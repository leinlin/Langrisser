using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;
using BlackJack.UtilityTools;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000430 RID: 1072
	[HotFix]
	public class BagComponentCommon : IComponentBase
	{
		// Token: 0x06003E05 RID: 15877 RVA: 0x001191E8 File Offset: 0x001173E8
		public BagComponentCommon()
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

		// Token: 0x06003E06 RID: 15878 RVA: 0x00119250 File Offset: 0x00117450
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
			return "Bag";
		}

		// Token: 0x06003E07 RID: 15879 RVA: 0x001192C4 File Offset: 0x001174C4
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
			this.m_bagDS = new DataSectionBag();
			this.m_bagItemFactory = new BagItemFactory();
			this.m_bagItemFactory.ConfigDataLoader = this.m_configDataLoader;
		}

		// Token: 0x06003E08 RID: 15880 RVA: 0x0011934C File Offset: 0x0011754C
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
			this.m_hero = (this.Owner.GetOwnerComponent("Hero") as HeroComponentCommon);
			this.m_resource = (this.Owner.GetOwnerComponent("Resource") as ResourceComponentCommon);
		}

		// Token: 0x06003E09 RID: 15881 RVA: 0x00119400 File Offset: 0x00117600
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

		// Token: 0x06003E0A RID: 15882 RVA: 0x00119460 File Offset: 0x00117660
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

		// Token: 0x06003E0B RID: 15883 RVA: 0x001194D0 File Offset: 0x001176D0
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

		// Token: 0x06003E0C RID: 15884 RVA: 0x00119550 File Offset: 0x00117750
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

		// Token: 0x06003E0D RID: 15885 RVA: 0x001195C0 File Offset: 0x001177C0
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

		// Token: 0x170010D6 RID: 4310
		// (get) Token: 0x06003E0E RID: 15886 RVA: 0x00119620 File Offset: 0x00117820
		// (set) Token: 0x06003E0F RID: 15887 RVA: 0x00119694 File Offset: 0x00117894
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

		// Token: 0x06003E10 RID: 15888 RVA: 0x0011970C File Offset: 0x0011790C
		public int IsGoodsEnough(List<Goods> conditions, out List<BagItemBase> BagItemsInBag)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsGoodsEnoughList`1List`1__hotfix != null)
			{
				return LuaDelegation.Lua_BlackJack_ProjectL_Common_BagComponentCommon_IsGoodsEnough_List1_List1(this, this.m_IsGoodsEnoughList`1List`1__hotfix, conditions, out BagItemsInBag);
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BagItemsInBag = new List<BagItemBase>();
			List<Goods> list = new List<Goods>();
			foreach (Goods goods in conditions)
			{
				if (goods.Count <= 0)
				{
					return -523;
				}
				GoodsType goodsType = goods.GoodsType;
				switch (goodsType)
				{
				case GoodsType.GoodsType_Gold:
					if (!this.m_basicInfo.IsGoldEnough(goods.Count))
					{
						return -400;
					}
					break;
				case GoodsType.GoodsType_Crystal:
					if (!this.m_basicInfo.IsCrystalEnough(goods.Count))
					{
						return -401;
					}
					break;
				case GoodsType.GoodsType_Energy:
					if (!this.m_basicInfo.IsEnergyEnough(goods.Count))
					{
						return -402;
					}
					break;
				default:
					switch (goodsType)
					{
					case GoodsType.GoodsType_SkinTicket:
						if (!this.m_basicInfo.IsSkinTicketEnough(goods.Count))
						{
							return -416;
						}
						break;
					case GoodsType.GoodsType_RealTimePVPHonor:
						if (!this.m_basicInfo.IsRealTimePVPHonorEnough(goods.Count))
						{
							return -415;
						}
						break;
					case GoodsType.GoodsType_MemoryEssence:
						if (!this.m_basicInfo.IsMemoryEssenceEnough(goods.Count))
						{
							return -419;
						}
						break;
					case GoodsType.GoodsType_MithralStone:
						if (!this.m_basicInfo.IsMithralStoneEnough(goods.Count))
						{
							return -421;
						}
						break;
					case GoodsType.GoodsType_BrillianceMithralStone:
						if (!this.m_basicInfo.IsBrillianceMithralStoneEnough(goods.Count))
						{
							return -420;
						}
						break;
					case GoodsType.GoodsType_GuildMedal:
						if (!this.m_basicInfo.IsGuildMedalEnough(goods.Count))
						{
							return -5239;
						}
						break;
					default:
					{
						if (!BagItemBase.IsBagItem(goodsType))
						{
							return -403;
						}
						if (BagItemBase.IsInstanceBagItem(goodsType))
						{
							return -403;
						}
						int num = this.IsBagItemContentIdInConfig(goodsType, goods.Id);
						if (num != 0)
						{
							return num;
						}
						list.Add(goods);
						break;
					}
					}
					break;
				case GoodsType.GoodsType_ArenaTicket:
					if (!this.m_basicInfo.IsArenaTicketsEnough(goods.Count))
					{
						return -2000;
					}
					break;
				case GoodsType.GoodsType_ArenaHonour:
					if (!this.m_basicInfo.IsArenaHonourEnough(goods.Count))
					{
						return -409;
					}
					break;
				case GoodsType.GoodsType_FriendshipPoints:
					if (!this.m_basicInfo.IsFriendshipPointsEnough(goods.Count))
					{
						return -417;
					}
					break;
				}
			}
			BagItemsInBag = this.FindEnoughBagItems(list);
			return (BagItemsInBag.Count != list.Count) ? -503 : 0;
		}

		// Token: 0x06003E11 RID: 15889 RVA: 0x00119A98 File Offset: 0x00117C98
		public void ConsumeGoods(List<Goods> needToConsumeGoods, List<BagItemBase> BagItemsInBag = null, List<BagItemBase> changedGoods = null, GameFunctionType causeId = GameFunctionType.GameFunctionType_None, string location = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ConsumeGoodsList`1List`1List`1GameFunctionTypeString_hotfix != null)
			{
				this.m_ConsumeGoodsList`1List`1List`1GameFunctionTypeString_hotfix.call(new object[]
				{
					this,
					needToConsumeGoods,
					BagItemsInBag,
					changedGoods,
					causeId,
					location
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			foreach (Goods goods in needToConsumeGoods)
			{
				GoodsType goodsType = goods.GoodsType;
				switch (goodsType)
				{
				case GoodsType.GoodsType_Gold:
				{
					int nums = this.m_basicInfo.AddGold(-goods.Count, causeId, location);
					if (changedGoods != null)
					{
						changedGoods.Add(new BagItemBase(goods.GoodsType, goods.Id, nums, 0UL));
					}
					break;
				}
				case GoodsType.GoodsType_Crystal:
				{
					int nums = this.m_basicInfo.AddCrystal(-goods.Count, causeId, location);
					if (changedGoods != null)
					{
						changedGoods.Add(new BagItemBase(goods.GoodsType, goods.Id, nums, 0UL));
					}
					break;
				}
				case GoodsType.GoodsType_Energy:
				{
					int nums = this.m_basicInfo.DecreaseEnergy(goods.Count, causeId, location);
					if (changedGoods != null)
					{
						changedGoods.Add(new BagItemBase(goods.GoodsType, goods.Id, nums, 0UL));
					}
					break;
				}
				default:
					switch (goodsType)
					{
					case GoodsType.GoodsType_SkinTicket:
					{
						int nums = this.m_basicInfo.AddSkinTickets(-goods.Count, causeId, location);
						if (changedGoods != null)
						{
							changedGoods.Add(new BagItemBase(goods.GoodsType, goods.Id, nums, 0UL));
						}
						break;
					}
					case GoodsType.GoodsType_RealTimePVPHonor:
					{
						int nums = this.m_basicInfo.AddRealTimePVPHonor(-goods.Count, causeId, location);
						if (changedGoods != null)
						{
							changedGoods.Add(new BagItemBase(goods.GoodsType, goods.Id, nums, 0UL));
						}
						break;
					}
					case GoodsType.GoodsType_MemoryEssence:
					{
						int nums = this.m_basicInfo.AddMemoryEssence(-goods.Count, causeId, location);
						if (changedGoods != null)
						{
							changedGoods.Add(new BagItemBase(goods.GoodsType, goods.Id, nums, 0UL));
						}
						break;
					}
					case GoodsType.GoodsType_MithralStone:
					{
						int nums = this.m_basicInfo.AddMithralStone(-goods.Count, causeId, location);
						if (changedGoods != null)
						{
							changedGoods.Add(new BagItemBase(goods.GoodsType, goods.Id, nums, 0UL));
						}
						break;
					}
					case GoodsType.GoodsType_BrillianceMithralStone:
					{
						int nums = this.m_basicInfo.AddBrillianceMithralStone(-goods.Count, causeId, location);
						if (changedGoods != null)
						{
							changedGoods.Add(new BagItemBase(goods.GoodsType, goods.Id, nums, 0UL));
						}
						break;
					}
					case GoodsType.GoodsType_GuildMedal:
					{
						int nums = this.m_basicInfo.AddGuildMedal(-goods.Count, causeId, location);
						if (changedGoods != null)
						{
							changedGoods.Add(new BagItemBase(goods.GoodsType, goods.Id, nums, 0UL));
						}
						break;
					}
					default:
						if (BagItemBase.IsBagItem(goodsType))
						{
							if (BagItemsInBag != null)
							{
								BagItemBase item = this.RemoveBagItemDirectly(BagItemsInBag[num++], goods.Count, causeId, location);
								if (changedGoods != null)
								{
									changedGoods.Add(item);
								}
							}
							else
							{
								BagItemBase bagItem = this.FindBagItemByType(goodsType, goods.Id);
								BagItemBase item2 = this.RemoveBagItemDirectly(bagItem, goods.Count, causeId, location);
								if (changedGoods != null)
								{
									changedGoods.Add(item2);
								}
							}
						}
						break;
					}
					break;
				case GoodsType.GoodsType_ArenaTicket:
				{
					int nums = this.m_basicInfo.AddArenaTickets(-goods.Count, false, causeId, location);
					if (changedGoods != null)
					{
						changedGoods.Add(new BagItemBase(goods.GoodsType, goods.Id, nums, 0UL));
					}
					break;
				}
				case GoodsType.GoodsType_ArenaHonour:
				{
					int nums = this.m_basicInfo.AddArenaHonour(-goods.Count, causeId, location);
					if (changedGoods != null)
					{
						changedGoods.Add(new BagItemBase(goods.GoodsType, goods.Id, nums, 0UL));
					}
					break;
				}
				case GoodsType.GoodsType_FriendshipPoints:
				{
					int nums = this.m_basicInfo.AddFriendshipPoints(-goods.Count, causeId, location);
					if (changedGoods != null)
					{
						changedGoods.Add(new BagItemBase(goods.GoodsType, goods.Id, nums, 0UL));
					}
					break;
				}
				}
			}
		}

		// Token: 0x06003E12 RID: 15890 RVA: 0x00119F60 File Offset: 0x00118160
		private int CountIncreaseBagSize(List<Goods> addBagItems)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CountIncreaseBagSizeList`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_CountIncreaseBagSizeList`1_hotfix.call(new object[]
				{
					this,
					addBagItems
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (addBagItems == null)
			{
				return 0;
			}
			int num = 0;
			foreach (Goods goods in addBagItems)
			{
				if (BagItemBase.IsInstanceBagItem(goods.GoodsType))
				{
					num += goods.Count;
				}
				else if (this.m_bagDS.FindBagItem(goods.GoodsType, goods.Id) == null)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06003E13 RID: 15891 RVA: 0x0011A06C File Offset: 0x0011826C
		private int CountDecreaseBagSize(List<Goods> deleteBagItems)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CountDecreaseBagSizeList`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_CountDecreaseBagSizeList`1_hotfix.call(new object[]
				{
					this,
					deleteBagItems
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (deleteBagItems == null)
			{
				return 0;
			}
			int num = 0;
			foreach (Goods goods in deleteBagItems)
			{
				BagItemBase bagItemBase = this.m_bagDS.FindBagItem(goods.GoodsType, goods.Id);
				if (bagItemBase.Nums == goods.Count)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06003E14 RID: 15892 RVA: 0x0011A168 File Offset: 0x00118368
		public bool IsBagFullByRandomGoods(int addRandomRewardExpectSize, List<Goods> addGoods = null, List<Goods> deleteGoods = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsBagFullByRandomGoodsInt32List`1List`1_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsBagFullByRandomGoodsInt32List`1List`1_hotfix.call(new object[]
				{
					this,
					addRandomRewardExpectSize,
					addGoods,
					deleteGoods
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.IsBagFullByGoodsOperation(addGoods, deleteGoods, addRandomRewardExpectSize);
		}

		// Token: 0x06003E15 RID: 15893 RVA: 0x0011A210 File Offset: 0x00118410
		public bool IsBagFullByGoods(List<Goods> addGoods = null, List<Goods> deleteGoods = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsBagFullByGoodsList`1List`1_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsBagFullByGoodsList`1List`1_hotfix.call(new object[]
				{
					this,
					addGoods,
					deleteGoods
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.IsBagFullByGoodsOperation(addGoods, deleteGoods, 0);
		}

		// Token: 0x06003E16 RID: 15894 RVA: 0x0011A2A8 File Offset: 0x001184A8
		private bool IsBagFullByGoodsOperation(List<Goods> addGoods = null, List<Goods> deleteGoods = null, int addRandomRewardExpectSize = 0)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsBagFullByGoodsOperationList`1List`1Int32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsBagFullByGoodsOperationList`1List`1Int32_hotfix.call(new object[]
				{
					this,
					addGoods,
					deleteGoods,
					addRandomRewardExpectSize
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Goods> addBagItems = this.FilterNonBagItemsWhenAdd(addGoods);
			List<Goods> deleteBagItems = this.FilterNonBagItem(deleteGoods);
			return this.IsBagFullByBagItems(addBagItems, deleteBagItems, addRandomRewardExpectSize);
		}

		// Token: 0x06003E17 RID: 15895 RVA: 0x0011A360 File Offset: 0x00118560
		private bool IsBagFullByBagItems(List<Goods> addBagItems = null, List<Goods> deleteBagItems = null, int addRandomRewardExpectSize = 0)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsBagFullByBagItemsList`1List`1Int32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsBagFullByBagItemsList`1List`1Int32_hotfix.call(new object[]
				{
					this,
					addBagItems,
					deleteBagItems,
					addRandomRewardExpectSize
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (addRandomRewardExpectSize == 0 && !this.IsHeuristicBagFull(addBagItems))
			{
				return false;
			}
			int num = this.CountIncreaseBagSize(addBagItems);
			int num2 = this.CountDecreaseBagSize(deleteBagItems);
			int expectSize = this.m_bagDS.Size() + addRandomRewardExpectSize + num - num2;
			return this.IsBagFull(expectSize);
		}

		// Token: 0x06003E18 RID: 15896 RVA: 0x0011A43C File Offset: 0x0011863C
		public bool IsBagFull(int expectSize)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsBagFullInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsBagFullInt32_hotfix.call(new object[]
				{
					this,
					expectSize
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return expectSize > this.m_configDataLoader.ConfigableConstId_BagMaxCapacity;
		}

		// Token: 0x06003E19 RID: 15897 RVA: 0x0011A4C8 File Offset: 0x001186C8
		public int GetBagSize()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetBagSize_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetBagSize_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_bagDS.Size();
		}

		// Token: 0x06003E1A RID: 15898 RVA: 0x0011A540 File Offset: 0x00118740
		public bool IsBagFullByCurrentSize()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsBagFullByCurrentSize_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsBagFullByCurrentSize_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.GetBagSize() >= this.m_configDataLoader.ConfigableConstId_BagMaxCapacity;
		}

		// Token: 0x06003E1B RID: 15899 RVA: 0x0011A5C4 File Offset: 0x001187C4
		private bool IsHeuristicBagFull(List<Goods> adds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsHeuristicBagFullList`1_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsHeuristicBagFullList`1_hotfix.call(new object[]
				{
					this,
					adds
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (adds == null)
			{
				return false;
			}
			int num = this.m_bagDS.Size();
			foreach (Goods goods in adds)
			{
				if (BagItemBase.IsInstanceBagItem(goods.GoodsType))
				{
					num += goods.Count;
				}
				else
				{
					num++;
				}
			}
			return this.IsBagFull(num);
		}

		// Token: 0x06003E1C RID: 15900 RVA: 0x0011A6C0 File Offset: 0x001188C0
		private List<Goods> FilterNonBagItem(List<Goods> goods)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FilterNonBagItemList`1_hotfix != null)
			{
				return (List<Goods>)this.m_FilterNonBagItemList`1_hotfix.call(new object[]
				{
					this,
					goods
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (goods == null)
			{
				return null;
			}
			List<Goods> list = new List<Goods>();
			foreach (Goods goods2 in goods)
			{
				if (BagItemBase.IsBagItem(goods2.GoodsType))
				{
					list.Add(goods2);
				}
			}
			return list;
		}

		// Token: 0x06003E1D RID: 15901 RVA: 0x0011A7A8 File Offset: 0x001189A8
		private List<Goods> FilterNonBagItemsWhenAdd(List<Goods> goodsList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FilterNonBagItemsWhenAddList`1_hotfix != null)
			{
				return (List<Goods>)this.m_FilterNonBagItemsWhenAddList`1_hotfix.call(new object[]
				{
					this,
					goodsList
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (goodsList == null)
			{
				return null;
			}
			List<Goods> list = new List<Goods>();
			foreach (Goods goods in goodsList)
			{
				if (BagItemBase.IsBagItem(goods.GoodsType))
				{
					list.Add(goods);
				}
				else if (goods.GoodsType == GoodsType.GoodsType_Hero)
				{
					foreach (Goods goods2 in this.TransformHeroGoods(goods.Id, goods.Count))
					{
						if (goods2.GoodsType == GoodsType.GoodsType_Item)
						{
							list.Add(goods2);
							break;
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06003E1E RID: 15902 RVA: 0x0011A908 File Offset: 0x00118B08
		protected List<Goods> TransformHeroGoods(int heroId, int nums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TransformHeroGoodsInt32Int32_hotfix != null)
			{
				return (List<Goods>)this.m_TransformHeroGoodsInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					nums
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.m_hero.FindHero(heroId);
			List<Goods> list = new List<Goods>();
			int num = nums;
			if (hero == null)
			{
				num--;
				Goods item = new Goods
				{
					GoodsType = GoodsType.GoodsType_Hero,
					Id = heroId,
					Count = 1
				};
				list.Add(item);
			}
			if (num > 0)
			{
				ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(heroId);
				int count = num * configDataHeroInfo.ExchangedFragmentCount;
				Goods item2 = new Goods
				{
					GoodsType = GoodsType.GoodsType_Item,
					Id = configDataHeroInfo.FragmentItem_ID,
					Count = count
				};
				list.Add(item2);
			}
			return list;
		}

		// Token: 0x06003E1F RID: 15903 RVA: 0x0011AA30 File Offset: 0x00118C30
		public int IsBagItemContentIdInConfig(GoodsType goodsTypeId, int contentId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsBagItemContentIdInConfigGoodsTypeInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_IsBagItemContentIdInConfigGoodsTypeInt32_hotfix.call(new object[]
				{
					this,
					goodsTypeId,
					contentId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (goodsTypeId == GoodsType.GoodsType_Item)
			{
				return (this.m_configDataLoader.GetConfigDataItemInfo(contentId) == null) ? -505 : 0;
			}
			if (goodsTypeId == GoodsType.GoodsType_JobMaterial)
			{
				return (this.m_configDataLoader.GetConfigDataJobMaterialInfo(contentId) == null) ? -504 : 0;
			}
			if (goodsTypeId == GoodsType.GoodsType_EnchantStone)
			{
				return (this.m_configDataLoader.GetConfigDataEnchantStoneInfo(contentId) == null) ? -505 : 0;
			}
			return (this.m_configDataLoader.GetConfigDataEquipmentInfo(contentId) == null) ? -522 : 0;
		}

		// Token: 0x06003E20 RID: 15904 RVA: 0x0011AB48 File Offset: 0x00118D48
		public void RemoveAllBagItems(List<BagItemBase> changedBagItems = null, int removeItemMaxNums = 2147483647)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RemoveAllBagItemsList`1Int32_hotfix != null)
			{
				this.m_RemoveAllBagItemsList`1Int32_hotfix.call(new object[]
				{
					this,
					changedBagItems,
					removeItemMaxNums
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			List<BagItemBase> allBagItems = this.m_bagDS.GetAllBagItems();
			foreach (BagItemBase bagItemBase in allBagItems)
			{
				if (num >= removeItemMaxNums)
				{
					break;
				}
				EquipmentBagItem equipmentBagItem = bagItemBase as EquipmentBagItem;
				if (equipmentBagItem == null || !this.m_hero.IsEquipmentWeared(equipmentBagItem.InstanceId))
				{
					num++;
					this.RemoveBagItemByItem(bagItemBase, bagItemBase.Nums, GameFunctionType.GameFunctionType_None, null);
					if (changedBagItems != null)
					{
						changedBagItems.Add(bagItemBase);
					}
				}
			}
		}

		// Token: 0x06003E21 RID: 15905 RVA: 0x0011AC70 File Offset: 0x00118E70
		public int RemoveBagItem(GoodsType goodsTypeId, int contentId, int consumeNums, ulong instanceId, GameFunctionType caseId = GameFunctionType.GameFunctionType_None, string location = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RemoveBagItemGoodsTypeInt32Int32UInt64GameFunctionTypeString_hotfix != null)
			{
				return Convert.ToInt32(this.m_RemoveBagItemGoodsTypeInt32Int32UInt64GameFunctionTypeString_hotfix.call(new object[]
				{
					this,
					goodsTypeId,
					contentId,
					consumeNums,
					instanceId,
					caseId,
					location
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BagItemBase bagItem = this.FindBagItem(goodsTypeId, contentId, instanceId);
			return this.RemoveBagItemByItem(bagItem, consumeNums, caseId, location);
		}

		// Token: 0x06003E22 RID: 15906 RVA: 0x0011AD54 File Offset: 0x00118F54
		private int RemoveBagItemByItem(BagItemBase bagItem, int consumeNums, GameFunctionType caseId = GameFunctionType.GameFunctionType_None, string location = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RemoveBagItemByItemBagItemBaseInt32GameFunctionTypeString_hotfix != null)
			{
				return Convert.ToInt32(this.m_RemoveBagItemByItemBagItemBaseInt32GameFunctionTypeString_hotfix.call(new object[]
				{
					this,
					bagItem,
					consumeNums,
					caseId,
					location
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (bagItem == null)
			{
				return -502;
			}
			int num = this.HasEnoughBagItem(bagItem, consumeNums);
			if (num != 0)
			{
				return num;
			}
			this.RemoveBagItemDirectly(bagItem, consumeNums, caseId, location);
			return 0;
		}

		// Token: 0x06003E23 RID: 15907 RVA: 0x0011AE2C File Offset: 0x0011902C
		public int RemoveBagItemByType(GoodsType goodsTypeId, int contentId, int consumeNums, GameFunctionType caseId = GameFunctionType.GameFunctionType_None, string location = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RemoveBagItemByTypeGoodsTypeInt32Int32GameFunctionTypeString_hotfix != null)
			{
				return Convert.ToInt32(this.m_RemoveBagItemByTypeGoodsTypeInt32Int32GameFunctionTypeString_hotfix.call(new object[]
				{
					this,
					goodsTypeId,
					contentId,
					consumeNums,
					caseId,
					location
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BagItemBase bagItem = this.FindBagItemByType(goodsTypeId, contentId);
			return this.RemoveBagItemByItem(bagItem, consumeNums, caseId, location);
		}

		// Token: 0x06003E24 RID: 15908 RVA: 0x0011AF00 File Offset: 0x00119100
		public int RemoveBagItemByInstanceId(ulong instanceId, GameFunctionType caseId = GameFunctionType.GameFunctionType_None, string location = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RemoveBagItemByInstanceIdUInt64GameFunctionTypeString_hotfix != null)
			{
				return Convert.ToInt32(this.m_RemoveBagItemByInstanceIdUInt64GameFunctionTypeString_hotfix.call(new object[]
				{
					this,
					instanceId,
					caseId,
					location
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BagItemBase bagItem = this.FindBagItemByInstanceId(instanceId);
			return this.RemoveBagItemByItem(bagItem, 1, caseId, location);
		}

		// Token: 0x06003E25 RID: 15909 RVA: 0x0011AFB0 File Offset: 0x001191B0
		public BagItemBase RemoveBagItemDirectly(BagItemBase bagItem, int consumeNums, GameFunctionType caseId = GameFunctionType.GameFunctionType_None, string location = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RemoveBagItemDirectlyBagItemBaseInt32GameFunctionTypeString_hotfix != null)
			{
				return (BagItemBase)this.m_RemoveBagItemDirectlyBagItemBaseInt32GameFunctionTypeString_hotfix.call(new object[]
				{
					this,
					bagItem,
					consumeNums,
					caseId,
					location
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.OutPutItemOperationLog(bagItem.GoodsTypeId, bagItem.ContentId, -consumeNums, caseId, location);
			return this.m_bagDS.RemoveBagItem(bagItem, consumeNums);
		}

		// Token: 0x06003E26 RID: 15910 RVA: 0x0011B080 File Offset: 0x00119280
		public BagItemBase FindBagItem(GoodsType goodsTypeId, int contentId, ulong instanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindBagItemGoodsTypeInt32UInt64_hotfix != null)
			{
				return (BagItemBase)this.m_FindBagItemGoodsTypeInt32UInt64_hotfix.call(new object[]
				{
					this,
					goodsTypeId,
					contentId,
					instanceId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BagItemBase result;
			if (BagItemBase.IsInstanceBagItem(goodsTypeId))
			{
				result = this.FindBagItemByInstanceId(instanceId);
			}
			else
			{
				result = this.FindBagItemByType(goodsTypeId, contentId);
			}
			return result;
		}

		// Token: 0x06003E27 RID: 15911 RVA: 0x0011B140 File Offset: 0x00119340
		public BagItemBase FindBagItemByInstanceId(ulong instanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindBagItemByInstanceIdUInt64_hotfix != null)
			{
				return (BagItemBase)this.m_FindBagItemByInstanceIdUInt64_hotfix.call(new object[]
				{
					this,
					instanceId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (instanceId == 0UL)
			{
				return null;
			}
			return this.m_bagDS.FindBagItem(instanceId);
		}

		// Token: 0x06003E28 RID: 15912 RVA: 0x0011B1D4 File Offset: 0x001193D4
		public BagItemBase FindBagItemByType(GoodsType goodsTypeId, int contentId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindBagItemByTypeGoodsTypeInt32_hotfix != null)
			{
				return (BagItemBase)this.m_FindBagItemByTypeGoodsTypeInt32_hotfix.call(new object[]
				{
					this,
					goodsTypeId,
					contentId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_bagDS.FindBagItem(goodsTypeId, contentId);
		}

		// Token: 0x06003E29 RID: 15913 RVA: 0x0011B270 File Offset: 0x00119470
		public UseableBagItem FindUseableBagItem(GoodsType goodsTypeId, int contentId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindUseableBagItemGoodsTypeInt32_hotfix != null)
			{
				return (UseableBagItem)this.m_FindUseableBagItemGoodsTypeInt32_hotfix.call(new object[]
				{
					this,
					goodsTypeId,
					contentId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BagItemBase bagItemBase = this.FindBagItemByType(goodsTypeId, contentId);
			if (bagItemBase == null)
			{
				return null;
			}
			return bagItemBase as UseableBagItem;
		}

		// Token: 0x06003E2A RID: 15914 RVA: 0x0011B314 File Offset: 0x00119514
		public List<BagItemBase> GetAllBagItems()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllBagItems_hotfix != null)
			{
				return (List<BagItemBase>)this.m_GetAllBagItems_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_bagDS.GetAllBagItems();
		}

		// Token: 0x06003E2B RID: 15915 RVA: 0x0011B38C File Offset: 0x0011958C
		public IEnumerable<BagItemBase> IterateAllBagItems()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IterateAllBagItems_hotfix != null)
			{
				return (IEnumerable<BagItemBase>)this.m_IterateAllBagItems_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_bagDS.IterateAllBagItems();
		}

		// Token: 0x06003E2C RID: 15916 RVA: 0x0011B404 File Offset: 0x00119604
		public List<BagItemBase> FindEnoughBagItems(List<Goods> conditions)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindEnoughBagItemsList`1_hotfix != null)
			{
				return (List<BagItemBase>)this.m_FindEnoughBagItemsList`1_hotfix.call(new object[]
				{
					this,
					conditions
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<BagItemBase> list = new List<BagItemBase>();
			foreach (Goods goods in conditions)
			{
				if (!BagItemBase.IsInstanceBagItem(goods.GoodsType))
				{
					BagItemBase bagItemBase = this.FindBagItemByType(goods.GoodsType, goods.Id);
					if (bagItemBase != null)
					{
						if (this.HasEnoughBagItem(bagItemBase, goods.Count) == 0)
						{
							list.Add(bagItemBase);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06003E2D RID: 15917 RVA: 0x0011B518 File Offset: 0x00119718
		public int UseBagItem(GoodsType goodsTypeId, int contentId, int consumeNums, params object[] param)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UseBagItemGoodsTypeInt32Int32Objectbe_hotfix != null)
			{
				return Convert.ToInt32(this.m_UseBagItemGoodsTypeInt32Int32Objectbe_hotfix.call(new object[]
				{
					this,
					goodsTypeId,
					contentId,
					consumeNums,
					param
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BagItemBase bagItemBase = this.FindBagItemByType(goodsTypeId, contentId);
			if (bagItemBase == null)
			{
				return -502;
			}
			UseableBagItem useableBagItem = bagItemBase as UseableBagItem;
			if (useableBagItem == null)
			{
				return -506;
			}
			ConfigDataItemInfo configDataItemInfo = this.m_configDataLoader.GetConfigDataItemInfo(contentId);
			if ((configDataItemInfo.FuncType == ItemFuncType.ItemFuncType_StaticBox || configDataItemInfo.FuncType == ItemFuncType.ItemFuncType_RandomBox) && consumeNums > this.m_configDataLoader.ConfigableConstId_UseBoxItemMaxCount)
			{
				return -533;
			}
			return this.UseBagItem(useableBagItem, consumeNums, param);
		}

		// Token: 0x06003E2E RID: 15918 RVA: 0x0011B634 File Offset: 0x00119834
		public int UseBagItem(UseableBagItem useableBagItem, int consumeNums, params object[] param)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UseBagItemUseableBagItemInt32Objectbe_hotfix != null)
			{
				return Convert.ToInt32(this.m_UseBagItemUseableBagItemInt32Objectbe_hotfix.call(new object[]
				{
					this,
					useableBagItem,
					consumeNums,
					param
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.HasEnoughBagItem(useableBagItem, consumeNums);
			if (num != 0)
			{
				return num;
			}
			return this.UseBagItemDirectly(useableBagItem, consumeNums, param);
		}

		// Token: 0x06003E2F RID: 15919 RVA: 0x0011B6EC File Offset: 0x001198EC
		public virtual int UseBagItemDirectly(UseableBagItem useableBagItem, int consumeNums, params object[] param)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UseBagItemDirectlyUseableBagItemInt32Objectbe_hotfix != null)
			{
				return Convert.ToInt32(this.m_UseBagItemDirectlyUseableBagItemInt32Objectbe_hotfix.call(new object[]
				{
					this,
					useableBagItem,
					consumeNums,
					param
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int i = 0;
			int num = 0;
			while (i < consumeNums)
			{
				num = useableBagItem.HaveEffect(this.Owner, param);
				if (num < 0)
				{
					break;
				}
				i++;
			}
			if (i == 0)
			{
				return num;
			}
			this.RemoveBagItemDirectly(useableBagItem, i, GameFunctionType.GameFunctionType_Item, useableBagItem.ContentId.ToString());
			ConfigDataItemInfo configDataItemInfo = this.m_configDataLoader.GetConfigDataItemInfo(useableBagItem.ContentId);
			if (configDataItemInfo != null && configDataItemInfo.FuncType == ItemFuncType.ItemFuncType_HeroEXP && this.UseHeroExpItemMissionEvent != null)
			{
				this.UseHeroExpItemMissionEvent(i);
			}
			return useableBagItem.Nums;
		}

		// Token: 0x06003E30 RID: 15920 RVA: 0x0011B820 File Offset: 0x00119A20
		public int HasEnoughBagItem(BagItemBase bagItem, int consumeNums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasEnoughBagItemBagItemBaseInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_HasEnoughBagItemBagItemBaseInt32_hotfix.call(new object[]
				{
					this,
					bagItem,
					consumeNums
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (consumeNums <= 0)
			{
				return -521;
			}
			return (!this.IsBagItemEnough(bagItem, consumeNums)) ? -503 : 0;
		}

		// Token: 0x06003E31 RID: 15921 RVA: 0x0011B8D4 File Offset: 0x00119AD4
		protected bool IsBagItemEnough(BagItemBase bagItem, int consumeNums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsBagItemEnoughBagItemBaseInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsBagItemEnoughBagItemBaseInt32_hotfix.call(new object[]
				{
					this,
					bagItem,
					consumeNums
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return bagItem.IsEnough(consumeNums);
		}

		// Token: 0x06003E32 RID: 15922 RVA: 0x0011B968 File Offset: 0x00119B68
		public bool IsBagItemEnough(GoodsType bagItemType, int bagItemId, int nums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsBagItemEnoughGoodsTypeInt32Int32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsBagItemEnoughGoodsTypeInt32Int32_hotfix.call(new object[]
				{
					this,
					bagItemType,
					bagItemId,
					nums
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (nums == 0)
			{
				return true;
			}
			BagItemBase bagItemBase = this.FindBagItemByType(bagItemType, bagItemId);
			return bagItemBase != null && bagItemBase.IsEnough(nums);
		}

		// Token: 0x06003E33 RID: 15923 RVA: 0x0011BA28 File Offset: 0x00119C28
		public int GetTicketId(GameFunctionType causeId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTicketIdGameFunctionType_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetTicketIdGameFunctionType_hotfix.call(new object[]
				{
					this,
					causeId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataTicketLimitInfo configDataTicketLimitInfo = this.m_configDataLoader.GetConfigDataTicketLimitInfo((int)causeId);
			return configDataTicketLimitInfo.TicketId;
		}

		// Token: 0x06003E34 RID: 15924 RVA: 0x0011BAB8 File Offset: 0x00119CB8
		public bool IsLevelTicketsMaxByUI(GameFunctionType causeId, GoodsType goodTypeId, int contentId, int nums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsLevelTicketsMaxByUIGameFunctionTypeGoodsTypeInt32Int32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsLevelTicketsMaxByUIGameFunctionTypeGoodsTypeInt32Int32_hotfix.call(new object[]
				{
					this,
					causeId,
					goodTypeId,
					contentId,
					nums
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (causeId != GameFunctionType.GameFunctionType_Mission)
			{
				return false;
			}
			if (goodTypeId != GoodsType.GoodsType_Item)
			{
				return false;
			}
			ConfigDataTicketLimitInfo configDataTicketLimitInfo;
			this.m_configDataLoader.TicketId2TicketLimitInfo.TryGetValue(contentId, out configDataTicketLimitInfo);
			return configDataTicketLimitInfo != null && this.IsLevelTicketsMax(configDataTicketLimitInfo, contentId, nums);
		}

		// Token: 0x06003E35 RID: 15925 RVA: 0x0011BB9C File Offset: 0x00119D9C
		private bool IsLevelTicketsMax(ConfigDataTicketLimitInfo ticketLimitInfo, int contentId, int nums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsLevelTicketsMaxConfigDataTicketLimitInfoInt32Int32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsLevelTicketsMaxConfigDataTicketLimitInfoInt32Int32_hotfix.call(new object[]
				{
					this,
					ticketLimitInfo,
					contentId,
					nums
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (ticketLimitInfo == null || ticketLimitInfo.MaxNums == 0)
			{
				return false;
			}
			BagItemBase bagItemBase = this.FindBagItemByType(GoodsType.GoodsType_Item, contentId);
			if (bagItemBase == null)
			{
				return nums > ticketLimitInfo.MaxNums;
			}
			return bagItemBase.Nums + nums > ticketLimitInfo.MaxNums;
		}

		// Token: 0x06003E36 RID: 15926 RVA: 0x0011BC74 File Offset: 0x00119E74
		public int SellBagItem(ulong instanceId, int nums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SellBagItemUInt64Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_SellBagItemUInt64Int32_hotfix.call(new object[]
				{
					this,
					instanceId,
					nums
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BagItemBase bagItemBase = this.FindBagItemByInstanceId(instanceId);
			if (bagItemBase == null)
			{
				return -502;
			}
			int num = this.HasEnoughBagItem(bagItemBase, nums);
			if (num != 0)
			{
				return num;
			}
			GoodsType goodsTypeId = bagItemBase.GoodsTypeId;
			int sellGold;
			if (goodsTypeId != GoodsType.GoodsType_JobMaterial)
			{
				if (goodsTypeId != GoodsType.GoodsType_Item)
				{
					if (goodsTypeId != GoodsType.GoodsType_EnchantStone)
					{
						return -507;
					}
					ConfigDataEnchantStoneInfo configDataEnchantStoneInfo = this.m_configDataLoader.GetConfigDataEnchantStoneInfo(bagItemBase.ContentId);
					if (configDataEnchantStoneInfo == null)
					{
						return -505;
					}
					sellGold = configDataEnchantStoneInfo.SellGold;
				}
				else
				{
					ConfigDataItemInfo configDataItemInfo = this.m_configDataLoader.GetConfigDataItemInfo(bagItemBase.ContentId);
					if (configDataItemInfo == null)
					{
						return -505;
					}
					sellGold = configDataItemInfo.SellGold;
				}
			}
			else
			{
				ConfigDataJobMaterialInfo configDataJobMaterialInfo = this.m_configDataLoader.GetConfigDataJobMaterialInfo(bagItemBase.ContentId);
				if (configDataJobMaterialInfo == null)
				{
					return -504;
				}
				sellGold = configDataJobMaterialInfo.SellGold;
			}
			BagItemBase bagItemBase2 = this.RemoveBagItemDirectly(bagItemBase, nums, GameFunctionType.GameFunctionType_None, null);
			this.m_basicInfo.AddGold(sellGold * nums, GameFunctionType.GameFunctionType_None, null);
			return bagItemBase2.Nums;
		}

		// Token: 0x06003E37 RID: 15927 RVA: 0x0011BDFC File Offset: 0x00119FFC
		public void CombineSameGoodsAndReplaceExistHeroToFragment(List<Goods> goodsList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CombineSameGoodsAndReplaceExistHeroToFragmentList`1_hotfix != null)
			{
				this.m_CombineSameGoodsAndReplaceExistHeroToFragmentList`1_hotfix.call(new object[]
				{
					this,
					goodsList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (goodsList == null || goodsList.Count == 0)
			{
				return;
			}
			List<Goods> list = new List<Goods>();
			using (List<Goods>.Enumerator enumerator = goodsList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Goods goods = enumerator.Current;
					if (goods.GoodsType != GoodsType.GoodsType_None && goods.Count > 0)
					{
						Goods goods4 = list.Find((Goods t) => t.Id == goods.Id && t.GoodsType == goods.GoodsType);
						if (goods4 != null)
						{
							goods4.Count += goods.Count;
						}
						else
						{
							list.Add(new Goods
							{
								GoodsType = goods.GoodsType,
								Id = goods.Id,
								Count = goods.Count
							});
						}
					}
				}
			}
			List<Goods> list2 = list.FindAll((Goods t) => t.GoodsType == GoodsType.GoodsType_Hero);
			if (list2.Count == 0)
			{
				goodsList.Clear();
				goodsList.AddRange(list);
				return;
			}
			ConfigDataHeroInfo heroConfig = null;
			foreach (Goods goods2 in list2)
			{
				heroConfig = this.m_configDataLoader.GetConfigDataHeroInfo(goods2.Id);
				if (heroConfig == null)
				{
					list.Remove(goods2);
				}
				else
				{
					int num;
					if (this.m_hero.FindHero(goods2.Id) == null)
					{
						num = goods2.Count - 1;
						goods2.Count = 1;
					}
					else
					{
						num = goods2.Count;
						list.Remove(goods2);
					}
					if (num != 0)
					{
						int num2 = heroConfig.ExchangedFragmentCount * num;
						Goods goods3 = list.Find((Goods t) => t.GoodsType == GoodsType.GoodsType_Item && t.Id == heroConfig.FragmentItem_ID);
						if (goods3 == null)
						{
							list.Add(new Goods
							{
								GoodsType = GoodsType.GoodsType_Item,
								Id = heroConfig.FragmentItem_ID,
								Count = num2
							});
						}
						else
						{
							goods3.Count += num2;
						}
					}
				}
			}
			goodsList.Clear();
			goodsList.AddRange(list);
		}

		// Token: 0x06003E38 RID: 15928 RVA: 0x0011C12C File Offset: 0x0011A32C
		public int CanDecomposeBagItems(List<ProGoods> goods)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanDecomposeBagItemsList`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanDecomposeBagItemsList`1_hotfix.call(new object[]
				{
					this,
					goods
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HashSet<string> hashSet = new HashSet<string>();
			int num = 0;
			foreach (ProGoods proGoods in goods)
			{
				GoodsType goodsType = (GoodsType)proGoods.GoodsType;
				string item;
				if (BagItemBase.IsInstanceBagItem(goodsType))
				{
					item = proGoods.InstanceId.ToString();
					num++;
				}
				else
				{
					item = CombineStringTools.BuildParam(new object[]
					{
						proGoods.GoodsType,
						proGoods.Id
					});
					num += proGoods.Nums;
				}
				if (hashSet.Contains(item))
				{
					return -528;
				}
				hashSet.Add(item);
				int num2 = this.CanDecomposeABagItem(goodsType, proGoods.Id, proGoods.Nums, proGoods.InstanceId);
				if (num2 != 0)
				{
					return num2;
				}
			}
			if (num > this.m_configDataLoader.ConfigableConstId_AlchemyMaxNum)
			{
				return -535;
			}
			return 0;
		}

		// Token: 0x06003E39 RID: 15929 RVA: 0x0011C2C8 File Offset: 0x0011A4C8
		public int CanDecomposeABagItem(GoodsType goodsTypeId, int contentId, int nums, ulong instanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanDecomposeABagItemGoodsTypeInt32Int32UInt64_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanDecomposeABagItemGoodsTypeInt32Int32UInt64_hotfix.call(new object[]
				{
					this,
					goodsTypeId,
					contentId,
					nums,
					instanceId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BagItemBase bagItemBase = this.FindBagItem(goodsTypeId, contentId, instanceId);
			if (bagItemBase == null)
			{
				return -502;
			}
			int num = this.HasEnoughBagItem(bagItemBase, nums);
			if (num != 0)
			{
				return num;
			}
			switch (goodsTypeId)
			{
			case GoodsType.GoodsType_JobMaterial:
			{
				ConfigDataJobMaterialInfo configDataJobMaterialInfo = this.m_configDataLoader.GetConfigDataJobMaterialInfo(contentId);
				if (configDataJobMaterialInfo.AlchemyGold == 0)
				{
					return -527;
				}
				break;
			}
			case GoodsType.GoodsType_Item:
			{
				ConfigDataItemInfo configDataItemInfo = this.m_configDataLoader.GetConfigDataItemInfo(contentId);
				if (configDataItemInfo.AlchemyGold == 0)
				{
					return -527;
				}
				break;
			}
			case GoodsType.GoodsType_Equipment:
			{
				EquipmentBagItem equipmentBagItem = bagItemBase as EquipmentBagItem;
				if (equipmentBagItem.Locked)
				{
					return -511;
				}
				if (this.m_hero.IsEquipmentWeared(equipmentBagItem.InstanceId))
				{
					return -646;
				}
				ConfigDataEquipmentInfo configDataEquipmentInfo = this.m_configDataLoader.GetConfigDataEquipmentInfo(contentId);
				if (configDataEquipmentInfo.AlchemyGold == 0)
				{
					return -527;
				}
				break;
			}
			default:
			{
				if (goodsTypeId != GoodsType.GoodsType_EnchantStone)
				{
					return -527;
				}
				ConfigDataEnchantStoneInfo configDataEnchantStoneInfo = this.m_configDataLoader.GetConfigDataEnchantStoneInfo(contentId);
				if (configDataEnchantStoneInfo.AlchemyGold == 0)
				{
					return -527;
				}
				break;
			}
			}
			return 0;
		}

		// Token: 0x06003E3A RID: 15930 RVA: 0x0011C48C File Offset: 0x0011A68C
		public void SetBagItemDirty(BagItemBase bagItem)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBagItemDirtyBagItemBase_hotfix != null)
			{
				this.m_SetBagItemDirtyBagItemBase_hotfix.call(new object[]
				{
					this,
					bagItem
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_bagDS.SetBagItemDirty(bagItem);
		}

		// Token: 0x06003E3B RID: 15931 RVA: 0x0011C508 File Offset: 0x0011A708
		public bool IsPercentBaseBattleProperty(PropertyModifyType id)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsPercentBaseBattlePropertyPropertyModifyType_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsPercentBaseBattlePropertyPropertyModifyType_hotfix.call(new object[]
				{
					this,
					id
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (id)
			{
			case PropertyModifyType.PropertyModifyType_Hero1_HPCmdAdd:
			case PropertyModifyType.PropertyModifyType_Hero1_ATCmdAdd:
			case PropertyModifyType.PropertyModifyType_Hero1_DFCmdAdd:
			case PropertyModifyType.PropertyModifyType_Hero1_MagicDFCmdAdd:
			case PropertyModifyType.PropertyModifyType_Hero1_CriticalDamageAdd:
			case PropertyModifyType.PropertyModifyType_Hero1_CriticalRateAdd:
			case PropertyModifyType.PropertyModifyType_Hero1_HPMul:
			case PropertyModifyType.PropertyModifyType_Hero1_ATMul:
			case PropertyModifyType.PropertyModifyType_Hero1_DFMul:
			case PropertyModifyType.PropertyModifyType_Hero1_MagicMul:
			case PropertyModifyType.PropertyModifyType_Hero1_MagicDFMul:
			case PropertyModifyType.PropertyModifyType_Hero1_DEXMul:
				return true;
			}
			return false;
		}

		// Token: 0x06003E3C RID: 15932 RVA: 0x0011C5CC File Offset: 0x0011A7CC
		public int CanLockAndUnLockEquipment(ulong instanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanLockAndUnLockEquipmentUInt64_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanLockAndUnLockEquipmentUInt64_hotfix.call(new object[]
				{
					this,
					instanceId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BagItemBase bagItemBase = this.FindBagItemByInstanceId(instanceId);
			if (bagItemBase == null)
			{
				return -502;
			}
			if (!bagItemBase.IsThisGoodsType(GoodsType.GoodsType_Equipment))
			{
				return -509;
			}
			return 0;
		}

		// Token: 0x06003E3D RID: 15933 RVA: 0x0011C670 File Offset: 0x0011A870
		public int LockAndUnLockEquipment(ulong instanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LockAndUnLockEquipmentUInt64_hotfix != null)
			{
				return Convert.ToInt32(this.m_LockAndUnLockEquipmentUInt64_hotfix.call(new object[]
				{
					this,
					instanceId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanLockAndUnLockEquipment(instanceId);
			if (num != 0)
			{
				return num;
			}
			EquipmentBagItem equipmentBagItem = this.FindBagItemByInstanceId(instanceId) as EquipmentBagItem;
			equipmentBagItem.Locked = !equipmentBagItem.Locked;
			this.SetBagItemDirty(equipmentBagItem);
			return 0;
		}

		// Token: 0x06003E3E RID: 15934 RVA: 0x0011C720 File Offset: 0x0011A920
		public int CanEnhanceEquipment(ulong instanceId, List<ulong> materialIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanEnhanceEquipmentUInt64List`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanEnhanceEquipmentUInt64List`1_hotfix.call(new object[]
				{
					this,
					instanceId,
					materialIds
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (materialIds.Count <= 0 || materialIds.Count > 5)
			{
				return -510;
			}
			if (materialIds.Contains(instanceId))
			{
				return -520;
			}
			EquipmentBagItem equipmentBagItem = this.FindBagItemByInstanceId(instanceId) as EquipmentBagItem;
			if (equipmentBagItem == null)
			{
				return -502;
			}
			if (!this.CanWearEquipmentByEquipmentType(equipmentBagItem))
			{
				return -515;
			}
			if (this.IsEquipmentMaxExp(equipmentBagItem))
			{
				return -514;
			}
			List<BagItemBase> list = new List<BagItemBase>();
			foreach (ulong instanceId2 in materialIds)
			{
				EquipmentBagItem equipmentBagItem2 = this.FindBagItemByInstanceId(instanceId2) as EquipmentBagItem;
				if (equipmentBagItem2 == null)
				{
					return -502;
				}
				if (equipmentBagItem2.Locked)
				{
					return -511;
				}
				if (this.m_hero.IsEquipmentWeared(instanceId2))
				{
					return -646;
				}
				if (equipmentBagItem2.IsEquipmentEnhanced())
				{
					return -512;
				}
				if (this.IsLevelUpEquipmentStarLevel(equipmentBagItem2))
				{
					return -513;
				}
				if (this.IsThisEquipmentType(equipmentBagItem2, EquipmentType.EquipmentType_LevelUpStar))
				{
					return -524;
				}
				list.Add(equipmentBagItem2);
			}
			this.m_enhanceEquipmentMaterialExp = this.CalculateEnhanceEquipmentExp(list);
			int useGoldCount = this.CalculateEnhanceEquipmentGold(this.m_enhanceEquipmentMaterialExp);
			if (!this.m_basicInfo.IsGoldEnough(useGoldCount))
			{
				return -400;
			}
			return 0;
		}

		// Token: 0x06003E3F RID: 15935 RVA: 0x0011C93C File Offset: 0x0011AB3C
		public bool CanWearEquipmentByEquipmentType(BagItemBase equipment)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanWearEquipmentByEquipmentTypeBagItemBase_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CanWearEquipmentByEquipmentTypeBagItemBase_hotfix.call(new object[]
				{
					this,
					equipment
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return !this.IsThisEquipmentType(equipment, EquipmentType.EquipmentType_Enhancement) && !this.IsThisEquipmentType(equipment, EquipmentType.EquipmentType_LevelUpStar);
		}

		// Token: 0x06003E40 RID: 15936 RVA: 0x0011C9D4 File Offset: 0x0011ABD4
		private bool IsThisEquipmentType(BagItemBase equipment, EquipmentType type)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsThisEquipmentTypeBagItemBaseEquipmentType_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsThisEquipmentTypeBagItemBaseEquipmentType_hotfix.call(new object[]
				{
					this,
					equipment,
					type
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataEquipmentInfo configDataEquipmentInfo = this.m_configDataLoader.GetConfigDataEquipmentInfo(equipment.ContentId);
			return configDataEquipmentInfo.EquipmentType == type;
		}

		// Token: 0x06003E41 RID: 15937 RVA: 0x0011CA7C File Offset: 0x0011AC7C
		private bool IsLevelUpEquipmentStarLevel(EquipmentBagItem equipment)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsLevelUpEquipmentStarLevelEquipmentBagItem_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsLevelUpEquipmentStarLevelEquipmentBagItem_hotfix.call(new object[]
				{
					this,
					equipment
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataEquipmentInfo configDataEquipmentInfo = this.m_configDataLoader.GetConfigDataEquipmentInfo(equipment.ContentId);
			return equipment.StarLevel > configDataEquipmentInfo.BornStarLevel;
		}

		// Token: 0x06003E42 RID: 15938 RVA: 0x0011CB18 File Offset: 0x0011AD18
		public int CalculateEnhanceEquipmentExp(List<BagItemBase> materials)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CalculateEnhanceEquipmentExpList`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_CalculateEnhanceEquipmentExpList`1_hotfix.call(new object[]
				{
					this,
					materials
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			foreach (BagItemBase bagItemBase in materials)
			{
				num += this.m_configDataLoader.GetConfigDataEquipmentInfo(bagItemBase.ContentId).Exp;
			}
			return num;
		}

		// Token: 0x06003E43 RID: 15939 RVA: 0x0011CBF4 File Offset: 0x0011ADF4
		public int CalculateEnhanceEquipmentGold(int exp)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CalculateEnhanceEquipmentGoldInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CalculateEnhanceEquipmentGoldInt32_hotfix.call(new object[]
				{
					this,
					exp
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return exp * this.m_configDataLoader.ConfigableConstId_EnhanceEquipmentConsumeGoldPerExp;
		}

		// Token: 0x06003E44 RID: 15940 RVA: 0x0011CC80 File Offset: 0x0011AE80
		public int EnhanceEquipment(ulong instanceId, List<ulong> materialIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EnhanceEquipmentUInt64List`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_EnhanceEquipmentUInt64List`1_hotfix.call(new object[]
				{
					this,
					instanceId,
					materialIds
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanEnhanceEquipment(instanceId, materialIds);
			if (num != 0)
			{
				return num;
			}
			EquipmentBagItem equipmentBagItem = this.FindBagItemByInstanceId(instanceId) as EquipmentBagItem;
			int exp = equipmentBagItem.Exp;
			int level = equipmentBagItem.Level;
			List<Goods> list = new List<Goods>();
			foreach (ulong instanceId2 in materialIds)
			{
				BagItemBase bagItemBase = this.FindBagItemByInstanceId(instanceId2);
				list.Add(bagItemBase.ToGoods());
				this.RemoveBagItemDirectly(bagItemBase, bagItemBase.Nums, GameFunctionType.GameFunctionType_EquipmentEnhance, equipmentBagItem.ContentId.ToString());
			}
			this.AddEquipmentExp(equipmentBagItem, this.m_enhanceEquipmentMaterialExp);
			int num2 = this.CalculateEnhanceEquipmentGold(this.m_enhanceEquipmentMaterialExp);
			this.m_basicInfo.AddGold(-num2, GameFunctionType.GameFunctionType_EquipmentEnhance, equipmentBagItem.ContentId.ToString());
			this.SetBagItemDirty(equipmentBagItem);
			list.Add(new Goods
			{
				GoodsType = GoodsType.GoodsType_Gold,
				Count = num2
			});
			Hero wearedEquipmentHero = this.m_hero.GetWearedEquipmentHero(instanceId);
			if (wearedEquipmentHero != null && equipmentBagItem.Level != level)
			{
				this.m_hero.OnHeroBattlePowerChange(wearedEquipmentHero);
			}
			this.OutPutEqipmentEnhanceOperateLog(equipmentBagItem, level, exp, list);
			return 0;
		}

		// Token: 0x06003E45 RID: 15941 RVA: 0x0011CE6C File Offset: 0x0011B06C
		public int CanEnchantEquipment(ulong equipmentInstanceId, ulong enchantStoneInstanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanEnchantEquipmentUInt64UInt64_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanEnchantEquipmentUInt64UInt64_hotfix.call(new object[]
				{
					this,
					equipmentInstanceId,
					enchantStoneInstanceId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!(this.FindBagItemByInstanceId(equipmentInstanceId) is EquipmentBagItem))
			{
				return -502;
			}
			EnchantStoneBagItem enchantStoneBagItem = this.FindBagItemByInstanceId(enchantStoneInstanceId) as EnchantStoneBagItem;
			if (enchantStoneBagItem == null)
			{
				return -502;
			}
			ConfigDataEnchantStoneInfo configDataEnchantStoneInfo = this.m_configDataLoader.GetConfigDataEnchantStoneInfo(enchantStoneBagItem.ContentId);
			if (!this.m_basicInfo.IsGoldEnough(configDataEnchantStoneInfo.CostGold))
			{
				return -400;
			}
			return 0;
		}

		// Token: 0x06003E46 RID: 15942 RVA: 0x0011CF5C File Offset: 0x0011B15C
		protected virtual void OutPutEqipmentEnhanceOperateLog(EquipmentBagItem equipment, int preLevel, int preExp, List<Goods> costItems)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OutPutEqipmentEnhanceOperateLogEquipmentBagItemInt32Int32List`1_hotfix != null)
			{
				this.m_OutPutEqipmentEnhanceOperateLogEquipmentBagItemInt32Int32List`1_hotfix.call(new object[]
				{
					this,
					equipment,
					preLevel,
					preExp,
					costItems
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06003E47 RID: 15943 RVA: 0x0011CFFC File Offset: 0x0011B1FC
		protected virtual void OutPutEquipmentUpgrageOperateLog(EquipmentBagItem equipment, EquipmentBagItem material, int preLvlLimit, int postLvlLimit, List<Goods> costItems)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OutPutEquipmentUpgrageOperateLogEquipmentBagItemEquipmentBagItemInt32Int32List`1_hotfix != null)
			{
				this.m_OutPutEquipmentUpgrageOperateLogEquipmentBagItemEquipmentBagItemInt32Int32List`1_hotfix.call(new object[]
				{
					this,
					equipment,
					material,
					preLvlLimit,
					postLvlLimit,
					costItems
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06003E48 RID: 15944 RVA: 0x0011D0AC File Offset: 0x0011B2AC
		private void AddEquipmentExp(EquipmentBagItem equipment, int exp)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddEquipmentExpEquipmentBagItemInt32_hotfix != null)
			{
				this.m_AddEquipmentExpEquipmentBagItemInt32_hotfix.call(new object[]
				{
					this,
					equipment,
					exp
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = equipment.Exp + exp;
			int num2;
			for (;;)
			{
				num2 = this.CaculateEquipmentNextLevelExp(equipment.ContentId, equipment.Level);
				if (num < num2)
				{
					break;
				}
				if (this.IsEquipmentMaxLevel(equipment))
				{
					goto Block_5;
				}
				this.LevelUpEquipment(equipment);
				num -= num2;
				if (num <= 0)
				{
					return;
				}
			}
			equipment.Exp = num;
			return;
			Block_5:
			equipment.Exp = num2;
		}

		// Token: 0x06003E49 RID: 15945 RVA: 0x0011D180 File Offset: 0x0011B380
		protected virtual void LevelUpEquipment(EquipmentBagItem equipment)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LevelUpEquipmentEquipmentBagItem_hotfix != null)
			{
				this.m_LevelUpEquipmentEquipmentBagItem_hotfix.call(new object[]
				{
					this,
					equipment
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			equipment.Level++;
			equipment.Exp = 0;
			if (this.EquipmentLevelupMissionEvent != null)
			{
				this.EquipmentLevelupMissionEvent(equipment);
			}
		}

		// Token: 0x06003E4A RID: 15946 RVA: 0x0011D21C File Offset: 0x0011B41C
		private bool IsEquipmentMaxExp(EquipmentBagItem equipment)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsEquipmentMaxExpEquipmentBagItem_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsEquipmentMaxExpEquipmentBagItem_hotfix.call(new object[]
				{
					this,
					equipment
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.IsEquipmentMaxLevel(equipment) && this.CaculateEquipmentNextLevelExp(equipment.ContentId, equipment.Level) == equipment.Exp;
		}

		// Token: 0x06003E4B RID: 15947 RVA: 0x0011D2C0 File Offset: 0x0011B4C0
		public int CaculateEquipmentNextLevelExp(int equipmentContentId, int equipmentLevel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CaculateEquipmentNextLevelExpInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CaculateEquipmentNextLevelExpInt32Int32_hotfix.call(new object[]
				{
					this,
					equipmentContentId,
					equipmentLevel
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataEquipmentInfo configDataEquipmentInfo = this.m_configDataLoader.GetConfigDataEquipmentInfo(equipmentContentId);
			return this.m_configDataLoader.GetConfigDataEquipmentLevelInfo(equipmentLevel).RankEquipmentNextExps[configDataEquipmentInfo.Rank - 1];
		}

		// Token: 0x06003E4C RID: 15948 RVA: 0x0011D378 File Offset: 0x0011B578
		private bool IsEquipmentMaxLevel(EquipmentBagItem equipment)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsEquipmentMaxLevelEquipmentBagItem_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsEquipmentMaxLevelEquipmentBagItem_hotfix.call(new object[]
				{
					this,
					equipment
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return equipment.Level == this.GetEquipmentLevelLimit(equipment.StarLevel);
		}

		// Token: 0x06003E4D RID: 15949 RVA: 0x0011D408 File Offset: 0x0011B608
		private int GetEquipmentLevelLimit(int equipmentStarLevel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetEquipmentLevelLimitInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetEquipmentLevelLimitInt32_hotfix.call(new object[]
				{
					this,
					equipmentStarLevel
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataEquipmentLevelLimitInfo configDataEquipmentLevelLimitInfo = this.m_configDataLoader.GetConfigDataEquipmentLevelLimitInfo(equipmentStarLevel);
			if (configDataEquipmentLevelLimitInfo == null)
			{
				return int.MaxValue;
			}
			return configDataEquipmentLevelLimitInfo.LevelLimit;
		}

		// Token: 0x06003E4E RID: 15950 RVA: 0x0011D4A4 File Offset: 0x0011B6A4
		public int CanLevelUpEquipmentStar(ulong instanceId, ulong materialId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanLevelUpEquipmentStarUInt64UInt64_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanLevelUpEquipmentStarUInt64UInt64_hotfix.call(new object[]
				{
					this,
					instanceId,
					materialId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (instanceId == materialId)
			{
				return -520;
			}
			EquipmentBagItem equipmentBagItem = this.FindBagItemByInstanceId(instanceId) as EquipmentBagItem;
			if (equipmentBagItem == null)
			{
				return -502;
			}
			if (!this.CanWearEquipmentByEquipmentType(equipmentBagItem))
			{
				return -525;
			}
			EquipmentBagItem equipmentBagItem2 = this.FindBagItemByInstanceId(materialId) as EquipmentBagItem;
			if (equipmentBagItem2 == null)
			{
				return -502;
			}
			if (equipmentBagItem.StarLevel + 1 > this.m_configDataLoader.ConfigableConstId_HeroStarLevelMax)
			{
				return -518;
			}
			int equipmentLevelLimit = this.GetEquipmentLevelLimit(equipmentBagItem.StarLevel);
			if (equipmentBagItem.Level != equipmentLevelLimit)
			{
				return -519;
			}
			ConfigDataEquipmentInfo configDataEquipmentInfo = this.m_configDataLoader.GetConfigDataEquipmentInfo(equipmentBagItem.ContentId);
			if (equipmentBagItem2.ContentId == equipmentBagItem.ContentId)
			{
				if (equipmentBagItem2.Locked)
				{
					return -511;
				}
				if (this.m_hero.IsEquipmentWeared(materialId))
				{
					return -646;
				}
			}
			else
			{
				if (!this.IsThisEquipmentType(equipmentBagItem2, EquipmentType.EquipmentType_LevelUpStar))
				{
					return -516;
				}
				ConfigDataEquipmentInfo configDataEquipmentInfo2 = this.m_configDataLoader.GetConfigDataEquipmentInfo(equipmentBagItem2.ContentId);
				if (configDataEquipmentInfo.Rank != configDataEquipmentInfo2.Rank)
				{
					return -517;
				}
			}
			int useGoldCount = this.CalculateLevelUpEquipmentStarGold(equipmentBagItem);
			if (!this.m_basicInfo.IsGoldEnough(useGoldCount))
			{
				return -400;
			}
			List<Goods> levelUpEquipmentStarItems = this.GetLevelUpEquipmentStarItems(equipmentBagItem.StarLevel, configDataEquipmentInfo);
			List<BagItemBase> list;
			return this.IsGoodsEnough(levelUpEquipmentStarItems, out list);
		}

		// Token: 0x06003E4F RID: 15951 RVA: 0x0011D688 File Offset: 0x0011B888
		private List<Goods> GetLevelUpEquipmentStarItems(int star, ConfigDataEquipmentInfo equipmentInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetLevelUpEquipmentStarItemsInt32ConfigDataEquipmentInfo_hotfix != null)
			{
				return (List<Goods>)this.m_GetLevelUpEquipmentStarItemsInt32ConfigDataEquipmentInfo_hotfix.call(new object[]
				{
					this,
					star,
					equipmentInfo
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (star)
			{
			case 1:
				return equipmentInfo.LevelUpGoods1;
			case 2:
				return equipmentInfo.LevelUpGoods2;
			case 3:
				return equipmentInfo.LevelUpGoods3;
			case 4:
				return equipmentInfo.LevelUpGoods4;
			case 5:
				return equipmentInfo.LevelUpGoods5;
			default:
				return null;
			}
		}

		// Token: 0x06003E50 RID: 15952 RVA: 0x0011D75C File Offset: 0x0011B95C
		public int CalculateLevelUpEquipmentStarGold(EquipmentBagItem equipment)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CalculateLevelUpEquipmentStarGoldEquipmentBagItem_hotfix != null)
			{
				return Convert.ToInt32(this.m_CalculateLevelUpEquipmentStarGoldEquipmentBagItem_hotfix.call(new object[]
				{
					this,
					equipment
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return equipment.StarLevel * this.m_configDataLoader.ConfigableConstId_LevelUpEquipmentStarConsumeGoldPerStar;
		}

		// Token: 0x06003E51 RID: 15953 RVA: 0x0011D7EC File Offset: 0x0011B9EC
		public int LevelUpEquipmentStar(ulong instanceId, ulong materialId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LevelUpEquipmentStarUInt64UInt64_hotfix != null)
			{
				return Convert.ToInt32(this.m_LevelUpEquipmentStarUInt64UInt64_hotfix.call(new object[]
				{
					this,
					instanceId,
					materialId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanLevelUpEquipmentStar(instanceId, materialId);
			if (num != 0)
			{
				return num;
			}
			List<Goods> list = new List<Goods>();
			EquipmentBagItem equipmentBagItem = this.FindBagItemByInstanceId(instanceId) as EquipmentBagItem;
			int num2 = this.CalculateLevelUpEquipmentStarGold(equipmentBagItem);
			this.m_basicInfo.AddGold(-num2, GameFunctionType.GameFunctionType_EquipmentUpgrade, equipmentBagItem.ContentId.ToString());
			list.Add(new Goods
			{
				GoodsType = GoodsType.GoodsType_Gold,
				Count = num2
			});
			ConfigDataEquipmentInfo configDataEquipmentInfo = this.m_configDataLoader.GetConfigDataEquipmentInfo(equipmentBagItem.ContentId);
			List<Goods> levelUpEquipmentStarItems = this.GetLevelUpEquipmentStarItems(equipmentBagItem.StarLevel, configDataEquipmentInfo);
			this.ConsumeGoods(levelUpEquipmentStarItems, null, null, GameFunctionType.GameFunctionType_EquipmentUpgrade, equipmentBagItem.ContentId.ToString());
			this.LevelUpEquipmentStar(equipmentBagItem);
			list.AddRange(levelUpEquipmentStarItems);
			EquipmentBagItem equipmentBagItem2 = this.FindBagItemByInstanceId(materialId) as EquipmentBagItem;
			this.OutPutEquipmentUpgrageOperateLog(equipmentBagItem, equipmentBagItem2, this.GetEquipmentLevelLimit(equipmentBagItem.StarLevel - 1), this.GetEquipmentLevelLimit(equipmentBagItem.StarLevel), list);
			this.RemoveBagItemDirectly(equipmentBagItem2, equipmentBagItem2.Nums, GameFunctionType.GameFunctionType_EquipmentUpgrade, equipmentBagItem.ContentId.ToString());
			Hero wearedEquipmentHero = this.m_hero.GetWearedEquipmentHero(instanceId);
			if (wearedEquipmentHero != null)
			{
				this.m_hero.OnHeroBattlePowerChange(wearedEquipmentHero);
			}
			return 0;
		}

		// Token: 0x06003E52 RID: 15954 RVA: 0x0011D9B8 File Offset: 0x0011BBB8
		public int CalculateEquipmentTotalExp(EquipmentBagItem equipment)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CalculateEquipmentTotalExpEquipmentBagItem_hotfix != null)
			{
				return Convert.ToInt32(this.m_CalculateEquipmentTotalExpEquipmentBagItem_hotfix.call(new object[]
				{
					this,
					equipment
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataEquipmentInfo configDataEquipmentInfo = this.m_configDataLoader.GetConfigDataEquipmentInfo(equipment.ContentId);
			int num = 0;
			for (int i = 1; i < equipment.Level; i++)
			{
				num += this.m_configDataLoader.GetConfigDataEquipmentLevelInfo(i).RankEquipmentNextExps[configDataEquipmentInfo.Rank - 1];
			}
			return num + equipment.Exp;
		}

		// Token: 0x06003E53 RID: 15955 RVA: 0x0011DA88 File Offset: 0x0011BC88
		public int CalculateDecomposeEquipmentBackGold(EquipmentBagItem equipment)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CalculateDecomposeEquipmentBackGoldEquipmentBagItem_hotfix != null)
			{
				return Convert.ToInt32(this.m_CalculateDecomposeEquipmentBackGoldEquipmentBagItem_hotfix.call(new object[]
				{
					this,
					equipment
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int exp = this.CalculateEquipmentTotalExp(equipment);
			return this.CalculateEnhanceEquipmentGold(exp) * this.m_configDataLoader.ConfigableConstId_DecomposeEquipmentBackGoldPercent / 100;
		}

		// Token: 0x06003E54 RID: 15956 RVA: 0x0011DB24 File Offset: 0x0011BD24
		private void LevelUpEquipmentStar(EquipmentBagItem equipment)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LevelUpEquipmentStarEquipmentBagItem_hotfix != null)
			{
				this.m_LevelUpEquipmentStarEquipmentBagItem_hotfix.call(new object[]
				{
					this,
					equipment
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			equipment.StarLevel++;
			this.SetBagItemDirty(equipment);
		}

		// Token: 0x06003E55 RID: 15957 RVA: 0x0011DBAC File Offset: 0x0011BDAC
		protected virtual void OutPutItemOperationLog(GoodsType itemTypeId, int itemId, int nums, GameFunctionType causeId = GameFunctionType.GameFunctionType_None, string location = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OutPutItemOperationLogGoodsTypeInt32Int32GameFunctionTypeString_hotfix != null)
			{
				this.m_OutPutItemOperationLogGoodsTypeInt32Int32GameFunctionTypeString_hotfix.call(new object[]
				{
					this,
					itemTypeId,
					itemId,
					nums,
					causeId,
					location
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06003E56 RID: 15958 RVA: 0x0011DC5C File Offset: 0x0011BE5C
		public void OnSaveEnchantSaveMissionEvent(EquipmentBagItem equipment)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSaveEnchantSaveMissionEventEquipmentBagItem_hotfix != null)
			{
				this.m_OnSaveEnchantSaveMissionEventEquipmentBagItem_hotfix.call(new object[]
				{
					this,
					equipment
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EnchantEquipmentPropertiesSaveMissionEvent != null)
			{
				this.EnchantEquipmentPropertiesSaveMissionEvent(equipment);
			}
		}

		// Token: 0x06003E57 RID: 15959 RVA: 0x0011DCE4 File Offset: 0x0011BEE4
		public void OnEnchantMissionEvent(EquipmentBagItem equipment)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEnchantMissionEventEquipmentBagItem_hotfix != null)
			{
				this.m_OnEnchantMissionEventEquipmentBagItem_hotfix.call(new object[]
				{
					this,
					equipment
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EnchantEquipmentsMissionEvent != null)
			{
				this.EnchantEquipmentsMissionEvent(equipment);
			}
		}

		// Token: 0x06003E58 RID: 15960 RVA: 0x0011DD6C File Offset: 0x0011BF6C
		public void OnCreateBagItemEvent(BagItemBase bagItem)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCreateBagItemEventBagItemBase_hotfix != null)
			{
				this.m_OnCreateBagItemEventBagItemBase_hotfix.call(new object[]
				{
					this,
					bagItem
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.CreateBagItemEvent(bagItem);
		}

		// Token: 0x1400002D RID: 45
		// (add) Token: 0x06003E59 RID: 15961 RVA: 0x0011DDE8 File Offset: 0x0011BFE8
		// (remove) Token: 0x06003E5A RID: 15962 RVA: 0x0011DE84 File Offset: 0x0011C084
		public event Action<int> UseHeroExpItemMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_UseHeroExpItemMissionEventAction`1_hotfix != null)
				{
					this.m_add_UseHeroExpItemMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.UseHeroExpItemMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.UseHeroExpItemMissionEvent, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_UseHeroExpItemMissionEventAction`1_hotfix != null)
				{
					this.m_remove_UseHeroExpItemMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.UseHeroExpItemMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.UseHeroExpItemMissionEvent, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400002E RID: 46
		// (add) Token: 0x06003E5B RID: 15963 RVA: 0x0011DF20 File Offset: 0x0011C120
		// (remove) Token: 0x06003E5C RID: 15964 RVA: 0x0011DFBC File Offset: 0x0011C1BC
		public event Action<EquipmentBagItem> EquipmentLevelupMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EquipmentLevelupMissionEventAction`1_hotfix != null)
				{
					this.m_add_EquipmentLevelupMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<EquipmentBagItem> action = this.EquipmentLevelupMissionEvent;
				Action<EquipmentBagItem> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<EquipmentBagItem>>(ref this.EquipmentLevelupMissionEvent, (Action<EquipmentBagItem>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EquipmentLevelupMissionEventAction`1_hotfix != null)
				{
					this.m_remove_EquipmentLevelupMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<EquipmentBagItem> action = this.EquipmentLevelupMissionEvent;
				Action<EquipmentBagItem> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<EquipmentBagItem>>(ref this.EquipmentLevelupMissionEvent, (Action<EquipmentBagItem>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400002F RID: 47
		// (add) Token: 0x06003E5D RID: 15965 RVA: 0x0011E058 File Offset: 0x0011C258
		// (remove) Token: 0x06003E5E RID: 15966 RVA: 0x0011E0F4 File Offset: 0x0011C2F4
		public event Action<EquipmentBagItem> EnchantEquipmentPropertiesSaveMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EnchantEquipmentPropertiesSaveMissionEventAction`1_hotfix != null)
				{
					this.m_add_EnchantEquipmentPropertiesSaveMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<EquipmentBagItem> action = this.EnchantEquipmentPropertiesSaveMissionEvent;
				Action<EquipmentBagItem> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<EquipmentBagItem>>(ref this.EnchantEquipmentPropertiesSaveMissionEvent, (Action<EquipmentBagItem>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EnchantEquipmentPropertiesSaveMissionEventAction`1_hotfix != null)
				{
					this.m_remove_EnchantEquipmentPropertiesSaveMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<EquipmentBagItem> action = this.EnchantEquipmentPropertiesSaveMissionEvent;
				Action<EquipmentBagItem> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<EquipmentBagItem>>(ref this.EnchantEquipmentPropertiesSaveMissionEvent, (Action<EquipmentBagItem>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000030 RID: 48
		// (add) Token: 0x06003E5F RID: 15967 RVA: 0x0011E190 File Offset: 0x0011C390
		// (remove) Token: 0x06003E60 RID: 15968 RVA: 0x0011E22C File Offset: 0x0011C42C
		public event Action<EquipmentBagItem> EnchantEquipmentsMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EnchantEquipmentsMissionEventAction`1_hotfix != null)
				{
					this.m_add_EnchantEquipmentsMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<EquipmentBagItem> action = this.EnchantEquipmentsMissionEvent;
				Action<EquipmentBagItem> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<EquipmentBagItem>>(ref this.EnchantEquipmentsMissionEvent, (Action<EquipmentBagItem>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EnchantEquipmentsMissionEventAction`1_hotfix != null)
				{
					this.m_remove_EnchantEquipmentsMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<EquipmentBagItem> action = this.EnchantEquipmentsMissionEvent;
				Action<EquipmentBagItem> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<EquipmentBagItem>>(ref this.EnchantEquipmentsMissionEvent, (Action<EquipmentBagItem>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000031 RID: 49
		// (add) Token: 0x06003E61 RID: 15969 RVA: 0x0011E2C8 File Offset: 0x0011C4C8
		// (remove) Token: 0x06003E62 RID: 15970 RVA: 0x0011E364 File Offset: 0x0011C564
		public event Action<BagItemBase> CreateBagItemEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_CreateBagItemEventAction`1_hotfix != null)
				{
					this.m_add_CreateBagItemEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BagItemBase> action = this.CreateBagItemEvent;
				Action<BagItemBase> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BagItemBase>>(ref this.CreateBagItemEvent, (Action<BagItemBase>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_CreateBagItemEventAction`1_hotfix != null)
				{
					this.m_remove_CreateBagItemEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BagItemBase> action = this.CreateBagItemEvent;
				Action<BagItemBase> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BagItemBase>>(ref this.CreateBagItemEvent, (Action<BagItemBase>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170010D7 RID: 4311
		// (get) Token: 0x06003E63 RID: 15971 RVA: 0x0011E400 File Offset: 0x0011C600
		// (set) Token: 0x06003E64 RID: 15972 RVA: 0x0011E420 File Offset: 0x0011C620
		[DoNotToLua]
		public BagComponentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BagComponentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06003E65 RID: 15973 RVA: 0x0011E42C File Offset: 0x0011C62C
		private void __callDele_UseHeroExpItemMissionEvent(int obj)
		{
			Action<int> useHeroExpItemMissionEvent = this.UseHeroExpItemMissionEvent;
			if (useHeroExpItemMissionEvent != null)
			{
				useHeroExpItemMissionEvent(obj);
			}
		}

		// Token: 0x06003E66 RID: 15974 RVA: 0x0011E450 File Offset: 0x0011C650
		private void __clearDele_UseHeroExpItemMissionEvent(int obj)
		{
			this.UseHeroExpItemMissionEvent = null;
		}

		// Token: 0x06003E67 RID: 15975 RVA: 0x0011E45C File Offset: 0x0011C65C
		private void __callDele_EquipmentLevelupMissionEvent(EquipmentBagItem obj)
		{
			Action<EquipmentBagItem> equipmentLevelupMissionEvent = this.EquipmentLevelupMissionEvent;
			if (equipmentLevelupMissionEvent != null)
			{
				equipmentLevelupMissionEvent(obj);
			}
		}

		// Token: 0x06003E68 RID: 15976 RVA: 0x0011E480 File Offset: 0x0011C680
		private void __clearDele_EquipmentLevelupMissionEvent(EquipmentBagItem obj)
		{
			this.EquipmentLevelupMissionEvent = null;
		}

		// Token: 0x06003E69 RID: 15977 RVA: 0x0011E48C File Offset: 0x0011C68C
		private void __callDele_EnchantEquipmentPropertiesSaveMissionEvent(EquipmentBagItem obj)
		{
			Action<EquipmentBagItem> enchantEquipmentPropertiesSaveMissionEvent = this.EnchantEquipmentPropertiesSaveMissionEvent;
			if (enchantEquipmentPropertiesSaveMissionEvent != null)
			{
				enchantEquipmentPropertiesSaveMissionEvent(obj);
			}
		}

		// Token: 0x06003E6A RID: 15978 RVA: 0x0011E4B0 File Offset: 0x0011C6B0
		private void __clearDele_EnchantEquipmentPropertiesSaveMissionEvent(EquipmentBagItem obj)
		{
			this.EnchantEquipmentPropertiesSaveMissionEvent = null;
		}

		// Token: 0x06003E6B RID: 15979 RVA: 0x0011E4BC File Offset: 0x0011C6BC
		private void __callDele_EnchantEquipmentsMissionEvent(EquipmentBagItem obj)
		{
			Action<EquipmentBagItem> enchantEquipmentsMissionEvent = this.EnchantEquipmentsMissionEvent;
			if (enchantEquipmentsMissionEvent != null)
			{
				enchantEquipmentsMissionEvent(obj);
			}
		}

		// Token: 0x06003E6C RID: 15980 RVA: 0x0011E4E0 File Offset: 0x0011C6E0
		private void __clearDele_EnchantEquipmentsMissionEvent(EquipmentBagItem obj)
		{
			this.EnchantEquipmentsMissionEvent = null;
		}

		// Token: 0x06003E6D RID: 15981 RVA: 0x0011E4EC File Offset: 0x0011C6EC
		private void __callDele_CreateBagItemEvent(BagItemBase obj)
		{
			Action<BagItemBase> createBagItemEvent = this.CreateBagItemEvent;
			if (createBagItemEvent != null)
			{
				createBagItemEvent(obj);
			}
		}

		// Token: 0x06003E6E RID: 15982 RVA: 0x0011E510 File Offset: 0x0011C710
		private void __clearDele_CreateBagItemEvent(BagItemBase obj)
		{
			this.CreateBagItemEvent = null;
		}

		// Token: 0x06003E70 RID: 15984 RVA: 0x0011E528 File Offset: 0x0011C728
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
					this.m_IsGoodsEnoughList`1List`1__hotfix = (luaObj.RawGet("IsGoodsEnough") as LuaFunction);
					this.m_ConsumeGoodsList`1List`1List`1GameFunctionTypeString_hotfix = (luaObj.RawGet("ConsumeGoods") as LuaFunction);
					this.m_CountIncreaseBagSizeList`1_hotfix = (luaObj.RawGet("CountIncreaseBagSize") as LuaFunction);
					this.m_CountDecreaseBagSizeList`1_hotfix = (luaObj.RawGet("CountDecreaseBagSize") as LuaFunction);
					this.m_IsBagFullByRandomGoodsInt32List`1List`1_hotfix = (luaObj.RawGet("IsBagFullByRandomGoods") as LuaFunction);
					this.m_IsBagFullByGoodsList`1List`1_hotfix = (luaObj.RawGet("IsBagFullByGoods") as LuaFunction);
					this.m_IsBagFullByGoodsOperationList`1List`1Int32_hotfix = (luaObj.RawGet("IsBagFullByGoodsOperation") as LuaFunction);
					this.m_IsBagFullByBagItemsList`1List`1Int32_hotfix = (luaObj.RawGet("IsBagFullByBagItems") as LuaFunction);
					this.m_IsBagFullInt32_hotfix = (luaObj.RawGet("IsBagFull") as LuaFunction);
					this.m_GetBagSize_hotfix = (luaObj.RawGet("GetBagSize") as LuaFunction);
					this.m_IsBagFullByCurrentSize_hotfix = (luaObj.RawGet("IsBagFullByCurrentSize") as LuaFunction);
					this.m_IsHeuristicBagFullList`1_hotfix = (luaObj.RawGet("IsHeuristicBagFull") as LuaFunction);
					this.m_FilterNonBagItemList`1_hotfix = (luaObj.RawGet("FilterNonBagItem") as LuaFunction);
					this.m_FilterNonBagItemsWhenAddList`1_hotfix = (luaObj.RawGet("FilterNonBagItemsWhenAdd") as LuaFunction);
					this.m_TransformHeroGoodsInt32Int32_hotfix = (luaObj.RawGet("TransformHeroGoods") as LuaFunction);
					this.m_IsBagItemContentIdInConfigGoodsTypeInt32_hotfix = (luaObj.RawGet("IsBagItemContentIdInConfig") as LuaFunction);
					this.m_RemoveAllBagItemsList`1Int32_hotfix = (luaObj.RawGet("RemoveAllBagItems") as LuaFunction);
					this.m_RemoveBagItemGoodsTypeInt32Int32UInt64GameFunctionTypeString_hotfix = (luaObj.RawGet("RemoveBagItem") as LuaFunction);
					this.m_RemoveBagItemByItemBagItemBaseInt32GameFunctionTypeString_hotfix = (luaObj.RawGet("RemoveBagItemByItem") as LuaFunction);
					this.m_RemoveBagItemByTypeGoodsTypeInt32Int32GameFunctionTypeString_hotfix = (luaObj.RawGet("RemoveBagItemByType") as LuaFunction);
					this.m_RemoveBagItemByInstanceIdUInt64GameFunctionTypeString_hotfix = (luaObj.RawGet("RemoveBagItemByInstanceId") as LuaFunction);
					this.m_RemoveBagItemDirectlyBagItemBaseInt32GameFunctionTypeString_hotfix = (luaObj.RawGet("RemoveBagItemDirectly") as LuaFunction);
					this.m_FindBagItemGoodsTypeInt32UInt64_hotfix = (luaObj.RawGet("FindBagItem") as LuaFunction);
					this.m_FindBagItemByInstanceIdUInt64_hotfix = (luaObj.RawGet("FindBagItemByInstanceId") as LuaFunction);
					this.m_FindBagItemByTypeGoodsTypeInt32_hotfix = (luaObj.RawGet("FindBagItemByType") as LuaFunction);
					this.m_FindUseableBagItemGoodsTypeInt32_hotfix = (luaObj.RawGet("FindUseableBagItem") as LuaFunction);
					this.m_GetAllBagItems_hotfix = (luaObj.RawGet("GetAllBagItems") as LuaFunction);
					this.m_IterateAllBagItems_hotfix = (luaObj.RawGet("IterateAllBagItems") as LuaFunction);
					this.m_FindEnoughBagItemsList`1_hotfix = (luaObj.RawGet("FindEnoughBagItems") as LuaFunction);
					this.m_UseBagItemGoodsTypeInt32Int32Objectbe_hotfix = (luaObj.RawGet("UseBagItem") as LuaFunction);
					this.m_UseBagItemUseableBagItemInt32Objectbe_hotfix = (luaObj.RawGet("UseBagItem") as LuaFunction);
					this.m_UseBagItemDirectlyUseableBagItemInt32Objectbe_hotfix = (luaObj.RawGet("UseBagItemDirectly") as LuaFunction);
					this.m_HasEnoughBagItemBagItemBaseInt32_hotfix = (luaObj.RawGet("HasEnoughBagItem") as LuaFunction);
					this.m_IsBagItemEnoughBagItemBaseInt32_hotfix = (luaObj.RawGet("IsBagItemEnough") as LuaFunction);
					this.m_IsBagItemEnoughGoodsTypeInt32Int32_hotfix = (luaObj.RawGet("IsBagItemEnough") as LuaFunction);
					this.m_GetTicketIdGameFunctionType_hotfix = (luaObj.RawGet("GetTicketId") as LuaFunction);
					this.m_IsLevelTicketsMaxByUIGameFunctionTypeGoodsTypeInt32Int32_hotfix = (luaObj.RawGet("IsLevelTicketsMaxByUI") as LuaFunction);
					this.m_IsLevelTicketsMaxConfigDataTicketLimitInfoInt32Int32_hotfix = (luaObj.RawGet("IsLevelTicketsMax") as LuaFunction);
					this.m_SellBagItemUInt64Int32_hotfix = (luaObj.RawGet("SellBagItem") as LuaFunction);
					this.m_CombineSameGoodsAndReplaceExistHeroToFragmentList`1_hotfix = (luaObj.RawGet("CombineSameGoodsAndReplaceExistHeroToFragment") as LuaFunction);
					this.m_CanDecomposeBagItemsList`1_hotfix = (luaObj.RawGet("CanDecomposeBagItems") as LuaFunction);
					this.m_CanDecomposeABagItemGoodsTypeInt32Int32UInt64_hotfix = (luaObj.RawGet("CanDecomposeABagItem") as LuaFunction);
					this.m_SetBagItemDirtyBagItemBase_hotfix = (luaObj.RawGet("SetBagItemDirty") as LuaFunction);
					this.m_IsPercentBaseBattlePropertyPropertyModifyType_hotfix = (luaObj.RawGet("IsPercentBaseBattleProperty") as LuaFunction);
					this.m_CanLockAndUnLockEquipmentUInt64_hotfix = (luaObj.RawGet("CanLockAndUnLockEquipment") as LuaFunction);
					this.m_LockAndUnLockEquipmentUInt64_hotfix = (luaObj.RawGet("LockAndUnLockEquipment") as LuaFunction);
					this.m_CanEnhanceEquipmentUInt64List`1_hotfix = (luaObj.RawGet("CanEnhanceEquipment") as LuaFunction);
					this.m_CanWearEquipmentByEquipmentTypeBagItemBase_hotfix = (luaObj.RawGet("CanWearEquipmentByEquipmentType") as LuaFunction);
					this.m_IsThisEquipmentTypeBagItemBaseEquipmentType_hotfix = (luaObj.RawGet("IsThisEquipmentType") as LuaFunction);
					this.m_IsLevelUpEquipmentStarLevelEquipmentBagItem_hotfix = (luaObj.RawGet("IsLevelUpEquipmentStarLevel") as LuaFunction);
					this.m_CalculateEnhanceEquipmentExpList`1_hotfix = (luaObj.RawGet("CalculateEnhanceEquipmentExp") as LuaFunction);
					this.m_CalculateEnhanceEquipmentGoldInt32_hotfix = (luaObj.RawGet("CalculateEnhanceEquipmentGold") as LuaFunction);
					this.m_EnhanceEquipmentUInt64List`1_hotfix = (luaObj.RawGet("EnhanceEquipment") as LuaFunction);
					this.m_CanEnchantEquipmentUInt64UInt64_hotfix = (luaObj.RawGet("CanEnchantEquipment") as LuaFunction);
					this.m_OutPutEqipmentEnhanceOperateLogEquipmentBagItemInt32Int32List`1_hotfix = (luaObj.RawGet("OutPutEqipmentEnhanceOperateLog") as LuaFunction);
					this.m_OutPutEquipmentUpgrageOperateLogEquipmentBagItemEquipmentBagItemInt32Int32List`1_hotfix = (luaObj.RawGet("OutPutEquipmentUpgrageOperateLog") as LuaFunction);
					this.m_AddEquipmentExpEquipmentBagItemInt32_hotfix = (luaObj.RawGet("AddEquipmentExp") as LuaFunction);
					this.m_LevelUpEquipmentEquipmentBagItem_hotfix = (luaObj.RawGet("LevelUpEquipment") as LuaFunction);
					this.m_IsEquipmentMaxExpEquipmentBagItem_hotfix = (luaObj.RawGet("IsEquipmentMaxExp") as LuaFunction);
					this.m_CaculateEquipmentNextLevelExpInt32Int32_hotfix = (luaObj.RawGet("CaculateEquipmentNextLevelExp") as LuaFunction);
					this.m_IsEquipmentMaxLevelEquipmentBagItem_hotfix = (luaObj.RawGet("IsEquipmentMaxLevel") as LuaFunction);
					this.m_GetEquipmentLevelLimitInt32_hotfix = (luaObj.RawGet("GetEquipmentLevelLimit") as LuaFunction);
					this.m_CanLevelUpEquipmentStarUInt64UInt64_hotfix = (luaObj.RawGet("CanLevelUpEquipmentStar") as LuaFunction);
					this.m_GetLevelUpEquipmentStarItemsInt32ConfigDataEquipmentInfo_hotfix = (luaObj.RawGet("GetLevelUpEquipmentStarItems") as LuaFunction);
					this.m_CalculateLevelUpEquipmentStarGoldEquipmentBagItem_hotfix = (luaObj.RawGet("CalculateLevelUpEquipmentStarGold") as LuaFunction);
					this.m_LevelUpEquipmentStarUInt64UInt64_hotfix = (luaObj.RawGet("LevelUpEquipmentStar") as LuaFunction);
					this.m_CalculateEquipmentTotalExpEquipmentBagItem_hotfix = (luaObj.RawGet("CalculateEquipmentTotalExp") as LuaFunction);
					this.m_CalculateDecomposeEquipmentBackGoldEquipmentBagItem_hotfix = (luaObj.RawGet("CalculateDecomposeEquipmentBackGold") as LuaFunction);
					this.m_LevelUpEquipmentStarEquipmentBagItem_hotfix = (luaObj.RawGet("LevelUpEquipmentStar") as LuaFunction);
					this.m_OutPutItemOperationLogGoodsTypeInt32Int32GameFunctionTypeString_hotfix = (luaObj.RawGet("OutPutItemOperationLog") as LuaFunction);
					this.m_OnSaveEnchantSaveMissionEventEquipmentBagItem_hotfix = (luaObj.RawGet("OnSaveEnchantSaveMissionEvent") as LuaFunction);
					this.m_OnEnchantMissionEventEquipmentBagItem_hotfix = (luaObj.RawGet("OnEnchantMissionEvent") as LuaFunction);
					this.m_OnCreateBagItemEventBagItemBase_hotfix = (luaObj.RawGet("OnCreateBagItemEvent") as LuaFunction);
					this.m_add_UseHeroExpItemMissionEventAction`1_hotfix = (luaObj.RawGet("add_UseHeroExpItemMissionEvent") as LuaFunction);
					this.m_remove_UseHeroExpItemMissionEventAction`1_hotfix = (luaObj.RawGet("remove_UseHeroExpItemMissionEvent") as LuaFunction);
					this.m_add_EquipmentLevelupMissionEventAction`1_hotfix = (luaObj.RawGet("add_EquipmentLevelupMissionEvent") as LuaFunction);
					this.m_remove_EquipmentLevelupMissionEventAction`1_hotfix = (luaObj.RawGet("remove_EquipmentLevelupMissionEvent") as LuaFunction);
					this.m_add_EnchantEquipmentPropertiesSaveMissionEventAction`1_hotfix = (luaObj.RawGet("add_EnchantEquipmentPropertiesSaveMissionEvent") as LuaFunction);
					this.m_remove_EnchantEquipmentPropertiesSaveMissionEventAction`1_hotfix = (luaObj.RawGet("remove_EnchantEquipmentPropertiesSaveMissionEvent") as LuaFunction);
					this.m_add_EnchantEquipmentsMissionEventAction`1_hotfix = (luaObj.RawGet("add_EnchantEquipmentsMissionEvent") as LuaFunction);
					this.m_remove_EnchantEquipmentsMissionEventAction`1_hotfix = (luaObj.RawGet("remove_EnchantEquipmentsMissionEvent") as LuaFunction);
					this.m_add_CreateBagItemEventAction`1_hotfix = (luaObj.RawGet("add_CreateBagItemEvent") as LuaFunction);
					this.m_remove_CreateBagItemEventAction`1_hotfix = (luaObj.RawGet("remove_CreateBagItemEvent") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06003E71 RID: 15985 RVA: 0x0011EF08 File Offset: 0x0011D108
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BagComponentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002ED7 RID: 11991
		protected DataSectionBag m_bagDS;

		// Token: 0x04002ED8 RID: 11992
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x04002ED9 RID: 11993
		protected ResourceComponentCommon m_resource;

		// Token: 0x04002EDA RID: 11994
		protected HeroComponentCommon m_hero;

		// Token: 0x04002EDB RID: 11995
		protected IConfigDataLoader m_configDataLoader;

		// Token: 0x04002EDC RID: 11996
		protected BagItemFactory m_bagItemFactory;

		// Token: 0x04002EDD RID: 11997
		private int m_enhanceEquipmentMaterialExp;

		// Token: 0x04002EE2 RID: 12002
		[DoNotToLua]
		private BagComponentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x04002EE4 RID: 12004
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002EE5 RID: 12005
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002EE6 RID: 12006
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04002EE7 RID: 12007
		private LuaFunction m_GetName_hotfix;

		// Token: 0x04002EE8 RID: 12008
		private LuaFunction m_Init_hotfix;

		// Token: 0x04002EE9 RID: 12009
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04002EEA RID: 12010
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04002EEB RID: 12011
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x04002EEC RID: 12012
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x04002EED RID: 12013
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x04002EEE RID: 12014
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x04002EEF RID: 12015
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x04002EF0 RID: 12016
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x04002EF1 RID: 12017
		private LuaFunction m_IsGoodsEnoughList`1List;

		// Token: 0x04002EF2 RID: 12018
		private LuaFunction m_ConsumeGoodsList`1List`1List;

		// Token: 0x04002EF3 RID: 12019
		private LuaFunction m_CountIncreaseBagSizeList;

		// Token: 0x04002EF4 RID: 12020
		private LuaFunction m_CountDecreaseBagSizeList;

		// Token: 0x04002EF5 RID: 12021
		private LuaFunction m_IsBagFullByRandomGoodsInt32List`1List;

		// Token: 0x04002EF6 RID: 12022
		private LuaFunction m_IsBagFullByGoodsList`1List;

		// Token: 0x04002EF7 RID: 12023
		private LuaFunction m_IsBagFullByGoodsOperationList`1List;

		// Token: 0x04002EF8 RID: 12024
		private LuaFunction m_IsBagFullByBagItemsList`1List;

		// Token: 0x04002EF9 RID: 12025
		private LuaFunction m_IsBagFullInt32_hotfix;

		// Token: 0x04002EFA RID: 12026
		private LuaFunction m_GetBagSize_hotfix;

		// Token: 0x04002EFB RID: 12027
		private LuaFunction m_IsBagFullByCurrentSize_hotfix;

		// Token: 0x04002EFC RID: 12028
		private LuaFunction m_IsHeuristicBagFullList;

		// Token: 0x04002EFD RID: 12029
		private LuaFunction m_FilterNonBagItemList;

		// Token: 0x04002EFE RID: 12030
		private LuaFunction m_FilterNonBagItemsWhenAddList;

		// Token: 0x04002EFF RID: 12031
		private LuaFunction m_TransformHeroGoodsInt32Int32_hotfix;

		// Token: 0x04002F00 RID: 12032
		private LuaFunction m_IsBagItemContentIdInConfigGoodsTypeInt32_hotfix;

		// Token: 0x04002F01 RID: 12033
		private LuaFunction m_RemoveAllBagItemsList;

		// Token: 0x04002F02 RID: 12034
		private LuaFunction m_RemoveBagItemGoodsTypeInt32Int32UInt64GameFunctionTypeString_hotfix;

		// Token: 0x04002F03 RID: 12035
		private LuaFunction m_RemoveBagItemByItemBagItemBaseInt32GameFunctionTypeString_hotfix;

		// Token: 0x04002F04 RID: 12036
		private LuaFunction m_RemoveBagItemByTypeGoodsTypeInt32Int32GameFunctionTypeString_hotfix;

		// Token: 0x04002F05 RID: 12037
		private LuaFunction m_RemoveBagItemByInstanceIdUInt64GameFunctionTypeString_hotfix;

		// Token: 0x04002F06 RID: 12038
		private LuaFunction m_RemoveBagItemDirectlyBagItemBaseInt32GameFunctionTypeString_hotfix;

		// Token: 0x04002F07 RID: 12039
		private LuaFunction m_FindBagItemGoodsTypeInt32UInt64_hotfix;

		// Token: 0x04002F08 RID: 12040
		private LuaFunction m_FindBagItemByInstanceIdUInt64_hotfix;

		// Token: 0x04002F09 RID: 12041
		private LuaFunction m_FindBagItemByTypeGoodsTypeInt32_hotfix;

		// Token: 0x04002F0A RID: 12042
		private LuaFunction m_FindUseableBagItemGoodsTypeInt32_hotfix;

		// Token: 0x04002F0B RID: 12043
		private LuaFunction m_GetAllBagItems_hotfix;

		// Token: 0x04002F0C RID: 12044
		private LuaFunction m_IterateAllBagItems_hotfix;

		// Token: 0x04002F0D RID: 12045
		private LuaFunction m_FindEnoughBagItemsList;

		// Token: 0x04002F0E RID: 12046
		private LuaFunction m_UseBagItemGoodsTypeInt32Int32Objectbe_hotfix;

		// Token: 0x04002F0F RID: 12047
		private LuaFunction m_UseBagItemUseableBagItemInt32Objectbe_hotfix;

		// Token: 0x04002F10 RID: 12048
		private LuaFunction m_UseBagItemDirectlyUseableBagItemInt32Objectbe_hotfix;

		// Token: 0x04002F11 RID: 12049
		private LuaFunction m_HasEnoughBagItemBagItemBaseInt32_hotfix;

		// Token: 0x04002F12 RID: 12050
		private LuaFunction m_IsBagItemEnoughBagItemBaseInt32_hotfix;

		// Token: 0x04002F13 RID: 12051
		private LuaFunction m_IsBagItemEnoughGoodsTypeInt32Int32_hotfix;

		// Token: 0x04002F14 RID: 12052
		private LuaFunction m_GetTicketIdGameFunctionType_hotfix;

		// Token: 0x04002F15 RID: 12053
		private LuaFunction m_IsLevelTicketsMaxByUIGameFunctionTypeGoodsTypeInt32Int32_hotfix;

		// Token: 0x04002F16 RID: 12054
		private LuaFunction m_IsLevelTicketsMaxConfigDataTicketLimitInfoInt32Int32_hotfix;

		// Token: 0x04002F17 RID: 12055
		private LuaFunction m_SellBagItemUInt64Int32_hotfix;

		// Token: 0x04002F18 RID: 12056
		private LuaFunction m_CombineSameGoodsAndReplaceExistHeroToFragmentList;

		// Token: 0x04002F19 RID: 12057
		private LuaFunction m_CanDecomposeBagItemsList;

		// Token: 0x04002F1A RID: 12058
		private LuaFunction m_CanDecomposeABagItemGoodsTypeInt32Int32UInt64_hotfix;

		// Token: 0x04002F1B RID: 12059
		private LuaFunction m_SetBagItemDirtyBagItemBase_hotfix;

		// Token: 0x04002F1C RID: 12060
		private LuaFunction m_IsPercentBaseBattlePropertyPropertyModifyType_hotfix;

		// Token: 0x04002F1D RID: 12061
		private LuaFunction m_CanLockAndUnLockEquipmentUInt64_hotfix;

		// Token: 0x04002F1E RID: 12062
		private LuaFunction m_LockAndUnLockEquipmentUInt64_hotfix;

		// Token: 0x04002F1F RID: 12063
		private LuaFunction m_CanEnhanceEquipmentUInt64List;

		// Token: 0x04002F20 RID: 12064
		private LuaFunction m_CanWearEquipmentByEquipmentTypeBagItemBase_hotfix;

		// Token: 0x04002F21 RID: 12065
		private LuaFunction m_IsThisEquipmentTypeBagItemBaseEquipmentType_hotfix;

		// Token: 0x04002F22 RID: 12066
		private LuaFunction m_IsLevelUpEquipmentStarLevelEquipmentBagItem_hotfix;

		// Token: 0x04002F23 RID: 12067
		private LuaFunction m_CalculateEnhanceEquipmentExpList;

		// Token: 0x04002F24 RID: 12068
		private LuaFunction m_CalculateEnhanceEquipmentGoldInt32_hotfix;

		// Token: 0x04002F25 RID: 12069
		private LuaFunction m_EnhanceEquipmentUInt64List;

		// Token: 0x04002F26 RID: 12070
		private LuaFunction m_CanEnchantEquipmentUInt64UInt64_hotfix;

		// Token: 0x04002F27 RID: 12071
		private LuaFunction m_OutPutEqipmentEnhanceOperateLogEquipmentBagItemInt32Int32List;

		// Token: 0x04002F28 RID: 12072
		private LuaFunction m_OutPutEquipmentUpgrageOperateLogEquipmentBagItemEquipmentBagItemInt32Int32List;

		// Token: 0x04002F29 RID: 12073
		private LuaFunction m_AddEquipmentExpEquipmentBagItemInt32_hotfix;

		// Token: 0x04002F2A RID: 12074
		private LuaFunction m_LevelUpEquipmentEquipmentBagItem_hotfix;

		// Token: 0x04002F2B RID: 12075
		private LuaFunction m_IsEquipmentMaxExpEquipmentBagItem_hotfix;

		// Token: 0x04002F2C RID: 12076
		private LuaFunction m_CaculateEquipmentNextLevelExpInt32Int32_hotfix;

		// Token: 0x04002F2D RID: 12077
		private LuaFunction m_IsEquipmentMaxLevelEquipmentBagItem_hotfix;

		// Token: 0x04002F2E RID: 12078
		private LuaFunction m_GetEquipmentLevelLimitInt32_hotfix;

		// Token: 0x04002F2F RID: 12079
		private LuaFunction m_CanLevelUpEquipmentStarUInt64UInt64_hotfix;

		// Token: 0x04002F30 RID: 12080
		private LuaFunction m_GetLevelUpEquipmentStarItemsInt32ConfigDataEquipmentInfo_hotfix;

		// Token: 0x04002F31 RID: 12081
		private LuaFunction m_CalculateLevelUpEquipmentStarGoldEquipmentBagItem_hotfix;

		// Token: 0x04002F32 RID: 12082
		private LuaFunction m_LevelUpEquipmentStarUInt64UInt64_hotfix;

		// Token: 0x04002F33 RID: 12083
		private LuaFunction m_CalculateEquipmentTotalExpEquipmentBagItem_hotfix;

		// Token: 0x04002F34 RID: 12084
		private LuaFunction m_CalculateDecomposeEquipmentBackGoldEquipmentBagItem_hotfix;

		// Token: 0x04002F35 RID: 12085
		private LuaFunction m_LevelUpEquipmentStarEquipmentBagItem_hotfix;

		// Token: 0x04002F36 RID: 12086
		private LuaFunction m_OutPutItemOperationLogGoodsTypeInt32Int32GameFunctionTypeString_hotfix;

		// Token: 0x04002F37 RID: 12087
		private LuaFunction m_OnSaveEnchantSaveMissionEventEquipmentBagItem_hotfix;

		// Token: 0x04002F38 RID: 12088
		private LuaFunction m_OnEnchantMissionEventEquipmentBagItem_hotfix;

		// Token: 0x04002F39 RID: 12089
		private LuaFunction m_OnCreateBagItemEventBagItemBase_hotfix;

		// Token: 0x04002F3A RID: 12090
		private LuaFunction m_add_UseHeroExpItemMissionEventAction;

		// Token: 0x04002F3B RID: 12091
		private LuaFunction m_remove_UseHeroExpItemMissionEventAction;

		// Token: 0x04002F3C RID: 12092
		private LuaFunction m_add_EquipmentLevelupMissionEventAction;

		// Token: 0x04002F3D RID: 12093
		private LuaFunction m_remove_EquipmentLevelupMissionEventAction;

		// Token: 0x04002F3E RID: 12094
		private LuaFunction m_add_EnchantEquipmentPropertiesSaveMissionEventAction;

		// Token: 0x04002F3F RID: 12095
		private LuaFunction m_remove_EnchantEquipmentPropertiesSaveMissionEventAction;

		// Token: 0x04002F40 RID: 12096
		private LuaFunction m_add_EnchantEquipmentsMissionEventAction;

		// Token: 0x04002F41 RID: 12097
		private LuaFunction m_remove_EnchantEquipmentsMissionEventAction;

		// Token: 0x04002F42 RID: 12098
		private LuaFunction m_add_CreateBagItemEventAction;

		// Token: 0x04002F43 RID: 12099
		private LuaFunction m_remove_CreateBagItemEventAction;

		// Token: 0x02000431 RID: 1073
		public class LuaExportHelper
		{
			// Token: 0x06003E72 RID: 15986 RVA: 0x0011EF70 File Offset: 0x0011D170
			public LuaExportHelper(BagComponentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06003E73 RID: 15987 RVA: 0x0011EF80 File Offset: 0x0011D180
			public void __callDele_UseHeroExpItemMissionEvent(int obj)
			{
				this.m_owner.__callDele_UseHeroExpItemMissionEvent(obj);
			}

			// Token: 0x06003E74 RID: 15988 RVA: 0x0011EF90 File Offset: 0x0011D190
			public void __clearDele_UseHeroExpItemMissionEvent(int obj)
			{
				this.m_owner.__clearDele_UseHeroExpItemMissionEvent(obj);
			}

			// Token: 0x06003E75 RID: 15989 RVA: 0x0011EFA0 File Offset: 0x0011D1A0
			public void __callDele_EquipmentLevelupMissionEvent(EquipmentBagItem obj)
			{
				this.m_owner.__callDele_EquipmentLevelupMissionEvent(obj);
			}

			// Token: 0x06003E76 RID: 15990 RVA: 0x0011EFB0 File Offset: 0x0011D1B0
			public void __clearDele_EquipmentLevelupMissionEvent(EquipmentBagItem obj)
			{
				this.m_owner.__clearDele_EquipmentLevelupMissionEvent(obj);
			}

			// Token: 0x06003E77 RID: 15991 RVA: 0x0011EFC0 File Offset: 0x0011D1C0
			public void __callDele_EnchantEquipmentPropertiesSaveMissionEvent(EquipmentBagItem obj)
			{
				this.m_owner.__callDele_EnchantEquipmentPropertiesSaveMissionEvent(obj);
			}

			// Token: 0x06003E78 RID: 15992 RVA: 0x0011EFD0 File Offset: 0x0011D1D0
			public void __clearDele_EnchantEquipmentPropertiesSaveMissionEvent(EquipmentBagItem obj)
			{
				this.m_owner.__clearDele_EnchantEquipmentPropertiesSaveMissionEvent(obj);
			}

			// Token: 0x06003E79 RID: 15993 RVA: 0x0011EFE0 File Offset: 0x0011D1E0
			public void __callDele_EnchantEquipmentsMissionEvent(EquipmentBagItem obj)
			{
				this.m_owner.__callDele_EnchantEquipmentsMissionEvent(obj);
			}

			// Token: 0x06003E7A RID: 15994 RVA: 0x0011EFF0 File Offset: 0x0011D1F0
			public void __clearDele_EnchantEquipmentsMissionEvent(EquipmentBagItem obj)
			{
				this.m_owner.__clearDele_EnchantEquipmentsMissionEvent(obj);
			}

			// Token: 0x06003E7B RID: 15995 RVA: 0x0011F000 File Offset: 0x0011D200
			public void __callDele_CreateBagItemEvent(BagItemBase obj)
			{
				this.m_owner.__callDele_CreateBagItemEvent(obj);
			}

			// Token: 0x06003E7C RID: 15996 RVA: 0x0011F010 File Offset: 0x0011D210
			public void __clearDele_CreateBagItemEvent(BagItemBase obj)
			{
				this.m_owner.__clearDele_CreateBagItemEvent(obj);
			}

			// Token: 0x170010D8 RID: 4312
			// (get) Token: 0x06003E7D RID: 15997 RVA: 0x0011F020 File Offset: 0x0011D220
			// (set) Token: 0x06003E7E RID: 15998 RVA: 0x0011F030 File Offset: 0x0011D230
			public DataSectionBag m_bagDS
			{
				get
				{
					return this.m_owner.m_bagDS;
				}
				set
				{
					this.m_owner.m_bagDS = value;
				}
			}

			// Token: 0x170010D9 RID: 4313
			// (get) Token: 0x06003E7F RID: 15999 RVA: 0x0011F040 File Offset: 0x0011D240
			// (set) Token: 0x06003E80 RID: 16000 RVA: 0x0011F050 File Offset: 0x0011D250
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

			// Token: 0x170010DA RID: 4314
			// (get) Token: 0x06003E81 RID: 16001 RVA: 0x0011F060 File Offset: 0x0011D260
			// (set) Token: 0x06003E82 RID: 16002 RVA: 0x0011F070 File Offset: 0x0011D270
			public ResourceComponentCommon m_resource
			{
				get
				{
					return this.m_owner.m_resource;
				}
				set
				{
					this.m_owner.m_resource = value;
				}
			}

			// Token: 0x170010DB RID: 4315
			// (get) Token: 0x06003E83 RID: 16003 RVA: 0x0011F080 File Offset: 0x0011D280
			// (set) Token: 0x06003E84 RID: 16004 RVA: 0x0011F090 File Offset: 0x0011D290
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

			// Token: 0x170010DC RID: 4316
			// (get) Token: 0x06003E85 RID: 16005 RVA: 0x0011F0A0 File Offset: 0x0011D2A0
			// (set) Token: 0x06003E86 RID: 16006 RVA: 0x0011F0B0 File Offset: 0x0011D2B0
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

			// Token: 0x170010DD RID: 4317
			// (get) Token: 0x06003E87 RID: 16007 RVA: 0x0011F0C0 File Offset: 0x0011D2C0
			// (set) Token: 0x06003E88 RID: 16008 RVA: 0x0011F0D0 File Offset: 0x0011D2D0
			public BagItemFactory m_bagItemFactory
			{
				get
				{
					return this.m_owner.m_bagItemFactory;
				}
				set
				{
					this.m_owner.m_bagItemFactory = value;
				}
			}

			// Token: 0x170010DE RID: 4318
			// (get) Token: 0x06003E89 RID: 16009 RVA: 0x0011F0E0 File Offset: 0x0011D2E0
			// (set) Token: 0x06003E8A RID: 16010 RVA: 0x0011F0F0 File Offset: 0x0011D2F0
			public int m_enhanceEquipmentMaterialExp
			{
				get
				{
					return this.m_owner.m_enhanceEquipmentMaterialExp;
				}
				set
				{
					this.m_owner.m_enhanceEquipmentMaterialExp = value;
				}
			}

			// Token: 0x06003E8B RID: 16011 RVA: 0x0011F100 File Offset: 0x0011D300
			public int CountIncreaseBagSize(List<Goods> addBagItems)
			{
				return this.m_owner.CountIncreaseBagSize(addBagItems);
			}

			// Token: 0x06003E8C RID: 16012 RVA: 0x0011F110 File Offset: 0x0011D310
			public int CountDecreaseBagSize(List<Goods> deleteBagItems)
			{
				return this.m_owner.CountDecreaseBagSize(deleteBagItems);
			}

			// Token: 0x06003E8D RID: 16013 RVA: 0x0011F120 File Offset: 0x0011D320
			public bool IsBagFullByGoodsOperation(List<Goods> addGoods, List<Goods> deleteGoods, int addRandomRewardExpectSize)
			{
				return this.m_owner.IsBagFullByGoodsOperation(addGoods, deleteGoods, addRandomRewardExpectSize);
			}

			// Token: 0x06003E8E RID: 16014 RVA: 0x0011F130 File Offset: 0x0011D330
			public bool IsBagFullByBagItems(List<Goods> addBagItems, List<Goods> deleteBagItems, int addRandomRewardExpectSize)
			{
				return this.m_owner.IsBagFullByBagItems(addBagItems, deleteBagItems, addRandomRewardExpectSize);
			}

			// Token: 0x06003E8F RID: 16015 RVA: 0x0011F140 File Offset: 0x0011D340
			public bool IsHeuristicBagFull(List<Goods> adds)
			{
				return this.m_owner.IsHeuristicBagFull(adds);
			}

			// Token: 0x06003E90 RID: 16016 RVA: 0x0011F150 File Offset: 0x0011D350
			public List<Goods> FilterNonBagItem(List<Goods> goods)
			{
				return this.m_owner.FilterNonBagItem(goods);
			}

			// Token: 0x06003E91 RID: 16017 RVA: 0x0011F160 File Offset: 0x0011D360
			public List<Goods> FilterNonBagItemsWhenAdd(List<Goods> goodsList)
			{
				return this.m_owner.FilterNonBagItemsWhenAdd(goodsList);
			}

			// Token: 0x06003E92 RID: 16018 RVA: 0x0011F170 File Offset: 0x0011D370
			public List<Goods> TransformHeroGoods(int heroId, int nums)
			{
				return this.m_owner.TransformHeroGoods(heroId, nums);
			}

			// Token: 0x06003E93 RID: 16019 RVA: 0x0011F180 File Offset: 0x0011D380
			public int RemoveBagItemByItem(BagItemBase bagItem, int consumeNums, GameFunctionType caseId, string location)
			{
				return this.m_owner.RemoveBagItemByItem(bagItem, consumeNums, caseId, location);
			}

			// Token: 0x06003E94 RID: 16020 RVA: 0x0011F194 File Offset: 0x0011D394
			public bool IsBagItemEnough(BagItemBase bagItem, int consumeNums)
			{
				return this.m_owner.IsBagItemEnough(bagItem, consumeNums);
			}

			// Token: 0x06003E95 RID: 16021 RVA: 0x0011F1A4 File Offset: 0x0011D3A4
			public bool IsLevelTicketsMax(ConfigDataTicketLimitInfo ticketLimitInfo, int contentId, int nums)
			{
				return this.m_owner.IsLevelTicketsMax(ticketLimitInfo, contentId, nums);
			}

			// Token: 0x06003E96 RID: 16022 RVA: 0x0011F1B4 File Offset: 0x0011D3B4
			public bool IsThisEquipmentType(BagItemBase equipment, EquipmentType type)
			{
				return this.m_owner.IsThisEquipmentType(equipment, type);
			}

			// Token: 0x06003E97 RID: 16023 RVA: 0x0011F1C4 File Offset: 0x0011D3C4
			public bool IsLevelUpEquipmentStarLevel(EquipmentBagItem equipment)
			{
				return this.m_owner.IsLevelUpEquipmentStarLevel(equipment);
			}

			// Token: 0x06003E98 RID: 16024 RVA: 0x0011F1D4 File Offset: 0x0011D3D4
			public void OutPutEqipmentEnhanceOperateLog(EquipmentBagItem equipment, int preLevel, int preExp, List<Goods> costItems)
			{
				this.m_owner.OutPutEqipmentEnhanceOperateLog(equipment, preLevel, preExp, costItems);
			}

			// Token: 0x06003E99 RID: 16025 RVA: 0x0011F1E8 File Offset: 0x0011D3E8
			public void OutPutEquipmentUpgrageOperateLog(EquipmentBagItem equipment, EquipmentBagItem material, int preLvlLimit, int postLvlLimit, List<Goods> costItems)
			{
				this.m_owner.OutPutEquipmentUpgrageOperateLog(equipment, material, preLvlLimit, postLvlLimit, costItems);
			}

			// Token: 0x06003E9A RID: 16026 RVA: 0x0011F1FC File Offset: 0x0011D3FC
			public void AddEquipmentExp(EquipmentBagItem equipment, int exp)
			{
				this.m_owner.AddEquipmentExp(equipment, exp);
			}

			// Token: 0x06003E9B RID: 16027 RVA: 0x0011F20C File Offset: 0x0011D40C
			public void LevelUpEquipment(EquipmentBagItem equipment)
			{
				this.m_owner.LevelUpEquipment(equipment);
			}

			// Token: 0x06003E9C RID: 16028 RVA: 0x0011F21C File Offset: 0x0011D41C
			public bool IsEquipmentMaxExp(EquipmentBagItem equipment)
			{
				return this.m_owner.IsEquipmentMaxExp(equipment);
			}

			// Token: 0x06003E9D RID: 16029 RVA: 0x0011F22C File Offset: 0x0011D42C
			public bool IsEquipmentMaxLevel(EquipmentBagItem equipment)
			{
				return this.m_owner.IsEquipmentMaxLevel(equipment);
			}

			// Token: 0x06003E9E RID: 16030 RVA: 0x0011F23C File Offset: 0x0011D43C
			public int GetEquipmentLevelLimit(int equipmentStarLevel)
			{
				return this.m_owner.GetEquipmentLevelLimit(equipmentStarLevel);
			}

			// Token: 0x06003E9F RID: 16031 RVA: 0x0011F24C File Offset: 0x0011D44C
			public List<Goods> GetLevelUpEquipmentStarItems(int star, ConfigDataEquipmentInfo equipmentInfo)
			{
				return this.m_owner.GetLevelUpEquipmentStarItems(star, equipmentInfo);
			}

			// Token: 0x06003EA0 RID: 16032 RVA: 0x0011F25C File Offset: 0x0011D45C
			public void LevelUpEquipmentStar(EquipmentBagItem equipment)
			{
				this.m_owner.LevelUpEquipmentStar(equipment);
			}

			// Token: 0x06003EA1 RID: 16033 RVA: 0x0011F26C File Offset: 0x0011D46C
			public void OutPutItemOperationLog(GoodsType itemTypeId, int itemId, int nums, GameFunctionType causeId, string location)
			{
				this.m_owner.OutPutItemOperationLog(itemTypeId, itemId, nums, causeId, location);
			}

			// Token: 0x04002F44 RID: 12100
			private BagComponentCommon m_owner;
		}
	}
}
