using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000479 RID: 1145
	[HotFix]
	public class HeroPhantomCompomentCommon : IComponentBase
	{
		// Token: 0x0600432F RID: 17199 RVA: 0x00141DB4 File Offset: 0x0013FFB4
		public HeroPhantomCompomentCommon()
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

		// Token: 0x06004330 RID: 17200 RVA: 0x00141E28 File Offset: 0x00140028
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
			return "HeroPhantom";
		}

		// Token: 0x06004331 RID: 17201 RVA: 0x00141E9C File Offset: 0x0014009C
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

		// Token: 0x06004332 RID: 17202 RVA: 0x00141EFC File Offset: 0x001400FC
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
			this.m_heroPhantomDS.PhantomCollections.Now = new CurrentTime(this.m_basicInfo.GetCurrentTime);
		}

		// Token: 0x06004333 RID: 17203 RVA: 0x00142008 File Offset: 0x00140208
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

		// Token: 0x06004334 RID: 17204 RVA: 0x00142068 File Offset: 0x00140268
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

		// Token: 0x06004335 RID: 17205 RVA: 0x001420D8 File Offset: 0x001402D8
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

		// Token: 0x06004336 RID: 17206 RVA: 0x00142158 File Offset: 0x00140358
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

		// Token: 0x06004337 RID: 17207 RVA: 0x001421C8 File Offset: 0x001403C8
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

		// Token: 0x17001175 RID: 4469
		// (get) Token: 0x06004338 RID: 17208 RVA: 0x00142228 File Offset: 0x00140428
		// (set) Token: 0x06004339 RID: 17209 RVA: 0x0014229C File Offset: 0x0014049C
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

		// Token: 0x0600433A RID: 17210 RVA: 0x00142314 File Offset: 0x00140514
		public bool CheckHeroPhantomAvailable(int HeroPhantomId, ref int Err)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckHeroPhantomAvailableInt32Int32__hotfix != null)
			{
				return LuaDelegation.Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon_CheckHeroPhantomAvailable_Int32_Int32(this, this.m_CheckHeroPhantomAvailableInt32Int32__hotfix, HeroPhantomId, ref Err);
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_heroPhantomDS.GetHeroPhantom(HeroPhantomId).IsAvailableForChallenge)
			{
				Err = -4400;
				return false;
			}
			return true;
		}

		// Token: 0x0600433B RID: 17211 RVA: 0x00142390 File Offset: 0x00140590
		public bool CheckHeroPhantomLevelAvailable(int LevelId, ref int Err)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckHeroPhantomLevelAvailableInt32Int32__hotfix != null)
			{
				return LuaDelegation.Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon_CheckHeroPhantomLevelAvailable_Int32_Int32(this, this.m_CheckHeroPhantomLevelAvailableInt32Int32__hotfix, LevelId, ref Err);
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroPhantomLevel heroPhantomLevel = this.m_heroPhantomDS.GetHeroPhantomLevel(LevelId);
			if (heroPhantomLevel == null)
			{
				Err = -4402;
				return false;
			}
			if (!this.CheckHeroPhantomAvailable(heroPhantomLevel.WhichPhantom.ID, ref Err))
			{
				return false;
			}
			if (!heroPhantomLevel.IsAvailableForChallenge)
			{
				Err = -4401;
				return false;
			}
			return true;
		}

		// Token: 0x0600433C RID: 17212 RVA: 0x00142438 File Offset: 0x00140638
		public bool CheckPlayerOutOfBattle(ref int Err)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckPlayerOutOfBattleInt32__hotfix != null)
			{
				return LuaDelegation.Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon_CheckPlayerOutOfBattle_Int32(this, this.m_CheckPlayerOutOfBattleInt32__hotfix, ref Err);
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_battle.IsFighting())
			{
				Err = -900;
				return false;
			}
			return true;
		}

		// Token: 0x0600433D RID: 17213 RVA: 0x001424B0 File Offset: 0x001406B0
		public bool CheckEnergy(int LevelId, ref int Err)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckEnergyInt32Int32__hotfix != null)
			{
				return LuaDelegation.Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon_CheckEnergy_Int32_Int32(this, this.m_CheckEnergyInt32Int32__hotfix, LevelId, ref Err);
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroPhantomLevel heroPhantomLevel = this.m_heroPhantomDS.GetHeroPhantomLevel(LevelId);
			if (!this.m_basicInfo.IsEnergyEnough(heroPhantomLevel.EnergySuccess))
			{
				Err = -402;
				return false;
			}
			return true;
		}

		// Token: 0x0600433E RID: 17214 RVA: 0x0014253C File Offset: 0x0014073C
		public bool CheckBag(int LevelId, ref int Err)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckBagInt32Int32__hotfix != null)
			{
				return LuaDelegation.Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon_CheckBag_Int32_Int32(this, this.m_CheckBagInt32Int32__hotfix, LevelId, ref Err);
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_bag.IsBagFullByCurrentSize())
			{
				Err = -500;
				return false;
			}
			return true;
		}

		// Token: 0x0600433F RID: 17215 RVA: 0x001425B4 File Offset: 0x001407B4
		public virtual int CheckChallengeHeroPhantomLevel(int LevelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckChallengeHeroPhantomLevelInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CheckChallengeHeroPhantomLevelInt32_hotfix.call(new object[]
				{
					this,
					LevelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int result = 0;
			if (this.CheckHeroPhantomLevelAvailable(LevelId, ref result) && this.CheckPlayerOutOfBattle(ref result) && this.CheckEnergy(LevelId, ref result) && this.CheckBag(LevelId, ref result))
			{
				return result;
			}
			return result;
		}

		// Token: 0x06004340 RID: 17216 RVA: 0x0014266C File Offset: 0x0014086C
		public int ChallengeHeroPhantomLevel(int LevelId, bool NoCheck = false)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ChallengeHeroPhantomLevelInt32Boolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_ChallengeHeroPhantomLevelInt32Boolean_hotfix.call(new object[]
				{
					this,
					LevelId,
					NoCheck
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroPhantomLevel heroPhantomLevel = this.m_heroPhantomDS.GetHeroPhantomLevel(LevelId);
			if (!NoCheck)
			{
				int num = this.CheckChallengeHeroPhantomLevel(LevelId);
				if (num != 0)
				{
					if (num == -900)
					{
						this.m_battle.FightFinished(GameFunctionStatus.Error, false, true);
					}
					return num;
				}
			}
			this.m_basicInfo.DecreaseEnergy(heroPhantomLevel.EnergyFail, GameFunctionType.GameFunctionType_HeroPhantom, LevelId.ToString());
			this.m_battle.SetProcessingBattleInfo(BattleType.HeroPhantom, LevelId);
			return 0;
		}

		// Token: 0x06004341 RID: 17217 RVA: 0x00142768 File Offset: 0x00140968
		public void SetCommonSuccessHeroPhantomLevel(HeroPhantomLevel Level, List<int> Heroes, List<int> BattleTreasures, List<int> newAchievementIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCommonSuccessHeroPhantomLevelHeroPhantomLevelList`1List`1List`1_hotfix != null)
			{
				this.m_SetCommonSuccessHeroPhantomLevelHeroPhantomLevelList`1List`1List`1_hotfix.call(new object[]
				{
					this,
					Level,
					Heroes,
					BattleTreasures,
					newAchievementIds
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battle.AddBattleTreasures(BattleTreasures);
			this.m_basicInfo.AddPlayerExp(Level.UserExp);
			this.m_battle.AddFightHeroFightNumsAndExp(Heroes, Level.HeroExp);
			this.m_basicInfo.AddGold(Level.GoldBonus, GameFunctionType.GameFunctionType_HeroPhantom, Level.ID.ToString());
			int num = Level.EnergySuccess - Level.EnergyFail;
			if (num > 0)
			{
				this.m_basicInfo.DecreaseEnergy(num, GameFunctionType.GameFunctionType_HeroPhantom, Level.ID.ToString());
			}
			this.m_battle.WinPveBattle(this.m_battle.GetBattleId());
			this.FinishedHeroPhantomLevel(Level, Heroes);
			foreach (int num2 in newAchievementIds)
			{
				Level.AchievementIdsFinished.Add(num2);
				if (this.GetBattleAchievementMissionEvent != null)
				{
					this.GetBattleAchievementMissionEvent(num2);
				}
			}
		}

		// Token: 0x06004342 RID: 17218 RVA: 0x00142920 File Offset: 0x00140B20
		protected virtual void FinishedHeroPhantomLevel(HeroPhantomLevel Level, List<int> heroes)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FinishedHeroPhantomLevelHeroPhantomLevelList`1_hotfix != null)
			{
				this.m_FinishedHeroPhantomLevelHeroPhantomLevelList`1_hotfix.call(new object[]
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
			if (this.CompleteHeroPhantomMissionEvent != null)
			{
				this.CompleteHeroPhantomMissionEvent(BattleType.HeroPhantom, Level.ID, heroes);
			}
		}

		// Token: 0x06004343 RID: 17219 RVA: 0x001429DC File Offset: 0x00140BDC
		public HeroPhantom GetHeroPhantom(int HeroPhantomId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroPhantomInt32_hotfix != null)
			{
				return (HeroPhantom)this.m_GetHeroPhantomInt32_hotfix.call(new object[]
				{
					this,
					HeroPhantomId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroPhantomDS.GetHeroPhantom(HeroPhantomId);
		}

		// Token: 0x06004344 RID: 17220 RVA: 0x00142A64 File Offset: 0x00140C64
		public HeroPhantomLevel GetHeroPhantomLevel(int LevelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroPhantomLevelInt32_hotfix != null)
			{
				return (HeroPhantomLevel)this.m_GetHeroPhantomLevelInt32_hotfix.call(new object[]
				{
					this,
					LevelId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroPhantomDS.GetHeroPhantomLevel(LevelId);
		}

		// Token: 0x06004345 RID: 17221 RVA: 0x00142AEC File Offset: 0x00140CEC
		public bool IsCompleteHeroPhantomLevelAchievement(int achievementRelatedInfoID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsCompleteHeroPhantomLevelAchievementInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsCompleteHeroPhantomLevelAchievementInt32_hotfix.call(new object[]
				{
					this,
					achievementRelatedInfoID2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int achievementRelatedInfoID = achievementRelatedInfoID2;
			return this.m_heroPhantomDS.PhantomCollections.HeroPhantoms.Exists((HeroPhantom hp) => hp.Levels.Exists((HeroPhantomLevel hpl) => hpl.AchievementIdsFinished.Contains(achievementRelatedInfoID)));
		}

		// Token: 0x17001176 RID: 4470
		// (get) Token: 0x06004346 RID: 17222 RVA: 0x00142B98 File Offset: 0x00140D98
		// (set) Token: 0x06004347 RID: 17223 RVA: 0x00142C0C File Offset: 0x00140E0C
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
					HeroPhantomCollections phantomCollections = this.m_heroPhantomDS.PhantomCollections;
					this._configDataLoader = value;
					phantomCollections.ConfigDataLoader = value;
				}
				else
				{
					this._configDataLoader = value;
				}
			}
		}

		// Token: 0x06004348 RID: 17224 RVA: 0x00142CB0 File Offset: 0x00140EB0
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
			foreach (HeroPhantom heroPhantom in this.m_heroPhantomDS.PhantomCollections.HeroPhantoms)
			{
				foreach (HeroPhantomLevel heroPhantomLevel in heroPhantom.Levels)
				{
					if (heroPhantomLevel.FirstClear != DateTime.MaxValue)
					{
						list.Add(heroPhantomLevel.ID);
					}
				}
			}
			return list;
		}

		// Token: 0x14000045 RID: 69
		// (add) Token: 0x06004349 RID: 17225 RVA: 0x00142DDC File Offset: 0x00140FDC
		// (remove) Token: 0x0600434A RID: 17226 RVA: 0x00142E78 File Offset: 0x00141078
		public event Action<BattleType, int, List<int>> CompleteHeroPhantomMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_CompleteHeroPhantomMissionEventAction`3_hotfix != null)
				{
					this.m_add_CompleteHeroPhantomMissionEventAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleType, int, List<int>> action = this.CompleteHeroPhantomMissionEvent;
				Action<BattleType, int, List<int>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleType, int, List<int>>>(ref this.CompleteHeroPhantomMissionEvent, (Action<BattleType, int, List<int>>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_CompleteHeroPhantomMissionEventAction`3_hotfix != null)
				{
					this.m_remove_CompleteHeroPhantomMissionEventAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleType, int, List<int>> action = this.CompleteHeroPhantomMissionEvent;
				Action<BattleType, int, List<int>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleType, int, List<int>>>(ref this.CompleteHeroPhantomMissionEvent, (Action<BattleType, int, List<int>>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000046 RID: 70
		// (add) Token: 0x0600434B RID: 17227 RVA: 0x00142F14 File Offset: 0x00141114
		// (remove) Token: 0x0600434C RID: 17228 RVA: 0x00142FB0 File Offset: 0x001411B0
		public event Action<int> GetBattleAchievementMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_GetBattleAchievementMissionEventAction`1_hotfix != null)
				{
					this.m_add_GetBattleAchievementMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.GetBattleAchievementMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.GetBattleAchievementMissionEvent, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_GetBattleAchievementMissionEventAction`1_hotfix != null)
				{
					this.m_remove_GetBattleAchievementMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.GetBattleAchievementMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.GetBattleAchievementMissionEvent, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17001177 RID: 4471
		// (get) Token: 0x0600434D RID: 17229 RVA: 0x0014304C File Offset: 0x0014124C
		// (set) Token: 0x0600434E RID: 17230 RVA: 0x0014306C File Offset: 0x0014126C
		[DoNotToLua]
		public HeroPhantomCompomentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroPhantomCompomentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600434F RID: 17231 RVA: 0x00143078 File Offset: 0x00141278
		private void __callDele_CompleteHeroPhantomMissionEvent(BattleType arg1, int arg2, List<int> arg3)
		{
			Action<BattleType, int, List<int>> completeHeroPhantomMissionEvent = this.CompleteHeroPhantomMissionEvent;
			if (completeHeroPhantomMissionEvent != null)
			{
				completeHeroPhantomMissionEvent(arg1, arg2, arg3);
			}
		}

		// Token: 0x06004350 RID: 17232 RVA: 0x0014309C File Offset: 0x0014129C
		private void __clearDele_CompleteHeroPhantomMissionEvent(BattleType arg1, int arg2, List<int> arg3)
		{
			this.CompleteHeroPhantomMissionEvent = null;
		}

		// Token: 0x06004351 RID: 17233 RVA: 0x001430A8 File Offset: 0x001412A8
		private void __callDele_GetBattleAchievementMissionEvent(int obj)
		{
			Action<int> getBattleAchievementMissionEvent = this.GetBattleAchievementMissionEvent;
			if (getBattleAchievementMissionEvent != null)
			{
				getBattleAchievementMissionEvent(obj);
			}
		}

		// Token: 0x06004352 RID: 17234 RVA: 0x001430CC File Offset: 0x001412CC
		private void __clearDele_GetBattleAchievementMissionEvent(int obj)
		{
			this.GetBattleAchievementMissionEvent = null;
		}

		// Token: 0x06004353 RID: 17235 RVA: 0x001430D8 File Offset: 0x001412D8
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
					this.m_CheckHeroPhantomAvailableInt32Int32__hotfix = (luaObj.RawGet("CheckHeroPhantomAvailable") as LuaFunction);
					this.m_CheckHeroPhantomLevelAvailableInt32Int32__hotfix = (luaObj.RawGet("CheckHeroPhantomLevelAvailable") as LuaFunction);
					this.m_CheckPlayerOutOfBattleInt32__hotfix = (luaObj.RawGet("CheckPlayerOutOfBattle") as LuaFunction);
					this.m_CheckEnergyInt32Int32__hotfix = (luaObj.RawGet("CheckEnergy") as LuaFunction);
					this.m_CheckBagInt32Int32__hotfix = (luaObj.RawGet("CheckBag") as LuaFunction);
					this.m_CheckChallengeHeroPhantomLevelInt32_hotfix = (luaObj.RawGet("CheckChallengeHeroPhantomLevel") as LuaFunction);
					this.m_ChallengeHeroPhantomLevelInt32Boolean_hotfix = (luaObj.RawGet("ChallengeHeroPhantomLevel") as LuaFunction);
					this.m_SetCommonSuccessHeroPhantomLevelHeroPhantomLevelList`1List`1List`1_hotfix = (luaObj.RawGet("SetCommonSuccessHeroPhantomLevel") as LuaFunction);
					this.m_FinishedHeroPhantomLevelHeroPhantomLevelList`1_hotfix = (luaObj.RawGet("FinishedHeroPhantomLevel") as LuaFunction);
					this.m_GetHeroPhantomInt32_hotfix = (luaObj.RawGet("GetHeroPhantom") as LuaFunction);
					this.m_GetHeroPhantomLevelInt32_hotfix = (luaObj.RawGet("GetHeroPhantomLevel") as LuaFunction);
					this.m_IsCompleteHeroPhantomLevelAchievementInt32_hotfix = (luaObj.RawGet("IsCompleteHeroPhantomLevelAchievement") as LuaFunction);
					this.m_get_m_configDataLoader_hotfix = (luaObj.RawGet("get_m_configDataLoader") as LuaFunction);
					this.m_set_m_configDataLoaderIConfigDataLoader_hotfix = (luaObj.RawGet("set_m_configDataLoader") as LuaFunction);
					this.m_GetAllFinishedLevels_hotfix = (luaObj.RawGet("GetAllFinishedLevels") as LuaFunction);
					this.m_add_CompleteHeroPhantomMissionEventAction`3_hotfix = (luaObj.RawGet("add_CompleteHeroPhantomMissionEvent") as LuaFunction);
					this.m_remove_CompleteHeroPhantomMissionEventAction`3_hotfix = (luaObj.RawGet("remove_CompleteHeroPhantomMissionEvent") as LuaFunction);
					this.m_add_GetBattleAchievementMissionEventAction`1_hotfix = (luaObj.RawGet("add_GetBattleAchievementMissionEvent") as LuaFunction);
					this.m_remove_GetBattleAchievementMissionEventAction`1_hotfix = (luaObj.RawGet("remove_GetBattleAchievementMissionEvent") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06004354 RID: 17236 RVA: 0x00143478 File Offset: 0x00141678
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroPhantomCompomentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003326 RID: 13094
		private IConfigDataLoader _configDataLoader;

		// Token: 0x04003327 RID: 13095
		protected DataSectionHeroPhantom m_heroPhantomDS = new DataSectionHeroPhantom();

		// Token: 0x04003328 RID: 13096
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x04003329 RID: 13097
		protected BattleComponentCommon m_battle;

		// Token: 0x0400332A RID: 13098
		protected BagComponentCommon m_bag;

		// Token: 0x0400332B RID: 13099
		protected HeroComponentCommon m_hero;

		// Token: 0x0400332C RID: 13100
		protected RiftComponentCommon m_rift;

		// Token: 0x0400332F RID: 13103
		[DoNotToLua]
		private HeroPhantomCompomentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x04003330 RID: 13104
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003331 RID: 13105
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003332 RID: 13106
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04003333 RID: 13107
		private LuaFunction m_GetName_hotfix;

		// Token: 0x04003334 RID: 13108
		private LuaFunction m_Init_hotfix;

		// Token: 0x04003335 RID: 13109
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04003336 RID: 13110
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04003337 RID: 13111
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x04003338 RID: 13112
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x04003339 RID: 13113
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x0400333A RID: 13114
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x0400333B RID: 13115
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x0400333C RID: 13116
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x0400333D RID: 13117
		private LuaFunction m_CheckHeroPhantomAvailableInt32Int32__hotfix;

		// Token: 0x0400333E RID: 13118
		private LuaFunction m_CheckHeroPhantomLevelAvailableInt32Int32__hotfix;

		// Token: 0x0400333F RID: 13119
		private LuaFunction m_CheckPlayerOutOfBattleInt32__hotfix;

		// Token: 0x04003340 RID: 13120
		private LuaFunction m_CheckEnergyInt32Int32__hotfix;

		// Token: 0x04003341 RID: 13121
		private LuaFunction m_CheckBagInt32Int32__hotfix;

		// Token: 0x04003342 RID: 13122
		private LuaFunction m_CheckChallengeHeroPhantomLevelInt32_hotfix;

		// Token: 0x04003343 RID: 13123
		private LuaFunction m_ChallengeHeroPhantomLevelInt32Boolean_hotfix;

		// Token: 0x04003344 RID: 13124
		private LuaFunction m_SetCommonSuccessHeroPhantomLevelHeroPhantomLevelList`1List`1List;

		// Token: 0x04003345 RID: 13125
		private LuaFunction m_FinishedHeroPhantomLevelHeroPhantomLevelList;

		// Token: 0x04003346 RID: 13126
		private LuaFunction m_GetHeroPhantomInt32_hotfix;

		// Token: 0x04003347 RID: 13127
		private LuaFunction m_GetHeroPhantomLevelInt32_hotfix;

		// Token: 0x04003348 RID: 13128
		private LuaFunction m_IsCompleteHeroPhantomLevelAchievementInt32_hotfix;

		// Token: 0x04003349 RID: 13129
		private LuaFunction m_get_m_configDataLoader_hotfix;

		// Token: 0x0400334A RID: 13130
		private LuaFunction m_set_m_configDataLoaderIConfigDataLoader_hotfix;

		// Token: 0x0400334B RID: 13131
		private LuaFunction m_GetAllFinishedLevels_hotfix;

		// Token: 0x0400334C RID: 13132
		private LuaFunction m_add_CompleteHeroPhantomMissionEventAction;

		// Token: 0x0400334D RID: 13133
		private LuaFunction m_remove_CompleteHeroPhantomMissionEventAction;

		// Token: 0x0400334E RID: 13134
		private LuaFunction m_add_GetBattleAchievementMissionEventAction;

		// Token: 0x0400334F RID: 13135
		private LuaFunction m_remove_GetBattleAchievementMissionEventAction;

		// Token: 0x0200047A RID: 1146
		public class LuaExportHelper
		{
			// Token: 0x06004355 RID: 17237 RVA: 0x001434E0 File Offset: 0x001416E0
			public LuaExportHelper(HeroPhantomCompomentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06004356 RID: 17238 RVA: 0x001434F0 File Offset: 0x001416F0
			public void __callDele_CompleteHeroPhantomMissionEvent(BattleType arg1, int arg2, List<int> arg3)
			{
				this.m_owner.__callDele_CompleteHeroPhantomMissionEvent(arg1, arg2, arg3);
			}

			// Token: 0x06004357 RID: 17239 RVA: 0x00143500 File Offset: 0x00141700
			public void __clearDele_CompleteHeroPhantomMissionEvent(BattleType arg1, int arg2, List<int> arg3)
			{
				this.m_owner.__clearDele_CompleteHeroPhantomMissionEvent(arg1, arg2, arg3);
			}

			// Token: 0x06004358 RID: 17240 RVA: 0x00143510 File Offset: 0x00141710
			public void __callDele_GetBattleAchievementMissionEvent(int obj)
			{
				this.m_owner.__callDele_GetBattleAchievementMissionEvent(obj);
			}

			// Token: 0x06004359 RID: 17241 RVA: 0x00143520 File Offset: 0x00141720
			public void __clearDele_GetBattleAchievementMissionEvent(int obj)
			{
				this.m_owner.__clearDele_GetBattleAchievementMissionEvent(obj);
			}

			// Token: 0x17001178 RID: 4472
			// (get) Token: 0x0600435A RID: 17242 RVA: 0x00143530 File Offset: 0x00141730
			// (set) Token: 0x0600435B RID: 17243 RVA: 0x00143540 File Offset: 0x00141740
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

			// Token: 0x17001179 RID: 4473
			// (get) Token: 0x0600435C RID: 17244 RVA: 0x00143550 File Offset: 0x00141750
			// (set) Token: 0x0600435D RID: 17245 RVA: 0x00143560 File Offset: 0x00141760
			public DataSectionHeroPhantom m_heroPhantomDS
			{
				get
				{
					return this.m_owner.m_heroPhantomDS;
				}
				set
				{
					this.m_owner.m_heroPhantomDS = value;
				}
			}

			// Token: 0x1700117A RID: 4474
			// (get) Token: 0x0600435E RID: 17246 RVA: 0x00143570 File Offset: 0x00141770
			// (set) Token: 0x0600435F RID: 17247 RVA: 0x00143580 File Offset: 0x00141780
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

			// Token: 0x1700117B RID: 4475
			// (get) Token: 0x06004360 RID: 17248 RVA: 0x00143590 File Offset: 0x00141790
			// (set) Token: 0x06004361 RID: 17249 RVA: 0x001435A0 File Offset: 0x001417A0
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

			// Token: 0x1700117C RID: 4476
			// (get) Token: 0x06004362 RID: 17250 RVA: 0x001435B0 File Offset: 0x001417B0
			// (set) Token: 0x06004363 RID: 17251 RVA: 0x001435C0 File Offset: 0x001417C0
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

			// Token: 0x1700117D RID: 4477
			// (get) Token: 0x06004364 RID: 17252 RVA: 0x001435D0 File Offset: 0x001417D0
			// (set) Token: 0x06004365 RID: 17253 RVA: 0x001435E0 File Offset: 0x001417E0
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

			// Token: 0x1700117E RID: 4478
			// (get) Token: 0x06004366 RID: 17254 RVA: 0x001435F0 File Offset: 0x001417F0
			// (set) Token: 0x06004367 RID: 17255 RVA: 0x00143600 File Offset: 0x00141800
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

			// Token: 0x1700117F RID: 4479
			// (get) Token: 0x06004368 RID: 17256 RVA: 0x00143610 File Offset: 0x00141810
			// (set) Token: 0x06004369 RID: 17257 RVA: 0x00143620 File Offset: 0x00141820
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

			// Token: 0x0600436A RID: 17258 RVA: 0x00143630 File Offset: 0x00141830
			public void FinishedHeroPhantomLevel(HeroPhantomLevel Level, List<int> heroes)
			{
				this.m_owner.FinishedHeroPhantomLevel(Level, heroes);
			}

			// Token: 0x04003350 RID: 13136
			private HeroPhantomCompomentCommon m_owner;
		}
	}
}
