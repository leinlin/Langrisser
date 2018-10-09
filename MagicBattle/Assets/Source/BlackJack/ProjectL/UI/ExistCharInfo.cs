using System;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x020010DD RID: 4317
	public class ExistCharInfo
	{
		// Token: 0x17003EF0 RID: 16112
		// (get) Token: 0x0601599D RID: 88477 RVA: 0x00580338 File Offset: 0x0057E538
		// (set) Token: 0x0601599E RID: 88478 RVA: 0x00580358 File Offset: 0x0057E558
		[DoNotToLua]
		public ExistCharInfo.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ExistCharInfo.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0400BCC5 RID: 48325
		[DoNotToLua]
		private ExistCharInfo.LuaExportHelper luaExportHelper;

		// Token: 0x020010DE RID: 4318
		public class LuaExportHelper
		{
			// Token: 0x0601599F RID: 88479 RVA: 0x00580364 File Offset: 0x0057E564
			public LuaExportHelper(ExistCharInfo owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0400BCC6 RID: 48326
			private ExistCharInfo m_owner;
		}
	}
}
