using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011CA RID: 4554
[Preserve]
public class Lua_BlackJack_ProjectL_Common_BattleComponentCommon : LuaObject
{
	// Token: 0x06017999 RID: 96665 RVA: 0x006787CC File Offset: 0x006769CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon o = new BattleComponentCommon();
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

	// Token: 0x0601799A RID: 96666 RVA: 0x00678814 File Offset: 0x00676A14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			string name = battleComponentCommon.GetName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601799B RID: 96667 RVA: 0x00678868 File Offset: 0x00676A68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			battleComponentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601799C RID: 96668 RVA: 0x006788B4 File Offset: 0x00676AB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			battleComponentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601799D RID: 96669 RVA: 0x00678900 File Offset: 0x00676B00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			battleComponentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601799E RID: 96670 RVA: 0x0067894C File Offset: 0x00676B4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			battleComponentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601799F RID: 96671 RVA: 0x006789A4 File Offset: 0x00676BA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			battleComponentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179A0 RID: 96672 RVA: 0x006789F0 File Offset: 0x00676BF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsGameFunctionOpenByMonthCard(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			GameFunctionType gameFuncTypeId;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFuncTypeId);
			bool b = battleComponentCommon.IsGameFunctionOpenByMonthCard(gameFuncTypeId);
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

	// Token: 0x060179A1 RID: 96673 RVA: 0x00678A54 File Offset: 0x00676C54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDailyBonusMaxNums(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			GameFunctionType gameFuncTypeId;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFuncTypeId);
			int dailyBonusMaxNums = battleComponentCommon.GetDailyBonusMaxNums(gameFuncTypeId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dailyBonusMaxNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179A2 RID: 96674 RVA: 0x00678AB8 File Offset: 0x00676CB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSinglePveBattleFailEnergyCostByMonthCard(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			int singlePveBattleFailEnergyCostByMonthCard = battleComponentCommon.GetSinglePveBattleFailEnergyCostByMonthCard();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, singlePveBattleFailEnergyCostByMonthCard);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179A3 RID: 96675 RVA: 0x00678B0C File Offset: 0x00676D0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTeamPveBattleFailEnergyCost(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			GameFunctionType typeId;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out typeId);
			int locationId;
			LuaObject.checkType(l, 3, out locationId);
			int teamPveBattleFailEnergyCost = battleComponentCommon.GetTeamPveBattleFailEnergyCost(typeId, locationId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamPveBattleFailEnergyCost);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179A4 RID: 96676 RVA: 0x00678B7C File Offset: 0x00676D7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTeamPveBattleFailEnergyCostByMonthCard(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			GameFunctionType typeId;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out typeId);
			int locationId;
			LuaObject.checkType(l, 3, out locationId);
			int teamPveBattleFailEnergyCostByMonthCard = battleComponentCommon.GetTeamPveBattleFailEnergyCostByMonthCard(typeId, locationId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamPveBattleFailEnergyCostByMonthCard);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179A5 RID: 96677 RVA: 0x00678BEC File Offset: 0x00676DEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddTeamPveFightFailCompensationEnergyByMonthCard(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			GameFunctionType typeId;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out typeId);
			int locationId;
			LuaObject.checkType(l, 3, out locationId);
			battleComponentCommon.AddTeamPveFightFailCompensationEnergyByMonthCard(typeId, locationId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179A6 RID: 96678 RVA: 0x00678C50 File Offset: 0x00676E50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsWaypointBattling(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			bool b = battleComponentCommon.IsWaypointBattling();
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

	// Token: 0x060179A7 RID: 96679 RVA: 0x00678CA4 File Offset: 0x00676EA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsBattleWin(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			bool b = battleComponentCommon.IsBattleWin();
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

	// Token: 0x060179A8 RID: 96680 RVA: 0x00678CF8 File Offset: 0x00676EF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CancelBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			int i = battleComponentCommon.CancelBattle();
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

	// Token: 0x060179A9 RID: 96681 RVA: 0x00678D4C File Offset: 0x00676F4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsFighting(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			bool b = battleComponentCommon.IsFighting();
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

	// Token: 0x060179AA RID: 96682 RVA: 0x00678DA0 File Offset: 0x00676FA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanSetupMineTeam(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			bool b = battleComponentCommon.CanSetupMineTeam();
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

	// Token: 0x060179AB RID: 96683 RVA: 0x00678DF4 File Offset: 0x00676FF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FightFinished(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			GameFunctionStatus status;
			LuaObject.checkEnum<GameFunctionStatus>(l, 2, out status);
			bool win;
			LuaObject.checkType(l, 3, out win);
			bool needBatlleLog;
			LuaObject.checkType(l, 4, out needBatlleLog);
			battleComponentCommon.FightFinished(status, win, needBatlleLog);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179AC RID: 96684 RVA: 0x00678E68 File Offset: 0x00677068
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsWayPointFightExist(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			int wayPointId;
			LuaObject.checkType(l, 2, out wayPointId);
			bool b = battleComponentCommon.IsWayPointFightExist(wayPointId);
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

	// Token: 0x060179AD RID: 96685 RVA: 0x00678ECC File Offset: 0x006770CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WinPveBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			int battleId;
			LuaObject.checkType(l, 2, out battleId);
			battleComponentCommon.WinPveBattle(battleId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179AE RID: 96686 RVA: 0x00678F24 File Offset: 0x00677124
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FinishedArenaFight(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			battleComponentCommon.FinishedArenaFight();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179AF RID: 96687 RVA: 0x00678F70 File Offset: 0x00677170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetProcessingBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			ProcessingBattle processingBattle = battleComponentCommon.GetProcessingBattle();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, processingBattle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179B0 RID: 96688 RVA: 0x00678FC4 File Offset: 0x006771C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetProcessingBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			BattleType type;
			LuaObject.checkEnum<BattleType>(l, 2, out type);
			int typeId;
			LuaObject.checkType(l, 3, out typeId);
			battleComponentCommon.SetProcessingBattleInfo(type, typeId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179B1 RID: 96689 RVA: 0x00679028 File Offset: 0x00677228
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetBattleArmyRandomSeed(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			int battleArmyRandomSeed;
			LuaObject.checkType(l, 2, out battleArmyRandomSeed);
			battleComponentCommon.SetBattleArmyRandomSeed(battleArmyRandomSeed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179B2 RID: 96690 RVA: 0x00679080 File Offset: 0x00677280
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetBattleArmyRandomSeed(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			int battleArmyRandomSeed = battleComponentCommon.GetBattleArmyRandomSeed();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleArmyRandomSeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179B3 RID: 96691 RVA: 0x006790D4 File Offset: 0x006772D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetArenaBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			int arenaBattleInfo;
			LuaObject.checkType(l, 2, out arenaBattleInfo);
			battleComponentCommon.SetArenaBattleInfo(arenaBattleInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179B4 RID: 96692 RVA: 0x0067912C File Offset: 0x0067732C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsAttackingPveLevel(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 2, out battleType);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			bool b = battleComponentCommon.IsAttackingPveLevel(battleType, levelId);
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

	// Token: 0x060179B5 RID: 96693 RVA: 0x0067919C File Offset: 0x0067739C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsAttackingArenaOpponent(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			bool b = battleComponentCommon.IsAttackingArenaOpponent();
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

	// Token: 0x060179B6 RID: 96694 RVA: 0x006791F0 File Offset: 0x006773F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsArenaBattleInReady(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			bool b = battleComponentCommon.IsArenaBattleInReady();
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

	// Token: 0x060179B7 RID: 96695 RVA: 0x00679244 File Offset: 0x00677444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsAttackingInBattleServer(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			bool b = battleComponentCommon.IsAttackingInBattleServer();
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

	// Token: 0x060179B8 RID: 96696 RVA: 0x00679298 File Offset: 0x00677498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FinishBattleInBattleServer(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			battleComponentCommon.FinishBattleInBattleServer();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179B9 RID: 96697 RVA: 0x006792E4 File Offset: 0x006774E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanCreateBattleRoom(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			BattleRoomType battleRoomType;
			LuaObject.checkEnum<BattleRoomType>(l, 2, out battleRoomType);
			int i = battleComponentCommon.CanCreateBattleRoom(battleRoomType);
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

	// Token: 0x060179BA RID: 96698 RVA: 0x00679348 File Offset: 0x00677548
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanCreateTeamBattleRoom(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			int i = battleComponentCommon.CanCreateTeamBattleRoom();
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

	// Token: 0x060179BB RID: 96699 RVA: 0x0067939C File Offset: 0x0067759C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanChangePlayerBattleStatus(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			PlayerBattleStatus status;
			LuaObject.checkEnum<PlayerBattleStatus>(l, 2, out status);
			int i = battleComponentCommon.CanChangePlayerBattleStatus(status);
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

	// Token: 0x060179BC RID: 96700 RVA: 0x00679400 File Offset: 0x00677600
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetArenaBattleFighting(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			battleComponentCommon.SetArenaBattleFighting();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179BD RID: 96701 RVA: 0x0067944C File Offset: 0x0067764C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBattleId(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
				int battleId = battleComponentCommon.GetBattleId();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, battleId);
				result = 2;
			}
			else if (num == 3)
			{
				BattleComponentCommon battleComponentCommon2 = (BattleComponentCommon)LuaObject.checkSelf(l);
				GameFunctionType typeId;
				LuaObject.checkEnum<GameFunctionType>(l, 2, out typeId);
				int loctionId;
				LuaObject.checkType(l, 3, out loctionId);
				int battleId2 = battleComponentCommon2.GetBattleId(typeId, loctionId);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, battleId2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetBattleId to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179BE RID: 96702 RVA: 0x00679514 File Offset: 0x00677714
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetMonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			int monsterLevel = battleComponentCommon.GetMonsterLevel();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, monsterLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179BF RID: 96703 RVA: 0x00679568 File Offset: 0x00677768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddFightHeroFightNumsAndExp(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			List<int> heroes;
			LuaObject.checkType<List<int>>(l, 2, out heroes);
			int exp;
			LuaObject.checkType(l, 3, out exp);
			battleComponentCommon.AddFightHeroFightNumsAndExp(heroes, exp);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179C0 RID: 96704 RVA: 0x006795CC File Offset: 0x006777CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetPveTeam(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			List<int> pveTeam = battleComponentCommon.GetPveTeam();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pveTeam);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179C1 RID: 96705 RVA: 0x00679620 File Offset: 0x00677820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsMineTeamSetValid(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			int battleId;
			LuaObject.checkType(l, 2, out battleId);
			int battleType;
			LuaObject.checkType(l, 3, out battleType);
			List<int> fightHeroes;
			LuaObject.checkType<List<int>>(l, 4, out fightHeroes);
			int i = battleComponentCommon.IsMineTeamSetValid(battleId, battleType, fightHeroes);
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

	// Token: 0x060179C2 RID: 96706 RVA: 0x0067969C File Offset: 0x0067789C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsArenaDefensiveTeamSetValid(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			int battleId;
			LuaObject.checkType(l, 2, out battleId);
			int teamCount;
			LuaObject.checkType(l, 3, out teamCount);
			int i = battleComponentCommon.IsArenaDefensiveTeamSetValid(battleId, teamCount);
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

	// Token: 0x060179C3 RID: 96707 RVA: 0x0067970C File Offset: 0x0067790C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsActionPositionIndexValid(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			ConfigDataArenaBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataArenaBattleInfo>(l, 2, out battleInfo);
			int actionPositionIndex;
			LuaObject.checkType(l, 3, out actionPositionIndex);
			bool b = battleComponentCommon.IsActionPositionIndexValid(battleInfo, actionPositionIndex);
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

	// Token: 0x060179C4 RID: 96708 RVA: 0x0067977C File Offset: 0x0067797C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsActionValueValid(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			ConfigDataArenaBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataArenaBattleInfo>(l, 2, out battleInfo);
			int actionValue;
			LuaObject.checkType(l, 3, out actionValue);
			bool b = battleComponentCommon.IsActionValueValid(battleInfo, actionValue);
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

	// Token: 0x060179C5 RID: 96709 RVA: 0x006797EC File Offset: 0x006779EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetMineTeam(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			int battleId;
			LuaObject.checkType(l, 2, out battleId);
			int battleType;
			LuaObject.checkType(l, 3, out battleType);
			List<int> team;
			LuaObject.checkType<List<int>>(l, 4, out team);
			int i = battleComponentCommon.SetMineTeam(battleId, battleType, team);
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

	// Token: 0x060179C6 RID: 96710 RVA: 0x00679868 File Offset: 0x00677A68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTeam(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 2, out battleType);
			List<int> team;
			LuaObject.checkType<List<int>>(l, 3, out team);
			battleComponentCommon.SetTeam(battleType, team);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179C7 RID: 96711 RVA: 0x006798CC File Offset: 0x00677ACC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetTeam(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 2, out battleType);
			List<int> team = battleComponentCommon.GetTeam(battleType);
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

	// Token: 0x060179C8 RID: 96712 RVA: 0x00679930 File Offset: 0x00677B30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CreateMineBattleHeroEquipments(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			ulong[] equipmentIds;
			LuaObject.checkArray<ulong>(l, 2, out equipmentIds);
			List<BattleHeroEquipment> o = battleComponentCommon.CreateMineBattleHeroEquipments(equipmentIds);
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

	// Token: 0x060179C9 RID: 96713 RVA: 0x00679994 File Offset: 0x00677B94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeBattlePowerFromBattleHeroes(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			List<BattleHero> heroes;
			LuaObject.checkType<List<BattleHero>>(l, 2, out heroes);
			List<TrainingTech> techs;
			LuaObject.checkType<List<TrainingTech>>(l, 3, out techs);
			int i = battleComponentCommon.ComputeBattlePowerFromBattleHeroes(heroes, techs);
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

	// Token: 0x060179CA RID: 96714 RVA: 0x00679A04 File Offset: 0x00677C04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeBattlePower(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
				Hero hero;
				LuaObject.checkType<Hero>(l, 2, out hero);
				int i = battleComponentCommon.ComputeBattlePower(hero);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 3)
			{
				BattleComponentCommon battleComponentCommon2 = (BattleComponentCommon)LuaObject.checkSelf(l);
				BattleHero hero2;
				LuaObject.checkType<BattleHero>(l, 2, out hero2);
				List<TrainingTech> techs;
				LuaObject.checkType<List<TrainingTech>>(l, 3, out techs);
				int i2 = battleComponentCommon2.ComputeBattlePower(hero2, techs);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function ComputeBattlePower to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179CB RID: 96715 RVA: 0x00679ADC File Offset: 0x00677CDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddGotBattleTreasuresInThisBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			battleComponentCommon.AddGotBattleTreasuresInThisBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179CC RID: 96716 RVA: 0x00679B28 File Offset: 0x00677D28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddBattleTreasures(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 2, out battleTreasures);
			battleComponentCommon.AddBattleTreasures(battleTreasures);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179CD RID: 96717 RVA: 0x00679B80 File Offset: 0x00677D80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGainBattleTreasuresInThisBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			List<int> gainBattleTreasuresInThisBattle = battleComponentCommon.GetGainBattleTreasuresInThisBattle();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gainBattleTreasuresInThisBattle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179CE RID: 96718 RVA: 0x00679BD4 File Offset: 0x00677DD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllBattleBoxTreasuresInBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			ConfigDataBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 2, out battleInfo);
			List<Goods> allBattleBoxTreasuresInBattle = battleComponentCommon.GetAllBattleBoxTreasuresInBattle(battleInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allBattleBoxTreasuresInBattle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179CF RID: 96719 RVA: 0x00679C38 File Offset: 0x00677E38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattlePracticeMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			battleComponentCommon.OnBattlePracticeMissionEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179D0 RID: 96720 RVA: 0x00679C84 File Offset: 0x00677E84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDailyBonusAddNumsByMonthCard(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			GameFunctionType gameFuncTypeId;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFuncTypeId);
			int dailyBonusAddNumsByMonthCard = battleComponentCommon.m_luaExportHelper.GetDailyBonusAddNumsByMonthCard(gameFuncTypeId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dailyBonusAddNumsByMonthCard);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179D1 RID: 96721 RVA: 0x00679CEC File Offset: 0x00677EEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSinglePveBattleFightEnergyCost(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			int singlePveBattleFightEnergyCost = battleComponentCommon.m_luaExportHelper.GetSinglePveBattleFightEnergyCost();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, singlePveBattleFightEnergyCost);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179D2 RID: 96722 RVA: 0x00679D48 File Offset: 0x00677F48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetFightFailEnergyCostByMonthcard(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			int energyCost;
			LuaObject.checkType(l, 2, out energyCost);
			int fightFailEnergyCostByMonthcard = battleComponentCommon.m_luaExportHelper.GetFightFailEnergyCostByMonthcard(energyCost);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fightFailEnergyCostByMonthcard);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179D3 RID: 96723 RVA: 0x00679DB0 File Offset: 0x00677FB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddFightFailCompensationEnergyByMonthCard(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			int energyCost;
			LuaObject.checkType(l, 2, out energyCost);
			battleComponentCommon.m_luaExportHelper.AddFightFailCompensationEnergyByMonthCard(energyCost);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179D4 RID: 96724 RVA: 0x00679E0C File Offset: 0x0067800C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddSinglePveFightFailCompensationEnergyByMonthCard(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			battleComponentCommon.m_luaExportHelper.AddSinglePveFightFailCompensationEnergyByMonthCard();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179D5 RID: 96725 RVA: 0x00679E60 File Offset: 0x00678060
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnFlushBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			battleComponentCommon.m_luaExportHelper.OnFlushBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179D6 RID: 96726 RVA: 0x00679EB4 File Offset: 0x006780B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsTeamEmpty(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			List<int> team;
			LuaObject.checkType<List<int>>(l, 2, out team);
			bool b = battleComponentCommon.m_luaExportHelper.IsTeamEmpty(team);
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

	// Token: 0x060179D7 RID: 96727 RVA: 0x00679F1C File Offset: 0x0067811C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectJobMasterPropertyModifier(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			List<BattleHeroJob> jobs;
			LuaObject.checkType<List<BattleHeroJob>>(l, 2, out jobs);
			BattlePropertyModifier pm;
			LuaObject.checkType<BattlePropertyModifier>(l, 3, out pm);
			battleComponentCommon.m_luaExportHelper.CollectJobMasterPropertyModifier(jobs, pm);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179D8 RID: 96728 RVA: 0x00679F88 File Offset: 0x00678188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectEquipmentPropertyModifierAndSkillBattlePower(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			List<BattleHeroEquipment> equipments;
			LuaObject.checkType<List<BattleHeroEquipment>>(l, 2, out equipments);
			BattlePropertyModifier pm;
			LuaObject.checkType<BattlePropertyModifier>(l, 3, out pm);
			int i = battleComponentCommon.m_luaExportHelper.CollectEquipmentPropertyModifierAndSkillBattlePower(equipments, pm);
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

	// Token: 0x060179D9 RID: 96729 RVA: 0x00679FFC File Offset: 0x006781FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CollectPassiveSkillStaticPropertyModifier(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			BattlePropertyModifier pm;
			LuaObject.checkType<BattlePropertyModifier>(l, 3, out pm);
			battleComponentCommon.m_luaExportHelper.CollectPassiveSkillStaticPropertyModifier(skillInfo, pm);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179DA RID: 96730 RVA: 0x0067A068 File Offset: 0x00678268
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CollectStaticPropertyModifier(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			PropertyModifyType modifyType;
			LuaObject.checkEnum<PropertyModifyType>(l, 2, out modifyType);
			int value;
			LuaObject.checkType(l, 3, out value);
			BattlePropertyModifier pm;
			LuaObject.checkType<BattlePropertyModifier>(l, 4, out pm);
			battleComponentCommon.m_luaExportHelper.CollectStaticPropertyModifier(modifyType, value, pm);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179DB RID: 96731 RVA: 0x0067A0E0 File Offset: 0x006782E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitGainBattleTreasures(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			battleComponentCommon.m_luaExportHelper.InitGainBattleTreasures();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179DC RID: 96732 RVA: 0x0067A134 File Offset: 0x00678334
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_BattlePracticeMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			battleComponentCommon.m_luaExportHelper.__callDele_BattlePracticeMissionEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179DD RID: 96733 RVA: 0x0067A188 File Offset: 0x00678388
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_BattlePracticeMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			battleComponentCommon.m_luaExportHelper.__clearDele_BattlePracticeMissionEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179DE RID: 96734 RVA: 0x0067A1DC File Offset: 0x006783DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectJobPropertyModifier_s(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo jobInfo;
			LuaObject.checkType<ConfigDataJobInfo>(l, 1, out jobInfo);
			BattlePropertyModifier pm;
			LuaObject.checkType<BattlePropertyModifier>(l, 2, out pm);
			BattleComponentCommon.LuaExportHelper.CollectJobPropertyModifier(jobInfo, pm);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179DF RID: 96735 RVA: 0x0067A234 File Offset: 0x00678434
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_gotBattleTreasureIds(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleComponentCommon.m_gotBattleTreasureIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179E0 RID: 96736 RVA: 0x0067A288 File Offset: 0x00678488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_gotBattleTreasureIds(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			List<int> gotBattleTreasureIds;
			LuaObject.checkType<List<int>>(l, 2, out gotBattleTreasureIds);
			battleComponentCommon.m_gotBattleTreasureIds = gotBattleTreasureIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179E1 RID: 96737 RVA: 0x0067A2E0 File Offset: 0x006784E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleComponentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179E2 RID: 96738 RVA: 0x0067A338 File Offset: 0x00678538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			battleComponentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179E3 RID: 96739 RVA: 0x0067A394 File Offset: 0x00678594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleComponentCommon.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179E4 RID: 96740 RVA: 0x0067A3EC File Offset: 0x006785EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			HeroComponentCommon hero;
			LuaObject.checkType<HeroComponentCommon>(l, 2, out hero);
			battleComponentCommon.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179E5 RID: 96741 RVA: 0x0067A448 File Offset: 0x00678648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_level(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleComponentCommon.m_luaExportHelper.m_level);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179E6 RID: 96742 RVA: 0x0067A4A0 File Offset: 0x006786A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_level(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			LevelComponentCommon level;
			LuaObject.checkType<LevelComponentCommon>(l, 2, out level);
			battleComponentCommon.m_luaExportHelper.m_level = level;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179E7 RID: 96743 RVA: 0x0067A4FC File Offset: 0x006786FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arena(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleComponentCommon.m_luaExportHelper.m_arena);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179E8 RID: 96744 RVA: 0x0067A554 File Offset: 0x00678754
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_arena(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			ArenaComponentCommon arena;
			LuaObject.checkType<ArenaComponentCommon>(l, 2, out arena);
			battleComponentCommon.m_luaExportHelper.m_arena = arena;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179E9 RID: 96745 RVA: 0x0067A5B0 File Offset: 0x006787B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_guild(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleComponentCommon.m_luaExportHelper.m_guild);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179EA RID: 96746 RVA: 0x0067A608 File Offset: 0x00678808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guild(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			GuildComponentCommon guild;
			LuaObject.checkType<GuildComponentCommon>(l, 2, out guild);
			battleComponentCommon.m_luaExportHelper.m_guild = guild;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179EB RID: 96747 RVA: 0x0067A664 File Offset: 0x00678864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_realtimePVP(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleComponentCommon.m_luaExportHelper.m_realtimePVP);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179EC RID: 96748 RVA: 0x0067A6BC File Offset: 0x006788BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_realtimePVP(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			RealTimePVPComponentCommon realtimePVP;
			LuaObject.checkType<RealTimePVPComponentCommon>(l, 2, out realtimePVP);
			battleComponentCommon.m_luaExportHelper.m_realtimePVP = realtimePVP;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179ED RID: 96749 RVA: 0x0067A718 File Offset: 0x00678918
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_bag(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleComponentCommon.m_luaExportHelper.m_bag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179EE RID: 96750 RVA: 0x0067A770 File Offset: 0x00678970
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_bag(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			BagComponentCommon bag;
			LuaObject.checkType<BagComponentCommon>(l, 2, out bag);
			battleComponentCommon.m_luaExportHelper.m_bag = bag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179EF RID: 96751 RVA: 0x0067A7CC File Offset: 0x006789CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleComponentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179F0 RID: 96752 RVA: 0x0067A824 File Offset: 0x00678A24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			battleComponentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179F1 RID: 96753 RVA: 0x0067A880 File Offset: 0x00678A80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_team(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleComponentCommon.m_luaExportHelper.m_team);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179F2 RID: 96754 RVA: 0x0067A8D8 File Offset: 0x00678AD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_team(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			TeamComponentCommon team;
			LuaObject.checkType<TeamComponentCommon>(l, 2, out team);
			battleComponentCommon.m_luaExportHelper.m_team = team;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179F3 RID: 96755 RVA: 0x0067A934 File Offset: 0x00678B34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_trainingGround(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleComponentCommon.m_luaExportHelper.m_trainingGround);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179F4 RID: 96756 RVA: 0x0067A98C File Offset: 0x00678B8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_trainingGround(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			TrainingGroundCompomentCommon trainingGround;
			LuaObject.checkType<TrainingGroundCompomentCommon>(l, 2, out trainingGround);
			battleComponentCommon.m_luaExportHelper.m_trainingGround = trainingGround;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179F5 RID: 96757 RVA: 0x0067A9E8 File Offset: 0x00678BE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_resource(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleComponentCommon.m_luaExportHelper.m_resource);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179F6 RID: 96758 RVA: 0x0067AA40 File Offset: 0x00678C40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_resource(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			ResourceComponentCommon resource;
			LuaObject.checkType<ResourceComponentCommon>(l, 2, out resource);
			battleComponentCommon.m_luaExportHelper.m_resource = resource;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179F7 RID: 96759 RVA: 0x0067AA9C File Offset: 0x00678C9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_battleDS(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleComponentCommon.m_luaExportHelper.m_battleDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179F8 RID: 96760 RVA: 0x0067AAF4 File Offset: 0x00678CF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleDS(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			DataSectionBattle battleDS;
			LuaObject.checkType<DataSectionBattle>(l, 2, out battleDS);
			battleComponentCommon.m_luaExportHelper.m_battleDS = battleDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179F9 RID: 96761 RVA: 0x0067AB50 File Offset: 0x00678D50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_battle(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleComponentCommon.m_luaExportHelper.m_battle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179FA RID: 96762 RVA: 0x0067ABA8 File Offset: 0x00678DA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_battle(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			BattleBase battle;
			LuaObject.checkType<BattleBase>(l, 2, out battle);
			battleComponentCommon.m_luaExportHelper.m_battle = battle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179FB RID: 96763 RVA: 0x0067AC04 File Offset: 0x00678E04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_propertyModifier(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleComponentCommon.m_luaExportHelper.m_propertyModifier);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179FC RID: 96764 RVA: 0x0067AC5C File Offset: 0x00678E5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_propertyModifier(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			BattlePropertyModifier propertyModifier;
			LuaObject.checkType<BattlePropertyModifier>(l, 2, out propertyModifier);
			battleComponentCommon.m_luaExportHelper.m_propertyModifier = propertyModifier;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179FD RID: 96765 RVA: 0x0067ACB8 File Offset: 0x00678EB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_battleProperty(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleComponentCommon.m_luaExportHelper.m_battleProperty);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179FE RID: 96766 RVA: 0x0067AD10 File Offset: 0x00678F10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_battleProperty(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			BattleProperty battleProperty;
			LuaObject.checkType<BattleProperty>(l, 2, out battleProperty);
			battleComponentCommon.m_luaExportHelper.m_battleProperty = battleProperty;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060179FF RID: 96767 RVA: 0x0067AD6C File Offset: 0x00678F6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BattlePracticeMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleComponentCommon.BattlePracticeMissionEvent += value;
				}
				else if (num == 2)
				{
					battleComponentCommon.BattlePracticeMissionEvent -= value;
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

	// Token: 0x06017A00 RID: 96768 RVA: 0x0067ADEC File Offset: 0x00678FEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleComponentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A01 RID: 96769 RVA: 0x0067AE40 File Offset: 0x00679040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			battleComponentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A02 RID: 96770 RVA: 0x0067AE98 File Offset: 0x00679098
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BattleRandomSeed(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleComponentCommon.BattleRandomSeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A03 RID: 96771 RVA: 0x0067AEEC File Offset: 0x006790EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ArmyRandomSeed(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleComponentCommon.ArmyRandomSeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A04 RID: 96772 RVA: 0x0067AF40 File Offset: 0x00679140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ProcessingScenarioId(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleComponentCommon.ProcessingScenarioId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A05 RID: 96773 RVA: 0x0067AF94 File Offset: 0x00679194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ArenaBattleRandomSeed(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleComponentCommon.ArenaBattleRandomSeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A06 RID: 96774 RVA: 0x0067AFE8 File Offset: 0x006791E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleRoomId(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleComponentCommon.BattleRoomId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A07 RID: 96775 RVA: 0x0067B03C File Offset: 0x0067923C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BattleRoomId(IntPtr l)
	{
		int result;
		try
		{
			BattleComponentCommon battleComponentCommon = (BattleComponentCommon)LuaObject.checkSelf(l);
			ulong battleRoomId;
			LuaObject.checkType(l, 2, out battleRoomId);
			battleComponentCommon.BattleRoomId = battleRoomId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A08 RID: 96776 RVA: 0x0067B094 File Offset: 0x00679294
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.BattleComponentCommon");
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.IsGameFunctionOpenByMonthCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.GetDailyBonusMaxNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.GetSinglePveBattleFailEnergyCostByMonthCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.GetTeamPveBattleFailEnergyCost);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.GetTeamPveBattleFailEnergyCostByMonthCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.AddTeamPveFightFailCompensationEnergyByMonthCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.IsWaypointBattling);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.IsBattleWin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.CancelBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.IsFighting);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.CanSetupMineTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.FightFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.IsWayPointFightExist);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.WinPveBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.FinishedArenaFight);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.GetProcessingBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.SetProcessingBattleInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.SetBattleArmyRandomSeed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.GetBattleArmyRandomSeed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.SetArenaBattleInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.IsAttackingPveLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.IsAttackingArenaOpponent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.IsArenaBattleInReady);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.IsAttackingInBattleServer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.FinishBattleInBattleServer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.CanCreateBattleRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.CanCreateTeamBattleRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.CanChangePlayerBattleStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.SetArenaBattleFighting);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.GetBattleId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.GetMonsterLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.AddFightHeroFightNumsAndExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.GetPveTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.IsMineTeamSetValid);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.IsArenaDefensiveTeamSetValid);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.IsActionPositionIndexValid);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.IsActionValueValid);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.SetMineTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.SetTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.GetTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.CreateMineBattleHeroEquipments);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.ComputeBattlePowerFromBattleHeroes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.ComputeBattlePower);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.AddGotBattleTreasuresInThisBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.AddBattleTreasures);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.GetGainBattleTreasuresInThisBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.GetAllBattleBoxTreasuresInBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.OnBattlePracticeMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.GetDailyBonusAddNumsByMonthCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.GetSinglePveBattleFightEnergyCost);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.GetFightFailEnergyCostByMonthcard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.AddFightFailCompensationEnergyByMonthCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.AddSinglePveFightFailCompensationEnergyByMonthCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.OnFlushBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.IsTeamEmpty);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.CollectJobMasterPropertyModifier);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.CollectEquipmentPropertyModifierAndSkillBattlePower);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.CollectPassiveSkillStaticPropertyModifier);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.CollectStaticPropertyModifier);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.InitGainBattleTreasures);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.__callDele_BattlePracticeMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.__clearDele_BattlePracticeMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.CollectJobPropertyModifier_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache44);
		string name = "m_gotBattleTreasureIds";
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.get_m_gotBattleTreasureIds);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.set_m_gotBattleTreasureIds);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache46, true);
		string name2 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache48, true);
		string name3 = "m_hero";
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.get_m_hero);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.set_m_hero);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache4A, true);
		string name4 = "m_level";
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.get_m_level);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.set_m_level);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache4C, true);
		string name5 = "m_arena";
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.get_m_arena);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.set_m_arena);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache4E, true);
		string name6 = "m_guild";
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.get_m_guild);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.set_m_guild);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache50, true);
		string name7 = "m_realtimePVP";
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.get_m_realtimePVP);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.set_m_realtimePVP);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache52, true);
		string name8 = "m_bag";
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.get_m_bag);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.set_m_bag);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache54, true);
		string name9 = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.get_m_basicInfo);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache56, true);
		string name10 = "m_team";
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.get_m_team);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.set_m_team);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache58, true);
		string name11 = "m_trainingGround";
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.get_m_trainingGround);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.set_m_trainingGround);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache5A, true);
		string name12 = "m_resource";
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.get_m_resource);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.set_m_resource);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache5C, true);
		string name13 = "m_battleDS";
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.get_m_battleDS);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.set_m_battleDS);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache5E, true);
		string name14 = "m_battle";
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.get_m_battle);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.set_m_battle);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache60, true);
		string name15 = "m_propertyModifier";
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.get_m_propertyModifier);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.set_m_propertyModifier);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache62, true);
		string name16 = "m_battleProperty";
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.get_m_battleProperty);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.set_m_battleProperty);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache64, true);
		string name17 = "BattlePracticeMissionEvent";
		LuaCSFunction get17 = null;
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.set_BattlePracticeMissionEvent);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache65, true);
		string name18 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.get_Owner);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache66;
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.set_Owner);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache67, true);
		string name19 = "BattleRandomSeed";
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.get_BattleRandomSeed);
		}
		LuaObject.addMember(l, name19, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache68, null, true);
		string name20 = "ArmyRandomSeed";
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.get_ArmyRandomSeed);
		}
		LuaObject.addMember(l, name20, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache69, null, true);
		string name21 = "ProcessingScenarioId";
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.get_ProcessingScenarioId);
		}
		LuaObject.addMember(l, name21, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache6A, null, true);
		string name22 = "ArenaBattleRandomSeed";
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.get_ArenaBattleRandomSeed);
		}
		LuaObject.addMember(l, name22, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache6B, null, true);
		string name23 = "BattleRoomId";
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.get_BattleRoomId);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache6C;
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.set_BattleRoomId);
		}
		LuaObject.addMember(l, name23, get19, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache6D, true);
		if (Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_BattleComponentCommon.<>f__mg$cache6E, typeof(BattleComponentCommon));
	}

	// Token: 0x0400DFE7 RID: 57319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DFE8 RID: 57320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DFE9 RID: 57321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DFEA RID: 57322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DFEB RID: 57323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DFEC RID: 57324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DFED RID: 57325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DFEE RID: 57326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DFEF RID: 57327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400DFF0 RID: 57328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400DFF1 RID: 57329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400DFF2 RID: 57330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400DFF3 RID: 57331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400DFF4 RID: 57332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400DFF5 RID: 57333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400DFF6 RID: 57334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400DFF7 RID: 57335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400DFF8 RID: 57336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400DFF9 RID: 57337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400DFFA RID: 57338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400DFFB RID: 57339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400DFFC RID: 57340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400DFFD RID: 57341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400DFFE RID: 57342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400DFFF RID: 57343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400E000 RID: 57344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400E001 RID: 57345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400E002 RID: 57346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400E003 RID: 57347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400E004 RID: 57348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400E005 RID: 57349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400E006 RID: 57350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400E007 RID: 57351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400E008 RID: 57352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400E009 RID: 57353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400E00A RID: 57354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400E00B RID: 57355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400E00C RID: 57356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400E00D RID: 57357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400E00E RID: 57358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400E00F RID: 57359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400E010 RID: 57360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400E011 RID: 57361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400E012 RID: 57362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400E013 RID: 57363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400E014 RID: 57364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400E015 RID: 57365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400E016 RID: 57366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400E017 RID: 57367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400E018 RID: 57368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400E019 RID: 57369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400E01A RID: 57370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400E01B RID: 57371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400E01C RID: 57372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400E01D RID: 57373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400E01E RID: 57374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400E01F RID: 57375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400E020 RID: 57376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400E021 RID: 57377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400E022 RID: 57378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400E023 RID: 57379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400E024 RID: 57380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400E025 RID: 57381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400E026 RID: 57382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400E027 RID: 57383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400E028 RID: 57384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400E029 RID: 57385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400E02A RID: 57386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400E02B RID: 57387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400E02C RID: 57388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0400E02D RID: 57389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0400E02E RID: 57390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0400E02F RID: 57391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0400E030 RID: 57392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0400E031 RID: 57393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0400E032 RID: 57394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0400E033 RID: 57395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0400E034 RID: 57396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0400E035 RID: 57397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0400E036 RID: 57398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x0400E037 RID: 57399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x0400E038 RID: 57400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x0400E039 RID: 57401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x0400E03A RID: 57402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0400E03B RID: 57403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x0400E03C RID: 57404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x0400E03D RID: 57405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x0400E03E RID: 57406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0400E03F RID: 57407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x0400E040 RID: 57408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x0400E041 RID: 57409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x0400E042 RID: 57410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0400E043 RID: 57411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x0400E044 RID: 57412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x0400E045 RID: 57413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x0400E046 RID: 57414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x0400E047 RID: 57415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x0400E048 RID: 57416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x0400E049 RID: 57417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x0400E04A RID: 57418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x0400E04B RID: 57419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x0400E04C RID: 57420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x0400E04D RID: 57421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x0400E04E RID: 57422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x0400E04F RID: 57423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x0400E050 RID: 57424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x0400E051 RID: 57425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x0400E052 RID: 57426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x0400E053 RID: 57427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x0400E054 RID: 57428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x0400E055 RID: 57429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;
}
