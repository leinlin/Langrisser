using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000524 RID: 1316
	[CustomLuaClass]
	public class BattleReport
	{
		// Token: 0x17001327 RID: 4903
		// (get) Token: 0x06004EA8 RID: 20136 RVA: 0x0017D55C File Offset: 0x0017B75C
		// (set) Token: 0x06004EA9 RID: 20137 RVA: 0x0017D564 File Offset: 0x0017B764
		public int Version { get; set; }

		// Token: 0x17001328 RID: 4904
		// (get) Token: 0x06004EAA RID: 20138 RVA: 0x0017D570 File Offset: 0x0017B770
		// (set) Token: 0x06004EAB RID: 20139 RVA: 0x0017D578 File Offset: 0x0017B778
		public ulong InstanceId { get; set; }

		// Token: 0x17001329 RID: 4905
		// (get) Token: 0x06004EAC RID: 20140 RVA: 0x0017D584 File Offset: 0x0017B784
		// (set) Token: 0x06004EAD RID: 20141 RVA: 0x0017D58C File Offset: 0x0017B78C
		public BattleType BattleType { get; set; }

		// Token: 0x1700132A RID: 4906
		// (get) Token: 0x06004EAE RID: 20142 RVA: 0x0017D598 File Offset: 0x0017B798
		// (set) Token: 0x06004EAF RID: 20143 RVA: 0x0017D5A0 File Offset: 0x0017B7A0
		public int BattleId { get; set; }

		// Token: 0x1700132B RID: 4907
		// (get) Token: 0x06004EB0 RID: 20144 RVA: 0x0017D5AC File Offset: 0x0017B7AC
		// (set) Token: 0x06004EB1 RID: 20145 RVA: 0x0017D5B4 File Offset: 0x0017B7B4
		public int RandomSeed { get; set; }

		// Token: 0x04003967 RID: 14695
		public List<BattleCommand> Commands = new List<BattleCommand>();
	}
}
