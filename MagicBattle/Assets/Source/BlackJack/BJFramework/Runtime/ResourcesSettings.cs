using System;
using System.Collections.Generic;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x0200003C RID: 60
	[Serializable]
	public class ResourcesSettings
	{
		// Token: 0x04000137 RID: 311
		public bool SkipStreamingAssetsFileProcessing = true;

		// Token: 0x04000138 RID: 312
		public bool DisableAssetBundle = true;

		// Token: 0x04000139 RID: 313
		public bool DisableAssetBundleDownload = true;

		// Token: 0x0400013A RID: 314
		public string AssetBundleDownloadUrlRoot;

		// Token: 0x0400013B RID: 315
		public bool SkipAssetBundlePreUpdateing = true;

		// Token: 0x0400013C RID: 316
		public int PreUpdateWorkerCount = 4;

		// Token: 0x0400013D RID: 317
		public bool LoadAssetFromBundleInEditor;

		// Token: 0x0400013E RID: 318
		public int UnloadUnusedAssetTimeInterval = 10;

		// Token: 0x0400013F RID: 319
		public bool AssetPathIgnoreCase;

		// Token: 0x04000140 RID: 320
		public List<string> ResaveFileDirRoots;

		// Token: 0x04000141 RID: 321
		public string ResaveAssetRoot = "GameProject/RuntimeAssets/ResaveFiles";

		// Token: 0x04000142 RID: 322
		public string ResaveFileDestDir = "Resave";

		// Token: 0x04000143 RID: 323
		[Header("是否开启资源管理器的详细log")]
		public bool EnableDetailResourceManagerLog;
	}
}
