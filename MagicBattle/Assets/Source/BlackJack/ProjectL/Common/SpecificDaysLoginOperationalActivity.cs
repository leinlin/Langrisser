using System;
using System.Collections.Generic;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200055F RID: 1375
	[CustomLuaClass]
	public class SpecificDaysLoginOperationalActivity : AwardOperationalActivityBase
	{
		// Token: 0x0600507B RID: 20603 RVA: 0x00180FE4 File Offset: 0x0017F1E4
		public SpecificDaysLoginOperationalActivity()
		{
			this.SpecificLoginTimes = new List<long>();
		}

		// Token: 0x0600507C RID: 20604 RVA: 0x00180FF8 File Offset: 0x0017F1F8
		public SpecificDaysLoginOperationalActivity(ulong instanceId, int operationalActivityId, OperationalActivityType operationalActivityType) : base(instanceId, operationalActivityId, operationalActivityType)
		{
			this.SpecificLoginTimes = new List<long>();
		}

		// Token: 0x0600507D RID: 20605 RVA: 0x00181010 File Offset: 0x0017F210
		public void DeserializeFromPB(ProSpecificDaysLoginOperationalActivity pbOperationalActivity, ConfigDataOperationalActivityInfo config)
		{
			base.OperationStartTime = new DateTime(pbOperationalActivity.BasicInfo.OperationStartTime);
			base.OperationEndTime = new DateTime(pbOperationalActivity.BasicInfo.OperationEndTime);
			base.GainRewardEndTime = new DateTime(pbOperationalActivity.BasicInfo.GainRewardEndTime);
			this.SpecificLoginTimes.AddRange(pbOperationalActivity.SpecificLoginTimes);
			base.GainedRewardIndexs.AddRange(pbOperationalActivity.GainRewardIndexs);
			base.Config = config;
		}

		// Token: 0x0600507E RID: 20606 RVA: 0x00181088 File Offset: 0x0017F288
		public override void ToPBNtf(DSOperationalActivityNtf ntf)
		{
			ntf.SpecificDaysLoginAwardOperationalActivities.Add(this.SerializeToPB());
		}

		// Token: 0x0600507F RID: 20607 RVA: 0x0018109C File Offset: 0x0017F29C
		public ProSpecificDaysLoginOperationalActivity SerializeToPB()
		{
			ProSpecificDaysLoginOperationalActivity proSpecificDaysLoginOperationalActivity = new ProSpecificDaysLoginOperationalActivity();
			proSpecificDaysLoginOperationalActivity.BasicInfo = base.ToPBOperationalActivityBasicData();
			proSpecificDaysLoginOperationalActivity.SpecificLoginTimes.AddRange(this.SpecificLoginTimes);
			proSpecificDaysLoginOperationalActivity.GainRewardIndexs.AddRange(base.GainedRewardIndexs);
			return proSpecificDaysLoginOperationalActivity;
		}

		// Token: 0x06005080 RID: 20608 RVA: 0x001810E0 File Offset: 0x0017F2E0
		public override int CanGainRewardByIndex(int rewardIndex, DateTime currentTime)
		{
			int num = base.CanGainRewardByIndex(rewardIndex, currentTime);
			if (num != 0)
			{
				return num;
			}
			int parm = base.Config.OperationalActivityParms[rewardIndex].Parm1;
			foreach (long ticks in this.SpecificLoginTimes)
			{
				if ((int)(new DateTime(ticks) - base.GetInitialTimeInOneDay(base.OperationStartTime)).TotalDays + 1 == parm)
				{
					return 0;
				}
			}
			return -2209;
		}

		// Token: 0x170013E1 RID: 5089
		// (get) Token: 0x06005081 RID: 20609 RVA: 0x00181198 File Offset: 0x0017F398
		// (set) Token: 0x06005082 RID: 20610 RVA: 0x001811A0 File Offset: 0x0017F3A0
		public List<long> SpecificLoginTimes { get; set; }
	}
}
