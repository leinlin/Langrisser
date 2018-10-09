using System;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200052F RID: 1327
	[CustomLuaClass]
	public class GlobalClimbTowerFloor
	{
		// Token: 0x1700134D RID: 4941
		// (get) Token: 0x06004F07 RID: 20231 RVA: 0x0017E09C File Offset: 0x0017C29C
		// (set) Token: 0x06004F08 RID: 20232 RVA: 0x0017E0A4 File Offset: 0x0017C2A4
		public int LevelId { get; set; }

		// Token: 0x1700134E RID: 4942
		// (get) Token: 0x06004F09 RID: 20233 RVA: 0x0017E0B0 File Offset: 0x0017C2B0
		// (set) Token: 0x06004F0A RID: 20234 RVA: 0x0017E0B8 File Offset: 0x0017C2B8
		public int RuleId { get; set; }

		// Token: 0x1700134F RID: 4943
		// (get) Token: 0x06004F0B RID: 20235 RVA: 0x0017E0C4 File Offset: 0x0017C2C4
		// (set) Token: 0x06004F0C RID: 20236 RVA: 0x0017E0CC File Offset: 0x0017C2CC
		public int ArmyRandomSeed { get; set; }

		// Token: 0x17001350 RID: 4944
		// (get) Token: 0x06004F0D RID: 20237 RVA: 0x0017E0D8 File Offset: 0x0017C2D8
		// (set) Token: 0x06004F0E RID: 20238 RVA: 0x0017E0E0 File Offset: 0x0017C2E0
		public int BonusHeroGroupId { get; set; }
	}
}
