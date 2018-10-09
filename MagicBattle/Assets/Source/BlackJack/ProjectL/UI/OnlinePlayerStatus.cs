using System;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x020010E9 RID: 4329
	public class OnlinePlayerStatus
	{
		// Token: 0x17003EF6 RID: 16118
		// (get) Token: 0x060159B5 RID: 88501 RVA: 0x005804D0 File Offset: 0x0057E6D0
		// (set) Token: 0x060159B6 RID: 88502 RVA: 0x005804F0 File Offset: 0x0057E6F0
		[DoNotToLua]
		public OnlinePlayerStatus.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new OnlinePlayerStatus.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0400BCD1 RID: 48337
		[DoNotToLua]
		private OnlinePlayerStatus.LuaExportHelper luaExportHelper;

		// Token: 0x020010EA RID: 4330
		public class LuaExportHelper
		{
			// Token: 0x060159B7 RID: 88503 RVA: 0x005804FC File Offset: 0x0057E6FC
			public LuaExportHelper(OnlinePlayerStatus owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0400BCD2 RID: 48338
			private OnlinePlayerStatus m_owner;
		}
	}
}
