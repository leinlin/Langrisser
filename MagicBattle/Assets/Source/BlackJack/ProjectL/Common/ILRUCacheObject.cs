using System;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200057E RID: 1406
	public interface ILRUCacheObject
	{
		// Token: 0x06005173 RID: 20851
		void SetLastUpdateTime();

		// Token: 0x06005174 RID: 20852
		long GetLastUpdateTime();

		// Token: 0x06005175 RID: 20853
		void SetLastReadTime();

		// Token: 0x06005176 RID: 20854
		long GetLastReadTime();

		// Token: 0x06005177 RID: 20855
		long GetNewestTime();
	}
}
