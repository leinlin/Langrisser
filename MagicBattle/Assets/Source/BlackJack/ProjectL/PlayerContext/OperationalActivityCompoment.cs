using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x020008D1 RID: 2257
	[HotFix]
	public class OperationalActivityCompoment : OperationalActivityCompomentCommon
	{
		// Token: 0x0600742F RID: 29743 RVA: 0x001FFE00 File Offset: 0x001FE000
		public OperationalActivityCompoment()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06007430 RID: 29744 RVA: 0x001FFE68 File Offset: 0x001FE068
		public override void Init()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Init_hotfix != null)
			{
				this.m_Init_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			base.Init();
		}

		// Token: 0x06007431 RID: 29745 RVA: 0x001FFEE4 File Offset: 0x001FE0E4
		public override void PostInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostInit_hotfix != null)
			{
				this.m_PostInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.PostInit();
		}

		// Token: 0x06007432 RID: 29746 RVA: 0x001FFF4C File Offset: 0x001FE14C
		public override void DeInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeInit_hotfix != null)
			{
				this.m_DeInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.DeInit();
		}

		// Token: 0x06007433 RID: 29747 RVA: 0x001FFFB4 File Offset: 0x001FE1B4
		public int ExchangeItemGroup(ulong operationalActivityInstanceId, int itemGroupIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExchangeItemGroupUInt64Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_ExchangeItemGroupUInt64Int32_hotfix.call(new object[]
				{
					this,
					operationalActivityInstanceId,
					itemGroupIndex
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			OperationalActivityBase operationalActivityBase = base.FindOperationalActivityById(operationalActivityInstanceId);
			if (operationalActivityBase == null)
			{
				return -2204;
			}
			LimitedTimeExchangeOperationActivity limitedTimeExchangeOperationActivity = operationalActivityBase as LimitedTimeExchangeOperationActivity;
			if (limitedTimeExchangeOperationActivity == null)
			{
				return -2212;
			}
			this.m_operationalActivityDS.ExchangeItemGroup(limitedTimeExchangeOperationActivity, itemGroupIndex);
			return 0;
		}

		// Token: 0x06007434 RID: 29748 RVA: 0x00200078 File Offset: 0x001FE278
		public int GainReward(ulong operationalActivityInstanceId, int rewardIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GainRewardUInt64Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GainRewardUInt64Int32_hotfix.call(new object[]
				{
					this,
					operationalActivityInstanceId,
					rewardIndex
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			OperationalActivityBase operationalActivityBase = base.FindOperationalActivityById(operationalActivityInstanceId);
			if (operationalActivityBase == null)
			{
				return -2204;
			}
			if (!OperationalActivityCompomentCommon.IsAwardOperationActivity(operationalActivityBase.ActivityType))
			{
				return -2205;
			}
			AwardOperationalActivityBase operationalActivity = operationalActivityBase as AwardOperationalActivityBase;
			this.m_operationalActivityDS.GainReward(operationalActivity, rewardIndex);
			return 0;
		}

		// Token: 0x06007435 RID: 29749 RVA: 0x00200144 File Offset: 0x001FE344
		public void Deserialize(DSOperationalActivityNtf ntf)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeserializeDSOperationalActivityNtf_hotfix != null)
			{
				this.m_DeserializeDSOperationalActivityNtf_hotfix.call(new object[]
				{
					this,
					ntf
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<OperationalActivityBase> list = new List<OperationalActivityBase>();
			foreach (ProPlayerLevelUpOperationalActivity proPlayerLevelUpOperationalActivity in ntf.PlayerLevelUpAwardOperationalActivities)
			{
				ConfigDataOperationalActivityInfo configDataOperationalActivityInfo = this.m_configDataLoader.GetConfigDataOperationalActivityInfo(proPlayerLevelUpOperationalActivity.BasicInfo.ActivityId);
				if (configDataOperationalActivityInfo != null)
				{
					PlayerLevelUpOperationalActivity playerLevelUpOperationalActivity = OperationalActivityFactory.CreateOperationalActivity(proPlayerLevelUpOperationalActivity.BasicInfo.InstanceId, proPlayerLevelUpOperationalActivity.BasicInfo.ActivityId, configDataOperationalActivityInfo.ActivityType) as PlayerLevelUpOperationalActivity;
					playerLevelUpOperationalActivity.DeserializeFromPB(proPlayerLevelUpOperationalActivity, configDataOperationalActivityInfo);
					list.Add(playerLevelUpOperationalActivity);
				}
			}
			foreach (ProAccumulateLoginOperationalActivity proAccumulateLoginOperationalActivity in ntf.AccumulateLoginAwardOperationalActivities)
			{
				ConfigDataOperationalActivityInfo configDataOperationalActivityInfo = this.m_configDataLoader.GetConfigDataOperationalActivityInfo(proAccumulateLoginOperationalActivity.BasicInfo.ActivityId);
				if (configDataOperationalActivityInfo != null)
				{
					AccumulateLoginOperationalActivity accumulateLoginOperationalActivity = OperationalActivityFactory.CreateOperationalActivity(proAccumulateLoginOperationalActivity.BasicInfo.InstanceId, proAccumulateLoginOperationalActivity.BasicInfo.ActivityId, configDataOperationalActivityInfo.ActivityType) as AccumulateLoginOperationalActivity;
					accumulateLoginOperationalActivity.DeserializeFromPB(proAccumulateLoginOperationalActivity, configDataOperationalActivityInfo);
					list.Add(accumulateLoginOperationalActivity);
				}
			}
			foreach (ProSpecificDaysLoginOperationalActivity proSpecificDaysLoginOperationalActivity in ntf.SpecificDaysLoginAwardOperationalActivities)
			{
				ConfigDataOperationalActivityInfo configDataOperationalActivityInfo = this.m_configDataLoader.GetConfigDataOperationalActivityInfo(proSpecificDaysLoginOperationalActivity.BasicInfo.ActivityId);
				if (configDataOperationalActivityInfo != null)
				{
					SpecificDaysLoginOperationalActivity specificDaysLoginOperationalActivity = OperationalActivityFactory.CreateOperationalActivity(proSpecificDaysLoginOperationalActivity.BasicInfo.InstanceId, proSpecificDaysLoginOperationalActivity.BasicInfo.ActivityId, configDataOperationalActivityInfo.ActivityType) as SpecificDaysLoginOperationalActivity;
					specificDaysLoginOperationalActivity.DeserializeFromPB(proSpecificDaysLoginOperationalActivity, configDataOperationalActivityInfo);
					list.Add(specificDaysLoginOperationalActivity);
				}
			}
			foreach (ProLimitedTimeExchangeOperationActivity proLimitedTimeExchangeOperationActivity in ntf.LimitedTimeExchangeOperationActivities)
			{
				ConfigDataOperationalActivityInfo configDataOperationalActivityInfo = this.m_configDataLoader.GetConfigDataOperationalActivityInfo(proLimitedTimeExchangeOperationActivity.BasicInfo.ActivityId);
				if (configDataOperationalActivityInfo != null)
				{
					LimitedTimeExchangeOperationActivity limitedTimeExchangeOperationActivity = OperationalActivityFactory.CreateOperationalActivity(proLimitedTimeExchangeOperationActivity.BasicInfo.InstanceId, proLimitedTimeExchangeOperationActivity.BasicInfo.ActivityId, configDataOperationalActivityInfo.ActivityType) as LimitedTimeExchangeOperationActivity;
					limitedTimeExchangeOperationActivity.DeserializeFromPB(proLimitedTimeExchangeOperationActivity, configDataOperationalActivityInfo);
					list.Add(limitedTimeExchangeOperationActivity);
				}
			}
			foreach (ProEffectOperationActivity proEffectOperationActivity in ntf.EffectOperationActivities)
			{
				ConfigDataOperationalActivityInfo configDataOperationalActivityInfo = this.m_configDataLoader.GetConfigDataOperationalActivityInfo(proEffectOperationActivity.BasicInfo.ActivityId);
				if (configDataOperationalActivityInfo != null)
				{
					EffectOperationalActivity effectOperationalActivity = OperationalActivityFactory.CreateOperationalActivity(proEffectOperationActivity.BasicInfo.InstanceId, proEffectOperationActivity.BasicInfo.ActivityId, configDataOperationalActivityInfo.ActivityType) as EffectOperationalActivity;
					effectOperationalActivity.DeserializeFromPB(proEffectOperationActivity, configDataOperationalActivityInfo);
					if (effectOperationalActivity.IsInOperationPeriod(this.m_basicInfo.GetCurrentTime()))
					{
						base.EffectOperationActivityGenerateEffect(effectOperationalActivity, true);
					}
					list.Add(effectOperationalActivity);
				}
			}
			foreach (ProAccumulateRechargeOperationalActivity proAccumulateRechargeOperationalActivity in ntf.AccumulateRechargeOperationalActivities)
			{
				ConfigDataOperationalActivityInfo configDataOperationalActivityInfo = this.m_configDataLoader.GetConfigDataOperationalActivityInfo(proAccumulateRechargeOperationalActivity.BasicInfo.ActivityId);
				if (configDataOperationalActivityInfo != null)
				{
					AccumulateRechargeOperationalActivity accumulateRechargeOperationalActivity = OperationalActivityFactory.CreateOperationalActivity(proAccumulateRechargeOperationalActivity.BasicInfo.InstanceId, proAccumulateRechargeOperationalActivity.BasicInfo.ActivityId, configDataOperationalActivityInfo.ActivityType) as AccumulateRechargeOperationalActivity;
					accumulateRechargeOperationalActivity.DeserializeFromPB(proAccumulateRechargeOperationalActivity, configDataOperationalActivityInfo);
					list.Add(accumulateRechargeOperationalActivity);
				}
			}
			foreach (ProAccumulateConsumeCrystalOperationalActivity proAccumulateConsumeCrystalOperationalActivity in ntf.AccumulateConsumeCrystalOperationalActivitites)
			{
				ConfigDataOperationalActivityInfo configDataOperationalActivityInfo = this.m_configDataLoader.GetConfigDataOperationalActivityInfo(proAccumulateConsumeCrystalOperationalActivity.BasicInfo.ActivityId);
				if (configDataOperationalActivityInfo != null)
				{
					AccumulateConsumeCrystalOperationalActivity accumulateConsumeCrystalOperationalActivity = OperationalActivityFactory.CreateOperationalActivity(proAccumulateConsumeCrystalOperationalActivity.BasicInfo.InstanceId, proAccumulateConsumeCrystalOperationalActivity.BasicInfo.ActivityId, configDataOperationalActivityInfo.ActivityType) as AccumulateConsumeCrystalOperationalActivity;
					accumulateConsumeCrystalOperationalActivity.DeserializeFromPB(proAccumulateConsumeCrystalOperationalActivity, configDataOperationalActivityInfo);
					list.Add(accumulateConsumeCrystalOperationalActivity);
				}
			}
			this.m_operationalActivityDS.InitOperationalActivities(list);
			this.m_operationalActivityDS.InitVersion((ushort)ntf.Version, (ushort)ntf.Version);
		}

		// Token: 0x06007436 RID: 29750 RVA: 0x00200660 File Offset: 0x001FE860
		public void Deserialize(DSAnnouncementNtf ntf)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeserializeDSAnnouncementNtf_hotfix != null)
			{
				this.m_DeserializeDSAnnouncementNtf_hotfix.call(new object[]
				{
					this,
					ntf
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_announcementDS.ClearInitedData();
			List<Announcement> list = new List<Announcement>();
			foreach (ProAnnouncement pbAnnouncement in ntf.Announcements)
			{
				list.Add(Announcement.PBAnnouncementToAnnouncement(pbAnnouncement));
			}
			this.m_announcementDS.InitAnnouncements(list);
			this.m_announcementDS.SetClientAnnouncementCurrentVersion(ntf.Version);
		}

		// Token: 0x06007437 RID: 29751 RVA: 0x00200754 File Offset: 0x001FE954
		public void Deserialize(AdvertisementFlowLayoutUpdateNtf ntf)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeserializeAdvertisementFlowLayoutUpdateNtf_hotfix != null)
			{
				this.m_DeserializeAdvertisementFlowLayoutUpdateNtf_hotfix.call(new object[]
				{
					this,
					ntf
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_operationalActivityDS.ClearAdvertisementLayout();
			foreach (ProAdvertisementFlowLayout pbLayout in ntf.Layouts)
			{
				this.m_operationalActivityDS.InitAdvertisementLayout(AdvertisementFlowLayout.FromPB(pbLayout));
			}
		}

		// Token: 0x06007438 RID: 29752 RVA: 0x00200828 File Offset: 0x001FEA28
		public ushort GetDSVersion()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDSVersion_hotfix != null)
			{
				return Convert.ToUInt16(this.m_GetDSVersion_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_operationalActivityDS.ClientVersion;
		}

		// Token: 0x06007439 RID: 29753 RVA: 0x002008A0 File Offset: 0x001FEAA0
		public ushort GetAnnouncementDSVersion()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAnnouncementDSVersion_hotfix != null)
			{
				return Convert.ToUInt16(this.m_GetAnnouncementDSVersion_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_announcementDS.ClientVersion;
		}

		// Token: 0x0600743A RID: 29754 RVA: 0x00200918 File Offset: 0x001FEB18
		public bool AddNewOperationalActivity(ProOperationalActivityBasicInfo operationalActivityBasicInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddNewOperationalActivityProOperationalActivityBasicInfo_hotfix != null)
			{
				return Convert.ToBoolean(this.m_AddNewOperationalActivityProOperationalActivityBasicInfo_hotfix.call(new object[]
				{
					this,
					operationalActivityBasicInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataOperationalActivityInfo configDataOperationalActivityInfo = this.m_configDataLoader.GetConfigDataOperationalActivityInfo(operationalActivityBasicInfo.ActivityId);
			if (configDataOperationalActivityInfo == null)
			{
				return false;
			}
			OperationalActivityBase operationalActivityBase = OperationalActivityFactory.CreateOperationalActivity(operationalActivityBasicInfo.InstanceId, operationalActivityBasicInfo.ActivityId, configDataOperationalActivityInfo.ActivityType);
			operationalActivityBase.InitOperationalActivityTime(new DateTime(operationalActivityBasicInfo.OperationStartTime), new DateTime(operationalActivityBasicInfo.OperationEndTime), new DateTime(operationalActivityBasicInfo.GainRewardEndTime), new DateTime(operationalActivityBasicInfo.OperationShowTime));
			operationalActivityBase.Config = configDataOperationalActivityInfo;
			if (operationalActivityBase.IsExpiredOperationalActivity(this.m_basicInfo.GetCurrentTime()))
			{
				return false;
			}
			base.AddNewOperationalActivity(operationalActivityBase);
			return true;
		}

		// Token: 0x0600743B RID: 29755 RVA: 0x00200A20 File Offset: 0x001FEC20
		public bool AddRedeemActivity(int activityId, RedeemInfoAck info)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddRedeemActivityInt32RedeemInfoAck_hotfix != null)
			{
				return Convert.ToBoolean(this.m_AddRedeemActivityInt32RedeemInfoAck_hotfix.call(new object[]
				{
					this,
					activityId,
					info
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataOperationalActivityInfo configDataOperationalActivityInfo = this.m_configDataLoader.GetConfigDataOperationalActivityInfo(activityId);
			OperationalActivityBase operationalActivityBase = new OperationalActivityBase(0UL, activityId, OperationalActivityType.OperationalActivityType_Redeem);
			operationalActivityBase.InitOperationalActivityTime(new DateTime(info.StartDate), new DateTime(info.EndDate), new DateTime(info.EndDate), new DateTime(info.EndDate));
			operationalActivityBase.Config = configDataOperationalActivityInfo;
			if (operationalActivityBase.IsExpiredOperationalActivity(this.m_basicInfo.GetCurrentTime()))
			{
				return false;
			}
			base.AddNewOperationalActivity(operationalActivityBase);
			return true;
		}

		// Token: 0x0600743C RID: 29756 RVA: 0x00200B20 File Offset: 0x001FED20
		public bool AddFansRewardFromPBTCBTActivity(int activityID, long startDate, long endDate, bool isClaimed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddFansRewardFromPBTCBTActivityInt32Int64Int64Boolean_hotfix != null)
			{
				return Convert.ToBoolean(this.m_AddFansRewardFromPBTCBTActivityInt32Int64Int64Boolean_hotfix.call(new object[]
				{
					this,
					activityID,
					startDate,
					endDate,
					isClaimed
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataOperationalActivityInfo configDataOperationalActivityInfo = this.m_configDataLoader.GetConfigDataOperationalActivityInfo(activityID);
			FansRewardsFromPBTCBTActivity fansRewardsFromPBTCBTActivity = new FansRewardsFromPBTCBTActivity(0UL, activityID, startDate, endDate, OperationalActivityType.OperationalActivityType_PBTCBTFansRewards);
			fansRewardsFromPBTCBTActivity.Config = configDataOperationalActivityInfo;
			fansRewardsFromPBTCBTActivity.claimed = isClaimed;
			if (fansRewardsFromPBTCBTActivity.IsExpiredOperationalActivity(this.m_basicInfo.GetCurrentTime()))
			{
				return false;
			}
			base.AddNewOperationalActivity(fansRewardsFromPBTCBTActivity);
			return true;
		}

		// Token: 0x0600743D RID: 29757 RVA: 0x00200C18 File Offset: 0x001FEE18
		public void AddAnnouncement(ProAnnouncement pbAnnouncement)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddAnnouncementProAnnouncement_hotfix != null)
			{
				this.m_AddAnnouncementProAnnouncement_hotfix.call(new object[]
				{
					this,
					pbAnnouncement
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.RemoveAllExpiredAnnouncements();
			this.m_announcementDS.AddAnnouncement(Announcement.PBAnnouncementToAnnouncement(pbAnnouncement));
		}

		// Token: 0x0600743E RID: 29758 RVA: 0x00200CA0 File Offset: 0x001FEEA0
		public void UpdateOperationalActivity(ProOperationalActivityBasicInfo opertioanlActivityInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateOperationalActivityProOperationalActivityBasicInfo_hotfix != null)
			{
				this.m_UpdateOperationalActivityProOperationalActivityBasicInfo_hotfix.call(new object[]
				{
					this,
					opertioanlActivityInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			OperationalActivityBase operationalActivityBase = base.FindOperationalActivityById(opertioanlActivityInfo.InstanceId);
			if (operationalActivityBase == null)
			{
				return;
			}
			operationalActivityBase.OperationStartTime = new DateTime(opertioanlActivityInfo.OperationStartTime);
			operationalActivityBase.OperationEndTime = new DateTime(opertioanlActivityInfo.OperationEndTime);
			operationalActivityBase.GainRewardEndTime = new DateTime(opertioanlActivityInfo.GainRewardEndTime);
			this.m_operationalActivityDS.SetDirty(true);
		}

		// Token: 0x0600743F RID: 29759 RVA: 0x00200D64 File Offset: 0x001FEF64
		public List<Announcement> GetValidAnnouncements()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetValidAnnouncements_hotfix != null)
			{
				return (List<Announcement>)this.m_GetValidAnnouncements_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DateTime currentTime = this.m_basicInfo.GetCurrentTime();
			return this.m_announcementDS.FindAnnouncementsByCondition((Announcement t) => t.ShowStartTime <= currentTime && currentTime < t.ShowEndTime);
		}

		// Token: 0x06007440 RID: 29760 RVA: 0x00200E00 File Offset: 0x001FF000
		public void RemoveGlobalAnnouncement(ulong instanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RemoveGlobalAnnouncementUInt64_hotfix != null)
			{
				this.m_RemoveGlobalAnnouncementUInt64_hotfix.call(new object[]
				{
					this,
					instanceId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Announcement announcement = this.m_announcementDS.FindAnnouncementsByInstanceId(instanceId);
			if (announcement != null)
			{
				this.m_announcementDS.RemoveAnnouncement(announcement);
			}
		}

		// Token: 0x06007441 RID: 29761 RVA: 0x00200E90 File Offset: 0x001FF090
		public void RemoveAllExpiredAnnouncements()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RemoveAllExpiredAnnouncements_hotfix != null)
			{
				this.m_RemoveAllExpiredAnnouncements_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DateTime currentTime = this.m_basicInfo.GetCurrentTime();
			List<Announcement> list = this.m_announcementDS.FindAnnouncementsByCondition((Announcement t) => t.ShowEndTime <= currentTime);
			if (list.Count == 0)
			{
				return;
			}
			foreach (Announcement announcement in list)
			{
				this.m_announcementDS.RemoveAnnouncement(announcement);
			}
		}

		// Token: 0x17001BD8 RID: 7128
		// (get) Token: 0x06007442 RID: 29762 RVA: 0x00200F7C File Offset: 0x001FF17C
		// (set) Token: 0x06007443 RID: 29763 RVA: 0x00200F9C File Offset: 0x001FF19C
		[DoNotToLua]
		public new OperationalActivityCompoment.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new OperationalActivityCompoment.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06007444 RID: 29764 RVA: 0x00200FA8 File Offset: 0x001FF1A8
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x06007445 RID: 29765 RVA: 0x00200FB0 File Offset: 0x001FF1B0
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x06007446 RID: 29766 RVA: 0x00200FB8 File Offset: 0x001FF1B8
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x06007447 RID: 29767 RVA: 0x00200FC0 File Offset: 0x001FF1C0
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x06007448 RID: 29768 RVA: 0x00200FC8 File Offset: 0x001FF1C8
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x06007449 RID: 29769 RVA: 0x00200FD4 File Offset: 0x001FF1D4
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x0600744A RID: 29770 RVA: 0x00200FDC File Offset: 0x001FF1DC
		private void __callBase_OnFlushLoginDaysEvent()
		{
			base.OnFlushLoginDaysEvent();
		}

		// Token: 0x0600744B RID: 29771 RVA: 0x00200FE4 File Offset: 0x001FF1E4
		private void __callBase_OnFlushSuccessCallBack(OperationalActivityBase activity)
		{
			base.OnFlushSuccessCallBack(activity);
		}

		// Token: 0x0600744C RID: 29772 RVA: 0x00200FF0 File Offset: 0x001FF1F0
		private void __callBase_OnPlayerLevelUpEvent(int palyerLevel)
		{
			base.OnPlayerLevelUpEvent(palyerLevel);
		}

		// Token: 0x0600744D RID: 29773 RVA: 0x00200FFC File Offset: 0x001FF1FC
		private void __callBase_AddNewOperationalActivity(OperationalActivityBase operationalActivity)
		{
			base.AddNewOperationalActivity(operationalActivity);
		}

		// Token: 0x0600744E RID: 29774 RVA: 0x00201008 File Offset: 0x001FF208
		private void __callBase_InitNewNewOperationalActivityInfo(OperationalActivityBase operationalActivityInfo)
		{
			base.InitNewNewOperationalActivityInfo(operationalActivityInfo);
		}

		// Token: 0x0600744F RID: 29775 RVA: 0x00201014 File Offset: 0x001FF214
		private void __callBase_OnAddNewActivityCallBack(OperationalActivityBase activity)
		{
			base.OnAddNewActivityCallBack(activity);
		}

		// Token: 0x06007450 RID: 29776 RVA: 0x00201020 File Offset: 0x001FF220
		private void __callBase_OnActivityInitCallBack(OperationalActivityBase activity)
		{
			base.OnActivityInitCallBack(activity);
		}

		// Token: 0x06007451 RID: 29777 RVA: 0x0020102C File Offset: 0x001FF22C
		private void __callBase_RemoveAllExpiredOperationalActivities()
		{
			base.RemoveAllExpiredOperationalActivities();
		}

		// Token: 0x06007452 RID: 29778 RVA: 0x00201034 File Offset: 0x001FF234
		private int __callBase_CanExchangeItemGroup(LimitedTimeExchangeOperationActivity limitedTimeExchangeOperationalActivity, int itemGroupIndex)
		{
			return base.CanExchangeItemGroup(limitedTimeExchangeOperationalActivity, itemGroupIndex);
		}

		// Token: 0x06007453 RID: 29779 RVA: 0x00201040 File Offset: 0x001FF240
		private int __callBase_CanGainOperactionalActivityReward(OperationalActivityBase operationalActivityBase, int rewardIndex)
		{
			return base.CanGainOperactionalActivityReward(operationalActivityBase, rewardIndex);
		}

		// Token: 0x06007454 RID: 29780 RVA: 0x0020104C File Offset: 0x001FF24C
		private List<OperationalActivityBase> __callBase_GetAllOperationalActivities()
		{
			return base.GetAllOperationalActivities();
		}

		// Token: 0x06007455 RID: 29781 RVA: 0x00201054 File Offset: 0x001FF254
		private List<OperationalActivityBase> __callBase_GetAllValidOperationalActivities()
		{
			return base.GetAllValidOperationalActivities();
		}

		// Token: 0x06007456 RID: 29782 RVA: 0x0020105C File Offset: 0x001FF25C
		private int __callBase_GetAwardOperationActivityRewardItemGroupIdByIndex(OperationalActivityBase operationalActivity, int rewardIndex)
		{
			return base.GetAwardOperationActivityRewardItemGroupIdByIndex(operationalActivity, rewardIndex);
		}

		// Token: 0x06007457 RID: 29783 RVA: 0x00201068 File Offset: 0x001FF268
		private void __callBase_EffectOperationActivityGenerateEffect(OperationalActivityBase operationalActivity, bool isPositive)
		{
			base.EffectOperationActivityGenerateEffect(operationalActivity, isPositive);
		}

		// Token: 0x06007458 RID: 29784 RVA: 0x00201074 File Offset: 0x001FF274
		private OperationalActivityBase __callBase_FindOperationalActivityById(ulong operationalActivityInstanceId)
		{
			return base.FindOperationalActivityById(operationalActivityInstanceId);
		}

		// Token: 0x06007459 RID: 29785 RVA: 0x00201080 File Offset: 0x001FF280
		private List<OperationalActivityBase> __callBase_FindOperationalActivitiesByType(OperationalActivityType activityType)
		{
			return base.FindOperationalActivitiesByType(activityType);
		}

		// Token: 0x0600745A RID: 29786 RVA: 0x0020108C File Offset: 0x001FF28C
		private OperationalActivityBase __callBase_FindOperationalActivityByActivityCardPoolId(int activityCardPoolId)
		{
			return base.FindOperationalActivityByActivityCardPoolId(activityCardPoolId);
		}

		// Token: 0x0600745B RID: 29787 RVA: 0x00201098 File Offset: 0x001FF298
		private OperationalActivityBase __callBase_FindOperationalActivityByRafflePoolId(int rafflePoolId)
		{
			return base.FindOperationalActivityByRafflePoolId(rafflePoolId);
		}

		// Token: 0x0600745C RID: 29788 RVA: 0x002010A4 File Offset: 0x001FF2A4
		private OperationalActivityBase __callBase_FindOperationalActivityByUnchartedScoreId(int UnchartedScoreId)
		{
			return base.FindOperationalActivityByUnchartedScoreId(UnchartedScoreId);
		}

		// Token: 0x0600745D RID: 29789 RVA: 0x002010B0 File Offset: 0x001FF2B0
		private OperationalActivityBase __callBase_FindShowActivityByUnchartedScoreId(int UnchartedScoreId)
		{
			return base.FindShowActivityByUnchartedScoreId(UnchartedScoreId);
		}

		// Token: 0x0600745E RID: 29790 RVA: 0x002010BC File Offset: 0x001FF2BC
		private List<AdvertisementFlowLayout> __callBase_GetAllAdvertisementFlowLayouts()
		{
			return base.GetAllAdvertisementFlowLayouts();
		}

		// Token: 0x0600745F RID: 29791 RVA: 0x002010C4 File Offset: 0x001FF2C4
		private void __callBase_OnBuyStoreItemCallBack(int storeId, int goodsId)
		{
			base.OnBuyStoreItemCallBack(storeId, goodsId);
		}

		// Token: 0x06007460 RID: 29792 RVA: 0x002010D0 File Offset: 0x001FF2D0
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_PostInit_hotfix = (luaObj.RawGet("PostInit") as LuaFunction);
					this.m_DeInit_hotfix = (luaObj.RawGet("DeInit") as LuaFunction);
					this.m_ExchangeItemGroupUInt64Int32_hotfix = (luaObj.RawGet("ExchangeItemGroup") as LuaFunction);
					this.m_GainRewardUInt64Int32_hotfix = (luaObj.RawGet("GainReward") as LuaFunction);
					this.m_DeserializeDSOperationalActivityNtf_hotfix = (luaObj.RawGet("Deserialize") as LuaFunction);
					this.m_DeserializeDSAnnouncementNtf_hotfix = (luaObj.RawGet("Deserialize") as LuaFunction);
					this.m_DeserializeAdvertisementFlowLayoutUpdateNtf_hotfix = (luaObj.RawGet("Deserialize") as LuaFunction);
					this.m_GetDSVersion_hotfix = (luaObj.RawGet("GetDSVersion") as LuaFunction);
					this.m_GetAnnouncementDSVersion_hotfix = (luaObj.RawGet("GetAnnouncementDSVersion") as LuaFunction);
					this.m_AddNewOperationalActivityProOperationalActivityBasicInfo_hotfix = (luaObj.RawGet("AddNewOperationalActivity") as LuaFunction);
					this.m_AddRedeemActivityInt32RedeemInfoAck_hotfix = (luaObj.RawGet("AddRedeemActivity") as LuaFunction);
					this.m_AddFansRewardFromPBTCBTActivityInt32Int64Int64Boolean_hotfix = (luaObj.RawGet("AddFansRewardFromPBTCBTActivity") as LuaFunction);
					this.m_AddAnnouncementProAnnouncement_hotfix = (luaObj.RawGet("AddAnnouncement") as LuaFunction);
					this.m_UpdateOperationalActivityProOperationalActivityBasicInfo_hotfix = (luaObj.RawGet("UpdateOperationalActivity") as LuaFunction);
					this.m_GetValidAnnouncements_hotfix = (luaObj.RawGet("GetValidAnnouncements") as LuaFunction);
					this.m_RemoveGlobalAnnouncementUInt64_hotfix = (luaObj.RawGet("RemoveGlobalAnnouncement") as LuaFunction);
					this.m_RemoveAllExpiredAnnouncements_hotfix = (luaObj.RawGet("RemoveAllExpiredAnnouncements") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06007461 RID: 29793 RVA: 0x00201360 File Offset: 0x001FF560
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(OperationalActivityCompoment));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400559C RID: 21916
		[DoNotToLua]
		private OperationalActivityCompoment.LuaExportHelper luaExportHelper;

		// Token: 0x0400559D RID: 21917
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400559E RID: 21918
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400559F RID: 21919
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040055A0 RID: 21920
		private LuaFunction m_Init_hotfix;

		// Token: 0x040055A1 RID: 21921
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x040055A2 RID: 21922
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x040055A3 RID: 21923
		private LuaFunction m_ExchangeItemGroupUInt64Int32_hotfix;

		// Token: 0x040055A4 RID: 21924
		private LuaFunction m_GainRewardUInt64Int32_hotfix;

		// Token: 0x040055A5 RID: 21925
		private LuaFunction m_DeserializeDSOperationalActivityNtf_hotfix;

		// Token: 0x040055A6 RID: 21926
		private LuaFunction m_DeserializeDSAnnouncementNtf_hotfix;

		// Token: 0x040055A7 RID: 21927
		private LuaFunction m_DeserializeAdvertisementFlowLayoutUpdateNtf_hotfix;

		// Token: 0x040055A8 RID: 21928
		private LuaFunction m_GetDSVersion_hotfix;

		// Token: 0x040055A9 RID: 21929
		private LuaFunction m_GetAnnouncementDSVersion_hotfix;

		// Token: 0x040055AA RID: 21930
		private LuaFunction m_AddNewOperationalActivityProOperationalActivityBasicInfo_hotfix;

		// Token: 0x040055AB RID: 21931
		private LuaFunction m_AddRedeemActivityInt32RedeemInfoAck_hotfix;

		// Token: 0x040055AC RID: 21932
		private LuaFunction m_AddFansRewardFromPBTCBTActivityInt32Int64Int64Boolean_hotfix;

		// Token: 0x040055AD RID: 21933
		private LuaFunction m_AddAnnouncementProAnnouncement_hotfix;

		// Token: 0x040055AE RID: 21934
		private LuaFunction m_UpdateOperationalActivityProOperationalActivityBasicInfo_hotfix;

		// Token: 0x040055AF RID: 21935
		private LuaFunction m_GetValidAnnouncements_hotfix;

		// Token: 0x040055B0 RID: 21936
		private LuaFunction m_RemoveGlobalAnnouncementUInt64_hotfix;

		// Token: 0x040055B1 RID: 21937
		private LuaFunction m_RemoveAllExpiredAnnouncements_hotfix;

		// Token: 0x020008D2 RID: 2258
		public new class LuaExportHelper
		{
			// Token: 0x06007462 RID: 29794 RVA: 0x002013C8 File Offset: 0x001FF5C8
			public LuaExportHelper(OperationalActivityCompoment owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06007463 RID: 29795 RVA: 0x002013D8 File Offset: 0x001FF5D8
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x06007464 RID: 29796 RVA: 0x002013E8 File Offset: 0x001FF5E8
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x06007465 RID: 29797 RVA: 0x002013F8 File Offset: 0x001FF5F8
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x06007466 RID: 29798 RVA: 0x00201408 File Offset: 0x001FF608
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x06007467 RID: 29799 RVA: 0x00201418 File Offset: 0x001FF618
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x06007468 RID: 29800 RVA: 0x00201428 File Offset: 0x001FF628
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x06007469 RID: 29801 RVA: 0x00201438 File Offset: 0x001FF638
			public void __callBase_OnFlushLoginDaysEvent()
			{
				this.m_owner.__callBase_OnFlushLoginDaysEvent();
			}

			// Token: 0x0600746A RID: 29802 RVA: 0x00201448 File Offset: 0x001FF648
			public void __callBase_OnFlushSuccessCallBack(OperationalActivityBase activity)
			{
				this.m_owner.__callBase_OnFlushSuccessCallBack(activity);
			}

			// Token: 0x0600746B RID: 29803 RVA: 0x00201458 File Offset: 0x001FF658
			public void __callBase_OnPlayerLevelUpEvent(int palyerLevel)
			{
				this.m_owner.__callBase_OnPlayerLevelUpEvent(palyerLevel);
			}

			// Token: 0x0600746C RID: 29804 RVA: 0x00201468 File Offset: 0x001FF668
			public void __callBase_AddNewOperationalActivity(OperationalActivityBase operationalActivity)
			{
				this.m_owner.__callBase_AddNewOperationalActivity(operationalActivity);
			}

			// Token: 0x0600746D RID: 29805 RVA: 0x00201478 File Offset: 0x001FF678
			public void __callBase_InitNewNewOperationalActivityInfo(OperationalActivityBase operationalActivityInfo)
			{
				this.m_owner.__callBase_InitNewNewOperationalActivityInfo(operationalActivityInfo);
			}

			// Token: 0x0600746E RID: 29806 RVA: 0x00201488 File Offset: 0x001FF688
			public void __callBase_OnAddNewActivityCallBack(OperationalActivityBase activity)
			{
				this.m_owner.__callBase_OnAddNewActivityCallBack(activity);
			}

			// Token: 0x0600746F RID: 29807 RVA: 0x00201498 File Offset: 0x001FF698
			public void __callBase_OnActivityInitCallBack(OperationalActivityBase activity)
			{
				this.m_owner.__callBase_OnActivityInitCallBack(activity);
			}

			// Token: 0x06007470 RID: 29808 RVA: 0x002014A8 File Offset: 0x001FF6A8
			public void __callBase_RemoveAllExpiredOperationalActivities()
			{
				this.m_owner.__callBase_RemoveAllExpiredOperationalActivities();
			}

			// Token: 0x06007471 RID: 29809 RVA: 0x002014B8 File Offset: 0x001FF6B8
			public int __callBase_CanExchangeItemGroup(LimitedTimeExchangeOperationActivity limitedTimeExchangeOperationalActivity, int itemGroupIndex)
			{
				return this.m_owner.__callBase_CanExchangeItemGroup(limitedTimeExchangeOperationalActivity, itemGroupIndex);
			}

			// Token: 0x06007472 RID: 29810 RVA: 0x002014C8 File Offset: 0x001FF6C8
			public int __callBase_CanGainOperactionalActivityReward(OperationalActivityBase operationalActivityBase, int rewardIndex)
			{
				return this.m_owner.__callBase_CanGainOperactionalActivityReward(operationalActivityBase, rewardIndex);
			}

			// Token: 0x06007473 RID: 29811 RVA: 0x002014D8 File Offset: 0x001FF6D8
			public List<OperationalActivityBase> __callBase_GetAllOperationalActivities()
			{
				return this.m_owner.__callBase_GetAllOperationalActivities();
			}

			// Token: 0x06007474 RID: 29812 RVA: 0x002014E8 File Offset: 0x001FF6E8
			public List<OperationalActivityBase> __callBase_GetAllValidOperationalActivities()
			{
				return this.m_owner.__callBase_GetAllValidOperationalActivities();
			}

			// Token: 0x06007475 RID: 29813 RVA: 0x002014F8 File Offset: 0x001FF6F8
			public int __callBase_GetAwardOperationActivityRewardItemGroupIdByIndex(OperationalActivityBase operationalActivity, int rewardIndex)
			{
				return this.m_owner.__callBase_GetAwardOperationActivityRewardItemGroupIdByIndex(operationalActivity, rewardIndex);
			}

			// Token: 0x06007476 RID: 29814 RVA: 0x00201508 File Offset: 0x001FF708
			public void __callBase_EffectOperationActivityGenerateEffect(OperationalActivityBase operationalActivity, bool isPositive)
			{
				this.m_owner.__callBase_EffectOperationActivityGenerateEffect(operationalActivity, isPositive);
			}

			// Token: 0x06007477 RID: 29815 RVA: 0x00201518 File Offset: 0x001FF718
			public OperationalActivityBase __callBase_FindOperationalActivityById(ulong operationalActivityInstanceId)
			{
				return this.m_owner.__callBase_FindOperationalActivityById(operationalActivityInstanceId);
			}

			// Token: 0x06007478 RID: 29816 RVA: 0x00201528 File Offset: 0x001FF728
			public List<OperationalActivityBase> __callBase_FindOperationalActivitiesByType(OperationalActivityType activityType)
			{
				return this.m_owner.__callBase_FindOperationalActivitiesByType(activityType);
			}

			// Token: 0x06007479 RID: 29817 RVA: 0x00201538 File Offset: 0x001FF738
			public OperationalActivityBase __callBase_FindOperationalActivityByActivityCardPoolId(int activityCardPoolId)
			{
				return this.m_owner.__callBase_FindOperationalActivityByActivityCardPoolId(activityCardPoolId);
			}

			// Token: 0x0600747A RID: 29818 RVA: 0x00201548 File Offset: 0x001FF748
			public OperationalActivityBase __callBase_FindOperationalActivityByRafflePoolId(int rafflePoolId)
			{
				return this.m_owner.__callBase_FindOperationalActivityByRafflePoolId(rafflePoolId);
			}

			// Token: 0x0600747B RID: 29819 RVA: 0x00201558 File Offset: 0x001FF758
			public OperationalActivityBase __callBase_FindOperationalActivityByUnchartedScoreId(int UnchartedScoreId)
			{
				return this.m_owner.__callBase_FindOperationalActivityByUnchartedScoreId(UnchartedScoreId);
			}

			// Token: 0x0600747C RID: 29820 RVA: 0x00201568 File Offset: 0x001FF768
			public OperationalActivityBase __callBase_FindShowActivityByUnchartedScoreId(int UnchartedScoreId)
			{
				return this.m_owner.__callBase_FindShowActivityByUnchartedScoreId(UnchartedScoreId);
			}

			// Token: 0x0600747D RID: 29821 RVA: 0x00201578 File Offset: 0x001FF778
			public List<AdvertisementFlowLayout> __callBase_GetAllAdvertisementFlowLayouts()
			{
				return this.m_owner.__callBase_GetAllAdvertisementFlowLayouts();
			}

			// Token: 0x0600747E RID: 29822 RVA: 0x00201588 File Offset: 0x001FF788
			public void __callBase_OnBuyStoreItemCallBack(int storeId, int goodsId)
			{
				this.m_owner.__callBase_OnBuyStoreItemCallBack(storeId, goodsId);
			}

			// Token: 0x040055B2 RID: 21938
			private OperationalActivityCompoment m_owner;
		}
	}
}
