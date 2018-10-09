using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x020003B4 RID: 948
	[HotFix]
	public class Combat
	{
		// Token: 0x06003782 RID: 14210 RVA: 0x000F9680 File Offset: 0x000F7880
		public Combat(BattleBase battle)
		{
			this.m_battle = battle;
			this.m_teams = new CombatTeam[2];
			for (int i = 0; i < this.m_teams.Length; i++)
			{
				this.m_teams[i] = new CombatTeam();
			}
			this.m_randomNumber = new RandomNumber();
			this.m_state = CombatState.None;
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctorBattleBase_hotfix != null)
			{
				this.m_ctorBattleBase_hotfix.call(new object[]
				{
					this,
					battle
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06003783 RID: 14211 RVA: 0x000F9744 File Offset: 0x000F7944
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
			this.m_battle = null;
			this.m_teams = null;
			this.m_randomNumber = null;
		}

		// Token: 0x06003784 RID: 14212 RVA: 0x000F97BC File Offset: 0x000F79BC
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
			if (this.m_cutscenePauseCountdown > 0)
			{
				this.m_cutscenePauseCountdown--;
				if (this.m_cutscenePauseCountdown == 0)
				{
					this.Pause(false);
					this.m_battle.Listener.OnStopSkillCutscene();
				}
			}
			if (this.m_isPaused)
			{
				return;
			}
			if (this.m_state != CombatState.None)
			{
				if (this.m_state == CombatState.Ready)
				{
					if (this.m_startCountdown > 0)
					{
						this.m_startCountdown--;
						if (this.m_startCountdown == 0)
						{
							this.m_state = CombatState.Play;
							foreach (CombatTeam combatTeam in this.m_teams)
							{
								combatTeam.StartCombat();
							}
						}
					}
				}
				else if (this.m_state == CombatState.Play)
				{
					this.m_frameCount++;
					if (this.m_teams[0].CanStopCombat() && this.m_teams[1].CanStopCombat())
					{
						this.Stop();
					}
				}
				else if (this.m_state == CombatState.Stop)
				{
					if (this.m_endCountdown > 0)
					{
						this.m_endCountdown--;
						if (this.m_endCountdown == 0)
						{
							this.m_state = CombatState.End;
						}
					}
				}
				else if (this.m_state == CombatState.End)
				{
				}
			}
			foreach (CombatTeam combatTeam2 in this.m_teams)
			{
				combatTeam2.Tick();
			}
			foreach (CombatTeam combatTeam3 in this.m_teams)
			{
				combatTeam3.RemoveDeleted();
			}
		}

		// Token: 0x06003785 RID: 14213 RVA: 0x000F99C4 File Offset: 0x000F7BC4
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
			if (this.m_isPaused)
			{
				dt = 0f;
			}
			foreach (CombatTeam combatTeam in this.m_teams)
			{
				combatTeam.TickGraphic(dt);
			}
		}

		// Token: 0x06003786 RID: 14214 RVA: 0x000F9A6C File Offset: 0x000F7C6C
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
			foreach (CombatTeam combatTeam in this.m_teams)
			{
				combatTeam.Draw();
			}
		}

		// Token: 0x06003787 RID: 14215 RVA: 0x000F9AF4 File Offset: 0x000F7CF4
		private void Pause(bool pause)
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
			foreach (CombatTeam combatTeam in this.m_teams)
			{
				combatTeam.Pause(pause);
			}
		}

		// Token: 0x06003788 RID: 14216 RVA: 0x000F9B94 File Offset: 0x000F7D94
		public void Start(BattleActor actor0, BattleActor actor1, ConfigDataSkillInfo heroSkillInfo0, ConfigDataSkillInfo heroSkillInfo1, int randomSeed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartBattleActorBattleActorConfigDataSkillInfoConfigDataSkillInfoInt32_hotfix != null)
			{
				this.m_StartBattleActorBattleActorConfigDataSkillInfoConfigDataSkillInfoInt32_hotfix.call(new object[]
				{
					this,
					actor0,
					actor1,
					heroSkillInfo0,
					heroSkillInfo1,
					randomSeed
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.Clear();
			this.m_randomNumber.SetSeed(randomSeed);
			this.m_startCountdown = Combat.MillisecondToFrame1(this.ConfigDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_Combat_StartDelay) + 250) + 1;
			this.m_state = CombatState.Ready;
			this.m_isPaused = false;
			this.m_combatGridDistance = GridPosition.Distance(actor0.Position, actor1.Position);
			this.SetupTeam(0, actor0, heroSkillInfo0);
			this.SetupTeam(1, actor1, heroSkillInfo1);
			foreach (CombatTeam combatTeam in this.m_teams)
			{
				combatTeam.EnterCombat();
			}
		}

		// Token: 0x06003789 RID: 14217 RVA: 0x000F9CD4 File Offset: 0x000F7ED4
		public void Stop()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Stop_hotfix != null)
			{
				this.m_Stop_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_state = CombatState.Stop;
			foreach (CombatTeam combatTeam in this.m_teams)
			{
				combatTeam.StopCombat();
			}
			this.m_endCountdown = Combat.MillisecondToFrame1(this.ConfigDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_Combat_StopDelay) + 250) + 1;
			this.m_battle.Listener.OnPreStopCombat();
		}

		// Token: 0x0600378A RID: 14218 RVA: 0x000F9D90 File Offset: 0x000F7F90
		private void SetupTeam(int teamNumber, BattleActor battleActor, ConfigDataSkillInfo heroSkillInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetupTeamInt32BattleActorConfigDataSkillInfo_hotfix != null)
			{
				this.m_SetupTeamInt32BattleActorConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					teamNumber,
					battleActor,
					heroSkillInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (battleActor == null)
			{
				return;
			}
			CombatTeam combatTeam = this.m_teams[teamNumber];
			combatTeam.Initialize(this, teamNumber, battleActor, heroSkillInfo);
			int num = this.ConfigDataLoader.Const_CombatHeroDistance / -2;
			int num2 = -20;
			int num3 = 1;
			if (this.GetCombatGridDistance() > 1)
			{
				num -= this.ConfigDataLoader.Const_CombatSplitScreenDistance / 2;
			}
			if (teamNumber != 0)
			{
				num = -num;
				num3 = -1;
			}
			if (battleActor.HeroInfo != null)
			{
				CombatActor combatActor = combatTeam.CreateActor(true);
				combatActor.SetPosition(num, num2);
				combatActor.SetDirection(num3);
				combatActor.SetFormationLine(9);
			}
			if (battleActor.SoldierInfo != null)
			{
				int soldierCount = battleActor.GetSoldierCount();
				for (int i = 0; i < soldierCount; i++)
				{
					CombatActor combatActor2 = combatTeam.CreateActor(false);
					Position2i formationPosition = combatTeam.GetFormationPosition(i);
					combatActor2.SetPosition(num + formationPosition.x * num3, num2 + formationPosition.y);
					combatActor2.SetDirection(num3);
					combatActor2.SetFormationLine(combatTeam.GetFormationLine(i));
					if (i == soldierCount - 1)
					{
						combatActor2.SetHealthPoint(battleActor.SoldierTotalHealthPoint - combatActor2.HealthPointMax * (soldierCount - 1));
					}
				}
			}
		}

		// Token: 0x0600378B RID: 14219 RVA: 0x000F9F38 File Offset: 0x000F8138
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
			foreach (CombatTeam combatTeam in this.m_teams)
			{
				combatTeam.RemoveAll();
			}
			this.m_state = CombatState.None;
			this.m_isPaused = false;
			this.m_entityIdCounter = 0;
			this.m_hitIdCounter = 0;
			this.m_combatGridDistance = 0;
			this.m_frameCount = 0;
			this.m_startCountdown = 0;
			this.m_endCountdown = 0;
			this.m_cutscenePauseCountdown = 0;
		}

		// Token: 0x0600378C RID: 14220 RVA: 0x000F9FFC File Offset: 0x000F81FC
		public CombatTeam GetTeam(int teamNumber)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTeamInt32_hotfix != null)
			{
				return (CombatTeam)this.m_GetTeamInt32_hotfix.call(new object[]
				{
					this,
					teamNumber
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_teams[teamNumber];
		}

		// Token: 0x0600378D RID: 14221 RVA: 0x000FA080 File Offset: 0x000F8280
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

		// Token: 0x0600378E RID: 14222 RVA: 0x000FA114 File Offset: 0x000F8314
		public ushort GetNextHitId()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetNextHitId_hotfix != null)
			{
				return Convert.ToUInt16(this.m_GetNextHitId_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_hitIdCounter += 1;
			if (this.m_hitIdCounter == 0)
			{
				this.m_hitIdCounter = 1;
			}
			return this.m_hitIdCounter;
		}

		// Token: 0x0600378F RID: 14223 RVA: 0x000FA1A8 File Offset: 0x000F83A8
		public int GetCombatGridDistance()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCombatGridDistance_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetCombatGridDistance_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_combatGridDistance;
		}

		// Token: 0x06003790 RID: 14224 RVA: 0x000FA21C File Offset: 0x000F841C
		public void OnActorCastSkill(CombatActor a, ConfigDataSkillInfo skillInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnActorCastSkillCombatActorConfigDataSkillInfo_hotfix != null)
			{
				this.m_OnActorCastSkillCombatActorConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					a,
					skillInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (a == null || skillInfo == null)
			{
				return;
			}
			if (skillInfo.CutsceneType != 0)
			{
				ConfigDataCutsceneInfo configDataCutsceneInfo = null;
				if (skillInfo.CutsceneType == 1)
				{
					ConfigDataHeroInfo heroInfo = a.Team.HeroInfo;
					if (heroInfo != null)
					{
						ConfigDataCharImageInfo charImageInfo = heroInfo.GetCharImageInfo(a.Team.HeroStar);
						if (charImageInfo != null)
						{
							configDataCutsceneInfo = charImageInfo.m_skillCutsceneInfo;
						}
					}
				}
				this.Pause(true);
				this.m_teams[a.TeamNumber].SetGraphicSkillFade(true);
				if (configDataCutsceneInfo != null)
				{
					this.m_cutscenePauseCountdown = Combat.MillisecondToFrame1(configDataCutsceneInfo.Time);
				}
				else
				{
					this.m_cutscenePauseCountdown = Combat.MillisecondToFrame1(this.ConfigDataLoader.Const_SkillPauseTime);
				}
				this.m_battle.Listener.OnStartSkillCutscene(skillInfo, configDataCutsceneInfo, a.TeamNumber);
			}
		}

		// Token: 0x06003791 RID: 14225 RVA: 0x000FA358 File Offset: 0x000F8558
		public void OnActorCastPassiveSkill(CombatActor a, BuffState sourceBuffState)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnActorCastPassiveSkillCombatActorBuffState_hotfix != null)
			{
				this.m_OnActorCastPassiveSkillCombatActorBuffState_hotfix.call(new object[]
				{
					this,
					a,
					sourceBuffState
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (a == null || sourceBuffState == null)
			{
				return;
			}
			this.Pause(true);
			this.m_teams[a.TeamNumber].SetGraphicSkillFade(true);
			this.m_cutscenePauseCountdown = Combat.MillisecondToFrame1(this.ConfigDataLoader.Const_SkillPauseTime);
			this.m_battle.Listener.OnStartPassiveSkillCutscene(sourceBuffState, a.TeamNumber);
		}

		// Token: 0x06003792 RID: 14226 RVA: 0x000FA42C File Offset: 0x000F862C
		public void OnActorDie(CombatActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnActorDieCombatActor_hotfix != null)
			{
				this.m_OnActorDieCombatActor_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsPlay())
			{
				return;
			}
			this.m_battle.Listener.OnCombatActorDie(a);
		}

		// Token: 0x06003793 RID: 14227 RVA: 0x000FA4BC File Offset: 0x000F86BC
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
			return this.m_state == CombatState.Play;
		}

		// Token: 0x06003794 RID: 14228 RVA: 0x000FA534 File Offset: 0x000F8734
		public bool IsPaused()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsPaused_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsPaused_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isPaused;
		}

		// Token: 0x06003795 RID: 14229 RVA: 0x000FA5A8 File Offset: 0x000F87A8
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

		// Token: 0x06003796 RID: 14230 RVA: 0x000FA650 File Offset: 0x000F8850
		public int GetFrameCount()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetFrameCount_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetFrameCount_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_frameCount;
		}

		// Token: 0x06003797 RID: 14231 RVA: 0x000FA6C4 File Offset: 0x000F88C4
		public static int FrameToMillisecond(int frame)
		{
			return frame * 1000 / 30;
		}

		// Token: 0x06003798 RID: 14232 RVA: 0x000FA6D0 File Offset: 0x000F88D0
		public static int MillisecondToFrame(int ms)
		{
			return (ms * 30 + 500) / 1000;
		}

		// Token: 0x06003799 RID: 14233 RVA: 0x000FA6E4 File Offset: 0x000F88E4
		public static int MillisecondToFrame1(int ms)
		{
			return Math.Max((ms * 30 + 500) / 1000, 1);
		}

		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x0600379A RID: 14234 RVA: 0x000FA6FC File Offset: 0x000F88FC
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

		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x0600379B RID: 14235 RVA: 0x000FA770 File Offset: 0x000F8970
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

		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x0600379C RID: 14236 RVA: 0x000FA7E4 File Offset: 0x000F89E4
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
				return this.m_battle.Listener;
			}
		}

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x0600379D RID: 14237 RVA: 0x000FA85C File Offset: 0x000F8A5C
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
				return this.m_battle.ConfigDataLoader;
			}
		}

		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x0600379E RID: 14238 RVA: 0x000FA8D4 File Offset: 0x000F8AD4
		public CombatState State
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_State_hotfix != null)
				{
					return (CombatState)this.m_get_State_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_state;
			}
		}

		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x0600379F RID: 14239 RVA: 0x000FA948 File Offset: 0x000F8B48
		// (set) Token: 0x060037A0 RID: 14240 RVA: 0x000FA968 File Offset: 0x000F8B68
		[DoNotToLua]
		public Combat.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new Combat.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060037A1 RID: 14241 RVA: 0x000FA974 File Offset: 0x000F8B74
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
					this.m_ctorBattleBase_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_Dispose_hotfix = (luaObj.RawGet("Dispose") as LuaFunction);
					this.m_Tick_hotfix = (luaObj.RawGet("Tick") as LuaFunction);
					this.m_TickGraphicSingle_hotfix = (luaObj.RawGet("TickGraphic") as LuaFunction);
					this.m_Draw_hotfix = (luaObj.RawGet("Draw") as LuaFunction);
					this.m_PauseBoolean_hotfix = (luaObj.RawGet("Pause") as LuaFunction);
					this.m_StartBattleActorBattleActorConfigDataSkillInfoConfigDataSkillInfoInt32_hotfix = (luaObj.RawGet("Start") as LuaFunction);
					this.m_Stop_hotfix = (luaObj.RawGet("Stop") as LuaFunction);
					this.m_SetupTeamInt32BattleActorConfigDataSkillInfo_hotfix = (luaObj.RawGet("SetupTeam") as LuaFunction);
					this.m_Clear_hotfix = (luaObj.RawGet("Clear") as LuaFunction);
					this.m_GetTeamInt32_hotfix = (luaObj.RawGet("GetTeam") as LuaFunction);
					this.m_GetNextEntityId_hotfix = (luaObj.RawGet("GetNextEntityId") as LuaFunction);
					this.m_GetNextHitId_hotfix = (luaObj.RawGet("GetNextHitId") as LuaFunction);
					this.m_GetCombatGridDistance_hotfix = (luaObj.RawGet("GetCombatGridDistance") as LuaFunction);
					this.m_OnActorCastSkillCombatActorConfigDataSkillInfo_hotfix = (luaObj.RawGet("OnActorCastSkill") as LuaFunction);
					this.m_OnActorCastPassiveSkillCombatActorBuffState_hotfix = (luaObj.RawGet("OnActorCastPassiveSkill") as LuaFunction);
					this.m_OnActorDieCombatActor_hotfix = (luaObj.RawGet("OnActorDie") as LuaFunction);
					this.m_IsPlay_hotfix = (luaObj.RawGet("IsPlay") as LuaFunction);
					this.m_IsPaused_hotfix = (luaObj.RawGet("IsPaused") as LuaFunction);
					this.m_IsProbabilitySatisfiedInt32_hotfix = (luaObj.RawGet("IsProbabilitySatisfied") as LuaFunction);
					this.m_GetFrameCount_hotfix = (luaObj.RawGet("GetFrameCount") as LuaFunction);
					this.m_get_Battle_hotfix = (luaObj.RawGet("get_Battle") as LuaFunction);
					this.m_get_RandomNumber_hotfix = (luaObj.RawGet("get_RandomNumber") as LuaFunction);
					this.m_get_Listener_hotfix = (luaObj.RawGet("get_Listener") as LuaFunction);
					this.m_get_ConfigDataLoader_hotfix = (luaObj.RawGet("get_ConfigDataLoader") as LuaFunction);
					this.m_get_State_hotfix = (luaObj.RawGet("get_State") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060037A2 RID: 14242 RVA: 0x000FACB0 File Offset: 0x000F8EB0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(Combat));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002AD9 RID: 10969
		private BattleBase m_battle;

		// Token: 0x04002ADA RID: 10970
		private RandomNumber m_randomNumber;

		// Token: 0x04002ADB RID: 10971
		private CombatState m_state;

		// Token: 0x04002ADC RID: 10972
		private bool m_isPaused;

		// Token: 0x04002ADD RID: 10973
		private int m_entityIdCounter;

		// Token: 0x04002ADE RID: 10974
		private ushort m_hitIdCounter;

		// Token: 0x04002ADF RID: 10975
		private int m_combatGridDistance;

		// Token: 0x04002AE0 RID: 10976
		private int m_frameCount;

		// Token: 0x04002AE1 RID: 10977
		private int m_startCountdown;

		// Token: 0x04002AE2 RID: 10978
		private int m_endCountdown;

		// Token: 0x04002AE3 RID: 10979
		private int m_cutscenePauseCountdown;

		// Token: 0x04002AE4 RID: 10980
		private CombatTeam[] m_teams;

		// Token: 0x04002AE5 RID: 10981
		[DoNotToLua]
		private Combat.LuaExportHelper luaExportHelper;

		// Token: 0x04002AE6 RID: 10982
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002AE7 RID: 10983
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002AE8 RID: 10984
		private LuaFunction m_ctorBattleBase_hotfix;

		// Token: 0x04002AE9 RID: 10985
		private LuaFunction m_Dispose_hotfix;

		// Token: 0x04002AEA RID: 10986
		private LuaFunction m_Tick_hotfix;

		// Token: 0x04002AEB RID: 10987
		private LuaFunction m_TickGraphicSingle_hotfix;

		// Token: 0x04002AEC RID: 10988
		private LuaFunction m_Draw_hotfix;

		// Token: 0x04002AED RID: 10989
		private LuaFunction m_PauseBoolean_hotfix;

		// Token: 0x04002AEE RID: 10990
		private LuaFunction m_StartBattleActorBattleActorConfigDataSkillInfoConfigDataSkillInfoInt32_hotfix;

		// Token: 0x04002AEF RID: 10991
		private LuaFunction m_Stop_hotfix;

		// Token: 0x04002AF0 RID: 10992
		private LuaFunction m_SetupTeamInt32BattleActorConfigDataSkillInfo_hotfix;

		// Token: 0x04002AF1 RID: 10993
		private LuaFunction m_Clear_hotfix;

		// Token: 0x04002AF2 RID: 10994
		private LuaFunction m_GetTeamInt32_hotfix;

		// Token: 0x04002AF3 RID: 10995
		private LuaFunction m_GetNextEntityId_hotfix;

		// Token: 0x04002AF4 RID: 10996
		private LuaFunction m_GetNextHitId_hotfix;

		// Token: 0x04002AF5 RID: 10997
		private LuaFunction m_GetCombatGridDistance_hotfix;

		// Token: 0x04002AF6 RID: 10998
		private LuaFunction m_OnActorCastSkillCombatActorConfigDataSkillInfo_hotfix;

		// Token: 0x04002AF7 RID: 10999
		private LuaFunction m_OnActorCastPassiveSkillCombatActorBuffState_hotfix;

		// Token: 0x04002AF8 RID: 11000
		private LuaFunction m_OnActorDieCombatActor_hotfix;

		// Token: 0x04002AF9 RID: 11001
		private LuaFunction m_IsPlay_hotfix;

		// Token: 0x04002AFA RID: 11002
		private LuaFunction m_IsPaused_hotfix;

		// Token: 0x04002AFB RID: 11003
		private LuaFunction m_IsProbabilitySatisfiedInt32_hotfix;

		// Token: 0x04002AFC RID: 11004
		private LuaFunction m_GetFrameCount_hotfix;

		// Token: 0x04002AFD RID: 11005
		private LuaFunction m_get_Battle_hotfix;

		// Token: 0x04002AFE RID: 11006
		private LuaFunction m_get_RandomNumber_hotfix;

		// Token: 0x04002AFF RID: 11007
		private LuaFunction m_get_Listener_hotfix;

		// Token: 0x04002B00 RID: 11008
		private LuaFunction m_get_ConfigDataLoader_hotfix;

		// Token: 0x04002B01 RID: 11009
		private LuaFunction m_get_State_hotfix;

		// Token: 0x020003B5 RID: 949
		public class LuaExportHelper
		{
			// Token: 0x060037A3 RID: 14243 RVA: 0x000FAD18 File Offset: 0x000F8F18
			public LuaExportHelper(Combat owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17000F4E RID: 3918
			// (get) Token: 0x060037A4 RID: 14244 RVA: 0x000FAD28 File Offset: 0x000F8F28
			// (set) Token: 0x060037A5 RID: 14245 RVA: 0x000FAD38 File Offset: 0x000F8F38
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

			// Token: 0x17000F4F RID: 3919
			// (get) Token: 0x060037A6 RID: 14246 RVA: 0x000FAD48 File Offset: 0x000F8F48
			// (set) Token: 0x060037A7 RID: 14247 RVA: 0x000FAD58 File Offset: 0x000F8F58
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

			// Token: 0x17000F50 RID: 3920
			// (get) Token: 0x060037A8 RID: 14248 RVA: 0x000FAD68 File Offset: 0x000F8F68
			// (set) Token: 0x060037A9 RID: 14249 RVA: 0x000FAD78 File Offset: 0x000F8F78
			public CombatState m_state
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

			// Token: 0x17000F51 RID: 3921
			// (get) Token: 0x060037AA RID: 14250 RVA: 0x000FAD88 File Offset: 0x000F8F88
			// (set) Token: 0x060037AB RID: 14251 RVA: 0x000FAD98 File Offset: 0x000F8F98
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

			// Token: 0x17000F52 RID: 3922
			// (get) Token: 0x060037AC RID: 14252 RVA: 0x000FADA8 File Offset: 0x000F8FA8
			// (set) Token: 0x060037AD RID: 14253 RVA: 0x000FADB8 File Offset: 0x000F8FB8
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

			// Token: 0x17000F53 RID: 3923
			// (get) Token: 0x060037AE RID: 14254 RVA: 0x000FADC8 File Offset: 0x000F8FC8
			// (set) Token: 0x060037AF RID: 14255 RVA: 0x000FADD8 File Offset: 0x000F8FD8
			public ushort m_hitIdCounter
			{
				get
				{
					return this.m_owner.m_hitIdCounter;
				}
				set
				{
					this.m_owner.m_hitIdCounter = value;
				}
			}

			// Token: 0x17000F54 RID: 3924
			// (get) Token: 0x060037B0 RID: 14256 RVA: 0x000FADE8 File Offset: 0x000F8FE8
			// (set) Token: 0x060037B1 RID: 14257 RVA: 0x000FADF8 File Offset: 0x000F8FF8
			public int m_combatGridDistance
			{
				get
				{
					return this.m_owner.m_combatGridDistance;
				}
				set
				{
					this.m_owner.m_combatGridDistance = value;
				}
			}

			// Token: 0x17000F55 RID: 3925
			// (get) Token: 0x060037B2 RID: 14258 RVA: 0x000FAE08 File Offset: 0x000F9008
			// (set) Token: 0x060037B3 RID: 14259 RVA: 0x000FAE18 File Offset: 0x000F9018
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

			// Token: 0x17000F56 RID: 3926
			// (get) Token: 0x060037B4 RID: 14260 RVA: 0x000FAE28 File Offset: 0x000F9028
			// (set) Token: 0x060037B5 RID: 14261 RVA: 0x000FAE38 File Offset: 0x000F9038
			public int m_startCountdown
			{
				get
				{
					return this.m_owner.m_startCountdown;
				}
				set
				{
					this.m_owner.m_startCountdown = value;
				}
			}

			// Token: 0x17000F57 RID: 3927
			// (get) Token: 0x060037B6 RID: 14262 RVA: 0x000FAE48 File Offset: 0x000F9048
			// (set) Token: 0x060037B7 RID: 14263 RVA: 0x000FAE58 File Offset: 0x000F9058
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

			// Token: 0x17000F58 RID: 3928
			// (get) Token: 0x060037B8 RID: 14264 RVA: 0x000FAE68 File Offset: 0x000F9068
			// (set) Token: 0x060037B9 RID: 14265 RVA: 0x000FAE78 File Offset: 0x000F9078
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

			// Token: 0x17000F59 RID: 3929
			// (get) Token: 0x060037BA RID: 14266 RVA: 0x000FAE88 File Offset: 0x000F9088
			// (set) Token: 0x060037BB RID: 14267 RVA: 0x000FAE98 File Offset: 0x000F9098
			public CombatTeam[] m_teams
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

			// Token: 0x060037BC RID: 14268 RVA: 0x000FAEA8 File Offset: 0x000F90A8
			public void Pause(bool pause)
			{
				this.m_owner.Pause(pause);
			}

			// Token: 0x060037BD RID: 14269 RVA: 0x000FAEB8 File Offset: 0x000F90B8
			public void SetupTeam(int teamNumber, BattleActor battleActor, ConfigDataSkillInfo heroSkillInfo)
			{
				this.m_owner.SetupTeam(teamNumber, battleActor, heroSkillInfo);
			}

			// Token: 0x04002B02 RID: 11010
			private Combat m_owner;
		}
	}
}
