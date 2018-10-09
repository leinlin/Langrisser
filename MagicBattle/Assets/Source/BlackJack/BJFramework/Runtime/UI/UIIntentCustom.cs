using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.BJFramework.Runtime.UI
{
	// Token: 0x02000106 RID: 262
	[CustomLuaClassWithProtected]
	public class UIIntentCustom : UIIntent
	{
		// Token: 0x06000A79 RID: 2681 RVA: 0x0002CB24 File Offset: 0x0002AD24
		public UIIntentCustom(string targetTaskName, string targetMode = null) : base(targetTaskName, targetMode)
		{
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x0002CB3C File Offset: 0x0002AD3C
		public void SetParam(string key, object value)
		{
			this.m_params[key] = value;
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x0002CB4C File Offset: 0x0002AD4C
		public bool TryGetParam(string key, out object value)
		{
			return this.m_params.TryGetValue(key, out value);
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x0002CB5C File Offset: 0x0002AD5C
		public T GetClassParam<T>(string key) where T : class
		{
			object obj;
			if (this.TryGetParam(key, out obj))
			{
				return obj as T;
			}
			return (T)((object)null);
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x0002CB8C File Offset: 0x0002AD8C
		public T GetStructParam<T>(string key) where T : struct
		{
			object obj;
			if (this.TryGetParam(key, out obj))
			{
				return (T)((object)obj);
			}
			return default(T);
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x0002CBB8 File Offset: 0x0002ADB8
		// (set) Token: 0x06000A7F RID: 2687 RVA: 0x0002CBD8 File Offset: 0x0002ADD8
		[DoNotToLua]
		public new UIIntentCustom.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new UIIntentCustom.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x04000641 RID: 1601
		private Dictionary<string, object> m_params = new Dictionary<string, object>();

		// Token: 0x04000642 RID: 1602
		[DoNotToLua]
		private UIIntentCustom.LuaExportHelper luaExportHelper;

		// Token: 0x02000107 RID: 263
		public new class LuaExportHelper
		{
			// Token: 0x06000A80 RID: 2688 RVA: 0x0002CBE4 File Offset: 0x0002ADE4
			public LuaExportHelper(UIIntentCustom owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17000101 RID: 257
			// (get) Token: 0x06000A81 RID: 2689 RVA: 0x0002CBF4 File Offset: 0x0002ADF4
			// (set) Token: 0x06000A82 RID: 2690 RVA: 0x0002CC04 File Offset: 0x0002AE04
			public Dictionary<string, object> m_params
			{
				get
				{
					return this.m_owner.m_params;
				}
				set
				{
					this.m_owner.m_params = value;
				}
			}

			// Token: 0x04000643 RID: 1603
			private UIIntentCustom m_owner;
		}
	}
}
