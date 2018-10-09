using System;
using System.Collections.Generic;

namespace BlackJack.BJFramework.Runtime.Resource
{
	// Token: 0x02000085 RID: 133
	public class BundleDataHelper
	{
		// Token: 0x060005A7 RID: 1447 RVA: 0x00018E58 File Offset: 0x00017058
		public BundleDataHelper(BundleData bundleData, bool assetPathIgnoreCase)
		{
			this.m_internalBundleData = bundleData;
			this.m_assetPathIgnoreCase = assetPathIgnoreCase;
			this.m_internalBundleData.m_bundleList.ForEach(delegate(BundleData.SingleBundleData elem)
			{
				this.m_bundleDataDict.Add(elem.m_bundleName, elem);
			});
			this.m_internalBundleData.m_bundleList.ForEach(delegate(BundleData.SingleBundleData elem)
			{
				elem.m_assetList.ForEach(delegate(string assetPath)
				{
					this.m_assetPath2BundleDataDict.Add((!this.m_assetPathIgnoreCase) ? assetPath : assetPath.ToLower(), elem);
				});
			});
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00018ECC File Offset: 0x000170CC
		public int GetBundleVersionByName(string name)
		{
			if (name == PathHelper.BundleDataBundleName)
			{
				return this.m_internalBundleData.m_version;
			}
			BundleData.SingleBundleData singleBundleData;
			if (!this.m_bundleDataDict.TryGetValue(name, out singleBundleData))
			{
				return -1;
			}
			return singleBundleData.m_version;
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00018F10 File Offset: 0x00017110
		public BundleData.SingleBundleData GetBundleDataByName(string name)
		{
			BundleData.SingleBundleData result;
			if (!this.m_bundleDataDict.TryGetValue(name, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00018F34 File Offset: 0x00017134
		public BundleData.SingleBundleData GetBundleDataByAssetPath(string assetPath)
		{
			BundleData.SingleBundleData result;
			if (!this.m_assetPath2BundleDataDict.TryGetValue((!this.m_assetPathIgnoreCase) ? assetPath : assetPath.ToLower(), out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00018F70 File Offset: 0x00017170
		public BundleData.SingleBundleData GetResaveFileBundleDataByPath(string relativePath)
		{
			return this.GetBundleDataByAssetPath(relativePath);
		}

		// Token: 0x040002F3 RID: 755
		private BundleData m_internalBundleData;

		// Token: 0x040002F4 RID: 756
		private bool m_assetPathIgnoreCase;

		// Token: 0x040002F5 RID: 757
		private Dictionary<string, BundleData.SingleBundleData> m_bundleDataDict = new Dictionary<string, BundleData.SingleBundleData>();

		// Token: 0x040002F6 RID: 758
		private Dictionary<string, BundleData.SingleBundleData> m_assetPath2BundleDataDict = new Dictionary<string, BundleData.SingleBundleData>(StringComparer.OrdinalIgnoreCase);
	}
}
