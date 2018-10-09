using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000352 RID: 850
	[CustomLuaClass]
	public class TrainingTechInfo
	{
		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x0600313D RID: 12605 RVA: 0x000C0A50 File Offset: 0x000BEC50
		// (set) Token: 0x0600313E RID: 12606 RVA: 0x000C0A58 File Offset: 0x000BEC58
		public int ID { get; set; }

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x0600313F RID: 12607 RVA: 0x000C0A64 File Offset: 0x000BEC64
		// (set) Token: 0x06003140 RID: 12608 RVA: 0x000C0A6C File Offset: 0x000BEC6C
		public int TechID { get; set; }

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x06003141 RID: 12609 RVA: 0x000C0A78 File Offset: 0x000BEC78
		// (set) Token: 0x06003142 RID: 12610 RVA: 0x000C0A80 File Offset: 0x000BEC80
		public int RoomExp { get; set; }

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x06003143 RID: 12611 RVA: 0x000C0A8C File Offset: 0x000BEC8C
		// (set) Token: 0x06003144 RID: 12612 RVA: 0x000C0A94 File Offset: 0x000BEC94
		public int SoldierIDUnlocked { get; set; }

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x06003145 RID: 12613 RVA: 0x000C0AA0 File Offset: 0x000BECA0
		// (set) Token: 0x06003146 RID: 12614 RVA: 0x000C0AA8 File Offset: 0x000BECA8
		public int SoldierSkillLevelup { get; set; }

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x06003147 RID: 12615 RVA: 0x000C0AB4 File Offset: 0x000BECB4
		// (set) Token: 0x06003148 RID: 12616 RVA: 0x000C0ABC File Offset: 0x000BECBC
		public int SoldierSkillID { get; set; }

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x06003149 RID: 12617 RVA: 0x000C0AC8 File Offset: 0x000BECC8
		// (set) Token: 0x0600314A RID: 12618 RVA: 0x000C0AD0 File Offset: 0x000BECD0
		public int Gold { get; set; }

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x0600314B RID: 12619 RVA: 0x000C0ADC File Offset: 0x000BECDC
		// (set) Token: 0x0600314C RID: 12620 RVA: 0x000C0AE4 File Offset: 0x000BECE4
		public int RoomLevel { get; set; }

		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x0600314D RID: 12621 RVA: 0x000C0AF0 File Offset: 0x000BECF0
		// (set) Token: 0x0600314E RID: 12622 RVA: 0x000C0AF8 File Offset: 0x000BECF8
		public List<Goods> Materials { get; set; }

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x0600314F RID: 12623 RVA: 0x000C0B04 File Offset: 0x000BED04
		// (set) Token: 0x06003150 RID: 12624 RVA: 0x000C0B0C File Offset: 0x000BED0C
		public List<int> PreIds { get; set; }

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x06003151 RID: 12625 RVA: 0x000C0B18 File Offset: 0x000BED18
		// (set) Token: 0x06003152 RID: 12626 RVA: 0x000C0B20 File Offset: 0x000BED20
		public List<int> PreTechLevels { get; set; }

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x06003153 RID: 12627 RVA: 0x000C0B2C File Offset: 0x000BED2C
		// (set) Token: 0x06003154 RID: 12628 RVA: 0x000C0B34 File Offset: 0x000BED34
		public ConfigDataTrainingTechLevelInfo Config { get; set; }

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x06003155 RID: 12629 RVA: 0x000C0B40 File Offset: 0x000BED40
		public TrainingTechResourceRequirements LevelupRequirements
		{
			get
			{
				return new TrainingTechResourceRequirements
				{
					Gold = this.Gold,
					RoomLevel = this.RoomLevel,
					PreTechs = this.PreIds,
					PreTechLevels = this.PreTechLevels,
					Materials = this.Materials
				};
			}
		}
	}
}
