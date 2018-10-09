using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004FA RID: 1274
	[CustomLuaClass]
	public class DataSectionStatisticalData : DataSection
	{
		// Token: 0x06004D45 RID: 19781 RVA: 0x0017A54C File Offset: 0x0017874C
		public DataSectionStatisticalData()
		{
			this.StatisticalData = new Dictionary<int, long>();
		}

		// Token: 0x06004D46 RID: 19782 RVA: 0x0017A560 File Offset: 0x00178760
		public bool IsExistStatisticalData(int typeId)
		{
			return this.StatisticalData.ContainsKey(typeId);
		}

		// Token: 0x06004D47 RID: 19783 RVA: 0x0017A570 File Offset: 0x00178770
		public void AddStatisticalData(int typeId, long nums)
		{
			Dictionary<int, long> statisticalData;
			(statisticalData = this.StatisticalData)[typeId] = statisticalData[typeId] + nums;
			base.SetDirty(true);
		}

		// Token: 0x06004D48 RID: 19784 RVA: 0x0017A5A0 File Offset: 0x001787A0
		public void AddNewStatisticalData(int typeId, long nums)
		{
			this.StatisticalData[typeId] = nums;
			base.SetDirty(true);
		}

		// Token: 0x06004D49 RID: 19785 RVA: 0x0017A5B8 File Offset: 0x001787B8
		public long GetStatisticalDataByTypeId(int typeId)
		{
			return this.StatisticalData[typeId];
		}

		// Token: 0x06004D4A RID: 19786 RVA: 0x0017A5C8 File Offset: 0x001787C8
		public void InitStatisticalData(Dictionary<int, long> dataDict)
		{
			foreach (KeyValuePair<int, long> keyValuePair in dataDict)
			{
				this.StatisticalData[keyValuePair.Key] = keyValuePair.Value;
			}
		}

		// Token: 0x170012C3 RID: 4803
		// (get) Token: 0x06004D4B RID: 19787 RVA: 0x0017A634 File Offset: 0x00178834
		// (set) Token: 0x06004D4C RID: 19788 RVA: 0x0017A63C File Offset: 0x0017883C
		public Dictionary<int, long> StatisticalData { get; set; }
	}
}
