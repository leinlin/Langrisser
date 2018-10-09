using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000558 RID: 1368
	[CustomLuaClass]
	public class UniformBatchMail
	{
		// Token: 0x06005033 RID: 20531 RVA: 0x00180788 File Offset: 0x0017E988
		public UniformBatchMail()
		{
			this.UserIds = new LinkedList<string>();
		}

		// Token: 0x170013CE RID: 5070
		// (get) Token: 0x06005034 RID: 20532 RVA: 0x0018079C File Offset: 0x0017E99C
		// (set) Token: 0x06005035 RID: 20533 RVA: 0x001807A4 File Offset: 0x0017E9A4
		public LinkedList<string> UserIds { get; set; }

		// Token: 0x170013CF RID: 5071
		// (get) Token: 0x06005036 RID: 20534 RVA: 0x001807B0 File Offset: 0x0017E9B0
		// (set) Token: 0x06005037 RID: 20535 RVA: 0x001807B8 File Offset: 0x0017E9B8
		public Mail UniformMail { get; set; }
	}
}
