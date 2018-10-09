using System;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x020010D5 RID: 4309
	public class CachedRankingListInfo
	{
		// Token: 0x17003EEC RID: 16108
		// (get) Token: 0x0601598D RID: 88461 RVA: 0x00580228 File Offset: 0x0057E428
		// (set) Token: 0x0601598E RID: 88462 RVA: 0x00580248 File Offset: 0x0057E448
		[DoNotToLua]
		public CachedRankingListInfo.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new CachedRankingListInfo.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0400BCBD RID: 48317
		[DoNotToLua]
		private CachedRankingListInfo.LuaExportHelper luaExportHelper;

		// Token: 0x020010D6 RID: 4310
		public class LuaExportHelper
		{
			// Token: 0x0601598F RID: 88463 RVA: 0x00580254 File Offset: 0x0057E454
			public LuaExportHelper(CachedRankingListInfo owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0400BCBE RID: 48318
			private CachedRankingListInfo m_owner;
		}
	}
}
