using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200048C RID: 1164
	[HotFix]
	public class OperationalActivityCompomentCommon : IComponentBase
	{
		// Token: 0x060045DE RID: 17886 RVA: 0x0015514C File Offset: 0x0015334C
		public OperationalActivityCompomentCommon()
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

		// Token: 0x060045DF RID: 17887 RVA: 0x001551B4 File Offset: 0x001533B4
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
			return "OperationalActivity";
		}

		// Token: 0x060045E0 RID: 17888 RVA: 0x00155228 File Offset: 0x00153428
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
			this.m_operationalActivityDS = new DataSectionOperationalActivity();
			this.m_announcementDS = new DataSectionAnnouncement();
		}

		// Token: 0x060045E1 RID: 17889 RVA: 0x001552A0 File Offset: 0x001534A0
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
			this.m_rift = (this.Owner.GetOwnerComponent("Rift") as RiftComponentCommon);
			this.m_anikiGym = (this.Owner.GetOwnerComponent("AnikiGym") as AnikiGymComponentCommon);
			this.m_thearchyTrial = (this.Owner.GetOwnerComponent("ThearchyTrail") as ThearchyTrialCompomentCommon);
			this.m_selectCard = (this.Owner.GetOwnerComponent("SelectCard") as SelectCardComponentCommon);
			this.m_heroDungeon = (this.Owner.GetOwnerComponent("HeroDungeon") as HeroDungeonComponentCommon);
			this.m_raffle = (this.Owner.GetOwnerComponent("Raffle") as RaffleComponentCommon);
			this.m_unchartedScore = (this.Owner.GetOwnerComponent("UnchartedScore") as UnchartedScoreComponentCommon);
			this.m_randomStore = (this.Owner.GetOwnerComponent("RandomStore") as RandomStoreComponentCommon);
			this.m_fixedStore = (this.Owner.GetOwnerComponent("FixedStore") as FixedStoreComponentCommon);
			this.m_rechargeStore = (this.Owner.GetOwnerComponent("RechargeStore") as RechargeStoreComponentCommon);
			this.m_giftStore = (this.Owner.GetOwnerComponent("GiftStore") as GiftStoreComponentCommon);
			this.m_basicInfo.PlayerActionFlushEvent += this.OnFlushLoginDaysEvent;
			this.m_basicInfo.LevelUpPlayerLevelEvent += this.OnPlayerLevelUpEvent;
			this.m_basicInfo.AddRechargeRMBEvent += this.OnAddRechargeRMBEvent;
			this.m_basicInfo.ConsumeCrystalMissionEvent += this.OnConsumeCrystalEvent;
			this.m_fixedStore.BuyStoreItemEvent += this.OnBuyStoreItemCallBack;
			this.m_randomStore.BuyStoreItemEvent += this.OnBuyStoreItemCallBack;
			this.m_giftStore.BuyStoreItemEvent += this.OnBuyStoreItemCallBack;
			this.m_rechargeStore.BuyStoreItemEvent += this.OnBuyStoreItemCallBack;
		}

		// Token: 0x060045E2 RID: 17890 RVA: 0x00155518 File Offset: 0x00153718
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

		// Token: 0x060045E3 RID: 17891 RVA: 0x00155578 File Offset: 0x00153778
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
			this.RemoveAllExpiredOperationalActivities();
		}

		// Token: 0x060045E4 RID: 17892 RVA: 0x001555F0 File Offset: 0x001537F0
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

		// Token: 0x060045E5 RID: 17893 RVA: 0x00155670 File Offset: 0x00153870
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

		// Token: 0x060045E6 RID: 17894 RVA: 0x001556E0 File Offset: 0x001538E0
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

		// Token: 0x170011CF RID: 4559
		// (get) Token: 0x060045E7 RID: 17895 RVA: 0x00155740 File Offset: 0x00153940
		// (set) Token: 0x060045E8 RID: 17896 RVA: 0x001557B4 File Offset: 0x001539B4
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

		// Token: 0x060045E9 RID: 17897 RVA: 0x0015582C File Offset: 0x00153A2C
		public void OnFlushLoginDaysEvent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFlushLoginDaysEvent_hotfix != null)
			{
				this.m_OnFlushLoginDaysEvent_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_operationalActivityDS.AllOperationalActivities.Count == 0)
			{
				return;
			}
			DateTime currentTime = this.m_basicInfo.GetCurrentTime();
			List<OperationalActivityBase> list = this.m_operationalActivityDS.FindOperationalActivitiesByType(OperationalActivityType.OperationalActivityType_AccumulateDaysLogin);
			foreach (OperationalActivityBase operationalActivityBase in list)
			{
				if (operationalActivityBase.IsInOperationPeriod(currentTime))
				{
					AccumulateLoginOperationalActivity accumulateLoginOperationalActivity = operationalActivityBase as AccumulateLoginOperationalActivity;
					if (this.m_operationalActivityDS.AddAccumulateLoginTime(accumulateLoginOperationalActivity, currentTime))
					{
						this.OnFlushSuccessCallBack(accumulateLoginOperationalActivity);
					}
				}
			}
			List<OperationalActivityBase> list2 = this.m_operationalActivityDS.FindOperationalActivitiesByType(OperationalActivityType.OperationalActivityType_SpecificDaysLogin);
			int relativeLoginDays;
			foreach (OperationalActivityBase operationalActivityBase2 in list2)
			{
				if (operationalActivityBase2.IsInOperationPeriod(currentTime))
				{
					SpecificDaysLoginOperationalActivity specificDaysLoginOperationalActivity = operationalActivityBase2 as SpecificDaysLoginOperationalActivity;
					relativeLoginDays = (int)(currentTime.Date - operationalActivityBase2.OperationStartTime.Date).TotalDays + 1;
					if (specificDaysLoginOperationalActivity.Config.OperationalActivityParms.Find((ActivityParam t) => t.Parm1 == relativeLoginDays) != null)
					{
						this.m_operationalActivityDS.AddSpecificLoginTimes(specificDaysLoginOperationalActivity, currentTime.Ticks);
						this.OnFlushSuccessCallBack(specificDaysLoginOperationalActivity);
					}
				}
			}
		}

		// Token: 0x060045EA RID: 17898 RVA: 0x00155A18 File Offset: 0x00153C18
		protected virtual void OnFlushSuccessCallBack(OperationalActivityBase activity)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFlushSuccessCallBackOperationalActivityBase_hotfix != null)
			{
				this.m_OnFlushSuccessCallBackOperationalActivityBase_hotfix.call(new object[]
				{
					this,
					activity
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060045EB RID: 17899 RVA: 0x00155A88 File Offset: 0x00153C88
		public void OnPlayerLevelUpEvent(int palyerLevel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPlayerLevelUpEventInt32_hotfix != null)
			{
				this.m_OnPlayerLevelUpEventInt32_hotfix.call(new object[]
				{
					this,
					palyerLevel
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DateTime currentTime = this.m_basicInfo.GetCurrentTime();
			List<OperationalActivityBase> list = this.m_operationalActivityDS.FindOperationalActivitiesByType(OperationalActivityType.OperationalActivityType_PlayerLevelUp).FindAll((OperationalActivityBase t) => t.IsInOperationPeriod(currentTime));
			foreach (OperationalActivityBase operationalActivityBase in list)
			{
				PlayerLevelUpOperationalActivity playerLevelUpOperationalActivity = operationalActivityBase as PlayerLevelUpOperationalActivity;
				this.m_operationalActivityDS.SetPlayerLevel(playerLevelUpOperationalActivity, palyerLevel);
			}
		}

		// Token: 0x060045EC RID: 17900 RVA: 0x00155B88 File Offset: 0x00153D88
		protected void AddNewOperationalActivity(OperationalActivityBase operationalActivity)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddNewOperationalActivityOperationalActivityBase_hotfix != null)
			{
				this.m_AddNewOperationalActivityOperationalActivityBase_hotfix.call(new object[]
				{
					this,
					operationalActivity
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.InitNewNewOperationalActivityInfo(operationalActivity);
			this.m_operationalActivityDS.AddNewOperationalActivity(operationalActivity);
			this.OnAddNewActivityCallBack(operationalActivity);
		}

		// Token: 0x060045ED RID: 17901 RVA: 0x00155C14 File Offset: 0x00153E14
		protected void InitNewNewOperationalActivityInfo(OperationalActivityBase operationalActivityInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitNewNewOperationalActivityInfoOperationalActivityBase_hotfix != null)
			{
				this.m_InitNewNewOperationalActivityInfoOperationalActivityBase_hotfix.call(new object[]
				{
					this,
					operationalActivityInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!operationalActivityInfo.IsInOperationPeriod(this.m_basicInfo.GetCurrentTime()))
			{
				return;
			}
			DateTime currentTime = this.m_basicInfo.GetCurrentTime();
			this.OnActivityInitCallBack(operationalActivityInfo);
			if (OperationalActivityCompomentCommon.IsEffectOperationalActivity(operationalActivityInfo.ActivityType))
			{
				this.EffectOperationActivityGenerateEffect(operationalActivityInfo, true);
			}
			else if (operationalActivityInfo.ActivityType == OperationalActivityType.OperationalActivityType_AccumulateDaysLogin)
			{
				AccumulateLoginOperationalActivity accumulateLoginOperationalActivity = operationalActivityInfo as AccumulateLoginOperationalActivity;
				accumulateLoginOperationalActivity.AddLoginTime(currentTime);
			}
			else if (operationalActivityInfo.ActivityType == OperationalActivityType.OperationalActivityType_SpecificDaysLogin)
			{
				SpecificDaysLoginOperationalActivity specificDaysLoginOperationalActivity = operationalActivityInfo as SpecificDaysLoginOperationalActivity;
				int relativeLoginDays = (int)(currentTime.Date - specificDaysLoginOperationalActivity.OperationStartTime.Date).TotalDays + 1;
				if (specificDaysLoginOperationalActivity.Config.OperationalActivityParms.Find((ActivityParam t) => t.Parm1 == relativeLoginDays) != null)
				{
					specificDaysLoginOperationalActivity.SpecificLoginTimes.Add(currentTime.Ticks);
				}
			}
			else if (operationalActivityInfo.ActivityType == OperationalActivityType.OperationalActivityType_PlayerLevelUp)
			{
				PlayerLevelUpOperationalActivity playerLevelUpOperationalActivity = operationalActivityInfo as PlayerLevelUpOperationalActivity;
				playerLevelUpOperationalActivity.PlayerLevel = this.m_basicInfo.GetLevel();
			}
		}

		// Token: 0x060045EE RID: 17902 RVA: 0x00155D90 File Offset: 0x00153F90
		protected virtual void OnAddNewActivityCallBack(OperationalActivityBase activity)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAddNewActivityCallBackOperationalActivityBase_hotfix != null)
			{
				this.m_OnAddNewActivityCallBackOperationalActivityBase_hotfix.call(new object[]
				{
					this,
					activity
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060045EF RID: 17903 RVA: 0x00155E00 File Offset: 0x00154000
		protected virtual void OnActivityInitCallBack(OperationalActivityBase activity)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnActivityInitCallBackOperationalActivityBase_hotfix != null)
			{
				this.m_OnActivityInitCallBackOperationalActivityBase_hotfix.call(new object[]
				{
					this,
					activity
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060045F0 RID: 17904 RVA: 0x00155E70 File Offset: 0x00154070
		public static bool IsEffectOperationalActivity(OperationalActivityType operationalActivityType)
		{
			switch (operationalActivityType)
			{
			case OperationalActivityType.OperationalActivityType_RewardAdd:
			case OperationalActivityType.OperationalActivityType_ChallengeNumsAdd:
			case OperationalActivityType.OperationalActivityType_ActivitySelectCard:
			case OperationalActivityType.OperationalActivityType_Raffle:
			case OperationalActivityType.OperationalActivityType_UnchartedScore:
			case OperationalActivityType.OperationalActivityType_Web:
			case OperationalActivityType.OperationalActivityType_BuyItemGuide:
				return true;
			}
			return false;
		}

		// Token: 0x060045F1 RID: 17905 RVA: 0x00155EAC File Offset: 0x001540AC
		public static bool IsAwardOperationActivity(OperationalActivityType operationalActivityType)
		{
			switch (operationalActivityType)
			{
			case OperationalActivityType.OperationalActivityType_PlayerLevelUp:
			case OperationalActivityType.OperationalActivityType_SpecificDaysLogin:
			case OperationalActivityType.OperationalActivityType_AccumulateDaysLogin:
				break;
			default:
				if (operationalActivityType != OperationalActivityType.OperationalActivityType_AccumulateRecharge && operationalActivityType != OperationalActivityType.OperationalActivityType_AccumulateConsumeCrystal)
				{
					return false;
				}
				break;
			}
			return true;
		}

		// Token: 0x060045F2 RID: 17906 RVA: 0x00155EE0 File Offset: 0x001540E0
		public void RemoveAllExpiredOperationalActivities()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RemoveAllExpiredOperationalActivities_hotfix != null)
			{
				this.m_RemoveAllExpiredOperationalActivities_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_operationalActivityDS.AllOperationalActivities.Count == 0)
			{
				return;
			}
			DateTime currentTime = this.m_basicInfo.GetCurrentTime();
			List<OperationalActivityBase> list = null;
			foreach (OperationalActivityBase operationalActivityBase in this.m_operationalActivityDS.AllOperationalActivities)
			{
				if (operationalActivityBase.IsExpiredOperationalActivity(currentTime))
				{
					if (list == null)
					{
						list = new List<OperationalActivityBase>();
					}
					list.Add(operationalActivityBase);
					this.EffectOperationActivityGenerateEffect(operationalActivityBase, false);
				}
			}
			if (list != null)
			{
				foreach (OperationalActivityBase operatinoalActivity in list)
				{
					this.m_operationalActivityDS.RemoveExpiredOperationalActivity(operatinoalActivity);
				}
			}
		}

		// Token: 0x060045F3 RID: 17907 RVA: 0x00156034 File Offset: 0x00154234
		public int CanExchangeItemGroup(LimitedTimeExchangeOperationActivity limitedTimeExchangeOperationalActivity, int itemGroupIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanExchangeItemGroupLimitedTimeExchangeOperationActivityInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanExchangeItemGroupLimitedTimeExchangeOperationActivityInt32_hotfix.call(new object[]
				{
					this,
					limitedTimeExchangeOperationalActivity,
					itemGroupIndex
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!limitedTimeExchangeOperationalActivity.IsInOperationPeriod(this.m_basicInfo.GetCurrentTime()))
			{
				return -2206;
			}
			int num = limitedTimeExchangeOperationalActivity.CanExchangeOperationalActivityItem(itemGroupIndex, 1);
			if (num != 0)
			{
				return num;
			}
			ActivityParam activityParam = limitedTimeExchangeOperationalActivity.Config.OperationalActivityParms[itemGroupIndex];
			ConfigDataOperationalActivityItemGroupInfo configDataOperationalActivityItemGroupInfo = this.m_configDataLoader.GetConfigDataOperationalActivityItemGroupInfo(activityParam.Parm1);
			ConfigDataOperationalActivityItemGroupInfo configDataOperationalActivityItemGroupInfo2 = this.m_configDataLoader.GetConfigDataOperationalActivityItemGroupInfo(activityParam.Parm2);
			if (configDataOperationalActivityItemGroupInfo == null || configDataOperationalActivityItemGroupInfo2 == null)
			{
				return -2210;
			}
			List<BagItemBase> list;
			if (this.m_bag.IsGoodsEnough(configDataOperationalActivityItemGroupInfo.ItemList, out list) != 0)
			{
				return -501;
			}
			if (this.m_bag.IsBagFullByCurrentSize())
			{
				return -500;
			}
			return 0;
		}

		// Token: 0x060045F4 RID: 17908 RVA: 0x0015616C File Offset: 0x0015436C
		public int CanGainOperactionalActivityReward(OperationalActivityBase operationalActivityBase, int rewardIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanGainOperactionalActivityRewardOperationalActivityBaseInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanGainOperactionalActivityRewardOperationalActivityBaseInt32_hotfix.call(new object[]
				{
					this,
					operationalActivityBase,
					rewardIndex
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!OperationalActivityCompomentCommon.IsAwardOperationActivity(operationalActivityBase.ActivityType))
			{
				return -2205;
			}
			AwardOperationalActivityBase awardOperationalActivityBase = operationalActivityBase as AwardOperationalActivityBase;
			int num = awardOperationalActivityBase.CanGainRewardByIndex(rewardIndex, this.m_basicInfo.GetCurrentTime());
			if (num != 0)
			{
				return num;
			}
			int awardOperationActivityRewardItemGroupIdByIndex = this.GetAwardOperationActivityRewardItemGroupIdByIndex(awardOperationalActivityBase, rewardIndex);
			if (this.m_configDataLoader.GetConfigDataOperationalActivityItemGroupInfo(awardOperationActivityRewardItemGroupIdByIndex) == null)
			{
				return -2210;
			}
			if (this.m_bag.IsBagFullByCurrentSize())
			{
				return -500;
			}
			return 0;
		}

		// Token: 0x060045F5 RID: 17909 RVA: 0x0015626C File Offset: 0x0015446C
		public List<OperationalActivityBase> GetAllOperationalActivities()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllOperationalActivities_hotfix != null)
			{
				return (List<OperationalActivityBase>)this.m_GetAllOperationalActivities_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_operationalActivityDS.AllOperationalActivities;
		}

		// Token: 0x060045F6 RID: 17910 RVA: 0x001562E4 File Offset: 0x001544E4
		public List<OperationalActivityBase> GetAllValidOperationalActivities()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllValidOperationalActivities_hotfix != null)
			{
				return (List<OperationalActivityBase>)this.m_GetAllValidOperationalActivities_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DateTime currentTime = this.m_basicInfo.GetCurrentTime();
			List<OperationalActivityBase> list = new List<OperationalActivityBase>();
			foreach (OperationalActivityBase operationalActivityBase in this.m_operationalActivityDS.AllOperationalActivities)
			{
				if (operationalActivityBase.GainRewardEndTime != DateTime.MinValue)
				{
					if (operationalActivityBase.IsInGainRewardPeriod(currentTime))
					{
						list.Add(operationalActivityBase);
					}
				}
				else if (operationalActivityBase.IsInOperationPeriod(currentTime) || operationalActivityBase.IsInOperationShowPeriod(currentTime))
				{
					list.Add(operationalActivityBase);
				}
			}
			return list;
		}

		// Token: 0x060045F7 RID: 17911 RVA: 0x001563FC File Offset: 0x001545FC
		protected int GetAwardOperationActivityRewardItemGroupIdByIndex(OperationalActivityBase operationalActivity, int rewardIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAwardOperationActivityRewardItemGroupIdByIndexOperationalActivityBaseInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetAwardOperationActivityRewardItemGroupIdByIndexOperationalActivityBaseInt32_hotfix.call(new object[]
				{
					this,
					operationalActivity,
					rewardIndex
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (rewardIndex < 0 || rewardIndex > operationalActivity.Config.OperationalActivityParms.Count)
			{
				return int.MinValue;
			}
			if (operationalActivity.ActivityType == OperationalActivityType.OperationalActivityType_PlayerLevelUp || operationalActivity.ActivityType == OperationalActivityType.OperationalActivityType_SpecificDaysLogin || operationalActivity.ActivityType == OperationalActivityType.OperationalActivityType_AccumulateDaysLogin || operationalActivity.ActivityType == OperationalActivityType.OperationalActivityType_AccumulateRecharge || operationalActivity.ActivityType == OperationalActivityType.OperationalActivityType_AccumulateConsumeCrystal)
			{
				return operationalActivity.Config.OperationalActivityParms[rewardIndex].Parm2;
			}
			return int.MinValue;
		}

		// Token: 0x060045F8 RID: 17912 RVA: 0x00156508 File Offset: 0x00154708
		protected void EffectOperationActivityGenerateEffect(OperationalActivityBase operationalActivity, bool isPositive)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EffectOperationActivityGenerateEffectOperationalActivityBaseBoolean_hotfix != null)
			{
				this.m_EffectOperationActivityGenerateEffectOperationalActivityBaseBoolean_hotfix.call(new object[]
				{
					this,
					operationalActivity,
					isPositive
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!OperationalActivityCompomentCommon.IsEffectOperationalActivity(operationalActivity.ActivityType))
			{
				return;
			}
			if (operationalActivity.ActivityType == OperationalActivityType.OperationalActivityType_ChallengeNumsAdd)
			{
				foreach (ActivityParam activityParam in operationalActivity.Config.OperationalActivityParms)
				{
					int operationalActivityChanllengenumsAdd = (!isPositive) ? 0 : activityParam.Parm2;
					BattleType parm = (BattleType)activityParam.Parm1;
					if (parm != BattleType.Rift)
					{
						if (parm == BattleType.HeroDungeon)
						{
							this.m_heroDungeon.OperationalActivityChanllengenumsAdd = operationalActivityChanllengenumsAdd;
						}
					}
					else
					{
						this.m_rift.OperationalActivityChanllengenumsAdd = operationalActivityChanllengenumsAdd;
					}
				}
			}
			else if (operationalActivity.ActivityType == OperationalActivityType.OperationalActivityType_RewardAdd)
			{
				foreach (ActivityParam activityParam2 in operationalActivity.Config.OperationalActivityParms)
				{
					BattleType parm2 = (BattleType)activityParam2.Parm1;
					if (parm2 != BattleType.Rift)
					{
						if (parm2 != BattleType.ThearchyTrial)
						{
							if (parm2 == BattleType.AnikiGym)
							{
								this.m_anikiGym.HasRewardAddRelativeOperationalActivity = isPositive;
							}
						}
						else
						{
							this.m_thearchyTrial.HasRewardAddRelativeOperationalActivity = isPositive;
						}
					}
					else
					{
						this.m_rift.HasRewardAddRelativeOperationalActivity = isPositive;
					}
				}
			}
			else if (operationalActivity.ActivityType == OperationalActivityType.OperationalActivityType_ActivitySelectCard)
			{
				if (!isPositive)
				{
					foreach (ActivityParam activityParam3 in operationalActivity.Config.OperationalActivityParms)
					{
						this.m_selectCard.RemoveCardPool(activityParam3.Parm1);
					}
				}
			}
			else if (operationalActivity.ActivityType == OperationalActivityType.OperationalActivityType_Raffle)
			{
				if (!isPositive)
				{
					foreach (ActivityParam activityParam4 in operationalActivity.Config.OperationalActivityParms)
					{
						this.m_raffle.RemoveRafflePool(activityParam4.Parm1);
					}
				}
			}
			else if (operationalActivity.ActivityType == OperationalActivityType.OperationalActivityType_UnchartedScore && !isPositive)
			{
				foreach (ActivityParam activityParam5 in operationalActivity.Config.OperationalActivityParms)
				{
					this.m_unchartedScore.RemoveUnchartedScore(activityParam5.Parm1);
				}
			}
		}

		// Token: 0x060045F9 RID: 17913 RVA: 0x00156854 File Offset: 0x00154A54
		public OperationalActivityBase FindOperationalActivityById(ulong operationalActivityInstanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindOperationalActivityByIdUInt64_hotfix != null)
			{
				return (OperationalActivityBase)this.m_FindOperationalActivityByIdUInt64_hotfix.call(new object[]
				{
					this,
					operationalActivityInstanceId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_operationalActivityDS.FindOperationalActivityById(operationalActivityInstanceId);
		}

		// Token: 0x060045FA RID: 17914 RVA: 0x001568DC File Offset: 0x00154ADC
		public List<OperationalActivityBase> FindOperationalActivitiesByType(OperationalActivityType activityType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindOperationalActivitiesByTypeOperationalActivityType_hotfix != null)
			{
				return (List<OperationalActivityBase>)this.m_FindOperationalActivitiesByTypeOperationalActivityType_hotfix.call(new object[]
				{
					this,
					activityType
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_operationalActivityDS.FindOperationalActivitiesByType(activityType);
		}

		// Token: 0x060045FB RID: 17915 RVA: 0x00156964 File Offset: 0x00154B64
		public OperationalActivityBase FindOperationalActivityByActivityCardPoolId(int activityCardPoolId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindOperationalActivityByActivityCardPoolIdInt32_hotfix != null)
			{
				return (OperationalActivityBase)this.m_FindOperationalActivityByActivityCardPoolIdInt32_hotfix.call(new object[]
				{
					this,
					activityCardPoolId2
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int activityCardPoolId = activityCardPoolId2;
			DateTime currentTime = this.m_basicInfo.GetCurrentTime();
			List<OperationalActivityBase> list = this.m_operationalActivityDS.FindOperationalActivitiesByType(OperationalActivityType.OperationalActivityType_ActivitySelectCard);
			return list.Find((OperationalActivityBase t) => t.IsInOperationPeriod(currentTime) && t.Config.OperationalActivityParms.Find((ActivityParam m) => m.Parm1 == activityCardPoolId) != null);
		}

		// Token: 0x060045FC RID: 17916 RVA: 0x00156A20 File Offset: 0x00154C20
		public OperationalActivityBase FindOperationalActivityByRafflePoolId(int rafflePoolId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindOperationalActivityByRafflePoolIdInt32_hotfix != null)
			{
				return (OperationalActivityBase)this.m_FindOperationalActivityByRafflePoolIdInt32_hotfix.call(new object[]
				{
					this,
					rafflePoolId2
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int rafflePoolId = rafflePoolId2;
			DateTime currentTime = this.m_basicInfo.GetCurrentTime();
			List<OperationalActivityBase> list = this.m_operationalActivityDS.FindOperationalActivitiesByType(OperationalActivityType.OperationalActivityType_Raffle);
			return list.Find((OperationalActivityBase t) => t.IsInOperationPeriod(currentTime) && t.Config.OperationalActivityParms.Find((ActivityParam m) => m.Parm1 == rafflePoolId) != null);
		}

		// Token: 0x060045FD RID: 17917 RVA: 0x00156ADC File Offset: 0x00154CDC
		public OperationalActivityBase FindOperationalActivityByUnchartedScoreId(int UnchartedScoreId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindOperationalActivityByUnchartedScoreIdInt32_hotfix != null)
			{
				return (OperationalActivityBase)this.m_FindOperationalActivityByUnchartedScoreIdInt32_hotfix.call(new object[]
				{
					this,
					UnchartedScoreId2
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int UnchartedScoreId = UnchartedScoreId2;
			DateTime currentTime = this.m_basicInfo.GetCurrentTime();
			List<OperationalActivityBase> list = this.m_operationalActivityDS.FindOperationalActivitiesByType(OperationalActivityType.OperationalActivityType_UnchartedScore);
			return list.Find((OperationalActivityBase t) => t.IsInOperationPeriod(currentTime) && t.Config.OperationalActivityParms.Find((ActivityParam m) => m.Parm1 == UnchartedScoreId) != null);
		}

		// Token: 0x060045FE RID: 17918 RVA: 0x00156B98 File Offset: 0x00154D98
		public OperationalActivityBase FindShowActivityByUnchartedScoreId(int UnchartedScoreId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindShowActivityByUnchartedScoreIdInt32_hotfix != null)
			{
				return (OperationalActivityBase)this.m_FindShowActivityByUnchartedScoreIdInt32_hotfix.call(new object[]
				{
					this,
					UnchartedScoreId2
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int UnchartedScoreId = UnchartedScoreId2;
			DateTime currentTime = this.m_basicInfo.GetCurrentTime();
			List<OperationalActivityBase> list = this.m_operationalActivityDS.FindOperationalActivitiesByType(OperationalActivityType.OperationalActivityType_UnchartedScore);
			return list.Find((OperationalActivityBase t) => t.IsInOperationShowPeriod(currentTime) && t.Config.OperationalActivityParms.Find((ActivityParam m) => m.Parm1 == UnchartedScoreId) != null);
		}

		// Token: 0x060045FF RID: 17919 RVA: 0x00156C54 File Offset: 0x00154E54
		private void OnAddRechargeRMBEvent(int nums, DateTime rechargeTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAddRechargeRMBEventInt32DateTime_hotfix != null)
			{
				this.m_OnAddRechargeRMBEventInt32DateTime_hotfix.call(new object[]
				{
					this,
					nums,
					rechargeTime
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<OperationalActivityBase> list = this.FindOperationalActivitiesByType(OperationalActivityType.OperationalActivityType_AccumulateRecharge);
			foreach (OperationalActivityBase operationalActivityBase in list)
			{
				if (operationalActivityBase.IsInOperationPeriod(rechargeTime))
				{
					AccumulateRechargeOperationalActivity activity = operationalActivityBase as AccumulateRechargeOperationalActivity;
					this.m_operationalActivityDS.AddRechargeRMB(activity, nums);
				}
			}
		}

		// Token: 0x06004600 RID: 17920 RVA: 0x00156D48 File Offset: 0x00154F48
		private void OnConsumeCrystalEvent(int nums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnConsumeCrystalEventInt32_hotfix != null)
			{
				this.m_OnConsumeCrystalEventInt32_hotfix.call(new object[]
				{
					this,
					nums
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DateTime currentTime = this.m_basicInfo.GetCurrentTime();
			List<OperationalActivityBase> list = this.FindOperationalActivitiesByType(OperationalActivityType.OperationalActivityType_AccumulateConsumeCrystal);
			foreach (OperationalActivityBase operationalActivityBase in list)
			{
				if (operationalActivityBase.IsInOperationPeriod(currentTime))
				{
					AccumulateConsumeCrystalOperationalActivity activity = operationalActivityBase as AccumulateConsumeCrystalOperationalActivity;
					this.m_operationalActivityDS.AddConsumeCrystal(activity, nums);
				}
			}
		}

		// Token: 0x06004601 RID: 17921 RVA: 0x00156E38 File Offset: 0x00155038
		public List<AdvertisementFlowLayout> GetAllAdvertisementFlowLayouts()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllAdvertisementFlowLayouts_hotfix != null)
			{
				return (List<AdvertisementFlowLayout>)this.m_GetAllAdvertisementFlowLayouts_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_operationalActivityDS.GetAllAdvertisementFlowLayouts();
		}

		// Token: 0x06004602 RID: 17922 RVA: 0x00156EB0 File Offset: 0x001550B0
		public void OnBuyStoreItemCallBack(int storeId, int goodsId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBuyStoreItemCallBackInt32Int32_hotfix != null)
			{
				this.m_OnBuyStoreItemCallBackInt32Int32_hotfix.call(new object[]
				{
					this,
					storeId,
					goodsId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<OperationalActivityBase> list = this.FindOperationalActivitiesByType(OperationalActivityType.OperationalActivityType_BuyItemGuide);
			foreach (OperationalActivityBase operationalActivityBase in list)
			{
				if (operationalActivityBase.Config != null && operationalActivityBase.Config.OperationalActivityParms.Count != 0)
				{
					ActivityParam activityParam = operationalActivityBase.Config.OperationalActivityParms[0];
					if (activityParam.Parm1 == storeId && activityParam.Parm2 == goodsId)
					{
						this.m_operationalActivityDS.RemoveExpiredOperationalActivity(operationalActivityBase);
					}
				}
			}
		}

		// Token: 0x170011D0 RID: 4560
		// (get) Token: 0x06004603 RID: 17923 RVA: 0x00156FD8 File Offset: 0x001551D8
		// (set) Token: 0x06004604 RID: 17924 RVA: 0x00156FF8 File Offset: 0x001551F8
		[DoNotToLua]
		public OperationalActivityCompomentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new OperationalActivityCompomentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06004605 RID: 17925 RVA: 0x00157004 File Offset: 0x00155204
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
					this.m_OnFlushLoginDaysEvent_hotfix = (luaObj.RawGet("OnFlushLoginDaysEvent") as LuaFunction);
					this.m_OnFlushSuccessCallBackOperationalActivityBase_hotfix = (luaObj.RawGet("OnFlushSuccessCallBack") as LuaFunction);
					this.m_OnPlayerLevelUpEventInt32_hotfix = (luaObj.RawGet("OnPlayerLevelUpEvent") as LuaFunction);
					this.m_AddNewOperationalActivityOperationalActivityBase_hotfix = (luaObj.RawGet("AddNewOperationalActivity") as LuaFunction);
					this.m_InitNewNewOperationalActivityInfoOperationalActivityBase_hotfix = (luaObj.RawGet("InitNewNewOperationalActivityInfo") as LuaFunction);
					this.m_OnAddNewActivityCallBackOperationalActivityBase_hotfix = (luaObj.RawGet("OnAddNewActivityCallBack") as LuaFunction);
					this.m_OnActivityInitCallBackOperationalActivityBase_hotfix = (luaObj.RawGet("OnActivityInitCallBack") as LuaFunction);
					this.m_RemoveAllExpiredOperationalActivities_hotfix = (luaObj.RawGet("RemoveAllExpiredOperationalActivities") as LuaFunction);
					this.m_CanExchangeItemGroupLimitedTimeExchangeOperationActivityInt32_hotfix = (luaObj.RawGet("CanExchangeItemGroup") as LuaFunction);
					this.m_CanGainOperactionalActivityRewardOperationalActivityBaseInt32_hotfix = (luaObj.RawGet("CanGainOperactionalActivityReward") as LuaFunction);
					this.m_GetAllOperationalActivities_hotfix = (luaObj.RawGet("GetAllOperationalActivities") as LuaFunction);
					this.m_GetAllValidOperationalActivities_hotfix = (luaObj.RawGet("GetAllValidOperationalActivities") as LuaFunction);
					this.m_GetAwardOperationActivityRewardItemGroupIdByIndexOperationalActivityBaseInt32_hotfix = (luaObj.RawGet("GetAwardOperationActivityRewardItemGroupIdByIndex") as LuaFunction);
					this.m_EffectOperationActivityGenerateEffectOperationalActivityBaseBoolean_hotfix = (luaObj.RawGet("EffectOperationActivityGenerateEffect") as LuaFunction);
					this.m_FindOperationalActivityByIdUInt64_hotfix = (luaObj.RawGet("FindOperationalActivityById") as LuaFunction);
					this.m_FindOperationalActivitiesByTypeOperationalActivityType_hotfix = (luaObj.RawGet("FindOperationalActivitiesByType") as LuaFunction);
					this.m_FindOperationalActivityByActivityCardPoolIdInt32_hotfix = (luaObj.RawGet("FindOperationalActivityByActivityCardPoolId") as LuaFunction);
					this.m_FindOperationalActivityByRafflePoolIdInt32_hotfix = (luaObj.RawGet("FindOperationalActivityByRafflePoolId") as LuaFunction);
					this.m_FindOperationalActivityByUnchartedScoreIdInt32_hotfix = (luaObj.RawGet("FindOperationalActivityByUnchartedScoreId") as LuaFunction);
					this.m_FindShowActivityByUnchartedScoreIdInt32_hotfix = (luaObj.RawGet("FindShowActivityByUnchartedScoreId") as LuaFunction);
					this.m_OnAddRechargeRMBEventInt32DateTime_hotfix = (luaObj.RawGet("OnAddRechargeRMBEvent") as LuaFunction);
					this.m_OnConsumeCrystalEventInt32_hotfix = (luaObj.RawGet("OnConsumeCrystalEvent") as LuaFunction);
					this.m_GetAllAdvertisementFlowLayouts_hotfix = (luaObj.RawGet("GetAllAdvertisementFlowLayouts") as LuaFunction);
					this.m_OnBuyStoreItemCallBackInt32Int32_hotfix = (luaObj.RawGet("OnBuyStoreItemCallBack") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06004606 RID: 17926 RVA: 0x00157424 File Offset: 0x00155624
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(OperationalActivityCompomentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040034EA RID: 13546
		protected IConfigDataLoader m_configDataLoader;

		// Token: 0x040034EB RID: 13547
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x040034EC RID: 13548
		protected BagComponentCommon m_bag;

		// Token: 0x040034ED RID: 13549
		protected AnikiGymComponentCommon m_anikiGym;

		// Token: 0x040034EE RID: 13550
		protected ThearchyTrialCompomentCommon m_thearchyTrial;

		// Token: 0x040034EF RID: 13551
		protected RiftComponentCommon m_rift;

		// Token: 0x040034F0 RID: 13552
		protected SelectCardComponentCommon m_selectCard;

		// Token: 0x040034F1 RID: 13553
		protected HeroDungeonComponentCommon m_heroDungeon;

		// Token: 0x040034F2 RID: 13554
		protected RaffleComponentCommon m_raffle;

		// Token: 0x040034F3 RID: 13555
		protected UnchartedScoreComponentCommon m_unchartedScore;

		// Token: 0x040034F4 RID: 13556
		protected FixedStoreComponentCommon m_fixedStore;

		// Token: 0x040034F5 RID: 13557
		protected RandomStoreComponentCommon m_randomStore;

		// Token: 0x040034F6 RID: 13558
		protected GiftStoreComponentCommon m_giftStore;

		// Token: 0x040034F7 RID: 13559
		protected RechargeStoreComponentCommon m_rechargeStore;

		// Token: 0x040034F8 RID: 13560
		protected DataSectionOperationalActivity m_operationalActivityDS;

		// Token: 0x040034F9 RID: 13561
		protected DataSectionAnnouncement m_announcementDS;

		// Token: 0x040034FA RID: 13562
		[DoNotToLua]
		private OperationalActivityCompomentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x040034FB RID: 13563
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040034FC RID: 13564
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040034FD RID: 13565
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040034FE RID: 13566
		private LuaFunction m_GetName_hotfix;

		// Token: 0x040034FF RID: 13567
		private LuaFunction m_Init_hotfix;

		// Token: 0x04003500 RID: 13568
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04003501 RID: 13569
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04003502 RID: 13570
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x04003503 RID: 13571
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x04003504 RID: 13572
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x04003505 RID: 13573
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x04003506 RID: 13574
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x04003507 RID: 13575
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x04003508 RID: 13576
		private LuaFunction m_OnFlushLoginDaysEvent_hotfix;

		// Token: 0x04003509 RID: 13577
		private LuaFunction m_OnFlushSuccessCallBackOperationalActivityBase_hotfix;

		// Token: 0x0400350A RID: 13578
		private LuaFunction m_OnPlayerLevelUpEventInt32_hotfix;

		// Token: 0x0400350B RID: 13579
		private LuaFunction m_AddNewOperationalActivityOperationalActivityBase_hotfix;

		// Token: 0x0400350C RID: 13580
		private LuaFunction m_InitNewNewOperationalActivityInfoOperationalActivityBase_hotfix;

		// Token: 0x0400350D RID: 13581
		private LuaFunction m_OnAddNewActivityCallBackOperationalActivityBase_hotfix;

		// Token: 0x0400350E RID: 13582
		private LuaFunction m_OnActivityInitCallBackOperationalActivityBase_hotfix;

		// Token: 0x0400350F RID: 13583
		private LuaFunction m_RemoveAllExpiredOperationalActivities_hotfix;

		// Token: 0x04003510 RID: 13584
		private LuaFunction m_CanExchangeItemGroupLimitedTimeExchangeOperationActivityInt32_hotfix;

		// Token: 0x04003511 RID: 13585
		private LuaFunction m_CanGainOperactionalActivityRewardOperationalActivityBaseInt32_hotfix;

		// Token: 0x04003512 RID: 13586
		private LuaFunction m_GetAllOperationalActivities_hotfix;

		// Token: 0x04003513 RID: 13587
		private LuaFunction m_GetAllValidOperationalActivities_hotfix;

		// Token: 0x04003514 RID: 13588
		private LuaFunction m_GetAwardOperationActivityRewardItemGroupIdByIndexOperationalActivityBaseInt32_hotfix;

		// Token: 0x04003515 RID: 13589
		private LuaFunction m_EffectOperationActivityGenerateEffectOperationalActivityBaseBoolean_hotfix;

		// Token: 0x04003516 RID: 13590
		private LuaFunction m_FindOperationalActivityByIdUInt64_hotfix;

		// Token: 0x04003517 RID: 13591
		private LuaFunction m_FindOperationalActivitiesByTypeOperationalActivityType_hotfix;

		// Token: 0x04003518 RID: 13592
		private LuaFunction m_FindOperationalActivityByActivityCardPoolIdInt32_hotfix;

		// Token: 0x04003519 RID: 13593
		private LuaFunction m_FindOperationalActivityByRafflePoolIdInt32_hotfix;

		// Token: 0x0400351A RID: 13594
		private LuaFunction m_FindOperationalActivityByUnchartedScoreIdInt32_hotfix;

		// Token: 0x0400351B RID: 13595
		private LuaFunction m_FindShowActivityByUnchartedScoreIdInt32_hotfix;

		// Token: 0x0400351C RID: 13596
		private LuaFunction m_OnAddRechargeRMBEventInt32DateTime_hotfix;

		// Token: 0x0400351D RID: 13597
		private LuaFunction m_OnConsumeCrystalEventInt32_hotfix;

		// Token: 0x0400351E RID: 13598
		private LuaFunction m_GetAllAdvertisementFlowLayouts_hotfix;

		// Token: 0x0400351F RID: 13599
		private LuaFunction m_OnBuyStoreItemCallBackInt32Int32_hotfix;

		// Token: 0x0200048D RID: 1165
		public class LuaExportHelper
		{
			// Token: 0x06004607 RID: 17927 RVA: 0x0015748C File Offset: 0x0015568C
			public LuaExportHelper(OperationalActivityCompomentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x170011D1 RID: 4561
			// (get) Token: 0x06004608 RID: 17928 RVA: 0x0015749C File Offset: 0x0015569C
			// (set) Token: 0x06004609 RID: 17929 RVA: 0x001574AC File Offset: 0x001556AC
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

			// Token: 0x170011D2 RID: 4562
			// (get) Token: 0x0600460A RID: 17930 RVA: 0x001574BC File Offset: 0x001556BC
			// (set) Token: 0x0600460B RID: 17931 RVA: 0x001574CC File Offset: 0x001556CC
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

			// Token: 0x170011D3 RID: 4563
			// (get) Token: 0x0600460C RID: 17932 RVA: 0x001574DC File Offset: 0x001556DC
			// (set) Token: 0x0600460D RID: 17933 RVA: 0x001574EC File Offset: 0x001556EC
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

			// Token: 0x170011D4 RID: 4564
			// (get) Token: 0x0600460E RID: 17934 RVA: 0x001574FC File Offset: 0x001556FC
			// (set) Token: 0x0600460F RID: 17935 RVA: 0x0015750C File Offset: 0x0015570C
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

			// Token: 0x170011D5 RID: 4565
			// (get) Token: 0x06004610 RID: 17936 RVA: 0x0015751C File Offset: 0x0015571C
			// (set) Token: 0x06004611 RID: 17937 RVA: 0x0015752C File Offset: 0x0015572C
			public ThearchyTrialCompomentCommon m_thearchyTrial
			{
				get
				{
					return this.m_owner.m_thearchyTrial;
				}
				set
				{
					this.m_owner.m_thearchyTrial = value;
				}
			}

			// Token: 0x170011D6 RID: 4566
			// (get) Token: 0x06004612 RID: 17938 RVA: 0x0015753C File Offset: 0x0015573C
			// (set) Token: 0x06004613 RID: 17939 RVA: 0x0015754C File Offset: 0x0015574C
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

			// Token: 0x170011D7 RID: 4567
			// (get) Token: 0x06004614 RID: 17940 RVA: 0x0015755C File Offset: 0x0015575C
			// (set) Token: 0x06004615 RID: 17941 RVA: 0x0015756C File Offset: 0x0015576C
			public SelectCardComponentCommon m_selectCard
			{
				get
				{
					return this.m_owner.m_selectCard;
				}
				set
				{
					this.m_owner.m_selectCard = value;
				}
			}

			// Token: 0x170011D8 RID: 4568
			// (get) Token: 0x06004616 RID: 17942 RVA: 0x0015757C File Offset: 0x0015577C
			// (set) Token: 0x06004617 RID: 17943 RVA: 0x0015758C File Offset: 0x0015578C
			public HeroDungeonComponentCommon m_heroDungeon
			{
				get
				{
					return this.m_owner.m_heroDungeon;
				}
				set
				{
					this.m_owner.m_heroDungeon = value;
				}
			}

			// Token: 0x170011D9 RID: 4569
			// (get) Token: 0x06004618 RID: 17944 RVA: 0x0015759C File Offset: 0x0015579C
			// (set) Token: 0x06004619 RID: 17945 RVA: 0x001575AC File Offset: 0x001557AC
			public RaffleComponentCommon m_raffle
			{
				get
				{
					return this.m_owner.m_raffle;
				}
				set
				{
					this.m_owner.m_raffle = value;
				}
			}

			// Token: 0x170011DA RID: 4570
			// (get) Token: 0x0600461A RID: 17946 RVA: 0x001575BC File Offset: 0x001557BC
			// (set) Token: 0x0600461B RID: 17947 RVA: 0x001575CC File Offset: 0x001557CC
			public UnchartedScoreComponentCommon m_unchartedScore
			{
				get
				{
					return this.m_owner.m_unchartedScore;
				}
				set
				{
					this.m_owner.m_unchartedScore = value;
				}
			}

			// Token: 0x170011DB RID: 4571
			// (get) Token: 0x0600461C RID: 17948 RVA: 0x001575DC File Offset: 0x001557DC
			// (set) Token: 0x0600461D RID: 17949 RVA: 0x001575EC File Offset: 0x001557EC
			public FixedStoreComponentCommon m_fixedStore
			{
				get
				{
					return this.m_owner.m_fixedStore;
				}
				set
				{
					this.m_owner.m_fixedStore = value;
				}
			}

			// Token: 0x170011DC RID: 4572
			// (get) Token: 0x0600461E RID: 17950 RVA: 0x001575FC File Offset: 0x001557FC
			// (set) Token: 0x0600461F RID: 17951 RVA: 0x0015760C File Offset: 0x0015580C
			public RandomStoreComponentCommon m_randomStore
			{
				get
				{
					return this.m_owner.m_randomStore;
				}
				set
				{
					this.m_owner.m_randomStore = value;
				}
			}

			// Token: 0x170011DD RID: 4573
			// (get) Token: 0x06004620 RID: 17952 RVA: 0x0015761C File Offset: 0x0015581C
			// (set) Token: 0x06004621 RID: 17953 RVA: 0x0015762C File Offset: 0x0015582C
			public GiftStoreComponentCommon m_giftStore
			{
				get
				{
					return this.m_owner.m_giftStore;
				}
				set
				{
					this.m_owner.m_giftStore = value;
				}
			}

			// Token: 0x170011DE RID: 4574
			// (get) Token: 0x06004622 RID: 17954 RVA: 0x0015763C File Offset: 0x0015583C
			// (set) Token: 0x06004623 RID: 17955 RVA: 0x0015764C File Offset: 0x0015584C
			public RechargeStoreComponentCommon m_rechargeStore
			{
				get
				{
					return this.m_owner.m_rechargeStore;
				}
				set
				{
					this.m_owner.m_rechargeStore = value;
				}
			}

			// Token: 0x170011DF RID: 4575
			// (get) Token: 0x06004624 RID: 17956 RVA: 0x0015765C File Offset: 0x0015585C
			// (set) Token: 0x06004625 RID: 17957 RVA: 0x0015766C File Offset: 0x0015586C
			public DataSectionOperationalActivity m_operationalActivityDS
			{
				get
				{
					return this.m_owner.m_operationalActivityDS;
				}
				set
				{
					this.m_owner.m_operationalActivityDS = value;
				}
			}

			// Token: 0x170011E0 RID: 4576
			// (get) Token: 0x06004626 RID: 17958 RVA: 0x0015767C File Offset: 0x0015587C
			// (set) Token: 0x06004627 RID: 17959 RVA: 0x0015768C File Offset: 0x0015588C
			public DataSectionAnnouncement m_announcementDS
			{
				get
				{
					return this.m_owner.m_announcementDS;
				}
				set
				{
					this.m_owner.m_announcementDS = value;
				}
			}

			// Token: 0x06004628 RID: 17960 RVA: 0x0015769C File Offset: 0x0015589C
			public void OnFlushSuccessCallBack(OperationalActivityBase activity)
			{
				this.m_owner.OnFlushSuccessCallBack(activity);
			}

			// Token: 0x06004629 RID: 17961 RVA: 0x001576AC File Offset: 0x001558AC
			public void AddNewOperationalActivity(OperationalActivityBase operationalActivity)
			{
				this.m_owner.AddNewOperationalActivity(operationalActivity);
			}

			// Token: 0x0600462A RID: 17962 RVA: 0x001576BC File Offset: 0x001558BC
			public void InitNewNewOperationalActivityInfo(OperationalActivityBase operationalActivityInfo)
			{
				this.m_owner.InitNewNewOperationalActivityInfo(operationalActivityInfo);
			}

			// Token: 0x0600462B RID: 17963 RVA: 0x001576CC File Offset: 0x001558CC
			public void OnAddNewActivityCallBack(OperationalActivityBase activity)
			{
				this.m_owner.OnAddNewActivityCallBack(activity);
			}

			// Token: 0x0600462C RID: 17964 RVA: 0x001576DC File Offset: 0x001558DC
			public void OnActivityInitCallBack(OperationalActivityBase activity)
			{
				this.m_owner.OnActivityInitCallBack(activity);
			}

			// Token: 0x0600462D RID: 17965 RVA: 0x001576EC File Offset: 0x001558EC
			public int GetAwardOperationActivityRewardItemGroupIdByIndex(OperationalActivityBase operationalActivity, int rewardIndex)
			{
				return this.m_owner.GetAwardOperationActivityRewardItemGroupIdByIndex(operationalActivity, rewardIndex);
			}

			// Token: 0x0600462E RID: 17966 RVA: 0x001576FC File Offset: 0x001558FC
			public void EffectOperationActivityGenerateEffect(OperationalActivityBase operationalActivity, bool isPositive)
			{
				this.m_owner.EffectOperationActivityGenerateEffect(operationalActivity, isPositive);
			}

			// Token: 0x0600462F RID: 17967 RVA: 0x0015770C File Offset: 0x0015590C
			public void OnAddRechargeRMBEvent(int nums, DateTime rechargeTime)
			{
				this.m_owner.OnAddRechargeRMBEvent(nums, rechargeTime);
			}

			// Token: 0x06004630 RID: 17968 RVA: 0x0015771C File Offset: 0x0015591C
			public void OnConsumeCrystalEvent(int nums)
			{
				this.m_owner.OnConsumeCrystalEvent(nums);
			}

			// Token: 0x04003520 RID: 13600
			private OperationalActivityCompomentCommon m_owner;
		}
	}
}
