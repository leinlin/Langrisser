using System;
using System.Collections.Generic;
using System.Threading;
using Assets.Script.ProjectL.Runtime.UI.Activity;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000998 RID: 2456
	[HotFix]
	public class ActivityUIController : UIControllerBase
	{
		// Token: 0x06008DC1 RID: 36289 RVA: 0x00295924 File Offset: 0x00293B24
		protected override void OnBindFiledsCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBindFiledsCompleted_hotfix != null)
			{
				this.m_OnBindFiledsCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnBindFiledsCompleted();
			this.m_returnButton.onClick.AddListener(new UnityAction(this.OnReturnButtonClick));
			this.m_addActivityButton.onClick.AddListener(new UnityAction(this.OnAddActivityButtonClick));
			this.m_goButton.onClick.AddListener(new UnityAction(this.OnGotoButtonClick));
			this.m_getRewardButton.onClick.AddListener(new UnityAction(this.OnGetRewardButtonClick));
		}

		// Token: 0x06008DC2 RID: 36290 RVA: 0x002959FC File Offset: 0x00293BFC
		public void Open()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Open_hotfix != null)
			{
				this.m_Open_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_activityStateCtrl, "Show", null, false, true);
		}

		// Token: 0x06008DC3 RID: 36291 RVA: 0x00295A70 File Offset: 0x00293C70
		public void UpdateViewInActivity()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateViewInActivity_hotfix != null)
			{
				this.m_UpdateViewInActivity_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LocalConfigData data = LocalConfig.Instance.Data;
			this.m_activityGMObj.SetActive(data.IsDeveloper);
			this.SetTab();
		}

		// Token: 0x06008DC4 RID: 36292 RVA: 0x00295AF4 File Offset: 0x00293CF4
		public void OpenSpecificActivity(int activityId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OpenSpecificActivityInt32_hotfix != null)
			{
				this.m_OpenSpecificActivityInt32_hotfix.call(new object[]
				{
					this,
					activityId2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int activityId = activityId2;
			List<OperationalActivityBase> allCurrentActivity = this.m_playerContext.GetAllCurrentActivity();
			OperationalActivityBase activityInfo = allCurrentActivity.Find((OperationalActivityBase m) => m.ActivityId == activityId);
			if (activityInfo == null)
			{
				return;
			}
			if (!this.m_instanceIDList.Contains(activityInfo.InstanceId))
			{
				return;
			}
			int num = this.m_instanceIDList.FindIndex((ulong m) => m == activityInfo.InstanceId);
			if (num < 0 || num >= this.m_tabList.Count)
			{
				return;
			}
			GameObject gameObject = this.m_tabList[num];
			if (gameObject != null)
			{
				gameObject.GetComponent<Toggle>().isOn = true;
			}
		}

		// Token: 0x06008DC5 RID: 36293 RVA: 0x00295C14 File Offset: 0x00293E14
		private void SetTab()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTab_hotfix != null)
			{
				this.m_SetTab_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyChildren(this.m_leftSidebarScrollViewContent);
			this.m_tabList.Clear();
			this.m_instanceIDList.Clear();
			this.m_announcementPanelObj.SetActive(false);
			this.m_activityPanelObj.SetActive(false);
			List<Announcement> allCurrentAnnouncements = this.m_playerContext.GetAllCurrentAnnouncements();
			this.announceCount = allCurrentAnnouncements.Count;
			LocalAccountConfigData cfg = LocalAccountConfig.Instance.Data;
			this.m_readAnnounceActivityList.Clear();
			int i;
			if (cfg.HaveReadAnnounceActivities != null)
			{
				string[] haveReadAnnounceActivities = cfg.HaveReadAnnounceActivities;
				for (i = 0; i < haveReadAnnounceActivities.Length; i++)
				{
					string s = haveReadAnnounceActivities[i];
					this.m_readAnnounceActivityList.Add(ulong.Parse(s));
				}
			}
			if (allCurrentAnnouncements != null && allCurrentAnnouncements.Count > 0)
			{
				allCurrentAnnouncements.Sort(new Comparison<Announcement>(this.AnnouncementComparer));
				using (List<Announcement>.Enumerator enumerator = allCurrentAnnouncements.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ActivityUIController.<SetTab>c__AnonStorey1 <SetTab>c__AnonStorey2 = new ActivityUIController.<SetTab>c__AnonStorey1();
						<SetTab>c__AnonStorey2.item = enumerator.Current;
						this.m_activityNameText.text = <SetTab>c__AnonStorey2.item.Title;
						this.m_activityNameDarkText.text = <SetTab>c__AnonStorey2.item.Title;
						this.m_tabNewLogo.SetActive(<SetTab>c__AnonStorey2.item.ShowStartTime.Year == this.m_playerContext.GetServerTime().Year && <SetTab>c__AnonStorey2.item.ShowStartTime.DayOfYear == this.m_playerContext.GetServerTime().DayOfYear && !this.m_readAnnounceActivityList.Contains(<SetTab>c__AnonStorey2.item.InstanceId));
						this.m_tabRedPoint.SetActive(false);
						this.m_tabIcon.sprite = AssetUtility.Instance.GetSprite("UI/Activity_ABS/Icon_Repair.png");
						GameObject go = UnityEngine.Object.Instantiate<GameObject>(this.m_toggleItemPrefab);
						this.m_tabList.Add(go);
						this.m_instanceIDList.Add(<SetTab>c__AnonStorey2.item.InstanceId);
						go.GetComponent<Toggle>().onValueChanged.AddListener(delegate(bool isOn)
						{
							if (isOn)
							{
								this.m_activityIsOn = false;
								this.m_goButton.gameObject.SetActive(false);
								this.m_getRewardButton.gameObject.SetActive(false);
								this.m_ReceivedRewardObj.SetActive(false);
								this.SetCurrentAnnouncement(<SetTab>c__AnonStorey2.item);
								go.transform.Find("ItemContent/NewLogo").gameObject.SetActive(false);
								if (!this.m_readAnnounceActivityList.Contains(<SetTab>c__AnonStorey2.item.InstanceId))
								{
									this.m_readAnnounceActivityList.Add(<SetTab>c__AnonStorey2.item.InstanceId);
									cfg.HaveReadAnnounceActivities = this.m_readAnnounceActivityList.ConvertAll<string>((ulong i) => i.ToString()).ToArray();
									LocalAccountConfig.Instance.Save();
								}
							}
						});
						go.transform.SetParent(this.m_leftSidebarScrollViewContent.transform, false);
						go.SetActive(true);
					}
				}
			}
			List<OperationalActivityBase> allCurrentActivity = this.m_playerContext.GetAllCurrentActivity();
			if (allCurrentActivity != null && allCurrentActivity.Count > 0)
			{
				allCurrentActivity.Sort(new Comparison<OperationalActivityBase>(this.ActivityComparer));
				using (List<OperationalActivityBase>.Enumerator enumerator2 = allCurrentActivity.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						ActivityUIController.<SetTab>c__AnonStorey4 <SetTab>c__AnonStorey4 = new ActivityUIController.<SetTab>c__AnonStorey4();
						<SetTab>c__AnonStorey4.item = enumerator2.Current;
						this.m_activityNameText.text = <SetTab>c__AnonStorey4.item.Config.Title;
						this.m_activityNameDarkText.text = <SetTab>c__AnonStorey4.item.Config.Title;
						this.m_tabNewLogo.SetActive(<SetTab>c__AnonStorey4.item.OperationStartTime.Year == this.m_playerContext.GetServerTime().Year && <SetTab>c__AnonStorey4.item.OperationStartTime.DayOfYear == this.m_playerContext.GetServerTime().DayOfYear && !this.m_readAnnounceActivityList.Contains(<SetTab>c__AnonStorey4.item.InstanceId));
						this.m_tabRedPoint.SetActive(this.m_playerContext.IsTabRedPointShow(<SetTab>c__AnonStorey4.item));
						this.m_tabIcon.sprite = AssetUtility.Instance.GetSprite("UI/Activity_ABS/Icon_activity.png");
						GameObject go = UnityEngine.Object.Instantiate<GameObject>(this.m_toggleItemPrefab);
						this.m_tabList.Add(go);
						this.m_instanceIDList.Add(<SetTab>c__AnonStorey4.item.InstanceId);
						go.GetComponent<Toggle>().onValueChanged.AddListener(delegate(bool isOn)
						{
							if (isOn)
							{
								if (!this.IsActivityInOperationPeriod(<SetTab>c__AnonStorey4.item))
								{
									this.SetTab();
									return;
								}
								this.m_currentActivity = <SetTab>c__AnonStorey4.item;
								this.m_activityIsOn = true;
								this.m_goButton.gameObject.SetActive(false);
								this.m_getRewardButton.gameObject.SetActive(false);
								this.m_ReceivedRewardObj.SetActive(false);
								this.m_BigImage.gameObject.SetActive(false);
								this.m_activityScrollView.SetActive(true);
								go.transform.Find("ItemContent/NewLogo").gameObject.SetActive(false);
								this.SetCurrentActivity(true);
								if (!this.m_readAnnounceActivityList.Contains(<SetTab>c__AnonStorey4.item.InstanceId))
								{
									this.m_readAnnounceActivityList.Add(<SetTab>c__AnonStorey4.item.InstanceId);
									cfg.HaveReadAnnounceActivities = this.m_readAnnounceActivityList.ConvertAll<string>((ulong i) => i.ToString()).ToArray();
									LocalAccountConfig.Instance.Save();
								}
							}
						});
						go.transform.SetParent(this.m_leftSidebarScrollViewContent.transform, false);
						go.SetActive(true);
					}
				}
			}
			if (this.m_readAnnounceActivityList.Count > 0)
			{
				for (int j = 0; j < this.m_readAnnounceActivityList.Count; j++)
				{
					ulong item = this.m_readAnnounceActivityList[j];
					if (!this.m_instanceIDList.Contains(item))
					{
						this.m_readAnnounceActivityList.Remove(item);
						cfg.HaveReadAnnounceActivities = this.m_readAnnounceActivityList.ConvertAll<string>((ulong x) => x.ToString()).ToArray();
						LocalAccountConfig.Instance.Save();
					}
				}
			}
			if (this.m_tabList != null && this.m_tabList.Count > 0)
			{
				this.m_tabList[0].GetComponent<Toggle>().isOn = true;
			}
			this.m_leftSidebarScrollView.GetComponent<ScrollRect>().normalizedPosition = Vector2.one;
		}

		// Token: 0x06008DC6 RID: 36294 RVA: 0x0029623C File Offset: 0x0029443C
		protected bool IsActivityInOperationPeriod(OperationalActivityBase activity)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsActivityInOperationPeriodOperationalActivityBase_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsActivityInOperationPeriodOperationalActivityBase_hotfix.call(new object[]
				{
					this,
					activity
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return activity != null && !activity.IsExpiredOperationalActivity(this.m_playerContext.GetCurrServerTime());
		}

		// Token: 0x06008DC7 RID: 36295 RVA: 0x002962D8 File Offset: 0x002944D8
		private void SetCurrentAnnouncement(Announcement currAnnouncement)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCurrentAnnouncementAnnouncement_hotfix != null)
			{
				this.m_SetCurrentAnnouncementAnnouncement_hotfix.call(new object[]
				{
					this,
					currAnnouncement
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_announcementScrollView.GetComponent<ScrollRect>().normalizedPosition = Vector2.one;
			this.m_announcementContentText.text = currAnnouncement.Content;
			this.m_activityPanelObj.SetActive(false);
			this.m_announcementPanelObj.SetActive(true);
		}

		// Token: 0x06008DC8 RID: 36296 RVA: 0x00296388 File Offset: 0x00294588
		public void SetCurrentActivity(bool needRefreshToTop)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCurrentActivityBoolean_hotfix != null)
			{
				this.m_SetCurrentActivityBoolean_hotfix.call(new object[]
				{
					this,
					needRefreshToTop
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (needRefreshToTop)
			{
				this.m_activityScrollView.GetComponent<ScrollRect>().normalizedPosition = Vector2.one;
			}
			this.m_activityTimeText.text = this.m_currentActivity.OperationStartTime.ToString("yyyy.MM.dd") + " ~ " + this.m_currentActivity.OperationEndTime.ToString("yyyy.MM.dd");
			if (this.m_currentActivity.ActivityType == OperationalActivityType.OperationalActivityType_Redeem)
			{
				this.m_activityContentText.text = this.GetRedeemContent();
			}
			else
			{
				this.m_activityContentText.text = this.m_currentActivity.Config.Content;
			}
			if (this.m_currentActivity.ActivityType == OperationalActivityType.OperationalActivityType_BuyItemGuide)
			{
				this.m_BigImage.sprite = AssetUtility.Instance.GetSprite(this.m_currentActivity.Config.AdvertisingImage);
				this.m_activityPanelStateCtrl.SetToUIState("CloseBillboard", false, true);
			}
			else if (!string.IsNullOrEmpty(this.m_currentActivity.Config.AdvertisingImage))
			{
				this.m_activityBillboardImage.sprite = AssetUtility.Instance.GetSprite(this.m_currentActivity.Config.AdvertisingImage);
				this.m_activityPanelStateCtrl.SetToUIState("ShowBillboard", false, true);
			}
			else
			{
				this.m_activityPanelStateCtrl.SetToUIState("CloseBillboard", false, true);
			}
			if (this.m_currentActivity.ActivityType == OperationalActivityType.OperationalActivityType_BuyItemGuide)
			{
				this.m_playerContext.SetBuyGuideActivityViewed();
			}
			this.SetActivityRewardPanel(this.m_currentActivity);
			this.SetTabRedPoint();
			this.m_announcementPanelObj.SetActive(false);
			this.m_activityPanelObj.SetActive(true);
		}

		// Token: 0x06008DC9 RID: 36297 RVA: 0x00296598 File Offset: 0x00294798
		private void SetTabRedPoint()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTabRedPoint_hotfix != null)
			{
				this.m_SetTabRedPoint_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			for (int i = this.announceCount; i < this.m_tabList.Count; i++)
			{
				if (this.m_tabList[i].activeSelf && this.m_tabList[i].GetComponent<Toggle>().isOn)
				{
					this.m_tabList[i].transform.Find("ItemContent/RedPoint").gameObject.SetActive(this.m_playerContext.IsTabRedPointShow(this.m_currentActivity));
				}
			}
		}

		// Token: 0x06008DCA RID: 36298 RVA: 0x00296680 File Offset: 0x00294880
		private void SetActivityRewardPanel(OperationalActivityBase activity)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetActivityRewardPanelOperationalActivityBase_hotfix != null)
			{
				this.m_SetActivityRewardPanelOperationalActivityBase_hotfix.call(new object[]
				{
					this,
					activity
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyChildren(this.m_activityRewardList);
			switch (activity.ActivityType)
			{
			case OperationalActivityType.OperationalActivityType_PlayerLevelUp:
			case OperationalActivityType.OperationalActivityType_LimitedTimeExchange:
			case OperationalActivityType.OperationalActivityType_SpecificDaysLogin:
			case OperationalActivityType.OperationalActivityType_AccumulateDaysLogin:
			case OperationalActivityType.OperationalActivityType_AccumulateRecharge:
			case OperationalActivityType.OperationalActivityType_AccumulateConsumeCrystal:
				this.m_activityRewardTitleObj.SetActive(true);
				this.m_activityRewardList.SetActive(true);
				this.SetRewardListPanel(activity);
				break;
			case OperationalActivityType.OperationalActivityType_RewardAdd:
			case OperationalActivityType.OperationalActivityType_ChallengeNumsAdd:
				this.m_activityRewardTitleObj.SetActive(false);
				this.m_activityRewardList.SetActive(false);
				break;
			case OperationalActivityType.OperationalActivityType_ActivitySelectCard:
				this.m_activityRewardTitleObj.SetActive(false);
				this.m_activityRewardList.SetActive(false);
				this.m_goButton.gameObject.SetActive(true);
				break;
			case OperationalActivityType.OperationalActivityType_Raffle:
				this.m_activityRewardTitleObj.SetActive(true);
				this.m_activityRewardList.SetActive(true);
				this.SetRaffleRewardPanel(activity);
				break;
			case OperationalActivityType.OperationalActivityType_UnchartedScore:
				this.m_activityRewardTitleObj.SetActive(false);
				this.m_activityRewardList.SetActive(false);
				this.m_goButton.gameObject.SetActive(true);
				break;
			case OperationalActivityType.OperationalActivityType_Redeem:
			{
				this.m_activityRewardTitleObj.SetActive(false);
				this.m_activityRewardList.SetActive(false);
				bool flag = this.m_playerContext.IsRedeemClaimed();
				this.m_getRewardButton.gameObject.SetActive(!flag);
				this.m_ReceivedRewardObj.SetActive(flag);
				break;
			}
			case OperationalActivityType.OperationalActivityType_Web:
				this.m_activityRewardTitleObj.SetActive(false);
				this.m_activityRewardList.SetActive(false);
				this.m_goButton.gameObject.SetActive(true);
				break;
			case OperationalActivityType.OperationalActivityType_BuyItemGuide:
				this.m_activityRewardTitleObj.SetActive(false);
				this.m_activityRewardList.SetActive(false);
				this.m_activityScrollView.SetActive(false);
				this.m_BigImage.gameObject.SetActive(true);
				this.m_goButton.gameObject.SetActive(true);
				break;
			case OperationalActivityType.OperationalActivityType_PBTCBTFansRewards:
			{
				FansRewardsFromPBTCBTActivity fansRewardsFromPBTCBTActivity = (FansRewardsFromPBTCBTActivity)activity;
				this.m_activityRewardTitleObj.SetActive(false);
				this.m_activityRewardList.SetActive(false);
				this.m_getRewardButton.gameObject.SetActive(!fansRewardsFromPBTCBTActivity.claimed);
				this.m_ReceivedRewardObj.SetActive(fansRewardsFromPBTCBTActivity.claimed);
				break;
			}
			}
		}

		// Token: 0x06008DCB RID: 36299 RVA: 0x0029691C File Offset: 0x00294B1C
		private void SetRewardListPanel(OperationalActivityBase activity)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRewardListPanelOperationalActivityBase_hotfix != null)
			{
				this.m_SetRewardListPanelOperationalActivityBase_hotfix.call(new object[]
				{
					this,
					activity
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (activity.Config.OperationalActivityParms != null && activity.Config.OperationalActivityParms.Count > 0)
			{
				for (int i = 0; i < activity.Config.OperationalActivityParms.Count; i++)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_activityRewardPrefab);
					gameObject.transform.SetParent(this.m_activityRewardList.transform, false);
					GameObject assetInContainer = base.GetAssetInContainer<GameObject>("ActivityRewardItem");
					ActivityRewardUIController activityRewardUIController = GameObjectUtility.AddControllerToGameObject<ActivityRewardUIController>(gameObject);
					activityRewardUIController.EventOnGainRewardButtonClick += this.OnGainRewardButtonClick;
					activityRewardUIController.EventOnExchangeItemGroupButtonClick += this.OnExchangeItemGroupButtonClick;
					activityRewardUIController.EventOnCrystalNotEnough += this.OnExchangeItemGroupCrystalNotEnough;
					activityRewardUIController.SetActivityRewardPanel(activity, i, assetInContainer);
				}
			}
		}

		// Token: 0x06008DCC RID: 36300 RVA: 0x00296A48 File Offset: 0x00294C48
		protected void SetRaffleRewardPanel(OperationalActivityBase activity)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRaffleRewardPanelOperationalActivityBase_hotfix != null)
			{
				this.m_SetRaffleRewardPanelOperationalActivityBase_hotfix.call(new object[]
				{
					this,
					activity
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_goButton.gameObject.SetActive(true);
			int parm = activity.Config.OperationalActivityParms[0].Parm1;
			RafflePool rafflePool = this.m_playerContext.GetRafflePool(parm);
			if (rafflePool == null)
			{
				global::Debug.LogError(string.Format("SetRaffleRewardPanel error: rafflePool id = {0} not exist !", parm));
				return;
			}
			Dictionary<int, List<RaffleItem>> dictionary = this.GainRaffleRewardLevelInfo(rafflePool);
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("RaffleRewardItemUIPrefab");
			foreach (KeyValuePair<int, List<RaffleItem>> keyValuePair in dictionary)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
				gameObject.transform.SetParent(this.m_activityRewardList.transform, false);
				PrefabControllerCreater.CreateAllControllers(gameObject);
				RaffleRewardItemUIController componentInChildren = gameObject.GetComponentInChildren<RaffleRewardItemUIController>(true);
				componentInChildren.UpdateRaffleRewardItemInfo(keyValuePair.Key, keyValuePair.Value, rafflePool.DrawedRaffleIds);
			}
		}

		// Token: 0x06008DCD RID: 36301 RVA: 0x00296BB0 File Offset: 0x00294DB0
		protected Dictionary<int, List<RaffleItem>> GainRaffleRewardLevelInfo(RafflePool rafflePool)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GainRaffleRewardLevelInfoRafflePool_hotfix != null)
			{
				return (Dictionary<int, List<RaffleItem>>)this.m_GainRaffleRewardLevelInfoRafflePool_hotfix.call(new object[]
				{
					this,
					rafflePool
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Dictionary<int, List<RaffleItem>> dictionary = new Dictionary<int, List<RaffleItem>>();
			foreach (RaffleItem raffleItem in rafflePool.Config.RaffleItems)
			{
				if (!dictionary.ContainsKey(raffleItem.RaffleLevel))
				{
					dictionary[raffleItem.RaffleLevel] = new List<RaffleItem>();
				}
				dictionary[raffleItem.RaffleLevel].Add(raffleItem);
			}
			return dictionary;
		}

		// Token: 0x06008DCE RID: 36302 RVA: 0x00296CB4 File Offset: 0x00294EB4
		private string GetRedeemContent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRedeemContent_hotfix != null)
			{
				return (string)this.m_GetRedeemContent_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			RedeemInfoAck redeemInfo = this.m_playerContext.GetRedeemInfo();
			if (redeemInfo != null && redeemInfo.Bundle != null)
			{
				return string.Format(this.m_currentActivity.Config.Content, redeemInfo.TotalRecharge.ToString(), redeemInfo.Bundle.Total.ToString());
			}
			return string.Empty;
		}

		// Token: 0x06008DCF RID: 36303 RVA: 0x00296D88 File Offset: 0x00294F88
		private int AnnouncementComparer(Announcement announcementA, Announcement announcementB)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AnnouncementComparerAnnouncementAnnouncement_hotfix != null)
			{
				return Convert.ToInt32(this.m_AnnouncementComparerAnnouncementAnnouncement_hotfix.call(new object[]
				{
					this,
					announcementA,
					announcementB
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (announcementA.InstanceId == announcementB.InstanceId)
			{
				return 0;
			}
			if (announcementA.InstanceId > announcementB.InstanceId)
			{
				return -1;
			}
			return 1;
		}

		// Token: 0x06008DD0 RID: 36304 RVA: 0x00296E3C File Offset: 0x0029503C
		private int ActivityComparer(OperationalActivityBase activityA, OperationalActivityBase activityB)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActivityComparerOperationalActivityBaseOperationalActivityBase_hotfix != null)
			{
				return Convert.ToInt32(this.m_ActivityComparerOperationalActivityBaseOperationalActivityBase_hotfix.call(new object[]
				{
					this,
					activityA,
					activityB
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (activityA.Config.SortID != activityB.Config.SortID)
			{
				return activityA.Config.SortID - activityB.Config.SortID;
			}
			return activityA.Config.ID - activityB.Config.ID;
		}

		// Token: 0x06008DD1 RID: 36305 RVA: 0x00296F14 File Offset: 0x00295114
		private void OnGainRewardButtonClick(ulong activityInstanceID, int rewardIndex, ActivityRewardUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGainRewardButtonClickUInt64Int32ActivityRewardUIController_hotfix != null)
			{
				this.m_OnGainRewardButtonClickUInt64Int32ActivityRewardUIController_hotfix.call(new object[]
				{
					this,
					activityInstanceID,
					rewardIndex,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsActivityInOperationPeriod(this.m_currentActivity))
			{
				this.SetTab();
				CommonUIController.Instance.ShowErrorMessage(-2216, 2f, null, true);
				return;
			}
			OperationalActivityBase operationalActivityBase = this.m_playerContext.FindOperationalActivityById(activityInstanceID);
			int num = this.m_playerContext.CanActivityGainRewardResult(operationalActivityBase, rewardIndex);
			if (num == 0 || num == -500)
			{
				if (this.EventOnGainReward != null)
				{
					this.EventOnGainReward(activityInstanceID, rewardIndex, ctrl.m_rewardList);
				}
			}
			else
			{
				this.SetTab();
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x06008DD2 RID: 36306 RVA: 0x0029703C File Offset: 0x0029523C
		private void OnExchangeItemGroupButtonClick(ulong activityInstanceID, int itemGroupIndex, ActivityRewardUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnExchangeItemGroupButtonClickUInt64Int32ActivityRewardUIController_hotfix != null)
			{
				this.m_OnExchangeItemGroupButtonClickUInt64Int32ActivityRewardUIController_hotfix.call(new object[]
				{
					this,
					activityInstanceID,
					itemGroupIndex,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnExchangeItemGroup != null)
			{
				this.EventOnExchangeItemGroup(activityInstanceID, itemGroupIndex, ctrl.m_rewardList);
			}
		}

		// Token: 0x06008DD3 RID: 36307 RVA: 0x002970EC File Offset: 0x002952EC
		private void OnExchangeItemGroupCrystalNotEnough()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnExchangeItemGroupCrystalNotEnough_hotfix != null)
			{
				this.m_OnExchangeItemGroupCrystalNotEnough_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnCrystalNotEnough != null)
			{
				this.EventOnCrystalNotEnough();
			}
		}

		// Token: 0x06008DD4 RID: 36308 RVA: 0x00297164 File Offset: 0x00295364
		private void OnReturnButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnReturnButtonClick_hotfix != null)
			{
				this.m_OnReturnButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnReturn != null)
			{
				this.m_activityIsOn = false;
				this.EventOnReturn();
			}
		}

		// Token: 0x06008DD5 RID: 36309 RVA: 0x002971E4 File Offset: 0x002953E4
		private void OnAddActivityButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAddActivityButtonClick_hotfix != null)
			{
				this.m_OnAddActivityButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnAddActivity != null)
			{
				this.EventOnAddActivity(this.m_activityInputField.text);
			}
		}

		// Token: 0x06008DD6 RID: 36310 RVA: 0x00297268 File Offset: 0x00295468
		protected void OnGotoButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGotoButtonClick_hotfix != null)
			{
				this.m_OnGotoButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsActivityInOperationPeriod(this.m_currentActivity))
			{
				this.SetTab();
				CommonUIController.Instance.ShowErrorMessage(-2216, 2f, null, true);
				return;
			}
			if (this.m_currentActivity != null && this.EventOnGoToButtonClick != null)
			{
				this.EventOnGoToButtonClick(this.m_currentActivity);
			}
		}

		// Token: 0x06008DD7 RID: 36311 RVA: 0x00297320 File Offset: 0x00295520
		protected void OnGetRewardButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGetRewardButtonClick_hotfix != null)
			{
				this.m_OnGetRewardButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_currentActivity != null && this.EventOnGetRewardButtonClick != null)
			{
				this.EventOnGetRewardButtonClick(this.m_currentActivity);
			}
		}

		// Token: 0x14000184 RID: 388
		// (add) Token: 0x06008DD8 RID: 36312 RVA: 0x002973A8 File Offset: 0x002955A8
		// (remove) Token: 0x06008DD9 RID: 36313 RVA: 0x00297444 File Offset: 0x00295644
		public event Action EventOnReturn
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnReturnAction_hotfix != null)
				{
					this.m_add_EventOnReturnAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnReturn;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnReturn, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnReturnAction_hotfix != null)
				{
					this.m_remove_EventOnReturnAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnReturn;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnReturn, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000185 RID: 389
		// (add) Token: 0x06008DDA RID: 36314 RVA: 0x002974E0 File Offset: 0x002956E0
		// (remove) Token: 0x06008DDB RID: 36315 RVA: 0x0029757C File Offset: 0x0029577C
		public event Action<ulong, int, List<Goods>> EventOnGainReward
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGainRewardAction`3_hotfix != null)
				{
					this.m_add_EventOnGainRewardAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ulong, int, List<Goods>> action = this.EventOnGainReward;
				Action<ulong, int, List<Goods>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ulong, int, List<Goods>>>(ref this.EventOnGainReward, (Action<ulong, int, List<Goods>>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGainRewardAction`3_hotfix != null)
				{
					this.m_remove_EventOnGainRewardAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ulong, int, List<Goods>> action = this.EventOnGainReward;
				Action<ulong, int, List<Goods>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ulong, int, List<Goods>>>(ref this.EventOnGainReward, (Action<ulong, int, List<Goods>>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000186 RID: 390
		// (add) Token: 0x06008DDC RID: 36316 RVA: 0x00297618 File Offset: 0x00295818
		// (remove) Token: 0x06008DDD RID: 36317 RVA: 0x002976B4 File Offset: 0x002958B4
		public event Action<ulong, int, List<Goods>> EventOnExchangeItemGroup
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnExchangeItemGroupAction`3_hotfix != null)
				{
					this.m_add_EventOnExchangeItemGroupAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ulong, int, List<Goods>> action = this.EventOnExchangeItemGroup;
				Action<ulong, int, List<Goods>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ulong, int, List<Goods>>>(ref this.EventOnExchangeItemGroup, (Action<ulong, int, List<Goods>>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnExchangeItemGroupAction`3_hotfix != null)
				{
					this.m_remove_EventOnExchangeItemGroupAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ulong, int, List<Goods>> action = this.EventOnExchangeItemGroup;
				Action<ulong, int, List<Goods>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ulong, int, List<Goods>>>(ref this.EventOnExchangeItemGroup, (Action<ulong, int, List<Goods>>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000187 RID: 391
		// (add) Token: 0x06008DDE RID: 36318 RVA: 0x00297750 File Offset: 0x00295950
		// (remove) Token: 0x06008DDF RID: 36319 RVA: 0x002977EC File Offset: 0x002959EC
		public event Action<string> EventOnAddActivity
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAddActivityAction`1_hotfix != null)
				{
					this.m_add_EventOnAddActivityAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnAddActivity;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnAddActivity, (Action<string>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAddActivityAction`1_hotfix != null)
				{
					this.m_remove_EventOnAddActivityAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnAddActivity;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnAddActivity, (Action<string>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000188 RID: 392
		// (add) Token: 0x06008DE0 RID: 36320 RVA: 0x00297888 File Offset: 0x00295A88
		// (remove) Token: 0x06008DE1 RID: 36321 RVA: 0x00297924 File Offset: 0x00295B24
		public event Action<OperationalActivityBase> EventOnGoToButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGoToButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnGoToButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<OperationalActivityBase> action = this.EventOnGoToButtonClick;
				Action<OperationalActivityBase> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<OperationalActivityBase>>(ref this.EventOnGoToButtonClick, (Action<OperationalActivityBase>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGoToButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnGoToButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<OperationalActivityBase> action = this.EventOnGoToButtonClick;
				Action<OperationalActivityBase> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<OperationalActivityBase>>(ref this.EventOnGoToButtonClick, (Action<OperationalActivityBase>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000189 RID: 393
		// (add) Token: 0x06008DE2 RID: 36322 RVA: 0x002979C0 File Offset: 0x00295BC0
		// (remove) Token: 0x06008DE3 RID: 36323 RVA: 0x00297A5C File Offset: 0x00295C5C
		public event Action<OperationalActivityBase> EventOnGetRewardButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGetRewardButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnGetRewardButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<OperationalActivityBase> action = this.EventOnGetRewardButtonClick;
				Action<OperationalActivityBase> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<OperationalActivityBase>>(ref this.EventOnGetRewardButtonClick, (Action<OperationalActivityBase>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGetRewardButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnGetRewardButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<OperationalActivityBase> action = this.EventOnGetRewardButtonClick;
				Action<OperationalActivityBase> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<OperationalActivityBase>>(ref this.EventOnGetRewardButtonClick, (Action<OperationalActivityBase>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400018A RID: 394
		// (add) Token: 0x06008DE4 RID: 36324 RVA: 0x00297AF8 File Offset: 0x00295CF8
		// (remove) Token: 0x06008DE5 RID: 36325 RVA: 0x00297B94 File Offset: 0x00295D94
		public event Action EventOnCrystalNotEnough
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCrystalNotEnoughAction_hotfix != null)
				{
					this.m_add_EventOnCrystalNotEnoughAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCrystalNotEnough;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCrystalNotEnough, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCrystalNotEnoughAction_hotfix != null)
				{
					this.m_remove_EventOnCrystalNotEnoughAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCrystalNotEnough;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCrystalNotEnough, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17001DAD RID: 7597
		// (get) Token: 0x06008DE6 RID: 36326 RVA: 0x00297C30 File Offset: 0x00295E30
		// (set) Token: 0x06008DE7 RID: 36327 RVA: 0x00297C50 File Offset: 0x00295E50
		[DoNotToLua]
		public new ActivityUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ActivityUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06008DE8 RID: 36328 RVA: 0x00297C5C File Offset: 0x00295E5C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06008DE9 RID: 36329 RVA: 0x00297C68 File Offset: 0x00295E68
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06008DEA RID: 36330 RVA: 0x00297C70 File Offset: 0x00295E70
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06008DEB RID: 36331 RVA: 0x00297C78 File Offset: 0x00295E78
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06008DEC RID: 36332 RVA: 0x00297C8C File Offset: 0x00295E8C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06008DED RID: 36333 RVA: 0x00297C94 File Offset: 0x00295E94
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06008DEE RID: 36334 RVA: 0x00297CA0 File Offset: 0x00295EA0
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06008DEF RID: 36335 RVA: 0x00297CAC File Offset: 0x00295EAC
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06008DF0 RID: 36336 RVA: 0x00297CB8 File Offset: 0x00295EB8
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06008DF1 RID: 36337 RVA: 0x00297CC4 File Offset: 0x00295EC4
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06008DF2 RID: 36338 RVA: 0x00297CD0 File Offset: 0x00295ED0
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06008DF3 RID: 36339 RVA: 0x00297CDC File Offset: 0x00295EDC
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06008DF4 RID: 36340 RVA: 0x00297CE8 File Offset: 0x00295EE8
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06008DF5 RID: 36341 RVA: 0x00297CF4 File Offset: 0x00295EF4
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06008DF6 RID: 36342 RVA: 0x00297D00 File Offset: 0x00295F00
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06008DF7 RID: 36343 RVA: 0x00297D08 File Offset: 0x00295F08
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x06008DF8 RID: 36344 RVA: 0x00297D28 File Offset: 0x00295F28
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x06008DF9 RID: 36345 RVA: 0x00297D34 File Offset: 0x00295F34
		private void __callDele_EventOnGainReward(ulong arg1, int arg2, List<Goods> arg3)
		{
			Action<ulong, int, List<Goods>> eventOnGainReward = this.EventOnGainReward;
			if (eventOnGainReward != null)
			{
				eventOnGainReward(arg1, arg2, arg3);
			}
		}

		// Token: 0x06008DFA RID: 36346 RVA: 0x00297D58 File Offset: 0x00295F58
		private void __clearDele_EventOnGainReward(ulong arg1, int arg2, List<Goods> arg3)
		{
			this.EventOnGainReward = null;
		}

		// Token: 0x06008DFB RID: 36347 RVA: 0x00297D64 File Offset: 0x00295F64
		private void __callDele_EventOnExchangeItemGroup(ulong arg1, int arg2, List<Goods> arg3)
		{
			Action<ulong, int, List<Goods>> eventOnExchangeItemGroup = this.EventOnExchangeItemGroup;
			if (eventOnExchangeItemGroup != null)
			{
				eventOnExchangeItemGroup(arg1, arg2, arg3);
			}
		}

		// Token: 0x06008DFC RID: 36348 RVA: 0x00297D88 File Offset: 0x00295F88
		private void __clearDele_EventOnExchangeItemGroup(ulong arg1, int arg2, List<Goods> arg3)
		{
			this.EventOnExchangeItemGroup = null;
		}

		// Token: 0x06008DFD RID: 36349 RVA: 0x00297D94 File Offset: 0x00295F94
		private void __callDele_EventOnAddActivity(string obj)
		{
			Action<string> eventOnAddActivity = this.EventOnAddActivity;
			if (eventOnAddActivity != null)
			{
				eventOnAddActivity(obj);
			}
		}

		// Token: 0x06008DFE RID: 36350 RVA: 0x00297DB8 File Offset: 0x00295FB8
		private void __clearDele_EventOnAddActivity(string obj)
		{
			this.EventOnAddActivity = null;
		}

		// Token: 0x06008DFF RID: 36351 RVA: 0x00297DC4 File Offset: 0x00295FC4
		private void __callDele_EventOnGoToButtonClick(OperationalActivityBase obj)
		{
			Action<OperationalActivityBase> eventOnGoToButtonClick = this.EventOnGoToButtonClick;
			if (eventOnGoToButtonClick != null)
			{
				eventOnGoToButtonClick(obj);
			}
		}

		// Token: 0x06008E00 RID: 36352 RVA: 0x00297DE8 File Offset: 0x00295FE8
		private void __clearDele_EventOnGoToButtonClick(OperationalActivityBase obj)
		{
			this.EventOnGoToButtonClick = null;
		}

		// Token: 0x06008E01 RID: 36353 RVA: 0x00297DF4 File Offset: 0x00295FF4
		private void __callDele_EventOnGetRewardButtonClick(OperationalActivityBase obj)
		{
			Action<OperationalActivityBase> eventOnGetRewardButtonClick = this.EventOnGetRewardButtonClick;
			if (eventOnGetRewardButtonClick != null)
			{
				eventOnGetRewardButtonClick(obj);
			}
		}

		// Token: 0x06008E02 RID: 36354 RVA: 0x00297E18 File Offset: 0x00296018
		private void __clearDele_EventOnGetRewardButtonClick(OperationalActivityBase obj)
		{
			this.EventOnGetRewardButtonClick = null;
		}

		// Token: 0x06008E03 RID: 36355 RVA: 0x00297E24 File Offset: 0x00296024
		private void __callDele_EventOnCrystalNotEnough()
		{
			Action eventOnCrystalNotEnough = this.EventOnCrystalNotEnough;
			if (eventOnCrystalNotEnough != null)
			{
				eventOnCrystalNotEnough();
			}
		}

		// Token: 0x06008E04 RID: 36356 RVA: 0x00297E44 File Offset: 0x00296044
		private void __clearDele_EventOnCrystalNotEnough()
		{
			this.EventOnCrystalNotEnough = null;
		}

		// Token: 0x06008E06 RID: 36358 RVA: 0x00297E60 File Offset: 0x00296060
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				global::Debug.LogError("Can't find HotFixObject Func");
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
					this.m_OnBindFiledsCompleted_hotfix = (luaObj.RawGet("OnBindFiledsCompleted") as LuaFunction);
					this.m_Open_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_UpdateViewInActivity_hotfix = (luaObj.RawGet("UpdateViewInActivity") as LuaFunction);
					this.m_OpenSpecificActivityInt32_hotfix = (luaObj.RawGet("OpenSpecificActivity") as LuaFunction);
					this.m_SetTab_hotfix = (luaObj.RawGet("SetTab") as LuaFunction);
					this.m_IsActivityInOperationPeriodOperationalActivityBase_hotfix = (luaObj.RawGet("IsActivityInOperationPeriod") as LuaFunction);
					this.m_SetCurrentAnnouncementAnnouncement_hotfix = (luaObj.RawGet("SetCurrentAnnouncement") as LuaFunction);
					this.m_SetCurrentActivityBoolean_hotfix = (luaObj.RawGet("SetCurrentActivity") as LuaFunction);
					this.m_SetTabRedPoint_hotfix = (luaObj.RawGet("SetTabRedPoint") as LuaFunction);
					this.m_SetActivityRewardPanelOperationalActivityBase_hotfix = (luaObj.RawGet("SetActivityRewardPanel") as LuaFunction);
					this.m_SetRewardListPanelOperationalActivityBase_hotfix = (luaObj.RawGet("SetRewardListPanel") as LuaFunction);
					this.m_SetRaffleRewardPanelOperationalActivityBase_hotfix = (luaObj.RawGet("SetRaffleRewardPanel") as LuaFunction);
					this.m_GainRaffleRewardLevelInfoRafflePool_hotfix = (luaObj.RawGet("GainRaffleRewardLevelInfo") as LuaFunction);
					this.m_GetRedeemContent_hotfix = (luaObj.RawGet("GetRedeemContent") as LuaFunction);
					this.m_AnnouncementComparerAnnouncementAnnouncement_hotfix = (luaObj.RawGet("AnnouncementComparer") as LuaFunction);
					this.m_ActivityComparerOperationalActivityBaseOperationalActivityBase_hotfix = (luaObj.RawGet("ActivityComparer") as LuaFunction);
					this.m_OnGainRewardButtonClickUInt64Int32ActivityRewardUIController_hotfix = (luaObj.RawGet("OnGainRewardButtonClick") as LuaFunction);
					this.m_OnExchangeItemGroupButtonClickUInt64Int32ActivityRewardUIController_hotfix = (luaObj.RawGet("OnExchangeItemGroupButtonClick") as LuaFunction);
					this.m_OnExchangeItemGroupCrystalNotEnough_hotfix = (luaObj.RawGet("OnExchangeItemGroupCrystalNotEnough") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_OnAddActivityButtonClick_hotfix = (luaObj.RawGet("OnAddActivityButtonClick") as LuaFunction);
					this.m_OnGotoButtonClick_hotfix = (luaObj.RawGet("OnGotoButtonClick") as LuaFunction);
					this.m_OnGetRewardButtonClick_hotfix = (luaObj.RawGet("OnGetRewardButtonClick") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnGainRewardAction`3_hotfix = (luaObj.RawGet("add_EventOnGainReward") as LuaFunction);
					this.m_remove_EventOnGainRewardAction`3_hotfix = (luaObj.RawGet("remove_EventOnGainReward") as LuaFunction);
					this.m_add_EventOnExchangeItemGroupAction`3_hotfix = (luaObj.RawGet("add_EventOnExchangeItemGroup") as LuaFunction);
					this.m_remove_EventOnExchangeItemGroupAction`3_hotfix = (luaObj.RawGet("remove_EventOnExchangeItemGroup") as LuaFunction);
					this.m_add_EventOnAddActivityAction`1_hotfix = (luaObj.RawGet("add_EventOnAddActivity") as LuaFunction);
					this.m_remove_EventOnAddActivityAction`1_hotfix = (luaObj.RawGet("remove_EventOnAddActivity") as LuaFunction);
					this.m_add_EventOnGoToButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnGoToButtonClick") as LuaFunction);
					this.m_remove_EventOnGoToButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnGoToButtonClick") as LuaFunction);
					this.m_add_EventOnGetRewardButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnGetRewardButtonClick") as LuaFunction);
					this.m_remove_EventOnGetRewardButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnGetRewardButtonClick") as LuaFunction);
					this.m_add_EventOnCrystalNotEnoughAction_hotfix = (luaObj.RawGet("add_EventOnCrystalNotEnough") as LuaFunction);
					this.m_remove_EventOnCrystalNotEnoughAction_hotfix = (luaObj.RawGet("remove_EventOnCrystalNotEnough") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06008E07 RID: 36359 RVA: 0x002982B0 File Offset: 0x002964B0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ActivityUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006485 RID: 25733
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_activityStateCtrl;

		// Token: 0x04006486 RID: 25734
		[AutoBind("./Prefab/ToggleItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_toggleItemPrefab;

		// Token: 0x04006487 RID: 25735
		[AutoBind("./Prefab/ToggleItem/ItemContent/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_activityNameText;

		// Token: 0x04006488 RID: 25736
		[AutoBind("./Prefab/ToggleItem/ItemContent/NameTextDark", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_activityNameDarkText;

		// Token: 0x04006489 RID: 25737
		[AutoBind("./Prefab/ToggleItem/ItemContent/Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_tabIcon;

		// Token: 0x0400648A RID: 25738
		[AutoBind("./Prefab/ToggleItem/ItemContent/NewLogo", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_tabNewLogo;

		// Token: 0x0400648B RID: 25739
		[AutoBind("./Prefab/ToggleItem/ItemContent/RedPoint", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_tabRedPoint;

		// Token: 0x0400648C RID: 25740
		[AutoBind("./LeftSidebar/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_leftSidebarScrollView;

		// Token: 0x0400648D RID: 25741
		[AutoBind("./LeftSidebar/ScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_leftSidebarScrollViewContent;

		// Token: 0x0400648E RID: 25742
		[AutoBind("./Activity&AnnounceContent/AnnouncementPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_announcementPanelObj;

		// Token: 0x0400648F RID: 25743
		[AutoBind("./Activity&AnnounceContent/AnnouncementPanel/ScrollView/Viewport/Content/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_announcementContentText;

		// Token: 0x04006490 RID: 25744
		[AutoBind("./Activity&AnnounceContent/AnnouncementPanel/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_announcementScrollView;

		// Token: 0x04006491 RID: 25745
		[AutoBind("./Activity&AnnounceContent/ActivityPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_activityPanelObj;

		// Token: 0x04006492 RID: 25746
		[AutoBind("./Activity&AnnounceContent/ActivityPanel/DetaileScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_activityScrollView;

		// Token: 0x04006493 RID: 25747
		[AutoBind("./Activity&AnnounceContent/ActivityPanel/DetaileScrollView/Viewport/Content/Time/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_activityTimeText;

		// Token: 0x04006494 RID: 25748
		[AutoBind("./Activity&AnnounceContent/ActivityPanel/DetaileScrollView/Viewport/Content/Detail/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_activityContentText;

		// Token: 0x04006495 RID: 25749
		[AutoBind("./Activity&AnnounceContent/ActivityPanel/DetaileScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_activityPanelStateCtrl;

		// Token: 0x04006496 RID: 25750
		[AutoBind("./Activity&AnnounceContent/ActivityPanel/DetaileScrollView/Viewport/Content/BillboardImage/BGImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_activityBillboardImage;

		// Token: 0x04006497 RID: 25751
		[AutoBind("./Activity&AnnounceContent/ActivityPanel/DetaileScrollView/Viewport/Content/ActivityRewardGroup/Title", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_activityRewardTitleObj;

		// Token: 0x04006498 RID: 25752
		[AutoBind("./Activity&AnnounceContent/ActivityPanel/DetaileScrollView/Viewport/Content/ActivityRewardGroup/ActivityRewardList", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_activityRewardList;

		// Token: 0x04006499 RID: 25753
		[AutoBind("./Prefab/ActivityReward", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_activityRewardPrefab;

		// Token: 0x0400649A RID: 25754
		[AutoBind("./Activity&AnnounceContent/ActivityPanel/GoToButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_goButton;

		// Token: 0x0400649B RID: 25755
		[AutoBind("./Activity&AnnounceContent/ActivityPanel/GetRewardButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_getRewardButton;

		// Token: 0x0400649C RID: 25756
		[AutoBind("./Activity&AnnounceContent/ActivityPanel/ReceivedReward", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_ReceivedRewardObj;

		// Token: 0x0400649D RID: 25757
		[AutoBind("./Activity&AnnounceContent/ActivityPanel/BigImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_BigImage;

		// Token: 0x0400649E RID: 25758
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x0400649F RID: 25759
		[AutoBind("./ActivityGM", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_activityGMObj;

		// Token: 0x040064A0 RID: 25760
		[AutoBind("./ActivityGM/ActivityInputField", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_activityInputField;

		// Token: 0x040064A1 RID: 25761
		[AutoBind("./ActivityGM/AddActivityButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_addActivityButton;

		// Token: 0x040064A2 RID: 25762
		public bool m_activityIsOn;

		// Token: 0x040064A3 RID: 25763
		private int announceCount;

		// Token: 0x040064A4 RID: 25764
		private OperationalActivityBase m_currentActivity;

		// Token: 0x040064A5 RID: 25765
		private List<GameObject> m_tabList = new List<GameObject>();

		// Token: 0x040064A6 RID: 25766
		private List<ulong> m_instanceIDList = new List<ulong>();

		// Token: 0x040064A7 RID: 25767
		private List<ulong> m_readAnnounceActivityList = new List<ulong>();

		// Token: 0x040064A8 RID: 25768
		private ProjectLPlayerContext m_playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x040064A9 RID: 25769
		private IConfigDataLoader m_configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;

		// Token: 0x040064AA RID: 25770
		[DoNotToLua]
		private ActivityUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040064AC RID: 25772
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040064AD RID: 25773
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040064AE RID: 25774
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040064AF RID: 25775
		private LuaFunction m_Open_hotfix;

		// Token: 0x040064B0 RID: 25776
		private LuaFunction m_UpdateViewInActivity_hotfix;

		// Token: 0x040064B1 RID: 25777
		private LuaFunction m_OpenSpecificActivityInt32_hotfix;

		// Token: 0x040064B2 RID: 25778
		private LuaFunction m_SetTab_hotfix;

		// Token: 0x040064B3 RID: 25779
		private LuaFunction m_IsActivityInOperationPeriodOperationalActivityBase_hotfix;

		// Token: 0x040064B4 RID: 25780
		private LuaFunction m_SetCurrentAnnouncementAnnouncement_hotfix;

		// Token: 0x040064B5 RID: 25781
		private LuaFunction m_SetCurrentActivityBoolean_hotfix;

		// Token: 0x040064B6 RID: 25782
		private LuaFunction m_SetTabRedPoint_hotfix;

		// Token: 0x040064B7 RID: 25783
		private LuaFunction m_SetActivityRewardPanelOperationalActivityBase_hotfix;

		// Token: 0x040064B8 RID: 25784
		private LuaFunction m_SetRewardListPanelOperationalActivityBase_hotfix;

		// Token: 0x040064B9 RID: 25785
		private LuaFunction m_SetRaffleRewardPanelOperationalActivityBase_hotfix;

		// Token: 0x040064BA RID: 25786
		private LuaFunction m_GainRaffleRewardLevelInfoRafflePool_hotfix;

		// Token: 0x040064BB RID: 25787
		private LuaFunction m_GetRedeemContent_hotfix;

		// Token: 0x040064BC RID: 25788
		private LuaFunction m_AnnouncementComparerAnnouncementAnnouncement_hotfix;

		// Token: 0x040064BD RID: 25789
		private LuaFunction m_ActivityComparerOperationalActivityBaseOperationalActivityBase_hotfix;

		// Token: 0x040064BE RID: 25790
		private LuaFunction m_OnGainRewardButtonClickUInt64Int32ActivityRewardUIController_hotfix;

		// Token: 0x040064BF RID: 25791
		private LuaFunction m_OnExchangeItemGroupButtonClickUInt64Int32ActivityRewardUIController_hotfix;

		// Token: 0x040064C0 RID: 25792
		private LuaFunction m_OnExchangeItemGroupCrystalNotEnough_hotfix;

		// Token: 0x040064C1 RID: 25793
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x040064C2 RID: 25794
		private LuaFunction m_OnAddActivityButtonClick_hotfix;

		// Token: 0x040064C3 RID: 25795
		private LuaFunction m_OnGotoButtonClick_hotfix;

		// Token: 0x040064C4 RID: 25796
		private LuaFunction m_OnGetRewardButtonClick_hotfix;

		// Token: 0x040064C5 RID: 25797
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x040064C6 RID: 25798
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x040064C7 RID: 25799
		private LuaFunction m_add_EventOnGainRewardAction;

		// Token: 0x040064C8 RID: 25800
		private LuaFunction m_remove_EventOnGainRewardAction;

		// Token: 0x040064C9 RID: 25801
		private LuaFunction m_add_EventOnExchangeItemGroupAction;

		// Token: 0x040064CA RID: 25802
		private LuaFunction m_remove_EventOnExchangeItemGroupAction;

		// Token: 0x040064CB RID: 25803
		private LuaFunction m_add_EventOnAddActivityAction;

		// Token: 0x040064CC RID: 25804
		private LuaFunction m_remove_EventOnAddActivityAction;

		// Token: 0x040064CD RID: 25805
		private LuaFunction m_add_EventOnGoToButtonClickAction;

		// Token: 0x040064CE RID: 25806
		private LuaFunction m_remove_EventOnGoToButtonClickAction;

		// Token: 0x040064CF RID: 25807
		private LuaFunction m_add_EventOnGetRewardButtonClickAction;

		// Token: 0x040064D0 RID: 25808
		private LuaFunction m_remove_EventOnGetRewardButtonClickAction;

		// Token: 0x040064D1 RID: 25809
		private LuaFunction m_add_EventOnCrystalNotEnoughAction_hotfix;

		// Token: 0x040064D2 RID: 25810
		private LuaFunction m_remove_EventOnCrystalNotEnoughAction_hotfix;

		// Token: 0x02000999 RID: 2457
		public new class LuaExportHelper
		{
			// Token: 0x06008E08 RID: 36360 RVA: 0x00298318 File Offset: 0x00296518
			public LuaExportHelper(ActivityUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06008E09 RID: 36361 RVA: 0x00298328 File Offset: 0x00296528
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06008E0A RID: 36362 RVA: 0x00298338 File Offset: 0x00296538
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06008E0B RID: 36363 RVA: 0x00298348 File Offset: 0x00296548
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06008E0C RID: 36364 RVA: 0x00298358 File Offset: 0x00296558
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06008E0D RID: 36365 RVA: 0x00298370 File Offset: 0x00296570
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06008E0E RID: 36366 RVA: 0x00298380 File Offset: 0x00296580
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06008E0F RID: 36367 RVA: 0x00298390 File Offset: 0x00296590
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06008E10 RID: 36368 RVA: 0x002983A0 File Offset: 0x002965A0
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06008E11 RID: 36369 RVA: 0x002983B0 File Offset: 0x002965B0
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06008E12 RID: 36370 RVA: 0x002983C0 File Offset: 0x002965C0
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06008E13 RID: 36371 RVA: 0x002983D0 File Offset: 0x002965D0
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06008E14 RID: 36372 RVA: 0x002983E0 File Offset: 0x002965E0
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06008E15 RID: 36373 RVA: 0x002983F0 File Offset: 0x002965F0
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06008E16 RID: 36374 RVA: 0x00298400 File Offset: 0x00296600
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06008E17 RID: 36375 RVA: 0x00298410 File Offset: 0x00296610
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06008E18 RID: 36376 RVA: 0x00298420 File Offset: 0x00296620
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x06008E19 RID: 36377 RVA: 0x00298430 File Offset: 0x00296630
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x06008E1A RID: 36378 RVA: 0x00298440 File Offset: 0x00296640
			public void __callDele_EventOnGainReward(ulong arg1, int arg2, List<Goods> arg3)
			{
				this.m_owner.__callDele_EventOnGainReward(arg1, arg2, arg3);
			}

			// Token: 0x06008E1B RID: 36379 RVA: 0x00298450 File Offset: 0x00296650
			public void __clearDele_EventOnGainReward(ulong arg1, int arg2, List<Goods> arg3)
			{
				this.m_owner.__clearDele_EventOnGainReward(arg1, arg2, arg3);
			}

			// Token: 0x06008E1C RID: 36380 RVA: 0x00298460 File Offset: 0x00296660
			public void __callDele_EventOnExchangeItemGroup(ulong arg1, int arg2, List<Goods> arg3)
			{
				this.m_owner.__callDele_EventOnExchangeItemGroup(arg1, arg2, arg3);
			}

			// Token: 0x06008E1D RID: 36381 RVA: 0x00298470 File Offset: 0x00296670
			public void __clearDele_EventOnExchangeItemGroup(ulong arg1, int arg2, List<Goods> arg3)
			{
				this.m_owner.__clearDele_EventOnExchangeItemGroup(arg1, arg2, arg3);
			}

			// Token: 0x06008E1E RID: 36382 RVA: 0x00298480 File Offset: 0x00296680
			public void __callDele_EventOnAddActivity(string obj)
			{
				this.m_owner.__callDele_EventOnAddActivity(obj);
			}

			// Token: 0x06008E1F RID: 36383 RVA: 0x00298490 File Offset: 0x00296690
			public void __clearDele_EventOnAddActivity(string obj)
			{
				this.m_owner.__clearDele_EventOnAddActivity(obj);
			}

			// Token: 0x06008E20 RID: 36384 RVA: 0x002984A0 File Offset: 0x002966A0
			public void __callDele_EventOnGoToButtonClick(OperationalActivityBase obj)
			{
				this.m_owner.__callDele_EventOnGoToButtonClick(obj);
			}

			// Token: 0x06008E21 RID: 36385 RVA: 0x002984B0 File Offset: 0x002966B0
			public void __clearDele_EventOnGoToButtonClick(OperationalActivityBase obj)
			{
				this.m_owner.__clearDele_EventOnGoToButtonClick(obj);
			}

			// Token: 0x06008E22 RID: 36386 RVA: 0x002984C0 File Offset: 0x002966C0
			public void __callDele_EventOnGetRewardButtonClick(OperationalActivityBase obj)
			{
				this.m_owner.__callDele_EventOnGetRewardButtonClick(obj);
			}

			// Token: 0x06008E23 RID: 36387 RVA: 0x002984D0 File Offset: 0x002966D0
			public void __clearDele_EventOnGetRewardButtonClick(OperationalActivityBase obj)
			{
				this.m_owner.__clearDele_EventOnGetRewardButtonClick(obj);
			}

			// Token: 0x06008E24 RID: 36388 RVA: 0x002984E0 File Offset: 0x002966E0
			public void __callDele_EventOnCrystalNotEnough()
			{
				this.m_owner.__callDele_EventOnCrystalNotEnough();
			}

			// Token: 0x06008E25 RID: 36389 RVA: 0x002984F0 File Offset: 0x002966F0
			public void __clearDele_EventOnCrystalNotEnough()
			{
				this.m_owner.__clearDele_EventOnCrystalNotEnough();
			}

			// Token: 0x17001DAE RID: 7598
			// (get) Token: 0x06008E26 RID: 36390 RVA: 0x00298500 File Offset: 0x00296700
			// (set) Token: 0x06008E27 RID: 36391 RVA: 0x00298510 File Offset: 0x00296710
			public CommonUIStateController m_activityStateCtrl
			{
				get
				{
					return this.m_owner.m_activityStateCtrl;
				}
				set
				{
					this.m_owner.m_activityStateCtrl = value;
				}
			}

			// Token: 0x17001DAF RID: 7599
			// (get) Token: 0x06008E28 RID: 36392 RVA: 0x00298520 File Offset: 0x00296720
			// (set) Token: 0x06008E29 RID: 36393 RVA: 0x00298530 File Offset: 0x00296730
			public GameObject m_toggleItemPrefab
			{
				get
				{
					return this.m_owner.m_toggleItemPrefab;
				}
				set
				{
					this.m_owner.m_toggleItemPrefab = value;
				}
			}

			// Token: 0x17001DB0 RID: 7600
			// (get) Token: 0x06008E2A RID: 36394 RVA: 0x00298540 File Offset: 0x00296740
			// (set) Token: 0x06008E2B RID: 36395 RVA: 0x00298550 File Offset: 0x00296750
			public Text m_activityNameText
			{
				get
				{
					return this.m_owner.m_activityNameText;
				}
				set
				{
					this.m_owner.m_activityNameText = value;
				}
			}

			// Token: 0x17001DB1 RID: 7601
			// (get) Token: 0x06008E2C RID: 36396 RVA: 0x00298560 File Offset: 0x00296760
			// (set) Token: 0x06008E2D RID: 36397 RVA: 0x00298570 File Offset: 0x00296770
			public Text m_activityNameDarkText
			{
				get
				{
					return this.m_owner.m_activityNameDarkText;
				}
				set
				{
					this.m_owner.m_activityNameDarkText = value;
				}
			}

			// Token: 0x17001DB2 RID: 7602
			// (get) Token: 0x06008E2E RID: 36398 RVA: 0x00298580 File Offset: 0x00296780
			// (set) Token: 0x06008E2F RID: 36399 RVA: 0x00298590 File Offset: 0x00296790
			public Image m_tabIcon
			{
				get
				{
					return this.m_owner.m_tabIcon;
				}
				set
				{
					this.m_owner.m_tabIcon = value;
				}
			}

			// Token: 0x17001DB3 RID: 7603
			// (get) Token: 0x06008E30 RID: 36400 RVA: 0x002985A0 File Offset: 0x002967A0
			// (set) Token: 0x06008E31 RID: 36401 RVA: 0x002985B0 File Offset: 0x002967B0
			public GameObject m_tabNewLogo
			{
				get
				{
					return this.m_owner.m_tabNewLogo;
				}
				set
				{
					this.m_owner.m_tabNewLogo = value;
				}
			}

			// Token: 0x17001DB4 RID: 7604
			// (get) Token: 0x06008E32 RID: 36402 RVA: 0x002985C0 File Offset: 0x002967C0
			// (set) Token: 0x06008E33 RID: 36403 RVA: 0x002985D0 File Offset: 0x002967D0
			public GameObject m_tabRedPoint
			{
				get
				{
					return this.m_owner.m_tabRedPoint;
				}
				set
				{
					this.m_owner.m_tabRedPoint = value;
				}
			}

			// Token: 0x17001DB5 RID: 7605
			// (get) Token: 0x06008E34 RID: 36404 RVA: 0x002985E0 File Offset: 0x002967E0
			// (set) Token: 0x06008E35 RID: 36405 RVA: 0x002985F0 File Offset: 0x002967F0
			public GameObject m_leftSidebarScrollView
			{
				get
				{
					return this.m_owner.m_leftSidebarScrollView;
				}
				set
				{
					this.m_owner.m_leftSidebarScrollView = value;
				}
			}

			// Token: 0x17001DB6 RID: 7606
			// (get) Token: 0x06008E36 RID: 36406 RVA: 0x00298600 File Offset: 0x00296800
			// (set) Token: 0x06008E37 RID: 36407 RVA: 0x00298610 File Offset: 0x00296810
			public GameObject m_leftSidebarScrollViewContent
			{
				get
				{
					return this.m_owner.m_leftSidebarScrollViewContent;
				}
				set
				{
					this.m_owner.m_leftSidebarScrollViewContent = value;
				}
			}

			// Token: 0x17001DB7 RID: 7607
			// (get) Token: 0x06008E38 RID: 36408 RVA: 0x00298620 File Offset: 0x00296820
			// (set) Token: 0x06008E39 RID: 36409 RVA: 0x00298630 File Offset: 0x00296830
			public GameObject m_announcementPanelObj
			{
				get
				{
					return this.m_owner.m_announcementPanelObj;
				}
				set
				{
					this.m_owner.m_announcementPanelObj = value;
				}
			}

			// Token: 0x17001DB8 RID: 7608
			// (get) Token: 0x06008E3A RID: 36410 RVA: 0x00298640 File Offset: 0x00296840
			// (set) Token: 0x06008E3B RID: 36411 RVA: 0x00298650 File Offset: 0x00296850
			public Text m_announcementContentText
			{
				get
				{
					return this.m_owner.m_announcementContentText;
				}
				set
				{
					this.m_owner.m_announcementContentText = value;
				}
			}

			// Token: 0x17001DB9 RID: 7609
			// (get) Token: 0x06008E3C RID: 36412 RVA: 0x00298660 File Offset: 0x00296860
			// (set) Token: 0x06008E3D RID: 36413 RVA: 0x00298670 File Offset: 0x00296870
			public GameObject m_announcementScrollView
			{
				get
				{
					return this.m_owner.m_announcementScrollView;
				}
				set
				{
					this.m_owner.m_announcementScrollView = value;
				}
			}

			// Token: 0x17001DBA RID: 7610
			// (get) Token: 0x06008E3E RID: 36414 RVA: 0x00298680 File Offset: 0x00296880
			// (set) Token: 0x06008E3F RID: 36415 RVA: 0x00298690 File Offset: 0x00296890
			public GameObject m_activityPanelObj
			{
				get
				{
					return this.m_owner.m_activityPanelObj;
				}
				set
				{
					this.m_owner.m_activityPanelObj = value;
				}
			}

			// Token: 0x17001DBB RID: 7611
			// (get) Token: 0x06008E40 RID: 36416 RVA: 0x002986A0 File Offset: 0x002968A0
			// (set) Token: 0x06008E41 RID: 36417 RVA: 0x002986B0 File Offset: 0x002968B0
			public GameObject m_activityScrollView
			{
				get
				{
					return this.m_owner.m_activityScrollView;
				}
				set
				{
					this.m_owner.m_activityScrollView = value;
				}
			}

			// Token: 0x17001DBC RID: 7612
			// (get) Token: 0x06008E42 RID: 36418 RVA: 0x002986C0 File Offset: 0x002968C0
			// (set) Token: 0x06008E43 RID: 36419 RVA: 0x002986D0 File Offset: 0x002968D0
			public Text m_activityTimeText
			{
				get
				{
					return this.m_owner.m_activityTimeText;
				}
				set
				{
					this.m_owner.m_activityTimeText = value;
				}
			}

			// Token: 0x17001DBD RID: 7613
			// (get) Token: 0x06008E44 RID: 36420 RVA: 0x002986E0 File Offset: 0x002968E0
			// (set) Token: 0x06008E45 RID: 36421 RVA: 0x002986F0 File Offset: 0x002968F0
			public Text m_activityContentText
			{
				get
				{
					return this.m_owner.m_activityContentText;
				}
				set
				{
					this.m_owner.m_activityContentText = value;
				}
			}

			// Token: 0x17001DBE RID: 7614
			// (get) Token: 0x06008E46 RID: 36422 RVA: 0x00298700 File Offset: 0x00296900
			// (set) Token: 0x06008E47 RID: 36423 RVA: 0x00298710 File Offset: 0x00296910
			public CommonUIStateController m_activityPanelStateCtrl
			{
				get
				{
					return this.m_owner.m_activityPanelStateCtrl;
				}
				set
				{
					this.m_owner.m_activityPanelStateCtrl = value;
				}
			}

			// Token: 0x17001DBF RID: 7615
			// (get) Token: 0x06008E48 RID: 36424 RVA: 0x00298720 File Offset: 0x00296920
			// (set) Token: 0x06008E49 RID: 36425 RVA: 0x00298730 File Offset: 0x00296930
			public Image m_activityBillboardImage
			{
				get
				{
					return this.m_owner.m_activityBillboardImage;
				}
				set
				{
					this.m_owner.m_activityBillboardImage = value;
				}
			}

			// Token: 0x17001DC0 RID: 7616
			// (get) Token: 0x06008E4A RID: 36426 RVA: 0x00298740 File Offset: 0x00296940
			// (set) Token: 0x06008E4B RID: 36427 RVA: 0x00298750 File Offset: 0x00296950
			public GameObject m_activityRewardTitleObj
			{
				get
				{
					return this.m_owner.m_activityRewardTitleObj;
				}
				set
				{
					this.m_owner.m_activityRewardTitleObj = value;
				}
			}

			// Token: 0x17001DC1 RID: 7617
			// (get) Token: 0x06008E4C RID: 36428 RVA: 0x00298760 File Offset: 0x00296960
			// (set) Token: 0x06008E4D RID: 36429 RVA: 0x00298770 File Offset: 0x00296970
			public GameObject m_activityRewardList
			{
				get
				{
					return this.m_owner.m_activityRewardList;
				}
				set
				{
					this.m_owner.m_activityRewardList = value;
				}
			}

			// Token: 0x17001DC2 RID: 7618
			// (get) Token: 0x06008E4E RID: 36430 RVA: 0x00298780 File Offset: 0x00296980
			// (set) Token: 0x06008E4F RID: 36431 RVA: 0x00298790 File Offset: 0x00296990
			public GameObject m_activityRewardPrefab
			{
				get
				{
					return this.m_owner.m_activityRewardPrefab;
				}
				set
				{
					this.m_owner.m_activityRewardPrefab = value;
				}
			}

			// Token: 0x17001DC3 RID: 7619
			// (get) Token: 0x06008E50 RID: 36432 RVA: 0x002987A0 File Offset: 0x002969A0
			// (set) Token: 0x06008E51 RID: 36433 RVA: 0x002987B0 File Offset: 0x002969B0
			public Button m_goButton
			{
				get
				{
					return this.m_owner.m_goButton;
				}
				set
				{
					this.m_owner.m_goButton = value;
				}
			}

			// Token: 0x17001DC4 RID: 7620
			// (get) Token: 0x06008E52 RID: 36434 RVA: 0x002987C0 File Offset: 0x002969C0
			// (set) Token: 0x06008E53 RID: 36435 RVA: 0x002987D0 File Offset: 0x002969D0
			public Button m_getRewardButton
			{
				get
				{
					return this.m_owner.m_getRewardButton;
				}
				set
				{
					this.m_owner.m_getRewardButton = value;
				}
			}

			// Token: 0x17001DC5 RID: 7621
			// (get) Token: 0x06008E54 RID: 36436 RVA: 0x002987E0 File Offset: 0x002969E0
			// (set) Token: 0x06008E55 RID: 36437 RVA: 0x002987F0 File Offset: 0x002969F0
			public GameObject m_ReceivedRewardObj
			{
				get
				{
					return this.m_owner.m_ReceivedRewardObj;
				}
				set
				{
					this.m_owner.m_ReceivedRewardObj = value;
				}
			}

			// Token: 0x17001DC6 RID: 7622
			// (get) Token: 0x06008E56 RID: 36438 RVA: 0x00298800 File Offset: 0x00296A00
			// (set) Token: 0x06008E57 RID: 36439 RVA: 0x00298810 File Offset: 0x00296A10
			public Image m_BigImage
			{
				get
				{
					return this.m_owner.m_BigImage;
				}
				set
				{
					this.m_owner.m_BigImage = value;
				}
			}

			// Token: 0x17001DC7 RID: 7623
			// (get) Token: 0x06008E58 RID: 36440 RVA: 0x00298820 File Offset: 0x00296A20
			// (set) Token: 0x06008E59 RID: 36441 RVA: 0x00298830 File Offset: 0x00296A30
			public Button m_returnButton
			{
				get
				{
					return this.m_owner.m_returnButton;
				}
				set
				{
					this.m_owner.m_returnButton = value;
				}
			}

			// Token: 0x17001DC8 RID: 7624
			// (get) Token: 0x06008E5A RID: 36442 RVA: 0x00298840 File Offset: 0x00296A40
			// (set) Token: 0x06008E5B RID: 36443 RVA: 0x00298850 File Offset: 0x00296A50
			public GameObject m_activityGMObj
			{
				get
				{
					return this.m_owner.m_activityGMObj;
				}
				set
				{
					this.m_owner.m_activityGMObj = value;
				}
			}

			// Token: 0x17001DC9 RID: 7625
			// (get) Token: 0x06008E5C RID: 36444 RVA: 0x00298860 File Offset: 0x00296A60
			// (set) Token: 0x06008E5D RID: 36445 RVA: 0x00298870 File Offset: 0x00296A70
			public InputField m_activityInputField
			{
				get
				{
					return this.m_owner.m_activityInputField;
				}
				set
				{
					this.m_owner.m_activityInputField = value;
				}
			}

			// Token: 0x17001DCA RID: 7626
			// (get) Token: 0x06008E5E RID: 36446 RVA: 0x00298880 File Offset: 0x00296A80
			// (set) Token: 0x06008E5F RID: 36447 RVA: 0x00298890 File Offset: 0x00296A90
			public Button m_addActivityButton
			{
				get
				{
					return this.m_owner.m_addActivityButton;
				}
				set
				{
					this.m_owner.m_addActivityButton = value;
				}
			}

			// Token: 0x17001DCB RID: 7627
			// (get) Token: 0x06008E60 RID: 36448 RVA: 0x002988A0 File Offset: 0x00296AA0
			// (set) Token: 0x06008E61 RID: 36449 RVA: 0x002988B0 File Offset: 0x00296AB0
			public int announceCount
			{
				get
				{
					return this.m_owner.announceCount;
				}
				set
				{
					this.m_owner.announceCount = value;
				}
			}

			// Token: 0x17001DCC RID: 7628
			// (get) Token: 0x06008E62 RID: 36450 RVA: 0x002988C0 File Offset: 0x00296AC0
			// (set) Token: 0x06008E63 RID: 36451 RVA: 0x002988D0 File Offset: 0x00296AD0
			public OperationalActivityBase m_currentActivity
			{
				get
				{
					return this.m_owner.m_currentActivity;
				}
				set
				{
					this.m_owner.m_currentActivity = value;
				}
			}

			// Token: 0x17001DCD RID: 7629
			// (get) Token: 0x06008E64 RID: 36452 RVA: 0x002988E0 File Offset: 0x00296AE0
			// (set) Token: 0x06008E65 RID: 36453 RVA: 0x002988F0 File Offset: 0x00296AF0
			public List<GameObject> m_tabList
			{
				get
				{
					return this.m_owner.m_tabList;
				}
				set
				{
					this.m_owner.m_tabList = value;
				}
			}

			// Token: 0x17001DCE RID: 7630
			// (get) Token: 0x06008E66 RID: 36454 RVA: 0x00298900 File Offset: 0x00296B00
			// (set) Token: 0x06008E67 RID: 36455 RVA: 0x00298910 File Offset: 0x00296B10
			public List<ulong> m_instanceIDList
			{
				get
				{
					return this.m_owner.m_instanceIDList;
				}
				set
				{
					this.m_owner.m_instanceIDList = value;
				}
			}

			// Token: 0x17001DCF RID: 7631
			// (get) Token: 0x06008E68 RID: 36456 RVA: 0x00298920 File Offset: 0x00296B20
			// (set) Token: 0x06008E69 RID: 36457 RVA: 0x00298930 File Offset: 0x00296B30
			public List<ulong> m_readAnnounceActivityList
			{
				get
				{
					return this.m_owner.m_readAnnounceActivityList;
				}
				set
				{
					this.m_owner.m_readAnnounceActivityList = value;
				}
			}

			// Token: 0x17001DD0 RID: 7632
			// (get) Token: 0x06008E6A RID: 36458 RVA: 0x00298940 File Offset: 0x00296B40
			// (set) Token: 0x06008E6B RID: 36459 RVA: 0x00298950 File Offset: 0x00296B50
			public ProjectLPlayerContext m_playerContext
			{
				get
				{
					return this.m_owner.m_playerContext;
				}
				set
				{
					this.m_owner.m_playerContext = value;
				}
			}

			// Token: 0x17001DD1 RID: 7633
			// (get) Token: 0x06008E6C RID: 36460 RVA: 0x00298960 File Offset: 0x00296B60
			// (set) Token: 0x06008E6D RID: 36461 RVA: 0x00298970 File Offset: 0x00296B70
			public IConfigDataLoader m_configDataLoader
			{
				get
				{
					return this.m_owner.m_configDataLoader;
				}
				set
				{
					this.m_owner.m_configDataLoader = value;
				}
			}

			// Token: 0x06008E6E RID: 36462 RVA: 0x00298980 File Offset: 0x00296B80
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06008E6F RID: 36463 RVA: 0x00298990 File Offset: 0x00296B90
			public void SetTab()
			{
				this.m_owner.SetTab();
			}

			// Token: 0x06008E70 RID: 36464 RVA: 0x002989A0 File Offset: 0x00296BA0
			public bool IsActivityInOperationPeriod(OperationalActivityBase activity)
			{
				return this.m_owner.IsActivityInOperationPeriod(activity);
			}

			// Token: 0x06008E71 RID: 36465 RVA: 0x002989B0 File Offset: 0x00296BB0
			public void SetCurrentAnnouncement(Announcement currAnnouncement)
			{
				this.m_owner.SetCurrentAnnouncement(currAnnouncement);
			}

			// Token: 0x06008E72 RID: 36466 RVA: 0x002989C0 File Offset: 0x00296BC0
			public void SetTabRedPoint()
			{
				this.m_owner.SetTabRedPoint();
			}

			// Token: 0x06008E73 RID: 36467 RVA: 0x002989D0 File Offset: 0x00296BD0
			public void SetActivityRewardPanel(OperationalActivityBase activity)
			{
				this.m_owner.SetActivityRewardPanel(activity);
			}

			// Token: 0x06008E74 RID: 36468 RVA: 0x002989E0 File Offset: 0x00296BE0
			public void SetRewardListPanel(OperationalActivityBase activity)
			{
				this.m_owner.SetRewardListPanel(activity);
			}

			// Token: 0x06008E75 RID: 36469 RVA: 0x002989F0 File Offset: 0x00296BF0
			public void SetRaffleRewardPanel(OperationalActivityBase activity)
			{
				this.m_owner.SetRaffleRewardPanel(activity);
			}

			// Token: 0x06008E76 RID: 36470 RVA: 0x00298A00 File Offset: 0x00296C00
			public Dictionary<int, List<RaffleItem>> GainRaffleRewardLevelInfo(RafflePool rafflePool)
			{
				return this.m_owner.GainRaffleRewardLevelInfo(rafflePool);
			}

			// Token: 0x06008E77 RID: 36471 RVA: 0x00298A10 File Offset: 0x00296C10
			public string GetRedeemContent()
			{
				return this.m_owner.GetRedeemContent();
			}

			// Token: 0x06008E78 RID: 36472 RVA: 0x00298A20 File Offset: 0x00296C20
			public int AnnouncementComparer(Announcement announcementA, Announcement announcementB)
			{
				return this.m_owner.AnnouncementComparer(announcementA, announcementB);
			}

			// Token: 0x06008E79 RID: 36473 RVA: 0x00298A30 File Offset: 0x00296C30
			public int ActivityComparer(OperationalActivityBase activityA, OperationalActivityBase activityB)
			{
				return this.m_owner.ActivityComparer(activityA, activityB);
			}

			// Token: 0x06008E7A RID: 36474 RVA: 0x00298A40 File Offset: 0x00296C40
			public void OnGainRewardButtonClick(ulong activityInstanceID, int rewardIndex, ActivityRewardUIController ctrl)
			{
				this.m_owner.OnGainRewardButtonClick(activityInstanceID, rewardIndex, ctrl);
			}

			// Token: 0x06008E7B RID: 36475 RVA: 0x00298A50 File Offset: 0x00296C50
			public void OnExchangeItemGroupButtonClick(ulong activityInstanceID, int itemGroupIndex, ActivityRewardUIController ctrl)
			{
				this.m_owner.OnExchangeItemGroupButtonClick(activityInstanceID, itemGroupIndex, ctrl);
			}

			// Token: 0x06008E7C RID: 36476 RVA: 0x00298A60 File Offset: 0x00296C60
			public void OnExchangeItemGroupCrystalNotEnough()
			{
				this.m_owner.OnExchangeItemGroupCrystalNotEnough();
			}

			// Token: 0x06008E7D RID: 36477 RVA: 0x00298A70 File Offset: 0x00296C70
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x06008E7E RID: 36478 RVA: 0x00298A80 File Offset: 0x00296C80
			public void OnAddActivityButtonClick()
			{
				this.m_owner.OnAddActivityButtonClick();
			}

			// Token: 0x06008E7F RID: 36479 RVA: 0x00298A90 File Offset: 0x00296C90
			public void OnGotoButtonClick()
			{
				this.m_owner.OnGotoButtonClick();
			}

			// Token: 0x06008E80 RID: 36480 RVA: 0x00298AA0 File Offset: 0x00296CA0
			public void OnGetRewardButtonClick()
			{
				this.m_owner.OnGetRewardButtonClick();
			}

			// Token: 0x040064D3 RID: 25811
			private ActivityUIController m_owner;
		}
	}
}
