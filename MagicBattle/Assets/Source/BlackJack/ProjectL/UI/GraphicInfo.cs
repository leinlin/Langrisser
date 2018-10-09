using System;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x020010DF RID: 4319
	public class GraphicInfo
	{
		// Token: 0x17003EF1 RID: 16113
		// (get) Token: 0x060159A1 RID: 88481 RVA: 0x0058037C File Offset: 0x0057E57C
		// (set) Token: 0x060159A2 RID: 88482 RVA: 0x0058039C File Offset: 0x0057E59C
		[DoNotToLua]
		public GraphicInfo.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GraphicInfo.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0400BCC7 RID: 48327
		[DoNotToLua]
		private GraphicInfo.LuaExportHelper luaExportHelper;

		// Token: 0x020010E0 RID: 4320
		public class LuaExportHelper
		{
			// Token: 0x060159A3 RID: 88483 RVA: 0x005803A8 File Offset: 0x0057E5A8
			public LuaExportHelper(GraphicInfo owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0400BCC8 RID: 48328
			private GraphicInfo m_owner;
		}
	}
}
