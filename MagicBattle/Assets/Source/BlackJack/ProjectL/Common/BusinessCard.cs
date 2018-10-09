using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020003E2 RID: 994
	[CustomLuaClass]
	public class BusinessCard
	{
		// Token: 0x17001006 RID: 4102
		// (get) Token: 0x06003B2C RID: 15148 RVA: 0x0010EEFC File Offset: 0x0010D0FC
		// (set) Token: 0x06003B2D RID: 15149 RVA: 0x0010EF04 File Offset: 0x0010D104
		public string UserId { get; set; }

		// Token: 0x17001007 RID: 4103
		// (get) Token: 0x06003B2E RID: 15150 RVA: 0x0010EF10 File Offset: 0x0010D110
		// (set) Token: 0x06003B2F RID: 15151 RVA: 0x0010EF18 File Offset: 0x0010D118
		public string Name { get; set; }

		// Token: 0x17001008 RID: 4104
		// (get) Token: 0x06003B30 RID: 15152 RVA: 0x0010EF24 File Offset: 0x0010D124
		// (set) Token: 0x06003B31 RID: 15153 RVA: 0x0010EF2C File Offset: 0x0010D12C
		public int Level { get; set; }

		// Token: 0x17001009 RID: 4105
		// (get) Token: 0x06003B32 RID: 15154 RVA: 0x0010EF38 File Offset: 0x0010D138
		// (set) Token: 0x06003B33 RID: 15155 RVA: 0x0010EF40 File Offset: 0x0010D140
		public int HeadIcon { get; set; }

		// Token: 0x1700100A RID: 4106
		// (get) Token: 0x06003B34 RID: 15156 RVA: 0x0010EF4C File Offset: 0x0010D14C
		// (set) Token: 0x06003B35 RID: 15157 RVA: 0x0010EF54 File Offset: 0x0010D154
		public int ArenaPoints { get; set; }

		// Token: 0x1700100B RID: 4107
		// (get) Token: 0x06003B36 RID: 15158 RVA: 0x0010EF60 File Offset: 0x0010D160
		// (set) Token: 0x06003B37 RID: 15159 RVA: 0x0010EF68 File Offset: 0x0010D168
		public int Likes { get; set; }

		// Token: 0x1700100C RID: 4108
		// (get) Token: 0x06003B38 RID: 15160 RVA: 0x0010EF74 File Offset: 0x0010D174
		// (set) Token: 0x06003B39 RID: 15161 RVA: 0x0010EF7C File Offset: 0x0010D17C
		public bool IsOnLine { get; set; }

		// Token: 0x1700100D RID: 4109
		// (get) Token: 0x06003B3A RID: 15162 RVA: 0x0010EF88 File Offset: 0x0010D188
		// (set) Token: 0x06003B3B RID: 15163 RVA: 0x0010EF90 File Offset: 0x0010D190
		public BusinessCardInfoSet SetInfo { get; set; }

		// Token: 0x1700100E RID: 4110
		// (get) Token: 0x06003B3C RID: 15164 RVA: 0x0010EF9C File Offset: 0x0010D19C
		// (set) Token: 0x06003B3D RID: 15165 RVA: 0x0010EFA4 File Offset: 0x0010D1A4
		public BusinessCardStatisticalData StatisticalData { get; set; }

		// Token: 0x06003B3E RID: 15166 RVA: 0x0010EFB0 File Offset: 0x0010D1B0
		public static ProBusinessCard ToProtocol(BusinessCard businessCard)
		{
			ProBusinessCard proBusinessCard = new ProBusinessCard();
			proBusinessCard.UserId = businessCard.UserId;
			proBusinessCard.HeadIcon = businessCard.HeadIcon;
			proBusinessCard.Name = businessCard.Name;
			proBusinessCard.Level = businessCard.Level;
			proBusinessCard.ArenaPoints = businessCard.ArenaPoints;
			proBusinessCard.Likes = businessCard.Likes;
			proBusinessCard.IsOnLine = businessCard.IsOnLine;
			proBusinessCard.SetInfo = BusinessCardInfoSet.ToProtocol(businessCard.SetInfo);
			proBusinessCard.StatisticalData = BusinessCardStatisticalData.ToProtocol(businessCard.StatisticalData);
			foreach (BattleHero battleHero in businessCard.Heroes)
			{
				proBusinessCard.Heroes.Add(BattleHero.BattleHeroToPBBattleHero(battleHero));
			}
			foreach (BattleHero battleHero2 in businessCard.MostSkilledHeroes)
			{
				proBusinessCard.MostSkilledHeroes.Add(BattleHero.BattleHeroToPBBattleHero(battleHero2));
			}
			foreach (TrainingTech trainingTech in businessCard.Techs)
			{
				proBusinessCard.Techs.Add(trainingTech.ToPro());
			}
			return proBusinessCard;
		}

		// Token: 0x06003B3F RID: 15167 RVA: 0x0010F144 File Offset: 0x0010D344
		public static BusinessCard FromProtocol(ProBusinessCard pbBusinessCard)
		{
			BusinessCard businessCard = new BusinessCard();
			businessCard.UserId = pbBusinessCard.UserId;
			businessCard.HeadIcon = pbBusinessCard.HeadIcon;
			businessCard.Name = pbBusinessCard.Name;
			businessCard.Level = pbBusinessCard.Level;
			businessCard.ArenaPoints = pbBusinessCard.ArenaPoints;
			businessCard.Likes = pbBusinessCard.Likes;
			businessCard.IsOnLine = pbBusinessCard.IsOnLine;
			businessCard.SetInfo = BusinessCardInfoSet.FromProtocol(pbBusinessCard.SetInfo);
			businessCard.StatisticalData = BusinessCardStatisticalData.FromProtocol(pbBusinessCard.StatisticalData);
			foreach (ProBattleHero pbBattleHero in pbBusinessCard.Heroes)
			{
				businessCard.Heroes.Add(BattleHero.PBBattleHeroToBattleHero(pbBattleHero));
			}
			foreach (ProBattleHero pbBattleHero2 in pbBusinessCard.MostSkilledHeroes)
			{
				businessCard.MostSkilledHeroes.Add(BattleHero.PBBattleHeroToBattleHero(pbBattleHero2));
			}
			foreach (ProTrainingTech tech in pbBusinessCard.Techs)
			{
				businessCard.Techs.Add(TrainingTech.FromDataSection(tech));
			}
			return businessCard;
		}

		// Token: 0x04002D12 RID: 11538
		public List<BattleHero> Heroes = new List<BattleHero>();

		// Token: 0x04002D15 RID: 11541
		public List<TrainingTech> Techs = new List<TrainingTech>();

		// Token: 0x04002D16 RID: 11542
		public List<BattleHero> MostSkilledHeroes = new List<BattleHero>();
	}
}
