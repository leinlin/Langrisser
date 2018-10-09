using System;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime.TaskNs
{
	// Token: 0x020000C5 RID: 197
	public interface IDynamicAssetProvider
	{
		// Token: 0x06000707 RID: 1799
		UnityEngine.Object AllocDynamicAsset(string name);

		// Token: 0x06000708 RID: 1800
		T AllocDynamicAsset<T>(string name) where T : UnityEngine.Object;

		// Token: 0x06000709 RID: 1801
		void ReleaseDynamicAsset(string name);

		// Token: 0x0600070A RID: 1802
		bool CheckAsset(string resString);
	}
}
