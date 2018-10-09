using System;
using System.Collections.Generic;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;
using BlackJack.UtilityTools;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004F5 RID: 1269
	[CustomLuaClass]
	public class DataSectionResource : DataSection
	{
		// Token: 0x06004CEA RID: 19690 RVA: 0x00179A28 File Offset: 0x00177C28
		public override void ClearInitedData()
		{
		}

		// Token: 0x06004CEB RID: 19691 RVA: 0x00179A2C File Offset: 0x00177C2C
		public override object SerializeToClient()
		{
			return new DSResourceNtf
			{
				Version = (int)base.Version,
				Resource = PlayerOutOfBagItem.ToPB(this.m_resource)
			};
		}

		// Token: 0x06004CEC RID: 19692 RVA: 0x00179A60 File Offset: 0x00177C60
		public List<MonthCard> GetAllMonthCards()
		{
			return this.m_resource.MonthCards;
		}

		// Token: 0x06004CED RID: 19693 RVA: 0x00179A70 File Offset: 0x00177C70
		public MonthCard FindMonthCardById(int cardId)
		{
			return this.m_resource.MonthCards.Find((MonthCard t) => t.CardId == cardId);
		}

		// Token: 0x06004CEE RID: 19694 RVA: 0x00179AA8 File Offset: 0x00177CA8
		public void AddMonthCard(int monthCardId, DateTime expiredTime, string goodsId = null)
		{
			MonthCard monthCard = this.FindMonthCardById(monthCardId);
			if (monthCard == null)
			{
				monthCard = new MonthCard();
				monthCard.CardId = monthCardId;
				monthCard.GoodsId = goodsId;
				this.m_resource.MonthCards.Add(monthCard);
			}
			monthCard.ExpiredTime = expiredTime;
			this.m_resource.MonthCards.Sort((MonthCard a, MonthCard b) => TimeCaculate.AscendTimeCallBack(a.ExpiredTime, b.ExpiredTime));
			base.SetDirty(true);
		}

		// Token: 0x06004CEF RID: 19695 RVA: 0x00179B24 File Offset: 0x00177D24
		public bool RemoveMonthCard(int monthCardId)
		{
			MonthCard monthCard = this.FindMonthCardById(monthCardId);
			if (monthCard == null)
			{
				return false;
			}
			this.m_resource.MonthCards.Remove(monthCard);
			base.SetDirty(true);
			return true;
		}

		// Token: 0x06004CF0 RID: 19696 RVA: 0x00179B5C File Offset: 0x00177D5C
		public void RemoveMonthCard(MonthCard monthCard)
		{
			this.m_resource.MonthCards.Remove(monthCard);
			base.SetDirty(true);
		}

		// Token: 0x06004CF1 RID: 19697 RVA: 0x00179B78 File Offset: 0x00177D78
		public bool HasHeadFrameId(int headFrameId)
		{
			return this.m_resource.HeadFrames.Contains(headFrameId);
		}

		// Token: 0x06004CF2 RID: 19698 RVA: 0x00179B8C File Offset: 0x00177D8C
		public bool AddHeadFrame(int headFrameId)
		{
			if (!this.m_resource.HeadFrames.Contains(headFrameId))
			{
				this.m_resource.HeadFrames.Add(headFrameId);
				base.SetDirty(true);
				return true;
			}
			return false;
		}

		// Token: 0x06004CF3 RID: 19699 RVA: 0x00179BC0 File Offset: 0x00177DC0
		public bool HasOwn(GoodsType goodtypeId, int id)
		{
			switch (goodtypeId)
			{
			case GoodsType.GoodsType_HeadFrame:
				return this.m_resource.HeadFrames.Contains(id);
			case GoodsType.GoodsType_HeroSkin:
				return this.m_resource.HeroSkinIds.Contains(id);
			case GoodsType.GoodsType_SoldierSkin:
				return this.m_resource.SoldierSkinIds.Contains(id);
			default:
				return goodtypeId == GoodsType.GoodsType_Equipment && this.m_resource.EquipmentIds.Contains(id);
			}
		}

		// Token: 0x06004CF4 RID: 19700 RVA: 0x00179C38 File Offset: 0x00177E38
		public void AddHeroSkin(int heroSkinId)
		{
			this.m_resource.HeroSkinIds.Add(heroSkinId);
			base.SetDirty(true);
		}

		// Token: 0x06004CF5 RID: 19701 RVA: 0x00179C54 File Offset: 0x00177E54
		public void AddSoldierSkin(int soldierSkinId)
		{
			this.m_resource.SoldierSkinIds.Add(soldierSkinId);
			base.SetDirty(true);
		}

		// Token: 0x06004CF6 RID: 19702 RVA: 0x00179C70 File Offset: 0x00177E70
		public void AddEquipmentId(int equipmentId)
		{
			this.m_resource.EquipmentIds.Add(equipmentId);
			base.SetDirty(true);
		}

		// Token: 0x06004CF7 RID: 19703 RVA: 0x00179C8C File Offset: 0x00177E8C
		public void InitResource(PlayerOutOfBagItem resource)
		{
			this.m_resource = resource;
		}

		// Token: 0x170012B5 RID: 4789
		// (get) Token: 0x06004CF8 RID: 19704 RVA: 0x00179C98 File Offset: 0x00177E98
		public PlayerOutOfBagItem Resource
		{
			get
			{
				return this.m_resource;
			}
		}

		// Token: 0x040038D2 RID: 14546
		public PlayerOutOfBagItem m_resource = new PlayerOutOfBagItem();
	}
}
