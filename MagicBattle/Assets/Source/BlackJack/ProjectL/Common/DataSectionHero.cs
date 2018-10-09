using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004D6 RID: 1238
	[CustomLuaClass]
	public class DataSectionHero : DataSection
	{
		// Token: 0x06004B45 RID: 19269 RVA: 0x00175E78 File Offset: 0x00174078
		public DataSectionHero()
		{
			this.Heroes = new HeroUpdateCache();
			this.GainHeroIds = new HashSet<int>();
			this.m_id2CacheIndex = new Dictionary<int, int>();
			this.m_protagonistId = 0;
			this.HeroInteractNumsFlushTime = DateTime.MinValue;
			this.m_heroInteractNums = 0;
		}

		// Token: 0x06004B46 RID: 19270 RVA: 0x00175EC8 File Offset: 0x001740C8
		public override void ClearInitedData()
		{
			this.Heroes = new HeroUpdateCache();
			this.GainHeroIds.Clear();
			this.m_id2CacheIndex.Clear();
		}

		// Token: 0x06004B47 RID: 19271 RVA: 0x00175EEC File Offset: 0x001740EC
		public override object SerializeToClient()
		{
			DSHeroNtf dsheroNtf = new DSHeroNtf();
			dsheroNtf.Version = (uint)base.Version;
			dsheroNtf.ProtagonistId = this.m_protagonistId;
			dsheroNtf.HeroInteractNums = this.m_heroInteractNums;
			dsheroNtf.HeroInteractNumsFlushTime = this.HeroInteractNumsFlushTime.Ticks;
			foreach (UpdateCache<Hero> updateCache in this.Heroes.Caches)
			{
				if (updateCache.IsValid())
				{
					dsheroNtf.Heroes.Add(Hero.HeroToPBHero(updateCache.Data));
				}
			}
			return dsheroNtf;
		}

		// Token: 0x06004B48 RID: 19272 RVA: 0x00175FA8 File Offset: 0x001741A8
		public void AddHeroFightNums(Hero hero, int nums)
		{
			hero.FightNums += nums;
			this.SetHeroDirty(hero);
		}

		// Token: 0x06004B49 RID: 19273 RVA: 0x00175FC0 File Offset: 0x001741C0
		public Hero AddHero(int heroId, int starLevel)
		{
			Hero hero = new Hero();
			hero.HeroId = heroId;
			hero.Exp = 0;
			hero.Level = 1;
			hero.FavorabilityLevel = 1;
			hero.FavorabilityExp = 0;
			hero.StarLevel = starLevel;
			hero.ActiveHeroJobRelatedId = 0;
			hero.SelectedSoldierId = 0;
			int value = this.Heroes.Add(hero);
			this.GainHeroIds.Add(heroId);
			this.m_id2CacheIndex.Add(heroId, value);
			base.SetDirty(true);
			return hero;
		}

		// Token: 0x06004B4A RID: 19274 RVA: 0x0017603C File Offset: 0x0017423C
		public void InitHero(Hero hero)
		{
			int value = this.Heroes.Init(hero);
			int heroId = hero.HeroId;
			this.GainHeroIds.Add(heroId);
			this.m_id2CacheIndex.Add(heroId, value);
		}

		// Token: 0x06004B4B RID: 19275 RVA: 0x00176078 File Offset: 0x00174278
		public void RemoveHero(Hero hero)
		{
			int index = this.FindHeroIndex(hero);
			this.Heroes.Remove(index);
			this.GainHeroIds.Remove(hero.HeroId);
			this.m_id2CacheIndex.Remove(hero.HeroId);
			base.SetDirty(true);
		}

		// Token: 0x06004B4C RID: 19276 RVA: 0x001760C8 File Offset: 0x001742C8
		public bool ReplaceHero(Hero oldHero, Hero newHero)
		{
			if (oldHero.HeroId != newHero.HeroId)
			{
				return false;
			}
			int index = this.FindHeroIndex(oldHero);
			this.Heroes.Set(index, newHero);
			base.SetDirty(true);
			return true;
		}

		// Token: 0x06004B4D RID: 19277 RVA: 0x00176108 File Offset: 0x00174308
		private UpdateCache<Hero> FindCache(Hero hero)
		{
			int index = this.FindHeroIndex(hero);
			return this.Heroes.Find(index);
		}

		// Token: 0x06004B4E RID: 19278 RVA: 0x0017612C File Offset: 0x0017432C
		private int FindHeroIndex(Hero hero)
		{
			int result;
			this.m_id2CacheIndex.TryGetValue(hero.HeroId, out result);
			return result;
		}

		// Token: 0x06004B4F RID: 19279 RVA: 0x00176150 File Offset: 0x00174350
		public void RemoveAllHeros()
		{
			this.Heroes.Clear();
			this.GainHeroIds.Clear();
			this.m_id2CacheIndex.Clear();
			base.SetDirty(true);
		}

		// Token: 0x06004B50 RID: 19280 RVA: 0x0017617C File Offset: 0x0017437C
		public Hero FindHero(int heroId)
		{
			int index;
			if (this.m_id2CacheIndex.TryGetValue(heroId, out index))
			{
				UpdateCache<Hero> updateCache = this.Heroes.Find(index);
				return updateCache.Data;
			}
			return null;
		}

		// Token: 0x06004B51 RID: 19281 RVA: 0x001761B4 File Offset: 0x001743B4
		public bool IsNeedAddAchievement(Hero hero)
		{
			return hero.NeedGetAchievementsJobRelatedIdList.Count != 0;
		}

		// Token: 0x06004B52 RID: 19282 RVA: 0x001761C8 File Offset: 0x001743C8
		public void SetHeroDirty(Hero hero)
		{
			UpdateCache<Hero> updateCache = this.FindCache(hero);
			updateCache.Dirty = true;
			base.SetDirty(true);
		}

		// Token: 0x06004B53 RID: 19283 RVA: 0x001761EC File Offset: 0x001743EC
		public void AddHeroJob(Hero hero, int jobRelatedId)
		{
			HeroJob heroJob = new HeroJob();
			heroJob.JobRelatedId = jobRelatedId;
			heroJob.JobLevel = 0;
			hero.Jobs.Add(heroJob);
			this.SetHeroDirty(hero);
		}

		// Token: 0x06004B54 RID: 19284 RVA: 0x00176220 File Offset: 0x00174420
		public HeroJob FindHeroJob(Hero hero, int jobRelatedId)
		{
			return hero.Jobs.Find((HeroJob m) => m.JobRelatedId == jobRelatedId);
		}

		// Token: 0x06004B55 RID: 19285 RVA: 0x00176254 File Offset: 0x00174454
		public void UnlockHeroJob(Hero hero, int jobRelatedId)
		{
			hero.UnlockedJobs.Add(jobRelatedId);
			this.SetHeroDirty(hero);
		}

		// Token: 0x06004B56 RID: 19286 RVA: 0x0017626C File Offset: 0x0017446C
		public void AddHeroJobAchievements(HeroJob heroJob, List<int> achievements)
		{
			foreach (int item in achievements)
			{
				heroJob.Achievements.Add(item);
			}
		}

		// Token: 0x06004B57 RID: 19287 RVA: 0x001762CC File Offset: 0x001744CC
		public void ActiveHeroJob(Hero hero, int jobRelatedId)
		{
			hero.ActiveHeroJobRelatedId = jobRelatedId;
			this.SetHeroDirty(hero);
		}

		// Token: 0x06004B58 RID: 19288 RVA: 0x001762DC File Offset: 0x001744DC
		public void SetHeroExp(Hero hero, int exp)
		{
			hero.Exp = exp;
			this.SetHeroDirty(hero);
		}

		// Token: 0x06004B59 RID: 19289 RVA: 0x001762EC File Offset: 0x001744EC
		public void AddHeroLevel(Hero hero, int level)
		{
			hero.Level += level;
			hero.Exp = 0;
			this.SetHeroDirty(hero);
		}

		// Token: 0x06004B5A RID: 19290 RVA: 0x0017630C File Offset: 0x0017450C
		public void AddHeroStarLevel(Hero hero, int starLevel)
		{
			hero.StarLevel += starLevel;
			this.SetHeroDirty(hero);
		}

		// Token: 0x06004B5B RID: 19291 RVA: 0x00176324 File Offset: 0x00174524
		public void SelectSkills(Hero hero, List<int> skills)
		{
			hero.SelectedSkills.Clear();
			foreach (int item in skills)
			{
				hero.SelectedSkills.Add(item);
			}
			this.SetHeroDirty(hero);
		}

		// Token: 0x06004B5C RID: 19292 RVA: 0x00176394 File Offset: 0x00174594
		public void SelectSolider(Hero hero, int soliderId)
		{
			hero.SelectedSoldierId = soliderId;
			this.SetHeroDirty(hero);
		}

		// Token: 0x06004B5D RID: 19293 RVA: 0x001763A4 File Offset: 0x001745A4
		public void AddSkill(Hero hero, int skillId)
		{
			hero.SkillIds.Add(skillId);
		}

		// Token: 0x06004B5E RID: 19294 RVA: 0x001763B4 File Offset: 0x001745B4
		public void AddSoldier(Hero hero, int soldierId)
		{
			hero.SoldierIds.Add(soldierId);
		}

		// Token: 0x06004B5F RID: 19295 RVA: 0x001763C4 File Offset: 0x001745C4
		public void LevelUpHeroJobLevel(Hero hero, HeroJob heroJob)
		{
			heroJob.JobLevel++;
			this.SetHeroDirty(hero);
		}

		// Token: 0x06004B60 RID: 19296 RVA: 0x001763DC File Offset: 0x001745DC
		public List<Hero> GetAllHeroes()
		{
			return this.Heroes.GetAllVaildDatas();
		}

		// Token: 0x06004B61 RID: 19297 RVA: 0x001763EC File Offset: 0x001745EC
		public void InitProtagonist(int protagonist)
		{
			this.m_protagonistId = protagonist;
		}

		// Token: 0x06004B62 RID: 19298 RVA: 0x001763F8 File Offset: 0x001745F8
		public void SetProtagonist(int protagonistId)
		{
			this.m_protagonistId = protagonistId;
			base.SetDirty(true);
		}

		// Token: 0x06004B63 RID: 19299 RVA: 0x00176408 File Offset: 0x00174608
		public void SetHeroFavorabilityLevel(Hero hero, int level)
		{
			hero.FavorabilityLevel = level;
			this.SetHeroDirty(hero);
		}

		// Token: 0x06004B64 RID: 19300 RVA: 0x00176418 File Offset: 0x00174618
		public void AddHeroFavorabilityLevel(Hero hero, int addLevel)
		{
			hero.FavorabilityLevel += addLevel;
			hero.FavorabilityExp = 0;
			this.SetHeroDirty(hero);
		}

		// Token: 0x06004B65 RID: 19301 RVA: 0x00176438 File Offset: 0x00174638
		public void SetHeroFavorabilityExp(Hero hero, int exp)
		{
			hero.FavorabilityExp = exp;
			this.SetHeroDirty(hero);
		}

		// Token: 0x06004B66 RID: 19302 RVA: 0x00176448 File Offset: 0x00174648
		public void UnlockHeroFetter(Hero hero, int fetterId)
		{
			hero.Fetters.Add(fetterId, 1);
			this.SetHeroDirty(hero);
		}

		// Token: 0x06004B67 RID: 19303 RVA: 0x00176460 File Offset: 0x00174660
		public void ConfessHero(Hero hero)
		{
			hero.Confessed = true;
			this.SetHeroDirty(hero);
		}

		// Token: 0x06004B68 RID: 19304 RVA: 0x00176470 File Offset: 0x00174670
		public void LevelUpHeroFetter(Hero hero, int fetterId)
		{
			Dictionary<int, int> fetters;
			(fetters = hero.Fetters)[fetterId] = fetters[fetterId] + 1;
			this.SetHeroDirty(hero);
		}

		// Token: 0x06004B69 RID: 19305 RVA: 0x001764A0 File Offset: 0x001746A0
		public bool CanInteractHero()
		{
			return this.m_heroInteractNums > 0;
		}

		// Token: 0x06004B6A RID: 19306 RVA: 0x001764AC File Offset: 0x001746AC
		public void InitHeroInteractNums(int nums)
		{
			this.m_heroInteractNums = nums;
		}

		// Token: 0x06004B6B RID: 19307 RVA: 0x001764B8 File Offset: 0x001746B8
		public void InitAllHeroBattlePower(int power, DateTime updateTime, int lastRank, DateTime lastUpdateTime)
		{
			this.AllHeroBattlePower = power;
			this.AllHeroBattlePowerUpdateTime = updateTime;
			this.LastAllHeroRank = lastRank;
			this.LastHeroRankUpdateTime = lastUpdateTime;
		}

		// Token: 0x06004B6C RID: 19308 RVA: 0x001764D8 File Offset: 0x001746D8
		public void InitTopHeroBattlePower(int power, DateTime updateTime, int powerThreshold, int lastRank)
		{
			this.TopHeroBattlePower = power;
			this.TopHeroBattlePowerUpdateTime = updateTime;
			this.TopBattlePowerThreshold = powerThreshold;
			this.LastTopHeroRank = lastRank;
		}

		// Token: 0x06004B6D RID: 19309 RVA: 0x001764F8 File Offset: 0x001746F8
		public void InitChampionHeroBattlePower(int power, DateTime updateTime, int heroId, int lastRank)
		{
			this.ChampionHeroBattlePower = power;
			this.ChampionHeroBattlePowerUpdateTime = updateTime;
			this.ChampionHeroId = heroId;
			this.LastChampionHeroRank = lastRank;
		}

		// Token: 0x06004B6E RID: 19310 RVA: 0x00176518 File Offset: 0x00174718
		public void SetHeroInteractNums(int nums)
		{
			this.m_heroInteractNums = nums;
			base.SetDirty(true);
		}

		// Token: 0x17001280 RID: 4736
		// (get) Token: 0x06004B6F RID: 19311 RVA: 0x00176528 File Offset: 0x00174728
		public int HeroInteractNums
		{
			get
			{
				return this.m_heroInteractNums;
			}
		}

		// Token: 0x06004B70 RID: 19312 RVA: 0x00176530 File Offset: 0x00174730
		public void SetHeroInteractNumsFlushTime(DateTime time)
		{
			this.HeroInteractNumsFlushTime = time;
			base.SetDirty(true);
		}

		// Token: 0x06004B71 RID: 19313 RVA: 0x00176540 File Offset: 0x00174740
		public void InitHeroInteractNumsFlushTime(DateTime time)
		{
			this.HeroInteractNumsFlushTime = time;
		}

		// Token: 0x06004B72 RID: 19314 RVA: 0x0017654C File Offset: 0x0017474C
		private static int BattlePowerCompare(Hero x, Hero y)
		{
			return y.BattlePower - x.BattlePower;
		}

		// Token: 0x06004B73 RID: 19315 RVA: 0x0017655C File Offset: 0x0017475C
		public void OnHeroBattlePowerChange(DateTime time, Hero hero = null)
		{
			List<Hero> allHeroes = this.GetAllHeroes();
			if (allHeroes.Count == 0)
			{
				return;
			}
			this.AllHeroBattlePower = 0;
			foreach (Hero hero2 in allHeroes)
			{
				this.AllHeroBattlePower += hero2.BattlePower;
			}
			this.AllHeroBattlePowerUpdateTime = time;
			if ((hero != null && hero.BattlePower > this.TopBattlePowerThreshold) || hero == null)
			{
				List<Hero> list = new List<Hero>();
				list.AddRange(allHeroes);
				List<Hero> list2 = list;
				if (DataSectionHero.<>f__mg$cache0 == null)
				{
					DataSectionHero.<>f__mg$cache0 = new Comparison<Hero>(DataSectionHero.BattlePowerCompare);
				}
				list2.Sort(DataSectionHero.<>f__mg$cache0);
				this.TopHeroBattlePower = 0;
				int num = 0;
				foreach (Hero hero3 in list)
				{
					this.TopBattlePowerThreshold = hero3.BattlePower;
					this.TopHeroBattlePower += hero3.BattlePower;
					this.TopHeroBattlePowerUpdateTime = time;
					if (num == 0)
					{
						this.ChampionHeroBattlePower = hero3.BattlePower;
						this.ChampionHeroId = hero3.HeroId;
						this.ChampionHeroBattlePowerUpdateTime = time;
					}
					num++;
					if (num >= 5)
					{
						break;
					}
				}
			}
			base.SetDirty(true);
		}

		// Token: 0x17001281 RID: 4737
		// (get) Token: 0x06004B74 RID: 19316 RVA: 0x001766E4 File Offset: 0x001748E4
		// (set) Token: 0x06004B75 RID: 19317 RVA: 0x001766EC File Offset: 0x001748EC
		public DateTime HeroInteractNumsFlushTime { get; set; }

		// Token: 0x17001282 RID: 4738
		// (get) Token: 0x06004B76 RID: 19318 RVA: 0x001766F8 File Offset: 0x001748F8
		// (set) Token: 0x06004B77 RID: 19319 RVA: 0x00176700 File Offset: 0x00174900
		public HashSet<int> GainHeroIds { get; set; }

		// Token: 0x17001283 RID: 4739
		// (get) Token: 0x06004B78 RID: 19320 RVA: 0x0017670C File Offset: 0x0017490C
		// (set) Token: 0x06004B79 RID: 19321 RVA: 0x00176714 File Offset: 0x00174914
		public HeroUpdateCache Heroes { get; set; }

		// Token: 0x17001284 RID: 4740
		// (get) Token: 0x06004B7A RID: 19322 RVA: 0x00176720 File Offset: 0x00174920
		public int ProtagonistID
		{
			get
			{
				return this.m_protagonistId;
			}
		}

		// Token: 0x17001285 RID: 4741
		// (get) Token: 0x06004B7B RID: 19323 RVA: 0x00176728 File Offset: 0x00174928
		// (set) Token: 0x06004B7C RID: 19324 RVA: 0x00176730 File Offset: 0x00174930
		public int AllHeroBattlePower { get; private set; }

		// Token: 0x17001286 RID: 4742
		// (get) Token: 0x06004B7D RID: 19325 RVA: 0x0017673C File Offset: 0x0017493C
		// (set) Token: 0x06004B7E RID: 19326 RVA: 0x00176744 File Offset: 0x00174944
		public DateTime AllHeroBattlePowerUpdateTime { get; set; }

		// Token: 0x17001287 RID: 4743
		// (get) Token: 0x06004B7F RID: 19327 RVA: 0x00176750 File Offset: 0x00174950
		// (set) Token: 0x06004B80 RID: 19328 RVA: 0x00176758 File Offset: 0x00174958
		public int LastAllHeroRank { get; set; }

		// Token: 0x17001288 RID: 4744
		// (get) Token: 0x06004B81 RID: 19329 RVA: 0x00176764 File Offset: 0x00174964
		// (set) Token: 0x06004B82 RID: 19330 RVA: 0x0017676C File Offset: 0x0017496C
		public int TopHeroBattlePower { get; private set; }

		// Token: 0x17001289 RID: 4745
		// (get) Token: 0x06004B83 RID: 19331 RVA: 0x00176778 File Offset: 0x00174978
		// (set) Token: 0x06004B84 RID: 19332 RVA: 0x00176780 File Offset: 0x00174980
		public DateTime TopHeroBattlePowerUpdateTime { get; set; }

		// Token: 0x1700128A RID: 4746
		// (get) Token: 0x06004B85 RID: 19333 RVA: 0x0017678C File Offset: 0x0017498C
		// (set) Token: 0x06004B86 RID: 19334 RVA: 0x00176794 File Offset: 0x00174994
		public int LastTopHeroRank { get; set; }

		// Token: 0x1700128B RID: 4747
		// (get) Token: 0x06004B87 RID: 19335 RVA: 0x001767A0 File Offset: 0x001749A0
		// (set) Token: 0x06004B88 RID: 19336 RVA: 0x001767A8 File Offset: 0x001749A8
		public int ChampionHeroBattlePower { get; private set; }

		// Token: 0x1700128C RID: 4748
		// (get) Token: 0x06004B89 RID: 19337 RVA: 0x001767B4 File Offset: 0x001749B4
		// (set) Token: 0x06004B8A RID: 19338 RVA: 0x001767BC File Offset: 0x001749BC
		public int ChampionHeroId { get; private set; }

		// Token: 0x1700128D RID: 4749
		// (get) Token: 0x06004B8B RID: 19339 RVA: 0x001767C8 File Offset: 0x001749C8
		// (set) Token: 0x06004B8C RID: 19340 RVA: 0x001767D0 File Offset: 0x001749D0
		public DateTime ChampionHeroBattlePowerUpdateTime { get; set; }

		// Token: 0x1700128E RID: 4750
		// (get) Token: 0x06004B8D RID: 19341 RVA: 0x001767DC File Offset: 0x001749DC
		// (set) Token: 0x06004B8E RID: 19342 RVA: 0x001767E4 File Offset: 0x001749E4
		public int LastChampionHeroRank { get; set; }

		// Token: 0x1700128F RID: 4751
		// (get) Token: 0x06004B8F RID: 19343 RVA: 0x001767F0 File Offset: 0x001749F0
		// (set) Token: 0x06004B90 RID: 19344 RVA: 0x001767F8 File Offset: 0x001749F8
		public DateTime LastHeroRankUpdateTime { get; set; }

		// Token: 0x17001290 RID: 4752
		// (get) Token: 0x06004B91 RID: 19345 RVA: 0x00176804 File Offset: 0x00174A04
		// (set) Token: 0x06004B92 RID: 19346 RVA: 0x0017680C File Offset: 0x00174A0C
		public int TopBattlePowerThreshold { get; private set; }

		// Token: 0x0400385F RID: 14431
		private int m_heroInteractNums;

		// Token: 0x04003861 RID: 14433
		private Dictionary<int, int> m_id2CacheIndex;

		// Token: 0x04003863 RID: 14435
		private int m_protagonistId;

		// Token: 0x04003870 RID: 14448
		[CompilerGenerated]
		private static Comparison<Hero> <>f__mg$cache0;
	}
}
