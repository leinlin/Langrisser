using System;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200050F RID: 1295
	[CustomLuaClass]
	public class BagItemFactory
	{
		// Token: 0x17001311 RID: 4881
		// (get) Token: 0x06004E47 RID: 20039 RVA: 0x0017C9E4 File Offset: 0x0017ABE4
		// (set) Token: 0x06004E48 RID: 20040 RVA: 0x0017C9EC File Offset: 0x0017ABEC
		public IConfigDataLoader ConfigDataLoader { get; set; }

		// Token: 0x06004E49 RID: 20041 RVA: 0x0017C9F8 File Offset: 0x0017ABF8
		public static ulong CreateBagItemInstanceId(GoodsType goodsTypeId, int contentId)
		{
			ulong num = (ulong)((long)goodsTypeId);
			num <<= 32;
			ulong num2 = (ulong)((long)contentId);
			return num | num2;
		}

		// Token: 0x06004E4A RID: 20042 RVA: 0x0017CA18 File Offset: 0x0017AC18
		public BagItemBase CreateBagItem(GoodsType goodsTypeId, int contentId, int nums)
		{
			ulong instanceId = BagItemFactory.CreateBagItemInstanceId(goodsTypeId, contentId);
			if (goodsTypeId == GoodsType.GoodsType_JobMaterial)
			{
				return new JobMaterialBagItem(goodsTypeId, contentId, nums, instanceId);
			}
			if (goodsTypeId != GoodsType.GoodsType_Item)
			{
				if (goodsTypeId != GoodsType.GoodsType_EnchantStone)
				{
					return null;
				}
				return new EnchantStoneBagItem(goodsTypeId, contentId, nums, instanceId);
			}
			else
			{
				ConfigDataItemInfo configDataItemInfo = this.ConfigDataLoader.GetConfigDataItemInfo(contentId);
				switch (configDataItemInfo.FuncType)
				{
				case ItemFuncType.ItemFuncType_None:
				case ItemFuncType.ItemFuncType_JobMaterialFragment:
					return new UnusableBagItem(goodsTypeId, contentId, nums, instanceId);
				case ItemFuncType.ItemFuncType_Gold:
					return new GoldUsableBagItem(goodsTypeId, contentId, nums, instanceId)
					{
						GoldCount = configDataItemInfo.FuncTypeParam1
					};
				case ItemFuncType.ItemFuncType_Crystal:
					return new CrystalUsableBagItem(goodsTypeId, contentId, nums, instanceId)
					{
						CrystalCount = configDataItemInfo.FuncTypeParam1
					};
				case ItemFuncType.ItemFuncType_Energy:
					return new EnergyUsableBagItem(goodsTypeId, contentId, nums, instanceId)
					{
						EnergyCount = configDataItemInfo.FuncTypeParam1
					};
				case ItemFuncType.ItemFuncType_HeroEXP:
					return new HeroExpUseableBagItem(goodsTypeId, contentId, nums, instanceId)
					{
						HeroExp = configDataItemInfo.FuncTypeParam1
					};
				case ItemFuncType.ItemFuncType_PlayerEXP:
					return new PlayerExpUseableBagItem(goodsTypeId, contentId, nums, instanceId)
					{
						PlayerExp = configDataItemInfo.FuncTypeParam1
					};
				case ItemFuncType.ItemFuncType_HeroFragment:
					return new HeroFragmentBagItem(goodsTypeId, contentId, nums, instanceId)
					{
						ExchangeMemoryEssence = configDataItemInfo.FuncTypeParam1
					};
				case ItemFuncType.ItemFuncType_StaticBox:
					return new StaticBoxBagItem(goodsTypeId, contentId, nums, instanceId);
				case ItemFuncType.ItemFuncType_RandomBox:
					return new RandomBoxBagItem(goodsTypeId, contentId, nums, instanceId);
				case ItemFuncType.ItemFuncType_NameChange:
					return new ChangeNameUsableBagItem(goodsTypeId, contentId, nums, instanceId);
				case ItemFuncType.ItemFuncType_AddHeroFavorabilityExp:
				{
					AddHeroFavorabilityUseableBagItem addHeroFavorabilityUseableBagItem = new AddHeroFavorabilityUseableBagItem(goodsTypeId, contentId, nums, instanceId);
					addHeroFavorabilityUseableBagItem.NormalAddExp = configDataItemInfo.FuncTypeParam1;
					addHeroFavorabilityUseableBagItem.SpecificHeroAddFavorabilityExpMultipleValue = configDataItemInfo.FuncTypeParam2;
					addHeroFavorabilityUseableBagItem.SpecificHeroes.AddRange(configDataItemInfo.FuncTypeParam4);
					return addHeroFavorabilityUseableBagItem;
				}
				case ItemFuncType.ItemFuncType_SelfSelectedBox:
					return new SelfSelectedBoxBagItem(goodsTypeId, contentId, nums, instanceId);
				default:
					return null;
				}
			}
		}

		// Token: 0x06004E4B RID: 20043 RVA: 0x0017CBC0 File Offset: 0x0017ADC0
		public BagItemBase CreateInstanceBagItemByServer(GoodsType goodsTypeId, int contentId, int nums, ulong instanceId)
		{
			if (goodsTypeId != GoodsType.GoodsType_Equipment)
			{
				return null;
			}
			EquipmentBagItem equipmentBagItem = new EquipmentBagItem(goodsTypeId, contentId, nums, instanceId);
			equipmentBagItem.StarLevel = this.ConfigDataLoader.GetConfigDataEquipmentInfo(equipmentBagItem.ContentId).BornStarLevel;
			return equipmentBagItem;
		}

		// Token: 0x06004E4C RID: 20044 RVA: 0x0017CC04 File Offset: 0x0017AE04
		public BagItemBase CreateInstanceBagItemByClient(ProGoods pbGoods)
		{
			GoodsType goodsType = (GoodsType)pbGoods.GoodsType;
			if (goodsType != GoodsType.GoodsType_Equipment)
			{
				return null;
			}
			ProEquipment equipment = pbGoods.Equipment;
			EquipmentBagItem equipmentBagItem = new EquipmentBagItem(goodsType, pbGoods.Id, pbGoods.Nums, pbGoods.InstanceId);
			equipmentBagItem.Level = equipment.Level;
			equipmentBagItem.Exp = equipment.Exp;
			equipmentBagItem.StarLevel = equipment.StarLevel;
			equipmentBagItem.Locked = equipment.Locked;
			equipmentBagItem.ResonanceId = equipment.ResonanceId;
			foreach (ProCommonBattleProperty pbProperty in equipment.EnchantProperties)
			{
				equipmentBagItem.EnchantProperties.Add(CommonBattleProperty.PBCommonBattlePropertyToCommonBattleProperty(pbProperty));
			}
			return equipmentBagItem;
		}
	}
}
