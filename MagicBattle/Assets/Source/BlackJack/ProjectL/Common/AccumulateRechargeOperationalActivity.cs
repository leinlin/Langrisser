using System;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;
using BlackJack.UtilityTools;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000561 RID: 1377
	[CustomLuaClass]
	public class AccumulateRechargeOperationalActivity : AwardOperationalActivityBase
	{
		// Token: 0x0600508C RID: 20620 RVA: 0x0018139C File Offset: 0x0017F59C
		public AccumulateRechargeOperationalActivity()
		{
			this.AccumulateRechargeRMB = 0;
		}

		// Token: 0x0600508D RID: 20621 RVA: 0x001813AC File Offset: 0x0017F5AC
		public AccumulateRechargeOperationalActivity(ulong instanceId, int operationalActivityId, OperationalActivityType operationalActivityType) : base(instanceId, operationalActivityId, operationalActivityType)
		{
			this.AccumulateRechargeRMB = 0;
		}

		// Token: 0x0600508E RID: 20622 RVA: 0x001813C0 File Offset: 0x0017F5C0
		public void DeserializeFromPB(ProAccumulateRechargeOperationalActivity pbOperationalActivity, ConfigDataOperationalActivityInfo config)
		{
			base.OperationStartTime = new DateTime(pbOperationalActivity.BasicInfo.OperationStartTime);
			base.OperationEndTime = new DateTime(pbOperationalActivity.BasicInfo.OperationEndTime);
			base.GainRewardEndTime = new DateTime(pbOperationalActivity.BasicInfo.GainRewardEndTime);
			this.AccumulateRechargeRMB = pbOperationalActivity.AccumulateRechargeRMB;
			base.GainedRewardIndexs.AddRange(pbOperationalActivity.GainRewardIndexs);
			base.Config = config;
		}

		// Token: 0x0600508F RID: 20623 RVA: 0x00181434 File Offset: 0x0017F634
		public override void ToPBNtf(DSOperationalActivityNtf ntf)
		{
			ntf.AccumulateRechargeOperationalActivities.Add(this.SerializeToPB());
		}

		// Token: 0x06005090 RID: 20624 RVA: 0x00181448 File Offset: 0x0017F648
		public ProAccumulateRechargeOperationalActivity SerializeToPB()
		{
			ProAccumulateRechargeOperationalActivity proAccumulateRechargeOperationalActivity = new ProAccumulateRechargeOperationalActivity();
			proAccumulateRechargeOperationalActivity.BasicInfo = base.ToPBOperationalActivityBasicData();
			proAccumulateRechargeOperationalActivity.AccumulateRechargeRMB = this.AccumulateRechargeRMB;
			proAccumulateRechargeOperationalActivity.GainRewardIndexs.AddRange(base.GainedRewardIndexs);
			return proAccumulateRechargeOperationalActivity;
		}

		// Token: 0x06005091 RID: 20625 RVA: 0x00181488 File Offset: 0x0017F688
		public override int CanGainRewardByIndex(int rewardIndex, DateTime currentTime)
		{
			int num = base.CanGainRewardByIndex(rewardIndex, currentTime);
			if (num != 0)
			{
				return num;
			}
			if (MoneyCaculate.FenToYuan(this.AccumulateRechargeRMB) < (double)base.Config.OperationalActivityParms[rewardIndex].Parm1)
			{
				return -2220;
			}
			return 0;
		}

		// Token: 0x06005092 RID: 20626 RVA: 0x001814D4 File Offset: 0x0017F6D4
		public void AddRechargeRMB(int addNums)
		{
			this.AccumulateRechargeRMB += addNums;
		}

		// Token: 0x170013E3 RID: 5091
		// (get) Token: 0x06005093 RID: 20627 RVA: 0x001814E4 File Offset: 0x0017F6E4
		// (set) Token: 0x06005094 RID: 20628 RVA: 0x001814EC File Offset: 0x0017F6EC
		public int AccumulateRechargeRMB { get; set; }
	}
}
