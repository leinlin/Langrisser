using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x02000888 RID: 2184
	[HotFix]
	public class BagComponent : BagComponentCommon
	{
		// Token: 0x06006C8A RID: 27786 RVA: 0x001E5C08 File Offset: 0x001E3E08
		public BagComponent()
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

		// Token: 0x06006C8B RID: 27787 RVA: 0x001E5C70 File Offset: 0x001E3E70
		public override void Init()
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
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			base.Init();
		}

		// Token: 0x06006C8C RID: 27788 RVA: 0x001E5CEC File Offset: 0x001E3EEC
		public override void PostInit()
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
			base.PostInit();
		}

		// Token: 0x06006C8D RID: 27789 RVA: 0x001E5D54 File Offset: 0x001E3F54
		public override void DeInit()
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
			base.DeInit();
		}

		// Token: 0x06006C8E RID: 27790 RVA: 0x001E5DBC File Offset: 0x001E3FBC
		public void DeSerialize(DSBagNtf msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeDSBagNtf_hotfix != null)
			{
				this.m_DeSerializeDSBagNtf_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_bagDS.ClearInitedData();
			foreach (ProGoods pbGoods in msg.Bag)
			{
				this.m_bagDS.InitBagItem(BagItemBase.PBGoodsToBagItem(this.m_bagItemFactory, pbGoods));
			}
			this.m_bagDS.InitVersion((ushort)msg.Version, (ushort)msg.Version);
		}

		// Token: 0x06006C8F RID: 27791 RVA: 0x001E5EB0 File Offset: 0x001E40B0
		public void DeSerialize(DSBagExtraNtf msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeDSBagExtraNtf_hotfix != null)
			{
				this.m_DeSerializeDSBagExtraNtf_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (ProGoods pbGoods in msg.Bag)
			{
				this.m_bagDS.InitBagItem(BagItemBase.PBGoodsToBagItem(this.m_bagItemFactory, pbGoods));
			}
		}

		// Token: 0x06006C90 RID: 27792 RVA: 0x001E5F80 File Offset: 0x001E4180
		public ushort GetDSVersion()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDSVersion_hotfix != null)
			{
				return Convert.ToUInt16(this.m_GetDSVersion_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_bagDS.ClientVersion;
		}

		// Token: 0x06006C91 RID: 27793 RVA: 0x001E5FF8 File Offset: 0x001E41F8
		public void ChangeBagItem(ProGoods goods)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ChangeBagItemProGoods_hotfix != null)
			{
				this.m_ChangeBagItemProGoods_hotfix.call(new object[]
				{
					this,
					goods
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GoodsType goodsType = (GoodsType)goods.GoodsType;
			int nums = goods.Nums;
			if (nums <= 0)
			{
				BagItemBase bagItemBase = base.FindBagItem(goodsType, goods.Id, goods.InstanceId);
				if (bagItemBase != null)
				{
					base.RemoveBagItemDirectly(bagItemBase, bagItemBase.Nums, GameFunctionType.GameFunctionType_None, null);
				}
			}
			else if (BagItemBase.IsInstanceBagItem(goodsType))
			{
				this.AddInstanceBagItemDirectly(goods);
			}
			else
			{
				this.AddTypeBagItemDirectly(goodsType, goods.Id, nums);
			}
		}

		// Token: 0x06006C92 RID: 27794 RVA: 0x001E60D4 File Offset: 0x001E42D4
		public bool IsExistBagItemIgnoreInstanceDifference(GoodsType goodsTypeId, int contentId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsExistBagItemIgnoreInstanceDifferenceGoodsTypeInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsExistBagItemIgnoreInstanceDifferenceGoodsTypeInt32_hotfix.call(new object[]
				{
					this,
					goodsTypeId2,
					contentId2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GoodsType goodsTypeId = goodsTypeId2;
			int contentId = contentId2;
			return this.m_bagDS.GetAllBagItems().Find((BagItemBase t) => t.GoodsTypeId == goodsTypeId && t.ContentId == contentId) != null;
		}

		// Token: 0x06006C93 RID: 27795 RVA: 0x001E6198 File Offset: 0x001E4398
		public int GetBagItemNums(GoodsType goodsTypeId, int contentId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetBagItemNumsGoodsTypeInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetBagItemNumsGoodsTypeInt32_hotfix.call(new object[]
				{
					this,
					goodsTypeId2,
					contentId2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GoodsType goodsTypeId = goodsTypeId2;
			int contentId = contentId2;
			if (BagItemBase.IsInstanceBagItem(goodsTypeId))
			{
				return this.m_bagDS.GetAllBagItems().FindAll((BagItemBase t) => t.GoodsTypeId == goodsTypeId && t.ContentId == contentId).Count;
			}
			BagItemBase bagItemBase = base.FindBagItemByType(goodsTypeId, contentId);
			if (bagItemBase == null)
			{
				return 0;
			}
			return bagItemBase.Nums;
		}

		// Token: 0x06006C94 RID: 27796 RVA: 0x001E628C File Offset: 0x001E448C
		public List<ulong> GetInstanceBagItemInstanceIdsByContentId(int contentId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetInstanceBagItemInstanceIdsByContentIdInt32_hotfix != null)
			{
				return (List<ulong>)this.m_GetInstanceBagItemInstanceIdsByContentIdInt32_hotfix.call(new object[]
				{
					this,
					contentId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<ulong> list = new List<ulong>();
			foreach (BagItemBase bagItemBase in this.m_bagDS.GetAllBagItems())
			{
				if (BagItemBase.IsInstanceBagItem(bagItemBase.GoodsTypeId) && bagItemBase.ContentId == contentId)
				{
					list.Add(bagItemBase.InstanceId);
				}
			}
			return list;
		}

		// Token: 0x06006C95 RID: 27797 RVA: 0x001E638C File Offset: 0x001E458C
		public BagItemBase AddInstanceBagItemDirectly(ProGoods goods)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddInstanceBagItemDirectlyProGoods_hotfix != null)
			{
				return (BagItemBase)this.m_AddInstanceBagItemDirectlyProGoods_hotfix.call(new object[]
				{
					this,
					goods
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BagItemBase bagItemBase = this.m_bagItemFactory.CreateInstanceBagItemByClient(goods);
			if (bagItemBase == null)
			{
				return null;
			}
			base.OnCreateBagItemEvent(bagItemBase);
			this.m_bagDS.AddBagItem(bagItemBase);
			return bagItemBase;
		}

		// Token: 0x06006C96 RID: 27798 RVA: 0x001E6434 File Offset: 0x001E4634
		public BagItemBase AddTypeBagItemDirectly(GoodsType goodsTypeId, int contentId, int currentNums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddTypeBagItemDirectlyGoodsTypeInt32Int32_hotfix != null)
			{
				return (BagItemBase)this.m_AddTypeBagItemDirectlyGoodsTypeInt32Int32_hotfix.call(new object[]
				{
					this,
					goodsTypeId,
					contentId,
					currentNums
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BagItemBase bagItemBase = base.FindBagItemByType(goodsTypeId, contentId);
			if (bagItemBase == null)
			{
				bagItemBase = this.m_bagItemFactory.CreateBagItem(goodsTypeId, contentId, currentNums);
				if (bagItemBase == null)
				{
					return null;
				}
				base.OnCreateBagItemEvent(bagItemBase);
				this.m_bagDS.AddBagItem(bagItemBase);
			}
			else
			{
				this.m_bagDS.SetBagItemNums(bagItemBase, currentNums);
			}
			return bagItemBase;
		}

		// Token: 0x06006C97 RID: 27799 RVA: 0x001E6520 File Offset: 0x001E4720
		public int DecomposeBagItems(List<ProGoods> goods)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DecomposeBagItemsList`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_DecomposeBagItemsList`1_hotfix.call(new object[]
				{
					this,
					goods
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = base.CanDecomposeBagItems(goods);
			if (num != 0)
			{
				return num;
			}
			foreach (ProGoods proGoods in goods)
			{
				base.RemoveBagItem((GoodsType)proGoods.GoodsType, proGoods.Id, proGoods.Nums, proGoods.InstanceId, GameFunctionType.GameFunctionType_None, null);
			}
			return 0;
		}

		// Token: 0x06006C98 RID: 27800 RVA: 0x001E6614 File Offset: 0x001E4814
		public int EnchantEquipment(ulong equipmentInstanceId, ulong enchantStoneInstanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EnchantEquipmentUInt64UInt64_hotfix != null)
			{
				return Convert.ToInt32(this.m_EnchantEquipmentUInt64UInt64_hotfix.call(new object[]
				{
					this,
					equipmentInstanceId,
					enchantStoneInstanceId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = base.CanEnchantEquipment(equipmentInstanceId, enchantStoneInstanceId);
			if (num != 0)
			{
				return num;
			}
			BagItemBase bagItemBase = base.FindBagItemByInstanceId(enchantStoneInstanceId);
			ConfigDataEnchantStoneInfo configDataEnchantStoneInfo = this.m_configDataLoader.GetConfigDataEnchantStoneInfo(bagItemBase.ContentId);
			this.m_basicInfo.AddGold(-configDataEnchantStoneInfo.CostGold, GameFunctionType.GameFunctionType_None, null);
			base.RemoveBagItemDirectly(bagItemBase, 1, GameFunctionType.GameFunctionType_None, null);
			return 0;
		}

		// Token: 0x06006C99 RID: 27801 RVA: 0x001E66EC File Offset: 0x001E48EC
		public int GetEquipmentResonanceNums(ulong equipmentInstanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetEquipmentResonanceNumsUInt64_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetEquipmentResonanceNumsUInt64_hotfix.call(new object[]
				{
					this,
					equipmentInstanceId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero wearedEquipmentHero = this.m_hero.GetWearedEquipmentHero(equipmentInstanceId);
			if (wearedEquipmentHero == null)
			{
				return 0;
			}
			return this.GetEquipmentResonanceNumsByHero(equipmentInstanceId, wearedEquipmentHero);
		}

		// Token: 0x06006C9A RID: 27802 RVA: 0x001E6788 File Offset: 0x001E4988
		public int GetEquipmentResonanceNumsByHeroId(ulong equipmentInstanceId, int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetEquipmentResonanceNumsByHeroIdUInt64Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetEquipmentResonanceNumsByHeroIdUInt64Int32_hotfix.call(new object[]
				{
					this,
					equipmentInstanceId,
					heroId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.m_hero.FindHero(heroId);
			if (hero == null)
			{
				return 0;
			}
			return this.GetEquipmentResonanceNumsByHero(equipmentInstanceId, hero);
		}

		// Token: 0x06006C9B RID: 27803 RVA: 0x001E6834 File Offset: 0x001E4A34
		public int CanUseEnergyMedicine(int itemId, int useCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanUseEnergyMedicineInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanUseEnergyMedicineInt32Int32_hotfix.call(new object[]
				{
					this,
					itemId,
					useCount
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (base.IsBagItemEnough(GoodsType.GoodsType_Item, itemId, useCount))
			{
				return 0;
			}
			return -534;
		}

		// Token: 0x06006C9C RID: 27804 RVA: 0x001E68D8 File Offset: 0x001E4AD8
		public bool HasOwn(GoodsType goodsType, int id)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasOwnGoodsTypeInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasOwnGoodsTypeInt32_hotfix.call(new object[]
				{
					this,
					goodsType,
					id
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_resource.HasOwn(goodsType, id);
		}

		// Token: 0x06006C9D RID: 27805 RVA: 0x001E6974 File Offset: 0x001E4B74
		private int GetEquipmentResonanceNumsByHero(ulong equipmentInstanceId, Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetEquipmentResonanceNumsByHeroUInt64Hero_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetEquipmentResonanceNumsByHeroUInt64Hero_hotfix.call(new object[]
				{
					this,
					equipmentInstanceId,
					hero
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			EquipmentBagItem equipmentBagItem = base.FindBagItemByInstanceId(equipmentInstanceId) as EquipmentBagItem;
			if (equipmentBagItem == null)
			{
				return 0;
			}
			if (!equipmentBagItem.IsEnchant())
			{
				return 0;
			}
			int resonanceId = equipmentBagItem.ResonanceId;
			int num = 0;
			foreach (ulong num2 in hero.EquipmentIds)
			{
				if (num2 != 0UL)
				{
					equipmentBagItem = (base.FindBagItemByInstanceId(num2) as EquipmentBagItem);
					if (equipmentBagItem != null)
					{
						if (equipmentBagItem.ResonanceId == resonanceId)
						{
							num++;
						}
					}
				}
			}
			return num;
		}

		// Token: 0x17001B99 RID: 7065
		// (get) Token: 0x06006C9E RID: 27806 RVA: 0x001E6A88 File Offset: 0x001E4C88
		// (set) Token: 0x06006C9F RID: 27807 RVA: 0x001E6AA8 File Offset: 0x001E4CA8
		[DoNotToLua]
		public new BagComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BagComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06006CA0 RID: 27808 RVA: 0x001E6AB4 File Offset: 0x001E4CB4
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x06006CA1 RID: 27809 RVA: 0x001E6ABC File Offset: 0x001E4CBC
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x06006CA2 RID: 27810 RVA: 0x001E6AC4 File Offset: 0x001E4CC4
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x06006CA3 RID: 27811 RVA: 0x001E6ACC File Offset: 0x001E4CCC
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x06006CA4 RID: 27812 RVA: 0x001E6AD4 File Offset: 0x001E4CD4
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x06006CA5 RID: 27813 RVA: 0x001E6AE0 File Offset: 0x001E4CE0
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x06006CA6 RID: 27814 RVA: 0x001E6AE8 File Offset: 0x001E4CE8
		private int __callBase_IsGoodsEnough(List<Goods> conditions, out List<BagItemBase> BagItemsInBag)
		{
			return base.IsGoodsEnough(conditions, out BagItemsInBag);
		}

		// Token: 0x06006CA7 RID: 27815 RVA: 0x001E6AF4 File Offset: 0x001E4CF4
		private void __callBase_ConsumeGoods(List<Goods> needToConsumeGoods, List<BagItemBase> BagItemsInBag, List<BagItemBase> changedGoods, GameFunctionType causeId, string location)
		{
			base.ConsumeGoods(needToConsumeGoods, BagItemsInBag, changedGoods, causeId, location);
		}

		// Token: 0x06006CA8 RID: 27816 RVA: 0x001E6B04 File Offset: 0x001E4D04
		private bool __callBase_IsBagFullByRandomGoods(int addRandomRewardExpectSize, List<Goods> addGoods, List<Goods> deleteGoods)
		{
			return base.IsBagFullByRandomGoods(addRandomRewardExpectSize, addGoods, deleteGoods);
		}

		// Token: 0x06006CA9 RID: 27817 RVA: 0x001E6B10 File Offset: 0x001E4D10
		private bool __callBase_IsBagFullByGoods(List<Goods> addGoods, List<Goods> deleteGoods)
		{
			return base.IsBagFullByGoods(addGoods, deleteGoods);
		}

		// Token: 0x06006CAA RID: 27818 RVA: 0x001E6B1C File Offset: 0x001E4D1C
		private bool __callBase_IsBagFull(int expectSize)
		{
			return base.IsBagFull(expectSize);
		}

		// Token: 0x06006CAB RID: 27819 RVA: 0x001E6B28 File Offset: 0x001E4D28
		private int __callBase_GetBagSize()
		{
			return base.GetBagSize();
		}

		// Token: 0x06006CAC RID: 27820 RVA: 0x001E6B30 File Offset: 0x001E4D30
		private bool __callBase_IsBagFullByCurrentSize()
		{
			return base.IsBagFullByCurrentSize();
		}

		// Token: 0x06006CAD RID: 27821 RVA: 0x001E6B38 File Offset: 0x001E4D38
		private List<Goods> __callBase_TransformHeroGoods(int heroId, int nums)
		{
			return base.TransformHeroGoods(heroId, nums);
		}

		// Token: 0x06006CAE RID: 27822 RVA: 0x001E6B44 File Offset: 0x001E4D44
		private int __callBase_IsBagItemContentIdInConfig(GoodsType goodsTypeId, int contentId)
		{
			return base.IsBagItemContentIdInConfig(goodsTypeId, contentId);
		}

		// Token: 0x06006CAF RID: 27823 RVA: 0x001E6B50 File Offset: 0x001E4D50
		private void __callBase_RemoveAllBagItems(List<BagItemBase> changedBagItems, int removeItemMaxNums)
		{
			base.RemoveAllBagItems(changedBagItems, removeItemMaxNums);
		}

		// Token: 0x06006CB0 RID: 27824 RVA: 0x001E6B5C File Offset: 0x001E4D5C
		private int __callBase_RemoveBagItem(GoodsType goodsTypeId, int contentId, int consumeNums, ulong instanceId, GameFunctionType caseId, string location)
		{
			return base.RemoveBagItem(goodsTypeId, contentId, consumeNums, instanceId, caseId, location);
		}

		// Token: 0x06006CB1 RID: 27825 RVA: 0x001E6B70 File Offset: 0x001E4D70
		private int __callBase_RemoveBagItemByType(GoodsType goodsTypeId, int contentId, int consumeNums, GameFunctionType caseId, string location)
		{
			return base.RemoveBagItemByType(goodsTypeId, contentId, consumeNums, caseId, location);
		}

		// Token: 0x06006CB2 RID: 27826 RVA: 0x001E6B80 File Offset: 0x001E4D80
		private int __callBase_RemoveBagItemByInstanceId(ulong instanceId, GameFunctionType caseId, string location)
		{
			return base.RemoveBagItemByInstanceId(instanceId, caseId, location);
		}

		// Token: 0x06006CB3 RID: 27827 RVA: 0x001E6B8C File Offset: 0x001E4D8C
		private BagItemBase __callBase_RemoveBagItemDirectly(BagItemBase bagItem, int consumeNums, GameFunctionType caseId, string location)
		{
			return base.RemoveBagItemDirectly(bagItem, consumeNums, caseId, location);
		}

		// Token: 0x06006CB4 RID: 27828 RVA: 0x001E6B9C File Offset: 0x001E4D9C
		private BagItemBase __callBase_FindBagItem(GoodsType goodsTypeId, int contentId, ulong instanceId)
		{
			return base.FindBagItem(goodsTypeId, contentId, instanceId);
		}

		// Token: 0x06006CB5 RID: 27829 RVA: 0x001E6BA8 File Offset: 0x001E4DA8
		private BagItemBase __callBase_FindBagItemByInstanceId(ulong instanceId)
		{
			return base.FindBagItemByInstanceId(instanceId);
		}

		// Token: 0x06006CB6 RID: 27830 RVA: 0x001E6BB4 File Offset: 0x001E4DB4
		private BagItemBase __callBase_FindBagItemByType(GoodsType goodsTypeId, int contentId)
		{
			return base.FindBagItemByType(goodsTypeId, contentId);
		}

		// Token: 0x06006CB7 RID: 27831 RVA: 0x001E6BC0 File Offset: 0x001E4DC0
		private UseableBagItem __callBase_FindUseableBagItem(GoodsType goodsTypeId, int contentId)
		{
			return base.FindUseableBagItem(goodsTypeId, contentId);
		}

		// Token: 0x06006CB8 RID: 27832 RVA: 0x001E6BCC File Offset: 0x001E4DCC
		private List<BagItemBase> __callBase_GetAllBagItems()
		{
			return base.GetAllBagItems();
		}

		// Token: 0x06006CB9 RID: 27833 RVA: 0x001E6BD4 File Offset: 0x001E4DD4
		private IEnumerable<BagItemBase> __callBase_IterateAllBagItems()
		{
			return base.IterateAllBagItems();
		}

		// Token: 0x06006CBA RID: 27834 RVA: 0x001E6BDC File Offset: 0x001E4DDC
		private List<BagItemBase> __callBase_FindEnoughBagItems(List<Goods> conditions)
		{
			return base.FindEnoughBagItems(conditions);
		}

		// Token: 0x06006CBB RID: 27835 RVA: 0x001E6BE8 File Offset: 0x001E4DE8
		private int __callBase_UseBagItem(GoodsType goodsTypeId, int contentId, int consumeNums, object[] param)
		{
			return base.UseBagItem(goodsTypeId, contentId, consumeNums, param);
		}

		// Token: 0x06006CBC RID: 27836 RVA: 0x001E6BF8 File Offset: 0x001E4DF8
		private int __callBase_UseBagItem(UseableBagItem useableBagItem, int consumeNums, object[] param)
		{
			return base.UseBagItem(useableBagItem, consumeNums, param);
		}

		// Token: 0x06006CBD RID: 27837 RVA: 0x001E6C04 File Offset: 0x001E4E04
		private int __callBase_UseBagItemDirectly(UseableBagItem useableBagItem, int consumeNums, object[] param)
		{
			return base.UseBagItemDirectly(useableBagItem, consumeNums, param);
		}

		// Token: 0x06006CBE RID: 27838 RVA: 0x001E6C10 File Offset: 0x001E4E10
		private int __callBase_HasEnoughBagItem(BagItemBase bagItem, int consumeNums)
		{
			return base.HasEnoughBagItem(bagItem, consumeNums);
		}

		// Token: 0x06006CBF RID: 27839 RVA: 0x001E6C1C File Offset: 0x001E4E1C
		private bool __callBase_IsBagItemEnough(BagItemBase bagItem, int consumeNums)
		{
			return base.IsBagItemEnough(bagItem, consumeNums);
		}

		// Token: 0x06006CC0 RID: 27840 RVA: 0x001E6C28 File Offset: 0x001E4E28
		private bool __callBase_IsBagItemEnough(GoodsType bagItemType, int bagItemId, int nums)
		{
			return base.IsBagItemEnough(bagItemType, bagItemId, nums);
		}

		// Token: 0x06006CC1 RID: 27841 RVA: 0x001E6C34 File Offset: 0x001E4E34
		private int __callBase_GetTicketId(GameFunctionType causeId)
		{
			return base.GetTicketId(causeId);
		}

		// Token: 0x06006CC2 RID: 27842 RVA: 0x001E6C40 File Offset: 0x001E4E40
		private bool __callBase_IsLevelTicketsMaxByUI(GameFunctionType causeId, GoodsType goodTypeId, int contentId, int nums)
		{
			return base.IsLevelTicketsMaxByUI(causeId, goodTypeId, contentId, nums);
		}

		// Token: 0x06006CC3 RID: 27843 RVA: 0x001E6C50 File Offset: 0x001E4E50
		private int __callBase_SellBagItem(ulong instanceId, int nums)
		{
			return base.SellBagItem(instanceId, nums);
		}

		// Token: 0x06006CC4 RID: 27844 RVA: 0x001E6C5C File Offset: 0x001E4E5C
		private void __callBase_CombineSameGoodsAndReplaceExistHeroToFragment(List<Goods> goodsList)
		{
			base.CombineSameGoodsAndReplaceExistHeroToFragment(goodsList);
		}

		// Token: 0x06006CC5 RID: 27845 RVA: 0x001E6C68 File Offset: 0x001E4E68
		private int __callBase_CanDecomposeBagItems(List<ProGoods> goods)
		{
			return base.CanDecomposeBagItems(goods);
		}

		// Token: 0x06006CC6 RID: 27846 RVA: 0x001E6C74 File Offset: 0x001E4E74
		private int __callBase_CanDecomposeABagItem(GoodsType goodsTypeId, int contentId, int nums, ulong instanceId)
		{
			return base.CanDecomposeABagItem(goodsTypeId, contentId, nums, instanceId);
		}

		// Token: 0x06006CC7 RID: 27847 RVA: 0x001E6C84 File Offset: 0x001E4E84
		private void __callBase_SetBagItemDirty(BagItemBase bagItem)
		{
			base.SetBagItemDirty(bagItem);
		}

		// Token: 0x06006CC8 RID: 27848 RVA: 0x001E6C90 File Offset: 0x001E4E90
		private bool __callBase_IsPercentBaseBattleProperty(PropertyModifyType id)
		{
			return base.IsPercentBaseBattleProperty(id);
		}

		// Token: 0x06006CC9 RID: 27849 RVA: 0x001E6C9C File Offset: 0x001E4E9C
		private int __callBase_CanLockAndUnLockEquipment(ulong instanceId)
		{
			return base.CanLockAndUnLockEquipment(instanceId);
		}

		// Token: 0x06006CCA RID: 27850 RVA: 0x001E6CA8 File Offset: 0x001E4EA8
		private int __callBase_LockAndUnLockEquipment(ulong instanceId)
		{
			return base.LockAndUnLockEquipment(instanceId);
		}

		// Token: 0x06006CCB RID: 27851 RVA: 0x001E6CB4 File Offset: 0x001E4EB4
		private int __callBase_CanEnhanceEquipment(ulong instanceId, List<ulong> materialIds)
		{
			return base.CanEnhanceEquipment(instanceId, materialIds);
		}

		// Token: 0x06006CCC RID: 27852 RVA: 0x001E6CC0 File Offset: 0x001E4EC0
		private bool __callBase_CanWearEquipmentByEquipmentType(BagItemBase equipment)
		{
			return base.CanWearEquipmentByEquipmentType(equipment);
		}

		// Token: 0x06006CCD RID: 27853 RVA: 0x001E6CCC File Offset: 0x001E4ECC
		private int __callBase_CalculateEnhanceEquipmentExp(List<BagItemBase> materials)
		{
			return base.CalculateEnhanceEquipmentExp(materials);
		}

		// Token: 0x06006CCE RID: 27854 RVA: 0x001E6CD8 File Offset: 0x001E4ED8
		private int __callBase_CalculateEnhanceEquipmentGold(int exp)
		{
			return base.CalculateEnhanceEquipmentGold(exp);
		}

		// Token: 0x06006CCF RID: 27855 RVA: 0x001E6CE4 File Offset: 0x001E4EE4
		private int __callBase_EnhanceEquipment(ulong instanceId, List<ulong> materialIds)
		{
			return base.EnhanceEquipment(instanceId, materialIds);
		}

		// Token: 0x06006CD0 RID: 27856 RVA: 0x001E6CF0 File Offset: 0x001E4EF0
		private int __callBase_CanEnchantEquipment(ulong equipmentInstanceId, ulong enchantStoneInstanceId)
		{
			return base.CanEnchantEquipment(equipmentInstanceId, enchantStoneInstanceId);
		}

		// Token: 0x06006CD1 RID: 27857 RVA: 0x001E6CFC File Offset: 0x001E4EFC
		private void __callBase_OutPutEqipmentEnhanceOperateLog(EquipmentBagItem equipment, int preLevel, int preExp, List<Goods> costItems)
		{
			base.OutPutEqipmentEnhanceOperateLog(equipment, preLevel, preExp, costItems);
		}

		// Token: 0x06006CD2 RID: 27858 RVA: 0x001E6D0C File Offset: 0x001E4F0C
		private void __callBase_OutPutEquipmentUpgrageOperateLog(EquipmentBagItem equipment, EquipmentBagItem material, int preLvlLimit, int postLvlLimit, List<Goods> costItems)
		{
			base.OutPutEquipmentUpgrageOperateLog(equipment, material, preLvlLimit, postLvlLimit, costItems);
		}

		// Token: 0x06006CD3 RID: 27859 RVA: 0x001E6D1C File Offset: 0x001E4F1C
		private void __callBase_LevelUpEquipment(EquipmentBagItem equipment)
		{
			base.LevelUpEquipment(equipment);
		}

		// Token: 0x06006CD4 RID: 27860 RVA: 0x001E6D28 File Offset: 0x001E4F28
		private int __callBase_CaculateEquipmentNextLevelExp(int equipmentContentId, int equipmentLevel)
		{
			return base.CaculateEquipmentNextLevelExp(equipmentContentId, equipmentLevel);
		}

		// Token: 0x06006CD5 RID: 27861 RVA: 0x001E6D34 File Offset: 0x001E4F34
		private int __callBase_CanLevelUpEquipmentStar(ulong instanceId, ulong materialId)
		{
			return base.CanLevelUpEquipmentStar(instanceId, materialId);
		}

		// Token: 0x06006CD6 RID: 27862 RVA: 0x001E6D40 File Offset: 0x001E4F40
		private int __callBase_CalculateLevelUpEquipmentStarGold(EquipmentBagItem equipment)
		{
			return base.CalculateLevelUpEquipmentStarGold(equipment);
		}

		// Token: 0x06006CD7 RID: 27863 RVA: 0x001E6D4C File Offset: 0x001E4F4C
		private int __callBase_LevelUpEquipmentStar(ulong instanceId, ulong materialId)
		{
			return base.LevelUpEquipmentStar(instanceId, materialId);
		}

		// Token: 0x06006CD8 RID: 27864 RVA: 0x001E6D58 File Offset: 0x001E4F58
		private int __callBase_CalculateEquipmentTotalExp(EquipmentBagItem equipment)
		{
			return base.CalculateEquipmentTotalExp(equipment);
		}

		// Token: 0x06006CD9 RID: 27865 RVA: 0x001E6D64 File Offset: 0x001E4F64
		private int __callBase_CalculateDecomposeEquipmentBackGold(EquipmentBagItem equipment)
		{
			return base.CalculateDecomposeEquipmentBackGold(equipment);
		}

		// Token: 0x06006CDA RID: 27866 RVA: 0x001E6D70 File Offset: 0x001E4F70
		private void __callBase_OutPutItemOperationLog(GoodsType itemTypeId, int itemId, int nums, GameFunctionType causeId, string location)
		{
			base.OutPutItemOperationLog(itemTypeId, itemId, nums, causeId, location);
		}

		// Token: 0x06006CDB RID: 27867 RVA: 0x001E6D80 File Offset: 0x001E4F80
		private void __callBase_OnSaveEnchantSaveMissionEvent(EquipmentBagItem equipment)
		{
			base.OnSaveEnchantSaveMissionEvent(equipment);
		}

		// Token: 0x06006CDC RID: 27868 RVA: 0x001E6D8C File Offset: 0x001E4F8C
		private void __callBase_OnEnchantMissionEvent(EquipmentBagItem equipment)
		{
			base.OnEnchantMissionEvent(equipment);
		}

		// Token: 0x06006CDD RID: 27869 RVA: 0x001E6D98 File Offset: 0x001E4F98
		private void __callBase_OnCreateBagItemEvent(BagItemBase bagItem)
		{
			base.OnCreateBagItemEvent(bagItem);
		}

		// Token: 0x06006CDE RID: 27870 RVA: 0x001E6DA4 File Offset: 0x001E4FA4
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
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_PostInit_hotfix = (luaObj.RawGet("PostInit") as LuaFunction);
					this.m_DeInit_hotfix = (luaObj.RawGet("DeInit") as LuaFunction);
					this.m_DeSerializeDSBagNtf_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_DeSerializeDSBagExtraNtf_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_GetDSVersion_hotfix = (luaObj.RawGet("GetDSVersion") as LuaFunction);
					this.m_ChangeBagItemProGoods_hotfix = (luaObj.RawGet("ChangeBagItem") as LuaFunction);
					this.m_IsExistBagItemIgnoreInstanceDifferenceGoodsTypeInt32_hotfix = (luaObj.RawGet("IsExistBagItemIgnoreInstanceDifference") as LuaFunction);
					this.m_GetBagItemNumsGoodsTypeInt32_hotfix = (luaObj.RawGet("GetBagItemNums") as LuaFunction);
					this.m_GetInstanceBagItemInstanceIdsByContentIdInt32_hotfix = (luaObj.RawGet("GetInstanceBagItemInstanceIdsByContentId") as LuaFunction);
					this.m_AddInstanceBagItemDirectlyProGoods_hotfix = (luaObj.RawGet("AddInstanceBagItemDirectly") as LuaFunction);
					this.m_AddTypeBagItemDirectlyGoodsTypeInt32Int32_hotfix = (luaObj.RawGet("AddTypeBagItemDirectly") as LuaFunction);
					this.m_DecomposeBagItemsList`1_hotfix = (luaObj.RawGet("DecomposeBagItems") as LuaFunction);
					this.m_EnchantEquipmentUInt64UInt64_hotfix = (luaObj.RawGet("EnchantEquipment") as LuaFunction);
					this.m_GetEquipmentResonanceNumsUInt64_hotfix = (luaObj.RawGet("GetEquipmentResonanceNums") as LuaFunction);
					this.m_GetEquipmentResonanceNumsByHeroIdUInt64Int32_hotfix = (luaObj.RawGet("GetEquipmentResonanceNumsByHeroId") as LuaFunction);
					this.m_CanUseEnergyMedicineInt32Int32_hotfix = (luaObj.RawGet("CanUseEnergyMedicine") as LuaFunction);
					this.m_HasOwnGoodsTypeInt32_hotfix = (luaObj.RawGet("HasOwn") as LuaFunction);
					this.m_GetEquipmentResonanceNumsByHeroUInt64Hero_hotfix = (luaObj.RawGet("GetEquipmentResonanceNumsByHero") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06006CDF RID: 27871 RVA: 0x001E704C File Offset: 0x001E524C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BagComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005328 RID: 21288
		[DoNotToLua]
		private BagComponent.LuaExportHelper luaExportHelper;

		// Token: 0x04005329 RID: 21289
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400532A RID: 21290
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400532B RID: 21291
		private LuaFunction m_ctor_hotfix;

		// Token: 0x0400532C RID: 21292
		private LuaFunction m_Init_hotfix;

		// Token: 0x0400532D RID: 21293
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x0400532E RID: 21294
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x0400532F RID: 21295
		private LuaFunction m_DeSerializeDSBagNtf_hotfix;

		// Token: 0x04005330 RID: 21296
		private LuaFunction m_DeSerializeDSBagExtraNtf_hotfix;

		// Token: 0x04005331 RID: 21297
		private LuaFunction m_GetDSVersion_hotfix;

		// Token: 0x04005332 RID: 21298
		private LuaFunction m_ChangeBagItemProGoods_hotfix;

		// Token: 0x04005333 RID: 21299
		private LuaFunction m_IsExistBagItemIgnoreInstanceDifferenceGoodsTypeInt32_hotfix;

		// Token: 0x04005334 RID: 21300
		private LuaFunction m_GetBagItemNumsGoodsTypeInt32_hotfix;

		// Token: 0x04005335 RID: 21301
		private LuaFunction m_GetInstanceBagItemInstanceIdsByContentIdInt32_hotfix;

		// Token: 0x04005336 RID: 21302
		private LuaFunction m_AddInstanceBagItemDirectlyProGoods_hotfix;

		// Token: 0x04005337 RID: 21303
		private LuaFunction m_AddTypeBagItemDirectlyGoodsTypeInt32Int32_hotfix;

		// Token: 0x04005338 RID: 21304
		private LuaFunction m_DecomposeBagItemsList;

		// Token: 0x04005339 RID: 21305
		private LuaFunction m_EnchantEquipmentUInt64UInt64_hotfix;

		// Token: 0x0400533A RID: 21306
		private LuaFunction m_GetEquipmentResonanceNumsUInt64_hotfix;

		// Token: 0x0400533B RID: 21307
		private LuaFunction m_GetEquipmentResonanceNumsByHeroIdUInt64Int32_hotfix;

		// Token: 0x0400533C RID: 21308
		private LuaFunction m_CanUseEnergyMedicineInt32Int32_hotfix;

		// Token: 0x0400533D RID: 21309
		private LuaFunction m_HasOwnGoodsTypeInt32_hotfix;

		// Token: 0x0400533E RID: 21310
		private LuaFunction m_GetEquipmentResonanceNumsByHeroUInt64Hero_hotfix;

		// Token: 0x02000889 RID: 2185
		public new class LuaExportHelper
		{
			// Token: 0x06006CE0 RID: 27872 RVA: 0x001E70B4 File Offset: 0x001E52B4
			public LuaExportHelper(BagComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06006CE1 RID: 27873 RVA: 0x001E70C4 File Offset: 0x001E52C4
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x06006CE2 RID: 27874 RVA: 0x001E70D4 File Offset: 0x001E52D4
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x06006CE3 RID: 27875 RVA: 0x001E70E4 File Offset: 0x001E52E4
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x06006CE4 RID: 27876 RVA: 0x001E70F4 File Offset: 0x001E52F4
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x06006CE5 RID: 27877 RVA: 0x001E7104 File Offset: 0x001E5304
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x06006CE6 RID: 27878 RVA: 0x001E7114 File Offset: 0x001E5314
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x06006CE7 RID: 27879 RVA: 0x001E7124 File Offset: 0x001E5324
			public int __callBase_IsGoodsEnough(List<Goods> conditions, out List<BagItemBase> BagItemsInBag)
			{
				return this.m_owner.__callBase_IsGoodsEnough(conditions, out BagItemsInBag);
			}

			// Token: 0x06006CE8 RID: 27880 RVA: 0x001E7134 File Offset: 0x001E5334
			public void __callBase_ConsumeGoods(List<Goods> needToConsumeGoods, List<BagItemBase> BagItemsInBag, List<BagItemBase> changedGoods, GameFunctionType causeId, string location)
			{
				this.m_owner.__callBase_ConsumeGoods(needToConsumeGoods, BagItemsInBag, changedGoods, causeId, location);
			}

			// Token: 0x06006CE9 RID: 27881 RVA: 0x001E7148 File Offset: 0x001E5348
			public bool __callBase_IsBagFullByRandomGoods(int addRandomRewardExpectSize, List<Goods> addGoods, List<Goods> deleteGoods)
			{
				return this.m_owner.__callBase_IsBagFullByRandomGoods(addRandomRewardExpectSize, addGoods, deleteGoods);
			}

			// Token: 0x06006CEA RID: 27882 RVA: 0x001E7158 File Offset: 0x001E5358
			public bool __callBase_IsBagFullByGoods(List<Goods> addGoods, List<Goods> deleteGoods)
			{
				return this.m_owner.__callBase_IsBagFullByGoods(addGoods, deleteGoods);
			}

			// Token: 0x06006CEB RID: 27883 RVA: 0x001E7168 File Offset: 0x001E5368
			public bool __callBase_IsBagFull(int expectSize)
			{
				return this.m_owner.__callBase_IsBagFull(expectSize);
			}

			// Token: 0x06006CEC RID: 27884 RVA: 0x001E7178 File Offset: 0x001E5378
			public int __callBase_GetBagSize()
			{
				return this.m_owner.__callBase_GetBagSize();
			}

			// Token: 0x06006CED RID: 27885 RVA: 0x001E7188 File Offset: 0x001E5388
			public bool __callBase_IsBagFullByCurrentSize()
			{
				return this.m_owner.__callBase_IsBagFullByCurrentSize();
			}

			// Token: 0x06006CEE RID: 27886 RVA: 0x001E7198 File Offset: 0x001E5398
			public List<Goods> __callBase_TransformHeroGoods(int heroId, int nums)
			{
				return this.m_owner.__callBase_TransformHeroGoods(heroId, nums);
			}

			// Token: 0x06006CEF RID: 27887 RVA: 0x001E71A8 File Offset: 0x001E53A8
			public int __callBase_IsBagItemContentIdInConfig(GoodsType goodsTypeId, int contentId)
			{
				return this.m_owner.__callBase_IsBagItemContentIdInConfig(goodsTypeId, contentId);
			}

			// Token: 0x06006CF0 RID: 27888 RVA: 0x001E71B8 File Offset: 0x001E53B8
			public void __callBase_RemoveAllBagItems(List<BagItemBase> changedBagItems, int removeItemMaxNums)
			{
				this.m_owner.__callBase_RemoveAllBagItems(changedBagItems, removeItemMaxNums);
			}

			// Token: 0x06006CF1 RID: 27889 RVA: 0x001E71C8 File Offset: 0x001E53C8
			public int __callBase_RemoveBagItem(GoodsType goodsTypeId, int contentId, int consumeNums, ulong instanceId, GameFunctionType caseId, string location)
			{
				return this.m_owner.__callBase_RemoveBagItem(goodsTypeId, contentId, consumeNums, instanceId, caseId, location);
			}

			// Token: 0x06006CF2 RID: 27890 RVA: 0x001E71E0 File Offset: 0x001E53E0
			public int __callBase_RemoveBagItemByType(GoodsType goodsTypeId, int contentId, int consumeNums, GameFunctionType caseId, string location)
			{
				return this.m_owner.__callBase_RemoveBagItemByType(goodsTypeId, contentId, consumeNums, caseId, location);
			}

			// Token: 0x06006CF3 RID: 27891 RVA: 0x001E71F4 File Offset: 0x001E53F4
			public int __callBase_RemoveBagItemByInstanceId(ulong instanceId, GameFunctionType caseId, string location)
			{
				return this.m_owner.__callBase_RemoveBagItemByInstanceId(instanceId, caseId, location);
			}

			// Token: 0x06006CF4 RID: 27892 RVA: 0x001E7204 File Offset: 0x001E5404
			public BagItemBase __callBase_RemoveBagItemDirectly(BagItemBase bagItem, int consumeNums, GameFunctionType caseId, string location)
			{
				return this.m_owner.__callBase_RemoveBagItemDirectly(bagItem, consumeNums, caseId, location);
			}

			// Token: 0x06006CF5 RID: 27893 RVA: 0x001E7218 File Offset: 0x001E5418
			public BagItemBase __callBase_FindBagItem(GoodsType goodsTypeId, int contentId, ulong instanceId)
			{
				return this.m_owner.__callBase_FindBagItem(goodsTypeId, contentId, instanceId);
			}

			// Token: 0x06006CF6 RID: 27894 RVA: 0x001E7228 File Offset: 0x001E5428
			public BagItemBase __callBase_FindBagItemByInstanceId(ulong instanceId)
			{
				return this.m_owner.__callBase_FindBagItemByInstanceId(instanceId);
			}

			// Token: 0x06006CF7 RID: 27895 RVA: 0x001E7238 File Offset: 0x001E5438
			public BagItemBase __callBase_FindBagItemByType(GoodsType goodsTypeId, int contentId)
			{
				return this.m_owner.__callBase_FindBagItemByType(goodsTypeId, contentId);
			}

			// Token: 0x06006CF8 RID: 27896 RVA: 0x001E7248 File Offset: 0x001E5448
			public UseableBagItem __callBase_FindUseableBagItem(GoodsType goodsTypeId, int contentId)
			{
				return this.m_owner.__callBase_FindUseableBagItem(goodsTypeId, contentId);
			}

			// Token: 0x06006CF9 RID: 27897 RVA: 0x001E7258 File Offset: 0x001E5458
			public List<BagItemBase> __callBase_GetAllBagItems()
			{
				return this.m_owner.__callBase_GetAllBagItems();
			}

			// Token: 0x06006CFA RID: 27898 RVA: 0x001E7268 File Offset: 0x001E5468
			public IEnumerable<BagItemBase> __callBase_IterateAllBagItems()
			{
				return this.m_owner.__callBase_IterateAllBagItems();
			}

			// Token: 0x06006CFB RID: 27899 RVA: 0x001E7278 File Offset: 0x001E5478
			public List<BagItemBase> __callBase_FindEnoughBagItems(List<Goods> conditions)
			{
				return this.m_owner.__callBase_FindEnoughBagItems(conditions);
			}

			// Token: 0x06006CFC RID: 27900 RVA: 0x001E7288 File Offset: 0x001E5488
			public int __callBase_UseBagItem(GoodsType goodsTypeId, int contentId, int consumeNums, object[] param)
			{
				return this.m_owner.__callBase_UseBagItem(goodsTypeId, contentId, consumeNums, param);
			}

			// Token: 0x06006CFD RID: 27901 RVA: 0x001E729C File Offset: 0x001E549C
			public int __callBase_UseBagItem(UseableBagItem useableBagItem, int consumeNums, object[] param)
			{
				return this.m_owner.__callBase_UseBagItem(useableBagItem, consumeNums, param);
			}

			// Token: 0x06006CFE RID: 27902 RVA: 0x001E72AC File Offset: 0x001E54AC
			public int __callBase_UseBagItemDirectly(UseableBagItem useableBagItem, int consumeNums, object[] param)
			{
				return this.m_owner.__callBase_UseBagItemDirectly(useableBagItem, consumeNums, param);
			}

			// Token: 0x06006CFF RID: 27903 RVA: 0x001E72BC File Offset: 0x001E54BC
			public int __callBase_HasEnoughBagItem(BagItemBase bagItem, int consumeNums)
			{
				return this.m_owner.__callBase_HasEnoughBagItem(bagItem, consumeNums);
			}

			// Token: 0x06006D00 RID: 27904 RVA: 0x001E72CC File Offset: 0x001E54CC
			public bool __callBase_IsBagItemEnough(BagItemBase bagItem, int consumeNums)
			{
				return this.m_owner.__callBase_IsBagItemEnough(bagItem, consumeNums);
			}

			// Token: 0x06006D01 RID: 27905 RVA: 0x001E72DC File Offset: 0x001E54DC
			public bool __callBase_IsBagItemEnough(GoodsType bagItemType, int bagItemId, int nums)
			{
				return this.m_owner.__callBase_IsBagItemEnough(bagItemType, bagItemId, nums);
			}

			// Token: 0x06006D02 RID: 27906 RVA: 0x001E72EC File Offset: 0x001E54EC
			public int __callBase_GetTicketId(GameFunctionType causeId)
			{
				return this.m_owner.__callBase_GetTicketId(causeId);
			}

			// Token: 0x06006D03 RID: 27907 RVA: 0x001E72FC File Offset: 0x001E54FC
			public bool __callBase_IsLevelTicketsMaxByUI(GameFunctionType causeId, GoodsType goodTypeId, int contentId, int nums)
			{
				return this.m_owner.__callBase_IsLevelTicketsMaxByUI(causeId, goodTypeId, contentId, nums);
			}

			// Token: 0x06006D04 RID: 27908 RVA: 0x001E7310 File Offset: 0x001E5510
			public int __callBase_SellBagItem(ulong instanceId, int nums)
			{
				return this.m_owner.__callBase_SellBagItem(instanceId, nums);
			}

			// Token: 0x06006D05 RID: 27909 RVA: 0x001E7320 File Offset: 0x001E5520
			public void __callBase_CombineSameGoodsAndReplaceExistHeroToFragment(List<Goods> goodsList)
			{
				this.m_owner.__callBase_CombineSameGoodsAndReplaceExistHeroToFragment(goodsList);
			}

			// Token: 0x06006D06 RID: 27910 RVA: 0x001E7330 File Offset: 0x001E5530
			public int __callBase_CanDecomposeBagItems(List<ProGoods> goods)
			{
				return this.m_owner.__callBase_CanDecomposeBagItems(goods);
			}

			// Token: 0x06006D07 RID: 27911 RVA: 0x001E7340 File Offset: 0x001E5540
			public int __callBase_CanDecomposeABagItem(GoodsType goodsTypeId, int contentId, int nums, ulong instanceId)
			{
				return this.m_owner.__callBase_CanDecomposeABagItem(goodsTypeId, contentId, nums, instanceId);
			}

			// Token: 0x06006D08 RID: 27912 RVA: 0x001E7354 File Offset: 0x001E5554
			public void __callBase_SetBagItemDirty(BagItemBase bagItem)
			{
				this.m_owner.__callBase_SetBagItemDirty(bagItem);
			}

			// Token: 0x06006D09 RID: 27913 RVA: 0x001E7364 File Offset: 0x001E5564
			public bool __callBase_IsPercentBaseBattleProperty(PropertyModifyType id)
			{
				return this.m_owner.__callBase_IsPercentBaseBattleProperty(id);
			}

			// Token: 0x06006D0A RID: 27914 RVA: 0x001E7374 File Offset: 0x001E5574
			public int __callBase_CanLockAndUnLockEquipment(ulong instanceId)
			{
				return this.m_owner.__callBase_CanLockAndUnLockEquipment(instanceId);
			}

			// Token: 0x06006D0B RID: 27915 RVA: 0x001E7384 File Offset: 0x001E5584
			public int __callBase_LockAndUnLockEquipment(ulong instanceId)
			{
				return this.m_owner.__callBase_LockAndUnLockEquipment(instanceId);
			}

			// Token: 0x06006D0C RID: 27916 RVA: 0x001E7394 File Offset: 0x001E5594
			public int __callBase_CanEnhanceEquipment(ulong instanceId, List<ulong> materialIds)
			{
				return this.m_owner.__callBase_CanEnhanceEquipment(instanceId, materialIds);
			}

			// Token: 0x06006D0D RID: 27917 RVA: 0x001E73A4 File Offset: 0x001E55A4
			public bool __callBase_CanWearEquipmentByEquipmentType(BagItemBase equipment)
			{
				return this.m_owner.__callBase_CanWearEquipmentByEquipmentType(equipment);
			}

			// Token: 0x06006D0E RID: 27918 RVA: 0x001E73B4 File Offset: 0x001E55B4
			public int __callBase_CalculateEnhanceEquipmentExp(List<BagItemBase> materials)
			{
				return this.m_owner.__callBase_CalculateEnhanceEquipmentExp(materials);
			}

			// Token: 0x06006D0F RID: 27919 RVA: 0x001E73C4 File Offset: 0x001E55C4
			public int __callBase_CalculateEnhanceEquipmentGold(int exp)
			{
				return this.m_owner.__callBase_CalculateEnhanceEquipmentGold(exp);
			}

			// Token: 0x06006D10 RID: 27920 RVA: 0x001E73D4 File Offset: 0x001E55D4
			public int __callBase_EnhanceEquipment(ulong instanceId, List<ulong> materialIds)
			{
				return this.m_owner.__callBase_EnhanceEquipment(instanceId, materialIds);
			}

			// Token: 0x06006D11 RID: 27921 RVA: 0x001E73E4 File Offset: 0x001E55E4
			public int __callBase_CanEnchantEquipment(ulong equipmentInstanceId, ulong enchantStoneInstanceId)
			{
				return this.m_owner.__callBase_CanEnchantEquipment(equipmentInstanceId, enchantStoneInstanceId);
			}

			// Token: 0x06006D12 RID: 27922 RVA: 0x001E73F4 File Offset: 0x001E55F4
			public void __callBase_OutPutEqipmentEnhanceOperateLog(EquipmentBagItem equipment, int preLevel, int preExp, List<Goods> costItems)
			{
				this.m_owner.__callBase_OutPutEqipmentEnhanceOperateLog(equipment, preLevel, preExp, costItems);
			}

			// Token: 0x06006D13 RID: 27923 RVA: 0x001E7408 File Offset: 0x001E5608
			public void __callBase_OutPutEquipmentUpgrageOperateLog(EquipmentBagItem equipment, EquipmentBagItem material, int preLvlLimit, int postLvlLimit, List<Goods> costItems)
			{
				this.m_owner.__callBase_OutPutEquipmentUpgrageOperateLog(equipment, material, preLvlLimit, postLvlLimit, costItems);
			}

			// Token: 0x06006D14 RID: 27924 RVA: 0x001E741C File Offset: 0x001E561C
			public void __callBase_LevelUpEquipment(EquipmentBagItem equipment)
			{
				this.m_owner.__callBase_LevelUpEquipment(equipment);
			}

			// Token: 0x06006D15 RID: 27925 RVA: 0x001E742C File Offset: 0x001E562C
			public int __callBase_CaculateEquipmentNextLevelExp(int equipmentContentId, int equipmentLevel)
			{
				return this.m_owner.__callBase_CaculateEquipmentNextLevelExp(equipmentContentId, equipmentLevel);
			}

			// Token: 0x06006D16 RID: 27926 RVA: 0x001E743C File Offset: 0x001E563C
			public int __callBase_CanLevelUpEquipmentStar(ulong instanceId, ulong materialId)
			{
				return this.m_owner.__callBase_CanLevelUpEquipmentStar(instanceId, materialId);
			}

			// Token: 0x06006D17 RID: 27927 RVA: 0x001E744C File Offset: 0x001E564C
			public int __callBase_CalculateLevelUpEquipmentStarGold(EquipmentBagItem equipment)
			{
				return this.m_owner.__callBase_CalculateLevelUpEquipmentStarGold(equipment);
			}

			// Token: 0x06006D18 RID: 27928 RVA: 0x001E745C File Offset: 0x001E565C
			public int __callBase_LevelUpEquipmentStar(ulong instanceId, ulong materialId)
			{
				return this.m_owner.__callBase_LevelUpEquipmentStar(instanceId, materialId);
			}

			// Token: 0x06006D19 RID: 27929 RVA: 0x001E746C File Offset: 0x001E566C
			public int __callBase_CalculateEquipmentTotalExp(EquipmentBagItem equipment)
			{
				return this.m_owner.__callBase_CalculateEquipmentTotalExp(equipment);
			}

			// Token: 0x06006D1A RID: 27930 RVA: 0x001E747C File Offset: 0x001E567C
			public int __callBase_CalculateDecomposeEquipmentBackGold(EquipmentBagItem equipment)
			{
				return this.m_owner.__callBase_CalculateDecomposeEquipmentBackGold(equipment);
			}

			// Token: 0x06006D1B RID: 27931 RVA: 0x001E748C File Offset: 0x001E568C
			public void __callBase_OutPutItemOperationLog(GoodsType itemTypeId, int itemId, int nums, GameFunctionType causeId, string location)
			{
				this.m_owner.__callBase_OutPutItemOperationLog(itemTypeId, itemId, nums, causeId, location);
			}

			// Token: 0x06006D1C RID: 27932 RVA: 0x001E74A0 File Offset: 0x001E56A0
			public void __callBase_OnSaveEnchantSaveMissionEvent(EquipmentBagItem equipment)
			{
				this.m_owner.__callBase_OnSaveEnchantSaveMissionEvent(equipment);
			}

			// Token: 0x06006D1D RID: 27933 RVA: 0x001E74B0 File Offset: 0x001E56B0
			public void __callBase_OnEnchantMissionEvent(EquipmentBagItem equipment)
			{
				this.m_owner.__callBase_OnEnchantMissionEvent(equipment);
			}

			// Token: 0x06006D1E RID: 27934 RVA: 0x001E74C0 File Offset: 0x001E56C0
			public void __callBase_OnCreateBagItemEvent(BagItemBase bagItem)
			{
				this.m_owner.__callBase_OnCreateBagItemEvent(bagItem);
			}

			// Token: 0x06006D1F RID: 27935 RVA: 0x001E74D0 File Offset: 0x001E56D0
			public int GetEquipmentResonanceNumsByHero(ulong equipmentInstanceId, Hero hero)
			{
				return this.m_owner.GetEquipmentResonanceNumsByHero(equipmentInstanceId, hero);
			}

			// Token: 0x0400533F RID: 21311
			private BagComponent m_owner;
		}
	}
}
