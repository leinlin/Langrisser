using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Art;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.Scene;
using FixMath.NET;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001317 RID: 4887
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientBattle : LuaObject
{
	// Token: 0x0601A2DF RID: 107231 RVA: 0x007B3BCC File Offset: 0x007B1DCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle o = new ClientBattle();
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

	// Token: 0x0601A2E0 RID: 107232 RVA: 0x007B3C14 File Offset: 0x007B1E14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Dispose(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			clientBattle.Dispose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2E1 RID: 107233 RVA: 0x007B3C60 File Offset: 0x007B1E60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Initialize(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			IClientBattleListener clientBattleListener;
			LuaObject.checkType<IClientBattleListener>(l, 2, out clientBattleListener);
			GameObject root;
			LuaObject.checkType<GameObject>(l, 3, out root);
			clientBattle.Initialize(clientBattleListener, root);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2E2 RID: 107234 RVA: 0x007B3CC4 File Offset: 0x007B1EC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			clientBattle.Tick(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2E3 RID: 107235 RVA: 0x007B3D1C File Offset: 0x007B1F1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGlobalTimeScale(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			float globalTimeScale;
			LuaObject.checkType(l, 2, out globalTimeScale);
			clientBattle.SetGlobalTimeScale(globalTimeScale);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2E4 RID: 107236 RVA: 0x007B3D74 File Offset: 0x007B1F74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Clear(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			clientBattle.Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2E5 RID: 107237 RVA: 0x007B3DC0 File Offset: 0x007B1FC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateMap(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ConfigDataBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 2, out battleInfo);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 3, out battleType);
			int myPlayerIndex;
			LuaObject.checkType(l, 4, out myPlayerIndex);
			clientBattle.CreateMap(battleInfo, battleType, myPlayerIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2E6 RID: 107238 RVA: 0x007B3E34 File Offset: 0x007B2034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateArenaMap(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ConfigDataArenaBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataArenaBattleInfo>(l, 2, out battleInfo);
			int myPlayerTeam;
			LuaObject.checkType(l, 3, out myPlayerTeam);
			clientBattle.CreateArenaMap(battleInfo, myPlayerTeam);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2E7 RID: 107239 RVA: 0x007B3E98 File Offset: 0x007B2098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreatePVPMap(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ConfigDataPVPBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataPVPBattleInfo>(l, 2, out battleInfo);
			int myPlayerIndex;
			LuaObject.checkType(l, 3, out myPlayerIndex);
			clientBattle.CreatePVPMap(battleInfo, myPlayerIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2E8 RID: 107240 RVA: 0x007B3EFC File Offset: 0x007B20FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateRealTimePVPMap(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ConfigDataRealTimePVPBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataRealTimePVPBattleInfo>(l, 2, out battleInfo);
			int myPlayerIndex;
			LuaObject.checkType(l, 3, out myPlayerIndex);
			clientBattle.CreateRealTimePVPMap(battleInfo, myPlayerIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2E9 RID: 107241 RVA: 0x007B3F60 File Offset: 0x007B2160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetMap(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			clientBattle.ResetMap();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2EA RID: 107242 RVA: 0x007B3FAC File Offset: 0x007B21AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Start(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleTeamSetup teamSetup;
			LuaObject.checkType<BattleTeamSetup>(l, 2, out teamSetup);
			BattleTeamSetup teamSetup2;
			LuaObject.checkType<BattleTeamSetup>(l, 3, out teamSetup2);
			BattlePlayer[] players;
			LuaObject.checkArray<BattlePlayer>(l, 4, out players);
			int randomSeed;
			LuaObject.checkType(l, 5, out randomSeed);
			int armyRandomSeed;
			LuaObject.checkType(l, 6, out armyRandomSeed);
			int monsterLevel;
			LuaObject.checkType(l, 7, out monsterLevel);
			int starTurnMax;
			LuaObject.checkType(l, 8, out starTurnMax);
			int starDeadMax;
			LuaObject.checkType(l, 9, out starDeadMax);
			List<ConfigDataBattleAchievementRelatedInfo> achievements;
			LuaObject.checkType<List<ConfigDataBattleAchievementRelatedInfo>>(l, 10, out achievements);
			List<int> gainBattleTreasures;
			LuaObject.checkType<List<int>>(l, 11, out gainBattleTreasures);
			clientBattle.Start(teamSetup, teamSetup2, players, randomSeed, armyRandomSeed, monsterLevel, starTurnMax, starDeadMax, achievements, gainBattleTreasures);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2EB RID: 107243 RVA: 0x007B4078 File Offset: 0x007B2278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartArena(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleTeamSetup teamSetup;
			LuaObject.checkType<BattleTeamSetup>(l, 2, out teamSetup);
			BattleTeamSetup teamSetup2;
			LuaObject.checkType<BattleTeamSetup>(l, 3, out teamSetup2);
			BattlePlayer[] players;
			LuaObject.checkArray<BattlePlayer>(l, 4, out players);
			int randomSeed;
			LuaObject.checkType(l, 5, out randomSeed);
			ConfigDataArenaDefendRuleInfo arenaDefendRuleInfo;
			LuaObject.checkType<ConfigDataArenaDefendRuleInfo>(l, 6, out arenaDefendRuleInfo);
			clientBattle.StartArena(teamSetup, teamSetup2, players, randomSeed, arenaDefendRuleInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2EC RID: 107244 RVA: 0x007B4104 File Offset: 0x007B2304
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartPVP(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleTeamSetup teamSetup;
			LuaObject.checkType<BattleTeamSetup>(l, 2, out teamSetup);
			BattleTeamSetup teamSetup2;
			LuaObject.checkType<BattleTeamSetup>(l, 3, out teamSetup2);
			BattlePlayer[] players;
			LuaObject.checkArray<BattlePlayer>(l, 4, out players);
			int randomSeed;
			LuaObject.checkType(l, 5, out randomSeed);
			clientBattle.StartPVP(teamSetup, teamSetup2, players, randomSeed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2ED RID: 107245 RVA: 0x007B4184 File Offset: 0x007B2384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartRealTimePVP(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleTeamSetup teamSetup;
			LuaObject.checkType<BattleTeamSetup>(l, 2, out teamSetup);
			BattleTeamSetup teamSetup2;
			LuaObject.checkType<BattleTeamSetup>(l, 3, out teamSetup2);
			BattlePlayer[] players;
			LuaObject.checkArray<BattlePlayer>(l, 4, out players);
			int randomSeed;
			LuaObject.checkType(l, 5, out randomSeed);
			clientBattle.StartRealTimePVP(teamSetup, teamSetup2, players, randomSeed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2EE RID: 107246 RVA: 0x007B4204 File Offset: 0x007B2404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsTeamBattle(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			bool b = clientBattle.IsTeamBattle();
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

	// Token: 0x0601A2EF RID: 107247 RVA: 0x007B4258 File Offset: 0x007B2458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetEnforceActionOrderHeros(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			List<int> enforceActionOrderHeros;
			LuaObject.checkType<List<int>>(l, 2, out enforceActionOrderHeros);
			clientBattle.SetEnforceActionOrderHeros(enforceActionOrderHeros);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2F0 RID: 107248 RVA: 0x007B42B0 File Offset: 0x007B24B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FirstStep(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			clientBattle.FirstStep();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2F1 RID: 107249 RVA: 0x007B42FC File Offset: 0x007B24FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Stop(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			bool win;
			LuaObject.checkType(l, 2, out win);
			bool skipPerform;
			LuaObject.checkType(l, 3, out skipPerform);
			clientBattle.Stop(win, skipPerform);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2F2 RID: 107250 RVA: 0x007B4360 File Offset: 0x007B2560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Pause(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			clientBattle.Pause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2F3 RID: 107251 RVA: 0x007B43B8 File Offset: 0x007B25B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAutoBattle(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			bool autoBattle;
			LuaObject.checkType(l, 2, out autoBattle);
			clientBattle.SetAutoBattle(autoBattle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2F4 RID: 107252 RVA: 0x007B4410 File Offset: 0x007B2610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetFastBattle(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			bool fastBattle;
			LuaObject.checkType(l, 2, out fastBattle);
			clientBattle.SetFastBattle(fastBattle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2F5 RID: 107253 RVA: 0x007B4468 File Offset: 0x007B2668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBattleDialog(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ConfigDataBattleDialogInfo dialogInfo;
			LuaObject.checkType<ConfigDataBattleDialogInfo>(l, 2, out dialogInfo);
			clientBattle.StartBattleDialog(dialogInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2F6 RID: 107254 RVA: 0x007B44C0 File Offset: 0x007B26C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopBattleDialog(IntPtr l)
	{
		int result2;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			int result;
			LuaObject.checkType(l, 2, out result);
			clientBattle.StopBattleDialog(result);
			LuaObject.pushValue(l, true);
			result2 = 1;
		}
		catch (Exception e)
		{
			result2 = LuaObject.error(l, e);
		}
		return result2;
	}

	// Token: 0x0601A2F7 RID: 107255 RVA: 0x007B4518 File Offset: 0x007B2718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBattleDialogResult(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			int battleDialogResult = clientBattle.GetBattleDialogResult();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleDialogResult);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2F8 RID: 107256 RVA: 0x007B456C File Offset: 0x007B276C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsWaitBattleDialog(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			bool b = clientBattle.IsWaitBattleDialog();
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

	// Token: 0x0601A2F9 RID: 107257 RVA: 0x007B45C0 File Offset: 0x007B27C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBattleTreasureDialog(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ConfigDataBattleTreasureInfo treasureInfo;
			LuaObject.checkType<ConfigDataBattleTreasureInfo>(l, 2, out treasureInfo);
			clientBattle.StartBattleTreasureDialog(treasureInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2FA RID: 107258 RVA: 0x007B4618 File Offset: 0x007B2818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopBattleTreasureDialog(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			clientBattle.StopBattleTreasureDialog();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2FB RID: 107259 RVA: 0x007B4664 File Offset: 0x007B2864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsWaitBattleTreasureDialog(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			bool b = clientBattle.IsWaitBattleTreasureDialog();
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

	// Token: 0x0601A2FC RID: 107260 RVA: 0x007B46B8 File Offset: 0x007B28B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBattleTreasureReward(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ConfigDataBattleTreasureInfo treasureInfo;
			LuaObject.checkType<ConfigDataBattleTreasureInfo>(l, 2, out treasureInfo);
			clientBattle.StartBattleTreasureReward(treasureInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2FD RID: 107261 RVA: 0x007B4710 File Offset: 0x007B2910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopBattleTreasureReward(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			clientBattle.StopBattleTreasureReward();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2FE RID: 107262 RVA: 0x007B475C File Offset: 0x007B295C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsWaitBattleTreasureReward(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			bool b = clientBattle.IsWaitBattleTreasureReward();
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

	// Token: 0x0601A2FF RID: 107263 RVA: 0x007B47B0 File Offset: 0x007B29B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartFastCombat(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			FastCombatActorInfo a;
			LuaObject.checkType<FastCombatActorInfo>(l, 2, out a);
			FastCombatActorInfo b;
			LuaObject.checkType<FastCombatActorInfo>(l, 3, out b);
			clientBattle.StartFastCombat(a, b);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A300 RID: 107264 RVA: 0x007B4814 File Offset: 0x007B2A14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopFastCombat(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			clientBattle.StopFastCombat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A301 RID: 107265 RVA: 0x007B4860 File Offset: 0x007B2A60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsWaitFastCombat(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			bool b = clientBattle.IsWaitFastCombat();
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

	// Token: 0x0601A302 RID: 107266 RVA: 0x007B48B4 File Offset: 0x007B2AB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBattlePerform(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			clientBattle.StartBattlePerform();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A303 RID: 107267 RVA: 0x007B4900 File Offset: 0x007B2B00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopBattlePerform(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			clientBattle.StopBattlePerform();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A304 RID: 107268 RVA: 0x007B494C File Offset: 0x007B2B4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsBattlePerforming(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			bool b = clientBattle.IsBattlePerforming();
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

	// Token: 0x0601A305 RID: 107269 RVA: 0x007B49A0 File Offset: 0x007B2BA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetActors(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			List<ClientBattleActor> actors = clientBattle.GetActors();
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

	// Token: 0x0601A306 RID: 107270 RVA: 0x007B49F4 File Offset: 0x007B2BF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetActor(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			ClientBattleActor actor2 = clientBattle.GetActor(actor);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, actor2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A307 RID: 107271 RVA: 0x007B4A58 File Offset: 0x007B2C58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CameraFocusActor(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ClientBattleActor ca;
			LuaObject.checkType<ClientBattleActor>(l, 2, out ca);
			clientBattle.CameraFocusActor(ca);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A308 RID: 107272 RVA: 0x007B4AB0 File Offset: 0x007B2CB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CameraFocusPosition(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			clientBattle.CameraFocusPosition(p);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A309 RID: 107273 RVA: 0x007B4B08 File Offset: 0x007B2D08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CameraFollowActor(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ClientBattleActor ca;
			LuaObject.checkType<ClientBattleActor>(l, 2, out ca);
			clientBattle.CameraFollowActor(ca);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A30A RID: 107274 RVA: 0x007B4B60 File Offset: 0x007B2D60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsCameraFocusing(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			bool b = clientBattle.IsCameraFocusing();
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

	// Token: 0x0601A30B RID: 107275 RVA: 0x007B4BB4 File Offset: 0x007B2DB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeTotalHealthPoint(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			int team;
			LuaObject.checkType(l, 2, out team);
			int i = clientBattle.ComputeTotalHealthPoint(team);
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

	// Token: 0x0601A30C RID: 107276 RVA: 0x007B4C18 File Offset: 0x007B2E18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeTotalHealthPointMax(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			int team;
			LuaObject.checkType(l, 2, out team);
			int i = clientBattle.ComputeTotalHealthPointMax(team);
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

	// Token: 0x0601A30D RID: 107277 RVA: 0x007B4C7C File Offset: 0x007B2E7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EndAllAction(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			int team;
			LuaObject.checkType(l, 2, out team);
			clientBattle.EndAllAction(team);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A30E RID: 107278 RVA: 0x007B4CD4 File Offset: 0x007B2ED4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IgnoreMoveStep(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			int step;
			LuaObject.checkType(l, 2, out step);
			clientBattle.IgnoreMoveStep(step);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A30F RID: 107279 RVA: 0x007B4D2C File Offset: 0x007B2F2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IgnoreSkillStep(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			int step;
			LuaObject.checkType(l, 2, out step);
			clientBattle.IgnoreSkillStep(step);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A310 RID: 107280 RVA: 0x007B4D84 File Offset: 0x007B2F84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IgnoreTeleportDisappearStep(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			int step;
			LuaObject.checkType(l, 2, out step);
			clientBattle.IgnoreTeleportDisappearStep(step);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A311 RID: 107281 RVA: 0x007B4DDC File Offset: 0x007B2FDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GridPositionToWorldPosition(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			Vector2 o = clientBattle.GridPositionToWorldPosition(p);
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

	// Token: 0x0601A312 RID: 107282 RVA: 0x007B4E40 File Offset: 0x007B3040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldPositionToGridPosition(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			Vector2 sp;
			LuaObject.checkType(l, 2, out sp);
			GridPosition gridPosition = clientBattle.WorldPositionToGridPosition(sp);
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

	// Token: 0x0601A313 RID: 107283 RVA: 0x007B4EA8 File Offset: 0x007B30A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ScreenPositionToWorldPosition(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			Vector2 p;
			LuaObject.checkType(l, 2, out p);
			Vector2 o = clientBattle.ScreenPositionToWorldPosition(p);
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

	// Token: 0x0601A314 RID: 107284 RVA: 0x007B4F0C File Offset: 0x007B310C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ScreenPositionToGridPosition(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			Vector2 p;
			LuaObject.checkType(l, 2, out p);
			GridPosition gridPosition = clientBattle.ScreenPositionToGridPosition(p);
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

	// Token: 0x0601A315 RID: 107285 RVA: 0x007B4F74 File Offset: 0x007B3174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GridPositionToScreenPosition(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			Vector2 o = clientBattle.GridPositionToScreenPosition(p);
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

	// Token: 0x0601A316 RID: 107286 RVA: 0x007B4FD8 File Offset: 0x007B31D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DrawLine(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, num, 2, typeof(Vector2i), typeof(Vector2i), typeof(Colori)))
			{
				ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
				Vector2i p;
				LuaObject.checkValueType<Vector2i>(l, 2, out p);
				Vector2i p2;
				LuaObject.checkValueType<Vector2i>(l, 3, out p2);
				Colori color;
				LuaObject.checkValueType<Colori>(l, 4, out color);
				clientBattle.DrawLine(p, p2, color);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(Vector3), typeof(Vector3), typeof(Color)))
			{
				ClientBattle clientBattle2 = (ClientBattle)LuaObject.checkSelf(l);
				Vector3 p3;
				LuaObject.checkType(l, 2, out p3);
				Vector3 p4;
				LuaObject.checkType(l, 3, out p4);
				Color color2;
				LuaObject.checkType(l, 4, out color2);
				clientBattle2.DrawLine(p3, p4, color2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 6)
			{
				ClientBattle clientBattle3 = (ClientBattle)LuaObject.checkSelf(l);
				Vector2i p5;
				LuaObject.checkValueType<Vector2i>(l, 2, out p5);
				Fix64 z;
				LuaObject.checkValueType<Fix64>(l, 3, out z);
				Vector2i p6;
				LuaObject.checkValueType<Vector2i>(l, 4, out p6);
				Fix64 z2;
				LuaObject.checkValueType<Fix64>(l, 5, out z2);
				Colori color3;
				LuaObject.checkValueType<Colori>(l, 6, out color3);
				clientBattle3.DrawLine(p5, z, p6, z2, color3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function DrawLine to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A317 RID: 107287 RVA: 0x007B517C File Offset: 0x007B337C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DrawGrid(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			float scale;
			LuaObject.checkType(l, 3, out scale);
			Color color;
			LuaObject.checkType(l, 4, out color);
			bool cross;
			LuaObject.checkType(l, 5, out cross);
			clientBattle.DrawGrid(p, scale, color, cross);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A318 RID: 107288 RVA: 0x007B51FC File Offset: 0x007B33FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateBattleGraphic(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			float scale;
			LuaObject.checkType(l, 3, out scale);
			GenericGraphic o = clientBattle.CreateBattleGraphic(assetName, scale);
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

	// Token: 0x0601A319 RID: 107289 RVA: 0x007B526C File Offset: 0x007B346C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroyBattleGraphic(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			GenericGraphic graphic;
			LuaObject.checkType<GenericGraphic>(l, 2, out graphic);
			clientBattle.DestroyBattleGraphic(graphic);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A31A RID: 107290 RVA: 0x007B52C4 File Offset: 0x007B34C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleActorTryMove(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 3, out p);
			int dir;
			LuaObject.checkType(l, 4, out dir);
			clientBattle.BattleActorTryMove(a, p, dir);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A31B RID: 107291 RVA: 0x007B5338 File Offset: 0x007B3538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateActor(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			ClientBattleActor o = clientBattle.CreateActor(a);
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

	// Token: 0x0601A31C RID: 107292 RVA: 0x007B539C File Offset: 0x007B359C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTreasure(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ConfigDataBattleTreasureInfo treasureInfo;
			LuaObject.checkType<ConfigDataBattleTreasureInfo>(l, 2, out treasureInfo);
			ClientBattleTreasure treasure = clientBattle.GetTreasure(treasureInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasure);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A31D RID: 107293 RVA: 0x007B5400 File Offset: 0x007B3600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetNextEntityId(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			int nextEntityId = clientBattle.GetNextEntityId();
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

	// Token: 0x0601A31E RID: 107294 RVA: 0x007B5454 File Offset: 0x007B3654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayScreenEffect(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			clientBattle.PlayScreenEffect(name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A31F RID: 107295 RVA: 0x007B54AC File Offset: 0x007B36AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ChangeMapTerrainFx(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			ConfigDataTerrainInfo terrainInfo;
			LuaObject.checkType<ConfigDataTerrainInfo>(l, 3, out terrainInfo);
			clientBattle.ChangeMapTerrainFx(p, terrainInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A320 RID: 107296 RVA: 0x007B5510 File Offset: 0x007B3710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RebuildBattle(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
				LocalProcessingBattleData data;
				LuaObject.checkType<LocalProcessingBattleData>(l, 2, out data);
				clientBattle.RebuildBattle(data);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				ClientBattle clientBattle2 = (ClientBattle)LuaObject.checkSelf(l);
				List<BattleCommand> commands;
				LuaObject.checkType<List<BattleCommand>>(l, 2, out commands);
				int fromStep;
				LuaObject.checkType(l, 3, out fromStep);
				int toStep;
				LuaObject.checkType(l, 4, out toStep);
				clientBattle2.RebuildBattle(commands, fromStep, toStep);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function RebuildBattle to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A321 RID: 107297 RVA: 0x007B55E0 File Offset: 0x007B37E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsRebuildingBattle(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			bool b = clientBattle.IsRebuildingBattle();
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

	// Token: 0x0601A322 RID: 107298 RVA: 0x007B5634 File Offset: 0x007B3834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopRebuildingBattle(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			clientBattle.StopRebuildingBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A323 RID: 107299 RVA: 0x007B5680 File Offset: 0x007B3880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSkipCombatMode(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			SkipCombatMode skipCombatMode;
			LuaObject.checkEnum<SkipCombatMode>(l, 2, out skipCombatMode);
			clientBattle.SetSkipCombatMode(skipCombatMode);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A324 RID: 107300 RVA: 0x007B56D8 File Offset: 0x007B38D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsSkippingCombat(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			bool checkState;
			LuaObject.checkType(l, 2, out checkState);
			bool b = clientBattle.IsSkippingCombat(checkState);
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

	// Token: 0x0601A325 RID: 107301 RVA: 0x007B573C File Offset: 0x007B393C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeCombatArmyRelationValue(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			BattleActor b;
			LuaObject.checkType<BattleActor>(l, 3, out b);
			bool isMagic;
			LuaObject.checkType(l, 4, out isMagic);
			int i = clientBattle.ComputeCombatArmyRelationValue(a, b, isMagic);
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

	// Token: 0x0601A326 RID: 107302 RVA: 0x007B57B8 File Offset: 0x007B39B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsCombatMagicAttack(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor attacker;
			LuaObject.checkType<BattleActor>(l, 2, out attacker);
			BattleActor target;
			LuaObject.checkType<BattleActor>(l, 3, out target);
			ConfigDataSkillInfo attackerSkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 4, out attackerSkillInfo);
			bool b = clientBattle.IsCombatMagicAttack(attacker, target, attackerSkillInfo);
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

	// Token: 0x0601A327 RID: 107303 RVA: 0x007B5834 File Offset: 0x007B3A34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnableSdkLogBattle(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			bool enable;
			LuaObject.checkType(l, 2, out enable);
			clientBattle.EnableSdkLogBattle(enable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A328 RID: 107304 RVA: 0x007B588C File Offset: 0x007B3A8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMyPlayerIndex(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			int myPlayerIndex = clientBattle.GetMyPlayerIndex();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, myPlayerIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A329 RID: 107305 RVA: 0x007B58E0 File Offset: 0x007B3AE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMyPlayerTeamNumber(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			int myPlayerTeamNumber = clientBattle.GetMyPlayerTeamNumber();
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

	// Token: 0x0601A32A RID: 107306 RVA: 0x007B5934 File Offset: 0x007B3B34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsAnyActorHasAct(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			bool b = clientBattle.IsAnyActorHasAct();
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

	// Token: 0x0601A32B RID: 107307 RVA: 0x007B5988 File Offset: 0x007B3B88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasWaitingAct(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			int step;
			LuaObject.checkType(l, 3, out step);
			bool b = clientBattle.HasWaitingAct(a, step);
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

	// Token: 0x0601A32C RID: 107308 RVA: 0x007B59F8 File Offset: 0x007B3BF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnActorActive(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ClientBattleActor a;
			LuaObject.checkType<ClientBattleActor>(l, 2, out a);
			bool newStep;
			LuaObject.checkType(l, 3, out newStep);
			int step;
			LuaObject.checkType(l, 4, out step);
			clientBattle.OnActorActive(a, newStep, step);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A32D RID: 107309 RVA: 0x007B5A6C File Offset: 0x007B3C6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnActorPreStartCombat(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ClientBattleActor a;
			LuaObject.checkType<ClientBattleActor>(l, 2, out a);
			clientBattle.OnActorPreStartCombat(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A32E RID: 107310 RVA: 0x007B5AC4 File Offset: 0x007B3CC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnActorStopCombatEnd(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ClientBattleActor a;
			LuaObject.checkType<ClientBattleActor>(l, 2, out a);
			clientBattle.OnActorStopCombatEnd(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A32F RID: 107311 RVA: 0x007B5B1C File Offset: 0x007B3D1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnActorCastSkill(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ClientBattleActor a;
			LuaObject.checkType<ClientBattleActor>(l, 2, out a);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skillInfo);
			GridPosition targetPos;
			LuaObject.checkValueType<GridPosition>(l, 4, out targetPos);
			clientBattle.OnActorCastSkill(a, skillInfo, targetPos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A330 RID: 107312 RVA: 0x007B5B90 File Offset: 0x007B3D90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnActorCastSkillEnd(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ClientBattleActor a;
			LuaObject.checkType<ClientBattleActor>(l, 2, out a);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skillInfo);
			clientBattle.OnActorCastSkillEnd(a, skillInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A331 RID: 107313 RVA: 0x007B5BF4 File Offset: 0x007B3DF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorCreate(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			bool visible;
			LuaObject.checkType(l, 3, out visible);
			clientBattle.OnBattleActorCreate(a, visible);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A332 RID: 107314 RVA: 0x007B5C58 File Offset: 0x007B3E58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorCreateEnd(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			clientBattle.OnBattleActorCreateEnd(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A333 RID: 107315 RVA: 0x007B5CB0 File Offset: 0x007B3EB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorActive(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			bool newStep;
			LuaObject.checkType(l, 3, out newStep);
			clientBattle.OnBattleActorActive(a, newStep);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A334 RID: 107316 RVA: 0x007B5D14 File Offset: 0x007B3F14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorActionBegin(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			clientBattle.OnBattleActorActionBegin(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A335 RID: 107317 RVA: 0x007B5D6C File Offset: 0x007B3F6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorActionEnd(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			clientBattle.OnBattleActorActionEnd(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A336 RID: 107318 RVA: 0x007B5DC4 File Offset: 0x007B3FC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorMove(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 3, out p);
			int dir;
			LuaObject.checkType(l, 4, out dir);
			clientBattle.OnBattleActorMove(a, p, dir);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A337 RID: 107319 RVA: 0x007B5E38 File Offset: 0x007B4038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorPerformMove(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 3, out p);
			int dir;
			LuaObject.checkType(l, 4, out dir);
			bool cameraFollow;
			LuaObject.checkType(l, 5, out cameraFollow);
			clientBattle.OnBattleActorPerformMove(a, p, dir, cameraFollow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A338 RID: 107320 RVA: 0x007B5EB8 File Offset: 0x007B40B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorPunchMove(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			string fxName;
			LuaObject.checkType(l, 3, out fxName);
			bool isDragExchange;
			LuaObject.checkType(l, 4, out isDragExchange);
			clientBattle.OnBattleActorPunchMove(a, fxName, isDragExchange);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A339 RID: 107321 RVA: 0x007B5F2C File Offset: 0x007B412C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorExchangeMove(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			BattleActor b;
			LuaObject.checkType<BattleActor>(l, 3, out b);
			int moveType;
			LuaObject.checkType(l, 4, out moveType);
			string fxName;
			LuaObject.checkType(l, 5, out fxName);
			clientBattle.OnBattleActorExchangeMove(a, b, moveType, fxName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A33A RID: 107322 RVA: 0x007B5FAC File Offset: 0x007B41AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorSetDir(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			int dir;
			LuaObject.checkType(l, 3, out dir);
			clientBattle.OnBattleActorSetDir(a, dir);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A33B RID: 107323 RVA: 0x007B6010 File Offset: 0x007B4210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorPlayFx(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			string fxName;
			LuaObject.checkType(l, 3, out fxName);
			int attachMode;
			LuaObject.checkType(l, 4, out attachMode);
			clientBattle.OnBattleActorPlayFx(a, fxName, attachMode);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A33C RID: 107324 RVA: 0x007B6084 File Offset: 0x007B4284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorPlayAnimation(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			string animationName;
			LuaObject.checkType(l, 3, out animationName);
			int animationTime;
			LuaObject.checkType(l, 4, out animationTime);
			clientBattle.OnBattleActorPlayAnimation(a, animationName, animationTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A33D RID: 107325 RVA: 0x007B60F8 File Offset: 0x007B42F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorChangeIdleAnimation(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			string idleAnimationName;
			LuaObject.checkType(l, 3, out idleAnimationName);
			clientBattle.OnBattleActorChangeIdleAnimation(a, idleAnimationName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A33E RID: 107326 RVA: 0x007B615C File Offset: 0x007B435C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorSkill(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			ConfigDataSkillInfo skill;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skill);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 4, out p);
			clientBattle.OnBattleActorSkill(a, skill, p);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A33F RID: 107327 RVA: 0x007B61D0 File Offset: 0x007B43D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorSkillHitBegin(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skillInfo);
			bool isRebound;
			LuaObject.checkType(l, 4, out isRebound);
			clientBattle.OnBattleActorSkillHitBegin(a, skillInfo, isRebound);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A340 RID: 107328 RVA: 0x007B6244 File Offset: 0x007B4444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorSkillHit(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			ConfigDataSkillInfo skill;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skill);
			int heroHpModify;
			LuaObject.checkType(l, 4, out heroHpModify);
			int soldierHpModify;
			LuaObject.checkType(l, 5, out soldierHpModify);
			DamageNumberType damageNumberType;
			LuaObject.checkEnum<DamageNumberType>(l, 6, out damageNumberType);
			bool isRebound;
			LuaObject.checkType(l, 7, out isRebound);
			clientBattle.OnBattleActorSkillHit(a, skill, heroHpModify, soldierHpModify, damageNumberType, isRebound);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A341 RID: 107329 RVA: 0x007B62DC File Offset: 0x007B44DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorSkillHitEnd(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skillInfo);
			bool isRebound;
			LuaObject.checkType(l, 4, out isRebound);
			clientBattle.OnBattleActorSkillHitEnd(a, skillInfo, isRebound);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A342 RID: 107330 RVA: 0x007B6350 File Offset: 0x007B4550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorAttachBuff(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			BuffState buffState;
			LuaObject.checkType<BuffState>(l, 3, out buffState);
			clientBattle.OnBattleActorAttachBuff(a, buffState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A343 RID: 107331 RVA: 0x007B63B4 File Offset: 0x007B45B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorDetachBuff(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			BuffState buffState;
			LuaObject.checkType<BuffState>(l, 3, out buffState);
			clientBattle.OnBattleActorDetachBuff(a, buffState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A344 RID: 107332 RVA: 0x007B6418 File Offset: 0x007B4618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorImmune(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			clientBattle.OnBattleActorImmune(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A345 RID: 107333 RVA: 0x007B6470 File Offset: 0x007B4670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorPassiveSkill(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			BattleActor target;
			LuaObject.checkType<BattleActor>(l, 3, out target);
			BuffState sourceBuffState;
			LuaObject.checkType<BuffState>(l, 4, out sourceBuffState);
			clientBattle.OnBattleActorPassiveSkill(a, target, sourceBuffState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A346 RID: 107334 RVA: 0x007B64E4 File Offset: 0x007B46E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorBuffHit(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			BuffState buffState;
			LuaObject.checkType<BuffState>(l, 3, out buffState);
			int heroHpModify;
			LuaObject.checkType(l, 4, out heroHpModify);
			int soldierHpModify;
			LuaObject.checkType(l, 5, out soldierHpModify);
			DamageNumberType damageNumberType;
			LuaObject.checkEnum<DamageNumberType>(l, 6, out damageNumberType);
			clientBattle.OnBattleActorBuffHit(a, buffState, heroHpModify, soldierHpModify, damageNumberType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A347 RID: 107335 RVA: 0x007B6570 File Offset: 0x007B4770
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorTerrainHit(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			ConfigDataTerrainInfo terrainInfo;
			LuaObject.checkType<ConfigDataTerrainInfo>(l, 3, out terrainInfo);
			int heroHpModify;
			LuaObject.checkType(l, 4, out heroHpModify);
			int soldierHpModify;
			LuaObject.checkType(l, 5, out soldierHpModify);
			DamageNumberType damageNumberType;
			LuaObject.checkEnum<DamageNumberType>(l, 6, out damageNumberType);
			clientBattle.OnBattleActorTerrainHit(a, terrainInfo, heroHpModify, soldierHpModify, damageNumberType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A348 RID: 107336 RVA: 0x007B65FC File Offset: 0x007B47FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorTeleport(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			ConfigDataSkillInfo skill;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skill);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 4, out p);
			clientBattle.OnBattleActorTeleport(a, skill, p);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A349 RID: 107337 RVA: 0x007B6670 File Offset: 0x007B4870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorTeleportDisappear(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			ConfigDataSkillInfo skill;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skill);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 4, out p);
			clientBattle.OnBattleActorTeleportDisappear(a, skill, p);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A34A RID: 107338 RVA: 0x007B66E4 File Offset: 0x007B48E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorTeleportAppear(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			ConfigDataSkillInfo skill;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skill);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 4, out p);
			clientBattle.OnBattleActorTeleportAppear(a, skill, p);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A34B RID: 107339 RVA: 0x007B6758 File Offset: 0x007B4958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorSummon(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skillInfo);
			clientBattle.OnBattleActorSummon(a, skillInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A34C RID: 107340 RVA: 0x007B67BC File Offset: 0x007B49BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorDie(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			bool isAfterCombat;
			LuaObject.checkType(l, 3, out isAfterCombat);
			clientBattle.OnBattleActorDie(a, isAfterCombat);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A34D RID: 107341 RVA: 0x007B6820 File Offset: 0x007B4A20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorAppear(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			int effectType;
			LuaObject.checkType(l, 3, out effectType);
			string fxName;
			LuaObject.checkType(l, 4, out fxName);
			clientBattle.OnBattleActorAppear(a, effectType, fxName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A34E RID: 107342 RVA: 0x007B6894 File Offset: 0x007B4A94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorDisappear(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			int effectType;
			LuaObject.checkType(l, 3, out effectType);
			string fxName;
			LuaObject.checkType(l, 4, out fxName);
			clientBattle.OnBattleActorDisappear(a, effectType, fxName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A34F RID: 107343 RVA: 0x007B6908 File Offset: 0x007B4B08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorChangeTeam(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			clientBattle.OnBattleActorChangeTeam(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A350 RID: 107344 RVA: 0x007B6960 File Offset: 0x007B4B60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorChangeArmy(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			clientBattle.OnBattleActorChangeArmy(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A351 RID: 107345 RVA: 0x007B69B8 File Offset: 0x007B4BB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorReplace(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			BattleActor a2;
			LuaObject.checkType<BattleActor>(l, 3, out a2);
			string fxName;
			LuaObject.checkType(l, 4, out fxName);
			clientBattle.OnBattleActorReplace(a, a2, fxName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A352 RID: 107346 RVA: 0x007B6A2C File Offset: 0x007B4C2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorCameraFocus(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			clientBattle.OnBattleActorCameraFocus(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A353 RID: 107347 RVA: 0x007B6A84 File Offset: 0x007B4C84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleActorGainBattleTreasure(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			ConfigDataBattleTreasureInfo treasureInfo;
			LuaObject.checkType<ConfigDataBattleTreasureInfo>(l, 3, out treasureInfo);
			clientBattle.OnBattleActorGainBattleTreasure(a, treasureInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A354 RID: 107348 RVA: 0x007B6AE8 File Offset: 0x007B4CE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStartGuard(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			BattleActor target;
			LuaObject.checkType<BattleActor>(l, 3, out target);
			clientBattle.OnStartGuard(a, target);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A355 RID: 107349 RVA: 0x007B6B4C File Offset: 0x007B4D4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStopGuard(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			BattleActor target;
			LuaObject.checkType<BattleActor>(l, 3, out target);
			clientBattle.OnStopGuard(a, target);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A356 RID: 107350 RVA: 0x007B6BB0 File Offset: 0x007B4DB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBeforeStartCombat(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			BattleActor b;
			LuaObject.checkType<BattleActor>(l, 3, out b);
			ConfigDataSkillInfo attackerSkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 4, out attackerSkillInfo);
			clientBattle.OnBeforeStartCombat(a, b, attackerSkillInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A357 RID: 107351 RVA: 0x007B6C24 File Offset: 0x007B4E24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCancelCombat(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			clientBattle.OnCancelCombat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A358 RID: 107352 RVA: 0x007B6C70 File Offset: 0x007B4E70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStartCombat(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			BattleActor b;
			LuaObject.checkType<BattleActor>(l, 3, out b);
			ConfigDataSkillInfo attackerSkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 4, out attackerSkillInfo);
			clientBattle.OnStartCombat(a, b, attackerSkillInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A359 RID: 107353 RVA: 0x007B6CE4 File Offset: 0x007B4EE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPreStopCombat(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			clientBattle.OnPreStopCombat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A35A RID: 107354 RVA: 0x007B6D30 File Offset: 0x007B4F30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStopCombat(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			int teamAHeroTotalDamage;
			LuaObject.checkType(l, 2, out teamAHeroTotalDamage);
			int teamASoldierTotalDamage;
			LuaObject.checkType(l, 3, out teamASoldierTotalDamage);
			bool teamACriticalAttack;
			LuaObject.checkType(l, 4, out teamACriticalAttack);
			int teamBHeroTotalDamage;
			LuaObject.checkType(l, 5, out teamBHeroTotalDamage);
			int teamBSoldierTotalDamage;
			LuaObject.checkType(l, 6, out teamBSoldierTotalDamage);
			bool teamBCriticalAttack;
			LuaObject.checkType(l, 7, out teamBCriticalAttack);
			clientBattle.OnStopCombat(teamAHeroTotalDamage, teamASoldierTotalDamage, teamACriticalAttack, teamBHeroTotalDamage, teamBSoldierTotalDamage, teamBCriticalAttack);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A35B RID: 107355 RVA: 0x007B6DC8 File Offset: 0x007B4FC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleNextTurn(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			int turn;
			LuaObject.checkType(l, 2, out turn);
			clientBattle.OnBattleNextTurn(turn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A35C RID: 107356 RVA: 0x007B6E20 File Offset: 0x007B5020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleNextTeam(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			int team;
			LuaObject.checkType(l, 2, out team);
			bool isNpc;
			LuaObject.checkType(l, 3, out isNpc);
			clientBattle.OnBattleNextTeam(team, isNpc);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A35D RID: 107357 RVA: 0x007B6E84 File Offset: 0x007B5084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleNextPlayer(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			int prevPlayerIndex;
			LuaObject.checkType(l, 2, out prevPlayerIndex);
			int playerIndex;
			LuaObject.checkType(l, 3, out playerIndex);
			clientBattle.OnBattleNextPlayer(prevPlayerIndex, playerIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A35E RID: 107358 RVA: 0x007B6EE8 File Offset: 0x007B50E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleNextActor(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			clientBattle.OnBattleNextActor(actor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A35F RID: 107359 RVA: 0x007B6F40 File Offset: 0x007B5140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCombatActorHit(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			CombatActor a;
			LuaObject.checkType<CombatActor>(l, 2, out a);
			CombatActor attacker;
			LuaObject.checkType<CombatActor>(l, 3, out attacker);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 4, out skillInfo);
			int hpModify;
			LuaObject.checkType(l, 5, out hpModify);
			int totalDamage;
			LuaObject.checkType(l, 6, out totalDamage);
			DamageNumberType damageNumberType;
			LuaObject.checkEnum<DamageNumberType>(l, 7, out damageNumberType);
			clientBattle.OnCombatActorHit(a, attacker, skillInfo, hpModify, totalDamage, damageNumberType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A360 RID: 107360 RVA: 0x007B6FD8 File Offset: 0x007B51D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCombatActorDie(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			CombatActor a;
			LuaObject.checkType<CombatActor>(l, 2, out a);
			clientBattle.OnCombatActorDie(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A361 RID: 107361 RVA: 0x007B7030 File Offset: 0x007B5230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStartSkillCutscene(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			ConfigDataCutsceneInfo cutsceneInfo;
			LuaObject.checkType<ConfigDataCutsceneInfo>(l, 3, out cutsceneInfo);
			int team;
			LuaObject.checkType(l, 4, out team);
			clientBattle.OnStartSkillCutscene(skillInfo, cutsceneInfo, team);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A362 RID: 107362 RVA: 0x007B70A4 File Offset: 0x007B52A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStartPassiveSkillCutscene(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BuffState sourceBuffState;
			LuaObject.checkType<BuffState>(l, 2, out sourceBuffState);
			int team;
			LuaObject.checkType(l, 3, out team);
			clientBattle.OnStartPassiveSkillCutscene(sourceBuffState, team);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A363 RID: 107363 RVA: 0x007B7108 File Offset: 0x007B5308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStopSkillCutscene(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			clientBattle.OnStopSkillCutscene();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A364 RID: 107364 RVA: 0x007B7154 File Offset: 0x007B5354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStartBattleDialog(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ConfigDataBattleDialogInfo dialogInfo;
			LuaObject.checkType<ConfigDataBattleDialogInfo>(l, 2, out dialogInfo);
			clientBattle.OnStartBattleDialog(dialogInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A365 RID: 107365 RVA: 0x007B71AC File Offset: 0x007B53AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStartBattlePerform(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ConfigDataBattlePerformInfo performInfo;
			LuaObject.checkType<ConfigDataBattlePerformInfo>(l, 2, out performInfo);
			clientBattle.OnStartBattlePerform(performInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A366 RID: 107366 RVA: 0x007B7204 File Offset: 0x007B5404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStopBattlePerform(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			clientBattle.OnStopBattlePerform();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A367 RID: 107367 RVA: 0x007B7250 File Offset: 0x007B5450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChangeMapTerrain(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			ConfigDataTerrainInfo terrainInfo;
			LuaObject.checkType<ConfigDataTerrainInfo>(l, 3, out terrainInfo);
			clientBattle.OnChangeMapTerrain(p, terrainInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A368 RID: 107368 RVA: 0x007B72B4 File Offset: 0x007B54B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCameraFocus(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			clientBattle.OnCameraFocus(p);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A369 RID: 107369 RVA: 0x007B730C File Offset: 0x007B550C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPlayMusic(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			string musicName;
			LuaObject.checkType(l, 2, out musicName);
			clientBattle.OnPlayMusic(musicName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A36A RID: 107370 RVA: 0x007B7364 File Offset: 0x007B5564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPlaySound(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			string soundName;
			LuaObject.checkType(l, 2, out soundName);
			clientBattle.OnPlaySound(soundName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A36B RID: 107371 RVA: 0x007B73BC File Offset: 0x007B55BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPlayFx(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			string fxName;
			LuaObject.checkType(l, 2, out fxName);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 3, out p);
			clientBattle.OnPlayFx(fxName, p);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A36C RID: 107372 RVA: 0x007B7420 File Offset: 0x007B5620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnWaitTime(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			int timeInMs;
			LuaObject.checkType(l, 2, out timeInMs);
			clientBattle.OnWaitTime(timeInMs);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A36D RID: 107373 RVA: 0x007B7478 File Offset: 0x007B5678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleTreasureCreate(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ConfigDataBattleTreasureInfo treasureInfo;
			LuaObject.checkType<ConfigDataBattleTreasureInfo>(l, 2, out treasureInfo);
			bool isOpened;
			LuaObject.checkType(l, 3, out isOpened);
			clientBattle.OnBattleTreasureCreate(treasureInfo, isOpened);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A36E RID: 107374 RVA: 0x007B74DC File Offset: 0x007B56DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateCombatGraphic(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			float scale;
			LuaObject.checkType(l, 3, out scale);
			IBattleGraphic o = clientBattle.CreateCombatGraphic(assetName, scale);
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

	// Token: 0x0601A36F RID: 107375 RVA: 0x007B754C File Offset: 0x007B574C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroyCombatGraphic(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			IBattleGraphic g;
			LuaObject.checkType<IBattleGraphic>(l, 2, out g);
			clientBattle.DestroyCombatGraphic(g);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A370 RID: 107376 RVA: 0x007B75A4 File Offset: 0x007B57A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayFx(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			float scale;
			LuaObject.checkType(l, 3, out scale);
			IBattleGraphic o = clientBattle.PlayFx(assetName, scale);
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

	// Token: 0x0601A371 RID: 107377 RVA: 0x007B7614 File Offset: 0x007B5814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlaySound(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				clientBattle.PlaySound(name);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(SoundTableId)))
			{
				ClientBattle clientBattle2 = (ClientBattle)LuaObject.checkSelf(l);
				SoundTableId id;
				LuaObject.checkEnum<SoundTableId>(l, 2, out id);
				clientBattle2.PlaySound(id);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function PlaySound to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A372 RID: 107378 RVA: 0x007B76EC File Offset: 0x007B58EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsCombatGraphicMirrorX(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			bool b = clientBattle.IsCombatGraphicMirrorX();
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

	// Token: 0x0601A373 RID: 107379 RVA: 0x007B7740 File Offset: 0x007B5940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAudio(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			FxEvent e;
			LuaObject.checkType<FxEvent>(l, 2, out e);
			AudioClip a;
			LuaObject.checkType<AudioClip>(l, 3, out a);
			clientBattle.OnAudio(e, a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x0601A374 RID: 107380 RVA: 0x007B77A4 File Offset: 0x007B59A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSound(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			FxEvent e;
			LuaObject.checkType<FxEvent>(l, 2, out e);
			string name;
			LuaObject.checkType(l, 3, out name);
			clientBattle.OnSound(e, name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x0601A375 RID: 107381 RVA: 0x007B7808 File Offset: 0x007B5A08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCameraEffect(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			FxEvent e;
			LuaObject.checkType<FxEvent>(l, 2, out e);
			string name;
			LuaObject.checkType(l, 3, out name);
			clientBattle.OnCameraEffect(e, name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x0601A376 RID: 107382 RVA: 0x007B786C File Offset: 0x007B5A6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnScreenEffect(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			FxEvent e;
			LuaObject.checkType<FxEvent>(l, 2, out e);
			string name;
			LuaObject.checkType(l, 3, out name);
			clientBattle.OnScreenEffect(e, name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x0601A377 RID: 107383 RVA: 0x007B78D0 File Offset: 0x007B5AD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGeneral(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			FxEvent e;
			LuaObject.checkType<FxEvent>(l, 2, out e);
			string name;
			LuaObject.checkType(l, 3, out name);
			clientBattle.OnGeneral(e, name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x0601A378 RID: 107384 RVA: 0x007B7934 File Offset: 0x007B5B34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCameraPosition(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			Vector3 cameraPosition = clientBattle.GetCameraPosition();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cameraPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A379 RID: 107385 RVA: 0x007B7988 File Offset: 0x007B5B88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CombatPositionToWorldPosition(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			Vector2i p;
			LuaObject.checkValueType<Vector2i>(l, 2, out p);
			Fix64 z;
			LuaObject.checkValueType<Fix64>(l, 3, out z);
			bool computeZOffset;
			LuaObject.checkType(l, 4, out computeZOffset);
			Vector3 o = clientBattle.CombatPositionToWorldPosition(p, z, computeZOffset);
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

	// Token: 0x0601A37A RID: 107386 RVA: 0x007B7A04 File Offset: 0x007B5C04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsCulled(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			Vector2 bmin;
			LuaObject.checkType(l, 2, out bmin);
			Vector2 bmax;
			LuaObject.checkType(l, 3, out bmax);
			bool isCombat;
			LuaObject.checkType(l, 4, out isCombat);
			bool b = clientBattle.IsCulled(bmin, bmax, isCombat);
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

	// Token: 0x0601A37B RID: 107387 RVA: 0x007B7A80 File Offset: 0x007B5C80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogBattleStart(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			clientBattle.LogBattleStart();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A37C RID: 107388 RVA: 0x007B7ACC File Offset: 0x007B5CCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogBattleStop(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			bool isWin;
			LuaObject.checkType(l, 2, out isWin);
			clientBattle.LogBattleStop(isWin);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A37D RID: 107389 RVA: 0x007B7B24 File Offset: 0x007B5D24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogBattleTeam(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleTeam team;
			LuaObject.checkType<BattleTeam>(l, 2, out team);
			BattleTeam team2;
			LuaObject.checkType<BattleTeam>(l, 3, out team2);
			clientBattle.LogBattleTeam(team, team2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A37E RID: 107390 RVA: 0x007B7B88 File Offset: 0x007B5D88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogActorMove(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			GridPosition fromPos;
			LuaObject.checkValueType<GridPosition>(l, 3, out fromPos);
			GridPosition toPos;
			LuaObject.checkValueType<GridPosition>(l, 4, out toPos);
			clientBattle.LogActorMove(actor, fromPos, toPos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A37F RID: 107391 RVA: 0x007B7BFC File Offset: 0x007B5DFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogActorStandby(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			clientBattle.LogActorStandby(actor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A380 RID: 107392 RVA: 0x007B7C54 File Offset: 0x007B5E54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogActorAttack(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			BattleActor targetActor;
			LuaObject.checkType<BattleActor>(l, 3, out targetActor);
			clientBattle.LogActorAttack(actor, targetActor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A381 RID: 107393 RVA: 0x007B7CB8 File Offset: 0x007B5EB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogActorSkill(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skillInfo);
			BattleActor targetActor;
			LuaObject.checkType<BattleActor>(l, 4, out targetActor);
			GridPosition targetPos;
			LuaObject.checkValueType<GridPosition>(l, 5, out targetPos);
			clientBattle.LogActorSkill(actor, skillInfo, targetActor, targetPos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A382 RID: 107394 RVA: 0x007B7D38 File Offset: 0x007B5F38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogActorDie(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			BattleActor killerActor;
			LuaObject.checkType<BattleActor>(l, 3, out killerActor);
			clientBattle.LogActorDie(actor, killerActor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A383 RID: 107395 RVA: 0x007B7D9C File Offset: 0x007B5F9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FrameToMillisecond_s(IntPtr l)
	{
		int result;
		try
		{
			int frame;
			LuaObject.checkType(l, 1, out frame);
			int i = ClientBattle.FrameToMillisecond(frame);
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

	// Token: 0x0601A384 RID: 107396 RVA: 0x007B7DF0 File Offset: 0x007B5FF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MillisecondToFrame_s(IntPtr l)
	{
		int result;
		try
		{
			int ms;
			LuaObject.checkType(l, 1, out ms);
			int i = ClientBattle.MillisecondToFrame(ms);
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

	// Token: 0x0601A385 RID: 107397 RVA: 0x007B7E44 File Offset: 0x007B6044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MillisecondToFrame1_s(IntPtr l)
	{
		int result;
		try
		{
			int ms;
			LuaObject.checkType(l, 1, out ms);
			int i = ClientBattle.MillisecondToFrame1(ms);
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

	// Token: 0x0601A386 RID: 107398 RVA: 0x007B7E98 File Offset: 0x007B6098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TickSlowMotion(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			clientBattle.m_luaExportHelper.TickSlowMotion(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A387 RID: 107399 RVA: 0x007B7EF4 File Offset: 0x007B60F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TickCombat(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			clientBattle.m_luaExportHelper.TickCombat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A388 RID: 107400 RVA: 0x007B7F48 File Offset: 0x007B6148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TickClientBattle(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			clientBattle.m_luaExportHelper.TickClientBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A389 RID: 107401 RVA: 0x007B7F9C File Offset: 0x007B619C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartCombat(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			clientBattle.m_luaExportHelper.StartCombat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A38A RID: 107402 RVA: 0x007B7FF0 File Offset: 0x007B61F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopCombat(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			clientBattle.m_luaExportHelper.StopCombat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A38B RID: 107403 RVA: 0x007B8044 File Offset: 0x007B6244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTimeScale(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			float timeScale;
			LuaObject.checkType(l, 2, out timeScale);
			clientBattle.m_luaExportHelper.SetTimeScale(timeScale);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A38C RID: 107404 RVA: 0x007B80A0 File Offset: 0x007B62A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateFinalTimeScale(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			clientBattle.m_luaExportHelper.UpdateFinalTimeScale();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A38D RID: 107405 RVA: 0x007B80F4 File Offset: 0x007B62F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TickGraphic(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			clientBattle.m_luaExportHelper.TickGraphic(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A38E RID: 107406 RVA: 0x007B8150 File Offset: 0x007B6350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Draw(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			clientBattle.m_luaExportHelper.Draw();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A38F RID: 107407 RVA: 0x007B81A4 File Offset: 0x007B63A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int _CreateMap(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ConfigDataBattlefieldInfo battlefieldInfo;
			LuaObject.checkType<ConfigDataBattlefieldInfo>(l, 2, out battlefieldInfo);
			int cameraX;
			LuaObject.checkType(l, 3, out cameraX);
			int cameraY;
			LuaObject.checkType(l, 4, out cameraY);
			clientBattle.m_luaExportHelper._CreateMap(battlefieldInfo, cameraX, cameraY);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A390 RID: 107408 RVA: 0x007B821C File Offset: 0x007B641C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetWinConditionTargetPosition(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ConfigDataBattleWinConditionInfo winConditionInfo;
			LuaObject.checkType<ConfigDataBattleWinConditionInfo>(l, 2, out winConditionInfo);
			GridPosition winConditionTargetPosition = clientBattle.m_luaExportHelper.GetWinConditionTargetPosition(winConditionInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, winConditionTargetPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A391 RID: 107409 RVA: 0x007B8288 File Offset: 0x007B6488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLoseConditionTargetPosition(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ConfigDataBattleLoseConditionInfo loseConditionInfo;
			LuaObject.checkType<ConfigDataBattleLoseConditionInfo>(l, 2, out loseConditionInfo);
			GridPosition loseConditionTargetPosition = clientBattle.m_luaExportHelper.GetLoseConditionTargetPosition(loseConditionInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loseConditionTargetPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A392 RID: 107410 RVA: 0x007B82F4 File Offset: 0x007B64F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FadeNonSkillTargets(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ClientBattleActor ca;
			LuaObject.checkType<ClientBattleActor>(l, 2, out ca);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skillInfo);
			GridPosition targetPos;
			LuaObject.checkValueType<GridPosition>(l, 4, out targetPos);
			clientBattle.m_luaExportHelper.FadeNonSkillTargets(ca, skillInfo, targetPos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A393 RID: 107411 RVA: 0x007B836C File Offset: 0x007B656C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RestoreNonSkillTargets(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			clientBattle.m_luaExportHelper.RestoreNonSkillTargets();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A394 RID: 107412 RVA: 0x007B83C0 File Offset: 0x007B65C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedTargetIcon(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			bool b = clientBattle.m_luaExportHelper.IsNeedTargetIcon(a);
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

	// Token: 0x0601A395 RID: 107413 RVA: 0x007B8428 File Offset: 0x007B6628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DrawMap(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			clientBattle.m_luaExportHelper.DrawMap();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A396 RID: 107414 RVA: 0x007B847C File Offset: 0x007B667C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DrawCell(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 3, out actor);
			ConfigDataTerrainInfo terrain;
			LuaObject.checkType<ConfigDataTerrainInfo>(l, 4, out terrain);
			clientBattle.m_luaExportHelper.DrawCell(p, actor, terrain);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A397 RID: 107415 RVA: 0x007B84F4 File Offset: 0x007B66F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCurrentCamera(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			CameraBase currentCamera = clientBattle.m_luaExportHelper.GetCurrentCamera();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, currentCamera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A398 RID: 107416 RVA: 0x007B8550 File Offset: 0x007B6750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateTreasure(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ConfigDataBattleTreasureInfo treasureInfo;
			LuaObject.checkType<ConfigDataBattleTreasureInfo>(l, 2, out treasureInfo);
			bool isOpened;
			LuaObject.checkType(l, 3, out isOpened);
			ClientBattleTreasure o = clientBattle.m_luaExportHelper.CreateTreasure(treasureInfo, isOpened);
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

	// Token: 0x0601A399 RID: 107417 RVA: 0x007B85C4 File Offset: 0x007B67C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateMapBackground(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ConfigDataBattlefieldInfo battlefieldInfo;
			LuaObject.checkType<ConfigDataBattlefieldInfo>(l, 2, out battlefieldInfo);
			GameObject parent;
			LuaObject.checkType<GameObject>(l, 3, out parent);
			clientBattle.m_luaExportHelper.CreateMapBackground(battlefieldInfo, parent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A39A RID: 107418 RVA: 0x007B8630 File Offset: 0x007B6830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearMapBackground(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			clientBattle.m_luaExportHelper.ClearMapBackground();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A39B RID: 107419 RVA: 0x007B8684 File Offset: 0x007B6884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateMapTerrainFx(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			GameObject parent;
			LuaObject.checkType<GameObject>(l, 2, out parent);
			clientBattle.m_luaExportHelper.CreateMapTerrainFx(parent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A39C RID: 107420 RVA: 0x007B86E0 File Offset: 0x007B68E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearMapTerrainFx(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			clientBattle.m_luaExportHelper.ClearMapTerrainFx();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A39D RID: 107421 RVA: 0x007B8734 File Offset: 0x007B6934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddMapTerrainFx(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			ConfigDataTerrainInfo terrainInfo;
			LuaObject.checkType<ConfigDataTerrainInfo>(l, 3, out terrainInfo);
			GameObject parent;
			LuaObject.checkType<GameObject>(l, 4, out parent);
			clientBattle.m_luaExportHelper.AddMapTerrainFx(p, terrainInfo, parent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A39E RID: 107422 RVA: 0x007B87AC File Offset: 0x007B69AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int _ComputeCombatArmyRelationValue(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			BattleActor b;
			LuaObject.checkType<BattleActor>(l, 3, out b);
			bool isMagic;
			LuaObject.checkType(l, 4, out isMagic);
			int i = clientBattle.m_luaExportHelper._ComputeCombatArmyRelationValue(a, b, isMagic);
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

	// Token: 0x0601A39F RID: 107423 RVA: 0x007B8830 File Offset: 0x007B6A30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AppendActToActor(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			clientBattle.m_luaExportHelper.AppendActToActor();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3A0 RID: 107424 RVA: 0x007B8884 File Offset: 0x007B6A84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AppendActsToActor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
				int step;
				LuaObject.checkType(l, 2, out step);
				Type type;
				LuaObject.checkType(l, 3, out type);
				clientBattle.m_luaExportHelper.AppendActsToActor(step, type);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				ClientBattle clientBattle2 = (ClientBattle)LuaObject.checkSelf(l);
				int step2;
				LuaObject.checkType(l, 2, out step2);
				Type type2;
				LuaObject.checkType(l, 3, out type2);
				ClientBattleActor ca;
				LuaObject.checkType<ClientBattleActor>(l, 4, out ca);
				clientBattle2.m_luaExportHelper.AppendActsToActor(step2, type2, ca);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function AppendActsToActor to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3A1 RID: 107425 RVA: 0x007B896C File Offset: 0x007B6B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SdkLogBattle(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			string eventId;
			LuaObject.checkType(l, 2, out eventId);
			object logData;
			LuaObject.checkType<object>(l, 3, out logData);
			clientBattle.m_luaExportHelper.SdkLogBattle(eventId, logData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3A2 RID: 107426 RVA: 0x007B89D8 File Offset: 0x007B6BD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int _ComputeArmyRelationValue_s(IntPtr l)
	{
		int result;
		try
		{
			ArmyRelationData r;
			LuaObject.checkValueType<ArmyRelationData>(l, 1, out r);
			bool isMagic;
			LuaObject.checkType(l, 2, out isMagic);
			int i;
			LuaObject.checkType(l, 3, out i);
			ClientBattle.LuaExportHelper._ComputeArmyRelationValue(r, isMagic, ref i);
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

	// Token: 0x0601A3A3 RID: 107427 RVA: 0x007B8A44 File Offset: 0x007B6C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_state(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)clientBattle.m_luaExportHelper.m_state);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3A4 RID: 107428 RVA: 0x007B8A9C File Offset: 0x007B6C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_state(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ClientBattleState state;
			LuaObject.checkEnum<ClientBattleState>(l, 2, out state);
			clientBattle.m_luaExportHelper.m_state = state;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3A5 RID: 107429 RVA: 0x007B8AF8 File Offset: 0x007B6CF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_entityIdCounter(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_entityIdCounter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3A6 RID: 107430 RVA: 0x007B8B50 File Offset: 0x007B6D50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_entityIdCounter(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			int entityIdCounter;
			LuaObject.checkType(l, 2, out entityIdCounter);
			clientBattle.m_luaExportHelper.m_entityIdCounter = entityIdCounter;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3A7 RID: 107431 RVA: 0x007B8BAC File Offset: 0x007B6DAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isStopBattleWin(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_isStopBattleWin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3A8 RID: 107432 RVA: 0x007B8C04 File Offset: 0x007B6E04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isStopBattleWin(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			bool isStopBattleWin;
			LuaObject.checkType(l, 2, out isStopBattleWin);
			clientBattle.m_luaExportHelper.m_isStopBattleWin = isStopBattleWin;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3A9 RID: 107433 RVA: 0x007B8C60 File Offset: 0x007B6E60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_frameCount(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_frameCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3AA RID: 107434 RVA: 0x007B8CB8 File Offset: 0x007B6EB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_frameCount(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			int frameCount;
			LuaObject.checkType(l, 2, out frameCount);
			clientBattle.m_luaExportHelper.m_frameCount = frameCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3AB RID: 107435 RVA: 0x007B8D14 File Offset: 0x007B6F14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_endCountdown(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_endCountdown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3AC RID: 107436 RVA: 0x007B8D6C File Offset: 0x007B6F6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_endCountdown(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			int endCountdown;
			LuaObject.checkType(l, 2, out endCountdown);
			clientBattle.m_luaExportHelper.m_endCountdown = endCountdown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3AD RID: 107437 RVA: 0x007B8DC8 File Offset: 0x007B6FC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cutscenePauseCountdown(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_cutscenePauseCountdown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3AE RID: 107438 RVA: 0x007B8E20 File Offset: 0x007B7020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cutscenePauseCountdown(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			int cutscenePauseCountdown;
			LuaObject.checkType(l, 2, out cutscenePauseCountdown);
			clientBattle.m_luaExportHelper.m_cutscenePauseCountdown = cutscenePauseCountdown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3AF RID: 107439 RVA: 0x007B8E7C File Offset: 0x007B707C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_restoreNonSkillTargetsCountdown(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_restoreNonSkillTargetsCountdown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3B0 RID: 107440 RVA: 0x007B8ED4 File Offset: 0x007B70D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_restoreNonSkillTargetsCountdown(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			int restoreNonSkillTargetsCountdown;
			LuaObject.checkType(l, 2, out restoreNonSkillTargetsCountdown);
			clientBattle.m_luaExportHelper.m_restoreNonSkillTargetsCountdown = restoreNonSkillTargetsCountdown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3B1 RID: 107441 RVA: 0x007B8F30 File Offset: 0x007B7130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tickSoundName(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_tickSoundName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3B2 RID: 107442 RVA: 0x007B8F88 File Offset: 0x007B7188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tickSoundName(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			string tickSoundName;
			LuaObject.checkType(l, 2, out tickSoundName);
			clientBattle.m_luaExportHelper.m_tickSoundName = tickSoundName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3B3 RID: 107443 RVA: 0x007B8FE4 File Offset: 0x007B71E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleTickTime(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_battleTickTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3B4 RID: 107444 RVA: 0x007B903C File Offset: 0x007B723C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleTickTime(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			float battleTickTime;
			LuaObject.checkType(l, 2, out battleTickTime);
			clientBattle.m_luaExportHelper.m_battleTickTime = battleTickTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3B5 RID: 107445 RVA: 0x007B9098 File Offset: 0x007B7298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_combatTickTime(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_combatTickTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3B6 RID: 107446 RVA: 0x007B90F0 File Offset: 0x007B72F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_combatTickTime(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			float combatTickTime;
			LuaObject.checkType(l, 2, out combatTickTime);
			clientBattle.m_luaExportHelper.m_combatTickTime = combatTickTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3B7 RID: 107447 RVA: 0x007B914C File Offset: 0x007B734C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_timeScale(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_timeScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3B8 RID: 107448 RVA: 0x007B91A4 File Offset: 0x007B73A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_timeScale(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			float timeScale;
			LuaObject.checkType(l, 2, out timeScale);
			clientBattle.m_luaExportHelper.m_timeScale = timeScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3B9 RID: 107449 RVA: 0x007B9200 File Offset: 0x007B7400
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_globalTimeScale(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_globalTimeScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3BA RID: 107450 RVA: 0x007B9258 File Offset: 0x007B7458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_globalTimeScale(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			float globalTimeScale;
			LuaObject.checkType(l, 2, out globalTimeScale);
			clientBattle.m_luaExportHelper.m_globalTimeScale = globalTimeScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3BB RID: 107451 RVA: 0x007B92B4 File Offset: 0x007B74B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_slowMotionState(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)clientBattle.m_luaExportHelper.m_slowMotionState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3BC RID: 107452 RVA: 0x007B930C File Offset: 0x007B750C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_slowMotionState(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			SlowMotionState slowMotionState;
			LuaObject.checkEnum<SlowMotionState>(l, 2, out slowMotionState);
			clientBattle.m_luaExportHelper.m_slowMotionState = slowMotionState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3BD RID: 107453 RVA: 0x007B9368 File Offset: 0x007B7568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_slowMotionCountdown(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_slowMotionCountdown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3BE RID: 107454 RVA: 0x007B93C0 File Offset: 0x007B75C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_slowMotionCountdown(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			float slowMotionCountdown;
			LuaObject.checkType(l, 2, out slowMotionCountdown);
			clientBattle.m_luaExportHelper.m_slowMotionCountdown = slowMotionCountdown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3BF RID: 107455 RVA: 0x007B941C File Offset: 0x007B761C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isPaused(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_isPaused);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3C0 RID: 107456 RVA: 0x007B9474 File Offset: 0x007B7674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isPaused(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			bool isPaused;
			LuaObject.checkType(l, 2, out isPaused);
			clientBattle.m_luaExportHelper.m_isPaused = isPaused;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3C1 RID: 107457 RVA: 0x007B94D0 File Offset: 0x007B76D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isAutoBattle(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_isAutoBattle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3C2 RID: 107458 RVA: 0x007B9528 File Offset: 0x007B7728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isAutoBattle(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			bool isAutoBattle;
			LuaObject.checkType(l, 2, out isAutoBattle);
			clientBattle.m_luaExportHelper.m_isAutoBattle = isAutoBattle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3C3 RID: 107459 RVA: 0x007B9584 File Offset: 0x007B7784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isFastBattle(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_isFastBattle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3C4 RID: 107460 RVA: 0x007B95DC File Offset: 0x007B77DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isFastBattle(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			bool isFastBattle;
			LuaObject.checkType(l, 2, out isFastBattle);
			clientBattle.m_luaExportHelper.m_isFastBattle = isFastBattle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3C5 RID: 107461 RVA: 0x007B9638 File Offset: 0x007B7838
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isEnableDebugDraw(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_isEnableDebugDraw);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3C6 RID: 107462 RVA: 0x007B9690 File Offset: 0x007B7890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isEnableDebugDraw(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			bool isEnableDebugDraw;
			LuaObject.checkType(l, 2, out isEnableDebugDraw);
			clientBattle.m_luaExportHelper.m_isEnableDebugDraw = isEnableDebugDraw;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3C7 RID: 107463 RVA: 0x007B96EC File Offset: 0x007B78EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isEnableSdkLogBattle(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_isEnableSdkLogBattle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3C8 RID: 107464 RVA: 0x007B9744 File Offset: 0x007B7944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isEnableSdkLogBattle(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			bool isEnableSdkLogBattle;
			LuaObject.checkType(l, 2, out isEnableSdkLogBattle);
			clientBattle.m_luaExportHelper.m_isEnableSdkLogBattle = isEnableSdkLogBattle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3C9 RID: 107465 RVA: 0x007B97A0 File Offset: 0x007B79A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_randomNumber(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_randomNumber);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3CA RID: 107466 RVA: 0x007B97F8 File Offset: 0x007B79F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_randomNumber(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			RandomNumber randomNumber;
			LuaObject.checkType<RandomNumber>(l, 2, out randomNumber);
			clientBattle.m_luaExportHelper.m_randomNumber = randomNumber;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3CB RID: 107467 RVA: 0x007B9854 File Offset: 0x007B7A54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battle(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_battle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3CC RID: 107468 RVA: 0x007B98AC File Offset: 0x007B7AAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battle(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleBase battle;
			LuaObject.checkType<BattleBase>(l, 2, out battle);
			clientBattle.m_luaExportHelper.m_battle = battle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3CD RID: 107469 RVA: 0x007B9908 File Offset: 0x007B7B08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nullActor(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_nullActor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3CE RID: 107470 RVA: 0x007B9960 File Offset: 0x007B7B60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nullActor(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ClientBattleActor nullActor;
			LuaObject.checkType<ClientBattleActor>(l, 2, out nullActor);
			clientBattle.m_luaExportHelper.m_nullActor = nullActor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3CF RID: 107471 RVA: 0x007B99BC File Offset: 0x007B7BBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actors(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_actors);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3D0 RID: 107472 RVA: 0x007B9A14 File Offset: 0x007B7C14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actors(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			List<ClientBattleActor> actors;
			LuaObject.checkType<List<ClientBattleActor>>(l, 2, out actors);
			clientBattle.m_luaExportHelper.m_actors = actors;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3D1 RID: 107473 RVA: 0x007B9A70 File Offset: 0x007B7C70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_activeActor(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_activeActor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3D2 RID: 107474 RVA: 0x007B9AC8 File Offset: 0x007B7CC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_activeActor(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ClientBattleActor activeActor;
			LuaObject.checkType<ClientBattleActor>(l, 2, out activeActor);
			clientBattle.m_luaExportHelper.m_activeActor = activeActor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3D3 RID: 107475 RVA: 0x007B9B24 File Offset: 0x007B7D24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cameraFollowActor(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_cameraFollowActor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3D4 RID: 107476 RVA: 0x007B9B7C File Offset: 0x007B7D7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cameraFollowActor(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ClientBattleActor cameraFollowActor;
			LuaObject.checkType<ClientBattleActor>(l, 2, out cameraFollowActor);
			clientBattle.m_luaExportHelper.m_cameraFollowActor = cameraFollowActor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3D5 RID: 107477 RVA: 0x007B9BD8 File Offset: 0x007B7DD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actorActs(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_actorActs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3D6 RID: 107478 RVA: 0x007B9C30 File Offset: 0x007B7E30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actorActs(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			List<ClientActorAct> actorActs;
			LuaObject.checkType<List<ClientActorAct>>(l, 2, out actorActs);
			clientBattle.m_luaExportHelper.m_actorActs = actorActs;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3D7 RID: 107479 RVA: 0x007B9C8C File Offset: 0x007B7E8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_treasures(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_treasures);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3D8 RID: 107480 RVA: 0x007B9CE4 File Offset: 0x007B7EE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_treasures(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			List<ClientBattleTreasure> treasures;
			LuaObject.checkType<List<ClientBattleTreasure>>(l, 2, out treasures);
			clientBattle.m_luaExportHelper.m_treasures = treasures;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3D9 RID: 107481 RVA: 0x007B9D40 File Offset: 0x007B7F40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enforceActionOrderHeroIds(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_enforceActionOrderHeroIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3DA RID: 107482 RVA: 0x007B9D98 File Offset: 0x007B7F98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enforceActionOrderHeroIds(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			List<int> enforceActionOrderHeroIds;
			LuaObject.checkType<List<int>>(l, 2, out enforceActionOrderHeroIds);
			clientBattle.m_luaExportHelper.m_enforceActionOrderHeroIds = enforceActionOrderHeroIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3DB RID: 107483 RVA: 0x007B9DF4 File Offset: 0x007B7FF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_combatingBattleActorA(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_combatingBattleActorA);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3DC RID: 107484 RVA: 0x007B9E4C File Offset: 0x007B804C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_combatingBattleActorA(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor combatingBattleActorA;
			LuaObject.checkType<BattleActor>(l, 2, out combatingBattleActorA);
			clientBattle.m_luaExportHelper.m_combatingBattleActorA = combatingBattleActorA;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3DD RID: 107485 RVA: 0x007B9EA8 File Offset: 0x007B80A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_combatingBattleActorB(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_combatingBattleActorB);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3DE RID: 107486 RVA: 0x007B9F00 File Offset: 0x007B8100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_combatingBattleActorB(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleActor combatingBattleActorB;
			LuaObject.checkType<BattleActor>(l, 2, out combatingBattleActorB);
			clientBattle.m_luaExportHelper.m_combatingBattleActorB = combatingBattleActorB;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3DF RID: 107487 RVA: 0x007B9F5C File Offset: 0x007B815C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_combatSkillInfoA(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_combatSkillInfoA);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3E0 RID: 107488 RVA: 0x007B9FB4 File Offset: 0x007B81B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_combatSkillInfoA(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ConfigDataSkillInfo combatSkillInfoA;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out combatSkillInfoA);
			clientBattle.m_luaExportHelper.m_combatSkillInfoA = combatSkillInfoA;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3E1 RID: 107489 RVA: 0x007BA010 File Offset: 0x007B8210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ignoreMoveStep(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_ignoreMoveStep);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3E2 RID: 107490 RVA: 0x007BA068 File Offset: 0x007B8268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ignoreMoveStep(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			int ignoreMoveStep;
			LuaObject.checkType(l, 2, out ignoreMoveStep);
			clientBattle.m_luaExportHelper.m_ignoreMoveStep = ignoreMoveStep;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3E3 RID: 107491 RVA: 0x007BA0C4 File Offset: 0x007B82C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ignoreSkillStep(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_ignoreSkillStep);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3E4 RID: 107492 RVA: 0x007BA11C File Offset: 0x007B831C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ignoreSkillStep(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			int ignoreSkillStep;
			LuaObject.checkType(l, 2, out ignoreSkillStep);
			clientBattle.m_luaExportHelper.m_ignoreSkillStep = ignoreSkillStep;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3E5 RID: 107493 RVA: 0x007BA178 File Offset: 0x007B8378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ignoreTeleportDisappearStep(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_ignoreTeleportDisappearStep);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3E6 RID: 107494 RVA: 0x007BA1D0 File Offset: 0x007B83D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ignoreTeleportDisappearStep(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			int ignoreTeleportDisappearStep;
			LuaObject.checkType(l, 2, out ignoreTeleportDisappearStep);
			clientBattle.m_luaExportHelper.m_ignoreTeleportDisappearStep = ignoreTeleportDisappearStep;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3E7 RID: 107495 RVA: 0x007BA22C File Offset: 0x007B842C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ignoreActiveTeam(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_ignoreActiveTeam);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3E8 RID: 107496 RVA: 0x007BA284 File Offset: 0x007B8484
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ignoreActiveTeam(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			int ignoreActiveTeam;
			LuaObject.checkType(l, 2, out ignoreActiveTeam);
			clientBattle.m_luaExportHelper.m_ignoreActiveTeam = ignoreActiveTeam;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3E9 RID: 107497 RVA: 0x007BA2E0 File Offset: 0x007B84E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ignoreActiveTurn(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_ignoreActiveTurn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3EA RID: 107498 RVA: 0x007BA338 File Offset: 0x007B8538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ignoreActiveTurn(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			int ignoreActiveTurn;
			LuaObject.checkType(l, 2, out ignoreActiveTurn);
			clientBattle.m_luaExportHelper.m_ignoreActiveTurn = ignoreActiveTurn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3EB RID: 107499 RVA: 0x007BA394 File Offset: 0x007B8594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actorActSkillHit(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_actorActSkillHit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3EC RID: 107500 RVA: 0x007BA3EC File Offset: 0x007B85EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actorActSkillHit(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ClientActorActSkillHit actorActSkillHit;
			LuaObject.checkType<ClientActorActSkillHit>(l, 2, out actorActSkillHit);
			clientBattle.m_luaExportHelper.m_actorActSkillHit = actorActSkillHit;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3ED RID: 107501 RVA: 0x007BA448 File Offset: 0x007B8648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actorActSkillRebound(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_actorActSkillRebound);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3EE RID: 107502 RVA: 0x007BA4A0 File Offset: 0x007B86A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actorActSkillRebound(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ClientActorActSkillHit actorActSkillRebound;
			LuaObject.checkType<ClientActorActSkillHit>(l, 2, out actorActSkillRebound);
			clientBattle.m_luaExportHelper.m_actorActSkillRebound = actorActSkillRebound;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3EF RID: 107503 RVA: 0x007BA4FC File Offset: 0x007B86FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curBattleDialogInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_curBattleDialogInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3F0 RID: 107504 RVA: 0x007BA554 File Offset: 0x007B8754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curBattleDialogInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ConfigDataBattleDialogInfo curBattleDialogInfo;
			LuaObject.checkType<ConfigDataBattleDialogInfo>(l, 2, out curBattleDialogInfo);
			clientBattle.m_luaExportHelper.m_curBattleDialogInfo = curBattleDialogInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3F1 RID: 107505 RVA: 0x007BA5B0 File Offset: 0x007B87B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleDialogResult(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_battleDialogResult);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3F2 RID: 107506 RVA: 0x007BA608 File Offset: 0x007B8808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleDialogResult(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			int battleDialogResult;
			LuaObject.checkType(l, 2, out battleDialogResult);
			clientBattle.m_luaExportHelper.m_battleDialogResult = battleDialogResult;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3F3 RID: 107507 RVA: 0x007BA664 File Offset: 0x007B8864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isWaitBattleTreasureDialog(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_isWaitBattleTreasureDialog);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3F4 RID: 107508 RVA: 0x007BA6BC File Offset: 0x007B88BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isWaitBattleTreasureDialog(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			bool isWaitBattleTreasureDialog;
			LuaObject.checkType(l, 2, out isWaitBattleTreasureDialog);
			clientBattle.m_luaExportHelper.m_isWaitBattleTreasureDialog = isWaitBattleTreasureDialog;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3F5 RID: 107509 RVA: 0x007BA718 File Offset: 0x007B8918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isWaitBattleTreasureReward(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_isWaitBattleTreasureReward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3F6 RID: 107510 RVA: 0x007BA770 File Offset: 0x007B8970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isWaitBattleTreasureReward(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			bool isWaitBattleTreasureReward;
			LuaObject.checkType(l, 2, out isWaitBattleTreasureReward);
			clientBattle.m_luaExportHelper.m_isWaitBattleTreasureReward = isWaitBattleTreasureReward;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3F7 RID: 107511 RVA: 0x007BA7CC File Offset: 0x007B89CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isWaitFastCombat(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_isWaitFastCombat);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3F8 RID: 107512 RVA: 0x007BA824 File Offset: 0x007B8A24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isWaitFastCombat(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			bool isWaitFastCombat;
			LuaObject.checkType(l, 2, out isWaitFastCombat);
			clientBattle.m_luaExportHelper.m_isWaitFastCombat = isWaitFastCombat;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3F9 RID: 107513 RVA: 0x007BA880 File Offset: 0x007B8A80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isBattlePerforming(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_isBattlePerforming);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3FA RID: 107514 RVA: 0x007BA8D8 File Offset: 0x007B8AD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isBattlePerforming(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			bool isBattlePerforming;
			LuaObject.checkType(l, 2, out isBattlePerforming);
			clientBattle.m_luaExportHelper.m_isBattlePerforming = isBattlePerforming;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3FB RID: 107515 RVA: 0x007BA934 File Offset: 0x007B8B34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_myPlayerIndex(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_myPlayerIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3FC RID: 107516 RVA: 0x007BA98C File Offset: 0x007B8B8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_myPlayerIndex(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			int myPlayerIndex;
			LuaObject.checkType(l, 2, out myPlayerIndex);
			clientBattle.m_luaExportHelper.m_myPlayerIndex = myPlayerIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3FD RID: 107517 RVA: 0x007BA9E8 File Offset: 0x007B8BE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_myPlayerTeam(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_myPlayerTeam);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3FE RID: 107518 RVA: 0x007BAA40 File Offset: 0x007B8C40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_myPlayerTeam(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			int myPlayerTeam;
			LuaObject.checkType(l, 2, out myPlayerTeam);
			clientBattle.m_luaExportHelper.m_myPlayerTeam = myPlayerTeam;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A3FF RID: 107519 RVA: 0x007BAA9C File Offset: 0x007B8C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rebuildBattleStepMax(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_rebuildBattleStepMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A400 RID: 107520 RVA: 0x007BAAF4 File Offset: 0x007B8CF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rebuildBattleStepMax(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			int rebuildBattleStepMax;
			LuaObject.checkType(l, 2, out rebuildBattleStepMax);
			clientBattle.m_luaExportHelper.m_rebuildBattleStepMax = rebuildBattleStepMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A401 RID: 107521 RVA: 0x007BAB50 File Offset: 0x007B8D50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skipCombatMode(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)clientBattle.m_luaExportHelper.m_skipCombatMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A402 RID: 107522 RVA: 0x007BABA8 File Offset: 0x007B8DA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skipCombatMode(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			SkipCombatMode skipCombatMode;
			LuaObject.checkEnum<SkipCombatMode>(l, 2, out skipCombatMode);
			clientBattle.m_luaExportHelper.m_skipCombatMode = skipCombatMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A403 RID: 107523 RVA: 0x007BAC04 File Offset: 0x007B8E04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A404 RID: 107524 RVA: 0x007BAC5C File Offset: 0x007B8E5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			clientBattle.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A405 RID: 107525 RVA: 0x007BACB8 File Offset: 0x007B8EB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_clientBattleListener(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_clientBattleListener);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A406 RID: 107526 RVA: 0x007BAD10 File Offset: 0x007B8F10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_clientBattleListener(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			IClientBattleListener clientBattleListener;
			LuaObject.checkType<IClientBattleListener>(l, 2, out clientBattleListener);
			clientBattle.m_luaExportHelper.m_clientBattleListener = clientBattleListener;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A407 RID: 107527 RVA: 0x007BAD6C File Offset: 0x007B8F6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_battleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A408 RID: 107528 RVA: 0x007BADC4 File Offset: 0x007B8FC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ConfigDataBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 2, out battleInfo);
			clientBattle.m_luaExportHelper.m_battleInfo = battleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A409 RID: 107529 RVA: 0x007BAE20 File Offset: 0x007B9020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_arenaBattleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A40A RID: 107530 RVA: 0x007BAE78 File Offset: 0x007B9078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ConfigDataArenaBattleInfo arenaBattleInfo;
			LuaObject.checkType<ConfigDataArenaBattleInfo>(l, 2, out arenaBattleInfo);
			clientBattle.m_luaExportHelper.m_arenaBattleInfo = arenaBattleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A40B RID: 107531 RVA: 0x007BAED4 File Offset: 0x007B90D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pvpBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_pvpBattleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A40C RID: 107532 RVA: 0x007BAF2C File Offset: 0x007B912C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pvpBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ConfigDataPVPBattleInfo pvpBattleInfo;
			LuaObject.checkType<ConfigDataPVPBattleInfo>(l, 2, out pvpBattleInfo);
			clientBattle.m_luaExportHelper.m_pvpBattleInfo = pvpBattleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A40D RID: 107533 RVA: 0x007BAF88 File Offset: 0x007B9188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_realtimePvpBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_realtimePvpBattleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A40E RID: 107534 RVA: 0x007BAFE0 File Offset: 0x007B91E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_realtimePvpBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			ConfigDataRealTimePVPBattleInfo realtimePvpBattleInfo;
			LuaObject.checkType<ConfigDataRealTimePVPBattleInfo>(l, 2, out realtimePvpBattleInfo);
			clientBattle.m_luaExportHelper.m_realtimePvpBattleInfo = realtimePvpBattleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A40F RID: 107535 RVA: 0x007BB03C File Offset: 0x007B923C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleType(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)clientBattle.m_luaExportHelper.m_battleType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A410 RID: 107536 RVA: 0x007BB094 File Offset: 0x007B9294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleType(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 2, out battleType);
			clientBattle.m_luaExportHelper.m_battleType = battleType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A411 RID: 107537 RVA: 0x007BB0F0 File Offset: 0x007B92F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleCamera(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_battleCamera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A412 RID: 107538 RVA: 0x007BB148 File Offset: 0x007B9348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleCamera(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			BattleCamera battleCamera;
			LuaObject.checkType<BattleCamera>(l, 2, out battleCamera);
			clientBattle.m_luaExportHelper.m_battleCamera = battleCamera;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A413 RID: 107539 RVA: 0x007BB1A4 File Offset: 0x007B93A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_combatCamera(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_combatCamera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A414 RID: 107540 RVA: 0x007BB1FC File Offset: 0x007B93FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_combatCamera(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			CombatCamera combatCamera;
			LuaObject.checkType<CombatCamera>(l, 2, out combatCamera);
			clientBattle.m_luaExportHelper.m_combatCamera = combatCamera;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A415 RID: 107541 RVA: 0x007BB258 File Offset: 0x007B9458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cutsceneCamera(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_cutsceneCamera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A416 RID: 107542 RVA: 0x007BB2B0 File Offset: 0x007B94B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cutsceneCamera(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			CutsceneCamera cutsceneCamera;
			LuaObject.checkType<CutsceneCamera>(l, 2, out cutsceneCamera);
			clientBattle.m_luaExportHelper.m_cutsceneCamera = cutsceneCamera;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A417 RID: 107543 RVA: 0x007BB30C File Offset: 0x007B950C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_battleRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A418 RID: 107544 RVA: 0x007BB364 File Offset: 0x007B9564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			GameObject battleRoot;
			LuaObject.checkType<GameObject>(l, 2, out battleRoot);
			clientBattle.m_luaExportHelper.m_battleRoot = battleRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A419 RID: 107545 RVA: 0x007BB3C0 File Offset: 0x007B95C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_combatRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_combatRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A41A RID: 107546 RVA: 0x007BB418 File Offset: 0x007B9618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_combatRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			GameObject combatRoot;
			LuaObject.checkType<GameObject>(l, 2, out combatRoot);
			clientBattle.m_luaExportHelper.m_combatRoot = combatRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A41B RID: 107547 RVA: 0x007BB474 File Offset: 0x007B9674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cutsceneRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_cutsceneRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A41C RID: 107548 RVA: 0x007BB4CC File Offset: 0x007B96CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cutsceneRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			GameObject cutsceneRoot;
			LuaObject.checkType<GameObject>(l, 2, out cutsceneRoot);
			clientBattle.m_luaExportHelper.m_cutsceneRoot = cutsceneRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A41D RID: 107549 RVA: 0x007BB528 File Offset: 0x007B9728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleGraphicRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_battleGraphicRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A41E RID: 107550 RVA: 0x007BB580 File Offset: 0x007B9780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleGraphicRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			GameObject battleGraphicRoot;
			LuaObject.checkType<GameObject>(l, 2, out battleGraphicRoot);
			clientBattle.m_luaExportHelper.m_battleGraphicRoot = battleGraphicRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A41F RID: 107551 RVA: 0x007BB5DC File Offset: 0x007B97DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_combatGraphicRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_combatGraphicRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A420 RID: 107552 RVA: 0x007BB634 File Offset: 0x007B9834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_combatGraphicRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			GameObject combatGraphicRoot;
			LuaObject.checkType<GameObject>(l, 2, out combatGraphicRoot);
			clientBattle.m_luaExportHelper.m_combatGraphicRoot = combatGraphicRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A421 RID: 107553 RVA: 0x007BB690 File Offset: 0x007B9890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cutsceneGraphicRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_cutsceneGraphicRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A422 RID: 107554 RVA: 0x007BB6E8 File Offset: 0x007B98E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cutsceneGraphicRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			GameObject cutsceneGraphicRoot;
			LuaObject.checkType<GameObject>(l, 2, out cutsceneGraphicRoot);
			clientBattle.m_luaExportHelper.m_cutsceneGraphicRoot = cutsceneGraphicRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A423 RID: 107555 RVA: 0x007BB744 File Offset: 0x007B9944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mapRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_mapRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A424 RID: 107556 RVA: 0x007BB79C File Offset: 0x007B999C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mapRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			GameObject mapRoot;
			LuaObject.checkType<GameObject>(l, 2, out mapRoot);
			clientBattle.m_luaExportHelper.m_mapRoot = mapRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A425 RID: 107557 RVA: 0x007BB7F8 File Offset: 0x007B99F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mapBackground(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_mapBackground);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A426 RID: 107558 RVA: 0x007BB850 File Offset: 0x007B9A50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mapBackground(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			GameObject mapBackground;
			LuaObject.checkType<GameObject>(l, 2, out mapBackground);
			clientBattle.m_luaExportHelper.m_mapBackground = mapBackground;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A427 RID: 107559 RVA: 0x007BB8AC File Offset: 0x007B9AAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mapTerrainFxRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_mapTerrainFxRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A428 RID: 107560 RVA: 0x007BB904 File Offset: 0x007B9B04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mapTerrainFxRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			GameObject mapTerrainFxRoot;
			LuaObject.checkType<GameObject>(l, 2, out mapTerrainFxRoot);
			clientBattle.m_luaExportHelper.m_mapTerrainFxRoot = mapTerrainFxRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A429 RID: 107561 RVA: 0x007BB960 File Offset: 0x007B9B60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mapTreasureRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_mapTreasureRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A42A RID: 107562 RVA: 0x007BB9B8 File Offset: 0x007B9BB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mapTreasureRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			GameObject mapTreasureRoot;
			LuaObject.checkType<GameObject>(l, 2, out mapTreasureRoot);
			clientBattle.m_luaExportHelper.m_mapTreasureRoot = mapTreasureRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A42B RID: 107563 RVA: 0x007BBA14 File Offset: 0x007B9C14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mapTerrainFxs(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_mapTerrainFxs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A42C RID: 107564 RVA: 0x007BBA6C File Offset: 0x007B9C6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mapTerrainFxs(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			Dictionary<GridPosition, GameObject> mapTerrainFxs;
			LuaObject.checkType<Dictionary<GridPosition, GameObject>>(l, 2, out mapTerrainFxs);
			clientBattle.m_luaExportHelper.m_mapTerrainFxs = mapTerrainFxs;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A42D RID: 107565 RVA: 0x007BBAC8 File Offset: 0x007B9CC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleUIRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_battleUIRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A42E RID: 107566 RVA: 0x007BBB20 File Offset: 0x007B9D20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleUIRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			GameObject battleUIRoot;
			LuaObject.checkType<GameObject>(l, 2, out battleUIRoot);
			clientBattle.m_luaExportHelper.m_battleUIRoot = battleUIRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A42F RID: 107567 RVA: 0x007BBB7C File Offset: 0x007B9D7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleActorUIRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_battleActorUIRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A430 RID: 107568 RVA: 0x007BBBD4 File Offset: 0x007B9DD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleActorUIRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			GameObject battleActorUIRoot;
			LuaObject.checkType<GameObject>(l, 2, out battleActorUIRoot);
			clientBattle.m_luaExportHelper.m_battleActorUIRoot = battleActorUIRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A431 RID: 107569 RVA: 0x007BBC30 File Offset: 0x007B9E30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleActorUIPrefab(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_battleActorUIPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A432 RID: 107570 RVA: 0x007BBC88 File Offset: 0x007B9E88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleActorUIPrefab(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			GameObject battleActorUIPrefab;
			LuaObject.checkType<GameObject>(l, 2, out battleActorUIPrefab);
			clientBattle.m_luaExportHelper.m_battleActorUIPrefab = battleActorUIPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A433 RID: 107571 RVA: 0x007BBCE4 File Offset: 0x007B9EE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_graphicPool(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_graphicPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A434 RID: 107572 RVA: 0x007BBD3C File Offset: 0x007B9F3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_graphicPool(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			GraphicPool graphicPool;
			LuaObject.checkType<GraphicPool>(l, 2, out graphicPool);
			clientBattle.m_luaExportHelper.m_graphicPool = graphicPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A435 RID: 107573 RVA: 0x007BBD98 File Offset: 0x007B9F98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fxPool(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_fxPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A436 RID: 107574 RVA: 0x007BBDF0 File Offset: 0x007B9FF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fxPool(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			GraphicPool fxPool;
			LuaObject.checkType<GraphicPool>(l, 2, out fxPool);
			clientBattle.m_luaExportHelper.m_fxPool = fxPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A437 RID: 107575 RVA: 0x007BBE4C File Offset: 0x007BA04C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleFxPlayer(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_battleFxPlayer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A438 RID: 107576 RVA: 0x007BBEA4 File Offset: 0x007BA0A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleFxPlayer(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			FxPlayer battleFxPlayer;
			LuaObject.checkType<FxPlayer>(l, 2, out battleFxPlayer);
			clientBattle.m_luaExportHelper.m_battleFxPlayer = battleFxPlayer;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A439 RID: 107577 RVA: 0x007BBF00 File Offset: 0x007BA100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_combatFxPlayer(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_combatFxPlayer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A43A RID: 107578 RVA: 0x007BBF58 File Offset: 0x007BA158
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_combatFxPlayer(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			FxPlayer combatFxPlayer;
			LuaObject.checkType<FxPlayer>(l, 2, out combatFxPlayer);
			clientBattle.m_luaExportHelper.m_combatFxPlayer = combatFxPlayer;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A43B RID: 107579 RVA: 0x007BBFB4 File Offset: 0x007BA1B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cutscenePlayer(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.m_luaExportHelper.m_cutscenePlayer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A43C RID: 107580 RVA: 0x007BC00C File Offset: 0x007BA20C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cutscenePlayer(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			FxPlayer cutscenePlayer;
			LuaObject.checkType<FxPlayer>(l, 2, out cutscenePlayer);
			clientBattle.m_luaExportHelper.m_cutscenePlayer = cutscenePlayer;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A43D RID: 107581 RVA: 0x007BC068 File Offset: 0x007BA268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Battle(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.Battle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A43E RID: 107582 RVA: 0x007BC0BC File Offset: 0x007BA2BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleCamera(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.BattleCamera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A43F RID: 107583 RVA: 0x007BC110 File Offset: 0x007BA310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CombatCamera(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.CombatCamera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A440 RID: 107584 RVA: 0x007BC164 File Offset: 0x007BA364
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_State(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)clientBattle.State);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A441 RID: 107585 RVA: 0x007BC1B8 File Offset: 0x007BA3B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EnableDebugDraw(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.EnableDebugDraw);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A442 RID: 107586 RVA: 0x007BC20C File Offset: 0x007BA40C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EnableDebugDraw(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			bool enableDebugDraw;
			LuaObject.checkType(l, 2, out enableDebugDraw);
			clientBattle.EnableDebugDraw = enableDebugDraw;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A443 RID: 107587 RVA: 0x007BC264 File Offset: 0x007BA464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsAutoBattle(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.IsAutoBattle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A444 RID: 107588 RVA: 0x007BC2B8 File Offset: 0x007BA4B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsFastBattle(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.IsFastBattle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A445 RID: 107589 RVA: 0x007BC30C File Offset: 0x007BA50C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SkipCombatMode(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)clientBattle.SkipCombatMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A446 RID: 107590 RVA: 0x007BC360 File Offset: 0x007BA560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsPaused(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.IsPaused);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A447 RID: 107591 RVA: 0x007BC3B4 File Offset: 0x007BA5B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleGraphicRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.BattleGraphicRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A448 RID: 107592 RVA: 0x007BC408 File Offset: 0x007BA608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CombatGraphicRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.CombatGraphicRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A449 RID: 107593 RVA: 0x007BC45C File Offset: 0x007BA65C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MapTreasureRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.MapTreasureRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A44A RID: 107594 RVA: 0x007BC4B0 File Offset: 0x007BA6B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleActorUIRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.BattleActorUIRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A44B RID: 107595 RVA: 0x007BC504 File Offset: 0x007BA704
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleActorUIPrefab(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.BattleActorUIPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A44C RID: 107596 RVA: 0x007BC558 File Offset: 0x007BA758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleFxPlayer(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.BattleFxPlayer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A44D RID: 107597 RVA: 0x007BC5AC File Offset: 0x007BA7AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CombatFxPlayer(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.CombatFxPlayer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A44E RID: 107598 RVA: 0x007BC600 File Offset: 0x007BA800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.ConfigDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A44F RID: 107599 RVA: 0x007BC654 File Offset: 0x007BA854
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ClientBattleListener(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.ClientBattleListener);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A450 RID: 107600 RVA: 0x007BC6A8 File Offset: 0x007BA8A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RandomNumber(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle = (ClientBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattle.RandomNumber);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A451 RID: 107601 RVA: 0x007BC6FC File Offset: 0x007BA8FC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientBattle");
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.Dispose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.SetGlobalTimeScale);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.CreateMap);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.CreateArenaMap);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.CreatePVPMap);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.CreateRealTimePVPMap);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.ResetMap);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.Start);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.StartArena);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.StartPVP);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.StartRealTimePVP);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.IsTeamBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.SetEnforceActionOrderHeros);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.FirstStep);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.Stop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.Pause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.SetAutoBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.SetFastBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.StartBattleDialog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.StopBattleDialog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.GetBattleDialogResult);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.IsWaitBattleDialog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.StartBattleTreasureDialog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.StopBattleTreasureDialog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.IsWaitBattleTreasureDialog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.StartBattleTreasureReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.StopBattleTreasureReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.IsWaitBattleTreasureReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.StartFastCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.StopFastCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.IsWaitFastCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.StartBattlePerform);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.StopBattlePerform);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.IsBattlePerforming);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.GetActors);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.GetActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.CameraFocusActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.CameraFocusPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.CameraFollowActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.IsCameraFocusing);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.ComputeTotalHealthPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.ComputeTotalHealthPointMax);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.EndAllAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.IgnoreMoveStep);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.IgnoreSkillStep);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.IgnoreTeleportDisappearStep);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.GridPositionToWorldPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.WorldPositionToGridPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.ScreenPositionToWorldPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.ScreenPositionToGridPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.GridPositionToScreenPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.DrawLine);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.DrawGrid);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.CreateBattleGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.DestroyBattleGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.BattleActorTryMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.CreateActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.GetTreasure);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.GetNextEntityId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.PlayScreenEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.ChangeMapTerrainFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.RebuildBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.IsRebuildingBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.StopRebuildingBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.SetSkipCombatMode);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.IsSkippingCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.ComputeCombatArmyRelationValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.IsCombatMagicAttack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.EnableSdkLogBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.GetMyPlayerIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.GetMyPlayerTeamNumber);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.IsAnyActorHasAct);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.HasWaitingAct);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache4B);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnActorActive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache4C);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnActorPreStartCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache4D);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnActorStopCombatEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache4E);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnActorCastSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache4F);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnActorCastSkillEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache50);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleActorCreate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache51);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleActorCreateEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache52);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleActorActive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache53);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleActorActionBegin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache54);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleActorActionEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache55);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleActorMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache56);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleActorPerformMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache57);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleActorPunchMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache58);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleActorExchangeMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache59);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleActorSetDir);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache5A);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleActorPlayFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache5B);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleActorPlayAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache5C);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleActorChangeIdleAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache5D);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleActorSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache5E);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleActorSkillHitBegin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache5F);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleActorSkillHit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache60);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleActorSkillHitEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache61);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleActorAttachBuff);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache62);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleActorDetachBuff);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache63);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleActorImmune);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache64);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleActorPassiveSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache65);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleActorBuffHit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache66);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleActorTerrainHit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache67);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleActorTeleport);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache68);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleActorTeleportDisappear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache69);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleActorTeleportAppear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache6A);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleActorSummon);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache6B);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleActorDie);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache6C);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleActorAppear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache6D);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleActorDisappear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache6E);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleActorChangeTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache6F);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleActorChangeArmy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache70);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleActorReplace);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache71);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleActorCameraFocus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache72);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleActorGainBattleTreasure);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache73);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnStartGuard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache74);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnStopGuard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache75);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBeforeStartCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache76);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnCancelCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache77);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnStartCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache78);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnPreStopCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache79);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnStopCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache7A);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleNextTurn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache7B);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleNextTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache7C);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleNextPlayer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache7D);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleNextActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache7E);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnCombatActorHit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache7F);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnCombatActorDie);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache80);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnStartSkillCutscene);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache81);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnStartPassiveSkillCutscene);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache82);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnStopSkillCutscene);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache83);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnStartBattleDialog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache84);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnStartBattlePerform);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache85);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnStopBattlePerform);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache86);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnChangeMapTerrain);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache87);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnCameraFocus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache88);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnPlayMusic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache89);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnPlaySound);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache8A);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnPlayFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache8B);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnWaitTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache8C);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnBattleTreasureCreate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache8D);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.CreateCombatGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache8E);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.DestroyCombatGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache8F);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.PlayFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache90);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.PlaySound);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache91);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.IsCombatGraphicMirrorX);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache92);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnAudio);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache93);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnSound);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache94);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnCameraEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache95);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnScreenEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache96);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.OnGeneral);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache97);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.GetCameraPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache98);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.CombatPositionToWorldPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache99);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.IsCulled);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache9A);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.LogBattleStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache9B);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.LogBattleStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache9C);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.LogBattleTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache9D);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.LogActorMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache9E);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.LogActorStandby);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache9F);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.LogActorAttack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheA0);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.LogActorSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheA1);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.LogActorDie);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheA2);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.FrameToMillisecond_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheA3);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.MillisecondToFrame_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheA4);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.MillisecondToFrame1_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheA5);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.TickSlowMotion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheA6);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.TickCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheA7);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.TickClientBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheA8);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheA9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheA9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.StartCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheA9);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheAA == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheAA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.StopCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheAA);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheAB == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheAB = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.SetTimeScale);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheAB);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheAC == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheAC = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.UpdateFinalTimeScale);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheAC);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheAD == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheAD = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.TickGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheAD);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheAE == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheAE = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.Draw);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheAE);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheAF == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheAF = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle._CreateMap);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheAF);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheB0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheB0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.GetWinConditionTargetPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheB0);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheB1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheB1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.GetLoseConditionTargetPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheB1);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheB2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheB2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.FadeNonSkillTargets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheB2);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheB3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheB3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.RestoreNonSkillTargets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheB3);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheB4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheB4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.IsNeedTargetIcon);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheB4);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheB5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheB5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.DrawMap);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheB5);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheB6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheB6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.DrawCell);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheB6);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheB7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheB7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.GetCurrentCamera);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheB7);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheB8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheB8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.CreateTreasure);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheB8);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheB9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheB9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.CreateMapBackground);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheB9);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheBA == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheBA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.ClearMapBackground);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheBA);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheBB == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheBB = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.CreateMapTerrainFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheBB);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheBC == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheBC = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.ClearMapTerrainFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheBC);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheBD == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheBD = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.AddMapTerrainFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheBD);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheBE == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheBE = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle._ComputeCombatArmyRelationValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheBE);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheBF == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheBF = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.AppendActToActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheBF);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheC0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheC0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.AppendActsToActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheC0);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheC1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheC1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.SdkLogBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheC1);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheC2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheC2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle._ComputeArmyRelationValue_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheC2);
		string name = "m_state";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheC3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheC3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_state);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheC3;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheC4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheC4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_state);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheC4, true);
		string name2 = "m_entityIdCounter";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheC5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheC5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_entityIdCounter);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheC5;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheC6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheC6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_entityIdCounter);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheC6, true);
		string name3 = "m_isStopBattleWin";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheC7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheC7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_isStopBattleWin);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheC7;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheC8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheC8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_isStopBattleWin);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheC8, true);
		string name4 = "m_frameCount";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheC9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheC9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_frameCount);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheC9;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheCA == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheCA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_frameCount);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheCA, true);
		string name5 = "m_endCountdown";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheCB == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheCB = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_endCountdown);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheCB;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheCC == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheCC = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_endCountdown);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheCC, true);
		string name6 = "m_cutscenePauseCountdown";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheCD == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheCD = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_cutscenePauseCountdown);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheCD;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheCE == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheCE = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_cutscenePauseCountdown);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheCE, true);
		string name7 = "m_restoreNonSkillTargetsCountdown";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheCF == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheCF = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_restoreNonSkillTargetsCountdown);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheCF;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheD0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheD0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_restoreNonSkillTargetsCountdown);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheD0, true);
		string name8 = "m_tickSoundName";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheD1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheD1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_tickSoundName);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheD1;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheD2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheD2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_tickSoundName);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheD2, true);
		string name9 = "m_battleTickTime";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheD3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheD3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_battleTickTime);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheD3;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheD4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheD4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_battleTickTime);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheD4, true);
		string name10 = "m_combatTickTime";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheD5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheD5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_combatTickTime);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheD5;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheD6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheD6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_combatTickTime);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheD6, true);
		string name11 = "m_timeScale";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheD7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheD7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_timeScale);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheD7;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheD8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheD8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_timeScale);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheD8, true);
		string name12 = "m_globalTimeScale";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheD9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheD9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_globalTimeScale);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheD9;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheDA == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheDA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_globalTimeScale);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheDA, true);
		string name13 = "m_slowMotionState";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheDB == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheDB = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_slowMotionState);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheDB;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheDC == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheDC = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_slowMotionState);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheDC, true);
		string name14 = "m_slowMotionCountdown";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheDD == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheDD = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_slowMotionCountdown);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheDD;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheDE == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheDE = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_slowMotionCountdown);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheDE, true);
		string name15 = "m_isPaused";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheDF == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheDF = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_isPaused);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheDF;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheE0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheE0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_isPaused);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheE0, true);
		string name16 = "m_isAutoBattle";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheE1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheE1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_isAutoBattle);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheE1;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheE2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheE2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_isAutoBattle);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheE2, true);
		string name17 = "m_isFastBattle";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheE3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheE3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_isFastBattle);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheE3;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheE4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheE4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_isFastBattle);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheE4, true);
		string name18 = "m_isEnableDebugDraw";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheE5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheE5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_isEnableDebugDraw);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheE5;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheE6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheE6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_isEnableDebugDraw);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheE6, true);
		string name19 = "m_isEnableSdkLogBattle";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheE7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheE7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_isEnableSdkLogBattle);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheE7;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheE8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheE8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_isEnableSdkLogBattle);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheE8, true);
		string name20 = "m_randomNumber";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheE9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheE9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_randomNumber);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheE9;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheEA == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheEA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_randomNumber);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheEA, true);
		string name21 = "m_battle";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheEB == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheEB = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_battle);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheEB;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheEC == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheEC = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_battle);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheEC, true);
		string name22 = "m_nullActor";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheED == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheED = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_nullActor);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheED;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheEE == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheEE = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_nullActor);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheEE, true);
		string name23 = "m_actors";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheEF == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheEF = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_actors);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheEF;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheF0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheF0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_actors);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheF0, true);
		string name24 = "m_activeActor";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheF1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheF1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_activeActor);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheF1;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheF2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheF2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_activeActor);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheF2, true);
		string name25 = "m_cameraFollowActor";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheF3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheF3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_cameraFollowActor);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheF3;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheF4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheF4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_cameraFollowActor);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheF4, true);
		string name26 = "m_actorActs";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheF5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheF5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_actorActs);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheF5;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheF6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheF6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_actorActs);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheF6, true);
		string name27 = "m_treasures";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheF7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheF7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_treasures);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheF7;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheF8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheF8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_treasures);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheF8, true);
		string name28 = "m_enforceActionOrderHeroIds";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheF9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheF9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_enforceActionOrderHeroIds);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheF9;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheFA == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheFA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_enforceActionOrderHeroIds);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheFA, true);
		string name29 = "m_combatingBattleActorA";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheFB == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheFB = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_combatingBattleActorA);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheFB;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheFC == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheFC = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_combatingBattleActorA);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheFC, true);
		string name30 = "m_combatingBattleActorB";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheFD == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheFD = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_combatingBattleActorB);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheFD;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheFE == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheFE = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_combatingBattleActorB);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheFE, true);
		string name31 = "m_combatSkillInfoA";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheFF == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheFF = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_combatSkillInfoA);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cacheFF;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache100 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache100 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_combatSkillInfoA);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache100, true);
		string name32 = "m_ignoreMoveStep";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache101 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache101 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_ignoreMoveStep);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache101;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache102 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache102 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_ignoreMoveStep);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache102, true);
		string name33 = "m_ignoreSkillStep";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache103 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache103 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_ignoreSkillStep);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache103;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache104 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache104 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_ignoreSkillStep);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache104, true);
		string name34 = "m_ignoreTeleportDisappearStep";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache105 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache105 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_ignoreTeleportDisappearStep);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache105;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache106 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache106 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_ignoreTeleportDisappearStep);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache106, true);
		string name35 = "m_ignoreActiveTeam";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache107 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache107 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_ignoreActiveTeam);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache107;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache108 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache108 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_ignoreActiveTeam);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache108, true);
		string name36 = "m_ignoreActiveTurn";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache109 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache109 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_ignoreActiveTurn);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache109;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache10A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache10A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_ignoreActiveTurn);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache10A, true);
		string name37 = "m_actorActSkillHit";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache10B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache10B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_actorActSkillHit);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache10B;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache10C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache10C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_actorActSkillHit);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache10C, true);
		string name38 = "m_actorActSkillRebound";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache10D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache10D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_actorActSkillRebound);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache10D;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache10E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache10E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_actorActSkillRebound);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache10E, true);
		string name39 = "m_curBattleDialogInfo";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache10F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache10F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_curBattleDialogInfo);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache10F;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache110 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache110 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_curBattleDialogInfo);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache110, true);
		string name40 = "m_battleDialogResult";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache111 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache111 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_battleDialogResult);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache111;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache112 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache112 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_battleDialogResult);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache112, true);
		string name41 = "m_isWaitBattleTreasureDialog";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache113 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache113 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_isWaitBattleTreasureDialog);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache113;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache114 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache114 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_isWaitBattleTreasureDialog);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache114, true);
		string name42 = "m_isWaitBattleTreasureReward";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache115 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache115 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_isWaitBattleTreasureReward);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache115;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache116 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache116 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_isWaitBattleTreasureReward);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache116, true);
		string name43 = "m_isWaitFastCombat";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache117 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache117 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_isWaitFastCombat);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache117;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache118 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache118 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_isWaitFastCombat);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache118, true);
		string name44 = "m_isBattlePerforming";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache119 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache119 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_isBattlePerforming);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache119;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache11A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache11A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_isBattlePerforming);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache11A, true);
		string name45 = "m_myPlayerIndex";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache11B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache11B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_myPlayerIndex);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache11B;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache11C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache11C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_myPlayerIndex);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache11C, true);
		string name46 = "m_myPlayerTeam";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache11D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache11D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_myPlayerTeam);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache11D;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache11E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache11E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_myPlayerTeam);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache11E, true);
		string name47 = "m_rebuildBattleStepMax";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache11F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache11F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_rebuildBattleStepMax);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache11F;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache120 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache120 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_rebuildBattleStepMax);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache120, true);
		string name48 = "m_skipCombatMode";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache121 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache121 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_skipCombatMode);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache121;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache122 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache122 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_skipCombatMode);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache122, true);
		string name49 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache123 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache123 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_configDataLoader);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache123;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache124 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache124 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name49, get49, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache124, true);
		string name50 = "m_clientBattleListener";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache125 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache125 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_clientBattleListener);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache125;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache126 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache126 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_clientBattleListener);
		}
		LuaObject.addMember(l, name50, get50, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache126, true);
		string name51 = "m_battleInfo";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache127 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache127 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_battleInfo);
		}
		LuaCSFunction get51 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache127;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache128 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache128 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_battleInfo);
		}
		LuaObject.addMember(l, name51, get51, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache128, true);
		string name52 = "m_arenaBattleInfo";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache129 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache129 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_arenaBattleInfo);
		}
		LuaCSFunction get52 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache129;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache12A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache12A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_arenaBattleInfo);
		}
		LuaObject.addMember(l, name52, get52, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache12A, true);
		string name53 = "m_pvpBattleInfo";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache12B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache12B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_pvpBattleInfo);
		}
		LuaCSFunction get53 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache12B;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache12C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache12C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_pvpBattleInfo);
		}
		LuaObject.addMember(l, name53, get53, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache12C, true);
		string name54 = "m_realtimePvpBattleInfo";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache12D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache12D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_realtimePvpBattleInfo);
		}
		LuaCSFunction get54 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache12D;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache12E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache12E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_realtimePvpBattleInfo);
		}
		LuaObject.addMember(l, name54, get54, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache12E, true);
		string name55 = "m_battleType";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache12F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache12F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_battleType);
		}
		LuaCSFunction get55 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache12F;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache130 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache130 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_battleType);
		}
		LuaObject.addMember(l, name55, get55, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache130, true);
		string name56 = "m_battleCamera";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache131 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache131 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_battleCamera);
		}
		LuaCSFunction get56 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache131;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache132 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache132 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_battleCamera);
		}
		LuaObject.addMember(l, name56, get56, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache132, true);
		string name57 = "m_combatCamera";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache133 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache133 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_combatCamera);
		}
		LuaCSFunction get57 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache133;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache134 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache134 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_combatCamera);
		}
		LuaObject.addMember(l, name57, get57, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache134, true);
		string name58 = "m_cutsceneCamera";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache135 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache135 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_cutsceneCamera);
		}
		LuaCSFunction get58 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache135;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache136 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache136 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_cutsceneCamera);
		}
		LuaObject.addMember(l, name58, get58, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache136, true);
		string name59 = "m_battleRoot";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache137 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache137 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_battleRoot);
		}
		LuaCSFunction get59 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache137;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache138 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache138 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_battleRoot);
		}
		LuaObject.addMember(l, name59, get59, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache138, true);
		string name60 = "m_combatRoot";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache139 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache139 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_combatRoot);
		}
		LuaCSFunction get60 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache139;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache13A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache13A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_combatRoot);
		}
		LuaObject.addMember(l, name60, get60, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache13A, true);
		string name61 = "m_cutsceneRoot";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache13B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache13B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_cutsceneRoot);
		}
		LuaCSFunction get61 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache13B;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache13C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache13C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_cutsceneRoot);
		}
		LuaObject.addMember(l, name61, get61, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache13C, true);
		string name62 = "m_battleGraphicRoot";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache13D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache13D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_battleGraphicRoot);
		}
		LuaCSFunction get62 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache13D;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache13E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache13E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_battleGraphicRoot);
		}
		LuaObject.addMember(l, name62, get62, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache13E, true);
		string name63 = "m_combatGraphicRoot";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache13F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache13F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_combatGraphicRoot);
		}
		LuaCSFunction get63 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache13F;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache140 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache140 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_combatGraphicRoot);
		}
		LuaObject.addMember(l, name63, get63, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache140, true);
		string name64 = "m_cutsceneGraphicRoot";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache141 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache141 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_cutsceneGraphicRoot);
		}
		LuaCSFunction get64 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache141;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache142 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache142 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_cutsceneGraphicRoot);
		}
		LuaObject.addMember(l, name64, get64, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache142, true);
		string name65 = "m_mapRoot";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache143 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache143 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_mapRoot);
		}
		LuaCSFunction get65 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache143;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache144 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache144 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_mapRoot);
		}
		LuaObject.addMember(l, name65, get65, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache144, true);
		string name66 = "m_mapBackground";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache145 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache145 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_mapBackground);
		}
		LuaCSFunction get66 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache145;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache146 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache146 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_mapBackground);
		}
		LuaObject.addMember(l, name66, get66, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache146, true);
		string name67 = "m_mapTerrainFxRoot";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache147 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache147 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_mapTerrainFxRoot);
		}
		LuaCSFunction get67 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache147;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache148 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache148 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_mapTerrainFxRoot);
		}
		LuaObject.addMember(l, name67, get67, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache148, true);
		string name68 = "m_mapTreasureRoot";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache149 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache149 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_mapTreasureRoot);
		}
		LuaCSFunction get68 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache149;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache14A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache14A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_mapTreasureRoot);
		}
		LuaObject.addMember(l, name68, get68, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache14A, true);
		string name69 = "m_mapTerrainFxs";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache14B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache14B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_mapTerrainFxs);
		}
		LuaCSFunction get69 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache14B;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache14C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache14C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_mapTerrainFxs);
		}
		LuaObject.addMember(l, name69, get69, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache14C, true);
		string name70 = "m_battleUIRoot";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache14D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache14D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_battleUIRoot);
		}
		LuaCSFunction get70 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache14D;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache14E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache14E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_battleUIRoot);
		}
		LuaObject.addMember(l, name70, get70, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache14E, true);
		string name71 = "m_battleActorUIRoot";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache14F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache14F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_battleActorUIRoot);
		}
		LuaCSFunction get71 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache14F;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache150 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache150 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_battleActorUIRoot);
		}
		LuaObject.addMember(l, name71, get71, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache150, true);
		string name72 = "m_battleActorUIPrefab";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache151 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache151 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_battleActorUIPrefab);
		}
		LuaCSFunction get72 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache151;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache152 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache152 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_battleActorUIPrefab);
		}
		LuaObject.addMember(l, name72, get72, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache152, true);
		string name73 = "m_graphicPool";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache153 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache153 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_graphicPool);
		}
		LuaCSFunction get73 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache153;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache154 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache154 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_graphicPool);
		}
		LuaObject.addMember(l, name73, get73, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache154, true);
		string name74 = "m_fxPool";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache155 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache155 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_fxPool);
		}
		LuaCSFunction get74 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache155;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache156 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache156 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_fxPool);
		}
		LuaObject.addMember(l, name74, get74, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache156, true);
		string name75 = "m_battleFxPlayer";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache157 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache157 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_battleFxPlayer);
		}
		LuaCSFunction get75 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache157;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache158 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache158 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_battleFxPlayer);
		}
		LuaObject.addMember(l, name75, get75, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache158, true);
		string name76 = "m_combatFxPlayer";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache159 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache159 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_combatFxPlayer);
		}
		LuaCSFunction get76 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache159;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache15A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache15A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_combatFxPlayer);
		}
		LuaObject.addMember(l, name76, get76, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache15A, true);
		string name77 = "m_cutscenePlayer";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache15B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache15B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_m_cutscenePlayer);
		}
		LuaCSFunction get77 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache15B;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache15C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache15C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_m_cutscenePlayer);
		}
		LuaObject.addMember(l, name77, get77, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache15C, true);
		string name78 = "Battle";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache15D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache15D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_Battle);
		}
		LuaObject.addMember(l, name78, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache15D, null, true);
		string name79 = "BattleCamera";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache15E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache15E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_BattleCamera);
		}
		LuaObject.addMember(l, name79, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache15E, null, true);
		string name80 = "CombatCamera";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache15F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache15F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_CombatCamera);
		}
		LuaObject.addMember(l, name80, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache15F, null, true);
		string name81 = "State";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache160 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache160 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_State);
		}
		LuaObject.addMember(l, name81, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache160, null, true);
		string name82 = "EnableDebugDraw";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache161 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache161 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_EnableDebugDraw);
		}
		LuaCSFunction get78 = Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache161;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache162 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache162 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.set_EnableDebugDraw);
		}
		LuaObject.addMember(l, name82, get78, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache162, true);
		string name83 = "IsAutoBattle";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache163 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache163 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_IsAutoBattle);
		}
		LuaObject.addMember(l, name83, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache163, null, true);
		string name84 = "IsFastBattle";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache164 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache164 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_IsFastBattle);
		}
		LuaObject.addMember(l, name84, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache164, null, true);
		string name85 = "SkipCombatMode";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache165 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache165 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_SkipCombatMode);
		}
		LuaObject.addMember(l, name85, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache165, null, true);
		string name86 = "IsPaused";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache166 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache166 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_IsPaused);
		}
		LuaObject.addMember(l, name86, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache166, null, true);
		string name87 = "BattleGraphicRoot";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache167 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache167 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_BattleGraphicRoot);
		}
		LuaObject.addMember(l, name87, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache167, null, true);
		string name88 = "CombatGraphicRoot";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache168 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache168 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_CombatGraphicRoot);
		}
		LuaObject.addMember(l, name88, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache168, null, true);
		string name89 = "MapTreasureRoot";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache169 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache169 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_MapTreasureRoot);
		}
		LuaObject.addMember(l, name89, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache169, null, true);
		string name90 = "BattleActorUIRoot";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache16A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache16A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_BattleActorUIRoot);
		}
		LuaObject.addMember(l, name90, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache16A, null, true);
		string name91 = "BattleActorUIPrefab";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache16B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache16B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_BattleActorUIPrefab);
		}
		LuaObject.addMember(l, name91, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache16B, null, true);
		string name92 = "BattleFxPlayer";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache16C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache16C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_BattleFxPlayer);
		}
		LuaObject.addMember(l, name92, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache16C, null, true);
		string name93 = "CombatFxPlayer";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache16D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache16D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_CombatFxPlayer);
		}
		LuaObject.addMember(l, name93, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache16D, null, true);
		string name94 = "ConfigDataLoader";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache16E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache16E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_ConfigDataLoader);
		}
		LuaObject.addMember(l, name94, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache16E, null, true);
		string name95 = "ClientBattleListener";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache16F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache16F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_ClientBattleListener);
		}
		LuaObject.addMember(l, name95, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache16F, null, true);
		string name96 = "RandomNumber";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache170 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache170 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.get_RandomNumber);
		}
		LuaObject.addMember(l, name96, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache170, null, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache171 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache171 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientBattle.<>f__mg$cache171, typeof(ClientBattle));
	}

	// Token: 0x04010693 RID: 67219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010694 RID: 67220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010695 RID: 67221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010696 RID: 67222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010697 RID: 67223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010698 RID: 67224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010699 RID: 67225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401069A RID: 67226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401069B RID: 67227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401069C RID: 67228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401069D RID: 67229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401069E RID: 67230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401069F RID: 67231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040106A0 RID: 67232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040106A1 RID: 67233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040106A2 RID: 67234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040106A3 RID: 67235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040106A4 RID: 67236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040106A5 RID: 67237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040106A6 RID: 67238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040106A7 RID: 67239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040106A8 RID: 67240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040106A9 RID: 67241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040106AA RID: 67242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040106AB RID: 67243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040106AC RID: 67244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040106AD RID: 67245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040106AE RID: 67246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040106AF RID: 67247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040106B0 RID: 67248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040106B1 RID: 67249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040106B2 RID: 67250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040106B3 RID: 67251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040106B4 RID: 67252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040106B5 RID: 67253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040106B6 RID: 67254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040106B7 RID: 67255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040106B8 RID: 67256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040106B9 RID: 67257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040106BA RID: 67258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040106BB RID: 67259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040106BC RID: 67260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040106BD RID: 67261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040106BE RID: 67262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040106BF RID: 67263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040106C0 RID: 67264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040106C1 RID: 67265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040106C2 RID: 67266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040106C3 RID: 67267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040106C4 RID: 67268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040106C5 RID: 67269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040106C6 RID: 67270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040106C7 RID: 67271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040106C8 RID: 67272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040106C9 RID: 67273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040106CA RID: 67274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040106CB RID: 67275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040106CC RID: 67276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x040106CD RID: 67277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x040106CE RID: 67278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x040106CF RID: 67279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x040106D0 RID: 67280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x040106D1 RID: 67281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x040106D2 RID: 67282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x040106D3 RID: 67283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x040106D4 RID: 67284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x040106D5 RID: 67285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x040106D6 RID: 67286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x040106D7 RID: 67287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x040106D8 RID: 67288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x040106D9 RID: 67289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x040106DA RID: 67290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x040106DB RID: 67291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x040106DC RID: 67292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x040106DD RID: 67293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x040106DE RID: 67294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x040106DF RID: 67295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x040106E0 RID: 67296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x040106E1 RID: 67297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x040106E2 RID: 67298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x040106E3 RID: 67299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x040106E4 RID: 67300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x040106E5 RID: 67301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x040106E6 RID: 67302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x040106E7 RID: 67303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x040106E8 RID: 67304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x040106E9 RID: 67305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x040106EA RID: 67306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x040106EB RID: 67307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x040106EC RID: 67308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x040106ED RID: 67309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x040106EE RID: 67310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x040106EF RID: 67311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x040106F0 RID: 67312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x040106F1 RID: 67313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x040106F2 RID: 67314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x040106F3 RID: 67315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x040106F4 RID: 67316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x040106F5 RID: 67317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x040106F6 RID: 67318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x040106F7 RID: 67319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x040106F8 RID: 67320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x040106F9 RID: 67321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x040106FA RID: 67322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x040106FB RID: 67323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x040106FC RID: 67324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x040106FD RID: 67325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x040106FE RID: 67326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x040106FF RID: 67327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04010700 RID: 67328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04010701 RID: 67329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04010702 RID: 67330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04010703 RID: 67331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04010704 RID: 67332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04010705 RID: 67333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04010706 RID: 67334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04010707 RID: 67335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04010708 RID: 67336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04010709 RID: 67337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x0401070A RID: 67338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x0401070B RID: 67339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x0401070C RID: 67340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x0401070D RID: 67341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x0401070E RID: 67342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x0401070F RID: 67343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x04010710 RID: 67344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x04010711 RID: 67345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x04010712 RID: 67346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x04010713 RID: 67347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x04010714 RID: 67348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04010715 RID: 67349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04010716 RID: 67350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x04010717 RID: 67351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x04010718 RID: 67352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x04010719 RID: 67353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x0401071A RID: 67354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x0401071B RID: 67355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x0401071C RID: 67356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x0401071D RID: 67357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x0401071E RID: 67358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x0401071F RID: 67359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x04010720 RID: 67360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x04010721 RID: 67361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x04010722 RID: 67362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x04010723 RID: 67363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x04010724 RID: 67364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x04010725 RID: 67365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x04010726 RID: 67366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x04010727 RID: 67367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x04010728 RID: 67368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x04010729 RID: 67369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x0401072A RID: 67370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x0401072B RID: 67371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x0401072C RID: 67372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x0401072D RID: 67373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x0401072E RID: 67374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x0401072F RID: 67375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x04010730 RID: 67376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x04010731 RID: 67377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x04010732 RID: 67378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x04010733 RID: 67379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x04010734 RID: 67380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x04010735 RID: 67381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x04010736 RID: 67382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x04010737 RID: 67383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x04010738 RID: 67384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x04010739 RID: 67385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x0401073A RID: 67386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x0401073B RID: 67387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;

	// Token: 0x0401073C RID: 67388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA9;

	// Token: 0x0401073D RID: 67389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAA;

	// Token: 0x0401073E RID: 67390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAB;

	// Token: 0x0401073F RID: 67391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAC;

	// Token: 0x04010740 RID: 67392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAD;

	// Token: 0x04010741 RID: 67393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAE;

	// Token: 0x04010742 RID: 67394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAF;

	// Token: 0x04010743 RID: 67395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB0;

	// Token: 0x04010744 RID: 67396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB1;

	// Token: 0x04010745 RID: 67397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB2;

	// Token: 0x04010746 RID: 67398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB3;

	// Token: 0x04010747 RID: 67399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB4;

	// Token: 0x04010748 RID: 67400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB5;

	// Token: 0x04010749 RID: 67401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB6;

	// Token: 0x0401074A RID: 67402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB7;

	// Token: 0x0401074B RID: 67403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB8;

	// Token: 0x0401074C RID: 67404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB9;

	// Token: 0x0401074D RID: 67405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBA;

	// Token: 0x0401074E RID: 67406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBB;

	// Token: 0x0401074F RID: 67407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBC;

	// Token: 0x04010750 RID: 67408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBD;

	// Token: 0x04010751 RID: 67409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBE;

	// Token: 0x04010752 RID: 67410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBF;

	// Token: 0x04010753 RID: 67411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC0;

	// Token: 0x04010754 RID: 67412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC1;

	// Token: 0x04010755 RID: 67413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC2;

	// Token: 0x04010756 RID: 67414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC3;

	// Token: 0x04010757 RID: 67415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC4;

	// Token: 0x04010758 RID: 67416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC5;

	// Token: 0x04010759 RID: 67417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC6;

	// Token: 0x0401075A RID: 67418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC7;

	// Token: 0x0401075B RID: 67419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC8;

	// Token: 0x0401075C RID: 67420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC9;

	// Token: 0x0401075D RID: 67421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCA;

	// Token: 0x0401075E RID: 67422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCB;

	// Token: 0x0401075F RID: 67423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCC;

	// Token: 0x04010760 RID: 67424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCD;

	// Token: 0x04010761 RID: 67425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCE;

	// Token: 0x04010762 RID: 67426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCF;

	// Token: 0x04010763 RID: 67427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD0;

	// Token: 0x04010764 RID: 67428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD1;

	// Token: 0x04010765 RID: 67429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD2;

	// Token: 0x04010766 RID: 67430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD3;

	// Token: 0x04010767 RID: 67431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD4;

	// Token: 0x04010768 RID: 67432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD5;

	// Token: 0x04010769 RID: 67433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD6;

	// Token: 0x0401076A RID: 67434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD7;

	// Token: 0x0401076B RID: 67435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD8;

	// Token: 0x0401076C RID: 67436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD9;

	// Token: 0x0401076D RID: 67437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDA;

	// Token: 0x0401076E RID: 67438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDB;

	// Token: 0x0401076F RID: 67439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDC;

	// Token: 0x04010770 RID: 67440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDD;

	// Token: 0x04010771 RID: 67441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDE;

	// Token: 0x04010772 RID: 67442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDF;

	// Token: 0x04010773 RID: 67443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE0;

	// Token: 0x04010774 RID: 67444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE1;

	// Token: 0x04010775 RID: 67445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE2;

	// Token: 0x04010776 RID: 67446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE3;

	// Token: 0x04010777 RID: 67447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE4;

	// Token: 0x04010778 RID: 67448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE5;

	// Token: 0x04010779 RID: 67449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE6;

	// Token: 0x0401077A RID: 67450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE7;

	// Token: 0x0401077B RID: 67451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE8;

	// Token: 0x0401077C RID: 67452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE9;

	// Token: 0x0401077D RID: 67453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEA;

	// Token: 0x0401077E RID: 67454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEB;

	// Token: 0x0401077F RID: 67455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEC;

	// Token: 0x04010780 RID: 67456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheED;

	// Token: 0x04010781 RID: 67457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEE;

	// Token: 0x04010782 RID: 67458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEF;

	// Token: 0x04010783 RID: 67459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF0;

	// Token: 0x04010784 RID: 67460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF1;

	// Token: 0x04010785 RID: 67461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF2;

	// Token: 0x04010786 RID: 67462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF3;

	// Token: 0x04010787 RID: 67463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF4;

	// Token: 0x04010788 RID: 67464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF5;

	// Token: 0x04010789 RID: 67465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF6;

	// Token: 0x0401078A RID: 67466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF7;

	// Token: 0x0401078B RID: 67467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF8;

	// Token: 0x0401078C RID: 67468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF9;

	// Token: 0x0401078D RID: 67469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFA;

	// Token: 0x0401078E RID: 67470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFB;

	// Token: 0x0401078F RID: 67471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFC;

	// Token: 0x04010790 RID: 67472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFD;

	// Token: 0x04010791 RID: 67473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFE;

	// Token: 0x04010792 RID: 67474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFF;

	// Token: 0x04010793 RID: 67475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache100;

	// Token: 0x04010794 RID: 67476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache101;

	// Token: 0x04010795 RID: 67477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache102;

	// Token: 0x04010796 RID: 67478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache103;

	// Token: 0x04010797 RID: 67479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache104;

	// Token: 0x04010798 RID: 67480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache105;

	// Token: 0x04010799 RID: 67481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache106;

	// Token: 0x0401079A RID: 67482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache107;

	// Token: 0x0401079B RID: 67483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache108;

	// Token: 0x0401079C RID: 67484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache109;

	// Token: 0x0401079D RID: 67485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10A;

	// Token: 0x0401079E RID: 67486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10B;

	// Token: 0x0401079F RID: 67487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10C;

	// Token: 0x040107A0 RID: 67488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10D;

	// Token: 0x040107A1 RID: 67489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10E;

	// Token: 0x040107A2 RID: 67490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10F;

	// Token: 0x040107A3 RID: 67491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache110;

	// Token: 0x040107A4 RID: 67492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache111;

	// Token: 0x040107A5 RID: 67493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache112;

	// Token: 0x040107A6 RID: 67494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache113;

	// Token: 0x040107A7 RID: 67495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache114;

	// Token: 0x040107A8 RID: 67496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache115;

	// Token: 0x040107A9 RID: 67497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache116;

	// Token: 0x040107AA RID: 67498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache117;

	// Token: 0x040107AB RID: 67499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache118;

	// Token: 0x040107AC RID: 67500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache119;

	// Token: 0x040107AD RID: 67501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11A;

	// Token: 0x040107AE RID: 67502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11B;

	// Token: 0x040107AF RID: 67503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11C;

	// Token: 0x040107B0 RID: 67504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11D;

	// Token: 0x040107B1 RID: 67505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11E;

	// Token: 0x040107B2 RID: 67506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11F;

	// Token: 0x040107B3 RID: 67507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache120;

	// Token: 0x040107B4 RID: 67508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache121;

	// Token: 0x040107B5 RID: 67509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache122;

	// Token: 0x040107B6 RID: 67510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache123;

	// Token: 0x040107B7 RID: 67511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache124;

	// Token: 0x040107B8 RID: 67512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache125;

	// Token: 0x040107B9 RID: 67513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache126;

	// Token: 0x040107BA RID: 67514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache127;

	// Token: 0x040107BB RID: 67515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache128;

	// Token: 0x040107BC RID: 67516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache129;

	// Token: 0x040107BD RID: 67517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12A;

	// Token: 0x040107BE RID: 67518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12B;

	// Token: 0x040107BF RID: 67519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12C;

	// Token: 0x040107C0 RID: 67520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12D;

	// Token: 0x040107C1 RID: 67521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12E;

	// Token: 0x040107C2 RID: 67522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12F;

	// Token: 0x040107C3 RID: 67523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache130;

	// Token: 0x040107C4 RID: 67524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache131;

	// Token: 0x040107C5 RID: 67525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache132;

	// Token: 0x040107C6 RID: 67526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache133;

	// Token: 0x040107C7 RID: 67527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache134;

	// Token: 0x040107C8 RID: 67528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache135;

	// Token: 0x040107C9 RID: 67529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache136;

	// Token: 0x040107CA RID: 67530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache137;

	// Token: 0x040107CB RID: 67531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache138;

	// Token: 0x040107CC RID: 67532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache139;

	// Token: 0x040107CD RID: 67533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13A;

	// Token: 0x040107CE RID: 67534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13B;

	// Token: 0x040107CF RID: 67535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13C;

	// Token: 0x040107D0 RID: 67536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13D;

	// Token: 0x040107D1 RID: 67537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13E;

	// Token: 0x040107D2 RID: 67538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13F;

	// Token: 0x040107D3 RID: 67539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache140;

	// Token: 0x040107D4 RID: 67540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache141;

	// Token: 0x040107D5 RID: 67541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache142;

	// Token: 0x040107D6 RID: 67542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache143;

	// Token: 0x040107D7 RID: 67543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache144;

	// Token: 0x040107D8 RID: 67544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache145;

	// Token: 0x040107D9 RID: 67545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache146;

	// Token: 0x040107DA RID: 67546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache147;

	// Token: 0x040107DB RID: 67547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache148;

	// Token: 0x040107DC RID: 67548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache149;

	// Token: 0x040107DD RID: 67549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14A;

	// Token: 0x040107DE RID: 67550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14B;

	// Token: 0x040107DF RID: 67551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14C;

	// Token: 0x040107E0 RID: 67552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14D;

	// Token: 0x040107E1 RID: 67553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14E;

	// Token: 0x040107E2 RID: 67554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14F;

	// Token: 0x040107E3 RID: 67555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache150;

	// Token: 0x040107E4 RID: 67556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache151;

	// Token: 0x040107E5 RID: 67557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache152;

	// Token: 0x040107E6 RID: 67558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache153;

	// Token: 0x040107E7 RID: 67559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache154;

	// Token: 0x040107E8 RID: 67560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache155;

	// Token: 0x040107E9 RID: 67561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache156;

	// Token: 0x040107EA RID: 67562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache157;

	// Token: 0x040107EB RID: 67563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache158;

	// Token: 0x040107EC RID: 67564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache159;

	// Token: 0x040107ED RID: 67565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15A;

	// Token: 0x040107EE RID: 67566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15B;

	// Token: 0x040107EF RID: 67567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15C;

	// Token: 0x040107F0 RID: 67568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15D;

	// Token: 0x040107F1 RID: 67569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15E;

	// Token: 0x040107F2 RID: 67570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15F;

	// Token: 0x040107F3 RID: 67571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache160;

	// Token: 0x040107F4 RID: 67572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache161;

	// Token: 0x040107F5 RID: 67573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache162;

	// Token: 0x040107F6 RID: 67574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache163;

	// Token: 0x040107F7 RID: 67575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache164;

	// Token: 0x040107F8 RID: 67576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache165;

	// Token: 0x040107F9 RID: 67577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache166;

	// Token: 0x040107FA RID: 67578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache167;

	// Token: 0x040107FB RID: 67579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache168;

	// Token: 0x040107FC RID: 67580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache169;

	// Token: 0x040107FD RID: 67581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16A;

	// Token: 0x040107FE RID: 67582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16B;

	// Token: 0x040107FF RID: 67583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16C;

	// Token: 0x04010800 RID: 67584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16D;

	// Token: 0x04010801 RID: 67585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16E;

	// Token: 0x04010802 RID: 67586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16F;

	// Token: 0x04010803 RID: 67587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache170;

	// Token: 0x04010804 RID: 67588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache171;
}
