using System;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200055C RID: 1372
	[CustomLuaClass]
	public class OperationalActivityBase
	{
		// Token: 0x0600504E RID: 20558 RVA: 0x00180AAC File Offset: 0x0017ECAC
		public OperationalActivityBase()
		{
			this.OperationStartTime = DateTime.MinValue;
			this.OperationEndTime = DateTime.MinValue;
			this.GainRewardEndTime = DateTime.MinValue;
			this.OperationShowTime = DateTime.MinValue;
		}

		// Token: 0x0600504F RID: 20559 RVA: 0x00180AE0 File Offset: 0x0017ECE0
		public OperationalActivityBase(ulong instanceId, int operationalActivityId, OperationalActivityType operationalActivityType) : this()
		{
			this.InstanceId = instanceId;
			this.ActivityId = operationalActivityId;
			this.ActivityType = operationalActivityType;
		}

		// Token: 0x06005050 RID: 20560 RVA: 0x00180B00 File Offset: 0x0017ED00
		public string ToInfoString()
		{
			return string.Format(" InstanceId = {0} ActivityId = {1} OperationStartTime = {2} OperationEndTime = {3} GainRewardEndTime = {4} OperationShowTime = {5}", new object[]
			{
				this.InstanceId,
				this.ActivityId,
				this.OperationStartTime.ToString(),
				this.OperationEndTime.ToString(),
				this.GainRewardEndTime.ToString(),
				this.OperationShowTime.ToString()
			});
		}

		// Token: 0x06005051 RID: 20561 RVA: 0x00180B98 File Offset: 0x0017ED98
		public virtual void ToPBNtf(DSOperationalActivityNtf ntf)
		{
		}

		// Token: 0x06005052 RID: 20562 RVA: 0x00180B9C File Offset: 0x0017ED9C
		public ProOperationalActivityBasicInfo ToPBOperationalActivityBasicData()
		{
			return new ProOperationalActivityBasicInfo
			{
				InstanceId = this.InstanceId,
				ActivityId = this.ActivityId,
				OperationShowTime = this.OperationShowTime.Ticks,
				OperationStartTime = this.OperationStartTime.Ticks,
				OperationEndTime = this.OperationEndTime.Ticks,
				GainRewardEndTime = this.GainRewardEndTime.Ticks
			};
		}

		// Token: 0x06005053 RID: 20563 RVA: 0x00180C1C File Offset: 0x0017EE1C
		public void InitOperationalActivityTime(DateTime operationStartTime, DateTime operationEndTime, DateTime gainRewardEndTime, DateTime operationShowTime)
		{
			this.OperationShowTime = operationShowTime;
			this.OperationStartTime = operationStartTime;
			this.OperationEndTime = operationEndTime;
			this.GainRewardEndTime = gainRewardEndTime;
		}

		// Token: 0x06005054 RID: 20564 RVA: 0x00180C3C File Offset: 0x0017EE3C
		public bool IsInOperationPeriod(DateTime time)
		{
			return this.OperationStartTime <= time && time < this.OperationEndTime;
		}

		// Token: 0x06005055 RID: 20565 RVA: 0x00180C60 File Offset: 0x0017EE60
		public bool IsInOperationShowPeriod(DateTime time)
		{
			return this.OperationShowTime != DateTime.MinValue && this.ActivityType == OperationalActivityType.OperationalActivityType_UnchartedScore && this.OperationShowTime <= time && time < this.OperationStartTime;
		}

		// Token: 0x06005056 RID: 20566 RVA: 0x00180CB4 File Offset: 0x0017EEB4
		public bool IsInGainRewardPeriod(DateTime time)
		{
			return this.OperationStartTime <= time && time < this.GainRewardEndTime;
		}

		// Token: 0x06005057 RID: 20567 RVA: 0x00180CD8 File Offset: 0x0017EED8
		public bool IsExpiredOperationalActivity(DateTime currentTime)
		{
			return currentTime >= this.GetExpiredTime();
		}

		// Token: 0x06005058 RID: 20568 RVA: 0x00180CE8 File Offset: 0x0017EEE8
		public DateTime GetExpiredTime()
		{
			if (this.GainRewardEndTime == DateTime.MinValue)
			{
				return this.OperationEndTime;
			}
			return this.GainRewardEndTime;
		}

		// Token: 0x06005059 RID: 20569 RVA: 0x00180D0C File Offset: 0x0017EF0C
		public DateTime GetInitialTimeInOneDay(DateTime time)
		{
			return new DateTime(time.Year, time.Month, time.Day, 0, 0, 0);
		}

		// Token: 0x170013D6 RID: 5078
		// (get) Token: 0x0600505A RID: 20570 RVA: 0x00180D2C File Offset: 0x0017EF2C
		// (set) Token: 0x0600505B RID: 20571 RVA: 0x00180D34 File Offset: 0x0017EF34
		public DateTime OperationShowTime { get; set; }

		// Token: 0x170013D7 RID: 5079
		// (get) Token: 0x0600505C RID: 20572 RVA: 0x00180D40 File Offset: 0x0017EF40
		// (set) Token: 0x0600505D RID: 20573 RVA: 0x00180D48 File Offset: 0x0017EF48
		public DateTime OperationStartTime { get; set; }

		// Token: 0x170013D8 RID: 5080
		// (get) Token: 0x0600505E RID: 20574 RVA: 0x00180D54 File Offset: 0x0017EF54
		// (set) Token: 0x0600505F RID: 20575 RVA: 0x00180D5C File Offset: 0x0017EF5C
		public DateTime OperationEndTime { get; set; }

		// Token: 0x170013D9 RID: 5081
		// (get) Token: 0x06005060 RID: 20576 RVA: 0x00180D68 File Offset: 0x0017EF68
		// (set) Token: 0x06005061 RID: 20577 RVA: 0x00180D70 File Offset: 0x0017EF70
		public DateTime GainRewardEndTime { get; set; }

		// Token: 0x170013DA RID: 5082
		// (get) Token: 0x06005062 RID: 20578 RVA: 0x00180D7C File Offset: 0x0017EF7C
		// (set) Token: 0x06005063 RID: 20579 RVA: 0x00180D84 File Offset: 0x0017EF84
		public int DaysAfterPlayerCreated { get; set; }

		// Token: 0x170013DB RID: 5083
		// (get) Token: 0x06005064 RID: 20580 RVA: 0x00180D90 File Offset: 0x0017EF90
		// (set) Token: 0x06005065 RID: 20581 RVA: 0x00180D98 File Offset: 0x0017EF98
		public ulong InstanceId { get; set; }

		// Token: 0x170013DC RID: 5084
		// (get) Token: 0x06005066 RID: 20582 RVA: 0x00180DA4 File Offset: 0x0017EFA4
		// (set) Token: 0x06005067 RID: 20583 RVA: 0x00180DAC File Offset: 0x0017EFAC
		public int ActivityId { get; set; }

		// Token: 0x170013DD RID: 5085
		// (get) Token: 0x06005068 RID: 20584 RVA: 0x00180DB8 File Offset: 0x0017EFB8
		// (set) Token: 0x06005069 RID: 20585 RVA: 0x00180DC0 File Offset: 0x0017EFC0
		public OperationalActivityType ActivityType { get; set; }

		// Token: 0x170013DE RID: 5086
		// (get) Token: 0x0600506A RID: 20586 RVA: 0x00180DCC File Offset: 0x0017EFCC
		// (set) Token: 0x0600506B RID: 20587 RVA: 0x00180DD4 File Offset: 0x0017EFD4
		public ConfigDataOperationalActivityInfo Config { get; set; }
	}
}
