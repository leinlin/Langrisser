using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004A8 RID: 1192
	[HotFix]
	public class SelectCardComponentCommon : IComponentBase
	{
		// Token: 0x06004883 RID: 18563 RVA: 0x00167960 File Offset: 0x00165B60
		public SelectCardComponentCommon()
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

		// Token: 0x06004884 RID: 18564 RVA: 0x001679D4 File Offset: 0x00165BD4
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
			return "SelectCard";
		}

		// Token: 0x06004885 RID: 18565 RVA: 0x00167A48 File Offset: 0x00165C48
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

		// Token: 0x06004886 RID: 18566 RVA: 0x00167AA8 File Offset: 0x00165CA8
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
			this.m_operationalActivity = (this.Owner.GetOwnerComponent("OperationalActivity") as OperationalActivityCompomentCommon);
		}

		// Token: 0x06004887 RID: 18567 RVA: 0x00167B5C File Offset: 0x00165D5C
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

		// Token: 0x06004888 RID: 18568 RVA: 0x00167BBC File Offset: 0x00165DBC
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

		// Token: 0x06004889 RID: 18569 RVA: 0x00167C2C File Offset: 0x00165E2C
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

		// Token: 0x0600488A RID: 18570 RVA: 0x00167CAC File Offset: 0x00165EAC
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

		// Token: 0x0600488B RID: 18571 RVA: 0x00167D1C File Offset: 0x00165F1C
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

		// Token: 0x17001218 RID: 4632
		// (get) Token: 0x0600488C RID: 18572 RVA: 0x00167D7C File Offset: 0x00165F7C
		// (set) Token: 0x0600488D RID: 18573 RVA: 0x00167DF0 File Offset: 0x00165FF0
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

		// Token: 0x0600488E RID: 18574 RVA: 0x00167E68 File Offset: 0x00166068
		public void RemoveCardPool(int cardPool)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RemoveCardPoolInt32_hotfix != null)
			{
				this.m_RemoveCardPoolInt32_hotfix.call(new object[]
				{
					this,
					cardPool
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_selectCardDS.RemoveCardPool(cardPool);
		}

		// Token: 0x0600488F RID: 18575 RVA: 0x00167EE4 File Offset: 0x001660E4
		protected void InitCardPoolConfigs(List<CardPool> cardPools)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitCardPoolConfigsList`1_hotfix != null)
			{
				this.m_InitCardPoolConfigsList`1_hotfix.call(new object[]
				{
					this,
					cardPools
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (CardPool cardPool in cardPools)
			{
				cardPool.Config = this.m_configDataLoader.GetConfigDataCardPoolInfo(cardPool.PoolId);
			}
		}

		// Token: 0x06004890 RID: 18576 RVA: 0x00167FB0 File Offset: 0x001661B0
		public int IsActivityCardPoolOnActivityTime(int activityCardPoolId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsActivityCardPoolOnActivityTimeInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_IsActivityCardPoolOnActivityTimeInt32_hotfix.call(new object[]
				{
					this,
					activityCardPoolId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.FindOperationalActivityByActivityCardPoolId(activityCardPoolId) == null)
			{
				return -1500;
			}
			return 0;
		}

		// Token: 0x06004891 RID: 18577 RVA: 0x00168044 File Offset: 0x00166244
		public OperationalActivityBase FindOperationalActivityByActivityCardPoolId(int activityCardPoolId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindOperationalActivityByActivityCardPoolIdInt32_hotfix != null)
			{
				return (OperationalActivityBase)this.m_FindOperationalActivityByActivityCardPoolIdInt32_hotfix.call(new object[]
				{
					this,
					activityCardPoolId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_operationalActivity.FindOperationalActivityByActivityCardPoolId(activityCardPoolId);
		}

		// Token: 0x06004892 RID: 18578 RVA: 0x001680CC File Offset: 0x001662CC
		public List<int> GetAllOpenActivityCardPool()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllOpenActivityCardPool_hotfix != null)
			{
				return (List<int>)this.m_GetAllOpenActivityCardPool_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<int> list = new List<int>();
			List<OperationalActivityBase> list2 = this.m_operationalActivity.FindOperationalActivitiesByType(OperationalActivityType.OperationalActivityType_ActivitySelectCard);
			foreach (OperationalActivityBase operationalActivityBase in list2)
			{
				foreach (ActivityParam activityParam in operationalActivityBase.Config.OperationalActivityParms)
				{
					if (!list.Contains(activityParam.Parm1))
					{
						list.Add(activityParam.Parm1);
					}
				}
			}
			return list;
		}

		// Token: 0x06004893 RID: 18579 RVA: 0x001681FC File Offset: 0x001663FC
		protected bool IsUsedOutActivityCardPoolSelectOpportunity(CardPool cardPool)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsUsedOutActivityCardPoolSelectOpportunityCardPool_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsUsedOutActivityCardPoolSelectOpportunityCardPool_hotfix.call(new object[]
				{
					this,
					cardPool
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int cardPoolSelectMaxCount = cardPool.Config.CardPoolSelectMaxCount;
			return cardPoolSelectMaxCount != 0 && cardPoolSelectMaxCount <= cardPool.SelectCardCount;
		}

		// Token: 0x06004894 RID: 18580 RVA: 0x00168298 File Offset: 0x00166498
		public CardPool GetCardPoolById(int cardPoolId, bool ignoreActivityCheck = true)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCardPoolByIdInt32Boolean_hotfix != null)
			{
				return (CardPool)this.m_GetCardPoolByIdInt32Boolean_hotfix.call(new object[]
				{
					this,
					cardPoolId,
					ignoreActivityCheck
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CardPool cardPool = this.m_selectCardDS.FindCardPool(cardPoolId);
			if (cardPool == null)
			{
				ConfigDataCardPoolInfo configDataCardPoolInfo = this.m_configDataLoader.GetConfigDataCardPoolInfo(cardPoolId);
				if (configDataCardPoolInfo == null)
				{
					return null;
				}
				if (configDataCardPoolInfo.PoolType == CardPoolType.CardPoolType_ActivityCardPool)
				{
					OperationalActivityBase operationalActivityBase = this.m_operationalActivity.FindOperationalActivityByActivityCardPoolId(cardPoolId);
					if (operationalActivityBase == null)
					{
						return null;
					}
					cardPool = new CardPool(cardPoolId);
					cardPool.ActivityInstanceId = operationalActivityBase.InstanceId;
				}
				else
				{
					cardPool = new CardPool(cardPoolId);
				}
				cardPool.Config = configDataCardPoolInfo;
			}
			else if (cardPool.Config.PoolType == CardPoolType.CardPoolType_ActivityCardPool && this.m_operationalActivity.FindOperationalActivityByActivityCardPoolId(cardPoolId) == null)
			{
				return null;
			}
			return cardPool;
		}

		// Token: 0x06004895 RID: 18581 RVA: 0x001683C0 File Offset: 0x001665C0
		protected bool IsTicketsEnough(int ticketId, int ticketCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsTicketsEnoughInt32Int32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsTicketsEnoughInt32Int32_hotfix.call(new object[]
				{
					this,
					ticketId,
					ticketCount
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_bag.IsBagItemEnough(GoodsType.GoodsType_Item, ticketId, ticketCount);
		}

		// Token: 0x06004896 RID: 18582 RVA: 0x0016845C File Offset: 0x0016665C
		public int GetCrystalCount(CardPool cardPool, bool isSingleSelect, out bool isTenSelectDiscount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCrystalCountCardPoolBooleanBoolean__hotfix != null)
			{
				return LuaDelegation.Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon_GetCrystalCount_CardPool_Boolean_Boolean(this, this.m_GetCrystalCountCardPoolBooleanBoolean__hotfix, cardPool, isSingleSelect, out isTenSelectDiscount);
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			isTenSelectDiscount = false;
			int result;
			if (isSingleSelect)
			{
				result = cardPool.Config.CrystalCost;
			}
			else
			{
				result = cardPool.Config.CrystalCost * 10;
				if (cardPool.Config.TenSelectDiscount != 0 && this.m_selectCardDS.CanTenSelectDiscount(cardPool))
				{
					isTenSelectDiscount = true;
					result = cardPool.Config.TenSelectDiscount;
				}
			}
			return result;
		}

		// Token: 0x06004897 RID: 18583 RVA: 0x00168518 File Offset: 0x00166718
		protected void SelectCardUseTickets(CardPool cardPool, bool isSingleSelect)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SelectCardUseTicketsCardPoolBoolean_hotfix != null)
			{
				this.m_SelectCardUseTicketsCardPoolBoolean_hotfix.call(new object[]
				{
					this,
					cardPool,
					isSingleSelect
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			int num2 = (!isSingleSelect) ? 10 : 1;
			if (this.IsCrystalOrActivityCardPool(cardPool.Config.PoolType))
			{
				BagItemBase bagItemBase = this.m_bag.FindBagItemByType(GoodsType.GoodsType_Item, cardPool.Config.TicketId);
				int num3 = (bagItemBase != null) ? bagItemBase.Nums : 0;
				if (num3 < num2)
				{
					num = (num2 - num3) * cardPool.Config.CrystalCost;
					num2 = num3;
				}
			}
			this.m_bag.RemoveBagItemByType(GoodsType.GoodsType_Item, cardPool.Config.TicketId, num2, GameFunctionType.GameFunctionType_SelectCard, cardPool.PoolId.ToString());
			this.OnSelectCardFinished(cardPool.PoolId, isSingleSelect);
			if (num > 0)
			{
				this.m_basicInfo.AddCrystal(-num, GameFunctionType.GameFunctionType_SelectCard, cardPool.PoolId.ToString());
			}
		}

		// Token: 0x06004898 RID: 18584 RVA: 0x0016866C File Offset: 0x0016686C
		protected void SelectCardUseCrystal(CardPool cardPool, bool isSingleSelect)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SelectCardUseCrystalCardPoolBoolean_hotfix != null)
			{
				this.m_SelectCardUseCrystalCardPoolBoolean_hotfix.call(new object[]
				{
					this,
					cardPool,
					isSingleSelect
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool flag = false;
			int crystalCount = this.GetCrystalCount(cardPool, isSingleSelect, out flag);
			this.m_basicInfo.AddCrystal(-crystalCount, GameFunctionType.GameFunctionType_SelectCard, cardPool.PoolId.ToString());
			if (flag)
			{
				this.m_selectCardDS.AddTenSelectDiscountCount(cardPool);
			}
			this.OnSelectCardFinished(cardPool.PoolId, isSingleSelect);
		}

		// Token: 0x06004899 RID: 18585 RVA: 0x0016873C File Offset: 0x0016693C
		protected int CanSelectCard(CardPool cardPool, bool isSingleSelect, bool isUsingTickets)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanSelectCardCardPoolBooleanBoolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanSelectCardCardPoolBooleanBoolean_hotfix.call(new object[]
				{
					this,
					cardPool,
					isSingleSelect,
					isUsingTickets
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!isSingleSelect && cardPool.Config.SelectType == CardSelectType.CardSelectType_SingleSelect)
			{
				return -1504;
			}
			if (!isUsingTickets && cardPool.Config.CrystalCost == 0)
			{
				return -1505;
			}
			CardPoolType poolType = cardPool.Config.PoolType;
			if (poolType != CardPoolType.CardPoolType_FreeCardPool)
			{
				if (poolType != CardPoolType.CardPoolType_CrystalCardPool)
				{
					if (poolType == CardPoolType.CardPoolType_ActivityCardPool)
					{
						if (this.IsUsedOutActivityCardPoolSelectOpportunity(cardPool))
						{
							return -1501;
						}
						if (!isUsingTickets)
						{
							return -1516;
						}
					}
				}
				else if (!isUsingTickets)
				{
					return -1513;
				}
			}
			else if (!isUsingTickets)
			{
				return -1506;
			}
			if (this.m_bag.IsBagFullByCurrentSize())
			{
				return -500;
			}
			if (isUsingTickets)
			{
				int ticketNums = (!isSingleSelect) ? 10 : 1;
				return this.CanUseTicketSelectCard(cardPool, ticketNums);
			}
			bool flag = false;
			int crystalCount = this.GetCrystalCount(cardPool, isSingleSelect, out flag);
			if (!this.m_basicInfo.IsCrystalEnough(crystalCount))
			{
				return -401;
			}
			return 0;
		}

		// Token: 0x0600489A RID: 18586 RVA: 0x001688D8 File Offset: 0x00166AD8
		protected bool IsCrystalOrActivityCardPool(CardPoolType cardPoolType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsCrystalOrActivityCardPoolCardPoolType_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsCrystalOrActivityCardPoolCardPoolType_hotfix.call(new object[]
				{
					this,
					cardPoolType
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return cardPoolType == CardPoolType.CardPoolType_CrystalCardPool || cardPoolType == CardPoolType.CardPoolType_ActivityCardPool;
		}

		// Token: 0x0600489B RID: 18587 RVA: 0x00168964 File Offset: 0x00166B64
		protected virtual int CanUseTicketSelectCard(CardPool cardPool, int ticketNums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanUseTicketSelectCardCardPoolInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanUseTicketSelectCardCardPoolInt32_hotfix.call(new object[]
				{
					this,
					cardPool,
					ticketNums
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsCrystalOrActivityCardPool(cardPool.Config.PoolType))
			{
				BagItemBase bagItemBase = this.m_bag.FindBagItemByType(GoodsType.GoodsType_Item, cardPool.Config.TicketId);
				if (bagItemBase == null || bagItemBase.Nums < ticketNums)
				{
					int num = (bagItemBase != null) ? bagItemBase.Nums : 0;
					int num2 = ticketNums - num;
					int consumeNums = num2 * cardPool.Config.CrystalCost;
					if (this.m_basicInfo.IsCrystalEnough(consumeNums))
					{
						return -1515;
					}
					return -1514;
				}
			}
			else if (!this.IsTicketsEnough(cardPool.Config.TicketId, ticketNums))
			{
				return -1502;
			}
			return 0;
		}

		// Token: 0x0600489C RID: 18588 RVA: 0x00168A98 File Offset: 0x00166C98
		private void OnSelectCardFinished(int cardPoolId, bool isSingleSelect)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSelectCardFinishedInt32Boolean_hotfix != null)
			{
				this.m_OnSelectCardFinishedInt32Boolean_hotfix.call(new object[]
				{
					this,
					cardPoolId,
					isSingleSelect
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.SelectCardMissionEvent != null)
			{
				int arg = (!isSingleSelect) ? 10 : 1;
				this.SelectCardMissionEvent(cardPoolId, arg);
			}
		}

		// Token: 0x0600489D RID: 18589 RVA: 0x00168B40 File Offset: 0x00166D40
		protected void SelectCardSpendTicketsOrCrystal(CardPool cardPool, bool isSingleSelect, bool isUsingTickets)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SelectCardSpendTicketsOrCrystalCardPoolBooleanBoolean_hotfix != null)
			{
				this.m_SelectCardSpendTicketsOrCrystalCardPoolBooleanBoolean_hotfix.call(new object[]
				{
					this,
					cardPool,
					isSingleSelect,
					isUsingTickets
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isUsingTickets)
			{
				this.SelectCardUseTickets(cardPool, isSingleSelect);
			}
			else
			{
				this.SelectCardUseCrystal(cardPool, isSingleSelect);
			}
		}

		// Token: 0x0600489E RID: 18590 RVA: 0x00168BEC File Offset: 0x00166DEC
		public virtual void SelectHeroCard(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SelectHeroCardInt32_hotfix != null)
			{
				this.m_SelectHeroCardInt32_hotfix.call(new object[]
				{
					this,
					heroId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.SummonHeroMissionEvent != null)
			{
				this.SummonHeroMissionEvent(heroId);
			}
		}

		// Token: 0x14000062 RID: 98
		// (add) Token: 0x0600489F RID: 18591 RVA: 0x00168C74 File Offset: 0x00166E74
		// (remove) Token: 0x060048A0 RID: 18592 RVA: 0x00168D10 File Offset: 0x00166F10
		public event Action<int, int> SelectCardMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_SelectCardMissionEventAction`2_hotfix != null)
				{
					this.m_add_SelectCardMissionEventAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int> action = this.SelectCardMissionEvent;
				Action<int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int>>(ref this.SelectCardMissionEvent, (Action<int, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_SelectCardMissionEventAction`2_hotfix != null)
				{
					this.m_remove_SelectCardMissionEventAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int> action = this.SelectCardMissionEvent;
				Action<int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int>>(ref this.SelectCardMissionEvent, (Action<int, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000063 RID: 99
		// (add) Token: 0x060048A1 RID: 18593 RVA: 0x00168DAC File Offset: 0x00166FAC
		// (remove) Token: 0x060048A2 RID: 18594 RVA: 0x00168E48 File Offset: 0x00167048
		public event Action<int> SummonHeroMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_SummonHeroMissionEventAction`1_hotfix != null)
				{
					this.m_add_SummonHeroMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.SummonHeroMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.SummonHeroMissionEvent, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_SummonHeroMissionEventAction`1_hotfix != null)
				{
					this.m_remove_SummonHeroMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.SummonHeroMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.SummonHeroMissionEvent, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17001219 RID: 4633
		// (get) Token: 0x060048A3 RID: 18595 RVA: 0x00168EE4 File Offset: 0x001670E4
		// (set) Token: 0x060048A4 RID: 18596 RVA: 0x00168F04 File Offset: 0x00167104
		[DoNotToLua]
		public SelectCardComponentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new SelectCardComponentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060048A5 RID: 18597 RVA: 0x00168F10 File Offset: 0x00167110
		private void __callDele_SelectCardMissionEvent(int arg1, int arg2)
		{
			Action<int, int> selectCardMissionEvent = this.SelectCardMissionEvent;
			if (selectCardMissionEvent != null)
			{
				selectCardMissionEvent(arg1, arg2);
			}
		}

		// Token: 0x060048A6 RID: 18598 RVA: 0x00168F34 File Offset: 0x00167134
		private void __clearDele_SelectCardMissionEvent(int arg1, int arg2)
		{
			this.SelectCardMissionEvent = null;
		}

		// Token: 0x060048A7 RID: 18599 RVA: 0x00168F40 File Offset: 0x00167140
		private void __callDele_SummonHeroMissionEvent(int obj)
		{
			Action<int> summonHeroMissionEvent = this.SummonHeroMissionEvent;
			if (summonHeroMissionEvent != null)
			{
				summonHeroMissionEvent(obj);
			}
		}

		// Token: 0x060048A8 RID: 18600 RVA: 0x00168F64 File Offset: 0x00167164
		private void __clearDele_SummonHeroMissionEvent(int obj)
		{
			this.SummonHeroMissionEvent = null;
		}

		// Token: 0x060048A9 RID: 18601 RVA: 0x00168F70 File Offset: 0x00167170
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
					this.m_RemoveCardPoolInt32_hotfix = (luaObj.RawGet("RemoveCardPool") as LuaFunction);
					this.m_InitCardPoolConfigsList`1_hotfix = (luaObj.RawGet("InitCardPoolConfigs") as LuaFunction);
					this.m_IsActivityCardPoolOnActivityTimeInt32_hotfix = (luaObj.RawGet("IsActivityCardPoolOnActivityTime") as LuaFunction);
					this.m_FindOperationalActivityByActivityCardPoolIdInt32_hotfix = (luaObj.RawGet("FindOperationalActivityByActivityCardPoolId") as LuaFunction);
					this.m_GetAllOpenActivityCardPool_hotfix = (luaObj.RawGet("GetAllOpenActivityCardPool") as LuaFunction);
					this.m_IsUsedOutActivityCardPoolSelectOpportunityCardPool_hotfix = (luaObj.RawGet("IsUsedOutActivityCardPoolSelectOpportunity") as LuaFunction);
					this.m_GetCardPoolByIdInt32Boolean_hotfix = (luaObj.RawGet("GetCardPoolById") as LuaFunction);
					this.m_IsTicketsEnoughInt32Int32_hotfix = (luaObj.RawGet("IsTicketsEnough") as LuaFunction);
					this.m_GetCrystalCountCardPoolBooleanBoolean__hotfix = (luaObj.RawGet("GetCrystalCount") as LuaFunction);
					this.m_SelectCardUseTicketsCardPoolBoolean_hotfix = (luaObj.RawGet("SelectCardUseTickets") as LuaFunction);
					this.m_SelectCardUseCrystalCardPoolBoolean_hotfix = (luaObj.RawGet("SelectCardUseCrystal") as LuaFunction);
					this.m_CanSelectCardCardPoolBooleanBoolean_hotfix = (luaObj.RawGet("CanSelectCard") as LuaFunction);
					this.m_IsCrystalOrActivityCardPoolCardPoolType_hotfix = (luaObj.RawGet("IsCrystalOrActivityCardPool") as LuaFunction);
					this.m_CanUseTicketSelectCardCardPoolInt32_hotfix = (luaObj.RawGet("CanUseTicketSelectCard") as LuaFunction);
					this.m_OnSelectCardFinishedInt32Boolean_hotfix = (luaObj.RawGet("OnSelectCardFinished") as LuaFunction);
					this.m_SelectCardSpendTicketsOrCrystalCardPoolBooleanBoolean_hotfix = (luaObj.RawGet("SelectCardSpendTicketsOrCrystal") as LuaFunction);
					this.m_SelectHeroCardInt32_hotfix = (luaObj.RawGet("SelectHeroCard") as LuaFunction);
					this.m_add_SelectCardMissionEventAction`2_hotfix = (luaObj.RawGet("add_SelectCardMissionEvent") as LuaFunction);
					this.m_remove_SelectCardMissionEventAction`2_hotfix = (luaObj.RawGet("remove_SelectCardMissionEvent") as LuaFunction);
					this.m_add_SummonHeroMissionEventAction`1_hotfix = (luaObj.RawGet("add_SummonHeroMissionEvent") as LuaFunction);
					this.m_remove_SummonHeroMissionEventAction`1_hotfix = (luaObj.RawGet("remove_SummonHeroMissionEvent") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060048AA RID: 18602 RVA: 0x00169344 File Offset: 0x00167544
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(SelectCardComponentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040036DE RID: 14046
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x040036DF RID: 14047
		protected IConfigDataLoader m_configDataLoader;

		// Token: 0x040036E0 RID: 14048
		protected BagComponentCommon m_bag;

		// Token: 0x040036E1 RID: 14049
		protected OperationalActivityCompomentCommon m_operationalActivity;

		// Token: 0x040036E2 RID: 14050
		protected DataSectionSelectCard m_selectCardDS = new DataSectionSelectCard();

		// Token: 0x040036E5 RID: 14053
		[DoNotToLua]
		private SelectCardComponentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x040036E6 RID: 14054
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040036E7 RID: 14055
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040036E8 RID: 14056
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040036E9 RID: 14057
		private LuaFunction m_GetName_hotfix;

		// Token: 0x040036EA RID: 14058
		private LuaFunction m_Init_hotfix;

		// Token: 0x040036EB RID: 14059
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x040036EC RID: 14060
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x040036ED RID: 14061
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x040036EE RID: 14062
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x040036EF RID: 14063
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x040036F0 RID: 14064
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x040036F1 RID: 14065
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x040036F2 RID: 14066
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x040036F3 RID: 14067
		private LuaFunction m_RemoveCardPoolInt32_hotfix;

		// Token: 0x040036F4 RID: 14068
		private LuaFunction m_InitCardPoolConfigsList;

		// Token: 0x040036F5 RID: 14069
		private LuaFunction m_IsActivityCardPoolOnActivityTimeInt32_hotfix;

		// Token: 0x040036F6 RID: 14070
		private LuaFunction m_FindOperationalActivityByActivityCardPoolIdInt32_hotfix;

		// Token: 0x040036F7 RID: 14071
		private LuaFunction m_GetAllOpenActivityCardPool_hotfix;

		// Token: 0x040036F8 RID: 14072
		private LuaFunction m_IsUsedOutActivityCardPoolSelectOpportunityCardPool_hotfix;

		// Token: 0x040036F9 RID: 14073
		private LuaFunction m_GetCardPoolByIdInt32Boolean_hotfix;

		// Token: 0x040036FA RID: 14074
		private LuaFunction m_IsTicketsEnoughInt32Int32_hotfix;

		// Token: 0x040036FB RID: 14075
		private LuaFunction m_GetCrystalCountCardPoolBooleanBoolean__hotfix;

		// Token: 0x040036FC RID: 14076
		private LuaFunction m_SelectCardUseTicketsCardPoolBoolean_hotfix;

		// Token: 0x040036FD RID: 14077
		private LuaFunction m_SelectCardUseCrystalCardPoolBoolean_hotfix;

		// Token: 0x040036FE RID: 14078
		private LuaFunction m_CanSelectCardCardPoolBooleanBoolean_hotfix;

		// Token: 0x040036FF RID: 14079
		private LuaFunction m_IsCrystalOrActivityCardPoolCardPoolType_hotfix;

		// Token: 0x04003700 RID: 14080
		private LuaFunction m_CanUseTicketSelectCardCardPoolInt32_hotfix;

		// Token: 0x04003701 RID: 14081
		private LuaFunction m_OnSelectCardFinishedInt32Boolean_hotfix;

		// Token: 0x04003702 RID: 14082
		private LuaFunction m_SelectCardSpendTicketsOrCrystalCardPoolBooleanBoolean_hotfix;

		// Token: 0x04003703 RID: 14083
		private LuaFunction m_SelectHeroCardInt32_hotfix;

		// Token: 0x04003704 RID: 14084
		private LuaFunction m_add_SelectCardMissionEventAction;

		// Token: 0x04003705 RID: 14085
		private LuaFunction m_remove_SelectCardMissionEventAction;

		// Token: 0x04003706 RID: 14086
		private LuaFunction m_add_SummonHeroMissionEventAction;

		// Token: 0x04003707 RID: 14087
		private LuaFunction m_remove_SummonHeroMissionEventAction;

		// Token: 0x020004A9 RID: 1193
		public class LuaExportHelper
		{
			// Token: 0x060048AB RID: 18603 RVA: 0x001693AC File Offset: 0x001675AC
			public LuaExportHelper(SelectCardComponentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060048AC RID: 18604 RVA: 0x001693BC File Offset: 0x001675BC
			public void __callDele_SelectCardMissionEvent(int arg1, int arg2)
			{
				this.m_owner.__callDele_SelectCardMissionEvent(arg1, arg2);
			}

			// Token: 0x060048AD RID: 18605 RVA: 0x001693CC File Offset: 0x001675CC
			public void __clearDele_SelectCardMissionEvent(int arg1, int arg2)
			{
				this.m_owner.__clearDele_SelectCardMissionEvent(arg1, arg2);
			}

			// Token: 0x060048AE RID: 18606 RVA: 0x001693DC File Offset: 0x001675DC
			public void __callDele_SummonHeroMissionEvent(int obj)
			{
				this.m_owner.__callDele_SummonHeroMissionEvent(obj);
			}

			// Token: 0x060048AF RID: 18607 RVA: 0x001693EC File Offset: 0x001675EC
			public void __clearDele_SummonHeroMissionEvent(int obj)
			{
				this.m_owner.__clearDele_SummonHeroMissionEvent(obj);
			}

			// Token: 0x1700121A RID: 4634
			// (get) Token: 0x060048B0 RID: 18608 RVA: 0x001693FC File Offset: 0x001675FC
			// (set) Token: 0x060048B1 RID: 18609 RVA: 0x0016940C File Offset: 0x0016760C
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

			// Token: 0x1700121B RID: 4635
			// (get) Token: 0x060048B2 RID: 18610 RVA: 0x0016941C File Offset: 0x0016761C
			// (set) Token: 0x060048B3 RID: 18611 RVA: 0x0016942C File Offset: 0x0016762C
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

			// Token: 0x1700121C RID: 4636
			// (get) Token: 0x060048B4 RID: 18612 RVA: 0x0016943C File Offset: 0x0016763C
			// (set) Token: 0x060048B5 RID: 18613 RVA: 0x0016944C File Offset: 0x0016764C
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

			// Token: 0x1700121D RID: 4637
			// (get) Token: 0x060048B6 RID: 18614 RVA: 0x0016945C File Offset: 0x0016765C
			// (set) Token: 0x060048B7 RID: 18615 RVA: 0x0016946C File Offset: 0x0016766C
			public OperationalActivityCompomentCommon m_operationalActivity
			{
				get
				{
					return this.m_owner.m_operationalActivity;
				}
				set
				{
					this.m_owner.m_operationalActivity = value;
				}
			}

			// Token: 0x1700121E RID: 4638
			// (get) Token: 0x060048B8 RID: 18616 RVA: 0x0016947C File Offset: 0x0016767C
			// (set) Token: 0x060048B9 RID: 18617 RVA: 0x0016948C File Offset: 0x0016768C
			public DataSectionSelectCard m_selectCardDS
			{
				get
				{
					return this.m_owner.m_selectCardDS;
				}
				set
				{
					this.m_owner.m_selectCardDS = value;
				}
			}

			// Token: 0x060048BA RID: 18618 RVA: 0x0016949C File Offset: 0x0016769C
			public void InitCardPoolConfigs(List<CardPool> cardPools)
			{
				this.m_owner.InitCardPoolConfigs(cardPools);
			}

			// Token: 0x060048BB RID: 18619 RVA: 0x001694AC File Offset: 0x001676AC
			public bool IsUsedOutActivityCardPoolSelectOpportunity(CardPool cardPool)
			{
				return this.m_owner.IsUsedOutActivityCardPoolSelectOpportunity(cardPool);
			}

			// Token: 0x060048BC RID: 18620 RVA: 0x001694BC File Offset: 0x001676BC
			public bool IsTicketsEnough(int ticketId, int ticketCount)
			{
				return this.m_owner.IsTicketsEnough(ticketId, ticketCount);
			}

			// Token: 0x060048BD RID: 18621 RVA: 0x001694CC File Offset: 0x001676CC
			public void SelectCardUseTickets(CardPool cardPool, bool isSingleSelect)
			{
				this.m_owner.SelectCardUseTickets(cardPool, isSingleSelect);
			}

			// Token: 0x060048BE RID: 18622 RVA: 0x001694DC File Offset: 0x001676DC
			public void SelectCardUseCrystal(CardPool cardPool, bool isSingleSelect)
			{
				this.m_owner.SelectCardUseCrystal(cardPool, isSingleSelect);
			}

			// Token: 0x060048BF RID: 18623 RVA: 0x001694EC File Offset: 0x001676EC
			public int CanSelectCard(CardPool cardPool, bool isSingleSelect, bool isUsingTickets)
			{
				return this.m_owner.CanSelectCard(cardPool, isSingleSelect, isUsingTickets);
			}

			// Token: 0x060048C0 RID: 18624 RVA: 0x001694FC File Offset: 0x001676FC
			public bool IsCrystalOrActivityCardPool(CardPoolType cardPoolType)
			{
				return this.m_owner.IsCrystalOrActivityCardPool(cardPoolType);
			}

			// Token: 0x060048C1 RID: 18625 RVA: 0x0016950C File Offset: 0x0016770C
			public int CanUseTicketSelectCard(CardPool cardPool, int ticketNums)
			{
				return this.m_owner.CanUseTicketSelectCard(cardPool, ticketNums);
			}

			// Token: 0x060048C2 RID: 18626 RVA: 0x0016951C File Offset: 0x0016771C
			public void OnSelectCardFinished(int cardPoolId, bool isSingleSelect)
			{
				this.m_owner.OnSelectCardFinished(cardPoolId, isSingleSelect);
			}

			// Token: 0x060048C3 RID: 18627 RVA: 0x0016952C File Offset: 0x0016772C
			public void SelectCardSpendTicketsOrCrystal(CardPool cardPool, bool isSingleSelect, bool isUsingTickets)
			{
				this.m_owner.SelectCardSpendTicketsOrCrystal(cardPool, isSingleSelect, isUsingTickets);
			}

			// Token: 0x04003708 RID: 14088
			private SelectCardComponentCommon m_owner;
		}
	}
}
