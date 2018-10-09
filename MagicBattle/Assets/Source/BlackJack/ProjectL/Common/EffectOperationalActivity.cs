using System;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000564 RID: 1380
	[CustomLuaClass]
	public class EffectOperationalActivity : OperationalActivityBase
	{
		// Token: 0x060050A7 RID: 20647 RVA: 0x001818BC File Offset: 0x0017FABC
		public EffectOperationalActivity()
		{
		}

		// Token: 0x060050A8 RID: 20648 RVA: 0x001818C4 File Offset: 0x0017FAC4
		public EffectOperationalActivity(ulong instanceId, int operationalActivityId, OperationalActivityType operationalActivityType) : base(instanceId, operationalActivityId, operationalActivityType)
		{
		}

		// Token: 0x060050A9 RID: 20649 RVA: 0x001818D0 File Offset: 0x0017FAD0
		public void DeserializeFromPB(ProEffectOperationActivity pbOperationalActivity, ConfigDataOperationalActivityInfo config)
		{
			base.OperationShowTime = new DateTime(pbOperationalActivity.BasicInfo.OperationShowTime);
			base.OperationStartTime = new DateTime(pbOperationalActivity.BasicInfo.OperationStartTime);
			base.OperationEndTime = new DateTime(pbOperationalActivity.BasicInfo.OperationEndTime);
			base.GainRewardEndTime = new DateTime(pbOperationalActivity.BasicInfo.GainRewardEndTime);
			base.Config = config;
		}

		// Token: 0x060050AA RID: 20650 RVA: 0x0018193C File Offset: 0x0017FB3C
		public override void ToPBNtf(DSOperationalActivityNtf ntf)
		{
			ntf.EffectOperationActivities.Add(this.SerializeToPB());
		}

		// Token: 0x060050AB RID: 20651 RVA: 0x00181950 File Offset: 0x0017FB50
		public ProEffectOperationActivity SerializeToPB()
		{
			return new ProEffectOperationActivity
			{
				BasicInfo = base.ToPBOperationalActivityBasicData(),
				BasicInfo = 
				{
					GainRewardEndTime = base.GainRewardEndTime.Ticks
				}
			};
		}
	}
}
