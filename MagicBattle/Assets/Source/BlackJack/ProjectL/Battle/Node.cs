using System;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x020010E7 RID: 4327
	public class Node
	{
		// Token: 0x17003EF5 RID: 16117
		// (get) Token: 0x060159B1 RID: 88497 RVA: 0x0058048C File Offset: 0x0057E68C
		// (set) Token: 0x060159B2 RID: 88498 RVA: 0x005804AC File Offset: 0x0057E6AC
		[DoNotToLua]
		public Node.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new Node.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0400BCCF RID: 48335
		[DoNotToLua]
		private Node.LuaExportHelper luaExportHelper;

		// Token: 0x020010E8 RID: 4328
		public class LuaExportHelper
		{
			// Token: 0x060159B3 RID: 88499 RVA: 0x005804B8 File Offset: 0x0057E6B8
			public LuaExportHelper(Node owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0400BCD0 RID: 48336
			private Node m_owner;
		}
	}
}
