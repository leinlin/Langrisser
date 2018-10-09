using System;
using System.Collections.Generic;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200054B RID: 1355
	[CustomLuaClass]
	public class HeroPhantomLevel
	{
		// Token: 0x170013A3 RID: 5027
		// (get) Token: 0x06004FD9 RID: 20441 RVA: 0x0017FA8C File Offset: 0x0017DC8C
		// (set) Token: 0x06004FDA RID: 20442 RVA: 0x0017FA94 File Offset: 0x0017DC94
		public int ID { get; set; }

		// Token: 0x170013A4 RID: 5028
		// (get) Token: 0x06004FDB RID: 20443 RVA: 0x0017FAA0 File Offset: 0x0017DCA0
		public string Name
		{
			get
			{
				return this.Config.Name;
			}
		}

		// Token: 0x170013A5 RID: 5029
		// (get) Token: 0x06004FDC RID: 20444 RVA: 0x0017FAB0 File Offset: 0x0017DCB0
		public int PreLevel
		{
			get
			{
				return this.Config.PreLevel;
			}
		}

		// Token: 0x170013A6 RID: 5030
		// (get) Token: 0x06004FDD RID: 20445 RVA: 0x0017FAC0 File Offset: 0x0017DCC0
		public int EnergySuccess
		{
			get
			{
				return this.Config.EnergySuccess;
			}
		}

		// Token: 0x170013A7 RID: 5031
		// (get) Token: 0x06004FDE RID: 20446 RVA: 0x0017FAD0 File Offset: 0x0017DCD0
		public int EnergyFail
		{
			get
			{
				return this.Config.EnergyFail;
			}
		}

		// Token: 0x170013A8 RID: 5032
		// (get) Token: 0x06004FDF RID: 20447 RVA: 0x0017FAE0 File Offset: 0x0017DCE0
		public int MonsterLevel
		{
			get
			{
				return this.Config.MonsterLevel;
			}
		}

		// Token: 0x170013A9 RID: 5033
		// (get) Token: 0x06004FE0 RID: 20448 RVA: 0x0017FAF0 File Offset: 0x0017DCF0
		public ConfigDataBattleInfo BattleInfo
		{
			get
			{
				return this.Config.m_battleInfo;
			}
		}

		// Token: 0x170013AA RID: 5034
		// (get) Token: 0x06004FE1 RID: 20449 RVA: 0x0017FB00 File Offset: 0x0017DD00
		public int UserExp
		{
			get
			{
				return this.Config.PlayerExp;
			}
		}

		// Token: 0x170013AB RID: 5035
		// (get) Token: 0x06004FE2 RID: 20450 RVA: 0x0017FB10 File Offset: 0x0017DD10
		public int HeroExp
		{
			get
			{
				return this.Config.HeroExp;
			}
		}

		// Token: 0x170013AC RID: 5036
		// (get) Token: 0x06004FE3 RID: 20451 RVA: 0x0017FB20 File Offset: 0x0017DD20
		public int GoldBonus
		{
			get
			{
				return this.Config.Gold;
			}
		}

		// Token: 0x170013AD RID: 5037
		// (get) Token: 0x06004FE4 RID: 20452 RVA: 0x0017FB30 File Offset: 0x0017DD30
		public int RandomDropID
		{
			get
			{
				return this.Config.DropID;
			}
		}

		// Token: 0x170013AE RID: 5038
		// (get) Token: 0x06004FE5 RID: 20453 RVA: 0x0017FB40 File Offset: 0x0017DD40
		public List<Goods> FirstClearDropItems
		{
			get
			{
				return this.Config.FirstClearDropItems;
			}
		}

		// Token: 0x170013AF RID: 5039
		// (get) Token: 0x06004FE6 RID: 20454 RVA: 0x0017FB50 File Offset: 0x0017DD50
		public BattleLevelAchievement[] Achievements
		{
			get
			{
				return this.Config.m_achievements;
			}
		}

		// Token: 0x170013B0 RID: 5040
		// (get) Token: 0x06004FE7 RID: 20455 RVA: 0x0017FB60 File Offset: 0x0017DD60
		// (set) Token: 0x06004FE8 RID: 20456 RVA: 0x0017FB68 File Offset: 0x0017DD68
		public IConfigDataLoader ConfigDataLoader { get; set; }

		// Token: 0x170013B1 RID: 5041
		// (get) Token: 0x06004FE9 RID: 20457 RVA: 0x0017FB74 File Offset: 0x0017DD74
		public ConfigDataHeroPhantomLevelInfo Config
		{
			get
			{
				return this.ConfigDataLoader.GetConfigDataHeroPhantomLevelInfo(this.ID);
			}
		}

		// Token: 0x170013B2 RID: 5042
		// (get) Token: 0x06004FEA RID: 20458 RVA: 0x0017FB88 File Offset: 0x0017DD88
		public bool Cleared
		{
			get
			{
				return this.FirstClear < this.WhichPhantom.WhichCollection.Now();
			}
		}

		// Token: 0x170013B3 RID: 5043
		// (get) Token: 0x06004FEB RID: 20459 RVA: 0x0017FBAC File Offset: 0x0017DDAC
		public bool IsAvailableForChallenge
		{
			get
			{
				int LevelId = this.PreLevel;
				for (;;)
				{
					HeroPhantomLevel heroPhantomLevel = this.WhichPhantom.Levels.Find((HeroPhantomLevel l) => l.ID == LevelId);
					if (heroPhantomLevel == null)
					{
						break;
					}
					if (!heroPhantomLevel.Cleared)
					{
						return false;
					}
					LevelId = heroPhantomLevel.PreLevel;
				}
				return true;
			}
		}

		// Token: 0x040039E2 RID: 14818
		public DateTime FirstClear = DateTime.MaxValue;

		// Token: 0x040039E3 RID: 14819
		public List<int> AchievementIdsFinished = new List<int>();

		// Token: 0x040039E4 RID: 14820
		public HeroPhantom WhichPhantom;
	}
}
