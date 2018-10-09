using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004FF RID: 1279
	[CustomLuaClass]
	public class DataSectionTreasureMap : DataSection
	{
		// Token: 0x06004D7C RID: 19836 RVA: 0x0017AD14 File Offset: 0x00178F14
		public DataSectionTreasureMap()
		{
			this.m_finishedLevels = new HashSet<int>();
		}

		// Token: 0x06004D7D RID: 19837 RVA: 0x0017AD28 File Offset: 0x00178F28
		public override void ClearInitedData()
		{
			this.m_finishedLevels.Clear();
		}

		// Token: 0x06004D7E RID: 19838 RVA: 0x0017AD38 File Offset: 0x00178F38
		public override object SerializeToClient()
		{
			DSTreasureMapNtf dstreasureMapNtf = new DSTreasureMapNtf();
			dstreasureMapNtf.FinishedLeves.AddRange(this.m_finishedLevels);
			dstreasureMapNtf.Version = (uint)base.Version;
			return dstreasureMapNtf;
		}

		// Token: 0x06004D7F RID: 19839 RVA: 0x0017AD6C File Offset: 0x00178F6C
		public void InitFinishedLevels(List<int> levels)
		{
			foreach (int item in levels)
			{
				this.m_finishedLevels.Add(item);
			}
		}

		// Token: 0x06004D80 RID: 19840 RVA: 0x0017ADCC File Offset: 0x00178FCC
		public bool IsLevelFinished(int levelId)
		{
			return this.m_finishedLevels.Contains(levelId);
		}

		// Token: 0x06004D81 RID: 19841 RVA: 0x0017ADDC File Offset: 0x00178FDC
		public void AddFinishedLevel(int levelId)
		{
			if (this.m_finishedLevels.Add(levelId))
			{
				base.SetDirty(true);
			}
		}

		// Token: 0x06004D82 RID: 19842 RVA: 0x0017ADF8 File Offset: 0x00178FF8
		public HashSet<int> GetAllFinishedLevels()
		{
			return this.m_finishedLevels;
		}

		// Token: 0x040038EE RID: 14574
		private HashSet<int> m_finishedLevels;
	}
}
