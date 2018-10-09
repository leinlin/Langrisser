using System;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200057D RID: 1405
	[CustomLuaClass]
	public class CacheObject
	{
		// Token: 0x06005170 RID: 20848 RVA: 0x00183750 File Offset: 0x00181950
		public CacheObject()
		{
			this.Dirty = false;
		}

		// Token: 0x17001424 RID: 5156
		// (get) Token: 0x06005171 RID: 20849 RVA: 0x00183760 File Offset: 0x00181960
		// (set) Token: 0x06005172 RID: 20850 RVA: 0x00183768 File Offset: 0x00181968
		public bool Dirty { get; set; }
	}
}
