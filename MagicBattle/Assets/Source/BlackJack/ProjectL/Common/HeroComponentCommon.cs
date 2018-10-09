using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.UtilityTools;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200046C RID: 1132
	[HotFix]
	public class HeroComponentCommon : IComponentBase
	{
		// Token: 0x060041A4 RID: 16804 RVA: 0x00134810 File Offset: 0x00132A10
		public HeroComponentCommon()
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

		// Token: 0x060041A5 RID: 16805 RVA: 0x00134884 File Offset: 0x00132A84
		public string GetName()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetName_hotfix != null)
			{
				return (string)this.m_GetName_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return "Hero";
		}

		// Token: 0x060041A6 RID: 16806 RVA: 0x001348F8 File Offset: 0x00132AF8
		public virtual void Init()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Init_hotfix != null)
			{
				this.m_Init_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060041A7 RID: 16807 RVA: 0x00134958 File Offset: 0x00132B58
		public virtual void PostInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostInit_hotfix != null)
			{
				this.m_PostInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_bag = (this.Owner.GetOwnerComponent("Bag") as BagComponentCommon);
			this.m_basicInfo = (this.Owner.GetOwnerComponent("PlayerBasicInfo") as PlayerBasicInfoComponentCommon);
			this.m_rift = (this.Owner.GetOwnerComponent("Rift") as RiftComponentCommon);
			this.m_mission = (this.Owner.GetOwnerComponent("Mission") as MissionComponentCommon);
			this.m_battle = (this.Owner.GetOwnerComponent("Battle") as BattleComponentCommon);
			this.m_resource = (this.Owner.GetOwnerComponent("Resource") as ResourceComponentCommon);
			this.m_guild = (this.Owner.GetOwnerComponent("Guild") as GuildComponentCommon);
			this.m_trainingGround = (this.Owner.GetOwnerComponent("TrainingGround") as TrainingGroundCompomentCommon);
			this.m_wearedEquipmentHeroDict = new Dictionary<ulong, int>();
			this.m_soliders = new HashSet<int>();
			this.m_skills = new HashSet<int>();
			this.m_atuoEquipmentTouch = new Dictionary<int, DateTime>();
		}

		// Token: 0x060041A8 RID: 16808 RVA: 0x00134ABC File Offset: 0x00132CBC
		public virtual void DeInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeInit_hotfix != null)
			{
				this.m_DeInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060041A9 RID: 16809 RVA: 0x00134B1C File Offset: 0x00132D1C
		public virtual void Tick(uint deltaMillisecond)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickUInt32_hotfix != null)
			{
				this.m_TickUInt32_hotfix.call(new object[]
				{
					this,
					deltaMillisecond
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.FlushHeroInteractNums();
		}

		// Token: 0x060041AA RID: 16810 RVA: 0x00134B94 File Offset: 0x00132D94
		public virtual bool Serialize<T>(T dest)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SerializeT_hotfix != null)
			{
				return Convert.ToBoolean(this.m_SerializeT_hotfix.call(new object[]
				{
					this,
					dest
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return false;
		}

		// Token: 0x060041AB RID: 16811 RVA: 0x00134C14 File Offset: 0x00132E14
		public virtual void DeSerialize<T>(T source)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeT_hotfix != null)
			{
				this.m_DeSerializeT_hotfix.call(new object[]
				{
					this,
					source
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060041AC RID: 16812 RVA: 0x00134C84 File Offset: 0x00132E84
		public virtual void PostDeSerialize()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostDeSerialize_hotfix != null)
			{
				this.m_PostDeSerialize_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x1700115A RID: 4442
		// (get) Token: 0x060041AD RID: 16813 RVA: 0x00134CE4 File Offset: 0x00132EE4
		// (set) Token: 0x060041AE RID: 16814 RVA: 0x00134D58 File Offset: 0x00132F58
		public IComponentOwner Owner
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Owner_hotfix != null)
				{
					return (IComponentOwner)this.m_get_Owner_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Owner>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_OwnerIComponentOwner_hotfix != null)
				{
					this.m_set_OwnerIComponentOwner_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Owner>k__BackingField = value;
			}
		}

		// Token: 0x060041AF RID: 16815 RVA: 0x00134DD0 File Offset: 0x00132FD0
		public int GetProtagonistID()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetProtagonistID_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetProtagonistID_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroDS.ProtagonistID;
		}

		// Token: 0x060041B0 RID: 16816 RVA: 0x00134E48 File Offset: 0x00133048
		public bool IsProtagonistHero(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsProtagonistHeroInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsProtagonistHeroInt32_hotfix.call(new object[]
				{
					this,
					heroId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return heroId == this.m_configDataLoader.ConfigableConstId_ProtagonistHeroID;
		}

		// Token: 0x060041B1 RID: 16817 RVA: 0x00134ED4 File Offset: 0x001330D4
		public bool IsProtagonistExist()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsProtagonistExist_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsProtagonistExist_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroDS.ProtagonistID != 0;
		}

		// Token: 0x060041B2 RID: 16818 RVA: 0x00134F54 File Offset: 0x00133154
		public int SetProtagonist(int protagonistId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetProtagonistInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_SetProtagonistInt32_hotfix.call(new object[]
				{
					this,
					protagonistId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_configDataLoader.GetConfigDataProtagonistInfo(protagonistId) == null)
			{
				return -644;
			}
			if (this.IsProtagonistExist())
			{
				return -645;
			}
			int num = this.AddHero(this.m_configDataLoader.ConfigableConstId_ProtagonistHeroID);
			if (num != 0)
			{
				return num;
			}
			this.m_heroDS.SetProtagonist(protagonistId);
			return 0;
		}

		// Token: 0x060041B3 RID: 16819 RVA: 0x00135024 File Offset: 0x00133224
		public List<Hero> GetAllStarLvlMaxHeroes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllStarLvlMaxHeroes_hotfix != null)
			{
				return (List<Hero>)this.m_GetAllStarLvlMaxHeroes_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Hero> list = new List<Hero>();
			foreach (Hero hero in this.m_heroDS.GetAllHeroes())
			{
				if (this.IsLvlMaxHeroStar(hero))
				{
					list.Add(hero);
				}
			}
			return list;
		}

		// Token: 0x060041B4 RID: 16820 RVA: 0x001350F8 File Offset: 0x001332F8
		public List<HeroFragmentBagItem> GetAllStarLvlMaxHeroFragments()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllStarLvlMaxHeroFragments_hotfix != null)
			{
				return (List<HeroFragmentBagItem>)this.m_GetAllStarLvlMaxHeroFragments_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<HeroFragmentBagItem> list = new List<HeroFragmentBagItem>();
			List<Hero> allStarLvlMaxHeroes = this.GetAllStarLvlMaxHeroes();
			foreach (Hero hero in allStarLvlMaxHeroes)
			{
				ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(hero.HeroId);
				if (configDataHeroInfo != null && configDataHeroInfo.FragmentItem_ID != 0)
				{
					HeroFragmentBagItem heroFragmentBagItem = this.m_bag.FindBagItemByType(GoodsType.GoodsType_Item, configDataHeroInfo.FragmentItem_ID) as HeroFragmentBagItem;
					if (heroFragmentBagItem != null)
					{
						list.Add(heroFragmentBagItem);
					}
				}
			}
			return list;
		}

		// Token: 0x060041B5 RID: 16821 RVA: 0x0013520C File Offset: 0x0013340C
		protected void InitHeroDataByCaculate(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitHeroDataByCaculateHero_hotfix != null)
			{
				this.m_InitHeroDataByCaculateHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(hero.HeroId);
			this.AddSoldier(hero, configDataHeroInfo.Soldier_ID, false);
			foreach (int soldierId in configDataHeroInfo.SelectableSoldier_ID)
			{
				this.AddSoldier(hero, soldierId, false);
			}
			foreach (int skillId in configDataHeroInfo.Skills_ID)
			{
				this.AddSkill(hero, skillId);
			}
			this.InitHeroJobs(hero);
			foreach (ConfigDataJobConnectionInfo configDataJobConnectionInfo in configDataHeroInfo.m_useableJobConnectionInfos)
			{
				if (this.IsNeedAddAchievement(configDataJobConnectionInfo))
				{
					foreach (ConfigDataJobConnectionInfo configDataJobConnectionInfo2 in configDataJobConnectionInfo.m_preJobConnectionInfos)
					{
						hero.NeedGetAchievementsJobRelatedIdList.Add(configDataJobConnectionInfo2.ID);
					}
				}
			}
		}

		// Token: 0x060041B6 RID: 16822 RVA: 0x001353D4 File Offset: 0x001335D4
		private void InitHeroJobs(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitHeroJobsHero_hotfix != null)
			{
				this.m_InitHeroJobsHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			foreach (HeroJob heroJob in hero.Jobs)
			{
				ConfigDataJobConnectionInfo configDataJobConnectionInfo = this.m_configDataLoader.GetConfigDataJobConnectionInfo(heroJob.JobRelatedId);
				int rank = configDataJobConnectionInfo.m_jobInfo.Rank;
				if (num <= rank)
				{
					num = rank;
					if (this.IsJobLevelMax(configDataJobConnectionInfo, heroJob.JobLevel))
					{
						num++;
					}
				}
				for (int i = 0; i <= heroJob.JobLevel; i++)
				{
					ConfigDataJobLevelInfo configDataJobLevelInfo = configDataJobConnectionInfo.m_jobLevelInfos[i];
					this.AddSkill(hero, configDataJobLevelInfo.GotSkill_ID);
					this.AddSoldier(hero, configDataJobLevelInfo.GotSoldier_ID, false);
				}
			}
			hero.CanTransferMaxRank = num;
		}

		// Token: 0x060041B7 RID: 16823 RVA: 0x00135518 File Offset: 0x00133718
		private void AddHeroDefaultInfos(Hero hero, ConfigDataHeroInfo heroInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddHeroDefaultInfosHeroConfigDataHeroInfo_hotfix != null)
			{
				this.m_AddHeroDefaultInfosHeroConfigDataHeroInfo_hotfix.call(new object[]
				{
					this,
					hero,
					heroInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			hero.SelectedSoldierId = heroInfo.Soldier_ID;
			this.AddSoldier(hero, heroInfo.Soldier_ID, false);
			foreach (int skillId in heroInfo.Skills_ID)
			{
				this.AddSkill(hero, skillId);
			}
			this.AddHeroJob(hero, heroInfo.m_jobConnectionInfo);
			this.m_heroDS.ActiveHeroJob(hero, heroInfo.m_jobConnectionInfo.ID);
			foreach (int newGotSkillId in hero.SkillIds)
			{
				this.TryEquipNewSkill(hero, newGotSkillId);
			}
		}

		// Token: 0x060041B8 RID: 16824 RVA: 0x00135674 File Offset: 0x00133874
		public int CanHeroJobEquipSkill(int jobRelatedId, int skillId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanHeroJobEquipSkillInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanHeroJobEquipSkillInt32Int32_hotfix.call(new object[]
				{
					this,
					jobRelatedId,
					skillId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = this.m_configDataLoader.GetConfigDataJobConnectionInfo(jobRelatedId);
			if (configDataJobConnectionInfo == null)
			{
				return -615;
			}
			ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(skillId);
			if (configDataSkillInfo == null)
			{
				return -621;
			}
			if (configDataSkillInfo.LimitArmys_ID.Count != 0 && !configDataSkillInfo.LimitArmys_ID.Contains(configDataJobConnectionInfo.m_jobInfo.Army_ID))
			{
				return -643;
			}
			return 0;
		}

		// Token: 0x060041B9 RID: 16825 RVA: 0x00135764 File Offset: 0x00133964
		public int CanSelectSkillHero(Hero hero, List<int> skills)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanSelectSkillHeroHeroList`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanSelectSkillHeroHeroList`1_hotfix.call(new object[]
				{
					this,
					hero,
					skills
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (skills.Count > this.m_configDataLoader.ConfigableConstId_SelectSkillsMaxCount)
			{
				return -626;
			}
			int num = 0;
			foreach (int num2 in skills)
			{
				if (!hero.SkillIds.Contains(num2))
				{
					return -620;
				}
				int skillCostFromConfig = this.GetSkillCostFromConfig(num2);
				if (skillCostFromConfig == 2147483647)
				{
					return -621;
				}
				int num3 = this.CanHeroJobEquipSkill(hero.GetActiveJob().JobRelatedId, num2);
				if (num3 != 0)
				{
					return num3;
				}
				num += skillCostFromConfig;
			}
			int skillEnergyFromConfig = this.GetSkillEnergyFromConfig(hero.Level);
			if (skillEnergyFromConfig == 2147483647)
			{
				return -624;
			}
			if (num > skillEnergyFromConfig)
			{
				return -625;
			}
			HashSet<int> hashSet = new HashSet<int>();
			foreach (int item in skills)
			{
				if (!hashSet.Add(item))
				{
					return -632;
				}
			}
			return 0;
		}

		// Token: 0x060041BA RID: 16826 RVA: 0x00135948 File Offset: 0x00133B48
		public int SelectSkills(int heroId, List<int> skills)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SelectSkillsInt32List`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_SelectSkillsInt32List`1_hotfix.call(new object[]
				{
					this,
					heroId,
					skills
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.FindHero(heroId);
			if (hero == null)
			{
				return -602;
			}
			int num = this.CanSelectSkillHero(hero, skills);
			if (num != 0)
			{
				return num;
			}
			this.m_heroDS.SelectSkills(hero, skills);
			this.OnHeroBattlePowerChange(hero);
			return 0;
		}

		// Token: 0x060041BB RID: 16827 RVA: 0x00135A10 File Offset: 0x00133C10
		public int SelectSoldier(int heroId, int soldierId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SelectSoldierInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_SelectSoldierInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					soldierId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.FindHero(heroId);
			if (hero == null)
			{
				return -602;
			}
			int num = this.CanHeroSelectSolider(hero, soldierId);
			if (num != 0)
			{
				return num;
			}
			this.m_heroDS.SelectSolider(hero, soldierId);
			this.OnHeroBattlePowerChange(hero);
			return 0;
		}

		// Token: 0x060041BC RID: 16828 RVA: 0x00135AD8 File Offset: 0x00133CD8
		public int CanHeroSelectSolider(Hero hero, int soliderId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanHeroSelectSoliderHeroInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanHeroSelectSoliderHeroInt32_hotfix.call(new object[]
				{
					this,
					hero,
					soliderId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!hero.HasOwnSoldier(soliderId))
			{
				return -619;
			}
			return 0;
		}

		// Token: 0x060041BD RID: 16829 RVA: 0x00135B78 File Offset: 0x00133D78
		public int RemoveHero(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RemoveHeroInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_RemoveHeroInt32_hotfix.call(new object[]
				{
					this,
					heroId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.FindHero(heroId);
			if (hero == null)
			{
				return -602;
			}
			this.m_heroDS.RemoveHero(hero);
			return 0;
		}

		// Token: 0x060041BE RID: 16830 RVA: 0x00135C18 File Offset: 0x00133E18
		public void RemoveAllHero(List<int> changedHeroIdList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RemoveAllHeroList`1_hotfix != null)
			{
				this.m_RemoveAllHeroList`1_hotfix.call(new object[]
				{
					this,
					changedHeroIdList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (Hero hero in this.m_heroDS.GetAllHeroes())
			{
				changedHeroIdList.Add(hero.HeroId);
			}
			this.m_heroDS.RemoveAllHeros();
		}

		// Token: 0x060041BF RID: 16831 RVA: 0x00135CEC File Offset: 0x00133EEC
		public void RemoveAllHeros()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RemoveAllHeros_hotfix != null)
			{
				this.m_RemoveAllHeros_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroDS.RemoveAllHeros();
		}

		// Token: 0x060041C0 RID: 16832 RVA: 0x00135D58 File Offset: 0x00133F58
		public List<Hero> GetAllHeros()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllHeros_hotfix != null)
			{
				return (List<Hero>)this.m_GetAllHeros_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroDS.GetAllHeroes();
		}

		// Token: 0x060041C1 RID: 16833 RVA: 0x00135DD0 File Offset: 0x00133FD0
		public HeroJob FindHeroJob(Hero hero, int jobRelatedId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindHeroJobHeroInt32_hotfix != null)
			{
				return (HeroJob)this.m_FindHeroJobHeroInt32_hotfix.call(new object[]
				{
					this,
					hero,
					jobRelatedId2
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int jobRelatedId = jobRelatedId2;
			return hero.Jobs.Find((HeroJob m) => m.JobRelatedId == jobRelatedId);
		}

		// Token: 0x060041C2 RID: 16834 RVA: 0x00135E80 File Offset: 0x00134080
		public bool IsUnlockedHeroJob(Hero hero, int jobRelatedId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsUnlockedHeroJobHeroInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsUnlockedHeroJobHeroInt32_hotfix.call(new object[]
				{
					this,
					hero,
					jobRelatedId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return hero.UnlockedJobs.Contains(jobRelatedId);
		}

		// Token: 0x060041C3 RID: 16835 RVA: 0x00135F18 File Offset: 0x00134118
		private bool CanGetHeroJobByRank(Hero hero, int rank)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanGetHeroJobByRankHeroInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CanGetHeroJobByRankHeroInt32_hotfix.call(new object[]
				{
					this,
					hero,
					rank
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (HeroJob heroJob in hero.Jobs)
			{
				ConfigDataJobConnectionInfo configDataJobConnectionInfo = this.m_configDataLoader.GetConfigDataJobConnectionInfo(heroJob.JobRelatedId);
				if (configDataJobConnectionInfo.m_jobInfo.Rank == rank)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060041C4 RID: 16836 RVA: 0x0013601C File Offset: 0x0013421C
		public HeroJob FindHeroJob(int heroId, int jobRelatedId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindHeroJobInt32Int32_hotfix != null)
			{
				return (HeroJob)this.m_FindHeroJobInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					jobRelatedId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroJob result = null;
			Hero hero = this.FindHero(heroId);
			if (hero != null)
			{
				result = this.FindHeroJob(hero, jobRelatedId);
			}
			return result;
		}

		// Token: 0x060041C5 RID: 16837 RVA: 0x001360C4 File Offset: 0x001342C4
		public Hero FindHero(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindHeroInt32_hotfix != null)
			{
				return (Hero)this.m_FindHeroInt32_hotfix.call(new object[]
				{
					this,
					heroId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroDS.FindHero(heroId);
		}

		// Token: 0x060041C6 RID: 16838 RVA: 0x0013614C File Offset: 0x0013434C
		public int AddHeroFightNums(int heroId, int nums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddHeroFightNumsInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_AddHeroFightNumsInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					nums
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.FindHero(heroId);
			if (hero == null)
			{
				return -618;
			}
			this.m_heroDS.AddHeroFightNums(hero, nums);
			if (this.SpecificHeroFightMissionEvent != null)
			{
				this.SpecificHeroFightMissionEvent(heroId, nums);
			}
			return 0;
		}

		// Token: 0x060041C7 RID: 16839 RVA: 0x00136214 File Offset: 0x00134414
		public int AddHeroAllNeedJobsAchievements(int heroId, List<int> achievements)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddHeroAllNeedJobsAchievementsInt32List`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_AddHeroAllNeedJobsAchievementsInt32List`1_hotfix.call(new object[]
				{
					this,
					heroId,
					achievements
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.FindHero(heroId);
			if (hero == null)
			{
				return -618;
			}
			if (!this.m_heroDS.IsNeedAddAchievement(hero))
			{
				return 0;
			}
			foreach (int num in hero.NeedGetAchievementsJobRelatedIdList)
			{
				HeroJob heroJob = this.FindHeroJob(hero, num);
				if (heroJob != null)
				{
					ConfigDataJobConnectionInfo configDataJobConnectionInfo = this.m_configDataLoader.GetConfigDataJobConnectionInfo(num);
					List<int> unlcokJobAchievements = this.GetUnlcokJobAchievements(configDataJobConnectionInfo);
					foreach (int item in achievements)
					{
						if (unlcokJobAchievements.Contains(item))
						{
							this.m_heroDS.AddHeroJobAchievements(heroJob, achievements);
						}
					}
				}
			}
			this.m_heroDS.SetHeroDirty(hero);
			return 0;
		}

		// Token: 0x060041C8 RID: 16840 RVA: 0x001363A4 File Offset: 0x001345A4
		public int AddHero(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddHeroInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_AddHeroInt32_hotfix.call(new object[]
				{
					this,
					heroId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(heroId);
			if (configDataHeroInfo == null)
			{
				return -618;
			}
			Hero hero = this.FindHero(heroId);
			if (hero != null)
			{
				return -603;
			}
			if (this.IsProtagonistHero(heroId) && !this.IsProtagonistExist())
			{
				this.m_heroDS.SetProtagonist(this.m_configDataLoader.GetAllConfigDataProtagonistInfo().First<KeyValuePair<int, ConfigDataProtagonistInfo>>().Key);
			}
			Hero hero2 = this.AddHeroInfos(configDataHeroInfo);
			if (this.AddHeroEvent != null)
			{
				this.AddHeroEvent(heroId);
			}
			if (this.AddHeroMissionEvent != null)
			{
				this.AddHeroMissionEvent(heroId);
			}
			this.UpdateProtagonistHeroFavorabilityLevel();
			this.OnHeroBattlePowerChange(hero2);
			return 0;
		}

		// Token: 0x060041C9 RID: 16841 RVA: 0x001364CC File Offset: 0x001346CC
		private Hero AddHeroInfos(ConfigDataHeroInfo heroInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddHeroInfosConfigDataHeroInfo_hotfix != null)
			{
				return (Hero)this.m_AddHeroInfosConfigDataHeroInfo_hotfix.call(new object[]
				{
					this,
					heroInfo
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.m_heroDS.AddHero(heroInfo.ID, heroInfo.Star);
			this.AddHeroDefaultInfos(hero, heroInfo);
			this.m_trainingGround.ApplyTrainingTechToHero(hero);
			this.UpdateProtagonistHeroFavorabilityLevel();
			return hero;
		}

		// Token: 0x060041CA RID: 16842 RVA: 0x0013657C File Offset: 0x0013477C
		public bool IsWastefulAddExp(Hero hero, int addExp)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsWastefulAddExpHeroInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsWastefulAddExpHeroInt32_hotfix.call(new object[]
				{
					this,
					hero,
					addExp
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.IsCurrentLevelMaxHeroLevel(hero.Level) && this.m_configDataLoader.GetConfigDataHeroLevelInfo(hero.Level).Exp < addExp + hero.Exp;
		}

		// Token: 0x060041CB RID: 16843 RVA: 0x0013663C File Offset: 0x0013483C
		public bool IsCurrentLevelMaxHeroLevel(int heroLevel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsCurrentLevelMaxHeroLevelInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsCurrentLevelMaxHeroLevelInt32_hotfix.call(new object[]
				{
					this,
					heroLevel
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_configDataLoader.GetConfigDataHeroLevelInfo(heroLevel + 1) == null || heroLevel == this.m_basicInfo.GetLevel() + this.m_configDataLoader.ConfigableConstId_HeroLevelUpCeiling;
		}

		// Token: 0x060041CC RID: 16844 RVA: 0x001366EC File Offset: 0x001348EC
		public bool IsFullCurrentHeroExp(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsFullCurrentHeroExpHero_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsFullCurrentHeroExpHero_hotfix.call(new object[]
				{
					this,
					hero
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.IsCurrentLevelMaxHeroLevel(hero.Level) && this.m_configDataLoader.GetConfigDataHeroLevelInfo(hero.Level).Exp == hero.Exp;
		}

		// Token: 0x060041CD RID: 16845 RVA: 0x0013679C File Offset: 0x0013499C
		public void AddHeroesExp(List<int> heroIds, int exp)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddHeroesExpList`1Int32_hotfix != null)
			{
				this.m_AddHeroesExpList`1Int32_hotfix.call(new object[]
				{
					this,
					heroIds,
					exp
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (int num in heroIds)
			{
				if (num != 0 && this.CanAddHeroExp(num) == 0)
				{
					this.AddHeroExp(num, exp);
				}
			}
		}

		// Token: 0x060041CE RID: 16846 RVA: 0x0013687C File Offset: 0x00134A7C
		public int CanAddHeroExp(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAddHeroExpInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAddHeroExpInt32_hotfix.call(new object[]
				{
					this,
					heroId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.FindHero(heroId);
			if (hero == null)
			{
				return -602;
			}
			if (this.IsFullCurrentHeroExp(hero))
			{
				return -631;
			}
			return 0;
		}

		// Token: 0x060041CF RID: 16847 RVA: 0x00136920 File Offset: 0x00134B20
		public int AddHeroExp(int heroId, int exp)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddHeroExpInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_AddHeroExpInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					exp
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanAddHeroExp(heroId);
			if (num != 0)
			{
				return num;
			}
			Hero hero = this.FindHero(heroId);
			int level = hero.Level;
			int additiveHeroAddExp = this.GetAdditiveHeroAddExp(exp);
			int num2 = hero.Exp + additiveHeroAddExp;
			int exp2;
			for (;;)
			{
				exp2 = this.m_configDataLoader.GetConfigDataHeroLevelInfo(hero.Level).Exp;
				if (num2 < exp2)
				{
					break;
				}
				if (this.IsCurrentLevelMaxHeroLevel(hero.Level))
				{
					goto Block_6;
				}
				this.m_heroDS.AddHeroLevel(hero, 1);
				this.OutPutHeroLevelUpOperateLog(heroId, hero.Level);
				if (this.HeroLevelUpMissionEvent != null)
				{
					this.HeroLevelUpMissionEvent(heroId);
				}
				num2 -= exp2;
				if (num2 <= 0)
				{
					goto IL_146;
				}
			}
			this.m_heroDS.SetHeroExp(hero, num2);
			goto IL_146;
			Block_6:
			this.m_heroDS.SetHeroExp(hero, exp2);
			IL_146:
			if (hero.Level != level)
			{
				this.OnHeroLevelUp(level, hero);
			}
			return 0;
		}

		// Token: 0x060041D0 RID: 16848 RVA: 0x00136A88 File Offset: 0x00134C88
		protected virtual void OutPutHeroLevelUpOperateLog(int heroId, int currentLevel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OutPutHeroLevelUpOperateLogInt32Int32_hotfix != null)
			{
				this.m_OutPutHeroLevelUpOperateLogInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					currentLevel
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060041D1 RID: 16849 RVA: 0x00136B08 File Offset: 0x00134D08
		public int AddHeroExpByUseableBagItem(int heroId, GoodsType goodsTypeId, int contentId, int consumeNums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddHeroExpByUseableBagItemInt32GoodsTypeInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_AddHeroExpByUseableBagItemInt32GoodsTypeInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					goodsTypeId,
					contentId,
					consumeNums
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.FindHero(heroId) == null)
			{
				return -602;
			}
			return this.m_bag.UseBagItem(goodsTypeId, contentId, consumeNums, new object[]
			{
				heroId
			});
		}

		// Token: 0x060041D2 RID: 16850 RVA: 0x00136BE8 File Offset: 0x00134DE8
		public int ComposeHero(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComposeHeroInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_ComposeHeroInt32_hotfix.call(new object[]
				{
					this,
					heroId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanComposeHero(heroId);
			if (num != 0)
			{
				return 0;
			}
			num = this.AddHero(heroId);
			if (num != 0)
			{
				return num;
			}
			ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(heroId);
			ConfigDataHeroStarInfo configDataHeroStarInfo = this.m_configDataLoader.GetConfigDataHeroStarInfo(configDataHeroInfo.Star);
			this.m_basicInfo.AddGold(-configDataHeroStarInfo.Gold, GameFunctionType.GameFunctionType_HeroCompose, null);
			this.m_bag.RemoveBagItemByType(GoodsType.GoodsType_Item, configDataHeroInfo.FragmentItem_ID, configDataHeroStarInfo.Fragment, GameFunctionType.GameFunctionType_HeroCompose, heroId.ToString());
			if (this.AddHeroEvent != null)
			{
				this.AddHeroEvent(heroId);
			}
			return 0;
		}

		// Token: 0x060041D3 RID: 16851 RVA: 0x00136CFC File Offset: 0x00134EFC
		public bool IsLvlMaxHeroStar(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsLvlMaxHeroStarHero_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsLvlMaxHeroStarHero_hotfix.call(new object[]
				{
					this,
					hero
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return hero.StarLevel >= this.m_configDataLoader.ConfigableConstId_HeroStarLevelMax;
		}

		// Token: 0x060041D4 RID: 16852 RVA: 0x00136D90 File Offset: 0x00134F90
		public int LevelUpHeroStarLevel(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LevelUpHeroStarLevelInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_LevelUpHeroStarLevelInt32_hotfix.call(new object[]
				{
					this,
					heroId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.FindHero(heroId);
			if (hero == null)
			{
				return -602;
			}
			ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(hero.HeroId);
			if (configDataHeroInfo == null)
			{
				return -618;
			}
			if (this.IsLvlMaxHeroStar(hero))
			{
				return -630;
			}
			List<Goods> heroStarLevelUpDataFromConfig = this.GetHeroStarLevelUpDataFromConfig(configDataHeroInfo.FragmentItem_ID, hero.StarLevel + 1);
			if (heroStarLevelUpDataFromConfig.Count == 0)
			{
				return -610;
			}
			List<BagItemBase> bagItemsInBag = null;
			int num = this.m_bag.IsGoodsEnough(heroStarLevelUpDataFromConfig, out bagItemsInBag);
			if (num != 0)
			{
				return num;
			}
			this.m_bag.ConsumeGoods(heroStarLevelUpDataFromConfig, bagItemsInBag, null, GameFunctionType.GameFunctionType_HeroUpgrade, heroId.ToString());
			this.m_heroDS.AddHeroStarLevel(hero, 1);
			this.OutPutHeroUpgradeOperateLog(hero.HeroId, hero.StarLevel, heroStarLevelUpDataFromConfig);
			if (this.LevelUpHeroStarLevelMissionEvent != null)
			{
				this.LevelUpHeroStarLevelMissionEvent(heroId);
			}
			this.OnHeroBattlePowerChange(hero);
			return 0;
		}

		// Token: 0x060041D5 RID: 16853 RVA: 0x00136EF0 File Offset: 0x001350F0
		protected virtual void OutPutHeroUpgradeOperateLog(int heroId, int currentStar, List<Goods> costItems)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OutPutHeroUpgradeOperateLogInt32Int32List`1_hotfix != null)
			{
				this.m_OutPutHeroUpgradeOperateLogInt32Int32List`1_hotfix.call(new object[]
				{
					this,
					heroId,
					currentStar,
					costItems
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060041D6 RID: 16854 RVA: 0x00136F80 File Offset: 0x00135180
		public HashSet<int> GetGainHeroIds()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetGainHeroIds_hotfix != null)
			{
				return (HashSet<int>)this.m_GetGainHeroIds_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroDS.GainHeroIds;
		}

		// Token: 0x060041D7 RID: 16855 RVA: 0x00136FF8 File Offset: 0x001351F8
		public bool HasGainHero(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasGainHeroInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasGainHeroInt32_hotfix.call(new object[]
				{
					this,
					heroId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroDS.GainHeroIds.Contains(heroId);
		}

		// Token: 0x060041D8 RID: 16856 RVA: 0x00137088 File Offset: 0x00135288
		public bool IsExistSkillId(int skillId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsExistSkillIdInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsExistSkillIdInt32_hotfix.call(new object[]
				{
					this,
					skillId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_skills.Contains(skillId);
		}

		// Token: 0x060041D9 RID: 16857 RVA: 0x00137110 File Offset: 0x00135310
		public bool IsExistSoliderId(int soliderId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsExistSoliderIdInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsExistSoliderIdInt32_hotfix.call(new object[]
				{
					this,
					soliderId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_soliders.Contains(soliderId);
		}

		// Token: 0x060041DA RID: 16858 RVA: 0x00137198 File Offset: 0x00135398
		public LinkedList<Hero> FindTopLevelHeroes(int topNums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindTopLevelHeroesInt32_hotfix != null)
			{
				return (LinkedList<Hero>)this.m_FindTopLevelHeroesInt32_hotfix.call(new object[]
				{
					this,
					topNums
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LinkedList<Hero> linkedList = new LinkedList<Hero>();
			List<Hero> allHeros = this.GetAllHeros();
			using (List<Hero>.Enumerator enumerator = allHeros.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Hero hero = enumerator.Current;
					if (linkedList.Count >= topNums)
					{
						if (hero.Level > allHeros.Last<Hero>().Level)
						{
							linkedList.AddAfterFromLast(hero, (Hero m) => m.Level >= hero.Level);
							linkedList.RemoveLast();
						}
					}
					else
					{
						linkedList.AddAfterFromLast(hero, (Hero m) => m.Level >= hero.Level);
					}
				}
			}
			return linkedList;
		}

		// Token: 0x060041DB RID: 16859 RVA: 0x001372D4 File Offset: 0x001354D4
		public int GetActiveHeroJobRelatedIdByHeroId(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetActiveHeroJobRelatedIdByHeroIdInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetActiveHeroJobRelatedIdByHeroIdInt32_hotfix.call(new object[]
				{
					this,
					heroId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.FindHero(heroId);
			return hero.ActiveHeroJobRelatedId;
		}

		// Token: 0x060041DC RID: 16860 RVA: 0x00137360 File Offset: 0x00135560
		public int GmResetHeroJob(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GmResetHeroJobInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GmResetHeroJobInt32_hotfix.call(new object[]
				{
					this,
					heroId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.FindHero(heroId);
			if (hero == null)
			{
				return -305;
			}
			this.m_soliders.RemoveWhere((int t) => hero.HasOwnSoldier(t));
			this.m_skills.RemoveWhere((int t) => hero.SkillIds.Contains(t));
			foreach (ulong key in hero.EquipmentIds)
			{
				if (this.m_wearedEquipmentHeroDict.ContainsKey(key))
				{
					this.m_wearedEquipmentHeroDict.Remove(key);
				}
			}
			ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(heroId);
			Hero hero2 = HeroComponentCommon.CreateDefaultConfigHero(configDataHeroInfo);
			this.m_heroDS.ReplaceHero(hero, hero2);
			this.OnHeroBattlePowerChange(hero2);
			return 0;
		}

		// Token: 0x060041DD RID: 16861 RVA: 0x001374A8 File Offset: 0x001356A8
		public static Hero CreateDefaultConfigHero(ConfigDataHeroInfo heroInfo)
		{
			if (heroInfo == null)
			{
				return null;
			}
			Hero hero = new Hero();
			hero.HeroId = heroInfo.ID;
			hero.ActiveHeroJobRelatedId = heroInfo.JobConnection_ID;
			hero.Level = 1;
			hero.Exp = 0;
			hero.FavorabilityLevel = 1;
			hero.StarLevel = heroInfo.Star;
			HeroJob heroJob = new HeroJob();
			heroJob.JobRelatedId = heroInfo.JobConnection_ID;
			heroJob.JobLevel = 0;
			hero.Jobs.Add(heroJob);
			hero.SelectedSoldierId = heroInfo.Soldier_ID;
			int num = 0;
			while (num < heroInfo.Skills_ID.Count && num < 3)
			{
				hero.SelectedSkills.Add(heroInfo.Skills_ID[num]);
				num++;
			}
			return hero;
		}

		// Token: 0x060041DE RID: 16862 RVA: 0x00137568 File Offset: 0x00135768
		protected virtual void OnHeroLevelUp(int oldLevel, Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeroLevelUpInt32Hero_hotfix != null)
			{
				this.m_OnHeroLevelUpInt32Hero_hotfix.call(new object[]
				{
					this,
					oldLevel,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.OnHeroBattlePowerChange(hero);
		}

		// Token: 0x060041DF RID: 16863 RVA: 0x001375F0 File Offset: 0x001357F0
		public int GetAdditiveHeroAddExp(int addExp)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAdditiveHeroAddExpInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetAdditiveHeroAddExpInt32_hotfix.call(new object[]
				{
					this,
					addExp
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			foreach (MonthCard monthCard in this.m_resource.GetAllValidMonthCards())
			{
				ConfigDataMonthCardInfo configDataMonthCardInfo = this.m_configDataLoader.GetConfigDataMonthCardInfo(monthCard.CardId);
				if (configDataMonthCardInfo != null && configDataMonthCardInfo.HeroExpAddRate != 0)
				{
					num += configDataMonthCardInfo.HeroExpAddRate;
				}
			}
			if (num == 0)
			{
				return addExp;
			}
			return (int)(((double)num * 1.0 / (double)this.m_configDataLoader.ConfigableConstId_GainMaximum + 1.0) * (double)addExp);
		}

		// Token: 0x060041E0 RID: 16864 RVA: 0x00137718 File Offset: 0x00135918
		public int GetAdditiveHeroFavourabilityAddExp(int addExp)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAdditiveHeroFavourabilityAddExpInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetAdditiveHeroFavourabilityAddExpInt32_hotfix.call(new object[]
				{
					this,
					addExp
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			foreach (MonthCard monthCard in this.m_resource.GetAllValidMonthCards())
			{
				ConfigDataMonthCardInfo configDataMonthCardInfo = this.m_configDataLoader.GetConfigDataMonthCardInfo(monthCard.CardId);
				if (configDataMonthCardInfo != null && configDataMonthCardInfo.HeroFavourabilityExpAddRate != 0)
				{
					num += configDataMonthCardInfo.HeroFavourabilityExpAddRate;
				}
			}
			if (num == 0)
			{
				return addExp;
			}
			return (int)(((double)num * 1.0 / (double)this.m_configDataLoader.ConfigableConstId_GainMaximum + 1.0) * (double)addExp);
		}

		// Token: 0x060041E1 RID: 16865 RVA: 0x00137840 File Offset: 0x00135A40
		public void AddHeroJobAchievementsAfterBattleLevelEnd(List<int> relatedAchievements, List<int> fightHeroes)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddHeroJobAchievementsAfterBattleLevelEndList`1List`1_hotfix != null)
			{
				this.m_AddHeroJobAchievementsAfterBattleLevelEndList`1List`1_hotfix.call(new object[]
				{
					this,
					relatedAchievements,
					fightHeroes
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<int> list = new List<int>();
			foreach (int key in relatedAchievements)
			{
				ConfigDataBattleAchievementRelatedInfo configDataBattleAchievementRelatedInfo = this.m_configDataLoader.GetConfigDataBattleAchievementRelatedInfo(key);
				if (configDataBattleAchievementRelatedInfo != null)
				{
					list.Add(configDataBattleAchievementRelatedInfo.Achievement_ID);
				}
			}
			if (list.Count != 0)
			{
				foreach (int num in fightHeroes)
				{
					if (num != 0)
					{
						this.AddHeroAllNeedJobsAchievements(num, list);
					}
				}
			}
		}

		// Token: 0x060041E2 RID: 16866 RVA: 0x00137990 File Offset: 0x00135B90
		private void AddHeroJob(Hero hero, ConfigDataJobConnectionInfo jobConnectionInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddHeroJobHeroConfigDataJobConnectionInfo_hotfix != null)
			{
				this.m_AddHeroJobHeroConfigDataJobConnectionInfo_hotfix.call(new object[]
				{
					this,
					hero,
					jobConnectionInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataJobLevelInfo configDataJobLevelInfo = jobConnectionInfo.m_jobLevelInfos[this.m_configDataLoader.ConfigableConstId_JobStartLeve];
			this.AddSkill(hero, configDataJobLevelInfo.GotSkill_ID);
			this.AddSoldier(hero, configDataJobLevelInfo.GotSoldier_ID, true);
			this.m_heroDS.AddHeroJob(hero, jobConnectionInfo.ID);
			if (this.AddHeroJobSkillMissionEvent != null)
			{
				this.AddHeroJobSkillMissionEvent(configDataJobLevelInfo.GotSkill_ID);
			}
			if (this.AddHeroJobSoliderMissionEvent != null)
			{
				this.AddHeroJobSoliderMissionEvent(configDataJobLevelInfo.GotSoldier_ID);
			}
			if (this.AddHeroJobMissionEvent != null)
			{
				this.AddHeroJobMissionEvent();
			}
		}

		// Token: 0x060041E3 RID: 16867 RVA: 0x00137AA0 File Offset: 0x00135CA0
		public bool IsJobLevelMax(ConfigDataJobConnectionInfo jobConnectionInfo, int jobLevel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsJobLevelMaxConfigDataJobConnectionInfoInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsJobLevelMaxConfigDataJobConnectionInfoInt32_hotfix.call(new object[]
				{
					this,
					jobConnectionInfo,
					jobLevel
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return jobConnectionInfo.JobLevels_ID.Count - 1 == jobLevel;
		}

		// Token: 0x060041E4 RID: 16868 RVA: 0x00137B44 File Offset: 0x00135D44
		public bool IsJobLevelMax(HeroJob job)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsJobLevelMaxHeroJob_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsJobLevelMaxHeroJob_hotfix.call(new object[]
				{
					this,
					job
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = this.m_configDataLoader.GetConfigDataJobConnectionInfo(job.JobRelatedId);
			return this.IsJobLevelMax(configDataJobConnectionInfo, job.JobLevel);
		}

		// Token: 0x060041E5 RID: 16869 RVA: 0x00137BE0 File Offset: 0x00135DE0
		public int CanLevelUpHeroJobLevel(int heroId, int jobRelatedId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanLevelUpHeroJobLevelInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanLevelUpHeroJobLevelInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					jobRelatedId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.FindHero(heroId);
			if (hero == null)
			{
				return -602;
			}
			HeroJob heroJob = this.FindHeroJob(hero, jobRelatedId);
			if (heroJob == null)
			{
				return -601;
			}
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = this.m_configDataLoader.GetConfigDataJobConnectionInfo(jobRelatedId);
			if (this.IsJobLevelMax(configDataJobConnectionInfo, heroJob.JobLevel))
			{
				return -612;
			}
			ConfigDataJobLevelInfo configDataJobLevelInfo = configDataJobConnectionInfo.m_jobLevelInfos[heroJob.JobLevel];
			if (configDataJobLevelInfo.JobLevelUpHeroLevel > hero.Level)
			{
				return -623;
			}
			List<BagItemBase> list;
			int num = this.m_bag.IsGoodsEnough(configDataJobLevelInfo.Materials, out list);
			if (num != 0)
			{
				return num;
			}
			return 0;
		}

		// Token: 0x060041E6 RID: 16870 RVA: 0x00137D00 File Offset: 0x00135F00
		private bool CanTransferHeroJobRank(int jobRank, int CanTransferMaxRank)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanTransferHeroJobRankInt32Int32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CanTransferHeroJobRankInt32Int32_hotfix.call(new object[]
				{
					this,
					jobRank,
					CanTransferMaxRank
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return jobRank != 0 && jobRank <= CanTransferMaxRank;
		}

		// Token: 0x060041E7 RID: 16871 RVA: 0x00137D9C File Offset: 0x00135F9C
		public int CanTransferHeroJob(int heroId, int jobRelatedId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanTransferHeroJobInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanTransferHeroJobInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					jobRelatedId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.FindHero(heroId);
			if (hero == null)
			{
				return -602;
			}
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = this.m_configDataLoader.GetConfigDataJobConnectionInfo(jobRelatedId);
			if (configDataJobConnectionInfo == null)
			{
				return -615;
			}
			if (!configDataJobConnectionInfo.IsJobOpen)
			{
				return -679;
			}
			bool flag = false;
			HeroJob heroJob = null;
			if (configDataJobConnectionInfo.m_preJobConnectionInfos.Count != 0)
			{
				foreach (ConfigDataJobConnectionInfo configDataJobConnectionInfo2 in configDataJobConnectionInfo.m_preJobConnectionInfos)
				{
					heroJob = this.FindHeroJob(hero, configDataJobConnectionInfo2.ID);
					if (heroJob != null && this.IsJobLevelMax(heroJob))
					{
						flag = true;
						break;
					}
				}
				if (heroJob == null)
				{
					return -636;
				}
				if (!flag)
				{
					return -650;
				}
			}
			ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(heroId);
			if (this.FindHeroJob(hero, jobRelatedId) == null)
			{
				List<int> list = new List<int>(configDataHeroInfo.UseableJobConnections_ID);
				if (this.IsProtagonistHero(heroId))
				{
					ConfigDataProtagonistInfo configDataProtagonistInfo = this.m_configDataLoader.GetConfigDataProtagonistInfo(this.m_heroDS.ProtagonistID);
					if (configDataProtagonistInfo != null)
					{
						list.Clear();
						list.AddRange(configDataProtagonistInfo.UseableJobConnections_ID);
					}
				}
				if (!list.Contains(jobRelatedId))
				{
					return -634;
				}
				if (!this.CanTransferHeroJobRank(configDataJobConnectionInfo.m_jobInfo.Rank, hero.CanTransferMaxRank))
				{
					return -617;
				}
				if (!this.CanGetHeroJobByRank(hero, configDataJobConnectionInfo.m_jobInfo.Rank))
				{
					if (configDataJobConnectionInfo.m_unlockConditions.Count != 0 && !hero.UnlockedJobs.Contains(jobRelatedId))
					{
						return -637;
					}
				}
				else
				{
					int nums = 1;
					if (!this.m_bag.IsBagItemEnough(GoodsType.GoodsType_Item, this.m_configDataLoader.ConfigableConstId_MagicStoneId, nums))
					{
						return -501;
					}
				}
			}
			else if (hero.ActiveHeroJobRelatedId == jobRelatedId)
			{
				return -633;
			}
			if (!this.m_basicInfo.IsGoldEnough(configDataJobConnectionInfo.m_jobInfo.ChangeJobGold))
			{
				return -400;
			}
			return 0;
		}

		// Token: 0x060041E8 RID: 16872 RVA: 0x0013804C File Offset: 0x0013624C
		public int TransferHeroJob(int heroId, int jobRelatedId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TransferHeroJobInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_TransferHeroJobInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					jobRelatedId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanTransferHeroJob(heroId, jobRelatedId);
			if (num != 0)
			{
				return num;
			}
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = this.m_configDataLoader.GetConfigDataJobConnectionInfo(jobRelatedId);
			Hero hero = this.FindHero(heroId);
			int activeHeroJobRelatedId = hero.ActiveHeroJobRelatedId;
			List<Goods> list = new List<Goods>();
			HeroJob heroJob = this.FindHeroJob(hero, jobRelatedId);
			int jobLevel;
			if (heroJob == null)
			{
				jobLevel = this.m_configDataLoader.ConfigableConstId_JobStartLeve;
				if (this.CanGetHeroJobByRank(hero, configDataJobConnectionInfo.m_jobInfo.Rank))
				{
					list.Add(new Goods
					{
						GoodsType = GoodsType.GoodsType_Item,
						Id = this.m_configDataLoader.ConfigableConstId_MagicStoneId,
						Count = 1
					});
				}
				this.AddHeroJob(hero, configDataJobConnectionInfo);
				if (this.HeroNewJobTransferMissionEvent != null)
				{
					this.HeroNewJobTransferMissionEvent(heroId, jobRelatedId);
				}
			}
			else
			{
				jobLevel = heroJob.JobLevel;
			}
			list.Add(new Goods
			{
				GoodsType = GoodsType.GoodsType_Gold,
				Count = configDataJobConnectionInfo.m_jobInfo.ChangeJobGold
			});
			this.m_bag.ConsumeGoods(list, null, null, GameFunctionType.GameFunctionType_HeroJobChange, jobRelatedId.ToString());
			this.OnTransferHeroJob(hero, configDataJobConnectionInfo, jobLevel);
			this.TakeOffEquipmentsOrNotWhenTransferHeroJob(hero);
			this.OutPutHeroJobChangeOperateLog(heroId, activeHeroJobRelatedId, jobRelatedId, list);
			this.OnHeroBattlePowerChange(hero);
			return 0;
		}

		// Token: 0x060041E9 RID: 16873 RVA: 0x0013820C File Offset: 0x0013640C
		protected virtual void OutPutHeroJobChangeOperateLog(int heroId, int preJobConnectionId, int postJobConnectionId, List<Goods> costItems)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OutPutHeroJobChangeOperateLogInt32Int32Int32List`1_hotfix != null)
			{
				this.m_OutPutHeroJobChangeOperateLogInt32Int32Int32List`1_hotfix.call(new object[]
				{
					this,
					heroId,
					preJobConnectionId,
					postJobConnectionId,
					costItems
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060041EA RID: 16874 RVA: 0x001382AC File Offset: 0x001364AC
		private void OnTransferHeroJob(Hero hero, ConfigDataJobConnectionInfo jobConnectionInfo, int jobLevel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTransferHeroJobHeroConfigDataJobConnectionInfoInt32_hotfix != null)
			{
				this.m_OnTransferHeroJobHeroConfigDataJobConnectionInfoInt32_hotfix.call(new object[]
				{
					this,
					hero,
					jobConnectionInfo,
					jobLevel
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroDS.ActiveHeroJob(hero, jobConnectionInfo.ID);
			List<int> list = new List<int>();
			foreach (int num in hero.SelectedSkills)
			{
				if (this.CanHeroJobEquipSkill(jobConnectionInfo.ID, num) == 0)
				{
					list.Add(num);
				}
			}
			if (list.Count != hero.SelectedSkills.Count)
			{
				this.SelectSkills(hero.HeroId, list);
			}
			this.TryEquipNewSkill(hero, jobConnectionInfo.m_jobLevelInfos[jobLevel].GotSkill_ID);
		}

		// Token: 0x060041EB RID: 16875 RVA: 0x001383F4 File Offset: 0x001365F4
		private void TryEquipNewSkill(Hero hero, int newGotSkillId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TryEquipNewSkillHeroInt32_hotfix != null)
			{
				this.m_TryEquipNewSkillHeroInt32_hotfix.call(new object[]
				{
					this,
					hero,
					newGotSkillId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<int> list = new List<int>(hero.SelectedSkills);
			if (newGotSkillId == 0 || list.Contains(newGotSkillId))
			{
				return;
			}
			list.Add(newGotSkillId);
			this.SelectSkills(hero.HeroId, list);
		}

		// Token: 0x060041EC RID: 16876 RVA: 0x001384A8 File Offset: 0x001366A8
		public bool IsNeedUnlock(ConfigDataJobConnectionInfo jobConnectionInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedUnlockConfigDataJobConnectionInfo_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedUnlockConfigDataJobConnectionInfo_hotfix.call(new object[]
				{
					this,
					jobConnectionInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return jobConnectionInfo.m_unlockConditions.Count != 0;
		}

		// Token: 0x060041ED RID: 16877 RVA: 0x00138538 File Offset: 0x00136738
		private bool IsNeedAddAchievement(ConfigDataJobConnectionInfo jobConnectionInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedAddAchievementConfigDataJobConnectionInfo_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedAddAchievementConfigDataJobConnectionInfo_hotfix.call(new object[]
				{
					this,
					jobConnectionInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsNeedUnlock(jobConnectionInfo))
			{
				if (jobConnectionInfo.m_unlockConditions.Find((ConfigDataJobUnlockConditionInfo t) => t.AchievementID != 0) != null)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060041EE RID: 16878 RVA: 0x001385F0 File Offset: 0x001367F0
		public int UnlockedHeroJob(int heroId, int jobRelatedId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UnlockedHeroJobInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_UnlockedHeroJobInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					jobRelatedId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.FindHero(heroId);
			if (hero == null)
			{
				return -602;
			}
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = this.m_configDataLoader.GetConfigDataJobConnectionInfo(jobRelatedId);
			if (configDataJobConnectionInfo == null)
			{
				return -615;
			}
			if (!this.IsNeedUnlock(configDataJobConnectionInfo))
			{
				return -641;
			}
			if (this.IsUnlockedHeroJob(hero, jobRelatedId))
			{
				return -638;
			}
			int num = this.CanUnlockedHeroJob(hero, configDataJobConnectionInfo);
			if (num != 0)
			{
				return num;
			}
			List<Goods> list = new List<Goods>();
			foreach (ConfigDataJobUnlockConditionInfo configDataJobUnlockConditionInfo in configDataJobConnectionInfo.m_unlockConditions)
			{
				list.AddRange(new List<Goods>(configDataJobUnlockConditionInfo.ItemCost));
			}
			this.m_bag.ConsumeGoods(list, null, null, GameFunctionType.GameFunctionType_JobUnlock, jobRelatedId.ToString());
			this.m_heroDS.UnlockHeroJob(hero, jobRelatedId);
			return 0;
		}

		// Token: 0x060041EF RID: 16879 RVA: 0x0013876C File Offset: 0x0013696C
		protected virtual void OutPutHeroJobUnlockOperateLog(int heroId, int activeJobId, int unlockJobId, List<Goods> costItems)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OutPutHeroJobUnlockOperateLogInt32Int32Int32List`1_hotfix != null)
			{
				this.m_OutPutHeroJobUnlockOperateLogInt32Int32Int32List`1_hotfix.call(new object[]
				{
					this,
					heroId,
					activeJobId,
					unlockJobId,
					costItems
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060041F0 RID: 16880 RVA: 0x0013880C File Offset: 0x00136A0C
		private int CanUnlockedHeroJob(Hero hero, ConfigDataJobConnectionInfo jobConnectionInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanUnlockedHeroJobHeroConfigDataJobConnectionInfo_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanUnlockedHeroJobHeroConfigDataJobConnectionInfo_hotfix.call(new object[]
				{
					this,
					hero,
					jobConnectionInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HashSet<int> hashSet = new HashSet<int>();
			List<Goods> list = new List<Goods>();
			foreach (ConfigDataJobUnlockConditionInfo configDataJobUnlockConditionInfo in jobConnectionInfo.m_unlockConditions)
			{
				if (configDataJobUnlockConditionInfo.AchievementID != 0)
				{
					hashSet.Add(configDataJobUnlockConditionInfo.AchievementID);
				}
				list.AddRange(new List<Goods>(configDataJobUnlockConditionInfo.ItemCost));
			}
			if (hashSet.Count == 0 && list.Count == 0)
			{
				return 0;
			}
			List<BagItemBase> list2;
			int num = this.m_bag.IsGoodsEnough(list, out list2);
			if (num != 0)
			{
				return num;
			}
			bool flag = true;
			bool flag2 = false;
			foreach (int jobRelatedId in jobConnectionInfo.PreJobConnectionList)
			{
				HeroJob heroJob = this.FindHeroJob(hero, jobRelatedId);
				if (heroJob != null)
				{
					foreach (int item in hashSet)
					{
						if (!heroJob.Achievements.Contains(item))
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						return 0;
					}
					flag2 = true;
				}
			}
			if (!flag2)
			{
				return -642;
			}
			return -640;
		}

		// Token: 0x060041F1 RID: 16881 RVA: 0x00138A30 File Offset: 0x00136C30
		public int LevelUpHeroJobLevel(int heroId, int jobRelatedId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LevelUpHeroJobLevelInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_LevelUpHeroJobLevelInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					jobRelatedId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanLevelUpHeroJobLevel(heroId, jobRelatedId);
			if (num != 0)
			{
				return num;
			}
			Hero hero = this.FindHero(heroId);
			HeroJob heroJob = this.FindHeroJob(hero, jobRelatedId);
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = this.m_configDataLoader.GetConfigDataJobConnectionInfo(jobRelatedId);
			ConfigDataJobLevelInfo configDataJobLevelInfo = configDataJobConnectionInfo.m_jobLevelInfos[heroJob.JobLevel];
			this.m_bag.ConsumeGoods(configDataJobLevelInfo.Materials, null, null, GameFunctionType.GameFunctionType_HeroJobLevelUp, jobRelatedId.ToString());
			int num2 = heroJob.JobLevel + 1;
			ConfigDataJobLevelInfo configDataJobLevelInfo2 = configDataJobConnectionInfo.m_jobLevelInfos[num2];
			if (this.IsJobLevelMax(configDataJobConnectionInfo, num2))
			{
				ConfigDataJobInfo jobInfo = configDataJobConnectionInfo.m_jobInfo;
				int num3 = jobInfo.Rank + 1;
				if (num3 > hero.CanTransferMaxRank)
				{
					hero.CanTransferMaxRank = num3;
				}
			}
			this.AddSkill(hero, configDataJobLevelInfo2.GotSkill_ID);
			this.AddSoldier(hero, configDataJobLevelInfo2.GotSoldier_ID, true);
			this.TryEquipNewSkill(hero, configDataJobLevelInfo2.GotSkill_ID);
			this.m_heroDS.LevelUpHeroJobLevel(hero, heroJob);
			if (this.HeroJobLevelUpMissionEvent != null)
			{
				this.HeroJobLevelUpMissionEvent();
			}
			if (this.IsJobLevelMax(heroJob) && this.HeroJobMasterMissionEvent != null)
			{
				this.HeroJobMasterMissionEvent(heroId, heroJob.JobRelatedId);
			}
			this.OnHeroBattlePowerChange(hero);
			this.OutPutHeroJobLevelUpOperateLog(heroId, jobRelatedId, heroJob.JobLevel, configDataJobLevelInfo.Materials);
			return 0;
		}

		// Token: 0x060041F2 RID: 16882 RVA: 0x00138BFC File Offset: 0x00136DFC
		protected virtual void OutPutHeroJobLevelUpOperateLog(int heroId, int activeJobId, int currentLevel, List<Goods> costItems)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OutPutHeroJobLevelUpOperateLogInt32Int32Int32List`1_hotfix != null)
			{
				this.m_OutPutHeroJobLevelUpOperateLogInt32Int32Int32List`1_hotfix.call(new object[]
				{
					this,
					heroId,
					activeJobId,
					currentLevel,
					costItems
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060041F3 RID: 16883 RVA: 0x00138C9C File Offset: 0x00136E9C
		private void AddSkill(Hero hero, int skillId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddSkillHeroInt32_hotfix != null)
			{
				this.m_AddSkillHeroInt32_hotfix.call(new object[]
				{
					this,
					hero,
					skillId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_skills.Add(skillId);
			if (skillId != 0 && !hero.SkillIds.Contains(skillId))
			{
				this.m_heroDS.AddSkill(hero, skillId);
			}
		}

		// Token: 0x060041F4 RID: 16884 RVA: 0x00138D50 File Offset: 0x00136F50
		public void AddSoldier(Hero hero, int soldierId, bool needExchange = true)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddSoldierHeroInt32Boolean_hotfix != null)
			{
				this.m_AddSoldierHeroInt32Boolean_hotfix.call(new object[]
				{
					this,
					hero,
					soldierId,
					needExchange
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_soliders.Add(soldierId);
			if (soldierId != 0 && !hero.HasOwnSoldier(soldierId))
			{
				if (needExchange)
				{
					int selectedSoldierId = hero.SelectedSoldierId;
					ConfigDataSoldierInfo configDataSoldierInfo = this.m_configDataLoader.GetConfigDataSoldierInfo(selectedSoldierId);
					ConfigDataSoldierInfo configDataSoldierInfo2 = this.m_configDataLoader.GetConfigDataSoldierInfo(soldierId);
					if (configDataSoldierInfo != null && configDataSoldierInfo2 != null && configDataSoldierInfo2.Rank > configDataSoldierInfo.Rank)
					{
						this.m_heroDS.SelectSolider(hero, soldierId);
					}
				}
				this.m_heroDS.AddSoldier(hero, soldierId);
			}
		}

		// Token: 0x060041F5 RID: 16885 RVA: 0x00138E60 File Offset: 0x00137060
		public int AutoTakeOffEquipments(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AutoTakeOffEquipmentsInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_AutoTakeOffEquipmentsInt32_hotfix.call(new object[]
				{
					this,
					heroId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.FindHero(heroId);
			if (hero == null)
			{
				return -602;
			}
			for (int i = 0; i < hero.EquipmentIds.Length; i++)
			{
				ulong num = hero.EquipmentIds[i];
				if (num != 0UL)
				{
					this.m_wearedEquipmentHeroDict.Remove(num);
					hero.EquipmentIds[i] = 0UL;
				}
			}
			this.m_heroDS.SetHeroDirty(hero);
			this.OnHeroBattlePowerChange(hero);
			return 0;
		}

		// Token: 0x060041F6 RID: 16886 RVA: 0x00138F50 File Offset: 0x00137150
		protected void InitWearedEquipments()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitWearedEquipments_hotfix != null)
			{
				this.m_InitWearedEquipments_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (Hero hero in this.GetAllHeros())
			{
				foreach (ulong num in hero.EquipmentIds)
				{
					if (num != 0UL)
					{
						this.m_wearedEquipmentHeroDict.Add(num, hero.HeroId);
					}
				}
			}
		}

		// Token: 0x060041F7 RID: 16887 RVA: 0x00139038 File Offset: 0x00137238
		public int CanWearEquipment(int heroId, ulong instanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanWearEquipmentInt32UInt64_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanWearEquipmentInt32UInt64_hotfix.call(new object[]
				{
					this,
					heroId,
					instanceId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.FindHero(heroId);
			if (hero == null)
			{
				return -602;
			}
			BagItemBase bagItemBase = this.m_bag.FindBagItemByInstanceId(instanceId);
			if (bagItemBase == null)
			{
				return -502;
			}
			if (!bagItemBase.IsThisGoodsType(GoodsType.GoodsType_Equipment))
			{
				return -509;
			}
			if (!this.m_bag.CanWearEquipmentByEquipmentType(bagItemBase))
			{
				return -651;
			}
			return this.CanWearEquipmentByJobAndArmy(hero, bagItemBase);
		}

		// Token: 0x060041F8 RID: 16888 RVA: 0x00139124 File Offset: 0x00137324
		public int CanWearEquipmentByJobAndArmy(Hero hero, BagItemBase equipment)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanWearEquipmentByJobAndArmyHeroBagItemBase_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanWearEquipmentByJobAndArmyHeroBagItemBase_hotfix.call(new object[]
				{
					this,
					hero,
					equipment
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataEquipmentInfo configDataEquipmentInfo = this.m_configDataLoader.GetConfigDataEquipmentInfo(equipment.ContentId);
			ConfigDataJobInfo jobInfo = this.m_configDataLoader.GetConfigDataJobConnectionInfo(hero.ActiveHeroJobRelatedId).m_jobInfo;
			if (configDataEquipmentInfo.JobIds.Contains(-1) || configDataEquipmentInfo.ArmyIds.Contains(-1))
			{
				return -526;
			}
			if (configDataEquipmentInfo.JobIds.Contains(jobInfo.ID) || configDataEquipmentInfo.ArmyIds.Contains(jobInfo.Army_ID) || configDataEquipmentInfo.ArmyIds.Count == 0)
			{
				return 0;
			}
			if (!configDataEquipmentInfo.ArmyIds.Contains(jobInfo.Army_ID))
			{
				return -647;
			}
			return -648;
		}

		// Token: 0x060041F9 RID: 16889 RVA: 0x00139260 File Offset: 0x00137460
		public bool IsEquipmentWeared(ulong instanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsEquipmentWearedUInt64_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsEquipmentWearedUInt64_hotfix.call(new object[]
				{
					this,
					instanceId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_wearedEquipmentHeroDict.ContainsKey(instanceId);
		}

		// Token: 0x060041FA RID: 16890 RVA: 0x001392E8 File Offset: 0x001374E8
		public Hero GetWearedEquipmentHero(ulong instanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetWearedEquipmentHeroUInt64_hotfix != null)
			{
				return (Hero)this.m_GetWearedEquipmentHeroUInt64_hotfix.call(new object[]
				{
					this,
					instanceId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int heroId = 0;
			this.m_wearedEquipmentHeroDict.TryGetValue(instanceId, out heroId);
			return this.FindHero(heroId);
		}

		// Token: 0x060041FB RID: 16891 RVA: 0x0013937C File Offset: 0x0013757C
		private void TakeOffEquipmentsOrNotWhenTransferHeroJob(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TakeOffEquipmentsOrNotWhenTransferHeroJobHero_hotfix != null)
			{
				this.m_TakeOffEquipmentsOrNotWhenTransferHeroJobHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			for (int i = 0; i < hero.EquipmentIds.Length; i++)
			{
				ulong num = hero.EquipmentIds[i];
				if (num != 0UL)
				{
					BagItemBase bagItemBase = this.m_bag.FindBagItemByInstanceId(num);
					if (bagItemBase != null)
					{
						if (this.CanWearEquipmentByJobAndArmy(hero, bagItemBase) != 0)
						{
							this.TakeOffEquipmentBySlot(hero, i);
						}
					}
				}
			}
		}

		// Token: 0x060041FC RID: 16892 RVA: 0x00139448 File Offset: 0x00137648
		public int WearEquipment(int heroId, ulong instanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WearEquipmentInt32UInt64_hotfix != null)
			{
				return Convert.ToInt32(this.m_WearEquipmentInt32UInt64_hotfix.call(new object[]
				{
					this,
					heroId,
					instanceId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanWearEquipment(heroId, instanceId);
			if (num != 0)
			{
				return num;
			}
			Hero hero = this.FindHero(heroId);
			BagItemBase bagItemBase = this.m_bag.FindBagItemByInstanceId(instanceId);
			ConfigDataEquipmentInfo configDataEquipmentInfo = this.m_configDataLoader.GetConfigDataEquipmentInfo(bagItemBase.ContentId);
			int equipmentType = (int)configDataEquipmentInfo.EquipmentType;
			this.WearEquipmentBySlot(hero, equipmentType, instanceId);
			this.OnHeroBattlePowerChange(hero);
			return 0;
		}

		// Token: 0x060041FD RID: 16893 RVA: 0x00139528 File Offset: 0x00137728
		protected void WearEquipmentBySlot(Hero hero, int slot, ulong instanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WearEquipmentBySlotHeroInt32UInt64_hotfix != null)
			{
				this.m_WearEquipmentBySlotHeroInt32UInt64_hotfix.call(new object[]
				{
					this,
					hero,
					slot,
					instanceId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ulong num = hero.EquipmentIds[slot];
			if (num != 0UL)
			{
				this.m_wearedEquipmentHeroDict.Remove(num);
			}
			hero.EquipmentIds[slot] = instanceId;
			this.m_wearedEquipmentHeroDict.Add(instanceId, hero.HeroId);
			this.m_heroDS.SetHeroDirty(hero);
		}

		// Token: 0x060041FE RID: 16894 RVA: 0x00139600 File Offset: 0x00137800
		private void TakeOffEquipmentBySlot(Hero hero, int slot)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TakeOffEquipmentBySlotHeroInt32_hotfix != null)
			{
				this.m_TakeOffEquipmentBySlotHeroInt32_hotfix.call(new object[]
				{
					this,
					hero,
					slot
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ulong num = hero.EquipmentIds[slot];
			if (num != 0UL)
			{
				this.m_wearedEquipmentHeroDict.Remove(num);
				hero.TakeOffEquipment(slot);
				this.m_heroDS.SetHeroDirty(hero);
			}
		}

		// Token: 0x060041FF RID: 16895 RVA: 0x001396B4 File Offset: 0x001378B4
		public int CanTakeOffEquipment(int heroId, int slot)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanTakeOffEquipmentInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanTakeOffEquipmentInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					slot
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (slot < 0 || slot >= 4)
			{
				return -609;
			}
			Hero hero = this.FindHero(heroId);
			if (hero == null)
			{
				return -602;
			}
			if (!hero.IsEquipmentWeared(slot))
			{
				return -649;
			}
			return 0;
		}

		// Token: 0x06004200 RID: 16896 RVA: 0x0013977C File Offset: 0x0013797C
		public int TakeOffEquipment(int heroId, int slot)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TakeOffEquipmentInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_TakeOffEquipmentInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					slot
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanTakeOffEquipment(heroId, slot);
			if (num != 0)
			{
				return num;
			}
			Hero hero = this.FindHero(heroId);
			this.TakeOffEquipmentBySlot(hero, slot);
			this.OnHeroBattlePowerChange(hero);
			return 0;
		}

		// Token: 0x06004201 RID: 16897 RVA: 0x00139834 File Offset: 0x00137A34
		public bool HasBetterEquipmentByHero(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasBetterEquipmentByHeroInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasBetterEquipmentByHeroInt32_hotfix.call(new object[]
				{
					this,
					heroId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.FindHero(heroId);
			for (int i = 0; i < 4; i++)
			{
				if (this.HasBetterEquipmentBySlotId(hero, i))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06004202 RID: 16898 RVA: 0x001398DC File Offset: 0x00137ADC
		public bool HasBetterEquipmentBySlotId(int heroId, int slotId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasBetterEquipmentBySlotIdInt32Int32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasBetterEquipmentBySlotIdInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					slotId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.FindHero(heroId);
			return this.HasBetterEquipmentBySlotId(hero, slotId);
		}

		// Token: 0x06004203 RID: 16899 RVA: 0x00139978 File Offset: 0x00137B78
		protected BagItemBase GetWearedEquipmentBySlotId(Hero hero, int slotId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetWearedEquipmentBySlotIdHeroInt32_hotfix != null)
			{
				return (BagItemBase)this.m_GetWearedEquipmentBySlotIdHeroInt32_hotfix.call(new object[]
				{
					this,
					hero,
					slotId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ulong num = hero.EquipmentIds[slotId];
			BagItemBase result = null;
			if (num != 0UL)
			{
				result = this.m_bag.FindBagItemByInstanceId(num);
			}
			return result;
		}

		// Token: 0x06004204 RID: 16900 RVA: 0x00139A28 File Offset: 0x00137C28
		private bool HasBetterEquipmentBySlotId(Hero hero, int slotId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasBetterEquipmentBySlotIdHeroInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasBetterEquipmentBySlotIdHeroInt32_hotfix.call(new object[]
				{
					this,
					hero,
					slotId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BagItemBase wearedEquipmentBySlotId = this.GetWearedEquipmentBySlotId(hero, slotId);
			foreach (BagItemBase bagItemBase in this.m_bag.GetAllBagItems())
			{
				if (bagItemBase.GoodsTypeId == GoodsType.GoodsType_Equipment)
				{
					if (!this.IsEquipmentWeared(bagItemBase.InstanceId))
					{
						if (this.IsBetterEquipment(wearedEquipmentBySlotId, bagItemBase, slotId) && this.CanWearEquipmentByJobAndArmy(hero, bagItemBase) == 0)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x06004205 RID: 16901 RVA: 0x00139B58 File Offset: 0x00137D58
		protected bool IsBetterEquipment(BagItemBase wearedEquipment, BagItemBase compareEquipment, int slotId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsBetterEquipmentBagItemBaseBagItemBaseInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsBetterEquipmentBagItemBaseBagItemBaseInt32_hotfix.call(new object[]
				{
					this,
					wearedEquipment,
					compareEquipment,
					slotId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataEquipmentInfo configDataEquipmentInfo = this.m_configDataLoader.GetConfigDataEquipmentInfo(compareEquipment.ContentId);
			if (slotId != (int)configDataEquipmentInfo.EquipmentType)
			{
				return false;
			}
			if (wearedEquipment == null)
			{
				return true;
			}
			ConfigDataEquipmentInfo configDataEquipmentInfo2 = this.m_configDataLoader.GetConfigDataEquipmentInfo(wearedEquipment.ContentId);
			return configDataEquipmentInfo.Rank > configDataEquipmentInfo2.Rank;
		}

		// Token: 0x06004206 RID: 16902 RVA: 0x00139C3C File Offset: 0x00137E3C
		public int CanAutoEquipmentByClient(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAutoEquipmentByClientInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAutoEquipmentByClientInt32_hotfix.call(new object[]
				{
					this,
					heroId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasBetterEquipmentByHero(heroId))
			{
				return -654;
			}
			return this.CanAutoEquipment(heroId);
		}

		// Token: 0x06004207 RID: 16903 RVA: 0x00139CD4 File Offset: 0x00137ED4
		public int CanAutoEquipment(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAutoEquipmentInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAutoEquipmentInt32_hotfix.call(new object[]
				{
					this,
					heroId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.FindHero(heroId) == null)
			{
				return -602;
			}
			DateTime d;
			if (this.m_atuoEquipmentTouch.TryGetValue(heroId, out d))
			{
				double totalSeconds = (this.m_basicInfo.GetCurrentTime() - d).TotalSeconds;
				if (totalSeconds < (double)this.m_configDataLoader.ConfigableConstId_AutoEquipmentDeltaTime)
				{
					return -653;
				}
			}
			return 0;
		}

		// Token: 0x06004208 RID: 16904 RVA: 0x00139DAC File Offset: 0x00137FAC
		public int CanWearCharSkin(int heroId, int charSkinId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanWearCharSkinInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanWearCharSkinInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					charSkinId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasGainHero(heroId))
			{
				return -602;
			}
			if (!this.m_resource.HasOwn(GoodsType.GoodsType_HeroSkin, charSkinId))
			{
				return -5000;
			}
			ConfigDataHeroSkinInfo configDataHeroSkinInfo = this.m_configDataLoader.GetConfigDataHeroSkinInfo(charSkinId);
			if (configDataHeroSkinInfo.SpecifiedHero != heroId)
			{
				return -5001;
			}
			return 0;
		}

		// Token: 0x06004209 RID: 16905 RVA: 0x00139E84 File Offset: 0x00138084
		public int WearCharSkin(int heroId, int charSkinId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WearCharSkinInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_WearCharSkinInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					charSkinId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanWearCharSkin(heroId, charSkinId);
			if (num != 0)
			{
				return num;
			}
			Hero hero = this.FindHero(heroId);
			hero.CharSkinId = charSkinId;
			this.m_heroDS.SetHeroDirty(hero);
			return 0;
		}

		// Token: 0x0600420A RID: 16906 RVA: 0x00139F40 File Offset: 0x00138140
		public int CanTakeOffCharSkin(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanTakeOffCharSkinInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanTakeOffCharSkinInt32_hotfix.call(new object[]
				{
					this,
					heroId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasGainHero(heroId))
			{
				return -602;
			}
			return 0;
		}

		// Token: 0x0600420B RID: 16907 RVA: 0x00139FD0 File Offset: 0x001381D0
		public int TakeOffCharSkin(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TakeOffCharSkinInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_TakeOffCharSkinInt32_hotfix.call(new object[]
				{
					this,
					heroId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanTakeOffCharSkin(heroId);
			Hero hero = this.FindHero(heroId);
			if (hero.CharSkinId != 0)
			{
				hero.CharSkinId = 0;
				this.m_heroDS.SetHeroDirty(hero);
			}
			return 0;
		}

		// Token: 0x0600420C RID: 16908 RVA: 0x0013A07C File Offset: 0x0013827C
		public int CanWearModelSkin(int heroId, int jobRelatedId, int modelSkinId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanWearModelSkinInt32Int32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanWearModelSkinInt32Int32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					jobRelatedId2,
					modelSkinId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int jobRelatedId = jobRelatedId2;
			Hero hero = this.FindHero(heroId);
			if (hero == null)
			{
				return -602;
			}
			if (this.FindHeroJob(hero, jobRelatedId) == null)
			{
				return -601;
			}
			if (!this.m_resource.HasOwn(GoodsType.GoodsType_HeroSkin, modelSkinId))
			{
				return -5000;
			}
			List<JobConnection2SkinResource> specifiedModelSkinResource = this.m_configDataLoader.GetConfigDataHeroSkinInfo(modelSkinId).SpecifiedModelSkinResource;
			if (specifiedModelSkinResource.Find((JobConnection2SkinResource m) => m.JobConnectionId == jobRelatedId) == null)
			{
				return -5002;
			}
			return 0;
		}

		// Token: 0x0600420D RID: 16909 RVA: 0x0013A1A0 File Offset: 0x001383A0
		public int WearModelSkin(int heroId, int jobRelatedId, int modelSkinId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WearModelSkinInt32Int32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_WearModelSkinInt32Int32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					jobRelatedId,
					modelSkinId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanWearModelSkin(heroId, jobRelatedId, modelSkinId);
			if (num != 0)
			{
				return num;
			}
			Hero hero = this.FindHero(heroId);
			HeroJob heroJob = this.FindHeroJob(hero, jobRelatedId);
			heroJob.ModelSkinId = modelSkinId;
			this.m_heroDS.SetHeroDirty(hero);
			return 0;
		}

		// Token: 0x0600420E RID: 16910 RVA: 0x0013A274 File Offset: 0x00138474
		public int CanTakeOffModelSkin(int heroId, int jobRelatedId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanTakeOffModelSkinInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanTakeOffModelSkinInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					jobRelatedId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.FindHero(heroId);
			if (hero == null)
			{
				return -602;
			}
			if (this.FindHeroJob(hero, jobRelatedId) == null)
			{
				return -601;
			}
			return 0;
		}

		// Token: 0x0600420F RID: 16911 RVA: 0x0013A32C File Offset: 0x0013852C
		public int TakeOffModelSkin(int heroId, int jobRelatedId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TakeOffModelSkinInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_TakeOffModelSkinInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					jobRelatedId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanTakeOffModelSkin(heroId, jobRelatedId);
			if (num != 0)
			{
				return num;
			}
			Hero hero = this.FindHero(heroId);
			HeroJob heroJob = this.FindHeroJob(hero, jobRelatedId);
			if (heroJob.ModelSkinId != 0)
			{
				heroJob.ModelSkinId = 0;
				this.m_heroDS.SetHeroDirty(hero);
			}
			return 0;
		}

		// Token: 0x06004210 RID: 16912 RVA: 0x0013A3FC File Offset: 0x001385FC
		public int CanWearSoldierSkin(int heroId, int soldierId, int soldierSkinId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanWearSoldierSkinInt32Int32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanWearSoldierSkinInt32Int32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					soldierId2,
					soldierSkinId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int soldierId = soldierId2;
			Hero hero = this.FindHero(heroId);
			if (hero == null)
			{
				return -602;
			}
			if (!hero.HasOwnSoldier(soldierId))
			{
				return -619;
			}
			if (!this.m_resource.HasOwn(GoodsType.GoodsType_SoldierSkin, soldierSkinId))
			{
				return -5000;
			}
			List<Soldier2SkinResource> specifiedSoldier = this.m_configDataLoader.GetConfigDataSoldierSkinInfo(soldierSkinId).SpecifiedSoldier;
			if (specifiedSoldier.Find((Soldier2SkinResource m) => m.SoldierId == soldierId) == null)
			{
				return -5003;
			}
			return 0;
		}

		// Token: 0x06004211 RID: 16913 RVA: 0x0013A51C File Offset: 0x0013871C
		public int WearSoldierSkin(int heroId, int soldierId, int soldierSkinId, bool applyToAll)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WearSoldierSkinInt32Int32Int32Boolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_WearSoldierSkinInt32Int32Int32Boolean_hotfix.call(new object[]
				{
					this,
					heroId,
					soldierId2,
					soldierSkinId,
					applyToAll
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int soldierId = soldierId2;
			HashSet<int> hashSet;
			if (applyToAll)
			{
				hashSet = this.GetGainHeroIds();
			}
			else
			{
				hashSet = new HashSet<int>();
				hashSet.Add(heroId);
			}
			foreach (int heroId2 in hashSet)
			{
				int num = this.CanWearSoldierSkin(heroId2, soldierId, soldierSkinId);
				if (num == 0)
				{
					Hero hero = this.FindHero(heroId2);
					List<SoldierSkin> soldierSkins = hero.SoldierSkins;
					SoldierSkin soldierSkin = soldierSkins.Find((SoldierSkin m) => m.SoldierId == soldierId);
					if (soldierSkin == null)
					{
						soldierSkin = new SoldierSkin
						{
							SoldierId = soldierId,
							SkinId = soldierSkinId
						};
						soldierSkins.Add(soldierSkin);
					}
					else
					{
						soldierSkin.SkinId = soldierSkinId;
					}
					this.m_heroDS.SetHeroDirty(hero);
				}
			}
			return 0;
		}

		// Token: 0x06004212 RID: 16914 RVA: 0x0013A6C8 File Offset: 0x001388C8
		public int CanTakeOffSoldierSkin(int heroId, int soldierId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanTakeOffSoldierSkinInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanTakeOffSoldierSkinInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					soldierId2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int soldierId = soldierId2;
			Hero hero = this.FindHero(heroId);
			if (hero == null)
			{
				return -602;
			}
			if (!hero.HasOwnSoldier(soldierId))
			{
				return -619;
			}
			List<SoldierSkin> soldierSkins = hero.SoldierSkins;
			if (soldierSkins.Find((SoldierSkin m) => m.SoldierId == soldierId) == null)
			{
				return -5004;
			}
			return 0;
		}

		// Token: 0x06004213 RID: 16915 RVA: 0x0013A7B4 File Offset: 0x001389B4
		public int TakeOffSoldierSkin(int heroId, int soldierId, bool applyToAll)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TakeOffSoldierSkinInt32Int32Boolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_TakeOffSoldierSkinInt32Int32Boolean_hotfix.call(new object[]
				{
					this,
					heroId,
					soldierId2,
					applyToAll
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int soldierId = soldierId2;
			int num = this.CanTakeOffSoldierSkin(heroId, soldierId);
			if (num != 0)
			{
				return num;
			}
			Hero hero = this.FindHero(heroId);
			List<SoldierSkin> soldierSkins = hero.SoldierSkins;
			SoldierSkin soldierSkin = soldierSkins.Find((SoldierSkin m) => m.SoldierId == soldierId);
			soldierSkins.Remove(soldierSkin);
			this.m_heroDS.SetHeroDirty(hero);
			int skinId = soldierSkin.SkinId;
			if (applyToAll)
			{
				this.TakeOffSoldierSkinApplyToAll(soldierId, skinId);
			}
			return 0;
		}

		// Token: 0x06004214 RID: 16916 RVA: 0x0013A8CC File Offset: 0x00138ACC
		public void TakeOffSoldierSkinApplyToAll(int soldierId, int skinId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TakeOffSoldierSkinApplyToAllInt32Int32_hotfix != null)
			{
				this.m_TakeOffSoldierSkinApplyToAllInt32Int32_hotfix.call(new object[]
				{
					this,
					soldierId2,
					skinId2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int soldierId = soldierId2;
			int skinId = skinId2;
			foreach (Hero hero in this.GetAllHeros())
			{
				List<SoldierSkin> soldierSkins = hero.SoldierSkins;
				SoldierSkin soldierSkin = soldierSkins.Find((SoldierSkin m) => m.SoldierId == soldierId && m.SkinId == skinId);
				if (soldierSkin != null)
				{
					soldierSkins.Remove(soldierSkin);
					this.m_heroDS.SetHeroDirty(hero);
				}
			}
		}

		// Token: 0x06004215 RID: 16917 RVA: 0x0013A9E0 File Offset: 0x00138BE0
		public int AddHeroFavorabilityExpByUseableBagItem(int heroId, GoodsType goodsTypeId, int contentId, int consumeNums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddHeroFavorabilityExpByUseableBagItemInt32GoodsTypeInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_AddHeroFavorabilityExpByUseableBagItemInt32GoodsTypeInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					goodsTypeId,
					contentId,
					consumeNums
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.FindHero(heroId) == null)
			{
				return -602;
			}
			return this.m_bag.UseBagItem(goodsTypeId, contentId, consumeNums, new object[]
			{
				heroId
			});
		}

		// Token: 0x06004216 RID: 16918 RVA: 0x0013AAC0 File Offset: 0x00138CC0
		public int AddHeroFavorabilityLevel(int heroId, int addExp)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddHeroFavorabilityLevelInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_AddHeroFavorabilityLevelInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					addExp
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(heroId);
			if (configDataHeroInfo == null)
			{
				return -618;
			}
			if (configDataHeroInfo.m_informationInfo == null)
			{
				return -657;
			}
			Hero hero = this.m_heroDS.FindHero(heroId);
			if (hero == null)
			{
				return -602;
			}
			if (this.IsProtagonistHero(heroId))
			{
				return -655;
			}
			if (this.IsFullFavorabilityExp(hero, configDataHeroInfo.m_informationInfo))
			{
				return -656;
			}
			int additiveHeroFavourabilityAddExp = this.GetAdditiveHeroFavourabilityAddExp(addExp);
			int num = hero.FavorabilityExp + additiveHeroFavourabilityAddExp;
			int nextExp;
			for (;;)
			{
				nextExp = this.m_configDataLoader.GetConfigDataHeroFavorabilityLevelInfo(hero.FavorabilityLevel).NextExp;
				if (num < nextExp)
				{
					break;
				}
				if (configDataHeroInfo.m_informationInfo.FavorabilityMaxLevel == hero.FavorabilityLevel)
				{
					goto Block_10;
				}
				this.GenerateFavorabilityLevelUpReward(heroId, configDataHeroInfo.m_informationInfo.FavourabilityLevelUpReward);
				this.AddHeroFavorabilityLevel(hero);
				num -= nextExp;
				if (num <= 0)
				{
					return 0;
				}
			}
			this.OutPutHeroFavourabilityOperateLog(heroId, hero.FavorabilityLevel, hero.FavorabilityExp, hero.FavorabilityLevel, num, null);
			this.m_heroDS.SetHeroFavorabilityExp(hero, num);
			return 0;
			Block_10:
			this.OutPutHeroFavourabilityOperateLog(heroId, hero.FavorabilityLevel, hero.FavorabilityExp, hero.FavorabilityLevel, num, null);
			this.m_heroDS.SetHeroFavorabilityExp(hero, nextExp);
			return 0;
		}

		// Token: 0x06004217 RID: 16919 RVA: 0x0013AC84 File Offset: 0x00138E84
		protected virtual void OutPutHeroFavourabilityOperateLog(int heroId, int oldLvl, int oldExp, int newLvl, int newExp, List<Goods> rewards = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OutPutHeroFavourabilityOperateLogInt32Int32Int32Int32Int32List`1_hotfix != null)
			{
				this.m_OutPutHeroFavourabilityOperateLogInt32Int32Int32Int32Int32List`1_hotfix.call(new object[]
				{
					this,
					heroId,
					oldLvl,
					oldExp,
					newLvl,
					newExp,
					rewards
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06004218 RID: 16920 RVA: 0x0013AD44 File Offset: 0x00138F44
		private void AddHeroFavorabilityLevel(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddHeroFavorabilityLevelHero_hotfix != null)
			{
				this.m_AddHeroFavorabilityLevelHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroDS.AddHeroFavorabilityLevel(hero, 1);
			this.UpdateProtagonistHeroFavorabilityLevel();
			if (this.HeroFavorabilityLevelupMissionEvent != null)
			{
				this.HeroFavorabilityLevelupMissionEvent(hero);
			}
		}

		// Token: 0x06004219 RID: 16921 RVA: 0x0013ADE0 File Offset: 0x00138FE0
		protected virtual void GenerateFavorabilityLevelUpReward(int heroId, int dropId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GenerateFavorabilityLevelUpRewardInt32Int32_hotfix != null)
			{
				this.m_GenerateFavorabilityLevelUpRewardInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					dropId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600421A RID: 16922 RVA: 0x0013AE60 File Offset: 0x00139060
		public bool IsFullFavorabilityExp(Hero hero, ConfigDataHeroInformationInfo heroInformationInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsFullFavorabilityExpHeroConfigDataHeroInformationInfo_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsFullFavorabilityExpHeroConfigDataHeroInformationInfo_hotfix.call(new object[]
				{
					this,
					hero,
					heroInformationInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return hero.FavorabilityLevel >= heroInformationInfo.FavorabilityMaxLevel && (hero.FavorabilityLevel > heroInformationInfo.FavorabilityMaxLevel || hero.FavorabilityExp == this.m_configDataLoader.GetConfigDataHeroFavorabilityLevelInfo(hero.FavorabilityLevel).NextExp);
		}

		// Token: 0x0600421B RID: 16923 RVA: 0x0013AF30 File Offset: 0x00139130
		protected void UpdateProtagonistHeroFavorabilityLevel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateProtagonistHeroFavorabilityLevel_hotfix != null)
			{
				this.m_UpdateProtagonistHeroFavorabilityLevel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsProtagonistExist())
			{
				return;
			}
			int num = 0;
			foreach (Hero hero in this.m_heroDS.GetAllHeroes())
			{
				if (!this.IsProtagonistHero(hero.HeroId))
				{
					num += hero.FavorabilityLevel;
				}
			}
			Hero hero2 = this.m_heroDS.FindHero(this.m_configDataLoader.ConfigableConstId_ProtagonistHeroID);
			if (hero2.FavorabilityLevel != num)
			{
				this.m_heroDS.SetHeroFavorabilityLevel(hero2, num);
			}
		}

		// Token: 0x0600421C RID: 16924 RVA: 0x0013B03C File Offset: 0x0013923C
		public int CanUnlockHeroFetter(int heroId, int fetterId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanUnlockHeroFetterInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanUnlockHeroFetterInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					fetterId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.m_heroDS.FindHero(heroId);
			if (hero == null)
			{
				return -602;
			}
			ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(heroId);
			if (configDataHeroInfo.m_informationInfo == null)
			{
				return -657;
			}
			if (!configDataHeroInfo.m_informationInfo.HeroFetters_ID.Contains(fetterId))
			{
				return -662;
			}
			ConfigDataHeroFetterInfo configDataHeroFetterInfo = this.m_configDataLoader.GetConfigDataHeroFetterInfo(fetterId);
			if (configDataHeroFetterInfo == null)
			{
				return -662;
			}
			if (hero.Fetters.ContainsKey(fetterId))
			{
				return -663;
			}
			foreach (HeroFetterCompletionCondition condition in configDataHeroFetterInfo.CompletionConditions)
			{
				int num = this.CanReachFetterUnlockCondition(condition);
				if (num != 0)
				{
					return num;
				}
			}
			if (this.m_bag.IsBagFullByCurrentSize())
			{
				return -500;
			}
			return 0;
		}

		// Token: 0x0600421D RID: 16925 RVA: 0x0013B1C8 File Offset: 0x001393C8
		public int CanReachFetterUnlockCondition(HeroFetterCompletionCondition condition)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanReachFetterUnlockConditionHeroFetterCompletionCondition_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanReachFetterUnlockConditionHeroFetterCompletionCondition_hotfix.call(new object[]
				{
					this,
					condition
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			FetterCompleteConditionType conditionType = condition.ConditionType;
			if (conditionType != FetterCompleteConditionType.FetterCompleteConditionType_HeroFavorabilityLevel)
			{
				if (conditionType != FetterCompleteConditionType.FetterCompleteConditionType_Mission)
				{
					return -660;
				}
				if (!this.m_mission.IsMissionFinished(condition.Parm1))
				{
					return -659;
				}
			}
			else
			{
				Hero hero = this.m_heroDS.FindHero(condition.Parm1);
				if (hero == null || hero.FavorabilityLevel < condition.Parm2)
				{
					return -658;
				}
			}
			return 0;
		}

		// Token: 0x0600421E RID: 16926 RVA: 0x0013B2BC File Offset: 0x001394BC
		public int GmLevelUpHeroFetter2SpecificLevel(int heroId, int fetterId, int reachLevel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GmLevelUpHeroFetter2SpecificLevelInt32Int32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GmLevelUpHeroFetter2SpecificLevelInt32Int32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					fetterId,
					reachLevel
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.m_heroDS.FindHero(heroId);
			if (hero == null)
			{
				return -602;
			}
			ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(heroId);
			if (configDataHeroInfo.m_informationInfo == null)
			{
				return -657;
			}
			if (!configDataHeroInfo.m_informationInfo.HeroFetters_ID.Contains(fetterId))
			{
				return -662;
			}
			if (!hero.Fetters.ContainsKey(fetterId))
			{
				return -661;
			}
			ConfigDataHeroFetterInfo configDataHeroFetterInfo = this.m_configDataLoader.GetConfigDataHeroFetterInfo(fetterId);
			int num = (reachLevel <= configDataHeroFetterInfo.MaxLevel) ? reachLevel : configDataHeroFetterInfo.MaxLevel;
			int num2 = hero.Fetters[fetterId];
			if (num > num2)
			{
				for (int i = num2; i < num; i++)
				{
					this.LevelUpHeroFetterCallBack(hero, fetterId);
				}
			}
			else
			{
				hero.Fetters[fetterId] = num;
			}
			this.OnHeroBattlePowerChange(hero);
			return 0;
		}

		// Token: 0x0600421F RID: 16927 RVA: 0x0013B438 File Offset: 0x00139638
		public int CanLevelUpHeroFetter(int heroId, int fetterId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanLevelUpHeroFetterInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanLevelUpHeroFetterInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					fetterId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.m_heroDS.FindHero(heroId);
			if (hero == null)
			{
				return -602;
			}
			ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(heroId);
			if (configDataHeroInfo.m_informationInfo == null)
			{
				return -657;
			}
			if (!configDataHeroInfo.m_informationInfo.HeroFetters_ID.Contains(fetterId))
			{
				return -662;
			}
			if (!hero.Fetters.ContainsKey(fetterId))
			{
				return -661;
			}
			int num = hero.Fetters[fetterId];
			ConfigDataHeroFetterInfo configDataHeroFetterInfo = this.m_configDataLoader.GetConfigDataHeroFetterInfo(fetterId);
			if (configDataHeroFetterInfo.MaxLevel <= num)
			{
				return -664;
			}
			List<Goods> list = new List<Goods>();
			foreach (HeroFetterLevelUpCost heroFetterLevelUpCost in configDataHeroFetterInfo.LevelUpMaterials)
			{
				if (num + 1 == heroFetterLevelUpCost.Level)
				{
					list.Add(new Goods
					{
						GoodsType = heroFetterLevelUpCost.ItemType,
						Id = heroFetterLevelUpCost.ItemId,
						Count = heroFetterLevelUpCost.Count
					});
				}
			}
			List<BagItemBase> list2;
			int num2 = this.m_bag.IsGoodsEnough(list, out list2);
			if (num2 != 0)
			{
				return num2;
			}
			if (configDataHeroFetterInfo.LevelUpGold.Count >= num)
			{
				int useGoldCount = configDataHeroFetterInfo.LevelUpGold[num - 1];
				if (!this.m_basicInfo.IsGoldEnough(useGoldCount))
				{
					return -400;
				}
			}
			return 0;
		}

		// Token: 0x06004220 RID: 16928 RVA: 0x0013B64C File Offset: 0x0013984C
		public virtual int LevelUpHeroFetter(int heroId, int fetterId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LevelUpHeroFetterInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_LevelUpHeroFetterInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					fetterId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanLevelUpHeroFetter(heroId, fetterId);
			if (num != 0)
			{
				return num;
			}
			Hero hero = this.m_heroDS.FindHero(heroId);
			int num2 = hero.Fetters[fetterId];
			ConfigDataHeroFetterInfo configDataHeroFetterInfo = this.m_configDataLoader.GetConfigDataHeroFetterInfo(fetterId);
			List<Goods> list = new List<Goods>();
			foreach (HeroFetterLevelUpCost heroFetterLevelUpCost in configDataHeroFetterInfo.LevelUpMaterials)
			{
				if (heroFetterLevelUpCost.Level == num2 + 1)
				{
					list.Add(new Goods
					{
						GoodsType = heroFetterLevelUpCost.ItemType,
						Id = heroFetterLevelUpCost.ItemId,
						Count = heroFetterLevelUpCost.Count
					});
				}
			}
			this.m_bag.ConsumeGoods(list, null, null, GameFunctionType.GameFunctionType_HeroFetterLevelUp, fetterId.ToString());
			if (configDataHeroFetterInfo.LevelUpGold.Count >= num2)
			{
				int num3 = configDataHeroFetterInfo.LevelUpGold[num2 - 1];
				this.m_basicInfo.AddGold(-num3, GameFunctionType.GameFunctionType_HeroFetterLevelUp, fetterId.ToString());
				list.Add(new Goods
				{
					GoodsType = GoodsType.GoodsType_Gold,
					Id = 0,
					Count = num3
				});
			}
			this.LevelUpHeroFetterCallBack(hero, fetterId);
			this.OutPutHeroFetterOpereateLog(heroId, fetterId, hero.Fetters[fetterId], list, null);
			this.OnHeroBattlePowerChange(hero);
			return 0;
		}

		// Token: 0x06004221 RID: 16929 RVA: 0x0013B858 File Offset: 0x00139A58
		protected void LevelUpHeroFetterCallBack(Hero hero, int fetterId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LevelUpHeroFetterCallBackHeroInt32_hotfix != null)
			{
				this.m_LevelUpHeroFetterCallBackHeroInt32_hotfix.call(new object[]
				{
					this,
					hero,
					fetterId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroDS.LevelUpHeroFetter(hero, fetterId);
			if (this.HeroFetterLevelupMissionEvent != null)
			{
				this.HeroFetterLevelupMissionEvent(hero, fetterId);
			}
		}

		// Token: 0x06004222 RID: 16930 RVA: 0x0013B900 File Offset: 0x00139B00
		protected virtual void OutPutHeroFetterOpereateLog(int heroId, int fetterId, int currentLvl, List<Goods> itemCost = null, List<Goods> rewards = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OutPutHeroFetterOpereateLogInt32Int32Int32List`1List`1_hotfix != null)
			{
				this.m_OutPutHeroFetterOpereateLogInt32Int32Int32List`1List`1_hotfix.call(new object[]
				{
					this,
					heroId,
					fetterId,
					currentLvl,
					itemCost,
					rewards
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06004223 RID: 16931 RVA: 0x0013B9B0 File Offset: 0x00139BB0
		public int UnlockHeroFetter(int heroId, int fetterId, bool check = true)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UnlockHeroFetterInt32Int32Boolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_UnlockHeroFetterInt32Int32Boolean_hotfix.call(new object[]
				{
					this,
					heroId,
					fetterId,
					check
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (check)
			{
				int num = this.CanUnlockHeroFetter(heroId, fetterId);
				if (num != 0)
				{
					return num;
				}
			}
			Hero hero = this.m_heroDS.FindHero(heroId);
			this.m_heroDS.UnlockHeroFetter(hero, fetterId);
			this.GenerateFetterUnlockRewards(heroId, fetterId);
			this.OnHeroBattlePowerChange(hero);
			return 0;
		}

		// Token: 0x06004224 RID: 16932 RVA: 0x0013BA90 File Offset: 0x00139C90
		protected virtual void GenerateFetterUnlockRewards(int heroId, int fetterId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GenerateFetterUnlockRewardsInt32Int32_hotfix != null)
			{
				this.m_GenerateFetterUnlockRewardsInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					fetterId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06004225 RID: 16933 RVA: 0x0013BB10 File Offset: 0x00139D10
		public int ConfessHero(int heroId, bool check = true)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ConfessHeroInt32Boolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_ConfessHeroInt32Boolean_hotfix.call(new object[]
				{
					this,
					heroId,
					check
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (check)
			{
				int num = this.CanConfessHero(heroId);
				if (num != 0)
				{
					return num;
				}
			}
			Hero hero = this.m_heroDS.FindHero(heroId);
			this.m_heroDS.ConfessHero(hero);
			ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(heroId);
			this.GenerateConfessionRewards(heroId, configDataHeroInfo.m_informationInfo.m_confessionInfo);
			return 0;
		}

		// Token: 0x06004226 RID: 16934 RVA: 0x0013BBEC File Offset: 0x00139DEC
		protected virtual void GenerateConfessionRewards(int herId, ConfigDataHeroConfessionInfo confessionInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GenerateConfessionRewardsInt32ConfigDataHeroConfessionInfo_hotfix != null)
			{
				this.m_GenerateConfessionRewardsInt32ConfigDataHeroConfessionInfo_hotfix.call(new object[]
				{
					this,
					herId,
					confessionInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06004227 RID: 16935 RVA: 0x0013BC6C File Offset: 0x00139E6C
		public int CanConfessHero(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanConfessHeroInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanConfessHeroInt32_hotfix.call(new object[]
				{
					this,
					heroId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.m_heroDS.FindHero(heroId);
			if (hero == null)
			{
				return -602;
			}
			ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(heroId);
			if (configDataHeroInfo.m_informationInfo == null)
			{
				return -657;
			}
			if (this.IsProtagonistHero(heroId))
			{
				return -674;
			}
			if (hero.Confessed)
			{
				return -671;
			}
			ConfigDataHeroConfessionInfo confessionInfo = configDataHeroInfo.m_informationInfo.m_confessionInfo;
			if (confessionInfo == null)
			{
				return -673;
			}
			foreach (HeroConfessionUnlockCondition heroConfessionUnlockCondition in confessionInfo.UnlockConditions)
			{
				if (!hero.Fetters.ContainsKey(heroConfessionUnlockCondition.FetterId))
				{
					return -661;
				}
				if (hero.Fetters[heroConfessionUnlockCondition.FetterId] < heroConfessionUnlockCondition.FetterLevel)
				{
					return -672;
				}
			}
			if (this.m_bag.IsBagFullByCurrentSize())
			{
				return -500;
			}
			return 0;
		}

		// Token: 0x06004228 RID: 16936 RVA: 0x0013BE08 File Offset: 0x0013A008
		private void FlushHeroInteractNums()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FlushHeroInteractNums_hotfix != null)
			{
				this.m_FlushHeroInteractNums_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.InitHeroInteractNums();
		}

		// Token: 0x06004229 RID: 16937 RVA: 0x0013BE70 File Offset: 0x0013A070
		protected void InitHeroInteractNums()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitHeroInteractNums_hotfix != null)
			{
				this.m_InitHeroInteractNums_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsFullHeroInteractNums())
			{
				return;
			}
			if (!this.CanFlushHeroInteractNums())
			{
				return;
			}
			int configableConstId_HeroInteractNumsRecoveryPeriod = this.m_configDataLoader.ConfigableConstId_HeroInteractNumsRecoveryPeriod;
			DateTime currentTime = this.m_basicInfo.GetCurrentTime();
			int addNums = (int)((currentTime - this.m_heroDS.HeroInteractNumsFlushTime).TotalSeconds / (double)configableConstId_HeroInteractNumsRecoveryPeriod);
			this.AddHeroInteractNums(addNums, true);
		}

		// Token: 0x0600422A RID: 16938 RVA: 0x0013BF28 File Offset: 0x0013A128
		private bool CanFlushHeroInteractNums()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanFlushHeroInteractNums_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CanFlushHeroInteractNums_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return (this.m_basicInfo.GetCurrentTime() - this.m_heroDS.HeroInteractNumsFlushTime).TotalSeconds >= (double)this.m_configDataLoader.ConfigableConstId_HeroInteractNumsRecoveryPeriod;
		}

		// Token: 0x0600422B RID: 16939 RVA: 0x0013BFC8 File Offset: 0x0013A1C8
		private bool IsFullHeroInteractNums()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsFullHeroInteractNums_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsFullHeroInteractNums_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroDS.HeroInteractNums >= this.m_configDataLoader.ConfigableConstId_HeroIteractMaxNums;
		}

		// Token: 0x0600422C RID: 16940 RVA: 0x0013C050 File Offset: 0x0013A250
		protected void AddHeroInteractNums(int addNums, bool recoveryByTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddHeroInteractNumsInt32Boolean_hotfix != null)
			{
				this.m_AddHeroInteractNumsInt32Boolean_hotfix.call(new object[]
				{
					this,
					addNums,
					recoveryByTime
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_heroDS.HeroInteractNums + addNums;
			if (num >= this.m_configDataLoader.ConfigableConstId_HeroIteractMaxNums)
			{
				num = this.m_configDataLoader.ConfigableConstId_HeroIteractMaxNums;
			}
			if (recoveryByTime)
			{
				DateTime heroInteractNumsFlushTime = this.m_heroDS.HeroInteractNumsFlushTime.AddSeconds((double)(addNums * this.m_configDataLoader.ConfigableConstId_HeroInteractNumsRecoveryPeriod));
				this.m_heroDS.SetHeroInteractNumsFlushTime(heroInteractNumsFlushTime);
			}
			else if (addNums < 0 && this.IsHeroInteractNumsEqualToMax())
			{
				this.m_heroDS.SetHeroInteractNumsFlushTime(this.m_basicInfo.GetCurrentTime());
			}
			if (num != this.m_heroDS.HeroInteractNums)
			{
				this.m_heroDS.SetHeroInteractNums(num);
			}
		}

		// Token: 0x0600422D RID: 16941 RVA: 0x0013C17C File Offset: 0x0013A37C
		private bool IsHeroInteractNumsEqualToMax()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsHeroInteractNumsEqualToMax_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsHeroInteractNumsEqualToMax_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroDS.HeroInteractNums == this.m_configDataLoader.ConfigableConstId_HeroIteractMaxNums;
		}

		// Token: 0x0600422E RID: 16942 RVA: 0x0013C200 File Offset: 0x0013A400
		public int CanInteractHero(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanInteractHeroInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanInteractHeroInt32_hotfix.call(new object[]
				{
					this,
					heroId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.m_heroDS.FindHero(heroId);
			if (hero == null)
			{
				return -602;
			}
			ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(heroId);
			if (configDataHeroInfo.m_informationInfo == null)
			{
				return -657;
			}
			if (!this.m_heroDS.CanInteractHero())
			{
				return -675;
			}
			int heroInteractId = this.GetHeroInteractId(hero, configDataHeroInfo.m_informationInfo);
			ConfigDataHeroInteractionInfo configDataHeroInteractionInfo = this.m_configDataLoader.GetConfigDataHeroInteractionInfo(heroInteractId);
			if (configDataHeroInteractionInfo == null)
			{
				return -676;
			}
			if (configDataHeroInteractionInfo.Results.Count == 0)
			{
				return -678;
			}
			HeroInteractionWeightResult heroInteractionWeightResult = configDataHeroInteractionInfo.Results.Find((HeroInteractionWeightResult t) => t.ResultType == HeroInteractionResultType.HeroInteractionResultType_BigUp);
			if (heroInteractionWeightResult == null)
			{
				return -677;
			}
			if (this.GetHeroFavorabilityUpLevel(hero, configDataHeroInfo.m_informationInfo, heroInteractionWeightResult.FavourabilityExp) == 0)
			{
				return 0;
			}
			if (this.m_bag.IsBagFullByCurrentSize())
			{
				return -500;
			}
			return 0;
		}

		// Token: 0x0600422F RID: 16943 RVA: 0x0013C374 File Offset: 0x0013A574
		public int GetHeroFavorabilityUpLevel(Hero hero, ConfigDataHeroInformationInfo heroInformationInfo, int addExp)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroFavorabilityUpLevelHeroConfigDataHeroInformationInfoInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetHeroFavorabilityUpLevelHeroConfigDataHeroInformationInfoInt32_hotfix.call(new object[]
				{
					this,
					hero,
					heroInformationInfo,
					addExp
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsFullFavorabilityExp(hero, heroInformationInfo))
			{
				return 0;
			}
			int num = 0;
			int num2 = hero.FavorabilityLevel;
			int num3 = hero.FavorabilityExp + addExp;
			do
			{
				int nextExp = this.m_configDataLoader.GetConfigDataHeroFavorabilityLevelInfo(num2).NextExp;
				if (num3 < nextExp)
				{
					break;
				}
				if (heroInformationInfo.FavorabilityMaxLevel == hero.FavorabilityLevel)
				{
					break;
				}
				num2++;
				num++;
				num3 -= nextExp;
			}
			while (num3 > 0);
			return num;
		}

		// Token: 0x06004230 RID: 16944 RVA: 0x0013C47C File Offset: 0x0013A67C
		protected int GetHeroInteractId(Hero hero, ConfigDataHeroInformationInfo heroInformationInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroInteractIdHeroConfigDataHeroInformationInfo_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetHeroInteractIdHeroConfigDataHeroInformationInfo_hotfix.call(new object[]
				{
					this,
					hero,
					heroInformationInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			for (int i = 0; i < heroInformationInfo.HeroTouch.Count; i++)
			{
				if (i + 1 == heroInformationInfo.HeroTouch.Count)
				{
					return heroInformationInfo.HeroTouch[i].HeroInteractionId;
				}
				if (heroInformationInfo.HeroTouch[i].FavorabilityLevel <= hero.FavorabilityLevel && hero.FavorabilityLevel < heroInformationInfo.HeroTouch[i + 1].FavorabilityLevel)
				{
					return heroInformationInfo.HeroTouch[i].HeroInteractionId;
				}
			}
			return int.MinValue;
		}

		// Token: 0x06004231 RID: 16945 RVA: 0x0013C59C File Offset: 0x0013A79C
		public int GetAllHeroBattlePower()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllHeroBattlePower_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetAllHeroBattlePower_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroDS.AllHeroBattlePower;
		}

		// Token: 0x06004232 RID: 16946 RVA: 0x0013C614 File Offset: 0x0013A814
		public int GetLastAllHeroRank()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetLastAllHeroRank_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetLastAllHeroRank_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroDS.LastAllHeroRank;
		}

		// Token: 0x06004233 RID: 16947 RVA: 0x0013C68C File Offset: 0x0013A88C
		public int GetTopHeroBattlePower()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTopHeroBattlePower_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetTopHeroBattlePower_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroDS.TopHeroBattlePower;
		}

		// Token: 0x06004234 RID: 16948 RVA: 0x0013C704 File Offset: 0x0013A904
		public int GetLastTopHeroRank()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetLastTopHeroRank_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetLastTopHeroRank_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroDS.LastTopHeroRank;
		}

		// Token: 0x06004235 RID: 16949 RVA: 0x0013C77C File Offset: 0x0013A97C
		public int GetChampionHeroBattlePower()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetChampionHeroBattlePower_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetChampionHeroBattlePower_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroDS.ChampionHeroBattlePower;
		}

		// Token: 0x06004236 RID: 16950 RVA: 0x0013C7F4 File Offset: 0x0013A9F4
		public int GetChampionHeroId()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetChampionHeroId_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetChampionHeroId_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroDS.ChampionHeroId;
		}

		// Token: 0x06004237 RID: 16951 RVA: 0x0013C86C File Offset: 0x0013AA6C
		public int GetLastChampionHeroRank()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetLastChampionHeroRank_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetLastChampionHeroRank_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroDS.LastChampionHeroRank;
		}

		// Token: 0x06004238 RID: 16952 RVA: 0x0013C8E4 File Offset: 0x0013AAE4
		public bool ComputeBattlePower(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeBattlePowerHero_hotfix != null)
			{
				return Convert.ToBoolean(this.m_ComputeBattlePowerHero_hotfix.call(new object[]
				{
					this,
					hero
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int battlePower = hero.BattlePower;
			hero.BattlePower = this.m_battle.ComputeBattlePower(hero);
			if (battlePower != hero.BattlePower)
			{
				hero.BattlePowerUpdateTime = this.m_basicInfo.GetCurrentTime();
				this.m_heroDS.SetHeroDirty(hero);
				return true;
			}
			return false;
		}

		// Token: 0x06004239 RID: 16953 RVA: 0x0013C9A8 File Offset: 0x0013ABA8
		public virtual void OnHeroBattlePowerChange(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeroBattlePowerChangeHero_hotfix != null)
			{
				this.m_OnHeroBattlePowerChangeHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool flag = false;
			if (hero != null)
			{
				flag |= this.ComputeBattlePower(hero);
			}
			else
			{
				foreach (Hero hero2 in this.GetAllHeros())
				{
					flag |= this.ComputeBattlePower(hero2);
				}
			}
			if (flag)
			{
				this.m_heroDS.OnHeroBattlePowerChange(this.m_basicInfo.GetCurrentTime(), hero);
			}
		}

		// Token: 0x0600423A RID: 16954 RVA: 0x0013CAA0 File Offset: 0x0013ACA0
		public int CanComposeHero(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanComposeHeroInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanComposeHeroInt32_hotfix.call(new object[]
				{
					this,
					heroId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.FindHero(heroId);
			if (hero != null)
			{
				return -603;
			}
			ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(heroId);
			if (configDataHeroInfo == null)
			{
				return -618;
			}
			ConfigDataHeroStarInfo configDataHeroStarInfo = this.m_configDataLoader.GetConfigDataHeroStarInfo(configDataHeroInfo.Star);
			if (configDataHeroStarInfo == null)
			{
				return -635;
			}
			if (!this.m_bag.IsBagItemEnough(GoodsType.GoodsType_Item, configDataHeroInfo.FragmentItem_ID, configDataHeroStarInfo.Fragment))
			{
				return -652;
			}
			if (!this.m_basicInfo.IsGoldEnough(configDataHeroStarInfo.Gold))
			{
				return -400;
			}
			return 0;
		}

		// Token: 0x0600423B RID: 16955 RVA: 0x0013CBA8 File Offset: 0x0013ADA8
		public int CanLevelUpHeroStarLevel(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanLevelUpHeroStarLevelInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanLevelUpHeroStarLevelInt32_hotfix.call(new object[]
				{
					this,
					heroId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.FindHero(heroId);
			if (hero == null)
			{
				return -602;
			}
			ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(hero.HeroId);
			if (configDataHeroInfo == null)
			{
				return -618;
			}
			if (hero.StarLevel + 1 > this.m_configDataLoader.ConfigableConstId_HeroStarLevelMax)
			{
				return -630;
			}
			List<Goods> heroStarLevelUpDataFromConfig = this.GetHeroStarLevelUpDataFromConfig(configDataHeroInfo.FragmentItem_ID, hero.StarLevel + 1);
			if (heroStarLevelUpDataFromConfig.Count == 0)
			{
				return -610;
			}
			List<BagItemBase> list = null;
			return this.m_bag.IsGoodsEnough(heroStarLevelUpDataFromConfig, out list);
		}

		// Token: 0x0600423C RID: 16956 RVA: 0x0013CCAC File Offset: 0x0013AEAC
		public List<ulong> GetEquipedEquipments()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetEquipedEquipments_hotfix != null)
			{
				return (List<ulong>)this.m_GetEquipedEquipments_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_wearedEquipmentHeroDict.Keys.ToList<ulong>();
		}

		// Token: 0x0600423D RID: 16957 RVA: 0x0013CD28 File Offset: 0x0013AF28
		private List<int> GetUnlcokJobAchievements(ConfigDataJobConnectionInfo jobConnectionInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetUnlcokJobAchievementsConfigDataJobConnectionInfo_hotfix != null)
			{
				return (List<int>)this.m_GetUnlcokJobAchievementsConfigDataJobConnectionInfo_hotfix.call(new object[]
				{
					this,
					jobConnectionInfo
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<int> list = new List<int>();
			if (this.IsNeedUnlock(jobConnectionInfo))
			{
				foreach (ConfigDataJobUnlockConditionInfo configDataJobUnlockConditionInfo in jobConnectionInfo.m_unlockConditions)
				{
					if (configDataJobUnlockConditionInfo.AchievementID != 0)
					{
						list.Add(configDataJobUnlockConditionInfo.AchievementID);
					}
				}
			}
			return list;
		}

		// Token: 0x0600423E RID: 16958 RVA: 0x0013CE18 File Offset: 0x0013B018
		public int GetSkillEnergyFromConfig(int heroLevel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSkillEnergyFromConfigInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetSkillEnergyFromConfigInt32_hotfix.call(new object[]
				{
					this,
					heroLevel
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int result = int.MaxValue;
			ConfigDataHeroLevelInfo configDataHeroLevelInfo = this.m_configDataLoader.GetConfigDataHeroLevelInfo(heroLevel);
			if (configDataHeroLevelInfo != null)
			{
				result = configDataHeroLevelInfo.SkillPoint;
			}
			return result;
		}

		// Token: 0x0600423F RID: 16959 RVA: 0x0013CEB8 File Offset: 0x0013B0B8
		private List<Goods> GetHeroStarLevelUpDataFromConfig(int fragmentId, int newStarLevel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroStarLevelUpDataFromConfigInt32Int32_hotfix != null)
			{
				return (List<Goods>)this.m_GetHeroStarLevelUpDataFromConfigInt32Int32_hotfix.call(new object[]
				{
					this,
					fragmentId,
					newStarLevel
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Goods> list = new List<Goods>();
			ConfigDataHeroStarInfo configDataHeroStarInfo = this.m_configDataLoader.GetConfigDataHeroStarInfo(newStarLevel);
			if (configDataHeroStarInfo == null)
			{
				return list;
			}
			int fragment = configDataHeroStarInfo.Fragment;
			configDataHeroStarInfo = this.m_configDataLoader.GetConfigDataHeroStarInfo(newStarLevel - 1);
			if (configDataHeroStarInfo == null)
			{
				return list;
			}
			int num = fragment - configDataHeroStarInfo.Fragment;
			if (num <= 0)
			{
				return list;
			}
			Goods item = GoodsFactory.CreateGoods(GoodsType.GoodsType_Item, fragmentId, num);
			list.Add(item);
			return list;
		}

		// Token: 0x06004240 RID: 16960 RVA: 0x0013CFA4 File Offset: 0x0013B1A4
		private int GetSkillCostFromConfig(int skillId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSkillCostFromConfigInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetSkillCostFromConfigInt32_hotfix.call(new object[]
				{
					this,
					skillId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int result = int.MaxValue;
			ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(skillId);
			if (configDataSkillInfo != null)
			{
				result = configDataSkillInfo.SkillCost;
			}
			return result;
		}

		// Token: 0x14000039 RID: 57
		// (add) Token: 0x06004241 RID: 16961 RVA: 0x0013D044 File Offset: 0x0013B244
		// (remove) Token: 0x06004242 RID: 16962 RVA: 0x0013D0E0 File Offset: 0x0013B2E0
		public event Action<int> AddHeroEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_AddHeroEventAction`1_hotfix != null)
				{
					this.m_add_AddHeroEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.AddHeroEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.AddHeroEvent, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_AddHeroEventAction`1_hotfix != null)
				{
					this.m_remove_AddHeroEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.AddHeroEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.AddHeroEvent, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400003A RID: 58
		// (add) Token: 0x06004243 RID: 16963 RVA: 0x0013D17C File Offset: 0x0013B37C
		// (remove) Token: 0x06004244 RID: 16964 RVA: 0x0013D218 File Offset: 0x0013B418
		public event Action<int, int> SpecificHeroFightMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_SpecificHeroFightMissionEventAction`2_hotfix != null)
				{
					this.m_add_SpecificHeroFightMissionEventAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int> action = this.SpecificHeroFightMissionEvent;
				Action<int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int>>(ref this.SpecificHeroFightMissionEvent, (Action<int, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_SpecificHeroFightMissionEventAction`2_hotfix != null)
				{
					this.m_remove_SpecificHeroFightMissionEventAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int> action = this.SpecificHeroFightMissionEvent;
				Action<int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int>>(ref this.SpecificHeroFightMissionEvent, (Action<int, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400003B RID: 59
		// (add) Token: 0x06004245 RID: 16965 RVA: 0x0013D2B4 File Offset: 0x0013B4B4
		// (remove) Token: 0x06004246 RID: 16966 RVA: 0x0013D350 File Offset: 0x0013B550
		public event Action<int, int> HeroNewJobTransferMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_HeroNewJobTransferMissionEventAction`2_hotfix != null)
				{
					this.m_add_HeroNewJobTransferMissionEventAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int> action = this.HeroNewJobTransferMissionEvent;
				Action<int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int>>(ref this.HeroNewJobTransferMissionEvent, (Action<int, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_HeroNewJobTransferMissionEventAction`2_hotfix != null)
				{
					this.m_remove_HeroNewJobTransferMissionEventAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int> action = this.HeroNewJobTransferMissionEvent;
				Action<int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int>>(ref this.HeroNewJobTransferMissionEvent, (Action<int, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400003C RID: 60
		// (add) Token: 0x06004247 RID: 16967 RVA: 0x0013D3EC File Offset: 0x0013B5EC
		// (remove) Token: 0x06004248 RID: 16968 RVA: 0x0013D488 File Offset: 0x0013B688
		public event Action HeroJobLevelUpMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_HeroJobLevelUpMissionEventAction_hotfix != null)
				{
					this.m_add_HeroJobLevelUpMissionEventAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.HeroJobLevelUpMissionEvent;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.HeroJobLevelUpMissionEvent, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_HeroJobLevelUpMissionEventAction_hotfix != null)
				{
					this.m_remove_HeroJobLevelUpMissionEventAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.HeroJobLevelUpMissionEvent;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.HeroJobLevelUpMissionEvent, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400003D RID: 61
		// (add) Token: 0x06004249 RID: 16969 RVA: 0x0013D524 File Offset: 0x0013B724
		// (remove) Token: 0x0600424A RID: 16970 RVA: 0x0013D5C0 File Offset: 0x0013B7C0
		public event Action<int, int> HeroJobMasterMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_HeroJobMasterMissionEventAction`2_hotfix != null)
				{
					this.m_add_HeroJobMasterMissionEventAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int> action = this.HeroJobMasterMissionEvent;
				Action<int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int>>(ref this.HeroJobMasterMissionEvent, (Action<int, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_HeroJobMasterMissionEventAction`2_hotfix != null)
				{
					this.m_remove_HeroJobMasterMissionEventAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int> action = this.HeroJobMasterMissionEvent;
				Action<int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int>>(ref this.HeroJobMasterMissionEvent, (Action<int, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400003E RID: 62
		// (add) Token: 0x0600424B RID: 16971 RVA: 0x0013D65C File Offset: 0x0013B85C
		// (remove) Token: 0x0600424C RID: 16972 RVA: 0x0013D6F8 File Offset: 0x0013B8F8
		public event Action AddHeroJobMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_AddHeroJobMissionEventAction_hotfix != null)
				{
					this.m_add_AddHeroJobMissionEventAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.AddHeroJobMissionEvent;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.AddHeroJobMissionEvent, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_AddHeroJobMissionEventAction_hotfix != null)
				{
					this.m_remove_AddHeroJobMissionEventAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.AddHeroJobMissionEvent;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.AddHeroJobMissionEvent, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400003F RID: 63
		// (add) Token: 0x0600424D RID: 16973 RVA: 0x0013D794 File Offset: 0x0013B994
		// (remove) Token: 0x0600424E RID: 16974 RVA: 0x0013D830 File Offset: 0x0013BA30
		public event Action<int> HeroLevelUpMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_HeroLevelUpMissionEventAction`1_hotfix != null)
				{
					this.m_add_HeroLevelUpMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.HeroLevelUpMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.HeroLevelUpMissionEvent, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_HeroLevelUpMissionEventAction`1_hotfix != null)
				{
					this.m_remove_HeroLevelUpMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.HeroLevelUpMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.HeroLevelUpMissionEvent, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000040 RID: 64
		// (add) Token: 0x0600424F RID: 16975 RVA: 0x0013D8CC File Offset: 0x0013BACC
		// (remove) Token: 0x06004250 RID: 16976 RVA: 0x0013D968 File Offset: 0x0013BB68
		public event Action<int> AddHeroJobSkillMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_AddHeroJobSkillMissionEventAction`1_hotfix != null)
				{
					this.m_add_AddHeroJobSkillMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.AddHeroJobSkillMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.AddHeroJobSkillMissionEvent, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_AddHeroJobSkillMissionEventAction`1_hotfix != null)
				{
					this.m_remove_AddHeroJobSkillMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.AddHeroJobSkillMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.AddHeroJobSkillMissionEvent, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000041 RID: 65
		// (add) Token: 0x06004251 RID: 16977 RVA: 0x0013DA04 File Offset: 0x0013BC04
		// (remove) Token: 0x06004252 RID: 16978 RVA: 0x0013DAA0 File Offset: 0x0013BCA0
		public event Action<int> AddHeroJobSoliderMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_AddHeroJobSoliderMissionEventAction`1_hotfix != null)
				{
					this.m_add_AddHeroJobSoliderMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.AddHeroJobSoliderMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.AddHeroJobSoliderMissionEvent, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_AddHeroJobSoliderMissionEventAction`1_hotfix != null)
				{
					this.m_remove_AddHeroJobSoliderMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.AddHeroJobSoliderMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.AddHeroJobSoliderMissionEvent, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000042 RID: 66
		// (add) Token: 0x06004253 RID: 16979 RVA: 0x0013DB3C File Offset: 0x0013BD3C
		// (remove) Token: 0x06004254 RID: 16980 RVA: 0x0013DBD8 File Offset: 0x0013BDD8
		public event Action<int> AddHeroMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_AddHeroMissionEventAction`1_hotfix != null)
				{
					this.m_add_AddHeroMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.AddHeroMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.AddHeroMissionEvent, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_AddHeroMissionEventAction`1_hotfix != null)
				{
					this.m_remove_AddHeroMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.AddHeroMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.AddHeroMissionEvent, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000043 RID: 67
		// (add) Token: 0x06004255 RID: 16981 RVA: 0x0013DC74 File Offset: 0x0013BE74
		// (remove) Token: 0x06004256 RID: 16982 RVA: 0x0013DD10 File Offset: 0x0013BF10
		public event Action<int> LevelUpHeroStarLevelMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_LevelUpHeroStarLevelMissionEventAction`1_hotfix != null)
				{
					this.m_add_LevelUpHeroStarLevelMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.LevelUpHeroStarLevelMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.LevelUpHeroStarLevelMissionEvent, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_LevelUpHeroStarLevelMissionEventAction`1_hotfix != null)
				{
					this.m_remove_LevelUpHeroStarLevelMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.LevelUpHeroStarLevelMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.LevelUpHeroStarLevelMissionEvent, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1700115B RID: 4443
		// (get) Token: 0x06004257 RID: 16983 RVA: 0x0013DDAC File Offset: 0x0013BFAC
		// (set) Token: 0x06004258 RID: 16984 RVA: 0x0013DDCC File Offset: 0x0013BFCC
		[DoNotToLua]
		public HeroComponentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroComponentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06004259 RID: 16985 RVA: 0x0013DDD8 File Offset: 0x0013BFD8
		private void __callDele_AddHeroEvent(int obj)
		{
			Action<int> addHeroEvent = this.AddHeroEvent;
			if (addHeroEvent != null)
			{
				addHeroEvent(obj);
			}
		}

		// Token: 0x0600425A RID: 16986 RVA: 0x0013DDFC File Offset: 0x0013BFFC
		private void __clearDele_AddHeroEvent(int obj)
		{
			this.AddHeroEvent = null;
		}

		// Token: 0x0600425B RID: 16987 RVA: 0x0013DE08 File Offset: 0x0013C008
		private void __callDele_SpecificHeroFightMissionEvent(int arg1, int arg2)
		{
			Action<int, int> specificHeroFightMissionEvent = this.SpecificHeroFightMissionEvent;
			if (specificHeroFightMissionEvent != null)
			{
				specificHeroFightMissionEvent(arg1, arg2);
			}
		}

		// Token: 0x0600425C RID: 16988 RVA: 0x0013DE2C File Offset: 0x0013C02C
		private void __clearDele_SpecificHeroFightMissionEvent(int arg1, int arg2)
		{
			this.SpecificHeroFightMissionEvent = null;
		}

		// Token: 0x0600425D RID: 16989 RVA: 0x0013DE38 File Offset: 0x0013C038
		private void __callDele_HeroNewJobTransferMissionEvent(int arg1, int arg2)
		{
			Action<int, int> heroNewJobTransferMissionEvent = this.HeroNewJobTransferMissionEvent;
			if (heroNewJobTransferMissionEvent != null)
			{
				heroNewJobTransferMissionEvent(arg1, arg2);
			}
		}

		// Token: 0x0600425E RID: 16990 RVA: 0x0013DE5C File Offset: 0x0013C05C
		private void __clearDele_HeroNewJobTransferMissionEvent(int arg1, int arg2)
		{
			this.HeroNewJobTransferMissionEvent = null;
		}

		// Token: 0x0600425F RID: 16991 RVA: 0x0013DE68 File Offset: 0x0013C068
		private void __callDele_HeroJobLevelUpMissionEvent()
		{
			Action heroJobLevelUpMissionEvent = this.HeroJobLevelUpMissionEvent;
			if (heroJobLevelUpMissionEvent != null)
			{
				heroJobLevelUpMissionEvent();
			}
		}

		// Token: 0x06004260 RID: 16992 RVA: 0x0013DE88 File Offset: 0x0013C088
		private void __clearDele_HeroJobLevelUpMissionEvent()
		{
			this.HeroJobLevelUpMissionEvent = null;
		}

		// Token: 0x06004261 RID: 16993 RVA: 0x0013DE94 File Offset: 0x0013C094
		private void __callDele_HeroJobMasterMissionEvent(int arg1, int arg2)
		{
			Action<int, int> heroJobMasterMissionEvent = this.HeroJobMasterMissionEvent;
			if (heroJobMasterMissionEvent != null)
			{
				heroJobMasterMissionEvent(arg1, arg2);
			}
		}

		// Token: 0x06004262 RID: 16994 RVA: 0x0013DEB8 File Offset: 0x0013C0B8
		private void __clearDele_HeroJobMasterMissionEvent(int arg1, int arg2)
		{
			this.HeroJobMasterMissionEvent = null;
		}

		// Token: 0x06004263 RID: 16995 RVA: 0x0013DEC4 File Offset: 0x0013C0C4
		private void __callDele_AddHeroJobMissionEvent()
		{
			Action addHeroJobMissionEvent = this.AddHeroJobMissionEvent;
			if (addHeroJobMissionEvent != null)
			{
				addHeroJobMissionEvent();
			}
		}

		// Token: 0x06004264 RID: 16996 RVA: 0x0013DEE4 File Offset: 0x0013C0E4
		private void __clearDele_AddHeroJobMissionEvent()
		{
			this.AddHeroJobMissionEvent = null;
		}

		// Token: 0x06004265 RID: 16997 RVA: 0x0013DEF0 File Offset: 0x0013C0F0
		private void __callDele_HeroLevelUpMissionEvent(int obj)
		{
			Action<int> heroLevelUpMissionEvent = this.HeroLevelUpMissionEvent;
			if (heroLevelUpMissionEvent != null)
			{
				heroLevelUpMissionEvent(obj);
			}
		}

		// Token: 0x06004266 RID: 16998 RVA: 0x0013DF14 File Offset: 0x0013C114
		private void __clearDele_HeroLevelUpMissionEvent(int obj)
		{
			this.HeroLevelUpMissionEvent = null;
		}

		// Token: 0x06004267 RID: 16999 RVA: 0x0013DF20 File Offset: 0x0013C120
		private void __callDele_AddHeroJobSkillMissionEvent(int obj)
		{
			Action<int> addHeroJobSkillMissionEvent = this.AddHeroJobSkillMissionEvent;
			if (addHeroJobSkillMissionEvent != null)
			{
				addHeroJobSkillMissionEvent(obj);
			}
		}

		// Token: 0x06004268 RID: 17000 RVA: 0x0013DF44 File Offset: 0x0013C144
		private void __clearDele_AddHeroJobSkillMissionEvent(int obj)
		{
			this.AddHeroJobSkillMissionEvent = null;
		}

		// Token: 0x06004269 RID: 17001 RVA: 0x0013DF50 File Offset: 0x0013C150
		private void __callDele_AddHeroJobSoliderMissionEvent(int obj)
		{
			Action<int> addHeroJobSoliderMissionEvent = this.AddHeroJobSoliderMissionEvent;
			if (addHeroJobSoliderMissionEvent != null)
			{
				addHeroJobSoliderMissionEvent(obj);
			}
		}

		// Token: 0x0600426A RID: 17002 RVA: 0x0013DF74 File Offset: 0x0013C174
		private void __clearDele_AddHeroJobSoliderMissionEvent(int obj)
		{
			this.AddHeroJobSoliderMissionEvent = null;
		}

		// Token: 0x0600426B RID: 17003 RVA: 0x0013DF80 File Offset: 0x0013C180
		private void __callDele_AddHeroMissionEvent(int obj)
		{
			Action<int> addHeroMissionEvent = this.AddHeroMissionEvent;
			if (addHeroMissionEvent != null)
			{
				addHeroMissionEvent(obj);
			}
		}

		// Token: 0x0600426C RID: 17004 RVA: 0x0013DFA4 File Offset: 0x0013C1A4
		private void __clearDele_AddHeroMissionEvent(int obj)
		{
			this.AddHeroMissionEvent = null;
		}

		// Token: 0x0600426D RID: 17005 RVA: 0x0013DFB0 File Offset: 0x0013C1B0
		private void __callDele_LevelUpHeroStarLevelMissionEvent(int obj)
		{
			Action<int> levelUpHeroStarLevelMissionEvent = this.LevelUpHeroStarLevelMissionEvent;
			if (levelUpHeroStarLevelMissionEvent != null)
			{
				levelUpHeroStarLevelMissionEvent(obj);
			}
		}

		// Token: 0x0600426E RID: 17006 RVA: 0x0013DFD4 File Offset: 0x0013C1D4
		private void __clearDele_LevelUpHeroStarLevelMissionEvent(int obj)
		{
			this.LevelUpHeroStarLevelMissionEvent = null;
		}

		// Token: 0x06004271 RID: 17009 RVA: 0x0013DFFC File Offset: 0x0013C1FC
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
					this.m_GetName_hotfix = (luaObj.RawGet("GetName") as LuaFunction);
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_PostInit_hotfix = (luaObj.RawGet("PostInit") as LuaFunction);
					this.m_DeInit_hotfix = (luaObj.RawGet("DeInit") as LuaFunction);
					this.m_TickUInt32_hotfix = (luaObj.RawGet("Tick") as LuaFunction);
					this.m_SerializeT_hotfix = (luaObj.RawGet("Serialize") as LuaFunction);
					this.m_DeSerializeT_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_PostDeSerialize_hotfix = (luaObj.RawGet("PostDeSerialize") as LuaFunction);
					this.m_get_Owner_hotfix = (luaObj.RawGet("get_Owner") as LuaFunction);
					this.m_set_OwnerIComponentOwner_hotfix = (luaObj.RawGet("set_Owner") as LuaFunction);
					this.m_GetProtagonistID_hotfix = (luaObj.RawGet("GetProtagonistID") as LuaFunction);
					this.m_IsProtagonistHeroInt32_hotfix = (luaObj.RawGet("IsProtagonistHero") as LuaFunction);
					this.m_IsProtagonistExist_hotfix = (luaObj.RawGet("IsProtagonistExist") as LuaFunction);
					this.m_SetProtagonistInt32_hotfix = (luaObj.RawGet("SetProtagonist") as LuaFunction);
					this.m_GetAllStarLvlMaxHeroes_hotfix = (luaObj.RawGet("GetAllStarLvlMaxHeroes") as LuaFunction);
					this.m_GetAllStarLvlMaxHeroFragments_hotfix = (luaObj.RawGet("GetAllStarLvlMaxHeroFragments") as LuaFunction);
					this.m_InitHeroDataByCaculateHero_hotfix = (luaObj.RawGet("InitHeroDataByCaculate") as LuaFunction);
					this.m_InitHeroJobsHero_hotfix = (luaObj.RawGet("InitHeroJobs") as LuaFunction);
					this.m_AddHeroDefaultInfosHeroConfigDataHeroInfo_hotfix = (luaObj.RawGet("AddHeroDefaultInfos") as LuaFunction);
					this.m_CanHeroJobEquipSkillInt32Int32_hotfix = (luaObj.RawGet("CanHeroJobEquipSkill") as LuaFunction);
					this.m_CanSelectSkillHeroHeroList`1_hotfix = (luaObj.RawGet("CanSelectSkillHero") as LuaFunction);
					this.m_SelectSkillsInt32List`1_hotfix = (luaObj.RawGet("SelectSkills") as LuaFunction);
					this.m_SelectSoldierInt32Int32_hotfix = (luaObj.RawGet("SelectSoldier") as LuaFunction);
					this.m_CanHeroSelectSoliderHeroInt32_hotfix = (luaObj.RawGet("CanHeroSelectSolider") as LuaFunction);
					this.m_RemoveHeroInt32_hotfix = (luaObj.RawGet("RemoveHero") as LuaFunction);
					this.m_RemoveAllHeroList`1_hotfix = (luaObj.RawGet("RemoveAllHero") as LuaFunction);
					this.m_RemoveAllHeros_hotfix = (luaObj.RawGet("RemoveAllHeros") as LuaFunction);
					this.m_GetAllHeros_hotfix = (luaObj.RawGet("GetAllHeros") as LuaFunction);
					this.m_FindHeroJobHeroInt32_hotfix = (luaObj.RawGet("FindHeroJob") as LuaFunction);
					this.m_IsUnlockedHeroJobHeroInt32_hotfix = (luaObj.RawGet("IsUnlockedHeroJob") as LuaFunction);
					this.m_CanGetHeroJobByRankHeroInt32_hotfix = (luaObj.RawGet("CanGetHeroJobByRank") as LuaFunction);
					this.m_FindHeroJobInt32Int32_hotfix = (luaObj.RawGet("FindHeroJob") as LuaFunction);
					this.m_FindHeroInt32_hotfix = (luaObj.RawGet("FindHero") as LuaFunction);
					this.m_AddHeroFightNumsInt32Int32_hotfix = (luaObj.RawGet("AddHeroFightNums") as LuaFunction);
					this.m_AddHeroAllNeedJobsAchievementsInt32List`1_hotfix = (luaObj.RawGet("AddHeroAllNeedJobsAchievements") as LuaFunction);
					this.m_AddHeroInt32_hotfix = (luaObj.RawGet("AddHero") as LuaFunction);
					this.m_AddHeroInfosConfigDataHeroInfo_hotfix = (luaObj.RawGet("AddHeroInfos") as LuaFunction);
					this.m_IsWastefulAddExpHeroInt32_hotfix = (luaObj.RawGet("IsWastefulAddExp") as LuaFunction);
					this.m_IsCurrentLevelMaxHeroLevelInt32_hotfix = (luaObj.RawGet("IsCurrentLevelMaxHeroLevel") as LuaFunction);
					this.m_IsFullCurrentHeroExpHero_hotfix = (luaObj.RawGet("IsFullCurrentHeroExp") as LuaFunction);
					this.m_AddHeroesExpList`1Int32_hotfix = (luaObj.RawGet("AddHeroesExp") as LuaFunction);
					this.m_CanAddHeroExpInt32_hotfix = (luaObj.RawGet("CanAddHeroExp") as LuaFunction);
					this.m_AddHeroExpInt32Int32_hotfix = (luaObj.RawGet("AddHeroExp") as LuaFunction);
					this.m_OutPutHeroLevelUpOperateLogInt32Int32_hotfix = (luaObj.RawGet("OutPutHeroLevelUpOperateLog") as LuaFunction);
					this.m_AddHeroExpByUseableBagItemInt32GoodsTypeInt32Int32_hotfix = (luaObj.RawGet("AddHeroExpByUseableBagItem") as LuaFunction);
					this.m_ComposeHeroInt32_hotfix = (luaObj.RawGet("ComposeHero") as LuaFunction);
					this.m_IsLvlMaxHeroStarHero_hotfix = (luaObj.RawGet("IsLvlMaxHeroStar") as LuaFunction);
					this.m_LevelUpHeroStarLevelInt32_hotfix = (luaObj.RawGet("LevelUpHeroStarLevel") as LuaFunction);
					this.m_OutPutHeroUpgradeOperateLogInt32Int32List`1_hotfix = (luaObj.RawGet("OutPutHeroUpgradeOperateLog") as LuaFunction);
					this.m_GetGainHeroIds_hotfix = (luaObj.RawGet("GetGainHeroIds") as LuaFunction);
					this.m_HasGainHeroInt32_hotfix = (luaObj.RawGet("HasGainHero") as LuaFunction);
					this.m_IsExistSkillIdInt32_hotfix = (luaObj.RawGet("IsExistSkillId") as LuaFunction);
					this.m_IsExistSoliderIdInt32_hotfix = (luaObj.RawGet("IsExistSoliderId") as LuaFunction);
					this.m_FindTopLevelHeroesInt32_hotfix = (luaObj.RawGet("FindTopLevelHeroes") as LuaFunction);
					this.m_GetActiveHeroJobRelatedIdByHeroIdInt32_hotfix = (luaObj.RawGet("GetActiveHeroJobRelatedIdByHeroId") as LuaFunction);
					this.m_GmResetHeroJobInt32_hotfix = (luaObj.RawGet("GmResetHeroJob") as LuaFunction);
					this.m_OnHeroLevelUpInt32Hero_hotfix = (luaObj.RawGet("OnHeroLevelUp") as LuaFunction);
					this.m_GetAdditiveHeroAddExpInt32_hotfix = (luaObj.RawGet("GetAdditiveHeroAddExp") as LuaFunction);
					this.m_GetAdditiveHeroFavourabilityAddExpInt32_hotfix = (luaObj.RawGet("GetAdditiveHeroFavourabilityAddExp") as LuaFunction);
					this.m_AddHeroJobAchievementsAfterBattleLevelEndList`1List`1_hotfix = (luaObj.RawGet("AddHeroJobAchievementsAfterBattleLevelEnd") as LuaFunction);
					this.m_AddHeroJobHeroConfigDataJobConnectionInfo_hotfix = (luaObj.RawGet("AddHeroJob") as LuaFunction);
					this.m_IsJobLevelMaxConfigDataJobConnectionInfoInt32_hotfix = (luaObj.RawGet("IsJobLevelMax") as LuaFunction);
					this.m_IsJobLevelMaxHeroJob_hotfix = (luaObj.RawGet("IsJobLevelMax") as LuaFunction);
					this.m_CanLevelUpHeroJobLevelInt32Int32_hotfix = (luaObj.RawGet("CanLevelUpHeroJobLevel") as LuaFunction);
					this.m_CanTransferHeroJobRankInt32Int32_hotfix = (luaObj.RawGet("CanTransferHeroJobRank") as LuaFunction);
					this.m_CanTransferHeroJobInt32Int32_hotfix = (luaObj.RawGet("CanTransferHeroJob") as LuaFunction);
					this.m_TransferHeroJobInt32Int32_hotfix = (luaObj.RawGet("TransferHeroJob") as LuaFunction);
					this.m_OutPutHeroJobChangeOperateLogInt32Int32Int32List`1_hotfix = (luaObj.RawGet("OutPutHeroJobChangeOperateLog") as LuaFunction);
					this.m_OnTransferHeroJobHeroConfigDataJobConnectionInfoInt32_hotfix = (luaObj.RawGet("OnTransferHeroJob") as LuaFunction);
					this.m_TryEquipNewSkillHeroInt32_hotfix = (luaObj.RawGet("TryEquipNewSkill") as LuaFunction);
					this.m_IsNeedUnlockConfigDataJobConnectionInfo_hotfix = (luaObj.RawGet("IsNeedUnlock") as LuaFunction);
					this.m_IsNeedAddAchievementConfigDataJobConnectionInfo_hotfix = (luaObj.RawGet("IsNeedAddAchievement") as LuaFunction);
					this.m_UnlockedHeroJobInt32Int32_hotfix = (luaObj.RawGet("UnlockedHeroJob") as LuaFunction);
					this.m_OutPutHeroJobUnlockOperateLogInt32Int32Int32List`1_hotfix = (luaObj.RawGet("OutPutHeroJobUnlockOperateLog") as LuaFunction);
					this.m_CanUnlockedHeroJobHeroConfigDataJobConnectionInfo_hotfix = (luaObj.RawGet("CanUnlockedHeroJob") as LuaFunction);
					this.m_LevelUpHeroJobLevelInt32Int32_hotfix = (luaObj.RawGet("LevelUpHeroJobLevel") as LuaFunction);
					this.m_OutPutHeroJobLevelUpOperateLogInt32Int32Int32List`1_hotfix = (luaObj.RawGet("OutPutHeroJobLevelUpOperateLog") as LuaFunction);
					this.m_AddSkillHeroInt32_hotfix = (luaObj.RawGet("AddSkill") as LuaFunction);
					this.m_AddSoldierHeroInt32Boolean_hotfix = (luaObj.RawGet("AddSoldier") as LuaFunction);
					this.m_AutoTakeOffEquipmentsInt32_hotfix = (luaObj.RawGet("AutoTakeOffEquipments") as LuaFunction);
					this.m_InitWearedEquipments_hotfix = (luaObj.RawGet("InitWearedEquipments") as LuaFunction);
					this.m_CanWearEquipmentInt32UInt64_hotfix = (luaObj.RawGet("CanWearEquipment") as LuaFunction);
					this.m_CanWearEquipmentByJobAndArmyHeroBagItemBase_hotfix = (luaObj.RawGet("CanWearEquipmentByJobAndArmy") as LuaFunction);
					this.m_IsEquipmentWearedUInt64_hotfix = (luaObj.RawGet("IsEquipmentWeared") as LuaFunction);
					this.m_GetWearedEquipmentHeroUInt64_hotfix = (luaObj.RawGet("GetWearedEquipmentHero") as LuaFunction);
					this.m_TakeOffEquipmentsOrNotWhenTransferHeroJobHero_hotfix = (luaObj.RawGet("TakeOffEquipmentsOrNotWhenTransferHeroJob") as LuaFunction);
					this.m_WearEquipmentInt32UInt64_hotfix = (luaObj.RawGet("WearEquipment") as LuaFunction);
					this.m_WearEquipmentBySlotHeroInt32UInt64_hotfix = (luaObj.RawGet("WearEquipmentBySlot") as LuaFunction);
					this.m_TakeOffEquipmentBySlotHeroInt32_hotfix = (luaObj.RawGet("TakeOffEquipmentBySlot") as LuaFunction);
					this.m_CanTakeOffEquipmentInt32Int32_hotfix = (luaObj.RawGet("CanTakeOffEquipment") as LuaFunction);
					this.m_TakeOffEquipmentInt32Int32_hotfix = (luaObj.RawGet("TakeOffEquipment") as LuaFunction);
					this.m_HasBetterEquipmentByHeroInt32_hotfix = (luaObj.RawGet("HasBetterEquipmentByHero") as LuaFunction);
					this.m_HasBetterEquipmentBySlotIdInt32Int32_hotfix = (luaObj.RawGet("HasBetterEquipmentBySlotId") as LuaFunction);
					this.m_GetWearedEquipmentBySlotIdHeroInt32_hotfix = (luaObj.RawGet("GetWearedEquipmentBySlotId") as LuaFunction);
					this.m_HasBetterEquipmentBySlotIdHeroInt32_hotfix = (luaObj.RawGet("HasBetterEquipmentBySlotId") as LuaFunction);
					this.m_IsBetterEquipmentBagItemBaseBagItemBaseInt32_hotfix = (luaObj.RawGet("IsBetterEquipment") as LuaFunction);
					this.m_CanAutoEquipmentByClientInt32_hotfix = (luaObj.RawGet("CanAutoEquipmentByClient") as LuaFunction);
					this.m_CanAutoEquipmentInt32_hotfix = (luaObj.RawGet("CanAutoEquipment") as LuaFunction);
					this.m_CanWearCharSkinInt32Int32_hotfix = (luaObj.RawGet("CanWearCharSkin") as LuaFunction);
					this.m_WearCharSkinInt32Int32_hotfix = (luaObj.RawGet("WearCharSkin") as LuaFunction);
					this.m_CanTakeOffCharSkinInt32_hotfix = (luaObj.RawGet("CanTakeOffCharSkin") as LuaFunction);
					this.m_TakeOffCharSkinInt32_hotfix = (luaObj.RawGet("TakeOffCharSkin") as LuaFunction);
					this.m_CanWearModelSkinInt32Int32Int32_hotfix = (luaObj.RawGet("CanWearModelSkin") as LuaFunction);
					this.m_WearModelSkinInt32Int32Int32_hotfix = (luaObj.RawGet("WearModelSkin") as LuaFunction);
					this.m_CanTakeOffModelSkinInt32Int32_hotfix = (luaObj.RawGet("CanTakeOffModelSkin") as LuaFunction);
					this.m_TakeOffModelSkinInt32Int32_hotfix = (luaObj.RawGet("TakeOffModelSkin") as LuaFunction);
					this.m_CanWearSoldierSkinInt32Int32Int32_hotfix = (luaObj.RawGet("CanWearSoldierSkin") as LuaFunction);
					this.m_WearSoldierSkinInt32Int32Int32Boolean_hotfix = (luaObj.RawGet("WearSoldierSkin") as LuaFunction);
					this.m_CanTakeOffSoldierSkinInt32Int32_hotfix = (luaObj.RawGet("CanTakeOffSoldierSkin") as LuaFunction);
					this.m_TakeOffSoldierSkinInt32Int32Boolean_hotfix = (luaObj.RawGet("TakeOffSoldierSkin") as LuaFunction);
					this.m_TakeOffSoldierSkinApplyToAllInt32Int32_hotfix = (luaObj.RawGet("TakeOffSoldierSkinApplyToAll") as LuaFunction);
					this.m_AddHeroFavorabilityExpByUseableBagItemInt32GoodsTypeInt32Int32_hotfix = (luaObj.RawGet("AddHeroFavorabilityExpByUseableBagItem") as LuaFunction);
					this.m_AddHeroFavorabilityLevelInt32Int32_hotfix = (luaObj.RawGet("AddHeroFavorabilityLevel") as LuaFunction);
					this.m_OutPutHeroFavourabilityOperateLogInt32Int32Int32Int32Int32List`1_hotfix = (luaObj.RawGet("OutPutHeroFavourabilityOperateLog") as LuaFunction);
					this.m_AddHeroFavorabilityLevelHero_hotfix = (luaObj.RawGet("AddHeroFavorabilityLevel") as LuaFunction);
					this.m_GenerateFavorabilityLevelUpRewardInt32Int32_hotfix = (luaObj.RawGet("GenerateFavorabilityLevelUpReward") as LuaFunction);
					this.m_IsFullFavorabilityExpHeroConfigDataHeroInformationInfo_hotfix = (luaObj.RawGet("IsFullFavorabilityExp") as LuaFunction);
					this.m_UpdateProtagonistHeroFavorabilityLevel_hotfix = (luaObj.RawGet("UpdateProtagonistHeroFavorabilityLevel") as LuaFunction);
					this.m_CanUnlockHeroFetterInt32Int32_hotfix = (luaObj.RawGet("CanUnlockHeroFetter") as LuaFunction);
					this.m_CanReachFetterUnlockConditionHeroFetterCompletionCondition_hotfix = (luaObj.RawGet("CanReachFetterUnlockCondition") as LuaFunction);
					this.m_GmLevelUpHeroFetter2SpecificLevelInt32Int32Int32_hotfix = (luaObj.RawGet("GmLevelUpHeroFetter2SpecificLevel") as LuaFunction);
					this.m_CanLevelUpHeroFetterInt32Int32_hotfix = (luaObj.RawGet("CanLevelUpHeroFetter") as LuaFunction);
					this.m_LevelUpHeroFetterInt32Int32_hotfix = (luaObj.RawGet("LevelUpHeroFetter") as LuaFunction);
					this.m_LevelUpHeroFetterCallBackHeroInt32_hotfix = (luaObj.RawGet("LevelUpHeroFetterCallBack") as LuaFunction);
					this.m_OutPutHeroFetterOpereateLogInt32Int32Int32List`1List`1_hotfix = (luaObj.RawGet("OutPutHeroFetterOpereateLog") as LuaFunction);
					this.m_UnlockHeroFetterInt32Int32Boolean_hotfix = (luaObj.RawGet("UnlockHeroFetter") as LuaFunction);
					this.m_GenerateFetterUnlockRewardsInt32Int32_hotfix = (luaObj.RawGet("GenerateFetterUnlockRewards") as LuaFunction);
					this.m_ConfessHeroInt32Boolean_hotfix = (luaObj.RawGet("ConfessHero") as LuaFunction);
					this.m_GenerateConfessionRewardsInt32ConfigDataHeroConfessionInfo_hotfix = (luaObj.RawGet("GenerateConfessionRewards") as LuaFunction);
					this.m_CanConfessHeroInt32_hotfix = (luaObj.RawGet("CanConfessHero") as LuaFunction);
					this.m_FlushHeroInteractNums_hotfix = (luaObj.RawGet("FlushHeroInteractNums") as LuaFunction);
					this.m_InitHeroInteractNums_hotfix = (luaObj.RawGet("InitHeroInteractNums") as LuaFunction);
					this.m_CanFlushHeroInteractNums_hotfix = (luaObj.RawGet("CanFlushHeroInteractNums") as LuaFunction);
					this.m_IsFullHeroInteractNums_hotfix = (luaObj.RawGet("IsFullHeroInteractNums") as LuaFunction);
					this.m_AddHeroInteractNumsInt32Boolean_hotfix = (luaObj.RawGet("AddHeroInteractNums") as LuaFunction);
					this.m_IsHeroInteractNumsEqualToMax_hotfix = (luaObj.RawGet("IsHeroInteractNumsEqualToMax") as LuaFunction);
					this.m_CanInteractHeroInt32_hotfix = (luaObj.RawGet("CanInteractHero") as LuaFunction);
					this.m_GetHeroFavorabilityUpLevelHeroConfigDataHeroInformationInfoInt32_hotfix = (luaObj.RawGet("GetHeroFavorabilityUpLevel") as LuaFunction);
					this.m_GetHeroInteractIdHeroConfigDataHeroInformationInfo_hotfix = (luaObj.RawGet("GetHeroInteractId") as LuaFunction);
					this.m_GetAllHeroBattlePower_hotfix = (luaObj.RawGet("GetAllHeroBattlePower") as LuaFunction);
					this.m_GetLastAllHeroRank_hotfix = (luaObj.RawGet("GetLastAllHeroRank") as LuaFunction);
					this.m_GetTopHeroBattlePower_hotfix = (luaObj.RawGet("GetTopHeroBattlePower") as LuaFunction);
					this.m_GetLastTopHeroRank_hotfix = (luaObj.RawGet("GetLastTopHeroRank") as LuaFunction);
					this.m_GetChampionHeroBattlePower_hotfix = (luaObj.RawGet("GetChampionHeroBattlePower") as LuaFunction);
					this.m_GetChampionHeroId_hotfix = (luaObj.RawGet("GetChampionHeroId") as LuaFunction);
					this.m_GetLastChampionHeroRank_hotfix = (luaObj.RawGet("GetLastChampionHeroRank") as LuaFunction);
					this.m_ComputeBattlePowerHero_hotfix = (luaObj.RawGet("ComputeBattlePower") as LuaFunction);
					this.m_OnHeroBattlePowerChangeHero_hotfix = (luaObj.RawGet("OnHeroBattlePowerChange") as LuaFunction);
					this.m_CanComposeHeroInt32_hotfix = (luaObj.RawGet("CanComposeHero") as LuaFunction);
					this.m_CanLevelUpHeroStarLevelInt32_hotfix = (luaObj.RawGet("CanLevelUpHeroStarLevel") as LuaFunction);
					this.m_GetEquipedEquipments_hotfix = (luaObj.RawGet("GetEquipedEquipments") as LuaFunction);
					this.m_GetUnlcokJobAchievementsConfigDataJobConnectionInfo_hotfix = (luaObj.RawGet("GetUnlcokJobAchievements") as LuaFunction);
					this.m_GetSkillEnergyFromConfigInt32_hotfix = (luaObj.RawGet("GetSkillEnergyFromConfig") as LuaFunction);
					this.m_GetHeroStarLevelUpDataFromConfigInt32Int32_hotfix = (luaObj.RawGet("GetHeroStarLevelUpDataFromConfig") as LuaFunction);
					this.m_GetSkillCostFromConfigInt32_hotfix = (luaObj.RawGet("GetSkillCostFromConfig") as LuaFunction);
					this.m_add_AddHeroEventAction`1_hotfix = (luaObj.RawGet("add_AddHeroEvent") as LuaFunction);
					this.m_remove_AddHeroEventAction`1_hotfix = (luaObj.RawGet("remove_AddHeroEvent") as LuaFunction);
					this.m_add_SpecificHeroFightMissionEventAction`2_hotfix = (luaObj.RawGet("add_SpecificHeroFightMissionEvent") as LuaFunction);
					this.m_remove_SpecificHeroFightMissionEventAction`2_hotfix = (luaObj.RawGet("remove_SpecificHeroFightMissionEvent") as LuaFunction);
					this.m_add_HeroNewJobTransferMissionEventAction`2_hotfix = (luaObj.RawGet("add_HeroNewJobTransferMissionEvent") as LuaFunction);
					this.m_remove_HeroNewJobTransferMissionEventAction`2_hotfix = (luaObj.RawGet("remove_HeroNewJobTransferMissionEvent") as LuaFunction);
					this.m_add_HeroJobLevelUpMissionEventAction_hotfix = (luaObj.RawGet("add_HeroJobLevelUpMissionEvent") as LuaFunction);
					this.m_remove_HeroJobLevelUpMissionEventAction_hotfix = (luaObj.RawGet("remove_HeroJobLevelUpMissionEvent") as LuaFunction);
					this.m_add_HeroJobMasterMissionEventAction`2_hotfix = (luaObj.RawGet("add_HeroJobMasterMissionEvent") as LuaFunction);
					this.m_remove_HeroJobMasterMissionEventAction`2_hotfix = (luaObj.RawGet("remove_HeroJobMasterMissionEvent") as LuaFunction);
					this.m_add_AddHeroJobMissionEventAction_hotfix = (luaObj.RawGet("add_AddHeroJobMissionEvent") as LuaFunction);
					this.m_remove_AddHeroJobMissionEventAction_hotfix = (luaObj.RawGet("remove_AddHeroJobMissionEvent") as LuaFunction);
					this.m_add_HeroLevelUpMissionEventAction`1_hotfix = (luaObj.RawGet("add_HeroLevelUpMissionEvent") as LuaFunction);
					this.m_remove_HeroLevelUpMissionEventAction`1_hotfix = (luaObj.RawGet("remove_HeroLevelUpMissionEvent") as LuaFunction);
					this.m_add_AddHeroJobSkillMissionEventAction`1_hotfix = (luaObj.RawGet("add_AddHeroJobSkillMissionEvent") as LuaFunction);
					this.m_remove_AddHeroJobSkillMissionEventAction`1_hotfix = (luaObj.RawGet("remove_AddHeroJobSkillMissionEvent") as LuaFunction);
					this.m_add_AddHeroJobSoliderMissionEventAction`1_hotfix = (luaObj.RawGet("add_AddHeroJobSoliderMissionEvent") as LuaFunction);
					this.m_remove_AddHeroJobSoliderMissionEventAction`1_hotfix = (luaObj.RawGet("remove_AddHeroJobSoliderMissionEvent") as LuaFunction);
					this.m_add_AddHeroMissionEventAction`1_hotfix = (luaObj.RawGet("add_AddHeroMissionEvent") as LuaFunction);
					this.m_remove_AddHeroMissionEventAction`1_hotfix = (luaObj.RawGet("remove_AddHeroMissionEvent") as LuaFunction);
					this.m_add_LevelUpHeroStarLevelMissionEventAction`1_hotfix = (luaObj.RawGet("add_LevelUpHeroStarLevelMissionEvent") as LuaFunction);
					this.m_remove_LevelUpHeroStarLevelMissionEventAction`1_hotfix = (luaObj.RawGet("remove_LevelUpHeroStarLevelMissionEvent") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06004272 RID: 17010 RVA: 0x0013F210 File Offset: 0x0013D410
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroComponentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003210 RID: 12816
		protected IConfigDataLoader m_configDataLoader;

		// Token: 0x04003212 RID: 12818
		protected BagComponentCommon m_bag;

		// Token: 0x04003213 RID: 12819
		protected RiftComponentCommon m_rift;

		// Token: 0x04003214 RID: 12820
		protected MissionComponentCommon m_mission;

		// Token: 0x04003215 RID: 12821
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x04003216 RID: 12822
		protected BattleComponentCommon m_battle;

		// Token: 0x04003217 RID: 12823
		protected ResourceComponentCommon m_resource;

		// Token: 0x04003218 RID: 12824
		protected GuildComponentCommon m_guild;

		// Token: 0x04003219 RID: 12825
		protected TrainingGroundCompomentCommon m_trainingGround;

		// Token: 0x0400321A RID: 12826
		protected DataSectionHero m_heroDS = new DataSectionHero();

		// Token: 0x04003225 RID: 12837
		protected Dictionary<ulong, int> m_wearedEquipmentHeroDict;

		// Token: 0x04003226 RID: 12838
		protected HashSet<int> m_soliders;

		// Token: 0x04003227 RID: 12839
		protected HashSet<int> m_skills;

		// Token: 0x04003228 RID: 12840
		protected Dictionary<int, DateTime> m_atuoEquipmentTouch;

		// Token: 0x04003229 RID: 12841
		public Action<Hero> HeroFavorabilityLevelupMissionEvent;

		// Token: 0x0400322A RID: 12842
		public Action<Hero, int> HeroFetterLevelupMissionEvent;

		// Token: 0x0400322B RID: 12843
		[DoNotToLua]
		private HeroComponentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x0400322E RID: 12846
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400322F RID: 12847
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003230 RID: 12848
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04003231 RID: 12849
		private LuaFunction m_GetName_hotfix;

		// Token: 0x04003232 RID: 12850
		private LuaFunction m_Init_hotfix;

		// Token: 0x04003233 RID: 12851
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04003234 RID: 12852
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04003235 RID: 12853
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x04003236 RID: 12854
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x04003237 RID: 12855
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x04003238 RID: 12856
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x04003239 RID: 12857
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x0400323A RID: 12858
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x0400323B RID: 12859
		private LuaFunction m_GetProtagonistID_hotfix;

		// Token: 0x0400323C RID: 12860
		private LuaFunction m_IsProtagonistHeroInt32_hotfix;

		// Token: 0x0400323D RID: 12861
		private LuaFunction m_IsProtagonistExist_hotfix;

		// Token: 0x0400323E RID: 12862
		private LuaFunction m_SetProtagonistInt32_hotfix;

		// Token: 0x0400323F RID: 12863
		private LuaFunction m_GetAllStarLvlMaxHeroes_hotfix;

		// Token: 0x04003240 RID: 12864
		private LuaFunction m_GetAllStarLvlMaxHeroFragments_hotfix;

		// Token: 0x04003241 RID: 12865
		private LuaFunction m_InitHeroDataByCaculateHero_hotfix;

		// Token: 0x04003242 RID: 12866
		private LuaFunction m_InitHeroJobsHero_hotfix;

		// Token: 0x04003243 RID: 12867
		private LuaFunction m_AddHeroDefaultInfosHeroConfigDataHeroInfo_hotfix;

		// Token: 0x04003244 RID: 12868
		private LuaFunction m_CanHeroJobEquipSkillInt32Int32_hotfix;

		// Token: 0x04003245 RID: 12869
		private LuaFunction m_CanSelectSkillHeroHeroList;

		// Token: 0x04003246 RID: 12870
		private LuaFunction m_SelectSkillsInt32List;

		// Token: 0x04003247 RID: 12871
		private LuaFunction m_SelectSoldierInt32Int32_hotfix;

		// Token: 0x04003248 RID: 12872
		private LuaFunction m_CanHeroSelectSoliderHeroInt32_hotfix;

		// Token: 0x04003249 RID: 12873
		private LuaFunction m_RemoveHeroInt32_hotfix;

		// Token: 0x0400324A RID: 12874
		private LuaFunction m_RemoveAllHeroList;

		// Token: 0x0400324B RID: 12875
		private LuaFunction m_RemoveAllHeros_hotfix;

		// Token: 0x0400324C RID: 12876
		private LuaFunction m_GetAllHeros_hotfix;

		// Token: 0x0400324D RID: 12877
		private LuaFunction m_FindHeroJobHeroInt32_hotfix;

		// Token: 0x0400324E RID: 12878
		private LuaFunction m_IsUnlockedHeroJobHeroInt32_hotfix;

		// Token: 0x0400324F RID: 12879
		private LuaFunction m_CanGetHeroJobByRankHeroInt32_hotfix;

		// Token: 0x04003250 RID: 12880
		private LuaFunction m_FindHeroJobInt32Int32_hotfix;

		// Token: 0x04003251 RID: 12881
		private LuaFunction m_FindHeroInt32_hotfix;

		// Token: 0x04003252 RID: 12882
		private LuaFunction m_AddHeroFightNumsInt32Int32_hotfix;

		// Token: 0x04003253 RID: 12883
		private LuaFunction m_AddHeroAllNeedJobsAchievementsInt32List;

		// Token: 0x04003254 RID: 12884
		private LuaFunction m_AddHeroInt32_hotfix;

		// Token: 0x04003255 RID: 12885
		private LuaFunction m_AddHeroInfosConfigDataHeroInfo_hotfix;

		// Token: 0x04003256 RID: 12886
		private LuaFunction m_IsWastefulAddExpHeroInt32_hotfix;

		// Token: 0x04003257 RID: 12887
		private LuaFunction m_IsCurrentLevelMaxHeroLevelInt32_hotfix;

		// Token: 0x04003258 RID: 12888
		private LuaFunction m_IsFullCurrentHeroExpHero_hotfix;

		// Token: 0x04003259 RID: 12889
		private LuaFunction m_AddHeroesExpList;

		// Token: 0x0400325A RID: 12890
		private LuaFunction m_CanAddHeroExpInt32_hotfix;

		// Token: 0x0400325B RID: 12891
		private LuaFunction m_AddHeroExpInt32Int32_hotfix;

		// Token: 0x0400325C RID: 12892
		private LuaFunction m_OutPutHeroLevelUpOperateLogInt32Int32_hotfix;

		// Token: 0x0400325D RID: 12893
		private LuaFunction m_AddHeroExpByUseableBagItemInt32GoodsTypeInt32Int32_hotfix;

		// Token: 0x0400325E RID: 12894
		private LuaFunction m_ComposeHeroInt32_hotfix;

		// Token: 0x0400325F RID: 12895
		private LuaFunction m_IsLvlMaxHeroStarHero_hotfix;

		// Token: 0x04003260 RID: 12896
		private LuaFunction m_LevelUpHeroStarLevelInt32_hotfix;

		// Token: 0x04003261 RID: 12897
		private LuaFunction m_OutPutHeroUpgradeOperateLogInt32Int32List;

		// Token: 0x04003262 RID: 12898
		private LuaFunction m_GetGainHeroIds_hotfix;

		// Token: 0x04003263 RID: 12899
		private LuaFunction m_HasGainHeroInt32_hotfix;

		// Token: 0x04003264 RID: 12900
		private LuaFunction m_IsExistSkillIdInt32_hotfix;

		// Token: 0x04003265 RID: 12901
		private LuaFunction m_IsExistSoliderIdInt32_hotfix;

		// Token: 0x04003266 RID: 12902
		private LuaFunction m_FindTopLevelHeroesInt32_hotfix;

		// Token: 0x04003267 RID: 12903
		private LuaFunction m_GetActiveHeroJobRelatedIdByHeroIdInt32_hotfix;

		// Token: 0x04003268 RID: 12904
		private LuaFunction m_GmResetHeroJobInt32_hotfix;

		// Token: 0x04003269 RID: 12905
		private LuaFunction m_OnHeroLevelUpInt32Hero_hotfix;

		// Token: 0x0400326A RID: 12906
		private LuaFunction m_GetAdditiveHeroAddExpInt32_hotfix;

		// Token: 0x0400326B RID: 12907
		private LuaFunction m_GetAdditiveHeroFavourabilityAddExpInt32_hotfix;

		// Token: 0x0400326C RID: 12908
		private LuaFunction m_AddHeroJobAchievementsAfterBattleLevelEndList`1List;

		// Token: 0x0400326D RID: 12909
		private LuaFunction m_AddHeroJobHeroConfigDataJobConnectionInfo_hotfix;

		// Token: 0x0400326E RID: 12910
		private LuaFunction m_IsJobLevelMaxConfigDataJobConnectionInfoInt32_hotfix;

		// Token: 0x0400326F RID: 12911
		private LuaFunction m_IsJobLevelMaxHeroJob_hotfix;

		// Token: 0x04003270 RID: 12912
		private LuaFunction m_CanLevelUpHeroJobLevelInt32Int32_hotfix;

		// Token: 0x04003271 RID: 12913
		private LuaFunction m_CanTransferHeroJobRankInt32Int32_hotfix;

		// Token: 0x04003272 RID: 12914
		private LuaFunction m_CanTransferHeroJobInt32Int32_hotfix;

		// Token: 0x04003273 RID: 12915
		private LuaFunction m_TransferHeroJobInt32Int32_hotfix;

		// Token: 0x04003274 RID: 12916
		private LuaFunction m_OutPutHeroJobChangeOperateLogInt32Int32Int32List;

		// Token: 0x04003275 RID: 12917
		private LuaFunction m_OnTransferHeroJobHeroConfigDataJobConnectionInfoInt32_hotfix;

		// Token: 0x04003276 RID: 12918
		private LuaFunction m_TryEquipNewSkillHeroInt32_hotfix;

		// Token: 0x04003277 RID: 12919
		private LuaFunction m_IsNeedUnlockConfigDataJobConnectionInfo_hotfix;

		// Token: 0x04003278 RID: 12920
		private LuaFunction m_IsNeedAddAchievementConfigDataJobConnectionInfo_hotfix;

		// Token: 0x04003279 RID: 12921
		private LuaFunction m_UnlockedHeroJobInt32Int32_hotfix;

		// Token: 0x0400327A RID: 12922
		private LuaFunction m_OutPutHeroJobUnlockOperateLogInt32Int32Int32List;

		// Token: 0x0400327B RID: 12923
		private LuaFunction m_CanUnlockedHeroJobHeroConfigDataJobConnectionInfo_hotfix;

		// Token: 0x0400327C RID: 12924
		private LuaFunction m_LevelUpHeroJobLevelInt32Int32_hotfix;

		// Token: 0x0400327D RID: 12925
		private LuaFunction m_OutPutHeroJobLevelUpOperateLogInt32Int32Int32List;

		// Token: 0x0400327E RID: 12926
		private LuaFunction m_AddSkillHeroInt32_hotfix;

		// Token: 0x0400327F RID: 12927
		private LuaFunction m_AddSoldierHeroInt32Boolean_hotfix;

		// Token: 0x04003280 RID: 12928
		private LuaFunction m_AutoTakeOffEquipmentsInt32_hotfix;

		// Token: 0x04003281 RID: 12929
		private LuaFunction m_InitWearedEquipments_hotfix;

		// Token: 0x04003282 RID: 12930
		private LuaFunction m_CanWearEquipmentInt32UInt64_hotfix;

		// Token: 0x04003283 RID: 12931
		private LuaFunction m_CanWearEquipmentByJobAndArmyHeroBagItemBase_hotfix;

		// Token: 0x04003284 RID: 12932
		private LuaFunction m_IsEquipmentWearedUInt64_hotfix;

		// Token: 0x04003285 RID: 12933
		private LuaFunction m_GetWearedEquipmentHeroUInt64_hotfix;

		// Token: 0x04003286 RID: 12934
		private LuaFunction m_TakeOffEquipmentsOrNotWhenTransferHeroJobHero_hotfix;

		// Token: 0x04003287 RID: 12935
		private LuaFunction m_WearEquipmentInt32UInt64_hotfix;

		// Token: 0x04003288 RID: 12936
		private LuaFunction m_WearEquipmentBySlotHeroInt32UInt64_hotfix;

		// Token: 0x04003289 RID: 12937
		private LuaFunction m_TakeOffEquipmentBySlotHeroInt32_hotfix;

		// Token: 0x0400328A RID: 12938
		private LuaFunction m_CanTakeOffEquipmentInt32Int32_hotfix;

		// Token: 0x0400328B RID: 12939
		private LuaFunction m_TakeOffEquipmentInt32Int32_hotfix;

		// Token: 0x0400328C RID: 12940
		private LuaFunction m_HasBetterEquipmentByHeroInt32_hotfix;

		// Token: 0x0400328D RID: 12941
		private LuaFunction m_HasBetterEquipmentBySlotIdInt32Int32_hotfix;

		// Token: 0x0400328E RID: 12942
		private LuaFunction m_GetWearedEquipmentBySlotIdHeroInt32_hotfix;

		// Token: 0x0400328F RID: 12943
		private LuaFunction m_HasBetterEquipmentBySlotIdHeroInt32_hotfix;

		// Token: 0x04003290 RID: 12944
		private LuaFunction m_IsBetterEquipmentBagItemBaseBagItemBaseInt32_hotfix;

		// Token: 0x04003291 RID: 12945
		private LuaFunction m_CanAutoEquipmentByClientInt32_hotfix;

		// Token: 0x04003292 RID: 12946
		private LuaFunction m_CanAutoEquipmentInt32_hotfix;

		// Token: 0x04003293 RID: 12947
		private LuaFunction m_CanWearCharSkinInt32Int32_hotfix;

		// Token: 0x04003294 RID: 12948
		private LuaFunction m_WearCharSkinInt32Int32_hotfix;

		// Token: 0x04003295 RID: 12949
		private LuaFunction m_CanTakeOffCharSkinInt32_hotfix;

		// Token: 0x04003296 RID: 12950
		private LuaFunction m_TakeOffCharSkinInt32_hotfix;

		// Token: 0x04003297 RID: 12951
		private LuaFunction m_CanWearModelSkinInt32Int32Int32_hotfix;

		// Token: 0x04003298 RID: 12952
		private LuaFunction m_WearModelSkinInt32Int32Int32_hotfix;

		// Token: 0x04003299 RID: 12953
		private LuaFunction m_CanTakeOffModelSkinInt32Int32_hotfix;

		// Token: 0x0400329A RID: 12954
		private LuaFunction m_TakeOffModelSkinInt32Int32_hotfix;

		// Token: 0x0400329B RID: 12955
		private LuaFunction m_CanWearSoldierSkinInt32Int32Int32_hotfix;

		// Token: 0x0400329C RID: 12956
		private LuaFunction m_WearSoldierSkinInt32Int32Int32Boolean_hotfix;

		// Token: 0x0400329D RID: 12957
		private LuaFunction m_CanTakeOffSoldierSkinInt32Int32_hotfix;

		// Token: 0x0400329E RID: 12958
		private LuaFunction m_TakeOffSoldierSkinInt32Int32Boolean_hotfix;

		// Token: 0x0400329F RID: 12959
		private LuaFunction m_TakeOffSoldierSkinApplyToAllInt32Int32_hotfix;

		// Token: 0x040032A0 RID: 12960
		private LuaFunction m_AddHeroFavorabilityExpByUseableBagItemInt32GoodsTypeInt32Int32_hotfix;

		// Token: 0x040032A1 RID: 12961
		private LuaFunction m_AddHeroFavorabilityLevelInt32Int32_hotfix;

		// Token: 0x040032A2 RID: 12962
		private LuaFunction m_OutPutHeroFavourabilityOperateLogInt32Int32Int32Int32Int32List;

		// Token: 0x040032A3 RID: 12963
		private LuaFunction m_AddHeroFavorabilityLevelHero_hotfix;

		// Token: 0x040032A4 RID: 12964
		private LuaFunction m_GenerateFavorabilityLevelUpRewardInt32Int32_hotfix;

		// Token: 0x040032A5 RID: 12965
		private LuaFunction m_IsFullFavorabilityExpHeroConfigDataHeroInformationInfo_hotfix;

		// Token: 0x040032A6 RID: 12966
		private LuaFunction m_UpdateProtagonistHeroFavorabilityLevel_hotfix;

		// Token: 0x040032A7 RID: 12967
		private LuaFunction m_CanUnlockHeroFetterInt32Int32_hotfix;

		// Token: 0x040032A8 RID: 12968
		private LuaFunction m_CanReachFetterUnlockConditionHeroFetterCompletionCondition_hotfix;

		// Token: 0x040032A9 RID: 12969
		private LuaFunction m_GmLevelUpHeroFetter2SpecificLevelInt32Int32Int32_hotfix;

		// Token: 0x040032AA RID: 12970
		private LuaFunction m_CanLevelUpHeroFetterInt32Int32_hotfix;

		// Token: 0x040032AB RID: 12971
		private LuaFunction m_LevelUpHeroFetterInt32Int32_hotfix;

		// Token: 0x040032AC RID: 12972
		private LuaFunction m_LevelUpHeroFetterCallBackHeroInt32_hotfix;

		// Token: 0x040032AD RID: 12973
		private LuaFunction m_OutPutHeroFetterOpereateLogInt32Int32Int32List`1List;

		// Token: 0x040032AE RID: 12974
		private LuaFunction m_UnlockHeroFetterInt32Int32Boolean_hotfix;

		// Token: 0x040032AF RID: 12975
		private LuaFunction m_GenerateFetterUnlockRewardsInt32Int32_hotfix;

		// Token: 0x040032B0 RID: 12976
		private LuaFunction m_ConfessHeroInt32Boolean_hotfix;

		// Token: 0x040032B1 RID: 12977
		private LuaFunction m_GenerateConfessionRewardsInt32ConfigDataHeroConfessionInfo_hotfix;

		// Token: 0x040032B2 RID: 12978
		private LuaFunction m_CanConfessHeroInt32_hotfix;

		// Token: 0x040032B3 RID: 12979
		private LuaFunction m_FlushHeroInteractNums_hotfix;

		// Token: 0x040032B4 RID: 12980
		private LuaFunction m_InitHeroInteractNums_hotfix;

		// Token: 0x040032B5 RID: 12981
		private LuaFunction m_CanFlushHeroInteractNums_hotfix;

		// Token: 0x040032B6 RID: 12982
		private LuaFunction m_IsFullHeroInteractNums_hotfix;

		// Token: 0x040032B7 RID: 12983
		private LuaFunction m_AddHeroInteractNumsInt32Boolean_hotfix;

		// Token: 0x040032B8 RID: 12984
		private LuaFunction m_IsHeroInteractNumsEqualToMax_hotfix;

		// Token: 0x040032B9 RID: 12985
		private LuaFunction m_CanInteractHeroInt32_hotfix;

		// Token: 0x040032BA RID: 12986
		private LuaFunction m_GetHeroFavorabilityUpLevelHeroConfigDataHeroInformationInfoInt32_hotfix;

		// Token: 0x040032BB RID: 12987
		private LuaFunction m_GetHeroInteractIdHeroConfigDataHeroInformationInfo_hotfix;

		// Token: 0x040032BC RID: 12988
		private LuaFunction m_GetAllHeroBattlePower_hotfix;

		// Token: 0x040032BD RID: 12989
		private LuaFunction m_GetLastAllHeroRank_hotfix;

		// Token: 0x040032BE RID: 12990
		private LuaFunction m_GetTopHeroBattlePower_hotfix;

		// Token: 0x040032BF RID: 12991
		private LuaFunction m_GetLastTopHeroRank_hotfix;

		// Token: 0x040032C0 RID: 12992
		private LuaFunction m_GetChampionHeroBattlePower_hotfix;

		// Token: 0x040032C1 RID: 12993
		private LuaFunction m_GetChampionHeroId_hotfix;

		// Token: 0x040032C2 RID: 12994
		private LuaFunction m_GetLastChampionHeroRank_hotfix;

		// Token: 0x040032C3 RID: 12995
		private LuaFunction m_ComputeBattlePowerHero_hotfix;

		// Token: 0x040032C4 RID: 12996
		private LuaFunction m_OnHeroBattlePowerChangeHero_hotfix;

		// Token: 0x040032C5 RID: 12997
		private LuaFunction m_CanComposeHeroInt32_hotfix;

		// Token: 0x040032C6 RID: 12998
		private LuaFunction m_CanLevelUpHeroStarLevelInt32_hotfix;

		// Token: 0x040032C7 RID: 12999
		private LuaFunction m_GetEquipedEquipments_hotfix;

		// Token: 0x040032C8 RID: 13000
		private LuaFunction m_GetUnlcokJobAchievementsConfigDataJobConnectionInfo_hotfix;

		// Token: 0x040032C9 RID: 13001
		private LuaFunction m_GetSkillEnergyFromConfigInt32_hotfix;

		// Token: 0x040032CA RID: 13002
		private LuaFunction m_GetHeroStarLevelUpDataFromConfigInt32Int32_hotfix;

		// Token: 0x040032CB RID: 13003
		private LuaFunction m_GetSkillCostFromConfigInt32_hotfix;

		// Token: 0x040032CC RID: 13004
		private LuaFunction m_add_AddHeroEventAction;

		// Token: 0x040032CD RID: 13005
		private LuaFunction m_remove_AddHeroEventAction;

		// Token: 0x040032CE RID: 13006
		private LuaFunction m_add_SpecificHeroFightMissionEventAction;

		// Token: 0x040032CF RID: 13007
		private LuaFunction m_remove_SpecificHeroFightMissionEventAction;

		// Token: 0x040032D0 RID: 13008
		private LuaFunction m_add_HeroNewJobTransferMissionEventAction;

		// Token: 0x040032D1 RID: 13009
		private LuaFunction m_remove_HeroNewJobTransferMissionEventAction;

		// Token: 0x040032D2 RID: 13010
		private LuaFunction m_add_HeroJobLevelUpMissionEventAction_hotfix;

		// Token: 0x040032D3 RID: 13011
		private LuaFunction m_remove_HeroJobLevelUpMissionEventAction_hotfix;

		// Token: 0x040032D4 RID: 13012
		private LuaFunction m_add_HeroJobMasterMissionEventAction;

		// Token: 0x040032D5 RID: 13013
		private LuaFunction m_remove_HeroJobMasterMissionEventAction;

		// Token: 0x040032D6 RID: 13014
		private LuaFunction m_add_AddHeroJobMissionEventAction_hotfix;

		// Token: 0x040032D7 RID: 13015
		private LuaFunction m_remove_AddHeroJobMissionEventAction_hotfix;

		// Token: 0x040032D8 RID: 13016
		private LuaFunction m_add_HeroLevelUpMissionEventAction;

		// Token: 0x040032D9 RID: 13017
		private LuaFunction m_remove_HeroLevelUpMissionEventAction;

		// Token: 0x040032DA RID: 13018
		private LuaFunction m_add_AddHeroJobSkillMissionEventAction;

		// Token: 0x040032DB RID: 13019
		private LuaFunction m_remove_AddHeroJobSkillMissionEventAction;

		// Token: 0x040032DC RID: 13020
		private LuaFunction m_add_AddHeroJobSoliderMissionEventAction;

		// Token: 0x040032DD RID: 13021
		private LuaFunction m_remove_AddHeroJobSoliderMissionEventAction;

		// Token: 0x040032DE RID: 13022
		private LuaFunction m_add_AddHeroMissionEventAction;

		// Token: 0x040032DF RID: 13023
		private LuaFunction m_remove_AddHeroMissionEventAction;

		// Token: 0x040032E0 RID: 13024
		private LuaFunction m_add_LevelUpHeroStarLevelMissionEventAction;

		// Token: 0x040032E1 RID: 13025
		private LuaFunction m_remove_LevelUpHeroStarLevelMissionEventAction;

		// Token: 0x0200046D RID: 1133
		public class LuaExportHelper
		{
			// Token: 0x06004273 RID: 17011 RVA: 0x0013F278 File Offset: 0x0013D478
			public LuaExportHelper(HeroComponentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06004274 RID: 17012 RVA: 0x0013F288 File Offset: 0x0013D488
			public void __callDele_AddHeroEvent(int obj)
			{
				this.m_owner.__callDele_AddHeroEvent(obj);
			}

			// Token: 0x06004275 RID: 17013 RVA: 0x0013F298 File Offset: 0x0013D498
			public void __clearDele_AddHeroEvent(int obj)
			{
				this.m_owner.__clearDele_AddHeroEvent(obj);
			}

			// Token: 0x06004276 RID: 17014 RVA: 0x0013F2A8 File Offset: 0x0013D4A8
			public void __callDele_SpecificHeroFightMissionEvent(int arg1, int arg2)
			{
				this.m_owner.__callDele_SpecificHeroFightMissionEvent(arg1, arg2);
			}

			// Token: 0x06004277 RID: 17015 RVA: 0x0013F2B8 File Offset: 0x0013D4B8
			public void __clearDele_SpecificHeroFightMissionEvent(int arg1, int arg2)
			{
				this.m_owner.__clearDele_SpecificHeroFightMissionEvent(arg1, arg2);
			}

			// Token: 0x06004278 RID: 17016 RVA: 0x0013F2C8 File Offset: 0x0013D4C8
			public void __callDele_HeroNewJobTransferMissionEvent(int arg1, int arg2)
			{
				this.m_owner.__callDele_HeroNewJobTransferMissionEvent(arg1, arg2);
			}

			// Token: 0x06004279 RID: 17017 RVA: 0x0013F2D8 File Offset: 0x0013D4D8
			public void __clearDele_HeroNewJobTransferMissionEvent(int arg1, int arg2)
			{
				this.m_owner.__clearDele_HeroNewJobTransferMissionEvent(arg1, arg2);
			}

			// Token: 0x0600427A RID: 17018 RVA: 0x0013F2E8 File Offset: 0x0013D4E8
			public void __callDele_HeroJobLevelUpMissionEvent()
			{
				this.m_owner.__callDele_HeroJobLevelUpMissionEvent();
			}

			// Token: 0x0600427B RID: 17019 RVA: 0x0013F2F8 File Offset: 0x0013D4F8
			public void __clearDele_HeroJobLevelUpMissionEvent()
			{
				this.m_owner.__clearDele_HeroJobLevelUpMissionEvent();
			}

			// Token: 0x0600427C RID: 17020 RVA: 0x0013F308 File Offset: 0x0013D508
			public void __callDele_HeroJobMasterMissionEvent(int arg1, int arg2)
			{
				this.m_owner.__callDele_HeroJobMasterMissionEvent(arg1, arg2);
			}

			// Token: 0x0600427D RID: 17021 RVA: 0x0013F318 File Offset: 0x0013D518
			public void __clearDele_HeroJobMasterMissionEvent(int arg1, int arg2)
			{
				this.m_owner.__clearDele_HeroJobMasterMissionEvent(arg1, arg2);
			}

			// Token: 0x0600427E RID: 17022 RVA: 0x0013F328 File Offset: 0x0013D528
			public void __callDele_AddHeroJobMissionEvent()
			{
				this.m_owner.__callDele_AddHeroJobMissionEvent();
			}

			// Token: 0x0600427F RID: 17023 RVA: 0x0013F338 File Offset: 0x0013D538
			public void __clearDele_AddHeroJobMissionEvent()
			{
				this.m_owner.__clearDele_AddHeroJobMissionEvent();
			}

			// Token: 0x06004280 RID: 17024 RVA: 0x0013F348 File Offset: 0x0013D548
			public void __callDele_HeroLevelUpMissionEvent(int obj)
			{
				this.m_owner.__callDele_HeroLevelUpMissionEvent(obj);
			}

			// Token: 0x06004281 RID: 17025 RVA: 0x0013F358 File Offset: 0x0013D558
			public void __clearDele_HeroLevelUpMissionEvent(int obj)
			{
				this.m_owner.__clearDele_HeroLevelUpMissionEvent(obj);
			}

			// Token: 0x06004282 RID: 17026 RVA: 0x0013F368 File Offset: 0x0013D568
			public void __callDele_AddHeroJobSkillMissionEvent(int obj)
			{
				this.m_owner.__callDele_AddHeroJobSkillMissionEvent(obj);
			}

			// Token: 0x06004283 RID: 17027 RVA: 0x0013F378 File Offset: 0x0013D578
			public void __clearDele_AddHeroJobSkillMissionEvent(int obj)
			{
				this.m_owner.__clearDele_AddHeroJobSkillMissionEvent(obj);
			}

			// Token: 0x06004284 RID: 17028 RVA: 0x0013F388 File Offset: 0x0013D588
			public void __callDele_AddHeroJobSoliderMissionEvent(int obj)
			{
				this.m_owner.__callDele_AddHeroJobSoliderMissionEvent(obj);
			}

			// Token: 0x06004285 RID: 17029 RVA: 0x0013F398 File Offset: 0x0013D598
			public void __clearDele_AddHeroJobSoliderMissionEvent(int obj)
			{
				this.m_owner.__clearDele_AddHeroJobSoliderMissionEvent(obj);
			}

			// Token: 0x06004286 RID: 17030 RVA: 0x0013F3A8 File Offset: 0x0013D5A8
			public void __callDele_AddHeroMissionEvent(int obj)
			{
				this.m_owner.__callDele_AddHeroMissionEvent(obj);
			}

			// Token: 0x06004287 RID: 17031 RVA: 0x0013F3B8 File Offset: 0x0013D5B8
			public void __clearDele_AddHeroMissionEvent(int obj)
			{
				this.m_owner.__clearDele_AddHeroMissionEvent(obj);
			}

			// Token: 0x06004288 RID: 17032 RVA: 0x0013F3C8 File Offset: 0x0013D5C8
			public void __callDele_LevelUpHeroStarLevelMissionEvent(int obj)
			{
				this.m_owner.__callDele_LevelUpHeroStarLevelMissionEvent(obj);
			}

			// Token: 0x06004289 RID: 17033 RVA: 0x0013F3D8 File Offset: 0x0013D5D8
			public void __clearDele_LevelUpHeroStarLevelMissionEvent(int obj)
			{
				this.m_owner.__clearDele_LevelUpHeroStarLevelMissionEvent(obj);
			}

			// Token: 0x1700115C RID: 4444
			// (get) Token: 0x0600428A RID: 17034 RVA: 0x0013F3E8 File Offset: 0x0013D5E8
			// (set) Token: 0x0600428B RID: 17035 RVA: 0x0013F3F8 File Offset: 0x0013D5F8
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

			// Token: 0x1700115D RID: 4445
			// (get) Token: 0x0600428C RID: 17036 RVA: 0x0013F408 File Offset: 0x0013D608
			// (set) Token: 0x0600428D RID: 17037 RVA: 0x0013F418 File Offset: 0x0013D618
			public BagComponentCommon m_bag
			{
				get
				{
					return this.m_owner.m_bag;
				}
				set
				{
					this.m_owner.m_bag = value;
				}
			}

			// Token: 0x1700115E RID: 4446
			// (get) Token: 0x0600428E RID: 17038 RVA: 0x0013F428 File Offset: 0x0013D628
			// (set) Token: 0x0600428F RID: 17039 RVA: 0x0013F438 File Offset: 0x0013D638
			public RiftComponentCommon m_rift
			{
				get
				{
					return this.m_owner.m_rift;
				}
				set
				{
					this.m_owner.m_rift = value;
				}
			}

			// Token: 0x1700115F RID: 4447
			// (get) Token: 0x06004290 RID: 17040 RVA: 0x0013F448 File Offset: 0x0013D648
			// (set) Token: 0x06004291 RID: 17041 RVA: 0x0013F458 File Offset: 0x0013D658
			public MissionComponentCommon m_mission
			{
				get
				{
					return this.m_owner.m_mission;
				}
				set
				{
					this.m_owner.m_mission = value;
				}
			}

			// Token: 0x17001160 RID: 4448
			// (get) Token: 0x06004292 RID: 17042 RVA: 0x0013F468 File Offset: 0x0013D668
			// (set) Token: 0x06004293 RID: 17043 RVA: 0x0013F478 File Offset: 0x0013D678
			public PlayerBasicInfoComponentCommon m_basicInfo
			{
				get
				{
					return this.m_owner.m_basicInfo;
				}
				set
				{
					this.m_owner.m_basicInfo = value;
				}
			}

			// Token: 0x17001161 RID: 4449
			// (get) Token: 0x06004294 RID: 17044 RVA: 0x0013F488 File Offset: 0x0013D688
			// (set) Token: 0x06004295 RID: 17045 RVA: 0x0013F498 File Offset: 0x0013D698
			public BattleComponentCommon m_battle
			{
				get
				{
					return this.m_owner.m_battle;
				}
				set
				{
					this.m_owner.m_battle = value;
				}
			}

			// Token: 0x17001162 RID: 4450
			// (get) Token: 0x06004296 RID: 17046 RVA: 0x0013F4A8 File Offset: 0x0013D6A8
			// (set) Token: 0x06004297 RID: 17047 RVA: 0x0013F4B8 File Offset: 0x0013D6B8
			public ResourceComponentCommon m_resource
			{
				get
				{
					return this.m_owner.m_resource;
				}
				set
				{
					this.m_owner.m_resource = value;
				}
			}

			// Token: 0x17001163 RID: 4451
			// (get) Token: 0x06004298 RID: 17048 RVA: 0x0013F4C8 File Offset: 0x0013D6C8
			// (set) Token: 0x06004299 RID: 17049 RVA: 0x0013F4D8 File Offset: 0x0013D6D8
			public GuildComponentCommon m_guild
			{
				get
				{
					return this.m_owner.m_guild;
				}
				set
				{
					this.m_owner.m_guild = value;
				}
			}

			// Token: 0x17001164 RID: 4452
			// (get) Token: 0x0600429A RID: 17050 RVA: 0x0013F4E8 File Offset: 0x0013D6E8
			// (set) Token: 0x0600429B RID: 17051 RVA: 0x0013F4F8 File Offset: 0x0013D6F8
			public TrainingGroundCompomentCommon m_trainingGround
			{
				get
				{
					return this.m_owner.m_trainingGround;
				}
				set
				{
					this.m_owner.m_trainingGround = value;
				}
			}

			// Token: 0x17001165 RID: 4453
			// (get) Token: 0x0600429C RID: 17052 RVA: 0x0013F508 File Offset: 0x0013D708
			// (set) Token: 0x0600429D RID: 17053 RVA: 0x0013F518 File Offset: 0x0013D718
			public DataSectionHero m_heroDS
			{
				get
				{
					return this.m_owner.m_heroDS;
				}
				set
				{
					this.m_owner.m_heroDS = value;
				}
			}

			// Token: 0x17001166 RID: 4454
			// (get) Token: 0x0600429E RID: 17054 RVA: 0x0013F528 File Offset: 0x0013D728
			// (set) Token: 0x0600429F RID: 17055 RVA: 0x0013F538 File Offset: 0x0013D738
			public Dictionary<ulong, int> m_wearedEquipmentHeroDict
			{
				get
				{
					return this.m_owner.m_wearedEquipmentHeroDict;
				}
				set
				{
					this.m_owner.m_wearedEquipmentHeroDict = value;
				}
			}

			// Token: 0x17001167 RID: 4455
			// (get) Token: 0x060042A0 RID: 17056 RVA: 0x0013F548 File Offset: 0x0013D748
			// (set) Token: 0x060042A1 RID: 17057 RVA: 0x0013F558 File Offset: 0x0013D758
			public HashSet<int> m_soliders
			{
				get
				{
					return this.m_owner.m_soliders;
				}
				set
				{
					this.m_owner.m_soliders = value;
				}
			}

			// Token: 0x17001168 RID: 4456
			// (get) Token: 0x060042A2 RID: 17058 RVA: 0x0013F568 File Offset: 0x0013D768
			// (set) Token: 0x060042A3 RID: 17059 RVA: 0x0013F578 File Offset: 0x0013D778
			public HashSet<int> m_skills
			{
				get
				{
					return this.m_owner.m_skills;
				}
				set
				{
					this.m_owner.m_skills = value;
				}
			}

			// Token: 0x17001169 RID: 4457
			// (get) Token: 0x060042A4 RID: 17060 RVA: 0x0013F588 File Offset: 0x0013D788
			// (set) Token: 0x060042A5 RID: 17061 RVA: 0x0013F598 File Offset: 0x0013D798
			public Dictionary<int, DateTime> m_atuoEquipmentTouch
			{
				get
				{
					return this.m_owner.m_atuoEquipmentTouch;
				}
				set
				{
					this.m_owner.m_atuoEquipmentTouch = value;
				}
			}

			// Token: 0x060042A6 RID: 17062 RVA: 0x0013F5A8 File Offset: 0x0013D7A8
			public void InitHeroDataByCaculate(Hero hero)
			{
				this.m_owner.InitHeroDataByCaculate(hero);
			}

			// Token: 0x060042A7 RID: 17063 RVA: 0x0013F5B8 File Offset: 0x0013D7B8
			public void InitHeroJobs(Hero hero)
			{
				this.m_owner.InitHeroJobs(hero);
			}

			// Token: 0x060042A8 RID: 17064 RVA: 0x0013F5C8 File Offset: 0x0013D7C8
			public void AddHeroDefaultInfos(Hero hero, ConfigDataHeroInfo heroInfo)
			{
				this.m_owner.AddHeroDefaultInfos(hero, heroInfo);
			}

			// Token: 0x060042A9 RID: 17065 RVA: 0x0013F5D8 File Offset: 0x0013D7D8
			public bool CanGetHeroJobByRank(Hero hero, int rank)
			{
				return this.m_owner.CanGetHeroJobByRank(hero, rank);
			}

			// Token: 0x060042AA RID: 17066 RVA: 0x0013F5E8 File Offset: 0x0013D7E8
			public Hero AddHeroInfos(ConfigDataHeroInfo heroInfo)
			{
				return this.m_owner.AddHeroInfos(heroInfo);
			}

			// Token: 0x060042AB RID: 17067 RVA: 0x0013F5F8 File Offset: 0x0013D7F8
			public void OutPutHeroLevelUpOperateLog(int heroId, int currentLevel)
			{
				this.m_owner.OutPutHeroLevelUpOperateLog(heroId, currentLevel);
			}

			// Token: 0x060042AC RID: 17068 RVA: 0x0013F608 File Offset: 0x0013D808
			public void OutPutHeroUpgradeOperateLog(int heroId, int currentStar, List<Goods> costItems)
			{
				this.m_owner.OutPutHeroUpgradeOperateLog(heroId, currentStar, costItems);
			}

			// Token: 0x060042AD RID: 17069 RVA: 0x0013F618 File Offset: 0x0013D818
			public void OnHeroLevelUp(int oldLevel, Hero hero)
			{
				this.m_owner.OnHeroLevelUp(oldLevel, hero);
			}

			// Token: 0x060042AE RID: 17070 RVA: 0x0013F628 File Offset: 0x0013D828
			public void AddHeroJob(Hero hero, ConfigDataJobConnectionInfo jobConnectionInfo)
			{
				this.m_owner.AddHeroJob(hero, jobConnectionInfo);
			}

			// Token: 0x060042AF RID: 17071 RVA: 0x0013F638 File Offset: 0x0013D838
			public bool CanTransferHeroJobRank(int jobRank, int CanTransferMaxRank)
			{
				return this.m_owner.CanTransferHeroJobRank(jobRank, CanTransferMaxRank);
			}

			// Token: 0x060042B0 RID: 17072 RVA: 0x0013F648 File Offset: 0x0013D848
			public void OutPutHeroJobChangeOperateLog(int heroId, int preJobConnectionId, int postJobConnectionId, List<Goods> costItems)
			{
				this.m_owner.OutPutHeroJobChangeOperateLog(heroId, preJobConnectionId, postJobConnectionId, costItems);
			}

			// Token: 0x060042B1 RID: 17073 RVA: 0x0013F65C File Offset: 0x0013D85C
			public void OnTransferHeroJob(Hero hero, ConfigDataJobConnectionInfo jobConnectionInfo, int jobLevel)
			{
				this.m_owner.OnTransferHeroJob(hero, jobConnectionInfo, jobLevel);
			}

			// Token: 0x060042B2 RID: 17074 RVA: 0x0013F66C File Offset: 0x0013D86C
			public void TryEquipNewSkill(Hero hero, int newGotSkillId)
			{
				this.m_owner.TryEquipNewSkill(hero, newGotSkillId);
			}

			// Token: 0x060042B3 RID: 17075 RVA: 0x0013F67C File Offset: 0x0013D87C
			public bool IsNeedAddAchievement(ConfigDataJobConnectionInfo jobConnectionInfo)
			{
				return this.m_owner.IsNeedAddAchievement(jobConnectionInfo);
			}

			// Token: 0x060042B4 RID: 17076 RVA: 0x0013F68C File Offset: 0x0013D88C
			public void OutPutHeroJobUnlockOperateLog(int heroId, int activeJobId, int unlockJobId, List<Goods> costItems)
			{
				this.m_owner.OutPutHeroJobUnlockOperateLog(heroId, activeJobId, unlockJobId, costItems);
			}

			// Token: 0x060042B5 RID: 17077 RVA: 0x0013F6A0 File Offset: 0x0013D8A0
			public int CanUnlockedHeroJob(Hero hero, ConfigDataJobConnectionInfo jobConnectionInfo)
			{
				return this.m_owner.CanUnlockedHeroJob(hero, jobConnectionInfo);
			}

			// Token: 0x060042B6 RID: 17078 RVA: 0x0013F6B0 File Offset: 0x0013D8B0
			public void OutPutHeroJobLevelUpOperateLog(int heroId, int activeJobId, int currentLevel, List<Goods> costItems)
			{
				this.m_owner.OutPutHeroJobLevelUpOperateLog(heroId, activeJobId, currentLevel, costItems);
			}

			// Token: 0x060042B7 RID: 17079 RVA: 0x0013F6C4 File Offset: 0x0013D8C4
			public void AddSkill(Hero hero, int skillId)
			{
				this.m_owner.AddSkill(hero, skillId);
			}

			// Token: 0x060042B8 RID: 17080 RVA: 0x0013F6D4 File Offset: 0x0013D8D4
			public void InitWearedEquipments()
			{
				this.m_owner.InitWearedEquipments();
			}

			// Token: 0x060042B9 RID: 17081 RVA: 0x0013F6E4 File Offset: 0x0013D8E4
			public void TakeOffEquipmentsOrNotWhenTransferHeroJob(Hero hero)
			{
				this.m_owner.TakeOffEquipmentsOrNotWhenTransferHeroJob(hero);
			}

			// Token: 0x060042BA RID: 17082 RVA: 0x0013F6F4 File Offset: 0x0013D8F4
			public void WearEquipmentBySlot(Hero hero, int slot, ulong instanceId)
			{
				this.m_owner.WearEquipmentBySlot(hero, slot, instanceId);
			}

			// Token: 0x060042BB RID: 17083 RVA: 0x0013F704 File Offset: 0x0013D904
			public void TakeOffEquipmentBySlot(Hero hero, int slot)
			{
				this.m_owner.TakeOffEquipmentBySlot(hero, slot);
			}

			// Token: 0x060042BC RID: 17084 RVA: 0x0013F714 File Offset: 0x0013D914
			public BagItemBase GetWearedEquipmentBySlotId(Hero hero, int slotId)
			{
				return this.m_owner.GetWearedEquipmentBySlotId(hero, slotId);
			}

			// Token: 0x060042BD RID: 17085 RVA: 0x0013F724 File Offset: 0x0013D924
			public bool HasBetterEquipmentBySlotId(Hero hero, int slotId)
			{
				return this.m_owner.HasBetterEquipmentBySlotId(hero, slotId);
			}

			// Token: 0x060042BE RID: 17086 RVA: 0x0013F734 File Offset: 0x0013D934
			public bool IsBetterEquipment(BagItemBase wearedEquipment, BagItemBase compareEquipment, int slotId)
			{
				return this.m_owner.IsBetterEquipment(wearedEquipment, compareEquipment, slotId);
			}

			// Token: 0x060042BF RID: 17087 RVA: 0x0013F744 File Offset: 0x0013D944
			public void OutPutHeroFavourabilityOperateLog(int heroId, int oldLvl, int oldExp, int newLvl, int newExp, List<Goods> rewards)
			{
				this.m_owner.OutPutHeroFavourabilityOperateLog(heroId, oldLvl, oldExp, newLvl, newExp, rewards);
			}

			// Token: 0x060042C0 RID: 17088 RVA: 0x0013F75C File Offset: 0x0013D95C
			public void AddHeroFavorabilityLevel(Hero hero)
			{
				this.m_owner.AddHeroFavorabilityLevel(hero);
			}

			// Token: 0x060042C1 RID: 17089 RVA: 0x0013F76C File Offset: 0x0013D96C
			public void GenerateFavorabilityLevelUpReward(int heroId, int dropId)
			{
				this.m_owner.GenerateFavorabilityLevelUpReward(heroId, dropId);
			}

			// Token: 0x060042C2 RID: 17090 RVA: 0x0013F77C File Offset: 0x0013D97C
			public void UpdateProtagonistHeroFavorabilityLevel()
			{
				this.m_owner.UpdateProtagonistHeroFavorabilityLevel();
			}

			// Token: 0x060042C3 RID: 17091 RVA: 0x0013F78C File Offset: 0x0013D98C
			public void LevelUpHeroFetterCallBack(Hero hero, int fetterId)
			{
				this.m_owner.LevelUpHeroFetterCallBack(hero, fetterId);
			}

			// Token: 0x060042C4 RID: 17092 RVA: 0x0013F79C File Offset: 0x0013D99C
			public void OutPutHeroFetterOpereateLog(int heroId, int fetterId, int currentLvl, List<Goods> itemCost, List<Goods> rewards)
			{
				this.m_owner.OutPutHeroFetterOpereateLog(heroId, fetterId, currentLvl, itemCost, rewards);
			}

			// Token: 0x060042C5 RID: 17093 RVA: 0x0013F7B0 File Offset: 0x0013D9B0
			public void GenerateFetterUnlockRewards(int heroId, int fetterId)
			{
				this.m_owner.GenerateFetterUnlockRewards(heroId, fetterId);
			}

			// Token: 0x060042C6 RID: 17094 RVA: 0x0013F7C0 File Offset: 0x0013D9C0
			public void GenerateConfessionRewards(int herId, ConfigDataHeroConfessionInfo confessionInfo)
			{
				this.m_owner.GenerateConfessionRewards(herId, confessionInfo);
			}

			// Token: 0x060042C7 RID: 17095 RVA: 0x0013F7D0 File Offset: 0x0013D9D0
			public void FlushHeroInteractNums()
			{
				this.m_owner.FlushHeroInteractNums();
			}

			// Token: 0x060042C8 RID: 17096 RVA: 0x0013F7E0 File Offset: 0x0013D9E0
			public void InitHeroInteractNums()
			{
				this.m_owner.InitHeroInteractNums();
			}

			// Token: 0x060042C9 RID: 17097 RVA: 0x0013F7F0 File Offset: 0x0013D9F0
			public bool CanFlushHeroInteractNums()
			{
				return this.m_owner.CanFlushHeroInteractNums();
			}

			// Token: 0x060042CA RID: 17098 RVA: 0x0013F800 File Offset: 0x0013DA00
			public bool IsFullHeroInteractNums()
			{
				return this.m_owner.IsFullHeroInteractNums();
			}

			// Token: 0x060042CB RID: 17099 RVA: 0x0013F810 File Offset: 0x0013DA10
			public void AddHeroInteractNums(int addNums, bool recoveryByTime)
			{
				this.m_owner.AddHeroInteractNums(addNums, recoveryByTime);
			}

			// Token: 0x060042CC RID: 17100 RVA: 0x0013F820 File Offset: 0x0013DA20
			public bool IsHeroInteractNumsEqualToMax()
			{
				return this.m_owner.IsHeroInteractNumsEqualToMax();
			}

			// Token: 0x060042CD RID: 17101 RVA: 0x0013F830 File Offset: 0x0013DA30
			public int GetHeroInteractId(Hero hero, ConfigDataHeroInformationInfo heroInformationInfo)
			{
				return this.m_owner.GetHeroInteractId(hero, heroInformationInfo);
			}

			// Token: 0x060042CE RID: 17102 RVA: 0x0013F840 File Offset: 0x0013DA40
			public List<int> GetUnlcokJobAchievements(ConfigDataJobConnectionInfo jobConnectionInfo)
			{
				return this.m_owner.GetUnlcokJobAchievements(jobConnectionInfo);
			}

			// Token: 0x060042CF RID: 17103 RVA: 0x0013F850 File Offset: 0x0013DA50
			public List<Goods> GetHeroStarLevelUpDataFromConfig(int fragmentId, int newStarLevel)
			{
				return this.m_owner.GetHeroStarLevelUpDataFromConfig(fragmentId, newStarLevel);
			}

			// Token: 0x060042D0 RID: 17104 RVA: 0x0013F860 File Offset: 0x0013DA60
			public int GetSkillCostFromConfig(int skillId)
			{
				return this.m_owner.GetSkillCostFromConfig(skillId);
			}

			// Token: 0x040032E2 RID: 13026
			private HeroComponentCommon m_owner;
		}
	}
}
