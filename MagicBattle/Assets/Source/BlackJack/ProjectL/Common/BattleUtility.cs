using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020003E1 RID: 993
	[CustomLuaClass]
	public class BattleUtility
	{
		// Token: 0x06003B15 RID: 15125 RVA: 0x0010D7B0 File Offset: 0x0010B9B0
		public static BattleHero CreateDefaultConfigBattleHero(ConfigDataHeroInfo heroInfo)
		{
			if (heroInfo == null)
			{
				return null;
			}
			BattleHero battleHero = new BattleHero();
			battleHero.HeroId = heroInfo.ID;
			battleHero.ActiveHeroJobRelatedId = heroInfo.JobConnection_ID;
			battleHero.Level = 1;
			battleHero.StarLevel = heroInfo.Star;
			BattleHeroJob battleHeroJob = new BattleHeroJob();
			battleHeroJob.JobRelatedId = heroInfo.JobConnection_ID;
			battleHeroJob.JobLevel = 0;
			battleHero.Jobs.Add(battleHeroJob);
			battleHero.SelectedSoldierId = heroInfo.Soldier_ID;
			int num = 0;
			while (num < heroInfo.Skills_ID.Count && num < 3)
			{
				battleHero.SelectedSkillList.Add(heroInfo.Skills_ID[num]);
				num++;
			}
			return battleHero;
		}

		// Token: 0x06003B16 RID: 15126 RVA: 0x0010D864 File Offset: 0x0010BA64
		public static BattleActorSetup CreateBattleActorSetupFromBattleHero(IConfigDataLoader configDataLoader, BattleHero hero, int level = 0, int behaviorId = -1, int groupId = 0)
		{
			BattleActorSetup battleActorSetup = new BattleActorSetup();
			battleActorSetup.HeroInfo = configDataLoader.GetConfigDataHeroInfo(hero.HeroId);
			battleActorSetup.JobConnectionInfo = configDataLoader.GetConfigDataJobConnectionInfo(hero.ActiveHeroJobRelatedId);
			battleActorSetup.SoldierInfo = configDataLoader.GetConfigDataSoldierInfo(hero.SelectedSoldierId);
			battleActorSetup.HeroStar = hero.StarLevel;
			battleActorSetup.JobLevel = hero.GetJob(hero.ActiveHeroJobRelatedId).JobLevel;
			battleActorSetup.SoldierCount = configDataLoader.Const_SoldierCountMax;
			battleActorSetup.ActionValue = hero.ActionValue;
			battleActorSetup.BehaviorId = behaviorId;
			battleActorSetup.GroupId = groupId;
			battleActorSetup.PlayerIndex = -1;
			if (level > 0)
			{
				battleActorSetup.HeroLevel = level;
			}
			else
			{
				battleActorSetup.HeroLevel = hero.Level;
			}
			if (hero.SelectedSkillList.Count > 0)
			{
				List<ConfigDataSkillInfo> list = new List<ConfigDataSkillInfo>();
				foreach (int key in hero.SelectedSkillList)
				{
					ConfigDataSkillInfo configDataSkillInfo = configDataLoader.GetConfigDataSkillInfo(key);
					if (configDataSkillInfo != null)
					{
						list.Add(configDataSkillInfo);
					}
				}
				if (list.Count > 0)
				{
					battleActorSetup.SkillInfos = list.ToArray();
				}
			}
			if (hero.Jobs.Count > 0)
			{
				List<ConfigDataJobInfo> list2 = new List<ConfigDataJobInfo>();
				foreach (BattleHeroJob battleHeroJob in hero.Jobs)
				{
					ConfigDataJobConnectionInfo configDataJobConnectionInfo = configDataLoader.GetConfigDataJobConnectionInfo(battleHeroJob.JobRelatedId);
					if (configDataJobConnectionInfo.IsJobLevelMax(battleHeroJob.JobLevel))
					{
						list2.Add(configDataJobConnectionInfo.m_jobInfo);
					}
				}
				if (list2.Count > 0)
				{
					battleActorSetup.MasterJobInfos = list2.ToArray();
				}
			}
			if (hero.Fetters.Count > 0)
			{
				List<ConfigDataSkillInfo> list3 = new List<ConfigDataSkillInfo>();
				foreach (KeyValuePair<int, int> keyValuePair in hero.Fetters)
				{
					ConfigDataHeroFetterInfo configDataHeroFetterInfo = configDataLoader.GetConfigDataHeroFetterInfo(keyValuePair.Key);
					if (configDataHeroFetterInfo != null)
					{
						int num = keyValuePair.Value - 1;
						if (num < configDataHeroFetterInfo.GotSkills_ID.Count)
						{
							ConfigDataSkillInfo configDataSkillInfo2 = configDataLoader.GetConfigDataSkillInfo(configDataHeroFetterInfo.GotSkills_ID[num]);
							if (configDataSkillInfo2 != null)
							{
								list3.Add(configDataSkillInfo2);
							}
						}
					}
				}
				if (list3.Count > 0)
				{
					battleActorSetup.FetterSkillInfos = list3.ToArray();
				}
			}
			if (hero.Equipments.Count > 0)
			{
				List<BattleActorEquipment> list4 = new List<BattleActorEquipment>();
				foreach (BattleHeroEquipment battleHeroEquipment in hero.Equipments)
				{
					ConfigDataEquipmentInfo configDataEquipmentInfo = configDataLoader.GetConfigDataEquipmentInfo(battleHeroEquipment.Id);
					if (configDataEquipmentInfo != null)
					{
						BattleActorEquipment battleActorEquipment = new BattleActorEquipment();
						battleActorEquipment.EquipmentInfo = configDataEquipmentInfo;
						battleActorEquipment.Level = battleHeroEquipment.Level;
						if (battleHeroEquipment.EnchantProperties.Count > 0)
						{
							battleActorEquipment.EnchantProperties = new CommonBattleProperty[battleHeroEquipment.EnchantProperties.Count];
							for (int i = 0; i < battleHeroEquipment.EnchantProperties.Count; i++)
							{
								battleActorEquipment.EnchantProperties[i] = battleHeroEquipment.EnchantProperties[i];
							}
						}
						list4.Add(battleActorEquipment);
					}
				}
				if (list4.Count > 0)
				{
					battleActorSetup.Equipments = list4.ToArray();
				}
				List<ConfigDataSkillInfo> equipmentResonanceSkillInfos = BattleUtility.GetEquipmentResonanceSkillInfos(configDataLoader, hero.Equipments);
				if (equipmentResonanceSkillInfos.Count > 0)
				{
					battleActorSetup.ResonanceSkillInfos = equipmentResonanceSkillInfos.ToArray();
				}
			}
			battleActorSetup.HeroCharImageSkinResourceInfo = hero.GetHeroCharImageSkinResourceInfo(configDataLoader);
			battleActorSetup.HeroModelSkinResourceInfo = hero.GetHeroActiveJobModelSkinResourceInfo(configDataLoader);
			battleActorSetup.SoldierModelSkinResourceInfo = hero.GetSelectedSoldierModelSkinResourceInfo(configDataLoader);
			return battleActorSetup;
		}

		// Token: 0x06003B17 RID: 15127 RVA: 0x0010DC90 File Offset: 0x0010BE90
		public static BattleActorSetup CreatePveMyBattleActorSetup(IConfigDataLoader configDataLoader, ConfigDataBattleInfo battleInfo, int position, BattleHero hero)
		{
			BattleActorSetup battleActorSetup = BattleUtility.CreateBattleActorSetupFromBattleHero(configDataLoader, hero, 0, -1, 0);
			battleActorSetup.Position.x = battleInfo.AllyPositions[position].X;
			battleActorSetup.Position.y = battleInfo.AllyPositions[position].Y;
			battleActorSetup.Direction = 0;
			if (battleInfo.AllyDirs.Count > position)
			{
				battleActorSetup.Direction = battleInfo.AllyDirs[position];
			}
			battleActorSetup.IsNpc = false;
			return battleActorSetup;
		}

		// Token: 0x06003B18 RID: 15128 RVA: 0x0010DD14 File Offset: 0x0010BF14
		public static BattleActorSetup CreateArenaBattleActorSetup(IConfigDataLoader configDataLoader, int team, ConfigDataArenaBattleInfo battleInfo, int position, BattleHero hero)
		{
			BattleActorSetup battleActorSetup = BattleUtility.CreateBattleActorSetupFromBattleHero(configDataLoader, hero, 0, -1, 0);
			if (team == 0)
			{
				battleActorSetup.Position.x = battleInfo.AttackPositions[position].X;
				battleActorSetup.Position.y = battleInfo.AttackPositions[position].Y;
				if (battleInfo.AttackDirs.Count > position)
				{
					battleActorSetup.Direction = battleInfo.AttackDirs[position];
				}
			}
			else
			{
				if (team != 1)
				{
					return null;
				}
				battleActorSetup.Position.x = battleInfo.DefendPositions[position].X;
				battleActorSetup.Position.y = battleInfo.DefendPositions[position].Y;
				if (battleInfo.DefendDirs.Count > position)
				{
					battleActorSetup.Direction = battleInfo.DefendDirs[position];
				}
			}
			battleActorSetup.IsNpc = false;
			return battleActorSetup;
		}

		// Token: 0x06003B19 RID: 15129 RVA: 0x0010DE04 File Offset: 0x0010C004
		public static BattleActorSetup CreatePvpBattleActorSetup(IConfigDataLoader configDataLoader, int team, ConfigDataPVPBattleInfo battleInfo, int position, BattleHero hero)
		{
			BattleActorSetup battleActorSetup = BattleUtility.CreateBattleActorSetupFromBattleHero(configDataLoader, hero, 0, -1, 0);
			if (team == 0)
			{
				battleActorSetup.Position.x = battleInfo.AttackPositions[position].X;
				battleActorSetup.Position.y = battleInfo.AttackPositions[position].Y;
				if (battleInfo.AttackDirs.Count > position)
				{
					battleActorSetup.Direction = battleInfo.AttackDirs[position];
				}
			}
			else
			{
				if (team != 1)
				{
					return null;
				}
				battleActorSetup.Position.x = battleInfo.DefendPositions[position].X;
				battleActorSetup.Position.y = battleInfo.DefendPositions[position].Y;
				if (battleInfo.DefendDirs.Count > position)
				{
					battleActorSetup.Direction = battleInfo.DefendDirs[position];
				}
			}
			battleActorSetup.IsNpc = false;
			return battleActorSetup;
		}

		// Token: 0x06003B1A RID: 15130 RVA: 0x0010DEF4 File Offset: 0x0010C0F4
		public static BattleActorSetup CreateRealtimePvpBattleActorSetup(IConfigDataLoader configDataLoader, int team, ConfigDataRealTimePVPBattleInfo battleInfo, int position, BattleHero hero)
		{
			BattleActorSetup battleActorSetup = BattleUtility.CreateBattleActorSetupFromBattleHero(configDataLoader, hero, 0, -1, 0);
			if (team == 0)
			{
				battleActorSetup.Position.x = battleInfo.AttackPositions[position].X;
				battleActorSetup.Position.y = battleInfo.AttackPositions[position].Y;
				if (battleInfo.AttackDirs.Count > position)
				{
					battleActorSetup.Direction = battleInfo.AttackDirs[position];
				}
			}
			else
			{
				if (team != 1)
				{
					return null;
				}
				battleActorSetup.Position.x = battleInfo.DefendPositions[position].X;
				battleActorSetup.Position.y = battleInfo.DefendPositions[position].Y;
				if (battleInfo.DefendDirs.Count > position)
				{
					battleActorSetup.Direction = battleInfo.DefendDirs[position];
				}
			}
			battleActorSetup.IsNpc = false;
			return battleActorSetup;
		}

		// Token: 0x06003B1B RID: 15131 RVA: 0x0010DFE4 File Offset: 0x0010C1E4
		public static int AppendPveMyNpcBattleActorSetups(IConfigDataLoader configDataLoader, ConfigDataBattleInfo battleInfo, int monsterLevel, List<BattleActorSetup> actors)
		{
			for (int i = 0; i < battleInfo.NpcActors.Count; i++)
			{
				BattlePosActor battlePosActor = battleInfo.NpcActors[i];
				int id = battlePosActor.ID;
				int num = battlePosActor.Level;
				int behaviorId = 0;
				if (battleInfo.NpcActorsBehavior.Count > i)
				{
					behaviorId = battleInfo.NpcActorsBehavior[i];
				}
				int groupId = 0;
				if (battleInfo.NpcGroups.Count > i)
				{
					groupId = battleInfo.NpcGroups[i];
				}
				if (num == 0)
				{
					num = monsterLevel;
				}
				ConfigDataHeroInfo configDataHeroInfo = configDataLoader.GetConfigDataHeroInfo(id);
				if (configDataHeroInfo == null)
				{
					return -618;
				}
				BattleHero hero = BattleUtility.CreateDefaultConfigBattleHero(configDataHeroInfo);
				BattleActorSetup battleActorSetup = BattleUtility.CreateBattleActorSetupFromBattleHero(configDataLoader, hero, num, behaviorId, groupId);
				battleActorSetup.Position.x = battlePosActor.X;
				battleActorSetup.Position.y = battlePosActor.Y;
				battleActorSetup.Direction = 0;
				if (battleInfo.NpcDirs.Count > i)
				{
					battleActorSetup.Direction = battleInfo.NpcDirs[i];
				}
				battleActorSetup.IsNpc = true;
				actors.Add(battleActorSetup);
			}
			return 0;
		}

		// Token: 0x06003B1C RID: 15132 RVA: 0x0010E104 File Offset: 0x0010C304
		public static int AppendPveOpponentBattleActorSetups(IConfigDataLoader configDataLoader, ConfigDataBattleInfo battleInfo, int monsterLevel, int randomSeed, List<BattleActorSetup> actors)
		{
			List<RandomArmyActor> list = null;
			if (battleInfo.BattleRandomEnemies_ID.Count > 0)
			{
				RandomNumber randomNumber = new RandomNumber();
				randomNumber.SetSeed(randomSeed);
				int randomBattleArmyActors = BattleUtility.GetRandomBattleArmyActors(configDataLoader, battleInfo.BattleRandomEnemies_ID, randomNumber, out list);
				if (randomBattleArmyActors != 0)
				{
					return randomBattleArmyActors;
				}
			}
			List<ConfigDataSkillInfo> list2 = null;
			if (battleInfo.EnemyRandomTalentProbilities.Count > 0)
			{
				RandomNumber randomNumber2 = new RandomNumber();
				randomNumber2.SetSeed(randomSeed);
				BattleUtility.GetRandomTalentSkills(configDataLoader, battleInfo.EnemyRandomTalent_ID, battleInfo.EnemyRandomTalentProbilities, randomNumber2, out list2);
			}
			for (int i = 0; i < battleInfo.EnemyActors.Count; i++)
			{
				BattlePosActor battlePosActor = battleInfo.EnemyActors[i];
				int key = battlePosActor.ID;
				int num = battlePosActor.Level;
				int behaviorId = 0;
				if (battleInfo.EnemyActorsBehavior.Count > i)
				{
					behaviorId = battleInfo.EnemyActorsBehavior[i];
				}
				int groupId = 0;
				if (battleInfo.EnemyGroups.Count > i)
				{
					groupId = battleInfo.EnemyGroups[i];
				}
				if (list != null && i < list.Count && list[i] != null)
				{
					key = list[i].HeroID;
					num = list[i].Level;
					behaviorId = list[i].AI;
				}
				if (num == 0)
				{
					num = monsterLevel;
				}
				ConfigDataHeroInfo configDataHeroInfo = configDataLoader.GetConfigDataHeroInfo(key);
				if (configDataHeroInfo == null)
				{
					return -618;
				}
				BattleHero hero = BattleUtility.CreateDefaultConfigBattleHero(configDataHeroInfo);
				BattleActorSetup battleActorSetup = BattleUtility.CreateBattleActorSetupFromBattleHero(configDataLoader, hero, num, behaviorId, groupId);
				battleActorSetup.Position.x = battlePosActor.X;
				battleActorSetup.Position.y = battlePosActor.Y;
				battleActorSetup.Direction = 0;
				if (battleInfo.EnemyDirs.Count > i)
				{
					battleActorSetup.Direction = battleInfo.EnemyDirs[i];
				}
				battleActorSetup.IsNpc = false;
				if (list2 != null && i < list2.Count)
				{
					battleActorSetup.ExtraTalentSkillInfo = list2[i];
				}
				actors.Add(battleActorSetup);
			}
			return 0;
		}

		// Token: 0x06003B1D RID: 15133 RVA: 0x0010E31C File Offset: 0x0010C51C
		public static int GetRandomBattleArmyActors(IConfigDataLoader configDataLoader, List<int> randomArmies, RandomNumber randomNumber, out List<RandomArmyActor> actors)
		{
			actors = new List<RandomArmyActor>();
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (int key in randomArmies)
			{
				ConfigDataBattleRandomArmyInfo configDataBattleRandomArmyInfo = configDataLoader.GetConfigDataBattleRandomArmyInfo(key);
				if (configDataBattleRandomArmyInfo == null)
				{
					return -919;
				}
				for (int i = 0; i < configDataBattleRandomArmyInfo.RandomArmyActors.Count; i++)
				{
					dictionary.Add(i, configDataBattleRandomArmyInfo.RandomArmyActors[i].Weight);
				}
				int randomNumberByAccumulateWeight = randomNumber.GetRandomNumberByAccumulateWeight(dictionary);
				if (randomNumberByAccumulateWeight == -2147483648)
				{
					return -920;
				}
				actors.Add(configDataBattleRandomArmyInfo.RandomArmyActors[randomNumberByAccumulateWeight]);
				dictionary.Clear();
			}
			return 0;
		}

		// Token: 0x06003B1E RID: 15134 RVA: 0x0010E40C File Offset: 0x0010C60C
		public static int GetRandomTalentSkillId(IConfigDataLoader configDataLoader, RandomNumber randomNumber, int randomTalentId)
		{
			ConfigDataBattleRandomTalentInfo configDataBattleRandomTalentInfo = configDataLoader.GetConfigDataBattleRandomTalentInfo(randomTalentId);
			if (configDataBattleRandomTalentInfo == null)
			{
				return 0;
			}
			int num = 0;
			foreach (RandomTalent randomTalent in configDataBattleRandomTalentInfo.RandomTalents)
			{
				num += randomTalent.Weight;
			}
			int num2 = randomNumber.Next(0, num);
			int num3 = 0;
			foreach (RandomTalent randomTalent2 in configDataBattleRandomTalentInfo.RandomTalents)
			{
				num3 += randomTalent2.Weight;
				if (num3 >= num2)
				{
					return randomTalent2.SkillId;
				}
			}
			return 0;
		}

		// Token: 0x06003B1F RID: 15135 RVA: 0x0010E4F8 File Offset: 0x0010C6F8
		public static void GetRandomTalentSkills(IConfigDataLoader configDataLoader, int randomTalentId, List<int> randomTalentProbilities, RandomNumber randomNumber, out List<ConfigDataSkillInfo> actorTalentSkillInfos)
		{
			actorTalentSkillInfos = new List<ConfigDataSkillInfo>();
			int randomTalentSkillId = BattleUtility.GetRandomTalentSkillId(configDataLoader, randomNumber, randomTalentId);
			ConfigDataSkillInfo configDataSkillInfo = configDataLoader.GetConfigDataSkillInfo(randomTalentSkillId);
			if (configDataSkillInfo == null)
			{
				return;
			}
			foreach (int num in randomTalentProbilities)
			{
				if (randomNumber.Next(0, 10000) < num)
				{
					actorTalentSkillInfos.Add(configDataSkillInfo);
				}
				else
				{
					actorTalentSkillInfos.Add(null);
				}
			}
		}

		// Token: 0x06003B20 RID: 15136 RVA: 0x0010E594 File Offset: 0x0010C794
		public static List<ConfigDataSkillInfo> GetEquipmentResonanceSkillInfos(IConfigDataLoader configDataLoader, List<BattleHeroEquipment> equipments)
		{
			List<ConfigDataSkillInfo> list = new List<ConfigDataSkillInfo>();
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (BattleHeroEquipment battleHeroEquipment in equipments)
			{
				if (battleHeroEquipment.ResonanceId != 0)
				{
					int num;
					if (dictionary.TryGetValue(battleHeroEquipment.ResonanceId, out num))
					{
						dictionary[battleHeroEquipment.ResonanceId] = num + 1;
					}
					else
					{
						dictionary.Add(battleHeroEquipment.ResonanceId, 1);
					}
				}
			}
			foreach (KeyValuePair<int, int> keyValuePair in dictionary)
			{
				ConfigDataResonanceInfo configDataResonanceInfo = configDataLoader.GetConfigDataResonanceInfo(keyValuePair.Key);
				if (configDataResonanceInfo != null)
				{
					if (keyValuePair.Value >= 2)
					{
						ConfigDataSkillInfo configDataSkillInfo = configDataLoader.GetConfigDataSkillInfo(configDataResonanceInfo.Effect1);
						if (configDataSkillInfo != null)
						{
							list.Add(configDataSkillInfo);
						}
					}
					if (keyValuePair.Value >= 4)
					{
						ConfigDataSkillInfo configDataSkillInfo2 = configDataLoader.GetConfigDataSkillInfo(configDataResonanceInfo.Effect2);
						if (configDataSkillInfo2 != null)
						{
							list.Add(configDataSkillInfo2);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06003B21 RID: 15137 RVA: 0x0010E6E8 File Offset: 0x0010C8E8
		public static List<ConfigDataSkillInfo> GetTrainingTechSoldierSkillInfos(IConfigDataLoader configDataLoader, List<TrainingTech> techs, ConfigDataSoldierInfo soldierInfo, out int soldierSkillLevelUp)
		{
			List<ConfigDataSkillInfo> list = new List<ConfigDataSkillInfo>();
			soldierSkillLevelUp = 0;
			if (techs == null || soldierInfo == null)
			{
				return list;
			}
			foreach (TrainingTech trainingTech in techs)
			{
				if (trainingTech.ConfigDataLoader == null)
				{
					trainingTech.ConfigDataLoader = configDataLoader;
				}
				if (trainingTech.Config != null)
				{
					ConfigDataTrainingTechInfo config = trainingTech.Config;
					if (!config.IsSummon)
					{
						if (config.SoldierIDRelated.Contains(soldierInfo.ID) || config.ArmyIDRelated.Contains(soldierInfo.Army_ID))
						{
							int num = 0;
							int num2 = 0;
							while (num2 < trainingTech.Level && num2 < trainingTech.Infos.Count)
							{
								ConfigDataTrainingTechLevelInfo config2 = trainingTech.Infos[num2].Config;
								if (config2.SoldierSkillID != 0)
								{
									num = config2.SoldierSkillID;
								}
								if (config2.SoldierSkillLevelup > soldierSkillLevelUp)
								{
									soldierSkillLevelUp = config2.SoldierSkillLevelup;
								}
								num2++;
							}
							if (num != 0)
							{
								ConfigDataSkillInfo configDataSkillInfo = configDataLoader.GetConfigDataSkillInfo(num);
								if (configDataSkillInfo != null)
								{
									list.Add(configDataSkillInfo);
								}
							}
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06003B22 RID: 15138 RVA: 0x0010E854 File Offset: 0x0010CA54
		public static List<ConfigDataSkillInfo> GetTrainingTechSummonSkills(IConfigDataLoader configDataLoader, List<TrainingTech> techs, ConfigDataHeroInfo heroInfo)
		{
			List<ConfigDataSkillInfo> list = new List<ConfigDataSkillInfo>();
			if (techs == null || heroInfo == null)
			{
				return list;
			}
			foreach (TrainingTech trainingTech in techs)
			{
				if (trainingTech.ConfigDataLoader == null)
				{
					trainingTech.ConfigDataLoader = configDataLoader;
				}
				if (trainingTech.Config != null)
				{
					ConfigDataTrainingTechInfo config = trainingTech.Config;
					if (config.IsSummon)
					{
						if (config.SoldierIDRelated.Contains(heroInfo.ID) || config.ArmyIDRelated.Contains(heroInfo.m_jobConnectionInfo.m_jobInfo.Army_ID))
						{
							int num = 0;
							int num2 = 0;
							while (num2 < trainingTech.Level && num2 < trainingTech.Infos.Count)
							{
								ConfigDataTrainingTechLevelInfo config2 = trainingTech.Infos[num2].Config;
								if (config2.SoldierSkillID != 0)
								{
									num = config2.SoldierSkillID;
								}
								num2++;
							}
							if (num != 0)
							{
								ConfigDataSkillInfo configDataSkillInfo = configDataLoader.GetConfigDataSkillInfo(num);
								if (configDataSkillInfo != null)
								{
									list.Add(configDataSkillInfo);
								}
							}
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06003B23 RID: 15139 RVA: 0x0010E9B0 File Offset: 0x0010CBB0
		public static BattlePlayer CreateBattlePlayer(IConfigDataLoader configDataLoader, int playerLevel, List<TrainingTech> techs, ulong sessionId)
		{
			BattlePlayer battlePlayer = new BattlePlayer();
			battlePlayer.SessionId = sessionId;
			battlePlayer.PlayerLevel = playerLevel;
			if (techs != null && techs.Count > 0)
			{
				List<BattlePlayerTrainingTech> list = new List<BattlePlayerTrainingTech>();
				foreach (TrainingTech trainingTech in techs)
				{
					if (trainingTech.ConfigDataLoader == null)
					{
						trainingTech.ConfigDataLoader = configDataLoader;
					}
					if (trainingTech.Config != null)
					{
						list.Add(new BattlePlayerTrainingTech
						{
							TrainingTechInfo = trainingTech.Config,
							Level = trainingTech.Level
						});
					}
				}
				if (list.Count > 0)
				{
					List<BattlePlayerTrainingTech> list2 = list;
					if (BattleUtility.<>f__mg$cache0 == null)
					{
						BattleUtility.<>f__mg$cache0 = new Comparison<BattlePlayerTrainingTech>(BattleUtility.CompareTrainingTechById);
					}
					list2.Sort(BattleUtility.<>f__mg$cache0);
					battlePlayer.TrainingTechs = list.ToArray();
				}
			}
			return battlePlayer;
		}

		// Token: 0x06003B24 RID: 15140 RVA: 0x0010EAB4 File Offset: 0x0010CCB4
		private static int CompareTrainingTechById(BattlePlayerTrainingTech t1, BattlePlayerTrainingTech t2)
		{
			return t1.TrainingTechInfo.ID - t2.TrainingTechInfo.ID;
		}

		// Token: 0x06003B25 RID: 15141 RVA: 0x0010EAD0 File Offset: 0x0010CCD0
		public static ConfigDataCharImageSkinResourceInfo GetHeroCharImageSkinResourceInfo(IConfigDataLoader configDataLoader, int charSkinId)
		{
			if (charSkinId == 0)
			{
				return null;
			}
			ConfigDataHeroSkinInfo configDataHeroSkinInfo = configDataLoader.GetConfigDataHeroSkinInfo(charSkinId);
			if (configDataHeroSkinInfo != null)
			{
				return configDataLoader.GetConfigDataCharImageSkinResourceInfo(configDataHeroSkinInfo.CharImageSkinResource_ID);
			}
			return null;
		}

		// Token: 0x06003B26 RID: 15142 RVA: 0x0010EB04 File Offset: 0x0010CD04
		public static ConfigDataModelSkinResourceInfo GetHeroModelSkinResourceInfo(IConfigDataLoader configDataLoader, int heroSkinId, int activeJobRelatedId)
		{
			if (heroSkinId == 0)
			{
				return null;
			}
			ConfigDataHeroSkinInfo configDataHeroSkinInfo = configDataLoader.GetConfigDataHeroSkinInfo(heroSkinId);
			if (configDataHeroSkinInfo != null)
			{
				foreach (JobConnection2SkinResource jobConnection2SkinResource in configDataHeroSkinInfo.SpecifiedModelSkinResource)
				{
					if (jobConnection2SkinResource.JobConnectionId == activeJobRelatedId)
					{
						return configDataLoader.GetConfigDataModelSkinResourceInfo(jobConnection2SkinResource.SkinResourceId);
					}
				}
			}
			return null;
		}

		// Token: 0x06003B27 RID: 15143 RVA: 0x0010EB90 File Offset: 0x0010CD90
		public static ConfigDataModelSkinResourceInfo GetSoldierModelSkinResourceInfo(IConfigDataLoader configDataLoader, int soldierSkinId, int soldierId)
		{
			if (soldierSkinId == 0)
			{
				return null;
			}
			ConfigDataSoldierSkinInfo configDataSoldierSkinInfo = configDataLoader.GetConfigDataSoldierSkinInfo(soldierSkinId);
			if (configDataSoldierSkinInfo != null)
			{
				foreach (Soldier2SkinResource soldier2SkinResource in configDataSoldierSkinInfo.SpecifiedSoldier)
				{
					if (soldier2SkinResource.SoldierId == soldierId)
					{
						return configDataLoader.GetConfigDataModelSkinResourceInfo(soldier2SkinResource.SkinResourceId);
					}
				}
			}
			return null;
		}

		// Token: 0x06003B28 RID: 15144 RVA: 0x0010EC1C File Offset: 0x0010CE1C
		public static void ModifyClimbTowerBattleTeamSetups(IConfigDataLoader configDataLoader, int floorId, int bonusHeroGroupId, int battleRuleId, BattleTeamSetup mineTime, BattleTeamSetup opponentTeam)
		{
			ConfigDataTowerFloorInfo configDataTowerFloorInfo = configDataLoader.GetConfigDataTowerFloorInfo(floorId);
			if (configDataTowerFloorInfo == null)
			{
				return;
			}
			ConfigDataTowerBonusHeroGroupInfo configDataTowerBonusHeroGroupInfo = configDataLoader.GetConfigDataTowerBonusHeroGroupInfo(bonusHeroGroupId);
			if (configDataTowerBonusHeroGroupInfo != null)
			{
				ConfigDataSkillInfo configDataSkillInfo = configDataLoader.GetConfigDataSkillInfo(configDataTowerFloorInfo.BonusSkill_ID);
				if (configDataSkillInfo != null)
				{
					foreach (BattleActorSetup battleActorSetup in mineTime.m_actors)
					{
						if (configDataTowerBonusHeroGroupInfo.BonusHeroIdList.Contains(battleActorSetup.HeroInfo.ID))
						{
							BattleUtility.AppendExtraSkillToBattleActorSetup(configDataSkillInfo, battleActorSetup);
						}
					}
				}
			}
			ConfigDataTowerBattleRuleInfo configDataTowerBattleRuleInfo = configDataLoader.GetConfigDataTowerBattleRuleInfo(battleRuleId);
			if (configDataTowerBattleRuleInfo != null)
			{
				ConfigDataSkillInfo configDataSkillInfo2 = configDataLoader.GetConfigDataSkillInfo(configDataTowerBattleRuleInfo.Skill_ID);
				if (configDataSkillInfo2 != null)
				{
					if (configDataTowerBattleRuleInfo.Target == 1 || configDataTowerBattleRuleInfo.Target == 3)
					{
						foreach (BattleActorSetup a in opponentTeam.m_actors)
						{
							BattleUtility.AppendExtraSkillToBattleActorSetup(configDataSkillInfo2, a);
						}
					}
					if (configDataTowerBattleRuleInfo.Target == 2 || configDataTowerBattleRuleInfo.Target == 3)
					{
						foreach (BattleActorSetup a2 in mineTime.m_actors)
						{
							BattleUtility.AppendExtraSkillToBattleActorSetup(configDataSkillInfo2, a2);
						}
					}
				}
			}
		}

		// Token: 0x06003B29 RID: 15145 RVA: 0x0010EDC0 File Offset: 0x0010CFC0
		public static void ModifyGuildMassiveCombatBattleTeamSetups(IConfigDataLoader configDataLoader, int strongholdId, List<int> preferredHeroTagIds, BattleTeamSetup mineTime)
		{
			ConfigDataGuildMassiveCombatStrongholdInfo configDataGuildMassiveCombatStrongholdInfo = configDataLoader.GetConfigDataGuildMassiveCombatStrongholdInfo(strongholdId);
			if (configDataGuildMassiveCombatStrongholdInfo == null)
			{
				return;
			}
			if (preferredHeroTagIds == null)
			{
				return;
			}
			ConfigDataSkillInfo configDataSkillInfo = configDataLoader.GetConfigDataSkillInfo(configDataGuildMassiveCombatStrongholdInfo.UpSkill_ID);
			if (configDataSkillInfo != null)
			{
				foreach (BattleActorSetup battleActorSetup in mineTime.m_actors)
				{
					foreach (int item in preferredHeroTagIds)
					{
						if (battleActorSetup.HeroInfo.m_heroTagIds.Contains(item))
						{
							BattleUtility.AppendExtraSkillToBattleActorSetup(configDataSkillInfo, battleActorSetup);
							break;
						}
					}
				}
			}
		}

		// Token: 0x06003B2A RID: 15146 RVA: 0x0010EEA4 File Offset: 0x0010D0A4
		private static void AppendExtraSkillToBattleActorSetup(ConfigDataSkillInfo skillInfo, BattleActorSetup a)
		{
			if (skillInfo == null)
			{
				return;
			}
			if (a.ExtraPassiveSkillInfos == null)
			{
				a.ExtraPassiveSkillInfos = new List<ConfigDataSkillInfo>();
			}
			a.ExtraPassiveSkillInfos.Add(skillInfo);
		}

		// Token: 0x04002D0A RID: 11530
		[CompilerGenerated]
		private static Comparison<BattlePlayerTrainingTech> <>f__mg$cache0;
	}
}
