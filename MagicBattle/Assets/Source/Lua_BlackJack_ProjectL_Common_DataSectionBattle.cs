using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011F7 RID: 4599
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionBattle : LuaObject
{
	// Token: 0x06017D8B RID: 97675 RVA: 0x00694DD8 File Offset: 0x00692FD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle o = new DataSectionBattle();
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

	// Token: 0x06017D8C RID: 97676 RVA: 0x00694E20 File Offset: 0x00693020
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			dataSectionBattle.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D8D RID: 97677 RVA: 0x00694E6C File Offset: 0x0069306C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SerializeToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			object o = dataSectionBattle.SerializeToClient();
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

	// Token: 0x06017D8E RID: 97678 RVA: 0x00694EC0 File Offset: 0x006930C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitProcessingBattle(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			ProcessingBattle info;
			LuaObject.checkType<ProcessingBattle>(l, 2, out info);
			dataSectionBattle.InitProcessingBattle(info);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D8F RID: 97679 RVA: 0x00694F18 File Offset: 0x00693118
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitTeams(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			Dictionary<int, List<int>> teams;
			LuaObject.checkType<Dictionary<int, List<int>>>(l, 2, out teams);
			dataSectionBattle.InitTeams(teams);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D90 RID: 97680 RVA: 0x00694F70 File Offset: 0x00693170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTeam(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			int teamTypeId;
			LuaObject.checkType(l, 2, out teamTypeId);
			List<int> heroes;
			LuaObject.checkType<List<int>>(l, 3, out heroes);
			dataSectionBattle.SetTeam(teamTypeId, heroes);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D91 RID: 97681 RVA: 0x00694FD4 File Offset: 0x006931D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTeam(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			int teamTypeId;
			LuaObject.checkType(l, 2, out teamTypeId);
			List<int> team = dataSectionBattle.GetTeam(teamTypeId);
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

	// Token: 0x06017D92 RID: 97682 RVA: 0x00695038 File Offset: 0x00693238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetProcessingBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			BattleType type;
			LuaObject.checkEnum<BattleType>(l, 2, out type);
			int typeId;
			LuaObject.checkType(l, 3, out typeId);
			dataSectionBattle.SetProcessingBattleInfo(type, typeId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D93 RID: 97683 RVA: 0x0069509C File Offset: 0x0069329C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetRandomSeed(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			int randomSeed;
			LuaObject.checkType(l, 2, out randomSeed);
			dataSectionBattle.SetRandomSeed(randomSeed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D94 RID: 97684 RVA: 0x006950F4 File Offset: 0x006932F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetArmyRandomSeed(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			int armyRandomSeed;
			LuaObject.checkType(l, 2, out armyRandomSeed);
			dataSectionBattle.SetArmyRandomSeed(armyRandomSeed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D95 RID: 97685 RVA: 0x0069514C File Offset: 0x0069334C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetArmyRandomSeed(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			int armyRandomSeed = dataSectionBattle.GetArmyRandomSeed();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, armyRandomSeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D96 RID: 97686 RVA: 0x006951A0 File Offset: 0x006933A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsGotBattleTreasureId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			bool b = dataSectionBattle.IsGotBattleTreasureId(id);
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

	// Token: 0x06017D97 RID: 97687 RVA: 0x00695204 File Offset: 0x00693404
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddBattleTreasureId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			dataSectionBattle.AddBattleTreasureId(id);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D98 RID: 97688 RVA: 0x0069525C File Offset: 0x0069345C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetArmyRandomSeedByBattleId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			int battleId;
			LuaObject.checkType(l, 2, out battleId);
			int armyRandomSeedByBattleId = dataSectionBattle.GetArmyRandomSeedByBattleId(battleId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, armyRandomSeedByBattleId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D99 RID: 97689 RVA: 0x006952C0 File Offset: 0x006934C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RemoveEveryTimeArmyRandomSeed(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			int battleId;
			LuaObject.checkType(l, 2, out battleId);
			dataSectionBattle.RemoveEveryTimeArmyRandomSeed(battleId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D9A RID: 97690 RVA: 0x00695318 File Offset: 0x00693518
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddEveryTimeArmyRandomSeed(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			int battleId;
			LuaObject.checkType(l, 2, out battleId);
			int randomSeed;
			LuaObject.checkType(l, 3, out randomSeed);
			dataSectionBattle.AddEveryTimeArmyRandomSeed(battleId, randomSeed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D9B RID: 97691 RVA: 0x0069537C File Offset: 0x0069357C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddDailyTimeArmyRandomSeed(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			int battleId;
			LuaObject.checkType(l, 2, out battleId);
			int randomSeed;
			LuaObject.checkType(l, 3, out randomSeed);
			dataSectionBattle.AddDailyTimeArmyRandomSeed(battleId, randomSeed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D9C RID: 97692 RVA: 0x006953E0 File Offset: 0x006935E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitDailyTimeArmyRandomSeed(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			int bettleId;
			LuaObject.checkType(l, 2, out bettleId);
			int armyRandomSeed;
			LuaObject.checkType(l, 3, out armyRandomSeed);
			dataSectionBattle.InitDailyTimeArmyRandomSeed(bettleId, armyRandomSeed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D9D RID: 97693 RVA: 0x00695444 File Offset: 0x00693644
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitEveryTimeArmyRandomSeed(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			int bettleId;
			LuaObject.checkType(l, 2, out bettleId);
			int armyRandomSeed;
			LuaObject.checkType(l, 3, out armyRandomSeed);
			dataSectionBattle.InitEveryTimeArmyRandomSeed(bettleId, armyRandomSeed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D9E RID: 97694 RVA: 0x006954A8 File Offset: 0x006936A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearDailyArmyRandomSeeds(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			dataSectionBattle.ClearDailyArmyRandomSeeds();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D9F RID: 97695 RVA: 0x006954F4 File Offset: 0x006936F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearProcesingBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			dataSectionBattle.ClearProcesingBattleInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DA0 RID: 97696 RVA: 0x00695540 File Offset: 0x00693740
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ProcessingBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionBattle.ProcessingBattleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DA1 RID: 97697 RVA: 0x00695594 File Offset: 0x00693794
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Teams(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionBattle.Teams);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DA2 RID: 97698 RVA: 0x006955E8 File Offset: 0x006937E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Teams(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			Dictionary<int, List<int>> teams;
			LuaObject.checkType<Dictionary<int, List<int>>>(l, 2, out teams);
			dataSectionBattle.Teams = teams;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DA3 RID: 97699 RVA: 0x00695640 File Offset: 0x00693840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GotBattleTreasureIds(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionBattle.GotBattleTreasureIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DA4 RID: 97700 RVA: 0x00695694 File Offset: 0x00693894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GotBattleTreasureIds(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			List<int> gotBattleTreasureIds;
			LuaObject.checkType<List<int>>(l, 2, out gotBattleTreasureIds);
			dataSectionBattle.GotBattleTreasureIds = gotBattleTreasureIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DA5 RID: 97701 RVA: 0x006956EC File Offset: 0x006938EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DailyArmyRandomSeedDict(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionBattle.DailyArmyRandomSeedDict);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DA6 RID: 97702 RVA: 0x00695740 File Offset: 0x00693940
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DailyArmyRandomSeedDict(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			Dictionary<int, int> dailyArmyRandomSeedDict;
			LuaObject.checkType<Dictionary<int, int>>(l, 2, out dailyArmyRandomSeedDict);
			dataSectionBattle.DailyArmyRandomSeedDict = dailyArmyRandomSeedDict;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DA7 RID: 97703 RVA: 0x00695798 File Offset: 0x00693998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EveryTimeArmyRandomSeedDict(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionBattle.EveryTimeArmyRandomSeedDict);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DA8 RID: 97704 RVA: 0x006957EC File Offset: 0x006939EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EveryTimeArmyRandomSeedDict(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			Dictionary<int, int> everyTimeArmyRandomSeedDict;
			LuaObject.checkType<Dictionary<int, int>>(l, 2, out everyTimeArmyRandomSeedDict);
			dataSectionBattle.EveryTimeArmyRandomSeedDict = everyTimeArmyRandomSeedDict;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DA9 RID: 97705 RVA: 0x00695844 File Offset: 0x00693A44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ArenaBattleStatus(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)dataSectionBattle.ArenaBattleStatus);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DAA RID: 97706 RVA: 0x00695898 File Offset: 0x00693A98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ArenaBattleStatus(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			ArenaBattleStatus arenaBattleStatus;
			LuaObject.checkEnum<ArenaBattleStatus>(l, 2, out arenaBattleStatus);
			dataSectionBattle.ArenaBattleStatus = arenaBattleStatus;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DAB RID: 97707 RVA: 0x006958F0 File Offset: 0x00693AF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ArenaBattleId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionBattle.ArenaBattleId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DAC RID: 97708 RVA: 0x00695944 File Offset: 0x00693B44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ArenaBattleId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			int arenaBattleId;
			LuaObject.checkType(l, 2, out arenaBattleId);
			dataSectionBattle.ArenaBattleId = arenaBattleId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DAD RID: 97709 RVA: 0x0069599C File Offset: 0x00693B9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ArenaBattleRandomSeed(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionBattle.ArenaBattleRandomSeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DAE RID: 97710 RVA: 0x006959F0 File Offset: 0x00693BF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ArenaBattleRandomSeed(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			int arenaBattleRandomSeed;
			LuaObject.checkType(l, 2, out arenaBattleRandomSeed);
			dataSectionBattle.ArenaBattleRandomSeed = arenaBattleRandomSeed;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DAF RID: 97711 RVA: 0x00695A48 File Offset: 0x00693C48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleRoomId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionBattle.BattleRoomId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DB0 RID: 97712 RVA: 0x00695A9C File Offset: 0x00693C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BattleRoomId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBattle dataSectionBattle = (DataSectionBattle)LuaObject.checkSelf(l);
			ulong battleRoomId;
			LuaObject.checkType(l, 2, out battleRoomId);
			dataSectionBattle.BattleRoomId = battleRoomId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DB1 RID: 97713 RVA: 0x00695AF4 File Offset: 0x00693CF4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionBattle");
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.SerializeToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.InitProcessingBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.InitTeams);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.SetTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.GetTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.SetProcessingBattleInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.SetRandomSeed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.SetArmyRandomSeed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.GetArmyRandomSeed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.IsGotBattleTreasureId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.AddBattleTreasureId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.GetArmyRandomSeedByBattleId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.RemoveEveryTimeArmyRandomSeed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.AddEveryTimeArmyRandomSeed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.AddDailyTimeArmyRandomSeed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.InitDailyTimeArmyRandomSeed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.InitEveryTimeArmyRandomSeed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.ClearDailyArmyRandomSeeds);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.ClearProcesingBattleInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache13);
		string name = "ProcessingBattleInfo";
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.get_ProcessingBattleInfo);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache14, null, true);
		string name2 = "Teams";
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.get_Teams);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.set_Teams);
		}
		LuaObject.addMember(l, name2, get, Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache16, true);
		string name3 = "GotBattleTreasureIds";
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.get_GotBattleTreasureIds);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.set_GotBattleTreasureIds);
		}
		LuaObject.addMember(l, name3, get2, Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache18, true);
		string name4 = "DailyArmyRandomSeedDict";
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.get_DailyArmyRandomSeedDict);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.set_DailyArmyRandomSeedDict);
		}
		LuaObject.addMember(l, name4, get3, Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache1A, true);
		string name5 = "EveryTimeArmyRandomSeedDict";
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.get_EveryTimeArmyRandomSeedDict);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.set_EveryTimeArmyRandomSeedDict);
		}
		LuaObject.addMember(l, name5, get4, Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache1C, true);
		string name6 = "ArenaBattleStatus";
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.get_ArenaBattleStatus);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.set_ArenaBattleStatus);
		}
		LuaObject.addMember(l, name6, get5, Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache1E, true);
		string name7 = "ArenaBattleId";
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.get_ArenaBattleId);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.set_ArenaBattleId);
		}
		LuaObject.addMember(l, name7, get6, Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache20, true);
		string name8 = "ArenaBattleRandomSeed";
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.get_ArenaBattleRandomSeed);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.set_ArenaBattleRandomSeed);
		}
		LuaObject.addMember(l, name8, get7, Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache22, true);
		string name9 = "BattleRoomId";
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.get_BattleRoomId);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.set_BattleRoomId);
		}
		LuaObject.addMember(l, name9, get8, Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache24, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBattle.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionBattle.<>f__mg$cache25, typeof(DataSectionBattle), typeof(DataSection));
	}

	// Token: 0x0400E37F RID: 58239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E380 RID: 58240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E381 RID: 58241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E382 RID: 58242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E383 RID: 58243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E384 RID: 58244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E385 RID: 58245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E386 RID: 58246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E387 RID: 58247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E388 RID: 58248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E389 RID: 58249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E38A RID: 58250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E38B RID: 58251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E38C RID: 58252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E38D RID: 58253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E38E RID: 58254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E38F RID: 58255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E390 RID: 58256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E391 RID: 58257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E392 RID: 58258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E393 RID: 58259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400E394 RID: 58260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400E395 RID: 58261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400E396 RID: 58262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400E397 RID: 58263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400E398 RID: 58264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400E399 RID: 58265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400E39A RID: 58266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400E39B RID: 58267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400E39C RID: 58268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400E39D RID: 58269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400E39E RID: 58270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400E39F RID: 58271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400E3A0 RID: 58272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400E3A1 RID: 58273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400E3A2 RID: 58274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400E3A3 RID: 58275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400E3A4 RID: 58276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;
}
