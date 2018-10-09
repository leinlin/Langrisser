using System;
using System.Collections.Generic;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000560 RID: 1376
	[CustomLuaClass]
	public class AccumulateLoginOperationalActivity : AwardOperationalActivityBase
	{
		// Token: 0x06005083 RID: 20611 RVA: 0x001811AC File Offset: 0x0017F3AC
		public AccumulateLoginOperationalActivity()
		{
			this.SpecificLoginTimes = new List<long>();
		}

		// Token: 0x06005084 RID: 20612 RVA: 0x001811C0 File Offset: 0x0017F3C0
		public AccumulateLoginOperationalActivity(ulong instanceId, int operationalActivityId, OperationalActivityType operationalActivityType) : base(instanceId, operationalActivityId, operationalActivityType)
		{
			this.SpecificLoginTimes = new List<long>();
		}

		// Token: 0x06005085 RID: 20613 RVA: 0x001811D8 File Offset: 0x0017F3D8
		public void DeserializeFromPB(ProAccumulateLoginOperationalActivity pbOperationalActivity, ConfigDataOperationalActivityInfo config)
		{
			base.OperationStartTime = new DateTime(pbOperationalActivity.BasicInfo.OperationStartTime);
			base.OperationEndTime = new DateTime(pbOperationalActivity.BasicInfo.OperationEndTime);
			base.GainRewardEndTime = new DateTime(pbOperationalActivity.BasicInfo.GainRewardEndTime);
			this.SpecificLoginTimes.AddRange(pbOperationalActivity.SpecificLoginTimes);
			base.GainedRewardIndexs.AddRange(pbOperationalActivity.GainRewardIndexs);
			base.Config = config;
		}

		// Token: 0x06005086 RID: 20614 RVA: 0x00181250 File Offset: 0x0017F450
		public override void ToPBNtf(DSOperationalActivityNtf ntf)
		{
			ntf.AccumulateLoginAwardOperationalActivities.Add(this.SerializeToPB());
		}

		// Token: 0x06005087 RID: 20615 RVA: 0x00181264 File Offset: 0x0017F464
		public ProAccumulateLoginOperationalActivity SerializeToPB()
		{
			ProAccumulateLoginOperationalActivity proAccumulateLoginOperationalActivity = new ProAccumulateLoginOperationalActivity();
			proAccumulateLoginOperationalActivity.BasicInfo = base.ToPBOperationalActivityBasicData();
			proAccumulateLoginOperationalActivity.GainRewardIndexs.AddRange(base.GainedRewardIndexs);
			proAccumulateLoginOperationalActivity.SpecificLoginTimes.AddRange(this.SpecificLoginTimes);
			return proAccumulateLoginOperationalActivity;
		}

		// Token: 0x06005088 RID: 20616 RVA: 0x001812A8 File Offset: 0x0017F4A8
		public override int CanGainRewardByIndex(int rewardIndex, DateTime currentTime)
		{
			int num = base.CanGainRewardByIndex(rewardIndex, currentTime);
			if (num != 0)
			{
				return num;
			}
			if (this.SpecificLoginTimes.Count < base.Config.OperationalActivityParms[rewardIndex].Parm1)
			{
				return -2209;
			}
			return 0;
		}

		// Token: 0x06005089 RID: 20617 RVA: 0x001812F4 File Offset: 0x0017F4F4
		public bool AddLoginTime(DateTime time)
		{
			foreach (long ticks in this.SpecificLoginTimes)
			{
				DateTime dateTime = new DateTime(ticks);
				if (dateTime.Date == time.Date)
				{
					return false;
				}
			}
			this.SpecificLoginTimes.Add(time.Ticks);
			return true;
		}

		// Token: 0x170013E2 RID: 5090
		// (get) Token: 0x0600508A RID: 20618 RVA: 0x00181388 File Offset: 0x0017F588
		// (set) Token: 0x0600508B RID: 20619 RVA: 0x00181390 File Offset: 0x0017F590
		public List<long> SpecificLoginTimes { get; set; }
	}
}
