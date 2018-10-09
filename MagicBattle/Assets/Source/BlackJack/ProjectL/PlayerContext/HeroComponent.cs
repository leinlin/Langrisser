using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using BlackJack.UtilityTools;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x020008BD RID: 2237
	[HotFix]
	public class HeroComponent : HeroComponentCommon
	{
		// Token: 0x060070D8 RID: 28888 RVA: 0x001F7850 File Offset: 0x001F5A50
		public HeroComponent()
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

		// Token: 0x060070D9 RID: 28889 RVA: 0x001F78B8 File Offset: 0x001F5AB8
		public override void Init()
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
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			base.Init();
		}

		// Token: 0x060070DA RID: 28890 RVA: 0x001F7934 File Offset: 0x001F5B34
		public override void PostInit()
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
			base.PostInit();
		}

		// Token: 0x060070DB RID: 28891 RVA: 0x001F799C File Offset: 0x001F5B9C
		public override void DeInit()
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
			base.DeInit();
		}

		// Token: 0x060070DC RID: 28892 RVA: 0x001F7A04 File Offset: 0x001F5C04
		public void DeSerialize(DSHeroNtf msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeDSHeroNtf_hotfix != null)
			{
				this.m_DeSerializeDSHeroNtf_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ClearInitedData();
			this.m_heroDS.InitProtagonist(msg.ProtagonistId);
			this.m_heroDS.InitHeroInteractNums(msg.HeroInteractNums);
			this.m_heroDS.InitHeroInteractNumsFlushTime(new DateTime(msg.HeroInteractNumsFlushTime));
			foreach (ProHero proHero in msg.Heroes)
			{
				Hero hero = Hero.PBHeroToHero(proHero);
				if (hero.HeroInfo != null)
				{
					this.m_heroDS.InitHero(hero);
					this.m_heroDS.GainHeroIds.Add(proHero.HeroId);
				}
			}
			foreach (Hero hero2 in this.m_heroDS.GetAllHeroes())
			{
				base.InitHeroDataByCaculate(hero2);
				if (hero2.GetActiveJob() == null)
				{
					Debug.LogWarning("Hero active job id error. " + hero2.ActiveHeroJobRelatedId);
				}
			}
			base.InitWearedEquipments();
			this.m_heroDS.InitVersion((ushort)msg.Version, (ushort)msg.Version);
		}

		// Token: 0x060070DD RID: 28893 RVA: 0x001F7BC4 File Offset: 0x001F5DC4
		public void InteractHero(int heroId, int addFavorabilityExp)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InteractHeroInt32Int32_hotfix != null)
			{
				this.m_InteractHeroInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					addFavorabilityExp
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.AddHeroFavorabilityLevel(heroId, addFavorabilityExp);
			base.AddHeroInteractNums(-1, false);
		}

		// Token: 0x060070DE RID: 28894 RVA: 0x001F7C58 File Offset: 0x001F5E58
		public ConfigDataHeroInteractionInfo GetHeroInteractionInfo(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroInteractionInfoInt32_hotfix != null)
			{
				return (ConfigDataHeroInteractionInfo)this.m_GetHeroInteractionInfoInt32_hotfix.call(new object[]
				{
					this,
					heroId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.m_heroDS.FindHero(heroId);
			if (hero == null)
			{
				return null;
			}
			ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(heroId);
			if (configDataHeroInfo.m_informationInfo == null)
			{
				return null;
			}
			int heroInteractId = base.GetHeroInteractId(hero, configDataHeroInfo.m_informationInfo);
			return this.m_configDataLoader.GetConfigDataHeroInteractionInfo(heroInteractId);
		}

		// Token: 0x060070DF RID: 28895 RVA: 0x001F7D20 File Offset: 0x001F5F20
		public int GetHeroInteractHeroPerformanceId(int heroId, HeroInteractionResultType resultType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroInteractHeroPerformanceIdInt32HeroInteractionResultType_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetHeroInteractHeroPerformanceIdInt32HeroInteractionResultType_hotfix.call(new object[]
				{
					this,
					heroId,
					resultType
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataHeroInteractionInfo heroInteractionInfo = this.GetHeroInteractionInfo(heroId);
			if (heroInteractionInfo == null)
			{
				return int.MinValue;
			}
			int key = int.MinValue;
			if (resultType != HeroInteractionResultType.HeroInteractionResultType_Norml)
			{
				if (resultType != HeroInteractionResultType.HeroInteractionResultType_SmallUp)
				{
					if (resultType == HeroInteractionResultType.HeroInteractionResultType_BigUp)
					{
						key = heroInteractionInfo.BigUpResultPerformance;
					}
				}
				else
				{
					key = heroInteractionInfo.SmallUpResultPerformance;
				}
			}
			else
			{
				key = heroInteractionInfo.NormalResultPerformance;
			}
			ConfigDataPerformanceInfo configDataPerformanceInfo = this.m_configDataLoader.GetConfigDataPerformanceInfo(key);
			if (configDataPerformanceInfo == null)
			{
				return int.MinValue;
			}
			return new Random(DateTime.Now.Second).GetRandomNumber(configDataPerformanceInfo.HeroPerformances_ID);
		}

		// Token: 0x060070E0 RID: 28896 RVA: 0x001F7E3C File Offset: 0x001F603C
		public int CanUnlockHeroPerformance(int heroPerformanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanUnlockHeroPerformanceInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanUnlockHeroPerformanceInt32_hotfix.call(new object[]
				{
					this,
					heroPerformanceId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataHeroPerformanceInfo configDataHeroPerformanceInfo = this.m_configDataLoader.GetConfigDataHeroPerformanceInfo(heroPerformanceId);
			if (configDataHeroPerformanceInfo == null)
			{
				return -665;
			}
			foreach (HeroPerformanceUnlcokCondition heroPerformanceUnlcokCondition in configDataHeroPerformanceInfo.UnlockConditions)
			{
				HeroPerformanceUnlockConditionType conditionType = heroPerformanceUnlcokCondition.ConditionType;
				if (conditionType != HeroPerformanceUnlockConditionType.HeroPerformanceUnlockConditionType_HeroFavourabilityLevel)
				{
					return -667;
				}
				Hero hero = this.m_heroDS.FindHero(heroPerformanceUnlcokCondition.Param1);
				if (hero == null || hero.FavorabilityLevel < heroPerformanceUnlcokCondition.Param2)
				{
					return -666;
				}
			}
			return 0;
		}

		// Token: 0x060070E1 RID: 28897 RVA: 0x001F7F7C File Offset: 0x001F617C
		public int CanUnlockHeroBiography(int biographyId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanUnlockHeroBiographyInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanUnlockHeroBiographyInt32_hotfix.call(new object[]
				{
					this,
					biographyId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataHeroBiographyInfo configDataHeroBiographyInfo = this.m_configDataLoader.GetConfigDataHeroBiographyInfo(biographyId);
			if (configDataHeroBiographyInfo == null)
			{
				return -668;
			}
			foreach (HeroBiographyCondition heroBiographyCondition in configDataHeroBiographyInfo.UnlockConditions)
			{
				HeroBiographyUnlockConditionType conditionType = heroBiographyCondition.ConditionType;
				if (conditionType != HeroBiographyUnlockConditionType.HeroBiographyUnlockConditionType_HeroFavorabilityLevel)
				{
					return -670;
				}
				Hero hero = this.m_heroDS.FindHero(heroBiographyCondition.Parm1);
				if (hero == null || hero.FavorabilityLevel < heroBiographyCondition.Parm2)
				{
					return -669;
				}
			}
			return 0;
		}

		// Token: 0x060070E2 RID: 28898 RVA: 0x001F80BC File Offset: 0x001F62BC
		public ushort GetDSVersion()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDSVersion_hotfix != null)
			{
				return Convert.ToUInt16(this.m_GetDSVersion_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroDS.ClientVersion;
		}

		// Token: 0x060070E3 RID: 28899 RVA: 0x001F8134 File Offset: 0x001F6334
		private void ClearInitedData()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearInitedData_hotfix != null)
			{
				this.m_ClearInitedData_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroDS.ClearInitedData();
			this.m_skills.Clear();
			this.m_soliders.Clear();
			this.m_wearedEquipmentHeroDict.Clear();
		}

		// Token: 0x060070E4 RID: 28900 RVA: 0x001F81C0 File Offset: 0x001F63C0
		public int GetWearedEquipmentHeroIdByEquipmentId(ulong equipmentId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetWearedEquipmentHeroIdByEquipmentIdUInt64_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetWearedEquipmentHeroIdByEquipmentIdUInt64_hotfix.call(new object[]
				{
					this,
					equipmentId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_wearedEquipmentHeroDict.ContainsKey(equipmentId))
			{
				return this.m_wearedEquipmentHeroDict[equipmentId];
			}
			return int.MinValue;
		}

		// Token: 0x060070E5 RID: 28901 RVA: 0x001F8260 File Offset: 0x001F6460
		public int GetHeroInteractNums()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroInteractNums_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetHeroInteractNums_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroDS.HeroInteractNums;
		}

		// Token: 0x060070E6 RID: 28902 RVA: 0x001F82D8 File Offset: 0x001F64D8
		public DateTime GetHeroInteractNumsFlushTime()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroInteractNumsFlushTime_hotfix != null)
			{
				return (DateTime)this.m_GetHeroInteractNumsFlushTime_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroDS.HeroInteractNumsFlushTime;
		}

		// Token: 0x060070E7 RID: 28903 RVA: 0x001F8350 File Offset: 0x001F6550
		public int ImitateUseHeroFavorabilityExpItem(int heroId, int itemId, int nums, GoodsType goodsType = GoodsType.GoodsType_Item)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ImitateUseHeroFavorabilityExpItemInt32Int32Int32GoodsType_hotfix != null)
			{
				return Convert.ToInt32(this.m_ImitateUseHeroFavorabilityExpItemInt32Int32Int32GoodsType_hotfix.call(new object[]
				{
					this,
					heroId,
					itemId,
					nums,
					goodsType
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (goodsType != GoodsType.GoodsType_Item)
			{
				return -529;
			}
			if (nums <= 0)
			{
				return -531;
			}
			if (base.IsProtagonistHero(heroId))
			{
				return -655;
			}
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
			BagItemBase bagItemBase = this.m_bag.FindBagItemByType(goodsType, itemId);
			if (bagItemBase == null || bagItemBase.Nums < nums)
			{
				return -530;
			}
			AddHeroFavorabilityUseableBagItem addHeroFavorabilityUseableBagItem = bagItemBase as AddHeroFavorabilityUseableBagItem;
			if (addHeroFavorabilityUseableBagItem == null)
			{
				return -506;
			}
			int num = addHeroFavorabilityUseableBagItem.CalculateAddFavorabilityExp(heroId);
			Hero hero2 = new Hero(hero);
			int i = 0;
			IL_231:
			while (i < nums)
			{
				if (base.IsFullFavorabilityExp(hero2, configDataHeroInfo.m_informationInfo))
				{
					return -656;
				}
				bool flag = false;
				int num2 = hero2.FavorabilityExp + num;
				while (!flag || !this.m_bag.IsBagFullByCurrentSize())
				{
					int nextExp = this.m_configDataLoader.GetConfigDataHeroFavorabilityLevelInfo(hero2.FavorabilityLevel).NextExp;
					if (num2 < nextExp)
					{
						hero2.FavorabilityExp = num2;
					}
					else if (configDataHeroInfo.m_informationInfo.FavorabilityMaxLevel == hero2.FavorabilityLevel)
					{
						hero2.FavorabilityExp = nextExp;
					}
					else
					{
						hero2.FavorabilityLevel++;
						hero2.FavorabilityExp = 0;
						flag = true;
						num2 -= nextExp;
						if (num2 > 0)
						{
							continue;
						}
					}
					i++;
					goto IL_231;
				}
				return -500;
			}
			return 0;
		}

		// Token: 0x060070E8 RID: 28904 RVA: 0x001F8598 File Offset: 0x001F6798
		public int AutoEquipment(int heroId, List<ulong> equipmentInstanceIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AutoEquipmentInt32List`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_AutoEquipmentInt32List`1_hotfix.call(new object[]
				{
					this,
					heroId,
					equipmentInstanceIds
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = base.FindHero(heroId);
			for (int i = 0; i < 4; i++)
			{
				ulong num = equipmentInstanceIds[i];
				if (num != 0UL && num != hero.EquipmentIds[i])
				{
					base.WearEquipmentBySlot(hero, i, num);
				}
			}
			this.m_atuoEquipmentTouch[heroId] = this.m_basicInfo.GetCurrentTime();
			this.OnHeroBattlePowerChange(hero);
			return 0;
		}

		// Token: 0x17001BCF RID: 7119
		// (get) Token: 0x060070E9 RID: 28905 RVA: 0x001F8684 File Offset: 0x001F6884
		// (set) Token: 0x060070EA RID: 28906 RVA: 0x001F86A4 File Offset: 0x001F68A4
		[DoNotToLua]
		public new HeroComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060070EB RID: 28907 RVA: 0x001F86B0 File Offset: 0x001F68B0
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x060070EC RID: 28908 RVA: 0x001F86B8 File Offset: 0x001F68B8
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x060070ED RID: 28909 RVA: 0x001F86C0 File Offset: 0x001F68C0
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x060070EE RID: 28910 RVA: 0x001F86C8 File Offset: 0x001F68C8
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x060070EF RID: 28911 RVA: 0x001F86D0 File Offset: 0x001F68D0
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x060070F0 RID: 28912 RVA: 0x001F86DC File Offset: 0x001F68DC
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x060070F1 RID: 28913 RVA: 0x001F86E4 File Offset: 0x001F68E4
		private int __callBase_GetProtagonistID()
		{
			return base.GetProtagonistID();
		}

		// Token: 0x060070F2 RID: 28914 RVA: 0x001F86EC File Offset: 0x001F68EC
		private bool __callBase_IsProtagonistHero(int heroId)
		{
			return base.IsProtagonistHero(heroId);
		}

		// Token: 0x060070F3 RID: 28915 RVA: 0x001F86F8 File Offset: 0x001F68F8
		private bool __callBase_IsProtagonistExist()
		{
			return base.IsProtagonistExist();
		}

		// Token: 0x060070F4 RID: 28916 RVA: 0x001F8700 File Offset: 0x001F6900
		private int __callBase_SetProtagonist(int protagonistId)
		{
			return base.SetProtagonist(protagonistId);
		}

		// Token: 0x060070F5 RID: 28917 RVA: 0x001F870C File Offset: 0x001F690C
		private List<Hero> __callBase_GetAllStarLvlMaxHeroes()
		{
			return base.GetAllStarLvlMaxHeroes();
		}

		// Token: 0x060070F6 RID: 28918 RVA: 0x001F8714 File Offset: 0x001F6914
		private List<HeroFragmentBagItem> __callBase_GetAllStarLvlMaxHeroFragments()
		{
			return base.GetAllStarLvlMaxHeroFragments();
		}

		// Token: 0x060070F7 RID: 28919 RVA: 0x001F871C File Offset: 0x001F691C
		private void __callBase_InitHeroDataByCaculate(Hero hero)
		{
			base.InitHeroDataByCaculate(hero);
		}

		// Token: 0x060070F8 RID: 28920 RVA: 0x001F8728 File Offset: 0x001F6928
		private int __callBase_CanHeroJobEquipSkill(int jobRelatedId, int skillId)
		{
			return base.CanHeroJobEquipSkill(jobRelatedId, skillId);
		}

		// Token: 0x060070F9 RID: 28921 RVA: 0x001F8734 File Offset: 0x001F6934
		private int __callBase_CanSelectSkillHero(Hero hero, List<int> skills)
		{
			return base.CanSelectSkillHero(hero, skills);
		}

		// Token: 0x060070FA RID: 28922 RVA: 0x001F8740 File Offset: 0x001F6940
		private int __callBase_SelectSkills(int heroId, List<int> skills)
		{
			return base.SelectSkills(heroId, skills);
		}

		// Token: 0x060070FB RID: 28923 RVA: 0x001F874C File Offset: 0x001F694C
		private int __callBase_SelectSoldier(int heroId, int soldierId)
		{
			return base.SelectSoldier(heroId, soldierId);
		}

		// Token: 0x060070FC RID: 28924 RVA: 0x001F8758 File Offset: 0x001F6958
		private int __callBase_CanHeroSelectSolider(Hero hero, int soliderId)
		{
			return base.CanHeroSelectSolider(hero, soliderId);
		}

		// Token: 0x060070FD RID: 28925 RVA: 0x001F8764 File Offset: 0x001F6964
		private int __callBase_RemoveHero(int heroId)
		{
			return base.RemoveHero(heroId);
		}

		// Token: 0x060070FE RID: 28926 RVA: 0x001F8770 File Offset: 0x001F6970
		private void __callBase_RemoveAllHero(List<int> changedHeroIdList)
		{
			base.RemoveAllHero(changedHeroIdList);
		}

		// Token: 0x060070FF RID: 28927 RVA: 0x001F877C File Offset: 0x001F697C
		private void __callBase_RemoveAllHeros()
		{
			base.RemoveAllHeros();
		}

		// Token: 0x06007100 RID: 28928 RVA: 0x001F8784 File Offset: 0x001F6984
		private List<Hero> __callBase_GetAllHeros()
		{
			return base.GetAllHeros();
		}

		// Token: 0x06007101 RID: 28929 RVA: 0x001F878C File Offset: 0x001F698C
		private HeroJob __callBase_FindHeroJob(Hero hero, int jobRelatedId)
		{
			return base.FindHeroJob(hero, jobRelatedId);
		}

		// Token: 0x06007102 RID: 28930 RVA: 0x001F8798 File Offset: 0x001F6998
		private bool __callBase_IsUnlockedHeroJob(Hero hero, int jobRelatedId)
		{
			return base.IsUnlockedHeroJob(hero, jobRelatedId);
		}

		// Token: 0x06007103 RID: 28931 RVA: 0x001F87A4 File Offset: 0x001F69A4
		private HeroJob __callBase_FindHeroJob(int heroId, int jobRelatedId)
		{
			return base.FindHeroJob(heroId, jobRelatedId);
		}

		// Token: 0x06007104 RID: 28932 RVA: 0x001F87B0 File Offset: 0x001F69B0
		private Hero __callBase_FindHero(int heroId)
		{
			return base.FindHero(heroId);
		}

		// Token: 0x06007105 RID: 28933 RVA: 0x001F87BC File Offset: 0x001F69BC
		private int __callBase_AddHeroFightNums(int heroId, int nums)
		{
			return base.AddHeroFightNums(heroId, nums);
		}

		// Token: 0x06007106 RID: 28934 RVA: 0x001F87C8 File Offset: 0x001F69C8
		private int __callBase_AddHeroAllNeedJobsAchievements(int heroId, List<int> achievements)
		{
			return base.AddHeroAllNeedJobsAchievements(heroId, achievements);
		}

		// Token: 0x06007107 RID: 28935 RVA: 0x001F87D4 File Offset: 0x001F69D4
		private int __callBase_AddHero(int heroId)
		{
			return base.AddHero(heroId);
		}

		// Token: 0x06007108 RID: 28936 RVA: 0x001F87E0 File Offset: 0x001F69E0
		private bool __callBase_IsWastefulAddExp(Hero hero, int addExp)
		{
			return base.IsWastefulAddExp(hero, addExp);
		}

		// Token: 0x06007109 RID: 28937 RVA: 0x001F87EC File Offset: 0x001F69EC
		private bool __callBase_IsCurrentLevelMaxHeroLevel(int heroLevel)
		{
			return base.IsCurrentLevelMaxHeroLevel(heroLevel);
		}

		// Token: 0x0600710A RID: 28938 RVA: 0x001F87F8 File Offset: 0x001F69F8
		private bool __callBase_IsFullCurrentHeroExp(Hero hero)
		{
			return base.IsFullCurrentHeroExp(hero);
		}

		// Token: 0x0600710B RID: 28939 RVA: 0x001F8804 File Offset: 0x001F6A04
		private void __callBase_AddHeroesExp(List<int> heroIds, int exp)
		{
			base.AddHeroesExp(heroIds, exp);
		}

		// Token: 0x0600710C RID: 28940 RVA: 0x001F8810 File Offset: 0x001F6A10
		private int __callBase_CanAddHeroExp(int heroId)
		{
			return base.CanAddHeroExp(heroId);
		}

		// Token: 0x0600710D RID: 28941 RVA: 0x001F881C File Offset: 0x001F6A1C
		private int __callBase_AddHeroExp(int heroId, int exp)
		{
			return base.AddHeroExp(heroId, exp);
		}

		// Token: 0x0600710E RID: 28942 RVA: 0x001F8828 File Offset: 0x001F6A28
		private void __callBase_OutPutHeroLevelUpOperateLog(int heroId, int currentLevel)
		{
			base.OutPutHeroLevelUpOperateLog(heroId, currentLevel);
		}

		// Token: 0x0600710F RID: 28943 RVA: 0x001F8834 File Offset: 0x001F6A34
		private int __callBase_AddHeroExpByUseableBagItem(int heroId, GoodsType goodsTypeId, int contentId, int consumeNums)
		{
			return base.AddHeroExpByUseableBagItem(heroId, goodsTypeId, contentId, consumeNums);
		}

		// Token: 0x06007110 RID: 28944 RVA: 0x001F8844 File Offset: 0x001F6A44
		private int __callBase_ComposeHero(int heroId)
		{
			return base.ComposeHero(heroId);
		}

		// Token: 0x06007111 RID: 28945 RVA: 0x001F8850 File Offset: 0x001F6A50
		private bool __callBase_IsLvlMaxHeroStar(Hero hero)
		{
			return base.IsLvlMaxHeroStar(hero);
		}

		// Token: 0x06007112 RID: 28946 RVA: 0x001F885C File Offset: 0x001F6A5C
		private int __callBase_LevelUpHeroStarLevel(int heroId)
		{
			return base.LevelUpHeroStarLevel(heroId);
		}

		// Token: 0x06007113 RID: 28947 RVA: 0x001F8868 File Offset: 0x001F6A68
		private void __callBase_OutPutHeroUpgradeOperateLog(int heroId, int currentStar, List<Goods> costItems)
		{
			base.OutPutHeroUpgradeOperateLog(heroId, currentStar, costItems);
		}

		// Token: 0x06007114 RID: 28948 RVA: 0x001F8874 File Offset: 0x001F6A74
		private HashSet<int> __callBase_GetGainHeroIds()
		{
			return base.GetGainHeroIds();
		}

		// Token: 0x06007115 RID: 28949 RVA: 0x001F887C File Offset: 0x001F6A7C
		private bool __callBase_HasGainHero(int heroId)
		{
			return base.HasGainHero(heroId);
		}

		// Token: 0x06007116 RID: 28950 RVA: 0x001F8888 File Offset: 0x001F6A88
		private bool __callBase_IsExistSkillId(int skillId)
		{
			return base.IsExistSkillId(skillId);
		}

		// Token: 0x06007117 RID: 28951 RVA: 0x001F8894 File Offset: 0x001F6A94
		private bool __callBase_IsExistSoliderId(int soliderId)
		{
			return base.IsExistSoliderId(soliderId);
		}

		// Token: 0x06007118 RID: 28952 RVA: 0x001F88A0 File Offset: 0x001F6AA0
		private LinkedList<Hero> __callBase_FindTopLevelHeroes(int topNums)
		{
			return base.FindTopLevelHeroes(topNums);
		}

		// Token: 0x06007119 RID: 28953 RVA: 0x001F88AC File Offset: 0x001F6AAC
		private int __callBase_GetActiveHeroJobRelatedIdByHeroId(int heroId)
		{
			return base.GetActiveHeroJobRelatedIdByHeroId(heroId);
		}

		// Token: 0x0600711A RID: 28954 RVA: 0x001F88B8 File Offset: 0x001F6AB8
		private int __callBase_GmResetHeroJob(int heroId)
		{
			return base.GmResetHeroJob(heroId);
		}

		// Token: 0x0600711B RID: 28955 RVA: 0x001F88C4 File Offset: 0x001F6AC4
		private void __callBase_OnHeroLevelUp(int oldLevel, Hero hero)
		{
			base.OnHeroLevelUp(oldLevel, hero);
		}

		// Token: 0x0600711C RID: 28956 RVA: 0x001F88D0 File Offset: 0x001F6AD0
		private int __callBase_GetAdditiveHeroAddExp(int addExp)
		{
			return base.GetAdditiveHeroAddExp(addExp);
		}

		// Token: 0x0600711D RID: 28957 RVA: 0x001F88DC File Offset: 0x001F6ADC
		private int __callBase_GetAdditiveHeroFavourabilityAddExp(int addExp)
		{
			return base.GetAdditiveHeroFavourabilityAddExp(addExp);
		}

		// Token: 0x0600711E RID: 28958 RVA: 0x001F88E8 File Offset: 0x001F6AE8
		private void __callBase_AddHeroJobAchievementsAfterBattleLevelEnd(List<int> relatedAchievements, List<int> fightHeroes)
		{
			base.AddHeroJobAchievementsAfterBattleLevelEnd(relatedAchievements, fightHeroes);
		}

		// Token: 0x0600711F RID: 28959 RVA: 0x001F88F4 File Offset: 0x001F6AF4
		private bool __callBase_IsJobLevelMax(ConfigDataJobConnectionInfo jobConnectionInfo, int jobLevel)
		{
			return base.IsJobLevelMax(jobConnectionInfo, jobLevel);
		}

		// Token: 0x06007120 RID: 28960 RVA: 0x001F8900 File Offset: 0x001F6B00
		private bool __callBase_IsJobLevelMax(HeroJob job)
		{
			return base.IsJobLevelMax(job);
		}

		// Token: 0x06007121 RID: 28961 RVA: 0x001F890C File Offset: 0x001F6B0C
		private int __callBase_CanLevelUpHeroJobLevel(int heroId, int jobRelatedId)
		{
			return base.CanLevelUpHeroJobLevel(heroId, jobRelatedId);
		}

		// Token: 0x06007122 RID: 28962 RVA: 0x001F8918 File Offset: 0x001F6B18
		private int __callBase_CanTransferHeroJob(int heroId, int jobRelatedId)
		{
			return base.CanTransferHeroJob(heroId, jobRelatedId);
		}

		// Token: 0x06007123 RID: 28963 RVA: 0x001F8924 File Offset: 0x001F6B24
		private int __callBase_TransferHeroJob(int heroId, int jobRelatedId)
		{
			return base.TransferHeroJob(heroId, jobRelatedId);
		}

		// Token: 0x06007124 RID: 28964 RVA: 0x001F8930 File Offset: 0x001F6B30
		private void __callBase_OutPutHeroJobChangeOperateLog(int heroId, int preJobConnectionId, int postJobConnectionId, List<Goods> costItems)
		{
			base.OutPutHeroJobChangeOperateLog(heroId, preJobConnectionId, postJobConnectionId, costItems);
		}

		// Token: 0x06007125 RID: 28965 RVA: 0x001F8940 File Offset: 0x001F6B40
		private bool __callBase_IsNeedUnlock(ConfigDataJobConnectionInfo jobConnectionInfo)
		{
			return base.IsNeedUnlock(jobConnectionInfo);
		}

		// Token: 0x06007126 RID: 28966 RVA: 0x001F894C File Offset: 0x001F6B4C
		private int __callBase_UnlockedHeroJob(int heroId, int jobRelatedId)
		{
			return base.UnlockedHeroJob(heroId, jobRelatedId);
		}

		// Token: 0x06007127 RID: 28967 RVA: 0x001F8958 File Offset: 0x001F6B58
		private void __callBase_OutPutHeroJobUnlockOperateLog(int heroId, int activeJobId, int unlockJobId, List<Goods> costItems)
		{
			base.OutPutHeroJobUnlockOperateLog(heroId, activeJobId, unlockJobId, costItems);
		}

		// Token: 0x06007128 RID: 28968 RVA: 0x001F8968 File Offset: 0x001F6B68
		private int __callBase_LevelUpHeroJobLevel(int heroId, int jobRelatedId)
		{
			return base.LevelUpHeroJobLevel(heroId, jobRelatedId);
		}

		// Token: 0x06007129 RID: 28969 RVA: 0x001F8974 File Offset: 0x001F6B74
		private void __callBase_OutPutHeroJobLevelUpOperateLog(int heroId, int activeJobId, int currentLevel, List<Goods> costItems)
		{
			base.OutPutHeroJobLevelUpOperateLog(heroId, activeJobId, currentLevel, costItems);
		}

		// Token: 0x0600712A RID: 28970 RVA: 0x001F8984 File Offset: 0x001F6B84
		private void __callBase_AddSoldier(Hero hero, int soldierId, bool needExchange)
		{
			base.AddSoldier(hero, soldierId, needExchange);
		}

		// Token: 0x0600712B RID: 28971 RVA: 0x001F8990 File Offset: 0x001F6B90
		private int __callBase_AutoTakeOffEquipments(int heroId)
		{
			return base.AutoTakeOffEquipments(heroId);
		}

		// Token: 0x0600712C RID: 28972 RVA: 0x001F899C File Offset: 0x001F6B9C
		private void __callBase_InitWearedEquipments()
		{
			base.InitWearedEquipments();
		}

		// Token: 0x0600712D RID: 28973 RVA: 0x001F89A4 File Offset: 0x001F6BA4
		private int __callBase_CanWearEquipment(int heroId, ulong instanceId)
		{
			return base.CanWearEquipment(heroId, instanceId);
		}

		// Token: 0x0600712E RID: 28974 RVA: 0x001F89B0 File Offset: 0x001F6BB0
		private int __callBase_CanWearEquipmentByJobAndArmy(Hero hero, BagItemBase equipment)
		{
			return base.CanWearEquipmentByJobAndArmy(hero, equipment);
		}

		// Token: 0x0600712F RID: 28975 RVA: 0x001F89BC File Offset: 0x001F6BBC
		private bool __callBase_IsEquipmentWeared(ulong instanceId)
		{
			return base.IsEquipmentWeared(instanceId);
		}

		// Token: 0x06007130 RID: 28976 RVA: 0x001F89C8 File Offset: 0x001F6BC8
		private Hero __callBase_GetWearedEquipmentHero(ulong instanceId)
		{
			return base.GetWearedEquipmentHero(instanceId);
		}

		// Token: 0x06007131 RID: 28977 RVA: 0x001F89D4 File Offset: 0x001F6BD4
		private int __callBase_WearEquipment(int heroId, ulong instanceId)
		{
			return base.WearEquipment(heroId, instanceId);
		}

		// Token: 0x06007132 RID: 28978 RVA: 0x001F89E0 File Offset: 0x001F6BE0
		private void __callBase_WearEquipmentBySlot(Hero hero, int slot, ulong instanceId)
		{
			base.WearEquipmentBySlot(hero, slot, instanceId);
		}

		// Token: 0x06007133 RID: 28979 RVA: 0x001F89EC File Offset: 0x001F6BEC
		private int __callBase_CanTakeOffEquipment(int heroId, int slot)
		{
			return base.CanTakeOffEquipment(heroId, slot);
		}

		// Token: 0x06007134 RID: 28980 RVA: 0x001F89F8 File Offset: 0x001F6BF8
		private int __callBase_TakeOffEquipment(int heroId, int slot)
		{
			return base.TakeOffEquipment(heroId, slot);
		}

		// Token: 0x06007135 RID: 28981 RVA: 0x001F8A04 File Offset: 0x001F6C04
		private bool __callBase_HasBetterEquipmentByHero(int heroId)
		{
			return base.HasBetterEquipmentByHero(heroId);
		}

		// Token: 0x06007136 RID: 28982 RVA: 0x001F8A10 File Offset: 0x001F6C10
		private bool __callBase_HasBetterEquipmentBySlotId(int heroId, int slotId)
		{
			return base.HasBetterEquipmentBySlotId(heroId, slotId);
		}

		// Token: 0x06007137 RID: 28983 RVA: 0x001F8A1C File Offset: 0x001F6C1C
		private BagItemBase __callBase_GetWearedEquipmentBySlotId(Hero hero, int slotId)
		{
			return base.GetWearedEquipmentBySlotId(hero, slotId);
		}

		// Token: 0x06007138 RID: 28984 RVA: 0x001F8A28 File Offset: 0x001F6C28
		private bool __callBase_IsBetterEquipment(BagItemBase wearedEquipment, BagItemBase compareEquipment, int slotId)
		{
			return base.IsBetterEquipment(wearedEquipment, compareEquipment, slotId);
		}

		// Token: 0x06007139 RID: 28985 RVA: 0x001F8A34 File Offset: 0x001F6C34
		private int __callBase_CanAutoEquipmentByClient(int heroId)
		{
			return base.CanAutoEquipmentByClient(heroId);
		}

		// Token: 0x0600713A RID: 28986 RVA: 0x001F8A40 File Offset: 0x001F6C40
		private int __callBase_CanAutoEquipment(int heroId)
		{
			return base.CanAutoEquipment(heroId);
		}

		// Token: 0x0600713B RID: 28987 RVA: 0x001F8A4C File Offset: 0x001F6C4C
		private int __callBase_CanWearCharSkin(int heroId, int charSkinId)
		{
			return base.CanWearCharSkin(heroId, charSkinId);
		}

		// Token: 0x0600713C RID: 28988 RVA: 0x001F8A58 File Offset: 0x001F6C58
		private int __callBase_WearCharSkin(int heroId, int charSkinId)
		{
			return base.WearCharSkin(heroId, charSkinId);
		}

		// Token: 0x0600713D RID: 28989 RVA: 0x001F8A64 File Offset: 0x001F6C64
		private int __callBase_CanTakeOffCharSkin(int heroId)
		{
			return base.CanTakeOffCharSkin(heroId);
		}

		// Token: 0x0600713E RID: 28990 RVA: 0x001F8A70 File Offset: 0x001F6C70
		private int __callBase_TakeOffCharSkin(int heroId)
		{
			return base.TakeOffCharSkin(heroId);
		}

		// Token: 0x0600713F RID: 28991 RVA: 0x001F8A7C File Offset: 0x001F6C7C
		private int __callBase_CanWearModelSkin(int heroId, int jobRelatedId, int modelSkinId)
		{
			return base.CanWearModelSkin(heroId, jobRelatedId, modelSkinId);
		}

		// Token: 0x06007140 RID: 28992 RVA: 0x001F8A88 File Offset: 0x001F6C88
		private int __callBase_WearModelSkin(int heroId, int jobRelatedId, int modelSkinId)
		{
			return base.WearModelSkin(heroId, jobRelatedId, modelSkinId);
		}

		// Token: 0x06007141 RID: 28993 RVA: 0x001F8A94 File Offset: 0x001F6C94
		private int __callBase_CanTakeOffModelSkin(int heroId, int jobRelatedId)
		{
			return base.CanTakeOffModelSkin(heroId, jobRelatedId);
		}

		// Token: 0x06007142 RID: 28994 RVA: 0x001F8AA0 File Offset: 0x001F6CA0
		private int __callBase_TakeOffModelSkin(int heroId, int jobRelatedId)
		{
			return base.TakeOffModelSkin(heroId, jobRelatedId);
		}

		// Token: 0x06007143 RID: 28995 RVA: 0x001F8AAC File Offset: 0x001F6CAC
		private int __callBase_CanWearSoldierSkin(int heroId, int soldierId, int soldierSkinId)
		{
			return base.CanWearSoldierSkin(heroId, soldierId, soldierSkinId);
		}

		// Token: 0x06007144 RID: 28996 RVA: 0x001F8AB8 File Offset: 0x001F6CB8
		private int __callBase_WearSoldierSkin(int heroId, int soldierId, int soldierSkinId, bool applyToAll)
		{
			return base.WearSoldierSkin(heroId, soldierId, soldierSkinId, applyToAll);
		}

		// Token: 0x06007145 RID: 28997 RVA: 0x001F8AC8 File Offset: 0x001F6CC8
		private int __callBase_CanTakeOffSoldierSkin(int heroId, int soldierId)
		{
			return base.CanTakeOffSoldierSkin(heroId, soldierId);
		}

		// Token: 0x06007146 RID: 28998 RVA: 0x001F8AD4 File Offset: 0x001F6CD4
		private int __callBase_TakeOffSoldierSkin(int heroId, int soldierId, bool applyToAll)
		{
			return base.TakeOffSoldierSkin(heroId, soldierId, applyToAll);
		}

		// Token: 0x06007147 RID: 28999 RVA: 0x001F8AE0 File Offset: 0x001F6CE0
		private void __callBase_TakeOffSoldierSkinApplyToAll(int soldierId, int skinId)
		{
			base.TakeOffSoldierSkinApplyToAll(soldierId, skinId);
		}

		// Token: 0x06007148 RID: 29000 RVA: 0x001F8AEC File Offset: 0x001F6CEC
		private int __callBase_AddHeroFavorabilityExpByUseableBagItem(int heroId, GoodsType goodsTypeId, int contentId, int consumeNums)
		{
			return base.AddHeroFavorabilityExpByUseableBagItem(heroId, goodsTypeId, contentId, consumeNums);
		}

		// Token: 0x06007149 RID: 29001 RVA: 0x001F8AFC File Offset: 0x001F6CFC
		private int __callBase_AddHeroFavorabilityLevel(int heroId, int addExp)
		{
			return base.AddHeroFavorabilityLevel(heroId, addExp);
		}

		// Token: 0x0600714A RID: 29002 RVA: 0x001F8B08 File Offset: 0x001F6D08
		private void __callBase_OutPutHeroFavourabilityOperateLog(int heroId, int oldLvl, int oldExp, int newLvl, int newExp, List<Goods> rewards)
		{
			base.OutPutHeroFavourabilityOperateLog(heroId, oldLvl, oldExp, newLvl, newExp, rewards);
		}

		// Token: 0x0600714B RID: 29003 RVA: 0x001F8B1C File Offset: 0x001F6D1C
		private void __callBase_GenerateFavorabilityLevelUpReward(int heroId, int dropId)
		{
			base.GenerateFavorabilityLevelUpReward(heroId, dropId);
		}

		// Token: 0x0600714C RID: 29004 RVA: 0x001F8B28 File Offset: 0x001F6D28
		private bool __callBase_IsFullFavorabilityExp(Hero hero, ConfigDataHeroInformationInfo heroInformationInfo)
		{
			return base.IsFullFavorabilityExp(hero, heroInformationInfo);
		}

		// Token: 0x0600714D RID: 29005 RVA: 0x001F8B34 File Offset: 0x001F6D34
		private void __callBase_UpdateProtagonistHeroFavorabilityLevel()
		{
			base.UpdateProtagonistHeroFavorabilityLevel();
		}

		// Token: 0x0600714E RID: 29006 RVA: 0x001F8B3C File Offset: 0x001F6D3C
		private int __callBase_CanUnlockHeroFetter(int heroId, int fetterId)
		{
			return base.CanUnlockHeroFetter(heroId, fetterId);
		}

		// Token: 0x0600714F RID: 29007 RVA: 0x001F8B48 File Offset: 0x001F6D48
		private int __callBase_CanReachFetterUnlockCondition(HeroFetterCompletionCondition condition)
		{
			return base.CanReachFetterUnlockCondition(condition);
		}

		// Token: 0x06007150 RID: 29008 RVA: 0x001F8B54 File Offset: 0x001F6D54
		private int __callBase_GmLevelUpHeroFetter2SpecificLevel(int heroId, int fetterId, int reachLevel)
		{
			return base.GmLevelUpHeroFetter2SpecificLevel(heroId, fetterId, reachLevel);
		}

		// Token: 0x06007151 RID: 29009 RVA: 0x001F8B60 File Offset: 0x001F6D60
		private int __callBase_CanLevelUpHeroFetter(int heroId, int fetterId)
		{
			return base.CanLevelUpHeroFetter(heroId, fetterId);
		}

		// Token: 0x06007152 RID: 29010 RVA: 0x001F8B6C File Offset: 0x001F6D6C
		private int __callBase_LevelUpHeroFetter(int heroId, int fetterId)
		{
			return base.LevelUpHeroFetter(heroId, fetterId);
		}

		// Token: 0x06007153 RID: 29011 RVA: 0x001F8B78 File Offset: 0x001F6D78
		private void __callBase_LevelUpHeroFetterCallBack(Hero hero, int fetterId)
		{
			base.LevelUpHeroFetterCallBack(hero, fetterId);
		}

		// Token: 0x06007154 RID: 29012 RVA: 0x001F8B84 File Offset: 0x001F6D84
		private void __callBase_OutPutHeroFetterOpereateLog(int heroId, int fetterId, int currentLvl, List<Goods> itemCost, List<Goods> rewards)
		{
			base.OutPutHeroFetterOpereateLog(heroId, fetterId, currentLvl, itemCost, rewards);
		}

		// Token: 0x06007155 RID: 29013 RVA: 0x001F8B94 File Offset: 0x001F6D94
		private int __callBase_UnlockHeroFetter(int heroId, int fetterId, bool check)
		{
			return base.UnlockHeroFetter(heroId, fetterId, check);
		}

		// Token: 0x06007156 RID: 29014 RVA: 0x001F8BA0 File Offset: 0x001F6DA0
		private void __callBase_GenerateFetterUnlockRewards(int heroId, int fetterId)
		{
			base.GenerateFetterUnlockRewards(heroId, fetterId);
		}

		// Token: 0x06007157 RID: 29015 RVA: 0x001F8BAC File Offset: 0x001F6DAC
		private int __callBase_ConfessHero(int heroId, bool check)
		{
			return base.ConfessHero(heroId, check);
		}

		// Token: 0x06007158 RID: 29016 RVA: 0x001F8BB8 File Offset: 0x001F6DB8
		private void __callBase_GenerateConfessionRewards(int herId, ConfigDataHeroConfessionInfo confessionInfo)
		{
			base.GenerateConfessionRewards(herId, confessionInfo);
		}

		// Token: 0x06007159 RID: 29017 RVA: 0x001F8BC4 File Offset: 0x001F6DC4
		private int __callBase_CanConfessHero(int heroId)
		{
			return base.CanConfessHero(heroId);
		}

		// Token: 0x0600715A RID: 29018 RVA: 0x001F8BD0 File Offset: 0x001F6DD0
		private void __callBase_InitHeroInteractNums()
		{
			base.InitHeroInteractNums();
		}

		// Token: 0x0600715B RID: 29019 RVA: 0x001F8BD8 File Offset: 0x001F6DD8
		private void __callBase_AddHeroInteractNums(int addNums, bool recoveryByTime)
		{
			base.AddHeroInteractNums(addNums, recoveryByTime);
		}

		// Token: 0x0600715C RID: 29020 RVA: 0x001F8BE4 File Offset: 0x001F6DE4
		private int __callBase_CanInteractHero(int heroId)
		{
			return base.CanInteractHero(heroId);
		}

		// Token: 0x0600715D RID: 29021 RVA: 0x001F8BF0 File Offset: 0x001F6DF0
		private int __callBase_GetHeroFavorabilityUpLevel(Hero hero, ConfigDataHeroInformationInfo heroInformationInfo, int addExp)
		{
			return base.GetHeroFavorabilityUpLevel(hero, heroInformationInfo, addExp);
		}

		// Token: 0x0600715E RID: 29022 RVA: 0x001F8BFC File Offset: 0x001F6DFC
		private int __callBase_GetHeroInteractId(Hero hero, ConfigDataHeroInformationInfo heroInformationInfo)
		{
			return base.GetHeroInteractId(hero, heroInformationInfo);
		}

		// Token: 0x0600715F RID: 29023 RVA: 0x001F8C08 File Offset: 0x001F6E08
		private int __callBase_GetAllHeroBattlePower()
		{
			return base.GetAllHeroBattlePower();
		}

		// Token: 0x06007160 RID: 29024 RVA: 0x001F8C10 File Offset: 0x001F6E10
		private int __callBase_GetLastAllHeroRank()
		{
			return base.GetLastAllHeroRank();
		}

		// Token: 0x06007161 RID: 29025 RVA: 0x001F8C18 File Offset: 0x001F6E18
		private int __callBase_GetTopHeroBattlePower()
		{
			return base.GetTopHeroBattlePower();
		}

		// Token: 0x06007162 RID: 29026 RVA: 0x001F8C20 File Offset: 0x001F6E20
		private int __callBase_GetLastTopHeroRank()
		{
			return base.GetLastTopHeroRank();
		}

		// Token: 0x06007163 RID: 29027 RVA: 0x001F8C28 File Offset: 0x001F6E28
		private int __callBase_GetChampionHeroBattlePower()
		{
			return base.GetChampionHeroBattlePower();
		}

		// Token: 0x06007164 RID: 29028 RVA: 0x001F8C30 File Offset: 0x001F6E30
		private int __callBase_GetChampionHeroId()
		{
			return base.GetChampionHeroId();
		}

		// Token: 0x06007165 RID: 29029 RVA: 0x001F8C38 File Offset: 0x001F6E38
		private int __callBase_GetLastChampionHeroRank()
		{
			return base.GetLastChampionHeroRank();
		}

		// Token: 0x06007166 RID: 29030 RVA: 0x001F8C40 File Offset: 0x001F6E40
		private bool __callBase_ComputeBattlePower(Hero hero)
		{
			return base.ComputeBattlePower(hero);
		}

		// Token: 0x06007167 RID: 29031 RVA: 0x001F8C4C File Offset: 0x001F6E4C
		private void __callBase_OnHeroBattlePowerChange(Hero hero)
		{
			base.OnHeroBattlePowerChange(hero);
		}

		// Token: 0x06007168 RID: 29032 RVA: 0x001F8C58 File Offset: 0x001F6E58
		private int __callBase_CanComposeHero(int heroId)
		{
			return base.CanComposeHero(heroId);
		}

		// Token: 0x06007169 RID: 29033 RVA: 0x001F8C64 File Offset: 0x001F6E64
		private int __callBase_CanLevelUpHeroStarLevel(int heroId)
		{
			return base.CanLevelUpHeroStarLevel(heroId);
		}

		// Token: 0x0600716A RID: 29034 RVA: 0x001F8C70 File Offset: 0x001F6E70
		private List<ulong> __callBase_GetEquipedEquipments()
		{
			return base.GetEquipedEquipments();
		}

		// Token: 0x0600716B RID: 29035 RVA: 0x001F8C78 File Offset: 0x001F6E78
		private int __callBase_GetSkillEnergyFromConfig(int heroLevel)
		{
			return base.GetSkillEnergyFromConfig(heroLevel);
		}

		// Token: 0x0600716C RID: 29036 RVA: 0x001F8C84 File Offset: 0x001F6E84
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
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_PostInit_hotfix = (luaObj.RawGet("PostInit") as LuaFunction);
					this.m_DeInit_hotfix = (luaObj.RawGet("DeInit") as LuaFunction);
					this.m_DeSerializeDSHeroNtf_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_InteractHeroInt32Int32_hotfix = (luaObj.RawGet("InteractHero") as LuaFunction);
					this.m_GetHeroInteractionInfoInt32_hotfix = (luaObj.RawGet("GetHeroInteractionInfo") as LuaFunction);
					this.m_GetHeroInteractHeroPerformanceIdInt32HeroInteractionResultType_hotfix = (luaObj.RawGet("GetHeroInteractHeroPerformanceId") as LuaFunction);
					this.m_CanUnlockHeroPerformanceInt32_hotfix = (luaObj.RawGet("CanUnlockHeroPerformance") as LuaFunction);
					this.m_CanUnlockHeroBiographyInt32_hotfix = (luaObj.RawGet("CanUnlockHeroBiography") as LuaFunction);
					this.m_GetDSVersion_hotfix = (luaObj.RawGet("GetDSVersion") as LuaFunction);
					this.m_ClearInitedData_hotfix = (luaObj.RawGet("ClearInitedData") as LuaFunction);
					this.m_GetWearedEquipmentHeroIdByEquipmentIdUInt64_hotfix = (luaObj.RawGet("GetWearedEquipmentHeroIdByEquipmentId") as LuaFunction);
					this.m_GetHeroInteractNums_hotfix = (luaObj.RawGet("GetHeroInteractNums") as LuaFunction);
					this.m_GetHeroInteractNumsFlushTime_hotfix = (luaObj.RawGet("GetHeroInteractNumsFlushTime") as LuaFunction);
					this.m_ImitateUseHeroFavorabilityExpItemInt32Int32Int32GoodsType_hotfix = (luaObj.RawGet("ImitateUseHeroFavorabilityExpItem") as LuaFunction);
					this.m_AutoEquipmentInt32List`1_hotfix = (luaObj.RawGet("AutoEquipment") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600716D RID: 29037 RVA: 0x001F8EE0 File Offset: 0x001F70E0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005509 RID: 21769
		[DoNotToLua]
		private HeroComponent.LuaExportHelper luaExportHelper;

		// Token: 0x0400550A RID: 21770
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400550B RID: 21771
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400550C RID: 21772
		private LuaFunction m_ctor_hotfix;

		// Token: 0x0400550D RID: 21773
		private LuaFunction m_Init_hotfix;

		// Token: 0x0400550E RID: 21774
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x0400550F RID: 21775
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04005510 RID: 21776
		private LuaFunction m_DeSerializeDSHeroNtf_hotfix;

		// Token: 0x04005511 RID: 21777
		private LuaFunction m_InteractHeroInt32Int32_hotfix;

		// Token: 0x04005512 RID: 21778
		private LuaFunction m_GetHeroInteractionInfoInt32_hotfix;

		// Token: 0x04005513 RID: 21779
		private LuaFunction m_GetHeroInteractHeroPerformanceIdInt32HeroInteractionResultType_hotfix;

		// Token: 0x04005514 RID: 21780
		private LuaFunction m_CanUnlockHeroPerformanceInt32_hotfix;

		// Token: 0x04005515 RID: 21781
		private LuaFunction m_CanUnlockHeroBiographyInt32_hotfix;

		// Token: 0x04005516 RID: 21782
		private LuaFunction m_GetDSVersion_hotfix;

		// Token: 0x04005517 RID: 21783
		private LuaFunction m_ClearInitedData_hotfix;

		// Token: 0x04005518 RID: 21784
		private LuaFunction m_GetWearedEquipmentHeroIdByEquipmentIdUInt64_hotfix;

		// Token: 0x04005519 RID: 21785
		private LuaFunction m_GetHeroInteractNums_hotfix;

		// Token: 0x0400551A RID: 21786
		private LuaFunction m_GetHeroInteractNumsFlushTime_hotfix;

		// Token: 0x0400551B RID: 21787
		private LuaFunction m_ImitateUseHeroFavorabilityExpItemInt32Int32Int32GoodsType_hotfix;

		// Token: 0x0400551C RID: 21788
		private LuaFunction m_AutoEquipmentInt32List;

		// Token: 0x020008BE RID: 2238
		public new class LuaExportHelper
		{
			// Token: 0x0600716E RID: 29038 RVA: 0x001F8F48 File Offset: 0x001F7148
			public LuaExportHelper(HeroComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600716F RID: 29039 RVA: 0x001F8F58 File Offset: 0x001F7158
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x06007170 RID: 29040 RVA: 0x001F8F68 File Offset: 0x001F7168
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x06007171 RID: 29041 RVA: 0x001F8F78 File Offset: 0x001F7178
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x06007172 RID: 29042 RVA: 0x001F8F88 File Offset: 0x001F7188
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x06007173 RID: 29043 RVA: 0x001F8F98 File Offset: 0x001F7198
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x06007174 RID: 29044 RVA: 0x001F8FA8 File Offset: 0x001F71A8
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x06007175 RID: 29045 RVA: 0x001F8FB8 File Offset: 0x001F71B8
			public int __callBase_GetProtagonistID()
			{
				return this.m_owner.__callBase_GetProtagonistID();
			}

			// Token: 0x06007176 RID: 29046 RVA: 0x001F8FC8 File Offset: 0x001F71C8
			public bool __callBase_IsProtagonistHero(int heroId)
			{
				return this.m_owner.__callBase_IsProtagonistHero(heroId);
			}

			// Token: 0x06007177 RID: 29047 RVA: 0x001F8FD8 File Offset: 0x001F71D8
			public bool __callBase_IsProtagonistExist()
			{
				return this.m_owner.__callBase_IsProtagonistExist();
			}

			// Token: 0x06007178 RID: 29048 RVA: 0x001F8FE8 File Offset: 0x001F71E8
			public int __callBase_SetProtagonist(int protagonistId)
			{
				return this.m_owner.__callBase_SetProtagonist(protagonistId);
			}

			// Token: 0x06007179 RID: 29049 RVA: 0x001F8FF8 File Offset: 0x001F71F8
			public List<Hero> __callBase_GetAllStarLvlMaxHeroes()
			{
				return this.m_owner.__callBase_GetAllStarLvlMaxHeroes();
			}

			// Token: 0x0600717A RID: 29050 RVA: 0x001F9008 File Offset: 0x001F7208
			public List<HeroFragmentBagItem> __callBase_GetAllStarLvlMaxHeroFragments()
			{
				return this.m_owner.__callBase_GetAllStarLvlMaxHeroFragments();
			}

			// Token: 0x0600717B RID: 29051 RVA: 0x001F9018 File Offset: 0x001F7218
			public void __callBase_InitHeroDataByCaculate(Hero hero)
			{
				this.m_owner.__callBase_InitHeroDataByCaculate(hero);
			}

			// Token: 0x0600717C RID: 29052 RVA: 0x001F9028 File Offset: 0x001F7228
			public int __callBase_CanHeroJobEquipSkill(int jobRelatedId, int skillId)
			{
				return this.m_owner.__callBase_CanHeroJobEquipSkill(jobRelatedId, skillId);
			}

			// Token: 0x0600717D RID: 29053 RVA: 0x001F9038 File Offset: 0x001F7238
			public int __callBase_CanSelectSkillHero(Hero hero, List<int> skills)
			{
				return this.m_owner.__callBase_CanSelectSkillHero(hero, skills);
			}

			// Token: 0x0600717E RID: 29054 RVA: 0x001F9048 File Offset: 0x001F7248
			public int __callBase_SelectSkills(int heroId, List<int> skills)
			{
				return this.m_owner.__callBase_SelectSkills(heroId, skills);
			}

			// Token: 0x0600717F RID: 29055 RVA: 0x001F9058 File Offset: 0x001F7258
			public int __callBase_SelectSoldier(int heroId, int soldierId)
			{
				return this.m_owner.__callBase_SelectSoldier(heroId, soldierId);
			}

			// Token: 0x06007180 RID: 29056 RVA: 0x001F9068 File Offset: 0x001F7268
			public int __callBase_CanHeroSelectSolider(Hero hero, int soliderId)
			{
				return this.m_owner.__callBase_CanHeroSelectSolider(hero, soliderId);
			}

			// Token: 0x06007181 RID: 29057 RVA: 0x001F9078 File Offset: 0x001F7278
			public int __callBase_RemoveHero(int heroId)
			{
				return this.m_owner.__callBase_RemoveHero(heroId);
			}

			// Token: 0x06007182 RID: 29058 RVA: 0x001F9088 File Offset: 0x001F7288
			public void __callBase_RemoveAllHero(List<int> changedHeroIdList)
			{
				this.m_owner.__callBase_RemoveAllHero(changedHeroIdList);
			}

			// Token: 0x06007183 RID: 29059 RVA: 0x001F9098 File Offset: 0x001F7298
			public void __callBase_RemoveAllHeros()
			{
				this.m_owner.__callBase_RemoveAllHeros();
			}

			// Token: 0x06007184 RID: 29060 RVA: 0x001F90A8 File Offset: 0x001F72A8
			public List<Hero> __callBase_GetAllHeros()
			{
				return this.m_owner.__callBase_GetAllHeros();
			}

			// Token: 0x06007185 RID: 29061 RVA: 0x001F90B8 File Offset: 0x001F72B8
			public HeroJob __callBase_FindHeroJob(Hero hero, int jobRelatedId)
			{
				return this.m_owner.__callBase_FindHeroJob(hero, jobRelatedId);
			}

			// Token: 0x06007186 RID: 29062 RVA: 0x001F90C8 File Offset: 0x001F72C8
			public bool __callBase_IsUnlockedHeroJob(Hero hero, int jobRelatedId)
			{
				return this.m_owner.__callBase_IsUnlockedHeroJob(hero, jobRelatedId);
			}

			// Token: 0x06007187 RID: 29063 RVA: 0x001F90D8 File Offset: 0x001F72D8
			public HeroJob __callBase_FindHeroJob(int heroId, int jobRelatedId)
			{
				return this.m_owner.__callBase_FindHeroJob(heroId, jobRelatedId);
			}

			// Token: 0x06007188 RID: 29064 RVA: 0x001F90E8 File Offset: 0x001F72E8
			public Hero __callBase_FindHero(int heroId)
			{
				return this.m_owner.__callBase_FindHero(heroId);
			}

			// Token: 0x06007189 RID: 29065 RVA: 0x001F90F8 File Offset: 0x001F72F8
			public int __callBase_AddHeroFightNums(int heroId, int nums)
			{
				return this.m_owner.__callBase_AddHeroFightNums(heroId, nums);
			}

			// Token: 0x0600718A RID: 29066 RVA: 0x001F9108 File Offset: 0x001F7308
			public int __callBase_AddHeroAllNeedJobsAchievements(int heroId, List<int> achievements)
			{
				return this.m_owner.__callBase_AddHeroAllNeedJobsAchievements(heroId, achievements);
			}

			// Token: 0x0600718B RID: 29067 RVA: 0x001F9118 File Offset: 0x001F7318
			public int __callBase_AddHero(int heroId)
			{
				return this.m_owner.__callBase_AddHero(heroId);
			}

			// Token: 0x0600718C RID: 29068 RVA: 0x001F9128 File Offset: 0x001F7328
			public bool __callBase_IsWastefulAddExp(Hero hero, int addExp)
			{
				return this.m_owner.__callBase_IsWastefulAddExp(hero, addExp);
			}

			// Token: 0x0600718D RID: 29069 RVA: 0x001F9138 File Offset: 0x001F7338
			public bool __callBase_IsCurrentLevelMaxHeroLevel(int heroLevel)
			{
				return this.m_owner.__callBase_IsCurrentLevelMaxHeroLevel(heroLevel);
			}

			// Token: 0x0600718E RID: 29070 RVA: 0x001F9148 File Offset: 0x001F7348
			public bool __callBase_IsFullCurrentHeroExp(Hero hero)
			{
				return this.m_owner.__callBase_IsFullCurrentHeroExp(hero);
			}

			// Token: 0x0600718F RID: 29071 RVA: 0x001F9158 File Offset: 0x001F7358
			public void __callBase_AddHeroesExp(List<int> heroIds, int exp)
			{
				this.m_owner.__callBase_AddHeroesExp(heroIds, exp);
			}

			// Token: 0x06007190 RID: 29072 RVA: 0x001F9168 File Offset: 0x001F7368
			public int __callBase_CanAddHeroExp(int heroId)
			{
				return this.m_owner.__callBase_CanAddHeroExp(heroId);
			}

			// Token: 0x06007191 RID: 29073 RVA: 0x001F9178 File Offset: 0x001F7378
			public int __callBase_AddHeroExp(int heroId, int exp)
			{
				return this.m_owner.__callBase_AddHeroExp(heroId, exp);
			}

			// Token: 0x06007192 RID: 29074 RVA: 0x001F9188 File Offset: 0x001F7388
			public void __callBase_OutPutHeroLevelUpOperateLog(int heroId, int currentLevel)
			{
				this.m_owner.__callBase_OutPutHeroLevelUpOperateLog(heroId, currentLevel);
			}

			// Token: 0x06007193 RID: 29075 RVA: 0x001F9198 File Offset: 0x001F7398
			public int __callBase_AddHeroExpByUseableBagItem(int heroId, GoodsType goodsTypeId, int contentId, int consumeNums)
			{
				return this.m_owner.__callBase_AddHeroExpByUseableBagItem(heroId, goodsTypeId, contentId, consumeNums);
			}

			// Token: 0x06007194 RID: 29076 RVA: 0x001F91AC File Offset: 0x001F73AC
			public int __callBase_ComposeHero(int heroId)
			{
				return this.m_owner.__callBase_ComposeHero(heroId);
			}

			// Token: 0x06007195 RID: 29077 RVA: 0x001F91BC File Offset: 0x001F73BC
			public bool __callBase_IsLvlMaxHeroStar(Hero hero)
			{
				return this.m_owner.__callBase_IsLvlMaxHeroStar(hero);
			}

			// Token: 0x06007196 RID: 29078 RVA: 0x001F91CC File Offset: 0x001F73CC
			public int __callBase_LevelUpHeroStarLevel(int heroId)
			{
				return this.m_owner.__callBase_LevelUpHeroStarLevel(heroId);
			}

			// Token: 0x06007197 RID: 29079 RVA: 0x001F91DC File Offset: 0x001F73DC
			public void __callBase_OutPutHeroUpgradeOperateLog(int heroId, int currentStar, List<Goods> costItems)
			{
				this.m_owner.__callBase_OutPutHeroUpgradeOperateLog(heroId, currentStar, costItems);
			}

			// Token: 0x06007198 RID: 29080 RVA: 0x001F91EC File Offset: 0x001F73EC
			public HashSet<int> __callBase_GetGainHeroIds()
			{
				return this.m_owner.__callBase_GetGainHeroIds();
			}

			// Token: 0x06007199 RID: 29081 RVA: 0x001F91FC File Offset: 0x001F73FC
			public bool __callBase_HasGainHero(int heroId)
			{
				return this.m_owner.__callBase_HasGainHero(heroId);
			}

			// Token: 0x0600719A RID: 29082 RVA: 0x001F920C File Offset: 0x001F740C
			public bool __callBase_IsExistSkillId(int skillId)
			{
				return this.m_owner.__callBase_IsExistSkillId(skillId);
			}

			// Token: 0x0600719B RID: 29083 RVA: 0x001F921C File Offset: 0x001F741C
			public bool __callBase_IsExistSoliderId(int soliderId)
			{
				return this.m_owner.__callBase_IsExistSoliderId(soliderId);
			}

			// Token: 0x0600719C RID: 29084 RVA: 0x001F922C File Offset: 0x001F742C
			public LinkedList<Hero> __callBase_FindTopLevelHeroes(int topNums)
			{
				return this.m_owner.__callBase_FindTopLevelHeroes(topNums);
			}

			// Token: 0x0600719D RID: 29085 RVA: 0x001F923C File Offset: 0x001F743C
			public int __callBase_GetActiveHeroJobRelatedIdByHeroId(int heroId)
			{
				return this.m_owner.__callBase_GetActiveHeroJobRelatedIdByHeroId(heroId);
			}

			// Token: 0x0600719E RID: 29086 RVA: 0x001F924C File Offset: 0x001F744C
			public int __callBase_GmResetHeroJob(int heroId)
			{
				return this.m_owner.__callBase_GmResetHeroJob(heroId);
			}

			// Token: 0x0600719F RID: 29087 RVA: 0x001F925C File Offset: 0x001F745C
			public void __callBase_OnHeroLevelUp(int oldLevel, Hero hero)
			{
				this.m_owner.__callBase_OnHeroLevelUp(oldLevel, hero);
			}

			// Token: 0x060071A0 RID: 29088 RVA: 0x001F926C File Offset: 0x001F746C
			public int __callBase_GetAdditiveHeroAddExp(int addExp)
			{
				return this.m_owner.__callBase_GetAdditiveHeroAddExp(addExp);
			}

			// Token: 0x060071A1 RID: 29089 RVA: 0x001F927C File Offset: 0x001F747C
			public int __callBase_GetAdditiveHeroFavourabilityAddExp(int addExp)
			{
				return this.m_owner.__callBase_GetAdditiveHeroFavourabilityAddExp(addExp);
			}

			// Token: 0x060071A2 RID: 29090 RVA: 0x001F928C File Offset: 0x001F748C
			public void __callBase_AddHeroJobAchievementsAfterBattleLevelEnd(List<int> relatedAchievements, List<int> fightHeroes)
			{
				this.m_owner.__callBase_AddHeroJobAchievementsAfterBattleLevelEnd(relatedAchievements, fightHeroes);
			}

			// Token: 0x060071A3 RID: 29091 RVA: 0x001F929C File Offset: 0x001F749C
			public bool __callBase_IsJobLevelMax(ConfigDataJobConnectionInfo jobConnectionInfo, int jobLevel)
			{
				return this.m_owner.__callBase_IsJobLevelMax(jobConnectionInfo, jobLevel);
			}

			// Token: 0x060071A4 RID: 29092 RVA: 0x001F92AC File Offset: 0x001F74AC
			public bool __callBase_IsJobLevelMax(HeroJob job)
			{
				return this.m_owner.__callBase_IsJobLevelMax(job);
			}

			// Token: 0x060071A5 RID: 29093 RVA: 0x001F92BC File Offset: 0x001F74BC
			public int __callBase_CanLevelUpHeroJobLevel(int heroId, int jobRelatedId)
			{
				return this.m_owner.__callBase_CanLevelUpHeroJobLevel(heroId, jobRelatedId);
			}

			// Token: 0x060071A6 RID: 29094 RVA: 0x001F92CC File Offset: 0x001F74CC
			public int __callBase_CanTransferHeroJob(int heroId, int jobRelatedId)
			{
				return this.m_owner.__callBase_CanTransferHeroJob(heroId, jobRelatedId);
			}

			// Token: 0x060071A7 RID: 29095 RVA: 0x001F92DC File Offset: 0x001F74DC
			public int __callBase_TransferHeroJob(int heroId, int jobRelatedId)
			{
				return this.m_owner.__callBase_TransferHeroJob(heroId, jobRelatedId);
			}

			// Token: 0x060071A8 RID: 29096 RVA: 0x001F92EC File Offset: 0x001F74EC
			public void __callBase_OutPutHeroJobChangeOperateLog(int heroId, int preJobConnectionId, int postJobConnectionId, List<Goods> costItems)
			{
				this.m_owner.__callBase_OutPutHeroJobChangeOperateLog(heroId, preJobConnectionId, postJobConnectionId, costItems);
			}

			// Token: 0x060071A9 RID: 29097 RVA: 0x001F9300 File Offset: 0x001F7500
			public bool __callBase_IsNeedUnlock(ConfigDataJobConnectionInfo jobConnectionInfo)
			{
				return this.m_owner.__callBase_IsNeedUnlock(jobConnectionInfo);
			}

			// Token: 0x060071AA RID: 29098 RVA: 0x001F9310 File Offset: 0x001F7510
			public int __callBase_UnlockedHeroJob(int heroId, int jobRelatedId)
			{
				return this.m_owner.__callBase_UnlockedHeroJob(heroId, jobRelatedId);
			}

			// Token: 0x060071AB RID: 29099 RVA: 0x001F9320 File Offset: 0x001F7520
			public void __callBase_OutPutHeroJobUnlockOperateLog(int heroId, int activeJobId, int unlockJobId, List<Goods> costItems)
			{
				this.m_owner.__callBase_OutPutHeroJobUnlockOperateLog(heroId, activeJobId, unlockJobId, costItems);
			}

			// Token: 0x060071AC RID: 29100 RVA: 0x001F9334 File Offset: 0x001F7534
			public int __callBase_LevelUpHeroJobLevel(int heroId, int jobRelatedId)
			{
				return this.m_owner.__callBase_LevelUpHeroJobLevel(heroId, jobRelatedId);
			}

			// Token: 0x060071AD RID: 29101 RVA: 0x001F9344 File Offset: 0x001F7544
			public void __callBase_OutPutHeroJobLevelUpOperateLog(int heroId, int activeJobId, int currentLevel, List<Goods> costItems)
			{
				this.m_owner.__callBase_OutPutHeroJobLevelUpOperateLog(heroId, activeJobId, currentLevel, costItems);
			}

			// Token: 0x060071AE RID: 29102 RVA: 0x001F9358 File Offset: 0x001F7558
			public void __callBase_AddSoldier(Hero hero, int soldierId, bool needExchange)
			{
				this.m_owner.__callBase_AddSoldier(hero, soldierId, needExchange);
			}

			// Token: 0x060071AF RID: 29103 RVA: 0x001F9368 File Offset: 0x001F7568
			public int __callBase_AutoTakeOffEquipments(int heroId)
			{
				return this.m_owner.__callBase_AutoTakeOffEquipments(heroId);
			}

			// Token: 0x060071B0 RID: 29104 RVA: 0x001F9378 File Offset: 0x001F7578
			public void __callBase_InitWearedEquipments()
			{
				this.m_owner.__callBase_InitWearedEquipments();
			}

			// Token: 0x060071B1 RID: 29105 RVA: 0x001F9388 File Offset: 0x001F7588
			public int __callBase_CanWearEquipment(int heroId, ulong instanceId)
			{
				return this.m_owner.__callBase_CanWearEquipment(heroId, instanceId);
			}

			// Token: 0x060071B2 RID: 29106 RVA: 0x001F9398 File Offset: 0x001F7598
			public int __callBase_CanWearEquipmentByJobAndArmy(Hero hero, BagItemBase equipment)
			{
				return this.m_owner.__callBase_CanWearEquipmentByJobAndArmy(hero, equipment);
			}

			// Token: 0x060071B3 RID: 29107 RVA: 0x001F93A8 File Offset: 0x001F75A8
			public bool __callBase_IsEquipmentWeared(ulong instanceId)
			{
				return this.m_owner.__callBase_IsEquipmentWeared(instanceId);
			}

			// Token: 0x060071B4 RID: 29108 RVA: 0x001F93B8 File Offset: 0x001F75B8
			public Hero __callBase_GetWearedEquipmentHero(ulong instanceId)
			{
				return this.m_owner.__callBase_GetWearedEquipmentHero(instanceId);
			}

			// Token: 0x060071B5 RID: 29109 RVA: 0x001F93C8 File Offset: 0x001F75C8
			public int __callBase_WearEquipment(int heroId, ulong instanceId)
			{
				return this.m_owner.__callBase_WearEquipment(heroId, instanceId);
			}

			// Token: 0x060071B6 RID: 29110 RVA: 0x001F93D8 File Offset: 0x001F75D8
			public void __callBase_WearEquipmentBySlot(Hero hero, int slot, ulong instanceId)
			{
				this.m_owner.__callBase_WearEquipmentBySlot(hero, slot, instanceId);
			}

			// Token: 0x060071B7 RID: 29111 RVA: 0x001F93E8 File Offset: 0x001F75E8
			public int __callBase_CanTakeOffEquipment(int heroId, int slot)
			{
				return this.m_owner.__callBase_CanTakeOffEquipment(heroId, slot);
			}

			// Token: 0x060071B8 RID: 29112 RVA: 0x001F93F8 File Offset: 0x001F75F8
			public int __callBase_TakeOffEquipment(int heroId, int slot)
			{
				return this.m_owner.__callBase_TakeOffEquipment(heroId, slot);
			}

			// Token: 0x060071B9 RID: 29113 RVA: 0x001F9408 File Offset: 0x001F7608
			public bool __callBase_HasBetterEquipmentByHero(int heroId)
			{
				return this.m_owner.__callBase_HasBetterEquipmentByHero(heroId);
			}

			// Token: 0x060071BA RID: 29114 RVA: 0x001F9418 File Offset: 0x001F7618
			public bool __callBase_HasBetterEquipmentBySlotId(int heroId, int slotId)
			{
				return this.m_owner.__callBase_HasBetterEquipmentBySlotId(heroId, slotId);
			}

			// Token: 0x060071BB RID: 29115 RVA: 0x001F9428 File Offset: 0x001F7628
			public BagItemBase __callBase_GetWearedEquipmentBySlotId(Hero hero, int slotId)
			{
				return this.m_owner.__callBase_GetWearedEquipmentBySlotId(hero, slotId);
			}

			// Token: 0x060071BC RID: 29116 RVA: 0x001F9438 File Offset: 0x001F7638
			public bool __callBase_IsBetterEquipment(BagItemBase wearedEquipment, BagItemBase compareEquipment, int slotId)
			{
				return this.m_owner.__callBase_IsBetterEquipment(wearedEquipment, compareEquipment, slotId);
			}

			// Token: 0x060071BD RID: 29117 RVA: 0x001F9448 File Offset: 0x001F7648
			public int __callBase_CanAutoEquipmentByClient(int heroId)
			{
				return this.m_owner.__callBase_CanAutoEquipmentByClient(heroId);
			}

			// Token: 0x060071BE RID: 29118 RVA: 0x001F9458 File Offset: 0x001F7658
			public int __callBase_CanAutoEquipment(int heroId)
			{
				return this.m_owner.__callBase_CanAutoEquipment(heroId);
			}

			// Token: 0x060071BF RID: 29119 RVA: 0x001F9468 File Offset: 0x001F7668
			public int __callBase_CanWearCharSkin(int heroId, int charSkinId)
			{
				return this.m_owner.__callBase_CanWearCharSkin(heroId, charSkinId);
			}

			// Token: 0x060071C0 RID: 29120 RVA: 0x001F9478 File Offset: 0x001F7678
			public int __callBase_WearCharSkin(int heroId, int charSkinId)
			{
				return this.m_owner.__callBase_WearCharSkin(heroId, charSkinId);
			}

			// Token: 0x060071C1 RID: 29121 RVA: 0x001F9488 File Offset: 0x001F7688
			public int __callBase_CanTakeOffCharSkin(int heroId)
			{
				return this.m_owner.__callBase_CanTakeOffCharSkin(heroId);
			}

			// Token: 0x060071C2 RID: 29122 RVA: 0x001F9498 File Offset: 0x001F7698
			public int __callBase_TakeOffCharSkin(int heroId)
			{
				return this.m_owner.__callBase_TakeOffCharSkin(heroId);
			}

			// Token: 0x060071C3 RID: 29123 RVA: 0x001F94A8 File Offset: 0x001F76A8
			public int __callBase_CanWearModelSkin(int heroId, int jobRelatedId, int modelSkinId)
			{
				return this.m_owner.__callBase_CanWearModelSkin(heroId, jobRelatedId, modelSkinId);
			}

			// Token: 0x060071C4 RID: 29124 RVA: 0x001F94B8 File Offset: 0x001F76B8
			public int __callBase_WearModelSkin(int heroId, int jobRelatedId, int modelSkinId)
			{
				return this.m_owner.__callBase_WearModelSkin(heroId, jobRelatedId, modelSkinId);
			}

			// Token: 0x060071C5 RID: 29125 RVA: 0x001F94C8 File Offset: 0x001F76C8
			public int __callBase_CanTakeOffModelSkin(int heroId, int jobRelatedId)
			{
				return this.m_owner.__callBase_CanTakeOffModelSkin(heroId, jobRelatedId);
			}

			// Token: 0x060071C6 RID: 29126 RVA: 0x001F94D8 File Offset: 0x001F76D8
			public int __callBase_TakeOffModelSkin(int heroId, int jobRelatedId)
			{
				return this.m_owner.__callBase_TakeOffModelSkin(heroId, jobRelatedId);
			}

			// Token: 0x060071C7 RID: 29127 RVA: 0x001F94E8 File Offset: 0x001F76E8
			public int __callBase_CanWearSoldierSkin(int heroId, int soldierId, int soldierSkinId)
			{
				return this.m_owner.__callBase_CanWearSoldierSkin(heroId, soldierId, soldierSkinId);
			}

			// Token: 0x060071C8 RID: 29128 RVA: 0x001F94F8 File Offset: 0x001F76F8
			public int __callBase_WearSoldierSkin(int heroId, int soldierId, int soldierSkinId, bool applyToAll)
			{
				return this.m_owner.__callBase_WearSoldierSkin(heroId, soldierId, soldierSkinId, applyToAll);
			}

			// Token: 0x060071C9 RID: 29129 RVA: 0x001F950C File Offset: 0x001F770C
			public int __callBase_CanTakeOffSoldierSkin(int heroId, int soldierId)
			{
				return this.m_owner.__callBase_CanTakeOffSoldierSkin(heroId, soldierId);
			}

			// Token: 0x060071CA RID: 29130 RVA: 0x001F951C File Offset: 0x001F771C
			public int __callBase_TakeOffSoldierSkin(int heroId, int soldierId, bool applyToAll)
			{
				return this.m_owner.__callBase_TakeOffSoldierSkin(heroId, soldierId, applyToAll);
			}

			// Token: 0x060071CB RID: 29131 RVA: 0x001F952C File Offset: 0x001F772C
			public void __callBase_TakeOffSoldierSkinApplyToAll(int soldierId, int skinId)
			{
				this.m_owner.__callBase_TakeOffSoldierSkinApplyToAll(soldierId, skinId);
			}

			// Token: 0x060071CC RID: 29132 RVA: 0x001F953C File Offset: 0x001F773C
			public int __callBase_AddHeroFavorabilityExpByUseableBagItem(int heroId, GoodsType goodsTypeId, int contentId, int consumeNums)
			{
				return this.m_owner.__callBase_AddHeroFavorabilityExpByUseableBagItem(heroId, goodsTypeId, contentId, consumeNums);
			}

			// Token: 0x060071CD RID: 29133 RVA: 0x001F9550 File Offset: 0x001F7750
			public int __callBase_AddHeroFavorabilityLevel(int heroId, int addExp)
			{
				return this.m_owner.__callBase_AddHeroFavorabilityLevel(heroId, addExp);
			}

			// Token: 0x060071CE RID: 29134 RVA: 0x001F9560 File Offset: 0x001F7760
			public void __callBase_OutPutHeroFavourabilityOperateLog(int heroId, int oldLvl, int oldExp, int newLvl, int newExp, List<Goods> rewards)
			{
				this.m_owner.__callBase_OutPutHeroFavourabilityOperateLog(heroId, oldLvl, oldExp, newLvl, newExp, rewards);
			}

			// Token: 0x060071CF RID: 29135 RVA: 0x001F9578 File Offset: 0x001F7778
			public void __callBase_GenerateFavorabilityLevelUpReward(int heroId, int dropId)
			{
				this.m_owner.__callBase_GenerateFavorabilityLevelUpReward(heroId, dropId);
			}

			// Token: 0x060071D0 RID: 29136 RVA: 0x001F9588 File Offset: 0x001F7788
			public bool __callBase_IsFullFavorabilityExp(Hero hero, ConfigDataHeroInformationInfo heroInformationInfo)
			{
				return this.m_owner.__callBase_IsFullFavorabilityExp(hero, heroInformationInfo);
			}

			// Token: 0x060071D1 RID: 29137 RVA: 0x001F9598 File Offset: 0x001F7798
			public void __callBase_UpdateProtagonistHeroFavorabilityLevel()
			{
				this.m_owner.__callBase_UpdateProtagonistHeroFavorabilityLevel();
			}

			// Token: 0x060071D2 RID: 29138 RVA: 0x001F95A8 File Offset: 0x001F77A8
			public int __callBase_CanUnlockHeroFetter(int heroId, int fetterId)
			{
				return this.m_owner.__callBase_CanUnlockHeroFetter(heroId, fetterId);
			}

			// Token: 0x060071D3 RID: 29139 RVA: 0x001F95B8 File Offset: 0x001F77B8
			public int __callBase_CanReachFetterUnlockCondition(HeroFetterCompletionCondition condition)
			{
				return this.m_owner.__callBase_CanReachFetterUnlockCondition(condition);
			}

			// Token: 0x060071D4 RID: 29140 RVA: 0x001F95C8 File Offset: 0x001F77C8
			public int __callBase_GmLevelUpHeroFetter2SpecificLevel(int heroId, int fetterId, int reachLevel)
			{
				return this.m_owner.__callBase_GmLevelUpHeroFetter2SpecificLevel(heroId, fetterId, reachLevel);
			}

			// Token: 0x060071D5 RID: 29141 RVA: 0x001F95D8 File Offset: 0x001F77D8
			public int __callBase_CanLevelUpHeroFetter(int heroId, int fetterId)
			{
				return this.m_owner.__callBase_CanLevelUpHeroFetter(heroId, fetterId);
			}

			// Token: 0x060071D6 RID: 29142 RVA: 0x001F95E8 File Offset: 0x001F77E8
			public int __callBase_LevelUpHeroFetter(int heroId, int fetterId)
			{
				return this.m_owner.__callBase_LevelUpHeroFetter(heroId, fetterId);
			}

			// Token: 0x060071D7 RID: 29143 RVA: 0x001F95F8 File Offset: 0x001F77F8
			public void __callBase_LevelUpHeroFetterCallBack(Hero hero, int fetterId)
			{
				this.m_owner.__callBase_LevelUpHeroFetterCallBack(hero, fetterId);
			}

			// Token: 0x060071D8 RID: 29144 RVA: 0x001F9608 File Offset: 0x001F7808
			public void __callBase_OutPutHeroFetterOpereateLog(int heroId, int fetterId, int currentLvl, List<Goods> itemCost, List<Goods> rewards)
			{
				this.m_owner.__callBase_OutPutHeroFetterOpereateLog(heroId, fetterId, currentLvl, itemCost, rewards);
			}

			// Token: 0x060071D9 RID: 29145 RVA: 0x001F961C File Offset: 0x001F781C
			public int __callBase_UnlockHeroFetter(int heroId, int fetterId, bool check)
			{
				return this.m_owner.__callBase_UnlockHeroFetter(heroId, fetterId, check);
			}

			// Token: 0x060071DA RID: 29146 RVA: 0x001F962C File Offset: 0x001F782C
			public void __callBase_GenerateFetterUnlockRewards(int heroId, int fetterId)
			{
				this.m_owner.__callBase_GenerateFetterUnlockRewards(heroId, fetterId);
			}

			// Token: 0x060071DB RID: 29147 RVA: 0x001F963C File Offset: 0x001F783C
			public int __callBase_ConfessHero(int heroId, bool check)
			{
				return this.m_owner.__callBase_ConfessHero(heroId, check);
			}

			// Token: 0x060071DC RID: 29148 RVA: 0x001F964C File Offset: 0x001F784C
			public void __callBase_GenerateConfessionRewards(int herId, ConfigDataHeroConfessionInfo confessionInfo)
			{
				this.m_owner.__callBase_GenerateConfessionRewards(herId, confessionInfo);
			}

			// Token: 0x060071DD RID: 29149 RVA: 0x001F965C File Offset: 0x001F785C
			public int __callBase_CanConfessHero(int heroId)
			{
				return this.m_owner.__callBase_CanConfessHero(heroId);
			}

			// Token: 0x060071DE RID: 29150 RVA: 0x001F966C File Offset: 0x001F786C
			public void __callBase_InitHeroInteractNums()
			{
				this.m_owner.__callBase_InitHeroInteractNums();
			}

			// Token: 0x060071DF RID: 29151 RVA: 0x001F967C File Offset: 0x001F787C
			public void __callBase_AddHeroInteractNums(int addNums, bool recoveryByTime)
			{
				this.m_owner.__callBase_AddHeroInteractNums(addNums, recoveryByTime);
			}

			// Token: 0x060071E0 RID: 29152 RVA: 0x001F968C File Offset: 0x001F788C
			public int __callBase_CanInteractHero(int heroId)
			{
				return this.m_owner.__callBase_CanInteractHero(heroId);
			}

			// Token: 0x060071E1 RID: 29153 RVA: 0x001F969C File Offset: 0x001F789C
			public int __callBase_GetHeroFavorabilityUpLevel(Hero hero, ConfigDataHeroInformationInfo heroInformationInfo, int addExp)
			{
				return this.m_owner.__callBase_GetHeroFavorabilityUpLevel(hero, heroInformationInfo, addExp);
			}

			// Token: 0x060071E2 RID: 29154 RVA: 0x001F96AC File Offset: 0x001F78AC
			public int __callBase_GetHeroInteractId(Hero hero, ConfigDataHeroInformationInfo heroInformationInfo)
			{
				return this.m_owner.__callBase_GetHeroInteractId(hero, heroInformationInfo);
			}

			// Token: 0x060071E3 RID: 29155 RVA: 0x001F96BC File Offset: 0x001F78BC
			public int __callBase_GetAllHeroBattlePower()
			{
				return this.m_owner.__callBase_GetAllHeroBattlePower();
			}

			// Token: 0x060071E4 RID: 29156 RVA: 0x001F96CC File Offset: 0x001F78CC
			public int __callBase_GetLastAllHeroRank()
			{
				return this.m_owner.__callBase_GetLastAllHeroRank();
			}

			// Token: 0x060071E5 RID: 29157 RVA: 0x001F96DC File Offset: 0x001F78DC
			public int __callBase_GetTopHeroBattlePower()
			{
				return this.m_owner.__callBase_GetTopHeroBattlePower();
			}

			// Token: 0x060071E6 RID: 29158 RVA: 0x001F96EC File Offset: 0x001F78EC
			public int __callBase_GetLastTopHeroRank()
			{
				return this.m_owner.__callBase_GetLastTopHeroRank();
			}

			// Token: 0x060071E7 RID: 29159 RVA: 0x001F96FC File Offset: 0x001F78FC
			public int __callBase_GetChampionHeroBattlePower()
			{
				return this.m_owner.__callBase_GetChampionHeroBattlePower();
			}

			// Token: 0x060071E8 RID: 29160 RVA: 0x001F970C File Offset: 0x001F790C
			public int __callBase_GetChampionHeroId()
			{
				return this.m_owner.__callBase_GetChampionHeroId();
			}

			// Token: 0x060071E9 RID: 29161 RVA: 0x001F971C File Offset: 0x001F791C
			public int __callBase_GetLastChampionHeroRank()
			{
				return this.m_owner.__callBase_GetLastChampionHeroRank();
			}

			// Token: 0x060071EA RID: 29162 RVA: 0x001F972C File Offset: 0x001F792C
			public bool __callBase_ComputeBattlePower(Hero hero)
			{
				return this.m_owner.__callBase_ComputeBattlePower(hero);
			}

			// Token: 0x060071EB RID: 29163 RVA: 0x001F973C File Offset: 0x001F793C
			public void __callBase_OnHeroBattlePowerChange(Hero hero)
			{
				this.m_owner.__callBase_OnHeroBattlePowerChange(hero);
			}

			// Token: 0x060071EC RID: 29164 RVA: 0x001F974C File Offset: 0x001F794C
			public int __callBase_CanComposeHero(int heroId)
			{
				return this.m_owner.__callBase_CanComposeHero(heroId);
			}

			// Token: 0x060071ED RID: 29165 RVA: 0x001F975C File Offset: 0x001F795C
			public int __callBase_CanLevelUpHeroStarLevel(int heroId)
			{
				return this.m_owner.__callBase_CanLevelUpHeroStarLevel(heroId);
			}

			// Token: 0x060071EE RID: 29166 RVA: 0x001F976C File Offset: 0x001F796C
			public List<ulong> __callBase_GetEquipedEquipments()
			{
				return this.m_owner.__callBase_GetEquipedEquipments();
			}

			// Token: 0x060071EF RID: 29167 RVA: 0x001F977C File Offset: 0x001F797C
			public int __callBase_GetSkillEnergyFromConfig(int heroLevel)
			{
				return this.m_owner.__callBase_GetSkillEnergyFromConfig(heroLevel);
			}

			// Token: 0x060071F0 RID: 29168 RVA: 0x001F978C File Offset: 0x001F798C
			public void ClearInitedData()
			{
				this.m_owner.ClearInitedData();
			}

			// Token: 0x0400551D RID: 21789
			private HeroComponent m_owner;
		}
	}
}
