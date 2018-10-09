using System;
using System.Collections.Generic;
using System.Linq;
using BlackJack.ProjectL.Protocol;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000500 RID: 1280
	public class DataSectionUnchartedScore : DataSection
	{
		// Token: 0x06004D83 RID: 19843 RVA: 0x0017AE00 File Offset: 0x00179000
		public DataSectionUnchartedScore()
		{
			this.UnchartedScores = new Dictionary<int, UnchartedScore>();
		}

		// Token: 0x06004D84 RID: 19844 RVA: 0x0017AE14 File Offset: 0x00179014
		public override object SerializeToClient()
		{
			DSUnchartedScoreNtf dsunchartedScoreNtf = new DSUnchartedScoreNtf
			{
				Version = (uint)base.Version
			};
			dsunchartedScoreNtf.UnchartedScores.AddRange(UnchartedScore.ProUnchartedScores2PbProUnchartedScores(this.UnchartedScores.Values.ToList<UnchartedScore>()));
			return dsunchartedScoreNtf;
		}

		// Token: 0x06004D85 RID: 19845 RVA: 0x0017AE58 File Offset: 0x00179058
		public override void ClearInitedData()
		{
			this.UnchartedScores.Clear();
		}

		// Token: 0x06004D86 RID: 19846 RVA: 0x0017AE68 File Offset: 0x00179068
		public void RemoveUnchartedScore(int unchartedScoreId)
		{
			this.UnchartedScores.Remove(unchartedScoreId);
			base.SetDirty(true);
		}

		// Token: 0x170012CB RID: 4811
		// (get) Token: 0x06004D87 RID: 19847 RVA: 0x0017AE80 File Offset: 0x00179080
		// (set) Token: 0x06004D88 RID: 19848 RVA: 0x0017AE88 File Offset: 0x00179088
		public Dictionary<int, UnchartedScore> UnchartedScores { get; set; }
	}
}
