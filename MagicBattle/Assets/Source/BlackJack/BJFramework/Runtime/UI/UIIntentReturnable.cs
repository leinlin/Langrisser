using System;
using SLua;

namespace BlackJack.BJFramework.Runtime.UI
{
	// Token: 0x02000108 RID: 264
	[CustomLuaClassWithProtected]
	public class UIIntentReturnable : UIIntentCustom
	{
		// Token: 0x06000A83 RID: 2691 RVA: 0x0002CC14 File Offset: 0x0002AE14
		public UIIntentReturnable(UIIntent prevTaskIntent, string targetTaskName, string targetMode = null) : base(targetTaskName, targetMode)
		{
			this.PrevTaskIntent = prevTaskIntent;
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x0002CC34 File Offset: 0x0002AE34
		// (set) Token: 0x06000A84 RID: 2692 RVA: 0x0002CC28 File Offset: 0x0002AE28
		public UIIntent PrevTaskIntent { get; set; }

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000A86 RID: 2694 RVA: 0x0002CC3C File Offset: 0x0002AE3C
		// (set) Token: 0x06000A87 RID: 2695 RVA: 0x0002CC5C File Offset: 0x0002AE5C
		[DoNotToLua]
		public new UIIntentReturnable.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new UIIntentReturnable.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x0002CC68 File Offset: 0x0002AE68
		private void __callBase_SetParam(string key, object value)
		{
			base.SetParam(key, value);
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x0002CC74 File Offset: 0x0002AE74
		private bool __callBase_TryGetParam(string key, out object value)
		{
			return base.TryGetParam(key, out value);
		}

		// Token: 0x04000645 RID: 1605
		[DoNotToLua]
		private UIIntentReturnable.LuaExportHelper luaExportHelper;

		// Token: 0x02000109 RID: 265
		public new class LuaExportHelper
		{
			// Token: 0x06000A8A RID: 2698 RVA: 0x0002CC80 File Offset: 0x0002AE80
			public LuaExportHelper(UIIntentReturnable owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06000A8B RID: 2699 RVA: 0x0002CC90 File Offset: 0x0002AE90
			public void __callBase_SetParam(string key, object value)
			{
				this.m_owner.__callBase_SetParam(key, value);
			}

			// Token: 0x06000A8C RID: 2700 RVA: 0x0002CCA0 File Offset: 0x0002AEA0
			public bool __callBase_TryGetParam(string key, out object value)
			{
				return this.m_owner.__callBase_TryGetParam(key, out value);
			}

			// Token: 0x04000646 RID: 1606
			private UIIntentReturnable m_owner;
		}
	}
}
