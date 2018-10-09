using System;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004F3 RID: 1267
	[CustomLuaClass]
	public class RealTimePVPMatchStats
	{
		// Token: 0x06004CDA RID: 19674 RVA: 0x001797AC File Offset: 0x001779AC
		public void AddWins()
		{
			this.Wins++;
			this.ConsecutiveLosses = 0;
			this.ConsecutiveWins++;
			this.Matches++;
		}

		// Token: 0x06004CDB RID: 19675 RVA: 0x001797E0 File Offset: 0x001779E0
		public void AddLosses()
		{
			this.ConsecutiveLosses++;
			this.ConsecutiveWins = 0;
			this.Matches++;
		}

		// Token: 0x06004CDC RID: 19676 RVA: 0x00179808 File Offset: 0x00177A08
		public RealTimePVPMatchStats DeepDuplicate()
		{
			return new RealTimePVPMatchStats
			{
				ConsecutiveLosses = this.ConsecutiveLosses,
				ConsecutiveWins = this.ConsecutiveWins,
				Matches = this.Matches,
				Wins = this.Wins
			};
		}

		// Token: 0x040038CC RID: 14540
		public int Matches;

		// Token: 0x040038CD RID: 14541
		public int Wins;

		// Token: 0x040038CE RID: 14542
		public int ConsecutiveWins;

		// Token: 0x040038CF RID: 14543
		public int ConsecutiveLosses;
	}
}
