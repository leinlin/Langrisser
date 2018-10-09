using System;
using System.Collections.Generic;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;
using BlackJack.UtilityTools;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004EA RID: 1258
	[CustomLuaClass]
	public class DataSectionOperationalActivity : DataSection
	{
		// Token: 0x06004C3F RID: 19519 RVA: 0x0017843C File Offset: 0x0017663C
		public DataSectionOperationalActivity()
		{
			this.m_operationalActivities = new List<OperationalActivityBase>();
			this.m_layouts = new List<AdvertisementFlowLayout>();
		}

		// Token: 0x06004C40 RID: 19520 RVA: 0x0017845C File Offset: 0x0017665C
		public override void ClearInitedData()
		{
			this.m_operationalActivities.Clear();
			this.m_layouts.Clear();
		}

		// Token: 0x06004C41 RID: 19521 RVA: 0x00178474 File Offset: 0x00176674
		public override object SerializeToClient()
		{
			DSOperationalActivityNtf dsoperationalActivityNtf = new DSOperationalActivityNtf();
			dsoperationalActivityNtf.Version = (uint)base.Version;
			foreach (OperationalActivityBase operationalActivityBase in this.m_operationalActivities)
			{
				operationalActivityBase.ToPBNtf(dsoperationalActivityNtf);
			}
			return dsoperationalActivityNtf;
		}

		// Token: 0x06004C42 RID: 19522 RVA: 0x001784E4 File Offset: 0x001766E4
		public OperationalActivityBase FindOperationalActivityById(ulong operationalActivityInstanceId)
		{
			return this.m_operationalActivities.Find((OperationalActivityBase t) => t.InstanceId == operationalActivityInstanceId);
		}

		// Token: 0x06004C43 RID: 19523 RVA: 0x00178518 File Offset: 0x00176718
		public List<OperationalActivityBase> FindOperationalActivitiesByType(OperationalActivityType activityType)
		{
			List<OperationalActivityBase> list = new List<OperationalActivityBase>();
			foreach (OperationalActivityBase operationalActivityBase in this.m_operationalActivities)
			{
				if (activityType == operationalActivityBase.ActivityType)
				{
					list.Add(operationalActivityBase);
				}
			}
			return list;
		}

		// Token: 0x06004C44 RID: 19524 RVA: 0x00178588 File Offset: 0x00176788
		public void InitOperationalActivities(List<OperationalActivityBase> operationalActivities)
		{
			this.m_operationalActivities.Clear();
			this.m_operationalActivities.AddRange(operationalActivities);
		}

		// Token: 0x06004C45 RID: 19525 RVA: 0x001785A4 File Offset: 0x001767A4
		public void SetOperationalActivities(List<OperationalActivityBase> operationalActivities)
		{
			this.m_operationalActivities.Clear();
			this.m_operationalActivities.AddRange(operationalActivities);
			base.SetDirty(true);
		}

		// Token: 0x06004C46 RID: 19526 RVA: 0x001785C4 File Offset: 0x001767C4
		public bool AddAccumulateLoginTime(AccumulateLoginOperationalActivity accumulateLoginOperationalActivity, DateTime loginTime)
		{
			if (accumulateLoginOperationalActivity.AddLoginTime(loginTime))
			{
				base.SetDirty(true);
				return true;
			}
			return false;
		}

		// Token: 0x06004C47 RID: 19527 RVA: 0x001785DC File Offset: 0x001767DC
		public void AddRechargeRMB(AccumulateRechargeOperationalActivity activity, int nums)
		{
			activity.AddRechargeRMB(nums);
			base.SetDirty(true);
		}

		// Token: 0x06004C48 RID: 19528 RVA: 0x001785EC File Offset: 0x001767EC
		public void AddConsumeCrystal(AccumulateConsumeCrystalOperationalActivity activity, int nums)
		{
			activity.AddConsumeCrystal(nums);
			base.SetDirty(true);
		}

		// Token: 0x06004C49 RID: 19529 RVA: 0x001785FC File Offset: 0x001767FC
		public void SetPlayerLevel(PlayerLevelUpOperationalActivity playerLevelUpOperationalActivity, int playerLevel)
		{
			playerLevelUpOperationalActivity.PlayerLevel = playerLevel;
			base.SetDirty(true);
		}

		// Token: 0x06004C4A RID: 19530 RVA: 0x0017860C File Offset: 0x0017680C
		public void AddSpecificLoginTimes(SpecificDaysLoginOperationalActivity specificDaysLoginOperationalActivity, long time)
		{
			specificDaysLoginOperationalActivity.SpecificLoginTimes.Add(time);
			base.SetDirty(true);
		}

		// Token: 0x06004C4B RID: 19531 RVA: 0x00178624 File Offset: 0x00176824
		public void ExchangeItemGroup(LimitedTimeExchangeOperationActivity limitedTimeExchangeOperationActivity, int itemGroupId)
		{
			limitedTimeExchangeOperationActivity.AddOperationalActivityItemExchangeTimes(itemGroupId, 1);
			base.SetDirty(true);
		}

		// Token: 0x06004C4C RID: 19532 RVA: 0x00178638 File Offset: 0x00176838
		public void GainReward(AwardOperationalActivityBase operationalActivity, int rewardIndex)
		{
			operationalActivity.GainReward(rewardIndex);
			base.SetDirty(true);
		}

		// Token: 0x06004C4D RID: 19533 RVA: 0x00178648 File Offset: 0x00176848
		public void ClearOperationalActivities()
		{
			this.m_operationalActivities.Clear();
			base.SetDirty(true);
		}

		// Token: 0x06004C4E RID: 19534 RVA: 0x0017865C File Offset: 0x0017685C
		public void AddNewOperationalActivity(OperationalActivityBase operationalActivity)
		{
			this.m_operationalActivities.Add(operationalActivity);
			this.m_operationalActivities.Sort((OperationalActivityBase a, OperationalActivityBase b) => TimeCaculate.AscendTimeCallBack(a.GetExpiredTime(), b.GetExpiredTime()));
			base.SetDirty(true);
		}

		// Token: 0x06004C4F RID: 19535 RVA: 0x0017869C File Offset: 0x0017689C
		public void RemoveExpiredOperationalActivity(OperationalActivityBase operatinoalActivity)
		{
			this.m_operationalActivities.Remove(operatinoalActivity);
			base.SetDirty(true);
		}

		// Token: 0x06004C50 RID: 19536 RVA: 0x001786B4 File Offset: 0x001768B4
		public void ClearAdvertisementLayout()
		{
			this.m_layouts.Clear();
		}

		// Token: 0x06004C51 RID: 19537 RVA: 0x001786C4 File Offset: 0x001768C4
		public void InitAdvertisementLayout(AdvertisementFlowLayout layout)
		{
			this.m_layouts.Add(layout);
		}

		// Token: 0x06004C52 RID: 19538 RVA: 0x001786D4 File Offset: 0x001768D4
		public List<AdvertisementFlowLayout> GetAllAdvertisementFlowLayouts()
		{
			return this.m_layouts;
		}

		// Token: 0x170012A2 RID: 4770
		// (get) Token: 0x06004C53 RID: 19539 RVA: 0x001786DC File Offset: 0x001768DC
		public List<OperationalActivityBase> AllOperationalActivities
		{
			get
			{
				return this.m_operationalActivities;
			}
		}

		// Token: 0x04003895 RID: 14485
		private List<OperationalActivityBase> m_operationalActivities;

		// Token: 0x04003896 RID: 14486
		private List<AdvertisementFlowLayout> m_layouts;
	}
}
