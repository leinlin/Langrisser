using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000566 RID: 1382
	[CustomLuaClass]
	public class PlayerOutOfBagItem
	{
		// Token: 0x060050B6 RID: 20662 RVA: 0x00181A80 File Offset: 0x0017FC80
		public static ProResource ToPB(PlayerOutOfBagItem resource)
		{
			ProResource proResource = new ProResource();
			proResource.HeadFrames.AddRange(resource.HeadFrames);
			proResource.HeroSkinIds.AddRange(resource.HeroSkinIds);
			proResource.SoldierSkinIds.AddRange(resource.SoldierSkinIds);
			proResource.EquipmentIds.AddRange(resource.EquipmentIds);
			foreach (MonthCard monthCard in resource.MonthCards)
			{
				proResource.MonthCards.Add(MonthCard.ToPB(monthCard));
			}
			return proResource;
		}

		// Token: 0x060050B7 RID: 20663 RVA: 0x00181B34 File Offset: 0x0017FD34
		public static PlayerOutOfBagItem FromPB(ProResource pbResource)
		{
			PlayerOutOfBagItem playerOutOfBagItem = new PlayerOutOfBagItem();
			playerOutOfBagItem.HeadFrames.AddRange(pbResource.HeadFrames);
			playerOutOfBagItem.HeroSkinIds.AddRange(pbResource.HeroSkinIds);
			playerOutOfBagItem.SoldierSkinIds.AddRange(pbResource.SoldierSkinIds);
			playerOutOfBagItem.EquipmentIds.AddRange(pbResource.EquipmentIds);
			foreach (ProMonthCard pbMonthCard in pbResource.MonthCards)
			{
				playerOutOfBagItem.MonthCards.Add(MonthCard.FromPB(pbMonthCard));
			}
			return playerOutOfBagItem;
		}

		// Token: 0x04003A23 RID: 14883
		public List<int> HeadFrames = new List<int>();

		// Token: 0x04003A24 RID: 14884
		public List<int> HeroSkinIds = new List<int>();

		// Token: 0x04003A25 RID: 14885
		public List<int> SoldierSkinIds = new List<int>();

		// Token: 0x04003A26 RID: 14886
		public List<int> EquipmentIds = new List<int>();

		// Token: 0x04003A27 RID: 14887
		public List<MonthCard> MonthCards = new List<MonthCard>();
	}
}
