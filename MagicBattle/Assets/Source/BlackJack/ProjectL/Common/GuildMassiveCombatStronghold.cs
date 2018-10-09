using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020003FA RID: 1018
	[CustomLuaClass]
	public class GuildMassiveCombatStronghold
	{
		// Token: 0x1700103F RID: 4159
		// (get) Token: 0x06003BCC RID: 15308 RVA: 0x00110220 File Offset: 0x0010E420
		// (set) Token: 0x06003BCD RID: 15309 RVA: 0x00110228 File Offset: 0x0010E428
		public int ConfigId { get; set; }

		// Token: 0x17001040 RID: 4160
		// (get) Token: 0x06003BCE RID: 15310 RVA: 0x00110234 File Offset: 0x0010E434
		// (set) Token: 0x06003BCF RID: 15311 RVA: 0x0011023C File Offset: 0x0010E43C
		public int LevelId { get; set; }

		// Token: 0x17001041 RID: 4161
		// (get) Token: 0x06003BD0 RID: 15312 RVA: 0x00110248 File Offset: 0x0010E448
		// (set) Token: 0x06003BD1 RID: 15313 RVA: 0x00110250 File Offset: 0x0010E450
		public int RandomSeed { get; set; }

		// Token: 0x17001042 RID: 4162
		// (get) Token: 0x06003BD2 RID: 15314 RVA: 0x0011025C File Offset: 0x0010E45C
		// (set) Token: 0x06003BD3 RID: 15315 RVA: 0x00110264 File Offset: 0x0010E464
		public int EnemyEliminated { get; set; }

		// Token: 0x06003BD4 RID: 15316 RVA: 0x00110270 File Offset: 0x0010E470
		public bool IsTakenOver(DateTime now)
		{
			return this.TakenOverTime < now.AddDays(14.0);
		}

		// Token: 0x04002D9D RID: 11677
		public DateTime TakenOverTime = DateTime.MaxValue;

		// Token: 0x04002D9E RID: 11678
		public List<int> PreferredHeroTagIds = new List<int>();
	}
}
