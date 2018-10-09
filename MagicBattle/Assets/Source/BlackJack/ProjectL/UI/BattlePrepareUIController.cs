using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A9A RID: 2714
	[HotFix]
	public class BattlePrepareUIController : UIControllerBase
	{
		// Token: 0x0600ACB9 RID: 44217 RVA: 0x0030060C File Offset: 0x002FE80C
		private BattlePrepareUIController()
		{
		}

		// Token: 0x0600ACBA RID: 44218 RVA: 0x00300638 File Offset: 0x002FE838
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
			this.m_heroButtonPrefab.SetActive(true);
			this.m_pauseButton.onClick.AddListener(new UnityAction(this.OnPauseButtonClick));
			this.m_startButton.onClick.AddListener(new UnityAction(this.OnStartButtonClick));
			this.m_actionOrderButton.onClick.AddListener(new UnityAction(this.OnActionOrderButtonClick));
			this.m_chatButton.onClick.AddListener(new UnityAction(this.OnChatButtonClick));
			this.m_testOnStageToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnTestOnStageToggle));
			this.m_teamReadyGameObject.SetActive(false);
			this.m_teamReadyWaitGameObject.SetActive(false);
			this.m_teamReadyTimeUIStateController.gameObject.SetActive(false);
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("ArmyRelation");
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer, this.m_marginTransform, false);
			gameObject.transform.SetAsFirstSibling();
			UIUtility.MarginAdjustHorizontal(gameObject.transform as RectTransform);
			Button button = Utility.FindChildComponent<Button>(gameObject, "ShowButton", true);
			button.onClick.AddListener(new UnityAction(this.OnArmyRelationButtonClick));
			Button button2 = Utility.FindChildComponent<Button>(gameObject, "ShowButton/HelpButton", true);
			button2.onClick.AddListener(new UnityAction(this.OnHelpButtonClick));
			this.m_armyRelationButtonUIStateController = button.gameObject.GetComponent<CommonUIStateController>();
			this.m_armyRelationDescUIStateController = Utility.FindChildComponent<CommonUIStateController>(gameObject, "Desc", true);
			this.m_armyRelationDescUIStateController.gameObject.SetActive(false);
			this.m_climbTowerRuleUIStateController.gameObject.SetActive(false);
			this.m_actorListDisableGameObject.SetActive(false);
			this.m_prefabsGameObject.SetActive(false);
			UIUtility.MarginAdjustHorizontal(this.m_marginTransform);
		}

		// Token: 0x0600ACBB RID: 44219 RVA: 0x00300848 File Offset: 0x002FEA48
		public void Initialize(ClientBattle clientBattle)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitializeClientBattle_hotfix != null)
			{
				this.m_InitializeClientBattle_hotfix.call(new object[]
				{
					this,
					clientBattle
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_clientBattle = clientBattle;
			this.m_stagePositions = new List<GridPosition>[3];
			this.m_stageDirs = new List<int>[3];
			for (int i = 0; i < this.m_stagePositions.Length; i++)
			{
				this.m_stagePositions[i] = new List<GridPosition>();
				this.m_stageDirs[i] = new List<int>();
			}
			this.m_camera = base.GetComponentInParent<Camera>();
		}

		// Token: 0x0600ACBC RID: 44220 RVA: 0x00300918 File Offset: 0x002FEB18
		private void OnDisable()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDisable_hotfix != null)
			{
				this.m_OnDisable_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_setBattlePowerValueCoroutine = null;
			this.m_battlePowerValue = 0;
			this.CancelDragging();
		}

		// Token: 0x0600ACBD RID: 44221 RVA: 0x0030098C File Offset: 0x002FEB8C
		private void OnApplicationPause(bool isPause)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnApplicationPauseBoolean_hotfix != null)
			{
				this.m_OnApplicationPauseBoolean_hotfix.call(new object[]
				{
					this,
					isPause
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isPause)
			{
				this.CancelDragging();
			}
		}

		// Token: 0x0600ACBE RID: 44222 RVA: 0x00300A08 File Offset: 0x002FEC08
		private void OnApplicationFocus(bool focus)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnApplicationFocusBoolean_hotfix != null)
			{
				this.m_OnApplicationFocusBoolean_hotfix.call(new object[]
				{
					this,
					focus
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!focus)
			{
				this.CancelDragging();
			}
		}

		// Token: 0x0600ACBF RID: 44223 RVA: 0x00300A84 File Offset: 0x002FEC84
		private void CancelDragging()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CancelDragging_hotfix != null)
			{
				this.m_CancelDragging_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_draggingHeroButton != null)
			{
				this.DestroyDragginHeroButton();
			}
			if (this.m_pointerDownStageActor != null)
			{
				this.ClearPointerDownStageActor();
			}
			EventSystem.current.pixelDragThreshold = UIUtility.GetDefaultPixelDragThreshold();
		}

		// Token: 0x0600ACC0 RID: 44224 RVA: 0x00300B1C File Offset: 0x002FED1C
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
			foreach (BattlePrepareStageActor battlePrepareStageActor in this.m_stageActors)
			{
				battlePrepareStageActor.TickGraphic(deltaTime);
			}
			this.CheckStageActorChange();
			if (Time.time - this.m_chatRedPointLastTime > 1f)
			{
				this.m_chatRedPointLastTime = Time.time;
				this.RefreshChatRedState();
			}
		}

		// Token: 0x0600ACC1 RID: 44225 RVA: 0x00300C00 File Offset: 0x002FEE00
		public void CheckStageActorChange()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckStageActorChange_hotfix != null)
			{
				this.m_CheckStageActorChange_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isStageActorChanged)
			{
				this.m_isStageActorChanged = false;
				this.UpdateStageActorCount();
				using (List<HeroDragButton>.Enumerator enumerator = this.m_heroButtons.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						HeroDragButton b = enumerator.Current;
						bool flag = !this.IsTestOnStage() && this.m_stageActors.Find((BattlePrepareStageActor x) => x.GetPositionType() == StagePositionType.Me && x.GetHero().HeroId == b.GetHero().HeroId) != null;
						b.gameObject.SetActive(!flag);
					}
				}
				this.SortChildByY(this.m_clientBattle.BattleActorUIRoot.transform);
				if (this.EventOnStageActorChange != null)
				{
					this.EventOnStageActorChange();
				}
			}
		}

		// Token: 0x0600ACC2 RID: 44226 RVA: 0x00300D38 File Offset: 0x002FEF38
		public void PrepareBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PrepareBattle_hotfix != null)
			{
				this.m_PrepareBattle_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideTerrainInfo();
			this.ClearStageActors();
			this.ClearBattleTreasures();
			this.ClearBattlePowerValue();
			this.m_armyRelationButtonUIStateController.SetToUIState("PrepareShow", false, true);
			this.m_setBattlePowerValueCoroutine = null;
			this.m_climbTowerRuleUIStateController.gameObject.SetActive(false);
			this.m_towerBattleRuleInfo = null;
			this.m_isIgnoreToggleEvent = true;
			this.m_testOnStageToggle.isOn = BattlePrepareUIController.s_isTestOnStage;
			this.m_isIgnoreToggleEvent = false;
			this.UpdateTestValuesToInputField();
			this.m_testGameObject.SetActive(this.IsTestBattle());
		}

		// Token: 0x0600ACC3 RID: 44227 RVA: 0x00300E18 File Offset: 0x002FF018
		public void Pause(bool pause)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PauseBoolean_hotfix != null)
			{
				this.m_PauseBoolean_hotfix.call(new object[]
				{
					this,
					pause
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattlePrepareStageActor battlePrepareStageActor in this.m_stageActors)
			{
				battlePrepareStageActor.Pause(pause);
			}
		}

		// Token: 0x0600ACC4 RID: 44228 RVA: 0x00300ED8 File Offset: 0x002FF0D8
		public void SetStageActorCountMax(int count)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetStageActorCountMaxInt32_hotfix != null)
			{
				this.m_SetStageActorCountMaxInt32_hotfix.call(new object[]
				{
					this,
					count
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_stageActorCountMax = count;
			this.UpdateStageActorCount();
		}

		// Token: 0x0600ACC5 RID: 44229 RVA: 0x00300F58 File Offset: 0x002FF158
		public void SetTurnStageActorCountMax(int count)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTurnStageActorCountMaxInt32_hotfix != null)
			{
				this.m_SetTurnStageActorCountMaxInt32_hotfix.call(new object[]
				{
					this,
					count
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_turnStageActorCountMax = count;
		}

		// Token: 0x0600ACC6 RID: 44230 RVA: 0x00300FD0 File Offset: 0x002FF1D0
		public void ClearHeros()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearHeros_hotfix != null)
			{
				this.m_ClearHeros_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (HeroDragButton heroDragButton in this.m_heroButtons)
			{
				heroDragButton.Destroy();
			}
			this.m_heroButtons.Clear();
		}

		// Token: 0x0600ACC7 RID: 44231 RVA: 0x0030108C File Offset: 0x002FF28C
		public void AddHero(BattleHero hero, StageActorTagType tagType = StageActorTagType.None)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddHeroBattleHeroStageActorTagType_hotfix != null)
			{
				this.m_AddHeroBattleHeroStageActorTagType_hotfix.call(new object[]
				{
					this,
					hero,
					tagType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (hero == null)
			{
				return;
			}
			HeroDragButton heroDragButton = this.CreateHeroButton(hero, this.m_actorListScrollRect.content);
			heroDragButton.SetTagType(tagType);
			this.m_heroButtons.Add(heroDragButton);
		}

		// Token: 0x0600ACC8 RID: 44232 RVA: 0x0030113C File Offset: 0x002FF33C
		public void ClearStagePositions()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearStagePositions_hotfix != null)
			{
				this.m_ClearStagePositions_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (List<GridPosition> list in this.m_stagePositions)
			{
				list.Clear();
			}
			foreach (List<int> list2 in this.m_stageDirs)
			{
				list2.Clear();
			}
		}

		// Token: 0x0600ACC9 RID: 44233 RVA: 0x003011F0 File Offset: 0x002FF3F0
		public void AddStagePosition(GridPosition p, int dir, StagePositionType posType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddStagePositionGridPositionInt32StagePositionType_hotfix != null)
			{
				this.m_AddStagePositionGridPositionInt32StagePositionType_hotfix.call(new object[]
				{
					this,
					p,
					dir,
					posType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_stagePositions[(int)posType].Add(p);
			this.m_stageDirs[(int)posType].Add(dir);
		}

		// Token: 0x0600ACCA RID: 44234 RVA: 0x003012A0 File Offset: 0x002FF4A0
		public List<GridPosition> GetStagePositions(StagePositionType posType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetStagePositionsStagePositionType_hotfix != null)
			{
				return (List<GridPosition>)this.m_GetStagePositionsStagePositionType_hotfix.call(new object[]
				{
					this,
					posType
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_stagePositions[(int)posType];
		}

		// Token: 0x0600ACCB RID: 44235 RVA: 0x00301328 File Offset: 0x002FF528
		private int GetStageDirection(GridPosition p, StagePositionType posType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetStageDirectionGridPositionStagePositionType_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetStageDirectionGridPositionStagePositionType_hotfix.call(new object[]
				{
					this,
					p,
					posType
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			for (int i = 0; i < this.m_stagePositions[(int)posType].Count; i++)
			{
				if (this.m_stagePositions[(int)posType][i] == p)
				{
					return this.m_stageDirs[(int)posType][i];
				}
			}
			return 0;
		}

		// Token: 0x0600ACCC RID: 44236 RVA: 0x00301400 File Offset: 0x002FF600
		private HeroDragButton CreateHeroButton(BattleHero hero, Transform parent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateHeroButtonBattleHeroTransform_hotfix != null)
			{
				return (HeroDragButton)this.m_CreateHeroButtonBattleHeroTransform_hotfix.call(new object[]
				{
					this,
					hero,
					parent
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject go = UnityEngine.Object.Instantiate<GameObject>(this.m_heroButtonPrefab, parent, false);
			HeroDragButton heroDragButton = GameObjectUtility.AddControllerToGameObject<HeroDragButton>(go);
			heroDragButton.SetHero(hero);
			heroDragButton.SetTagType(StageActorTagType.None);
			heroDragButton.EventOnClick += this.HeroDragButton_OnClick;
			heroDragButton.EventOnBeginDrag += this.HeroDragButton_OnBeginDrag;
			heroDragButton.EventOnEndDrag += this.HeroDragButton_OnEndDrag;
			heroDragButton.EventOnDrag += this.HeroDragButton_OnDrag;
			heroDragButton.EventOnDrop += this.HeroDragButton_OnDrop;
			return heroDragButton;
		}

		// Token: 0x0600ACCD RID: 44237 RVA: 0x0030150C File Offset: 0x002FF70C
		public void SkipStageActorGraphic(bool skip)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SkipStageActorGraphicBoolean_hotfix != null)
			{
				this.m_SkipStageActorGraphicBoolean_hotfix.call(new object[]
				{
					this,
					skip
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isSkipStageActorGraphic = skip;
		}

		// Token: 0x0600ACCE RID: 44238 RVA: 0x00301584 File Offset: 0x002FF784
		public void EnableHeroOnStage(bool enable)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EnableHeroOnStageBoolean_hotfix != null)
			{
				this.m_EnableHeroOnStageBoolean_hotfix.call(new object[]
				{
					this,
					enable
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_actorListDisableGameObject.SetActive(!enable);
			foreach (HeroDragButton heroDragButton in this.m_heroButtons)
			{
				heroDragButton.SetEnabled(enable);
			}
		}

		// Token: 0x0600ACCF RID: 44239 RVA: 0x00301654 File Offset: 0x002FF854
		public BattlePrepareStageActor HeroOnStage(BattleHero hero, GridPosition pos, int dir, int team, StagePositionType posType, StageActorTagType tagType = StageActorTagType.None, int behaviorId = -1, int groupId = 0, int playerIndex = -1)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroOnStageBattleHeroGridPositionInt32Int32StagePositionTypeStageActorTagTypeInt32Int32Int32_hotfix != null)
			{
				return (BattlePrepareStageActor)this.m_HeroOnStageBattleHeroGridPositionInt32Int32StagePositionTypeStageActorTagTypeInt32Int32Int32_hotfix.call(new object[]
				{
					this,
					hero,
					pos,
					dir,
					team,
					posType,
					tagType,
					behaviorId,
					groupId,
					playerIndex
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (hero == null)
			{
				return null;
			}
			BattlePrepareStageActor stageActor = this.GetStageActor(pos);
			if (stageActor != null)
			{
				if (stageActor.GetHeroId() == hero.HeroId && stageActor.GetSoldierId() == hero.SelectedSoldierId && stageActor.GetTeam() == team && stageActor.GetPositionType() == posType && stageActor.GetTagType() == tagType && stageActor.GetBehaviorId() == behaviorId && stageActor.GetGroupId() == groupId && stageActor.GetPlayerIndex() == playerIndex)
				{
					return stageActor;
				}
				this.ActorOffStage(stageActor);
			}
			BattlePrepareStageActor battlePrepareStageActor = new BattlePrepareStageActor(this.m_clientBattle);
			battlePrepareStageActor.Setup(hero, team, posType, tagType, behaviorId, groupId, playerIndex, this.m_isSkipStageActorGraphic);
			battlePrepareStageActor.SetPosition(pos, dir);
			battlePrepareStageActor.ForceUpdateSpine();
			this.m_stageActors.Add(battlePrepareStageActor);
			this.m_isStageActorChanged = true;
			return battlePrepareStageActor;
		}

		// Token: 0x0600ACD0 RID: 44240 RVA: 0x00301828 File Offset: 0x002FFA28
		public BattlePrepareStageActor HeroOnStage(BattleHero hero, GridPosition pos, int team, StagePositionType posType, int playerIndex, StageActorTagType tagType = StageActorTagType.None)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroOnStageBattleHeroGridPositionInt32StagePositionTypeInt32StageActorTagType_hotfix != null)
			{
				return (BattlePrepareStageActor)this.m_HeroOnStageBattleHeroGridPositionInt32StagePositionTypeInt32StageActorTagType_hotfix.call(new object[]
				{
					this,
					hero,
					pos,
					team,
					posType,
					playerIndex,
					tagType
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.HeroOnStage(hero, pos, this.GetStageDirection(pos, posType), team, posType, tagType, -1, 0, playerIndex);
		}

		// Token: 0x0600ACD1 RID: 44241 RVA: 0x00301910 File Offset: 0x002FFB10
		public void ActorOffStage(BattlePrepareStageActor sa)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActorOffStageBattlePrepareStageActor_hotfix != null)
			{
				this.m_ActorOffStageBattlePrepareStageActor_hotfix.call(new object[]
				{
					this,
					sa
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (sa == null)
			{
				return;
			}
			for (int i = 0; i < this.m_stageActors.Count; i++)
			{
				if (this.m_stageActors[i] == sa)
				{
					this.m_stageActors[i].Destroy();
					this.m_stageActors.RemoveAt(i);
					this.m_isStageActorChanged = true;
					break;
				}
			}
		}

		// Token: 0x0600ACD2 RID: 44242 RVA: 0x003019E0 File Offset: 0x002FFBE0
		public void ActorOnStageMove(BattlePrepareStageActor sa, GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActorOnStageMoveBattlePrepareStageActorGridPosition_hotfix != null)
			{
				this.m_ActorOnStageMoveBattlePrepareStageActorGridPosition_hotfix.call(new object[]
				{
					this,
					sa,
					p
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (sa == null)
			{
				return;
			}
			sa.SetPosition(p, this.GetStageDirection(p, sa.GetPositionType()));
			this.m_isStageActorChanged = true;
		}

		// Token: 0x0600ACD3 RID: 44243 RVA: 0x00301A84 File Offset: 0x002FFC84
		public void ActorOnStageExchange(BattlePrepareStageActor sa1, BattlePrepareStageActor sa2)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActorOnStageExchangeBattlePrepareStageActorBattlePrepareStageActor_hotfix != null)
			{
				this.m_ActorOnStageExchangeBattlePrepareStageActorBattlePrepareStageActor_hotfix.call(new object[]
				{
					this,
					sa1,
					sa2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (sa1 == null || sa2 == null)
			{
				return;
			}
			GridPosition position = sa1.GetPosition();
			int direction = sa1.GetDirection();
			sa1.SetPosition(sa2.GetPosition(), sa2.GetDirection());
			sa2.SetPosition(position, direction);
			this.m_isStageActorChanged = true;
		}

		// Token: 0x0600ACD4 RID: 44244 RVA: 0x00301B40 File Offset: 0x002FFD40
		private void SortChildByY(Transform parent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SortChildByYTransform_hotfix != null)
			{
				this.m_SortChildByYTransform_hotfix.call(new object[]
				{
					this,
					parent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Transform> list = new List<Transform>();
			for (int i = 0; i < parent.childCount; i++)
			{
				list.Add(parent.GetChild(i));
			}
			List<Transform> list2 = list;
			if (BattlePrepareUIController.<>f__mg$cache0 == null)
			{
				BattlePrepareUIController.<>f__mg$cache0 = new Comparison<Transform>(BattlePrepareUIController.CompareTransformY);
			}
			list2.Sort(BattlePrepareUIController.<>f__mg$cache0);
			for (int j = 0; j < list.Count; j++)
			{
				list[j].SetSiblingIndex(j);
			}
		}

		// Token: 0x0600ACD5 RID: 44245 RVA: 0x00301C24 File Offset: 0x002FFE24
		private static int CompareTransformY(Transform t0, Transform t1)
		{
			Vector2 vector = t0.position;
			Vector2 vector2 = t1.position;
			if (vector.y > vector2.y)
			{
				return -1;
			}
			if (vector.y < vector2.y)
			{
				return 1;
			}
			if (vector.x < vector2.x)
			{
				return -1;
			}
			if (vector.x > vector2.x)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x0600ACD6 RID: 44246 RVA: 0x00301CA0 File Offset: 0x002FFEA0
		public void ClearStageActors()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearStageActors_hotfix != null)
			{
				this.m_ClearStageActors_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattlePrepareStageActor battlePrepareStageActor in this.m_stageActors)
			{
				battlePrepareStageActor.Destroy();
			}
			this.m_stageActors.Clear();
			this.m_isStageActorChanged = true;
		}

		// Token: 0x0600ACD7 RID: 44247 RVA: 0x00301D60 File Offset: 0x002FFF60
		public BattlePrepareStageActor GetStageActor(GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetStageActorGridPosition_hotfix != null)
			{
				return (BattlePrepareStageActor)this.m_GetStageActorGridPosition_hotfix.call(new object[]
				{
					this,
					p
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattlePrepareStageActor battlePrepareStageActor in this.m_stageActors)
			{
				if (battlePrepareStageActor.GetPosition() == p)
				{
					return battlePrepareStageActor;
				}
			}
			return null;
		}

		// Token: 0x0600ACD8 RID: 44248 RVA: 0x00301E40 File Offset: 0x00300040
		public BattlePrepareStageActor GetStageActorByHeroId(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetStageActorByHeroIdInt32_hotfix != null)
			{
				return (BattlePrepareStageActor)this.m_GetStageActorByHeroIdInt32_hotfix.call(new object[]
				{
					this,
					heroId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattlePrepareStageActor battlePrepareStageActor in this.m_stageActors)
			{
				if (battlePrepareStageActor.GetHero().HeroId == heroId)
				{
					return battlePrepareStageActor;
				}
			}
			return null;
		}

		// Token: 0x0600ACD9 RID: 44249 RVA: 0x00301F20 File Offset: 0x00300120
		public List<BattlePrepareStageActor> GetStageActors()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetStageActors_hotfix != null)
			{
				return (List<BattlePrepareStageActor>)this.m_GetStageActors_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_stageActors;
		}

		// Token: 0x0600ACDA RID: 44250 RVA: 0x00301F94 File Offset: 0x00300194
		public void UpdateStageActor(BattleHero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateStageActorBattleHero_hotfix != null)
			{
				this.m_UpdateStageActorBattleHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattlePrepareStageActor battlePrepareStageActor in this.m_stageActors)
			{
				if (battlePrepareStageActor.GetHero() == hero)
				{
					battlePrepareStageActor.Setup(hero, battlePrepareStageActor.GetTeam(), battlePrepareStageActor.GetPositionType(), battlePrepareStageActor.GetTagType(), battlePrepareStageActor.GetBehaviorId(), battlePrepareStageActor.GetGroupId(), battlePrepareStageActor.GetPlayerIndex(), false);
					battlePrepareStageActor.SetPosition(battlePrepareStageActor.GetPosition(), battlePrepareStageActor.GetDirection());
				}
			}
		}

		// Token: 0x0600ACDB RID: 44251 RVA: 0x00302098 File Offset: 0x00300298
		public void AddBattleTreasure(ConfigDataBattleTreasureInfo treasureInfo, bool isOpened)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddBattleTreasureConfigDataBattleTreasureInfoBoolean_hotfix != null)
			{
				this.m_AddBattleTreasureConfigDataBattleTreasureInfoBoolean_hotfix.call(new object[]
				{
					this,
					treasureInfo,
					isOpened
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattlePrepareTreasure battlePrepareTreasure = new BattlePrepareTreasure();
			battlePrepareTreasure.Initialize(this.m_clientBattle, treasureInfo);
			battlePrepareTreasure.SetOpened(isOpened);
			this.m_treasures.Add(battlePrepareTreasure);
		}

		// Token: 0x0600ACDC RID: 44252 RVA: 0x00302140 File Offset: 0x00300340
		public void ClearBattleTreasures()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearBattleTreasures_hotfix != null)
			{
				this.m_ClearBattleTreasures_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattlePrepareTreasure battlePrepareTreasure in this.m_treasures)
			{
				battlePrepareTreasure.Destroy();
			}
			this.m_treasures.Clear();
		}

		// Token: 0x0600ACDD RID: 44253 RVA: 0x003021FC File Offset: 0x003003FC
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
			this.m_terrainInfoGameObject.SetActive(true);
			if (terrain != null)
			{
				this.m_terrainInfoText.text = terrain.Name;
				this.m_terrainInfoDefText.text = terrain.BattleBonus + "%";
				this.m_terrainInfoImage.sprite = AssetUtility.Instance.GetSprite(terrain.InfoImage);
			}
			else
			{
				this.m_terrainInfoText.text = string.Empty;
				this.m_terrainInfoDefText.text = 0 + "%";
			}
		}

		// Token: 0x0600ACDE RID: 44254 RVA: 0x003022FC File Offset: 0x003004FC
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

		// Token: 0x0600ACDF RID: 44255 RVA: 0x00302368 File Offset: 0x00300568
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
			UIUtility.SetUIStateOpen(this.m_armyRelationDescUIStateController, "PrepareShow", null, false, true);
			if (this.m_towerBattleRuleInfo != null)
			{
				this.HideClimbTowerBattleRule();
			}
		}

		// Token: 0x0600ACE0 RID: 44256 RVA: 0x003023EC File Offset: 0x003005EC
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
			UIUtility.SetUIStateClose(this.m_armyRelationDescUIStateController, "PrepareClose", null, false, true);
			if (this.m_towerBattleRuleInfo != null)
			{
				this.ShowClimbTowerBattleRule(this.m_towerBattleRuleInfo);
			}
		}

		// Token: 0x0600ACE1 RID: 44257 RVA: 0x00302478 File Offset: 0x00300678
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

		// Token: 0x0600ACE2 RID: 44258 RVA: 0x003024F4 File Offset: 0x003006F4
		public void ShowClimbTowerBattleRule(ConfigDataTowerBattleRuleInfo ruleInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowClimbTowerBattleRuleConfigDataTowerBattleRuleInfo_hotfix != null)
			{
				this.m_ShowClimbTowerBattleRuleConfigDataTowerBattleRuleInfo_hotfix.call(new object[]
				{
					this,
					ruleInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_climbTowerRuleUIStateController, "Show", null, false, false);
			this.m_climbTowerRuleText.text = ruleInfo.Desc;
			this.m_towerBattleRuleInfo = ruleInfo;
		}

		// Token: 0x0600ACE3 RID: 44259 RVA: 0x00302590 File Offset: 0x00300790
		public void HideClimbTowerBattleRule()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideClimbTowerBattleRule_hotfix != null)
			{
				this.m_HideClimbTowerBattleRule_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_climbTowerRuleUIStateController.gameObject.SetActive(false);
		}

		// Token: 0x0600ACE4 RID: 44260 RVA: 0x00302604 File Offset: 0x00300804
		public void ShowActionOrderButton(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowActionOrderButtonBoolean_hotfix != null)
			{
				this.m_ShowActionOrderButtonBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_actionOrderButton.gameObject.SetActive(show);
		}

		// Token: 0x0600ACE5 RID: 44261 RVA: 0x00302688 File Offset: 0x00300888
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

		// Token: 0x0600ACE6 RID: 44262 RVA: 0x00302710 File Offset: 0x00300910
		public void SetBattlePower(int battlePower)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBattlePowerInt32_hotfix != null)
			{
				this.m_SetBattlePowerInt32_hotfix.call(new object[]
				{
					this,
					battlePower
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_battlePowerValue == 0)
			{
				this.m_battlePowerArrowGo.SetActive(false);
				this.m_battlePowerText.text = battlePower.ToString();
			}
			else if (this.m_battlePowerValue != battlePower)
			{
				if (this.m_setBattlePowerValueCoroutine != null)
				{
					base.StopCoroutine(this.m_setBattlePowerValueCoroutine);
				}
				this.m_setBattlePowerValueCoroutine = base.StartCoroutine(this.Co_SetBattlePowerValue(battlePower, this.m_battlePowerValue));
			}
			else
			{
				this.m_battlePowerArrowGo.SetActive(false);
			}
			this.m_battlePowerValue = battlePower;
		}

		// Token: 0x0600ACE7 RID: 44263 RVA: 0x00302808 File Offset: 0x00300A08
		private void ClearBattlePowerValue()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearBattlePowerValue_hotfix != null)
			{
				this.m_ClearBattlePowerValue_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battlePowerValue = 0;
		}

		// Token: 0x0600ACE8 RID: 44264 RVA: 0x00302870 File Offset: 0x00300A70
		[DebuggerHidden]
		private IEnumerator Co_SetBattlePowerValue(int newValue, int oldValue)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_SetBattlePowerValueInt32Int32_hotfix != null)
			{
				return (IEnumerator)this.m_Co_SetBattlePowerValueInt32Int32_hotfix.call(new object[]
				{
					this,
					newValue,
					oldValue
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattlePrepareUIController.<Co_SetBattlePowerValue>c__Iterator0 <Co_SetBattlePowerValue>c__Iterator = new BattlePrepareUIController.<Co_SetBattlePowerValue>c__Iterator0();
			<Co_SetBattlePowerValue>c__Iterator.newValue = newValue;
			<Co_SetBattlePowerValue>c__Iterator.oldValue = oldValue;
			<Co_SetBattlePowerValue>c__Iterator.$this = this;
			return <Co_SetBattlePowerValue>c__Iterator;
		}

		// Token: 0x0600ACE9 RID: 44265 RVA: 0x00302918 File Offset: 0x00300B18
		private void UpdateTestValuesToInputField()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateTestValuesToInputField_hotfix != null)
			{
				this.m_UpdateTestValuesToInputField_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			BattlePrepareUIController.SetInputFieldValue(this.m_testSoldierInputField0, BattlePrepareUIController.s_testSoldierCount0, configDataLoader.Const_SoldierCountMax);
			BattlePrepareUIController.SetInputFieldValue(this.m_testSoldierInputField1, BattlePrepareUIController.s_testSoldierCount1, configDataLoader.Const_SoldierCountMax);
			BattlePrepareUIController.SetInputFieldValue(this.m_testSkillInputField0, BattlePrepareUIController.s_testSkillId0, 0);
			BattlePrepareUIController.SetInputFieldValue(this.m_testSkillInputField1, BattlePrepareUIController.s_testSkillId1, 0);
			BattlePrepareUIController.SetInputFieldValue(this.m_testTalentInputField0, BattlePrepareUIController.s_testTalentId0, 0);
			BattlePrepareUIController.SetInputFieldValue(this.m_testTalentInputField1, BattlePrepareUIController.s_testTalentId1, 0);
		}

		// Token: 0x0600ACEA RID: 44266 RVA: 0x003029F8 File Offset: 0x00300BF8
		private static void SetInputFieldValue(InputField inputField, int value, int defaultValue)
		{
			if (value != defaultValue)
			{
				inputField.text = value.ToString();
			}
			else
			{
				inputField.text = string.Empty;
			}
		}

		// Token: 0x0600ACEB RID: 44267 RVA: 0x00302A24 File Offset: 0x00300C24
		private void UpdateTestValuesFromInputField()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateTestValuesFromInputField_hotfix != null)
			{
				this.m_UpdateTestValuesFromInputField_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			BattlePrepareUIController.s_testSoldierCount0 = (BattlePrepareUIController.s_testSoldierCount1 = configDataLoader.Const_SoldierCountMax);
			BattlePrepareUIController.s_testSkillId0 = (BattlePrepareUIController.s_testSkillId1 = (BattlePrepareUIController.s_testTalentId0 = (BattlePrepareUIController.s_testTalentId1 = 0)));
			BattlePrepareUIController.s_testSoldierCount0 = BattlePrepareUIController.GetInputFieldValue(this.m_testSoldierInputField0, configDataLoader.Const_SoldierCountMax);
			BattlePrepareUIController.s_testSoldierCount1 = BattlePrepareUIController.GetInputFieldValue(this.m_testSoldierInputField1, configDataLoader.Const_SoldierCountMax);
			BattlePrepareUIController.s_testSkillId0 = BattlePrepareUIController.GetInputFieldValue(this.m_testSkillInputField0, 0);
			BattlePrepareUIController.s_testSkillId1 = BattlePrepareUIController.GetInputFieldValue(this.m_testSkillInputField1, 0);
			BattlePrepareUIController.s_testTalentId0 = BattlePrepareUIController.GetInputFieldValue(this.m_testTalentInputField0, 0);
			BattlePrepareUIController.s_testTalentId1 = BattlePrepareUIController.GetInputFieldValue(this.m_testTalentInputField1, 0);
		}

		// Token: 0x0600ACEC RID: 44268 RVA: 0x00302B30 File Offset: 0x00300D30
		private static int GetInputFieldValue(InputField inputField, int defaultValue)
		{
			int result = defaultValue;
			if (!string.IsNullOrEmpty(inputField.text) && !int.TryParse(inputField.text, out result))
			{
				result = defaultValue;
			}
			return result;
		}

		// Token: 0x0600ACED RID: 44269 RVA: 0x00302B64 File Offset: 0x00300D64
		public void ShowStartButton(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowStartButtonBoolean_hotfix != null)
			{
				this.m_ShowStartButtonBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_startButton.gameObject.SetActive(show);
		}

		// Token: 0x0600ACEE RID: 44270 RVA: 0x00302BE8 File Offset: 0x00300DE8
		public void ShowTeamReadyCountdown(TimeSpan ts)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowTeamReadyCountdownTimeSpan_hotfix != null)
			{
				this.m_ShowTeamReadyCountdownTimeSpan_hotfix.call(new object[]
				{
					this,
					ts
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_teamReadyGameObject.SetActive(true);
			UIUtility.SetUIStateOpen(this.m_teamReadyTimeUIStateController, "Show", null, false, false);
			this.m_teamReadyTimeText.text = Mathf.CeilToInt((float)ts.TotalSeconds).ToString();
			this.HideTeamReadyWait();
		}

		// Token: 0x0600ACEF RID: 44271 RVA: 0x00302CA4 File Offset: 0x00300EA4
		private void HideTeamReadyCountdown()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideTeamReadyCountdown_hotfix != null)
			{
				this.m_HideTeamReadyCountdown_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_teamReadyTimeUIStateController, "Close", null, false, false);
		}

		// Token: 0x0600ACF0 RID: 44272 RVA: 0x00302D18 File Offset: 0x00300F18
		public void ShowTeamReadyWait(BattleRoomType battleRoomType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowTeamReadyWaitBattleRoomType_hotfix != null)
			{
				this.m_ShowTeamReadyWaitBattleRoomType_hotfix.call(new object[]
				{
					this,
					battleRoomType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (battleRoomType == BattleRoomType.RealTimePVPBPMode)
			{
				return;
			}
			this.m_teamReadyGameObject.SetActive(true);
			this.m_teamReadyWaitGameObject.SetActive(true);
			this.m_teamReadyWaitTeammateText.gameObject.SetActive(battleRoomType == BattleRoomType.Team || battleRoomType == BattleRoomType.GuildMassiveCombat);
			this.m_teamReadyWaitOpponentText.gameObject.SetActive(battleRoomType == BattleRoomType.PVP || battleRoomType == BattleRoomType.RealTimePVPDefaultMode);
			this.HideTeamReadyCountdown();
		}

		// Token: 0x0600ACF1 RID: 44273 RVA: 0x00302DEC File Offset: 0x00300FEC
		private void HideTeamReadyWait()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideTeamReadyWait_hotfix != null)
			{
				this.m_HideTeamReadyWait_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_teamReadyWaitGameObject.SetActive(false);
		}

		// Token: 0x0600ACF2 RID: 44274 RVA: 0x00302E58 File Offset: 0x00301058
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

		// Token: 0x0600ACF3 RID: 44275 RVA: 0x00302ED0 File Offset: 0x003010D0
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

		// Token: 0x0600ACF4 RID: 44276 RVA: 0x00302F48 File Offset: 0x00301148
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
			this.UpdateTestValuesFromInputField();
			if (this.EventOnStart != null)
			{
				this.EventOnStart();
			}
		}

		// Token: 0x0600ACF5 RID: 44277 RVA: 0x00302FC4 File Offset: 0x003011C4
		private void OnActionOrderButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnActionOrderButtonClick_hotfix != null)
			{
				this.m_OnActionOrderButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowActionOrder != null)
			{
				this.EventOnShowActionOrder();
			}
		}

		// Token: 0x0600ACF6 RID: 44278 RVA: 0x0030303C File Offset: 0x0030123C
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

		// Token: 0x0600ACF7 RID: 44279 RVA: 0x003030B4 File Offset: 0x003012B4
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

		// Token: 0x0600ACF8 RID: 44280 RVA: 0x0030312C File Offset: 0x0030132C
		public bool IsTestBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsTestBattle_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsTestBattle_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.Happening.BattleInfo == null && projectLPlayerContext.CurrentBattle.ArenaBattleInfo == null && projectLPlayerContext.CurrentBattle.PVPBattleInfo == null && projectLPlayerContext.CurrentBattle.RealTimePVPBattleInfo == null;
		}

		// Token: 0x0600ACF9 RID: 44281 RVA: 0x003031EC File Offset: 0x003013EC
		private void OnTestOnStageToggle(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTestOnStageToggleBoolean_hotfix != null)
			{
				this.m_OnTestOnStageToggleBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			BattlePrepareUIController.s_isTestOnStage = on;
			if (this.EventOnTestOnStage != null)
			{
				this.EventOnTestOnStage();
			}
		}

		// Token: 0x0600ACFA RID: 44282 RVA: 0x00303284 File Offset: 0x00301484
		public bool IsTestOnStage()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsTestOnStage_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsTestOnStage_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return BattlePrepareUIController.s_isTestOnStage && this.IsTestBattle();
		}

		// Token: 0x0600ACFB RID: 44283 RVA: 0x00303304 File Offset: 0x00301504
		public int GetTestSoldierCount(int team)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTestSoldierCountInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetTestSoldierCountInt32_hotfix.call(new object[]
				{
					this,
					team
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (team == 0)
			{
				return BattlePrepareUIController.s_testSoldierCount0;
			}
			return BattlePrepareUIController.s_testSoldierCount1;
		}

		// Token: 0x0600ACFC RID: 44284 RVA: 0x00303394 File Offset: 0x00301594
		public int GetTestSkillId(int team)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTestSkillIdInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetTestSkillIdInt32_hotfix.call(new object[]
				{
					this,
					team
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (team == 0)
			{
				return BattlePrepareUIController.s_testSkillId0;
			}
			return BattlePrepareUIController.s_testSkillId1;
		}

		// Token: 0x0600ACFD RID: 44285 RVA: 0x00303424 File Offset: 0x00301624
		public int GetTestTalentId(int team)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTestTalentIdInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetTestTalentIdInt32_hotfix.call(new object[]
				{
					this,
					team
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (team == 0)
			{
				return BattlePrepareUIController.s_testTalentId0;
			}
			return BattlePrepareUIController.s_testTalentId1;
		}

		// Token: 0x0600ACFE RID: 44286 RVA: 0x003034B4 File Offset: 0x003016B4
		private void ClearPointerDownStageActor()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearPointerDownStageActor_hotfix != null)
			{
				this.m_ClearPointerDownStageActor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_pointerDownStageActor != null)
			{
				this.m_pointerDownStageActor.TweenColor(new Colori(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue));
				this.m_pointerDownStageActor = null;
			}
		}

		// Token: 0x0600ACFF RID: 44287 RVA: 0x0030354C File Offset: 0x0030174C
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
			this.m_isIgnorePointerClick = false;
			GridPosition p = this.m_clientBattle.ScreenPositionToGridPosition(eventData.position);
			this.m_pointerDownStageActor = this.GetStageActor(p);
			if (this.m_pointerDownStageActor != null)
			{
				this.m_pointerDownStageActor.TweenColor(new Colori(200, 200, 200, byte.MaxValue));
			}
			else
			{
				this.HideActorInfo();
			}
			if (this.EventOnPointerDown != null)
			{
				this.EventOnPointerDown(eventData.button, eventData.position);
			}
		}

		// Token: 0x0600AD00 RID: 44288 RVA: 0x00303640 File Offset: 0x00301840
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
			if (this.m_pointerDownStageActor != null)
			{
				this.m_pointerDownStageActor.TweenColor(new Colori(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue));
				if (this.m_draggingHeroButton != null)
				{
					this.m_isIgnorePointerClick = true;
				}
				else
				{
					this.m_pointerDownStageActor = null;
				}
			}
			if (this.EventOnPointerUp != null)
			{
				this.EventOnPointerUp(eventData.button, eventData.position);
			}
		}

		// Token: 0x0600AD01 RID: 44289 RVA: 0x00303728 File Offset: 0x00301928
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
			if (this.EventOnPointerClick != null && !this.m_isIgnorePointerClick)
			{
				this.EventOnPointerClick(eventData.button, eventData.position);
			}
			this.m_isIgnorePointerClick = false;
		}

		// Token: 0x0600AD02 RID: 44290 RVA: 0x003037CC File Offset: 0x003019CC
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
			if (this.m_pointerDownStageActor != null && this.m_draggingHeroButton == null)
			{
				bool flag = (this.m_pointerDownStageActor.GetPositionType() == StagePositionType.Me || this.IsTestOnStage()) && !this.m_pointerDownStageActor.IsNpc() && !this.m_pointerDownStageActor.IsEnforce() && !this.m_pointerDownStageActor.IsGray() && !this.m_actorListDisableGameObject.activeSelf;
				if (flag)
				{
					this.HideActorInfo();
					this.m_pointerDownStageActor.TweenColor(new Colori(150, 150, 150, byte.MaxValue));
					this.CreateDraggingHeroButton(this.m_pointerDownStageActor.GetHero());
				}
				else
				{
					if (this.m_pointerDownStageActor.IsNpc())
					{
						CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Battle_CanNotDragNPC, 2f, null, true);
					}
					else if (this.m_pointerDownStageActor.IsEnforce())
					{
						CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Battle_CanNotDragEnforceHero, 2f, null, true);
					}
					else if (this.m_pointerDownStageActor.GetPositionType() == StagePositionType.Teammate)
					{
						CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Team_CanNotChangeTeammate, 2f, null, true);
					}
					this.ClearPointerDownStageActor();
					this.m_isIgnorePointerClick = true;
				}
			}
		}

		// Token: 0x0600AD03 RID: 44291 RVA: 0x00303988 File Offset: 0x00301B88
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
			if (this.m_draggingHeroButton != null)
			{
				this.DropHeroButton(eventData.position);
				this.DestroyDragginHeroButton();
				this.ClearPointerDownStageActor();
			}
		}

		// Token: 0x0600AD04 RID: 44292 RVA: 0x00303A24 File Offset: 0x00301C24
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
			if (this.m_draggingHeroButton != null)
			{
				this.MoveDraggingHeroButton(eventData.position);
			}
		}

		// Token: 0x0600AD05 RID: 44293 RVA: 0x00303AB4 File Offset: 0x00301CB4
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
		}

		// Token: 0x0600AD06 RID: 44294 RVA: 0x00303B24 File Offset: 0x00301D24
		private void CreateDraggingHeroButton(BattleHero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateDraggingHeroButtonBattleHero_hotfix != null)
			{
				this.m_CreateDraggingHeroButtonBattleHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DestroyDragginHeroButton();
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			this.m_draggingHeroButton = this.CreateHeroButton(hero, componentInParent.transform);
			this.m_draggingHeroButton.transform.SetAsLastSibling();
			AudioUtility.PlaySound(SoundTableId.SoundTableId_DragHero);
			CommonUIController.Instance.EnableInput(false);
			if (this.EventOnBeginDragHero != null)
			{
				this.EventOnBeginDragHero();
			}
		}

		// Token: 0x0600AD07 RID: 44295 RVA: 0x00303BEC File Offset: 0x00301DEC
		private void DestroyDragginHeroButton()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroyDragginHeroButton_hotfix != null)
			{
				this.m_DestroyDragginHeroButton_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_draggingHeroButton != null)
			{
				this.m_draggingHeroButton.Destroy();
				this.m_draggingHeroButton = null;
				foreach (HeroDragButton heroDragButton in this.m_heroButtons)
				{
					heroDragButton.CancelDrag();
				}
				CommonUIController.Instance.EnableInput(true);
				if (this.EventOnEndDragHero != null)
				{
					this.EventOnEndDragHero();
				}
			}
		}

		// Token: 0x0600AD08 RID: 44296 RVA: 0x00303CE0 File Offset: 0x00301EE0
		private void MoveDraggingHeroButton(Vector2 pos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_MoveDraggingHeroButtonVector2_hotfix != null)
			{
				this.m_MoveDraggingHeroButtonVector2_hotfix.call(new object[]
				{
					this,
					pos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_draggingHeroButton != null)
			{
				Canvas componentInParent = base.GetComponentInParent<Canvas>();
				RectTransform rect = componentInParent.transform as RectTransform;
				Vector3 position;
				if (RectTransformUtility.ScreenPointToWorldPointInRectangle(rect, pos, this.m_camera, out position))
				{
					position.y += 0.3f;
					this.m_draggingHeroButton.transform.position = position;
				}
			}
		}

		// Token: 0x0600AD09 RID: 44297 RVA: 0x00303DAC File Offset: 0x00301FAC
		public void DropHeroButton(Vector2 pos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DropHeroButtonVector2_hotfix != null)
			{
				this.m_DropHeroButtonVector2_hotfix.call(new object[]
				{
					this,
					pos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_draggingHeroButton == null)
			{
				return;
			}
			GridPosition gridPosition = new GridPosition(0, 0);
			StagePositionType stagePositionType = (StagePositionType)(-1);
			float num = float.MaxValue;
			Vector2 a = this.m_clientBattle.ScreenPositionToWorldPosition(pos);
			for (int i = 0; i < this.m_stagePositions.Length; i++)
			{
				for (int j = 0; j < this.m_stagePositions[i].Count; j++)
				{
					GridPosition gridPosition2 = this.m_stagePositions[i][j];
					Vector2 b = this.m_clientBattle.GridPositionToWorldPosition(gridPosition2);
					float num2 = Vector2.Distance(a, b);
					if (num2 <= 2f)
					{
						if (num2 <= num)
						{
							stagePositionType = (StagePositionType)i;
							gridPosition = gridPosition2;
							num = num2;
						}
					}
				}
			}
			if (stagePositionType == StagePositionType.Teammate)
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Team_CanNotChangeTeammate, 2f, null, true);
				return;
			}
			if (stagePositionType == StagePositionType.Enemy && !this.IsTestOnStage())
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Team_CanNotChangeEnemy, 2f, null, true);
				return;
			}
			BattlePrepareStageActor stageActor = this.GetStageActor(gridPosition);
			if (stageActor != null)
			{
				if (stageActor.IsEnforce())
				{
					CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Battle_CanNotDragEnforceHero, 2f, null, true);
					return;
				}
				if (stageActor.IsGray())
				{
					return;
				}
			}
			if (this.m_pointerDownStageActor != null)
			{
				if (this.m_pointerDownStageActor.GetPositionType() == stagePositionType)
				{
					if (stageActor != null)
					{
						if (this.EventOnStageActorSwap != null)
						{
							this.EventOnStageActorSwap(this.m_pointerDownStageActor, stageActor);
						}
					}
					else if (this.EventOnStageActorMove != null)
					{
						this.EventOnStageActorMove(this.m_pointerDownStageActor, gridPosition);
					}
				}
				else if (this.EventOnActorOffStage != null)
				{
					this.EventOnActorOffStage(this.m_pointerDownStageActor);
				}
				this.ClearPointerDownStageActor();
			}
			else if (stagePositionType >= StagePositionType.Me)
			{
				int num3 = this.ComputeStageActorCount();
				int num4 = 1000;
				if (!this.IsTestOnStage() && stagePositionType == StagePositionType.Me)
				{
					if (this.m_turnStageActorCountMax != 0)
					{
						num4 = this.m_turnStageActorCountMax;
					}
					else
					{
						num4 = this.m_stageActorCountMax;
					}
					if (stageActor == null)
					{
						num4--;
					}
				}
				if (num3 <= num4)
				{
					int arg = (stagePositionType != StagePositionType.Enemy) ? 0 : 1;
					if (this.EventOnHeroOnStage != null)
					{
						this.EventOnHeroOnStage(this.m_draggingHeroButton.GetHero(), gridPosition, arg);
					}
				}
				else if (this.m_turnStageActorCountMax != 0)
				{
					CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Battle_CanNotStageHero, 2f, null, true);
				}
				else
				{
					CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Battle_StageHeroCountMax, 2f, null, true);
				}
			}
		}

		// Token: 0x0600AD0A RID: 44298 RVA: 0x003040C8 File Offset: 0x003022C8
		public int ComputeStageActorCount()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeStageActorCount_hotfix != null)
			{
				return Convert.ToInt32(this.m_ComputeStageActorCount_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			foreach (BattlePrepareStageActor battlePrepareStageActor in this.m_stageActors)
			{
				if (!battlePrepareStageActor.IsNpc())
				{
					if (battlePrepareStageActor.GetTeam() == 0)
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x0600AD0B RID: 44299 RVA: 0x003041A0 File Offset: 0x003023A0
		private void UpdateStageActorCount()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateStageActorCount_hotfix != null)
			{
				this.m_UpdateStageActorCount_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_stageActorCountText.text = this.ComputeStageActorCount() + " / " + this.m_stageActorCountMax;
		}

		// Token: 0x0600AD0C RID: 44300 RVA: 0x0030422C File Offset: 0x0030242C
		public void HeroDragButton_OnBeginDrag(HeroDragButton b, PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroDragButton_OnBeginDragHeroDragButtonPointerEventData_hotfix != null)
			{
				this.m_HeroDragButton_OnBeginDragHeroDragButtonPointerEventData_hotfix.call(new object[]
				{
					this,
					b,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideActorInfo();
			this.CreateDraggingHeroButton(b.GetHero());
		}

		// Token: 0x0600AD0D RID: 44301 RVA: 0x003042C0 File Offset: 0x003024C0
		public void HeroDragButton_OnEndDrag(HeroDragButton b, PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroDragButton_OnEndDragHeroDragButtonPointerEventData_hotfix != null)
			{
				this.m_HeroDragButton_OnEndDragHeroDragButtonPointerEventData_hotfix.call(new object[]
				{
					this,
					b,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DestroyDragginHeroButton();
		}

		// Token: 0x0600AD0E RID: 44302 RVA: 0x00304348 File Offset: 0x00302548
		public void HeroDragButton_OnDrag(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroDragButton_OnDragPointerEventData_hotfix != null)
			{
				this.m_HeroDragButton_OnDragPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.MoveDraggingHeroButton(eventData.position);
		}

		// Token: 0x0600AD0F RID: 44303 RVA: 0x003043C4 File Offset: 0x003025C4
		public void HeroDragButton_OnDrop(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroDragButton_OnDropPointerEventData_hotfix != null)
			{
				this.m_HeroDragButton_OnDropPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DropHeroButton(eventData.position);
		}

		// Token: 0x0600AD10 RID: 44304 RVA: 0x00304440 File Offset: 0x00302640
		public void HeroDragButton_OnClick(HeroDragButton b)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroDragButton_OnClickHeroDragButton_hotfix != null)
			{
				this.m_HeroDragButton_OnClickHeroDragButton_hotfix.call(new object[]
				{
					this,
					b
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.CancelDragging();
			if (this.EventOnShowMyActorInfo != null)
			{
				this.EventOnShowMyActorInfo(b.GetHero());
			}
		}

		// Token: 0x0600AD11 RID: 44305 RVA: 0x003044D4 File Offset: 0x003026D4
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

		// Token: 0x0600AD12 RID: 44306 RVA: 0x0030457C File Offset: 0x0030277C
		private void HideActorInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideActorInfo_hotfix != null)
			{
				this.m_HideActorInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnHideActorInfo != null)
			{
				this.EventOnHideActorInfo();
			}
		}

		// Token: 0x140001FC RID: 508
		// (add) Token: 0x0600AD13 RID: 44307 RVA: 0x003045F4 File Offset: 0x003027F4
		// (remove) Token: 0x0600AD14 RID: 44308 RVA: 0x00304690 File Offset: 0x00302890
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

		// Token: 0x140001FD RID: 509
		// (add) Token: 0x0600AD15 RID: 44309 RVA: 0x0030472C File Offset: 0x0030292C
		// (remove) Token: 0x0600AD16 RID: 44310 RVA: 0x003047C8 File Offset: 0x003029C8
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

		// Token: 0x140001FE RID: 510
		// (add) Token: 0x0600AD17 RID: 44311 RVA: 0x00304864 File Offset: 0x00302A64
		// (remove) Token: 0x0600AD18 RID: 44312 RVA: 0x00304900 File Offset: 0x00302B00
		public event Action EventOnStart
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnStartAction_hotfix != null)
				{
					this.m_add_EventOnStartAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnStart;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnStart, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnStartAction_hotfix != null)
				{
					this.m_remove_EventOnStartAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnStart;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnStart, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001FF RID: 511
		// (add) Token: 0x0600AD19 RID: 44313 RVA: 0x0030499C File Offset: 0x00302B9C
		// (remove) Token: 0x0600AD1A RID: 44314 RVA: 0x00304A38 File Offset: 0x00302C38
		public event Action EventOnShowActionOrder
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowActionOrderAction_hotfix != null)
				{
					this.m_add_EventOnShowActionOrderAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowActionOrder;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowActionOrder, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowActionOrderAction_hotfix != null)
				{
					this.m_remove_EventOnShowActionOrderAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowActionOrder;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowActionOrder, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000200 RID: 512
		// (add) Token: 0x0600AD1B RID: 44315 RVA: 0x00304AD4 File Offset: 0x00302CD4
		// (remove) Token: 0x0600AD1C RID: 44316 RVA: 0x00304B70 File Offset: 0x00302D70
		public event Action EventOnTestOnStage
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnTestOnStageAction_hotfix != null)
				{
					this.m_add_EventOnTestOnStageAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnTestOnStage;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnTestOnStage, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnTestOnStageAction_hotfix != null)
				{
					this.m_remove_EventOnTestOnStageAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnTestOnStage;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnTestOnStage, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000201 RID: 513
		// (add) Token: 0x0600AD1D RID: 44317 RVA: 0x00304C0C File Offset: 0x00302E0C
		// (remove) Token: 0x0600AD1E RID: 44318 RVA: 0x00304CA8 File Offset: 0x00302EA8
		public event Action<BattleHero> EventOnShowMyActorInfo
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowMyActorInfoAction`1_hotfix != null)
				{
					this.m_add_EventOnShowMyActorInfoAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleHero> action = this.EventOnShowMyActorInfo;
				Action<BattleHero> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleHero>>(ref this.EventOnShowMyActorInfo, (Action<BattleHero>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowMyActorInfoAction`1_hotfix != null)
				{
					this.m_remove_EventOnShowMyActorInfoAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleHero> action = this.EventOnShowMyActorInfo;
				Action<BattleHero> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleHero>>(ref this.EventOnShowMyActorInfo, (Action<BattleHero>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000202 RID: 514
		// (add) Token: 0x0600AD1F RID: 44319 RVA: 0x00304D44 File Offset: 0x00302F44
		// (remove) Token: 0x0600AD20 RID: 44320 RVA: 0x00304DE0 File Offset: 0x00302FE0
		public event Action EventOnHideActorInfo
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnHideActorInfoAction_hotfix != null)
				{
					this.m_add_EventOnHideActorInfoAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnHideActorInfo;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnHideActorInfo, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnHideActorInfoAction_hotfix != null)
				{
					this.m_remove_EventOnHideActorInfoAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnHideActorInfo;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnHideActorInfo, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000203 RID: 515
		// (add) Token: 0x0600AD21 RID: 44321 RVA: 0x00304E7C File Offset: 0x0030307C
		// (remove) Token: 0x0600AD22 RID: 44322 RVA: 0x00304F18 File Offset: 0x00303118
		public event Action EventOnStageActorChange
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnStageActorChangeAction_hotfix != null)
				{
					this.m_add_EventOnStageActorChangeAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnStageActorChange;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnStageActorChange, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnStageActorChangeAction_hotfix != null)
				{
					this.m_remove_EventOnStageActorChangeAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnStageActorChange;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnStageActorChange, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000204 RID: 516
		// (add) Token: 0x0600AD23 RID: 44323 RVA: 0x00304FB4 File Offset: 0x003031B4
		// (remove) Token: 0x0600AD24 RID: 44324 RVA: 0x00305050 File Offset: 0x00303250
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

		// Token: 0x14000205 RID: 517
		// (add) Token: 0x0600AD25 RID: 44325 RVA: 0x003050EC File Offset: 0x003032EC
		// (remove) Token: 0x0600AD26 RID: 44326 RVA: 0x00305188 File Offset: 0x00303388
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

		// Token: 0x14000206 RID: 518
		// (add) Token: 0x0600AD27 RID: 44327 RVA: 0x00305224 File Offset: 0x00303424
		// (remove) Token: 0x0600AD28 RID: 44328 RVA: 0x003052C0 File Offset: 0x003034C0
		public event Action<BattleHero, GridPosition, int> EventOnHeroOnStage
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnHeroOnStageAction`3_hotfix != null)
				{
					this.m_add_EventOnHeroOnStageAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleHero, GridPosition, int> action = this.EventOnHeroOnStage;
				Action<BattleHero, GridPosition, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleHero, GridPosition, int>>(ref this.EventOnHeroOnStage, (Action<BattleHero, GridPosition, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnHeroOnStageAction`3_hotfix != null)
				{
					this.m_remove_EventOnHeroOnStageAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleHero, GridPosition, int> action = this.EventOnHeroOnStage;
				Action<BattleHero, GridPosition, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleHero, GridPosition, int>>(ref this.EventOnHeroOnStage, (Action<BattleHero, GridPosition, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000207 RID: 519
		// (add) Token: 0x0600AD29 RID: 44329 RVA: 0x0030535C File Offset: 0x0030355C
		// (remove) Token: 0x0600AD2A RID: 44330 RVA: 0x003053F8 File Offset: 0x003035F8
		public event Action<BattlePrepareStageActor> EventOnActorOffStage
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnActorOffStageAction`1_hotfix != null)
				{
					this.m_add_EventOnActorOffStageAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattlePrepareStageActor> action = this.EventOnActorOffStage;
				Action<BattlePrepareStageActor> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattlePrepareStageActor>>(ref this.EventOnActorOffStage, (Action<BattlePrepareStageActor>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnActorOffStageAction`1_hotfix != null)
				{
					this.m_remove_EventOnActorOffStageAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattlePrepareStageActor> action = this.EventOnActorOffStage;
				Action<BattlePrepareStageActor> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattlePrepareStageActor>>(ref this.EventOnActorOffStage, (Action<BattlePrepareStageActor>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000208 RID: 520
		// (add) Token: 0x0600AD2B RID: 44331 RVA: 0x00305494 File Offset: 0x00303694
		// (remove) Token: 0x0600AD2C RID: 44332 RVA: 0x00305530 File Offset: 0x00303730
		public event Action<BattlePrepareStageActor, GridPosition> EventOnStageActorMove
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnStageActorMoveAction`2_hotfix != null)
				{
					this.m_add_EventOnStageActorMoveAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattlePrepareStageActor, GridPosition> action = this.EventOnStageActorMove;
				Action<BattlePrepareStageActor, GridPosition> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattlePrepareStageActor, GridPosition>>(ref this.EventOnStageActorMove, (Action<BattlePrepareStageActor, GridPosition>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnStageActorMoveAction`2_hotfix != null)
				{
					this.m_remove_EventOnStageActorMoveAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattlePrepareStageActor, GridPosition> action = this.EventOnStageActorMove;
				Action<BattlePrepareStageActor, GridPosition> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattlePrepareStageActor, GridPosition>>(ref this.EventOnStageActorMove, (Action<BattlePrepareStageActor, GridPosition>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000209 RID: 521
		// (add) Token: 0x0600AD2D RID: 44333 RVA: 0x003055CC File Offset: 0x003037CC
		// (remove) Token: 0x0600AD2E RID: 44334 RVA: 0x00305668 File Offset: 0x00303868
		public event Action<BattlePrepareStageActor, BattlePrepareStageActor> EventOnStageActorSwap
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnStageActorSwapAction`2_hotfix != null)
				{
					this.m_add_EventOnStageActorSwapAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattlePrepareStageActor, BattlePrepareStageActor> action = this.EventOnStageActorSwap;
				Action<BattlePrepareStageActor, BattlePrepareStageActor> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattlePrepareStageActor, BattlePrepareStageActor>>(ref this.EventOnStageActorSwap, (Action<BattlePrepareStageActor, BattlePrepareStageActor>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnStageActorSwapAction`2_hotfix != null)
				{
					this.m_remove_EventOnStageActorSwapAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattlePrepareStageActor, BattlePrepareStageActor> action = this.EventOnStageActorSwap;
				Action<BattlePrepareStageActor, BattlePrepareStageActor> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattlePrepareStageActor, BattlePrepareStageActor>>(ref this.EventOnStageActorSwap, (Action<BattlePrepareStageActor, BattlePrepareStageActor>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400020A RID: 522
		// (add) Token: 0x0600AD2F RID: 44335 RVA: 0x00305704 File Offset: 0x00303904
		// (remove) Token: 0x0600AD30 RID: 44336 RVA: 0x003057A0 File Offset: 0x003039A0
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

		// Token: 0x1400020B RID: 523
		// (add) Token: 0x0600AD31 RID: 44337 RVA: 0x0030583C File Offset: 0x00303A3C
		// (remove) Token: 0x0600AD32 RID: 44338 RVA: 0x003058D8 File Offset: 0x00303AD8
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

		// Token: 0x1400020C RID: 524
		// (add) Token: 0x0600AD33 RID: 44339 RVA: 0x00305974 File Offset: 0x00303B74
		// (remove) Token: 0x0600AD34 RID: 44340 RVA: 0x00305A10 File Offset: 0x00303C10
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

		// Token: 0x1400020D RID: 525
		// (add) Token: 0x0600AD35 RID: 44341 RVA: 0x00305AAC File Offset: 0x00303CAC
		// (remove) Token: 0x0600AD36 RID: 44342 RVA: 0x00305B48 File Offset: 0x00303D48
		public event Action EventOnBeginDragHero
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnBeginDragHeroAction_hotfix != null)
				{
					this.m_add_EventOnBeginDragHeroAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnBeginDragHero;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnBeginDragHero, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnBeginDragHeroAction_hotfix != null)
				{
					this.m_remove_EventOnBeginDragHeroAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnBeginDragHero;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnBeginDragHero, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400020E RID: 526
		// (add) Token: 0x0600AD37 RID: 44343 RVA: 0x00305BE4 File Offset: 0x00303DE4
		// (remove) Token: 0x0600AD38 RID: 44344 RVA: 0x00305C80 File Offset: 0x00303E80
		public event Action EventOnEndDragHero
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnEndDragHeroAction_hotfix != null)
				{
					this.m_add_EventOnEndDragHeroAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnEndDragHero;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnEndDragHero, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnEndDragHeroAction_hotfix != null)
				{
					this.m_remove_EventOnEndDragHeroAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnEndDragHero;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnEndDragHero, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002320 RID: 8992
		// (get) Token: 0x0600AD39 RID: 44345 RVA: 0x00305D1C File Offset: 0x00303F1C
		// (set) Token: 0x0600AD3A RID: 44346 RVA: 0x00305D3C File Offset: 0x00303F3C
		[DoNotToLua]
		public new BattlePrepareUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattlePrepareUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600AD3B RID: 44347 RVA: 0x00305D48 File Offset: 0x00303F48
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600AD3C RID: 44348 RVA: 0x00305D54 File Offset: 0x00303F54
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600AD3D RID: 44349 RVA: 0x00305D5C File Offset: 0x00303F5C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600AD3E RID: 44350 RVA: 0x00305D64 File Offset: 0x00303F64
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600AD3F RID: 44351 RVA: 0x00305D78 File Offset: 0x00303F78
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600AD40 RID: 44352 RVA: 0x00305D80 File Offset: 0x00303F80
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600AD41 RID: 44353 RVA: 0x00305D8C File Offset: 0x00303F8C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600AD42 RID: 44354 RVA: 0x00305D98 File Offset: 0x00303F98
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600AD43 RID: 44355 RVA: 0x00305DA4 File Offset: 0x00303FA4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600AD44 RID: 44356 RVA: 0x00305DB0 File Offset: 0x00303FB0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600AD45 RID: 44357 RVA: 0x00305DBC File Offset: 0x00303FBC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600AD46 RID: 44358 RVA: 0x00305DC8 File Offset: 0x00303FC8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600AD47 RID: 44359 RVA: 0x00305DD4 File Offset: 0x00303FD4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600AD48 RID: 44360 RVA: 0x00305DE0 File Offset: 0x00303FE0
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600AD49 RID: 44361 RVA: 0x00305DEC File Offset: 0x00303FEC
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600AD4A RID: 44362 RVA: 0x00305DF4 File Offset: 0x00303FF4
		private void __callDele_EventOnPauseBattle()
		{
			Action eventOnPauseBattle = this.EventOnPauseBattle;
			if (eventOnPauseBattle != null)
			{
				eventOnPauseBattle();
			}
		}

		// Token: 0x0600AD4B RID: 44363 RVA: 0x00305E14 File Offset: 0x00304014
		private void __clearDele_EventOnPauseBattle()
		{
			this.EventOnPauseBattle = null;
		}

		// Token: 0x0600AD4C RID: 44364 RVA: 0x00305E20 File Offset: 0x00304020
		private void __callDele_EventOnShowArmyRelation()
		{
			Action eventOnShowArmyRelation = this.EventOnShowArmyRelation;
			if (eventOnShowArmyRelation != null)
			{
				eventOnShowArmyRelation();
			}
		}

		// Token: 0x0600AD4D RID: 44365 RVA: 0x00305E40 File Offset: 0x00304040
		private void __clearDele_EventOnShowArmyRelation()
		{
			this.EventOnShowArmyRelation = null;
		}

		// Token: 0x0600AD4E RID: 44366 RVA: 0x00305E4C File Offset: 0x0030404C
		private void __callDele_EventOnStart()
		{
			Action eventOnStart = this.EventOnStart;
			if (eventOnStart != null)
			{
				eventOnStart();
			}
		}

		// Token: 0x0600AD4F RID: 44367 RVA: 0x00305E6C File Offset: 0x0030406C
		private void __clearDele_EventOnStart()
		{
			this.EventOnStart = null;
		}

		// Token: 0x0600AD50 RID: 44368 RVA: 0x00305E78 File Offset: 0x00304078
		private void __callDele_EventOnShowActionOrder()
		{
			Action eventOnShowActionOrder = this.EventOnShowActionOrder;
			if (eventOnShowActionOrder != null)
			{
				eventOnShowActionOrder();
			}
		}

		// Token: 0x0600AD51 RID: 44369 RVA: 0x00305E98 File Offset: 0x00304098
		private void __clearDele_EventOnShowActionOrder()
		{
			this.EventOnShowActionOrder = null;
		}

		// Token: 0x0600AD52 RID: 44370 RVA: 0x00305EA4 File Offset: 0x003040A4
		private void __callDele_EventOnTestOnStage()
		{
			Action eventOnTestOnStage = this.EventOnTestOnStage;
			if (eventOnTestOnStage != null)
			{
				eventOnTestOnStage();
			}
		}

		// Token: 0x0600AD53 RID: 44371 RVA: 0x00305EC4 File Offset: 0x003040C4
		private void __clearDele_EventOnTestOnStage()
		{
			this.EventOnTestOnStage = null;
		}

		// Token: 0x0600AD54 RID: 44372 RVA: 0x00305ED0 File Offset: 0x003040D0
		private void __callDele_EventOnShowMyActorInfo(BattleHero obj)
		{
			Action<BattleHero> eventOnShowMyActorInfo = this.EventOnShowMyActorInfo;
			if (eventOnShowMyActorInfo != null)
			{
				eventOnShowMyActorInfo(obj);
			}
		}

		// Token: 0x0600AD55 RID: 44373 RVA: 0x00305EF4 File Offset: 0x003040F4
		private void __clearDele_EventOnShowMyActorInfo(BattleHero obj)
		{
			this.EventOnShowMyActorInfo = null;
		}

		// Token: 0x0600AD56 RID: 44374 RVA: 0x00305F00 File Offset: 0x00304100
		private void __callDele_EventOnHideActorInfo()
		{
			Action eventOnHideActorInfo = this.EventOnHideActorInfo;
			if (eventOnHideActorInfo != null)
			{
				eventOnHideActorInfo();
			}
		}

		// Token: 0x0600AD57 RID: 44375 RVA: 0x00305F20 File Offset: 0x00304120
		private void __clearDele_EventOnHideActorInfo()
		{
			this.EventOnHideActorInfo = null;
		}

		// Token: 0x0600AD58 RID: 44376 RVA: 0x00305F2C File Offset: 0x0030412C
		private void __callDele_EventOnStageActorChange()
		{
			Action eventOnStageActorChange = this.EventOnStageActorChange;
			if (eventOnStageActorChange != null)
			{
				eventOnStageActorChange();
			}
		}

		// Token: 0x0600AD59 RID: 44377 RVA: 0x00305F4C File Offset: 0x0030414C
		private void __clearDele_EventOnStageActorChange()
		{
			this.EventOnStageActorChange = null;
		}

		// Token: 0x0600AD5A RID: 44378 RVA: 0x00305F58 File Offset: 0x00304158
		private void __callDele_EventOnShowChat()
		{
			Action eventOnShowChat = this.EventOnShowChat;
			if (eventOnShowChat != null)
			{
				eventOnShowChat();
			}
		}

		// Token: 0x0600AD5B RID: 44379 RVA: 0x00305F78 File Offset: 0x00304178
		private void __clearDele_EventOnShowChat()
		{
			this.EventOnShowChat = null;
		}

		// Token: 0x0600AD5C RID: 44380 RVA: 0x00305F84 File Offset: 0x00304184
		private void __callDele_EventOnShowHelp()
		{
			Action eventOnShowHelp = this.EventOnShowHelp;
			if (eventOnShowHelp != null)
			{
				eventOnShowHelp();
			}
		}

		// Token: 0x0600AD5D RID: 44381 RVA: 0x00305FA4 File Offset: 0x003041A4
		private void __clearDele_EventOnShowHelp()
		{
			this.EventOnShowHelp = null;
		}

		// Token: 0x0600AD5E RID: 44382 RVA: 0x00305FB0 File Offset: 0x003041B0
		private void __callDele_EventOnHeroOnStage(BattleHero arg1, GridPosition arg2, int arg3)
		{
			Action<BattleHero, GridPosition, int> eventOnHeroOnStage = this.EventOnHeroOnStage;
			if (eventOnHeroOnStage != null)
			{
				eventOnHeroOnStage(arg1, arg2, arg3);
			}
		}

		// Token: 0x0600AD5F RID: 44383 RVA: 0x00305FD4 File Offset: 0x003041D4
		private void __clearDele_EventOnHeroOnStage(BattleHero arg1, GridPosition arg2, int arg3)
		{
			this.EventOnHeroOnStage = null;
		}

		// Token: 0x0600AD60 RID: 44384 RVA: 0x00305FE0 File Offset: 0x003041E0
		private void __callDele_EventOnActorOffStage(BattlePrepareStageActor obj)
		{
			Action<BattlePrepareStageActor> eventOnActorOffStage = this.EventOnActorOffStage;
			if (eventOnActorOffStage != null)
			{
				eventOnActorOffStage(obj);
			}
		}

		// Token: 0x0600AD61 RID: 44385 RVA: 0x00306004 File Offset: 0x00304204
		private void __clearDele_EventOnActorOffStage(BattlePrepareStageActor obj)
		{
			this.EventOnActorOffStage = null;
		}

		// Token: 0x0600AD62 RID: 44386 RVA: 0x00306010 File Offset: 0x00304210
		private void __callDele_EventOnStageActorMove(BattlePrepareStageActor arg1, GridPosition arg2)
		{
			Action<BattlePrepareStageActor, GridPosition> eventOnStageActorMove = this.EventOnStageActorMove;
			if (eventOnStageActorMove != null)
			{
				eventOnStageActorMove(arg1, arg2);
			}
		}

		// Token: 0x0600AD63 RID: 44387 RVA: 0x00306034 File Offset: 0x00304234
		private void __clearDele_EventOnStageActorMove(BattlePrepareStageActor arg1, GridPosition arg2)
		{
			this.EventOnStageActorMove = null;
		}

		// Token: 0x0600AD64 RID: 44388 RVA: 0x00306040 File Offset: 0x00304240
		private void __callDele_EventOnStageActorSwap(BattlePrepareStageActor arg1, BattlePrepareStageActor arg2)
		{
			Action<BattlePrepareStageActor, BattlePrepareStageActor> eventOnStageActorSwap = this.EventOnStageActorSwap;
			if (eventOnStageActorSwap != null)
			{
				eventOnStageActorSwap(arg1, arg2);
			}
		}

		// Token: 0x0600AD65 RID: 44389 RVA: 0x00306064 File Offset: 0x00304264
		private void __clearDele_EventOnStageActorSwap(BattlePrepareStageActor arg1, BattlePrepareStageActor arg2)
		{
			this.EventOnStageActorSwap = null;
		}

		// Token: 0x0600AD66 RID: 44390 RVA: 0x00306070 File Offset: 0x00304270
		private void __callDele_EventOnPointerDown(PointerEventData.InputButton arg1, Vector2 arg2)
		{
			Action<PointerEventData.InputButton, Vector2> eventOnPointerDown = this.EventOnPointerDown;
			if (eventOnPointerDown != null)
			{
				eventOnPointerDown(arg1, arg2);
			}
		}

		// Token: 0x0600AD67 RID: 44391 RVA: 0x00306094 File Offset: 0x00304294
		private void __clearDele_EventOnPointerDown(PointerEventData.InputButton arg1, Vector2 arg2)
		{
			this.EventOnPointerDown = null;
		}

		// Token: 0x0600AD68 RID: 44392 RVA: 0x003060A0 File Offset: 0x003042A0
		private void __callDele_EventOnPointerUp(PointerEventData.InputButton arg1, Vector2 arg2)
		{
			Action<PointerEventData.InputButton, Vector2> eventOnPointerUp = this.EventOnPointerUp;
			if (eventOnPointerUp != null)
			{
				eventOnPointerUp(arg1, arg2);
			}
		}

		// Token: 0x0600AD69 RID: 44393 RVA: 0x003060C4 File Offset: 0x003042C4
		private void __clearDele_EventOnPointerUp(PointerEventData.InputButton arg1, Vector2 arg2)
		{
			this.EventOnPointerUp = null;
		}

		// Token: 0x0600AD6A RID: 44394 RVA: 0x003060D0 File Offset: 0x003042D0
		private void __callDele_EventOnPointerClick(PointerEventData.InputButton arg1, Vector2 arg2)
		{
			Action<PointerEventData.InputButton, Vector2> eventOnPointerClick = this.EventOnPointerClick;
			if (eventOnPointerClick != null)
			{
				eventOnPointerClick(arg1, arg2);
			}
		}

		// Token: 0x0600AD6B RID: 44395 RVA: 0x003060F4 File Offset: 0x003042F4
		private void __clearDele_EventOnPointerClick(PointerEventData.InputButton arg1, Vector2 arg2)
		{
			this.EventOnPointerClick = null;
		}

		// Token: 0x0600AD6C RID: 44396 RVA: 0x00306100 File Offset: 0x00304300
		private void __callDele_EventOnBeginDragHero()
		{
			Action eventOnBeginDragHero = this.EventOnBeginDragHero;
			if (eventOnBeginDragHero != null)
			{
				eventOnBeginDragHero();
			}
		}

		// Token: 0x0600AD6D RID: 44397 RVA: 0x00306120 File Offset: 0x00304320
		private void __clearDele_EventOnBeginDragHero()
		{
			this.EventOnBeginDragHero = null;
		}

		// Token: 0x0600AD6E RID: 44398 RVA: 0x0030612C File Offset: 0x0030432C
		private void __callDele_EventOnEndDragHero()
		{
			Action eventOnEndDragHero = this.EventOnEndDragHero;
			if (eventOnEndDragHero != null)
			{
				eventOnEndDragHero();
			}
		}

		// Token: 0x0600AD6F RID: 44399 RVA: 0x0030614C File Offset: 0x0030434C
		private void __clearDele_EventOnEndDragHero()
		{
			this.EventOnEndDragHero = null;
		}

		// Token: 0x0600AD71 RID: 44401 RVA: 0x00306168 File Offset: 0x00304368
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
					this.m_InitializeClientBattle_hotfix = (luaObj.RawGet("Initialize") as LuaFunction);
					this.m_OnDisable_hotfix = (luaObj.RawGet("OnDisable") as LuaFunction);
					this.m_OnApplicationPauseBoolean_hotfix = (luaObj.RawGet("OnApplicationPause") as LuaFunction);
					this.m_OnApplicationFocusBoolean_hotfix = (luaObj.RawGet("OnApplicationFocus") as LuaFunction);
					this.m_CancelDragging_hotfix = (luaObj.RawGet("CancelDragging") as LuaFunction);
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_CheckStageActorChange_hotfix = (luaObj.RawGet("CheckStageActorChange") as LuaFunction);
					this.m_PrepareBattle_hotfix = (luaObj.RawGet("PrepareBattle") as LuaFunction);
					this.m_PauseBoolean_hotfix = (luaObj.RawGet("Pause") as LuaFunction);
					this.m_SetStageActorCountMaxInt32_hotfix = (luaObj.RawGet("SetStageActorCountMax") as LuaFunction);
					this.m_SetTurnStageActorCountMaxInt32_hotfix = (luaObj.RawGet("SetTurnStageActorCountMax") as LuaFunction);
					this.m_ClearHeros_hotfix = (luaObj.RawGet("ClearHeros") as LuaFunction);
					this.m_AddHeroBattleHeroStageActorTagType_hotfix = (luaObj.RawGet("AddHero") as LuaFunction);
					this.m_ClearStagePositions_hotfix = (luaObj.RawGet("ClearStagePositions") as LuaFunction);
					this.m_AddStagePositionGridPositionInt32StagePositionType_hotfix = (luaObj.RawGet("AddStagePosition") as LuaFunction);
					this.m_GetStagePositionsStagePositionType_hotfix = (luaObj.RawGet("GetStagePositions") as LuaFunction);
					this.m_GetStageDirectionGridPositionStagePositionType_hotfix = (luaObj.RawGet("GetStageDirection") as LuaFunction);
					this.m_CreateHeroButtonBattleHeroTransform_hotfix = (luaObj.RawGet("CreateHeroButton") as LuaFunction);
					this.m_SkipStageActorGraphicBoolean_hotfix = (luaObj.RawGet("SkipStageActorGraphic") as LuaFunction);
					this.m_EnableHeroOnStageBoolean_hotfix = (luaObj.RawGet("EnableHeroOnStage") as LuaFunction);
					this.m_HeroOnStageBattleHeroGridPositionInt32Int32StagePositionTypeStageActorTagTypeInt32Int32Int32_hotfix = (luaObj.RawGet("HeroOnStage") as LuaFunction);
					this.m_HeroOnStageBattleHeroGridPositionInt32StagePositionTypeInt32StageActorTagType_hotfix = (luaObj.RawGet("HeroOnStage") as LuaFunction);
					this.m_ActorOffStageBattlePrepareStageActor_hotfix = (luaObj.RawGet("ActorOffStage") as LuaFunction);
					this.m_ActorOnStageMoveBattlePrepareStageActorGridPosition_hotfix = (luaObj.RawGet("ActorOnStageMove") as LuaFunction);
					this.m_ActorOnStageExchangeBattlePrepareStageActorBattlePrepareStageActor_hotfix = (luaObj.RawGet("ActorOnStageExchange") as LuaFunction);
					this.m_SortChildByYTransform_hotfix = (luaObj.RawGet("SortChildByY") as LuaFunction);
					this.m_ClearStageActors_hotfix = (luaObj.RawGet("ClearStageActors") as LuaFunction);
					this.m_GetStageActorGridPosition_hotfix = (luaObj.RawGet("GetStageActor") as LuaFunction);
					this.m_GetStageActorByHeroIdInt32_hotfix = (luaObj.RawGet("GetStageActorByHeroId") as LuaFunction);
					this.m_GetStageActors_hotfix = (luaObj.RawGet("GetStageActors") as LuaFunction);
					this.m_UpdateStageActorBattleHero_hotfix = (luaObj.RawGet("UpdateStageActor") as LuaFunction);
					this.m_AddBattleTreasureConfigDataBattleTreasureInfoBoolean_hotfix = (luaObj.RawGet("AddBattleTreasure") as LuaFunction);
					this.m_ClearBattleTreasures_hotfix = (luaObj.RawGet("ClearBattleTreasures") as LuaFunction);
					this.m_ShowTerrainInfoConfigDataTerrainInfo_hotfix = (luaObj.RawGet("ShowTerrainInfo") as LuaFunction);
					this.m_HideTerrainInfo_hotfix = (luaObj.RawGet("HideTerrainInfo") as LuaFunction);
					this.m_ShowArmyRelationDesc_hotfix = (luaObj.RawGet("ShowArmyRelationDesc") as LuaFunction);
					this.m_HideArmyRelationDesc_hotfix = (luaObj.RawGet("HideArmyRelationDesc") as LuaFunction);
					this.m_IsArmyRelationDescVisible_hotfix = (luaObj.RawGet("IsArmyRelationDescVisible") as LuaFunction);
					this.m_ShowClimbTowerBattleRuleConfigDataTowerBattleRuleInfo_hotfix = (luaObj.RawGet("ShowClimbTowerBattleRule") as LuaFunction);
					this.m_HideClimbTowerBattleRule_hotfix = (luaObj.RawGet("HideClimbTowerBattleRule") as LuaFunction);
					this.m_ShowActionOrderButtonBoolean_hotfix = (luaObj.RawGet("ShowActionOrderButton") as LuaFunction);
					this.m_ShowChatButtonBoolean_hotfix = (luaObj.RawGet("ShowChatButton") as LuaFunction);
					this.m_SetBattlePowerInt32_hotfix = (luaObj.RawGet("SetBattlePower") as LuaFunction);
					this.m_ClearBattlePowerValue_hotfix = (luaObj.RawGet("ClearBattlePowerValue") as LuaFunction);
					this.m_Co_SetBattlePowerValueInt32Int32_hotfix = (luaObj.RawGet("Co_SetBattlePowerValue") as LuaFunction);
					this.m_UpdateTestValuesToInputField_hotfix = (luaObj.RawGet("UpdateTestValuesToInputField") as LuaFunction);
					this.m_UpdateTestValuesFromInputField_hotfix = (luaObj.RawGet("UpdateTestValuesFromInputField") as LuaFunction);
					this.m_ShowStartButtonBoolean_hotfix = (luaObj.RawGet("ShowStartButton") as LuaFunction);
					this.m_ShowTeamReadyCountdownTimeSpan_hotfix = (luaObj.RawGet("ShowTeamReadyCountdown") as LuaFunction);
					this.m_HideTeamReadyCountdown_hotfix = (luaObj.RawGet("HideTeamReadyCountdown") as LuaFunction);
					this.m_ShowTeamReadyWaitBattleRoomType_hotfix = (luaObj.RawGet("ShowTeamReadyWait") as LuaFunction);
					this.m_HideTeamReadyWait_hotfix = (luaObj.RawGet("HideTeamReadyWait") as LuaFunction);
					this.m_OnPauseButtonClick_hotfix = (luaObj.RawGet("OnPauseButtonClick") as LuaFunction);
					this.m_OnArmyRelationButtonClick_hotfix = (luaObj.RawGet("OnArmyRelationButtonClick") as LuaFunction);
					this.m_OnStartButtonClick_hotfix = (luaObj.RawGet("OnStartButtonClick") as LuaFunction);
					this.m_OnActionOrderButtonClick_hotfix = (luaObj.RawGet("OnActionOrderButtonClick") as LuaFunction);
					this.m_OnChatButtonClick_hotfix = (luaObj.RawGet("OnChatButtonClick") as LuaFunction);
					this.m_OnHelpButtonClick_hotfix = (luaObj.RawGet("OnHelpButtonClick") as LuaFunction);
					this.m_IsTestBattle_hotfix = (luaObj.RawGet("IsTestBattle") as LuaFunction);
					this.m_OnTestOnStageToggleBoolean_hotfix = (luaObj.RawGet("OnTestOnStageToggle") as LuaFunction);
					this.m_IsTestOnStage_hotfix = (luaObj.RawGet("IsTestOnStage") as LuaFunction);
					this.m_GetTestSoldierCountInt32_hotfix = (luaObj.RawGet("GetTestSoldierCount") as LuaFunction);
					this.m_GetTestSkillIdInt32_hotfix = (luaObj.RawGet("GetTestSkillId") as LuaFunction);
					this.m_GetTestTalentIdInt32_hotfix = (luaObj.RawGet("GetTestTalentId") as LuaFunction);
					this.m_ClearPointerDownStageActor_hotfix = (luaObj.RawGet("ClearPointerDownStageActor") as LuaFunction);
					this.m_OnScenePointerDownPointerEventData_hotfix = (luaObj.RawGet("OnScenePointerDown") as LuaFunction);
					this.m_OnScenePointerUpPointerEventData_hotfix = (luaObj.RawGet("OnScenePointerUp") as LuaFunction);
					this.m_OnScenePointerClickPointerEventData_hotfix = (luaObj.RawGet("OnScenePointerClick") as LuaFunction);
					this.m_OnSceneBeginDragPointerEventData_hotfix = (luaObj.RawGet("OnSceneBeginDrag") as LuaFunction);
					this.m_OnSceneEndDragPointerEventData_hotfix = (luaObj.RawGet("OnSceneEndDrag") as LuaFunction);
					this.m_OnSceneDragPointerEventData_hotfix = (luaObj.RawGet("OnSceneDrag") as LuaFunction);
					this.m_OnScene3DTouchVector2_hotfix = (luaObj.RawGet("OnScene3DTouch") as LuaFunction);
					this.m_CreateDraggingHeroButtonBattleHero_hotfix = (luaObj.RawGet("CreateDraggingHeroButton") as LuaFunction);
					this.m_DestroyDragginHeroButton_hotfix = (luaObj.RawGet("DestroyDragginHeroButton") as LuaFunction);
					this.m_MoveDraggingHeroButtonVector2_hotfix = (luaObj.RawGet("MoveDraggingHeroButton") as LuaFunction);
					this.m_DropHeroButtonVector2_hotfix = (luaObj.RawGet("DropHeroButton") as LuaFunction);
					this.m_ComputeStageActorCount_hotfix = (luaObj.RawGet("ComputeStageActorCount") as LuaFunction);
					this.m_UpdateStageActorCount_hotfix = (luaObj.RawGet("UpdateStageActorCount") as LuaFunction);
					this.m_HeroDragButton_OnBeginDragHeroDragButtonPointerEventData_hotfix = (luaObj.RawGet("HeroDragButton_OnBeginDrag") as LuaFunction);
					this.m_HeroDragButton_OnEndDragHeroDragButtonPointerEventData_hotfix = (luaObj.RawGet("HeroDragButton_OnEndDrag") as LuaFunction);
					this.m_HeroDragButton_OnDragPointerEventData_hotfix = (luaObj.RawGet("HeroDragButton_OnDrag") as LuaFunction);
					this.m_HeroDragButton_OnDropPointerEventData_hotfix = (luaObj.RawGet("HeroDragButton_OnDrop") as LuaFunction);
					this.m_HeroDragButton_OnClickHeroDragButton_hotfix = (luaObj.RawGet("HeroDragButton_OnClick") as LuaFunction);
					this.m_RefreshChatRedState_hotfix = (luaObj.RawGet("RefreshChatRedState") as LuaFunction);
					this.m_HideActorInfo_hotfix = (luaObj.RawGet("HideActorInfo") as LuaFunction);
					this.m_add_EventOnPauseBattleAction_hotfix = (luaObj.RawGet("add_EventOnPauseBattle") as LuaFunction);
					this.m_remove_EventOnPauseBattleAction_hotfix = (luaObj.RawGet("remove_EventOnPauseBattle") as LuaFunction);
					this.m_add_EventOnShowArmyRelationAction_hotfix = (luaObj.RawGet("add_EventOnShowArmyRelation") as LuaFunction);
					this.m_remove_EventOnShowArmyRelationAction_hotfix = (luaObj.RawGet("remove_EventOnShowArmyRelation") as LuaFunction);
					this.m_add_EventOnStartAction_hotfix = (luaObj.RawGet("add_EventOnStart") as LuaFunction);
					this.m_remove_EventOnStartAction_hotfix = (luaObj.RawGet("remove_EventOnStart") as LuaFunction);
					this.m_add_EventOnShowActionOrderAction_hotfix = (luaObj.RawGet("add_EventOnShowActionOrder") as LuaFunction);
					this.m_remove_EventOnShowActionOrderAction_hotfix = (luaObj.RawGet("remove_EventOnShowActionOrder") as LuaFunction);
					this.m_add_EventOnTestOnStageAction_hotfix = (luaObj.RawGet("add_EventOnTestOnStage") as LuaFunction);
					this.m_remove_EventOnTestOnStageAction_hotfix = (luaObj.RawGet("remove_EventOnTestOnStage") as LuaFunction);
					this.m_add_EventOnShowMyActorInfoAction`1_hotfix = (luaObj.RawGet("add_EventOnShowMyActorInfo") as LuaFunction);
					this.m_remove_EventOnShowMyActorInfoAction`1_hotfix = (luaObj.RawGet("remove_EventOnShowMyActorInfo") as LuaFunction);
					this.m_add_EventOnHideActorInfoAction_hotfix = (luaObj.RawGet("add_EventOnHideActorInfo") as LuaFunction);
					this.m_remove_EventOnHideActorInfoAction_hotfix = (luaObj.RawGet("remove_EventOnHideActorInfo") as LuaFunction);
					this.m_add_EventOnStageActorChangeAction_hotfix = (luaObj.RawGet("add_EventOnStageActorChange") as LuaFunction);
					this.m_remove_EventOnStageActorChangeAction_hotfix = (luaObj.RawGet("remove_EventOnStageActorChange") as LuaFunction);
					this.m_add_EventOnShowChatAction_hotfix = (luaObj.RawGet("add_EventOnShowChat") as LuaFunction);
					this.m_remove_EventOnShowChatAction_hotfix = (luaObj.RawGet("remove_EventOnShowChat") as LuaFunction);
					this.m_add_EventOnShowHelpAction_hotfix = (luaObj.RawGet("add_EventOnShowHelp") as LuaFunction);
					this.m_remove_EventOnShowHelpAction_hotfix = (luaObj.RawGet("remove_EventOnShowHelp") as LuaFunction);
					this.m_add_EventOnHeroOnStageAction`3_hotfix = (luaObj.RawGet("add_EventOnHeroOnStage") as LuaFunction);
					this.m_remove_EventOnHeroOnStageAction`3_hotfix = (luaObj.RawGet("remove_EventOnHeroOnStage") as LuaFunction);
					this.m_add_EventOnActorOffStageAction`1_hotfix = (luaObj.RawGet("add_EventOnActorOffStage") as LuaFunction);
					this.m_remove_EventOnActorOffStageAction`1_hotfix = (luaObj.RawGet("remove_EventOnActorOffStage") as LuaFunction);
					this.m_add_EventOnStageActorMoveAction`2_hotfix = (luaObj.RawGet("add_EventOnStageActorMove") as LuaFunction);
					this.m_remove_EventOnStageActorMoveAction`2_hotfix = (luaObj.RawGet("remove_EventOnStageActorMove") as LuaFunction);
					this.m_add_EventOnStageActorSwapAction`2_hotfix = (luaObj.RawGet("add_EventOnStageActorSwap") as LuaFunction);
					this.m_remove_EventOnStageActorSwapAction`2_hotfix = (luaObj.RawGet("remove_EventOnStageActorSwap") as LuaFunction);
					this.m_add_EventOnPointerDownAction`2_hotfix = (luaObj.RawGet("add_EventOnPointerDown") as LuaFunction);
					this.m_remove_EventOnPointerDownAction`2_hotfix = (luaObj.RawGet("remove_EventOnPointerDown") as LuaFunction);
					this.m_add_EventOnPointerUpAction`2_hotfix = (luaObj.RawGet("add_EventOnPointerUp") as LuaFunction);
					this.m_remove_EventOnPointerUpAction`2_hotfix = (luaObj.RawGet("remove_EventOnPointerUp") as LuaFunction);
					this.m_add_EventOnPointerClickAction`2_hotfix = (luaObj.RawGet("add_EventOnPointerClick") as LuaFunction);
					this.m_remove_EventOnPointerClickAction`2_hotfix = (luaObj.RawGet("remove_EventOnPointerClick") as LuaFunction);
					this.m_add_EventOnBeginDragHeroAction_hotfix = (luaObj.RawGet("add_EventOnBeginDragHero") as LuaFunction);
					this.m_remove_EventOnBeginDragHeroAction_hotfix = (luaObj.RawGet("remove_EventOnBeginDragHero") as LuaFunction);
					this.m_add_EventOnEndDragHeroAction_hotfix = (luaObj.RawGet("add_EventOnEndDragHero") as LuaFunction);
					this.m_remove_EventOnEndDragHeroAction_hotfix = (luaObj.RawGet("remove_EventOnEndDragHero") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600AD72 RID: 44402 RVA: 0x00306E38 File Offset: 0x00305038
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattlePrepareUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007133 RID: 28979
		[AutoBind("./Margin", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_marginTransform;

		// Token: 0x04007134 RID: 28980
		[AutoBind("./Margin/Title/PauseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_pauseButton;

		// Token: 0x04007135 RID: 28981
		[AutoBind("./Margin/Title/ActorCount/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_stageActorCountText;

		// Token: 0x04007136 RID: 28982
		[AutoBind("./Margin/Title/BattlePower", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_battlePowerUIStateController;

		// Token: 0x04007137 RID: 28983
		[AutoBind("./Margin/Title/BattlePower/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_battlePowerText;

		// Token: 0x04007138 RID: 28984
		[AutoBind("./Margin/Title/BattlePower/Arrow", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_battlePowerArrowGo;

		// Token: 0x04007139 RID: 28985
		[AutoBind("./Margin/ClimbTowerRulePanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_climbTowerRuleUIStateController;

		// Token: 0x0400713A RID: 28986
		[AutoBind("./Margin/ClimbTowerRulePanel/Desc/ConditionText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_climbTowerRuleText;

		// Token: 0x0400713B RID: 28987
		[AutoBind("./Margin/ChatButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_chatButton;

		// Token: 0x0400713C RID: 28988
		[AutoBind("./Margin/ChatButton/CountPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_chatRedPoint;

		// Token: 0x0400713D RID: 28989
		[AutoBind("./Margin/ActionOrderButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_actionOrderButton;

		// Token: 0x0400713E RID: 28990
		[AutoBind("./StartButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_startButton;

		// Token: 0x0400713F RID: 28991
		[AutoBind("./TeamReady", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_teamReadyGameObject;

		// Token: 0x04007140 RID: 28992
		[AutoBind("./TeamReady/Time", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_teamReadyTimeUIStateController;

		// Token: 0x04007141 RID: 28993
		[AutoBind("./TeamReady/Time/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_teamReadyTimeText;

		// Token: 0x04007142 RID: 28994
		[AutoBind("./TeamReady/Wait", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_teamReadyWaitGameObject;

		// Token: 0x04007143 RID: 28995
		[AutoBind("./TeamReady/Wait/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_teamReadyWaitTeammateText;

		// Token: 0x04007144 RID: 28996
		[AutoBind("./TeamReady/Wait/Text2", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_teamReadyWaitOpponentText;

		// Token: 0x04007145 RID: 28997
		[AutoBind("./Test", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_testGameObject;

		// Token: 0x04007146 RID: 28998
		[AutoBind("./Test/TestOnStageToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_testOnStageToggle;

		// Token: 0x04007147 RID: 28999
		[AutoBind("./Test/SoldierInputField0", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_testSoldierInputField0;

		// Token: 0x04007148 RID: 29000
		[AutoBind("./Test/SoldierInputField1", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_testSoldierInputField1;

		// Token: 0x04007149 RID: 29001
		[AutoBind("./Test/SkillInputField0", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_testSkillInputField0;

		// Token: 0x0400714A RID: 29002
		[AutoBind("./Test/SkillInputField1", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_testSkillInputField1;

		// Token: 0x0400714B RID: 29003
		[AutoBind("./Test/TalentInputField0", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_testTalentInputField0;

		// Token: 0x0400714C RID: 29004
		[AutoBind("./Test/TalentInputField1", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_testTalentInputField1;

		// Token: 0x0400714D RID: 29005
		[AutoBind("./ActorList/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_actorListScrollRect;

		// Token: 0x0400714E RID: 29006
		[AutoBind("./ActorList/Disable", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_actorListDisableGameObject;

		// Token: 0x0400714F RID: 29007
		[AutoBind("./TerrainInfo", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_terrainInfoGameObject;

		// Token: 0x04007150 RID: 29008
		[AutoBind("./TerrainInfo/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_terrainInfoText;

		// Token: 0x04007151 RID: 29009
		[AutoBind("./TerrainInfo/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_terrainInfoImage;

		// Token: 0x04007152 RID: 29010
		[AutoBind("./TerrainInfo/Def/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_terrainInfoDefText;

		// Token: 0x04007153 RID: 29011
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_prefabsGameObject;

		// Token: 0x04007154 RID: 29012
		[AutoBind("./Prefabs/HeroButton", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroButtonPrefab;

		// Token: 0x04007155 RID: 29013
		private CommonUIStateController m_armyRelationButtonUIStateController;

		// Token: 0x04007156 RID: 29014
		private CommonUIStateController m_armyRelationDescUIStateController;

		// Token: 0x04007157 RID: 29015
		private ClientBattle m_clientBattle;

		// Token: 0x04007158 RID: 29016
		private Camera m_camera;

		// Token: 0x04007159 RID: 29017
		private float m_chatRedPointLastTime;

		// Token: 0x0400715A RID: 29018
		private bool m_isIgnorePointerClick;

		// Token: 0x0400715B RID: 29019
		private BattlePrepareStageActor m_pointerDownStageActor;

		// Token: 0x0400715C RID: 29020
		private bool m_isIgnoreToggleEvent;

		// Token: 0x0400715D RID: 29021
		private bool m_isSkipStageActorGraphic;

		// Token: 0x0400715E RID: 29022
		private int m_stageActorCountMax;

		// Token: 0x0400715F RID: 29023
		private int m_turnStageActorCountMax;

		// Token: 0x04007160 RID: 29024
		private bool m_isStageActorChanged;

		// Token: 0x04007161 RID: 29025
		private List<HeroDragButton> m_heroButtons = new List<HeroDragButton>();

		// Token: 0x04007162 RID: 29026
		private List<BattlePrepareStageActor> m_stageActors = new List<BattlePrepareStageActor>();

		// Token: 0x04007163 RID: 29027
		private List<BattlePrepareTreasure> m_treasures = new List<BattlePrepareTreasure>();

		// Token: 0x04007164 RID: 29028
		private List<GridPosition>[] m_stagePositions;

		// Token: 0x04007165 RID: 29029
		private List<int>[] m_stageDirs;

		// Token: 0x04007166 RID: 29030
		private HeroDragButton m_draggingHeroButton;

		// Token: 0x04007167 RID: 29031
		private static int s_testSoldierCount0 = 10;

		// Token: 0x04007168 RID: 29032
		private static int s_testSoldierCount1 = 10;

		// Token: 0x04007169 RID: 29033
		private static int s_testSkillId0;

		// Token: 0x0400716A RID: 29034
		private static int s_testSkillId1;

		// Token: 0x0400716B RID: 29035
		private static int s_testTalentId0;

		// Token: 0x0400716C RID: 29036
		private static int s_testTalentId1;

		// Token: 0x0400716D RID: 29037
		private static bool s_isTestOnStage;

		// Token: 0x0400716E RID: 29038
		private int m_battlePowerValue;

		// Token: 0x0400716F RID: 29039
		private Coroutine m_setBattlePowerValueCoroutine;

		// Token: 0x04007170 RID: 29040
		private ConfigDataTowerBattleRuleInfo m_towerBattleRuleInfo;

		// Token: 0x04007171 RID: 29041
		[DoNotToLua]
		private BattlePrepareUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04007172 RID: 29042
		[CompilerGenerated]
		private static Comparison<Transform> <>f__mg$cache0;

		// Token: 0x04007173 RID: 29043
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007174 RID: 29044
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007175 RID: 29045
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04007176 RID: 29046
		private LuaFunction m_InitializeClientBattle_hotfix;

		// Token: 0x04007177 RID: 29047
		private LuaFunction m_OnDisable_hotfix;

		// Token: 0x04007178 RID: 29048
		private LuaFunction m_OnApplicationPauseBoolean_hotfix;

		// Token: 0x04007179 RID: 29049
		private LuaFunction m_OnApplicationFocusBoolean_hotfix;

		// Token: 0x0400717A RID: 29050
		private LuaFunction m_CancelDragging_hotfix;

		// Token: 0x0400717B RID: 29051
		private LuaFunction m_Update_hotfix;

		// Token: 0x0400717C RID: 29052
		private LuaFunction m_CheckStageActorChange_hotfix;

		// Token: 0x0400717D RID: 29053
		private LuaFunction m_PrepareBattle_hotfix;

		// Token: 0x0400717E RID: 29054
		private LuaFunction m_PauseBoolean_hotfix;

		// Token: 0x0400717F RID: 29055
		private LuaFunction m_SetStageActorCountMaxInt32_hotfix;

		// Token: 0x04007180 RID: 29056
		private LuaFunction m_SetTurnStageActorCountMaxInt32_hotfix;

		// Token: 0x04007181 RID: 29057
		private LuaFunction m_ClearHeros_hotfix;

		// Token: 0x04007182 RID: 29058
		private LuaFunction m_AddHeroBattleHeroStageActorTagType_hotfix;

		// Token: 0x04007183 RID: 29059
		private LuaFunction m_ClearStagePositions_hotfix;

		// Token: 0x04007184 RID: 29060
		private LuaFunction m_AddStagePositionGridPositionInt32StagePositionType_hotfix;

		// Token: 0x04007185 RID: 29061
		private LuaFunction m_GetStagePositionsStagePositionType_hotfix;

		// Token: 0x04007186 RID: 29062
		private LuaFunction m_GetStageDirectionGridPositionStagePositionType_hotfix;

		// Token: 0x04007187 RID: 29063
		private LuaFunction m_CreateHeroButtonBattleHeroTransform_hotfix;

		// Token: 0x04007188 RID: 29064
		private LuaFunction m_SkipStageActorGraphicBoolean_hotfix;

		// Token: 0x04007189 RID: 29065
		private LuaFunction m_EnableHeroOnStageBoolean_hotfix;

		// Token: 0x0400718A RID: 29066
		private LuaFunction m_HeroOnStageBattleHeroGridPositionInt32Int32StagePositionTypeStageActorTagTypeInt32Int32Int32_hotfix;

		// Token: 0x0400718B RID: 29067
		private LuaFunction m_HeroOnStageBattleHeroGridPositionInt32StagePositionTypeInt32StageActorTagType_hotfix;

		// Token: 0x0400718C RID: 29068
		private LuaFunction m_ActorOffStageBattlePrepareStageActor_hotfix;

		// Token: 0x0400718D RID: 29069
		private LuaFunction m_ActorOnStageMoveBattlePrepareStageActorGridPosition_hotfix;

		// Token: 0x0400718E RID: 29070
		private LuaFunction m_ActorOnStageExchangeBattlePrepareStageActorBattlePrepareStageActor_hotfix;

		// Token: 0x0400718F RID: 29071
		private LuaFunction m_SortChildByYTransform_hotfix;

		// Token: 0x04007190 RID: 29072
		private LuaFunction m_ClearStageActors_hotfix;

		// Token: 0x04007191 RID: 29073
		private LuaFunction m_GetStageActorGridPosition_hotfix;

		// Token: 0x04007192 RID: 29074
		private LuaFunction m_GetStageActorByHeroIdInt32_hotfix;

		// Token: 0x04007193 RID: 29075
		private LuaFunction m_GetStageActors_hotfix;

		// Token: 0x04007194 RID: 29076
		private LuaFunction m_UpdateStageActorBattleHero_hotfix;

		// Token: 0x04007195 RID: 29077
		private LuaFunction m_AddBattleTreasureConfigDataBattleTreasureInfoBoolean_hotfix;

		// Token: 0x04007196 RID: 29078
		private LuaFunction m_ClearBattleTreasures_hotfix;

		// Token: 0x04007197 RID: 29079
		private LuaFunction m_ShowTerrainInfoConfigDataTerrainInfo_hotfix;

		// Token: 0x04007198 RID: 29080
		private LuaFunction m_HideTerrainInfo_hotfix;

		// Token: 0x04007199 RID: 29081
		private LuaFunction m_ShowArmyRelationDesc_hotfix;

		// Token: 0x0400719A RID: 29082
		private LuaFunction m_HideArmyRelationDesc_hotfix;

		// Token: 0x0400719B RID: 29083
		private LuaFunction m_IsArmyRelationDescVisible_hotfix;

		// Token: 0x0400719C RID: 29084
		private LuaFunction m_ShowClimbTowerBattleRuleConfigDataTowerBattleRuleInfo_hotfix;

		// Token: 0x0400719D RID: 29085
		private LuaFunction m_HideClimbTowerBattleRule_hotfix;

		// Token: 0x0400719E RID: 29086
		private LuaFunction m_ShowActionOrderButtonBoolean_hotfix;

		// Token: 0x0400719F RID: 29087
		private LuaFunction m_ShowChatButtonBoolean_hotfix;

		// Token: 0x040071A0 RID: 29088
		private LuaFunction m_SetBattlePowerInt32_hotfix;

		// Token: 0x040071A1 RID: 29089
		private LuaFunction m_ClearBattlePowerValue_hotfix;

		// Token: 0x040071A2 RID: 29090
		private LuaFunction m_Co_SetBattlePowerValueInt32Int32_hotfix;

		// Token: 0x040071A3 RID: 29091
		private LuaFunction m_UpdateTestValuesToInputField_hotfix;

		// Token: 0x040071A4 RID: 29092
		private LuaFunction m_UpdateTestValuesFromInputField_hotfix;

		// Token: 0x040071A5 RID: 29093
		private LuaFunction m_ShowStartButtonBoolean_hotfix;

		// Token: 0x040071A6 RID: 29094
		private LuaFunction m_ShowTeamReadyCountdownTimeSpan_hotfix;

		// Token: 0x040071A7 RID: 29095
		private LuaFunction m_HideTeamReadyCountdown_hotfix;

		// Token: 0x040071A8 RID: 29096
		private LuaFunction m_ShowTeamReadyWaitBattleRoomType_hotfix;

		// Token: 0x040071A9 RID: 29097
		private LuaFunction m_HideTeamReadyWait_hotfix;

		// Token: 0x040071AA RID: 29098
		private LuaFunction m_OnPauseButtonClick_hotfix;

		// Token: 0x040071AB RID: 29099
		private LuaFunction m_OnArmyRelationButtonClick_hotfix;

		// Token: 0x040071AC RID: 29100
		private LuaFunction m_OnStartButtonClick_hotfix;

		// Token: 0x040071AD RID: 29101
		private LuaFunction m_OnActionOrderButtonClick_hotfix;

		// Token: 0x040071AE RID: 29102
		private LuaFunction m_OnChatButtonClick_hotfix;

		// Token: 0x040071AF RID: 29103
		private LuaFunction m_OnHelpButtonClick_hotfix;

		// Token: 0x040071B0 RID: 29104
		private LuaFunction m_IsTestBattle_hotfix;

		// Token: 0x040071B1 RID: 29105
		private LuaFunction m_OnTestOnStageToggleBoolean_hotfix;

		// Token: 0x040071B2 RID: 29106
		private LuaFunction m_IsTestOnStage_hotfix;

		// Token: 0x040071B3 RID: 29107
		private LuaFunction m_GetTestSoldierCountInt32_hotfix;

		// Token: 0x040071B4 RID: 29108
		private LuaFunction m_GetTestSkillIdInt32_hotfix;

		// Token: 0x040071B5 RID: 29109
		private LuaFunction m_GetTestTalentIdInt32_hotfix;

		// Token: 0x040071B6 RID: 29110
		private LuaFunction m_ClearPointerDownStageActor_hotfix;

		// Token: 0x040071B7 RID: 29111
		private LuaFunction m_OnScenePointerDownPointerEventData_hotfix;

		// Token: 0x040071B8 RID: 29112
		private LuaFunction m_OnScenePointerUpPointerEventData_hotfix;

		// Token: 0x040071B9 RID: 29113
		private LuaFunction m_OnScenePointerClickPointerEventData_hotfix;

		// Token: 0x040071BA RID: 29114
		private LuaFunction m_OnSceneBeginDragPointerEventData_hotfix;

		// Token: 0x040071BB RID: 29115
		private LuaFunction m_OnSceneEndDragPointerEventData_hotfix;

		// Token: 0x040071BC RID: 29116
		private LuaFunction m_OnSceneDragPointerEventData_hotfix;

		// Token: 0x040071BD RID: 29117
		private LuaFunction m_OnScene3DTouchVector2_hotfix;

		// Token: 0x040071BE RID: 29118
		private LuaFunction m_CreateDraggingHeroButtonBattleHero_hotfix;

		// Token: 0x040071BF RID: 29119
		private LuaFunction m_DestroyDragginHeroButton_hotfix;

		// Token: 0x040071C0 RID: 29120
		private LuaFunction m_MoveDraggingHeroButtonVector2_hotfix;

		// Token: 0x040071C1 RID: 29121
		private LuaFunction m_DropHeroButtonVector2_hotfix;

		// Token: 0x040071C2 RID: 29122
		private LuaFunction m_ComputeStageActorCount_hotfix;

		// Token: 0x040071C3 RID: 29123
		private LuaFunction m_UpdateStageActorCount_hotfix;

		// Token: 0x040071C4 RID: 29124
		private LuaFunction m_HeroDragButton_OnBeginDragHeroDragButtonPointerEventData_hotfix;

		// Token: 0x040071C5 RID: 29125
		private LuaFunction m_HeroDragButton_OnEndDragHeroDragButtonPointerEventData_hotfix;

		// Token: 0x040071C6 RID: 29126
		private LuaFunction m_HeroDragButton_OnDragPointerEventData_hotfix;

		// Token: 0x040071C7 RID: 29127
		private LuaFunction m_HeroDragButton_OnDropPointerEventData_hotfix;

		// Token: 0x040071C8 RID: 29128
		private LuaFunction m_HeroDragButton_OnClickHeroDragButton_hotfix;

		// Token: 0x040071C9 RID: 29129
		private LuaFunction m_RefreshChatRedState_hotfix;

		// Token: 0x040071CA RID: 29130
		private LuaFunction m_HideActorInfo_hotfix;

		// Token: 0x040071CB RID: 29131
		private LuaFunction m_add_EventOnPauseBattleAction_hotfix;

		// Token: 0x040071CC RID: 29132
		private LuaFunction m_remove_EventOnPauseBattleAction_hotfix;

		// Token: 0x040071CD RID: 29133
		private LuaFunction m_add_EventOnShowArmyRelationAction_hotfix;

		// Token: 0x040071CE RID: 29134
		private LuaFunction m_remove_EventOnShowArmyRelationAction_hotfix;

		// Token: 0x040071CF RID: 29135
		private LuaFunction m_add_EventOnStartAction_hotfix;

		// Token: 0x040071D0 RID: 29136
		private LuaFunction m_remove_EventOnStartAction_hotfix;

		// Token: 0x040071D1 RID: 29137
		private LuaFunction m_add_EventOnShowActionOrderAction_hotfix;

		// Token: 0x040071D2 RID: 29138
		private LuaFunction m_remove_EventOnShowActionOrderAction_hotfix;

		// Token: 0x040071D3 RID: 29139
		private LuaFunction m_add_EventOnTestOnStageAction_hotfix;

		// Token: 0x040071D4 RID: 29140
		private LuaFunction m_remove_EventOnTestOnStageAction_hotfix;

		// Token: 0x040071D5 RID: 29141
		private LuaFunction m_add_EventOnShowMyActorInfoAction;

		// Token: 0x040071D6 RID: 29142
		private LuaFunction m_remove_EventOnShowMyActorInfoAction;

		// Token: 0x040071D7 RID: 29143
		private LuaFunction m_add_EventOnHideActorInfoAction_hotfix;

		// Token: 0x040071D8 RID: 29144
		private LuaFunction m_remove_EventOnHideActorInfoAction_hotfix;

		// Token: 0x040071D9 RID: 29145
		private LuaFunction m_add_EventOnStageActorChangeAction_hotfix;

		// Token: 0x040071DA RID: 29146
		private LuaFunction m_remove_EventOnStageActorChangeAction_hotfix;

		// Token: 0x040071DB RID: 29147
		private LuaFunction m_add_EventOnShowChatAction_hotfix;

		// Token: 0x040071DC RID: 29148
		private LuaFunction m_remove_EventOnShowChatAction_hotfix;

		// Token: 0x040071DD RID: 29149
		private LuaFunction m_add_EventOnShowHelpAction_hotfix;

		// Token: 0x040071DE RID: 29150
		private LuaFunction m_remove_EventOnShowHelpAction_hotfix;

		// Token: 0x040071DF RID: 29151
		private LuaFunction m_add_EventOnHeroOnStageAction;

		// Token: 0x040071E0 RID: 29152
		private LuaFunction m_remove_EventOnHeroOnStageAction;

		// Token: 0x040071E1 RID: 29153
		private LuaFunction m_add_EventOnActorOffStageAction;

		// Token: 0x040071E2 RID: 29154
		private LuaFunction m_remove_EventOnActorOffStageAction;

		// Token: 0x040071E3 RID: 29155
		private LuaFunction m_add_EventOnStageActorMoveAction;

		// Token: 0x040071E4 RID: 29156
		private LuaFunction m_remove_EventOnStageActorMoveAction;

		// Token: 0x040071E5 RID: 29157
		private LuaFunction m_add_EventOnStageActorSwapAction;

		// Token: 0x040071E6 RID: 29158
		private LuaFunction m_remove_EventOnStageActorSwapAction;

		// Token: 0x040071E7 RID: 29159
		private LuaFunction m_add_EventOnPointerDownAction;

		// Token: 0x040071E8 RID: 29160
		private LuaFunction m_remove_EventOnPointerDownAction;

		// Token: 0x040071E9 RID: 29161
		private LuaFunction m_add_EventOnPointerUpAction;

		// Token: 0x040071EA RID: 29162
		private LuaFunction m_remove_EventOnPointerUpAction;

		// Token: 0x040071EB RID: 29163
		private LuaFunction m_add_EventOnPointerClickAction;

		// Token: 0x040071EC RID: 29164
		private LuaFunction m_remove_EventOnPointerClickAction;

		// Token: 0x040071ED RID: 29165
		private LuaFunction m_add_EventOnBeginDragHeroAction_hotfix;

		// Token: 0x040071EE RID: 29166
		private LuaFunction m_remove_EventOnBeginDragHeroAction_hotfix;

		// Token: 0x040071EF RID: 29167
		private LuaFunction m_add_EventOnEndDragHeroAction_hotfix;

		// Token: 0x040071F0 RID: 29168
		private LuaFunction m_remove_EventOnEndDragHeroAction_hotfix;

		// Token: 0x02000A9B RID: 2715
		public new class LuaExportHelper
		{
			// Token: 0x0600AD73 RID: 44403 RVA: 0x00306EA0 File Offset: 0x003050A0
			public LuaExportHelper(BattlePrepareUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600AD74 RID: 44404 RVA: 0x00306EB0 File Offset: 0x003050B0
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600AD75 RID: 44405 RVA: 0x00306EC0 File Offset: 0x003050C0
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600AD76 RID: 44406 RVA: 0x00306ED0 File Offset: 0x003050D0
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600AD77 RID: 44407 RVA: 0x00306EE0 File Offset: 0x003050E0
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600AD78 RID: 44408 RVA: 0x00306EF8 File Offset: 0x003050F8
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600AD79 RID: 44409 RVA: 0x00306F08 File Offset: 0x00305108
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600AD7A RID: 44410 RVA: 0x00306F18 File Offset: 0x00305118
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600AD7B RID: 44411 RVA: 0x00306F28 File Offset: 0x00305128
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600AD7C RID: 44412 RVA: 0x00306F38 File Offset: 0x00305138
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600AD7D RID: 44413 RVA: 0x00306F48 File Offset: 0x00305148
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600AD7E RID: 44414 RVA: 0x00306F58 File Offset: 0x00305158
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600AD7F RID: 44415 RVA: 0x00306F68 File Offset: 0x00305168
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600AD80 RID: 44416 RVA: 0x00306F78 File Offset: 0x00305178
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600AD81 RID: 44417 RVA: 0x00306F88 File Offset: 0x00305188
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600AD82 RID: 44418 RVA: 0x00306F98 File Offset: 0x00305198
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600AD83 RID: 44419 RVA: 0x00306FA8 File Offset: 0x003051A8
			public void __callDele_EventOnPauseBattle()
			{
				this.m_owner.__callDele_EventOnPauseBattle();
			}

			// Token: 0x0600AD84 RID: 44420 RVA: 0x00306FB8 File Offset: 0x003051B8
			public void __clearDele_EventOnPauseBattle()
			{
				this.m_owner.__clearDele_EventOnPauseBattle();
			}

			// Token: 0x0600AD85 RID: 44421 RVA: 0x00306FC8 File Offset: 0x003051C8
			public void __callDele_EventOnShowArmyRelation()
			{
				this.m_owner.__callDele_EventOnShowArmyRelation();
			}

			// Token: 0x0600AD86 RID: 44422 RVA: 0x00306FD8 File Offset: 0x003051D8
			public void __clearDele_EventOnShowArmyRelation()
			{
				this.m_owner.__clearDele_EventOnShowArmyRelation();
			}

			// Token: 0x0600AD87 RID: 44423 RVA: 0x00306FE8 File Offset: 0x003051E8
			public void __callDele_EventOnStart()
			{
				this.m_owner.__callDele_EventOnStart();
			}

			// Token: 0x0600AD88 RID: 44424 RVA: 0x00306FF8 File Offset: 0x003051F8
			public void __clearDele_EventOnStart()
			{
				this.m_owner.__clearDele_EventOnStart();
			}

			// Token: 0x0600AD89 RID: 44425 RVA: 0x00307008 File Offset: 0x00305208
			public void __callDele_EventOnShowActionOrder()
			{
				this.m_owner.__callDele_EventOnShowActionOrder();
			}

			// Token: 0x0600AD8A RID: 44426 RVA: 0x00307018 File Offset: 0x00305218
			public void __clearDele_EventOnShowActionOrder()
			{
				this.m_owner.__clearDele_EventOnShowActionOrder();
			}

			// Token: 0x0600AD8B RID: 44427 RVA: 0x00307028 File Offset: 0x00305228
			public void __callDele_EventOnTestOnStage()
			{
				this.m_owner.__callDele_EventOnTestOnStage();
			}

			// Token: 0x0600AD8C RID: 44428 RVA: 0x00307038 File Offset: 0x00305238
			public void __clearDele_EventOnTestOnStage()
			{
				this.m_owner.__clearDele_EventOnTestOnStage();
			}

			// Token: 0x0600AD8D RID: 44429 RVA: 0x00307048 File Offset: 0x00305248
			public void __callDele_EventOnShowMyActorInfo(BattleHero obj)
			{
				this.m_owner.__callDele_EventOnShowMyActorInfo(obj);
			}

			// Token: 0x0600AD8E RID: 44430 RVA: 0x00307058 File Offset: 0x00305258
			public void __clearDele_EventOnShowMyActorInfo(BattleHero obj)
			{
				this.m_owner.__clearDele_EventOnShowMyActorInfo(obj);
			}

			// Token: 0x0600AD8F RID: 44431 RVA: 0x00307068 File Offset: 0x00305268
			public void __callDele_EventOnHideActorInfo()
			{
				this.m_owner.__callDele_EventOnHideActorInfo();
			}

			// Token: 0x0600AD90 RID: 44432 RVA: 0x00307078 File Offset: 0x00305278
			public void __clearDele_EventOnHideActorInfo()
			{
				this.m_owner.__clearDele_EventOnHideActorInfo();
			}

			// Token: 0x0600AD91 RID: 44433 RVA: 0x00307088 File Offset: 0x00305288
			public void __callDele_EventOnStageActorChange()
			{
				this.m_owner.__callDele_EventOnStageActorChange();
			}

			// Token: 0x0600AD92 RID: 44434 RVA: 0x00307098 File Offset: 0x00305298
			public void __clearDele_EventOnStageActorChange()
			{
				this.m_owner.__clearDele_EventOnStageActorChange();
			}

			// Token: 0x0600AD93 RID: 44435 RVA: 0x003070A8 File Offset: 0x003052A8
			public void __callDele_EventOnShowChat()
			{
				this.m_owner.__callDele_EventOnShowChat();
			}

			// Token: 0x0600AD94 RID: 44436 RVA: 0x003070B8 File Offset: 0x003052B8
			public void __clearDele_EventOnShowChat()
			{
				this.m_owner.__clearDele_EventOnShowChat();
			}

			// Token: 0x0600AD95 RID: 44437 RVA: 0x003070C8 File Offset: 0x003052C8
			public void __callDele_EventOnShowHelp()
			{
				this.m_owner.__callDele_EventOnShowHelp();
			}

			// Token: 0x0600AD96 RID: 44438 RVA: 0x003070D8 File Offset: 0x003052D8
			public void __clearDele_EventOnShowHelp()
			{
				this.m_owner.__clearDele_EventOnShowHelp();
			}

			// Token: 0x0600AD97 RID: 44439 RVA: 0x003070E8 File Offset: 0x003052E8
			public void __callDele_EventOnHeroOnStage(BattleHero arg1, GridPosition arg2, int arg3)
			{
				this.m_owner.__callDele_EventOnHeroOnStage(arg1, arg2, arg3);
			}

			// Token: 0x0600AD98 RID: 44440 RVA: 0x003070F8 File Offset: 0x003052F8
			public void __clearDele_EventOnHeroOnStage(BattleHero arg1, GridPosition arg2, int arg3)
			{
				this.m_owner.__clearDele_EventOnHeroOnStage(arg1, arg2, arg3);
			}

			// Token: 0x0600AD99 RID: 44441 RVA: 0x00307108 File Offset: 0x00305308
			public void __callDele_EventOnActorOffStage(BattlePrepareStageActor obj)
			{
				this.m_owner.__callDele_EventOnActorOffStage(obj);
			}

			// Token: 0x0600AD9A RID: 44442 RVA: 0x00307118 File Offset: 0x00305318
			public void __clearDele_EventOnActorOffStage(BattlePrepareStageActor obj)
			{
				this.m_owner.__clearDele_EventOnActorOffStage(obj);
			}

			// Token: 0x0600AD9B RID: 44443 RVA: 0x00307128 File Offset: 0x00305328
			public void __callDele_EventOnStageActorMove(BattlePrepareStageActor arg1, GridPosition arg2)
			{
				this.m_owner.__callDele_EventOnStageActorMove(arg1, arg2);
			}

			// Token: 0x0600AD9C RID: 44444 RVA: 0x00307138 File Offset: 0x00305338
			public void __clearDele_EventOnStageActorMove(BattlePrepareStageActor arg1, GridPosition arg2)
			{
				this.m_owner.__clearDele_EventOnStageActorMove(arg1, arg2);
			}

			// Token: 0x0600AD9D RID: 44445 RVA: 0x00307148 File Offset: 0x00305348
			public void __callDele_EventOnStageActorSwap(BattlePrepareStageActor arg1, BattlePrepareStageActor arg2)
			{
				this.m_owner.__callDele_EventOnStageActorSwap(arg1, arg2);
			}

			// Token: 0x0600AD9E RID: 44446 RVA: 0x00307158 File Offset: 0x00305358
			public void __clearDele_EventOnStageActorSwap(BattlePrepareStageActor arg1, BattlePrepareStageActor arg2)
			{
				this.m_owner.__clearDele_EventOnStageActorSwap(arg1, arg2);
			}

			// Token: 0x0600AD9F RID: 44447 RVA: 0x00307168 File Offset: 0x00305368
			public void __callDele_EventOnPointerDown(PointerEventData.InputButton arg1, Vector2 arg2)
			{
				this.m_owner.__callDele_EventOnPointerDown(arg1, arg2);
			}

			// Token: 0x0600ADA0 RID: 44448 RVA: 0x00307178 File Offset: 0x00305378
			public void __clearDele_EventOnPointerDown(PointerEventData.InputButton arg1, Vector2 arg2)
			{
				this.m_owner.__clearDele_EventOnPointerDown(arg1, arg2);
			}

			// Token: 0x0600ADA1 RID: 44449 RVA: 0x00307188 File Offset: 0x00305388
			public void __callDele_EventOnPointerUp(PointerEventData.InputButton arg1, Vector2 arg2)
			{
				this.m_owner.__callDele_EventOnPointerUp(arg1, arg2);
			}

			// Token: 0x0600ADA2 RID: 44450 RVA: 0x00307198 File Offset: 0x00305398
			public void __clearDele_EventOnPointerUp(PointerEventData.InputButton arg1, Vector2 arg2)
			{
				this.m_owner.__clearDele_EventOnPointerUp(arg1, arg2);
			}

			// Token: 0x0600ADA3 RID: 44451 RVA: 0x003071A8 File Offset: 0x003053A8
			public void __callDele_EventOnPointerClick(PointerEventData.InputButton arg1, Vector2 arg2)
			{
				this.m_owner.__callDele_EventOnPointerClick(arg1, arg2);
			}

			// Token: 0x0600ADA4 RID: 44452 RVA: 0x003071B8 File Offset: 0x003053B8
			public void __clearDele_EventOnPointerClick(PointerEventData.InputButton arg1, Vector2 arg2)
			{
				this.m_owner.__clearDele_EventOnPointerClick(arg1, arg2);
			}

			// Token: 0x0600ADA5 RID: 44453 RVA: 0x003071C8 File Offset: 0x003053C8
			public void __callDele_EventOnBeginDragHero()
			{
				this.m_owner.__callDele_EventOnBeginDragHero();
			}

			// Token: 0x0600ADA6 RID: 44454 RVA: 0x003071D8 File Offset: 0x003053D8
			public void __clearDele_EventOnBeginDragHero()
			{
				this.m_owner.__clearDele_EventOnBeginDragHero();
			}

			// Token: 0x0600ADA7 RID: 44455 RVA: 0x003071E8 File Offset: 0x003053E8
			public void __callDele_EventOnEndDragHero()
			{
				this.m_owner.__callDele_EventOnEndDragHero();
			}

			// Token: 0x0600ADA8 RID: 44456 RVA: 0x003071F8 File Offset: 0x003053F8
			public void __clearDele_EventOnEndDragHero()
			{
				this.m_owner.__clearDele_EventOnEndDragHero();
			}

			// Token: 0x17002321 RID: 8993
			// (get) Token: 0x0600ADA9 RID: 44457 RVA: 0x00307208 File Offset: 0x00305408
			// (set) Token: 0x0600ADAA RID: 44458 RVA: 0x00307218 File Offset: 0x00305418
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

			// Token: 0x17002322 RID: 8994
			// (get) Token: 0x0600ADAB RID: 44459 RVA: 0x00307228 File Offset: 0x00305428
			// (set) Token: 0x0600ADAC RID: 44460 RVA: 0x00307238 File Offset: 0x00305438
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

			// Token: 0x17002323 RID: 8995
			// (get) Token: 0x0600ADAD RID: 44461 RVA: 0x00307248 File Offset: 0x00305448
			// (set) Token: 0x0600ADAE RID: 44462 RVA: 0x00307258 File Offset: 0x00305458
			public Text m_stageActorCountText
			{
				get
				{
					return this.m_owner.m_stageActorCountText;
				}
				set
				{
					this.m_owner.m_stageActorCountText = value;
				}
			}

			// Token: 0x17002324 RID: 8996
			// (get) Token: 0x0600ADAF RID: 44463 RVA: 0x00307268 File Offset: 0x00305468
			// (set) Token: 0x0600ADB0 RID: 44464 RVA: 0x00307278 File Offset: 0x00305478
			public CommonUIStateController m_battlePowerUIStateController
			{
				get
				{
					return this.m_owner.m_battlePowerUIStateController;
				}
				set
				{
					this.m_owner.m_battlePowerUIStateController = value;
				}
			}

			// Token: 0x17002325 RID: 8997
			// (get) Token: 0x0600ADB1 RID: 44465 RVA: 0x00307288 File Offset: 0x00305488
			// (set) Token: 0x0600ADB2 RID: 44466 RVA: 0x00307298 File Offset: 0x00305498
			public Text m_battlePowerText
			{
				get
				{
					return this.m_owner.m_battlePowerText;
				}
				set
				{
					this.m_owner.m_battlePowerText = value;
				}
			}

			// Token: 0x17002326 RID: 8998
			// (get) Token: 0x0600ADB3 RID: 44467 RVA: 0x003072A8 File Offset: 0x003054A8
			// (set) Token: 0x0600ADB4 RID: 44468 RVA: 0x003072B8 File Offset: 0x003054B8
			public GameObject m_battlePowerArrowGo
			{
				get
				{
					return this.m_owner.m_battlePowerArrowGo;
				}
				set
				{
					this.m_owner.m_battlePowerArrowGo = value;
				}
			}

			// Token: 0x17002327 RID: 8999
			// (get) Token: 0x0600ADB5 RID: 44469 RVA: 0x003072C8 File Offset: 0x003054C8
			// (set) Token: 0x0600ADB6 RID: 44470 RVA: 0x003072D8 File Offset: 0x003054D8
			public CommonUIStateController m_climbTowerRuleUIStateController
			{
				get
				{
					return this.m_owner.m_climbTowerRuleUIStateController;
				}
				set
				{
					this.m_owner.m_climbTowerRuleUIStateController = value;
				}
			}

			// Token: 0x17002328 RID: 9000
			// (get) Token: 0x0600ADB7 RID: 44471 RVA: 0x003072E8 File Offset: 0x003054E8
			// (set) Token: 0x0600ADB8 RID: 44472 RVA: 0x003072F8 File Offset: 0x003054F8
			public Text m_climbTowerRuleText
			{
				get
				{
					return this.m_owner.m_climbTowerRuleText;
				}
				set
				{
					this.m_owner.m_climbTowerRuleText = value;
				}
			}

			// Token: 0x17002329 RID: 9001
			// (get) Token: 0x0600ADB9 RID: 44473 RVA: 0x00307308 File Offset: 0x00305508
			// (set) Token: 0x0600ADBA RID: 44474 RVA: 0x00307318 File Offset: 0x00305518
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

			// Token: 0x1700232A RID: 9002
			// (get) Token: 0x0600ADBB RID: 44475 RVA: 0x00307328 File Offset: 0x00305528
			// (set) Token: 0x0600ADBC RID: 44476 RVA: 0x00307338 File Offset: 0x00305538
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

			// Token: 0x1700232B RID: 9003
			// (get) Token: 0x0600ADBD RID: 44477 RVA: 0x00307348 File Offset: 0x00305548
			// (set) Token: 0x0600ADBE RID: 44478 RVA: 0x00307358 File Offset: 0x00305558
			public Button m_actionOrderButton
			{
				get
				{
					return this.m_owner.m_actionOrderButton;
				}
				set
				{
					this.m_owner.m_actionOrderButton = value;
				}
			}

			// Token: 0x1700232C RID: 9004
			// (get) Token: 0x0600ADBF RID: 44479 RVA: 0x00307368 File Offset: 0x00305568
			// (set) Token: 0x0600ADC0 RID: 44480 RVA: 0x00307378 File Offset: 0x00305578
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

			// Token: 0x1700232D RID: 9005
			// (get) Token: 0x0600ADC1 RID: 44481 RVA: 0x00307388 File Offset: 0x00305588
			// (set) Token: 0x0600ADC2 RID: 44482 RVA: 0x00307398 File Offset: 0x00305598
			public GameObject m_teamReadyGameObject
			{
				get
				{
					return this.m_owner.m_teamReadyGameObject;
				}
				set
				{
					this.m_owner.m_teamReadyGameObject = value;
				}
			}

			// Token: 0x1700232E RID: 9006
			// (get) Token: 0x0600ADC3 RID: 44483 RVA: 0x003073A8 File Offset: 0x003055A8
			// (set) Token: 0x0600ADC4 RID: 44484 RVA: 0x003073B8 File Offset: 0x003055B8
			public CommonUIStateController m_teamReadyTimeUIStateController
			{
				get
				{
					return this.m_owner.m_teamReadyTimeUIStateController;
				}
				set
				{
					this.m_owner.m_teamReadyTimeUIStateController = value;
				}
			}

			// Token: 0x1700232F RID: 9007
			// (get) Token: 0x0600ADC5 RID: 44485 RVA: 0x003073C8 File Offset: 0x003055C8
			// (set) Token: 0x0600ADC6 RID: 44486 RVA: 0x003073D8 File Offset: 0x003055D8
			public Text m_teamReadyTimeText
			{
				get
				{
					return this.m_owner.m_teamReadyTimeText;
				}
				set
				{
					this.m_owner.m_teamReadyTimeText = value;
				}
			}

			// Token: 0x17002330 RID: 9008
			// (get) Token: 0x0600ADC7 RID: 44487 RVA: 0x003073E8 File Offset: 0x003055E8
			// (set) Token: 0x0600ADC8 RID: 44488 RVA: 0x003073F8 File Offset: 0x003055F8
			public GameObject m_teamReadyWaitGameObject
			{
				get
				{
					return this.m_owner.m_teamReadyWaitGameObject;
				}
				set
				{
					this.m_owner.m_teamReadyWaitGameObject = value;
				}
			}

			// Token: 0x17002331 RID: 9009
			// (get) Token: 0x0600ADC9 RID: 44489 RVA: 0x00307408 File Offset: 0x00305608
			// (set) Token: 0x0600ADCA RID: 44490 RVA: 0x00307418 File Offset: 0x00305618
			public Text m_teamReadyWaitTeammateText
			{
				get
				{
					return this.m_owner.m_teamReadyWaitTeammateText;
				}
				set
				{
					this.m_owner.m_teamReadyWaitTeammateText = value;
				}
			}

			// Token: 0x17002332 RID: 9010
			// (get) Token: 0x0600ADCB RID: 44491 RVA: 0x00307428 File Offset: 0x00305628
			// (set) Token: 0x0600ADCC RID: 44492 RVA: 0x00307438 File Offset: 0x00305638
			public Text m_teamReadyWaitOpponentText
			{
				get
				{
					return this.m_owner.m_teamReadyWaitOpponentText;
				}
				set
				{
					this.m_owner.m_teamReadyWaitOpponentText = value;
				}
			}

			// Token: 0x17002333 RID: 9011
			// (get) Token: 0x0600ADCD RID: 44493 RVA: 0x00307448 File Offset: 0x00305648
			// (set) Token: 0x0600ADCE RID: 44494 RVA: 0x00307458 File Offset: 0x00305658
			public GameObject m_testGameObject
			{
				get
				{
					return this.m_owner.m_testGameObject;
				}
				set
				{
					this.m_owner.m_testGameObject = value;
				}
			}

			// Token: 0x17002334 RID: 9012
			// (get) Token: 0x0600ADCF RID: 44495 RVA: 0x00307468 File Offset: 0x00305668
			// (set) Token: 0x0600ADD0 RID: 44496 RVA: 0x00307478 File Offset: 0x00305678
			public Toggle m_testOnStageToggle
			{
				get
				{
					return this.m_owner.m_testOnStageToggle;
				}
				set
				{
					this.m_owner.m_testOnStageToggle = value;
				}
			}

			// Token: 0x17002335 RID: 9013
			// (get) Token: 0x0600ADD1 RID: 44497 RVA: 0x00307488 File Offset: 0x00305688
			// (set) Token: 0x0600ADD2 RID: 44498 RVA: 0x00307498 File Offset: 0x00305698
			public InputField m_testSoldierInputField0
			{
				get
				{
					return this.m_owner.m_testSoldierInputField0;
				}
				set
				{
					this.m_owner.m_testSoldierInputField0 = value;
				}
			}

			// Token: 0x17002336 RID: 9014
			// (get) Token: 0x0600ADD3 RID: 44499 RVA: 0x003074A8 File Offset: 0x003056A8
			// (set) Token: 0x0600ADD4 RID: 44500 RVA: 0x003074B8 File Offset: 0x003056B8
			public InputField m_testSoldierInputField1
			{
				get
				{
					return this.m_owner.m_testSoldierInputField1;
				}
				set
				{
					this.m_owner.m_testSoldierInputField1 = value;
				}
			}

			// Token: 0x17002337 RID: 9015
			// (get) Token: 0x0600ADD5 RID: 44501 RVA: 0x003074C8 File Offset: 0x003056C8
			// (set) Token: 0x0600ADD6 RID: 44502 RVA: 0x003074D8 File Offset: 0x003056D8
			public InputField m_testSkillInputField0
			{
				get
				{
					return this.m_owner.m_testSkillInputField0;
				}
				set
				{
					this.m_owner.m_testSkillInputField0 = value;
				}
			}

			// Token: 0x17002338 RID: 9016
			// (get) Token: 0x0600ADD7 RID: 44503 RVA: 0x003074E8 File Offset: 0x003056E8
			// (set) Token: 0x0600ADD8 RID: 44504 RVA: 0x003074F8 File Offset: 0x003056F8
			public InputField m_testSkillInputField1
			{
				get
				{
					return this.m_owner.m_testSkillInputField1;
				}
				set
				{
					this.m_owner.m_testSkillInputField1 = value;
				}
			}

			// Token: 0x17002339 RID: 9017
			// (get) Token: 0x0600ADD9 RID: 44505 RVA: 0x00307508 File Offset: 0x00305708
			// (set) Token: 0x0600ADDA RID: 44506 RVA: 0x00307518 File Offset: 0x00305718
			public InputField m_testTalentInputField0
			{
				get
				{
					return this.m_owner.m_testTalentInputField0;
				}
				set
				{
					this.m_owner.m_testTalentInputField0 = value;
				}
			}

			// Token: 0x1700233A RID: 9018
			// (get) Token: 0x0600ADDB RID: 44507 RVA: 0x00307528 File Offset: 0x00305728
			// (set) Token: 0x0600ADDC RID: 44508 RVA: 0x00307538 File Offset: 0x00305738
			public InputField m_testTalentInputField1
			{
				get
				{
					return this.m_owner.m_testTalentInputField1;
				}
				set
				{
					this.m_owner.m_testTalentInputField1 = value;
				}
			}

			// Token: 0x1700233B RID: 9019
			// (get) Token: 0x0600ADDD RID: 44509 RVA: 0x00307548 File Offset: 0x00305748
			// (set) Token: 0x0600ADDE RID: 44510 RVA: 0x00307558 File Offset: 0x00305758
			public ScrollRect m_actorListScrollRect
			{
				get
				{
					return this.m_owner.m_actorListScrollRect;
				}
				set
				{
					this.m_owner.m_actorListScrollRect = value;
				}
			}

			// Token: 0x1700233C RID: 9020
			// (get) Token: 0x0600ADDF RID: 44511 RVA: 0x00307568 File Offset: 0x00305768
			// (set) Token: 0x0600ADE0 RID: 44512 RVA: 0x00307578 File Offset: 0x00305778
			public GameObject m_actorListDisableGameObject
			{
				get
				{
					return this.m_owner.m_actorListDisableGameObject;
				}
				set
				{
					this.m_owner.m_actorListDisableGameObject = value;
				}
			}

			// Token: 0x1700233D RID: 9021
			// (get) Token: 0x0600ADE1 RID: 44513 RVA: 0x00307588 File Offset: 0x00305788
			// (set) Token: 0x0600ADE2 RID: 44514 RVA: 0x00307598 File Offset: 0x00305798
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

			// Token: 0x1700233E RID: 9022
			// (get) Token: 0x0600ADE3 RID: 44515 RVA: 0x003075A8 File Offset: 0x003057A8
			// (set) Token: 0x0600ADE4 RID: 44516 RVA: 0x003075B8 File Offset: 0x003057B8
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

			// Token: 0x1700233F RID: 9023
			// (get) Token: 0x0600ADE5 RID: 44517 RVA: 0x003075C8 File Offset: 0x003057C8
			// (set) Token: 0x0600ADE6 RID: 44518 RVA: 0x003075D8 File Offset: 0x003057D8
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

			// Token: 0x17002340 RID: 9024
			// (get) Token: 0x0600ADE7 RID: 44519 RVA: 0x003075E8 File Offset: 0x003057E8
			// (set) Token: 0x0600ADE8 RID: 44520 RVA: 0x003075F8 File Offset: 0x003057F8
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

			// Token: 0x17002341 RID: 9025
			// (get) Token: 0x0600ADE9 RID: 44521 RVA: 0x00307608 File Offset: 0x00305808
			// (set) Token: 0x0600ADEA RID: 44522 RVA: 0x00307618 File Offset: 0x00305818
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

			// Token: 0x17002342 RID: 9026
			// (get) Token: 0x0600ADEB RID: 44523 RVA: 0x00307628 File Offset: 0x00305828
			// (set) Token: 0x0600ADEC RID: 44524 RVA: 0x00307638 File Offset: 0x00305838
			public GameObject m_heroButtonPrefab
			{
				get
				{
					return this.m_owner.m_heroButtonPrefab;
				}
				set
				{
					this.m_owner.m_heroButtonPrefab = value;
				}
			}

			// Token: 0x17002343 RID: 9027
			// (get) Token: 0x0600ADED RID: 44525 RVA: 0x00307648 File Offset: 0x00305848
			// (set) Token: 0x0600ADEE RID: 44526 RVA: 0x00307658 File Offset: 0x00305858
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

			// Token: 0x17002344 RID: 9028
			// (get) Token: 0x0600ADEF RID: 44527 RVA: 0x00307668 File Offset: 0x00305868
			// (set) Token: 0x0600ADF0 RID: 44528 RVA: 0x00307678 File Offset: 0x00305878
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

			// Token: 0x17002345 RID: 9029
			// (get) Token: 0x0600ADF1 RID: 44529 RVA: 0x00307688 File Offset: 0x00305888
			// (set) Token: 0x0600ADF2 RID: 44530 RVA: 0x00307698 File Offset: 0x00305898
			public ClientBattle m_clientBattle
			{
				get
				{
					return this.m_owner.m_clientBattle;
				}
				set
				{
					this.m_owner.m_clientBattle = value;
				}
			}

			// Token: 0x17002346 RID: 9030
			// (get) Token: 0x0600ADF3 RID: 44531 RVA: 0x003076A8 File Offset: 0x003058A8
			// (set) Token: 0x0600ADF4 RID: 44532 RVA: 0x003076B8 File Offset: 0x003058B8
			public Camera m_camera
			{
				get
				{
					return this.m_owner.m_camera;
				}
				set
				{
					this.m_owner.m_camera = value;
				}
			}

			// Token: 0x17002347 RID: 9031
			// (get) Token: 0x0600ADF5 RID: 44533 RVA: 0x003076C8 File Offset: 0x003058C8
			// (set) Token: 0x0600ADF6 RID: 44534 RVA: 0x003076D8 File Offset: 0x003058D8
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

			// Token: 0x17002348 RID: 9032
			// (get) Token: 0x0600ADF7 RID: 44535 RVA: 0x003076E8 File Offset: 0x003058E8
			// (set) Token: 0x0600ADF8 RID: 44536 RVA: 0x003076F8 File Offset: 0x003058F8
			public bool m_isIgnorePointerClick
			{
				get
				{
					return this.m_owner.m_isIgnorePointerClick;
				}
				set
				{
					this.m_owner.m_isIgnorePointerClick = value;
				}
			}

			// Token: 0x17002349 RID: 9033
			// (get) Token: 0x0600ADF9 RID: 44537 RVA: 0x00307708 File Offset: 0x00305908
			// (set) Token: 0x0600ADFA RID: 44538 RVA: 0x00307718 File Offset: 0x00305918
			public BattlePrepareStageActor m_pointerDownStageActor
			{
				get
				{
					return this.m_owner.m_pointerDownStageActor;
				}
				set
				{
					this.m_owner.m_pointerDownStageActor = value;
				}
			}

			// Token: 0x1700234A RID: 9034
			// (get) Token: 0x0600ADFB RID: 44539 RVA: 0x00307728 File Offset: 0x00305928
			// (set) Token: 0x0600ADFC RID: 44540 RVA: 0x00307738 File Offset: 0x00305938
			public bool m_isIgnoreToggleEvent
			{
				get
				{
					return this.m_owner.m_isIgnoreToggleEvent;
				}
				set
				{
					this.m_owner.m_isIgnoreToggleEvent = value;
				}
			}

			// Token: 0x1700234B RID: 9035
			// (get) Token: 0x0600ADFD RID: 44541 RVA: 0x00307748 File Offset: 0x00305948
			// (set) Token: 0x0600ADFE RID: 44542 RVA: 0x00307758 File Offset: 0x00305958
			public bool m_isSkipStageActorGraphic
			{
				get
				{
					return this.m_owner.m_isSkipStageActorGraphic;
				}
				set
				{
					this.m_owner.m_isSkipStageActorGraphic = value;
				}
			}

			// Token: 0x1700234C RID: 9036
			// (get) Token: 0x0600ADFF RID: 44543 RVA: 0x00307768 File Offset: 0x00305968
			// (set) Token: 0x0600AE00 RID: 44544 RVA: 0x00307778 File Offset: 0x00305978
			public int m_stageActorCountMax
			{
				get
				{
					return this.m_owner.m_stageActorCountMax;
				}
				set
				{
					this.m_owner.m_stageActorCountMax = value;
				}
			}

			// Token: 0x1700234D RID: 9037
			// (get) Token: 0x0600AE01 RID: 44545 RVA: 0x00307788 File Offset: 0x00305988
			// (set) Token: 0x0600AE02 RID: 44546 RVA: 0x00307798 File Offset: 0x00305998
			public int m_turnStageActorCountMax
			{
				get
				{
					return this.m_owner.m_turnStageActorCountMax;
				}
				set
				{
					this.m_owner.m_turnStageActorCountMax = value;
				}
			}

			// Token: 0x1700234E RID: 9038
			// (get) Token: 0x0600AE03 RID: 44547 RVA: 0x003077A8 File Offset: 0x003059A8
			// (set) Token: 0x0600AE04 RID: 44548 RVA: 0x003077B8 File Offset: 0x003059B8
			public bool m_isStageActorChanged
			{
				get
				{
					return this.m_owner.m_isStageActorChanged;
				}
				set
				{
					this.m_owner.m_isStageActorChanged = value;
				}
			}

			// Token: 0x1700234F RID: 9039
			// (get) Token: 0x0600AE05 RID: 44549 RVA: 0x003077C8 File Offset: 0x003059C8
			// (set) Token: 0x0600AE06 RID: 44550 RVA: 0x003077D8 File Offset: 0x003059D8
			public List<HeroDragButton> m_heroButtons
			{
				get
				{
					return this.m_owner.m_heroButtons;
				}
				set
				{
					this.m_owner.m_heroButtons = value;
				}
			}

			// Token: 0x17002350 RID: 9040
			// (get) Token: 0x0600AE07 RID: 44551 RVA: 0x003077E8 File Offset: 0x003059E8
			// (set) Token: 0x0600AE08 RID: 44552 RVA: 0x003077F8 File Offset: 0x003059F8
			public List<BattlePrepareStageActor> m_stageActors
			{
				get
				{
					return this.m_owner.m_stageActors;
				}
				set
				{
					this.m_owner.m_stageActors = value;
				}
			}

			// Token: 0x17002351 RID: 9041
			// (get) Token: 0x0600AE09 RID: 44553 RVA: 0x00307808 File Offset: 0x00305A08
			// (set) Token: 0x0600AE0A RID: 44554 RVA: 0x00307818 File Offset: 0x00305A18
			public List<BattlePrepareTreasure> m_treasures
			{
				get
				{
					return this.m_owner.m_treasures;
				}
				set
				{
					this.m_owner.m_treasures = value;
				}
			}

			// Token: 0x17002352 RID: 9042
			// (get) Token: 0x0600AE0B RID: 44555 RVA: 0x00307828 File Offset: 0x00305A28
			// (set) Token: 0x0600AE0C RID: 44556 RVA: 0x00307838 File Offset: 0x00305A38
			public List<GridPosition>[] m_stagePositions
			{
				get
				{
					return this.m_owner.m_stagePositions;
				}
				set
				{
					this.m_owner.m_stagePositions = value;
				}
			}

			// Token: 0x17002353 RID: 9043
			// (get) Token: 0x0600AE0D RID: 44557 RVA: 0x00307848 File Offset: 0x00305A48
			// (set) Token: 0x0600AE0E RID: 44558 RVA: 0x00307858 File Offset: 0x00305A58
			public List<int>[] m_stageDirs
			{
				get
				{
					return this.m_owner.m_stageDirs;
				}
				set
				{
					this.m_owner.m_stageDirs = value;
				}
			}

			// Token: 0x17002354 RID: 9044
			// (get) Token: 0x0600AE0F RID: 44559 RVA: 0x00307868 File Offset: 0x00305A68
			// (set) Token: 0x0600AE10 RID: 44560 RVA: 0x00307878 File Offset: 0x00305A78
			public HeroDragButton m_draggingHeroButton
			{
				get
				{
					return this.m_owner.m_draggingHeroButton;
				}
				set
				{
					this.m_owner.m_draggingHeroButton = value;
				}
			}

			// Token: 0x17002355 RID: 9045
			// (get) Token: 0x0600AE11 RID: 44561 RVA: 0x00307888 File Offset: 0x00305A88
			// (set) Token: 0x0600AE12 RID: 44562 RVA: 0x00307890 File Offset: 0x00305A90
			public static int s_testSoldierCount0
			{
				get
				{
					return BattlePrepareUIController.s_testSoldierCount0;
				}
				set
				{
					BattlePrepareUIController.s_testSoldierCount0 = value;
				}
			}

			// Token: 0x17002356 RID: 9046
			// (get) Token: 0x0600AE13 RID: 44563 RVA: 0x00307898 File Offset: 0x00305A98
			// (set) Token: 0x0600AE14 RID: 44564 RVA: 0x003078A0 File Offset: 0x00305AA0
			public static int s_testSoldierCount1
			{
				get
				{
					return BattlePrepareUIController.s_testSoldierCount1;
				}
				set
				{
					BattlePrepareUIController.s_testSoldierCount1 = value;
				}
			}

			// Token: 0x17002357 RID: 9047
			// (get) Token: 0x0600AE15 RID: 44565 RVA: 0x003078A8 File Offset: 0x00305AA8
			// (set) Token: 0x0600AE16 RID: 44566 RVA: 0x003078B0 File Offset: 0x00305AB0
			public static int s_testSkillId0
			{
				get
				{
					return BattlePrepareUIController.s_testSkillId0;
				}
				set
				{
					BattlePrepareUIController.s_testSkillId0 = value;
				}
			}

			// Token: 0x17002358 RID: 9048
			// (get) Token: 0x0600AE17 RID: 44567 RVA: 0x003078B8 File Offset: 0x00305AB8
			// (set) Token: 0x0600AE18 RID: 44568 RVA: 0x003078C0 File Offset: 0x00305AC0
			public static int s_testSkillId1
			{
				get
				{
					return BattlePrepareUIController.s_testSkillId1;
				}
				set
				{
					BattlePrepareUIController.s_testSkillId1 = value;
				}
			}

			// Token: 0x17002359 RID: 9049
			// (get) Token: 0x0600AE19 RID: 44569 RVA: 0x003078C8 File Offset: 0x00305AC8
			// (set) Token: 0x0600AE1A RID: 44570 RVA: 0x003078D0 File Offset: 0x00305AD0
			public static int s_testTalentId0
			{
				get
				{
					return BattlePrepareUIController.s_testTalentId0;
				}
				set
				{
					BattlePrepareUIController.s_testTalentId0 = value;
				}
			}

			// Token: 0x1700235A RID: 9050
			// (get) Token: 0x0600AE1B RID: 44571 RVA: 0x003078D8 File Offset: 0x00305AD8
			// (set) Token: 0x0600AE1C RID: 44572 RVA: 0x003078E0 File Offset: 0x00305AE0
			public static int s_testTalentId1
			{
				get
				{
					return BattlePrepareUIController.s_testTalentId1;
				}
				set
				{
					BattlePrepareUIController.s_testTalentId1 = value;
				}
			}

			// Token: 0x1700235B RID: 9051
			// (get) Token: 0x0600AE1D RID: 44573 RVA: 0x003078E8 File Offset: 0x00305AE8
			// (set) Token: 0x0600AE1E RID: 44574 RVA: 0x003078F0 File Offset: 0x00305AF0
			public static bool s_isTestOnStage
			{
				get
				{
					return BattlePrepareUIController.s_isTestOnStage;
				}
				set
				{
					BattlePrepareUIController.s_isTestOnStage = value;
				}
			}

			// Token: 0x1700235C RID: 9052
			// (get) Token: 0x0600AE1F RID: 44575 RVA: 0x003078F8 File Offset: 0x00305AF8
			// (set) Token: 0x0600AE20 RID: 44576 RVA: 0x00307908 File Offset: 0x00305B08
			public int m_battlePowerValue
			{
				get
				{
					return this.m_owner.m_battlePowerValue;
				}
				set
				{
					this.m_owner.m_battlePowerValue = value;
				}
			}

			// Token: 0x1700235D RID: 9053
			// (get) Token: 0x0600AE21 RID: 44577 RVA: 0x00307918 File Offset: 0x00305B18
			// (set) Token: 0x0600AE22 RID: 44578 RVA: 0x00307928 File Offset: 0x00305B28
			public Coroutine m_setBattlePowerValueCoroutine
			{
				get
				{
					return this.m_owner.m_setBattlePowerValueCoroutine;
				}
				set
				{
					this.m_owner.m_setBattlePowerValueCoroutine = value;
				}
			}

			// Token: 0x1700235E RID: 9054
			// (get) Token: 0x0600AE23 RID: 44579 RVA: 0x00307938 File Offset: 0x00305B38
			// (set) Token: 0x0600AE24 RID: 44580 RVA: 0x00307948 File Offset: 0x00305B48
			public ConfigDataTowerBattleRuleInfo m_towerBattleRuleInfo
			{
				get
				{
					return this.m_owner.m_towerBattleRuleInfo;
				}
				set
				{
					this.m_owner.m_towerBattleRuleInfo = value;
				}
			}

			// Token: 0x0600AE25 RID: 44581 RVA: 0x00307958 File Offset: 0x00305B58
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600AE26 RID: 44582 RVA: 0x00307968 File Offset: 0x00305B68
			public void OnDisable()
			{
				this.m_owner.OnDisable();
			}

			// Token: 0x0600AE27 RID: 44583 RVA: 0x00307978 File Offset: 0x00305B78
			public void OnApplicationPause(bool isPause)
			{
				this.m_owner.OnApplicationPause(isPause);
			}

			// Token: 0x0600AE28 RID: 44584 RVA: 0x00307988 File Offset: 0x00305B88
			public void OnApplicationFocus(bool focus)
			{
				this.m_owner.OnApplicationFocus(focus);
			}

			// Token: 0x0600AE29 RID: 44585 RVA: 0x00307998 File Offset: 0x00305B98
			public void CancelDragging()
			{
				this.m_owner.CancelDragging();
			}

			// Token: 0x0600AE2A RID: 44586 RVA: 0x003079A8 File Offset: 0x00305BA8
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x0600AE2B RID: 44587 RVA: 0x003079B8 File Offset: 0x00305BB8
			public int GetStageDirection(GridPosition p, StagePositionType posType)
			{
				return this.m_owner.GetStageDirection(p, posType);
			}

			// Token: 0x0600AE2C RID: 44588 RVA: 0x003079C8 File Offset: 0x00305BC8
			public HeroDragButton CreateHeroButton(BattleHero hero, Transform parent)
			{
				return this.m_owner.CreateHeroButton(hero, parent);
			}

			// Token: 0x0600AE2D RID: 44589 RVA: 0x003079D8 File Offset: 0x00305BD8
			public void SortChildByY(Transform parent)
			{
				this.m_owner.SortChildByY(parent);
			}

			// Token: 0x0600AE2E RID: 44590 RVA: 0x003079E8 File Offset: 0x00305BE8
			public static int CompareTransformY(Transform t0, Transform t1)
			{
				return BattlePrepareUIController.CompareTransformY(t0, t1);
			}

			// Token: 0x0600AE2F RID: 44591 RVA: 0x003079F4 File Offset: 0x00305BF4
			public void ClearBattlePowerValue()
			{
				this.m_owner.ClearBattlePowerValue();
			}

			// Token: 0x0600AE30 RID: 44592 RVA: 0x00307A04 File Offset: 0x00305C04
			public IEnumerator Co_SetBattlePowerValue(int newValue, int oldValue)
			{
				return this.m_owner.Co_SetBattlePowerValue(newValue, oldValue);
			}

			// Token: 0x0600AE31 RID: 44593 RVA: 0x00307A14 File Offset: 0x00305C14
			public void UpdateTestValuesToInputField()
			{
				this.m_owner.UpdateTestValuesToInputField();
			}

			// Token: 0x0600AE32 RID: 44594 RVA: 0x00307A24 File Offset: 0x00305C24
			public static void SetInputFieldValue(InputField inputField, int value, int defaultValue)
			{
				BattlePrepareUIController.SetInputFieldValue(inputField, value, defaultValue);
			}

			// Token: 0x0600AE33 RID: 44595 RVA: 0x00307A30 File Offset: 0x00305C30
			public void UpdateTestValuesFromInputField()
			{
				this.m_owner.UpdateTestValuesFromInputField();
			}

			// Token: 0x0600AE34 RID: 44596 RVA: 0x00307A40 File Offset: 0x00305C40
			public static int GetInputFieldValue(InputField inputField, int defaultValue)
			{
				return BattlePrepareUIController.GetInputFieldValue(inputField, defaultValue);
			}

			// Token: 0x0600AE35 RID: 44597 RVA: 0x00307A4C File Offset: 0x00305C4C
			public void HideTeamReadyCountdown()
			{
				this.m_owner.HideTeamReadyCountdown();
			}

			// Token: 0x0600AE36 RID: 44598 RVA: 0x00307A5C File Offset: 0x00305C5C
			public void HideTeamReadyWait()
			{
				this.m_owner.HideTeamReadyWait();
			}

			// Token: 0x0600AE37 RID: 44599 RVA: 0x00307A6C File Offset: 0x00305C6C
			public void OnPauseButtonClick()
			{
				this.m_owner.OnPauseButtonClick();
			}

			// Token: 0x0600AE38 RID: 44600 RVA: 0x00307A7C File Offset: 0x00305C7C
			public void OnArmyRelationButtonClick()
			{
				this.m_owner.OnArmyRelationButtonClick();
			}

			// Token: 0x0600AE39 RID: 44601 RVA: 0x00307A8C File Offset: 0x00305C8C
			public void OnStartButtonClick()
			{
				this.m_owner.OnStartButtonClick();
			}

			// Token: 0x0600AE3A RID: 44602 RVA: 0x00307A9C File Offset: 0x00305C9C
			public void OnActionOrderButtonClick()
			{
				this.m_owner.OnActionOrderButtonClick();
			}

			// Token: 0x0600AE3B RID: 44603 RVA: 0x00307AAC File Offset: 0x00305CAC
			public void OnChatButtonClick()
			{
				this.m_owner.OnChatButtonClick();
			}

			// Token: 0x0600AE3C RID: 44604 RVA: 0x00307ABC File Offset: 0x00305CBC
			public void OnHelpButtonClick()
			{
				this.m_owner.OnHelpButtonClick();
			}

			// Token: 0x0600AE3D RID: 44605 RVA: 0x00307ACC File Offset: 0x00305CCC
			public void OnTestOnStageToggle(bool on)
			{
				this.m_owner.OnTestOnStageToggle(on);
			}

			// Token: 0x0600AE3E RID: 44606 RVA: 0x00307ADC File Offset: 0x00305CDC
			public void ClearPointerDownStageActor()
			{
				this.m_owner.ClearPointerDownStageActor();
			}

			// Token: 0x0600AE3F RID: 44607 RVA: 0x00307AEC File Offset: 0x00305CEC
			public void CreateDraggingHeroButton(BattleHero hero)
			{
				this.m_owner.CreateDraggingHeroButton(hero);
			}

			// Token: 0x0600AE40 RID: 44608 RVA: 0x00307AFC File Offset: 0x00305CFC
			public void DestroyDragginHeroButton()
			{
				this.m_owner.DestroyDragginHeroButton();
			}

			// Token: 0x0600AE41 RID: 44609 RVA: 0x00307B0C File Offset: 0x00305D0C
			public void MoveDraggingHeroButton(Vector2 pos)
			{
				this.m_owner.MoveDraggingHeroButton(pos);
			}

			// Token: 0x0600AE42 RID: 44610 RVA: 0x00307B1C File Offset: 0x00305D1C
			public void UpdateStageActorCount()
			{
				this.m_owner.UpdateStageActorCount();
			}

			// Token: 0x0600AE43 RID: 44611 RVA: 0x00307B2C File Offset: 0x00305D2C
			public void HideActorInfo()
			{
				this.m_owner.HideActorInfo();
			}

			// Token: 0x040071F1 RID: 29169
			private BattlePrepareUIController m_owner;
		}
	}
}
