using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020003FF RID: 1023
	[CustomLuaClass]
	public class GuildMassiveCombatGeneral
	{
		// Token: 0x1700104A RID: 4170
		// (get) Token: 0x06003BED RID: 15341 RVA: 0x001109D4 File Offset: 0x0010EBD4
		// (set) Token: 0x06003BEE RID: 15342 RVA: 0x001109DC File Offset: 0x0010EBDC
		public GuildMassiveCombatInfo RecentCombat { get; set; }

		// Token: 0x04002DBA RID: 11706
		public List<GuildMassiveCombatInfo> FinishedCombats = new List<GuildMassiveCombatInfo>();
	}
}
