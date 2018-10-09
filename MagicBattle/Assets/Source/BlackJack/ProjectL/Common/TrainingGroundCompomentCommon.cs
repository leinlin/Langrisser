using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004B1 RID: 1201
	[HotFix]
	public class TrainingGroundCompomentCommon : IComponentBase
	{
		// Token: 0x0600496B RID: 18795 RVA: 0x0016DEA4 File Offset: 0x0016C0A4
		public TrainingGroundCompomentCommon()
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

		// Token: 0x0600496C RID: 18796 RVA: 0x0016DF18 File Offset: 0x0016C118
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
			return "TrainingGround";
		}

		// Token: 0x0600496D RID: 18797 RVA: 0x0016DF8C File Offset: 0x0016C18C
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

		// Token: 0x0600496E RID: 18798 RVA: 0x0016DFEC File Offset: 0x0016C1EC
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
			this.m_basicInfo = (this.Owner.GetOwnerComponent("PlayerBasicInfo") as PlayerBasicInfoComponentCommon);
			this.m_bag = (this.Owner.GetOwnerComponent("Bag") as BagComponentCommon);
			this.m_anikiGym = (this.Owner.GetOwnerComponent("AnikiGym") as AnikiGymComponentCommon);
			this.m_hero = (this.Owner.GetOwnerComponent("Hero") as HeroComponentCommon);
			this.m_trainingGroundDS.TrainingGround.IsAnikiGymLevelCleared = new AnikiGymLevelClearCheck(this.m_anikiGym.IsLevelFinished);
		}

		// Token: 0x0600496F RID: 18799 RVA: 0x0016E0DC File Offset: 0x0016C2DC
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

		// Token: 0x06004970 RID: 18800 RVA: 0x0016E13C File Offset: 0x0016C33C
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
		}

		// Token: 0x06004971 RID: 18801 RVA: 0x0016E1AC File Offset: 0x0016C3AC
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

		// Token: 0x06004972 RID: 18802 RVA: 0x0016E22C File Offset: 0x0016C42C
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

		// Token: 0x06004973 RID: 18803 RVA: 0x0016E29C File Offset: 0x0016C49C
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
			foreach (TrainingTechInfo trainingTechInfo in this.m_trainingGroundDS.TrainingGround.IterateAvailableTechInfos())
			{
				foreach (Hero hero in this.m_hero.GetAllHeros())
				{
					ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(hero.HeroId);
					if (configDataHeroInfo != null && configDataHeroInfo.TechCanLearnSoldiers_ID.Contains(trainingTechInfo.SoldierIDUnlocked) && !hero.HasOwnSoldier(trainingTechInfo.SoldierIDUnlocked))
					{
						this.m_hero.AddSoldier(hero, trainingTechInfo.SoldierIDUnlocked, false);
					}
				}
			}
		}

		// Token: 0x17001241 RID: 4673
		// (get) Token: 0x06004974 RID: 18804 RVA: 0x0016E3EC File Offset: 0x0016C5EC
		// (set) Token: 0x06004975 RID: 18805 RVA: 0x0016E460 File Offset: 0x0016C660
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

		// Token: 0x06004976 RID: 18806 RVA: 0x0016E4D8 File Offset: 0x0016C6D8
		public int GetTechMaxLevel(int TechId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTechMaxLevelInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetTechMaxLevelInt32_hotfix.call(new object[]
				{
					this,
					TechId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataTrainingTechInfo configDataTrainingTechInfo = this.m_configDataLoader.GetConfigDataTrainingTechInfo(TechId);
			return configDataTrainingTechInfo.TechLevelupInfoList.Count;
		}

		// Token: 0x06004977 RID: 18807 RVA: 0x0016E56C File Offset: 0x0016C76C
		public bool IsTechLocked(int TechId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsTechLockedInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsTechLockedInt32_hotfix.call(new object[]
				{
					this,
					TechId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataTrainingTechInfo configDataTrainingTechInfo = this.m_configDataLoader.GetConfigDataTrainingTechInfo(TechId);
			int techMaxLevel = this.GetTechMaxLevel(TechId);
			TrainingTech tech = this.GetTech(TechId);
			if (tech.Level >= techMaxLevel)
			{
				return false;
			}
			TrainingTechInfo TechInfo = configDataTrainingTechInfo.m_Infos[tech.Level];
			ConfigDataTrainingCourseInfo configDataTrainingCourseInfo = this.m_configDataLoader.GetConfigDataTrainingCourseInfo(configDataTrainingTechInfo.m_courseId);
			TrainingRoom room = this.GetRoom(configDataTrainingCourseInfo.RoomID);
			if (room.Level < TechInfo.RoomLevel)
			{
				return true;
			}
			if (TechInfo.PreIds == null || TechInfo.PreIds.Count == 0)
			{
				return false;
			}
			List<TrainingTech> availableTechs = this.GetAvailableTechs();
			int i;
			for (i = 0; i < TechInfo.PreIds.Count; i++)
			{
				int PreTechId = TechInfo.PreIds[i];
				if (availableTechs.Find((TrainingTech t) => t.ConfigId == PreTechId && !this.IsTechLocked(t.ConfigId) && t.Level >= TechInfo.PreTechLevels[i]) == null)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06004978 RID: 18808 RVA: 0x0016E734 File Offset: 0x0016C934
		public bool CanLevelup(int TechId, int DeltaLevel = 1)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanLevelupInt32Int32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CanLevelupInt32Int32_hotfix.call(new object[]
				{
					this,
					TechId,
					DeltaLevel
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataTrainingTechInfo configDataTrainingTechInfo = this.m_configDataLoader.GetConfigDataTrainingTechInfo(TechId);
			int techMaxLevel = this.GetTechMaxLevel(TechId);
			TrainingTech tech = this.GetTech(TechId);
			int level = tech.Level;
			bool result = true;
			for (int i = 1; i <= DeltaLevel; i++)
			{
				if (tech.Level >= techMaxLevel || this.IsTechLocked(TechId))
				{
					result = false;
					break;
				}
				tech.Level++;
			}
			tech.Level = level;
			return result;
		}

		// Token: 0x06004979 RID: 18809 RVA: 0x0016E834 File Offset: 0x0016CA34
		public TrainingTechResourceRequirements GetResourceRequirementsByLevel(int TechId, int Level)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetResourceRequirementsByLevelInt32Int32_hotfix != null)
			{
				return (TrainingTechResourceRequirements)this.m_GetResourceRequirementsByLevelInt32Int32_hotfix.call(new object[]
				{
					this,
					TechId,
					Level
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.CanLevelup(TechId, 1))
			{
				return this.m_configDataLoader.GetConfigDataTrainingTechInfo(TechId).m_Infos[Level - 1].LevelupRequirements;
			}
			return null;
		}

		// Token: 0x0600497A RID: 18810 RVA: 0x0016E8F0 File Offset: 0x0016CAF0
		public TrainingTechResourceRequirements GetTechLevelupResourceRequirements(int TechId, int DeltaLevel = 1)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTechLevelupResourceRequirementsInt32Int32_hotfix != null)
			{
				return (TrainingTechResourceRequirements)this.m_GetTechLevelupResourceRequirementsInt32Int32_hotfix.call(new object[]
				{
					this,
					TechId,
					DeltaLevel
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			TrainingTech tech = this.m_trainingGroundDS.GetTech(TechId);
			if (DeltaLevel < 1)
			{
				return null;
			}
			int level = tech.Level;
			if (!this.CanLevelup(TechId, DeltaLevel))
			{
				return null;
			}
			TrainingTechResourceRequirements trainingTechResourceRequirements = this.GetResourceRequirementsByLevel(TechId, tech.Level + 1);
			int num = tech.Level + 2;
			while (num < this.GetTechMaxLevel(TechId) && num < tech.Level + DeltaLevel)
			{
				trainingTechResourceRequirements += this.GetResourceRequirementsByLevel(TechId, num);
				num++;
			}
			return trainingTechResourceRequirements;
		}

		// Token: 0x0600497B RID: 18811 RVA: 0x0016E9F8 File Offset: 0x0016CBF8
		public int CheckTechLevelup(int TechId, int DeltaLevel = 1)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckTechLevelupInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CheckTechLevelupInt32Int32_hotfix.call(new object[]
				{
					this,
					TechId,
					DeltaLevel
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			TrainingTech tech = this.m_trainingGroundDS.GetTech(TechId);
			if (!this.CanLevelup(TechId, DeltaLevel))
			{
				return -10077;
			}
			TrainingTechResourceRequirements techLevelupResourceRequirements = this.GetTechLevelupResourceRequirements(TechId, DeltaLevel);
			if (techLevelupResourceRequirements == null)
			{
				return -10076;
			}
			if (!this.m_basicInfo.IsGoldEnough(techLevelupResourceRequirements.Gold))
			{
				return -400;
			}
			List<BagItemBase> list = this.m_bag.FindEnoughBagItems(techLevelupResourceRequirements.Materials);
			if (list.Count != techLevelupResourceRequirements.Materials.Count)
			{
				return -10076;
			}
			return 0;
		}

		// Token: 0x0600497C RID: 18812 RVA: 0x0016EB04 File Offset: 0x0016CD04
		public virtual int TechLevelup(int TechId, int DeltaLevel = 1)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TechLevelupInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_TechLevelupInt32Int32_hotfix.call(new object[]
				{
					this,
					TechId,
					DeltaLevel
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CheckTechLevelup(TechId, DeltaLevel);
			if (num != 0)
			{
				return num;
			}
			this.AddTechLevel(TechId, DeltaLevel, false);
			return num;
		}

		// Token: 0x0600497D RID: 18813 RVA: 0x0016EBAC File Offset: 0x0016CDAC
		public void AddTechLevel(int TechId, int DeltaLevel, bool NoCheckAndCost = false)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddTechLevelInt32Int32Boolean_hotfix != null)
			{
				this.m_AddTechLevelInt32Int32Boolean_hotfix.call(new object[]
				{
					this,
					TechId,
					DeltaLevel,
					NoCheckAndCost
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			TrainingTech tech = this.m_trainingGroundDS.GetTech(TechId);
			int num = tech.Level + DeltaLevel;
			ConfigDataTrainingTechInfo configDataTrainingTechInfo = this.m_configDataLoader.GetConfigDataTrainingTechInfo(TechId);
			if (!NoCheckAndCost)
			{
				TrainingTechResourceRequirements techLevelupResourceRequirements = this.GetTechLevelupResourceRequirements(TechId, DeltaLevel);
				List<Goods> list = new List<Goods>();
				list.Add(new Goods
				{
					GoodsType = GoodsType.GoodsType_Gold,
					Count = techLevelupResourceRequirements.Gold
				});
				list.AddRange(techLevelupResourceRequirements.Materials);
				this.m_bag.ConsumeGoods(list, null, null, GameFunctionType.GameFunctionType_TrainingGround, string.Format("{0}: {1}", TechId, num));
				this.OutPutTeachnologyTreeOperateLog(configDataTrainingTechInfo.m_courseId, TechId, num, null, list);
			}
			this.m_trainingGroundDS.UpdateTechLevel(TechId, num);
			foreach (Hero hero in this.m_hero.GetAllHeros())
			{
				this.ApplyTrainingTechToHero(hero, tech);
				this.m_hero.OnHeroBattlePowerChange(hero);
			}
			if (this.TrainingTechLevelupMissionEvent != null)
			{
				this.TrainingTechLevelupMissionEvent(tech);
			}
		}

		// Token: 0x0600497E RID: 18814 RVA: 0x0016ED68 File Offset: 0x0016CF68
		public void ApplyTrainingTechToHero(Hero hero, TrainingTech tech)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ApplyTrainingTechToHeroHeroTrainingTech_hotfix != null)
			{
				this.m_ApplyTrainingTechToHeroHeroTrainingTech_hotfix.call(new object[]
				{
					this,
					hero,
					tech
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (tech == null || tech.Level == 0)
			{
				return;
			}
			ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(hero.HeroId);
			if (configDataHeroInfo == null)
			{
				return;
			}
			TrainingTechInfo trainingTechInfo = tech.Infos[tech.Level - 1];
			if (configDataHeroInfo.TechCanLearnSoldiers_ID.Contains(trainingTechInfo.SoldierIDUnlocked) && !hero.HasOwnSoldier(trainingTechInfo.SoldierIDUnlocked))
			{
				this.m_hero.AddSoldier(hero, trainingTechInfo.SoldierIDUnlocked, true);
			}
		}

		// Token: 0x0600497F RID: 18815 RVA: 0x0016EE64 File Offset: 0x0016D064
		public void ApplyTrainingTechToHero(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ApplyTrainingTechToHeroHero_hotfix != null)
			{
				this.m_ApplyTrainingTechToHeroHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (TrainingTech tech in this.IterateAvailableTechs())
			{
				this.ApplyTrainingTechToHero(hero, tech);
			}
		}

		// Token: 0x06004980 RID: 18816 RVA: 0x0016EF24 File Offset: 0x0016D124
		protected virtual void OutPutTeachnologyTreeOperateLog(int courseId, int techId, int currentLvl, List<Goods> itemGot, List<Goods> itemCost)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OutPutTeachnologyTreeOperateLogInt32Int32Int32List`1List`1_hotfix != null)
			{
				this.m_OutPutTeachnologyTreeOperateLogInt32Int32Int32List`1List`1_hotfix.call(new object[]
				{
					this,
					courseId,
					techId,
					currentLvl,
					itemGot,
					itemCost
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06004981 RID: 18817 RVA: 0x0016EFD4 File Offset: 0x0016D1D4
		public List<TrainingTech> GetAvailableTechs()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAvailableTechs_hotfix != null)
			{
				return (List<TrainingTech>)this.m_GetAvailableTechs_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_trainingGroundDS.TrainingGround.GetAvailableTechs();
		}

		// Token: 0x06004982 RID: 18818 RVA: 0x0016F050 File Offset: 0x0016D250
		public IEnumerable<TrainingTechInfo> IterateAvailableTechInfos()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IterateAvailableTechInfos_hotfix != null)
			{
				return (IEnumerable<TrainingTechInfo>)this.m_IterateAvailableTechInfos_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_trainingGroundDS.TrainingGround.IterateAvailableTechInfos();
		}

		// Token: 0x06004983 RID: 18819 RVA: 0x0016F0CC File Offset: 0x0016D2CC
		public IEnumerable<TrainingTech> IterateAvailableTechs()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IterateAvailableTechs_hotfix != null)
			{
				return (IEnumerable<TrainingTech>)this.m_IterateAvailableTechs_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_trainingGroundDS.TrainingGround.IterateAvailableTechs();
		}

		// Token: 0x06004984 RID: 18820 RVA: 0x0016F148 File Offset: 0x0016D348
		public int GetTechLevel(int TechId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTechLevelInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetTechLevelInt32_hotfix.call(new object[]
				{
					this,
					TechId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_trainingGroundDS.TrainingGround.GetTechLevel(TechId);
		}

		// Token: 0x06004985 RID: 18821 RVA: 0x0016F1D8 File Offset: 0x0016D3D8
		public TrainingTech GetTech(int TechId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTechInt32_hotfix != null)
			{
				return (TrainingTech)this.m_GetTechInt32_hotfix.call(new object[]
				{
					this,
					TechId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_trainingGroundDS.GetTech(TechId);
		}

		// Token: 0x06004986 RID: 18822 RVA: 0x0016F260 File Offset: 0x0016D460
		public TrainingRoom GetRoom(int RoomId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRoomInt32_hotfix != null)
			{
				return (TrainingRoom)this.m_GetRoomInt32_hotfix.call(new object[]
				{
					this,
					RoomId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_trainingGroundDS.GetRoom(RoomId);
		}

		// Token: 0x06004987 RID: 18823 RVA: 0x0016F2E8 File Offset: 0x0016D4E8
		public int GetSoldierSkillLevelBySoldierId(int SoldierId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSoldierSkillLevelBySoldierIdInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetSoldierSkillLevelBySoldierIdInt32_hotfix.call(new object[]
				{
					this,
					SoldierId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_trainingGroundDS.TrainingGround.GetTechLevelBySoldierId(SoldierId);
		}

		// Token: 0x17001242 RID: 4674
		// (get) Token: 0x06004988 RID: 18824 RVA: 0x0016F378 File Offset: 0x0016D578
		// (set) Token: 0x06004989 RID: 18825 RVA: 0x0016F3EC File Offset: 0x0016D5EC
		protected IConfigDataLoader m_configDataLoader
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_m_configDataLoader_hotfix != null)
				{
					return (IConfigDataLoader)this.m_get_m_configDataLoader_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this._configDataLoader;
			}
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_m_configDataLoaderIConfigDataLoader_hotfix != null)
				{
					this.m_set_m_configDataLoaderIConfigDataLoader_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				if (this._configDataLoader != null)
				{
					TrainingGround trainingGround = this.m_trainingGroundDS.TrainingGround;
					this._configDataLoader = value;
					trainingGround.ConfigDataLoader = value;
				}
				else
				{
					this._configDataLoader = value;
				}
			}
		}

		// Token: 0x14000065 RID: 101
		// (add) Token: 0x0600498A RID: 18826 RVA: 0x0016F490 File Offset: 0x0016D690
		// (remove) Token: 0x0600498B RID: 18827 RVA: 0x0016F52C File Offset: 0x0016D72C
		public event Action<TrainingTech> TrainingTechLevelupMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_TrainingTechLevelupMissionEventAction`1_hotfix != null)
				{
					this.m_add_TrainingTechLevelupMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<TrainingTech> action = this.TrainingTechLevelupMissionEvent;
				Action<TrainingTech> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<TrainingTech>>(ref this.TrainingTechLevelupMissionEvent, (Action<TrainingTech>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_TrainingTechLevelupMissionEventAction`1_hotfix != null)
				{
					this.m_remove_TrainingTechLevelupMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<TrainingTech> action = this.TrainingTechLevelupMissionEvent;
				Action<TrainingTech> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<TrainingTech>>(ref this.TrainingTechLevelupMissionEvent, (Action<TrainingTech>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17001243 RID: 4675
		// (get) Token: 0x0600498C RID: 18828 RVA: 0x0016F5C8 File Offset: 0x0016D7C8
		// (set) Token: 0x0600498D RID: 18829 RVA: 0x0016F5E8 File Offset: 0x0016D7E8
		[DoNotToLua]
		public TrainingGroundCompomentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new TrainingGroundCompomentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600498E RID: 18830 RVA: 0x0016F5F4 File Offset: 0x0016D7F4
		private void __callDele_TrainingTechLevelupMissionEvent(TrainingTech obj)
		{
			Action<TrainingTech> trainingTechLevelupMissionEvent = this.TrainingTechLevelupMissionEvent;
			if (trainingTechLevelupMissionEvent != null)
			{
				trainingTechLevelupMissionEvent(obj);
			}
		}

		// Token: 0x0600498F RID: 18831 RVA: 0x0016F618 File Offset: 0x0016D818
		private void __clearDele_TrainingTechLevelupMissionEvent(TrainingTech obj)
		{
			this.TrainingTechLevelupMissionEvent = null;
		}

		// Token: 0x06004990 RID: 18832 RVA: 0x0016F624 File Offset: 0x0016D824
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
					this.m_GetTechMaxLevelInt32_hotfix = (luaObj.RawGet("GetTechMaxLevel") as LuaFunction);
					this.m_IsTechLockedInt32_hotfix = (luaObj.RawGet("IsTechLocked") as LuaFunction);
					this.m_CanLevelupInt32Int32_hotfix = (luaObj.RawGet("CanLevelup") as LuaFunction);
					this.m_GetResourceRequirementsByLevelInt32Int32_hotfix = (luaObj.RawGet("GetResourceRequirementsByLevel") as LuaFunction);
					this.m_GetTechLevelupResourceRequirementsInt32Int32_hotfix = (luaObj.RawGet("GetTechLevelupResourceRequirements") as LuaFunction);
					this.m_CheckTechLevelupInt32Int32_hotfix = (luaObj.RawGet("CheckTechLevelup") as LuaFunction);
					this.m_TechLevelupInt32Int32_hotfix = (luaObj.RawGet("TechLevelup") as LuaFunction);
					this.m_AddTechLevelInt32Int32Boolean_hotfix = (luaObj.RawGet("AddTechLevel") as LuaFunction);
					this.m_ApplyTrainingTechToHeroHeroTrainingTech_hotfix = (luaObj.RawGet("ApplyTrainingTechToHero") as LuaFunction);
					this.m_ApplyTrainingTechToHeroHero_hotfix = (luaObj.RawGet("ApplyTrainingTechToHero") as LuaFunction);
					this.m_OutPutTeachnologyTreeOperateLogInt32Int32Int32List`1List`1_hotfix = (luaObj.RawGet("OutPutTeachnologyTreeOperateLog") as LuaFunction);
					this.m_GetAvailableTechs_hotfix = (luaObj.RawGet("GetAvailableTechs") as LuaFunction);
					this.m_IterateAvailableTechInfos_hotfix = (luaObj.RawGet("IterateAvailableTechInfos") as LuaFunction);
					this.m_IterateAvailableTechs_hotfix = (luaObj.RawGet("IterateAvailableTechs") as LuaFunction);
					this.m_GetTechLevelInt32_hotfix = (luaObj.RawGet("GetTechLevel") as LuaFunction);
					this.m_GetTechInt32_hotfix = (luaObj.RawGet("GetTech") as LuaFunction);
					this.m_GetRoomInt32_hotfix = (luaObj.RawGet("GetRoom") as LuaFunction);
					this.m_GetSoldierSkillLevelBySoldierIdInt32_hotfix = (luaObj.RawGet("GetSoldierSkillLevelBySoldierId") as LuaFunction);
					this.m_get_m_configDataLoader_hotfix = (luaObj.RawGet("get_m_configDataLoader") as LuaFunction);
					this.m_set_m_configDataLoaderIConfigDataLoader_hotfix = (luaObj.RawGet("set_m_configDataLoader") as LuaFunction);
					this.m_add_TrainingTechLevelupMissionEventAction`1_hotfix = (luaObj.RawGet("add_TrainingTechLevelupMissionEvent") as LuaFunction);
					this.m_remove_TrainingTechLevelupMissionEventAction`1_hotfix = (luaObj.RawGet("remove_TrainingTechLevelupMissionEvent") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06004991 RID: 18833 RVA: 0x0016FA10 File Offset: 0x0016DC10
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TrainingGroundCompomentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003790 RID: 14224
		private IConfigDataLoader _configDataLoader;

		// Token: 0x04003791 RID: 14225
		public DataSectionTrainingGround m_trainingGroundDS = new DataSectionTrainingGround();

		// Token: 0x04003792 RID: 14226
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x04003793 RID: 14227
		protected BagComponentCommon m_bag;

		// Token: 0x04003794 RID: 14228
		protected HeroComponentCommon m_hero;

		// Token: 0x04003795 RID: 14229
		protected AnikiGymComponentCommon m_anikiGym;

		// Token: 0x04003797 RID: 14231
		[DoNotToLua]
		private TrainingGroundCompomentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x04003798 RID: 14232
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003799 RID: 14233
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400379A RID: 14234
		private LuaFunction m_ctor_hotfix;

		// Token: 0x0400379B RID: 14235
		private LuaFunction m_GetName_hotfix;

		// Token: 0x0400379C RID: 14236
		private LuaFunction m_Init_hotfix;

		// Token: 0x0400379D RID: 14237
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x0400379E RID: 14238
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x0400379F RID: 14239
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x040037A0 RID: 14240
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x040037A1 RID: 14241
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x040037A2 RID: 14242
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x040037A3 RID: 14243
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x040037A4 RID: 14244
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x040037A5 RID: 14245
		private LuaFunction m_GetTechMaxLevelInt32_hotfix;

		// Token: 0x040037A6 RID: 14246
		private LuaFunction m_IsTechLockedInt32_hotfix;

		// Token: 0x040037A7 RID: 14247
		private LuaFunction m_CanLevelupInt32Int32_hotfix;

		// Token: 0x040037A8 RID: 14248
		private LuaFunction m_GetResourceRequirementsByLevelInt32Int32_hotfix;

		// Token: 0x040037A9 RID: 14249
		private LuaFunction m_GetTechLevelupResourceRequirementsInt32Int32_hotfix;

		// Token: 0x040037AA RID: 14250
		private LuaFunction m_CheckTechLevelupInt32Int32_hotfix;

		// Token: 0x040037AB RID: 14251
		private LuaFunction m_TechLevelupInt32Int32_hotfix;

		// Token: 0x040037AC RID: 14252
		private LuaFunction m_AddTechLevelInt32Int32Boolean_hotfix;

		// Token: 0x040037AD RID: 14253
		private LuaFunction m_ApplyTrainingTechToHeroHeroTrainingTech_hotfix;

		// Token: 0x040037AE RID: 14254
		private LuaFunction m_ApplyTrainingTechToHeroHero_hotfix;

		// Token: 0x040037AF RID: 14255
		private LuaFunction m_OutPutTeachnologyTreeOperateLogInt32Int32Int32List`1List;

		// Token: 0x040037B0 RID: 14256
		private LuaFunction m_GetAvailableTechs_hotfix;

		// Token: 0x040037B1 RID: 14257
		private LuaFunction m_IterateAvailableTechInfos_hotfix;

		// Token: 0x040037B2 RID: 14258
		private LuaFunction m_IterateAvailableTechs_hotfix;

		// Token: 0x040037B3 RID: 14259
		private LuaFunction m_GetTechLevelInt32_hotfix;

		// Token: 0x040037B4 RID: 14260
		private LuaFunction m_GetTechInt32_hotfix;

		// Token: 0x040037B5 RID: 14261
		private LuaFunction m_GetRoomInt32_hotfix;

		// Token: 0x040037B6 RID: 14262
		private LuaFunction m_GetSoldierSkillLevelBySoldierIdInt32_hotfix;

		// Token: 0x040037B7 RID: 14263
		private LuaFunction m_get_m_configDataLoader_hotfix;

		// Token: 0x040037B8 RID: 14264
		private LuaFunction m_set_m_configDataLoaderIConfigDataLoader_hotfix;

		// Token: 0x040037B9 RID: 14265
		private LuaFunction m_add_TrainingTechLevelupMissionEventAction;

		// Token: 0x040037BA RID: 14266
		private LuaFunction m_remove_TrainingTechLevelupMissionEventAction;

		// Token: 0x020004B2 RID: 1202
		public class LuaExportHelper
		{
			// Token: 0x06004992 RID: 18834 RVA: 0x0016FA78 File Offset: 0x0016DC78
			public LuaExportHelper(TrainingGroundCompomentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06004993 RID: 18835 RVA: 0x0016FA88 File Offset: 0x0016DC88
			public void __callDele_TrainingTechLevelupMissionEvent(TrainingTech obj)
			{
				this.m_owner.__callDele_TrainingTechLevelupMissionEvent(obj);
			}

			// Token: 0x06004994 RID: 18836 RVA: 0x0016FA98 File Offset: 0x0016DC98
			public void __clearDele_TrainingTechLevelupMissionEvent(TrainingTech obj)
			{
				this.m_owner.__clearDele_TrainingTechLevelupMissionEvent(obj);
			}

			// Token: 0x17001244 RID: 4676
			// (get) Token: 0x06004995 RID: 18837 RVA: 0x0016FAA8 File Offset: 0x0016DCA8
			// (set) Token: 0x06004996 RID: 18838 RVA: 0x0016FAB8 File Offset: 0x0016DCB8
			public IConfigDataLoader _configDataLoader
			{
				get
				{
					return this.m_owner._configDataLoader;
				}
				set
				{
					this.m_owner._configDataLoader = value;
				}
			}

			// Token: 0x17001245 RID: 4677
			// (get) Token: 0x06004997 RID: 18839 RVA: 0x0016FAC8 File Offset: 0x0016DCC8
			// (set) Token: 0x06004998 RID: 18840 RVA: 0x0016FAD8 File Offset: 0x0016DCD8
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

			// Token: 0x17001246 RID: 4678
			// (get) Token: 0x06004999 RID: 18841 RVA: 0x0016FAE8 File Offset: 0x0016DCE8
			// (set) Token: 0x0600499A RID: 18842 RVA: 0x0016FAF8 File Offset: 0x0016DCF8
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

			// Token: 0x17001247 RID: 4679
			// (get) Token: 0x0600499B RID: 18843 RVA: 0x0016FB08 File Offset: 0x0016DD08
			// (set) Token: 0x0600499C RID: 18844 RVA: 0x0016FB18 File Offset: 0x0016DD18
			public HeroComponentCommon m_hero
			{
				get
				{
					return this.m_owner.m_hero;
				}
				set
				{
					this.m_owner.m_hero = value;
				}
			}

			// Token: 0x17001248 RID: 4680
			// (get) Token: 0x0600499D RID: 18845 RVA: 0x0016FB28 File Offset: 0x0016DD28
			// (set) Token: 0x0600499E RID: 18846 RVA: 0x0016FB38 File Offset: 0x0016DD38
			public AnikiGymComponentCommon m_anikiGym
			{
				get
				{
					return this.m_owner.m_anikiGym;
				}
				set
				{
					this.m_owner.m_anikiGym = value;
				}
			}

			// Token: 0x17001249 RID: 4681
			// (get) Token: 0x0600499F RID: 18847 RVA: 0x0016FB48 File Offset: 0x0016DD48
			// (set) Token: 0x060049A0 RID: 18848 RVA: 0x0016FB58 File Offset: 0x0016DD58
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

			// Token: 0x060049A1 RID: 18849 RVA: 0x0016FB68 File Offset: 0x0016DD68
			public void OutPutTeachnologyTreeOperateLog(int courseId, int techId, int currentLvl, List<Goods> itemGot, List<Goods> itemCost)
			{
				this.m_owner.OutPutTeachnologyTreeOperateLog(courseId, techId, currentLvl, itemGot, itemCost);
			}

			// Token: 0x040037BB RID: 14267
			private TrainingGroundCompomentCommon m_owner;
		}
	}
}
