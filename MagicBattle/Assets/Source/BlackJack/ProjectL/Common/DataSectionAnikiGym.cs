using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004BA RID: 1210
	[CustomLuaClass]
	public class DataSectionAnikiGym : DataSection
	{
		// Token: 0x06004A16 RID: 18966 RVA: 0x001737B4 File Offset: 0x001719B4
		public DataSectionAnikiGym()
		{
			this.m_finishedLevels = new HashSet<int>();
			this.m_challengedNums = 0;
		}

		// Token: 0x06004A17 RID: 18967 RVA: 0x001737D0 File Offset: 0x001719D0
		public override void ClearInitedData()
		{
			this.m_finishedLevels.Clear();
		}

		// Token: 0x06004A18 RID: 18968 RVA: 0x001737E0 File Offset: 0x001719E0
		public override object SerializeToClient()
		{
			DSAnikiGymNtf dsanikiGymNtf = new DSAnikiGymNtf();
			dsanikiGymNtf.Version = (uint)base.Version;
			dsanikiGymNtf.FinishedLeves.AddRange(this.m_finishedLevels);
			dsanikiGymNtf.ChallengedNums = this.m_challengedNums;
			return dsanikiGymNtf;
		}

		// Token: 0x06004A19 RID: 18969 RVA: 0x00173820 File Offset: 0x00171A20
		public void InitFinishedLevels(List<int> levels)
		{
			foreach (int item in levels)
			{
				this.m_finishedLevels.Add(item);
			}
		}

		// Token: 0x06004A1A RID: 18970 RVA: 0x00173880 File Offset: 0x00171A80
		public bool IsLevelFinished(int levelId)
		{
			return this.m_finishedLevels.Contains(levelId);
		}

		// Token: 0x06004A1B RID: 18971 RVA: 0x00173890 File Offset: 0x00171A90
		public void AddFinishedLevel(int levelId)
		{
			if (this.m_finishedLevels.Add(levelId))
			{
				base.SetDirty(true);
			}
		}

		// Token: 0x06004A1C RID: 18972 RVA: 0x001738AC File Offset: 0x00171AAC
		public HashSet<int> GetAllFinishedLevels()
		{
			return this.m_finishedLevels;
		}

		// Token: 0x06004A1D RID: 18973 RVA: 0x001738B4 File Offset: 0x00171AB4
		public void InitChallengedNums(int nums)
		{
			this.m_challengedNums = nums;
		}

		// Token: 0x06004A1E RID: 18974 RVA: 0x001738C0 File Offset: 0x00171AC0
		public void SetChallengedNums(int nums)
		{
			this.m_challengedNums = nums;
			base.SetDirty(true);
		}

		// Token: 0x06004A1F RID: 18975 RVA: 0x001738D0 File Offset: 0x00171AD0
		public void AddChallengedNums(int nums)
		{
			this.m_challengedNums += nums;
			base.SetDirty(true);
		}

		// Token: 0x1700125B RID: 4699
		// (get) Token: 0x06004A20 RID: 18976 RVA: 0x001738E8 File Offset: 0x00171AE8
		public int ChallengedNums
		{
			get
			{
				return this.m_challengedNums;
			}
		}

		// Token: 0x0400381D RID: 14365
		private int m_challengedNums;

		// Token: 0x0400381E RID: 14366
		private HashSet<int> m_finishedLevels;
	}
}
