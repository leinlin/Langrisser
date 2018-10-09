using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectLBasic;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000AD0 RID: 2768
	[HotFix]
	public class BattleUIController : UIControllerBase
	{
		// Token: 0x0600B477 RID: 46199 RVA: 0x0031C88C File Offset: 0x0031AA8C
		private BattleUIController()
		{
		}

		// Token: 0x0600B478 RID: 46200 RVA: 0x0031C8C0 File Offset: 0x0031AAC0
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
			this.m_pauseButton.onClick.AddListener(new UnityAction(this.OnPauseButtonClick));
			this.m_autoButton.onClick.AddListener(new UnityAction(this.OnAutoButtonClick));
			this.m_autoOffButton.onClick.AddListener(new UnityAction(this.OnAutoOffButtonClick));
			this.m_arenaAutoButton.onClick.AddListener(new UnityAction(this.OnArenaAutoButtonClick));
			this.m_fastButton.onClick.AddListener(new UnityAction(this.OnFastButtonClick));
			this.m_skipCombatButton.onClick.AddListener(new UnityAction(this.OnSkipCombatButtonClick));
			this.m_dangerOnButton.onClick.AddListener(new UnityAction(this.OnDangerOnButtonClick));
			this.m_dangerOffButton.onClick.AddListener(new UnityAction(this.OnDangerOffButtonClick));
			this.m_endActionButton.onClick.AddListener(new UnityAction(this.OnEndActionButtonClick));
			this.m_endAllActionButton.onClick.AddListener(new UnityAction(this.OnEndAllActionButtonClick));
			this.m_actorSimpleInfoButton.onClick.AddListener(new UnityAction(this.OnActorSimpleInfoButtonClick));
			this.m_useSkillButton.onClick.AddListener(new UnityAction(this.OnUseSkillButtonClick));
			this.m_cancelSkillButton.onClick.AddListener(new UnityAction(this.OnCancelSkillButtonClick));
			this.m_chatButton.onClick.AddListener(new UnityAction(this.OnChatButtonClick));
			this.m_terrainInfoButton.onClick.AddListener(new UnityAction(this.OnTerrainInfoButtonClick));
			this.m_danmakuToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnDanmakuToggleValueChanged));
			this.m_danmakuSendButton.onClick.AddListener(new UnityAction(this.OnDanmakuSendButtonClick));
			this.m_danmakuInputWordButton.onClick.AddListener(new UnityAction(this.OnDanmakuInputWordButtonClick));
			this.m_danmakuInputBackButton.onClick.AddListener(new UnityAction(this.OnDanmakuInputBackButtonClick));
			this.m_regretPanelGameObject.SetActive(false);
			this.m_regretFxUIStateController.gameObject.SetActive(false);
			this.m_regratButton.onClick.AddListener(new UnityAction(this.OnRegretButtonClick));
			this.m_regratConfirmButton.onClick.AddListener(new UnityAction(this.OnRegretConfirmButtonClick));
			this.m_regretCancelButton.onClick.AddListener(new UnityAction(this.OnRegretCancelButtonClick));
			this.m_regretBackwardButton.onClick.AddListener(new UnityAction(this.OnRegretBackwardButtonClick));
			this.m_regretForwardButton.onClick.AddListener(new UnityAction(this.OnRegretForwardButtonClick));
			this.m_battleSkillButtonPool = new GameObjectPool<BattleSkillButton>();
			this.m_battleSkillButtonPool.Setup(this.m_battleSkillButtonPrefab, null);
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("ArmyRelation");
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer, this.m_topLeftGameObject.transform, false);
			gameObject.transform.SetAsFirstSibling();
			UIUtility.MarginAdjustHorizontal(gameObject.transform as RectTransform);
			Button button = Utility.FindChildComponent<Button>(gameObject, "ShowButton", true);
			button.onClick.AddListener(new UnityAction(this.OnArmyRelationButtonClick));
			button.gameObject.SetActive(false);
			Button button2 = Utility.FindChildComponent<Button>(gameObject, "ShowButton/HelpButton", true);
			button2.onClick.AddListener(new UnityAction(this.OnHelpButtonClick));
			this.m_armyRelationButtonUIStateController = button.gameObject.GetComponent<CommonUIStateController>();
			this.m_armyRelationDescUIStateController = Utility.FindChildComponent<CommonUIStateController>(gameObject, "Desc", true);
			this.m_armyRelationDescUIStateController.gameObject.SetActive(false);
			UIUtility.SetTweenIgnoreTimeScale(this.m_objectiveGameObject, false);
			UIUtility.SetTweenIgnoreTimeScale(this.m_turnStartGameObject, false);
			UIUtility.SetTweenIgnoreTimeScale(this.m_playerTurnGameObject, false);
			UIUtility.SetTweenIgnoreTimeScale(this.m_enemyTurnGameObject, false);
			UIUtility.SetTweenIgnoreTimeScale(this.m_cutsceneSkillUIStateController.gameObject, false);
			UIUtility.SetTweenIgnoreTimeScale(this.m_myActionUIStateController.gameObject, false);
			UIUtility.SetTweenIgnoreTimeScale(this.m_teammateActionUIStateController.gameObject, false);
			UIUtility.SetTweenIgnoreTimeScale(this.m_enemyActionUIStateController.gameObject, false);
			this.m_prefabsGameObject.SetActive(false);
			UIUtility.MarginAdjustHorizontal(this.m_marginTransform);
		}

		// Token: 0x0600B479 RID: 46201 RVA: 0x0031CD50 File Offset: 0x0031AF50
		private void Update()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Update_hotfix != null)
			{
				this.m_Update_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			float deltaTime = Time.deltaTime;
			if (this.m_hideSkillHintTime > 0f)
			{
				this.m_hideSkillHintTime -= deltaTime;
				if (this.m_hideSkillHintTime <= 0f)
				{
					this.HideSkillHint();
				}
			}
			if (Time.time - this.m_chatRedPointLastTime > 1f)
			{
				this.m_chatRedPointLastTime = Time.time;
				this.RefreshChatRedState();
			}
		}

		// Token: 0x0600B47A RID: 46202 RVA: 0x0031CE14 File Offset: 0x0031B014
		public void StartBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartBattle_hotfix != null)
			{
				this.m_StartBattle_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ShowEndAllAction(false);
			this.HideSkills();
			this.ShowUseOrCancelSkill(false);
			this.ShowEndAction(false);
			this.HideTerrainInfo();
			this.HideArmyRelation();
			this.HideCutsceneSkill();
			this.SetAutoBattle(false);
			this.SetFastBattle(false);
			this.SetShowDanger(false);
			this.m_objectiveGameObject.SetActive(false);
			this.m_winGameObject.SetActive(false);
			this.m_loseGameObject.SetActive(false);
			this.m_turnStartGameObject.SetActive(false);
			this.m_playerTurnGameObject.SetActive(false);
			this.m_enemyTurnGameObject.SetActive(false);
			this.m_topLeftGameObject.SetActive(true);
			this.m_topLeftGameObject2.SetActive(true);
			this.m_topRightGameObject2.SetActive(true);
			this.m_bottomGameObject.SetActive(true);
			this.m_actorSimpleInfoButton.gameObject.SetActive(false);
			this.m_skillsUIStateController.gameObject.SetActive(false);
			this.m_statusUIStateController.gameObject.SetActive(false);
			this.m_regretPanelGameObject.SetActive(false);
			this.m_isShowRegretPanel = false;
			this.m_myActionUIStateController.gameObject.SetActive(false);
			this.m_teammateActionUIStateController.gameObject.SetActive(false);
			this.m_enemyActionUIStateController.gameObject.SetActive(false);
			this.m_danmakuToggle.isOn = LocalConfig.Instance.Data.ShowBattleDanmaku;
			this.m_developerClickCount = 0;
		}

		// Token: 0x0600B47B RID: 46203 RVA: 0x0031CFC8 File Offset: 0x0031B1C8
		public void StopBattle(bool win)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StopBattleBoolean_hotfix != null)
			{
				this.m_StopBattleBoolean_hotfix.call(new object[]
				{
					this,
					win
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideTerrainInfo();
			this.HideArmyRelation();
			this.HideCutsceneSkill();
			this.ShowTopUI(false);
			this.ShowBottomUI(false);
			this.m_autoOffButton.gameObject.SetActive(false);
			if (win)
			{
				this.m_winGameObject.SetActive(true);
				this.m_loseGameObject.SetActive(false);
				UIUtility.ReplayTween(this.m_winGameObject, new Action(this.WinOrLoseTweenFinished));
			}
			else
			{
				this.m_winGameObject.SetActive(false);
				this.m_loseGameObject.SetActive(true);
				UIUtility.ReplayTween(this.m_loseGameObject, new Action(this.WinOrLoseTweenFinished));
			}
		}

		// Token: 0x0600B47C RID: 46204 RVA: 0x0031D0D4 File Offset: 0x0031B2D4
		private void WinOrLoseTweenFinished()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WinOrLoseTweenFinished_hotfix != null)
			{
				this.m_WinOrLoseTweenFinished_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnWinOrLoseEnd != null)
			{
				this.EventOnWinOrLoseEnd();
			}
		}

		// Token: 0x0600B47D RID: 46205 RVA: 0x0031D14C File Offset: 0x0031B34C
		public void ShowTurnStatus(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowTurnStatusBoolean_hotfix != null)
			{
				this.m_ShowTurnStatusBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (show)
			{
				UIUtility.SetUIStateOpen(this.m_statusUIStateController, "Show", null, false, false);
			}
			else
			{
				UIUtility.SetUIStateClose(this.m_statusUIStateController, "Close", null, false, true);
			}
		}

		// Token: 0x0600B47E RID: 46206 RVA: 0x0031D1F0 File Offset: 0x0031B3F0
		public void ShowObjecive(string winDesc, string loseDesc)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowObjeciveStringString_hotfix != null)
			{
				this.m_ShowObjeciveStringString_hotfix.call(new object[]
				{
					this,
					winDesc,
					loseDesc
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_objectiveGameObject.SetActive(true);
			this.m_objectiveWinDescText.text = winDesc;
			this.m_objectiveLoseDescText.text = loseDesc;
			UIUtility.ReplayTween(this.m_objectiveGameObject, delegate
			{
				this.m_objectiveGameObject.SetActive(false);
			});
			char[] separator = new char[]
			{
				'\r',
				'\n'
			};
			string[] array = winDesc.Split(separator);
			this.m_statusWinDescGameObject1.SetActive(false);
			this.m_statusWinDescGameObject2.SetActive(false);
			if (array.Length > 0)
			{
				this.m_statusWinDescGameObject1.SetActive(true);
				this.m_statusWinDescText1.text = array[0];
			}
			if (array.Length > 1)
			{
				this.m_statusWinDescGameObject2.SetActive(true);
				this.m_statusWinDescText2.text = array[1];
			}
		}

		// Token: 0x0600B47F RID: 46207 RVA: 0x0031D324 File Offset: 0x0031B524
		public void ShowTurnStart(int turn, int turnMax)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowTurnStartInt32Int32_hotfix != null)
			{
				this.m_ShowTurnStartInt32Int32_hotfix.call(new object[]
				{
					this,
					turn,
					turnMax
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_turnStartGameObject.SetActive(true);
			Text turnStartText = this.m_turnStartText;
			string text = turn + " / " + turnMax;
			this.m_statusTurnText.text = text;
			turnStartText.text = text;
			UIUtility.ReplayTween(this.m_turnStartGameObject, delegate
			{
				this.m_turnStartGameObject.SetActive(false);
			});
		}

		// Token: 0x0600B480 RID: 46208 RVA: 0x0031D3F8 File Offset: 0x0031B5F8
		public void ShowPlayerTurn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowPlayerTurn_hotfix != null)
			{
				this.m_ShowPlayerTurn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerTurnGameObject.SetActive(true);
			UIUtility.ReplayTween(this.m_playerTurnGameObject, delegate
			{
				this.m_playerTurnGameObject.SetActive(false);
			});
		}

		// Token: 0x0600B481 RID: 46209 RVA: 0x0031D47C File Offset: 0x0031B67C
		public void ShowEnemyTurn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowEnemyTurn_hotfix != null)
			{
				this.m_ShowEnemyTurn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_enemyTurnGameObject.SetActive(true);
			UIUtility.ReplayTween(this.m_enemyTurnGameObject, delegate
			{
				this.m_enemyTurnGameObject.SetActive(false);
			});
		}

		// Token: 0x0600B482 RID: 46210 RVA: 0x0031D500 File Offset: 0x0031B700
		public void ShowMyAction(BattleRoomPlayer player, int playerTagIndex, Action onEnd = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowMyActionBattleRoomPlayerInt32Action_hotfix != null)
			{
				this.m_ShowMyActionBattleRoomPlayerInt32Action_hotfix.call(new object[]
				{
					this,
					player,
					playerTagIndex,
					onEnd2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action onEnd = onEnd2;
			BattleUIController $this = this;
			this.m_myActionHeadImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerHeadIconImageName(HeadIconTools.GetHeadPortrait(player.HeadIcon)));
			this.m_myActionNameText.text = player.Name;
			if (playerTagIndex >= 0)
			{
				this.m_myActionPlayerTagImage.gameObject.SetActive(true);
				this.m_myActionPlayerTagImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetBattlePlayerTagImageName(playerTagIndex));
			}
			else
			{
				this.m_myActionPlayerTagImage.gameObject.SetActive(false);
			}
			UIUtility.SetUIStateOpen(this.m_myActionUIStateController, "Show", delegate
			{
				$this.m_myActionUIStateController.gameObject.SetActive(false);
				if (onEnd != null)
				{
					onEnd();
				}
			}, false, true);
		}

		// Token: 0x0600B483 RID: 46211 RVA: 0x0031D644 File Offset: 0x0031B844
		public void ShowTeammateAction(BattleRoomPlayer player, int playerIndex, Action onEnd = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowTeammateActionBattleRoomPlayerInt32Action_hotfix != null)
			{
				this.m_ShowTeammateActionBattleRoomPlayerInt32Action_hotfix.call(new object[]
				{
					this,
					player,
					playerIndex,
					onEnd2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action onEnd = onEnd2;
			BattleUIController $this = this;
			this.m_teammateActionHeadImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerHeadIconImageName(HeadIconTools.GetHeadPortrait(player.HeadIcon)));
			this.m_teammateActionNameText.text = player.Name;
			if (playerIndex >= 0)
			{
				this.m_teammateActionPlayerTagImage.gameObject.SetActive(true);
				this.m_teammateActionPlayerTagImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetBattlePlayerTagImageName(playerIndex));
			}
			else
			{
				this.m_teammateActionPlayerTagImage.gameObject.SetActive(false);
			}
			UIUtility.SetUIStateOpen(this.m_teammateActionUIStateController, "Show", delegate
			{
				$this.m_teammateActionUIStateController.gameObject.SetActive(false);
				if (onEnd != null)
				{
					onEnd();
				}
			}, false, true);
		}

		// Token: 0x0600B484 RID: 46212 RVA: 0x0031D788 File Offset: 0x0031B988
		public void ShowEnemyAction(BattleRoomPlayer player)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowEnemyActionBattleRoomPlayer_hotfix != null)
			{
				this.m_ShowEnemyActionBattleRoomPlayer_hotfix.call(new object[]
				{
					this,
					player
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_enemyActionHeadImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerHeadIconImageName(HeadIconTools.GetHeadPortrait(player.HeadIcon)));
			this.m_enemyActionNameText.text = player.Name;
			UIUtility.SetUIStateOpen(this.m_enemyActionUIStateController, "Show", delegate
			{
				this.m_enemyActionUIStateController.gameObject.SetActive(false);
			}, false, true);
		}

		// Token: 0x0600B485 RID: 46213 RVA: 0x0031D84C File Offset: 0x0031BA4C
		public void HidePauseButton()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HidePauseButton_hotfix != null)
			{
				this.m_HidePauseButton_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_pauseButton.gameObject.SetActive(false);
		}

		// Token: 0x0600B486 RID: 46214 RVA: 0x0031D8C0 File Offset: 0x0031BAC0
		public void ShowChatButton(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowChatButtonBoolean_hotfix != null)
			{
				this.m_ShowChatButtonBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_chatButton.gameObject.SetActive(show);
			NoticeUITask.m_isEnableClick = show;
		}

		// Token: 0x0600B487 RID: 46215 RVA: 0x0031D948 File Offset: 0x0031BB48
		public void SetAutoBattle(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetAutoBattleBoolean_hotfix != null)
			{
				this.m_SetAutoBattleBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_autoOffButton.gameObject.SetActive(on);
			if (!this.m_playerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_AutoBattle))
			{
				this.m_autoButton.gameObject.SetActive(true);
				this.m_autoButtonUIStateController.SetToUIState("Grey", false, true);
			}
			else if (on)
			{
				this.m_autoButton.gameObject.SetActive(false);
				this.HideArmyRelation();
			}
			else
			{
				this.m_autoButton.gameObject.SetActive(true);
				this.m_autoButtonUIStateController.SetToUIState("Close", false, true);
			}
		}

		// Token: 0x0600B488 RID: 46216 RVA: 0x0031DA48 File Offset: 0x0031BC48
		public void HideAutoBattleButton()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideAutoBattleButton_hotfix != null)
			{
				this.m_HideAutoBattleButton_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_autoButton.gameObject.SetActive(false);
			this.m_autoOffButton.gameObject.SetActive(false);
		}

		// Token: 0x0600B489 RID: 46217 RVA: 0x0031DACC File Offset: 0x0031BCCC
		public void SetArenaAutoBattle(bool auto)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetArenaAutoBattleBoolean_hotfix != null)
			{
				this.m_SetArenaAutoBattleBoolean_hotfix.call(new object[]
				{
					this,
					auto
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_arenaAutoButton.gameObject.SetActive(auto);
		}

		// Token: 0x0600B48A RID: 46218 RVA: 0x0031DB50 File Offset: 0x0031BD50
		public void SetFastBattle(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetFastBattleBoolean_hotfix != null)
			{
				this.m_SetFastBattleBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_playerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_FastBattle))
			{
				this.m_fastButtonUIStateController.SetToUIState("Grey", false, true);
			}
			else if (on)
			{
				this.m_fastButtonUIStateController.SetToUIState("Open", false, true);
			}
			else
			{
				this.m_fastButtonUIStateController.SetToUIState("Close", false, true);
			}
		}

		// Token: 0x0600B48B RID: 46219 RVA: 0x0031DC18 File Offset: 0x0031BE18
		public void SetSkipCombatMode(SkipCombatMode mode)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSkipCombatModeSkipCombatMode_hotfix != null)
			{
				this.m_SetSkipCombatModeSkipCombatMode_hotfix.call(new object[]
				{
					this,
					mode
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_playerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_SkipBattleAnimation))
			{
				this.m_skipCombatButtonUIStateController.SetToUIState("Grey", false, true);
			}
			else if (mode == SkipCombatMode.None)
			{
				this.m_skipCombatButtonUIStateController.SetToUIState("Open", false, true);
			}
			else if (mode == SkipCombatMode.All)
			{
				this.m_skipCombatButtonUIStateController.SetToUIState("Close", false, true);
			}
			else if (mode == SkipCombatMode.Enemy)
			{
				this.m_skipCombatButtonUIStateController.SetToUIState("OnlyUs", false, true);
			}
		}

		// Token: 0x0600B48C RID: 46220 RVA: 0x0031DD08 File Offset: 0x0031BF08
		public void SetActorSimpleInfo(BattleActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetActorSimpleInfoBattleActor_hotfix != null)
			{
				this.m_SetActorSimpleInfoBattleActor_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (a == null)
			{
				return;
			}
			ConfigDataCharImageInfo charImageInfo = a.HeroInfo.GetCharImageInfo(a.HeroStar);
			if (charImageInfo != null)
			{
				this.m_actorSimpleInfoHeadImage.sprite = AssetUtility.Instance.GetSprite(AssetUtility.MakeSpriteAssetName(charImageInfo.CardHeadImage, "_0"));
			}
			this.m_actorSimpleInfoNameText.text = a.HeroInfo.Name;
			this.m_actorSimpleInfoLevelText.text = a.HeroLevel.ToString();
			this.m_actorSimpleInfoArmyImage.sprite = AssetUtility.Instance.GetSprite(a.HeroArmyInfo.Icon);
			this.m_actorSimpleInfoHeroHPText.text = a.HeroHealthPoint + " / " + a.HeroBattleProperty.HealthPointMax;
			if (a.HeroHealthPoint > 0 && a.HeroBattleProperty.HealthPointMax > 0)
			{
				this.m_actorSimpleInfoHeroHPImage.fillAmount = (float)a.HeroHealthPoint / (float)a.HeroBattleProperty.HealthPointMax;
			}
			else
			{
				this.m_actorSimpleInfoHeroHPImage.fillAmount = 0f;
			}
			this.m_actorSimpleInfoSoldierHPText.text = a.SoldierTotalHealthPoint + " / " + a.SoldierBattleProperty.HealthPointMax;
			if (a.SoldierTotalHealthPoint > 0 && a.SoldierBattleProperty.HealthPointMax > 0)
			{
				this.m_actorSimpleInfoSoldierHPImage.fillAmount = (float)a.SoldierTotalHealthPoint / (float)a.SoldierBattleProperty.HealthPointMax;
			}
			else
			{
				this.m_actorSimpleInfoSoldierHPImage.fillAmount = 0f;
			}
		}

		// Token: 0x0600B48D RID: 46221 RVA: 0x0031DF14 File Offset: 0x0031C114
		public void ShowActorSimpleInfo(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowActorSimpleInfoBoolean_hotfix != null)
			{
				this.m_ShowActorSimpleInfoBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (show)
			{
				UIUtility.SetUIStateOpen(this.m_actorSimpleInfoUIStateController, "Show", null, false, true);
			}
			else
			{
				UIUtility.SetUIStateClose(this.m_actorSimpleInfoUIStateController, "Close", null, false, true);
			}
			if (show)
			{
				this.HideArmyRelation();
			}
		}

		// Token: 0x0600B48E RID: 46222 RVA: 0x0031DFC4 File Offset: 0x0031C1C4
		public bool IsShowActorSimpleInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsShowActorSimpleInfo_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsShowActorSimpleInfo_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_actorSimpleInfoButton.gameObject.activeSelf;
		}

		// Token: 0x0600B48F RID: 46223 RVA: 0x0031E040 File Offset: 0x0031C240
		public void SetShowDanger(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetShowDangerBoolean_hotfix != null)
			{
				this.m_SetShowDangerBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_dangerOnButton.gameObject.SetActive(!on);
			this.m_dangerOffButton.gameObject.SetActive(on);
		}

		// Token: 0x0600B490 RID: 46224 RVA: 0x0031E0D8 File Offset: 0x0031C2D8
		public void ShowEndAction(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowEndActionBoolean_hotfix != null)
			{
				this.m_ShowEndActionBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_endActionButton.gameObject.SetActive(show);
			if (show)
			{
				UIUtility.SetUIStateOpen(this.m_skillsUIStateController, "Show", null, false, false);
			}
		}

		// Token: 0x0600B491 RID: 46225 RVA: 0x0031E174 File Offset: 0x0031C374
		public void ShowEndAllAction(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowEndAllActionBoolean_hotfix != null)
			{
				this.m_ShowEndAllActionBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_endAllActionButton.gameObject.SetActive(show);
		}

		// Token: 0x0600B492 RID: 46226 RVA: 0x0031E1F8 File Offset: 0x0031C3F8
		public void SetActionOrderType(ActionOrderType actionOrderType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetActionOrderTypeActionOrderType_hotfix != null)
			{
				this.m_SetActionOrderTypeActionOrderType_hotfix.call(new object[]
				{
					this,
					actionOrderType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600B493 RID: 46227 RVA: 0x0031E268 File Offset: 0x0031C468
		public void RefreshChatRedState()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RefreshChatRedState_hotfix != null)
			{
				this.m_RefreshChatRedState_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.GetGroupUnreadChatMsgCount();
			num += projectLPlayerContext.GetPrivateUnreadChatMsgCount();
			if (num > 0)
			{
				this.m_chatRedPoint.SetActive(true);
			}
			else
			{
				this.m_chatRedPoint.SetActive(false);
			}
		}

		// Token: 0x0600B494 RID: 46228 RVA: 0x0031E310 File Offset: 0x0031C510
		private static void ComputeActionIconPositionScale(int index, out Vector2 pos, out float scale)
		{
			pos = Vector2.zero;
			scale = 1f;
			for (int i = 0; i < index; i++)
			{
				pos.x += 185f * scale;
				pos.y += 10f * scale;
				scale *= 0.9f;
			}
		}

		// Token: 0x0600B495 RID: 46229 RVA: 0x0031E378 File Offset: 0x0031C578
		public void ShowTopUI(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowTopUIBoolean_hotfix != null)
			{
				this.m_ShowTopUIBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_topLeftGameObject.SetActive(show);
			this.m_topLeftGameObject2.SetActive(show);
			this.m_topRightGameObject2.SetActive(show);
			if (!show)
			{
				this.m_actorSimpleInfoButton.gameObject.SetActive(false);
				this.HideArmyRelation();
			}
		}

		// Token: 0x0600B496 RID: 46230 RVA: 0x0031E42C File Offset: 0x0031C62C
		public bool IsShowTopUI()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsShowTopUI_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsShowTopUI_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_topLeftGameObject.activeSelf;
		}

		// Token: 0x0600B497 RID: 46231 RVA: 0x0031E4A4 File Offset: 0x0031C6A4
		public void ShowBottomUI(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowBottomUIBoolean_hotfix != null)
			{
				this.m_ShowBottomUIBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_bottomGameObject.SetActive(show);
		}

		// Token: 0x0600B498 RID: 46232 RVA: 0x0031E520 File Offset: 0x0031C720
		public bool IsShowBottomUI()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsShowBottomUI_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsShowBottomUI_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_bottomGameObject.activeSelf;
		}

		// Token: 0x0600B499 RID: 46233 RVA: 0x0031E598 File Offset: 0x0031C798
		public void ShowSkills(List<BattleSkillState> skills, bool isActiveSkillBanned, bool isPassiveSkillBanned)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowSkillsList`1BooleanBoolean_hotfix != null)
			{
				this.m_ShowSkillsList`1BooleanBoolean_hotfix.call(new object[]
				{
					this,
					skills,
					isActiveSkillBanned,
					isPassiveSkillBanned
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleSkillButtonPool.Deactive();
			UIUtility.SetUIStateOpen(this.m_skillsUIStateController, "Show", null, false, false);
			UIUtility.SetUIStateOpen(this.m_skillListUIStateController, "Show", null, false, true);
			for (int i = 0; i < this.m_skillListGameObject.transform.childCount; i++)
			{
				this.m_skillListGameObject.transform.GetChild(i).gameObject.SetActive(false);
			}
			for (int j = 0; j < skills.Count; j++)
			{
				if (j >= this.m_skillListGameObject.transform.childCount)
				{
					break;
				}
				BattleSkillState battleSkillState = skills[j];
				bool flag;
				BattleSkillButton sb = this.m_battleSkillButtonPool.Allocate(out flag);
				if (sb != null)
				{
					GameObject gameObject = this.m_skillListGameObject.transform.GetChild(j).gameObject;
					gameObject.SetActive(true);
					UnityEngine.Object @object = gameObject;
					string name = battleSkillState.m_skillInfo.ID.ToString();
					sb.gameObject.name = name;
					@object.name = name;
					sb.transform.SetParent(gameObject.transform, false);
					if (flag)
					{
						sb.EventOnClick += delegate()
						{
							this.BattleSkillButton_OnClick(sb);
						};
						sb.SetDescGameObject(this.m_skillDescGameObject);
					}
					sb.SetIndex(j);
					sb.SetSkillInfo(battleSkillState.m_skillInfo);
					sb.SetCooldown(battleSkillState.m_cooldown);
					sb.SetBanned(!battleSkillState.m_isSkillUseable || (isActiveSkillBanned && battleSkillState.m_skillInfo.IsActiveSkill) || (isPassiveSkillBanned && battleSkillState.m_skillInfo.IsPassiveSkill()));
				}
			}
			this.ShowUseOrCancelSkill(false);
			this.m_skillDescGameObject.SetActive(false);
			this.m_skillHintUIStateController.gameObject.SetActive(false);
			this.m_isShowSkillHint = false;
		}

		// Token: 0x0600B49A RID: 46234 RVA: 0x0031E83C File Offset: 0x0031CA3C
		public RectTransform GetSkillButtonRectTransform(int idx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSkillButtonRectTransformInt32_hotfix != null)
			{
				return (RectTransform)this.m_GetSkillButtonRectTransformInt32_hotfix.call(new object[]
				{
					this,
					idx
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_skillListGameObject.transform.GetChild(idx).GetChild(0) as RectTransform;
		}

		// Token: 0x0600B49B RID: 46235 RVA: 0x0031E8D4 File Offset: 0x0031CAD4
		public void HideSkills()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideSkills_hotfix != null)
			{
				this.m_HideSkills_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_skillsUIStateController, "Close", null, false, true);
			this.m_skillDescGameObject.SetActive(false);
			this.m_skillHintUIStateController.gameObject.SetActive(false);
			this.m_isShowSkillHint = false;
		}

		// Token: 0x0600B49C RID: 46236 RVA: 0x0031E96C File Offset: 0x0031CB6C
		public void ShowUseOrCancelSkill(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowUseOrCancelSkillBoolean_hotfix != null)
			{
				this.m_ShowUseOrCancelSkillBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_useSkillButton.gameObject.SetActive(show);
			this.m_cancelSkillButton.gameObject.SetActive(show);
		}

		// Token: 0x0600B49D RID: 46237 RVA: 0x0031EA00 File Offset: 0x0031CC00
		public void ShowUseSkill(bool enable)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowUseSkillBoolean_hotfix != null)
			{
				this.m_ShowUseSkillBoolean_hotfix.call(new object[]
				{
					this,
					enable
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_useSkillButton.gameObject.SetActive(enable);
		}

		// Token: 0x0600B49E RID: 46238 RVA: 0x0031EA84 File Offset: 0x0031CC84
		public void SetCurrentSkill(BattleSkillState ss)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCurrentSkillBattleSkillState_hotfix != null)
			{
				this.m_SetCurrentSkillBattleSkillState_hotfix.call(new object[]
				{
					this,
					ss
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (ss == null)
			{
				return;
			}
			this.ShowTopUI(false);
			UIUtility.SetUIStateClose(this.m_skillsUIStateController, "Close", null, false, true);
			this.ShowEndAction(false);
			this.ShowEndAllAction(false);
			this.ShowActorSimpleInfo(false);
			this.ShowUseOrCancelSkill(true);
			this.ShowUseSkill(false);
			if (ss.m_skillInfo.BF_TargetType == SkillTargetType.SkillTargetType_Enemy || ss.m_skillInfo.BF_TargetType == SkillTargetType.SkillTargetType_Ally || ss.m_skillInfo.BF_TargetType == SkillTargetType.SkillTargetType_Any)
			{
				this.ShowSkillHint(StringTableId.StringTableId_Battle_SelectTarget, 0f);
			}
			else
			{
				this.ShowSkillHint(StringTableId.StringTableId_Battle_SelectPosition, 0f);
			}
		}

		// Token: 0x0600B49F RID: 46239 RVA: 0x0031EB90 File Offset: 0x0031CD90
		public void ShowSkillHint(StringTableId id, float hideTime = 0f)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowSkillHintStringTableIdSingle_hotfix != null)
			{
				this.m_ShowSkillHintStringTableIdSingle_hotfix.call(new object[]
				{
					this,
					id,
					hideTime
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.m_skillHintText.text = configDataLoader.UtilityGetStringByStringTable(id);
			if (!this.m_isShowSkillHint)
			{
				this.m_isShowSkillHint = true;
				UIUtility.SetUIStateOpen(this.m_skillHintUIStateController, "PanelOpen", null, false, true);
				this.m_hideSkillHintTime = hideTime;
			}
		}

		// Token: 0x0600B4A0 RID: 46240 RVA: 0x0031EC60 File Offset: 0x0031CE60
		public void HideSkillHint()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideSkillHint_hotfix != null)
			{
				this.m_HideSkillHint_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isShowSkillHint)
			{
				this.m_isShowSkillHint = false;
				UIUtility.SetUIStateClose(this.m_skillHintUIStateController, "PanelClose", null, false, true);
			}
		}

		// Token: 0x0600B4A1 RID: 46241 RVA: 0x0031ECE8 File Offset: 0x0031CEE8
		public void HighlightSkillHint()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HighlightSkillHint_hotfix != null)
			{
				this.m_HighlightSkillHint_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600B4A2 RID: 46242 RVA: 0x0031ED48 File Offset: 0x0031CF48
		public void ShowTerrainInfo(ConfigDataTerrainInfo terrain)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowTerrainInfoConfigDataTerrainInfo_hotfix != null)
			{
				this.m_ShowTerrainInfoConfigDataTerrainInfo_hotfix.call(new object[]
				{
					this,
					terrain
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (terrain == null)
			{
				return;
			}
			this.m_terrainInfoGameObject.SetActive(true);
			this.m_terrainInfoText.text = terrain.Name;
			this.m_terrainInfoDefText.text = terrain.BattleBonus + "%";
			this.m_terrainInfoImage.sprite = AssetUtility.Instance.GetSprite(terrain.InfoImage);
		}

		// Token: 0x0600B4A3 RID: 46243 RVA: 0x0031EE18 File Offset: 0x0031D018
		public void HideTerrainInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideTerrainInfo_hotfix != null)
			{
				this.m_HideTerrainInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_terrainInfoGameObject.SetActive(false);
		}

		// Token: 0x0600B4A4 RID: 46244 RVA: 0x0031EE84 File Offset: 0x0031D084
		public void ShowArmyRelationButton()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowArmyRelationButton_hotfix != null)
			{
				this.m_ShowArmyRelationButton_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_armyRelationButtonUIStateController, "BattleShow", null, false, true);
		}

		// Token: 0x0600B4A5 RID: 46245 RVA: 0x0031EEF8 File Offset: 0x0031D0F8
		private void HideArmyRelation()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideArmyRelation_hotfix != null)
			{
				this.m_HideArmyRelation_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_armyRelationButtonUIStateController.gameObject.SetActive(false);
			this.m_armyRelationDescUIStateController.gameObject.SetActive(false);
		}

		// Token: 0x0600B4A6 RID: 46246 RVA: 0x0031EF7C File Offset: 0x0031D17C
		public void ShowArmyRelationDesc()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowArmyRelationDesc_hotfix != null)
			{
				this.m_ShowArmyRelationDesc_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_armyRelationDescUIStateController, "BattleShow", null, false, true);
		}

		// Token: 0x0600B4A7 RID: 46247 RVA: 0x0031EFF0 File Offset: 0x0031D1F0
		public void HideArmyRelationDesc()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideArmyRelationDesc_hotfix != null)
			{
				this.m_HideArmyRelationDesc_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_armyRelationDescUIStateController, "BattleClose", null, false, true);
		}

		// Token: 0x0600B4A8 RID: 46248 RVA: 0x0031F064 File Offset: 0x0031D264
		public bool IsArmyRelationDescVisible()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsArmyRelationDescVisible_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsArmyRelationDescVisible_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_armyRelationDescUIStateController.gameObject.activeSelf;
		}

		// Token: 0x0600B4A9 RID: 46249 RVA: 0x0031F0E0 File Offset: 0x0031D2E0
		public void ShowCutsceneSkill(ConfigDataSkillInfo skillInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowCutsceneSkillConfigDataSkillInfo_hotfix != null)
			{
				this.m_ShowCutsceneSkillConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					skillInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (skillInfo == null)
			{
				return;
			}
			this.m_cutsceneSkillIconImage.sprite = AssetUtility.Instance.GetSprite(skillInfo.Icon);
			this.m_cutsceneSkillNameText.text = skillInfo.Name;
			UIUtility.SetUIStateOpen(this.m_cutsceneSkillUIStateController, "Show", delegate
			{
				this.m_cutsceneSkillUIStateController.gameObject.SetActive(false);
			}, false, true);
		}

		// Token: 0x0600B4AA RID: 46250 RVA: 0x0031F1A4 File Offset: 0x0031D3A4
		private void HideCutsceneSkill()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideCutsceneSkill_hotfix != null)
			{
				this.m_HideCutsceneSkill_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_cutsceneSkillUIStateController.gameObject.SetActive(false);
		}

		// Token: 0x0600B4AB RID: 46251 RVA: 0x0031F218 File Offset: 0x0031D418
		private void OnPauseButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPauseButtonClick_hotfix != null)
			{
				this.m_OnPauseButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnPauseBattle != null)
			{
				this.EventOnPauseBattle();
			}
		}

		// Token: 0x0600B4AC RID: 46252 RVA: 0x0031F290 File Offset: 0x0031D490
		private void OnArmyRelationButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnArmyRelationButtonClick_hotfix != null)
			{
				this.m_OnArmyRelationButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowArmyRelation != null)
			{
				this.EventOnShowArmyRelation();
			}
		}

		// Token: 0x0600B4AD RID: 46253 RVA: 0x0031F308 File Offset: 0x0031D508
		private void OnAutoButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAutoButtonClick_hotfix != null)
			{
				this.m_OnAutoButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string uistateCurrentStateName = UIUtility.GetUIStateCurrentStateName(this.m_autoButtonUIStateController);
			if (uistateCurrentStateName == "Close")
			{
				if (this.EventOnAutoBattle != null)
				{
					this.EventOnAutoBattle(true);
				}
			}
			else
			{
				CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_AutoBattle), 2f, null, true);
			}
		}

		// Token: 0x0600B4AE RID: 46254 RVA: 0x0031F3B8 File Offset: 0x0031D5B8
		private void OnAutoOffButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAutoOffButtonClick_hotfix != null)
			{
				this.m_OnAutoOffButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnAutoBattle != null)
			{
				this.EventOnAutoBattle(false);
			}
		}

		// Token: 0x0600B4AF RID: 46255 RVA: 0x0031F430 File Offset: 0x0031D630
		private void OnArenaAutoButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnArenaAutoButtonClick_hotfix != null)
			{
				this.m_OnArenaAutoButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Battle_ArenaAutoBattle, 2f, null, true);
		}

		// Token: 0x0600B4B0 RID: 46256 RVA: 0x0031F4A8 File Offset: 0x0031D6A8
		private void OnFastButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFastButtonClick_hotfix != null)
			{
				this.m_OnFastButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string uistateCurrentStateName = UIUtility.GetUIStateCurrentStateName(this.m_fastButtonUIStateController);
			if (uistateCurrentStateName == "Close")
			{
				if (this.EventOnFastBattle != null)
				{
					this.EventOnFastBattle(true);
				}
			}
			else if (uistateCurrentStateName == "Open")
			{
				if (this.EventOnFastBattle != null)
				{
					this.EventOnFastBattle(false);
				}
			}
			else
			{
				CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_FastBattle), 2f, null, true);
			}
		}

		// Token: 0x0600B4B1 RID: 46257 RVA: 0x0031F584 File Offset: 0x0031D784
		private void OnSkipCombatButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSkipCombatButtonClick_hotfix != null)
			{
				this.m_OnSkipCombatButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string uistateCurrentStateName = UIUtility.GetUIStateCurrentStateName(this.m_skipCombatButtonUIStateController);
			if (uistateCurrentStateName == "Open")
			{
				if (this.EventOnFastBattle != null)
				{
					this.EventOnSkipCombat(SkipCombatMode.All);
				}
			}
			else if (uistateCurrentStateName == "Close")
			{
				if (this.EventOnFastBattle != null)
				{
					this.EventOnSkipCombat(SkipCombatMode.Enemy);
				}
			}
			else if (uistateCurrentStateName == "OnlyUs")
			{
				if (this.EventOnFastBattle != null)
				{
					this.EventOnSkipCombat(SkipCombatMode.None);
				}
			}
			else
			{
				CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_SkipBattleAnimation), 2f, null, true);
			}
		}

		// Token: 0x0600B4B2 RID: 46258 RVA: 0x0031F68C File Offset: 0x0031D88C
		private void OnDangerOnButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDangerOnButtonClick_hotfix != null)
			{
				this.m_OnDangerOnButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowDanger != null)
			{
				this.EventOnShowDanger(true);
			}
		}

		// Token: 0x0600B4B3 RID: 46259 RVA: 0x0031F704 File Offset: 0x0031D904
		private void OnDangerOffButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDangerOffButtonClick_hotfix != null)
			{
				this.m_OnDangerOffButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowDanger != null)
			{
				this.EventOnShowDanger(false);
			}
		}

		// Token: 0x0600B4B4 RID: 46260 RVA: 0x0031F77C File Offset: 0x0031D97C
		private void OnEndActionButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEndActionButtonClick_hotfix != null)
			{
				this.m_OnEndActionButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnEndAction != null)
			{
				this.EventOnEndAction();
			}
		}

		// Token: 0x0600B4B5 RID: 46261 RVA: 0x0031F7F4 File Offset: 0x0031D9F4
		private void OnEndAllActionButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEndAllActionButtonClick_hotfix != null)
			{
				this.m_OnEndAllActionButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnEndAllAction != null)
			{
				this.EventOnEndAllAction();
			}
		}

		// Token: 0x0600B4B6 RID: 46262 RVA: 0x0031F86C File Offset: 0x0031DA6C
		private void OnActorSimpleInfoButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnActorSimpleInfoButtonClick_hotfix != null)
			{
				this.m_OnActorSimpleInfoButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowActorInfo != null)
			{
				this.EventOnShowActorInfo();
			}
		}

		// Token: 0x0600B4B7 RID: 46263 RVA: 0x0031F8E4 File Offset: 0x0031DAE4
		private void OnUseSkillButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnUseSkillButtonClick_hotfix != null)
			{
				this.m_OnUseSkillButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnUseSkill != null)
			{
				this.EventOnUseSkill();
			}
		}

		// Token: 0x0600B4B8 RID: 46264 RVA: 0x0031F95C File Offset: 0x0031DB5C
		private void OnCancelSkillButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCancelSkillButtonClick_hotfix != null)
			{
				this.m_OnCancelSkillButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnCancelSkill != null)
			{
				this.EventOnCancelSkill();
			}
		}

		// Token: 0x0600B4B9 RID: 46265 RVA: 0x0031F9D4 File Offset: 0x0031DBD4
		private void BattleSkillButton_OnClick(BattleSkillButton sb)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleSkillButton_OnClickBattleSkillButton_hotfix != null)
			{
				this.m_BattleSkillButton_OnClickBattleSkillButton_hotfix.call(new object[]
				{
					this,
					sb
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnSelectSkill != null)
			{
				this.EventOnSelectSkill(sb.GetIndex());
			}
		}

		// Token: 0x0600B4BA RID: 46266 RVA: 0x0031FA60 File Offset: 0x0031DC60
		private void OnChatButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnChatButtonClick_hotfix != null)
			{
				this.m_OnChatButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowChat != null)
			{
				this.EventOnShowChat();
			}
		}

		// Token: 0x0600B4BB RID: 46267 RVA: 0x0031FAD8 File Offset: 0x0031DCD8
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

		// Token: 0x0600B4BC RID: 46268 RVA: 0x0031FB50 File Offset: 0x0031DD50
		private void OnTerrainInfoButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTerrainInfoButtonClick_hotfix != null)
			{
				this.m_OnTerrainInfoButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DeveloperModeClick();
		}

		// Token: 0x0600B4BD RID: 46269 RVA: 0x0031FBB8 File Offset: 0x0031DDB8
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
					LocalConfig.Instance.Save();
				}
			}
		}

		// Token: 0x0600B4BE RID: 46270 RVA: 0x0031FC64 File Offset: 0x0031DE64
		public void ShowDanmakuToggle(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowDanmakuToggleBoolean_hotfix != null)
			{
				this.m_ShowDanmakuToggleBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_danmakuToggle.gameObject.SetActive(show);
		}

		// Token: 0x0600B4BF RID: 46271 RVA: 0x0031FCE8 File Offset: 0x0031DEE8
		public void ShowCurTurnDanmaku(int turn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowCurTurnDanmakuInt32_hotfix != null)
			{
				this.m_ShowCurTurnDanmakuInt32_hotfix.call(new object[]
				{
					this,
					turn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_turn = turn;
			if (LocalConfig.Instance.Data.ShowBattleDanmaku && this.EventOnShowCurTurnDanmaku != null)
			{
				this.EventOnShowCurTurnDanmaku(this.m_turn);
			}
		}

		// Token: 0x0600B4C0 RID: 46272 RVA: 0x0031FD90 File Offset: 0x0031DF90
		private void OnDanmakuToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDanmakuToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnDanmakuToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				if (this.EventOnShowCurTurnDanmaku != null)
				{
					this.EventOnShowCurTurnDanmaku(this.m_turn);
				}
			}
			else if (this.EventOnCloseCurTurnDanmaku != null)
			{
				this.EventOnCloseCurTurnDanmaku();
			}
			LocalConfig.Instance.SetBattleDanmakuState(isOn);
		}

		// Token: 0x0600B4C1 RID: 46273 RVA: 0x0031FE48 File Offset: 0x0031E048
		private void OnDanmakuInputWordButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDanmakuInputWordButtonClick_hotfix != null)
			{
				this.m_OnDanmakuInputWordButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_danmakuStateCtrl, "Open", null, false, true);
		}

		// Token: 0x0600B4C2 RID: 46274 RVA: 0x0031FEBC File Offset: 0x0031E0BC
		private void OnDanmakuInputBackButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDanmakuInputBackButtonClick_hotfix != null)
			{
				this.m_OnDanmakuInputBackButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_danmakuStateCtrl, "Close", null, false, true);
		}

		// Token: 0x0600B4C3 RID: 46275 RVA: 0x0031FF30 File Offset: 0x0031E130
		private void OnDanmakuSendButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDanmakuSendButtonClick_hotfix != null)
			{
				this.m_OnDanmakuSendButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string text = this.m_danmakuInputField.text;
			if (text != null && text != string.Empty)
			{
				DanmakuEntry danmakuEntry = new DanmakuEntry();
				danmakuEntry.Content = this.m_configDataLoader.UtilityGetSensitiveWords().ReplaceSensitiveWord(text, '*');
				danmakuEntry.UserId = this.m_playerContext.GetUserId();
				if (this.EventOnShowOneDanmaku != null)
				{
					this.EventOnShowOneDanmaku(danmakuEntry);
				}
				this.m_danmakuInputField.text = string.Empty;
				PostDanmakuEntry postDanmakuEntry = new PostDanmakuEntry();
				postDanmakuEntry.Content = text;
				postDanmakuEntry.Turn = this.m_turn;
				this.m_playerContext.PostLevelDanmaku(postDanmakuEntry);
				UIUtility.SetUIStateClose(this.m_danmakuStateCtrl, "Close", null, false, true);
			}
		}

		// Token: 0x0600B4C4 RID: 46276 RVA: 0x00320044 File Offset: 0x0031E244
		public void SetRegretCount(int remainCount, int maxCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRegretCountInt32Int32_hotfix != null)
			{
				this.m_SetRegretCountInt32Int32_hotfix.call(new object[]
				{
					this,
					remainCount,
					maxCount
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			if (remainCount > 0)
			{
				this.m_regretCountText.text = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Regret_Count), remainCount);
				this.m_regretButtonUIStateController.SetToUIState("Normal", false, true);
			}
			else
			{
				this.m_regretCountText.text = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Regret_Count0), remainCount);
				this.m_regretButtonUIStateController.SetToUIState("Grey", false, true);
			}
		}

		// Token: 0x0600B4C5 RID: 46277 RVA: 0x00320148 File Offset: 0x0031E348
		public void SetRegretTurnStatus(int turn, int actionTeam, int count, int countMax)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRegretTurnStatusInt32Int32Int32Int32_hotfix != null)
			{
				this.m_SetRegretTurnStatusInt32Int32Int32Int32_hotfix.call(new object[]
				{
					this,
					turn,
					actionTeam,
					count,
					countMax
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.m_regretTurnText.text = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Regret_Turn), turn);
			string stateName = string.Empty;
			string stateName2 = string.Empty;
			StringTableId id;
			if (actionTeam == 0)
			{
				id = StringTableId.StringTableId_Regret_MyAction;
				stateName2 = "Blue";
				stateName = "Blue";
				this.m_regretMyCountText.text = string.Format("{0}/{1}", count, countMax);
			}
			else
			{
				id = StringTableId.StringTableId_Regret_EnemyAction;
				stateName2 = "Red";
				stateName = "Red";
				this.m_regretEnemyCountText.text = string.Format("{0}/{1}", count, countMax);
			}
			this.m_regretActionText.text = configDataLoader.UtilityGetStringByStringTable(id);
			this.m_regretTurnUIStateController.SetToUIState(stateName, false, true);
			this.m_regretEffectUIStateController.SetToUIState(stateName2, false, true);
		}

		// Token: 0x0600B4C6 RID: 46278 RVA: 0x003202C8 File Offset: 0x0031E4C8
		public void SetRegretButtonStatus(bool canBackward, bool canForward, bool canConfirm)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRegretButtonStatusBooleanBooleanBoolean_hotfix != null)
			{
				this.m_SetRegretButtonStatusBooleanBooleanBoolean_hotfix.call(new object[]
				{
					this,
					canBackward,
					canForward,
					canConfirm
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_regretBackwardUIStateController.SetToUIState((!canBackward) ? "Grey" : "Normal", false, true);
			this.m_regretForwardUIStateController.SetToUIState((!canForward) ? "Grey" : "Normal", false, true);
			this.m_regretConfirmUIStateController.SetToUIState((!canConfirm) ? "Grey" : "Normal", false, true);
		}

		// Token: 0x0600B4C7 RID: 46279 RVA: 0x003203C0 File Offset: 0x0031E5C0
		public void ShowRegretButton(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowRegretButtonBoolean_hotfix != null)
			{
				this.m_ShowRegretButtonBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_regratButton.gameObject.SetActive(show);
		}

		// Token: 0x0600B4C8 RID: 46280 RVA: 0x00320444 File Offset: 0x0031E644
		public void ShowRegretPanel(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowRegretPanelBoolean_hotfix != null)
			{
				this.m_ShowRegretPanelBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (show)
			{
				this.m_regretPanelGameObject.SetActive(true);
				UIUtility.SetUIStateOpen(this.m_regretUIStateController, "In", null, false, false);
			}
			else
			{
				UIUtility.SetUIStateClose(this.m_regretUIStateController, "Out", delegate
				{
					this.m_regretPanelGameObject.SetActive(false);
				}, false, false);
			}
			this.m_isShowRegretPanel = show;
		}

		// Token: 0x0600B4C9 RID: 46281 RVA: 0x00320504 File Offset: 0x0031E704
		public void ShowRegretConfirmFx(Action onEnd = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowRegretConfirmFxAction_hotfix != null)
			{
				this.m_ShowRegretConfirmFxAction_hotfix.call(new object[]
				{
					this,
					onEnd2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action onEnd = onEnd2;
			BattleUIController $this = this;
			UIUtility.SetUIStateOpen(this.m_regretFxUIStateController, "Open", delegate
			{
				$this.m_regretFxUIStateController.gameObject.SetActive(false);
				if (onEnd != null)
				{
					onEnd();
				}
			}, false, true);
		}

		// Token: 0x0600B4CA RID: 46282 RVA: 0x003205A8 File Offset: 0x0031E7A8
		private void OnRegretButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRegretButtonClick_hotfix != null)
			{
				this.m_OnRegretButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnRegretActive != null)
			{
				this.EventOnRegretActive();
			}
		}

		// Token: 0x0600B4CB RID: 46283 RVA: 0x00320620 File Offset: 0x0031E820
		private void OnRegretConfirmButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRegretConfirmButtonClick_hotfix != null)
			{
				this.m_OnRegretConfirmButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_isShowRegretPanel)
			{
				return;
			}
			if (UIUtility.GetUIStateCurrentStateName(this.m_regretConfirmUIStateController) == "Grey")
			{
				return;
			}
			if (this.EventOnRegretConfirm != null)
			{
				this.EventOnRegretConfirm();
			}
		}

		// Token: 0x0600B4CC RID: 46284 RVA: 0x003206C0 File Offset: 0x0031E8C0
		private void OnRegretCancelButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRegretCancelButtonClick_hotfix != null)
			{
				this.m_OnRegretCancelButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_isShowRegretPanel)
			{
				return;
			}
			if (this.EventOnRegretCancel != null)
			{
				this.EventOnRegretCancel();
			}
		}

		// Token: 0x0600B4CD RID: 46285 RVA: 0x00320744 File Offset: 0x0031E944
		private void OnRegretBackwardButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRegretBackwardButtonClick_hotfix != null)
			{
				this.m_OnRegretBackwardButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_isShowRegretPanel)
			{
				return;
			}
			if (UIUtility.GetUIStateCurrentStateName(this.m_regretBackwardUIStateController) == "Grey")
			{
				return;
			}
			if (this.EventOnRegretBackward != null)
			{
				this.EventOnRegretBackward();
			}
		}

		// Token: 0x0600B4CE RID: 46286 RVA: 0x003207E4 File Offset: 0x0031E9E4
		private void OnRegretForwardButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRegretForwardButtonClick_hotfix != null)
			{
				this.m_OnRegretForwardButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_isShowRegretPanel)
			{
				return;
			}
			if (UIUtility.GetUIStateCurrentStateName(this.m_regretForwardUIStateController) == "Grey")
			{
				return;
			}
			if (this.EventOnRegretForward != null)
			{
				this.EventOnRegretForward();
			}
		}

		// Token: 0x0600B4CF RID: 46287 RVA: 0x00320884 File Offset: 0x0031EA84
		public void OnScenePointerDown(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnScenePointerDownPointerEventData_hotfix != null)
			{
				this.m_OnScenePointerDownPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_pointerDownPosition = eventData.position;
			if (this.EventOnPointerDown != null)
			{
				this.EventOnPointerDown(eventData.button, eventData.position);
			}
		}

		// Token: 0x0600B4D0 RID: 46288 RVA: 0x00320924 File Offset: 0x0031EB24
		public void OnScenePointerUp(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnScenePointerUpPointerEventData_hotfix != null)
			{
				this.m_OnScenePointerUpPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnPointerUp != null)
			{
				this.EventOnPointerUp(eventData.button, eventData.position);
			}
		}

		// Token: 0x0600B4D1 RID: 46289 RVA: 0x003209B8 File Offset: 0x0031EBB8
		public void OnScenePointerClick(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnScenePointerClickPointerEventData_hotfix != null)
			{
				this.m_OnScenePointerClickPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnPointerClick != null && Vector2.Distance(eventData.position, this.m_pointerDownPosition) < (float)Screen.width * 0.02f)
			{
				this.EventOnPointerClick(eventData.button, eventData.position);
			}
		}

		// Token: 0x0600B4D2 RID: 46290 RVA: 0x00320A6C File Offset: 0x0031EC6C
		public void OnSceneBeginDrag(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSceneBeginDragPointerEventData_hotfix != null)
			{
				this.m_OnSceneBeginDragPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600B4D3 RID: 46291 RVA: 0x00320ADC File Offset: 0x0031ECDC
		public void OnSceneEndDrag(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSceneEndDragPointerEventData_hotfix != null)
			{
				this.m_OnSceneEndDragPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600B4D4 RID: 46292 RVA: 0x00320B4C File Offset: 0x0031ED4C
		public void OnSceneDrag(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSceneDragPointerEventData_hotfix != null)
			{
				this.m_OnSceneDragPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600B4D5 RID: 46293 RVA: 0x00320BBC File Offset: 0x0031EDBC
		public void OnScene3DTouch(Vector2 p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnScene3DTouchVector2_hotfix != null)
			{
				this.m_OnScene3DTouchVector2_hotfix.call(new object[]
				{
					this,
					p
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOn3DTouch != null)
			{
				this.EventOn3DTouch(p);
			}
		}

		// Token: 0x14000226 RID: 550
		// (add) Token: 0x0600B4D6 RID: 46294 RVA: 0x00320C44 File Offset: 0x0031EE44
		// (remove) Token: 0x0600B4D7 RID: 46295 RVA: 0x00320CE0 File Offset: 0x0031EEE0
		public event Action EventOnPauseBattle
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnPauseBattleAction_hotfix != null)
				{
					this.m_add_EventOnPauseBattleAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnPauseBattle;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnPauseBattle, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnPauseBattleAction_hotfix != null)
				{
					this.m_remove_EventOnPauseBattleAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnPauseBattle;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnPauseBattle, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000227 RID: 551
		// (add) Token: 0x0600B4D8 RID: 46296 RVA: 0x00320D7C File Offset: 0x0031EF7C
		// (remove) Token: 0x0600B4D9 RID: 46297 RVA: 0x00320E18 File Offset: 0x0031F018
		public event Action EventOnShowArmyRelation
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowArmyRelationAction_hotfix != null)
				{
					this.m_add_EventOnShowArmyRelationAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowArmyRelation;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowArmyRelation, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowArmyRelationAction_hotfix != null)
				{
					this.m_remove_EventOnShowArmyRelationAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowArmyRelation;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowArmyRelation, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000228 RID: 552
		// (add) Token: 0x0600B4DA RID: 46298 RVA: 0x00320EB4 File Offset: 0x0031F0B4
		// (remove) Token: 0x0600B4DB RID: 46299 RVA: 0x00320F50 File Offset: 0x0031F150
		public event Action<bool> EventOnAutoBattle
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAutoBattleAction`1_hotfix != null)
				{
					this.m_add_EventOnAutoBattleAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnAutoBattle;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnAutoBattle, (Action<bool>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAutoBattleAction`1_hotfix != null)
				{
					this.m_remove_EventOnAutoBattleAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnAutoBattle;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnAutoBattle, (Action<bool>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000229 RID: 553
		// (add) Token: 0x0600B4DC RID: 46300 RVA: 0x00320FEC File Offset: 0x0031F1EC
		// (remove) Token: 0x0600B4DD RID: 46301 RVA: 0x00321088 File Offset: 0x0031F288
		public event Action<bool> EventOnFastBattle
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnFastBattleAction`1_hotfix != null)
				{
					this.m_add_EventOnFastBattleAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnFastBattle;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnFastBattle, (Action<bool>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnFastBattleAction`1_hotfix != null)
				{
					this.m_remove_EventOnFastBattleAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnFastBattle;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnFastBattle, (Action<bool>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400022A RID: 554
		// (add) Token: 0x0600B4DE RID: 46302 RVA: 0x00321124 File Offset: 0x0031F324
		// (remove) Token: 0x0600B4DF RID: 46303 RVA: 0x003211C0 File Offset: 0x0031F3C0
		public event Action<SkipCombatMode> EventOnSkipCombat
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSkipCombatAction`1_hotfix != null)
				{
					this.m_add_EventOnSkipCombatAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<SkipCombatMode> action = this.EventOnSkipCombat;
				Action<SkipCombatMode> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<SkipCombatMode>>(ref this.EventOnSkipCombat, (Action<SkipCombatMode>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSkipCombatAction`1_hotfix != null)
				{
					this.m_remove_EventOnSkipCombatAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<SkipCombatMode> action = this.EventOnSkipCombat;
				Action<SkipCombatMode> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<SkipCombatMode>>(ref this.EventOnSkipCombat, (Action<SkipCombatMode>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400022B RID: 555
		// (add) Token: 0x0600B4E0 RID: 46304 RVA: 0x0032125C File Offset: 0x0031F45C
		// (remove) Token: 0x0600B4E1 RID: 46305 RVA: 0x003212F8 File Offset: 0x0031F4F8
		public event Action<bool> EventOnShowDanger
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowDangerAction`1_hotfix != null)
				{
					this.m_add_EventOnShowDangerAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnShowDanger;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnShowDanger, (Action<bool>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowDangerAction`1_hotfix != null)
				{
					this.m_remove_EventOnShowDangerAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnShowDanger;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnShowDanger, (Action<bool>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400022C RID: 556
		// (add) Token: 0x0600B4E2 RID: 46306 RVA: 0x00321394 File Offset: 0x0031F594
		// (remove) Token: 0x0600B4E3 RID: 46307 RVA: 0x00321430 File Offset: 0x0031F630
		public event Action EventOnEndAction
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnEndActionAction_hotfix != null)
				{
					this.m_add_EventOnEndActionAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnEndAction;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnEndAction, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnEndActionAction_hotfix != null)
				{
					this.m_remove_EventOnEndActionAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnEndAction;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnEndAction, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400022D RID: 557
		// (add) Token: 0x0600B4E4 RID: 46308 RVA: 0x003214CC File Offset: 0x0031F6CC
		// (remove) Token: 0x0600B4E5 RID: 46309 RVA: 0x00321568 File Offset: 0x0031F768
		public event Action EventOnShowActorInfo
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowActorInfoAction_hotfix != null)
				{
					this.m_add_EventOnShowActorInfoAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowActorInfo;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowActorInfo, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowActorInfoAction_hotfix != null)
				{
					this.m_remove_EventOnShowActorInfoAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowActorInfo;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowActorInfo, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400022E RID: 558
		// (add) Token: 0x0600B4E6 RID: 46310 RVA: 0x00321604 File Offset: 0x0031F804
		// (remove) Token: 0x0600B4E7 RID: 46311 RVA: 0x003216A0 File Offset: 0x0031F8A0
		public event Action EventOnEndAllAction
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnEndAllActionAction_hotfix != null)
				{
					this.m_add_EventOnEndAllActionAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnEndAllAction;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnEndAllAction, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnEndAllActionAction_hotfix != null)
				{
					this.m_remove_EventOnEndAllActionAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnEndAllAction;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnEndAllAction, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400022F RID: 559
		// (add) Token: 0x0600B4E8 RID: 46312 RVA: 0x0032173C File Offset: 0x0031F93C
		// (remove) Token: 0x0600B4E9 RID: 46313 RVA: 0x003217D8 File Offset: 0x0031F9D8
		public event Action EventOnUseSkill
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnUseSkillAction_hotfix != null)
				{
					this.m_add_EventOnUseSkillAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnUseSkill;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnUseSkill, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnUseSkillAction_hotfix != null)
				{
					this.m_remove_EventOnUseSkillAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnUseSkill;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnUseSkill, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000230 RID: 560
		// (add) Token: 0x0600B4EA RID: 46314 RVA: 0x00321874 File Offset: 0x0031FA74
		// (remove) Token: 0x0600B4EB RID: 46315 RVA: 0x00321910 File Offset: 0x0031FB10
		public event Action EventOnCancelSkill
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCancelSkillAction_hotfix != null)
				{
					this.m_add_EventOnCancelSkillAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCancelSkill;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCancelSkill, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCancelSkillAction_hotfix != null)
				{
					this.m_remove_EventOnCancelSkillAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCancelSkill;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCancelSkill, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000231 RID: 561
		// (add) Token: 0x0600B4EC RID: 46316 RVA: 0x003219AC File Offset: 0x0031FBAC
		// (remove) Token: 0x0600B4ED RID: 46317 RVA: 0x00321A48 File Offset: 0x0031FC48
		public event Action EventOnWinOrLoseEnd
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnWinOrLoseEndAction_hotfix != null)
				{
					this.m_add_EventOnWinOrLoseEndAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnWinOrLoseEnd;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnWinOrLoseEnd, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnWinOrLoseEndAction_hotfix != null)
				{
					this.m_remove_EventOnWinOrLoseEndAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnWinOrLoseEnd;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnWinOrLoseEnd, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000232 RID: 562
		// (add) Token: 0x0600B4EE RID: 46318 RVA: 0x00321AE4 File Offset: 0x0031FCE4
		// (remove) Token: 0x0600B4EF RID: 46319 RVA: 0x00321B80 File Offset: 0x0031FD80
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

		// Token: 0x14000233 RID: 563
		// (add) Token: 0x0600B4F0 RID: 46320 RVA: 0x00321C1C File Offset: 0x0031FE1C
		// (remove) Token: 0x0600B4F1 RID: 46321 RVA: 0x00321CB8 File Offset: 0x0031FEB8
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

		// Token: 0x14000234 RID: 564
		// (add) Token: 0x0600B4F2 RID: 46322 RVA: 0x00321D54 File Offset: 0x0031FF54
		// (remove) Token: 0x0600B4F3 RID: 46323 RVA: 0x00321DF0 File Offset: 0x0031FFF0
		public event Action<int> EventOnSelectSkill
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSelectSkillAction`1_hotfix != null)
				{
					this.m_add_EventOnSelectSkillAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnSelectSkill;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnSelectSkill, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSelectSkillAction`1_hotfix != null)
				{
					this.m_remove_EventOnSelectSkillAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnSelectSkill;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnSelectSkill, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000235 RID: 565
		// (add) Token: 0x0600B4F4 RID: 46324 RVA: 0x00321E8C File Offset: 0x0032008C
		// (remove) Token: 0x0600B4F5 RID: 46325 RVA: 0x00321F28 File Offset: 0x00320128
		public event Action<PointerEventData.InputButton, Vector2> EventOnPointerDown
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnPointerDownAction`2_hotfix != null)
				{
					this.m_add_EventOnPointerDownAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData.InputButton, Vector2> action = this.EventOnPointerDown;
				Action<PointerEventData.InputButton, Vector2> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData.InputButton, Vector2>>(ref this.EventOnPointerDown, (Action<PointerEventData.InputButton, Vector2>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnPointerDownAction`2_hotfix != null)
				{
					this.m_remove_EventOnPointerDownAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData.InputButton, Vector2> action = this.EventOnPointerDown;
				Action<PointerEventData.InputButton, Vector2> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData.InputButton, Vector2>>(ref this.EventOnPointerDown, (Action<PointerEventData.InputButton, Vector2>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000236 RID: 566
		// (add) Token: 0x0600B4F6 RID: 46326 RVA: 0x00321FC4 File Offset: 0x003201C4
		// (remove) Token: 0x0600B4F7 RID: 46327 RVA: 0x00322060 File Offset: 0x00320260
		public event Action<PointerEventData.InputButton, Vector2> EventOnPointerUp
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnPointerUpAction`2_hotfix != null)
				{
					this.m_add_EventOnPointerUpAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData.InputButton, Vector2> action = this.EventOnPointerUp;
				Action<PointerEventData.InputButton, Vector2> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData.InputButton, Vector2>>(ref this.EventOnPointerUp, (Action<PointerEventData.InputButton, Vector2>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnPointerUpAction`2_hotfix != null)
				{
					this.m_remove_EventOnPointerUpAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData.InputButton, Vector2> action = this.EventOnPointerUp;
				Action<PointerEventData.InputButton, Vector2> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData.InputButton, Vector2>>(ref this.EventOnPointerUp, (Action<PointerEventData.InputButton, Vector2>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000237 RID: 567
		// (add) Token: 0x0600B4F8 RID: 46328 RVA: 0x003220FC File Offset: 0x003202FC
		// (remove) Token: 0x0600B4F9 RID: 46329 RVA: 0x00322198 File Offset: 0x00320398
		public event Action<PointerEventData.InputButton, Vector2> EventOnPointerClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnPointerClickAction`2_hotfix != null)
				{
					this.m_add_EventOnPointerClickAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData.InputButton, Vector2> action = this.EventOnPointerClick;
				Action<PointerEventData.InputButton, Vector2> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData.InputButton, Vector2>>(ref this.EventOnPointerClick, (Action<PointerEventData.InputButton, Vector2>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnPointerClickAction`2_hotfix != null)
				{
					this.m_remove_EventOnPointerClickAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData.InputButton, Vector2> action = this.EventOnPointerClick;
				Action<PointerEventData.InputButton, Vector2> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData.InputButton, Vector2>>(ref this.EventOnPointerClick, (Action<PointerEventData.InputButton, Vector2>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000238 RID: 568
		// (add) Token: 0x0600B4FA RID: 46330 RVA: 0x00322234 File Offset: 0x00320434
		// (remove) Token: 0x0600B4FB RID: 46331 RVA: 0x003222D0 File Offset: 0x003204D0
		public event Action<Vector2> EventOn3DTouch
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOn3DTouchAction`1_hotfix != null)
				{
					this.m_add_EventOn3DTouchAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Vector2> action = this.EventOn3DTouch;
				Action<Vector2> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Vector2>>(ref this.EventOn3DTouch, (Action<Vector2>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOn3DTouchAction`1_hotfix != null)
				{
					this.m_remove_EventOn3DTouchAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Vector2> action = this.EventOn3DTouch;
				Action<Vector2> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Vector2>>(ref this.EventOn3DTouch, (Action<Vector2>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000239 RID: 569
		// (add) Token: 0x0600B4FC RID: 46332 RVA: 0x0032236C File Offset: 0x0032056C
		// (remove) Token: 0x0600B4FD RID: 46333 RVA: 0x00322408 File Offset: 0x00320608
		public event Action<int> EventOnShowCurTurnDanmaku
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowCurTurnDanmakuAction`1_hotfix != null)
				{
					this.m_add_EventOnShowCurTurnDanmakuAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnShowCurTurnDanmaku;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnShowCurTurnDanmaku, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowCurTurnDanmakuAction`1_hotfix != null)
				{
					this.m_remove_EventOnShowCurTurnDanmakuAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnShowCurTurnDanmaku;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnShowCurTurnDanmaku, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400023A RID: 570
		// (add) Token: 0x0600B4FE RID: 46334 RVA: 0x003224A4 File Offset: 0x003206A4
		// (remove) Token: 0x0600B4FF RID: 46335 RVA: 0x00322540 File Offset: 0x00320740
		public event Action EventOnCloseCurTurnDanmaku
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCloseCurTurnDanmakuAction_hotfix != null)
				{
					this.m_add_EventOnCloseCurTurnDanmakuAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCloseCurTurnDanmaku;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCloseCurTurnDanmaku, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCloseCurTurnDanmakuAction_hotfix != null)
				{
					this.m_remove_EventOnCloseCurTurnDanmakuAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCloseCurTurnDanmaku;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCloseCurTurnDanmaku, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400023B RID: 571
		// (add) Token: 0x0600B500 RID: 46336 RVA: 0x003225DC File Offset: 0x003207DC
		// (remove) Token: 0x0600B501 RID: 46337 RVA: 0x00322678 File Offset: 0x00320878
		public event Action<DanmakuEntry> EventOnShowOneDanmaku
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowOneDanmakuAction`1_hotfix != null)
				{
					this.m_add_EventOnShowOneDanmakuAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<DanmakuEntry> action = this.EventOnShowOneDanmaku;
				Action<DanmakuEntry> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<DanmakuEntry>>(ref this.EventOnShowOneDanmaku, (Action<DanmakuEntry>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowOneDanmakuAction`1_hotfix != null)
				{
					this.m_remove_EventOnShowOneDanmakuAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<DanmakuEntry> action = this.EventOnShowOneDanmaku;
				Action<DanmakuEntry> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<DanmakuEntry>>(ref this.EventOnShowOneDanmaku, (Action<DanmakuEntry>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400023C RID: 572
		// (add) Token: 0x0600B502 RID: 46338 RVA: 0x00322714 File Offset: 0x00320914
		// (remove) Token: 0x0600B503 RID: 46339 RVA: 0x003227B0 File Offset: 0x003209B0
		public event Action EventOnRegretActive
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnRegretActiveAction_hotfix != null)
				{
					this.m_add_EventOnRegretActiveAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnRegretActive;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnRegretActive, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnRegretActiveAction_hotfix != null)
				{
					this.m_remove_EventOnRegretActiveAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnRegretActive;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnRegretActive, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400023D RID: 573
		// (add) Token: 0x0600B504 RID: 46340 RVA: 0x0032284C File Offset: 0x00320A4C
		// (remove) Token: 0x0600B505 RID: 46341 RVA: 0x003228E8 File Offset: 0x00320AE8
		public event Action EventOnRegretConfirm
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnRegretConfirmAction_hotfix != null)
				{
					this.m_add_EventOnRegretConfirmAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnRegretConfirm;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnRegretConfirm, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnRegretConfirmAction_hotfix != null)
				{
					this.m_remove_EventOnRegretConfirmAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnRegretConfirm;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnRegretConfirm, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400023E RID: 574
		// (add) Token: 0x0600B506 RID: 46342 RVA: 0x00322984 File Offset: 0x00320B84
		// (remove) Token: 0x0600B507 RID: 46343 RVA: 0x00322A20 File Offset: 0x00320C20
		public event Action EventOnRegretCancel
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnRegretCancelAction_hotfix != null)
				{
					this.m_add_EventOnRegretCancelAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnRegretCancel;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnRegretCancel, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnRegretCancelAction_hotfix != null)
				{
					this.m_remove_EventOnRegretCancelAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnRegretCancel;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnRegretCancel, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400023F RID: 575
		// (add) Token: 0x0600B508 RID: 46344 RVA: 0x00322ABC File Offset: 0x00320CBC
		// (remove) Token: 0x0600B509 RID: 46345 RVA: 0x00322B58 File Offset: 0x00320D58
		public event Action EventOnRegretBackward
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnRegretBackwardAction_hotfix != null)
				{
					this.m_add_EventOnRegretBackwardAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnRegretBackward;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnRegretBackward, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnRegretBackwardAction_hotfix != null)
				{
					this.m_remove_EventOnRegretBackwardAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnRegretBackward;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnRegretBackward, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000240 RID: 576
		// (add) Token: 0x0600B50A RID: 46346 RVA: 0x00322BF4 File Offset: 0x00320DF4
		// (remove) Token: 0x0600B50B RID: 46347 RVA: 0x00322C90 File Offset: 0x00320E90
		public event Action EventOnRegretForward
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnRegretForwardAction_hotfix != null)
				{
					this.m_add_EventOnRegretForwardAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnRegretForward;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnRegretForward, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnRegretForwardAction_hotfix != null)
				{
					this.m_remove_EventOnRegretForwardAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnRegretForward;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnRegretForward, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002484 RID: 9348
		// (get) Token: 0x0600B50C RID: 46348 RVA: 0x00322D2C File Offset: 0x00320F2C
		// (set) Token: 0x0600B50D RID: 46349 RVA: 0x00322D4C File Offset: 0x00320F4C
		[DoNotToLua]
		public new BattleUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600B50E RID: 46350 RVA: 0x00322D58 File Offset: 0x00320F58
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600B50F RID: 46351 RVA: 0x00322D64 File Offset: 0x00320F64
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600B510 RID: 46352 RVA: 0x00322D6C File Offset: 0x00320F6C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600B511 RID: 46353 RVA: 0x00322D74 File Offset: 0x00320F74
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600B512 RID: 46354 RVA: 0x00322D88 File Offset: 0x00320F88
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600B513 RID: 46355 RVA: 0x00322D90 File Offset: 0x00320F90
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600B514 RID: 46356 RVA: 0x00322D9C File Offset: 0x00320F9C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600B515 RID: 46357 RVA: 0x00322DA8 File Offset: 0x00320FA8
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600B516 RID: 46358 RVA: 0x00322DB4 File Offset: 0x00320FB4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600B517 RID: 46359 RVA: 0x00322DC0 File Offset: 0x00320FC0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600B518 RID: 46360 RVA: 0x00322DCC File Offset: 0x00320FCC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600B519 RID: 46361 RVA: 0x00322DD8 File Offset: 0x00320FD8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600B51A RID: 46362 RVA: 0x00322DE4 File Offset: 0x00320FE4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600B51B RID: 46363 RVA: 0x00322DF0 File Offset: 0x00320FF0
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600B51C RID: 46364 RVA: 0x00322DFC File Offset: 0x00320FFC
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600B51D RID: 46365 RVA: 0x00322E04 File Offset: 0x00321004
		private void __callDele_EventOnPauseBattle()
		{
			Action eventOnPauseBattle = this.EventOnPauseBattle;
			if (eventOnPauseBattle != null)
			{
				eventOnPauseBattle();
			}
		}

		// Token: 0x0600B51E RID: 46366 RVA: 0x00322E24 File Offset: 0x00321024
		private void __clearDele_EventOnPauseBattle()
		{
			this.EventOnPauseBattle = null;
		}

		// Token: 0x0600B51F RID: 46367 RVA: 0x00322E30 File Offset: 0x00321030
		private void __callDele_EventOnShowArmyRelation()
		{
			Action eventOnShowArmyRelation = this.EventOnShowArmyRelation;
			if (eventOnShowArmyRelation != null)
			{
				eventOnShowArmyRelation();
			}
		}

		// Token: 0x0600B520 RID: 46368 RVA: 0x00322E50 File Offset: 0x00321050
		private void __clearDele_EventOnShowArmyRelation()
		{
			this.EventOnShowArmyRelation = null;
		}

		// Token: 0x0600B521 RID: 46369 RVA: 0x00322E5C File Offset: 0x0032105C
		private void __callDele_EventOnAutoBattle(bool obj)
		{
			Action<bool> eventOnAutoBattle = this.EventOnAutoBattle;
			if (eventOnAutoBattle != null)
			{
				eventOnAutoBattle(obj);
			}
		}

		// Token: 0x0600B522 RID: 46370 RVA: 0x00322E80 File Offset: 0x00321080
		private void __clearDele_EventOnAutoBattle(bool obj)
		{
			this.EventOnAutoBattle = null;
		}

		// Token: 0x0600B523 RID: 46371 RVA: 0x00322E8C File Offset: 0x0032108C
		private void __callDele_EventOnFastBattle(bool obj)
		{
			Action<bool> eventOnFastBattle = this.EventOnFastBattle;
			if (eventOnFastBattle != null)
			{
				eventOnFastBattle(obj);
			}
		}

		// Token: 0x0600B524 RID: 46372 RVA: 0x00322EB0 File Offset: 0x003210B0
		private void __clearDele_EventOnFastBattle(bool obj)
		{
			this.EventOnFastBattle = null;
		}

		// Token: 0x0600B525 RID: 46373 RVA: 0x00322EBC File Offset: 0x003210BC
		private void __callDele_EventOnSkipCombat(SkipCombatMode obj)
		{
			Action<SkipCombatMode> eventOnSkipCombat = this.EventOnSkipCombat;
			if (eventOnSkipCombat != null)
			{
				eventOnSkipCombat(obj);
			}
		}

		// Token: 0x0600B526 RID: 46374 RVA: 0x00322EE0 File Offset: 0x003210E0
		private void __clearDele_EventOnSkipCombat(SkipCombatMode obj)
		{
			this.EventOnSkipCombat = null;
		}

		// Token: 0x0600B527 RID: 46375 RVA: 0x00322EEC File Offset: 0x003210EC
		private void __callDele_EventOnShowDanger(bool obj)
		{
			Action<bool> eventOnShowDanger = this.EventOnShowDanger;
			if (eventOnShowDanger != null)
			{
				eventOnShowDanger(obj);
			}
		}

		// Token: 0x0600B528 RID: 46376 RVA: 0x00322F10 File Offset: 0x00321110
		private void __clearDele_EventOnShowDanger(bool obj)
		{
			this.EventOnShowDanger = null;
		}

		// Token: 0x0600B529 RID: 46377 RVA: 0x00322F1C File Offset: 0x0032111C
		private void __callDele_EventOnEndAction()
		{
			Action eventOnEndAction = this.EventOnEndAction;
			if (eventOnEndAction != null)
			{
				eventOnEndAction();
			}
		}

		// Token: 0x0600B52A RID: 46378 RVA: 0x00322F3C File Offset: 0x0032113C
		private void __clearDele_EventOnEndAction()
		{
			this.EventOnEndAction = null;
		}

		// Token: 0x0600B52B RID: 46379 RVA: 0x00322F48 File Offset: 0x00321148
		private void __callDele_EventOnShowActorInfo()
		{
			Action eventOnShowActorInfo = this.EventOnShowActorInfo;
			if (eventOnShowActorInfo != null)
			{
				eventOnShowActorInfo();
			}
		}

		// Token: 0x0600B52C RID: 46380 RVA: 0x00322F68 File Offset: 0x00321168
		private void __clearDele_EventOnShowActorInfo()
		{
			this.EventOnShowActorInfo = null;
		}

		// Token: 0x0600B52D RID: 46381 RVA: 0x00322F74 File Offset: 0x00321174
		private void __callDele_EventOnEndAllAction()
		{
			Action eventOnEndAllAction = this.EventOnEndAllAction;
			if (eventOnEndAllAction != null)
			{
				eventOnEndAllAction();
			}
		}

		// Token: 0x0600B52E RID: 46382 RVA: 0x00322F94 File Offset: 0x00321194
		private void __clearDele_EventOnEndAllAction()
		{
			this.EventOnEndAllAction = null;
		}

		// Token: 0x0600B52F RID: 46383 RVA: 0x00322FA0 File Offset: 0x003211A0
		private void __callDele_EventOnUseSkill()
		{
			Action eventOnUseSkill = this.EventOnUseSkill;
			if (eventOnUseSkill != null)
			{
				eventOnUseSkill();
			}
		}

		// Token: 0x0600B530 RID: 46384 RVA: 0x00322FC0 File Offset: 0x003211C0
		private void __clearDele_EventOnUseSkill()
		{
			this.EventOnUseSkill = null;
		}

		// Token: 0x0600B531 RID: 46385 RVA: 0x00322FCC File Offset: 0x003211CC
		private void __callDele_EventOnCancelSkill()
		{
			Action eventOnCancelSkill = this.EventOnCancelSkill;
			if (eventOnCancelSkill != null)
			{
				eventOnCancelSkill();
			}
		}

		// Token: 0x0600B532 RID: 46386 RVA: 0x00322FEC File Offset: 0x003211EC
		private void __clearDele_EventOnCancelSkill()
		{
			this.EventOnCancelSkill = null;
		}

		// Token: 0x0600B533 RID: 46387 RVA: 0x00322FF8 File Offset: 0x003211F8
		private void __callDele_EventOnWinOrLoseEnd()
		{
			Action eventOnWinOrLoseEnd = this.EventOnWinOrLoseEnd;
			if (eventOnWinOrLoseEnd != null)
			{
				eventOnWinOrLoseEnd();
			}
		}

		// Token: 0x0600B534 RID: 46388 RVA: 0x00323018 File Offset: 0x00321218
		private void __clearDele_EventOnWinOrLoseEnd()
		{
			this.EventOnWinOrLoseEnd = null;
		}

		// Token: 0x0600B535 RID: 46389 RVA: 0x00323024 File Offset: 0x00321224
		private void __callDele_EventOnShowChat()
		{
			Action eventOnShowChat = this.EventOnShowChat;
			if (eventOnShowChat != null)
			{
				eventOnShowChat();
			}
		}

		// Token: 0x0600B536 RID: 46390 RVA: 0x00323044 File Offset: 0x00321244
		private void __clearDele_EventOnShowChat()
		{
			this.EventOnShowChat = null;
		}

		// Token: 0x0600B537 RID: 46391 RVA: 0x00323050 File Offset: 0x00321250
		private void __callDele_EventOnShowHelp()
		{
			Action eventOnShowHelp = this.EventOnShowHelp;
			if (eventOnShowHelp != null)
			{
				eventOnShowHelp();
			}
		}

		// Token: 0x0600B538 RID: 46392 RVA: 0x00323070 File Offset: 0x00321270
		private void __clearDele_EventOnShowHelp()
		{
			this.EventOnShowHelp = null;
		}

		// Token: 0x0600B539 RID: 46393 RVA: 0x0032307C File Offset: 0x0032127C
		private void __callDele_EventOnSelectSkill(int obj)
		{
			Action<int> eventOnSelectSkill = this.EventOnSelectSkill;
			if (eventOnSelectSkill != null)
			{
				eventOnSelectSkill(obj);
			}
		}

		// Token: 0x0600B53A RID: 46394 RVA: 0x003230A0 File Offset: 0x003212A0
		private void __clearDele_EventOnSelectSkill(int obj)
		{
			this.EventOnSelectSkill = null;
		}

		// Token: 0x0600B53B RID: 46395 RVA: 0x003230AC File Offset: 0x003212AC
		private void __callDele_EventOnPointerDown(PointerEventData.InputButton arg1, Vector2 arg2)
		{
			Action<PointerEventData.InputButton, Vector2> eventOnPointerDown = this.EventOnPointerDown;
			if (eventOnPointerDown != null)
			{
				eventOnPointerDown(arg1, arg2);
			}
		}

		// Token: 0x0600B53C RID: 46396 RVA: 0x003230D0 File Offset: 0x003212D0
		private void __clearDele_EventOnPointerDown(PointerEventData.InputButton arg1, Vector2 arg2)
		{
			this.EventOnPointerDown = null;
		}

		// Token: 0x0600B53D RID: 46397 RVA: 0x003230DC File Offset: 0x003212DC
		private void __callDele_EventOnPointerUp(PointerEventData.InputButton arg1, Vector2 arg2)
		{
			Action<PointerEventData.InputButton, Vector2> eventOnPointerUp = this.EventOnPointerUp;
			if (eventOnPointerUp != null)
			{
				eventOnPointerUp(arg1, arg2);
			}
		}

		// Token: 0x0600B53E RID: 46398 RVA: 0x00323100 File Offset: 0x00321300
		private void __clearDele_EventOnPointerUp(PointerEventData.InputButton arg1, Vector2 arg2)
		{
			this.EventOnPointerUp = null;
		}

		// Token: 0x0600B53F RID: 46399 RVA: 0x0032310C File Offset: 0x0032130C
		private void __callDele_EventOnPointerClick(PointerEventData.InputButton arg1, Vector2 arg2)
		{
			Action<PointerEventData.InputButton, Vector2> eventOnPointerClick = this.EventOnPointerClick;
			if (eventOnPointerClick != null)
			{
				eventOnPointerClick(arg1, arg2);
			}
		}

		// Token: 0x0600B540 RID: 46400 RVA: 0x00323130 File Offset: 0x00321330
		private void __clearDele_EventOnPointerClick(PointerEventData.InputButton arg1, Vector2 arg2)
		{
			this.EventOnPointerClick = null;
		}

		// Token: 0x0600B541 RID: 46401 RVA: 0x0032313C File Offset: 0x0032133C
		private void __callDele_EventOn3DTouch(Vector2 obj)
		{
			Action<Vector2> eventOn3DTouch = this.EventOn3DTouch;
			if (eventOn3DTouch != null)
			{
				eventOn3DTouch(obj);
			}
		}

		// Token: 0x0600B542 RID: 46402 RVA: 0x00323160 File Offset: 0x00321360
		private void __clearDele_EventOn3DTouch(Vector2 obj)
		{
			this.EventOn3DTouch = null;
		}

		// Token: 0x0600B543 RID: 46403 RVA: 0x0032316C File Offset: 0x0032136C
		private void __callDele_EventOnShowCurTurnDanmaku(int obj)
		{
			Action<int> eventOnShowCurTurnDanmaku = this.EventOnShowCurTurnDanmaku;
			if (eventOnShowCurTurnDanmaku != null)
			{
				eventOnShowCurTurnDanmaku(obj);
			}
		}

		// Token: 0x0600B544 RID: 46404 RVA: 0x00323190 File Offset: 0x00321390
		private void __clearDele_EventOnShowCurTurnDanmaku(int obj)
		{
			this.EventOnShowCurTurnDanmaku = null;
		}

		// Token: 0x0600B545 RID: 46405 RVA: 0x0032319C File Offset: 0x0032139C
		private void __callDele_EventOnCloseCurTurnDanmaku()
		{
			Action eventOnCloseCurTurnDanmaku = this.EventOnCloseCurTurnDanmaku;
			if (eventOnCloseCurTurnDanmaku != null)
			{
				eventOnCloseCurTurnDanmaku();
			}
		}

		// Token: 0x0600B546 RID: 46406 RVA: 0x003231BC File Offset: 0x003213BC
		private void __clearDele_EventOnCloseCurTurnDanmaku()
		{
			this.EventOnCloseCurTurnDanmaku = null;
		}

		// Token: 0x0600B547 RID: 46407 RVA: 0x003231C8 File Offset: 0x003213C8
		private void __callDele_EventOnShowOneDanmaku(DanmakuEntry obj)
		{
			Action<DanmakuEntry> eventOnShowOneDanmaku = this.EventOnShowOneDanmaku;
			if (eventOnShowOneDanmaku != null)
			{
				eventOnShowOneDanmaku(obj);
			}
		}

		// Token: 0x0600B548 RID: 46408 RVA: 0x003231EC File Offset: 0x003213EC
		private void __clearDele_EventOnShowOneDanmaku(DanmakuEntry obj)
		{
			this.EventOnShowOneDanmaku = null;
		}

		// Token: 0x0600B549 RID: 46409 RVA: 0x003231F8 File Offset: 0x003213F8
		private void __callDele_EventOnRegretActive()
		{
			Action eventOnRegretActive = this.EventOnRegretActive;
			if (eventOnRegretActive != null)
			{
				eventOnRegretActive();
			}
		}

		// Token: 0x0600B54A RID: 46410 RVA: 0x00323218 File Offset: 0x00321418
		private void __clearDele_EventOnRegretActive()
		{
			this.EventOnRegretActive = null;
		}

		// Token: 0x0600B54B RID: 46411 RVA: 0x00323224 File Offset: 0x00321424
		private void __callDele_EventOnRegretConfirm()
		{
			Action eventOnRegretConfirm = this.EventOnRegretConfirm;
			if (eventOnRegretConfirm != null)
			{
				eventOnRegretConfirm();
			}
		}

		// Token: 0x0600B54C RID: 46412 RVA: 0x00323244 File Offset: 0x00321444
		private void __clearDele_EventOnRegretConfirm()
		{
			this.EventOnRegretConfirm = null;
		}

		// Token: 0x0600B54D RID: 46413 RVA: 0x00323250 File Offset: 0x00321450
		private void __callDele_EventOnRegretCancel()
		{
			Action eventOnRegretCancel = this.EventOnRegretCancel;
			if (eventOnRegretCancel != null)
			{
				eventOnRegretCancel();
			}
		}

		// Token: 0x0600B54E RID: 46414 RVA: 0x00323270 File Offset: 0x00321470
		private void __clearDele_EventOnRegretCancel()
		{
			this.EventOnRegretCancel = null;
		}

		// Token: 0x0600B54F RID: 46415 RVA: 0x0032327C File Offset: 0x0032147C
		private void __callDele_EventOnRegretBackward()
		{
			Action eventOnRegretBackward = this.EventOnRegretBackward;
			if (eventOnRegretBackward != null)
			{
				eventOnRegretBackward();
			}
		}

		// Token: 0x0600B550 RID: 46416 RVA: 0x0032329C File Offset: 0x0032149C
		private void __clearDele_EventOnRegretBackward()
		{
			this.EventOnRegretBackward = null;
		}

		// Token: 0x0600B551 RID: 46417 RVA: 0x003232A8 File Offset: 0x003214A8
		private void __callDele_EventOnRegretForward()
		{
			Action eventOnRegretForward = this.EventOnRegretForward;
			if (eventOnRegretForward != null)
			{
				eventOnRegretForward();
			}
		}

		// Token: 0x0600B552 RID: 46418 RVA: 0x003232C8 File Offset: 0x003214C8
		private void __clearDele_EventOnRegretForward()
		{
			this.EventOnRegretForward = null;
		}

		// Token: 0x0600B55A RID: 46426 RVA: 0x0032334C File Offset: 0x0032154C
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
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_StartBattle_hotfix = (luaObj.RawGet("StartBattle") as LuaFunction);
					this.m_StopBattleBoolean_hotfix = (luaObj.RawGet("StopBattle") as LuaFunction);
					this.m_WinOrLoseTweenFinished_hotfix = (luaObj.RawGet("WinOrLoseTweenFinished") as LuaFunction);
					this.m_ShowTurnStatusBoolean_hotfix = (luaObj.RawGet("ShowTurnStatus") as LuaFunction);
					this.m_ShowObjeciveStringString_hotfix = (luaObj.RawGet("ShowObjecive") as LuaFunction);
					this.m_ShowTurnStartInt32Int32_hotfix = (luaObj.RawGet("ShowTurnStart") as LuaFunction);
					this.m_ShowPlayerTurn_hotfix = (luaObj.RawGet("ShowPlayerTurn") as LuaFunction);
					this.m_ShowEnemyTurn_hotfix = (luaObj.RawGet("ShowEnemyTurn") as LuaFunction);
					this.m_ShowMyActionBattleRoomPlayerInt32Action_hotfix = (luaObj.RawGet("ShowMyAction") as LuaFunction);
					this.m_ShowTeammateActionBattleRoomPlayerInt32Action_hotfix = (luaObj.RawGet("ShowTeammateAction") as LuaFunction);
					this.m_ShowEnemyActionBattleRoomPlayer_hotfix = (luaObj.RawGet("ShowEnemyAction") as LuaFunction);
					this.m_HidePauseButton_hotfix = (luaObj.RawGet("HidePauseButton") as LuaFunction);
					this.m_ShowChatButtonBoolean_hotfix = (luaObj.RawGet("ShowChatButton") as LuaFunction);
					this.m_SetAutoBattleBoolean_hotfix = (luaObj.RawGet("SetAutoBattle") as LuaFunction);
					this.m_HideAutoBattleButton_hotfix = (luaObj.RawGet("HideAutoBattleButton") as LuaFunction);
					this.m_SetArenaAutoBattleBoolean_hotfix = (luaObj.RawGet("SetArenaAutoBattle") as LuaFunction);
					this.m_SetFastBattleBoolean_hotfix = (luaObj.RawGet("SetFastBattle") as LuaFunction);
					this.m_SetSkipCombatModeSkipCombatMode_hotfix = (luaObj.RawGet("SetSkipCombatMode") as LuaFunction);
					this.m_SetActorSimpleInfoBattleActor_hotfix = (luaObj.RawGet("SetActorSimpleInfo") as LuaFunction);
					this.m_ShowActorSimpleInfoBoolean_hotfix = (luaObj.RawGet("ShowActorSimpleInfo") as LuaFunction);
					this.m_IsShowActorSimpleInfo_hotfix = (luaObj.RawGet("IsShowActorSimpleInfo") as LuaFunction);
					this.m_SetShowDangerBoolean_hotfix = (luaObj.RawGet("SetShowDanger") as LuaFunction);
					this.m_ShowEndActionBoolean_hotfix = (luaObj.RawGet("ShowEndAction") as LuaFunction);
					this.m_ShowEndAllActionBoolean_hotfix = (luaObj.RawGet("ShowEndAllAction") as LuaFunction);
					this.m_SetActionOrderTypeActionOrderType_hotfix = (luaObj.RawGet("SetActionOrderType") as LuaFunction);
					this.m_RefreshChatRedState_hotfix = (luaObj.RawGet("RefreshChatRedState") as LuaFunction);
					this.m_ShowTopUIBoolean_hotfix = (luaObj.RawGet("ShowTopUI") as LuaFunction);
					this.m_IsShowTopUI_hotfix = (luaObj.RawGet("IsShowTopUI") as LuaFunction);
					this.m_ShowBottomUIBoolean_hotfix = (luaObj.RawGet("ShowBottomUI") as LuaFunction);
					this.m_IsShowBottomUI_hotfix = (luaObj.RawGet("IsShowBottomUI") as LuaFunction);
					this.m_ShowSkillsList`1BooleanBoolean_hotfix = (luaObj.RawGet("ShowSkills") as LuaFunction);
					this.m_GetSkillButtonRectTransformInt32_hotfix = (luaObj.RawGet("GetSkillButtonRectTransform") as LuaFunction);
					this.m_HideSkills_hotfix = (luaObj.RawGet("HideSkills") as LuaFunction);
					this.m_ShowUseOrCancelSkillBoolean_hotfix = (luaObj.RawGet("ShowUseOrCancelSkill") as LuaFunction);
					this.m_ShowUseSkillBoolean_hotfix = (luaObj.RawGet("ShowUseSkill") as LuaFunction);
					this.m_SetCurrentSkillBattleSkillState_hotfix = (luaObj.RawGet("SetCurrentSkill") as LuaFunction);
					this.m_ShowSkillHintStringTableIdSingle_hotfix = (luaObj.RawGet("ShowSkillHint") as LuaFunction);
					this.m_HideSkillHint_hotfix = (luaObj.RawGet("HideSkillHint") as LuaFunction);
					this.m_HighlightSkillHint_hotfix = (luaObj.RawGet("HighlightSkillHint") as LuaFunction);
					this.m_ShowTerrainInfoConfigDataTerrainInfo_hotfix = (luaObj.RawGet("ShowTerrainInfo") as LuaFunction);
					this.m_HideTerrainInfo_hotfix = (luaObj.RawGet("HideTerrainInfo") as LuaFunction);
					this.m_ShowArmyRelationButton_hotfix = (luaObj.RawGet("ShowArmyRelationButton") as LuaFunction);
					this.m_HideArmyRelation_hotfix = (luaObj.RawGet("HideArmyRelation") as LuaFunction);
					this.m_ShowArmyRelationDesc_hotfix = (luaObj.RawGet("ShowArmyRelationDesc") as LuaFunction);
					this.m_HideArmyRelationDesc_hotfix = (luaObj.RawGet("HideArmyRelationDesc") as LuaFunction);
					this.m_IsArmyRelationDescVisible_hotfix = (luaObj.RawGet("IsArmyRelationDescVisible") as LuaFunction);
					this.m_ShowCutsceneSkillConfigDataSkillInfo_hotfix = (luaObj.RawGet("ShowCutsceneSkill") as LuaFunction);
					this.m_HideCutsceneSkill_hotfix = (luaObj.RawGet("HideCutsceneSkill") as LuaFunction);
					this.m_OnPauseButtonClick_hotfix = (luaObj.RawGet("OnPauseButtonClick") as LuaFunction);
					this.m_OnArmyRelationButtonClick_hotfix = (luaObj.RawGet("OnArmyRelationButtonClick") as LuaFunction);
					this.m_OnAutoButtonClick_hotfix = (luaObj.RawGet("OnAutoButtonClick") as LuaFunction);
					this.m_OnAutoOffButtonClick_hotfix = (luaObj.RawGet("OnAutoOffButtonClick") as LuaFunction);
					this.m_OnArenaAutoButtonClick_hotfix = (luaObj.RawGet("OnArenaAutoButtonClick") as LuaFunction);
					this.m_OnFastButtonClick_hotfix = (luaObj.RawGet("OnFastButtonClick") as LuaFunction);
					this.m_OnSkipCombatButtonClick_hotfix = (luaObj.RawGet("OnSkipCombatButtonClick") as LuaFunction);
					this.m_OnDangerOnButtonClick_hotfix = (luaObj.RawGet("OnDangerOnButtonClick") as LuaFunction);
					this.m_OnDangerOffButtonClick_hotfix = (luaObj.RawGet("OnDangerOffButtonClick") as LuaFunction);
					this.m_OnEndActionButtonClick_hotfix = (luaObj.RawGet("OnEndActionButtonClick") as LuaFunction);
					this.m_OnEndAllActionButtonClick_hotfix = (luaObj.RawGet("OnEndAllActionButtonClick") as LuaFunction);
					this.m_OnActorSimpleInfoButtonClick_hotfix = (luaObj.RawGet("OnActorSimpleInfoButtonClick") as LuaFunction);
					this.m_OnUseSkillButtonClick_hotfix = (luaObj.RawGet("OnUseSkillButtonClick") as LuaFunction);
					this.m_OnCancelSkillButtonClick_hotfix = (luaObj.RawGet("OnCancelSkillButtonClick") as LuaFunction);
					this.m_BattleSkillButton_OnClickBattleSkillButton_hotfix = (luaObj.RawGet("BattleSkillButton_OnClick") as LuaFunction);
					this.m_OnChatButtonClick_hotfix = (luaObj.RawGet("OnChatButtonClick") as LuaFunction);
					this.m_OnHelpButtonClick_hotfix = (luaObj.RawGet("OnHelpButtonClick") as LuaFunction);
					this.m_OnTerrainInfoButtonClick_hotfix = (luaObj.RawGet("OnTerrainInfoButtonClick") as LuaFunction);
					this.m_DeveloperModeClick_hotfix = (luaObj.RawGet("DeveloperModeClick") as LuaFunction);
					this.m_ShowDanmakuToggleBoolean_hotfix = (luaObj.RawGet("ShowDanmakuToggle") as LuaFunction);
					this.m_ShowCurTurnDanmakuInt32_hotfix = (luaObj.RawGet("ShowCurTurnDanmaku") as LuaFunction);
					this.m_OnDanmakuToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnDanmakuToggleValueChanged") as LuaFunction);
					this.m_OnDanmakuInputWordButtonClick_hotfix = (luaObj.RawGet("OnDanmakuInputWordButtonClick") as LuaFunction);
					this.m_OnDanmakuInputBackButtonClick_hotfix = (luaObj.RawGet("OnDanmakuInputBackButtonClick") as LuaFunction);
					this.m_OnDanmakuSendButtonClick_hotfix = (luaObj.RawGet("OnDanmakuSendButtonClick") as LuaFunction);
					this.m_SetRegretCountInt32Int32_hotfix = (luaObj.RawGet("SetRegretCount") as LuaFunction);
					this.m_SetRegretTurnStatusInt32Int32Int32Int32_hotfix = (luaObj.RawGet("SetRegretTurnStatus") as LuaFunction);
					this.m_SetRegretButtonStatusBooleanBooleanBoolean_hotfix = (luaObj.RawGet("SetRegretButtonStatus") as LuaFunction);
					this.m_ShowRegretButtonBoolean_hotfix = (luaObj.RawGet("ShowRegretButton") as LuaFunction);
					this.m_ShowRegretPanelBoolean_hotfix = (luaObj.RawGet("ShowRegretPanel") as LuaFunction);
					this.m_ShowRegretConfirmFxAction_hotfix = (luaObj.RawGet("ShowRegretConfirmFx") as LuaFunction);
					this.m_OnRegretButtonClick_hotfix = (luaObj.RawGet("OnRegretButtonClick") as LuaFunction);
					this.m_OnRegretConfirmButtonClick_hotfix = (luaObj.RawGet("OnRegretConfirmButtonClick") as LuaFunction);
					this.m_OnRegretCancelButtonClick_hotfix = (luaObj.RawGet("OnRegretCancelButtonClick") as LuaFunction);
					this.m_OnRegretBackwardButtonClick_hotfix = (luaObj.RawGet("OnRegretBackwardButtonClick") as LuaFunction);
					this.m_OnRegretForwardButtonClick_hotfix = (luaObj.RawGet("OnRegretForwardButtonClick") as LuaFunction);
					this.m_OnScenePointerDownPointerEventData_hotfix = (luaObj.RawGet("OnScenePointerDown") as LuaFunction);
					this.m_OnScenePointerUpPointerEventData_hotfix = (luaObj.RawGet("OnScenePointerUp") as LuaFunction);
					this.m_OnScenePointerClickPointerEventData_hotfix = (luaObj.RawGet("OnScenePointerClick") as LuaFunction);
					this.m_OnSceneBeginDragPointerEventData_hotfix = (luaObj.RawGet("OnSceneBeginDrag") as LuaFunction);
					this.m_OnSceneEndDragPointerEventData_hotfix = (luaObj.RawGet("OnSceneEndDrag") as LuaFunction);
					this.m_OnSceneDragPointerEventData_hotfix = (luaObj.RawGet("OnSceneDrag") as LuaFunction);
					this.m_OnScene3DTouchVector2_hotfix = (luaObj.RawGet("OnScene3DTouch") as LuaFunction);
					this.m_add_EventOnPauseBattleAction_hotfix = (luaObj.RawGet("add_EventOnPauseBattle") as LuaFunction);
					this.m_remove_EventOnPauseBattleAction_hotfix = (luaObj.RawGet("remove_EventOnPauseBattle") as LuaFunction);
					this.m_add_EventOnShowArmyRelationAction_hotfix = (luaObj.RawGet("add_EventOnShowArmyRelation") as LuaFunction);
					this.m_remove_EventOnShowArmyRelationAction_hotfix = (luaObj.RawGet("remove_EventOnShowArmyRelation") as LuaFunction);
					this.m_add_EventOnAutoBattleAction`1_hotfix = (luaObj.RawGet("add_EventOnAutoBattle") as LuaFunction);
					this.m_remove_EventOnAutoBattleAction`1_hotfix = (luaObj.RawGet("remove_EventOnAutoBattle") as LuaFunction);
					this.m_add_EventOnFastBattleAction`1_hotfix = (luaObj.RawGet("add_EventOnFastBattle") as LuaFunction);
					this.m_remove_EventOnFastBattleAction`1_hotfix = (luaObj.RawGet("remove_EventOnFastBattle") as LuaFunction);
					this.m_add_EventOnSkipCombatAction`1_hotfix = (luaObj.RawGet("add_EventOnSkipCombat") as LuaFunction);
					this.m_remove_EventOnSkipCombatAction`1_hotfix = (luaObj.RawGet("remove_EventOnSkipCombat") as LuaFunction);
					this.m_add_EventOnShowDangerAction`1_hotfix = (luaObj.RawGet("add_EventOnShowDanger") as LuaFunction);
					this.m_remove_EventOnShowDangerAction`1_hotfix = (luaObj.RawGet("remove_EventOnShowDanger") as LuaFunction);
					this.m_add_EventOnEndActionAction_hotfix = (luaObj.RawGet("add_EventOnEndAction") as LuaFunction);
					this.m_remove_EventOnEndActionAction_hotfix = (luaObj.RawGet("remove_EventOnEndAction") as LuaFunction);
					this.m_add_EventOnShowActorInfoAction_hotfix = (luaObj.RawGet("add_EventOnShowActorInfo") as LuaFunction);
					this.m_remove_EventOnShowActorInfoAction_hotfix = (luaObj.RawGet("remove_EventOnShowActorInfo") as LuaFunction);
					this.m_add_EventOnEndAllActionAction_hotfix = (luaObj.RawGet("add_EventOnEndAllAction") as LuaFunction);
					this.m_remove_EventOnEndAllActionAction_hotfix = (luaObj.RawGet("remove_EventOnEndAllAction") as LuaFunction);
					this.m_add_EventOnUseSkillAction_hotfix = (luaObj.RawGet("add_EventOnUseSkill") as LuaFunction);
					this.m_remove_EventOnUseSkillAction_hotfix = (luaObj.RawGet("remove_EventOnUseSkill") as LuaFunction);
					this.m_add_EventOnCancelSkillAction_hotfix = (luaObj.RawGet("add_EventOnCancelSkill") as LuaFunction);
					this.m_remove_EventOnCancelSkillAction_hotfix = (luaObj.RawGet("remove_EventOnCancelSkill") as LuaFunction);
					this.m_add_EventOnWinOrLoseEndAction_hotfix = (luaObj.RawGet("add_EventOnWinOrLoseEnd") as LuaFunction);
					this.m_remove_EventOnWinOrLoseEndAction_hotfix = (luaObj.RawGet("remove_EventOnWinOrLoseEnd") as LuaFunction);
					this.m_add_EventOnShowChatAction_hotfix = (luaObj.RawGet("add_EventOnShowChat") as LuaFunction);
					this.m_remove_EventOnShowChatAction_hotfix = (luaObj.RawGet("remove_EventOnShowChat") as LuaFunction);
					this.m_add_EventOnShowHelpAction_hotfix = (luaObj.RawGet("add_EventOnShowHelp") as LuaFunction);
					this.m_remove_EventOnShowHelpAction_hotfix = (luaObj.RawGet("remove_EventOnShowHelp") as LuaFunction);
					this.m_add_EventOnSelectSkillAction`1_hotfix = (luaObj.RawGet("add_EventOnSelectSkill") as LuaFunction);
					this.m_remove_EventOnSelectSkillAction`1_hotfix = (luaObj.RawGet("remove_EventOnSelectSkill") as LuaFunction);
					this.m_add_EventOnPointerDownAction`2_hotfix = (luaObj.RawGet("add_EventOnPointerDown") as LuaFunction);
					this.m_remove_EventOnPointerDownAction`2_hotfix = (luaObj.RawGet("remove_EventOnPointerDown") as LuaFunction);
					this.m_add_EventOnPointerUpAction`2_hotfix = (luaObj.RawGet("add_EventOnPointerUp") as LuaFunction);
					this.m_remove_EventOnPointerUpAction`2_hotfix = (luaObj.RawGet("remove_EventOnPointerUp") as LuaFunction);
					this.m_add_EventOnPointerClickAction`2_hotfix = (luaObj.RawGet("add_EventOnPointerClick") as LuaFunction);
					this.m_remove_EventOnPointerClickAction`2_hotfix = (luaObj.RawGet("remove_EventOnPointerClick") as LuaFunction);
					this.m_add_EventOn3DTouchAction`1_hotfix = (luaObj.RawGet("add_EventOn3DTouch") as LuaFunction);
					this.m_remove_EventOn3DTouchAction`1_hotfix = (luaObj.RawGet("remove_EventOn3DTouch") as LuaFunction);
					this.m_add_EventOnShowCurTurnDanmakuAction`1_hotfix = (luaObj.RawGet("add_EventOnShowCurTurnDanmaku") as LuaFunction);
					this.m_remove_EventOnShowCurTurnDanmakuAction`1_hotfix = (luaObj.RawGet("remove_EventOnShowCurTurnDanmaku") as LuaFunction);
					this.m_add_EventOnCloseCurTurnDanmakuAction_hotfix = (luaObj.RawGet("add_EventOnCloseCurTurnDanmaku") as LuaFunction);
					this.m_remove_EventOnCloseCurTurnDanmakuAction_hotfix = (luaObj.RawGet("remove_EventOnCloseCurTurnDanmaku") as LuaFunction);
					this.m_add_EventOnShowOneDanmakuAction`1_hotfix = (luaObj.RawGet("add_EventOnShowOneDanmaku") as LuaFunction);
					this.m_remove_EventOnShowOneDanmakuAction`1_hotfix = (luaObj.RawGet("remove_EventOnShowOneDanmaku") as LuaFunction);
					this.m_add_EventOnRegretActiveAction_hotfix = (luaObj.RawGet("add_EventOnRegretActive") as LuaFunction);
					this.m_remove_EventOnRegretActiveAction_hotfix = (luaObj.RawGet("remove_EventOnRegretActive") as LuaFunction);
					this.m_add_EventOnRegretConfirmAction_hotfix = (luaObj.RawGet("add_EventOnRegretConfirm") as LuaFunction);
					this.m_remove_EventOnRegretConfirmAction_hotfix = (luaObj.RawGet("remove_EventOnRegretConfirm") as LuaFunction);
					this.m_add_EventOnRegretCancelAction_hotfix = (luaObj.RawGet("add_EventOnRegretCancel") as LuaFunction);
					this.m_remove_EventOnRegretCancelAction_hotfix = (luaObj.RawGet("remove_EventOnRegretCancel") as LuaFunction);
					this.m_add_EventOnRegretBackwardAction_hotfix = (luaObj.RawGet("add_EventOnRegretBackward") as LuaFunction);
					this.m_remove_EventOnRegretBackwardAction_hotfix = (luaObj.RawGet("remove_EventOnRegretBackward") as LuaFunction);
					this.m_add_EventOnRegretForwardAction_hotfix = (luaObj.RawGet("add_EventOnRegretForward") as LuaFunction);
					this.m_remove_EventOnRegretForwardAction_hotfix = (luaObj.RawGet("remove_EventOnRegretForward") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600B55B RID: 46427 RVA: 0x0032425C File Offset: 0x0032245C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040074DA RID: 29914
		[AutoBind("./Margin", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_marginTransform;

		// Token: 0x040074DB RID: 29915
		[AutoBind("./Margin/AutoOffButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_autoOffButton;

		// Token: 0x040074DC RID: 29916
		[AutoBind("./Margin/ArenaAutoButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_arenaAutoButton;

		// Token: 0x040074DD RID: 29917
		[AutoBind("./TopLeft", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_topLeftGameObject;

		// Token: 0x040074DE RID: 29918
		[AutoBind("./TopLeft/SimpleInfoButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_actorSimpleInfoButton;

		// Token: 0x040074DF RID: 29919
		[AutoBind("./TopLeft/SimpleInfoButton", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_actorSimpleInfoUIStateController;

		// Token: 0x040074E0 RID: 29920
		[AutoBind("./TopLeft/SimpleInfoButton/Head", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_actorSimpleInfoHeadImage;

		// Token: 0x040074E1 RID: 29921
		[AutoBind("./TopLeft/SimpleInfoButton/Name/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_actorSimpleInfoNameText;

		// Token: 0x040074E2 RID: 29922
		[AutoBind("./TopLeft/SimpleInfoButton/Level/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_actorSimpleInfoLevelText;

		// Token: 0x040074E3 RID: 29923
		[AutoBind("./TopLeft/SimpleInfoButton/Army/Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_actorSimpleInfoArmyImage;

		// Token: 0x040074E4 RID: 29924
		[AutoBind("./TopLeft/SimpleInfoButton/HeroHP/Bar", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_actorSimpleInfoHeroHPImage;

		// Token: 0x040074E5 RID: 29925
		[AutoBind("./TopLeft/SimpleInfoButton/HeroHP/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_actorSimpleInfoHeroHPText;

		// Token: 0x040074E6 RID: 29926
		[AutoBind("./TopLeft/SimpleInfoButton/SoldierHP/Bar", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_actorSimpleInfoSoldierHPImage;

		// Token: 0x040074E7 RID: 29927
		[AutoBind("./TopLeft/SimpleInfoButton/SoldierHP/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_actorSimpleInfoSoldierHPText;

		// Token: 0x040074E8 RID: 29928
		[AutoBind("./Margin/TopLeft", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_topLeftGameObject2;

		// Token: 0x040074E9 RID: 29929
		[AutoBind("./Margin/TopLeft/RegretButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_regratButton;

		// Token: 0x040074EA RID: 29930
		[AutoBind("./Margin/TopLeft/RegretButton", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_regretButtonUIStateController;

		// Token: 0x040074EB RID: 29931
		[AutoBind("./Margin/TopLeft/RegretButton/Count/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_regretCountText;

		// Token: 0x040074EC RID: 29932
		[AutoBind("./Margin/TopRight", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_topRightGameObject2;

		// Token: 0x040074ED RID: 29933
		[AutoBind("./Margin/TopRight/PauseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_pauseButton;

		// Token: 0x040074EE RID: 29934
		[AutoBind("./Margin/TopRight/AutoButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_autoButton;

		// Token: 0x040074EF RID: 29935
		[AutoBind("./Margin/TopRight/AutoButton", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_autoButtonUIStateController;

		// Token: 0x040074F0 RID: 29936
		[AutoBind("./Margin/TopRight/FastButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_fastButton;

		// Token: 0x040074F1 RID: 29937
		[AutoBind("./Margin/TopRight/FastButton", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_fastButtonUIStateController;

		// Token: 0x040074F2 RID: 29938
		[AutoBind("./Margin/TopRight/SkipButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_skipCombatButton;

		// Token: 0x040074F3 RID: 29939
		[AutoBind("./Margin/TopRight/SkipButton", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_skipCombatButtonUIStateController;

		// Token: 0x040074F4 RID: 29940
		[AutoBind("./Margin/TopRight/TerrainInfo", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_terrainInfoGameObject;

		// Token: 0x040074F5 RID: 29941
		[AutoBind("./Margin/TopRight/TerrainInfo", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_terrainInfoButton;

		// Token: 0x040074F6 RID: 29942
		[AutoBind("./Margin/TopRight/TerrainInfo/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_terrainInfoText;

		// Token: 0x040074F7 RID: 29943
		[AutoBind("./Margin/TopRight/TerrainInfo/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_terrainInfoImage;

		// Token: 0x040074F8 RID: 29944
		[AutoBind("./Margin/TopRight/TerrainInfo/Def/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_terrainInfoDefText;

		// Token: 0x040074F9 RID: 29945
		[AutoBind("./Margin/Bottom", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_bottomGameObject;

		// Token: 0x040074FA RID: 29946
		[AutoBind("./Margin/Bottom/DangerOnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_dangerOnButton;

		// Token: 0x040074FB RID: 29947
		[AutoBind("./Margin/Bottom/DangerOffButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_dangerOffButton;

		// Token: 0x040074FC RID: 29948
		[AutoBind("./Margin/Bottom/EndAllActionButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_endAllActionButton;

		// Token: 0x040074FD RID: 29949
		[AutoBind("./Margin/Bottom/UseSkillButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_useSkillButton;

		// Token: 0x040074FE RID: 29950
		[AutoBind("./Margin/Bottom/CancelSkillButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_cancelSkillButton;

		// Token: 0x040074FF RID: 29951
		[AutoBind("./Margin/Bottom/ChatButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_chatButton;

		// Token: 0x04007500 RID: 29952
		[AutoBind("./Margin/Bottom/ChatButton/CountPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_chatRedPoint;

		// Token: 0x04007501 RID: 29953
		[AutoBind("./Margin/Bottom/Skills", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_skillsUIStateController;

		// Token: 0x04007502 RID: 29954
		[AutoBind("./Margin/Bottom/Skills/EndActionButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_endActionButton;

		// Token: 0x04007503 RID: 29955
		[AutoBind("./Margin/Bottom/Skills/List", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillListGameObject;

		// Token: 0x04007504 RID: 29956
		[AutoBind("./Margin/Bottom/Skills/List", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_skillListUIStateController;

		// Token: 0x04007505 RID: 29957
		[AutoBind("./Margin/Bottom/SkillDesc", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillDescGameObject;

		// Token: 0x04007506 RID: 29958
		[AutoBind("./Margin/Bottom/SkillHint", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_skillHintUIStateController;

		// Token: 0x04007507 RID: 29959
		[AutoBind("./Margin/Bottom/SkillHint/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_skillHintText;

		// Token: 0x04007508 RID: 29960
		[AutoBind("./Margin/Bottom/Status", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_statusUIStateController;

		// Token: 0x04007509 RID: 29961
		[AutoBind("./Margin/Bottom/Status/TutnValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_statusTurnText;

		// Token: 0x0400750A RID: 29962
		[AutoBind("./Margin/Bottom/Status/ConditionGroup/Condition1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_statusWinDescGameObject1;

		// Token: 0x0400750B RID: 29963
		[AutoBind("./Margin/Bottom/Status/ConditionGroup/Condition1/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_statusWinDescText1;

		// Token: 0x0400750C RID: 29964
		[AutoBind("./Margin/Bottom/Status/ConditionGroup/Condition2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_statusWinDescGameObject2;

		// Token: 0x0400750D RID: 29965
		[AutoBind("./Margin/Bottom/Status/ConditionGroup/Condition2/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_statusWinDescText2;

		// Token: 0x0400750E RID: 29966
		[AutoBind("./Margin/Bottom/Danmaku", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_danmakuStateCtrl;

		// Token: 0x0400750F RID: 29967
		[AutoBind("./Margin/Bottom/Danmaku", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_danmakuInputBackButton;

		// Token: 0x04007510 RID: 29968
		[AutoBind("./Margin/Bottom/DanmakuToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_danmakuToggle;

		// Token: 0x04007511 RID: 29969
		[AutoBind("./Margin/Bottom/DanmakuToggle/InputWordButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_danmakuInputWordButton;

		// Token: 0x04007512 RID: 29970
		[AutoBind("./Margin/Bottom/Danmaku/Input/InputField", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_danmakuInputField;

		// Token: 0x04007513 RID: 29971
		[AutoBind("./Margin/Bottom/Danmaku/Input/SendButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_danmakuSendButton;

		// Token: 0x04007514 RID: 29972
		[AutoBind("./RegretInOrOut", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_regretUIStateController;

		// Token: 0x04007515 RID: 29973
		[AutoBind("./Margin/RegretPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_regretPanelGameObject;

		// Token: 0x04007516 RID: 29974
		[AutoBind("./Margin/RegretPanel/ConfirmButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_regratConfirmButton;

		// Token: 0x04007517 RID: 29975
		[AutoBind("./Margin/RegretPanel/ConfirmButton", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_regretConfirmUIStateController;

		// Token: 0x04007518 RID: 29976
		[AutoBind("./Margin/RegretPanel/CancelButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_regretCancelButton;

		// Token: 0x04007519 RID: 29977
		[AutoBind("./Margin/RegretPanel/BackwardButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_regretBackwardButton;

		// Token: 0x0400751A RID: 29978
		[AutoBind("./Margin/RegretPanel/BackwardButton", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_regretBackwardUIStateController;

		// Token: 0x0400751B RID: 29979
		[AutoBind("./Margin/RegretPanel/ForwardButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_regretForwardButton;

		// Token: 0x0400751C RID: 29980
		[AutoBind("./Margin/RegretPanel/ForwardButton", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_regretForwardUIStateController;

		// Token: 0x0400751D RID: 29981
		[AutoBind("./Margin/RegretPanel/RoundDetail/Info/RoundText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_regretTurnText;

		// Token: 0x0400751E RID: 29982
		[AutoBind("./Margin/RegretPanel/RoundDetail/Info/ActionText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_regretActionText;

		// Token: 0x0400751F RID: 29983
		[AutoBind("./Margin/RegretPanel/RoundDetail/Info/ActionCountGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_regretTurnUIStateController;

		// Token: 0x04007520 RID: 29984
		[AutoBind("./Margin/RegretPanel/RoundDetail/Info/ActionCountGroup/MyCountText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_regretMyCountText;

		// Token: 0x04007521 RID: 29985
		[AutoBind("./Margin/RegretPanel/RoundDetail/Info/ActionCountGroup/EnemyCountText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_regretEnemyCountText;

		// Token: 0x04007522 RID: 29986
		[AutoBind("./Margin/RegretPanel/EffectImage", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_regretEffectUIStateController;

		// Token: 0x04007523 RID: 29987
		[AutoBind("./Margin/FXRegret", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_regretFxUIStateController;

		// Token: 0x04007524 RID: 29988
		[AutoBind("./CutsceneSkill", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_cutsceneSkillUIStateController;

		// Token: 0x04007525 RID: 29989
		[AutoBind("./CutsceneSkill/Icon/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_cutsceneSkillIconImage;

		// Token: 0x04007526 RID: 29990
		[AutoBind("./CutsceneSkill/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_cutsceneSkillNameText;

		// Token: 0x04007527 RID: 29991
		[AutoBind("./Objective", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_objectiveGameObject;

		// Token: 0x04007528 RID: 29992
		[AutoBind("./Objective/BGImage/WinDescGroup/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_objectiveWinDescText;

		// Token: 0x04007529 RID: 29993
		[AutoBind("./Objective/BGImage/LoseDescText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_objectiveLoseDescText;

		// Token: 0x0400752A RID: 29994
		[AutoBind("./Win", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_winGameObject;

		// Token: 0x0400752B RID: 29995
		[AutoBind("./Lose", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_loseGameObject;

		// Token: 0x0400752C RID: 29996
		[AutoBind("./TurnStart", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_turnStartGameObject;

		// Token: 0x0400752D RID: 29997
		[AutoBind("./TurnStart/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_turnStartText;

		// Token: 0x0400752E RID: 29998
		[AutoBind("./PlayerTurn", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_playerTurnGameObject;

		// Token: 0x0400752F RID: 29999
		[AutoBind("./EnemyTurn", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_enemyTurnGameObject;

		// Token: 0x04007530 RID: 30000
		[AutoBind("./MyAction", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_myActionUIStateController;

		// Token: 0x04007531 RID: 30001
		[AutoBind("./MyAction/DetailPanel/PlayerIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_myActionHeadImage;

		// Token: 0x04007532 RID: 30002
		[AutoBind("./MyAction/DetailPanel/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_myActionNameText;

		// Token: 0x04007533 RID: 30003
		[AutoBind("./MyAction/DetailPanel/PlayerTag", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_myActionPlayerTagImage;

		// Token: 0x04007534 RID: 30004
		[AutoBind("./TeammateAction", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_teammateActionUIStateController;

		// Token: 0x04007535 RID: 30005
		[AutoBind("./TeammateAction/DetailPanel/PlayerIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_teammateActionHeadImage;

		// Token: 0x04007536 RID: 30006
		[AutoBind("./TeammateAction/DetailPanel/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_teammateActionNameText;

		// Token: 0x04007537 RID: 30007
		[AutoBind("./TeammateAction/DetailPanel/PlayerTag", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_teammateActionPlayerTagImage;

		// Token: 0x04007538 RID: 30008
		[AutoBind("./EnemyAction", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_enemyActionUIStateController;

		// Token: 0x04007539 RID: 30009
		[AutoBind("./EnemyAction/DetailPanel/PlayerIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_enemyActionHeadImage;

		// Token: 0x0400753A RID: 30010
		[AutoBind("./EnemyAction/DetailPanel/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enemyActionNameText;

		// Token: 0x0400753B RID: 30011
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_prefabsGameObject;

		// Token: 0x0400753C RID: 30012
		[AutoBind("./Prefabs/BattleSkillButton", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_battleSkillButtonPrefab;

		// Token: 0x0400753D RID: 30013
		private CommonUIStateController m_armyRelationButtonUIStateController;

		// Token: 0x0400753E RID: 30014
		private CommonUIStateController m_armyRelationDescUIStateController;

		// Token: 0x0400753F RID: 30015
		private Vector2 m_pointerDownPosition;

		// Token: 0x04007540 RID: 30016
		private GameObjectPool<BattleSkillButton> m_battleSkillButtonPool;

		// Token: 0x04007541 RID: 30017
		private float m_chatRedPointLastTime;

		// Token: 0x04007542 RID: 30018
		private float m_hideSkillHintTime;

		// Token: 0x04007543 RID: 30019
		private bool m_isShowSkillHint;

		// Token: 0x04007544 RID: 30020
		private bool m_isShowRegretPanel;

		// Token: 0x04007545 RID: 30021
		private int m_developerClickCount;

		// Token: 0x04007546 RID: 30022
		private int m_turn;

		// Token: 0x04007547 RID: 30023
		private IConfigDataLoader m_configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;

		// Token: 0x04007548 RID: 30024
		private ProjectLPlayerContext m_playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x04007549 RID: 30025
		[DoNotToLua]
		private BattleUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400754A RID: 30026
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400754B RID: 30027
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400754C RID: 30028
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400754D RID: 30029
		private LuaFunction m_Update_hotfix;

		// Token: 0x0400754E RID: 30030
		private LuaFunction m_StartBattle_hotfix;

		// Token: 0x0400754F RID: 30031
		private LuaFunction m_StopBattleBoolean_hotfix;

		// Token: 0x04007550 RID: 30032
		private LuaFunction m_WinOrLoseTweenFinished_hotfix;

		// Token: 0x04007551 RID: 30033
		private LuaFunction m_ShowTurnStatusBoolean_hotfix;

		// Token: 0x04007552 RID: 30034
		private LuaFunction m_ShowObjeciveStringString_hotfix;

		// Token: 0x04007553 RID: 30035
		private LuaFunction m_ShowTurnStartInt32Int32_hotfix;

		// Token: 0x04007554 RID: 30036
		private LuaFunction m_ShowPlayerTurn_hotfix;

		// Token: 0x04007555 RID: 30037
		private LuaFunction m_ShowEnemyTurn_hotfix;

		// Token: 0x04007556 RID: 30038
		private LuaFunction m_ShowMyActionBattleRoomPlayerInt32Action_hotfix;

		// Token: 0x04007557 RID: 30039
		private LuaFunction m_ShowTeammateActionBattleRoomPlayerInt32Action_hotfix;

		// Token: 0x04007558 RID: 30040
		private LuaFunction m_ShowEnemyActionBattleRoomPlayer_hotfix;

		// Token: 0x04007559 RID: 30041
		private LuaFunction m_HidePauseButton_hotfix;

		// Token: 0x0400755A RID: 30042
		private LuaFunction m_ShowChatButtonBoolean_hotfix;

		// Token: 0x0400755B RID: 30043
		private LuaFunction m_SetAutoBattleBoolean_hotfix;

		// Token: 0x0400755C RID: 30044
		private LuaFunction m_HideAutoBattleButton_hotfix;

		// Token: 0x0400755D RID: 30045
		private LuaFunction m_SetArenaAutoBattleBoolean_hotfix;

		// Token: 0x0400755E RID: 30046
		private LuaFunction m_SetFastBattleBoolean_hotfix;

		// Token: 0x0400755F RID: 30047
		private LuaFunction m_SetSkipCombatModeSkipCombatMode_hotfix;

		// Token: 0x04007560 RID: 30048
		private LuaFunction m_SetActorSimpleInfoBattleActor_hotfix;

		// Token: 0x04007561 RID: 30049
		private LuaFunction m_ShowActorSimpleInfoBoolean_hotfix;

		// Token: 0x04007562 RID: 30050
		private LuaFunction m_IsShowActorSimpleInfo_hotfix;

		// Token: 0x04007563 RID: 30051
		private LuaFunction m_SetShowDangerBoolean_hotfix;

		// Token: 0x04007564 RID: 30052
		private LuaFunction m_ShowEndActionBoolean_hotfix;

		// Token: 0x04007565 RID: 30053
		private LuaFunction m_ShowEndAllActionBoolean_hotfix;

		// Token: 0x04007566 RID: 30054
		private LuaFunction m_SetActionOrderTypeActionOrderType_hotfix;

		// Token: 0x04007567 RID: 30055
		private LuaFunction m_RefreshChatRedState_hotfix;

		// Token: 0x04007568 RID: 30056
		private LuaFunction m_ShowTopUIBoolean_hotfix;

		// Token: 0x04007569 RID: 30057
		private LuaFunction m_IsShowTopUI_hotfix;

		// Token: 0x0400756A RID: 30058
		private LuaFunction m_ShowBottomUIBoolean_hotfix;

		// Token: 0x0400756B RID: 30059
		private LuaFunction m_IsShowBottomUI_hotfix;

		// Token: 0x0400756C RID: 30060
		private LuaFunction m_ShowSkillsList;

		// Token: 0x0400756D RID: 30061
		private LuaFunction m_GetSkillButtonRectTransformInt32_hotfix;

		// Token: 0x0400756E RID: 30062
		private LuaFunction m_HideSkills_hotfix;

		// Token: 0x0400756F RID: 30063
		private LuaFunction m_ShowUseOrCancelSkillBoolean_hotfix;

		// Token: 0x04007570 RID: 30064
		private LuaFunction m_ShowUseSkillBoolean_hotfix;

		// Token: 0x04007571 RID: 30065
		private LuaFunction m_SetCurrentSkillBattleSkillState_hotfix;

		// Token: 0x04007572 RID: 30066
		private LuaFunction m_ShowSkillHintStringTableIdSingle_hotfix;

		// Token: 0x04007573 RID: 30067
		private LuaFunction m_HideSkillHint_hotfix;

		// Token: 0x04007574 RID: 30068
		private LuaFunction m_HighlightSkillHint_hotfix;

		// Token: 0x04007575 RID: 30069
		private LuaFunction m_ShowTerrainInfoConfigDataTerrainInfo_hotfix;

		// Token: 0x04007576 RID: 30070
		private LuaFunction m_HideTerrainInfo_hotfix;

		// Token: 0x04007577 RID: 30071
		private LuaFunction m_ShowArmyRelationButton_hotfix;

		// Token: 0x04007578 RID: 30072
		private LuaFunction m_HideArmyRelation_hotfix;

		// Token: 0x04007579 RID: 30073
		private LuaFunction m_ShowArmyRelationDesc_hotfix;

		// Token: 0x0400757A RID: 30074
		private LuaFunction m_HideArmyRelationDesc_hotfix;

		// Token: 0x0400757B RID: 30075
		private LuaFunction m_IsArmyRelationDescVisible_hotfix;

		// Token: 0x0400757C RID: 30076
		private LuaFunction m_ShowCutsceneSkillConfigDataSkillInfo_hotfix;

		// Token: 0x0400757D RID: 30077
		private LuaFunction m_HideCutsceneSkill_hotfix;

		// Token: 0x0400757E RID: 30078
		private LuaFunction m_OnPauseButtonClick_hotfix;

		// Token: 0x0400757F RID: 30079
		private LuaFunction m_OnArmyRelationButtonClick_hotfix;

		// Token: 0x04007580 RID: 30080
		private LuaFunction m_OnAutoButtonClick_hotfix;

		// Token: 0x04007581 RID: 30081
		private LuaFunction m_OnAutoOffButtonClick_hotfix;

		// Token: 0x04007582 RID: 30082
		private LuaFunction m_OnArenaAutoButtonClick_hotfix;

		// Token: 0x04007583 RID: 30083
		private LuaFunction m_OnFastButtonClick_hotfix;

		// Token: 0x04007584 RID: 30084
		private LuaFunction m_OnSkipCombatButtonClick_hotfix;

		// Token: 0x04007585 RID: 30085
		private LuaFunction m_OnDangerOnButtonClick_hotfix;

		// Token: 0x04007586 RID: 30086
		private LuaFunction m_OnDangerOffButtonClick_hotfix;

		// Token: 0x04007587 RID: 30087
		private LuaFunction m_OnEndActionButtonClick_hotfix;

		// Token: 0x04007588 RID: 30088
		private LuaFunction m_OnEndAllActionButtonClick_hotfix;

		// Token: 0x04007589 RID: 30089
		private LuaFunction m_OnActorSimpleInfoButtonClick_hotfix;

		// Token: 0x0400758A RID: 30090
		private LuaFunction m_OnUseSkillButtonClick_hotfix;

		// Token: 0x0400758B RID: 30091
		private LuaFunction m_OnCancelSkillButtonClick_hotfix;

		// Token: 0x0400758C RID: 30092
		private LuaFunction m_BattleSkillButton_OnClickBattleSkillButton_hotfix;

		// Token: 0x0400758D RID: 30093
		private LuaFunction m_OnChatButtonClick_hotfix;

		// Token: 0x0400758E RID: 30094
		private LuaFunction m_OnHelpButtonClick_hotfix;

		// Token: 0x0400758F RID: 30095
		private LuaFunction m_OnTerrainInfoButtonClick_hotfix;

		// Token: 0x04007590 RID: 30096
		private LuaFunction m_DeveloperModeClick_hotfix;

		// Token: 0x04007591 RID: 30097
		private LuaFunction m_ShowDanmakuToggleBoolean_hotfix;

		// Token: 0x04007592 RID: 30098
		private LuaFunction m_ShowCurTurnDanmakuInt32_hotfix;

		// Token: 0x04007593 RID: 30099
		private LuaFunction m_OnDanmakuToggleValueChangedBoolean_hotfix;

		// Token: 0x04007594 RID: 30100
		private LuaFunction m_OnDanmakuInputWordButtonClick_hotfix;

		// Token: 0x04007595 RID: 30101
		private LuaFunction m_OnDanmakuInputBackButtonClick_hotfix;

		// Token: 0x04007596 RID: 30102
		private LuaFunction m_OnDanmakuSendButtonClick_hotfix;

		// Token: 0x04007597 RID: 30103
		private LuaFunction m_SetRegretCountInt32Int32_hotfix;

		// Token: 0x04007598 RID: 30104
		private LuaFunction m_SetRegretTurnStatusInt32Int32Int32Int32_hotfix;

		// Token: 0x04007599 RID: 30105
		private LuaFunction m_SetRegretButtonStatusBooleanBooleanBoolean_hotfix;

		// Token: 0x0400759A RID: 30106
		private LuaFunction m_ShowRegretButtonBoolean_hotfix;

		// Token: 0x0400759B RID: 30107
		private LuaFunction m_ShowRegretPanelBoolean_hotfix;

		// Token: 0x0400759C RID: 30108
		private LuaFunction m_ShowRegretConfirmFxAction_hotfix;

		// Token: 0x0400759D RID: 30109
		private LuaFunction m_OnRegretButtonClick_hotfix;

		// Token: 0x0400759E RID: 30110
		private LuaFunction m_OnRegretConfirmButtonClick_hotfix;

		// Token: 0x0400759F RID: 30111
		private LuaFunction m_OnRegretCancelButtonClick_hotfix;

		// Token: 0x040075A0 RID: 30112
		private LuaFunction m_OnRegretBackwardButtonClick_hotfix;

		// Token: 0x040075A1 RID: 30113
		private LuaFunction m_OnRegretForwardButtonClick_hotfix;

		// Token: 0x040075A2 RID: 30114
		private LuaFunction m_OnScenePointerDownPointerEventData_hotfix;

		// Token: 0x040075A3 RID: 30115
		private LuaFunction m_OnScenePointerUpPointerEventData_hotfix;

		// Token: 0x040075A4 RID: 30116
		private LuaFunction m_OnScenePointerClickPointerEventData_hotfix;

		// Token: 0x040075A5 RID: 30117
		private LuaFunction m_OnSceneBeginDragPointerEventData_hotfix;

		// Token: 0x040075A6 RID: 30118
		private LuaFunction m_OnSceneEndDragPointerEventData_hotfix;

		// Token: 0x040075A7 RID: 30119
		private LuaFunction m_OnSceneDragPointerEventData_hotfix;

		// Token: 0x040075A8 RID: 30120
		private LuaFunction m_OnScene3DTouchVector2_hotfix;

		// Token: 0x040075A9 RID: 30121
		private LuaFunction m_add_EventOnPauseBattleAction_hotfix;

		// Token: 0x040075AA RID: 30122
		private LuaFunction m_remove_EventOnPauseBattleAction_hotfix;

		// Token: 0x040075AB RID: 30123
		private LuaFunction m_add_EventOnShowArmyRelationAction_hotfix;

		// Token: 0x040075AC RID: 30124
		private LuaFunction m_remove_EventOnShowArmyRelationAction_hotfix;

		// Token: 0x040075AD RID: 30125
		private LuaFunction m_add_EventOnAutoBattleAction;

		// Token: 0x040075AE RID: 30126
		private LuaFunction m_remove_EventOnAutoBattleAction;

		// Token: 0x040075AF RID: 30127
		private LuaFunction m_add_EventOnFastBattleAction;

		// Token: 0x040075B0 RID: 30128
		private LuaFunction m_remove_EventOnFastBattleAction;

		// Token: 0x040075B1 RID: 30129
		private LuaFunction m_add_EventOnSkipCombatAction;

		// Token: 0x040075B2 RID: 30130
		private LuaFunction m_remove_EventOnSkipCombatAction;

		// Token: 0x040075B3 RID: 30131
		private LuaFunction m_add_EventOnShowDangerAction;

		// Token: 0x040075B4 RID: 30132
		private LuaFunction m_remove_EventOnShowDangerAction;

		// Token: 0x040075B5 RID: 30133
		private LuaFunction m_add_EventOnEndActionAction_hotfix;

		// Token: 0x040075B6 RID: 30134
		private LuaFunction m_remove_EventOnEndActionAction_hotfix;

		// Token: 0x040075B7 RID: 30135
		private LuaFunction m_add_EventOnShowActorInfoAction_hotfix;

		// Token: 0x040075B8 RID: 30136
		private LuaFunction m_remove_EventOnShowActorInfoAction_hotfix;

		// Token: 0x040075B9 RID: 30137
		private LuaFunction m_add_EventOnEndAllActionAction_hotfix;

		// Token: 0x040075BA RID: 30138
		private LuaFunction m_remove_EventOnEndAllActionAction_hotfix;

		// Token: 0x040075BB RID: 30139
		private LuaFunction m_add_EventOnUseSkillAction_hotfix;

		// Token: 0x040075BC RID: 30140
		private LuaFunction m_remove_EventOnUseSkillAction_hotfix;

		// Token: 0x040075BD RID: 30141
		private LuaFunction m_add_EventOnCancelSkillAction_hotfix;

		// Token: 0x040075BE RID: 30142
		private LuaFunction m_remove_EventOnCancelSkillAction_hotfix;

		// Token: 0x040075BF RID: 30143
		private LuaFunction m_add_EventOnWinOrLoseEndAction_hotfix;

		// Token: 0x040075C0 RID: 30144
		private LuaFunction m_remove_EventOnWinOrLoseEndAction_hotfix;

		// Token: 0x040075C1 RID: 30145
		private LuaFunction m_add_EventOnShowChatAction_hotfix;

		// Token: 0x040075C2 RID: 30146
		private LuaFunction m_remove_EventOnShowChatAction_hotfix;

		// Token: 0x040075C3 RID: 30147
		private LuaFunction m_add_EventOnShowHelpAction_hotfix;

		// Token: 0x040075C4 RID: 30148
		private LuaFunction m_remove_EventOnShowHelpAction_hotfix;

		// Token: 0x040075C5 RID: 30149
		private LuaFunction m_add_EventOnSelectSkillAction;

		// Token: 0x040075C6 RID: 30150
		private LuaFunction m_remove_EventOnSelectSkillAction;

		// Token: 0x040075C7 RID: 30151
		private LuaFunction m_add_EventOnPointerDownAction;

		// Token: 0x040075C8 RID: 30152
		private LuaFunction m_remove_EventOnPointerDownAction;

		// Token: 0x040075C9 RID: 30153
		private LuaFunction m_add_EventOnPointerUpAction;

		// Token: 0x040075CA RID: 30154
		private LuaFunction m_remove_EventOnPointerUpAction;

		// Token: 0x040075CB RID: 30155
		private LuaFunction m_add_EventOnPointerClickAction;

		// Token: 0x040075CC RID: 30156
		private LuaFunction m_remove_EventOnPointerClickAction;

		// Token: 0x040075CD RID: 30157
		private LuaFunction m_add_EventOn3DTouchAction;

		// Token: 0x040075CE RID: 30158
		private LuaFunction m_remove_EventOn3DTouchAction;

		// Token: 0x040075CF RID: 30159
		private LuaFunction m_add_EventOnShowCurTurnDanmakuAction;

		// Token: 0x040075D0 RID: 30160
		private LuaFunction m_remove_EventOnShowCurTurnDanmakuAction;

		// Token: 0x040075D1 RID: 30161
		private LuaFunction m_add_EventOnCloseCurTurnDanmakuAction_hotfix;

		// Token: 0x040075D2 RID: 30162
		private LuaFunction m_remove_EventOnCloseCurTurnDanmakuAction_hotfix;

		// Token: 0x040075D3 RID: 30163
		private LuaFunction m_add_EventOnShowOneDanmakuAction;

		// Token: 0x040075D4 RID: 30164
		private LuaFunction m_remove_EventOnShowOneDanmakuAction;

		// Token: 0x040075D5 RID: 30165
		private LuaFunction m_add_EventOnRegretActiveAction_hotfix;

		// Token: 0x040075D6 RID: 30166
		private LuaFunction m_remove_EventOnRegretActiveAction_hotfix;

		// Token: 0x040075D7 RID: 30167
		private LuaFunction m_add_EventOnRegretConfirmAction_hotfix;

		// Token: 0x040075D8 RID: 30168
		private LuaFunction m_remove_EventOnRegretConfirmAction_hotfix;

		// Token: 0x040075D9 RID: 30169
		private LuaFunction m_add_EventOnRegretCancelAction_hotfix;

		// Token: 0x040075DA RID: 30170
		private LuaFunction m_remove_EventOnRegretCancelAction_hotfix;

		// Token: 0x040075DB RID: 30171
		private LuaFunction m_add_EventOnRegretBackwardAction_hotfix;

		// Token: 0x040075DC RID: 30172
		private LuaFunction m_remove_EventOnRegretBackwardAction_hotfix;

		// Token: 0x040075DD RID: 30173
		private LuaFunction m_add_EventOnRegretForwardAction_hotfix;

		// Token: 0x040075DE RID: 30174
		private LuaFunction m_remove_EventOnRegretForwardAction_hotfix;

		// Token: 0x02000AD1 RID: 2769
		public new class LuaExportHelper
		{
			// Token: 0x0600B55C RID: 46428 RVA: 0x003242C4 File Offset: 0x003224C4
			public LuaExportHelper(BattleUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600B55D RID: 46429 RVA: 0x003242D4 File Offset: 0x003224D4
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600B55E RID: 46430 RVA: 0x003242E4 File Offset: 0x003224E4
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600B55F RID: 46431 RVA: 0x003242F4 File Offset: 0x003224F4
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600B560 RID: 46432 RVA: 0x00324304 File Offset: 0x00322504
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600B561 RID: 46433 RVA: 0x0032431C File Offset: 0x0032251C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600B562 RID: 46434 RVA: 0x0032432C File Offset: 0x0032252C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600B563 RID: 46435 RVA: 0x0032433C File Offset: 0x0032253C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600B564 RID: 46436 RVA: 0x0032434C File Offset: 0x0032254C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600B565 RID: 46437 RVA: 0x0032435C File Offset: 0x0032255C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600B566 RID: 46438 RVA: 0x0032436C File Offset: 0x0032256C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600B567 RID: 46439 RVA: 0x0032437C File Offset: 0x0032257C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600B568 RID: 46440 RVA: 0x0032438C File Offset: 0x0032258C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600B569 RID: 46441 RVA: 0x0032439C File Offset: 0x0032259C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600B56A RID: 46442 RVA: 0x003243AC File Offset: 0x003225AC
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600B56B RID: 46443 RVA: 0x003243BC File Offset: 0x003225BC
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600B56C RID: 46444 RVA: 0x003243CC File Offset: 0x003225CC
			public void __callDele_EventOnPauseBattle()
			{
				this.m_owner.__callDele_EventOnPauseBattle();
			}

			// Token: 0x0600B56D RID: 46445 RVA: 0x003243DC File Offset: 0x003225DC
			public void __clearDele_EventOnPauseBattle()
			{
				this.m_owner.__clearDele_EventOnPauseBattle();
			}

			// Token: 0x0600B56E RID: 46446 RVA: 0x003243EC File Offset: 0x003225EC
			public void __callDele_EventOnShowArmyRelation()
			{
				this.m_owner.__callDele_EventOnShowArmyRelation();
			}

			// Token: 0x0600B56F RID: 46447 RVA: 0x003243FC File Offset: 0x003225FC
			public void __clearDele_EventOnShowArmyRelation()
			{
				this.m_owner.__clearDele_EventOnShowArmyRelation();
			}

			// Token: 0x0600B570 RID: 46448 RVA: 0x0032440C File Offset: 0x0032260C
			public void __callDele_EventOnAutoBattle(bool obj)
			{
				this.m_owner.__callDele_EventOnAutoBattle(obj);
			}

			// Token: 0x0600B571 RID: 46449 RVA: 0x0032441C File Offset: 0x0032261C
			public void __clearDele_EventOnAutoBattle(bool obj)
			{
				this.m_owner.__clearDele_EventOnAutoBattle(obj);
			}

			// Token: 0x0600B572 RID: 46450 RVA: 0x0032442C File Offset: 0x0032262C
			public void __callDele_EventOnFastBattle(bool obj)
			{
				this.m_owner.__callDele_EventOnFastBattle(obj);
			}

			// Token: 0x0600B573 RID: 46451 RVA: 0x0032443C File Offset: 0x0032263C
			public void __clearDele_EventOnFastBattle(bool obj)
			{
				this.m_owner.__clearDele_EventOnFastBattle(obj);
			}

			// Token: 0x0600B574 RID: 46452 RVA: 0x0032444C File Offset: 0x0032264C
			public void __callDele_EventOnSkipCombat(SkipCombatMode obj)
			{
				this.m_owner.__callDele_EventOnSkipCombat(obj);
			}

			// Token: 0x0600B575 RID: 46453 RVA: 0x0032445C File Offset: 0x0032265C
			public void __clearDele_EventOnSkipCombat(SkipCombatMode obj)
			{
				this.m_owner.__clearDele_EventOnSkipCombat(obj);
			}

			// Token: 0x0600B576 RID: 46454 RVA: 0x0032446C File Offset: 0x0032266C
			public void __callDele_EventOnShowDanger(bool obj)
			{
				this.m_owner.__callDele_EventOnShowDanger(obj);
			}

			// Token: 0x0600B577 RID: 46455 RVA: 0x0032447C File Offset: 0x0032267C
			public void __clearDele_EventOnShowDanger(bool obj)
			{
				this.m_owner.__clearDele_EventOnShowDanger(obj);
			}

			// Token: 0x0600B578 RID: 46456 RVA: 0x0032448C File Offset: 0x0032268C
			public void __callDele_EventOnEndAction()
			{
				this.m_owner.__callDele_EventOnEndAction();
			}

			// Token: 0x0600B579 RID: 46457 RVA: 0x0032449C File Offset: 0x0032269C
			public void __clearDele_EventOnEndAction()
			{
				this.m_owner.__clearDele_EventOnEndAction();
			}

			// Token: 0x0600B57A RID: 46458 RVA: 0x003244AC File Offset: 0x003226AC
			public void __callDele_EventOnShowActorInfo()
			{
				this.m_owner.__callDele_EventOnShowActorInfo();
			}

			// Token: 0x0600B57B RID: 46459 RVA: 0x003244BC File Offset: 0x003226BC
			public void __clearDele_EventOnShowActorInfo()
			{
				this.m_owner.__clearDele_EventOnShowActorInfo();
			}

			// Token: 0x0600B57C RID: 46460 RVA: 0x003244CC File Offset: 0x003226CC
			public void __callDele_EventOnEndAllAction()
			{
				this.m_owner.__callDele_EventOnEndAllAction();
			}

			// Token: 0x0600B57D RID: 46461 RVA: 0x003244DC File Offset: 0x003226DC
			public void __clearDele_EventOnEndAllAction()
			{
				this.m_owner.__clearDele_EventOnEndAllAction();
			}

			// Token: 0x0600B57E RID: 46462 RVA: 0x003244EC File Offset: 0x003226EC
			public void __callDele_EventOnUseSkill()
			{
				this.m_owner.__callDele_EventOnUseSkill();
			}

			// Token: 0x0600B57F RID: 46463 RVA: 0x003244FC File Offset: 0x003226FC
			public void __clearDele_EventOnUseSkill()
			{
				this.m_owner.__clearDele_EventOnUseSkill();
			}

			// Token: 0x0600B580 RID: 46464 RVA: 0x0032450C File Offset: 0x0032270C
			public void __callDele_EventOnCancelSkill()
			{
				this.m_owner.__callDele_EventOnCancelSkill();
			}

			// Token: 0x0600B581 RID: 46465 RVA: 0x0032451C File Offset: 0x0032271C
			public void __clearDele_EventOnCancelSkill()
			{
				this.m_owner.__clearDele_EventOnCancelSkill();
			}

			// Token: 0x0600B582 RID: 46466 RVA: 0x0032452C File Offset: 0x0032272C
			public void __callDele_EventOnWinOrLoseEnd()
			{
				this.m_owner.__callDele_EventOnWinOrLoseEnd();
			}

			// Token: 0x0600B583 RID: 46467 RVA: 0x0032453C File Offset: 0x0032273C
			public void __clearDele_EventOnWinOrLoseEnd()
			{
				this.m_owner.__clearDele_EventOnWinOrLoseEnd();
			}

			// Token: 0x0600B584 RID: 46468 RVA: 0x0032454C File Offset: 0x0032274C
			public void __callDele_EventOnShowChat()
			{
				this.m_owner.__callDele_EventOnShowChat();
			}

			// Token: 0x0600B585 RID: 46469 RVA: 0x0032455C File Offset: 0x0032275C
			public void __clearDele_EventOnShowChat()
			{
				this.m_owner.__clearDele_EventOnShowChat();
			}

			// Token: 0x0600B586 RID: 46470 RVA: 0x0032456C File Offset: 0x0032276C
			public void __callDele_EventOnShowHelp()
			{
				this.m_owner.__callDele_EventOnShowHelp();
			}

			// Token: 0x0600B587 RID: 46471 RVA: 0x0032457C File Offset: 0x0032277C
			public void __clearDele_EventOnShowHelp()
			{
				this.m_owner.__clearDele_EventOnShowHelp();
			}

			// Token: 0x0600B588 RID: 46472 RVA: 0x0032458C File Offset: 0x0032278C
			public void __callDele_EventOnSelectSkill(int obj)
			{
				this.m_owner.__callDele_EventOnSelectSkill(obj);
			}

			// Token: 0x0600B589 RID: 46473 RVA: 0x0032459C File Offset: 0x0032279C
			public void __clearDele_EventOnSelectSkill(int obj)
			{
				this.m_owner.__clearDele_EventOnSelectSkill(obj);
			}

			// Token: 0x0600B58A RID: 46474 RVA: 0x003245AC File Offset: 0x003227AC
			public void __callDele_EventOnPointerDown(PointerEventData.InputButton arg1, Vector2 arg2)
			{
				this.m_owner.__callDele_EventOnPointerDown(arg1, arg2);
			}

			// Token: 0x0600B58B RID: 46475 RVA: 0x003245BC File Offset: 0x003227BC
			public void __clearDele_EventOnPointerDown(PointerEventData.InputButton arg1, Vector2 arg2)
			{
				this.m_owner.__clearDele_EventOnPointerDown(arg1, arg2);
			}

			// Token: 0x0600B58C RID: 46476 RVA: 0x003245CC File Offset: 0x003227CC
			public void __callDele_EventOnPointerUp(PointerEventData.InputButton arg1, Vector2 arg2)
			{
				this.m_owner.__callDele_EventOnPointerUp(arg1, arg2);
			}

			// Token: 0x0600B58D RID: 46477 RVA: 0x003245DC File Offset: 0x003227DC
			public void __clearDele_EventOnPointerUp(PointerEventData.InputButton arg1, Vector2 arg2)
			{
				this.m_owner.__clearDele_EventOnPointerUp(arg1, arg2);
			}

			// Token: 0x0600B58E RID: 46478 RVA: 0x003245EC File Offset: 0x003227EC
			public void __callDele_EventOnPointerClick(PointerEventData.InputButton arg1, Vector2 arg2)
			{
				this.m_owner.__callDele_EventOnPointerClick(arg1, arg2);
			}

			// Token: 0x0600B58F RID: 46479 RVA: 0x003245FC File Offset: 0x003227FC
			public void __clearDele_EventOnPointerClick(PointerEventData.InputButton arg1, Vector2 arg2)
			{
				this.m_owner.__clearDele_EventOnPointerClick(arg1, arg2);
			}

			// Token: 0x0600B590 RID: 46480 RVA: 0x0032460C File Offset: 0x0032280C
			public void __callDele_EventOn3DTouch(Vector2 obj)
			{
				this.m_owner.__callDele_EventOn3DTouch(obj);
			}

			// Token: 0x0600B591 RID: 46481 RVA: 0x0032461C File Offset: 0x0032281C
			public void __clearDele_EventOn3DTouch(Vector2 obj)
			{
				this.m_owner.__clearDele_EventOn3DTouch(obj);
			}

			// Token: 0x0600B592 RID: 46482 RVA: 0x0032462C File Offset: 0x0032282C
			public void __callDele_EventOnShowCurTurnDanmaku(int obj)
			{
				this.m_owner.__callDele_EventOnShowCurTurnDanmaku(obj);
			}

			// Token: 0x0600B593 RID: 46483 RVA: 0x0032463C File Offset: 0x0032283C
			public void __clearDele_EventOnShowCurTurnDanmaku(int obj)
			{
				this.m_owner.__clearDele_EventOnShowCurTurnDanmaku(obj);
			}

			// Token: 0x0600B594 RID: 46484 RVA: 0x0032464C File Offset: 0x0032284C
			public void __callDele_EventOnCloseCurTurnDanmaku()
			{
				this.m_owner.__callDele_EventOnCloseCurTurnDanmaku();
			}

			// Token: 0x0600B595 RID: 46485 RVA: 0x0032465C File Offset: 0x0032285C
			public void __clearDele_EventOnCloseCurTurnDanmaku()
			{
				this.m_owner.__clearDele_EventOnCloseCurTurnDanmaku();
			}

			// Token: 0x0600B596 RID: 46486 RVA: 0x0032466C File Offset: 0x0032286C
			public void __callDele_EventOnShowOneDanmaku(DanmakuEntry obj)
			{
				this.m_owner.__callDele_EventOnShowOneDanmaku(obj);
			}

			// Token: 0x0600B597 RID: 46487 RVA: 0x0032467C File Offset: 0x0032287C
			public void __clearDele_EventOnShowOneDanmaku(DanmakuEntry obj)
			{
				this.m_owner.__clearDele_EventOnShowOneDanmaku(obj);
			}

			// Token: 0x0600B598 RID: 46488 RVA: 0x0032468C File Offset: 0x0032288C
			public void __callDele_EventOnRegretActive()
			{
				this.m_owner.__callDele_EventOnRegretActive();
			}

			// Token: 0x0600B599 RID: 46489 RVA: 0x0032469C File Offset: 0x0032289C
			public void __clearDele_EventOnRegretActive()
			{
				this.m_owner.__clearDele_EventOnRegretActive();
			}

			// Token: 0x0600B59A RID: 46490 RVA: 0x003246AC File Offset: 0x003228AC
			public void __callDele_EventOnRegretConfirm()
			{
				this.m_owner.__callDele_EventOnRegretConfirm();
			}

			// Token: 0x0600B59B RID: 46491 RVA: 0x003246BC File Offset: 0x003228BC
			public void __clearDele_EventOnRegretConfirm()
			{
				this.m_owner.__clearDele_EventOnRegretConfirm();
			}

			// Token: 0x0600B59C RID: 46492 RVA: 0x003246CC File Offset: 0x003228CC
			public void __callDele_EventOnRegretCancel()
			{
				this.m_owner.__callDele_EventOnRegretCancel();
			}

			// Token: 0x0600B59D RID: 46493 RVA: 0x003246DC File Offset: 0x003228DC
			public void __clearDele_EventOnRegretCancel()
			{
				this.m_owner.__clearDele_EventOnRegretCancel();
			}

			// Token: 0x0600B59E RID: 46494 RVA: 0x003246EC File Offset: 0x003228EC
			public void __callDele_EventOnRegretBackward()
			{
				this.m_owner.__callDele_EventOnRegretBackward();
			}

			// Token: 0x0600B59F RID: 46495 RVA: 0x003246FC File Offset: 0x003228FC
			public void __clearDele_EventOnRegretBackward()
			{
				this.m_owner.__clearDele_EventOnRegretBackward();
			}

			// Token: 0x0600B5A0 RID: 46496 RVA: 0x0032470C File Offset: 0x0032290C
			public void __callDele_EventOnRegretForward()
			{
				this.m_owner.__callDele_EventOnRegretForward();
			}

			// Token: 0x0600B5A1 RID: 46497 RVA: 0x0032471C File Offset: 0x0032291C
			public void __clearDele_EventOnRegretForward()
			{
				this.m_owner.__clearDele_EventOnRegretForward();
			}

			// Token: 0x17002485 RID: 9349
			// (get) Token: 0x0600B5A2 RID: 46498 RVA: 0x0032472C File Offset: 0x0032292C
			// (set) Token: 0x0600B5A3 RID: 46499 RVA: 0x0032473C File Offset: 0x0032293C
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

			// Token: 0x17002486 RID: 9350
			// (get) Token: 0x0600B5A4 RID: 46500 RVA: 0x0032474C File Offset: 0x0032294C
			// (set) Token: 0x0600B5A5 RID: 46501 RVA: 0x0032475C File Offset: 0x0032295C
			public Button m_autoOffButton
			{
				get
				{
					return this.m_owner.m_autoOffButton;
				}
				set
				{
					this.m_owner.m_autoOffButton = value;
				}
			}

			// Token: 0x17002487 RID: 9351
			// (get) Token: 0x0600B5A6 RID: 46502 RVA: 0x0032476C File Offset: 0x0032296C
			// (set) Token: 0x0600B5A7 RID: 46503 RVA: 0x0032477C File Offset: 0x0032297C
			public Button m_arenaAutoButton
			{
				get
				{
					return this.m_owner.m_arenaAutoButton;
				}
				set
				{
					this.m_owner.m_arenaAutoButton = value;
				}
			}

			// Token: 0x17002488 RID: 9352
			// (get) Token: 0x0600B5A8 RID: 46504 RVA: 0x0032478C File Offset: 0x0032298C
			// (set) Token: 0x0600B5A9 RID: 46505 RVA: 0x0032479C File Offset: 0x0032299C
			public GameObject m_topLeftGameObject
			{
				get
				{
					return this.m_owner.m_topLeftGameObject;
				}
				set
				{
					this.m_owner.m_topLeftGameObject = value;
				}
			}

			// Token: 0x17002489 RID: 9353
			// (get) Token: 0x0600B5AA RID: 46506 RVA: 0x003247AC File Offset: 0x003229AC
			// (set) Token: 0x0600B5AB RID: 46507 RVA: 0x003247BC File Offset: 0x003229BC
			public Button m_actorSimpleInfoButton
			{
				get
				{
					return this.m_owner.m_actorSimpleInfoButton;
				}
				set
				{
					this.m_owner.m_actorSimpleInfoButton = value;
				}
			}

			// Token: 0x1700248A RID: 9354
			// (get) Token: 0x0600B5AC RID: 46508 RVA: 0x003247CC File Offset: 0x003229CC
			// (set) Token: 0x0600B5AD RID: 46509 RVA: 0x003247DC File Offset: 0x003229DC
			public CommonUIStateController m_actorSimpleInfoUIStateController
			{
				get
				{
					return this.m_owner.m_actorSimpleInfoUIStateController;
				}
				set
				{
					this.m_owner.m_actorSimpleInfoUIStateController = value;
				}
			}

			// Token: 0x1700248B RID: 9355
			// (get) Token: 0x0600B5AE RID: 46510 RVA: 0x003247EC File Offset: 0x003229EC
			// (set) Token: 0x0600B5AF RID: 46511 RVA: 0x003247FC File Offset: 0x003229FC
			public Image m_actorSimpleInfoHeadImage
			{
				get
				{
					return this.m_owner.m_actorSimpleInfoHeadImage;
				}
				set
				{
					this.m_owner.m_actorSimpleInfoHeadImage = value;
				}
			}

			// Token: 0x1700248C RID: 9356
			// (get) Token: 0x0600B5B0 RID: 46512 RVA: 0x0032480C File Offset: 0x00322A0C
			// (set) Token: 0x0600B5B1 RID: 46513 RVA: 0x0032481C File Offset: 0x00322A1C
			public Text m_actorSimpleInfoNameText
			{
				get
				{
					return this.m_owner.m_actorSimpleInfoNameText;
				}
				set
				{
					this.m_owner.m_actorSimpleInfoNameText = value;
				}
			}

			// Token: 0x1700248D RID: 9357
			// (get) Token: 0x0600B5B2 RID: 46514 RVA: 0x0032482C File Offset: 0x00322A2C
			// (set) Token: 0x0600B5B3 RID: 46515 RVA: 0x0032483C File Offset: 0x00322A3C
			public Text m_actorSimpleInfoLevelText
			{
				get
				{
					return this.m_owner.m_actorSimpleInfoLevelText;
				}
				set
				{
					this.m_owner.m_actorSimpleInfoLevelText = value;
				}
			}

			// Token: 0x1700248E RID: 9358
			// (get) Token: 0x0600B5B4 RID: 46516 RVA: 0x0032484C File Offset: 0x00322A4C
			// (set) Token: 0x0600B5B5 RID: 46517 RVA: 0x0032485C File Offset: 0x00322A5C
			public Image m_actorSimpleInfoArmyImage
			{
				get
				{
					return this.m_owner.m_actorSimpleInfoArmyImage;
				}
				set
				{
					this.m_owner.m_actorSimpleInfoArmyImage = value;
				}
			}

			// Token: 0x1700248F RID: 9359
			// (get) Token: 0x0600B5B6 RID: 46518 RVA: 0x0032486C File Offset: 0x00322A6C
			// (set) Token: 0x0600B5B7 RID: 46519 RVA: 0x0032487C File Offset: 0x00322A7C
			public Image m_actorSimpleInfoHeroHPImage
			{
				get
				{
					return this.m_owner.m_actorSimpleInfoHeroHPImage;
				}
				set
				{
					this.m_owner.m_actorSimpleInfoHeroHPImage = value;
				}
			}

			// Token: 0x17002490 RID: 9360
			// (get) Token: 0x0600B5B8 RID: 46520 RVA: 0x0032488C File Offset: 0x00322A8C
			// (set) Token: 0x0600B5B9 RID: 46521 RVA: 0x0032489C File Offset: 0x00322A9C
			public Text m_actorSimpleInfoHeroHPText
			{
				get
				{
					return this.m_owner.m_actorSimpleInfoHeroHPText;
				}
				set
				{
					this.m_owner.m_actorSimpleInfoHeroHPText = value;
				}
			}

			// Token: 0x17002491 RID: 9361
			// (get) Token: 0x0600B5BA RID: 46522 RVA: 0x003248AC File Offset: 0x00322AAC
			// (set) Token: 0x0600B5BB RID: 46523 RVA: 0x003248BC File Offset: 0x00322ABC
			public Image m_actorSimpleInfoSoldierHPImage
			{
				get
				{
					return this.m_owner.m_actorSimpleInfoSoldierHPImage;
				}
				set
				{
					this.m_owner.m_actorSimpleInfoSoldierHPImage = value;
				}
			}

			// Token: 0x17002492 RID: 9362
			// (get) Token: 0x0600B5BC RID: 46524 RVA: 0x003248CC File Offset: 0x00322ACC
			// (set) Token: 0x0600B5BD RID: 46525 RVA: 0x003248DC File Offset: 0x00322ADC
			public Text m_actorSimpleInfoSoldierHPText
			{
				get
				{
					return this.m_owner.m_actorSimpleInfoSoldierHPText;
				}
				set
				{
					this.m_owner.m_actorSimpleInfoSoldierHPText = value;
				}
			}

			// Token: 0x17002493 RID: 9363
			// (get) Token: 0x0600B5BE RID: 46526 RVA: 0x003248EC File Offset: 0x00322AEC
			// (set) Token: 0x0600B5BF RID: 46527 RVA: 0x003248FC File Offset: 0x00322AFC
			public GameObject m_topLeftGameObject2
			{
				get
				{
					return this.m_owner.m_topLeftGameObject2;
				}
				set
				{
					this.m_owner.m_topLeftGameObject2 = value;
				}
			}

			// Token: 0x17002494 RID: 9364
			// (get) Token: 0x0600B5C0 RID: 46528 RVA: 0x0032490C File Offset: 0x00322B0C
			// (set) Token: 0x0600B5C1 RID: 46529 RVA: 0x0032491C File Offset: 0x00322B1C
			public Button m_regratButton
			{
				get
				{
					return this.m_owner.m_regratButton;
				}
				set
				{
					this.m_owner.m_regratButton = value;
				}
			}

			// Token: 0x17002495 RID: 9365
			// (get) Token: 0x0600B5C2 RID: 46530 RVA: 0x0032492C File Offset: 0x00322B2C
			// (set) Token: 0x0600B5C3 RID: 46531 RVA: 0x0032493C File Offset: 0x00322B3C
			public CommonUIStateController m_regretButtonUIStateController
			{
				get
				{
					return this.m_owner.m_regretButtonUIStateController;
				}
				set
				{
					this.m_owner.m_regretButtonUIStateController = value;
				}
			}

			// Token: 0x17002496 RID: 9366
			// (get) Token: 0x0600B5C4 RID: 46532 RVA: 0x0032494C File Offset: 0x00322B4C
			// (set) Token: 0x0600B5C5 RID: 46533 RVA: 0x0032495C File Offset: 0x00322B5C
			public Text m_regretCountText
			{
				get
				{
					return this.m_owner.m_regretCountText;
				}
				set
				{
					this.m_owner.m_regretCountText = value;
				}
			}

			// Token: 0x17002497 RID: 9367
			// (get) Token: 0x0600B5C6 RID: 46534 RVA: 0x0032496C File Offset: 0x00322B6C
			// (set) Token: 0x0600B5C7 RID: 46535 RVA: 0x0032497C File Offset: 0x00322B7C
			public GameObject m_topRightGameObject2
			{
				get
				{
					return this.m_owner.m_topRightGameObject2;
				}
				set
				{
					this.m_owner.m_topRightGameObject2 = value;
				}
			}

			// Token: 0x17002498 RID: 9368
			// (get) Token: 0x0600B5C8 RID: 46536 RVA: 0x0032498C File Offset: 0x00322B8C
			// (set) Token: 0x0600B5C9 RID: 46537 RVA: 0x0032499C File Offset: 0x00322B9C
			public Button m_pauseButton
			{
				get
				{
					return this.m_owner.m_pauseButton;
				}
				set
				{
					this.m_owner.m_pauseButton = value;
				}
			}

			// Token: 0x17002499 RID: 9369
			// (get) Token: 0x0600B5CA RID: 46538 RVA: 0x003249AC File Offset: 0x00322BAC
			// (set) Token: 0x0600B5CB RID: 46539 RVA: 0x003249BC File Offset: 0x00322BBC
			public Button m_autoButton
			{
				get
				{
					return this.m_owner.m_autoButton;
				}
				set
				{
					this.m_owner.m_autoButton = value;
				}
			}

			// Token: 0x1700249A RID: 9370
			// (get) Token: 0x0600B5CC RID: 46540 RVA: 0x003249CC File Offset: 0x00322BCC
			// (set) Token: 0x0600B5CD RID: 46541 RVA: 0x003249DC File Offset: 0x00322BDC
			public CommonUIStateController m_autoButtonUIStateController
			{
				get
				{
					return this.m_owner.m_autoButtonUIStateController;
				}
				set
				{
					this.m_owner.m_autoButtonUIStateController = value;
				}
			}

			// Token: 0x1700249B RID: 9371
			// (get) Token: 0x0600B5CE RID: 46542 RVA: 0x003249EC File Offset: 0x00322BEC
			// (set) Token: 0x0600B5CF RID: 46543 RVA: 0x003249FC File Offset: 0x00322BFC
			public Button m_fastButton
			{
				get
				{
					return this.m_owner.m_fastButton;
				}
				set
				{
					this.m_owner.m_fastButton = value;
				}
			}

			// Token: 0x1700249C RID: 9372
			// (get) Token: 0x0600B5D0 RID: 46544 RVA: 0x00324A0C File Offset: 0x00322C0C
			// (set) Token: 0x0600B5D1 RID: 46545 RVA: 0x00324A1C File Offset: 0x00322C1C
			public CommonUIStateController m_fastButtonUIStateController
			{
				get
				{
					return this.m_owner.m_fastButtonUIStateController;
				}
				set
				{
					this.m_owner.m_fastButtonUIStateController = value;
				}
			}

			// Token: 0x1700249D RID: 9373
			// (get) Token: 0x0600B5D2 RID: 46546 RVA: 0x00324A2C File Offset: 0x00322C2C
			// (set) Token: 0x0600B5D3 RID: 46547 RVA: 0x00324A3C File Offset: 0x00322C3C
			public Button m_skipCombatButton
			{
				get
				{
					return this.m_owner.m_skipCombatButton;
				}
				set
				{
					this.m_owner.m_skipCombatButton = value;
				}
			}

			// Token: 0x1700249E RID: 9374
			// (get) Token: 0x0600B5D4 RID: 46548 RVA: 0x00324A4C File Offset: 0x00322C4C
			// (set) Token: 0x0600B5D5 RID: 46549 RVA: 0x00324A5C File Offset: 0x00322C5C
			public CommonUIStateController m_skipCombatButtonUIStateController
			{
				get
				{
					return this.m_owner.m_skipCombatButtonUIStateController;
				}
				set
				{
					this.m_owner.m_skipCombatButtonUIStateController = value;
				}
			}

			// Token: 0x1700249F RID: 9375
			// (get) Token: 0x0600B5D6 RID: 46550 RVA: 0x00324A6C File Offset: 0x00322C6C
			// (set) Token: 0x0600B5D7 RID: 46551 RVA: 0x00324A7C File Offset: 0x00322C7C
			public GameObject m_terrainInfoGameObject
			{
				get
				{
					return this.m_owner.m_terrainInfoGameObject;
				}
				set
				{
					this.m_owner.m_terrainInfoGameObject = value;
				}
			}

			// Token: 0x170024A0 RID: 9376
			// (get) Token: 0x0600B5D8 RID: 46552 RVA: 0x00324A8C File Offset: 0x00322C8C
			// (set) Token: 0x0600B5D9 RID: 46553 RVA: 0x00324A9C File Offset: 0x00322C9C
			public Button m_terrainInfoButton
			{
				get
				{
					return this.m_owner.m_terrainInfoButton;
				}
				set
				{
					this.m_owner.m_terrainInfoButton = value;
				}
			}

			// Token: 0x170024A1 RID: 9377
			// (get) Token: 0x0600B5DA RID: 46554 RVA: 0x00324AAC File Offset: 0x00322CAC
			// (set) Token: 0x0600B5DB RID: 46555 RVA: 0x00324ABC File Offset: 0x00322CBC
			public Text m_terrainInfoText
			{
				get
				{
					return this.m_owner.m_terrainInfoText;
				}
				set
				{
					this.m_owner.m_terrainInfoText = value;
				}
			}

			// Token: 0x170024A2 RID: 9378
			// (get) Token: 0x0600B5DC RID: 46556 RVA: 0x00324ACC File Offset: 0x00322CCC
			// (set) Token: 0x0600B5DD RID: 46557 RVA: 0x00324ADC File Offset: 0x00322CDC
			public Image m_terrainInfoImage
			{
				get
				{
					return this.m_owner.m_terrainInfoImage;
				}
				set
				{
					this.m_owner.m_terrainInfoImage = value;
				}
			}

			// Token: 0x170024A3 RID: 9379
			// (get) Token: 0x0600B5DE RID: 46558 RVA: 0x00324AEC File Offset: 0x00322CEC
			// (set) Token: 0x0600B5DF RID: 46559 RVA: 0x00324AFC File Offset: 0x00322CFC
			public Text m_terrainInfoDefText
			{
				get
				{
					return this.m_owner.m_terrainInfoDefText;
				}
				set
				{
					this.m_owner.m_terrainInfoDefText = value;
				}
			}

			// Token: 0x170024A4 RID: 9380
			// (get) Token: 0x0600B5E0 RID: 46560 RVA: 0x00324B0C File Offset: 0x00322D0C
			// (set) Token: 0x0600B5E1 RID: 46561 RVA: 0x00324B1C File Offset: 0x00322D1C
			public GameObject m_bottomGameObject
			{
				get
				{
					return this.m_owner.m_bottomGameObject;
				}
				set
				{
					this.m_owner.m_bottomGameObject = value;
				}
			}

			// Token: 0x170024A5 RID: 9381
			// (get) Token: 0x0600B5E2 RID: 46562 RVA: 0x00324B2C File Offset: 0x00322D2C
			// (set) Token: 0x0600B5E3 RID: 46563 RVA: 0x00324B3C File Offset: 0x00322D3C
			public Button m_dangerOnButton
			{
				get
				{
					return this.m_owner.m_dangerOnButton;
				}
				set
				{
					this.m_owner.m_dangerOnButton = value;
				}
			}

			// Token: 0x170024A6 RID: 9382
			// (get) Token: 0x0600B5E4 RID: 46564 RVA: 0x00324B4C File Offset: 0x00322D4C
			// (set) Token: 0x0600B5E5 RID: 46565 RVA: 0x00324B5C File Offset: 0x00322D5C
			public Button m_dangerOffButton
			{
				get
				{
					return this.m_owner.m_dangerOffButton;
				}
				set
				{
					this.m_owner.m_dangerOffButton = value;
				}
			}

			// Token: 0x170024A7 RID: 9383
			// (get) Token: 0x0600B5E6 RID: 46566 RVA: 0x00324B6C File Offset: 0x00322D6C
			// (set) Token: 0x0600B5E7 RID: 46567 RVA: 0x00324B7C File Offset: 0x00322D7C
			public Button m_endAllActionButton
			{
				get
				{
					return this.m_owner.m_endAllActionButton;
				}
				set
				{
					this.m_owner.m_endAllActionButton = value;
				}
			}

			// Token: 0x170024A8 RID: 9384
			// (get) Token: 0x0600B5E8 RID: 46568 RVA: 0x00324B8C File Offset: 0x00322D8C
			// (set) Token: 0x0600B5E9 RID: 46569 RVA: 0x00324B9C File Offset: 0x00322D9C
			public Button m_useSkillButton
			{
				get
				{
					return this.m_owner.m_useSkillButton;
				}
				set
				{
					this.m_owner.m_useSkillButton = value;
				}
			}

			// Token: 0x170024A9 RID: 9385
			// (get) Token: 0x0600B5EA RID: 46570 RVA: 0x00324BAC File Offset: 0x00322DAC
			// (set) Token: 0x0600B5EB RID: 46571 RVA: 0x00324BBC File Offset: 0x00322DBC
			public Button m_cancelSkillButton
			{
				get
				{
					return this.m_owner.m_cancelSkillButton;
				}
				set
				{
					this.m_owner.m_cancelSkillButton = value;
				}
			}

			// Token: 0x170024AA RID: 9386
			// (get) Token: 0x0600B5EC RID: 46572 RVA: 0x00324BCC File Offset: 0x00322DCC
			// (set) Token: 0x0600B5ED RID: 46573 RVA: 0x00324BDC File Offset: 0x00322DDC
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

			// Token: 0x170024AB RID: 9387
			// (get) Token: 0x0600B5EE RID: 46574 RVA: 0x00324BEC File Offset: 0x00322DEC
			// (set) Token: 0x0600B5EF RID: 46575 RVA: 0x00324BFC File Offset: 0x00322DFC
			public GameObject m_chatRedPoint
			{
				get
				{
					return this.m_owner.m_chatRedPoint;
				}
				set
				{
					this.m_owner.m_chatRedPoint = value;
				}
			}

			// Token: 0x170024AC RID: 9388
			// (get) Token: 0x0600B5F0 RID: 46576 RVA: 0x00324C0C File Offset: 0x00322E0C
			// (set) Token: 0x0600B5F1 RID: 46577 RVA: 0x00324C1C File Offset: 0x00322E1C
			public CommonUIStateController m_skillsUIStateController
			{
				get
				{
					return this.m_owner.m_skillsUIStateController;
				}
				set
				{
					this.m_owner.m_skillsUIStateController = value;
				}
			}

			// Token: 0x170024AD RID: 9389
			// (get) Token: 0x0600B5F2 RID: 46578 RVA: 0x00324C2C File Offset: 0x00322E2C
			// (set) Token: 0x0600B5F3 RID: 46579 RVA: 0x00324C3C File Offset: 0x00322E3C
			public Button m_endActionButton
			{
				get
				{
					return this.m_owner.m_endActionButton;
				}
				set
				{
					this.m_owner.m_endActionButton = value;
				}
			}

			// Token: 0x170024AE RID: 9390
			// (get) Token: 0x0600B5F4 RID: 46580 RVA: 0x00324C4C File Offset: 0x00322E4C
			// (set) Token: 0x0600B5F5 RID: 46581 RVA: 0x00324C5C File Offset: 0x00322E5C
			public GameObject m_skillListGameObject
			{
				get
				{
					return this.m_owner.m_skillListGameObject;
				}
				set
				{
					this.m_owner.m_skillListGameObject = value;
				}
			}

			// Token: 0x170024AF RID: 9391
			// (get) Token: 0x0600B5F6 RID: 46582 RVA: 0x00324C6C File Offset: 0x00322E6C
			// (set) Token: 0x0600B5F7 RID: 46583 RVA: 0x00324C7C File Offset: 0x00322E7C
			public CommonUIStateController m_skillListUIStateController
			{
				get
				{
					return this.m_owner.m_skillListUIStateController;
				}
				set
				{
					this.m_owner.m_skillListUIStateController = value;
				}
			}

			// Token: 0x170024B0 RID: 9392
			// (get) Token: 0x0600B5F8 RID: 46584 RVA: 0x00324C8C File Offset: 0x00322E8C
			// (set) Token: 0x0600B5F9 RID: 46585 RVA: 0x00324C9C File Offset: 0x00322E9C
			public GameObject m_skillDescGameObject
			{
				get
				{
					return this.m_owner.m_skillDescGameObject;
				}
				set
				{
					this.m_owner.m_skillDescGameObject = value;
				}
			}

			// Token: 0x170024B1 RID: 9393
			// (get) Token: 0x0600B5FA RID: 46586 RVA: 0x00324CAC File Offset: 0x00322EAC
			// (set) Token: 0x0600B5FB RID: 46587 RVA: 0x00324CBC File Offset: 0x00322EBC
			public CommonUIStateController m_skillHintUIStateController
			{
				get
				{
					return this.m_owner.m_skillHintUIStateController;
				}
				set
				{
					this.m_owner.m_skillHintUIStateController = value;
				}
			}

			// Token: 0x170024B2 RID: 9394
			// (get) Token: 0x0600B5FC RID: 46588 RVA: 0x00324CCC File Offset: 0x00322ECC
			// (set) Token: 0x0600B5FD RID: 46589 RVA: 0x00324CDC File Offset: 0x00322EDC
			public Text m_skillHintText
			{
				get
				{
					return this.m_owner.m_skillHintText;
				}
				set
				{
					this.m_owner.m_skillHintText = value;
				}
			}

			// Token: 0x170024B3 RID: 9395
			// (get) Token: 0x0600B5FE RID: 46590 RVA: 0x00324CEC File Offset: 0x00322EEC
			// (set) Token: 0x0600B5FF RID: 46591 RVA: 0x00324CFC File Offset: 0x00322EFC
			public CommonUIStateController m_statusUIStateController
			{
				get
				{
					return this.m_owner.m_statusUIStateController;
				}
				set
				{
					this.m_owner.m_statusUIStateController = value;
				}
			}

			// Token: 0x170024B4 RID: 9396
			// (get) Token: 0x0600B600 RID: 46592 RVA: 0x00324D0C File Offset: 0x00322F0C
			// (set) Token: 0x0600B601 RID: 46593 RVA: 0x00324D1C File Offset: 0x00322F1C
			public Text m_statusTurnText
			{
				get
				{
					return this.m_owner.m_statusTurnText;
				}
				set
				{
					this.m_owner.m_statusTurnText = value;
				}
			}

			// Token: 0x170024B5 RID: 9397
			// (get) Token: 0x0600B602 RID: 46594 RVA: 0x00324D2C File Offset: 0x00322F2C
			// (set) Token: 0x0600B603 RID: 46595 RVA: 0x00324D3C File Offset: 0x00322F3C
			public GameObject m_statusWinDescGameObject1
			{
				get
				{
					return this.m_owner.m_statusWinDescGameObject1;
				}
				set
				{
					this.m_owner.m_statusWinDescGameObject1 = value;
				}
			}

			// Token: 0x170024B6 RID: 9398
			// (get) Token: 0x0600B604 RID: 46596 RVA: 0x00324D4C File Offset: 0x00322F4C
			// (set) Token: 0x0600B605 RID: 46597 RVA: 0x00324D5C File Offset: 0x00322F5C
			public Text m_statusWinDescText1
			{
				get
				{
					return this.m_owner.m_statusWinDescText1;
				}
				set
				{
					this.m_owner.m_statusWinDescText1 = value;
				}
			}

			// Token: 0x170024B7 RID: 9399
			// (get) Token: 0x0600B606 RID: 46598 RVA: 0x00324D6C File Offset: 0x00322F6C
			// (set) Token: 0x0600B607 RID: 46599 RVA: 0x00324D7C File Offset: 0x00322F7C
			public GameObject m_statusWinDescGameObject2
			{
				get
				{
					return this.m_owner.m_statusWinDescGameObject2;
				}
				set
				{
					this.m_owner.m_statusWinDescGameObject2 = value;
				}
			}

			// Token: 0x170024B8 RID: 9400
			// (get) Token: 0x0600B608 RID: 46600 RVA: 0x00324D8C File Offset: 0x00322F8C
			// (set) Token: 0x0600B609 RID: 46601 RVA: 0x00324D9C File Offset: 0x00322F9C
			public Text m_statusWinDescText2
			{
				get
				{
					return this.m_owner.m_statusWinDescText2;
				}
				set
				{
					this.m_owner.m_statusWinDescText2 = value;
				}
			}

			// Token: 0x170024B9 RID: 9401
			// (get) Token: 0x0600B60A RID: 46602 RVA: 0x00324DAC File Offset: 0x00322FAC
			// (set) Token: 0x0600B60B RID: 46603 RVA: 0x00324DBC File Offset: 0x00322FBC
			public CommonUIStateController m_danmakuStateCtrl
			{
				get
				{
					return this.m_owner.m_danmakuStateCtrl;
				}
				set
				{
					this.m_owner.m_danmakuStateCtrl = value;
				}
			}

			// Token: 0x170024BA RID: 9402
			// (get) Token: 0x0600B60C RID: 46604 RVA: 0x00324DCC File Offset: 0x00322FCC
			// (set) Token: 0x0600B60D RID: 46605 RVA: 0x00324DDC File Offset: 0x00322FDC
			public Button m_danmakuInputBackButton
			{
				get
				{
					return this.m_owner.m_danmakuInputBackButton;
				}
				set
				{
					this.m_owner.m_danmakuInputBackButton = value;
				}
			}

			// Token: 0x170024BB RID: 9403
			// (get) Token: 0x0600B60E RID: 46606 RVA: 0x00324DEC File Offset: 0x00322FEC
			// (set) Token: 0x0600B60F RID: 46607 RVA: 0x00324DFC File Offset: 0x00322FFC
			public Toggle m_danmakuToggle
			{
				get
				{
					return this.m_owner.m_danmakuToggle;
				}
				set
				{
					this.m_owner.m_danmakuToggle = value;
				}
			}

			// Token: 0x170024BC RID: 9404
			// (get) Token: 0x0600B610 RID: 46608 RVA: 0x00324E0C File Offset: 0x0032300C
			// (set) Token: 0x0600B611 RID: 46609 RVA: 0x00324E1C File Offset: 0x0032301C
			public Button m_danmakuInputWordButton
			{
				get
				{
					return this.m_owner.m_danmakuInputWordButton;
				}
				set
				{
					this.m_owner.m_danmakuInputWordButton = value;
				}
			}

			// Token: 0x170024BD RID: 9405
			// (get) Token: 0x0600B612 RID: 46610 RVA: 0x00324E2C File Offset: 0x0032302C
			// (set) Token: 0x0600B613 RID: 46611 RVA: 0x00324E3C File Offset: 0x0032303C
			public InputField m_danmakuInputField
			{
				get
				{
					return this.m_owner.m_danmakuInputField;
				}
				set
				{
					this.m_owner.m_danmakuInputField = value;
				}
			}

			// Token: 0x170024BE RID: 9406
			// (get) Token: 0x0600B614 RID: 46612 RVA: 0x00324E4C File Offset: 0x0032304C
			// (set) Token: 0x0600B615 RID: 46613 RVA: 0x00324E5C File Offset: 0x0032305C
			public Button m_danmakuSendButton
			{
				get
				{
					return this.m_owner.m_danmakuSendButton;
				}
				set
				{
					this.m_owner.m_danmakuSendButton = value;
				}
			}

			// Token: 0x170024BF RID: 9407
			// (get) Token: 0x0600B616 RID: 46614 RVA: 0x00324E6C File Offset: 0x0032306C
			// (set) Token: 0x0600B617 RID: 46615 RVA: 0x00324E7C File Offset: 0x0032307C
			public CommonUIStateController m_regretUIStateController
			{
				get
				{
					return this.m_owner.m_regretUIStateController;
				}
				set
				{
					this.m_owner.m_regretUIStateController = value;
				}
			}

			// Token: 0x170024C0 RID: 9408
			// (get) Token: 0x0600B618 RID: 46616 RVA: 0x00324E8C File Offset: 0x0032308C
			// (set) Token: 0x0600B619 RID: 46617 RVA: 0x00324E9C File Offset: 0x0032309C
			public GameObject m_regretPanelGameObject
			{
				get
				{
					return this.m_owner.m_regretPanelGameObject;
				}
				set
				{
					this.m_owner.m_regretPanelGameObject = value;
				}
			}

			// Token: 0x170024C1 RID: 9409
			// (get) Token: 0x0600B61A RID: 46618 RVA: 0x00324EAC File Offset: 0x003230AC
			// (set) Token: 0x0600B61B RID: 46619 RVA: 0x00324EBC File Offset: 0x003230BC
			public Button m_regratConfirmButton
			{
				get
				{
					return this.m_owner.m_regratConfirmButton;
				}
				set
				{
					this.m_owner.m_regratConfirmButton = value;
				}
			}

			// Token: 0x170024C2 RID: 9410
			// (get) Token: 0x0600B61C RID: 46620 RVA: 0x00324ECC File Offset: 0x003230CC
			// (set) Token: 0x0600B61D RID: 46621 RVA: 0x00324EDC File Offset: 0x003230DC
			public CommonUIStateController m_regretConfirmUIStateController
			{
				get
				{
					return this.m_owner.m_regretConfirmUIStateController;
				}
				set
				{
					this.m_owner.m_regretConfirmUIStateController = value;
				}
			}

			// Token: 0x170024C3 RID: 9411
			// (get) Token: 0x0600B61E RID: 46622 RVA: 0x00324EEC File Offset: 0x003230EC
			// (set) Token: 0x0600B61F RID: 46623 RVA: 0x00324EFC File Offset: 0x003230FC
			public Button m_regretCancelButton
			{
				get
				{
					return this.m_owner.m_regretCancelButton;
				}
				set
				{
					this.m_owner.m_regretCancelButton = value;
				}
			}

			// Token: 0x170024C4 RID: 9412
			// (get) Token: 0x0600B620 RID: 46624 RVA: 0x00324F0C File Offset: 0x0032310C
			// (set) Token: 0x0600B621 RID: 46625 RVA: 0x00324F1C File Offset: 0x0032311C
			public Button m_regretBackwardButton
			{
				get
				{
					return this.m_owner.m_regretBackwardButton;
				}
				set
				{
					this.m_owner.m_regretBackwardButton = value;
				}
			}

			// Token: 0x170024C5 RID: 9413
			// (get) Token: 0x0600B622 RID: 46626 RVA: 0x00324F2C File Offset: 0x0032312C
			// (set) Token: 0x0600B623 RID: 46627 RVA: 0x00324F3C File Offset: 0x0032313C
			public CommonUIStateController m_regretBackwardUIStateController
			{
				get
				{
					return this.m_owner.m_regretBackwardUIStateController;
				}
				set
				{
					this.m_owner.m_regretBackwardUIStateController = value;
				}
			}

			// Token: 0x170024C6 RID: 9414
			// (get) Token: 0x0600B624 RID: 46628 RVA: 0x00324F4C File Offset: 0x0032314C
			// (set) Token: 0x0600B625 RID: 46629 RVA: 0x00324F5C File Offset: 0x0032315C
			public Button m_regretForwardButton
			{
				get
				{
					return this.m_owner.m_regretForwardButton;
				}
				set
				{
					this.m_owner.m_regretForwardButton = value;
				}
			}

			// Token: 0x170024C7 RID: 9415
			// (get) Token: 0x0600B626 RID: 46630 RVA: 0x00324F6C File Offset: 0x0032316C
			// (set) Token: 0x0600B627 RID: 46631 RVA: 0x00324F7C File Offset: 0x0032317C
			public CommonUIStateController m_regretForwardUIStateController
			{
				get
				{
					return this.m_owner.m_regretForwardUIStateController;
				}
				set
				{
					this.m_owner.m_regretForwardUIStateController = value;
				}
			}

			// Token: 0x170024C8 RID: 9416
			// (get) Token: 0x0600B628 RID: 46632 RVA: 0x00324F8C File Offset: 0x0032318C
			// (set) Token: 0x0600B629 RID: 46633 RVA: 0x00324F9C File Offset: 0x0032319C
			public Text m_regretTurnText
			{
				get
				{
					return this.m_owner.m_regretTurnText;
				}
				set
				{
					this.m_owner.m_regretTurnText = value;
				}
			}

			// Token: 0x170024C9 RID: 9417
			// (get) Token: 0x0600B62A RID: 46634 RVA: 0x00324FAC File Offset: 0x003231AC
			// (set) Token: 0x0600B62B RID: 46635 RVA: 0x00324FBC File Offset: 0x003231BC
			public Text m_regretActionText
			{
				get
				{
					return this.m_owner.m_regretActionText;
				}
				set
				{
					this.m_owner.m_regretActionText = value;
				}
			}

			// Token: 0x170024CA RID: 9418
			// (get) Token: 0x0600B62C RID: 46636 RVA: 0x00324FCC File Offset: 0x003231CC
			// (set) Token: 0x0600B62D RID: 46637 RVA: 0x00324FDC File Offset: 0x003231DC
			public CommonUIStateController m_regretTurnUIStateController
			{
				get
				{
					return this.m_owner.m_regretTurnUIStateController;
				}
				set
				{
					this.m_owner.m_regretTurnUIStateController = value;
				}
			}

			// Token: 0x170024CB RID: 9419
			// (get) Token: 0x0600B62E RID: 46638 RVA: 0x00324FEC File Offset: 0x003231EC
			// (set) Token: 0x0600B62F RID: 46639 RVA: 0x00324FFC File Offset: 0x003231FC
			public Text m_regretMyCountText
			{
				get
				{
					return this.m_owner.m_regretMyCountText;
				}
				set
				{
					this.m_owner.m_regretMyCountText = value;
				}
			}

			// Token: 0x170024CC RID: 9420
			// (get) Token: 0x0600B630 RID: 46640 RVA: 0x0032500C File Offset: 0x0032320C
			// (set) Token: 0x0600B631 RID: 46641 RVA: 0x0032501C File Offset: 0x0032321C
			public Text m_regretEnemyCountText
			{
				get
				{
					return this.m_owner.m_regretEnemyCountText;
				}
				set
				{
					this.m_owner.m_regretEnemyCountText = value;
				}
			}

			// Token: 0x170024CD RID: 9421
			// (get) Token: 0x0600B632 RID: 46642 RVA: 0x0032502C File Offset: 0x0032322C
			// (set) Token: 0x0600B633 RID: 46643 RVA: 0x0032503C File Offset: 0x0032323C
			public CommonUIStateController m_regretEffectUIStateController
			{
				get
				{
					return this.m_owner.m_regretEffectUIStateController;
				}
				set
				{
					this.m_owner.m_regretEffectUIStateController = value;
				}
			}

			// Token: 0x170024CE RID: 9422
			// (get) Token: 0x0600B634 RID: 46644 RVA: 0x0032504C File Offset: 0x0032324C
			// (set) Token: 0x0600B635 RID: 46645 RVA: 0x0032505C File Offset: 0x0032325C
			public CommonUIStateController m_regretFxUIStateController
			{
				get
				{
					return this.m_owner.m_regretFxUIStateController;
				}
				set
				{
					this.m_owner.m_regretFxUIStateController = value;
				}
			}

			// Token: 0x170024CF RID: 9423
			// (get) Token: 0x0600B636 RID: 46646 RVA: 0x0032506C File Offset: 0x0032326C
			// (set) Token: 0x0600B637 RID: 46647 RVA: 0x0032507C File Offset: 0x0032327C
			public CommonUIStateController m_cutsceneSkillUIStateController
			{
				get
				{
					return this.m_owner.m_cutsceneSkillUIStateController;
				}
				set
				{
					this.m_owner.m_cutsceneSkillUIStateController = value;
				}
			}

			// Token: 0x170024D0 RID: 9424
			// (get) Token: 0x0600B638 RID: 46648 RVA: 0x0032508C File Offset: 0x0032328C
			// (set) Token: 0x0600B639 RID: 46649 RVA: 0x0032509C File Offset: 0x0032329C
			public Image m_cutsceneSkillIconImage
			{
				get
				{
					return this.m_owner.m_cutsceneSkillIconImage;
				}
				set
				{
					this.m_owner.m_cutsceneSkillIconImage = value;
				}
			}

			// Token: 0x170024D1 RID: 9425
			// (get) Token: 0x0600B63A RID: 46650 RVA: 0x003250AC File Offset: 0x003232AC
			// (set) Token: 0x0600B63B RID: 46651 RVA: 0x003250BC File Offset: 0x003232BC
			public Text m_cutsceneSkillNameText
			{
				get
				{
					return this.m_owner.m_cutsceneSkillNameText;
				}
				set
				{
					this.m_owner.m_cutsceneSkillNameText = value;
				}
			}

			// Token: 0x170024D2 RID: 9426
			// (get) Token: 0x0600B63C RID: 46652 RVA: 0x003250CC File Offset: 0x003232CC
			// (set) Token: 0x0600B63D RID: 46653 RVA: 0x003250DC File Offset: 0x003232DC
			public GameObject m_objectiveGameObject
			{
				get
				{
					return this.m_owner.m_objectiveGameObject;
				}
				set
				{
					this.m_owner.m_objectiveGameObject = value;
				}
			}

			// Token: 0x170024D3 RID: 9427
			// (get) Token: 0x0600B63E RID: 46654 RVA: 0x003250EC File Offset: 0x003232EC
			// (set) Token: 0x0600B63F RID: 46655 RVA: 0x003250FC File Offset: 0x003232FC
			public Text m_objectiveWinDescText
			{
				get
				{
					return this.m_owner.m_objectiveWinDescText;
				}
				set
				{
					this.m_owner.m_objectiveWinDescText = value;
				}
			}

			// Token: 0x170024D4 RID: 9428
			// (get) Token: 0x0600B640 RID: 46656 RVA: 0x0032510C File Offset: 0x0032330C
			// (set) Token: 0x0600B641 RID: 46657 RVA: 0x0032511C File Offset: 0x0032331C
			public Text m_objectiveLoseDescText
			{
				get
				{
					return this.m_owner.m_objectiveLoseDescText;
				}
				set
				{
					this.m_owner.m_objectiveLoseDescText = value;
				}
			}

			// Token: 0x170024D5 RID: 9429
			// (get) Token: 0x0600B642 RID: 46658 RVA: 0x0032512C File Offset: 0x0032332C
			// (set) Token: 0x0600B643 RID: 46659 RVA: 0x0032513C File Offset: 0x0032333C
			public GameObject m_winGameObject
			{
				get
				{
					return this.m_owner.m_winGameObject;
				}
				set
				{
					this.m_owner.m_winGameObject = value;
				}
			}

			// Token: 0x170024D6 RID: 9430
			// (get) Token: 0x0600B644 RID: 46660 RVA: 0x0032514C File Offset: 0x0032334C
			// (set) Token: 0x0600B645 RID: 46661 RVA: 0x0032515C File Offset: 0x0032335C
			public GameObject m_loseGameObject
			{
				get
				{
					return this.m_owner.m_loseGameObject;
				}
				set
				{
					this.m_owner.m_loseGameObject = value;
				}
			}

			// Token: 0x170024D7 RID: 9431
			// (get) Token: 0x0600B646 RID: 46662 RVA: 0x0032516C File Offset: 0x0032336C
			// (set) Token: 0x0600B647 RID: 46663 RVA: 0x0032517C File Offset: 0x0032337C
			public GameObject m_turnStartGameObject
			{
				get
				{
					return this.m_owner.m_turnStartGameObject;
				}
				set
				{
					this.m_owner.m_turnStartGameObject = value;
				}
			}

			// Token: 0x170024D8 RID: 9432
			// (get) Token: 0x0600B648 RID: 46664 RVA: 0x0032518C File Offset: 0x0032338C
			// (set) Token: 0x0600B649 RID: 46665 RVA: 0x0032519C File Offset: 0x0032339C
			public Text m_turnStartText
			{
				get
				{
					return this.m_owner.m_turnStartText;
				}
				set
				{
					this.m_owner.m_turnStartText = value;
				}
			}

			// Token: 0x170024D9 RID: 9433
			// (get) Token: 0x0600B64A RID: 46666 RVA: 0x003251AC File Offset: 0x003233AC
			// (set) Token: 0x0600B64B RID: 46667 RVA: 0x003251BC File Offset: 0x003233BC
			public GameObject m_playerTurnGameObject
			{
				get
				{
					return this.m_owner.m_playerTurnGameObject;
				}
				set
				{
					this.m_owner.m_playerTurnGameObject = value;
				}
			}

			// Token: 0x170024DA RID: 9434
			// (get) Token: 0x0600B64C RID: 46668 RVA: 0x003251CC File Offset: 0x003233CC
			// (set) Token: 0x0600B64D RID: 46669 RVA: 0x003251DC File Offset: 0x003233DC
			public GameObject m_enemyTurnGameObject
			{
				get
				{
					return this.m_owner.m_enemyTurnGameObject;
				}
				set
				{
					this.m_owner.m_enemyTurnGameObject = value;
				}
			}

			// Token: 0x170024DB RID: 9435
			// (get) Token: 0x0600B64E RID: 46670 RVA: 0x003251EC File Offset: 0x003233EC
			// (set) Token: 0x0600B64F RID: 46671 RVA: 0x003251FC File Offset: 0x003233FC
			public CommonUIStateController m_myActionUIStateController
			{
				get
				{
					return this.m_owner.m_myActionUIStateController;
				}
				set
				{
					this.m_owner.m_myActionUIStateController = value;
				}
			}

			// Token: 0x170024DC RID: 9436
			// (get) Token: 0x0600B650 RID: 46672 RVA: 0x0032520C File Offset: 0x0032340C
			// (set) Token: 0x0600B651 RID: 46673 RVA: 0x0032521C File Offset: 0x0032341C
			public Image m_myActionHeadImage
			{
				get
				{
					return this.m_owner.m_myActionHeadImage;
				}
				set
				{
					this.m_owner.m_myActionHeadImage = value;
				}
			}

			// Token: 0x170024DD RID: 9437
			// (get) Token: 0x0600B652 RID: 46674 RVA: 0x0032522C File Offset: 0x0032342C
			// (set) Token: 0x0600B653 RID: 46675 RVA: 0x0032523C File Offset: 0x0032343C
			public Text m_myActionNameText
			{
				get
				{
					return this.m_owner.m_myActionNameText;
				}
				set
				{
					this.m_owner.m_myActionNameText = value;
				}
			}

			// Token: 0x170024DE RID: 9438
			// (get) Token: 0x0600B654 RID: 46676 RVA: 0x0032524C File Offset: 0x0032344C
			// (set) Token: 0x0600B655 RID: 46677 RVA: 0x0032525C File Offset: 0x0032345C
			public Image m_myActionPlayerTagImage
			{
				get
				{
					return this.m_owner.m_myActionPlayerTagImage;
				}
				set
				{
					this.m_owner.m_myActionPlayerTagImage = value;
				}
			}

			// Token: 0x170024DF RID: 9439
			// (get) Token: 0x0600B656 RID: 46678 RVA: 0x0032526C File Offset: 0x0032346C
			// (set) Token: 0x0600B657 RID: 46679 RVA: 0x0032527C File Offset: 0x0032347C
			public CommonUIStateController m_teammateActionUIStateController
			{
				get
				{
					return this.m_owner.m_teammateActionUIStateController;
				}
				set
				{
					this.m_owner.m_teammateActionUIStateController = value;
				}
			}

			// Token: 0x170024E0 RID: 9440
			// (get) Token: 0x0600B658 RID: 46680 RVA: 0x0032528C File Offset: 0x0032348C
			// (set) Token: 0x0600B659 RID: 46681 RVA: 0x0032529C File Offset: 0x0032349C
			public Image m_teammateActionHeadImage
			{
				get
				{
					return this.m_owner.m_teammateActionHeadImage;
				}
				set
				{
					this.m_owner.m_teammateActionHeadImage = value;
				}
			}

			// Token: 0x170024E1 RID: 9441
			// (get) Token: 0x0600B65A RID: 46682 RVA: 0x003252AC File Offset: 0x003234AC
			// (set) Token: 0x0600B65B RID: 46683 RVA: 0x003252BC File Offset: 0x003234BC
			public Text m_teammateActionNameText
			{
				get
				{
					return this.m_owner.m_teammateActionNameText;
				}
				set
				{
					this.m_owner.m_teammateActionNameText = value;
				}
			}

			// Token: 0x170024E2 RID: 9442
			// (get) Token: 0x0600B65C RID: 46684 RVA: 0x003252CC File Offset: 0x003234CC
			// (set) Token: 0x0600B65D RID: 46685 RVA: 0x003252DC File Offset: 0x003234DC
			public Image m_teammateActionPlayerTagImage
			{
				get
				{
					return this.m_owner.m_teammateActionPlayerTagImage;
				}
				set
				{
					this.m_owner.m_teammateActionPlayerTagImage = value;
				}
			}

			// Token: 0x170024E3 RID: 9443
			// (get) Token: 0x0600B65E RID: 46686 RVA: 0x003252EC File Offset: 0x003234EC
			// (set) Token: 0x0600B65F RID: 46687 RVA: 0x003252FC File Offset: 0x003234FC
			public CommonUIStateController m_enemyActionUIStateController
			{
				get
				{
					return this.m_owner.m_enemyActionUIStateController;
				}
				set
				{
					this.m_owner.m_enemyActionUIStateController = value;
				}
			}

			// Token: 0x170024E4 RID: 9444
			// (get) Token: 0x0600B660 RID: 46688 RVA: 0x0032530C File Offset: 0x0032350C
			// (set) Token: 0x0600B661 RID: 46689 RVA: 0x0032531C File Offset: 0x0032351C
			public Image m_enemyActionHeadImage
			{
				get
				{
					return this.m_owner.m_enemyActionHeadImage;
				}
				set
				{
					this.m_owner.m_enemyActionHeadImage = value;
				}
			}

			// Token: 0x170024E5 RID: 9445
			// (get) Token: 0x0600B662 RID: 46690 RVA: 0x0032532C File Offset: 0x0032352C
			// (set) Token: 0x0600B663 RID: 46691 RVA: 0x0032533C File Offset: 0x0032353C
			public Text m_enemyActionNameText
			{
				get
				{
					return this.m_owner.m_enemyActionNameText;
				}
				set
				{
					this.m_owner.m_enemyActionNameText = value;
				}
			}

			// Token: 0x170024E6 RID: 9446
			// (get) Token: 0x0600B664 RID: 46692 RVA: 0x0032534C File Offset: 0x0032354C
			// (set) Token: 0x0600B665 RID: 46693 RVA: 0x0032535C File Offset: 0x0032355C
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

			// Token: 0x170024E7 RID: 9447
			// (get) Token: 0x0600B666 RID: 46694 RVA: 0x0032536C File Offset: 0x0032356C
			// (set) Token: 0x0600B667 RID: 46695 RVA: 0x0032537C File Offset: 0x0032357C
			public GameObject m_battleSkillButtonPrefab
			{
				get
				{
					return this.m_owner.m_battleSkillButtonPrefab;
				}
				set
				{
					this.m_owner.m_battleSkillButtonPrefab = value;
				}
			}

			// Token: 0x170024E8 RID: 9448
			// (get) Token: 0x0600B668 RID: 46696 RVA: 0x0032538C File Offset: 0x0032358C
			// (set) Token: 0x0600B669 RID: 46697 RVA: 0x0032539C File Offset: 0x0032359C
			public CommonUIStateController m_armyRelationButtonUIStateController
			{
				get
				{
					return this.m_owner.m_armyRelationButtonUIStateController;
				}
				set
				{
					this.m_owner.m_armyRelationButtonUIStateController = value;
				}
			}

			// Token: 0x170024E9 RID: 9449
			// (get) Token: 0x0600B66A RID: 46698 RVA: 0x003253AC File Offset: 0x003235AC
			// (set) Token: 0x0600B66B RID: 46699 RVA: 0x003253BC File Offset: 0x003235BC
			public CommonUIStateController m_armyRelationDescUIStateController
			{
				get
				{
					return this.m_owner.m_armyRelationDescUIStateController;
				}
				set
				{
					this.m_owner.m_armyRelationDescUIStateController = value;
				}
			}

			// Token: 0x170024EA RID: 9450
			// (get) Token: 0x0600B66C RID: 46700 RVA: 0x003253CC File Offset: 0x003235CC
			// (set) Token: 0x0600B66D RID: 46701 RVA: 0x003253DC File Offset: 0x003235DC
			public Vector2 m_pointerDownPosition
			{
				get
				{
					return this.m_owner.m_pointerDownPosition;
				}
				set
				{
					this.m_owner.m_pointerDownPosition = value;
				}
			}

			// Token: 0x170024EB RID: 9451
			// (get) Token: 0x0600B66E RID: 46702 RVA: 0x003253EC File Offset: 0x003235EC
			// (set) Token: 0x0600B66F RID: 46703 RVA: 0x003253FC File Offset: 0x003235FC
			public GameObjectPool<BattleSkillButton> m_battleSkillButtonPool
			{
				get
				{
					return this.m_owner.m_battleSkillButtonPool;
				}
				set
				{
					this.m_owner.m_battleSkillButtonPool = value;
				}
			}

			// Token: 0x170024EC RID: 9452
			// (get) Token: 0x0600B670 RID: 46704 RVA: 0x0032540C File Offset: 0x0032360C
			// (set) Token: 0x0600B671 RID: 46705 RVA: 0x0032541C File Offset: 0x0032361C
			public float m_chatRedPointLastTime
			{
				get
				{
					return this.m_owner.m_chatRedPointLastTime;
				}
				set
				{
					this.m_owner.m_chatRedPointLastTime = value;
				}
			}

			// Token: 0x170024ED RID: 9453
			// (get) Token: 0x0600B672 RID: 46706 RVA: 0x0032542C File Offset: 0x0032362C
			// (set) Token: 0x0600B673 RID: 46707 RVA: 0x0032543C File Offset: 0x0032363C
			public float m_hideSkillHintTime
			{
				get
				{
					return this.m_owner.m_hideSkillHintTime;
				}
				set
				{
					this.m_owner.m_hideSkillHintTime = value;
				}
			}

			// Token: 0x170024EE RID: 9454
			// (get) Token: 0x0600B674 RID: 46708 RVA: 0x0032544C File Offset: 0x0032364C
			// (set) Token: 0x0600B675 RID: 46709 RVA: 0x0032545C File Offset: 0x0032365C
			public bool m_isShowSkillHint
			{
				get
				{
					return this.m_owner.m_isShowSkillHint;
				}
				set
				{
					this.m_owner.m_isShowSkillHint = value;
				}
			}

			// Token: 0x170024EF RID: 9455
			// (get) Token: 0x0600B676 RID: 46710 RVA: 0x0032546C File Offset: 0x0032366C
			// (set) Token: 0x0600B677 RID: 46711 RVA: 0x0032547C File Offset: 0x0032367C
			public bool m_isShowRegretPanel
			{
				get
				{
					return this.m_owner.m_isShowRegretPanel;
				}
				set
				{
					this.m_owner.m_isShowRegretPanel = value;
				}
			}

			// Token: 0x170024F0 RID: 9456
			// (get) Token: 0x0600B678 RID: 46712 RVA: 0x0032548C File Offset: 0x0032368C
			// (set) Token: 0x0600B679 RID: 46713 RVA: 0x0032549C File Offset: 0x0032369C
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

			// Token: 0x170024F1 RID: 9457
			// (get) Token: 0x0600B67A RID: 46714 RVA: 0x003254AC File Offset: 0x003236AC
			// (set) Token: 0x0600B67B RID: 46715 RVA: 0x003254BC File Offset: 0x003236BC
			public int m_turn
			{
				get
				{
					return this.m_owner.m_turn;
				}
				set
				{
					this.m_owner.m_turn = value;
				}
			}

			// Token: 0x170024F2 RID: 9458
			// (get) Token: 0x0600B67C RID: 46716 RVA: 0x003254CC File Offset: 0x003236CC
			// (set) Token: 0x0600B67D RID: 46717 RVA: 0x003254DC File Offset: 0x003236DC
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

			// Token: 0x170024F3 RID: 9459
			// (get) Token: 0x0600B67E RID: 46718 RVA: 0x003254EC File Offset: 0x003236EC
			// (set) Token: 0x0600B67F RID: 46719 RVA: 0x003254FC File Offset: 0x003236FC
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

			// Token: 0x0600B680 RID: 46720 RVA: 0x0032550C File Offset: 0x0032370C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600B681 RID: 46721 RVA: 0x0032551C File Offset: 0x0032371C
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x0600B682 RID: 46722 RVA: 0x0032552C File Offset: 0x0032372C
			public void WinOrLoseTweenFinished()
			{
				this.m_owner.WinOrLoseTweenFinished();
			}

			// Token: 0x0600B683 RID: 46723 RVA: 0x0032553C File Offset: 0x0032373C
			public static void ComputeActionIconPositionScale(int index, out Vector2 pos, out float scale)
			{
				BattleUIController.ComputeActionIconPositionScale(index, out pos, out scale);
			}

			// Token: 0x0600B684 RID: 46724 RVA: 0x00325548 File Offset: 0x00323748
			public void HideArmyRelation()
			{
				this.m_owner.HideArmyRelation();
			}

			// Token: 0x0600B685 RID: 46725 RVA: 0x00325558 File Offset: 0x00323758
			public void HideCutsceneSkill()
			{
				this.m_owner.HideCutsceneSkill();
			}

			// Token: 0x0600B686 RID: 46726 RVA: 0x00325568 File Offset: 0x00323768
			public void OnPauseButtonClick()
			{
				this.m_owner.OnPauseButtonClick();
			}

			// Token: 0x0600B687 RID: 46727 RVA: 0x00325578 File Offset: 0x00323778
			public void OnArmyRelationButtonClick()
			{
				this.m_owner.OnArmyRelationButtonClick();
			}

			// Token: 0x0600B688 RID: 46728 RVA: 0x00325588 File Offset: 0x00323788
			public void OnAutoButtonClick()
			{
				this.m_owner.OnAutoButtonClick();
			}

			// Token: 0x0600B689 RID: 46729 RVA: 0x00325598 File Offset: 0x00323798
			public void OnAutoOffButtonClick()
			{
				this.m_owner.OnAutoOffButtonClick();
			}

			// Token: 0x0600B68A RID: 46730 RVA: 0x003255A8 File Offset: 0x003237A8
			public void OnArenaAutoButtonClick()
			{
				this.m_owner.OnArenaAutoButtonClick();
			}

			// Token: 0x0600B68B RID: 46731 RVA: 0x003255B8 File Offset: 0x003237B8
			public void OnFastButtonClick()
			{
				this.m_owner.OnFastButtonClick();
			}

			// Token: 0x0600B68C RID: 46732 RVA: 0x003255C8 File Offset: 0x003237C8
			public void OnSkipCombatButtonClick()
			{
				this.m_owner.OnSkipCombatButtonClick();
			}

			// Token: 0x0600B68D RID: 46733 RVA: 0x003255D8 File Offset: 0x003237D8
			public void OnDangerOnButtonClick()
			{
				this.m_owner.OnDangerOnButtonClick();
			}

			// Token: 0x0600B68E RID: 46734 RVA: 0x003255E8 File Offset: 0x003237E8
			public void OnDangerOffButtonClick()
			{
				this.m_owner.OnDangerOffButtonClick();
			}

			// Token: 0x0600B68F RID: 46735 RVA: 0x003255F8 File Offset: 0x003237F8
			public void OnEndActionButtonClick()
			{
				this.m_owner.OnEndActionButtonClick();
			}

			// Token: 0x0600B690 RID: 46736 RVA: 0x00325608 File Offset: 0x00323808
			public void OnEndAllActionButtonClick()
			{
				this.m_owner.OnEndAllActionButtonClick();
			}

			// Token: 0x0600B691 RID: 46737 RVA: 0x00325618 File Offset: 0x00323818
			public void OnActorSimpleInfoButtonClick()
			{
				this.m_owner.OnActorSimpleInfoButtonClick();
			}

			// Token: 0x0600B692 RID: 46738 RVA: 0x00325628 File Offset: 0x00323828
			public void OnUseSkillButtonClick()
			{
				this.m_owner.OnUseSkillButtonClick();
			}

			// Token: 0x0600B693 RID: 46739 RVA: 0x00325638 File Offset: 0x00323838
			public void OnCancelSkillButtonClick()
			{
				this.m_owner.OnCancelSkillButtonClick();
			}

			// Token: 0x0600B694 RID: 46740 RVA: 0x00325648 File Offset: 0x00323848
			public void BattleSkillButton_OnClick(BattleSkillButton sb)
			{
				this.m_owner.BattleSkillButton_OnClick(sb);
			}

			// Token: 0x0600B695 RID: 46741 RVA: 0x00325658 File Offset: 0x00323858
			public void OnChatButtonClick()
			{
				this.m_owner.OnChatButtonClick();
			}

			// Token: 0x0600B696 RID: 46742 RVA: 0x00325668 File Offset: 0x00323868
			public void OnHelpButtonClick()
			{
				this.m_owner.OnHelpButtonClick();
			}

			// Token: 0x0600B697 RID: 46743 RVA: 0x00325678 File Offset: 0x00323878
			public void OnTerrainInfoButtonClick()
			{
				this.m_owner.OnTerrainInfoButtonClick();
			}

			// Token: 0x0600B698 RID: 46744 RVA: 0x00325688 File Offset: 0x00323888
			public void DeveloperModeClick()
			{
				this.m_owner.DeveloperModeClick();
			}

			// Token: 0x0600B699 RID: 46745 RVA: 0x00325698 File Offset: 0x00323898
			public void OnDanmakuToggleValueChanged(bool isOn)
			{
				this.m_owner.OnDanmakuToggleValueChanged(isOn);
			}

			// Token: 0x0600B69A RID: 46746 RVA: 0x003256A8 File Offset: 0x003238A8
			public void OnDanmakuInputWordButtonClick()
			{
				this.m_owner.OnDanmakuInputWordButtonClick();
			}

			// Token: 0x0600B69B RID: 46747 RVA: 0x003256B8 File Offset: 0x003238B8
			public void OnDanmakuInputBackButtonClick()
			{
				this.m_owner.OnDanmakuInputBackButtonClick();
			}

			// Token: 0x0600B69C RID: 46748 RVA: 0x003256C8 File Offset: 0x003238C8
			public void OnDanmakuSendButtonClick()
			{
				this.m_owner.OnDanmakuSendButtonClick();
			}

			// Token: 0x0600B69D RID: 46749 RVA: 0x003256D8 File Offset: 0x003238D8
			public void OnRegretButtonClick()
			{
				this.m_owner.OnRegretButtonClick();
			}

			// Token: 0x0600B69E RID: 46750 RVA: 0x003256E8 File Offset: 0x003238E8
			public void OnRegretConfirmButtonClick()
			{
				this.m_owner.OnRegretConfirmButtonClick();
			}

			// Token: 0x0600B69F RID: 46751 RVA: 0x003256F8 File Offset: 0x003238F8
			public void OnRegretCancelButtonClick()
			{
				this.m_owner.OnRegretCancelButtonClick();
			}

			// Token: 0x0600B6A0 RID: 46752 RVA: 0x00325708 File Offset: 0x00323908
			public void OnRegretBackwardButtonClick()
			{
				this.m_owner.OnRegretBackwardButtonClick();
			}

			// Token: 0x0600B6A1 RID: 46753 RVA: 0x00325718 File Offset: 0x00323918
			public void OnRegretForwardButtonClick()
			{
				this.m_owner.OnRegretForwardButtonClick();
			}

			// Token: 0x040075DF RID: 30175
			private BattleUIController m_owner;
		}
	}
}
