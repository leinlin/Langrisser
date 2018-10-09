using System;
using SLua;

namespace BlackJack.BJFramework.Runtime.TaskNs
{
	// Token: 0x020000C6 RID: 198
	[CustomLuaClassWithProtected]
	public class MapSceneUpdatePipeLineCtxBase
	{
		// Token: 0x0600070C RID: 1804 RVA: 0x00020C08 File Offset: 0x0001EE08
		public virtual bool Start()
		{
			if (this.m_runing)
			{
				return false;
			}
			this.m_runing = true;
			return true;
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00020C20 File Offset: 0x0001EE20
		public virtual void Clear()
		{
			this.m_runing = false;
			this.m_loadingStaticResCorutineCount = 0;
			this.m_loadingDynamicResCorutineCount = 0;
			this.m_updateViewAction = null;
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00020C40 File Offset: 0x0001EE40
		public bool IsRunning()
		{
			return this.m_runing;
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600070F RID: 1807 RVA: 0x00020C48 File Offset: 0x0001EE48
		// (set) Token: 0x06000710 RID: 1808 RVA: 0x00020C68 File Offset: 0x0001EE68
		[DoNotToLua]
		public MapSceneUpdatePipeLineCtxBase.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new MapSceneUpdatePipeLineCtxBase.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x040004BD RID: 1213
		protected bool m_runing;

		// Token: 0x040004BE RID: 1214
		public bool m_lockResCache;

		// Token: 0x040004BF RID: 1215
		public int m_loadingStaticResCorutineCount;

		// Token: 0x040004C0 RID: 1216
		public int m_loadingDynamicResCorutineCount;

		// Token: 0x040004C1 RID: 1217
		public Action m_updateViewAction;

		// Token: 0x040004C2 RID: 1218
		[DoNotToLua]
		private MapSceneUpdatePipeLineCtxBase.LuaExportHelper luaExportHelper;

		// Token: 0x020000C7 RID: 199
		public class LuaExportHelper
		{
			// Token: 0x06000711 RID: 1809 RVA: 0x00020C74 File Offset: 0x0001EE74
			public LuaExportHelper(MapSceneUpdatePipeLineCtxBase owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x170000AC RID: 172
			// (get) Token: 0x06000712 RID: 1810 RVA: 0x00020C84 File Offset: 0x0001EE84
			// (set) Token: 0x06000713 RID: 1811 RVA: 0x00020C94 File Offset: 0x0001EE94
			public bool m_runing
			{
				get
				{
					return this.m_owner.m_runing;
				}
				set
				{
					this.m_owner.m_runing = value;
				}
			}

			// Token: 0x040004C3 RID: 1219
			private MapSceneUpdatePipeLineCtxBase m_owner;
		}
	}
}
