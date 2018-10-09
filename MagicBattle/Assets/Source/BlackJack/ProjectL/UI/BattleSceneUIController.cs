using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000AC8 RID: 2760
	[HotFix]
	public class BattleSceneUIController : UIControllerBase, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IEventSystemHandler
	{
		// Token: 0x0600B2FD RID: 45821 RVA: 0x003174C8 File Offset: 0x003156C8
		private BattleSceneUIController()
		{
		}

		// Token: 0x0600B2FE RID: 45822 RVA: 0x00317554 File Offset: 0x00315754
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
			this.m_prefabsGameObject.SetActive(false);
		}

		// Token: 0x0600B2FF RID: 45823 RVA: 0x003175C8 File Offset: 0x003157C8
		public void Initialize(ClientBattle clientBattle, BattleMapUIController battleMapUIController)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitializeClientBattleBattleMapUIController_hotfix != null)
			{
				this.m_InitializeClientBattleBattleMapUIController_hotfix.call(new object[]
				{
					this,
					clientBattle,
					battleMapUIController
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_clientBattle = clientBattle;
			this.m_actionMarkGameObject.SetActive(false);
			this.m_actionMark2GameObject.SetActive(false);
			this.m_selectionMarkGameObject.SetActive(false);
			this.m_passiveSkillUIStateController.gameObject.SetActive(false);
			this.m_guardUIStateController.gameObject.SetActive(false);
			this.m_winConditionUIStateController.gameObject.SetActive(false);
			this.m_damageNumberPool.Setup(this.m_damageNumberPrefab, this.m_damageNumbersGameObject);
			this.m_damageNumberWeakPool.Setup(this.m_damageNumberWeakPrefab, this.m_damageNumbersGameObject);
			this.m_damageNumberStrongPool.Setup(this.m_damageNumberStrongPrefab, this.m_damageNumbersGameObject);
			this.m_damageNumberCriticalPool.Setup(this.m_damageNumberCriticalPrefab, this.m_damageNumbersGameObject);
			this.m_damageNumberSoldierPool.Setup(this.m_damageNumberSoldierPrefab, this.m_damageNumbersGameObject);
			this.m_healNumberPool.Setup(this.m_healNumberPrefab, this.m_damageNumbersGameObject);
			this.m_immunePool.Setup(this.m_immunePrefab, this.m_damageNumbersGameObject);
			this.m_targetIconPools = new GameObjectPool[6];
			this.m_targetIconPools[0] = new GameObjectPool();
			this.m_targetIconPools[0].Setup(this.m_target1Prefab, base.gameObject);
			this.m_targetIconPools[1] = new GameObjectPool();
			this.m_targetIconPools[1].Setup(this.m_target2Prefab, base.gameObject);
			this.m_targetIconPools[2] = new GameObjectPool();
			this.m_targetIconPools[2].Setup(this.m_target3Prefab, base.gameObject);
			this.m_targetIconPools[3] = new GameObjectPool();
			this.m_targetIconPools[3].Setup(this.m_target4Prefab, base.gameObject);
			this.m_targetIconPools[4] = new GameObjectPool();
			this.m_targetIconPools[4].Setup(this.m_target5Prefab, base.gameObject);
			this.m_targetIconPools[5] = new GameObjectPool();
			this.m_targetIconPools[5].Setup(this.m_target6Prefab, base.gameObject);
			this.m_canActionIconPool.Setup(this.m_canActionPrefab, base.gameObject);
			UIUtility.SetTweenIgnoreTimeScale(this.m_passiveSkillUIStateController.gameObject, false);
			UIUtility.SetTweenIgnoreTimeScale(this.m_guardUIStateController.gameObject, false);
			UIUtility.SetTweenIgnoreTimeScale(this.m_winConditionUIStateController.gameObject, false);
		}

		// Token: 0x0600B300 RID: 45824 RVA: 0x00317884 File Offset: 0x00315A84
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
		}

		// Token: 0x0600B301 RID: 45825 RVA: 0x003178E4 File Offset: 0x00315AE4
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
			this.m_damageNumberPool.Deactive();
			this.m_damageNumberWeakPool.Deactive();
			this.m_damageNumberStrongPool.Deactive();
			this.m_damageNumberCriticalPool.Deactive();
			this.m_damageNumberSoldierPool.Deactive();
			this.m_healNumberPool.Deactive();
			this.m_immunePool.Deactive();
			this.HideTargetIcons();
			this.m_actionMarkGameObject.SetActive(false);
			this.m_actionMark2GameObject.SetActive(false);
			this.m_selectionMarkGameObject.SetActive(false);
			this.m_passiveSkillUIStateController.gameObject.SetActive(false);
			this.m_guardUIStateController.gameObject.SetActive(false);
			this.m_winConditionUIStateController.gameObject.SetActive(false);
		}

		// Token: 0x0600B302 RID: 45826 RVA: 0x003179F0 File Offset: 0x00315BF0
		public void StopBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StopBattle_hotfix != null)
			{
				this.m_StopBattle_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideTargetIcons();
			this.m_actionMarkGameObject.SetActive(false);
			this.m_actionMark2GameObject.SetActive(false);
			this.m_selectionMarkGameObject.SetActive(false);
			this.m_passiveSkillUIStateController.gameObject.SetActive(false);
			this.m_guardUIStateController.gameObject.SetActive(false);
			this.m_winConditionUIStateController.gameObject.SetActive(false);
		}

		// Token: 0x0600B303 RID: 45827 RVA: 0x00317AB0 File Offset: 0x00315CB0
		public void ShowBattleWinCondition(ConfigDataBattleWinConditionInfo winConditionInfo, GridPosition targetPos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowBattleWinConditionConfigDataBattleWinConditionInfoGridPosition_hotfix != null)
			{
				this.m_ShowBattleWinConditionConfigDataBattleWinConditionInfoGridPosition_hotfix.call(new object[]
				{
					this,
					winConditionInfo,
					targetPos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_winConditionKillGameObject.SetActive(winConditionInfo.WinConditionType == BattleWinConditionType.BattleWinConditionType_KillActor);
			this.m_winConditionProtectGameObject.SetActive(winConditionInfo.WinConditionType == BattleWinConditionType.BattleWinConditionType_ActorNotDead);
			this.m_winConditionUIStateController.transform.localPosition = this.m_clientBattle.GridPositionToWorldPosition(targetPos);
			UIUtility.SetUIStateOpen(this.m_winConditionUIStateController, "Open", null, false, true);
		}

		// Token: 0x0600B304 RID: 45828 RVA: 0x00317B8C File Offset: 0x00315D8C
		public void HideBattleWinCondition(ConfigDataBattleWinConditionInfo winConditionInfo, GridPosition targetPos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideBattleWinConditionConfigDataBattleWinConditionInfoGridPosition_hotfix != null)
			{
				this.m_HideBattleWinConditionConfigDataBattleWinConditionInfoGridPosition_hotfix.call(new object[]
				{
					this,
					winConditionInfo,
					targetPos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_winConditionUIStateController, "Close", null, false, true);
		}

		// Token: 0x0600B305 RID: 45829 RVA: 0x00317C20 File Offset: 0x00315E20
		public void OnActorSkillHit(ClientBattleActor a, ConfigDataSkillInfo skillInfo, int heroHpModify, int soldierHpModify, DamageNumberType damageNumberType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnActorSkillHitClientBattleActorConfigDataSkillInfoInt32Int32DamageNumberType_hotfix != null)
			{
				this.m_OnActorSkillHitClientBattleActorConfigDataSkillInfoInt32Int32DamageNumberType_hotfix.call(new object[]
				{
					this,
					a,
					skillInfo,
					heroHpModify,
					soldierHpModify,
					damageNumberType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (a == null || skillInfo == null)
			{
				return;
			}
			if (skillInfo.IsBuffSkill() && heroHpModify == 0 && soldierHpModify == 0)
			{
				return;
			}
			this.ShowDamageNumbers(a, heroHpModify, soldierHpModify, damageNumberType);
		}

		// Token: 0x0600B306 RID: 45830 RVA: 0x00317D04 File Offset: 0x00315F04
		public void OnActorBuffHit(ClientBattleActor a, ConfigDataBuffInfo buffInfo, int heroHpModify, int soldierHpModify, DamageNumberType damageNumberType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnActorBuffHitClientBattleActorConfigDataBuffInfoInt32Int32DamageNumberType_hotfix != null)
			{
				this.m_OnActorBuffHitClientBattleActorConfigDataBuffInfoInt32Int32DamageNumberType_hotfix.call(new object[]
				{
					this,
					a,
					buffInfo,
					heroHpModify,
					soldierHpModify,
					damageNumberType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (a == null)
			{
				return;
			}
			this.ShowDamageNumbers(a, heroHpModify, soldierHpModify, damageNumberType);
		}

		// Token: 0x0600B307 RID: 45831 RVA: 0x00317DC8 File Offset: 0x00315FC8
		public void OnActorTerrainHit(ClientBattleActor a, ConfigDataTerrainInfo terrainInfo, int heroHpModify, int soldierHpModify, DamageNumberType damageNumberType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnActorTerrainHitClientBattleActorConfigDataTerrainInfoInt32Int32DamageNumberType_hotfix != null)
			{
				this.m_OnActorTerrainHitClientBattleActorConfigDataTerrainInfoInt32Int32DamageNumberType_hotfix.call(new object[]
				{
					this,
					a,
					terrainInfo,
					heroHpModify,
					soldierHpModify,
					damageNumberType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (a == null)
			{
				return;
			}
			this.ShowDamageNumbers(a, heroHpModify, soldierHpModify, damageNumberType);
		}

		// Token: 0x0600B308 RID: 45832 RVA: 0x00317E8C File Offset: 0x0031608C
		private void ShowDamageNumbers(ClientBattleActor a, int heroHpModify, int soldierHpModify, DamageNumberType damageNumberType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowDamageNumbersClientBattleActorInt32Int32DamageNumberType_hotfix != null)
			{
				this.m_ShowDamageNumbersClientBattleActorInt32Int32DamageNumberType_hotfix.call(new object[]
				{
					this,
					a,
					heroHpModify,
					soldierHpModify,
					damageNumberType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (damageNumberType == DamageNumberType.Heal)
			{
				if (soldierHpModify != heroHpModify)
				{
					if (soldierHpModify == 0 || heroHpModify == 0)
					{
						if (soldierHpModify != 0)
						{
							this.ShowDamangeNumber(a, soldierHpModify, damageNumberType, true);
						}
						else
						{
							this.ShowDamangeNumber(a, heroHpModify, damageNumberType, true);
						}
					}
					else
					{
						this.ShowDamangeNumber(a, soldierHpModify, damageNumberType, false);
						this.ShowDamangeNumber(a, heroHpModify, damageNumberType, true);
					}
				}
				else
				{
					this.ShowDamangeNumber(a, heroHpModify, damageNumberType, true);
				}
			}
			else
			{
				int hpModify = heroHpModify + soldierHpModify;
				this.ShowDamangeNumber(a, hpModify, damageNumberType, true);
			}
		}

		// Token: 0x0600B309 RID: 45833 RVA: 0x00317FA8 File Offset: 0x003161A8
		public void OnActorAttachImmune(ClientBattleActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnActorAttachImmuneClientBattleActor_hotfix != null)
			{
				this.m_OnActorAttachImmuneClientBattleActor_hotfix.call(new object[]
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
			Vector3 actorGraphicCenterPosition = this.GetActorGraphicCenterPosition(a);
			actorGraphicCenterPosition.y += 1f;
			DamageNumber damageNumber = this.m_immunePool.Allocate();
			damageNumber.transform.localPosition = actorGraphicCenterPosition;
			damageNumber.transform.SetAsLastSibling();
		}

		// Token: 0x0600B30A RID: 45834 RVA: 0x00318060 File Offset: 0x00316260
		public void OnActorPassiveSkill(ClientBattleActor a, BuffState sourceBuffState)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnActorPassiveSkillClientBattleActorBuffState_hotfix != null)
			{
				this.m_OnActorPassiveSkillClientBattleActorBuffState_hotfix.call(new object[]
				{
					this,
					a,
					sourceBuffState
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (a == null)
			{
				return;
			}
			if (sourceBuffState == null)
			{
				return;
			}
			Vector3 actorGraphicCenterPosition = this.GetActorGraphicCenterPosition(a);
			this.m_passiveSkillUIStateController.transform.localPosition = actorGraphicCenterPosition;
			UIUtility.SetUIStateOpenAndClose(this.m_passiveSkillUIStateController, "Open", "Close", null, false);
			if (sourceBuffState.m_sourceType == BuffSourceType.TalentPassiveSkill)
			{
				this.m_passiveSkillIconImage.gameObject.SetActive(false);
				this.m_passiveSkillTalentIconImage.gameObject.SetActive(true);
				this.m_passiveSkillTalentIconImage.sprite = AssetUtility.Instance.GetSprite(sourceBuffState.m_buffInfo.Icon);
			}
			else
			{
				this.m_passiveSkillIconImage.gameObject.SetActive(true);
				this.m_passiveSkillTalentIconImage.gameObject.SetActive(false);
				this.m_passiveSkillIconImage.sprite = AssetUtility.Instance.GetSprite(sourceBuffState.m_buffInfo.Icon);
			}
			this.m_passiveSkillNameText.text = sourceBuffState.m_buffInfo.Name;
		}

		// Token: 0x0600B30B RID: 45835 RVA: 0x003181CC File Offset: 0x003163CC
		public void OnActorGuard(ClientBattleActor a, ClientBattleActor target)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnActorGuardClientBattleActorClientBattleActor_hotfix != null)
			{
				this.m_OnActorGuardClientBattleActorClientBattleActor_hotfix.call(new object[]
				{
					this,
					a,
					target
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (a == null || target == null)
			{
				return;
			}
			Vector3 actorGraphicCenterPosition = this.GetActorGraphicCenterPosition(target);
			this.m_guardUIStateController.transform.localPosition = actorGraphicCenterPosition;
			UIUtility.SetUIStateOpenAndClose(this.m_guardUIStateController, "Open", "Close", null, false);
		}

		// Token: 0x0600B30C RID: 45836 RVA: 0x0031828C File Offset: 0x0031648C
		public void OnActorCombatDamage(ClientBattleActor a, int heroDamage, int soldierDamage)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnActorCombatDamageClientBattleActorInt32Int32_hotfix != null)
			{
				this.m_OnActorCombatDamageClientBattleActorInt32Int32_hotfix.call(new object[]
				{
					this,
					a,
					heroDamage,
					soldierDamage
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = heroDamage + soldierDamage;
			if (num > 0)
			{
				this.ShowDamangeNumber(a, -num, DamageNumberType.Normal, true);
			}
		}

		// Token: 0x0600B30D RID: 45837 RVA: 0x00318334 File Offset: 0x00316534
		private void ShowDamangeNumber(ClientBattleActor a, int hpModify, DamageNumberType damageNumberType, bool isHero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowDamangeNumberClientBattleActorInt32DamageNumberTypeBoolean_hotfix != null)
			{
				this.m_ShowDamangeNumberClientBattleActorInt32DamageNumberTypeBoolean_hotfix.call(new object[]
				{
					this,
					a,
					hpModify,
					damageNumberType,
					isHero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (a == null)
			{
				return;
			}
			Vector3 actorGraphicCenterPosition = this.GetActorGraphicCenterPosition(a);
			if (isHero)
			{
				actorGraphicCenterPosition.y += 1f;
			}
			else
			{
				actorGraphicCenterPosition.y += 0.15f;
			}
			int number = Mathf.Abs(hpModify);
			DamageNumber damageNumber;
			if (damageNumberType == DamageNumberType.Heal)
			{
				damageNumber = this.m_healNumberPool.Allocate();
				damageNumber.SetNumber(number);
			}
			else
			{
				if (isHero)
				{
					if (damageNumberType == DamageNumberType.Weak)
					{
						damageNumber = this.m_damageNumberWeakPool.Allocate();
					}
					else if (damageNumberType == DamageNumberType.Strong)
					{
						damageNumber = this.m_damageNumberStrongPool.Allocate();
					}
					else if (damageNumberType == DamageNumberType.Critical)
					{
						damageNumber = this.m_damageNumberCriticalPool.Allocate();
					}
					else
					{
						damageNumber = this.m_damageNumberPool.Allocate();
					}
				}
				else
				{
					damageNumber = this.m_damageNumberSoldierPool.Allocate();
				}
				damageNumber.SetNumber(number);
			}
			damageNumber.transform.localPosition = actorGraphicCenterPosition;
			damageNumber.transform.SetAsLastSibling();
		}

		// Token: 0x0600B30E RID: 45838 RVA: 0x003184C8 File Offset: 0x003166C8
		public void SetActiveActor(ClientBattleActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetActiveActorClientBattleActor_hotfix != null)
			{
				this.m_SetActiveActorClientBattleActor_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600B30F RID: 45839 RVA: 0x00318538 File Offset: 0x00316738
		public void ShowSelectionMark(GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowSelectionMarkGridPosition_hotfix != null)
			{
				this.m_ShowSelectionMarkGridPosition_hotfix.call(new object[]
				{
					this,
					p
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_selectionMarkGameObject.SetActive(true);
			this.m_selectionMarkGameObject.transform.localPosition = this.m_clientBattle.GridPositionToWorldPosition(p);
		}

		// Token: 0x0600B310 RID: 45840 RVA: 0x003185D8 File Offset: 0x003167D8
		public void HideSelectionMark()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideSelectionMark_hotfix != null)
			{
				this.m_HideSelectionMark_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_selectionMarkGameObject.SetActive(false);
		}

		// Token: 0x0600B311 RID: 45841 RVA: 0x00318644 File Offset: 0x00316844
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
			if (this.m_clientBattle == null)
			{
				return;
			}
			float deltaTime = Time.deltaTime;
			if (this.m_hideTargetIconTime > 0f)
			{
				this.m_hideTargetIconTime -= deltaTime;
				if (this.m_hideTargetIconTime <= 0f)
				{
					this.HideTargetIcons();
				}
			}
			this.Update3DTouch();
		}

		// Token: 0x0600B312 RID: 45842 RVA: 0x003186F0 File Offset: 0x003168F0
		private void Update3DTouch()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Update3DTouch_hotfix != null)
			{
				this.m_Update3DTouch_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_downPointerId != -1000 && Input.touchCount > 0 && Input.touchPressureSupported)
			{
				for (int i = 0; i < Input.touchCount; i++)
				{
					Touch touch = Input.GetTouch(i);
					if (touch.fingerId == this.m_downPointerId && touch.pressure > 5f && this.EventOn3DTouch != null && !this.m_is3DTouchTriggered)
					{
						this.m_is3DTouchTriggered = true;
						this.m_clickPointerId = -1000;
						this.EventOn3DTouch(touch.position);
					}
				}
			}
			else
			{
				this.m_is3DTouchTriggered = false;
			}
		}

		// Token: 0x0600B313 RID: 45843 RVA: 0x003187FC File Offset: 0x003169FC
		private Vector3 GetActorGraphicCenterPosition(ClientBattleActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetActorGraphicCenterPositionClientBattleActor_hotfix != null)
			{
				return (Vector3)this.m_GetActorGraphicCenterPositionClientBattleActor_hotfix.call(new object[]
				{
					this,
					a
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (a == null)
			{
				return Vector3.zero;
			}
			Vector3 result = a.GetGraphicPosition();
			result.z = 0f;
			return result;
		}

		// Token: 0x0600B314 RID: 45844 RVA: 0x003188A0 File Offset: 0x00316AA0
		public void ShowTargetIcons(List<GridPosition> positions, List<int> armyRelationValues, ConfigDataSkillInfo skillInfo, GridPosition startPos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowTargetIconsList`1List`1ConfigDataSkillInfoGridPosition_hotfix != null)
			{
				this.m_ShowTargetIconsList`1List`1ConfigDataSkillInfoGridPosition_hotfix.call(new object[]
				{
					this,
					positions,
					armyRelationValues,
					skillInfo,
					startPos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideTargetIcons();
			for (int i = 0; i < positions.Count; i++)
			{
				GameObject gameObject = this.AllocateTargetIcon(skillInfo, (armyRelationValues == null) ? 0 : armyRelationValues[i]);
				if (gameObject != null)
				{
					gameObject.transform.localPosition = this.m_clientBattle.GridPositionToWorldPosition(positions[i]);
				}
			}
		}

		// Token: 0x0600B315 RID: 45845 RVA: 0x003189A8 File Offset: 0x00316BA8
		public void ShowTargetIcon(GridPosition pos, int armyRelationValue, ConfigDataSkillInfo skillInfo, float time)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowTargetIconGridPositionInt32ConfigDataSkillInfoSingle_hotfix != null)
			{
				this.m_ShowTargetIconGridPositionInt32ConfigDataSkillInfoSingle_hotfix.call(new object[]
				{
					this,
					pos,
					armyRelationValue,
					skillInfo,
					time
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideTargetIcons();
			GameObject gameObject = this.AllocateTargetIcon(skillInfo, armyRelationValue);
			if (gameObject != null)
			{
				gameObject.transform.localPosition = this.m_clientBattle.GridPositionToWorldPosition(pos);
			}
			this.m_hideTargetIconTime = time;
		}

		// Token: 0x0600B316 RID: 45846 RVA: 0x00318A88 File Offset: 0x00316C88
		public void HideTargetIcons()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideTargetIcons_hotfix != null)
			{
				this.m_HideTargetIcons_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (GameObjectPool gameObjectPool in this.m_targetIconPools)
			{
				gameObjectPool.Deactive();
			}
			this.m_hideTargetIconTime = 0f;
		}

		// Token: 0x0600B317 RID: 45847 RVA: 0x00318B18 File Offset: 0x00316D18
		private GameObject AllocateTargetIcon(ConfigDataSkillInfo skillInfo, int armyRelationValue)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AllocateTargetIconConfigDataSkillInfoInt32_hotfix != null)
			{
				return (GameObject)this.m_AllocateTargetIconConfigDataSkillInfoInt32_hotfix.call(new object[]
				{
					this,
					skillInfo,
					armyRelationValue
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectPool gameObjectPool = this.m_targetIconPools[0];
			if (skillInfo != null)
			{
				if (skillInfo.SkillType == SkillType.SkillType_BF_MagicDamage)
				{
					gameObjectPool = this.m_targetIconPools[3];
				}
				else if (skillInfo.IsHealSkill() || skillInfo.IsTeleportSkill() || skillInfo.IsSummonSkill())
				{
					gameObjectPool = this.m_targetIconPools[4];
				}
				else
				{
					gameObjectPool = this.m_targetIconPools[5];
				}
			}
			else if (armyRelationValue == 0)
			{
				gameObjectPool = this.m_targetIconPools[0];
			}
			else if (armyRelationValue < 0)
			{
				gameObjectPool = this.m_targetIconPools[1];
			}
			else if (armyRelationValue > 0)
			{
				gameObjectPool = this.m_targetIconPools[2];
			}
			if (gameObjectPool != null)
			{
				return gameObjectPool.Allocate();
			}
			return null;
		}

		// Token: 0x0600B318 RID: 45848 RVA: 0x00318C54 File Offset: 0x00316E54
		public void ShowCanActionIcons(List<GridPosition> positions)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowCanActionIconsList`1_hotfix != null)
			{
				this.m_ShowCanActionIconsList`1_hotfix.call(new object[]
				{
					this,
					positions
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideCanActionIcons();
			for (int i = 0; i < positions.Count; i++)
			{
				GameObject gameObject = this.m_canActionIconPool.Allocate();
				gameObject.transform.localPosition = this.m_clientBattle.GridPositionToWorldPosition(positions[i]);
			}
		}

		// Token: 0x0600B319 RID: 45849 RVA: 0x00318D10 File Offset: 0x00316F10
		public void HideCanActionIcons()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideCanActionIcons_hotfix != null)
			{
				this.m_HideCanActionIcons_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_canActionIconPool.Deactive();
		}

		// Token: 0x0600B31A RID: 45850 RVA: 0x00318D7C File Offset: 0x00316F7C
		private Vector3 GridPositionToMapPosition(GridPosition p, float z)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GridPositionToMapPositionGridPositionSingle_hotfix != null)
			{
				return (Vector3)this.m_GridPositionToMapPositionGridPositionSingle_hotfix.call(new object[]
				{
					this,
					p,
					z
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return new Vector3((float)p.x * 2f, (float)(-(float)p.y) * 2f, z);
		}

		// Token: 0x0600B31B RID: 45851 RVA: 0x00318E2C File Offset: 0x0031702C
		public void OnPointerDown(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPointerDownPointerEventData_hotfix != null)
			{
				this.m_OnPointerDownPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_downPointerId != -1000)
			{
				return;
			}
			this.m_downPointerId = (this.m_clickPointerId = eventData.pointerId);
			if (this.EventOnPointerDown != null)
			{
				this.EventOnPointerDown(eventData);
			}
		}

		// Token: 0x0600B31C RID: 45852 RVA: 0x00318EDC File Offset: 0x003170DC
		public void OnPointerUp(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPointerUpPointerEventData_hotfix != null)
			{
				this.m_OnPointerUpPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (eventData.pointerId != this.m_downPointerId)
			{
				return;
			}
			this.m_downPointerId = -1000;
			if (this.EventOnPointerUp != null)
			{
				this.EventOnPointerUp(eventData);
			}
		}

		// Token: 0x0600B31D RID: 45853 RVA: 0x00318F80 File Offset: 0x00317180
		public void OnPointerClick(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPointerClickPointerEventData_hotfix != null)
			{
				this.m_OnPointerClickPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (eventData.pointerId != this.m_clickPointerId)
			{
				return;
			}
			this.m_clickPointerId = -1000;
			if (this.EventOnPointerClick != null)
			{
				this.EventOnPointerClick(eventData);
			}
		}

		// Token: 0x0600B31E RID: 45854 RVA: 0x00319024 File Offset: 0x00317224
		public void OnBeginDrag(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBeginDragPointerEventData_hotfix != null)
			{
				this.m_OnBeginDragPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (eventData.pointerId != this.m_downPointerId)
			{
				return;
			}
			this.m_dragPointerId = eventData.pointerId;
			if (this.EventOnBeginDrag != null)
			{
				this.EventOnBeginDrag(eventData);
			}
		}

		// Token: 0x0600B31F RID: 45855 RVA: 0x003190CC File Offset: 0x003172CC
		public void OnEndDrag(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEndDragPointerEventData_hotfix != null)
			{
				this.m_OnEndDragPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (eventData.pointerId != this.m_dragPointerId)
			{
				return;
			}
			this.m_dragPointerId = -1000;
			if (this.EventOnEndDrag != null)
			{
				this.EventOnEndDrag(eventData);
			}
		}

		// Token: 0x0600B320 RID: 45856 RVA: 0x00319170 File Offset: 0x00317370
		public void OnDrag(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDragPointerEventData_hotfix != null)
			{
				this.m_OnDragPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (eventData.pointerId != this.m_dragPointerId)
			{
				return;
			}
			if (this.EventOnDrag != null)
			{
				this.EventOnDrag(eventData);
			}
		}

		// Token: 0x1400021C RID: 540
		// (add) Token: 0x0600B321 RID: 45857 RVA: 0x0031920C File Offset: 0x0031740C
		// (remove) Token: 0x0600B322 RID: 45858 RVA: 0x003192A8 File Offset: 0x003174A8
		public event Action<PointerEventData> EventOnPointerDown
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnPointerDownAction`1_hotfix != null)
				{
					this.m_add_EventOnPointerDownAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnPointerDown;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnPointerDown, (Action<PointerEventData>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnPointerDownAction`1_hotfix != null)
				{
					this.m_remove_EventOnPointerDownAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnPointerDown;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnPointerDown, (Action<PointerEventData>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400021D RID: 541
		// (add) Token: 0x0600B323 RID: 45859 RVA: 0x00319344 File Offset: 0x00317544
		// (remove) Token: 0x0600B324 RID: 45860 RVA: 0x003193E0 File Offset: 0x003175E0
		public event Action<PointerEventData> EventOnPointerUp
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnPointerUpAction`1_hotfix != null)
				{
					this.m_add_EventOnPointerUpAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnPointerUp;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnPointerUp, (Action<PointerEventData>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnPointerUpAction`1_hotfix != null)
				{
					this.m_remove_EventOnPointerUpAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnPointerUp;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnPointerUp, (Action<PointerEventData>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400021E RID: 542
		// (add) Token: 0x0600B325 RID: 45861 RVA: 0x0031947C File Offset: 0x0031767C
		// (remove) Token: 0x0600B326 RID: 45862 RVA: 0x00319518 File Offset: 0x00317718
		public event Action<PointerEventData> EventOnPointerClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnPointerClickAction`1_hotfix != null)
				{
					this.m_add_EventOnPointerClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnPointerClick;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnPointerClick, (Action<PointerEventData>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnPointerClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnPointerClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnPointerClick;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnPointerClick, (Action<PointerEventData>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400021F RID: 543
		// (add) Token: 0x0600B327 RID: 45863 RVA: 0x003195B4 File Offset: 0x003177B4
		// (remove) Token: 0x0600B328 RID: 45864 RVA: 0x00319650 File Offset: 0x00317850
		public event Action<PointerEventData> EventOnBeginDrag
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnBeginDragAction`1_hotfix != null)
				{
					this.m_add_EventOnBeginDragAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnBeginDrag;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnBeginDrag, (Action<PointerEventData>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnBeginDragAction`1_hotfix != null)
				{
					this.m_remove_EventOnBeginDragAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnBeginDrag;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnBeginDrag, (Action<PointerEventData>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000220 RID: 544
		// (add) Token: 0x0600B329 RID: 45865 RVA: 0x003196EC File Offset: 0x003178EC
		// (remove) Token: 0x0600B32A RID: 45866 RVA: 0x00319788 File Offset: 0x00317988
		public event Action<PointerEventData> EventOnEndDrag
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnEndDragAction`1_hotfix != null)
				{
					this.m_add_EventOnEndDragAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnEndDrag;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnEndDrag, (Action<PointerEventData>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnEndDragAction`1_hotfix != null)
				{
					this.m_remove_EventOnEndDragAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnEndDrag;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnEndDrag, (Action<PointerEventData>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000221 RID: 545
		// (add) Token: 0x0600B32B RID: 45867 RVA: 0x00319824 File Offset: 0x00317A24
		// (remove) Token: 0x0600B32C RID: 45868 RVA: 0x003198C0 File Offset: 0x00317AC0
		public event Action<PointerEventData> EventOnDrag
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnDragAction`1_hotfix != null)
				{
					this.m_add_EventOnDragAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnDrag;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnDrag, (Action<PointerEventData>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnDragAction`1_hotfix != null)
				{
					this.m_remove_EventOnDragAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnDrag;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnDrag, (Action<PointerEventData>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000222 RID: 546
		// (add) Token: 0x0600B32D RID: 45869 RVA: 0x0031995C File Offset: 0x00317B5C
		// (remove) Token: 0x0600B32E RID: 45870 RVA: 0x003199F8 File Offset: 0x00317BF8
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

		// Token: 0x1700243D RID: 9277
		// (get) Token: 0x0600B32F RID: 45871 RVA: 0x00319A94 File Offset: 0x00317C94
		// (set) Token: 0x0600B330 RID: 45872 RVA: 0x00319AB4 File Offset: 0x00317CB4
		[DoNotToLua]
		public new BattleSceneUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleSceneUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600B331 RID: 45873 RVA: 0x00319AC0 File Offset: 0x00317CC0
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600B332 RID: 45874 RVA: 0x00319ACC File Offset: 0x00317CCC
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600B333 RID: 45875 RVA: 0x00319AD4 File Offset: 0x00317CD4
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600B334 RID: 45876 RVA: 0x00319ADC File Offset: 0x00317CDC
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600B335 RID: 45877 RVA: 0x00319AF0 File Offset: 0x00317CF0
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600B336 RID: 45878 RVA: 0x00319AF8 File Offset: 0x00317CF8
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600B337 RID: 45879 RVA: 0x00319B04 File Offset: 0x00317D04
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600B338 RID: 45880 RVA: 0x00319B10 File Offset: 0x00317D10
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600B339 RID: 45881 RVA: 0x00319B1C File Offset: 0x00317D1C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600B33A RID: 45882 RVA: 0x00319B28 File Offset: 0x00317D28
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600B33B RID: 45883 RVA: 0x00319B34 File Offset: 0x00317D34
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600B33C RID: 45884 RVA: 0x00319B40 File Offset: 0x00317D40
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600B33D RID: 45885 RVA: 0x00319B4C File Offset: 0x00317D4C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600B33E RID: 45886 RVA: 0x00319B58 File Offset: 0x00317D58
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600B33F RID: 45887 RVA: 0x00319B64 File Offset: 0x00317D64
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600B340 RID: 45888 RVA: 0x00319B6C File Offset: 0x00317D6C
		private void __callDele_EventOnPointerDown(PointerEventData obj)
		{
			Action<PointerEventData> eventOnPointerDown = this.EventOnPointerDown;
			if (eventOnPointerDown != null)
			{
				eventOnPointerDown(obj);
			}
		}

		// Token: 0x0600B341 RID: 45889 RVA: 0x00319B90 File Offset: 0x00317D90
		private void __clearDele_EventOnPointerDown(PointerEventData obj)
		{
			this.EventOnPointerDown = null;
		}

		// Token: 0x0600B342 RID: 45890 RVA: 0x00319B9C File Offset: 0x00317D9C
		private void __callDele_EventOnPointerUp(PointerEventData obj)
		{
			Action<PointerEventData> eventOnPointerUp = this.EventOnPointerUp;
			if (eventOnPointerUp != null)
			{
				eventOnPointerUp(obj);
			}
		}

		// Token: 0x0600B343 RID: 45891 RVA: 0x00319BC0 File Offset: 0x00317DC0
		private void __clearDele_EventOnPointerUp(PointerEventData obj)
		{
			this.EventOnPointerUp = null;
		}

		// Token: 0x0600B344 RID: 45892 RVA: 0x00319BCC File Offset: 0x00317DCC
		private void __callDele_EventOnPointerClick(PointerEventData obj)
		{
			Action<PointerEventData> eventOnPointerClick = this.EventOnPointerClick;
			if (eventOnPointerClick != null)
			{
				eventOnPointerClick(obj);
			}
		}

		// Token: 0x0600B345 RID: 45893 RVA: 0x00319BF0 File Offset: 0x00317DF0
		private void __clearDele_EventOnPointerClick(PointerEventData obj)
		{
			this.EventOnPointerClick = null;
		}

		// Token: 0x0600B346 RID: 45894 RVA: 0x00319BFC File Offset: 0x00317DFC
		private void __callDele_EventOnBeginDrag(PointerEventData obj)
		{
			Action<PointerEventData> eventOnBeginDrag = this.EventOnBeginDrag;
			if (eventOnBeginDrag != null)
			{
				eventOnBeginDrag(obj);
			}
		}

		// Token: 0x0600B347 RID: 45895 RVA: 0x00319C20 File Offset: 0x00317E20
		private void __clearDele_EventOnBeginDrag(PointerEventData obj)
		{
			this.EventOnBeginDrag = null;
		}

		// Token: 0x0600B348 RID: 45896 RVA: 0x00319C2C File Offset: 0x00317E2C
		private void __callDele_EventOnEndDrag(PointerEventData obj)
		{
			Action<PointerEventData> eventOnEndDrag = this.EventOnEndDrag;
			if (eventOnEndDrag != null)
			{
				eventOnEndDrag(obj);
			}
		}

		// Token: 0x0600B349 RID: 45897 RVA: 0x00319C50 File Offset: 0x00317E50
		private void __clearDele_EventOnEndDrag(PointerEventData obj)
		{
			this.EventOnEndDrag = null;
		}

		// Token: 0x0600B34A RID: 45898 RVA: 0x00319C5C File Offset: 0x00317E5C
		private void __callDele_EventOnDrag(PointerEventData obj)
		{
			Action<PointerEventData> eventOnDrag = this.EventOnDrag;
			if (eventOnDrag != null)
			{
				eventOnDrag(obj);
			}
		}

		// Token: 0x0600B34B RID: 45899 RVA: 0x00319C80 File Offset: 0x00317E80
		private void __clearDele_EventOnDrag(PointerEventData obj)
		{
			this.EventOnDrag = null;
		}

		// Token: 0x0600B34C RID: 45900 RVA: 0x00319C8C File Offset: 0x00317E8C
		private void __callDele_EventOn3DTouch(Vector2 obj)
		{
			Action<Vector2> eventOn3DTouch = this.EventOn3DTouch;
			if (eventOn3DTouch != null)
			{
				eventOn3DTouch(obj);
			}
		}

		// Token: 0x0600B34D RID: 45901 RVA: 0x00319CB0 File Offset: 0x00317EB0
		private void __clearDele_EventOn3DTouch(Vector2 obj)
		{
			this.EventOn3DTouch = null;
		}

		// Token: 0x0600B34E RID: 45902 RVA: 0x00319CBC File Offset: 0x00317EBC
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
					this.m_InitializeClientBattleBattleMapUIController_hotfix = (luaObj.RawGet("Initialize") as LuaFunction);
					this.m_PrepareBattle_hotfix = (luaObj.RawGet("PrepareBattle") as LuaFunction);
					this.m_StartBattle_hotfix = (luaObj.RawGet("StartBattle") as LuaFunction);
					this.m_StopBattle_hotfix = (luaObj.RawGet("StopBattle") as LuaFunction);
					this.m_ShowBattleWinConditionConfigDataBattleWinConditionInfoGridPosition_hotfix = (luaObj.RawGet("ShowBattleWinCondition") as LuaFunction);
					this.m_HideBattleWinConditionConfigDataBattleWinConditionInfoGridPosition_hotfix = (luaObj.RawGet("HideBattleWinCondition") as LuaFunction);
					this.m_OnActorSkillHitClientBattleActorConfigDataSkillInfoInt32Int32DamageNumberType_hotfix = (luaObj.RawGet("OnActorSkillHit") as LuaFunction);
					this.m_OnActorBuffHitClientBattleActorConfigDataBuffInfoInt32Int32DamageNumberType_hotfix = (luaObj.RawGet("OnActorBuffHit") as LuaFunction);
					this.m_OnActorTerrainHitClientBattleActorConfigDataTerrainInfoInt32Int32DamageNumberType_hotfix = (luaObj.RawGet("OnActorTerrainHit") as LuaFunction);
					this.m_ShowDamageNumbersClientBattleActorInt32Int32DamageNumberType_hotfix = (luaObj.RawGet("ShowDamageNumbers") as LuaFunction);
					this.m_OnActorAttachImmuneClientBattleActor_hotfix = (luaObj.RawGet("OnActorAttachImmune") as LuaFunction);
					this.m_OnActorPassiveSkillClientBattleActorBuffState_hotfix = (luaObj.RawGet("OnActorPassiveSkill") as LuaFunction);
					this.m_OnActorGuardClientBattleActorClientBattleActor_hotfix = (luaObj.RawGet("OnActorGuard") as LuaFunction);
					this.m_OnActorCombatDamageClientBattleActorInt32Int32_hotfix = (luaObj.RawGet("OnActorCombatDamage") as LuaFunction);
					this.m_ShowDamangeNumberClientBattleActorInt32DamageNumberTypeBoolean_hotfix = (luaObj.RawGet("ShowDamangeNumber") as LuaFunction);
					this.m_SetActiveActorClientBattleActor_hotfix = (luaObj.RawGet("SetActiveActor") as LuaFunction);
					this.m_ShowSelectionMarkGridPosition_hotfix = (luaObj.RawGet("ShowSelectionMark") as LuaFunction);
					this.m_HideSelectionMark_hotfix = (luaObj.RawGet("HideSelectionMark") as LuaFunction);
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_Update3DTouch_hotfix = (luaObj.RawGet("Update3DTouch") as LuaFunction);
					this.m_GetActorGraphicCenterPositionClientBattleActor_hotfix = (luaObj.RawGet("GetActorGraphicCenterPosition") as LuaFunction);
					this.m_ShowTargetIconsList`1List`1ConfigDataSkillInfoGridPosition_hotfix = (luaObj.RawGet("ShowTargetIcons") as LuaFunction);
					this.m_ShowTargetIconGridPositionInt32ConfigDataSkillInfoSingle_hotfix = (luaObj.RawGet("ShowTargetIcon") as LuaFunction);
					this.m_HideTargetIcons_hotfix = (luaObj.RawGet("HideTargetIcons") as LuaFunction);
					this.m_AllocateTargetIconConfigDataSkillInfoInt32_hotfix = (luaObj.RawGet("AllocateTargetIcon") as LuaFunction);
					this.m_ShowCanActionIconsList`1_hotfix = (luaObj.RawGet("ShowCanActionIcons") as LuaFunction);
					this.m_HideCanActionIcons_hotfix = (luaObj.RawGet("HideCanActionIcons") as LuaFunction);
					this.m_GridPositionToMapPositionGridPositionSingle_hotfix = (luaObj.RawGet("GridPositionToMapPosition") as LuaFunction);
					this.m_OnPointerDownPointerEventData_hotfix = (luaObj.RawGet("OnPointerDown") as LuaFunction);
					this.m_OnPointerUpPointerEventData_hotfix = (luaObj.RawGet("OnPointerUp") as LuaFunction);
					this.m_OnPointerClickPointerEventData_hotfix = (luaObj.RawGet("OnPointerClick") as LuaFunction);
					this.m_OnBeginDragPointerEventData_hotfix = (luaObj.RawGet("OnBeginDrag") as LuaFunction);
					this.m_OnEndDragPointerEventData_hotfix = (luaObj.RawGet("OnEndDrag") as LuaFunction);
					this.m_OnDragPointerEventData_hotfix = (luaObj.RawGet("OnDrag") as LuaFunction);
					this.m_add_EventOnPointerDownAction`1_hotfix = (luaObj.RawGet("add_EventOnPointerDown") as LuaFunction);
					this.m_remove_EventOnPointerDownAction`1_hotfix = (luaObj.RawGet("remove_EventOnPointerDown") as LuaFunction);
					this.m_add_EventOnPointerUpAction`1_hotfix = (luaObj.RawGet("add_EventOnPointerUp") as LuaFunction);
					this.m_remove_EventOnPointerUpAction`1_hotfix = (luaObj.RawGet("remove_EventOnPointerUp") as LuaFunction);
					this.m_add_EventOnPointerClickAction`1_hotfix = (luaObj.RawGet("add_EventOnPointerClick") as LuaFunction);
					this.m_remove_EventOnPointerClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnPointerClick") as LuaFunction);
					this.m_add_EventOnBeginDragAction`1_hotfix = (luaObj.RawGet("add_EventOnBeginDrag") as LuaFunction);
					this.m_remove_EventOnBeginDragAction`1_hotfix = (luaObj.RawGet("remove_EventOnBeginDrag") as LuaFunction);
					this.m_add_EventOnEndDragAction`1_hotfix = (luaObj.RawGet("add_EventOnEndDrag") as LuaFunction);
					this.m_remove_EventOnEndDragAction`1_hotfix = (luaObj.RawGet("remove_EventOnEndDrag") as LuaFunction);
					this.m_add_EventOnDragAction`1_hotfix = (luaObj.RawGet("add_EventOnDrag") as LuaFunction);
					this.m_remove_EventOnDragAction`1_hotfix = (luaObj.RawGet("remove_EventOnDrag") as LuaFunction);
					this.m_add_EventOn3DTouchAction`1_hotfix = (luaObj.RawGet("add_EventOn3DTouch") as LuaFunction);
					this.m_remove_EventOn3DTouchAction`1_hotfix = (luaObj.RawGet("remove_EventOn3DTouch") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600B34F RID: 45903 RVA: 0x0031A238 File Offset: 0x00318438
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleSceneUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400741F RID: 29727
		[AutoBind("./ActionMark", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_actionMarkGameObject;

		// Token: 0x04007420 RID: 29728
		[AutoBind("./ActionMark2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_actionMark2GameObject;

		// Token: 0x04007421 RID: 29729
		[AutoBind("./WinCondition", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_winConditionUIStateController;

		// Token: 0x04007422 RID: 29730
		[AutoBind("./WinCondition/Defeat", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_winConditionKillGameObject;

		// Token: 0x04007423 RID: 29731
		[AutoBind("./WinCondition/Protect", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_winConditionProtectGameObject;

		// Token: 0x04007424 RID: 29732
		[AutoBind("./SelectionMark", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_selectionMarkGameObject;

		// Token: 0x04007425 RID: 29733
		[AutoBind("./PassiveSkill", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_passiveSkillUIStateController;

		// Token: 0x04007426 RID: 29734
		[AutoBind("./PassiveSkill/Panel/IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_passiveSkillIconImage;

		// Token: 0x04007427 RID: 29735
		[AutoBind("./PassiveSkill/Panel/TalentIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_passiveSkillTalentIconImage;

		// Token: 0x04007428 RID: 29736
		[AutoBind("./PassiveSkill/Panel/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_passiveSkillNameText;

		// Token: 0x04007429 RID: 29737
		[AutoBind("./Guard", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_guardUIStateController;

		// Token: 0x0400742A RID: 29738
		[AutoBind("./DamageNumbers", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_damageNumbersGameObject;

		// Token: 0x0400742B RID: 29739
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_prefabsGameObject;

		// Token: 0x0400742C RID: 29740
		[AutoBind("./Prefabs/DamageNumber", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_damageNumberPrefab;

		// Token: 0x0400742D RID: 29741
		[AutoBind("./Prefabs/DamageNumberWeak", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_damageNumberWeakPrefab;

		// Token: 0x0400742E RID: 29742
		[AutoBind("./Prefabs/DamageNumberStrong", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_damageNumberStrongPrefab;

		// Token: 0x0400742F RID: 29743
		[AutoBind("./Prefabs/DamageNumberCritical", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_damageNumberCriticalPrefab;

		// Token: 0x04007430 RID: 29744
		[AutoBind("./Prefabs/DamageNumberSoldier", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_damageNumberSoldierPrefab;

		// Token: 0x04007431 RID: 29745
		[AutoBind("./Prefabs/HealNumber", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_healNumberPrefab;

		// Token: 0x04007432 RID: 29746
		[AutoBind("./Prefabs/Immune", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_immunePrefab;

		// Token: 0x04007433 RID: 29747
		[AutoBind("./Prefabs/Target1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_target1Prefab;

		// Token: 0x04007434 RID: 29748
		[AutoBind("./Prefabs/Target2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_target2Prefab;

		// Token: 0x04007435 RID: 29749
		[AutoBind("./Prefabs/Target3", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_target3Prefab;

		// Token: 0x04007436 RID: 29750
		[AutoBind("./Prefabs/Target4", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_target4Prefab;

		// Token: 0x04007437 RID: 29751
		[AutoBind("./Prefabs/Target5", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_target5Prefab;

		// Token: 0x04007438 RID: 29752
		[AutoBind("./Prefabs/Target6", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_target6Prefab;

		// Token: 0x04007439 RID: 29753
		[AutoBind("./Prefabs/CanAction", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_canActionPrefab;

		// Token: 0x0400743A RID: 29754
		private ClientBattle m_clientBattle;

		// Token: 0x0400743B RID: 29755
		private GameObjectPool<DamageNumber> m_damageNumberPool = new GameObjectPool<DamageNumber>();

		// Token: 0x0400743C RID: 29756
		private GameObjectPool<DamageNumber> m_damageNumberWeakPool = new GameObjectPool<DamageNumber>();

		// Token: 0x0400743D RID: 29757
		private GameObjectPool<DamageNumber> m_damageNumberStrongPool = new GameObjectPool<DamageNumber>();

		// Token: 0x0400743E RID: 29758
		private GameObjectPool<DamageNumber> m_damageNumberCriticalPool = new GameObjectPool<DamageNumber>();

		// Token: 0x0400743F RID: 29759
		private GameObjectPool<DamageNumber> m_damageNumberSoldierPool = new GameObjectPool<DamageNumber>();

		// Token: 0x04007440 RID: 29760
		private GameObjectPool<DamageNumber> m_healNumberPool = new GameObjectPool<DamageNumber>();

		// Token: 0x04007441 RID: 29761
		private GameObjectPool<DamageNumber> m_immunePool = new GameObjectPool<DamageNumber>();

		// Token: 0x04007442 RID: 29762
		private GameObjectPool[] m_targetIconPools;

		// Token: 0x04007443 RID: 29763
		private GameObjectPool m_canActionIconPool = new GameObjectPool();

		// Token: 0x04007444 RID: 29764
		private float m_hideTargetIconTime;

		// Token: 0x04007445 RID: 29765
		private const int InvalidPointerID = -1000;

		// Token: 0x04007446 RID: 29766
		private int m_downPointerId = -1000;

		// Token: 0x04007447 RID: 29767
		private int m_clickPointerId = -1000;

		// Token: 0x04007448 RID: 29768
		private int m_dragPointerId = -1000;

		// Token: 0x04007449 RID: 29769
		private bool m_is3DTouchTriggered;

		// Token: 0x0400744A RID: 29770
		[DoNotToLua]
		private BattleSceneUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400744B RID: 29771
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400744C RID: 29772
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400744D RID: 29773
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400744E RID: 29774
		private LuaFunction m_InitializeClientBattleBattleMapUIController_hotfix;

		// Token: 0x0400744F RID: 29775
		private LuaFunction m_PrepareBattle_hotfix;

		// Token: 0x04007450 RID: 29776
		private LuaFunction m_StartBattle_hotfix;

		// Token: 0x04007451 RID: 29777
		private LuaFunction m_StopBattle_hotfix;

		// Token: 0x04007452 RID: 29778
		private LuaFunction m_ShowBattleWinConditionConfigDataBattleWinConditionInfoGridPosition_hotfix;

		// Token: 0x04007453 RID: 29779
		private LuaFunction m_HideBattleWinConditionConfigDataBattleWinConditionInfoGridPosition_hotfix;

		// Token: 0x04007454 RID: 29780
		private LuaFunction m_OnActorSkillHitClientBattleActorConfigDataSkillInfoInt32Int32DamageNumberType_hotfix;

		// Token: 0x04007455 RID: 29781
		private LuaFunction m_OnActorBuffHitClientBattleActorConfigDataBuffInfoInt32Int32DamageNumberType_hotfix;

		// Token: 0x04007456 RID: 29782
		private LuaFunction m_OnActorTerrainHitClientBattleActorConfigDataTerrainInfoInt32Int32DamageNumberType_hotfix;

		// Token: 0x04007457 RID: 29783
		private LuaFunction m_ShowDamageNumbersClientBattleActorInt32Int32DamageNumberType_hotfix;

		// Token: 0x04007458 RID: 29784
		private LuaFunction m_OnActorAttachImmuneClientBattleActor_hotfix;

		// Token: 0x04007459 RID: 29785
		private LuaFunction m_OnActorPassiveSkillClientBattleActorBuffState_hotfix;

		// Token: 0x0400745A RID: 29786
		private LuaFunction m_OnActorGuardClientBattleActorClientBattleActor_hotfix;

		// Token: 0x0400745B RID: 29787
		private LuaFunction m_OnActorCombatDamageClientBattleActorInt32Int32_hotfix;

		// Token: 0x0400745C RID: 29788
		private LuaFunction m_ShowDamangeNumberClientBattleActorInt32DamageNumberTypeBoolean_hotfix;

		// Token: 0x0400745D RID: 29789
		private LuaFunction m_SetActiveActorClientBattleActor_hotfix;

		// Token: 0x0400745E RID: 29790
		private LuaFunction m_ShowSelectionMarkGridPosition_hotfix;

		// Token: 0x0400745F RID: 29791
		private LuaFunction m_HideSelectionMark_hotfix;

		// Token: 0x04007460 RID: 29792
		private LuaFunction m_Update_hotfix;

		// Token: 0x04007461 RID: 29793
		private LuaFunction m_Update3DTouch_hotfix;

		// Token: 0x04007462 RID: 29794
		private LuaFunction m_GetActorGraphicCenterPositionClientBattleActor_hotfix;

		// Token: 0x04007463 RID: 29795
		private LuaFunction m_ShowTargetIconsList`1List;

		// Token: 0x04007464 RID: 29796
		private LuaFunction m_ShowTargetIconGridPositionInt32ConfigDataSkillInfoSingle_hotfix;

		// Token: 0x04007465 RID: 29797
		private LuaFunction m_HideTargetIcons_hotfix;

		// Token: 0x04007466 RID: 29798
		private LuaFunction m_AllocateTargetIconConfigDataSkillInfoInt32_hotfix;

		// Token: 0x04007467 RID: 29799
		private LuaFunction m_ShowCanActionIconsList;

		// Token: 0x04007468 RID: 29800
		private LuaFunction m_HideCanActionIcons_hotfix;

		// Token: 0x04007469 RID: 29801
		private LuaFunction m_GridPositionToMapPositionGridPositionSingle_hotfix;

		// Token: 0x0400746A RID: 29802
		private LuaFunction m_OnPointerDownPointerEventData_hotfix;

		// Token: 0x0400746B RID: 29803
		private LuaFunction m_OnPointerUpPointerEventData_hotfix;

		// Token: 0x0400746C RID: 29804
		private LuaFunction m_OnPointerClickPointerEventData_hotfix;

		// Token: 0x0400746D RID: 29805
		private LuaFunction m_OnBeginDragPointerEventData_hotfix;

		// Token: 0x0400746E RID: 29806
		private LuaFunction m_OnEndDragPointerEventData_hotfix;

		// Token: 0x0400746F RID: 29807
		private LuaFunction m_OnDragPointerEventData_hotfix;

		// Token: 0x04007470 RID: 29808
		private LuaFunction m_add_EventOnPointerDownAction;

		// Token: 0x04007471 RID: 29809
		private LuaFunction m_remove_EventOnPointerDownAction;

		// Token: 0x04007472 RID: 29810
		private LuaFunction m_add_EventOnPointerUpAction;

		// Token: 0x04007473 RID: 29811
		private LuaFunction m_remove_EventOnPointerUpAction;

		// Token: 0x04007474 RID: 29812
		private LuaFunction m_add_EventOnPointerClickAction;

		// Token: 0x04007475 RID: 29813
		private LuaFunction m_remove_EventOnPointerClickAction;

		// Token: 0x04007476 RID: 29814
		private LuaFunction m_add_EventOnBeginDragAction;

		// Token: 0x04007477 RID: 29815
		private LuaFunction m_remove_EventOnBeginDragAction;

		// Token: 0x04007478 RID: 29816
		private LuaFunction m_add_EventOnEndDragAction;

		// Token: 0x04007479 RID: 29817
		private LuaFunction m_remove_EventOnEndDragAction;

		// Token: 0x0400747A RID: 29818
		private LuaFunction m_add_EventOnDragAction;

		// Token: 0x0400747B RID: 29819
		private LuaFunction m_remove_EventOnDragAction;

		// Token: 0x0400747C RID: 29820
		private LuaFunction m_add_EventOn3DTouchAction;

		// Token: 0x0400747D RID: 29821
		private LuaFunction m_remove_EventOn3DTouchAction;

		// Token: 0x02000AC9 RID: 2761
		public new class LuaExportHelper
		{
			// Token: 0x0600B350 RID: 45904 RVA: 0x0031A2A0 File Offset: 0x003184A0
			public LuaExportHelper(BattleSceneUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600B351 RID: 45905 RVA: 0x0031A2B0 File Offset: 0x003184B0
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600B352 RID: 45906 RVA: 0x0031A2C0 File Offset: 0x003184C0
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600B353 RID: 45907 RVA: 0x0031A2D0 File Offset: 0x003184D0
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600B354 RID: 45908 RVA: 0x0031A2E0 File Offset: 0x003184E0
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600B355 RID: 45909 RVA: 0x0031A2F8 File Offset: 0x003184F8
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600B356 RID: 45910 RVA: 0x0031A308 File Offset: 0x00318508
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600B357 RID: 45911 RVA: 0x0031A318 File Offset: 0x00318518
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600B358 RID: 45912 RVA: 0x0031A328 File Offset: 0x00318528
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600B359 RID: 45913 RVA: 0x0031A338 File Offset: 0x00318538
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600B35A RID: 45914 RVA: 0x0031A348 File Offset: 0x00318548
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600B35B RID: 45915 RVA: 0x0031A358 File Offset: 0x00318558
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600B35C RID: 45916 RVA: 0x0031A368 File Offset: 0x00318568
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600B35D RID: 45917 RVA: 0x0031A378 File Offset: 0x00318578
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600B35E RID: 45918 RVA: 0x0031A388 File Offset: 0x00318588
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600B35F RID: 45919 RVA: 0x0031A398 File Offset: 0x00318598
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600B360 RID: 45920 RVA: 0x0031A3A8 File Offset: 0x003185A8
			public void __callDele_EventOnPointerDown(PointerEventData obj)
			{
				this.m_owner.__callDele_EventOnPointerDown(obj);
			}

			// Token: 0x0600B361 RID: 45921 RVA: 0x0031A3B8 File Offset: 0x003185B8
			public void __clearDele_EventOnPointerDown(PointerEventData obj)
			{
				this.m_owner.__clearDele_EventOnPointerDown(obj);
			}

			// Token: 0x0600B362 RID: 45922 RVA: 0x0031A3C8 File Offset: 0x003185C8
			public void __callDele_EventOnPointerUp(PointerEventData obj)
			{
				this.m_owner.__callDele_EventOnPointerUp(obj);
			}

			// Token: 0x0600B363 RID: 45923 RVA: 0x0031A3D8 File Offset: 0x003185D8
			public void __clearDele_EventOnPointerUp(PointerEventData obj)
			{
				this.m_owner.__clearDele_EventOnPointerUp(obj);
			}

			// Token: 0x0600B364 RID: 45924 RVA: 0x0031A3E8 File Offset: 0x003185E8
			public void __callDele_EventOnPointerClick(PointerEventData obj)
			{
				this.m_owner.__callDele_EventOnPointerClick(obj);
			}

			// Token: 0x0600B365 RID: 45925 RVA: 0x0031A3F8 File Offset: 0x003185F8
			public void __clearDele_EventOnPointerClick(PointerEventData obj)
			{
				this.m_owner.__clearDele_EventOnPointerClick(obj);
			}

			// Token: 0x0600B366 RID: 45926 RVA: 0x0031A408 File Offset: 0x00318608
			public void __callDele_EventOnBeginDrag(PointerEventData obj)
			{
				this.m_owner.__callDele_EventOnBeginDrag(obj);
			}

			// Token: 0x0600B367 RID: 45927 RVA: 0x0031A418 File Offset: 0x00318618
			public void __clearDele_EventOnBeginDrag(PointerEventData obj)
			{
				this.m_owner.__clearDele_EventOnBeginDrag(obj);
			}

			// Token: 0x0600B368 RID: 45928 RVA: 0x0031A428 File Offset: 0x00318628
			public void __callDele_EventOnEndDrag(PointerEventData obj)
			{
				this.m_owner.__callDele_EventOnEndDrag(obj);
			}

			// Token: 0x0600B369 RID: 45929 RVA: 0x0031A438 File Offset: 0x00318638
			public void __clearDele_EventOnEndDrag(PointerEventData obj)
			{
				this.m_owner.__clearDele_EventOnEndDrag(obj);
			}

			// Token: 0x0600B36A RID: 45930 RVA: 0x0031A448 File Offset: 0x00318648
			public void __callDele_EventOnDrag(PointerEventData obj)
			{
				this.m_owner.__callDele_EventOnDrag(obj);
			}

			// Token: 0x0600B36B RID: 45931 RVA: 0x0031A458 File Offset: 0x00318658
			public void __clearDele_EventOnDrag(PointerEventData obj)
			{
				this.m_owner.__clearDele_EventOnDrag(obj);
			}

			// Token: 0x0600B36C RID: 45932 RVA: 0x0031A468 File Offset: 0x00318668
			public void __callDele_EventOn3DTouch(Vector2 obj)
			{
				this.m_owner.__callDele_EventOn3DTouch(obj);
			}

			// Token: 0x0600B36D RID: 45933 RVA: 0x0031A478 File Offset: 0x00318678
			public void __clearDele_EventOn3DTouch(Vector2 obj)
			{
				this.m_owner.__clearDele_EventOn3DTouch(obj);
			}

			// Token: 0x1700243E RID: 9278
			// (get) Token: 0x0600B36E RID: 45934 RVA: 0x0031A488 File Offset: 0x00318688
			// (set) Token: 0x0600B36F RID: 45935 RVA: 0x0031A498 File Offset: 0x00318698
			public GameObject m_actionMarkGameObject
			{
				get
				{
					return this.m_owner.m_actionMarkGameObject;
				}
				set
				{
					this.m_owner.m_actionMarkGameObject = value;
				}
			}

			// Token: 0x1700243F RID: 9279
			// (get) Token: 0x0600B370 RID: 45936 RVA: 0x0031A4A8 File Offset: 0x003186A8
			// (set) Token: 0x0600B371 RID: 45937 RVA: 0x0031A4B8 File Offset: 0x003186B8
			public GameObject m_actionMark2GameObject
			{
				get
				{
					return this.m_owner.m_actionMark2GameObject;
				}
				set
				{
					this.m_owner.m_actionMark2GameObject = value;
				}
			}

			// Token: 0x17002440 RID: 9280
			// (get) Token: 0x0600B372 RID: 45938 RVA: 0x0031A4C8 File Offset: 0x003186C8
			// (set) Token: 0x0600B373 RID: 45939 RVA: 0x0031A4D8 File Offset: 0x003186D8
			public CommonUIStateController m_winConditionUIStateController
			{
				get
				{
					return this.m_owner.m_winConditionUIStateController;
				}
				set
				{
					this.m_owner.m_winConditionUIStateController = value;
				}
			}

			// Token: 0x17002441 RID: 9281
			// (get) Token: 0x0600B374 RID: 45940 RVA: 0x0031A4E8 File Offset: 0x003186E8
			// (set) Token: 0x0600B375 RID: 45941 RVA: 0x0031A4F8 File Offset: 0x003186F8
			public GameObject m_winConditionKillGameObject
			{
				get
				{
					return this.m_owner.m_winConditionKillGameObject;
				}
				set
				{
					this.m_owner.m_winConditionKillGameObject = value;
				}
			}

			// Token: 0x17002442 RID: 9282
			// (get) Token: 0x0600B376 RID: 45942 RVA: 0x0031A508 File Offset: 0x00318708
			// (set) Token: 0x0600B377 RID: 45943 RVA: 0x0031A518 File Offset: 0x00318718
			public GameObject m_winConditionProtectGameObject
			{
				get
				{
					return this.m_owner.m_winConditionProtectGameObject;
				}
				set
				{
					this.m_owner.m_winConditionProtectGameObject = value;
				}
			}

			// Token: 0x17002443 RID: 9283
			// (get) Token: 0x0600B378 RID: 45944 RVA: 0x0031A528 File Offset: 0x00318728
			// (set) Token: 0x0600B379 RID: 45945 RVA: 0x0031A538 File Offset: 0x00318738
			public GameObject m_selectionMarkGameObject
			{
				get
				{
					return this.m_owner.m_selectionMarkGameObject;
				}
				set
				{
					this.m_owner.m_selectionMarkGameObject = value;
				}
			}

			// Token: 0x17002444 RID: 9284
			// (get) Token: 0x0600B37A RID: 45946 RVA: 0x0031A548 File Offset: 0x00318748
			// (set) Token: 0x0600B37B RID: 45947 RVA: 0x0031A558 File Offset: 0x00318758
			public CommonUIStateController m_passiveSkillUIStateController
			{
				get
				{
					return this.m_owner.m_passiveSkillUIStateController;
				}
				set
				{
					this.m_owner.m_passiveSkillUIStateController = value;
				}
			}

			// Token: 0x17002445 RID: 9285
			// (get) Token: 0x0600B37C RID: 45948 RVA: 0x0031A568 File Offset: 0x00318768
			// (set) Token: 0x0600B37D RID: 45949 RVA: 0x0031A578 File Offset: 0x00318778
			public Image m_passiveSkillIconImage
			{
				get
				{
					return this.m_owner.m_passiveSkillIconImage;
				}
				set
				{
					this.m_owner.m_passiveSkillIconImage = value;
				}
			}

			// Token: 0x17002446 RID: 9286
			// (get) Token: 0x0600B37E RID: 45950 RVA: 0x0031A588 File Offset: 0x00318788
			// (set) Token: 0x0600B37F RID: 45951 RVA: 0x0031A598 File Offset: 0x00318798
			public Image m_passiveSkillTalentIconImage
			{
				get
				{
					return this.m_owner.m_passiveSkillTalentIconImage;
				}
				set
				{
					this.m_owner.m_passiveSkillTalentIconImage = value;
				}
			}

			// Token: 0x17002447 RID: 9287
			// (get) Token: 0x0600B380 RID: 45952 RVA: 0x0031A5A8 File Offset: 0x003187A8
			// (set) Token: 0x0600B381 RID: 45953 RVA: 0x0031A5B8 File Offset: 0x003187B8
			public Text m_passiveSkillNameText
			{
				get
				{
					return this.m_owner.m_passiveSkillNameText;
				}
				set
				{
					this.m_owner.m_passiveSkillNameText = value;
				}
			}

			// Token: 0x17002448 RID: 9288
			// (get) Token: 0x0600B382 RID: 45954 RVA: 0x0031A5C8 File Offset: 0x003187C8
			// (set) Token: 0x0600B383 RID: 45955 RVA: 0x0031A5D8 File Offset: 0x003187D8
			public CommonUIStateController m_guardUIStateController
			{
				get
				{
					return this.m_owner.m_guardUIStateController;
				}
				set
				{
					this.m_owner.m_guardUIStateController = value;
				}
			}

			// Token: 0x17002449 RID: 9289
			// (get) Token: 0x0600B384 RID: 45956 RVA: 0x0031A5E8 File Offset: 0x003187E8
			// (set) Token: 0x0600B385 RID: 45957 RVA: 0x0031A5F8 File Offset: 0x003187F8
			public GameObject m_damageNumbersGameObject
			{
				get
				{
					return this.m_owner.m_damageNumbersGameObject;
				}
				set
				{
					this.m_owner.m_damageNumbersGameObject = value;
				}
			}

			// Token: 0x1700244A RID: 9290
			// (get) Token: 0x0600B386 RID: 45958 RVA: 0x0031A608 File Offset: 0x00318808
			// (set) Token: 0x0600B387 RID: 45959 RVA: 0x0031A618 File Offset: 0x00318818
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

			// Token: 0x1700244B RID: 9291
			// (get) Token: 0x0600B388 RID: 45960 RVA: 0x0031A628 File Offset: 0x00318828
			// (set) Token: 0x0600B389 RID: 45961 RVA: 0x0031A638 File Offset: 0x00318838
			public GameObject m_damageNumberPrefab
			{
				get
				{
					return this.m_owner.m_damageNumberPrefab;
				}
				set
				{
					this.m_owner.m_damageNumberPrefab = value;
				}
			}

			// Token: 0x1700244C RID: 9292
			// (get) Token: 0x0600B38A RID: 45962 RVA: 0x0031A648 File Offset: 0x00318848
			// (set) Token: 0x0600B38B RID: 45963 RVA: 0x0031A658 File Offset: 0x00318858
			public GameObject m_damageNumberWeakPrefab
			{
				get
				{
					return this.m_owner.m_damageNumberWeakPrefab;
				}
				set
				{
					this.m_owner.m_damageNumberWeakPrefab = value;
				}
			}

			// Token: 0x1700244D RID: 9293
			// (get) Token: 0x0600B38C RID: 45964 RVA: 0x0031A668 File Offset: 0x00318868
			// (set) Token: 0x0600B38D RID: 45965 RVA: 0x0031A678 File Offset: 0x00318878
			public GameObject m_damageNumberStrongPrefab
			{
				get
				{
					return this.m_owner.m_damageNumberStrongPrefab;
				}
				set
				{
					this.m_owner.m_damageNumberStrongPrefab = value;
				}
			}

			// Token: 0x1700244E RID: 9294
			// (get) Token: 0x0600B38E RID: 45966 RVA: 0x0031A688 File Offset: 0x00318888
			// (set) Token: 0x0600B38F RID: 45967 RVA: 0x0031A698 File Offset: 0x00318898
			public GameObject m_damageNumberCriticalPrefab
			{
				get
				{
					return this.m_owner.m_damageNumberCriticalPrefab;
				}
				set
				{
					this.m_owner.m_damageNumberCriticalPrefab = value;
				}
			}

			// Token: 0x1700244F RID: 9295
			// (get) Token: 0x0600B390 RID: 45968 RVA: 0x0031A6A8 File Offset: 0x003188A8
			// (set) Token: 0x0600B391 RID: 45969 RVA: 0x0031A6B8 File Offset: 0x003188B8
			public GameObject m_damageNumberSoldierPrefab
			{
				get
				{
					return this.m_owner.m_damageNumberSoldierPrefab;
				}
				set
				{
					this.m_owner.m_damageNumberSoldierPrefab = value;
				}
			}

			// Token: 0x17002450 RID: 9296
			// (get) Token: 0x0600B392 RID: 45970 RVA: 0x0031A6C8 File Offset: 0x003188C8
			// (set) Token: 0x0600B393 RID: 45971 RVA: 0x0031A6D8 File Offset: 0x003188D8
			public GameObject m_healNumberPrefab
			{
				get
				{
					return this.m_owner.m_healNumberPrefab;
				}
				set
				{
					this.m_owner.m_healNumberPrefab = value;
				}
			}

			// Token: 0x17002451 RID: 9297
			// (get) Token: 0x0600B394 RID: 45972 RVA: 0x0031A6E8 File Offset: 0x003188E8
			// (set) Token: 0x0600B395 RID: 45973 RVA: 0x0031A6F8 File Offset: 0x003188F8
			public GameObject m_immunePrefab
			{
				get
				{
					return this.m_owner.m_immunePrefab;
				}
				set
				{
					this.m_owner.m_immunePrefab = value;
				}
			}

			// Token: 0x17002452 RID: 9298
			// (get) Token: 0x0600B396 RID: 45974 RVA: 0x0031A708 File Offset: 0x00318908
			// (set) Token: 0x0600B397 RID: 45975 RVA: 0x0031A718 File Offset: 0x00318918
			public GameObject m_target1Prefab
			{
				get
				{
					return this.m_owner.m_target1Prefab;
				}
				set
				{
					this.m_owner.m_target1Prefab = value;
				}
			}

			// Token: 0x17002453 RID: 9299
			// (get) Token: 0x0600B398 RID: 45976 RVA: 0x0031A728 File Offset: 0x00318928
			// (set) Token: 0x0600B399 RID: 45977 RVA: 0x0031A738 File Offset: 0x00318938
			public GameObject m_target2Prefab
			{
				get
				{
					return this.m_owner.m_target2Prefab;
				}
				set
				{
					this.m_owner.m_target2Prefab = value;
				}
			}

			// Token: 0x17002454 RID: 9300
			// (get) Token: 0x0600B39A RID: 45978 RVA: 0x0031A748 File Offset: 0x00318948
			// (set) Token: 0x0600B39B RID: 45979 RVA: 0x0031A758 File Offset: 0x00318958
			public GameObject m_target3Prefab
			{
				get
				{
					return this.m_owner.m_target3Prefab;
				}
				set
				{
					this.m_owner.m_target3Prefab = value;
				}
			}

			// Token: 0x17002455 RID: 9301
			// (get) Token: 0x0600B39C RID: 45980 RVA: 0x0031A768 File Offset: 0x00318968
			// (set) Token: 0x0600B39D RID: 45981 RVA: 0x0031A778 File Offset: 0x00318978
			public GameObject m_target4Prefab
			{
				get
				{
					return this.m_owner.m_target4Prefab;
				}
				set
				{
					this.m_owner.m_target4Prefab = value;
				}
			}

			// Token: 0x17002456 RID: 9302
			// (get) Token: 0x0600B39E RID: 45982 RVA: 0x0031A788 File Offset: 0x00318988
			// (set) Token: 0x0600B39F RID: 45983 RVA: 0x0031A798 File Offset: 0x00318998
			public GameObject m_target5Prefab
			{
				get
				{
					return this.m_owner.m_target5Prefab;
				}
				set
				{
					this.m_owner.m_target5Prefab = value;
				}
			}

			// Token: 0x17002457 RID: 9303
			// (get) Token: 0x0600B3A0 RID: 45984 RVA: 0x0031A7A8 File Offset: 0x003189A8
			// (set) Token: 0x0600B3A1 RID: 45985 RVA: 0x0031A7B8 File Offset: 0x003189B8
			public GameObject m_target6Prefab
			{
				get
				{
					return this.m_owner.m_target6Prefab;
				}
				set
				{
					this.m_owner.m_target6Prefab = value;
				}
			}

			// Token: 0x17002458 RID: 9304
			// (get) Token: 0x0600B3A2 RID: 45986 RVA: 0x0031A7C8 File Offset: 0x003189C8
			// (set) Token: 0x0600B3A3 RID: 45987 RVA: 0x0031A7D8 File Offset: 0x003189D8
			public GameObject m_canActionPrefab
			{
				get
				{
					return this.m_owner.m_canActionPrefab;
				}
				set
				{
					this.m_owner.m_canActionPrefab = value;
				}
			}

			// Token: 0x17002459 RID: 9305
			// (get) Token: 0x0600B3A4 RID: 45988 RVA: 0x0031A7E8 File Offset: 0x003189E8
			// (set) Token: 0x0600B3A5 RID: 45989 RVA: 0x0031A7F8 File Offset: 0x003189F8
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

			// Token: 0x1700245A RID: 9306
			// (get) Token: 0x0600B3A6 RID: 45990 RVA: 0x0031A808 File Offset: 0x00318A08
			// (set) Token: 0x0600B3A7 RID: 45991 RVA: 0x0031A818 File Offset: 0x00318A18
			public GameObjectPool<DamageNumber> m_damageNumberPool
			{
				get
				{
					return this.m_owner.m_damageNumberPool;
				}
				set
				{
					this.m_owner.m_damageNumberPool = value;
				}
			}

			// Token: 0x1700245B RID: 9307
			// (get) Token: 0x0600B3A8 RID: 45992 RVA: 0x0031A828 File Offset: 0x00318A28
			// (set) Token: 0x0600B3A9 RID: 45993 RVA: 0x0031A838 File Offset: 0x00318A38
			public GameObjectPool<DamageNumber> m_damageNumberWeakPool
			{
				get
				{
					return this.m_owner.m_damageNumberWeakPool;
				}
				set
				{
					this.m_owner.m_damageNumberWeakPool = value;
				}
			}

			// Token: 0x1700245C RID: 9308
			// (get) Token: 0x0600B3AA RID: 45994 RVA: 0x0031A848 File Offset: 0x00318A48
			// (set) Token: 0x0600B3AB RID: 45995 RVA: 0x0031A858 File Offset: 0x00318A58
			public GameObjectPool<DamageNumber> m_damageNumberStrongPool
			{
				get
				{
					return this.m_owner.m_damageNumberStrongPool;
				}
				set
				{
					this.m_owner.m_damageNumberStrongPool = value;
				}
			}

			// Token: 0x1700245D RID: 9309
			// (get) Token: 0x0600B3AC RID: 45996 RVA: 0x0031A868 File Offset: 0x00318A68
			// (set) Token: 0x0600B3AD RID: 45997 RVA: 0x0031A878 File Offset: 0x00318A78
			public GameObjectPool<DamageNumber> m_damageNumberCriticalPool
			{
				get
				{
					return this.m_owner.m_damageNumberCriticalPool;
				}
				set
				{
					this.m_owner.m_damageNumberCriticalPool = value;
				}
			}

			// Token: 0x1700245E RID: 9310
			// (get) Token: 0x0600B3AE RID: 45998 RVA: 0x0031A888 File Offset: 0x00318A88
			// (set) Token: 0x0600B3AF RID: 45999 RVA: 0x0031A898 File Offset: 0x00318A98
			public GameObjectPool<DamageNumber> m_damageNumberSoldierPool
			{
				get
				{
					return this.m_owner.m_damageNumberSoldierPool;
				}
				set
				{
					this.m_owner.m_damageNumberSoldierPool = value;
				}
			}

			// Token: 0x1700245F RID: 9311
			// (get) Token: 0x0600B3B0 RID: 46000 RVA: 0x0031A8A8 File Offset: 0x00318AA8
			// (set) Token: 0x0600B3B1 RID: 46001 RVA: 0x0031A8B8 File Offset: 0x00318AB8
			public GameObjectPool<DamageNumber> m_healNumberPool
			{
				get
				{
					return this.m_owner.m_healNumberPool;
				}
				set
				{
					this.m_owner.m_healNumberPool = value;
				}
			}

			// Token: 0x17002460 RID: 9312
			// (get) Token: 0x0600B3B2 RID: 46002 RVA: 0x0031A8C8 File Offset: 0x00318AC8
			// (set) Token: 0x0600B3B3 RID: 46003 RVA: 0x0031A8D8 File Offset: 0x00318AD8
			public GameObjectPool<DamageNumber> m_immunePool
			{
				get
				{
					return this.m_owner.m_immunePool;
				}
				set
				{
					this.m_owner.m_immunePool = value;
				}
			}

			// Token: 0x17002461 RID: 9313
			// (get) Token: 0x0600B3B4 RID: 46004 RVA: 0x0031A8E8 File Offset: 0x00318AE8
			// (set) Token: 0x0600B3B5 RID: 46005 RVA: 0x0031A8F8 File Offset: 0x00318AF8
			public GameObjectPool[] m_targetIconPools
			{
				get
				{
					return this.m_owner.m_targetIconPools;
				}
				set
				{
					this.m_owner.m_targetIconPools = value;
				}
			}

			// Token: 0x17002462 RID: 9314
			// (get) Token: 0x0600B3B6 RID: 46006 RVA: 0x0031A908 File Offset: 0x00318B08
			// (set) Token: 0x0600B3B7 RID: 46007 RVA: 0x0031A918 File Offset: 0x00318B18
			public GameObjectPool m_canActionIconPool
			{
				get
				{
					return this.m_owner.m_canActionIconPool;
				}
				set
				{
					this.m_owner.m_canActionIconPool = value;
				}
			}

			// Token: 0x17002463 RID: 9315
			// (get) Token: 0x0600B3B8 RID: 46008 RVA: 0x0031A928 File Offset: 0x00318B28
			// (set) Token: 0x0600B3B9 RID: 46009 RVA: 0x0031A938 File Offset: 0x00318B38
			public float m_hideTargetIconTime
			{
				get
				{
					return this.m_owner.m_hideTargetIconTime;
				}
				set
				{
					this.m_owner.m_hideTargetIconTime = value;
				}
			}

			// Token: 0x17002464 RID: 9316
			// (get) Token: 0x0600B3BA RID: 46010 RVA: 0x0031A948 File Offset: 0x00318B48
			public static int InvalidPointerID
			{
				get
				{
					return -1000;
				}
			}

			// Token: 0x17002465 RID: 9317
			// (get) Token: 0x0600B3BB RID: 46011 RVA: 0x0031A950 File Offset: 0x00318B50
			// (set) Token: 0x0600B3BC RID: 46012 RVA: 0x0031A960 File Offset: 0x00318B60
			public int m_downPointerId
			{
				get
				{
					return this.m_owner.m_downPointerId;
				}
				set
				{
					this.m_owner.m_downPointerId = value;
				}
			}

			// Token: 0x17002466 RID: 9318
			// (get) Token: 0x0600B3BD RID: 46013 RVA: 0x0031A970 File Offset: 0x00318B70
			// (set) Token: 0x0600B3BE RID: 46014 RVA: 0x0031A980 File Offset: 0x00318B80
			public int m_clickPointerId
			{
				get
				{
					return this.m_owner.m_clickPointerId;
				}
				set
				{
					this.m_owner.m_clickPointerId = value;
				}
			}

			// Token: 0x17002467 RID: 9319
			// (get) Token: 0x0600B3BF RID: 46015 RVA: 0x0031A990 File Offset: 0x00318B90
			// (set) Token: 0x0600B3C0 RID: 46016 RVA: 0x0031A9A0 File Offset: 0x00318BA0
			public int m_dragPointerId
			{
				get
				{
					return this.m_owner.m_dragPointerId;
				}
				set
				{
					this.m_owner.m_dragPointerId = value;
				}
			}

			// Token: 0x17002468 RID: 9320
			// (get) Token: 0x0600B3C1 RID: 46017 RVA: 0x0031A9B0 File Offset: 0x00318BB0
			// (set) Token: 0x0600B3C2 RID: 46018 RVA: 0x0031A9C0 File Offset: 0x00318BC0
			public bool m_is3DTouchTriggered
			{
				get
				{
					return this.m_owner.m_is3DTouchTriggered;
				}
				set
				{
					this.m_owner.m_is3DTouchTriggered = value;
				}
			}

			// Token: 0x0600B3C3 RID: 46019 RVA: 0x0031A9D0 File Offset: 0x00318BD0
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600B3C4 RID: 46020 RVA: 0x0031A9E0 File Offset: 0x00318BE0
			public void ShowDamageNumbers(ClientBattleActor a, int heroHpModify, int soldierHpModify, DamageNumberType damageNumberType)
			{
				this.m_owner.ShowDamageNumbers(a, heroHpModify, soldierHpModify, damageNumberType);
			}

			// Token: 0x0600B3C5 RID: 46021 RVA: 0x0031A9F4 File Offset: 0x00318BF4
			public void ShowDamangeNumber(ClientBattleActor a, int hpModify, DamageNumberType damageNumberType, bool isHero)
			{
				this.m_owner.ShowDamangeNumber(a, hpModify, damageNumberType, isHero);
			}

			// Token: 0x0600B3C6 RID: 46022 RVA: 0x0031AA08 File Offset: 0x00318C08
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x0600B3C7 RID: 46023 RVA: 0x0031AA18 File Offset: 0x00318C18
			public void Update3DTouch()
			{
				this.m_owner.Update3DTouch();
			}

			// Token: 0x0600B3C8 RID: 46024 RVA: 0x0031AA28 File Offset: 0x00318C28
			public Vector3 GetActorGraphicCenterPosition(ClientBattleActor a)
			{
				return this.m_owner.GetActorGraphicCenterPosition(a);
			}

			// Token: 0x0600B3C9 RID: 46025 RVA: 0x0031AA38 File Offset: 0x00318C38
			public GameObject AllocateTargetIcon(ConfigDataSkillInfo skillInfo, int armyRelationValue)
			{
				return this.m_owner.AllocateTargetIcon(skillInfo, armyRelationValue);
			}

			// Token: 0x0600B3CA RID: 46026 RVA: 0x0031AA48 File Offset: 0x00318C48
			public Vector3 GridPositionToMapPosition(GridPosition p, float z)
			{
				return this.m_owner.GridPositionToMapPosition(p, z);
			}

			// Token: 0x0400747E RID: 29822
			private BattleSceneUIController m_owner;
		}
	}
}
