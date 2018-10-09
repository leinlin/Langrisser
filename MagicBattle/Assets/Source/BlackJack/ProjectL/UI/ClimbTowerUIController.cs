using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B91 RID: 2961
	[HotFix]
	public class ClimbTowerUIController : UIControllerBase
	{
		// Token: 0x0600C9FF RID: 51711 RVA: 0x0037BF04 File Offset: 0x0037A104
		private ClimbTowerUIController()
		{
		}

		// Token: 0x0600CA00 RID: 51712 RVA: 0x0037BF18 File Offset: 0x0037A118
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
			this.m_helpButton.onClick.AddListener(new UnityAction(this.OnHelpButtonClick));
			this.m_startButton.onClick.AddListener(new UnityAction(this.OnStartButtonClick));
			this.m_raidButton.onClick.AddListener(new UnityAction(this.OnRaidButtonClick));
			this.m_showRewardButton.onClick.AddListener(new UnityAction(this.OnShowRewardButtonClick));
			this.m_climbTowerFloorItemUIControllers[0] = GameObjectUtility.AddControllerToGameObject<ClimbTowerFloorItemUIController>(this.m_floor0FloorGameObject);
			this.m_climbTowerFloorItemUIControllers[1] = GameObjectUtility.AddControllerToGameObject<ClimbTowerFloorItemUIController>(this.m_floor1FloorGameObject);
			this.m_climbTowerFloorItemUIControllers[2] = GameObjectUtility.AddControllerToGameObject<ClimbTowerFloorItemUIController>(this.m_floor2FloorGameObject);
			this.m_climbTowerFloorItemUIControllers[3] = GameObjectUtility.AddControllerToGameObject<ClimbTowerFloorItemUIController>(this.m_floor3FloorGameObject);
			this.m_climbTowerFloorItemUIControllers[4] = GameObjectUtility.AddControllerToGameObject<ClimbTowerFloorItemUIController>(this.m_floor4FloorGameObject);
			foreach (ClimbTowerFloorItemUIController climbTowerFloorItemUIController in this.m_climbTowerFloorItemUIControllers)
			{
				ClimbTowerFloorItemUIController climbTowerFloorItemUIController2 = climbTowerFloorItemUIController;
				climbTowerFloorItemUIController2.EventOnButtonClick = (Action<ClimbTowerFloorItemUIController>)Delegate.Combine(climbTowerFloorItemUIController2.EventOnButtonClick, new Action<ClimbTowerFloorItemUIController>(this.ClimbTowerFloorItemUIController_OnButtonClick));
			}
			this.m_rewardPreviewUIStateController.gameObject.SetActive(false);
			this.m_rewardPreviewBackgroundButton.onClick.AddListener(new UnityAction(this.OnRewardPreviewCloseButtonClick));
			this.m_raidPanelUIStateController.gameObject.SetActive(false);
			this.m_raidPanelConfirmButton.onClick.AddListener(new UnityAction(this.OnRaidPanelConfirmButtonClick));
			this.m_raidPanelCancelButton.onClick.AddListener(new UnityAction(this.OnRaidPanelCancelButtonClick));
			this.m_blackCoverUIStateController.gameObject.SetActive(false);
			this.m_prefabsGameObject.SetActive(false);
		}

		// Token: 0x0600CA01 RID: 51713 RVA: 0x0037C140 File Offset: 0x0037A340
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
			UIUtility.SetUIStateOpen(this.m_uiStateController, "Show", null, false, true);
		}

		// Token: 0x0600CA02 RID: 51714 RVA: 0x0037C1B4 File Offset: 0x0037A3B4
		public void SetNextFlushTime(TimeSpan ts)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetNextFlushTimeTimeSpan_hotfix != null)
			{
				this.m_SetNextFlushTimeTimeSpan_hotfix.call(new object[]
				{
					this,
					ts
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_flushTimeText.text = UIUtility.TimeSpanToString(ts);
		}

		// Token: 0x0600CA03 RID: 51715 RVA: 0x0037C238 File Offset: 0x0037A438
		public void SetClearAllFloors(bool clear)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetClearAllFloorsBoolean_hotfix != null)
			{
				this.m_SetClearAllFloorsBoolean_hotfix.call(new object[]
				{
					this,
					clear
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_clearUIStateController.SetToUIState((!clear) ? "Normal" : "Clear", false, true);
		}

		// Token: 0x0600CA04 RID: 51716 RVA: 0x0037C2CC File Offset: 0x0037A4CC
		public void ShowClearEffectBegin(bool isRaid, Action onEnd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowClearEffectBeginBooleanAction_hotfix != null)
			{
				this.m_ShowClearEffectBeginBooleanAction_hotfix.call(new object[]
				{
					this,
					isRaid,
					onEnd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartCoroutine(this.Co_ShowClearEffectBegin(isRaid, onEnd));
		}

		// Token: 0x0600CA05 RID: 51717 RVA: 0x0037C35C File Offset: 0x0037A55C
		[DebuggerHidden]
		private IEnumerator Co_ShowClearEffectBegin(bool isRaid, Action onEnd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_ShowClearEffectBeginBooleanAction_hotfix != null)
			{
				return (IEnumerator)this.m_Co_ShowClearEffectBeginBooleanAction_hotfix.call(new object[]
				{
					this,
					isRaid,
					onEnd
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClimbTowerUIController.<Co_ShowClearEffectBegin>c__Iterator0 <Co_ShowClearEffectBegin>c__Iterator = new ClimbTowerUIController.<Co_ShowClearEffectBegin>c__Iterator0();
			<Co_ShowClearEffectBegin>c__Iterator.isRaid = isRaid;
			<Co_ShowClearEffectBegin>c__Iterator.onEnd = onEnd;
			<Co_ShowClearEffectBegin>c__Iterator.$this = this;
			return <Co_ShowClearEffectBegin>c__Iterator;
		}

		// Token: 0x0600CA06 RID: 51718 RVA: 0x0037C404 File Offset: 0x0037A604
		public void ShowClearEffectEnd()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowClearEffectEnd_hotfix != null)
			{
				this.m_ShowClearEffectEnd_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_blackCoverUIStateController, "Show", null, false, true);
		}

		// Token: 0x0600CA07 RID: 51719 RVA: 0x0037C478 File Offset: 0x0037A678
		public void SetProgress(float p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetProgressSingle_hotfix != null)
			{
				this.m_SetProgressSingle_hotfix.call(new object[]
				{
					this,
					p
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_progressSlider.value = p;
		}

		// Token: 0x0600CA08 RID: 51720 RVA: 0x0037C4F4 File Offset: 0x0037A6F4
		public void SetCurrentTowerFloor(ConfigDataTowerFloorInfo floorInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCurrentTowerFloorConfigDataTowerFloorInfo_hotfix != null)
			{
				this.m_SetCurrentTowerFloorConfigDataTowerFloorInfo_hotfix.call(new object[]
				{
					this,
					floorInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_progressInfoText.text = floorInfo.Name;
			this.m_bigFloorNameText.text = floorInfo.BigFloorName;
		}

		// Token: 0x0600CA09 RID: 51721 RVA: 0x0037C588 File Offset: 0x0037A788
		public void SetTowerFloor(int idx, ConfigDataTowerFloorInfo floorInfo, ConfigDataTowerLevelInfo levelInfo, bool isCleared, bool isLocked)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTowerFloorInt32ConfigDataTowerFloorInfoConfigDataTowerLevelInfoBooleanBoolean_hotfix != null)
			{
				this.m_SetTowerFloorInt32ConfigDataTowerFloorInfoConfigDataTowerLevelInfoBooleanBoolean_hotfix.call(new object[]
				{
					this,
					idx,
					floorInfo,
					levelInfo,
					isCleared,
					isLocked
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClimbTowerFloorItemUIController climbTowerFloorItemUIController = this.m_climbTowerFloorItemUIControllers[idx];
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("RewardGoods");
			climbTowerFloorItemUIController.SetTowerFloor(floorInfo, levelInfo, assetInContainer);
			climbTowerFloorItemUIController.SetState(isCleared, isLocked, null);
		}

		// Token: 0x0600CA0A RID: 51722 RVA: 0x0037C664 File Offset: 0x0037A864
		public void ShowRaidButton(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowRaidButtonBoolean_hotfix != null)
			{
				this.m_ShowRaidButtonBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_raidButton.gameObject.SetActive(show);
		}

		// Token: 0x0600CA0B RID: 51723 RVA: 0x0037C6E8 File Offset: 0x0037A8E8
		public void SetRaidTowerFloor(ConfigDataTowerFloorInfo historyMaxFloorInfo, ConfigDataTowerFloorInfo raidMaxFloorInfo, bool canRaid)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRaidTowerFloorConfigDataTowerFloorInfoConfigDataTowerFloorInfoBoolean_hotfix != null)
			{
				this.m_SetRaidTowerFloorConfigDataTowerFloorInfoConfigDataTowerFloorInfoBoolean_hotfix.call(new object[]
				{
					this,
					historyMaxFloorInfo,
					raidMaxFloorInfo,
					canRaid
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (historyMaxFloorInfo != null)
			{
				this.m_historyMaxFloorText.text = historyMaxFloorInfo.Name;
				this.m_historyMaxFloorText.gameObject.SetActive(true);
			}
			else
			{
				this.m_historyMaxFloorText.gameObject.SetActive(false);
			}
			if (raidMaxFloorInfo != null)
			{
				this.m_raidMaxFloorText.text = raidMaxFloorInfo.Name;
				this.m_raidMaxFloorText.gameObject.SetActive(true);
			}
			else
			{
				this.m_raidMaxFloorText.gameObject.SetActive(false);
			}
			this.m_raidButtonUIStateController.SetToUIState((!canRaid) ? "Grey" : "Normal", false, true);
		}

		// Token: 0x0600CA0C RID: 51724 RVA: 0x0037C818 File Offset: 0x0037AA18
		public void ShowRewardPreview()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowRewardPreview_hotfix != null)
			{
				this.m_ShowRewardPreview_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			string format = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_ClimbTower_RewardPreviewDesc);
			int num = 0;
			foreach (KeyValuePair<int, ConfigDataTowerFloorInfo> keyValuePair in configDataLoader.GetAllConfigDataTowerFloorInfo())
			{
				if (keyValuePair.Key % 5 == 0)
				{
					ClimbTowerRewardListItemUIController climbTowerRewardListItemUIController;
					if (num < this.m_rewardPreviewScollRect.content.childCount)
					{
						climbTowerRewardListItemUIController = this.m_rewardPreviewScollRect.content.GetChild(num).GetComponent<ClimbTowerRewardListItemUIController>();
					}
					else
					{
						GameObject go = UnityEngine.Object.Instantiate<GameObject>(this.m_rewardItemPrefab, this.m_rewardPreviewScollRect.content, false);
						climbTowerRewardListItemUIController = GameObjectUtility.AddControllerToGameObject<ClimbTowerRewardListItemUIController>(go);
					}
					ConfigDataTowerFloorInfo value = keyValuePair.Value;
					climbTowerRewardListItemUIController.SetReward(value.RewardList, string.Format(format, value.BigFloorName));
					num++;
				}
			}
			UIUtility.SetGameObjectChildrenActiveCount(this.m_rewardPreviewScollRect.content.gameObject, num);
			UIUtility.SetUIStateOpen(this.m_rewardPreviewUIStateController, "PanelOpen", null, false, true);
		}

		// Token: 0x0600CA0D RID: 51725 RVA: 0x0037C99C File Offset: 0x0037AB9C
		private void HideRewardPreview()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideRewardPreview_hotfix != null)
			{
				this.m_HideRewardPreview_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_rewardPreviewUIStateController, "PanelClose", null, false, true);
		}

		// Token: 0x0600CA0E RID: 51726 RVA: 0x0037CA10 File Offset: 0x0037AC10
		public void ShowRaidPanel(int curEnrgy, int costEnergy, ConfigDataTowerFloorInfo reachFloorInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowRaidPanelInt32Int32ConfigDataTowerFloorInfo_hotfix != null)
			{
				this.m_ShowRaidPanelInt32Int32ConfigDataTowerFloorInfo_hotfix.call(new object[]
				{
					this,
					curEnrgy,
					costEnergy,
					reachFloorInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.m_raidPanelNowEnergyText.text = curEnrgy.ToString();
			this.m_raidPanelNeedEnergyText.text = costEnergy.ToString();
			this.m_raidPanelText.text = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_ClimbTower_RaidFloor), reachFloorInfo.Name);
			UIUtility.SetUIStateOpen(this.m_raidPanelUIStateController, "Show", null, false, true);
		}

		// Token: 0x0600CA0F RID: 51727 RVA: 0x0037CB14 File Offset: 0x0037AD14
		private void HideRaidPanel(Action onEnd = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideRaidPanelAction_hotfix != null)
			{
				this.m_HideRaidPanelAction_hotfix.call(new object[]
				{
					this,
					onEnd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_raidPanelUIStateController, "Close", onEnd, true, true);
		}

		// Token: 0x0600CA10 RID: 51728 RVA: 0x0037CB98 File Offset: 0x0037AD98
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
				this.EventOnReturn();
			}
		}

		// Token: 0x0600CA11 RID: 51729 RVA: 0x0037CC10 File Offset: 0x0037AE10
		private void OnHelpButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHelpButtonClick_hotfix != null)
			{
				this.m_OnHelpButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowHelp != null)
			{
				this.EventOnShowHelp();
			}
		}

		// Token: 0x0600CA12 RID: 51730 RVA: 0x0037CC88 File Offset: 0x0037AE88
		private void OnStartButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartButtonClick_hotfix != null)
			{
				this.m_OnStartButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowLevelInfo != null)
			{
				this.EventOnShowLevelInfo();
			}
		}

		// Token: 0x0600CA13 RID: 51731 RVA: 0x0037CD00 File Offset: 0x0037AF00
		private void OnRaidButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRaidButtonClick_hotfix != null)
			{
				this.m_OnRaidButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (UIUtility.GetUIStateCurrentStateName(this.m_raidButtonUIStateController) == "Grey")
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_ClimbTower_RaidReachFloorMax, 2f, null, true);
				return;
			}
			if (this.EventOnShowRaid != null)
			{
				this.EventOnShowRaid();
			}
		}

		// Token: 0x0600CA14 RID: 51732 RVA: 0x0037CDA8 File Offset: 0x0037AFA8
		private void OnShowRewardButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnShowRewardButtonClick_hotfix != null)
			{
				this.m_OnShowRewardButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ShowRewardPreview();
		}

		// Token: 0x0600CA15 RID: 51733 RVA: 0x0037CE10 File Offset: 0x0037B010
		private void OnRewardPreviewCloseButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRewardPreviewCloseButtonClick_hotfix != null)
			{
				this.m_OnRewardPreviewCloseButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideRewardPreview();
		}

		// Token: 0x0600CA16 RID: 51734 RVA: 0x0037CE78 File Offset: 0x0037B078
		private void OnRaidPanelConfirmButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRaidPanelConfirmButtonClick_hotfix != null)
			{
				this.m_OnRaidPanelConfirmButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideRaidPanel(delegate
			{
				if (this.EventOnConfirmRaid != null)
				{
					this.EventOnConfirmRaid();
				}
			});
		}

		// Token: 0x0600CA17 RID: 51735 RVA: 0x0037CEEC File Offset: 0x0037B0EC
		private void OnRaidPanelCancelButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRaidPanelCancelButtonClick_hotfix != null)
			{
				this.m_OnRaidPanelCancelButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideRaidPanel(null);
		}

		// Token: 0x0600CA18 RID: 51736 RVA: 0x0037CF54 File Offset: 0x0037B154
		private void ClimbTowerFloorItemUIController_OnButtonClick(ClimbTowerFloorItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClimbTowerFloorItemUIController_OnButtonClickClimbTowerFloorItemUIController_hotfix != null)
			{
				this.m_ClimbTowerFloorItemUIController_OnButtonClickClimbTowerFloorItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowLevelInfo != null)
			{
				this.EventOnShowLevelInfo();
			}
		}

		// Token: 0x14000270 RID: 624
		// (add) Token: 0x0600CA19 RID: 51737 RVA: 0x0037CFDC File Offset: 0x0037B1DC
		// (remove) Token: 0x0600CA1A RID: 51738 RVA: 0x0037D078 File Offset: 0x0037B278
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

		// Token: 0x14000271 RID: 625
		// (add) Token: 0x0600CA1B RID: 51739 RVA: 0x0037D114 File Offset: 0x0037B314
		// (remove) Token: 0x0600CA1C RID: 51740 RVA: 0x0037D1B0 File Offset: 0x0037B3B0
		public event Action EventOnShowHelp
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowHelpAction_hotfix != null)
				{
					this.m_add_EventOnShowHelpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowHelp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowHelp, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowHelpAction_hotfix != null)
				{
					this.m_remove_EventOnShowHelpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowHelp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowHelp, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000272 RID: 626
		// (add) Token: 0x0600CA1D RID: 51741 RVA: 0x0037D24C File Offset: 0x0037B44C
		// (remove) Token: 0x0600CA1E RID: 51742 RVA: 0x0037D2E8 File Offset: 0x0037B4E8
		public event Action EventOnShowRaid
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowRaidAction_hotfix != null)
				{
					this.m_add_EventOnShowRaidAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowRaid;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowRaid, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowRaidAction_hotfix != null)
				{
					this.m_remove_EventOnShowRaidAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowRaid;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowRaid, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000273 RID: 627
		// (add) Token: 0x0600CA1F RID: 51743 RVA: 0x0037D384 File Offset: 0x0037B584
		// (remove) Token: 0x0600CA20 RID: 51744 RVA: 0x0037D420 File Offset: 0x0037B620
		public event Action EventOnShowLevelInfo
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowLevelInfoAction_hotfix != null)
				{
					this.m_add_EventOnShowLevelInfoAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowLevelInfo;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowLevelInfo, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowLevelInfoAction_hotfix != null)
				{
					this.m_remove_EventOnShowLevelInfoAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowLevelInfo;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowLevelInfo, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000274 RID: 628
		// (add) Token: 0x0600CA21 RID: 51745 RVA: 0x0037D4BC File Offset: 0x0037B6BC
		// (remove) Token: 0x0600CA22 RID: 51746 RVA: 0x0037D558 File Offset: 0x0037B758
		public event Action EventOnConfirmRaid
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnConfirmRaidAction_hotfix != null)
				{
					this.m_add_EventOnConfirmRaidAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnConfirmRaid;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnConfirmRaid, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnConfirmRaidAction_hotfix != null)
				{
					this.m_remove_EventOnConfirmRaidAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnConfirmRaid;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnConfirmRaid, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002816 RID: 10262
		// (get) Token: 0x0600CA23 RID: 51747 RVA: 0x0037D5F4 File Offset: 0x0037B7F4
		// (set) Token: 0x0600CA24 RID: 51748 RVA: 0x0037D614 File Offset: 0x0037B814
		[DoNotToLua]
		public new ClimbTowerUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ClimbTowerUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600CA25 RID: 51749 RVA: 0x0037D620 File Offset: 0x0037B820
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600CA26 RID: 51750 RVA: 0x0037D62C File Offset: 0x0037B82C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600CA27 RID: 51751 RVA: 0x0037D634 File Offset: 0x0037B834
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600CA28 RID: 51752 RVA: 0x0037D63C File Offset: 0x0037B83C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600CA29 RID: 51753 RVA: 0x0037D650 File Offset: 0x0037B850
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600CA2A RID: 51754 RVA: 0x0037D658 File Offset: 0x0037B858
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600CA2B RID: 51755 RVA: 0x0037D664 File Offset: 0x0037B864
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600CA2C RID: 51756 RVA: 0x0037D670 File Offset: 0x0037B870
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600CA2D RID: 51757 RVA: 0x0037D67C File Offset: 0x0037B87C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600CA2E RID: 51758 RVA: 0x0037D688 File Offset: 0x0037B888
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600CA2F RID: 51759 RVA: 0x0037D694 File Offset: 0x0037B894
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600CA30 RID: 51760 RVA: 0x0037D6A0 File Offset: 0x0037B8A0
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600CA31 RID: 51761 RVA: 0x0037D6AC File Offset: 0x0037B8AC
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600CA32 RID: 51762 RVA: 0x0037D6B8 File Offset: 0x0037B8B8
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600CA33 RID: 51763 RVA: 0x0037D6C4 File Offset: 0x0037B8C4
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600CA34 RID: 51764 RVA: 0x0037D6CC File Offset: 0x0037B8CC
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x0600CA35 RID: 51765 RVA: 0x0037D6EC File Offset: 0x0037B8EC
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x0600CA36 RID: 51766 RVA: 0x0037D6F8 File Offset: 0x0037B8F8
		private void __callDele_EventOnShowHelp()
		{
			Action eventOnShowHelp = this.EventOnShowHelp;
			if (eventOnShowHelp != null)
			{
				eventOnShowHelp();
			}
		}

		// Token: 0x0600CA37 RID: 51767 RVA: 0x0037D718 File Offset: 0x0037B918
		private void __clearDele_EventOnShowHelp()
		{
			this.EventOnShowHelp = null;
		}

		// Token: 0x0600CA38 RID: 51768 RVA: 0x0037D724 File Offset: 0x0037B924
		private void __callDele_EventOnShowRaid()
		{
			Action eventOnShowRaid = this.EventOnShowRaid;
			if (eventOnShowRaid != null)
			{
				eventOnShowRaid();
			}
		}

		// Token: 0x0600CA39 RID: 51769 RVA: 0x0037D744 File Offset: 0x0037B944
		private void __clearDele_EventOnShowRaid()
		{
			this.EventOnShowRaid = null;
		}

		// Token: 0x0600CA3A RID: 51770 RVA: 0x0037D750 File Offset: 0x0037B950
		private void __callDele_EventOnShowLevelInfo()
		{
			Action eventOnShowLevelInfo = this.EventOnShowLevelInfo;
			if (eventOnShowLevelInfo != null)
			{
				eventOnShowLevelInfo();
			}
		}

		// Token: 0x0600CA3B RID: 51771 RVA: 0x0037D770 File Offset: 0x0037B970
		private void __clearDele_EventOnShowLevelInfo()
		{
			this.EventOnShowLevelInfo = null;
		}

		// Token: 0x0600CA3C RID: 51772 RVA: 0x0037D77C File Offset: 0x0037B97C
		private void __callDele_EventOnConfirmRaid()
		{
			Action eventOnConfirmRaid = this.EventOnConfirmRaid;
			if (eventOnConfirmRaid != null)
			{
				eventOnConfirmRaid();
			}
		}

		// Token: 0x0600CA3D RID: 51773 RVA: 0x0037D79C File Offset: 0x0037B99C
		private void __clearDele_EventOnConfirmRaid()
		{
			this.EventOnConfirmRaid = null;
		}

		// Token: 0x0600CA3F RID: 51775 RVA: 0x0037D7C0 File Offset: 0x0037B9C0
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
					this.m_SetNextFlushTimeTimeSpan_hotfix = (luaObj.RawGet("SetNextFlushTime") as LuaFunction);
					this.m_SetClearAllFloorsBoolean_hotfix = (luaObj.RawGet("SetClearAllFloors") as LuaFunction);
					this.m_ShowClearEffectBeginBooleanAction_hotfix = (luaObj.RawGet("ShowClearEffectBegin") as LuaFunction);
					this.m_Co_ShowClearEffectBeginBooleanAction_hotfix = (luaObj.RawGet("Co_ShowClearEffectBegin") as LuaFunction);
					this.m_ShowClearEffectEnd_hotfix = (luaObj.RawGet("ShowClearEffectEnd") as LuaFunction);
					this.m_SetProgressSingle_hotfix = (luaObj.RawGet("SetProgress") as LuaFunction);
					this.m_SetCurrentTowerFloorConfigDataTowerFloorInfo_hotfix = (luaObj.RawGet("SetCurrentTowerFloor") as LuaFunction);
					this.m_SetTowerFloorInt32ConfigDataTowerFloorInfoConfigDataTowerLevelInfoBooleanBoolean_hotfix = (luaObj.RawGet("SetTowerFloor") as LuaFunction);
					this.m_ShowRaidButtonBoolean_hotfix = (luaObj.RawGet("ShowRaidButton") as LuaFunction);
					this.m_SetRaidTowerFloorConfigDataTowerFloorInfoConfigDataTowerFloorInfoBoolean_hotfix = (luaObj.RawGet("SetRaidTowerFloor") as LuaFunction);
					this.m_ShowRewardPreview_hotfix = (luaObj.RawGet("ShowRewardPreview") as LuaFunction);
					this.m_HideRewardPreview_hotfix = (luaObj.RawGet("HideRewardPreview") as LuaFunction);
					this.m_ShowRaidPanelInt32Int32ConfigDataTowerFloorInfo_hotfix = (luaObj.RawGet("ShowRaidPanel") as LuaFunction);
					this.m_HideRaidPanelAction_hotfix = (luaObj.RawGet("HideRaidPanel") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_OnHelpButtonClick_hotfix = (luaObj.RawGet("OnHelpButtonClick") as LuaFunction);
					this.m_OnStartButtonClick_hotfix = (luaObj.RawGet("OnStartButtonClick") as LuaFunction);
					this.m_OnRaidButtonClick_hotfix = (luaObj.RawGet("OnRaidButtonClick") as LuaFunction);
					this.m_OnShowRewardButtonClick_hotfix = (luaObj.RawGet("OnShowRewardButtonClick") as LuaFunction);
					this.m_OnRewardPreviewCloseButtonClick_hotfix = (luaObj.RawGet("OnRewardPreviewCloseButtonClick") as LuaFunction);
					this.m_OnRaidPanelConfirmButtonClick_hotfix = (luaObj.RawGet("OnRaidPanelConfirmButtonClick") as LuaFunction);
					this.m_OnRaidPanelCancelButtonClick_hotfix = (luaObj.RawGet("OnRaidPanelCancelButtonClick") as LuaFunction);
					this.m_ClimbTowerFloorItemUIController_OnButtonClickClimbTowerFloorItemUIController_hotfix = (luaObj.RawGet("ClimbTowerFloorItemUIController_OnButtonClick") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnShowHelpAction_hotfix = (luaObj.RawGet("add_EventOnShowHelp") as LuaFunction);
					this.m_remove_EventOnShowHelpAction_hotfix = (luaObj.RawGet("remove_EventOnShowHelp") as LuaFunction);
					this.m_add_EventOnShowRaidAction_hotfix = (luaObj.RawGet("add_EventOnShowRaid") as LuaFunction);
					this.m_remove_EventOnShowRaidAction_hotfix = (luaObj.RawGet("remove_EventOnShowRaid") as LuaFunction);
					this.m_add_EventOnShowLevelInfoAction_hotfix = (luaObj.RawGet("add_EventOnShowLevelInfo") as LuaFunction);
					this.m_remove_EventOnShowLevelInfoAction_hotfix = (luaObj.RawGet("remove_EventOnShowLevelInfo") as LuaFunction);
					this.m_add_EventOnConfirmRaidAction_hotfix = (luaObj.RawGet("add_EventOnConfirmRaid") as LuaFunction);
					this.m_remove_EventOnConfirmRaidAction_hotfix = (luaObj.RawGet("remove_EventOnConfirmRaid") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600CA40 RID: 51776 RVA: 0x0037DBE0 File Offset: 0x0037BDE0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ClimbTowerUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007F39 RID: 32569
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x04007F3A RID: 32570
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x04007F3B RID: 32571
		[AutoBind("./HelpButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_helpButton;

		// Token: 0x04007F3C RID: 32572
		[AutoBind("./TopProgress/RewardButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_showRewardButton;

		// Token: 0x04007F3D RID: 32573
		[AutoBind("./StartButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_startButton;

		// Token: 0x04007F3E RID: 32574
		[AutoBind("./StageClearOrNot", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_clearUIStateController;

		// Token: 0x04007F3F RID: 32575
		[AutoBind("./RaidButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_raidButton;

		// Token: 0x04007F40 RID: 32576
		[AutoBind("./RaidButton", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_raidButtonUIStateController;

		// Token: 0x04007F41 RID: 32577
		[AutoBind("./RaidButton/InfoPanel/TopValue", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_historyMaxFloorText;

		// Token: 0x04007F42 RID: 32578
		[AutoBind("./RaidButton/InfoPanel/WeekTopValue", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_raidMaxFloorText;

		// Token: 0x04007F43 RID: 32579
		[AutoBind("./StageName/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_bigFloorNameText;

		// Token: 0x04007F44 RID: 32580
		[AutoBind("./BlackCover", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_blackCoverUIStateController;

		// Token: 0x04007F45 RID: 32581
		[AutoBind("./StageGroup/SoldierItem1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_floor0FloorGameObject;

		// Token: 0x04007F46 RID: 32582
		[AutoBind("./StageGroup/SoldierItem2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_floor1FloorGameObject;

		// Token: 0x04007F47 RID: 32583
		[AutoBind("./StageGroup/SoldierItem3", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_floor2FloorGameObject;

		// Token: 0x04007F48 RID: 32584
		[AutoBind("./StageGroup/SoldierItem4", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_floor3FloorGameObject;

		// Token: 0x04007F49 RID: 32585
		[AutoBind("./StageGroup/BossItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_floor4FloorGameObject;

		// Token: 0x04007F4A RID: 32586
		[AutoBind("./TopProgress/ProgressBar", AutoBindAttribute.InitState.NotInit, false)]
		private Slider m_progressSlider;

		// Token: 0x04007F4B RID: 32587
		[AutoBind("./TopProgress/ProgressBar/Fill Area/Info/Text/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_progressInfoText;

		// Token: 0x04007F4C RID: 32588
		[AutoBind("./TopProgress/TimeText/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_flushTimeText;

		// Token: 0x04007F4D RID: 32589
		[AutoBind("./RewardPreview", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_rewardPreviewUIStateController;

		// Token: 0x04007F4E RID: 32590
		[AutoBind("./RewardPreview/BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_rewardPreviewBackgroundButton;

		// Token: 0x04007F4F RID: 32591
		[AutoBind("./RewardPreview/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_rewardPreviewScollRect;

		// Token: 0x04007F50 RID: 32592
		[AutoBind("./RaidPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_raidPanelUIStateController;

		// Token: 0x04007F51 RID: 32593
		[AutoBind("./RaidPanel/Detail/NowEngryValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_raidPanelNowEnergyText;

		// Token: 0x04007F52 RID: 32594
		[AutoBind("./RaidPanel/Detail/NeedEngryValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_raidPanelNeedEnergyText;

		// Token: 0x04007F53 RID: 32595
		[AutoBind("./RaidPanel/Detail/RaidText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_raidPanelText;

		// Token: 0x04007F54 RID: 32596
		[AutoBind("./RaidPanel/Detail/ConfirmButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_raidPanelConfirmButton;

		// Token: 0x04007F55 RID: 32597
		[AutoBind("./RaidPanel/Detail/CancelButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_raidPanelCancelButton;

		// Token: 0x04007F56 RID: 32598
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_prefabsGameObject;

		// Token: 0x04007F57 RID: 32599
		[AutoBind("./Prefabs/RewardItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rewardItemPrefab;

		// Token: 0x04007F58 RID: 32600
		private ClimbTowerFloorItemUIController[] m_climbTowerFloorItemUIControllers = new ClimbTowerFloorItemUIController[5];

		// Token: 0x04007F59 RID: 32601
		[DoNotToLua]
		private ClimbTowerUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04007F5A RID: 32602
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007F5B RID: 32603
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007F5C RID: 32604
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04007F5D RID: 32605
		private LuaFunction m_Open_hotfix;

		// Token: 0x04007F5E RID: 32606
		private LuaFunction m_SetNextFlushTimeTimeSpan_hotfix;

		// Token: 0x04007F5F RID: 32607
		private LuaFunction m_SetClearAllFloorsBoolean_hotfix;

		// Token: 0x04007F60 RID: 32608
		private LuaFunction m_ShowClearEffectBeginBooleanAction_hotfix;

		// Token: 0x04007F61 RID: 32609
		private LuaFunction m_Co_ShowClearEffectBeginBooleanAction_hotfix;

		// Token: 0x04007F62 RID: 32610
		private LuaFunction m_ShowClearEffectEnd_hotfix;

		// Token: 0x04007F63 RID: 32611
		private LuaFunction m_SetProgressSingle_hotfix;

		// Token: 0x04007F64 RID: 32612
		private LuaFunction m_SetCurrentTowerFloorConfigDataTowerFloorInfo_hotfix;

		// Token: 0x04007F65 RID: 32613
		private LuaFunction m_SetTowerFloorInt32ConfigDataTowerFloorInfoConfigDataTowerLevelInfoBooleanBoolean_hotfix;

		// Token: 0x04007F66 RID: 32614
		private LuaFunction m_ShowRaidButtonBoolean_hotfix;

		// Token: 0x04007F67 RID: 32615
		private LuaFunction m_SetRaidTowerFloorConfigDataTowerFloorInfoConfigDataTowerFloorInfoBoolean_hotfix;

		// Token: 0x04007F68 RID: 32616
		private LuaFunction m_ShowRewardPreview_hotfix;

		// Token: 0x04007F69 RID: 32617
		private LuaFunction m_HideRewardPreview_hotfix;

		// Token: 0x04007F6A RID: 32618
		private LuaFunction m_ShowRaidPanelInt32Int32ConfigDataTowerFloorInfo_hotfix;

		// Token: 0x04007F6B RID: 32619
		private LuaFunction m_HideRaidPanelAction_hotfix;

		// Token: 0x04007F6C RID: 32620
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x04007F6D RID: 32621
		private LuaFunction m_OnHelpButtonClick_hotfix;

		// Token: 0x04007F6E RID: 32622
		private LuaFunction m_OnStartButtonClick_hotfix;

		// Token: 0x04007F6F RID: 32623
		private LuaFunction m_OnRaidButtonClick_hotfix;

		// Token: 0x04007F70 RID: 32624
		private LuaFunction m_OnShowRewardButtonClick_hotfix;

		// Token: 0x04007F71 RID: 32625
		private LuaFunction m_OnRewardPreviewCloseButtonClick_hotfix;

		// Token: 0x04007F72 RID: 32626
		private LuaFunction m_OnRaidPanelConfirmButtonClick_hotfix;

		// Token: 0x04007F73 RID: 32627
		private LuaFunction m_OnRaidPanelCancelButtonClick_hotfix;

		// Token: 0x04007F74 RID: 32628
		private LuaFunction m_ClimbTowerFloorItemUIController_OnButtonClickClimbTowerFloorItemUIController_hotfix;

		// Token: 0x04007F75 RID: 32629
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x04007F76 RID: 32630
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x04007F77 RID: 32631
		private LuaFunction m_add_EventOnShowHelpAction_hotfix;

		// Token: 0x04007F78 RID: 32632
		private LuaFunction m_remove_EventOnShowHelpAction_hotfix;

		// Token: 0x04007F79 RID: 32633
		private LuaFunction m_add_EventOnShowRaidAction_hotfix;

		// Token: 0x04007F7A RID: 32634
		private LuaFunction m_remove_EventOnShowRaidAction_hotfix;

		// Token: 0x04007F7B RID: 32635
		private LuaFunction m_add_EventOnShowLevelInfoAction_hotfix;

		// Token: 0x04007F7C RID: 32636
		private LuaFunction m_remove_EventOnShowLevelInfoAction_hotfix;

		// Token: 0x04007F7D RID: 32637
		private LuaFunction m_add_EventOnConfirmRaidAction_hotfix;

		// Token: 0x04007F7E RID: 32638
		private LuaFunction m_remove_EventOnConfirmRaidAction_hotfix;

		// Token: 0x02000B92 RID: 2962
		public new class LuaExportHelper
		{
			// Token: 0x0600CA41 RID: 51777 RVA: 0x0037DC48 File Offset: 0x0037BE48
			public LuaExportHelper(ClimbTowerUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600CA42 RID: 51778 RVA: 0x0037DC58 File Offset: 0x0037BE58
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600CA43 RID: 51779 RVA: 0x0037DC68 File Offset: 0x0037BE68
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600CA44 RID: 51780 RVA: 0x0037DC78 File Offset: 0x0037BE78
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600CA45 RID: 51781 RVA: 0x0037DC88 File Offset: 0x0037BE88
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600CA46 RID: 51782 RVA: 0x0037DCA0 File Offset: 0x0037BEA0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600CA47 RID: 51783 RVA: 0x0037DCB0 File Offset: 0x0037BEB0
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600CA48 RID: 51784 RVA: 0x0037DCC0 File Offset: 0x0037BEC0
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600CA49 RID: 51785 RVA: 0x0037DCD0 File Offset: 0x0037BED0
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600CA4A RID: 51786 RVA: 0x0037DCE0 File Offset: 0x0037BEE0
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600CA4B RID: 51787 RVA: 0x0037DCF0 File Offset: 0x0037BEF0
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600CA4C RID: 51788 RVA: 0x0037DD00 File Offset: 0x0037BF00
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600CA4D RID: 51789 RVA: 0x0037DD10 File Offset: 0x0037BF10
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600CA4E RID: 51790 RVA: 0x0037DD20 File Offset: 0x0037BF20
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600CA4F RID: 51791 RVA: 0x0037DD30 File Offset: 0x0037BF30
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600CA50 RID: 51792 RVA: 0x0037DD40 File Offset: 0x0037BF40
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600CA51 RID: 51793 RVA: 0x0037DD50 File Offset: 0x0037BF50
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x0600CA52 RID: 51794 RVA: 0x0037DD60 File Offset: 0x0037BF60
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x0600CA53 RID: 51795 RVA: 0x0037DD70 File Offset: 0x0037BF70
			public void __callDele_EventOnShowHelp()
			{
				this.m_owner.__callDele_EventOnShowHelp();
			}

			// Token: 0x0600CA54 RID: 51796 RVA: 0x0037DD80 File Offset: 0x0037BF80
			public void __clearDele_EventOnShowHelp()
			{
				this.m_owner.__clearDele_EventOnShowHelp();
			}

			// Token: 0x0600CA55 RID: 51797 RVA: 0x0037DD90 File Offset: 0x0037BF90
			public void __callDele_EventOnShowRaid()
			{
				this.m_owner.__callDele_EventOnShowRaid();
			}

			// Token: 0x0600CA56 RID: 51798 RVA: 0x0037DDA0 File Offset: 0x0037BFA0
			public void __clearDele_EventOnShowRaid()
			{
				this.m_owner.__clearDele_EventOnShowRaid();
			}

			// Token: 0x0600CA57 RID: 51799 RVA: 0x0037DDB0 File Offset: 0x0037BFB0
			public void __callDele_EventOnShowLevelInfo()
			{
				this.m_owner.__callDele_EventOnShowLevelInfo();
			}

			// Token: 0x0600CA58 RID: 51800 RVA: 0x0037DDC0 File Offset: 0x0037BFC0
			public void __clearDele_EventOnShowLevelInfo()
			{
				this.m_owner.__clearDele_EventOnShowLevelInfo();
			}

			// Token: 0x0600CA59 RID: 51801 RVA: 0x0037DDD0 File Offset: 0x0037BFD0
			public void __callDele_EventOnConfirmRaid()
			{
				this.m_owner.__callDele_EventOnConfirmRaid();
			}

			// Token: 0x0600CA5A RID: 51802 RVA: 0x0037DDE0 File Offset: 0x0037BFE0
			public void __clearDele_EventOnConfirmRaid()
			{
				this.m_owner.__clearDele_EventOnConfirmRaid();
			}

			// Token: 0x17002817 RID: 10263
			// (get) Token: 0x0600CA5B RID: 51803 RVA: 0x0037DDF0 File Offset: 0x0037BFF0
			// (set) Token: 0x0600CA5C RID: 51804 RVA: 0x0037DE00 File Offset: 0x0037C000
			public CommonUIStateController m_uiStateController
			{
				get
				{
					return this.m_owner.m_uiStateController;
				}
				set
				{
					this.m_owner.m_uiStateController = value;
				}
			}

			// Token: 0x17002818 RID: 10264
			// (get) Token: 0x0600CA5D RID: 51805 RVA: 0x0037DE10 File Offset: 0x0037C010
			// (set) Token: 0x0600CA5E RID: 51806 RVA: 0x0037DE20 File Offset: 0x0037C020
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

			// Token: 0x17002819 RID: 10265
			// (get) Token: 0x0600CA5F RID: 51807 RVA: 0x0037DE30 File Offset: 0x0037C030
			// (set) Token: 0x0600CA60 RID: 51808 RVA: 0x0037DE40 File Offset: 0x0037C040
			public Button m_helpButton
			{
				get
				{
					return this.m_owner.m_helpButton;
				}
				set
				{
					this.m_owner.m_helpButton = value;
				}
			}

			// Token: 0x1700281A RID: 10266
			// (get) Token: 0x0600CA61 RID: 51809 RVA: 0x0037DE50 File Offset: 0x0037C050
			// (set) Token: 0x0600CA62 RID: 51810 RVA: 0x0037DE60 File Offset: 0x0037C060
			public Button m_showRewardButton
			{
				get
				{
					return this.m_owner.m_showRewardButton;
				}
				set
				{
					this.m_owner.m_showRewardButton = value;
				}
			}

			// Token: 0x1700281B RID: 10267
			// (get) Token: 0x0600CA63 RID: 51811 RVA: 0x0037DE70 File Offset: 0x0037C070
			// (set) Token: 0x0600CA64 RID: 51812 RVA: 0x0037DE80 File Offset: 0x0037C080
			public Button m_startButton
			{
				get
				{
					return this.m_owner.m_startButton;
				}
				set
				{
					this.m_owner.m_startButton = value;
				}
			}

			// Token: 0x1700281C RID: 10268
			// (get) Token: 0x0600CA65 RID: 51813 RVA: 0x0037DE90 File Offset: 0x0037C090
			// (set) Token: 0x0600CA66 RID: 51814 RVA: 0x0037DEA0 File Offset: 0x0037C0A0
			public CommonUIStateController m_clearUIStateController
			{
				get
				{
					return this.m_owner.m_clearUIStateController;
				}
				set
				{
					this.m_owner.m_clearUIStateController = value;
				}
			}

			// Token: 0x1700281D RID: 10269
			// (get) Token: 0x0600CA67 RID: 51815 RVA: 0x0037DEB0 File Offset: 0x0037C0B0
			// (set) Token: 0x0600CA68 RID: 51816 RVA: 0x0037DEC0 File Offset: 0x0037C0C0
			public Button m_raidButton
			{
				get
				{
					return this.m_owner.m_raidButton;
				}
				set
				{
					this.m_owner.m_raidButton = value;
				}
			}

			// Token: 0x1700281E RID: 10270
			// (get) Token: 0x0600CA69 RID: 51817 RVA: 0x0037DED0 File Offset: 0x0037C0D0
			// (set) Token: 0x0600CA6A RID: 51818 RVA: 0x0037DEE0 File Offset: 0x0037C0E0
			public CommonUIStateController m_raidButtonUIStateController
			{
				get
				{
					return this.m_owner.m_raidButtonUIStateController;
				}
				set
				{
					this.m_owner.m_raidButtonUIStateController = value;
				}
			}

			// Token: 0x1700281F RID: 10271
			// (get) Token: 0x0600CA6B RID: 51819 RVA: 0x0037DEF0 File Offset: 0x0037C0F0
			// (set) Token: 0x0600CA6C RID: 51820 RVA: 0x0037DF00 File Offset: 0x0037C100
			public Text m_historyMaxFloorText
			{
				get
				{
					return this.m_owner.m_historyMaxFloorText;
				}
				set
				{
					this.m_owner.m_historyMaxFloorText = value;
				}
			}

			// Token: 0x17002820 RID: 10272
			// (get) Token: 0x0600CA6D RID: 51821 RVA: 0x0037DF10 File Offset: 0x0037C110
			// (set) Token: 0x0600CA6E RID: 51822 RVA: 0x0037DF20 File Offset: 0x0037C120
			public Text m_raidMaxFloorText
			{
				get
				{
					return this.m_owner.m_raidMaxFloorText;
				}
				set
				{
					this.m_owner.m_raidMaxFloorText = value;
				}
			}

			// Token: 0x17002821 RID: 10273
			// (get) Token: 0x0600CA6F RID: 51823 RVA: 0x0037DF30 File Offset: 0x0037C130
			// (set) Token: 0x0600CA70 RID: 51824 RVA: 0x0037DF40 File Offset: 0x0037C140
			public Text m_bigFloorNameText
			{
				get
				{
					return this.m_owner.m_bigFloorNameText;
				}
				set
				{
					this.m_owner.m_bigFloorNameText = value;
				}
			}

			// Token: 0x17002822 RID: 10274
			// (get) Token: 0x0600CA71 RID: 51825 RVA: 0x0037DF50 File Offset: 0x0037C150
			// (set) Token: 0x0600CA72 RID: 51826 RVA: 0x0037DF60 File Offset: 0x0037C160
			public CommonUIStateController m_blackCoverUIStateController
			{
				get
				{
					return this.m_owner.m_blackCoverUIStateController;
				}
				set
				{
					this.m_owner.m_blackCoverUIStateController = value;
				}
			}

			// Token: 0x17002823 RID: 10275
			// (get) Token: 0x0600CA73 RID: 51827 RVA: 0x0037DF70 File Offset: 0x0037C170
			// (set) Token: 0x0600CA74 RID: 51828 RVA: 0x0037DF80 File Offset: 0x0037C180
			public GameObject m_floor0FloorGameObject
			{
				get
				{
					return this.m_owner.m_floor0FloorGameObject;
				}
				set
				{
					this.m_owner.m_floor0FloorGameObject = value;
				}
			}

			// Token: 0x17002824 RID: 10276
			// (get) Token: 0x0600CA75 RID: 51829 RVA: 0x0037DF90 File Offset: 0x0037C190
			// (set) Token: 0x0600CA76 RID: 51830 RVA: 0x0037DFA0 File Offset: 0x0037C1A0
			public GameObject m_floor1FloorGameObject
			{
				get
				{
					return this.m_owner.m_floor1FloorGameObject;
				}
				set
				{
					this.m_owner.m_floor1FloorGameObject = value;
				}
			}

			// Token: 0x17002825 RID: 10277
			// (get) Token: 0x0600CA77 RID: 51831 RVA: 0x0037DFB0 File Offset: 0x0037C1B0
			// (set) Token: 0x0600CA78 RID: 51832 RVA: 0x0037DFC0 File Offset: 0x0037C1C0
			public GameObject m_floor2FloorGameObject
			{
				get
				{
					return this.m_owner.m_floor2FloorGameObject;
				}
				set
				{
					this.m_owner.m_floor2FloorGameObject = value;
				}
			}

			// Token: 0x17002826 RID: 10278
			// (get) Token: 0x0600CA79 RID: 51833 RVA: 0x0037DFD0 File Offset: 0x0037C1D0
			// (set) Token: 0x0600CA7A RID: 51834 RVA: 0x0037DFE0 File Offset: 0x0037C1E0
			public GameObject m_floor3FloorGameObject
			{
				get
				{
					return this.m_owner.m_floor3FloorGameObject;
				}
				set
				{
					this.m_owner.m_floor3FloorGameObject = value;
				}
			}

			// Token: 0x17002827 RID: 10279
			// (get) Token: 0x0600CA7B RID: 51835 RVA: 0x0037DFF0 File Offset: 0x0037C1F0
			// (set) Token: 0x0600CA7C RID: 51836 RVA: 0x0037E000 File Offset: 0x0037C200
			public GameObject m_floor4FloorGameObject
			{
				get
				{
					return this.m_owner.m_floor4FloorGameObject;
				}
				set
				{
					this.m_owner.m_floor4FloorGameObject = value;
				}
			}

			// Token: 0x17002828 RID: 10280
			// (get) Token: 0x0600CA7D RID: 51837 RVA: 0x0037E010 File Offset: 0x0037C210
			// (set) Token: 0x0600CA7E RID: 51838 RVA: 0x0037E020 File Offset: 0x0037C220
			public Slider m_progressSlider
			{
				get
				{
					return this.m_owner.m_progressSlider;
				}
				set
				{
					this.m_owner.m_progressSlider = value;
				}
			}

			// Token: 0x17002829 RID: 10281
			// (get) Token: 0x0600CA7F RID: 51839 RVA: 0x0037E030 File Offset: 0x0037C230
			// (set) Token: 0x0600CA80 RID: 51840 RVA: 0x0037E040 File Offset: 0x0037C240
			public Text m_progressInfoText
			{
				get
				{
					return this.m_owner.m_progressInfoText;
				}
				set
				{
					this.m_owner.m_progressInfoText = value;
				}
			}

			// Token: 0x1700282A RID: 10282
			// (get) Token: 0x0600CA81 RID: 51841 RVA: 0x0037E050 File Offset: 0x0037C250
			// (set) Token: 0x0600CA82 RID: 51842 RVA: 0x0037E060 File Offset: 0x0037C260
			public Text m_flushTimeText
			{
				get
				{
					return this.m_owner.m_flushTimeText;
				}
				set
				{
					this.m_owner.m_flushTimeText = value;
				}
			}

			// Token: 0x1700282B RID: 10283
			// (get) Token: 0x0600CA83 RID: 51843 RVA: 0x0037E070 File Offset: 0x0037C270
			// (set) Token: 0x0600CA84 RID: 51844 RVA: 0x0037E080 File Offset: 0x0037C280
			public CommonUIStateController m_rewardPreviewUIStateController
			{
				get
				{
					return this.m_owner.m_rewardPreviewUIStateController;
				}
				set
				{
					this.m_owner.m_rewardPreviewUIStateController = value;
				}
			}

			// Token: 0x1700282C RID: 10284
			// (get) Token: 0x0600CA85 RID: 51845 RVA: 0x0037E090 File Offset: 0x0037C290
			// (set) Token: 0x0600CA86 RID: 51846 RVA: 0x0037E0A0 File Offset: 0x0037C2A0
			public Button m_rewardPreviewBackgroundButton
			{
				get
				{
					return this.m_owner.m_rewardPreviewBackgroundButton;
				}
				set
				{
					this.m_owner.m_rewardPreviewBackgroundButton = value;
				}
			}

			// Token: 0x1700282D RID: 10285
			// (get) Token: 0x0600CA87 RID: 51847 RVA: 0x0037E0B0 File Offset: 0x0037C2B0
			// (set) Token: 0x0600CA88 RID: 51848 RVA: 0x0037E0C0 File Offset: 0x0037C2C0
			public ScrollRect m_rewardPreviewScollRect
			{
				get
				{
					return this.m_owner.m_rewardPreviewScollRect;
				}
				set
				{
					this.m_owner.m_rewardPreviewScollRect = value;
				}
			}

			// Token: 0x1700282E RID: 10286
			// (get) Token: 0x0600CA89 RID: 51849 RVA: 0x0037E0D0 File Offset: 0x0037C2D0
			// (set) Token: 0x0600CA8A RID: 51850 RVA: 0x0037E0E0 File Offset: 0x0037C2E0
			public CommonUIStateController m_raidPanelUIStateController
			{
				get
				{
					return this.m_owner.m_raidPanelUIStateController;
				}
				set
				{
					this.m_owner.m_raidPanelUIStateController = value;
				}
			}

			// Token: 0x1700282F RID: 10287
			// (get) Token: 0x0600CA8B RID: 51851 RVA: 0x0037E0F0 File Offset: 0x0037C2F0
			// (set) Token: 0x0600CA8C RID: 51852 RVA: 0x0037E100 File Offset: 0x0037C300
			public Text m_raidPanelNowEnergyText
			{
				get
				{
					return this.m_owner.m_raidPanelNowEnergyText;
				}
				set
				{
					this.m_owner.m_raidPanelNowEnergyText = value;
				}
			}

			// Token: 0x17002830 RID: 10288
			// (get) Token: 0x0600CA8D RID: 51853 RVA: 0x0037E110 File Offset: 0x0037C310
			// (set) Token: 0x0600CA8E RID: 51854 RVA: 0x0037E120 File Offset: 0x0037C320
			public Text m_raidPanelNeedEnergyText
			{
				get
				{
					return this.m_owner.m_raidPanelNeedEnergyText;
				}
				set
				{
					this.m_owner.m_raidPanelNeedEnergyText = value;
				}
			}

			// Token: 0x17002831 RID: 10289
			// (get) Token: 0x0600CA8F RID: 51855 RVA: 0x0037E130 File Offset: 0x0037C330
			// (set) Token: 0x0600CA90 RID: 51856 RVA: 0x0037E140 File Offset: 0x0037C340
			public Text m_raidPanelText
			{
				get
				{
					return this.m_owner.m_raidPanelText;
				}
				set
				{
					this.m_owner.m_raidPanelText = value;
				}
			}

			// Token: 0x17002832 RID: 10290
			// (get) Token: 0x0600CA91 RID: 51857 RVA: 0x0037E150 File Offset: 0x0037C350
			// (set) Token: 0x0600CA92 RID: 51858 RVA: 0x0037E160 File Offset: 0x0037C360
			public Button m_raidPanelConfirmButton
			{
				get
				{
					return this.m_owner.m_raidPanelConfirmButton;
				}
				set
				{
					this.m_owner.m_raidPanelConfirmButton = value;
				}
			}

			// Token: 0x17002833 RID: 10291
			// (get) Token: 0x0600CA93 RID: 51859 RVA: 0x0037E170 File Offset: 0x0037C370
			// (set) Token: 0x0600CA94 RID: 51860 RVA: 0x0037E180 File Offset: 0x0037C380
			public Button m_raidPanelCancelButton
			{
				get
				{
					return this.m_owner.m_raidPanelCancelButton;
				}
				set
				{
					this.m_owner.m_raidPanelCancelButton = value;
				}
			}

			// Token: 0x17002834 RID: 10292
			// (get) Token: 0x0600CA95 RID: 51861 RVA: 0x0037E190 File Offset: 0x0037C390
			// (set) Token: 0x0600CA96 RID: 51862 RVA: 0x0037E1A0 File Offset: 0x0037C3A0
			public GameObject m_prefabsGameObject
			{
				get
				{
					return this.m_owner.m_prefabsGameObject;
				}
				set
				{
					this.m_owner.m_prefabsGameObject = value;
				}
			}

			// Token: 0x17002835 RID: 10293
			// (get) Token: 0x0600CA97 RID: 51863 RVA: 0x0037E1B0 File Offset: 0x0037C3B0
			// (set) Token: 0x0600CA98 RID: 51864 RVA: 0x0037E1C0 File Offset: 0x0037C3C0
			public GameObject m_rewardItemPrefab
			{
				get
				{
					return this.m_owner.m_rewardItemPrefab;
				}
				set
				{
					this.m_owner.m_rewardItemPrefab = value;
				}
			}

			// Token: 0x17002836 RID: 10294
			// (get) Token: 0x0600CA99 RID: 51865 RVA: 0x0037E1D0 File Offset: 0x0037C3D0
			// (set) Token: 0x0600CA9A RID: 51866 RVA: 0x0037E1E0 File Offset: 0x0037C3E0
			public ClimbTowerFloorItemUIController[] m_climbTowerFloorItemUIControllers
			{
				get
				{
					return this.m_owner.m_climbTowerFloorItemUIControllers;
				}
				set
				{
					this.m_owner.m_climbTowerFloorItemUIControllers = value;
				}
			}

			// Token: 0x0600CA9B RID: 51867 RVA: 0x0037E1F0 File Offset: 0x0037C3F0
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600CA9C RID: 51868 RVA: 0x0037E200 File Offset: 0x0037C400
			public IEnumerator Co_ShowClearEffectBegin(bool isRaid, Action onEnd)
			{
				return this.m_owner.Co_ShowClearEffectBegin(isRaid, onEnd);
			}

			// Token: 0x0600CA9D RID: 51869 RVA: 0x0037E210 File Offset: 0x0037C410
			public void HideRewardPreview()
			{
				this.m_owner.HideRewardPreview();
			}

			// Token: 0x0600CA9E RID: 51870 RVA: 0x0037E220 File Offset: 0x0037C420
			public void HideRaidPanel(Action onEnd)
			{
				this.m_owner.HideRaidPanel(onEnd);
			}

			// Token: 0x0600CA9F RID: 51871 RVA: 0x0037E230 File Offset: 0x0037C430
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x0600CAA0 RID: 51872 RVA: 0x0037E240 File Offset: 0x0037C440
			public void OnHelpButtonClick()
			{
				this.m_owner.OnHelpButtonClick();
			}

			// Token: 0x0600CAA1 RID: 51873 RVA: 0x0037E250 File Offset: 0x0037C450
			public void OnStartButtonClick()
			{
				this.m_owner.OnStartButtonClick();
			}

			// Token: 0x0600CAA2 RID: 51874 RVA: 0x0037E260 File Offset: 0x0037C460
			public void OnRaidButtonClick()
			{
				this.m_owner.OnRaidButtonClick();
			}

			// Token: 0x0600CAA3 RID: 51875 RVA: 0x0037E270 File Offset: 0x0037C470
			public void OnShowRewardButtonClick()
			{
				this.m_owner.OnShowRewardButtonClick();
			}

			// Token: 0x0600CAA4 RID: 51876 RVA: 0x0037E280 File Offset: 0x0037C480
			public void OnRewardPreviewCloseButtonClick()
			{
				this.m_owner.OnRewardPreviewCloseButtonClick();
			}

			// Token: 0x0600CAA5 RID: 51877 RVA: 0x0037E290 File Offset: 0x0037C490
			public void OnRaidPanelConfirmButtonClick()
			{
				this.m_owner.OnRaidPanelConfirmButtonClick();
			}

			// Token: 0x0600CAA6 RID: 51878 RVA: 0x0037E2A0 File Offset: 0x0037C4A0
			public void OnRaidPanelCancelButtonClick()
			{
				this.m_owner.OnRaidPanelCancelButtonClick();
			}

			// Token: 0x0600CAA7 RID: 51879 RVA: 0x0037E2B0 File Offset: 0x0037C4B0
			public void ClimbTowerFloorItemUIController_OnButtonClick(ClimbTowerFloorItemUIController ctrl)
			{
				this.m_owner.ClimbTowerFloorItemUIController_OnButtonClick(ctrl);
			}

			// Token: 0x04007F7F RID: 32639
			private ClimbTowerUIController m_owner;
		}
	}
}
