using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004BF RID: 1215
	[CustomLuaClass]
	public class DataSectionArenaBattleReport : DataSection
	{
		// Token: 0x06004A50 RID: 19024 RVA: 0x00173DC8 File Offset: 0x00171FC8
		public DataSectionArenaBattleReport()
		{
			this.ArenaBattleReportInfo = new ArenaBattleReportUpdateCache();
			this.m_instanceId2CacheIndex = new Dictionary<ulong, int>();
		}

		// Token: 0x06004A51 RID: 19025 RVA: 0x00173DE8 File Offset: 0x00171FE8
		public override void ClearInitedData()
		{
			this.ArenaBattleReportInfo = new ArenaBattleReportUpdateCache();
			this.m_instanceId2CacheIndex.Clear();
		}

		// Token: 0x06004A52 RID: 19026 RVA: 0x00173E00 File Offset: 0x00172000
		public void InitArenaBattleReport(ArenaBattleReport report)
		{
			int value = this.ArenaBattleReportInfo.Init(report);
			this.m_instanceId2CacheIndex.Add(report.InstanceId, value);
		}

		// Token: 0x06004A53 RID: 19027 RVA: 0x00173E2C File Offset: 0x0017202C
		public void SetArenaBattleReport(int index, ArenaBattleReport report)
		{
			UpdateCache<ArenaBattleReport> updateCache = this.ArenaBattleReportInfo.Find(index);
			this.m_instanceId2CacheIndex.Remove(updateCache.Data.InstanceId);
			this.ArenaBattleReportInfo.Set(index, report);
			this.m_instanceId2CacheIndex.Add(report.InstanceId, index);
			base.SetDirty(true);
		}

		// Token: 0x06004A54 RID: 19028 RVA: 0x00173E84 File Offset: 0x00172084
		public void AddArenaBattleReport(ArenaBattleReport report)
		{
			int value = this.ArenaBattleReportInfo.Add(report);
			this.m_instanceId2CacheIndex.Add(report.InstanceId, value);
			base.SetDirty(true);
		}

		// Token: 0x06004A55 RID: 19029 RVA: 0x00173EB8 File Offset: 0x001720B8
		public void DirtyArenaBattleReport(ulong battleReportInstanceId)
		{
			UpdateCache<ArenaBattleReport> updateCache = this.ArenaBattleReportInfo.Find(this.m_instanceId2CacheIndex[battleReportInstanceId]);
			updateCache.Dirty = true;
			base.SetDirty(true);
		}

		// Token: 0x06004A56 RID: 19030 RVA: 0x00173EEC File Offset: 0x001720EC
		public List<ArenaBattleReport> GetAllArenaBattleReports()
		{
			return this.ArenaBattleReportInfo.GetAllVaildDatas();
		}

		// Token: 0x06004A57 RID: 19031 RVA: 0x00173EFC File Offset: 0x001720FC
		public ArenaBattleReport FindArenaBattleReportByInstanceId(ulong battleReportInstanceId)
		{
			if (!this.m_instanceId2CacheIndex.ContainsKey(battleReportInstanceId))
			{
				return null;
			}
			UpdateCache<ArenaBattleReport> updateCache = this.ArenaBattleReportInfo.Find(this.m_instanceId2CacheIndex[battleReportInstanceId]);
			if (updateCache == null)
			{
				return null;
			}
			return updateCache.Data;
		}

		// Token: 0x06004A58 RID: 19032 RVA: 0x00173F44 File Offset: 0x00172144
		public void SetNextBattleReportIndex(byte index)
		{
			this.NextBattleReportIndex = index;
			base.SetDirty(true);
		}

		// Token: 0x1700125E RID: 4702
		// (get) Token: 0x06004A59 RID: 19033 RVA: 0x00173F54 File Offset: 0x00172154
		// (set) Token: 0x06004A5A RID: 19034 RVA: 0x00173F5C File Offset: 0x0017215C
		public byte NextBattleReportIndex { get; set; }

		// Token: 0x1700125F RID: 4703
		// (get) Token: 0x06004A5B RID: 19035 RVA: 0x00173F68 File Offset: 0x00172168
		public int BattleReportNums
		{
			get
			{
				return this.m_instanceId2CacheIndex.Count;
			}
		}

		// Token: 0x17001260 RID: 4704
		// (get) Token: 0x06004A5C RID: 19036 RVA: 0x00173F78 File Offset: 0x00172178
		// (set) Token: 0x06004A5D RID: 19037 RVA: 0x00173F80 File Offset: 0x00172180
		public ArenaBattleReportUpdateCache ArenaBattleReportInfo { get; set; }

		// Token: 0x04003825 RID: 14373
		private Dictionary<ulong, int> m_instanceId2CacheIndex;
	}
}
