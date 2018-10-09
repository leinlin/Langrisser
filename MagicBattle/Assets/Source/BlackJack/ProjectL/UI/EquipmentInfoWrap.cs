using System;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x020010DB RID: 4315
	public class EquipmentInfoWrap
	{
		// Token: 0x17003EEF RID: 16111
		// (get) Token: 0x06015999 RID: 88473 RVA: 0x005802F4 File Offset: 0x0057E4F4
		// (set) Token: 0x0601599A RID: 88474 RVA: 0x00580314 File Offset: 0x0057E514
		[DoNotToLua]
		public EquipmentInfoWrap.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new EquipmentInfoWrap.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0400BCC3 RID: 48323
		[DoNotToLua]
		private EquipmentInfoWrap.LuaExportHelper luaExportHelper;

		// Token: 0x020010DC RID: 4316
		public class LuaExportHelper
		{
			// Token: 0x0601599B RID: 88475 RVA: 0x00580320 File Offset: 0x0057E520
			public LuaExportHelper(EquipmentInfoWrap owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0400BCC4 RID: 48324
			private EquipmentInfoWrap m_owner;
		}
	}
}
