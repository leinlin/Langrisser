using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000402 RID: 1026
	[CustomLuaClass]
	public class Hero
	{
		// Token: 0x06003BFE RID: 15358 RVA: 0x00110F74 File Offset: 0x0010F174
		public Hero()
		{
			this.m_heroId = 0;
		}

		// Token: 0x06003BFF RID: 15359 RVA: 0x00110FF4 File Offset: 0x0010F1F4
		public Hero(Hero other)
		{
			this.HeroId = other.HeroId;
			this.Level = other.Level;
			this.Exp = other.Exp;
			this.FavorabilityLevel = other.FavorabilityLevel;
			this.FavorabilityExp = other.FavorabilityExp;
			this.StarLevel = other.StarLevel;
			this.ActiveHeroJobRelatedId = other.ActiveHeroJobRelatedId;
			this.SelectedSoldierId = other.SelectedSoldierId;
			this.FightNums = other.FightNums;
			this.Confessed = other.Confessed;
			this.SelectedSkills.AddRange(other.SelectedSkills);
			this.UnlockedJobs.AddRange(other.UnlockedJobs);
			foreach (HeroJob other2 in other.Jobs)
			{
				this.Jobs.Add(new HeroJob(other2));
			}
			for (int i = 0; i < other.EquipmentIds.Length; i++)
			{
				this.EquipmentIds[i] = other.EquipmentIds[i];
			}
			foreach (KeyValuePair<int, int> keyValuePair in other.Fetters)
			{
				this.Fetters.Add(keyValuePair.Key, keyValuePair.Value);
			}
			foreach (SoldierSkin other3 in other.SoldierSkins)
			{
				this.SoldierSkins.Add(new SoldierSkin(other3));
			}
			this.BattlePower = other.BattlePower;
			this.BattlePowerUpdateTime = other.BattlePowerUpdateTime;
			this.LastRank = other.LastRank;
			this.CharSkinId = other.CharSkinId;
		}

		// Token: 0x06003C00 RID: 15360 RVA: 0x00111270 File Offset: 0x0010F470
		public Hero GetHeroCopy()
		{
			Hero hero = new Hero(this);
			hero.SkillIds.AddRange(this.SkillIds);
			hero.SoldierIds.AddRange(this.SoldierIds);
			hero.NeedGetAchievementsJobRelatedIdList.AddRange(this.NeedGetAchievementsJobRelatedIdList);
			hero.ActionPositionIndex = this.ActionPositionIndex;
			hero.ActionValue = this.ActionValue;
			hero.CanTransferMaxRank = this.CanTransferMaxRank;
			return hero;
		}

		// Token: 0x1700104D RID: 4173
		// (get) Token: 0x06003C01 RID: 15361 RVA: 0x001112DC File Offset: 0x0010F4DC
		// (set) Token: 0x06003C02 RID: 15362 RVA: 0x001112E4 File Offset: 0x0010F4E4
		public int ActionPositionIndex { get; set; }

		// Token: 0x1700104E RID: 4174
		// (get) Token: 0x06003C03 RID: 15363 RVA: 0x001112F0 File Offset: 0x0010F4F0
		// (set) Token: 0x06003C04 RID: 15364 RVA: 0x001112F8 File Offset: 0x0010F4F8
		public int ActionValue { get; set; }

		// Token: 0x1700104F RID: 4175
		// (get) Token: 0x06003C06 RID: 15366 RVA: 0x00111314 File Offset: 0x0010F514
		// (set) Token: 0x06003C05 RID: 15365 RVA: 0x00111304 File Offset: 0x0010F504
		public int HeroId
		{
			get
			{
				return this.m_heroId;
			}
			set
			{
				this.m_heroId = value;
				this.UpdateHeroInfo();
			}
		}

		// Token: 0x17001050 RID: 4176
		// (get) Token: 0x06003C07 RID: 15367 RVA: 0x0011131C File Offset: 0x0010F51C
		// (set) Token: 0x06003C08 RID: 15368 RVA: 0x00111324 File Offset: 0x0010F524
		public int Level { get; set; }

		// Token: 0x17001051 RID: 4177
		// (get) Token: 0x06003C09 RID: 15369 RVA: 0x00111330 File Offset: 0x0010F530
		// (set) Token: 0x06003C0A RID: 15370 RVA: 0x00111338 File Offset: 0x0010F538
		public int Exp { get; set; }

		// Token: 0x17001052 RID: 4178
		// (get) Token: 0x06003C0B RID: 15371 RVA: 0x00111344 File Offset: 0x0010F544
		// (set) Token: 0x06003C0C RID: 15372 RVA: 0x0011134C File Offset: 0x0010F54C
		public int StarLevel { get; set; }

		// Token: 0x17001053 RID: 4179
		// (get) Token: 0x06003C0D RID: 15373 RVA: 0x00111358 File Offset: 0x0010F558
		// (set) Token: 0x06003C0E RID: 15374 RVA: 0x00111360 File Offset: 0x0010F560
		public int FightNums { get; set; }

		// Token: 0x17001054 RID: 4180
		// (get) Token: 0x06003C0F RID: 15375 RVA: 0x0011136C File Offset: 0x0010F56C
		// (set) Token: 0x06003C10 RID: 15376 RVA: 0x00111374 File Offset: 0x0010F574
		public int ActiveHeroJobRelatedId { get; set; }

		// Token: 0x17001055 RID: 4181
		// (get) Token: 0x06003C11 RID: 15377 RVA: 0x00111380 File Offset: 0x0010F580
		// (set) Token: 0x06003C12 RID: 15378 RVA: 0x00111388 File Offset: 0x0010F588
		public int CharSkinId { get; set; }

		// Token: 0x17001056 RID: 4182
		// (get) Token: 0x06003C13 RID: 15379 RVA: 0x00111394 File Offset: 0x0010F594
		// (set) Token: 0x06003C14 RID: 15380 RVA: 0x0011139C File Offset: 0x0010F59C
		public int FavorabilityLevel { get; set; }

		// Token: 0x17001057 RID: 4183
		// (get) Token: 0x06003C15 RID: 15381 RVA: 0x001113A8 File Offset: 0x0010F5A8
		// (set) Token: 0x06003C16 RID: 15382 RVA: 0x001113B0 File Offset: 0x0010F5B0
		public int FavorabilityExp { get; set; }

		// Token: 0x17001058 RID: 4184
		// (get) Token: 0x06003C17 RID: 15383 RVA: 0x001113BC File Offset: 0x0010F5BC
		// (set) Token: 0x06003C18 RID: 15384 RVA: 0x001113C4 File Offset: 0x0010F5C4
		public bool Confessed { get; set; }

		// Token: 0x06003C19 RID: 15385 RVA: 0x001113D0 File Offset: 0x0010F5D0
		public bool IsEquipmentWeared(int slot)
		{
			return this.EquipmentIds[slot] != 0UL;
		}

		// Token: 0x06003C1A RID: 15386 RVA: 0x001113E4 File Offset: 0x0010F5E4
		public void TakeOffEquipment(int slot)
		{
			this.EquipmentIds[slot] = 0UL;
		}

		// Token: 0x06003C1B RID: 15387 RVA: 0x001113F0 File Offset: 0x0010F5F0
		public bool HasOwnSoldier(int soldierId)
		{
			return this.SoldierIds.Contains(soldierId);
		}

		// Token: 0x06003C1C RID: 15388 RVA: 0x00111400 File Offset: 0x0010F600
		public int GetSoldierSkinId(int soldierId)
		{
			SoldierSkin soldierSkin = this.SoldierSkins.Find((SoldierSkin m) => m.SoldierId == soldierId);
			return (soldierSkin == null) ? 0 : soldierSkin.SkinId;
		}

		// Token: 0x17001059 RID: 4185
		// (get) Token: 0x06003C1E RID: 15390 RVA: 0x00111454 File Offset: 0x0010F654
		// (set) Token: 0x06003C1D RID: 15389 RVA: 0x00111444 File Offset: 0x0010F644
		public int SelectedSoldierId
		{
			get
			{
				return this.m_selectedSoldierId;
			}
			set
			{
				this.m_selectedSoldierId = value;
				this.UpdateSoldierInfo();
			}
		}

		// Token: 0x1700105A RID: 4186
		// (get) Token: 0x06003C1F RID: 15391 RVA: 0x0011145C File Offset: 0x0010F65C
		// (set) Token: 0x06003C20 RID: 15392 RVA: 0x00111464 File Offset: 0x0010F664
		public int CanTransferMaxRank { get; set; }

		// Token: 0x1700105B RID: 4187
		// (get) Token: 0x06003C21 RID: 15393 RVA: 0x00111470 File Offset: 0x0010F670
		// (set) Token: 0x06003C22 RID: 15394 RVA: 0x00111478 File Offset: 0x0010F678
		public int BattlePower { get; set; }

		// Token: 0x1700105C RID: 4188
		// (get) Token: 0x06003C23 RID: 15395 RVA: 0x00111484 File Offset: 0x0010F684
		// (set) Token: 0x06003C24 RID: 15396 RVA: 0x0011148C File Offset: 0x0010F68C
		public DateTime BattlePowerUpdateTime { get; set; }

		// Token: 0x1700105D RID: 4189
		// (get) Token: 0x06003C25 RID: 15397 RVA: 0x00111498 File Offset: 0x0010F698
		// (set) Token: 0x06003C26 RID: 15398 RVA: 0x001114A0 File Offset: 0x0010F6A0
		public int LastRank { get; set; }

		// Token: 0x06003C27 RID: 15399 RVA: 0x001114AC File Offset: 0x0010F6AC
		public HeroJob GetJob(int jobRelatedId)
		{
			foreach (HeroJob heroJob in this.Jobs)
			{
				if (heroJob.JobRelatedId == jobRelatedId)
				{
					return heroJob;
				}
			}
			return null;
		}

		// Token: 0x06003C28 RID: 15400 RVA: 0x00111518 File Offset: 0x0010F718
		public HeroJob GetActiveJob()
		{
			return this.GetJob(this.ActiveHeroJobRelatedId);
		}

		// Token: 0x06003C29 RID: 15401 RVA: 0x00111528 File Offset: 0x0010F728
		public static ProHero HeroToPBHero(Hero hero)
		{
			ProHero proHero = new ProHero();
			proHero.HeroId = hero.HeroId;
			proHero.Level = hero.Level;
			proHero.Exp = hero.Exp;
			proHero.FavorabilityLevel = hero.FavorabilityLevel;
			proHero.FavorabilityExp = hero.FavorabilityExp;
			proHero.StarLevel = hero.StarLevel;
			proHero.ActiveJobRelatedId = hero.ActiveHeroJobRelatedId;
			proHero.SelectedSoldierId = hero.SelectedSoldierId;
			proHero.FightNums = hero.FightNums;
			proHero.Confessed = hero.Confessed;
			proHero.Power = hero.BattlePower;
			proHero.CharSkinId = hero.CharSkinId;
			proHero.SelectedSkills.AddRange(hero.SelectedSkills);
			proHero.UnlockedJobs.AddRange(hero.UnlockedJobs);
			foreach (SoldierSkin skin in hero.SoldierSkins)
			{
				proHero.SoldierSkins.Add(SoldierSkin.SoldierSkinToPbSoldierSkin(skin));
			}
			foreach (HeroJob heroJob in hero.Jobs)
			{
				proHero.Jobs.Add(HeroJob.HeroJobToPBHeroJob(heroJob));
			}
			proHero.EquipmentIds.AddRange(hero.EquipmentIds);
			foreach (KeyValuePair<int, int> keyValuePair in hero.Fetters)
			{
				proHero.Fetters.Add(new ProHeroFetter
				{
					FetterId = keyValuePair.Key,
					Level = keyValuePair.Value
				});
			}
			return proHero;
		}

		// Token: 0x06003C2A RID: 15402 RVA: 0x00111724 File Offset: 0x0010F924
		public static Hero PBHeroToHero(ProHero pbHero)
		{
			Hero hero = new Hero();
			hero.HeroId = pbHero.HeroId;
			hero.Level = pbHero.Level;
			hero.Exp = pbHero.Exp;
			hero.FavorabilityLevel = pbHero.FavorabilityLevel;
			hero.FavorabilityExp = pbHero.FavorabilityExp;
			hero.StarLevel = pbHero.StarLevel;
			hero.ActiveHeroJobRelatedId = pbHero.ActiveJobRelatedId;
			hero.SelectedSoldierId = pbHero.SelectedSoldierId;
			hero.FightNums = pbHero.FightNums;
			hero.Confessed = pbHero.Confessed;
			hero.BattlePower = pbHero.Power;
			hero.CharSkinId = pbHero.CharSkinId;
			hero.SelectedSkills.AddRange(pbHero.SelectedSkills);
			hero.UnlockedJobs.AddRange(pbHero.UnlockedJobs);
			foreach (ProHeroJob pbHeroJob in pbHero.Jobs)
			{
				hero.Jobs.Add(HeroJob.PbHeroJobToHeroJob(pbHeroJob));
			}
			foreach (ProSoldierSkin pbSkin in pbHero.SoldierSkins)
			{
				hero.SoldierSkins.Add(SoldierSkin.PbSoldierSkinToSoldierSkin(pbSkin));
			}
			for (int i = 0; i < pbHero.EquipmentIds.Count; i++)
			{
				hero.EquipmentIds[i] = pbHero.EquipmentIds[i];
			}
			foreach (ProHeroFetter proHeroFetter in pbHero.Fetters)
			{
				hero.Fetters.Add(proHeroFetter.FetterId, proHeroFetter.Level);
			}
			return hero;
		}

		// Token: 0x06003C2B RID: 15403 RVA: 0x00111930 File Offset: 0x0010FB30
		private void UpdateHeroInfo()
		{
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.HeroInfo = configDataLoader.GetConfigDataHeroInfo(this.HeroId);
		}

		// Token: 0x06003C2C RID: 15404 RVA: 0x00111960 File Offset: 0x0010FB60
		private void UpdateSoldierInfo()
		{
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.SelectedSoldierInfo = configDataLoader.GetConfigDataSoldierInfo(this.SelectedSoldierId);
		}

		// Token: 0x06003C2D RID: 15405 RVA: 0x00111990 File Offset: 0x0010FB90
		public ConfigDataCharImageSkinResourceInfo GetHeroCharImageSkinResourceInfo()
		{
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			return BattleUtility.GetHeroCharImageSkinResourceInfo(configDataLoader, this.CharSkinId);
		}

		// Token: 0x06003C2E RID: 15406 RVA: 0x001119BC File Offset: 0x0010FBBC
		public ConfigDataModelSkinResourceInfo GetSoldierModelSkinResourceInfo(int soldierId)
		{
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			int soldierSkinId = this.GetSoldierSkinId(soldierId);
			return BattleUtility.GetSoldierModelSkinResourceInfo(configDataLoader, soldierSkinId, soldierId);
		}

		// Token: 0x1700105E RID: 4190
		// (get) Token: 0x06003C30 RID: 15408 RVA: 0x001119F8 File Offset: 0x0010FBF8
		// (set) Token: 0x06003C2F RID: 15407 RVA: 0x001119EC File Offset: 0x0010FBEC
		public ConfigDataHeroInfo HeroInfo { get; private set; }

		// Token: 0x1700105F RID: 4191
		// (get) Token: 0x06003C32 RID: 15410 RVA: 0x00111A0C File Offset: 0x0010FC0C
		// (set) Token: 0x06003C31 RID: 15409 RVA: 0x00111A00 File Offset: 0x0010FC00
		public ConfigDataSoldierInfo SelectedSoldierInfo { get; private set; }

		// Token: 0x04002DC1 RID: 11713
		private int m_heroId;

		// Token: 0x04002DC8 RID: 11720
		public List<int> SkillIds = new List<int>();

		// Token: 0x04002DC9 RID: 11721
		public List<int> SoldierIds = new List<int>();

		// Token: 0x04002DCA RID: 11722
		public List<int> SelectedSkills = new List<int>();

		// Token: 0x04002DCB RID: 11723
		public List<int> NeedGetAchievementsJobRelatedIdList = new List<int>();

		// Token: 0x04002DCC RID: 11724
		public ulong[] EquipmentIds = new ulong[4];

		// Token: 0x04002DD0 RID: 11728
		public Dictionary<int, int> Fetters = new Dictionary<int, int>();

		// Token: 0x04002DD1 RID: 11729
		private int m_selectedSoldierId;

		// Token: 0x04002DD3 RID: 11731
		public List<HeroJob> Jobs = new List<HeroJob>();

		// Token: 0x04002DD4 RID: 11732
		public List<int> UnlockedJobs = new List<int>();

		// Token: 0x04002DD5 RID: 11733
		public List<SoldierSkin> SoldierSkins = new List<SoldierSkin>();
	}
}
