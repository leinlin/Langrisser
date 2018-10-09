using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004E1 RID: 1249
	[CustomLuaClass]
	public class DataSectionHeroTrainning : DataSection
	{
		// Token: 0x06004BC7 RID: 19399 RVA: 0x001773D0 File Offset: 0x001755D0
		public DataSectionHeroTrainning()
		{
			this.m_finishedLevels = new HashSet<int>();
			this.m_challengedNums = 0;
		}

		// Token: 0x06004BC8 RID: 19400 RVA: 0x001773EC File Offset: 0x001755EC
		public override void ClearInitedData()
		{
			this.m_finishedLevels.Clear();
		}

		// Token: 0x06004BC9 RID: 19401 RVA: 0x001773FC File Offset: 0x001755FC
		public override object SerializeToClient()
		{
			DSHeroTrainningNtf dsheroTrainningNtf = new DSHeroTrainningNtf();
			dsheroTrainningNtf.Version = (uint)base.Version;
			dsheroTrainningNtf.FinishedLeves.AddRange(this.m_finishedLevels);
			dsheroTrainningNtf.ChallengedNums = this.m_challengedNums;
			return dsheroTrainningNtf;
		}

		// Token: 0x06004BCA RID: 19402 RVA: 0x0017743C File Offset: 0x0017563C
		public void InitFinishedLevels(List<int> levels)
		{
			foreach (int item in levels)
			{
				this.m_finishedLevels.Add(item);
			}
		}

		// Token: 0x06004BCB RID: 19403 RVA: 0x0017749C File Offset: 0x0017569C
		public bool IsLevelFinished(int levelId)
		{
			return this.m_finishedLevels.Contains(levelId);
		}

		// Token: 0x06004BCC RID: 19404 RVA: 0x001774AC File Offset: 0x001756AC
		public void AddFinishedLevel(int levelId)
		{
			if (this.m_finishedLevels.Add(levelId))
			{
				base.SetDirty(true);
			}
		}

		// Token: 0x06004BCD RID: 19405 RVA: 0x001774C8 File Offset: 0x001756C8
		public HashSet<int> GetAllFinishedLevels()
		{
			return this.m_finishedLevels;
		}

		// Token: 0x06004BCE RID: 19406 RVA: 0x001774D0 File Offset: 0x001756D0
		public void InitChallengedNums(int nums)
		{
			this.m_challengedNums = nums;
		}

		// Token: 0x06004BCF RID: 19407 RVA: 0x001774DC File Offset: 0x001756DC
		public void SetChallengedNums(int nums)
		{
			this.m_challengedNums = nums;
			base.SetDirty(true);
		}

		// Token: 0x06004BD0 RID: 19408 RVA: 0x001774EC File Offset: 0x001756EC
		public void AddChallengedNums(int nums)
		{
			this.m_challengedNums += nums;
			base.SetDirty(true);
		}

		// Token: 0x17001295 RID: 4757
		// (get) Token: 0x06004BD1 RID: 19409 RVA: 0x00177504 File Offset: 0x00175704
		public int ChallengedNums
		{
			get
			{
				return this.m_challengedNums;
			}
		}

		// Token: 0x0400387F RID: 14463
		private int m_challengedNums;

		// Token: 0x04003880 RID: 14464
		private HashSet<int> m_finishedLevels;
	}
}
