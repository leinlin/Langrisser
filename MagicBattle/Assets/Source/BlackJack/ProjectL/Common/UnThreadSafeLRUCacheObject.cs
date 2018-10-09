using System;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200057F RID: 1407
	[CustomLuaClass]
	public class UnThreadSafeLRUCacheObject : CacheObject, ILRUCacheObject
	{
		// Token: 0x06005179 RID: 20857 RVA: 0x0018377C File Offset: 0x0018197C
		public void SetLastUpdateTime()
		{
			this.m_lastUpdateTime += 1L;
		}

		// Token: 0x0600517A RID: 20858 RVA: 0x00183790 File Offset: 0x00181990
		public long GetLastUpdateTime()
		{
			return this.m_lastUpdateTime;
		}

		// Token: 0x0600517B RID: 20859 RVA: 0x00183798 File Offset: 0x00181998
		public void SetLastReadTime()
		{
			this.m_lastReadTime += 1L;
		}

		// Token: 0x0600517C RID: 20860 RVA: 0x001837AC File Offset: 0x001819AC
		public long GetLastReadTime()
		{
			return this.m_lastReadTime;
		}

		// Token: 0x0600517D RID: 20861 RVA: 0x001837B4 File Offset: 0x001819B4
		public long GetNewestTime()
		{
			return (this.m_lastReadTime < this.m_lastUpdateTime) ? this.m_lastUpdateTime : this.m_lastReadTime;
		}

		// Token: 0x04003A87 RID: 14983
		private long m_lastReadTime;

		// Token: 0x04003A88 RID: 14984
		private long m_lastUpdateTime;
	}
}
