using System;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x020010E1 RID: 4321
	public class HeroWrap
	{
		// Token: 0x17003EF2 RID: 16114
		// (get) Token: 0x060159A5 RID: 88485 RVA: 0x005803C0 File Offset: 0x0057E5C0
		// (set) Token: 0x060159A6 RID: 88486 RVA: 0x005803E0 File Offset: 0x0057E5E0
		[DoNotToLua]
		public HeroWrap.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroWrap.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0400BCC9 RID: 48329
		[DoNotToLua]
		private HeroWrap.LuaExportHelper luaExportHelper;

		// Token: 0x020010E2 RID: 4322
		public class LuaExportHelper
		{
			// Token: 0x060159A7 RID: 88487 RVA: 0x005803EC File Offset: 0x0057E5EC
			public LuaExportHelper(HeroWrap owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0400BCCA RID: 48330
			private HeroWrap m_owner;
		}
	}
}
