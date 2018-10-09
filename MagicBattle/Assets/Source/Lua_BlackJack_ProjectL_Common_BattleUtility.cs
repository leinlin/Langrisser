using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011D4 RID: 4564
[Preserve]
public class Lua_BlackJack_ProjectL_Common_BattleUtility : LuaObject
{
	// Token: 0x06017AE0 RID: 96992 RVA: 0x00681FB8 File Offset: 0x006801B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleUtility o = new BattleUtility();
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

	// Token: 0x06017AE1 RID: 96993 RVA: 0x00682000 File Offset: 0x00680200
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CreateDefaultConfigBattleHero_s(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo heroInfo;
			LuaObject.checkType<ConfigDataHeroInfo>(l, 1, out heroInfo);
			BattleHero o = BattleUtility.CreateDefaultConfigBattleHero(heroInfo);
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

	// Token: 0x06017AE2 RID: 96994 RVA: 0x00682054 File Offset: 0x00680254
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CreateBattleActorSetupFromBattleHero_s(IntPtr l)
	{
		int result;
		try
		{
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 1, out configDataLoader);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			int level;
			LuaObject.checkType(l, 3, out level);
			int behaviorId;
			LuaObject.checkType(l, 4, out behaviorId);
			int groupId;
			LuaObject.checkType(l, 5, out groupId);
			BattleActorSetup o = BattleUtility.CreateBattleActorSetupFromBattleHero(configDataLoader, hero, level, behaviorId, groupId);
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

	// Token: 0x06017AE3 RID: 96995 RVA: 0x006820DC File Offset: 0x006802DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CreatePveMyBattleActorSetup_s(IntPtr l)
	{
		int result;
		try
		{
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 1, out configDataLoader);
			ConfigDataBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 2, out battleInfo);
			int position;
			LuaObject.checkType(l, 3, out position);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 4, out hero);
			BattleActorSetup o = BattleUtility.CreatePveMyBattleActorSetup(configDataLoader, battleInfo, position, hero);
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

	// Token: 0x06017AE4 RID: 96996 RVA: 0x00682158 File Offset: 0x00680358
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CreateArenaBattleActorSetup_s(IntPtr l)
	{
		int result;
		try
		{
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 1, out configDataLoader);
			int team;
			LuaObject.checkType(l, 2, out team);
			ConfigDataArenaBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataArenaBattleInfo>(l, 3, out battleInfo);
			int position;
			LuaObject.checkType(l, 4, out position);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 5, out hero);
			BattleActorSetup o = BattleUtility.CreateArenaBattleActorSetup(configDataLoader, team, battleInfo, position, hero);
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

	// Token: 0x06017AE5 RID: 96997 RVA: 0x006821E0 File Offset: 0x006803E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CreatePvpBattleActorSetup_s(IntPtr l)
	{
		int result;
		try
		{
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 1, out configDataLoader);
			int team;
			LuaObject.checkType(l, 2, out team);
			ConfigDataPVPBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataPVPBattleInfo>(l, 3, out battleInfo);
			int position;
			LuaObject.checkType(l, 4, out position);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 5, out hero);
			BattleActorSetup o = BattleUtility.CreatePvpBattleActorSetup(configDataLoader, team, battleInfo, position, hero);
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

	// Token: 0x06017AE6 RID: 96998 RVA: 0x00682268 File Offset: 0x00680468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateRealtimePvpBattleActorSetup_s(IntPtr l)
	{
		int result;
		try
		{
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 1, out configDataLoader);
			int team;
			LuaObject.checkType(l, 2, out team);
			ConfigDataRealTimePVPBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataRealTimePVPBattleInfo>(l, 3, out battleInfo);
			int position;
			LuaObject.checkType(l, 4, out position);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 5, out hero);
			BattleActorSetup o = BattleUtility.CreateRealtimePvpBattleActorSetup(configDataLoader, team, battleInfo, position, hero);
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

	// Token: 0x06017AE7 RID: 96999 RVA: 0x006822F0 File Offset: 0x006804F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AppendPveMyNpcBattleActorSetups_s(IntPtr l)
	{
		int result;
		try
		{
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 1, out configDataLoader);
			ConfigDataBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 2, out battleInfo);
			int monsterLevel;
			LuaObject.checkType(l, 3, out monsterLevel);
			List<BattleActorSetup> actors;
			LuaObject.checkType<List<BattleActorSetup>>(l, 4, out actors);
			int i = BattleUtility.AppendPveMyNpcBattleActorSetups(configDataLoader, battleInfo, monsterLevel, actors);
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

	// Token: 0x06017AE8 RID: 97000 RVA: 0x0068236C File Offset: 0x0068056C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AppendPveOpponentBattleActorSetups_s(IntPtr l)
	{
		int result;
		try
		{
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 1, out configDataLoader);
			ConfigDataBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 2, out battleInfo);
			int monsterLevel;
			LuaObject.checkType(l, 3, out monsterLevel);
			int randomSeed;
			LuaObject.checkType(l, 4, out randomSeed);
			List<BattleActorSetup> actors;
			LuaObject.checkType<List<BattleActorSetup>>(l, 5, out actors);
			int i = BattleUtility.AppendPveOpponentBattleActorSetups(configDataLoader, battleInfo, monsterLevel, randomSeed, actors);
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

	// Token: 0x06017AE9 RID: 97001 RVA: 0x006823F4 File Offset: 0x006805F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRandomBattleArmyActors_s(IntPtr l)
	{
		int result;
		try
		{
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 1, out configDataLoader);
			List<int> randomArmies;
			LuaObject.checkType<List<int>>(l, 2, out randomArmies);
			RandomNumber randomNumber;
			LuaObject.checkType<RandomNumber>(l, 3, out randomNumber);
			List<RandomArmyActor> o;
			int randomBattleArmyActors = BattleUtility.GetRandomBattleArmyActors(configDataLoader, randomArmies, randomNumber, out o);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomBattleArmyActors);
			LuaObject.pushValue(l, o);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AEA RID: 97002 RVA: 0x0068246C File Offset: 0x0068066C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetRandomTalentSkillId_s(IntPtr l)
	{
		int result;
		try
		{
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 1, out configDataLoader);
			RandomNumber randomNumber;
			LuaObject.checkType<RandomNumber>(l, 2, out randomNumber);
			int randomTalentId;
			LuaObject.checkType(l, 3, out randomTalentId);
			int randomTalentSkillId = BattleUtility.GetRandomTalentSkillId(configDataLoader, randomNumber, randomTalentId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomTalentSkillId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AEB RID: 97003 RVA: 0x006824DC File Offset: 0x006806DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRandomTalentSkills_s(IntPtr l)
	{
		int result;
		try
		{
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 1, out configDataLoader);
			int randomTalentId;
			LuaObject.checkType(l, 2, out randomTalentId);
			List<int> randomTalentProbilities;
			LuaObject.checkType<List<int>>(l, 3, out randomTalentProbilities);
			RandomNumber randomNumber;
			LuaObject.checkType<RandomNumber>(l, 4, out randomNumber);
			List<ConfigDataSkillInfo> o;
			BattleUtility.GetRandomTalentSkills(configDataLoader, randomTalentId, randomTalentProbilities, randomNumber, out o);
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

	// Token: 0x06017AEC RID: 97004 RVA: 0x00682558 File Offset: 0x00680758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetEquipmentResonanceSkillInfos_s(IntPtr l)
	{
		int result;
		try
		{
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 1, out configDataLoader);
			List<BattleHeroEquipment> equipments;
			LuaObject.checkType<List<BattleHeroEquipment>>(l, 2, out equipments);
			List<ConfigDataSkillInfo> equipmentResonanceSkillInfos = BattleUtility.GetEquipmentResonanceSkillInfos(configDataLoader, equipments);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentResonanceSkillInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AED RID: 97005 RVA: 0x006825B8 File Offset: 0x006807B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTrainingTechSoldierSkillInfos_s(IntPtr l)
	{
		int result;
		try
		{
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 1, out configDataLoader);
			List<TrainingTech> techs;
			LuaObject.checkType<List<TrainingTech>>(l, 2, out techs);
			ConfigDataSoldierInfo soldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 3, out soldierInfo);
			int i;
			List<ConfigDataSkillInfo> trainingTechSoldierSkillInfos = BattleUtility.GetTrainingTechSoldierSkillInfos(configDataLoader, techs, soldierInfo, out i);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingTechSoldierSkillInfos);
			LuaObject.pushValue(l, i);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AEE RID: 97006 RVA: 0x00682630 File Offset: 0x00680830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTrainingTechSummonSkills_s(IntPtr l)
	{
		int result;
		try
		{
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 1, out configDataLoader);
			List<TrainingTech> techs;
			LuaObject.checkType<List<TrainingTech>>(l, 2, out techs);
			ConfigDataHeroInfo heroInfo;
			LuaObject.checkType<ConfigDataHeroInfo>(l, 3, out heroInfo);
			List<ConfigDataSkillInfo> trainingTechSummonSkills = BattleUtility.GetTrainingTechSummonSkills(configDataLoader, techs, heroInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingTechSummonSkills);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AEF RID: 97007 RVA: 0x006826A0 File Offset: 0x006808A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateBattlePlayer_s(IntPtr l)
	{
		int result;
		try
		{
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 1, out configDataLoader);
			int playerLevel;
			LuaObject.checkType(l, 2, out playerLevel);
			List<TrainingTech> techs;
			LuaObject.checkType<List<TrainingTech>>(l, 3, out techs);
			ulong sessionId;
			LuaObject.checkType(l, 4, out sessionId);
			BattlePlayer o = BattleUtility.CreateBattlePlayer(configDataLoader, playerLevel, techs, sessionId);
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

	// Token: 0x06017AF0 RID: 97008 RVA: 0x0068271C File Offset: 0x0068091C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroCharImageSkinResourceInfo_s(IntPtr l)
	{
		int result;
		try
		{
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 1, out configDataLoader);
			int charSkinId;
			LuaObject.checkType(l, 2, out charSkinId);
			ConfigDataCharImageSkinResourceInfo heroCharImageSkinResourceInfo = BattleUtility.GetHeroCharImageSkinResourceInfo(configDataLoader, charSkinId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCharImageSkinResourceInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AF1 RID: 97009 RVA: 0x0068277C File Offset: 0x0068097C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroModelSkinResourceInfo_s(IntPtr l)
	{
		int result;
		try
		{
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 1, out configDataLoader);
			int heroSkinId;
			LuaObject.checkType(l, 2, out heroSkinId);
			int activeJobRelatedId;
			LuaObject.checkType(l, 3, out activeJobRelatedId);
			ConfigDataModelSkinResourceInfo heroModelSkinResourceInfo = BattleUtility.GetHeroModelSkinResourceInfo(configDataLoader, heroSkinId, activeJobRelatedId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroModelSkinResourceInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AF2 RID: 97010 RVA: 0x006827EC File Offset: 0x006809EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSoldierModelSkinResourceInfo_s(IntPtr l)
	{
		int result;
		try
		{
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 1, out configDataLoader);
			int soldierSkinId;
			LuaObject.checkType(l, 2, out soldierSkinId);
			int soldierId;
			LuaObject.checkType(l, 3, out soldierId);
			ConfigDataModelSkinResourceInfo soldierModelSkinResourceInfo = BattleUtility.GetSoldierModelSkinResourceInfo(configDataLoader, soldierSkinId, soldierId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierModelSkinResourceInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AF3 RID: 97011 RVA: 0x0068285C File Offset: 0x00680A5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ModifyClimbTowerBattleTeamSetups_s(IntPtr l)
	{
		int result;
		try
		{
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 1, out configDataLoader);
			int floorId;
			LuaObject.checkType(l, 2, out floorId);
			int bonusHeroGroupId;
			LuaObject.checkType(l, 3, out bonusHeroGroupId);
			int battleRuleId;
			LuaObject.checkType(l, 4, out battleRuleId);
			BattleTeamSetup mineTime;
			LuaObject.checkType<BattleTeamSetup>(l, 5, out mineTime);
			BattleTeamSetup opponentTeam;
			LuaObject.checkType<BattleTeamSetup>(l, 6, out opponentTeam);
			BattleUtility.ModifyClimbTowerBattleTeamSetups(configDataLoader, floorId, bonusHeroGroupId, battleRuleId, mineTime, opponentTeam);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AF4 RID: 97012 RVA: 0x006828E4 File Offset: 0x00680AE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ModifyGuildMassiveCombatBattleTeamSetups_s(IntPtr l)
	{
		int result;
		try
		{
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 1, out configDataLoader);
			int strongholdId;
			LuaObject.checkType(l, 2, out strongholdId);
			List<int> preferredHeroTagIds;
			LuaObject.checkType<List<int>>(l, 3, out preferredHeroTagIds);
			BattleTeamSetup mineTime;
			LuaObject.checkType<BattleTeamSetup>(l, 4, out mineTime);
			BattleUtility.ModifyGuildMassiveCombatBattleTeamSetups(configDataLoader, strongholdId, preferredHeroTagIds, mineTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AF5 RID: 97013 RVA: 0x00682954 File Offset: 0x00680B54
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.BattleUtility");
		if (Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleUtility.CreateDefaultConfigBattleHero_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleUtility.CreateBattleActorSetupFromBattleHero_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleUtility.CreatePveMyBattleActorSetup_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleUtility.CreateArenaBattleActorSetup_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleUtility.CreatePvpBattleActorSetup_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleUtility.CreateRealtimePvpBattleActorSetup_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleUtility.AppendPveMyNpcBattleActorSetups_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleUtility.AppendPveOpponentBattleActorSetups_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleUtility.GetRandomBattleArmyActors_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleUtility.GetRandomTalentSkillId_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleUtility.GetRandomTalentSkills_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleUtility.GetEquipmentResonanceSkillInfos_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleUtility.GetTrainingTechSoldierSkillInfos_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleUtility.GetTrainingTechSummonSkills_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleUtility.CreateBattlePlayer_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleUtility.GetHeroCharImageSkinResourceInfo_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleUtility.GetHeroModelSkinResourceInfo_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleUtility.GetSoldierModelSkinResourceInfo_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleUtility.ModifyClimbTowerBattleTeamSetups_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleUtility.ModifyGuildMassiveCombatBattleTeamSetups_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleUtility.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_BattleUtility.<>f__mg$cache14, typeof(BattleUtility));
	}

	// Token: 0x0400E11A RID: 57626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E11B RID: 57627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E11C RID: 57628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E11D RID: 57629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E11E RID: 57630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E11F RID: 57631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E120 RID: 57632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E121 RID: 57633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E122 RID: 57634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E123 RID: 57635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E124 RID: 57636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E125 RID: 57637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E126 RID: 57638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E127 RID: 57639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E128 RID: 57640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E129 RID: 57641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E12A RID: 57642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E12B RID: 57643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E12C RID: 57644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E12D RID: 57645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E12E RID: 57646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;
}
