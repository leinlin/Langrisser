using System;
using System.Collections.Generic;
using System.Linq;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004F9 RID: 1273
	[CustomLuaClass]
	public class DataSectionSelectCard : DataSection
	{
		// Token: 0x06004D25 RID: 19749 RVA: 0x0017A288 File Offset: 0x00178488
		public DataSectionSelectCard()
		{
			this.CardPools = new Dictionary<int, CardPool>();
			this.m_guaranteedSelectCardCount = 0;
			this.m_guaranteedAccumulatedValue = 0;
		}

		// Token: 0x06004D26 RID: 19750 RVA: 0x0017A2AC File Offset: 0x001784AC
		public override void ClearInitedData()
		{
			this.CardPools.Clear();
		}

		// Token: 0x06004D27 RID: 19751 RVA: 0x0017A2BC File Offset: 0x001784BC
		public override object SerializeToClient()
		{
			DSSelectCardNtf dsselectCardNtf = new DSSelectCardNtf();
			dsselectCardNtf.Version = (uint)base.Version;
			dsselectCardNtf.CardPools.AddRange(CardPool.CardPoolsToPBActivityCardPools(this.CardPools.Values.ToList<CardPool>()));
			return dsselectCardNtf;
		}

		// Token: 0x06004D28 RID: 19752 RVA: 0x0017A2FC File Offset: 0x001784FC
		public void InitCardPools(List<CardPool> cardPools)
		{
			foreach (CardPool cardPool in cardPools)
			{
				this.CardPools.Add(cardPool.PoolId, cardPool);
			}
		}

		// Token: 0x06004D29 RID: 19753 RVA: 0x0017A360 File Offset: 0x00178560
		public void SetCardPools(List<CardPool> cardPools)
		{
			this.InitCardPools(cardPools);
			base.SetDirty(true);
		}

		// Token: 0x06004D2A RID: 19754 RVA: 0x0017A370 File Offset: 0x00178570
		public bool CanTenSelectDiscount(CardPool cardPool)
		{
			return cardPool.DisconnectCount < cardPool.Config.TenSelectCount;
		}

		// Token: 0x06004D2B RID: 19755 RVA: 0x0017A388 File Offset: 0x00178588
		public CardPool FindCardPool(int cardPoolId)
		{
			CardPool result = null;
			this.CardPools.TryGetValue(cardPoolId, out result);
			return result;
		}

		// Token: 0x06004D2C RID: 19756 RVA: 0x0017A3A8 File Offset: 0x001785A8
		public void RemoveCardPool(int cardPoolId)
		{
			if (this.CardPools.Remove(cardPoolId))
			{
				base.SetDirty(true);
			}
		}

		// Token: 0x06004D2D RID: 19757 RVA: 0x0017A3C4 File Offset: 0x001785C4
		public CardPool AddCardPool(CardPool newCardPool)
		{
			CardPool result = null;
			if (!this.CardPools.ContainsKey(newCardPool.PoolId))
			{
				this.CardPools.Add(newCardPool.PoolId, newCardPool);
				result = newCardPool;
			}
			else
			{
				this.CardPools[newCardPool.PoolId] = newCardPool;
			}
			base.SetDirty(true);
			return result;
		}

		// Token: 0x06004D2E RID: 19758 RVA: 0x0017A41C File Offset: 0x0017861C
		public void AddSelectCount(CardPool cardPool, int count = 1)
		{
			cardPool.SelectCardCount += count;
		}

		// Token: 0x06004D2F RID: 19759 RVA: 0x0017A42C File Offset: 0x0017862C
		public void SummonRareHero(CardPool cardPool)
		{
			cardPool.SummonedRareHero = true;
		}

		// Token: 0x06004D30 RID: 19760 RVA: 0x0017A438 File Offset: 0x00178638
		public void AddGuaranteedSelectCount(int count)
		{
			this.m_guaranteedSelectCardCount += count;
			base.SetDirty(true);
		}

		// Token: 0x06004D31 RID: 19761 RVA: 0x0017A450 File Offset: 0x00178650
		public void AddTenSelectDiscountCount(CardPool cardPool)
		{
			cardPool.DisconnectCount++;
		}

		// Token: 0x06004D32 RID: 19762 RVA: 0x0017A460 File Offset: 0x00178660
		public bool IsFirstSingleSelectCard(CardPool cardPool)
		{
			return cardPool.IsFirstSignleSelect;
		}

		// Token: 0x06004D33 RID: 19763 RVA: 0x0017A468 File Offset: 0x00178668
		public bool IsFirstTenSelectCard(CardPool cardPool)
		{
			return cardPool.IsFirstTenSelect;
		}

		// Token: 0x06004D34 RID: 19764 RVA: 0x0017A470 File Offset: 0x00178670
		public bool IsFirstSelectCard(CardPool cardPool)
		{
			return cardPool.SelectCardCount == 0;
		}

		// Token: 0x06004D35 RID: 19765 RVA: 0x0017A47C File Offset: 0x0017867C
		public void FinishFirstSingleSelect(CardPool cardPool)
		{
			cardPool.IsFirstSignleSelect = false;
		}

		// Token: 0x06004D36 RID: 19766 RVA: 0x0017A488 File Offset: 0x00178688
		public void FinishFirstTenSelect(CardPool cardPool)
		{
			cardPool.IsFirstTenSelect = false;
		}

		// Token: 0x06004D37 RID: 19767 RVA: 0x0017A494 File Offset: 0x00178694
		public void SetGuaranteedAccumulatedValue(int value)
		{
			this.m_guaranteedAccumulatedValue = value;
			base.SetDirty(true);
		}

		// Token: 0x06004D38 RID: 19768 RVA: 0x0017A4A4 File Offset: 0x001786A4
		public void InitGuaranteedAccumulatedValue(int value)
		{
			this.m_guaranteedAccumulatedValue = value;
		}

		// Token: 0x06004D39 RID: 19769 RVA: 0x0017A4B0 File Offset: 0x001786B0
		public bool IsReachGuaranteedAccumulatedValue(int value)
		{
			return this.m_guaranteedAccumulatedValue == this.m_guaranteedSelectCardCount + value;
		}

		// Token: 0x06004D3A RID: 19770 RVA: 0x0017A4C4 File Offset: 0x001786C4
		public bool IsAboveGuaranteedAccumulatedValue()
		{
			return this.m_guaranteedAccumulatedValue <= this.m_guaranteedSelectCardCount;
		}

		// Token: 0x06004D3B RID: 19771 RVA: 0x0017A4D8 File Offset: 0x001786D8
		public bool IsCardPoolExistGuaranteedMechanism()
		{
			return this.m_guaranteedAccumulatedValue != 0;
		}

		// Token: 0x06004D3C RID: 19772 RVA: 0x0017A4E8 File Offset: 0x001786E8
		public void SetGuaranteedSelectCardCount(int count)
		{
			this.m_guaranteedSelectCardCount = count;
			base.SetDirty(true);
		}

		// Token: 0x06004D3D RID: 19773 RVA: 0x0017A4F8 File Offset: 0x001786F8
		public void InitGuaranteedSelectCardCount(int count)
		{
			this.m_guaranteedSelectCardCount = count;
		}

		// Token: 0x06004D3E RID: 19774 RVA: 0x0017A504 File Offset: 0x00178704
		public void InitSelectCardGuaranteedStatus(SelectCardGuaranteedStatus status)
		{
			this.m_selectCardGuaranteedStatus = status;
		}

		// Token: 0x06004D3F RID: 19775 RVA: 0x0017A510 File Offset: 0x00178710
		public void SetSelectCardGuaranteedStatus(SelectCardGuaranteedStatus status)
		{
			this.m_selectCardGuaranteedStatus = status;
			base.SetDirty(true);
		}

		// Token: 0x170012BF RID: 4799
		// (get) Token: 0x06004D40 RID: 19776 RVA: 0x0017A520 File Offset: 0x00178720
		// (set) Token: 0x06004D41 RID: 19777 RVA: 0x0017A528 File Offset: 0x00178728
		public Dictionary<int, CardPool> CardPools { get; set; }

		// Token: 0x170012C0 RID: 4800
		// (get) Token: 0x06004D42 RID: 19778 RVA: 0x0017A534 File Offset: 0x00178734
		public int GuaranteedAccumulatedValue
		{
			get
			{
				return this.m_guaranteedAccumulatedValue;
			}
		}

		// Token: 0x170012C1 RID: 4801
		// (get) Token: 0x06004D43 RID: 19779 RVA: 0x0017A53C File Offset: 0x0017873C
		public int GuaranteedSelectCardCount
		{
			get
			{
				return this.m_guaranteedSelectCardCount;
			}
		}

		// Token: 0x170012C2 RID: 4802
		// (get) Token: 0x06004D44 RID: 19780 RVA: 0x0017A544 File Offset: 0x00178744
		public SelectCardGuaranteedStatus GuaranteedStatus
		{
			get
			{
				return this.m_selectCardGuaranteedStatus;
			}
		}

		// Token: 0x040038DF RID: 14559
		private int m_guaranteedAccumulatedValue;

		// Token: 0x040038E0 RID: 14560
		private int m_guaranteedSelectCardCount;

		// Token: 0x040038E1 RID: 14561
		private SelectCardGuaranteedStatus m_selectCardGuaranteedStatus;
	}
}
