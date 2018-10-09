using System;
using System.Collections.Generic;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime.Resource
{
	// Token: 0x02000083 RID: 131
	public class BundleData : ScriptableObject
	{
		// Token: 0x040002E7 RID: 743
		public int m_version = 1;

		// Token: 0x040002E8 RID: 744
		public int m_basicVersion = 1;

		// Token: 0x040002E9 RID: 745
		public List<BundleData.SingleBundleData> m_bundleList = new List<BundleData.SingleBundleData>();

		// Token: 0x02000084 RID: 132
		[Serializable]
		public class SingleBundleData
		{
			// Token: 0x040002EA RID: 746
			public string m_bundleName;

			// Token: 0x040002EB RID: 747
			public int m_version = 1;

			// Token: 0x040002EC RID: 748
			public string m_bundleHash;

			// Token: 0x040002ED RID: 749
			public uint m_bundleCRC;

			// Token: 0x040002EE RID: 750
			public long m_size;

			// Token: 0x040002EF RID: 751
			public bool m_isInStreamingAssets;

			// Token: 0x040002F0 RID: 752
			public bool m_isNeedPreUpdateByDefault;

			// Token: 0x040002F1 RID: 753
			public bool m_isResaveFileBundle;

			// Token: 0x040002F2 RID: 754
			public List<string> m_assetList = new List<string>();
		}
	}
}
