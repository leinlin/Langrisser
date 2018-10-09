using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011F4 RID: 4596
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionArena : LuaObject
{
	// Token: 0x06017D4A RID: 97610 RVA: 0x006930B4 File Offset: 0x006912B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArena o = new DataSectionArena();
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

	// Token: 0x06017D4B RID: 97611 RVA: 0x006930FC File Offset: 0x006912FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitArenaPlayerInfo(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArena dataSectionArena = (DataSectionArena)LuaObject.checkSelf(l);
			ArenaPlayerInfo info;
			LuaObject.checkType<ArenaPlayerInfo>(l, 2, out info);
			dataSectionArena.InitArenaPlayerInfo(info);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D4C RID: 97612 RVA: 0x00693154 File Offset: 0x00691354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArena dataSectionArena = (DataSectionArena)LuaObject.checkSelf(l);
			dataSectionArena.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D4D RID: 97613 RVA: 0x006931A0 File Offset: 0x006913A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SerializeToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArena dataSectionArena = (DataSectionArena)LuaObject.checkSelf(l);
			object o = dataSectionArena.SerializeToClient();
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

	// Token: 0x06017D4E RID: 97614 RVA: 0x006931F4 File Offset: 0x006913F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsEmptyArenaPlayerInfo(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArena dataSectionArena = (DataSectionArena)LuaObject.checkSelf(l);
			bool b = dataSectionArena.IsEmptyArenaPlayerInfo();
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

	// Token: 0x06017D4F RID: 97615 RVA: 0x00693248 File Offset: 0x00691448
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetDefensiveTeam(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArena dataSectionArena = (DataSectionArena)LuaObject.checkSelf(l);
			ArenaPlayerDefensiveTeam defensiveTeam;
			LuaObject.checkType<ArenaPlayerDefensiveTeam>(l, 2, out defensiveTeam);
			dataSectionArena.SetDefensiveTeam(defensiveTeam);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D50 RID: 97616 RVA: 0x006932A0 File Offset: 0x006914A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetWeekLastFlushTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArena dataSectionArena = (DataSectionArena)LuaObject.checkSelf(l);
			DateTime weekLastFlushTime;
			LuaObject.checkValueType<DateTime>(l, 2, out weekLastFlushTime);
			dataSectionArena.SetWeekLastFlushTime(weekLastFlushTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D51 RID: 97617 RVA: 0x006932F8 File Offset: 0x006914F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetThisWeekBattleIds(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArena dataSectionArena = (DataSectionArena)LuaObject.checkSelf(l);
			List<int> thisWeekBattleIds;
			LuaObject.checkType<List<int>>(l, 2, out thisWeekBattleIds);
			dataSectionArena.SetThisWeekBattleIds(thisWeekBattleIds);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D52 RID: 97618 RVA: 0x00693350 File Offset: 0x00691550
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetDefensiveBattleId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArena dataSectionArena = (DataSectionArena)LuaObject.checkSelf(l);
			byte defensiveBattleId;
			LuaObject.checkType(l, 2, out defensiveBattleId);
			dataSectionArena.SetDefensiveBattleId(defensiveBattleId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D53 RID: 97619 RVA: 0x006933A8 File Offset: 0x006915A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetDefensiveRuleId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArena dataSectionArena = (DataSectionArena)LuaObject.checkSelf(l);
			byte defensiveRuleId;
			LuaObject.checkType(l, 2, out defensiveRuleId);
			dataSectionArena.SetDefensiveRuleId(defensiveRuleId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D54 RID: 97620 RVA: 0x00693400 File Offset: 0x00691600
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddVictoryPoints(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArena dataSectionArena = (DataSectionArena)LuaObject.checkSelf(l);
			int points;
			LuaObject.checkType(l, 2, out points);
			dataSectionArena.AddVictoryPoints(points);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D55 RID: 97621 RVA: 0x00693458 File Offset: 0x00691658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCurrentVictoryPoints(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArena dataSectionArena = (DataSectionArena)LuaObject.checkSelf(l);
			int currentVictoryPoints = dataSectionArena.GetCurrentVictoryPoints();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, currentVictoryPoints);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D56 RID: 97622 RVA: 0x006934AC File Offset: 0x006916AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetVictoryPoints(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArena dataSectionArena = (DataSectionArena)LuaObject.checkSelf(l);
			dataSectionArena.ResetVictoryPoints();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D57 RID: 97623 RVA: 0x006934F8 File Offset: 0x006916F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetReceivedVictoryPointsRewardedIndexs(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArena dataSectionArena = (DataSectionArena)LuaObject.checkSelf(l);
			dataSectionArena.ResetReceivedVictoryPointsRewardedIndexs();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D58 RID: 97624 RVA: 0x00693544 File Offset: 0x00691744
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HasReceivedVictoryPointsRewardedIndex(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArena dataSectionArena = (DataSectionArena)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			bool b = dataSectionArena.HasReceivedVictoryPointsRewardedIndex(index);
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

	// Token: 0x06017D59 RID: 97625 RVA: 0x006935A8 File Offset: 0x006917A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddReceivedVictoryPointsRewardIndex(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArena dataSectionArena = (DataSectionArena)LuaObject.checkSelf(l);
			int victoryPointsIndex;
			LuaObject.checkType(l, 2, out victoryPointsIndex);
			dataSectionArena.AddReceivedVictoryPointsRewardIndex(victoryPointsIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D5A RID: 97626 RVA: 0x00693600 File Offset: 0x00691800
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindOpponent(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArena dataSectionArena = (DataSectionArena)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			ArenaOpponent o = dataSectionArena.FindOpponent(index);
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

	// Token: 0x06017D5B RID: 97627 RVA: 0x00693664 File Offset: 0x00691864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAttackedOpponent(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArena dataSectionArena = (DataSectionArena)LuaObject.checkSelf(l);
			bool attackedOpponent;
			LuaObject.checkType(l, 2, out attackedOpponent);
			dataSectionArena.SetAttackedOpponent(attackedOpponent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D5C RID: 97628 RVA: 0x006936BC File Offset: 0x006918BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetOpponents(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArena dataSectionArena = (DataSectionArena)LuaObject.checkSelf(l);
			List<ArenaOpponent> opponents;
			LuaObject.checkType<List<ArenaOpponent>>(l, 2, out opponents);
			dataSectionArena.SetOpponents(opponents);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D5D RID: 97629 RVA: 0x00693714 File Offset: 0x00691914
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetArenaDefensiveBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArena dataSectionArena = (DataSectionArena)LuaObject.checkSelf(l);
			ArenaOpponentDefensiveBattleInfo arenaDefensiveBattleInfo;
			LuaObject.checkType<ArenaOpponentDefensiveBattleInfo>(l, 2, out arenaDefensiveBattleInfo);
			dataSectionArena.SetArenaDefensiveBattleInfo(arenaDefensiveBattleInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D5E RID: 97630 RVA: 0x0069376C File Offset: 0x0069196C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetArenaDefensiveBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArena dataSectionArena = (DataSectionArena)LuaObject.checkSelf(l);
			ArenaOpponentDefensiveBattleInfo arenaDefensiveBattleInfo = dataSectionArena.GetArenaDefensiveBattleInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefensiveBattleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D5F RID: 97631 RVA: 0x006937C0 File Offset: 0x006919C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetOpponentUserId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArena dataSectionArena = (DataSectionArena)LuaObject.checkSelf(l);
			string opponentUserId = dataSectionArena.GetOpponentUserId();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, opponentUserId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D60 RID: 97632 RVA: 0x00693814 File Offset: 0x00691A14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetArenaLevelId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArena dataSectionArena = (DataSectionArena)LuaObject.checkSelf(l);
			int arenaLevelId;
			LuaObject.checkType(l, 2, out arenaLevelId);
			dataSectionArena.SetArenaLevelId(arenaLevelId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D61 RID: 97633 RVA: 0x0069386C File Offset: 0x00691A6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetArenaPoints(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArena dataSectionArena = (DataSectionArena)LuaObject.checkSelf(l);
			ushort arenaPoints;
			LuaObject.checkType(l, 2, out arenaPoints);
			dataSectionArena.SetArenaPoints(arenaPoints);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D62 RID: 97634 RVA: 0x006938C4 File Offset: 0x00691AC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetArenaPlayerInfo(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArena dataSectionArena = (DataSectionArena)LuaObject.checkSelf(l);
			ArenaPlayerInfo arenaPlayerInfo;
			LuaObject.checkType<ArenaPlayerInfo>(l, 2, out arenaPlayerInfo);
			dataSectionArena.SetArenaPlayerInfo(arenaPlayerInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D63 RID: 97635 RVA: 0x0069391C File Offset: 0x00691B1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsFirstFindOpponents(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArena dataSectionArena = (DataSectionArena)LuaObject.checkSelf(l);
			bool b = dataSectionArena.IsFirstFindOpponents();
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

	// Token: 0x06017D64 RID: 97636 RVA: 0x00693970 File Offset: 0x00691B70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetConsecutiveVictoryNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArena dataSectionArena = (DataSectionArena)LuaObject.checkSelf(l);
			dataSectionArena.ResetConsecutiveVictoryNums();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D65 RID: 97637 RVA: 0x006939BC File Offset: 0x00691BBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddConsecutiveVictoryNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArena dataSectionArena = (DataSectionArena)LuaObject.checkSelf(l);
			int i = dataSectionArena.AddConsecutiveVictoryNums();
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

	// Token: 0x06017D66 RID: 97638 RVA: 0x00693A10 File Offset: 0x00691C10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ArenaPlayerInfo(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArena dataSectionArena = (DataSectionArena)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionArena.ArenaPlayerInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D67 RID: 97639 RVA: 0x00693A64 File Offset: 0x00691C64
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionArena");
		if (Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArena.InitArenaPlayerInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArena.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArena.SerializeToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArena.IsEmptyArenaPlayerInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArena.SetDefensiveTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArena.SetWeekLastFlushTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArena.SetThisWeekBattleIds);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArena.SetDefensiveBattleId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArena.SetDefensiveRuleId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArena.AddVictoryPoints);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArena.GetCurrentVictoryPoints);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArena.ResetVictoryPoints);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArena.ResetReceivedVictoryPointsRewardedIndexs);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArena.HasReceivedVictoryPointsRewardedIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArena.AddReceivedVictoryPointsRewardIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArena.FindOpponent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArena.SetAttackedOpponent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArena.SetOpponents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArena.SetArenaDefensiveBattleInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArena.GetArenaDefensiveBattleInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArena.GetOpponentUserId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArena.SetArenaLevelId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArena.SetArenaPoints);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArena.SetArenaPlayerInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArena.IsFirstFindOpponents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArena.ResetConsecutiveVictoryNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArena.AddConsecutiveVictoryNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache1A);
		string name = "ArenaPlayerInfo";
		if (Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArena.get_ArenaPlayerInfo);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache1B, null, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArena.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionArena.<>f__mg$cache1C, typeof(DataSectionArena), typeof(DataSection));
	}

	// Token: 0x0400E344 RID: 58180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E345 RID: 58181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E346 RID: 58182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E347 RID: 58183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E348 RID: 58184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E349 RID: 58185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E34A RID: 58186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E34B RID: 58187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E34C RID: 58188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E34D RID: 58189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E34E RID: 58190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E34F RID: 58191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E350 RID: 58192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E351 RID: 58193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E352 RID: 58194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E353 RID: 58195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E354 RID: 58196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E355 RID: 58197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E356 RID: 58198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E357 RID: 58199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E358 RID: 58200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400E359 RID: 58201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400E35A RID: 58202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400E35B RID: 58203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400E35C RID: 58204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400E35D RID: 58205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400E35E RID: 58206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400E35F RID: 58207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400E360 RID: 58208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;
}
