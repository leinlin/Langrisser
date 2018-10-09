using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012B3 RID: 4787
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_BattleComponent : LuaObject
{
	// Token: 0x060191FA RID: 102906 RVA: 0x0072C138 File Offset: 0x0072A338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent o = new BattleComponent();
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

	// Token: 0x060191FB RID: 102907 RVA: 0x0072C180 File Offset: 0x0072A380
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			battleComponent.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060191FC RID: 102908 RVA: 0x0072C1CC File Offset: 0x0072A3CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			battleComponent.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060191FD RID: 102909 RVA: 0x0072C218 File Offset: 0x0072A418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			battleComponent.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060191FE RID: 102910 RVA: 0x0072C264 File Offset: 0x0072A464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeSerialize(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			DSBattleNtf msg;
			LuaObject.checkType<DSBattleNtf>(l, 2, out msg);
			battleComponent.DeSerialize(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060191FF RID: 102911 RVA: 0x0072C2BC File Offset: 0x0072A4BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetDSVersion(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			ushort dsversion = battleComponent.GetDSVersion();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dsversion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019200 RID: 102912 RVA: 0x0072C310 File Offset: 0x0072A510
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetBattleBase(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			BattleBase battleBase;
			LuaObject.checkType<BattleBase>(l, 2, out battleBase);
			battleComponent.SetBattleBase(battleBase);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019201 RID: 102913 RVA: 0x0072C368 File Offset: 0x0072A568
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetBattleBase(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			BattleBase battleBase = battleComponent.GetBattleBase();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019202 RID: 102914 RVA: 0x0072C3BC File Offset: 0x0072A5BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsRiftBattling(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			bool b = battleComponent.IsRiftBattling();
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

	// Token: 0x06019203 RID: 102915 RVA: 0x0072C410 File Offset: 0x0072A610
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsTreasureMapBattling(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			bool b = battleComponent.IsTreasureMapBattling();
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

	// Token: 0x06019204 RID: 102916 RVA: 0x0072C464 File Offset: 0x0072A664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBattleTeam(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			int teamType;
			LuaObject.checkType(l, 2, out teamType);
			List<int> battleTeam = battleComponent.GetBattleTeam(teamType);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTeam);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019205 RID: 102917 RVA: 0x0072C4C8 File Offset: 0x0072A6C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearFighting(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			battleComponent.ClearFighting();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019206 RID: 102918 RVA: 0x0072C514 File Offset: 0x0072A714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBattleRandomSeed(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			int battleRandomSeed;
			LuaObject.checkType(l, 2, out battleRandomSeed);
			battleComponent.SetBattleRandomSeed(battleRandomSeed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019207 RID: 102919 RVA: 0x0072C56C File Offset: 0x0072A76C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetArenaBattleRandomSeed(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			int arenaBattleRandomSeed;
			LuaObject.checkType(l, 2, out arenaBattleRandomSeed);
			battleComponent.SetArenaBattleRandomSeed(arenaBattleRandomSeed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019208 RID: 102920 RVA: 0x0072C5C4 File Offset: 0x0072A7C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetArenaBattleStatus(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			ArenaBattleStatus arenaBattleStatus = battleComponent.GetArenaBattleStatus();
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)arenaBattleStatus);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019209 RID: 102921 RVA: 0x0072C618 File Offset: 0x0072A818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetArenaBattleId(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			int arenaBattleId = battleComponent.GetArenaBattleId();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaBattleId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601920A RID: 102922 RVA: 0x0072C66C File Offset: 0x0072A86C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetGotBattleTreasureIds(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			List<int> gotBattleTreasureIds = battleComponent.GetGotBattleTreasureIds();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gotBattleTreasureIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601920B RID: 102923 RVA: 0x0072C6C0 File Offset: 0x0072A8C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int JoinTeamBattleRoom(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			ulong roomId;
			LuaObject.checkType(l, 2, out roomId);
			int battleId;
			LuaObject.checkType(l, 3, out battleId);
			GameFunctionType gameFunctionType;
			LuaObject.checkEnum<GameFunctionType>(l, 4, out gameFunctionType);
			int locationId;
			LuaObject.checkType(l, 5, out locationId);
			List<ProBattleRoomPlayer> players;
			LuaObject.checkType<List<ProBattleRoomPlayer>>(l, 6, out players);
			DateTime readyTimeOut;
			LuaObject.checkValueType<DateTime>(l, 7, out readyTimeOut);
			int i = battleComponent.JoinTeamBattleRoom(roomId, battleId, gameFunctionType, locationId, players, readyTimeOut);
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

	// Token: 0x0601920C RID: 102924 RVA: 0x0072C760 File Offset: 0x0072A960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int JoinPVPBattleRoom(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			ulong roomId;
			LuaObject.checkType(l, 2, out roomId);
			int battleId;
			LuaObject.checkType(l, 3, out battleId);
			List<ProBattleRoomPlayer> players;
			LuaObject.checkType<List<ProBattleRoomPlayer>>(l, 4, out players);
			DateTime readyTimeOut;
			LuaObject.checkValueType<DateTime>(l, 5, out readyTimeOut);
			int i = battleComponent.JoinPVPBattleRoom(roomId, battleId, players, readyTimeOut);
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

	// Token: 0x0601920D RID: 102925 RVA: 0x0072C7E8 File Offset: 0x0072A9E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int JoinRealtimePVPBattleRoom(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			ulong roomId;
			LuaObject.checkType(l, 2, out roomId);
			int battleId;
			LuaObject.checkType(l, 3, out battleId);
			List<ProBattleRoomPlayer> players;
			LuaObject.checkType<List<ProBattleRoomPlayer>>(l, 4, out players);
			DateTime readyTimeOut;
			LuaObject.checkValueType<DateTime>(l, 5, out readyTimeOut);
			BattleRoomType roomType;
			LuaObject.checkEnum<BattleRoomType>(l, 6, out roomType);
			int i = battleComponent.JoinRealtimePVPBattleRoom(roomId, battleId, players, readyTimeOut, roomType);
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

	// Token: 0x0601920E RID: 102926 RVA: 0x0072C87C File Offset: 0x0072AA7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int JoinGuildMassiveCombatBattleRoom(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			ulong roomId;
			LuaObject.checkType(l, 2, out roomId);
			int battleId;
			LuaObject.checkType(l, 3, out battleId);
			int locationId;
			LuaObject.checkType(l, 4, out locationId);
			List<ProBattleRoomPlayer> players;
			LuaObject.checkType<List<ProBattleRoomPlayer>>(l, 5, out players);
			DateTime readyTimeOut;
			LuaObject.checkValueType<DateTime>(l, 6, out readyTimeOut);
			List<int> preferredHeroTagIds;
			LuaObject.checkType<List<int>>(l, 7, out preferredHeroTagIds);
			int i = battleComponent.JoinGuildMassiveCombatBattleRoom(roomId, battleId, locationId, players, readyTimeOut, preferredHeroTagIds);
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

	// Token: 0x0601920F RID: 102927 RVA: 0x0072C91C File Offset: 0x0072AB1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int QuitBattleRoom(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			int i = battleComponent.QuitBattleRoom();
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

	// Token: 0x06019210 RID: 102928 RVA: 0x0072C970 File Offset: 0x0072AB70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetRealtimePVPBattleRoomData(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			BattleRoomDataChangeNtf realtimePVPBattleRoomData;
			LuaObject.checkType<BattleRoomDataChangeNtf>(l, 2, out realtimePVPBattleRoomData);
			battleComponent.SetRealtimePVPBattleRoomData(realtimePVPBattleRoomData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019211 RID: 102929 RVA: 0x0072C9C8 File Offset: 0x0072ABC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetBattleRoomPlayerStatus(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			ulong sessionId;
			LuaObject.checkType(l, 2, out sessionId);
			PlayerBattleStatus status;
			LuaObject.checkEnum<PlayerBattleStatus>(l, 3, out status);
			bool isOffLine;
			LuaObject.checkType(l, 4, out isOffLine);
			battleComponent.SetBattleRoomPlayerStatus(sessionId, status, isOffLine);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019212 RID: 102930 RVA: 0x0072CA3C File Offset: 0x0072AC3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitBattleRoomPlayer(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			ulong sessionId;
			LuaObject.checkType(l, 2, out sessionId);
			List<ProTrainingTech> techs;
			LuaObject.checkType<List<ProTrainingTech>>(l, 3, out techs);
			battleComponent.InitBattleRoomPlayer(sessionId, techs);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019213 RID: 102931 RVA: 0x0072CAA0 File Offset: 0x0072ACA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int BattleRoomHeroSetup(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			ProBattleHeroSetupInfo heroSetup;
			LuaObject.checkType<ProBattleHeroSetupInfo>(l, 2, out heroSetup);
			battleComponent.BattleRoomHeroSetup(heroSetup);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019214 RID: 102932 RVA: 0x0072CAF8 File Offset: 0x0072ACF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleRoomBattleStart(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			battleComponent.BattleRoomBattleStart();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019215 RID: 102933 RVA: 0x0072CB44 File Offset: 0x0072AD44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AppendBattleRoomCommands(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			List<ProBattleCommand> commands;
			LuaObject.checkType<List<ProBattleCommand>>(l, 2, out commands);
			battleComponent.AppendBattleRoomCommands(commands);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019216 RID: 102934 RVA: 0x0072CB9C File Offset: 0x0072AD9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsInBattleRoom(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			bool b = battleComponent.IsInBattleRoom();
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

	// Token: 0x06019217 RID: 102935 RVA: 0x0072CBF0 File Offset: 0x0072ADF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetBattleRoom(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			BattleRoom battleRoom = battleComponent.GetBattleRoom();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoom);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019218 RID: 102936 RVA: 0x0072CC44 File Offset: 0x0072AE44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBattleReward(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			BattleReward battleReward = battleComponent.GetBattleReward();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019219 RID: 102937 RVA: 0x0072CC98 File Offset: 0x0072AE98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			string s = battleComponent.m_luaExportHelper.__callBase_GetName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601921A RID: 102938 RVA: 0x0072CCF4 File Offset: 0x0072AEF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			battleComponent.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601921B RID: 102939 RVA: 0x0072CD48 File Offset: 0x0072AF48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			battleComponent.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601921C RID: 102940 RVA: 0x0072CD9C File Offset: 0x0072AF9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			battleComponent.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601921D RID: 102941 RVA: 0x0072CDF0 File Offset: 0x0072AFF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			battleComponent.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601921E RID: 102942 RVA: 0x0072CE4C File Offset: 0x0072B04C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			battleComponent.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601921F RID: 102943 RVA: 0x0072CEA0 File Offset: 0x0072B0A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsGameFunctionOpenByMonthCard(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			GameFunctionType gameFuncTypeId;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFuncTypeId);
			bool b = battleComponent.m_luaExportHelper.__callBase_IsGameFunctionOpenByMonthCard(gameFuncTypeId);
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

	// Token: 0x06019220 RID: 102944 RVA: 0x0072CF08 File Offset: 0x0072B108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetDailyBonusMaxNums(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			GameFunctionType gameFuncTypeId;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFuncTypeId);
			int i = battleComponent.m_luaExportHelper.__callBase_GetDailyBonusMaxNums(gameFuncTypeId);
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

	// Token: 0x06019221 RID: 102945 RVA: 0x0072CF70 File Offset: 0x0072B170
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetSinglePveBattleFailEnergyCostByMonthCard(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			int i = battleComponent.m_luaExportHelper.__callBase_GetSinglePveBattleFailEnergyCostByMonthCard();
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

	// Token: 0x06019222 RID: 102946 RVA: 0x0072CFCC File Offset: 0x0072B1CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetTeamPveBattleFailEnergyCost(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			GameFunctionType typeId;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out typeId);
			int locationId;
			LuaObject.checkType(l, 3, out locationId);
			int i = battleComponent.m_luaExportHelper.__callBase_GetTeamPveBattleFailEnergyCost(typeId, locationId);
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

	// Token: 0x06019223 RID: 102947 RVA: 0x0072D040 File Offset: 0x0072B240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetTeamPveBattleFailEnergyCostByMonthCard(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			GameFunctionType typeId;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out typeId);
			int locationId;
			LuaObject.checkType(l, 3, out locationId);
			int i = battleComponent.m_luaExportHelper.__callBase_GetTeamPveBattleFailEnergyCostByMonthCard(typeId, locationId);
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

	// Token: 0x06019224 RID: 102948 RVA: 0x0072D0B4 File Offset: 0x0072B2B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AddTeamPveFightFailCompensationEnergyByMonthCard(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			GameFunctionType typeId;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out typeId);
			int locationId;
			LuaObject.checkType(l, 3, out locationId);
			battleComponent.m_luaExportHelper.__callBase_AddTeamPveFightFailCompensationEnergyByMonthCard(typeId, locationId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019225 RID: 102949 RVA: 0x0072D120 File Offset: 0x0072B320
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsWaypointBattling(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			bool b = battleComponent.m_luaExportHelper.__callBase_IsWaypointBattling();
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

	// Token: 0x06019226 RID: 102950 RVA: 0x0072D17C File Offset: 0x0072B37C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsBattleWin(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			bool b = battleComponent.m_luaExportHelper.__callBase_IsBattleWin();
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

	// Token: 0x06019227 RID: 102951 RVA: 0x0072D1D8 File Offset: 0x0072B3D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CancelBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			int i = battleComponent.m_luaExportHelper.__callBase_CancelBattle();
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

	// Token: 0x06019228 RID: 102952 RVA: 0x0072D234 File Offset: 0x0072B434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsFighting(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			bool b = battleComponent.m_luaExportHelper.__callBase_IsFighting();
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

	// Token: 0x06019229 RID: 102953 RVA: 0x0072D290 File Offset: 0x0072B490
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanSetupMineTeam(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			bool b = battleComponent.m_luaExportHelper.__callBase_CanSetupMineTeam();
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

	// Token: 0x0601922A RID: 102954 RVA: 0x0072D2EC File Offset: 0x0072B4EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_FightFinished(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			GameFunctionStatus status;
			LuaObject.checkEnum<GameFunctionStatus>(l, 2, out status);
			bool win;
			LuaObject.checkType(l, 3, out win);
			bool needBatlleLog;
			LuaObject.checkType(l, 4, out needBatlleLog);
			battleComponent.m_luaExportHelper.__callBase_FightFinished(status, win, needBatlleLog);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601922B RID: 102955 RVA: 0x0072D364 File Offset: 0x0072B564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsWayPointFightExist(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			int wayPointId;
			LuaObject.checkType(l, 2, out wayPointId);
			bool b = battleComponent.m_luaExportHelper.__callBase_IsWayPointFightExist(wayPointId);
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

	// Token: 0x0601922C RID: 102956 RVA: 0x0072D3CC File Offset: 0x0072B5CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_WinPveBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			int battleId;
			LuaObject.checkType(l, 2, out battleId);
			battleComponent.m_luaExportHelper.__callBase_WinPveBattle(battleId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601922D RID: 102957 RVA: 0x0072D428 File Offset: 0x0072B628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_FinishedArenaFight(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			battleComponent.m_luaExportHelper.__callBase_FinishedArenaFight();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601922E RID: 102958 RVA: 0x0072D47C File Offset: 0x0072B67C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetProcessingBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			ProcessingBattle o = battleComponent.m_luaExportHelper.__callBase_GetProcessingBattle();
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

	// Token: 0x0601922F RID: 102959 RVA: 0x0072D4D8 File Offset: 0x0072B6D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetProcessingBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			BattleType type;
			LuaObject.checkEnum<BattleType>(l, 2, out type);
			int typeId;
			LuaObject.checkType(l, 3, out typeId);
			battleComponent.m_luaExportHelper.__callBase_SetProcessingBattleInfo(type, typeId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019230 RID: 102960 RVA: 0x0072D544 File Offset: 0x0072B744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetBattleArmyRandomSeed(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			int armyRandomSeed;
			LuaObject.checkType(l, 2, out armyRandomSeed);
			battleComponent.m_luaExportHelper.__callBase_SetBattleArmyRandomSeed(armyRandomSeed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019231 RID: 102961 RVA: 0x0072D5A0 File Offset: 0x0072B7A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetBattleArmyRandomSeed(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			int i = battleComponent.m_luaExportHelper.__callBase_GetBattleArmyRandomSeed();
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

	// Token: 0x06019232 RID: 102962 RVA: 0x0072D5FC File Offset: 0x0072B7FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetArenaBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			int arenaBattleId;
			LuaObject.checkType(l, 2, out arenaBattleId);
			battleComponent.m_luaExportHelper.__callBase_SetArenaBattleInfo(arenaBattleId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019233 RID: 102963 RVA: 0x0072D658 File Offset: 0x0072B858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsAttackingPveLevel(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 2, out battleType);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			bool b = battleComponent.m_luaExportHelper.__callBase_IsAttackingPveLevel(battleType, levelId);
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

	// Token: 0x06019234 RID: 102964 RVA: 0x0072D6CC File Offset: 0x0072B8CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsAttackingArenaOpponent(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			bool b = battleComponent.m_luaExportHelper.__callBase_IsAttackingArenaOpponent();
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

	// Token: 0x06019235 RID: 102965 RVA: 0x0072D728 File Offset: 0x0072B928
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsArenaBattleInReady(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			bool b = battleComponent.m_luaExportHelper.__callBase_IsArenaBattleInReady();
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

	// Token: 0x06019236 RID: 102966 RVA: 0x0072D784 File Offset: 0x0072B984
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsAttackingInBattleServer(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			bool b = battleComponent.m_luaExportHelper.__callBase_IsAttackingInBattleServer();
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

	// Token: 0x06019237 RID: 102967 RVA: 0x0072D7E0 File Offset: 0x0072B9E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_FinishBattleInBattleServer(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			battleComponent.m_luaExportHelper.__callBase_FinishBattleInBattleServer();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019238 RID: 102968 RVA: 0x0072D834 File Offset: 0x0072BA34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanCreateBattleRoom(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			BattleRoomType battleRoomType;
			LuaObject.checkEnum<BattleRoomType>(l, 2, out battleRoomType);
			int i = battleComponent.m_luaExportHelper.__callBase_CanCreateBattleRoom(battleRoomType);
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

	// Token: 0x06019239 RID: 102969 RVA: 0x0072D89C File Offset: 0x0072BA9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanCreateTeamBattleRoom(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			int i = battleComponent.m_luaExportHelper.__callBase_CanCreateTeamBattleRoom();
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

	// Token: 0x0601923A RID: 102970 RVA: 0x0072D8F8 File Offset: 0x0072BAF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanChangePlayerBattleStatus(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			PlayerBattleStatus status;
			LuaObject.checkEnum<PlayerBattleStatus>(l, 2, out status);
			int i = battleComponent.m_luaExportHelper.__callBase_CanChangePlayerBattleStatus(status);
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

	// Token: 0x0601923B RID: 102971 RVA: 0x0072D960 File Offset: 0x0072BB60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetArenaBattleFighting(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			battleComponent.m_luaExportHelper.__callBase_SetArenaBattleFighting();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601923C RID: 102972 RVA: 0x0072D9B4 File Offset: 0x0072BBB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetBattleId(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
				int i = battleComponent.m_luaExportHelper.__callBase_GetBattleId();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 3)
			{
				BattleComponent battleComponent2 = (BattleComponent)LuaObject.checkSelf(l);
				GameFunctionType typeId;
				LuaObject.checkEnum<GameFunctionType>(l, 2, out typeId);
				int loctionId;
				LuaObject.checkType(l, 3, out loctionId);
				int i2 = battleComponent2.m_luaExportHelper.__callBase_GetBattleId(typeId, loctionId);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_GetBattleId to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601923D RID: 102973 RVA: 0x0072DA88 File Offset: 0x0072BC88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetMonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			int i = battleComponent.m_luaExportHelper.__callBase_GetMonsterLevel();
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

	// Token: 0x0601923E RID: 102974 RVA: 0x0072DAE4 File Offset: 0x0072BCE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_AddFightHeroFightNumsAndExp(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			List<int> heroes;
			LuaObject.checkType<List<int>>(l, 2, out heroes);
			int exp;
			LuaObject.checkType(l, 3, out exp);
			battleComponent.m_luaExportHelper.__callBase_AddFightHeroFightNumsAndExp(heroes, exp);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601923F RID: 102975 RVA: 0x0072DB50 File Offset: 0x0072BD50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetPveTeam(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			List<int> o = battleComponent.m_luaExportHelper.__callBase_GetPveTeam();
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

	// Token: 0x06019240 RID: 102976 RVA: 0x0072DBAC File Offset: 0x0072BDAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsMineTeamSetValid(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			int battleId;
			LuaObject.checkType(l, 2, out battleId);
			int battleType;
			LuaObject.checkType(l, 3, out battleType);
			List<int> fightHeroes;
			LuaObject.checkType<List<int>>(l, 4, out fightHeroes);
			int i = battleComponent.m_luaExportHelper.__callBase_IsMineTeamSetValid(battleId, battleType, fightHeroes);
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

	// Token: 0x06019241 RID: 102977 RVA: 0x0072DC30 File Offset: 0x0072BE30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsArenaDefensiveTeamSetValid(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			int battleId;
			LuaObject.checkType(l, 2, out battleId);
			int teamCount;
			LuaObject.checkType(l, 3, out teamCount);
			int i = battleComponent.m_luaExportHelper.__callBase_IsArenaDefensiveTeamSetValid(battleId, teamCount);
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

	// Token: 0x06019242 RID: 102978 RVA: 0x0072DCA4 File Offset: 0x0072BEA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsActionPositionIndexValid(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			ConfigDataArenaBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataArenaBattleInfo>(l, 2, out battleInfo);
			int actionPositionIndex;
			LuaObject.checkType(l, 3, out actionPositionIndex);
			bool b = battleComponent.m_luaExportHelper.__callBase_IsActionPositionIndexValid(battleInfo, actionPositionIndex);
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

	// Token: 0x06019243 RID: 102979 RVA: 0x0072DD18 File Offset: 0x0072BF18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsActionValueValid(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			ConfigDataArenaBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataArenaBattleInfo>(l, 2, out battleInfo);
			int actionValue;
			LuaObject.checkType(l, 3, out actionValue);
			bool b = battleComponent.m_luaExportHelper.__callBase_IsActionValueValid(battleInfo, actionValue);
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

	// Token: 0x06019244 RID: 102980 RVA: 0x0072DD8C File Offset: 0x0072BF8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetMineTeam(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			int battleId;
			LuaObject.checkType(l, 2, out battleId);
			int battleType;
			LuaObject.checkType(l, 3, out battleType);
			List<int> team;
			LuaObject.checkType<List<int>>(l, 4, out team);
			int i = battleComponent.m_luaExportHelper.__callBase_SetMineTeam(battleId, battleType, team);
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

	// Token: 0x06019245 RID: 102981 RVA: 0x0072DE10 File Offset: 0x0072C010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetTeam(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 2, out battleType);
			List<int> team;
			LuaObject.checkType<List<int>>(l, 3, out team);
			battleComponent.m_luaExportHelper.__callBase_SetTeam(battleType, team);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019246 RID: 102982 RVA: 0x0072DE7C File Offset: 0x0072C07C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetTeam(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 2, out battleType);
			List<int> o = battleComponent.m_luaExportHelper.__callBase_GetTeam(battleType);
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

	// Token: 0x06019247 RID: 102983 RVA: 0x0072DEE4 File Offset: 0x0072C0E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CreateMineBattleHeroEquipments(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			ulong[] equipmentIds;
			LuaObject.checkArray<ulong>(l, 2, out equipmentIds);
			List<BattleHeroEquipment> o = battleComponent.m_luaExportHelper.__callBase_CreateMineBattleHeroEquipments(equipmentIds);
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

	// Token: 0x06019248 RID: 102984 RVA: 0x0072DF4C File Offset: 0x0072C14C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ComputeBattlePowerFromBattleHeroes(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			List<BattleHero> heroes;
			LuaObject.checkType<List<BattleHero>>(l, 2, out heroes);
			List<TrainingTech> techs;
			LuaObject.checkType<List<TrainingTech>>(l, 3, out techs);
			int i = battleComponent.m_luaExportHelper.__callBase_ComputeBattlePowerFromBattleHeroes(heroes, techs);
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

	// Token: 0x06019249 RID: 102985 RVA: 0x0072DFC0 File Offset: 0x0072C1C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ComputeBattlePower(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
				Hero hero;
				LuaObject.checkType<Hero>(l, 2, out hero);
				int i = battleComponent.m_luaExportHelper.__callBase_ComputeBattlePower(hero);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 3)
			{
				BattleComponent battleComponent2 = (BattleComponent)LuaObject.checkSelf(l);
				BattleHero hero2;
				LuaObject.checkType<BattleHero>(l, 2, out hero2);
				List<TrainingTech> techs;
				LuaObject.checkType<List<TrainingTech>>(l, 3, out techs);
				int i2 = battleComponent2.m_luaExportHelper.__callBase_ComputeBattlePower(hero2, techs);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_ComputeBattlePower to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601924A RID: 102986 RVA: 0x0072E0A4 File Offset: 0x0072C2A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_InitGainBattleTreasures(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			battleComponent.m_luaExportHelper.__callBase_InitGainBattleTreasures();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601924B RID: 102987 RVA: 0x0072E0F8 File Offset: 0x0072C2F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AddGotBattleTreasuresInThisBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			battleComponent.m_luaExportHelper.__callBase_AddGotBattleTreasuresInThisBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601924C RID: 102988 RVA: 0x0072E14C File Offset: 0x0072C34C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AddBattleTreasures(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 2, out battleTreasures);
			battleComponent.m_luaExportHelper.__callBase_AddBattleTreasures(battleTreasures);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601924D RID: 102989 RVA: 0x0072E1A8 File Offset: 0x0072C3A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetGainBattleTreasuresInThisBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			List<int> o = battleComponent.m_luaExportHelper.__callBase_GetGainBattleTreasuresInThisBattle();
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

	// Token: 0x0601924E RID: 102990 RVA: 0x0072E204 File Offset: 0x0072C404
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetAllBattleBoxTreasuresInBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			ConfigDataBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 2, out battleInfo);
			List<Goods> o = battleComponent.m_luaExportHelper.__callBase_GetAllBattleBoxTreasuresInBattle(battleInfo);
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

	// Token: 0x0601924F RID: 102991 RVA: 0x0072E26C File Offset: 0x0072C46C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnBattlePracticeMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			battleComponent.m_luaExportHelper.__callBase_OnBattlePracticeMissionEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019250 RID: 102992 RVA: 0x0072E2C0 File Offset: 0x0072C4C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleRoom(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleComponent.m_luaExportHelper.m_battleRoom);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019251 RID: 102993 RVA: 0x0072E318 File Offset: 0x0072C518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleRoom(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			BattleRoom battleRoom;
			LuaObject.checkType<BattleRoom>(l, 2, out battleRoom);
			battleComponent.m_luaExportHelper.m_battleRoom = battleRoom;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019252 RID: 102994 RVA: 0x0072E374 File Offset: 0x0072C574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleReward(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleComponent.m_luaExportHelper.m_battleReward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019253 RID: 102995 RVA: 0x0072E3CC File Offset: 0x0072C5CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_battleReward(IntPtr l)
	{
		int result;
		try
		{
			BattleComponent battleComponent = (BattleComponent)LuaObject.checkSelf(l);
			BattleReward battleReward;
			LuaObject.checkType<BattleReward>(l, 2, out battleReward);
			battleComponent.m_luaExportHelper.m_battleReward = battleReward;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019254 RID: 102996 RVA: 0x0072E428 File Offset: 0x0072C628
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.BattleComponent");
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.DeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.GetDSVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.SetBattleBase);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.GetBattleBase);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.IsRiftBattling);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.IsTreasureMapBattling);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.GetBattleTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.ClearFighting);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.SetBattleRandomSeed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.SetArenaBattleRandomSeed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.GetArenaBattleStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.GetArenaBattleId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.GetGotBattleTreasureIds);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.JoinTeamBattleRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.JoinPVPBattleRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.JoinRealtimePVPBattleRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.JoinGuildMassiveCombatBattleRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.QuitBattleRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.SetRealtimePVPBattleRoomData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.SetBattleRoomPlayerStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.InitBattleRoomPlayer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.BattleRoomHeroSetup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.BattleRoomBattleStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.AppendBattleRoomCommands);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.IsInBattleRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.GetBattleRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.GetBattleReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_IsGameFunctionOpenByMonthCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_GetDailyBonusMaxNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_GetSinglePveBattleFailEnergyCostByMonthCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_GetTeamPveBattleFailEnergyCost);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_GetTeamPveBattleFailEnergyCostByMonthCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_AddTeamPveFightFailCompensationEnergyByMonthCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_IsWaypointBattling);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_IsBattleWin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_CancelBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_IsFighting);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_CanSetupMineTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_FightFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_IsWayPointFightExist);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_WinPveBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_FinishedArenaFight);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_GetProcessingBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_SetProcessingBattleInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_SetBattleArmyRandomSeed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_GetBattleArmyRandomSeed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_SetArenaBattleInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_IsAttackingPveLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_IsAttackingArenaOpponent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_IsArenaBattleInReady);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_IsAttackingInBattleServer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_FinishBattleInBattleServer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_CanCreateBattleRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_CanCreateTeamBattleRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_CanChangePlayerBattleStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_SetArenaBattleFighting);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_GetBattleId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_GetMonsterLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_AddFightHeroFightNumsAndExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_GetPveTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_IsMineTeamSetValid);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_IsArenaDefensiveTeamSetValid);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_IsActionPositionIndexValid);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_IsActionValueValid);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_SetMineTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_SetTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_GetTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache4B);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_CreateMineBattleHeroEquipments);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache4C);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_ComputeBattlePowerFromBattleHeroes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache4D);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_ComputeBattlePower);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache4E);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_InitGainBattleTreasures);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache4F);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_AddGotBattleTreasuresInThisBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache50);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_AddBattleTreasures);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache51);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_GetGainBattleTreasuresInThisBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache52);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_GetAllBattleBoxTreasuresInBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache53);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.__callBase_OnBattlePracticeMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache54);
		string name = "m_battleRoom";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.get_m_battleRoom);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.set_m_battleRoom);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache56, true);
		string name2 = "m_battleReward";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.get_m_battleReward);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.set_m_battleReward);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache58, true);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.<>f__mg$cache59, typeof(BattleComponent), typeof(BattleComponentCommon));
	}

	// Token: 0x0400F676 RID: 63094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F677 RID: 63095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F678 RID: 63096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F679 RID: 63097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F67A RID: 63098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F67B RID: 63099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F67C RID: 63100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F67D RID: 63101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F67E RID: 63102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F67F RID: 63103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F680 RID: 63104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F681 RID: 63105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F682 RID: 63106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F683 RID: 63107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F684 RID: 63108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F685 RID: 63109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F686 RID: 63110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400F687 RID: 63111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400F688 RID: 63112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400F689 RID: 63113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400F68A RID: 63114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400F68B RID: 63115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400F68C RID: 63116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400F68D RID: 63117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400F68E RID: 63118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400F68F RID: 63119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400F690 RID: 63120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400F691 RID: 63121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400F692 RID: 63122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400F693 RID: 63123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400F694 RID: 63124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400F695 RID: 63125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400F696 RID: 63126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400F697 RID: 63127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400F698 RID: 63128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400F699 RID: 63129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400F69A RID: 63130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400F69B RID: 63131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400F69C RID: 63132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400F69D RID: 63133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400F69E RID: 63134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400F69F RID: 63135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400F6A0 RID: 63136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400F6A1 RID: 63137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400F6A2 RID: 63138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400F6A3 RID: 63139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400F6A4 RID: 63140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400F6A5 RID: 63141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400F6A6 RID: 63142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400F6A7 RID: 63143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400F6A8 RID: 63144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400F6A9 RID: 63145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400F6AA RID: 63146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400F6AB RID: 63147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400F6AC RID: 63148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400F6AD RID: 63149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400F6AE RID: 63150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400F6AF RID: 63151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400F6B0 RID: 63152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400F6B1 RID: 63153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400F6B2 RID: 63154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400F6B3 RID: 63155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400F6B4 RID: 63156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400F6B5 RID: 63157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400F6B6 RID: 63158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400F6B7 RID: 63159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400F6B8 RID: 63160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400F6B9 RID: 63161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400F6BA RID: 63162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400F6BB RID: 63163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0400F6BC RID: 63164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0400F6BD RID: 63165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0400F6BE RID: 63166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0400F6BF RID: 63167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0400F6C0 RID: 63168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0400F6C1 RID: 63169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0400F6C2 RID: 63170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0400F6C3 RID: 63171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0400F6C4 RID: 63172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0400F6C5 RID: 63173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x0400F6C6 RID: 63174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x0400F6C7 RID: 63175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x0400F6C8 RID: 63176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x0400F6C9 RID: 63177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0400F6CA RID: 63178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x0400F6CB RID: 63179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x0400F6CC RID: 63180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x0400F6CD RID: 63181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0400F6CE RID: 63182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x0400F6CF RID: 63183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;
}
