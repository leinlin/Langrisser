using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004E5 RID: 1253
	[CustomLuaClass]
	public class DataSectionMemoryCorridor : DataSection
	{
		// Token: 0x06004C0E RID: 19470 RVA: 0x00177CF4 File Offset: 0x00175EF4
		public DataSectionMemoryCorridor()
		{
			this.m_finishedLevels = new HashSet<int>();
			this.m_challengedNums = 0;
		}

		// Token: 0x06004C0F RID: 19471 RVA: 0x00177D10 File Offset: 0x00175F10
		public override void ClearInitedData()
		{
			this.m_finishedLevels.Clear();
		}

		// Token: 0x06004C10 RID: 19472 RVA: 0x00177D20 File Offset: 0x00175F20
		public override object SerializeToClient()
		{
			DSMemoryCorridorNtf dsmemoryCorridorNtf = new DSMemoryCorridorNtf();
			dsmemoryCorridorNtf.Version = (uint)base.Version;
			dsmemoryCorridorNtf.FinishedLeves.AddRange(this.m_finishedLevels);
			dsmemoryCorridorNtf.ChallengedNums = this.m_challengedNums;
			return dsmemoryCorridorNtf;
		}

		// Token: 0x06004C11 RID: 19473 RVA: 0x00177D60 File Offset: 0x00175F60
		public void InitFinishedLevels(List<int> levels)
		{
			foreach (int item in levels)
			{
				this.m_finishedLevels.Add(item);
			}
		}

		// Token: 0x06004C12 RID: 19474 RVA: 0x00177DC0 File Offset: 0x00175FC0
		public bool IsLevelFinished(int levelId)
		{
			return this.m_finishedLevels.Contains(levelId);
		}

		// Token: 0x06004C13 RID: 19475 RVA: 0x00177DD0 File Offset: 0x00175FD0
		public void AddFinishedLevel(int levelId)
		{
			if (this.m_finishedLevels.Add(levelId))
			{
				base.SetDirty(true);
			}
		}

		// Token: 0x06004C14 RID: 19476 RVA: 0x00177DEC File Offset: 0x00175FEC
		public HashSet<int> GetAllFinishedLevels()
		{
			return this.m_finishedLevels;
		}

		// Token: 0x06004C15 RID: 19477 RVA: 0x00177DF4 File Offset: 0x00175FF4
		public void InitChallengedNums(int nums)
		{
			this.m_challengedNums = nums;
		}

		// Token: 0x06004C16 RID: 19478 RVA: 0x00177E00 File Offset: 0x00176000
		public void SetChallengedNums(int nums)
		{
			this.m_challengedNums = nums;
			base.SetDirty(true);
		}

		// Token: 0x06004C17 RID: 19479 RVA: 0x00177E10 File Offset: 0x00176010
		public void AddChallengedNums(int nums)
		{
			this.m_challengedNums += nums;
			base.SetDirty(true);
		}

		// Token: 0x1700129C RID: 4764
		// (get) Token: 0x06004C18 RID: 19480 RVA: 0x00177E28 File Offset: 0x00176028
		public int ChallengedNums
		{
			get
			{
				return this.m_challengedNums;
			}
		}

		// Token: 0x0400388B RID: 14475
		private int m_challengedNums;

		// Token: 0x0400388C RID: 14476
		private HashSet<int> m_finishedLevels;
	}
}
