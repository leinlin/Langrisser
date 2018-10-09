using System;
using SLua;

namespace BlackJack.BJFramework.Runtime.UI
{
	// Token: 0x02000104 RID: 260
	[CustomLuaClassWithProtected]
	public class UIIntent
	{
		// Token: 0x06000A70 RID: 2672 RVA: 0x0002CA98 File Offset: 0x0002AC98
		public UIIntent(string targetTaskName, string targetMode = null)
		{
			this.TargetTaskName = targetTaskName;
			this.TargetMode = targetMode;
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000A71 RID: 2673 RVA: 0x0002CAB0 File Offset: 0x0002ACB0
		// (set) Token: 0x06000A72 RID: 2674 RVA: 0x0002CAB8 File Offset: 0x0002ACB8
		public string TargetTaskName { get; private set; }

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000A73 RID: 2675 RVA: 0x0002CAC4 File Offset: 0x0002ACC4
		// (set) Token: 0x06000A74 RID: 2676 RVA: 0x0002CACC File Offset: 0x0002ACCC
		public string TargetMode { get; set; }

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x0002CAD8 File Offset: 0x0002ACD8
		// (set) Token: 0x06000A76 RID: 2678 RVA: 0x0002CAF8 File Offset: 0x0002ACF8
		[DoNotToLua]
		public UIIntent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new UIIntent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0400063F RID: 1599
		[DoNotToLua]
		private UIIntent.LuaExportHelper luaExportHelper;

		// Token: 0x02000105 RID: 261
		public class LuaExportHelper
		{
			// Token: 0x06000A77 RID: 2679 RVA: 0x0002CB04 File Offset: 0x0002AD04
			public LuaExportHelper(UIIntent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x170000FF RID: 255
			// (set) Token: 0x06000A78 RID: 2680 RVA: 0x0002CB14 File Offset: 0x0002AD14
			public string TargetTaskName
			{
				set
				{
					this.m_owner.TargetTaskName = value;
				}
			}

			// Token: 0x04000640 RID: 1600
			private UIIntent m_owner;
		}
	}
}
