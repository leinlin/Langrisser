using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200044D RID: 1101
	[HotFix]
	public class CooperateBattleCompomentCommon : IComponentBase
	{
		// Token: 0x06003FF3 RID: 16371 RVA: 0x0012884C File Offset: 0x00126A4C
		public CooperateBattleCompomentCommon()
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

		// Token: 0x06003FF4 RID: 16372 RVA: 0x001288C0 File Offset: 0x00126AC0
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
			return "CooperateBattle";
		}

		// Token: 0x06003FF5 RID: 16373 RVA: 0x00128934 File Offset: 0x00126B34
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

		// Token: 0x06003FF6 RID: 16374 RVA: 0x00128994 File Offset: 0x00126B94
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
			this.m_hero = (this.Owner.GetOwnerComponent("Hero") as HeroComponentCommon);
			this.m_battle = (this.Owner.GetOwnerComponent("Battle") as BattleComponentCommon);
			this.m_rift = (this.Owner.GetOwnerComponent("Rift") as RiftComponentCommon);
			this.m_cooperateBattleDS.BattleCollections.GetLevel = new GetUserLevel(this.m_basicInfo.GetLevel);
			this.m_cooperateBattleDS.BattleCollections.Now = new CurrentTime(this.m_basicInfo.GetCurrentTime);
			this.m_basicInfo.PlayerActionFlushEvent += this.FlushChallengNums;
		}

		// Token: 0x06003FF7 RID: 16375 RVA: 0x00128AD8 File Offset: 0x00126CD8
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

		// Token: 0x06003FF8 RID: 16376 RVA: 0x00128B38 File Offset: 0x00126D38
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

		// Token: 0x06003FF9 RID: 16377 RVA: 0x00128BA8 File Offset: 0x00126DA8
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

		// Token: 0x06003FFA RID: 16378 RVA: 0x00128C28 File Offset: 0x00126E28
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

		// Token: 0x06003FFB RID: 16379 RVA: 0x00128C98 File Offset: 0x00126E98
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

		// Token: 0x17001116 RID: 4374
		// (get) Token: 0x06003FFC RID: 16380 RVA: 0x00128CF8 File Offset: 0x00126EF8
		// (set) Token: 0x06003FFD RID: 16381 RVA: 0x00128D6C File Offset: 0x00126F6C
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

		// Token: 0x06003FFE RID: 16382 RVA: 0x00128DE4 File Offset: 0x00126FE4
		public bool CheckCooperateBattleAvailable(int CooperateBattleID, ref int Err)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckCooperateBattleAvailableInt32Int32__hotfix != null)
			{
				return LuaDelegation.Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon_CheckCooperateBattleAvailable_Int32_Int32(this, this.m_CheckCooperateBattleAvailableInt32Int32__hotfix, CooperateBattleID, ref Err);
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_cooperateBattleDS.GetCooperateBattle(CooperateBattleID).IsAvailableForChallenge)
			{
				Err = -4500;
				return false;
			}
			return true;
		}

		// Token: 0x06003FFF RID: 16383 RVA: 0x00128E60 File Offset: 0x00127060
		public bool CheckCooperateBattleDisplayable(int CooperateBattleID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckCooperateBattleDisplayableInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CheckCooperateBattleDisplayableInt32_hotfix.call(new object[]
				{
					this,
					CooperateBattleID
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_cooperateBattleDS.GetCooperateBattle(CooperateBattleID).IsAvailableForDisplay;
		}

		// Token: 0x06004000 RID: 16384 RVA: 0x00128EF0 File Offset: 0x001270F0
		public bool IsLevelUnlocked(int LevelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsLevelUnlockedInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsLevelUnlockedInt32_hotfix.call(new object[]
				{
					this,
					LevelId2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int LevelId = LevelId2;
			if (!this.IsGameFunctionOpened())
			{
				return false;
			}
			foreach (CooperateBattle cooperateBattle in this.m_cooperateBattleDS.BattleCollections.Battles)
			{
				if (cooperateBattle.IsAvailableForChallenge && cooperateBattle.Levels.Find((CooperateBattleLevel l) => l.ID == LevelId && l.IsAvailableForChallenge) != null)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06004001 RID: 16385 RVA: 0x0012900C File Offset: 0x0012720C
		public bool IsLevelFinished(int LevelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsLevelFinishedInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsLevelFinishedInt32_hotfix.call(new object[]
				{
					this,
					LevelId2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int LevelId = LevelId2;
			foreach (CooperateBattle cooperateBattle in this.m_cooperateBattleDS.BattleCollections.Battles)
			{
				if (cooperateBattle.Levels.Find((CooperateBattleLevel l) => l.ID == LevelId && l.Cleared) != null)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06004002 RID: 16386 RVA: 0x00129110 File Offset: 0x00127310
		public List<int> GetAllUnlockedLevels()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllUnlockedLevels_hotfix != null)
			{
				return (List<int>)this.m_GetAllUnlockedLevels_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<int> list = new List<int>();
			foreach (CooperateBattle cooperateBattle in this.m_cooperateBattleDS.BattleCollections.Battles)
			{
				if (cooperateBattle.IsAvailableForChallenge)
				{
					foreach (CooperateBattleLevel cooperateBattleLevel in cooperateBattle.Levels)
					{
						if (cooperateBattleLevel.IsAvailableForChallenge)
						{
							list.Add(cooperateBattleLevel.ID);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06004003 RID: 16387 RVA: 0x00129244 File Offset: 0x00127444
		public List<int> GetAllFinishedLevels()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllFinishedLevels_hotfix != null)
			{
				return (List<int>)this.m_GetAllFinishedLevels_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<int> list = new List<int>();
			foreach (CooperateBattle cooperateBattle in this.m_cooperateBattleDS.BattleCollections.Battles)
			{
				foreach (CooperateBattleLevel cooperateBattleLevel in cooperateBattle.Levels)
				{
					if (cooperateBattleLevel.Cleared)
					{
						list.Add(cooperateBattleLevel.ID);
					}
				}
			}
			return list;
		}

		// Token: 0x06004004 RID: 16388 RVA: 0x00129368 File Offset: 0x00127568
		private void FlushChallengNums()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FlushChallengNums_hotfix != null)
			{
				this.m_FlushChallengNums_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_cooperateBattleDS.SetChallengedNums(0);
		}

		// Token: 0x06004005 RID: 16389 RVA: 0x001293D4 File Offset: 0x001275D4
		public int GetDailyChallengeNums(int BattleId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDailyChallengeNumsInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetDailyChallengeNumsInt32_hotfix.call(new object[]
				{
					this,
					BattleId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int dailyBonusMaxNums = this.m_battle.GetDailyBonusMaxNums(GameFunctionType.GameFunctionType_CooperateBattle);
			CooperateBattle cooperateBattle = this.m_cooperateBattleDS.GetCooperateBattle(BattleId);
			int num = (cooperateBattle != null) ? cooperateBattle.ChallengedNums : 0;
			if (dailyBonusMaxNums > num)
			{
				return dailyBonusMaxNums - num;
			}
			return 0;
		}

		// Token: 0x06004006 RID: 16390 RVA: 0x0012948C File Offset: 0x0012768C
		public bool CheckCooperateBattleLevelAvailable(int BattleId, int LevelId, ref int Err)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckCooperateBattleLevelAvailableInt32Int32Int32__hotfix != null)
			{
				return LuaDelegation.Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon_CheckCooperateBattleLevelAvailable_Int32_Int32_Int32(this, this.m_CheckCooperateBattleLevelAvailableInt32Int32Int32__hotfix, BattleId, LevelId, ref Err);
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_cooperateBattleDS.GetCooperateBattleLevel(BattleId, LevelId).IsAvailableForChallenge)
			{
				Err = -4501;
				return false;
			}
			return true;
		}

		// Token: 0x06004007 RID: 16391 RVA: 0x0012950C File Offset: 0x0012770C
		public bool CheckPlayerOutOfBattle(ref int Err)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckPlayerOutOfBattleInt32__hotfix != null)
			{
				return LuaDelegation.Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon_CheckPlayerOutOfBattle_Int32(this, this.m_CheckPlayerOutOfBattleInt32__hotfix, ref Err);
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_battle.IsFighting())
			{
				Err = -900;
				return false;
			}
			return true;
		}

		// Token: 0x06004008 RID: 16392 RVA: 0x00129584 File Offset: 0x00127784
		public bool CheckEnergy(int BattleId, int LevelId, ref int Err)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckEnergyInt32Int32Int32__hotfix != null)
			{
				return LuaDelegation.Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon_CheckEnergy_Int32_Int32_Int32(this, this.m_CheckEnergyInt32Int32Int32__hotfix, BattleId, LevelId, ref Err);
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CooperateBattleLevel cooperateBattleLevel = this.m_cooperateBattleDS.GetCooperateBattleLevel(BattleId, LevelId);
			if (!this.m_basicInfo.IsEnergyEnough(cooperateBattleLevel.EnergySuccess))
			{
				Err = -402;
				return false;
			}
			return true;
		}

		// Token: 0x06004009 RID: 16393 RVA: 0x00129610 File Offset: 0x00127810
		public bool CheckBag(int CooperateBattleId, int LevelId, ref int Err)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckBagInt32Int32Int32__hotfix != null)
			{
				return LuaDelegation.Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon_CheckBag_Int32_Int32_Int32(this, this.m_CheckBagInt32Int32Int32__hotfix, CooperateBattleId, LevelId, ref Err);
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_bag.IsBagFullByCurrentSize())
			{
				Err = -500;
				return false;
			}
			return true;
		}

		// Token: 0x0600400A RID: 16394 RVA: 0x00129688 File Offset: 0x00127888
		public int CanAttackCooperateBattleLevel(int BattleId, int LevelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAttackCooperateBattleLevelInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAttackCooperateBattleLevelInt32Int32_hotfix.call(new object[]
				{
					this,
					BattleId,
					LevelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int result = 0;
			if (this.CheckCooperateBattleAvailable(BattleId, ref result) && this.CheckCooperateBattleLevelAvailable(BattleId, LevelId, ref result) && this.CheckPlayerOutOfBattle(ref result) && this.CheckEnergy(BattleId, LevelId, ref result) && this.CheckBag(BattleId, LevelId, ref result))
			{
				return result;
			}
			return result;
		}

		// Token: 0x0600400B RID: 16395 RVA: 0x00129764 File Offset: 0x00127964
		private bool IsGameFunctionOpened()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsGameFunctionOpened_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsGameFunctionOpened_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_basicInfo.IsGameFunctionOpened(GameFunctionType.GameFunctionType_CooperateBattle);
		}

		// Token: 0x0600400C RID: 16396 RVA: 0x001297E0 File Offset: 0x001279E0
		public virtual int CanAttackCooperateBattleLevel(int LevelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAttackCooperateBattleLevelInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAttackCooperateBattleLevelInt32_hotfix.call(new object[]
				{
					this,
					LevelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsGameFunctionOpened())
			{
				return -4503;
			}
			CooperateBattleLevel firstCooperateBattleLevel = this.m_cooperateBattleDS.GetFirstCooperateBattleLevel(LevelId, true);
			int result = 0;
			if (firstCooperateBattleLevel == null)
			{
				result = -4501;
			}
			else
			{
				int id = firstCooperateBattleLevel.WhichCooperateBattle.ID;
				if (this.CheckCooperateBattleAvailable(id, ref result) && this.CheckCooperateBattleLevelAvailable(id, LevelId, ref result) && this.CheckPlayerOutOfBattle(ref result) && this.CheckEnergy(id, LevelId, ref result) && this.CheckBag(id, LevelId, ref result))
				{
					return result;
				}
			}
			return result;
		}

		// Token: 0x0600400D RID: 16397 RVA: 0x001298E8 File Offset: 0x00127AE8
		public void SetCommonSuccessCooperateBattleLevel(ConfigDataCooperateBattleLevelInfo Level, List<int> Heroes, List<int> BattleTreasures)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCommonSuccessCooperateBattleLevelConfigDataCooperateBattleLevelInfoList`1List`1_hotfix != null)
			{
				this.m_SetCommonSuccessCooperateBattleLevelConfigDataCooperateBattleLevelInfoList`1List`1_hotfix.call(new object[]
				{
					this,
					Level,
					Heroes,
					BattleTreasures
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battle.AddBattleTreasures(BattleTreasures);
			this.m_basicInfo.AddPlayerExp(Level.PlayerExp);
			this.m_battle.AddFightHeroFightNumsAndExp(Heroes, Level.HeroExp);
			this.m_basicInfo.AddGold(Level.Gold, GameFunctionType.GameFunctionType_CooperateBattle, Level.ID.ToString());
			int num = Level.EnergySuccess - Level.EnergyFail;
			if (num > 0)
			{
				this.m_basicInfo.DecreaseEnergy(num, GameFunctionType.GameFunctionType_HeroPhantom, Level.ID.ToString());
			}
			this.m_battle.WinPveBattle(Level.Battle_ID);
			CooperateBattleLevel firstCooperateBattleLevel = this.m_cooperateBattleDS.GetFirstCooperateBattleLevel(Level.ID, false);
			if (firstCooperateBattleLevel != null && this.GetDailyChallengeNums(firstCooperateBattleLevel.WhichCooperateBattle.ID) > 0)
			{
				this.m_cooperateBattleDS.IncreaseChallengedNums(firstCooperateBattleLevel.WhichCooperateBattle.ID, 1);
			}
			this.FinishedCooperateBattleLevel(firstCooperateBattleLevel, Heroes);
		}

		// Token: 0x0600400E RID: 16398 RVA: 0x00129A68 File Offset: 0x00127C68
		protected virtual void FinishedCooperateBattleLevel(CooperateBattleLevel Level, List<int> heroes)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FinishedCooperateBattleLevelCooperateBattleLevelList`1_hotfix != null)
			{
				this.m_FinishedCooperateBattleLevelCooperateBattleLevelList`1_hotfix.call(new object[]
				{
					this,
					Level,
					heroes
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!Level.Cleared)
			{
				Level.FirstClear = this.m_basicInfo.GetCurrentTime();
			}
			if (this.CompleteCooperateBattleMissionEvent != null)
			{
				this.CompleteCooperateBattleMissionEvent(BattleType.CooperateBattle, Level.ID, heroes);
			}
		}

		// Token: 0x17001117 RID: 4375
		// (get) Token: 0x0600400F RID: 16399 RVA: 0x00129B24 File Offset: 0x00127D24
		// (set) Token: 0x06004010 RID: 16400 RVA: 0x00129B98 File Offset: 0x00127D98
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
					CooperateBattleCollections battleCollections = this.m_cooperateBattleDS.BattleCollections;
					this._configDataLoader = value;
					battleCollections.ConfigDataLoader = value;
				}
				else
				{
					this._configDataLoader = value;
				}
			}
		}

		// Token: 0x14000033 RID: 51
		// (add) Token: 0x06004011 RID: 16401 RVA: 0x00129C3C File Offset: 0x00127E3C
		// (remove) Token: 0x06004012 RID: 16402 RVA: 0x00129CD8 File Offset: 0x00127ED8
		public event Action<BattleType, int, List<int>> CompleteCooperateBattleMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_CompleteCooperateBattleMissionEventAction`3_hotfix != null)
				{
					this.m_add_CompleteCooperateBattleMissionEventAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleType, int, List<int>> action = this.CompleteCooperateBattleMissionEvent;
				Action<BattleType, int, List<int>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleType, int, List<int>>>(ref this.CompleteCooperateBattleMissionEvent, (Action<BattleType, int, List<int>>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_CompleteCooperateBattleMissionEventAction`3_hotfix != null)
				{
					this.m_remove_CompleteCooperateBattleMissionEventAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleType, int, List<int>> action = this.CompleteCooperateBattleMissionEvent;
				Action<BattleType, int, List<int>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleType, int, List<int>>>(ref this.CompleteCooperateBattleMissionEvent, (Action<BattleType, int, List<int>>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17001118 RID: 4376
		// (get) Token: 0x06004013 RID: 16403 RVA: 0x00129D74 File Offset: 0x00127F74
		// (set) Token: 0x06004014 RID: 16404 RVA: 0x00129D94 File Offset: 0x00127F94
		[DoNotToLua]
		public CooperateBattleCompomentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new CooperateBattleCompomentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06004015 RID: 16405 RVA: 0x00129DA0 File Offset: 0x00127FA0
		private void __callDele_CompleteCooperateBattleMissionEvent(BattleType arg1, int arg2, List<int> arg3)
		{
			Action<BattleType, int, List<int>> completeCooperateBattleMissionEvent = this.CompleteCooperateBattleMissionEvent;
			if (completeCooperateBattleMissionEvent != null)
			{
				completeCooperateBattleMissionEvent(arg1, arg2, arg3);
			}
		}

		// Token: 0x06004016 RID: 16406 RVA: 0x00129DC4 File Offset: 0x00127FC4
		private void __clearDele_CompleteCooperateBattleMissionEvent(BattleType arg1, int arg2, List<int> arg3)
		{
			this.CompleteCooperateBattleMissionEvent = null;
		}

		// Token: 0x06004017 RID: 16407 RVA: 0x00129DD0 File Offset: 0x00127FD0
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
					this.m_CheckCooperateBattleAvailableInt32Int32__hotfix = (luaObj.RawGet("CheckCooperateBattleAvailable") as LuaFunction);
					this.m_CheckCooperateBattleDisplayableInt32_hotfix = (luaObj.RawGet("CheckCooperateBattleDisplayable") as LuaFunction);
					this.m_IsLevelUnlockedInt32_hotfix = (luaObj.RawGet("IsLevelUnlocked") as LuaFunction);
					this.m_IsLevelFinishedInt32_hotfix = (luaObj.RawGet("IsLevelFinished") as LuaFunction);
					this.m_GetAllUnlockedLevels_hotfix = (luaObj.RawGet("GetAllUnlockedLevels") as LuaFunction);
					this.m_GetAllFinishedLevels_hotfix = (luaObj.RawGet("GetAllFinishedLevels") as LuaFunction);
					this.m_FlushChallengNums_hotfix = (luaObj.RawGet("FlushChallengNums") as LuaFunction);
					this.m_GetDailyChallengeNumsInt32_hotfix = (luaObj.RawGet("GetDailyChallengeNums") as LuaFunction);
					this.m_CheckCooperateBattleLevelAvailableInt32Int32Int32__hotfix = (luaObj.RawGet("CheckCooperateBattleLevelAvailable") as LuaFunction);
					this.m_CheckPlayerOutOfBattleInt32__hotfix = (luaObj.RawGet("CheckPlayerOutOfBattle") as LuaFunction);
					this.m_CheckEnergyInt32Int32Int32__hotfix = (luaObj.RawGet("CheckEnergy") as LuaFunction);
					this.m_CheckBagInt32Int32Int32__hotfix = (luaObj.RawGet("CheckBag") as LuaFunction);
					this.m_CanAttackCooperateBattleLevelInt32Int32_hotfix = (luaObj.RawGet("CanAttackCooperateBattleLevel") as LuaFunction);
					this.m_IsGameFunctionOpened_hotfix = (luaObj.RawGet("IsGameFunctionOpened") as LuaFunction);
					this.m_CanAttackCooperateBattleLevelInt32_hotfix = (luaObj.RawGet("CanAttackCooperateBattleLevel") as LuaFunction);
					this.m_SetCommonSuccessCooperateBattleLevelConfigDataCooperateBattleLevelInfoList`1List`1_hotfix = (luaObj.RawGet("SetCommonSuccessCooperateBattleLevel") as LuaFunction);
					this.m_FinishedCooperateBattleLevelCooperateBattleLevelList`1_hotfix = (luaObj.RawGet("FinishedCooperateBattleLevel") as LuaFunction);
					this.m_get_m_configDataLoader_hotfix = (luaObj.RawGet("get_m_configDataLoader") as LuaFunction);
					this.m_set_m_configDataLoaderIConfigDataLoader_hotfix = (luaObj.RawGet("set_m_configDataLoader") as LuaFunction);
					this.m_add_CompleteCooperateBattleMissionEventAction`3_hotfix = (luaObj.RawGet("add_CompleteCooperateBattleMissionEvent") as LuaFunction);
					this.m_remove_CompleteCooperateBattleMissionEventAction`3_hotfix = (luaObj.RawGet("remove_CompleteCooperateBattleMissionEvent") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06004018 RID: 16408 RVA: 0x0012A1A4 File Offset: 0x001283A4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CooperateBattleCompomentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040030C1 RID: 12481
		private IConfigDataLoader _configDataLoader;

		// Token: 0x040030C2 RID: 12482
		protected DataSectionCooperateBattle m_cooperateBattleDS = new DataSectionCooperateBattle();

		// Token: 0x040030C3 RID: 12483
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x040030C4 RID: 12484
		protected BattleComponentCommon m_battle;

		// Token: 0x040030C5 RID: 12485
		protected BagComponentCommon m_bag;

		// Token: 0x040030C6 RID: 12486
		protected HeroComponentCommon m_hero;

		// Token: 0x040030C7 RID: 12487
		protected RiftComponentCommon m_rift;

		// Token: 0x040030C9 RID: 12489
		[DoNotToLua]
		private CooperateBattleCompomentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x040030CA RID: 12490
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040030CB RID: 12491
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040030CC RID: 12492
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040030CD RID: 12493
		private LuaFunction m_GetName_hotfix;

		// Token: 0x040030CE RID: 12494
		private LuaFunction m_Init_hotfix;

		// Token: 0x040030CF RID: 12495
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x040030D0 RID: 12496
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x040030D1 RID: 12497
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x040030D2 RID: 12498
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x040030D3 RID: 12499
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x040030D4 RID: 12500
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x040030D5 RID: 12501
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x040030D6 RID: 12502
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x040030D7 RID: 12503
		private LuaFunction m_CheckCooperateBattleAvailableInt32Int32__hotfix;

		// Token: 0x040030D8 RID: 12504
		private LuaFunction m_CheckCooperateBattleDisplayableInt32_hotfix;

		// Token: 0x040030D9 RID: 12505
		private LuaFunction m_IsLevelUnlockedInt32_hotfix;

		// Token: 0x040030DA RID: 12506
		private LuaFunction m_IsLevelFinishedInt32_hotfix;

		// Token: 0x040030DB RID: 12507
		private LuaFunction m_GetAllUnlockedLevels_hotfix;

		// Token: 0x040030DC RID: 12508
		private LuaFunction m_GetAllFinishedLevels_hotfix;

		// Token: 0x040030DD RID: 12509
		private LuaFunction m_FlushChallengNums_hotfix;

		// Token: 0x040030DE RID: 12510
		private LuaFunction m_GetDailyChallengeNumsInt32_hotfix;

		// Token: 0x040030DF RID: 12511
		private LuaFunction m_CheckCooperateBattleLevelAvailableInt32Int32Int32__hotfix;

		// Token: 0x040030E0 RID: 12512
		private LuaFunction m_CheckPlayerOutOfBattleInt32__hotfix;

		// Token: 0x040030E1 RID: 12513
		private LuaFunction m_CheckEnergyInt32Int32Int32__hotfix;

		// Token: 0x040030E2 RID: 12514
		private LuaFunction m_CheckBagInt32Int32Int32__hotfix;

		// Token: 0x040030E3 RID: 12515
		private LuaFunction m_CanAttackCooperateBattleLevelInt32Int32_hotfix;

		// Token: 0x040030E4 RID: 12516
		private LuaFunction m_IsGameFunctionOpened_hotfix;

		// Token: 0x040030E5 RID: 12517
		private LuaFunction m_CanAttackCooperateBattleLevelInt32_hotfix;

		// Token: 0x040030E6 RID: 12518
		private LuaFunction m_SetCommonSuccessCooperateBattleLevelConfigDataCooperateBattleLevelInfoList`1List;

		// Token: 0x040030E7 RID: 12519
		private LuaFunction m_FinishedCooperateBattleLevelCooperateBattleLevelList;

		// Token: 0x040030E8 RID: 12520
		private LuaFunction m_get_m_configDataLoader_hotfix;

		// Token: 0x040030E9 RID: 12521
		private LuaFunction m_set_m_configDataLoaderIConfigDataLoader_hotfix;

		// Token: 0x040030EA RID: 12522
		private LuaFunction m_add_CompleteCooperateBattleMissionEventAction;

		// Token: 0x040030EB RID: 12523
		private LuaFunction m_remove_CompleteCooperateBattleMissionEventAction;

		// Token: 0x0200044E RID: 1102
		public class LuaExportHelper
		{
			// Token: 0x06004019 RID: 16409 RVA: 0x0012A20C File Offset: 0x0012840C
			public LuaExportHelper(CooperateBattleCompomentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600401A RID: 16410 RVA: 0x0012A21C File Offset: 0x0012841C
			public void __callDele_CompleteCooperateBattleMissionEvent(BattleType arg1, int arg2, List<int> arg3)
			{
				this.m_owner.__callDele_CompleteCooperateBattleMissionEvent(arg1, arg2, arg3);
			}

			// Token: 0x0600401B RID: 16411 RVA: 0x0012A22C File Offset: 0x0012842C
			public void __clearDele_CompleteCooperateBattleMissionEvent(BattleType arg1, int arg2, List<int> arg3)
			{
				this.m_owner.__clearDele_CompleteCooperateBattleMissionEvent(arg1, arg2, arg3);
			}

			// Token: 0x17001119 RID: 4377
			// (get) Token: 0x0600401C RID: 16412 RVA: 0x0012A23C File Offset: 0x0012843C
			// (set) Token: 0x0600401D RID: 16413 RVA: 0x0012A24C File Offset: 0x0012844C
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

			// Token: 0x1700111A RID: 4378
			// (get) Token: 0x0600401E RID: 16414 RVA: 0x0012A25C File Offset: 0x0012845C
			// (set) Token: 0x0600401F RID: 16415 RVA: 0x0012A26C File Offset: 0x0012846C
			public DataSectionCooperateBattle m_cooperateBattleDS
			{
				get
				{
					return this.m_owner.m_cooperateBattleDS;
				}
				set
				{
					this.m_owner.m_cooperateBattleDS = value;
				}
			}

			// Token: 0x1700111B RID: 4379
			// (get) Token: 0x06004020 RID: 16416 RVA: 0x0012A27C File Offset: 0x0012847C
			// (set) Token: 0x06004021 RID: 16417 RVA: 0x0012A28C File Offset: 0x0012848C
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

			// Token: 0x1700111C RID: 4380
			// (get) Token: 0x06004022 RID: 16418 RVA: 0x0012A29C File Offset: 0x0012849C
			// (set) Token: 0x06004023 RID: 16419 RVA: 0x0012A2AC File Offset: 0x001284AC
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

			// Token: 0x1700111D RID: 4381
			// (get) Token: 0x06004024 RID: 16420 RVA: 0x0012A2BC File Offset: 0x001284BC
			// (set) Token: 0x06004025 RID: 16421 RVA: 0x0012A2CC File Offset: 0x001284CC
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

			// Token: 0x1700111E RID: 4382
			// (get) Token: 0x06004026 RID: 16422 RVA: 0x0012A2DC File Offset: 0x001284DC
			// (set) Token: 0x06004027 RID: 16423 RVA: 0x0012A2EC File Offset: 0x001284EC
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

			// Token: 0x1700111F RID: 4383
			// (get) Token: 0x06004028 RID: 16424 RVA: 0x0012A2FC File Offset: 0x001284FC
			// (set) Token: 0x06004029 RID: 16425 RVA: 0x0012A30C File Offset: 0x0012850C
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

			// Token: 0x17001120 RID: 4384
			// (get) Token: 0x0600402A RID: 16426 RVA: 0x0012A31C File Offset: 0x0012851C
			// (set) Token: 0x0600402B RID: 16427 RVA: 0x0012A32C File Offset: 0x0012852C
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

			// Token: 0x0600402C RID: 16428 RVA: 0x0012A33C File Offset: 0x0012853C
			public void FlushChallengNums()
			{
				this.m_owner.FlushChallengNums();
			}

			// Token: 0x0600402D RID: 16429 RVA: 0x0012A34C File Offset: 0x0012854C
			public bool IsGameFunctionOpened()
			{
				return this.m_owner.IsGameFunctionOpened();
			}

			// Token: 0x0600402E RID: 16430 RVA: 0x0012A35C File Offset: 0x0012855C
			public void FinishedCooperateBattleLevel(CooperateBattleLevel Level, List<int> heroes)
			{
				this.m_owner.FinishedCooperateBattleLevel(Level, heroes);
			}

			// Token: 0x040030EC RID: 12524
			private CooperateBattleCompomentCommon m_owner;
		}
	}
}
