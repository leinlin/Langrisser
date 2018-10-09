using System;
using System.Collections.Generic;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000510 RID: 1296
	[CustomLuaClass]
	public class EquipmentBagItem : BagItemBase
	{
		// Token: 0x06004E4D RID: 20045 RVA: 0x0017CCE0 File Offset: 0x0017AEE0
		public EquipmentBagItem(GoodsType goodsTypeId, int contentId, int nums, ulong instanceId) : base(goodsTypeId, contentId, nums, instanceId)
		{
			this.Level = 1;
			this.Locked = false;
		}

		// Token: 0x06004E4E RID: 20046 RVA: 0x0017CD08 File Offset: 0x0017AF08
		public bool IsEnchant()
		{
			return this.ResonanceId != 0;
		}

		// Token: 0x17001312 RID: 4882
		// (get) Token: 0x06004E4F RID: 20047 RVA: 0x0017CD18 File Offset: 0x0017AF18
		// (set) Token: 0x06004E50 RID: 20048 RVA: 0x0017CD20 File Offset: 0x0017AF20
		public int Level { get; set; }

		// Token: 0x17001313 RID: 4883
		// (get) Token: 0x06004E51 RID: 20049 RVA: 0x0017CD2C File Offset: 0x0017AF2C
		// (set) Token: 0x06004E52 RID: 20050 RVA: 0x0017CD34 File Offset: 0x0017AF34
		public int Exp { get; set; }

		// Token: 0x17001314 RID: 4884
		// (get) Token: 0x06004E53 RID: 20051 RVA: 0x0017CD40 File Offset: 0x0017AF40
		// (set) Token: 0x06004E54 RID: 20052 RVA: 0x0017CD48 File Offset: 0x0017AF48
		public int StarLevel { get; set; }

		// Token: 0x17001315 RID: 4885
		// (get) Token: 0x06004E55 RID: 20053 RVA: 0x0017CD54 File Offset: 0x0017AF54
		// (set) Token: 0x06004E56 RID: 20054 RVA: 0x0017CD5C File Offset: 0x0017AF5C
		public bool Locked { get; set; }

		// Token: 0x17001316 RID: 4886
		// (get) Token: 0x06004E57 RID: 20055 RVA: 0x0017CD68 File Offset: 0x0017AF68
		// (set) Token: 0x06004E58 RID: 20056 RVA: 0x0017CD70 File Offset: 0x0017AF70
		public int ResonanceId { get; set; }

		// Token: 0x06004E59 RID: 20057 RVA: 0x0017CD7C File Offset: 0x0017AF7C
		public bool IsEquipmentEnhanced()
		{
			return this.Level > 1 || this.Exp > 0;
		}

		// Token: 0x06004E5A RID: 20058 RVA: 0x0017CD98 File Offset: 0x0017AF98
		public bool IsEquipmentLevelUped(int bornStarLevel)
		{
			return this.StarLevel > bornStarLevel;
		}

		// Token: 0x06004E5B RID: 20059 RVA: 0x0017CDA4 File Offset: 0x0017AFA4
		public BattleHeroEquipment ToBattleHeroEquipment()
		{
			BattleHeroEquipment battleHeroEquipment = new BattleHeroEquipment();
			battleHeroEquipment.Id = base.ContentId;
			battleHeroEquipment.Level = this.Level;
			battleHeroEquipment.StarLevel = this.StarLevel;
			battleHeroEquipment.Exp = this.Exp;
			battleHeroEquipment.ResonanceId = this.ResonanceId;
			battleHeroEquipment.EnchantProperties.AddRange(this.EnchantProperties);
			return battleHeroEquipment;
		}

		// Token: 0x06004E5C RID: 20060 RVA: 0x0017CE08 File Offset: 0x0017B008
		public override ProGoods ToPBGoods()
		{
			ProGoods proGoods = new ProGoods();
			proGoods.GoodsType = (int)base.GoodsTypeId;
			proGoods.Id = base.ContentId;
			proGoods.Nums = base.Nums;
			proGoods.InstanceId = base.InstanceId;
			ProEquipment proEquipment = new ProEquipment();
			proGoods.Equipment = proEquipment;
			proEquipment.Level = this.Level;
			proEquipment.Exp = this.Exp;
			proEquipment.StarLevel = this.StarLevel;
			proEquipment.Locked = this.Locked;
			proEquipment.ResonanceId = this.ResonanceId;
			foreach (CommonBattleProperty property in this.EnchantProperties)
			{
				proEquipment.EnchantProperties.Add(CommonBattleProperty.CommonBattlePropertyToPBCommonBattleProperty(property));
			}
			return proGoods;
		}

		// Token: 0x04003947 RID: 14663
		public List<CommonBattleProperty> EnchantProperties = new List<CommonBattleProperty>();
	}
}
