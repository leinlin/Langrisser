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
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x0200102F RID: 4143
	[HotFix]
	public class WorldUIController : UIControllerBase
	{
		// Token: 0x06014FA2 RID: 85922 RVA: 0x0054E394 File Offset: 0x0054C594
		private WorldUIController()
		{
		}

		// Token: 0x06014FA3 RID: 85923 RVA: 0x0054E3D4 File Offset: 0x0054C5D4
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
			this.m_mainButton.onClick.AddListener(new UnityAction(this.OnMainButtonClick));
			this.ShowMainButtonBar(true);
			this.m_compassButton.onClick.AddListener(new UnityAction(this.OnCompassButtonClick));
			this.m_currentScenarioButton.onClick.AddListener(new UnityAction(this.OnCurrentScenarioButtonClick));
			this.m_newScenarioUIStateController.gameObject.SetActive(false);
			this.m_unlockScenarioUIStateController.gameObject.SetActive(false);
			this.m_unlockScenarioBackgroundButton.onClick.AddListener(new UnityAction(this.OnUnlockScenarioBackgroundButtonClick));
			this.m_unlockScenarioGotoButton.onClick.AddListener(new UnityAction(this.OnUnlockScenarioGotoButtonClick));
			this.m_enterScenarioUIStateController.gameObject.SetActive(false);
			this.m_enterScenarioUIStateController.gameObject.SetActive(false);
			this.m_enterMonsterUIStateController.gameObject.SetActive(false);
			this.m_cooperateBattleButton.onClick.AddListener(new UnityAction(this.OnCooperateBattleButtonClick));
			base.SetButtonClickListener("m_playerButton", new Action<UIControllerBase>(this.OnPlayerButtonClick));
			base.SetButtonClickListener("m_heroButton", new Action<UIControllerBase>(this.OnHeroButtonClick));
			base.SetButtonClickListener("m_bagButton", new Action<UIControllerBase>(this.OnBagButtonClick));
			base.SetButtonClickListener("m_selectCardButton", new Action<UIControllerBase>(this.OnSelectCardButtonClick));
			base.SetButtonClickListener("m_missionButton", new Action<UIControllerBase>(this.OnMissionButtonClick));
			base.SetButtonClickListener("m_fetterButton", new Action<UIControllerBase>(this.OnFetterButtonClick));
			base.SetButtonClickListener("m_storeButton", new Action<UIControllerBase>(this.OnStoreButtonClick));
			base.SetButtonClickListener("m_drillButton", new Action<UIControllerBase>(this.OnDrillButtonClick));
			base.SetButtonClickListener("m_friendButton", new Action<UIControllerBase>(this.OnFriendButtonClick));
			base.SetButtonClickListener("m_guildButton", new Action<UIControllerBase>(this.OnGuildButtonClick));
			base.SetButtonClickListener("m_eventButton", new Action<UIControllerBase>(this.OnEventButtonClick));
			base.SetButtonClickListener("m_unchartedButton", new Action<UIControllerBase>(this.OnUnchartedButtonClick));
			base.SetButtonClickListener("m_arenaButton", new Action<UIControllerBase>(this.OnArenaButtonClick));
			base.SetButtonClickListener("m_riftButton", new Action<UIControllerBase>(this.OnRiftButtonClick));
			base.SetButtonClickListener("m_testButton", new Action<UIControllerBase>(this.OnTestButtonClick));
			base.SetButtonClickListener("m_mailButton", new Action<UIControllerBase>(this.OnMailButtonClick));
			base.SetButtonClickListener("m_chatButton", new Action<UIControllerBase>(this.OnChatButtonClick));
			base.SetButtonClickListener("m_rankButton", new Action<UIControllerBase>(this.OnRankButtonClick));
			base.SetButtonClickListener("m_activityButton", new Action<UIControllerBase>(this.OnActivityButtonClick));
			base.SetButtonClickListener("m_investigationButton", new Action<UIControllerBase>(this.OnInvestigationButtonClick));
			base.SetButtonClickListener("m_openServiceActivityButton", new Action<UIControllerBase>(this.OnOpenServiceActivityButtonClick));
			base.SetButtonClickListener("m_YYBButton", new Action<UIControllerBase>(this.OnYingYongBaoButtonClick));
			base.SetButtonClickListener("m_OppoButton", new Action<UIControllerBase>(this.OnOppoButtonClick));
			this.m_YYBButton.gameObject.SetActive(UIUtility.IsYYBChannel());
			this.m_OppoButton.gameObject.SetActive(UIUtility.IsOppoChannel());
			this.m_eventListUIStateController.gameObject.SetActive(false);
			this.m_eventListBackgroundButton.onClick.AddListener(new UnityAction(this.OnEventListBackgroundButtonClick));
			this.m_pastScenarioListUIStateController.gameObject.SetActive(false);
			this.m_pastScenarioListBackgroundButton.onClick.AddListener(new UnityAction(this.OnPastScenarioListBackgroundButtonClick));
			this.m_monthCardButton.onClick.AddListener(new UnityAction(this.OnMonthCardButtonClick));
			this.m_monthCardCloseButton.onClick.AddListener(new UnityAction(this.OnMonthCardCloseButtonClick));
			this.UpdateGameFunctionOpen();
			this.UpdateDeveloperMode();
			this.m_fogImage.gameObject.SetActive(false);
			this.m_fogColor = this.m_fogImage.color;
			this.m_userGuideDialogHideGameObjects.Add(this.m_compassButton.gameObject);
			this.m_userGuideDialogHideGameObjects.Add(this.m_mainButton.gameObject);
			this.m_userGuideDialogHideGameObjects.Add(this.m_mainButtonBarUIStateController.gameObject);
			this.m_userGuideDialogHideGameObjects.Add(this.m_leftGameObject);
			this.m_userGuideDialogHideGameObjects.Add(this.m_rightGameObject);
			this.m_prefabsGameObject.SetActive(false);
			UIUtility.MarginAdjustHorizontal(this.m_eventListTransform);
			UIUtility.MarginAdjustHorizontal(this.m_marginTransform);
			UIUtility.MarginAdjustVertical(this.m_margin1Transform);
		}

		// Token: 0x06014FA4 RID: 85924 RVA: 0x0054E8D0 File Offset: 0x0054CAD0
		private void OnEnable()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEnable_hotfix != null)
			{
				this.m_OnEnable_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_developerClickCount = 0;
		}

		// Token: 0x06014FA5 RID: 85925 RVA: 0x0054E938 File Offset: 0x0054CB38
		private void UpdateDeveloperMode()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateDeveloperMode_hotfix != null)
			{
				this.m_UpdateDeveloperMode_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LocalConfigData data = LocalConfig.Instance.Data;
			this.m_testButton.gameObject.SetActive(data.IsDeveloper);
		}

		// Token: 0x06014FA6 RID: 85926 RVA: 0x0054E9BC File Offset: 0x0054CBBC
		public void ShowOrHide(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowOrHideBoolean_hotfix != null)
			{
				this.m_ShowOrHideBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_uiStateController.SetToUIState((!isShow) ? "Close" : "Show", false, true);
		}

		// Token: 0x06014FA7 RID: 85927 RVA: 0x0054EA50 File Offset: 0x0054CC50
		public void UpdateGameFunctionOpen()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateGameFunctionOpen_hotfix != null)
			{
				this.m_UpdateGameFunctionOpen_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LocalConfigData data = LocalConfig.Instance.Data;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			this.m_riftButton.gameObject.SetActive(projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_Rift) || data.IsDeveloper);
			this.m_arenaButton.gameObject.SetActive(projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_ArenaBattle) || data.IsDeveloper);
			this.m_eventButton.gameObject.SetActive(projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_RandomEvent) || data.IsDeveloper);
			this.m_unchartedButton.gameObject.SetActive(projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_AnikiGym) || data.IsDeveloper);
		}

		// Token: 0x06014FA8 RID: 85928 RVA: 0x0054EB64 File Offset: 0x0054CD64
		public void SetPlayerName(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPlayerNameString_hotfix != null)
			{
				this.m_SetPlayerNameString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerNameText.text = name;
		}

		// Token: 0x06014FA9 RID: 85929 RVA: 0x0054EBE0 File Offset: 0x0054CDE0
		public void SetPlayerLevel(int level)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPlayerLevelInt32_hotfix != null)
			{
				this.m_SetPlayerLevelInt32_hotfix.call(new object[]
				{
					this,
					level
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerLevelText.text = level.ToString();
		}

		// Token: 0x06014FAA RID: 85930 RVA: 0x0054EC68 File Offset: 0x0054CE68
		public void SetPlayerVip(int vip)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPlayerVipInt32_hotfix != null)
			{
				this.m_SetPlayerVipInt32_hotfix.call(new object[]
				{
					this,
					vip
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerVipText.text = vip.ToString();
		}

		// Token: 0x06014FAB RID: 85931 RVA: 0x0054ECF0 File Offset: 0x0054CEF0
		public void SetPlayerExp(int exp, int expMax)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPlayerExpInt32Int32_hotfix != null)
			{
				this.m_SetPlayerExpInt32Int32_hotfix.call(new object[]
				{
					this,
					exp,
					expMax
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerExpText.text = exp + "/" + expMax;
			if (exp > 0 && expMax > 0)
			{
				this.m_playerExpImage.fillAmount = (float)exp / (float)expMax;
			}
			else
			{
				this.m_playerExpImage.fillAmount = 0f;
			}
		}

		// Token: 0x06014FAC RID: 85932 RVA: 0x0054EDC4 File Offset: 0x0054CFC4
		public void SetPlayerHeadIcon(int playerHeadIconId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPlayerHeadIconInt32_hotfix != null)
			{
				this.m_SetPlayerHeadIconInt32_hotfix.call(new object[]
				{
					this,
					playerHeadIconId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerIconImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerHeadIconImageName(HeadIconTools.GetHeadPortrait(playerHeadIconId)));
		}

		// Token: 0x06014FAD RID: 85933 RVA: 0x0054EE54 File Offset: 0x0054D054
		public void ShowMainButtonBar(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowMainButtonBarBoolean_hotfix != null)
			{
				this.m_ShowMainButtonBarBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (show)
			{
				this.m_mainButtonOnGameObject.SetActive(true);
				this.m_mainButtonOffGameObject.SetActive(false);
				this.m_mainButtonBarUIStateController.SetToUIState("First", false, true);
			}
			else
			{
				this.m_mainButtonOnGameObject.SetActive(false);
				this.m_mainButtonOffGameObject.SetActive(true);
				this.m_mainButtonBarUIStateController.SetToUIState("Hide", false, true);
			}
		}

		// Token: 0x06014FAE RID: 85934 RVA: 0x0054EF24 File Offset: 0x0054D124
		public void SetCurrentScenario(ConfigDataScenarioInfo scenarioInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCurrentScenarioConfigDataScenarioInfo_hotfix != null)
			{
				this.m_SetCurrentScenarioConfigDataScenarioInfo_hotfix.call(new object[]
				{
					this,
					scenarioInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (scenarioInfo != null)
			{
				this.m_currentScenarioButton.gameObject.SetActive(true);
				this.m_currentScenarioNameText.text = scenarioInfo.Chapter + " " + scenarioInfo.Name;
			}
			else
			{
				this.m_currentScenarioButton.gameObject.SetActive(false);
			}
		}

		// Token: 0x06014FAF RID: 85935 RVA: 0x0054EFE4 File Offset: 0x0054D1E4
		public void ShowNewScenario(ConfigDataScenarioInfo scenarioInfo, Action onEnd = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowNewScenarioConfigDataScenarioInfoAction_hotfix != null)
			{
				this.m_ShowNewScenarioConfigDataScenarioInfoAction_hotfix.call(new object[]
				{
					this,
					scenarioInfo,
					onEnd2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action onEnd = onEnd2;
			WorldUIController $this = this;
			if (scenarioInfo == null)
			{
				return;
			}
			this.m_newScenarioNameText.text = scenarioInfo.Chapter + " : " + scenarioInfo.Name;
			UIUtility.SetUIStateOpen(this.m_newScenarioUIStateController, "Open", delegate
			{
				$this.m_newScenarioUIStateController.gameObject.SetActive(false);
				if (onEnd != null)
				{
					onEnd();
				}
			}, false, true);
		}

		// Token: 0x06014FB0 RID: 85936 RVA: 0x0054F0C0 File Offset: 0x0054D2C0
		public void ShowUnlockScenario(ConfigDataScenarioInfo scenarioInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowUnlockScenarioConfigDataScenarioInfo_hotfix != null)
			{
				this.m_ShowUnlockScenarioConfigDataScenarioInfo_hotfix.call(new object[]
				{
					this,
					scenarioInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (scenarioInfo == null)
			{
				return;
			}
			UIUtility.SetUIStateOpen(this.m_unlockScenarioUIStateController, "Open", null, false, true);
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			string text = string.Empty;
			bool active = false;
			foreach (ScenarioInfoUnlockCondition scenarioInfoUnlockCondition in scenarioInfo.UnlockCondition)
			{
				if (scenarioInfoUnlockCondition.ConditionType == ScenarioUnlockConditionType.ScenarioUnlockConditionType_PlayerLevel)
				{
					if (!string.IsNullOrEmpty(text))
					{
						text += "\n";
					}
					text += string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_UnlockScenario_PlayerLevel), scenarioInfoUnlockCondition.Param);
				}
				else if (scenarioInfoUnlockCondition.ConditionType == ScenarioUnlockConditionType.ScenarioUnlockConditionType_RiftLevel)
				{
					ConfigDataRiftLevelInfo configDataRiftLevelInfo = configDataLoader.GetConfigDataRiftLevelInfo(scenarioInfoUnlockCondition.Param);
					if (configDataRiftLevelInfo != null)
					{
						if (!string.IsNullOrEmpty(text))
						{
							text += "\n";
						}
						text += string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_UnlockScenario_RiftLevel), configDataRiftLevelInfo.NameNum);
						active = true;
						this.m_gotoRiftLevelInfo = configDataRiftLevelInfo;
					}
				}
			}
			this.m_unlockScenarioTitleText.text = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_UnlockScenario_Title), scenarioInfo.Chapter);
			this.m_unlockScenarioText.text = text;
			this.m_unlockScenarioGotoButton.gameObject.SetActive(active);
		}

		// Token: 0x06014FB1 RID: 85937 RVA: 0x0054F294 File Offset: 0x0054D494
		public void ShowEnterScenario(ConfigDataScenarioInfo scenarioInfo, Action onEnd = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowEnterScenarioConfigDataScenarioInfoAction_hotfix != null)
			{
				this.m_ShowEnterScenarioConfigDataScenarioInfoAction_hotfix.call(new object[]
				{
					this,
					scenarioInfo,
					onEnd2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action onEnd = onEnd2;
			WorldUIController $this = this;
			if (scenarioInfo == null)
			{
				return;
			}
			this.m_enterScenarioChapterText.text = scenarioInfo.Chapter;
			this.m_enterScenarioNameText.text = scenarioInfo.Name;
			UIUtility.SetUIStateOpen(this.m_enterScenarioUIStateController, "Open", delegate
			{
				$this.m_enterScenarioUIStateController.gameObject.SetActive(false);
				if (onEnd != null)
				{
					onEnd();
				}
			}, false, true);
		}

		// Token: 0x06014FB2 RID: 85938 RVA: 0x0054F370 File Offset: 0x0054D570
		public void ShowEnterMonster(ConfigDataBattleInfo battleInfo, Action onEnd = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowEnterMonsterConfigDataBattleInfoAction_hotfix != null)
			{
				this.m_ShowEnterMonsterConfigDataBattleInfoAction_hotfix.call(new object[]
				{
					this,
					battleInfo,
					onEnd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (battleInfo == null)
			{
				return;
			}
			base.StartCoroutine(this.Co_EnterMonster(onEnd));
		}

		// Token: 0x06014FB3 RID: 85939 RVA: 0x0054F408 File Offset: 0x0054D608
		[DebuggerHidden]
		private IEnumerator Co_EnterMonster(Action onEnd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_EnterMonsterAction_hotfix != null)
			{
				return (IEnumerator)this.m_Co_EnterMonsterAction_hotfix.call(new object[]
				{
					this,
					onEnd
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			WorldUIController.<Co_EnterMonster>c__Iterator0 <Co_EnterMonster>c__Iterator = new WorldUIController.<Co_EnterMonster>c__Iterator0();
			<Co_EnterMonster>c__Iterator.onEnd = onEnd;
			<Co_EnterMonster>c__Iterator.$this = this;
			return <Co_EnterMonster>c__Iterator;
		}

		// Token: 0x06014FB4 RID: 85940 RVA: 0x0054F49C File Offset: 0x0054D69C
		public void SetFog(float fog)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetFogSingle_hotfix != null)
			{
				this.m_SetFogSingle_hotfix.call(new object[]
				{
					this,
					fog
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_fogImage.color = new Color(this.m_fogColor.r, this.m_fogColor.g, this.m_fogColor.b, Mathf.Lerp(0f, this.m_fogColor.a, fog));
			this.m_fogImage.gameObject.SetActive(fog > 0.01f);
		}

		// Token: 0x06014FB5 RID: 85941 RVA: 0x0054F56C File Offset: 0x0054D76C
		public void AddRandomEvent(ConfigDataWaypointInfo waypointInfo, RandomEvent randomEvent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddRandomEventConfigDataWaypointInfoRandomEvent_hotfix != null)
			{
				this.m_AddRandomEventConfigDataWaypointInfoRandomEvent_hotfix.call(new object[]
				{
					this,
					waypointInfo,
					randomEvent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataEventInfo configDataEventInfo = configDataLoader.GetConfigDataEventInfo(randomEvent.EventId);
			if (configDataEventInfo == null)
			{
				return;
			}
			GameObject go = UnityEngine.Object.Instantiate<GameObject>(this.m_randomEventListItemPrefab, this.m_randomEventScrollRect.content, false);
			WorldEventListItemUIController worldEventListItemUIController = GameObjectUtility.AddControllerToGameObject<WorldEventListItemUIController>(go);
			worldEventListItemUIController.EventOnClick += this.WorldEventListItem_OnButtonClick;
			worldEventListItemUIController.SetEventInfo(waypointInfo, configDataEventInfo);
			worldEventListItemUIController.SetExpireTime(randomEvent.ExpiredTime);
			this.m_randomEventListItems.Add(worldEventListItemUIController);
		}

		// Token: 0x06014FB6 RID: 85942 RVA: 0x0054F664 File Offset: 0x0054D864
		public void ClearRandomEventList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearRandomEventList_hotfix != null)
			{
				this.m_ClearRandomEventList_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyComponentList<WorldEventListItemUIController>(this.m_randomEventListItems);
			this.m_randomEventListItems.Clear();
		}

		// Token: 0x06014FB7 RID: 85943 RVA: 0x0054F6DC File Offset: 0x0054D8DC
		public void ShowEventList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowEventList_hotfix != null)
			{
				this.m_ShowEventList_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_eventListUIStateController, "Show", null, false, true);
		}

		// Token: 0x06014FB8 RID: 85944 RVA: 0x0054F750 File Offset: 0x0054D950
		public void HideEventList(Action onEnd = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideEventListAction_hotfix != null)
			{
				this.m_HideEventListAction_hotfix.call(new object[]
				{
					this,
					onEnd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_eventListUIStateController, "Close", onEnd, false, true);
		}

		// Token: 0x06014FB9 RID: 85945 RVA: 0x0054F7D4 File Offset: 0x0054D9D4
		public bool IsEventListVisible()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsEventListVisible_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsEventListVisible_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_eventListUIStateController.gameObject.activeSelf;
		}

		// Token: 0x06014FBA RID: 85946 RVA: 0x0054F850 File Offset: 0x0054DA50
		public void AddPastScenario(ConfigDataScenarioInfo scenarioInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddPastScenarioConfigDataScenarioInfo_hotfix != null)
			{
				this.m_AddPastScenarioConfigDataScenarioInfo_hotfix.call(new object[]
				{
					this,
					scenarioInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject go = UnityEngine.Object.Instantiate<GameObject>(this.m_pastScenarioListItemPrefab, this.m_pastScenarioListScrollRect.content, false);
			PastScenarioListItemUIController pastScenarioListItemUIController = GameObjectUtility.AddControllerToGameObject<PastScenarioListItemUIController>(go);
			pastScenarioListItemUIController.EventOnStart += this.PastScenarioListItem_OnStartButtonClick;
			pastScenarioListItemUIController.SetScenarioInfo(scenarioInfo);
			this.m_pastScenarioListItems.Add(pastScenarioListItemUIController);
		}

		// Token: 0x06014FBB RID: 85947 RVA: 0x0054F904 File Offset: 0x0054DB04
		public void ClearPastScenarioList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearPastScenarioList_hotfix != null)
			{
				this.m_ClearPastScenarioList_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyComponentList<PastScenarioListItemUIController>(this.m_pastScenarioListItems);
			this.m_pastScenarioListItems.Clear();
		}

		// Token: 0x06014FBC RID: 85948 RVA: 0x0054F97C File Offset: 0x0054DB7C
		public void ShowPastScenarioList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowPastScenarioList_hotfix != null)
			{
				this.m_ShowPastScenarioList_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_pastScenarioListUIStateController, "Open", null, false, true);
		}

		// Token: 0x06014FBD RID: 85949 RVA: 0x0054F9F0 File Offset: 0x0054DBF0
		public void HidePastScenarioList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HidePastScenarioList_hotfix != null)
			{
				this.m_HidePastScenarioList_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_pastScenarioListUIStateController.gameObject.SetActive(false);
		}

		// Token: 0x06014FBE RID: 85950 RVA: 0x0054FA64 File Offset: 0x0054DC64
		public void ShowCooperateBattleButton(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowCooperateBattleButtonBoolean_hotfix != null)
			{
				this.m_ShowCooperateBattleButtonBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_cooperateBattleButton.gameObject.SetActive(show);
		}

		// Token: 0x06014FBF RID: 85951 RVA: 0x0054FAE8 File Offset: 0x0054DCE8
		public void ShowHeroRedMark(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowHeroRedMarkBoolean_hotfix != null)
			{
				this.m_ShowHeroRedMarkBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroButtonRedMarkGameObject.SetActive(show);
		}

		// Token: 0x06014FC0 RID: 85952 RVA: 0x0054FB64 File Offset: 0x0054DD64
		public void ShowDrillRedMark(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowDrillRedMarkBoolean_hotfix != null)
			{
				this.m_ShowDrillRedMarkBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_drillButtonRedMark.SetActive(show);
		}

		// Token: 0x06014FC1 RID: 85953 RVA: 0x0054FBE0 File Offset: 0x0054DDE0
		public void ShowFetterRedMark(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowFetterRedMarkBoolean_hotfix != null)
			{
				this.m_ShowFetterRedMarkBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_fetterButtonRedMarkGameObject.SetActive(show);
		}

		// Token: 0x06014FC2 RID: 85954 RVA: 0x0054FC5C File Offset: 0x0054DE5C
		public void ShowGuildRedMark(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowGuildRedMarkBoolean_hotfix != null)
			{
				this.m_ShowGuildRedMarkBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_sociatyButtonRedMark.SetActive(show);
		}

		// Token: 0x06014FC3 RID: 85955 RVA: 0x0054FCD8 File Offset: 0x0054DED8
		public void ShowEventRedMark(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowEventRedMarkBoolean_hotfix != null)
			{
				this.m_ShowEventRedMarkBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_eventButtonRedMarkGameObject.SetActive(show);
		}

		// Token: 0x06014FC4 RID: 85956 RVA: 0x0054FD54 File Offset: 0x0054DF54
		public void ShowMissionRedMark(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowMissionRedMarkBoolean_hotfix != null)
			{
				this.m_ShowMissionRedMarkBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_missionButtonRedMarkGameObject.SetActive(show);
		}

		// Token: 0x06014FC5 RID: 85957 RVA: 0x0054FDD0 File Offset: 0x0054DFD0
		public void ShowActivityRedMark(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowActivityRedMarkBoolean_hotfix != null)
			{
				this.m_ShowActivityRedMarkBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_activityRedMarkGameObject.SetActive(show);
		}

		// Token: 0x06014FC6 RID: 85958 RVA: 0x0054FE4C File Offset: 0x0054E04C
		public void ShowFriendRedMark(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowFriendRedMarkBoolean_hotfix != null)
			{
				this.m_ShowFriendRedMarkBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_friendButtonRedMark.SetActive(show);
		}

		// Token: 0x06014FC7 RID: 85959 RVA: 0x0054FEC8 File Offset: 0x0054E0C8
		public void UpdateNewChatCount(int newCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateNewChatCountInt32_hotfix != null)
			{
				this.m_UpdateNewChatCountInt32_hotfix.call(new object[]
				{
					this,
					newCount
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_newChatCountText.transform.parent.gameObject.SetActive(newCount > 0);
			string text = string.Empty;
			if (newCount > 99)
			{
				text = "99+";
			}
			else
			{
				text = newCount.ToString();
			}
			this.m_newChatCountText.text = text;
		}

		// Token: 0x06014FC8 RID: 85960 RVA: 0x0054FF8C File Offset: 0x0054E18C
		public void UpdateUnreadMailCount(int newCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateUnreadMailCountInt32_hotfix != null)
			{
				this.m_UpdateUnreadMailCountInt32_hotfix.call(new object[]
				{
					this,
					newCount
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_unreadMailCountText.transform.parent.gameObject.SetActive(newCount > 0);
			string text = string.Empty;
			if (newCount > 99)
			{
				text = "99+";
			}
			else
			{
				text = newCount.ToString();
			}
			this.m_unreadMailCountText.text = text;
		}

		// Token: 0x06014FC9 RID: 85961 RVA: 0x00550050 File Offset: 0x0054E250
		public List<GameObject> GetUserGuideDialogHideGameObjects()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetUserGuideDialogHideGameObjects_hotfix != null)
			{
				return (List<GameObject>)this.m_GetUserGuideDialogHideGameObjects_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_userGuideDialogHideGameObjects;
		}

		// Token: 0x06014FCA RID: 85962 RVA: 0x005500C4 File Offset: 0x0054E2C4
		public void UpdateMonthCardOpen(bool isOpen)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateMonthCardOpenBoolean_hotfix != null)
			{
				this.m_UpdateMonthCardOpenBoolean_hotfix.call(new object[]
				{
					this,
					isOpen
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_monthCardButton.gameObject.SetActive(isOpen);
			bool obj = false;
			UIStateDesc currentUIState = this.m_monthCardPanelUIStateController.GetCurrentUIState();
			if (currentUIState != null)
			{
				obj = (currentUIState.StateName == "Show");
			}
			if (this.EventOnRefreshMonthCardPanel != null)
			{
				this.EventOnRefreshMonthCardPanel(obj);
			}
		}

		// Token: 0x06014FCB RID: 85963 RVA: 0x00550184 File Offset: 0x0054E384
		public void OpenMonthCardPanel(List<MonthCard> cardList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OpenMonthCardPanelList`1_hotfix != null)
			{
				this.m_OpenMonthCardPanelList`1_hotfix.call(new object[]
				{
					this,
					cardList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyChildren(this.m_monthCardItemGroupObj);
			foreach (MonthCard monthCard in cardList)
			{
				GameObject go = GameObjectUtility.CloneGameObject(this.m_monthCardItemPrefab, this.m_monthCardItemGroupObj.transform);
				WorldMonthCardItemUIController worldMonthCardItemUIController = GameObjectUtility.AddControllerToGameObject<WorldMonthCardItemUIController>(go);
				ConfigDataMonthCardInfo configDataMonthCardInfo = this.m_configDataLoader.GetConfigDataMonthCardInfo(monthCard.CardId);
				if (configDataMonthCardInfo != null)
				{
					worldMonthCardItemUIController.UpdateItemInfo(monthCard.CardId, configDataMonthCardInfo.Icon, configDataMonthCardInfo.Name);
					ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
					worldMonthCardItemUIController.UpdateRemainTime(UIUtility.TimeSpanToString2(projectLPlayerContext.GetMonthCardLeftTime(monthCard.CardId)));
					worldMonthCardItemUIController.EventOnItemButtonClick -= this.OnMonthCardItemItemClick;
					worldMonthCardItemUIController.EventOnItemBuyButtonClick -= this.OnMonthCardBuyClick;
					worldMonthCardItemUIController.EventOnItemButtonClick += this.OnMonthCardItemItemClick;
					worldMonthCardItemUIController.EventOnItemBuyButtonClick += this.OnMonthCardBuyClick;
				}
			}
			UIStateDesc currentUIState = this.m_monthCardPanelUIStateController.GetCurrentUIState();
			if (currentUIState == null || currentUIState.StateName != "Show")
			{
				this.m_monthCardPanelUIStateController.gameObject.SetActive(true);
				this.m_monthCardPanelUIStateController.SetToUIState("Show", false, true);
			}
		}

		// Token: 0x06014FCC RID: 85964 RVA: 0x00550358 File Offset: 0x0054E558
		public void CloseMonthCardPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseMonthCardPanel_hotfix != null)
			{
				this.m_CloseMonthCardPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIStateDesc currentUIState = this.m_monthCardPanelUIStateController.GetCurrentUIState();
			if (currentUIState == null || currentUIState.StateName != "Close")
			{
				this.m_monthCardPanelUIStateController.SetActionForUIStateFinshed("Close", delegate
				{
					this.m_monthCardPanelUIStateController.gameObject.SetActive(false);
				});
				this.m_monthCardPanelUIStateController.SetToUIState("Close", false, true);
			}
		}

		// Token: 0x06014FCD RID: 85965 RVA: 0x00550410 File Offset: 0x0054E610
		private void DeveloperModeClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeveloperModeClick_hotfix != null)
			{
				this.m_DeveloperModeClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (LoginUITask.IsGMUser)
			{
				this.m_developerClickCount++;
				if (this.m_developerClickCount % 10 == 0)
				{
					LocalConfigData data = LocalConfig.Instance.Data;
					data.IsDeveloper = !data.IsDeveloper;
					this.UpdateGameFunctionOpen();
					this.UpdateDeveloperMode();
					LocalConfig.Instance.Save();
				}
			}
		}

		// Token: 0x06014FCE RID: 85966 RVA: 0x005504C8 File Offset: 0x0054E6C8
		private void OnCompassButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCompassButtonClick_hotfix != null)
			{
				this.m_OnCompassButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DeveloperModeClick();
			if (this.EventOnCompass != null)
			{
				this.EventOnCompass();
			}
		}

		// Token: 0x06014FCF RID: 85967 RVA: 0x00550544 File Offset: 0x0054E744
		private void OnCurrentScenarioButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCurrentScenarioButtonClick_hotfix != null)
			{
				this.m_OnCurrentScenarioButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DeveloperModeClick();
			if (this.EventOnCurrentScenario != null)
			{
				this.EventOnCurrentScenario();
			}
		}

		// Token: 0x06014FD0 RID: 85968 RVA: 0x005505C0 File Offset: 0x0054E7C0
		private void OnUnlockScenarioBackgroundButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnUnlockScenarioBackgroundButtonClick_hotfix != null)
			{
				this.m_OnUnlockScenarioBackgroundButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_unlockScenarioUIStateController, "Close", null, true, true);
		}

		// Token: 0x06014FD1 RID: 85969 RVA: 0x00550634 File Offset: 0x0054E834
		private void OnUnlockScenarioGotoButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnUnlockScenarioGotoButtonClick_hotfix != null)
			{
				this.m_OnUnlockScenarioGotoButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_gotoRiftLevelInfo == null)
			{
				return;
			}
			UIUtility.SetUIStateClose(this.m_unlockScenarioUIStateController, "Close", delegate
			{
				if (this.EventOnUnlockScenarioGotoRiftLevel != null)
				{
					this.EventOnUnlockScenarioGotoRiftLevel(this.m_gotoRiftLevelInfo);
				}
			}, true, true);
		}

		// Token: 0x06014FD2 RID: 85970 RVA: 0x005506C0 File Offset: 0x0054E8C0
		private void OnMainButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMainButtonClick_hotfix != null)
			{
				this.m_OnMainButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_mainButtonOnGameObject.activeSelf)
			{
				this.m_mainButtonOnGameObject.SetActive(false);
				this.m_mainButtonOffGameObject.SetActive(true);
				this.m_mainButtonBarUIStateController.SetToUIState("Out", false, true);
			}
			else
			{
				this.m_mainButtonOnGameObject.SetActive(true);
				this.m_mainButtonOffGameObject.SetActive(false);
				this.m_mainButtonBarUIStateController.SetToUIState("In", false, true);
			}
			if (this.EventOnShowMainButtonBar != null)
			{
				this.EventOnShowMainButtonBar(this.m_mainButtonOnGameObject.activeSelf);
			}
		}

		// Token: 0x06014FD3 RID: 85971 RVA: 0x005507AC File Offset: 0x0054E9AC
		private void OnPlayerButtonClick(UIControllerBase ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPlayerButtonClickUIControllerBase_hotfix != null)
			{
				this.m_OnPlayerButtonClickUIControllerBase_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowPlayerInfo != null)
			{
				this.EventOnShowPlayerInfo();
			}
		}

		// Token: 0x06014FD4 RID: 85972 RVA: 0x00550834 File Offset: 0x0054EA34
		private void OnHeroButtonClick(UIControllerBase ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeroButtonClickUIControllerBase_hotfix != null)
			{
				this.m_OnHeroButtonClickUIControllerBase_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowHero != null)
			{
				this.EventOnShowHero();
			}
		}

		// Token: 0x06014FD5 RID: 85973 RVA: 0x005508BC File Offset: 0x0054EABC
		private void OnBagButtonClick(UIControllerBase ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBagButtonClickUIControllerBase_hotfix != null)
			{
				this.m_OnBagButtonClickUIControllerBase_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowBag != null)
			{
				this.EventOnShowBag();
			}
		}

		// Token: 0x06014FD6 RID: 85974 RVA: 0x00550944 File Offset: 0x0054EB44
		private void OnSelectCardButtonClick(UIControllerBase ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSelectCardButtonClickUIControllerBase_hotfix != null)
			{
				this.m_OnSelectCardButtonClickUIControllerBase_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (!projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_SelectCard))
			{
				CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_SelectCard), 2f, null, true);
			}
			else if (this.EventOnShowSelectCard != null)
			{
				this.EventOnShowSelectCard();
			}
		}

		// Token: 0x06014FD7 RID: 85975 RVA: 0x00550A04 File Offset: 0x0054EC04
		private void OnMissionButtonClick(UIControllerBase ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMissionButtonClickUIControllerBase_hotfix != null)
			{
				this.m_OnMissionButtonClickUIControllerBase_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowMisision != null)
			{
				this.EventOnShowMisision();
			}
		}

		// Token: 0x06014FD8 RID: 85976 RVA: 0x00550A8C File Offset: 0x0054EC8C
		private void OnFetterButtonClick(UIControllerBase ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFetterButtonClickUIControllerBase_hotfix != null)
			{
				this.m_OnFetterButtonClickUIControllerBase_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowFetter != null)
			{
				this.EventOnShowFetter();
			}
		}

		// Token: 0x06014FD9 RID: 85977 RVA: 0x00550B14 File Offset: 0x0054ED14
		private void OnStoreButtonClick(UIControllerBase ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStoreButtonClickUIControllerBase_hotfix != null)
			{
				this.m_OnStoreButtonClickUIControllerBase_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowStore != null)
			{
				this.EventOnShowStore();
			}
		}

		// Token: 0x06014FDA RID: 85978 RVA: 0x00550B9C File Offset: 0x0054ED9C
		private void OnDrillButtonClick(UIControllerBase ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDrillButtonClickUIControllerBase_hotfix != null)
			{
				this.m_OnDrillButtonClickUIControllerBase_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowDrill != null)
			{
				this.EventOnShowDrill();
			}
		}

		// Token: 0x06014FDB RID: 85979 RVA: 0x00550C24 File Offset: 0x0054EE24
		private void OnFriendButtonClick(UIControllerBase ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFriendButtonClickUIControllerBase_hotfix != null)
			{
				this.m_OnFriendButtonClickUIControllerBase_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowFriend != null)
			{
				this.EventOnShowFriend();
			}
		}

		// Token: 0x06014FDC RID: 85980 RVA: 0x00550CAC File Offset: 0x0054EEAC
		private void OnGuildButtonClick(UIControllerBase ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGuildButtonClickUIControllerBase_hotfix != null)
			{
				this.m_OnGuildButtonClickUIControllerBase_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowGuild != null)
			{
				this.EventOnShowGuild();
			}
		}

		// Token: 0x06014FDD RID: 85981 RVA: 0x00550D34 File Offset: 0x0054EF34
		private void OnEventButtonClick(UIControllerBase ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEventButtonClickUIControllerBase_hotfix != null)
			{
				this.m_OnEventButtonClickUIControllerBase_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowEvent != null)
			{
				this.EventOnShowEvent();
			}
		}

		// Token: 0x06014FDE RID: 85982 RVA: 0x00550DBC File Offset: 0x0054EFBC
		private void OnUnchartedButtonClick(UIControllerBase ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnUnchartedButtonClickUIControllerBase_hotfix != null)
			{
				this.m_OnUnchartedButtonClickUIControllerBase_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowUncharted != null)
			{
				this.EventOnShowUncharted();
			}
		}

		// Token: 0x06014FDF RID: 85983 RVA: 0x00550E44 File Offset: 0x0054F044
		private void OnArenaButtonClick(UIControllerBase ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnArenaButtonClickUIControllerBase_hotfix != null)
			{
				this.m_OnArenaButtonClickUIControllerBase_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowArena != null)
			{
				this.EventOnShowArena();
			}
		}

		// Token: 0x06014FE0 RID: 85984 RVA: 0x00550ECC File Offset: 0x0054F0CC
		private void OnRiftButtonClick(UIControllerBase ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRiftButtonClickUIControllerBase_hotfix != null)
			{
				this.m_OnRiftButtonClickUIControllerBase_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowRift != null)
			{
				this.EventOnShowRift();
			}
		}

		// Token: 0x06014FE1 RID: 85985 RVA: 0x00550F54 File Offset: 0x0054F154
		private void OnTestButtonClick(UIControllerBase ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTestButtonClickUIControllerBase_hotfix != null)
			{
				this.m_OnTestButtonClickUIControllerBase_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowTest != null)
			{
				this.EventOnShowTest();
			}
		}

		// Token: 0x06014FE2 RID: 85986 RVA: 0x00550FDC File Offset: 0x0054F1DC
		private void OnCooperateBattleButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCooperateBattleButtonClick_hotfix != null)
			{
				this.m_OnCooperateBattleButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowCooperateBattle != null)
			{
				this.EventOnShowCooperateBattle();
			}
		}

		// Token: 0x06014FE3 RID: 85987 RVA: 0x00551054 File Offset: 0x0054F254
		private void OnMailButtonClick(UIControllerBase ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMailButtonClickUIControllerBase_hotfix != null)
			{
				this.m_OnMailButtonClickUIControllerBase_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowMail != null)
			{
				this.EventOnShowMail();
			}
		}

		// Token: 0x06014FE4 RID: 85988 RVA: 0x005510DC File Offset: 0x0054F2DC
		private void OnChatButtonClick(UIControllerBase ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnChatButtonClickUIControllerBase_hotfix != null)
			{
				this.m_OnChatButtonClickUIControllerBase_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowChat != null)
			{
				this.EventOnShowChat();
			}
		}

		// Token: 0x06014FE5 RID: 85989 RVA: 0x00551164 File Offset: 0x0054F364
		private void OnRankButtonClick(UIControllerBase ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRankButtonClickUIControllerBase_hotfix != null)
			{
				this.m_OnRankButtonClickUIControllerBase_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowRanking != null)
			{
				this.EventOnShowRanking();
			}
		}

		// Token: 0x06014FE6 RID: 85990 RVA: 0x005511EC File Offset: 0x0054F3EC
		private void OnActivityButtonClick(UIControllerBase ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnActivityButtonClickUIControllerBase_hotfix != null)
			{
				this.m_OnActivityButtonClickUIControllerBase_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowAnnouncement != null)
			{
				this.EventOnShowAnnouncement();
			}
		}

		// Token: 0x06014FE7 RID: 85991 RVA: 0x00551274 File Offset: 0x0054F474
		private void OnOpenServiceActivityButtonClick(UIControllerBase ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnOpenServiceActivityButtonClickUIControllerBase_hotfix != null)
			{
				this.m_OnOpenServiceActivityButtonClickUIControllerBase_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			bool flag = projectLPlayerContext.GetNoviceMissionsEndTime() > TimeSpan.Zero;
			if (flag)
			{
				if (this.EventOnShowOpenServiceActivity != null)
				{
					this.EventOnShowOpenServiceActivity();
				}
			}
			else
			{
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				string txt = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_OpenServiceActivityClosed);
				CommonUIController.Instance.ShowMessage(txt, 2f, null, true);
			}
		}

		// Token: 0x06014FE8 RID: 85992 RVA: 0x00551354 File Offset: 0x0054F554
		private void OnOppoButtonClick(UIControllerBase ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnOppoButtonClickUIControllerBase_hotfix != null)
			{
				this.m_OnOppoButtonClickUIControllerBase_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnOppoButtonClick != null)
			{
				this.EventOnOppoButtonClick();
			}
		}

		// Token: 0x06014FE9 RID: 85993 RVA: 0x005513DC File Offset: 0x0054F5DC
		private void OnYingYongBaoButtonClick(UIControllerBase ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnYingYongBaoButtonClickUIControllerBase_hotfix != null)
			{
				this.m_OnYingYongBaoButtonClickUIControllerBase_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnYYBButtonClick != null)
			{
				this.EventOnYYBButtonClick();
			}
		}

		// Token: 0x06014FEA RID: 85994 RVA: 0x00551464 File Offset: 0x0054F664
		private void OnInvestigationButtonClick(UIControllerBase ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnInvestigationButtonClickUIControllerBase_hotfix != null)
			{
				this.m_OnInvestigationButtonClickUIControllerBase_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnOpenWebInvestigation != null)
			{
				this.EventOnOpenWebInvestigation();
			}
		}

		// Token: 0x06014FEB RID: 85995 RVA: 0x005514EC File Offset: 0x0054F6EC
		public void UpdateInvestigationButton()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateInvestigationButton_hotfix != null)
			{
				this.m_UpdateInvestigationButton_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int configableConstId_WriteSurveyPlayerLevel = this.m_configDataLoader.ConfigableConstId_WriteSurveyPlayerLevel;
			SurveyStatus currentSurveyStatus = projectLPlayerContext.GetCurrentSurveyStatus();
			this.m_investigationButton.gameObject.SetActive(projectLPlayerContext.GetPlayerLevel() >= configableConstId_WriteSurveyPlayerLevel && (currentSurveyStatus == SurveyStatus.UnOpen || currentSurveyStatus == SurveyStatus.Open));
			this.m_investigationButtonRedMark.SetActive(currentSurveyStatus == SurveyStatus.UnOpen);
		}

		// Token: 0x06014FEC RID: 85996 RVA: 0x005515AC File Offset: 0x0054F7AC
		public void UpdateOpenServiceActivityButton()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateOpenServiceActivityButton_hotfix != null)
			{
				this.m_UpdateOpenServiceActivityButton_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int playerLevel = projectLPlayerContext.GetPlayerLevel();
			int num = this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_OpenServiceActivityUnlockLevel);
			bool flag = projectLPlayerContext.GetNoviceMissionsEndTime() > TimeSpan.Zero;
			this.m_openServiceActivityButton.gameObject.SetActive(playerLevel >= num && flag);
			if (playerLevel >= num && flag)
			{
				this.m_openServiceActivityButtonRedMark.SetActive(projectLPlayerContext.IsShowRedMarkOnOpenServiceButton());
			}
		}

		// Token: 0x06014FED RID: 85997 RVA: 0x00551680 File Offset: 0x0054F880
		private void WorldEventListItem_OnButtonClick(WorldEventListItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldEventListItem_OnButtonClickWorldEventListItemUIController_hotfix != null)
			{
				this.m_WorldEventListItem_OnButtonClickWorldEventListItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnGotoEvent != null)
			{
				this.EventOnGotoEvent(ctrl.GetWaypointInfo(), ctrl.GetEventInfo());
			}
		}

		// Token: 0x06014FEE RID: 85998 RVA: 0x00551714 File Offset: 0x0054F914
		private void OnEventListBackgroundButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEventListBackgroundButtonClick_hotfix != null)
			{
				this.m_OnEventListBackgroundButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideEventList(null);
		}

		// Token: 0x06014FEF RID: 85999 RVA: 0x0055177C File Offset: 0x0054F97C
		private void OnPastScenarioListBackgroundButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPastScenarioListBackgroundButtonClick_hotfix != null)
			{
				this.m_OnPastScenarioListBackgroundButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_pastScenarioListUIStateController, "Close", delegate
			{
				if (this.EventOnClosePastScenarioList != null)
				{
					this.EventOnClosePastScenarioList();
				}
			}, false, true);
		}

		// Token: 0x06014FF0 RID: 86000 RVA: 0x005517FC File Offset: 0x0054F9FC
		private void PastScenarioListItem_OnStartButtonClick(PastScenarioListItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PastScenarioListItem_OnStartButtonClickPastScenarioListItemUIController_hotfix != null)
			{
				this.m_PastScenarioListItem_OnStartButtonClickPastScenarioListItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnStartPastScenario != null)
			{
				this.EventOnStartPastScenario(ctrl.GetScenarioInfo());
			}
		}

		// Token: 0x06014FF1 RID: 86001 RVA: 0x00551888 File Offset: 0x0054FA88
		private void OnMonthCardButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMonthCardButtonClick_hotfix != null)
			{
				this.m_OnMonthCardButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnMonthCardButtonClick != null)
			{
				this.EventOnMonthCardButtonClick();
			}
		}

		// Token: 0x06014FF2 RID: 86002 RVA: 0x00551900 File Offset: 0x0054FB00
		private void OnMonthCardCloseButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMonthCardCloseButtonClick_hotfix != null)
			{
				this.m_OnMonthCardCloseButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.CloseMonthCardPanel();
		}

		// Token: 0x06014FF3 RID: 86003 RVA: 0x00551968 File Offset: 0x0054FB68
		private void OnMonthCardItemItemClick(int cardId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMonthCardItemItemClickInt32_hotfix != null)
			{
				this.m_OnMonthCardItemItemClickInt32_hotfix.call(new object[]
				{
					this,
					cardId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnMonthCardItemClick != null)
			{
				this.EventOnMonthCardItemClick(cardId);
			}
		}

		// Token: 0x06014FF4 RID: 86004 RVA: 0x005519F0 File Offset: 0x0054FBF0
		private void OnMonthCardBuyClick(int cardId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMonthCardBuyClickInt32_hotfix != null)
			{
				this.m_OnMonthCardBuyClickInt32_hotfix.call(new object[]
				{
					this,
					cardId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.CloseMonthCardPanel();
			if (this.EventOnMonthCardItemBuyClick != null)
			{
				this.EventOnMonthCardItemBuyClick(cardId);
			}
		}

		// Token: 0x140004A5 RID: 1189
		// (add) Token: 0x06014FF5 RID: 86005 RVA: 0x00551A80 File Offset: 0x0054FC80
		// (remove) Token: 0x06014FF6 RID: 86006 RVA: 0x00551B1C File Offset: 0x0054FD1C
		public event Action EventOnShowPlayerInfo
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowPlayerInfoAction_hotfix != null)
				{
					this.m_add_EventOnShowPlayerInfoAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowPlayerInfo;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowPlayerInfo, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowPlayerInfoAction_hotfix != null)
				{
					this.m_remove_EventOnShowPlayerInfoAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowPlayerInfo;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowPlayerInfo, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004A6 RID: 1190
		// (add) Token: 0x06014FF7 RID: 86007 RVA: 0x00551BB8 File Offset: 0x0054FDB8
		// (remove) Token: 0x06014FF8 RID: 86008 RVA: 0x00551C54 File Offset: 0x0054FE54
		public event Action EventOnCompass
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCompassAction_hotfix != null)
				{
					this.m_add_EventOnCompassAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCompass;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCompass, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCompassAction_hotfix != null)
				{
					this.m_remove_EventOnCompassAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCompass;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCompass, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004A7 RID: 1191
		// (add) Token: 0x06014FF9 RID: 86009 RVA: 0x00551CF0 File Offset: 0x0054FEF0
		// (remove) Token: 0x06014FFA RID: 86010 RVA: 0x00551D8C File Offset: 0x0054FF8C
		public event Action EventOnCurrentScenario
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCurrentScenarioAction_hotfix != null)
				{
					this.m_add_EventOnCurrentScenarioAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCurrentScenario;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCurrentScenario, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCurrentScenarioAction_hotfix != null)
				{
					this.m_remove_EventOnCurrentScenarioAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCurrentScenario;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCurrentScenario, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004A8 RID: 1192
		// (add) Token: 0x06014FFB RID: 86011 RVA: 0x00551E28 File Offset: 0x00550028
		// (remove) Token: 0x06014FFC RID: 86012 RVA: 0x00551EC4 File Offset: 0x005500C4
		public event Action<bool> EventOnShowMainButtonBar
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowMainButtonBarAction`1_hotfix != null)
				{
					this.m_add_EventOnShowMainButtonBarAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnShowMainButtonBar;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnShowMainButtonBar, (Action<bool>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowMainButtonBarAction`1_hotfix != null)
				{
					this.m_remove_EventOnShowMainButtonBarAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnShowMainButtonBar;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnShowMainButtonBar, (Action<bool>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004A9 RID: 1193
		// (add) Token: 0x06014FFD RID: 86013 RVA: 0x00551F60 File Offset: 0x00550160
		// (remove) Token: 0x06014FFE RID: 86014 RVA: 0x00551FFC File Offset: 0x005501FC
		public event Action<ConfigDataRiftLevelInfo> EventOnUnlockScenarioGotoRiftLevel
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnUnlockScenarioGotoRiftLevelAction`1_hotfix != null)
				{
					this.m_add_EventOnUnlockScenarioGotoRiftLevelAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataRiftLevelInfo> action = this.EventOnUnlockScenarioGotoRiftLevel;
				Action<ConfigDataRiftLevelInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataRiftLevelInfo>>(ref this.EventOnUnlockScenarioGotoRiftLevel, (Action<ConfigDataRiftLevelInfo>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnUnlockScenarioGotoRiftLevelAction`1_hotfix != null)
				{
					this.m_remove_EventOnUnlockScenarioGotoRiftLevelAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataRiftLevelInfo> action = this.EventOnUnlockScenarioGotoRiftLevel;
				Action<ConfigDataRiftLevelInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataRiftLevelInfo>>(ref this.EventOnUnlockScenarioGotoRiftLevel, (Action<ConfigDataRiftLevelInfo>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004AA RID: 1194
		// (add) Token: 0x06014FFF RID: 86015 RVA: 0x00552098 File Offset: 0x00550298
		// (remove) Token: 0x06015000 RID: 86016 RVA: 0x00552134 File Offset: 0x00550334
		public event Action<ConfigDataWaypointInfo, ConfigDataEventInfo> EventOnGotoEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGotoEventAction`2_hotfix != null)
				{
					this.m_add_EventOnGotoEventAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataWaypointInfo, ConfigDataEventInfo> action = this.EventOnGotoEvent;
				Action<ConfigDataWaypointInfo, ConfigDataEventInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataWaypointInfo, ConfigDataEventInfo>>(ref this.EventOnGotoEvent, (Action<ConfigDataWaypointInfo, ConfigDataEventInfo>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGotoEventAction`2_hotfix != null)
				{
					this.m_remove_EventOnGotoEventAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataWaypointInfo, ConfigDataEventInfo> action = this.EventOnGotoEvent;
				Action<ConfigDataWaypointInfo, ConfigDataEventInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataWaypointInfo, ConfigDataEventInfo>>(ref this.EventOnGotoEvent, (Action<ConfigDataWaypointInfo, ConfigDataEventInfo>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004AB RID: 1195
		// (add) Token: 0x06015001 RID: 86017 RVA: 0x005521D0 File Offset: 0x005503D0
		// (remove) Token: 0x06015002 RID: 86018 RVA: 0x0055226C File Offset: 0x0055046C
		public event Action<ConfigDataScenarioInfo> EventOnStartPastScenario
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnStartPastScenarioAction`1_hotfix != null)
				{
					this.m_add_EventOnStartPastScenarioAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataScenarioInfo> action = this.EventOnStartPastScenario;
				Action<ConfigDataScenarioInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataScenarioInfo>>(ref this.EventOnStartPastScenario, (Action<ConfigDataScenarioInfo>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnStartPastScenarioAction`1_hotfix != null)
				{
					this.m_remove_EventOnStartPastScenarioAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataScenarioInfo> action = this.EventOnStartPastScenario;
				Action<ConfigDataScenarioInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataScenarioInfo>>(ref this.EventOnStartPastScenario, (Action<ConfigDataScenarioInfo>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004AC RID: 1196
		// (add) Token: 0x06015003 RID: 86019 RVA: 0x00552308 File Offset: 0x00550508
		// (remove) Token: 0x06015004 RID: 86020 RVA: 0x005523A4 File Offset: 0x005505A4
		public event Action EventOnClosePastScenarioList
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnClosePastScenarioListAction_hotfix != null)
				{
					this.m_add_EventOnClosePastScenarioListAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClosePastScenarioList;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClosePastScenarioList, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnClosePastScenarioListAction_hotfix != null)
				{
					this.m_remove_EventOnClosePastScenarioListAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClosePastScenarioList;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClosePastScenarioList, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004AD RID: 1197
		// (add) Token: 0x06015005 RID: 86021 RVA: 0x00552440 File Offset: 0x00550640
		// (remove) Token: 0x06015006 RID: 86022 RVA: 0x005524DC File Offset: 0x005506DC
		public event Action EventOnShowHero
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowHeroAction_hotfix != null)
				{
					this.m_add_EventOnShowHeroAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowHero;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowHero, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowHeroAction_hotfix != null)
				{
					this.m_remove_EventOnShowHeroAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowHero;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowHero, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004AE RID: 1198
		// (add) Token: 0x06015007 RID: 86023 RVA: 0x00552578 File Offset: 0x00550778
		// (remove) Token: 0x06015008 RID: 86024 RVA: 0x00552614 File Offset: 0x00550814
		public event Action EventOnShowBag
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowBagAction_hotfix != null)
				{
					this.m_add_EventOnShowBagAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowBag;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowBag, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowBagAction_hotfix != null)
				{
					this.m_remove_EventOnShowBagAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowBag;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowBag, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004AF RID: 1199
		// (add) Token: 0x06015009 RID: 86025 RVA: 0x005526B0 File Offset: 0x005508B0
		// (remove) Token: 0x0601500A RID: 86026 RVA: 0x0055274C File Offset: 0x0055094C
		public event Action EventOnShowSelectCard
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowSelectCardAction_hotfix != null)
				{
					this.m_add_EventOnShowSelectCardAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowSelectCard;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowSelectCard, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowSelectCardAction_hotfix != null)
				{
					this.m_remove_EventOnShowSelectCardAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowSelectCard;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowSelectCard, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004B0 RID: 1200
		// (add) Token: 0x0601500B RID: 86027 RVA: 0x005527E8 File Offset: 0x005509E8
		// (remove) Token: 0x0601500C RID: 86028 RVA: 0x00552884 File Offset: 0x00550A84
		public event Action EventOnShowMisision
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowMisisionAction_hotfix != null)
				{
					this.m_add_EventOnShowMisisionAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowMisision;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowMisision, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowMisisionAction_hotfix != null)
				{
					this.m_remove_EventOnShowMisisionAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowMisision;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowMisision, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004B1 RID: 1201
		// (add) Token: 0x0601500D RID: 86029 RVA: 0x00552920 File Offset: 0x00550B20
		// (remove) Token: 0x0601500E RID: 86030 RVA: 0x005529BC File Offset: 0x00550BBC
		public event Action EventOnShowFetter
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowFetterAction_hotfix != null)
				{
					this.m_add_EventOnShowFetterAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowFetter;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowFetter, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowFetterAction_hotfix != null)
				{
					this.m_remove_EventOnShowFetterAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowFetter;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowFetter, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004B2 RID: 1202
		// (add) Token: 0x0601500F RID: 86031 RVA: 0x00552A58 File Offset: 0x00550C58
		// (remove) Token: 0x06015010 RID: 86032 RVA: 0x00552AF4 File Offset: 0x00550CF4
		public event Action EventOnShowStore
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowStoreAction_hotfix != null)
				{
					this.m_add_EventOnShowStoreAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowStore;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowStore, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowStoreAction_hotfix != null)
				{
					this.m_remove_EventOnShowStoreAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowStore;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowStore, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004B3 RID: 1203
		// (add) Token: 0x06015011 RID: 86033 RVA: 0x00552B90 File Offset: 0x00550D90
		// (remove) Token: 0x06015012 RID: 86034 RVA: 0x00552C2C File Offset: 0x00550E2C
		public event Action EventOnShowDrill
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowDrillAction_hotfix != null)
				{
					this.m_add_EventOnShowDrillAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowDrill;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowDrill, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowDrillAction_hotfix != null)
				{
					this.m_remove_EventOnShowDrillAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowDrill;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowDrill, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004B4 RID: 1204
		// (add) Token: 0x06015013 RID: 86035 RVA: 0x00552CC8 File Offset: 0x00550EC8
		// (remove) Token: 0x06015014 RID: 86036 RVA: 0x00552D64 File Offset: 0x00550F64
		public event Action EventOnShowFriend
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowFriendAction_hotfix != null)
				{
					this.m_add_EventOnShowFriendAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowFriend;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowFriend, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowFriendAction_hotfix != null)
				{
					this.m_remove_EventOnShowFriendAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowFriend;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowFriend, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004B5 RID: 1205
		// (add) Token: 0x06015015 RID: 86037 RVA: 0x00552E00 File Offset: 0x00551000
		// (remove) Token: 0x06015016 RID: 86038 RVA: 0x00552E9C File Offset: 0x0055109C
		public event Action EventOnShowGuild
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowGuildAction_hotfix != null)
				{
					this.m_add_EventOnShowGuildAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowGuild;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowGuild, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowGuildAction_hotfix != null)
				{
					this.m_remove_EventOnShowGuildAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowGuild;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowGuild, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004B6 RID: 1206
		// (add) Token: 0x06015017 RID: 86039 RVA: 0x00552F38 File Offset: 0x00551138
		// (remove) Token: 0x06015018 RID: 86040 RVA: 0x00552FD4 File Offset: 0x005511D4
		public event Action EventOnShowEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowEventAction_hotfix != null)
				{
					this.m_add_EventOnShowEventAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowEvent;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowEvent, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowEventAction_hotfix != null)
				{
					this.m_remove_EventOnShowEventAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowEvent;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowEvent, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004B7 RID: 1207
		// (add) Token: 0x06015019 RID: 86041 RVA: 0x00553070 File Offset: 0x00551270
		// (remove) Token: 0x0601501A RID: 86042 RVA: 0x0055310C File Offset: 0x0055130C
		public event Action EventOnShowUncharted
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowUnchartedAction_hotfix != null)
				{
					this.m_add_EventOnShowUnchartedAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowUncharted;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowUncharted, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowUnchartedAction_hotfix != null)
				{
					this.m_remove_EventOnShowUnchartedAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowUncharted;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowUncharted, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004B8 RID: 1208
		// (add) Token: 0x0601501B RID: 86043 RVA: 0x005531A8 File Offset: 0x005513A8
		// (remove) Token: 0x0601501C RID: 86044 RVA: 0x00553244 File Offset: 0x00551444
		public event Action EventOnShowArena
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowArenaAction_hotfix != null)
				{
					this.m_add_EventOnShowArenaAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowArena;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowArena, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowArenaAction_hotfix != null)
				{
					this.m_remove_EventOnShowArenaAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowArena;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowArena, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004B9 RID: 1209
		// (add) Token: 0x0601501D RID: 86045 RVA: 0x005532E0 File Offset: 0x005514E0
		// (remove) Token: 0x0601501E RID: 86046 RVA: 0x0055337C File Offset: 0x0055157C
		public event Action EventOnShowRift
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowRiftAction_hotfix != null)
				{
					this.m_add_EventOnShowRiftAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowRift;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowRift, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowRiftAction_hotfix != null)
				{
					this.m_remove_EventOnShowRiftAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowRift;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowRift, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004BA RID: 1210
		// (add) Token: 0x0601501F RID: 86047 RVA: 0x00553418 File Offset: 0x00551618
		// (remove) Token: 0x06015020 RID: 86048 RVA: 0x005534B4 File Offset: 0x005516B4
		public event Action EventOnShowTest
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowTestAction_hotfix != null)
				{
					this.m_add_EventOnShowTestAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowTest;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowTest, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowTestAction_hotfix != null)
				{
					this.m_remove_EventOnShowTestAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowTest;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowTest, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004BB RID: 1211
		// (add) Token: 0x06015021 RID: 86049 RVA: 0x00553550 File Offset: 0x00551750
		// (remove) Token: 0x06015022 RID: 86050 RVA: 0x005535EC File Offset: 0x005517EC
		public event Action EventOnShowCooperateBattle
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowCooperateBattleAction_hotfix != null)
				{
					this.m_add_EventOnShowCooperateBattleAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowCooperateBattle;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowCooperateBattle, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowCooperateBattleAction_hotfix != null)
				{
					this.m_remove_EventOnShowCooperateBattleAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowCooperateBattle;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowCooperateBattle, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004BC RID: 1212
		// (add) Token: 0x06015023 RID: 86051 RVA: 0x00553688 File Offset: 0x00551888
		// (remove) Token: 0x06015024 RID: 86052 RVA: 0x00553724 File Offset: 0x00551924
		public event Action EventOnShowMail
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowMailAction_hotfix != null)
				{
					this.m_add_EventOnShowMailAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowMail;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowMail, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowMailAction_hotfix != null)
				{
					this.m_remove_EventOnShowMailAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowMail;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowMail, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004BD RID: 1213
		// (add) Token: 0x06015025 RID: 86053 RVA: 0x005537C0 File Offset: 0x005519C0
		// (remove) Token: 0x06015026 RID: 86054 RVA: 0x0055385C File Offset: 0x00551A5C
		public event Action EventOnShowChat
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowChatAction_hotfix != null)
				{
					this.m_add_EventOnShowChatAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowChat;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowChat, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowChatAction_hotfix != null)
				{
					this.m_remove_EventOnShowChatAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowChat;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowChat, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004BE RID: 1214
		// (add) Token: 0x06015027 RID: 86055 RVA: 0x005538F8 File Offset: 0x00551AF8
		// (remove) Token: 0x06015028 RID: 86056 RVA: 0x00553994 File Offset: 0x00551B94
		public event Action EventOnShowRanking
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowRankingAction_hotfix != null)
				{
					this.m_add_EventOnShowRankingAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowRanking;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowRanking, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowRankingAction_hotfix != null)
				{
					this.m_remove_EventOnShowRankingAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowRanking;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowRanking, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004BF RID: 1215
		// (add) Token: 0x06015029 RID: 86057 RVA: 0x00553A30 File Offset: 0x00551C30
		// (remove) Token: 0x0601502A RID: 86058 RVA: 0x00553ACC File Offset: 0x00551CCC
		public event Action EventOnShowAnnouncement
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowAnnouncementAction_hotfix != null)
				{
					this.m_add_EventOnShowAnnouncementAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowAnnouncement;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowAnnouncement, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowAnnouncementAction_hotfix != null)
				{
					this.m_remove_EventOnShowAnnouncementAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowAnnouncement;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowAnnouncement, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004C0 RID: 1216
		// (add) Token: 0x0601502B RID: 86059 RVA: 0x00553B68 File Offset: 0x00551D68
		// (remove) Token: 0x0601502C RID: 86060 RVA: 0x00553C04 File Offset: 0x00551E04
		public event Action EventOnOpenWebInvestigation
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnOpenWebInvestigationAction_hotfix != null)
				{
					this.m_add_EventOnOpenWebInvestigationAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnOpenWebInvestigation;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnOpenWebInvestigation, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnOpenWebInvestigationAction_hotfix != null)
				{
					this.m_remove_EventOnOpenWebInvestigationAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnOpenWebInvestigation;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnOpenWebInvestigation, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004C1 RID: 1217
		// (add) Token: 0x0601502D RID: 86061 RVA: 0x00553CA0 File Offset: 0x00551EA0
		// (remove) Token: 0x0601502E RID: 86062 RVA: 0x00553D3C File Offset: 0x00551F3C
		public event Action EventOnShowOpenServiceActivity
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowOpenServiceActivityAction_hotfix != null)
				{
					this.m_add_EventOnShowOpenServiceActivityAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowOpenServiceActivity;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowOpenServiceActivity, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowOpenServiceActivityAction_hotfix != null)
				{
					this.m_remove_EventOnShowOpenServiceActivityAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowOpenServiceActivity;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowOpenServiceActivity, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004C2 RID: 1218
		// (add) Token: 0x0601502F RID: 86063 RVA: 0x00553DD8 File Offset: 0x00551FD8
		// (remove) Token: 0x06015030 RID: 86064 RVA: 0x00553E74 File Offset: 0x00552074
		public event Action EventOnMonthCardButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnMonthCardButtonClickAction_hotfix != null)
				{
					this.m_add_EventOnMonthCardButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnMonthCardButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnMonthCardButtonClick, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnMonthCardButtonClickAction_hotfix != null)
				{
					this.m_remove_EventOnMonthCardButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnMonthCardButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnMonthCardButtonClick, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004C3 RID: 1219
		// (add) Token: 0x06015031 RID: 86065 RVA: 0x00553F10 File Offset: 0x00552110
		// (remove) Token: 0x06015032 RID: 86066 RVA: 0x00553FAC File Offset: 0x005521AC
		public event Action<bool> EventOnRefreshMonthCardPanel
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnRefreshMonthCardPanelAction`1_hotfix != null)
				{
					this.m_add_EventOnRefreshMonthCardPanelAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnRefreshMonthCardPanel;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnRefreshMonthCardPanel, (Action<bool>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnRefreshMonthCardPanelAction`1_hotfix != null)
				{
					this.m_remove_EventOnRefreshMonthCardPanelAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnRefreshMonthCardPanel;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnRefreshMonthCardPanel, (Action<bool>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004C4 RID: 1220
		// (add) Token: 0x06015033 RID: 86067 RVA: 0x00554048 File Offset: 0x00552248
		// (remove) Token: 0x06015034 RID: 86068 RVA: 0x005540E4 File Offset: 0x005522E4
		public event Action<int> EventOnMonthCardItemClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnMonthCardItemClickAction`1_hotfix != null)
				{
					this.m_add_EventOnMonthCardItemClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnMonthCardItemClick;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnMonthCardItemClick, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnMonthCardItemClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnMonthCardItemClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnMonthCardItemClick;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnMonthCardItemClick, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004C5 RID: 1221
		// (add) Token: 0x06015035 RID: 86069 RVA: 0x00554180 File Offset: 0x00552380
		// (remove) Token: 0x06015036 RID: 86070 RVA: 0x0055421C File Offset: 0x0055241C
		public event Action<int> EventOnMonthCardItemBuyClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnMonthCardItemBuyClickAction`1_hotfix != null)
				{
					this.m_add_EventOnMonthCardItemBuyClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnMonthCardItemBuyClick;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnMonthCardItemBuyClick, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnMonthCardItemBuyClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnMonthCardItemBuyClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnMonthCardItemBuyClick;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnMonthCardItemBuyClick, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004C6 RID: 1222
		// (add) Token: 0x06015037 RID: 86071 RVA: 0x005542B8 File Offset: 0x005524B8
		// (remove) Token: 0x06015038 RID: 86072 RVA: 0x00554354 File Offset: 0x00552554
		public event Action EventOnYYBButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnYYBButtonClickAction_hotfix != null)
				{
					this.m_add_EventOnYYBButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnYYBButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnYYBButtonClick, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnYYBButtonClickAction_hotfix != null)
				{
					this.m_remove_EventOnYYBButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnYYBButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnYYBButtonClick, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004C7 RID: 1223
		// (add) Token: 0x06015039 RID: 86073 RVA: 0x005543F0 File Offset: 0x005525F0
		// (remove) Token: 0x0601503A RID: 86074 RVA: 0x0055448C File Offset: 0x0055268C
		public event Action EventOnOppoButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnOppoButtonClickAction_hotfix != null)
				{
					this.m_add_EventOnOppoButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnOppoButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnOppoButtonClick, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnOppoButtonClickAction_hotfix != null)
				{
					this.m_remove_EventOnOppoButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnOppoButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnOppoButtonClick, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003DB7 RID: 15799
		// (get) Token: 0x0601503B RID: 86075 RVA: 0x00554528 File Offset: 0x00552728
		// (set) Token: 0x0601503C RID: 86076 RVA: 0x00554548 File Offset: 0x00552748
		[DoNotToLua]
		public new WorldUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new WorldUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0601503D RID: 86077 RVA: 0x00554554 File Offset: 0x00552754
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0601503E RID: 86078 RVA: 0x00554560 File Offset: 0x00552760
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0601503F RID: 86079 RVA: 0x00554568 File Offset: 0x00552768
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06015040 RID: 86080 RVA: 0x00554570 File Offset: 0x00552770
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06015041 RID: 86081 RVA: 0x00554584 File Offset: 0x00552784
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06015042 RID: 86082 RVA: 0x0055458C File Offset: 0x0055278C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06015043 RID: 86083 RVA: 0x00554598 File Offset: 0x00552798
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06015044 RID: 86084 RVA: 0x005545A4 File Offset: 0x005527A4
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06015045 RID: 86085 RVA: 0x005545B0 File Offset: 0x005527B0
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06015046 RID: 86086 RVA: 0x005545BC File Offset: 0x005527BC
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06015047 RID: 86087 RVA: 0x005545C8 File Offset: 0x005527C8
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06015048 RID: 86088 RVA: 0x005545D4 File Offset: 0x005527D4
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06015049 RID: 86089 RVA: 0x005545E0 File Offset: 0x005527E0
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0601504A RID: 86090 RVA: 0x005545EC File Offset: 0x005527EC
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0601504B RID: 86091 RVA: 0x005545F8 File Offset: 0x005527F8
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0601504C RID: 86092 RVA: 0x00554600 File Offset: 0x00552800
		private void __callDele_EventOnShowPlayerInfo()
		{
			Action eventOnShowPlayerInfo = this.EventOnShowPlayerInfo;
			if (eventOnShowPlayerInfo != null)
			{
				eventOnShowPlayerInfo();
			}
		}

		// Token: 0x0601504D RID: 86093 RVA: 0x00554620 File Offset: 0x00552820
		private void __clearDele_EventOnShowPlayerInfo()
		{
			this.EventOnShowPlayerInfo = null;
		}

		// Token: 0x0601504E RID: 86094 RVA: 0x0055462C File Offset: 0x0055282C
		private void __callDele_EventOnCompass()
		{
			Action eventOnCompass = this.EventOnCompass;
			if (eventOnCompass != null)
			{
				eventOnCompass();
			}
		}

		// Token: 0x0601504F RID: 86095 RVA: 0x0055464C File Offset: 0x0055284C
		private void __clearDele_EventOnCompass()
		{
			this.EventOnCompass = null;
		}

		// Token: 0x06015050 RID: 86096 RVA: 0x00554658 File Offset: 0x00552858
		private void __callDele_EventOnCurrentScenario()
		{
			Action eventOnCurrentScenario = this.EventOnCurrentScenario;
			if (eventOnCurrentScenario != null)
			{
				eventOnCurrentScenario();
			}
		}

		// Token: 0x06015051 RID: 86097 RVA: 0x00554678 File Offset: 0x00552878
		private void __clearDele_EventOnCurrentScenario()
		{
			this.EventOnCurrentScenario = null;
		}

		// Token: 0x06015052 RID: 86098 RVA: 0x00554684 File Offset: 0x00552884
		private void __callDele_EventOnShowMainButtonBar(bool obj)
		{
			Action<bool> eventOnShowMainButtonBar = this.EventOnShowMainButtonBar;
			if (eventOnShowMainButtonBar != null)
			{
				eventOnShowMainButtonBar(obj);
			}
		}

		// Token: 0x06015053 RID: 86099 RVA: 0x005546A8 File Offset: 0x005528A8
		private void __clearDele_EventOnShowMainButtonBar(bool obj)
		{
			this.EventOnShowMainButtonBar = null;
		}

		// Token: 0x06015054 RID: 86100 RVA: 0x005546B4 File Offset: 0x005528B4
		private void __callDele_EventOnUnlockScenarioGotoRiftLevel(ConfigDataRiftLevelInfo obj)
		{
			Action<ConfigDataRiftLevelInfo> eventOnUnlockScenarioGotoRiftLevel = this.EventOnUnlockScenarioGotoRiftLevel;
			if (eventOnUnlockScenarioGotoRiftLevel != null)
			{
				eventOnUnlockScenarioGotoRiftLevel(obj);
			}
		}

		// Token: 0x06015055 RID: 86101 RVA: 0x005546D8 File Offset: 0x005528D8
		private void __clearDele_EventOnUnlockScenarioGotoRiftLevel(ConfigDataRiftLevelInfo obj)
		{
			this.EventOnUnlockScenarioGotoRiftLevel = null;
		}

		// Token: 0x06015056 RID: 86102 RVA: 0x005546E4 File Offset: 0x005528E4
		private void __callDele_EventOnGotoEvent(ConfigDataWaypointInfo arg1, ConfigDataEventInfo arg2)
		{
			Action<ConfigDataWaypointInfo, ConfigDataEventInfo> eventOnGotoEvent = this.EventOnGotoEvent;
			if (eventOnGotoEvent != null)
			{
				eventOnGotoEvent(arg1, arg2);
			}
		}

		// Token: 0x06015057 RID: 86103 RVA: 0x00554708 File Offset: 0x00552908
		private void __clearDele_EventOnGotoEvent(ConfigDataWaypointInfo arg1, ConfigDataEventInfo arg2)
		{
			this.EventOnGotoEvent = null;
		}

		// Token: 0x06015058 RID: 86104 RVA: 0x00554714 File Offset: 0x00552914
		private void __callDele_EventOnStartPastScenario(ConfigDataScenarioInfo obj)
		{
			Action<ConfigDataScenarioInfo> eventOnStartPastScenario = this.EventOnStartPastScenario;
			if (eventOnStartPastScenario != null)
			{
				eventOnStartPastScenario(obj);
			}
		}

		// Token: 0x06015059 RID: 86105 RVA: 0x00554738 File Offset: 0x00552938
		private void __clearDele_EventOnStartPastScenario(ConfigDataScenarioInfo obj)
		{
			this.EventOnStartPastScenario = null;
		}

		// Token: 0x0601505A RID: 86106 RVA: 0x00554744 File Offset: 0x00552944
		private void __callDele_EventOnClosePastScenarioList()
		{
			Action eventOnClosePastScenarioList = this.EventOnClosePastScenarioList;
			if (eventOnClosePastScenarioList != null)
			{
				eventOnClosePastScenarioList();
			}
		}

		// Token: 0x0601505B RID: 86107 RVA: 0x00554764 File Offset: 0x00552964
		private void __clearDele_EventOnClosePastScenarioList()
		{
			this.EventOnClosePastScenarioList = null;
		}

		// Token: 0x0601505C RID: 86108 RVA: 0x00554770 File Offset: 0x00552970
		private void __callDele_EventOnShowHero()
		{
			Action eventOnShowHero = this.EventOnShowHero;
			if (eventOnShowHero != null)
			{
				eventOnShowHero();
			}
		}

		// Token: 0x0601505D RID: 86109 RVA: 0x00554790 File Offset: 0x00552990
		private void __clearDele_EventOnShowHero()
		{
			this.EventOnShowHero = null;
		}

		// Token: 0x0601505E RID: 86110 RVA: 0x0055479C File Offset: 0x0055299C
		private void __callDele_EventOnShowBag()
		{
			Action eventOnShowBag = this.EventOnShowBag;
			if (eventOnShowBag != null)
			{
				eventOnShowBag();
			}
		}

		// Token: 0x0601505F RID: 86111 RVA: 0x005547BC File Offset: 0x005529BC
		private void __clearDele_EventOnShowBag()
		{
			this.EventOnShowBag = null;
		}

		// Token: 0x06015060 RID: 86112 RVA: 0x005547C8 File Offset: 0x005529C8
		private void __callDele_EventOnShowSelectCard()
		{
			Action eventOnShowSelectCard = this.EventOnShowSelectCard;
			if (eventOnShowSelectCard != null)
			{
				eventOnShowSelectCard();
			}
		}

		// Token: 0x06015061 RID: 86113 RVA: 0x005547E8 File Offset: 0x005529E8
		private void __clearDele_EventOnShowSelectCard()
		{
			this.EventOnShowSelectCard = null;
		}

		// Token: 0x06015062 RID: 86114 RVA: 0x005547F4 File Offset: 0x005529F4
		private void __callDele_EventOnShowMisision()
		{
			Action eventOnShowMisision = this.EventOnShowMisision;
			if (eventOnShowMisision != null)
			{
				eventOnShowMisision();
			}
		}

		// Token: 0x06015063 RID: 86115 RVA: 0x00554814 File Offset: 0x00552A14
		private void __clearDele_EventOnShowMisision()
		{
			this.EventOnShowMisision = null;
		}

		// Token: 0x06015064 RID: 86116 RVA: 0x00554820 File Offset: 0x00552A20
		private void __callDele_EventOnShowFetter()
		{
			Action eventOnShowFetter = this.EventOnShowFetter;
			if (eventOnShowFetter != null)
			{
				eventOnShowFetter();
			}
		}

		// Token: 0x06015065 RID: 86117 RVA: 0x00554840 File Offset: 0x00552A40
		private void __clearDele_EventOnShowFetter()
		{
			this.EventOnShowFetter = null;
		}

		// Token: 0x06015066 RID: 86118 RVA: 0x0055484C File Offset: 0x00552A4C
		private void __callDele_EventOnShowStore()
		{
			Action eventOnShowStore = this.EventOnShowStore;
			if (eventOnShowStore != null)
			{
				eventOnShowStore();
			}
		}

		// Token: 0x06015067 RID: 86119 RVA: 0x0055486C File Offset: 0x00552A6C
		private void __clearDele_EventOnShowStore()
		{
			this.EventOnShowStore = null;
		}

		// Token: 0x06015068 RID: 86120 RVA: 0x00554878 File Offset: 0x00552A78
		private void __callDele_EventOnShowDrill()
		{
			Action eventOnShowDrill = this.EventOnShowDrill;
			if (eventOnShowDrill != null)
			{
				eventOnShowDrill();
			}
		}

		// Token: 0x06015069 RID: 86121 RVA: 0x00554898 File Offset: 0x00552A98
		private void __clearDele_EventOnShowDrill()
		{
			this.EventOnShowDrill = null;
		}

		// Token: 0x0601506A RID: 86122 RVA: 0x005548A4 File Offset: 0x00552AA4
		private void __callDele_EventOnShowFriend()
		{
			Action eventOnShowFriend = this.EventOnShowFriend;
			if (eventOnShowFriend != null)
			{
				eventOnShowFriend();
			}
		}

		// Token: 0x0601506B RID: 86123 RVA: 0x005548C4 File Offset: 0x00552AC4
		private void __clearDele_EventOnShowFriend()
		{
			this.EventOnShowFriend = null;
		}

		// Token: 0x0601506C RID: 86124 RVA: 0x005548D0 File Offset: 0x00552AD0
		private void __callDele_EventOnShowGuild()
		{
			Action eventOnShowGuild = this.EventOnShowGuild;
			if (eventOnShowGuild != null)
			{
				eventOnShowGuild();
			}
		}

		// Token: 0x0601506D RID: 86125 RVA: 0x005548F0 File Offset: 0x00552AF0
		private void __clearDele_EventOnShowGuild()
		{
			this.EventOnShowGuild = null;
		}

		// Token: 0x0601506E RID: 86126 RVA: 0x005548FC File Offset: 0x00552AFC
		private void __callDele_EventOnShowEvent()
		{
			Action eventOnShowEvent = this.EventOnShowEvent;
			if (eventOnShowEvent != null)
			{
				eventOnShowEvent();
			}
		}

		// Token: 0x0601506F RID: 86127 RVA: 0x0055491C File Offset: 0x00552B1C
		private void __clearDele_EventOnShowEvent()
		{
			this.EventOnShowEvent = null;
		}

		// Token: 0x06015070 RID: 86128 RVA: 0x00554928 File Offset: 0x00552B28
		private void __callDele_EventOnShowUncharted()
		{
			Action eventOnShowUncharted = this.EventOnShowUncharted;
			if (eventOnShowUncharted != null)
			{
				eventOnShowUncharted();
			}
		}

		// Token: 0x06015071 RID: 86129 RVA: 0x00554948 File Offset: 0x00552B48
		private void __clearDele_EventOnShowUncharted()
		{
			this.EventOnShowUncharted = null;
		}

		// Token: 0x06015072 RID: 86130 RVA: 0x00554954 File Offset: 0x00552B54
		private void __callDele_EventOnShowArena()
		{
			Action eventOnShowArena = this.EventOnShowArena;
			if (eventOnShowArena != null)
			{
				eventOnShowArena();
			}
		}

		// Token: 0x06015073 RID: 86131 RVA: 0x00554974 File Offset: 0x00552B74
		private void __clearDele_EventOnShowArena()
		{
			this.EventOnShowArena = null;
		}

		// Token: 0x06015074 RID: 86132 RVA: 0x00554980 File Offset: 0x00552B80
		private void __callDele_EventOnShowRift()
		{
			Action eventOnShowRift = this.EventOnShowRift;
			if (eventOnShowRift != null)
			{
				eventOnShowRift();
			}
		}

		// Token: 0x06015075 RID: 86133 RVA: 0x005549A0 File Offset: 0x00552BA0
		private void __clearDele_EventOnShowRift()
		{
			this.EventOnShowRift = null;
		}

		// Token: 0x06015076 RID: 86134 RVA: 0x005549AC File Offset: 0x00552BAC
		private void __callDele_EventOnShowTest()
		{
			Action eventOnShowTest = this.EventOnShowTest;
			if (eventOnShowTest != null)
			{
				eventOnShowTest();
			}
		}

		// Token: 0x06015077 RID: 86135 RVA: 0x005549CC File Offset: 0x00552BCC
		private void __clearDele_EventOnShowTest()
		{
			this.EventOnShowTest = null;
		}

		// Token: 0x06015078 RID: 86136 RVA: 0x005549D8 File Offset: 0x00552BD8
		private void __callDele_EventOnShowCooperateBattle()
		{
			Action eventOnShowCooperateBattle = this.EventOnShowCooperateBattle;
			if (eventOnShowCooperateBattle != null)
			{
				eventOnShowCooperateBattle();
			}
		}

		// Token: 0x06015079 RID: 86137 RVA: 0x005549F8 File Offset: 0x00552BF8
		private void __clearDele_EventOnShowCooperateBattle()
		{
			this.EventOnShowCooperateBattle = null;
		}

		// Token: 0x0601507A RID: 86138 RVA: 0x00554A04 File Offset: 0x00552C04
		private void __callDele_EventOnShowMail()
		{
			Action eventOnShowMail = this.EventOnShowMail;
			if (eventOnShowMail != null)
			{
				eventOnShowMail();
			}
		}

		// Token: 0x0601507B RID: 86139 RVA: 0x00554A24 File Offset: 0x00552C24
		private void __clearDele_EventOnShowMail()
		{
			this.EventOnShowMail = null;
		}

		// Token: 0x0601507C RID: 86140 RVA: 0x00554A30 File Offset: 0x00552C30
		private void __callDele_EventOnShowChat()
		{
			Action eventOnShowChat = this.EventOnShowChat;
			if (eventOnShowChat != null)
			{
				eventOnShowChat();
			}
		}

		// Token: 0x0601507D RID: 86141 RVA: 0x00554A50 File Offset: 0x00552C50
		private void __clearDele_EventOnShowChat()
		{
			this.EventOnShowChat = null;
		}

		// Token: 0x0601507E RID: 86142 RVA: 0x00554A5C File Offset: 0x00552C5C
		private void __callDele_EventOnShowRanking()
		{
			Action eventOnShowRanking = this.EventOnShowRanking;
			if (eventOnShowRanking != null)
			{
				eventOnShowRanking();
			}
		}

		// Token: 0x0601507F RID: 86143 RVA: 0x00554A7C File Offset: 0x00552C7C
		private void __clearDele_EventOnShowRanking()
		{
			this.EventOnShowRanking = null;
		}

		// Token: 0x06015080 RID: 86144 RVA: 0x00554A88 File Offset: 0x00552C88
		private void __callDele_EventOnShowAnnouncement()
		{
			Action eventOnShowAnnouncement = this.EventOnShowAnnouncement;
			if (eventOnShowAnnouncement != null)
			{
				eventOnShowAnnouncement();
			}
		}

		// Token: 0x06015081 RID: 86145 RVA: 0x00554AA8 File Offset: 0x00552CA8
		private void __clearDele_EventOnShowAnnouncement()
		{
			this.EventOnShowAnnouncement = null;
		}

		// Token: 0x06015082 RID: 86146 RVA: 0x00554AB4 File Offset: 0x00552CB4
		private void __callDele_EventOnOpenWebInvestigation()
		{
			Action eventOnOpenWebInvestigation = this.EventOnOpenWebInvestigation;
			if (eventOnOpenWebInvestigation != null)
			{
				eventOnOpenWebInvestigation();
			}
		}

		// Token: 0x06015083 RID: 86147 RVA: 0x00554AD4 File Offset: 0x00552CD4
		private void __clearDele_EventOnOpenWebInvestigation()
		{
			this.EventOnOpenWebInvestigation = null;
		}

		// Token: 0x06015084 RID: 86148 RVA: 0x00554AE0 File Offset: 0x00552CE0
		private void __callDele_EventOnShowOpenServiceActivity()
		{
			Action eventOnShowOpenServiceActivity = this.EventOnShowOpenServiceActivity;
			if (eventOnShowOpenServiceActivity != null)
			{
				eventOnShowOpenServiceActivity();
			}
		}

		// Token: 0x06015085 RID: 86149 RVA: 0x00554B00 File Offset: 0x00552D00
		private void __clearDele_EventOnShowOpenServiceActivity()
		{
			this.EventOnShowOpenServiceActivity = null;
		}

		// Token: 0x06015086 RID: 86150 RVA: 0x00554B0C File Offset: 0x00552D0C
		private void __callDele_EventOnMonthCardButtonClick()
		{
			Action eventOnMonthCardButtonClick = this.EventOnMonthCardButtonClick;
			if (eventOnMonthCardButtonClick != null)
			{
				eventOnMonthCardButtonClick();
			}
		}

		// Token: 0x06015087 RID: 86151 RVA: 0x00554B2C File Offset: 0x00552D2C
		private void __clearDele_EventOnMonthCardButtonClick()
		{
			this.EventOnMonthCardButtonClick = null;
		}

		// Token: 0x06015088 RID: 86152 RVA: 0x00554B38 File Offset: 0x00552D38
		private void __callDele_EventOnRefreshMonthCardPanel(bool obj)
		{
			Action<bool> eventOnRefreshMonthCardPanel = this.EventOnRefreshMonthCardPanel;
			if (eventOnRefreshMonthCardPanel != null)
			{
				eventOnRefreshMonthCardPanel(obj);
			}
		}

		// Token: 0x06015089 RID: 86153 RVA: 0x00554B5C File Offset: 0x00552D5C
		private void __clearDele_EventOnRefreshMonthCardPanel(bool obj)
		{
			this.EventOnRefreshMonthCardPanel = null;
		}

		// Token: 0x0601508A RID: 86154 RVA: 0x00554B68 File Offset: 0x00552D68
		private void __callDele_EventOnMonthCardItemClick(int obj)
		{
			Action<int> eventOnMonthCardItemClick = this.EventOnMonthCardItemClick;
			if (eventOnMonthCardItemClick != null)
			{
				eventOnMonthCardItemClick(obj);
			}
		}

		// Token: 0x0601508B RID: 86155 RVA: 0x00554B8C File Offset: 0x00552D8C
		private void __clearDele_EventOnMonthCardItemClick(int obj)
		{
			this.EventOnMonthCardItemClick = null;
		}

		// Token: 0x0601508C RID: 86156 RVA: 0x00554B98 File Offset: 0x00552D98
		private void __callDele_EventOnMonthCardItemBuyClick(int obj)
		{
			Action<int> eventOnMonthCardItemBuyClick = this.EventOnMonthCardItemBuyClick;
			if (eventOnMonthCardItemBuyClick != null)
			{
				eventOnMonthCardItemBuyClick(obj);
			}
		}

		// Token: 0x0601508D RID: 86157 RVA: 0x00554BBC File Offset: 0x00552DBC
		private void __clearDele_EventOnMonthCardItemBuyClick(int obj)
		{
			this.EventOnMonthCardItemBuyClick = null;
		}

		// Token: 0x0601508E RID: 86158 RVA: 0x00554BC8 File Offset: 0x00552DC8
		private void __callDele_EventOnYYBButtonClick()
		{
			Action eventOnYYBButtonClick = this.EventOnYYBButtonClick;
			if (eventOnYYBButtonClick != null)
			{
				eventOnYYBButtonClick();
			}
		}

		// Token: 0x0601508F RID: 86159 RVA: 0x00554BE8 File Offset: 0x00552DE8
		private void __clearDele_EventOnYYBButtonClick()
		{
			this.EventOnYYBButtonClick = null;
		}

		// Token: 0x06015090 RID: 86160 RVA: 0x00554BF4 File Offset: 0x00552DF4
		private void __callDele_EventOnOppoButtonClick()
		{
			Action eventOnOppoButtonClick = this.EventOnOppoButtonClick;
			if (eventOnOppoButtonClick != null)
			{
				eventOnOppoButtonClick();
			}
		}

		// Token: 0x06015091 RID: 86161 RVA: 0x00554C14 File Offset: 0x00552E14
		private void __clearDele_EventOnOppoButtonClick()
		{
			this.EventOnOppoButtonClick = null;
		}

		// Token: 0x06015095 RID: 86165 RVA: 0x00554C6C File Offset: 0x00552E6C
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
					this.m_OnEnable_hotfix = (luaObj.RawGet("OnEnable") as LuaFunction);
					this.m_UpdateDeveloperMode_hotfix = (luaObj.RawGet("UpdateDeveloperMode") as LuaFunction);
					this.m_ShowOrHideBoolean_hotfix = (luaObj.RawGet("ShowOrHide") as LuaFunction);
					this.m_UpdateGameFunctionOpen_hotfix = (luaObj.RawGet("UpdateGameFunctionOpen") as LuaFunction);
					this.m_SetPlayerNameString_hotfix = (luaObj.RawGet("SetPlayerName") as LuaFunction);
					this.m_SetPlayerLevelInt32_hotfix = (luaObj.RawGet("SetPlayerLevel") as LuaFunction);
					this.m_SetPlayerVipInt32_hotfix = (luaObj.RawGet("SetPlayerVip") as LuaFunction);
					this.m_SetPlayerExpInt32Int32_hotfix = (luaObj.RawGet("SetPlayerExp") as LuaFunction);
					this.m_SetPlayerHeadIconInt32_hotfix = (luaObj.RawGet("SetPlayerHeadIcon") as LuaFunction);
					this.m_ShowMainButtonBarBoolean_hotfix = (luaObj.RawGet("ShowMainButtonBar") as LuaFunction);
					this.m_SetCurrentScenarioConfigDataScenarioInfo_hotfix = (luaObj.RawGet("SetCurrentScenario") as LuaFunction);
					this.m_ShowNewScenarioConfigDataScenarioInfoAction_hotfix = (luaObj.RawGet("ShowNewScenario") as LuaFunction);
					this.m_ShowUnlockScenarioConfigDataScenarioInfo_hotfix = (luaObj.RawGet("ShowUnlockScenario") as LuaFunction);
					this.m_ShowEnterScenarioConfigDataScenarioInfoAction_hotfix = (luaObj.RawGet("ShowEnterScenario") as LuaFunction);
					this.m_ShowEnterMonsterConfigDataBattleInfoAction_hotfix = (luaObj.RawGet("ShowEnterMonster") as LuaFunction);
					this.m_Co_EnterMonsterAction_hotfix = (luaObj.RawGet("Co_EnterMonster") as LuaFunction);
					this.m_SetFogSingle_hotfix = (luaObj.RawGet("SetFog") as LuaFunction);
					this.m_AddRandomEventConfigDataWaypointInfoRandomEvent_hotfix = (luaObj.RawGet("AddRandomEvent") as LuaFunction);
					this.m_ClearRandomEventList_hotfix = (luaObj.RawGet("ClearRandomEventList") as LuaFunction);
					this.m_ShowEventList_hotfix = (luaObj.RawGet("ShowEventList") as LuaFunction);
					this.m_HideEventListAction_hotfix = (luaObj.RawGet("HideEventList") as LuaFunction);
					this.m_IsEventListVisible_hotfix = (luaObj.RawGet("IsEventListVisible") as LuaFunction);
					this.m_AddPastScenarioConfigDataScenarioInfo_hotfix = (luaObj.RawGet("AddPastScenario") as LuaFunction);
					this.m_ClearPastScenarioList_hotfix = (luaObj.RawGet("ClearPastScenarioList") as LuaFunction);
					this.m_ShowPastScenarioList_hotfix = (luaObj.RawGet("ShowPastScenarioList") as LuaFunction);
					this.m_HidePastScenarioList_hotfix = (luaObj.RawGet("HidePastScenarioList") as LuaFunction);
					this.m_ShowCooperateBattleButtonBoolean_hotfix = (luaObj.RawGet("ShowCooperateBattleButton") as LuaFunction);
					this.m_ShowHeroRedMarkBoolean_hotfix = (luaObj.RawGet("ShowHeroRedMark") as LuaFunction);
					this.m_ShowDrillRedMarkBoolean_hotfix = (luaObj.RawGet("ShowDrillRedMark") as LuaFunction);
					this.m_ShowFetterRedMarkBoolean_hotfix = (luaObj.RawGet("ShowFetterRedMark") as LuaFunction);
					this.m_ShowGuildRedMarkBoolean_hotfix = (luaObj.RawGet("ShowGuildRedMark") as LuaFunction);
					this.m_ShowEventRedMarkBoolean_hotfix = (luaObj.RawGet("ShowEventRedMark") as LuaFunction);
					this.m_ShowMissionRedMarkBoolean_hotfix = (luaObj.RawGet("ShowMissionRedMark") as LuaFunction);
					this.m_ShowActivityRedMarkBoolean_hotfix = (luaObj.RawGet("ShowActivityRedMark") as LuaFunction);
					this.m_ShowFriendRedMarkBoolean_hotfix = (luaObj.RawGet("ShowFriendRedMark") as LuaFunction);
					this.m_UpdateNewChatCountInt32_hotfix = (luaObj.RawGet("UpdateNewChatCount") as LuaFunction);
					this.m_UpdateUnreadMailCountInt32_hotfix = (luaObj.RawGet("UpdateUnreadMailCount") as LuaFunction);
					this.m_GetUserGuideDialogHideGameObjects_hotfix = (luaObj.RawGet("GetUserGuideDialogHideGameObjects") as LuaFunction);
					this.m_UpdateMonthCardOpenBoolean_hotfix = (luaObj.RawGet("UpdateMonthCardOpen") as LuaFunction);
					this.m_OpenMonthCardPanelList`1_hotfix = (luaObj.RawGet("OpenMonthCardPanel") as LuaFunction);
					this.m_CloseMonthCardPanel_hotfix = (luaObj.RawGet("CloseMonthCardPanel") as LuaFunction);
					this.m_DeveloperModeClick_hotfix = (luaObj.RawGet("DeveloperModeClick") as LuaFunction);
					this.m_OnCompassButtonClick_hotfix = (luaObj.RawGet("OnCompassButtonClick") as LuaFunction);
					this.m_OnCurrentScenarioButtonClick_hotfix = (luaObj.RawGet("OnCurrentScenarioButtonClick") as LuaFunction);
					this.m_OnUnlockScenarioBackgroundButtonClick_hotfix = (luaObj.RawGet("OnUnlockScenarioBackgroundButtonClick") as LuaFunction);
					this.m_OnUnlockScenarioGotoButtonClick_hotfix = (luaObj.RawGet("OnUnlockScenarioGotoButtonClick") as LuaFunction);
					this.m_OnMainButtonClick_hotfix = (luaObj.RawGet("OnMainButtonClick") as LuaFunction);
					this.m_OnPlayerButtonClickUIControllerBase_hotfix = (luaObj.RawGet("OnPlayerButtonClick") as LuaFunction);
					this.m_OnHeroButtonClickUIControllerBase_hotfix = (luaObj.RawGet("OnHeroButtonClick") as LuaFunction);
					this.m_OnBagButtonClickUIControllerBase_hotfix = (luaObj.RawGet("OnBagButtonClick") as LuaFunction);
					this.m_OnSelectCardButtonClickUIControllerBase_hotfix = (luaObj.RawGet("OnSelectCardButtonClick") as LuaFunction);
					this.m_OnMissionButtonClickUIControllerBase_hotfix = (luaObj.RawGet("OnMissionButtonClick") as LuaFunction);
					this.m_OnFetterButtonClickUIControllerBase_hotfix = (luaObj.RawGet("OnFetterButtonClick") as LuaFunction);
					this.m_OnStoreButtonClickUIControllerBase_hotfix = (luaObj.RawGet("OnStoreButtonClick") as LuaFunction);
					this.m_OnDrillButtonClickUIControllerBase_hotfix = (luaObj.RawGet("OnDrillButtonClick") as LuaFunction);
					this.m_OnFriendButtonClickUIControllerBase_hotfix = (luaObj.RawGet("OnFriendButtonClick") as LuaFunction);
					this.m_OnGuildButtonClickUIControllerBase_hotfix = (luaObj.RawGet("OnGuildButtonClick") as LuaFunction);
					this.m_OnEventButtonClickUIControllerBase_hotfix = (luaObj.RawGet("OnEventButtonClick") as LuaFunction);
					this.m_OnUnchartedButtonClickUIControllerBase_hotfix = (luaObj.RawGet("OnUnchartedButtonClick") as LuaFunction);
					this.m_OnArenaButtonClickUIControllerBase_hotfix = (luaObj.RawGet("OnArenaButtonClick") as LuaFunction);
					this.m_OnRiftButtonClickUIControllerBase_hotfix = (luaObj.RawGet("OnRiftButtonClick") as LuaFunction);
					this.m_OnTestButtonClickUIControllerBase_hotfix = (luaObj.RawGet("OnTestButtonClick") as LuaFunction);
					this.m_OnCooperateBattleButtonClick_hotfix = (luaObj.RawGet("OnCooperateBattleButtonClick") as LuaFunction);
					this.m_OnMailButtonClickUIControllerBase_hotfix = (luaObj.RawGet("OnMailButtonClick") as LuaFunction);
					this.m_OnChatButtonClickUIControllerBase_hotfix = (luaObj.RawGet("OnChatButtonClick") as LuaFunction);
					this.m_OnRankButtonClickUIControllerBase_hotfix = (luaObj.RawGet("OnRankButtonClick") as LuaFunction);
					this.m_OnActivityButtonClickUIControllerBase_hotfix = (luaObj.RawGet("OnActivityButtonClick") as LuaFunction);
					this.m_OnOpenServiceActivityButtonClickUIControllerBase_hotfix = (luaObj.RawGet("OnOpenServiceActivityButtonClick") as LuaFunction);
					this.m_OnOppoButtonClickUIControllerBase_hotfix = (luaObj.RawGet("OnOppoButtonClick") as LuaFunction);
					this.m_OnYingYongBaoButtonClickUIControllerBase_hotfix = (luaObj.RawGet("OnYingYongBaoButtonClick") as LuaFunction);
					this.m_OnInvestigationButtonClickUIControllerBase_hotfix = (luaObj.RawGet("OnInvestigationButtonClick") as LuaFunction);
					this.m_UpdateInvestigationButton_hotfix = (luaObj.RawGet("UpdateInvestigationButton") as LuaFunction);
					this.m_UpdateOpenServiceActivityButton_hotfix = (luaObj.RawGet("UpdateOpenServiceActivityButton") as LuaFunction);
					this.m_WorldEventListItem_OnButtonClickWorldEventListItemUIController_hotfix = (luaObj.RawGet("WorldEventListItem_OnButtonClick") as LuaFunction);
					this.m_OnEventListBackgroundButtonClick_hotfix = (luaObj.RawGet("OnEventListBackgroundButtonClick") as LuaFunction);
					this.m_OnPastScenarioListBackgroundButtonClick_hotfix = (luaObj.RawGet("OnPastScenarioListBackgroundButtonClick") as LuaFunction);
					this.m_PastScenarioListItem_OnStartButtonClickPastScenarioListItemUIController_hotfix = (luaObj.RawGet("PastScenarioListItem_OnStartButtonClick") as LuaFunction);
					this.m_OnMonthCardButtonClick_hotfix = (luaObj.RawGet("OnMonthCardButtonClick") as LuaFunction);
					this.m_OnMonthCardCloseButtonClick_hotfix = (luaObj.RawGet("OnMonthCardCloseButtonClick") as LuaFunction);
					this.m_OnMonthCardItemItemClickInt32_hotfix = (luaObj.RawGet("OnMonthCardItemItemClick") as LuaFunction);
					this.m_OnMonthCardBuyClickInt32_hotfix = (luaObj.RawGet("OnMonthCardBuyClick") as LuaFunction);
					this.m_add_EventOnShowPlayerInfoAction_hotfix = (luaObj.RawGet("add_EventOnShowPlayerInfo") as LuaFunction);
					this.m_remove_EventOnShowPlayerInfoAction_hotfix = (luaObj.RawGet("remove_EventOnShowPlayerInfo") as LuaFunction);
					this.m_add_EventOnCompassAction_hotfix = (luaObj.RawGet("add_EventOnCompass") as LuaFunction);
					this.m_remove_EventOnCompassAction_hotfix = (luaObj.RawGet("remove_EventOnCompass") as LuaFunction);
					this.m_add_EventOnCurrentScenarioAction_hotfix = (luaObj.RawGet("add_EventOnCurrentScenario") as LuaFunction);
					this.m_remove_EventOnCurrentScenarioAction_hotfix = (luaObj.RawGet("remove_EventOnCurrentScenario") as LuaFunction);
					this.m_add_EventOnShowMainButtonBarAction`1_hotfix = (luaObj.RawGet("add_EventOnShowMainButtonBar") as LuaFunction);
					this.m_remove_EventOnShowMainButtonBarAction`1_hotfix = (luaObj.RawGet("remove_EventOnShowMainButtonBar") as LuaFunction);
					this.m_add_EventOnUnlockScenarioGotoRiftLevelAction`1_hotfix = (luaObj.RawGet("add_EventOnUnlockScenarioGotoRiftLevel") as LuaFunction);
					this.m_remove_EventOnUnlockScenarioGotoRiftLevelAction`1_hotfix = (luaObj.RawGet("remove_EventOnUnlockScenarioGotoRiftLevel") as LuaFunction);
					this.m_add_EventOnGotoEventAction`2_hotfix = (luaObj.RawGet("add_EventOnGotoEvent") as LuaFunction);
					this.m_remove_EventOnGotoEventAction`2_hotfix = (luaObj.RawGet("remove_EventOnGotoEvent") as LuaFunction);
					this.m_add_EventOnStartPastScenarioAction`1_hotfix = (luaObj.RawGet("add_EventOnStartPastScenario") as LuaFunction);
					this.m_remove_EventOnStartPastScenarioAction`1_hotfix = (luaObj.RawGet("remove_EventOnStartPastScenario") as LuaFunction);
					this.m_add_EventOnClosePastScenarioListAction_hotfix = (luaObj.RawGet("add_EventOnClosePastScenarioList") as LuaFunction);
					this.m_remove_EventOnClosePastScenarioListAction_hotfix = (luaObj.RawGet("remove_EventOnClosePastScenarioList") as LuaFunction);
					this.m_add_EventOnShowHeroAction_hotfix = (luaObj.RawGet("add_EventOnShowHero") as LuaFunction);
					this.m_remove_EventOnShowHeroAction_hotfix = (luaObj.RawGet("remove_EventOnShowHero") as LuaFunction);
					this.m_add_EventOnShowBagAction_hotfix = (luaObj.RawGet("add_EventOnShowBag") as LuaFunction);
					this.m_remove_EventOnShowBagAction_hotfix = (luaObj.RawGet("remove_EventOnShowBag") as LuaFunction);
					this.m_add_EventOnShowSelectCardAction_hotfix = (luaObj.RawGet("add_EventOnShowSelectCard") as LuaFunction);
					this.m_remove_EventOnShowSelectCardAction_hotfix = (luaObj.RawGet("remove_EventOnShowSelectCard") as LuaFunction);
					this.m_add_EventOnShowMisisionAction_hotfix = (luaObj.RawGet("add_EventOnShowMisision") as LuaFunction);
					this.m_remove_EventOnShowMisisionAction_hotfix = (luaObj.RawGet("remove_EventOnShowMisision") as LuaFunction);
					this.m_add_EventOnShowFetterAction_hotfix = (luaObj.RawGet("add_EventOnShowFetter") as LuaFunction);
					this.m_remove_EventOnShowFetterAction_hotfix = (luaObj.RawGet("remove_EventOnShowFetter") as LuaFunction);
					this.m_add_EventOnShowStoreAction_hotfix = (luaObj.RawGet("add_EventOnShowStore") as LuaFunction);
					this.m_remove_EventOnShowStoreAction_hotfix = (luaObj.RawGet("remove_EventOnShowStore") as LuaFunction);
					this.m_add_EventOnShowDrillAction_hotfix = (luaObj.RawGet("add_EventOnShowDrill") as LuaFunction);
					this.m_remove_EventOnShowDrillAction_hotfix = (luaObj.RawGet("remove_EventOnShowDrill") as LuaFunction);
					this.m_add_EventOnShowFriendAction_hotfix = (luaObj.RawGet("add_EventOnShowFriend") as LuaFunction);
					this.m_remove_EventOnShowFriendAction_hotfix = (luaObj.RawGet("remove_EventOnShowFriend") as LuaFunction);
					this.m_add_EventOnShowGuildAction_hotfix = (luaObj.RawGet("add_EventOnShowGuild") as LuaFunction);
					this.m_remove_EventOnShowGuildAction_hotfix = (luaObj.RawGet("remove_EventOnShowGuild") as LuaFunction);
					this.m_add_EventOnShowEventAction_hotfix = (luaObj.RawGet("add_EventOnShowEvent") as LuaFunction);
					this.m_remove_EventOnShowEventAction_hotfix = (luaObj.RawGet("remove_EventOnShowEvent") as LuaFunction);
					this.m_add_EventOnShowUnchartedAction_hotfix = (luaObj.RawGet("add_EventOnShowUncharted") as LuaFunction);
					this.m_remove_EventOnShowUnchartedAction_hotfix = (luaObj.RawGet("remove_EventOnShowUncharted") as LuaFunction);
					this.m_add_EventOnShowArenaAction_hotfix = (luaObj.RawGet("add_EventOnShowArena") as LuaFunction);
					this.m_remove_EventOnShowArenaAction_hotfix = (luaObj.RawGet("remove_EventOnShowArena") as LuaFunction);
					this.m_add_EventOnShowRiftAction_hotfix = (luaObj.RawGet("add_EventOnShowRift") as LuaFunction);
					this.m_remove_EventOnShowRiftAction_hotfix = (luaObj.RawGet("remove_EventOnShowRift") as LuaFunction);
					this.m_add_EventOnShowTestAction_hotfix = (luaObj.RawGet("add_EventOnShowTest") as LuaFunction);
					this.m_remove_EventOnShowTestAction_hotfix = (luaObj.RawGet("remove_EventOnShowTest") as LuaFunction);
					this.m_add_EventOnShowCooperateBattleAction_hotfix = (luaObj.RawGet("add_EventOnShowCooperateBattle") as LuaFunction);
					this.m_remove_EventOnShowCooperateBattleAction_hotfix = (luaObj.RawGet("remove_EventOnShowCooperateBattle") as LuaFunction);
					this.m_add_EventOnShowMailAction_hotfix = (luaObj.RawGet("add_EventOnShowMail") as LuaFunction);
					this.m_remove_EventOnShowMailAction_hotfix = (luaObj.RawGet("remove_EventOnShowMail") as LuaFunction);
					this.m_add_EventOnShowChatAction_hotfix = (luaObj.RawGet("add_EventOnShowChat") as LuaFunction);
					this.m_remove_EventOnShowChatAction_hotfix = (luaObj.RawGet("remove_EventOnShowChat") as LuaFunction);
					this.m_add_EventOnShowRankingAction_hotfix = (luaObj.RawGet("add_EventOnShowRanking") as LuaFunction);
					this.m_remove_EventOnShowRankingAction_hotfix = (luaObj.RawGet("remove_EventOnShowRanking") as LuaFunction);
					this.m_add_EventOnShowAnnouncementAction_hotfix = (luaObj.RawGet("add_EventOnShowAnnouncement") as LuaFunction);
					this.m_remove_EventOnShowAnnouncementAction_hotfix = (luaObj.RawGet("remove_EventOnShowAnnouncement") as LuaFunction);
					this.m_add_EventOnOpenWebInvestigationAction_hotfix = (luaObj.RawGet("add_EventOnOpenWebInvestigation") as LuaFunction);
					this.m_remove_EventOnOpenWebInvestigationAction_hotfix = (luaObj.RawGet("remove_EventOnOpenWebInvestigation") as LuaFunction);
					this.m_add_EventOnShowOpenServiceActivityAction_hotfix = (luaObj.RawGet("add_EventOnShowOpenServiceActivity") as LuaFunction);
					this.m_remove_EventOnShowOpenServiceActivityAction_hotfix = (luaObj.RawGet("remove_EventOnShowOpenServiceActivity") as LuaFunction);
					this.m_add_EventOnMonthCardButtonClickAction_hotfix = (luaObj.RawGet("add_EventOnMonthCardButtonClick") as LuaFunction);
					this.m_remove_EventOnMonthCardButtonClickAction_hotfix = (luaObj.RawGet("remove_EventOnMonthCardButtonClick") as LuaFunction);
					this.m_add_EventOnRefreshMonthCardPanelAction`1_hotfix = (luaObj.RawGet("add_EventOnRefreshMonthCardPanel") as LuaFunction);
					this.m_remove_EventOnRefreshMonthCardPanelAction`1_hotfix = (luaObj.RawGet("remove_EventOnRefreshMonthCardPanel") as LuaFunction);
					this.m_add_EventOnMonthCardItemClickAction`1_hotfix = (luaObj.RawGet("add_EventOnMonthCardItemClick") as LuaFunction);
					this.m_remove_EventOnMonthCardItemClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnMonthCardItemClick") as LuaFunction);
					this.m_add_EventOnMonthCardItemBuyClickAction`1_hotfix = (luaObj.RawGet("add_EventOnMonthCardItemBuyClick") as LuaFunction);
					this.m_remove_EventOnMonthCardItemBuyClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnMonthCardItemBuyClick") as LuaFunction);
					this.m_add_EventOnYYBButtonClickAction_hotfix = (luaObj.RawGet("add_EventOnYYBButtonClick") as LuaFunction);
					this.m_remove_EventOnYYBButtonClickAction_hotfix = (luaObj.RawGet("remove_EventOnYYBButtonClick") as LuaFunction);
					this.m_add_EventOnOppoButtonClickAction_hotfix = (luaObj.RawGet("add_EventOnOppoButtonClick") as LuaFunction);
					this.m_remove_EventOnOppoButtonClickAction_hotfix = (luaObj.RawGet("remove_EventOnOppoButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06015096 RID: 86166 RVA: 0x00555BF8 File Offset: 0x00553DF8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(WorldUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B74B RID: 46923
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400B74C RID: 46924
		[AutoBind("./Fog", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_fogImage;

		// Token: 0x0400B74D RID: 46925
		[AutoBind("./Player", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_playerButton;

		// Token: 0x0400B74E RID: 46926
		[AutoBind("./Player/Name/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerNameText;

		// Token: 0x0400B74F RID: 46927
		[AutoBind("./Player/Level/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerLevelText;

		// Token: 0x0400B750 RID: 46928
		[AutoBind("./Player/Vip/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerVipText;

		// Token: 0x0400B751 RID: 46929
		[AutoBind("./Player/Exp/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerExpText;

		// Token: 0x0400B752 RID: 46930
		[AutoBind("./Player/Exp/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_playerExpImage;

		// Token: 0x0400B753 RID: 46931
		[AutoBind("./Player/Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_playerIconImage;

		// Token: 0x0400B754 RID: 46932
		[AutoBind("./CompassButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_compassButton;

		// Token: 0x0400B755 RID: 46933
		[AutoBind("./CurrentScenario", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_currentScenarioButton;

		// Token: 0x0400B756 RID: 46934
		[AutoBind("./CurrentScenario/Name", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_currentScenarioNameText;

		// Token: 0x0400B757 RID: 46935
		[AutoBind("./NewScenario", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_newScenarioUIStateController;

		// Token: 0x0400B758 RID: 46936
		[AutoBind("./NewScenario/NameGroup/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_newScenarioNameText;

		// Token: 0x0400B759 RID: 46937
		[AutoBind("./EnterScenario", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_enterScenarioUIStateController;

		// Token: 0x0400B75A RID: 46938
		[AutoBind("./EnterScenario/Image/Chapter", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enterScenarioChapterText;

		// Token: 0x0400B75B RID: 46939
		[AutoBind("./EnterScenario/Image/Name", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enterScenarioNameText;

		// Token: 0x0400B75C RID: 46940
		[AutoBind("./EnterMonster", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_enterMonsterUIStateController;

		// Token: 0x0400B75D RID: 46941
		[AutoBind("./EventList", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_eventListTransform;

		// Token: 0x0400B75E RID: 46942
		[AutoBind("./EventList", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_eventListUIStateController;

		// Token: 0x0400B75F RID: 46943
		[AutoBind("./EventList/RandomEventPanel/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_randomEventScrollRect;

		// Token: 0x0400B760 RID: 46944
		[AutoBind("./EventList/BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_eventListBackgroundButton;

		// Token: 0x0400B761 RID: 46945
		[AutoBind("./PastScenarioList", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_pastScenarioListUIStateController;

		// Token: 0x0400B762 RID: 46946
		[AutoBind("./PastScenarioList/BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_pastScenarioListBackgroundButton;

		// Token: 0x0400B763 RID: 46947
		[AutoBind("./PastScenarioList/Detail/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_pastScenarioListScrollRect;

		// Token: 0x0400B764 RID: 46948
		[AutoBind("./UnlockScenario", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_unlockScenarioUIStateController;

		// Token: 0x0400B765 RID: 46949
		[AutoBind("./UnlockScenario/BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_unlockScenarioBackgroundButton;

		// Token: 0x0400B766 RID: 46950
		[AutoBind("./UnlockScenario/Frame/Title/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_unlockScenarioTitleText;

		// Token: 0x0400B767 RID: 46951
		[AutoBind("./UnlockScenario/Frame/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_unlockScenarioText;

		// Token: 0x0400B768 RID: 46952
		[AutoBind("./UnlockScenario/Frame/GotoButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_unlockScenarioGotoButton;

		// Token: 0x0400B769 RID: 46953
		[AutoBind("./MainButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_mainButton;

		// Token: 0x0400B76A RID: 46954
		[AutoBind("./MainButton/ON", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_mainButtonOnGameObject;

		// Token: 0x0400B76B RID: 46955
		[AutoBind("./MainButton/OFF", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_mainButtonOffGameObject;

		// Token: 0x0400B76C RID: 46956
		[AutoBind("./Margin1", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_margin1Transform;

		// Token: 0x0400B76D RID: 46957
		[AutoBind("./Margin1/MainButtonBar", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_mainButtonBarUIStateController;

		// Token: 0x0400B76E RID: 46958
		[AutoBind("./Margin1/MainButtonBar/HeroButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_heroButton;

		// Token: 0x0400B76F RID: 46959
		[AutoBind("./Margin1/MainButtonBar/HeroButton/RedMark", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroButtonRedMarkGameObject;

		// Token: 0x0400B770 RID: 46960
		[AutoBind("./Margin1/MainButtonBar/BagButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_bagButton;

		// Token: 0x0400B771 RID: 46961
		[AutoBind("./Margin1/MainButtonBar/MissionButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_missionButton;

		// Token: 0x0400B772 RID: 46962
		[AutoBind("./Margin1/MainButtonBar/MissionButton/RedMark", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_missionButtonRedMarkGameObject;

		// Token: 0x0400B773 RID: 46963
		[AutoBind("./Margin1/MainButtonBar/FetterButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_fetterButton;

		// Token: 0x0400B774 RID: 46964
		[AutoBind("./Margin1/MainButtonBar/FetterButton/RedMark", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_fetterButtonRedMarkGameObject;

		// Token: 0x0400B775 RID: 46965
		[AutoBind("./Margin1/MainButtonBar/StoreButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_storeButton;

		// Token: 0x0400B776 RID: 46966
		[AutoBind("./Margin1/MainButtonBar/SelectCardButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_selectCardButton;

		// Token: 0x0400B777 RID: 46967
		[AutoBind("./Margin1/MainButtonBar/TrainingHouseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_drillButton;

		// Token: 0x0400B778 RID: 46968
		[AutoBind("./Margin1/MainButtonBar/TrainingHouseButton/RedMark", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_drillButtonRedMark;

		// Token: 0x0400B779 RID: 46969
		[AutoBind("./Margin1/MainButtonBar/SociatyButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_guildButton;

		// Token: 0x0400B77A RID: 46970
		[AutoBind("./Margin1/MainButtonBar/SociatyButton/RedMark", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_sociatyButtonRedMark;

		// Token: 0x0400B77B RID: 46971
		[AutoBind("./Margin", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_marginTransform;

		// Token: 0x0400B77C RID: 46972
		[AutoBind("./Margin/Right/", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rightGameObject;

		// Token: 0x0400B77D RID: 46973
		[AutoBind("./Margin/Right/EventButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_eventButton;

		// Token: 0x0400B77E RID: 46974
		[AutoBind("./Margin/Right/EventButton/RedMark", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_eventButtonRedMarkGameObject;

		// Token: 0x0400B77F RID: 46975
		[AutoBind("./Margin/Right/UnchartedButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_unchartedButton;

		// Token: 0x0400B780 RID: 46976
		[AutoBind("./Margin/Right/ArenaButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_arenaButton;

		// Token: 0x0400B781 RID: 46977
		[AutoBind("./Margin/Right/RiftButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_riftButton;

		// Token: 0x0400B782 RID: 46978
		[AutoBind("./Margin/Right/TestButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_testButton;

		// Token: 0x0400B783 RID: 46979
		[AutoBind("./Margin/Right/CooperateBattleButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_cooperateBattleButton;

		// Token: 0x0400B784 RID: 46980
		[AutoBind("./Margin/Left/", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_leftGameObject;

		// Token: 0x0400B785 RID: 46981
		[AutoBind("./Margin/Left/FriendButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_friendButton;

		// Token: 0x0400B786 RID: 46982
		[AutoBind("./Margin/Left/FriendButton/RedMark", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_friendButtonRedMark;

		// Token: 0x0400B787 RID: 46983
		[AutoBind("./Margin/Left/MailButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_mailButton;

		// Token: 0x0400B788 RID: 46984
		[AutoBind("./Margin/Left/MailButton/CountPanel/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_unreadMailCountText;

		// Token: 0x0400B789 RID: 46985
		[AutoBind("./Margin/Left/ChatButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_chatButton;

		// Token: 0x0400B78A RID: 46986
		[AutoBind("./Margin/Left/ChatButton/CountPanel/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_newChatCountText;

		// Token: 0x0400B78B RID: 46987
		[AutoBind("./Margin/Left/RankButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_rankButton;

		// Token: 0x0400B78C RID: 46988
		[AutoBind("./Margin/Left/ActivityButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_activityButton;

		// Token: 0x0400B78D RID: 46989
		[AutoBind("./Margin/Left/ActivityButton/CountPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_activityRedMarkGameObject;

		// Token: 0x0400B78E RID: 46990
		[AutoBind("./Margin/Left/InvestigationButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_investigationButton;

		// Token: 0x0400B78F RID: 46991
		[AutoBind("./Margin/Left/InvestigationButton/RedMark", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_investigationButtonRedMark;

		// Token: 0x0400B790 RID: 46992
		[AutoBind("./Margin/YYBButton/", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_YYBButton;

		// Token: 0x0400B791 RID: 46993
		[AutoBind("./Margin/OppoButton/", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_OppoButton;

		// Token: 0x0400B792 RID: 46994
		[AutoBind("./OpenServiceButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_openServiceActivityButton;

		// Token: 0x0400B793 RID: 46995
		[AutoBind("./OpenServiceButton/RedMark", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_openServiceActivityButtonRedMark;

		// Token: 0x0400B794 RID: 46996
		[AutoBind("./MonthCardButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_monthCardButton;

		// Token: 0x0400B795 RID: 46997
		[AutoBind("./MonthCardBuyPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_monthCardPanelUIStateController;

		// Token: 0x0400B796 RID: 46998
		[AutoBind("./MonthCardBuyPanel/Detail/FrameImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_monthCardItemGroupObj;

		// Token: 0x0400B797 RID: 46999
		[AutoBind("./MonthCardBuyPanel", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_monthCardCloseButton;

		// Token: 0x0400B798 RID: 47000
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_prefabsGameObject;

		// Token: 0x0400B799 RID: 47001
		[AutoBind("./Prefabs/RandomEventListItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_randomEventListItemPrefab;

		// Token: 0x0400B79A RID: 47002
		[AutoBind("./Prefabs/PastScenarioListItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_pastScenarioListItemPrefab;

		// Token: 0x0400B79B RID: 47003
		[AutoBind("./Prefabs/MonthCardDetail", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_monthCardItemPrefab;

		// Token: 0x0400B79C RID: 47004
		private ConfigDataRiftLevelInfo m_gotoRiftLevelInfo;

		// Token: 0x0400B79D RID: 47005
		private int m_developerClickCount;

		// Token: 0x0400B79E RID: 47006
		private Color m_fogColor;

		// Token: 0x0400B79F RID: 47007
		private List<WorldEventListItemUIController> m_randomEventListItems = new List<WorldEventListItemUIController>();

		// Token: 0x0400B7A0 RID: 47008
		private List<PastScenarioListItemUIController> m_pastScenarioListItems = new List<PastScenarioListItemUIController>();

		// Token: 0x0400B7A1 RID: 47009
		private List<GameObject> m_userGuideDialogHideGameObjects = new List<GameObject>();

		// Token: 0x0400B7A2 RID: 47010
		private IConfigDataLoader m_configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;

		// Token: 0x0400B7A3 RID: 47011
		[DoNotToLua]
		private WorldUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400B7A4 RID: 47012
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B7A5 RID: 47013
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B7A6 RID: 47014
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400B7A7 RID: 47015
		private LuaFunction m_OnEnable_hotfix;

		// Token: 0x0400B7A8 RID: 47016
		private LuaFunction m_UpdateDeveloperMode_hotfix;

		// Token: 0x0400B7A9 RID: 47017
		private LuaFunction m_ShowOrHideBoolean_hotfix;

		// Token: 0x0400B7AA RID: 47018
		private LuaFunction m_UpdateGameFunctionOpen_hotfix;

		// Token: 0x0400B7AB RID: 47019
		private LuaFunction m_SetPlayerNameString_hotfix;

		// Token: 0x0400B7AC RID: 47020
		private LuaFunction m_SetPlayerLevelInt32_hotfix;

		// Token: 0x0400B7AD RID: 47021
		private LuaFunction m_SetPlayerVipInt32_hotfix;

		// Token: 0x0400B7AE RID: 47022
		private LuaFunction m_SetPlayerExpInt32Int32_hotfix;

		// Token: 0x0400B7AF RID: 47023
		private LuaFunction m_SetPlayerHeadIconInt32_hotfix;

		// Token: 0x0400B7B0 RID: 47024
		private LuaFunction m_ShowMainButtonBarBoolean_hotfix;

		// Token: 0x0400B7B1 RID: 47025
		private LuaFunction m_SetCurrentScenarioConfigDataScenarioInfo_hotfix;

		// Token: 0x0400B7B2 RID: 47026
		private LuaFunction m_ShowNewScenarioConfigDataScenarioInfoAction_hotfix;

		// Token: 0x0400B7B3 RID: 47027
		private LuaFunction m_ShowUnlockScenarioConfigDataScenarioInfo_hotfix;

		// Token: 0x0400B7B4 RID: 47028
		private LuaFunction m_ShowEnterScenarioConfigDataScenarioInfoAction_hotfix;

		// Token: 0x0400B7B5 RID: 47029
		private LuaFunction m_ShowEnterMonsterConfigDataBattleInfoAction_hotfix;

		// Token: 0x0400B7B6 RID: 47030
		private LuaFunction m_Co_EnterMonsterAction_hotfix;

		// Token: 0x0400B7B7 RID: 47031
		private LuaFunction m_SetFogSingle_hotfix;

		// Token: 0x0400B7B8 RID: 47032
		private LuaFunction m_AddRandomEventConfigDataWaypointInfoRandomEvent_hotfix;

		// Token: 0x0400B7B9 RID: 47033
		private LuaFunction m_ClearRandomEventList_hotfix;

		// Token: 0x0400B7BA RID: 47034
		private LuaFunction m_ShowEventList_hotfix;

		// Token: 0x0400B7BB RID: 47035
		private LuaFunction m_HideEventListAction_hotfix;

		// Token: 0x0400B7BC RID: 47036
		private LuaFunction m_IsEventListVisible_hotfix;

		// Token: 0x0400B7BD RID: 47037
		private LuaFunction m_AddPastScenarioConfigDataScenarioInfo_hotfix;

		// Token: 0x0400B7BE RID: 47038
		private LuaFunction m_ClearPastScenarioList_hotfix;

		// Token: 0x0400B7BF RID: 47039
		private LuaFunction m_ShowPastScenarioList_hotfix;

		// Token: 0x0400B7C0 RID: 47040
		private LuaFunction m_HidePastScenarioList_hotfix;

		// Token: 0x0400B7C1 RID: 47041
		private LuaFunction m_ShowCooperateBattleButtonBoolean_hotfix;

		// Token: 0x0400B7C2 RID: 47042
		private LuaFunction m_ShowHeroRedMarkBoolean_hotfix;

		// Token: 0x0400B7C3 RID: 47043
		private LuaFunction m_ShowDrillRedMarkBoolean_hotfix;

		// Token: 0x0400B7C4 RID: 47044
		private LuaFunction m_ShowFetterRedMarkBoolean_hotfix;

		// Token: 0x0400B7C5 RID: 47045
		private LuaFunction m_ShowGuildRedMarkBoolean_hotfix;

		// Token: 0x0400B7C6 RID: 47046
		private LuaFunction m_ShowEventRedMarkBoolean_hotfix;

		// Token: 0x0400B7C7 RID: 47047
		private LuaFunction m_ShowMissionRedMarkBoolean_hotfix;

		// Token: 0x0400B7C8 RID: 47048
		private LuaFunction m_ShowActivityRedMarkBoolean_hotfix;

		// Token: 0x0400B7C9 RID: 47049
		private LuaFunction m_ShowFriendRedMarkBoolean_hotfix;

		// Token: 0x0400B7CA RID: 47050
		private LuaFunction m_UpdateNewChatCountInt32_hotfix;

		// Token: 0x0400B7CB RID: 47051
		private LuaFunction m_UpdateUnreadMailCountInt32_hotfix;

		// Token: 0x0400B7CC RID: 47052
		private LuaFunction m_GetUserGuideDialogHideGameObjects_hotfix;

		// Token: 0x0400B7CD RID: 47053
		private LuaFunction m_UpdateMonthCardOpenBoolean_hotfix;

		// Token: 0x0400B7CE RID: 47054
		private LuaFunction m_OpenMonthCardPanelList;

		// Token: 0x0400B7CF RID: 47055
		private LuaFunction m_CloseMonthCardPanel_hotfix;

		// Token: 0x0400B7D0 RID: 47056
		private LuaFunction m_DeveloperModeClick_hotfix;

		// Token: 0x0400B7D1 RID: 47057
		private LuaFunction m_OnCompassButtonClick_hotfix;

		// Token: 0x0400B7D2 RID: 47058
		private LuaFunction m_OnCurrentScenarioButtonClick_hotfix;

		// Token: 0x0400B7D3 RID: 47059
		private LuaFunction m_OnUnlockScenarioBackgroundButtonClick_hotfix;

		// Token: 0x0400B7D4 RID: 47060
		private LuaFunction m_OnUnlockScenarioGotoButtonClick_hotfix;

		// Token: 0x0400B7D5 RID: 47061
		private LuaFunction m_OnMainButtonClick_hotfix;

		// Token: 0x0400B7D6 RID: 47062
		private LuaFunction m_OnPlayerButtonClickUIControllerBase_hotfix;

		// Token: 0x0400B7D7 RID: 47063
		private LuaFunction m_OnHeroButtonClickUIControllerBase_hotfix;

		// Token: 0x0400B7D8 RID: 47064
		private LuaFunction m_OnBagButtonClickUIControllerBase_hotfix;

		// Token: 0x0400B7D9 RID: 47065
		private LuaFunction m_OnSelectCardButtonClickUIControllerBase_hotfix;

		// Token: 0x0400B7DA RID: 47066
		private LuaFunction m_OnMissionButtonClickUIControllerBase_hotfix;

		// Token: 0x0400B7DB RID: 47067
		private LuaFunction m_OnFetterButtonClickUIControllerBase_hotfix;

		// Token: 0x0400B7DC RID: 47068
		private LuaFunction m_OnStoreButtonClickUIControllerBase_hotfix;

		// Token: 0x0400B7DD RID: 47069
		private LuaFunction m_OnDrillButtonClickUIControllerBase_hotfix;

		// Token: 0x0400B7DE RID: 47070
		private LuaFunction m_OnFriendButtonClickUIControllerBase_hotfix;

		// Token: 0x0400B7DF RID: 47071
		private LuaFunction m_OnGuildButtonClickUIControllerBase_hotfix;

		// Token: 0x0400B7E0 RID: 47072
		private LuaFunction m_OnEventButtonClickUIControllerBase_hotfix;

		// Token: 0x0400B7E1 RID: 47073
		private LuaFunction m_OnUnchartedButtonClickUIControllerBase_hotfix;

		// Token: 0x0400B7E2 RID: 47074
		private LuaFunction m_OnArenaButtonClickUIControllerBase_hotfix;

		// Token: 0x0400B7E3 RID: 47075
		private LuaFunction m_OnRiftButtonClickUIControllerBase_hotfix;

		// Token: 0x0400B7E4 RID: 47076
		private LuaFunction m_OnTestButtonClickUIControllerBase_hotfix;

		// Token: 0x0400B7E5 RID: 47077
		private LuaFunction m_OnCooperateBattleButtonClick_hotfix;

		// Token: 0x0400B7E6 RID: 47078
		private LuaFunction m_OnMailButtonClickUIControllerBase_hotfix;

		// Token: 0x0400B7E7 RID: 47079
		private LuaFunction m_OnChatButtonClickUIControllerBase_hotfix;

		// Token: 0x0400B7E8 RID: 47080
		private LuaFunction m_OnRankButtonClickUIControllerBase_hotfix;

		// Token: 0x0400B7E9 RID: 47081
		private LuaFunction m_OnActivityButtonClickUIControllerBase_hotfix;

		// Token: 0x0400B7EA RID: 47082
		private LuaFunction m_OnOpenServiceActivityButtonClickUIControllerBase_hotfix;

		// Token: 0x0400B7EB RID: 47083
		private LuaFunction m_OnOppoButtonClickUIControllerBase_hotfix;

		// Token: 0x0400B7EC RID: 47084
		private LuaFunction m_OnYingYongBaoButtonClickUIControllerBase_hotfix;

		// Token: 0x0400B7ED RID: 47085
		private LuaFunction m_OnInvestigationButtonClickUIControllerBase_hotfix;

		// Token: 0x0400B7EE RID: 47086
		private LuaFunction m_UpdateInvestigationButton_hotfix;

		// Token: 0x0400B7EF RID: 47087
		private LuaFunction m_UpdateOpenServiceActivityButton_hotfix;

		// Token: 0x0400B7F0 RID: 47088
		private LuaFunction m_WorldEventListItem_OnButtonClickWorldEventListItemUIController_hotfix;

		// Token: 0x0400B7F1 RID: 47089
		private LuaFunction m_OnEventListBackgroundButtonClick_hotfix;

		// Token: 0x0400B7F2 RID: 47090
		private LuaFunction m_OnPastScenarioListBackgroundButtonClick_hotfix;

		// Token: 0x0400B7F3 RID: 47091
		private LuaFunction m_PastScenarioListItem_OnStartButtonClickPastScenarioListItemUIController_hotfix;

		// Token: 0x0400B7F4 RID: 47092
		private LuaFunction m_OnMonthCardButtonClick_hotfix;

		// Token: 0x0400B7F5 RID: 47093
		private LuaFunction m_OnMonthCardCloseButtonClick_hotfix;

		// Token: 0x0400B7F6 RID: 47094
		private LuaFunction m_OnMonthCardItemItemClickInt32_hotfix;

		// Token: 0x0400B7F7 RID: 47095
		private LuaFunction m_OnMonthCardBuyClickInt32_hotfix;

		// Token: 0x0400B7F8 RID: 47096
		private LuaFunction m_add_EventOnShowPlayerInfoAction_hotfix;

		// Token: 0x0400B7F9 RID: 47097
		private LuaFunction m_remove_EventOnShowPlayerInfoAction_hotfix;

		// Token: 0x0400B7FA RID: 47098
		private LuaFunction m_add_EventOnCompassAction_hotfix;

		// Token: 0x0400B7FB RID: 47099
		private LuaFunction m_remove_EventOnCompassAction_hotfix;

		// Token: 0x0400B7FC RID: 47100
		private LuaFunction m_add_EventOnCurrentScenarioAction_hotfix;

		// Token: 0x0400B7FD RID: 47101
		private LuaFunction m_remove_EventOnCurrentScenarioAction_hotfix;

		// Token: 0x0400B7FE RID: 47102
		private LuaFunction m_add_EventOnShowMainButtonBarAction;

		// Token: 0x0400B7FF RID: 47103
		private LuaFunction m_remove_EventOnShowMainButtonBarAction;

		// Token: 0x0400B800 RID: 47104
		private LuaFunction m_add_EventOnUnlockScenarioGotoRiftLevelAction;

		// Token: 0x0400B801 RID: 47105
		private LuaFunction m_remove_EventOnUnlockScenarioGotoRiftLevelAction;

		// Token: 0x0400B802 RID: 47106
		private LuaFunction m_add_EventOnGotoEventAction;

		// Token: 0x0400B803 RID: 47107
		private LuaFunction m_remove_EventOnGotoEventAction;

		// Token: 0x0400B804 RID: 47108
		private LuaFunction m_add_EventOnStartPastScenarioAction;

		// Token: 0x0400B805 RID: 47109
		private LuaFunction m_remove_EventOnStartPastScenarioAction;

		// Token: 0x0400B806 RID: 47110
		private LuaFunction m_add_EventOnClosePastScenarioListAction_hotfix;

		// Token: 0x0400B807 RID: 47111
		private LuaFunction m_remove_EventOnClosePastScenarioListAction_hotfix;

		// Token: 0x0400B808 RID: 47112
		private LuaFunction m_add_EventOnShowHeroAction_hotfix;

		// Token: 0x0400B809 RID: 47113
		private LuaFunction m_remove_EventOnShowHeroAction_hotfix;

		// Token: 0x0400B80A RID: 47114
		private LuaFunction m_add_EventOnShowBagAction_hotfix;

		// Token: 0x0400B80B RID: 47115
		private LuaFunction m_remove_EventOnShowBagAction_hotfix;

		// Token: 0x0400B80C RID: 47116
		private LuaFunction m_add_EventOnShowSelectCardAction_hotfix;

		// Token: 0x0400B80D RID: 47117
		private LuaFunction m_remove_EventOnShowSelectCardAction_hotfix;

		// Token: 0x0400B80E RID: 47118
		private LuaFunction m_add_EventOnShowMisisionAction_hotfix;

		// Token: 0x0400B80F RID: 47119
		private LuaFunction m_remove_EventOnShowMisisionAction_hotfix;

		// Token: 0x0400B810 RID: 47120
		private LuaFunction m_add_EventOnShowFetterAction_hotfix;

		// Token: 0x0400B811 RID: 47121
		private LuaFunction m_remove_EventOnShowFetterAction_hotfix;

		// Token: 0x0400B812 RID: 47122
		private LuaFunction m_add_EventOnShowStoreAction_hotfix;

		// Token: 0x0400B813 RID: 47123
		private LuaFunction m_remove_EventOnShowStoreAction_hotfix;

		// Token: 0x0400B814 RID: 47124
		private LuaFunction m_add_EventOnShowDrillAction_hotfix;

		// Token: 0x0400B815 RID: 47125
		private LuaFunction m_remove_EventOnShowDrillAction_hotfix;

		// Token: 0x0400B816 RID: 47126
		private LuaFunction m_add_EventOnShowFriendAction_hotfix;

		// Token: 0x0400B817 RID: 47127
		private LuaFunction m_remove_EventOnShowFriendAction_hotfix;

		// Token: 0x0400B818 RID: 47128
		private LuaFunction m_add_EventOnShowGuildAction_hotfix;

		// Token: 0x0400B819 RID: 47129
		private LuaFunction m_remove_EventOnShowGuildAction_hotfix;

		// Token: 0x0400B81A RID: 47130
		private LuaFunction m_add_EventOnShowEventAction_hotfix;

		// Token: 0x0400B81B RID: 47131
		private LuaFunction m_remove_EventOnShowEventAction_hotfix;

		// Token: 0x0400B81C RID: 47132
		private LuaFunction m_add_EventOnShowUnchartedAction_hotfix;

		// Token: 0x0400B81D RID: 47133
		private LuaFunction m_remove_EventOnShowUnchartedAction_hotfix;

		// Token: 0x0400B81E RID: 47134
		private LuaFunction m_add_EventOnShowArenaAction_hotfix;

		// Token: 0x0400B81F RID: 47135
		private LuaFunction m_remove_EventOnShowArenaAction_hotfix;

		// Token: 0x0400B820 RID: 47136
		private LuaFunction m_add_EventOnShowRiftAction_hotfix;

		// Token: 0x0400B821 RID: 47137
		private LuaFunction m_remove_EventOnShowRiftAction_hotfix;

		// Token: 0x0400B822 RID: 47138
		private LuaFunction m_add_EventOnShowTestAction_hotfix;

		// Token: 0x0400B823 RID: 47139
		private LuaFunction m_remove_EventOnShowTestAction_hotfix;

		// Token: 0x0400B824 RID: 47140
		private LuaFunction m_add_EventOnShowCooperateBattleAction_hotfix;

		// Token: 0x0400B825 RID: 47141
		private LuaFunction m_remove_EventOnShowCooperateBattleAction_hotfix;

		// Token: 0x0400B826 RID: 47142
		private LuaFunction m_add_EventOnShowMailAction_hotfix;

		// Token: 0x0400B827 RID: 47143
		private LuaFunction m_remove_EventOnShowMailAction_hotfix;

		// Token: 0x0400B828 RID: 47144
		private LuaFunction m_add_EventOnShowChatAction_hotfix;

		// Token: 0x0400B829 RID: 47145
		private LuaFunction m_remove_EventOnShowChatAction_hotfix;

		// Token: 0x0400B82A RID: 47146
		private LuaFunction m_add_EventOnShowRankingAction_hotfix;

		// Token: 0x0400B82B RID: 47147
		private LuaFunction m_remove_EventOnShowRankingAction_hotfix;

		// Token: 0x0400B82C RID: 47148
		private LuaFunction m_add_EventOnShowAnnouncementAction_hotfix;

		// Token: 0x0400B82D RID: 47149
		private LuaFunction m_remove_EventOnShowAnnouncementAction_hotfix;

		// Token: 0x0400B82E RID: 47150
		private LuaFunction m_add_EventOnOpenWebInvestigationAction_hotfix;

		// Token: 0x0400B82F RID: 47151
		private LuaFunction m_remove_EventOnOpenWebInvestigationAction_hotfix;

		// Token: 0x0400B830 RID: 47152
		private LuaFunction m_add_EventOnShowOpenServiceActivityAction_hotfix;

		// Token: 0x0400B831 RID: 47153
		private LuaFunction m_remove_EventOnShowOpenServiceActivityAction_hotfix;

		// Token: 0x0400B832 RID: 47154
		private LuaFunction m_add_EventOnMonthCardButtonClickAction_hotfix;

		// Token: 0x0400B833 RID: 47155
		private LuaFunction m_remove_EventOnMonthCardButtonClickAction_hotfix;

		// Token: 0x0400B834 RID: 47156
		private LuaFunction m_add_EventOnRefreshMonthCardPanelAction;

		// Token: 0x0400B835 RID: 47157
		private LuaFunction m_remove_EventOnRefreshMonthCardPanelAction;

		// Token: 0x0400B836 RID: 47158
		private LuaFunction m_add_EventOnMonthCardItemClickAction;

		// Token: 0x0400B837 RID: 47159
		private LuaFunction m_remove_EventOnMonthCardItemClickAction;

		// Token: 0x0400B838 RID: 47160
		private LuaFunction m_add_EventOnMonthCardItemBuyClickAction;

		// Token: 0x0400B839 RID: 47161
		private LuaFunction m_remove_EventOnMonthCardItemBuyClickAction;

		// Token: 0x0400B83A RID: 47162
		private LuaFunction m_add_EventOnYYBButtonClickAction_hotfix;

		// Token: 0x0400B83B RID: 47163
		private LuaFunction m_remove_EventOnYYBButtonClickAction_hotfix;

		// Token: 0x0400B83C RID: 47164
		private LuaFunction m_add_EventOnOppoButtonClickAction_hotfix;

		// Token: 0x0400B83D RID: 47165
		private LuaFunction m_remove_EventOnOppoButtonClickAction_hotfix;

		// Token: 0x02001030 RID: 4144
		public new class LuaExportHelper
		{
			// Token: 0x06015097 RID: 86167 RVA: 0x00555C60 File Offset: 0x00553E60
			public LuaExportHelper(WorldUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06015098 RID: 86168 RVA: 0x00555C70 File Offset: 0x00553E70
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06015099 RID: 86169 RVA: 0x00555C80 File Offset: 0x00553E80
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0601509A RID: 86170 RVA: 0x00555C90 File Offset: 0x00553E90
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0601509B RID: 86171 RVA: 0x00555CA0 File Offset: 0x00553EA0
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0601509C RID: 86172 RVA: 0x00555CB8 File Offset: 0x00553EB8
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0601509D RID: 86173 RVA: 0x00555CC8 File Offset: 0x00553EC8
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0601509E RID: 86174 RVA: 0x00555CD8 File Offset: 0x00553ED8
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0601509F RID: 86175 RVA: 0x00555CE8 File Offset: 0x00553EE8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x060150A0 RID: 86176 RVA: 0x00555CF8 File Offset: 0x00553EF8
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x060150A1 RID: 86177 RVA: 0x00555D08 File Offset: 0x00553F08
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x060150A2 RID: 86178 RVA: 0x00555D18 File Offset: 0x00553F18
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x060150A3 RID: 86179 RVA: 0x00555D28 File Offset: 0x00553F28
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x060150A4 RID: 86180 RVA: 0x00555D38 File Offset: 0x00553F38
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x060150A5 RID: 86181 RVA: 0x00555D48 File Offset: 0x00553F48
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x060150A6 RID: 86182 RVA: 0x00555D58 File Offset: 0x00553F58
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x060150A7 RID: 86183 RVA: 0x00555D68 File Offset: 0x00553F68
			public void __callDele_EventOnShowPlayerInfo()
			{
				this.m_owner.__callDele_EventOnShowPlayerInfo();
			}

			// Token: 0x060150A8 RID: 86184 RVA: 0x00555D78 File Offset: 0x00553F78
			public void __clearDele_EventOnShowPlayerInfo()
			{
				this.m_owner.__clearDele_EventOnShowPlayerInfo();
			}

			// Token: 0x060150A9 RID: 86185 RVA: 0x00555D88 File Offset: 0x00553F88
			public void __callDele_EventOnCompass()
			{
				this.m_owner.__callDele_EventOnCompass();
			}

			// Token: 0x060150AA RID: 86186 RVA: 0x00555D98 File Offset: 0x00553F98
			public void __clearDele_EventOnCompass()
			{
				this.m_owner.__clearDele_EventOnCompass();
			}

			// Token: 0x060150AB RID: 86187 RVA: 0x00555DA8 File Offset: 0x00553FA8
			public void __callDele_EventOnCurrentScenario()
			{
				this.m_owner.__callDele_EventOnCurrentScenario();
			}

			// Token: 0x060150AC RID: 86188 RVA: 0x00555DB8 File Offset: 0x00553FB8
			public void __clearDele_EventOnCurrentScenario()
			{
				this.m_owner.__clearDele_EventOnCurrentScenario();
			}

			// Token: 0x060150AD RID: 86189 RVA: 0x00555DC8 File Offset: 0x00553FC8
			public void __callDele_EventOnShowMainButtonBar(bool obj)
			{
				this.m_owner.__callDele_EventOnShowMainButtonBar(obj);
			}

			// Token: 0x060150AE RID: 86190 RVA: 0x00555DD8 File Offset: 0x00553FD8
			public void __clearDele_EventOnShowMainButtonBar(bool obj)
			{
				this.m_owner.__clearDele_EventOnShowMainButtonBar(obj);
			}

			// Token: 0x060150AF RID: 86191 RVA: 0x00555DE8 File Offset: 0x00553FE8
			public void __callDele_EventOnUnlockScenarioGotoRiftLevel(ConfigDataRiftLevelInfo obj)
			{
				this.m_owner.__callDele_EventOnUnlockScenarioGotoRiftLevel(obj);
			}

			// Token: 0x060150B0 RID: 86192 RVA: 0x00555DF8 File Offset: 0x00553FF8
			public void __clearDele_EventOnUnlockScenarioGotoRiftLevel(ConfigDataRiftLevelInfo obj)
			{
				this.m_owner.__clearDele_EventOnUnlockScenarioGotoRiftLevel(obj);
			}

			// Token: 0x060150B1 RID: 86193 RVA: 0x00555E08 File Offset: 0x00554008
			public void __callDele_EventOnGotoEvent(ConfigDataWaypointInfo arg1, ConfigDataEventInfo arg2)
			{
				this.m_owner.__callDele_EventOnGotoEvent(arg1, arg2);
			}

			// Token: 0x060150B2 RID: 86194 RVA: 0x00555E18 File Offset: 0x00554018
			public void __clearDele_EventOnGotoEvent(ConfigDataWaypointInfo arg1, ConfigDataEventInfo arg2)
			{
				this.m_owner.__clearDele_EventOnGotoEvent(arg1, arg2);
			}

			// Token: 0x060150B3 RID: 86195 RVA: 0x00555E28 File Offset: 0x00554028
			public void __callDele_EventOnStartPastScenario(ConfigDataScenarioInfo obj)
			{
				this.m_owner.__callDele_EventOnStartPastScenario(obj);
			}

			// Token: 0x060150B4 RID: 86196 RVA: 0x00555E38 File Offset: 0x00554038
			public void __clearDele_EventOnStartPastScenario(ConfigDataScenarioInfo obj)
			{
				this.m_owner.__clearDele_EventOnStartPastScenario(obj);
			}

			// Token: 0x060150B5 RID: 86197 RVA: 0x00555E48 File Offset: 0x00554048
			public void __callDele_EventOnClosePastScenarioList()
			{
				this.m_owner.__callDele_EventOnClosePastScenarioList();
			}

			// Token: 0x060150B6 RID: 86198 RVA: 0x00555E58 File Offset: 0x00554058
			public void __clearDele_EventOnClosePastScenarioList()
			{
				this.m_owner.__clearDele_EventOnClosePastScenarioList();
			}

			// Token: 0x060150B7 RID: 86199 RVA: 0x00555E68 File Offset: 0x00554068
			public void __callDele_EventOnShowHero()
			{
				this.m_owner.__callDele_EventOnShowHero();
			}

			// Token: 0x060150B8 RID: 86200 RVA: 0x00555E78 File Offset: 0x00554078
			public void __clearDele_EventOnShowHero()
			{
				this.m_owner.__clearDele_EventOnShowHero();
			}

			// Token: 0x060150B9 RID: 86201 RVA: 0x00555E88 File Offset: 0x00554088
			public void __callDele_EventOnShowBag()
			{
				this.m_owner.__callDele_EventOnShowBag();
			}

			// Token: 0x060150BA RID: 86202 RVA: 0x00555E98 File Offset: 0x00554098
			public void __clearDele_EventOnShowBag()
			{
				this.m_owner.__clearDele_EventOnShowBag();
			}

			// Token: 0x060150BB RID: 86203 RVA: 0x00555EA8 File Offset: 0x005540A8
			public void __callDele_EventOnShowSelectCard()
			{
				this.m_owner.__callDele_EventOnShowSelectCard();
			}

			// Token: 0x060150BC RID: 86204 RVA: 0x00555EB8 File Offset: 0x005540B8
			public void __clearDele_EventOnShowSelectCard()
			{
				this.m_owner.__clearDele_EventOnShowSelectCard();
			}

			// Token: 0x060150BD RID: 86205 RVA: 0x00555EC8 File Offset: 0x005540C8
			public void __callDele_EventOnShowMisision()
			{
				this.m_owner.__callDele_EventOnShowMisision();
			}

			// Token: 0x060150BE RID: 86206 RVA: 0x00555ED8 File Offset: 0x005540D8
			public void __clearDele_EventOnShowMisision()
			{
				this.m_owner.__clearDele_EventOnShowMisision();
			}

			// Token: 0x060150BF RID: 86207 RVA: 0x00555EE8 File Offset: 0x005540E8
			public void __callDele_EventOnShowFetter()
			{
				this.m_owner.__callDele_EventOnShowFetter();
			}

			// Token: 0x060150C0 RID: 86208 RVA: 0x00555EF8 File Offset: 0x005540F8
			public void __clearDele_EventOnShowFetter()
			{
				this.m_owner.__clearDele_EventOnShowFetter();
			}

			// Token: 0x060150C1 RID: 86209 RVA: 0x00555F08 File Offset: 0x00554108
			public void __callDele_EventOnShowStore()
			{
				this.m_owner.__callDele_EventOnShowStore();
			}

			// Token: 0x060150C2 RID: 86210 RVA: 0x00555F18 File Offset: 0x00554118
			public void __clearDele_EventOnShowStore()
			{
				this.m_owner.__clearDele_EventOnShowStore();
			}

			// Token: 0x060150C3 RID: 86211 RVA: 0x00555F28 File Offset: 0x00554128
			public void __callDele_EventOnShowDrill()
			{
				this.m_owner.__callDele_EventOnShowDrill();
			}

			// Token: 0x060150C4 RID: 86212 RVA: 0x00555F38 File Offset: 0x00554138
			public void __clearDele_EventOnShowDrill()
			{
				this.m_owner.__clearDele_EventOnShowDrill();
			}

			// Token: 0x060150C5 RID: 86213 RVA: 0x00555F48 File Offset: 0x00554148
			public void __callDele_EventOnShowFriend()
			{
				this.m_owner.__callDele_EventOnShowFriend();
			}

			// Token: 0x060150C6 RID: 86214 RVA: 0x00555F58 File Offset: 0x00554158
			public void __clearDele_EventOnShowFriend()
			{
				this.m_owner.__clearDele_EventOnShowFriend();
			}

			// Token: 0x060150C7 RID: 86215 RVA: 0x00555F68 File Offset: 0x00554168
			public void __callDele_EventOnShowGuild()
			{
				this.m_owner.__callDele_EventOnShowGuild();
			}

			// Token: 0x060150C8 RID: 86216 RVA: 0x00555F78 File Offset: 0x00554178
			public void __clearDele_EventOnShowGuild()
			{
				this.m_owner.__clearDele_EventOnShowGuild();
			}

			// Token: 0x060150C9 RID: 86217 RVA: 0x00555F88 File Offset: 0x00554188
			public void __callDele_EventOnShowEvent()
			{
				this.m_owner.__callDele_EventOnShowEvent();
			}

			// Token: 0x060150CA RID: 86218 RVA: 0x00555F98 File Offset: 0x00554198
			public void __clearDele_EventOnShowEvent()
			{
				this.m_owner.__clearDele_EventOnShowEvent();
			}

			// Token: 0x060150CB RID: 86219 RVA: 0x00555FA8 File Offset: 0x005541A8
			public void __callDele_EventOnShowUncharted()
			{
				this.m_owner.__callDele_EventOnShowUncharted();
			}

			// Token: 0x060150CC RID: 86220 RVA: 0x00555FB8 File Offset: 0x005541B8
			public void __clearDele_EventOnShowUncharted()
			{
				this.m_owner.__clearDele_EventOnShowUncharted();
			}

			// Token: 0x060150CD RID: 86221 RVA: 0x00555FC8 File Offset: 0x005541C8
			public void __callDele_EventOnShowArena()
			{
				this.m_owner.__callDele_EventOnShowArena();
			}

			// Token: 0x060150CE RID: 86222 RVA: 0x00555FD8 File Offset: 0x005541D8
			public void __clearDele_EventOnShowArena()
			{
				this.m_owner.__clearDele_EventOnShowArena();
			}

			// Token: 0x060150CF RID: 86223 RVA: 0x00555FE8 File Offset: 0x005541E8
			public void __callDele_EventOnShowRift()
			{
				this.m_owner.__callDele_EventOnShowRift();
			}

			// Token: 0x060150D0 RID: 86224 RVA: 0x00555FF8 File Offset: 0x005541F8
			public void __clearDele_EventOnShowRift()
			{
				this.m_owner.__clearDele_EventOnShowRift();
			}

			// Token: 0x060150D1 RID: 86225 RVA: 0x00556008 File Offset: 0x00554208
			public void __callDele_EventOnShowTest()
			{
				this.m_owner.__callDele_EventOnShowTest();
			}

			// Token: 0x060150D2 RID: 86226 RVA: 0x00556018 File Offset: 0x00554218
			public void __clearDele_EventOnShowTest()
			{
				this.m_owner.__clearDele_EventOnShowTest();
			}

			// Token: 0x060150D3 RID: 86227 RVA: 0x00556028 File Offset: 0x00554228
			public void __callDele_EventOnShowCooperateBattle()
			{
				this.m_owner.__callDele_EventOnShowCooperateBattle();
			}

			// Token: 0x060150D4 RID: 86228 RVA: 0x00556038 File Offset: 0x00554238
			public void __clearDele_EventOnShowCooperateBattle()
			{
				this.m_owner.__clearDele_EventOnShowCooperateBattle();
			}

			// Token: 0x060150D5 RID: 86229 RVA: 0x00556048 File Offset: 0x00554248
			public void __callDele_EventOnShowMail()
			{
				this.m_owner.__callDele_EventOnShowMail();
			}

			// Token: 0x060150D6 RID: 86230 RVA: 0x00556058 File Offset: 0x00554258
			public void __clearDele_EventOnShowMail()
			{
				this.m_owner.__clearDele_EventOnShowMail();
			}

			// Token: 0x060150D7 RID: 86231 RVA: 0x00556068 File Offset: 0x00554268
			public void __callDele_EventOnShowChat()
			{
				this.m_owner.__callDele_EventOnShowChat();
			}

			// Token: 0x060150D8 RID: 86232 RVA: 0x00556078 File Offset: 0x00554278
			public void __clearDele_EventOnShowChat()
			{
				this.m_owner.__clearDele_EventOnShowChat();
			}

			// Token: 0x060150D9 RID: 86233 RVA: 0x00556088 File Offset: 0x00554288
			public void __callDele_EventOnShowRanking()
			{
				this.m_owner.__callDele_EventOnShowRanking();
			}

			// Token: 0x060150DA RID: 86234 RVA: 0x00556098 File Offset: 0x00554298
			public void __clearDele_EventOnShowRanking()
			{
				this.m_owner.__clearDele_EventOnShowRanking();
			}

			// Token: 0x060150DB RID: 86235 RVA: 0x005560A8 File Offset: 0x005542A8
			public void __callDele_EventOnShowAnnouncement()
			{
				this.m_owner.__callDele_EventOnShowAnnouncement();
			}

			// Token: 0x060150DC RID: 86236 RVA: 0x005560B8 File Offset: 0x005542B8
			public void __clearDele_EventOnShowAnnouncement()
			{
				this.m_owner.__clearDele_EventOnShowAnnouncement();
			}

			// Token: 0x060150DD RID: 86237 RVA: 0x005560C8 File Offset: 0x005542C8
			public void __callDele_EventOnOpenWebInvestigation()
			{
				this.m_owner.__callDele_EventOnOpenWebInvestigation();
			}

			// Token: 0x060150DE RID: 86238 RVA: 0x005560D8 File Offset: 0x005542D8
			public void __clearDele_EventOnOpenWebInvestigation()
			{
				this.m_owner.__clearDele_EventOnOpenWebInvestigation();
			}

			// Token: 0x060150DF RID: 86239 RVA: 0x005560E8 File Offset: 0x005542E8
			public void __callDele_EventOnShowOpenServiceActivity()
			{
				this.m_owner.__callDele_EventOnShowOpenServiceActivity();
			}

			// Token: 0x060150E0 RID: 86240 RVA: 0x005560F8 File Offset: 0x005542F8
			public void __clearDele_EventOnShowOpenServiceActivity()
			{
				this.m_owner.__clearDele_EventOnShowOpenServiceActivity();
			}

			// Token: 0x060150E1 RID: 86241 RVA: 0x00556108 File Offset: 0x00554308
			public void __callDele_EventOnMonthCardButtonClick()
			{
				this.m_owner.__callDele_EventOnMonthCardButtonClick();
			}

			// Token: 0x060150E2 RID: 86242 RVA: 0x00556118 File Offset: 0x00554318
			public void __clearDele_EventOnMonthCardButtonClick()
			{
				this.m_owner.__clearDele_EventOnMonthCardButtonClick();
			}

			// Token: 0x060150E3 RID: 86243 RVA: 0x00556128 File Offset: 0x00554328
			public void __callDele_EventOnRefreshMonthCardPanel(bool obj)
			{
				this.m_owner.__callDele_EventOnRefreshMonthCardPanel(obj);
			}

			// Token: 0x060150E4 RID: 86244 RVA: 0x00556138 File Offset: 0x00554338
			public void __clearDele_EventOnRefreshMonthCardPanel(bool obj)
			{
				this.m_owner.__clearDele_EventOnRefreshMonthCardPanel(obj);
			}

			// Token: 0x060150E5 RID: 86245 RVA: 0x00556148 File Offset: 0x00554348
			public void __callDele_EventOnMonthCardItemClick(int obj)
			{
				this.m_owner.__callDele_EventOnMonthCardItemClick(obj);
			}

			// Token: 0x060150E6 RID: 86246 RVA: 0x00556158 File Offset: 0x00554358
			public void __clearDele_EventOnMonthCardItemClick(int obj)
			{
				this.m_owner.__clearDele_EventOnMonthCardItemClick(obj);
			}

			// Token: 0x060150E7 RID: 86247 RVA: 0x00556168 File Offset: 0x00554368
			public void __callDele_EventOnMonthCardItemBuyClick(int obj)
			{
				this.m_owner.__callDele_EventOnMonthCardItemBuyClick(obj);
			}

			// Token: 0x060150E8 RID: 86248 RVA: 0x00556178 File Offset: 0x00554378
			public void __clearDele_EventOnMonthCardItemBuyClick(int obj)
			{
				this.m_owner.__clearDele_EventOnMonthCardItemBuyClick(obj);
			}

			// Token: 0x060150E9 RID: 86249 RVA: 0x00556188 File Offset: 0x00554388
			public void __callDele_EventOnYYBButtonClick()
			{
				this.m_owner.__callDele_EventOnYYBButtonClick();
			}

			// Token: 0x060150EA RID: 86250 RVA: 0x00556198 File Offset: 0x00554398
			public void __clearDele_EventOnYYBButtonClick()
			{
				this.m_owner.__clearDele_EventOnYYBButtonClick();
			}

			// Token: 0x060150EB RID: 86251 RVA: 0x005561A8 File Offset: 0x005543A8
			public void __callDele_EventOnOppoButtonClick()
			{
				this.m_owner.__callDele_EventOnOppoButtonClick();
			}

			// Token: 0x060150EC RID: 86252 RVA: 0x005561B8 File Offset: 0x005543B8
			public void __clearDele_EventOnOppoButtonClick()
			{
				this.m_owner.__clearDele_EventOnOppoButtonClick();
			}

			// Token: 0x17003DB8 RID: 15800
			// (get) Token: 0x060150ED RID: 86253 RVA: 0x005561C8 File Offset: 0x005543C8
			// (set) Token: 0x060150EE RID: 86254 RVA: 0x005561D8 File Offset: 0x005543D8
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

			// Token: 0x17003DB9 RID: 15801
			// (get) Token: 0x060150EF RID: 86255 RVA: 0x005561E8 File Offset: 0x005543E8
			// (set) Token: 0x060150F0 RID: 86256 RVA: 0x005561F8 File Offset: 0x005543F8
			public Image m_fogImage
			{
				get
				{
					return this.m_owner.m_fogImage;
				}
				set
				{
					this.m_owner.m_fogImage = value;
				}
			}

			// Token: 0x17003DBA RID: 15802
			// (get) Token: 0x060150F1 RID: 86257 RVA: 0x00556208 File Offset: 0x00554408
			// (set) Token: 0x060150F2 RID: 86258 RVA: 0x00556218 File Offset: 0x00554418
			public Button m_playerButton
			{
				get
				{
					return this.m_owner.m_playerButton;
				}
				set
				{
					this.m_owner.m_playerButton = value;
				}
			}

			// Token: 0x17003DBB RID: 15803
			// (get) Token: 0x060150F3 RID: 86259 RVA: 0x00556228 File Offset: 0x00554428
			// (set) Token: 0x060150F4 RID: 86260 RVA: 0x00556238 File Offset: 0x00554438
			public Text m_playerNameText
			{
				get
				{
					return this.m_owner.m_playerNameText;
				}
				set
				{
					this.m_owner.m_playerNameText = value;
				}
			}

			// Token: 0x17003DBC RID: 15804
			// (get) Token: 0x060150F5 RID: 86261 RVA: 0x00556248 File Offset: 0x00554448
			// (set) Token: 0x060150F6 RID: 86262 RVA: 0x00556258 File Offset: 0x00554458
			public Text m_playerLevelText
			{
				get
				{
					return this.m_owner.m_playerLevelText;
				}
				set
				{
					this.m_owner.m_playerLevelText = value;
				}
			}

			// Token: 0x17003DBD RID: 15805
			// (get) Token: 0x060150F7 RID: 86263 RVA: 0x00556268 File Offset: 0x00554468
			// (set) Token: 0x060150F8 RID: 86264 RVA: 0x00556278 File Offset: 0x00554478
			public Text m_playerVipText
			{
				get
				{
					return this.m_owner.m_playerVipText;
				}
				set
				{
					this.m_owner.m_playerVipText = value;
				}
			}

			// Token: 0x17003DBE RID: 15806
			// (get) Token: 0x060150F9 RID: 86265 RVA: 0x00556288 File Offset: 0x00554488
			// (set) Token: 0x060150FA RID: 86266 RVA: 0x00556298 File Offset: 0x00554498
			public Text m_playerExpText
			{
				get
				{
					return this.m_owner.m_playerExpText;
				}
				set
				{
					this.m_owner.m_playerExpText = value;
				}
			}

			// Token: 0x17003DBF RID: 15807
			// (get) Token: 0x060150FB RID: 86267 RVA: 0x005562A8 File Offset: 0x005544A8
			// (set) Token: 0x060150FC RID: 86268 RVA: 0x005562B8 File Offset: 0x005544B8
			public Image m_playerExpImage
			{
				get
				{
					return this.m_owner.m_playerExpImage;
				}
				set
				{
					this.m_owner.m_playerExpImage = value;
				}
			}

			// Token: 0x17003DC0 RID: 15808
			// (get) Token: 0x060150FD RID: 86269 RVA: 0x005562C8 File Offset: 0x005544C8
			// (set) Token: 0x060150FE RID: 86270 RVA: 0x005562D8 File Offset: 0x005544D8
			public Image m_playerIconImage
			{
				get
				{
					return this.m_owner.m_playerIconImage;
				}
				set
				{
					this.m_owner.m_playerIconImage = value;
				}
			}

			// Token: 0x17003DC1 RID: 15809
			// (get) Token: 0x060150FF RID: 86271 RVA: 0x005562E8 File Offset: 0x005544E8
			// (set) Token: 0x06015100 RID: 86272 RVA: 0x005562F8 File Offset: 0x005544F8
			public Button m_compassButton
			{
				get
				{
					return this.m_owner.m_compassButton;
				}
				set
				{
					this.m_owner.m_compassButton = value;
				}
			}

			// Token: 0x17003DC2 RID: 15810
			// (get) Token: 0x06015101 RID: 86273 RVA: 0x00556308 File Offset: 0x00554508
			// (set) Token: 0x06015102 RID: 86274 RVA: 0x00556318 File Offset: 0x00554518
			public Button m_currentScenarioButton
			{
				get
				{
					return this.m_owner.m_currentScenarioButton;
				}
				set
				{
					this.m_owner.m_currentScenarioButton = value;
				}
			}

			// Token: 0x17003DC3 RID: 15811
			// (get) Token: 0x06015103 RID: 86275 RVA: 0x00556328 File Offset: 0x00554528
			// (set) Token: 0x06015104 RID: 86276 RVA: 0x00556338 File Offset: 0x00554538
			public Text m_currentScenarioNameText
			{
				get
				{
					return this.m_owner.m_currentScenarioNameText;
				}
				set
				{
					this.m_owner.m_currentScenarioNameText = value;
				}
			}

			// Token: 0x17003DC4 RID: 15812
			// (get) Token: 0x06015105 RID: 86277 RVA: 0x00556348 File Offset: 0x00554548
			// (set) Token: 0x06015106 RID: 86278 RVA: 0x00556358 File Offset: 0x00554558
			public CommonUIStateController m_newScenarioUIStateController
			{
				get
				{
					return this.m_owner.m_newScenarioUIStateController;
				}
				set
				{
					this.m_owner.m_newScenarioUIStateController = value;
				}
			}

			// Token: 0x17003DC5 RID: 15813
			// (get) Token: 0x06015107 RID: 86279 RVA: 0x00556368 File Offset: 0x00554568
			// (set) Token: 0x06015108 RID: 86280 RVA: 0x00556378 File Offset: 0x00554578
			public Text m_newScenarioNameText
			{
				get
				{
					return this.m_owner.m_newScenarioNameText;
				}
				set
				{
					this.m_owner.m_newScenarioNameText = value;
				}
			}

			// Token: 0x17003DC6 RID: 15814
			// (get) Token: 0x06015109 RID: 86281 RVA: 0x00556388 File Offset: 0x00554588
			// (set) Token: 0x0601510A RID: 86282 RVA: 0x00556398 File Offset: 0x00554598
			public CommonUIStateController m_enterScenarioUIStateController
			{
				get
				{
					return this.m_owner.m_enterScenarioUIStateController;
				}
				set
				{
					this.m_owner.m_enterScenarioUIStateController = value;
				}
			}

			// Token: 0x17003DC7 RID: 15815
			// (get) Token: 0x0601510B RID: 86283 RVA: 0x005563A8 File Offset: 0x005545A8
			// (set) Token: 0x0601510C RID: 86284 RVA: 0x005563B8 File Offset: 0x005545B8
			public Text m_enterScenarioChapterText
			{
				get
				{
					return this.m_owner.m_enterScenarioChapterText;
				}
				set
				{
					this.m_owner.m_enterScenarioChapterText = value;
				}
			}

			// Token: 0x17003DC8 RID: 15816
			// (get) Token: 0x0601510D RID: 86285 RVA: 0x005563C8 File Offset: 0x005545C8
			// (set) Token: 0x0601510E RID: 86286 RVA: 0x005563D8 File Offset: 0x005545D8
			public Text m_enterScenarioNameText
			{
				get
				{
					return this.m_owner.m_enterScenarioNameText;
				}
				set
				{
					this.m_owner.m_enterScenarioNameText = value;
				}
			}

			// Token: 0x17003DC9 RID: 15817
			// (get) Token: 0x0601510F RID: 86287 RVA: 0x005563E8 File Offset: 0x005545E8
			// (set) Token: 0x06015110 RID: 86288 RVA: 0x005563F8 File Offset: 0x005545F8
			public CommonUIStateController m_enterMonsterUIStateController
			{
				get
				{
					return this.m_owner.m_enterMonsterUIStateController;
				}
				set
				{
					this.m_owner.m_enterMonsterUIStateController = value;
				}
			}

			// Token: 0x17003DCA RID: 15818
			// (get) Token: 0x06015111 RID: 86289 RVA: 0x00556408 File Offset: 0x00554608
			// (set) Token: 0x06015112 RID: 86290 RVA: 0x00556418 File Offset: 0x00554618
			public RectTransform m_eventListTransform
			{
				get
				{
					return this.m_owner.m_eventListTransform;
				}
				set
				{
					this.m_owner.m_eventListTransform = value;
				}
			}

			// Token: 0x17003DCB RID: 15819
			// (get) Token: 0x06015113 RID: 86291 RVA: 0x00556428 File Offset: 0x00554628
			// (set) Token: 0x06015114 RID: 86292 RVA: 0x00556438 File Offset: 0x00554638
			public CommonUIStateController m_eventListUIStateController
			{
				get
				{
					return this.m_owner.m_eventListUIStateController;
				}
				set
				{
					this.m_owner.m_eventListUIStateController = value;
				}
			}

			// Token: 0x17003DCC RID: 15820
			// (get) Token: 0x06015115 RID: 86293 RVA: 0x00556448 File Offset: 0x00554648
			// (set) Token: 0x06015116 RID: 86294 RVA: 0x00556458 File Offset: 0x00554658
			public ScrollRect m_randomEventScrollRect
			{
				get
				{
					return this.m_owner.m_randomEventScrollRect;
				}
				set
				{
					this.m_owner.m_randomEventScrollRect = value;
				}
			}

			// Token: 0x17003DCD RID: 15821
			// (get) Token: 0x06015117 RID: 86295 RVA: 0x00556468 File Offset: 0x00554668
			// (set) Token: 0x06015118 RID: 86296 RVA: 0x00556478 File Offset: 0x00554678
			public Button m_eventListBackgroundButton
			{
				get
				{
					return this.m_owner.m_eventListBackgroundButton;
				}
				set
				{
					this.m_owner.m_eventListBackgroundButton = value;
				}
			}

			// Token: 0x17003DCE RID: 15822
			// (get) Token: 0x06015119 RID: 86297 RVA: 0x00556488 File Offset: 0x00554688
			// (set) Token: 0x0601511A RID: 86298 RVA: 0x00556498 File Offset: 0x00554698
			public CommonUIStateController m_pastScenarioListUIStateController
			{
				get
				{
					return this.m_owner.m_pastScenarioListUIStateController;
				}
				set
				{
					this.m_owner.m_pastScenarioListUIStateController = value;
				}
			}

			// Token: 0x17003DCF RID: 15823
			// (get) Token: 0x0601511B RID: 86299 RVA: 0x005564A8 File Offset: 0x005546A8
			// (set) Token: 0x0601511C RID: 86300 RVA: 0x005564B8 File Offset: 0x005546B8
			public Button m_pastScenarioListBackgroundButton
			{
				get
				{
					return this.m_owner.m_pastScenarioListBackgroundButton;
				}
				set
				{
					this.m_owner.m_pastScenarioListBackgroundButton = value;
				}
			}

			// Token: 0x17003DD0 RID: 15824
			// (get) Token: 0x0601511D RID: 86301 RVA: 0x005564C8 File Offset: 0x005546C8
			// (set) Token: 0x0601511E RID: 86302 RVA: 0x005564D8 File Offset: 0x005546D8
			public ScrollRect m_pastScenarioListScrollRect
			{
				get
				{
					return this.m_owner.m_pastScenarioListScrollRect;
				}
				set
				{
					this.m_owner.m_pastScenarioListScrollRect = value;
				}
			}

			// Token: 0x17003DD1 RID: 15825
			// (get) Token: 0x0601511F RID: 86303 RVA: 0x005564E8 File Offset: 0x005546E8
			// (set) Token: 0x06015120 RID: 86304 RVA: 0x005564F8 File Offset: 0x005546F8
			public CommonUIStateController m_unlockScenarioUIStateController
			{
				get
				{
					return this.m_owner.m_unlockScenarioUIStateController;
				}
				set
				{
					this.m_owner.m_unlockScenarioUIStateController = value;
				}
			}

			// Token: 0x17003DD2 RID: 15826
			// (get) Token: 0x06015121 RID: 86305 RVA: 0x00556508 File Offset: 0x00554708
			// (set) Token: 0x06015122 RID: 86306 RVA: 0x00556518 File Offset: 0x00554718
			public Button m_unlockScenarioBackgroundButton
			{
				get
				{
					return this.m_owner.m_unlockScenarioBackgroundButton;
				}
				set
				{
					this.m_owner.m_unlockScenarioBackgroundButton = value;
				}
			}

			// Token: 0x17003DD3 RID: 15827
			// (get) Token: 0x06015123 RID: 86307 RVA: 0x00556528 File Offset: 0x00554728
			// (set) Token: 0x06015124 RID: 86308 RVA: 0x00556538 File Offset: 0x00554738
			public Text m_unlockScenarioTitleText
			{
				get
				{
					return this.m_owner.m_unlockScenarioTitleText;
				}
				set
				{
					this.m_owner.m_unlockScenarioTitleText = value;
				}
			}

			// Token: 0x17003DD4 RID: 15828
			// (get) Token: 0x06015125 RID: 86309 RVA: 0x00556548 File Offset: 0x00554748
			// (set) Token: 0x06015126 RID: 86310 RVA: 0x00556558 File Offset: 0x00554758
			public Text m_unlockScenarioText
			{
				get
				{
					return this.m_owner.m_unlockScenarioText;
				}
				set
				{
					this.m_owner.m_unlockScenarioText = value;
				}
			}

			// Token: 0x17003DD5 RID: 15829
			// (get) Token: 0x06015127 RID: 86311 RVA: 0x00556568 File Offset: 0x00554768
			// (set) Token: 0x06015128 RID: 86312 RVA: 0x00556578 File Offset: 0x00554778
			public Button m_unlockScenarioGotoButton
			{
				get
				{
					return this.m_owner.m_unlockScenarioGotoButton;
				}
				set
				{
					this.m_owner.m_unlockScenarioGotoButton = value;
				}
			}

			// Token: 0x17003DD6 RID: 15830
			// (get) Token: 0x06015129 RID: 86313 RVA: 0x00556588 File Offset: 0x00554788
			// (set) Token: 0x0601512A RID: 86314 RVA: 0x00556598 File Offset: 0x00554798
			public Button m_mainButton
			{
				get
				{
					return this.m_owner.m_mainButton;
				}
				set
				{
					this.m_owner.m_mainButton = value;
				}
			}

			// Token: 0x17003DD7 RID: 15831
			// (get) Token: 0x0601512B RID: 86315 RVA: 0x005565A8 File Offset: 0x005547A8
			// (set) Token: 0x0601512C RID: 86316 RVA: 0x005565B8 File Offset: 0x005547B8
			public GameObject m_mainButtonOnGameObject
			{
				get
				{
					return this.m_owner.m_mainButtonOnGameObject;
				}
				set
				{
					this.m_owner.m_mainButtonOnGameObject = value;
				}
			}

			// Token: 0x17003DD8 RID: 15832
			// (get) Token: 0x0601512D RID: 86317 RVA: 0x005565C8 File Offset: 0x005547C8
			// (set) Token: 0x0601512E RID: 86318 RVA: 0x005565D8 File Offset: 0x005547D8
			public GameObject m_mainButtonOffGameObject
			{
				get
				{
					return this.m_owner.m_mainButtonOffGameObject;
				}
				set
				{
					this.m_owner.m_mainButtonOffGameObject = value;
				}
			}

			// Token: 0x17003DD9 RID: 15833
			// (get) Token: 0x0601512F RID: 86319 RVA: 0x005565E8 File Offset: 0x005547E8
			// (set) Token: 0x06015130 RID: 86320 RVA: 0x005565F8 File Offset: 0x005547F8
			public RectTransform m_margin1Transform
			{
				get
				{
					return this.m_owner.m_margin1Transform;
				}
				set
				{
					this.m_owner.m_margin1Transform = value;
				}
			}

			// Token: 0x17003DDA RID: 15834
			// (get) Token: 0x06015131 RID: 86321 RVA: 0x00556608 File Offset: 0x00554808
			// (set) Token: 0x06015132 RID: 86322 RVA: 0x00556618 File Offset: 0x00554818
			public CommonUIStateController m_mainButtonBarUIStateController
			{
				get
				{
					return this.m_owner.m_mainButtonBarUIStateController;
				}
				set
				{
					this.m_owner.m_mainButtonBarUIStateController = value;
				}
			}

			// Token: 0x17003DDB RID: 15835
			// (get) Token: 0x06015133 RID: 86323 RVA: 0x00556628 File Offset: 0x00554828
			// (set) Token: 0x06015134 RID: 86324 RVA: 0x00556638 File Offset: 0x00554838
			public Button m_heroButton
			{
				get
				{
					return this.m_owner.m_heroButton;
				}
				set
				{
					this.m_owner.m_heroButton = value;
				}
			}

			// Token: 0x17003DDC RID: 15836
			// (get) Token: 0x06015135 RID: 86325 RVA: 0x00556648 File Offset: 0x00554848
			// (set) Token: 0x06015136 RID: 86326 RVA: 0x00556658 File Offset: 0x00554858
			public GameObject m_heroButtonRedMarkGameObject
			{
				get
				{
					return this.m_owner.m_heroButtonRedMarkGameObject;
				}
				set
				{
					this.m_owner.m_heroButtonRedMarkGameObject = value;
				}
			}

			// Token: 0x17003DDD RID: 15837
			// (get) Token: 0x06015137 RID: 86327 RVA: 0x00556668 File Offset: 0x00554868
			// (set) Token: 0x06015138 RID: 86328 RVA: 0x00556678 File Offset: 0x00554878
			public Button m_bagButton
			{
				get
				{
					return this.m_owner.m_bagButton;
				}
				set
				{
					this.m_owner.m_bagButton = value;
				}
			}

			// Token: 0x17003DDE RID: 15838
			// (get) Token: 0x06015139 RID: 86329 RVA: 0x00556688 File Offset: 0x00554888
			// (set) Token: 0x0601513A RID: 86330 RVA: 0x00556698 File Offset: 0x00554898
			public Button m_missionButton
			{
				get
				{
					return this.m_owner.m_missionButton;
				}
				set
				{
					this.m_owner.m_missionButton = value;
				}
			}

			// Token: 0x17003DDF RID: 15839
			// (get) Token: 0x0601513B RID: 86331 RVA: 0x005566A8 File Offset: 0x005548A8
			// (set) Token: 0x0601513C RID: 86332 RVA: 0x005566B8 File Offset: 0x005548B8
			public GameObject m_missionButtonRedMarkGameObject
			{
				get
				{
					return this.m_owner.m_missionButtonRedMarkGameObject;
				}
				set
				{
					this.m_owner.m_missionButtonRedMarkGameObject = value;
				}
			}

			// Token: 0x17003DE0 RID: 15840
			// (get) Token: 0x0601513D RID: 86333 RVA: 0x005566C8 File Offset: 0x005548C8
			// (set) Token: 0x0601513E RID: 86334 RVA: 0x005566D8 File Offset: 0x005548D8
			public Button m_fetterButton
			{
				get
				{
					return this.m_owner.m_fetterButton;
				}
				set
				{
					this.m_owner.m_fetterButton = value;
				}
			}

			// Token: 0x17003DE1 RID: 15841
			// (get) Token: 0x0601513F RID: 86335 RVA: 0x005566E8 File Offset: 0x005548E8
			// (set) Token: 0x06015140 RID: 86336 RVA: 0x005566F8 File Offset: 0x005548F8
			public GameObject m_fetterButtonRedMarkGameObject
			{
				get
				{
					return this.m_owner.m_fetterButtonRedMarkGameObject;
				}
				set
				{
					this.m_owner.m_fetterButtonRedMarkGameObject = value;
				}
			}

			// Token: 0x17003DE2 RID: 15842
			// (get) Token: 0x06015141 RID: 86337 RVA: 0x00556708 File Offset: 0x00554908
			// (set) Token: 0x06015142 RID: 86338 RVA: 0x00556718 File Offset: 0x00554918
			public Button m_storeButton
			{
				get
				{
					return this.m_owner.m_storeButton;
				}
				set
				{
					this.m_owner.m_storeButton = value;
				}
			}

			// Token: 0x17003DE3 RID: 15843
			// (get) Token: 0x06015143 RID: 86339 RVA: 0x00556728 File Offset: 0x00554928
			// (set) Token: 0x06015144 RID: 86340 RVA: 0x00556738 File Offset: 0x00554938
			public Button m_selectCardButton
			{
				get
				{
					return this.m_owner.m_selectCardButton;
				}
				set
				{
					this.m_owner.m_selectCardButton = value;
				}
			}

			// Token: 0x17003DE4 RID: 15844
			// (get) Token: 0x06015145 RID: 86341 RVA: 0x00556748 File Offset: 0x00554948
			// (set) Token: 0x06015146 RID: 86342 RVA: 0x00556758 File Offset: 0x00554958
			public Button m_drillButton
			{
				get
				{
					return this.m_owner.m_drillButton;
				}
				set
				{
					this.m_owner.m_drillButton = value;
				}
			}

			// Token: 0x17003DE5 RID: 15845
			// (get) Token: 0x06015147 RID: 86343 RVA: 0x00556768 File Offset: 0x00554968
			// (set) Token: 0x06015148 RID: 86344 RVA: 0x00556778 File Offset: 0x00554978
			public GameObject m_drillButtonRedMark
			{
				get
				{
					return this.m_owner.m_drillButtonRedMark;
				}
				set
				{
					this.m_owner.m_drillButtonRedMark = value;
				}
			}

			// Token: 0x17003DE6 RID: 15846
			// (get) Token: 0x06015149 RID: 86345 RVA: 0x00556788 File Offset: 0x00554988
			// (set) Token: 0x0601514A RID: 86346 RVA: 0x00556798 File Offset: 0x00554998
			public Button m_guildButton
			{
				get
				{
					return this.m_owner.m_guildButton;
				}
				set
				{
					this.m_owner.m_guildButton = value;
				}
			}

			// Token: 0x17003DE7 RID: 15847
			// (get) Token: 0x0601514B RID: 86347 RVA: 0x005567A8 File Offset: 0x005549A8
			// (set) Token: 0x0601514C RID: 86348 RVA: 0x005567B8 File Offset: 0x005549B8
			public GameObject m_sociatyButtonRedMark
			{
				get
				{
					return this.m_owner.m_sociatyButtonRedMark;
				}
				set
				{
					this.m_owner.m_sociatyButtonRedMark = value;
				}
			}

			// Token: 0x17003DE8 RID: 15848
			// (get) Token: 0x0601514D RID: 86349 RVA: 0x005567C8 File Offset: 0x005549C8
			// (set) Token: 0x0601514E RID: 86350 RVA: 0x005567D8 File Offset: 0x005549D8
			public RectTransform m_marginTransform
			{
				get
				{
					return this.m_owner.m_marginTransform;
				}
				set
				{
					this.m_owner.m_marginTransform = value;
				}
			}

			// Token: 0x17003DE9 RID: 15849
			// (get) Token: 0x0601514F RID: 86351 RVA: 0x005567E8 File Offset: 0x005549E8
			// (set) Token: 0x06015150 RID: 86352 RVA: 0x005567F8 File Offset: 0x005549F8
			public GameObject m_rightGameObject
			{
				get
				{
					return this.m_owner.m_rightGameObject;
				}
				set
				{
					this.m_owner.m_rightGameObject = value;
				}
			}

			// Token: 0x17003DEA RID: 15850
			// (get) Token: 0x06015151 RID: 86353 RVA: 0x00556808 File Offset: 0x00554A08
			// (set) Token: 0x06015152 RID: 86354 RVA: 0x00556818 File Offset: 0x00554A18
			public Button m_eventButton
			{
				get
				{
					return this.m_owner.m_eventButton;
				}
				set
				{
					this.m_owner.m_eventButton = value;
				}
			}

			// Token: 0x17003DEB RID: 15851
			// (get) Token: 0x06015153 RID: 86355 RVA: 0x00556828 File Offset: 0x00554A28
			// (set) Token: 0x06015154 RID: 86356 RVA: 0x00556838 File Offset: 0x00554A38
			public GameObject m_eventButtonRedMarkGameObject
			{
				get
				{
					return this.m_owner.m_eventButtonRedMarkGameObject;
				}
				set
				{
					this.m_owner.m_eventButtonRedMarkGameObject = value;
				}
			}

			// Token: 0x17003DEC RID: 15852
			// (get) Token: 0x06015155 RID: 86357 RVA: 0x00556848 File Offset: 0x00554A48
			// (set) Token: 0x06015156 RID: 86358 RVA: 0x00556858 File Offset: 0x00554A58
			public Button m_unchartedButton
			{
				get
				{
					return this.m_owner.m_unchartedButton;
				}
				set
				{
					this.m_owner.m_unchartedButton = value;
				}
			}

			// Token: 0x17003DED RID: 15853
			// (get) Token: 0x06015157 RID: 86359 RVA: 0x00556868 File Offset: 0x00554A68
			// (set) Token: 0x06015158 RID: 86360 RVA: 0x00556878 File Offset: 0x00554A78
			public Button m_arenaButton
			{
				get
				{
					return this.m_owner.m_arenaButton;
				}
				set
				{
					this.m_owner.m_arenaButton = value;
				}
			}

			// Token: 0x17003DEE RID: 15854
			// (get) Token: 0x06015159 RID: 86361 RVA: 0x00556888 File Offset: 0x00554A88
			// (set) Token: 0x0601515A RID: 86362 RVA: 0x00556898 File Offset: 0x00554A98
			public Button m_riftButton
			{
				get
				{
					return this.m_owner.m_riftButton;
				}
				set
				{
					this.m_owner.m_riftButton = value;
				}
			}

			// Token: 0x17003DEF RID: 15855
			// (get) Token: 0x0601515B RID: 86363 RVA: 0x005568A8 File Offset: 0x00554AA8
			// (set) Token: 0x0601515C RID: 86364 RVA: 0x005568B8 File Offset: 0x00554AB8
			public Button m_testButton
			{
				get
				{
					return this.m_owner.m_testButton;
				}
				set
				{
					this.m_owner.m_testButton = value;
				}
			}

			// Token: 0x17003DF0 RID: 15856
			// (get) Token: 0x0601515D RID: 86365 RVA: 0x005568C8 File Offset: 0x00554AC8
			// (set) Token: 0x0601515E RID: 86366 RVA: 0x005568D8 File Offset: 0x00554AD8
			public Button m_cooperateBattleButton
			{
				get
				{
					return this.m_owner.m_cooperateBattleButton;
				}
				set
				{
					this.m_owner.m_cooperateBattleButton = value;
				}
			}

			// Token: 0x17003DF1 RID: 15857
			// (get) Token: 0x0601515F RID: 86367 RVA: 0x005568E8 File Offset: 0x00554AE8
			// (set) Token: 0x06015160 RID: 86368 RVA: 0x005568F8 File Offset: 0x00554AF8
			public GameObject m_leftGameObject
			{
				get
				{
					return this.m_owner.m_leftGameObject;
				}
				set
				{
					this.m_owner.m_leftGameObject = value;
				}
			}

			// Token: 0x17003DF2 RID: 15858
			// (get) Token: 0x06015161 RID: 86369 RVA: 0x00556908 File Offset: 0x00554B08
			// (set) Token: 0x06015162 RID: 86370 RVA: 0x00556918 File Offset: 0x00554B18
			public Button m_friendButton
			{
				get
				{
					return this.m_owner.m_friendButton;
				}
				set
				{
					this.m_owner.m_friendButton = value;
				}
			}

			// Token: 0x17003DF3 RID: 15859
			// (get) Token: 0x06015163 RID: 86371 RVA: 0x00556928 File Offset: 0x00554B28
			// (set) Token: 0x06015164 RID: 86372 RVA: 0x00556938 File Offset: 0x00554B38
			public GameObject m_friendButtonRedMark
			{
				get
				{
					return this.m_owner.m_friendButtonRedMark;
				}
				set
				{
					this.m_owner.m_friendButtonRedMark = value;
				}
			}

			// Token: 0x17003DF4 RID: 15860
			// (get) Token: 0x06015165 RID: 86373 RVA: 0x00556948 File Offset: 0x00554B48
			// (set) Token: 0x06015166 RID: 86374 RVA: 0x00556958 File Offset: 0x00554B58
			public Button m_mailButton
			{
				get
				{
					return this.m_owner.m_mailButton;
				}
				set
				{
					this.m_owner.m_mailButton = value;
				}
			}

			// Token: 0x17003DF5 RID: 15861
			// (get) Token: 0x06015167 RID: 86375 RVA: 0x00556968 File Offset: 0x00554B68
			// (set) Token: 0x06015168 RID: 86376 RVA: 0x00556978 File Offset: 0x00554B78
			public Text m_unreadMailCountText
			{
				get
				{
					return this.m_owner.m_unreadMailCountText;
				}
				set
				{
					this.m_owner.m_unreadMailCountText = value;
				}
			}

			// Token: 0x17003DF6 RID: 15862
			// (get) Token: 0x06015169 RID: 86377 RVA: 0x00556988 File Offset: 0x00554B88
			// (set) Token: 0x0601516A RID: 86378 RVA: 0x00556998 File Offset: 0x00554B98
			public Button m_chatButton
			{
				get
				{
					return this.m_owner.m_chatButton;
				}
				set
				{
					this.m_owner.m_chatButton = value;
				}
			}

			// Token: 0x17003DF7 RID: 15863
			// (get) Token: 0x0601516B RID: 86379 RVA: 0x005569A8 File Offset: 0x00554BA8
			// (set) Token: 0x0601516C RID: 86380 RVA: 0x005569B8 File Offset: 0x00554BB8
			public Text m_newChatCountText
			{
				get
				{
					return this.m_owner.m_newChatCountText;
				}
				set
				{
					this.m_owner.m_newChatCountText = value;
				}
			}

			// Token: 0x17003DF8 RID: 15864
			// (get) Token: 0x0601516D RID: 86381 RVA: 0x005569C8 File Offset: 0x00554BC8
			// (set) Token: 0x0601516E RID: 86382 RVA: 0x005569D8 File Offset: 0x00554BD8
			public Button m_rankButton
			{
				get
				{
					return this.m_owner.m_rankButton;
				}
				set
				{
					this.m_owner.m_rankButton = value;
				}
			}

			// Token: 0x17003DF9 RID: 15865
			// (get) Token: 0x0601516F RID: 86383 RVA: 0x005569E8 File Offset: 0x00554BE8
			// (set) Token: 0x06015170 RID: 86384 RVA: 0x005569F8 File Offset: 0x00554BF8
			public Button m_activityButton
			{
				get
				{
					return this.m_owner.m_activityButton;
				}
				set
				{
					this.m_owner.m_activityButton = value;
				}
			}

			// Token: 0x17003DFA RID: 15866
			// (get) Token: 0x06015171 RID: 86385 RVA: 0x00556A08 File Offset: 0x00554C08
			// (set) Token: 0x06015172 RID: 86386 RVA: 0x00556A18 File Offset: 0x00554C18
			public GameObject m_activityRedMarkGameObject
			{
				get
				{
					return this.m_owner.m_activityRedMarkGameObject;
				}
				set
				{
					this.m_owner.m_activityRedMarkGameObject = value;
				}
			}

			// Token: 0x17003DFB RID: 15867
			// (get) Token: 0x06015173 RID: 86387 RVA: 0x00556A28 File Offset: 0x00554C28
			// (set) Token: 0x06015174 RID: 86388 RVA: 0x00556A38 File Offset: 0x00554C38
			public Button m_investigationButton
			{
				get
				{
					return this.m_owner.m_investigationButton;
				}
				set
				{
					this.m_owner.m_investigationButton = value;
				}
			}

			// Token: 0x17003DFC RID: 15868
			// (get) Token: 0x06015175 RID: 86389 RVA: 0x00556A48 File Offset: 0x00554C48
			// (set) Token: 0x06015176 RID: 86390 RVA: 0x00556A58 File Offset: 0x00554C58
			public GameObject m_investigationButtonRedMark
			{
				get
				{
					return this.m_owner.m_investigationButtonRedMark;
				}
				set
				{
					this.m_owner.m_investigationButtonRedMark = value;
				}
			}

			// Token: 0x17003DFD RID: 15869
			// (get) Token: 0x06015177 RID: 86391 RVA: 0x00556A68 File Offset: 0x00554C68
			// (set) Token: 0x06015178 RID: 86392 RVA: 0x00556A78 File Offset: 0x00554C78
			public Button m_YYBButton
			{
				get
				{
					return this.m_owner.m_YYBButton;
				}
				set
				{
					this.m_owner.m_YYBButton = value;
				}
			}

			// Token: 0x17003DFE RID: 15870
			// (get) Token: 0x06015179 RID: 86393 RVA: 0x00556A88 File Offset: 0x00554C88
			// (set) Token: 0x0601517A RID: 86394 RVA: 0x00556A98 File Offset: 0x00554C98
			public Button m_OppoButton
			{
				get
				{
					return this.m_owner.m_OppoButton;
				}
				set
				{
					this.m_owner.m_OppoButton = value;
				}
			}

			// Token: 0x17003DFF RID: 15871
			// (get) Token: 0x0601517B RID: 86395 RVA: 0x00556AA8 File Offset: 0x00554CA8
			// (set) Token: 0x0601517C RID: 86396 RVA: 0x00556AB8 File Offset: 0x00554CB8
			public Button m_openServiceActivityButton
			{
				get
				{
					return this.m_owner.m_openServiceActivityButton;
				}
				set
				{
					this.m_owner.m_openServiceActivityButton = value;
				}
			}

			// Token: 0x17003E00 RID: 15872
			// (get) Token: 0x0601517D RID: 86397 RVA: 0x00556AC8 File Offset: 0x00554CC8
			// (set) Token: 0x0601517E RID: 86398 RVA: 0x00556AD8 File Offset: 0x00554CD8
			public GameObject m_openServiceActivityButtonRedMark
			{
				get
				{
					return this.m_owner.m_openServiceActivityButtonRedMark;
				}
				set
				{
					this.m_owner.m_openServiceActivityButtonRedMark = value;
				}
			}

			// Token: 0x17003E01 RID: 15873
			// (get) Token: 0x0601517F RID: 86399 RVA: 0x00556AE8 File Offset: 0x00554CE8
			// (set) Token: 0x06015180 RID: 86400 RVA: 0x00556AF8 File Offset: 0x00554CF8
			public Button m_monthCardButton
			{
				get
				{
					return this.m_owner.m_monthCardButton;
				}
				set
				{
					this.m_owner.m_monthCardButton = value;
				}
			}

			// Token: 0x17003E02 RID: 15874
			// (get) Token: 0x06015181 RID: 86401 RVA: 0x00556B08 File Offset: 0x00554D08
			// (set) Token: 0x06015182 RID: 86402 RVA: 0x00556B18 File Offset: 0x00554D18
			public CommonUIStateController m_monthCardPanelUIStateController
			{
				get
				{
					return this.m_owner.m_monthCardPanelUIStateController;
				}
				set
				{
					this.m_owner.m_monthCardPanelUIStateController = value;
				}
			}

			// Token: 0x17003E03 RID: 15875
			// (get) Token: 0x06015183 RID: 86403 RVA: 0x00556B28 File Offset: 0x00554D28
			// (set) Token: 0x06015184 RID: 86404 RVA: 0x00556B38 File Offset: 0x00554D38
			public GameObject m_monthCardItemGroupObj
			{
				get
				{
					return this.m_owner.m_monthCardItemGroupObj;
				}
				set
				{
					this.m_owner.m_monthCardItemGroupObj = value;
				}
			}

			// Token: 0x17003E04 RID: 15876
			// (get) Token: 0x06015185 RID: 86405 RVA: 0x00556B48 File Offset: 0x00554D48
			// (set) Token: 0x06015186 RID: 86406 RVA: 0x00556B58 File Offset: 0x00554D58
			public Button m_monthCardCloseButton
			{
				get
				{
					return this.m_owner.m_monthCardCloseButton;
				}
				set
				{
					this.m_owner.m_monthCardCloseButton = value;
				}
			}

			// Token: 0x17003E05 RID: 15877
			// (get) Token: 0x06015187 RID: 86407 RVA: 0x00556B68 File Offset: 0x00554D68
			// (set) Token: 0x06015188 RID: 86408 RVA: 0x00556B78 File Offset: 0x00554D78
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

			// Token: 0x17003E06 RID: 15878
			// (get) Token: 0x06015189 RID: 86409 RVA: 0x00556B88 File Offset: 0x00554D88
			// (set) Token: 0x0601518A RID: 86410 RVA: 0x00556B98 File Offset: 0x00554D98
			public GameObject m_randomEventListItemPrefab
			{
				get
				{
					return this.m_owner.m_randomEventListItemPrefab;
				}
				set
				{
					this.m_owner.m_randomEventListItemPrefab = value;
				}
			}

			// Token: 0x17003E07 RID: 15879
			// (get) Token: 0x0601518B RID: 86411 RVA: 0x00556BA8 File Offset: 0x00554DA8
			// (set) Token: 0x0601518C RID: 86412 RVA: 0x00556BB8 File Offset: 0x00554DB8
			public GameObject m_pastScenarioListItemPrefab
			{
				get
				{
					return this.m_owner.m_pastScenarioListItemPrefab;
				}
				set
				{
					this.m_owner.m_pastScenarioListItemPrefab = value;
				}
			}

			// Token: 0x17003E08 RID: 15880
			// (get) Token: 0x0601518D RID: 86413 RVA: 0x00556BC8 File Offset: 0x00554DC8
			// (set) Token: 0x0601518E RID: 86414 RVA: 0x00556BD8 File Offset: 0x00554DD8
			public GameObject m_monthCardItemPrefab
			{
				get
				{
					return this.m_owner.m_monthCardItemPrefab;
				}
				set
				{
					this.m_owner.m_monthCardItemPrefab = value;
				}
			}

			// Token: 0x17003E09 RID: 15881
			// (get) Token: 0x0601518F RID: 86415 RVA: 0x00556BE8 File Offset: 0x00554DE8
			// (set) Token: 0x06015190 RID: 86416 RVA: 0x00556BF8 File Offset: 0x00554DF8
			public ConfigDataRiftLevelInfo m_gotoRiftLevelInfo
			{
				get
				{
					return this.m_owner.m_gotoRiftLevelInfo;
				}
				set
				{
					this.m_owner.m_gotoRiftLevelInfo = value;
				}
			}

			// Token: 0x17003E0A RID: 15882
			// (get) Token: 0x06015191 RID: 86417 RVA: 0x00556C08 File Offset: 0x00554E08
			// (set) Token: 0x06015192 RID: 86418 RVA: 0x00556C18 File Offset: 0x00554E18
			public int m_developerClickCount
			{
				get
				{
					return this.m_owner.m_developerClickCount;
				}
				set
				{
					this.m_owner.m_developerClickCount = value;
				}
			}

			// Token: 0x17003E0B RID: 15883
			// (get) Token: 0x06015193 RID: 86419 RVA: 0x00556C28 File Offset: 0x00554E28
			// (set) Token: 0x06015194 RID: 86420 RVA: 0x00556C38 File Offset: 0x00554E38
			public Color m_fogColor
			{
				get
				{
					return this.m_owner.m_fogColor;
				}
				set
				{
					this.m_owner.m_fogColor = value;
				}
			}

			// Token: 0x17003E0C RID: 15884
			// (get) Token: 0x06015195 RID: 86421 RVA: 0x00556C48 File Offset: 0x00554E48
			// (set) Token: 0x06015196 RID: 86422 RVA: 0x00556C58 File Offset: 0x00554E58
			public List<WorldEventListItemUIController> m_randomEventListItems
			{
				get
				{
					return this.m_owner.m_randomEventListItems;
				}
				set
				{
					this.m_owner.m_randomEventListItems = value;
				}
			}

			// Token: 0x17003E0D RID: 15885
			// (get) Token: 0x06015197 RID: 86423 RVA: 0x00556C68 File Offset: 0x00554E68
			// (set) Token: 0x06015198 RID: 86424 RVA: 0x00556C78 File Offset: 0x00554E78
			public List<PastScenarioListItemUIController> m_pastScenarioListItems
			{
				get
				{
					return this.m_owner.m_pastScenarioListItems;
				}
				set
				{
					this.m_owner.m_pastScenarioListItems = value;
				}
			}

			// Token: 0x17003E0E RID: 15886
			// (get) Token: 0x06015199 RID: 86425 RVA: 0x00556C88 File Offset: 0x00554E88
			// (set) Token: 0x0601519A RID: 86426 RVA: 0x00556C98 File Offset: 0x00554E98
			public List<GameObject> m_userGuideDialogHideGameObjects
			{
				get
				{
					return this.m_owner.m_userGuideDialogHideGameObjects;
				}
				set
				{
					this.m_owner.m_userGuideDialogHideGameObjects = value;
				}
			}

			// Token: 0x17003E0F RID: 15887
			// (get) Token: 0x0601519B RID: 86427 RVA: 0x00556CA8 File Offset: 0x00554EA8
			// (set) Token: 0x0601519C RID: 86428 RVA: 0x00556CB8 File Offset: 0x00554EB8
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

			// Token: 0x0601519D RID: 86429 RVA: 0x00556CC8 File Offset: 0x00554EC8
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0601519E RID: 86430 RVA: 0x00556CD8 File Offset: 0x00554ED8
			public void OnEnable()
			{
				this.m_owner.OnEnable();
			}

			// Token: 0x0601519F RID: 86431 RVA: 0x00556CE8 File Offset: 0x00554EE8
			public void UpdateDeveloperMode()
			{
				this.m_owner.UpdateDeveloperMode();
			}

			// Token: 0x060151A0 RID: 86432 RVA: 0x00556CF8 File Offset: 0x00554EF8
			public IEnumerator Co_EnterMonster(Action onEnd)
			{
				return this.m_owner.Co_EnterMonster(onEnd);
			}

			// Token: 0x060151A1 RID: 86433 RVA: 0x00556D08 File Offset: 0x00554F08
			public void DeveloperModeClick()
			{
				this.m_owner.DeveloperModeClick();
			}

			// Token: 0x060151A2 RID: 86434 RVA: 0x00556D18 File Offset: 0x00554F18
			public void OnCompassButtonClick()
			{
				this.m_owner.OnCompassButtonClick();
			}

			// Token: 0x060151A3 RID: 86435 RVA: 0x00556D28 File Offset: 0x00554F28
			public void OnCurrentScenarioButtonClick()
			{
				this.m_owner.OnCurrentScenarioButtonClick();
			}

			// Token: 0x060151A4 RID: 86436 RVA: 0x00556D38 File Offset: 0x00554F38
			public void OnUnlockScenarioBackgroundButtonClick()
			{
				this.m_owner.OnUnlockScenarioBackgroundButtonClick();
			}

			// Token: 0x060151A5 RID: 86437 RVA: 0x00556D48 File Offset: 0x00554F48
			public void OnUnlockScenarioGotoButtonClick()
			{
				this.m_owner.OnUnlockScenarioGotoButtonClick();
			}

			// Token: 0x060151A6 RID: 86438 RVA: 0x00556D58 File Offset: 0x00554F58
			public void OnMainButtonClick()
			{
				this.m_owner.OnMainButtonClick();
			}

			// Token: 0x060151A7 RID: 86439 RVA: 0x00556D68 File Offset: 0x00554F68
			public void OnPlayerButtonClick(UIControllerBase ctrl)
			{
				this.m_owner.OnPlayerButtonClick(ctrl);
			}

			// Token: 0x060151A8 RID: 86440 RVA: 0x00556D78 File Offset: 0x00554F78
			public void OnHeroButtonClick(UIControllerBase ctrl)
			{
				this.m_owner.OnHeroButtonClick(ctrl);
			}

			// Token: 0x060151A9 RID: 86441 RVA: 0x00556D88 File Offset: 0x00554F88
			public void OnBagButtonClick(UIControllerBase ctrl)
			{
				this.m_owner.OnBagButtonClick(ctrl);
			}

			// Token: 0x060151AA RID: 86442 RVA: 0x00556D98 File Offset: 0x00554F98
			public void OnSelectCardButtonClick(UIControllerBase ctrl)
			{
				this.m_owner.OnSelectCardButtonClick(ctrl);
			}

			// Token: 0x060151AB RID: 86443 RVA: 0x00556DA8 File Offset: 0x00554FA8
			public void OnMissionButtonClick(UIControllerBase ctrl)
			{
				this.m_owner.OnMissionButtonClick(ctrl);
			}

			// Token: 0x060151AC RID: 86444 RVA: 0x00556DB8 File Offset: 0x00554FB8
			public void OnFetterButtonClick(UIControllerBase ctrl)
			{
				this.m_owner.OnFetterButtonClick(ctrl);
			}

			// Token: 0x060151AD RID: 86445 RVA: 0x00556DC8 File Offset: 0x00554FC8
			public void OnStoreButtonClick(UIControllerBase ctrl)
			{
				this.m_owner.OnStoreButtonClick(ctrl);
			}

			// Token: 0x060151AE RID: 86446 RVA: 0x00556DD8 File Offset: 0x00554FD8
			public void OnDrillButtonClick(UIControllerBase ctrl)
			{
				this.m_owner.OnDrillButtonClick(ctrl);
			}

			// Token: 0x060151AF RID: 86447 RVA: 0x00556DE8 File Offset: 0x00554FE8
			public void OnFriendButtonClick(UIControllerBase ctrl)
			{
				this.m_owner.OnFriendButtonClick(ctrl);
			}

			// Token: 0x060151B0 RID: 86448 RVA: 0x00556DF8 File Offset: 0x00554FF8
			public void OnGuildButtonClick(UIControllerBase ctrl)
			{
				this.m_owner.OnGuildButtonClick(ctrl);
			}

			// Token: 0x060151B1 RID: 86449 RVA: 0x00556E08 File Offset: 0x00555008
			public void OnEventButtonClick(UIControllerBase ctrl)
			{
				this.m_owner.OnEventButtonClick(ctrl);
			}

			// Token: 0x060151B2 RID: 86450 RVA: 0x00556E18 File Offset: 0x00555018
			public void OnUnchartedButtonClick(UIControllerBase ctrl)
			{
				this.m_owner.OnUnchartedButtonClick(ctrl);
			}

			// Token: 0x060151B3 RID: 86451 RVA: 0x00556E28 File Offset: 0x00555028
			public void OnArenaButtonClick(UIControllerBase ctrl)
			{
				this.m_owner.OnArenaButtonClick(ctrl);
			}

			// Token: 0x060151B4 RID: 86452 RVA: 0x00556E38 File Offset: 0x00555038
			public void OnRiftButtonClick(UIControllerBase ctrl)
			{
				this.m_owner.OnRiftButtonClick(ctrl);
			}

			// Token: 0x060151B5 RID: 86453 RVA: 0x00556E48 File Offset: 0x00555048
			public void OnTestButtonClick(UIControllerBase ctrl)
			{
				this.m_owner.OnTestButtonClick(ctrl);
			}

			// Token: 0x060151B6 RID: 86454 RVA: 0x00556E58 File Offset: 0x00555058
			public void OnCooperateBattleButtonClick()
			{
				this.m_owner.OnCooperateBattleButtonClick();
			}

			// Token: 0x060151B7 RID: 86455 RVA: 0x00556E68 File Offset: 0x00555068
			public void OnMailButtonClick(UIControllerBase ctrl)
			{
				this.m_owner.OnMailButtonClick(ctrl);
			}

			// Token: 0x060151B8 RID: 86456 RVA: 0x00556E78 File Offset: 0x00555078
			public void OnChatButtonClick(UIControllerBase ctrl)
			{
				this.m_owner.OnChatButtonClick(ctrl);
			}

			// Token: 0x060151B9 RID: 86457 RVA: 0x00556E88 File Offset: 0x00555088
			public void OnRankButtonClick(UIControllerBase ctrl)
			{
				this.m_owner.OnRankButtonClick(ctrl);
			}

			// Token: 0x060151BA RID: 86458 RVA: 0x00556E98 File Offset: 0x00555098
			public void OnActivityButtonClick(UIControllerBase ctrl)
			{
				this.m_owner.OnActivityButtonClick(ctrl);
			}

			// Token: 0x060151BB RID: 86459 RVA: 0x00556EA8 File Offset: 0x005550A8
			public void OnOpenServiceActivityButtonClick(UIControllerBase ctrl)
			{
				this.m_owner.OnOpenServiceActivityButtonClick(ctrl);
			}

			// Token: 0x060151BC RID: 86460 RVA: 0x00556EB8 File Offset: 0x005550B8
			public void OnOppoButtonClick(UIControllerBase ctrl)
			{
				this.m_owner.OnOppoButtonClick(ctrl);
			}

			// Token: 0x060151BD RID: 86461 RVA: 0x00556EC8 File Offset: 0x005550C8
			public void OnYingYongBaoButtonClick(UIControllerBase ctrl)
			{
				this.m_owner.OnYingYongBaoButtonClick(ctrl);
			}

			// Token: 0x060151BE RID: 86462 RVA: 0x00556ED8 File Offset: 0x005550D8
			public void OnInvestigationButtonClick(UIControllerBase ctrl)
			{
				this.m_owner.OnInvestigationButtonClick(ctrl);
			}

			// Token: 0x060151BF RID: 86463 RVA: 0x00556EE8 File Offset: 0x005550E8
			public void WorldEventListItem_OnButtonClick(WorldEventListItemUIController ctrl)
			{
				this.m_owner.WorldEventListItem_OnButtonClick(ctrl);
			}

			// Token: 0x060151C0 RID: 86464 RVA: 0x00556EF8 File Offset: 0x005550F8
			public void OnEventListBackgroundButtonClick()
			{
				this.m_owner.OnEventListBackgroundButtonClick();
			}

			// Token: 0x060151C1 RID: 86465 RVA: 0x00556F08 File Offset: 0x00555108
			public void OnPastScenarioListBackgroundButtonClick()
			{
				this.m_owner.OnPastScenarioListBackgroundButtonClick();
			}

			// Token: 0x060151C2 RID: 86466 RVA: 0x00556F18 File Offset: 0x00555118
			public void PastScenarioListItem_OnStartButtonClick(PastScenarioListItemUIController ctrl)
			{
				this.m_owner.PastScenarioListItem_OnStartButtonClick(ctrl);
			}

			// Token: 0x060151C3 RID: 86467 RVA: 0x00556F28 File Offset: 0x00555128
			public void OnMonthCardButtonClick()
			{
				this.m_owner.OnMonthCardButtonClick();
			}

			// Token: 0x060151C4 RID: 86468 RVA: 0x00556F38 File Offset: 0x00555138
			public void OnMonthCardCloseButtonClick()
			{
				this.m_owner.OnMonthCardCloseButtonClick();
			}

			// Token: 0x060151C5 RID: 86469 RVA: 0x00556F48 File Offset: 0x00555148
			public void OnMonthCardItemItemClick(int cardId)
			{
				this.m_owner.OnMonthCardItemItemClick(cardId);
			}

			// Token: 0x060151C6 RID: 86470 RVA: 0x00556F58 File Offset: 0x00555158
			public void OnMonthCardBuyClick(int cardId)
			{
				this.m_owner.OnMonthCardBuyClick(cardId);
			}

			// Token: 0x0400B83E RID: 47166
			private WorldUIController m_owner;
		}
	}
}
