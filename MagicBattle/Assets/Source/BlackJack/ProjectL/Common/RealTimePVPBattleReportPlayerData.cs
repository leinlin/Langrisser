using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000570 RID: 1392
	[CustomLuaClass]
	public class RealTimePVPBattleReportPlayerData
	{
		// Token: 0x17001403 RID: 5123
		// (get) Token: 0x06005102 RID: 20738 RVA: 0x001823BC File Offset: 0x001805BC
		// (set) Token: 0x06005103 RID: 20739 RVA: 0x001823C4 File Offset: 0x001805C4
		public string UserId { get; set; }

		// Token: 0x17001404 RID: 5124
		// (get) Token: 0x06005104 RID: 20740 RVA: 0x001823D0 File Offset: 0x001805D0
		// (set) Token: 0x06005105 RID: 20741 RVA: 0x001823D8 File Offset: 0x001805D8
		public string Name { get; set; }

		// Token: 0x17001405 RID: 5125
		// (get) Token: 0x06005106 RID: 20742 RVA: 0x001823E4 File Offset: 0x001805E4
		// (set) Token: 0x06005107 RID: 20743 RVA: 0x001823EC File Offset: 0x001805EC
		public int HeadIcon { get; set; }

		// Token: 0x17001406 RID: 5126
		// (get) Token: 0x06005108 RID: 20744 RVA: 0x001823F8 File Offset: 0x001805F8
		// (set) Token: 0x06005109 RID: 20745 RVA: 0x00182400 File Offset: 0x00180600
		public int Level { get; set; }

		// Token: 0x0600510A RID: 20746 RVA: 0x0018240C File Offset: 0x0018060C
		public RealTimePVPBattleReportPlayerData DeepCopy()
		{
			RealTimePVPBattleReportPlayerData realTimePVPBattleReportPlayerData = new RealTimePVPBattleReportPlayerData
			{
				UserId = this.UserId,
				HeadIcon = this.HeadIcon,
				Level = this.Level,
				Name = this.Name,
				ScoreDiff = this.ScoreDiff
			};
			realTimePVPBattleReportPlayerData.Heroes.AddRange(this.Heroes);
			realTimePVPBattleReportPlayerData.Techs.AddRange(this.Techs);
			return realTimePVPBattleReportPlayerData;
		}

		// Token: 0x04003A58 RID: 14936
		public List<BattleHero> Heroes = new List<BattleHero>();

		// Token: 0x04003A59 RID: 14937
		public List<TrainingTech> Techs = new List<TrainingTech>();

		// Token: 0x04003A5A RID: 14938
		public int ScoreDiff;
	}
}
