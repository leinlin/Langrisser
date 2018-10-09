using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E00 RID: 3584
	[HotFix]
	public class HeroPropertyComputer
	{
		// Token: 0x06011182 RID: 70018 RVA: 0x0046D9C0 File Offset: 0x0046BBC0
		public HeroPropertyComputer()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06011183 RID: 70019 RVA: 0x0046DA54 File Offset: 0x0046BC54
		public void Init(IConfigDataLoader configDataLoader)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitIConfigDataLoader_hotfix != null)
			{
				this.m_InitIConfigDataLoader_hotfix.call(new object[]
				{
					this,
					configDataLoader
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_configDataLoader = configDataLoader;
		}

		// Token: 0x06011184 RID: 70020 RVA: 0x0046DACC File Offset: 0x0046BCCC
		public void ComputeHeroProperties(Hero hero, int jobConnectionId, int heroLevel0 = -1, int heroLevel1 = -1, int starLevel0 = -1, int starLevel1 = -1, int jobLevel0 = -1, int jobLevel1 = -1)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeHeroPropertiesHeroInt32Int32Int32Int32Int32Int32Int32_hotfix != null)
			{
				this.m_ComputeHeroPropertiesHeroInt32Int32Int32Int32Int32Int32Int32_hotfix.call(new object[]
				{
					this,
					hero,
					jobConnectionId,
					heroLevel0,
					heroLevel1,
					starLevel0,
					starLevel1,
					jobLevel0,
					jobLevel1
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroJob job = hero.GetJob(jobConnectionId);
			if (heroLevel0 < 0)
			{
				heroLevel0 = hero.Level;
			}
			if (heroLevel1 < 0)
			{
				heroLevel1 = hero.Level;
			}
			if (starLevel0 < 0)
			{
				starLevel0 = hero.StarLevel;
			}
			if (starLevel1 < 0)
			{
				starLevel1 = hero.StarLevel;
			}
			if (jobLevel0 < 0)
			{
				jobLevel0 = job.JobLevel;
			}
			if (jobLevel1 < 0)
			{
				jobLevel1 = job.JobLevel;
			}
			this.m_propertyModifier.Clear();
			this.CollectJobMasterPropertyModifier(hero, jobConnectionId, job.JobLevel);
			this.CollectFetterPropertyModidier(hero.Fetters);
			this.CollectEquipmentPropertyModifier(hero);
			this.CollectSkinPropertyModifier(job.GetModelSkinResourceInfo());
			this.m_property0.ComputeHeroProperties(this.m_configDataLoader, hero.HeroInfo, job.JobConnectionInfo, jobLevel0, heroLevel0, starLevel0, this.m_propertyModifier);
			this.m_property1.ComputeHeroProperties(this.m_configDataLoader, hero.HeroInfo, job.JobConnectionInfo, jobLevel1, heroLevel1, starLevel1, this.m_propertyModifier);
		}

		// Token: 0x06011185 RID: 70021 RVA: 0x0046DC9C File Offset: 0x0046BE9C
		public void ComputeHeroJobLevelUpProperties(Hero hero, int jobConnectionId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeHeroJobLevelUpPropertiesHeroInt32_hotfix != null)
			{
				this.m_ComputeHeroJobLevelUpPropertiesHeroInt32_hotfix.call(new object[]
				{
					this,
					hero,
					jobConnectionId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroJob job = hero.GetJob(jobConnectionId);
			this.m_propertyModifier.Clear();
			this.CollectJobMasterPropertyModifier(hero, jobConnectionId, job.JobLevel);
			this.CollectFetterPropertyModidier(hero.Fetters);
			this.CollectEquipmentPropertyModifier(hero);
			this.CollectSkinPropertyModifier(job.GetModelSkinResourceInfo());
			this.m_property0.ComputeHeroProperties(this.m_configDataLoader, hero.HeroInfo, job.JobConnectionInfo, job.JobLevel, hero.Level, hero.StarLevel, this.m_propertyModifier);
			if (job.IsLevelMax())
			{
				this.m_property1.ComputeHeroProperties(this.m_configDataLoader, hero.HeroInfo, job.JobConnectionInfo, job.JobLevel, hero.Level, hero.StarLevel, this.m_propertyModifier);
			}
			else
			{
				this.m_propertyModifier.Clear();
				this.CollectJobMasterPropertyModifier(hero, jobConnectionId, job.JobLevel + 1);
				this.m_property1.ComputeHeroProperties(this.m_configDataLoader, hero.HeroInfo, job.JobConnectionInfo, job.JobLevel + 1, hero.Level, hero.StarLevel, this.m_propertyModifier);
			}
		}

		// Token: 0x06011186 RID: 70022 RVA: 0x0046DE28 File Offset: 0x0046C028
		public void ComputeHeroEquipmentProperties(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeHeroEquipmentPropertiesHero_hotfix != null)
			{
				this.m_ComputeHeroEquipmentPropertiesHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroJob activeJob = hero.GetActiveJob();
			this.m_propertyModifier.Clear();
			this.CollectJobMasterPropertyModifier(hero, activeJob.JobRelatedId, activeJob.JobLevel);
			this.CollectFetterPropertyModidier(hero.Fetters);
			this.CollectSkinPropertyModifier(activeJob.GetModelSkinResourceInfo());
			this.m_property0.ComputeHeroProperties(this.m_configDataLoader, hero.HeroInfo, activeJob.JobConnectionInfo, activeJob.JobLevel, hero.Level, hero.StarLevel, this.m_propertyModifier);
			this.CollectEquipmentPropertyModifier(hero);
			this.m_property1.ComputeHeroProperties(this.m_configDataLoader, hero.HeroInfo, activeJob.JobConnectionInfo, activeJob.JobLevel, hero.Level, hero.StarLevel, this.m_propertyModifier);
		}

		// Token: 0x06011187 RID: 70023 RVA: 0x0046DF48 File Offset: 0x0046C148
		public void ComputeSoldierCommandProperties(Hero hero, ConfigDataSoldierInfo soldierInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeSoldierCommandPropertiesHeroConfigDataSoldierInfo_hotfix != null)
			{
				this.m_ComputeSoldierCommandPropertiesHeroConfigDataSoldierInfo_hotfix.call(new object[]
				{
					this,
					hero,
					soldierInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			HeroJob activeJob = hero.GetActiveJob();
			this.m_propertyModifier.Clear();
			this.CollectJobMasterPropertyModifier(hero, activeJob.JobRelatedId, activeJob.JobLevel);
			this.CollectFetterPropertyModidier(hero.Fetters);
			this.CollectEquipmentPropertyModifier(hero);
			this.CollectSkinPropertyModifier(activeJob.GetModelSkinResourceInfo());
			this.CollectSkinPropertyModifier(hero.GetSoldierModelSkinResourceInfo(soldierInfo.ID));
			this.CollectSoldierPassiveSkillPropertyModifier(soldierInfo, projectLPlayerContext.GetTrainingGroundAvailableTechs());
			this.m_property0.ComputeSoldierProperties(this.m_configDataLoader, soldierInfo, null, hero.Level, this.m_propertyModifier);
			this.m_property1.ComputeSoldierProperties(this.m_configDataLoader, soldierInfo, hero.HeroInfo, hero.Level, this.m_propertyModifier);
		}

		// Token: 0x06011188 RID: 70024 RVA: 0x0046E080 File Offset: 0x0046C280
		public void ComputeSoldierCommandProperties(BattleHero hero, ConfigDataSoldierInfo soldierInfo, List<TrainingTech> techs, ConfigDataModelSkinResourceInfo soldierSkinResInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeSoldierCommandPropertiesBattleHeroConfigDataSoldierInfoList`1ConfigDataModelSkinResourceInfo_hotfix != null)
			{
				this.m_ComputeSoldierCommandPropertiesBattleHeroConfigDataSoldierInfoList`1ConfigDataModelSkinResourceInfo_hotfix.call(new object[]
				{
					this,
					hero,
					soldierInfo,
					techs,
					soldierSkinResInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_propertyModifier.Clear();
			this.CollectJobMasterPropertyModifier(hero);
			this.CollectFetterPropertyModidier(hero.Fetters);
			this.CollectEquipmentPropertyModifier(hero);
			this.CollectSkinPropertyModifier(hero.GetHeroActiveJobModelSkinResourceInfo(this.m_configDataLoader));
			this.CollectSkinPropertyModifier(soldierSkinResInfo);
			this.CollectSoldierPassiveSkillPropertyModifier(soldierInfo, techs);
			this.m_property0.ComputeSoldierProperties(this.m_configDataLoader, soldierInfo, null, hero.Level, this.m_propertyModifier);
			this.m_property1.ComputeSoldierProperties(this.m_configDataLoader, soldierInfo, hero.HeroInfo, hero.Level, this.m_propertyModifier);
		}

		// Token: 0x06011189 RID: 70025 RVA: 0x0046E1AC File Offset: 0x0046C3AC
		public void ComputeHeroBuffProperties(BattleActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeHeroBuffPropertiesBattleActor_hotfix != null)
			{
				this.m_ComputeHeroBuffPropertiesBattleActor_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_propertyModifier.Clear();
			this.CollectJobMasterPropertyModifier(a);
			this.CollectEquipmentPropertyModifier(a);
			this.CollectBuffPropertyModifier(a, false);
			this.m_property0.ComputeHeroProperties(this.m_configDataLoader, a.HeroInfo, a.JobConnectionInfo, a.JobLevel, a.HeroLevel, a.HeroStar, this.m_propertyModifier);
			this.CollectBuffPropertyModifier(a, true);
			this.m_property1.ComputeHeroProperties(this.m_configDataLoader, a.HeroInfo, a.JobConnectionInfo, a.JobLevel, a.HeroLevel, a.HeroStar, this.m_propertyModifier);
			this.CollectBuffPropertyExchange(a, this.m_property1);
			this.m_property1.ApplyExchangeProperty(this.m_propertyModifier);
		}

		// Token: 0x0601118A RID: 70026 RVA: 0x0046E2D0 File Offset: 0x0046C4D0
		public void ComputeSoldierBuffCommandProperties(BattleActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeSoldierBuffCommandPropertiesBattleActor_hotfix != null)
			{
				this.m_ComputeSoldierBuffCommandPropertiesBattleActor_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_propertyModifier.Clear();
			this.CollectJobMasterPropertyModifier(a);
			this.CollectEquipmentPropertyModifier(a);
			this.CollectBuffPropertyModifier(a, false);
			this.m_property0.ComputeSoldierProperties(this.m_configDataLoader, a.SoldierInfo, null, a.HeroLevel, this.m_propertyModifier);
			this.CollectBuffPropertyModifier(a, true);
			this.m_property1.ComputeSoldierProperties(this.m_configDataLoader, a.SoldierInfo, null, a.HeroLevel, this.m_propertyModifier);
			this.m_property2.ComputeSoldierProperties(this.m_configDataLoader, a.SoldierInfo, a.HeroInfo, a.HeroLevel, this.m_propertyModifier);
		}

		// Token: 0x0601118B RID: 70027 RVA: 0x0046E3DC File Offset: 0x0046C5DC
		private void CollectJobMasterPropertyModifier(Hero hero, int jobConnectionId, int jobLevel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectJobMasterPropertyModifierHeroInt32Int32_hotfix != null)
			{
				this.m_CollectJobMasterPropertyModifierHeroInt32Int32_hotfix.call(new object[]
				{
					this,
					hero,
					jobConnectionId,
					jobLevel
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (HeroJob heroJob in hero.Jobs)
			{
				int jobLevel2 = heroJob.JobLevel;
				if (jobConnectionId == heroJob.JobRelatedId)
				{
					jobLevel2 = jobLevel;
				}
				if (heroJob.IsLevelMax(jobLevel2))
				{
					ConfigDataJobInfo jobInfo = heroJob.JobConnectionInfo.m_jobInfo;
					this.CollectJobPropertyModifier(jobInfo);
				}
			}
		}

		// Token: 0x0601118C RID: 70028 RVA: 0x0046E4E8 File Offset: 0x0046C6E8
		private void CollectFetterPropertyModidier(Dictionary<int, int> fetters)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectFetterPropertyModidierDictionary`2_hotfix != null)
			{
				this.m_CollectFetterPropertyModidierDictionary`2_hotfix.call(new object[]
				{
					this,
					fetters
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (KeyValuePair<int, int> keyValuePair in fetters)
			{
				ConfigDataHeroFetterInfo configDataHeroFetterInfo = this.m_configDataLoader.GetConfigDataHeroFetterInfo(keyValuePair.Key);
				if (configDataHeroFetterInfo != null)
				{
					int num = keyValuePair.Value - 1;
					if (num < configDataHeroFetterInfo.GotSkills_ID.Count)
					{
						ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(configDataHeroFetterInfo.GotSkills_ID[num]);
						if (configDataSkillInfo != null)
						{
							this.CollectPassiveSkillStaticPropertyModifier(configDataSkillInfo);
						}
					}
				}
			}
		}

		// Token: 0x0601118D RID: 70029 RVA: 0x0046E5FC File Offset: 0x0046C7FC
		private void CollectEquipmentPropertyModifier(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectEquipmentPropertyModifierHero_hotfix != null)
			{
				this.m_CollectEquipmentPropertyModifierHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			foreach (ulong instanceId in hero.EquipmentIds)
			{
				EquipmentBagItem equipmentBagItem = projectLPlayerContext.GetBagItemByInstanceId(instanceId) as EquipmentBagItem;
				if (equipmentBagItem != null)
				{
					ConfigDataEquipmentInfo equipmentInfo = equipmentBagItem.EquipmentInfo;
					this.m_propertyModifier.Collect(equipmentInfo.Property1_ID, BattleFormula.ComputeEquipmentPropertyAdd(equipmentInfo.Property1_Value, equipmentInfo.Property1_LevelUpValue, equipmentBagItem.Level));
					this.m_propertyModifier.Collect(equipmentInfo.Property2_ID, BattleFormula.ComputeEquipmentPropertyAdd(equipmentInfo.Property2_Value, equipmentInfo.Property2_LevelUpValue, equipmentBagItem.Level));
					foreach (CommonBattleProperty commonBattleProperty in equipmentBagItem.EnchantProperties)
					{
						this.m_propertyModifier.Collect(commonBattleProperty.Id, commonBattleProperty.Value);
					}
					int activeSkillId = equipmentInfo.GetActiveSkillId(equipmentBagItem.Level);
					ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(activeSkillId);
					if (configDataSkillInfo != null)
					{
						this.CollectPassiveSkillStaticPropertyModifier(configDataSkillInfo);
					}
				}
			}
			List<ConfigDataSkillInfo> equipmentResonanceSkillInfos = this.GetEquipmentResonanceSkillInfos(hero.EquipmentIds);
			foreach (ConfigDataSkillInfo skillInfo in equipmentResonanceSkillInfos)
			{
				this.CollectPassiveSkillStaticPropertyModifier(skillInfo);
			}
		}

		// Token: 0x0601118E RID: 70030 RVA: 0x0046E7FC File Offset: 0x0046C9FC
		private void CollectSoldierPassiveSkillPropertyModifier(ConfigDataSoldierInfo soldierInfo, List<TrainingTech> techs)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectSoldierPassiveSkillPropertyModifierConfigDataSoldierInfoList`1_hotfix != null)
			{
				this.m_CollectSoldierPassiveSkillPropertyModifierConfigDataSoldierInfoList`1_hotfix.call(new object[]
				{
					this,
					soldierInfo,
					techs
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (soldierInfo == null)
			{
				return;
			}
			if (techs == null)
			{
				return;
			}
			int skillLevelUp = 0;
			List<ConfigDataSkillInfo> trainingTechSoldierSkillInfos = BattleUtility.GetTrainingTechSoldierSkillInfos(this.m_configDataLoader, techs, soldierInfo, out skillLevelUp);
			foreach (ConfigDataSkillInfo skillInfo in trainingTechSoldierSkillInfos)
			{
				this.CollectPassiveSkillStaticPropertyModifier(skillInfo);
			}
			ConfigDataSkillInfo levelUpSkillInfo = soldierInfo.GetLevelUpSkillInfo(skillLevelUp);
			if (levelUpSkillInfo != null)
			{
				this.CollectPassiveSkillStaticPropertyModifier(levelUpSkillInfo);
			}
		}

		// Token: 0x0601118F RID: 70031 RVA: 0x0046E900 File Offset: 0x0046CB00
		public List<ConfigDataSkillInfo> GetEquipmentResonanceSkillInfos(ulong[] equipmentIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetEquipmentResonanceSkillInfosUInt64be_hotfix != null)
			{
				return (List<ConfigDataSkillInfo>)this.m_GetEquipmentResonanceSkillInfosUInt64be_hotfix.call(new object[]
				{
					this,
					equipmentIds
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			List<ConfigDataSkillInfo> list = new List<ConfigDataSkillInfo>();
			foreach (ulong instanceId in equipmentIds)
			{
				EquipmentBagItem equipmentBagItem = projectLPlayerContext.GetBagItemByInstanceId(instanceId) as EquipmentBagItem;
				if (equipmentBagItem != null && equipmentBagItem.ResonanceId != 0)
				{
					int num;
					if (dictionary.TryGetValue(equipmentBagItem.ResonanceId, out num))
					{
						dictionary[equipmentBagItem.ResonanceId] = num + 1;
					}
					else
					{
						dictionary.Add(equipmentBagItem.ResonanceId, 1);
					}
				}
			}
			foreach (KeyValuePair<int, int> keyValuePair in dictionary)
			{
				ConfigDataResonanceInfo configDataResonanceInfo = this.m_configDataLoader.GetConfigDataResonanceInfo(keyValuePair.Key);
				if (configDataResonanceInfo != null)
				{
					if (keyValuePair.Value >= 2)
					{
						ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(configDataResonanceInfo.Effect1);
						if (configDataSkillInfo != null)
						{
							list.Add(configDataSkillInfo);
						}
					}
					if (keyValuePair.Value >= 4)
					{
						ConfigDataSkillInfo configDataSkillInfo2 = this.m_configDataLoader.GetConfigDataSkillInfo(configDataResonanceInfo.Effect2);
						if (configDataSkillInfo2 != null)
						{
							list.Add(configDataSkillInfo2);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06011190 RID: 70032 RVA: 0x0046EADC File Offset: 0x0046CCDC
		private void CollectSkinPropertyModifier(ConfigDataModelSkinResourceInfo skinResInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectSkinPropertyModifierConfigDataModelSkinResourceInfo_hotfix != null)
			{
				this.m_CollectSkinPropertyModifierConfigDataModelSkinResourceInfo_hotfix.call(new object[]
				{
					this,
					skinResInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (skinResInfo == null)
			{
				return;
			}
			this.CollectPassiveSkillStaticPropertyModifier(skinResInfo.m_skinSkillInfo);
		}

		// Token: 0x06011191 RID: 70033 RVA: 0x0046EB60 File Offset: 0x0046CD60
		private void CollectBuffPropertyModifier(BattleActor a, bool isDynamic)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectBuffPropertyModifierBattleActorBoolean_hotfix != null)
			{
				this.m_CollectBuffPropertyModifierBattleActorBoolean_hotfix.call(new object[]
				{
					this,
					a,
					isDynamic
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			uint num = 0u;
			a.CollectBuffPropertyModifiersAndFightTags(this.m_propertyModifier, ref num, !isDynamic, isDynamic);
		}

		// Token: 0x06011192 RID: 70034 RVA: 0x0046EBF8 File Offset: 0x0046CDF8
		private void CollectBuffPropertyExchange(BattleActor a, BattleProperty property)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectBuffPropertyExchangeBattleActorBattleProperty_hotfix != null)
			{
				this.m_CollectBuffPropertyExchangeBattleActorBattleProperty_hotfix.call(new object[]
				{
					this,
					a,
					property
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			a.CollectBuffPropertyExchange(property, this.m_propertyModifier);
		}

		// Token: 0x06011193 RID: 70035 RVA: 0x0046EC88 File Offset: 0x0046CE88
		private void CollectJobMasterPropertyModifier(BattleActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectJobMasterPropertyModifierBattleActor_hotfix != null)
			{
				this.m_CollectJobMasterPropertyModifierBattleActor_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			a.CollectJobMasterPropertyModifiers(this.m_propertyModifier);
		}

		// Token: 0x06011194 RID: 70036 RVA: 0x0046ED04 File Offset: 0x0046CF04
		private void CollectEquipmentPropertyModifier(BattleActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectEquipmentPropertyModifierBattleActor_hotfix != null)
			{
				this.m_CollectEquipmentPropertyModifierBattleActor_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			a.CollectEquipmentPropertyModifiers(this.m_propertyModifier);
		}

		// Token: 0x06011195 RID: 70037 RVA: 0x0046ED80 File Offset: 0x0046CF80
		public void ComputeHeroProperties(BattleHero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeHeroPropertiesBattleHero_hotfix != null)
			{
				this.m_ComputeHeroPropertiesBattleHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleHeroJob activeJob = hero.GetActiveJob();
			this.m_propertyModifier.Clear();
			this.CollectJobMasterPropertyModifier(hero);
			this.CollectFetterPropertyModidier(hero.Fetters);
			this.CollectEquipmentPropertyModifier(hero);
			this.CollectSkinPropertyModifier(hero.GetHeroActiveJobModelSkinResourceInfo(this.m_configDataLoader));
			this.m_property0.ComputeHeroProperties(this.m_configDataLoader, hero.HeroInfo, activeJob.JobConnectionInfo, activeJob.JobLevel, hero.Level, hero.StarLevel, this.m_propertyModifier);
		}

		// Token: 0x06011196 RID: 70038 RVA: 0x0046EE64 File Offset: 0x0046D064
		public void ComputeHeroEquipmentProperties(BattleHero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeHeroEquipmentPropertiesBattleHero_hotfix != null)
			{
				this.m_ComputeHeroEquipmentPropertiesBattleHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleHeroJob activeJob = hero.GetActiveJob();
			this.m_propertyModifier.Clear();
			this.CollectJobMasterPropertyModifier(hero);
			this.CollectFetterPropertyModidier(hero.Fetters);
			this.CollectSkinPropertyModifier(hero.GetHeroActiveJobModelSkinResourceInfo(this.m_configDataLoader));
			this.m_property0.ComputeHeroProperties(this.m_configDataLoader, hero.HeroInfo, activeJob.JobConnectionInfo, activeJob.JobLevel, hero.Level, hero.StarLevel, this.m_propertyModifier);
			this.CollectEquipmentPropertyModifier(hero);
			this.m_property1.ComputeHeroProperties(this.m_configDataLoader, hero.HeroInfo, activeJob.JobConnectionInfo, activeJob.JobLevel, hero.Level, hero.StarLevel, this.m_propertyModifier);
		}

		// Token: 0x06011197 RID: 70039 RVA: 0x0046EF7C File Offset: 0x0046D17C
		private void CollectJobMasterPropertyModifier(BattleHero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectJobMasterPropertyModifierBattleHero_hotfix != null)
			{
				this.m_CollectJobMasterPropertyModifierBattleHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (hero == null)
			{
				return;
			}
			foreach (BattleHeroJob battleHeroJob in hero.Jobs)
			{
				if (battleHeroJob.JobConnectionInfo.IsJobLevelMax(battleHeroJob.JobLevel))
				{
					this.CollectJobPropertyModifier(battleHeroJob.JobConnectionInfo.m_jobInfo);
				}
			}
		}

		// Token: 0x06011198 RID: 70040 RVA: 0x0046F064 File Offset: 0x0046D264
		private void CollectEquipmentPropertyModifier(BattleHero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectEquipmentPropertyModifierBattleHero_hotfix != null)
			{
				this.m_CollectEquipmentPropertyModifierBattleHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (hero == null)
			{
				return;
			}
			foreach (BattleHeroEquipment battleHeroEquipment in hero.Equipments)
			{
				ConfigDataEquipmentInfo configDataEquipmentInfo = this.m_configDataLoader.GetConfigDataEquipmentInfo(battleHeroEquipment.Id);
				if (configDataEquipmentInfo != null)
				{
					this.m_propertyModifier.Collect(configDataEquipmentInfo.Property1_ID, BattleFormula.ComputeEquipmentPropertyAdd(configDataEquipmentInfo.Property1_Value, configDataEquipmentInfo.Property1_LevelUpValue, battleHeroEquipment.Level));
					this.m_propertyModifier.Collect(configDataEquipmentInfo.Property2_ID, BattleFormula.ComputeEquipmentPropertyAdd(configDataEquipmentInfo.Property2_Value, configDataEquipmentInfo.Property2_LevelUpValue, battleHeroEquipment.Level));
					foreach (CommonBattleProperty commonBattleProperty in battleHeroEquipment.EnchantProperties)
					{
						this.m_propertyModifier.Collect(commonBattleProperty.Id, commonBattleProperty.Value);
					}
					int activeSkillId = configDataEquipmentInfo.GetActiveSkillId(battleHeroEquipment.Level);
					ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(activeSkillId);
					if (configDataSkillInfo != null)
					{
						this.CollectPassiveSkillStaticPropertyModifier(configDataSkillInfo);
					}
				}
			}
			List<ConfigDataSkillInfo> equipmentResonanceSkillInfos = BattleUtility.GetEquipmentResonanceSkillInfos(this.m_configDataLoader, hero.Equipments);
			foreach (ConfigDataSkillInfo skillInfo in equipmentResonanceSkillInfos)
			{
				this.CollectPassiveSkillStaticPropertyModifier(skillInfo);
			}
		}

		// Token: 0x06011199 RID: 70041 RVA: 0x0046F294 File Offset: 0x0046D494
		private void CollectJobPropertyModifier(ConfigDataJobInfo jobInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectJobPropertyModifierConfigDataJobInfo_hotfix != null)
			{
				this.m_CollectJobPropertyModifierConfigDataJobInfo_hotfix.call(new object[]
				{
					this,
					jobInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (jobInfo == null)
			{
				return;
			}
			this.m_propertyModifier.Collect(jobInfo.Property1_ID, jobInfo.Property1_Value);
			this.m_propertyModifier.Collect(jobInfo.Property2_ID, jobInfo.Property2_Value);
			this.m_propertyModifier.Collect(jobInfo.Property3_ID, jobInfo.Property3_Value);
		}

		// Token: 0x0601119A RID: 70042 RVA: 0x0046F350 File Offset: 0x0046D550
		private void CollectPassiveSkillStaticPropertyModifier(ConfigDataSkillInfo skillInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectPassiveSkillStaticPropertyModifierConfigDataSkillInfo_hotfix != null)
			{
				this.m_CollectPassiveSkillStaticPropertyModifierConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					skillInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (skillInfo == null)
			{
				return;
			}
			if (skillInfo.m_passiveBuffInfos != null)
			{
				foreach (ConfigDataBuffInfo configDataBuffInfo in skillInfo.m_passiveBuffInfos)
				{
					this.CollectStaticPropertyModifier(configDataBuffInfo.Property1_ID, configDataBuffInfo.Property1_Value);
					this.CollectStaticPropertyModifier(configDataBuffInfo.Property2_ID, configDataBuffInfo.Property2_Value);
					this.CollectStaticPropertyModifier(configDataBuffInfo.Property3_ID, configDataBuffInfo.Property3_Value);
					this.CollectStaticPropertyModifier(configDataBuffInfo.Property4_ID, configDataBuffInfo.Property4_Value);
				}
			}
		}

		// Token: 0x0601119B RID: 70043 RVA: 0x0046F43C File Offset: 0x0046D63C
		private void CollectStaticPropertyModifier(PropertyModifyType modifyType, int value)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectStaticPropertyModifierPropertyModifyTypeInt32_hotfix != null)
			{
				this.m_CollectStaticPropertyModifierPropertyModifyTypeInt32_hotfix.call(new object[]
				{
					this,
					modifyType,
					value
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataPropertyModifyInfo configDataPropertyModifyInfo = this.m_configDataLoader.GetConfigDataPropertyModifyInfo((int)modifyType);
			if (configDataPropertyModifyInfo != null && !configDataPropertyModifyInfo.IsDynamic)
			{
				this.m_propertyModifier.Collect(modifyType, value);
			}
		}

		// Token: 0x170034C4 RID: 13508
		// (get) Token: 0x0601119C RID: 70044 RVA: 0x0046F4E8 File Offset: 0x0046D6E8
		public BattleProperty Property0
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Property0_hotfix != null)
				{
					return (BattleProperty)this.m_get_Property0_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_property0;
			}
		}

		// Token: 0x170034C5 RID: 13509
		// (get) Token: 0x0601119D RID: 70045 RVA: 0x0046F55C File Offset: 0x0046D75C
		public BattleProperty Property1
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Property1_hotfix != null)
				{
					return (BattleProperty)this.m_get_Property1_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_property1;
			}
		}

		// Token: 0x170034C6 RID: 13510
		// (get) Token: 0x0601119E RID: 70046 RVA: 0x0046F5D0 File Offset: 0x0046D7D0
		public BattleProperty Property2
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Property2_hotfix != null)
				{
					return (BattleProperty)this.m_get_Property2_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_property2;
			}
		}

		// Token: 0x170034C7 RID: 13511
		// (get) Token: 0x0601119F RID: 70047 RVA: 0x0046F644 File Offset: 0x0046D844
		// (set) Token: 0x060111A0 RID: 70048 RVA: 0x0046F664 File Offset: 0x0046D864
		[DoNotToLua]
		public HeroPropertyComputer.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroPropertyComputer.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060111A1 RID: 70049 RVA: 0x0046F670 File Offset: 0x0046D870
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_InitIConfigDataLoader_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_ComputeHeroPropertiesHeroInt32Int32Int32Int32Int32Int32Int32_hotfix = (luaObj.RawGet("ComputeHeroProperties") as LuaFunction);
					this.m_ComputeHeroJobLevelUpPropertiesHeroInt32_hotfix = (luaObj.RawGet("ComputeHeroJobLevelUpProperties") as LuaFunction);
					this.m_ComputeHeroEquipmentPropertiesHero_hotfix = (luaObj.RawGet("ComputeHeroEquipmentProperties") as LuaFunction);
					this.m_ComputeSoldierCommandPropertiesHeroConfigDataSoldierInfo_hotfix = (luaObj.RawGet("ComputeSoldierCommandProperties") as LuaFunction);
					this.m_ComputeSoldierCommandPropertiesBattleHeroConfigDataSoldierInfoList`1ConfigDataModelSkinResourceInfo_hotfix = (luaObj.RawGet("ComputeSoldierCommandProperties") as LuaFunction);
					this.m_ComputeHeroBuffPropertiesBattleActor_hotfix = (luaObj.RawGet("ComputeHeroBuffProperties") as LuaFunction);
					this.m_ComputeSoldierBuffCommandPropertiesBattleActor_hotfix = (luaObj.RawGet("ComputeSoldierBuffCommandProperties") as LuaFunction);
					this.m_CollectJobMasterPropertyModifierHeroInt32Int32_hotfix = (luaObj.RawGet("CollectJobMasterPropertyModifier") as LuaFunction);
					this.m_CollectFetterPropertyModidierDictionary`2_hotfix = (luaObj.RawGet("CollectFetterPropertyModidier") as LuaFunction);
					this.m_CollectEquipmentPropertyModifierHero_hotfix = (luaObj.RawGet("CollectEquipmentPropertyModifier") as LuaFunction);
					this.m_CollectSoldierPassiveSkillPropertyModifierConfigDataSoldierInfoList`1_hotfix = (luaObj.RawGet("CollectSoldierPassiveSkillPropertyModifier") as LuaFunction);
					this.m_GetEquipmentResonanceSkillInfosUInt64be_hotfix = (luaObj.RawGet("GetEquipmentResonanceSkillInfos") as LuaFunction);
					this.m_CollectSkinPropertyModifierConfigDataModelSkinResourceInfo_hotfix = (luaObj.RawGet("CollectSkinPropertyModifier") as LuaFunction);
					this.m_CollectBuffPropertyModifierBattleActorBoolean_hotfix = (luaObj.RawGet("CollectBuffPropertyModifier") as LuaFunction);
					this.m_CollectBuffPropertyExchangeBattleActorBattleProperty_hotfix = (luaObj.RawGet("CollectBuffPropertyExchange") as LuaFunction);
					this.m_CollectJobMasterPropertyModifierBattleActor_hotfix = (luaObj.RawGet("CollectJobMasterPropertyModifier") as LuaFunction);
					this.m_CollectEquipmentPropertyModifierBattleActor_hotfix = (luaObj.RawGet("CollectEquipmentPropertyModifier") as LuaFunction);
					this.m_ComputeHeroPropertiesBattleHero_hotfix = (luaObj.RawGet("ComputeHeroProperties") as LuaFunction);
					this.m_ComputeHeroEquipmentPropertiesBattleHero_hotfix = (luaObj.RawGet("ComputeHeroEquipmentProperties") as LuaFunction);
					this.m_CollectJobMasterPropertyModifierBattleHero_hotfix = (luaObj.RawGet("CollectJobMasterPropertyModifier") as LuaFunction);
					this.m_CollectEquipmentPropertyModifierBattleHero_hotfix = (luaObj.RawGet("CollectEquipmentPropertyModifier") as LuaFunction);
					this.m_CollectJobPropertyModifierConfigDataJobInfo_hotfix = (luaObj.RawGet("CollectJobPropertyModifier") as LuaFunction);
					this.m_CollectPassiveSkillStaticPropertyModifierConfigDataSkillInfo_hotfix = (luaObj.RawGet("CollectPassiveSkillStaticPropertyModifier") as LuaFunction);
					this.m_CollectStaticPropertyModifierPropertyModifyTypeInt32_hotfix = (luaObj.RawGet("CollectStaticPropertyModifier") as LuaFunction);
					this.m_get_Property0_hotfix = (luaObj.RawGet("get_Property0") as LuaFunction);
					this.m_get_Property1_hotfix = (luaObj.RawGet("get_Property1") as LuaFunction);
					this.m_get_Property2_hotfix = (luaObj.RawGet("get_Property2") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060111A2 RID: 70050 RVA: 0x0046F9F8 File Offset: 0x0046DBF8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroPropertyComputer));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009D28 RID: 40232
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04009D29 RID: 40233
		private BattleProperty m_property0 = new BattleProperty();

		// Token: 0x04009D2A RID: 40234
		private BattleProperty m_property1 = new BattleProperty();

		// Token: 0x04009D2B RID: 40235
		private BattleProperty m_property2 = new BattleProperty();

		// Token: 0x04009D2C RID: 40236
		private BattlePropertyModifier m_propertyModifier = new BattlePropertyModifier();

		// Token: 0x04009D2D RID: 40237
		[DoNotToLua]
		private HeroPropertyComputer.LuaExportHelper luaExportHelper;

		// Token: 0x04009D2E RID: 40238
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009D2F RID: 40239
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009D30 RID: 40240
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04009D31 RID: 40241
		private LuaFunction m_InitIConfigDataLoader_hotfix;

		// Token: 0x04009D32 RID: 40242
		private LuaFunction m_ComputeHeroPropertiesHeroInt32Int32Int32Int32Int32Int32Int32_hotfix;

		// Token: 0x04009D33 RID: 40243
		private LuaFunction m_ComputeHeroJobLevelUpPropertiesHeroInt32_hotfix;

		// Token: 0x04009D34 RID: 40244
		private LuaFunction m_ComputeHeroEquipmentPropertiesHero_hotfix;

		// Token: 0x04009D35 RID: 40245
		private LuaFunction m_ComputeSoldierCommandPropertiesHeroConfigDataSoldierInfo_hotfix;

		// Token: 0x04009D36 RID: 40246
		private LuaFunction m_ComputeSoldierCommandPropertiesBattleHeroConfigDataSoldierInfoList;

		// Token: 0x04009D37 RID: 40247
		private LuaFunction m_ComputeHeroBuffPropertiesBattleActor_hotfix;

		// Token: 0x04009D38 RID: 40248
		private LuaFunction m_ComputeSoldierBuffCommandPropertiesBattleActor_hotfix;

		// Token: 0x04009D39 RID: 40249
		private LuaFunction m_CollectJobMasterPropertyModifierHeroInt32Int32_hotfix;

		// Token: 0x04009D3A RID: 40250
		private LuaFunction m_CollectFetterPropertyModidierDictionary;

		// Token: 0x04009D3B RID: 40251
		private LuaFunction m_CollectEquipmentPropertyModifierHero_hotfix;

		// Token: 0x04009D3C RID: 40252
		private LuaFunction m_CollectSoldierPassiveSkillPropertyModifierConfigDataSoldierInfoList;

		// Token: 0x04009D3D RID: 40253
		private LuaFunction m_GetEquipmentResonanceSkillInfosUInt64be_hotfix;

		// Token: 0x04009D3E RID: 40254
		private LuaFunction m_CollectSkinPropertyModifierConfigDataModelSkinResourceInfo_hotfix;

		// Token: 0x04009D3F RID: 40255
		private LuaFunction m_CollectBuffPropertyModifierBattleActorBoolean_hotfix;

		// Token: 0x04009D40 RID: 40256
		private LuaFunction m_CollectBuffPropertyExchangeBattleActorBattleProperty_hotfix;

		// Token: 0x04009D41 RID: 40257
		private LuaFunction m_CollectJobMasterPropertyModifierBattleActor_hotfix;

		// Token: 0x04009D42 RID: 40258
		private LuaFunction m_CollectEquipmentPropertyModifierBattleActor_hotfix;

		// Token: 0x04009D43 RID: 40259
		private LuaFunction m_ComputeHeroPropertiesBattleHero_hotfix;

		// Token: 0x04009D44 RID: 40260
		private LuaFunction m_ComputeHeroEquipmentPropertiesBattleHero_hotfix;

		// Token: 0x04009D45 RID: 40261
		private LuaFunction m_CollectJobMasterPropertyModifierBattleHero_hotfix;

		// Token: 0x04009D46 RID: 40262
		private LuaFunction m_CollectEquipmentPropertyModifierBattleHero_hotfix;

		// Token: 0x04009D47 RID: 40263
		private LuaFunction m_CollectJobPropertyModifierConfigDataJobInfo_hotfix;

		// Token: 0x04009D48 RID: 40264
		private LuaFunction m_CollectPassiveSkillStaticPropertyModifierConfigDataSkillInfo_hotfix;

		// Token: 0x04009D49 RID: 40265
		private LuaFunction m_CollectStaticPropertyModifierPropertyModifyTypeInt32_hotfix;

		// Token: 0x04009D4A RID: 40266
		private LuaFunction m_get_Property0_hotfix;

		// Token: 0x04009D4B RID: 40267
		private LuaFunction m_get_Property1_hotfix;

		// Token: 0x04009D4C RID: 40268
		private LuaFunction m_get_Property2_hotfix;

		// Token: 0x02000E01 RID: 3585
		public class LuaExportHelper
		{
			// Token: 0x060111A3 RID: 70051 RVA: 0x0046FA60 File Offset: 0x0046DC60
			public LuaExportHelper(HeroPropertyComputer owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x170034C8 RID: 13512
			// (get) Token: 0x060111A4 RID: 70052 RVA: 0x0046FA70 File Offset: 0x0046DC70
			// (set) Token: 0x060111A5 RID: 70053 RVA: 0x0046FA80 File Offset: 0x0046DC80
			public IConfigDataLoader m_configDataLoader
			{
				get
				{
					return this.m_owner.m_configDataLoader;
				}
				set
				{
					this.m_owner.m_configDataLoader = value;
				}
			}

			// Token: 0x170034C9 RID: 13513
			// (get) Token: 0x060111A6 RID: 70054 RVA: 0x0046FA90 File Offset: 0x0046DC90
			// (set) Token: 0x060111A7 RID: 70055 RVA: 0x0046FAA0 File Offset: 0x0046DCA0
			public BattleProperty m_property0
			{
				get
				{
					return this.m_owner.m_property0;
				}
				set
				{
					this.m_owner.m_property0 = value;
				}
			}

			// Token: 0x170034CA RID: 13514
			// (get) Token: 0x060111A8 RID: 70056 RVA: 0x0046FAB0 File Offset: 0x0046DCB0
			// (set) Token: 0x060111A9 RID: 70057 RVA: 0x0046FAC0 File Offset: 0x0046DCC0
			public BattleProperty m_property1
			{
				get
				{
					return this.m_owner.m_property1;
				}
				set
				{
					this.m_owner.m_property1 = value;
				}
			}

			// Token: 0x170034CB RID: 13515
			// (get) Token: 0x060111AA RID: 70058 RVA: 0x0046FAD0 File Offset: 0x0046DCD0
			// (set) Token: 0x060111AB RID: 70059 RVA: 0x0046FAE0 File Offset: 0x0046DCE0
			public BattleProperty m_property2
			{
				get
				{
					return this.m_owner.m_property2;
				}
				set
				{
					this.m_owner.m_property2 = value;
				}
			}

			// Token: 0x170034CC RID: 13516
			// (get) Token: 0x060111AC RID: 70060 RVA: 0x0046FAF0 File Offset: 0x0046DCF0
			// (set) Token: 0x060111AD RID: 70061 RVA: 0x0046FB00 File Offset: 0x0046DD00
			public BattlePropertyModifier m_propertyModifier
			{
				get
				{
					return this.m_owner.m_propertyModifier;
				}
				set
				{
					this.m_owner.m_propertyModifier = value;
				}
			}

			// Token: 0x060111AE RID: 70062 RVA: 0x0046FB10 File Offset: 0x0046DD10
			public void CollectJobMasterPropertyModifier(Hero hero, int jobConnectionId, int jobLevel)
			{
				this.m_owner.CollectJobMasterPropertyModifier(hero, jobConnectionId, jobLevel);
			}

			// Token: 0x060111AF RID: 70063 RVA: 0x0046FB20 File Offset: 0x0046DD20
			public void CollectFetterPropertyModidier(Dictionary<int, int> fetters)
			{
				this.m_owner.CollectFetterPropertyModidier(fetters);
			}

			// Token: 0x060111B0 RID: 70064 RVA: 0x0046FB30 File Offset: 0x0046DD30
			public void CollectEquipmentPropertyModifier(Hero hero)
			{
				this.m_owner.CollectEquipmentPropertyModifier(hero);
			}

			// Token: 0x060111B1 RID: 70065 RVA: 0x0046FB40 File Offset: 0x0046DD40
			public void CollectSoldierPassiveSkillPropertyModifier(ConfigDataSoldierInfo soldierInfo, List<TrainingTech> techs)
			{
				this.m_owner.CollectSoldierPassiveSkillPropertyModifier(soldierInfo, techs);
			}

			// Token: 0x060111B2 RID: 70066 RVA: 0x0046FB50 File Offset: 0x0046DD50
			public void CollectSkinPropertyModifier(ConfigDataModelSkinResourceInfo skinResInfo)
			{
				this.m_owner.CollectSkinPropertyModifier(skinResInfo);
			}

			// Token: 0x060111B3 RID: 70067 RVA: 0x0046FB60 File Offset: 0x0046DD60
			public void CollectBuffPropertyModifier(BattleActor a, bool isDynamic)
			{
				this.m_owner.CollectBuffPropertyModifier(a, isDynamic);
			}

			// Token: 0x060111B4 RID: 70068 RVA: 0x0046FB70 File Offset: 0x0046DD70
			public void CollectBuffPropertyExchange(BattleActor a, BattleProperty property)
			{
				this.m_owner.CollectBuffPropertyExchange(a, property);
			}

			// Token: 0x060111B5 RID: 70069 RVA: 0x0046FB80 File Offset: 0x0046DD80
			public void CollectJobMasterPropertyModifier(BattleActor a)
			{
				this.m_owner.CollectJobMasterPropertyModifier(a);
			}

			// Token: 0x060111B6 RID: 70070 RVA: 0x0046FB90 File Offset: 0x0046DD90
			public void CollectEquipmentPropertyModifier(BattleActor a)
			{
				this.m_owner.CollectEquipmentPropertyModifier(a);
			}

			// Token: 0x060111B7 RID: 70071 RVA: 0x0046FBA0 File Offset: 0x0046DDA0
			public void CollectJobMasterPropertyModifier(BattleHero hero)
			{
				this.m_owner.CollectJobMasterPropertyModifier(hero);
			}

			// Token: 0x060111B8 RID: 70072 RVA: 0x0046FBB0 File Offset: 0x0046DDB0
			public void CollectEquipmentPropertyModifier(BattleHero hero)
			{
				this.m_owner.CollectEquipmentPropertyModifier(hero);
			}

			// Token: 0x060111B9 RID: 70073 RVA: 0x0046FBC0 File Offset: 0x0046DDC0
			public void CollectJobPropertyModifier(ConfigDataJobInfo jobInfo)
			{
				this.m_owner.CollectJobPropertyModifier(jobInfo);
			}

			// Token: 0x060111BA RID: 70074 RVA: 0x0046FBD0 File Offset: 0x0046DDD0
			public void CollectPassiveSkillStaticPropertyModifier(ConfigDataSkillInfo skillInfo)
			{
				this.m_owner.CollectPassiveSkillStaticPropertyModifier(skillInfo);
			}

			// Token: 0x060111BB RID: 70075 RVA: 0x0046FBE0 File Offset: 0x0046DDE0
			public void CollectStaticPropertyModifier(PropertyModifyType modifyType, int value)
			{
				this.m_owner.CollectStaticPropertyModifier(modifyType, value);
			}

			// Token: 0x04009D4D RID: 40269
			private HeroPropertyComputer m_owner;
		}
	}
}
