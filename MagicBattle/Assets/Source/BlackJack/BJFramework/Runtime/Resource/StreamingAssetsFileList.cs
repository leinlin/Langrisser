using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime.Resource
{
	// Token: 0x020000B4 RID: 180
	public class StreamingAssetsFileList : ScriptableObject
	{
		// Token: 0x04000463 RID: 1123
		public int m_version;

		// Token: 0x04000464 RID: 1124
		public List<StreamingAssetsFileList.ListItem> m_fileList = new List<StreamingAssetsFileList.ListItem>();

		// Token: 0x020000B5 RID: 181
		[Serializable]
		public class ListItem
		{
			// Token: 0x060006BA RID: 1722 RVA: 0x0001EF2C File Offset: 0x0001D12C
			public ListItem(string path, int version)
			{
				this.m_filePath = path;
				this.m_bundleVersion = version;
				this.m_bundleName = Path.GetFileName(this.m_filePath);
			}

			// Token: 0x04000465 RID: 1125
			public string m_bundleName;

			// Token: 0x04000466 RID: 1126
			public int m_bundleVersion;

			// Token: 0x04000467 RID: 1127
			public string m_filePath;
		}
	}
}
