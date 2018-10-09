using System;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x020010EB RID: 4331
	public class PosStringTuple
	{
		// Token: 0x17003EF7 RID: 16119
		// (get) Token: 0x060159B9 RID: 88505 RVA: 0x00580514 File Offset: 0x0057E714
		// (set) Token: 0x060159BA RID: 88506 RVA: 0x00580534 File Offset: 0x0057E734
		[DoNotToLua]
		public PosStringTuple.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new PosStringTuple.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0400BCD3 RID: 48339
		[DoNotToLua]
		private PosStringTuple.LuaExportHelper luaExportHelper;

		// Token: 0x020010EC RID: 4332
		public class LuaExportHelper
		{
			// Token: 0x060159BB RID: 88507 RVA: 0x00580540 File Offset: 0x0057E740
			public LuaExportHelper(PosStringTuple owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0400BCD4 RID: 48340
			private PosStringTuple m_owner;
		}
	}
}
