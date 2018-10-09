using System;
using System.Collections.Generic;
using System.Text;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x02000387 RID: 903
	[HotFix]
	public class BattleBase
	{
		// Token: 0x0600348A RID: 13450 RVA: 0x000DF8C0 File Offset: 0x000DDAC0
		public BattleBase(IConfigDataLoader configDataLoader, IBattleListener battleListener)
		{
			this.m_configDataLoader = configDataLoader;
			this.m_battleListener = battleListener;
			this.m_teams = new BattleTeam[2];
			for (int i = 0; i < this.m_teams.Length; i++)
			{
				this.m_teams[i] = new BattleTeam(this, i);
			}
			this.m_battleCommands = new LinkedList<BattleCommand>();
			this.m_logBattleCommands = new LinkedList<BattleCommand>();
			this.m_tempBattleCommands = new LinkedList<BattleCommand>();
			this.m_stepExecutedCommands = new List<BattleCommand>();
			this.m_checksums = new List<int>();
			this.m_winConditionStates = new List<BattleWinConditionState>();
			this.m_loseConditionStates = new List<BattleLoseConditionState>();
			this.m_achievementStates = new List<BattleAchievementState>();
			this.m_eventTriggerStates = new List<BattleEventTriggerState>();
			this.m_battleTreasureStates = new List<BattleTreasureState>();
			this.m_randomNumber = new RandomNumber();
			this.m_aiRandomNumber1 = new RandomNumber();
			this.m_aiRandomNumber2 = new RandomNumber();
			this.m_armyRandomNumber = new RandomNumber();
			this.m_state = BattleState.None;
			this.m_actionOrderType = ActionOrderType.Normal;
			this.m_map = new BattleMap();
			this.m_pathfinder = new Pathfinder();
			this.m_combat = new Combat(this);
			this.m_tempIntLists = new List<int>[5];
			for (int j = 0; j < this.m_tempIntLists.Length; j++)
			{
				this.m_tempIntLists[j] = new List<int>();
			}
			this.m_freeIntListIndex = 0;
			this.m_tempGridPositionLists = new List<GridPosition>[5];
			for (int k = 0; k < this.m_tempGridPositionLists.Length; k++)
			{
				this.m_tempGridPositionLists[k] = new List<GridPosition>();
			}
			this.m_freeGridPositionListIndex = 0;
			this.m_tempActorLists = new List<BattleActor>[5];
			for (int l = 0; l < this.m_tempActorLists.Length; l++)
			{
				this.m_tempActorLists[l] = new List<BattleActor>();
			}
			this.m_freeActorListIndex = 0;
			this.m_tempBuffLists = new List<ConfigDataBuffInfo>[5];
			for (int m = 0; m < this.m_tempBuffLists.Length; m++)
			{
				this.m_tempBuffLists[m] = new List<ConfigDataBuffInfo>();
			}
			this.m_freeBuffListIndex = 0;
			this.m_tempBuffStateLists = new List<BuffState>[8];
			for (int n = 0; n < this.m_tempBuffStateLists.Length; n++)
			{
				this.m_tempBuffStateLists[n] = new List<BuffState>();
			}
			this.m_freeBuffStateListIndex = 0;
			this.m_tempBattlePropertyModifier = new BattlePropertyModifier();
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctorIConfigDataLoaderIBattleListener_hotfix != null)
			{
				this.m_ctorIConfigDataLoaderIBattleListener_hotfix.call(new object[]
				{
					this,
					configDataLoader,
					battleListener
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600348B RID: 13451 RVA: 0x000DFB8C File Offset: 0x000DDD8C
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
			if (this.m_map != null)
			{
				this.m_map.Dispose();
				this.m_map = null;
				this.m_battlefieldInfo = null;
			}
			if (this.m_pathfinder != null)
			{
				this.m_pathfinder.Dispose();
				this.m_pathfinder = null;
			}
			if (this.m_combat != null)
			{
				this.m_combat.Dispose();
				this.m_combat = null;
			}
			this.m_teams = null;
			this.m_players = null;
			this.m_maxPlayerLevelInfo = null;
			this.m_battleCommands = null;
			this.m_logBattleCommands = null;
			this.m_tempBattleCommands = null;
			this.m_stepExecutedCommands = null;
			this.m_checksums = null;
			this.m_winConditionStates = null;
			this.m_loseConditionStates = null;
			this.m_achievementStates = null;
			this.m_eventTriggerStates = null;
			this.m_battleTreasureStates = null;
			this.m_randomNumber = null;
			this.m_aiRandomNumber1 = null;
			this.m_aiRandomNumber2 = null;
			this.m_tempIntLists = null;
			this.m_tempGridPositionLists = null;
			this.m_tempActorLists = null;
			this.m_tempBuffLists = null;
			this.m_tempBuffStateLists = null;
			this.m_tempBattlePropertyModifier = null;
		}

		// Token: 0x0600348C RID: 13452 RVA: 0x000DFCEC File Offset: 0x000DDEEC
		public void SetWinForCheat()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetWinForCheat_hotfix != null)
			{
				this.m_SetWinForCheat_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_stars = 3;
		}

		// Token: 0x0600348D RID: 13453 RVA: 0x000DFD54 File Offset: 0x000DDF54
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
			this.m_battleInfo = null;
			this.m_arenaBattleInfo = null;
			this.m_pvpBattleInfo = null;
			this.m_realtimePvpBattleInfo = null;
			this.m_monsterLevel = 0;
			foreach (BattleTeam battleTeam in this.m_teams)
			{
				battleTeam.RemoveAll();
			}
			this.m_map.ClearActors();
			this.m_map.ClearRegion();
			this.m_players = null;
			this.m_maxPlayerLevelInfo = null;
			this.m_battleCommands.Clear();
			this.m_logBattleCommands.Clear();
			this.m_tempBattleCommands.Clear();
			this.m_stepExecutedCommands.Clear();
			this.m_checksums.Clear();
			this.m_enableTempBattleCommands = false;
			this.m_winConditionStates.Clear();
			this.m_loseConditionStates.Clear();
			this.m_achievementStates.Clear();
			this.m_eventTriggerStates.Clear();
			this.m_battleTreasureStates.Clear();
			this.m_stars = 0;
			this.m_starTurnMax = -1;
			this.m_starDeadMax = -1;
			this.m_state = BattleState.None;
			this.m_step = 0;
			this.m_turn = 0;
			this.m_turnMax = 0;
			this.m_actionTeam = -1;
			this.m_prevActionPlayerIndex = -1;
			this.m_actionActor = null;
			this.m_entityIdCounter = 0;
			this.m_needCheckBattleStopEventTrigger = false;
			this.m_isGiveupBattle = false;
			this.m_giveupBattlePlayerIndex = -1;
			this.m_freeIntListIndex = 0;
			this.m_freeGridPositionListIndex = 0;
			this.m_freeActorListIndex = 0;
			this.m_freeBuffListIndex = 0;
			this.m_freeBuffStateListIndex = 0;
			this.m_combatActorA = null;
			this.m_combatActorB = null;
			this.m_combatSkillInfoA = null;
			this.m_beGuardedCombatActor = null;
			this.m_afterComatPerform = null;
			this.m_isPerformCombat = false;
			this.m_isAfterCombatNextStep = false;
			this.m_isAfterCombatNextStepActorActive = false;
			this.m_afterCombatExecuteTriggerState = null;
			this.m_afterCombatExecuteTriggerEventActionIndex = -1;
		}

		// Token: 0x0600348E RID: 13454 RVA: 0x000DFF60 File Offset: 0x000DE160
		public int GetStarTurnMax()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetStarTurnMax_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetStarTurnMax_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_starTurnMax;
		}

		// Token: 0x0600348F RID: 13455 RVA: 0x000DFFD4 File Offset: 0x000DE1D4
		public int GetStarDeadMax()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetStarDeadMax_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetStarDeadMax_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_starDeadMax;
		}

		// Token: 0x06003490 RID: 13456 RVA: 0x000E0048 File Offset: 0x000DE248
		public bool IsPerformOnlyBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsPerformOnlyBattle_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsPerformOnlyBattle_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_battleInfo != null && this.m_battleInfo.m_battlePerformInfo != null;
		}

		// Token: 0x06003491 RID: 13457 RVA: 0x000E00D4 File Offset: 0x000DE2D4
		public void Start()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Start_hotfix != null)
			{
				this.m_Start_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 1;
			foreach (BattleAchievementState battleAchievementState in this.m_achievementStates)
			{
				battleAchievementState.m_conditionId = num++;
				battleAchievementState.m_status = BattleConditionStatus.Progress;
			}
			foreach (BattleWinConditionState battleWinConditionState in this.m_winConditionStates)
			{
				battleWinConditionState.m_conditionId = num++;
				battleWinConditionState.m_status = BattleConditionStatus.Progress;
			}
			foreach (BattleLoseConditionState battleLoseConditionState in this.m_loseConditionStates)
			{
				battleLoseConditionState.m_conditionId = num++;
				battleLoseConditionState.m_status = BattleConditionStatus.Progress;
			}
			foreach (BattleEventTriggerState battleEventTriggerState in this.m_eventTriggerStates)
			{
				battleEventTriggerState.m_conditionId = num++;
				battleEventTriggerState.m_status = BattleConditionStatus.Progress;
			}
			if (this.IsEnableDebugLog() && num >= 64)
			{
				DebugUtility.LogError(string.Format("BattleBase.Start() error, conditionId >= 64: {0}", num));
			}
			foreach (BattleTreasureState battleTreasureState in this.m_battleTreasureStates)
			{
				this.m_battleListener.OnBattleTreasureCreate(battleTreasureState.m_battleTreasureInfo, battleTreasureState.m_isOpened);
			}
			foreach (BattleTeam battleTeam in this.m_teams)
			{
				battleTeam.StartBattle();
			}
			if (!this.IsPerformOnlyBattle())
			{
				this.m_battleListener.LogBattleStart();
				this.m_battleListener.LogBattleTeam(this.m_teams[0], this.m_teams[1]);
			}
			this.m_state = BattleState.Play;
		}

		// Token: 0x06003492 RID: 13458 RVA: 0x000E038C File Offset: 0x000DE58C
		private void Stop(bool win)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StopBoolean_hotfix != null)
			{
				this.m_StopBoolean_hotfix.call(new object[]
				{
					this,
					win
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsPlay())
			{
				return;
			}
			this.m_state = BattleState.Stop;
			for (int i = 0; i < this.m_teams.Length; i++)
			{
				BattleTeam battleTeam = this.m_teams[i];
				battleTeam.StopBattle((i != 0) ? (!win) : win);
			}
			this.CheckAchievementOnTurnEndOrWin(win);
			if (win)
			{
				this.m_stars = 1;
				if (this.m_turn <= this.m_starTurnMax)
				{
					this.m_stars++;
				}
				if (this.m_teams[0].ComputeDeadActorCount(null, NpcCondition.NotNpc) <= this.m_starDeadMax)
				{
					this.m_stars++;
				}
				this.CheckAchievementOnWin();
			}
			else
			{
				this.m_stars = 0;
				this.CheckAchievementOnLose();
			}
			if (!this.IsPerformOnlyBattle())
			{
				this.m_battleListener.LogBattleStop(win);
			}
			this.m_needCheckBattleStopEventTrigger = true;
		}

		// Token: 0x06003493 RID: 13459 RVA: 0x000E04D8 File Offset: 0x000DE6D8
		public void FirstStep(bool skipPerformCombat)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FirstStepBoolean_hotfix != null)
			{
				this.m_FirstStepBoolean_hotfix.call(new object[]
				{
					this,
					skipPerformCombat
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsPerformOnlyBattle())
			{
				this.ExecuteBattlePerforms(this.m_battleInfo.m_battlePerformInfo);
			}
			else
			{
				this.NextStep();
				if (skipPerformCombat && this.m_state == BattleState.Combat)
				{
					this.RunCombat();
				}
			}
		}

		// Token: 0x06003494 RID: 13460 RVA: 0x000E0588 File Offset: 0x000DE788
		private void NextStep()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_NextStep_hotfix != null)
			{
				this.m_NextStep_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_enableChecksum)
			{
				this.ComputeStepChecksum();
			}
			BattleActor actionActor = null;
			this.m_prevActionPlayerIndex = -1;
			if (this.m_actionActor != null)
			{
				BattleActor actionActor2 = this.m_actionActor;
				this.m_prevActionPlayerIndex = actionActor2.PlayerIndex;
				if (!actionActor2.IsDeadOrRetreat())
				{
					actionActor2.ActionEnd();
					if (!actionActor2.IsDeadOrRetreat())
					{
						this.CheckOnActorMove(actionActor2);
						this.m_battleListener.OnBattleActorActionEnd(actionActor2);
						if (actionActor2.IsExtraAction() || actionActor2.IsExtraActionMoving())
						{
							actionActor = actionActor2;
						}
					}
				}
				this.m_actionActor = null;
			}
			this.CheckWinConditionOnNextStep();
			this.CheckAchievementOnNextStep();
			this.CheckEventTriggerOnNextStep();
			if (!this.IsPlay())
			{
				this.CheckBattleStopEventTrigger();
				return;
			}
			if (this.m_actionOrderType == ActionOrderType.Normal)
			{
				this.NextStep_Normal(actionActor);
			}
			else if (this.m_actionOrderType == ActionOrderType.PVP)
			{
				this.NextStep_Pvp(actionActor);
			}
			if (this.m_state == BattleState.Combat)
			{
				this.m_isAfterCombatNextStepActorActive = true;
			}
			else
			{
				this.NextStepActorActive();
			}
		}

		// Token: 0x06003495 RID: 13461 RVA: 0x000E06DC File Offset: 0x000DE8DC
		private void NextStep_Normal(BattleActor actionActor)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_NextStep_NormalBattleActor_hotfix != null)
			{
				this.m_NextStep_NormalBattleActor_hotfix.call(new object[]
				{
					this,
					actionActor
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool flag = false;
			if (this.m_turn == 0)
			{
				this.NextTurn();
				flag = true;
			}
			else if (!this.m_teams[this.m_actionTeam].HasNotActionFinishedActor())
			{
				if (this.m_actionTeam == 1)
				{
					this.NextTurn();
				}
				if (this.IsPlay())
				{
					this.m_actionTeam = 1 - this.m_actionTeam;
					flag = true;
				}
			}
			if (this.IsPlay())
			{
				if (actionActor == null)
				{
					actionActor = this.GetDefaultActionActor(this.m_actionTeam);
				}
				if (actionActor != null)
				{
					this.m_step++;
					this.m_actionActor = actionActor;
					bool flag2 = false;
					if (this.m_actionTeam == 0 && actionActor.IsAINpc() && !this.m_teams[0].HasFinishActionNpcActor())
					{
						flag2 = true;
						flag = true;
					}
					if (flag)
					{
						this.m_battleListener.OnBattleNextTeam(this.m_actionTeam, flag2);
						this.CheckEventTriggerOnNextTeam(this.m_actionTeam, flag2);
						if (!flag2)
						{
							this.m_teams[this.m_actionTeam].DoGroupBehavior();
						}
					}
				}
			}
		}

		// Token: 0x06003496 RID: 13462 RVA: 0x000E0854 File Offset: 0x000DEA54
		private void NextStep_Pvp(BattleActor actionActor)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_NextStep_PvpBattleActor_hotfix != null)
			{
				this.m_NextStep_PvpBattleActor_hotfix.call(new object[]
				{
					this,
					actionActor
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool flag = false;
			if (this.m_turn == 0)
			{
				this.NextTurn();
				flag = true;
			}
			else if (this.HasNotActionFinishedActor())
			{
				if (actionActor == null)
				{
					this.m_actionTeam = 1 - this.m_actionTeam;
				}
			}
			else
			{
				this.NextTurn();
				if (this.IsPlay())
				{
					this.m_actionTeam = 1 - this.m_actionTeam;
					flag = true;
				}
			}
			if (this.IsPlay())
			{
				if (actionActor == null)
				{
					actionActor = this.GetDefaultActionActor(this.m_actionTeam);
				}
				if (actionActor != null)
				{
					this.m_step++;
					this.m_actionActor = actionActor;
				}
				else
				{
					actionActor = this.GetDefaultActionActor(1 - this.m_actionTeam);
					if (actionActor != null)
					{
						this.m_actionTeam = 1 - this.m_actionTeam;
						this.m_step++;
						this.m_actionActor = actionActor;
					}
				}
				if (flag)
				{
					this.CheckEventTriggerOnNextTeam(0, false);
				}
			}
		}

		// Token: 0x06003497 RID: 13463 RVA: 0x000E09B0 File Offset: 0x000DEBB0
		private void NextStepActorActive()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_NextStepActorActive_hotfix != null)
			{
				this.m_NextStepActorActive_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsPlay())
			{
				if (this.m_actionActor == null || this.m_actionActor.IsDeadOrRetreat())
				{
					this.NextStep();
				}
				else
				{
					if (this.m_actionActor.PlayerIndex != this.m_prevActionPlayerIndex)
					{
						this.m_battleListener.OnBattleNextPlayer(this.m_prevActionPlayerIndex, this.m_actionActor.PlayerIndex);
					}
					if (this.m_actionActor.HasFightTag(FightTag.FightTag_Stun))
					{
						this.m_actionActor.ActionBegin();
						this.NextStep();
					}
					else
					{
						if (!this.m_actionActor.IsExtraActionMoving())
						{
							this.m_battleListener.OnBattleNextActor(this.m_actionActor);
						}
						this.m_battleListener.OnBattleActorActive(this.m_actionActor, true);
						this.CheckEventTriggerOnActorActionBegin(this.m_actionActor);
					}
				}
			}
		}

		// Token: 0x06003498 RID: 13464 RVA: 0x000E0ADC File Offset: 0x000DECDC
		private void NextTurn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_NextTurn_hotfix != null)
			{
				this.m_NextTurn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.CheckAchievementOnTurnEndOrWin(false);
			this.m_turn++;
			foreach (BattleTeam battleTeam in this.m_teams)
			{
				battleTeam.RemoveDeleted();
			}
			foreach (BattleTeam battleTeam2 in this.m_teams)
			{
				battleTeam2.NextTurn();
			}
			this.CheckWinConditionOnTurnBegin();
			if (this.IsPlay())
			{
				if (this.m_turn > this.m_turnMax)
				{
					this.CheckWinLoseConditionOnTurnMax();
				}
				else
				{
					this.m_battleListener.OnBattleNextTurn(this.m_turn);
				}
			}
			if (!this.IsPlay())
			{
				this.CheckBattleStopEventTrigger();
			}
		}

		// Token: 0x06003499 RID: 13465 RVA: 0x000E0BF4 File Offset: 0x000DEDF4
		private BattleActor GetDefaultActionActor(int team)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDefaultActionActorInt32_hotfix != null)
			{
				return (BattleActor)this.m_GetDefaultActionActorInt32_hotfix.call(new object[]
				{
					this,
					team
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = -100000;
			BattleActor result = null;
			List<BattleActor> actors = this.m_teams[team].GetActors();
			foreach (BattleActor battleActor in actors)
			{
				if (!battleActor.IsDeadOrRetreat())
				{
					if (!battleActor.IsActionFinished())
					{
						int num2 = battleActor.ActionValue;
						if (!battleActor.IsAINpc())
						{
							num2 += 100000;
							if (battleActor.IsPlayerActor() && !battleActor.HasFightTag(FightTag.FightTag_Stun))
							{
								num2 += 100000;
							}
							if (battleActor.PlayerIndex >= 0)
							{
								num2 += (9 - battleActor.PlayerIndex) * 1000;
							}
						}
						if (num2 > num)
						{
							num = num2;
							result = battleActor;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x0600349A RID: 13466 RVA: 0x000E0D58 File Offset: 0x000DEF58
		private bool HasNotActionFinishedActor()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasNotActionFinishedActor_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasNotActionFinishedActor_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleTeam battleTeam in this.m_teams)
			{
				if (battleTeam.HasNotActionFinishedActor())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600349B RID: 13467 RVA: 0x000E0DF4 File Offset: 0x000DEFF4
		public int GetActionTeam()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetActionTeam_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetActionTeam_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_actionTeam;
		}

		// Token: 0x0600349C RID: 13468 RVA: 0x000E0E68 File Offset: 0x000DF068
		public BattleActor GetActionActor()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetActionActor_hotfix != null)
			{
				return (BattleActor)this.m_GetActionActor_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_actionActor;
		}

		// Token: 0x0600349D RID: 13469 RVA: 0x000E0EDC File Offset: 0x000DF0DC
		public bool ChangeActionActor(BattleActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ChangeActionActorBattleActor_hotfix != null)
			{
				return Convert.ToBoolean(this.m_ChangeActionActorBattleActor_hotfix.call(new object[]
				{
					this,
					a
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (a == null)
			{
				return false;
			}
			if (!a.CanAction())
			{
				return false;
			}
			if (a.TeamNumber != this.m_actionTeam)
			{
				return false;
			}
			if (this.m_actionActor == null)
			{
				return false;
			}
			if (!this.m_actionActor.CanAction())
			{
				return false;
			}
			if (!this.IsPlay())
			{
				return false;
			}
			if (a != this.m_actionActor && (this.m_actionActor.IsExtraAction() || this.m_actionActor.IsExtraActionMoving()))
			{
				return false;
			}
			this.m_actionActor = a;
			this.m_battleListener.OnBattleActorActive(a, false);
			return true;
		}

		// Token: 0x0600349E RID: 13470 RVA: 0x000E0FF0 File Offset: 0x000DF1F0
		public void Tick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Tick_hotfix != null)
			{
				this.m_Tick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_state == BattleState.Combat)
			{
				this.m_combat.Tick();
				if (this.m_combat.State == CombatState.End)
				{
					this.StopCombat();
				}
			}
		}

		// Token: 0x0600349F RID: 13471 RVA: 0x000E1080 File Offset: 0x000DF280
		public void TickGraphic(float dt)
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
			if (this.m_state == BattleState.Combat)
			{
				this.m_combat.TickGraphic(dt);
			}
		}

		// Token: 0x060034A0 RID: 13472 RVA: 0x000E1108 File Offset: 0x000DF308
		public void Draw()
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
			if (this.m_state == BattleState.Combat)
			{
				this.m_combat.Draw();
			}
		}

		// Token: 0x060034A1 RID: 13473 RVA: 0x000E1180 File Offset: 0x000DF380
		public void ChangeMapTerrain(GridPosition p, ConfigDataTerrainInfo terrainInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ChangeMapTerrainGridPositionConfigDataTerrainInfo_hotfix != null)
			{
				this.m_ChangeMapTerrainGridPositionConfigDataTerrainInfo_hotfix.call(new object[]
				{
					this,
					p,
					terrainInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_map.SetTerrain(p, terrainInfo);
			this.m_battleListener.OnChangeMapTerrain(p, terrainInfo);
		}

		// Token: 0x060034A2 RID: 13474 RVA: 0x000E121C File Offset: 0x000DF41C
		public BattleTeam GetTeam(int teamNumber)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTeamInt32_hotfix != null)
			{
				return (BattleTeam)this.m_GetTeamInt32_hotfix.call(new object[]
				{
					this,
					teamNumber
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_teams[teamNumber];
		}

		// Token: 0x060034A3 RID: 13475 RVA: 0x000E12A0 File Offset: 0x000DF4A0
		public BattlePlayer GetBattlePlayer(int playerIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetBattlePlayerInt32_hotfix != null)
			{
				return (BattlePlayer)this.m_GetBattlePlayerInt32_hotfix.call(new object[]
				{
					this,
					playerIndex
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_players == null || this.m_players.Length <= 0)
			{
				return null;
			}
			if (playerIndex < 0)
			{
				return this.m_players[0];
			}
			if (playerIndex < this.m_players.Length)
			{
				return this.m_players[playerIndex];
			}
			return null;
		}

		// Token: 0x060034A4 RID: 13476 RVA: 0x000E1360 File Offset: 0x000DF560
		public BattleActor GetActorById(int id)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetActorByIdInt32_hotfix != null)
			{
				return (BattleActor)this.m_GetActorByIdInt32_hotfix.call(new object[]
				{
					this,
					id
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (id == 0)
			{
				return null;
			}
			foreach (BattleTeam battleTeam in this.m_teams)
			{
				BattleActor actorById = battleTeam.GetActorById(id);
				if (actorById != null)
				{
					return actorById;
				}
			}
			return null;
		}

		// Token: 0x060034A5 RID: 13477 RVA: 0x000E1414 File Offset: 0x000DF614
		public BattleActor GetActorByHeroId(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetActorByHeroIdInt32_hotfix != null)
			{
				return (BattleActor)this.m_GetActorByHeroIdInt32_hotfix.call(new object[]
				{
					this,
					heroId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (heroId == 0)
			{
				return null;
			}
			foreach (BattleTeam battleTeam in this.m_teams)
			{
				BattleActor actorByHeroId = battleTeam.GetActorByHeroId(heroId, false);
				if (actorByHeroId != null)
				{
					return actorByHeroId;
				}
			}
			return null;
		}

		// Token: 0x060034A6 RID: 13478 RVA: 0x000E14CC File Offset: 0x000DF6CC
		private BattleActor GetAliveActorByHeroId(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAliveActorByHeroIdInt32_hotfix != null)
			{
				return (BattleActor)this.m_GetAliveActorByHeroIdInt32_hotfix.call(new object[]
				{
					this,
					heroId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (heroId == 0)
			{
				return null;
			}
			foreach (BattleTeam battleTeam in this.m_teams)
			{
				BattleActor actorByHeroId = battleTeam.GetActorByHeroId(heroId, true);
				if (actorByHeroId != null)
				{
					return actorByHeroId;
				}
			}
			return null;
		}

		// Token: 0x060034A7 RID: 13479 RVA: 0x000E1584 File Offset: 0x000DF784
		private void GetAliveActorsByHeroIdsAndGroupIds(List<int> heroIds, List<int> groupIds, List<BattleActor> actors)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAliveActorsByHeroIdsAndGroupIdsList`1List`1List`1_hotfix != null)
			{
				this.m_GetAliveActorsByHeroIdsAndGroupIdsList`1List`1List`1_hotfix.call(new object[]
				{
					this,
					heroIds,
					groupIds,
					actors
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleTeam battleTeam in this.m_teams)
			{
				foreach (BattleActor battleActor in battleTeam.GetActors())
				{
					if (!battleActor.IsDeadOrRetreat())
					{
						if (heroIds == null || heroIds.Count <= 0 || heroIds.Contains(battleActor.HeroId))
						{
							if (groupIds == null || groupIds.Count <= 0 || groupIds.Contains(battleActor.GroupId))
							{
								actors.Add(battleActor);
							}
						}
					}
				}
			}
		}

		// Token: 0x060034A8 RID: 13480 RVA: 0x000E16E4 File Offset: 0x000DF8E4
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

		// Token: 0x060034A9 RID: 13481 RVA: 0x000E1778 File Offset: 0x000DF978
		public void CheckOnActorMove(BattleActor actor)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckOnActorMoveBattleActor_hotfix != null)
			{
				this.m_CheckOnActorMoveBattleActor_hotfix.call(new object[]
				{
					this,
					actor
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (actor.IsDead())
			{
				return;
			}
			this.CheckLoseConditionOnActorMove(actor);
			this.CheckWinConditionOnActorMove(actor);
			this.CheckAchievementOnActorMove(actor);
			this.CheckEventTriggerOnActorMove(actor);
			this.CheckBattleTreasureOnActorMove(actor);
			if (!this.IsPlay())
			{
				this.CheckBattleStopEventTrigger();
			}
		}

		// Token: 0x060034AA RID: 13482 RVA: 0x000E1828 File Offset: 0x000DFA28
		public void CheckOnActorDie(BattleActor actor)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckOnActorDieBattleActor_hotfix != null)
			{
				this.m_CheckOnActorDieBattleActor_hotfix.call(new object[]
				{
					this,
					actor
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.CheckLoseConditionOnActorDie(actor);
			this.CheckWinConditionOnActorDie(actor);
			this.CheckAchievementOnActorDie(actor);
			this.CheckEventTriggerOnActorDie(actor);
			if (!this.IsPlay())
			{
				this.CheckBattleStopEventTrigger();
			}
		}

		// Token: 0x060034AB RID: 13483 RVA: 0x000E18C8 File Offset: 0x000DFAC8
		public void OnActorDie(BattleActor actor)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnActorDieBattleActor_hotfix != null)
			{
				this.m_OnActorDieBattleActor_hotfix.call(new object[]
				{
					this,
					actor
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool isAfterCombat = this.m_combatActorA != null && this.m_combatActorB != null;
			this.m_battleListener.OnBattleActorDie(actor, isAfterCombat);
		}

		// Token: 0x060034AC RID: 13484 RVA: 0x000E1960 File Offset: 0x000DFB60
		public void OnActorRetreat(BattleActor actor, int effectType, string fxName, bool notifyListener)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnActorRetreatBattleActorInt32StringBoolean_hotfix != null)
			{
				this.m_OnActorRetreatBattleActorInt32StringBoolean_hotfix.call(new object[]
				{
					this,
					actor,
					effectType,
					fxName,
					notifyListener
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (notifyListener)
			{
				this.m_battleListener.OnBattleActorDisappear(actor, effectType, fxName);
			}
			this.CheckLoseConditionOnActorRetreat(actor);
			this.CheckWinConditionOnActorRetreat(actor);
			if (!this.IsPlay())
			{
				this.CheckBattleStopEventTrigger();
			}
		}

		// Token: 0x060034AD RID: 13485 RVA: 0x000E1A34 File Offset: 0x000DFC34
		public void OnActorChangeTeam(BattleActor actor)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnActorChangeTeamBattleActor_hotfix != null)
			{
				this.m_OnActorChangeTeamBattleActor_hotfix.call(new object[]
				{
					this,
					actor
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleListener.OnBattleActorChangeTeam(actor);
		}

		// Token: 0x060034AE RID: 13486 RVA: 0x000E1AB0 File Offset: 0x000DFCB0
		public bool IsPlay()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsPlay_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsPlay_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_state == BattleState.Play || this.m_state == BattleState.Combat;
		}

		// Token: 0x060034AF RID: 13487 RVA: 0x000E1B34 File Offset: 0x000DFD34
		public bool IsGiveupBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsGiveupBattle_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsGiveupBattle_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isGiveupBattle;
		}

		// Token: 0x060034B0 RID: 13488 RVA: 0x000E1BA8 File Offset: 0x000DFDA8
		public int GetGiveupBattlePlayerIndex()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetGiveupBattlePlayerIndex_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetGiveupBattlePlayerIndex_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_giveupBattlePlayerIndex;
		}

		// Token: 0x060034B1 RID: 13489 RVA: 0x000E1C1C File Offset: 0x000DFE1C
		public List<int> AllocateTempIntList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AllocateTempIntList_hotfix != null)
			{
				return (List<int>)this.m_AllocateTempIntList_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_freeIntListIndex < this.m_tempIntLists.Length)
			{
				return this.m_tempIntLists[this.m_freeIntListIndex++];
			}
			throw new Exception("AllocateTempIntList");
		}

		// Token: 0x060034B2 RID: 13490 RVA: 0x000E1CC4 File Offset: 0x000DFEC4
		public void FreeTempIntList(List<int> list)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FreeTempIntListList`1_hotfix != null)
			{
				this.m_FreeTempIntListList`1_hotfix.call(new object[]
				{
					this,
					list
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_freeIntListIndex > 0 && list == this.m_tempIntLists[this.m_freeIntListIndex - 1])
			{
				list.Clear();
				this.m_freeIntListIndex--;
				return;
			}
			throw new Exception("FreeTempIntList");
		}

		// Token: 0x060034B3 RID: 13491 RVA: 0x000E1D7C File Offset: 0x000DFF7C
		public List<GridPosition> AllocateTempGridPositionList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AllocateTempGridPositionList_hotfix != null)
			{
				return (List<GridPosition>)this.m_AllocateTempGridPositionList_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_freeGridPositionListIndex < this.m_tempGridPositionLists.Length)
			{
				return this.m_tempGridPositionLists[this.m_freeGridPositionListIndex++];
			}
			throw new Exception("AllocateTempGridPositionList");
		}

		// Token: 0x060034B4 RID: 13492 RVA: 0x000E1E24 File Offset: 0x000E0024
		public void FreeTempGridPositionList(List<GridPosition> list)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FreeTempGridPositionListList`1_hotfix != null)
			{
				this.m_FreeTempGridPositionListList`1_hotfix.call(new object[]
				{
					this,
					list
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_freeGridPositionListIndex > 0 && list == this.m_tempGridPositionLists[this.m_freeGridPositionListIndex - 1])
			{
				list.Clear();
				this.m_freeGridPositionListIndex--;
				return;
			}
			throw new Exception("FreeTempGridPositionList");
		}

		// Token: 0x060034B5 RID: 13493 RVA: 0x000E1EDC File Offset: 0x000E00DC
		public List<BattleActor> AllocateTempActorList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AllocateTempActorList_hotfix != null)
			{
				return (List<BattleActor>)this.m_AllocateTempActorList_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_freeActorListIndex < this.m_tempActorLists.Length)
			{
				return this.m_tempActorLists[this.m_freeActorListIndex++];
			}
			throw new Exception("AllocateTempActorList");
		}

		// Token: 0x060034B6 RID: 13494 RVA: 0x000E1F84 File Offset: 0x000E0184
		public void FreeTempActorList(List<BattleActor> list)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FreeTempActorListList`1_hotfix != null)
			{
				this.m_FreeTempActorListList`1_hotfix.call(new object[]
				{
					this,
					list
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_freeActorListIndex > 0 && list == this.m_tempActorLists[this.m_freeActorListIndex - 1])
			{
				list.Clear();
				this.m_freeActorListIndex--;
				return;
			}
			throw new Exception("FreeTempActorList");
		}

		// Token: 0x060034B7 RID: 13495 RVA: 0x000E203C File Offset: 0x000E023C
		public List<ConfigDataBuffInfo> AllocateTempBuffList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AllocateTempBuffList_hotfix != null)
			{
				return (List<ConfigDataBuffInfo>)this.m_AllocateTempBuffList_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_freeBuffListIndex < this.m_tempBuffLists.Length)
			{
				return this.m_tempBuffLists[this.m_freeBuffListIndex++];
			}
			throw new Exception("AllocateTempBuffList");
		}

		// Token: 0x060034B8 RID: 13496 RVA: 0x000E20E4 File Offset: 0x000E02E4
		public void FreeTempBuffList(List<ConfigDataBuffInfo> list)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FreeTempBuffListList`1_hotfix != null)
			{
				this.m_FreeTempBuffListList`1_hotfix.call(new object[]
				{
					this,
					list
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_freeBuffListIndex > 0 && list == this.m_tempBuffLists[this.m_freeBuffListIndex - 1])
			{
				list.Clear();
				this.m_freeBuffListIndex--;
				return;
			}
			throw new Exception("FreeTempBuffList");
		}

		// Token: 0x060034B9 RID: 13497 RVA: 0x000E219C File Offset: 0x000E039C
		public List<BuffState> AllocateTempBuffStateList(List<BuffState> initValue = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AllocateTempBuffStateListList`1_hotfix != null)
			{
				return (List<BuffState>)this.m_AllocateTempBuffStateListList`1_hotfix.call(new object[]
				{
					this,
					initValue
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_freeBuffStateListIndex < this.m_tempBuffStateLists.Length)
			{
				List<BuffState> list = this.m_tempBuffStateLists[this.m_freeBuffStateListIndex++];
				if (initValue != null)
				{
					list.AddRange(initValue);
				}
				return list;
			}
			throw new Exception("AllocateTempBuffList");
		}

		// Token: 0x060034BA RID: 13498 RVA: 0x000E2264 File Offset: 0x000E0464
		public void FreeTempBuffStateList(List<BuffState> list)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FreeTempBuffStateListList`1_hotfix != null)
			{
				this.m_FreeTempBuffStateListList`1_hotfix.call(new object[]
				{
					this,
					list
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_freeBuffStateListIndex > 0 && list == this.m_tempBuffStateLists[this.m_freeBuffStateListIndex - 1])
			{
				list.Clear();
				this.m_freeBuffStateListIndex--;
				return;
			}
			throw new Exception("FreeTempBuffStateList");
		}

		// Token: 0x060034BB RID: 13499 RVA: 0x000E231C File Offset: 0x000E051C
		public void RandomizeBuffStateList(List<BuffState> buffStateList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RandomizeBuffStateListList`1_hotfix != null)
			{
				this.m_RandomizeBuffStateListList`1_hotfix.call(new object[]
				{
					this,
					buffStateList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			for (int i = 0; i < buffStateList.Count; i++)
			{
				int index = this.m_randomNumber.Next(0, buffStateList.Count);
				BuffState value = buffStateList[i];
				buffStateList[i] = buffStateList[index];
				buffStateList[index] = value;
			}
		}

		// Token: 0x060034BC RID: 13500 RVA: 0x000E23D4 File Offset: 0x000E05D4
		public BattlePropertyModifier GetTempBattlePropertyModifier()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTempBattlePropertyModifier_hotfix != null)
			{
				return (BattlePropertyModifier)this.m_GetTempBattlePropertyModifier_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_tempBattlePropertyModifier.Clear();
			return this.m_tempBattlePropertyModifier;
		}

		// Token: 0x060034BD RID: 13501 RVA: 0x000E2454 File Offset: 0x000E0654
		public bool IsProbabilitySatisfied(int rate)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsProbabilitySatisfiedInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsProbabilitySatisfiedInt32_hotfix.call(new object[]
				{
					this,
					rate
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return rate >= 10000 || (rate > 0 && this.m_randomNumber.Next(0, 10000) < rate);
		}

		// Token: 0x060034BE RID: 13502 RVA: 0x000E24FC File Offset: 0x000E06FC
		public void GetRandomBuffList(List<int> buffIds, int num, List<ConfigDataBuffInfo> buffList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRandomBuffListList`1Int32List`1_hotfix != null)
			{
				this.m_GetRandomBuffListList`1Int32List`1_hotfix.call(new object[]
				{
					this,
					buffIds,
					num,
					buffList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			buffList.Clear();
			if (buffIds.Count <= 0)
			{
				return;
			}
			if (num == buffIds.Count)
			{
				for (int i = 0; i < num; i++)
				{
					ConfigDataBuffInfo configDataBuffInfo = this.m_configDataLoader.GetConfigDataBuffInfo(buffIds[i]);
					if (configDataBuffInfo != null)
					{
						buffList.Add(configDataBuffInfo);
					}
				}
				return;
			}
			for (int j = 0; j < num; j++)
			{
				int num2 = 0;
				if (buffIds.Count > 1)
				{
					num2 = this.m_randomNumber.Next(0, buffIds.Count);
				}
				if (j < buffIds.Count)
				{
					for (int k = 0; k < buffIds.Count; k++)
					{
						int index = (num2 + k) % buffIds.Count;
						ConfigDataBuffInfo configDataBuffInfo2 = this.m_configDataLoader.GetConfigDataBuffInfo(buffIds[index]);
						if (configDataBuffInfo2 != null && !buffList.Contains(configDataBuffInfo2))
						{
							buffList.Add(configDataBuffInfo2);
							break;
						}
					}
				}
				else
				{
					ConfigDataBuffInfo configDataBuffInfo3 = this.m_configDataLoader.GetConfigDataBuffInfo(buffIds[num2]);
					if (configDataBuffInfo3 != null)
					{
						buffList.Add(configDataBuffInfo3);
					}
				}
			}
		}

		// Token: 0x060034BF RID: 13503 RVA: 0x000E26A4 File Offset: 0x000E08A4
		public ArmyRelationData ComputeArmyRelationData(ConfigDataArmyInfo attackerArmyInfo, ConfigDataArmyInfo targetArmyInfo, BattleActor attacker, BattleActor target, bool targetIsHero, bool isMagic)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeArmyRelationDataConfigDataArmyInfoConfigDataArmyInfoBattleActorBattleActorBooleanBoolean_hotfix != null)
			{
				return (ArmyRelationData)this.m_ComputeArmyRelationDataConfigDataArmyInfoConfigDataArmyInfoBattleActorBattleActorBooleanBoolean_hotfix.call(new object[]
				{
					this,
					attackerArmyInfo,
					targetArmyInfo,
					attacker,
					target,
					targetIsHero,
					isMagic
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ArmyRelationData result = default(ArmyRelationData);
			if (attackerArmyInfo == null || targetArmyInfo == null || attacker == null || target == null)
			{
				return result;
			}
			ArmyRelationData armyRelationData = this.m_configDataLoader.UtilityGetArmyRelationData(attackerArmyInfo.ArmyTag, targetArmyInfo.ArmyTag);
			result.Attack = armyRelationData.Attack;
			result.Defend = armyRelationData.Defend;
			result.Magic = armyRelationData.Magic;
			result.MagicDefend = armyRelationData.MagicDefend;
			int num;
			if (isMagic)
			{
				num = result.Magic - result.MagicDefend;
			}
			else
			{
				num = result.Attack - result.Defend;
			}
			attacker.AddBuffArmyRelationModifyAttack(num, targetIsHero, ref result);
			target.AddBuffArmyRelationModifyDefend(-num, targetIsHero, ref result);
			attacker.AddBuffArmyRelationAttack(targetArmyInfo.ID, targetIsHero, ref result);
			target.AddBuffArmyRelationDefend(attackerArmyInfo.ID, targetIsHero, ref result);
			return result;
		}

		// Token: 0x060034C0 RID: 13504 RVA: 0x000E284C File Offset: 0x000E0A4C
		public bool FindPath(GridPosition start, GridPosition goal, int movePoint, MoveType moveType, int ignoreTeam, int overrideMovePointCost, int inRegion, List<GridPosition> path, bool findNearestIfFail = false)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindPathGridPositionGridPositionInt32MoveTypeInt32Int32Int32List`1Boolean_hotfix != null)
			{
				return Convert.ToBoolean(this.m_FindPathGridPositionGridPositionInt32MoveTypeInt32Int32Int32List`1Boolean_hotfix.call(new object[]
				{
					this,
					start,
					goal,
					movePoint,
					moveType,
					ignoreTeam,
					overrideMovePointCost,
					inRegion,
					path,
					findNearestIfFail
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_pathfinder.FindPath(this.m_map, start, goal, movePoint, moveType, ignoreTeam, overrideMovePointCost, inRegion, path, findNearestIfFail);
		}

		// Token: 0x060034C1 RID: 13505 RVA: 0x000E2968 File Offset: 0x000E0B68
		public void FindMoveRegion(GridPosition start, int movePoint, MoveType moveType, int ignoreTeam, int overrideMovePointCost, int inRegion, List<GridPosition> region)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindMoveRegionGridPositionInt32MoveTypeInt32Int32Int32List`1_hotfix != null)
			{
				this.m_FindMoveRegionGridPositionInt32MoveTypeInt32Int32Int32List`1_hotfix.call(new object[]
				{
					this,
					start,
					movePoint,
					moveType,
					ignoreTeam,
					overrideMovePointCost,
					inRegion,
					region
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_pathfinder.FindRegion(this.m_map, start, movePoint, moveType, ignoreTeam, overrideMovePointCost, inRegion, region);
		}

		// Token: 0x060034C2 RID: 13506 RVA: 0x000E2A58 File Offset: 0x000E0C58
		public void FindAttackRegion(GridPosition start, int range, int shape, List<GridPosition> region)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindAttackRegionGridPositionInt32Int32List`1_hotfix != null)
			{
				this.m_FindAttackRegionGridPositionInt32Int32List`1_hotfix.call(new object[]
				{
					this,
					start,
					range,
					shape,
					region
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			region.Clear();
			int num = start.x - range;
			int num2 = start.x + range;
			int num3 = start.y - range;
			int num4 = start.y + range;
			if (num < 0)
			{
				num = 0;
			}
			if (num2 >= this.m_map.Width)
			{
				num2 = this.m_map.Width - 1;
			}
			if (num3 < 0)
			{
				num3 = 0;
			}
			if (num4 >= this.m_map.Height)
			{
				num4 = this.m_map.Height - 1;
			}
			if (shape == 1)
			{
				for (int i = num3; i <= num4; i++)
				{
					for (int j = num; j <= num2; j++)
					{
						region.Add(new GridPosition(j, i));
					}
				}
			}
			else if (shape == 2)
			{
				for (int k = num; k <= num2; k++)
				{
					region.Add(new GridPosition(k, start.y));
				}
				for (int l = num3; l <= num4; l++)
				{
					if (l != start.y)
					{
						region.Add(new GridPosition(start.x, l));
					}
				}
			}
			else
			{
				for (int m = num3; m <= num4; m++)
				{
					int num5 = m - start.y;
					if (num5 < 0)
					{
						num5 = -num5;
					}
					int num6 = range - num5;
					num = start.x - num6;
					num2 = start.x + num6;
					if (num < 0)
					{
						num = 0;
					}
					if (num2 >= this.m_map.Width)
					{
						num2 = this.m_map.Width - 1;
					}
					for (int n = num; n <= num2; n++)
					{
						region.Add(new GridPosition(n, m));
					}
				}
			}
		}

		// Token: 0x060034C3 RID: 13507 RVA: 0x000E2CC8 File Offset: 0x000E0EC8
		public void FindFixedDistanceRegion(GridPosition start, int distance, List<GridPosition> region)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindFixedDistanceRegionGridPositionInt32List`1_hotfix != null)
			{
				this.m_FindFixedDistanceRegionGridPositionInt32List`1_hotfix.call(new object[]
				{
					this,
					start,
					distance,
					region
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = start.x - distance;
			int num2 = start.x + distance;
			int num3 = start.y - distance;
			int num4 = start.y + distance;
			if (num < 0)
			{
				num = 0;
			}
			if (num2 >= this.m_map.Width)
			{
				num2 = this.m_map.Width - 1;
			}
			if (num3 < 0)
			{
				num3 = 0;
			}
			if (num4 >= this.m_map.Height)
			{
				num4 = this.m_map.Height - 1;
			}
			for (int i = num3; i <= num4; i++)
			{
				for (int j = num; j <= num2; j++)
				{
					GridPosition gridPosition = new GridPosition(j, i);
					if (GridPosition.Distance(gridPosition, start) == distance)
					{
						region.Add(gridPosition);
					}
				}
			}
		}

		// Token: 0x060034C4 RID: 13508 RVA: 0x000E2E20 File Offset: 0x000E1020
		public static bool IsInRegion(GridPosition start, GridPosition target, int range, int shape)
		{
			if (shape == 0)
			{
				return GridPosition.Distance(start, target) <= range;
			}
			if (shape == 1)
			{
				return Math.Abs(start.x - target.x) <= range && Math.Abs(start.y - target.y) <= range;
			}
			return shape == 2 && ((start.x == target.x && Math.Abs(start.y - target.y) <= range) || (start.y == target.y && Math.Abs(start.x - target.x) <= range));
		}

		// Token: 0x060034C5 RID: 13509 RVA: 0x000E2EEC File Offset: 0x000E10EC
		public bool IsInDangerRegion(int team, GridPosition pos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsInDangerRegionInt32GridPosition_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsInDangerRegionInt32GridPosition_hotfix.call(new object[]
				{
					this,
					team,
					pos
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<GridPosition> list = this.AllocateTempGridPositionList();
			List<GridPosition> list2 = this.AllocateTempGridPositionList();
			bool result = false;
			foreach (BattleActor battleActor in this.m_teams[team].GetActors())
			{
				if (!battleActor.IsDeadOrRetreat())
				{
					list.Clear();
					battleActor.FindMoveRegion(battleActor.Position, list);
					foreach (GridPosition gridPosition in list)
					{
						if (this.m_map.GetActor(gridPosition) == null)
						{
							if (gridPosition == pos)
							{
								result = true;
								goto IL_17B;
							}
							list2.Clear();
							this.FindAttackRegion(gridPosition, battleActor.GetMaxAttackDistance(), 0, list2);
							if (list2.Contains(pos))
							{
								result = true;
								goto IL_17B;
							}
						}
					}
				}
			}
			IL_17B:
			this.FreeTempGridPositionList(list2);
			this.FreeTempGridPositionList(list);
			return result;
		}

		// Token: 0x060034C6 RID: 13510 RVA: 0x000E30A0 File Offset: 0x000E12A0
		public int GetStars()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetStars_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetStars_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_stars;
		}

		// Token: 0x060034C7 RID: 13511 RVA: 0x000E3114 File Offset: 0x000E1314
		public bool IsWin()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsWin_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsWin_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_stars > 0;
		}

		// Token: 0x060034C8 RID: 13512 RVA: 0x000E318C File Offset: 0x000E138C
		public List<BattleActor> GetPlayerActors(int teamId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPlayerActorsInt32_hotfix != null)
			{
				return (List<BattleActor>)this.m_GetPlayerActorsInt32_hotfix.call(new object[]
				{
					this,
					teamId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<BattleActor> list = new List<BattleActor>();
			foreach (BattleActor battleActor in this.m_teams[teamId].GetActors())
			{
				if (!battleActor.IsNpc() && battleActor.GetSourceType() == BattleActorSourceType.Init)
				{
					list.Add(battleActor);
				}
			}
			return list;
		}

		// Token: 0x060034C9 RID: 13513 RVA: 0x000E327C File Offset: 0x000E147C
		public Dictionary<int, List<BattleActorLogInfo>> GetPlayerActorsLogInfos(int teamId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPlayerActorsLogInfosInt32_hotfix != null)
			{
				return (Dictionary<int, List<BattleActorLogInfo>>)this.m_GetPlayerActorsLogInfosInt32_hotfix.call(new object[]
				{
					this,
					teamId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Dictionary<int, List<BattleActorLogInfo>> dictionary = new Dictionary<int, List<BattleActorLogInfo>>();
			foreach (BattleActor battleActor in this.GetPlayerActors(teamId))
			{
				BattleActorLogInfo item = new BattleActorLogInfo
				{
					heroId = battleActor.HeroId,
					killEnemies = battleActor.GetKillActorCount(),
					useSkills = (int)battleActor.GetUseSkillCount(),
					deadTurn = ((battleActor.GetDieTurn() != -1) ? battleActor.GetDieTurn() : 0),
					killerId = ((battleActor.GetKillerActor() != null) ? battleActor.GetKillerActor().HeroId : 0)
				};
				if (!dictionary.ContainsKey(battleActor.PlayerIndex))
				{
					dictionary.Add(battleActor.PlayerIndex, new List<BattleActorLogInfo>());
				}
				dictionary[battleActor.PlayerIndex].Add(item);
			}
			return dictionary;
		}

		// Token: 0x060034CA RID: 13514 RVA: 0x000E33F0 File Offset: 0x000E15F0
		public int GetPlayerKillActorCount(int playerIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPlayerKillActorCountInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetPlayerKillActorCountInt32_hotfix.call(new object[]
				{
					this,
					playerIndex
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			foreach (BattleTeam battleTeam in this.m_teams)
			{
				foreach (BattleActor battleActor in battleTeam.GetActors())
				{
					if (battleActor.PlayerIndex == playerIndex)
					{
						num += battleActor.GetKillActorCount();
					}
				}
			}
			return num;
		}

		// Token: 0x060034CB RID: 13515 RVA: 0x000E34F0 File Offset: 0x000E16F0
		public List<BattleActor> GetDeadEnemyActors()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDeadEnemyActors_hotfix != null)
			{
				return (List<BattleActor>)this.m_GetDeadEnemyActors_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<BattleActor> list = new List<BattleActor>();
			foreach (BattleActor battleActor in this.m_teams[1].GetActors())
			{
				if (battleActor.IsDead())
				{
					list.Add(battleActor);
				}
			}
			return list;
		}

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x060034CC RID: 13516 RVA: 0x000E35C4 File Offset: 0x000E17C4
		public string AliveActorsInfo
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_AliveActorsInfo_hotfix != null)
				{
					return (string)this.m_get_AliveActorsInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.AppendLine(string.Empty);
				stringBuilder.AppendLine("Friends:");
				foreach (BattleActor battleActor in this.m_teams[0].GetActors())
				{
					if (!battleActor.IsDeadOrRetreat())
					{
						stringBuilder.AppendLine(battleActor.InstanceID);
					}
				}
				stringBuilder.AppendLine("Enemies:");
				foreach (BattleActor battleActor2 in this.m_teams[1].GetActors())
				{
					if (!battleActor2.IsDeadOrRetreat())
					{
						stringBuilder.AppendLine(battleActor2.InstanceID);
					}
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x060034CD RID: 13517 RVA: 0x000E372C File Offset: 0x000E192C
		public void EnableChecksum(bool enable)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EnableChecksumBoolean_hotfix != null)
			{
				this.m_EnableChecksumBoolean_hotfix.call(new object[]
				{
					this,
					enable
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_enableChecksum = enable;
		}

		// Token: 0x060034CE RID: 13518 RVA: 0x000E37A4 File Offset: 0x000E19A4
		public List<int> GetChecksums()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetChecksums_hotfix != null)
			{
				return (List<int>)this.m_GetChecksums_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_checksums;
		}

		// Token: 0x060034CF RID: 13519 RVA: 0x000E3818 File Offset: 0x000E1A18
		private void ComputeStepChecksum()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeStepChecksum_hotfix != null)
			{
				this.m_ComputeStepChecksum_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			foreach (BattleTeam battleTeam in this.m_teams)
			{
				foreach (BattleActor battleActor in battleTeam.GetActors())
				{
					num += battleActor.Position.x + battleActor.Position.y;
					num += battleActor.HeroHealthPoint + battleActor.SoldierTotalHealthPoint;
				}
			}
			this.m_checksums.Add(num);
		}

		// Token: 0x060034D0 RID: 13520 RVA: 0x000E3928 File Offset: 0x000E1B28
		public void EnableDebugLog(bool enable)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EnableDebugLogBoolean_hotfix != null)
			{
				this.m_EnableDebugLogBoolean_hotfix.call(new object[]
				{
					this,
					enable
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_enableDebugLog = enable;
		}

		// Token: 0x060034D1 RID: 13521 RVA: 0x000E39A0 File Offset: 0x000E1BA0
		public bool IsEnableDebugLog()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsEnableDebugLog_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsEnableDebugLog_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_enableDebugLog;
		}

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x060034D2 RID: 13522 RVA: 0x000E3A14 File Offset: 0x000E1C14
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

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x060034D3 RID: 13523 RVA: 0x000E3A88 File Offset: 0x000E1C88
		public IBattleListener Listener
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Listener_hotfix != null)
				{
					return (IBattleListener)this.m_get_Listener_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_battleListener;
			}
		}

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x060034D4 RID: 13524 RVA: 0x000E3AFC File Offset: 0x000E1CFC
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

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x060034D5 RID: 13525 RVA: 0x000E3B70 File Offset: 0x000E1D70
		public RandomNumber AIRandomNumber1
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_AIRandomNumber1_hotfix != null)
				{
					return (RandomNumber)this.m_get_AIRandomNumber1_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_aiRandomNumber1;
			}
		}

		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x060034D6 RID: 13526 RVA: 0x000E3BE4 File Offset: 0x000E1DE4
		public RandomNumber AIRandomNumber2
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_AIRandomNumber2_hotfix != null)
				{
					return (RandomNumber)this.m_get_AIRandomNumber2_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_aiRandomNumber2;
			}
		}

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x060034D7 RID: 13527 RVA: 0x000E3C58 File Offset: 0x000E1E58
		public ConfigDataBattleInfo BattleInfo
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_BattleInfo_hotfix != null)
				{
					return (ConfigDataBattleInfo)this.m_get_BattleInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_battleInfo;
			}
		}

		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x060034D8 RID: 13528 RVA: 0x000E3CCC File Offset: 0x000E1ECC
		public ConfigDataArenaBattleInfo ArenaBattleInfo
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_ArenaBattleInfo_hotfix != null)
				{
					return (ConfigDataArenaBattleInfo)this.m_get_ArenaBattleInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_arenaBattleInfo;
			}
		}

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x060034D9 RID: 13529 RVA: 0x000E3D40 File Offset: 0x000E1F40
		public ConfigDataPVPBattleInfo PVPBattleInfo
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_PVPBattleInfo_hotfix != null)
				{
					return (ConfigDataPVPBattleInfo)this.m_get_PVPBattleInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_pvpBattleInfo;
			}
		}

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x060034DA RID: 13530 RVA: 0x000E3DB4 File Offset: 0x000E1FB4
		public ConfigDataRealTimePVPBattleInfo RealTimePVPBattleInfo
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_RealTimePVPBattleInfo_hotfix != null)
				{
					return (ConfigDataRealTimePVPBattleInfo)this.m_get_RealTimePVPBattleInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_realtimePvpBattleInfo;
			}
		}

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x060034DB RID: 13531 RVA: 0x000E3E28 File Offset: 0x000E2028
		public BattleType BattleType
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_BattleType_hotfix != null)
				{
					return (BattleType)this.m_get_BattleType_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_battleType;
			}
		}

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x060034DC RID: 13532 RVA: 0x000E3E9C File Offset: 0x000E209C
		public ActionOrderType ActionOrderType
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_ActionOrderType_hotfix != null)
				{
					return (ActionOrderType)this.m_get_ActionOrderType_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_actionOrderType;
			}
		}

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x060034DD RID: 13533 RVA: 0x000E3F10 File Offset: 0x000E2110
		public BattlePlayer[] BattlePlayers
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_BattlePlayers_hotfix != null)
				{
					return (BattlePlayer[])this.m_get_BattlePlayers_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_players;
			}
		}

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x060034DE RID: 13534 RVA: 0x000E3F84 File Offset: 0x000E2184
		public ConfigDataPlayerLevelInfo MaxPlayerLevelInfo
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_MaxPlayerLevelInfo_hotfix != null)
				{
					return (ConfigDataPlayerLevelInfo)this.m_get_MaxPlayerLevelInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_maxPlayerLevelInfo;
			}
		}

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x060034DF RID: 13535 RVA: 0x000E3FF8 File Offset: 0x000E21F8
		public BattleState State
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_State_hotfix != null)
				{
					return (BattleState)this.m_get_State_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_state;
			}
		}

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x060034E0 RID: 13536 RVA: 0x000E406C File Offset: 0x000E226C
		public int Step
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Step_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_Step_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_step;
			}
		}

		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x060034E1 RID: 13537 RVA: 0x000E40E0 File Offset: 0x000E22E0
		public int Turn
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Turn_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_Turn_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_turn;
			}
		}

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x060034E2 RID: 13538 RVA: 0x000E4154 File Offset: 0x000E2354
		public int TurnMax
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_TurnMax_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_TurnMax_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_turnMax;
			}
		}

		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x060034E3 RID: 13539 RVA: 0x000E41C8 File Offset: 0x000E23C8
		public BattleMap Map
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Map_hotfix != null)
				{
					return (BattleMap)this.m_get_Map_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_map;
			}
		}

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x060034E4 RID: 13540 RVA: 0x000E423C File Offset: 0x000E243C
		public Combat Combat
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Combat_hotfix != null)
				{
					return (Combat)this.m_get_Combat_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_combat;
			}
		}

		// Token: 0x060034E5 RID: 13541 RVA: 0x000E42B0 File Offset: 0x000E24B0
		private void CheckAchievementOnActorMove(BattleActor actor)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckAchievementOnActorMoveBattleActor_hotfix != null)
			{
				this.m_CheckAchievementOnActorMoveBattleActor_hotfix.call(new object[]
				{
					this,
					actor
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleAchievementState battleAchievementState in this.m_achievementStates)
			{
				if (battleAchievementState.m_status == BattleConditionStatus.Progress)
				{
					ConfigDataBattleAchievementInfo achievementInfo = battleAchievementState.m_achievementRelatedInfo.m_achievementInfo;
					if (achievementInfo.ConditionType == BattleAchievementConditionType.BattleAchievementConditionType_ActorReachPosition)
					{
						if (this.m_turn <= battleAchievementState.m_turnCount)
						{
							if (achievementInfo.ActorID.Count > 0)
							{
								if (achievementInfo.ActorID.Contains(actor.HeroId) && this.IsActorReachPositions(actor, achievementInfo.ConditionParam2, battleAchievementState.m_conditionId))
								{
									this.ChangeAchievementStatus(battleAchievementState, true);
								}
							}
							else
							{
								NpcCondition npcCondition = NpcCondition.DontCare;
								if (achievementInfo.ConditionParam1 == 2)
								{
									npcCondition = NpcCondition.NotNpc;
								}
								else if (achievementInfo.ConditionParam1 == 3)
								{
									npcCondition = NpcCondition.IsNpc;
								}
								if (actor.TeamNumber == 0 && this.IsActorReachPositions(actor, npcCondition, achievementInfo.ConditionParam2, battleAchievementState.m_conditionId))
								{
									this.ChangeAchievementStatus(battleAchievementState, true);
								}
							}
						}
						else
						{
							this.ChangeAchievementStatus(battleAchievementState, false);
						}
					}
					else if (achievementInfo.ConditionType == BattleAchievementConditionType.BattleAchievementConditionType_ActorNotReachPosition)
					{
						if (this.m_turn <= battleAchievementState.m_turnCount)
						{
							if (achievementInfo.ActorID.Count > 0)
							{
								if (achievementInfo.ActorID.Contains(actor.HeroId) && this.IsActorReachPositions(actor, achievementInfo.ConditionParam2, battleAchievementState.m_conditionId))
								{
									this.ChangeAchievementStatus(battleAchievementState, false);
								}
							}
							else if (actor.TeamNumber == 1 && this.IsActorReachPositions(actor, achievementInfo.ConditionParam2, battleAchievementState.m_conditionId))
							{
								this.ChangeAchievementStatus(battleAchievementState, false);
							}
						}
						else
						{
							this.ChangeAchievementStatus(battleAchievementState, false);
						}
					}
				}
			}
		}

		// Token: 0x060034E6 RID: 13542 RVA: 0x000E4500 File Offset: 0x000E2700
		private void CheckAchievementOnActorDie(BattleActor actor)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckAchievementOnActorDieBattleActor_hotfix != null)
			{
				this.m_CheckAchievementOnActorDieBattleActor_hotfix.call(new object[]
				{
					this,
					actor
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleAchievementState battleAchievementState in this.m_achievementStates)
			{
				if (battleAchievementState.m_status == BattleConditionStatus.Progress)
				{
					ConfigDataBattleAchievementInfo achievementInfo = battleAchievementState.m_achievementRelatedInfo.m_achievementInfo;
					if (achievementInfo.ConditionType == BattleAchievementConditionType.BattleAchievementConditionType_KillActor)
					{
						if (this.m_turn <= battleAchievementState.m_turnCount)
						{
							if (achievementInfo.ActorID.Contains(actor.HeroId))
							{
								this.ChangeAchievementStatus(battleAchievementState, true);
							}
						}
						else
						{
							this.ChangeAchievementStatus(battleAchievementState, false);
						}
					}
					else if (achievementInfo.ConditionType == BattleAchievementConditionType.BattleAchievementConditionType_SkillKillActor)
					{
						if (this.m_turn <= battleAchievementState.m_turnCount)
						{
							if (achievementInfo.ActorID.Contains(actor.HeroId) && this.IsActorsAllKillBySkillClass(achievementInfo.ActorID, achievementInfo.ConditionParam1))
							{
								this.ChangeAchievementStatus(battleAchievementState, true);
							}
						}
						else
						{
							this.ChangeAchievementStatus(battleAchievementState, false);
						}
					}
					else if (achievementInfo.ConditionType == BattleAchievementConditionType.BattleAchievementConditionType_KillCount)
					{
						int conditionParam = achievementInfo.ConditionParam1;
						if (conditionParam > 0)
						{
							if (this.m_turn <= battleAchievementState.m_turnCount)
							{
								if (this.m_teams[1].ComputeDeadActorCount(achievementInfo.ActorID, NpcCondition.DontCare) >= conditionParam)
								{
									this.ChangeAchievementStatus(battleAchievementState, true);
								}
							}
							else
							{
								this.ChangeAchievementStatus(battleAchievementState, false);
							}
						}
					}
				}
			}
		}

		// Token: 0x060034E7 RID: 13543 RVA: 0x000E46F0 File Offset: 0x000E28F0
		private void CheckAchievementOnNextStep()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckAchievementOnNextStep_hotfix != null)
			{
				this.m_CheckAchievementOnNextStep_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleAchievementState battleAchievementState in this.m_achievementStates)
			{
				if (battleAchievementState.m_status == BattleConditionStatus.Progress)
				{
					ConfigDataBattleAchievementInfo achievementInfo = battleAchievementState.m_achievementRelatedInfo.m_achievementInfo;
					if (achievementInfo.ConditionType == BattleAchievementConditionType.BattleAchievementConditionType_ActorHpLess)
					{
						if (this.m_turn <= battleAchievementState.m_turnCount)
						{
							foreach (int heroId in achievementInfo.ActorID)
							{
								BattleActor actorByHeroId = this.m_teams[1].GetActorByHeroId(heroId, false);
								if (actorByHeroId != null && actorByHeroId.GetTotalHealthPoint() * 10000 / actorByHeroId.GetTotalHealthPointMax() <= achievementInfo.ConditionParam1)
								{
									this.ChangeAchievementStatus(battleAchievementState, true);
									break;
								}
							}
						}
						else
						{
							this.ChangeAchievementStatus(battleAchievementState, false);
						}
					}
				}
			}
		}

		// Token: 0x060034E8 RID: 13544 RVA: 0x000E486C File Offset: 0x000E2A6C
		private void CheckAchievementOnTurnEndOrWin(bool isWin)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckAchievementOnTurnEndOrWinBoolean_hotfix != null)
			{
				this.m_CheckAchievementOnTurnEndOrWinBoolean_hotfix.call(new object[]
				{
					this,
					isWin
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleAchievementState battleAchievementState in this.m_achievementStates)
			{
				if (battleAchievementState.m_status == BattleConditionStatus.Progress)
				{
					ConfigDataBattleAchievementInfo achievementInfo = battleAchievementState.m_achievementRelatedInfo.m_achievementInfo;
					if (achievementInfo.ConditionType == BattleAchievementConditionType.BattleAchievementConditionType_ActorNotDamage)
					{
						if (this.m_turn <= battleAchievementState.m_turnCount)
						{
							bool flag = false;
							foreach (int heroId in achievementInfo.ActorID)
							{
								BattleActor actorByHeroId = this.GetActorByHeroId(heroId);
								if (actorByHeroId != null)
								{
									if (actorByHeroId.GetFirstDamageTurn() != 0 && actorByHeroId.GetFirstDamageTurn() <= this.m_turn)
									{
										flag = true;
										break;
									}
								}
							}
							if (flag)
							{
								this.ChangeAchievementStatus(battleAchievementState, false);
							}
							else if (isWin || this.m_turn == battleAchievementState.m_turnCount)
							{
								this.ChangeAchievementStatus(battleAchievementState, true);
							}
						}
						else
						{
							this.ChangeAchievementStatus(battleAchievementState, false);
						}
					}
					else if (achievementInfo.ConditionType == BattleAchievementConditionType.BattleAchievementConditionType_PlayerDieLess)
					{
						if (this.m_turn <= battleAchievementState.m_turnCount)
						{
							int num = this.m_teams[0].ComputeDeadActorCount(null, NpcCondition.NotNpc);
							if (num > achievementInfo.ConditionParam1)
							{
								this.ChangeAchievementStatus(battleAchievementState, false);
							}
							else if (isWin || this.m_turn == battleAchievementState.m_turnCount)
							{
								this.ChangeAchievementStatus(battleAchievementState, true);
							}
						}
						else
						{
							this.ChangeAchievementStatus(battleAchievementState, false);
						}
					}
					else if (achievementInfo.ConditionType == BattleAchievementConditionType.BattleAchievementConditionType_NpcDieLess)
					{
						if (this.m_turn <= battleAchievementState.m_turnCount)
						{
							int num2 = this.m_teams[0].ComputeDeadActorCount(achievementInfo.ActorID, NpcCondition.IsNpc);
							if (num2 > achievementInfo.ConditionParam1)
							{
								this.ChangeAchievementStatus(battleAchievementState, false);
							}
							else if (isWin || this.m_turn == battleAchievementState.m_turnCount)
							{
								this.ChangeAchievementStatus(battleAchievementState, true);
							}
						}
						else
						{
							this.ChangeAchievementStatus(battleAchievementState, false);
						}
					}
					else if (achievementInfo.ConditionType == BattleAchievementConditionType.BattleAchievementConditionType_ActorNotReachPosition)
					{
						if (this.m_turn <= battleAchievementState.m_turnCount)
						{
							bool flag2;
							if (achievementInfo.ActorID.Count > 0)
							{
								flag2 = this.IsActorsAnyReachPositions(achievementInfo.ActorID, achievementInfo.ConditionParam2, battleAchievementState.m_conditionId);
							}
							else
							{
								flag2 = this.IsActorsAnyReachPositions(1, NpcCondition.DontCare, achievementInfo.ConditionParam2, battleAchievementState.m_conditionId);
							}
							if (flag2)
							{
								this.ChangeAchievementStatus(battleAchievementState, false);
							}
							else if (isWin || this.m_turn == battleAchievementState.m_turnCount)
							{
								this.ChangeAchievementStatus(battleAchievementState, true);
							}
						}
						else
						{
							this.ChangeAchievementStatus(battleAchievementState, false);
						}
					}
				}
			}
		}

		// Token: 0x060034E9 RID: 13545 RVA: 0x000E4BE0 File Offset: 0x000E2DE0
		private void CheckAchievementOnWin()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckAchievementOnWin_hotfix != null)
			{
				this.m_CheckAchievementOnWin_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleAchievementState battleAchievementState in this.m_achievementStates)
			{
				if (battleAchievementState.m_status == BattleConditionStatus.Progress)
				{
					ConfigDataBattleAchievementInfo achievementInfo = battleAchievementState.m_achievementRelatedInfo.m_achievementInfo;
					if (achievementInfo.ConditionType == BattleAchievementConditionType.BattleAchievementConditionType_ActorNotDead)
					{
						this.ChangeAchievementStatus(battleAchievementState, this.IsActorsAllAlive(achievementInfo.ActorID));
					}
					else if (achievementInfo.ConditionType == BattleAchievementConditionType.BattleAchievementConditionType_TurnCount)
					{
						this.ChangeAchievementStatus(battleAchievementState, this.m_turn <= battleAchievementState.m_turnCount);
					}
					else if (achievementInfo.ConditionType == BattleAchievementConditionType.BattleAchievementConditionType_ActorCount)
					{
						this.ChangeAchievementStatus(battleAchievementState, this.m_teams[0].InitNotNpcActorCount <= achievementInfo.ConditionParam1);
					}
				}
			}
		}

		// Token: 0x060034EA RID: 13546 RVA: 0x000E4D20 File Offset: 0x000E2F20
		private void CheckAchievementOnLose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckAchievementOnLose_hotfix != null)
			{
				this.m_CheckAchievementOnLose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleAchievementState battleAchievementState in this.m_achievementStates)
			{
				if (battleAchievementState.m_status == BattleConditionStatus.Progress)
				{
					this.ChangeAchievementStatus(battleAchievementState, false);
				}
			}
		}

		// Token: 0x060034EB RID: 13547 RVA: 0x000E4DDC File Offset: 0x000E2FDC
		private void ChangeAchievementStatus(BattleAchievementState bs, bool success)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ChangeAchievementStatusBattleAchievementStateBoolean_hotfix != null)
			{
				this.m_ChangeAchievementStatusBattleAchievementStateBoolean_hotfix.call(new object[]
				{
					this,
					bs,
					success
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleConditionStatus battleConditionStatus = (!success) ? BattleConditionStatus.Fail : BattleConditionStatus.Success;
			if (bs.m_status == battleConditionStatus)
			{
				return;
			}
			bs.m_status = battleConditionStatus;
			if (success)
			{
				if (this.IsEnableDebugLog())
				{
					DebugUtility.Log(string.Format("BattleBase.ChangeAchievementStatus(), achievementRelatedId {0}", bs.m_achievementRelatedInfo.ID));
				}
				this.CheckEventTriggerOnCompleteAchievement(bs.m_achievementRelatedInfo.Achievement_ID);
			}
		}

		// Token: 0x060034EC RID: 13548 RVA: 0x000E4EC0 File Offset: 0x000E30C0
		private bool IsActorsAllAlive(List<int> heroIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsActorsAllAliveList`1_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsActorsAllAliveList`1_hotfix.call(new object[]
				{
					this,
					heroIds
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (heroIds.Count <= 0)
			{
				return false;
			}
			int num = 0;
			foreach (int heroId in heroIds)
			{
				BattleActor actorByHeroId = this.GetActorByHeroId(heroId);
				if (actorByHeroId != null)
				{
					if (actorByHeroId.IsDead())
					{
						return false;
					}
					num++;
				}
			}
			return num > 0;
		}

		// Token: 0x060034ED RID: 13549 RVA: 0x000E4FC0 File Offset: 0x000E31C0
		private bool IsActorsAllKillBySkillClass(List<int> heroIds, int skillClass)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsActorsAllKillBySkillClassList`1Int32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsActorsAllKillBySkillClassList`1Int32_hotfix.call(new object[]
				{
					this,
					heroIds,
					skillClass
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (heroIds.Count <= 0)
			{
				return false;
			}
			int num = 0;
			foreach (int heroId in heroIds)
			{
				BattleActor actorByHeroId = this.GetActorByHeroId(heroId);
				if (actorByHeroId != null)
				{
					if (!actorByHeroId.IsDead())
					{
						return false;
					}
					if (!BattleBase.IsSkillClassMatch(actorByHeroId.GetLastDamageBySkill(), skillClass))
					{
						return false;
					}
					num++;
				}
			}
			return num > 0;
		}

		// Token: 0x060034EE RID: 13550 RVA: 0x000E50F4 File Offset: 0x000E32F4
		private bool IsActorReachPositions(BattleActor a, List<ParamPosition> positions, int conditionId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsActorReachPositionsBattleActorList`1Int32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsActorReachPositionsBattleActorList`1Int32_hotfix.call(new object[]
				{
					this,
					a,
					positions,
					conditionId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (a == null)
			{
				return false;
			}
			if (a.IsSatisfyCondition(conditionId))
			{
				return true;
			}
			if (BattleBase.IsActorInPositions(a, positions))
			{
				a.SetSetisfyCondition(conditionId);
				return true;
			}
			return false;
		}

		// Token: 0x060034EF RID: 13551 RVA: 0x000E51BC File Offset: 0x000E33BC
		private bool IsActorReachPositions(BattleActor a, NpcCondition npcCondition, List<ParamPosition> positions, int conditionId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsActorReachPositionsBattleActorNpcConditionList`1Int32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsActorReachPositionsBattleActorNpcConditionList`1Int32_hotfix.call(new object[]
				{
					this,
					a,
					npcCondition,
					positions,
					conditionId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (a == null)
			{
				return false;
			}
			if (npcCondition == NpcCondition.IsNpc)
			{
				if (!a.IsAINpc())
				{
					return false;
				}
			}
			else if (npcCondition == NpcCondition.NotNpc && a.IsAINpc())
			{
				return false;
			}
			return this.IsActorReachPositions(a, positions, conditionId);
		}

		// Token: 0x060034F0 RID: 13552 RVA: 0x000E52A8 File Offset: 0x000E34A8
		private bool IsActorsAnyReachPositions(List<int> heroIds, List<ParamPosition> positions, int conditionId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsActorsAnyReachPositionsList`1List`1Int32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsActorsAnyReachPositionsList`1List`1Int32_hotfix.call(new object[]
				{
					this,
					heroIds,
					positions,
					conditionId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (int heroId in heroIds)
			{
				BattleActor actorByHeroId = this.GetActorByHeroId(heroId);
				if (actorByHeroId != null)
				{
					if (this.IsActorReachPositions(actorByHeroId, positions, conditionId))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060034F1 RID: 13553 RVA: 0x000E53B4 File Offset: 0x000E35B4
		private bool IsActorsAnyReachPositions(int team, NpcCondition npcCondition, List<ParamPosition> positions, int conditionId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsActorsAnyReachPositionsInt32NpcConditionList`1Int32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsActorsAnyReachPositionsInt32NpcConditionList`1Int32_hotfix.call(new object[]
				{
					this,
					team,
					npcCondition,
					positions,
					conditionId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleActor a in this.m_teams[team].GetActors())
			{
				if (this.IsActorReachPositions(a, npcCondition, positions, conditionId))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060034F2 RID: 13554 RVA: 0x000E54CC File Offset: 0x000E36CC
		private int GetActorsCountSatisfyCondition(int team, NpcCondition npcCondition, int conditionId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetActorsCountSatisfyConditionInt32NpcConditionInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetActorsCountSatisfyConditionInt32NpcConditionInt32_hotfix.call(new object[]
				{
					this,
					team,
					npcCondition,
					conditionId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			foreach (BattleActor battleActor in this.m_teams[team].GetActors())
			{
				if (npcCondition == NpcCondition.IsNpc)
				{
					if (!battleActor.IsAINpc())
					{
						continue;
					}
				}
				else if (npcCondition == NpcCondition.NotNpc && battleActor.IsAINpc())
				{
					continue;
				}
				if (battleActor.IsSatisfyCondition(conditionId))
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x060034F3 RID: 13555 RVA: 0x000E5600 File Offset: 0x000E3800
		private static bool IsActorInPositions(BattleActor a, List<ParamPosition> positions)
		{
			foreach (ParamPosition paramPosition in positions)
			{
				if (a.Position.x == paramPosition.X && a.Position.y == paramPosition.Y)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060034F4 RID: 13556 RVA: 0x000E5690 File Offset: 0x000E3890
		private static bool IsSkillClassMatch(ConfigDataSkillInfo skillInfo, int skillClass)
		{
			return skillInfo != null && (skillClass != 1 || skillInfo.IsNormalAttack());
		}

		// Token: 0x060034F5 RID: 13557 RVA: 0x000E56AC File Offset: 0x000E38AC
		private static bool IsActorClassMatch(BattleActor actor, int actorClass)
		{
			if (actor == null)
			{
				return false;
			}
			if (actorClass == 1)
			{
				return actor.TeamNumber == 0;
			}
			if (actorClass == 2)
			{
				return actor.TeamNumber == 0 && !actor.IsNpc();
			}
			if (actorClass == 3)
			{
				return actor.TeamNumber == 0 && actor.IsNpc();
			}
			return actorClass == 4 && actor.TeamNumber == 1;
		}

		// Token: 0x060034F6 RID: 13558 RVA: 0x000E5720 File Offset: 0x000E3920
		public bool IsAchievementComplete(int achievementReleatedId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsAchievementCompleteInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsAchievementCompleteInt32_hotfix.call(new object[]
				{
					this,
					achievementReleatedId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleAchievementState battleAchievementState in this.m_achievementStates)
			{
				if (battleAchievementState.m_achievementRelatedInfo.ID == achievementReleatedId && battleAchievementState.m_status == BattleConditionStatus.Success)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060034F7 RID: 13559 RVA: 0x000E580C File Offset: 0x000E3A0C
		public List<int> GetCompleteAchievements()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCompleteAchievements_hotfix != null)
			{
				return (List<int>)this.m_GetCompleteAchievements_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<int> list = new List<int>();
			foreach (BattleAchievementState battleAchievementState in this.m_achievementStates)
			{
				if (battleAchievementState.m_status == BattleConditionStatus.Success)
				{
					list.Add(battleAchievementState.m_achievementRelatedInfo.ID);
				}
			}
			return list;
		}

		// Token: 0x060034F8 RID: 13560 RVA: 0x000E58E4 File Offset: 0x000E3AE4
		public BattleConditionStatus GetAchievementStatus(int achievementReleatedId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAchievementStatusInt32_hotfix != null)
			{
				return (BattleConditionStatus)this.m_GetAchievementStatusInt32_hotfix.call(new object[]
				{
					this,
					achievementReleatedId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleAchievementState battleAchievementState in this.m_achievementStates)
			{
				if (battleAchievementState.m_achievementRelatedInfo.ID == achievementReleatedId)
				{
					return battleAchievementState.m_status;
				}
			}
			return BattleConditionStatus.None;
		}

		// Token: 0x060034F9 RID: 13561 RVA: 0x000E59C8 File Offset: 0x000E3BC8
		public void AddBattleCommand(BattleCommand cmd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddBattleCommandBattleCommand_hotfix != null)
			{
				this.m_AddBattleCommandBattleCommand_hotfix.call(new object[]
				{
					this,
					cmd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (cmd == null)
			{
				return;
			}
			if (this.m_enableTempBattleCommands)
			{
				this.AddBattleCommandToList(this.m_tempBattleCommands, cmd);
				return;
			}
			this.AddBattleCommandToList(this.m_battleCommands, cmd);
		}

		// Token: 0x060034FA RID: 13562 RVA: 0x000E5A68 File Offset: 0x000E3C68
		private void AddLogBattleCommand(BattleCommand cmd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddLogBattleCommandBattleCommand_hotfix != null)
			{
				this.m_AddLogBattleCommandBattleCommand_hotfix.call(new object[]
				{
					this,
					cmd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleActor actorById = this.GetActorById(cmd.ActorId);
			if (actorById == null || actorById.IsPlayerActor())
			{
				this.AddBattleCommandToList(this.m_logBattleCommands, cmd);
			}
		}

		// Token: 0x060034FB RID: 13563 RVA: 0x000E5B04 File Offset: 0x000E3D04
		public void AddGiveupLogBattleCommand(int playerIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddGiveupLogBattleCommandInt32_hotfix != null)
			{
				this.m_AddGiveupLogBattleCommandInt32_hotfix.call(new object[]
				{
					this,
					playerIndex
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleCommand battleCommand = new BattleCommand();
			battleCommand.Type = BattleCommandType.Giveup;
			battleCommand.Step = this.m_step;
			if (battleCommand.Step == 0)
			{
				battleCommand.Step = 1;
			}
			battleCommand.SkillIndex = playerIndex;
			this.AddLogBattleCommand(battleCommand);
		}

		// Token: 0x060034FC RID: 13564 RVA: 0x000E5BB0 File Offset: 0x000E3DB0
		public void AddCancelLogBattleCommand(int playerIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddCancelLogBattleCommandInt32_hotfix != null)
			{
				this.m_AddCancelLogBattleCommandInt32_hotfix.call(new object[]
				{
					this,
					playerIndex
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleCommand battleCommand = new BattleCommand();
			battleCommand.Type = BattleCommandType.Cancel;
			battleCommand.Step = this.m_step;
			if (battleCommand.Step == 0)
			{
				battleCommand.Step = 1;
			}
			battleCommand.SkillIndex = playerIndex;
			this.AddLogBattleCommand(battleCommand);
		}

		// Token: 0x060034FD RID: 13565 RVA: 0x000E5C5C File Offset: 0x000E3E5C
		private void AddBattleCommandToList(LinkedList<BattleCommand> commands, BattleCommand command)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddBattleCommandToListLinkedList`1BattleCommand_hotfix != null)
			{
				this.m_AddBattleCommandToListLinkedList`1BattleCommand_hotfix.call(new object[]
				{
					this,
					commands,
					command
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LinkedListNode<BattleCommand> linkedListNode;
			for (linkedListNode = commands.Last; linkedListNode != null; linkedListNode = linkedListNode.Previous)
			{
				if (linkedListNode.Value.Step <= command.Step)
				{
					break;
				}
			}
			if (linkedListNode != null)
			{
				LinkedListNode<BattleCommand> linkedListNode2 = commands.AddAfter(linkedListNode, command);
				if (linkedListNode2 != null && linkedListNode2.Previous != null && linkedListNode2.Value.ActorId == linkedListNode2.Previous.Value.ActorId && linkedListNode2.Value.Step == linkedListNode2.Previous.Value.Step && linkedListNode2.Value.Type == BattleCommandType.Done && (linkedListNode2.Previous.Value.Type == BattleCommandType.Skill || linkedListNode2.Previous.Value.Type == BattleCommandType.Combat) && this.IsEnableDebugLog())
				{
					DebugUtility.LogError(string.Format("BattleBase.AddBattleCommandToList() error, ActorId {0} has {1} and {2}.", linkedListNode2.Value.ActorId, linkedListNode2.Previous.Value.Type, linkedListNode2.Value.Type));
				}
			}
			else
			{
				commands.AddFirst(command);
			}
		}

		// Token: 0x060034FE RID: 13566 RVA: 0x000E5E0C File Offset: 0x000E400C
		public void ClearBattleCommandsAndNextStep()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearBattleCommandsAndNextStep_hotfix != null)
			{
				this.m_ClearBattleCommandsAndNextStep_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleCommands.Clear();
			this.NextStep();
		}

		// Token: 0x060034FF RID: 13567 RVA: 0x000E5E80 File Offset: 0x000E4080
		public bool HasBattleCommand()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasBattleCommand_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasBattleCommand_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_battleCommands.Count > 0;
		}

		// Token: 0x06003500 RID: 13568 RVA: 0x000E5EFC File Offset: 0x000E40FC
		public bool HasCurrentStepBattleCommand()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasCurrentStepBattleCommand_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasCurrentStepBattleCommand_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_battleCommands.Count > 0 && this.m_battleCommands.First.Value.Step == this.m_step;
		}

		// Token: 0x06003501 RID: 13569 RVA: 0x000E5F98 File Offset: 0x000E4198
		private bool HasWrongStepBattleCommand()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasWrongStepBattleCommand_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasWrongStepBattleCommand_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_battleCommands.Count > 0 && this.m_battleCommands.First.Value.Step < this.m_step;
		}

		// Token: 0x06003502 RID: 13570 RVA: 0x000E6034 File Offset: 0x000E4234
		public bool ExecuteBattleCommand()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteBattleCommand_hotfix != null)
			{
				return Convert.ToBoolean(this.m_ExecuteBattleCommand_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_stepExecutedCommands.Clear();
			if (this.m_battleCommands.Count <= 0)
			{
				if (this.IsEnableDebugLog())
				{
					DebugUtility.LogError("BattleBase.ExecuteBattleCommand() error, commands count is 0.");
				}
				return false;
			}
			BattleCommand value = this.m_battleCommands.First.Value;
			if (value.Type == BattleCommandType.Giveup)
			{
				if (this.m_arenaBattleInfo != null || this.m_realtimePvpBattleInfo != null)
				{
					int skillIndex = value.SkillIndex;
					this.ExecuteGiveupCommand(skillIndex);
					this.AddExecutedCommand(value);
					return true;
				}
				if (this.IsEnableDebugLog())
				{
					DebugUtility.LogError("BattleBase.ExecuteBattleCommand() error, can't exec giveup command.");
				}
				this.RemoveStepCommands(value.Step);
				this.NextStep();
				return false;
			}
			else
			{
				if (value.Type == BattleCommandType.Cancel)
				{
				}
				BattleActor actorById = this.GetActorById(value.ActorId);
				if (actorById == null)
				{
					if (this.IsEnableDebugLog())
					{
						DebugUtility.LogError(string.Format("BattleBase.ExecuteBattleCommand() error, wrong actorId {0}", value.ActorId));
					}
					this.RemoveStepCommands(value.Step);
					this.NextStep();
					return false;
				}
				if (actorById.IsActionFinished())
				{
					if (this.IsEnableDebugLog())
					{
						DebugUtility.LogError(string.Format("BattleBase.ExecuteBattleCommand() error, actor {0} 's action is finished. ", actorById.InstanceID));
					}
					this.RemoveStepCommands(value.Step);
					this.NextStep();
					return false;
				}
				if (actorById.IsDeadOrRetreat())
				{
					if (this.IsEnableDebugLog())
					{
						DebugUtility.LogError(string.Format("BattleBase.ExecuteBattleCommand() error, actor {0} is dead or retreat. ", actorById.InstanceID));
					}
					this.RemoveStepCommands(value.Step);
					this.NextStep();
					return false;
				}
				if (value.Step < this.m_step)
				{
					if (this.IsEnableDebugLog())
					{
						DebugUtility.LogError(string.Format("BattleBase.ExecuteBattleCommand() error, cmd.Step {0} < Step {1}", value.Step, this.m_step));
					}
					this.RemoveStepCommands(value.Step);
					this.NextStep();
					return false;
				}
				bool flag = false;
				bool flag2 = false;
				bool flag3 = false;
				actorById.ActionBegin();
				this.m_actionActor = actorById;
				this.m_battleListener.OnBattleActorActionBegin(actorById);
				int step = this.m_step;
				while (value.Step == step)
				{
					this.m_battleCommands.RemoveFirst();
					if (this.IsEnableDebugLog())
					{
						DebugUtility.Log(string.Format("BattleBase.ExecuteBattleCommand(), step {0}, actorId {1}, {2}, skillIdx {3}, pos ({4},{5}), pos2 ({6},{7})", new object[]
						{
							value.Step,
							value.ActorId,
							value.Type,
							value.SkillIndex,
							value.TargetPosition.x,
							value.TargetPosition.y,
							value.TargetPosition2.x,
							value.TargetPosition2.y
						}));
					}
					if (value.Type == BattleCommandType.Giveup)
					{
						if (this.m_arenaBattleInfo != null || this.m_realtimePvpBattleInfo != null)
						{
							int skillIndex2 = value.SkillIndex;
							this.ExecuteGiveupCommand(skillIndex2);
							this.AddExecutedCommand(value);
							return true;
						}
						if (this.IsEnableDebugLog())
						{
							DebugUtility.LogError("BattleBase.ExecuteBattleCommand() error, can't exec giveup command.");
						}
						flag2 = true;
					}
					else if (value.Type == BattleCommandType.Cancel)
					{
					}
					if (value.ActorId == actorById.Id)
					{
						if (actorById.IsDeadOrRetreat() || flag2)
						{
							flag = true;
						}
						else if (value.Type == BattleCommandType.Move)
						{
							if (actorById.ExecuteMoveCommand(value.TargetPosition))
							{
								if (this.IsEnableDebugLog())
								{
									DebugUtility.Log(string.Format("{0} exec command: {1}", actorById.InstanceID, value.Type));
								}
								this.AddExecutedCommand(value);
							}
							else
							{
								if (this.IsEnableDebugLog())
								{
									DebugUtility.LogError(string.Format("{0} 's Move Command error. BattleMap: {1}", actorById.InstanceID, this.AliveActorsInfo));
								}
								flag2 = true;
							}
						}
						else if (value.Type == BattleCommandType.Combat)
						{
							BattleActor actor = this.m_map.GetActor(value.TargetPosition);
							if (actorById.ExecuteCombatCommand(actor, null, false))
							{
								if (this.IsEnableDebugLog())
								{
									DebugUtility.Log(string.Format("{0} exec command: {1}", actorById.InstanceID, value.Type));
								}
								this.AddExecutedCommand(value);
								flag3 = true;
								if (this.m_state != BattleState.Combat)
								{
									flag = true;
								}
							}
							else
							{
								if (this.IsEnableDebugLog())
								{
									DebugUtility.LogError(string.Format("{0} 's Combat Command error", actorById.InstanceID));
								}
								flag2 = true;
							}
						}
						else if (value.Type == BattleCommandType.Skill)
						{
							if (actorById.ExecuteSkillCommand(value.SkillIndex, value.TargetPosition, value.TargetPosition2))
							{
								if (this.IsEnableDebugLog())
								{
									DebugUtility.Log(string.Format("{0} exec command: {1}", actorById.InstanceID, value.Type));
								}
								this.AddExecutedCommand(value);
								flag3 = true;
								if (this.m_state != BattleState.Combat)
								{
									flag = true;
								}
							}
							else
							{
								if (this.IsEnableDebugLog())
								{
									DebugUtility.LogError(string.Format("{0} 's Skill Command error", actorById.InstanceID));
								}
								flag2 = true;
							}
						}
						else if (value.Type == BattleCommandType.Done)
						{
							if (!flag3)
							{
								if (actorById.ExecuteDoneCommand())
								{
									if (this.IsEnableDebugLog())
									{
										DebugUtility.Log(string.Format("{0} exec command: {1}", actorById.InstanceID, value.Type));
									}
									this.AddExecutedCommand(value);
								}
								else
								{
									if (this.IsEnableDebugLog())
									{
										DebugUtility.LogError(string.Format("{0} 's Done Command error", actorById.InstanceID));
									}
									flag2 = true;
								}
								flag = true;
							}
						}
						else
						{
							if (this.IsEnableDebugLog())
							{
								DebugUtility.LogError(string.Format("BattleBase.ExecuteBattleCommand() error, wrong command type {0}", value.Type));
							}
							flag2 = true;
						}
					}
					else
					{
						if (this.IsEnableDebugLog())
						{
							DebugUtility.LogError(string.Format("BattleBase.ExecuteBattleCommand() error, wrong actorId {0}", value.ActorId));
						}
						flag2 = true;
					}
					if (flag2)
					{
						flag = true;
					}
					if (this.m_battleCommands.Count <= 0)
					{
						break;
					}
					value = this.m_battleCommands.First.Value;
				}
				if (flag)
				{
					this.NextStep();
				}
				return !flag2;
			}
		}

		// Token: 0x06003503 RID: 13571 RVA: 0x000E66C4 File Offset: 0x000E48C4
		private void ExecuteGiveupCommand(int playerIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteGiveupCommandInt32_hotfix != null)
			{
				this.m_ExecuteGiveupCommandInt32_hotfix.call(new object[]
				{
					this,
					playerIndex
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isGiveupBattle = true;
			this.m_giveupBattlePlayerIndex = playerIndex;
			this.Stop(playerIndex != 0);
		}

		// Token: 0x06003504 RID: 13572 RVA: 0x000E6750 File Offset: 0x000E4950
		private void RemoveStepCommands(int step)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RemoveStepCommandsInt32_hotfix != null)
			{
				this.m_RemoveStepCommandsInt32_hotfix.call(new object[]
				{
					this,
					step
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_battleCommands.Count <= 0)
			{
				return;
			}
			BattleCommand value = this.m_battleCommands.First.Value;
			while (value.Step == this.m_step)
			{
				this.m_battleCommands.RemoveFirst();
				if (this.m_battleCommands.Count <= 0)
				{
					break;
				}
				value = this.m_battleCommands.First.Value;
			}
		}

		// Token: 0x06003505 RID: 13573 RVA: 0x000E6830 File Offset: 0x000E4A30
		private bool RunCurrentStepBattleCommand()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RunCurrentStepBattleCommand_hotfix != null)
			{
				return Convert.ToBoolean(this.m_RunCurrentStepBattleCommand_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleCommand value = this.m_battleCommands.First.Value;
			if (!this.ExecuteBattleCommand())
			{
				BattleActor actorById = this.GetActorById(value.ActorId);
				if (actorById != null && actorById.IsPlayerActor())
				{
					return false;
				}
			}
			return this.m_state != BattleState.Combat || this.RunCombat();
		}

		// Token: 0x06003506 RID: 13574 RVA: 0x000E68F4 File Offset: 0x000E4AF4
		private bool RunCombat()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RunCombat_hotfix != null)
			{
				return Convert.ToBoolean(this.m_RunCombat_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			while (this.m_state == BattleState.Combat)
			{
				this.Tick();
				num++;
				if (num > 1000)
				{
					if (this.IsEnableDebugLog())
					{
						DebugUtility.LogError(string.Format("BattleBase.RunCombat() error, combat infinite loop, combat state:{0}, frame:{1}, paused:{2}", this.m_combat.State, this.m_combat.GetFrameCount(), this.m_combat.IsPaused()));
						this.m_combat.GetTeam(0).LogCanNotStopCombat();
						this.m_combat.GetTeam(1).LogCanNotStopCombat();
					}
					return false;
				}
			}
			return true;
		}

		// Token: 0x06003507 RID: 13575 RVA: 0x000E69F8 File Offset: 0x000E4BF8
		public bool Run(bool strictCheckCommand = true)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RunBoolean_hotfix != null)
			{
				return Convert.ToBoolean(this.m_RunBoolean_hotfix.call(new object[]
				{
					this,
					strictCheckCommand
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsPerformOnlyBattle())
			{
				return true;
			}
			this.Start();
			this.FirstStep(true);
			int num = 0;
			while (this.IsPlay())
			{
				if (strictCheckCommand)
				{
					BattleActor actionActor = this.GetActionActor();
					if (actionActor != null)
					{
						if (actionActor.IsAIActor())
						{
							if (this.HasCurrentStepBattleCommand())
							{
								BattleCommand value = this.m_battleCommands.First.Value;
								if (value.Type != BattleCommandType.Giveup && value.Type != BattleCommandType.Cancel)
								{
									if (this.IsEnableDebugLog())
									{
										DebugUtility.LogError(string.Format("BattleBase.Run() error, AI actor has wrong command, step:{0}", this.m_step));
									}
									return false;
								}
							}
							else
							{
								actionActor.GenerateAIBattleCommand();
							}
						}
						if (!this.HasCurrentStepBattleCommand())
						{
							if (this.IsEnableDebugLog())
							{
								DebugUtility.LogError(string.Format("BattleBase.Run() error, no current step command, step:{0}", this.m_step));
							}
							return false;
						}
						if (!this.RunCurrentStepBattleCommand())
						{
							return false;
						}
					}
				}
				else if (this.HasCurrentStepBattleCommand())
				{
					if (!this.RunCurrentStepBattleCommand())
					{
						return false;
					}
				}
				else
				{
					if (this.HasWrongStepBattleCommand())
					{
						if (this.IsEnableDebugLog())
						{
							DebugUtility.LogError("BattleBase.Run() error, wrong command step");
						}
						return false;
					}
					BattleActor actionActor2 = this.GetActionActor();
					if (actionActor2 != null)
					{
						actionActor2.GenerateAIBattleCommand();
					}
				}
				num++;
				if (num > 1000)
				{
					if (this.IsEnableDebugLog())
					{
						DebugUtility.LogError("BattleBase.Run() error, infinite loop");
					}
					return false;
				}
			}
			return true;
		}

		// Token: 0x06003508 RID: 13576 RVA: 0x000E6BE8 File Offset: 0x000E4DE8
		public bool RunAIActors()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RunAIActors_hotfix != null)
			{
				return Convert.ToBoolean(this.m_RunAIActors_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			while (this.IsPlay())
			{
				if (this.HasCurrentStepBattleCommand())
				{
					if (!this.RunCurrentStepBattleCommand())
					{
						return false;
					}
				}
				else
				{
					if (this.HasWrongStepBattleCommand())
					{
						if (this.IsEnableDebugLog())
						{
							DebugUtility.LogError("BattleBase.RunAIActors() error, wrong command step");
						}
						return false;
					}
					BattleActor actionActor = this.GetActionActor();
					if (actionActor == null || !actionActor.IsAIActor())
					{
						break;
					}
					actionActor.GenerateAIBattleCommand();
				}
				num++;
				if (num > 1000)
				{
					if (this.IsEnableDebugLog())
					{
						DebugUtility.LogError("BattleBase.RunAIActors() error, infinite loop");
					}
					return false;
				}
			}
			return true;
		}

		// Token: 0x06003509 RID: 13577 RVA: 0x000E6CF4 File Offset: 0x000E4EF4
		public bool RunPlayerBattleCommands(int playerIndex, List<BattleCommand> commands)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RunPlayerBattleCommandsInt32List`1_hotfix != null)
			{
				return Convert.ToBoolean(this.m_RunPlayerBattleCommandsInt32List`1_hotfix.call(new object[]
				{
					this,
					playerIndex,
					commands
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_stepExecutedCommands.Clear();
			if (commands == null)
			{
				return false;
			}
			if (!this.IsPlay())
			{
				return false;
			}
			BattleActor battleActor = this.GetActionActor();
			if (battleActor == null)
			{
				return false;
			}
			if (battleActor.PlayerIndex != playerIndex)
			{
				if (this.IsEnableDebugLog())
				{
					DebugUtility.LogError(string.Format("BattleBase.RunPlayerBattleCommands() error, player index should {0}, but {1}", battleActor.PlayerIndex, playerIndex));
				}
				return false;
			}
			int step = this.m_step;
			foreach (BattleCommand battleCommand in commands)
			{
				if (battleCommand.Step != step)
				{
					if (this.IsEnableDebugLog())
					{
						DebugUtility.LogError(string.Format("BattleBase.RunPlayerBattleCommands() error, step should {0}, but {1}", step, battleCommand.Step));
					}
					this.FixExecutedCommands(battleActor, step);
					return false;
				}
				if (battleCommand.Type == BattleCommandType.Giveup)
				{
					return false;
				}
				BattleActor actorById = this.GetActorById(battleCommand.ActorId);
				if (actorById == null || actorById.PlayerIndex != playerIndex)
				{
					if (this.IsEnableDebugLog())
					{
						DebugUtility.LogError(string.Format("BattleBase.RunPlayerBattleCommands() error, wrong actorId {0}", battleCommand.ActorId));
					}
					this.FixExecutedCommands(battleActor, step);
					return false;
				}
				battleActor = actorById;
			}
			foreach (BattleCommand cmd in commands)
			{
				this.AddBattleCommand(cmd);
			}
			if (!this.HasCurrentStepBattleCommand())
			{
				if (this.IsEnableDebugLog())
				{
					DebugUtility.LogError("BattleBase.RunPlayerBattleCommands() error, no current step command");
				}
				this.FixExecutedCommands(battleActor, step);
				return false;
			}
			if (!this.RunCurrentStepBattleCommand())
			{
				this.FixExecutedCommands(battleActor, step);
				return false;
			}
			return true;
		}

		// Token: 0x0600350A RID: 13578 RVA: 0x000E6F74 File Offset: 0x000E5174
		private void AddExecutedCommand(BattleCommand cmd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddExecutedCommandBattleCommand_hotfix != null)
			{
				this.m_AddExecutedCommandBattleCommand_hotfix.call(new object[]
				{
					this,
					cmd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_stepExecutedCommands.Add(cmd);
			if (this.m_enableLogBattleCommands)
			{
				this.AddLogBattleCommand(cmd);
			}
		}

		// Token: 0x0600350B RID: 13579 RVA: 0x000E7004 File Offset: 0x000E5204
		public void FixExecutedCommands(BattleActor actor, int step)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FixExecutedCommandsBattleActorInt32_hotfix != null)
			{
				this.m_FixExecutedCommandsBattleActorInt32_hotfix.call(new object[]
				{
					this,
					actor,
					step
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (actor == null)
			{
				return;
			}
			bool flag = false;
			if (this.m_stepExecutedCommands.Count > 0)
			{
				BattleCommand battleCommand = this.m_stepExecutedCommands[this.m_stepExecutedCommands.Count - 1];
				if (battleCommand.Type == BattleCommandType.Move)
				{
					flag = true;
				}
			}
			else
			{
				flag = true;
			}
			if (flag)
			{
				this.AddExecutedCommand(new BattleCommand
				{
					Type = BattleCommandType.Done,
					Step = step,
					ActorId = actor.Id
				});
			}
			if (this.m_step == step)
			{
				this.NextStep();
			}
		}

		// Token: 0x0600350C RID: 13580 RVA: 0x000E710C File Offset: 0x000E530C
		public List<BattleCommand> GetStepExecutedCommands()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetStepExecutedCommands_hotfix != null)
			{
				return (List<BattleCommand>)this.m_GetStepExecutedCommands_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_stepExecutedCommands;
		}

		// Token: 0x0600350D RID: 13581 RVA: 0x000E7180 File Offset: 0x000E5380
		public void EnableLogBattleCommands(bool enable)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EnableLogBattleCommandsBoolean_hotfix != null)
			{
				this.m_EnableLogBattleCommandsBoolean_hotfix.call(new object[]
				{
					this,
					enable
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_enableLogBattleCommands = enable;
		}

		// Token: 0x0600350E RID: 13582 RVA: 0x000E71F8 File Offset: 0x000E53F8
		public bool IsEnableLogBattleCommands()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsEnableLogBattleCommands_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsEnableLogBattleCommands_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_enableLogBattleCommands;
		}

		// Token: 0x0600350F RID: 13583 RVA: 0x000E726C File Offset: 0x000E546C
		public LinkedList<BattleCommand> GetLogBattleCommands()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetLogBattleCommands_hotfix != null)
			{
				return (LinkedList<BattleCommand>)this.m_GetLogBattleCommands_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_logBattleCommands;
		}

		// Token: 0x06003510 RID: 13584 RVA: 0x000E72E0 File Offset: 0x000E54E0
		public void EnableTempBattleCommands(bool enable)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EnableTempBattleCommandsBoolean_hotfix != null)
			{
				this.m_EnableTempBattleCommandsBoolean_hotfix.call(new object[]
				{
					this,
					enable
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_enableTempBattleCommands = enable;
		}

		// Token: 0x06003511 RID: 13585 RVA: 0x000E7358 File Offset: 0x000E5558
		public bool IsEnableTempBattleCommands()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsEnableTempBattleCommands_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsEnableTempBattleCommands_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_enableTempBattleCommands;
		}

		// Token: 0x06003512 RID: 13586 RVA: 0x000E73CC File Offset: 0x000E55CC
		public LinkedList<BattleCommand> GetTempBattleCommands()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTempBattleCommands_hotfix != null)
			{
				return (LinkedList<BattleCommand>)this.m_GetTempBattleCommands_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_tempBattleCommands;
		}

		// Token: 0x06003513 RID: 13587 RVA: 0x000E7440 File Offset: 0x000E5640
		public void ClearTempBattleCommands()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearTempBattleCommands_hotfix != null)
			{
				this.m_ClearTempBattleCommands_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_tempBattleCommands.Clear();
		}

		// Token: 0x06003514 RID: 13588 RVA: 0x000E74AC File Offset: 0x000E56AC
		public void StartCombat(BattleActor actorA, BattleActor actorB, ConfigDataSkillInfo skillInfoA)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartCombatBattleActorBattleActorConfigDataSkillInfo_hotfix != null)
			{
				this.m_StartCombatBattleActorBattleActorConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					actorA,
					actorB,
					skillInfoA
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (actorA == null || actorB == null)
			{
				return;
			}
			int num = GridPosition.Distance(actorA.Position, actorB.Position);
			BattleActor battleActor = null;
			if (!actorA.HasFightTag(FightTag.FightTag_IngoreGuard))
			{
				ConfigDataSkillInfo configDataSkillInfo = skillInfoA;
				if (configDataSkillInfo == null)
				{
					configDataSkillInfo = actorA.GetHeroAttackSkillInfo(actorB.GetMoveType(), num);
				}
				battleActor = actorB.GetGuardActor(configDataSkillInfo);
			}
			if (battleActor != null)
			{
				this.m_beGuardedCombatActor = actorB;
				battleActor.GuardMove(actorB.Position);
				this.m_battleListener.OnStartGuard(battleActor, actorB);
				battleActor.FaceTo(actorA.Position);
				actorB = battleActor;
			}
			else
			{
				this.m_beGuardedCombatActor = null;
			}
			this.m_battleListener.OnBeforeStartCombat(actorA, actorB, skillInfoA);
			List<BattleActor> list = this.AllocateTempActorList();
			list.Add(actorA);
			List<BattleActor> list2 = this.AllocateTempActorList();
			list2.Add(actorB);
			actorA.CombatApplyBuff(actorB, true, true, num, false);
			actorA.CombatBuffHeal(actorB, true, true, num, false, 0, 0);
			actorA.CombatBuffHealOther(actorB, true, true, num, false, 0, 0);
			actorA.CombatBuffDamage(actorB, true, true, num, false);
			actorA.AttackRemoveBuff(list2, true, true, num);
			actorB.CombatApplyBuff(actorA, true, false, num, false);
			actorB.CombatBuffHeal(actorA, true, false, num, false, 0, 0);
			actorB.CombatBuffHealOther(actorA, true, false, num, false, 0, 0);
			actorB.CombatBuffDamage(actorA, true, false, num, false);
			actorB.AttackRemoveBuff(list, true, false, num);
			this.FreeTempActorList(list2);
			this.FreeTempActorList(list);
			if (actorA.IsDead() || actorB.IsDead())
			{
				actorA.CheckDie(actorB);
				actorB.CheckDie(actorA);
				if (actorA.IsDead() || actorB.IsDead())
				{
					if (actorB.IsDead())
					{
						actorA.SetActionKillActor();
					}
					if (actorA.IsDead())
					{
						actorB.SetActionKillActor();
					}
					this.m_battleListener.OnCancelCombat();
					if (battleActor != null && !battleActor.IsDeadOrRetreat())
					{
						battleActor.UnguardMove();
						this.m_battleListener.OnStopGuard(battleActor, this.m_beGuardedCombatActor);
					}
					actorA.AfterCombatDetachBuff();
					actorB.AfterCombatDetachBuff();
					actorB.CombatBy(actorA);
					this.CheckCombatActorsDie(actorA, actorB);
					this.m_beGuardedCombatActor = null;
					return;
				}
			}
			this.m_combatActorA = actorA;
			this.m_combatActorB = actorB;
			this.m_combatSkillInfoA = skillInfoA;
			this.CheckEventTriggerOnActorCombatAttackBefore(actorA, this.m_beGuardedCombatActor ?? actorB);
			actorA.UpdateBattlePropertiesInCombat(actorB, true, num);
			actorB.UpdateBattlePropertiesInCombat(actorA, false, num);
			this.m_state = BattleState.Combat;
			this.m_combatRandomSeed = this.m_randomNumber.Next(0, 100000);
			if (actorA.TeamNumber == 0)
			{
				this.m_combat.Start(actorA, actorB, skillInfoA, null, this.m_combatRandomSeed);
			}
			else
			{
				this.m_combat.Start(actorB, actorA, null, skillInfoA, this.m_combatRandomSeed);
			}
			this.m_battleListener.OnStartCombat(actorA, actorB, skillInfoA);
		}

		// Token: 0x06003515 RID: 13589 RVA: 0x000E77D0 File Offset: 0x000E59D0
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
			this.m_state = BattleState.Play;
			BattleActor combatActorA = this.m_combatActorA;
			BattleActor combatActorB = this.m_combatActorB;
			BattleActor beGuardedCombatActor = this.m_beGuardedCombatActor;
			ConfigDataSkillInfo combatSkillInfoA = this.m_combatSkillInfoA;
			bool isPerformCombat = this.m_isPerformCombat;
			ConfigDataBattlePerformInfo afterComatPerform = this.m_afterComatPerform;
			BattleEventTriggerState afterCombatExecuteTriggerState = this.m_afterCombatExecuteTriggerState;
			int afterCombatExecuteTriggerEventActionIndex = this.m_afterCombatExecuteTriggerEventActionIndex;
			List<BattleActor> list = this.AllocateTempActorList();
			list.Add(combatActorA);
			List<BattleActor> list2 = this.AllocateTempActorList();
			list2.Add(combatActorB);
			CombatTeam team = this.m_combat.GetTeam(combatActorA.TeamNumber);
			CombatTeam team2 = this.m_combat.GetTeam(1 - combatActorA.TeamNumber);
			this.CopyCombatProperty(team, combatActorA);
			this.CopyCombatProperty(team2, combatActorB);
			combatActorA.UpdateBattleProperties();
			combatActorB.UpdateBattleProperties();
			bool isBeCriticalAttack = team2.IsBeCriticalAttack;
			bool isBeCriticalAttack2 = team.IsBeCriticalAttack;
			combatActorA.SetBeCriticalAttack(isBeCriticalAttack2);
			combatActorB.SetBeCriticalAttack(isBeCriticalAttack);
			if (isBeCriticalAttack)
			{
				combatActorA.SetActionCriticalAttack();
			}
			if (isBeCriticalAttack2)
			{
				combatActorB.SetActionCriticalAttack();
			}
			this.m_battleListener.OnStopCombat(team.HeroReceiveTotalDamage, team.SoldierReceiveTotalDamage, isBeCriticalAttack, team2.HeroReceiveTotalDamage, team2.SoldierReceiveTotalDamage, isBeCriticalAttack2);
			int num = GridPosition.Distance(combatActorA.Position, combatActorB.Position);
			combatActorA.CheckDie(combatActorB);
			combatActorB.CheckDie(combatActorA);
			combatActorA.SetBeKillAttack(combatActorA.IsDead());
			combatActorB.SetBeKillAttack(combatActorB.IsDead());
			if (beGuardedCombatActor != null && !combatActorB.IsDeadOrRetreat())
			{
				combatActorB.UnguardMove();
				this.m_battleListener.OnStopGuard(combatActorB, beGuardedCombatActor);
			}
			if (combatSkillInfoA != null)
			{
				combatActorB.SkillDispelBuff(combatSkillInfoA);
			}
			if (!combatActorA.IsDeadOrRetreat() && !combatActorB.IsDeadOrRetreat())
			{
				if (team.IsCastAnyDamageSkill && beGuardedCombatActor == null)
				{
					combatActorA.AttackBuffPunch(combatActorB);
					combatActorA.AttackBuffDrag(combatActorB);
				}
				combatActorA.AttackBuffExchangePosition(combatActorB, beGuardedCombatActor != null);
			}
			if (!combatActorA.IsDeadOrRetreat())
			{
				ConfigDataSkillInfo attachBuffSourceSkillInfo = team.GetAttachBuffSourceSkillInfo();
				if (attachBuffSourceSkillInfo != null && this.IsProbabilitySatisfied(attachBuffSourceSkillInfo.BuffRate))
				{
					List<ConfigDataBuffInfo> list3 = this.AllocateTempBuffList();
					this.GetRandomBuffList(attachBuffSourceSkillInfo.Buffs_ID, attachBuffSourceSkillInfo.BuffNum, list3);
					foreach (ConfigDataBuffInfo buffInfo in list3)
					{
						combatActorA.AttachBuff(buffInfo, combatActorB, BuffSourceType.SkillApply, attachBuffSourceSkillInfo, null);
					}
					this.FreeTempBuffList(list3);
				}
				if (team.IsCastAnyDamageSkill)
				{
					combatActorA.AttackApplyBuff(list2);
					combatActorA.AttackRemoveBuff(list2, false, true, num);
				}
			}
			if (!combatActorB.IsDeadOrRetreat())
			{
				ConfigDataSkillInfo attachBuffSourceSkillInfo2 = team2.GetAttachBuffSourceSkillInfo();
				if (attachBuffSourceSkillInfo2 != null && this.IsProbabilitySatisfied(attachBuffSourceSkillInfo2.BuffRate))
				{
					List<ConfigDataBuffInfo> list4 = this.AllocateTempBuffList();
					this.GetRandomBuffList(attachBuffSourceSkillInfo2.Buffs_ID, attachBuffSourceSkillInfo2.BuffNum, list4);
					foreach (ConfigDataBuffInfo buffInfo2 in list4)
					{
						combatActorB.AttachBuff(buffInfo2, combatActorA, BuffSourceType.SkillApply, attachBuffSourceSkillInfo2, null);
					}
					this.FreeTempBuffList(list4);
				}
				if (team2.IsCastAnyDamageSkill)
				{
					combatActorB.AttackApplyBuff(list);
					combatActorB.AttackRemoveBuff(list, false, false, num);
				}
			}
			if (!combatActorA.IsDeadOrRetreat())
			{
				combatActorA.CombatBuffHeal(combatActorB, false, true, num, isBeCriticalAttack, team.HeroApplyTotalDamage, team.SoldierApplyTotalDamage);
				combatActorA.CombatBuffHealOther(combatActorB, false, true, num, isBeCriticalAttack, team.HeroApplyTotalDamage, team.SoldierApplyTotalDamage);
				combatActorA.CombatApplyBuff(combatActorB, false, true, num, isBeCriticalAttack);
				combatActorA.CombatBuffDamage(combatActorB, false, true, num, isBeCriticalAttack);
				if (team.IsCastAnyDamageSkill)
				{
					combatActorA.AttackBuffDamage(list2, false, true, num);
				}
			}
			if (!combatActorB.IsDeadOrRetreat())
			{
				combatActorB.CombatBuffHeal(combatActorA, false, false, num, isBeCriticalAttack2, team2.HeroApplyTotalDamage, team2.SoldierApplyTotalDamage);
				combatActorB.CombatBuffHealOther(combatActorA, false, false, num, isBeCriticalAttack2, team2.HeroApplyTotalDamage, team2.SoldierApplyTotalDamage);
				combatActorB.CombatApplyBuff(combatActorA, false, false, num, isBeCriticalAttack2);
				combatActorB.CombatBuffDamage(combatActorA, false, false, num, isBeCriticalAttack2);
				if (team2.IsCastAnyDamageSkill)
				{
					combatActorB.AttackBuffDamage(list, false, false, num);
				}
			}
			if (!combatActorA.IsDeadOrRetreat())
			{
				combatActorA.CombatArmyChange(combatActorB);
			}
			if (team.IsCastAnyDamageSkill && !combatActorA.IsDeadOrRetreat())
			{
				combatActorA.AttackRemoveSkillCooldown(this.m_combatSkillInfoA, isBeCriticalAttack, combatActorB.IsDead());
			}
			if (team2.IsCastAnyDamageSkill && !combatActorB.IsDeadOrRetreat())
			{
				combatActorB.AttackRemoveSkillCooldown(null, isBeCriticalAttack2, combatActorA.IsDead());
			}
			this.FreeTempActorList(list2);
			this.FreeTempActorList(list);
			combatActorA.AfterCombatDetachBuff();
			combatActorB.AfterCombatDetachBuff();
			combatActorA.CheckDie(combatActorB);
			combatActorB.CheckDie(combatActorA);
			combatActorB.CombatBy(combatActorA);
			if (team.GetLastDamageBySkill() != null)
			{
				combatActorA.SetLastDamageBySkill(team.GetLastDamageBySkill());
				if (combatActorA.GetFirstDamageTurn() == 0)
				{
					combatActorA.SetFirstDamageTurn(this.m_turn);
				}
				combatActorB.SetActionDamageActor();
			}
			if (team2.GetLastDamageBySkill() != null)
			{
				combatActorB.SetLastDamageBySkill(team2.GetLastDamageBySkill());
				if (combatActorB.GetFirstDamageTurn() == 0)
				{
					combatActorB.SetFirstDamageTurn(this.m_turn);
				}
				combatActorA.SetActionDamageActor();
			}
			if (combatActorB.IsDead())
			{
				combatActorA.SetActionKillActor();
			}
			if (combatActorA.IsDead())
			{
				combatActorB.SetActionKillActor();
			}
			this.m_combat.Clear();
			this.m_combatActorA = (this.m_combatActorB = null);
			this.m_combatSkillInfoA = null;
			this.m_beGuardedCombatActor = null;
			this.m_isPerformCombat = false;
			this.m_afterComatPerform = null;
			this.m_afterCombatExecuteTriggerState = null;
			this.m_afterCombatExecuteTriggerEventActionIndex = -1;
			this.CheckEventTriggerOnActorCombatAttackAfter(combatActorA, beGuardedCombatActor ?? combatActorB);
			this.CheckEventTriggerOnActorBeCombatAttack(combatActorB);
			combatActorA.IncreaseCombatAttackCount();
			combatActorB.IncreaseBeCombatAttackCount();
			this.CheckCombatActorsDie(combatActorA, combatActorB);
			if (isPerformCombat)
			{
				if (afterComatPerform != null)
				{
					this.ExecuteBattlePerforms(afterComatPerform);
				}
				if (afterCombatExecuteTriggerState != null && this.m_state != BattleState.Combat)
				{
					this.ExecuteTriggerEventActions(afterCombatExecuteTriggerState, afterCombatExecuteTriggerEventActionIndex);
				}
				if (this.m_state != BattleState.Combat)
				{
					this.ExecuteAfterCombatSteps();
				}
			}
			else if (this.m_afterComatPerform != null)
			{
				this.m_isAfterCombatNextStep = true;
			}
			else
			{
				this.NextStep();
			}
		}

		// Token: 0x06003516 RID: 13590 RVA: 0x000E7E5C File Offset: 0x000E605C
		private void CheckCombatActorsDie(BattleActor actorA, BattleActor actorB)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckCombatActorsDieBattleActorBattleActor_hotfix != null)
			{
				this.m_CheckCombatActorsDieBattleActorBattleActor_hotfix.call(new object[]
				{
					this,
					actorA,
					actorB
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (actorA.TeamNumber == 0)
			{
				if (actorA.IsDead())
				{
					this.CheckOnActorDie(actorA);
					actorB.IncreaseKillActorCount();
				}
				if (actorB.IsDead())
				{
					this.CheckOnActorDie(actorB);
					actorA.IncreaseKillActorCount();
				}
			}
			else
			{
				if (actorB.IsDead())
				{
					this.CheckOnActorDie(actorB);
					actorA.IncreaseKillActorCount();
				}
				if (actorA.IsDead())
				{
					this.CheckOnActorDie(actorA);
					actorB.IncreaseKillActorCount();
				}
			}
		}

		// Token: 0x06003517 RID: 13591 RVA: 0x000E7F4C File Offset: 0x000E614C
		public void RestartCombat()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RestartCombat_hotfix != null)
			{
				this.m_RestartCombat_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_state != BattleState.Combat)
			{
				return;
			}
			if (this.m_combatActorA.TeamNumber == 0)
			{
				this.m_combat.Start(this.m_combatActorA, this.m_combatActorB, this.m_combatSkillInfoA, null, this.m_combatRandomSeed);
			}
			else
			{
				this.m_combat.Start(this.m_combatActorB, this.m_combatActorA, null, this.m_combatSkillInfoA, this.m_combatRandomSeed);
			}
		}

		// Token: 0x06003518 RID: 13592 RVA: 0x000E8018 File Offset: 0x000E6218
		private void CopyCombatProperty(CombatTeam combatTeam, BattleActor actor)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CopyCombatPropertyCombatTeamBattleActor_hotfix != null)
			{
				this.m_CopyCombatPropertyCombatTeamBattleActor_hotfix.call(new object[]
				{
					this,
					combatTeam,
					actor
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			actor.SetSoldierTotalHealthPoint(combatTeam.ComputeSoldierTotalHealthPoint());
			CombatActor hero = combatTeam.GetHero();
			if (hero != null)
			{
				actor.SetHeroHealthPoint(hero.HealthPoint);
			}
			else
			{
				actor.SetHeroHealthPoint(0);
			}
		}

		// Token: 0x06003519 RID: 13593 RVA: 0x000E80CC File Offset: 0x000E62CC
		private void CheckWinConditionOnActorMove(BattleActor actor)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckWinConditionOnActorMoveBattleActor_hotfix != null)
			{
				this.m_CheckWinConditionOnActorMoveBattleActor_hotfix.call(new object[]
				{
					this,
					actor
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsPlay())
			{
				return;
			}
			foreach (BattleWinConditionState battleWinConditionState in this.m_winConditionStates)
			{
				if (battleWinConditionState.m_status == BattleConditionStatus.Progress)
				{
					if (battleWinConditionState.m_winConditionInfo.WinConditionType == BattleWinConditionType.BattleWinConditionType_ActorReachPosition)
					{
						if (battleWinConditionState.m_winConditionInfo.Param1.Count > 0)
						{
							if (battleWinConditionState.m_winConditionInfo.Param1.Contains(actor.HeroId) && this.IsActorReachPositions(actor, battleWinConditionState.m_winConditionInfo.Param3, battleWinConditionState.m_conditionId))
							{
								this.ChangeWinConditionStatus(battleWinConditionState);
								break;
							}
						}
						else
						{
							int num = 0;
							NpcCondition npcCondition = NpcCondition.DontCare;
							if (battleWinConditionState.m_winConditionInfo.Param2FirstValue() == 2)
							{
								npcCondition = NpcCondition.NotNpc;
							}
							else if (battleWinConditionState.m_winConditionInfo.Param2FirstValue() == 3)
							{
								npcCondition = NpcCondition.IsNpc;
							}
							else if (battleWinConditionState.m_winConditionInfo.Param2FirstValue() == 4)
							{
								num = 1;
							}
							if (actor.TeamNumber == num && this.IsActorReachPositions(actor, npcCondition, battleWinConditionState.m_winConditionInfo.Param3, battleWinConditionState.m_conditionId))
							{
								if (battleWinConditionState.m_winConditionInfo.Param2.Count <= 1)
								{
									this.ChangeWinConditionStatus(battleWinConditionState);
									break;
								}
								if (this.GetActorsCountSatisfyCondition(num, npcCondition, battleWinConditionState.m_conditionId) >= battleWinConditionState.m_winConditionInfo.Param2[1])
								{
									this.ChangeWinConditionStatus(battleWinConditionState);
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600351A RID: 13594 RVA: 0x000E82E8 File Offset: 0x000E64E8
		private void CheckLoseConditionOnActorMove(BattleActor actor)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckLoseConditionOnActorMoveBattleActor_hotfix != null)
			{
				this.m_CheckLoseConditionOnActorMoveBattleActor_hotfix.call(new object[]
				{
					this,
					actor
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsPlay())
			{
				return;
			}
			foreach (BattleLoseConditionState battleLoseConditionState in this.m_loseConditionStates)
			{
				if (battleLoseConditionState.m_status == BattleConditionStatus.Progress)
				{
					if (battleLoseConditionState.m_loseConditionInfo.LoseConditionType == BattleLoseConditionType.BattleLoseConditionType_ActorReachPosition)
					{
						if (battleLoseConditionState.m_loseConditionInfo.Param1.Count > 0)
						{
							if (battleLoseConditionState.m_loseConditionInfo.Param1.Contains(actor.HeroId) && this.IsActorReachPositions(actor, battleLoseConditionState.m_loseConditionInfo.Param3, battleLoseConditionState.m_conditionId))
							{
								this.ChangeLoseConditionStatus(battleLoseConditionState);
								break;
							}
						}
						else
						{
							int num = 1;
							if (actor.TeamNumber == num && this.IsActorReachPositions(actor, battleLoseConditionState.m_loseConditionInfo.Param3, battleLoseConditionState.m_conditionId))
							{
								if (battleLoseConditionState.m_loseConditionInfo.Param2.Count <= 1)
								{
									this.ChangeLoseConditionStatus(battleLoseConditionState);
									break;
								}
								if (this.GetActorsCountSatisfyCondition(num, NpcCondition.DontCare, battleLoseConditionState.m_conditionId) >= battleLoseConditionState.m_loseConditionInfo.Param2[1])
								{
									this.ChangeLoseConditionStatus(battleLoseConditionState);
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600351B RID: 13595 RVA: 0x000E84BC File Offset: 0x000E66BC
		private void CheckWinConditionOnActorDie(BattleActor actor)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckWinConditionOnActorDieBattleActor_hotfix != null)
			{
				this.m_CheckWinConditionOnActorDieBattleActor_hotfix.call(new object[]
				{
					this,
					actor
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsPlay())
			{
				return;
			}
			foreach (BattleWinConditionState battleWinConditionState in this.m_winConditionStates)
			{
				if (battleWinConditionState.m_status == BattleConditionStatus.Progress)
				{
					if (battleWinConditionState.m_winConditionInfo.WinConditionType == BattleWinConditionType.BattleWinConditionType_KillAll)
					{
						if (actor.TeamNumber == 1 && !this.m_teams[1].HasAliveActor())
						{
							this.ChangeWinConditionStatus(battleWinConditionState);
							break;
						}
					}
					else if (battleWinConditionState.m_winConditionInfo.WinConditionType == BattleWinConditionType.BattleWinConditionType_KillActor)
					{
						if (battleWinConditionState.m_winConditionInfo.Param1.Contains(actor.HeroId))
						{
							this.ChangeWinConditionStatus(battleWinConditionState);
							break;
						}
					}
					else if (battleWinConditionState.m_winConditionInfo.WinConditionType == BattleWinConditionType.BattleWinConditionType_KillCount)
					{
						int num = battleWinConditionState.m_winConditionInfo.Param2FirstValue();
						if (actor.TeamNumber == 1 && num > 0)
						{
							if (battleWinConditionState.m_winConditionInfo.Param1.Count > 0)
							{
								if (this.m_teams[1].ComputeDeadActorCount(battleWinConditionState.m_winConditionInfo.Param1, NpcCondition.DontCare) >= num)
								{
									this.ChangeWinConditionStatus(battleWinConditionState);
									break;
								}
							}
							else if (this.m_teams[1].DeadActorCount >= num)
							{
								this.ChangeWinConditionStatus(battleWinConditionState);
								break;
							}
						}
					}
					else if (battleWinConditionState.m_winConditionInfo.WinConditionType == BattleWinConditionType.BattleWinConditionType_KillOthers && actor.TeamNumber == 1)
					{
						bool flag = false;
						foreach (BattleActor battleActor in this.m_teams[1].GetActors())
						{
							if (!battleActor.IsDeadOrRetreat() && !battleWinConditionState.m_winConditionInfo.Param1.Contains(battleActor.HeroId))
							{
								flag = true;
								break;
							}
						}
						if (!flag)
						{
							this.ChangeWinConditionStatus(battleWinConditionState);
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600351C RID: 13596 RVA: 0x000E8770 File Offset: 0x000E6970
		private void CheckLoseConditionOnActorDie(BattleActor actor)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckLoseConditionOnActorDieBattleActor_hotfix != null)
			{
				this.m_CheckLoseConditionOnActorDieBattleActor_hotfix.call(new object[]
				{
					this,
					actor
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsPlay())
			{
				return;
			}
			foreach (BattleLoseConditionState battleLoseConditionState in this.m_loseConditionStates)
			{
				if (battleLoseConditionState.m_status == BattleConditionStatus.Progress)
				{
					if (battleLoseConditionState.m_loseConditionInfo.LoseConditionType == BattleLoseConditionType.BattleLoseConditionType_DieAll)
					{
						if (actor.TeamNumber == 0)
						{
							bool flag = false;
							int num = 0;
							foreach (BattleActor battleActor in this.m_teams[0].GetActors())
							{
								if (!battleActor.IsAINpc())
								{
									if (!battleActor.IsDeadOrRetreat())
									{
										flag = true;
										break;
									}
									num++;
								}
							}
							if (num > 0 && !flag)
							{
								this.ChangeLoseConditionStatus(battleLoseConditionState);
								break;
							}
						}
					}
					else if (battleLoseConditionState.m_loseConditionInfo.LoseConditionType == BattleLoseConditionType.BattleLoseConditionType_ActorDie)
					{
						if (battleLoseConditionState.m_loseConditionInfo.Param1.Contains(actor.HeroId))
						{
							this.ChangeLoseConditionStatus(battleLoseConditionState);
							break;
						}
					}
					else if (battleLoseConditionState.m_loseConditionInfo.LoseConditionType == BattleLoseConditionType.BattleLoseConditionType_DieCount)
					{
						if (actor.TeamNumber == 0)
						{
							int num2 = battleLoseConditionState.m_loseConditionInfo.Param2FirstValue();
							if (num2 > 0 && this.m_teams[0].DeadActorCount >= num2)
							{
								this.ChangeLoseConditionStatus(battleLoseConditionState);
								break;
							}
						}
					}
					else if (battleLoseConditionState.m_loseConditionInfo.LoseConditionType == BattleLoseConditionType.BattleLoseConditionType_PlayerDieCount)
					{
						if (actor.TeamNumber == 0)
						{
							int num3 = battleLoseConditionState.m_loseConditionInfo.Param2FirstValue();
							if (num3 > 0 && this.m_teams[0].ComputeDeadActorCount(null, NpcCondition.NotNpc) >= num3)
							{
								this.ChangeLoseConditionStatus(battleLoseConditionState);
								break;
							}
						}
					}
					else if (battleLoseConditionState.m_loseConditionInfo.LoseConditionType == BattleLoseConditionType.BattleLoseConditionType_NpcDieCount && actor.TeamNumber == 0)
					{
						int num4 = battleLoseConditionState.m_loseConditionInfo.Param2FirstValue();
						if (num4 > 0 && this.m_teams[0].ComputeDeadActorCount(battleLoseConditionState.m_loseConditionInfo.Param1, NpcCondition.IsNpc) >= num4)
						{
							this.ChangeLoseConditionStatus(battleLoseConditionState);
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600351D RID: 13597 RVA: 0x000E8A58 File Offset: 0x000E6C58
		private void CheckWinConditionOnActorRetreat(BattleActor actor)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckWinConditionOnActorRetreatBattleActor_hotfix != null)
			{
				this.m_CheckWinConditionOnActorRetreatBattleActor_hotfix.call(new object[]
				{
					this,
					actor
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsPlay())
			{
				return;
			}
			foreach (BattleWinConditionState battleWinConditionState in this.m_winConditionStates)
			{
				if (battleWinConditionState.m_status == BattleConditionStatus.Progress)
				{
					if (battleWinConditionState.m_winConditionInfo.WinConditionType == BattleWinConditionType.BattleWinConditionType_KillAll && actor.TeamNumber == 1 && !this.m_teams[1].HasAliveActor())
					{
						this.ChangeWinConditionStatus(battleWinConditionState);
						break;
					}
				}
			}
		}

		// Token: 0x0600351E RID: 13598 RVA: 0x000E8B68 File Offset: 0x000E6D68
		private void CheckLoseConditionOnActorRetreat(BattleActor actor)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckLoseConditionOnActorRetreatBattleActor_hotfix != null)
			{
				this.m_CheckLoseConditionOnActorRetreatBattleActor_hotfix.call(new object[]
				{
					this,
					actor
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsPlay())
			{
				return;
			}
		}

		// Token: 0x0600351F RID: 13599 RVA: 0x000E8BE4 File Offset: 0x000E6DE4
		private void CheckWinConditionOnEventTrigger(BattleEventTriggerState eventState)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckWinConditionOnEventTriggerBattleEventTriggerState_hotfix != null)
			{
				this.m_CheckWinConditionOnEventTriggerBattleEventTriggerState_hotfix.call(new object[]
				{
					this,
					eventState
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsPlay())
			{
				return;
			}
			foreach (BattleWinConditionState battleWinConditionState in this.m_winConditionStates)
			{
				if (battleWinConditionState.m_status == BattleConditionStatus.Progress)
				{
					if (battleWinConditionState.m_winConditionInfo.WinConditionType == BattleWinConditionType.BattleWinConditionType_EventTrigger && battleWinConditionState.m_winConditionInfo.Param1.Contains(eventState.m_triggerInfo.ID))
					{
						this.ChangeWinConditionStatus(battleWinConditionState);
						break;
					}
				}
			}
		}

		// Token: 0x06003520 RID: 13600 RVA: 0x000E8CF8 File Offset: 0x000E6EF8
		private void CheckLoseConditionOnEventTrigger(BattleEventTriggerState eventState)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckLoseConditionOnEventTriggerBattleEventTriggerState_hotfix != null)
			{
				this.m_CheckLoseConditionOnEventTriggerBattleEventTriggerState_hotfix.call(new object[]
				{
					this,
					eventState
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsPlay())
			{
				return;
			}
			foreach (BattleLoseConditionState battleLoseConditionState in this.m_loseConditionStates)
			{
				if (battleLoseConditionState.m_status == BattleConditionStatus.Progress)
				{
					if (battleLoseConditionState.m_loseConditionInfo.LoseConditionType == BattleLoseConditionType.BattleLoseConditionType_EventTrigger && battleLoseConditionState.m_loseConditionInfo.Param1.Contains(eventState.m_triggerInfo.ID))
					{
						this.ChangeLoseConditionStatus(battleLoseConditionState);
						break;
					}
				}
			}
		}

		// Token: 0x06003521 RID: 13601 RVA: 0x000E8E0C File Offset: 0x000E700C
		private void CheckWinConditionOnNextStep()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckWinConditionOnNextStep_hotfix != null)
			{
				this.m_CheckWinConditionOnNextStep_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsPlay())
			{
				return;
			}
			foreach (BattleWinConditionState battleWinConditionState in this.m_winConditionStates)
			{
				if (battleWinConditionState.m_status == BattleConditionStatus.Progress)
				{
					if (battleWinConditionState.m_winConditionInfo.WinConditionType == BattleWinConditionType.BattleWinConditionType_ActorHpLess)
					{
						int num = battleWinConditionState.m_winConditionInfo.Param2FirstValue();
						foreach (int heroId in battleWinConditionState.m_winConditionInfo.Param1)
						{
							BattleActor actorByHeroId = this.m_teams[1].GetActorByHeroId(heroId, false);
							if (actorByHeroId != null && actorByHeroId.GetTotalHealthPoint() * 10000 / actorByHeroId.GetTotalHealthPointMax() <= num)
							{
								this.ChangeWinConditionStatus(battleWinConditionState);
								return;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003522 RID: 13602 RVA: 0x000E8F78 File Offset: 0x000E7178
		private void CheckWinConditionOnTurnBegin()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckWinConditionOnTurnBegin_hotfix != null)
			{
				this.m_CheckWinConditionOnTurnBegin_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsPlay())
			{
				return;
			}
			foreach (BattleWinConditionState battleWinConditionState in this.m_winConditionStates)
			{
				if (battleWinConditionState.m_status == BattleConditionStatus.Progress)
				{
					if (battleWinConditionState.m_winConditionInfo.WinConditionType == BattleWinConditionType.BattleWinConditionType_Turn && this.m_turn > battleWinConditionState.m_winConditionInfo.Param2FirstValue())
					{
						this.ChangeWinConditionStatus(battleWinConditionState);
						break;
					}
				}
			}
		}

		// Token: 0x06003523 RID: 13603 RVA: 0x000E9070 File Offset: 0x000E7270
		private void CheckWinLoseConditionOnTurnMax()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckWinLoseConditionOnTurnMax_hotfix != null)
			{
				this.m_CheckWinLoseConditionOnTurnMax_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsPlay())
			{
				return;
			}
			foreach (BattleWinConditionState battleWinConditionState in this.m_winConditionStates)
			{
				if (battleWinConditionState.m_status == BattleConditionStatus.Progress)
				{
					if (battleWinConditionState.m_winConditionInfo.WinConditionType == BattleWinConditionType.BattleWinConditionType_ActorNotDead && this.IsActorsAllAlive(battleWinConditionState.m_winConditionInfo.Param1))
					{
						this.ChangeWinConditionStatus(battleWinConditionState);
						return;
					}
				}
			}
			if (this.m_battleType == BattleType.TreasureMap)
			{
				this.Stop(true);
			}
			else
			{
				this.Stop(false);
			}
		}

		// Token: 0x06003524 RID: 13604 RVA: 0x000E9188 File Offset: 0x000E7388
		private void ChangeWinConditionStatus(BattleWinConditionState state)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ChangeWinConditionStatusBattleWinConditionState_hotfix != null)
			{
				this.m_ChangeWinConditionStatusBattleWinConditionState_hotfix.call(new object[]
				{
					this,
					state
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsEnableDebugLog())
			{
				DebugUtility.Log(string.Format("BattleBase.ChangeWinConditionStatus(), winConditionId {0}", state.m_winConditionInfo.ID));
			}
			state.m_status = BattleConditionStatus.Success;
			this.Stop(true);
		}

		// Token: 0x06003525 RID: 13605 RVA: 0x000E9230 File Offset: 0x000E7430
		private void ChangeLoseConditionStatus(BattleLoseConditionState state)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ChangeLoseConditionStatusBattleLoseConditionState_hotfix != null)
			{
				this.m_ChangeLoseConditionStatusBattleLoseConditionState_hotfix.call(new object[]
				{
					this,
					state
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsEnableDebugLog())
			{
				DebugUtility.Log(string.Format("BattleBase.ChangeLoseConditionStatus(), loseConditionId {0}", state.m_loseConditionInfo.ID));
			}
			state.m_status = BattleConditionStatus.Success;
			this.Stop(false);
		}

		// Token: 0x06003526 RID: 13606 RVA: 0x000E92D8 File Offset: 0x000E74D8
		private void CheckEventTriggerOnActorMove(BattleActor actor)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckEventTriggerOnActorMoveBattleActor_hotfix != null)
			{
				this.m_CheckEventTriggerOnActorMoveBattleActor_hotfix.call(new object[]
				{
					this,
					actor
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleEventTriggerState battleEventTriggerState in this.m_eventTriggerStates)
			{
				if (battleEventTriggerState.m_status == BattleConditionStatus.Progress)
				{
					if (battleEventTriggerState.m_triggerInfo.TriggerType == BattleEventTriggerType.BattleEventTriggerType_ActorNeighbor)
					{
						if (actor.HeroId == battleEventTriggerState.m_triggerInfo.Param1FirstValue())
						{
							BattleActor aliveActorByHeroId = this.GetAliveActorByHeroId(battleEventTriggerState.m_triggerInfo.Param2FirstValue());
							if (aliveActorByHeroId != null && GridPosition.Distance(actor.Position, aliveActorByHeroId.Position) == 1)
							{
								this.TriggerEvent(battleEventTriggerState);
							}
						}
						else if (actor.HeroId == battleEventTriggerState.m_triggerInfo.Param2FirstValue())
						{
							BattleActor aliveActorByHeroId2 = this.GetAliveActorByHeroId(battleEventTriggerState.m_triggerInfo.Param1FirstValue());
							if (aliveActorByHeroId2 != null && GridPosition.Distance(actor.Position, aliveActorByHeroId2.Position) == 1)
							{
								this.TriggerEvent(battleEventTriggerState);
							}
						}
					}
					else if (battleEventTriggerState.m_triggerInfo.TriggerType == BattleEventTriggerType.BattleEventTriggerType_ActorReachPosition)
					{
						int num = battleEventTriggerState.m_triggerInfo.Param2FirstValue();
						if (((battleEventTriggerState.m_triggerInfo.Param1FirstValue() != 0 && actor.HeroId == battleEventTriggerState.m_triggerInfo.Param1FirstValue()) || (num == 1 && actor.TeamNumber == 1) || (num == 2 && actor.TeamNumber == 0 && !actor.IsNpc()) || (num == 3 && actor.TeamNumber == 0 && actor.IsNpc())) && BattleBase.IsActorInPositions(actor, battleEventTriggerState.m_triggerInfo.Param3))
						{
							this.TriggerEvent(battleEventTriggerState);
						}
					}
					else if (battleEventTriggerState.m_triggerInfo.TriggerType == BattleEventTriggerType.BattleEventTriggerType_ActorOverPosition && battleEventTriggerState.m_triggerInfo.Param3.Count > 0 && BattleBase.IsActorClassMatch(actor, battleEventTriggerState.m_triggerInfo.Param1FirstValue()))
					{
						int x = battleEventTriggerState.m_triggerInfo.Param3[0].X;
						int y = battleEventTriggerState.m_triggerInfo.Param3[0].Y;
						if (x >= 0)
						{
							if ((actor.InitPosition.x < x && actor.Position.x > x) || (actor.InitPosition.x > x && actor.Position.x < x))
							{
								this.TriggerEvent(battleEventTriggerState);
							}
						}
						else if (y >= 0 && ((actor.InitPosition.y < y && actor.Position.y > y) || (actor.InitPosition.y > y && actor.Position.y < y)))
						{
							this.TriggerEvent(battleEventTriggerState);
						}
					}
				}
			}
		}

		// Token: 0x06003527 RID: 13607 RVA: 0x000E9658 File Offset: 0x000E7858
		private void CheckEventTriggerOnActorDie(BattleActor actor)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckEventTriggerOnActorDieBattleActor_hotfix != null)
			{
				this.m_CheckEventTriggerOnActorDieBattleActor_hotfix.call(new object[]
				{
					this,
					actor
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleEventTriggerState battleEventTriggerState in this.m_eventTriggerStates)
			{
				if (battleEventTriggerState.m_status == BattleConditionStatus.Progress)
				{
					if (battleEventTriggerState.m_triggerInfo.TriggerType == BattleEventTriggerType.BattleEventTriggerType_ActorDie)
					{
						if (battleEventTriggerState.m_triggerInfo.Param1.Contains(actor.HeroId))
						{
							this.TriggerEvent(battleEventTriggerState);
						}
					}
					else if (battleEventTriggerState.m_triggerInfo.TriggerType == BattleEventTriggerType.BattleEventTriggerType_KillCount)
					{
						List<int> list = null;
						if (battleEventTriggerState.m_triggerInfo.Param1FirstValue() != 0)
						{
							list = this.AllocateTempIntList();
							list.Add(battleEventTriggerState.m_triggerInfo.Param1FirstValue());
						}
						if (this.m_teams[1].ComputeDeadActorCount(list, NpcCondition.DontCare) >= battleEventTriggerState.m_triggerInfo.Param2FirstValue())
						{
							this.TriggerEvent(battleEventTriggerState);
						}
						if (list != null)
						{
							this.FreeTempIntList(list);
						}
					}
					else if (battleEventTriggerState.m_triggerInfo.TriggerType == BattleEventTriggerType.BattleEventTriggerType_GroupDie && actor.GroupId == battleEventTriggerState.m_triggerInfo.Param1FirstValue() && this.m_teams[1].IsGroupDie(battleEventTriggerState.m_triggerInfo.Param1FirstValue()))
					{
						this.TriggerEvent(battleEventTriggerState);
					}
				}
			}
		}

		// Token: 0x06003528 RID: 13608 RVA: 0x000E9828 File Offset: 0x000E7A28
		private void CheckEventTriggerOnActorActionBegin(BattleActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckEventTriggerOnActorActionBeginBattleActor_hotfix != null)
			{
				this.m_CheckEventTriggerOnActorActionBeginBattleActor_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleEventTriggerState battleEventTriggerState in this.m_eventTriggerStates)
			{
				if (battleEventTriggerState.m_status == BattleConditionStatus.Progress)
				{
					if (battleEventTriggerState.m_triggerInfo.TriggerType == BattleEventTriggerType.BattleEventTriggerType_ActorFirstAction && a.HeroId == battleEventTriggerState.m_triggerInfo.Param1FirstValue() && a.GetActionCount() == 0)
					{
						this.TriggerEvent(battleEventTriggerState);
					}
				}
			}
		}

		// Token: 0x06003529 RID: 13609 RVA: 0x000E992C File Offset: 0x000E7B2C
		private void CheckEventTriggerOnActorCombatAttackBefore(BattleActor a, BattleActor target)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckEventTriggerOnActorCombatAttackBeforeBattleActorBattleActor_hotfix != null)
			{
				this.m_CheckEventTriggerOnActorCombatAttackBeforeBattleActorBattleActor_hotfix.call(new object[]
				{
					this,
					a,
					target
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleEventTriggerState battleEventTriggerState in this.m_eventTriggerStates)
			{
				if (battleEventTriggerState.m_status == BattleConditionStatus.Progress)
				{
					if (battleEventTriggerState.m_triggerInfo.TriggerType == BattleEventTriggerType.BattleEventTriggerType_ActorFirstAttack)
					{
						if (a.HeroId == battleEventTriggerState.m_triggerInfo.Param1FirstValue() && a.GetCombatAttackCount() == 0)
						{
							this.TriggerEvent(battleEventTriggerState);
						}
					}
					else if (battleEventTriggerState.m_triggerInfo.TriggerType == BattleEventTriggerType.BattleEventTriggerType_ActorAttackTarget && a.HeroId == battleEventTriggerState.m_triggerInfo.Param1FirstValue() && target.HeroId == battleEventTriggerState.m_triggerInfo.Param2FirstValue())
					{
						this.TriggerEvent(battleEventTriggerState);
					}
				}
			}
		}

		// Token: 0x0600352A RID: 13610 RVA: 0x000E9A8C File Offset: 0x000E7C8C
		private void CheckEventTriggerOnActorCombatAttackAfter(BattleActor a, BattleActor target)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckEventTriggerOnActorCombatAttackAfterBattleActorBattleActor_hotfix != null)
			{
				this.m_CheckEventTriggerOnActorCombatAttackAfterBattleActorBattleActor_hotfix.call(new object[]
				{
					this,
					a,
					target
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleEventTriggerState battleEventTriggerState in this.m_eventTriggerStates)
			{
				if (battleEventTriggerState.m_status == BattleConditionStatus.Progress)
				{
					if (battleEventTriggerState.m_triggerInfo.TriggerType == BattleEventTriggerType.BattleEventTriggerType_ActorFirstAttackAfter)
					{
						if (a.HeroId == battleEventTriggerState.m_triggerInfo.Param1FirstValue() && a.GetCombatAttackCount() == 0)
						{
							this.TriggerEvent(battleEventTriggerState);
						}
					}
					else if (battleEventTriggerState.m_triggerInfo.TriggerType == BattleEventTriggerType.BattleEventTriggerType_ActorAttackTargetAfter && a.HeroId == battleEventTriggerState.m_triggerInfo.Param1FirstValue() && target.HeroId == battleEventTriggerState.m_triggerInfo.Param2FirstValue())
					{
						this.TriggerEvent(battleEventTriggerState);
					}
				}
			}
		}

		// Token: 0x0600352B RID: 13611 RVA: 0x000E9BEC File Offset: 0x000E7DEC
		private void CheckEventTriggerOnActorBeCombatAttack(BattleActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckEventTriggerOnActorBeCombatAttackBattleActor_hotfix != null)
			{
				this.m_CheckEventTriggerOnActorBeCombatAttackBattleActor_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleEventTriggerState battleEventTriggerState in this.m_eventTriggerStates)
			{
				if (battleEventTriggerState.m_status == BattleConditionStatus.Progress)
				{
					if (battleEventTriggerState.m_triggerInfo.TriggerType == BattleEventTriggerType.BattleEventTriggerType_ActorFirstBeAttack && a.HeroId == battleEventTriggerState.m_triggerInfo.Param1FirstValue() && a.GetBeCombatAttackCount() == 0)
					{
						this.TriggerEvent(battleEventTriggerState);
					}
				}
			}
		}

		// Token: 0x0600352C RID: 13612 RVA: 0x000E9CF0 File Offset: 0x000E7EF0
		public void CheckEventTriggerOnActorUseSkill(BattleActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckEventTriggerOnActorUseSkillBattleActor_hotfix != null)
			{
				this.m_CheckEventTriggerOnActorUseSkillBattleActor_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleEventTriggerState battleEventTriggerState in this.m_eventTriggerStates)
			{
				if (battleEventTriggerState.m_status == BattleConditionStatus.Progress)
				{
					if (battleEventTriggerState.m_triggerInfo.TriggerType == BattleEventTriggerType.BattleEventTriggerType_ActorFirstSkill && a.HeroId == battleEventTriggerState.m_triggerInfo.Param1FirstValue() && a.GetUseSkillCount() == 0)
					{
						this.TriggerEvent(battleEventTriggerState);
					}
				}
			}
		}

		// Token: 0x0600352D RID: 13613 RVA: 0x000E9DF4 File Offset: 0x000E7FF4
		private void CheckEventTriggerOnNextStep()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckEventTriggerOnNextStep_hotfix != null)
			{
				this.m_CheckEventTriggerOnNextStep_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleEventTriggerState battleEventTriggerState in this.m_eventTriggerStates)
			{
				if (battleEventTriggerState.m_status == BattleConditionStatus.Progress)
				{
					if (battleEventTriggerState.m_triggerInfo.TriggerType == BattleEventTriggerType.BattleEventTriggerType_ActorHpLess)
					{
						BattleActor actorByHeroId = this.GetActorByHeroId(battleEventTriggerState.m_triggerInfo.Param1FirstValue());
						if (actorByHeroId != null && actorByHeroId.GetTotalHealthPoint() * 10000 / actorByHeroId.GetTotalHealthPointMax() <= battleEventTriggerState.m_triggerInfo.Param2FirstValue())
						{
							this.TriggerEvent(battleEventTriggerState);
						}
					}
					else if (battleEventTriggerState.m_triggerInfo.TriggerType == BattleEventTriggerType.BattleEventTriggerType_ActorCountLess)
					{
						List<int> list = null;
						if (battleEventTriggerState.m_triggerInfo.Param1FirstValue() != 0)
						{
							list = this.AllocateTempIntList();
							list.Add(battleEventTriggerState.m_triggerInfo.Param1FirstValue());
						}
						if (this.m_teams[1].ComputeAliveActorCount(list, NpcCondition.DontCare) <= battleEventTriggerState.m_triggerInfo.Param2FirstValue())
						{
							this.TriggerEvent(battleEventTriggerState);
						}
						if (list != null)
						{
							this.FreeTempIntList(list);
						}
					}
				}
			}
		}

		// Token: 0x0600352E RID: 13614 RVA: 0x000E9F74 File Offset: 0x000E8174
		private void CheckEventTriggerOnNextTeam(int team, bool isNpc)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckEventTriggerOnNextTeamInt32Boolean_hotfix != null)
			{
				this.m_CheckEventTriggerOnNextTeamInt32Boolean_hotfix.call(new object[]
				{
					this,
					team,
					isNpc
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleEventTriggerState battleEventTriggerState in this.m_eventTriggerStates)
			{
				if (battleEventTriggerState.m_status == BattleConditionStatus.Progress)
				{
					if (battleEventTriggerState.m_triggerInfo.TriggerType == BattleEventTriggerType.BattleEventTriggerType_TurnCount)
					{
						if (this.m_turn == battleEventTriggerState.m_triggerInfo.Param1FirstValue())
						{
							int num = battleEventTriggerState.m_triggerInfo.Param2FirstValue();
							if (((num == 0 || num == 1) && team == 0 && !isNpc) || (num == 2 && team == 0 && isNpc) || (num == 3 && team == 1))
							{
								this.TriggerEvent(battleEventTriggerState);
							}
						}
					}
					else if (battleEventTriggerState.m_triggerInfo.TriggerType == BattleEventTriggerType.BattleEventTriggerType_TriggerTurnCount)
					{
						int triggerId = battleEventTriggerState.m_triggerInfo.Param1FirstValue();
						if (this.IsEventTriggerd(triggerId))
						{
							BattleEventTriggerState eventTriggerState = this.GetEventTriggerState(triggerId);
							if (eventTriggerState != null && this.m_turn >= eventTriggerState.m_triggerTurn + battleEventTriggerState.m_triggerInfo.Param2FirstValue())
							{
								int num2 = 0;
								if (battleEventTriggerState.m_triggerInfo.Param3.Count > 0)
								{
									num2 = battleEventTriggerState.m_triggerInfo.Param3[0].X;
								}
								if (((num2 == 0 || num2 == 1) && team == 0 && !isNpc) || (num2 == 2 && team == 0 && isNpc) || (num2 == 3 && team == 1))
								{
									this.TriggerEvent(battleEventTriggerState);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600352F RID: 13615 RVA: 0x000EA1A0 File Offset: 0x000E83A0
		private void CheckEventTriggerOnCompleteAchievement(int achievementId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckEventTriggerOnCompleteAchievementInt32_hotfix != null)
			{
				this.m_CheckEventTriggerOnCompleteAchievementInt32_hotfix.call(new object[]
				{
					this,
					achievementId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleEventTriggerState battleEventTriggerState in this.m_eventTriggerStates)
			{
				if (battleEventTriggerState.m_status == BattleConditionStatus.Progress)
				{
					if (battleEventTriggerState.m_triggerInfo.TriggerType == BattleEventTriggerType.BattleEventTriggerType_Achievement && achievementId == battleEventTriggerState.m_triggerInfo.Param1FirstValue())
					{
						this.TriggerEvent(battleEventTriggerState);
					}
				}
			}
		}

		// Token: 0x06003530 RID: 13616 RVA: 0x000EA294 File Offset: 0x000E8494
		private void CheckEventTriggerOnWin()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckEventTriggerOnWin_hotfix != null)
			{
				this.m_CheckEventTriggerOnWin_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleEventTriggerState battleEventTriggerState in this.m_eventTriggerStates)
			{
				if (battleEventTriggerState.m_status == BattleConditionStatus.Progress)
				{
					if (battleEventTriggerState.m_triggerInfo.TriggerType == BattleEventTriggerType.BattleEventTriggerType_Win)
					{
						this.TriggerEvent(battleEventTriggerState);
					}
				}
			}
		}

		// Token: 0x06003531 RID: 13617 RVA: 0x000EA368 File Offset: 0x000E8568
		private void CheckEventTriggerOnLose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckEventTriggerOnLose_hotfix != null)
			{
				this.m_CheckEventTriggerOnLose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06003532 RID: 13618 RVA: 0x000EA3C8 File Offset: 0x000E85C8
		private void CheckBattleStopEventTrigger()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckBattleStopEventTrigger_hotfix != null)
			{
				this.m_CheckBattleStopEventTrigger_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_needCheckBattleStopEventTrigger)
			{
				this.m_needCheckBattleStopEventTrigger = false;
				if (this.m_state == BattleState.Stop)
				{
					if (this.IsWin())
					{
						this.CheckEventTriggerOnWin();
					}
					else
					{
						this.CheckEventTriggerOnLose();
					}
				}
			}
		}

		// Token: 0x06003533 RID: 13619 RVA: 0x000EA464 File Offset: 0x000E8664
		private void CheckMultiEventTrigger()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckMultiEventTrigger_hotfix != null)
			{
				this.m_CheckMultiEventTrigger_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleEventTriggerState battleEventTriggerState in this.m_eventTriggerStates)
			{
				if (battleEventTriggerState.m_status == BattleConditionStatus.Progress)
				{
					if (battleEventTriggerState.m_triggerInfo.TriggerType == BattleEventTriggerType.BattleEventTriggerType_MultiTrigger && battleEventTriggerState.m_triggerInfo.Param1.Count > 0)
					{
						bool flag = true;
						foreach (int triggerId in battleEventTriggerState.m_triggerInfo.Param1)
						{
							if (!this.IsEventTriggerd(triggerId))
							{
								flag = false;
								break;
							}
						}
						if (flag)
						{
							this.TriggerEvent(battleEventTriggerState);
						}
					}
				}
			}
		}

		// Token: 0x06003534 RID: 13620 RVA: 0x000EA5B4 File Offset: 0x000E87B4
		private bool IsEventTriggerd(int triggerId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsEventTriggerdInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsEventTriggerdInt32_hotfix.call(new object[]
				{
					this,
					triggerId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleEventTriggerState battleEventTriggerState in this.m_eventTriggerStates)
			{
				if (battleEventTriggerState.m_triggerInfo.ID == triggerId)
				{
					if (battleEventTriggerState.m_triggerInfo.TriggerType == BattleEventTriggerType.BattleEventTriggerType_NotTrigger)
					{
						foreach (int triggerId2 in battleEventTriggerState.m_triggerInfo.Param1)
						{
							if (this.IsEventTriggerd(triggerId2))
							{
								return false;
							}
						}
						return true;
					}
					return battleEventTriggerState.m_triggerCount > 0;
				}
			}
			return false;
		}

		// Token: 0x06003535 RID: 13621 RVA: 0x000EA714 File Offset: 0x000E8914
		private BattleEventTriggerState GetEventTriggerState(int triggerId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetEventTriggerStateInt32_hotfix != null)
			{
				return (BattleEventTriggerState)this.m_GetEventTriggerStateInt32_hotfix.call(new object[]
				{
					this,
					triggerId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleEventTriggerState battleEventTriggerState in this.m_eventTriggerStates)
			{
				if (battleEventTriggerState.m_triggerInfo.ID == triggerId)
				{
					return battleEventTriggerState;
				}
			}
			return null;
		}

		// Token: 0x06003536 RID: 13622 RVA: 0x000EA7F4 File Offset: 0x000E89F4
		private void TriggerEvent(BattleEventTriggerState state)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TriggerEventBattleEventTriggerState_hotfix != null)
			{
				this.m_TriggerEventBattleEventTriggerState_hotfix.call(new object[]
				{
					this,
					state
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (state.m_triggerCount == 0)
			{
				state.m_triggerTurn = this.m_turn;
			}
			state.m_triggerCount++;
			if (!state.m_triggerInfo.CanRepeat)
			{
				state.m_status = BattleConditionStatus.Success;
			}
			if (this.IsEnableDebugLog())
			{
				DebugUtility.Log(string.Format("BattleBase.TriggerEvent(), triggerId {0}", state.m_triggerInfo.ID));
			}
			this.ExecuteTriggerEventActions(state, 0);
		}

		// Token: 0x06003537 RID: 13623 RVA: 0x000EA8D4 File Offset: 0x000E8AD4
		private void ExecuteTriggerEventActions(BattleEventTriggerState state, int fromIdx = 0)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteTriggerEventActionsBattleEventTriggerStateInt32_hotfix != null)
			{
				this.m_ExecuteTriggerEventActionsBattleEventTriggerStateInt32_hotfix.call(new object[]
				{
					this,
					state,
					fromIdx
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			for (int i = fromIdx; i < state.m_triggerInfo.m_battleEventActionInfos.Length; i++)
			{
				ConfigDataBattleEventActionInfo e = state.m_triggerInfo.m_battleEventActionInfos[i];
				this.ExecuteEventAction(e);
				if (this.m_state == BattleState.Combat)
				{
					this.m_afterCombatExecuteTriggerState = state;
					this.m_afterCombatExecuteTriggerEventActionIndex = i + 1;
					return;
				}
			}
			this.CheckMultiEventTrigger();
			this.CheckWinConditionOnEventTrigger(state);
			this.CheckLoseConditionOnEventTrigger(state);
		}

		// Token: 0x06003538 RID: 13624 RVA: 0x000EA9B8 File Offset: 0x000E8BB8
		private void ExecuteEventAction(ConfigDataBattleEventActionInfo e)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteEventActionConfigDataBattleEventActionInfo_hotfix != null)
			{
				this.m_ExecuteEventActionConfigDataBattleEventActionInfo_hotfix.call(new object[]
				{
					this,
					e
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsEnableDebugLog())
			{
				DebugUtility.Log(string.Format("BattleBase.ExecuteEventAction(), actionId {0}", e.ID));
			}
			if (e.ActionType == BattleEventActionType.BattleEventActionType_Relief)
			{
				this.ExecuteEventAction_Relief(e);
			}
			else if (e.ActionType == BattleEventActionType.BattleEventActionType_Retreat)
			{
				this.ExecuteEventAction_Retreat(e);
			}
			else if (e.ActionType == BattleEventActionType.BattleEventActionType_Dialog)
			{
				this.ExecuteEventAction_Dialog(e);
			}
			else if (e.ActionType == BattleEventActionType.BattleEventActionType_ChangeTeam)
			{
				this.ExecuteEventAction_ChangeTeam(e);
			}
			else if (e.ActionType == BattleEventActionType.BattleEventActionType_AttachBuff)
			{
				this.ExecuteEventAction_AttachBuff(e);
			}
			else if (e.ActionType == BattleEventActionType.BattleEventActionType_ChangeBehavior)
			{
				this.ExecuteEventAction_ChangeBehavior(e);
			}
			else if (e.ActionType == BattleEventActionType.BattleEventActionType_Music)
			{
				this.ExecuteEventAction_Music(e);
			}
			else if (e.ActionType == BattleEventActionType.BattleEventActionType_ChangeTerrain)
			{
				this.ExecuteEventAction_ChangeTerrain(e);
			}
			else if (e.ActionType == BattleEventActionType.BattleEventActionType_Perform)
			{
				this.ExecuteEventAction_Perform(e);
			}
			else if (e.ActionType == BattleEventActionType.BattleEventActionType_RetreatPosition)
			{
				this.ExecuteEventAction_RetreatPosition(e);
			}
			else if (e.ActionType == BattleEventActionType.BattleEventActionType_Replace)
			{
				this.ExecuteEventAction_Replace(e);
			}
			else if (e.ActionType == BattleEventActionType.BattleEventActionType_RemoveBuff)
			{
				this.ExecuteEventAction_RemoveBuff(e);
			}
			else if (e.ActionType == BattleEventActionType.BattleEventActionType_AttachBuffPosition)
			{
				this.ExecuteEventAction_AttachBuffPosition(e);
			}
		}

		// Token: 0x06003539 RID: 13625 RVA: 0x000EAB88 File Offset: 0x000E8D88
		private void ExecuteEventAction_Relief(ConfigDataBattleEventActionInfo e)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteEventAction_ReliefConfigDataBattleEventActionInfo_hotfix != null)
			{
				this.m_ExecuteEventAction_ReliefConfigDataBattleEventActionInfo_hotfix.call(new object[]
				{
					this,
					e
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			bool isNpc = false;
			if (e.Param1.Count > 0)
			{
				if (e.Param1[0] == 1)
				{
					num = 0;
					isNpc = true;
				}
				else if (e.Param1[0] == 2)
				{
					num = 1;
					isNpc = false;
				}
			}
			bool flag = true;
			this.m_teams[num].AddGroupBehaviors(e.m_reliefGroupBehaviors);
			List<RandomArmyActor> list = null;
			if (e.ReliefRandomArmies_ID.Count > 0)
			{
				list = this.GetRandomBattleArmyActors(e.ReliefRandomArmies_ID);
			}
			int num2 = 0;
			while (num2 < e.Param2.Count && num2 < e.Param3.Count)
			{
				int num3 = e.Param2[num2];
				ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(num3);
				if (configDataHeroInfo != null)
				{
					MoveType moveType = BattleActor.ComputeDefaultMoveType(configDataHeroInfo);
					GridPosition gridPosition = this.FindEmptyNearPosition(new GridPosition(e.Param3[num2].X, e.Param3[num2].Y), moveType);
					if (!(gridPosition == GridPosition.Null))
					{
						if (flag)
						{
							this.m_battleListener.OnCameraFocus(gridPosition);
							flag = false;
						}
						int heroLevel = (num2 >= e.Param4.Count) ? 0 : e.Param4[num2];
						int behaviorId = (num2 >= e.ReliefActorsBehavior.Count) ? -1 : e.ReliefActorsBehavior[num2];
						int groupId = (num2 >= e.ReliefGroups.Count) ? 0 : e.ReliefGroups[num2];
						int dir = (num2 >= e.Param6.Count) ? 0 : e.Param6[num2];
						if (list != null && num2 < list.Count && list[num2] != null)
						{
							num3 = list[num2].HeroID;
							heroLevel = list[num2].Level;
							behaviorId = list[num2].AI;
						}
						this.CreateEventActor(gridPosition, dir, num, isNpc, num3, heroLevel, behaviorId, groupId, 0, e.Param5, BattleActorSourceType.Event);
					}
				}
				num2++;
			}
			this.m_teams[num].UpdateGroups();
		}

		// Token: 0x0600353A RID: 13626 RVA: 0x000EAE4C File Offset: 0x000E904C
		private void ExecuteEventAction_Retreat(ConfigDataBattleEventActionInfo e)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteEventAction_RetreatConfigDataBattleEventActionInfo_hotfix != null)
			{
				this.m_ExecuteEventAction_RetreatConfigDataBattleEventActionInfo_hotfix.call(new object[]
				{
					this,
					e
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<BattleActor> list = this.AllocateTempActorList();
			this.GetAliveActorsByHeroIdsAndGroupIds(e.Param1, e.Param6, list);
			int effectType = e.Param2FirstValue();
			foreach (BattleActor battleActor in list)
			{
				this.m_battleListener.OnBattleActorCameraFocus(battleActor);
				battleActor.Retreat(effectType, e.Param5, true);
			}
			this.FreeTempActorList(list);
		}

		// Token: 0x0600353B RID: 13627 RVA: 0x000EAF44 File Offset: 0x000E9144
		private void ExecuteEventAction_Dialog(ConfigDataBattleEventActionInfo e)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteEventAction_DialogConfigDataBattleEventActionInfo_hotfix != null)
			{
				this.m_ExecuteEventAction_DialogConfigDataBattleEventActionInfo_hotfix.call(new object[]
				{
					this,
					e
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = this.m_configDataLoader.GetConfigDataBattleDialogInfo(e.Param1FirstValue());
			if (configDataBattleDialogInfo != null)
			{
				this.m_battleListener.OnStartBattleDialog(configDataBattleDialogInfo);
			}
		}

		// Token: 0x0600353C RID: 13628 RVA: 0x000EAFD8 File Offset: 0x000E91D8
		private void ExecuteEventAction_ChangeTeam(ConfigDataBattleEventActionInfo e)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteEventAction_ChangeTeamConfigDataBattleEventActionInfo_hotfix != null)
			{
				this.m_ExecuteEventAction_ChangeTeamConfigDataBattleEventActionInfo_hotfix.call(new object[]
				{
					this,
					e
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int team = 0;
			bool isNpc = false;
			if (e.Param2.Count > 0)
			{
				if (e.Param2[0] == 1)
				{
					team = 0;
				}
				else if (e.Param2[0] == 2)
				{
					team = 1;
				}
				else if (e.Param2[0] == 3)
				{
					team = 0;
					isNpc = true;
				}
			}
			List<BattleActor> list = this.AllocateTempActorList();
			this.GetAliveActorsByHeroIdsAndGroupIds(e.Param1, e.Param6, list);
			foreach (BattleActor battleActor in list)
			{
				this.m_battleListener.OnBattleActorCameraFocus(battleActor);
				battleActor.ChangeTeam(team, isNpc);
			}
			this.FreeTempActorList(list);
		}

		// Token: 0x0600353D RID: 13629 RVA: 0x000EB120 File Offset: 0x000E9320
		private void ExecuteEventAction_AttachBuff(ConfigDataBattleEventActionInfo e)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteEventAction_AttachBuffConfigDataBattleEventActionInfo_hotfix != null)
			{
				this.m_ExecuteEventAction_AttachBuffConfigDataBattleEventActionInfo_hotfix.call(new object[]
				{
					this,
					e
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<BattleActor> list = this.AllocateTempActorList();
			if (e.Param4.Count > 0)
			{
				int num = 0;
				bool flag = false;
				if (e.Param4[0] == 2)
				{
					num = 1;
				}
				else if (e.Param4[0] == 3)
				{
					flag = true;
				}
				foreach (BattleActor battleActor in this.m_teams[num].GetActors())
				{
					if (!battleActor.IsDeadOrRetreat())
					{
						if (!flag || battleActor.IsNpc())
						{
							list.Add(battleActor);
						}
					}
				}
			}
			else
			{
				this.GetAliveActorsByHeroIdsAndGroupIds(e.Param1, e.Param6, list);
			}
			foreach (BattleActor battleActor2 in list)
			{
				this.m_battleListener.OnBattleActorCameraFocus(battleActor2);
				foreach (int key in e.Param2)
				{
					ConfigDataBuffInfo configDataBuffInfo = this.m_configDataLoader.GetConfigDataBuffInfo(key);
					if (configDataBuffInfo != null)
					{
						battleActor2.AttachBuff(configDataBuffInfo, battleActor2, BuffSourceType.EventApply, null, null);
					}
				}
				this.m_battleListener.OnWaitTime(500);
			}
			this.FreeTempActorList(list);
		}

		// Token: 0x0600353E RID: 13630 RVA: 0x000EB340 File Offset: 0x000E9540
		private void ExecuteEventAction_ChangeBehavior(ConfigDataBattleEventActionInfo e)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteEventAction_ChangeBehaviorConfigDataBattleEventActionInfo_hotfix != null)
			{
				this.m_ExecuteEventAction_ChangeBehaviorConfigDataBattleEventActionInfo_hotfix.call(new object[]
				{
					this,
					e
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int behavior = e.Param2FirstValue();
			List<BattleActor> list = this.AllocateTempActorList();
			this.GetAliveActorsByHeroIdsAndGroupIds(e.Param1, e.Param6, list);
			foreach (BattleActor battleActor in list)
			{
				battleActor.SetBehavior(behavior);
			}
			this.FreeTempActorList(list);
		}

		// Token: 0x0600353F RID: 13631 RVA: 0x000EB424 File Offset: 0x000E9624
		private void ExecuteEventAction_Music(ConfigDataBattleEventActionInfo e)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteEventAction_MusicConfigDataBattleEventActionInfo_hotfix != null)
			{
				this.m_ExecuteEventAction_MusicConfigDataBattleEventActionInfo_hotfix.call(new object[]
				{
					this,
					e
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleListener.OnPlayMusic(e.Param5);
		}

		// Token: 0x06003540 RID: 13632 RVA: 0x000EB4A8 File Offset: 0x000E96A8
		private void ExecuteEventAction_ChangeTerrain(ConfigDataBattleEventActionInfo e)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteEventAction_ChangeTerrainConfigDataBattleEventActionInfo_hotfix != null)
			{
				this.m_ExecuteEventAction_ChangeTerrainConfigDataBattleEventActionInfo_hotfix.call(new object[]
				{
					this,
					e
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataTerrainInfo configDataTerrainInfo = this.m_configDataLoader.GetConfigDataTerrainInfo(e.Param1FirstValue());
			if (configDataTerrainInfo != null && e.Param3.Count > 0)
			{
				int num = 0;
				int num2 = 0;
				foreach (ParamPosition paramPosition in e.Param3)
				{
					num += paramPosition.X;
					num2 += paramPosition.Y;
				}
				this.m_battleListener.OnCameraFocus(new GridPosition(num / e.Param3.Count, num2 / e.Param3.Count));
				foreach (ParamPosition paramPosition2 in e.Param3)
				{
					GridPosition p = new GridPosition(paramPosition2.X, paramPosition2.Y);
					this.ChangeMapTerrain(p, configDataTerrainInfo);
				}
				this.m_battleListener.OnWaitTime(500);
			}
		}

		// Token: 0x06003541 RID: 13633 RVA: 0x000EB640 File Offset: 0x000E9840
		private void ExecuteEventAction_Perform(ConfigDataBattleEventActionInfo e)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteEventAction_PerformConfigDataBattleEventActionInfo_hotfix != null)
			{
				this.m_ExecuteEventAction_PerformConfigDataBattleEventActionInfo_hotfix.call(new object[]
				{
					this,
					e
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataBattlePerformInfo configDataBattlePerformInfo = this.m_configDataLoader.GetConfigDataBattlePerformInfo(e.Param1FirstValue());
			if (configDataBattlePerformInfo != null)
			{
				this.ExecuteBattlePerforms(configDataBattlePerformInfo);
			}
		}

		// Token: 0x06003542 RID: 13634 RVA: 0x000EB6D0 File Offset: 0x000E98D0
		private void ExecuteEventAction_RetreatPosition(ConfigDataBattleEventActionInfo e)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteEventAction_RetreatPositionConfigDataBattleEventActionInfo_hotfix != null)
			{
				this.m_ExecuteEventAction_RetreatPositionConfigDataBattleEventActionInfo_hotfix.call(new object[]
				{
					this,
					e
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int effectType = e.Param2FirstValue();
			foreach (ParamPosition paramPosition in e.Param3)
			{
				GridPosition p = new GridPosition(paramPosition.X, paramPosition.Y);
				BattleActor actor = this.m_map.GetActor(p);
				if (actor != null && !actor.IsDeadOrRetreat())
				{
					if (e.Param1.Count > 0)
					{
						int teamNumber = actor.TeamNumber;
						if (e.Param1[0] == 1 && teamNumber != 1)
						{
							continue;
						}
						if (e.Param1[0] == 2 && teamNumber != 0)
						{
							continue;
						}
						if (e.Param1[0] == 3 && !actor.IsNpc())
						{
							continue;
						}
					}
					actor.Retreat(effectType, e.Param5, true);
				}
			}
		}

		// Token: 0x06003543 RID: 13635 RVA: 0x000EB854 File Offset: 0x000E9A54
		private void ExecuteEventAction_Replace(ConfigDataBattleEventActionInfo e)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteEventAction_ReplaceConfigDataBattleEventActionInfo_hotfix != null)
			{
				this.m_ExecuteEventAction_ReplaceConfigDataBattleEventActionInfo_hotfix.call(new object[]
				{
					this,
					e
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int heroId = 0;
			int heroLevel = 0;
			if (e.Param2.Count > 0)
			{
				heroId = e.Param2[0];
			}
			if (e.Param2.Count > 1)
			{
				heroLevel = e.Param2[1];
			}
			List<BattleActor> list = this.AllocateTempActorList();
			this.GetAliveActorsByHeroIdsAndGroupIds(e.Param1, e.Param6, list);
			foreach (BattleActor a in list)
			{
				this.m_battleListener.OnBattleActorCameraFocus(a);
				this.ReplaceEventActor(a, heroId, heroLevel, e.Param5);
			}
			this.FreeTempActorList(list);
		}

		// Token: 0x06003544 RID: 13636 RVA: 0x000EB988 File Offset: 0x000E9B88
		private void ExecuteEventAction_RemoveBuff(ConfigDataBattleEventActionInfo e)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteEventAction_RemoveBuffConfigDataBattleEventActionInfo_hotfix != null)
			{
				this.m_ExecuteEventAction_RemoveBuffConfigDataBattleEventActionInfo_hotfix.call(new object[]
				{
					this,
					e
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<BattleActor> list = this.AllocateTempActorList();
			if (e.Param4.Count > 0)
			{
				int num = 0;
				bool flag = false;
				if (e.Param4[0] == 2)
				{
					num = 1;
				}
				else if (e.Param4[0] == 3)
				{
					flag = true;
				}
				foreach (BattleActor battleActor in this.m_teams[num].GetActors())
				{
					if (!battleActor.IsDeadOrRetreat())
					{
						if (!flag || battleActor.IsNpc())
						{
							list.Add(battleActor);
						}
					}
				}
			}
			else
			{
				this.GetAliveActorsByHeroIdsAndGroupIds(e.Param1, e.Param6, list);
			}
			foreach (BattleActor battleActor2 in list)
			{
				this.m_battleListener.OnBattleActorCameraFocus(battleActor2);
				this.m_battleListener.OnPlayFx(e.Param5, battleActor2.Position);
				battleActor2.RemoveBuffList(e.Param2);
				this.m_battleListener.OnWaitTime(500);
			}
			this.FreeTempActorList(list);
		}

		// Token: 0x06003545 RID: 13637 RVA: 0x000EBB64 File Offset: 0x000E9D64
		private void ExecuteEventAction_AttachBuffPosition(ConfigDataBattleEventActionInfo e)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteEventAction_AttachBuffPositionConfigDataBattleEventActionInfo_hotfix != null)
			{
				this.m_ExecuteEventAction_AttachBuffPositionConfigDataBattleEventActionInfo_hotfix.call(new object[]
				{
					this,
					e
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (ParamPosition paramPosition in e.Param3)
			{
				GridPosition p = new GridPosition(paramPosition.X, paramPosition.Y);
				BattleActor actor = this.m_map.GetActor(p);
				if (actor != null && !actor.IsDeadOrRetreat())
				{
					if (e.Param1.Count > 0)
					{
						int teamNumber = actor.TeamNumber;
						if (e.Param1[0] == 1)
						{
							if (teamNumber != 1)
							{
								continue;
							}
						}
						else if (e.Param1[0] == 2)
						{
							if (teamNumber != 0)
							{
								continue;
							}
						}
						else if (e.Param1[0] == 3 && (teamNumber != 0 || !actor.IsNpc()))
						{
							continue;
						}
					}
					this.m_battleListener.OnBattleActorCameraFocus(actor);
					foreach (int key in e.Param2)
					{
						ConfigDataBuffInfo configDataBuffInfo = this.m_configDataLoader.GetConfigDataBuffInfo(key);
						if (configDataBuffInfo != null)
						{
							actor.AttachBuff(configDataBuffInfo, actor, BuffSourceType.EventApply, null, null);
						}
					}
					this.m_battleListener.OnWaitTime(500);
				}
			}
		}

		// Token: 0x06003546 RID: 13638 RVA: 0x000EBD7C File Offset: 0x000E9F7C
		private bool IsEmptyPosition(GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsEmptyPositionGridPosition_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsEmptyPositionGridPosition_hotfix.call(new object[]
				{
					this,
					p
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_map.IsValidPosition(p) && this.m_map.GetActor(p) == null;
		}

		// Token: 0x06003547 RID: 13639 RVA: 0x000EBE1C File Offset: 0x000EA01C
		private List<RandomArmyActor> GetRandomBattleArmyActors(List<int> randomArmies)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRandomBattleArmyActorsList`1_hotfix != null)
			{
				return (List<RandomArmyActor>)this.m_GetRandomBattleArmyActorsList`1_hotfix.call(new object[]
				{
					this,
					randomArmies
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<RandomArmyActor> list = new List<RandomArmyActor>();
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (int key in randomArmies)
			{
				ConfigDataBattleRandomArmyInfo configDataBattleRandomArmyInfo = this.m_configDataLoader.GetConfigDataBattleRandomArmyInfo(key);
				if (configDataBattleRandomArmyInfo == null)
				{
					return null;
				}
				for (int i = 0; i < configDataBattleRandomArmyInfo.RandomArmyActors.Count; i++)
				{
					dictionary.Add(i, configDataBattleRandomArmyInfo.RandomArmyActors[i].Weight);
				}
				int randomNumberByAccumulateWeight = this.m_armyRandomNumber.GetRandomNumberByAccumulateWeight(dictionary);
				if (randomNumberByAccumulateWeight == -2147483648)
				{
					return null;
				}
				list.Add(configDataBattleRandomArmyInfo.RandomArmyActors[randomNumberByAccumulateWeight]);
				dictionary.Clear();
			}
			return list;
		}

		// Token: 0x06003548 RID: 13640 RVA: 0x000EBF80 File Offset: 0x000EA180
		private bool CreateEventActor(GridPosition p, int dir, int team, bool isNpc, int heroId, int heroLevel, int behaviorId, int groupId, int effectType, string fxName, BattleActorSourceType sourceType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateEventActorGridPositionInt32Int32BooleanInt32Int32Int32Int32Int32StringBattleActorSourceType_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CreateEventActorGridPositionInt32Int32BooleanInt32Int32Int32Int32Int32StringBattleActorSourceType_hotfix.call(new object[]
				{
					this,
					p,
					dir,
					team,
					isNpc,
					heroId,
					heroLevel,
					behaviorId,
					groupId,
					effectType,
					fxName,
					sourceType
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsEmptyPosition(p))
			{
				return false;
			}
			ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(heroId);
			if (configDataHeroInfo == null)
			{
				return false;
			}
			ConfigDataJobConnectionInfo jobConnectionInfo = configDataHeroInfo.m_jobConnectionInfo;
			ConfigDataSoldierInfo soldierInfo = configDataHeroInfo.m_soldierInfo;
			if (heroLevel == 0)
			{
				heroLevel = this.m_monsterLevel;
			}
			if (dir == 0)
			{
				int num = this.m_map.Width / 2;
				dir = ((p.x > num) ? -1 : 1);
			}
			int const_SoldierCountMax = this.m_configDataLoader.Const_SoldierCountMax;
			BattleActor battleActor = this.m_teams[team].CreateActor();
			battleActor.Initialize(this.m_teams[team], configDataHeroInfo, jobConnectionInfo, soldierInfo, configDataHeroInfo.m_skillInfos, null, null, null, null, heroLevel, configDataHeroInfo.Star, 0, const_SoldierCountMax, p, dir, isNpc, 0, behaviorId, groupId, sourceType, -1);
			battleActor.InitializeEnd(false, -1, -1);
			this.m_battleListener.OnBattleActorAppear(battleActor, effectType, fxName);
			return true;
		}

		// Token: 0x06003549 RID: 13641 RVA: 0x000EC174 File Offset: 0x000EA374
		private bool ReplaceEventActor(BattleActor a, int heroId, int heroLevel, string fxName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ReplaceEventActorBattleActorInt32Int32String_hotfix != null)
			{
				return Convert.ToBoolean(this.m_ReplaceEventActorBattleActorInt32Int32String_hotfix.call(new object[]
				{
					this,
					a,
					heroId,
					heroLevel,
					fxName
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (a == null)
			{
				return false;
			}
			ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(heroId);
			if (configDataHeroInfo == null)
			{
				return false;
			}
			ConfigDataJobConnectionInfo jobConnectionInfo = configDataHeroInfo.m_jobConnectionInfo;
			ConfigDataSoldierInfo soldierInfo = configDataHeroInfo.m_soldierInfo;
			if (heroLevel == 0)
			{
				heroLevel = a.HeroLevel;
			}
			a.Retreat(0, string.Empty, false);
			int const_SoldierCountMax = this.m_configDataLoader.Const_SoldierCountMax;
			BattleActor battleActor = this.m_teams[a.TeamNumber].CreateActor();
			battleActor.Initialize(this.m_teams[a.TeamNumber], configDataHeroInfo, jobConnectionInfo, soldierInfo, configDataHeroInfo.m_skillInfos, null, null, null, null, heroLevel, configDataHeroInfo.Star, 0, const_SoldierCountMax, a.Position, a.Direction, a.IsNpc(), 0, a.GetBehaviorId(), a.GroupId, BattleActorSourceType.Event, -1);
			battleActor.InitializeEnd(false, -1, -1);
			this.m_battleListener.OnBattleActorReplace(a, battleActor, fxName);
			return true;
		}

		// Token: 0x0600354A RID: 13642 RVA: 0x000EC2EC File Offset: 0x000EA4EC
		private GridPosition FindEmptyFixedDistancePosition(GridPosition target, int distance)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindEmptyFixedDistancePositionGridPositionInt32_hotfix != null)
			{
				return (GridPosition)this.m_FindEmptyFixedDistancePositionGridPositionInt32_hotfix.call(new object[]
				{
					this,
					target,
					distance
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<GridPosition> list = this.AllocateTempGridPositionList();
			this.FindFixedDistanceRegion(target, distance, list);
			GridPosition result = GridPosition.Null;
			foreach (GridPosition gridPosition in list)
			{
				if (this.IsEmptyPosition(gridPosition))
				{
					result = gridPosition;
					break;
				}
			}
			this.FreeTempGridPositionList(list);
			return result;
		}

		// Token: 0x0600354B RID: 13643 RVA: 0x000EC3EC File Offset: 0x000EA5EC
		private GridPosition FindEmptyFixedDistancePosition(GridPosition start, GridPosition target, int distance)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindEmptyFixedDistancePositionGridPositionGridPositionInt32_hotfix != null)
			{
				return (GridPosition)this.m_FindEmptyFixedDistancePositionGridPositionGridPositionInt32_hotfix.call(new object[]
				{
					this,
					start,
					target,
					distance
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<GridPosition> list = this.AllocateTempGridPositionList();
			this.FindFixedDistanceRegion(target, distance, list);
			int num = int.MaxValue;
			GridPosition result = GridPosition.Null;
			foreach (GridPosition gridPosition in list)
			{
				if (this.IsEmptyPosition(gridPosition))
				{
					int num2 = GridPosition.Distance(start, gridPosition);
					if (num2 < num)
					{
						num = num2;
						result = gridPosition;
					}
				}
			}
			this.FreeTempGridPositionList(list);
			return result;
		}

		// Token: 0x0600354C RID: 13644 RVA: 0x000EC514 File Offset: 0x000EA714
		private GridPosition FindEmptyNearPosition(GridPosition target, MoveType moveType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindEmptyNearPositionGridPositionMoveType_hotfix != null)
			{
				return (GridPosition)this.m_FindEmptyNearPositionGridPositionMoveType_hotfix.call(new object[]
				{
					this,
					target,
					moveType
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsEmptyPosition(target))
			{
				return target;
			}
			List<GridPosition> list = this.AllocateTempGridPositionList();
			this.FindAttackRegion(target, 1, 1, list);
			int num = int.MaxValue;
			GridPosition result = GridPosition.Null;
			foreach (GridPosition gridPosition in list)
			{
				if (this.IsEmptyPosition(gridPosition))
				{
					if (this.m_map.GetMovePointCost(gridPosition, moveType) > 0)
					{
						int num2 = GridPosition.Distance(target, gridPosition);
						if (num2 < num)
						{
							num = num2;
							result = gridPosition;
						}
					}
				}
			}
			this.FreeTempGridPositionList(list);
			return result;
		}

		// Token: 0x0600354D RID: 13645 RVA: 0x000EC658 File Offset: 0x000EA858
		public bool CreateMap(ConfigDataBattlefieldInfo battlefieldInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateMapConfigDataBattlefieldInfo_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CreateMapConfigDataBattlefieldInfo_hotfix.call(new object[]
				{
					this,
					battlefieldInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (battlefieldInfo == null)
			{
				return false;
			}
			this.m_battlefieldInfo = battlefieldInfo;
			this.m_map.Initialize(battlefieldInfo.Width, battlefieldInfo.Height);
			return this.m_map.InitializeTerrain(battlefieldInfo, this.m_configDataLoader);
		}

		// Token: 0x0600354E RID: 13646 RVA: 0x000EC70C File Offset: 0x000EA90C
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
			if (this.m_battlefieldInfo == null)
			{
				return;
			}
			if (this.m_map == null)
			{
				return;
			}
			this.m_map.InitializeTerrain(this.m_battlefieldInfo, this.m_configDataLoader);
		}

		// Token: 0x0600354F RID: 13647 RVA: 0x000EC79C File Offset: 0x000EA99C
		public void SetMyPlayerTeamNumber(int team)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetMyPlayerTeamNumberInt32_hotfix != null)
			{
				this.m_SetMyPlayerTeamNumberInt32_hotfix.call(new object[]
				{
					this,
					team
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_myPlayerTeam = team;
		}

		// Token: 0x06003550 RID: 13648 RVA: 0x000EC814 File Offset: 0x000EAA14
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

		// Token: 0x06003551 RID: 13649 RVA: 0x000EC888 File Offset: 0x000EAA88
		public bool InitBattle(ConfigDataBattleInfo battleInfo, BattleType battleType, BattleTeamSetup teamSetup0, BattleTeamSetup teamSetup1, BattlePlayer[] players, int randomSeed, int armyRandomSeed, int monsterLevel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitBattleConfigDataBattleInfoBattleTypeBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32Int32Int32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_InitBattleConfigDataBattleInfoBattleTypeBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32Int32Int32_hotfix.call(new object[]
				{
					this,
					battleInfo,
					battleType,
					teamSetup0,
					teamSetup1,
					players,
					randomSeed,
					armyRandomSeed,
					monsterLevel
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.Clear();
			this.m_battleInfo = battleInfo;
			this.m_battleType = battleType;
			this.m_actionOrderType = ActionOrderType.Normal;
			this.m_monsterLevel = monsterLevel;
			this.m_actionTeam = 0;
			this.m_turnMax = battleInfo.TurnMax;
			this.InitRandomNumbers(randomSeed, armyRandomSeed);
			this.InitPlayers(players);
			this.InitWinConditionStates(battleInfo.m_battleWinConditionInfos);
			this.InitLoseConditionStates(battleInfo.m_battleLoseConditionInfos);
			this.InitEventTriggerStates(battleInfo.m_battleEventTriggerInfos);
			this.InitBattleTreasureStates(this.m_battleInfo.m_battleTreasureInfos);
			this.m_teams[0].SetGroupBehaviorDict(battleInfo.m_npcGroupBehaviors);
			this.m_teams[1].SetGroupBehaviorDict(battleInfo.m_enemyGroupBehaviors);
			this.CreateActors(0, teamSetup0.m_actors);
			this.CreateActors(1, teamSetup1.m_actors);
			return true;
		}

		// Token: 0x06003552 RID: 13650 RVA: 0x000ECA34 File Offset: 0x000EAC34
		public bool InitArenaBattle(ConfigDataArenaBattleInfo battleInfo, BattleTeamSetup teamSetup0, BattleTeamSetup teamSetup1, BattlePlayer[] players, int randomSeed, ConfigDataArenaDefendRuleInfo arenaDefendRuleInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitArenaBattleConfigDataArenaBattleInfoBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32ConfigDataArenaDefendRuleInfo_hotfix != null)
			{
				return Convert.ToBoolean(this.m_InitArenaBattleConfigDataArenaBattleInfoBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32ConfigDataArenaDefendRuleInfo_hotfix.call(new object[]
				{
					this,
					battleInfo,
					teamSetup0,
					teamSetup1,
					players,
					randomSeed,
					arenaDefendRuleInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.Clear();
			this.m_arenaBattleInfo = battleInfo;
			this.m_battleType = BattleType.ArenaAttack;
			this.m_actionOrderType = ActionOrderType.Normal;
			this.m_actionTeam = 0;
			this.m_turnMax = arenaDefendRuleInfo.TurnMax;
			this.InitRandomNumbers(randomSeed, randomSeed);
			this.InitPlayers(players);
			this.InitWinConditionStates(arenaDefendRuleInfo.m_battleWinConditionInfos);
			this.InitLoseConditionStates(arenaDefendRuleInfo.m_battleLoseConditionInfos);
			this.InitEventTriggerStates(battleInfo.m_battleEventTriggerInfos);
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			dictionary.Add(0, this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_ArenaDefenderGroupBehaviorID));
			this.m_teams[1].SetGroupBehaviorDict(dictionary);
			int behaviorId = this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_ArenaDefenderBehaviorID);
			foreach (BattleActorSetup battleActorSetup in teamSetup1.m_actors)
			{
				battleActorSetup.BehaviorId = behaviorId;
			}
			this.CreateActors(0, teamSetup0.m_actors);
			this.CreateActors(1, teamSetup1.m_actors);
			return true;
		}

		// Token: 0x06003553 RID: 13651 RVA: 0x000ECC10 File Offset: 0x000EAE10
		public bool InitPVPBattle(ConfigDataPVPBattleInfo battleInfo, BattleTeamSetup teamSetup0, BattleTeamSetup teamSetup1, BattlePlayer[] players, int randomSeed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitPVPBattleConfigDataPVPBattleInfoBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_InitPVPBattleConfigDataPVPBattleInfoBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32_hotfix.call(new object[]
				{
					this,
					battleInfo,
					teamSetup0,
					teamSetup1,
					players,
					randomSeed
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.Clear();
			this.m_pvpBattleInfo = battleInfo;
			this.m_battleType = BattleType.PVP;
			this.m_actionOrderType = ActionOrderType.PVP;
			this.m_actionTeam = 0;
			this.m_turnMax = battleInfo.TurnMax;
			this.InitRandomNumbers(randomSeed, randomSeed);
			this.InitPlayers(players);
			this.InitWinConditionStates(battleInfo.m_battleWinConditionInfos);
			this.InitLoseConditionStates(battleInfo.m_battleLoseConditionInfos);
			this.InitEventTriggerStates(battleInfo.m_battleEventTriggerInfos);
			this.CreateActors(0, teamSetup0.m_actors);
			this.CreateActors(1, teamSetup1.m_actors);
			return true;
		}

		// Token: 0x06003554 RID: 13652 RVA: 0x000ECD4C File Offset: 0x000EAF4C
		public bool InitRealTimePVPBattle(ConfigDataRealTimePVPBattleInfo battleInfo, BattleTeamSetup teamSetup0, BattleTeamSetup teamSetup1, BattlePlayer[] players, int randomSeed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitRealTimePVPBattleConfigDataRealTimePVPBattleInfoBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_InitRealTimePVPBattleConfigDataRealTimePVPBattleInfoBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32_hotfix.call(new object[]
				{
					this,
					battleInfo,
					teamSetup0,
					teamSetup1,
					players,
					randomSeed
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.Clear();
			this.m_realtimePvpBattleInfo = battleInfo;
			this.m_battleType = BattleType.RealTimePVP;
			this.m_actionOrderType = ActionOrderType.PVP;
			this.m_actionTeam = 0;
			this.m_turnMax = battleInfo.TurnMax;
			this.InitRandomNumbers(randomSeed, randomSeed);
			this.InitPlayers(players);
			this.InitWinConditionStates(battleInfo.m_battleWinConditionInfos);
			this.InitLoseConditionStates(battleInfo.m_battleLoseConditionInfos);
			this.InitEventTriggerStates(battleInfo.m_battleEventTriggerInfos);
			this.CreateActors(0, teamSetup0.m_actors);
			this.CreateActors(1, teamSetup1.m_actors);
			return true;
		}

		// Token: 0x06003555 RID: 13653 RVA: 0x000ECE88 File Offset: 0x000EB088
		private void InitRandomNumbers(int randomSeed, int armyRandomSeed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitRandomNumbersInt32Int32_hotfix != null)
			{
				this.m_InitRandomNumbersInt32Int32_hotfix.call(new object[]
				{
					this,
					randomSeed,
					armyRandomSeed
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_randomNumber.SetSeed(randomSeed);
			this.m_aiRandomNumber1.SetSeed(randomSeed * 13579);
			this.m_aiRandomNumber2.SetSeed(randomSeed * 97531);
			this.m_armyRandomNumber.SetSeed(armyRandomSeed);
		}

		// Token: 0x06003556 RID: 13654 RVA: 0x000ECF44 File Offset: 0x000EB144
		private void InitPlayers(BattlePlayer[] players)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitPlayersBattlePlayerbe_hotfix != null)
			{
				this.m_InitPlayersBattlePlayerbe_hotfix.call(new object[]
				{
					this,
					players
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (players == null || players.Length <= 0)
			{
				return;
			}
			this.m_players = new BattlePlayer[players.Length];
			Array.Copy(players, this.m_players, players.Length);
			int num = 0;
			foreach (BattlePlayer battlePlayer in players)
			{
				if (battlePlayer.PlayerLevel > num)
				{
					num = battlePlayer.PlayerLevel;
				}
			}
			this.m_maxPlayerLevelInfo = this.m_configDataLoader.GetConfigDataPlayerLevelInfo(num);
		}

		// Token: 0x06003557 RID: 13655 RVA: 0x000ED024 File Offset: 0x000EB224
		private void InitWinConditionStates(ConfigDataBattleWinConditionInfo[] winConditionInfos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitWinConditionStatesConfigDataBattleWinConditionInfobe_hotfix != null)
			{
				this.m_InitWinConditionStatesConfigDataBattleWinConditionInfobe_hotfix.call(new object[]
				{
					this,
					winConditionInfos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (winConditionInfos == null)
			{
				return;
			}
			foreach (ConfigDataBattleWinConditionInfo winConditionInfo in winConditionInfos)
			{
				BattleWinConditionState battleWinConditionState = new BattleWinConditionState();
				battleWinConditionState.m_winConditionInfo = winConditionInfo;
				this.m_winConditionStates.Add(battleWinConditionState);
			}
		}

		// Token: 0x06003558 RID: 13656 RVA: 0x000ED0D0 File Offset: 0x000EB2D0
		private void InitLoseConditionStates(ConfigDataBattleLoseConditionInfo[] loseConditionInfos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitLoseConditionStatesConfigDataBattleLoseConditionInfobe_hotfix != null)
			{
				this.m_InitLoseConditionStatesConfigDataBattleLoseConditionInfobe_hotfix.call(new object[]
				{
					this,
					loseConditionInfos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (loseConditionInfos == null)
			{
				return;
			}
			foreach (ConfigDataBattleLoseConditionInfo loseConditionInfo in loseConditionInfos)
			{
				BattleLoseConditionState battleLoseConditionState = new BattleLoseConditionState();
				battleLoseConditionState.m_loseConditionInfo = loseConditionInfo;
				this.m_loseConditionStates.Add(battleLoseConditionState);
			}
		}

		// Token: 0x06003559 RID: 13657 RVA: 0x000ED17C File Offset: 0x000EB37C
		private void InitEventTriggerStates(ConfigDataBattleEventTriggerInfo[] eventTriggerInfos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitEventTriggerStatesConfigDataBattleEventTriggerInfobe_hotfix != null)
			{
				this.m_InitEventTriggerStatesConfigDataBattleEventTriggerInfobe_hotfix.call(new object[]
				{
					this,
					eventTriggerInfos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (eventTriggerInfos == null)
			{
				return;
			}
			foreach (ConfigDataBattleEventTriggerInfo triggerInfo in eventTriggerInfos)
			{
				BattleEventTriggerState battleEventTriggerState = new BattleEventTriggerState();
				battleEventTriggerState.m_triggerInfo = triggerInfo;
				this.m_eventTriggerStates.Add(battleEventTriggerState);
			}
			foreach (ConfigDataBattleEventTriggerInfo configDataBattleEventTriggerInfo in eventTriggerInfos)
			{
				if (configDataBattleEventTriggerInfo.TriggerType == BattleEventTriggerType.BattleEventTriggerType_NotTrigger || configDataBattleEventTriggerInfo.TriggerType == BattleEventTriggerType.BattleEventTriggerType_MultiTrigger)
				{
					foreach (int num in configDataBattleEventTriggerInfo.Param1)
					{
						if (this.GetEventTriggerState(num) == null)
						{
							ConfigDataBattleEventTriggerInfo configDataBattleEventTriggerInfo2 = this.m_configDataLoader.GetConfigDataBattleEventTriggerInfo(num);
							if (configDataBattleEventTriggerInfo2 != null)
							{
								BattleEventTriggerState battleEventTriggerState2 = new BattleEventTriggerState();
								battleEventTriggerState2.m_triggerInfo = configDataBattleEventTriggerInfo2;
								this.m_eventTriggerStates.Add(battleEventTriggerState2);
							}
						}
					}
				}
			}
		}

		// Token: 0x0600355A RID: 13658 RVA: 0x000ED2F0 File Offset: 0x000EB4F0
		private void InitBattleTreasureStates(ConfigDataBattleTreasureInfo[] battleTreasureInfos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitBattleTreasureStatesConfigDataBattleTreasureInfobe_hotfix != null)
			{
				this.m_InitBattleTreasureStatesConfigDataBattleTreasureInfobe_hotfix.call(new object[]
				{
					this,
					battleTreasureInfos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (battleTreasureInfos == null)
			{
				return;
			}
			foreach (ConfigDataBattleTreasureInfo battleTreasureInfo in battleTreasureInfos)
			{
				BattleTreasureState battleTreasureState = new BattleTreasureState();
				battleTreasureState.m_battleTreasureInfo = battleTreasureInfo;
				battleTreasureState.m_isOpened = false;
				battleTreasureState.m_isGain = false;
				this.m_battleTreasureStates.Add(battleTreasureState);
			}
		}

		// Token: 0x0600355B RID: 13659 RVA: 0x000ED3A8 File Offset: 0x000EB5A8
		private void CreateActors(int team, List<BattleActorSetup> setups)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateActorsInt32List`1_hotfix != null)
			{
				this.m_CreateActorsInt32List`1_hotfix.call(new object[]
				{
					this,
					team,
					setups
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (setups == null)
			{
				return;
			}
			int num = this.m_map.Width / 2;
			foreach (BattleActorSetup battleActorSetup in setups)
			{
				int dir;
				if (battleActorSetup.Direction != 0)
				{
					dir = battleActorSetup.Direction;
				}
				else
				{
					dir = ((battleActorSetup.Position.x > num) ? -1 : 1);
				}
				BattleActor battleActor = this.m_teams[team].CreateActor();
				battleActor.Initialize(this.m_teams[team], battleActorSetup.HeroInfo, battleActorSetup.JobConnectionInfo, battleActorSetup.SoldierInfo, battleActorSetup.SkillInfos, battleActorSetup.MasterJobInfos, battleActorSetup.Equipments, battleActorSetup.ResonanceSkillInfos, battleActorSetup.FetterSkillInfos, battleActorSetup.HeroLevel, battleActorSetup.HeroStar, battleActorSetup.JobLevel, battleActorSetup.SoldierCount, battleActorSetup.Position, dir, battleActorSetup.IsNpc, battleActorSetup.ActionValue, battleActorSetup.BehaviorId, battleActorSetup.GroupId, BattleActorSourceType.Init, battleActorSetup.PlayerIndex);
				battleActor.InitializeSkin(battleActorSetup.HeroCharImageSkinResourceInfo, battleActorSetup.HeroModelSkinResourceInfo, battleActorSetup.SoldierModelSkinResourceInfo);
				battleActor.InitializeExtraPassiveSkillAndTalent(battleActorSetup.ExtraPassiveSkillInfos, battleActorSetup.ExtraTalentSkillInfo);
				battleActor.InitializeEnd(true, battleActorSetup.HeroHealthPoint, battleActorSetup.SoldierHealthPoint);
				battleActorSetup.ActorId = battleActor.Id;
			}
			this.m_teams[team].CreateGroups();
		}

		// Token: 0x0600355C RID: 13660 RVA: 0x000ED5A4 File Offset: 0x000EB7A4
		public bool InitBattleReport(ConfigDataBattleInfo battleInfo, BattleType battleType, BattleTeamSetup teamSetup0, BattleTeamSetup teamSetup1, BattlePlayer[] players, int randomSeed, int armyRandomSeed, int monsterLevel, List<BattleCommand> commands)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitBattleReportConfigDataBattleInfoBattleTypeBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32Int32Int32List`1_hotfix != null)
			{
				return Convert.ToBoolean(this.m_InitBattleReportConfigDataBattleInfoBattleTypeBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32Int32Int32List`1_hotfix.call(new object[]
				{
					this,
					battleInfo,
					battleType,
					teamSetup0,
					teamSetup1,
					players,
					randomSeed,
					armyRandomSeed,
					monsterLevel,
					commands
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (battleInfo == null || teamSetup0 == null || teamSetup1 == null || commands == null)
			{
				return false;
			}
			if (!this.InitBattle(battleInfo, battleType, teamSetup0, teamSetup1, players, randomSeed, armyRandomSeed, monsterLevel))
			{
				return false;
			}
			foreach (BattleCommand cmd in commands)
			{
				this.AddBattleCommand(cmd);
			}
			return true;
		}

		// Token: 0x0600355D RID: 13661 RVA: 0x000ED724 File Offset: 0x000EB924
		public bool InitArenaBattleReport(ConfigDataArenaBattleInfo battleInfo, BattleTeamSetup teamSetup0, BattleTeamSetup teamSetup1, BattlePlayer[] players, int randomSeed, ConfigDataArenaDefendRuleInfo arenaDefendRuleInfo, List<BattleCommand> commands)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitArenaBattleReportConfigDataArenaBattleInfoBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32ConfigDataArenaDefendRuleInfoList`1_hotfix != null)
			{
				return Convert.ToBoolean(this.m_InitArenaBattleReportConfigDataArenaBattleInfoBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32ConfigDataArenaDefendRuleInfoList`1_hotfix.call(new object[]
				{
					this,
					battleInfo,
					teamSetup0,
					teamSetup1,
					players,
					randomSeed,
					arenaDefendRuleInfo,
					commands
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (battleInfo == null || teamSetup0 == null || teamSetup1 == null || commands == null)
			{
				return false;
			}
			if (!this.InitArenaBattle(battleInfo, teamSetup0, teamSetup1, players, randomSeed, arenaDefendRuleInfo))
			{
				return false;
			}
			foreach (BattleCommand cmd in commands)
			{
				this.AddBattleCommand(cmd);
			}
			return true;
		}

		// Token: 0x0600355E RID: 13662 RVA: 0x000ED880 File Offset: 0x000EBA80
		public bool InitPVPBattleReport(ConfigDataPVPBattleInfo battleInfo, BattleTeamSetup teamSetup0, BattleTeamSetup teamSetup1, BattlePlayer[] players, int randomSeed, List<BattleCommand> commands)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitPVPBattleReportConfigDataPVPBattleInfoBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32List`1_hotfix != null)
			{
				return Convert.ToBoolean(this.m_InitPVPBattleReportConfigDataPVPBattleInfoBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32List`1_hotfix.call(new object[]
				{
					this,
					battleInfo,
					teamSetup0,
					teamSetup1,
					players,
					randomSeed,
					commands
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (battleInfo == null || teamSetup0 == null || teamSetup1 == null || commands == null)
			{
				return false;
			}
			if (!this.InitPVPBattle(battleInfo, teamSetup0, teamSetup1, players, randomSeed))
			{
				return false;
			}
			foreach (BattleCommand cmd in commands)
			{
				this.AddBattleCommand(cmd);
			}
			return true;
		}

		// Token: 0x0600355F RID: 13663 RVA: 0x000ED9C8 File Offset: 0x000EBBC8
		public bool InitRealTimePVPBattleReport(ConfigDataRealTimePVPBattleInfo battleInfo, BattleTeamSetup teamSetup0, BattleTeamSetup teamSetup1, BattlePlayer[] players, int randomSeed, List<BattleCommand> commands)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitRealTimePVPBattleReportConfigDataRealTimePVPBattleInfoBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32List`1_hotfix != null)
			{
				return Convert.ToBoolean(this.m_InitRealTimePVPBattleReportConfigDataRealTimePVPBattleInfoBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32List`1_hotfix.call(new object[]
				{
					this,
					battleInfo,
					teamSetup0,
					teamSetup1,
					players,
					randomSeed,
					commands
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (battleInfo == null || teamSetup0 == null || teamSetup1 == null || commands == null)
			{
				return false;
			}
			if (!this.InitRealTimePVPBattle(battleInfo, teamSetup0, teamSetup1, players, randomSeed))
			{
				return false;
			}
			foreach (BattleCommand cmd in commands)
			{
				this.AddBattleCommand(cmd);
			}
			return true;
		}

		// Token: 0x06003560 RID: 13664 RVA: 0x000EDB10 File Offset: 0x000EBD10
		public void InitStarAndAchievement(int starTurnMax, int starDeadMax, List<ConfigDataBattleAchievementRelatedInfo> achievementRelatedInfos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitStarAndAchievementInt32Int32List`1_hotfix != null)
			{
				this.m_InitStarAndAchievementInt32Int32List`1_hotfix.call(new object[]
				{
					this,
					starTurnMax,
					starDeadMax,
					achievementRelatedInfos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_achievementStates.Clear();
			if (achievementRelatedInfos != null)
			{
				foreach (ConfigDataBattleAchievementRelatedInfo configDataBattleAchievementRelatedInfo in achievementRelatedInfos)
				{
					BattleAchievementState battleAchievementState = new BattleAchievementState();
					battleAchievementState.m_achievementRelatedInfo = configDataBattleAchievementRelatedInfo;
					if (configDataBattleAchievementRelatedInfo.m_achievementInfo.TurnCount > 0)
					{
						battleAchievementState.m_turnCount = configDataBattleAchievementRelatedInfo.m_achievementInfo.TurnCount;
					}
					else
					{
						battleAchievementState.m_turnCount = this.m_turnMax;
					}
					this.m_achievementStates.Add(battleAchievementState);
				}
			}
			this.m_starTurnMax = starTurnMax;
			this.m_starDeadMax = starDeadMax;
		}

		// Token: 0x06003561 RID: 13665 RVA: 0x000EDC50 File Offset: 0x000EBE50
		public void InitGainBattleTreasures(List<int> gainBattleTreasureIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitGainBattleTreasuresList`1_hotfix != null)
			{
				this.m_InitGainBattleTreasuresList`1_hotfix.call(new object[]
				{
					this,
					gainBattleTreasureIds
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (gainBattleTreasureIds != null)
			{
				foreach (BattleTreasureState battleTreasureState in this.m_battleTreasureStates)
				{
					battleTreasureState.m_isOpened = gainBattleTreasureIds.Contains(battleTreasureState.m_battleTreasureInfo.ID);
					battleTreasureState.m_isGain = false;
				}
			}
		}

		// Token: 0x06003562 RID: 13666 RVA: 0x000EDD2C File Offset: 0x000EBF2C
		private void ExecuteBattlePerforms(ConfigDataBattlePerformInfo performInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteBattlePerformsConfigDataBattlePerformInfo_hotfix != null)
			{
				this.m_ExecuteBattlePerformsConfigDataBattlePerformInfo_hotfix.call(new object[]
				{
					this,
					performInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (performInfo == null)
			{
				return;
			}
			this.m_battleListener.OnStartBattlePerform(performInfo);
			while (performInfo != null)
			{
				this.m_step++;
				this.ExecuteBattlePerform(performInfo);
				performInfo = performInfo.m_nextPerformInfo;
				if (this.m_state == BattleState.Combat)
				{
					this.m_isPerformCombat = true;
					this.m_afterComatPerform = performInfo;
					break;
				}
			}
			this.m_battleListener.OnStopBattlePerform();
		}

		// Token: 0x06003563 RID: 13667 RVA: 0x000EDE04 File Offset: 0x000EC004
		private void ExecuteAfterCombatSteps()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteAfterCombatSteps_hotfix != null)
			{
				this.m_ExecuteAfterCombatSteps_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isAfterCombatNextStep)
			{
				this.m_isAfterCombatNextStep = false;
				this.NextStep();
			}
			else if (this.m_isAfterCombatNextStepActorActive)
			{
				this.m_isAfterCombatNextStepActorActive = false;
				this.NextStepActorActive();
			}
		}

		// Token: 0x06003564 RID: 13668 RVA: 0x000EDE9C File Offset: 0x000EC09C
		private void ExecuteBattlePerform(ConfigDataBattlePerformInfo performInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteBattlePerformConfigDataBattlePerformInfo_hotfix != null)
			{
				this.m_ExecuteBattlePerformConfigDataBattlePerformInfo_hotfix.call(new object[]
				{
					this,
					performInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (performInfo == null)
			{
				return;
			}
			if (performInfo.PerformType == BattlePerformType.BattlePerformType_Dialog)
			{
				this.ExecuteBattlePerform_Dialog(performInfo);
			}
			else if (performInfo.PerformType == BattlePerformType.BattlePerformType_PlayMusic)
			{
				this.ExecuteBattlePerform_PlayMusic(performInfo);
			}
			else if (performInfo.PerformType == BattlePerformType.BattlePerformType_PlaySound)
			{
				this.ExecuteBattlePerform_PlaySound(performInfo);
			}
			else if (performInfo.PerformType == BattlePerformType.BattlePerformType_PlayFx)
			{
				this.ExecuteBattlePerform_PlayFx(performInfo);
			}
			else if (performInfo.PerformType == BattlePerformType.BattlePerformType_PlayActorFx)
			{
				this.ExecuteBattlePerform_PlayActorFx(performInfo);
			}
			else if (performInfo.PerformType == BattlePerformType.BattlePerformType_ChangeTerrain)
			{
				this.ExecuteBattlePerform_ChangeTerrain(performInfo);
			}
			else if (performInfo.PerformType == BattlePerformType.BattlePerformType_CameraFocusPosition)
			{
				this.ExecuteBattlePerform_CameraFocusPosition(performInfo);
			}
			else if (performInfo.PerformType == BattlePerformType.BattlePerformType_CameraFocusActor)
			{
				this.ExecuteBattlePerform_CameraFocusActor(performInfo);
			}
			else if (performInfo.PerformType == BattlePerformType.BattlePerformType_CreateActor)
			{
				this.ExecuteBattlePerform_CreateActor(performInfo);
			}
			else if (performInfo.PerformType == BattlePerformType.BattlePerformType_CreateActorNear)
			{
				this.ExecuteBattlePerform_CreateActorNear(performInfo);
			}
			else if (performInfo.PerformType == BattlePerformType.BattlePerformType_RemoveActor)
			{
				this.ExecuteBattlePerform_RemoveActor(performInfo);
			}
			else if (performInfo.PerformType == BattlePerformType.BattlePerformType_ActorMove)
			{
				this.ExecuteBattlePerform_ActorMove(performInfo);
			}
			else if (performInfo.PerformType == BattlePerformType.BattlePerformType_ActorMoveNear)
			{
				this.ExecuteBattlePerform_ActorMoveNear(performInfo);
			}
			else if (performInfo.PerformType == BattlePerformType.BattlePerformType_ActorAttack)
			{
				this.ExecuteBattlePerform_ActorAttack(performInfo);
			}
			else if (performInfo.PerformType == BattlePerformType.BattlePerformType_ActorSkill)
			{
				this.ExecuteBattlePerform_ActorSkill(performInfo);
			}
			else if (performInfo.PerformType == BattlePerformType.BattlePerformType_ActorDir)
			{
				this.ExecuteBattlePerform_ActorDir(performInfo);
			}
			else if (performInfo.PerformType == BattlePerformType.BattlePerformType_ActorAnimation)
			{
				this.ExecuteBattlePerform_ActorAnimation(performInfo);
			}
			else if (performInfo.PerformType == BattlePerformType.BattlePerformType_ActorIdle)
			{
				this.ExecuteBattlePerform_ActorIdle(performInfo);
			}
			else if (performInfo.PerformType == BattlePerformType.BattlePerformType_WaitTime)
			{
				this.ExecuteBattlePerform_WaitTime(performInfo);
			}
			else if (performInfo.PerformType == BattlePerformType.BattlePerformType_StopBattle)
			{
				this.ExecuteBattlePerform_StopBattle(performInfo);
			}
		}

		// Token: 0x06003565 RID: 13669 RVA: 0x000EE0FC File Offset: 0x000EC2FC
		private void ExecuteBattlePerform_Dialog(ConfigDataBattlePerformInfo performInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteBattlePerform_DialogConfigDataBattlePerformInfo_hotfix != null)
			{
				this.m_ExecuteBattlePerform_DialogConfigDataBattlePerformInfo_hotfix.call(new object[]
				{
					this,
					performInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataBattleDialogInfo configDataBattleDialogInfo = this.m_configDataLoader.GetConfigDataBattleDialogInfo(performInfo.Param1);
			if (configDataBattleDialogInfo != null)
			{
				this.m_battleListener.OnStartBattleDialog(configDataBattleDialogInfo);
			}
		}

		// Token: 0x06003566 RID: 13670 RVA: 0x000EE190 File Offset: 0x000EC390
		private void ExecuteBattlePerform_PlayMusic(ConfigDataBattlePerformInfo performInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteBattlePerform_PlayMusicConfigDataBattlePerformInfo_hotfix != null)
			{
				this.m_ExecuteBattlePerform_PlayMusicConfigDataBattlePerformInfo_hotfix.call(new object[]
				{
					this,
					performInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleListener.OnPlayMusic(performInfo.Param5);
		}

		// Token: 0x06003567 RID: 13671 RVA: 0x000EE214 File Offset: 0x000EC414
		private void ExecuteBattlePerform_PlaySound(ConfigDataBattlePerformInfo performInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteBattlePerform_PlaySoundConfigDataBattlePerformInfo_hotfix != null)
			{
				this.m_ExecuteBattlePerform_PlaySoundConfigDataBattlePerformInfo_hotfix.call(new object[]
				{
					this,
					performInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleListener.OnPlaySound(performInfo.Param5);
		}

		// Token: 0x06003568 RID: 13672 RVA: 0x000EE298 File Offset: 0x000EC498
		private void ExecuteBattlePerform_PlayFx(ConfigDataBattlePerformInfo performInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteBattlePerform_PlayFxConfigDataBattlePerformInfo_hotfix != null)
			{
				this.m_ExecuteBattlePerform_PlayFxConfigDataBattlePerformInfo_hotfix.call(new object[]
				{
					this,
					performInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (performInfo.Param3.Count > 0)
			{
				GridPosition p = new GridPosition(performInfo.Param3[0].X, performInfo.Param3[0].Y);
				this.m_battleListener.OnPlayFx(performInfo.Param5, p);
			}
			else
			{
				BattleActor aliveActorByHeroId = this.GetAliveActorByHeroId(performInfo.Param1);
				if (aliveActorByHeroId != null)
				{
					this.m_battleListener.OnPlayFx(performInfo.Param5, aliveActorByHeroId.Position);
				}
			}
		}

		// Token: 0x06003569 RID: 13673 RVA: 0x000EE384 File Offset: 0x000EC584
		private void ExecuteBattlePerform_PlayActorFx(ConfigDataBattlePerformInfo performInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteBattlePerform_PlayActorFxConfigDataBattlePerformInfo_hotfix != null)
			{
				this.m_ExecuteBattlePerform_PlayActorFxConfigDataBattlePerformInfo_hotfix.call(new object[]
				{
					this,
					performInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleActor aliveActorByHeroId = this.GetAliveActorByHeroId(performInfo.Param1);
			if (aliveActorByHeroId != null)
			{
				this.m_battleListener.OnBattleActorPlayFx(aliveActorByHeroId, performInfo.Param5, performInfo.Param2);
			}
		}

		// Token: 0x0600356A RID: 13674 RVA: 0x000EE420 File Offset: 0x000EC620
		private void ExecuteBattlePerform_ChangeTerrain(ConfigDataBattlePerformInfo performInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteBattlePerform_ChangeTerrainConfigDataBattlePerformInfo_hotfix != null)
			{
				this.m_ExecuteBattlePerform_ChangeTerrainConfigDataBattlePerformInfo_hotfix.call(new object[]
				{
					this,
					performInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataTerrainInfo configDataTerrainInfo = this.m_configDataLoader.GetConfigDataTerrainInfo(performInfo.Param1);
			if (configDataTerrainInfo != null)
			{
				foreach (ParamPosition paramPosition in performInfo.Param3)
				{
					GridPosition p = new GridPosition(paramPosition.X, paramPosition.Y);
					this.ChangeMapTerrain(p, configDataTerrainInfo);
				}
			}
		}

		// Token: 0x0600356B RID: 13675 RVA: 0x000EE50C File Offset: 0x000EC70C
		private void ExecuteBattlePerform_CameraFocusPosition(ConfigDataBattlePerformInfo performInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteBattlePerform_CameraFocusPositionConfigDataBattlePerformInfo_hotfix != null)
			{
				this.m_ExecuteBattlePerform_CameraFocusPositionConfigDataBattlePerformInfo_hotfix.call(new object[]
				{
					this,
					performInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (performInfo.Param3.Count > 0)
			{
				GridPosition p = new GridPosition(performInfo.Param3[0].X, performInfo.Param3[0].Y);
				this.m_battleListener.OnCameraFocus(p);
			}
		}

		// Token: 0x0600356C RID: 13676 RVA: 0x000EE5C4 File Offset: 0x000EC7C4
		private void ExecuteBattlePerform_CameraFocusActor(ConfigDataBattlePerformInfo performInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteBattlePerform_CameraFocusActorConfigDataBattlePerformInfo_hotfix != null)
			{
				this.m_ExecuteBattlePerform_CameraFocusActorConfigDataBattlePerformInfo_hotfix.call(new object[]
				{
					this,
					performInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleActor aliveActorByHeroId = this.GetAliveActorByHeroId(performInfo.Param1);
			if (aliveActorByHeroId != null)
			{
				this.m_battleListener.OnBattleActorCameraFocus(aliveActorByHeroId);
			}
		}

		// Token: 0x0600356D RID: 13677 RVA: 0x000EE654 File Offset: 0x000EC854
		private void ExecuteBattlePerform_CreateActor(ConfigDataBattlePerformInfo performInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteBattlePerform_CreateActorConfigDataBattlePerformInfo_hotfix != null)
			{
				this.m_ExecuteBattlePerform_CreateActorConfigDataBattlePerformInfo_hotfix.call(new object[]
				{
					this,
					performInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (performInfo.Param3.Count > 0 && performInfo.Param4.Count > 0)
			{
				int team = 0;
				bool isNpc = false;
				if (performInfo.Param1 == 1)
				{
					team = 0;
				}
				else if (performInfo.Param1 == 2)
				{
					team = 1;
				}
				else if (performInfo.Param1 == 3)
				{
					team = 0;
					isNpc = true;
				}
				int param = performInfo.Param2;
				ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(param);
				MoveType moveType = BattleActor.ComputeDefaultMoveType(configDataHeroInfo);
				GridPosition gridPosition = this.FindEmptyNearPosition(new GridPosition(performInfo.Param3[0].X, performInfo.Param3[0].Y), moveType);
				if (gridPosition != GridPosition.Null)
				{
					int heroLevel = performInfo.Param4[0];
					int effectType = 0;
					if (performInfo.Param4.Count > 1)
					{
						effectType = performInfo.Param4[1];
					}
					int behaviorId = 0;
					if (performInfo.Param4.Count > 2)
					{
						behaviorId = performInfo.Param4[2];
					}
					int groupId = 0;
					int dir = 0;
					if (performInfo.Param6.Count > 0)
					{
						dir = performInfo.Param6[0];
					}
					this.CreateEventActor(gridPosition, dir, team, isNpc, param, heroLevel, behaviorId, groupId, effectType, performInfo.Param5, BattleActorSourceType.Perform);
				}
			}
		}

		// Token: 0x0600356E RID: 13678 RVA: 0x000EE814 File Offset: 0x000ECA14
		private void ExecuteBattlePerform_CreateActorNear(ConfigDataBattlePerformInfo performInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteBattlePerform_CreateActorNearConfigDataBattlePerformInfo_hotfix != null)
			{
				this.m_ExecuteBattlePerform_CreateActorNearConfigDataBattlePerformInfo_hotfix.call(new object[]
				{
					this,
					performInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (performInfo.Param3.Count > 0 && performInfo.Param4.Count > 0)
			{
				int team = 0;
				bool isNpc = false;
				if (performInfo.Param1 == 1)
				{
					team = 0;
				}
				else if (performInfo.Param1 == 2)
				{
					team = 1;
				}
				else if (performInfo.Param1 == 3)
				{
					team = 0;
					isNpc = true;
				}
				int x = performInfo.Param3[0].X;
				BattleActor aliveActorByHeroId = this.GetAliveActorByHeroId(x);
				if (aliveActorByHeroId != null)
				{
					int y = performInfo.Param3[0].Y;
					GridPosition gridPosition = this.FindEmptyFixedDistancePosition(aliveActorByHeroId.Position, y);
					if (gridPosition != GridPosition.Null)
					{
						int heroLevel = performInfo.Param4[0];
						int effectType = 0;
						if (performInfo.Param4.Count > 1)
						{
							effectType = performInfo.Param4[1];
						}
						int behaviorId = 0;
						if (performInfo.Param4.Count > 2)
						{
							behaviorId = performInfo.Param4[2];
						}
						int groupId = 0;
						int dir = 0;
						if (performInfo.Param6.Count > 0)
						{
							dir = performInfo.Param6[0];
						}
						this.CreateEventActor(gridPosition, dir, team, isNpc, performInfo.Param2, heroLevel, behaviorId, groupId, effectType, performInfo.Param5, BattleActorSourceType.Perform);
					}
				}
			}
		}

		// Token: 0x0600356F RID: 13679 RVA: 0x000EE9D0 File Offset: 0x000ECBD0
		private void ExecuteBattlePerform_RemoveActor(ConfigDataBattlePerformInfo performInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteBattlePerform_RemoveActorConfigDataBattlePerformInfo_hotfix != null)
			{
				this.m_ExecuteBattlePerform_RemoveActorConfigDataBattlePerformInfo_hotfix.call(new object[]
				{
					this,
					performInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleActor aliveActorByHeroId = this.GetAliveActorByHeroId(performInfo.Param1);
			if (aliveActorByHeroId != null)
			{
				aliveActorByHeroId.Retreat(performInfo.Param2, performInfo.Param5, true);
			}
		}

		// Token: 0x06003570 RID: 13680 RVA: 0x000EEA68 File Offset: 0x000ECC68
		private void ExecuteBattlePerform_ActorMove(ConfigDataBattlePerformInfo performInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteBattlePerform_ActorMoveConfigDataBattlePerformInfo_hotfix != null)
			{
				this.m_ExecuteBattlePerform_ActorMoveConfigDataBattlePerformInfo_hotfix.call(new object[]
				{
					this,
					performInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleActor aliveActorByHeroId = this.GetAliveActorByHeroId(performInfo.Param1);
			if (aliveActorByHeroId != null && performInfo.Param3.Count > 0)
			{
				GridPosition p = new GridPosition(performInfo.Param3[0].X, performInfo.Param3[0].Y);
				bool cameraFollow = performInfo.Param2 == 0;
				aliveActorByHeroId.ExecutePerformMoveCommand(p, cameraFollow);
			}
		}

		// Token: 0x06003571 RID: 13681 RVA: 0x000EEB38 File Offset: 0x000ECD38
		private void ExecuteBattlePerform_ActorMoveNear(ConfigDataBattlePerformInfo performInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteBattlePerform_ActorMoveNearConfigDataBattlePerformInfo_hotfix != null)
			{
				this.m_ExecuteBattlePerform_ActorMoveNearConfigDataBattlePerformInfo_hotfix.call(new object[]
				{
					this,
					performInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleActor aliveActorByHeroId = this.GetAliveActorByHeroId(performInfo.Param1);
			if (aliveActorByHeroId != null && performInfo.Param3.Count > 0)
			{
				int x = performInfo.Param3[0].X;
				BattleActor aliveActorByHeroId2 = this.GetAliveActorByHeroId(x);
				if (aliveActorByHeroId2 != null)
				{
					int y = performInfo.Param3[0].Y;
					GridPosition gridPosition = this.FindEmptyFixedDistancePosition(aliveActorByHeroId.Position, aliveActorByHeroId2.Position, y);
					if (gridPosition != GridPosition.Null)
					{
						bool cameraFollow = performInfo.Param2 == 0;
						aliveActorByHeroId.ExecutePerformMoveCommand(gridPosition, cameraFollow);
					}
				}
			}
		}

		// Token: 0x06003572 RID: 13682 RVA: 0x000EEC3C File Offset: 0x000ECE3C
		private void ExecuteBattlePerform_ActorAttack(ConfigDataBattlePerformInfo performInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteBattlePerform_ActorAttackConfigDataBattlePerformInfo_hotfix != null)
			{
				this.m_ExecuteBattlePerform_ActorAttackConfigDataBattlePerformInfo_hotfix.call(new object[]
				{
					this,
					performInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleActor aliveActorByHeroId = this.GetAliveActorByHeroId(performInfo.Param1);
			BattleActor aliveActorByHeroId2 = this.GetAliveActorByHeroId(performInfo.Param2);
			if (aliveActorByHeroId != null && aliveActorByHeroId2 != null)
			{
				aliveActorByHeroId.ExecuteCombatCommand(aliveActorByHeroId2, null, true);
			}
		}

		// Token: 0x06003573 RID: 13683 RVA: 0x000EECDC File Offset: 0x000ECEDC
		private void ExecuteBattlePerform_ActorSkill(ConfigDataBattlePerformInfo performInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteBattlePerform_ActorSkillConfigDataBattlePerformInfo_hotfix != null)
			{
				this.m_ExecuteBattlePerform_ActorSkillConfigDataBattlePerformInfo_hotfix.call(new object[]
				{
					this,
					performInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleActor aliveActorByHeroId = this.GetAliveActorByHeroId(performInfo.Param1);
			if (aliveActorByHeroId != null && performInfo.Param4.Count > 0)
			{
				GridPosition gridPosition = GridPosition.Null;
				BattleActor aliveActorByHeroId2 = this.GetAliveActorByHeroId(performInfo.Param2);
				if (aliveActorByHeroId2 != null)
				{
					gridPosition = aliveActorByHeroId2.Position;
				}
				else if (performInfo.Param3.Count > 0)
				{
					gridPosition.Set(performInfo.Param3[0].X, performInfo.Param3[0].Y);
				}
				ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(performInfo.Param4[0]);
				if (configDataSkillInfo != null)
				{
					aliveActorByHeroId.ExecutePerformSkillCommand(configDataSkillInfo, gridPosition, gridPosition);
				}
			}
		}

		// Token: 0x06003574 RID: 13684 RVA: 0x000EEDF8 File Offset: 0x000ECFF8
		private void ExecuteBattlePerform_ActorDir(ConfigDataBattlePerformInfo performInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteBattlePerform_ActorDirConfigDataBattlePerformInfo_hotfix != null)
			{
				this.m_ExecuteBattlePerform_ActorDirConfigDataBattlePerformInfo_hotfix.call(new object[]
				{
					this,
					performInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleActor aliveActorByHeroId = this.GetAliveActorByHeroId(performInfo.Param1);
			if (aliveActorByHeroId != null)
			{
				aliveActorByHeroId.SetDirection(performInfo.Param2);
				this.m_battleListener.OnBattleActorSetDir(aliveActorByHeroId, performInfo.Param2);
			}
		}

		// Token: 0x06003575 RID: 13685 RVA: 0x000EEE9C File Offset: 0x000ED09C
		private void ExecuteBattlePerform_ActorAnimation(ConfigDataBattlePerformInfo performInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteBattlePerform_ActorAnimationConfigDataBattlePerformInfo_hotfix != null)
			{
				this.m_ExecuteBattlePerform_ActorAnimationConfigDataBattlePerformInfo_hotfix.call(new object[]
				{
					this,
					performInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleActor aliveActorByHeroId = this.GetAliveActorByHeroId(performInfo.Param1);
			if (aliveActorByHeroId != null)
			{
				this.m_battleListener.OnBattleActorPlayAnimation(aliveActorByHeroId, performInfo.Param5, performInfo.Param2);
			}
		}

		// Token: 0x06003576 RID: 13686 RVA: 0x000EEF38 File Offset: 0x000ED138
		private void ExecuteBattlePerform_ActorIdle(ConfigDataBattlePerformInfo performInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteBattlePerform_ActorIdleConfigDataBattlePerformInfo_hotfix != null)
			{
				this.m_ExecuteBattlePerform_ActorIdleConfigDataBattlePerformInfo_hotfix.call(new object[]
				{
					this,
					performInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleActor aliveActorByHeroId = this.GetAliveActorByHeroId(performInfo.Param1);
			if (aliveActorByHeroId != null)
			{
				this.m_battleListener.OnBattleActorChangeIdleAnimation(aliveActorByHeroId, performInfo.Param5);
			}
		}

		// Token: 0x06003577 RID: 13687 RVA: 0x000EEFD0 File Offset: 0x000ED1D0
		private void ExecuteBattlePerform_WaitTime(ConfigDataBattlePerformInfo performInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteBattlePerform_WaitTimeConfigDataBattlePerformInfo_hotfix != null)
			{
				this.m_ExecuteBattlePerform_WaitTimeConfigDataBattlePerformInfo_hotfix.call(new object[]
				{
					this,
					performInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleListener.OnWaitTime(performInfo.Param1);
		}

		// Token: 0x06003578 RID: 13688 RVA: 0x000EF054 File Offset: 0x000ED254
		private void ExecuteBattlePerform_StopBattle(ConfigDataBattlePerformInfo performInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteBattlePerform_StopBattleConfigDataBattlePerformInfo_hotfix != null)
			{
				this.m_ExecuteBattlePerform_StopBattleConfigDataBattlePerformInfo_hotfix.call(new object[]
				{
					this,
					performInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.Stop(true);
		}

		// Token: 0x06003579 RID: 13689 RVA: 0x000EF0CC File Offset: 0x000ED2CC
		private void CheckBattleTreasureOnActorMove(BattleActor actor)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckBattleTreasureOnActorMoveBattleActor_hotfix != null)
			{
				this.m_CheckBattleTreasureOnActorMoveBattleActor_hotfix.call(new object[]
				{
					this,
					actor
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (actor.TeamNumber != 0 || actor.IsAINpc())
			{
				return;
			}
			GridPosition position = actor.Position;
			foreach (BattleTreasureState battleTreasureState in this.m_battleTreasureStates)
			{
				if (!battleTreasureState.m_isOpened && !battleTreasureState.m_isGain)
				{
					foreach (ParamPosition paramPosition in battleTreasureState.m_battleTreasureInfo.TriggerPositions)
					{
						if (paramPosition.X == position.x && paramPosition.Y == position.y)
						{
							this.ChangeBattleTeasureStatus(battleTreasureState, actor);
							this.m_battleListener.OnBattleActorGainBattleTreasure(actor, battleTreasureState.m_battleTreasureInfo);
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600357A RID: 13690 RVA: 0x000EF24C File Offset: 0x000ED44C
		private void ChangeBattleTeasureStatus(BattleTreasureState state, BattleActor actor)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ChangeBattleTeasureStatusBattleTreasureStateBattleActor_hotfix != null)
			{
				this.m_ChangeBattleTeasureStatusBattleTreasureStateBattleActor_hotfix.call(new object[]
				{
					this,
					state,
					actor
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsEnableDebugLog())
			{
				DebugUtility.Log(string.Format("BattleBase.ChangeBattleTeasureStatus(), battleTreasureId {0}, actorId {1}", state.m_battleTreasureInfo.ID, actor.Id));
			}
			state.m_isOpened = (state.m_isGain = true);
		}

		// Token: 0x0600357B RID: 13691 RVA: 0x000EF314 File Offset: 0x000ED514
		public bool IsGainBattleTreasure(int treasureId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsGainBattleTreasureInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsGainBattleTreasureInt32_hotfix.call(new object[]
				{
					this,
					treasureId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleTreasureState battleTreasureState in this.m_battleTreasureStates)
			{
				if (battleTreasureState.m_battleTreasureInfo.ID == treasureId && battleTreasureState.m_isGain)
				{
					return true;
				}
			}
			return true;
		}

		// Token: 0x0600357C RID: 13692 RVA: 0x000EF400 File Offset: 0x000ED600
		public List<int> GetGainBattleTreasures()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetGainBattleTreasures_hotfix != null)
			{
				return (List<int>)this.m_GetGainBattleTreasures_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<int> list = new List<int>();
			foreach (BattleTreasureState battleTreasureState in this.m_battleTreasureStates)
			{
				if (battleTreasureState.m_isGain)
				{
					list.Add(battleTreasureState.m_battleTreasureInfo.ID);
				}
			}
			return list;
		}

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x0600357D RID: 13693 RVA: 0x000EF4D8 File Offset: 0x000ED6D8
		// (set) Token: 0x0600357E RID: 13694 RVA: 0x000EF4F8 File Offset: 0x000ED6F8
		[DoNotToLua]
		public BattleBase.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleBase.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600357F RID: 13695 RVA: 0x000EF504 File Offset: 0x000ED704
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
					this.m_ctorIConfigDataLoaderIBattleListener_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_Dispose_hotfix = (luaObj.RawGet("Dispose") as LuaFunction);
					this.m_SetWinForCheat_hotfix = (luaObj.RawGet("SetWinForCheat") as LuaFunction);
					this.m_Clear_hotfix = (luaObj.RawGet("Clear") as LuaFunction);
					this.m_GetStarTurnMax_hotfix = (luaObj.RawGet("GetStarTurnMax") as LuaFunction);
					this.m_GetStarDeadMax_hotfix = (luaObj.RawGet("GetStarDeadMax") as LuaFunction);
					this.m_IsPerformOnlyBattle_hotfix = (luaObj.RawGet("IsPerformOnlyBattle") as LuaFunction);
					this.m_Start_hotfix = (luaObj.RawGet("Start") as LuaFunction);
					this.m_StopBoolean_hotfix = (luaObj.RawGet("Stop") as LuaFunction);
					this.m_FirstStepBoolean_hotfix = (luaObj.RawGet("FirstStep") as LuaFunction);
					this.m_NextStep_hotfix = (luaObj.RawGet("NextStep") as LuaFunction);
					this.m_NextStep_NormalBattleActor_hotfix = (luaObj.RawGet("NextStep_Normal") as LuaFunction);
					this.m_NextStep_PvpBattleActor_hotfix = (luaObj.RawGet("NextStep_Pvp") as LuaFunction);
					this.m_NextStepActorActive_hotfix = (luaObj.RawGet("NextStepActorActive") as LuaFunction);
					this.m_NextTurn_hotfix = (luaObj.RawGet("NextTurn") as LuaFunction);
					this.m_GetDefaultActionActorInt32_hotfix = (luaObj.RawGet("GetDefaultActionActor") as LuaFunction);
					this.m_HasNotActionFinishedActor_hotfix = (luaObj.RawGet("HasNotActionFinishedActor") as LuaFunction);
					this.m_GetActionTeam_hotfix = (luaObj.RawGet("GetActionTeam") as LuaFunction);
					this.m_GetActionActor_hotfix = (luaObj.RawGet("GetActionActor") as LuaFunction);
					this.m_ChangeActionActorBattleActor_hotfix = (luaObj.RawGet("ChangeActionActor") as LuaFunction);
					this.m_Tick_hotfix = (luaObj.RawGet("Tick") as LuaFunction);
					this.m_TickGraphicSingle_hotfix = (luaObj.RawGet("TickGraphic") as LuaFunction);
					this.m_Draw_hotfix = (luaObj.RawGet("Draw") as LuaFunction);
					this.m_ChangeMapTerrainGridPositionConfigDataTerrainInfo_hotfix = (luaObj.RawGet("ChangeMapTerrain") as LuaFunction);
					this.m_GetTeamInt32_hotfix = (luaObj.RawGet("GetTeam") as LuaFunction);
					this.m_GetBattlePlayerInt32_hotfix = (luaObj.RawGet("GetBattlePlayer") as LuaFunction);
					this.m_GetActorByIdInt32_hotfix = (luaObj.RawGet("GetActorById") as LuaFunction);
					this.m_GetActorByHeroIdInt32_hotfix = (luaObj.RawGet("GetActorByHeroId") as LuaFunction);
					this.m_GetAliveActorByHeroIdInt32_hotfix = (luaObj.RawGet("GetAliveActorByHeroId") as LuaFunction);
					this.m_GetAliveActorsByHeroIdsAndGroupIdsList`1List`1List`1_hotfix = (luaObj.RawGet("GetAliveActorsByHeroIdsAndGroupIds") as LuaFunction);
					this.m_GetNextEntityId_hotfix = (luaObj.RawGet("GetNextEntityId") as LuaFunction);
					this.m_CheckOnActorMoveBattleActor_hotfix = (luaObj.RawGet("CheckOnActorMove") as LuaFunction);
					this.m_CheckOnActorDieBattleActor_hotfix = (luaObj.RawGet("CheckOnActorDie") as LuaFunction);
					this.m_OnActorDieBattleActor_hotfix = (luaObj.RawGet("OnActorDie") as LuaFunction);
					this.m_OnActorRetreatBattleActorInt32StringBoolean_hotfix = (luaObj.RawGet("OnActorRetreat") as LuaFunction);
					this.m_OnActorChangeTeamBattleActor_hotfix = (luaObj.RawGet("OnActorChangeTeam") as LuaFunction);
					this.m_IsPlay_hotfix = (luaObj.RawGet("IsPlay") as LuaFunction);
					this.m_IsGiveupBattle_hotfix = (luaObj.RawGet("IsGiveupBattle") as LuaFunction);
					this.m_GetGiveupBattlePlayerIndex_hotfix = (luaObj.RawGet("GetGiveupBattlePlayerIndex") as LuaFunction);
					this.m_AllocateTempIntList_hotfix = (luaObj.RawGet("AllocateTempIntList") as LuaFunction);
					this.m_FreeTempIntListList`1_hotfix = (luaObj.RawGet("FreeTempIntList") as LuaFunction);
					this.m_AllocateTempGridPositionList_hotfix = (luaObj.RawGet("AllocateTempGridPositionList") as LuaFunction);
					this.m_FreeTempGridPositionListList`1_hotfix = (luaObj.RawGet("FreeTempGridPositionList") as LuaFunction);
					this.m_AllocateTempActorList_hotfix = (luaObj.RawGet("AllocateTempActorList") as LuaFunction);
					this.m_FreeTempActorListList`1_hotfix = (luaObj.RawGet("FreeTempActorList") as LuaFunction);
					this.m_AllocateTempBuffList_hotfix = (luaObj.RawGet("AllocateTempBuffList") as LuaFunction);
					this.m_FreeTempBuffListList`1_hotfix = (luaObj.RawGet("FreeTempBuffList") as LuaFunction);
					this.m_AllocateTempBuffStateListList`1_hotfix = (luaObj.RawGet("AllocateTempBuffStateList") as LuaFunction);
					this.m_FreeTempBuffStateListList`1_hotfix = (luaObj.RawGet("FreeTempBuffStateList") as LuaFunction);
					this.m_RandomizeBuffStateListList`1_hotfix = (luaObj.RawGet("RandomizeBuffStateList") as LuaFunction);
					this.m_GetTempBattlePropertyModifier_hotfix = (luaObj.RawGet("GetTempBattlePropertyModifier") as LuaFunction);
					this.m_IsProbabilitySatisfiedInt32_hotfix = (luaObj.RawGet("IsProbabilitySatisfied") as LuaFunction);
					this.m_GetRandomBuffListList`1Int32List`1_hotfix = (luaObj.RawGet("GetRandomBuffList") as LuaFunction);
					this.m_ComputeArmyRelationDataConfigDataArmyInfoConfigDataArmyInfoBattleActorBattleActorBooleanBoolean_hotfix = (luaObj.RawGet("ComputeArmyRelationData") as LuaFunction);
					this.m_FindPathGridPositionGridPositionInt32MoveTypeInt32Int32Int32List`1Boolean_hotfix = (luaObj.RawGet("FindPath") as LuaFunction);
					this.m_FindMoveRegionGridPositionInt32MoveTypeInt32Int32Int32List`1_hotfix = (luaObj.RawGet("FindMoveRegion") as LuaFunction);
					this.m_FindAttackRegionGridPositionInt32Int32List`1_hotfix = (luaObj.RawGet("FindAttackRegion") as LuaFunction);
					this.m_FindFixedDistanceRegionGridPositionInt32List`1_hotfix = (luaObj.RawGet("FindFixedDistanceRegion") as LuaFunction);
					this.m_IsInDangerRegionInt32GridPosition_hotfix = (luaObj.RawGet("IsInDangerRegion") as LuaFunction);
					this.m_GetStars_hotfix = (luaObj.RawGet("GetStars") as LuaFunction);
					this.m_IsWin_hotfix = (luaObj.RawGet("IsWin") as LuaFunction);
					this.m_GetPlayerActorsInt32_hotfix = (luaObj.RawGet("GetPlayerActors") as LuaFunction);
					this.m_GetPlayerActorsLogInfosInt32_hotfix = (luaObj.RawGet("GetPlayerActorsLogInfos") as LuaFunction);
					this.m_GetPlayerKillActorCountInt32_hotfix = (luaObj.RawGet("GetPlayerKillActorCount") as LuaFunction);
					this.m_GetDeadEnemyActors_hotfix = (luaObj.RawGet("GetDeadEnemyActors") as LuaFunction);
					this.m_get_AliveActorsInfo_hotfix = (luaObj.RawGet("get_AliveActorsInfo") as LuaFunction);
					this.m_EnableChecksumBoolean_hotfix = (luaObj.RawGet("EnableChecksum") as LuaFunction);
					this.m_GetChecksums_hotfix = (luaObj.RawGet("GetChecksums") as LuaFunction);
					this.m_ComputeStepChecksum_hotfix = (luaObj.RawGet("ComputeStepChecksum") as LuaFunction);
					this.m_EnableDebugLogBoolean_hotfix = (luaObj.RawGet("EnableDebugLog") as LuaFunction);
					this.m_IsEnableDebugLog_hotfix = (luaObj.RawGet("IsEnableDebugLog") as LuaFunction);
					this.m_get_ConfigDataLoader_hotfix = (luaObj.RawGet("get_ConfigDataLoader") as LuaFunction);
					this.m_get_Listener_hotfix = (luaObj.RawGet("get_Listener") as LuaFunction);
					this.m_get_RandomNumber_hotfix = (luaObj.RawGet("get_RandomNumber") as LuaFunction);
					this.m_get_AIRandomNumber1_hotfix = (luaObj.RawGet("get_AIRandomNumber1") as LuaFunction);
					this.m_get_AIRandomNumber2_hotfix = (luaObj.RawGet("get_AIRandomNumber2") as LuaFunction);
					this.m_get_BattleInfo_hotfix = (luaObj.RawGet("get_BattleInfo") as LuaFunction);
					this.m_get_ArenaBattleInfo_hotfix = (luaObj.RawGet("get_ArenaBattleInfo") as LuaFunction);
					this.m_get_PVPBattleInfo_hotfix = (luaObj.RawGet("get_PVPBattleInfo") as LuaFunction);
					this.m_get_RealTimePVPBattleInfo_hotfix = (luaObj.RawGet("get_RealTimePVPBattleInfo") as LuaFunction);
					this.m_get_BattleType_hotfix = (luaObj.RawGet("get_BattleType") as LuaFunction);
					this.m_get_ActionOrderType_hotfix = (luaObj.RawGet("get_ActionOrderType") as LuaFunction);
					this.m_get_BattlePlayers_hotfix = (luaObj.RawGet("get_BattlePlayers") as LuaFunction);
					this.m_get_MaxPlayerLevelInfo_hotfix = (luaObj.RawGet("get_MaxPlayerLevelInfo") as LuaFunction);
					this.m_get_State_hotfix = (luaObj.RawGet("get_State") as LuaFunction);
					this.m_get_Step_hotfix = (luaObj.RawGet("get_Step") as LuaFunction);
					this.m_get_Turn_hotfix = (luaObj.RawGet("get_Turn") as LuaFunction);
					this.m_get_TurnMax_hotfix = (luaObj.RawGet("get_TurnMax") as LuaFunction);
					this.m_get_Map_hotfix = (luaObj.RawGet("get_Map") as LuaFunction);
					this.m_get_Combat_hotfix = (luaObj.RawGet("get_Combat") as LuaFunction);
					this.m_CheckAchievementOnActorMoveBattleActor_hotfix = (luaObj.RawGet("CheckAchievementOnActorMove") as LuaFunction);
					this.m_CheckAchievementOnActorDieBattleActor_hotfix = (luaObj.RawGet("CheckAchievementOnActorDie") as LuaFunction);
					this.m_CheckAchievementOnNextStep_hotfix = (luaObj.RawGet("CheckAchievementOnNextStep") as LuaFunction);
					this.m_CheckAchievementOnTurnEndOrWinBoolean_hotfix = (luaObj.RawGet("CheckAchievementOnTurnEndOrWin") as LuaFunction);
					this.m_CheckAchievementOnWin_hotfix = (luaObj.RawGet("CheckAchievementOnWin") as LuaFunction);
					this.m_CheckAchievementOnLose_hotfix = (luaObj.RawGet("CheckAchievementOnLose") as LuaFunction);
					this.m_ChangeAchievementStatusBattleAchievementStateBoolean_hotfix = (luaObj.RawGet("ChangeAchievementStatus") as LuaFunction);
					this.m_IsActorsAllAliveList`1_hotfix = (luaObj.RawGet("IsActorsAllAlive") as LuaFunction);
					this.m_IsActorsAllKillBySkillClassList`1Int32_hotfix = (luaObj.RawGet("IsActorsAllKillBySkillClass") as LuaFunction);
					this.m_IsActorReachPositionsBattleActorList`1Int32_hotfix = (luaObj.RawGet("IsActorReachPositions") as LuaFunction);
					this.m_IsActorReachPositionsBattleActorNpcConditionList`1Int32_hotfix = (luaObj.RawGet("IsActorReachPositions") as LuaFunction);
					this.m_IsActorsAnyReachPositionsList`1List`1Int32_hotfix = (luaObj.RawGet("IsActorsAnyReachPositions") as LuaFunction);
					this.m_IsActorsAnyReachPositionsInt32NpcConditionList`1Int32_hotfix = (luaObj.RawGet("IsActorsAnyReachPositions") as LuaFunction);
					this.m_GetActorsCountSatisfyConditionInt32NpcConditionInt32_hotfix = (luaObj.RawGet("GetActorsCountSatisfyCondition") as LuaFunction);
					this.m_IsAchievementCompleteInt32_hotfix = (luaObj.RawGet("IsAchievementComplete") as LuaFunction);
					this.m_GetCompleteAchievements_hotfix = (luaObj.RawGet("GetCompleteAchievements") as LuaFunction);
					this.m_GetAchievementStatusInt32_hotfix = (luaObj.RawGet("GetAchievementStatus") as LuaFunction);
					this.m_AddBattleCommandBattleCommand_hotfix = (luaObj.RawGet("AddBattleCommand") as LuaFunction);
					this.m_AddLogBattleCommandBattleCommand_hotfix = (luaObj.RawGet("AddLogBattleCommand") as LuaFunction);
					this.m_AddGiveupLogBattleCommandInt32_hotfix = (luaObj.RawGet("AddGiveupLogBattleCommand") as LuaFunction);
					this.m_AddCancelLogBattleCommandInt32_hotfix = (luaObj.RawGet("AddCancelLogBattleCommand") as LuaFunction);
					this.m_AddBattleCommandToListLinkedList`1BattleCommand_hotfix = (luaObj.RawGet("AddBattleCommandToList") as LuaFunction);
					this.m_ClearBattleCommandsAndNextStep_hotfix = (luaObj.RawGet("ClearBattleCommandsAndNextStep") as LuaFunction);
					this.m_HasBattleCommand_hotfix = (luaObj.RawGet("HasBattleCommand") as LuaFunction);
					this.m_HasCurrentStepBattleCommand_hotfix = (luaObj.RawGet("HasCurrentStepBattleCommand") as LuaFunction);
					this.m_HasWrongStepBattleCommand_hotfix = (luaObj.RawGet("HasWrongStepBattleCommand") as LuaFunction);
					this.m_ExecuteBattleCommand_hotfix = (luaObj.RawGet("ExecuteBattleCommand") as LuaFunction);
					this.m_ExecuteGiveupCommandInt32_hotfix = (luaObj.RawGet("ExecuteGiveupCommand") as LuaFunction);
					this.m_RemoveStepCommandsInt32_hotfix = (luaObj.RawGet("RemoveStepCommands") as LuaFunction);
					this.m_RunCurrentStepBattleCommand_hotfix = (luaObj.RawGet("RunCurrentStepBattleCommand") as LuaFunction);
					this.m_RunCombat_hotfix = (luaObj.RawGet("RunCombat") as LuaFunction);
					this.m_RunBoolean_hotfix = (luaObj.RawGet("Run") as LuaFunction);
					this.m_RunAIActors_hotfix = (luaObj.RawGet("RunAIActors") as LuaFunction);
					this.m_RunPlayerBattleCommandsInt32List`1_hotfix = (luaObj.RawGet("RunPlayerBattleCommands") as LuaFunction);
					this.m_AddExecutedCommandBattleCommand_hotfix = (luaObj.RawGet("AddExecutedCommand") as LuaFunction);
					this.m_FixExecutedCommandsBattleActorInt32_hotfix = (luaObj.RawGet("FixExecutedCommands") as LuaFunction);
					this.m_GetStepExecutedCommands_hotfix = (luaObj.RawGet("GetStepExecutedCommands") as LuaFunction);
					this.m_EnableLogBattleCommandsBoolean_hotfix = (luaObj.RawGet("EnableLogBattleCommands") as LuaFunction);
					this.m_IsEnableLogBattleCommands_hotfix = (luaObj.RawGet("IsEnableLogBattleCommands") as LuaFunction);
					this.m_GetLogBattleCommands_hotfix = (luaObj.RawGet("GetLogBattleCommands") as LuaFunction);
					this.m_EnableTempBattleCommandsBoolean_hotfix = (luaObj.RawGet("EnableTempBattleCommands") as LuaFunction);
					this.m_IsEnableTempBattleCommands_hotfix = (luaObj.RawGet("IsEnableTempBattleCommands") as LuaFunction);
					this.m_GetTempBattleCommands_hotfix = (luaObj.RawGet("GetTempBattleCommands") as LuaFunction);
					this.m_ClearTempBattleCommands_hotfix = (luaObj.RawGet("ClearTempBattleCommands") as LuaFunction);
					this.m_StartCombatBattleActorBattleActorConfigDataSkillInfo_hotfix = (luaObj.RawGet("StartCombat") as LuaFunction);
					this.m_StopCombat_hotfix = (luaObj.RawGet("StopCombat") as LuaFunction);
					this.m_CheckCombatActorsDieBattleActorBattleActor_hotfix = (luaObj.RawGet("CheckCombatActorsDie") as LuaFunction);
					this.m_RestartCombat_hotfix = (luaObj.RawGet("RestartCombat") as LuaFunction);
					this.m_CopyCombatPropertyCombatTeamBattleActor_hotfix = (luaObj.RawGet("CopyCombatProperty") as LuaFunction);
					this.m_CheckWinConditionOnActorMoveBattleActor_hotfix = (luaObj.RawGet("CheckWinConditionOnActorMove") as LuaFunction);
					this.m_CheckLoseConditionOnActorMoveBattleActor_hotfix = (luaObj.RawGet("CheckLoseConditionOnActorMove") as LuaFunction);
					this.m_CheckWinConditionOnActorDieBattleActor_hotfix = (luaObj.RawGet("CheckWinConditionOnActorDie") as LuaFunction);
					this.m_CheckLoseConditionOnActorDieBattleActor_hotfix = (luaObj.RawGet("CheckLoseConditionOnActorDie") as LuaFunction);
					this.m_CheckWinConditionOnActorRetreatBattleActor_hotfix = (luaObj.RawGet("CheckWinConditionOnActorRetreat") as LuaFunction);
					this.m_CheckLoseConditionOnActorRetreatBattleActor_hotfix = (luaObj.RawGet("CheckLoseConditionOnActorRetreat") as LuaFunction);
					this.m_CheckWinConditionOnEventTriggerBattleEventTriggerState_hotfix = (luaObj.RawGet("CheckWinConditionOnEventTrigger") as LuaFunction);
					this.m_CheckLoseConditionOnEventTriggerBattleEventTriggerState_hotfix = (luaObj.RawGet("CheckLoseConditionOnEventTrigger") as LuaFunction);
					this.m_CheckWinConditionOnNextStep_hotfix = (luaObj.RawGet("CheckWinConditionOnNextStep") as LuaFunction);
					this.m_CheckWinConditionOnTurnBegin_hotfix = (luaObj.RawGet("CheckWinConditionOnTurnBegin") as LuaFunction);
					this.m_CheckWinLoseConditionOnTurnMax_hotfix = (luaObj.RawGet("CheckWinLoseConditionOnTurnMax") as LuaFunction);
					this.m_ChangeWinConditionStatusBattleWinConditionState_hotfix = (luaObj.RawGet("ChangeWinConditionStatus") as LuaFunction);
					this.m_ChangeLoseConditionStatusBattleLoseConditionState_hotfix = (luaObj.RawGet("ChangeLoseConditionStatus") as LuaFunction);
					this.m_CheckEventTriggerOnActorMoveBattleActor_hotfix = (luaObj.RawGet("CheckEventTriggerOnActorMove") as LuaFunction);
					this.m_CheckEventTriggerOnActorDieBattleActor_hotfix = (luaObj.RawGet("CheckEventTriggerOnActorDie") as LuaFunction);
					this.m_CheckEventTriggerOnActorActionBeginBattleActor_hotfix = (luaObj.RawGet("CheckEventTriggerOnActorActionBegin") as LuaFunction);
					this.m_CheckEventTriggerOnActorCombatAttackBeforeBattleActorBattleActor_hotfix = (luaObj.RawGet("CheckEventTriggerOnActorCombatAttackBefore") as LuaFunction);
					this.m_CheckEventTriggerOnActorCombatAttackAfterBattleActorBattleActor_hotfix = (luaObj.RawGet("CheckEventTriggerOnActorCombatAttackAfter") as LuaFunction);
					this.m_CheckEventTriggerOnActorBeCombatAttackBattleActor_hotfix = (luaObj.RawGet("CheckEventTriggerOnActorBeCombatAttack") as LuaFunction);
					this.m_CheckEventTriggerOnActorUseSkillBattleActor_hotfix = (luaObj.RawGet("CheckEventTriggerOnActorUseSkill") as LuaFunction);
					this.m_CheckEventTriggerOnNextStep_hotfix = (luaObj.RawGet("CheckEventTriggerOnNextStep") as LuaFunction);
					this.m_CheckEventTriggerOnNextTeamInt32Boolean_hotfix = (luaObj.RawGet("CheckEventTriggerOnNextTeam") as LuaFunction);
					this.m_CheckEventTriggerOnCompleteAchievementInt32_hotfix = (luaObj.RawGet("CheckEventTriggerOnCompleteAchievement") as LuaFunction);
					this.m_CheckEventTriggerOnWin_hotfix = (luaObj.RawGet("CheckEventTriggerOnWin") as LuaFunction);
					this.m_CheckEventTriggerOnLose_hotfix = (luaObj.RawGet("CheckEventTriggerOnLose") as LuaFunction);
					this.m_CheckBattleStopEventTrigger_hotfix = (luaObj.RawGet("CheckBattleStopEventTrigger") as LuaFunction);
					this.m_CheckMultiEventTrigger_hotfix = (luaObj.RawGet("CheckMultiEventTrigger") as LuaFunction);
					this.m_IsEventTriggerdInt32_hotfix = (luaObj.RawGet("IsEventTriggerd") as LuaFunction);
					this.m_GetEventTriggerStateInt32_hotfix = (luaObj.RawGet("GetEventTriggerState") as LuaFunction);
					this.m_TriggerEventBattleEventTriggerState_hotfix = (luaObj.RawGet("TriggerEvent") as LuaFunction);
					this.m_ExecuteTriggerEventActionsBattleEventTriggerStateInt32_hotfix = (luaObj.RawGet("ExecuteTriggerEventActions") as LuaFunction);
					this.m_ExecuteEventActionConfigDataBattleEventActionInfo_hotfix = (luaObj.RawGet("ExecuteEventAction") as LuaFunction);
					this.m_ExecuteEventAction_ReliefConfigDataBattleEventActionInfo_hotfix = (luaObj.RawGet("ExecuteEventAction_Relief") as LuaFunction);
					this.m_ExecuteEventAction_RetreatConfigDataBattleEventActionInfo_hotfix = (luaObj.RawGet("ExecuteEventAction_Retreat") as LuaFunction);
					this.m_ExecuteEventAction_DialogConfigDataBattleEventActionInfo_hotfix = (luaObj.RawGet("ExecuteEventAction_Dialog") as LuaFunction);
					this.m_ExecuteEventAction_ChangeTeamConfigDataBattleEventActionInfo_hotfix = (luaObj.RawGet("ExecuteEventAction_ChangeTeam") as LuaFunction);
					this.m_ExecuteEventAction_AttachBuffConfigDataBattleEventActionInfo_hotfix = (luaObj.RawGet("ExecuteEventAction_AttachBuff") as LuaFunction);
					this.m_ExecuteEventAction_ChangeBehaviorConfigDataBattleEventActionInfo_hotfix = (luaObj.RawGet("ExecuteEventAction_ChangeBehavior") as LuaFunction);
					this.m_ExecuteEventAction_MusicConfigDataBattleEventActionInfo_hotfix = (luaObj.RawGet("ExecuteEventAction_Music") as LuaFunction);
					this.m_ExecuteEventAction_ChangeTerrainConfigDataBattleEventActionInfo_hotfix = (luaObj.RawGet("ExecuteEventAction_ChangeTerrain") as LuaFunction);
					this.m_ExecuteEventAction_PerformConfigDataBattleEventActionInfo_hotfix = (luaObj.RawGet("ExecuteEventAction_Perform") as LuaFunction);
					this.m_ExecuteEventAction_RetreatPositionConfigDataBattleEventActionInfo_hotfix = (luaObj.RawGet("ExecuteEventAction_RetreatPosition") as LuaFunction);
					this.m_ExecuteEventAction_ReplaceConfigDataBattleEventActionInfo_hotfix = (luaObj.RawGet("ExecuteEventAction_Replace") as LuaFunction);
					this.m_ExecuteEventAction_RemoveBuffConfigDataBattleEventActionInfo_hotfix = (luaObj.RawGet("ExecuteEventAction_RemoveBuff") as LuaFunction);
					this.m_ExecuteEventAction_AttachBuffPositionConfigDataBattleEventActionInfo_hotfix = (luaObj.RawGet("ExecuteEventAction_AttachBuffPosition") as LuaFunction);
					this.m_IsEmptyPositionGridPosition_hotfix = (luaObj.RawGet("IsEmptyPosition") as LuaFunction);
					this.m_GetRandomBattleArmyActorsList`1_hotfix = (luaObj.RawGet("GetRandomBattleArmyActors") as LuaFunction);
					this.m_CreateEventActorGridPositionInt32Int32BooleanInt32Int32Int32Int32Int32StringBattleActorSourceType_hotfix = (luaObj.RawGet("CreateEventActor") as LuaFunction);
					this.m_ReplaceEventActorBattleActorInt32Int32String_hotfix = (luaObj.RawGet("ReplaceEventActor") as LuaFunction);
					this.m_FindEmptyFixedDistancePositionGridPositionInt32_hotfix = (luaObj.RawGet("FindEmptyFixedDistancePosition") as LuaFunction);
					this.m_FindEmptyFixedDistancePositionGridPositionGridPositionInt32_hotfix = (luaObj.RawGet("FindEmptyFixedDistancePosition") as LuaFunction);
					this.m_FindEmptyNearPositionGridPositionMoveType_hotfix = (luaObj.RawGet("FindEmptyNearPosition") as LuaFunction);
					this.m_CreateMapConfigDataBattlefieldInfo_hotfix = (luaObj.RawGet("CreateMap") as LuaFunction);
					this.m_ResetMap_hotfix = (luaObj.RawGet("ResetMap") as LuaFunction);
					this.m_SetMyPlayerTeamNumberInt32_hotfix = (luaObj.RawGet("SetMyPlayerTeamNumber") as LuaFunction);
					this.m_GetMyPlayerTeamNumber_hotfix = (luaObj.RawGet("GetMyPlayerTeamNumber") as LuaFunction);
					this.m_InitBattleConfigDataBattleInfoBattleTypeBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32Int32Int32_hotfix = (luaObj.RawGet("InitBattle") as LuaFunction);
					this.m_InitArenaBattleConfigDataArenaBattleInfoBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32ConfigDataArenaDefendRuleInfo_hotfix = (luaObj.RawGet("InitArenaBattle") as LuaFunction);
					this.m_InitPVPBattleConfigDataPVPBattleInfoBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32_hotfix = (luaObj.RawGet("InitPVPBattle") as LuaFunction);
					this.m_InitRealTimePVPBattleConfigDataRealTimePVPBattleInfoBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32_hotfix = (luaObj.RawGet("InitRealTimePVPBattle") as LuaFunction);
					this.m_InitRandomNumbersInt32Int32_hotfix = (luaObj.RawGet("InitRandomNumbers") as LuaFunction);
					this.m_InitPlayersBattlePlayerbe_hotfix = (luaObj.RawGet("InitPlayers") as LuaFunction);
					this.m_InitWinConditionStatesConfigDataBattleWinConditionInfobe_hotfix = (luaObj.RawGet("InitWinConditionStates") as LuaFunction);
					this.m_InitLoseConditionStatesConfigDataBattleLoseConditionInfobe_hotfix = (luaObj.RawGet("InitLoseConditionStates") as LuaFunction);
					this.m_InitEventTriggerStatesConfigDataBattleEventTriggerInfobe_hotfix = (luaObj.RawGet("InitEventTriggerStates") as LuaFunction);
					this.m_InitBattleTreasureStatesConfigDataBattleTreasureInfobe_hotfix = (luaObj.RawGet("InitBattleTreasureStates") as LuaFunction);
					this.m_CreateActorsInt32List`1_hotfix = (luaObj.RawGet("CreateActors") as LuaFunction);
					this.m_InitBattleReportConfigDataBattleInfoBattleTypeBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32Int32Int32List`1_hotfix = (luaObj.RawGet("InitBattleReport") as LuaFunction);
					this.m_InitArenaBattleReportConfigDataArenaBattleInfoBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32ConfigDataArenaDefendRuleInfoList`1_hotfix = (luaObj.RawGet("InitArenaBattleReport") as LuaFunction);
					this.m_InitPVPBattleReportConfigDataPVPBattleInfoBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32List`1_hotfix = (luaObj.RawGet("InitPVPBattleReport") as LuaFunction);
					this.m_InitRealTimePVPBattleReportConfigDataRealTimePVPBattleInfoBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32List`1_hotfix = (luaObj.RawGet("InitRealTimePVPBattleReport") as LuaFunction);
					this.m_InitStarAndAchievementInt32Int32List`1_hotfix = (luaObj.RawGet("InitStarAndAchievement") as LuaFunction);
					this.m_InitGainBattleTreasuresList`1_hotfix = (luaObj.RawGet("InitGainBattleTreasures") as LuaFunction);
					this.m_ExecuteBattlePerformsConfigDataBattlePerformInfo_hotfix = (luaObj.RawGet("ExecuteBattlePerforms") as LuaFunction);
					this.m_ExecuteAfterCombatSteps_hotfix = (luaObj.RawGet("ExecuteAfterCombatSteps") as LuaFunction);
					this.m_ExecuteBattlePerformConfigDataBattlePerformInfo_hotfix = (luaObj.RawGet("ExecuteBattlePerform") as LuaFunction);
					this.m_ExecuteBattlePerform_DialogConfigDataBattlePerformInfo_hotfix = (luaObj.RawGet("ExecuteBattlePerform_Dialog") as LuaFunction);
					this.m_ExecuteBattlePerform_PlayMusicConfigDataBattlePerformInfo_hotfix = (luaObj.RawGet("ExecuteBattlePerform_PlayMusic") as LuaFunction);
					this.m_ExecuteBattlePerform_PlaySoundConfigDataBattlePerformInfo_hotfix = (luaObj.RawGet("ExecuteBattlePerform_PlaySound") as LuaFunction);
					this.m_ExecuteBattlePerform_PlayFxConfigDataBattlePerformInfo_hotfix = (luaObj.RawGet("ExecuteBattlePerform_PlayFx") as LuaFunction);
					this.m_ExecuteBattlePerform_PlayActorFxConfigDataBattlePerformInfo_hotfix = (luaObj.RawGet("ExecuteBattlePerform_PlayActorFx") as LuaFunction);
					this.m_ExecuteBattlePerform_ChangeTerrainConfigDataBattlePerformInfo_hotfix = (luaObj.RawGet("ExecuteBattlePerform_ChangeTerrain") as LuaFunction);
					this.m_ExecuteBattlePerform_CameraFocusPositionConfigDataBattlePerformInfo_hotfix = (luaObj.RawGet("ExecuteBattlePerform_CameraFocusPosition") as LuaFunction);
					this.m_ExecuteBattlePerform_CameraFocusActorConfigDataBattlePerformInfo_hotfix = (luaObj.RawGet("ExecuteBattlePerform_CameraFocusActor") as LuaFunction);
					this.m_ExecuteBattlePerform_CreateActorConfigDataBattlePerformInfo_hotfix = (luaObj.RawGet("ExecuteBattlePerform_CreateActor") as LuaFunction);
					this.m_ExecuteBattlePerform_CreateActorNearConfigDataBattlePerformInfo_hotfix = (luaObj.RawGet("ExecuteBattlePerform_CreateActorNear") as LuaFunction);
					this.m_ExecuteBattlePerform_RemoveActorConfigDataBattlePerformInfo_hotfix = (luaObj.RawGet("ExecuteBattlePerform_RemoveActor") as LuaFunction);
					this.m_ExecuteBattlePerform_ActorMoveConfigDataBattlePerformInfo_hotfix = (luaObj.RawGet("ExecuteBattlePerform_ActorMove") as LuaFunction);
					this.m_ExecuteBattlePerform_ActorMoveNearConfigDataBattlePerformInfo_hotfix = (luaObj.RawGet("ExecuteBattlePerform_ActorMoveNear") as LuaFunction);
					this.m_ExecuteBattlePerform_ActorAttackConfigDataBattlePerformInfo_hotfix = (luaObj.RawGet("ExecuteBattlePerform_ActorAttack") as LuaFunction);
					this.m_ExecuteBattlePerform_ActorSkillConfigDataBattlePerformInfo_hotfix = (luaObj.RawGet("ExecuteBattlePerform_ActorSkill") as LuaFunction);
					this.m_ExecuteBattlePerform_ActorDirConfigDataBattlePerformInfo_hotfix = (luaObj.RawGet("ExecuteBattlePerform_ActorDir") as LuaFunction);
					this.m_ExecuteBattlePerform_ActorAnimationConfigDataBattlePerformInfo_hotfix = (luaObj.RawGet("ExecuteBattlePerform_ActorAnimation") as LuaFunction);
					this.m_ExecuteBattlePerform_ActorIdleConfigDataBattlePerformInfo_hotfix = (luaObj.RawGet("ExecuteBattlePerform_ActorIdle") as LuaFunction);
					this.m_ExecuteBattlePerform_WaitTimeConfigDataBattlePerformInfo_hotfix = (luaObj.RawGet("ExecuteBattlePerform_WaitTime") as LuaFunction);
					this.m_ExecuteBattlePerform_StopBattleConfigDataBattlePerformInfo_hotfix = (luaObj.RawGet("ExecuteBattlePerform_StopBattle") as LuaFunction);
					this.m_CheckBattleTreasureOnActorMoveBattleActor_hotfix = (luaObj.RawGet("CheckBattleTreasureOnActorMove") as LuaFunction);
					this.m_ChangeBattleTeasureStatusBattleTreasureStateBattleActor_hotfix = (luaObj.RawGet("ChangeBattleTeasureStatus") as LuaFunction);
					this.m_IsGainBattleTreasureInt32_hotfix = (luaObj.RawGet("IsGainBattleTreasure") as LuaFunction);
					this.m_GetGainBattleTreasures_hotfix = (luaObj.RawGet("GetGainBattleTreasures") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06003580 RID: 13696 RVA: 0x000F0D10 File Offset: 0x000EEF10
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleBase));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400284E RID: 10318
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x0400284F RID: 10319
		private IBattleListener m_battleListener;

		// Token: 0x04002850 RID: 10320
		private RandomNumber m_randomNumber;

		// Token: 0x04002851 RID: 10321
		private RandomNumber m_aiRandomNumber1;

		// Token: 0x04002852 RID: 10322
		private RandomNumber m_aiRandomNumber2;

		// Token: 0x04002853 RID: 10323
		private RandomNumber m_armyRandomNumber;

		// Token: 0x04002854 RID: 10324
		private BattleMap m_map;

		// Token: 0x04002855 RID: 10325
		private Pathfinder m_pathfinder;

		// Token: 0x04002856 RID: 10326
		private Combat m_combat;

		// Token: 0x04002857 RID: 10327
		private ConfigDataBattlefieldInfo m_battlefieldInfo;

		// Token: 0x04002858 RID: 10328
		private ConfigDataBattleInfo m_battleInfo;

		// Token: 0x04002859 RID: 10329
		private ConfigDataArenaBattleInfo m_arenaBattleInfo;

		// Token: 0x0400285A RID: 10330
		private ConfigDataPVPBattleInfo m_pvpBattleInfo;

		// Token: 0x0400285B RID: 10331
		private ConfigDataRealTimePVPBattleInfo m_realtimePvpBattleInfo;

		// Token: 0x0400285C RID: 10332
		private BattleType m_battleType;

		// Token: 0x0400285D RID: 10333
		private int m_monsterLevel;

		// Token: 0x0400285E RID: 10334
		private BattleTeam[] m_teams;

		// Token: 0x0400285F RID: 10335
		private BattlePlayer[] m_players;

		// Token: 0x04002860 RID: 10336
		private ConfigDataPlayerLevelInfo m_maxPlayerLevelInfo;

		// Token: 0x04002861 RID: 10337
		private BattleState m_state;

		// Token: 0x04002862 RID: 10338
		private int m_step;

		// Token: 0x04002863 RID: 10339
		private int m_turn;

		// Token: 0x04002864 RID: 10340
		private int m_turnMax;

		// Token: 0x04002865 RID: 10341
		private int m_actionTeam;

		// Token: 0x04002866 RID: 10342
		private int m_prevActionPlayerIndex;

		// Token: 0x04002867 RID: 10343
		private BattleActor m_actionActor;

		// Token: 0x04002868 RID: 10344
		private ActionOrderType m_actionOrderType;

		// Token: 0x04002869 RID: 10345
		private int m_entityIdCounter;

		// Token: 0x0400286A RID: 10346
		private bool m_needCheckBattleStopEventTrigger;

		// Token: 0x0400286B RID: 10347
		private bool m_isGiveupBattle;

		// Token: 0x0400286C RID: 10348
		private int m_giveupBattlePlayerIndex;

		// Token: 0x0400286D RID: 10349
		private int m_combatRandomSeed;

		// Token: 0x0400286E RID: 10350
		private BattleActor m_combatActorA;

		// Token: 0x0400286F RID: 10351
		private BattleActor m_combatActorB;

		// Token: 0x04002870 RID: 10352
		private ConfigDataSkillInfo m_combatSkillInfoA;

		// Token: 0x04002871 RID: 10353
		private BattleActor m_beGuardedCombatActor;

		// Token: 0x04002872 RID: 10354
		private bool m_isPerformCombat;

		// Token: 0x04002873 RID: 10355
		private ConfigDataBattlePerformInfo m_afterComatPerform;

		// Token: 0x04002874 RID: 10356
		private BattleEventTriggerState m_afterCombatExecuteTriggerState;

		// Token: 0x04002875 RID: 10357
		private int m_afterCombatExecuteTriggerEventActionIndex;

		// Token: 0x04002876 RID: 10358
		private bool m_isAfterCombatNextStep;

		// Token: 0x04002877 RID: 10359
		private bool m_isAfterCombatNextStepActorActive;

		// Token: 0x04002878 RID: 10360
		private List<int>[] m_tempIntLists;

		// Token: 0x04002879 RID: 10361
		private int m_freeIntListIndex;

		// Token: 0x0400287A RID: 10362
		private List<GridPosition>[] m_tempGridPositionLists;

		// Token: 0x0400287B RID: 10363
		private int m_freeGridPositionListIndex;

		// Token: 0x0400287C RID: 10364
		private List<BattleActor>[] m_tempActorLists;

		// Token: 0x0400287D RID: 10365
		private int m_freeActorListIndex;

		// Token: 0x0400287E RID: 10366
		private List<ConfigDataBuffInfo>[] m_tempBuffLists;

		// Token: 0x0400287F RID: 10367
		private int m_freeBuffListIndex;

		// Token: 0x04002880 RID: 10368
		private List<BuffState>[] m_tempBuffStateLists;

		// Token: 0x04002881 RID: 10369
		private int m_freeBuffStateListIndex;

		// Token: 0x04002882 RID: 10370
		private BattlePropertyModifier m_tempBattlePropertyModifier;

		// Token: 0x04002883 RID: 10371
		private LinkedList<BattleCommand> m_battleCommands;

		// Token: 0x04002884 RID: 10372
		private LinkedList<BattleCommand> m_logBattleCommands;

		// Token: 0x04002885 RID: 10373
		private LinkedList<BattleCommand> m_tempBattleCommands;

		// Token: 0x04002886 RID: 10374
		private List<BattleCommand> m_stepExecutedCommands;

		// Token: 0x04002887 RID: 10375
		private bool m_enableLogBattleCommands;

		// Token: 0x04002888 RID: 10376
		private bool m_enableTempBattleCommands;

		// Token: 0x04002889 RID: 10377
		private bool m_enableDebugLog = true;

		// Token: 0x0400288A RID: 10378
		private bool m_enableChecksum;

		// Token: 0x0400288B RID: 10379
		private List<int> m_checksums;

		// Token: 0x0400288C RID: 10380
		private List<BattleWinConditionState> m_winConditionStates;

		// Token: 0x0400288D RID: 10381
		private List<BattleLoseConditionState> m_loseConditionStates;

		// Token: 0x0400288E RID: 10382
		private List<BattleAchievementState> m_achievementStates;

		// Token: 0x0400288F RID: 10383
		private List<BattleEventTriggerState> m_eventTriggerStates;

		// Token: 0x04002890 RID: 10384
		private List<BattleTreasureState> m_battleTreasureStates;

		// Token: 0x04002891 RID: 10385
		private int m_stars;

		// Token: 0x04002892 RID: 10386
		private int m_starTurnMax;

		// Token: 0x04002893 RID: 10387
		private int m_starDeadMax;

		// Token: 0x04002894 RID: 10388
		private int m_myPlayerTeam;

		// Token: 0x04002895 RID: 10389
		[DoNotToLua]
		private BattleBase.LuaExportHelper luaExportHelper;

		// Token: 0x04002896 RID: 10390
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002897 RID: 10391
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002898 RID: 10392
		private LuaFunction m_ctorIConfigDataLoaderIBattleListener_hotfix;

		// Token: 0x04002899 RID: 10393
		private LuaFunction m_Dispose_hotfix;

		// Token: 0x0400289A RID: 10394
		private LuaFunction m_SetWinForCheat_hotfix;

		// Token: 0x0400289B RID: 10395
		private LuaFunction m_Clear_hotfix;

		// Token: 0x0400289C RID: 10396
		private LuaFunction m_GetStarTurnMax_hotfix;

		// Token: 0x0400289D RID: 10397
		private LuaFunction m_GetStarDeadMax_hotfix;

		// Token: 0x0400289E RID: 10398
		private LuaFunction m_IsPerformOnlyBattle_hotfix;

		// Token: 0x0400289F RID: 10399
		private LuaFunction m_Start_hotfix;

		// Token: 0x040028A0 RID: 10400
		private LuaFunction m_StopBoolean_hotfix;

		// Token: 0x040028A1 RID: 10401
		private LuaFunction m_FirstStepBoolean_hotfix;

		// Token: 0x040028A2 RID: 10402
		private LuaFunction m_NextStep_hotfix;

		// Token: 0x040028A3 RID: 10403
		private LuaFunction m_NextStep_NormalBattleActor_hotfix;

		// Token: 0x040028A4 RID: 10404
		private LuaFunction m_NextStep_PvpBattleActor_hotfix;

		// Token: 0x040028A5 RID: 10405
		private LuaFunction m_NextStepActorActive_hotfix;

		// Token: 0x040028A6 RID: 10406
		private LuaFunction m_NextTurn_hotfix;

		// Token: 0x040028A7 RID: 10407
		private LuaFunction m_GetDefaultActionActorInt32_hotfix;

		// Token: 0x040028A8 RID: 10408
		private LuaFunction m_HasNotActionFinishedActor_hotfix;

		// Token: 0x040028A9 RID: 10409
		private LuaFunction m_GetActionTeam_hotfix;

		// Token: 0x040028AA RID: 10410
		private LuaFunction m_GetActionActor_hotfix;

		// Token: 0x040028AB RID: 10411
		private LuaFunction m_ChangeActionActorBattleActor_hotfix;

		// Token: 0x040028AC RID: 10412
		private LuaFunction m_Tick_hotfix;

		// Token: 0x040028AD RID: 10413
		private LuaFunction m_TickGraphicSingle_hotfix;

		// Token: 0x040028AE RID: 10414
		private LuaFunction m_Draw_hotfix;

		// Token: 0x040028AF RID: 10415
		private LuaFunction m_ChangeMapTerrainGridPositionConfigDataTerrainInfo_hotfix;

		// Token: 0x040028B0 RID: 10416
		private LuaFunction m_GetTeamInt32_hotfix;

		// Token: 0x040028B1 RID: 10417
		private LuaFunction m_GetBattlePlayerInt32_hotfix;

		// Token: 0x040028B2 RID: 10418
		private LuaFunction m_GetActorByIdInt32_hotfix;

		// Token: 0x040028B3 RID: 10419
		private LuaFunction m_GetActorByHeroIdInt32_hotfix;

		// Token: 0x040028B4 RID: 10420
		private LuaFunction m_GetAliveActorByHeroIdInt32_hotfix;

		// Token: 0x040028B5 RID: 10421
		private LuaFunction m_GetAliveActorsByHeroIdsAndGroupIdsList`1List`1List;

		// Token: 0x040028B6 RID: 10422
		private LuaFunction m_GetNextEntityId_hotfix;

		// Token: 0x040028B7 RID: 10423
		private LuaFunction m_CheckOnActorMoveBattleActor_hotfix;

		// Token: 0x040028B8 RID: 10424
		private LuaFunction m_CheckOnActorDieBattleActor_hotfix;

		// Token: 0x040028B9 RID: 10425
		private LuaFunction m_OnActorDieBattleActor_hotfix;

		// Token: 0x040028BA RID: 10426
		private LuaFunction m_OnActorRetreatBattleActorInt32StringBoolean_hotfix;

		// Token: 0x040028BB RID: 10427
		private LuaFunction m_OnActorChangeTeamBattleActor_hotfix;

		// Token: 0x040028BC RID: 10428
		private LuaFunction m_IsPlay_hotfix;

		// Token: 0x040028BD RID: 10429
		private LuaFunction m_IsGiveupBattle_hotfix;

		// Token: 0x040028BE RID: 10430
		private LuaFunction m_GetGiveupBattlePlayerIndex_hotfix;

		// Token: 0x040028BF RID: 10431
		private LuaFunction m_AllocateTempIntList_hotfix;

		// Token: 0x040028C0 RID: 10432
		private LuaFunction m_FreeTempIntListList;

		// Token: 0x040028C1 RID: 10433
		private LuaFunction m_AllocateTempGridPositionList_hotfix;

		// Token: 0x040028C2 RID: 10434
		private LuaFunction m_FreeTempGridPositionListList;

		// Token: 0x040028C3 RID: 10435
		private LuaFunction m_AllocateTempActorList_hotfix;

		// Token: 0x040028C4 RID: 10436
		private LuaFunction m_FreeTempActorListList;

		// Token: 0x040028C5 RID: 10437
		private LuaFunction m_AllocateTempBuffList_hotfix;

		// Token: 0x040028C6 RID: 10438
		private LuaFunction m_FreeTempBuffListList;

		// Token: 0x040028C7 RID: 10439
		private LuaFunction m_AllocateTempBuffStateListList;

		// Token: 0x040028C8 RID: 10440
		private LuaFunction m_FreeTempBuffStateListList;

		// Token: 0x040028C9 RID: 10441
		private LuaFunction m_RandomizeBuffStateListList;

		// Token: 0x040028CA RID: 10442
		private LuaFunction m_GetTempBattlePropertyModifier_hotfix;

		// Token: 0x040028CB RID: 10443
		private LuaFunction m_IsProbabilitySatisfiedInt32_hotfix;

		// Token: 0x040028CC RID: 10444
		private LuaFunction m_GetRandomBuffListList`1Int32List;

		// Token: 0x040028CD RID: 10445
		private LuaFunction m_ComputeArmyRelationDataConfigDataArmyInfoConfigDataArmyInfoBattleActorBattleActorBooleanBoolean_hotfix;

		// Token: 0x040028CE RID: 10446
		private LuaFunction m_FindPathGridPositionGridPositionInt32MoveTypeInt32Int32Int32List;

		// Token: 0x040028CF RID: 10447
		private LuaFunction m_FindMoveRegionGridPositionInt32MoveTypeInt32Int32Int32List;

		// Token: 0x040028D0 RID: 10448
		private LuaFunction m_FindAttackRegionGridPositionInt32Int32List;

		// Token: 0x040028D1 RID: 10449
		private LuaFunction m_FindFixedDistanceRegionGridPositionInt32List;

		// Token: 0x040028D2 RID: 10450
		private LuaFunction m_IsInDangerRegionInt32GridPosition_hotfix;

		// Token: 0x040028D3 RID: 10451
		private LuaFunction m_GetStars_hotfix;

		// Token: 0x040028D4 RID: 10452
		private LuaFunction m_IsWin_hotfix;

		// Token: 0x040028D5 RID: 10453
		private LuaFunction m_GetPlayerActorsInt32_hotfix;

		// Token: 0x040028D6 RID: 10454
		private LuaFunction m_GetPlayerActorsLogInfosInt32_hotfix;

		// Token: 0x040028D7 RID: 10455
		private LuaFunction m_GetPlayerKillActorCountInt32_hotfix;

		// Token: 0x040028D8 RID: 10456
		private LuaFunction m_GetDeadEnemyActors_hotfix;

		// Token: 0x040028D9 RID: 10457
		private LuaFunction m_get_AliveActorsInfo_hotfix;

		// Token: 0x040028DA RID: 10458
		private LuaFunction m_EnableChecksumBoolean_hotfix;

		// Token: 0x040028DB RID: 10459
		private LuaFunction m_GetChecksums_hotfix;

		// Token: 0x040028DC RID: 10460
		private LuaFunction m_ComputeStepChecksum_hotfix;

		// Token: 0x040028DD RID: 10461
		private LuaFunction m_EnableDebugLogBoolean_hotfix;

		// Token: 0x040028DE RID: 10462
		private LuaFunction m_IsEnableDebugLog_hotfix;

		// Token: 0x040028DF RID: 10463
		private LuaFunction m_get_ConfigDataLoader_hotfix;

		// Token: 0x040028E0 RID: 10464
		private LuaFunction m_get_Listener_hotfix;

		// Token: 0x040028E1 RID: 10465
		private LuaFunction m_get_RandomNumber_hotfix;

		// Token: 0x040028E2 RID: 10466
		private LuaFunction m_get_AIRandomNumber1_hotfix;

		// Token: 0x040028E3 RID: 10467
		private LuaFunction m_get_AIRandomNumber2_hotfix;

		// Token: 0x040028E4 RID: 10468
		private LuaFunction m_get_BattleInfo_hotfix;

		// Token: 0x040028E5 RID: 10469
		private LuaFunction m_get_ArenaBattleInfo_hotfix;

		// Token: 0x040028E6 RID: 10470
		private LuaFunction m_get_PVPBattleInfo_hotfix;

		// Token: 0x040028E7 RID: 10471
		private LuaFunction m_get_RealTimePVPBattleInfo_hotfix;

		// Token: 0x040028E8 RID: 10472
		private LuaFunction m_get_BattleType_hotfix;

		// Token: 0x040028E9 RID: 10473
		private LuaFunction m_get_ActionOrderType_hotfix;

		// Token: 0x040028EA RID: 10474
		private LuaFunction m_get_BattlePlayers_hotfix;

		// Token: 0x040028EB RID: 10475
		private LuaFunction m_get_MaxPlayerLevelInfo_hotfix;

		// Token: 0x040028EC RID: 10476
		private LuaFunction m_get_State_hotfix;

		// Token: 0x040028ED RID: 10477
		private LuaFunction m_get_Step_hotfix;

		// Token: 0x040028EE RID: 10478
		private LuaFunction m_get_Turn_hotfix;

		// Token: 0x040028EF RID: 10479
		private LuaFunction m_get_TurnMax_hotfix;

		// Token: 0x040028F0 RID: 10480
		private LuaFunction m_get_Map_hotfix;

		// Token: 0x040028F1 RID: 10481
		private LuaFunction m_get_Combat_hotfix;

		// Token: 0x040028F2 RID: 10482
		private LuaFunction m_CheckAchievementOnActorMoveBattleActor_hotfix;

		// Token: 0x040028F3 RID: 10483
		private LuaFunction m_CheckAchievementOnActorDieBattleActor_hotfix;

		// Token: 0x040028F4 RID: 10484
		private LuaFunction m_CheckAchievementOnNextStep_hotfix;

		// Token: 0x040028F5 RID: 10485
		private LuaFunction m_CheckAchievementOnTurnEndOrWinBoolean_hotfix;

		// Token: 0x040028F6 RID: 10486
		private LuaFunction m_CheckAchievementOnWin_hotfix;

		// Token: 0x040028F7 RID: 10487
		private LuaFunction m_CheckAchievementOnLose_hotfix;

		// Token: 0x040028F8 RID: 10488
		private LuaFunction m_ChangeAchievementStatusBattleAchievementStateBoolean_hotfix;

		// Token: 0x040028F9 RID: 10489
		private LuaFunction m_IsActorsAllAliveList;

		// Token: 0x040028FA RID: 10490
		private LuaFunction m_IsActorsAllKillBySkillClassList;

		// Token: 0x040028FB RID: 10491
		private LuaFunction m_IsActorReachPositionsBattleActorList;

		// Token: 0x040028FC RID: 10492
		private LuaFunction m_IsActorReachPositionsBattleActorNpcConditionList;

		// Token: 0x040028FD RID: 10493
		private LuaFunction m_IsActorsAnyReachPositionsList`1List;

		// Token: 0x040028FE RID: 10494
		private LuaFunction m_IsActorsAnyReachPositionsInt32NpcConditionList;

		// Token: 0x040028FF RID: 10495
		private LuaFunction m_GetActorsCountSatisfyConditionInt32NpcConditionInt32_hotfix;

		// Token: 0x04002900 RID: 10496
		private LuaFunction m_IsAchievementCompleteInt32_hotfix;

		// Token: 0x04002901 RID: 10497
		private LuaFunction m_GetCompleteAchievements_hotfix;

		// Token: 0x04002902 RID: 10498
		private LuaFunction m_GetAchievementStatusInt32_hotfix;

		// Token: 0x04002903 RID: 10499
		private LuaFunction m_AddBattleCommandBattleCommand_hotfix;

		// Token: 0x04002904 RID: 10500
		private LuaFunction m_AddLogBattleCommandBattleCommand_hotfix;

		// Token: 0x04002905 RID: 10501
		private LuaFunction m_AddGiveupLogBattleCommandInt32_hotfix;

		// Token: 0x04002906 RID: 10502
		private LuaFunction m_AddCancelLogBattleCommandInt32_hotfix;

		// Token: 0x04002907 RID: 10503
		private LuaFunction m_AddBattleCommandToListLinkedList;

		// Token: 0x04002908 RID: 10504
		private LuaFunction m_ClearBattleCommandsAndNextStep_hotfix;

		// Token: 0x04002909 RID: 10505
		private LuaFunction m_HasBattleCommand_hotfix;

		// Token: 0x0400290A RID: 10506
		private LuaFunction m_HasCurrentStepBattleCommand_hotfix;

		// Token: 0x0400290B RID: 10507
		private LuaFunction m_HasWrongStepBattleCommand_hotfix;

		// Token: 0x0400290C RID: 10508
		private LuaFunction m_ExecuteBattleCommand_hotfix;

		// Token: 0x0400290D RID: 10509
		private LuaFunction m_ExecuteGiveupCommandInt32_hotfix;

		// Token: 0x0400290E RID: 10510
		private LuaFunction m_RemoveStepCommandsInt32_hotfix;

		// Token: 0x0400290F RID: 10511
		private LuaFunction m_RunCurrentStepBattleCommand_hotfix;

		// Token: 0x04002910 RID: 10512
		private LuaFunction m_RunCombat_hotfix;

		// Token: 0x04002911 RID: 10513
		private LuaFunction m_RunBoolean_hotfix;

		// Token: 0x04002912 RID: 10514
		private LuaFunction m_RunAIActors_hotfix;

		// Token: 0x04002913 RID: 10515
		private LuaFunction m_RunPlayerBattleCommandsInt32List;

		// Token: 0x04002914 RID: 10516
		private LuaFunction m_AddExecutedCommandBattleCommand_hotfix;

		// Token: 0x04002915 RID: 10517
		private LuaFunction m_FixExecutedCommandsBattleActorInt32_hotfix;

		// Token: 0x04002916 RID: 10518
		private LuaFunction m_GetStepExecutedCommands_hotfix;

		// Token: 0x04002917 RID: 10519
		private LuaFunction m_EnableLogBattleCommandsBoolean_hotfix;

		// Token: 0x04002918 RID: 10520
		private LuaFunction m_IsEnableLogBattleCommands_hotfix;

		// Token: 0x04002919 RID: 10521
		private LuaFunction m_GetLogBattleCommands_hotfix;

		// Token: 0x0400291A RID: 10522
		private LuaFunction m_EnableTempBattleCommandsBoolean_hotfix;

		// Token: 0x0400291B RID: 10523
		private LuaFunction m_IsEnableTempBattleCommands_hotfix;

		// Token: 0x0400291C RID: 10524
		private LuaFunction m_GetTempBattleCommands_hotfix;

		// Token: 0x0400291D RID: 10525
		private LuaFunction m_ClearTempBattleCommands_hotfix;

		// Token: 0x0400291E RID: 10526
		private LuaFunction m_StartCombatBattleActorBattleActorConfigDataSkillInfo_hotfix;

		// Token: 0x0400291F RID: 10527
		private LuaFunction m_StopCombat_hotfix;

		// Token: 0x04002920 RID: 10528
		private LuaFunction m_CheckCombatActorsDieBattleActorBattleActor_hotfix;

		// Token: 0x04002921 RID: 10529
		private LuaFunction m_RestartCombat_hotfix;

		// Token: 0x04002922 RID: 10530
		private LuaFunction m_CopyCombatPropertyCombatTeamBattleActor_hotfix;

		// Token: 0x04002923 RID: 10531
		private LuaFunction m_CheckWinConditionOnActorMoveBattleActor_hotfix;

		// Token: 0x04002924 RID: 10532
		private LuaFunction m_CheckLoseConditionOnActorMoveBattleActor_hotfix;

		// Token: 0x04002925 RID: 10533
		private LuaFunction m_CheckWinConditionOnActorDieBattleActor_hotfix;

		// Token: 0x04002926 RID: 10534
		private LuaFunction m_CheckLoseConditionOnActorDieBattleActor_hotfix;

		// Token: 0x04002927 RID: 10535
		private LuaFunction m_CheckWinConditionOnActorRetreatBattleActor_hotfix;

		// Token: 0x04002928 RID: 10536
		private LuaFunction m_CheckLoseConditionOnActorRetreatBattleActor_hotfix;

		// Token: 0x04002929 RID: 10537
		private LuaFunction m_CheckWinConditionOnEventTriggerBattleEventTriggerState_hotfix;

		// Token: 0x0400292A RID: 10538
		private LuaFunction m_CheckLoseConditionOnEventTriggerBattleEventTriggerState_hotfix;

		// Token: 0x0400292B RID: 10539
		private LuaFunction m_CheckWinConditionOnNextStep_hotfix;

		// Token: 0x0400292C RID: 10540
		private LuaFunction m_CheckWinConditionOnTurnBegin_hotfix;

		// Token: 0x0400292D RID: 10541
		private LuaFunction m_CheckWinLoseConditionOnTurnMax_hotfix;

		// Token: 0x0400292E RID: 10542
		private LuaFunction m_ChangeWinConditionStatusBattleWinConditionState_hotfix;

		// Token: 0x0400292F RID: 10543
		private LuaFunction m_ChangeLoseConditionStatusBattleLoseConditionState_hotfix;

		// Token: 0x04002930 RID: 10544
		private LuaFunction m_CheckEventTriggerOnActorMoveBattleActor_hotfix;

		// Token: 0x04002931 RID: 10545
		private LuaFunction m_CheckEventTriggerOnActorDieBattleActor_hotfix;

		// Token: 0x04002932 RID: 10546
		private LuaFunction m_CheckEventTriggerOnActorActionBeginBattleActor_hotfix;

		// Token: 0x04002933 RID: 10547
		private LuaFunction m_CheckEventTriggerOnActorCombatAttackBeforeBattleActorBattleActor_hotfix;

		// Token: 0x04002934 RID: 10548
		private LuaFunction m_CheckEventTriggerOnActorCombatAttackAfterBattleActorBattleActor_hotfix;

		// Token: 0x04002935 RID: 10549
		private LuaFunction m_CheckEventTriggerOnActorBeCombatAttackBattleActor_hotfix;

		// Token: 0x04002936 RID: 10550
		private LuaFunction m_CheckEventTriggerOnActorUseSkillBattleActor_hotfix;

		// Token: 0x04002937 RID: 10551
		private LuaFunction m_CheckEventTriggerOnNextStep_hotfix;

		// Token: 0x04002938 RID: 10552
		private LuaFunction m_CheckEventTriggerOnNextTeamInt32Boolean_hotfix;

		// Token: 0x04002939 RID: 10553
		private LuaFunction m_CheckEventTriggerOnCompleteAchievementInt32_hotfix;

		// Token: 0x0400293A RID: 10554
		private LuaFunction m_CheckEventTriggerOnWin_hotfix;

		// Token: 0x0400293B RID: 10555
		private LuaFunction m_CheckEventTriggerOnLose_hotfix;

		// Token: 0x0400293C RID: 10556
		private LuaFunction m_CheckBattleStopEventTrigger_hotfix;

		// Token: 0x0400293D RID: 10557
		private LuaFunction m_CheckMultiEventTrigger_hotfix;

		// Token: 0x0400293E RID: 10558
		private LuaFunction m_IsEventTriggerdInt32_hotfix;

		// Token: 0x0400293F RID: 10559
		private LuaFunction m_GetEventTriggerStateInt32_hotfix;

		// Token: 0x04002940 RID: 10560
		private LuaFunction m_TriggerEventBattleEventTriggerState_hotfix;

		// Token: 0x04002941 RID: 10561
		private LuaFunction m_ExecuteTriggerEventActionsBattleEventTriggerStateInt32_hotfix;

		// Token: 0x04002942 RID: 10562
		private LuaFunction m_ExecuteEventActionConfigDataBattleEventActionInfo_hotfix;

		// Token: 0x04002943 RID: 10563
		private LuaFunction m_ExecuteEventAction_ReliefConfigDataBattleEventActionInfo_hotfix;

		// Token: 0x04002944 RID: 10564
		private LuaFunction m_ExecuteEventAction_RetreatConfigDataBattleEventActionInfo_hotfix;

		// Token: 0x04002945 RID: 10565
		private LuaFunction m_ExecuteEventAction_DialogConfigDataBattleEventActionInfo_hotfix;

		// Token: 0x04002946 RID: 10566
		private LuaFunction m_ExecuteEventAction_ChangeTeamConfigDataBattleEventActionInfo_hotfix;

		// Token: 0x04002947 RID: 10567
		private LuaFunction m_ExecuteEventAction_AttachBuffConfigDataBattleEventActionInfo_hotfix;

		// Token: 0x04002948 RID: 10568
		private LuaFunction m_ExecuteEventAction_ChangeBehaviorConfigDataBattleEventActionInfo_hotfix;

		// Token: 0x04002949 RID: 10569
		private LuaFunction m_ExecuteEventAction_MusicConfigDataBattleEventActionInfo_hotfix;

		// Token: 0x0400294A RID: 10570
		private LuaFunction m_ExecuteEventAction_ChangeTerrainConfigDataBattleEventActionInfo_hotfix;

		// Token: 0x0400294B RID: 10571
		private LuaFunction m_ExecuteEventAction_PerformConfigDataBattleEventActionInfo_hotfix;

		// Token: 0x0400294C RID: 10572
		private LuaFunction m_ExecuteEventAction_RetreatPositionConfigDataBattleEventActionInfo_hotfix;

		// Token: 0x0400294D RID: 10573
		private LuaFunction m_ExecuteEventAction_ReplaceConfigDataBattleEventActionInfo_hotfix;

		// Token: 0x0400294E RID: 10574
		private LuaFunction m_ExecuteEventAction_RemoveBuffConfigDataBattleEventActionInfo_hotfix;

		// Token: 0x0400294F RID: 10575
		private LuaFunction m_ExecuteEventAction_AttachBuffPositionConfigDataBattleEventActionInfo_hotfix;

		// Token: 0x04002950 RID: 10576
		private LuaFunction m_IsEmptyPositionGridPosition_hotfix;

		// Token: 0x04002951 RID: 10577
		private LuaFunction m_GetRandomBattleArmyActorsList;

		// Token: 0x04002952 RID: 10578
		private LuaFunction m_CreateEventActorGridPositionInt32Int32BooleanInt32Int32Int32Int32Int32StringBattleActorSourceType_hotfix;

		// Token: 0x04002953 RID: 10579
		private LuaFunction m_ReplaceEventActorBattleActorInt32Int32String_hotfix;

		// Token: 0x04002954 RID: 10580
		private LuaFunction m_FindEmptyFixedDistancePositionGridPositionInt32_hotfix;

		// Token: 0x04002955 RID: 10581
		private LuaFunction m_FindEmptyFixedDistancePositionGridPositionGridPositionInt32_hotfix;

		// Token: 0x04002956 RID: 10582
		private LuaFunction m_FindEmptyNearPositionGridPositionMoveType_hotfix;

		// Token: 0x04002957 RID: 10583
		private LuaFunction m_CreateMapConfigDataBattlefieldInfo_hotfix;

		// Token: 0x04002958 RID: 10584
		private LuaFunction m_ResetMap_hotfix;

		// Token: 0x04002959 RID: 10585
		private LuaFunction m_SetMyPlayerTeamNumberInt32_hotfix;

		// Token: 0x0400295A RID: 10586
		private LuaFunction m_GetMyPlayerTeamNumber_hotfix;

		// Token: 0x0400295B RID: 10587
		private LuaFunction m_InitBattleConfigDataBattleInfoBattleTypeBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32Int32Int32_hotfix;

		// Token: 0x0400295C RID: 10588
		private LuaFunction m_InitArenaBattleConfigDataArenaBattleInfoBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32ConfigDataArenaDefendRuleInfo_hotfix;

		// Token: 0x0400295D RID: 10589
		private LuaFunction m_InitPVPBattleConfigDataPVPBattleInfoBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32_hotfix;

		// Token: 0x0400295E RID: 10590
		private LuaFunction m_InitRealTimePVPBattleConfigDataRealTimePVPBattleInfoBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32_hotfix;

		// Token: 0x0400295F RID: 10591
		private LuaFunction m_InitRandomNumbersInt32Int32_hotfix;

		// Token: 0x04002960 RID: 10592
		private LuaFunction m_InitPlayersBattlePlayerbe_hotfix;

		// Token: 0x04002961 RID: 10593
		private LuaFunction m_InitWinConditionStatesConfigDataBattleWinConditionInfobe_hotfix;

		// Token: 0x04002962 RID: 10594
		private LuaFunction m_InitLoseConditionStatesConfigDataBattleLoseConditionInfobe_hotfix;

		// Token: 0x04002963 RID: 10595
		private LuaFunction m_InitEventTriggerStatesConfigDataBattleEventTriggerInfobe_hotfix;

		// Token: 0x04002964 RID: 10596
		private LuaFunction m_InitBattleTreasureStatesConfigDataBattleTreasureInfobe_hotfix;

		// Token: 0x04002965 RID: 10597
		private LuaFunction m_CreateActorsInt32List;

		// Token: 0x04002966 RID: 10598
		private LuaFunction m_InitBattleReportConfigDataBattleInfoBattleTypeBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32Int32Int32List;

		// Token: 0x04002967 RID: 10599
		private LuaFunction m_InitArenaBattleReportConfigDataArenaBattleInfoBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32ConfigDataArenaDefendRuleInfoList;

		// Token: 0x04002968 RID: 10600
		private LuaFunction m_InitPVPBattleReportConfigDataPVPBattleInfoBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32List;

		// Token: 0x04002969 RID: 10601
		private LuaFunction m_InitRealTimePVPBattleReportConfigDataRealTimePVPBattleInfoBattleTeamSetupBattleTeamSetupBattlePlayerbeInt32List;

		// Token: 0x0400296A RID: 10602
		private LuaFunction m_InitStarAndAchievementInt32Int32List;

		// Token: 0x0400296B RID: 10603
		private LuaFunction m_InitGainBattleTreasuresList;

		// Token: 0x0400296C RID: 10604
		private LuaFunction m_ExecuteBattlePerformsConfigDataBattlePerformInfo_hotfix;

		// Token: 0x0400296D RID: 10605
		private LuaFunction m_ExecuteAfterCombatSteps_hotfix;

		// Token: 0x0400296E RID: 10606
		private LuaFunction m_ExecuteBattlePerformConfigDataBattlePerformInfo_hotfix;

		// Token: 0x0400296F RID: 10607
		private LuaFunction m_ExecuteBattlePerform_DialogConfigDataBattlePerformInfo_hotfix;

		// Token: 0x04002970 RID: 10608
		private LuaFunction m_ExecuteBattlePerform_PlayMusicConfigDataBattlePerformInfo_hotfix;

		// Token: 0x04002971 RID: 10609
		private LuaFunction m_ExecuteBattlePerform_PlaySoundConfigDataBattlePerformInfo_hotfix;

		// Token: 0x04002972 RID: 10610
		private LuaFunction m_ExecuteBattlePerform_PlayFxConfigDataBattlePerformInfo_hotfix;

		// Token: 0x04002973 RID: 10611
		private LuaFunction m_ExecuteBattlePerform_PlayActorFxConfigDataBattlePerformInfo_hotfix;

		// Token: 0x04002974 RID: 10612
		private LuaFunction m_ExecuteBattlePerform_ChangeTerrainConfigDataBattlePerformInfo_hotfix;

		// Token: 0x04002975 RID: 10613
		private LuaFunction m_ExecuteBattlePerform_CameraFocusPositionConfigDataBattlePerformInfo_hotfix;

		// Token: 0x04002976 RID: 10614
		private LuaFunction m_ExecuteBattlePerform_CameraFocusActorConfigDataBattlePerformInfo_hotfix;

		// Token: 0x04002977 RID: 10615
		private LuaFunction m_ExecuteBattlePerform_CreateActorConfigDataBattlePerformInfo_hotfix;

		// Token: 0x04002978 RID: 10616
		private LuaFunction m_ExecuteBattlePerform_CreateActorNearConfigDataBattlePerformInfo_hotfix;

		// Token: 0x04002979 RID: 10617
		private LuaFunction m_ExecuteBattlePerform_RemoveActorConfigDataBattlePerformInfo_hotfix;

		// Token: 0x0400297A RID: 10618
		private LuaFunction m_ExecuteBattlePerform_ActorMoveConfigDataBattlePerformInfo_hotfix;

		// Token: 0x0400297B RID: 10619
		private LuaFunction m_ExecuteBattlePerform_ActorMoveNearConfigDataBattlePerformInfo_hotfix;

		// Token: 0x0400297C RID: 10620
		private LuaFunction m_ExecuteBattlePerform_ActorAttackConfigDataBattlePerformInfo_hotfix;

		// Token: 0x0400297D RID: 10621
		private LuaFunction m_ExecuteBattlePerform_ActorSkillConfigDataBattlePerformInfo_hotfix;

		// Token: 0x0400297E RID: 10622
		private LuaFunction m_ExecuteBattlePerform_ActorDirConfigDataBattlePerformInfo_hotfix;

		// Token: 0x0400297F RID: 10623
		private LuaFunction m_ExecuteBattlePerform_ActorAnimationConfigDataBattlePerformInfo_hotfix;

		// Token: 0x04002980 RID: 10624
		private LuaFunction m_ExecuteBattlePerform_ActorIdleConfigDataBattlePerformInfo_hotfix;

		// Token: 0x04002981 RID: 10625
		private LuaFunction m_ExecuteBattlePerform_WaitTimeConfigDataBattlePerformInfo_hotfix;

		// Token: 0x04002982 RID: 10626
		private LuaFunction m_ExecuteBattlePerform_StopBattleConfigDataBattlePerformInfo_hotfix;

		// Token: 0x04002983 RID: 10627
		private LuaFunction m_CheckBattleTreasureOnActorMoveBattleActor_hotfix;

		// Token: 0x04002984 RID: 10628
		private LuaFunction m_ChangeBattleTeasureStatusBattleTreasureStateBattleActor_hotfix;

		// Token: 0x04002985 RID: 10629
		private LuaFunction m_IsGainBattleTreasureInt32_hotfix;

		// Token: 0x04002986 RID: 10630
		private LuaFunction m_GetGainBattleTreasures_hotfix;

		// Token: 0x02000388 RID: 904
		public class LuaExportHelper
		{
			// Token: 0x06003581 RID: 13697 RVA: 0x000F0D78 File Offset: 0x000EEF78
			public LuaExportHelper(BattleBase owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17000ECF RID: 3791
			// (get) Token: 0x06003582 RID: 13698 RVA: 0x000F0D88 File Offset: 0x000EEF88
			// (set) Token: 0x06003583 RID: 13699 RVA: 0x000F0D98 File Offset: 0x000EEF98
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

			// Token: 0x17000ED0 RID: 3792
			// (get) Token: 0x06003584 RID: 13700 RVA: 0x000F0DA8 File Offset: 0x000EEFA8
			// (set) Token: 0x06003585 RID: 13701 RVA: 0x000F0DB8 File Offset: 0x000EEFB8
			public IBattleListener m_battleListener
			{
				get
				{
					return this.m_owner.m_battleListener;
				}
				set
				{
					this.m_owner.m_battleListener = value;
				}
			}

			// Token: 0x17000ED1 RID: 3793
			// (get) Token: 0x06003586 RID: 13702 RVA: 0x000F0DC8 File Offset: 0x000EEFC8
			// (set) Token: 0x06003587 RID: 13703 RVA: 0x000F0DD8 File Offset: 0x000EEFD8
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

			// Token: 0x17000ED2 RID: 3794
			// (get) Token: 0x06003588 RID: 13704 RVA: 0x000F0DE8 File Offset: 0x000EEFE8
			// (set) Token: 0x06003589 RID: 13705 RVA: 0x000F0DF8 File Offset: 0x000EEFF8
			public RandomNumber m_aiRandomNumber1
			{
				get
				{
					return this.m_owner.m_aiRandomNumber1;
				}
				set
				{
					this.m_owner.m_aiRandomNumber1 = value;
				}
			}

			// Token: 0x17000ED3 RID: 3795
			// (get) Token: 0x0600358A RID: 13706 RVA: 0x000F0E08 File Offset: 0x000EF008
			// (set) Token: 0x0600358B RID: 13707 RVA: 0x000F0E18 File Offset: 0x000EF018
			public RandomNumber m_aiRandomNumber2
			{
				get
				{
					return this.m_owner.m_aiRandomNumber2;
				}
				set
				{
					this.m_owner.m_aiRandomNumber2 = value;
				}
			}

			// Token: 0x17000ED4 RID: 3796
			// (get) Token: 0x0600358C RID: 13708 RVA: 0x000F0E28 File Offset: 0x000EF028
			// (set) Token: 0x0600358D RID: 13709 RVA: 0x000F0E38 File Offset: 0x000EF038
			public RandomNumber m_armyRandomNumber
			{
				get
				{
					return this.m_owner.m_armyRandomNumber;
				}
				set
				{
					this.m_owner.m_armyRandomNumber = value;
				}
			}

			// Token: 0x17000ED5 RID: 3797
			// (get) Token: 0x0600358E RID: 13710 RVA: 0x000F0E48 File Offset: 0x000EF048
			// (set) Token: 0x0600358F RID: 13711 RVA: 0x000F0E58 File Offset: 0x000EF058
			public BattleMap m_map
			{
				get
				{
					return this.m_owner.m_map;
				}
				set
				{
					this.m_owner.m_map = value;
				}
			}

			// Token: 0x17000ED6 RID: 3798
			// (get) Token: 0x06003590 RID: 13712 RVA: 0x000F0E68 File Offset: 0x000EF068
			// (set) Token: 0x06003591 RID: 13713 RVA: 0x000F0E78 File Offset: 0x000EF078
			public Pathfinder m_pathfinder
			{
				get
				{
					return this.m_owner.m_pathfinder;
				}
				set
				{
					this.m_owner.m_pathfinder = value;
				}
			}

			// Token: 0x17000ED7 RID: 3799
			// (get) Token: 0x06003592 RID: 13714 RVA: 0x000F0E88 File Offset: 0x000EF088
			// (set) Token: 0x06003593 RID: 13715 RVA: 0x000F0E98 File Offset: 0x000EF098
			public Combat m_combat
			{
				get
				{
					return this.m_owner.m_combat;
				}
				set
				{
					this.m_owner.m_combat = value;
				}
			}

			// Token: 0x17000ED8 RID: 3800
			// (get) Token: 0x06003594 RID: 13716 RVA: 0x000F0EA8 File Offset: 0x000EF0A8
			// (set) Token: 0x06003595 RID: 13717 RVA: 0x000F0EB8 File Offset: 0x000EF0B8
			public ConfigDataBattlefieldInfo m_battlefieldInfo
			{
				get
				{
					return this.m_owner.m_battlefieldInfo;
				}
				set
				{
					this.m_owner.m_battlefieldInfo = value;
				}
			}

			// Token: 0x17000ED9 RID: 3801
			// (get) Token: 0x06003596 RID: 13718 RVA: 0x000F0EC8 File Offset: 0x000EF0C8
			// (set) Token: 0x06003597 RID: 13719 RVA: 0x000F0ED8 File Offset: 0x000EF0D8
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

			// Token: 0x17000EDA RID: 3802
			// (get) Token: 0x06003598 RID: 13720 RVA: 0x000F0EE8 File Offset: 0x000EF0E8
			// (set) Token: 0x06003599 RID: 13721 RVA: 0x000F0EF8 File Offset: 0x000EF0F8
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

			// Token: 0x17000EDB RID: 3803
			// (get) Token: 0x0600359A RID: 13722 RVA: 0x000F0F08 File Offset: 0x000EF108
			// (set) Token: 0x0600359B RID: 13723 RVA: 0x000F0F18 File Offset: 0x000EF118
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

			// Token: 0x17000EDC RID: 3804
			// (get) Token: 0x0600359C RID: 13724 RVA: 0x000F0F28 File Offset: 0x000EF128
			// (set) Token: 0x0600359D RID: 13725 RVA: 0x000F0F38 File Offset: 0x000EF138
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

			// Token: 0x17000EDD RID: 3805
			// (get) Token: 0x0600359E RID: 13726 RVA: 0x000F0F48 File Offset: 0x000EF148
			// (set) Token: 0x0600359F RID: 13727 RVA: 0x000F0F58 File Offset: 0x000EF158
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

			// Token: 0x17000EDE RID: 3806
			// (get) Token: 0x060035A0 RID: 13728 RVA: 0x000F0F68 File Offset: 0x000EF168
			// (set) Token: 0x060035A1 RID: 13729 RVA: 0x000F0F78 File Offset: 0x000EF178
			public int m_monsterLevel
			{
				get
				{
					return this.m_owner.m_monsterLevel;
				}
				set
				{
					this.m_owner.m_monsterLevel = value;
				}
			}

			// Token: 0x17000EDF RID: 3807
			// (get) Token: 0x060035A2 RID: 13730 RVA: 0x000F0F88 File Offset: 0x000EF188
			// (set) Token: 0x060035A3 RID: 13731 RVA: 0x000F0F98 File Offset: 0x000EF198
			public BattleTeam[] m_teams
			{
				get
				{
					return this.m_owner.m_teams;
				}
				set
				{
					this.m_owner.m_teams = value;
				}
			}

			// Token: 0x17000EE0 RID: 3808
			// (get) Token: 0x060035A4 RID: 13732 RVA: 0x000F0FA8 File Offset: 0x000EF1A8
			// (set) Token: 0x060035A5 RID: 13733 RVA: 0x000F0FB8 File Offset: 0x000EF1B8
			public BattlePlayer[] m_players
			{
				get
				{
					return this.m_owner.m_players;
				}
				set
				{
					this.m_owner.m_players = value;
				}
			}

			// Token: 0x17000EE1 RID: 3809
			// (get) Token: 0x060035A6 RID: 13734 RVA: 0x000F0FC8 File Offset: 0x000EF1C8
			// (set) Token: 0x060035A7 RID: 13735 RVA: 0x000F0FD8 File Offset: 0x000EF1D8
			public ConfigDataPlayerLevelInfo m_maxPlayerLevelInfo
			{
				get
				{
					return this.m_owner.m_maxPlayerLevelInfo;
				}
				set
				{
					this.m_owner.m_maxPlayerLevelInfo = value;
				}
			}

			// Token: 0x17000EE2 RID: 3810
			// (get) Token: 0x060035A8 RID: 13736 RVA: 0x000F0FE8 File Offset: 0x000EF1E8
			// (set) Token: 0x060035A9 RID: 13737 RVA: 0x000F0FF8 File Offset: 0x000EF1F8
			public BattleState m_state
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

			// Token: 0x17000EE3 RID: 3811
			// (get) Token: 0x060035AA RID: 13738 RVA: 0x000F1008 File Offset: 0x000EF208
			// (set) Token: 0x060035AB RID: 13739 RVA: 0x000F1018 File Offset: 0x000EF218
			public int m_step
			{
				get
				{
					return this.m_owner.m_step;
				}
				set
				{
					this.m_owner.m_step = value;
				}
			}

			// Token: 0x17000EE4 RID: 3812
			// (get) Token: 0x060035AC RID: 13740 RVA: 0x000F1028 File Offset: 0x000EF228
			// (set) Token: 0x060035AD RID: 13741 RVA: 0x000F1038 File Offset: 0x000EF238
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

			// Token: 0x17000EE5 RID: 3813
			// (get) Token: 0x060035AE RID: 13742 RVA: 0x000F1048 File Offset: 0x000EF248
			// (set) Token: 0x060035AF RID: 13743 RVA: 0x000F1058 File Offset: 0x000EF258
			public int m_turnMax
			{
				get
				{
					return this.m_owner.m_turnMax;
				}
				set
				{
					this.m_owner.m_turnMax = value;
				}
			}

			// Token: 0x17000EE6 RID: 3814
			// (get) Token: 0x060035B0 RID: 13744 RVA: 0x000F1068 File Offset: 0x000EF268
			// (set) Token: 0x060035B1 RID: 13745 RVA: 0x000F1078 File Offset: 0x000EF278
			public int m_actionTeam
			{
				get
				{
					return this.m_owner.m_actionTeam;
				}
				set
				{
					this.m_owner.m_actionTeam = value;
				}
			}

			// Token: 0x17000EE7 RID: 3815
			// (get) Token: 0x060035B2 RID: 13746 RVA: 0x000F1088 File Offset: 0x000EF288
			// (set) Token: 0x060035B3 RID: 13747 RVA: 0x000F1098 File Offset: 0x000EF298
			public int m_prevActionPlayerIndex
			{
				get
				{
					return this.m_owner.m_prevActionPlayerIndex;
				}
				set
				{
					this.m_owner.m_prevActionPlayerIndex = value;
				}
			}

			// Token: 0x17000EE8 RID: 3816
			// (get) Token: 0x060035B4 RID: 13748 RVA: 0x000F10A8 File Offset: 0x000EF2A8
			// (set) Token: 0x060035B5 RID: 13749 RVA: 0x000F10B8 File Offset: 0x000EF2B8
			public BattleActor m_actionActor
			{
				get
				{
					return this.m_owner.m_actionActor;
				}
				set
				{
					this.m_owner.m_actionActor = value;
				}
			}

			// Token: 0x17000EE9 RID: 3817
			// (get) Token: 0x060035B6 RID: 13750 RVA: 0x000F10C8 File Offset: 0x000EF2C8
			// (set) Token: 0x060035B7 RID: 13751 RVA: 0x000F10D8 File Offset: 0x000EF2D8
			public ActionOrderType m_actionOrderType
			{
				get
				{
					return this.m_owner.m_actionOrderType;
				}
				set
				{
					this.m_owner.m_actionOrderType = value;
				}
			}

			// Token: 0x17000EEA RID: 3818
			// (get) Token: 0x060035B8 RID: 13752 RVA: 0x000F10E8 File Offset: 0x000EF2E8
			// (set) Token: 0x060035B9 RID: 13753 RVA: 0x000F10F8 File Offset: 0x000EF2F8
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

			// Token: 0x17000EEB RID: 3819
			// (get) Token: 0x060035BA RID: 13754 RVA: 0x000F1108 File Offset: 0x000EF308
			// (set) Token: 0x060035BB RID: 13755 RVA: 0x000F1118 File Offset: 0x000EF318
			public bool m_needCheckBattleStopEventTrigger
			{
				get
				{
					return this.m_owner.m_needCheckBattleStopEventTrigger;
				}
				set
				{
					this.m_owner.m_needCheckBattleStopEventTrigger = value;
				}
			}

			// Token: 0x17000EEC RID: 3820
			// (get) Token: 0x060035BC RID: 13756 RVA: 0x000F1128 File Offset: 0x000EF328
			// (set) Token: 0x060035BD RID: 13757 RVA: 0x000F1138 File Offset: 0x000EF338
			public bool m_isGiveupBattle
			{
				get
				{
					return this.m_owner.m_isGiveupBattle;
				}
				set
				{
					this.m_owner.m_isGiveupBattle = value;
				}
			}

			// Token: 0x17000EED RID: 3821
			// (get) Token: 0x060035BE RID: 13758 RVA: 0x000F1148 File Offset: 0x000EF348
			// (set) Token: 0x060035BF RID: 13759 RVA: 0x000F1158 File Offset: 0x000EF358
			public int m_giveupBattlePlayerIndex
			{
				get
				{
					return this.m_owner.m_giveupBattlePlayerIndex;
				}
				set
				{
					this.m_owner.m_giveupBattlePlayerIndex = value;
				}
			}

			// Token: 0x17000EEE RID: 3822
			// (get) Token: 0x060035C0 RID: 13760 RVA: 0x000F1168 File Offset: 0x000EF368
			// (set) Token: 0x060035C1 RID: 13761 RVA: 0x000F1178 File Offset: 0x000EF378
			public int m_combatRandomSeed
			{
				get
				{
					return this.m_owner.m_combatRandomSeed;
				}
				set
				{
					this.m_owner.m_combatRandomSeed = value;
				}
			}

			// Token: 0x17000EEF RID: 3823
			// (get) Token: 0x060035C2 RID: 13762 RVA: 0x000F1188 File Offset: 0x000EF388
			// (set) Token: 0x060035C3 RID: 13763 RVA: 0x000F1198 File Offset: 0x000EF398
			public BattleActor m_combatActorA
			{
				get
				{
					return this.m_owner.m_combatActorA;
				}
				set
				{
					this.m_owner.m_combatActorA = value;
				}
			}

			// Token: 0x17000EF0 RID: 3824
			// (get) Token: 0x060035C4 RID: 13764 RVA: 0x000F11A8 File Offset: 0x000EF3A8
			// (set) Token: 0x060035C5 RID: 13765 RVA: 0x000F11B8 File Offset: 0x000EF3B8
			public BattleActor m_combatActorB
			{
				get
				{
					return this.m_owner.m_combatActorB;
				}
				set
				{
					this.m_owner.m_combatActorB = value;
				}
			}

			// Token: 0x17000EF1 RID: 3825
			// (get) Token: 0x060035C6 RID: 13766 RVA: 0x000F11C8 File Offset: 0x000EF3C8
			// (set) Token: 0x060035C7 RID: 13767 RVA: 0x000F11D8 File Offset: 0x000EF3D8
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

			// Token: 0x17000EF2 RID: 3826
			// (get) Token: 0x060035C8 RID: 13768 RVA: 0x000F11E8 File Offset: 0x000EF3E8
			// (set) Token: 0x060035C9 RID: 13769 RVA: 0x000F11F8 File Offset: 0x000EF3F8
			public BattleActor m_beGuardedCombatActor
			{
				get
				{
					return this.m_owner.m_beGuardedCombatActor;
				}
				set
				{
					this.m_owner.m_beGuardedCombatActor = value;
				}
			}

			// Token: 0x17000EF3 RID: 3827
			// (get) Token: 0x060035CA RID: 13770 RVA: 0x000F1208 File Offset: 0x000EF408
			// (set) Token: 0x060035CB RID: 13771 RVA: 0x000F1218 File Offset: 0x000EF418
			public bool m_isPerformCombat
			{
				get
				{
					return this.m_owner.m_isPerformCombat;
				}
				set
				{
					this.m_owner.m_isPerformCombat = value;
				}
			}

			// Token: 0x17000EF4 RID: 3828
			// (get) Token: 0x060035CC RID: 13772 RVA: 0x000F1228 File Offset: 0x000EF428
			// (set) Token: 0x060035CD RID: 13773 RVA: 0x000F1238 File Offset: 0x000EF438
			public ConfigDataBattlePerformInfo m_afterComatPerform
			{
				get
				{
					return this.m_owner.m_afterComatPerform;
				}
				set
				{
					this.m_owner.m_afterComatPerform = value;
				}
			}

			// Token: 0x17000EF5 RID: 3829
			// (get) Token: 0x060035CE RID: 13774 RVA: 0x000F1248 File Offset: 0x000EF448
			// (set) Token: 0x060035CF RID: 13775 RVA: 0x000F1258 File Offset: 0x000EF458
			public BattleEventTriggerState m_afterCombatExecuteTriggerState
			{
				get
				{
					return this.m_owner.m_afterCombatExecuteTriggerState;
				}
				set
				{
					this.m_owner.m_afterCombatExecuteTriggerState = value;
				}
			}

			// Token: 0x17000EF6 RID: 3830
			// (get) Token: 0x060035D0 RID: 13776 RVA: 0x000F1268 File Offset: 0x000EF468
			// (set) Token: 0x060035D1 RID: 13777 RVA: 0x000F1278 File Offset: 0x000EF478
			public int m_afterCombatExecuteTriggerEventActionIndex
			{
				get
				{
					return this.m_owner.m_afterCombatExecuteTriggerEventActionIndex;
				}
				set
				{
					this.m_owner.m_afterCombatExecuteTriggerEventActionIndex = value;
				}
			}

			// Token: 0x17000EF7 RID: 3831
			// (get) Token: 0x060035D2 RID: 13778 RVA: 0x000F1288 File Offset: 0x000EF488
			// (set) Token: 0x060035D3 RID: 13779 RVA: 0x000F1298 File Offset: 0x000EF498
			public bool m_isAfterCombatNextStep
			{
				get
				{
					return this.m_owner.m_isAfterCombatNextStep;
				}
				set
				{
					this.m_owner.m_isAfterCombatNextStep = value;
				}
			}

			// Token: 0x17000EF8 RID: 3832
			// (get) Token: 0x060035D4 RID: 13780 RVA: 0x000F12A8 File Offset: 0x000EF4A8
			// (set) Token: 0x060035D5 RID: 13781 RVA: 0x000F12B8 File Offset: 0x000EF4B8
			public bool m_isAfterCombatNextStepActorActive
			{
				get
				{
					return this.m_owner.m_isAfterCombatNextStepActorActive;
				}
				set
				{
					this.m_owner.m_isAfterCombatNextStepActorActive = value;
				}
			}

			// Token: 0x17000EF9 RID: 3833
			// (get) Token: 0x060035D6 RID: 13782 RVA: 0x000F12C8 File Offset: 0x000EF4C8
			// (set) Token: 0x060035D7 RID: 13783 RVA: 0x000F12D8 File Offset: 0x000EF4D8
			public List<int>[] m_tempIntLists
			{
				get
				{
					return this.m_owner.m_tempIntLists;
				}
				set
				{
					this.m_owner.m_tempIntLists = value;
				}
			}

			// Token: 0x17000EFA RID: 3834
			// (get) Token: 0x060035D8 RID: 13784 RVA: 0x000F12E8 File Offset: 0x000EF4E8
			// (set) Token: 0x060035D9 RID: 13785 RVA: 0x000F12F8 File Offset: 0x000EF4F8
			public int m_freeIntListIndex
			{
				get
				{
					return this.m_owner.m_freeIntListIndex;
				}
				set
				{
					this.m_owner.m_freeIntListIndex = value;
				}
			}

			// Token: 0x17000EFB RID: 3835
			// (get) Token: 0x060035DA RID: 13786 RVA: 0x000F1308 File Offset: 0x000EF508
			// (set) Token: 0x060035DB RID: 13787 RVA: 0x000F1318 File Offset: 0x000EF518
			public List<GridPosition>[] m_tempGridPositionLists
			{
				get
				{
					return this.m_owner.m_tempGridPositionLists;
				}
				set
				{
					this.m_owner.m_tempGridPositionLists = value;
				}
			}

			// Token: 0x17000EFC RID: 3836
			// (get) Token: 0x060035DC RID: 13788 RVA: 0x000F1328 File Offset: 0x000EF528
			// (set) Token: 0x060035DD RID: 13789 RVA: 0x000F1338 File Offset: 0x000EF538
			public int m_freeGridPositionListIndex
			{
				get
				{
					return this.m_owner.m_freeGridPositionListIndex;
				}
				set
				{
					this.m_owner.m_freeGridPositionListIndex = value;
				}
			}

			// Token: 0x17000EFD RID: 3837
			// (get) Token: 0x060035DE RID: 13790 RVA: 0x000F1348 File Offset: 0x000EF548
			// (set) Token: 0x060035DF RID: 13791 RVA: 0x000F1358 File Offset: 0x000EF558
			public List<BattleActor>[] m_tempActorLists
			{
				get
				{
					return this.m_owner.m_tempActorLists;
				}
				set
				{
					this.m_owner.m_tempActorLists = value;
				}
			}

			// Token: 0x17000EFE RID: 3838
			// (get) Token: 0x060035E0 RID: 13792 RVA: 0x000F1368 File Offset: 0x000EF568
			// (set) Token: 0x060035E1 RID: 13793 RVA: 0x000F1378 File Offset: 0x000EF578
			public int m_freeActorListIndex
			{
				get
				{
					return this.m_owner.m_freeActorListIndex;
				}
				set
				{
					this.m_owner.m_freeActorListIndex = value;
				}
			}

			// Token: 0x17000EFF RID: 3839
			// (get) Token: 0x060035E2 RID: 13794 RVA: 0x000F1388 File Offset: 0x000EF588
			// (set) Token: 0x060035E3 RID: 13795 RVA: 0x000F1398 File Offset: 0x000EF598
			public List<ConfigDataBuffInfo>[] m_tempBuffLists
			{
				get
				{
					return this.m_owner.m_tempBuffLists;
				}
				set
				{
					this.m_owner.m_tempBuffLists = value;
				}
			}

			// Token: 0x17000F00 RID: 3840
			// (get) Token: 0x060035E4 RID: 13796 RVA: 0x000F13A8 File Offset: 0x000EF5A8
			// (set) Token: 0x060035E5 RID: 13797 RVA: 0x000F13B8 File Offset: 0x000EF5B8
			public int m_freeBuffListIndex
			{
				get
				{
					return this.m_owner.m_freeBuffListIndex;
				}
				set
				{
					this.m_owner.m_freeBuffListIndex = value;
				}
			}

			// Token: 0x17000F01 RID: 3841
			// (get) Token: 0x060035E6 RID: 13798 RVA: 0x000F13C8 File Offset: 0x000EF5C8
			// (set) Token: 0x060035E7 RID: 13799 RVA: 0x000F13D8 File Offset: 0x000EF5D8
			public List<BuffState>[] m_tempBuffStateLists
			{
				get
				{
					return this.m_owner.m_tempBuffStateLists;
				}
				set
				{
					this.m_owner.m_tempBuffStateLists = value;
				}
			}

			// Token: 0x17000F02 RID: 3842
			// (get) Token: 0x060035E8 RID: 13800 RVA: 0x000F13E8 File Offset: 0x000EF5E8
			// (set) Token: 0x060035E9 RID: 13801 RVA: 0x000F13F8 File Offset: 0x000EF5F8
			public int m_freeBuffStateListIndex
			{
				get
				{
					return this.m_owner.m_freeBuffStateListIndex;
				}
				set
				{
					this.m_owner.m_freeBuffStateListIndex = value;
				}
			}

			// Token: 0x17000F03 RID: 3843
			// (get) Token: 0x060035EA RID: 13802 RVA: 0x000F1408 File Offset: 0x000EF608
			// (set) Token: 0x060035EB RID: 13803 RVA: 0x000F1418 File Offset: 0x000EF618
			public BattlePropertyModifier m_tempBattlePropertyModifier
			{
				get
				{
					return this.m_owner.m_tempBattlePropertyModifier;
				}
				set
				{
					this.m_owner.m_tempBattlePropertyModifier = value;
				}
			}

			// Token: 0x17000F04 RID: 3844
			// (get) Token: 0x060035EC RID: 13804 RVA: 0x000F1428 File Offset: 0x000EF628
			// (set) Token: 0x060035ED RID: 13805 RVA: 0x000F1438 File Offset: 0x000EF638
			public LinkedList<BattleCommand> m_battleCommands
			{
				get
				{
					return this.m_owner.m_battleCommands;
				}
				set
				{
					this.m_owner.m_battleCommands = value;
				}
			}

			// Token: 0x17000F05 RID: 3845
			// (get) Token: 0x060035EE RID: 13806 RVA: 0x000F1448 File Offset: 0x000EF648
			// (set) Token: 0x060035EF RID: 13807 RVA: 0x000F1458 File Offset: 0x000EF658
			public LinkedList<BattleCommand> m_logBattleCommands
			{
				get
				{
					return this.m_owner.m_logBattleCommands;
				}
				set
				{
					this.m_owner.m_logBattleCommands = value;
				}
			}

			// Token: 0x17000F06 RID: 3846
			// (get) Token: 0x060035F0 RID: 13808 RVA: 0x000F1468 File Offset: 0x000EF668
			// (set) Token: 0x060035F1 RID: 13809 RVA: 0x000F1478 File Offset: 0x000EF678
			public LinkedList<BattleCommand> m_tempBattleCommands
			{
				get
				{
					return this.m_owner.m_tempBattleCommands;
				}
				set
				{
					this.m_owner.m_tempBattleCommands = value;
				}
			}

			// Token: 0x17000F07 RID: 3847
			// (get) Token: 0x060035F2 RID: 13810 RVA: 0x000F1488 File Offset: 0x000EF688
			// (set) Token: 0x060035F3 RID: 13811 RVA: 0x000F1498 File Offset: 0x000EF698
			public List<BattleCommand> m_stepExecutedCommands
			{
				get
				{
					return this.m_owner.m_stepExecutedCommands;
				}
				set
				{
					this.m_owner.m_stepExecutedCommands = value;
				}
			}

			// Token: 0x17000F08 RID: 3848
			// (get) Token: 0x060035F4 RID: 13812 RVA: 0x000F14A8 File Offset: 0x000EF6A8
			// (set) Token: 0x060035F5 RID: 13813 RVA: 0x000F14B8 File Offset: 0x000EF6B8
			public bool m_enableLogBattleCommands
			{
				get
				{
					return this.m_owner.m_enableLogBattleCommands;
				}
				set
				{
					this.m_owner.m_enableLogBattleCommands = value;
				}
			}

			// Token: 0x17000F09 RID: 3849
			// (get) Token: 0x060035F6 RID: 13814 RVA: 0x000F14C8 File Offset: 0x000EF6C8
			// (set) Token: 0x060035F7 RID: 13815 RVA: 0x000F14D8 File Offset: 0x000EF6D8
			public bool m_enableTempBattleCommands
			{
				get
				{
					return this.m_owner.m_enableTempBattleCommands;
				}
				set
				{
					this.m_owner.m_enableTempBattleCommands = value;
				}
			}

			// Token: 0x17000F0A RID: 3850
			// (get) Token: 0x060035F8 RID: 13816 RVA: 0x000F14E8 File Offset: 0x000EF6E8
			// (set) Token: 0x060035F9 RID: 13817 RVA: 0x000F14F8 File Offset: 0x000EF6F8
			public bool m_enableDebugLog
			{
				get
				{
					return this.m_owner.m_enableDebugLog;
				}
				set
				{
					this.m_owner.m_enableDebugLog = value;
				}
			}

			// Token: 0x17000F0B RID: 3851
			// (get) Token: 0x060035FA RID: 13818 RVA: 0x000F1508 File Offset: 0x000EF708
			// (set) Token: 0x060035FB RID: 13819 RVA: 0x000F1518 File Offset: 0x000EF718
			public bool m_enableChecksum
			{
				get
				{
					return this.m_owner.m_enableChecksum;
				}
				set
				{
					this.m_owner.m_enableChecksum = value;
				}
			}

			// Token: 0x17000F0C RID: 3852
			// (get) Token: 0x060035FC RID: 13820 RVA: 0x000F1528 File Offset: 0x000EF728
			// (set) Token: 0x060035FD RID: 13821 RVA: 0x000F1538 File Offset: 0x000EF738
			public List<int> m_checksums
			{
				get
				{
					return this.m_owner.m_checksums;
				}
				set
				{
					this.m_owner.m_checksums = value;
				}
			}

			// Token: 0x17000F0D RID: 3853
			// (get) Token: 0x060035FE RID: 13822 RVA: 0x000F1548 File Offset: 0x000EF748
			// (set) Token: 0x060035FF RID: 13823 RVA: 0x000F1558 File Offset: 0x000EF758
			public List<BattleWinConditionState> m_winConditionStates
			{
				get
				{
					return this.m_owner.m_winConditionStates;
				}
				set
				{
					this.m_owner.m_winConditionStates = value;
				}
			}

			// Token: 0x17000F0E RID: 3854
			// (get) Token: 0x06003600 RID: 13824 RVA: 0x000F1568 File Offset: 0x000EF768
			// (set) Token: 0x06003601 RID: 13825 RVA: 0x000F1578 File Offset: 0x000EF778
			public List<BattleLoseConditionState> m_loseConditionStates
			{
				get
				{
					return this.m_owner.m_loseConditionStates;
				}
				set
				{
					this.m_owner.m_loseConditionStates = value;
				}
			}

			// Token: 0x17000F0F RID: 3855
			// (get) Token: 0x06003602 RID: 13826 RVA: 0x000F1588 File Offset: 0x000EF788
			// (set) Token: 0x06003603 RID: 13827 RVA: 0x000F1598 File Offset: 0x000EF798
			public List<BattleAchievementState> m_achievementStates
			{
				get
				{
					return this.m_owner.m_achievementStates;
				}
				set
				{
					this.m_owner.m_achievementStates = value;
				}
			}

			// Token: 0x17000F10 RID: 3856
			// (get) Token: 0x06003604 RID: 13828 RVA: 0x000F15A8 File Offset: 0x000EF7A8
			// (set) Token: 0x06003605 RID: 13829 RVA: 0x000F15B8 File Offset: 0x000EF7B8
			public List<BattleEventTriggerState> m_eventTriggerStates
			{
				get
				{
					return this.m_owner.m_eventTriggerStates;
				}
				set
				{
					this.m_owner.m_eventTriggerStates = value;
				}
			}

			// Token: 0x17000F11 RID: 3857
			// (get) Token: 0x06003606 RID: 13830 RVA: 0x000F15C8 File Offset: 0x000EF7C8
			// (set) Token: 0x06003607 RID: 13831 RVA: 0x000F15D8 File Offset: 0x000EF7D8
			public List<BattleTreasureState> m_battleTreasureStates
			{
				get
				{
					return this.m_owner.m_battleTreasureStates;
				}
				set
				{
					this.m_owner.m_battleTreasureStates = value;
				}
			}

			// Token: 0x17000F12 RID: 3858
			// (get) Token: 0x06003608 RID: 13832 RVA: 0x000F15E8 File Offset: 0x000EF7E8
			// (set) Token: 0x06003609 RID: 13833 RVA: 0x000F15F8 File Offset: 0x000EF7F8
			public int m_stars
			{
				get
				{
					return this.m_owner.m_stars;
				}
				set
				{
					this.m_owner.m_stars = value;
				}
			}

			// Token: 0x17000F13 RID: 3859
			// (get) Token: 0x0600360A RID: 13834 RVA: 0x000F1608 File Offset: 0x000EF808
			// (set) Token: 0x0600360B RID: 13835 RVA: 0x000F1618 File Offset: 0x000EF818
			public int m_starTurnMax
			{
				get
				{
					return this.m_owner.m_starTurnMax;
				}
				set
				{
					this.m_owner.m_starTurnMax = value;
				}
			}

			// Token: 0x17000F14 RID: 3860
			// (get) Token: 0x0600360C RID: 13836 RVA: 0x000F1628 File Offset: 0x000EF828
			// (set) Token: 0x0600360D RID: 13837 RVA: 0x000F1638 File Offset: 0x000EF838
			public int m_starDeadMax
			{
				get
				{
					return this.m_owner.m_starDeadMax;
				}
				set
				{
					this.m_owner.m_starDeadMax = value;
				}
			}

			// Token: 0x17000F15 RID: 3861
			// (get) Token: 0x0600360E RID: 13838 RVA: 0x000F1648 File Offset: 0x000EF848
			// (set) Token: 0x0600360F RID: 13839 RVA: 0x000F1658 File Offset: 0x000EF858
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

			// Token: 0x06003610 RID: 13840 RVA: 0x000F1668 File Offset: 0x000EF868
			public void Stop(bool win)
			{
				this.m_owner.Stop(win);
			}

			// Token: 0x06003611 RID: 13841 RVA: 0x000F1678 File Offset: 0x000EF878
			public void NextStep()
			{
				this.m_owner.NextStep();
			}

			// Token: 0x06003612 RID: 13842 RVA: 0x000F1688 File Offset: 0x000EF888
			public void NextStep_Normal(BattleActor actionActor)
			{
				this.m_owner.NextStep_Normal(actionActor);
			}

			// Token: 0x06003613 RID: 13843 RVA: 0x000F1698 File Offset: 0x000EF898
			public void NextStep_Pvp(BattleActor actionActor)
			{
				this.m_owner.NextStep_Pvp(actionActor);
			}

			// Token: 0x06003614 RID: 13844 RVA: 0x000F16A8 File Offset: 0x000EF8A8
			public void NextStepActorActive()
			{
				this.m_owner.NextStepActorActive();
			}

			// Token: 0x06003615 RID: 13845 RVA: 0x000F16B8 File Offset: 0x000EF8B8
			public void NextTurn()
			{
				this.m_owner.NextTurn();
			}

			// Token: 0x06003616 RID: 13846 RVA: 0x000F16C8 File Offset: 0x000EF8C8
			public BattleActor GetDefaultActionActor(int team)
			{
				return this.m_owner.GetDefaultActionActor(team);
			}

			// Token: 0x06003617 RID: 13847 RVA: 0x000F16D8 File Offset: 0x000EF8D8
			public bool HasNotActionFinishedActor()
			{
				return this.m_owner.HasNotActionFinishedActor();
			}

			// Token: 0x06003618 RID: 13848 RVA: 0x000F16E8 File Offset: 0x000EF8E8
			public BattleActor GetAliveActorByHeroId(int heroId)
			{
				return this.m_owner.GetAliveActorByHeroId(heroId);
			}

			// Token: 0x06003619 RID: 13849 RVA: 0x000F16F8 File Offset: 0x000EF8F8
			public void GetAliveActorsByHeroIdsAndGroupIds(List<int> heroIds, List<int> groupIds, List<BattleActor> actors)
			{
				this.m_owner.GetAliveActorsByHeroIdsAndGroupIds(heroIds, groupIds, actors);
			}

			// Token: 0x0600361A RID: 13850 RVA: 0x000F1708 File Offset: 0x000EF908
			public void ComputeStepChecksum()
			{
				this.m_owner.ComputeStepChecksum();
			}

			// Token: 0x0600361B RID: 13851 RVA: 0x000F1718 File Offset: 0x000EF918
			public void CheckAchievementOnActorMove(BattleActor actor)
			{
				this.m_owner.CheckAchievementOnActorMove(actor);
			}

			// Token: 0x0600361C RID: 13852 RVA: 0x000F1728 File Offset: 0x000EF928
			public void CheckAchievementOnActorDie(BattleActor actor)
			{
				this.m_owner.CheckAchievementOnActorDie(actor);
			}

			// Token: 0x0600361D RID: 13853 RVA: 0x000F1738 File Offset: 0x000EF938
			public void CheckAchievementOnNextStep()
			{
				this.m_owner.CheckAchievementOnNextStep();
			}

			// Token: 0x0600361E RID: 13854 RVA: 0x000F1748 File Offset: 0x000EF948
			public void CheckAchievementOnTurnEndOrWin(bool isWin)
			{
				this.m_owner.CheckAchievementOnTurnEndOrWin(isWin);
			}

			// Token: 0x0600361F RID: 13855 RVA: 0x000F1758 File Offset: 0x000EF958
			public void CheckAchievementOnWin()
			{
				this.m_owner.CheckAchievementOnWin();
			}

			// Token: 0x06003620 RID: 13856 RVA: 0x000F1768 File Offset: 0x000EF968
			public void CheckAchievementOnLose()
			{
				this.m_owner.CheckAchievementOnLose();
			}

			// Token: 0x06003621 RID: 13857 RVA: 0x000F1778 File Offset: 0x000EF978
			public void ChangeAchievementStatus(BattleAchievementState bs, bool success)
			{
				this.m_owner.ChangeAchievementStatus(bs, success);
			}

			// Token: 0x06003622 RID: 13858 RVA: 0x000F1788 File Offset: 0x000EF988
			public bool IsActorsAllAlive(List<int> heroIds)
			{
				return this.m_owner.IsActorsAllAlive(heroIds);
			}

			// Token: 0x06003623 RID: 13859 RVA: 0x000F1798 File Offset: 0x000EF998
			public bool IsActorsAllKillBySkillClass(List<int> heroIds, int skillClass)
			{
				return this.m_owner.IsActorsAllKillBySkillClass(heroIds, skillClass);
			}

			// Token: 0x06003624 RID: 13860 RVA: 0x000F17A8 File Offset: 0x000EF9A8
			public bool IsActorReachPositions(BattleActor a, List<ParamPosition> positions, int conditionId)
			{
				return this.m_owner.IsActorReachPositions(a, positions, conditionId);
			}

			// Token: 0x06003625 RID: 13861 RVA: 0x000F17B8 File Offset: 0x000EF9B8
			public bool IsActorReachPositions(BattleActor a, NpcCondition npcCondition, List<ParamPosition> positions, int conditionId)
			{
				return this.m_owner.IsActorReachPositions(a, npcCondition, positions, conditionId);
			}

			// Token: 0x06003626 RID: 13862 RVA: 0x000F17CC File Offset: 0x000EF9CC
			public bool IsActorsAnyReachPositions(List<int> heroIds, List<ParamPosition> positions, int conditionId)
			{
				return this.m_owner.IsActorsAnyReachPositions(heroIds, positions, conditionId);
			}

			// Token: 0x06003627 RID: 13863 RVA: 0x000F17DC File Offset: 0x000EF9DC
			public bool IsActorsAnyReachPositions(int team, NpcCondition npcCondition, List<ParamPosition> positions, int conditionId)
			{
				return this.m_owner.IsActorsAnyReachPositions(team, npcCondition, positions, conditionId);
			}

			// Token: 0x06003628 RID: 13864 RVA: 0x000F17F0 File Offset: 0x000EF9F0
			public int GetActorsCountSatisfyCondition(int team, NpcCondition npcCondition, int conditionId)
			{
				return this.m_owner.GetActorsCountSatisfyCondition(team, npcCondition, conditionId);
			}

			// Token: 0x06003629 RID: 13865 RVA: 0x000F1800 File Offset: 0x000EFA00
			public static bool IsActorInPositions(BattleActor a, List<ParamPosition> positions)
			{
				return BattleBase.IsActorInPositions(a, positions);
			}

			// Token: 0x0600362A RID: 13866 RVA: 0x000F180C File Offset: 0x000EFA0C
			public static bool IsSkillClassMatch(ConfigDataSkillInfo skillInfo, int skillClass)
			{
				return BattleBase.IsSkillClassMatch(skillInfo, skillClass);
			}

			// Token: 0x0600362B RID: 13867 RVA: 0x000F1818 File Offset: 0x000EFA18
			public static bool IsActorClassMatch(BattleActor actor, int actorClass)
			{
				return BattleBase.IsActorClassMatch(actor, actorClass);
			}

			// Token: 0x0600362C RID: 13868 RVA: 0x000F1824 File Offset: 0x000EFA24
			public void AddLogBattleCommand(BattleCommand cmd)
			{
				this.m_owner.AddLogBattleCommand(cmd);
			}

			// Token: 0x0600362D RID: 13869 RVA: 0x000F1834 File Offset: 0x000EFA34
			public void AddBattleCommandToList(LinkedList<BattleCommand> commands, BattleCommand command)
			{
				this.m_owner.AddBattleCommandToList(commands, command);
			}

			// Token: 0x0600362E RID: 13870 RVA: 0x000F1844 File Offset: 0x000EFA44
			public bool HasWrongStepBattleCommand()
			{
				return this.m_owner.HasWrongStepBattleCommand();
			}

			// Token: 0x0600362F RID: 13871 RVA: 0x000F1854 File Offset: 0x000EFA54
			public void ExecuteGiveupCommand(int playerIndex)
			{
				this.m_owner.ExecuteGiveupCommand(playerIndex);
			}

			// Token: 0x06003630 RID: 13872 RVA: 0x000F1864 File Offset: 0x000EFA64
			public void RemoveStepCommands(int step)
			{
				this.m_owner.RemoveStepCommands(step);
			}

			// Token: 0x06003631 RID: 13873 RVA: 0x000F1874 File Offset: 0x000EFA74
			public bool RunCurrentStepBattleCommand()
			{
				return this.m_owner.RunCurrentStepBattleCommand();
			}

			// Token: 0x06003632 RID: 13874 RVA: 0x000F1884 File Offset: 0x000EFA84
			public bool RunCombat()
			{
				return this.m_owner.RunCombat();
			}

			// Token: 0x06003633 RID: 13875 RVA: 0x000F1894 File Offset: 0x000EFA94
			public void AddExecutedCommand(BattleCommand cmd)
			{
				this.m_owner.AddExecutedCommand(cmd);
			}

			// Token: 0x06003634 RID: 13876 RVA: 0x000F18A4 File Offset: 0x000EFAA4
			public void StopCombat()
			{
				this.m_owner.StopCombat();
			}

			// Token: 0x06003635 RID: 13877 RVA: 0x000F18B4 File Offset: 0x000EFAB4
			public void CheckCombatActorsDie(BattleActor actorA, BattleActor actorB)
			{
				this.m_owner.CheckCombatActorsDie(actorA, actorB);
			}

			// Token: 0x06003636 RID: 13878 RVA: 0x000F18C4 File Offset: 0x000EFAC4
			public void CopyCombatProperty(CombatTeam combatTeam, BattleActor actor)
			{
				this.m_owner.CopyCombatProperty(combatTeam, actor);
			}

			// Token: 0x06003637 RID: 13879 RVA: 0x000F18D4 File Offset: 0x000EFAD4
			public void CheckWinConditionOnActorMove(BattleActor actor)
			{
				this.m_owner.CheckWinConditionOnActorMove(actor);
			}

			// Token: 0x06003638 RID: 13880 RVA: 0x000F18E4 File Offset: 0x000EFAE4
			public void CheckLoseConditionOnActorMove(BattleActor actor)
			{
				this.m_owner.CheckLoseConditionOnActorMove(actor);
			}

			// Token: 0x06003639 RID: 13881 RVA: 0x000F18F4 File Offset: 0x000EFAF4
			public void CheckWinConditionOnActorDie(BattleActor actor)
			{
				this.m_owner.CheckWinConditionOnActorDie(actor);
			}

			// Token: 0x0600363A RID: 13882 RVA: 0x000F1904 File Offset: 0x000EFB04
			public void CheckLoseConditionOnActorDie(BattleActor actor)
			{
				this.m_owner.CheckLoseConditionOnActorDie(actor);
			}

			// Token: 0x0600363B RID: 13883 RVA: 0x000F1914 File Offset: 0x000EFB14
			public void CheckWinConditionOnActorRetreat(BattleActor actor)
			{
				this.m_owner.CheckWinConditionOnActorRetreat(actor);
			}

			// Token: 0x0600363C RID: 13884 RVA: 0x000F1924 File Offset: 0x000EFB24
			public void CheckLoseConditionOnActorRetreat(BattleActor actor)
			{
				this.m_owner.CheckLoseConditionOnActorRetreat(actor);
			}

			// Token: 0x0600363D RID: 13885 RVA: 0x000F1934 File Offset: 0x000EFB34
			public void CheckWinConditionOnEventTrigger(BattleEventTriggerState eventState)
			{
				this.m_owner.CheckWinConditionOnEventTrigger(eventState);
			}

			// Token: 0x0600363E RID: 13886 RVA: 0x000F1944 File Offset: 0x000EFB44
			public void CheckLoseConditionOnEventTrigger(BattleEventTriggerState eventState)
			{
				this.m_owner.CheckLoseConditionOnEventTrigger(eventState);
			}

			// Token: 0x0600363F RID: 13887 RVA: 0x000F1954 File Offset: 0x000EFB54
			public void CheckWinConditionOnNextStep()
			{
				this.m_owner.CheckWinConditionOnNextStep();
			}

			// Token: 0x06003640 RID: 13888 RVA: 0x000F1964 File Offset: 0x000EFB64
			public void CheckWinConditionOnTurnBegin()
			{
				this.m_owner.CheckWinConditionOnTurnBegin();
			}

			// Token: 0x06003641 RID: 13889 RVA: 0x000F1974 File Offset: 0x000EFB74
			public void CheckWinLoseConditionOnTurnMax()
			{
				this.m_owner.CheckWinLoseConditionOnTurnMax();
			}

			// Token: 0x06003642 RID: 13890 RVA: 0x000F1984 File Offset: 0x000EFB84
			public void ChangeWinConditionStatus(BattleWinConditionState state)
			{
				this.m_owner.ChangeWinConditionStatus(state);
			}

			// Token: 0x06003643 RID: 13891 RVA: 0x000F1994 File Offset: 0x000EFB94
			public void ChangeLoseConditionStatus(BattleLoseConditionState state)
			{
				this.m_owner.ChangeLoseConditionStatus(state);
			}

			// Token: 0x06003644 RID: 13892 RVA: 0x000F19A4 File Offset: 0x000EFBA4
			public void CheckEventTriggerOnActorMove(BattleActor actor)
			{
				this.m_owner.CheckEventTriggerOnActorMove(actor);
			}

			// Token: 0x06003645 RID: 13893 RVA: 0x000F19B4 File Offset: 0x000EFBB4
			public void CheckEventTriggerOnActorDie(BattleActor actor)
			{
				this.m_owner.CheckEventTriggerOnActorDie(actor);
			}

			// Token: 0x06003646 RID: 13894 RVA: 0x000F19C4 File Offset: 0x000EFBC4
			public void CheckEventTriggerOnActorActionBegin(BattleActor a)
			{
				this.m_owner.CheckEventTriggerOnActorActionBegin(a);
			}

			// Token: 0x06003647 RID: 13895 RVA: 0x000F19D4 File Offset: 0x000EFBD4
			public void CheckEventTriggerOnActorCombatAttackBefore(BattleActor a, BattleActor target)
			{
				this.m_owner.CheckEventTriggerOnActorCombatAttackBefore(a, target);
			}

			// Token: 0x06003648 RID: 13896 RVA: 0x000F19E4 File Offset: 0x000EFBE4
			public void CheckEventTriggerOnActorCombatAttackAfter(BattleActor a, BattleActor target)
			{
				this.m_owner.CheckEventTriggerOnActorCombatAttackAfter(a, target);
			}

			// Token: 0x06003649 RID: 13897 RVA: 0x000F19F4 File Offset: 0x000EFBF4
			public void CheckEventTriggerOnActorBeCombatAttack(BattleActor a)
			{
				this.m_owner.CheckEventTriggerOnActorBeCombatAttack(a);
			}

			// Token: 0x0600364A RID: 13898 RVA: 0x000F1A04 File Offset: 0x000EFC04
			public void CheckEventTriggerOnNextStep()
			{
				this.m_owner.CheckEventTriggerOnNextStep();
			}

			// Token: 0x0600364B RID: 13899 RVA: 0x000F1A14 File Offset: 0x000EFC14
			public void CheckEventTriggerOnNextTeam(int team, bool isNpc)
			{
				this.m_owner.CheckEventTriggerOnNextTeam(team, isNpc);
			}

			// Token: 0x0600364C RID: 13900 RVA: 0x000F1A24 File Offset: 0x000EFC24
			public void CheckEventTriggerOnCompleteAchievement(int achievementId)
			{
				this.m_owner.CheckEventTriggerOnCompleteAchievement(achievementId);
			}

			// Token: 0x0600364D RID: 13901 RVA: 0x000F1A34 File Offset: 0x000EFC34
			public void CheckEventTriggerOnWin()
			{
				this.m_owner.CheckEventTriggerOnWin();
			}

			// Token: 0x0600364E RID: 13902 RVA: 0x000F1A44 File Offset: 0x000EFC44
			public void CheckEventTriggerOnLose()
			{
				this.m_owner.CheckEventTriggerOnLose();
			}

			// Token: 0x0600364F RID: 13903 RVA: 0x000F1A54 File Offset: 0x000EFC54
			public void CheckBattleStopEventTrigger()
			{
				this.m_owner.CheckBattleStopEventTrigger();
			}

			// Token: 0x06003650 RID: 13904 RVA: 0x000F1A64 File Offset: 0x000EFC64
			public void CheckMultiEventTrigger()
			{
				this.m_owner.CheckMultiEventTrigger();
			}

			// Token: 0x06003651 RID: 13905 RVA: 0x000F1A74 File Offset: 0x000EFC74
			public bool IsEventTriggerd(int triggerId)
			{
				return this.m_owner.IsEventTriggerd(triggerId);
			}

			// Token: 0x06003652 RID: 13906 RVA: 0x000F1A84 File Offset: 0x000EFC84
			public BattleEventTriggerState GetEventTriggerState(int triggerId)
			{
				return this.m_owner.GetEventTriggerState(triggerId);
			}

			// Token: 0x06003653 RID: 13907 RVA: 0x000F1A94 File Offset: 0x000EFC94
			public void TriggerEvent(BattleEventTriggerState state)
			{
				this.m_owner.TriggerEvent(state);
			}

			// Token: 0x06003654 RID: 13908 RVA: 0x000F1AA4 File Offset: 0x000EFCA4
			public void ExecuteTriggerEventActions(BattleEventTriggerState state, int fromIdx)
			{
				this.m_owner.ExecuteTriggerEventActions(state, fromIdx);
			}

			// Token: 0x06003655 RID: 13909 RVA: 0x000F1AB4 File Offset: 0x000EFCB4
			public void ExecuteEventAction(ConfigDataBattleEventActionInfo e)
			{
				this.m_owner.ExecuteEventAction(e);
			}

			// Token: 0x06003656 RID: 13910 RVA: 0x000F1AC4 File Offset: 0x000EFCC4
			public void ExecuteEventAction_Relief(ConfigDataBattleEventActionInfo e)
			{
				this.m_owner.ExecuteEventAction_Relief(e);
			}

			// Token: 0x06003657 RID: 13911 RVA: 0x000F1AD4 File Offset: 0x000EFCD4
			public void ExecuteEventAction_Retreat(ConfigDataBattleEventActionInfo e)
			{
				this.m_owner.ExecuteEventAction_Retreat(e);
			}

			// Token: 0x06003658 RID: 13912 RVA: 0x000F1AE4 File Offset: 0x000EFCE4
			public void ExecuteEventAction_Dialog(ConfigDataBattleEventActionInfo e)
			{
				this.m_owner.ExecuteEventAction_Dialog(e);
			}

			// Token: 0x06003659 RID: 13913 RVA: 0x000F1AF4 File Offset: 0x000EFCF4
			public void ExecuteEventAction_ChangeTeam(ConfigDataBattleEventActionInfo e)
			{
				this.m_owner.ExecuteEventAction_ChangeTeam(e);
			}

			// Token: 0x0600365A RID: 13914 RVA: 0x000F1B04 File Offset: 0x000EFD04
			public void ExecuteEventAction_AttachBuff(ConfigDataBattleEventActionInfo e)
			{
				this.m_owner.ExecuteEventAction_AttachBuff(e);
			}

			// Token: 0x0600365B RID: 13915 RVA: 0x000F1B14 File Offset: 0x000EFD14
			public void ExecuteEventAction_ChangeBehavior(ConfigDataBattleEventActionInfo e)
			{
				this.m_owner.ExecuteEventAction_ChangeBehavior(e);
			}

			// Token: 0x0600365C RID: 13916 RVA: 0x000F1B24 File Offset: 0x000EFD24
			public void ExecuteEventAction_Music(ConfigDataBattleEventActionInfo e)
			{
				this.m_owner.ExecuteEventAction_Music(e);
			}

			// Token: 0x0600365D RID: 13917 RVA: 0x000F1B34 File Offset: 0x000EFD34
			public void ExecuteEventAction_ChangeTerrain(ConfigDataBattleEventActionInfo e)
			{
				this.m_owner.ExecuteEventAction_ChangeTerrain(e);
			}

			// Token: 0x0600365E RID: 13918 RVA: 0x000F1B44 File Offset: 0x000EFD44
			public void ExecuteEventAction_Perform(ConfigDataBattleEventActionInfo e)
			{
				this.m_owner.ExecuteEventAction_Perform(e);
			}

			// Token: 0x0600365F RID: 13919 RVA: 0x000F1B54 File Offset: 0x000EFD54
			public void ExecuteEventAction_RetreatPosition(ConfigDataBattleEventActionInfo e)
			{
				this.m_owner.ExecuteEventAction_RetreatPosition(e);
			}

			// Token: 0x06003660 RID: 13920 RVA: 0x000F1B64 File Offset: 0x000EFD64
			public void ExecuteEventAction_Replace(ConfigDataBattleEventActionInfo e)
			{
				this.m_owner.ExecuteEventAction_Replace(e);
			}

			// Token: 0x06003661 RID: 13921 RVA: 0x000F1B74 File Offset: 0x000EFD74
			public void ExecuteEventAction_RemoveBuff(ConfigDataBattleEventActionInfo e)
			{
				this.m_owner.ExecuteEventAction_RemoveBuff(e);
			}

			// Token: 0x06003662 RID: 13922 RVA: 0x000F1B84 File Offset: 0x000EFD84
			public void ExecuteEventAction_AttachBuffPosition(ConfigDataBattleEventActionInfo e)
			{
				this.m_owner.ExecuteEventAction_AttachBuffPosition(e);
			}

			// Token: 0x06003663 RID: 13923 RVA: 0x000F1B94 File Offset: 0x000EFD94
			public bool IsEmptyPosition(GridPosition p)
			{
				return this.m_owner.IsEmptyPosition(p);
			}

			// Token: 0x06003664 RID: 13924 RVA: 0x000F1BA4 File Offset: 0x000EFDA4
			public List<RandomArmyActor> GetRandomBattleArmyActors(List<int> randomArmies)
			{
				return this.m_owner.GetRandomBattleArmyActors(randomArmies);
			}

			// Token: 0x06003665 RID: 13925 RVA: 0x000F1BB4 File Offset: 0x000EFDB4
			public bool CreateEventActor(GridPosition p, int dir, int team, bool isNpc, int heroId, int heroLevel, int behaviorId, int groupId, int effectType, string fxName, BattleActorSourceType sourceType)
			{
				return this.m_owner.CreateEventActor(p, dir, team, isNpc, heroId, heroLevel, behaviorId, groupId, effectType, fxName, sourceType);
			}

			// Token: 0x06003666 RID: 13926 RVA: 0x000F1BE0 File Offset: 0x000EFDE0
			public bool ReplaceEventActor(BattleActor a, int heroId, int heroLevel, string fxName)
			{
				return this.m_owner.ReplaceEventActor(a, heroId, heroLevel, fxName);
			}

			// Token: 0x06003667 RID: 13927 RVA: 0x000F1BF4 File Offset: 0x000EFDF4
			public GridPosition FindEmptyFixedDistancePosition(GridPosition target, int distance)
			{
				return this.m_owner.FindEmptyFixedDistancePosition(target, distance);
			}

			// Token: 0x06003668 RID: 13928 RVA: 0x000F1C04 File Offset: 0x000EFE04
			public GridPosition FindEmptyFixedDistancePosition(GridPosition start, GridPosition target, int distance)
			{
				return this.m_owner.FindEmptyFixedDistancePosition(start, target, distance);
			}

			// Token: 0x06003669 RID: 13929 RVA: 0x000F1C14 File Offset: 0x000EFE14
			public GridPosition FindEmptyNearPosition(GridPosition target, MoveType moveType)
			{
				return this.m_owner.FindEmptyNearPosition(target, moveType);
			}

			// Token: 0x0600366A RID: 13930 RVA: 0x000F1C24 File Offset: 0x000EFE24
			public void InitRandomNumbers(int randomSeed, int armyRandomSeed)
			{
				this.m_owner.InitRandomNumbers(randomSeed, armyRandomSeed);
			}

			// Token: 0x0600366B RID: 13931 RVA: 0x000F1C34 File Offset: 0x000EFE34
			public void InitPlayers(BattlePlayer[] players)
			{
				this.m_owner.InitPlayers(players);
			}

			// Token: 0x0600366C RID: 13932 RVA: 0x000F1C44 File Offset: 0x000EFE44
			public void InitWinConditionStates(ConfigDataBattleWinConditionInfo[] winConditionInfos)
			{
				this.m_owner.InitWinConditionStates(winConditionInfos);
			}

			// Token: 0x0600366D RID: 13933 RVA: 0x000F1C54 File Offset: 0x000EFE54
			public void InitLoseConditionStates(ConfigDataBattleLoseConditionInfo[] loseConditionInfos)
			{
				this.m_owner.InitLoseConditionStates(loseConditionInfos);
			}

			// Token: 0x0600366E RID: 13934 RVA: 0x000F1C64 File Offset: 0x000EFE64
			public void InitEventTriggerStates(ConfigDataBattleEventTriggerInfo[] eventTriggerInfos)
			{
				this.m_owner.InitEventTriggerStates(eventTriggerInfos);
			}

			// Token: 0x0600366F RID: 13935 RVA: 0x000F1C74 File Offset: 0x000EFE74
			public void InitBattleTreasureStates(ConfigDataBattleTreasureInfo[] battleTreasureInfos)
			{
				this.m_owner.InitBattleTreasureStates(battleTreasureInfos);
			}

			// Token: 0x06003670 RID: 13936 RVA: 0x000F1C84 File Offset: 0x000EFE84
			public void CreateActors(int team, List<BattleActorSetup> setups)
			{
				this.m_owner.CreateActors(team, setups);
			}

			// Token: 0x06003671 RID: 13937 RVA: 0x000F1C94 File Offset: 0x000EFE94
			public void ExecuteBattlePerforms(ConfigDataBattlePerformInfo performInfo)
			{
				this.m_owner.ExecuteBattlePerforms(performInfo);
			}

			// Token: 0x06003672 RID: 13938 RVA: 0x000F1CA4 File Offset: 0x000EFEA4
			public void ExecuteAfterCombatSteps()
			{
				this.m_owner.ExecuteAfterCombatSteps();
			}

			// Token: 0x06003673 RID: 13939 RVA: 0x000F1CB4 File Offset: 0x000EFEB4
			public void ExecuteBattlePerform(ConfigDataBattlePerformInfo performInfo)
			{
				this.m_owner.ExecuteBattlePerform(performInfo);
			}

			// Token: 0x06003674 RID: 13940 RVA: 0x000F1CC4 File Offset: 0x000EFEC4
			public void ExecuteBattlePerform_Dialog(ConfigDataBattlePerformInfo performInfo)
			{
				this.m_owner.ExecuteBattlePerform_Dialog(performInfo);
			}

			// Token: 0x06003675 RID: 13941 RVA: 0x000F1CD4 File Offset: 0x000EFED4
			public void ExecuteBattlePerform_PlayMusic(ConfigDataBattlePerformInfo performInfo)
			{
				this.m_owner.ExecuteBattlePerform_PlayMusic(performInfo);
			}

			// Token: 0x06003676 RID: 13942 RVA: 0x000F1CE4 File Offset: 0x000EFEE4
			public void ExecuteBattlePerform_PlaySound(ConfigDataBattlePerformInfo performInfo)
			{
				this.m_owner.ExecuteBattlePerform_PlaySound(performInfo);
			}

			// Token: 0x06003677 RID: 13943 RVA: 0x000F1CF4 File Offset: 0x000EFEF4
			public void ExecuteBattlePerform_PlayFx(ConfigDataBattlePerformInfo performInfo)
			{
				this.m_owner.ExecuteBattlePerform_PlayFx(performInfo);
			}

			// Token: 0x06003678 RID: 13944 RVA: 0x000F1D04 File Offset: 0x000EFF04
			public void ExecuteBattlePerform_PlayActorFx(ConfigDataBattlePerformInfo performInfo)
			{
				this.m_owner.ExecuteBattlePerform_PlayActorFx(performInfo);
			}

			// Token: 0x06003679 RID: 13945 RVA: 0x000F1D14 File Offset: 0x000EFF14
			public void ExecuteBattlePerform_ChangeTerrain(ConfigDataBattlePerformInfo performInfo)
			{
				this.m_owner.ExecuteBattlePerform_ChangeTerrain(performInfo);
			}

			// Token: 0x0600367A RID: 13946 RVA: 0x000F1D24 File Offset: 0x000EFF24
			public void ExecuteBattlePerform_CameraFocusPosition(ConfigDataBattlePerformInfo performInfo)
			{
				this.m_owner.ExecuteBattlePerform_CameraFocusPosition(performInfo);
			}

			// Token: 0x0600367B RID: 13947 RVA: 0x000F1D34 File Offset: 0x000EFF34
			public void ExecuteBattlePerform_CameraFocusActor(ConfigDataBattlePerformInfo performInfo)
			{
				this.m_owner.ExecuteBattlePerform_CameraFocusActor(performInfo);
			}

			// Token: 0x0600367C RID: 13948 RVA: 0x000F1D44 File Offset: 0x000EFF44
			public void ExecuteBattlePerform_CreateActor(ConfigDataBattlePerformInfo performInfo)
			{
				this.m_owner.ExecuteBattlePerform_CreateActor(performInfo);
			}

			// Token: 0x0600367D RID: 13949 RVA: 0x000F1D54 File Offset: 0x000EFF54
			public void ExecuteBattlePerform_CreateActorNear(ConfigDataBattlePerformInfo performInfo)
			{
				this.m_owner.ExecuteBattlePerform_CreateActorNear(performInfo);
			}

			// Token: 0x0600367E RID: 13950 RVA: 0x000F1D64 File Offset: 0x000EFF64
			public void ExecuteBattlePerform_RemoveActor(ConfigDataBattlePerformInfo performInfo)
			{
				this.m_owner.ExecuteBattlePerform_RemoveActor(performInfo);
			}

			// Token: 0x0600367F RID: 13951 RVA: 0x000F1D74 File Offset: 0x000EFF74
			public void ExecuteBattlePerform_ActorMove(ConfigDataBattlePerformInfo performInfo)
			{
				this.m_owner.ExecuteBattlePerform_ActorMove(performInfo);
			}

			// Token: 0x06003680 RID: 13952 RVA: 0x000F1D84 File Offset: 0x000EFF84
			public void ExecuteBattlePerform_ActorMoveNear(ConfigDataBattlePerformInfo performInfo)
			{
				this.m_owner.ExecuteBattlePerform_ActorMoveNear(performInfo);
			}

			// Token: 0x06003681 RID: 13953 RVA: 0x000F1D94 File Offset: 0x000EFF94
			public void ExecuteBattlePerform_ActorAttack(ConfigDataBattlePerformInfo performInfo)
			{
				this.m_owner.ExecuteBattlePerform_ActorAttack(performInfo);
			}

			// Token: 0x06003682 RID: 13954 RVA: 0x000F1DA4 File Offset: 0x000EFFA4
			public void ExecuteBattlePerform_ActorSkill(ConfigDataBattlePerformInfo performInfo)
			{
				this.m_owner.ExecuteBattlePerform_ActorSkill(performInfo);
			}

			// Token: 0x06003683 RID: 13955 RVA: 0x000F1DB4 File Offset: 0x000EFFB4
			public void ExecuteBattlePerform_ActorDir(ConfigDataBattlePerformInfo performInfo)
			{
				this.m_owner.ExecuteBattlePerform_ActorDir(performInfo);
			}

			// Token: 0x06003684 RID: 13956 RVA: 0x000F1DC4 File Offset: 0x000EFFC4
			public void ExecuteBattlePerform_ActorAnimation(ConfigDataBattlePerformInfo performInfo)
			{
				this.m_owner.ExecuteBattlePerform_ActorAnimation(performInfo);
			}

			// Token: 0x06003685 RID: 13957 RVA: 0x000F1DD4 File Offset: 0x000EFFD4
			public void ExecuteBattlePerform_ActorIdle(ConfigDataBattlePerformInfo performInfo)
			{
				this.m_owner.ExecuteBattlePerform_ActorIdle(performInfo);
			}

			// Token: 0x06003686 RID: 13958 RVA: 0x000F1DE4 File Offset: 0x000EFFE4
			public void ExecuteBattlePerform_WaitTime(ConfigDataBattlePerformInfo performInfo)
			{
				this.m_owner.ExecuteBattlePerform_WaitTime(performInfo);
			}

			// Token: 0x06003687 RID: 13959 RVA: 0x000F1DF4 File Offset: 0x000EFFF4
			public void ExecuteBattlePerform_StopBattle(ConfigDataBattlePerformInfo performInfo)
			{
				this.m_owner.ExecuteBattlePerform_StopBattle(performInfo);
			}

			// Token: 0x06003688 RID: 13960 RVA: 0x000F1E04 File Offset: 0x000F0004
			public void CheckBattleTreasureOnActorMove(BattleActor actor)
			{
				this.m_owner.CheckBattleTreasureOnActorMove(actor);
			}

			// Token: 0x06003689 RID: 13961 RVA: 0x000F1E14 File Offset: 0x000F0014
			public void ChangeBattleTeasureStatus(BattleTreasureState state, BattleActor actor)
			{
				this.m_owner.ChangeBattleTeasureStatus(state, actor);
			}

			// Token: 0x04002987 RID: 10631
			private BattleBase m_owner;
		}
	}
}
