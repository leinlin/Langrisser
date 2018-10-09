using System;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x020010E5 RID: 4325
	public class JobChoiceValue
	{
		// Token: 0x17003EF4 RID: 16116
		// (get) Token: 0x060159AD RID: 88493 RVA: 0x00580448 File Offset: 0x0057E648
		// (set) Token: 0x060159AE RID: 88494 RVA: 0x00580468 File Offset: 0x0057E668
		[DoNotToLua]
		public JobChoiceValue.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new JobChoiceValue.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0400BCCD RID: 48333
		[DoNotToLua]
		private JobChoiceValue.LuaExportHelper luaExportHelper;

		// Token: 0x020010E6 RID: 4326
		public class LuaExportHelper
		{
			// Token: 0x060159AF RID: 88495 RVA: 0x00580474 File Offset: 0x0057E674
			public LuaExportHelper(JobChoiceValue owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0400BCCE RID: 48334
			private JobChoiceValue m_owner;
		}
	}
}
