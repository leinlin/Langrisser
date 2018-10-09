using System;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200055E RID: 1374
	[CustomLuaClass]
	public class PlayerLevelUpOperationalActivity : AwardOperationalActivityBase
	{
		// Token: 0x06005072 RID: 20594 RVA: 0x00180E90 File Offset: 0x0017F090
		public PlayerLevelUpOperationalActivity()
		{
			this.PlayerLevel = 0;
		}

		// Token: 0x06005073 RID: 20595 RVA: 0x00180EA0 File Offset: 0x0017F0A0
		public PlayerLevelUpOperationalActivity(ulong instanceId, int operationalActivityId, OperationalActivityType operationalActivityType) : base(instanceId, operationalActivityId, operationalActivityType)
		{
			this.PlayerLevel = 0;
		}

		// Token: 0x06005074 RID: 20596 RVA: 0x00180EB4 File Offset: 0x0017F0B4
		public void DeserializeFromPB(ProPlayerLevelUpOperationalActivity pbOperationalActivity, ConfigDataOperationalActivityInfo config)
		{
			base.OperationStartTime = new DateTime(pbOperationalActivity.BasicInfo.OperationStartTime);
			base.OperationEndTime = new DateTime(pbOperationalActivity.BasicInfo.OperationEndTime);
			base.GainRewardEndTime = new DateTime(pbOperationalActivity.BasicInfo.GainRewardEndTime);
			base.GainedRewardIndexs.AddRange(pbOperationalActivity.GainRewardIndexs);
			this.PlayerLevel = pbOperationalActivity.PlayerLevel;
			base.Config = config;
		}

		// Token: 0x06005075 RID: 20597 RVA: 0x00180F28 File Offset: 0x0017F128
		public override void ToPBNtf(DSOperationalActivityNtf ntf)
		{
			ntf.PlayerLevelUpAwardOperationalActivities.Add(this.SerializeToPB());
		}

		// Token: 0x06005076 RID: 20598 RVA: 0x00180F3C File Offset: 0x0017F13C
		public ProPlayerLevelUpOperationalActivity SerializeToPB()
		{
			ProPlayerLevelUpOperationalActivity proPlayerLevelUpOperationalActivity = new ProPlayerLevelUpOperationalActivity();
			proPlayerLevelUpOperationalActivity.BasicInfo = base.ToPBOperationalActivityBasicData();
			proPlayerLevelUpOperationalActivity.PlayerLevel = this.PlayerLevel;
			proPlayerLevelUpOperationalActivity.GainRewardIndexs.AddRange(base.GainedRewardIndexs);
			return proPlayerLevelUpOperationalActivity;
		}

		// Token: 0x06005077 RID: 20599 RVA: 0x00180F7C File Offset: 0x0017F17C
		public override int CanGainRewardByIndex(int rewardIndex, DateTime currentTime)
		{
			int num = base.CanGainRewardByIndex(rewardIndex, currentTime);
			if (num != 0)
			{
				return num;
			}
			if (this.PlayerLevel < base.Config.OperationalActivityParms[rewardIndex].Parm1)
			{
				return -2208;
			}
			return 0;
		}

		// Token: 0x06005078 RID: 20600 RVA: 0x00180FC4 File Offset: 0x0017F1C4
		public void SetPlayerLevel(int playerLevel)
		{
			this.PlayerLevel = playerLevel;
		}

		// Token: 0x170013E0 RID: 5088
		// (get) Token: 0x06005079 RID: 20601 RVA: 0x00180FD0 File Offset: 0x0017F1D0
		// (set) Token: 0x0600507A RID: 20602 RVA: 0x00180FD8 File Offset: 0x0017F1D8
		public int PlayerLevel { get; set; }
	}
}
