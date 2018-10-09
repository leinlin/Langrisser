using System;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020003E3 RID: 995
	[CustomLuaClass]
	public class BusinessCardStatisticalData
	{
		// Token: 0x1700100F RID: 4111
		// (get) Token: 0x06003B41 RID: 15169 RVA: 0x0010F2E0 File Offset: 0x0010D4E0
		// (set) Token: 0x06003B42 RID: 15170 RVA: 0x0010F2E8 File Offset: 0x0010D4E8
		public int MostSkilledHeroId { get; set; }

		// Token: 0x17001010 RID: 4112
		// (get) Token: 0x06003B43 RID: 15171 RVA: 0x0010F2F4 File Offset: 0x0010D4F4
		// (set) Token: 0x06003B44 RID: 15172 RVA: 0x0010F2FC File Offset: 0x0010D4FC
		public int HeroTotalPower { get; set; }

		// Token: 0x17001011 RID: 4113
		// (get) Token: 0x06003B45 RID: 15173 RVA: 0x0010F308 File Offset: 0x0010D508
		// (set) Token: 0x06003B46 RID: 15174 RVA: 0x0010F310 File Offset: 0x0010D510
		public int AchievementMissionNums { get; set; }

		// Token: 0x17001012 RID: 4114
		// (get) Token: 0x06003B47 RID: 15175 RVA: 0x0010F31C File Offset: 0x0010D51C
		// (set) Token: 0x06003B48 RID: 15176 RVA: 0x0010F324 File Offset: 0x0010D524
		public int MasterJobNums { get; set; }

		// Token: 0x17001013 RID: 4115
		// (get) Token: 0x06003B49 RID: 15177 RVA: 0x0010F330 File Offset: 0x0010D530
		// (set) Token: 0x06003B4A RID: 15178 RVA: 0x0010F338 File Offset: 0x0010D538
		public int RiftAchievementNums { get; set; }

		// Token: 0x17001014 RID: 4116
		// (get) Token: 0x06003B4B RID: 15179 RVA: 0x0010F344 File Offset: 0x0010D544
		// (set) Token: 0x06003B4C RID: 15180 RVA: 0x0010F34C File Offset: 0x0010D54C
		public int ChooseLevelAchievementNums { get; set; }

		// Token: 0x06003B4D RID: 15181 RVA: 0x0010F358 File Offset: 0x0010D558
		public static ProBusinessCardStatisticalData ToProtocol(BusinessCardStatisticalData data)
		{
			return new ProBusinessCardStatisticalData
			{
				MostSkilledHeroId = data.MostSkilledHeroId,
				HeroTotalPower = data.HeroTotalPower,
				AchievementMissionNums = data.AchievementMissionNums,
				MasterJobNums = data.MasterJobNums,
				RiftAchievementNums = data.RiftAchievementNums,
				ChooseLevelAchievementNums = data.ChooseLevelAchievementNums
			};
		}

		// Token: 0x06003B4E RID: 15182 RVA: 0x0010F3B4 File Offset: 0x0010D5B4
		public static BusinessCardStatisticalData FromProtocol(ProBusinessCardStatisticalData pbData)
		{
			return new BusinessCardStatisticalData
			{
				MostSkilledHeroId = pbData.MostSkilledHeroId,
				HeroTotalPower = pbData.HeroTotalPower,
				AchievementMissionNums = pbData.AchievementMissionNums,
				MasterJobNums = pbData.MasterJobNums,
				RiftAchievementNums = pbData.RiftAchievementNums,
				ChooseLevelAchievementNums = pbData.ChooseLevelAchievementNums
			};
		}
	}
}
