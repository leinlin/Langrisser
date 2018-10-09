using System;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x02000041 RID: 65
	[Serializable]
	public class ConfigDataSettings
	{
		// Token: 0x06000364 RID: 868 RVA: 0x00010940 File Offset: 0x0000EB40
		public string GetConfigDataAssetTargetPath()
		{
			return this.ConfigDataAssetTargetPath;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00010948 File Offset: 0x0000EB48
		public string GetConfigDataAssetPathNoPostfix(string fileName)
		{
			return string.Format("{0}/{1}", this.ConfigDataAssetTargetPath, fileName);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0001095C File Offset: 0x0000EB5C
		public string GetConfigDataAssetPath(string fileName)
		{
			return string.Format("{0}/{1}.asset", this.ConfigDataAssetTargetPath, fileName);
		}

		// Token: 0x04000150 RID: 336
		public string ConfigDataLoaderTypeDNName = "Assembly-CSharp@BlackJack.ConfigData.ClientConfigDataLoader";

		// Token: 0x04000151 RID: 337
		public bool ConfigDataAssetAllowNullSetting = true;

		// Token: 0x04000152 RID: 338
		public string StringTableManagerTypeDNName;

		// Token: 0x04000153 RID: 339
		public bool ConfigDataAllowMD5NotMach;

		// Token: 0x04000154 RID: 340
		public string ConfigDataAssetTargetPath = "Assets/GameProject/RuntimeAssets/ConfigData/ConfigData_ABS";

		// Token: 0x04000155 RID: 341
		[Header("初始化的线程个数")]
		public int InitThreadCount = 4;

		// Token: 0x04000156 RID: 342
		[Header("初始化时加载多少个yeildreturn一次")]
		public int InitloadCountForSingleYield = 20;
	}
}
