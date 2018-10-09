using System;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000562 RID: 1378
	[CustomLuaClass]
	public class AccumulateConsumeCrystalOperationalActivity : AwardOperationalActivityBase
	{
		// Token: 0x06005095 RID: 20629 RVA: 0x001814F8 File Offset: 0x0017F6F8
		public AccumulateConsumeCrystalOperationalActivity()
		{
			this.AccumulateConsumeCrystal = 0;
		}

		// Token: 0x06005096 RID: 20630 RVA: 0x00181508 File Offset: 0x0017F708
		public AccumulateConsumeCrystalOperationalActivity(ulong instanceId, int operationalActivityId, OperationalActivityType operationalActivityType) : base(instanceId, operationalActivityId, operationalActivityType)
		{
			this.AccumulateConsumeCrystal = 0;
		}

		// Token: 0x06005097 RID: 20631 RVA: 0x0018151C File Offset: 0x0017F71C
		public void DeserializeFromPB(ProAccumulateConsumeCrystalOperationalActivity pbOperationalActivity, ConfigDataOperationalActivityInfo config)
		{
			base.OperationStartTime = new DateTime(pbOperationalActivity.BasicInfo.OperationStartTime);
			base.OperationEndTime = new DateTime(pbOperationalActivity.BasicInfo.OperationEndTime);
			base.GainRewardEndTime = new DateTime(pbOperationalActivity.BasicInfo.GainRewardEndTime);
			this.AccumulateConsumeCrystal = pbOperationalActivity.AccumulateConsumeCrystal;
			base.GainedRewardIndexs.AddRange(pbOperationalActivity.GainRewardIndexs);
			base.Config = config;
		}

		// Token: 0x06005098 RID: 20632 RVA: 0x00181590 File Offset: 0x0017F790
		public override void ToPBNtf(DSOperationalActivityNtf ntf)
		{
			ntf.AccumulateConsumeCrystalOperationalActivitites.Add(this.SerializeToPB());
		}

		// Token: 0x06005099 RID: 20633 RVA: 0x001815A4 File Offset: 0x0017F7A4
		public ProAccumulateConsumeCrystalOperationalActivity SerializeToPB()
		{
			ProAccumulateConsumeCrystalOperationalActivity proAccumulateConsumeCrystalOperationalActivity = new ProAccumulateConsumeCrystalOperationalActivity();
			proAccumulateConsumeCrystalOperationalActivity.BasicInfo = base.ToPBOperationalActivityBasicData();
			proAccumulateConsumeCrystalOperationalActivity.AccumulateConsumeCrystal = this.AccumulateConsumeCrystal;
			proAccumulateConsumeCrystalOperationalActivity.GainRewardIndexs.AddRange(base.GainedRewardIndexs);
			return proAccumulateConsumeCrystalOperationalActivity;
		}

		// Token: 0x0600509A RID: 20634 RVA: 0x001815E4 File Offset: 0x0017F7E4
		public override int CanGainRewardByIndex(int rewardIndex, DateTime currentTime)
		{
			int num = base.CanGainRewardByIndex(rewardIndex, currentTime);
			if (num != 0)
			{
				return num;
			}
			if (this.AccumulateConsumeCrystal < base.Config.OperationalActivityParms[rewardIndex].Parm1)
			{
				return -2221;
			}
			return 0;
		}

		// Token: 0x0600509B RID: 20635 RVA: 0x0018162C File Offset: 0x0017F82C
		public void AddConsumeCrystal(int addNums)
		{
			this.AccumulateConsumeCrystal += addNums;
		}

		// Token: 0x170013E4 RID: 5092
		// (get) Token: 0x0600509C RID: 20636 RVA: 0x0018163C File Offset: 0x0017F83C
		// (set) Token: 0x0600509D RID: 20637 RVA: 0x00181644 File Offset: 0x0017F844
		public int AccumulateConsumeCrystal { get; set; }
	}
}
