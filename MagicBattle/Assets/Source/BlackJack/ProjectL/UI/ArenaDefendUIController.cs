using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x020009FA RID: 2554
	[HotFix]
	public class ArenaDefendUIController : UIControllerBase
	{
		// Token: 0x06009817 RID: 38935 RVA: 0x002B6B70 File Offset: 0x002B4D70
		private ArenaDefendUIController()
		{
		}

		// Token: 0x06009818 RID: 38936 RVA: 0x002B6BD4 File Offset: 0x002B4DD4
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
			this.m_saveTeamButton.onClick.AddListener(new UnityAction(this.OnSaveTeamButtonClick));
			this.m_actionOrderButton.onClick.AddListener(new UnityAction(this.OnShowActionOrderButtonClick));
			this.m_mapButton.onClick.AddListener(new UnityAction(this.OnShowMapButtonClick));
			this.m_defendRuleButton.onClick.AddListener(new UnityAction(this.OnShowDefendRuleButtonClick));
			this.m_panelBackgroundButton.onClick.AddListener(new UnityAction(this.OnPanelBackgroundButtonClick));
			this.m_panelGameObject.SetActive(false);
			this.m_actionOrderPanelGameObject.SetActive(false);
			this.m_mapPanelGameObject.SetActive(false);
			this.m_defendRulePanelGameObject.SetActive(false);
			for (int i = 0; i < this.m_actionOrderButtons.Length; i++)
			{
				Transform parent = this.m_actionOrdersGameObject.transform.GetChild(i).Find("ActionOrderButtonDummy");
				this.m_actionOrderButtons[i] = this.CreateActionOrderButton(null, parent);
				this.m_actionOrderButtons[i].SetIndex(i);
			}
			for (int j = 0; j < this.m_defendMapToggles.Length; j++)
			{
				this.m_defendMapToggles[j] = GameObjectUtility.AddControllerToGameObject<ArenaDefendMapToggle>(this.m_mapsGameObject.transform.GetChild(j).gameObject);
			}
			for (int k = 0; k < this.m_defendRuleToggles.Length; k++)
			{
				this.m_defendRuleToggles[k] = GameObjectUtility.AddControllerToGameObject<ArenaDefendRuleToggle>(this.m_defendRulesGameObject.transform.GetChild(k).gameObject);
			}
			this.m_actionOrderOkButton.onClick.AddListener(new UnityAction(this.OnActionOrderOkButtonClick));
			this.m_mapOkButton.onClick.AddListener(new UnityAction(this.OnMapOkButtonClick));
			this.m_defendRuleOkButton.onClick.AddListener(new UnityAction(this.OnDefendRuleOkButtonClick));
			this.m_prefabsGameObject.SetActive(false);
			UIUtility.MarginAdjustHorizontal(this.m_marginTransform);
		}

		// Token: 0x06009819 RID: 38937 RVA: 0x002B6E4C File Offset: 0x002B504C
		public void Initialize(ArenaDefendBattle battle)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitializeArenaDefendBattle_hotfix != null)
			{
				this.m_InitializeArenaDefendBattle_hotfix.call(new object[]
				{
					this,
					battle
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_arenaDefendBattle = battle;
			this.m_camera = base.GetComponentInParent<Camera>();
		}

		// Token: 0x0600981A RID: 38938 RVA: 0x002B6ED0 File Offset: 0x002B50D0
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

		// Token: 0x0600981B RID: 38939 RVA: 0x002B6F44 File Offset: 0x002B5144
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

		// Token: 0x0600981C RID: 38940 RVA: 0x002B6FC0 File Offset: 0x002B51C0
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

		// Token: 0x0600981D RID: 38941 RVA: 0x002B703C File Offset: 0x002B523C
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
			if (this.m_draggingActionOrderButton != null)
			{
				this.DestroyDragginActionOrderButton();
			}
			if (this.m_draggingHeroButton != null)
			{
				this.DestroyDragginHeroButton();
			}
			if (this.m_draggingActionOrderButton != null)
			{
				this.DestroyDragginActionOrderButton();
			}
			EventSystem.current.pixelDragThreshold = UIUtility.GetDefaultPixelDragThreshold();
		}

		// Token: 0x0600981E RID: 38942 RVA: 0x002B70F0 File Offset: 0x002B52F0
		public void SetHeroActionOrders(List<BattleHero> heros)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroActionOrdersList`1_hotfix != null)
			{
				this.m_SetHeroActionOrdersList`1_hotfix.call(new object[]
				{
					this,
					heros
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			for (int i = 0; i < this.m_actionOrderButtons.Length; i++)
			{
				if (i < heros.Count)
				{
					this.m_actionOrderButtons[i].SetHero(heros[i]);
					this.m_actionOrderButtons[i].gameObject.SetActive(true);
				}
				else
				{
					this.m_actionOrderButtons[i].SetHero(null);
					this.m_actionOrderButtons[i].gameObject.SetActive(false);
				}
			}
		}

		// Token: 0x0600981F RID: 38943 RVA: 0x002B71D4 File Offset: 0x002B53D4
		public int GetHeroActionOrderIndex(BattleHero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroActionOrderIndexBattleHero_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetHeroActionOrderIndexBattleHero_hotfix.call(new object[]
				{
					this,
					hero
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (ArenaActionOrderButton arenaActionOrderButton in this.m_actionOrderButtons)
			{
				if (arenaActionOrderButton.GetHero() == hero)
				{
					return arenaActionOrderButton.GetIndex();
				}
			}
			return 0;
		}

		// Token: 0x06009820 RID: 38944 RVA: 0x002B7284 File Offset: 0x002B5484
		public void SetMaps(List<ConfigDataArenaBattleInfo> battleInfos, int currentIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetMapsList`1Int32_hotfix != null)
			{
				this.m_SetMapsList`1Int32_hotfix.call(new object[]
				{
					this,
					battleInfos,
					currentIndex
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			for (int i = 0; i < battleInfos.Count; i++)
			{
				if (i < this.m_defendMapToggles.Length)
				{
					this.m_defendMapToggles[i].SetArenaBattleInfo(battleInfos[i]);
				}
				if (i == currentIndex)
				{
					this.m_defendMapToggles[i].SetSelected(true);
				}
			}
		}

		// Token: 0x06009821 RID: 38945 RVA: 0x002B7354 File Offset: 0x002B5554
		public void SetDefendRules(List<ConfigDataArenaDefendRuleInfo> defendRuleInfos, int currentIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetDefendRulesList`1Int32_hotfix != null)
			{
				this.m_SetDefendRulesList`1Int32_hotfix.call(new object[]
				{
					this,
					defendRuleInfos,
					currentIndex
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			for (int i = 0; i < defendRuleInfos.Count; i++)
			{
				if (i < this.m_defendRuleToggles.Length)
				{
					this.m_defendRuleToggles[i].SetArenaDefendRuleInfo(defendRuleInfos[i]);
				}
				if (i == currentIndex)
				{
					this.m_defendRuleToggles[i].SetSelected(true);
				}
			}
		}

		// Token: 0x06009822 RID: 38946 RVA: 0x002B7424 File Offset: 0x002B5624
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
				this.m_battlePowerText.text = battlePower.ToString();
				this.m_battlePowerUIStateController.SetToUIState("Hide", false, true);
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
				this.m_battlePowerUIStateController.SetToUIState("Hide", false, true);
			}
			this.m_battlePowerValue = battlePower;
		}

		// Token: 0x06009823 RID: 38947 RVA: 0x002B7528 File Offset: 0x002B5728
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
			ArenaDefendUIController.<Co_SetBattlePowerValue>c__Iterator0 <Co_SetBattlePowerValue>c__Iterator = new ArenaDefendUIController.<Co_SetBattlePowerValue>c__Iterator0();
			<Co_SetBattlePowerValue>c__Iterator.newValue = newValue;
			<Co_SetBattlePowerValue>c__Iterator.oldValue = oldValue;
			<Co_SetBattlePowerValue>c__Iterator.$this = this;
			return <Co_SetBattlePowerValue>c__Iterator;
		}

		// Token: 0x06009824 RID: 38948 RVA: 0x002B75D0 File Offset: 0x002B57D0
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

		// Token: 0x06009825 RID: 38949 RVA: 0x002B7638 File Offset: 0x002B5838
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
			foreach (ArenaDefendActor arenaDefendActor in this.m_stageActors)
			{
				arenaDefendActor.TickGraphic(deltaTime);
			}
			this.CheckStageAtorChange();
		}

		// Token: 0x06009826 RID: 38950 RVA: 0x002B76F4 File Offset: 0x002B58F4
		public void CheckStageAtorChange()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckStageAtorChange_hotfix != null)
			{
				this.m_CheckStageAtorChange_hotfix.call(new object[]
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
						bool flag = this.m_stageActors.Find((ArenaDefendActor x) => x.GetHero() == b.GetHero()) != null;
						b.gameObject.SetActive(!flag);
					}
				}
				if (this.EventOnStageActorChange != null)
				{
					this.EventOnStageActorChange();
				}
			}
		}

		// Token: 0x06009827 RID: 38951 RVA: 0x002B7808 File Offset: 0x002B5A08
		public void SetStageActorCountMax(int c)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetStageActorCountMaxInt32_hotfix != null)
			{
				this.m_SetStageActorCountMaxInt32_hotfix.call(new object[]
				{
					this,
					c
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_stageActorCountMax = c;
			this.UpdateStageActorCount();
		}

		// Token: 0x06009828 RID: 38952 RVA: 0x002B7888 File Offset: 0x002B5A88
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
			this.m_stageActorCountText.text = this.m_stageActors.Count + " / " + this.m_stageActorCountMax;
		}

		// Token: 0x06009829 RID: 38953 RVA: 0x002B7918 File Offset: 0x002B5B18
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

		// Token: 0x0600982A RID: 38954 RVA: 0x002B79D4 File Offset: 0x002B5BD4
		public void AddHero(BattleHero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddHeroBattleHero_hotfix != null)
			{
				this.m_AddHeroBattleHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (hero == null)
			{
				return;
			}
			HeroDragButton item = this.CreateHeroButton(hero, this.m_actorListScrollRect.content);
			this.m_heroButtons.Add(item);
		}

		// Token: 0x0600982B RID: 38955 RVA: 0x002B7A6C File Offset: 0x002B5C6C
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
			this.m_stagePositions.Clear();
			this.m_stageDirs.Clear();
		}

		// Token: 0x0600982C RID: 38956 RVA: 0x002B7AE4 File Offset: 0x002B5CE4
		public void AddStagePosition(GridPosition p, int dir)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddStagePositionGridPositionInt32_hotfix != null)
			{
				this.m_AddStagePositionGridPositionInt32_hotfix.call(new object[]
				{
					this,
					p,
					dir
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_stagePositions.Add(p);
			this.m_stageDirs.Add(dir);
		}

		// Token: 0x0600982D RID: 38957 RVA: 0x002B7B7C File Offset: 0x002B5D7C
		public List<GridPosition> GetStagePositions()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetStagePositions_hotfix != null)
			{
				return (List<GridPosition>)this.m_GetStagePositions_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_stagePositions;
		}

		// Token: 0x0600982E RID: 38958 RVA: 0x002B7BF0 File Offset: 0x002B5DF0
		private int GetStageDirection(GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetStageDirectionGridPosition_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetStageDirectionGridPosition_hotfix.call(new object[]
				{
					this,
					p
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			for (int i = 0; i < this.m_stagePositions.Count; i++)
			{
				if (this.m_stagePositions[i] == p)
				{
					return this.m_stageDirs[i];
				}
			}
			return 0;
		}

		// Token: 0x0600982F RID: 38959 RVA: 0x002B7CB0 File Offset: 0x002B5EB0
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
			heroDragButton.EventOnClick += this.HeroDragButton_OnClick;
			heroDragButton.EventOnBeginDrag += this.HeroDragButton_OnBeginDrag;
			heroDragButton.EventOnEndDrag += this.HeroDragButton_OnEndDrag;
			heroDragButton.EventOnDrag += this.HeroDragButton_OnDrag;
			heroDragButton.EventOnDrop += this.HeroDragButton_OnDrop;
			return heroDragButton;
		}

		// Token: 0x06009830 RID: 38960 RVA: 0x002B7DB4 File Offset: 0x002B5FB4
		public ArenaDefendActor HeroOnStage(BattleHero hero, GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroOnStageBattleHeroGridPosition_hotfix != null)
			{
				return (ArenaDefendActor)this.m_HeroOnStageBattleHeroGridPosition_hotfix.call(new object[]
				{
					this,
					hero,
					p
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ArenaDefendActor stageActor = this.GetStageActor(p);
			if (stageActor != null)
			{
				this.ActorOffStage(stageActor);
			}
			ArenaDefendActor arenaDefendActor = new ArenaDefendActor(this.m_arenaDefendBattle);
			arenaDefendActor.SetHero(hero);
			arenaDefendActor.SetPosition(p, this.GetStageDirection(p));
			this.m_stageActors.Add(arenaDefendActor);
			this.m_isStageActorChanged = true;
			return arenaDefendActor;
		}

		// Token: 0x06009831 RID: 38961 RVA: 0x002B7E8C File Offset: 0x002B608C
		public void ActorOffStage(ArenaDefendActor sa)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActorOffStageArenaDefendActor_hotfix != null)
			{
				this.m_ActorOffStageArenaDefendActor_hotfix.call(new object[]
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

		// Token: 0x06009832 RID: 38962 RVA: 0x002B7F5C File Offset: 0x002B615C
		public void ActorOnStageMove(ArenaDefendActor sa, GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActorOnStageMoveArenaDefendActorGridPosition_hotfix != null)
			{
				this.m_ActorOnStageMoveArenaDefendActorGridPosition_hotfix.call(new object[]
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
			sa.SetPosition(p, this.GetStageDirection(p));
			this.m_isStageActorChanged = true;
		}

		// Token: 0x06009833 RID: 38963 RVA: 0x002B7FF8 File Offset: 0x002B61F8
		public void ActorOnStageExchange(ArenaDefendActor sa1, ArenaDefendActor sa2)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActorOnStageExchangeArenaDefendActorArenaDefendActor_hotfix != null)
			{
				this.m_ActorOnStageExchangeArenaDefendActorArenaDefendActor_hotfix.call(new object[]
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

		// Token: 0x06009834 RID: 38964 RVA: 0x002B80B4 File Offset: 0x002B62B4
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
			foreach (ArenaDefendActor arenaDefendActor in this.m_stageActors)
			{
				arenaDefendActor.Destroy();
			}
			this.m_stageActors.Clear();
			this.m_isStageActorChanged = true;
		}

		// Token: 0x06009835 RID: 38965 RVA: 0x002B8174 File Offset: 0x002B6374
		public ArenaDefendActor GetStageActor(GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetStageActorGridPosition_hotfix != null)
			{
				return (ArenaDefendActor)this.m_GetStageActorGridPosition_hotfix.call(new object[]
				{
					this,
					p
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (ArenaDefendActor arenaDefendActor in this.m_stageActors)
			{
				if (arenaDefendActor.GetPosition() == p)
				{
					return arenaDefendActor;
				}
			}
			return null;
		}

		// Token: 0x06009836 RID: 38966 RVA: 0x002B8254 File Offset: 0x002B6454
		public List<ArenaDefendActor> GetStageActors()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetStageActors_hotfix != null)
			{
				return (List<ArenaDefendActor>)this.m_GetStageActors_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_stageActors;
		}

		// Token: 0x06009837 RID: 38967 RVA: 0x002B82C8 File Offset: 0x002B64C8
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
			foreach (ArenaDefendActor arenaDefendActor in this.m_stageActors)
			{
				if (arenaDefendActor.GetHero() == hero)
				{
					arenaDefendActor.SetHero(hero);
				}
			}
		}

		// Token: 0x06009838 RID: 38968 RVA: 0x002B8394 File Offset: 0x002B6594
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

		// Token: 0x06009839 RID: 38969 RVA: 0x002B8428 File Offset: 0x002B6628
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

		// Token: 0x0600983A RID: 38970 RVA: 0x002B84B0 File Offset: 0x002B66B0
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

		// Token: 0x0600983B RID: 38971 RVA: 0x002B852C File Offset: 0x002B672C
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

		// Token: 0x0600983C RID: 38972 RVA: 0x002B85A8 File Offset: 0x002B67A8
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

		// Token: 0x0600983D RID: 38973 RVA: 0x002B863C File Offset: 0x002B683C
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

		// Token: 0x0600983E RID: 38974 RVA: 0x002B86B4 File Offset: 0x002B68B4
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

		// Token: 0x0600983F RID: 38975 RVA: 0x002B874C File Offset: 0x002B694C
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
			GridPosition p = this.m_arenaDefendBattle.ScreenPositionToGridPosition(eventData.position);
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

		// Token: 0x06009840 RID: 38976 RVA: 0x002B8840 File Offset: 0x002B6A40
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

		// Token: 0x06009841 RID: 38977 RVA: 0x002B8928 File Offset: 0x002B6B28
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

		// Token: 0x06009842 RID: 38978 RVA: 0x002B89CC File Offset: 0x002B6BCC
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
				this.HideActorInfo();
				this.m_pointerDownStageActor.TweenColor(new Colori(150, 150, 150, byte.MaxValue));
				this.CreateDraggingHeroButton(this.m_pointerDownStageActor.GetHero());
			}
		}

		// Token: 0x06009843 RID: 38979 RVA: 0x002B8A94 File Offset: 0x002B6C94
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

		// Token: 0x06009844 RID: 38980 RVA: 0x002B8B30 File Offset: 0x002B6D30
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

		// Token: 0x06009845 RID: 38981 RVA: 0x002B8BC0 File Offset: 0x002B6DC0
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
			this.m_draggingHeroButton.transform.SetParent(componentInParent.transform, false);
			this.m_draggingHeroButton.transform.SetAsLastSibling();
			AudioUtility.PlaySound(SoundTableId.SoundTableId_DragHero);
			CommonUIController.Instance.EnableInput(false);
		}

		// Token: 0x06009846 RID: 38982 RVA: 0x002B8C88 File Offset: 0x002B6E88
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
			}
		}

		// Token: 0x06009847 RID: 38983 RVA: 0x002B8D64 File Offset: 0x002B6F64
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

		// Token: 0x06009848 RID: 38984 RVA: 0x002B8E30 File Offset: 0x002B7030
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
			bool flag = false;
			float num = float.MaxValue;
			Vector2 a = this.m_arenaDefendBattle.ScreenPositionToWorldPosition(pos);
			for (int i = 0; i < this.m_stagePositions.Count; i++)
			{
				GridPosition gridPosition2 = this.m_stagePositions[i];
				Vector2 b = this.m_arenaDefendBattle.GridPositionToWorldPosition(gridPosition2);
				float num2 = Vector2.Distance(a, b);
				if (num2 <= 2f)
				{
					if (num2 <= num)
					{
						flag = true;
						gridPosition = gridPosition2;
						num = num2;
					}
				}
			}
			ArenaDefendActor stageActor = this.GetStageActor(gridPosition);
			if (this.m_pointerDownStageActor != null)
			{
				if (flag)
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
			else if (flag)
			{
				int num3;
				if (stageActor != null)
				{
					num3 = this.m_stageActorCountMax;
				}
				else
				{
					num3 = this.m_stageActorCountMax - 1;
				}
				if (this.m_stageActors.Count <= num3)
				{
					if (this.EventOnHeroOnStage != null)
					{
						this.EventOnHeroOnStage(this.m_draggingHeroButton.GetHero(), gridPosition);
					}
				}
				else
				{
					CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Battle_StageHeroCountMax, 2f, null, true);
				}
			}
		}

		// Token: 0x06009849 RID: 38985 RVA: 0x002B9044 File Offset: 0x002B7244
		public void ShowActionOrderPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowActionOrderPanel_hotfix != null)
			{
				this.m_ShowActionOrderPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_panelGameObject.SetActive(true);
			UIUtility.SetUIStateOpen(this.m_actionOrderPanelUIStateController, "Show", null, false, true);
		}

		// Token: 0x0600984A RID: 38986 RVA: 0x002B90C4 File Offset: 0x002B72C4
		public void ShowMapPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowMapPanel_hotfix != null)
			{
				this.m_ShowMapPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_panelGameObject.SetActive(true);
			UIUtility.SetUIStateOpen(this.m_mapPanelUIStateController, "Show", null, false, true);
		}

		// Token: 0x0600984B RID: 38987 RVA: 0x002B9144 File Offset: 0x002B7344
		public void ShowDefendRulePanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowDefendRulePanel_hotfix != null)
			{
				this.m_ShowDefendRulePanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_panelGameObject.SetActive(true);
			UIUtility.SetUIStateOpen(this.m_defendRulePanelUIStateController, "Show", null, false, true);
		}

		// Token: 0x0600984C RID: 38988 RVA: 0x002B91C4 File Offset: 0x002B73C4
		private ArenaActionOrderButton CreateActionOrderButton(BattleHero hero, Transform parent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateActionOrderButtonBattleHeroTransform_hotfix != null)
			{
				return (ArenaActionOrderButton)this.m_CreateActionOrderButtonBattleHeroTransform_hotfix.call(new object[]
				{
					this,
					hero,
					parent
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject go = UnityEngine.Object.Instantiate<GameObject>(this.m_actionOrderButtonPrefab, parent, false);
			ArenaActionOrderButton arenaActionOrderButton = GameObjectUtility.AddControllerToGameObject<ArenaActionOrderButton>(go);
			if (hero != null)
			{
				arenaActionOrderButton.SetHero(hero);
			}
			arenaActionOrderButton.EventOnClick += this.ActionOrderButton_OnClick;
			arenaActionOrderButton.EventOnBeginDrag += this.ActionOrderButton_OnBeginDrag;
			arenaActionOrderButton.EventOnEndDrag += this.ActionOrderButton_OnEndDrag;
			arenaActionOrderButton.EventOnDrag += this.ActionOrderButton_OnDrag;
			arenaActionOrderButton.EventOnDrop += this.ActionOrderButton_OnDrop;
			return arenaActionOrderButton;
		}

		// Token: 0x0600984D RID: 38989 RVA: 0x002B92D0 File Offset: 0x002B74D0
		private void CreateDraggingActionOrderButton(BattleHero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateDraggingActionOrderButtonBattleHero_hotfix != null)
			{
				this.m_CreateDraggingActionOrderButtonBattleHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DestroyDragginActionOrderButton();
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			this.m_draggingActionOrderButton = this.CreateActionOrderButton(hero, componentInParent.transform);
			this.m_draggingActionOrderButton.transform.SetAsLastSibling();
			AudioUtility.PlaySound(SoundTableId.SoundTableId_DragHero);
			CommonUIController.Instance.EnableInput(false);
		}

		// Token: 0x0600984E RID: 38990 RVA: 0x002B9384 File Offset: 0x002B7584
		private void DestroyDragginActionOrderButton()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroyDragginActionOrderButton_hotfix != null)
			{
				this.m_DestroyDragginActionOrderButton_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_draggingActionOrderButton == null)
			{
				return;
			}
			this.m_draggingActionOrderButton.Destroy();
			this.m_draggingActionOrderButton = null;
			CommonUIController.Instance.EnableInput(true);
		}

		// Token: 0x0600984F RID: 38991 RVA: 0x002B9414 File Offset: 0x002B7614
		private void MoveDraggingActionOrderButton(Vector2 pos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_MoveDraggingActionOrderButtonVector2_hotfix != null)
			{
				this.m_MoveDraggingActionOrderButtonVector2_hotfix.call(new object[]
				{
					this,
					pos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_draggingActionOrderButton == null)
			{
				return;
			}
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			RectTransform rect = componentInParent.transform as RectTransform;
			Vector3 position;
			if (RectTransformUtility.ScreenPointToWorldPointInRectangle(rect, pos, this.m_camera, out position))
			{
				position.y += 0.3f;
				this.m_draggingActionOrderButton.transform.position = position;
			}
		}

		// Token: 0x06009850 RID: 38992 RVA: 0x002B94E4 File Offset: 0x002B76E4
		private void DropDraggingActionOrderButton(Vector2 pos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DropDraggingActionOrderButtonVector2_hotfix != null)
			{
				this.m_DropDraggingActionOrderButtonVector2_hotfix.call(new object[]
				{
					this,
					pos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_draggingActionOrderButton == null)
			{
				return;
			}
			foreach (ArenaActionOrderButton arenaActionOrderButton in this.m_actionOrderButtons)
			{
				if (arenaActionOrderButton.GetHero() != null && arenaActionOrderButton.gameObject.activeSelf)
				{
					RectTransform rect = arenaActionOrderButton.transform as RectTransform;
					if (RectTransformUtility.RectangleContainsScreenPoint(rect, pos, this.m_camera))
					{
						BattleHero hero = arenaActionOrderButton.GetHero();
						arenaActionOrderButton.SetHero(this.m_draggingActionOrderButton.GetHero());
						this.m_actionOrderButtons[this.m_draggingActionOrderButtonIndex].SetHero(hero);
						AudioUtility.PlaySound(SoundTableId.SoundTableId_DropHero);
						break;
					}
				}
			}
			this.DestroyDragginActionOrderButton();
		}

		// Token: 0x06009851 RID: 38993 RVA: 0x002B9604 File Offset: 0x002B7804
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

		// Token: 0x06009852 RID: 38994 RVA: 0x002B967C File Offset: 0x002B787C
		private void OnSaveTeamButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSaveTeamButtonClick_hotfix != null)
			{
				this.m_OnSaveTeamButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnSave != null)
			{
				this.EventOnSave();
			}
		}

		// Token: 0x06009853 RID: 38995 RVA: 0x002B96F4 File Offset: 0x002B78F4
		private void OnShowActionOrderButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnShowActionOrderButtonClick_hotfix != null)
			{
				this.m_OnShowActionOrderButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowActionOrderPanel != null)
			{
				this.EventOnShowActionOrderPanel();
			}
		}

		// Token: 0x06009854 RID: 38996 RVA: 0x002B976C File Offset: 0x002B796C
		private void OnShowMapButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnShowMapButtonClick_hotfix != null)
			{
				this.m_OnShowMapButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowMapPanel != null)
			{
				this.EventOnShowMapPanel();
			}
		}

		// Token: 0x06009855 RID: 38997 RVA: 0x002B97E4 File Offset: 0x002B79E4
		private void OnShowDefendRuleButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnShowDefendRuleButtonClick_hotfix != null)
			{
				this.m_OnShowDefendRuleButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowDefendRulePanel != null)
			{
				this.EventOnShowDefendRulePanel();
			}
		}

		// Token: 0x06009856 RID: 38998 RVA: 0x002B985C File Offset: 0x002B7A5C
		private void OnPanelBackgroundButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPanelBackgroundButtonClick_hotfix != null)
			{
				this.m_OnPanelBackgroundButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_mapsGameObject.activeSelf)
			{
				UIUtility.SetUIStateClose(this.m_mapPanelUIStateController, "Close", delegate
				{
					this.m_panelGameObject.SetActive(false);
				}, false, true);
			}
			if (this.m_actionOrdersGameObject.activeSelf)
			{
				UIUtility.SetUIStateClose(this.m_actionOrderPanelUIStateController, "Close", delegate
				{
					this.m_panelGameObject.SetActive(false);
				}, false, true);
			}
			if (this.m_defendRulesGameObject.activeSelf)
			{
				UIUtility.SetUIStateClose(this.m_defendRulePanelUIStateController, "Close", delegate
				{
					this.m_panelGameObject.SetActive(false);
				}, false, true);
			}
		}

		// Token: 0x06009857 RID: 38999 RVA: 0x002B9948 File Offset: 0x002B7B48
		private void OnActionOrderOkButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnActionOrderOkButtonClick_hotfix != null)
			{
				this.m_OnActionOrderOkButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_actionOrderPanelUIStateController, "Close", delegate
			{
				this.m_panelGameObject.SetActive(false);
			}, false, true);
			if (this.EventOnConfirmActionOrder != null)
			{
				this.EventOnConfirmActionOrder();
			}
		}

		// Token: 0x06009858 RID: 39000 RVA: 0x002B99DC File Offset: 0x002B7BDC
		private void ActionOrderButton_OnClick(ArenaActionOrderButton b)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActionOrderButton_OnClickArenaActionOrderButton_hotfix != null)
			{
				this.m_ActionOrderButton_OnClickArenaActionOrderButton_hotfix.call(new object[]
				{
					this,
					b
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06009859 RID: 39001 RVA: 0x002B9A4C File Offset: 0x002B7C4C
		private void ActionOrderButton_OnBeginDrag(ArenaActionOrderButton b, PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActionOrderButton_OnBeginDragArenaActionOrderButtonPointerEventData_hotfix != null)
			{
				this.m_ActionOrderButton_OnBeginDragArenaActionOrderButtonPointerEventData_hotfix.call(new object[]
				{
					this,
					b,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_draggingActionOrderButtonIndex = b.GetIndex();
			this.CreateDraggingActionOrderButton(b.GetHero());
		}

		// Token: 0x0600985A RID: 39002 RVA: 0x002B9AE4 File Offset: 0x002B7CE4
		private void ActionOrderButton_OnEndDrag(ArenaActionOrderButton b, PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActionOrderButton_OnEndDragArenaActionOrderButtonPointerEventData_hotfix != null)
			{
				this.m_ActionOrderButton_OnEndDragArenaActionOrderButtonPointerEventData_hotfix.call(new object[]
				{
					this,
					b,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DestroyDragginActionOrderButton();
		}

		// Token: 0x0600985B RID: 39003 RVA: 0x002B9B6C File Offset: 0x002B7D6C
		private void ActionOrderButton_OnDrag(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActionOrderButton_OnDragPointerEventData_hotfix != null)
			{
				this.m_ActionOrderButton_OnDragPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.MoveDraggingActionOrderButton(eventData.position);
		}

		// Token: 0x0600985C RID: 39004 RVA: 0x002B9BE8 File Offset: 0x002B7DE8
		private void ActionOrderButton_OnDrop(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActionOrderButton_OnDropPointerEventData_hotfix != null)
			{
				this.m_ActionOrderButton_OnDropPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DropDraggingActionOrderButton(eventData.position);
		}

		// Token: 0x0600985D RID: 39005 RVA: 0x002B9C64 File Offset: 0x002B7E64
		private void OnMapOkButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMapOkButtonClick_hotfix != null)
			{
				this.m_OnMapOkButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_mapPanelUIStateController, "Close", delegate
			{
				this.m_panelGameObject.SetActive(false);
			}, false, true);
			if (this.EventOnConfirmMap != null)
			{
				int obj = -1;
				for (int i = 0; i < this.m_defendMapToggles.Length; i++)
				{
					if (this.m_defendMapToggles[i].IsSelected())
					{
						obj = i;
						break;
					}
				}
				this.EventOnConfirmMap(obj);
			}
		}

		// Token: 0x0600985E RID: 39006 RVA: 0x002B9D30 File Offset: 0x002B7F30
		private void OnDefendRuleOkButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDefendRuleOkButtonClick_hotfix != null)
			{
				this.m_OnDefendRuleOkButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_defendRulePanelUIStateController, "Close", delegate
			{
				this.m_panelGameObject.SetActive(false);
			}, false, true);
			if (this.EventOnConfirmDefendRule != null)
			{
				int obj = -1;
				for (int i = 0; i < this.m_defendRuleToggles.Length; i++)
				{
					if (this.m_defendRuleToggles[i].IsSelected())
					{
						obj = i;
						break;
					}
				}
				this.EventOnConfirmDefendRule(obj);
			}
		}

		// Token: 0x140001AA RID: 426
		// (add) Token: 0x0600985F RID: 39007 RVA: 0x002B9DFC File Offset: 0x002B7FFC
		// (remove) Token: 0x06009860 RID: 39008 RVA: 0x002B9E98 File Offset: 0x002B8098
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

		// Token: 0x140001AB RID: 427
		// (add) Token: 0x06009861 RID: 39009 RVA: 0x002B9F34 File Offset: 0x002B8134
		// (remove) Token: 0x06009862 RID: 39010 RVA: 0x002B9FD0 File Offset: 0x002B81D0
		public event Action EventOnSave
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSaveAction_hotfix != null)
				{
					this.m_add_EventOnSaveAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSave;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSave, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSaveAction_hotfix != null)
				{
					this.m_remove_EventOnSaveAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSave;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSave, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001AC RID: 428
		// (add) Token: 0x06009863 RID: 39011 RVA: 0x002BA06C File Offset: 0x002B826C
		// (remove) Token: 0x06009864 RID: 39012 RVA: 0x002BA108 File Offset: 0x002B8308
		public event Action EventOnShowActionOrderPanel
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowActionOrderPanelAction_hotfix != null)
				{
					this.m_add_EventOnShowActionOrderPanelAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowActionOrderPanel;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowActionOrderPanel, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowActionOrderPanelAction_hotfix != null)
				{
					this.m_remove_EventOnShowActionOrderPanelAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowActionOrderPanel;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowActionOrderPanel, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001AD RID: 429
		// (add) Token: 0x06009865 RID: 39013 RVA: 0x002BA1A4 File Offset: 0x002B83A4
		// (remove) Token: 0x06009866 RID: 39014 RVA: 0x002BA240 File Offset: 0x002B8440
		public event Action EventOnShowMapPanel
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowMapPanelAction_hotfix != null)
				{
					this.m_add_EventOnShowMapPanelAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowMapPanel;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowMapPanel, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowMapPanelAction_hotfix != null)
				{
					this.m_remove_EventOnShowMapPanelAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowMapPanel;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowMapPanel, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001AE RID: 430
		// (add) Token: 0x06009867 RID: 39015 RVA: 0x002BA2DC File Offset: 0x002B84DC
		// (remove) Token: 0x06009868 RID: 39016 RVA: 0x002BA378 File Offset: 0x002B8578
		public event Action EventOnShowDefendRulePanel
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowDefendRulePanelAction_hotfix != null)
				{
					this.m_add_EventOnShowDefendRulePanelAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowDefendRulePanel;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowDefendRulePanel, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowDefendRulePanelAction_hotfix != null)
				{
					this.m_remove_EventOnShowDefendRulePanelAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowDefendRulePanel;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowDefendRulePanel, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001AF RID: 431
		// (add) Token: 0x06009869 RID: 39017 RVA: 0x002BA414 File Offset: 0x002B8614
		// (remove) Token: 0x0600986A RID: 39018 RVA: 0x002BA4B0 File Offset: 0x002B86B0
		public event Action EventOnConfirmActionOrder
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnConfirmActionOrderAction_hotfix != null)
				{
					this.m_add_EventOnConfirmActionOrderAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnConfirmActionOrder;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnConfirmActionOrder, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnConfirmActionOrderAction_hotfix != null)
				{
					this.m_remove_EventOnConfirmActionOrderAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnConfirmActionOrder;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnConfirmActionOrder, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001B0 RID: 432
		// (add) Token: 0x0600986B RID: 39019 RVA: 0x002BA54C File Offset: 0x002B874C
		// (remove) Token: 0x0600986C RID: 39020 RVA: 0x002BA5E8 File Offset: 0x002B87E8
		public event Action<int> EventOnConfirmMap
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnConfirmMapAction`1_hotfix != null)
				{
					this.m_add_EventOnConfirmMapAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnConfirmMap;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnConfirmMap, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnConfirmMapAction`1_hotfix != null)
				{
					this.m_remove_EventOnConfirmMapAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnConfirmMap;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnConfirmMap, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001B1 RID: 433
		// (add) Token: 0x0600986D RID: 39021 RVA: 0x002BA684 File Offset: 0x002B8884
		// (remove) Token: 0x0600986E RID: 39022 RVA: 0x002BA720 File Offset: 0x002B8920
		public event Action<int> EventOnConfirmDefendRule
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnConfirmDefendRuleAction`1_hotfix != null)
				{
					this.m_add_EventOnConfirmDefendRuleAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnConfirmDefendRule;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnConfirmDefendRule, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnConfirmDefendRuleAction`1_hotfix != null)
				{
					this.m_remove_EventOnConfirmDefendRuleAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnConfirmDefendRule;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnConfirmDefendRule, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001B2 RID: 434
		// (add) Token: 0x0600986F RID: 39023 RVA: 0x002BA7BC File Offset: 0x002B89BC
		// (remove) Token: 0x06009870 RID: 39024 RVA: 0x002BA858 File Offset: 0x002B8A58
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

		// Token: 0x140001B3 RID: 435
		// (add) Token: 0x06009871 RID: 39025 RVA: 0x002BA8F4 File Offset: 0x002B8AF4
		// (remove) Token: 0x06009872 RID: 39026 RVA: 0x002BA990 File Offset: 0x002B8B90
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

		// Token: 0x140001B4 RID: 436
		// (add) Token: 0x06009873 RID: 39027 RVA: 0x002BAA2C File Offset: 0x002B8C2C
		// (remove) Token: 0x06009874 RID: 39028 RVA: 0x002BAAC8 File Offset: 0x002B8CC8
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

		// Token: 0x140001B5 RID: 437
		// (add) Token: 0x06009875 RID: 39029 RVA: 0x002BAB64 File Offset: 0x002B8D64
		// (remove) Token: 0x06009876 RID: 39030 RVA: 0x002BAC00 File Offset: 0x002B8E00
		public event Action<BattleHero, GridPosition> EventOnHeroOnStage
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnHeroOnStageAction`2_hotfix != null)
				{
					this.m_add_EventOnHeroOnStageAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleHero, GridPosition> action = this.EventOnHeroOnStage;
				Action<BattleHero, GridPosition> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleHero, GridPosition>>(ref this.EventOnHeroOnStage, (Action<BattleHero, GridPosition>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnHeroOnStageAction`2_hotfix != null)
				{
					this.m_remove_EventOnHeroOnStageAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleHero, GridPosition> action = this.EventOnHeroOnStage;
				Action<BattleHero, GridPosition> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleHero, GridPosition>>(ref this.EventOnHeroOnStage, (Action<BattleHero, GridPosition>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001B6 RID: 438
		// (add) Token: 0x06009877 RID: 39031 RVA: 0x002BAC9C File Offset: 0x002B8E9C
		// (remove) Token: 0x06009878 RID: 39032 RVA: 0x002BAD38 File Offset: 0x002B8F38
		public event Action<ArenaDefendActor> EventOnActorOffStage
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
				Action<ArenaDefendActor> action = this.EventOnActorOffStage;
				Action<ArenaDefendActor> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ArenaDefendActor>>(ref this.EventOnActorOffStage, (Action<ArenaDefendActor>)Delegate.Combine(action2, value), action);
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
				Action<ArenaDefendActor> action = this.EventOnActorOffStage;
				Action<ArenaDefendActor> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ArenaDefendActor>>(ref this.EventOnActorOffStage, (Action<ArenaDefendActor>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001B7 RID: 439
		// (add) Token: 0x06009879 RID: 39033 RVA: 0x002BADD4 File Offset: 0x002B8FD4
		// (remove) Token: 0x0600987A RID: 39034 RVA: 0x002BAE70 File Offset: 0x002B9070
		public event Action<ArenaDefendActor, GridPosition> EventOnStageActorMove
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
				Action<ArenaDefendActor, GridPosition> action = this.EventOnStageActorMove;
				Action<ArenaDefendActor, GridPosition> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ArenaDefendActor, GridPosition>>(ref this.EventOnStageActorMove, (Action<ArenaDefendActor, GridPosition>)Delegate.Combine(action2, value), action);
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
				Action<ArenaDefendActor, GridPosition> action = this.EventOnStageActorMove;
				Action<ArenaDefendActor, GridPosition> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ArenaDefendActor, GridPosition>>(ref this.EventOnStageActorMove, (Action<ArenaDefendActor, GridPosition>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001B8 RID: 440
		// (add) Token: 0x0600987B RID: 39035 RVA: 0x002BAF0C File Offset: 0x002B910C
		// (remove) Token: 0x0600987C RID: 39036 RVA: 0x002BAFA8 File Offset: 0x002B91A8
		public event Action<ArenaDefendActor, ArenaDefendActor> EventOnStageActorSwap
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
				Action<ArenaDefendActor, ArenaDefendActor> action = this.EventOnStageActorSwap;
				Action<ArenaDefendActor, ArenaDefendActor> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ArenaDefendActor, ArenaDefendActor>>(ref this.EventOnStageActorSwap, (Action<ArenaDefendActor, ArenaDefendActor>)Delegate.Combine(action2, value), action);
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
				Action<ArenaDefendActor, ArenaDefendActor> action = this.EventOnStageActorSwap;
				Action<ArenaDefendActor, ArenaDefendActor> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ArenaDefendActor, ArenaDefendActor>>(ref this.EventOnStageActorSwap, (Action<ArenaDefendActor, ArenaDefendActor>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001B9 RID: 441
		// (add) Token: 0x0600987D RID: 39037 RVA: 0x002BB044 File Offset: 0x002B9244
		// (remove) Token: 0x0600987E RID: 39038 RVA: 0x002BB0E0 File Offset: 0x002B92E0
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

		// Token: 0x140001BA RID: 442
		// (add) Token: 0x0600987F RID: 39039 RVA: 0x002BB17C File Offset: 0x002B937C
		// (remove) Token: 0x06009880 RID: 39040 RVA: 0x002BB218 File Offset: 0x002B9418
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

		// Token: 0x140001BB RID: 443
		// (add) Token: 0x06009881 RID: 39041 RVA: 0x002BB2B4 File Offset: 0x002B94B4
		// (remove) Token: 0x06009882 RID: 39042 RVA: 0x002BB350 File Offset: 0x002B9550
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

		// Token: 0x17001F4D RID: 8013
		// (get) Token: 0x06009883 RID: 39043 RVA: 0x002BB3EC File Offset: 0x002B95EC
		// (set) Token: 0x06009884 RID: 39044 RVA: 0x002BB40C File Offset: 0x002B960C
		[DoNotToLua]
		public new ArenaDefendUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ArenaDefendUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06009885 RID: 39045 RVA: 0x002BB418 File Offset: 0x002B9618
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06009886 RID: 39046 RVA: 0x002BB424 File Offset: 0x002B9624
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06009887 RID: 39047 RVA: 0x002BB42C File Offset: 0x002B962C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06009888 RID: 39048 RVA: 0x002BB434 File Offset: 0x002B9634
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06009889 RID: 39049 RVA: 0x002BB448 File Offset: 0x002B9648
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600988A RID: 39050 RVA: 0x002BB450 File Offset: 0x002B9650
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600988B RID: 39051 RVA: 0x002BB45C File Offset: 0x002B965C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600988C RID: 39052 RVA: 0x002BB468 File Offset: 0x002B9668
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600988D RID: 39053 RVA: 0x002BB474 File Offset: 0x002B9674
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600988E RID: 39054 RVA: 0x002BB480 File Offset: 0x002B9680
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600988F RID: 39055 RVA: 0x002BB48C File Offset: 0x002B968C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06009890 RID: 39056 RVA: 0x002BB498 File Offset: 0x002B9698
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06009891 RID: 39057 RVA: 0x002BB4A4 File Offset: 0x002B96A4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06009892 RID: 39058 RVA: 0x002BB4B0 File Offset: 0x002B96B0
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06009893 RID: 39059 RVA: 0x002BB4BC File Offset: 0x002B96BC
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06009894 RID: 39060 RVA: 0x002BB4C4 File Offset: 0x002B96C4
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x06009895 RID: 39061 RVA: 0x002BB4E4 File Offset: 0x002B96E4
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x06009896 RID: 39062 RVA: 0x002BB4F0 File Offset: 0x002B96F0
		private void __callDele_EventOnSave()
		{
			Action eventOnSave = this.EventOnSave;
			if (eventOnSave != null)
			{
				eventOnSave();
			}
		}

		// Token: 0x06009897 RID: 39063 RVA: 0x002BB510 File Offset: 0x002B9710
		private void __clearDele_EventOnSave()
		{
			this.EventOnSave = null;
		}

		// Token: 0x06009898 RID: 39064 RVA: 0x002BB51C File Offset: 0x002B971C
		private void __callDele_EventOnShowActionOrderPanel()
		{
			Action eventOnShowActionOrderPanel = this.EventOnShowActionOrderPanel;
			if (eventOnShowActionOrderPanel != null)
			{
				eventOnShowActionOrderPanel();
			}
		}

		// Token: 0x06009899 RID: 39065 RVA: 0x002BB53C File Offset: 0x002B973C
		private void __clearDele_EventOnShowActionOrderPanel()
		{
			this.EventOnShowActionOrderPanel = null;
		}

		// Token: 0x0600989A RID: 39066 RVA: 0x002BB548 File Offset: 0x002B9748
		private void __callDele_EventOnShowMapPanel()
		{
			Action eventOnShowMapPanel = this.EventOnShowMapPanel;
			if (eventOnShowMapPanel != null)
			{
				eventOnShowMapPanel();
			}
		}

		// Token: 0x0600989B RID: 39067 RVA: 0x002BB568 File Offset: 0x002B9768
		private void __clearDele_EventOnShowMapPanel()
		{
			this.EventOnShowMapPanel = null;
		}

		// Token: 0x0600989C RID: 39068 RVA: 0x002BB574 File Offset: 0x002B9774
		private void __callDele_EventOnShowDefendRulePanel()
		{
			Action eventOnShowDefendRulePanel = this.EventOnShowDefendRulePanel;
			if (eventOnShowDefendRulePanel != null)
			{
				eventOnShowDefendRulePanel();
			}
		}

		// Token: 0x0600989D RID: 39069 RVA: 0x002BB594 File Offset: 0x002B9794
		private void __clearDele_EventOnShowDefendRulePanel()
		{
			this.EventOnShowDefendRulePanel = null;
		}

		// Token: 0x0600989E RID: 39070 RVA: 0x002BB5A0 File Offset: 0x002B97A0
		private void __callDele_EventOnConfirmActionOrder()
		{
			Action eventOnConfirmActionOrder = this.EventOnConfirmActionOrder;
			if (eventOnConfirmActionOrder != null)
			{
				eventOnConfirmActionOrder();
			}
		}

		// Token: 0x0600989F RID: 39071 RVA: 0x002BB5C0 File Offset: 0x002B97C0
		private void __clearDele_EventOnConfirmActionOrder()
		{
			this.EventOnConfirmActionOrder = null;
		}

		// Token: 0x060098A0 RID: 39072 RVA: 0x002BB5CC File Offset: 0x002B97CC
		private void __callDele_EventOnConfirmMap(int obj)
		{
			Action<int> eventOnConfirmMap = this.EventOnConfirmMap;
			if (eventOnConfirmMap != null)
			{
				eventOnConfirmMap(obj);
			}
		}

		// Token: 0x060098A1 RID: 39073 RVA: 0x002BB5F0 File Offset: 0x002B97F0
		private void __clearDele_EventOnConfirmMap(int obj)
		{
			this.EventOnConfirmMap = null;
		}

		// Token: 0x060098A2 RID: 39074 RVA: 0x002BB5FC File Offset: 0x002B97FC
		private void __callDele_EventOnConfirmDefendRule(int obj)
		{
			Action<int> eventOnConfirmDefendRule = this.EventOnConfirmDefendRule;
			if (eventOnConfirmDefendRule != null)
			{
				eventOnConfirmDefendRule(obj);
			}
		}

		// Token: 0x060098A3 RID: 39075 RVA: 0x002BB620 File Offset: 0x002B9820
		private void __clearDele_EventOnConfirmDefendRule(int obj)
		{
			this.EventOnConfirmDefendRule = null;
		}

		// Token: 0x060098A4 RID: 39076 RVA: 0x002BB62C File Offset: 0x002B982C
		private void __callDele_EventOnShowMyActorInfo(BattleHero obj)
		{
			Action<BattleHero> eventOnShowMyActorInfo = this.EventOnShowMyActorInfo;
			if (eventOnShowMyActorInfo != null)
			{
				eventOnShowMyActorInfo(obj);
			}
		}

		// Token: 0x060098A5 RID: 39077 RVA: 0x002BB650 File Offset: 0x002B9850
		private void __clearDele_EventOnShowMyActorInfo(BattleHero obj)
		{
			this.EventOnShowMyActorInfo = null;
		}

		// Token: 0x060098A6 RID: 39078 RVA: 0x002BB65C File Offset: 0x002B985C
		private void __callDele_EventOnHideActorInfo()
		{
			Action eventOnHideActorInfo = this.EventOnHideActorInfo;
			if (eventOnHideActorInfo != null)
			{
				eventOnHideActorInfo();
			}
		}

		// Token: 0x060098A7 RID: 39079 RVA: 0x002BB67C File Offset: 0x002B987C
		private void __clearDele_EventOnHideActorInfo()
		{
			this.EventOnHideActorInfo = null;
		}

		// Token: 0x060098A8 RID: 39080 RVA: 0x002BB688 File Offset: 0x002B9888
		private void __callDele_EventOnStageActorChange()
		{
			Action eventOnStageActorChange = this.EventOnStageActorChange;
			if (eventOnStageActorChange != null)
			{
				eventOnStageActorChange();
			}
		}

		// Token: 0x060098A9 RID: 39081 RVA: 0x002BB6A8 File Offset: 0x002B98A8
		private void __clearDele_EventOnStageActorChange()
		{
			this.EventOnStageActorChange = null;
		}

		// Token: 0x060098AA RID: 39082 RVA: 0x002BB6B4 File Offset: 0x002B98B4
		private void __callDele_EventOnHeroOnStage(BattleHero arg1, GridPosition arg2)
		{
			Action<BattleHero, GridPosition> eventOnHeroOnStage = this.EventOnHeroOnStage;
			if (eventOnHeroOnStage != null)
			{
				eventOnHeroOnStage(arg1, arg2);
			}
		}

		// Token: 0x060098AB RID: 39083 RVA: 0x002BB6D8 File Offset: 0x002B98D8
		private void __clearDele_EventOnHeroOnStage(BattleHero arg1, GridPosition arg2)
		{
			this.EventOnHeroOnStage = null;
		}

		// Token: 0x060098AC RID: 39084 RVA: 0x002BB6E4 File Offset: 0x002B98E4
		private void __callDele_EventOnActorOffStage(ArenaDefendActor obj)
		{
			Action<ArenaDefendActor> eventOnActorOffStage = this.EventOnActorOffStage;
			if (eventOnActorOffStage != null)
			{
				eventOnActorOffStage(obj);
			}
		}

		// Token: 0x060098AD RID: 39085 RVA: 0x002BB708 File Offset: 0x002B9908
		private void __clearDele_EventOnActorOffStage(ArenaDefendActor obj)
		{
			this.EventOnActorOffStage = null;
		}

		// Token: 0x060098AE RID: 39086 RVA: 0x002BB714 File Offset: 0x002B9914
		private void __callDele_EventOnStageActorMove(ArenaDefendActor arg1, GridPosition arg2)
		{
			Action<ArenaDefendActor, GridPosition> eventOnStageActorMove = this.EventOnStageActorMove;
			if (eventOnStageActorMove != null)
			{
				eventOnStageActorMove(arg1, arg2);
			}
		}

		// Token: 0x060098AF RID: 39087 RVA: 0x002BB738 File Offset: 0x002B9938
		private void __clearDele_EventOnStageActorMove(ArenaDefendActor arg1, GridPosition arg2)
		{
			this.EventOnStageActorMove = null;
		}

		// Token: 0x060098B0 RID: 39088 RVA: 0x002BB744 File Offset: 0x002B9944
		private void __callDele_EventOnStageActorSwap(ArenaDefendActor arg1, ArenaDefendActor arg2)
		{
			Action<ArenaDefendActor, ArenaDefendActor> eventOnStageActorSwap = this.EventOnStageActorSwap;
			if (eventOnStageActorSwap != null)
			{
				eventOnStageActorSwap(arg1, arg2);
			}
		}

		// Token: 0x060098B1 RID: 39089 RVA: 0x002BB768 File Offset: 0x002B9968
		private void __clearDele_EventOnStageActorSwap(ArenaDefendActor arg1, ArenaDefendActor arg2)
		{
			this.EventOnStageActorSwap = null;
		}

		// Token: 0x060098B2 RID: 39090 RVA: 0x002BB774 File Offset: 0x002B9974
		private void __callDele_EventOnPointerDown(PointerEventData.InputButton arg1, Vector2 arg2)
		{
			Action<PointerEventData.InputButton, Vector2> eventOnPointerDown = this.EventOnPointerDown;
			if (eventOnPointerDown != null)
			{
				eventOnPointerDown(arg1, arg2);
			}
		}

		// Token: 0x060098B3 RID: 39091 RVA: 0x002BB798 File Offset: 0x002B9998
		private void __clearDele_EventOnPointerDown(PointerEventData.InputButton arg1, Vector2 arg2)
		{
			this.EventOnPointerDown = null;
		}

		// Token: 0x060098B4 RID: 39092 RVA: 0x002BB7A4 File Offset: 0x002B99A4
		private void __callDele_EventOnPointerUp(PointerEventData.InputButton arg1, Vector2 arg2)
		{
			Action<PointerEventData.InputButton, Vector2> eventOnPointerUp = this.EventOnPointerUp;
			if (eventOnPointerUp != null)
			{
				eventOnPointerUp(arg1, arg2);
			}
		}

		// Token: 0x060098B5 RID: 39093 RVA: 0x002BB7C8 File Offset: 0x002B99C8
		private void __clearDele_EventOnPointerUp(PointerEventData.InputButton arg1, Vector2 arg2)
		{
			this.EventOnPointerUp = null;
		}

		// Token: 0x060098B6 RID: 39094 RVA: 0x002BB7D4 File Offset: 0x002B99D4
		private void __callDele_EventOnPointerClick(PointerEventData.InputButton arg1, Vector2 arg2)
		{
			Action<PointerEventData.InputButton, Vector2> eventOnPointerClick = this.EventOnPointerClick;
			if (eventOnPointerClick != null)
			{
				eventOnPointerClick(arg1, arg2);
			}
		}

		// Token: 0x060098B7 RID: 39095 RVA: 0x002BB7F8 File Offset: 0x002B99F8
		private void __clearDele_EventOnPointerClick(PointerEventData.InputButton arg1, Vector2 arg2)
		{
			this.EventOnPointerClick = null;
		}

		// Token: 0x060098BE RID: 39102 RVA: 0x002BB864 File Offset: 0x002B9A64
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
					this.m_InitializeArenaDefendBattle_hotfix = (luaObj.RawGet("Initialize") as LuaFunction);
					this.m_OnDisable_hotfix = (luaObj.RawGet("OnDisable") as LuaFunction);
					this.m_OnApplicationPauseBoolean_hotfix = (luaObj.RawGet("OnApplicationPause") as LuaFunction);
					this.m_OnApplicationFocusBoolean_hotfix = (luaObj.RawGet("OnApplicationFocus") as LuaFunction);
					this.m_CancelDragging_hotfix = (luaObj.RawGet("CancelDragging") as LuaFunction);
					this.m_SetHeroActionOrdersList`1_hotfix = (luaObj.RawGet("SetHeroActionOrders") as LuaFunction);
					this.m_GetHeroActionOrderIndexBattleHero_hotfix = (luaObj.RawGet("GetHeroActionOrderIndex") as LuaFunction);
					this.m_SetMapsList`1Int32_hotfix = (luaObj.RawGet("SetMaps") as LuaFunction);
					this.m_SetDefendRulesList`1Int32_hotfix = (luaObj.RawGet("SetDefendRules") as LuaFunction);
					this.m_SetBattlePowerInt32_hotfix = (luaObj.RawGet("SetBattlePower") as LuaFunction);
					this.m_Co_SetBattlePowerValueInt32Int32_hotfix = (luaObj.RawGet("Co_SetBattlePowerValue") as LuaFunction);
					this.m_ClearBattlePowerValue_hotfix = (luaObj.RawGet("ClearBattlePowerValue") as LuaFunction);
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_CheckStageAtorChange_hotfix = (luaObj.RawGet("CheckStageAtorChange") as LuaFunction);
					this.m_SetStageActorCountMaxInt32_hotfix = (luaObj.RawGet("SetStageActorCountMax") as LuaFunction);
					this.m_UpdateStageActorCount_hotfix = (luaObj.RawGet("UpdateStageActorCount") as LuaFunction);
					this.m_ClearHeros_hotfix = (luaObj.RawGet("ClearHeros") as LuaFunction);
					this.m_AddHeroBattleHero_hotfix = (luaObj.RawGet("AddHero") as LuaFunction);
					this.m_ClearStagePositions_hotfix = (luaObj.RawGet("ClearStagePositions") as LuaFunction);
					this.m_AddStagePositionGridPositionInt32_hotfix = (luaObj.RawGet("AddStagePosition") as LuaFunction);
					this.m_GetStagePositions_hotfix = (luaObj.RawGet("GetStagePositions") as LuaFunction);
					this.m_GetStageDirectionGridPosition_hotfix = (luaObj.RawGet("GetStageDirection") as LuaFunction);
					this.m_CreateHeroButtonBattleHeroTransform_hotfix = (luaObj.RawGet("CreateHeroButton") as LuaFunction);
					this.m_HeroOnStageBattleHeroGridPosition_hotfix = (luaObj.RawGet("HeroOnStage") as LuaFunction);
					this.m_ActorOffStageArenaDefendActor_hotfix = (luaObj.RawGet("ActorOffStage") as LuaFunction);
					this.m_ActorOnStageMoveArenaDefendActorGridPosition_hotfix = (luaObj.RawGet("ActorOnStageMove") as LuaFunction);
					this.m_ActorOnStageExchangeArenaDefendActorArenaDefendActor_hotfix = (luaObj.RawGet("ActorOnStageExchange") as LuaFunction);
					this.m_ClearStageActors_hotfix = (luaObj.RawGet("ClearStageActors") as LuaFunction);
					this.m_GetStageActorGridPosition_hotfix = (luaObj.RawGet("GetStageActor") as LuaFunction);
					this.m_GetStageActors_hotfix = (luaObj.RawGet("GetStageActors") as LuaFunction);
					this.m_UpdateStageActorBattleHero_hotfix = (luaObj.RawGet("UpdateStageActor") as LuaFunction);
					this.m_HeroDragButton_OnBeginDragHeroDragButtonPointerEventData_hotfix = (luaObj.RawGet("HeroDragButton_OnBeginDrag") as LuaFunction);
					this.m_HeroDragButton_OnEndDragHeroDragButtonPointerEventData_hotfix = (luaObj.RawGet("HeroDragButton_OnEndDrag") as LuaFunction);
					this.m_HeroDragButton_OnDragPointerEventData_hotfix = (luaObj.RawGet("HeroDragButton_OnDrag") as LuaFunction);
					this.m_HeroDragButton_OnDropPointerEventData_hotfix = (luaObj.RawGet("HeroDragButton_OnDrop") as LuaFunction);
					this.m_HeroDragButton_OnClickHeroDragButton_hotfix = (luaObj.RawGet("HeroDragButton_OnClick") as LuaFunction);
					this.m_HideActorInfo_hotfix = (luaObj.RawGet("HideActorInfo") as LuaFunction);
					this.m_ClearPointerDownStageActor_hotfix = (luaObj.RawGet("ClearPointerDownStageActor") as LuaFunction);
					this.m_OnScenePointerDownPointerEventData_hotfix = (luaObj.RawGet("OnScenePointerDown") as LuaFunction);
					this.m_OnScenePointerUpPointerEventData_hotfix = (luaObj.RawGet("OnScenePointerUp") as LuaFunction);
					this.m_OnScenePointerClickPointerEventData_hotfix = (luaObj.RawGet("OnScenePointerClick") as LuaFunction);
					this.m_OnSceneBeginDragPointerEventData_hotfix = (luaObj.RawGet("OnSceneBeginDrag") as LuaFunction);
					this.m_OnSceneEndDragPointerEventData_hotfix = (luaObj.RawGet("OnSceneEndDrag") as LuaFunction);
					this.m_OnSceneDragPointerEventData_hotfix = (luaObj.RawGet("OnSceneDrag") as LuaFunction);
					this.m_CreateDraggingHeroButtonBattleHero_hotfix = (luaObj.RawGet("CreateDraggingHeroButton") as LuaFunction);
					this.m_DestroyDragginHeroButton_hotfix = (luaObj.RawGet("DestroyDragginHeroButton") as LuaFunction);
					this.m_MoveDraggingHeroButtonVector2_hotfix = (luaObj.RawGet("MoveDraggingHeroButton") as LuaFunction);
					this.m_DropHeroButtonVector2_hotfix = (luaObj.RawGet("DropHeroButton") as LuaFunction);
					this.m_ShowActionOrderPanel_hotfix = (luaObj.RawGet("ShowActionOrderPanel") as LuaFunction);
					this.m_ShowMapPanel_hotfix = (luaObj.RawGet("ShowMapPanel") as LuaFunction);
					this.m_ShowDefendRulePanel_hotfix = (luaObj.RawGet("ShowDefendRulePanel") as LuaFunction);
					this.m_CreateActionOrderButtonBattleHeroTransform_hotfix = (luaObj.RawGet("CreateActionOrderButton") as LuaFunction);
					this.m_CreateDraggingActionOrderButtonBattleHero_hotfix = (luaObj.RawGet("CreateDraggingActionOrderButton") as LuaFunction);
					this.m_DestroyDragginActionOrderButton_hotfix = (luaObj.RawGet("DestroyDragginActionOrderButton") as LuaFunction);
					this.m_MoveDraggingActionOrderButtonVector2_hotfix = (luaObj.RawGet("MoveDraggingActionOrderButton") as LuaFunction);
					this.m_DropDraggingActionOrderButtonVector2_hotfix = (luaObj.RawGet("DropDraggingActionOrderButton") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_OnSaveTeamButtonClick_hotfix = (luaObj.RawGet("OnSaveTeamButtonClick") as LuaFunction);
					this.m_OnShowActionOrderButtonClick_hotfix = (luaObj.RawGet("OnShowActionOrderButtonClick") as LuaFunction);
					this.m_OnShowMapButtonClick_hotfix = (luaObj.RawGet("OnShowMapButtonClick") as LuaFunction);
					this.m_OnShowDefendRuleButtonClick_hotfix = (luaObj.RawGet("OnShowDefendRuleButtonClick") as LuaFunction);
					this.m_OnPanelBackgroundButtonClick_hotfix = (luaObj.RawGet("OnPanelBackgroundButtonClick") as LuaFunction);
					this.m_OnActionOrderOkButtonClick_hotfix = (luaObj.RawGet("OnActionOrderOkButtonClick") as LuaFunction);
					this.m_ActionOrderButton_OnClickArenaActionOrderButton_hotfix = (luaObj.RawGet("ActionOrderButton_OnClick") as LuaFunction);
					this.m_ActionOrderButton_OnBeginDragArenaActionOrderButtonPointerEventData_hotfix = (luaObj.RawGet("ActionOrderButton_OnBeginDrag") as LuaFunction);
					this.m_ActionOrderButton_OnEndDragArenaActionOrderButtonPointerEventData_hotfix = (luaObj.RawGet("ActionOrderButton_OnEndDrag") as LuaFunction);
					this.m_ActionOrderButton_OnDragPointerEventData_hotfix = (luaObj.RawGet("ActionOrderButton_OnDrag") as LuaFunction);
					this.m_ActionOrderButton_OnDropPointerEventData_hotfix = (luaObj.RawGet("ActionOrderButton_OnDrop") as LuaFunction);
					this.m_OnMapOkButtonClick_hotfix = (luaObj.RawGet("OnMapOkButtonClick") as LuaFunction);
					this.m_OnDefendRuleOkButtonClick_hotfix = (luaObj.RawGet("OnDefendRuleOkButtonClick") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnSaveAction_hotfix = (luaObj.RawGet("add_EventOnSave") as LuaFunction);
					this.m_remove_EventOnSaveAction_hotfix = (luaObj.RawGet("remove_EventOnSave") as LuaFunction);
					this.m_add_EventOnShowActionOrderPanelAction_hotfix = (luaObj.RawGet("add_EventOnShowActionOrderPanel") as LuaFunction);
					this.m_remove_EventOnShowActionOrderPanelAction_hotfix = (luaObj.RawGet("remove_EventOnShowActionOrderPanel") as LuaFunction);
					this.m_add_EventOnShowMapPanelAction_hotfix = (luaObj.RawGet("add_EventOnShowMapPanel") as LuaFunction);
					this.m_remove_EventOnShowMapPanelAction_hotfix = (luaObj.RawGet("remove_EventOnShowMapPanel") as LuaFunction);
					this.m_add_EventOnShowDefendRulePanelAction_hotfix = (luaObj.RawGet("add_EventOnShowDefendRulePanel") as LuaFunction);
					this.m_remove_EventOnShowDefendRulePanelAction_hotfix = (luaObj.RawGet("remove_EventOnShowDefendRulePanel") as LuaFunction);
					this.m_add_EventOnConfirmActionOrderAction_hotfix = (luaObj.RawGet("add_EventOnConfirmActionOrder") as LuaFunction);
					this.m_remove_EventOnConfirmActionOrderAction_hotfix = (luaObj.RawGet("remove_EventOnConfirmActionOrder") as LuaFunction);
					this.m_add_EventOnConfirmMapAction`1_hotfix = (luaObj.RawGet("add_EventOnConfirmMap") as LuaFunction);
					this.m_remove_EventOnConfirmMapAction`1_hotfix = (luaObj.RawGet("remove_EventOnConfirmMap") as LuaFunction);
					this.m_add_EventOnConfirmDefendRuleAction`1_hotfix = (luaObj.RawGet("add_EventOnConfirmDefendRule") as LuaFunction);
					this.m_remove_EventOnConfirmDefendRuleAction`1_hotfix = (luaObj.RawGet("remove_EventOnConfirmDefendRule") as LuaFunction);
					this.m_add_EventOnShowMyActorInfoAction`1_hotfix = (luaObj.RawGet("add_EventOnShowMyActorInfo") as LuaFunction);
					this.m_remove_EventOnShowMyActorInfoAction`1_hotfix = (luaObj.RawGet("remove_EventOnShowMyActorInfo") as LuaFunction);
					this.m_add_EventOnHideActorInfoAction_hotfix = (luaObj.RawGet("add_EventOnHideActorInfo") as LuaFunction);
					this.m_remove_EventOnHideActorInfoAction_hotfix = (luaObj.RawGet("remove_EventOnHideActorInfo") as LuaFunction);
					this.m_add_EventOnStageActorChangeAction_hotfix = (luaObj.RawGet("add_EventOnStageActorChange") as LuaFunction);
					this.m_remove_EventOnStageActorChangeAction_hotfix = (luaObj.RawGet("remove_EventOnStageActorChange") as LuaFunction);
					this.m_add_EventOnHeroOnStageAction`2_hotfix = (luaObj.RawGet("add_EventOnHeroOnStage") as LuaFunction);
					this.m_remove_EventOnHeroOnStageAction`2_hotfix = (luaObj.RawGet("remove_EventOnHeroOnStage") as LuaFunction);
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
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060098BF RID: 39103 RVA: 0x002BC38C File Offset: 0x002BA58C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaDefendUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006882 RID: 26754
		[AutoBind("./Margin", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_marginTransform;

		// Token: 0x04006883 RID: 26755
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x04006884 RID: 26756
		[AutoBind("./SaveButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_saveTeamButton;

		// Token: 0x04006885 RID: 26757
		[AutoBind("./Margin/ActionOrderButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_actionOrderButton;

		// Token: 0x04006886 RID: 26758
		[AutoBind("./Margin/MapButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_mapButton;

		// Token: 0x04006887 RID: 26759
		[AutoBind("./Margin/DefendRuleButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_defendRuleButton;

		// Token: 0x04006888 RID: 26760
		[AutoBind("./Title/ActorCount/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_stageActorCountText;

		// Token: 0x04006889 RID: 26761
		[AutoBind("./ActorList/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_actorListScrollRect;

		// Token: 0x0400688A RID: 26762
		[AutoBind("./BattlePower", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_battlePowerUIStateController;

		// Token: 0x0400688B RID: 26763
		[AutoBind("./BattlePower/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_battlePowerText;

		// Token: 0x0400688C RID: 26764
		[AutoBind("./Panels", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_panelGameObject;

		// Token: 0x0400688D RID: 26765
		[AutoBind("./Panels/BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_panelBackgroundButton;

		// Token: 0x0400688E RID: 26766
		[AutoBind("./Panels/ActionOrder", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_actionOrderPanelUIStateController;

		// Token: 0x0400688F RID: 26767
		[AutoBind("./Panels/ActionOrder", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_actionOrderPanelGameObject;

		// Token: 0x04006890 RID: 26768
		[AutoBind("./Panels/ActionOrder/Slots", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_actionOrdersGameObject;

		// Token: 0x04006891 RID: 26769
		[AutoBind("./Panels/ActionOrder/OkButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_actionOrderOkButton;

		// Token: 0x04006892 RID: 26770
		[AutoBind("./Panels/Map", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_mapPanelUIStateController;

		// Token: 0x04006893 RID: 26771
		[AutoBind("./Panels/Map", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_mapPanelGameObject;

		// Token: 0x04006894 RID: 26772
		[AutoBind("./Panels/Map/Maps", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_mapsGameObject;

		// Token: 0x04006895 RID: 26773
		[AutoBind("./Panels/Map/OkButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_mapOkButton;

		// Token: 0x04006896 RID: 26774
		[AutoBind("./Panels/DefendRule", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_defendRulePanelUIStateController;

		// Token: 0x04006897 RID: 26775
		[AutoBind("./Panels/DefendRule", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_defendRulePanelGameObject;

		// Token: 0x04006898 RID: 26776
		[AutoBind("./Panels/DefendRule/Rules", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_defendRulesGameObject;

		// Token: 0x04006899 RID: 26777
		[AutoBind("./Panels/DefendRule/OkButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_defendRuleOkButton;

		// Token: 0x0400689A RID: 26778
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_prefabsGameObject;

		// Token: 0x0400689B RID: 26779
		[AutoBind("./Prefabs/HeroButton", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroButtonPrefab;

		// Token: 0x0400689C RID: 26780
		[AutoBind("./Prefabs/ActionOrderButton", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_actionOrderButtonPrefab;

		// Token: 0x0400689D RID: 26781
		private Camera m_camera;

		// Token: 0x0400689E RID: 26782
		private bool m_isIgnorePointerClick;

		// Token: 0x0400689F RID: 26783
		private ArenaDefendActor m_pointerDownStageActor;

		// Token: 0x040068A0 RID: 26784
		private int m_stageActorCountMax;

		// Token: 0x040068A1 RID: 26785
		private bool m_isStageActorChanged;

		// Token: 0x040068A2 RID: 26786
		private List<HeroDragButton> m_heroButtons = new List<HeroDragButton>();

		// Token: 0x040068A3 RID: 26787
		private List<ArenaDefendActor> m_stageActors = new List<ArenaDefendActor>();

		// Token: 0x040068A4 RID: 26788
		private List<GridPosition> m_stagePositions = new List<GridPosition>();

		// Token: 0x040068A5 RID: 26789
		private List<int> m_stageDirs = new List<int>();

		// Token: 0x040068A6 RID: 26790
		private ArenaActionOrderButton[] m_actionOrderButtons = new ArenaActionOrderButton[5];

		// Token: 0x040068A7 RID: 26791
		private ArenaDefendMapToggle[] m_defendMapToggles = new ArenaDefendMapToggle[3];

		// Token: 0x040068A8 RID: 26792
		private ArenaDefendRuleToggle[] m_defendRuleToggles = new ArenaDefendRuleToggle[3];

		// Token: 0x040068A9 RID: 26793
		private HeroDragButton m_draggingHeroButton;

		// Token: 0x040068AA RID: 26794
		private ArenaActionOrderButton m_draggingActionOrderButton;

		// Token: 0x040068AB RID: 26795
		private int m_draggingActionOrderButtonIndex;

		// Token: 0x040068AC RID: 26796
		private ArenaDefendBattle m_arenaDefendBattle;

		// Token: 0x040068AD RID: 26797
		private int m_battlePowerValue;

		// Token: 0x040068AE RID: 26798
		private Coroutine m_setBattlePowerValueCoroutine;

		// Token: 0x040068AF RID: 26799
		[DoNotToLua]
		private ArenaDefendUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040068B0 RID: 26800
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040068B1 RID: 26801
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040068B2 RID: 26802
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040068B3 RID: 26803
		private LuaFunction m_InitializeArenaDefendBattle_hotfix;

		// Token: 0x040068B4 RID: 26804
		private LuaFunction m_OnDisable_hotfix;

		// Token: 0x040068B5 RID: 26805
		private LuaFunction m_OnApplicationPauseBoolean_hotfix;

		// Token: 0x040068B6 RID: 26806
		private LuaFunction m_OnApplicationFocusBoolean_hotfix;

		// Token: 0x040068B7 RID: 26807
		private LuaFunction m_CancelDragging_hotfix;

		// Token: 0x040068B8 RID: 26808
		private LuaFunction m_SetHeroActionOrdersList;

		// Token: 0x040068B9 RID: 26809
		private LuaFunction m_GetHeroActionOrderIndexBattleHero_hotfix;

		// Token: 0x040068BA RID: 26810
		private LuaFunction m_SetMapsList;

		// Token: 0x040068BB RID: 26811
		private LuaFunction m_SetDefendRulesList;

		// Token: 0x040068BC RID: 26812
		private LuaFunction m_SetBattlePowerInt32_hotfix;

		// Token: 0x040068BD RID: 26813
		private LuaFunction m_Co_SetBattlePowerValueInt32Int32_hotfix;

		// Token: 0x040068BE RID: 26814
		private LuaFunction m_ClearBattlePowerValue_hotfix;

		// Token: 0x040068BF RID: 26815
		private LuaFunction m_Update_hotfix;

		// Token: 0x040068C0 RID: 26816
		private LuaFunction m_CheckStageAtorChange_hotfix;

		// Token: 0x040068C1 RID: 26817
		private LuaFunction m_SetStageActorCountMaxInt32_hotfix;

		// Token: 0x040068C2 RID: 26818
		private LuaFunction m_UpdateStageActorCount_hotfix;

		// Token: 0x040068C3 RID: 26819
		private LuaFunction m_ClearHeros_hotfix;

		// Token: 0x040068C4 RID: 26820
		private LuaFunction m_AddHeroBattleHero_hotfix;

		// Token: 0x040068C5 RID: 26821
		private LuaFunction m_ClearStagePositions_hotfix;

		// Token: 0x040068C6 RID: 26822
		private LuaFunction m_AddStagePositionGridPositionInt32_hotfix;

		// Token: 0x040068C7 RID: 26823
		private LuaFunction m_GetStagePositions_hotfix;

		// Token: 0x040068C8 RID: 26824
		private LuaFunction m_GetStageDirectionGridPosition_hotfix;

		// Token: 0x040068C9 RID: 26825
		private LuaFunction m_CreateHeroButtonBattleHeroTransform_hotfix;

		// Token: 0x040068CA RID: 26826
		private LuaFunction m_HeroOnStageBattleHeroGridPosition_hotfix;

		// Token: 0x040068CB RID: 26827
		private LuaFunction m_ActorOffStageArenaDefendActor_hotfix;

		// Token: 0x040068CC RID: 26828
		private LuaFunction m_ActorOnStageMoveArenaDefendActorGridPosition_hotfix;

		// Token: 0x040068CD RID: 26829
		private LuaFunction m_ActorOnStageExchangeArenaDefendActorArenaDefendActor_hotfix;

		// Token: 0x040068CE RID: 26830
		private LuaFunction m_ClearStageActors_hotfix;

		// Token: 0x040068CF RID: 26831
		private LuaFunction m_GetStageActorGridPosition_hotfix;

		// Token: 0x040068D0 RID: 26832
		private LuaFunction m_GetStageActors_hotfix;

		// Token: 0x040068D1 RID: 26833
		private LuaFunction m_UpdateStageActorBattleHero_hotfix;

		// Token: 0x040068D2 RID: 26834
		private LuaFunction m_HeroDragButton_OnBeginDragHeroDragButtonPointerEventData_hotfix;

		// Token: 0x040068D3 RID: 26835
		private LuaFunction m_HeroDragButton_OnEndDragHeroDragButtonPointerEventData_hotfix;

		// Token: 0x040068D4 RID: 26836
		private LuaFunction m_HeroDragButton_OnDragPointerEventData_hotfix;

		// Token: 0x040068D5 RID: 26837
		private LuaFunction m_HeroDragButton_OnDropPointerEventData_hotfix;

		// Token: 0x040068D6 RID: 26838
		private LuaFunction m_HeroDragButton_OnClickHeroDragButton_hotfix;

		// Token: 0x040068D7 RID: 26839
		private LuaFunction m_HideActorInfo_hotfix;

		// Token: 0x040068D8 RID: 26840
		private LuaFunction m_ClearPointerDownStageActor_hotfix;

		// Token: 0x040068D9 RID: 26841
		private LuaFunction m_OnScenePointerDownPointerEventData_hotfix;

		// Token: 0x040068DA RID: 26842
		private LuaFunction m_OnScenePointerUpPointerEventData_hotfix;

		// Token: 0x040068DB RID: 26843
		private LuaFunction m_OnScenePointerClickPointerEventData_hotfix;

		// Token: 0x040068DC RID: 26844
		private LuaFunction m_OnSceneBeginDragPointerEventData_hotfix;

		// Token: 0x040068DD RID: 26845
		private LuaFunction m_OnSceneEndDragPointerEventData_hotfix;

		// Token: 0x040068DE RID: 26846
		private LuaFunction m_OnSceneDragPointerEventData_hotfix;

		// Token: 0x040068DF RID: 26847
		private LuaFunction m_CreateDraggingHeroButtonBattleHero_hotfix;

		// Token: 0x040068E0 RID: 26848
		private LuaFunction m_DestroyDragginHeroButton_hotfix;

		// Token: 0x040068E1 RID: 26849
		private LuaFunction m_MoveDraggingHeroButtonVector2_hotfix;

		// Token: 0x040068E2 RID: 26850
		private LuaFunction m_DropHeroButtonVector2_hotfix;

		// Token: 0x040068E3 RID: 26851
		private LuaFunction m_ShowActionOrderPanel_hotfix;

		// Token: 0x040068E4 RID: 26852
		private LuaFunction m_ShowMapPanel_hotfix;

		// Token: 0x040068E5 RID: 26853
		private LuaFunction m_ShowDefendRulePanel_hotfix;

		// Token: 0x040068E6 RID: 26854
		private LuaFunction m_CreateActionOrderButtonBattleHeroTransform_hotfix;

		// Token: 0x040068E7 RID: 26855
		private LuaFunction m_CreateDraggingActionOrderButtonBattleHero_hotfix;

		// Token: 0x040068E8 RID: 26856
		private LuaFunction m_DestroyDragginActionOrderButton_hotfix;

		// Token: 0x040068E9 RID: 26857
		private LuaFunction m_MoveDraggingActionOrderButtonVector2_hotfix;

		// Token: 0x040068EA RID: 26858
		private LuaFunction m_DropDraggingActionOrderButtonVector2_hotfix;

		// Token: 0x040068EB RID: 26859
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x040068EC RID: 26860
		private LuaFunction m_OnSaveTeamButtonClick_hotfix;

		// Token: 0x040068ED RID: 26861
		private LuaFunction m_OnShowActionOrderButtonClick_hotfix;

		// Token: 0x040068EE RID: 26862
		private LuaFunction m_OnShowMapButtonClick_hotfix;

		// Token: 0x040068EF RID: 26863
		private LuaFunction m_OnShowDefendRuleButtonClick_hotfix;

		// Token: 0x040068F0 RID: 26864
		private LuaFunction m_OnPanelBackgroundButtonClick_hotfix;

		// Token: 0x040068F1 RID: 26865
		private LuaFunction m_OnActionOrderOkButtonClick_hotfix;

		// Token: 0x040068F2 RID: 26866
		private LuaFunction m_ActionOrderButton_OnClickArenaActionOrderButton_hotfix;

		// Token: 0x040068F3 RID: 26867
		private LuaFunction m_ActionOrderButton_OnBeginDragArenaActionOrderButtonPointerEventData_hotfix;

		// Token: 0x040068F4 RID: 26868
		private LuaFunction m_ActionOrderButton_OnEndDragArenaActionOrderButtonPointerEventData_hotfix;

		// Token: 0x040068F5 RID: 26869
		private LuaFunction m_ActionOrderButton_OnDragPointerEventData_hotfix;

		// Token: 0x040068F6 RID: 26870
		private LuaFunction m_ActionOrderButton_OnDropPointerEventData_hotfix;

		// Token: 0x040068F7 RID: 26871
		private LuaFunction m_OnMapOkButtonClick_hotfix;

		// Token: 0x040068F8 RID: 26872
		private LuaFunction m_OnDefendRuleOkButtonClick_hotfix;

		// Token: 0x040068F9 RID: 26873
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x040068FA RID: 26874
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x040068FB RID: 26875
		private LuaFunction m_add_EventOnSaveAction_hotfix;

		// Token: 0x040068FC RID: 26876
		private LuaFunction m_remove_EventOnSaveAction_hotfix;

		// Token: 0x040068FD RID: 26877
		private LuaFunction m_add_EventOnShowActionOrderPanelAction_hotfix;

		// Token: 0x040068FE RID: 26878
		private LuaFunction m_remove_EventOnShowActionOrderPanelAction_hotfix;

		// Token: 0x040068FF RID: 26879
		private LuaFunction m_add_EventOnShowMapPanelAction_hotfix;

		// Token: 0x04006900 RID: 26880
		private LuaFunction m_remove_EventOnShowMapPanelAction_hotfix;

		// Token: 0x04006901 RID: 26881
		private LuaFunction m_add_EventOnShowDefendRulePanelAction_hotfix;

		// Token: 0x04006902 RID: 26882
		private LuaFunction m_remove_EventOnShowDefendRulePanelAction_hotfix;

		// Token: 0x04006903 RID: 26883
		private LuaFunction m_add_EventOnConfirmActionOrderAction_hotfix;

		// Token: 0x04006904 RID: 26884
		private LuaFunction m_remove_EventOnConfirmActionOrderAction_hotfix;

		// Token: 0x04006905 RID: 26885
		private LuaFunction m_add_EventOnConfirmMapAction;

		// Token: 0x04006906 RID: 26886
		private LuaFunction m_remove_EventOnConfirmMapAction;

		// Token: 0x04006907 RID: 26887
		private LuaFunction m_add_EventOnConfirmDefendRuleAction;

		// Token: 0x04006908 RID: 26888
		private LuaFunction m_remove_EventOnConfirmDefendRuleAction;

		// Token: 0x04006909 RID: 26889
		private LuaFunction m_add_EventOnShowMyActorInfoAction;

		// Token: 0x0400690A RID: 26890
		private LuaFunction m_remove_EventOnShowMyActorInfoAction;

		// Token: 0x0400690B RID: 26891
		private LuaFunction m_add_EventOnHideActorInfoAction_hotfix;

		// Token: 0x0400690C RID: 26892
		private LuaFunction m_remove_EventOnHideActorInfoAction_hotfix;

		// Token: 0x0400690D RID: 26893
		private LuaFunction m_add_EventOnStageActorChangeAction_hotfix;

		// Token: 0x0400690E RID: 26894
		private LuaFunction m_remove_EventOnStageActorChangeAction_hotfix;

		// Token: 0x0400690F RID: 26895
		private LuaFunction m_add_EventOnHeroOnStageAction;

		// Token: 0x04006910 RID: 26896
		private LuaFunction m_remove_EventOnHeroOnStageAction;

		// Token: 0x04006911 RID: 26897
		private LuaFunction m_add_EventOnActorOffStageAction;

		// Token: 0x04006912 RID: 26898
		private LuaFunction m_remove_EventOnActorOffStageAction;

		// Token: 0x04006913 RID: 26899
		private LuaFunction m_add_EventOnStageActorMoveAction;

		// Token: 0x04006914 RID: 26900
		private LuaFunction m_remove_EventOnStageActorMoveAction;

		// Token: 0x04006915 RID: 26901
		private LuaFunction m_add_EventOnStageActorSwapAction;

		// Token: 0x04006916 RID: 26902
		private LuaFunction m_remove_EventOnStageActorSwapAction;

		// Token: 0x04006917 RID: 26903
		private LuaFunction m_add_EventOnPointerDownAction;

		// Token: 0x04006918 RID: 26904
		private LuaFunction m_remove_EventOnPointerDownAction;

		// Token: 0x04006919 RID: 26905
		private LuaFunction m_add_EventOnPointerUpAction;

		// Token: 0x0400691A RID: 26906
		private LuaFunction m_remove_EventOnPointerUpAction;

		// Token: 0x0400691B RID: 26907
		private LuaFunction m_add_EventOnPointerClickAction;

		// Token: 0x0400691C RID: 26908
		private LuaFunction m_remove_EventOnPointerClickAction;

		// Token: 0x020009FB RID: 2555
		public new class LuaExportHelper
		{
			// Token: 0x060098C0 RID: 39104 RVA: 0x002BC3F4 File Offset: 0x002BA5F4
			public LuaExportHelper(ArenaDefendUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060098C1 RID: 39105 RVA: 0x002BC404 File Offset: 0x002BA604
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x060098C2 RID: 39106 RVA: 0x002BC414 File Offset: 0x002BA614
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x060098C3 RID: 39107 RVA: 0x002BC424 File Offset: 0x002BA624
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x060098C4 RID: 39108 RVA: 0x002BC434 File Offset: 0x002BA634
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x060098C5 RID: 39109 RVA: 0x002BC44C File Offset: 0x002BA64C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x060098C6 RID: 39110 RVA: 0x002BC45C File Offset: 0x002BA65C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x060098C7 RID: 39111 RVA: 0x002BC46C File Offset: 0x002BA66C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x060098C8 RID: 39112 RVA: 0x002BC47C File Offset: 0x002BA67C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x060098C9 RID: 39113 RVA: 0x002BC48C File Offset: 0x002BA68C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x060098CA RID: 39114 RVA: 0x002BC49C File Offset: 0x002BA69C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x060098CB RID: 39115 RVA: 0x002BC4AC File Offset: 0x002BA6AC
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x060098CC RID: 39116 RVA: 0x002BC4BC File Offset: 0x002BA6BC
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x060098CD RID: 39117 RVA: 0x002BC4CC File Offset: 0x002BA6CC
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x060098CE RID: 39118 RVA: 0x002BC4DC File Offset: 0x002BA6DC
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x060098CF RID: 39119 RVA: 0x002BC4EC File Offset: 0x002BA6EC
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x060098D0 RID: 39120 RVA: 0x002BC4FC File Offset: 0x002BA6FC
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x060098D1 RID: 39121 RVA: 0x002BC50C File Offset: 0x002BA70C
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x060098D2 RID: 39122 RVA: 0x002BC51C File Offset: 0x002BA71C
			public void __callDele_EventOnSave()
			{
				this.m_owner.__callDele_EventOnSave();
			}

			// Token: 0x060098D3 RID: 39123 RVA: 0x002BC52C File Offset: 0x002BA72C
			public void __clearDele_EventOnSave()
			{
				this.m_owner.__clearDele_EventOnSave();
			}

			// Token: 0x060098D4 RID: 39124 RVA: 0x002BC53C File Offset: 0x002BA73C
			public void __callDele_EventOnShowActionOrderPanel()
			{
				this.m_owner.__callDele_EventOnShowActionOrderPanel();
			}

			// Token: 0x060098D5 RID: 39125 RVA: 0x002BC54C File Offset: 0x002BA74C
			public void __clearDele_EventOnShowActionOrderPanel()
			{
				this.m_owner.__clearDele_EventOnShowActionOrderPanel();
			}

			// Token: 0x060098D6 RID: 39126 RVA: 0x002BC55C File Offset: 0x002BA75C
			public void __callDele_EventOnShowMapPanel()
			{
				this.m_owner.__callDele_EventOnShowMapPanel();
			}

			// Token: 0x060098D7 RID: 39127 RVA: 0x002BC56C File Offset: 0x002BA76C
			public void __clearDele_EventOnShowMapPanel()
			{
				this.m_owner.__clearDele_EventOnShowMapPanel();
			}

			// Token: 0x060098D8 RID: 39128 RVA: 0x002BC57C File Offset: 0x002BA77C
			public void __callDele_EventOnShowDefendRulePanel()
			{
				this.m_owner.__callDele_EventOnShowDefendRulePanel();
			}

			// Token: 0x060098D9 RID: 39129 RVA: 0x002BC58C File Offset: 0x002BA78C
			public void __clearDele_EventOnShowDefendRulePanel()
			{
				this.m_owner.__clearDele_EventOnShowDefendRulePanel();
			}

			// Token: 0x060098DA RID: 39130 RVA: 0x002BC59C File Offset: 0x002BA79C
			public void __callDele_EventOnConfirmActionOrder()
			{
				this.m_owner.__callDele_EventOnConfirmActionOrder();
			}

			// Token: 0x060098DB RID: 39131 RVA: 0x002BC5AC File Offset: 0x002BA7AC
			public void __clearDele_EventOnConfirmActionOrder()
			{
				this.m_owner.__clearDele_EventOnConfirmActionOrder();
			}

			// Token: 0x060098DC RID: 39132 RVA: 0x002BC5BC File Offset: 0x002BA7BC
			public void __callDele_EventOnConfirmMap(int obj)
			{
				this.m_owner.__callDele_EventOnConfirmMap(obj);
			}

			// Token: 0x060098DD RID: 39133 RVA: 0x002BC5CC File Offset: 0x002BA7CC
			public void __clearDele_EventOnConfirmMap(int obj)
			{
				this.m_owner.__clearDele_EventOnConfirmMap(obj);
			}

			// Token: 0x060098DE RID: 39134 RVA: 0x002BC5DC File Offset: 0x002BA7DC
			public void __callDele_EventOnConfirmDefendRule(int obj)
			{
				this.m_owner.__callDele_EventOnConfirmDefendRule(obj);
			}

			// Token: 0x060098DF RID: 39135 RVA: 0x002BC5EC File Offset: 0x002BA7EC
			public void __clearDele_EventOnConfirmDefendRule(int obj)
			{
				this.m_owner.__clearDele_EventOnConfirmDefendRule(obj);
			}

			// Token: 0x060098E0 RID: 39136 RVA: 0x002BC5FC File Offset: 0x002BA7FC
			public void __callDele_EventOnShowMyActorInfo(BattleHero obj)
			{
				this.m_owner.__callDele_EventOnShowMyActorInfo(obj);
			}

			// Token: 0x060098E1 RID: 39137 RVA: 0x002BC60C File Offset: 0x002BA80C
			public void __clearDele_EventOnShowMyActorInfo(BattleHero obj)
			{
				this.m_owner.__clearDele_EventOnShowMyActorInfo(obj);
			}

			// Token: 0x060098E2 RID: 39138 RVA: 0x002BC61C File Offset: 0x002BA81C
			public void __callDele_EventOnHideActorInfo()
			{
				this.m_owner.__callDele_EventOnHideActorInfo();
			}

			// Token: 0x060098E3 RID: 39139 RVA: 0x002BC62C File Offset: 0x002BA82C
			public void __clearDele_EventOnHideActorInfo()
			{
				this.m_owner.__clearDele_EventOnHideActorInfo();
			}

			// Token: 0x060098E4 RID: 39140 RVA: 0x002BC63C File Offset: 0x002BA83C
			public void __callDele_EventOnStageActorChange()
			{
				this.m_owner.__callDele_EventOnStageActorChange();
			}

			// Token: 0x060098E5 RID: 39141 RVA: 0x002BC64C File Offset: 0x002BA84C
			public void __clearDele_EventOnStageActorChange()
			{
				this.m_owner.__clearDele_EventOnStageActorChange();
			}

			// Token: 0x060098E6 RID: 39142 RVA: 0x002BC65C File Offset: 0x002BA85C
			public void __callDele_EventOnHeroOnStage(BattleHero arg1, GridPosition arg2)
			{
				this.m_owner.__callDele_EventOnHeroOnStage(arg1, arg2);
			}

			// Token: 0x060098E7 RID: 39143 RVA: 0x002BC66C File Offset: 0x002BA86C
			public void __clearDele_EventOnHeroOnStage(BattleHero arg1, GridPosition arg2)
			{
				this.m_owner.__clearDele_EventOnHeroOnStage(arg1, arg2);
			}

			// Token: 0x060098E8 RID: 39144 RVA: 0x002BC67C File Offset: 0x002BA87C
			public void __callDele_EventOnActorOffStage(ArenaDefendActor obj)
			{
				this.m_owner.__callDele_EventOnActorOffStage(obj);
			}

			// Token: 0x060098E9 RID: 39145 RVA: 0x002BC68C File Offset: 0x002BA88C
			public void __clearDele_EventOnActorOffStage(ArenaDefendActor obj)
			{
				this.m_owner.__clearDele_EventOnActorOffStage(obj);
			}

			// Token: 0x060098EA RID: 39146 RVA: 0x002BC69C File Offset: 0x002BA89C
			public void __callDele_EventOnStageActorMove(ArenaDefendActor arg1, GridPosition arg2)
			{
				this.m_owner.__callDele_EventOnStageActorMove(arg1, arg2);
			}

			// Token: 0x060098EB RID: 39147 RVA: 0x002BC6AC File Offset: 0x002BA8AC
			public void __clearDele_EventOnStageActorMove(ArenaDefendActor arg1, GridPosition arg2)
			{
				this.m_owner.__clearDele_EventOnStageActorMove(arg1, arg2);
			}

			// Token: 0x060098EC RID: 39148 RVA: 0x002BC6BC File Offset: 0x002BA8BC
			public void __callDele_EventOnStageActorSwap(ArenaDefendActor arg1, ArenaDefendActor arg2)
			{
				this.m_owner.__callDele_EventOnStageActorSwap(arg1, arg2);
			}

			// Token: 0x060098ED RID: 39149 RVA: 0x002BC6CC File Offset: 0x002BA8CC
			public void __clearDele_EventOnStageActorSwap(ArenaDefendActor arg1, ArenaDefendActor arg2)
			{
				this.m_owner.__clearDele_EventOnStageActorSwap(arg1, arg2);
			}

			// Token: 0x060098EE RID: 39150 RVA: 0x002BC6DC File Offset: 0x002BA8DC
			public void __callDele_EventOnPointerDown(PointerEventData.InputButton arg1, Vector2 arg2)
			{
				this.m_owner.__callDele_EventOnPointerDown(arg1, arg2);
			}

			// Token: 0x060098EF RID: 39151 RVA: 0x002BC6EC File Offset: 0x002BA8EC
			public void __clearDele_EventOnPointerDown(PointerEventData.InputButton arg1, Vector2 arg2)
			{
				this.m_owner.__clearDele_EventOnPointerDown(arg1, arg2);
			}

			// Token: 0x060098F0 RID: 39152 RVA: 0x002BC6FC File Offset: 0x002BA8FC
			public void __callDele_EventOnPointerUp(PointerEventData.InputButton arg1, Vector2 arg2)
			{
				this.m_owner.__callDele_EventOnPointerUp(arg1, arg2);
			}

			// Token: 0x060098F1 RID: 39153 RVA: 0x002BC70C File Offset: 0x002BA90C
			public void __clearDele_EventOnPointerUp(PointerEventData.InputButton arg1, Vector2 arg2)
			{
				this.m_owner.__clearDele_EventOnPointerUp(arg1, arg2);
			}

			// Token: 0x060098F2 RID: 39154 RVA: 0x002BC71C File Offset: 0x002BA91C
			public void __callDele_EventOnPointerClick(PointerEventData.InputButton arg1, Vector2 arg2)
			{
				this.m_owner.__callDele_EventOnPointerClick(arg1, arg2);
			}

			// Token: 0x060098F3 RID: 39155 RVA: 0x002BC72C File Offset: 0x002BA92C
			public void __clearDele_EventOnPointerClick(PointerEventData.InputButton arg1, Vector2 arg2)
			{
				this.m_owner.__clearDele_EventOnPointerClick(arg1, arg2);
			}

			// Token: 0x17001F4E RID: 8014
			// (get) Token: 0x060098F4 RID: 39156 RVA: 0x002BC73C File Offset: 0x002BA93C
			// (set) Token: 0x060098F5 RID: 39157 RVA: 0x002BC74C File Offset: 0x002BA94C
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

			// Token: 0x17001F4F RID: 8015
			// (get) Token: 0x060098F6 RID: 39158 RVA: 0x002BC75C File Offset: 0x002BA95C
			// (set) Token: 0x060098F7 RID: 39159 RVA: 0x002BC76C File Offset: 0x002BA96C
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

			// Token: 0x17001F50 RID: 8016
			// (get) Token: 0x060098F8 RID: 39160 RVA: 0x002BC77C File Offset: 0x002BA97C
			// (set) Token: 0x060098F9 RID: 39161 RVA: 0x002BC78C File Offset: 0x002BA98C
			public Button m_saveTeamButton
			{
				get
				{
					return this.m_owner.m_saveTeamButton;
				}
				set
				{
					this.m_owner.m_saveTeamButton = value;
				}
			}

			// Token: 0x17001F51 RID: 8017
			// (get) Token: 0x060098FA RID: 39162 RVA: 0x002BC79C File Offset: 0x002BA99C
			// (set) Token: 0x060098FB RID: 39163 RVA: 0x002BC7AC File Offset: 0x002BA9AC
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

			// Token: 0x17001F52 RID: 8018
			// (get) Token: 0x060098FC RID: 39164 RVA: 0x002BC7BC File Offset: 0x002BA9BC
			// (set) Token: 0x060098FD RID: 39165 RVA: 0x002BC7CC File Offset: 0x002BA9CC
			public Button m_mapButton
			{
				get
				{
					return this.m_owner.m_mapButton;
				}
				set
				{
					this.m_owner.m_mapButton = value;
				}
			}

			// Token: 0x17001F53 RID: 8019
			// (get) Token: 0x060098FE RID: 39166 RVA: 0x002BC7DC File Offset: 0x002BA9DC
			// (set) Token: 0x060098FF RID: 39167 RVA: 0x002BC7EC File Offset: 0x002BA9EC
			public Button m_defendRuleButton
			{
				get
				{
					return this.m_owner.m_defendRuleButton;
				}
				set
				{
					this.m_owner.m_defendRuleButton = value;
				}
			}

			// Token: 0x17001F54 RID: 8020
			// (get) Token: 0x06009900 RID: 39168 RVA: 0x002BC7FC File Offset: 0x002BA9FC
			// (set) Token: 0x06009901 RID: 39169 RVA: 0x002BC80C File Offset: 0x002BAA0C
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

			// Token: 0x17001F55 RID: 8021
			// (get) Token: 0x06009902 RID: 39170 RVA: 0x002BC81C File Offset: 0x002BAA1C
			// (set) Token: 0x06009903 RID: 39171 RVA: 0x002BC82C File Offset: 0x002BAA2C
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

			// Token: 0x17001F56 RID: 8022
			// (get) Token: 0x06009904 RID: 39172 RVA: 0x002BC83C File Offset: 0x002BAA3C
			// (set) Token: 0x06009905 RID: 39173 RVA: 0x002BC84C File Offset: 0x002BAA4C
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

			// Token: 0x17001F57 RID: 8023
			// (get) Token: 0x06009906 RID: 39174 RVA: 0x002BC85C File Offset: 0x002BAA5C
			// (set) Token: 0x06009907 RID: 39175 RVA: 0x002BC86C File Offset: 0x002BAA6C
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

			// Token: 0x17001F58 RID: 8024
			// (get) Token: 0x06009908 RID: 39176 RVA: 0x002BC87C File Offset: 0x002BAA7C
			// (set) Token: 0x06009909 RID: 39177 RVA: 0x002BC88C File Offset: 0x002BAA8C
			public GameObject m_panelGameObject
			{
				get
				{
					return this.m_owner.m_panelGameObject;
				}
				set
				{
					this.m_owner.m_panelGameObject = value;
				}
			}

			// Token: 0x17001F59 RID: 8025
			// (get) Token: 0x0600990A RID: 39178 RVA: 0x002BC89C File Offset: 0x002BAA9C
			// (set) Token: 0x0600990B RID: 39179 RVA: 0x002BC8AC File Offset: 0x002BAAAC
			public Button m_panelBackgroundButton
			{
				get
				{
					return this.m_owner.m_panelBackgroundButton;
				}
				set
				{
					this.m_owner.m_panelBackgroundButton = value;
				}
			}

			// Token: 0x17001F5A RID: 8026
			// (get) Token: 0x0600990C RID: 39180 RVA: 0x002BC8BC File Offset: 0x002BAABC
			// (set) Token: 0x0600990D RID: 39181 RVA: 0x002BC8CC File Offset: 0x002BAACC
			public CommonUIStateController m_actionOrderPanelUIStateController
			{
				get
				{
					return this.m_owner.m_actionOrderPanelUIStateController;
				}
				set
				{
					this.m_owner.m_actionOrderPanelUIStateController = value;
				}
			}

			// Token: 0x17001F5B RID: 8027
			// (get) Token: 0x0600990E RID: 39182 RVA: 0x002BC8DC File Offset: 0x002BAADC
			// (set) Token: 0x0600990F RID: 39183 RVA: 0x002BC8EC File Offset: 0x002BAAEC
			public GameObject m_actionOrderPanelGameObject
			{
				get
				{
					return this.m_owner.m_actionOrderPanelGameObject;
				}
				set
				{
					this.m_owner.m_actionOrderPanelGameObject = value;
				}
			}

			// Token: 0x17001F5C RID: 8028
			// (get) Token: 0x06009910 RID: 39184 RVA: 0x002BC8FC File Offset: 0x002BAAFC
			// (set) Token: 0x06009911 RID: 39185 RVA: 0x002BC90C File Offset: 0x002BAB0C
			public GameObject m_actionOrdersGameObject
			{
				get
				{
					return this.m_owner.m_actionOrdersGameObject;
				}
				set
				{
					this.m_owner.m_actionOrdersGameObject = value;
				}
			}

			// Token: 0x17001F5D RID: 8029
			// (get) Token: 0x06009912 RID: 39186 RVA: 0x002BC91C File Offset: 0x002BAB1C
			// (set) Token: 0x06009913 RID: 39187 RVA: 0x002BC92C File Offset: 0x002BAB2C
			public Button m_actionOrderOkButton
			{
				get
				{
					return this.m_owner.m_actionOrderOkButton;
				}
				set
				{
					this.m_owner.m_actionOrderOkButton = value;
				}
			}

			// Token: 0x17001F5E RID: 8030
			// (get) Token: 0x06009914 RID: 39188 RVA: 0x002BC93C File Offset: 0x002BAB3C
			// (set) Token: 0x06009915 RID: 39189 RVA: 0x002BC94C File Offset: 0x002BAB4C
			public CommonUIStateController m_mapPanelUIStateController
			{
				get
				{
					return this.m_owner.m_mapPanelUIStateController;
				}
				set
				{
					this.m_owner.m_mapPanelUIStateController = value;
				}
			}

			// Token: 0x17001F5F RID: 8031
			// (get) Token: 0x06009916 RID: 39190 RVA: 0x002BC95C File Offset: 0x002BAB5C
			// (set) Token: 0x06009917 RID: 39191 RVA: 0x002BC96C File Offset: 0x002BAB6C
			public GameObject m_mapPanelGameObject
			{
				get
				{
					return this.m_owner.m_mapPanelGameObject;
				}
				set
				{
					this.m_owner.m_mapPanelGameObject = value;
				}
			}

			// Token: 0x17001F60 RID: 8032
			// (get) Token: 0x06009918 RID: 39192 RVA: 0x002BC97C File Offset: 0x002BAB7C
			// (set) Token: 0x06009919 RID: 39193 RVA: 0x002BC98C File Offset: 0x002BAB8C
			public GameObject m_mapsGameObject
			{
				get
				{
					return this.m_owner.m_mapsGameObject;
				}
				set
				{
					this.m_owner.m_mapsGameObject = value;
				}
			}

			// Token: 0x17001F61 RID: 8033
			// (get) Token: 0x0600991A RID: 39194 RVA: 0x002BC99C File Offset: 0x002BAB9C
			// (set) Token: 0x0600991B RID: 39195 RVA: 0x002BC9AC File Offset: 0x002BABAC
			public Button m_mapOkButton
			{
				get
				{
					return this.m_owner.m_mapOkButton;
				}
				set
				{
					this.m_owner.m_mapOkButton = value;
				}
			}

			// Token: 0x17001F62 RID: 8034
			// (get) Token: 0x0600991C RID: 39196 RVA: 0x002BC9BC File Offset: 0x002BABBC
			// (set) Token: 0x0600991D RID: 39197 RVA: 0x002BC9CC File Offset: 0x002BABCC
			public CommonUIStateController m_defendRulePanelUIStateController
			{
				get
				{
					return this.m_owner.m_defendRulePanelUIStateController;
				}
				set
				{
					this.m_owner.m_defendRulePanelUIStateController = value;
				}
			}

			// Token: 0x17001F63 RID: 8035
			// (get) Token: 0x0600991E RID: 39198 RVA: 0x002BC9DC File Offset: 0x002BABDC
			// (set) Token: 0x0600991F RID: 39199 RVA: 0x002BC9EC File Offset: 0x002BABEC
			public GameObject m_defendRulePanelGameObject
			{
				get
				{
					return this.m_owner.m_defendRulePanelGameObject;
				}
				set
				{
					this.m_owner.m_defendRulePanelGameObject = value;
				}
			}

			// Token: 0x17001F64 RID: 8036
			// (get) Token: 0x06009920 RID: 39200 RVA: 0x002BC9FC File Offset: 0x002BABFC
			// (set) Token: 0x06009921 RID: 39201 RVA: 0x002BCA0C File Offset: 0x002BAC0C
			public GameObject m_defendRulesGameObject
			{
				get
				{
					return this.m_owner.m_defendRulesGameObject;
				}
				set
				{
					this.m_owner.m_defendRulesGameObject = value;
				}
			}

			// Token: 0x17001F65 RID: 8037
			// (get) Token: 0x06009922 RID: 39202 RVA: 0x002BCA1C File Offset: 0x002BAC1C
			// (set) Token: 0x06009923 RID: 39203 RVA: 0x002BCA2C File Offset: 0x002BAC2C
			public Button m_defendRuleOkButton
			{
				get
				{
					return this.m_owner.m_defendRuleOkButton;
				}
				set
				{
					this.m_owner.m_defendRuleOkButton = value;
				}
			}

			// Token: 0x17001F66 RID: 8038
			// (get) Token: 0x06009924 RID: 39204 RVA: 0x002BCA3C File Offset: 0x002BAC3C
			// (set) Token: 0x06009925 RID: 39205 RVA: 0x002BCA4C File Offset: 0x002BAC4C
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

			// Token: 0x17001F67 RID: 8039
			// (get) Token: 0x06009926 RID: 39206 RVA: 0x002BCA5C File Offset: 0x002BAC5C
			// (set) Token: 0x06009927 RID: 39207 RVA: 0x002BCA6C File Offset: 0x002BAC6C
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

			// Token: 0x17001F68 RID: 8040
			// (get) Token: 0x06009928 RID: 39208 RVA: 0x002BCA7C File Offset: 0x002BAC7C
			// (set) Token: 0x06009929 RID: 39209 RVA: 0x002BCA8C File Offset: 0x002BAC8C
			public GameObject m_actionOrderButtonPrefab
			{
				get
				{
					return this.m_owner.m_actionOrderButtonPrefab;
				}
				set
				{
					this.m_owner.m_actionOrderButtonPrefab = value;
				}
			}

			// Token: 0x17001F69 RID: 8041
			// (get) Token: 0x0600992A RID: 39210 RVA: 0x002BCA9C File Offset: 0x002BAC9C
			// (set) Token: 0x0600992B RID: 39211 RVA: 0x002BCAAC File Offset: 0x002BACAC
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

			// Token: 0x17001F6A RID: 8042
			// (get) Token: 0x0600992C RID: 39212 RVA: 0x002BCABC File Offset: 0x002BACBC
			// (set) Token: 0x0600992D RID: 39213 RVA: 0x002BCACC File Offset: 0x002BACCC
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

			// Token: 0x17001F6B RID: 8043
			// (get) Token: 0x0600992E RID: 39214 RVA: 0x002BCADC File Offset: 0x002BACDC
			// (set) Token: 0x0600992F RID: 39215 RVA: 0x002BCAEC File Offset: 0x002BACEC
			public ArenaDefendActor m_pointerDownStageActor
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

			// Token: 0x17001F6C RID: 8044
			// (get) Token: 0x06009930 RID: 39216 RVA: 0x002BCAFC File Offset: 0x002BACFC
			// (set) Token: 0x06009931 RID: 39217 RVA: 0x002BCB0C File Offset: 0x002BAD0C
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

			// Token: 0x17001F6D RID: 8045
			// (get) Token: 0x06009932 RID: 39218 RVA: 0x002BCB1C File Offset: 0x002BAD1C
			// (set) Token: 0x06009933 RID: 39219 RVA: 0x002BCB2C File Offset: 0x002BAD2C
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

			// Token: 0x17001F6E RID: 8046
			// (get) Token: 0x06009934 RID: 39220 RVA: 0x002BCB3C File Offset: 0x002BAD3C
			// (set) Token: 0x06009935 RID: 39221 RVA: 0x002BCB4C File Offset: 0x002BAD4C
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

			// Token: 0x17001F6F RID: 8047
			// (get) Token: 0x06009936 RID: 39222 RVA: 0x002BCB5C File Offset: 0x002BAD5C
			// (set) Token: 0x06009937 RID: 39223 RVA: 0x002BCB6C File Offset: 0x002BAD6C
			public List<ArenaDefendActor> m_stageActors
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

			// Token: 0x17001F70 RID: 8048
			// (get) Token: 0x06009938 RID: 39224 RVA: 0x002BCB7C File Offset: 0x002BAD7C
			// (set) Token: 0x06009939 RID: 39225 RVA: 0x002BCB8C File Offset: 0x002BAD8C
			public List<GridPosition> m_stagePositions
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

			// Token: 0x17001F71 RID: 8049
			// (get) Token: 0x0600993A RID: 39226 RVA: 0x002BCB9C File Offset: 0x002BAD9C
			// (set) Token: 0x0600993B RID: 39227 RVA: 0x002BCBAC File Offset: 0x002BADAC
			public List<int> m_stageDirs
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

			// Token: 0x17001F72 RID: 8050
			// (get) Token: 0x0600993C RID: 39228 RVA: 0x002BCBBC File Offset: 0x002BADBC
			// (set) Token: 0x0600993D RID: 39229 RVA: 0x002BCBCC File Offset: 0x002BADCC
			public ArenaActionOrderButton[] m_actionOrderButtons
			{
				get
				{
					return this.m_owner.m_actionOrderButtons;
				}
				set
				{
					this.m_owner.m_actionOrderButtons = value;
				}
			}

			// Token: 0x17001F73 RID: 8051
			// (get) Token: 0x0600993E RID: 39230 RVA: 0x002BCBDC File Offset: 0x002BADDC
			// (set) Token: 0x0600993F RID: 39231 RVA: 0x002BCBEC File Offset: 0x002BADEC
			public ArenaDefendMapToggle[] m_defendMapToggles
			{
				get
				{
					return this.m_owner.m_defendMapToggles;
				}
				set
				{
					this.m_owner.m_defendMapToggles = value;
				}
			}

			// Token: 0x17001F74 RID: 8052
			// (get) Token: 0x06009940 RID: 39232 RVA: 0x002BCBFC File Offset: 0x002BADFC
			// (set) Token: 0x06009941 RID: 39233 RVA: 0x002BCC0C File Offset: 0x002BAE0C
			public ArenaDefendRuleToggle[] m_defendRuleToggles
			{
				get
				{
					return this.m_owner.m_defendRuleToggles;
				}
				set
				{
					this.m_owner.m_defendRuleToggles = value;
				}
			}

			// Token: 0x17001F75 RID: 8053
			// (get) Token: 0x06009942 RID: 39234 RVA: 0x002BCC1C File Offset: 0x002BAE1C
			// (set) Token: 0x06009943 RID: 39235 RVA: 0x002BCC2C File Offset: 0x002BAE2C
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

			// Token: 0x17001F76 RID: 8054
			// (get) Token: 0x06009944 RID: 39236 RVA: 0x002BCC3C File Offset: 0x002BAE3C
			// (set) Token: 0x06009945 RID: 39237 RVA: 0x002BCC4C File Offset: 0x002BAE4C
			public ArenaActionOrderButton m_draggingActionOrderButton
			{
				get
				{
					return this.m_owner.m_draggingActionOrderButton;
				}
				set
				{
					this.m_owner.m_draggingActionOrderButton = value;
				}
			}

			// Token: 0x17001F77 RID: 8055
			// (get) Token: 0x06009946 RID: 39238 RVA: 0x002BCC5C File Offset: 0x002BAE5C
			// (set) Token: 0x06009947 RID: 39239 RVA: 0x002BCC6C File Offset: 0x002BAE6C
			public int m_draggingActionOrderButtonIndex
			{
				get
				{
					return this.m_owner.m_draggingActionOrderButtonIndex;
				}
				set
				{
					this.m_owner.m_draggingActionOrderButtonIndex = value;
				}
			}

			// Token: 0x17001F78 RID: 8056
			// (get) Token: 0x06009948 RID: 39240 RVA: 0x002BCC7C File Offset: 0x002BAE7C
			// (set) Token: 0x06009949 RID: 39241 RVA: 0x002BCC8C File Offset: 0x002BAE8C
			public ArenaDefendBattle m_arenaDefendBattle
			{
				get
				{
					return this.m_owner.m_arenaDefendBattle;
				}
				set
				{
					this.m_owner.m_arenaDefendBattle = value;
				}
			}

			// Token: 0x17001F79 RID: 8057
			// (get) Token: 0x0600994A RID: 39242 RVA: 0x002BCC9C File Offset: 0x002BAE9C
			// (set) Token: 0x0600994B RID: 39243 RVA: 0x002BCCAC File Offset: 0x002BAEAC
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

			// Token: 0x17001F7A RID: 8058
			// (get) Token: 0x0600994C RID: 39244 RVA: 0x002BCCBC File Offset: 0x002BAEBC
			// (set) Token: 0x0600994D RID: 39245 RVA: 0x002BCCCC File Offset: 0x002BAECC
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

			// Token: 0x0600994E RID: 39246 RVA: 0x002BCCDC File Offset: 0x002BAEDC
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600994F RID: 39247 RVA: 0x002BCCEC File Offset: 0x002BAEEC
			public void OnDisable()
			{
				this.m_owner.OnDisable();
			}

			// Token: 0x06009950 RID: 39248 RVA: 0x002BCCFC File Offset: 0x002BAEFC
			public void OnApplicationPause(bool isPause)
			{
				this.m_owner.OnApplicationPause(isPause);
			}

			// Token: 0x06009951 RID: 39249 RVA: 0x002BCD0C File Offset: 0x002BAF0C
			public void OnApplicationFocus(bool focus)
			{
				this.m_owner.OnApplicationFocus(focus);
			}

			// Token: 0x06009952 RID: 39250 RVA: 0x002BCD1C File Offset: 0x002BAF1C
			public void CancelDragging()
			{
				this.m_owner.CancelDragging();
			}

			// Token: 0x06009953 RID: 39251 RVA: 0x002BCD2C File Offset: 0x002BAF2C
			public IEnumerator Co_SetBattlePowerValue(int newValue, int oldValue)
			{
				return this.m_owner.Co_SetBattlePowerValue(newValue, oldValue);
			}

			// Token: 0x06009954 RID: 39252 RVA: 0x002BCD3C File Offset: 0x002BAF3C
			public void ClearBattlePowerValue()
			{
				this.m_owner.ClearBattlePowerValue();
			}

			// Token: 0x06009955 RID: 39253 RVA: 0x002BCD4C File Offset: 0x002BAF4C
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x06009956 RID: 39254 RVA: 0x002BCD5C File Offset: 0x002BAF5C
			public void UpdateStageActorCount()
			{
				this.m_owner.UpdateStageActorCount();
			}

			// Token: 0x06009957 RID: 39255 RVA: 0x002BCD6C File Offset: 0x002BAF6C
			public int GetStageDirection(GridPosition p)
			{
				return this.m_owner.GetStageDirection(p);
			}

			// Token: 0x06009958 RID: 39256 RVA: 0x002BCD7C File Offset: 0x002BAF7C
			public HeroDragButton CreateHeroButton(BattleHero hero, Transform parent)
			{
				return this.m_owner.CreateHeroButton(hero, parent);
			}

			// Token: 0x06009959 RID: 39257 RVA: 0x002BCD8C File Offset: 0x002BAF8C
			public void HideActorInfo()
			{
				this.m_owner.HideActorInfo();
			}

			// Token: 0x0600995A RID: 39258 RVA: 0x002BCD9C File Offset: 0x002BAF9C
			public void ClearPointerDownStageActor()
			{
				this.m_owner.ClearPointerDownStageActor();
			}

			// Token: 0x0600995B RID: 39259 RVA: 0x002BCDAC File Offset: 0x002BAFAC
			public void CreateDraggingHeroButton(BattleHero hero)
			{
				this.m_owner.CreateDraggingHeroButton(hero);
			}

			// Token: 0x0600995C RID: 39260 RVA: 0x002BCDBC File Offset: 0x002BAFBC
			public void DestroyDragginHeroButton()
			{
				this.m_owner.DestroyDragginHeroButton();
			}

			// Token: 0x0600995D RID: 39261 RVA: 0x002BCDCC File Offset: 0x002BAFCC
			public void MoveDraggingHeroButton(Vector2 pos)
			{
				this.m_owner.MoveDraggingHeroButton(pos);
			}

			// Token: 0x0600995E RID: 39262 RVA: 0x002BCDDC File Offset: 0x002BAFDC
			public ArenaActionOrderButton CreateActionOrderButton(BattleHero hero, Transform parent)
			{
				return this.m_owner.CreateActionOrderButton(hero, parent);
			}

			// Token: 0x0600995F RID: 39263 RVA: 0x002BCDEC File Offset: 0x002BAFEC
			public void CreateDraggingActionOrderButton(BattleHero hero)
			{
				this.m_owner.CreateDraggingActionOrderButton(hero);
			}

			// Token: 0x06009960 RID: 39264 RVA: 0x002BCDFC File Offset: 0x002BAFFC
			public void DestroyDragginActionOrderButton()
			{
				this.m_owner.DestroyDragginActionOrderButton();
			}

			// Token: 0x06009961 RID: 39265 RVA: 0x002BCE0C File Offset: 0x002BB00C
			public void MoveDraggingActionOrderButton(Vector2 pos)
			{
				this.m_owner.MoveDraggingActionOrderButton(pos);
			}

			// Token: 0x06009962 RID: 39266 RVA: 0x002BCE1C File Offset: 0x002BB01C
			public void DropDraggingActionOrderButton(Vector2 pos)
			{
				this.m_owner.DropDraggingActionOrderButton(pos);
			}

			// Token: 0x06009963 RID: 39267 RVA: 0x002BCE2C File Offset: 0x002BB02C
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x06009964 RID: 39268 RVA: 0x002BCE3C File Offset: 0x002BB03C
			public void OnSaveTeamButtonClick()
			{
				this.m_owner.OnSaveTeamButtonClick();
			}

			// Token: 0x06009965 RID: 39269 RVA: 0x002BCE4C File Offset: 0x002BB04C
			public void OnShowActionOrderButtonClick()
			{
				this.m_owner.OnShowActionOrderButtonClick();
			}

			// Token: 0x06009966 RID: 39270 RVA: 0x002BCE5C File Offset: 0x002BB05C
			public void OnShowMapButtonClick()
			{
				this.m_owner.OnShowMapButtonClick();
			}

			// Token: 0x06009967 RID: 39271 RVA: 0x002BCE6C File Offset: 0x002BB06C
			public void OnShowDefendRuleButtonClick()
			{
				this.m_owner.OnShowDefendRuleButtonClick();
			}

			// Token: 0x06009968 RID: 39272 RVA: 0x002BCE7C File Offset: 0x002BB07C
			public void OnPanelBackgroundButtonClick()
			{
				this.m_owner.OnPanelBackgroundButtonClick();
			}

			// Token: 0x06009969 RID: 39273 RVA: 0x002BCE8C File Offset: 0x002BB08C
			public void OnActionOrderOkButtonClick()
			{
				this.m_owner.OnActionOrderOkButtonClick();
			}

			// Token: 0x0600996A RID: 39274 RVA: 0x002BCE9C File Offset: 0x002BB09C
			public void ActionOrderButton_OnClick(ArenaActionOrderButton b)
			{
				this.m_owner.ActionOrderButton_OnClick(b);
			}

			// Token: 0x0600996B RID: 39275 RVA: 0x002BCEAC File Offset: 0x002BB0AC
			public void ActionOrderButton_OnBeginDrag(ArenaActionOrderButton b, PointerEventData eventData)
			{
				this.m_owner.ActionOrderButton_OnBeginDrag(b, eventData);
			}

			// Token: 0x0600996C RID: 39276 RVA: 0x002BCEBC File Offset: 0x002BB0BC
			public void ActionOrderButton_OnEndDrag(ArenaActionOrderButton b, PointerEventData eventData)
			{
				this.m_owner.ActionOrderButton_OnEndDrag(b, eventData);
			}

			// Token: 0x0600996D RID: 39277 RVA: 0x002BCECC File Offset: 0x002BB0CC
			public void ActionOrderButton_OnDrag(PointerEventData eventData)
			{
				this.m_owner.ActionOrderButton_OnDrag(eventData);
			}

			// Token: 0x0600996E RID: 39278 RVA: 0x002BCEDC File Offset: 0x002BB0DC
			public void ActionOrderButton_OnDrop(PointerEventData eventData)
			{
				this.m_owner.ActionOrderButton_OnDrop(eventData);
			}

			// Token: 0x0600996F RID: 39279 RVA: 0x002BCEEC File Offset: 0x002BB0EC
			public void OnMapOkButtonClick()
			{
				this.m_owner.OnMapOkButtonClick();
			}

			// Token: 0x06009970 RID: 39280 RVA: 0x002BCEFC File Offset: 0x002BB0FC
			public void OnDefendRuleOkButtonClick()
			{
				this.m_owner.OnDefendRuleOkButtonClick();
			}

			// Token: 0x0400691D RID: 26909
			private ArenaDefendUIController m_owner;
		}
	}
}
