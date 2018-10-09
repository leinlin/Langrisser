using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012E0 RID: 4832
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus : LuaObject
{
	// Token: 0x06019FEF RID: 106479 RVA: 0x0079F0F8 File Offset: 0x0079D2F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RewardPlayerStatus o = new RewardPlayerStatus();
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

	// Token: 0x06019FF0 RID: 106480 RVA: 0x0079F140 File Offset: 0x0079D340
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Clear(IntPtr l)
	{
		int result;
		try
		{
			RewardPlayerStatus rewardPlayerStatus = (RewardPlayerStatus)LuaObject.checkSelf(l);
			rewardPlayerStatus.Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FF1 RID: 106481 RVA: 0x0079F18C File Offset: 0x0079D38C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Level(IntPtr l)
	{
		int result;
		try
		{
			RewardPlayerStatus rewardPlayerStatus = (RewardPlayerStatus)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardPlayerStatus.Level);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FF2 RID: 106482 RVA: 0x0079F1E0 File Offset: 0x0079D3E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Level(IntPtr l)
	{
		int result;
		try
		{
			RewardPlayerStatus rewardPlayerStatus = (RewardPlayerStatus)LuaObject.checkSelf(l);
			int level;
			LuaObject.checkType(l, 2, out level);
			rewardPlayerStatus.Level = level;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FF3 RID: 106483 RVA: 0x0079F238 File Offset: 0x0079D438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Exp(IntPtr l)
	{
		int result;
		try
		{
			RewardPlayerStatus rewardPlayerStatus = (RewardPlayerStatus)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardPlayerStatus.Exp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FF4 RID: 106484 RVA: 0x0079F28C File Offset: 0x0079D48C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Exp(IntPtr l)
	{
		int result;
		try
		{
			RewardPlayerStatus rewardPlayerStatus = (RewardPlayerStatus)LuaObject.checkSelf(l);
			int exp;
			LuaObject.checkType(l, 2, out exp);
			rewardPlayerStatus.Exp = exp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FF5 RID: 106485 RVA: 0x0079F2E4 File Offset: 0x0079D4E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NextLevelExp(IntPtr l)
	{
		int result;
		try
		{
			RewardPlayerStatus rewardPlayerStatus = (RewardPlayerStatus)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardPlayerStatus.NextLevelExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FF6 RID: 106486 RVA: 0x0079F338 File Offset: 0x0079D538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_NextLevelExp(IntPtr l)
	{
		int result;
		try
		{
			RewardPlayerStatus rewardPlayerStatus = (RewardPlayerStatus)LuaObject.checkSelf(l);
			int nextLevelExp;
			LuaObject.checkType(l, 2, out nextLevelExp);
			rewardPlayerStatus.NextLevelExp = nextLevelExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FF7 RID: 106487 RVA: 0x0079F390 File Offset: 0x0079D590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Energy(IntPtr l)
	{
		int result;
		try
		{
			RewardPlayerStatus rewardPlayerStatus = (RewardPlayerStatus)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardPlayerStatus.Energy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FF8 RID: 106488 RVA: 0x0079F3E4 File Offset: 0x0079D5E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Energy(IntPtr l)
	{
		int result;
		try
		{
			RewardPlayerStatus rewardPlayerStatus = (RewardPlayerStatus)LuaObject.checkSelf(l);
			int energy;
			LuaObject.checkType(l, 2, out energy);
			rewardPlayerStatus.Energy = energy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FF9 RID: 106489 RVA: 0x0079F43C File Offset: 0x0079D63C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ArenaVictoryPoints(IntPtr l)
	{
		int result;
		try
		{
			RewardPlayerStatus rewardPlayerStatus = (RewardPlayerStatus)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardPlayerStatus.ArenaVictoryPoints);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FFA RID: 106490 RVA: 0x0079F490 File Offset: 0x0079D690
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ArenaVictoryPoints(IntPtr l)
	{
		int result;
		try
		{
			RewardPlayerStatus rewardPlayerStatus = (RewardPlayerStatus)LuaObject.checkSelf(l);
			int arenaVictoryPoints;
			LuaObject.checkType(l, 2, out arenaVictoryPoints);
			rewardPlayerStatus.ArenaVictoryPoints = arenaVictoryPoints;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FFB RID: 106491 RVA: 0x0079F4E8 File Offset: 0x0079D6E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ArenaLevelID(IntPtr l)
	{
		int result;
		try
		{
			RewardPlayerStatus rewardPlayerStatus = (RewardPlayerStatus)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardPlayerStatus.ArenaLevelID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FFC RID: 106492 RVA: 0x0079F53C File Offset: 0x0079D73C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ArenaLevelID(IntPtr l)
	{
		int result;
		try
		{
			RewardPlayerStatus rewardPlayerStatus = (RewardPlayerStatus)LuaObject.checkSelf(l);
			int arenaLevelID;
			LuaObject.checkType(l, 2, out arenaLevelID);
			rewardPlayerStatus.ArenaLevelID = arenaLevelID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FFD RID: 106493 RVA: 0x0079F594 File Offset: 0x0079D794
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RealTimePVPScore(IntPtr l)
	{
		int result;
		try
		{
			RewardPlayerStatus rewardPlayerStatus = (RewardPlayerStatus)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardPlayerStatus.RealTimePVPScore);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FFE RID: 106494 RVA: 0x0079F5E8 File Offset: 0x0079D7E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RealTimePVPScore(IntPtr l)
	{
		int result;
		try
		{
			RewardPlayerStatus rewardPlayerStatus = (RewardPlayerStatus)LuaObject.checkSelf(l);
			int realTimePVPScore;
			LuaObject.checkType(l, 2, out realTimePVPScore);
			rewardPlayerStatus.RealTimePVPScore = realTimePVPScore;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FFF RID: 106495 RVA: 0x0079F640 File Offset: 0x0079D840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RealTimePVPDan(IntPtr l)
	{
		int result;
		try
		{
			RewardPlayerStatus rewardPlayerStatus = (RewardPlayerStatus)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardPlayerStatus.RealTimePVPDan);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A000 RID: 106496 RVA: 0x0079F694 File Offset: 0x0079D894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RealTimePVPDan(IntPtr l)
	{
		int result;
		try
		{
			RewardPlayerStatus rewardPlayerStatus = (RewardPlayerStatus)LuaObject.checkSelf(l);
			int realTimePVPDan;
			LuaObject.checkType(l, 2, out realTimePVPDan);
			rewardPlayerStatus.RealTimePVPDan = realTimePVPDan;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A001 RID: 106497 RVA: 0x0079F6EC File Offset: 0x0079D8EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RealTimePVPIsPromotion(IntPtr l)
	{
		int result;
		try
		{
			RewardPlayerStatus rewardPlayerStatus = (RewardPlayerStatus)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardPlayerStatus.RealTimePVPIsPromotion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A002 RID: 106498 RVA: 0x0079F740 File Offset: 0x0079D940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RealTimePVPIsPromotion(IntPtr l)
	{
		int result;
		try
		{
			RewardPlayerStatus rewardPlayerStatus = (RewardPlayerStatus)LuaObject.checkSelf(l);
			bool realTimePVPIsPromotion;
			LuaObject.checkType(l, 2, out realTimePVPIsPromotion);
			rewardPlayerStatus.RealTimePVPIsPromotion = realTimePVPIsPromotion;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A003 RID: 106499 RVA: 0x0079F798 File Offset: 0x0079D998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RealtTimePVPBattleMode(IntPtr l)
	{
		int result;
		try
		{
			RewardPlayerStatus rewardPlayerStatus = (RewardPlayerStatus)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)rewardPlayerStatus.RealtTimePVPBattleMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A004 RID: 106500 RVA: 0x0079F7EC File Offset: 0x0079D9EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RealtTimePVPBattleMode(IntPtr l)
	{
		int result;
		try
		{
			RewardPlayerStatus rewardPlayerStatus = (RewardPlayerStatus)LuaObject.checkSelf(l);
			BattleMode realtTimePVPBattleMode;
			LuaObject.checkEnum<BattleMode>(l, 2, out realtTimePVPBattleMode);
			rewardPlayerStatus.RealtTimePVPBattleMode = realtTimePVPBattleMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A005 RID: 106501 RVA: 0x0079F844 File Offset: 0x0079DA44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ClimbTowerFinishedFloorId(IntPtr l)
	{
		int result;
		try
		{
			RewardPlayerStatus rewardPlayerStatus = (RewardPlayerStatus)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardPlayerStatus.ClimbTowerFinishedFloorId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A006 RID: 106502 RVA: 0x0079F898 File Offset: 0x0079DA98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ClimbTowerFinishedFloorId(IntPtr l)
	{
		int result;
		try
		{
			RewardPlayerStatus rewardPlayerStatus = (RewardPlayerStatus)LuaObject.checkSelf(l);
			int climbTowerFinishedFloorId;
			LuaObject.checkType(l, 2, out climbTowerFinishedFloorId);
			rewardPlayerStatus.ClimbTowerFinishedFloorId = climbTowerFinishedFloorId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A007 RID: 106503 RVA: 0x0079F8F0 File Offset: 0x0079DAF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GuildMassiveCombatEliminateRate(IntPtr l)
	{
		int result;
		try
		{
			RewardPlayerStatus rewardPlayerStatus = (RewardPlayerStatus)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardPlayerStatus.GuildMassiveCombatEliminateRate);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A008 RID: 106504 RVA: 0x0079F944 File Offset: 0x0079DB44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GuildMassiveCombatEliminateRate(IntPtr l)
	{
		int result;
		try
		{
			RewardPlayerStatus rewardPlayerStatus = (RewardPlayerStatus)LuaObject.checkSelf(l);
			int guildMassiveCombatEliminateRate;
			LuaObject.checkType(l, 2, out guildMassiveCombatEliminateRate);
			rewardPlayerStatus.GuildMassiveCombatEliminateRate = guildMassiveCombatEliminateRate;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A009 RID: 106505 RVA: 0x0079F99C File Offset: 0x0079DB9C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.RewardPlayerStatus");
		if (Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache0);
		string name = "Level";
		if (Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.get_Level);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache1;
		if (Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.set_Level);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache2, true);
		string name2 = "Exp";
		if (Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.get_Exp);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.set_Exp);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache4, true);
		string name3 = "NextLevelExp";
		if (Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.get_NextLevelExp);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.set_NextLevelExp);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache6, true);
		string name4 = "Energy";
		if (Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.get_Energy);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache7;
		if (Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.set_Energy);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache8, true);
		string name5 = "ArenaVictoryPoints";
		if (Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.get_ArenaVictoryPoints);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache9;
		if (Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.set_ArenaVictoryPoints);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cacheA, true);
		string name6 = "ArenaLevelID";
		if (Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.get_ArenaLevelID);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cacheB;
		if (Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.set_ArenaLevelID);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cacheC, true);
		string name7 = "RealTimePVPScore";
		if (Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.get_RealTimePVPScore);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cacheD;
		if (Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.set_RealTimePVPScore);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cacheE, true);
		string name8 = "RealTimePVPDan";
		if (Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.get_RealTimePVPDan);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.set_RealTimePVPDan);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache10, true);
		string name9 = "RealTimePVPIsPromotion";
		if (Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.get_RealTimePVPIsPromotion);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.set_RealTimePVPIsPromotion);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache12, true);
		string name10 = "RealtTimePVPBattleMode";
		if (Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.get_RealtTimePVPBattleMode);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.set_RealtTimePVPBattleMode);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache14, true);
		string name11 = "ClimbTowerFinishedFloorId";
		if (Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.get_ClimbTowerFinishedFloorId);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.set_ClimbTowerFinishedFloorId);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache16, true);
		string name12 = "GuildMassiveCombatEliminateRate";
		if (Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.get_GuildMassiveCombatEliminateRate);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.set_GuildMassiveCombatEliminateRate);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache18, true);
		if (Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.<>f__mg$cache19, typeof(RewardPlayerStatus));
	}

	// Token: 0x04010411 RID: 66577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010412 RID: 66578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010413 RID: 66579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010414 RID: 66580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010415 RID: 66581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010416 RID: 66582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010417 RID: 66583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010418 RID: 66584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010419 RID: 66585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401041A RID: 66586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401041B RID: 66587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401041C RID: 66588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401041D RID: 66589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401041E RID: 66590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401041F RID: 66591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010420 RID: 66592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04010421 RID: 66593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04010422 RID: 66594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04010423 RID: 66595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04010424 RID: 66596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04010425 RID: 66597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04010426 RID: 66598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04010427 RID: 66599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04010428 RID: 66600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04010429 RID: 66601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401042A RID: 66602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;
}
