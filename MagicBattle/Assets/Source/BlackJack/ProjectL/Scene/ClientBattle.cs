using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Art;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectLBasic;
using FixMath.NET;
using PD.SDK;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x0200091D RID: 2333
	[HotFix]
	public class ClientBattle : IBattleListener, IFxEventListener, IGenericGraphicContainer
	{
		// Token: 0x060086C4 RID: 34500 RVA: 0x0026B3B8 File Offset: 0x002695B8
		public ClientBattle()
		{
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			this.m_randomNumber = new RandomNumber();
			this.m_battle = new BattleBase(this.m_configDataLoader, this);
			this.m_battleCamera = new BattleCamera();
			this.m_combatCamera = new CombatCamera();
			this.m_cutsceneCamera = new CutsceneCamera();
			this.m_actors = new List<ClientBattleActor>();
			this.m_actorActs = new List<ClientActorAct>();
			this.m_treasures = new List<ClientBattleTreasure>();
			this.m_graphicPool = new GraphicPool(false);
			this.m_fxPool = new GraphicPool(true);
			this.m_battleFxPlayer = new FxPlayer(this.m_fxPool);
			this.m_combatFxPlayer = new FxPlayer(this.m_fxPool);
			this.m_cutscenePlayer = new FxPlayer(this.m_fxPool);
			this.m_mapTerrainFxs = new Dictionary<GridPosition, GameObject>();
			this.m_state = ClientBattleState.None;
			this.m_frameCount = 0;
			this.m_timeScale = (this.m_globalTimeScale = 1f);
			this.SetTimeScale(1f);
			GlobalFxEventListener.Instance = this;
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

		// Token: 0x060086C5 RID: 34501 RVA: 0x0026B530 File Offset: 0x00269730
		public void Dispose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Dispose_hotfix != null)
			{
				this.m_Dispose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.Clear();
			this.ClearMapBackground();
			this.ClearMapTerrainFx();
			if (this.m_battleFxPlayer != null)
			{
				this.m_battleFxPlayer.Clear();
				this.m_battleFxPlayer = null;
			}
			if (this.m_combatFxPlayer != null)
			{
				this.m_combatFxPlayer.Clear();
				this.m_combatFxPlayer = null;
			}
			if (this.m_cutscenePlayer != null)
			{
				this.m_cutscenePlayer.Clear();
				this.m_cutscenePlayer = null;
			}
			if (this.m_graphicPool != null)
			{
				this.m_graphicPool.Clear();
				this.m_graphicPool = null;
			}
			if (this.m_fxPool != null)
			{
				this.m_fxPool.Clear();
				this.m_fxPool = null;
			}
			if (this.m_battle != null)
			{
				this.m_battle.Dispose();
				this.m_battle = null;
			}
			this.m_randomNumber = null;
			this.m_battleCamera = null;
			this.m_combatCamera = null;
			this.m_cutsceneCamera = null;
			this.m_actors = null;
			this.m_actorActs = null;
			this.m_treasures = null;
			this.m_mapTerrainFxs = null;
			GlobalFxEventListener.Instance = null;
		}

		// Token: 0x060086C6 RID: 34502 RVA: 0x0026B690 File Offset: 0x00269890
		public void Initialize(IClientBattleListener clientBattleListener, GameObject root)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitializeIClientBattleListenerGameObject_hotfix != null)
			{
				this.m_InitializeIClientBattleListenerGameObject_hotfix.call(new object[]
				{
					this,
					clientBattleListener,
					root
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_clientBattleListener = clientBattleListener;
			this.m_battleRoot = Utility.FindChildGameObject(root, "Battle", true);
			this.m_combatRoot = Utility.FindChildGameObject(root, "Combat", true);
			this.m_cutsceneRoot = Utility.FindChildGameObject(root, "Cutscene", true);
			this.m_battleGraphicRoot = Utility.FindChildGameObject(this.m_battleRoot, "Graphics", true);
			this.m_combatGraphicRoot = Utility.FindChildGameObject(this.m_combatRoot, "Graphics", true);
			this.m_cutsceneGraphicRoot = Utility.FindChildGameObject(this.m_cutsceneRoot, "Graphics", true);
			this.m_mapRoot = Utility.FindChildGameObject(root, "Map", true);
			this.m_mapRoot.SetActive(false);
			this.m_mapTerrainFxRoot = Utility.FindChildGameObject(this.m_mapRoot, "TerrainFx", true);
			this.m_mapTreasureRoot = Utility.FindChildGameObject(this.m_mapRoot, "Treasure", true);
			this.m_battleUIRoot = Utility.FindChildGameObject(this.m_battleRoot, "Canvas", true);
			this.m_battleActorUIRoot = Utility.FindChildGameObject(this.m_battleUIRoot, "Actors", true);
			GameObject gameObject = Utility.FindChildGameObject(this.m_battleUIRoot, "Prefabs", true);
			gameObject.SetActive(false);
			this.m_battleActorUIPrefab = Utility.FindChildGameObject(gameObject, "Actor", true);
			this.m_battleCamera.Initialize(Utility.FindChildGameObject(root, "Camera", true));
			this.m_combatCamera.Initialize(Utility.FindChildGameObject(this.m_combatRoot, "Camera", true));
			this.m_cutsceneCamera.Initialize(Utility.FindChildGameObject(this.m_cutsceneRoot, "Camera", true));
			GameObject gameObject2 = Utility.FindChildGameObject(root, "GraphicPool", true);
			gameObject2.SetActive(false);
			this.m_graphicPool.SetDefaultParent(gameObject2);
			GameObject gameObject3 = Utility.FindChildGameObject(root, "FxPool", true);
			gameObject3.SetActive(false);
			this.m_fxPool.SetDefaultParent(gameObject3);
			this.m_battleFxPlayer.SetDefaultParent(this.m_battleGraphicRoot);
			this.m_combatFxPlayer.SetDefaultParent(this.m_combatGraphicRoot);
			this.m_cutscenePlayer.SetDefaultParent(this.m_cutsceneGraphicRoot);
			this.m_state = ClientBattleState.Initialized;
		}

		// Token: 0x060086C7 RID: 34503 RVA: 0x0026B900 File Offset: 0x00269B00
		public void Tick(float dt)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickSingle_hotfix != null)
			{
				this.m_TickSingle_hotfix.call(new object[]
				{
					this,
					dt
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_state == ClientBattleState.None)
			{
				return;
			}
			float num = this.m_globalTimeScale * ((!this.m_isFastBattle) ? 1f : 1.3f);
			this.TickSlowMotion(Time.unscaledDeltaTime * num);
			if (dt > 0f)
			{
				this.m_battleCamera.Update(dt);
				this.m_cutsceneCamera.Update(dt);
				if (this.m_state == ClientBattleState.Combat)
				{
					if (this.IsSkippingCombat(true))
					{
						while (this.IsSkippingCombat(true))
						{
							this.TickCombat();
						}
					}
					else
					{
						this.m_combatCamera.Update(dt);
						float num2 = 0.0333333351f;
						this.m_combatTickTime += dt;
						while (this.m_combatTickTime >= num2 && this.m_state == ClientBattleState.Combat)
						{
							this.TickCombat();
							this.m_combatTickTime -= num2;
						}
					}
				}
				else
				{
					float num3 = 0.0333333351f;
					this.m_battleTickTime += dt;
					while (this.m_battleTickTime >= num3 && this.m_state != ClientBattleState.Combat)
					{
						this.TickClientBattle();
						this.m_battleTickTime -= num3;
					}
				}
				this.TickGraphic(dt);
				this.m_battleFxPlayer.Tick(dt);
				this.m_combatFxPlayer.Tick(dt);
				this.m_cutscenePlayer.Tick(dt);
			}
			this.Draw();
			this.m_tickSoundName = string.Empty;
		}

		// Token: 0x060086C8 RID: 34504 RVA: 0x0026BADC File Offset: 0x00269CDC
		private void TickSlowMotion(float dt)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickSlowMotionSingle_hotfix != null)
			{
				this.m_TickSlowMotionSingle_hotfix.call(new object[]
				{
					this,
					dt
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_slowMotionState == SlowMotionState.ToPause)
			{
				this.m_slowMotionCountdown -= dt;
				if (this.m_slowMotionCountdown <= 0f)
				{
					this.SetTimeScale(0f);
					this.m_slowMotionState = SlowMotionState.Pause;
					this.m_slowMotionCountdown = (float)this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_Combat_HeroDiePauseTime) * 0.001f;
				}
			}
			else if (this.m_slowMotionState == SlowMotionState.Pause)
			{
				this.m_slowMotionCountdown -= dt;
				if (this.m_slowMotionCountdown <= 0f)
				{
					this.SetTimeScale((float)this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_Combat_HeroDieSlowMotionSpeed) * 0.01f);
					this.m_slowMotionState = SlowMotionState.SlowMotion;
					this.m_slowMotionCountdown = (float)this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_Combat_HeroDieSlowMotionTime) * 0.001f;
				}
			}
			else if (this.m_slowMotionState == SlowMotionState.SlowMotion)
			{
				this.m_slowMotionCountdown -= dt;
				if (this.m_slowMotionCountdown <= 0f)
				{
					this.m_slowMotionState = SlowMotionState.NormalMotion;
					this.m_slowMotionCountdown = (float)this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_Combat_HeroDieNormalMotionTime) * 0.001f;
				}
			}
			else if (this.m_slowMotionState == SlowMotionState.NormalMotion)
			{
				this.m_slowMotionCountdown -= dt;
				if (this.m_slowMotionCountdown <= 0f)
				{
					this.m_slowMotionCountdown = 0f;
					this.m_slowMotionState = SlowMotionState.None;
				}
				float num = (float)this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_Combat_HeroDieNormalMotionTime) * 0.001f;
				float num2 = (float)this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_Combat_TimeScale) * 0.01f;
				if (num > 0f && this.m_slowMotionCountdown > 0f)
				{
					float b = (float)this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_Combat_HeroDieSlowMotionSpeed) * 0.01f;
					num2 = Mathf.Lerp(num2, b, this.m_slowMotionCountdown / num);
				}
				this.SetTimeScale(num2);
			}
		}

		// Token: 0x060086C9 RID: 34505 RVA: 0x0026BD10 File Offset: 0x00269F10
		private void TickCombat()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickCombat_hotfix != null)
			{
				this.m_TickCombat_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battle.Tick();
		}

		// Token: 0x060086CA RID: 34506 RVA: 0x0026BD7C File Offset: 0x00269F7C
		private void TickClientBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickClientBattle_hotfix != null)
			{
				this.m_TickClientBattle_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_cutscenePauseCountdown > 0)
			{
				this.m_cutscenePauseCountdown--;
				if (this.m_cutscenePauseCountdown == 0)
				{
					this.Pause(false);
					this.OnStopSkillCutscene();
				}
			}
			if (this.m_isPaused)
			{
				return;
			}
			if (this.m_restoreNonSkillTargetsCountdown > 0)
			{
				this.m_restoreNonSkillTargetsCountdown--;
				if (this.m_restoreNonSkillTargetsCountdown == 0)
				{
					this.RestoreNonSkillTargets();
				}
			}
			if (this.m_state != ClientBattleState.None)
			{
				if (this.m_state != ClientBattleState.Prepare)
				{
					if (this.m_state == ClientBattleState.Play)
					{
						if (!this.IsAnyActorHasAct())
						{
							if (this.m_actorActs.Count <= 0 && this.m_battle.HasCurrentStepBattleCommand() && this.m_battle.IsPlay())
							{
								BattleActor actionActor = this.m_battle.GetActionActor();
								int step = this.m_battle.Step;
								if (!this.m_battle.ExecuteBattleCommand())
								{
									if (this.IsRebuildingBattle())
									{
										this.StopRebuildingBattle();
										this.m_battle.ClearBattleCommandsAndNextStep();
										global::Debug.LogError("ClientBattle.TickClientBattle error, IsRebuildingBattle ExecuteBattleCommand error");
									}
									else if (actionActor != null && actionActor.IsPlayerActor())
									{
										this.m_battle.FixExecutedCommands(actionActor, step);
									}
								}
							}
							if (this.m_actorActs.Count > 0)
							{
								this.AppendActToActor();
							}
						}
						if (this.m_actorActs.Count <= 0 && !this.IsAnyActorHasAct() && this.m_battle.State == BattleState.Stop)
						{
							bool flag = this.m_battle.IsWin();
							if ((this.m_pvpBattleInfo != null || this.m_realtimePvpBattleInfo != null) && this.m_myPlayerIndex != 0)
							{
								flag = !flag;
							}
							this.Stop(flag, false);
						}
					}
					else if (this.m_state == ClientBattleState.PreStartCombat)
					{
						if (!this.IsAnyActorHasAct())
						{
							this.m_state = ClientBattleState.Combat;
							this.StartCombat();
						}
					}
					else if (this.m_state != ClientBattleState.Combat)
					{
						if (this.m_state == ClientBattleState.Stop && this.m_endCountdown > 0)
						{
							this.m_endCountdown--;
							if (this.m_endCountdown == 0)
							{
								this.m_clientBattleListener.OnStopBattle(this.m_isStopBattleWin, false);
							}
						}
					}
				}
			}
			if (this.m_nullActor != null)
			{
				this.m_nullActor.Tick();
			}
			EntityList.Tick<ClientBattleActor>(this.m_actors);
			EntityList.RemoveDeleted<ClientBattleActor>(this.m_actors);
			EntityList.Tick<ClientBattleTreasure>(this.m_treasures);
			EntityList.RemoveDeleted<ClientBattleTreasure>(this.m_treasures);
			if (this.m_activeActor != null && this.m_activeActor.IsDeleteMe)
			{
				this.m_activeActor = null;
			}
			if (this.m_cameraFollowActor != null && this.m_cameraFollowActor.IsDeleteMe)
			{
				this.m_cameraFollowActor = null;
			}
			this.m_frameCount++;
		}

		// Token: 0x060086CB RID: 34507 RVA: 0x0026C0B4 File Offset: 0x0026A2B4
		private void StartCombat()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartCombat_hotfix != null)
			{
				this.m_StartCombat_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (ClientBattleActor clientBattleActor in this.m_actors)
			{
				clientBattleActor.ClearAttachFx();
			}
			this.m_battleFxPlayer.DeleteAutoDeleteFxs();
			this.m_battleRoot.SetActive(false);
			this.m_combatRoot.SetActive(true);
			bool splitScreen = this.m_battle.Combat.GetCombatGridDistance() > 1;
			this.m_combatCamera.StartCombat(splitScreen);
			this.SetTimeScale((float)this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_Combat_TimeScale) * 0.01f);
			this.m_clientBattleListener.OnStartCombat(this.GetActor(this.m_combatingBattleActorA), this.GetActor(this.m_combatingBattleActorB), splitScreen);
			if (this.m_combatingBattleActorA.SoldierInfo != null && this.m_combatingBattleActorA.GetSoldierCount() > 0)
			{
				this.PlaySound(this.m_combatingBattleActorA.SoldierInfo.Sound_Enter);
			}
			if (this.m_combatingBattleActorB.SoldierInfo != null && this.m_combatingBattleActorB.GetSoldierCount() > 0)
			{
				this.PlaySound(this.m_combatingBattleActorB.SoldierInfo.Sound_Enter);
			}
		}

		// Token: 0x060086CC RID: 34508 RVA: 0x0026C254 File Offset: 0x0026A454
		private void StopCombat()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StopCombat_hotfix != null)
			{
				this.m_StopCombat_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleRoot.SetActive(true);
			this.m_combatRoot.SetActive(false);
			this.m_combatFxPlayer.Clear();
			this.SetTimeScale(1f);
			this.m_clientBattleListener.OnStopCombat();
		}

		// Token: 0x060086CD RID: 34509 RVA: 0x0026C2F0 File Offset: 0x0026A4F0
		private void SetTimeScale(float scale)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTimeScaleSingle_hotfix != null)
			{
				this.m_SetTimeScaleSingle_hotfix.call(new object[]
				{
					this,
					scale
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_timeScale = scale;
			this.UpdateFinalTimeScale();
		}

		// Token: 0x060086CE RID: 34510 RVA: 0x0026C370 File Offset: 0x0026A570
		public void SetGlobalTimeScale(float scale)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGlobalTimeScaleSingle_hotfix != null)
			{
				this.m_SetGlobalTimeScaleSingle_hotfix.call(new object[]
				{
					this,
					scale
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_globalTimeScale = scale;
			this.UpdateFinalTimeScale();
		}

		// Token: 0x060086CF RID: 34511 RVA: 0x0026C3F0 File Offset: 0x0026A5F0
		private void UpdateFinalTimeScale()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateFinalTimeScale_hotfix != null)
			{
				this.m_UpdateFinalTimeScale_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			float timeScale = this.m_timeScale * this.m_globalTimeScale * ((!this.m_isFastBattle) ? 1f : 1.3f);
			SystemUtility.SetTimeScale(timeScale);
		}

		// Token: 0x060086D0 RID: 34512 RVA: 0x0026C480 File Offset: 0x0026A680
		private void TickGraphic(float dt)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickGraphicSingle_hotfix != null)
			{
				this.m_TickGraphicSingle_hotfix.call(new object[]
				{
					this,
					dt
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsRebuildingBattle())
			{
				return;
			}
			if (this.m_isPaused)
			{
				dt = 0f;
			}
			EntityList.TickGraphic<ClientBattleActor>(this.m_actors, dt);
			EntityList.TickGraphic<ClientBattleTreasure>(this.m_treasures, dt);
			if (this.m_cameraFollowActor != null && !this.m_battleCamera.IsSmoothMoving())
			{
				this.m_battleCamera.Bound(this.m_cameraFollowActor.GetGraphicPosition(), dt, this.m_configDataLoader.Const_BattleActorMoveSpeed);
			}
			this.m_battle.TickGraphic(dt);
		}

		// Token: 0x060086D1 RID: 34513 RVA: 0x0026C570 File Offset: 0x0026A770
		private void Draw()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Draw_hotfix != null)
			{
				this.m_Draw_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_isEnableDebugDraw)
			{
				return;
			}
			if (this.m_state != ClientBattleState.Combat)
			{
				this.DrawMap();
				EntityList.Draw<ClientBattleActor>(this.m_actors);
				EntityList.Draw<ClientBattleTreasure>(this.m_treasures);
			}
			else
			{
				this.m_battle.Draw();
			}
		}

		// Token: 0x060086D2 RID: 34514 RVA: 0x0026C614 File Offset: 0x0026A814
		public void Clear()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Clear_hotfix != null)
			{
				this.m_Clear_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_nullActor != null)
			{
				this.m_nullActor.Dispose();
				this.m_nullActor = null;
			}
			EntityList.RemoveAll<ClientBattleActor>(this.m_actors);
			EntityList.RemoveAll<ClientBattleTreasure>(this.m_treasures);
			this.m_actorActs.Clear();
			this.m_activeActor = null;
			this.m_cameraFollowActor = null;
			this.m_state = ClientBattleState.None;
			this.m_entityIdCounter = 0;
			this.m_isStopBattleWin = false;
			this.m_frameCount = 0;
			this.m_endCountdown = 0;
			this.m_cutscenePauseCountdown = 0;
			this.m_restoreNonSkillTargetsCountdown = 0;
			this.m_tickSoundName = string.Empty;
			this.m_battleTickTime = 0f;
			this.m_combatTickTime = 0f;
			this.m_slowMotionState = SlowMotionState.None;
			this.m_slowMotionCountdown = 0f;
			this.m_enforceActionOrderHeroIds.Clear();
			this.m_combatingBattleActorA = null;
			this.m_combatingBattleActorB = null;
			this.m_combatSkillInfoA = null;
			this.m_ignoreMoveStep = -1;
			this.m_ignoreSkillStep = -1;
			this.m_ignoreTeleportDisappearStep = -1;
			this.m_ignoreActiveTeam = -1;
			this.m_ignoreActiveTurn = -1;
			this.m_curBattleDialogInfo = null;
			this.m_battleDialogResult = 0;
			this.m_isWaitBattleTreasureDialog = false;
			this.m_isWaitBattleTreasureReward = false;
			this.m_isWaitFastCombat = false;
			this.m_isBattlePerforming = false;
			this.m_rebuildBattleStepMax = -1;
			this.m_skipCombatMode = SkipCombatMode.None;
			this.m_battle.Clear();
			this.m_battleFxPlayer.Clear();
			this.m_combatFxPlayer.Clear();
			this.m_cutscenePlayer.Clear();
		}

		// Token: 0x060086D3 RID: 34515 RVA: 0x0026C7CC File Offset: 0x0026A9CC
		public void CreateMap(ConfigDataBattleInfo battleInfo, BattleType battleType, int myPlayerIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateMapConfigDataBattleInfoBattleTypeInt32_hotfix != null)
			{
				this.m_CreateMapConfigDataBattleInfoBattleTypeInt32_hotfix.call(new object[]
				{
					this,
					battleInfo,
					battleType,
					myPlayerIndex
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (battleInfo == null)
			{
				return;
			}
			this.m_battleInfo = battleInfo;
			this.m_battleType = battleType;
			this.m_arenaBattleInfo = null;
			this.m_pvpBattleInfo = null;
			this.m_realtimePvpBattleInfo = null;
			this.m_myPlayerIndex = myPlayerIndex;
			this.m_myPlayerTeam = 0;
			this._CreateMap(battleInfo.m_battlefieldInfo, battleInfo.CameraX, battleInfo.CameraY);
		}

		// Token: 0x060086D4 RID: 34516 RVA: 0x0026C8AC File Offset: 0x0026AAAC
		public void CreateArenaMap(ConfigDataArenaBattleInfo battleInfo, int myPlayerTeam)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateArenaMapConfigDataArenaBattleInfoInt32_hotfix != null)
			{
				this.m_CreateArenaMapConfigDataArenaBattleInfoInt32_hotfix.call(new object[]
				{
					this,
					battleInfo,
					myPlayerTeam
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (battleInfo == null)
			{
				return;
			}
			this.m_arenaBattleInfo = battleInfo;
			this.m_battleType = BattleType.ArenaAttack;
			this.m_battleInfo = null;
			this.m_pvpBattleInfo = null;
			this.m_realtimePvpBattleInfo = null;
			this.m_myPlayerIndex = -1;
			this.m_myPlayerTeam = myPlayerTeam;
			this._CreateMap(battleInfo.m_battlefieldInfo, battleInfo.CameraX, battleInfo.CameraY);
		}

		// Token: 0x060086D5 RID: 34517 RVA: 0x0026C97C File Offset: 0x0026AB7C
		public void CreatePVPMap(ConfigDataPVPBattleInfo battleInfo, int myPlayerIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreatePVPMapConfigDataPVPBattleInfoInt32_hotfix != null)
			{
				this.m_CreatePVPMapConfigDataPVPBattleInfoInt32_hotfix.call(new object[]
				{
					this,
					battleInfo,
					myPlayerIndex
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (battleInfo == null)
			{
				return;
			}
			this.m_pvpBattleInfo = battleInfo;
			this.m_battleType = BattleType.PVP;
			this.m_battleInfo = null;
			this.m_arenaBattleInfo = null;
			this.m_realtimePvpBattleInfo = null;
			this.m_myPlayerIndex = myPlayerIndex;
			this.m_myPlayerTeam = myPlayerIndex;
			if (myPlayerIndex == 0)
			{
				this._CreateMap(battleInfo.m_battlefieldInfo, battleInfo.CameraX, battleInfo.CameraY);
			}
			else
			{
				this._CreateMap(battleInfo.m_battlefieldInfo, battleInfo.DefendCameraX, battleInfo.DefendCameraY);
			}
		}

		// Token: 0x060086D6 RID: 34518 RVA: 0x0026CA70 File Offset: 0x0026AC70
		public void CreateRealTimePVPMap(ConfigDataRealTimePVPBattleInfo battleInfo, int myPlayerIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateRealTimePVPMapConfigDataRealTimePVPBattleInfoInt32_hotfix != null)
			{
				this.m_CreateRealTimePVPMapConfigDataRealTimePVPBattleInfoInt32_hotfix.call(new object[]
				{
					this,
					battleInfo,
					myPlayerIndex
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (battleInfo == null)
			{
				return;
			}
			this.m_realtimePvpBattleInfo = battleInfo;
			this.m_battleType = BattleType.RealTimePVP;
			this.m_battleInfo = null;
			this.m_arenaBattleInfo = null;
			this.m_pvpBattleInfo = null;
			this.m_myPlayerIndex = myPlayerIndex;
			this.m_myPlayerTeam = myPlayerIndex;
			if (myPlayerIndex == 0)
			{
				this._CreateMap(battleInfo.m_battlefieldInfo, battleInfo.CameraX, battleInfo.CameraY);
			}
			else
			{
				this._CreateMap(battleInfo.m_battlefieldInfo, battleInfo.DefendCameraX, battleInfo.DefendCameraY);
			}
		}

		// Token: 0x060086D7 RID: 34519 RVA: 0x0026CB64 File Offset: 0x0026AD64
		private void _CreateMap(ConfigDataBattlefieldInfo battlefieldInfo, int cameraX, int cameraY)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m__CreateMapConfigDataBattlefieldInfoInt32Int32_hotfix != null)
			{
				this.m__CreateMapConfigDataBattlefieldInfoInt32Int32_hotfix.call(new object[]
				{
					this,
					battlefieldInfo,
					cameraX,
					cameraY
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battle.CreateMap(battlefieldInfo);
			this.CreateMapBackground(battlefieldInfo, this.m_mapRoot);
			this.CreateMapTerrainFx(this.m_mapTerrainFxRoot);
			this.m_mapRoot.SetActive(true);
			this.m_battleRoot.SetActive(true);
			this.m_combatRoot.SetActive(false);
			this.m_cutsceneRoot.SetActive(false);
			this.m_battleCamera.PrepareBattle(battlefieldInfo);
			this.m_battleCamera.Look(this.GridPositionToWorldPosition(new GridPosition(cameraX, cameraY)));
			this.m_state = ClientBattleState.Prepare;
		}

		// Token: 0x060086D8 RID: 34520 RVA: 0x0026CC78 File Offset: 0x0026AE78
		public void ResetMap()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ResetMap_hotfix != null)
			{
				this.m_ResetMap_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battle.ResetMap();
			this.CreateMapTerrainFx(this.m_mapTerrainFxRoot);
		}

		// Token: 0x060086D9 RID: 34521 RVA: 0x0026CCF0 File Offset: 0x0026AEF0
		public void Start(BattleTeamSetup teamSetup0, BattleTeamSetup teamSetup1, BattlePlayer[] players, int randomSeed, int armyRandomSeed, int monsterLevel, int starTurnMax, int starDeadMax, List<ConfigDataBattleAchievementRelatedInfo> achievements, List<int> gainBattleTreasures)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32Int32Int32Int32Int32List`1List`1_hotfix != null)
			{
				this.m_StartBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32Int32Int32Int32Int32List`1List`1_hotfix.call(new object[]
				{
					this,
					teamSetup0,
					teamSetup1,
					players,
					randomSeed,
					armyRandomSeed,
					monsterLevel,
					starTurnMax,
					starDeadMax,
					achievements,
					gainBattleTreasures
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_battleInfo == null)
			{
				global::Debug.LogWarning("ClientBattle.Start error, map not created.");
				return;
			}
			this.Clear();
			this.m_state = ClientBattleState.Play;
			this.m_isPaused = false;
			this.m_isAutoBattle = false;
			this.m_isFastBattle = false;
			this.m_randomNumber.SetSeed(randomSeed * 3);
			this.m_nullActor = new ClientBattleActor();
			this.m_nullActor.Initialize(this, new BattleActor());
			this.m_battle.SetMyPlayerTeamNumber(this.m_myPlayerTeam);
			this.m_battle.InitBattle(this.m_battleInfo, this.m_battleType, teamSetup0, teamSetup1, players, randomSeed, armyRandomSeed, monsterLevel);
			if (!this.m_battle.IsPerformOnlyBattle())
			{
				if (achievements != null)
				{
					this.m_battle.InitStarAndAchievement(starTurnMax, starDeadMax, achievements);
				}
				if (gainBattleTreasures != null)
				{
					this.m_battle.InitGainBattleTreasures(gainBattleTreasures);
				}
			}
			this.m_battle.Start();
			this.m_battleCamera.StartBattle();
			this.m_battleCamera.EnableTouchMove(true);
			if (!this.m_battle.IsPerformOnlyBattle())
			{
				ClientNullActorActStartBattle clientNullActorActStartBattle = new ClientNullActorActStartBattle();
				clientNullActorActStartBattle.m_actor = null;
				clientNullActorActStartBattle.m_step = this.m_battle.Step;
				this.m_actorActs.Add(clientNullActorActStartBattle);
				GridPosition gridPosition = GridPosition.Null;
				foreach (ConfigDataBattleWinConditionInfo winConditionInfo in this.m_battleInfo.m_battleWinConditionInfos)
				{
					gridPosition = this.GetWinConditionTargetPosition(winConditionInfo);
					if (gridPosition != GridPosition.Null)
					{
						ClientNullActorActBattleWinCondition clientNullActorActBattleWinCondition = new ClientNullActorActBattleWinCondition();
						clientNullActorActBattleWinCondition.m_actor = null;
						clientNullActorActBattleWinCondition.m_step = this.m_battle.Step;
						clientNullActorActBattleWinCondition.m_winConditionInfo = this.m_battleInfo.m_battleWinConditionInfos[0];
						clientNullActorActBattleWinCondition.m_targetPosition = gridPosition;
						this.m_actorActs.Add(clientNullActorActBattleWinCondition);
						break;
					}
				}
				if (gridPosition == GridPosition.Null)
				{
					foreach (ConfigDataBattleLoseConditionInfo loseConditionInfo in this.m_battleInfo.m_battleLoseConditionInfos)
					{
						gridPosition = this.GetLoseConditionTargetPosition(loseConditionInfo);
						if (gridPosition != GridPosition.Null)
						{
							ClientNullActorActBattleLoseCondition clientNullActorActBattleLoseCondition = new ClientNullActorActBattleLoseCondition();
							clientNullActorActBattleLoseCondition.m_actor = null;
							clientNullActorActBattleLoseCondition.m_step = this.m_battle.Step;
							clientNullActorActBattleLoseCondition.m_loseConditionInfo = this.m_battleInfo.m_battleLoseConditionInfos[0];
							clientNullActorActBattleLoseCondition.m_targetPosition = gridPosition;
							this.m_actorActs.Add(clientNullActorActBattleLoseCondition);
							break;
						}
					}
				}
			}
		}

		// Token: 0x060086DA RID: 34522 RVA: 0x0026D058 File Offset: 0x0026B258
		public void StartArena(BattleTeamSetup teamSetup0, BattleTeamSetup teamSetup1, BattlePlayer[] players, int randomSeed, ConfigDataArenaDefendRuleInfo arenaDefendRuleInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartArenaBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32ConfigDataArenaDefendRuleInfo_hotfix != null)
			{
				this.m_StartArenaBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32ConfigDataArenaDefendRuleInfo_hotfix.call(new object[]
				{
					this,
					teamSetup0,
					teamSetup1,
					players,
					randomSeed,
					arenaDefendRuleInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_arenaBattleInfo == null)
			{
				global::Debug.LogWarning("ClientBattle.StartArena error, map not created.");
				return;
			}
			this.Clear();
			this.m_state = ClientBattleState.Play;
			this.m_isPaused = false;
			this.m_isAutoBattle = false;
			this.m_isFastBattle = false;
			this.m_randomNumber.SetSeed(randomSeed * 3);
			this.m_nullActor = new ClientBattleActor();
			this.m_nullActor.Initialize(this, new BattleActor());
			this.m_battle.SetMyPlayerTeamNumber(this.m_myPlayerTeam);
			this.m_battle.InitArenaBattle(this.m_arenaBattleInfo, teamSetup0, teamSetup1, players, randomSeed, arenaDefendRuleInfo);
			this.m_battle.Start();
			this.m_battleCamera.StartBattle();
			this.m_battleCamera.EnableTouchMove(true);
			ClientNullActorActStartBattle clientNullActorActStartBattle = new ClientNullActorActStartBattle();
			clientNullActorActStartBattle.m_actor = null;
			clientNullActorActStartBattle.m_step = this.m_battle.Step;
			this.m_actorActs.Add(clientNullActorActStartBattle);
		}

		// Token: 0x060086DB RID: 34523 RVA: 0x0026D1E4 File Offset: 0x0026B3E4
		public void StartPVP(BattleTeamSetup teamSetup0, BattleTeamSetup teamSetup1, BattlePlayer[] players, int randomSeed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartPVPBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32_hotfix != null)
			{
				this.m_StartPVPBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32_hotfix.call(new object[]
				{
					this,
					teamSetup0,
					teamSetup1,
					players,
					randomSeed
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_pvpBattleInfo == null)
			{
				global::Debug.LogWarning("ClientBattle.StartPVP error, map not created.");
				return;
			}
			this.Clear();
			this.m_state = ClientBattleState.Play;
			this.m_isPaused = false;
			this.m_isAutoBattle = false;
			this.m_isFastBattle = false;
			this.m_randomNumber.SetSeed(randomSeed * 3);
			this.m_nullActor = new ClientBattleActor();
			this.m_nullActor.Initialize(this, new BattleActor());
			this.m_battle.SetMyPlayerTeamNumber(this.m_myPlayerTeam);
			this.m_battle.InitPVPBattle(this.m_pvpBattleInfo, teamSetup0, teamSetup1, players, randomSeed);
			this.m_battle.Start();
			this.m_battleCamera.StartBattle();
			this.m_battleCamera.EnableTouchMove(true);
			ClientNullActorActStartBattle clientNullActorActStartBattle = new ClientNullActorActStartBattle();
			clientNullActorActStartBattle.m_actor = null;
			clientNullActorActStartBattle.m_step = this.m_battle.Step;
			this.m_actorActs.Add(clientNullActorActStartBattle);
		}

		// Token: 0x060086DC RID: 34524 RVA: 0x0026D35C File Offset: 0x0026B55C
		public void StartRealTimePVP(BattleTeamSetup teamSetup0, BattleTeamSetup teamSetup1, BattlePlayer[] players, int randomSeed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartRealTimePVPBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32_hotfix != null)
			{
				this.m_StartRealTimePVPBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32_hotfix.call(new object[]
				{
					this,
					teamSetup0,
					teamSetup1,
					players,
					randomSeed
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_realtimePvpBattleInfo == null)
			{
				global::Debug.LogWarning("ClientBattle.StartRealTimePVP error, map not created.");
				return;
			}
			this.Clear();
			this.m_state = ClientBattleState.Play;
			this.m_isPaused = false;
			this.m_isAutoBattle = false;
			this.m_isFastBattle = false;
			this.m_randomNumber.SetSeed(randomSeed * 3);
			this.m_nullActor = new ClientBattleActor();
			this.m_nullActor.Initialize(this, new BattleActor());
			this.m_battle.SetMyPlayerTeamNumber(this.m_myPlayerTeam);
			this.m_battle.InitRealTimePVPBattle(this.m_realtimePvpBattleInfo, teamSetup0, teamSetup1, players, randomSeed);
			this.m_battle.Start();
			this.m_battleCamera.StartBattle();
			this.m_battleCamera.EnableTouchMove(true);
			ClientNullActorActStartBattle clientNullActorActStartBattle = new ClientNullActorActStartBattle();
			clientNullActorActStartBattle.m_actor = null;
			clientNullActorActStartBattle.m_step = this.m_battle.Step;
			this.m_actorActs.Add(clientNullActorActStartBattle);
		}

		// Token: 0x060086DD RID: 34525 RVA: 0x0026D4D4 File Offset: 0x0026B6D4
		public bool IsTeamBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsTeamBattle_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsTeamBattle_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_myPlayerIndex >= 0 && this.m_battleInfo != null;
		}

		// Token: 0x060086DE RID: 34526 RVA: 0x0026D55C File Offset: 0x0026B75C
		public void SetEnforceActionOrderHeros(List<int> heroIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetEnforceActionOrderHerosList`1_hotfix != null)
			{
				this.m_SetEnforceActionOrderHerosList`1_hotfix.call(new object[]
				{
					this,
					heroIds
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_enforceActionOrderHeroIds.Clear();
			this.m_enforceActionOrderHeroIds.AddRange(heroIds);
		}

		// Token: 0x060086DF RID: 34527 RVA: 0x0026D5E4 File Offset: 0x0026B7E4
		public void FirstStep()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FirstStep_hotfix != null)
			{
				this.m_FirstStep_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battle.FirstStep(false);
			if (this.m_battle.IsPerformOnlyBattle())
			{
				int num = -1;
				while (this.m_actorActs.Count > 0)
				{
					ClientActorAct clientActorAct = this.m_actorActs[0];
					this.m_actorActs.RemoveAt(0);
					ClientBattleActor clientBattleActor;
					if (clientActorAct.m_actor == null)
					{
						clientBattleActor = this.m_nullActor;
					}
					else
					{
						clientBattleActor = this.GetActor(clientActorAct.m_actor);
					}
					if (clientBattleActor != null)
					{
						clientBattleActor.AddAct(clientActorAct);
					}
					if (num >= 0)
					{
						num++;
						if (num >= 1)
						{
							break;
						}
					}
					if (clientActorAct.GetType() == typeof(ClientNullActorActStartBattlePerform))
					{
						num = 0;
					}
				}
			}
		}

		// Token: 0x060086E0 RID: 34528 RVA: 0x0026D6F4 File Offset: 0x0026B8F4
		public void Stop(bool win, bool skipPerform)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StopBooleanBoolean_hotfix != null)
			{
				this.m_StopBooleanBoolean_hotfix.call(new object[]
				{
					this,
					win,
					skipPerform
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_state == ClientBattleState.Stop)
			{
				return;
			}
			if (this.m_state == ClientBattleState.Combat)
			{
				this.StopCombat();
			}
			if (this.IsBattlePerforming())
			{
				this.StopBattlePerform();
			}
			if (this.IsRebuildingBattle())
			{
				this.StopRebuildingBattle();
			}
			this.m_state = ClientBattleState.Stop;
			this.m_isStopBattleWin = win;
			this.SetFastBattle(false);
			this.SetTimeScale(1f);
			if (!skipPerform)
			{
				this.m_endCountdown = ClientBattle.MillisecondToFrame1(this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_Battle_StopDelay));
			}
			else
			{
				this.m_endCountdown = 0;
				this.m_clientBattleListener.OnStopBattle(this.m_isStopBattleWin, skipPerform);
			}
		}

		// Token: 0x060086E1 RID: 34529 RVA: 0x0026D810 File Offset: 0x0026BA10
		private GridPosition GetWinConditionTargetPosition(ConfigDataBattleWinConditionInfo winConditionInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetWinConditionTargetPositionConfigDataBattleWinConditionInfo_hotfix != null)
			{
				return (GridPosition)this.m_GetWinConditionTargetPositionConfigDataBattleWinConditionInfo_hotfix.call(new object[]
				{
					this,
					winConditionInfo
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GridPosition result = GridPosition.Null;
			if (winConditionInfo != null)
			{
				if (winConditionInfo.WinConditionType == BattleWinConditionType.BattleWinConditionType_KillActor)
				{
					if (winConditionInfo.Param1.Count > 0)
					{
						BattleActor actorByHeroId = this.m_battle.GetActorByHeroId(winConditionInfo.Param1[0]);
						if (actorByHeroId != null)
						{
							result = actorByHeroId.Position;
						}
					}
				}
				else if (winConditionInfo.WinConditionType == BattleWinConditionType.BattleWinConditionType_ActorNotDead)
				{
					if (winConditionInfo.Param1.Count > 0)
					{
						BattleActor actorByHeroId2 = this.m_battle.GetActorByHeroId(winConditionInfo.Param1[0]);
						if (actorByHeroId2 != null)
						{
							result = actorByHeroId2.Position;
						}
					}
				}
				else if (winConditionInfo.WinConditionType == BattleWinConditionType.BattleWinConditionType_ActorReachPosition && winConditionInfo.Param3.Count > 0)
				{
					result = new GridPosition(winConditionInfo.Param3[0].X, winConditionInfo.Param3[0].Y);
				}
			}
			return result;
		}

		// Token: 0x060086E2 RID: 34530 RVA: 0x0026D970 File Offset: 0x0026BB70
		private GridPosition GetLoseConditionTargetPosition(ConfigDataBattleLoseConditionInfo loseConditionInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetLoseConditionTargetPositionConfigDataBattleLoseConditionInfo_hotfix != null)
			{
				return (GridPosition)this.m_GetLoseConditionTargetPositionConfigDataBattleLoseConditionInfo_hotfix.call(new object[]
				{
					this,
					loseConditionInfo
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GridPosition @null = GridPosition.Null;
			if (loseConditionInfo != null && loseConditionInfo.LoseConditionType == BattleLoseConditionType.BattleLoseConditionType_ActorReachPosition && loseConditionInfo.Param3.Count > 0)
			{
				@null = new GridPosition(loseConditionInfo.Param3[0].X, loseConditionInfo.Param3[0].Y);
			}
			return @null;
		}

		// Token: 0x060086E3 RID: 34531 RVA: 0x0026DA40 File Offset: 0x0026BC40
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
			this.m_isPaused = pause;
			foreach (ClientBattleActor clientBattleActor in this.m_actors)
			{
				clientBattleActor.Pause(pause);
			}
			foreach (ClientBattleTreasure clientBattleTreasure in this.m_treasures)
			{
				clientBattleTreasure.Pause(pause);
			}
		}

		// Token: 0x060086E4 RID: 34532 RVA: 0x0026DB54 File Offset: 0x0026BD54
		public void SetAutoBattle(bool autoBattle)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetAutoBattleBoolean_hotfix != null)
			{
				this.m_SetAutoBattleBoolean_hotfix.call(new object[]
				{
					this,
					autoBattle
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isAutoBattle = autoBattle;
		}

		// Token: 0x060086E5 RID: 34533 RVA: 0x0026DBCC File Offset: 0x0026BDCC
		public void SetFastBattle(bool fastBattle)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetFastBattleBoolean_hotfix != null)
			{
				this.m_SetFastBattleBoolean_hotfix.call(new object[]
				{
					this,
					fastBattle
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isFastBattle = fastBattle;
			this.UpdateFinalTimeScale();
		}

		// Token: 0x060086E6 RID: 34534 RVA: 0x0026DC4C File Offset: 0x0026BE4C
		public void StartBattleDialog(ConfigDataBattleDialogInfo dialogInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartBattleDialogConfigDataBattleDialogInfo_hotfix != null)
			{
				this.m_StartBattleDialogConfigDataBattleDialogInfo_hotfix.call(new object[]
				{
					this,
					dialogInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_curBattleDialogInfo = dialogInfo;
			this.m_clientBattleListener.OnStartBattleDialog(dialogInfo);
		}

		// Token: 0x060086E7 RID: 34535 RVA: 0x0026DCD0 File Offset: 0x0026BED0
		public void StopBattleDialog(int result)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StopBattleDialogInt32_hotfix != null)
			{
				this.m_StopBattleDialogInt32_hotfix.call(new object[]
				{
					this,
					result
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curBattleDialogInfo == null)
			{
				return;
			}
			this.m_curBattleDialogInfo = null;
			this.m_battleDialogResult = result;
		}

		// Token: 0x060086E8 RID: 34536 RVA: 0x0026DD5C File Offset: 0x0026BF5C
		public int GetBattleDialogResult()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetBattleDialogResult_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetBattleDialogResult_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_battleDialogResult;
		}

		// Token: 0x060086E9 RID: 34537 RVA: 0x0026DDD0 File Offset: 0x0026BFD0
		public bool IsWaitBattleDialog()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsWaitBattleDialog_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsWaitBattleDialog_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_curBattleDialogInfo != null;
		}

		// Token: 0x060086EA RID: 34538 RVA: 0x0026DE48 File Offset: 0x0026C048
		public void StartBattleTreasureDialog(ConfigDataBattleTreasureInfo treasureInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartBattleTreasureDialogConfigDataBattleTreasureInfo_hotfix != null)
			{
				this.m_StartBattleTreasureDialogConfigDataBattleTreasureInfo_hotfix.call(new object[]
				{
					this,
					treasureInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsRebuildingBattle())
			{
				return;
			}
			if (string.IsNullOrEmpty(treasureInfo.Desc))
			{
				return;
			}
			this.m_isWaitBattleTreasureDialog = true;
			this.m_clientBattleListener.OnStartBattleTreasureDialog(treasureInfo);
		}

		// Token: 0x060086EB RID: 34539 RVA: 0x0026DEE8 File Offset: 0x0026C0E8
		public void StopBattleTreasureDialog()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StopBattleTreasureDialog_hotfix != null)
			{
				this.m_StopBattleTreasureDialog_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isWaitBattleTreasureDialog = false;
		}

		// Token: 0x060086EC RID: 34540 RVA: 0x0026DF50 File Offset: 0x0026C150
		public bool IsWaitBattleTreasureDialog()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsWaitBattleTreasureDialog_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsWaitBattleTreasureDialog_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isWaitBattleTreasureDialog;
		}

		// Token: 0x060086ED RID: 34541 RVA: 0x0026DFC4 File Offset: 0x0026C1C4
		public void StartBattleTreasureReward(ConfigDataBattleTreasureInfo treasureInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartBattleTreasureRewardConfigDataBattleTreasureInfo_hotfix != null)
			{
				this.m_StartBattleTreasureRewardConfigDataBattleTreasureInfo_hotfix.call(new object[]
				{
					this,
					treasureInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsRebuildingBattle())
			{
				return;
			}
			this.m_isWaitBattleTreasureReward = true;
			this.m_clientBattleListener.OnShowBattleTreasureReward(treasureInfo);
		}

		// Token: 0x060086EE RID: 34542 RVA: 0x0026E054 File Offset: 0x0026C254
		public void StopBattleTreasureReward()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StopBattleTreasureReward_hotfix != null)
			{
				this.m_StopBattleTreasureReward_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isWaitBattleTreasureReward = false;
		}

		// Token: 0x060086EF RID: 34543 RVA: 0x0026E0BC File Offset: 0x0026C2BC
		public bool IsWaitBattleTreasureReward()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsWaitBattleTreasureReward_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsWaitBattleTreasureReward_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isWaitBattleTreasureReward;
		}

		// Token: 0x060086F0 RID: 34544 RVA: 0x0026E130 File Offset: 0x0026C330
		public void StartFastCombat(FastCombatActorInfo a, FastCombatActorInfo b)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartFastCombatFastCombatActorInfoFastCombatActorInfo_hotfix != null)
			{
				this.m_StartFastCombatFastCombatActorInfoFastCombatActorInfo_hotfix.call(new object[]
				{
					this,
					a,
					b
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isWaitFastCombat = true;
			this.m_clientBattleListener.OnStartFastCombat(a, b);
		}

		// Token: 0x060086F1 RID: 34545 RVA: 0x0026E1C4 File Offset: 0x0026C3C4
		public void StopFastCombat()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StopFastCombat_hotfix != null)
			{
				this.m_StopFastCombat_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isWaitFastCombat = false;
		}

		// Token: 0x060086F2 RID: 34546 RVA: 0x0026E22C File Offset: 0x0026C42C
		public bool IsWaitFastCombat()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsWaitFastCombat_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsWaitFastCombat_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isWaitFastCombat;
		}

		// Token: 0x060086F3 RID: 34547 RVA: 0x0026E2A0 File Offset: 0x0026C4A0
		public void StartBattlePerform()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartBattlePerform_hotfix != null)
			{
				this.m_StartBattlePerform_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isBattlePerforming = true;
			this.m_battleCamera.EnableTouchMove(false);
			this.m_clientBattleListener.OnStartBattlePerform();
		}

		// Token: 0x060086F4 RID: 34548 RVA: 0x0026E320 File Offset: 0x0026C520
		public void StopBattlePerform()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StopBattlePerform_hotfix != null)
			{
				this.m_StopBattlePerform_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isBattlePerforming = false;
			this.m_battleCamera.EnableTouchMove(true);
			this.m_clientBattleListener.OnStopBattlePerform();
		}

		// Token: 0x060086F5 RID: 34549 RVA: 0x0026E3A0 File Offset: 0x0026C5A0
		public bool IsBattlePerforming()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsBattlePerforming_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsBattlePerforming_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isBattlePerforming;
		}

		// Token: 0x060086F6 RID: 34550 RVA: 0x0026E414 File Offset: 0x0026C614
		private void FadeNonSkillTargets(ClientBattleActor ca, ConfigDataSkillInfo skillInfo, GridPosition targetPos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FadeNonSkillTargetsClientBattleActorConfigDataSkillInfoGridPosition_hotfix != null)
			{
				this.m_FadeNonSkillTargetsClientBattleActorConfigDataSkillInfoGridPosition_hotfix.call(new object[]
				{
					this,
					ca,
					skillInfo,
					targetPos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (ca == null || skillInfo == null)
			{
				return;
			}
			List<GridPosition> list = this.m_battle.AllocateTempGridPositionList();
			this.m_battle.FindAttackRegion(targetPos, skillInfo.BF_Range - 1, skillInfo.BF_RangeShape, list);
			this.m_battle.Map.ClearRegion();
			foreach (GridPosition p in list)
			{
				this.m_battle.Map.SetRegion(p, 2);
			}
			this.m_battle.FreeTempGridPositionList(list);
			foreach (ClientBattleActor clientBattleActor in this.m_actors)
			{
				BattleActor battleActor = clientBattleActor.BattleActor;
				bool flag = this.m_battle.Map.GetRegion(clientBattleActor.Position) == 2 && ca.BattleActor.IsBattlefiledSkillApplyTarget(skillInfo, battleActor);
				clientBattleActor.SetGraphicSkillFade(!flag);
			}
			ca.SetGraphicSkillFade(false);
			foreach (ClientBattleTreasure clientBattleTreasure in this.m_treasures)
			{
				clientBattleTreasure.SetGraphicSkillFade(true);
			}
		}

		// Token: 0x060086F7 RID: 34551 RVA: 0x0026E628 File Offset: 0x0026C828
		private void RestoreNonSkillTargets()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RestoreNonSkillTargets_hotfix != null)
			{
				this.m_RestoreNonSkillTargets_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (ClientBattleActor clientBattleActor in this.m_actors)
			{
				clientBattleActor.SetGraphicSkillFade(false);
			}
			foreach (ClientBattleTreasure clientBattleTreasure in this.m_treasures)
			{
				clientBattleTreasure.SetGraphicSkillFade(false);
			}
		}

		// Token: 0x060086F8 RID: 34552 RVA: 0x0026E724 File Offset: 0x0026C924
		public List<ClientBattleActor> GetActors()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetActors_hotfix != null)
			{
				return (List<ClientBattleActor>)this.m_GetActors_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_actors;
		}

		// Token: 0x060086F9 RID: 34553 RVA: 0x0026E798 File Offset: 0x0026C998
		public ClientBattleActor GetActor(BattleActor actor)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetActorBattleActor_hotfix != null)
			{
				return (ClientBattleActor)this.m_GetActorBattleActor_hotfix.call(new object[]
				{
					this,
					actor
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (ClientBattleActor clientBattleActor in this.m_actors)
			{
				if (clientBattleActor.BattleActor == actor)
				{
					return clientBattleActor;
				}
			}
			return null;
		}

		// Token: 0x060086FA RID: 34554 RVA: 0x0026E874 File Offset: 0x0026CA74
		private bool IsNeedTargetIcon(BattleActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedTargetIconBattleActor_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedTargetIconBattleActor_hotfix.call(new object[]
				{
					this,
					a
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return a != null && (a.IsAIActor() || this.m_isAutoBattle || (a.PlayerIndex >= 0 && (a.PlayerIndex != this.m_myPlayerIndex || this.m_isAutoBattle)));
		}

		// Token: 0x060086FB RID: 34555 RVA: 0x0026E93C File Offset: 0x0026CB3C
		public void CameraFocusActor(ClientBattleActor ca)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CameraFocusActorClientBattleActor_hotfix != null)
			{
				this.m_CameraFocusActorClientBattleActor_hotfix.call(new object[]
				{
					this,
					ca
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (ca == null)
			{
				return;
			}
			Vector2 graphicPosition = ca.GetGraphicPosition();
			if (this.IsRebuildingBattle())
			{
				this.m_battleCamera.Look(graphicPosition);
			}
			else
			{
				this.m_battleCamera.SmoothLook(graphicPosition);
			}
			this.m_cameraFollowActor = null;
		}

		// Token: 0x060086FC RID: 34556 RVA: 0x0026E9EC File Offset: 0x0026CBEC
		public void CameraFocusPosition(GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CameraFocusPositionGridPosition_hotfix != null)
			{
				this.m_CameraFocusPositionGridPosition_hotfix.call(new object[]
				{
					this,
					p
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Vector2 p2 = this.GridPositionToWorldPosition(p);
			if (this.IsRebuildingBattle())
			{
				this.m_battleCamera.Look(p2);
			}
			else
			{
				this.m_battleCamera.SmoothLook(p2);
			}
			this.m_cameraFollowActor = null;
		}

		// Token: 0x060086FD RID: 34557 RVA: 0x0026EA94 File Offset: 0x0026CC94
		public void CameraFollowActor(ClientBattleActor ca)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CameraFollowActorClientBattleActor_hotfix != null)
			{
				this.m_CameraFollowActorClientBattleActor_hotfix.call(new object[]
				{
					this,
					ca
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_cameraFollowActor = ca;
		}

		// Token: 0x060086FE RID: 34558 RVA: 0x0026EB0C File Offset: 0x0026CD0C
		public bool IsCameraFocusing()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsCameraFocusing_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsCameraFocusing_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_battleCamera.IsSmoothMoving();
		}

		// Token: 0x060086FF RID: 34559 RVA: 0x0026EB84 File Offset: 0x0026CD84
		public int ComputeTotalHealthPoint(int team)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeTotalHealthPointInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_ComputeTotalHealthPointInt32_hotfix.call(new object[]
				{
					this,
					team
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			foreach (ClientBattleActor clientBattleActor in this.m_actors)
			{
				if (clientBattleActor.TeamNumber == team)
				{
					num += clientBattleActor.GetTotalHealthPoint();
				}
			}
			return num;
		}

		// Token: 0x06008700 RID: 34560 RVA: 0x0026EC60 File Offset: 0x0026CE60
		public int ComputeTotalHealthPointMax(int team)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeTotalHealthPointMaxInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_ComputeTotalHealthPointMaxInt32_hotfix.call(new object[]
				{
					this,
					team
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			foreach (ClientBattleActor clientBattleActor in this.m_actors)
			{
				if (clientBattleActor.TeamNumber == team)
				{
					num += clientBattleActor.GetTotalHealthPointMax();
				}
			}
			return num;
		}

		// Token: 0x06008701 RID: 34561 RVA: 0x0026ED3C File Offset: 0x0026CF3C
		public void EndAllAction(int team)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EndAllActionInt32_hotfix != null)
			{
				this.m_EndAllActionInt32_hotfix.call(new object[]
				{
					this,
					team
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_ignoreActiveTeam = team;
			this.m_ignoreActiveTurn = this.m_battle.Turn;
			if (this.m_battle.HasCurrentStepBattleCommand())
			{
				this.m_battle.ExecuteBattleCommand();
			}
			BattleActor actionActor = this.m_battle.GetActionActor();
			while (actionActor != null && !actionActor.IsAINpc() && actionActor.TeamNumber == team && this.m_battle.Turn == this.m_ignoreActiveTurn)
			{
				actionActor.CreateBattleCommand(BattleCommandType.Done);
				this.m_battle.ExecuteBattleCommand();
				actionActor = this.m_battle.GetActionActor();
			}
			this.m_ignoreActiveTeam = -1;
			this.m_ignoreActiveTurn = -1;
		}

		// Token: 0x06008702 RID: 34562 RVA: 0x0026EE54 File Offset: 0x0026D054
		public void IgnoreMoveStep(int step)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IgnoreMoveStepInt32_hotfix != null)
			{
				this.m_IgnoreMoveStepInt32_hotfix.call(new object[]
				{
					this,
					step
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_ignoreMoveStep = step;
		}

		// Token: 0x06008703 RID: 34563 RVA: 0x0026EECC File Offset: 0x0026D0CC
		public void IgnoreSkillStep(int step)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IgnoreSkillStepInt32_hotfix != null)
			{
				this.m_IgnoreSkillStepInt32_hotfix.call(new object[]
				{
					this,
					step
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_ignoreSkillStep = step;
		}

		// Token: 0x06008704 RID: 34564 RVA: 0x0026EF44 File Offset: 0x0026D144
		public void IgnoreTeleportDisappearStep(int step)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IgnoreTeleportDisappearStepInt32_hotfix != null)
			{
				this.m_IgnoreTeleportDisappearStepInt32_hotfix.call(new object[]
				{
					this,
					step
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_ignoreTeleportDisappearStep = step;
		}

		// Token: 0x06008705 RID: 34565 RVA: 0x0026EFBC File Offset: 0x0026D1BC
		public Vector2 GridPositionToWorldPosition(GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GridPositionToWorldPositionGridPosition_hotfix != null)
			{
				return (Vector2)this.m_GridPositionToWorldPositionGridPosition_hotfix.call(new object[]
				{
					this,
					p
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Vector2 result;
			result.x = ((float)p.x - (float)(this.m_battle.Map.Width - 1) * 0.5f) * 2f;
			result.y = ((float)(this.m_battle.Map.Height - 1) * 0.5f - (float)p.y) * 2f;
			return result;
		}

		// Token: 0x06008706 RID: 34566 RVA: 0x0026F098 File Offset: 0x0026D298
		public GridPosition WorldPositionToGridPosition(Vector2 sp)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldPositionToGridPositionVector2_hotfix != null)
			{
				return (GridPosition)this.m_WorldPositionToGridPositionVector2_hotfix.call(new object[]
				{
					this,
					sp
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			float fx = sp.x / 2f + (float)(this.m_battle.Map.Width - 1) * 0.5f;
			float fy = (float)(this.m_battle.Map.Height - 1) * 0.5f - sp.y / 2f;
			return GridPosition.Round(fx, fy);
		}

		// Token: 0x06008707 RID: 34567 RVA: 0x0026F16C File Offset: 0x0026D36C
		public Vector2 ScreenPositionToWorldPosition(Vector2 p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ScreenPositionToWorldPositionVector2_hotfix != null)
			{
				return (Vector2)this.m_ScreenPositionToWorldPositionVector2_hotfix.call(new object[]
				{
					this,
					p
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Camera camera = this.m_battleCamera.Camera;
			if (camera == null)
			{
				return Vector2.zero;
			}
			return camera.ScreenToWorldPoint(p);
		}

		// Token: 0x06008708 RID: 34568 RVA: 0x0026F218 File Offset: 0x0026D418
		public GridPosition ScreenPositionToGridPosition(Vector2 p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ScreenPositionToGridPositionVector2_hotfix != null)
			{
				return (GridPosition)this.m_ScreenPositionToGridPositionVector2_hotfix.call(new object[]
				{
					this,
					p
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.WorldPositionToGridPosition(this.ScreenPositionToWorldPosition(p));
		}

		// Token: 0x06008709 RID: 34569 RVA: 0x0026F2A4 File Offset: 0x0026D4A4
		public Vector2 GridPositionToScreenPosition(GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GridPositionToScreenPositionGridPosition_hotfix != null)
			{
				return (Vector2)this.m_GridPositionToScreenPositionGridPosition_hotfix.call(new object[]
				{
					this,
					p
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Camera camera = this.m_battleCamera.Camera;
			if (camera == null)
			{
				return Vector2.zero;
			}
			return camera.WorldToScreenPoint(this.GridPositionToWorldPosition(p));
		}

		// Token: 0x0600870A RID: 34570 RVA: 0x0026F358 File Offset: 0x0026D558
		public void DrawLine(Vector3 p0, Vector3 p1, Color color)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DrawLineVector3Vector3Color_hotfix != null)
			{
				this.m_DrawLineVector3Vector3Color_hotfix.call(new object[]
				{
					this,
					p0,
					p1,
					color
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.DrawLine(p0, p1, color);
		}

		// Token: 0x0600870B RID: 34571 RVA: 0x0026F3F0 File Offset: 0x0026D5F0
		private void DrawMap()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DrawMap_hotfix != null)
			{
				this.m_DrawMap_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			for (int i = 0; i < this.m_battle.Map.Height; i++)
			{
				for (int j = 0; j < this.m_battle.Map.Width; j++)
				{
					GridPosition p = new GridPosition(j, i);
					this.DrawCell(p, this.m_battle.Map.GetActor(p), this.m_battle.Map.GetTerrain(p));
				}
			}
		}

		// Token: 0x0600870C RID: 34572 RVA: 0x0026F4C4 File Offset: 0x0026D6C4
		private void DrawCell(GridPosition p, BattleActor actor, ConfigDataTerrainInfo terrain)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DrawCellGridPositionBattleActorConfigDataTerrainInfo_hotfix != null)
			{
				this.m_DrawCellGridPositionBattleActorConfigDataTerrainInfo_hotfix.call(new object[]
				{
					this,
					p,
					actor,
					terrain
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (terrain != null)
			{
				Color color = new Color((float)terrain.ColorR / 255f, (float)terrain.ColorG / 255f, (float)terrain.ColorB / 255f);
				this.DrawGrid(p, 0.99f, color, false);
			}
			if (actor != null)
			{
				Color color2;
				if (actor.TeamNumber == 0)
				{
					color2 = new Color(1f, 1f, 1f);
				}
				else
				{
					color2 = new Color(0.8f, 0f, 0f);
				}
				this.DrawGrid(p, 0.9f, color2, false);
			}
		}

		// Token: 0x0600870D RID: 34573 RVA: 0x0026F5E8 File Offset: 0x0026D7E8
		public void DrawGrid(GridPosition p, float scale, Color color, bool cross = false)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DrawGridGridPositionSingleColorBoolean_hotfix != null)
			{
				this.m_DrawGridGridPositionSingleColorBoolean_hotfix.call(new object[]
				{
					this,
					p,
					scale,
					color,
					cross
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			float num = 2f * scale * 0.5f;
			float num2 = 2f * scale * 0.5f;
			Vector3 vector = this.GridPositionToWorldPosition(p);
			Vector3 p2 = new Vector3(vector.x - num, vector.y - num2, vector.z);
			Vector3 vector2 = new Vector3(vector.x + num, vector.y - num2, vector.z);
			Vector3 vector3 = new Vector3(vector.x - num, vector.y + num2, vector.z);
			Vector3 p3 = new Vector3(vector.x + num, vector.y + num2, vector.z);
			this.DrawLine(p2, vector2, color);
			this.DrawLine(vector3, p3, color);
			this.DrawLine(p2, vector3, color);
			this.DrawLine(vector2, p3, color);
			if (cross)
			{
				this.DrawLine(p2, p3, color);
				this.DrawLine(vector2, vector3, color);
			}
		}

		// Token: 0x0600870E RID: 34574 RVA: 0x0026F778 File Offset: 0x0026D978
		public GenericGraphic CreateBattleGraphic(string assetName, float scale)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateBattleGraphicStringSingle_hotfix != null)
			{
				return (GenericGraphic)this.m_CreateBattleGraphicStringSingle_hotfix.call(new object[]
				{
					this,
					assetName,
					scale
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GenericGraphic genericGraphic = this.m_graphicPool.Create(assetName);
			if (genericGraphic != null)
			{
				genericGraphic.SetContainer(this);
				genericGraphic.SetFxPlayer(this.m_battleFxPlayer);
				genericGraphic.SetParent(this.m_battleGraphicRoot);
				genericGraphic.SetPrefabScale(scale);
			}
			return genericGraphic;
		}

		// Token: 0x0600870F RID: 34575 RVA: 0x0026F840 File Offset: 0x0026DA40
		public void DestroyBattleGraphic(GenericGraphic graphic)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroyBattleGraphicGenericGraphic_hotfix != null)
			{
				this.m_DestroyBattleGraphicGenericGraphic_hotfix.call(new object[]
				{
					this,
					graphic
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_graphicPool.Destroy(graphic);
		}

		// Token: 0x06008710 RID: 34576 RVA: 0x0026F8BC File Offset: 0x0026DABC
		private CameraBase GetCurrentCamera()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCurrentCamera_hotfix != null)
			{
				return (CameraBase)this.m_GetCurrentCamera_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_state == ClientBattleState.Combat)
			{
				return this.m_combatCamera;
			}
			return this.m_battleCamera;
		}

		// Token: 0x06008711 RID: 34577 RVA: 0x0026F944 File Offset: 0x0026DB44
		public void BattleActorTryMove(BattleActor a, GridPosition p, int dir)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleActorTryMoveBattleActorGridPositionInt32_hotfix != null)
			{
				this.m_BattleActorTryMoveBattleActorGridPositionInt32_hotfix.call(new object[]
				{
					this,
					a,
					p,
					dir
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientActorActTryMove clientActorActTryMove = new ClientActorActTryMove();
			clientActorActTryMove.m_actor = a;
			clientActorActTryMove.m_step = this.m_battle.Step;
			clientActorActTryMove.m_position = p;
			clientActorActTryMove.m_direction = dir;
			clientActorActTryMove.m_sound = false;
			this.m_actorActs.Add(clientActorActTryMove);
		}

		// Token: 0x06008712 RID: 34578 RVA: 0x0026FA14 File Offset: 0x0026DC14
		public ClientBattleActor CreateActor(BattleActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateActorBattleActor_hotfix != null)
			{
				return (ClientBattleActor)this.m_CreateActorBattleActor_hotfix.call(new object[]
				{
					this,
					a
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (a == null)
			{
				return null;
			}
			ClientBattleActor clientBattleActor = new ClientBattleActor();
			clientBattleActor.Initialize(this, a);
			clientBattleActor.Locate(a.Position, a.Direction);
			this.m_actors.Add(clientBattleActor);
			return clientBattleActor;
		}

		// Token: 0x06008713 RID: 34579 RVA: 0x0026FAC8 File Offset: 0x0026DCC8
		private ClientBattleTreasure CreateTreasure(ConfigDataBattleTreasureInfo treasureInfo, bool isOpened)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateTreasureConfigDataBattleTreasureInfoBoolean_hotfix != null)
			{
				return (ClientBattleTreasure)this.m_CreateTreasureConfigDataBattleTreasureInfoBoolean_hotfix.call(new object[]
				{
					this,
					treasureInfo,
					isOpened
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (treasureInfo == null)
			{
				return null;
			}
			ClientBattleTreasure clientBattleTreasure = new ClientBattleTreasure();
			clientBattleTreasure.Initialize(this, treasureInfo);
			clientBattleTreasure.SetOpened(isOpened);
			this.m_treasures.Add(clientBattleTreasure);
			return clientBattleTreasure;
		}

		// Token: 0x06008714 RID: 34580 RVA: 0x0026FB80 File Offset: 0x0026DD80
		public ClientBattleTreasure GetTreasure(ConfigDataBattleTreasureInfo treasureInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTreasureConfigDataBattleTreasureInfo_hotfix != null)
			{
				return (ClientBattleTreasure)this.m_GetTreasureConfigDataBattleTreasureInfo_hotfix.call(new object[]
				{
					this,
					treasureInfo
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (ClientBattleTreasure clientBattleTreasure in this.m_treasures)
			{
				if (clientBattleTreasure.BattleTreasureInfo == treasureInfo)
				{
					return clientBattleTreasure;
				}
			}
			return null;
		}

		// Token: 0x06008715 RID: 34581 RVA: 0x0026FC5C File Offset: 0x0026DE5C
		public int GetNextEntityId()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetNextEntityId_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetNextEntityId_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_entityIdCounter++;
			if (this.m_entityIdCounter <= 0)
			{
				this.m_entityIdCounter = 1;
			}
			return this.m_entityIdCounter;
		}

		// Token: 0x06008716 RID: 34582 RVA: 0x0026FCF0 File Offset: 0x0026DEF0
		public void PlayScreenEffect(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayScreenEffectString_hotfix != null)
			{
				this.m_PlayScreenEffectString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_clientBattleListener.OnScreenEffect(name);
		}

		// Token: 0x06008717 RID: 34583 RVA: 0x0026FD6C File Offset: 0x0026DF6C
		private void CreateMapBackground(ConfigDataBattlefieldInfo battlefieldInfo, GameObject parent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateMapBackgroundConfigDataBattlefieldInfoGameObject_hotfix != null)
			{
				this.m_CreateMapBackgroundConfigDataBattlefieldInfoGameObject_hotfix.call(new object[]
				{
					this,
					battlefieldInfo,
					parent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ClearMapBackground();
			if (battlefieldInfo == null || parent == null)
			{
				return;
			}
			GameObject asset = AssetUtility.Instance.GetAsset<GameObject>(battlefieldInfo.BattleMap);
			if (asset != null)
			{
				this.m_mapBackground = UnityEngine.Object.Instantiate<GameObject>(asset, parent.transform, false);
				this.m_mapBackground.transform.localPosition = new Vector3(-battlefieldInfo.BackgroundOffsetX * 2f, battlefieldInfo.BackgroundOffsetY * 2f, 0f);
			}
		}

		// Token: 0x06008718 RID: 34584 RVA: 0x0026FE68 File Offset: 0x0026E068
		private void ClearMapBackground()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearMapBackground_hotfix != null)
			{
				this.m_ClearMapBackground_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_mapBackground != null)
			{
				UnityEngine.Object.Destroy(this.m_mapBackground);
				this.m_mapBackground = null;
			}
		}

		// Token: 0x06008719 RID: 34585 RVA: 0x0026FEEC File Offset: 0x0026E0EC
		private void CreateMapTerrainFx(GameObject parent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateMapTerrainFxGameObject_hotfix != null)
			{
				this.m_CreateMapTerrainFxGameObject_hotfix.call(new object[]
				{
					this,
					parent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ClearMapTerrainFx();
			BattleMap map = this.m_battle.Map;
			for (int i = 0; i < map.Height; i++)
			{
				for (int j = 0; j < map.Width; j++)
				{
					GridPosition p = new GridPosition(j, i);
					ConfigDataTerrainInfo terrain = map.GetTerrain(p);
					if (terrain != null)
					{
						this.AddMapTerrainFx(p, terrain, parent);
					}
				}
			}
		}

		// Token: 0x0600871A RID: 34586 RVA: 0x0026FFC0 File Offset: 0x0026E1C0
		private void ClearMapTerrainFx()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearMapTerrainFx_hotfix != null)
			{
				this.m_ClearMapTerrainFx_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (KeyValuePair<GridPosition, GameObject> keyValuePair in this.m_mapTerrainFxs)
			{
				UnityEngine.Object.Destroy(keyValuePair.Value);
			}
			this.m_mapTerrainFxs.Clear();
		}

		// Token: 0x0600871B RID: 34587 RVA: 0x00270080 File Offset: 0x0026E280
		private void AddMapTerrainFx(GridPosition p, ConfigDataTerrainInfo terrainInfo, GameObject parent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddMapTerrainFxGridPositionConfigDataTerrainInfoGameObject_hotfix != null)
			{
				this.m_AddMapTerrainFxGridPositionConfigDataTerrainInfoGameObject_hotfix.call(new object[]
				{
					this,
					p,
					terrainInfo,
					parent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (terrainInfo == null || string.IsNullOrEmpty(terrainInfo.Fx))
			{
				return;
			}
			GameObject asset = AssetUtility.Instance.GetAsset<GameObject>(terrainInfo.Fx);
			if (asset != null)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(asset, parent.transform, false);
				gameObject.gameObject.SetActive(false);
				gameObject.transform.localPosition = this.GridPositionToWorldPosition(p);
				gameObject.gameObject.SetActive(true);
				this.m_mapTerrainFxs[p] = gameObject;
			}
		}

		// Token: 0x0600871C RID: 34588 RVA: 0x00270190 File Offset: 0x0026E390
		public void ChangeMapTerrainFx(GridPosition p, ConfigDataTerrainInfo terrainInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ChangeMapTerrainFxGridPositionConfigDataTerrainInfo_hotfix != null)
			{
				this.m_ChangeMapTerrainFxGridPositionConfigDataTerrainInfo_hotfix.call(new object[]
				{
					this,
					p,
					terrainInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_mapTerrainFxs.ContainsKey(p))
			{
				UnityEngine.Object.Destroy(this.m_mapTerrainFxs[p]);
				this.m_mapTerrainFxs.Remove(p);
			}
			this.AddMapTerrainFx(p, terrainInfo, this.m_mapTerrainFxRoot);
		}

		// Token: 0x0600871D RID: 34589 RVA: 0x00270250 File Offset: 0x0026E450
		public void RebuildBattle(LocalProcessingBattleData data)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RebuildBattleLocalProcessingBattleData_hotfix != null)
			{
				this.m_RebuildBattleLocalProcessingBattleData_hotfix.call(new object[]
				{
					this,
					data
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			if (data.BattleCommands != null)
			{
				foreach (LocalProcessingBattleData.LocalBattleCommand localBattleCommand in data.BattleCommands)
				{
					BattleCommand battleCommand = localBattleCommand.ToBattleCommand();
					this.m_battle.AddBattleCommand(battleCommand);
					if (battleCommand.Step > num)
					{
						num = battleCommand.Step;
					}
				}
			}
			this.m_rebuildBattleStepMax = num;
			this.m_battle.EnableDebugLog(false);
			this.m_battle.FirstStep(false);
			int num2 = 0;
			while (this.IsRebuildingBattle())
			{
				this.Tick(1f);
				if (!this.m_battle.HasCurrentStepBattleCommand())
				{
					num2++;
					if (num2 > 100)
					{
						this.StopRebuildingBattle();
						this.m_battle.ClearBattleCommandsAndNextStep();
						DebugUtility.LogError("ClientBattle.RebuildBattle error, infinite loop");
						break;
					}
				}
				else
				{
					num2 = 0;
				}
			}
			this.m_battle.EnableDebugLog(true);
			foreach (ClientBattleActor clientBattleActor in this.m_actors)
			{
				clientBattleActor.PostRebuildBattle();
			}
		}

		// Token: 0x0600871E RID: 34590 RVA: 0x002703F8 File Offset: 0x0026E5F8
		public void RebuildBattle(List<BattleCommand> commands, int fromStep = 0, int toStep = 2147483647)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RebuildBattleList`1Int32Int32_hotfix != null)
			{
				this.m_RebuildBattleList`1Int32Int32_hotfix.call(new object[]
				{
					this,
					commands,
					fromStep,
					toStep
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			foreach (BattleCommand battleCommand in commands)
			{
				if (battleCommand.Step >= fromStep && battleCommand.Step <= toStep)
				{
					this.m_battle.AddBattleCommand(battleCommand);
				}
				if (battleCommand.Step > num)
				{
					num = battleCommand.Step;
				}
			}
			if (toStep == 2147483647)
			{
				this.m_rebuildBattleStepMax = num;
			}
			else
			{
				this.m_rebuildBattleStepMax = toStep;
			}
			this.m_battle.EnableDebugLog(false);
			if (fromStep <= 0)
			{
				this.m_battle.FirstStep(false);
			}
			else if (!this.m_battle.HasCurrentStepBattleCommand())
			{
				ClientBattleActor actor = this.GetActor(this.m_battle.GetActionActor());
				if (actor != null)
				{
					this.m_clientBattleListener.OnClientActorActive(actor, true, this.m_battle.Step);
				}
			}
			while (this.IsRebuildingBattle())
			{
				this.Tick(1f);
			}
			this.m_battle.EnableDebugLog(true);
			foreach (ClientBattleActor clientBattleActor in this.m_actors)
			{
				clientBattleActor.PostRebuildBattle();
			}
		}

		// Token: 0x0600871F RID: 34591 RVA: 0x002705FC File Offset: 0x0026E7FC
		public bool IsRebuildingBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsRebuildingBattle_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsRebuildingBattle_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_rebuildBattleStepMax >= 0;
		}

		// Token: 0x06008720 RID: 34592 RVA: 0x00270674 File Offset: 0x0026E874
		public void StopRebuildingBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StopRebuildingBattle_hotfix != null)
			{
				this.m_StopRebuildingBattle_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_rebuildBattleStepMax = -1;
		}

		// Token: 0x06008721 RID: 34593 RVA: 0x002706DC File Offset: 0x0026E8DC
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
			this.m_skipCombatMode = mode;
		}

		// Token: 0x06008722 RID: 34594 RVA: 0x00270754 File Offset: 0x0026E954
		public bool IsSkippingCombat(bool checkState = true)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsSkippingCombatBoolean_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsSkippingCombatBoolean_hotfix.call(new object[]
				{
					this,
					checkState
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return (!checkState || this.m_state == ClientBattleState.Combat || this.m_state == ClientBattleState.PreStartCombat) && !this.m_isBattlePerforming && (this.m_skipCombatMode == SkipCombatMode.All || (this.m_skipCombatMode == SkipCombatMode.Enemy && this.m_battle.GetActionTeam() == 1));
		}

		// Token: 0x06008723 RID: 34595 RVA: 0x00270828 File Offset: 0x0026EA28
		public int ComputeCombatArmyRelationValue(BattleActor a, BattleActor b, bool isMagic)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeCombatArmyRelationValueBattleActorBattleActorBoolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_ComputeCombatArmyRelationValueBattleActorBattleActorBoolean_hotfix.call(new object[]
				{
					this,
					a,
					b,
					isMagic
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this._ComputeCombatArmyRelationValue(a, b, isMagic);
			int num2 = this._ComputeCombatArmyRelationValue(b, a, false);
			return num - num2;
		}

		// Token: 0x06008724 RID: 34596 RVA: 0x002708DC File Offset: 0x0026EADC
		private int _ComputeCombatArmyRelationValue(BattleActor a, BattleActor b, bool isMagic)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m__ComputeCombatArmyRelationValueBattleActorBattleActorBoolean_hotfix != null)
			{
				return Convert.ToInt32(this.m__ComputeCombatArmyRelationValueBattleActorBattleActorBoolean_hotfix.call(new object[]
				{
					this,
					a,
					b,
					isMagic
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int result = 0;
			if (a.HeroArmyInfo != null)
			{
				if (b.HeroArmyInfo != null)
				{
					ArmyRelationData r = this.m_battle.ComputeArmyRelationData(a.HeroArmyInfo, b.HeroArmyInfo, a, b, true, isMagic);
					ClientBattle._ComputeArmyRelationValue(r, isMagic, ref result);
				}
				if (b.SoldierArmyInfo != null && b.SoldierTotalHealthPoint > 0)
				{
					ArmyRelationData r2 = this.m_battle.ComputeArmyRelationData(a.HeroArmyInfo, b.SoldierArmyInfo, a, b, false, isMagic);
					ClientBattle._ComputeArmyRelationValue(r2, isMagic, ref result);
				}
			}
			if (a.SoldierArmyInfo != null && a.SoldierTotalHealthPoint > 0)
			{
				if (b.HeroArmyInfo != null)
				{
					ArmyRelationData r3 = this.m_battle.ComputeArmyRelationData(a.SoldierArmyInfo, b.HeroArmyInfo, a, b, true, isMagic);
					ClientBattle._ComputeArmyRelationValue(r3, false, ref result);
				}
				if (b.SoldierArmyInfo != null && b.SoldierTotalHealthPoint > 0)
				{
					ArmyRelationData r4 = this.m_battle.ComputeArmyRelationData(a.SoldierArmyInfo, b.SoldierArmyInfo, a, b, false, isMagic);
					ClientBattle._ComputeArmyRelationValue(r4, false, ref result);
				}
			}
			return result;
		}

		// Token: 0x06008725 RID: 34597 RVA: 0x00270A78 File Offset: 0x0026EC78
		private static void _ComputeArmyRelationValue(ArmyRelationData r, bool isMagic, ref int value)
		{
			if (isMagic)
			{
				if (r.Magic > 0)
				{
					value++;
				}
				else if (r.Magic < 0)
				{
					value--;
				}
			}
			else if (r.Attack > 0)
			{
				value++;
			}
			else if (r.Attack < 0)
			{
				value--;
			}
		}

		// Token: 0x06008726 RID: 34598 RVA: 0x00270AE8 File Offset: 0x0026ECE8
		public bool IsCombatMagicAttack(BattleActor attacker, BattleActor target, ConfigDataSkillInfo attackerSkillInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsCombatMagicAttackBattleActorBattleActorConfigDataSkillInfo_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsCombatMagicAttackBattleActorBattleActorConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					attacker,
					target,
					attackerSkillInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool result = false;
			if (attackerSkillInfo != null)
			{
				result = attackerSkillInfo.IsMagic;
			}
			else
			{
				ConfigDataSkillInfo heroAttackSkillInfo = attacker.GetHeroAttackSkillInfo(target.GetMoveType(), GridPosition.Distance(attacker.Position, target.Position));
				if (heroAttackSkillInfo != null)
				{
					result = heroAttackSkillInfo.IsMagic;
				}
			}
			return result;
		}

		// Token: 0x06008727 RID: 34599 RVA: 0x00270BC4 File Offset: 0x0026EDC4
		public void EnableSdkLogBattle(bool enable)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EnableSdkLogBattleBoolean_hotfix != null)
			{
				this.m_EnableSdkLogBattleBoolean_hotfix.call(new object[]
				{
					this,
					enable
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isEnableSdkLogBattle = enable;
		}

		// Token: 0x06008728 RID: 34600 RVA: 0x00270C3C File Offset: 0x0026EE3C
		public int GetMyPlayerIndex()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetMyPlayerIndex_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetMyPlayerIndex_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_myPlayerIndex;
		}

		// Token: 0x06008729 RID: 34601 RVA: 0x00270CB0 File Offset: 0x0026EEB0
		public int GetMyPlayerTeamNumber()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetMyPlayerTeamNumber_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetMyPlayerTeamNumber_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_myPlayerTeam;
		}

		// Token: 0x0600872A RID: 34602 RVA: 0x00270D24 File Offset: 0x0026EF24
		public static int FrameToMillisecond(int frame)
		{
			return frame * 1000 / 30;
		}

		// Token: 0x0600872B RID: 34603 RVA: 0x00270D30 File Offset: 0x0026EF30
		public static int MillisecondToFrame(int ms)
		{
			return (ms * 30 + 500) / 1000;
		}

		// Token: 0x0600872C RID: 34604 RVA: 0x00270D44 File Offset: 0x0026EF44
		public static int MillisecondToFrame1(int ms)
		{
			return Math.Max((ms * 30 + 500) / 1000, 1);
		}

		// Token: 0x17001C64 RID: 7268
		// (get) Token: 0x0600872D RID: 34605 RVA: 0x00270D5C File Offset: 0x0026EF5C
		public BattleBase Battle
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Battle_hotfix != null)
				{
					return (BattleBase)this.m_get_Battle_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_battle;
			}
		}

		// Token: 0x17001C65 RID: 7269
		// (get) Token: 0x0600872E RID: 34606 RVA: 0x00270DD0 File Offset: 0x0026EFD0
		public BattleCamera BattleCamera
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_BattleCamera_hotfix != null)
				{
					return (BattleCamera)this.m_get_BattleCamera_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_battleCamera;
			}
		}

		// Token: 0x17001C66 RID: 7270
		// (get) Token: 0x0600872F RID: 34607 RVA: 0x00270E44 File Offset: 0x0026F044
		public CombatCamera CombatCamera
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_CombatCamera_hotfix != null)
				{
					return (CombatCamera)this.m_get_CombatCamera_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_combatCamera;
			}
		}

		// Token: 0x17001C67 RID: 7271
		// (get) Token: 0x06008730 RID: 34608 RVA: 0x00270EB8 File Offset: 0x0026F0B8
		public ClientBattleState State
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_State_hotfix != null)
				{
					return (ClientBattleState)this.m_get_State_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_state;
			}
		}

		// Token: 0x17001C68 RID: 7272
		// (get) Token: 0x06008732 RID: 34610 RVA: 0x00270FA4 File Offset: 0x0026F1A4
		// (set) Token: 0x06008731 RID: 34609 RVA: 0x00270F2C File Offset: 0x0026F12C
		public bool EnableDebugDraw
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_EnableDebugDraw_hotfix != null)
				{
					return Convert.ToBoolean(this.m_get_EnableDebugDraw_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_isEnableDebugDraw;
			}
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_EnableDebugDrawBoolean_hotfix != null)
				{
					this.m_set_EnableDebugDrawBoolean_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.m_isEnableDebugDraw = value;
			}
		}

		// Token: 0x17001C69 RID: 7273
		// (get) Token: 0x06008733 RID: 34611 RVA: 0x00271018 File Offset: 0x0026F218
		public bool IsAutoBattle
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_IsAutoBattle_hotfix != null)
				{
					return Convert.ToBoolean(this.m_get_IsAutoBattle_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_isAutoBattle;
			}
		}

		// Token: 0x17001C6A RID: 7274
		// (get) Token: 0x06008734 RID: 34612 RVA: 0x0027108C File Offset: 0x0026F28C
		public bool IsFastBattle
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_IsFastBattle_hotfix != null)
				{
					return Convert.ToBoolean(this.m_get_IsFastBattle_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_isFastBattle;
			}
		}

		// Token: 0x17001C6B RID: 7275
		// (get) Token: 0x06008735 RID: 34613 RVA: 0x00271100 File Offset: 0x0026F300
		public SkipCombatMode SkipCombatMode
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_SkipCombatMode_hotfix != null)
				{
					return (SkipCombatMode)this.m_get_SkipCombatMode_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_skipCombatMode;
			}
		}

		// Token: 0x17001C6C RID: 7276
		// (get) Token: 0x06008736 RID: 34614 RVA: 0x00271174 File Offset: 0x0026F374
		public bool IsPaused
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_IsPaused_hotfix != null)
				{
					return Convert.ToBoolean(this.m_get_IsPaused_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_isPaused;
			}
		}

		// Token: 0x17001C6D RID: 7277
		// (get) Token: 0x06008737 RID: 34615 RVA: 0x002711E8 File Offset: 0x0026F3E8
		public GameObject BattleGraphicRoot
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_BattleGraphicRoot_hotfix != null)
				{
					return (GameObject)this.m_get_BattleGraphicRoot_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_battleGraphicRoot;
			}
		}

		// Token: 0x17001C6E RID: 7278
		// (get) Token: 0x06008738 RID: 34616 RVA: 0x0027125C File Offset: 0x0026F45C
		public GameObject CombatGraphicRoot
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_CombatGraphicRoot_hotfix != null)
				{
					return (GameObject)this.m_get_CombatGraphicRoot_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_combatGraphicRoot;
			}
		}

		// Token: 0x17001C6F RID: 7279
		// (get) Token: 0x06008739 RID: 34617 RVA: 0x002712D0 File Offset: 0x0026F4D0
		public GameObject MapTreasureRoot
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_MapTreasureRoot_hotfix != null)
				{
					return (GameObject)this.m_get_MapTreasureRoot_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_mapTreasureRoot;
			}
		}

		// Token: 0x17001C70 RID: 7280
		// (get) Token: 0x0600873A RID: 34618 RVA: 0x00271344 File Offset: 0x0026F544
		public GameObject BattleActorUIRoot
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_BattleActorUIRoot_hotfix != null)
				{
					return (GameObject)this.m_get_BattleActorUIRoot_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_battleActorUIRoot;
			}
		}

		// Token: 0x17001C71 RID: 7281
		// (get) Token: 0x0600873B RID: 34619 RVA: 0x002713B8 File Offset: 0x0026F5B8
		public GameObject BattleActorUIPrefab
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_BattleActorUIPrefab_hotfix != null)
				{
					return (GameObject)this.m_get_BattleActorUIPrefab_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_battleActorUIPrefab;
			}
		}

		// Token: 0x17001C72 RID: 7282
		// (get) Token: 0x0600873C RID: 34620 RVA: 0x0027142C File Offset: 0x0026F62C
		public FxPlayer BattleFxPlayer
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_BattleFxPlayer_hotfix != null)
				{
					return (FxPlayer)this.m_get_BattleFxPlayer_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_battleFxPlayer;
			}
		}

		// Token: 0x17001C73 RID: 7283
		// (get) Token: 0x0600873D RID: 34621 RVA: 0x002714A0 File Offset: 0x0026F6A0
		public FxPlayer CombatFxPlayer
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_CombatFxPlayer_hotfix != null)
				{
					return (FxPlayer)this.m_get_CombatFxPlayer_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_combatFxPlayer;
			}
		}

		// Token: 0x17001C74 RID: 7284
		// (get) Token: 0x0600873E RID: 34622 RVA: 0x00271514 File Offset: 0x0026F714
		public IConfigDataLoader ConfigDataLoader
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_ConfigDataLoader_hotfix != null)
				{
					return (IConfigDataLoader)this.m_get_ConfigDataLoader_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_configDataLoader;
			}
		}

		// Token: 0x17001C75 RID: 7285
		// (get) Token: 0x0600873F RID: 34623 RVA: 0x00271588 File Offset: 0x0026F788
		public IClientBattleListener ClientBattleListener
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_ClientBattleListener_hotfix != null)
				{
					return (IClientBattleListener)this.m_get_ClientBattleListener_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_clientBattleListener;
			}
		}

		// Token: 0x17001C76 RID: 7286
		// (get) Token: 0x06008740 RID: 34624 RVA: 0x002715FC File Offset: 0x0026F7FC
		public RandomNumber RandomNumber
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_RandomNumber_hotfix != null)
				{
					return (RandomNumber)this.m_get_RandomNumber_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_randomNumber;
			}
		}

		// Token: 0x06008741 RID: 34625 RVA: 0x00271670 File Offset: 0x0026F870
		private void AppendActToActor()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AppendActToActor_hotfix != null)
			{
				this.m_AppendActToActor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actorActs.Count <= 0)
			{
				return;
			}
			ClientActorAct clientActorAct = this.m_actorActs[0];
			this.m_actorActs.RemoveAt(0);
			ClientBattleActor clientBattleActor;
			if (clientActorAct.m_actor == null)
			{
				clientBattleActor = this.m_nullActor;
			}
			else
			{
				clientBattleActor = this.GetActor(clientActorAct.m_actor);
			}
			if (clientBattleActor == null)
			{
				global::Debug.LogWarning("ClientBattle.AppendActToActor error, wrong actor");
				return;
			}
			clientBattleActor.AddAct(clientActorAct);
			Type type = clientActorAct.GetType();
			if (type == typeof(ClientActorActMove))
			{
				((ClientActorActMove)clientActorAct).m_sound = true;
				this.AppendActsToActor(clientActorAct.m_step, type, clientBattleActor);
			}
			else if (type == typeof(ClientActorActTryMove))
			{
				((ClientActorActTryMove)clientActorAct).m_sound = true;
				this.AppendActsToActor(clientActorAct.m_step, type, clientBattleActor);
			}
			else if (type == typeof(ClientActorActPerformMove))
			{
				((ClientActorActPerformMove)clientActorAct).m_sound = true;
				this.AppendActsToActor(clientActorAct.m_step, type, clientBattleActor);
			}
			else if (type == typeof(ClientActorActSkill))
			{
				int i = 0;
				while (i < this.m_actorActs.Count)
				{
					ClientActorAct clientActorAct2 = this.m_actorActs[i];
					if (clientActorAct2.m_step != clientActorAct.m_step)
					{
						break;
					}
					Type type2 = clientActorAct2.GetType();
					if (type2 != typeof(ClientActorActSkillHit) && type2 != typeof(ClientActorActDie) && type2 != typeof(ClientActorActTeleportDisappear) && type2 != typeof(ClientActorActTeleportAppear) && type2 != typeof(ClientActorActSummon) && type2 != typeof(ClientActorActAttachBuff) && type2 != typeof(ClientActorActDetachBuff))
					{
						break;
					}
					this.m_actorActs.RemoveAt(i);
					if (type2 == typeof(ClientActorActSkillHit) && clientActorAct2.m_actor == clientBattleActor.BattleActor)
					{
						((ClientActorActSkill)clientActorAct).m_hits = ((ClientActorActSkillHit)clientActorAct2).m_hits;
					}
					else if (type2 != typeof(ClientActorActTeleportDisappear) || clientActorAct2.m_actor != clientBattleActor.BattleActor)
					{
						ClientBattleActor actor = this.GetActor(clientActorAct2.m_actor);
						if (actor != null)
						{
							actor.AddAct(clientActorAct2);
						}
					}
				}
			}
			else if (type == typeof(ClientActorActPassiveSkill))
			{
				int j = 0;
				while (j < this.m_actorActs.Count)
				{
					ClientActorAct clientActorAct3 = this.m_actorActs[j];
					if (clientActorAct3.m_step != clientActorAct.m_step)
					{
						break;
					}
					Type type3 = clientActorAct3.GetType();
					if (type3 != typeof(ClientActorActPassiveSkillHit) && type3 != typeof(ClientActorActDie) && type3 != typeof(ClientActorActAttachBuff) && type3 != typeof(ClientActorActDetachBuff) && type3 != typeof(ClientActorActPunchMove))
					{
						break;
					}
					this.m_actorActs.RemoveAt(j);
					ClientBattleActor actor2 = this.GetActor(clientActorAct3.m_actor);
					if (actor2 != null)
					{
						actor2.AddAct(clientActorAct3);
					}
				}
			}
			else if (type == typeof(ClientActorActBuffHit))
			{
				while (this.m_actorActs.Count > 0)
				{
					ClientActorAct clientActorAct4 = this.m_actorActs[0];
					if (clientActorAct4.m_step != clientActorAct.m_step)
					{
						break;
					}
					Type type4 = clientActorAct4.GetType();
					if (type4 != typeof(ClientActorActBuffHit) && type4 != typeof(ClientActorActDie) && type4 != typeof(ClientActorActAttachBuff) && type4 != typeof(ClientActorActDetachBuff))
					{
						break;
					}
					this.m_actorActs.RemoveAt(0);
					ClientBattleActor actor3 = this.GetActor(clientActorAct4.m_actor);
					if (actor3 != null)
					{
						actor3.AddAct(clientActorAct4);
					}
				}
			}
			else if (type == typeof(ClientActorActAttachBuff) || type == typeof(ClientActorActDetachBuff))
			{
				while (this.m_actorActs.Count > 0)
				{
					ClientActorAct clientActorAct5 = this.m_actorActs[0];
					if (clientActorAct5.m_step != clientActorAct.m_step)
					{
						break;
					}
					Type type5 = clientActorAct5.GetType();
					if (type5 != typeof(ClientActorActAttachBuff) && type5 != typeof(ClientActorActDetachBuff))
					{
						break;
					}
					this.m_actorActs.RemoveAt(0);
					ClientBattleActor actor4 = this.GetActor(clientActorAct5.m_actor);
					if (actor4 != null)
					{
						actor4.AddAct(clientActorAct5);
					}
				}
			}
			else if (type == typeof(ClientActorActTerrainHit))
			{
				this.AppendActsToActor(clientActorAct.m_step, type);
			}
			else if (type == typeof(ClientActorActPunchMove))
			{
				this.AppendActsToActor(clientActorAct.m_step, type);
			}
			else if (type == typeof(ClientActorActExchangeMove))
			{
				this.AppendActsToActor(clientActorAct.m_step, type);
			}
			else if (type == typeof(ClientActorActDie))
			{
				this.AppendActsToActor(clientActorAct.m_step, type);
			}
			else if (type == typeof(ClientActorActChangeTeam))
			{
				this.AppendActsToActor(clientActorAct.m_step, type);
			}
			else if (type == typeof(ClientActorActAppear))
			{
				this.AppendActsToActor(clientActorAct.m_step, type);
			}
			else if (type == typeof(ClientActorActPlayFx))
			{
				this.AppendActsToActor(clientActorAct.m_step, type, clientBattleActor);
			}
			else if (type == typeof(ClientActorActBeforeStartCombat))
			{
				this.AppendActsToActor(clientActorAct.m_step, type);
			}
			else if (type == typeof(ClientActorActStartCombat))
			{
				this.AppendActsToActor(clientActorAct.m_step, type);
			}
			else if (type == typeof(ClientActorActStopCombat))
			{
				int k = 0;
				while (k < this.m_actorActs.Count)
				{
					ClientActorAct clientActorAct6 = this.m_actorActs[k];
					if (clientActorAct6.m_step != clientActorAct.m_step)
					{
						break;
					}
					Type type6 = clientActorAct6.GetType();
					if (type6 != typeof(ClientActorActStopCombat) && type6 != typeof(ClientActorActDie) && type6 != typeof(ClientActorActAttachBuff) && type6 != typeof(ClientActorActDetachBuff))
					{
						break;
					}
					this.m_actorActs.RemoveAt(k);
					ClientBattleActor actor5 = this.GetActor(clientActorAct6.m_actor);
					if (actor5 != null)
					{
						actor5.AddAct(clientActorAct6);
					}
				}
			}
			else if (type == typeof(ClientNullActorActChangeMapTerrain))
			{
				this.AppendActsToActor(clientActorAct.m_step, type, clientBattleActor);
			}
		}

		// Token: 0x06008742 RID: 34626 RVA: 0x00271DE0 File Offset: 0x0026FFE0
		private void AppendActsToActor(int step, Type type)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AppendActsToActorInt32Type_hotfix != null)
			{
				this.m_AppendActsToActorInt32Type_hotfix.call(new object[]
				{
					this,
					step,
					type
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			while (this.m_actorActs.Count > 0)
			{
				ClientActorAct clientActorAct = this.m_actorActs[0];
				if (clientActorAct.m_step != step)
				{
					break;
				}
				if (clientActorAct.GetType() != type)
				{
					break;
				}
				this.m_actorActs.RemoveAt(0);
				ClientBattleActor actor = this.GetActor(clientActorAct.m_actor);
				if (actor != null)
				{
					actor.AddAct(clientActorAct);
				}
			}
		}

		// Token: 0x06008743 RID: 34627 RVA: 0x00271ED0 File Offset: 0x002700D0
		private void AppendActsToActor(int step, Type type, ClientBattleActor ca)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AppendActsToActorInt32TypeClientBattleActor_hotfix != null)
			{
				this.m_AppendActsToActorInt32TypeClientBattleActor_hotfix.call(new object[]
				{
					this,
					step,
					type,
					ca
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			while (this.m_actorActs.Count > 0)
			{
				ClientActorAct clientActorAct = this.m_actorActs[0];
				if (clientActorAct.m_step != step)
				{
					break;
				}
				bool flag = clientActorAct.m_actor == ca.BattleActor || (clientActorAct.m_actor == null && ca == this.m_nullActor);
				if (!flag || clientActorAct.GetType() != type)
				{
					break;
				}
				this.m_actorActs.RemoveAt(0);
				ca.AddAct(clientActorAct);
			}
		}

		// Token: 0x06008744 RID: 34628 RVA: 0x00271FF0 File Offset: 0x002701F0
		public bool IsAnyActorHasAct()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsAnyActorHasAct_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsAnyActorHasAct_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_nullActor != null && this.m_nullActor.HasAct())
			{
				return true;
			}
			foreach (ClientBattleActor clientBattleActor in this.m_actors)
			{
				if (clientBattleActor.HasAct())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06008745 RID: 34629 RVA: 0x002720D8 File Offset: 0x002702D8
		public bool HasWaitingAct(BattleActor a, int step)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasWaitingActBattleActorInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasWaitingActBattleActorInt32_hotfix.call(new object[]
				{
					this,
					a,
					step
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (a == null)
			{
				return false;
			}
			foreach (ClientActorAct clientActorAct in this.m_actorActs)
			{
				if (clientActorAct.m_actor == a && clientActorAct.m_step == step)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06008746 RID: 34630 RVA: 0x002721D8 File Offset: 0x002703D8
		public void OnActorActive(ClientBattleActor a, bool newStep, int step)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnActorActiveClientBattleActorBooleanInt32_hotfix != null)
			{
				this.m_OnActorActiveClientBattleActorBooleanInt32_hotfix.call(new object[]
				{
					this,
					a,
					newStep,
					step
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsRebuildingBattle() && newStep)
			{
				if (step > this.m_rebuildBattleStepMax)
				{
					this.StopRebuildingBattle();
				}
				else if (a.BattleActor.IsPlayerActor() && !this.m_battle.HasCurrentStepBattleCommand())
				{
					this.StopRebuildingBattle();
					this.m_battle.ClearBattleCommandsAndNextStep();
					global::Debug.LogError("ClientBattle.OnActorActive error, IsRebuildingBattle do not HasCurrentStepBattleCommand");
				}
			}
			if (this.m_activeActor != null)
			{
				this.m_activeActor.StopIdleRun();
			}
			this.m_activeActor = a;
			this.m_clientBattleListener.OnClientActorActive(a, newStep, step);
		}

		// Token: 0x06008747 RID: 34631 RVA: 0x002722F8 File Offset: 0x002704F8
		public void OnActorPreStartCombat(ClientBattleActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnActorPreStartCombatClientBattleActor_hotfix != null)
			{
				this.m_OnActorPreStartCombatClientBattleActor_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (a.BattleActor != this.m_combatingBattleActorA)
			{
				return;
			}
			if (this.IsRebuildingBattle() || this.IsSkippingCombat(false))
			{
				this.m_state = ClientBattleState.Combat;
				if (this.IsSkippingCombat(false))
				{
					this.m_clientBattleListener.OnPrepareFastCombat(this.GetActor(this.m_combatingBattleActorA), this.GetActor(this.m_combatingBattleActorB), this.m_combatSkillInfoA);
				}
			}
			else
			{
				this.m_state = ClientBattleState.PreStartCombat;
				this.m_clientBattleListener.OnPreStartCombat(this.GetActor(this.m_combatingBattleActorA), this.GetActor(this.m_combatingBattleActorB));
				this.m_battleCamera.EnableTouchMove(false);
			}
		}

		// Token: 0x06008748 RID: 34632 RVA: 0x00272408 File Offset: 0x00270608
		public void OnActorStopCombatEnd(ClientBattleActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnActorStopCombatEndClientBattleActor_hotfix != null)
			{
				this.m_OnActorStopCombatEndClientBattleActor_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleCamera.EnableTouchMove(true);
		}

		// Token: 0x06008749 RID: 34633 RVA: 0x00272484 File Offset: 0x00270684
		public void OnActorCastSkill(ClientBattleActor a, ConfigDataSkillInfo skillInfo, GridPosition targetPos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnActorCastSkillClientBattleActorConfigDataSkillInfoGridPosition_hotfix != null)
			{
				this.m_OnActorCastSkillClientBattleActorConfigDataSkillInfoGridPosition_hotfix.call(new object[]
				{
					this,
					a,
					skillInfo,
					targetPos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (a == null || skillInfo == null)
			{
				return;
			}
			if (this.IsRebuildingBattle())
			{
				return;
			}
			if (skillInfo.CutsceneType != 0)
			{
				ConfigDataCutsceneInfo configDataCutsceneInfo = null;
				if (skillInfo.CutsceneType == 1)
				{
					ConfigDataHeroInfo heroInfo = a.BattleActor.HeroInfo;
					if (heroInfo != null)
					{
						ConfigDataCharImageInfo charImageInfo = heroInfo.GetCharImageInfo(a.BattleActor.HeroStar);
						if (charImageInfo != null)
						{
							configDataCutsceneInfo = charImageInfo.m_skillCutsceneInfo;
						}
					}
				}
				this.Pause(true);
				this.FadeNonSkillTargets(a, skillInfo, targetPos);
				if (configDataCutsceneInfo != null)
				{
					this.m_cutscenePauseCountdown = ClientBattle.MillisecondToFrame1(configDataCutsceneInfo.Time);
					this.OnStartSkillCutscene(skillInfo, configDataCutsceneInfo, a.TeamNumber);
				}
				else
				{
					this.m_cutscenePauseCountdown = ClientBattle.MillisecondToFrame1(this.ConfigDataLoader.Const_SkillPauseTime);
					this.m_battle.Listener.OnStartSkillCutscene(skillInfo, configDataCutsceneInfo, a.TeamNumber);
				}
			}
			this.m_clientBattleListener.OnClientActorSkill(a, skillInfo);
		}

		// Token: 0x0600874A RID: 34634 RVA: 0x002725EC File Offset: 0x002707EC
		public void OnActorCastSkillEnd(ClientBattleActor a, ConfigDataSkillInfo skillInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnActorCastSkillEndClientBattleActorConfigDataSkillInfo_hotfix != null)
			{
				this.m_OnActorCastSkillEndClientBattleActorConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					a,
					skillInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsRebuildingBattle())
			{
				return;
			}
			this.m_restoreNonSkillTargetsCountdown = ClientBattle.MillisecondToFrame1(300);
			this.m_clientBattleListener.OnClientActorSkillEnd(a, skillInfo);
		}

		// Token: 0x0600874B RID: 34635 RVA: 0x00272698 File Offset: 0x00270898
		public void OnBattleActorCreate(BattleActor a, bool visible)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorCreateBattleActorBoolean_hotfix != null)
			{
				this.m_OnBattleActorCreateBattleActorBoolean_hotfix.call(new object[]
				{
					this,
					a,
					visible
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientBattleActor clientBattleActor = this.CreateActor(a);
			if (clientBattleActor != null)
			{
				clientBattleActor.SetVisible(visible);
			}
		}

		// Token: 0x0600874C RID: 34636 RVA: 0x00272730 File Offset: 0x00270930
		public void OnBattleActorCreateEnd(BattleActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorCreateEndBattleActor_hotfix != null)
			{
				this.m_OnBattleActorCreateEndBattleActor_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientBattleActor actor = this.GetActor(a);
			if (actor != null)
			{
				actor.InitializeEnd();
			}
		}

		// Token: 0x0600874D RID: 34637 RVA: 0x002727B4 File Offset: 0x002709B4
		public void OnBattleActorActive(BattleActor a, bool newStep)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorActiveBattleActorBoolean_hotfix != null)
			{
				this.m_OnBattleActorActiveBattleActorBoolean_hotfix.call(new object[]
				{
					this,
					a,
					newStep
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!a.IsAINpc() && a.TeamNumber == this.m_ignoreActiveTeam && this.m_battle.Turn == this.m_ignoreActiveTurn)
			{
				return;
			}
			if (newStep && a.TeamNumber == 0 && !a.IsAINpc())
			{
				foreach (int num in this.m_enforceActionOrderHeroIds)
				{
					BattleActor actorByHeroId = this.m_battle.GetTeam(0).GetActorByHeroId(num, true);
					if (actorByHeroId != null)
					{
						if (actorByHeroId.CanAction())
						{
							if (num == a.HeroId)
							{
								break;
							}
							int ignoreActiveTeam = this.m_ignoreActiveTeam;
							int ignoreActiveTurn = this.m_ignoreActiveTurn;
							this.m_ignoreActiveTeam = a.TeamNumber;
							this.m_ignoreActiveTurn = this.m_battle.Turn;
							if (this.m_battle.ChangeActionActor(actorByHeroId))
							{
								a = actorByHeroId;
							}
							this.m_ignoreActiveTeam = ignoreActiveTeam;
							this.m_ignoreActiveTurn = ignoreActiveTurn;
							break;
						}
					}
				}
			}
			ClientActorActActive clientActorActActive = new ClientActorActActive();
			clientActorActActive.m_actor = a;
			clientActorActActive.m_step = this.m_battle.Step;
			clientActorActActive.m_newStep = newStep;
			this.m_actorActs.Add(clientActorActActive);
		}

		// Token: 0x0600874E RID: 34638 RVA: 0x00272998 File Offset: 0x00270B98
		public void OnBattleActorActionBegin(BattleActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorActionBeginBattleActor_hotfix != null)
			{
				this.m_OnBattleActorActionBeginBattleActor_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientActorActActionBegin clientActorActActionBegin = new ClientActorActActionBegin();
			clientActorActActionBegin.m_actor = a;
			clientActorActActionBegin.m_step = this.m_battle.Step;
			this.m_actorActs.Add(clientActorActActionBegin);
		}

		// Token: 0x0600874F RID: 34639 RVA: 0x00272A34 File Offset: 0x00270C34
		public void OnBattleActorActionEnd(BattleActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorActionEndBattleActor_hotfix != null)
			{
				this.m_OnBattleActorActionEndBattleActor_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientActorActActionEnd clientActorActActionEnd = new ClientActorActActionEnd();
			clientActorActActionEnd.m_actor = a;
			clientActorActActionEnd.m_step = this.m_battle.Step;
			this.m_actorActs.Add(clientActorActActionEnd);
		}

		// Token: 0x06008750 RID: 34640 RVA: 0x00272AD0 File Offset: 0x00270CD0
		public void OnBattleActorMove(BattleActor a, GridPosition p, int dir)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorMoveBattleActorGridPositionInt32_hotfix != null)
			{
				this.m_OnBattleActorMoveBattleActorGridPositionInt32_hotfix.call(new object[]
				{
					this,
					a,
					p,
					dir
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_ignoreMoveStep == this.m_battle.Step)
			{
				return;
			}
			ClientActorActMove clientActorActMove = new ClientActorActMove();
			clientActorActMove.m_actor = a;
			clientActorActMove.m_step = this.m_battle.Step;
			clientActorActMove.m_position = p;
			clientActorActMove.m_direction = dir;
			clientActorActMove.m_sound = false;
			this.m_actorActs.Add(clientActorActMove);
		}

		// Token: 0x06008751 RID: 34641 RVA: 0x00272BB8 File Offset: 0x00270DB8
		public void OnBattleActorPerformMove(BattleActor a, GridPosition p, int dir, bool cameraFollow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorPerformMoveBattleActorGridPositionInt32Boolean_hotfix != null)
			{
				this.m_OnBattleActorPerformMoveBattleActorGridPositionInt32Boolean_hotfix.call(new object[]
				{
					this,
					a,
					p,
					dir,
					cameraFollow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_ignoreMoveStep == this.m_battle.Step)
			{
				return;
			}
			ClientActorActPerformMove clientActorActPerformMove = new ClientActorActPerformMove();
			clientActorActPerformMove.m_actor = a;
			clientActorActPerformMove.m_step = this.m_battle.Step;
			clientActorActPerformMove.m_position = p;
			clientActorActPerformMove.m_direction = dir;
			clientActorActPerformMove.m_sound = false;
			clientActorActPerformMove.m_cameraFollow = cameraFollow;
			this.m_actorActs.Add(clientActorActPerformMove);
		}

		// Token: 0x06008752 RID: 34642 RVA: 0x00272CB8 File Offset: 0x00270EB8
		public void OnBattleActorPunchMove(BattleActor a, string fxName, bool isDragExchange)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorPunchMoveBattleActorStringBoolean_hotfix != null)
			{
				this.m_OnBattleActorPunchMoveBattleActorStringBoolean_hotfix.call(new object[]
				{
					this,
					a,
					fxName,
					isDragExchange
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientActorActPunchMove clientActorActPunchMove = new ClientActorActPunchMove();
			clientActorActPunchMove.m_actor = a;
			clientActorActPunchMove.m_step = this.m_battle.Step;
			clientActorActPunchMove.m_position = a.Position;
			clientActorActPunchMove.m_direction = a.Direction;
			clientActorActPunchMove.m_fxName = fxName;
			clientActorActPunchMove.m_isDragExchange = isDragExchange;
			this.m_actorActs.Add(clientActorActPunchMove);
		}

		// Token: 0x06008753 RID: 34643 RVA: 0x00272D98 File Offset: 0x00270F98
		public void OnBattleActorExchangeMove(BattleActor a, BattleActor b, int moveType, string fxName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorExchangeMoveBattleActorBattleActorInt32String_hotfix != null)
			{
				this.m_OnBattleActorExchangeMoveBattleActorBattleActorInt32String_hotfix.call(new object[]
				{
					this,
					a,
					b,
					moveType,
					fxName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientActorActExchangeMove clientActorActExchangeMove = new ClientActorActExchangeMove();
			clientActorActExchangeMove.m_actor = a;
			clientActorActExchangeMove.m_step = this.m_battle.Step;
			clientActorActExchangeMove.m_position = a.Position;
			clientActorActExchangeMove.m_direction = a.Direction;
			clientActorActExchangeMove.m_fxName = fxName;
			clientActorActExchangeMove.m_moveType = moveType;
			this.m_actorActs.Add(clientActorActExchangeMove);
			ClientActorActExchangeMove clientActorActExchangeMove2 = new ClientActorActExchangeMove();
			clientActorActExchangeMove2.m_actor = b;
			clientActorActExchangeMove2.m_step = this.m_battle.Step;
			clientActorActExchangeMove2.m_position = b.Position;
			clientActorActExchangeMove2.m_direction = b.Direction;
			clientActorActExchangeMove2.m_fxName = fxName;
			clientActorActExchangeMove2.m_moveType = moveType;
			this.m_actorActs.Add(clientActorActExchangeMove2);
		}

		// Token: 0x06008754 RID: 34644 RVA: 0x00272EDC File Offset: 0x002710DC
		public void OnBattleActorSetDir(BattleActor a, int dir)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorSetDirBattleActorInt32_hotfix != null)
			{
				this.m_OnBattleActorSetDirBattleActorInt32_hotfix.call(new object[]
				{
					this,
					a,
					dir
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientActorActSetDir clientActorActSetDir = new ClientActorActSetDir();
			clientActorActSetDir.m_actor = a;
			clientActorActSetDir.m_step = this.m_battle.Step;
			clientActorActSetDir.m_direction = dir;
			this.m_actorActs.Add(clientActorActSetDir);
		}

		// Token: 0x06008755 RID: 34645 RVA: 0x00272F90 File Offset: 0x00271190
		public void OnBattleActorPlayFx(BattleActor a, string fxName, int attachMode)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorPlayFxBattleActorStringInt32_hotfix != null)
			{
				this.m_OnBattleActorPlayFxBattleActorStringInt32_hotfix.call(new object[]
				{
					this,
					a,
					fxName,
					attachMode
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientActorActPlayFx clientActorActPlayFx = new ClientActorActPlayFx();
			clientActorActPlayFx.m_actor = a;
			clientActorActPlayFx.m_step = this.m_battle.Step;
			clientActorActPlayFx.m_fxName = fxName;
			clientActorActPlayFx.m_attachMode = attachMode;
			this.m_actorActs.Add(clientActorActPlayFx);
		}

		// Token: 0x06008756 RID: 34646 RVA: 0x00273058 File Offset: 0x00271258
		public void OnBattleActorPlayAnimation(BattleActor a, string animationName, int animationTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorPlayAnimationBattleActorStringInt32_hotfix != null)
			{
				this.m_OnBattleActorPlayAnimationBattleActorStringInt32_hotfix.call(new object[]
				{
					this,
					a,
					animationName,
					animationTime
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientActorActPlayAnimation clientActorActPlayAnimation = new ClientActorActPlayAnimation();
			clientActorActPlayAnimation.m_actor = a;
			clientActorActPlayAnimation.m_step = this.m_battle.Step;
			clientActorActPlayAnimation.m_animationName = animationName;
			clientActorActPlayAnimation.m_animationTime = animationTime;
			this.m_actorActs.Add(clientActorActPlayAnimation);
		}

		// Token: 0x06008757 RID: 34647 RVA: 0x00273120 File Offset: 0x00271320
		public void OnBattleActorChangeIdleAnimation(BattleActor a, string idleAnimationName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorChangeIdleAnimationBattleActorString_hotfix != null)
			{
				this.m_OnBattleActorChangeIdleAnimationBattleActorString_hotfix.call(new object[]
				{
					this,
					a,
					idleAnimationName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientActorActChangeIdleAnimation clientActorActChangeIdleAnimation = new ClientActorActChangeIdleAnimation();
			clientActorActChangeIdleAnimation.m_actor = a;
			clientActorActChangeIdleAnimation.m_step = this.m_battle.Step;
			clientActorActChangeIdleAnimation.m_idleAnimationName = idleAnimationName;
			this.m_actorActs.Add(clientActorActChangeIdleAnimation);
		}

		// Token: 0x06008758 RID: 34648 RVA: 0x002731D4 File Offset: 0x002713D4
		public void OnBattleActorSkill(BattleActor a, ConfigDataSkillInfo skill, GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorSkillBattleActorConfigDataSkillInfoGridPosition_hotfix != null)
			{
				this.m_OnBattleActorSkillBattleActorConfigDataSkillInfoGridPosition_hotfix.call(new object[]
				{
					this,
					a,
					skill,
					p
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_ignoreSkillStep == this.m_battle.Step)
			{
				return;
			}
			if (this.IsNeedTargetIcon(a))
			{
				ClientActorActTarget clientActorActTarget = new ClientActorActTarget();
				clientActorActTarget.m_actor = a;
				clientActorActTarget.m_step = this.m_battle.Step;
				clientActorActTarget.m_skillInfo = skill;
				clientActorActTarget.m_targetPosition = p;
				clientActorActTarget.m_armyRelationValue = 0;
				this.m_actorActs.Add(clientActorActTarget);
			}
			ClientActorActSkill clientActorActSkill = new ClientActorActSkill();
			clientActorActSkill.m_actor = a;
			clientActorActSkill.m_step = this.m_battle.Step;
			clientActorActSkill.m_skillInfo = skill;
			clientActorActSkill.m_targetPosition = p;
			clientActorActSkill.m_hits = null;
			this.m_actorActs.Add(clientActorActSkill);
		}

		// Token: 0x06008759 RID: 34649 RVA: 0x00273308 File Offset: 0x00271508
		public void OnBattleActorSkillHitBegin(BattleActor a, ConfigDataSkillInfo skillInfo, bool isRebound)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorSkillHitBeginBattleActorConfigDataSkillInfoBoolean_hotfix != null)
			{
				this.m_OnBattleActorSkillHitBeginBattleActorConfigDataSkillInfoBoolean_hotfix.call(new object[]
				{
					this,
					a,
					skillInfo,
					isRebound
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientActorActSkillHit clientActorActSkillHit = new ClientActorActSkillHit();
			if (isRebound)
			{
				this.m_actorActSkillRebound = clientActorActSkillHit;
			}
			else
			{
				this.m_actorActSkillHit = clientActorActSkillHit;
			}
			clientActorActSkillHit.m_actor = a;
			clientActorActSkillHit.m_step = this.m_battle.Step;
			clientActorActSkillHit.m_skillInfo = skillInfo;
			clientActorActSkillHit.m_direction = a.Direction;
			clientActorActSkillHit.m_hits = new List<ClientActorHitInfo>();
		}

		// Token: 0x0600875A RID: 34650 RVA: 0x002733F0 File Offset: 0x002715F0
		public void OnBattleActorSkillHit(BattleActor a, ConfigDataSkillInfo skill, int heroHpModify, int soldierHpModify, DamageNumberType damageNumberType, bool isRebound)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorSkillHitBattleActorConfigDataSkillInfoInt32Int32DamageNumberTypeBoolean_hotfix != null)
			{
				this.m_OnBattleActorSkillHitBattleActorConfigDataSkillInfoInt32Int32DamageNumberTypeBoolean_hotfix.call(new object[]
				{
					this,
					a,
					skill,
					heroHpModify,
					soldierHpModify,
					damageNumberType,
					isRebound
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientActorActSkillHit clientActorActSkillHit;
			if (isRebound)
			{
				clientActorActSkillHit = this.m_actorActSkillRebound;
			}
			else
			{
				clientActorActSkillHit = this.m_actorActSkillHit;
			}
			if (clientActorActSkillHit == null)
			{
				return;
			}
			ClientActorHitInfo clientActorHitInfo = new ClientActorHitInfo();
			clientActorHitInfo.m_heroHp = a.HeroHealthPoint;
			clientActorHitInfo.m_soldierHp = a.SoldierTotalHealthPoint;
			clientActorHitInfo.m_heroHpModify = heroHpModify;
			clientActorHitInfo.m_soldierHpModify = soldierHpModify;
			clientActorHitInfo.m_damageNumberType = damageNumberType;
			clientActorActSkillHit.m_hits.Add(clientActorHitInfo);
		}

		// Token: 0x0600875B RID: 34651 RVA: 0x00273514 File Offset: 0x00271714
		public void OnBattleActorSkillHitEnd(BattleActor a, ConfigDataSkillInfo skillInfo, bool isRebound)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorSkillHitEndBattleActorConfigDataSkillInfoBoolean_hotfix != null)
			{
				this.m_OnBattleActorSkillHitEndBattleActorConfigDataSkillInfoBoolean_hotfix.call(new object[]
				{
					this,
					a,
					skillInfo,
					isRebound
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientActorActSkillHit clientActorActSkillHit;
			if (isRebound)
			{
				clientActorActSkillHit = this.m_actorActSkillRebound;
				this.m_actorActSkillRebound = null;
			}
			else
			{
				clientActorActSkillHit = this.m_actorActSkillHit;
				this.m_actorActSkillHit = null;
			}
			if (clientActorActSkillHit == null)
			{
				return;
			}
			this.m_actorActs.Add(clientActorActSkillHit);
		}

		// Token: 0x0600875C RID: 34652 RVA: 0x002735E0 File Offset: 0x002717E0
		public void OnBattleActorAttachBuff(BattleActor a, BuffState buffState)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorAttachBuffBattleActorBuffState_hotfix != null)
			{
				this.m_OnBattleActorAttachBuffBattleActorBuffState_hotfix.call(new object[]
				{
					this,
					a,
					buffState
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientActorActAttachBuff clientActorActAttachBuff = new ClientActorActAttachBuff();
			clientActorActAttachBuff.m_actor = a;
			clientActorActAttachBuff.m_step = this.m_battle.Step;
			clientActorActAttachBuff.m_buffState = buffState;
			clientActorActAttachBuff.m_fightTags = a.FightTags;
			clientActorActAttachBuff.m_heroHpMax = a.HeroBattleProperty.HealthPointMax;
			clientActorActAttachBuff.m_soldierHpMax = a.SoldierBattleProperty.HealthPointMax;
			this.m_actorActs.Add(clientActorActAttachBuff);
		}

		// Token: 0x0600875D RID: 34653 RVA: 0x002736C0 File Offset: 0x002718C0
		public void OnBattleActorDetachBuff(BattleActor a, BuffState buffState)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorDetachBuffBattleActorBuffState_hotfix != null)
			{
				this.m_OnBattleActorDetachBuffBattleActorBuffState_hotfix.call(new object[]
				{
					this,
					a,
					buffState
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientActorActDetachBuff clientActorActDetachBuff = new ClientActorActDetachBuff();
			clientActorActDetachBuff.m_actor = a;
			clientActorActDetachBuff.m_step = this.m_battle.Step;
			clientActorActDetachBuff.m_buffState = buffState;
			clientActorActDetachBuff.m_fightTags = a.FightTags;
			clientActorActDetachBuff.m_heroHpMax = a.HeroBattleProperty.HealthPointMax;
			clientActorActDetachBuff.m_soldierHpMax = a.SoldierBattleProperty.HealthPointMax;
			this.m_actorActs.Add(clientActorActDetachBuff);
		}

		// Token: 0x0600875E RID: 34654 RVA: 0x002737A0 File Offset: 0x002719A0
		public void OnBattleActorImmune(BattleActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorImmuneBattleActor_hotfix != null)
			{
				this.m_OnBattleActorImmuneBattleActor_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientActorActImmune clientActorActImmune = new ClientActorActImmune();
			clientActorActImmune.m_actor = a;
			clientActorActImmune.m_step = this.m_battle.Step;
			this.m_actorActs.Add(clientActorActImmune);
		}

		// Token: 0x0600875F RID: 34655 RVA: 0x0027383C File Offset: 0x00271A3C
		public void OnBattleActorPassiveSkill(BattleActor a, BattleActor target, BuffState sourceBuffState)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorPassiveSkillBattleActorBattleActorBuffState_hotfix != null)
			{
				this.m_OnBattleActorPassiveSkillBattleActorBattleActorBuffState_hotfix.call(new object[]
				{
					this,
					a,
					target,
					sourceBuffState
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientActorActPassiveSkill clientActorActPassiveSkill = null;
			for (int i = this.m_actorActs.Count - 1; i >= 0; i--)
			{
				if (this.m_actorActs[i].m_step != this.m_battle.Step)
				{
					break;
				}
				ClientActorActPassiveSkill clientActorActPassiveSkill2 = this.m_actorActs[i] as ClientActorActPassiveSkill;
				if (clientActorActPassiveSkill2 != null && clientActorActPassiveSkill2.m_actor == a && clientActorActPassiveSkill2.m_sourceBuffState == sourceBuffState)
				{
					clientActorActPassiveSkill = clientActorActPassiveSkill2;
					break;
				}
			}
			if (clientActorActPassiveSkill == null)
			{
				clientActorActPassiveSkill = new ClientActorActPassiveSkill();
				clientActorActPassiveSkill.m_actor = a;
				clientActorActPassiveSkill.m_step = this.m_battle.Step;
				clientActorActPassiveSkill.m_sourceBuffState = sourceBuffState;
				clientActorActPassiveSkill.m_hitSelf = false;
				this.m_actorActs.Add(clientActorActPassiveSkill);
			}
			if (target != null)
			{
				if (target == a)
				{
					clientActorActPassiveSkill.m_hitSelf = true;
				}
				else
				{
					ClientActorActPassiveSkillHit clientActorActPassiveSkillHit = new ClientActorActPassiveSkillHit();
					clientActorActPassiveSkillHit.m_actor = target;
					clientActorActPassiveSkillHit.m_step = this.m_battle.Step;
					clientActorActPassiveSkillHit.m_sourceBuffState = sourceBuffState;
					this.m_actorActs.Add(clientActorActPassiveSkillHit);
				}
			}
		}

		// Token: 0x06008760 RID: 34656 RVA: 0x002739D4 File Offset: 0x00271BD4
		public void OnBattleActorBuffHit(BattleActor a, BuffState buffState, int heroHpModify, int soldierHpModify, DamageNumberType damageNumberType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorBuffHitBattleActorBuffStateInt32Int32DamageNumberType_hotfix != null)
			{
				this.m_OnBattleActorBuffHitBattleActorBuffStateInt32Int32DamageNumberType_hotfix.call(new object[]
				{
					this,
					a,
					buffState,
					heroHpModify,
					soldierHpModify,
					damageNumberType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientActorActBuffHit clientActorActBuffHit = new ClientActorActBuffHit();
			clientActorActBuffHit.m_actor = a;
			clientActorActBuffHit.m_step = this.m_battle.Step;
			clientActorActBuffHit.m_buffState = buffState;
			clientActorActBuffHit.m_heroHp = a.HeroHealthPoint;
			clientActorActBuffHit.m_soldierHp = a.SoldierTotalHealthPoint;
			clientActorActBuffHit.m_heroHpModify = heroHpModify;
			clientActorActBuffHit.m_soldierHpModify = soldierHpModify;
			clientActorActBuffHit.m_damageNumberType = damageNumberType;
			this.m_actorActs.Add(clientActorActBuffHit);
		}

		// Token: 0x06008761 RID: 34657 RVA: 0x00273AE4 File Offset: 0x00271CE4
		public void OnBattleActorTerrainHit(BattleActor a, ConfigDataTerrainInfo terrainInfo, int heroHpModify, int soldierHpModify, DamageNumberType damageNumberType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorTerrainHitBattleActorConfigDataTerrainInfoInt32Int32DamageNumberType_hotfix != null)
			{
				this.m_OnBattleActorTerrainHitBattleActorConfigDataTerrainInfoInt32Int32DamageNumberType_hotfix.call(new object[]
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
			ClientActorActTerrainHit clientActorActTerrainHit = new ClientActorActTerrainHit();
			clientActorActTerrainHit.m_actor = a;
			clientActorActTerrainHit.m_step = this.m_battle.Step;
			clientActorActTerrainHit.m_terrainInfo = terrainInfo;
			clientActorActTerrainHit.m_heroHp = a.HeroHealthPoint;
			clientActorActTerrainHit.m_soldierHp = a.SoldierTotalHealthPoint;
			clientActorActTerrainHit.m_heroHpModify = heroHpModify;
			clientActorActTerrainHit.m_soldierHpModify = soldierHpModify;
			clientActorActTerrainHit.m_damageNumberType = damageNumberType;
			this.m_actorActs.Add(clientActorActTerrainHit);
		}

		// Token: 0x06008762 RID: 34658 RVA: 0x00273BF4 File Offset: 0x00271DF4
		public void OnBattleActorTeleport(BattleActor a, ConfigDataSkillInfo skill, GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorTeleportBattleActorConfigDataSkillInfoGridPosition_hotfix != null)
			{
				this.m_OnBattleActorTeleportBattleActorConfigDataSkillInfoGridPosition_hotfix.call(new object[]
				{
					this,
					a,
					skill,
					p
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.OnBattleActorTeleportDisappear(a, skill, p);
			this.OnBattleActorTeleportAppear(a, skill, p);
		}

		// Token: 0x06008763 RID: 34659 RVA: 0x00273C98 File Offset: 0x00271E98
		public void OnBattleActorTeleportDisappear(BattleActor a, ConfigDataSkillInfo skill, GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorTeleportDisappearBattleActorConfigDataSkillInfoGridPosition_hotfix != null)
			{
				this.m_OnBattleActorTeleportDisappearBattleActorConfigDataSkillInfoGridPosition_hotfix.call(new object[]
				{
					this,
					a,
					skill,
					p
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_ignoreTeleportDisappearStep == this.m_battle.Step)
			{
				return;
			}
			ClientActorActTeleportDisappear clientActorActTeleportDisappear = new ClientActorActTeleportDisappear();
			clientActorActTeleportDisappear.m_actor = a;
			clientActorActTeleportDisappear.m_step = this.m_battle.Step;
			clientActorActTeleportDisappear.m_skillInfo = skill;
			clientActorActTeleportDisappear.m_position = p;
			this.m_actorActs.Add(clientActorActTeleportDisappear);
		}

		// Token: 0x06008764 RID: 34660 RVA: 0x00273D78 File Offset: 0x00271F78
		public void OnBattleActorTeleportAppear(BattleActor a, ConfigDataSkillInfo skill, GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorTeleportAppearBattleActorConfigDataSkillInfoGridPosition_hotfix != null)
			{
				this.m_OnBattleActorTeleportAppearBattleActorConfigDataSkillInfoGridPosition_hotfix.call(new object[]
				{
					this,
					a,
					skill,
					p
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientActorActTeleportAppear clientActorActTeleportAppear = new ClientActorActTeleportAppear();
			clientActorActTeleportAppear.m_actor = a;
			clientActorActTeleportAppear.m_step = this.m_battle.Step;
			clientActorActTeleportAppear.m_skillInfo = skill;
			clientActorActTeleportAppear.m_position = p;
			this.m_actorActs.Add(clientActorActTeleportAppear);
		}

		// Token: 0x06008765 RID: 34661 RVA: 0x00273E40 File Offset: 0x00272040
		public void OnBattleActorSummon(BattleActor a, ConfigDataSkillInfo skillInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorSummonBattleActorConfigDataSkillInfo_hotfix != null)
			{
				this.m_OnBattleActorSummonBattleActorConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					a,
					skillInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientActorActSummon clientActorActSummon = new ClientActorActSummon();
			clientActorActSummon.m_actor = a;
			clientActorActSummon.m_step = this.m_battle.Step;
			clientActorActSummon.m_skillInfo = skillInfo;
			this.m_actorActs.Add(clientActorActSummon);
		}

		// Token: 0x06008766 RID: 34662 RVA: 0x00273EF4 File Offset: 0x002720F4
		public void OnBattleActorDie(BattleActor a, bool isAfterCombat)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorDieBattleActorBoolean_hotfix != null)
			{
				this.m_OnBattleActorDieBattleActorBoolean_hotfix.call(new object[]
				{
					this,
					a,
					isAfterCombat
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientActorActDie clientActorActDie = new ClientActorActDie();
			clientActorActDie.m_actor = a;
			clientActorActDie.m_step = this.m_battle.Step;
			clientActorActDie.m_isAfterCombat = isAfterCombat;
			this.m_actorActs.Add(clientActorActDie);
		}

		// Token: 0x06008767 RID: 34663 RVA: 0x00273FA8 File Offset: 0x002721A8
		public void OnBattleActorAppear(BattleActor a, int effectType, string fxName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorAppearBattleActorInt32String_hotfix != null)
			{
				this.m_OnBattleActorAppearBattleActorInt32String_hotfix.call(new object[]
				{
					this,
					a,
					effectType,
					fxName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientActorActAppear clientActorActAppear = new ClientActorActAppear();
			clientActorActAppear.m_actor = a;
			clientActorActAppear.m_step = this.m_battle.Step;
			clientActorActAppear.m_effectType = effectType;
			clientActorActAppear.m_fxName = fxName;
			this.m_actorActs.Add(clientActorActAppear);
		}

		// Token: 0x06008768 RID: 34664 RVA: 0x00274070 File Offset: 0x00272270
		public void OnBattleActorDisappear(BattleActor a, int effectType, string fxName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorDisappearBattleActorInt32String_hotfix != null)
			{
				this.m_OnBattleActorDisappearBattleActorInt32String_hotfix.call(new object[]
				{
					this,
					a,
					effectType,
					fxName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientActorActDisappear clientActorActDisappear = new ClientActorActDisappear();
			clientActorActDisappear.m_actor = a;
			clientActorActDisappear.m_step = this.m_battle.Step;
			clientActorActDisappear.m_effectType = effectType;
			clientActorActDisappear.m_fxName = fxName;
			this.m_actorActs.Add(clientActorActDisappear);
		}

		// Token: 0x06008769 RID: 34665 RVA: 0x00274138 File Offset: 0x00272338
		public void OnBattleActorChangeTeam(BattleActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorChangeTeamBattleActor_hotfix != null)
			{
				this.m_OnBattleActorChangeTeamBattleActor_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientActorActChangeTeam clientActorActChangeTeam = new ClientActorActChangeTeam();
			clientActorActChangeTeam.m_actor = a;
			clientActorActChangeTeam.m_step = this.m_battle.Step;
			clientActorActChangeTeam.m_team = a.TeamNumber;
			clientActorActChangeTeam.m_isAINpc = a.IsAINpc();
			this.m_actorActs.Add(clientActorActChangeTeam);
		}

		// Token: 0x0600876A RID: 34666 RVA: 0x002741EC File Offset: 0x002723EC
		public void OnBattleActorChangeArmy(BattleActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorChangeArmyBattleActor_hotfix != null)
			{
				this.m_OnBattleActorChangeArmyBattleActor_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientActorActChangeArmy clientActorActChangeArmy = new ClientActorActChangeArmy();
			clientActorActChangeArmy.m_actor = a;
			clientActorActChangeArmy.m_step = this.m_battle.Step;
			clientActorActChangeArmy.m_heroArmyInfo = a.HeroArmyInfo;
			this.m_actorActs.Add(clientActorActChangeArmy);
		}

		// Token: 0x0600876B RID: 34667 RVA: 0x00274294 File Offset: 0x00272494
		public void OnBattleActorReplace(BattleActor a0, BattleActor a1, string fxName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorReplaceBattleActorBattleActorString_hotfix != null)
			{
				this.m_OnBattleActorReplaceBattleActorBattleActorString_hotfix.call(new object[]
				{
					this,
					a0,
					a1,
					fxName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientActorActReplace clientActorActReplace = new ClientActorActReplace();
			clientActorActReplace.m_actor = a0;
			clientActorActReplace.m_step = this.m_battle.Step;
			clientActorActReplace.m_newActor = a1;
			clientActorActReplace.m_fxName = fxName;
			this.m_actorActs.Add(clientActorActReplace);
		}

		// Token: 0x0600876C RID: 34668 RVA: 0x0027435C File Offset: 0x0027255C
		public void OnBattleActorCameraFocus(BattleActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorCameraFocusBattleActor_hotfix != null)
			{
				this.m_OnBattleActorCameraFocusBattleActor_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientActorActCameraFocus clientActorActCameraFocus = new ClientActorActCameraFocus();
			clientActorActCameraFocus.m_actor = a;
			clientActorActCameraFocus.m_step = this.m_battle.Step;
			this.m_actorActs.Add(clientActorActCameraFocus);
		}

		// Token: 0x0600876D RID: 34669 RVA: 0x002743F8 File Offset: 0x002725F8
		public void OnBattleActorGainBattleTreasure(BattleActor a, ConfigDataBattleTreasureInfo treasureInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorGainBattleTreasureBattleActorConfigDataBattleTreasureInfo_hotfix != null)
			{
				this.m_OnBattleActorGainBattleTreasureBattleActorConfigDataBattleTreasureInfo_hotfix.call(new object[]
				{
					this,
					a,
					treasureInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientActorActGainBattleTreasure clientActorActGainBattleTreasure = new ClientActorActGainBattleTreasure();
			clientActorActGainBattleTreasure.m_actor = a;
			clientActorActGainBattleTreasure.m_step = this.m_battle.Step;
			clientActorActGainBattleTreasure.m_battleTreasureInfo = treasureInfo;
			this.m_actorActs.Add(clientActorActGainBattleTreasure);
		}

		// Token: 0x0600876E RID: 34670 RVA: 0x002744AC File Offset: 0x002726AC
		public void OnStartGuard(BattleActor a, BattleActor target)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartGuardBattleActorBattleActor_hotfix != null)
			{
				this.m_OnStartGuardBattleActorBattleActor_hotfix.call(new object[]
				{
					this,
					a,
					target
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientActorActStartGuard clientActorActStartGuard = new ClientActorActStartGuard();
			clientActorActStartGuard.m_actor = a;
			clientActorActStartGuard.m_step = this.m_battle.Step;
			clientActorActStartGuard.m_targetActor = target;
			clientActorActStartGuard.m_position = a.Position;
			clientActorActStartGuard.m_direction = a.Direction;
			this.m_actorActs.Add(clientActorActStartGuard);
		}

		// Token: 0x0600876F RID: 34671 RVA: 0x00274578 File Offset: 0x00272778
		public void OnStopGuard(BattleActor a, BattleActor target)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStopGuardBattleActorBattleActor_hotfix != null)
			{
				this.m_OnStopGuardBattleActorBattleActor_hotfix.call(new object[]
				{
					this,
					a,
					target
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientActorActStopGuard clientActorActStopGuard = new ClientActorActStopGuard();
			clientActorActStopGuard.m_actor = a;
			clientActorActStopGuard.m_step = this.m_battle.Step;
			clientActorActStopGuard.m_targetActor = target;
			clientActorActStopGuard.m_position = a.Position;
			clientActorActStopGuard.m_direction = a.Direction;
			this.m_actorActs.Add(clientActorActStopGuard);
		}

		// Token: 0x06008770 RID: 34672 RVA: 0x00274644 File Offset: 0x00272844
		public void OnBeforeStartCombat(BattleActor a, BattleActor b, ConfigDataSkillInfo attackerSkillInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBeforeStartCombatBattleActorBattleActorConfigDataSkillInfo_hotfix != null)
			{
				this.m_OnBeforeStartCombatBattleActorBattleActorConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					a,
					b,
					attackerSkillInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientActorActBeforeStartCombat clientActorActBeforeStartCombat = new ClientActorActBeforeStartCombat();
			clientActorActBeforeStartCombat.m_actor = a;
			clientActorActBeforeStartCombat.m_step = this.m_battle.Step;
			clientActorActBeforeStartCombat.m_direction = a.Direction;
			this.m_actorActs.Add(clientActorActBeforeStartCombat);
			clientActorActBeforeStartCombat = new ClientActorActBeforeStartCombat();
			clientActorActBeforeStartCombat.m_actor = b;
			clientActorActBeforeStartCombat.m_step = this.m_battle.Step;
			clientActorActBeforeStartCombat.m_direction = b.Direction;
			this.m_actorActs.Add(clientActorActBeforeStartCombat);
		}

		// Token: 0x06008771 RID: 34673 RVA: 0x00274740 File Offset: 0x00272940
		public void OnCancelCombat()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCancelCombat_hotfix != null)
			{
				this.m_OnCancelCombat_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientNullActorActCancelCombat clientNullActorActCancelCombat = new ClientNullActorActCancelCombat();
			clientNullActorActCancelCombat.m_actor = null;
			clientNullActorActCancelCombat.m_step = this.m_battle.Step;
			this.m_actorActs.Add(clientNullActorActCancelCombat);
		}

		// Token: 0x06008772 RID: 34674 RVA: 0x002747CC File Offset: 0x002729CC
		public void OnStartCombat(BattleActor a, BattleActor b, ConfigDataSkillInfo attackerSkillInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartCombatBattleActorBattleActorConfigDataSkillInfo_hotfix != null)
			{
				this.m_OnStartCombatBattleActorBattleActorConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					a,
					b,
					attackerSkillInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsNeedTargetIcon(a))
			{
				ClientActorActTarget clientActorActTarget = new ClientActorActTarget();
				clientActorActTarget.m_actor = a;
				clientActorActTarget.m_step = this.m_battle.Step;
				clientActorActTarget.m_skillInfo = null;
				clientActorActTarget.m_targetPosition = b.Position;
				clientActorActTarget.m_armyRelationValue = this.ComputeCombatArmyRelationValue(a, b, this.IsCombatMagicAttack(a, b, attackerSkillInfo));
				this.m_actorActs.Add(clientActorActTarget);
			}
			ClientActorActStartCombat clientActorActStartCombat = new ClientActorActStartCombat();
			clientActorActStartCombat.m_actor = a;
			clientActorActStartCombat.m_step = this.m_battle.Step;
			clientActorActStartCombat.m_direction = a.Direction;
			clientActorActStartCombat.m_targetActor = b;
			clientActorActStartCombat.m_attackerSkillInfo = attackerSkillInfo;
			clientActorActStartCombat.m_isAttacker = true;
			this.m_actorActs.Add(clientActorActStartCombat);
			this.m_combatingBattleActorA = a;
			this.m_combatSkillInfoA = attackerSkillInfo;
			clientActorActStartCombat = new ClientActorActStartCombat();
			clientActorActStartCombat.m_actor = b;
			clientActorActStartCombat.m_step = this.m_battle.Step;
			clientActorActStartCombat.m_direction = b.Direction;
			clientActorActStartCombat.m_targetActor = a;
			clientActorActStartCombat.m_attackerSkillInfo = attackerSkillInfo;
			clientActorActStartCombat.m_isAttacker = false;
			this.m_actorActs.Add(clientActorActStartCombat);
			this.m_combatingBattleActorB = b;
		}

		// Token: 0x06008773 RID: 34675 RVA: 0x00274968 File Offset: 0x00272B68
		public void OnPreStopCombat()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPreStopCombat_hotfix != null)
			{
				this.m_OnPreStopCombat_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsRebuildingBattle())
			{
				return;
			}
			if (this.IsSkippingCombat(true))
			{
				return;
			}
			this.m_clientBattleListener.OnPreStopCombat();
		}

		// Token: 0x06008774 RID: 34676 RVA: 0x002749EC File Offset: 0x00272BEC
		public void OnStopCombat(int teamAHeroTotalDamage, int teamASoldierTotalDamage, bool teamACriticalAttack, int teamBHeroTotalDamage, int teamBSoldierTotalDamage, bool teamBCriticalAttack)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStopCombatInt32Int32BooleanInt32Int32Boolean_hotfix != null)
			{
				this.m_OnStopCombatInt32Int32BooleanInt32Int32Boolean_hotfix.call(new object[]
				{
					this,
					teamAHeroTotalDamage,
					teamASoldierTotalDamage,
					teamACriticalAttack,
					teamBHeroTotalDamage,
					teamBSoldierTotalDamage,
					teamBCriticalAttack
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsSkippingCombat(true) && !this.IsRebuildingBattle())
			{
				ClientBattleActor actor = this.GetActor(this.m_combatingBattleActorA);
				ClientBattleActor actor2 = this.GetActor(this.m_combatingBattleActorB);
				ClientNullActorActFastCombat clientNullActorActFastCombat = new ClientNullActorActFastCombat();
				clientNullActorActFastCombat.m_fastCombatActorInfoA = new FastCombatActorInfo();
				clientNullActorActFastCombat.m_fastCombatActorInfoB = new FastCombatActorInfo();
				clientNullActorActFastCombat.m_fastCombatActorInfoA.m_battleActor = this.m_combatingBattleActorA;
				clientNullActorActFastCombat.m_fastCombatActorInfoA.m_heroHpMax = this.m_combatingBattleActorA.HeroBattleProperty.HealthPointMax;
				clientNullActorActFastCombat.m_fastCombatActorInfoA.m_soldierHpMax = this.m_combatingBattleActorA.SoldierBattleProperty.HealthPointMax;
				clientNullActorActFastCombat.m_fastCombatActorInfoA.m_beforeHeroHp = actor.HeroHealthPoint;
				clientNullActorActFastCombat.m_fastCombatActorInfoA.m_beforeSoldierHp = actor.SoldierTotalHealthPoint;
				clientNullActorActFastCombat.m_fastCombatActorInfoA.m_afterHeroHp = this.m_combatingBattleActorA.HeroHealthPoint;
				clientNullActorActFastCombat.m_fastCombatActorInfoA.m_afterSoldierHp = this.m_combatingBattleActorA.SoldierTotalHealthPoint;
				clientNullActorActFastCombat.m_fastCombatActorInfoA.m_heroDamage = teamAHeroTotalDamage;
				clientNullActorActFastCombat.m_fastCombatActorInfoA.m_soldierDamage = teamASoldierTotalDamage;
				clientNullActorActFastCombat.m_fastCombatActorInfoA.m_isReceiveCriticalAttack = teamBCriticalAttack;
				clientNullActorActFastCombat.m_fastCombatActorInfoB.m_battleActor = this.m_combatingBattleActorB;
				clientNullActorActFastCombat.m_fastCombatActorInfoB.m_heroHpMax = this.m_combatingBattleActorB.HeroBattleProperty.HealthPointMax;
				clientNullActorActFastCombat.m_fastCombatActorInfoB.m_soldierHpMax = this.m_combatingBattleActorB.SoldierBattleProperty.HealthPointMax;
				clientNullActorActFastCombat.m_fastCombatActorInfoB.m_beforeHeroHp = actor2.HeroHealthPoint;
				clientNullActorActFastCombat.m_fastCombatActorInfoB.m_beforeSoldierHp = actor2.SoldierTotalHealthPoint;
				clientNullActorActFastCombat.m_fastCombatActorInfoB.m_afterHeroHp = this.m_combatingBattleActorB.HeroHealthPoint;
				clientNullActorActFastCombat.m_fastCombatActorInfoB.m_afterSoldierHp = this.m_combatingBattleActorB.SoldierTotalHealthPoint;
				clientNullActorActFastCombat.m_fastCombatActorInfoB.m_heroDamage = teamBHeroTotalDamage;
				clientNullActorActFastCombat.m_fastCombatActorInfoB.m_soldierDamage = teamBSoldierTotalDamage;
				clientNullActorActFastCombat.m_fastCombatActorInfoB.m_isReceiveCriticalAttack = teamACriticalAttack;
				clientNullActorActFastCombat.m_attackerSkillInfo = this.m_combatSkillInfoA;
				this.m_actorActs.Add(clientNullActorActFastCombat);
			}
			ClientActorActStopCombat clientActorActStopCombat = new ClientActorActStopCombat();
			clientActorActStopCombat.m_actor = this.m_combatingBattleActorA;
			clientActorActStopCombat.m_step = this.m_battle.Step;
			clientActorActStopCombat.m_heroHp = this.m_combatingBattleActorA.HeroHealthPoint;
			clientActorActStopCombat.m_soldierHp = this.m_combatingBattleActorA.SoldierTotalHealthPoint;
			clientActorActStopCombat.m_heroDamage = teamAHeroTotalDamage;
			clientActorActStopCombat.m_soldierDamage = teamASoldierTotalDamage;
			this.m_actorActs.Add(clientActorActStopCombat);
			this.m_combatingBattleActorA = null;
			clientActorActStopCombat = new ClientActorActStopCombat();
			clientActorActStopCombat.m_actor = this.m_combatingBattleActorB;
			clientActorActStopCombat.m_step = this.m_battle.Step;
			clientActorActStopCombat.m_heroHp = this.m_combatingBattleActorB.HeroHealthPoint;
			clientActorActStopCombat.m_soldierHp = this.m_combatingBattleActorB.SoldierTotalHealthPoint;
			clientActorActStopCombat.m_heroDamage = teamBHeroTotalDamage;
			clientActorActStopCombat.m_soldierDamage = teamBSoldierTotalDamage;
			this.m_actorActs.Add(clientActorActStopCombat);
			this.m_combatingBattleActorB = null;
			if (!this.IsRebuildingBattle() && !this.IsSkippingCombat(true))
			{
				this.StopCombat();
			}
			this.m_state = ClientBattleState.Play;
		}

		// Token: 0x06008775 RID: 34677 RVA: 0x00274D80 File Offset: 0x00272F80
		public void OnBattleNextTurn(int turn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleNextTurnInt32_hotfix != null)
			{
				this.m_OnBattleNextTurnInt32_hotfix.call(new object[]
				{
					this,
					turn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientNullActorActNextTurn clientNullActorActNextTurn = new ClientNullActorActNextTurn();
			clientNullActorActNextTurn.m_actor = null;
			clientNullActorActNextTurn.m_step = this.m_battle.Step;
			clientNullActorActNextTurn.m_turn = turn;
			this.m_actorActs.Add(clientNullActorActNextTurn);
		}

		// Token: 0x06008776 RID: 34678 RVA: 0x00274E24 File Offset: 0x00273024
		public void OnBattleNextTeam(int team, bool isNpc)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleNextTeamInt32Boolean_hotfix != null)
			{
				this.m_OnBattleNextTeamInt32Boolean_hotfix.call(new object[]
				{
					this,
					team,
					isNpc
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isNpc)
			{
				return;
			}
			ClientNullActorActNextTeam clientNullActorActNextTeam = new ClientNullActorActNextTeam();
			clientNullActorActNextTeam.m_actor = null;
			clientNullActorActNextTeam.m_step = this.m_battle.Step;
			clientNullActorActNextTeam.m_team = team;
			clientNullActorActNextTeam.m_focusActor = this.GetActor(this.m_battle.GetActionActor());
			this.m_actorActs.Add(clientNullActorActNextTeam);
		}

		// Token: 0x06008777 RID: 34679 RVA: 0x00274EF4 File Offset: 0x002730F4
		public void OnBattleNextPlayer(int prevPlayerIndex, int playerIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleNextPlayerInt32Int32_hotfix != null)
			{
				this.m_OnBattleNextPlayerInt32Int32_hotfix.call(new object[]
				{
					this,
					prevPlayerIndex,
					playerIndex
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.CurrentBattle.RealTimePVPBattleReport != null)
			{
				return;
			}
			ClientNullActorActNextPlayer clientNullActorActNextPlayer = new ClientNullActorActNextPlayer();
			clientNullActorActNextPlayer.m_actor = null;
			clientNullActorActNextPlayer.m_step = this.m_battle.Step;
			clientNullActorActNextPlayer.m_playerIndex = playerIndex;
			clientNullActorActNextPlayer.m_focusActor = this.GetActor(this.m_battle.GetActionActor());
			this.m_actorActs.Add(clientNullActorActNextPlayer);
		}

		// Token: 0x06008778 RID: 34680 RVA: 0x00274FE0 File Offset: 0x002731E0
		public void OnBattleNextActor(BattleActor actor)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleNextActorBattleActor_hotfix != null)
			{
				this.m_OnBattleNextActorBattleActor_hotfix.call(new object[]
				{
					this,
					actor
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientNullActorActNextActor clientNullActorActNextActor = new ClientNullActorActNextActor();
			clientNullActorActNextActor.m_actor = null;
			clientNullActorActNextActor.m_step = this.m_battle.Step;
			clientNullActorActNextActor.m_nextActor = actor;
			this.m_actorActs.Add(clientNullActorActNextActor);
		}

		// Token: 0x06008779 RID: 34681 RVA: 0x00275084 File Offset: 0x00273284
		public void OnCombatActorHit(CombatActor a, CombatActor attacker, ConfigDataSkillInfo skillInfo, int hpModify, int totalDamage, DamageNumberType damageNumberType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCombatActorHitCombatActorCombatActorConfigDataSkillInfoInt32Int32DamageNumberType_hotfix != null)
			{
				this.m_OnCombatActorHitCombatActorCombatActorConfigDataSkillInfoInt32Int32DamageNumberType_hotfix.call(new object[]
				{
					this,
					a,
					attacker,
					skillInfo,
					hpModify,
					totalDamage,
					damageNumberType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsRebuildingBattle())
			{
				return;
			}
			if (this.IsSkippingCombat(true))
			{
				return;
			}
			this.m_clientBattleListener.OnCombatActorHit(a, attacker, skillInfo, hpModify, totalDamage, damageNumberType);
		}

		// Token: 0x0600877A RID: 34682 RVA: 0x00275174 File Offset: 0x00273374
		public void OnCombatActorDie(CombatActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCombatActorDieCombatActor_hotfix != null)
			{
				this.m_OnCombatActorDieCombatActor_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsRebuildingBattle())
			{
				return;
			}
			if (this.IsSkippingCombat(true))
			{
				return;
			}
			if (a.IsHero())
			{
				this.m_slowMotionState = SlowMotionState.ToPause;
				this.m_slowMotionCountdown = (float)this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_Combat_HeroDieToPauseTime) * 0.001f;
				AudioUtility.PlaySound(this.m_configDataLoader.UtilityGetSound(SoundTableId.SoundTableId_HeroDieAtCombat));
			}
		}

		// Token: 0x0600877B RID: 34683 RVA: 0x0027523C File Offset: 0x0027343C
		public void OnStartSkillCutscene(ConfigDataSkillInfo skillInfo, ConfigDataCutsceneInfo cutsceneInfo, int team)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartSkillCutsceneConfigDataSkillInfoConfigDataCutsceneInfoInt32_hotfix != null)
			{
				this.m_OnStartSkillCutsceneConfigDataSkillInfoConfigDataCutsceneInfoInt32_hotfix.call(new object[]
				{
					this,
					skillInfo,
					cutsceneInfo,
					team
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsRebuildingBattle())
			{
				return;
			}
			if (this.IsSkippingCombat(true))
			{
				return;
			}
			if (this.m_state == ClientBattleState.Combat)
			{
				this.m_combatFxPlayer.PauseAll(true);
			}
			else
			{
				this.m_battleCamera.EnableTouchMove(false);
				this.m_battleFxPlayer.PauseAll(true);
			}
			if (cutsceneInfo != null)
			{
				List<string> list = new List<string>();
				if (!string.IsNullOrEmpty(cutsceneInfo.Sound1))
				{
					list.Add(cutsceneInfo.Sound1);
				}
				if (!string.IsNullOrEmpty(cutsceneInfo.Sound2))
				{
					list.Add(cutsceneInfo.Sound2);
				}
				if (!string.IsNullOrEmpty(cutsceneInfo.Sound3))
				{
					list.Add(cutsceneInfo.Sound3);
				}
				if (list.Count > 0)
				{
					int index = this.m_randomNumber.Next(0, list.Count);
					this.PlaySound(list[index]);
				}
				this.m_cutsceneRoot.SetActive(true);
				GenericGraphic genericGraphic = this.m_cutscenePlayer.Play(cutsceneInfo.Fx);
				if (genericGraphic != null)
				{
					Texture asset = AssetUtility.Instance.GetAsset<Texture>(cutsceneInfo.Head);
					if (asset != null)
					{
						Renderer renderer = Utility.FindChildComponent<Renderer>(genericGraphic.GetPrefab(), "Head", true);
						if (renderer != null)
						{
							renderer.material.mainTexture = asset;
						}
					}
					genericGraphic.SetDirection((team != this.GetMyPlayerTeamNumber()) ? 1 : -1);
					genericGraphic.AutoDelete(true);
				}
				this.m_cutsceneCamera.StartCutscene();
				this.m_cutsceneCamera.PlayClipAnimation(cutsceneInfo.CameraAnimation);
			}
			this.m_clientBattleListener.OnStartSkillCutscene(skillInfo, cutsceneInfo, team);
		}

		// Token: 0x0600877C RID: 34684 RVA: 0x00275460 File Offset: 0x00273660
		public void OnStartPassiveSkillCutscene(BuffState sourceBuffState, int team)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartPassiveSkillCutsceneBuffStateInt32_hotfix != null)
			{
				this.m_OnStartPassiveSkillCutsceneBuffStateInt32_hotfix.call(new object[]
				{
					this,
					sourceBuffState,
					team
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsRebuildingBattle())
			{
				return;
			}
			if (this.IsSkippingCombat(true))
			{
				return;
			}
			if (this.m_state == ClientBattleState.Combat)
			{
				this.m_combatFxPlayer.PauseAll(true);
			}
			else
			{
				this.m_battleCamera.EnableTouchMove(false);
				this.m_battleFxPlayer.PauseAll(true);
			}
			this.m_clientBattleListener.OnStartPassiveSkillCutscene(sourceBuffState, team);
		}

		// Token: 0x0600877D RID: 34685 RVA: 0x0027553C File Offset: 0x0027373C
		public void OnStopSkillCutscene()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStopSkillCutscene_hotfix != null)
			{
				this.m_OnStopSkillCutscene_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_state == ClientBattleState.Combat)
			{
				this.m_combatFxPlayer.PauseAll(false);
			}
			else
			{
				this.m_battleCamera.EnableTouchMove(true);
				this.m_battleFxPlayer.PauseAll(false);
			}
			if (this.m_cutsceneRoot.activeSelf)
			{
				this.m_cutsceneCamera.PlayClipAnimation("Default");
				this.m_cutsceneCamera.StopCutscene();
				this.m_cutsceneRoot.SetActive(false);
			}
			this.m_clientBattleListener.OnStopSkillCutscene();
		}

		// Token: 0x0600877E RID: 34686 RVA: 0x00275614 File Offset: 0x00273814
		public void OnStartBattleDialog(ConfigDataBattleDialogInfo dialogInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartBattleDialogConfigDataBattleDialogInfo_hotfix != null)
			{
				this.m_OnStartBattleDialogConfigDataBattleDialogInfo_hotfix.call(new object[]
				{
					this,
					dialogInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (dialogInfo == null)
			{
				return;
			}
			if (this.IsRebuildingBattle())
			{
				return;
			}
			ClientNullActorActBattleDialog clientNullActorActBattleDialog = new ClientNullActorActBattleDialog();
			clientNullActorActBattleDialog.m_actor = null;
			clientNullActorActBattleDialog.m_step = this.m_battle.Step;
			clientNullActorActBattleDialog.m_battleDialogInfo = dialogInfo;
			this.m_actorActs.Add(clientNullActorActBattleDialog);
		}

		// Token: 0x0600877F RID: 34687 RVA: 0x002756C8 File Offset: 0x002738C8
		public void OnStartBattlePerform(ConfigDataBattlePerformInfo performInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartBattlePerformConfigDataBattlePerformInfo_hotfix != null)
			{
				this.m_OnStartBattlePerformConfigDataBattlePerformInfo_hotfix.call(new object[]
				{
					this,
					performInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientNullActorActStartBattlePerform clientNullActorActStartBattlePerform = new ClientNullActorActStartBattlePerform();
			clientNullActorActStartBattlePerform.m_actor = null;
			clientNullActorActStartBattlePerform.m_step = this.m_battle.Step;
			clientNullActorActStartBattlePerform.m_battlePerformInfo = performInfo;
			this.m_actorActs.Add(clientNullActorActStartBattlePerform);
		}

		// Token: 0x06008780 RID: 34688 RVA: 0x0027576C File Offset: 0x0027396C
		public void OnStopBattlePerform()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStopBattlePerform_hotfix != null)
			{
				this.m_OnStopBattlePerform_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientNullActorActStopBattlePerform clientNullActorActStopBattlePerform = new ClientNullActorActStopBattlePerform();
			clientNullActorActStopBattlePerform.m_actor = null;
			clientNullActorActStopBattlePerform.m_step = this.m_battle.Step;
			this.m_actorActs.Add(clientNullActorActStopBattlePerform);
		}

		// Token: 0x06008781 RID: 34689 RVA: 0x002757F8 File Offset: 0x002739F8
		public void OnChangeMapTerrain(GridPosition p, ConfigDataTerrainInfo terrainInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnChangeMapTerrainGridPositionConfigDataTerrainInfo_hotfix != null)
			{
				this.m_OnChangeMapTerrainGridPositionConfigDataTerrainInfo_hotfix.call(new object[]
				{
					this,
					p,
					terrainInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientNullActorActChangeMapTerrain clientNullActorActChangeMapTerrain = new ClientNullActorActChangeMapTerrain();
			clientNullActorActChangeMapTerrain.m_actor = null;
			clientNullActorActChangeMapTerrain.m_step = this.m_battle.Step;
			clientNullActorActChangeMapTerrain.m_position = p;
			clientNullActorActChangeMapTerrain.m_terrainInfo = terrainInfo;
			this.m_actorActs.Add(clientNullActorActChangeMapTerrain);
		}

		// Token: 0x06008782 RID: 34690 RVA: 0x002758B0 File Offset: 0x00273AB0
		public void OnCameraFocus(GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCameraFocusGridPosition_hotfix != null)
			{
				this.m_OnCameraFocusGridPosition_hotfix.call(new object[]
				{
					this,
					p
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientNullActorActCameraFocus clientNullActorActCameraFocus = new ClientNullActorActCameraFocus();
			clientNullActorActCameraFocus.m_actor = null;
			clientNullActorActCameraFocus.m_step = this.m_battle.Step;
			clientNullActorActCameraFocus.m_position = p;
			this.m_actorActs.Add(clientNullActorActCameraFocus);
		}

		// Token: 0x06008783 RID: 34691 RVA: 0x00275954 File Offset: 0x00273B54
		public void OnPlayMusic(string musicName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPlayMusicString_hotfix != null)
			{
				this.m_OnPlayMusicString_hotfix.call(new object[]
				{
					this,
					musicName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientNullActorActPlayMusic clientNullActorActPlayMusic = new ClientNullActorActPlayMusic();
			clientNullActorActPlayMusic.m_actor = null;
			clientNullActorActPlayMusic.m_step = this.m_battle.Step;
			clientNullActorActPlayMusic.m_musicName = musicName;
			this.m_actorActs.Add(clientNullActorActPlayMusic);
		}

		// Token: 0x06008784 RID: 34692 RVA: 0x002759F8 File Offset: 0x00273BF8
		public void OnPlaySound(string soundName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPlaySoundString_hotfix != null)
			{
				this.m_OnPlaySoundString_hotfix.call(new object[]
				{
					this,
					soundName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientNullActorActPlaySound clientNullActorActPlaySound = new ClientNullActorActPlaySound();
			clientNullActorActPlaySound.m_actor = null;
			clientNullActorActPlaySound.m_step = this.m_battle.Step;
			clientNullActorActPlaySound.m_soundName = soundName;
			this.m_actorActs.Add(clientNullActorActPlaySound);
		}

		// Token: 0x06008785 RID: 34693 RVA: 0x00275A9C File Offset: 0x00273C9C
		public void OnPlayFx(string fxName, GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPlayFxStringGridPosition_hotfix != null)
			{
				this.m_OnPlayFxStringGridPosition_hotfix.call(new object[]
				{
					this,
					fxName,
					p
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientNullActorActPlayFx clientNullActorActPlayFx = new ClientNullActorActPlayFx();
			clientNullActorActPlayFx.m_actor = null;
			clientNullActorActPlayFx.m_step = this.m_battle.Step;
			clientNullActorActPlayFx.m_fxName = fxName;
			clientNullActorActPlayFx.m_position = p;
			this.m_actorActs.Add(clientNullActorActPlayFx);
		}

		// Token: 0x06008786 RID: 34694 RVA: 0x00275B54 File Offset: 0x00273D54
		public void OnWaitTime(int timeInMs)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnWaitTimeInt32_hotfix != null)
			{
				this.m_OnWaitTimeInt32_hotfix.call(new object[]
				{
					this,
					timeInMs
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientNullActorActWaitTime clientNullActorActWaitTime = new ClientNullActorActWaitTime();
			clientNullActorActWaitTime.m_actor = null;
			clientNullActorActWaitTime.m_step = this.m_battle.Step;
			clientNullActorActWaitTime.m_time = timeInMs;
			this.m_actorActs.Add(clientNullActorActWaitTime);
		}

		// Token: 0x06008787 RID: 34695 RVA: 0x00275BF8 File Offset: 0x00273DF8
		public void OnBattleTreasureCreate(ConfigDataBattleTreasureInfo treasureInfo, bool isOpened)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleTreasureCreateConfigDataBattleTreasureInfoBoolean_hotfix != null)
			{
				this.m_OnBattleTreasureCreateConfigDataBattleTreasureInfoBoolean_hotfix.call(new object[]
				{
					this,
					treasureInfo,
					isOpened
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.CreateTreasure(treasureInfo, isOpened);
		}

		// Token: 0x06008788 RID: 34696 RVA: 0x00275C84 File Offset: 0x00273E84
		public IBattleGraphic CreateCombatGraphic(string assetName, float scale)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateCombatGraphicStringSingle_hotfix != null)
			{
				return (IBattleGraphic)this.m_CreateCombatGraphicStringSingle_hotfix.call(new object[]
				{
					this,
					assetName,
					scale
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsRebuildingBattle())
			{
				return null;
			}
			if (this.IsSkippingCombat(true))
			{
				return null;
			}
			GenericGraphic genericGraphic = this.m_graphicPool.Create(assetName);
			if (genericGraphic != null)
			{
				genericGraphic.SetContainer(this);
				genericGraphic.SetFxPlayer(this.m_combatFxPlayer);
				genericGraphic.SetParent(this.m_combatGraphicRoot);
				genericGraphic.SetPrefabScale(scale);
			}
			return genericGraphic;
		}

		// Token: 0x06008789 RID: 34697 RVA: 0x00275D68 File Offset: 0x00273F68
		public void DestroyCombatGraphic(IBattleGraphic g)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroyCombatGraphicIBattleGraphic_hotfix != null)
			{
				this.m_DestroyCombatGraphicIBattleGraphic_hotfix.call(new object[]
				{
					this,
					g
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GenericGraphic genericGraphic = g as GenericGraphic;
			if (genericGraphic == null)
			{
				return;
			}
			this.m_graphicPool.Destroy(genericGraphic);
		}

		// Token: 0x0600878A RID: 34698 RVA: 0x00275DF4 File Offset: 0x00273FF4
		public IBattleGraphic PlayFx(string assetName, float scale)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayFxStringSingle_hotfix != null)
			{
				return (IBattleGraphic)this.m_PlayFxStringSingle_hotfix.call(new object[]
				{
					this,
					assetName,
					scale
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsRebuildingBattle())
			{
				return null;
			}
			if (this.IsSkippingCombat(true))
			{
				return null;
			}
			GenericGraphic genericGraphic = this.m_combatFxPlayer.Play(assetName);
			if (genericGraphic != null)
			{
				genericGraphic.SetContainer(this);
				genericGraphic.SetPrefabScale(scale);
				AssetUtility.Instance.AddAssetToLruCache(5, assetName);
			}
			return genericGraphic;
		}

		// Token: 0x0600878B RID: 34699 RVA: 0x00275ECC File Offset: 0x002740CC
		public void PlaySound(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlaySoundString_hotfix != null)
			{
				this.m_PlaySoundString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsRebuildingBattle())
			{
				return;
			}
			if (this.IsSkippingCombat(true))
			{
				return;
			}
			if (name == this.m_tickSoundName)
			{
				return;
			}
			this.m_tickSoundName = name;
			AudioUtility.PlaySound(name);
		}

		// Token: 0x0600878C RID: 34700 RVA: 0x00275F78 File Offset: 0x00274178
		public void PlaySound(SoundTableId id)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlaySoundSoundTableId_hotfix != null)
			{
				this.m_PlaySoundSoundTableId_hotfix.call(new object[]
				{
					this,
					id
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsRebuildingBattle())
			{
				return;
			}
			if (this.IsSkippingCombat(true))
			{
				return;
			}
			AudioUtility.PlaySound(id);
		}

		// Token: 0x0600878D RID: 34701 RVA: 0x00276008 File Offset: 0x00274208
		public void DrawLine(Vector2i p0, Vector2i p1, Colori color)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DrawLineVector2iVector2iColori_hotfix != null)
			{
				this.m_DrawLineVector2iVector2iColori_hotfix.call(new object[]
				{
					this,
					p0,
					p1,
					color
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Vector3 p2 = this.CombatPositionToWorldPosition(p0, Fix64.Zero, false) + this.m_combatRoot.transform.position;
			Vector3 p3 = this.CombatPositionToWorldPosition(p1, Fix64.Zero, false) + this.m_combatRoot.transform.position;
			this.DrawLine(p2, p3, new Color((float)color.r / 255f, (float)color.g / 255f, (float)color.b / 255f, (float)color.a / 255f));
		}

		// Token: 0x0600878E RID: 34702 RVA: 0x00276124 File Offset: 0x00274324
		public void DrawLine(Vector2i p0, Fix64 z0, Vector2i p1, Fix64 z1, Colori color)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DrawLineVector2iFix64Vector2iFix64Colori_hotfix != null)
			{
				this.m_DrawLineVector2iFix64Vector2iFix64Colori_hotfix.call(new object[]
				{
					this,
					p0,
					z0,
					p1,
					z1,
					color
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Vector3 p2 = this.CombatPositionToWorldPosition(p0, z0, false) + this.m_combatRoot.transform.position;
			Vector3 p3 = this.CombatPositionToWorldPosition(p1, z1, false) + this.m_combatRoot.transform.position;
			this.DrawLine(p2, p3, new Color((float)color.r / 255f, (float)color.g / 255f, (float)color.b / 255f, (float)color.a / 255f));
		}

		// Token: 0x0600878F RID: 34703 RVA: 0x00276258 File Offset: 0x00274458
		public bool IsCombatGraphicMirrorX()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsCombatGraphicMirrorX_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsCombatGraphicMirrorX_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_myPlayerTeam != 0;
		}

		// Token: 0x06008790 RID: 34704 RVA: 0x002762D0 File Offset: 0x002744D0
		public void OnAudio(FxEvent e, AudioClip a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAudioFxEventAudioClip_hotfix != null)
			{
				this.m_OnAudioFxEventAudioClip_hotfix.call(new object[]
				{
					this,
					e,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsRebuildingBattle())
			{
				return;
			}
			if (this.IsSkippingCombat(true))
			{
				return;
			}
			AudioUtility.PlaySound(a);
		}

		// Token: 0x06008791 RID: 34705 RVA: 0x00276370 File Offset: 0x00274570
		public void OnSound(FxEvent e, string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSoundFxEventString_hotfix != null)
			{
				this.m_OnSoundFxEventString_hotfix.call(new object[]
				{
					this,
					e,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsRebuildingBattle())
			{
				return;
			}
			if (this.IsSkippingCombat(true))
			{
				return;
			}
			AudioUtility.PlaySound(name);
		}

		// Token: 0x06008792 RID: 34706 RVA: 0x00276410 File Offset: 0x00274610
		public void OnCameraEffect(FxEvent e, string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCameraEffectFxEventString_hotfix != null)
			{
				this.m_OnCameraEffectFxEventString_hotfix.call(new object[]
				{
					this,
					e,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsRebuildingBattle())
			{
				return;
			}
			if (this.IsSkippingCombat(true))
			{
				return;
			}
			CameraBase currentCamera = this.GetCurrentCamera();
			if (currentCamera != null)
			{
				currentCamera.PlayAnimation(name);
			}
		}

		// Token: 0x06008793 RID: 34707 RVA: 0x002764C0 File Offset: 0x002746C0
		public void OnScreenEffect(FxEvent e, string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnScreenEffectFxEventString_hotfix != null)
			{
				this.m_OnScreenEffectFxEventString_hotfix.call(new object[]
				{
					this,
					e,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsRebuildingBattle())
			{
				return;
			}
			if (this.IsSkippingCombat(true))
			{
				return;
			}
			this.PlayScreenEffect(name);
		}

		// Token: 0x06008794 RID: 34708 RVA: 0x00276560 File Offset: 0x00274760
		public void OnGeneral(FxEvent e, string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGeneralFxEventString_hotfix != null)
			{
				this.m_OnGeneralFxEventString_hotfix.call(new object[]
				{
					this,
					e,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06008795 RID: 34709 RVA: 0x002765E0 File Offset: 0x002747E0
		public Vector3 GetCameraPosition()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCameraPosition_hotfix != null)
			{
				return (Vector3)this.m_GetCameraPosition_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.GetCurrentCamera().Camera.transform.position;
		}

		// Token: 0x06008796 RID: 34710 RVA: 0x00276664 File Offset: 0x00274864
		public Vector3 CombatPositionToWorldPosition(Vector2i p, Fix64 z, bool computeZOffset)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CombatPositionToWorldPositionVector2iFix64Boolean_hotfix != null)
			{
				return (Vector3)this.m_CombatPositionToWorldPositionVector2iFix64Boolean_hotfix.call(new object[]
				{
					this,
					p,
					z,
					computeZOffset
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			float num = (float)p.x;
			float num2 = (float)p.y;
			float num3 = (float)z;
			float z2 = 0f;
			if (computeZOffset)
			{
				z2 = num2 * 0.005f;
			}
			return new Vector3(num * 0.02f + num2 * -0.005f, num2 * 0.01f + num3 * 0.01732f, z2);
		}

		// Token: 0x06008797 RID: 34711 RVA: 0x0027675C File Offset: 0x0027495C
		public bool IsCulled(Vector2 bmin, Vector2 bmax, bool isCombat)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsCulledVector2Vector2Boolean_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsCulledVector2Vector2Boolean_hotfix.call(new object[]
				{
					this,
					bmin,
					bmax,
					isCombat
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CameraBase cameraBase;
			if (isCombat)
			{
				cameraBase = this.m_combatCamera;
			}
			else
			{
				cameraBase = this.m_battleCamera;
			}
			return cameraBase.IsCulled(bmin, bmax);
		}

		// Token: 0x06008798 RID: 34712 RVA: 0x0027681C File Offset: 0x00274A1C
		public void LogBattleStart()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LogBattleStart_hotfix != null)
			{
				this.m_LogBattleStart_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_isEnableSdkLogBattle)
			{
				return;
			}
			if (this.m_battleInfo != null)
			{
				this.SdkLogBattle("40", new ClientBattle.LogDataBattleStart
				{
					BattleId = this.m_battleInfo.ID
				});
			}
			else if (this.m_arenaBattleInfo != null)
			{
				this.SdkLogBattle("41", new ClientBattle.LogDataArenaBattleStart
				{
					ArenaBattleId = this.m_arenaBattleInfo.ID
				});
			}
			else if (this.m_pvpBattleInfo != null)
			{
				ClientBattle.LogDataPVPBattleStart logDataPVPBattleStart = new ClientBattle.LogDataPVPBattleStart();
				logDataPVPBattleStart.PVPBattleId = this.m_pvpBattleInfo.ID;
			}
			else if (this.m_realtimePvpBattleInfo != null)
			{
				ClientBattle.LogDataRealTimePVPBattleStart logDataRealTimePVPBattleStart = new ClientBattle.LogDataRealTimePVPBattleStart();
				logDataRealTimePVPBattleStart.RealTimePVPBattleId = this.m_realtimePvpBattleInfo.ID;
			}
		}

		// Token: 0x06008799 RID: 34713 RVA: 0x00276938 File Offset: 0x00274B38
		public void LogBattleStop(bool isWin)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LogBattleStopBoolean_hotfix != null)
			{
				this.m_LogBattleStopBoolean_hotfix.call(new object[]
				{
					this,
					isWin
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_isEnableSdkLogBattle)
			{
				return;
			}
			this.SdkLogBattle("48", new ClientBattle.LogDataBattleStop
			{
				IsWin = isWin
			});
		}

		// Token: 0x0600879A RID: 34714 RVA: 0x002769D0 File Offset: 0x00274BD0
		public void LogBattleTeam(BattleTeam team0, BattleTeam team1)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LogBattleTeamBattleTeamBattleTeam_hotfix != null)
			{
				this.m_LogBattleTeamBattleTeamBattleTeam_hotfix.call(new object[]
				{
					this,
					team0,
					team1
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_isEnableSdkLogBattle)
			{
				return;
			}
			ClientBattle.LogDataBattleTeam logDataBattleTeam = new ClientBattle.LogDataBattleTeam();
			foreach (BattleActor battleActor in team0.GetActors())
			{
				if (!battleActor.IsNpc())
				{
					logDataBattleTeam.HeroId.Add(battleActor.HeroId);
					logDataBattleTeam.Pos.Add(battleActor.Position);
				}
			}
			this.SdkLogBattle("42", logDataBattleTeam);
			if (this.m_pvpBattleInfo != null || this.m_realtimePvpBattleInfo != null)
			{
				logDataBattleTeam = new ClientBattle.LogDataBattleTeam();
				foreach (BattleActor battleActor2 in team1.GetActors())
				{
					if (!battleActor2.IsNpc())
					{
						logDataBattleTeam.HeroId.Add(battleActor2.HeroId);
						logDataBattleTeam.Pos.Add(battleActor2.Position);
					}
				}
				this.SdkLogBattle("42", logDataBattleTeam);
			}
		}

		// Token: 0x0600879B RID: 34715 RVA: 0x00276B80 File Offset: 0x00274D80
		public void LogActorMove(BattleActor actor, GridPosition fromPos, GridPosition toPos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LogActorMoveBattleActorGridPositionGridPosition_hotfix != null)
			{
				this.m_LogActorMoveBattleActorGridPositionGridPosition_hotfix.call(new object[]
				{
					this,
					actor,
					fromPos,
					toPos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_isEnableSdkLogBattle)
			{
				return;
			}
			this.SdkLogBattle("43", new ClientBattle.LogDataActorMove
			{
				Turn = this.m_battle.Turn,
				HeroId = actor.HeroId,
				FromPos = fromPos,
				ToPos = toPos
			});
		}

		// Token: 0x0600879C RID: 34716 RVA: 0x00276C5C File Offset: 0x00274E5C
		public void LogActorStandby(BattleActor actor)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LogActorStandbyBattleActor_hotfix != null)
			{
				this.m_LogActorStandbyBattleActor_hotfix.call(new object[]
				{
					this,
					actor
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_isEnableSdkLogBattle)
			{
				return;
			}
			this.SdkLogBattle("46", new ClientBattle.LogDataActorStandby
			{
				Turn = this.m_battle.Turn,
				HeroId = actor.HeroId,
				Pos = actor.Position
			});
		}

		// Token: 0x0600879D RID: 34717 RVA: 0x00276D14 File Offset: 0x00274F14
		public void LogActorAttack(BattleActor actor, BattleActor targetActor)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LogActorAttackBattleActorBattleActor_hotfix != null)
			{
				this.m_LogActorAttackBattleActorBattleActor_hotfix.call(new object[]
				{
					this,
					actor,
					targetActor
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_isEnableSdkLogBattle)
			{
				return;
			}
			this.SdkLogBattle("44", new ClientBattle.LogDataActorAttack
			{
				Turn = this.m_battle.Turn,
				HeroId = actor.HeroId,
				TargetHeroId = targetActor.HeroId,
				TargetPos = targetActor.Position
			});
		}

		// Token: 0x0600879E RID: 34718 RVA: 0x00276DE8 File Offset: 0x00274FE8
		public void LogActorSkill(BattleActor actor, ConfigDataSkillInfo skillInfo, BattleActor targetActor, GridPosition targetPos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LogActorSkillBattleActorConfigDataSkillInfoBattleActorGridPosition_hotfix != null)
			{
				this.m_LogActorSkillBattleActorConfigDataSkillInfoBattleActorGridPosition_hotfix.call(new object[]
				{
					this,
					actor,
					skillInfo,
					targetActor,
					targetPos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_isEnableSdkLogBattle)
			{
				return;
			}
			ClientBattle.LogDataActorSkill logDataActorSkill = new ClientBattle.LogDataActorSkill();
			logDataActorSkill.Turn = this.m_battle.Turn;
			logDataActorSkill.HeroId = actor.HeroId;
			if (targetActor != null)
			{
				logDataActorSkill.TargetHeroId = targetActor.HeroId;
			}
			logDataActorSkill.TargetPos = targetPos;
			logDataActorSkill.SkillId = skillInfo.ID;
			this.SdkLogBattle("45", logDataActorSkill);
		}

		// Token: 0x0600879F RID: 34719 RVA: 0x00276EEC File Offset: 0x002750EC
		public void LogActorDie(BattleActor actor, BattleActor killerActor)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LogActorDieBattleActorBattleActor_hotfix != null)
			{
				this.m_LogActorDieBattleActorBattleActor_hotfix.call(new object[]
				{
					this,
					actor,
					killerActor
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_isEnableSdkLogBattle)
			{
				return;
			}
			ClientBattle.LogDataActorDie logDataActorDie = new ClientBattle.LogDataActorDie();
			logDataActorDie.Turn = this.m_battle.Turn;
			logDataActorDie.HeroId = actor.HeroId;
			if (killerActor != null)
			{
				logDataActorDie.KillerHeroId = killerActor.HeroId;
			}
			this.SdkLogBattle("47", logDataActorDie);
		}

		// Token: 0x060087A0 RID: 34720 RVA: 0x00276FBC File Offset: 0x002751BC
		private void SdkLogBattle(string eventId, object logData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SdkLogBattleStringObject_hotfix != null)
			{
				this.m_SdkLogBattleStringObject_hotfix.call(new object[]
				{
					this,
					eventId,
					logData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string remark = JsonUtility.Serialize(logData);
			PDSDK.Instance.printGameEventLog(eventId, remark);
		}

		// Token: 0x17001C77 RID: 7287
		// (get) Token: 0x060087A1 RID: 34721 RVA: 0x00277050 File Offset: 0x00275250
		// (set) Token: 0x060087A2 RID: 34722 RVA: 0x00277070 File Offset: 0x00275270
		[DoNotToLua]
		public ClientBattle.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ClientBattle.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060087A3 RID: 34723 RVA: 0x0027707C File Offset: 0x0027527C
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
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_Dispose_hotfix = (luaObj.RawGet("Dispose") as LuaFunction);
					this.m_InitializeIClientBattleListenerGameObject_hotfix = (luaObj.RawGet("Initialize") as LuaFunction);
					this.m_TickSingle_hotfix = (luaObj.RawGet("Tick") as LuaFunction);
					this.m_TickSlowMotionSingle_hotfix = (luaObj.RawGet("TickSlowMotion") as LuaFunction);
					this.m_TickCombat_hotfix = (luaObj.RawGet("TickCombat") as LuaFunction);
					this.m_TickClientBattle_hotfix = (luaObj.RawGet("TickClientBattle") as LuaFunction);
					this.m_StartCombat_hotfix = (luaObj.RawGet("StartCombat") as LuaFunction);
					this.m_StopCombat_hotfix = (luaObj.RawGet("StopCombat") as LuaFunction);
					this.m_SetTimeScaleSingle_hotfix = (luaObj.RawGet("SetTimeScale") as LuaFunction);
					this.m_SetGlobalTimeScaleSingle_hotfix = (luaObj.RawGet("SetGlobalTimeScale") as LuaFunction);
					this.m_UpdateFinalTimeScale_hotfix = (luaObj.RawGet("UpdateFinalTimeScale") as LuaFunction);
					this.m_TickGraphicSingle_hotfix = (luaObj.RawGet("TickGraphic") as LuaFunction);
					this.m_Draw_hotfix = (luaObj.RawGet("Draw") as LuaFunction);
					this.m_Clear_hotfix = (luaObj.RawGet("Clear") as LuaFunction);
					this.m_CreateMapConfigDataBattleInfoBattleTypeInt32_hotfix = (luaObj.RawGet("CreateMap") as LuaFunction);
					this.m_CreateArenaMapConfigDataArenaBattleInfoInt32_hotfix = (luaObj.RawGet("CreateArenaMap") as LuaFunction);
					this.m_CreatePVPMapConfigDataPVPBattleInfoInt32_hotfix = (luaObj.RawGet("CreatePVPMap") as LuaFunction);
					this.m_CreateRealTimePVPMapConfigDataRealTimePVPBattleInfoInt32_hotfix = (luaObj.RawGet("CreateRealTimePVPMap") as LuaFunction);
					this.m__CreateMapConfigDataBattlefieldInfoInt32Int32_hotfix = (luaObj.RawGet("_CreateMap") as LuaFunction);
					this.m_ResetMap_hotfix = (luaObj.RawGet("ResetMap") as LuaFunction);
					this.m_StartBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32Int32Int32Int32Int32List`1List`1_hotfix = (luaObj.RawGet("Start") as LuaFunction);
					this.m_StartArenaBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32ConfigDataArenaDefendRuleInfo_hotfix = (luaObj.RawGet("StartArena") as LuaFunction);
					this.m_StartPVPBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32_hotfix = (luaObj.RawGet("StartPVP") as LuaFunction);
					this.m_StartRealTimePVPBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32_hotfix = (luaObj.RawGet("StartRealTimePVP") as LuaFunction);
					this.m_IsTeamBattle_hotfix = (luaObj.RawGet("IsTeamBattle") as LuaFunction);
					this.m_SetEnforceActionOrderHerosList`1_hotfix = (luaObj.RawGet("SetEnforceActionOrderHeros") as LuaFunction);
					this.m_FirstStep_hotfix = (luaObj.RawGet("FirstStep") as LuaFunction);
					this.m_StopBooleanBoolean_hotfix = (luaObj.RawGet("Stop") as LuaFunction);
					this.m_GetWinConditionTargetPositionConfigDataBattleWinConditionInfo_hotfix = (luaObj.RawGet("GetWinConditionTargetPosition") as LuaFunction);
					this.m_GetLoseConditionTargetPositionConfigDataBattleLoseConditionInfo_hotfix = (luaObj.RawGet("GetLoseConditionTargetPosition") as LuaFunction);
					this.m_PauseBoolean_hotfix = (luaObj.RawGet("Pause") as LuaFunction);
					this.m_SetAutoBattleBoolean_hotfix = (luaObj.RawGet("SetAutoBattle") as LuaFunction);
					this.m_SetFastBattleBoolean_hotfix = (luaObj.RawGet("SetFastBattle") as LuaFunction);
					this.m_StartBattleDialogConfigDataBattleDialogInfo_hotfix = (luaObj.RawGet("StartBattleDialog") as LuaFunction);
					this.m_StopBattleDialogInt32_hotfix = (luaObj.RawGet("StopBattleDialog") as LuaFunction);
					this.m_GetBattleDialogResult_hotfix = (luaObj.RawGet("GetBattleDialogResult") as LuaFunction);
					this.m_IsWaitBattleDialog_hotfix = (luaObj.RawGet("IsWaitBattleDialog") as LuaFunction);
					this.m_StartBattleTreasureDialogConfigDataBattleTreasureInfo_hotfix = (luaObj.RawGet("StartBattleTreasureDialog") as LuaFunction);
					this.m_StopBattleTreasureDialog_hotfix = (luaObj.RawGet("StopBattleTreasureDialog") as LuaFunction);
					this.m_IsWaitBattleTreasureDialog_hotfix = (luaObj.RawGet("IsWaitBattleTreasureDialog") as LuaFunction);
					this.m_StartBattleTreasureRewardConfigDataBattleTreasureInfo_hotfix = (luaObj.RawGet("StartBattleTreasureReward") as LuaFunction);
					this.m_StopBattleTreasureReward_hotfix = (luaObj.RawGet("StopBattleTreasureReward") as LuaFunction);
					this.m_IsWaitBattleTreasureReward_hotfix = (luaObj.RawGet("IsWaitBattleTreasureReward") as LuaFunction);
					this.m_StartFastCombatFastCombatActorInfoFastCombatActorInfo_hotfix = (luaObj.RawGet("StartFastCombat") as LuaFunction);
					this.m_StopFastCombat_hotfix = (luaObj.RawGet("StopFastCombat") as LuaFunction);
					this.m_IsWaitFastCombat_hotfix = (luaObj.RawGet("IsWaitFastCombat") as LuaFunction);
					this.m_StartBattlePerform_hotfix = (luaObj.RawGet("StartBattlePerform") as LuaFunction);
					this.m_StopBattlePerform_hotfix = (luaObj.RawGet("StopBattlePerform") as LuaFunction);
					this.m_IsBattlePerforming_hotfix = (luaObj.RawGet("IsBattlePerforming") as LuaFunction);
					this.m_FadeNonSkillTargetsClientBattleActorConfigDataSkillInfoGridPosition_hotfix = (luaObj.RawGet("FadeNonSkillTargets") as LuaFunction);
					this.m_RestoreNonSkillTargets_hotfix = (luaObj.RawGet("RestoreNonSkillTargets") as LuaFunction);
					this.m_GetActors_hotfix = (luaObj.RawGet("GetActors") as LuaFunction);
					this.m_GetActorBattleActor_hotfix = (luaObj.RawGet("GetActor") as LuaFunction);
					this.m_IsNeedTargetIconBattleActor_hotfix = (luaObj.RawGet("IsNeedTargetIcon") as LuaFunction);
					this.m_CameraFocusActorClientBattleActor_hotfix = (luaObj.RawGet("CameraFocusActor") as LuaFunction);
					this.m_CameraFocusPositionGridPosition_hotfix = (luaObj.RawGet("CameraFocusPosition") as LuaFunction);
					this.m_CameraFollowActorClientBattleActor_hotfix = (luaObj.RawGet("CameraFollowActor") as LuaFunction);
					this.m_IsCameraFocusing_hotfix = (luaObj.RawGet("IsCameraFocusing") as LuaFunction);
					this.m_ComputeTotalHealthPointInt32_hotfix = (luaObj.RawGet("ComputeTotalHealthPoint") as LuaFunction);
					this.m_ComputeTotalHealthPointMaxInt32_hotfix = (luaObj.RawGet("ComputeTotalHealthPointMax") as LuaFunction);
					this.m_EndAllActionInt32_hotfix = (luaObj.RawGet("EndAllAction") as LuaFunction);
					this.m_IgnoreMoveStepInt32_hotfix = (luaObj.RawGet("IgnoreMoveStep") as LuaFunction);
					this.m_IgnoreSkillStepInt32_hotfix = (luaObj.RawGet("IgnoreSkillStep") as LuaFunction);
					this.m_IgnoreTeleportDisappearStepInt32_hotfix = (luaObj.RawGet("IgnoreTeleportDisappearStep") as LuaFunction);
					this.m_GridPositionToWorldPositionGridPosition_hotfix = (luaObj.RawGet("GridPositionToWorldPosition") as LuaFunction);
					this.m_WorldPositionToGridPositionVector2_hotfix = (luaObj.RawGet("WorldPositionToGridPosition") as LuaFunction);
					this.m_ScreenPositionToWorldPositionVector2_hotfix = (luaObj.RawGet("ScreenPositionToWorldPosition") as LuaFunction);
					this.m_ScreenPositionToGridPositionVector2_hotfix = (luaObj.RawGet("ScreenPositionToGridPosition") as LuaFunction);
					this.m_GridPositionToScreenPositionGridPosition_hotfix = (luaObj.RawGet("GridPositionToScreenPosition") as LuaFunction);
					this.m_DrawLineVector3Vector3Color_hotfix = (luaObj.RawGet("DrawLine") as LuaFunction);
					this.m_DrawMap_hotfix = (luaObj.RawGet("DrawMap") as LuaFunction);
					this.m_DrawCellGridPositionBattleActorConfigDataTerrainInfo_hotfix = (luaObj.RawGet("DrawCell") as LuaFunction);
					this.m_DrawGridGridPositionSingleColorBoolean_hotfix = (luaObj.RawGet("DrawGrid") as LuaFunction);
					this.m_CreateBattleGraphicStringSingle_hotfix = (luaObj.RawGet("CreateBattleGraphic") as LuaFunction);
					this.m_DestroyBattleGraphicGenericGraphic_hotfix = (luaObj.RawGet("DestroyBattleGraphic") as LuaFunction);
					this.m_GetCurrentCamera_hotfix = (luaObj.RawGet("GetCurrentCamera") as LuaFunction);
					this.m_BattleActorTryMoveBattleActorGridPositionInt32_hotfix = (luaObj.RawGet("BattleActorTryMove") as LuaFunction);
					this.m_CreateActorBattleActor_hotfix = (luaObj.RawGet("CreateActor") as LuaFunction);
					this.m_CreateTreasureConfigDataBattleTreasureInfoBoolean_hotfix = (luaObj.RawGet("CreateTreasure") as LuaFunction);
					this.m_GetTreasureConfigDataBattleTreasureInfo_hotfix = (luaObj.RawGet("GetTreasure") as LuaFunction);
					this.m_GetNextEntityId_hotfix = (luaObj.RawGet("GetNextEntityId") as LuaFunction);
					this.m_PlayScreenEffectString_hotfix = (luaObj.RawGet("PlayScreenEffect") as LuaFunction);
					this.m_CreateMapBackgroundConfigDataBattlefieldInfoGameObject_hotfix = (luaObj.RawGet("CreateMapBackground") as LuaFunction);
					this.m_ClearMapBackground_hotfix = (luaObj.RawGet("ClearMapBackground") as LuaFunction);
					this.m_CreateMapTerrainFxGameObject_hotfix = (luaObj.RawGet("CreateMapTerrainFx") as LuaFunction);
					this.m_ClearMapTerrainFx_hotfix = (luaObj.RawGet("ClearMapTerrainFx") as LuaFunction);
					this.m_AddMapTerrainFxGridPositionConfigDataTerrainInfoGameObject_hotfix = (luaObj.RawGet("AddMapTerrainFx") as LuaFunction);
					this.m_ChangeMapTerrainFxGridPositionConfigDataTerrainInfo_hotfix = (luaObj.RawGet("ChangeMapTerrainFx") as LuaFunction);
					this.m_RebuildBattleLocalProcessingBattleData_hotfix = (luaObj.RawGet("RebuildBattle") as LuaFunction);
					this.m_RebuildBattleList`1Int32Int32_hotfix = (luaObj.RawGet("RebuildBattle") as LuaFunction);
					this.m_IsRebuildingBattle_hotfix = (luaObj.RawGet("IsRebuildingBattle") as LuaFunction);
					this.m_StopRebuildingBattle_hotfix = (luaObj.RawGet("StopRebuildingBattle") as LuaFunction);
					this.m_SetSkipCombatModeSkipCombatMode_hotfix = (luaObj.RawGet("SetSkipCombatMode") as LuaFunction);
					this.m_IsSkippingCombatBoolean_hotfix = (luaObj.RawGet("IsSkippingCombat") as LuaFunction);
					this.m_ComputeCombatArmyRelationValueBattleActorBattleActorBoolean_hotfix = (luaObj.RawGet("ComputeCombatArmyRelationValue") as LuaFunction);
					this.m__ComputeCombatArmyRelationValueBattleActorBattleActorBoolean_hotfix = (luaObj.RawGet("_ComputeCombatArmyRelationValue") as LuaFunction);
					this.m_IsCombatMagicAttackBattleActorBattleActorConfigDataSkillInfo_hotfix = (luaObj.RawGet("IsCombatMagicAttack") as LuaFunction);
					this.m_EnableSdkLogBattleBoolean_hotfix = (luaObj.RawGet("EnableSdkLogBattle") as LuaFunction);
					this.m_GetMyPlayerIndex_hotfix = (luaObj.RawGet("GetMyPlayerIndex") as LuaFunction);
					this.m_GetMyPlayerTeamNumber_hotfix = (luaObj.RawGet("GetMyPlayerTeamNumber") as LuaFunction);
					this.m_get_Battle_hotfix = (luaObj.RawGet("get_Battle") as LuaFunction);
					this.m_get_BattleCamera_hotfix = (luaObj.RawGet("get_BattleCamera") as LuaFunction);
					this.m_get_CombatCamera_hotfix = (luaObj.RawGet("get_CombatCamera") as LuaFunction);
					this.m_get_State_hotfix = (luaObj.RawGet("get_State") as LuaFunction);
					this.m_set_EnableDebugDrawBoolean_hotfix = (luaObj.RawGet("set_EnableDebugDraw") as LuaFunction);
					this.m_get_EnableDebugDraw_hotfix = (luaObj.RawGet("get_EnableDebugDraw") as LuaFunction);
					this.m_get_IsAutoBattle_hotfix = (luaObj.RawGet("get_IsAutoBattle") as LuaFunction);
					this.m_get_IsFastBattle_hotfix = (luaObj.RawGet("get_IsFastBattle") as LuaFunction);
					this.m_get_SkipCombatMode_hotfix = (luaObj.RawGet("get_SkipCombatMode") as LuaFunction);
					this.m_get_IsPaused_hotfix = (luaObj.RawGet("get_IsPaused") as LuaFunction);
					this.m_get_BattleGraphicRoot_hotfix = (luaObj.RawGet("get_BattleGraphicRoot") as LuaFunction);
					this.m_get_CombatGraphicRoot_hotfix = (luaObj.RawGet("get_CombatGraphicRoot") as LuaFunction);
					this.m_get_MapTreasureRoot_hotfix = (luaObj.RawGet("get_MapTreasureRoot") as LuaFunction);
					this.m_get_BattleActorUIRoot_hotfix = (luaObj.RawGet("get_BattleActorUIRoot") as LuaFunction);
					this.m_get_BattleActorUIPrefab_hotfix = (luaObj.RawGet("get_BattleActorUIPrefab") as LuaFunction);
					this.m_get_BattleFxPlayer_hotfix = (luaObj.RawGet("get_BattleFxPlayer") as LuaFunction);
					this.m_get_CombatFxPlayer_hotfix = (luaObj.RawGet("get_CombatFxPlayer") as LuaFunction);
					this.m_get_ConfigDataLoader_hotfix = (luaObj.RawGet("get_ConfigDataLoader") as LuaFunction);
					this.m_get_ClientBattleListener_hotfix = (luaObj.RawGet("get_ClientBattleListener") as LuaFunction);
					this.m_get_RandomNumber_hotfix = (luaObj.RawGet("get_RandomNumber") as LuaFunction);
					this.m_AppendActToActor_hotfix = (luaObj.RawGet("AppendActToActor") as LuaFunction);
					this.m_AppendActsToActorInt32Type_hotfix = (luaObj.RawGet("AppendActsToActor") as LuaFunction);
					this.m_AppendActsToActorInt32TypeClientBattleActor_hotfix = (luaObj.RawGet("AppendActsToActor") as LuaFunction);
					this.m_IsAnyActorHasAct_hotfix = (luaObj.RawGet("IsAnyActorHasAct") as LuaFunction);
					this.m_HasWaitingActBattleActorInt32_hotfix = (luaObj.RawGet("HasWaitingAct") as LuaFunction);
					this.m_OnActorActiveClientBattleActorBooleanInt32_hotfix = (luaObj.RawGet("OnActorActive") as LuaFunction);
					this.m_OnActorPreStartCombatClientBattleActor_hotfix = (luaObj.RawGet("OnActorPreStartCombat") as LuaFunction);
					this.m_OnActorStopCombatEndClientBattleActor_hotfix = (luaObj.RawGet("OnActorStopCombatEnd") as LuaFunction);
					this.m_OnActorCastSkillClientBattleActorConfigDataSkillInfoGridPosition_hotfix = (luaObj.RawGet("OnActorCastSkill") as LuaFunction);
					this.m_OnActorCastSkillEndClientBattleActorConfigDataSkillInfo_hotfix = (luaObj.RawGet("OnActorCastSkillEnd") as LuaFunction);
					this.m_OnBattleActorCreateBattleActorBoolean_hotfix = (luaObj.RawGet("OnBattleActorCreate") as LuaFunction);
					this.m_OnBattleActorCreateEndBattleActor_hotfix = (luaObj.RawGet("OnBattleActorCreateEnd") as LuaFunction);
					this.m_OnBattleActorActiveBattleActorBoolean_hotfix = (luaObj.RawGet("OnBattleActorActive") as LuaFunction);
					this.m_OnBattleActorActionBeginBattleActor_hotfix = (luaObj.RawGet("OnBattleActorActionBegin") as LuaFunction);
					this.m_OnBattleActorActionEndBattleActor_hotfix = (luaObj.RawGet("OnBattleActorActionEnd") as LuaFunction);
					this.m_OnBattleActorMoveBattleActorGridPositionInt32_hotfix = (luaObj.RawGet("OnBattleActorMove") as LuaFunction);
					this.m_OnBattleActorPerformMoveBattleActorGridPositionInt32Boolean_hotfix = (luaObj.RawGet("OnBattleActorPerformMove") as LuaFunction);
					this.m_OnBattleActorPunchMoveBattleActorStringBoolean_hotfix = (luaObj.RawGet("OnBattleActorPunchMove") as LuaFunction);
					this.m_OnBattleActorExchangeMoveBattleActorBattleActorInt32String_hotfix = (luaObj.RawGet("OnBattleActorExchangeMove") as LuaFunction);
					this.m_OnBattleActorSetDirBattleActorInt32_hotfix = (luaObj.RawGet("OnBattleActorSetDir") as LuaFunction);
					this.m_OnBattleActorPlayFxBattleActorStringInt32_hotfix = (luaObj.RawGet("OnBattleActorPlayFx") as LuaFunction);
					this.m_OnBattleActorPlayAnimationBattleActorStringInt32_hotfix = (luaObj.RawGet("OnBattleActorPlayAnimation") as LuaFunction);
					this.m_OnBattleActorChangeIdleAnimationBattleActorString_hotfix = (luaObj.RawGet("OnBattleActorChangeIdleAnimation") as LuaFunction);
					this.m_OnBattleActorSkillBattleActorConfigDataSkillInfoGridPosition_hotfix = (luaObj.RawGet("OnBattleActorSkill") as LuaFunction);
					this.m_OnBattleActorSkillHitBeginBattleActorConfigDataSkillInfoBoolean_hotfix = (luaObj.RawGet("OnBattleActorSkillHitBegin") as LuaFunction);
					this.m_OnBattleActorSkillHitBattleActorConfigDataSkillInfoInt32Int32DamageNumberTypeBoolean_hotfix = (luaObj.RawGet("OnBattleActorSkillHit") as LuaFunction);
					this.m_OnBattleActorSkillHitEndBattleActorConfigDataSkillInfoBoolean_hotfix = (luaObj.RawGet("OnBattleActorSkillHitEnd") as LuaFunction);
					this.m_OnBattleActorAttachBuffBattleActorBuffState_hotfix = (luaObj.RawGet("OnBattleActorAttachBuff") as LuaFunction);
					this.m_OnBattleActorDetachBuffBattleActorBuffState_hotfix = (luaObj.RawGet("OnBattleActorDetachBuff") as LuaFunction);
					this.m_OnBattleActorImmuneBattleActor_hotfix = (luaObj.RawGet("OnBattleActorImmune") as LuaFunction);
					this.m_OnBattleActorPassiveSkillBattleActorBattleActorBuffState_hotfix = (luaObj.RawGet("OnBattleActorPassiveSkill") as LuaFunction);
					this.m_OnBattleActorBuffHitBattleActorBuffStateInt32Int32DamageNumberType_hotfix = (luaObj.RawGet("OnBattleActorBuffHit") as LuaFunction);
					this.m_OnBattleActorTerrainHitBattleActorConfigDataTerrainInfoInt32Int32DamageNumberType_hotfix = (luaObj.RawGet("OnBattleActorTerrainHit") as LuaFunction);
					this.m_OnBattleActorTeleportBattleActorConfigDataSkillInfoGridPosition_hotfix = (luaObj.RawGet("OnBattleActorTeleport") as LuaFunction);
					this.m_OnBattleActorTeleportDisappearBattleActorConfigDataSkillInfoGridPosition_hotfix = (luaObj.RawGet("OnBattleActorTeleportDisappear") as LuaFunction);
					this.m_OnBattleActorTeleportAppearBattleActorConfigDataSkillInfoGridPosition_hotfix = (luaObj.RawGet("OnBattleActorTeleportAppear") as LuaFunction);
					this.m_OnBattleActorSummonBattleActorConfigDataSkillInfo_hotfix = (luaObj.RawGet("OnBattleActorSummon") as LuaFunction);
					this.m_OnBattleActorDieBattleActorBoolean_hotfix = (luaObj.RawGet("OnBattleActorDie") as LuaFunction);
					this.m_OnBattleActorAppearBattleActorInt32String_hotfix = (luaObj.RawGet("OnBattleActorAppear") as LuaFunction);
					this.m_OnBattleActorDisappearBattleActorInt32String_hotfix = (luaObj.RawGet("OnBattleActorDisappear") as LuaFunction);
					this.m_OnBattleActorChangeTeamBattleActor_hotfix = (luaObj.RawGet("OnBattleActorChangeTeam") as LuaFunction);
					this.m_OnBattleActorChangeArmyBattleActor_hotfix = (luaObj.RawGet("OnBattleActorChangeArmy") as LuaFunction);
					this.m_OnBattleActorReplaceBattleActorBattleActorString_hotfix = (luaObj.RawGet("OnBattleActorReplace") as LuaFunction);
					this.m_OnBattleActorCameraFocusBattleActor_hotfix = (luaObj.RawGet("OnBattleActorCameraFocus") as LuaFunction);
					this.m_OnBattleActorGainBattleTreasureBattleActorConfigDataBattleTreasureInfo_hotfix = (luaObj.RawGet("OnBattleActorGainBattleTreasure") as LuaFunction);
					this.m_OnStartGuardBattleActorBattleActor_hotfix = (luaObj.RawGet("OnStartGuard") as LuaFunction);
					this.m_OnStopGuardBattleActorBattleActor_hotfix = (luaObj.RawGet("OnStopGuard") as LuaFunction);
					this.m_OnBeforeStartCombatBattleActorBattleActorConfigDataSkillInfo_hotfix = (luaObj.RawGet("OnBeforeStartCombat") as LuaFunction);
					this.m_OnCancelCombat_hotfix = (luaObj.RawGet("OnCancelCombat") as LuaFunction);
					this.m_OnStartCombatBattleActorBattleActorConfigDataSkillInfo_hotfix = (luaObj.RawGet("OnStartCombat") as LuaFunction);
					this.m_OnPreStopCombat_hotfix = (luaObj.RawGet("OnPreStopCombat") as LuaFunction);
					this.m_OnStopCombatInt32Int32BooleanInt32Int32Boolean_hotfix = (luaObj.RawGet("OnStopCombat") as LuaFunction);
					this.m_OnBattleNextTurnInt32_hotfix = (luaObj.RawGet("OnBattleNextTurn") as LuaFunction);
					this.m_OnBattleNextTeamInt32Boolean_hotfix = (luaObj.RawGet("OnBattleNextTeam") as LuaFunction);
					this.m_OnBattleNextPlayerInt32Int32_hotfix = (luaObj.RawGet("OnBattleNextPlayer") as LuaFunction);
					this.m_OnBattleNextActorBattleActor_hotfix = (luaObj.RawGet("OnBattleNextActor") as LuaFunction);
					this.m_OnCombatActorHitCombatActorCombatActorConfigDataSkillInfoInt32Int32DamageNumberType_hotfix = (luaObj.RawGet("OnCombatActorHit") as LuaFunction);
					this.m_OnCombatActorDieCombatActor_hotfix = (luaObj.RawGet("OnCombatActorDie") as LuaFunction);
					this.m_OnStartSkillCutsceneConfigDataSkillInfoConfigDataCutsceneInfoInt32_hotfix = (luaObj.RawGet("OnStartSkillCutscene") as LuaFunction);
					this.m_OnStartPassiveSkillCutsceneBuffStateInt32_hotfix = (luaObj.RawGet("OnStartPassiveSkillCutscene") as LuaFunction);
					this.m_OnStopSkillCutscene_hotfix = (luaObj.RawGet("OnStopSkillCutscene") as LuaFunction);
					this.m_OnStartBattleDialogConfigDataBattleDialogInfo_hotfix = (luaObj.RawGet("OnStartBattleDialog") as LuaFunction);
					this.m_OnStartBattlePerformConfigDataBattlePerformInfo_hotfix = (luaObj.RawGet("OnStartBattlePerform") as LuaFunction);
					this.m_OnStopBattlePerform_hotfix = (luaObj.RawGet("OnStopBattlePerform") as LuaFunction);
					this.m_OnChangeMapTerrainGridPositionConfigDataTerrainInfo_hotfix = (luaObj.RawGet("OnChangeMapTerrain") as LuaFunction);
					this.m_OnCameraFocusGridPosition_hotfix = (luaObj.RawGet("OnCameraFocus") as LuaFunction);
					this.m_OnPlayMusicString_hotfix = (luaObj.RawGet("OnPlayMusic") as LuaFunction);
					this.m_OnPlaySoundString_hotfix = (luaObj.RawGet("OnPlaySound") as LuaFunction);
					this.m_OnPlayFxStringGridPosition_hotfix = (luaObj.RawGet("OnPlayFx") as LuaFunction);
					this.m_OnWaitTimeInt32_hotfix = (luaObj.RawGet("OnWaitTime") as LuaFunction);
					this.m_OnBattleTreasureCreateConfigDataBattleTreasureInfoBoolean_hotfix = (luaObj.RawGet("OnBattleTreasureCreate") as LuaFunction);
					this.m_CreateCombatGraphicStringSingle_hotfix = (luaObj.RawGet("CreateCombatGraphic") as LuaFunction);
					this.m_DestroyCombatGraphicIBattleGraphic_hotfix = (luaObj.RawGet("DestroyCombatGraphic") as LuaFunction);
					this.m_PlayFxStringSingle_hotfix = (luaObj.RawGet("PlayFx") as LuaFunction);
					this.m_PlaySoundString_hotfix = (luaObj.RawGet("PlaySound") as LuaFunction);
					this.m_PlaySoundSoundTableId_hotfix = (luaObj.RawGet("PlaySound") as LuaFunction);
					this.m_DrawLineVector2iVector2iColori_hotfix = (luaObj.RawGet("DrawLine") as LuaFunction);
					this.m_DrawLineVector2iFix64Vector2iFix64Colori_hotfix = (luaObj.RawGet("DrawLine") as LuaFunction);
					this.m_IsCombatGraphicMirrorX_hotfix = (luaObj.RawGet("IsCombatGraphicMirrorX") as LuaFunction);
					this.m_OnAudioFxEventAudioClip_hotfix = (luaObj.RawGet("OnAudio") as LuaFunction);
					this.m_OnSoundFxEventString_hotfix = (luaObj.RawGet("OnSound") as LuaFunction);
					this.m_OnCameraEffectFxEventString_hotfix = (luaObj.RawGet("OnCameraEffect") as LuaFunction);
					this.m_OnScreenEffectFxEventString_hotfix = (luaObj.RawGet("OnScreenEffect") as LuaFunction);
					this.m_OnGeneralFxEventString_hotfix = (luaObj.RawGet("OnGeneral") as LuaFunction);
					this.m_GetCameraPosition_hotfix = (luaObj.RawGet("GetCameraPosition") as LuaFunction);
					this.m_CombatPositionToWorldPositionVector2iFix64Boolean_hotfix = (luaObj.RawGet("CombatPositionToWorldPosition") as LuaFunction);
					this.m_IsCulledVector2Vector2Boolean_hotfix = (luaObj.RawGet("IsCulled") as LuaFunction);
					this.m_LogBattleStart_hotfix = (luaObj.RawGet("LogBattleStart") as LuaFunction);
					this.m_LogBattleStopBoolean_hotfix = (luaObj.RawGet("LogBattleStop") as LuaFunction);
					this.m_LogBattleTeamBattleTeamBattleTeam_hotfix = (luaObj.RawGet("LogBattleTeam") as LuaFunction);
					this.m_LogActorMoveBattleActorGridPositionGridPosition_hotfix = (luaObj.RawGet("LogActorMove") as LuaFunction);
					this.m_LogActorStandbyBattleActor_hotfix = (luaObj.RawGet("LogActorStandby") as LuaFunction);
					this.m_LogActorAttackBattleActorBattleActor_hotfix = (luaObj.RawGet("LogActorAttack") as LuaFunction);
					this.m_LogActorSkillBattleActorConfigDataSkillInfoBattleActorGridPosition_hotfix = (luaObj.RawGet("LogActorSkill") as LuaFunction);
					this.m_LogActorDieBattleActorBattleActor_hotfix = (luaObj.RawGet("LogActorDie") as LuaFunction);
					this.m_SdkLogBattleStringObject_hotfix = (luaObj.RawGet("SdkLogBattle") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060087A4 RID: 34724 RVA: 0x00278660 File Offset: 0x00276860
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ClientBattle));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005FC3 RID: 24515
		private ClientBattleState m_state;

		// Token: 0x04005FC4 RID: 24516
		private int m_entityIdCounter;

		// Token: 0x04005FC5 RID: 24517
		private bool m_isStopBattleWin;

		// Token: 0x04005FC6 RID: 24518
		private int m_frameCount;

		// Token: 0x04005FC7 RID: 24519
		private int m_endCountdown;

		// Token: 0x04005FC8 RID: 24520
		private int m_cutscenePauseCountdown;

		// Token: 0x04005FC9 RID: 24521
		private int m_restoreNonSkillTargetsCountdown;

		// Token: 0x04005FCA RID: 24522
		private string m_tickSoundName;

		// Token: 0x04005FCB RID: 24523
		private float m_battleTickTime;

		// Token: 0x04005FCC RID: 24524
		private float m_combatTickTime;

		// Token: 0x04005FCD RID: 24525
		private float m_timeScale;

		// Token: 0x04005FCE RID: 24526
		private float m_globalTimeScale;

		// Token: 0x04005FCF RID: 24527
		private SlowMotionState m_slowMotionState;

		// Token: 0x04005FD0 RID: 24528
		private float m_slowMotionCountdown;

		// Token: 0x04005FD1 RID: 24529
		private bool m_isPaused;

		// Token: 0x04005FD2 RID: 24530
		private bool m_isAutoBattle;

		// Token: 0x04005FD3 RID: 24531
		private bool m_isFastBattle;

		// Token: 0x04005FD4 RID: 24532
		private bool m_isEnableDebugDraw;

		// Token: 0x04005FD5 RID: 24533
		private bool m_isEnableSdkLogBattle;

		// Token: 0x04005FD6 RID: 24534
		private RandomNumber m_randomNumber;

		// Token: 0x04005FD7 RID: 24535
		private BattleBase m_battle;

		// Token: 0x04005FD8 RID: 24536
		private ClientBattleActor m_nullActor;

		// Token: 0x04005FD9 RID: 24537
		private List<ClientBattleActor> m_actors;

		// Token: 0x04005FDA RID: 24538
		private ClientBattleActor m_activeActor;

		// Token: 0x04005FDB RID: 24539
		private ClientBattleActor m_cameraFollowActor;

		// Token: 0x04005FDC RID: 24540
		private List<ClientActorAct> m_actorActs;

		// Token: 0x04005FDD RID: 24541
		private List<ClientBattleTreasure> m_treasures;

		// Token: 0x04005FDE RID: 24542
		private List<int> m_enforceActionOrderHeroIds = new List<int>();

		// Token: 0x04005FDF RID: 24543
		private BattleActor m_combatingBattleActorA;

		// Token: 0x04005FE0 RID: 24544
		private BattleActor m_combatingBattleActorB;

		// Token: 0x04005FE1 RID: 24545
		private ConfigDataSkillInfo m_combatSkillInfoA;

		// Token: 0x04005FE2 RID: 24546
		private int m_ignoreMoveStep;

		// Token: 0x04005FE3 RID: 24547
		private int m_ignoreSkillStep;

		// Token: 0x04005FE4 RID: 24548
		private int m_ignoreTeleportDisappearStep;

		// Token: 0x04005FE5 RID: 24549
		private int m_ignoreActiveTeam;

		// Token: 0x04005FE6 RID: 24550
		private int m_ignoreActiveTurn;

		// Token: 0x04005FE7 RID: 24551
		private ClientActorActSkillHit m_actorActSkillHit;

		// Token: 0x04005FE8 RID: 24552
		private ClientActorActSkillHit m_actorActSkillRebound;

		// Token: 0x04005FE9 RID: 24553
		private ConfigDataBattleDialogInfo m_curBattleDialogInfo;

		// Token: 0x04005FEA RID: 24554
		private int m_battleDialogResult;

		// Token: 0x04005FEB RID: 24555
		private bool m_isWaitBattleTreasureDialog;

		// Token: 0x04005FEC RID: 24556
		private bool m_isWaitBattleTreasureReward;

		// Token: 0x04005FED RID: 24557
		private bool m_isWaitFastCombat;

		// Token: 0x04005FEE RID: 24558
		private bool m_isBattlePerforming;

		// Token: 0x04005FEF RID: 24559
		private int m_myPlayerIndex = -1;

		// Token: 0x04005FF0 RID: 24560
		private int m_myPlayerTeam;

		// Token: 0x04005FF1 RID: 24561
		private int m_rebuildBattleStepMax;

		// Token: 0x04005FF2 RID: 24562
		private SkipCombatMode m_skipCombatMode;

		// Token: 0x04005FF3 RID: 24563
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04005FF4 RID: 24564
		private IClientBattleListener m_clientBattleListener;

		// Token: 0x04005FF5 RID: 24565
		private ConfigDataBattleInfo m_battleInfo;

		// Token: 0x04005FF6 RID: 24566
		private ConfigDataArenaBattleInfo m_arenaBattleInfo;

		// Token: 0x04005FF7 RID: 24567
		private ConfigDataPVPBattleInfo m_pvpBattleInfo;

		// Token: 0x04005FF8 RID: 24568
		private ConfigDataRealTimePVPBattleInfo m_realtimePvpBattleInfo;

		// Token: 0x04005FF9 RID: 24569
		private BattleType m_battleType;

		// Token: 0x04005FFA RID: 24570
		private BattleCamera m_battleCamera;

		// Token: 0x04005FFB RID: 24571
		private CombatCamera m_combatCamera;

		// Token: 0x04005FFC RID: 24572
		private CutsceneCamera m_cutsceneCamera;

		// Token: 0x04005FFD RID: 24573
		private GameObject m_battleRoot;

		// Token: 0x04005FFE RID: 24574
		private GameObject m_combatRoot;

		// Token: 0x04005FFF RID: 24575
		private GameObject m_cutsceneRoot;

		// Token: 0x04006000 RID: 24576
		private GameObject m_battleGraphicRoot;

		// Token: 0x04006001 RID: 24577
		private GameObject m_combatGraphicRoot;

		// Token: 0x04006002 RID: 24578
		private GameObject m_cutsceneGraphicRoot;

		// Token: 0x04006003 RID: 24579
		private GameObject m_mapRoot;

		// Token: 0x04006004 RID: 24580
		private GameObject m_mapBackground;

		// Token: 0x04006005 RID: 24581
		private GameObject m_mapTerrainFxRoot;

		// Token: 0x04006006 RID: 24582
		private GameObject m_mapTreasureRoot;

		// Token: 0x04006007 RID: 24583
		private Dictionary<GridPosition, GameObject> m_mapTerrainFxs;

		// Token: 0x04006008 RID: 24584
		private GameObject m_battleUIRoot;

		// Token: 0x04006009 RID: 24585
		private GameObject m_battleActorUIRoot;

		// Token: 0x0400600A RID: 24586
		private GameObject m_battleActorUIPrefab;

		// Token: 0x0400600B RID: 24587
		private GraphicPool m_graphicPool;

		// Token: 0x0400600C RID: 24588
		private GraphicPool m_fxPool;

		// Token: 0x0400600D RID: 24589
		private FxPlayer m_battleFxPlayer;

		// Token: 0x0400600E RID: 24590
		private FxPlayer m_combatFxPlayer;

		// Token: 0x0400600F RID: 24591
		private FxPlayer m_cutscenePlayer;

		// Token: 0x04006010 RID: 24592
		[DoNotToLua]
		private ClientBattle.LuaExportHelper luaExportHelper;

		// Token: 0x04006011 RID: 24593
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006012 RID: 24594
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006013 RID: 24595
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04006014 RID: 24596
		private LuaFunction m_Dispose_hotfix;

		// Token: 0x04006015 RID: 24597
		private LuaFunction m_InitializeIClientBattleListenerGameObject_hotfix;

		// Token: 0x04006016 RID: 24598
		private LuaFunction m_TickSingle_hotfix;

		// Token: 0x04006017 RID: 24599
		private LuaFunction m_TickSlowMotionSingle_hotfix;

		// Token: 0x04006018 RID: 24600
		private LuaFunction m_TickCombat_hotfix;

		// Token: 0x04006019 RID: 24601
		private LuaFunction m_TickClientBattle_hotfix;

		// Token: 0x0400601A RID: 24602
		private LuaFunction m_StartCombat_hotfix;

		// Token: 0x0400601B RID: 24603
		private LuaFunction m_StopCombat_hotfix;

		// Token: 0x0400601C RID: 24604
		private LuaFunction m_SetTimeScaleSingle_hotfix;

		// Token: 0x0400601D RID: 24605
		private LuaFunction m_SetGlobalTimeScaleSingle_hotfix;

		// Token: 0x0400601E RID: 24606
		private LuaFunction m_UpdateFinalTimeScale_hotfix;

		// Token: 0x0400601F RID: 24607
		private LuaFunction m_TickGraphicSingle_hotfix;

		// Token: 0x04006020 RID: 24608
		private LuaFunction m_Draw_hotfix;

		// Token: 0x04006021 RID: 24609
		private LuaFunction m_Clear_hotfix;

		// Token: 0x04006022 RID: 24610
		private LuaFunction m_CreateMapConfigDataBattleInfoBattleTypeInt32_hotfix;

		// Token: 0x04006023 RID: 24611
		private LuaFunction m_CreateArenaMapConfigDataArenaBattleInfoInt32_hotfix;

		// Token: 0x04006024 RID: 24612
		private LuaFunction m_CreatePVPMapConfigDataPVPBattleInfoInt32_hotfix;

		// Token: 0x04006025 RID: 24613
		private LuaFunction m_CreateRealTimePVPMapConfigDataRealTimePVPBattleInfoInt32_hotfix;

		// Token: 0x04006026 RID: 24614
		private LuaFunction m__CreateMapConfigDataBattlefieldInfoInt32Int32_hotfix;

		// Token: 0x04006027 RID: 24615
		private LuaFunction m_ResetMap_hotfix;

		// Token: 0x04006028 RID: 24616
		private LuaFunction m_StartBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32Int32Int32Int32Int32List`1List;

		// Token: 0x04006029 RID: 24617
		private LuaFunction m_StartArenaBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32ConfigDataArenaDefendRuleInfo_hotfix;

		// Token: 0x0400602A RID: 24618
		private LuaFunction m_StartPVPBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32_hotfix;

		// Token: 0x0400602B RID: 24619
		private LuaFunction m_StartRealTimePVPBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32_hotfix;

		// Token: 0x0400602C RID: 24620
		private LuaFunction m_IsTeamBattle_hotfix;

		// Token: 0x0400602D RID: 24621
		private LuaFunction m_SetEnforceActionOrderHerosList;

		// Token: 0x0400602E RID: 24622
		private LuaFunction m_FirstStep_hotfix;

		// Token: 0x0400602F RID: 24623
		private LuaFunction m_StopBooleanBoolean_hotfix;

		// Token: 0x04006030 RID: 24624
		private LuaFunction m_GetWinConditionTargetPositionConfigDataBattleWinConditionInfo_hotfix;

		// Token: 0x04006031 RID: 24625
		private LuaFunction m_GetLoseConditionTargetPositionConfigDataBattleLoseConditionInfo_hotfix;

		// Token: 0x04006032 RID: 24626
		private LuaFunction m_PauseBoolean_hotfix;

		// Token: 0x04006033 RID: 24627
		private LuaFunction m_SetAutoBattleBoolean_hotfix;

		// Token: 0x04006034 RID: 24628
		private LuaFunction m_SetFastBattleBoolean_hotfix;

		// Token: 0x04006035 RID: 24629
		private LuaFunction m_StartBattleDialogConfigDataBattleDialogInfo_hotfix;

		// Token: 0x04006036 RID: 24630
		private LuaFunction m_StopBattleDialogInt32_hotfix;

		// Token: 0x04006037 RID: 24631
		private LuaFunction m_GetBattleDialogResult_hotfix;

		// Token: 0x04006038 RID: 24632
		private LuaFunction m_IsWaitBattleDialog_hotfix;

		// Token: 0x04006039 RID: 24633
		private LuaFunction m_StartBattleTreasureDialogConfigDataBattleTreasureInfo_hotfix;

		// Token: 0x0400603A RID: 24634
		private LuaFunction m_StopBattleTreasureDialog_hotfix;

		// Token: 0x0400603B RID: 24635
		private LuaFunction m_IsWaitBattleTreasureDialog_hotfix;

		// Token: 0x0400603C RID: 24636
		private LuaFunction m_StartBattleTreasureRewardConfigDataBattleTreasureInfo_hotfix;

		// Token: 0x0400603D RID: 24637
		private LuaFunction m_StopBattleTreasureReward_hotfix;

		// Token: 0x0400603E RID: 24638
		private LuaFunction m_IsWaitBattleTreasureReward_hotfix;

		// Token: 0x0400603F RID: 24639
		private LuaFunction m_StartFastCombatFastCombatActorInfoFastCombatActorInfo_hotfix;

		// Token: 0x04006040 RID: 24640
		private LuaFunction m_StopFastCombat_hotfix;

		// Token: 0x04006041 RID: 24641
		private LuaFunction m_IsWaitFastCombat_hotfix;

		// Token: 0x04006042 RID: 24642
		private LuaFunction m_StartBattlePerform_hotfix;

		// Token: 0x04006043 RID: 24643
		private LuaFunction m_StopBattlePerform_hotfix;

		// Token: 0x04006044 RID: 24644
		private LuaFunction m_IsBattlePerforming_hotfix;

		// Token: 0x04006045 RID: 24645
		private LuaFunction m_FadeNonSkillTargetsClientBattleActorConfigDataSkillInfoGridPosition_hotfix;

		// Token: 0x04006046 RID: 24646
		private LuaFunction m_RestoreNonSkillTargets_hotfix;

		// Token: 0x04006047 RID: 24647
		private LuaFunction m_GetActors_hotfix;

		// Token: 0x04006048 RID: 24648
		private LuaFunction m_GetActorBattleActor_hotfix;

		// Token: 0x04006049 RID: 24649
		private LuaFunction m_IsNeedTargetIconBattleActor_hotfix;

		// Token: 0x0400604A RID: 24650
		private LuaFunction m_CameraFocusActorClientBattleActor_hotfix;

		// Token: 0x0400604B RID: 24651
		private LuaFunction m_CameraFocusPositionGridPosition_hotfix;

		// Token: 0x0400604C RID: 24652
		private LuaFunction m_CameraFollowActorClientBattleActor_hotfix;

		// Token: 0x0400604D RID: 24653
		private LuaFunction m_IsCameraFocusing_hotfix;

		// Token: 0x0400604E RID: 24654
		private LuaFunction m_ComputeTotalHealthPointInt32_hotfix;

		// Token: 0x0400604F RID: 24655
		private LuaFunction m_ComputeTotalHealthPointMaxInt32_hotfix;

		// Token: 0x04006050 RID: 24656
		private LuaFunction m_EndAllActionInt32_hotfix;

		// Token: 0x04006051 RID: 24657
		private LuaFunction m_IgnoreMoveStepInt32_hotfix;

		// Token: 0x04006052 RID: 24658
		private LuaFunction m_IgnoreSkillStepInt32_hotfix;

		// Token: 0x04006053 RID: 24659
		private LuaFunction m_IgnoreTeleportDisappearStepInt32_hotfix;

		// Token: 0x04006054 RID: 24660
		private LuaFunction m_GridPositionToWorldPositionGridPosition_hotfix;

		// Token: 0x04006055 RID: 24661
		private LuaFunction m_WorldPositionToGridPositionVector2_hotfix;

		// Token: 0x04006056 RID: 24662
		private LuaFunction m_ScreenPositionToWorldPositionVector2_hotfix;

		// Token: 0x04006057 RID: 24663
		private LuaFunction m_ScreenPositionToGridPositionVector2_hotfix;

		// Token: 0x04006058 RID: 24664
		private LuaFunction m_GridPositionToScreenPositionGridPosition_hotfix;

		// Token: 0x04006059 RID: 24665
		private LuaFunction m_DrawLineVector3Vector3Color_hotfix;

		// Token: 0x0400605A RID: 24666
		private LuaFunction m_DrawMap_hotfix;

		// Token: 0x0400605B RID: 24667
		private LuaFunction m_DrawCellGridPositionBattleActorConfigDataTerrainInfo_hotfix;

		// Token: 0x0400605C RID: 24668
		private LuaFunction m_DrawGridGridPositionSingleColorBoolean_hotfix;

		// Token: 0x0400605D RID: 24669
		private LuaFunction m_CreateBattleGraphicStringSingle_hotfix;

		// Token: 0x0400605E RID: 24670
		private LuaFunction m_DestroyBattleGraphicGenericGraphic_hotfix;

		// Token: 0x0400605F RID: 24671
		private LuaFunction m_GetCurrentCamera_hotfix;

		// Token: 0x04006060 RID: 24672
		private LuaFunction m_BattleActorTryMoveBattleActorGridPositionInt32_hotfix;

		// Token: 0x04006061 RID: 24673
		private LuaFunction m_CreateActorBattleActor_hotfix;

		// Token: 0x04006062 RID: 24674
		private LuaFunction m_CreateTreasureConfigDataBattleTreasureInfoBoolean_hotfix;

		// Token: 0x04006063 RID: 24675
		private LuaFunction m_GetTreasureConfigDataBattleTreasureInfo_hotfix;

		// Token: 0x04006064 RID: 24676
		private LuaFunction m_GetNextEntityId_hotfix;

		// Token: 0x04006065 RID: 24677
		private LuaFunction m_PlayScreenEffectString_hotfix;

		// Token: 0x04006066 RID: 24678
		private LuaFunction m_CreateMapBackgroundConfigDataBattlefieldInfoGameObject_hotfix;

		// Token: 0x04006067 RID: 24679
		private LuaFunction m_ClearMapBackground_hotfix;

		// Token: 0x04006068 RID: 24680
		private LuaFunction m_CreateMapTerrainFxGameObject_hotfix;

		// Token: 0x04006069 RID: 24681
		private LuaFunction m_ClearMapTerrainFx_hotfix;

		// Token: 0x0400606A RID: 24682
		private LuaFunction m_AddMapTerrainFxGridPositionConfigDataTerrainInfoGameObject_hotfix;

		// Token: 0x0400606B RID: 24683
		private LuaFunction m_ChangeMapTerrainFxGridPositionConfigDataTerrainInfo_hotfix;

		// Token: 0x0400606C RID: 24684
		private LuaFunction m_RebuildBattleLocalProcessingBattleData_hotfix;

		// Token: 0x0400606D RID: 24685
		private LuaFunction m_RebuildBattleList;

		// Token: 0x0400606E RID: 24686
		private LuaFunction m_IsRebuildingBattle_hotfix;

		// Token: 0x0400606F RID: 24687
		private LuaFunction m_StopRebuildingBattle_hotfix;

		// Token: 0x04006070 RID: 24688
		private LuaFunction m_SetSkipCombatModeSkipCombatMode_hotfix;

		// Token: 0x04006071 RID: 24689
		private LuaFunction m_IsSkippingCombatBoolean_hotfix;

		// Token: 0x04006072 RID: 24690
		private LuaFunction m_ComputeCombatArmyRelationValueBattleActorBattleActorBoolean_hotfix;

		// Token: 0x04006073 RID: 24691
		private LuaFunction m__ComputeCombatArmyRelationValueBattleActorBattleActorBoolean_hotfix;

		// Token: 0x04006074 RID: 24692
		private LuaFunction m_IsCombatMagicAttackBattleActorBattleActorConfigDataSkillInfo_hotfix;

		// Token: 0x04006075 RID: 24693
		private LuaFunction m_EnableSdkLogBattleBoolean_hotfix;

		// Token: 0x04006076 RID: 24694
		private LuaFunction m_GetMyPlayerIndex_hotfix;

		// Token: 0x04006077 RID: 24695
		private LuaFunction m_GetMyPlayerTeamNumber_hotfix;

		// Token: 0x04006078 RID: 24696
		private LuaFunction m_get_Battle_hotfix;

		// Token: 0x04006079 RID: 24697
		private LuaFunction m_get_BattleCamera_hotfix;

		// Token: 0x0400607A RID: 24698
		private LuaFunction m_get_CombatCamera_hotfix;

		// Token: 0x0400607B RID: 24699
		private LuaFunction m_get_State_hotfix;

		// Token: 0x0400607C RID: 24700
		private LuaFunction m_set_EnableDebugDrawBoolean_hotfix;

		// Token: 0x0400607D RID: 24701
		private LuaFunction m_get_EnableDebugDraw_hotfix;

		// Token: 0x0400607E RID: 24702
		private LuaFunction m_get_IsAutoBattle_hotfix;

		// Token: 0x0400607F RID: 24703
		private LuaFunction m_get_IsFastBattle_hotfix;

		// Token: 0x04006080 RID: 24704
		private LuaFunction m_get_SkipCombatMode_hotfix;

		// Token: 0x04006081 RID: 24705
		private LuaFunction m_get_IsPaused_hotfix;

		// Token: 0x04006082 RID: 24706
		private LuaFunction m_get_BattleGraphicRoot_hotfix;

		// Token: 0x04006083 RID: 24707
		private LuaFunction m_get_CombatGraphicRoot_hotfix;

		// Token: 0x04006084 RID: 24708
		private LuaFunction m_get_MapTreasureRoot_hotfix;

		// Token: 0x04006085 RID: 24709
		private LuaFunction m_get_BattleActorUIRoot_hotfix;

		// Token: 0x04006086 RID: 24710
		private LuaFunction m_get_BattleActorUIPrefab_hotfix;

		// Token: 0x04006087 RID: 24711
		private LuaFunction m_get_BattleFxPlayer_hotfix;

		// Token: 0x04006088 RID: 24712
		private LuaFunction m_get_CombatFxPlayer_hotfix;

		// Token: 0x04006089 RID: 24713
		private LuaFunction m_get_ConfigDataLoader_hotfix;

		// Token: 0x0400608A RID: 24714
		private LuaFunction m_get_ClientBattleListener_hotfix;

		// Token: 0x0400608B RID: 24715
		private LuaFunction m_get_RandomNumber_hotfix;

		// Token: 0x0400608C RID: 24716
		private LuaFunction m_AppendActToActor_hotfix;

		// Token: 0x0400608D RID: 24717
		private LuaFunction m_AppendActsToActorInt32Type_hotfix;

		// Token: 0x0400608E RID: 24718
		private LuaFunction m_AppendActsToActorInt32TypeClientBattleActor_hotfix;

		// Token: 0x0400608F RID: 24719
		private LuaFunction m_IsAnyActorHasAct_hotfix;

		// Token: 0x04006090 RID: 24720
		private LuaFunction m_HasWaitingActBattleActorInt32_hotfix;

		// Token: 0x04006091 RID: 24721
		private LuaFunction m_OnActorActiveClientBattleActorBooleanInt32_hotfix;

		// Token: 0x04006092 RID: 24722
		private LuaFunction m_OnActorPreStartCombatClientBattleActor_hotfix;

		// Token: 0x04006093 RID: 24723
		private LuaFunction m_OnActorStopCombatEndClientBattleActor_hotfix;

		// Token: 0x04006094 RID: 24724
		private LuaFunction m_OnActorCastSkillClientBattleActorConfigDataSkillInfoGridPosition_hotfix;

		// Token: 0x04006095 RID: 24725
		private LuaFunction m_OnActorCastSkillEndClientBattleActorConfigDataSkillInfo_hotfix;

		// Token: 0x04006096 RID: 24726
		private LuaFunction m_OnBattleActorCreateBattleActorBoolean_hotfix;

		// Token: 0x04006097 RID: 24727
		private LuaFunction m_OnBattleActorCreateEndBattleActor_hotfix;

		// Token: 0x04006098 RID: 24728
		private LuaFunction m_OnBattleActorActiveBattleActorBoolean_hotfix;

		// Token: 0x04006099 RID: 24729
		private LuaFunction m_OnBattleActorActionBeginBattleActor_hotfix;

		// Token: 0x0400609A RID: 24730
		private LuaFunction m_OnBattleActorActionEndBattleActor_hotfix;

		// Token: 0x0400609B RID: 24731
		private LuaFunction m_OnBattleActorMoveBattleActorGridPositionInt32_hotfix;

		// Token: 0x0400609C RID: 24732
		private LuaFunction m_OnBattleActorPerformMoveBattleActorGridPositionInt32Boolean_hotfix;

		// Token: 0x0400609D RID: 24733
		private LuaFunction m_OnBattleActorPunchMoveBattleActorStringBoolean_hotfix;

		// Token: 0x0400609E RID: 24734
		private LuaFunction m_OnBattleActorExchangeMoveBattleActorBattleActorInt32String_hotfix;

		// Token: 0x0400609F RID: 24735
		private LuaFunction m_OnBattleActorSetDirBattleActorInt32_hotfix;

		// Token: 0x040060A0 RID: 24736
		private LuaFunction m_OnBattleActorPlayFxBattleActorStringInt32_hotfix;

		// Token: 0x040060A1 RID: 24737
		private LuaFunction m_OnBattleActorPlayAnimationBattleActorStringInt32_hotfix;

		// Token: 0x040060A2 RID: 24738
		private LuaFunction m_OnBattleActorChangeIdleAnimationBattleActorString_hotfix;

		// Token: 0x040060A3 RID: 24739
		private LuaFunction m_OnBattleActorSkillBattleActorConfigDataSkillInfoGridPosition_hotfix;

		// Token: 0x040060A4 RID: 24740
		private LuaFunction m_OnBattleActorSkillHitBeginBattleActorConfigDataSkillInfoBoolean_hotfix;

		// Token: 0x040060A5 RID: 24741
		private LuaFunction m_OnBattleActorSkillHitBattleActorConfigDataSkillInfoInt32Int32DamageNumberTypeBoolean_hotfix;

		// Token: 0x040060A6 RID: 24742
		private LuaFunction m_OnBattleActorSkillHitEndBattleActorConfigDataSkillInfoBoolean_hotfix;

		// Token: 0x040060A7 RID: 24743
		private LuaFunction m_OnBattleActorAttachBuffBattleActorBuffState_hotfix;

		// Token: 0x040060A8 RID: 24744
		private LuaFunction m_OnBattleActorDetachBuffBattleActorBuffState_hotfix;

		// Token: 0x040060A9 RID: 24745
		private LuaFunction m_OnBattleActorImmuneBattleActor_hotfix;

		// Token: 0x040060AA RID: 24746
		private LuaFunction m_OnBattleActorPassiveSkillBattleActorBattleActorBuffState_hotfix;

		// Token: 0x040060AB RID: 24747
		private LuaFunction m_OnBattleActorBuffHitBattleActorBuffStateInt32Int32DamageNumberType_hotfix;

		// Token: 0x040060AC RID: 24748
		private LuaFunction m_OnBattleActorTerrainHitBattleActorConfigDataTerrainInfoInt32Int32DamageNumberType_hotfix;

		// Token: 0x040060AD RID: 24749
		private LuaFunction m_OnBattleActorTeleportBattleActorConfigDataSkillInfoGridPosition_hotfix;

		// Token: 0x040060AE RID: 24750
		private LuaFunction m_OnBattleActorTeleportDisappearBattleActorConfigDataSkillInfoGridPosition_hotfix;

		// Token: 0x040060AF RID: 24751
		private LuaFunction m_OnBattleActorTeleportAppearBattleActorConfigDataSkillInfoGridPosition_hotfix;

		// Token: 0x040060B0 RID: 24752
		private LuaFunction m_OnBattleActorSummonBattleActorConfigDataSkillInfo_hotfix;

		// Token: 0x040060B1 RID: 24753
		private LuaFunction m_OnBattleActorDieBattleActorBoolean_hotfix;

		// Token: 0x040060B2 RID: 24754
		private LuaFunction m_OnBattleActorAppearBattleActorInt32String_hotfix;

		// Token: 0x040060B3 RID: 24755
		private LuaFunction m_OnBattleActorDisappearBattleActorInt32String_hotfix;

		// Token: 0x040060B4 RID: 24756
		private LuaFunction m_OnBattleActorChangeTeamBattleActor_hotfix;

		// Token: 0x040060B5 RID: 24757
		private LuaFunction m_OnBattleActorChangeArmyBattleActor_hotfix;

		// Token: 0x040060B6 RID: 24758
		private LuaFunction m_OnBattleActorReplaceBattleActorBattleActorString_hotfix;

		// Token: 0x040060B7 RID: 24759
		private LuaFunction m_OnBattleActorCameraFocusBattleActor_hotfix;

		// Token: 0x040060B8 RID: 24760
		private LuaFunction m_OnBattleActorGainBattleTreasureBattleActorConfigDataBattleTreasureInfo_hotfix;

		// Token: 0x040060B9 RID: 24761
		private LuaFunction m_OnStartGuardBattleActorBattleActor_hotfix;

		// Token: 0x040060BA RID: 24762
		private LuaFunction m_OnStopGuardBattleActorBattleActor_hotfix;

		// Token: 0x040060BB RID: 24763
		private LuaFunction m_OnBeforeStartCombatBattleActorBattleActorConfigDataSkillInfo_hotfix;

		// Token: 0x040060BC RID: 24764
		private LuaFunction m_OnCancelCombat_hotfix;

		// Token: 0x040060BD RID: 24765
		private LuaFunction m_OnStartCombatBattleActorBattleActorConfigDataSkillInfo_hotfix;

		// Token: 0x040060BE RID: 24766
		private LuaFunction m_OnPreStopCombat_hotfix;

		// Token: 0x040060BF RID: 24767
		private LuaFunction m_OnStopCombatInt32Int32BooleanInt32Int32Boolean_hotfix;

		// Token: 0x040060C0 RID: 24768
		private LuaFunction m_OnBattleNextTurnInt32_hotfix;

		// Token: 0x040060C1 RID: 24769
		private LuaFunction m_OnBattleNextTeamInt32Boolean_hotfix;

		// Token: 0x040060C2 RID: 24770
		private LuaFunction m_OnBattleNextPlayerInt32Int32_hotfix;

		// Token: 0x040060C3 RID: 24771
		private LuaFunction m_OnBattleNextActorBattleActor_hotfix;

		// Token: 0x040060C4 RID: 24772
		private LuaFunction m_OnCombatActorHitCombatActorCombatActorConfigDataSkillInfoInt32Int32DamageNumberType_hotfix;

		// Token: 0x040060C5 RID: 24773
		private LuaFunction m_OnCombatActorDieCombatActor_hotfix;

		// Token: 0x040060C6 RID: 24774
		private LuaFunction m_OnStartSkillCutsceneConfigDataSkillInfoConfigDataCutsceneInfoInt32_hotfix;

		// Token: 0x040060C7 RID: 24775
		private LuaFunction m_OnStartPassiveSkillCutsceneBuffStateInt32_hotfix;

		// Token: 0x040060C8 RID: 24776
		private LuaFunction m_OnStopSkillCutscene_hotfix;

		// Token: 0x040060C9 RID: 24777
		private LuaFunction m_OnStartBattleDialogConfigDataBattleDialogInfo_hotfix;

		// Token: 0x040060CA RID: 24778
		private LuaFunction m_OnStartBattlePerformConfigDataBattlePerformInfo_hotfix;

		// Token: 0x040060CB RID: 24779
		private LuaFunction m_OnStopBattlePerform_hotfix;

		// Token: 0x040060CC RID: 24780
		private LuaFunction m_OnChangeMapTerrainGridPositionConfigDataTerrainInfo_hotfix;

		// Token: 0x040060CD RID: 24781
		private LuaFunction m_OnCameraFocusGridPosition_hotfix;

		// Token: 0x040060CE RID: 24782
		private LuaFunction m_OnPlayMusicString_hotfix;

		// Token: 0x040060CF RID: 24783
		private LuaFunction m_OnPlaySoundString_hotfix;

		// Token: 0x040060D0 RID: 24784
		private LuaFunction m_OnPlayFxStringGridPosition_hotfix;

		// Token: 0x040060D1 RID: 24785
		private LuaFunction m_OnWaitTimeInt32_hotfix;

		// Token: 0x040060D2 RID: 24786
		private LuaFunction m_OnBattleTreasureCreateConfigDataBattleTreasureInfoBoolean_hotfix;

		// Token: 0x040060D3 RID: 24787
		private LuaFunction m_CreateCombatGraphicStringSingle_hotfix;

		// Token: 0x040060D4 RID: 24788
		private LuaFunction m_DestroyCombatGraphicIBattleGraphic_hotfix;

		// Token: 0x040060D5 RID: 24789
		private LuaFunction m_PlayFxStringSingle_hotfix;

		// Token: 0x040060D6 RID: 24790
		private LuaFunction m_PlaySoundString_hotfix;

		// Token: 0x040060D7 RID: 24791
		private LuaFunction m_PlaySoundSoundTableId_hotfix;

		// Token: 0x040060D8 RID: 24792
		private LuaFunction m_DrawLineVector2iVector2iColori_hotfix;

		// Token: 0x040060D9 RID: 24793
		private LuaFunction m_DrawLineVector2iFix64Vector2iFix64Colori_hotfix;

		// Token: 0x040060DA RID: 24794
		private LuaFunction m_IsCombatGraphicMirrorX_hotfix;

		// Token: 0x040060DB RID: 24795
		private LuaFunction m_OnAudioFxEventAudioClip_hotfix;

		// Token: 0x040060DC RID: 24796
		private LuaFunction m_OnSoundFxEventString_hotfix;

		// Token: 0x040060DD RID: 24797
		private LuaFunction m_OnCameraEffectFxEventString_hotfix;

		// Token: 0x040060DE RID: 24798
		private LuaFunction m_OnScreenEffectFxEventString_hotfix;

		// Token: 0x040060DF RID: 24799
		private LuaFunction m_OnGeneralFxEventString_hotfix;

		// Token: 0x040060E0 RID: 24800
		private LuaFunction m_GetCameraPosition_hotfix;

		// Token: 0x040060E1 RID: 24801
		private LuaFunction m_CombatPositionToWorldPositionVector2iFix64Boolean_hotfix;

		// Token: 0x040060E2 RID: 24802
		private LuaFunction m_IsCulledVector2Vector2Boolean_hotfix;

		// Token: 0x040060E3 RID: 24803
		private LuaFunction m_LogBattleStart_hotfix;

		// Token: 0x040060E4 RID: 24804
		private LuaFunction m_LogBattleStopBoolean_hotfix;

		// Token: 0x040060E5 RID: 24805
		private LuaFunction m_LogBattleTeamBattleTeamBattleTeam_hotfix;

		// Token: 0x040060E6 RID: 24806
		private LuaFunction m_LogActorMoveBattleActorGridPositionGridPosition_hotfix;

		// Token: 0x040060E7 RID: 24807
		private LuaFunction m_LogActorStandbyBattleActor_hotfix;

		// Token: 0x040060E8 RID: 24808
		private LuaFunction m_LogActorAttackBattleActorBattleActor_hotfix;

		// Token: 0x040060E9 RID: 24809
		private LuaFunction m_LogActorSkillBattleActorConfigDataSkillInfoBattleActorGridPosition_hotfix;

		// Token: 0x040060EA RID: 24810
		private LuaFunction m_LogActorDieBattleActorBattleActor_hotfix;

		// Token: 0x040060EB RID: 24811
		private LuaFunction m_SdkLogBattleStringObject_hotfix;

		// Token: 0x0200091E RID: 2334
		[CustomLuaClass]
		public class LogDataBattleStart
		{
			// Token: 0x040060EC RID: 24812
			public string Type = "BattleStart";

			// Token: 0x040060ED RID: 24813
			public int BattleId;
		}

		// Token: 0x0200091F RID: 2335
		[CustomLuaClass]
		public class LogDataArenaBattleStart
		{
			// Token: 0x040060EE RID: 24814
			public string Type = "ArenaBattleStart";

			// Token: 0x040060EF RID: 24815
			public int ArenaBattleId;
		}

		// Token: 0x02000920 RID: 2336
		[CustomLuaClass]
		public class LogDataPVPBattleStart
		{
			// Token: 0x040060F0 RID: 24816
			public string Type = "PVPBattleStart";

			// Token: 0x040060F1 RID: 24817
			public int PVPBattleId;
		}

		// Token: 0x02000921 RID: 2337
		[CustomLuaClass]
		public class LogDataRealTimePVPBattleStart
		{
			// Token: 0x040060F2 RID: 24818
			public string Type = "RealTimePVPBattleStart";

			// Token: 0x040060F3 RID: 24819
			public int RealTimePVPBattleId;
		}

		// Token: 0x02000922 RID: 2338
		[CustomLuaClass]
		public class LogDataBattleStop
		{
			// Token: 0x040060F4 RID: 24820
			public string Type = "BattleStop";

			// Token: 0x040060F5 RID: 24821
			public bool IsWin;
		}

		// Token: 0x02000923 RID: 2339
		[CustomLuaClass]
		public class LogDataBattleTeam
		{
			// Token: 0x040060F6 RID: 24822
			public string Type = "Team";

			// Token: 0x040060F7 RID: 24823
			public List<int> HeroId = new List<int>();

			// Token: 0x040060F8 RID: 24824
			public List<GridPosition> Pos = new List<GridPosition>();
		}

		// Token: 0x02000924 RID: 2340
		[CustomLuaClass]
		public class LogDataActorMove
		{
			// Token: 0x040060F9 RID: 24825
			public string Type = "Move";

			// Token: 0x040060FA RID: 24826
			public int Turn;

			// Token: 0x040060FB RID: 24827
			public int HeroId;

			// Token: 0x040060FC RID: 24828
			public GridPosition FromPos;

			// Token: 0x040060FD RID: 24829
			public GridPosition ToPos;
		}

		// Token: 0x02000925 RID: 2341
		[CustomLuaClass]
		public class LogDataActorStandby
		{
			// Token: 0x040060FE RID: 24830
			public string Type = "Standby";

			// Token: 0x040060FF RID: 24831
			public int Turn;

			// Token: 0x04006100 RID: 24832
			public int HeroId;

			// Token: 0x04006101 RID: 24833
			public GridPosition Pos;
		}

		// Token: 0x02000926 RID: 2342
		[CustomLuaClass]
		public class LogDataActorAttack
		{
			// Token: 0x04006102 RID: 24834
			public string Type = "Attack";

			// Token: 0x04006103 RID: 24835
			public int Turn;

			// Token: 0x04006104 RID: 24836
			public int HeroId;

			// Token: 0x04006105 RID: 24837
			public int TargetHeroId;

			// Token: 0x04006106 RID: 24838
			public GridPosition TargetPos;
		}

		// Token: 0x02000927 RID: 2343
		[CustomLuaClass]
		public class LogDataActorSkill
		{
			// Token: 0x04006107 RID: 24839
			public string Type = "Skill";

			// Token: 0x04006108 RID: 24840
			public int Turn;

			// Token: 0x04006109 RID: 24841
			public int HeroId;

			// Token: 0x0400610A RID: 24842
			public int TargetHeroId;

			// Token: 0x0400610B RID: 24843
			public GridPosition TargetPos;

			// Token: 0x0400610C RID: 24844
			public int SkillId;
		}

		// Token: 0x02000928 RID: 2344
		[CustomLuaClass]
		public class LogDataActorDie
		{
			// Token: 0x0400610D RID: 24845
			public string Type = "Die";

			// Token: 0x0400610E RID: 24846
			public int Turn;

			// Token: 0x0400610F RID: 24847
			public int HeroId;

			// Token: 0x04006110 RID: 24848
			public int KillerHeroId;
		}

		// Token: 0x02000929 RID: 2345
		public class LuaExportHelper
		{
			// Token: 0x060087B0 RID: 34736 RVA: 0x002787BC File Offset: 0x002769BC
			public LuaExportHelper(ClientBattle owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17001C78 RID: 7288
			// (get) Token: 0x060087B1 RID: 34737 RVA: 0x002787CC File Offset: 0x002769CC
			// (set) Token: 0x060087B2 RID: 34738 RVA: 0x002787DC File Offset: 0x002769DC
			public ClientBattleState m_state
			{
				get
				{
					return this.m_owner.m_state;
				}
				set
				{
					this.m_owner.m_state = value;
				}
			}

			// Token: 0x17001C79 RID: 7289
			// (get) Token: 0x060087B3 RID: 34739 RVA: 0x002787EC File Offset: 0x002769EC
			// (set) Token: 0x060087B4 RID: 34740 RVA: 0x002787FC File Offset: 0x002769FC
			public int m_entityIdCounter
			{
				get
				{
					return this.m_owner.m_entityIdCounter;
				}
				set
				{
					this.m_owner.m_entityIdCounter = value;
				}
			}

			// Token: 0x17001C7A RID: 7290
			// (get) Token: 0x060087B5 RID: 34741 RVA: 0x0027880C File Offset: 0x00276A0C
			// (set) Token: 0x060087B6 RID: 34742 RVA: 0x0027881C File Offset: 0x00276A1C
			public bool m_isStopBattleWin
			{
				get
				{
					return this.m_owner.m_isStopBattleWin;
				}
				set
				{
					this.m_owner.m_isStopBattleWin = value;
				}
			}

			// Token: 0x17001C7B RID: 7291
			// (get) Token: 0x060087B7 RID: 34743 RVA: 0x0027882C File Offset: 0x00276A2C
			// (set) Token: 0x060087B8 RID: 34744 RVA: 0x0027883C File Offset: 0x00276A3C
			public int m_frameCount
			{
				get
				{
					return this.m_owner.m_frameCount;
				}
				set
				{
					this.m_owner.m_frameCount = value;
				}
			}

			// Token: 0x17001C7C RID: 7292
			// (get) Token: 0x060087B9 RID: 34745 RVA: 0x0027884C File Offset: 0x00276A4C
			// (set) Token: 0x060087BA RID: 34746 RVA: 0x0027885C File Offset: 0x00276A5C
			public int m_endCountdown
			{
				get
				{
					return this.m_owner.m_endCountdown;
				}
				set
				{
					this.m_owner.m_endCountdown = value;
				}
			}

			// Token: 0x17001C7D RID: 7293
			// (get) Token: 0x060087BB RID: 34747 RVA: 0x0027886C File Offset: 0x00276A6C
			// (set) Token: 0x060087BC RID: 34748 RVA: 0x0027887C File Offset: 0x00276A7C
			public int m_cutscenePauseCountdown
			{
				get
				{
					return this.m_owner.m_cutscenePauseCountdown;
				}
				set
				{
					this.m_owner.m_cutscenePauseCountdown = value;
				}
			}

			// Token: 0x17001C7E RID: 7294
			// (get) Token: 0x060087BD RID: 34749 RVA: 0x0027888C File Offset: 0x00276A8C
			// (set) Token: 0x060087BE RID: 34750 RVA: 0x0027889C File Offset: 0x00276A9C
			public int m_restoreNonSkillTargetsCountdown
			{
				get
				{
					return this.m_owner.m_restoreNonSkillTargetsCountdown;
				}
				set
				{
					this.m_owner.m_restoreNonSkillTargetsCountdown = value;
				}
			}

			// Token: 0x17001C7F RID: 7295
			// (get) Token: 0x060087BF RID: 34751 RVA: 0x002788AC File Offset: 0x00276AAC
			// (set) Token: 0x060087C0 RID: 34752 RVA: 0x002788BC File Offset: 0x00276ABC
			public string m_tickSoundName
			{
				get
				{
					return this.m_owner.m_tickSoundName;
				}
				set
				{
					this.m_owner.m_tickSoundName = value;
				}
			}

			// Token: 0x17001C80 RID: 7296
			// (get) Token: 0x060087C1 RID: 34753 RVA: 0x002788CC File Offset: 0x00276ACC
			// (set) Token: 0x060087C2 RID: 34754 RVA: 0x002788DC File Offset: 0x00276ADC
			public float m_battleTickTime
			{
				get
				{
					return this.m_owner.m_battleTickTime;
				}
				set
				{
					this.m_owner.m_battleTickTime = value;
				}
			}

			// Token: 0x17001C81 RID: 7297
			// (get) Token: 0x060087C3 RID: 34755 RVA: 0x002788EC File Offset: 0x00276AEC
			// (set) Token: 0x060087C4 RID: 34756 RVA: 0x002788FC File Offset: 0x00276AFC
			public float m_combatTickTime
			{
				get
				{
					return this.m_owner.m_combatTickTime;
				}
				set
				{
					this.m_owner.m_combatTickTime = value;
				}
			}

			// Token: 0x17001C82 RID: 7298
			// (get) Token: 0x060087C5 RID: 34757 RVA: 0x0027890C File Offset: 0x00276B0C
			// (set) Token: 0x060087C6 RID: 34758 RVA: 0x0027891C File Offset: 0x00276B1C
			public float m_timeScale
			{
				get
				{
					return this.m_owner.m_timeScale;
				}
				set
				{
					this.m_owner.m_timeScale = value;
				}
			}

			// Token: 0x17001C83 RID: 7299
			// (get) Token: 0x060087C7 RID: 34759 RVA: 0x0027892C File Offset: 0x00276B2C
			// (set) Token: 0x060087C8 RID: 34760 RVA: 0x0027893C File Offset: 0x00276B3C
			public float m_globalTimeScale
			{
				get
				{
					return this.m_owner.m_globalTimeScale;
				}
				set
				{
					this.m_owner.m_globalTimeScale = value;
				}
			}

			// Token: 0x17001C84 RID: 7300
			// (get) Token: 0x060087C9 RID: 34761 RVA: 0x0027894C File Offset: 0x00276B4C
			// (set) Token: 0x060087CA RID: 34762 RVA: 0x0027895C File Offset: 0x00276B5C
			public SlowMotionState m_slowMotionState
			{
				get
				{
					return this.m_owner.m_slowMotionState;
				}
				set
				{
					this.m_owner.m_slowMotionState = value;
				}
			}

			// Token: 0x17001C85 RID: 7301
			// (get) Token: 0x060087CB RID: 34763 RVA: 0x0027896C File Offset: 0x00276B6C
			// (set) Token: 0x060087CC RID: 34764 RVA: 0x0027897C File Offset: 0x00276B7C
			public float m_slowMotionCountdown
			{
				get
				{
					return this.m_owner.m_slowMotionCountdown;
				}
				set
				{
					this.m_owner.m_slowMotionCountdown = value;
				}
			}

			// Token: 0x17001C86 RID: 7302
			// (get) Token: 0x060087CD RID: 34765 RVA: 0x0027898C File Offset: 0x00276B8C
			// (set) Token: 0x060087CE RID: 34766 RVA: 0x0027899C File Offset: 0x00276B9C
			public bool m_isPaused
			{
				get
				{
					return this.m_owner.m_isPaused;
				}
				set
				{
					this.m_owner.m_isPaused = value;
				}
			}

			// Token: 0x17001C87 RID: 7303
			// (get) Token: 0x060087CF RID: 34767 RVA: 0x002789AC File Offset: 0x00276BAC
			// (set) Token: 0x060087D0 RID: 34768 RVA: 0x002789BC File Offset: 0x00276BBC
			public bool m_isAutoBattle
			{
				get
				{
					return this.m_owner.m_isAutoBattle;
				}
				set
				{
					this.m_owner.m_isAutoBattle = value;
				}
			}

			// Token: 0x17001C88 RID: 7304
			// (get) Token: 0x060087D1 RID: 34769 RVA: 0x002789CC File Offset: 0x00276BCC
			// (set) Token: 0x060087D2 RID: 34770 RVA: 0x002789DC File Offset: 0x00276BDC
			public bool m_isFastBattle
			{
				get
				{
					return this.m_owner.m_isFastBattle;
				}
				set
				{
					this.m_owner.m_isFastBattle = value;
				}
			}

			// Token: 0x17001C89 RID: 7305
			// (get) Token: 0x060087D3 RID: 34771 RVA: 0x002789EC File Offset: 0x00276BEC
			// (set) Token: 0x060087D4 RID: 34772 RVA: 0x002789FC File Offset: 0x00276BFC
			public bool m_isEnableDebugDraw
			{
				get
				{
					return this.m_owner.m_isEnableDebugDraw;
				}
				set
				{
					this.m_owner.m_isEnableDebugDraw = value;
				}
			}

			// Token: 0x17001C8A RID: 7306
			// (get) Token: 0x060087D5 RID: 34773 RVA: 0x00278A0C File Offset: 0x00276C0C
			// (set) Token: 0x060087D6 RID: 34774 RVA: 0x00278A1C File Offset: 0x00276C1C
			public bool m_isEnableSdkLogBattle
			{
				get
				{
					return this.m_owner.m_isEnableSdkLogBattle;
				}
				set
				{
					this.m_owner.m_isEnableSdkLogBattle = value;
				}
			}

			// Token: 0x17001C8B RID: 7307
			// (get) Token: 0x060087D7 RID: 34775 RVA: 0x00278A2C File Offset: 0x00276C2C
			// (set) Token: 0x060087D8 RID: 34776 RVA: 0x00278A3C File Offset: 0x00276C3C
			public RandomNumber m_randomNumber
			{
				get
				{
					return this.m_owner.m_randomNumber;
				}
				set
				{
					this.m_owner.m_randomNumber = value;
				}
			}

			// Token: 0x17001C8C RID: 7308
			// (get) Token: 0x060087D9 RID: 34777 RVA: 0x00278A4C File Offset: 0x00276C4C
			// (set) Token: 0x060087DA RID: 34778 RVA: 0x00278A5C File Offset: 0x00276C5C
			public BattleBase m_battle
			{
				get
				{
					return this.m_owner.m_battle;
				}
				set
				{
					this.m_owner.m_battle = value;
				}
			}

			// Token: 0x17001C8D RID: 7309
			// (get) Token: 0x060087DB RID: 34779 RVA: 0x00278A6C File Offset: 0x00276C6C
			// (set) Token: 0x060087DC RID: 34780 RVA: 0x00278A7C File Offset: 0x00276C7C
			public ClientBattleActor m_nullActor
			{
				get
				{
					return this.m_owner.m_nullActor;
				}
				set
				{
					this.m_owner.m_nullActor = value;
				}
			}

			// Token: 0x17001C8E RID: 7310
			// (get) Token: 0x060087DD RID: 34781 RVA: 0x00278A8C File Offset: 0x00276C8C
			// (set) Token: 0x060087DE RID: 34782 RVA: 0x00278A9C File Offset: 0x00276C9C
			public List<ClientBattleActor> m_actors
			{
				get
				{
					return this.m_owner.m_actors;
				}
				set
				{
					this.m_owner.m_actors = value;
				}
			}

			// Token: 0x17001C8F RID: 7311
			// (get) Token: 0x060087DF RID: 34783 RVA: 0x00278AAC File Offset: 0x00276CAC
			// (set) Token: 0x060087E0 RID: 34784 RVA: 0x00278ABC File Offset: 0x00276CBC
			public ClientBattleActor m_activeActor
			{
				get
				{
					return this.m_owner.m_activeActor;
				}
				set
				{
					this.m_owner.m_activeActor = value;
				}
			}

			// Token: 0x17001C90 RID: 7312
			// (get) Token: 0x060087E1 RID: 34785 RVA: 0x00278ACC File Offset: 0x00276CCC
			// (set) Token: 0x060087E2 RID: 34786 RVA: 0x00278ADC File Offset: 0x00276CDC
			public ClientBattleActor m_cameraFollowActor
			{
				get
				{
					return this.m_owner.m_cameraFollowActor;
				}
				set
				{
					this.m_owner.m_cameraFollowActor = value;
				}
			}

			// Token: 0x17001C91 RID: 7313
			// (get) Token: 0x060087E3 RID: 34787 RVA: 0x00278AEC File Offset: 0x00276CEC
			// (set) Token: 0x060087E4 RID: 34788 RVA: 0x00278AFC File Offset: 0x00276CFC
			public List<ClientActorAct> m_actorActs
			{
				get
				{
					return this.m_owner.m_actorActs;
				}
				set
				{
					this.m_owner.m_actorActs = value;
				}
			}

			// Token: 0x17001C92 RID: 7314
			// (get) Token: 0x060087E5 RID: 34789 RVA: 0x00278B0C File Offset: 0x00276D0C
			// (set) Token: 0x060087E6 RID: 34790 RVA: 0x00278B1C File Offset: 0x00276D1C
			public List<ClientBattleTreasure> m_treasures
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

			// Token: 0x17001C93 RID: 7315
			// (get) Token: 0x060087E7 RID: 34791 RVA: 0x00278B2C File Offset: 0x00276D2C
			// (set) Token: 0x060087E8 RID: 34792 RVA: 0x00278B3C File Offset: 0x00276D3C
			public List<int> m_enforceActionOrderHeroIds
			{
				get
				{
					return this.m_owner.m_enforceActionOrderHeroIds;
				}
				set
				{
					this.m_owner.m_enforceActionOrderHeroIds = value;
				}
			}

			// Token: 0x17001C94 RID: 7316
			// (get) Token: 0x060087E9 RID: 34793 RVA: 0x00278B4C File Offset: 0x00276D4C
			// (set) Token: 0x060087EA RID: 34794 RVA: 0x00278B5C File Offset: 0x00276D5C
			public BattleActor m_combatingBattleActorA
			{
				get
				{
					return this.m_owner.m_combatingBattleActorA;
				}
				set
				{
					this.m_owner.m_combatingBattleActorA = value;
				}
			}

			// Token: 0x17001C95 RID: 7317
			// (get) Token: 0x060087EB RID: 34795 RVA: 0x00278B6C File Offset: 0x00276D6C
			// (set) Token: 0x060087EC RID: 34796 RVA: 0x00278B7C File Offset: 0x00276D7C
			public BattleActor m_combatingBattleActorB
			{
				get
				{
					return this.m_owner.m_combatingBattleActorB;
				}
				set
				{
					this.m_owner.m_combatingBattleActorB = value;
				}
			}

			// Token: 0x17001C96 RID: 7318
			// (get) Token: 0x060087ED RID: 34797 RVA: 0x00278B8C File Offset: 0x00276D8C
			// (set) Token: 0x060087EE RID: 34798 RVA: 0x00278B9C File Offset: 0x00276D9C
			public ConfigDataSkillInfo m_combatSkillInfoA
			{
				get
				{
					return this.m_owner.m_combatSkillInfoA;
				}
				set
				{
					this.m_owner.m_combatSkillInfoA = value;
				}
			}

			// Token: 0x17001C97 RID: 7319
			// (get) Token: 0x060087EF RID: 34799 RVA: 0x00278BAC File Offset: 0x00276DAC
			// (set) Token: 0x060087F0 RID: 34800 RVA: 0x00278BBC File Offset: 0x00276DBC
			public int m_ignoreMoveStep
			{
				get
				{
					return this.m_owner.m_ignoreMoveStep;
				}
				set
				{
					this.m_owner.m_ignoreMoveStep = value;
				}
			}

			// Token: 0x17001C98 RID: 7320
			// (get) Token: 0x060087F1 RID: 34801 RVA: 0x00278BCC File Offset: 0x00276DCC
			// (set) Token: 0x060087F2 RID: 34802 RVA: 0x00278BDC File Offset: 0x00276DDC
			public int m_ignoreSkillStep
			{
				get
				{
					return this.m_owner.m_ignoreSkillStep;
				}
				set
				{
					this.m_owner.m_ignoreSkillStep = value;
				}
			}

			// Token: 0x17001C99 RID: 7321
			// (get) Token: 0x060087F3 RID: 34803 RVA: 0x00278BEC File Offset: 0x00276DEC
			// (set) Token: 0x060087F4 RID: 34804 RVA: 0x00278BFC File Offset: 0x00276DFC
			public int m_ignoreTeleportDisappearStep
			{
				get
				{
					return this.m_owner.m_ignoreTeleportDisappearStep;
				}
				set
				{
					this.m_owner.m_ignoreTeleportDisappearStep = value;
				}
			}

			// Token: 0x17001C9A RID: 7322
			// (get) Token: 0x060087F5 RID: 34805 RVA: 0x00278C0C File Offset: 0x00276E0C
			// (set) Token: 0x060087F6 RID: 34806 RVA: 0x00278C1C File Offset: 0x00276E1C
			public int m_ignoreActiveTeam
			{
				get
				{
					return this.m_owner.m_ignoreActiveTeam;
				}
				set
				{
					this.m_owner.m_ignoreActiveTeam = value;
				}
			}

			// Token: 0x17001C9B RID: 7323
			// (get) Token: 0x060087F7 RID: 34807 RVA: 0x00278C2C File Offset: 0x00276E2C
			// (set) Token: 0x060087F8 RID: 34808 RVA: 0x00278C3C File Offset: 0x00276E3C
			public int m_ignoreActiveTurn
			{
				get
				{
					return this.m_owner.m_ignoreActiveTurn;
				}
				set
				{
					this.m_owner.m_ignoreActiveTurn = value;
				}
			}

			// Token: 0x17001C9C RID: 7324
			// (get) Token: 0x060087F9 RID: 34809 RVA: 0x00278C4C File Offset: 0x00276E4C
			// (set) Token: 0x060087FA RID: 34810 RVA: 0x00278C5C File Offset: 0x00276E5C
			public ClientActorActSkillHit m_actorActSkillHit
			{
				get
				{
					return this.m_owner.m_actorActSkillHit;
				}
				set
				{
					this.m_owner.m_actorActSkillHit = value;
				}
			}

			// Token: 0x17001C9D RID: 7325
			// (get) Token: 0x060087FB RID: 34811 RVA: 0x00278C6C File Offset: 0x00276E6C
			// (set) Token: 0x060087FC RID: 34812 RVA: 0x00278C7C File Offset: 0x00276E7C
			public ClientActorActSkillHit m_actorActSkillRebound
			{
				get
				{
					return this.m_owner.m_actorActSkillRebound;
				}
				set
				{
					this.m_owner.m_actorActSkillRebound = value;
				}
			}

			// Token: 0x17001C9E RID: 7326
			// (get) Token: 0x060087FD RID: 34813 RVA: 0x00278C8C File Offset: 0x00276E8C
			// (set) Token: 0x060087FE RID: 34814 RVA: 0x00278C9C File Offset: 0x00276E9C
			public ConfigDataBattleDialogInfo m_curBattleDialogInfo
			{
				get
				{
					return this.m_owner.m_curBattleDialogInfo;
				}
				set
				{
					this.m_owner.m_curBattleDialogInfo = value;
				}
			}

			// Token: 0x17001C9F RID: 7327
			// (get) Token: 0x060087FF RID: 34815 RVA: 0x00278CAC File Offset: 0x00276EAC
			// (set) Token: 0x06008800 RID: 34816 RVA: 0x00278CBC File Offset: 0x00276EBC
			public int m_battleDialogResult
			{
				get
				{
					return this.m_owner.m_battleDialogResult;
				}
				set
				{
					this.m_owner.m_battleDialogResult = value;
				}
			}

			// Token: 0x17001CA0 RID: 7328
			// (get) Token: 0x06008801 RID: 34817 RVA: 0x00278CCC File Offset: 0x00276ECC
			// (set) Token: 0x06008802 RID: 34818 RVA: 0x00278CDC File Offset: 0x00276EDC
			public bool m_isWaitBattleTreasureDialog
			{
				get
				{
					return this.m_owner.m_isWaitBattleTreasureDialog;
				}
				set
				{
					this.m_owner.m_isWaitBattleTreasureDialog = value;
				}
			}

			// Token: 0x17001CA1 RID: 7329
			// (get) Token: 0x06008803 RID: 34819 RVA: 0x00278CEC File Offset: 0x00276EEC
			// (set) Token: 0x06008804 RID: 34820 RVA: 0x00278CFC File Offset: 0x00276EFC
			public bool m_isWaitBattleTreasureReward
			{
				get
				{
					return this.m_owner.m_isWaitBattleTreasureReward;
				}
				set
				{
					this.m_owner.m_isWaitBattleTreasureReward = value;
				}
			}

			// Token: 0x17001CA2 RID: 7330
			// (get) Token: 0x06008805 RID: 34821 RVA: 0x00278D0C File Offset: 0x00276F0C
			// (set) Token: 0x06008806 RID: 34822 RVA: 0x00278D1C File Offset: 0x00276F1C
			public bool m_isWaitFastCombat
			{
				get
				{
					return this.m_owner.m_isWaitFastCombat;
				}
				set
				{
					this.m_owner.m_isWaitFastCombat = value;
				}
			}

			// Token: 0x17001CA3 RID: 7331
			// (get) Token: 0x06008807 RID: 34823 RVA: 0x00278D2C File Offset: 0x00276F2C
			// (set) Token: 0x06008808 RID: 34824 RVA: 0x00278D3C File Offset: 0x00276F3C
			public bool m_isBattlePerforming
			{
				get
				{
					return this.m_owner.m_isBattlePerforming;
				}
				set
				{
					this.m_owner.m_isBattlePerforming = value;
				}
			}

			// Token: 0x17001CA4 RID: 7332
			// (get) Token: 0x06008809 RID: 34825 RVA: 0x00278D4C File Offset: 0x00276F4C
			// (set) Token: 0x0600880A RID: 34826 RVA: 0x00278D5C File Offset: 0x00276F5C
			public int m_myPlayerIndex
			{
				get
				{
					return this.m_owner.m_myPlayerIndex;
				}
				set
				{
					this.m_owner.m_myPlayerIndex = value;
				}
			}

			// Token: 0x17001CA5 RID: 7333
			// (get) Token: 0x0600880B RID: 34827 RVA: 0x00278D6C File Offset: 0x00276F6C
			// (set) Token: 0x0600880C RID: 34828 RVA: 0x00278D7C File Offset: 0x00276F7C
			public int m_myPlayerTeam
			{
				get
				{
					return this.m_owner.m_myPlayerTeam;
				}
				set
				{
					this.m_owner.m_myPlayerTeam = value;
				}
			}

			// Token: 0x17001CA6 RID: 7334
			// (get) Token: 0x0600880D RID: 34829 RVA: 0x00278D8C File Offset: 0x00276F8C
			// (set) Token: 0x0600880E RID: 34830 RVA: 0x00278D9C File Offset: 0x00276F9C
			public int m_rebuildBattleStepMax
			{
				get
				{
					return this.m_owner.m_rebuildBattleStepMax;
				}
				set
				{
					this.m_owner.m_rebuildBattleStepMax = value;
				}
			}

			// Token: 0x17001CA7 RID: 7335
			// (get) Token: 0x0600880F RID: 34831 RVA: 0x00278DAC File Offset: 0x00276FAC
			// (set) Token: 0x06008810 RID: 34832 RVA: 0x00278DBC File Offset: 0x00276FBC
			public SkipCombatMode m_skipCombatMode
			{
				get
				{
					return this.m_owner.m_skipCombatMode;
				}
				set
				{
					this.m_owner.m_skipCombatMode = value;
				}
			}

			// Token: 0x17001CA8 RID: 7336
			// (get) Token: 0x06008811 RID: 34833 RVA: 0x00278DCC File Offset: 0x00276FCC
			// (set) Token: 0x06008812 RID: 34834 RVA: 0x00278DDC File Offset: 0x00276FDC
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

			// Token: 0x17001CA9 RID: 7337
			// (get) Token: 0x06008813 RID: 34835 RVA: 0x00278DEC File Offset: 0x00276FEC
			// (set) Token: 0x06008814 RID: 34836 RVA: 0x00278DFC File Offset: 0x00276FFC
			public IClientBattleListener m_clientBattleListener
			{
				get
				{
					return this.m_owner.m_clientBattleListener;
				}
				set
				{
					this.m_owner.m_clientBattleListener = value;
				}
			}

			// Token: 0x17001CAA RID: 7338
			// (get) Token: 0x06008815 RID: 34837 RVA: 0x00278E0C File Offset: 0x0027700C
			// (set) Token: 0x06008816 RID: 34838 RVA: 0x00278E1C File Offset: 0x0027701C
			public ConfigDataBattleInfo m_battleInfo
			{
				get
				{
					return this.m_owner.m_battleInfo;
				}
				set
				{
					this.m_owner.m_battleInfo = value;
				}
			}

			// Token: 0x17001CAB RID: 7339
			// (get) Token: 0x06008817 RID: 34839 RVA: 0x00278E2C File Offset: 0x0027702C
			// (set) Token: 0x06008818 RID: 34840 RVA: 0x00278E3C File Offset: 0x0027703C
			public ConfigDataArenaBattleInfo m_arenaBattleInfo
			{
				get
				{
					return this.m_owner.m_arenaBattleInfo;
				}
				set
				{
					this.m_owner.m_arenaBattleInfo = value;
				}
			}

			// Token: 0x17001CAC RID: 7340
			// (get) Token: 0x06008819 RID: 34841 RVA: 0x00278E4C File Offset: 0x0027704C
			// (set) Token: 0x0600881A RID: 34842 RVA: 0x00278E5C File Offset: 0x0027705C
			public ConfigDataPVPBattleInfo m_pvpBattleInfo
			{
				get
				{
					return this.m_owner.m_pvpBattleInfo;
				}
				set
				{
					this.m_owner.m_pvpBattleInfo = value;
				}
			}

			// Token: 0x17001CAD RID: 7341
			// (get) Token: 0x0600881B RID: 34843 RVA: 0x00278E6C File Offset: 0x0027706C
			// (set) Token: 0x0600881C RID: 34844 RVA: 0x00278E7C File Offset: 0x0027707C
			public ConfigDataRealTimePVPBattleInfo m_realtimePvpBattleInfo
			{
				get
				{
					return this.m_owner.m_realtimePvpBattleInfo;
				}
				set
				{
					this.m_owner.m_realtimePvpBattleInfo = value;
				}
			}

			// Token: 0x17001CAE RID: 7342
			// (get) Token: 0x0600881D RID: 34845 RVA: 0x00278E8C File Offset: 0x0027708C
			// (set) Token: 0x0600881E RID: 34846 RVA: 0x00278E9C File Offset: 0x0027709C
			public BattleType m_battleType
			{
				get
				{
					return this.m_owner.m_battleType;
				}
				set
				{
					this.m_owner.m_battleType = value;
				}
			}

			// Token: 0x17001CAF RID: 7343
			// (get) Token: 0x0600881F RID: 34847 RVA: 0x00278EAC File Offset: 0x002770AC
			// (set) Token: 0x06008820 RID: 34848 RVA: 0x00278EBC File Offset: 0x002770BC
			public BattleCamera m_battleCamera
			{
				get
				{
					return this.m_owner.m_battleCamera;
				}
				set
				{
					this.m_owner.m_battleCamera = value;
				}
			}

			// Token: 0x17001CB0 RID: 7344
			// (get) Token: 0x06008821 RID: 34849 RVA: 0x00278ECC File Offset: 0x002770CC
			// (set) Token: 0x06008822 RID: 34850 RVA: 0x00278EDC File Offset: 0x002770DC
			public CombatCamera m_combatCamera
			{
				get
				{
					return this.m_owner.m_combatCamera;
				}
				set
				{
					this.m_owner.m_combatCamera = value;
				}
			}

			// Token: 0x17001CB1 RID: 7345
			// (get) Token: 0x06008823 RID: 34851 RVA: 0x00278EEC File Offset: 0x002770EC
			// (set) Token: 0x06008824 RID: 34852 RVA: 0x00278EFC File Offset: 0x002770FC
			public CutsceneCamera m_cutsceneCamera
			{
				get
				{
					return this.m_owner.m_cutsceneCamera;
				}
				set
				{
					this.m_owner.m_cutsceneCamera = value;
				}
			}

			// Token: 0x17001CB2 RID: 7346
			// (get) Token: 0x06008825 RID: 34853 RVA: 0x00278F0C File Offset: 0x0027710C
			// (set) Token: 0x06008826 RID: 34854 RVA: 0x00278F1C File Offset: 0x0027711C
			public GameObject m_battleRoot
			{
				get
				{
					return this.m_owner.m_battleRoot;
				}
				set
				{
					this.m_owner.m_battleRoot = value;
				}
			}

			// Token: 0x17001CB3 RID: 7347
			// (get) Token: 0x06008827 RID: 34855 RVA: 0x00278F2C File Offset: 0x0027712C
			// (set) Token: 0x06008828 RID: 34856 RVA: 0x00278F3C File Offset: 0x0027713C
			public GameObject m_combatRoot
			{
				get
				{
					return this.m_owner.m_combatRoot;
				}
				set
				{
					this.m_owner.m_combatRoot = value;
				}
			}

			// Token: 0x17001CB4 RID: 7348
			// (get) Token: 0x06008829 RID: 34857 RVA: 0x00278F4C File Offset: 0x0027714C
			// (set) Token: 0x0600882A RID: 34858 RVA: 0x00278F5C File Offset: 0x0027715C
			public GameObject m_cutsceneRoot
			{
				get
				{
					return this.m_owner.m_cutsceneRoot;
				}
				set
				{
					this.m_owner.m_cutsceneRoot = value;
				}
			}

			// Token: 0x17001CB5 RID: 7349
			// (get) Token: 0x0600882B RID: 34859 RVA: 0x00278F6C File Offset: 0x0027716C
			// (set) Token: 0x0600882C RID: 34860 RVA: 0x00278F7C File Offset: 0x0027717C
			public GameObject m_battleGraphicRoot
			{
				get
				{
					return this.m_owner.m_battleGraphicRoot;
				}
				set
				{
					this.m_owner.m_battleGraphicRoot = value;
				}
			}

			// Token: 0x17001CB6 RID: 7350
			// (get) Token: 0x0600882D RID: 34861 RVA: 0x00278F8C File Offset: 0x0027718C
			// (set) Token: 0x0600882E RID: 34862 RVA: 0x00278F9C File Offset: 0x0027719C
			public GameObject m_combatGraphicRoot
			{
				get
				{
					return this.m_owner.m_combatGraphicRoot;
				}
				set
				{
					this.m_owner.m_combatGraphicRoot = value;
				}
			}

			// Token: 0x17001CB7 RID: 7351
			// (get) Token: 0x0600882F RID: 34863 RVA: 0x00278FAC File Offset: 0x002771AC
			// (set) Token: 0x06008830 RID: 34864 RVA: 0x00278FBC File Offset: 0x002771BC
			public GameObject m_cutsceneGraphicRoot
			{
				get
				{
					return this.m_owner.m_cutsceneGraphicRoot;
				}
				set
				{
					this.m_owner.m_cutsceneGraphicRoot = value;
				}
			}

			// Token: 0x17001CB8 RID: 7352
			// (get) Token: 0x06008831 RID: 34865 RVA: 0x00278FCC File Offset: 0x002771CC
			// (set) Token: 0x06008832 RID: 34866 RVA: 0x00278FDC File Offset: 0x002771DC
			public GameObject m_mapRoot
			{
				get
				{
					return this.m_owner.m_mapRoot;
				}
				set
				{
					this.m_owner.m_mapRoot = value;
				}
			}

			// Token: 0x17001CB9 RID: 7353
			// (get) Token: 0x06008833 RID: 34867 RVA: 0x00278FEC File Offset: 0x002771EC
			// (set) Token: 0x06008834 RID: 34868 RVA: 0x00278FFC File Offset: 0x002771FC
			public GameObject m_mapBackground
			{
				get
				{
					return this.m_owner.m_mapBackground;
				}
				set
				{
					this.m_owner.m_mapBackground = value;
				}
			}

			// Token: 0x17001CBA RID: 7354
			// (get) Token: 0x06008835 RID: 34869 RVA: 0x0027900C File Offset: 0x0027720C
			// (set) Token: 0x06008836 RID: 34870 RVA: 0x0027901C File Offset: 0x0027721C
			public GameObject m_mapTerrainFxRoot
			{
				get
				{
					return this.m_owner.m_mapTerrainFxRoot;
				}
				set
				{
					this.m_owner.m_mapTerrainFxRoot = value;
				}
			}

			// Token: 0x17001CBB RID: 7355
			// (get) Token: 0x06008837 RID: 34871 RVA: 0x0027902C File Offset: 0x0027722C
			// (set) Token: 0x06008838 RID: 34872 RVA: 0x0027903C File Offset: 0x0027723C
			public GameObject m_mapTreasureRoot
			{
				get
				{
					return this.m_owner.m_mapTreasureRoot;
				}
				set
				{
					this.m_owner.m_mapTreasureRoot = value;
				}
			}

			// Token: 0x17001CBC RID: 7356
			// (get) Token: 0x06008839 RID: 34873 RVA: 0x0027904C File Offset: 0x0027724C
			// (set) Token: 0x0600883A RID: 34874 RVA: 0x0027905C File Offset: 0x0027725C
			public Dictionary<GridPosition, GameObject> m_mapTerrainFxs
			{
				get
				{
					return this.m_owner.m_mapTerrainFxs;
				}
				set
				{
					this.m_owner.m_mapTerrainFxs = value;
				}
			}

			// Token: 0x17001CBD RID: 7357
			// (get) Token: 0x0600883B RID: 34875 RVA: 0x0027906C File Offset: 0x0027726C
			// (set) Token: 0x0600883C RID: 34876 RVA: 0x0027907C File Offset: 0x0027727C
			public GameObject m_battleUIRoot
			{
				get
				{
					return this.m_owner.m_battleUIRoot;
				}
				set
				{
					this.m_owner.m_battleUIRoot = value;
				}
			}

			// Token: 0x17001CBE RID: 7358
			// (get) Token: 0x0600883D RID: 34877 RVA: 0x0027908C File Offset: 0x0027728C
			// (set) Token: 0x0600883E RID: 34878 RVA: 0x0027909C File Offset: 0x0027729C
			public GameObject m_battleActorUIRoot
			{
				get
				{
					return this.m_owner.m_battleActorUIRoot;
				}
				set
				{
					this.m_owner.m_battleActorUIRoot = value;
				}
			}

			// Token: 0x17001CBF RID: 7359
			// (get) Token: 0x0600883F RID: 34879 RVA: 0x002790AC File Offset: 0x002772AC
			// (set) Token: 0x06008840 RID: 34880 RVA: 0x002790BC File Offset: 0x002772BC
			public GameObject m_battleActorUIPrefab
			{
				get
				{
					return this.m_owner.m_battleActorUIPrefab;
				}
				set
				{
					this.m_owner.m_battleActorUIPrefab = value;
				}
			}

			// Token: 0x17001CC0 RID: 7360
			// (get) Token: 0x06008841 RID: 34881 RVA: 0x002790CC File Offset: 0x002772CC
			// (set) Token: 0x06008842 RID: 34882 RVA: 0x002790DC File Offset: 0x002772DC
			public GraphicPool m_graphicPool
			{
				get
				{
					return this.m_owner.m_graphicPool;
				}
				set
				{
					this.m_owner.m_graphicPool = value;
				}
			}

			// Token: 0x17001CC1 RID: 7361
			// (get) Token: 0x06008843 RID: 34883 RVA: 0x002790EC File Offset: 0x002772EC
			// (set) Token: 0x06008844 RID: 34884 RVA: 0x002790FC File Offset: 0x002772FC
			public GraphicPool m_fxPool
			{
				get
				{
					return this.m_owner.m_fxPool;
				}
				set
				{
					this.m_owner.m_fxPool = value;
				}
			}

			// Token: 0x17001CC2 RID: 7362
			// (get) Token: 0x06008845 RID: 34885 RVA: 0x0027910C File Offset: 0x0027730C
			// (set) Token: 0x06008846 RID: 34886 RVA: 0x0027911C File Offset: 0x0027731C
			public FxPlayer m_battleFxPlayer
			{
				get
				{
					return this.m_owner.m_battleFxPlayer;
				}
				set
				{
					this.m_owner.m_battleFxPlayer = value;
				}
			}

			// Token: 0x17001CC3 RID: 7363
			// (get) Token: 0x06008847 RID: 34887 RVA: 0x0027912C File Offset: 0x0027732C
			// (set) Token: 0x06008848 RID: 34888 RVA: 0x0027913C File Offset: 0x0027733C
			public FxPlayer m_combatFxPlayer
			{
				get
				{
					return this.m_owner.m_combatFxPlayer;
				}
				set
				{
					this.m_owner.m_combatFxPlayer = value;
				}
			}

			// Token: 0x17001CC4 RID: 7364
			// (get) Token: 0x06008849 RID: 34889 RVA: 0x0027914C File Offset: 0x0027734C
			// (set) Token: 0x0600884A RID: 34890 RVA: 0x0027915C File Offset: 0x0027735C
			public FxPlayer m_cutscenePlayer
			{
				get
				{
					return this.m_owner.m_cutscenePlayer;
				}
				set
				{
					this.m_owner.m_cutscenePlayer = value;
				}
			}

			// Token: 0x0600884B RID: 34891 RVA: 0x0027916C File Offset: 0x0027736C
			public void TickSlowMotion(float dt)
			{
				this.m_owner.TickSlowMotion(dt);
			}

			// Token: 0x0600884C RID: 34892 RVA: 0x0027917C File Offset: 0x0027737C
			public void TickCombat()
			{
				this.m_owner.TickCombat();
			}

			// Token: 0x0600884D RID: 34893 RVA: 0x0027918C File Offset: 0x0027738C
			public void TickClientBattle()
			{
				this.m_owner.TickClientBattle();
			}

			// Token: 0x0600884E RID: 34894 RVA: 0x0027919C File Offset: 0x0027739C
			public void StartCombat()
			{
				this.m_owner.StartCombat();
			}

			// Token: 0x0600884F RID: 34895 RVA: 0x002791AC File Offset: 0x002773AC
			public void StopCombat()
			{
				this.m_owner.StopCombat();
			}

			// Token: 0x06008850 RID: 34896 RVA: 0x002791BC File Offset: 0x002773BC
			public void SetTimeScale(float scale)
			{
				this.m_owner.SetTimeScale(scale);
			}

			// Token: 0x06008851 RID: 34897 RVA: 0x002791CC File Offset: 0x002773CC
			public void UpdateFinalTimeScale()
			{
				this.m_owner.UpdateFinalTimeScale();
			}

			// Token: 0x06008852 RID: 34898 RVA: 0x002791DC File Offset: 0x002773DC
			public void TickGraphic(float dt)
			{
				this.m_owner.TickGraphic(dt);
			}

			// Token: 0x06008853 RID: 34899 RVA: 0x002791EC File Offset: 0x002773EC
			public void Draw()
			{
				this.m_owner.Draw();
			}

			// Token: 0x06008854 RID: 34900 RVA: 0x002791FC File Offset: 0x002773FC
			public void _CreateMap(ConfigDataBattlefieldInfo battlefieldInfo, int cameraX, int cameraY)
			{
				this.m_owner._CreateMap(battlefieldInfo, cameraX, cameraY);
			}

			// Token: 0x06008855 RID: 34901 RVA: 0x0027920C File Offset: 0x0027740C
			public GridPosition GetWinConditionTargetPosition(ConfigDataBattleWinConditionInfo winConditionInfo)
			{
				return this.m_owner.GetWinConditionTargetPosition(winConditionInfo);
			}

			// Token: 0x06008856 RID: 34902 RVA: 0x0027921C File Offset: 0x0027741C
			public GridPosition GetLoseConditionTargetPosition(ConfigDataBattleLoseConditionInfo loseConditionInfo)
			{
				return this.m_owner.GetLoseConditionTargetPosition(loseConditionInfo);
			}

			// Token: 0x06008857 RID: 34903 RVA: 0x0027922C File Offset: 0x0027742C
			public void FadeNonSkillTargets(ClientBattleActor ca, ConfigDataSkillInfo skillInfo, GridPosition targetPos)
			{
				this.m_owner.FadeNonSkillTargets(ca, skillInfo, targetPos);
			}

			// Token: 0x06008858 RID: 34904 RVA: 0x0027923C File Offset: 0x0027743C
			public void RestoreNonSkillTargets()
			{
				this.m_owner.RestoreNonSkillTargets();
			}

			// Token: 0x06008859 RID: 34905 RVA: 0x0027924C File Offset: 0x0027744C
			public bool IsNeedTargetIcon(BattleActor a)
			{
				return this.m_owner.IsNeedTargetIcon(a);
			}

			// Token: 0x0600885A RID: 34906 RVA: 0x0027925C File Offset: 0x0027745C
			public void DrawMap()
			{
				this.m_owner.DrawMap();
			}

			// Token: 0x0600885B RID: 34907 RVA: 0x0027926C File Offset: 0x0027746C
			public void DrawCell(GridPosition p, BattleActor actor, ConfigDataTerrainInfo terrain)
			{
				this.m_owner.DrawCell(p, actor, terrain);
			}

			// Token: 0x0600885C RID: 34908 RVA: 0x0027927C File Offset: 0x0027747C
			public CameraBase GetCurrentCamera()
			{
				return this.m_owner.GetCurrentCamera();
			}

			// Token: 0x0600885D RID: 34909 RVA: 0x0027928C File Offset: 0x0027748C
			public ClientBattleTreasure CreateTreasure(ConfigDataBattleTreasureInfo treasureInfo, bool isOpened)
			{
				return this.m_owner.CreateTreasure(treasureInfo, isOpened);
			}

			// Token: 0x0600885E RID: 34910 RVA: 0x0027929C File Offset: 0x0027749C
			public void CreateMapBackground(ConfigDataBattlefieldInfo battlefieldInfo, GameObject parent)
			{
				this.m_owner.CreateMapBackground(battlefieldInfo, parent);
			}

			// Token: 0x0600885F RID: 34911 RVA: 0x002792AC File Offset: 0x002774AC
			public void ClearMapBackground()
			{
				this.m_owner.ClearMapBackground();
			}

			// Token: 0x06008860 RID: 34912 RVA: 0x002792BC File Offset: 0x002774BC
			public void CreateMapTerrainFx(GameObject parent)
			{
				this.m_owner.CreateMapTerrainFx(parent);
			}

			// Token: 0x06008861 RID: 34913 RVA: 0x002792CC File Offset: 0x002774CC
			public void ClearMapTerrainFx()
			{
				this.m_owner.ClearMapTerrainFx();
			}

			// Token: 0x06008862 RID: 34914 RVA: 0x002792DC File Offset: 0x002774DC
			public void AddMapTerrainFx(GridPosition p, ConfigDataTerrainInfo terrainInfo, GameObject parent)
			{
				this.m_owner.AddMapTerrainFx(p, terrainInfo, parent);
			}

			// Token: 0x06008863 RID: 34915 RVA: 0x002792EC File Offset: 0x002774EC
			public int _ComputeCombatArmyRelationValue(BattleActor a, BattleActor b, bool isMagic)
			{
				return this.m_owner._ComputeCombatArmyRelationValue(a, b, isMagic);
			}

			// Token: 0x06008864 RID: 34916 RVA: 0x002792FC File Offset: 0x002774FC
			public static void _ComputeArmyRelationValue(ArmyRelationData r, bool isMagic, ref int value)
			{
				ClientBattle._ComputeArmyRelationValue(r, isMagic, ref value);
			}

			// Token: 0x06008865 RID: 34917 RVA: 0x00279308 File Offset: 0x00277508
			public void AppendActToActor()
			{
				this.m_owner.AppendActToActor();
			}

			// Token: 0x06008866 RID: 34918 RVA: 0x00279318 File Offset: 0x00277518
			public void AppendActsToActor(int step, Type type)
			{
				this.m_owner.AppendActsToActor(step, type);
			}

			// Token: 0x06008867 RID: 34919 RVA: 0x00279328 File Offset: 0x00277528
			public void AppendActsToActor(int step, Type type, ClientBattleActor ca)
			{
				this.m_owner.AppendActsToActor(step, type, ca);
			}

			// Token: 0x06008868 RID: 34920 RVA: 0x00279338 File Offset: 0x00277538
			public void SdkLogBattle(string eventId, object logData)
			{
				this.m_owner.SdkLogBattle(eventId, logData);
			}

			// Token: 0x04006111 RID: 24849
			private ClientBattle m_owner;
		}
	}
}
