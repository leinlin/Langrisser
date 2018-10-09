using System;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x020010E3 RID: 4323
	public class HPState
	{
		// Token: 0x17003EF3 RID: 16115
		// (get) Token: 0x060159A9 RID: 88489 RVA: 0x00580404 File Offset: 0x0057E604
		// (set) Token: 0x060159AA RID: 88490 RVA: 0x00580424 File Offset: 0x0057E624
		[DoNotToLua]
		public HPState.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HPState.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0400BCCB RID: 48331
		[DoNotToLua]
		private HPState.LuaExportHelper luaExportHelper;

		// Token: 0x020010E4 RID: 4324
		public class LuaExportHelper
		{
			// Token: 0x060159AB RID: 88491 RVA: 0x00580430 File Offset: 0x0057E630
			public LuaExportHelper(HPState owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0400BCCC RID: 48332
			private HPState m_owner;
		}
	}
}
