using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200057C RID: 1404
	public class UnchartedScore
	{
		// Token: 0x0600515B RID: 20827 RVA: 0x00183444 File Offset: 0x00181644
		public UnchartedScore(int id)
		{
			this.Id = id;
			this.RewardGains = new HashSet<int>();
			this.SocreLevelCompleteIds = new HashSet<int>();
			this.ChallengeLevelCompleteIds = new HashSet<int>();
		}

		// Token: 0x0600515C RID: 20828 RVA: 0x00183474 File Offset: 0x00181674
		public static List<ProUnchartedScore> ProUnchartedScores2PbProUnchartedScores(List<UnchartedScore> unchartedScores)
		{
			List<ProUnchartedScore> list = new List<ProUnchartedScore>();
			foreach (UnchartedScore unchartedScore in unchartedScores)
			{
				ProUnchartedScore proUnchartedScore = UnchartedScore.UnchartedScore2PbUnchartedScore(unchartedScore);
				if (proUnchartedScore != null)
				{
					list.Add(proUnchartedScore);
				}
			}
			return list;
		}

		// Token: 0x0600515D RID: 20829 RVA: 0x001834E0 File Offset: 0x001816E0
		private static ProUnchartedScore UnchartedScore2PbUnchartedScore(UnchartedScore unchartedScore)
		{
			ProUnchartedScore proUnchartedScore = new ProUnchartedScore
			{
				Id = unchartedScore.Id,
				BonusCount = unchartedScore.BonusCount
			};
			proUnchartedScore.ChallengeLevelCompleteIds.AddRange(unchartedScore.ChallengeLevelCompleteIds);
			proUnchartedScore.SocreLevelCompleteIds.AddRange(unchartedScore.SocreLevelCompleteIds);
			proUnchartedScore.RewardGains.AddRange(unchartedScore.RewardGains);
			proUnchartedScore.Score = unchartedScore.Score;
			return proUnchartedScore;
		}

		// Token: 0x0600515E RID: 20830 RVA: 0x00183550 File Offset: 0x00181750
		public static List<UnchartedScore> PbUnchartedScores(List<ProUnchartedScore> pbUnchartedScores)
		{
			if (UnchartedScore.<>f__mg$cache0 == null)
			{
				UnchartedScore.<>f__mg$cache0 = new Func<ProUnchartedScore, UnchartedScore>(UnchartedScore.PbUnchartedScoreToUnchartedScore);
			}
			return pbUnchartedScores.Select(UnchartedScore.<>f__mg$cache0).ToList<UnchartedScore>();
		}

		// Token: 0x0600515F RID: 20831 RVA: 0x0018357C File Offset: 0x0018177C
		public static UnchartedScore PbUnchartedScoreToUnchartedScore(ProUnchartedScore pbUnchartedScore)
		{
			UnchartedScore unchartedScore = new UnchartedScore(pbUnchartedScore.Id)
			{
				BonusCount = pbUnchartedScore.BonusCount
			};
			foreach (int item in pbUnchartedScore.ChallengeLevelCompleteIds)
			{
				unchartedScore.ChallengeLevelCompleteIds.Add(item);
			}
			foreach (int item2 in pbUnchartedScore.SocreLevelCompleteIds)
			{
				unchartedScore.SocreLevelCompleteIds.Add(item2);
			}
			foreach (int item3 in pbUnchartedScore.RewardGains)
			{
				unchartedScore.RewardGains.Add(item3);
			}
			unchartedScore.Score = pbUnchartedScore.Score;
			return unchartedScore;
		}

		// Token: 0x1700141C RID: 5148
		// (get) Token: 0x06005160 RID: 20832 RVA: 0x001836B0 File Offset: 0x001818B0
		// (set) Token: 0x06005161 RID: 20833 RVA: 0x001836B8 File Offset: 0x001818B8
		public ulong ActivityInstanceId { get; set; }

		// Token: 0x1700141D RID: 5149
		// (get) Token: 0x06005162 RID: 20834 RVA: 0x001836C4 File Offset: 0x001818C4
		// (set) Token: 0x06005163 RID: 20835 RVA: 0x001836CC File Offset: 0x001818CC
		public int Id { get; set; }

		// Token: 0x1700141E RID: 5150
		// (get) Token: 0x06005164 RID: 20836 RVA: 0x001836D8 File Offset: 0x001818D8
		// (set) Token: 0x06005165 RID: 20837 RVA: 0x001836E0 File Offset: 0x001818E0
		public int BonusCount { get; set; }

		// Token: 0x1700141F RID: 5151
		// (get) Token: 0x06005166 RID: 20838 RVA: 0x001836EC File Offset: 0x001818EC
		// (set) Token: 0x06005167 RID: 20839 RVA: 0x001836F4 File Offset: 0x001818F4
		public int Score { get; set; }

		// Token: 0x17001420 RID: 5152
		// (get) Token: 0x06005168 RID: 20840 RVA: 0x00183700 File Offset: 0x00181900
		// (set) Token: 0x06005169 RID: 20841 RVA: 0x00183708 File Offset: 0x00181908
		public HashSet<int> RewardGains { get; set; }

		// Token: 0x17001421 RID: 5153
		// (get) Token: 0x0600516A RID: 20842 RVA: 0x00183714 File Offset: 0x00181914
		// (set) Token: 0x0600516B RID: 20843 RVA: 0x0018371C File Offset: 0x0018191C
		public HashSet<int> SocreLevelCompleteIds { get; set; }

		// Token: 0x17001422 RID: 5154
		// (get) Token: 0x0600516C RID: 20844 RVA: 0x00183728 File Offset: 0x00181928
		// (set) Token: 0x0600516D RID: 20845 RVA: 0x00183730 File Offset: 0x00181930
		public HashSet<int> ChallengeLevelCompleteIds { get; set; }

		// Token: 0x17001423 RID: 5155
		// (get) Token: 0x0600516E RID: 20846 RVA: 0x0018373C File Offset: 0x0018193C
		// (set) Token: 0x0600516F RID: 20847 RVA: 0x00183744 File Offset: 0x00181944
		public ConfigDataUnchartedScoreInfo Config { get; set; }

		// Token: 0x04003A85 RID: 14981
		[CompilerGenerated]
		private static Func<ProUnchartedScore, UnchartedScore> <>f__mg$cache0;
	}
}
