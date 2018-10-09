using System;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000534 RID: 1332
	[CustomLuaClass]
	public class CooperateBattleLevel
	{
		// Token: 0x1700135C RID: 4956
		// (get) Token: 0x06004F34 RID: 20276 RVA: 0x0017E544 File Offset: 0x0017C744
		// (set) Token: 0x06004F35 RID: 20277 RVA: 0x0017E54C File Offset: 0x0017C74C
		public int ID { get; set; }

		// Token: 0x1700135D RID: 4957
		// (get) Token: 0x06004F36 RID: 20278 RVA: 0x0017E558 File Offset: 0x0017C758
		public string Name
		{
			get
			{
				return this.Config.Name;
			}
		}

		// Token: 0x1700135E RID: 4958
		// (get) Token: 0x06004F37 RID: 20279 RVA: 0x0017E568 File Offset: 0x0017C768
		public int PlayerLevelRequirement
		{
			get
			{
				return this.Config.PlayerLevelRequired;
			}
		}

		// Token: 0x1700135F RID: 4959
		// (get) Token: 0x06004F38 RID: 20280 RVA: 0x0017E578 File Offset: 0x0017C778
		public int EnergySuccess
		{
			get
			{
				return this.Config.EnergySuccess;
			}
		}

		// Token: 0x17001360 RID: 4960
		// (get) Token: 0x06004F39 RID: 20281 RVA: 0x0017E588 File Offset: 0x0017C788
		public int EnergyFail
		{
			get
			{
				return this.Config.EnergyFail;
			}
		}

		// Token: 0x17001361 RID: 4961
		// (get) Token: 0x06004F3A RID: 20282 RVA: 0x0017E598 File Offset: 0x0017C798
		public int MonsterLevel
		{
			get
			{
				return this.Config.MonsterLevel;
			}
		}

		// Token: 0x17001362 RID: 4962
		// (get) Token: 0x06004F3B RID: 20283 RVA: 0x0017E5A8 File Offset: 0x0017C7A8
		public int BattleID
		{
			get
			{
				return this.Config.Battle_ID;
			}
		}

		// Token: 0x17001363 RID: 4963
		// (get) Token: 0x06004F3C RID: 20284 RVA: 0x0017E5B8 File Offset: 0x0017C7B8
		public int UserExp
		{
			get
			{
				return this.Config.PlayerExp;
			}
		}

		// Token: 0x17001364 RID: 4964
		// (get) Token: 0x06004F3D RID: 20285 RVA: 0x0017E5C8 File Offset: 0x0017C7C8
		public int HeroExp
		{
			get
			{
				return this.Config.HeroExp;
			}
		}

		// Token: 0x17001365 RID: 4965
		// (get) Token: 0x06004F3E RID: 20286 RVA: 0x0017E5D8 File Offset: 0x0017C7D8
		public int GoldBonus
		{
			get
			{
				return this.Config.Gold;
			}
		}

		// Token: 0x17001366 RID: 4966
		// (get) Token: 0x06004F3F RID: 20287 RVA: 0x0017E5E8 File Offset: 0x0017C7E8
		public int RandomDropID
		{
			get
			{
				return this.Config.DropID;
			}
		}

		// Token: 0x17001367 RID: 4967
		// (get) Token: 0x06004F40 RID: 20288 RVA: 0x0017E5F8 File Offset: 0x0017C7F8
		public int TeamRandomDropID
		{
			get
			{
				return this.Config.TeamDrop_ID;
			}
		}

		// Token: 0x17001368 RID: 4968
		// (get) Token: 0x06004F41 RID: 20289 RVA: 0x0017E608 File Offset: 0x0017C808
		public int ItemDropCountDisplay
		{
			get
			{
				return this.Config.ItemDropCountDisplay;
			}
		}

		// Token: 0x17001369 RID: 4969
		// (get) Token: 0x06004F42 RID: 20290 RVA: 0x0017E618 File Offset: 0x0017C818
		public int DayBonusDropID
		{
			get
			{
				return this.Config.DayBonusDrop_ID;
			}
		}

		// Token: 0x1700136A RID: 4970
		// (get) Token: 0x06004F43 RID: 20291 RVA: 0x0017E628 File Offset: 0x0017C828
		public bool Cleared
		{
			get
			{
				return this.FirstClear < this.WhichCooperateBattle.WhichBattleCollections.Now();
			}
		}

		// Token: 0x1700136B RID: 4971
		// (get) Token: 0x06004F44 RID: 20292 RVA: 0x0017E64C File Offset: 0x0017C84C
		public bool IsAvailableForChallenge
		{
			get
			{
				return this.WhichCooperateBattle.WhichBattleCollections.GetLevel() >= this.PlayerLevelRequirement;
			}
		}

		// Token: 0x1700136C RID: 4972
		// (get) Token: 0x06004F45 RID: 20293 RVA: 0x0017E670 File Offset: 0x0017C870
		// (set) Token: 0x06004F46 RID: 20294 RVA: 0x0017E678 File Offset: 0x0017C878
		public IConfigDataLoader ConfigDataLoader { get; set; }

		// Token: 0x1700136D RID: 4973
		// (get) Token: 0x06004F47 RID: 20295 RVA: 0x0017E684 File Offset: 0x0017C884
		public ConfigDataCooperateBattleLevelInfo Config
		{
			get
			{
				return this.ConfigDataLoader.GetConfigDataCooperateBattleLevelInfo(this.ID);
			}
		}

		// Token: 0x040039A5 RID: 14757
		public DateTime FirstClear = DateTime.MaxValue;

		// Token: 0x040039A6 RID: 14758
		public CooperateBattle WhichCooperateBattle;
	}
}
