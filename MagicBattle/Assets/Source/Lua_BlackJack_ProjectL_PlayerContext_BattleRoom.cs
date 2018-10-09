using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012B5 RID: 4789
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_BattleRoom : LuaObject
{
	// Token: 0x06019276 RID: 103030 RVA: 0x0072FEE8 File Offset: 0x0072E0E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom o = new BattleRoom();
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

	// Token: 0x06019277 RID: 103031 RVA: 0x0072FF30 File Offset: 0x0072E130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Clear(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			battleRoom.Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019278 RID: 103032 RVA: 0x0072FF7C File Offset: 0x0072E17C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitPlayers(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			List<ProBattleRoomPlayer> players;
			LuaObject.checkType<List<ProBattleRoomPlayer>>(l, 2, out players);
			battleRoom.InitPlayers(players);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019279 RID: 103033 RVA: 0x0072FFD4 File Offset: 0x0072E1D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindPlayerBySessionId(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			ulong sessionId;
			LuaObject.checkType(l, 2, out sessionId);
			BattleRoomPlayer o = battleRoom.FindPlayerBySessionId(sessionId);
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

	// Token: 0x0601927A RID: 103034 RVA: 0x00730038 File Offset: 0x0072E238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindPlayerByUserId(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			BattleRoomPlayer o = battleRoom.FindPlayerByUserId(userId);
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

	// Token: 0x0601927B RID: 103035 RVA: 0x0073009C File Offset: 0x0072E29C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetMyPlayer(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			string myPlayer;
			LuaObject.checkType(l, 2, out myPlayer);
			battleRoom.SetMyPlayer(myPlayer);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601927C RID: 103036 RVA: 0x007300F4 File Offset: 0x0072E2F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetLeaderPlayer(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			string leaderPlayer;
			LuaObject.checkType(l, 2, out leaderPlayer);
			battleRoom.SetLeaderPlayer(leaderPlayer);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601927D RID: 103037 RVA: 0x0073014C File Offset: 0x0072E34C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindPlayerIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			int i = battleRoom.FindPlayerIndex(userId);
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

	// Token: 0x0601927E RID: 103038 RVA: 0x007301B0 File Offset: 0x0072E3B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindPlayerIndexBySessiongId(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			ulong sessionId;
			LuaObject.checkType(l, 2, out sessionId);
			int i = battleRoom.FindPlayerIndexBySessiongId(sessionId);
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

	// Token: 0x0601927F RID: 103039 RVA: 0x00730214 File Offset: 0x0072E414
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMyPlayer(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			BattleRoomPlayer myPlayer = battleRoom.GetMyPlayer();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, myPlayer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019280 RID: 103040 RVA: 0x00730268 File Offset: 0x0072E468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsTeamOrGuildMassiveCombatRoomType(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			bool b = battleRoom.IsTeamOrGuildMassiveCombatRoomType();
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

	// Token: 0x06019281 RID: 103041 RVA: 0x007302BC File Offset: 0x0072E4BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsAnyPVPBattleRoomType(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			bool b = battleRoom.IsAnyPVPBattleRoomType();
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

	// Token: 0x06019282 RID: 103042 RVA: 0x00730310 File Offset: 0x0072E510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsRealTimePVPBattleRoomType(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			bool b = battleRoom.IsRealTimePVPBattleRoomType();
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

	// Token: 0x06019283 RID: 103043 RVA: 0x00730364 File Offset: 0x0072E564
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetPlayerIndexInCurrentPickTurn(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			int playerIndexInCurrentPickTurn = battleRoom.GetPlayerIndexInCurrentPickTurn();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerIndexInCurrentPickTurn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019284 RID: 103044 RVA: 0x007303B8 File Offset: 0x0072E5B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetHeroSetupCountMaxInPickTurn(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			int turn;
			LuaObject.checkType(l, 2, out turn);
			int heroSetupCountMaxInPickTurn = battleRoom.GetHeroSetupCountMaxInPickTurn(turn);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSetupCountMaxInPickTurn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019285 RID: 103045 RVA: 0x0073041C File Offset: 0x0072E61C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroSetupCountInCurrentPickTurn(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			int heroSetupCountInCurrentPickTurn = battleRoom.GetHeroSetupCountInCurrentPickTurn();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSetupCountInCurrentPickTurn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019286 RID: 103046 RVA: 0x00730470 File Offset: 0x0072E670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRemainHeroSetupCountInCurrentPickTurn(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			int remainHeroSetupCountInCurrentPickTurn = battleRoom.GetRemainHeroSetupCountInCurrentPickTurn();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, remainHeroSetupCountInCurrentPickTurn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019287 RID: 103047 RVA: 0x007304C4 File Offset: 0x0072E6C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroSetupFlagCount(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			int playerIndex;
			LuaObject.checkType(l, 2, out playerIndex);
			SetupBattleHeroFlag flag;
			LuaObject.checkEnum<SetupBattleHeroFlag>(l, 3, out flag);
			int heroSetupFlagCount = battleRoom.GetHeroSetupFlagCount(playerIndex, flag);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSetupFlagCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019288 RID: 103048 RVA: 0x00730534 File Offset: 0x0072E734
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsHeroSetupHasFlag(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			int playerIndex;
			LuaObject.checkType(l, 2, out playerIndex);
			int heroId;
			LuaObject.checkType(l, 3, out heroId);
			SetupBattleHeroFlag flag;
			LuaObject.checkEnum<SetupBattleHeroFlag>(l, 4, out flag);
			bool b = battleRoom.IsHeroSetupHasFlag(playerIndex, heroId, flag);
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

	// Token: 0x06019289 RID: 103049 RVA: 0x007305B0 File Offset: 0x0072E7B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_RoomId(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoom.RoomId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601928A RID: 103050 RVA: 0x00730604 File Offset: 0x0072E804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RoomId(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			ulong roomId;
			LuaObject.checkType(l, 2, out roomId);
			battleRoom.RoomId = roomId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601928B RID: 103051 RVA: 0x0073065C File Offset: 0x0072E85C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleRoomType(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)battleRoom.BattleRoomType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601928C RID: 103052 RVA: 0x007306B0 File Offset: 0x0072E8B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BattleRoomType(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			BattleRoomType battleRoomType;
			LuaObject.checkEnum<BattleRoomType>(l, 2, out battleRoomType);
			battleRoom.BattleRoomType = battleRoomType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601928D RID: 103053 RVA: 0x00730708 File Offset: 0x0072E908
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleId(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoom.BattleId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601928E RID: 103054 RVA: 0x0073075C File Offset: 0x0072E95C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BattleId(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			int battleId;
			LuaObject.checkType(l, 2, out battleId);
			battleRoom.BattleId = battleId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601928F RID: 103055 RVA: 0x007307B4 File Offset: 0x0072E9B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GameFunctionType(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)battleRoom.GameFunctionType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019290 RID: 103056 RVA: 0x00730808 File Offset: 0x0072EA08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GameFunctionType(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionType;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFunctionType);
			battleRoom.GameFunctionType = gameFunctionType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019291 RID: 103057 RVA: 0x00730860 File Offset: 0x0072EA60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LocationId(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoom.LocationId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019292 RID: 103058 RVA: 0x007308B4 File Offset: 0x0072EAB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LocationId(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			int locationId;
			LuaObject.checkType(l, 2, out locationId);
			battleRoom.LocationId = locationId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019293 RID: 103059 RVA: 0x0073090C File Offset: 0x0072EB0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BattleRoomStatus(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)battleRoom.BattleRoomStatus);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019294 RID: 103060 RVA: 0x00730960 File Offset: 0x0072EB60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BattleRoomStatus(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			BattleRoomStatus battleRoomStatus;
			LuaObject.checkEnum<BattleRoomStatus>(l, 2, out battleRoomStatus);
			battleRoom.BattleRoomStatus = battleRoomStatus;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019295 RID: 103061 RVA: 0x007309B8 File Offset: 0x0072EBB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ReadyTimeout(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoom.ReadyTimeout);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019296 RID: 103062 RVA: 0x00730A10 File Offset: 0x0072EC10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ReadyTimeout(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			DateTime readyTimeout;
			LuaObject.checkValueType<DateTime>(l, 2, out readyTimeout);
			battleRoom.ReadyTimeout = readyTimeout;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019297 RID: 103063 RVA: 0x00730A68 File Offset: 0x0072EC68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LastPlayerBeginActionTime(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoom.LastPlayerBeginActionTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019298 RID: 103064 RVA: 0x00730AC0 File Offset: 0x0072ECC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LastPlayerBeginActionTime(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			DateTime lastPlayerBeginActionTime;
			LuaObject.checkValueType<DateTime>(l, 2, out lastPlayerBeginActionTime);
			battleRoom.LastPlayerBeginActionTime = lastPlayerBeginActionTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019299 RID: 103065 RVA: 0x00730B18 File Offset: 0x0072ED18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Players(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoom.Players);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601929A RID: 103066 RVA: 0x00730B6C File Offset: 0x0072ED6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Players(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			List<BattleRoomPlayer> players;
			LuaObject.checkType<List<BattleRoomPlayer>>(l, 2, out players);
			battleRoom.Players = players;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601929B RID: 103067 RVA: 0x00730BC4 File Offset: 0x0072EDC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BattleRoomPlayerHeroSetup(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoom.BattleRoomPlayerHeroSetup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601929C RID: 103068 RVA: 0x00730C18 File Offset: 0x0072EE18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BattleRoomPlayerHeroSetup(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			BattleRoomPlayerHeroSetup battleRoomPlayerHeroSetup;
			LuaObject.checkType<BattleRoomPlayerHeroSetup>(l, 2, out battleRoomPlayerHeroSetup);
			battleRoom.BattleRoomPlayerHeroSetup = battleRoomPlayerHeroSetup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601929D RID: 103069 RVA: 0x00730C70 File Offset: 0x0072EE70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MyPlayerIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoom.MyPlayerIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601929E RID: 103070 RVA: 0x00730CC4 File Offset: 0x0072EEC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_MyPlayerIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			int myPlayerIndex;
			LuaObject.checkType(l, 2, out myPlayerIndex);
			battleRoom.MyPlayerIndex = myPlayerIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601929F RID: 103071 RVA: 0x00730D1C File Offset: 0x0072EF1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LeaderPlayerIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoom.LeaderPlayerIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192A0 RID: 103072 RVA: 0x00730D70 File Offset: 0x0072EF70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LeaderPlayerIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			int leaderPlayerIndex;
			LuaObject.checkType(l, 2, out leaderPlayerIndex);
			battleRoom.LeaderPlayerIndex = leaderPlayerIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192A1 RID: 103073 RVA: 0x00730DC8 File Offset: 0x0072EFC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BattleCommands(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoom.BattleCommands);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192A2 RID: 103074 RVA: 0x00730E1C File Offset: 0x0072F01C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BattleCommands(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			List<BattleCommand> battleCommands;
			LuaObject.checkType<List<BattleCommand>>(l, 2, out battleCommands);
			battleRoom.BattleCommands = battleCommands;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192A3 RID: 103075 RVA: 0x00730E74 File Offset: 0x0072F074
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleStars(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoom.BattleStars);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192A4 RID: 103076 RVA: 0x00730EC8 File Offset: 0x0072F0C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BattleStars(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			int battleStars;
			LuaObject.checkType(l, 2, out battleStars);
			battleRoom.BattleStars = battleStars;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192A5 RID: 103077 RVA: 0x00730F20 File Offset: 0x0072F120
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BattleReward(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoom.BattleReward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192A6 RID: 103078 RVA: 0x00730F74 File Offset: 0x0072F174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BattleReward(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			BattleReward battleReward;
			LuaObject.checkType<BattleReward>(l, 2, out battleReward);
			battleRoom.BattleReward = battleReward;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192A7 RID: 103079 RVA: 0x00730FCC File Offset: 0x0072F1CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PVPWinSessionId(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoom.PVPWinSessionId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192A8 RID: 103080 RVA: 0x00731020 File Offset: 0x0072F220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PVPWinSessionId(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			ulong pvpwinSessionId;
			LuaObject.checkType(l, 2, out pvpwinSessionId);
			battleRoom.PVPWinSessionId = pvpwinSessionId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192A9 RID: 103081 RVA: 0x00731078 File Offset: 0x0072F278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleMode(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)battleRoom.BattleMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192AA RID: 103082 RVA: 0x007310CC File Offset: 0x0072F2CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BattleMode(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			BattleMode battleMode;
			LuaObject.checkEnum<BattleMode>(l, 2, out battleMode);
			battleRoom.BattleMode = battleMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192AB RID: 103083 RVA: 0x00731124 File Offset: 0x0072F324
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BPRule(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)battleRoom.BPRule);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192AC RID: 103084 RVA: 0x00731178 File Offset: 0x0072F378
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BPRule(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			BattleRoomBPRule bprule;
			LuaObject.checkEnum<BattleRoomBPRule>(l, 2, out bprule);
			battleRoom.BPRule = bprule;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192AD RID: 103085 RVA: 0x007311D0 File Offset: 0x0072F3D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BPTurn(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoom.BPTurn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192AE RID: 103086 RVA: 0x00731224 File Offset: 0x0072F424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BPTurn(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			int bpturn;
			LuaObject.checkType(l, 2, out bpturn);
			battleRoom.BPTurn = bpturn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192AF RID: 103087 RVA: 0x0073127C File Offset: 0x0072F47C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BPStatus(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)battleRoom.BPStatus);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192B0 RID: 103088 RVA: 0x007312D0 File Offset: 0x0072F4D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BPStatus(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			BattleRoomBPStatus bpstatus;
			LuaObject.checkEnum<BattleRoomBPStatus>(l, 2, out bpstatus);
			battleRoom.BPStatus = bpstatus;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192B1 RID: 103089 RVA: 0x00731328 File Offset: 0x0072F528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LatestTurnChangeDateTime(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoom.LatestTurnChangeDateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192B2 RID: 103090 RVA: 0x00731380 File Offset: 0x0072F580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LatestTurnChangeDateTime(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			DateTime latestTurnChangeDateTime;
			LuaObject.checkValueType<DateTime>(l, 2, out latestTurnChangeDateTime);
			battleRoom.LatestTurnChangeDateTime = latestTurnChangeDateTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192B3 RID: 103091 RVA: 0x007313D8 File Offset: 0x0072F5D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_RealtimePVPBattleInstanceId(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoom.RealtimePVPBattleInstanceId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192B4 RID: 103092 RVA: 0x0073142C File Offset: 0x0072F62C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RealtimePVPBattleInstanceId(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			ulong realtimePVPBattleInstanceId;
			LuaObject.checkType(l, 2, out realtimePVPBattleInstanceId);
			battleRoom.RealtimePVPBattleInstanceId = realtimePVPBattleInstanceId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192B5 RID: 103093 RVA: 0x00731484 File Offset: 0x0072F684
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PreferredHeroTagIds(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoom.PreferredHeroTagIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192B6 RID: 103094 RVA: 0x007314D8 File Offset: 0x0072F6D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PreferredHeroTagIds(IntPtr l)
	{
		int result;
		try
		{
			BattleRoom battleRoom = (BattleRoom)LuaObject.checkSelf(l);
			List<int> preferredHeroTagIds;
			LuaObject.checkType<List<int>>(l, 2, out preferredHeroTagIds);
			battleRoom.PreferredHeroTagIds = preferredHeroTagIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192B7 RID: 103095 RVA: 0x00731530 File Offset: 0x0072F730
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.BattleRoom");
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.InitPlayers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.FindPlayerBySessionId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.FindPlayerByUserId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.SetMyPlayer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.SetLeaderPlayer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.FindPlayerIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.FindPlayerIndexBySessiongId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.GetMyPlayer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.IsTeamOrGuildMassiveCombatRoomType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.IsAnyPVPBattleRoomType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.IsRealTimePVPBattleRoomType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.GetPlayerIndexInCurrentPickTurn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.GetHeroSetupCountMaxInPickTurn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.GetHeroSetupCountInCurrentPickTurn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.GetRemainHeroSetupCountInCurrentPickTurn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.GetHeroSetupFlagCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.IsHeroSetupHasFlag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache11);
		string name = "RoomId";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.get_RoomId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.set_RoomId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache13, true);
		string name2 = "BattleRoomType";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.get_BattleRoomType);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.set_BattleRoomType);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache15, true);
		string name3 = "BattleId";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.get_BattleId);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.set_BattleId);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache17, true);
		string name4 = "GameFunctionType";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.get_GameFunctionType);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.set_GameFunctionType);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache19, true);
		string name5 = "LocationId";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.get_LocationId);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.set_LocationId);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache1B, true);
		string name6 = "BattleRoomStatus";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.get_BattleRoomStatus);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.set_BattleRoomStatus);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache1D, true);
		string name7 = "ReadyTimeout";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.get_ReadyTimeout);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.set_ReadyTimeout);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache1F, true);
		string name8 = "LastPlayerBeginActionTime";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.get_LastPlayerBeginActionTime);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.set_LastPlayerBeginActionTime);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache21, true);
		string name9 = "Players";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.get_Players);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.set_Players);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache23, true);
		string name10 = "BattleRoomPlayerHeroSetup";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.get_BattleRoomPlayerHeroSetup);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.set_BattleRoomPlayerHeroSetup);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache25, true);
		string name11 = "MyPlayerIndex";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.get_MyPlayerIndex);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.set_MyPlayerIndex);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache27, true);
		string name12 = "LeaderPlayerIndex";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.get_LeaderPlayerIndex);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.set_LeaderPlayerIndex);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache29, true);
		string name13 = "BattleCommands";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.get_BattleCommands);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.set_BattleCommands);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache2B, true);
		string name14 = "BattleStars";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.get_BattleStars);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.set_BattleStars);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache2D, true);
		string name15 = "BattleReward";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.get_BattleReward);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.set_BattleReward);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache2F, true);
		string name16 = "PVPWinSessionId";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.get_PVPWinSessionId);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.set_PVPWinSessionId);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache31, true);
		string name17 = "BattleMode";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.get_BattleMode);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.set_BattleMode);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache33, true);
		string name18 = "BPRule";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.get_BPRule);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.set_BPRule);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache35, true);
		string name19 = "BPTurn";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.get_BPTurn);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.set_BPTurn);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache37, true);
		string name20 = "BPStatus";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.get_BPStatus);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.set_BPStatus);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache39, true);
		string name21 = "LatestTurnChangeDateTime";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.get_LatestTurnChangeDateTime);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.set_LatestTurnChangeDateTime);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache3B, true);
		string name22 = "RealtimePVPBattleInstanceId";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.get_RealtimePVPBattleInstanceId);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.set_RealtimePVPBattleInstanceId);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache3D, true);
		string name23 = "PreferredHeroTagIds";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.get_PreferredHeroTagIds);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.set_PreferredHeroTagIds);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache3F, true);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.<>f__mg$cache40, typeof(BattleRoom));
	}

	// Token: 0x0400F6EE RID: 63214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F6EF RID: 63215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F6F0 RID: 63216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F6F1 RID: 63217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F6F2 RID: 63218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F6F3 RID: 63219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F6F4 RID: 63220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F6F5 RID: 63221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F6F6 RID: 63222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F6F7 RID: 63223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F6F8 RID: 63224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F6F9 RID: 63225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F6FA RID: 63226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F6FB RID: 63227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F6FC RID: 63228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F6FD RID: 63229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F6FE RID: 63230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400F6FF RID: 63231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400F700 RID: 63232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400F701 RID: 63233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400F702 RID: 63234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400F703 RID: 63235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400F704 RID: 63236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400F705 RID: 63237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400F706 RID: 63238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400F707 RID: 63239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400F708 RID: 63240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400F709 RID: 63241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400F70A RID: 63242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400F70B RID: 63243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400F70C RID: 63244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400F70D RID: 63245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400F70E RID: 63246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400F70F RID: 63247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400F710 RID: 63248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400F711 RID: 63249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400F712 RID: 63250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400F713 RID: 63251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400F714 RID: 63252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400F715 RID: 63253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400F716 RID: 63254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400F717 RID: 63255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400F718 RID: 63256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400F719 RID: 63257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400F71A RID: 63258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400F71B RID: 63259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400F71C RID: 63260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400F71D RID: 63261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400F71E RID: 63262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400F71F RID: 63263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400F720 RID: 63264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400F721 RID: 63265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400F722 RID: 63266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400F723 RID: 63267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400F724 RID: 63268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400F725 RID: 63269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400F726 RID: 63270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400F727 RID: 63271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400F728 RID: 63272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400F729 RID: 63273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400F72A RID: 63274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400F72B RID: 63275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400F72C RID: 63276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400F72D RID: 63277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400F72E RID: 63278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;
}
