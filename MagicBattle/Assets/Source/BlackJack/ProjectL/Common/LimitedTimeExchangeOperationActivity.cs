using System;
using System.Collections.Generic;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000563 RID: 1379
	[CustomLuaClass]
	public class LimitedTimeExchangeOperationActivity : OperationalActivityBase
	{
		// Token: 0x0600509E RID: 20638 RVA: 0x00181650 File Offset: 0x0017F850
		public LimitedTimeExchangeOperationActivity()
		{
			this.ExchangedItemGroups = new Dictionary<int, int>();
		}

		// Token: 0x0600509F RID: 20639 RVA: 0x00181664 File Offset: 0x0017F864
		public LimitedTimeExchangeOperationActivity(ulong instanceId, int operationalActivityId, OperationalActivityType operationalActivityType) : base(instanceId, operationalActivityId, operationalActivityType)
		{
			this.ExchangedItemGroups = new Dictionary<int, int>();
		}

		// Token: 0x060050A0 RID: 20640 RVA: 0x0018167C File Offset: 0x0017F87C
		public void DeserializeFromPB(ProLimitedTimeExchangeOperationActivity pbOperationalActivity, ConfigDataOperationalActivityInfo config)
		{
			base.OperationStartTime = new DateTime(pbOperationalActivity.BasicInfo.OperationStartTime);
			base.OperationEndTime = new DateTime(pbOperationalActivity.BasicInfo.OperationEndTime);
			base.GainRewardEndTime = new DateTime(pbOperationalActivity.BasicInfo.GainRewardEndTime);
			foreach (ProLimitedTimeExchangeOperationActivityItemGroup proLimitedTimeExchangeOperationActivityItemGroup in pbOperationalActivity.ExchangedItemGroups)
			{
				this.ExchangedItemGroups.Add(proLimitedTimeExchangeOperationActivityItemGroup.ItemGroupIndex, proLimitedTimeExchangeOperationActivityItemGroup.ExchangedNums);
			}
			base.Config = config;
		}

		// Token: 0x060050A1 RID: 20641 RVA: 0x00181734 File Offset: 0x0017F934
		public override void ToPBNtf(DSOperationalActivityNtf ntf)
		{
			ntf.LimitedTimeExchangeOperationActivities.Add(this.SerializeToPB());
		}

		// Token: 0x060050A2 RID: 20642 RVA: 0x00181748 File Offset: 0x0017F948
		public ProLimitedTimeExchangeOperationActivity SerializeToPB()
		{
			ProLimitedTimeExchangeOperationActivity proLimitedTimeExchangeOperationActivity = new ProLimitedTimeExchangeOperationActivity();
			proLimitedTimeExchangeOperationActivity.BasicInfo = base.ToPBOperationalActivityBasicData();
			foreach (KeyValuePair<int, int> keyValuePair in this.ExchangedItemGroups)
			{
				proLimitedTimeExchangeOperationActivity.ExchangedItemGroups.Add(new ProLimitedTimeExchangeOperationActivityItemGroup
				{
					ItemGroupIndex = keyValuePair.Key,
					ExchangedNums = keyValuePair.Value
				});
			}
			return proLimitedTimeExchangeOperationActivity;
		}

		// Token: 0x170013E5 RID: 5093
		// (get) Token: 0x060050A3 RID: 20643 RVA: 0x001817DC File Offset: 0x0017F9DC
		// (set) Token: 0x060050A4 RID: 20644 RVA: 0x001817E4 File Offset: 0x0017F9E4
		public Dictionary<int, int> ExchangedItemGroups { get; set; }

		// Token: 0x060050A5 RID: 20645 RVA: 0x001817F0 File Offset: 0x0017F9F0
		public int CanExchangeOperationalActivityItem(int itemGroupIndex, int exchangeTimes = 1)
		{
			if (itemGroupIndex < 0 || itemGroupIndex >= base.Config.OperationalActivityParms.Count)
			{
				return -2200;
			}
			ActivityParam activityParam = base.Config.OperationalActivityParms[itemGroupIndex];
			if (this.ExchangedItemGroups.ContainsKey(itemGroupIndex) && activityParam.Parm3 < this.ExchangedItemGroups[itemGroupIndex] + exchangeTimes)
			{
				return -2201;
			}
			return 0;
		}

		// Token: 0x060050A6 RID: 20646 RVA: 0x00181864 File Offset: 0x0017FA64
		public int AddOperationalActivityItemExchangeTimes(int itemGroupIndex, int exchangeTimes = 1)
		{
			if (this.ExchangedItemGroups.ContainsKey(itemGroupIndex))
			{
				Dictionary<int, int> exchangedItemGroups;
				(exchangedItemGroups = this.ExchangedItemGroups)[itemGroupIndex] = exchangedItemGroups[itemGroupIndex] + exchangeTimes;
			}
			else
			{
				this.ExchangedItemGroups.Add(itemGroupIndex, exchangeTimes);
			}
			return this.ExchangedItemGroups[itemGroupIndex];
		}
	}
}
