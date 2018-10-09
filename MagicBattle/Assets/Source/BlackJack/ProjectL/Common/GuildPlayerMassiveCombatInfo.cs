using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000400 RID: 1024
	[CustomLuaClass]
	public class GuildPlayerMassiveCombatInfo
	{
		// Token: 0x1700104B RID: 4171
		// (get) Token: 0x06003BF0 RID: 15344 RVA: 0x001109FC File Offset: 0x0010EBFC
		// (set) Token: 0x06003BF1 RID: 15345 RVA: 0x00110A04 File Offset: 0x0010EC04
		public string BindedGuildId { get; set; }

		// Token: 0x1700104C RID: 4172
		// (get) Token: 0x06003BF2 RID: 15346 RVA: 0x00110A10 File Offset: 0x0010EC10
		// (set) Token: 0x06003BF3 RID: 15347 RVA: 0x00110A18 File Offset: 0x0010EC18
		public int Points { get; set; }

		// Token: 0x04002DBD RID: 11709
		public List<int> UsedHeroIds = new List<int>();
	}
}
