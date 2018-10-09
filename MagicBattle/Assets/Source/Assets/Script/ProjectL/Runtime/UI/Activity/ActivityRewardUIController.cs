using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Assets.Script.ProjectL.Runtime.UI.Activity
{
	// Token: 0x02000996 RID: 2454
	[HotFix]
	public class ActivityRewardUIController : UIControllerBase
	{
		// Token: 0x06008D42 RID: 36162 RVA: 0x002936D0 File Offset: 0x002918D0
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
			this.m_canReceiveButton.onClick.AddListener(new UnityAction(this.GainRewardButtonClick));
			this.m_canExchangeButton.onClick.AddListener(new UnityAction(this.ExchangeItemGroupButtonClick));
			base.gameObject.SetActive(true);
		}

		// Token: 0x06008D43 RID: 36163 RVA: 0x0029377C File Offset: 0x0029197C
		public void SetActivityRewardPanel(OperationalActivityBase activity, int index, GameObject rewardGoodsItemPrefab)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetActivityRewardPanelOperationalActivityBaseInt32GameObject_hotfix != null)
			{
				this.m_SetActivityRewardPanelOperationalActivityBaseInt32GameObject_hotfix.call(new object[]
				{
					this,
					activity,
					index,
					rewardGoodsItemPrefab
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ActivityParam activityParam = activity.Config.OperationalActivityParms[index];
			GameObjectUtility.DestroyChildren(this.m_activityRewardItemGroupObj);
			if (activity.ActivityType == OperationalActivityType.OperationalActivityType_LimitedTimeExchange)
			{
				List<Goods> list = new List<Goods>();
				List<Goods> itemList = this.m_configDataLoader.GetConfigDataOperationalActivityItemGroupInfo(activityParam.Parm1).ItemList;
				List<Goods> itemList2 = this.m_configDataLoader.GetConfigDataOperationalActivityItemGroupInfo(activityParam.Parm2).ItemList;
				list.AddRange(itemList);
				list.AddRange(itemList2);
				if (list != null && list.Count >= 2)
				{
					this.m_rewardList = itemList2;
					RewardGoodsUIController.CreateRewardGoodsList(list, this.m_activityRewardItemGroupObj.transform, rewardGoodsItemPrefab, null, true, 0, true);
					this.SetOperator(itemList, itemList2, activity, index);
				}
			}
			else
			{
				List<Goods> itemList3 = this.m_configDataLoader.GetConfigDataOperationalActivityItemGroupInfo(activityParam.Parm2).ItemList;
				this.m_rewardList = itemList3;
				this.m_allOperatorObj.SetActive(false);
				if (itemList3 != null)
				{
					this.m_rewardList = itemList3;
					RewardGoodsUIController.CreateRewardGoodsList(itemList3, this.m_activityRewardItemGroupObj.transform, rewardGoodsItemPrefab, null, true, 0, true);
				}
			}
			this.SetGoalState(activity, index);
		}

		// Token: 0x06008D44 RID: 36164 RVA: 0x00293910 File Offset: 0x00291B10
		private void SetGoalState(OperationalActivityBase activity, int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGoalStateOperationalActivityBaseInt32_hotfix != null)
			{
				this.m_SetGoalStateOperationalActivityBaseInt32_hotfix.call(new object[]
				{
					this,
					activity,
					index
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_activityInstanceID = activity.InstanceId;
			this.m_activity = activity;
			this.m_rewardIndex = index;
			switch (activity.ActivityType)
			{
			case OperationalActivityType.OperationalActivityType_PlayerLevelUp:
				this.SetLevelUpActivityGoal(activity, index);
				break;
			case OperationalActivityType.OperationalActivityType_LimitedTimeExchange:
				this.SetLimitedTimeExchangeActivityGoal(activity, index);
				break;
			case OperationalActivityType.OperationalActivityType_SpecificDaysLogin:
				this.SetSpecificDaysLoginActivityGoal(activity, index);
				break;
			case OperationalActivityType.OperationalActivityType_AccumulateDaysLogin:
				this.SetAccumulateDaysLoginGoal(activity, index);
				break;
			case OperationalActivityType.OperationalActivityType_AccumulateRecharge:
				this.SetAccumulateRechargeGoal(activity, index);
				break;
			case OperationalActivityType.OperationalActivityType_AccumulateConsumeCrystal:
				this.SetAccumulateConsumeCrystalGoal(activity, index);
				break;
			}
		}

		// Token: 0x06008D45 RID: 36165 RVA: 0x00293A34 File Offset: 0x00291C34
		private void SetLevelUpActivityGoal(OperationalActivityBase activity, int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLevelUpActivityGoalOperationalActivityBaseInt32_hotfix != null)
			{
				this.m_SetLevelUpActivityGoalOperationalActivityBaseInt32_hotfix.call(new object[]
				{
					this,
					activity,
					index
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ActivityParam activityParam = activity.Config.OperationalActivityParms[index];
			PlayerLevelUpOperationalActivity playerLevelUpOperationalActivity = activity as PlayerLevelUpOperationalActivity;
			this.m_achieveGoalText.text = string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Activity_LevelUpGoal), activityParam.Parm1);
			this.m_payGroupRMBIconObj.SetActive(false);
			if (playerLevelUpOperationalActivity.PlayerLevel < activityParam.Parm1)
			{
				this.m_achieveGoalObj.SetActive(true);
				this.m_goalProgressText.text = string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Activity_LevelUpProgress), playerLevelUpOperationalActivity.PlayerLevel, activityParam.Parm1);
				this.m_goalProgressText.gameObject.SetActive(true);
				this.m_exchangeButtonGroup.SetActive(false);
				this.m_receiveButtonGroup.SetActive(false);
				this.m_alreadyReceivedObj.gameObject.SetActive(false);
			}
			else
			{
				AwardOperationalActivityBase awardOperationalActivityBase = activity as AwardOperationalActivityBase;
				if (awardOperationalActivityBase.GainedRewardIndexs.Contains(index))
				{
					this.m_receiveButtonGroup.SetActive(false);
					this.m_exchangeButtonGroup.SetActive(false);
					this.m_goalProgressText.gameObject.SetActive(false);
					this.m_alreadyReceivedObj.gameObject.SetActive(true);
					this.m_achieveGoalObj.gameObject.SetActive(false);
				}
				else
				{
					this.m_receiveButtonGroup.SetActive(true);
					this.m_canReceiveButton.gameObject.SetActive(true);
					this.m_canNotReceiveButton.gameObject.SetActive(false);
					this.m_exchangeButtonGroup.SetActive(false);
					this.m_goalProgressText.gameObject.SetActive(false);
					this.m_alreadyReceivedObj.gameObject.SetActive(false);
					this.m_achieveGoalObj.SetActive(true);
				}
			}
		}

		// Token: 0x06008D46 RID: 36166 RVA: 0x00293C68 File Offset: 0x00291E68
		private void SetAccumulateDaysLoginGoal(OperationalActivityBase activity, int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetAccumulateDaysLoginGoalOperationalActivityBaseInt32_hotfix != null)
			{
				this.m_SetAccumulateDaysLoginGoalOperationalActivityBaseInt32_hotfix.call(new object[]
				{
					this,
					activity,
					index
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ActivityParam activityParam = activity.Config.OperationalActivityParms[index];
			AccumulateLoginOperationalActivity accumulateLoginOperationalActivity = activity as AccumulateLoginOperationalActivity;
			this.m_achieveGoalText.text = string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Activity_AccumulateDaysGoal), activityParam.Parm1);
			this.m_payGroupRMBIconObj.SetActive(false);
			if (accumulateLoginOperationalActivity.SpecificLoginTimes.Count < activityParam.Parm1)
			{
				this.m_achieveGoalObj.SetActive(true);
				this.m_goalProgressText.text = string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Activity_AccumulateDaysProgress), accumulateLoginOperationalActivity.SpecificLoginTimes.Count, activityParam.Parm1);
				this.m_goalProgressText.gameObject.SetActive(true);
				this.m_exchangeButtonGroup.SetActive(false);
				this.m_receiveButtonGroup.SetActive(false);
				this.m_alreadyReceivedObj.gameObject.SetActive(false);
			}
			else
			{
				AwardOperationalActivityBase awardOperationalActivityBase = activity as AwardOperationalActivityBase;
				if (awardOperationalActivityBase.GainedRewardIndexs.Contains(index))
				{
					this.m_receiveButtonGroup.SetActive(false);
					this.m_exchangeButtonGroup.SetActive(false);
					this.m_goalProgressText.gameObject.SetActive(false);
					this.m_alreadyReceivedObj.gameObject.SetActive(true);
					this.m_achieveGoalObj.SetActive(false);
				}
				else
				{
					this.m_receiveButtonGroup.SetActive(true);
					this.m_canReceiveButton.gameObject.SetActive(true);
					this.m_canNotReceiveButton.gameObject.SetActive(false);
					this.m_exchangeButtonGroup.SetActive(false);
					this.m_goalProgressText.gameObject.SetActive(false);
					this.m_alreadyReceivedObj.gameObject.SetActive(false);
					this.m_achieveGoalObj.SetActive(true);
				}
			}
		}

		// Token: 0x06008D47 RID: 36167 RVA: 0x00293EA0 File Offset: 0x002920A0
		private void SetSpecificDaysLoginActivityGoal(OperationalActivityBase activity, int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSpecificDaysLoginActivityGoalOperationalActivityBaseInt32_hotfix != null)
			{
				this.m_SetSpecificDaysLoginActivityGoalOperationalActivityBaseInt32_hotfix.call(new object[]
				{
					this,
					activity,
					index
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ActivityParam activityParam = activity.Config.OperationalActivityParms[index];
			DateTime dateTime = activity.OperationStartTime.AddDays((double)(activityParam.Parm1 - 1));
			this.m_achieveGoalText.text = string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Activity_SpecificDaysGoal), dateTime.Month, dateTime.Day);
			this.m_payGroupRMBIconObj.SetActive(false);
			AwardOperationalActivityBase awardOperationalActivityBase = activity as AwardOperationalActivityBase;
			if (awardOperationalActivityBase.GainedRewardIndexs.Contains(index))
			{
				this.m_receiveButtonGroup.SetActive(false);
				this.m_exchangeButtonGroup.SetActive(false);
				this.m_goalProgressText.gameObject.SetActive(false);
				this.m_alreadyReceivedObj.gameObject.SetActive(true);
				this.m_achieveGoalObj.SetActive(false);
			}
			else
			{
				this.m_receiveButtonGroup.SetActive(true);
				this.m_exchangeButtonGroup.SetActive(false);
				this.m_goalProgressText.gameObject.SetActive(false);
				this.m_alreadyReceivedObj.gameObject.SetActive(false);
				this.m_achieveGoalObj.SetActive(true);
				this.m_canReceiveButton.gameObject.SetActive(this.m_playerContext.CanActivityGainReward(activity, index));
				this.m_canNotReceiveButton.gameObject.SetActive(!this.m_playerContext.CanActivityGainReward(activity, index));
			}
		}

		// Token: 0x06008D48 RID: 36168 RVA: 0x00294074 File Offset: 0x00292274
		private void SetLimitedTimeExchangeActivityGoal(OperationalActivityBase activity, int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLimitedTimeExchangeActivityGoalOperationalActivityBaseInt32_hotfix != null)
			{
				this.m_SetLimitedTimeExchangeActivityGoalOperationalActivityBaseInt32_hotfix.call(new object[]
				{
					this,
					activity,
					index
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ActivityParam activityParam = activity.Config.OperationalActivityParms[index];
			LimitedTimeExchangeOperationActivity limitedTimeExchangeOperationActivity = activity as LimitedTimeExchangeOperationActivity;
			int num = 0;
			limitedTimeExchangeOperationActivity.ExchangedItemGroups.TryGetValue(index, out num);
			this.m_payGroupRMBIconObj.SetActive(false);
			int num2 = activityParam.Parm3 - num;
			if (num2 > 0)
			{
				this.m_achieveGoalText.text = string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Activity_HaveExchangeTimes), num2);
				this.m_achieveGoalObj.SetActive(true);
				this.m_receiveButtonGroup.gameObject.SetActive(false);
				this.m_exchangeButtonGroup.SetActive(true);
				this.m_canExchangeButton.gameObject.SetActive(true);
				this.m_canNotExchangeButton.gameObject.SetActive(false);
				this.m_alreadyReceivedObj.gameObject.SetActive(false);
				this.m_goalProgressText.gameObject.SetActive(false);
			}
			else
			{
				this.m_achieveGoalText.text = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Activity_HaveNoExchangeTimes);
				this.m_achieveGoalObj.SetActive(true);
				this.m_receiveButtonGroup.gameObject.SetActive(false);
				this.m_exchangeButtonGroup.SetActive(true);
				this.m_canExchangeButton.gameObject.SetActive(false);
				this.m_canNotExchangeButton.gameObject.SetActive(true);
				this.m_alreadyReceivedObj.gameObject.SetActive(false);
				this.m_goalProgressText.gameObject.SetActive(false);
			}
		}

		// Token: 0x06008D49 RID: 36169 RVA: 0x0029425C File Offset: 0x0029245C
		private void SetAccumulateRechargeGoal(OperationalActivityBase activity, int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetAccumulateRechargeGoalOperationalActivityBaseInt32_hotfix != null)
			{
				this.m_SetAccumulateRechargeGoalOperationalActivityBaseInt32_hotfix.call(new object[]
				{
					this,
					activity,
					index
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ActivityParam activityParam = activity.Config.OperationalActivityParms[index];
			AccumulateRechargeOperationalActivity accumulateRechargeOperationalActivity = activity as AccumulateRechargeOperationalActivity;
			this.m_payGroupRMBIconObj.SetActive(true);
			this.m_payGroupCrystalIconObj.SetActive(false);
			this.m_payGroupTitleText.text = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Activity_AccumulateRechargeGoal);
			this.m_payGroupNumberText.text = activityParam.Parm1.ToString();
			int num = (int)MoneyCaculate.FenToYuan(accumulateRechargeOperationalActivity.AccumulateRechargeRMB);
			if (num < activityParam.Parm1)
			{
				this.m_achieveGoalObj.SetActive(false);
				this.m_payGroupObj.SetActive(true);
				this.m_goalProgressText.text = string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Activity_AccumulateRechargeProgress), num, activityParam.Parm1);
				this.m_goalProgressText.gameObject.SetActive(true);
				this.m_exchangeButtonGroup.SetActive(false);
				this.m_receiveButtonGroup.SetActive(false);
				this.m_alreadyReceivedObj.gameObject.SetActive(false);
			}
			else if (accumulateRechargeOperationalActivity.GainedRewardIndexs.Contains(index))
			{
				this.m_receiveButtonGroup.SetActive(false);
				this.m_exchangeButtonGroup.SetActive(false);
				this.m_goalProgressText.gameObject.SetActive(false);
				this.m_alreadyReceivedObj.gameObject.SetActive(true);
				this.m_achieveGoalObj.SetActive(false);
				this.m_payGroupObj.SetActive(false);
			}
			else
			{
				this.m_receiveButtonGroup.SetActive(true);
				this.m_canReceiveButton.gameObject.SetActive(true);
				this.m_canNotReceiveButton.gameObject.SetActive(false);
				this.m_exchangeButtonGroup.SetActive(false);
				this.m_goalProgressText.gameObject.SetActive(false);
				this.m_alreadyReceivedObj.gameObject.SetActive(false);
				this.m_achieveGoalObj.SetActive(false);
				this.m_payGroupObj.SetActive(true);
			}
		}

		// Token: 0x06008D4A RID: 36170 RVA: 0x002944C4 File Offset: 0x002926C4
		private void SetAccumulateConsumeCrystalGoal(OperationalActivityBase activity, int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetAccumulateConsumeCrystalGoalOperationalActivityBaseInt32_hotfix != null)
			{
				this.m_SetAccumulateConsumeCrystalGoalOperationalActivityBaseInt32_hotfix.call(new object[]
				{
					this,
					activity,
					index
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ActivityParam activityParam = activity.Config.OperationalActivityParms[index];
			AccumulateConsumeCrystalOperationalActivity accumulateConsumeCrystalOperationalActivity = activity as AccumulateConsumeCrystalOperationalActivity;
			this.m_payGroupRMBIconObj.SetActive(false);
			this.m_payGroupCrystalIconObj.SetActive(true);
			this.m_payGroupTitleText.text = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Activity_AccumulateConsumeCrystalGoal);
			this.m_payGroupNumberText.text = activityParam.Parm1.ToString();
			if (accumulateConsumeCrystalOperationalActivity.AccumulateConsumeCrystal < activityParam.Parm1)
			{
				this.m_achieveGoalObj.SetActive(false);
				this.m_payGroupObj.SetActive(true);
				this.m_goalProgressText.text = string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Activity_AccumulateConsumeCrystalProgress), accumulateConsumeCrystalOperationalActivity.AccumulateConsumeCrystal, activityParam.Parm1);
				this.m_goalProgressText.gameObject.SetActive(true);
				this.m_exchangeButtonGroup.SetActive(false);
				this.m_receiveButtonGroup.SetActive(false);
				this.m_alreadyReceivedObj.gameObject.SetActive(false);
			}
			else if (accumulateConsumeCrystalOperationalActivity.GainedRewardIndexs.Contains(index))
			{
				this.m_receiveButtonGroup.SetActive(false);
				this.m_exchangeButtonGroup.SetActive(false);
				this.m_goalProgressText.gameObject.SetActive(false);
				this.m_alreadyReceivedObj.gameObject.SetActive(true);
				this.m_achieveGoalObj.SetActive(false);
				this.m_payGroupObj.SetActive(false);
			}
			else
			{
				this.m_receiveButtonGroup.SetActive(true);
				this.m_canReceiveButton.gameObject.SetActive(true);
				this.m_canNotReceiveButton.gameObject.SetActive(false);
				this.m_exchangeButtonGroup.SetActive(false);
				this.m_goalProgressText.gameObject.SetActive(false);
				this.m_alreadyReceivedObj.gameObject.SetActive(false);
				this.m_achieveGoalObj.SetActive(false);
				this.m_payGroupObj.SetActive(true);
			}
		}

		// Token: 0x06008D4B RID: 36171 RVA: 0x0029472C File Offset: 0x0029292C
		private void SetOperator(List<Goods> exchangeGoodList, List<Goods> gainGoodList, OperationalActivityBase activity, int rewardIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetOperatorList`1List`1OperationalActivityBaseInt32_hotfix != null)
			{
				this.m_SetOperatorList`1List`1OperationalActivityBaseInt32_hotfix.call(new object[]
				{
					this,
					exchangeGoodList,
					gainGoodList,
					activity,
					rewardIndex
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int count = exchangeGoodList.Count;
			int count2 = gainGoodList.Count;
			int num = count + count2;
			this.m_allOperatorObj.SetActive(true);
			if (num == 2)
			{
				this.m_operatorImage1.sprite = AssetUtility.Instance.GetSprite("UI/Common_New_ABS/Icon/Icon_Equal_01.png");
				this.m_operatorImage1.gameObject.SetActive(true);
				this.m_operatorImage2.gameObject.SetActive(false);
				this.m_operatorImage3.gameObject.SetActive(false);
			}
			else if (num == 3)
			{
				this.m_operatorImage1.gameObject.SetActive(true);
				this.m_operatorImage2.gameObject.SetActive(false);
				this.m_operatorImage3.gameObject.SetActive(false);
				if (count == 1)
				{
					this.m_operatorImage1.sprite = AssetUtility.Instance.GetSprite("UI/Common_New_ABS/Icon/Icon_Equal_01.png");
					this.m_operatorImage2.sprite = AssetUtility.Instance.GetSprite("UI/Common_New_ABS/Icon/Icon_Plus_01.png");
				}
				else
				{
					this.m_operatorImage1.sprite = AssetUtility.Instance.GetSprite("UI/Common_New_ABS/Icon/Icon_Plus_01.png");
					this.m_operatorImage2.sprite = AssetUtility.Instance.GetSprite("UI/Common_New_ABS/Icon/Icon_Equal_01.png");
				}
			}
			else if (num == 4)
			{
				this.m_operatorImage1.gameObject.SetActive(true);
				this.m_operatorImage2.gameObject.SetActive(true);
				this.m_operatorImage3.gameObject.SetActive(true);
				if (count == 1)
				{
					this.m_operatorImage1.sprite = AssetUtility.Instance.GetSprite("UI/Common_New_ABS/Icon/Icon_Equal_01.png");
					this.m_operatorImage2.sprite = AssetUtility.Instance.GetSprite("UI/Common_New_ABS/Icon/Icon_Plus_01.png");
					this.m_operatorImage3.sprite = AssetUtility.Instance.GetSprite("UI/Common_New_ABS/Icon/Icon_Plus_01.png");
				}
				else if (count == 2)
				{
					this.m_operatorImage1.sprite = AssetUtility.Instance.GetSprite("UI/Common_New_ABS/Icon/Icon_Plus_01.png");
					this.m_operatorImage2.sprite = AssetUtility.Instance.GetSprite("UI/Common_New_ABS/Icon/Icon_Equal_01.png");
					this.m_operatorImage3.sprite = AssetUtility.Instance.GetSprite("UI/Common_New_ABS/Icon/Icon_Plus_01.png");
				}
				else if (count == 3)
				{
					this.m_operatorImage1.sprite = AssetUtility.Instance.GetSprite("UI/Common_New_ABS/Icon/Icon_Plus_01.png");
					this.m_operatorImage2.sprite = AssetUtility.Instance.GetSprite("UI/Common_New_ABS/Icon/Icon_Plus_01.png");
					this.m_operatorImage3.sprite = AssetUtility.Instance.GetSprite("UI/Common_New_ABS/Icon/Icon_Equal_01.png");
				}
			}
		}

		// Token: 0x06008D4C RID: 36172 RVA: 0x00294A3C File Offset: 0x00292C3C
		private void GainRewardButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GainRewardButtonClick_hotfix != null)
			{
				this.m_GainRewardButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnGainRewardButtonClick != null)
			{
				this.EventOnGainRewardButtonClick(this.m_activityInstanceID, this.m_rewardIndex, this);
			}
		}

		// Token: 0x06008D4D RID: 36173 RVA: 0x00294AC0 File Offset: 0x00292CC0
		private void ExchangeItemGroupButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExchangeItemGroupButtonClick_hotfix != null)
			{
				this.m_ExchangeItemGroupButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_playerContext.CanExchangeGoodsResult(this.m_activity, this.m_rewardIndex);
			if (num == 0)
			{
				if (this.EventOnExchangeItemGroupButtonClick != null)
				{
					this.EventOnExchangeItemGroupButtonClick(this.m_activityInstanceID, this.m_rewardIndex, this);
				}
			}
			else if (num == -401)
			{
				if (this.EventOnCrystalNotEnough != null)
				{
					this.EventOnCrystalNotEnough();
				}
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x14000181 RID: 385
		// (add) Token: 0x06008D4E RID: 36174 RVA: 0x00294BA0 File Offset: 0x00292DA0
		// (remove) Token: 0x06008D4F RID: 36175 RVA: 0x00294C3C File Offset: 0x00292E3C
		public event Action<ulong, int, ActivityRewardUIController> EventOnGainRewardButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGainRewardButtonClickAction`3_hotfix != null)
				{
					this.m_add_EventOnGainRewardButtonClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ulong, int, ActivityRewardUIController> action = this.EventOnGainRewardButtonClick;
				Action<ulong, int, ActivityRewardUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ulong, int, ActivityRewardUIController>>(ref this.EventOnGainRewardButtonClick, (Action<ulong, int, ActivityRewardUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGainRewardButtonClickAction`3_hotfix != null)
				{
					this.m_remove_EventOnGainRewardButtonClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ulong, int, ActivityRewardUIController> action = this.EventOnGainRewardButtonClick;
				Action<ulong, int, ActivityRewardUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ulong, int, ActivityRewardUIController>>(ref this.EventOnGainRewardButtonClick, (Action<ulong, int, ActivityRewardUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000182 RID: 386
		// (add) Token: 0x06008D50 RID: 36176 RVA: 0x00294CD8 File Offset: 0x00292ED8
		// (remove) Token: 0x06008D51 RID: 36177 RVA: 0x00294D74 File Offset: 0x00292F74
		public event Action<ulong, int, ActivityRewardUIController> EventOnExchangeItemGroupButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnExchangeItemGroupButtonClickAction`3_hotfix != null)
				{
					this.m_add_EventOnExchangeItemGroupButtonClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ulong, int, ActivityRewardUIController> action = this.EventOnExchangeItemGroupButtonClick;
				Action<ulong, int, ActivityRewardUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ulong, int, ActivityRewardUIController>>(ref this.EventOnExchangeItemGroupButtonClick, (Action<ulong, int, ActivityRewardUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnExchangeItemGroupButtonClickAction`3_hotfix != null)
				{
					this.m_remove_EventOnExchangeItemGroupButtonClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ulong, int, ActivityRewardUIController> action = this.EventOnExchangeItemGroupButtonClick;
				Action<ulong, int, ActivityRewardUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ulong, int, ActivityRewardUIController>>(ref this.EventOnExchangeItemGroupButtonClick, (Action<ulong, int, ActivityRewardUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000183 RID: 387
		// (add) Token: 0x06008D52 RID: 36178 RVA: 0x00294E10 File Offset: 0x00293010
		// (remove) Token: 0x06008D53 RID: 36179 RVA: 0x00294EAC File Offset: 0x002930AC
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

		// Token: 0x17001D93 RID: 7571
		// (get) Token: 0x06008D54 RID: 36180 RVA: 0x00294F48 File Offset: 0x00293148
		// (set) Token: 0x06008D55 RID: 36181 RVA: 0x00294F68 File Offset: 0x00293168
		[DoNotToLua]
		public new ActivityRewardUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ActivityRewardUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06008D56 RID: 36182 RVA: 0x00294F74 File Offset: 0x00293174
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06008D57 RID: 36183 RVA: 0x00294F80 File Offset: 0x00293180
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06008D58 RID: 36184 RVA: 0x00294F88 File Offset: 0x00293188
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06008D59 RID: 36185 RVA: 0x00294F90 File Offset: 0x00293190
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06008D5A RID: 36186 RVA: 0x00294FA4 File Offset: 0x002931A4
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06008D5B RID: 36187 RVA: 0x00294FAC File Offset: 0x002931AC
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06008D5C RID: 36188 RVA: 0x00294FB8 File Offset: 0x002931B8
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06008D5D RID: 36189 RVA: 0x00294FC4 File Offset: 0x002931C4
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06008D5E RID: 36190 RVA: 0x00294FD0 File Offset: 0x002931D0
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06008D5F RID: 36191 RVA: 0x00294FDC File Offset: 0x002931DC
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06008D60 RID: 36192 RVA: 0x00294FE8 File Offset: 0x002931E8
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06008D61 RID: 36193 RVA: 0x00294FF4 File Offset: 0x002931F4
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06008D62 RID: 36194 RVA: 0x00295000 File Offset: 0x00293200
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06008D63 RID: 36195 RVA: 0x0029500C File Offset: 0x0029320C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06008D64 RID: 36196 RVA: 0x00295018 File Offset: 0x00293218
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06008D65 RID: 36197 RVA: 0x00295020 File Offset: 0x00293220
		private void __callDele_EventOnGainRewardButtonClick(ulong arg1, int arg2, ActivityRewardUIController arg3)
		{
			Action<ulong, int, ActivityRewardUIController> eventOnGainRewardButtonClick = this.EventOnGainRewardButtonClick;
			if (eventOnGainRewardButtonClick != null)
			{
				eventOnGainRewardButtonClick(arg1, arg2, arg3);
			}
		}

		// Token: 0x06008D66 RID: 36198 RVA: 0x00295044 File Offset: 0x00293244
		private void __clearDele_EventOnGainRewardButtonClick(ulong arg1, int arg2, ActivityRewardUIController arg3)
		{
			this.EventOnGainRewardButtonClick = null;
		}

		// Token: 0x06008D67 RID: 36199 RVA: 0x00295050 File Offset: 0x00293250
		private void __callDele_EventOnExchangeItemGroupButtonClick(ulong arg1, int arg2, ActivityRewardUIController arg3)
		{
			Action<ulong, int, ActivityRewardUIController> eventOnExchangeItemGroupButtonClick = this.EventOnExchangeItemGroupButtonClick;
			if (eventOnExchangeItemGroupButtonClick != null)
			{
				eventOnExchangeItemGroupButtonClick(arg1, arg2, arg3);
			}
		}

		// Token: 0x06008D68 RID: 36200 RVA: 0x00295074 File Offset: 0x00293274
		private void __clearDele_EventOnExchangeItemGroupButtonClick(ulong arg1, int arg2, ActivityRewardUIController arg3)
		{
			this.EventOnExchangeItemGroupButtonClick = null;
		}

		// Token: 0x06008D69 RID: 36201 RVA: 0x00295080 File Offset: 0x00293280
		private void __callDele_EventOnCrystalNotEnough()
		{
			Action eventOnCrystalNotEnough = this.EventOnCrystalNotEnough;
			if (eventOnCrystalNotEnough != null)
			{
				eventOnCrystalNotEnough();
			}
		}

		// Token: 0x06008D6A RID: 36202 RVA: 0x002950A0 File Offset: 0x002932A0
		private void __clearDele_EventOnCrystalNotEnough()
		{
			this.EventOnCrystalNotEnough = null;
		}

		// Token: 0x06008D6B RID: 36203 RVA: 0x002950AC File Offset: 0x002932AC
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
					this.m_SetActivityRewardPanelOperationalActivityBaseInt32GameObject_hotfix = (luaObj.RawGet("SetActivityRewardPanel") as LuaFunction);
					this.m_SetGoalStateOperationalActivityBaseInt32_hotfix = (luaObj.RawGet("SetGoalState") as LuaFunction);
					this.m_SetLevelUpActivityGoalOperationalActivityBaseInt32_hotfix = (luaObj.RawGet("SetLevelUpActivityGoal") as LuaFunction);
					this.m_SetAccumulateDaysLoginGoalOperationalActivityBaseInt32_hotfix = (luaObj.RawGet("SetAccumulateDaysLoginGoal") as LuaFunction);
					this.m_SetSpecificDaysLoginActivityGoalOperationalActivityBaseInt32_hotfix = (luaObj.RawGet("SetSpecificDaysLoginActivityGoal") as LuaFunction);
					this.m_SetLimitedTimeExchangeActivityGoalOperationalActivityBaseInt32_hotfix = (luaObj.RawGet("SetLimitedTimeExchangeActivityGoal") as LuaFunction);
					this.m_SetAccumulateRechargeGoalOperationalActivityBaseInt32_hotfix = (luaObj.RawGet("SetAccumulateRechargeGoal") as LuaFunction);
					this.m_SetAccumulateConsumeCrystalGoalOperationalActivityBaseInt32_hotfix = (luaObj.RawGet("SetAccumulateConsumeCrystalGoal") as LuaFunction);
					this.m_SetOperatorList`1List`1OperationalActivityBaseInt32_hotfix = (luaObj.RawGet("SetOperator") as LuaFunction);
					this.m_GainRewardButtonClick_hotfix = (luaObj.RawGet("GainRewardButtonClick") as LuaFunction);
					this.m_ExchangeItemGroupButtonClick_hotfix = (luaObj.RawGet("ExchangeItemGroupButtonClick") as LuaFunction);
					this.m_add_EventOnGainRewardButtonClickAction`3_hotfix = (luaObj.RawGet("add_EventOnGainRewardButtonClick") as LuaFunction);
					this.m_remove_EventOnGainRewardButtonClickAction`3_hotfix = (luaObj.RawGet("remove_EventOnGainRewardButtonClick") as LuaFunction);
					this.m_add_EventOnExchangeItemGroupButtonClickAction`3_hotfix = (luaObj.RawGet("add_EventOnExchangeItemGroupButtonClick") as LuaFunction);
					this.m_remove_EventOnExchangeItemGroupButtonClickAction`3_hotfix = (luaObj.RawGet("remove_EventOnExchangeItemGroupButtonClick") as LuaFunction);
					this.m_add_EventOnCrystalNotEnoughAction_hotfix = (luaObj.RawGet("add_EventOnCrystalNotEnough") as LuaFunction);
					this.m_remove_EventOnCrystalNotEnoughAction_hotfix = (luaObj.RawGet("remove_EventOnCrystalNotEnough") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06008D6C RID: 36204 RVA: 0x00295320 File Offset: 0x00293520
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ActivityRewardUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400644E RID: 25678
		private ulong m_activityInstanceID;

		// Token: 0x0400644F RID: 25679
		private OperationalActivityBase m_activity;

		// Token: 0x04006450 RID: 25680
		private int m_rewardIndex;

		// Token: 0x04006451 RID: 25681
		public List<Goods> m_rewardList;

		// Token: 0x04006452 RID: 25682
		[AutoBind("./RewardItemGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_activityRewardItemGroupObj;

		// Token: 0x04006453 RID: 25683
		[AutoBind("./ReceiveButtonGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_receiveButtonGroup;

		// Token: 0x04006454 RID: 25684
		[AutoBind("./ReceiveButtonGroup/CanReceiveButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_canReceiveButton;

		// Token: 0x04006455 RID: 25685
		[AutoBind("./ReceiveButtonGroup/CanNotReceiveButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_canNotReceiveButton;

		// Token: 0x04006456 RID: 25686
		[AutoBind("./ExchangeButtonGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_exchangeButtonGroup;

		// Token: 0x04006457 RID: 25687
		[AutoBind("./ExchangeButtonGroup/CanExchangeButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_canExchangeButton;

		// Token: 0x04006458 RID: 25688
		[AutoBind("./ExchangeButtonGroup/CanNotExchangeButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_canNotExchangeButton;

		// Token: 0x04006459 RID: 25689
		[AutoBind("./AlreadyReceived", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_alreadyReceivedObj;

		// Token: 0x0400645A RID: 25690
		[AutoBind("./AchieveGoal", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_achieveGoalObj;

		// Token: 0x0400645B RID: 25691
		[AutoBind("./AchieveGoal/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_achieveGoalText;

		// Token: 0x0400645C RID: 25692
		[AutoBind("./GoalProgressText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_goalProgressText;

		// Token: 0x0400645D RID: 25693
		[AutoBind("./AllOperator", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_allOperatorObj;

		// Token: 0x0400645E RID: 25694
		[AutoBind("./AllOperator/Operator1/OperatorImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_operatorImage1;

		// Token: 0x0400645F RID: 25695
		[AutoBind("./AllOperator/Operator2/OperatorImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_operatorImage2;

		// Token: 0x04006460 RID: 25696
		[AutoBind("./AllOperator/Operator3/OperatorImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_operatorImage3;

		// Token: 0x04006461 RID: 25697
		[AutoBind("./PayGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_payGroupObj;

		// Token: 0x04006462 RID: 25698
		[AutoBind("./PayGroup/IconRMB_Bg", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_payGroupRMBIconObj;

		// Token: 0x04006463 RID: 25699
		[AutoBind("./PayGroup/IconCrystal_Bg", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_payGroupCrystalIconObj;

		// Token: 0x04006464 RID: 25700
		[AutoBind("./PayGroup/TitleText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_payGroupTitleText;

		// Token: 0x04006465 RID: 25701
		[AutoBind("./PayGroup/NumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_payGroupNumberText;

		// Token: 0x04006466 RID: 25702
		private IConfigDataLoader m_configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;

		// Token: 0x04006467 RID: 25703
		private ProjectLPlayerContext m_playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x04006468 RID: 25704
		[DoNotToLua]
		private ActivityRewardUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04006469 RID: 25705
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400646A RID: 25706
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400646B RID: 25707
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400646C RID: 25708
		private LuaFunction m_SetActivityRewardPanelOperationalActivityBaseInt32GameObject_hotfix;

		// Token: 0x0400646D RID: 25709
		private LuaFunction m_SetGoalStateOperationalActivityBaseInt32_hotfix;

		// Token: 0x0400646E RID: 25710
		private LuaFunction m_SetLevelUpActivityGoalOperationalActivityBaseInt32_hotfix;

		// Token: 0x0400646F RID: 25711
		private LuaFunction m_SetAccumulateDaysLoginGoalOperationalActivityBaseInt32_hotfix;

		// Token: 0x04006470 RID: 25712
		private LuaFunction m_SetSpecificDaysLoginActivityGoalOperationalActivityBaseInt32_hotfix;

		// Token: 0x04006471 RID: 25713
		private LuaFunction m_SetLimitedTimeExchangeActivityGoalOperationalActivityBaseInt32_hotfix;

		// Token: 0x04006472 RID: 25714
		private LuaFunction m_SetAccumulateRechargeGoalOperationalActivityBaseInt32_hotfix;

		// Token: 0x04006473 RID: 25715
		private LuaFunction m_SetAccumulateConsumeCrystalGoalOperationalActivityBaseInt32_hotfix;

		// Token: 0x04006474 RID: 25716
		private LuaFunction m_SetOperatorList`1List;

		// Token: 0x04006475 RID: 25717
		private LuaFunction m_GainRewardButtonClick_hotfix;

		// Token: 0x04006476 RID: 25718
		private LuaFunction m_ExchangeItemGroupButtonClick_hotfix;

		// Token: 0x04006477 RID: 25719
		private LuaFunction m_add_EventOnGainRewardButtonClickAction;

		// Token: 0x04006478 RID: 25720
		private LuaFunction m_remove_EventOnGainRewardButtonClickAction;

		// Token: 0x04006479 RID: 25721
		private LuaFunction m_add_EventOnExchangeItemGroupButtonClickAction;

		// Token: 0x0400647A RID: 25722
		private LuaFunction m_remove_EventOnExchangeItemGroupButtonClickAction;

		// Token: 0x0400647B RID: 25723
		private LuaFunction m_add_EventOnCrystalNotEnoughAction_hotfix;

		// Token: 0x0400647C RID: 25724
		private LuaFunction m_remove_EventOnCrystalNotEnoughAction_hotfix;

		// Token: 0x02000997 RID: 2455
		public new class LuaExportHelper
		{
			// Token: 0x06008D6D RID: 36205 RVA: 0x00295388 File Offset: 0x00293588
			public LuaExportHelper(ActivityRewardUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06008D6E RID: 36206 RVA: 0x00295398 File Offset: 0x00293598
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06008D6F RID: 36207 RVA: 0x002953A8 File Offset: 0x002935A8
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06008D70 RID: 36208 RVA: 0x002953B8 File Offset: 0x002935B8
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06008D71 RID: 36209 RVA: 0x002953C8 File Offset: 0x002935C8
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06008D72 RID: 36210 RVA: 0x002953E0 File Offset: 0x002935E0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06008D73 RID: 36211 RVA: 0x002953F0 File Offset: 0x002935F0
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06008D74 RID: 36212 RVA: 0x00295400 File Offset: 0x00293600
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06008D75 RID: 36213 RVA: 0x00295410 File Offset: 0x00293610
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06008D76 RID: 36214 RVA: 0x00295420 File Offset: 0x00293620
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06008D77 RID: 36215 RVA: 0x00295430 File Offset: 0x00293630
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06008D78 RID: 36216 RVA: 0x00295440 File Offset: 0x00293640
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06008D79 RID: 36217 RVA: 0x00295450 File Offset: 0x00293650
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06008D7A RID: 36218 RVA: 0x00295460 File Offset: 0x00293660
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06008D7B RID: 36219 RVA: 0x00295470 File Offset: 0x00293670
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06008D7C RID: 36220 RVA: 0x00295480 File Offset: 0x00293680
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06008D7D RID: 36221 RVA: 0x00295490 File Offset: 0x00293690
			public void __callDele_EventOnGainRewardButtonClick(ulong arg1, int arg2, ActivityRewardUIController arg3)
			{
				this.m_owner.__callDele_EventOnGainRewardButtonClick(arg1, arg2, arg3);
			}

			// Token: 0x06008D7E RID: 36222 RVA: 0x002954A0 File Offset: 0x002936A0
			public void __clearDele_EventOnGainRewardButtonClick(ulong arg1, int arg2, ActivityRewardUIController arg3)
			{
				this.m_owner.__clearDele_EventOnGainRewardButtonClick(arg1, arg2, arg3);
			}

			// Token: 0x06008D7F RID: 36223 RVA: 0x002954B0 File Offset: 0x002936B0
			public void __callDele_EventOnExchangeItemGroupButtonClick(ulong arg1, int arg2, ActivityRewardUIController arg3)
			{
				this.m_owner.__callDele_EventOnExchangeItemGroupButtonClick(arg1, arg2, arg3);
			}

			// Token: 0x06008D80 RID: 36224 RVA: 0x002954C0 File Offset: 0x002936C0
			public void __clearDele_EventOnExchangeItemGroupButtonClick(ulong arg1, int arg2, ActivityRewardUIController arg3)
			{
				this.m_owner.__clearDele_EventOnExchangeItemGroupButtonClick(arg1, arg2, arg3);
			}

			// Token: 0x06008D81 RID: 36225 RVA: 0x002954D0 File Offset: 0x002936D0
			public void __callDele_EventOnCrystalNotEnough()
			{
				this.m_owner.__callDele_EventOnCrystalNotEnough();
			}

			// Token: 0x06008D82 RID: 36226 RVA: 0x002954E0 File Offset: 0x002936E0
			public void __clearDele_EventOnCrystalNotEnough()
			{
				this.m_owner.__clearDele_EventOnCrystalNotEnough();
			}

			// Token: 0x17001D94 RID: 7572
			// (get) Token: 0x06008D83 RID: 36227 RVA: 0x002954F0 File Offset: 0x002936F0
			// (set) Token: 0x06008D84 RID: 36228 RVA: 0x00295500 File Offset: 0x00293700
			public ulong m_activityInstanceID
			{
				get
				{
					return this.m_owner.m_activityInstanceID;
				}
				set
				{
					this.m_owner.m_activityInstanceID = value;
				}
			}

			// Token: 0x17001D95 RID: 7573
			// (get) Token: 0x06008D85 RID: 36229 RVA: 0x00295510 File Offset: 0x00293710
			// (set) Token: 0x06008D86 RID: 36230 RVA: 0x00295520 File Offset: 0x00293720
			public OperationalActivityBase m_activity
			{
				get
				{
					return this.m_owner.m_activity;
				}
				set
				{
					this.m_owner.m_activity = value;
				}
			}

			// Token: 0x17001D96 RID: 7574
			// (get) Token: 0x06008D87 RID: 36231 RVA: 0x00295530 File Offset: 0x00293730
			// (set) Token: 0x06008D88 RID: 36232 RVA: 0x00295540 File Offset: 0x00293740
			public int m_rewardIndex
			{
				get
				{
					return this.m_owner.m_rewardIndex;
				}
				set
				{
					this.m_owner.m_rewardIndex = value;
				}
			}

			// Token: 0x17001D97 RID: 7575
			// (get) Token: 0x06008D89 RID: 36233 RVA: 0x00295550 File Offset: 0x00293750
			// (set) Token: 0x06008D8A RID: 36234 RVA: 0x00295560 File Offset: 0x00293760
			public GameObject m_activityRewardItemGroupObj
			{
				get
				{
					return this.m_owner.m_activityRewardItemGroupObj;
				}
				set
				{
					this.m_owner.m_activityRewardItemGroupObj = value;
				}
			}

			// Token: 0x17001D98 RID: 7576
			// (get) Token: 0x06008D8B RID: 36235 RVA: 0x00295570 File Offset: 0x00293770
			// (set) Token: 0x06008D8C RID: 36236 RVA: 0x00295580 File Offset: 0x00293780
			public GameObject m_receiveButtonGroup
			{
				get
				{
					return this.m_owner.m_receiveButtonGroup;
				}
				set
				{
					this.m_owner.m_receiveButtonGroup = value;
				}
			}

			// Token: 0x17001D99 RID: 7577
			// (get) Token: 0x06008D8D RID: 36237 RVA: 0x00295590 File Offset: 0x00293790
			// (set) Token: 0x06008D8E RID: 36238 RVA: 0x002955A0 File Offset: 0x002937A0
			public Button m_canReceiveButton
			{
				get
				{
					return this.m_owner.m_canReceiveButton;
				}
				set
				{
					this.m_owner.m_canReceiveButton = value;
				}
			}

			// Token: 0x17001D9A RID: 7578
			// (get) Token: 0x06008D8F RID: 36239 RVA: 0x002955B0 File Offset: 0x002937B0
			// (set) Token: 0x06008D90 RID: 36240 RVA: 0x002955C0 File Offset: 0x002937C0
			public Button m_canNotReceiveButton
			{
				get
				{
					return this.m_owner.m_canNotReceiveButton;
				}
				set
				{
					this.m_owner.m_canNotReceiveButton = value;
				}
			}

			// Token: 0x17001D9B RID: 7579
			// (get) Token: 0x06008D91 RID: 36241 RVA: 0x002955D0 File Offset: 0x002937D0
			// (set) Token: 0x06008D92 RID: 36242 RVA: 0x002955E0 File Offset: 0x002937E0
			public GameObject m_exchangeButtonGroup
			{
				get
				{
					return this.m_owner.m_exchangeButtonGroup;
				}
				set
				{
					this.m_owner.m_exchangeButtonGroup = value;
				}
			}

			// Token: 0x17001D9C RID: 7580
			// (get) Token: 0x06008D93 RID: 36243 RVA: 0x002955F0 File Offset: 0x002937F0
			// (set) Token: 0x06008D94 RID: 36244 RVA: 0x00295600 File Offset: 0x00293800
			public Button m_canExchangeButton
			{
				get
				{
					return this.m_owner.m_canExchangeButton;
				}
				set
				{
					this.m_owner.m_canExchangeButton = value;
				}
			}

			// Token: 0x17001D9D RID: 7581
			// (get) Token: 0x06008D95 RID: 36245 RVA: 0x00295610 File Offset: 0x00293810
			// (set) Token: 0x06008D96 RID: 36246 RVA: 0x00295620 File Offset: 0x00293820
			public Button m_canNotExchangeButton
			{
				get
				{
					return this.m_owner.m_canNotExchangeButton;
				}
				set
				{
					this.m_owner.m_canNotExchangeButton = value;
				}
			}

			// Token: 0x17001D9E RID: 7582
			// (get) Token: 0x06008D97 RID: 36247 RVA: 0x00295630 File Offset: 0x00293830
			// (set) Token: 0x06008D98 RID: 36248 RVA: 0x00295640 File Offset: 0x00293840
			public GameObject m_alreadyReceivedObj
			{
				get
				{
					return this.m_owner.m_alreadyReceivedObj;
				}
				set
				{
					this.m_owner.m_alreadyReceivedObj = value;
				}
			}

			// Token: 0x17001D9F RID: 7583
			// (get) Token: 0x06008D99 RID: 36249 RVA: 0x00295650 File Offset: 0x00293850
			// (set) Token: 0x06008D9A RID: 36250 RVA: 0x00295660 File Offset: 0x00293860
			public GameObject m_achieveGoalObj
			{
				get
				{
					return this.m_owner.m_achieveGoalObj;
				}
				set
				{
					this.m_owner.m_achieveGoalObj = value;
				}
			}

			// Token: 0x17001DA0 RID: 7584
			// (get) Token: 0x06008D9B RID: 36251 RVA: 0x00295670 File Offset: 0x00293870
			// (set) Token: 0x06008D9C RID: 36252 RVA: 0x00295680 File Offset: 0x00293880
			public Text m_achieveGoalText
			{
				get
				{
					return this.m_owner.m_achieveGoalText;
				}
				set
				{
					this.m_owner.m_achieveGoalText = value;
				}
			}

			// Token: 0x17001DA1 RID: 7585
			// (get) Token: 0x06008D9D RID: 36253 RVA: 0x00295690 File Offset: 0x00293890
			// (set) Token: 0x06008D9E RID: 36254 RVA: 0x002956A0 File Offset: 0x002938A0
			public Text m_goalProgressText
			{
				get
				{
					return this.m_owner.m_goalProgressText;
				}
				set
				{
					this.m_owner.m_goalProgressText = value;
				}
			}

			// Token: 0x17001DA2 RID: 7586
			// (get) Token: 0x06008D9F RID: 36255 RVA: 0x002956B0 File Offset: 0x002938B0
			// (set) Token: 0x06008DA0 RID: 36256 RVA: 0x002956C0 File Offset: 0x002938C0
			public GameObject m_allOperatorObj
			{
				get
				{
					return this.m_owner.m_allOperatorObj;
				}
				set
				{
					this.m_owner.m_allOperatorObj = value;
				}
			}

			// Token: 0x17001DA3 RID: 7587
			// (get) Token: 0x06008DA1 RID: 36257 RVA: 0x002956D0 File Offset: 0x002938D0
			// (set) Token: 0x06008DA2 RID: 36258 RVA: 0x002956E0 File Offset: 0x002938E0
			public Image m_operatorImage1
			{
				get
				{
					return this.m_owner.m_operatorImage1;
				}
				set
				{
					this.m_owner.m_operatorImage1 = value;
				}
			}

			// Token: 0x17001DA4 RID: 7588
			// (get) Token: 0x06008DA3 RID: 36259 RVA: 0x002956F0 File Offset: 0x002938F0
			// (set) Token: 0x06008DA4 RID: 36260 RVA: 0x00295700 File Offset: 0x00293900
			public Image m_operatorImage2
			{
				get
				{
					return this.m_owner.m_operatorImage2;
				}
				set
				{
					this.m_owner.m_operatorImage2 = value;
				}
			}

			// Token: 0x17001DA5 RID: 7589
			// (get) Token: 0x06008DA5 RID: 36261 RVA: 0x00295710 File Offset: 0x00293910
			// (set) Token: 0x06008DA6 RID: 36262 RVA: 0x00295720 File Offset: 0x00293920
			public Image m_operatorImage3
			{
				get
				{
					return this.m_owner.m_operatorImage3;
				}
				set
				{
					this.m_owner.m_operatorImage3 = value;
				}
			}

			// Token: 0x17001DA6 RID: 7590
			// (get) Token: 0x06008DA7 RID: 36263 RVA: 0x00295730 File Offset: 0x00293930
			// (set) Token: 0x06008DA8 RID: 36264 RVA: 0x00295740 File Offset: 0x00293940
			public GameObject m_payGroupObj
			{
				get
				{
					return this.m_owner.m_payGroupObj;
				}
				set
				{
					this.m_owner.m_payGroupObj = value;
				}
			}

			// Token: 0x17001DA7 RID: 7591
			// (get) Token: 0x06008DA9 RID: 36265 RVA: 0x00295750 File Offset: 0x00293950
			// (set) Token: 0x06008DAA RID: 36266 RVA: 0x00295760 File Offset: 0x00293960
			public GameObject m_payGroupRMBIconObj
			{
				get
				{
					return this.m_owner.m_payGroupRMBIconObj;
				}
				set
				{
					this.m_owner.m_payGroupRMBIconObj = value;
				}
			}

			// Token: 0x17001DA8 RID: 7592
			// (get) Token: 0x06008DAB RID: 36267 RVA: 0x00295770 File Offset: 0x00293970
			// (set) Token: 0x06008DAC RID: 36268 RVA: 0x00295780 File Offset: 0x00293980
			public GameObject m_payGroupCrystalIconObj
			{
				get
				{
					return this.m_owner.m_payGroupCrystalIconObj;
				}
				set
				{
					this.m_owner.m_payGroupCrystalIconObj = value;
				}
			}

			// Token: 0x17001DA9 RID: 7593
			// (get) Token: 0x06008DAD RID: 36269 RVA: 0x00295790 File Offset: 0x00293990
			// (set) Token: 0x06008DAE RID: 36270 RVA: 0x002957A0 File Offset: 0x002939A0
			public Text m_payGroupTitleText
			{
				get
				{
					return this.m_owner.m_payGroupTitleText;
				}
				set
				{
					this.m_owner.m_payGroupTitleText = value;
				}
			}

			// Token: 0x17001DAA RID: 7594
			// (get) Token: 0x06008DAF RID: 36271 RVA: 0x002957B0 File Offset: 0x002939B0
			// (set) Token: 0x06008DB0 RID: 36272 RVA: 0x002957C0 File Offset: 0x002939C0
			public Text m_payGroupNumberText
			{
				get
				{
					return this.m_owner.m_payGroupNumberText;
				}
				set
				{
					this.m_owner.m_payGroupNumberText = value;
				}
			}

			// Token: 0x17001DAB RID: 7595
			// (get) Token: 0x06008DB1 RID: 36273 RVA: 0x002957D0 File Offset: 0x002939D0
			// (set) Token: 0x06008DB2 RID: 36274 RVA: 0x002957E0 File Offset: 0x002939E0
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

			// Token: 0x17001DAC RID: 7596
			// (get) Token: 0x06008DB3 RID: 36275 RVA: 0x002957F0 File Offset: 0x002939F0
			// (set) Token: 0x06008DB4 RID: 36276 RVA: 0x00295800 File Offset: 0x00293A00
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

			// Token: 0x06008DB5 RID: 36277 RVA: 0x00295810 File Offset: 0x00293A10
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06008DB6 RID: 36278 RVA: 0x00295820 File Offset: 0x00293A20
			public void SetGoalState(OperationalActivityBase activity, int index)
			{
				this.m_owner.SetGoalState(activity, index);
			}

			// Token: 0x06008DB7 RID: 36279 RVA: 0x00295830 File Offset: 0x00293A30
			public void SetLevelUpActivityGoal(OperationalActivityBase activity, int index)
			{
				this.m_owner.SetLevelUpActivityGoal(activity, index);
			}

			// Token: 0x06008DB8 RID: 36280 RVA: 0x00295840 File Offset: 0x00293A40
			public void SetAccumulateDaysLoginGoal(OperationalActivityBase activity, int index)
			{
				this.m_owner.SetAccumulateDaysLoginGoal(activity, index);
			}

			// Token: 0x06008DB9 RID: 36281 RVA: 0x00295850 File Offset: 0x00293A50
			public void SetSpecificDaysLoginActivityGoal(OperationalActivityBase activity, int index)
			{
				this.m_owner.SetSpecificDaysLoginActivityGoal(activity, index);
			}

			// Token: 0x06008DBA RID: 36282 RVA: 0x00295860 File Offset: 0x00293A60
			public void SetLimitedTimeExchangeActivityGoal(OperationalActivityBase activity, int index)
			{
				this.m_owner.SetLimitedTimeExchangeActivityGoal(activity, index);
			}

			// Token: 0x06008DBB RID: 36283 RVA: 0x00295870 File Offset: 0x00293A70
			public void SetAccumulateRechargeGoal(OperationalActivityBase activity, int index)
			{
				this.m_owner.SetAccumulateRechargeGoal(activity, index);
			}

			// Token: 0x06008DBC RID: 36284 RVA: 0x00295880 File Offset: 0x00293A80
			public void SetAccumulateConsumeCrystalGoal(OperationalActivityBase activity, int index)
			{
				this.m_owner.SetAccumulateConsumeCrystalGoal(activity, index);
			}

			// Token: 0x06008DBD RID: 36285 RVA: 0x00295890 File Offset: 0x00293A90
			public void SetOperator(List<Goods> exchangeGoodList, List<Goods> gainGoodList, OperationalActivityBase activity, int rewardIndex)
			{
				this.m_owner.SetOperator(exchangeGoodList, gainGoodList, activity, rewardIndex);
			}

			// Token: 0x06008DBE RID: 36286 RVA: 0x002958A4 File Offset: 0x00293AA4
			public void GainRewardButtonClick()
			{
				this.m_owner.GainRewardButtonClick();
			}

			// Token: 0x06008DBF RID: 36287 RVA: 0x002958B4 File Offset: 0x00293AB4
			public void ExchangeItemGroupButtonClick()
			{
				this.m_owner.ExchangeItemGroupButtonClick();
			}

			// Token: 0x0400647D RID: 25725
			private ActivityRewardUIController m_owner;
		}
	}
}
