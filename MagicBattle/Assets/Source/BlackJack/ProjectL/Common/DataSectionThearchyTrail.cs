using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004FD RID: 1277
	[CustomLuaClass]
	public class DataSectionThearchyTrail : DataSection
	{
		// Token: 0x06004D6A RID: 19818 RVA: 0x0017A950 File Offset: 0x00178B50
		public DataSectionThearchyTrail()
		{
			this.m_finishedLevels = new HashSet<int>();
			this.m_challengedNums = 0;
		}

		// Token: 0x06004D6B RID: 19819 RVA: 0x0017A96C File Offset: 0x00178B6C
		public override void ClearInitedData()
		{
			this.m_finishedLevels.Clear();
		}

		// Token: 0x06004D6C RID: 19820 RVA: 0x0017A97C File Offset: 0x00178B7C
		public override object SerializeToClient()
		{
			DSThearchyTrialNtf dsthearchyTrialNtf = new DSThearchyTrialNtf();
			dsthearchyTrialNtf.Version = (uint)base.Version;
			dsthearchyTrialNtf.FinishedLeves.AddRange(this.m_finishedLevels);
			dsthearchyTrialNtf.ChallengedNums = this.m_challengedNums;
			return dsthearchyTrialNtf;
		}

		// Token: 0x06004D6D RID: 19821 RVA: 0x0017A9BC File Offset: 0x00178BBC
		public void InitFinishedLevels(List<int> levels)
		{
			foreach (int item in levels)
			{
				this.m_finishedLevels.Add(item);
			}
		}

		// Token: 0x06004D6E RID: 19822 RVA: 0x0017AA1C File Offset: 0x00178C1C
		public bool IsLevelFinished(int levelId)
		{
			return this.m_finishedLevels.Contains(levelId);
		}

		// Token: 0x06004D6F RID: 19823 RVA: 0x0017AA2C File Offset: 0x00178C2C
		public void AddFinishedLevel(int levelId)
		{
			if (this.m_finishedLevels.Add(levelId))
			{
				base.SetDirty(true);
			}
		}

		// Token: 0x06004D70 RID: 19824 RVA: 0x0017AA48 File Offset: 0x00178C48
		public HashSet<int> GetAllFinishedLevels()
		{
			return this.m_finishedLevels;
		}

		// Token: 0x06004D71 RID: 19825 RVA: 0x0017AA50 File Offset: 0x00178C50
		public void InitChallengedNums(int nums)
		{
			this.m_challengedNums = nums;
		}

		// Token: 0x06004D72 RID: 19826 RVA: 0x0017AA5C File Offset: 0x00178C5C
		public void SetChallengedNums(int nums)
		{
			this.m_challengedNums = nums;
			base.SetDirty(true);
		}

		// Token: 0x06004D73 RID: 19827 RVA: 0x0017AA6C File Offset: 0x00178C6C
		public void AddChallengedNums(int nums)
		{
			this.m_challengedNums += nums;
			base.SetDirty(true);
		}

		// Token: 0x170012CA RID: 4810
		// (get) Token: 0x06004D74 RID: 19828 RVA: 0x0017AA84 File Offset: 0x00178C84
		public int ChallengedNums
		{
			get
			{
				return this.m_challengedNums;
			}
		}

		// Token: 0x040038EB RID: 14571
		private int m_challengedNums;

		// Token: 0x040038EC RID: 14572
		private HashSet<int> m_finishedLevels;
	}
}
