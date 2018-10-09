using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000363 RID: 867
	[HotFix]
	public class BattleHero
	{
		// Token: 0x06003174 RID: 12660 RVA: 0x000C1814 File Offset: 0x000BFA14
		public BattleHero()
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

		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x06003176 RID: 12662 RVA: 0x000C1928 File Offset: 0x000BFB28
		// (set) Token: 0x06003175 RID: 12661 RVA: 0x000C18A8 File Offset: 0x000BFAA8
		public int HeroId
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_HeroId_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_HeroId_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_heroId;
			}
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_HeroIdInt32_hotfix != null)
				{
					this.m_set_HeroIdInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.m_heroId = value;
				this.UpdateHeroInfo();
			}
		}

		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x06003177 RID: 12663 RVA: 0x000C199C File Offset: 0x000BFB9C
		// (set) Token: 0x06003178 RID: 12664 RVA: 0x000C1A10 File Offset: 0x000BFC10
		public int ActionPositionIndex
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_ActionPositionIndex_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_ActionPositionIndex_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<ActionPositionIndex>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_ActionPositionIndexInt32_hotfix != null)
				{
					this.m_set_ActionPositionIndexInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<ActionPositionIndex>k__BackingField = value;
			}
		}

		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x06003179 RID: 12665 RVA: 0x000C1A88 File Offset: 0x000BFC88
		// (set) Token: 0x0600317A RID: 12666 RVA: 0x000C1AFC File Offset: 0x000BFCFC
		public int ActionValue
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_ActionValue_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_ActionValue_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<ActionValue>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_ActionValueInt32_hotfix != null)
				{
					this.m_set_ActionValueInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<ActionValue>k__BackingField = value;
			}
		}

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x0600317B RID: 12667 RVA: 0x000C1B74 File Offset: 0x000BFD74
		// (set) Token: 0x0600317C RID: 12668 RVA: 0x000C1BE8 File Offset: 0x000BFDE8
		public int Level
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Level_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_Level_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Level>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_LevelInt32_hotfix != null)
				{
					this.m_set_LevelInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Level>k__BackingField = value;
			}
		}

		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x0600317D RID: 12669 RVA: 0x000C1C60 File Offset: 0x000BFE60
		// (set) Token: 0x0600317E RID: 12670 RVA: 0x000C1CD4 File Offset: 0x000BFED4
		public int StarLevel
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_StarLevel_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_StarLevel_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<StarLevel>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_StarLevelInt32_hotfix != null)
				{
					this.m_set_StarLevelInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<StarLevel>k__BackingField = value;
			}
		}

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x0600317F RID: 12671 RVA: 0x000C1D4C File Offset: 0x000BFF4C
		// (set) Token: 0x06003180 RID: 12672 RVA: 0x000C1DC0 File Offset: 0x000BFFC0
		public int ActiveHeroJobRelatedId
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_ActiveHeroJobRelatedId_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_ActiveHeroJobRelatedId_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<ActiveHeroJobRelatedId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_ActiveHeroJobRelatedIdInt32_hotfix != null)
				{
					this.m_set_ActiveHeroJobRelatedIdInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<ActiveHeroJobRelatedId>k__BackingField = value;
			}
		}

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x06003181 RID: 12673 RVA: 0x000C1E38 File Offset: 0x000C0038
		// (set) Token: 0x06003182 RID: 12674 RVA: 0x000C1EAC File Offset: 0x000C00AC
		public int ModelSkinId
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_ModelSkinId_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_ModelSkinId_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<ModelSkinId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_ModelSkinIdInt32_hotfix != null)
				{
					this.m_set_ModelSkinIdInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<ModelSkinId>k__BackingField = value;
			}
		}

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x06003183 RID: 12675 RVA: 0x000C1F24 File Offset: 0x000C0124
		// (set) Token: 0x06003184 RID: 12676 RVA: 0x000C1F98 File Offset: 0x000C0198
		public int CharSkinId
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_CharSkinId_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_CharSkinId_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<CharSkinId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_CharSkinIdInt32_hotfix != null)
				{
					this.m_set_CharSkinIdInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<CharSkinId>k__BackingField = value;
			}
		}

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x06003185 RID: 12677 RVA: 0x000C2010 File Offset: 0x000C0210
		// (set) Token: 0x06003186 RID: 12678 RVA: 0x000C2084 File Offset: 0x000C0284
		public int SelectedSoldierSkinId
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_SelectedSoldierSkinId_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_SelectedSoldierSkinId_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<SelectedSoldierSkinId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_SelectedSoldierSkinIdInt32_hotfix != null)
				{
					this.m_set_SelectedSoldierSkinIdInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<SelectedSoldierSkinId>k__BackingField = value;
			}
		}

		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x06003188 RID: 12680 RVA: 0x000C217C File Offset: 0x000C037C
		// (set) Token: 0x06003187 RID: 12679 RVA: 0x000C20FC File Offset: 0x000C02FC
		public int SelectedSoldierId
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_SelectedSoldierId_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_SelectedSoldierId_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_selectedSoldierId;
			}
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_SelectedSoldierIdInt32_hotfix != null)
				{
					this.m_set_SelectedSoldierIdInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.m_selectedSoldierId = value;
				this.UpdateSoldierInfo();
			}
		}

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x06003189 RID: 12681 RVA: 0x000C21F0 File Offset: 0x000C03F0
		// (set) Token: 0x0600318A RID: 12682 RVA: 0x000C2264 File Offset: 0x000C0464
		public int Power
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Power_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_Power_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Power>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_PowerInt32_hotfix != null)
				{
					this.m_set_PowerInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Power>k__BackingField = value;
			}
		}

		// Token: 0x0600318B RID: 12683 RVA: 0x000C22DC File Offset: 0x000C04DC
		public BattleHeroJob GetJob(int jobRelatedId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetJobInt32_hotfix != null)
			{
				return (BattleHeroJob)this.m_GetJobInt32_hotfix.call(new object[]
				{
					this,
					jobRelatedId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleHeroJob battleHeroJob in this.Jobs)
			{
				if (battleHeroJob.JobRelatedId == jobRelatedId)
				{
					return battleHeroJob;
				}
			}
			return null;
		}

		// Token: 0x0600318C RID: 12684 RVA: 0x000C23B8 File Offset: 0x000C05B8
		public BattleHeroJob GetActiveJob()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetActiveJob_hotfix != null)
			{
				return (BattleHeroJob)this.m_GetActiveJob_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.GetJob(this.ActiveHeroJobRelatedId);
		}

		// Token: 0x0600318D RID: 12685 RVA: 0x000C2430 File Offset: 0x000C0630
		public ConfigDataCharImageSkinResourceInfo GetHeroCharImageSkinResourceInfo(IConfigDataLoader configDataLoader)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroCharImageSkinResourceInfoIConfigDataLoader_hotfix != null)
			{
				return (ConfigDataCharImageSkinResourceInfo)this.m_GetHeroCharImageSkinResourceInfoIConfigDataLoader_hotfix.call(new object[]
				{
					this,
					configDataLoader
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return BattleUtility.GetHeroCharImageSkinResourceInfo(configDataLoader, this.CharSkinId);
		}

		// Token: 0x0600318E RID: 12686 RVA: 0x000C24B8 File Offset: 0x000C06B8
		public ConfigDataModelSkinResourceInfo GetHeroActiveJobModelSkinResourceInfo(IConfigDataLoader configDataLoader)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroActiveJobModelSkinResourceInfoIConfigDataLoader_hotfix != null)
			{
				return (ConfigDataModelSkinResourceInfo)this.m_GetHeroActiveJobModelSkinResourceInfoIConfigDataLoader_hotfix.call(new object[]
				{
					this,
					configDataLoader
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return BattleUtility.GetHeroModelSkinResourceInfo(configDataLoader, this.ModelSkinId, this.ActiveHeroJobRelatedId);
		}

		// Token: 0x0600318F RID: 12687 RVA: 0x000C2548 File Offset: 0x000C0748
		public ConfigDataModelSkinResourceInfo GetSelectedSoldierModelSkinResourceInfo(IConfigDataLoader configDataLoader)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSelectedSoldierModelSkinResourceInfoIConfigDataLoader_hotfix != null)
			{
				return (ConfigDataModelSkinResourceInfo)this.m_GetSelectedSoldierModelSkinResourceInfoIConfigDataLoader_hotfix.call(new object[]
				{
					this,
					configDataLoader
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return BattleUtility.GetSoldierModelSkinResourceInfo(configDataLoader, this.SelectedSoldierSkinId, this.SelectedSoldierId);
		}

		// Token: 0x06003190 RID: 12688 RVA: 0x000C25D8 File Offset: 0x000C07D8
		public static BattleHero HeroToBattleHero(Hero hero)
		{
			BattleHero battleHero = new BattleHero();
			battleHero.HeroId = hero.HeroId;
			battleHero.ActionValue = hero.ActionValue;
			battleHero.ActionPositionIndex = hero.ActionPositionIndex;
			battleHero.Level = hero.Level;
			battleHero.StarLevel = hero.StarLevel;
			battleHero.SelectedSoldierId = hero.SelectedSoldierId;
			battleHero.SelectedSkillList.AddRange(hero.SelectedSkills);
			battleHero.ActiveHeroJobRelatedId = hero.ActiveHeroJobRelatedId;
			battleHero.Power = hero.BattlePower;
			HeroJob heroJob = hero.Jobs.Find((HeroJob m) => m.JobRelatedId == hero.ActiveHeroJobRelatedId);
			battleHero.ModelSkinId = heroJob.ModelSkinId;
			battleHero.CharSkinId = hero.CharSkinId;
			battleHero.SelectedSoldierSkinId = hero.GetSoldierSkinId(hero.SelectedSoldierId);
			foreach (HeroJob heroJob2 in hero.Jobs)
			{
				battleHero.Jobs.Add(BattleHeroJob.HeroJobToBattleHeroJob(heroJob2));
			}
			foreach (KeyValuePair<int, int> keyValuePair in hero.Fetters)
			{
				battleHero.Fetters.Add(keyValuePair.Key, keyValuePair.Value);
			}
			return battleHero;
		}

		// Token: 0x06003191 RID: 12689 RVA: 0x000C27B0 File Offset: 0x000C09B0
		public static BattleHero PBBattleHeroToBattleHero(ProBattleHero pbBattleHero)
		{
			BattleHero battleHero = new BattleHero();
			battleHero.HeroId = pbBattleHero.HeroId;
			battleHero.ActionValue = pbBattleHero.ActionValue;
			battleHero.ActionPositionIndex = pbBattleHero.ActionPositionIndex;
			battleHero.Level = pbBattleHero.Level;
			battleHero.StarLevel = pbBattleHero.StarLevel;
			battleHero.SelectedSoldierId = pbBattleHero.SelectedSoldierId;
			battleHero.SelectedSkillList.AddRange(pbBattleHero.SelectedSkillList);
			battleHero.ActiveHeroJobRelatedId = pbBattleHero.ActiveHeroJobRelatedId;
			battleHero.Power = pbBattleHero.Power;
			battleHero.ModelSkinId = pbBattleHero.ModelSkinId;
			battleHero.CharSkinId = pbBattleHero.CharSkinId;
			battleHero.SelectedSoldierSkinId = pbBattleHero.SelectedSoldierSkinId;
			foreach (ProBattleHeroJob pbBattleHeroJob in pbBattleHero.Jobs)
			{
				battleHero.Jobs.Add(BattleHeroJob.PBBattleHeroJobToBattleHeroJob(pbBattleHeroJob));
			}
			foreach (ProBattleHeroEquipment pbEquipment in pbBattleHero.Equipments)
			{
				battleHero.Equipments.Add(BattleHeroEquipment.PBBattleHeroEquipmentToBattleHeroEquipment(pbEquipment));
			}
			foreach (ProHeroFetter proHeroFetter in pbBattleHero.Fetters)
			{
				battleHero.Fetters.Add(proHeroFetter.FetterId, proHeroFetter.Level);
			}
			return battleHero;
		}

		// Token: 0x06003192 RID: 12690 RVA: 0x000C2968 File Offset: 0x000C0B68
		public static ProBattleHero BattleHeroToPBBattleHero(BattleHero battleHero)
		{
			ProBattleHero proBattleHero = new ProBattleHero();
			proBattleHero.HeroId = battleHero.HeroId;
			proBattleHero.ActionPositionIndex = battleHero.ActionPositionIndex;
			proBattleHero.Level = battleHero.Level;
			proBattleHero.StarLevel = battleHero.StarLevel;
			proBattleHero.ActionValue = battleHero.ActionValue;
			proBattleHero.SelectedSoldierId = battleHero.SelectedSoldierId;
			proBattleHero.SelectedSkillList.AddRange(battleHero.SelectedSkillList);
			proBattleHero.ActiveHeroJobRelatedId = battleHero.ActiveHeroJobRelatedId;
			proBattleHero.Power = battleHero.Power;
			proBattleHero.ModelSkinId = battleHero.ModelSkinId;
			proBattleHero.CharSkinId = battleHero.CharSkinId;
			proBattleHero.SelectedSoldierSkinId = battleHero.SelectedSoldierSkinId;
			foreach (BattleHeroJob battleHeroJob in battleHero.Jobs)
			{
				proBattleHero.Jobs.Add(BattleHeroJob.BattleHeroJobToPBBattleHeroJob(battleHeroJob));
			}
			foreach (BattleHeroEquipment equipment in battleHero.Equipments)
			{
				proBattleHero.Equipments.Add(BattleHeroEquipment.BattleHeroEquipmentToPBBattleHeroEquipment(equipment));
			}
			foreach (KeyValuePair<int, int> keyValuePair in battleHero.Fetters)
			{
				proBattleHero.Fetters.Add(new ProHeroFetter
				{
					FetterId = keyValuePair.Key,
					Level = keyValuePair.Value
				});
			}
			return proBattleHero;
		}

		// Token: 0x06003193 RID: 12691 RVA: 0x000C2B38 File Offset: 0x000C0D38
		public static ProBattleHero ViewBattleHeroToPBBattleHero(BattleHero battleHero)
		{
			return new ProBattleHero
			{
				HeroId = battleHero.HeroId,
				ActionPositionIndex = battleHero.ActionPositionIndex,
				ActiveHeroJobRelatedId = battleHero.ActiveHeroJobRelatedId,
				ModelSkinId = battleHero.ModelSkinId
			};
		}

		// Token: 0x06003194 RID: 12692 RVA: 0x000C2B7C File Offset: 0x000C0D7C
		public static BattleHero PBBattleHeroToViewBattleHero(ProBattleHero pbBattleHero)
		{
			return new BattleHero
			{
				HeroId = pbBattleHero.HeroId,
				ActionPositionIndex = pbBattleHero.ActionPositionIndex,
				ActiveHeroJobRelatedId = pbBattleHero.ActiveHeroJobRelatedId
			};
		}

		// Token: 0x06003195 RID: 12693 RVA: 0x000C2BB4 File Offset: 0x000C0DB4
		private void UpdateHeroInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateHeroInfo_hotfix != null)
			{
				this.m_UpdateHeroInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.HeroInfo = configDataLoader.GetConfigDataHeroInfo(this.HeroId);
		}

		// Token: 0x06003196 RID: 12694 RVA: 0x000C2C38 File Offset: 0x000C0E38
		private void UpdateSoldierInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateSoldierInfo_hotfix != null)
			{
				this.m_UpdateSoldierInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.SelectedSoldierInfo = configDataLoader.GetConfigDataSoldierInfo(this.SelectedSoldierId);
		}

		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x06003198 RID: 12696 RVA: 0x000C2D34 File Offset: 0x000C0F34
		// (set) Token: 0x06003197 RID: 12695 RVA: 0x000C2CBC File Offset: 0x000C0EBC
		public ConfigDataHeroInfo HeroInfo
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_HeroInfo_hotfix != null)
				{
					return (ConfigDataHeroInfo)this.m_get_HeroInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<HeroInfo>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_HeroInfoConfigDataHeroInfo_hotfix != null)
				{
					this.m_set_HeroInfoConfigDataHeroInfo_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<HeroInfo>k__BackingField = value;
			}
		}

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x0600319A RID: 12698 RVA: 0x000C2E20 File Offset: 0x000C1020
		// (set) Token: 0x06003199 RID: 12697 RVA: 0x000C2DA8 File Offset: 0x000C0FA8
		public ConfigDataSoldierInfo SelectedSoldierInfo
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_SelectedSoldierInfo_hotfix != null)
				{
					return (ConfigDataSoldierInfo)this.m_get_SelectedSoldierInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<SelectedSoldierInfo>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_SelectedSoldierInfoConfigDataSoldierInfo_hotfix != null)
				{
					this.m_set_SelectedSoldierInfoConfigDataSoldierInfo_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<SelectedSoldierInfo>k__BackingField = value;
			}
		}

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x0600319B RID: 12699 RVA: 0x000C2E94 File Offset: 0x000C1094
		// (set) Token: 0x0600319C RID: 12700 RVA: 0x000C2EB4 File Offset: 0x000C10B4
		[DoNotToLua]
		public BattleHero.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleHero.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600319D RID: 12701 RVA: 0x000C2EC0 File Offset: 0x000C10C0
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
					this.m_set_HeroIdInt32_hotfix = (luaObj.RawGet("set_HeroId") as LuaFunction);
					this.m_get_HeroId_hotfix = (luaObj.RawGet("get_HeroId") as LuaFunction);
					this.m_get_ActionPositionIndex_hotfix = (luaObj.RawGet("get_ActionPositionIndex") as LuaFunction);
					this.m_set_ActionPositionIndexInt32_hotfix = (luaObj.RawGet("set_ActionPositionIndex") as LuaFunction);
					this.m_get_ActionValue_hotfix = (luaObj.RawGet("get_ActionValue") as LuaFunction);
					this.m_set_ActionValueInt32_hotfix = (luaObj.RawGet("set_ActionValue") as LuaFunction);
					this.m_get_Level_hotfix = (luaObj.RawGet("get_Level") as LuaFunction);
					this.m_set_LevelInt32_hotfix = (luaObj.RawGet("set_Level") as LuaFunction);
					this.m_get_StarLevel_hotfix = (luaObj.RawGet("get_StarLevel") as LuaFunction);
					this.m_set_StarLevelInt32_hotfix = (luaObj.RawGet("set_StarLevel") as LuaFunction);
					this.m_get_ActiveHeroJobRelatedId_hotfix = (luaObj.RawGet("get_ActiveHeroJobRelatedId") as LuaFunction);
					this.m_set_ActiveHeroJobRelatedIdInt32_hotfix = (luaObj.RawGet("set_ActiveHeroJobRelatedId") as LuaFunction);
					this.m_get_ModelSkinId_hotfix = (luaObj.RawGet("get_ModelSkinId") as LuaFunction);
					this.m_set_ModelSkinIdInt32_hotfix = (luaObj.RawGet("set_ModelSkinId") as LuaFunction);
					this.m_get_CharSkinId_hotfix = (luaObj.RawGet("get_CharSkinId") as LuaFunction);
					this.m_set_CharSkinIdInt32_hotfix = (luaObj.RawGet("set_CharSkinId") as LuaFunction);
					this.m_get_SelectedSoldierSkinId_hotfix = (luaObj.RawGet("get_SelectedSoldierSkinId") as LuaFunction);
					this.m_set_SelectedSoldierSkinIdInt32_hotfix = (luaObj.RawGet("set_SelectedSoldierSkinId") as LuaFunction);
					this.m_set_SelectedSoldierIdInt32_hotfix = (luaObj.RawGet("set_SelectedSoldierId") as LuaFunction);
					this.m_get_SelectedSoldierId_hotfix = (luaObj.RawGet("get_SelectedSoldierId") as LuaFunction);
					this.m_get_Power_hotfix = (luaObj.RawGet("get_Power") as LuaFunction);
					this.m_set_PowerInt32_hotfix = (luaObj.RawGet("set_Power") as LuaFunction);
					this.m_GetJobInt32_hotfix = (luaObj.RawGet("GetJob") as LuaFunction);
					this.m_GetActiveJob_hotfix = (luaObj.RawGet("GetActiveJob") as LuaFunction);
					this.m_GetHeroCharImageSkinResourceInfoIConfigDataLoader_hotfix = (luaObj.RawGet("GetHeroCharImageSkinResourceInfo") as LuaFunction);
					this.m_GetHeroActiveJobModelSkinResourceInfoIConfigDataLoader_hotfix = (luaObj.RawGet("GetHeroActiveJobModelSkinResourceInfo") as LuaFunction);
					this.m_GetSelectedSoldierModelSkinResourceInfoIConfigDataLoader_hotfix = (luaObj.RawGet("GetSelectedSoldierModelSkinResourceInfo") as LuaFunction);
					this.m_UpdateHeroInfo_hotfix = (luaObj.RawGet("UpdateHeroInfo") as LuaFunction);
					this.m_UpdateSoldierInfo_hotfix = (luaObj.RawGet("UpdateSoldierInfo") as LuaFunction);
					this.m_set_HeroInfoConfigDataHeroInfo_hotfix = (luaObj.RawGet("set_HeroInfo") as LuaFunction);
					this.m_get_HeroInfo_hotfix = (luaObj.RawGet("get_HeroInfo") as LuaFunction);
					this.m_set_SelectedSoldierInfoConfigDataSoldierInfo_hotfix = (luaObj.RawGet("set_SelectedSoldierInfo") as LuaFunction);
					this.m_get_SelectedSoldierInfo_hotfix = (luaObj.RawGet("get_SelectedSoldierInfo") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600319E RID: 12702 RVA: 0x000C32C4 File Offset: 0x000C14C4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleHero));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002606 RID: 9734
		private int m_heroId;

		// Token: 0x0400260F RID: 9743
		public List<BattleHeroJob> Jobs = new List<BattleHeroJob>();

		// Token: 0x04002610 RID: 9744
		public List<int> SelectedSkillList = new List<int>();

		// Token: 0x04002611 RID: 9745
		private int m_selectedSoldierId;

		// Token: 0x04002612 RID: 9746
		public List<BattleHeroEquipment> Equipments = new List<BattleHeroEquipment>();

		// Token: 0x04002613 RID: 9747
		public Dictionary<int, int> Fetters = new Dictionary<int, int>();

		// Token: 0x04002617 RID: 9751
		[DoNotToLua]
		private BattleHero.LuaExportHelper luaExportHelper;

		// Token: 0x04002618 RID: 9752
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002619 RID: 9753
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400261A RID: 9754
		private LuaFunction m_ctor_hotfix;

		// Token: 0x0400261B RID: 9755
		private LuaFunction m_set_HeroIdInt32_hotfix;

		// Token: 0x0400261C RID: 9756
		private LuaFunction m_get_HeroId_hotfix;

		// Token: 0x0400261D RID: 9757
		private LuaFunction m_get_ActionPositionIndex_hotfix;

		// Token: 0x0400261E RID: 9758
		private LuaFunction m_set_ActionPositionIndexInt32_hotfix;

		// Token: 0x0400261F RID: 9759
		private LuaFunction m_get_ActionValue_hotfix;

		// Token: 0x04002620 RID: 9760
		private LuaFunction m_set_ActionValueInt32_hotfix;

		// Token: 0x04002621 RID: 9761
		private LuaFunction m_get_Level_hotfix;

		// Token: 0x04002622 RID: 9762
		private LuaFunction m_set_LevelInt32_hotfix;

		// Token: 0x04002623 RID: 9763
		private LuaFunction m_get_StarLevel_hotfix;

		// Token: 0x04002624 RID: 9764
		private LuaFunction m_set_StarLevelInt32_hotfix;

		// Token: 0x04002625 RID: 9765
		private LuaFunction m_get_ActiveHeroJobRelatedId_hotfix;

		// Token: 0x04002626 RID: 9766
		private LuaFunction m_set_ActiveHeroJobRelatedIdInt32_hotfix;

		// Token: 0x04002627 RID: 9767
		private LuaFunction m_get_ModelSkinId_hotfix;

		// Token: 0x04002628 RID: 9768
		private LuaFunction m_set_ModelSkinIdInt32_hotfix;

		// Token: 0x04002629 RID: 9769
		private LuaFunction m_get_CharSkinId_hotfix;

		// Token: 0x0400262A RID: 9770
		private LuaFunction m_set_CharSkinIdInt32_hotfix;

		// Token: 0x0400262B RID: 9771
		private LuaFunction m_get_SelectedSoldierSkinId_hotfix;

		// Token: 0x0400262C RID: 9772
		private LuaFunction m_set_SelectedSoldierSkinIdInt32_hotfix;

		// Token: 0x0400262D RID: 9773
		private LuaFunction m_set_SelectedSoldierIdInt32_hotfix;

		// Token: 0x0400262E RID: 9774
		private LuaFunction m_get_SelectedSoldierId_hotfix;

		// Token: 0x0400262F RID: 9775
		private LuaFunction m_get_Power_hotfix;

		// Token: 0x04002630 RID: 9776
		private LuaFunction m_set_PowerInt32_hotfix;

		// Token: 0x04002631 RID: 9777
		private LuaFunction m_GetJobInt32_hotfix;

		// Token: 0x04002632 RID: 9778
		private LuaFunction m_GetActiveJob_hotfix;

		// Token: 0x04002633 RID: 9779
		private LuaFunction m_GetHeroCharImageSkinResourceInfoIConfigDataLoader_hotfix;

		// Token: 0x04002634 RID: 9780
		private LuaFunction m_GetHeroActiveJobModelSkinResourceInfoIConfigDataLoader_hotfix;

		// Token: 0x04002635 RID: 9781
		private LuaFunction m_GetSelectedSoldierModelSkinResourceInfoIConfigDataLoader_hotfix;

		// Token: 0x04002636 RID: 9782
		private LuaFunction m_UpdateHeroInfo_hotfix;

		// Token: 0x04002637 RID: 9783
		private LuaFunction m_UpdateSoldierInfo_hotfix;

		// Token: 0x04002638 RID: 9784
		private LuaFunction m_set_HeroInfoConfigDataHeroInfo_hotfix;

		// Token: 0x04002639 RID: 9785
		private LuaFunction m_get_HeroInfo_hotfix;

		// Token: 0x0400263A RID: 9786
		private LuaFunction m_set_SelectedSoldierInfoConfigDataSoldierInfo_hotfix;

		// Token: 0x0400263B RID: 9787
		private LuaFunction m_get_SelectedSoldierInfo_hotfix;

		// Token: 0x02000364 RID: 868
		public class LuaExportHelper
		{
			// Token: 0x0600319F RID: 12703 RVA: 0x000C332C File Offset: 0x000C152C
			public LuaExportHelper(BattleHero owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17000E2C RID: 3628
			// (get) Token: 0x060031A0 RID: 12704 RVA: 0x000C333C File Offset: 0x000C153C
			// (set) Token: 0x060031A1 RID: 12705 RVA: 0x000C334C File Offset: 0x000C154C
			public int m_heroId
			{
				get
				{
					return this.m_owner.m_heroId;
				}
				set
				{
					this.m_owner.m_heroId = value;
				}
			}

			// Token: 0x17000E2D RID: 3629
			// (get) Token: 0x060031A2 RID: 12706 RVA: 0x000C335C File Offset: 0x000C155C
			// (set) Token: 0x060031A3 RID: 12707 RVA: 0x000C336C File Offset: 0x000C156C
			public int m_selectedSoldierId
			{
				get
				{
					return this.m_owner.m_selectedSoldierId;
				}
				set
				{
					this.m_owner.m_selectedSoldierId = value;
				}
			}

			// Token: 0x17000E2E RID: 3630
			// (set) Token: 0x060031A4 RID: 12708 RVA: 0x000C337C File Offset: 0x000C157C
			public ConfigDataHeroInfo HeroInfo
			{
				set
				{
					this.m_owner.HeroInfo = value;
				}
			}

			// Token: 0x17000E2F RID: 3631
			// (set) Token: 0x060031A5 RID: 12709 RVA: 0x000C338C File Offset: 0x000C158C
			public ConfigDataSoldierInfo SelectedSoldierInfo
			{
				set
				{
					this.m_owner.SelectedSoldierInfo = value;
				}
			}

			// Token: 0x060031A6 RID: 12710 RVA: 0x000C339C File Offset: 0x000C159C
			public void UpdateHeroInfo()
			{
				this.m_owner.UpdateHeroInfo();
			}

			// Token: 0x060031A7 RID: 12711 RVA: 0x000C33AC File Offset: 0x000C15AC
			public void UpdateSoldierInfo()
			{
				this.m_owner.UpdateSoldierInfo();
			}

			// Token: 0x0400263C RID: 9788
			private BattleHero m_owner;
		}
	}
}
