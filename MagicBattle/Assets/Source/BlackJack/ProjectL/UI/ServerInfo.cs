using System;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x020010ED RID: 4333
	public class ServerInfo
	{
		// Token: 0x17003EF8 RID: 16120
		// (get) Token: 0x060159BD RID: 88509 RVA: 0x00580558 File Offset: 0x0057E758
		// (set) Token: 0x060159BE RID: 88510 RVA: 0x00580578 File Offset: 0x0057E778
		[DoNotToLua]
		public ServerInfo.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ServerInfo.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0400BCD5 RID: 48341
		[DoNotToLua]
		private ServerInfo.LuaExportHelper luaExportHelper;

		// Token: 0x020010EE RID: 4334
		public class LuaExportHelper
		{
			// Token: 0x060159BF RID: 88511 RVA: 0x00580584 File Offset: 0x0057E784
			public LuaExportHelper(ServerInfo owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0400BCD6 RID: 48342
			private ServerInfo m_owner;
		}
	}
}
