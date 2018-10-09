using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using FixMath.NET;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x020003B6 RID: 950
	[HotFix]
	public class CombatActor : Entity
	{
		// Token: 0x060037BE RID: 14270 RVA: 0x000FAEC8 File Offset: 0x000F90C8
		public CombatActor()
		{
			this.m_skillStates = new List<CombatSkillState>();
			this.m_state = CombatActorState.Idle;
			this.m_isVisible = true;
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

		// Token: 0x060037BF RID: 14271 RVA: 0x000FAF54 File Offset: 0x000F9154
		public override void Dispose()
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
			if (this.m_graphic != null)
			{
				this.Combat.Listener.DestroyCombatGraphic(this.m_graphic);
				this.m_graphic = null;
			}
			this.m_team = null;
			this.m_targetActor = null;
			this.m_skillStates.Clear();
		}

		// Token: 0x060037C0 RID: 14272 RVA: 0x000FAFF8 File Offset: 0x000F91F8
		public void Initialize(CombatTeam team, bool isHero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitializeCombatTeamBoolean_hotfix != null)
			{
				this.m_InitializeCombatTeamBoolean_hotfix.call(new object[]
				{
					this,
					team,
					isHero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_team = team;
			this.m_id = this.Combat.GetNextEntityId();
			this.m_isHero = isHero;
			if (isHero)
			{
				this.m_healthPointMax = team.BattleActor.HeroBattleProperty.HealthPointMax;
				this.m_healthPoint = team.BattleActor.HeroHealthPoint;
				ConfigDataJobConnectionInfo jobConnectionInfo = team.JobConnectionInfo;
				this.m_radius = jobConnectionInfo.Radius;
				this.m_height = jobConnectionInfo.Height;
				this.m_footHeight = this.m_team.JobConnectionInfo.FootHeight;
				string text = string.Empty;
				ConfigDataModelSkinResourceInfo heroModelSkinResourceInfo = this.m_team.BattleActor.HeroModelSkinResourceInfo;
				if (heroModelSkinResourceInfo != null)
				{
					text = ((!string.IsNullOrEmpty(heroModelSkinResourceInfo.CombatModel)) ? heroModelSkinResourceInfo.CombatModel : heroModelSkinResourceInfo.Model);
				}
				if (string.IsNullOrEmpty(text))
				{
					text = ((!string.IsNullOrEmpty(jobConnectionInfo.CombatModel)) ? jobConnectionInfo.CombatModel : jobConnectionInfo.Model);
				}
				float scale = (float)jobConnectionInfo.ModelScale * 0.01f;
				float height = (float)this.m_height * 0.01732f;
				float footHeight = (float)this.m_footHeight * 0.01732f;
				string name = "Hero_" + this.m_id;
				this.CreateGraphic(text, scale, height, footHeight, name, jobConnectionInfo.ReplaceAnims);
			}
			else
			{
				this.m_healthPoint = (this.m_healthPointMax = team.BattleActor.SoldierSingleHealthPointMax);
				ConfigDataSoldierInfo soldierInfo = team.SoldierInfo;
				this.m_radius = soldierInfo.Radius;
				this.m_height = soldierInfo.Height;
				this.m_footHeight = soldierInfo.FootHeight;
				string text2 = string.Empty;
				ConfigDataModelSkinResourceInfo soldierModelSkinResourceInfo = this.m_team.BattleActor.SoldierModelSkinResourceInfo;
				if (soldierModelSkinResourceInfo != null)
				{
					text2 = ((!string.IsNullOrEmpty(soldierModelSkinResourceInfo.CombatModel)) ? soldierModelSkinResourceInfo.CombatModel : soldierModelSkinResourceInfo.Model);
				}
				if (string.IsNullOrEmpty(text2))
				{
					if (this.m_team.TeamNumber == this.m_team.Combat.Battle.GetMyPlayerTeamNumber())
					{
						text2 = ((!string.IsNullOrEmpty(soldierInfo.CombatModel)) ? soldierInfo.CombatModel : soldierInfo.Model);
					}
					else
					{
						text2 = ((!string.IsNullOrEmpty(soldierInfo.CombatModel2)) ? soldierInfo.CombatModel2 : soldierInfo.Model2);
					}
				}
				float scale2 = (float)soldierInfo.ModelScale * 0.01f;
				float height2 = (float)this.m_height * 0.01732f;
				float footHeight2 = (float)this.m_footHeight * 0.01732f;
				string name2 = "Soldier_" + this.m_id;
				this.CreateGraphic(text2, scale2, height2, footHeight2, name2, soldierInfo.ReplaceAnims);
			}
			this.m_frameCount = 0;
			this.m_isVisible = true;
			this.m_isGraphicSkillFade = false;
			this.m_deathAnimType = 0;
			this.PlayAnimation("idle", true);
		}

		// Token: 0x060037C1 RID: 14273 RVA: 0x000FB358 File Offset: 0x000F9558
		public override void Tick()
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
			this.m_frameCount++;
			this.TickState();
			this.TickSkillStates();
		}

		// Token: 0x060037C2 RID: 14274 RVA: 0x000FB3D4 File Offset: 0x000F95D4
		public override void TickGraphic(float dt)
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
			if (this.m_graphic != null)
			{
				Vector2i vector2i = Vector2i.MoveTowards(this.m_graphicPrevPosition, this.m_position, this.m_graphicMoveDistance / CombatConst.TickTime * (Fix64)dt);
				int zoffset = (!this.m_isGraphicSkillFade) ? 0 : 25;
				this.m_graphic.SetCombatPosition(vector2i, Fix64.Zero, zoffset);
				this.m_graphic.SetCombatDirection(this.m_direction);
				this.m_graphicPrevPosition = vector2i;
				this.m_graphic.Tick(dt);
			}
		}

		// Token: 0x060037C3 RID: 14275 RVA: 0x000FB4C8 File Offset: 0x000F96C8
		public override void Draw()
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
			Colori color = this.m_team.GetColor();
			int num = (int)((long)this.m_position.x);
			int num2 = (int)((long)this.m_position.y);
			int radius = this.m_radius;
			Vector2i vector2i = new Vector2i(num - radius, num2);
			Vector2i vector2i2 = new Vector2i(num, num2 - radius);
			Vector2i vector2i3 = new Vector2i(num + radius, num2);
			Vector2i vector2i4 = new Vector2i(num, num2 + radius);
			IBattleListener listener = this.Combat.Listener;
			listener.DrawLine(vector2i, vector2i2, color);
			listener.DrawLine(vector2i2, vector2i3, color);
			listener.DrawLine(vector2i3, vector2i4, color);
			listener.DrawLine(vector2i4, vector2i, color);
			listener.DrawLine(this.m_position, (Fix64)((long)this.m_footHeight), this.m_position, (Fix64)((long)(this.m_height + this.m_footHeight)), color);
			if (!this.IsDead())
			{
				Colori color2 = new Colori(0, byte.MaxValue, 0, byte.MaxValue);
				if (this.m_team.TeamNumber != 0)
				{
					color2 = new Colori(byte.MaxValue, 0, 0, byte.MaxValue);
				}
				int num3 = this.m_healthPoint * radius * 2 / this.m_healthPointMax;
				listener.DrawLine(new Vector2i(num - radius, num2), new Vector2i(num - radius + num3, num2), color2);
			}
		}

		// Token: 0x060037C4 RID: 14276 RVA: 0x000FB670 File Offset: 0x000F9870
		public override void DoPause(bool pause)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DoPauseBoolean_hotfix != null)
			{
				this.m_DoPauseBoolean_hotfix.call(new object[]
				{
					this,
					pause
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_graphic != null)
			{
				this.m_graphic.Pause(pause);
			}
		}

		// Token: 0x060037C5 RID: 14277 RVA: 0x000FB6F8 File Offset: 0x000F98F8
		public void EnterCombat()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EnterCombat_hotfix != null)
			{
				this.m_EnterCombat_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_initPosition = this.m_position;
			this.m_initDirection = this.m_direction;
			Vector2i position = this.m_position;
			position.x -= (Fix64)((long)(500 * this.m_initDirection));
			this.SetPosition(position);
			this.ChangeState(CombatActorState.Enter);
		}

		// Token: 0x060037C6 RID: 14278 RVA: 0x000FB7AC File Offset: 0x000F99AC
		public void StartCombat()
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
			this.m_targetActor = null;
			this.m_skillInfo = null;
			this.m_curSkillState = null;
			this.m_skillStates.Clear();
			this.m_skillUseCount = 0;
			this.m_isDoubleAttacked = false;
			this.m_canStopFrame = 0;
			this.m_preAttackHp = this.m_healthPoint;
			if (this.Combat.GetCombatGridDistance() > this.GetAttackDistance() || this.m_team.BattleActor.HasFightTag(FightTag.FightTag_Stun))
			{
				this.ChangeState(CombatActorState.Stop);
			}
			else
			{
				this.ChangeState(CombatActorState.Fight);
			}
		}

		// Token: 0x060037C7 RID: 14279 RVA: 0x000FB890 File Offset: 0x000F9A90
		public void StopCombat()
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
			if (!this.IsDead())
			{
				this.ChangeState(CombatActorState.Exit);
			}
			else
			{
				this.SetVisible(false);
			}
			this.m_skillStates.Clear();
		}

		// Token: 0x060037C8 RID: 14280 RVA: 0x000FB91C File Offset: 0x000F9B1C
		public bool CanStopCombat()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanStopCombat_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CanStopCombat_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return (this.m_state == CombatActorState.Stop || this.m_state == CombatActorState.Die) && this.m_canStopFrame > 0 && this.m_frameCount >= this.m_canStopFrame;
		}

		// Token: 0x060037C9 RID: 14281 RVA: 0x000FB9C4 File Offset: 0x000F9BC4
		public void LogCanNotStopCombat()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LogCanNotStopCombat_hotfix != null)
			{
				this.m_LogCanNotStopCombat_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.CanStopCombat())
			{
				return;
			}
			DebugUtility.LogError(string.Format("Actor {0} can not stop combat, state:{1}, frame:{2}, canStopFrame:{3}", new object[]
			{
				this.m_id,
				this.m_state,
				this.m_frameCount,
				this.m_canStopFrame
			}));
		}

		// Token: 0x060037CA RID: 14282 RVA: 0x000FBA80 File Offset: 0x000F9C80
		public void SetCanStopFrame(int delay)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCanStopFrameInt32_hotfix != null)
			{
				this.m_SetCanStopFrameInt32_hotfix.call(new object[]
				{
					this,
					delay
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_canStopFrame = Math.Max(this.m_canStopFrame, this.m_frameCount + Combat.MillisecondToFrame(delay));
		}

		// Token: 0x060037CB RID: 14283 RVA: 0x000FBB10 File Offset: 0x000F9D10
		public void SetPosition(int x, int y)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPositionInt32Int32_hotfix != null)
			{
				this.m_SetPositionInt32Int32_hotfix.call(new object[]
				{
					this,
					x,
					y
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_position.Set(x, y);
			this.m_graphicPrevPosition.Set(x, y);
		}

		// Token: 0x060037CC RID: 14284 RVA: 0x000FBBAC File Offset: 0x000F9DAC
		public void SetPosition(Vector2i p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPositionVector2i_hotfix != null)
			{
				this.m_SetPositionVector2i_hotfix.call(new object[]
				{
					this,
					p
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_position = p;
			this.m_graphicPrevPosition = p;
		}

		// Token: 0x060037CD RID: 14285 RVA: 0x000FBC2C File Offset: 0x000F9E2C
		public void SetDirection(int d)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetDirectionInt32_hotfix != null)
			{
				this.m_SetDirectionInt32_hotfix.call(new object[]
				{
					this,
					d
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_direction = d;
		}

		// Token: 0x060037CE RID: 14286 RVA: 0x000FBCA4 File Offset: 0x000F9EA4
		public void SetFormationLine(int line)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetFormationLineInt32_hotfix != null)
			{
				this.m_SetFormationLineInt32_hotfix.call(new object[]
				{
					this,
					line
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_formationLine = line;
		}

		// Token: 0x060037CF RID: 14287 RVA: 0x000FBD1C File Offset: 0x000F9F1C
		public void FaceTo(Vector2i pos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FaceToVector2i_hotfix != null)
			{
				this.m_FaceToVector2i_hotfix.call(new object[]
				{
					this,
					pos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (pos.x > this.m_position.x)
			{
				this.m_direction = 1;
			}
			else if (pos.x < this.m_position.x)
			{
				this.m_direction = -1;
			}
		}

		// Token: 0x060037D0 RID: 14288 RVA: 0x000FBDD8 File Offset: 0x000F9FD8
		private void Move(Vector2i dir, Fix64 distance, bool changeDirection)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_MoveVector2iFix64Boolean_hotfix != null)
			{
				this.m_MoveVector2iFix64Boolean_hotfix.call(new object[]
				{
					this,
					dir,
					distance,
					changeDirection
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_position += dir * distance;
			if (changeDirection)
			{
				if (dir.x > Fix64.Zero)
				{
					this.m_direction = 1;
				}
				else if (dir.x < Fix64.Zero)
				{
					this.m_direction = -1;
				}
			}
			this.m_graphicMoveDistance = distance;
		}

		// Token: 0x060037D1 RID: 14289 RVA: 0x000FBECC File Offset: 0x000FA0CC
		private void MoveX(int dir, Fix64 distance, bool changeDirection)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_MoveXInt32Fix64Boolean_hotfix != null)
			{
				this.m_MoveXInt32Fix64Boolean_hotfix.call(new object[]
				{
					this,
					dir,
					distance,
					changeDirection
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (dir > 0)
			{
				this.m_position.x = this.m_position.x + distance;
				if (changeDirection)
				{
					this.m_direction = 1;
				}
			}
			else if (dir < 0)
			{
				this.m_position.x = this.m_position.x - distance;
				if (changeDirection)
				{
					this.m_direction = -1;
				}
			}
			this.m_graphicMoveDistance = distance;
		}

		// Token: 0x060037D2 RID: 14290 RVA: 0x000FBFC0 File Offset: 0x000FA1C0
		private void CreateGraphic(string assetName, float scale, float height, float footHeight, string name, List<ReplaceAnim> replaceAnims)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateGraphicStringSingleSingleSingleStringList`1_hotfix != null)
			{
				this.m_CreateGraphicStringSingleSingleSingleStringList`1_hotfix.call(new object[]
				{
					this,
					assetName,
					scale,
					height,
					footHeight,
					name,
					replaceAnims
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_graphic != null)
			{
				this.Combat.Listener.DestroyCombatGraphic(this.m_graphic);
			}
			this.m_graphic = this.Combat.Listener.CreateCombatGraphic(assetName, scale);
			if (this.m_graphic != null)
			{
				this.m_graphic.SetHeight(height, footHeight);
				this.m_graphic.SetName(name);
				this.m_graphic.SetReplaceAnimations(replaceAnims);
			}
		}

		// Token: 0x060037D3 RID: 14291 RVA: 0x000FC0EC File Offset: 0x000FA2EC
		public void SetGraphicSkillFade(bool fade)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGraphicSkillFadeBoolean_hotfix != null)
			{
				this.m_SetGraphicSkillFadeBoolean_hotfix.call(new object[]
				{
					this,
					fade
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isGraphicSkillFade = fade;
		}

		// Token: 0x060037D4 RID: 14292 RVA: 0x000FC164 File Offset: 0x000FA364
		private void PlayAnimation(string name, bool loop)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayAnimationStringBoolean_hotfix != null)
			{
				this.m_PlayAnimationStringBoolean_hotfix.call(new object[]
				{
					this,
					name,
					loop
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_graphic != null)
			{
				this.m_graphic.PlayAnimation(name, loop);
			}
		}

		// Token: 0x060037D5 RID: 14293 RVA: 0x000FC1FC File Offset: 0x000FA3FC
		private void PlayDeathAnimation(int deathType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayDeathAnimationInt32_hotfix != null)
			{
				this.m_PlayDeathAnimationInt32_hotfix.call(new object[]
				{
					this,
					deathType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_graphic != null)
			{
				this.m_graphic.PlayDeathAnimation(deathType);
			}
		}

		// Token: 0x060037D6 RID: 14294 RVA: 0x000FC284 File Offset: 0x000FA484
		private void PlayFx(string name, int tag)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayFxStringInt32_hotfix != null)
			{
				this.m_PlayFxStringInt32_hotfix.call(new object[]
				{
					this,
					name,
					tag
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (string.IsNullOrEmpty(name))
			{
				return;
			}
			if (this.m_graphic != null)
			{
				this.m_graphic.SetCombatDirection(this.m_direction);
				this.m_graphic.PlayFx(name, tag);
			}
		}

		// Token: 0x060037D7 RID: 14295 RVA: 0x000FC33C File Offset: 0x000FA53C
		private void PlaySkillFx(string name, string nameFar)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlaySkillFxStringString_hotfix != null)
			{
				this.m_PlaySkillFxStringString_hotfix.call(new object[]
				{
					this,
					name,
					nameFar
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!string.IsNullOrEmpty(nameFar) && this.Combat.GetCombatGridDistance() > 1)
			{
				this.PlayFx(nameFar, 1);
			}
			else
			{
				this.PlayFx(name, 1);
			}
		}

		// Token: 0x060037D8 RID: 14296 RVA: 0x000FC3F0 File Offset: 0x000FA5F0
		private void PlaySound(string name)
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
			this.Combat.Listener.PlaySound(name);
		}

		// Token: 0x060037D9 RID: 14297 RVA: 0x000FC474 File Offset: 0x000FA674
		private void SetGraphicEffect(GraphicEffect e, float param1 = 0f, float param2 = 0f)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGraphicEffectGraphicEffectSingleSingle_hotfix != null)
			{
				this.m_SetGraphicEffectGraphicEffectSingleSingle_hotfix.call(new object[]
				{
					this,
					e,
					param1,
					param2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_graphic != null)
			{
				this.m_graphic.SetEffect(e, param1, param2);
			}
		}

		// Token: 0x060037DA RID: 14298 RVA: 0x000FC520 File Offset: 0x000FA720
		private void ClearGraphicEffect(GraphicEffect e)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearGraphicEffectGraphicEffect_hotfix != null)
			{
				this.m_ClearGraphicEffectGraphicEffect_hotfix.call(new object[]
				{
					this,
					e
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_graphic != null)
			{
				this.m_graphic.ClearEffect(e);
			}
		}

		// Token: 0x060037DB RID: 14299 RVA: 0x000FC5A8 File Offset: 0x000FA7A8
		private void ClearAttachFxs(int tagMask)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearAttachFxsInt32_hotfix != null)
			{
				this.m_ClearAttachFxsInt32_hotfix.call(new object[]
				{
					this,
					tagMask
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_graphic != null)
			{
				this.m_graphic.ClearAttachFxs(tagMask);
			}
		}

		// Token: 0x060037DC RID: 14300 RVA: 0x000FC630 File Offset: 0x000FA830
		public bool IsDead()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsDead_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsDead_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_healthPoint <= 0;
		}

		// Token: 0x060037DD RID: 14301 RVA: 0x000FC6A8 File Offset: 0x000FA8A8
		public void SetVisible(bool v)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetVisibleBoolean_hotfix != null)
			{
				this.m_SetVisibleBoolean_hotfix.call(new object[]
				{
					this,
					v
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isVisible = v;
			if (this.m_graphic != null)
			{
				this.m_graphic.SetVisible(v);
			}
		}

		// Token: 0x060037DE RID: 14302 RVA: 0x000FC738 File Offset: 0x000FA938
		public bool IsVisible()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsVisible_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsVisible_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isVisible;
		}

		// Token: 0x060037DF RID: 14303 RVA: 0x000FC7AC File Offset: 0x000FA9AC
		public bool IsHero()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsHero_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsHero_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isHero;
		}

		// Token: 0x060037E0 RID: 14304 RVA: 0x000FC820 File Offset: 0x000FAA20
		private BattleProperty GetBattleProperty()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetBattleProperty_hotfix != null)
			{
				return (BattleProperty)this.m_GetBattleProperty_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isHero)
			{
				return this.m_team.BattleActor.HeroBattleProperty;
			}
			return this.m_team.BattleActor.SoldierBattleProperty;
		}

		// Token: 0x060037E1 RID: 14305 RVA: 0x000FC8B8 File Offset: 0x000FAAB8
		public ConfigDataArmyInfo GetArmyInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetArmyInfo_hotfix != null)
			{
				return (ConfigDataArmyInfo)this.m_GetArmyInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isHero)
			{
				return this.m_team.HeroArmyInfo;
			}
			return this.m_team.SoldierArmyInfo;
		}

		// Token: 0x060037E2 RID: 14306 RVA: 0x000FC948 File Offset: 0x000FAB48
		private int GetMoveSpeed()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetMoveSpeed_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetMoveSpeed_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isHero)
			{
				return this.m_team.JobInfo.MoveSPD_INI;
			}
			return this.m_team.SoldierInfo.MoveSPD_INI;
		}

		// Token: 0x060037E3 RID: 14307 RVA: 0x000FC9E0 File Offset: 0x000FABE0
		private int GetAttackDistance()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAttackDistance_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetAttackDistance_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_isHero)
			{
				return this.m_team.BattleActor.SoldierBattleProperty.AttackDistance;
			}
			if (this.m_team.HeroSkill != null)
			{
				return this.m_team.BattleActor.GetSkillDistance(this.m_team.HeroSkill);
			}
			return this.m_team.BattleActor.HeroBattleProperty.AttackDistance;
		}

		// Token: 0x060037E4 RID: 14308 RVA: 0x000FCAB0 File Offset: 0x000FACB0
		private MoveType GetMoveType()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetMoveType_hotfix != null)
			{
				return (MoveType)this.m_GetMoveType_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isHero)
			{
				return this.m_team.JobInfo.MoveType;
			}
			return this.m_team.SoldierInfo.MoveType;
		}

		// Token: 0x060037E5 RID: 14309 RVA: 0x000FCB48 File Offset: 0x000FAD48
		public IBattleGraphic GetGraphic()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetGraphic_hotfix != null)
			{
				return (IBattleGraphic)this.m_GetGraphic_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_graphic;
		}

		// Token: 0x17000F5A RID: 3930
		// (get) Token: 0x060037E6 RID: 14310 RVA: 0x000FCBBC File Offset: 0x000FADBC
		public Vector2i Position
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Position_hotfix != null)
				{
					return (Vector2i)this.m_get_Position_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_position;
			}
		}

		// Token: 0x17000F5B RID: 3931
		// (get) Token: 0x060037E7 RID: 14311 RVA: 0x000FCC30 File Offset: 0x000FAE30
		public int Direction
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Direction_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_Direction_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_direction;
			}
		}

		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x060037E8 RID: 14312 RVA: 0x000FCCA4 File Offset: 0x000FAEA4
		public int FormationLine
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_FormationLine_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_FormationLine_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_formationLine;
			}
		}

		// Token: 0x17000F5D RID: 3933
		// (get) Token: 0x060037E9 RID: 14313 RVA: 0x000FCD18 File Offset: 0x000FAF18
		public int Radius
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Radius_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_Radius_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_radius;
			}
		}

		// Token: 0x17000F5E RID: 3934
		// (get) Token: 0x060037EA RID: 14314 RVA: 0x000FCD8C File Offset: 0x000FAF8C
		public int Height
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Height_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_Height_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_height;
			}
		}

		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x060037EB RID: 14315 RVA: 0x000FCE00 File Offset: 0x000FB000
		public int FootHeight
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_FootHeight_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_FootHeight_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_footHeight;
			}
		}

		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x060037EC RID: 14316 RVA: 0x000FCE74 File Offset: 0x000FB074
		public int HealthPoint
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_HealthPoint_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_HealthPoint_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_healthPoint;
			}
		}

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x060037ED RID: 14317 RVA: 0x000FCEE8 File Offset: 0x000FB0E8
		public int HealthPointMax
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_HealthPointMax_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_HealthPointMax_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_healthPointMax;
			}
		}

		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x060037EE RID: 14318 RVA: 0x000FCF5C File Offset: 0x000FB15C
		public CombatActorState State
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_State_hotfix != null)
				{
					return (CombatActorState)this.m_get_State_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_state;
			}
		}

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x060037EF RID: 14319 RVA: 0x000FCFD0 File Offset: 0x000FB1D0
		public int StateFrame
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_StateFrame_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_StateFrame_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_stateFrame;
			}
		}

		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x060037F0 RID: 14320 RVA: 0x000FD044 File Offset: 0x000FB244
		public CombatTeam Team
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Team_hotfix != null)
				{
					return (CombatTeam)this.m_get_Team_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_team;
			}
		}

		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x060037F1 RID: 14321 RVA: 0x000FD0B8 File Offset: 0x000FB2B8
		public int TeamNumber
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_TeamNumber_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_TeamNumber_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_team.TeamNumber;
			}
		}

		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x060037F2 RID: 14322 RVA: 0x000FD130 File Offset: 0x000FB330
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
				return this.m_team.Combat;
			}
		}

		// Token: 0x060037F3 RID: 14323 RVA: 0x000FD1A8 File Offset: 0x000FB3A8
		private void TickSkillStates()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickSkillStates_hotfix != null)
			{
				this.m_TickSkillStates_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (CombatSkillState ss in this.m_skillStates)
			{
				this.TickSkillHits(ss);
			}
		}

		// Token: 0x060037F4 RID: 14324 RVA: 0x000FD258 File Offset: 0x000FB458
		private void TickSkillHits(CombatSkillState ss)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickSkillHitsCombatSkillState_hotfix != null)
			{
				this.m_TickSkillHitsCombatSkillState_hotfix.call(new object[]
				{
					this,
					ss
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (ss.m_delayHits.Count <= 0)
			{
				return;
			}
			DelayHit delayHit = ss.m_delayHits[0];
			while (delayHit.m_frame <= this.m_frameCount)
			{
				CombatActor combatActor = delayHit.m_targetActor;
				if (!combatActor.CanBeTarget() && ss.m_skillInfo.SkillType == SkillType.SkillType_Slash)
				{
					combatActor = this.SearchRangeTarget(delayHit.m_position, 100);
				}
				if (combatActor != null)
				{
					bool isCritical = ss.IsCritical(combatActor.IsHero());
					if (this.Attack(combatActor, ss.m_skillInfo, isCritical))
					{
						ss.m_hitCount++;
						if (ss.m_hitCount >= ss.m_skillInfo.HitCountMax)
						{
							ss.m_delayHits.Clear();
							break;
						}
					}
				}
				ss.m_delayHits.RemoveAt(0);
				if (ss.m_delayHits.Count <= 0)
				{
					break;
				}
				delayHit = ss.m_delayHits[0];
			}
		}

		// Token: 0x060037F5 RID: 14325 RVA: 0x000FD3C0 File Offset: 0x000FB5C0
		private bool Attack(CombatActor target, ConfigDataSkillInfo skillInfo, bool isCritical)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AttackCombatActorConfigDataSkillInfoBoolean_hotfix != null)
			{
				return Convert.ToBoolean(this.m_AttackCombatActorConfigDataSkillInfoBoolean_hotfix.call(new object[]
				{
					this,
					target,
					skillInfo,
					isCritical
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (target == null || skillInfo == null)
			{
				return false;
			}
			target.AttackBy(this, skillInfo, isCritical);
			return true;
		}

		// Token: 0x060037F6 RID: 14326 RVA: 0x000FD474 File Offset: 0x000FB674
		private bool Shoot(CombatSkillState ss, CombatActor target)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShootCombatSkillStateCombatActor_hotfix != null)
			{
				return Convert.ToBoolean(this.m_ShootCombatSkillStateCombatActor_hotfix.call(new object[]
				{
					this,
					ss,
					target
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (ss == null || target == null)
			{
				return false;
			}
			ConfigDataFlyObjectInfo configDataFlyObjectInfo = this.Combat.ConfigDataLoader.GetConfigDataFlyObjectInfo(ss.m_skillInfo.SkillTypeParam1);
			if (configDataFlyObjectInfo == null)
			{
				return false;
			}
			CombatFlyObject combatFlyObject = this.m_team.CreateFlyObject();
			combatFlyObject.Setup(configDataFlyObjectInfo, ss, this, target);
			combatFlyObject.SetGraphicSkillFade(this.m_isGraphicSkillFade);
			return true;
		}

		// Token: 0x060037F7 RID: 14327 RVA: 0x000FD558 File Offset: 0x000FB758
		public void AttackBy(CombatActor attacker, ConfigDataSkillInfo skillInfo, bool isCritical)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AttackByCombatActorConfigDataSkillInfoBoolean_hotfix != null)
			{
				this.m_AttackByCombatActorConfigDataSkillInfoBoolean_hotfix.call(new object[]
				{
					this,
					attacker,
					skillInfo,
					isCritical
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (attacker == null || skillInfo == null)
			{
				return;
			}
			if (!this.Combat.IsPlay())
			{
				return;
			}
			this.PlayFx(skillInfo.Effect_Hit, 1);
			this.SetGraphicEffect(GraphicEffect.Flash, 0f, 0f);
			ArmyRelationData armyRelation = this.m_team.Combat.Battle.ComputeArmyRelationData(attacker.GetArmyInfo(), this.GetArmyInfo(), attacker.m_team.BattleActor, this.m_team.BattleActor, this.m_isHero, skillInfo.IsMagic);
			bool isBuffForceMagicDamage = !skillInfo.IsMagic && attacker.m_team.BattleActor.IsBuffForceMagicDamage(attacker.m_isHero);
			bool isBanMeleePunish = attacker.m_team.BattleActor.HasFightTag(FightTag.FightTag_BanMeleePunish);
			ConfigDataTerrainInfo terrain = this.m_team.BattleActor.GetTerrain();
			int num = BattleFormula.ComputeSkillHpModifyValue(attacker.GetBattleProperty(), this.GetBattleProperty(), armyRelation, skillInfo, isCritical, isBuffForceMagicDamage, isBanMeleePunish, terrain, this.Combat.GetCombatGridDistance(), false, this.Combat.RandomNumber, this.Combat.ConfigDataLoader);
			int num2 = 0;
			if (num < 0 && !this.IsDead())
			{
				num2 = -this.m_team.BattleActor.ComputeBuffReboundDamage(skillInfo, -num);
			}
			if (this.m_team.BattleActor.HasFightTag(FightTag.FightTag_BanDamage) && skillInfo.IsDamageSkill() && num < 0)
			{
				num = 0;
			}
			this.SetHealthPoint(this.m_healthPoint + num);
			this.m_team.OnMyActorAttackBy(this, attacker, skillInfo, num, isCritical, armyRelation);
			if (num2 != 0)
			{
				attacker.SetHealthPoint(attacker.m_healthPoint + num2);
				attacker.m_team.OnMyActorReboundDamage(attacker, this, skillInfo, num2);
			}
			if (this.IsDead())
			{
				this.m_deathAnimType = skillInfo.DeadAnimType;
			}
		}

		// Token: 0x060037F8 RID: 14328 RVA: 0x000FD7A4 File Offset: 0x000FB9A4
		public void SetHealthPoint(int value)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHealthPointInt32_hotfix != null)
			{
				this.m_SetHealthPointInt32_hotfix.call(new object[]
				{
					this,
					value
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_healthPoint = value;
			if (this.m_healthPoint < 0)
			{
				this.m_healthPoint = 0;
			}
			else if (this.m_healthPoint > this.m_healthPointMax)
			{
				this.m_healthPoint = this.m_healthPointMax;
			}
		}

		// Token: 0x060037F9 RID: 14329 RVA: 0x000FD850 File Offset: 0x000FBA50
		public void PreAttack(CombatActor target, ConfigDataSkillInfo skillInfo, bool isCritical)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PreAttackCombatActorConfigDataSkillInfoBoolean_hotfix != null)
			{
				this.m_PreAttackCombatActorConfigDataSkillInfoBoolean_hotfix.call(new object[]
				{
					this,
					target,
					skillInfo,
					isCritical
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (target == null || skillInfo == null)
			{
				return;
			}
			ArmyRelationData armyRelation = this.m_team.Combat.Battle.ComputeArmyRelationData(this.GetArmyInfo(), target.GetArmyInfo(), this.m_team.BattleActor, target.m_team.BattleActor, target.m_isHero, skillInfo.IsMagic);
			bool isBuffForceMagicDamage = !skillInfo.IsMagic && this.m_team.BattleActor.IsBuffForceMagicDamage(this.m_isHero);
			bool isBanMeleePunish = this.m_team.BattleActor.HasFightTag(FightTag.FightTag_BanMeleePunish);
			ConfigDataTerrainInfo terrain = target.m_team.BattleActor.GetTerrain();
			int num = BattleFormula.ComputeSkillHpModifyValue(this.GetBattleProperty(), target.GetBattleProperty(), armyRelation, skillInfo, isCritical, isBuffForceMagicDamage, isBanMeleePunish, terrain, this.Combat.GetCombatGridDistance(), false, this.Combat.RandomNumber, this.Combat.ConfigDataLoader);
			target.m_preAttackHp += num;
			if (target.m_preAttackHp < 0)
			{
				target.m_preAttackHp = 0;
			}
			else if (target.m_preAttackHp > target.m_healthPointMax)
			{
				target.m_preAttackHp = target.m_healthPointMax;
			}
		}

		// Token: 0x060037FA RID: 14330 RVA: 0x000FD9FC File Offset: 0x000FBBFC
		public int GetPreAttackHealthPoint()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPreAttackHealthPoint_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetPreAttackHealthPoint_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_preAttackHp;
		}

		// Token: 0x060037FB RID: 14331 RVA: 0x000FDA70 File Offset: 0x000FBC70
		public void AddBeHitId(ushort id)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddBeHitIdUInt16_hotfix != null)
			{
				this.m_AddBeHitIdUInt16_hotfix.call(new object[]
				{
					this,
					id
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (id == 0)
			{
				return;
			}
			for (int i = this.m_beHitIds.Length - 1; i > 0; i--)
			{
				this.m_beHitIds[i] = this.m_beHitIds[i - 1];
			}
			this.m_beHitIds[0] = id;
		}

		// Token: 0x060037FC RID: 14332 RVA: 0x000FDB20 File Offset: 0x000FBD20
		public bool HasBeHitId(ushort id)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasBeHitIdUInt16_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasBeHitIdUInt16_hotfix.call(new object[]
				{
					this,
					id
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (id == 0)
			{
				return false;
			}
			foreach (ushort num in this.m_beHitIds)
			{
				if (num == id)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060037FD RID: 14333 RVA: 0x000FDBD0 File Offset: 0x000FBDD0
		private CombatSkillState CreateSkillState(ConfigDataSkillInfo skillInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateSkillStateConfigDataSkillInfo_hotfix != null)
			{
				return (CombatSkillState)this.m_CreateSkillStateConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					skillInfo
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (skillInfo == null)
			{
				return null;
			}
			CombatSkillState combatSkillState = new CombatSkillState();
			combatSkillState.m_skillInfo = skillInfo;
			combatSkillState.m_hitId = this.Combat.GetNextHitId();
			combatSkillState.m_hitCount = 0;
			combatSkillState.m_preAttackHitCount = 0;
			if (this.m_isHero)
			{
				combatSkillState.m_isToHeroCritical = this.m_team.ShouldHeroToHeroCriticalAttack;
				combatSkillState.m_isToSoldierCritical = this.m_team.ShouldHeroToSoldierCriticalAttack;
			}
			else
			{
				combatSkillState.m_isToHeroCritical = this.m_team.ShouldSoldierToHeroCriticalAttack;
				combatSkillState.m_isToSoldierCritical = this.m_team.ShouldSoldierToSoldierCriticalAttack;
			}
			this.m_skillStates.Add(combatSkillState);
			return combatSkillState;
		}

		// Token: 0x060037FE RID: 14334 RVA: 0x000FDCE4 File Offset: 0x000FBEE4
		private void AddSkillDelayHit(CombatSkillState ss, CombatActor target, int delay)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddSkillDelayHitCombatSkillStateCombatActorInt32_hotfix != null)
			{
				this.m_AddSkillDelayHitCombatSkillStateCombatActorInt32_hotfix.call(new object[]
				{
					this,
					ss,
					target,
					delay
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (ss == null || target == null)
			{
				return;
			}
			int frame = this.m_frameCount + Combat.MillisecondToFrame(delay);
			ss.AddDelayHit(frame, this.m_position, target);
			this.SetCanStopFrame(delay + this.Combat.ConfigDataLoader.Const_DamagePostDelay);
		}

		// Token: 0x060037FF RID: 14335 RVA: 0x000FDDB8 File Offset: 0x000FBFB8
		private void AddMagicDamageSkillDelayHits(CombatSkillState ss)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddMagicDamageSkillDelayHitsCombatSkillState_hotfix != null)
			{
				this.m_AddMagicDamageSkillDelayHitsCombatSkillState_hotfix.call(new object[]
				{
					this,
					ss
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = ss.m_skillInfo.Time_Hit;
			int num2 = 0;
			while (ss.m_preAttackHitCount < ss.m_skillInfo.HitCountMax)
			{
				CombatActor combatActor = this.SearchRandomHitTarget(ss.m_hitId, ss.m_skillInfo.SkillTypeParam3);
				if (combatActor == null)
				{
					CombatActor hero = this.m_team.GetTargetTeam().GetHero();
					if (hero != null && hero.CanBeTarget())
					{
						combatActor = hero;
					}
				}
				if (combatActor != null)
				{
					bool isCritical = ss.IsCritical(combatActor.IsHero());
					do
					{
						this.AddSkillDelayHit(ss, combatActor, num);
						this.PreAttack(combatActor, ss.m_skillInfo, isCritical);
						if (ss.m_skillInfo.Time_MultiHit.Count > 0)
						{
							num += ss.m_skillInfo.Time_MultiHit[num2 % ss.m_skillInfo.Time_MultiHit.Count];
							num2++;
						}
						ss.m_preAttackHitCount++;
						if (combatActor.m_preAttackHp <= 0 && !combatActor.IsHero())
						{
							break;
						}
					}
					while (ss.m_preAttackHitCount < ss.m_skillInfo.HitCountMax);
					IL_163:
					combatActor.AddBeHitId(ss.m_hitId);
					continue;
					goto IL_163;
				}
				break;
			}
		}

		// Token: 0x06003800 RID: 14336 RVA: 0x000FDF54 File Offset: 0x000FC154
		private void AddChargeSkillDelayHits(CombatSkillState ss)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddChargeSkillDelayHitsCombatSkillState_hotfix != null)
			{
				this.m_AddChargeSkillDelayHitsCombatSkillState_hotfix.call(new object[]
				{
					this,
					ss
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = ss.m_skillInfo.Time_Hit;
			int num2 = 0;
			int num3 = ss.GetDelayHitFrameMax() - this.m_frameCount;
			if (num3 >= 0)
			{
				num = Combat.FrameToMillisecond(num3);
				if (ss.m_skillInfo.Time_MultiHit.Count > 0)
				{
					num += ss.m_skillInfo.Time_MultiHit[0];
					num2 = 1;
				}
			}
			while (ss.m_preAttackHitCount < ss.m_skillInfo.HitCountMax)
			{
				CombatActor combatActor = this.SearchHitTarget(ss.m_skillInfo.AttackDistance, ss.m_hitId);
				if (combatActor == null)
				{
					CombatActor hero = this.m_team.GetTargetTeam().GetHero();
					if (hero != null && hero.CanBeTarget() && this.IsTargetInAttackDistance(hero, ss.m_skillInfo.AttackDistance))
					{
						combatActor = hero;
					}
				}
				if (combatActor != null)
				{
					bool isCritical = ss.IsCritical(combatActor.IsHero());
					do
					{
						this.AddSkillDelayHit(ss, combatActor, num);
						this.PreAttack(combatActor, ss.m_skillInfo, isCritical);
						if (ss.m_skillInfo.Time_MultiHit.Count > 0)
						{
							num += ss.m_skillInfo.Time_MultiHit[num2 % ss.m_skillInfo.Time_MultiHit.Count];
							num2++;
						}
						ss.m_preAttackHitCount++;
						if (combatActor.m_preAttackHp <= 0 && !combatActor.IsHero())
						{
							break;
						}
					}
					while (ss.m_preAttackHitCount < ss.m_skillInfo.HitCountMax);
					IL_1C7:
					combatActor.AddBeHitId(ss.m_hitId);
					continue;
					goto IL_1C7;
				}
				break;
			}
		}

		// Token: 0x06003801 RID: 14337 RVA: 0x000FE154 File Offset: 0x000FC354
		public bool CanBeTarget()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanBeTarget_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CanBeTarget_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return !this.IsDead() && this.IsVisible();
		}

		// Token: 0x06003802 RID: 14338 RVA: 0x000FE1D4 File Offset: 0x000FC3D4
		private void ChangeFightTarget(CombatActor target)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ChangeFightTargetCombatActor_hotfix != null)
			{
				this.m_ChangeFightTargetCombatActor_hotfix.call(new object[]
				{
					this,
					target
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (target == this.m_targetActor)
			{
				return;
			}
			this.m_targetActor = target;
			MoveType targetMoveType = MoveType.MoveType_None;
			if (target != null)
			{
				targetMoveType = target.GetMoveType();
			}
			if (this.m_isHero)
			{
				if (this.m_team.HeroSkill != null)
				{
					this.m_skillInfo = this.m_team.HeroSkill;
				}
				else
				{
					this.m_skillInfo = this.m_team.BattleActor.GetHeroAttackSkillInfo(targetMoveType, this.Combat.GetCombatGridDistance());
				}
			}
			else
			{
				this.m_skillInfo = this.m_team.BattleActor.GetSoldierAttackSkillInfo(targetMoveType, this.Combat.GetCombatGridDistance());
			}
		}

		// Token: 0x06003803 RID: 14339 RVA: 0x000FE2E4 File Offset: 0x000FC4E4
		private CombatActor SearchTarget()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SearchTarget_hotfix != null)
			{
				return (CombatActor)this.m_SearchTarget_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CombatTeam targetTeam = this.m_team.GetTargetTeam();
			int num = int.MaxValue;
			CombatActor result = null;
			if (!this.m_team.IsAttackHeroOnly())
			{
				foreach (CombatActor combatActor in targetTeam.GetActors())
				{
					if (combatActor.CanBeTarget())
					{
						int num2 = CombatActor.ComputeTargetScore(this.m_position, combatActor);
						if (num2 < num)
						{
							num = num2;
							result = combatActor;
						}
					}
				}
				return result;
			}
			CombatActor hero = targetTeam.GetHero();
			if (hero != null && hero.CanBeTarget())
			{
				return hero;
			}
			return null;
		}

		// Token: 0x06003804 RID: 14340 RVA: 0x000FE40C File Offset: 0x000FC60C
		private CombatActor SearchRangeTarget(Vector2i pos, int maxDistance)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SearchRangeTargetVector2iInt32_hotfix != null)
			{
				return (CombatActor)this.m_SearchRangeTargetVector2iInt32_hotfix.call(new object[]
				{
					this,
					pos,
					maxDistance
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CombatTeam targetTeam = this.m_team.GetTargetTeam();
			int num = int.MaxValue;
			CombatActor result = null;
			if (!this.m_team.IsAttackHeroOnly())
			{
				foreach (CombatActor combatActor in targetTeam.GetActors())
				{
					if (combatActor.CanBeTarget())
					{
						if (Math.Abs((int)((long)(combatActor.m_position.x - pos.x))) <= maxDistance)
						{
							int num2 = CombatActor.ComputeTargetScore(pos, combatActor);
							if (num2 < num)
							{
								num = num2;
								result = combatActor;
							}
						}
					}
				}
				return result;
			}
			CombatActor hero = targetTeam.GetHero();
			if (hero != null && hero.CanBeTarget() && Math.Abs((int)((long)(hero.m_position.x - pos.x))) <= maxDistance)
			{
				return hero;
			}
			return null;
		}

		// Token: 0x06003805 RID: 14341 RVA: 0x000FE5A4 File Offset: 0x000FC7A4
		private CombatActor SearchHitTarget(int attackDistance, ushort hitId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SearchHitTargetInt32UInt16_hotfix != null)
			{
				return (CombatActor)this.m_SearchHitTargetInt32UInt16_hotfix.call(new object[]
				{
					this,
					attackDistance,
					hitId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CombatTeam targetTeam = this.m_team.GetTargetTeam();
			int num = int.MaxValue;
			CombatActor result = null;
			if (!this.m_team.IsAttackHeroOnly())
			{
				foreach (CombatActor combatActor in targetTeam.GetActors())
				{
					if (combatActor.CanBeTarget())
					{
						if (combatActor.m_preAttackHp > 0)
						{
							if (this.IsTargetInAttackDistance(combatActor, attackDistance))
							{
								if (!combatActor.HasBeHitId(hitId))
								{
									int num2 = CombatActor.ComputeTargetScore(this.m_position, combatActor);
									if (num2 < num)
									{
										num = num2;
										result = combatActor;
									}
								}
							}
						}
					}
				}
				return result;
			}
			CombatActor hero = targetTeam.GetHero();
			if (hero != null && hero.CanBeTarget() && this.IsTargetInAttackDistance(hero, attackDistance))
			{
				return hero;
			}
			return null;
		}

		// Token: 0x06003806 RID: 14342 RVA: 0x000FE730 File Offset: 0x000FC930
		private CombatActor SearchRandomHitTarget(ushort hitId, int targetType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SearchRandomHitTargetUInt16Int32_hotfix != null)
			{
				return (CombatActor)this.m_SearchRandomHitTargetUInt16Int32_hotfix.call(new object[]
				{
					this,
					hitId,
					targetType
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CombatTeam targetTeam = this.m_team.GetTargetTeam();
			int num = int.MaxValue;
			CombatActor result = null;
			if (!this.m_team.IsAttackHeroOnly())
			{
				foreach (CombatActor combatActor in targetTeam.GetActors())
				{
					if (combatActor.CanBeTarget())
					{
						if (combatActor.m_preAttackHp > 0)
						{
							if (!combatActor.HasBeHitId(hitId))
							{
								int num2 = this.Combat.RandomNumber.Next(0, 100);
								if (targetType == 1)
								{
									if (!combatActor.IsHero())
									{
										num2 += 1000;
									}
								}
								else if (combatActor.IsHero())
								{
									num2 += 1000;
								}
								if (num2 < num)
								{
									num = num2;
									result = combatActor;
								}
							}
						}
					}
				}
				return result;
			}
			CombatActor hero = targetTeam.GetHero();
			if (hero != null && hero.CanBeTarget())
			{
				return hero;
			}
			return null;
		}

		// Token: 0x06003807 RID: 14343 RVA: 0x000FE8D8 File Offset: 0x000FCAD8
		private static int ComputeTargetScore(Vector2i pos, CombatActor target)
		{
			int num = 0;
			if (target.m_preAttackHp <= 0)
			{
				num = 1000000;
			}
			num += target.m_formationLine * 100000;
			return num + (int)((long)(pos - target.m_position).sqrMagnitude) / 100;
		}

		// Token: 0x06003808 RID: 14344 RVA: 0x000FE92C File Offset: 0x000FCB2C
		private bool IsTargetInAttackDistance(CombatActor target, int attackDistance)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsTargetInAttackDistanceCombatActorInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsTargetInAttackDistanceCombatActorInt32_hotfix.call(new object[]
				{
					this,
					target,
					attackDistance
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return Math.Abs((int)((long)(target.m_position.x - this.m_position.x))) <= attackDistance + target.Radius;
		}

		// Token: 0x06003809 RID: 14345 RVA: 0x000FE9EC File Offset: 0x000FCBEC
		private void TickState()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickState_hotfix != null)
			{
				this.m_TickState_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			do
			{
				this.m_isStateChanged = false;
				switch (this.m_state)
				{
				case CombatActorState.Enter:
					this.StateEnter();
					break;
				case CombatActorState.Exit:
					this.StateExit();
					break;
				case CombatActorState.Idle:
					this.StateIdle();
					break;
				case CombatActorState.Fight:
					this.StateFight();
					break;
				case CombatActorState.FightEnd:
					this.StateFightEnd();
					break;
				case CombatActorState.FightAgain:
					this.StateFightAgain();
					break;
				case CombatActorState.Skill:
					this.StateSkill();
					break;
				case CombatActorState.Die:
					this.StateDie();
					break;
				case CombatActorState.Return:
					this.StateReturn();
					break;
				case CombatActorState.Stop:
					this.StateStop();
					break;
				}
				num++;
			}
			while (this.m_isStateChanged && num < 10);
			this.m_stateFrame++;
			if (num >= 10 && this.m_team.Combat.Battle.IsEnableDebugLog())
			{
				DebugUtility.LogWarning(string.Concat(new object[]
				{
					"Actor ",
					this.m_id,
					" TickState ",
					num
				}));
			}
		}

		// Token: 0x0600380A RID: 14346 RVA: 0x000FEB80 File Offset: 0x000FCD80
		private void ChangeState(CombatActorState state)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ChangeStateCombatActorState_hotfix != null)
			{
				this.m_ChangeStateCombatActorState_hotfix.call(new object[]
				{
					this,
					state
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_state = state;
			this.m_stateFrame = 0;
			this.m_isStateChanged = true;
		}

		// Token: 0x0600380B RID: 14347 RVA: 0x000FEC08 File Offset: 0x000FCE08
		private void StateEnter()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StateEnter_hotfix != null)
			{
				this.m_StateEnter_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_stateFrame == 0)
			{
				this.PlayAnimation("run", true);
			}
			int num = Combat.MillisecondToFrame1(250);
			if (this.m_stateFrame < num)
			{
				this.MoveX(this.m_direction, (Fix64)500L / (Fix64)((long)num), false);
			}
			else
			{
				this.PlayAnimation("idle", true);
			}
		}

		// Token: 0x0600380C RID: 14348 RVA: 0x000FECCC File Offset: 0x000FCECC
		private void StateExit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StateExit_hotfix != null)
			{
				this.m_StateExit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_stateFrame == 0)
			{
				this.PlayAnimation("run", true);
				this.SetDirection(-this.m_initDirection);
				this.ClearGraphicEffect(GraphicEffect.Ghost);
			}
			int num = Combat.MillisecondToFrame1(250);
			if (this.m_stateFrame < num)
			{
				this.MoveX(this.m_direction, (Fix64)500L / (Fix64)((long)num), false);
			}
			else
			{
				this.PlayAnimation("idle", true);
			}
		}

		// Token: 0x0600380D RID: 14349 RVA: 0x000FEDA4 File Offset: 0x000FCFA4
		private void StateIdle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StateIdle_hotfix != null)
			{
				this.m_StateIdle_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsDead())
			{
				this.ChangeState(CombatActorState.Die);
				return;
			}
			if (this.m_team.CanReturn())
			{
				this.ChangeState(CombatActorState.Return);
				return;
			}
			if (this.m_stateFrame == 0)
			{
				this.PlayAnimation("idle", true);
			}
		}

		// Token: 0x0600380E RID: 14350 RVA: 0x000FEE48 File Offset: 0x000FD048
		private void StateFight()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StateFight_hotfix != null)
			{
				this.m_StateFight_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsDead())
			{
				this.ChangeState(CombatActorState.Die);
				return;
			}
			if (this.m_targetActor != null && (!this.m_targetActor.CanBeTarget() || this.m_targetActor.m_preAttackHp <= 0))
			{
				this.ChangeFightTarget(null);
			}
			if (this.m_targetActor == null)
			{
				this.ChangeFightTarget(this.SearchTarget());
				if (this.m_targetActor == null)
				{
					this.ChangeState(CombatActorState.FightEnd);
					return;
				}
			}
			if (this.m_stateFrame == 0)
			{
				if (this.m_skillInfo == null)
				{
					this.ChangeState(CombatActorState.FightEnd);
					return;
				}
				if (this.IsHero())
				{
					this.m_stateWaitFrame = Combat.MillisecondToFrame(this.m_skillInfo.HeroMoveDelay);
				}
				else
				{
					this.m_stateWaitFrame = Combat.MillisecondToFrame(this.Combat.RandomNumber.Next(0, this.Combat.ConfigDataLoader.Const_SoldierMoveDelay));
				}
				if (this.m_stateWaitFrame > 0)
				{
					this.PlayAnimation("idle", true);
				}
			}
			if (this.m_stateFrame >= this.m_stateWaitFrame)
			{
				if (this.m_stateFrame == this.m_stateWaitFrame && this.m_skillInfo.SkillType == SkillType.SkillType_Charge)
				{
					this.ChangeState(CombatActorState.Skill);
					return;
				}
				Fix64 fix = this.m_targetActor.m_position.x - this.m_position.x;
				Fix64 fix2 = Fix64.Abs(fix);
				Fix64 fix3 = (Fix64)((long)(this.m_skillInfo.AttackDistance + this.m_targetActor.Radius));
				if (fix2 <= fix3)
				{
					this.ChangeState(CombatActorState.Skill);
					return;
				}
				if (this.m_stateFrame == this.m_stateWaitFrame)
				{
					this.PlayAnimation("run", true);
				}
				if (fix > Fix64.Zero)
				{
					fix -= fix3 - Fix64.One;
				}
				else
				{
					fix += fix3 - Fix64.One;
				}
				fix2 = Fix64.Abs(fix);
				if (fix2 > Fix64.Zero)
				{
					Fix64 a = (Fix64)((long)this.GetMoveSpeed()) * CombatConst.TickTime;
					this.MoveX(Fix64.Sign(fix), MathUtility.Min(a, fix2), false);
					fix2 = Fix64.Abs(this.m_targetActor.m_position.x - this.m_position.x);
					if (fix2 <= fix3)
					{
						this.ChangeState(CombatActorState.Skill);
						return;
					}
				}
			}
		}

		// Token: 0x0600380F RID: 14351 RVA: 0x000FF108 File Offset: 0x000FD308
		private void StateFightEnd()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StateFightEnd_hotfix != null)
			{
				this.m_StateFightEnd_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsDead())
			{
				this.ChangeState(CombatActorState.Die);
				return;
			}
			if (this.m_team.CanReturn())
			{
				this.ChangeState(CombatActorState.Return);
				return;
			}
			if (this.m_stateFrame == 0)
			{
				this.PlayAnimation("idle", true);
			}
		}

		// Token: 0x06003810 RID: 14352 RVA: 0x000FF1AC File Offset: 0x000FD3AC
		private void StateFightAgain()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StateFightAgain_hotfix != null)
			{
				this.m_StateFightAgain_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsDead())
			{
				this.ChangeState(CombatActorState.Die);
				return;
			}
			if (this.m_stateFrame == 0)
			{
				this.m_direction = this.m_initDirection;
				if (this.m_team.BattleActor.HasFightTag(FightTag.FightTag_Stun))
				{
					this.PlayAnimation("stun", true);
				}
				else
				{
					this.PlayAnimation("idle", true);
				}
			}
			if (this.m_stateFrame == Combat.MillisecondToFrame(100))
			{
				this.ClearAttachFxs(2);
				BuffState doubleAttackBuff = this.m_team.GetDoubleAttackBuff();
				if (doubleAttackBuff != null)
				{
					this.PlayFx(doubleAttackBuff.m_buffInfo.Effect_Acting, 2);
				}
				this.m_team.OnMyActorFightAgain(this);
				this.ChangeState(CombatActorState.Fight);
				return;
			}
		}

		// Token: 0x06003811 RID: 14353 RVA: 0x000FF2BC File Offset: 0x000FD4BC
		private void StateSkill()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StateSkill_hotfix != null)
			{
				this.m_StateSkill_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsDead())
			{
				this.ChangeState(CombatActorState.Die);
				return;
			}
			if (this.m_stateFrame == 0)
			{
				this.m_curSkillState = this.CreateSkillState(this.m_skillInfo);
				this.m_skillUseCount++;
				if (this.m_skillInfo.Time_Sing > 0)
				{
					this.PlayAnimation("sing", true);
					this.PlayFx(this.m_skillInfo.Effect_Sing, 1);
				}
				bool isCritical = this.m_curSkillState.IsCritical(this.m_targetActor.IsHero());
				if (this.m_skillInfo.SkillType == SkillType.SkillType_Slash)
				{
					this.PreAttack(this.m_targetActor, this.m_skillInfo, isCritical);
				}
				else if (this.m_skillInfo.SkillType == SkillType.SkillType_Shoot)
				{
					ConfigDataFlyObjectInfo configDataFlyObjectInfo = this.Combat.ConfigDataLoader.GetConfigDataFlyObjectInfo(this.m_skillInfo.SkillTypeParam1);
					if (configDataFlyObjectInfo != null && configDataFlyObjectInfo.TrackType == TrackType.TrackType_Parabolic)
					{
						this.PreAttack(this.m_targetActor, this.m_skillInfo, isCritical);
					}
				}
			}
			int num = this.m_skillInfo.Time_Sing;
			if (!string.IsNullOrEmpty(this.m_skillInfo.Effect_PreCast))
			{
				num += this.Combat.ConfigDataLoader.Const_SkillPreCastDelay;
			}
			int num2 = Combat.MillisecondToFrame(num);
			if (this.m_stateFrame == Combat.MillisecondToFrame(this.m_skillInfo.Time_Sing))
			{
				this.PlayFx(this.m_skillInfo.Effect_PreCast, 1);
			}
			if (this.m_stateFrame == Math.Max(num2 - 1, 0))
			{
				this.m_team.OnMyActorCastSkill(this, this.m_skillInfo);
			}
			if (this.m_stateFrame == num2)
			{
				bool loop = this.m_skillInfo.SkillType == SkillType.SkillType_Charge;
				this.PlayAnimation(this.m_skillInfo.Anim_Cast, loop);
				if (this.m_skillInfo.SkillType == SkillType.SkillType_Charge && this.m_skillInfo.SkillTypeParam2 != 0)
				{
					this.SetGraphicEffect(GraphicEffect.Ghost, 0f, 0f);
				}
			}
			if (this.m_stateFrame >= num2)
			{
				if (this.m_stateFrame == Combat.MillisecondToFrame(num + this.m_skillInfo.Time_EffCast1))
				{
					this.PlaySkillFx(this.m_skillInfo.Effect_Cast1, this.m_skillInfo.Effect_Cast1_Far);
					if (this.m_skillInfo.SkillType == SkillType.SkillType_Slash)
					{
						this.AddSkillDelayHit(this.m_curSkillState, this.m_targetActor, this.m_skillInfo.Time_Hit);
						this.m_targetActor.AddBeHitId(this.m_curSkillState.m_hitId);
					}
					else if (this.m_skillInfo.SkillType == SkillType.SkillType_MagicDamage)
					{
						this.AddMagicDamageSkillDelayHits(this.m_curSkillState);
					}
					int num3 = this.m_skillInfo.Time_Hit;
					if (this.m_skillInfo.Time_MultiHit.Count > 0)
					{
						for (int i = 1; i < this.m_skillInfo.HitCountMax; i++)
						{
							num3 += this.m_skillInfo.Time_MultiHit[i % this.m_skillInfo.Time_MultiHit.Count];
						}
					}
					this.SetCanStopFrame(num3);
				}
				if (this.m_stateFrame == Combat.MillisecondToFrame(num + this.m_skillInfo.Time_EffCast2))
				{
					this.PlaySkillFx(this.m_skillInfo.Effect_Cast2, this.m_skillInfo.Effect_Cast2_Far);
				}
				if (this.m_stateFrame == Combat.MillisecondToFrame(num + this.m_skillInfo.Time_EffMagic1))
				{
					this.PlaySkillFx(this.m_skillInfo.Effect_Magic1, this.m_skillInfo.Effect_Magic1_Far);
				}
				if (this.m_stateFrame == Combat.MillisecondToFrame(num + this.m_skillInfo.Time_EffMagic2))
				{
					this.PlaySkillFx(this.m_skillInfo.Effect_Magic2, this.m_skillInfo.Effect_Magic2_Far);
				}
				if (this.m_skillInfo.SkillType == SkillType.SkillType_Charge)
				{
					Fix64 distance = (Fix64)((long)this.m_skillInfo.SkillTypeParam1) * CombatConst.TickTime;
					this.MoveX(this.m_direction, distance, false);
					int num4 = (int)((long)this.m_position.x);
					if ((this.m_direction > 0 && num4 > 300) || (this.m_direction < 0 && num4 < -300))
					{
						this.ChangeState(CombatActorState.Return);
						return;
					}
					this.AddChargeSkillDelayHits(this.m_curSkillState);
				}
				else
				{
					if (this.m_stateFrame == Combat.MillisecondToFrame(num + this.m_skillInfo.Time_Hit) && this.m_skillInfo.SkillType == SkillType.SkillType_Shoot)
					{
						this.Shoot(this.m_curSkillState, this.m_targetActor);
					}
					if (this.m_skillUseCount < this.m_skillInfo.AttackCount)
					{
						if (this.m_skillInfo.Time_NextAttack > 0 && this.m_stateFrame == Combat.MillisecondToFrame(num + this.m_skillInfo.Time_End))
						{
							this.PlayAnimation("idle", true);
						}
						if (this.m_stateFrame == Combat.MillisecondToFrame(num + this.m_skillInfo.Time_End + this.m_skillInfo.Time_NextAttack))
						{
							this.ChangeState(CombatActorState.Fight);
							return;
						}
					}
					else if (this.m_stateFrame == Combat.MillisecondToFrame(num + this.m_skillInfo.Time_End))
					{
						this.ChangeState(CombatActorState.FightEnd);
						return;
					}
				}
			}
		}

		// Token: 0x06003812 RID: 14354 RVA: 0x000FF85C File Offset: 0x000FDA5C
		private void StateDie()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StateDie_hotfix != null)
			{
				this.m_StateDie_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_stateFrame == 0)
			{
				this.ChangeFightTarget(null);
				this.ClearGraphicEffect(GraphicEffect.Ghost);
				this.ClearAttachFxs(2);
				this.PlayDeathAnimation(this.m_deathAnimType);
				this.m_team.OnMyActorDie(this);
				this.m_direction = this.m_initDirection;
				int dieFlyDistanceMin;
				int dieFlyDistanceMax;
				if (this.IsHero())
				{
					this.m_stateMoveDistance = 0;
					dieFlyDistanceMin = this.m_team.JobInfo.DieFlyDistanceMin;
					dieFlyDistanceMax = this.m_team.JobInfo.DieFlyDistanceMax;
				}
				else
				{
					dieFlyDistanceMin = this.m_team.SoldierInfo.DieFlyDistanceMin;
					dieFlyDistanceMax = this.m_team.SoldierInfo.DieFlyDistanceMax;
				}
				this.m_stateMoveDistance = this.Combat.RandomNumber.Next(dieFlyDistanceMin, dieFlyDistanceMax);
				this.SetCanStopFrame(1000);
			}
			if (this.m_stateMoveDistance > 0)
			{
				int num = Combat.MillisecondToFrame(1000);
				if (this.m_stateFrame < num)
				{
					this.MoveX(-this.m_direction, (Fix64)((long)this.m_stateMoveDistance) / (Fix64)((long)num), false);
				}
			}
			if (!this.IsHero() && this.m_stateFrame == Combat.MillisecondToFrame(1500))
			{
				this.SetGraphicEffect(GraphicEffect.FadeOut, 0.3f, 0f);
			}
		}

		// Token: 0x06003813 RID: 14355 RVA: 0x000FF9F8 File Offset: 0x000FDBF8
		private void StateReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StateReturn_hotfix != null)
			{
				this.m_StateReturn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsDead())
			{
				this.ChangeState(CombatActorState.Die);
				return;
			}
			if (this.m_stateFrame == 0)
			{
				this.ChangeFightTarget(null);
				if (this.IsHero() || this.GetMoveType() == MoveType.MoveType_Ride)
				{
					this.m_stateWaitFrame = 0;
				}
				else
				{
					this.m_stateWaitFrame = Combat.MillisecondToFrame(this.Combat.RandomNumber.Next(0, this.Combat.ConfigDataLoader.Const_SoldierReturnDelay));
					if (this.m_stateWaitFrame > 0)
					{
						this.PlayAnimation("idle", true);
					}
				}
			}
			if (this.m_stateFrame >= this.m_stateWaitFrame)
			{
				if (this.m_stateFrame == this.m_stateWaitFrame)
				{
					this.PlayAnimation("run", true);
				}
				Fix64 value = this.m_initPosition.x - this.m_position.x;
				Fix64 fix = Fix64.Abs(value);
				if (fix > Fix64.Zero)
				{
					int num = this.GetMoveSpeed();
					if (this.m_skillInfo != null && this.m_skillInfo.SkillType == SkillType.SkillType_Charge)
					{
						num = this.m_skillInfo.SkillTypeParam1;
					}
					Fix64 a = (Fix64)((long)num) * CombatConst.TickTime;
					this.MoveX(Fix64.Sign(value), MathUtility.Min(a, fix), true);
				}
				else
				{
					if (this.IsHero() && this.m_team.GetDoubleAttackBuff() != null && !this.m_isDoubleAttacked && this.SearchTarget() != null)
					{
						this.m_isDoubleAttacked = true;
						this.m_skillUseCount = 0;
						this.ChangeState(CombatActorState.FightAgain);
						return;
					}
					this.ChangeState(CombatActorState.Stop);
					return;
				}
			}
		}

		// Token: 0x06003814 RID: 14356 RVA: 0x000FFBF0 File Offset: 0x000FDDF0
		private void StateStop()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StateStop_hotfix != null)
			{
				this.m_StateStop_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsDead())
			{
				this.ChangeState(CombatActorState.Die);
				return;
			}
			if (this.m_stateFrame == 0)
			{
				this.m_direction = this.m_initDirection;
				if (this.m_team.BattleActor.HasFightTag(FightTag.FightTag_Stun))
				{
					this.PlayAnimation("stun", true);
				}
				else
				{
					this.PlayAnimation("idle", true);
				}
				this.SetCanStopFrame(200);
				this.ClearAttachFxs(2);
			}
		}

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x06003815 RID: 14357 RVA: 0x000FFCC0 File Offset: 0x000FDEC0
		// (set) Token: 0x06003816 RID: 14358 RVA: 0x000FFCE0 File Offset: 0x000FDEE0
		[DoNotToLua]
		public new CombatActor.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new CombatActor.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06003817 RID: 14359 RVA: 0x000FFCEC File Offset: 0x000FDEEC
		private void __callBase_Dispose()
		{
			base.Dispose();
		}

		// Token: 0x06003818 RID: 14360 RVA: 0x000FFCF4 File Offset: 0x000FDEF4
		private void __callBase_Tick()
		{
			base.Tick();
		}

		// Token: 0x06003819 RID: 14361 RVA: 0x000FFCFC File Offset: 0x000FDEFC
		private void __callBase_TickGraphic(float dt)
		{
			base.TickGraphic(dt);
		}

		// Token: 0x0600381A RID: 14362 RVA: 0x000FFD08 File Offset: 0x000FDF08
		private void __callBase_Draw()
		{
			base.Draw();
		}

		// Token: 0x0600381B RID: 14363 RVA: 0x000FFD10 File Offset: 0x000FDF10
		private void __callBase_Pause(bool pause)
		{
			base.Pause(pause);
		}

		// Token: 0x0600381C RID: 14364 RVA: 0x000FFD1C File Offset: 0x000FDF1C
		private void __callBase_DoPause(bool pause)
		{
			base.DoPause(pause);
		}

		// Token: 0x0600381D RID: 14365 RVA: 0x000FFD28 File Offset: 0x000FDF28
		private void __callBase_DeleteMe()
		{
			base.DeleteMe();
		}

		// Token: 0x0600381E RID: 14366 RVA: 0x000FFD30 File Offset: 0x000FDF30
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
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_Dispose_hotfix = (luaObj.RawGet("Dispose") as LuaFunction);
					this.m_InitializeCombatTeamBoolean_hotfix = (luaObj.RawGet("Initialize") as LuaFunction);
					this.m_Tick_hotfix = (luaObj.RawGet("Tick") as LuaFunction);
					this.m_TickGraphicSingle_hotfix = (luaObj.RawGet("TickGraphic") as LuaFunction);
					this.m_Draw_hotfix = (luaObj.RawGet("Draw") as LuaFunction);
					this.m_DoPauseBoolean_hotfix = (luaObj.RawGet("DoPause") as LuaFunction);
					this.m_EnterCombat_hotfix = (luaObj.RawGet("EnterCombat") as LuaFunction);
					this.m_StartCombat_hotfix = (luaObj.RawGet("StartCombat") as LuaFunction);
					this.m_StopCombat_hotfix = (luaObj.RawGet("StopCombat") as LuaFunction);
					this.m_CanStopCombat_hotfix = (luaObj.RawGet("CanStopCombat") as LuaFunction);
					this.m_LogCanNotStopCombat_hotfix = (luaObj.RawGet("LogCanNotStopCombat") as LuaFunction);
					this.m_SetCanStopFrameInt32_hotfix = (luaObj.RawGet("SetCanStopFrame") as LuaFunction);
					this.m_SetPositionInt32Int32_hotfix = (luaObj.RawGet("SetPosition") as LuaFunction);
					this.m_SetPositionVector2i_hotfix = (luaObj.RawGet("SetPosition") as LuaFunction);
					this.m_SetDirectionInt32_hotfix = (luaObj.RawGet("SetDirection") as LuaFunction);
					this.m_SetFormationLineInt32_hotfix = (luaObj.RawGet("SetFormationLine") as LuaFunction);
					this.m_FaceToVector2i_hotfix = (luaObj.RawGet("FaceTo") as LuaFunction);
					this.m_MoveVector2iFix64Boolean_hotfix = (luaObj.RawGet("Move") as LuaFunction);
					this.m_MoveXInt32Fix64Boolean_hotfix = (luaObj.RawGet("MoveX") as LuaFunction);
					this.m_CreateGraphicStringSingleSingleSingleStringList`1_hotfix = (luaObj.RawGet("CreateGraphic") as LuaFunction);
					this.m_SetGraphicSkillFadeBoolean_hotfix = (luaObj.RawGet("SetGraphicSkillFade") as LuaFunction);
					this.m_PlayAnimationStringBoolean_hotfix = (luaObj.RawGet("PlayAnimation") as LuaFunction);
					this.m_PlayDeathAnimationInt32_hotfix = (luaObj.RawGet("PlayDeathAnimation") as LuaFunction);
					this.m_PlayFxStringInt32_hotfix = (luaObj.RawGet("PlayFx") as LuaFunction);
					this.m_PlaySkillFxStringString_hotfix = (luaObj.RawGet("PlaySkillFx") as LuaFunction);
					this.m_PlaySoundString_hotfix = (luaObj.RawGet("PlaySound") as LuaFunction);
					this.m_SetGraphicEffectGraphicEffectSingleSingle_hotfix = (luaObj.RawGet("SetGraphicEffect") as LuaFunction);
					this.m_ClearGraphicEffectGraphicEffect_hotfix = (luaObj.RawGet("ClearGraphicEffect") as LuaFunction);
					this.m_ClearAttachFxsInt32_hotfix = (luaObj.RawGet("ClearAttachFxs") as LuaFunction);
					this.m_IsDead_hotfix = (luaObj.RawGet("IsDead") as LuaFunction);
					this.m_SetVisibleBoolean_hotfix = (luaObj.RawGet("SetVisible") as LuaFunction);
					this.m_IsVisible_hotfix = (luaObj.RawGet("IsVisible") as LuaFunction);
					this.m_IsHero_hotfix = (luaObj.RawGet("IsHero") as LuaFunction);
					this.m_GetBattleProperty_hotfix = (luaObj.RawGet("GetBattleProperty") as LuaFunction);
					this.m_GetArmyInfo_hotfix = (luaObj.RawGet("GetArmyInfo") as LuaFunction);
					this.m_GetMoveSpeed_hotfix = (luaObj.RawGet("GetMoveSpeed") as LuaFunction);
					this.m_GetAttackDistance_hotfix = (luaObj.RawGet("GetAttackDistance") as LuaFunction);
					this.m_GetMoveType_hotfix = (luaObj.RawGet("GetMoveType") as LuaFunction);
					this.m_GetGraphic_hotfix = (luaObj.RawGet("GetGraphic") as LuaFunction);
					this.m_get_Position_hotfix = (luaObj.RawGet("get_Position") as LuaFunction);
					this.m_get_Direction_hotfix = (luaObj.RawGet("get_Direction") as LuaFunction);
					this.m_get_FormationLine_hotfix = (luaObj.RawGet("get_FormationLine") as LuaFunction);
					this.m_get_Radius_hotfix = (luaObj.RawGet("get_Radius") as LuaFunction);
					this.m_get_Height_hotfix = (luaObj.RawGet("get_Height") as LuaFunction);
					this.m_get_FootHeight_hotfix = (luaObj.RawGet("get_FootHeight") as LuaFunction);
					this.m_get_HealthPoint_hotfix = (luaObj.RawGet("get_HealthPoint") as LuaFunction);
					this.m_get_HealthPointMax_hotfix = (luaObj.RawGet("get_HealthPointMax") as LuaFunction);
					this.m_get_State_hotfix = (luaObj.RawGet("get_State") as LuaFunction);
					this.m_get_StateFrame_hotfix = (luaObj.RawGet("get_StateFrame") as LuaFunction);
					this.m_get_Team_hotfix = (luaObj.RawGet("get_Team") as LuaFunction);
					this.m_get_TeamNumber_hotfix = (luaObj.RawGet("get_TeamNumber") as LuaFunction);
					this.m_get_Combat_hotfix = (luaObj.RawGet("get_Combat") as LuaFunction);
					this.m_TickSkillStates_hotfix = (luaObj.RawGet("TickSkillStates") as LuaFunction);
					this.m_TickSkillHitsCombatSkillState_hotfix = (luaObj.RawGet("TickSkillHits") as LuaFunction);
					this.m_AttackCombatActorConfigDataSkillInfoBoolean_hotfix = (luaObj.RawGet("Attack") as LuaFunction);
					this.m_ShootCombatSkillStateCombatActor_hotfix = (luaObj.RawGet("Shoot") as LuaFunction);
					this.m_AttackByCombatActorConfigDataSkillInfoBoolean_hotfix = (luaObj.RawGet("AttackBy") as LuaFunction);
					this.m_SetHealthPointInt32_hotfix = (luaObj.RawGet("SetHealthPoint") as LuaFunction);
					this.m_PreAttackCombatActorConfigDataSkillInfoBoolean_hotfix = (luaObj.RawGet("PreAttack") as LuaFunction);
					this.m_GetPreAttackHealthPoint_hotfix = (luaObj.RawGet("GetPreAttackHealthPoint") as LuaFunction);
					this.m_AddBeHitIdUInt16_hotfix = (luaObj.RawGet("AddBeHitId") as LuaFunction);
					this.m_HasBeHitIdUInt16_hotfix = (luaObj.RawGet("HasBeHitId") as LuaFunction);
					this.m_CreateSkillStateConfigDataSkillInfo_hotfix = (luaObj.RawGet("CreateSkillState") as LuaFunction);
					this.m_AddSkillDelayHitCombatSkillStateCombatActorInt32_hotfix = (luaObj.RawGet("AddSkillDelayHit") as LuaFunction);
					this.m_AddMagicDamageSkillDelayHitsCombatSkillState_hotfix = (luaObj.RawGet("AddMagicDamageSkillDelayHits") as LuaFunction);
					this.m_AddChargeSkillDelayHitsCombatSkillState_hotfix = (luaObj.RawGet("AddChargeSkillDelayHits") as LuaFunction);
					this.m_CanBeTarget_hotfix = (luaObj.RawGet("CanBeTarget") as LuaFunction);
					this.m_ChangeFightTargetCombatActor_hotfix = (luaObj.RawGet("ChangeFightTarget") as LuaFunction);
					this.m_SearchTarget_hotfix = (luaObj.RawGet("SearchTarget") as LuaFunction);
					this.m_SearchRangeTargetVector2iInt32_hotfix = (luaObj.RawGet("SearchRangeTarget") as LuaFunction);
					this.m_SearchHitTargetInt32UInt16_hotfix = (luaObj.RawGet("SearchHitTarget") as LuaFunction);
					this.m_SearchRandomHitTargetUInt16Int32_hotfix = (luaObj.RawGet("SearchRandomHitTarget") as LuaFunction);
					this.m_IsTargetInAttackDistanceCombatActorInt32_hotfix = (luaObj.RawGet("IsTargetInAttackDistance") as LuaFunction);
					this.m_TickState_hotfix = (luaObj.RawGet("TickState") as LuaFunction);
					this.m_ChangeStateCombatActorState_hotfix = (luaObj.RawGet("ChangeState") as LuaFunction);
					this.m_StateEnter_hotfix = (luaObj.RawGet("StateEnter") as LuaFunction);
					this.m_StateExit_hotfix = (luaObj.RawGet("StateExit") as LuaFunction);
					this.m_StateIdle_hotfix = (luaObj.RawGet("StateIdle") as LuaFunction);
					this.m_StateFight_hotfix = (luaObj.RawGet("StateFight") as LuaFunction);
					this.m_StateFightEnd_hotfix = (luaObj.RawGet("StateFightEnd") as LuaFunction);
					this.m_StateFightAgain_hotfix = (luaObj.RawGet("StateFightAgain") as LuaFunction);
					this.m_StateSkill_hotfix = (luaObj.RawGet("StateSkill") as LuaFunction);
					this.m_StateDie_hotfix = (luaObj.RawGet("StateDie") as LuaFunction);
					this.m_StateReturn_hotfix = (luaObj.RawGet("StateReturn") as LuaFunction);
					this.m_StateStop_hotfix = (luaObj.RawGet("StateStop") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600381F RID: 14367 RVA: 0x00100648 File Offset: 0x000FE848
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CombatActor));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002B03 RID: 11011
		private Vector2i m_position;

		// Token: 0x04002B04 RID: 11012
		private Vector2i m_initPosition;

		// Token: 0x04002B05 RID: 11013
		private int m_direction;

		// Token: 0x04002B06 RID: 11014
		private int m_initDirection;

		// Token: 0x04002B07 RID: 11015
		private int m_formationLine;

		// Token: 0x04002B08 RID: 11016
		private CombatTeam m_team;

		// Token: 0x04002B09 RID: 11017
		private bool m_isHero;

		// Token: 0x04002B0A RID: 11018
		private CombatActorState m_state;

		// Token: 0x04002B0B RID: 11019
		private int m_stateFrame;

		// Token: 0x04002B0C RID: 11020
		private bool m_isStateChanged;

		// Token: 0x04002B0D RID: 11021
		private int m_stateWaitFrame;

		// Token: 0x04002B0E RID: 11022
		private int m_stateMoveDistance;

		// Token: 0x04002B0F RID: 11023
		private int m_frameCount;

		// Token: 0x04002B10 RID: 11024
		private int m_canStopFrame;

		// Token: 0x04002B11 RID: 11025
		private bool m_isVisible;

		// Token: 0x04002B12 RID: 11026
		private CombatActor m_targetActor;

		// Token: 0x04002B13 RID: 11027
		private int m_preAttackHp;

		// Token: 0x04002B14 RID: 11028
		private ushort[] m_beHitIds = new ushort[6];

		// Token: 0x04002B15 RID: 11029
		private ConfigDataSkillInfo m_skillInfo;

		// Token: 0x04002B16 RID: 11030
		private CombatSkillState m_curSkillState;

		// Token: 0x04002B17 RID: 11031
		private List<CombatSkillState> m_skillStates;

		// Token: 0x04002B18 RID: 11032
		private int m_skillUseCount;

		// Token: 0x04002B19 RID: 11033
		private bool m_isDoubleAttacked;

		// Token: 0x04002B1A RID: 11034
		private int m_healthPoint;

		// Token: 0x04002B1B RID: 11035
		private int m_healthPointMax;

		// Token: 0x04002B1C RID: 11036
		private int m_radius;

		// Token: 0x04002B1D RID: 11037
		private int m_height;

		// Token: 0x04002B1E RID: 11038
		private int m_footHeight;

		// Token: 0x04002B1F RID: 11039
		private IBattleGraphic m_graphic;

		// Token: 0x04002B20 RID: 11040
		private Vector2i m_graphicPrevPosition;

		// Token: 0x04002B21 RID: 11041
		private Fix64 m_graphicMoveDistance;

		// Token: 0x04002B22 RID: 11042
		private bool m_isGraphicSkillFade;

		// Token: 0x04002B23 RID: 11043
		private int m_deathAnimType;

		// Token: 0x04002B24 RID: 11044
		[DoNotToLua]
		private CombatActor.LuaExportHelper luaExportHelper;

		// Token: 0x04002B25 RID: 11045
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002B26 RID: 11046
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002B27 RID: 11047
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04002B28 RID: 11048
		private LuaFunction m_Dispose_hotfix;

		// Token: 0x04002B29 RID: 11049
		private LuaFunction m_InitializeCombatTeamBoolean_hotfix;

		// Token: 0x04002B2A RID: 11050
		private LuaFunction m_Tick_hotfix;

		// Token: 0x04002B2B RID: 11051
		private LuaFunction m_TickGraphicSingle_hotfix;

		// Token: 0x04002B2C RID: 11052
		private LuaFunction m_Draw_hotfix;

		// Token: 0x04002B2D RID: 11053
		private LuaFunction m_DoPauseBoolean_hotfix;

		// Token: 0x04002B2E RID: 11054
		private LuaFunction m_EnterCombat_hotfix;

		// Token: 0x04002B2F RID: 11055
		private LuaFunction m_StartCombat_hotfix;

		// Token: 0x04002B30 RID: 11056
		private LuaFunction m_StopCombat_hotfix;

		// Token: 0x04002B31 RID: 11057
		private LuaFunction m_CanStopCombat_hotfix;

		// Token: 0x04002B32 RID: 11058
		private LuaFunction m_LogCanNotStopCombat_hotfix;

		// Token: 0x04002B33 RID: 11059
		private LuaFunction m_SetCanStopFrameInt32_hotfix;

		// Token: 0x04002B34 RID: 11060
		private LuaFunction m_SetPositionInt32Int32_hotfix;

		// Token: 0x04002B35 RID: 11061
		private LuaFunction m_SetPositionVector2i_hotfix;

		// Token: 0x04002B36 RID: 11062
		private LuaFunction m_SetDirectionInt32_hotfix;

		// Token: 0x04002B37 RID: 11063
		private LuaFunction m_SetFormationLineInt32_hotfix;

		// Token: 0x04002B38 RID: 11064
		private LuaFunction m_FaceToVector2i_hotfix;

		// Token: 0x04002B39 RID: 11065
		private LuaFunction m_MoveVector2iFix64Boolean_hotfix;

		// Token: 0x04002B3A RID: 11066
		private LuaFunction m_MoveXInt32Fix64Boolean_hotfix;

		// Token: 0x04002B3B RID: 11067
		private LuaFunction m_CreateGraphicStringSingleSingleSingleStringList;

		// Token: 0x04002B3C RID: 11068
		private LuaFunction m_SetGraphicSkillFadeBoolean_hotfix;

		// Token: 0x04002B3D RID: 11069
		private LuaFunction m_PlayAnimationStringBoolean_hotfix;

		// Token: 0x04002B3E RID: 11070
		private LuaFunction m_PlayDeathAnimationInt32_hotfix;

		// Token: 0x04002B3F RID: 11071
		private LuaFunction m_PlayFxStringInt32_hotfix;

		// Token: 0x04002B40 RID: 11072
		private LuaFunction m_PlaySkillFxStringString_hotfix;

		// Token: 0x04002B41 RID: 11073
		private LuaFunction m_PlaySoundString_hotfix;

		// Token: 0x04002B42 RID: 11074
		private LuaFunction m_SetGraphicEffectGraphicEffectSingleSingle_hotfix;

		// Token: 0x04002B43 RID: 11075
		private LuaFunction m_ClearGraphicEffectGraphicEffect_hotfix;

		// Token: 0x04002B44 RID: 11076
		private LuaFunction m_ClearAttachFxsInt32_hotfix;

		// Token: 0x04002B45 RID: 11077
		private LuaFunction m_IsDead_hotfix;

		// Token: 0x04002B46 RID: 11078
		private LuaFunction m_SetVisibleBoolean_hotfix;

		// Token: 0x04002B47 RID: 11079
		private LuaFunction m_IsVisible_hotfix;

		// Token: 0x04002B48 RID: 11080
		private LuaFunction m_IsHero_hotfix;

		// Token: 0x04002B49 RID: 11081
		private LuaFunction m_GetBattleProperty_hotfix;

		// Token: 0x04002B4A RID: 11082
		private LuaFunction m_GetArmyInfo_hotfix;

		// Token: 0x04002B4B RID: 11083
		private LuaFunction m_GetMoveSpeed_hotfix;

		// Token: 0x04002B4C RID: 11084
		private LuaFunction m_GetAttackDistance_hotfix;

		// Token: 0x04002B4D RID: 11085
		private LuaFunction m_GetMoveType_hotfix;

		// Token: 0x04002B4E RID: 11086
		private LuaFunction m_GetGraphic_hotfix;

		// Token: 0x04002B4F RID: 11087
		private LuaFunction m_get_Position_hotfix;

		// Token: 0x04002B50 RID: 11088
		private LuaFunction m_get_Direction_hotfix;

		// Token: 0x04002B51 RID: 11089
		private LuaFunction m_get_FormationLine_hotfix;

		// Token: 0x04002B52 RID: 11090
		private LuaFunction m_get_Radius_hotfix;

		// Token: 0x04002B53 RID: 11091
		private LuaFunction m_get_Height_hotfix;

		// Token: 0x04002B54 RID: 11092
		private LuaFunction m_get_FootHeight_hotfix;

		// Token: 0x04002B55 RID: 11093
		private LuaFunction m_get_HealthPoint_hotfix;

		// Token: 0x04002B56 RID: 11094
		private LuaFunction m_get_HealthPointMax_hotfix;

		// Token: 0x04002B57 RID: 11095
		private LuaFunction m_get_State_hotfix;

		// Token: 0x04002B58 RID: 11096
		private LuaFunction m_get_StateFrame_hotfix;

		// Token: 0x04002B59 RID: 11097
		private LuaFunction m_get_Team_hotfix;

		// Token: 0x04002B5A RID: 11098
		private LuaFunction m_get_TeamNumber_hotfix;

		// Token: 0x04002B5B RID: 11099
		private LuaFunction m_get_Combat_hotfix;

		// Token: 0x04002B5C RID: 11100
		private LuaFunction m_TickSkillStates_hotfix;

		// Token: 0x04002B5D RID: 11101
		private LuaFunction m_TickSkillHitsCombatSkillState_hotfix;

		// Token: 0x04002B5E RID: 11102
		private LuaFunction m_AttackCombatActorConfigDataSkillInfoBoolean_hotfix;

		// Token: 0x04002B5F RID: 11103
		private LuaFunction m_ShootCombatSkillStateCombatActor_hotfix;

		// Token: 0x04002B60 RID: 11104
		private LuaFunction m_AttackByCombatActorConfigDataSkillInfoBoolean_hotfix;

		// Token: 0x04002B61 RID: 11105
		private LuaFunction m_SetHealthPointInt32_hotfix;

		// Token: 0x04002B62 RID: 11106
		private LuaFunction m_PreAttackCombatActorConfigDataSkillInfoBoolean_hotfix;

		// Token: 0x04002B63 RID: 11107
		private LuaFunction m_GetPreAttackHealthPoint_hotfix;

		// Token: 0x04002B64 RID: 11108
		private LuaFunction m_AddBeHitIdUInt16_hotfix;

		// Token: 0x04002B65 RID: 11109
		private LuaFunction m_HasBeHitIdUInt16_hotfix;

		// Token: 0x04002B66 RID: 11110
		private LuaFunction m_CreateSkillStateConfigDataSkillInfo_hotfix;

		// Token: 0x04002B67 RID: 11111
		private LuaFunction m_AddSkillDelayHitCombatSkillStateCombatActorInt32_hotfix;

		// Token: 0x04002B68 RID: 11112
		private LuaFunction m_AddMagicDamageSkillDelayHitsCombatSkillState_hotfix;

		// Token: 0x04002B69 RID: 11113
		private LuaFunction m_AddChargeSkillDelayHitsCombatSkillState_hotfix;

		// Token: 0x04002B6A RID: 11114
		private LuaFunction m_CanBeTarget_hotfix;

		// Token: 0x04002B6B RID: 11115
		private LuaFunction m_ChangeFightTargetCombatActor_hotfix;

		// Token: 0x04002B6C RID: 11116
		private LuaFunction m_SearchTarget_hotfix;

		// Token: 0x04002B6D RID: 11117
		private LuaFunction m_SearchRangeTargetVector2iInt32_hotfix;

		// Token: 0x04002B6E RID: 11118
		private LuaFunction m_SearchHitTargetInt32UInt16_hotfix;

		// Token: 0x04002B6F RID: 11119
		private LuaFunction m_SearchRandomHitTargetUInt16Int32_hotfix;

		// Token: 0x04002B70 RID: 11120
		private LuaFunction m_IsTargetInAttackDistanceCombatActorInt32_hotfix;

		// Token: 0x04002B71 RID: 11121
		private LuaFunction m_TickState_hotfix;

		// Token: 0x04002B72 RID: 11122
		private LuaFunction m_ChangeStateCombatActorState_hotfix;

		// Token: 0x04002B73 RID: 11123
		private LuaFunction m_StateEnter_hotfix;

		// Token: 0x04002B74 RID: 11124
		private LuaFunction m_StateExit_hotfix;

		// Token: 0x04002B75 RID: 11125
		private LuaFunction m_StateIdle_hotfix;

		// Token: 0x04002B76 RID: 11126
		private LuaFunction m_StateFight_hotfix;

		// Token: 0x04002B77 RID: 11127
		private LuaFunction m_StateFightEnd_hotfix;

		// Token: 0x04002B78 RID: 11128
		private LuaFunction m_StateFightAgain_hotfix;

		// Token: 0x04002B79 RID: 11129
		private LuaFunction m_StateSkill_hotfix;

		// Token: 0x04002B7A RID: 11130
		private LuaFunction m_StateDie_hotfix;

		// Token: 0x04002B7B RID: 11131
		private LuaFunction m_StateReturn_hotfix;

		// Token: 0x04002B7C RID: 11132
		private LuaFunction m_StateStop_hotfix;

		// Token: 0x020003B7 RID: 951
		public new class LuaExportHelper
		{
			// Token: 0x06003820 RID: 14368 RVA: 0x001006B0 File Offset: 0x000FE8B0
			public LuaExportHelper(CombatActor owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06003821 RID: 14369 RVA: 0x001006C0 File Offset: 0x000FE8C0
			public void __callBase_Dispose()
			{
				this.m_owner.__callBase_Dispose();
			}

			// Token: 0x06003822 RID: 14370 RVA: 0x001006D0 File Offset: 0x000FE8D0
			public void __callBase_Tick()
			{
				this.m_owner.__callBase_Tick();
			}

			// Token: 0x06003823 RID: 14371 RVA: 0x001006E0 File Offset: 0x000FE8E0
			public void __callBase_TickGraphic(float dt)
			{
				this.m_owner.__callBase_TickGraphic(dt);
			}

			// Token: 0x06003824 RID: 14372 RVA: 0x001006F0 File Offset: 0x000FE8F0
			public void __callBase_Draw()
			{
				this.m_owner.__callBase_Draw();
			}

			// Token: 0x06003825 RID: 14373 RVA: 0x00100700 File Offset: 0x000FE900
			public void __callBase_Pause(bool pause)
			{
				this.m_owner.__callBase_Pause(pause);
			}

			// Token: 0x06003826 RID: 14374 RVA: 0x00100710 File Offset: 0x000FE910
			public void __callBase_DoPause(bool pause)
			{
				this.m_owner.__callBase_DoPause(pause);
			}

			// Token: 0x06003827 RID: 14375 RVA: 0x00100720 File Offset: 0x000FE920
			public void __callBase_DeleteMe()
			{
				this.m_owner.__callBase_DeleteMe();
			}

			// Token: 0x17000F68 RID: 3944
			// (get) Token: 0x06003828 RID: 14376 RVA: 0x00100730 File Offset: 0x000FE930
			// (set) Token: 0x06003829 RID: 14377 RVA: 0x00100740 File Offset: 0x000FE940
			public Vector2i m_position
			{
				get
				{
					return this.m_owner.m_position;
				}
				set
				{
					this.m_owner.m_position = value;
				}
			}

			// Token: 0x17000F69 RID: 3945
			// (get) Token: 0x0600382A RID: 14378 RVA: 0x00100750 File Offset: 0x000FE950
			// (set) Token: 0x0600382B RID: 14379 RVA: 0x00100760 File Offset: 0x000FE960
			public Vector2i m_initPosition
			{
				get
				{
					return this.m_owner.m_initPosition;
				}
				set
				{
					this.m_owner.m_initPosition = value;
				}
			}

			// Token: 0x17000F6A RID: 3946
			// (get) Token: 0x0600382C RID: 14380 RVA: 0x00100770 File Offset: 0x000FE970
			// (set) Token: 0x0600382D RID: 14381 RVA: 0x00100780 File Offset: 0x000FE980
			public int m_direction
			{
				get
				{
					return this.m_owner.m_direction;
				}
				set
				{
					this.m_owner.m_direction = value;
				}
			}

			// Token: 0x17000F6B RID: 3947
			// (get) Token: 0x0600382E RID: 14382 RVA: 0x00100790 File Offset: 0x000FE990
			// (set) Token: 0x0600382F RID: 14383 RVA: 0x001007A0 File Offset: 0x000FE9A0
			public int m_initDirection
			{
				get
				{
					return this.m_owner.m_initDirection;
				}
				set
				{
					this.m_owner.m_initDirection = value;
				}
			}

			// Token: 0x17000F6C RID: 3948
			// (get) Token: 0x06003830 RID: 14384 RVA: 0x001007B0 File Offset: 0x000FE9B0
			// (set) Token: 0x06003831 RID: 14385 RVA: 0x001007C0 File Offset: 0x000FE9C0
			public int m_formationLine
			{
				get
				{
					return this.m_owner.m_formationLine;
				}
				set
				{
					this.m_owner.m_formationLine = value;
				}
			}

			// Token: 0x17000F6D RID: 3949
			// (get) Token: 0x06003832 RID: 14386 RVA: 0x001007D0 File Offset: 0x000FE9D0
			// (set) Token: 0x06003833 RID: 14387 RVA: 0x001007E0 File Offset: 0x000FE9E0
			public CombatTeam m_team
			{
				get
				{
					return this.m_owner.m_team;
				}
				set
				{
					this.m_owner.m_team = value;
				}
			}

			// Token: 0x17000F6E RID: 3950
			// (get) Token: 0x06003834 RID: 14388 RVA: 0x001007F0 File Offset: 0x000FE9F0
			// (set) Token: 0x06003835 RID: 14389 RVA: 0x00100800 File Offset: 0x000FEA00
			public bool m_isHero
			{
				get
				{
					return this.m_owner.m_isHero;
				}
				set
				{
					this.m_owner.m_isHero = value;
				}
			}

			// Token: 0x17000F6F RID: 3951
			// (get) Token: 0x06003836 RID: 14390 RVA: 0x00100810 File Offset: 0x000FEA10
			// (set) Token: 0x06003837 RID: 14391 RVA: 0x00100820 File Offset: 0x000FEA20
			public CombatActorState m_state
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

			// Token: 0x17000F70 RID: 3952
			// (get) Token: 0x06003838 RID: 14392 RVA: 0x00100830 File Offset: 0x000FEA30
			// (set) Token: 0x06003839 RID: 14393 RVA: 0x00100840 File Offset: 0x000FEA40
			public int m_stateFrame
			{
				get
				{
					return this.m_owner.m_stateFrame;
				}
				set
				{
					this.m_owner.m_stateFrame = value;
				}
			}

			// Token: 0x17000F71 RID: 3953
			// (get) Token: 0x0600383A RID: 14394 RVA: 0x00100850 File Offset: 0x000FEA50
			// (set) Token: 0x0600383B RID: 14395 RVA: 0x00100860 File Offset: 0x000FEA60
			public bool m_isStateChanged
			{
				get
				{
					return this.m_owner.m_isStateChanged;
				}
				set
				{
					this.m_owner.m_isStateChanged = value;
				}
			}

			// Token: 0x17000F72 RID: 3954
			// (get) Token: 0x0600383C RID: 14396 RVA: 0x00100870 File Offset: 0x000FEA70
			// (set) Token: 0x0600383D RID: 14397 RVA: 0x00100880 File Offset: 0x000FEA80
			public int m_stateWaitFrame
			{
				get
				{
					return this.m_owner.m_stateWaitFrame;
				}
				set
				{
					this.m_owner.m_stateWaitFrame = value;
				}
			}

			// Token: 0x17000F73 RID: 3955
			// (get) Token: 0x0600383E RID: 14398 RVA: 0x00100890 File Offset: 0x000FEA90
			// (set) Token: 0x0600383F RID: 14399 RVA: 0x001008A0 File Offset: 0x000FEAA0
			public int m_stateMoveDistance
			{
				get
				{
					return this.m_owner.m_stateMoveDistance;
				}
				set
				{
					this.m_owner.m_stateMoveDistance = value;
				}
			}

			// Token: 0x17000F74 RID: 3956
			// (get) Token: 0x06003840 RID: 14400 RVA: 0x001008B0 File Offset: 0x000FEAB0
			// (set) Token: 0x06003841 RID: 14401 RVA: 0x001008C0 File Offset: 0x000FEAC0
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

			// Token: 0x17000F75 RID: 3957
			// (get) Token: 0x06003842 RID: 14402 RVA: 0x001008D0 File Offset: 0x000FEAD0
			// (set) Token: 0x06003843 RID: 14403 RVA: 0x001008E0 File Offset: 0x000FEAE0
			public int m_canStopFrame
			{
				get
				{
					return this.m_owner.m_canStopFrame;
				}
				set
				{
					this.m_owner.m_canStopFrame = value;
				}
			}

			// Token: 0x17000F76 RID: 3958
			// (get) Token: 0x06003844 RID: 14404 RVA: 0x001008F0 File Offset: 0x000FEAF0
			// (set) Token: 0x06003845 RID: 14405 RVA: 0x00100900 File Offset: 0x000FEB00
			public bool m_isVisible
			{
				get
				{
					return this.m_owner.m_isVisible;
				}
				set
				{
					this.m_owner.m_isVisible = value;
				}
			}

			// Token: 0x17000F77 RID: 3959
			// (get) Token: 0x06003846 RID: 14406 RVA: 0x00100910 File Offset: 0x000FEB10
			// (set) Token: 0x06003847 RID: 14407 RVA: 0x00100920 File Offset: 0x000FEB20
			public CombatActor m_targetActor
			{
				get
				{
					return this.m_owner.m_targetActor;
				}
				set
				{
					this.m_owner.m_targetActor = value;
				}
			}

			// Token: 0x17000F78 RID: 3960
			// (get) Token: 0x06003848 RID: 14408 RVA: 0x00100930 File Offset: 0x000FEB30
			// (set) Token: 0x06003849 RID: 14409 RVA: 0x00100940 File Offset: 0x000FEB40
			public int m_preAttackHp
			{
				get
				{
					return this.m_owner.m_preAttackHp;
				}
				set
				{
					this.m_owner.m_preAttackHp = value;
				}
			}

			// Token: 0x17000F79 RID: 3961
			// (get) Token: 0x0600384A RID: 14410 RVA: 0x00100950 File Offset: 0x000FEB50
			// (set) Token: 0x0600384B RID: 14411 RVA: 0x00100960 File Offset: 0x000FEB60
			public ushort[] m_beHitIds
			{
				get
				{
					return this.m_owner.m_beHitIds;
				}
				set
				{
					this.m_owner.m_beHitIds = value;
				}
			}

			// Token: 0x17000F7A RID: 3962
			// (get) Token: 0x0600384C RID: 14412 RVA: 0x00100970 File Offset: 0x000FEB70
			// (set) Token: 0x0600384D RID: 14413 RVA: 0x00100980 File Offset: 0x000FEB80
			public ConfigDataSkillInfo m_skillInfo
			{
				get
				{
					return this.m_owner.m_skillInfo;
				}
				set
				{
					this.m_owner.m_skillInfo = value;
				}
			}

			// Token: 0x17000F7B RID: 3963
			// (get) Token: 0x0600384E RID: 14414 RVA: 0x00100990 File Offset: 0x000FEB90
			// (set) Token: 0x0600384F RID: 14415 RVA: 0x001009A0 File Offset: 0x000FEBA0
			public CombatSkillState m_curSkillState
			{
				get
				{
					return this.m_owner.m_curSkillState;
				}
				set
				{
					this.m_owner.m_curSkillState = value;
				}
			}

			// Token: 0x17000F7C RID: 3964
			// (get) Token: 0x06003850 RID: 14416 RVA: 0x001009B0 File Offset: 0x000FEBB0
			// (set) Token: 0x06003851 RID: 14417 RVA: 0x001009C0 File Offset: 0x000FEBC0
			public List<CombatSkillState> m_skillStates
			{
				get
				{
					return this.m_owner.m_skillStates;
				}
				set
				{
					this.m_owner.m_skillStates = value;
				}
			}

			// Token: 0x17000F7D RID: 3965
			// (get) Token: 0x06003852 RID: 14418 RVA: 0x001009D0 File Offset: 0x000FEBD0
			// (set) Token: 0x06003853 RID: 14419 RVA: 0x001009E0 File Offset: 0x000FEBE0
			public int m_skillUseCount
			{
				get
				{
					return this.m_owner.m_skillUseCount;
				}
				set
				{
					this.m_owner.m_skillUseCount = value;
				}
			}

			// Token: 0x17000F7E RID: 3966
			// (get) Token: 0x06003854 RID: 14420 RVA: 0x001009F0 File Offset: 0x000FEBF0
			// (set) Token: 0x06003855 RID: 14421 RVA: 0x00100A00 File Offset: 0x000FEC00
			public bool m_isDoubleAttacked
			{
				get
				{
					return this.m_owner.m_isDoubleAttacked;
				}
				set
				{
					this.m_owner.m_isDoubleAttacked = value;
				}
			}

			// Token: 0x17000F7F RID: 3967
			// (get) Token: 0x06003856 RID: 14422 RVA: 0x00100A10 File Offset: 0x000FEC10
			// (set) Token: 0x06003857 RID: 14423 RVA: 0x00100A20 File Offset: 0x000FEC20
			public int m_healthPoint
			{
				get
				{
					return this.m_owner.m_healthPoint;
				}
				set
				{
					this.m_owner.m_healthPoint = value;
				}
			}

			// Token: 0x17000F80 RID: 3968
			// (get) Token: 0x06003858 RID: 14424 RVA: 0x00100A30 File Offset: 0x000FEC30
			// (set) Token: 0x06003859 RID: 14425 RVA: 0x00100A40 File Offset: 0x000FEC40
			public int m_healthPointMax
			{
				get
				{
					return this.m_owner.m_healthPointMax;
				}
				set
				{
					this.m_owner.m_healthPointMax = value;
				}
			}

			// Token: 0x17000F81 RID: 3969
			// (get) Token: 0x0600385A RID: 14426 RVA: 0x00100A50 File Offset: 0x000FEC50
			// (set) Token: 0x0600385B RID: 14427 RVA: 0x00100A60 File Offset: 0x000FEC60
			public int m_radius
			{
				get
				{
					return this.m_owner.m_radius;
				}
				set
				{
					this.m_owner.m_radius = value;
				}
			}

			// Token: 0x17000F82 RID: 3970
			// (get) Token: 0x0600385C RID: 14428 RVA: 0x00100A70 File Offset: 0x000FEC70
			// (set) Token: 0x0600385D RID: 14429 RVA: 0x00100A80 File Offset: 0x000FEC80
			public int m_height
			{
				get
				{
					return this.m_owner.m_height;
				}
				set
				{
					this.m_owner.m_height = value;
				}
			}

			// Token: 0x17000F83 RID: 3971
			// (get) Token: 0x0600385E RID: 14430 RVA: 0x00100A90 File Offset: 0x000FEC90
			// (set) Token: 0x0600385F RID: 14431 RVA: 0x00100AA0 File Offset: 0x000FECA0
			public int m_footHeight
			{
				get
				{
					return this.m_owner.m_footHeight;
				}
				set
				{
					this.m_owner.m_footHeight = value;
				}
			}

			// Token: 0x17000F84 RID: 3972
			// (get) Token: 0x06003860 RID: 14432 RVA: 0x00100AB0 File Offset: 0x000FECB0
			// (set) Token: 0x06003861 RID: 14433 RVA: 0x00100AC0 File Offset: 0x000FECC0
			public IBattleGraphic m_graphic
			{
				get
				{
					return this.m_owner.m_graphic;
				}
				set
				{
					this.m_owner.m_graphic = value;
				}
			}

			// Token: 0x17000F85 RID: 3973
			// (get) Token: 0x06003862 RID: 14434 RVA: 0x00100AD0 File Offset: 0x000FECD0
			// (set) Token: 0x06003863 RID: 14435 RVA: 0x00100AE0 File Offset: 0x000FECE0
			public Vector2i m_graphicPrevPosition
			{
				get
				{
					return this.m_owner.m_graphicPrevPosition;
				}
				set
				{
					this.m_owner.m_graphicPrevPosition = value;
				}
			}

			// Token: 0x17000F86 RID: 3974
			// (get) Token: 0x06003864 RID: 14436 RVA: 0x00100AF0 File Offset: 0x000FECF0
			// (set) Token: 0x06003865 RID: 14437 RVA: 0x00100B00 File Offset: 0x000FED00
			public Fix64 m_graphicMoveDistance
			{
				get
				{
					return this.m_owner.m_graphicMoveDistance;
				}
				set
				{
					this.m_owner.m_graphicMoveDistance = value;
				}
			}

			// Token: 0x17000F87 RID: 3975
			// (get) Token: 0x06003866 RID: 14438 RVA: 0x00100B10 File Offset: 0x000FED10
			// (set) Token: 0x06003867 RID: 14439 RVA: 0x00100B20 File Offset: 0x000FED20
			public bool m_isGraphicSkillFade
			{
				get
				{
					return this.m_owner.m_isGraphicSkillFade;
				}
				set
				{
					this.m_owner.m_isGraphicSkillFade = value;
				}
			}

			// Token: 0x17000F88 RID: 3976
			// (get) Token: 0x06003868 RID: 14440 RVA: 0x00100B30 File Offset: 0x000FED30
			// (set) Token: 0x06003869 RID: 14441 RVA: 0x00100B40 File Offset: 0x000FED40
			public int m_deathAnimType
			{
				get
				{
					return this.m_owner.m_deathAnimType;
				}
				set
				{
					this.m_owner.m_deathAnimType = value;
				}
			}

			// Token: 0x0600386A RID: 14442 RVA: 0x00100B50 File Offset: 0x000FED50
			public void Move(Vector2i dir, Fix64 distance, bool changeDirection)
			{
				this.m_owner.Move(dir, distance, changeDirection);
			}

			// Token: 0x0600386B RID: 14443 RVA: 0x00100B60 File Offset: 0x000FED60
			public void MoveX(int dir, Fix64 distance, bool changeDirection)
			{
				this.m_owner.MoveX(dir, distance, changeDirection);
			}

			// Token: 0x0600386C RID: 14444 RVA: 0x00100B70 File Offset: 0x000FED70
			public void CreateGraphic(string assetName, float scale, float height, float footHeight, string name, List<ReplaceAnim> replaceAnims)
			{
				this.m_owner.CreateGraphic(assetName, scale, height, footHeight, name, replaceAnims);
			}

			// Token: 0x0600386D RID: 14445 RVA: 0x00100B88 File Offset: 0x000FED88
			public void PlayAnimation(string name, bool loop)
			{
				this.m_owner.PlayAnimation(name, loop);
			}

			// Token: 0x0600386E RID: 14446 RVA: 0x00100B98 File Offset: 0x000FED98
			public void PlayDeathAnimation(int deathType)
			{
				this.m_owner.PlayDeathAnimation(deathType);
			}

			// Token: 0x0600386F RID: 14447 RVA: 0x00100BA8 File Offset: 0x000FEDA8
			public void PlayFx(string name, int tag)
			{
				this.m_owner.PlayFx(name, tag);
			}

			// Token: 0x06003870 RID: 14448 RVA: 0x00100BB8 File Offset: 0x000FEDB8
			public void PlaySkillFx(string name, string nameFar)
			{
				this.m_owner.PlaySkillFx(name, nameFar);
			}

			// Token: 0x06003871 RID: 14449 RVA: 0x00100BC8 File Offset: 0x000FEDC8
			public void PlaySound(string name)
			{
				this.m_owner.PlaySound(name);
			}

			// Token: 0x06003872 RID: 14450 RVA: 0x00100BD8 File Offset: 0x000FEDD8
			public void SetGraphicEffect(GraphicEffect e, float param1, float param2)
			{
				this.m_owner.SetGraphicEffect(e, param1, param2);
			}

			// Token: 0x06003873 RID: 14451 RVA: 0x00100BE8 File Offset: 0x000FEDE8
			public void ClearGraphicEffect(GraphicEffect e)
			{
				this.m_owner.ClearGraphicEffect(e);
			}

			// Token: 0x06003874 RID: 14452 RVA: 0x00100BF8 File Offset: 0x000FEDF8
			public void ClearAttachFxs(int tagMask)
			{
				this.m_owner.ClearAttachFxs(tagMask);
			}

			// Token: 0x06003875 RID: 14453 RVA: 0x00100C08 File Offset: 0x000FEE08
			public BattleProperty GetBattleProperty()
			{
				return this.m_owner.GetBattleProperty();
			}

			// Token: 0x06003876 RID: 14454 RVA: 0x00100C18 File Offset: 0x000FEE18
			public int GetMoveSpeed()
			{
				return this.m_owner.GetMoveSpeed();
			}

			// Token: 0x06003877 RID: 14455 RVA: 0x00100C28 File Offset: 0x000FEE28
			public int GetAttackDistance()
			{
				return this.m_owner.GetAttackDistance();
			}

			// Token: 0x06003878 RID: 14456 RVA: 0x00100C38 File Offset: 0x000FEE38
			public MoveType GetMoveType()
			{
				return this.m_owner.GetMoveType();
			}

			// Token: 0x06003879 RID: 14457 RVA: 0x00100C48 File Offset: 0x000FEE48
			public void TickSkillStates()
			{
				this.m_owner.TickSkillStates();
			}

			// Token: 0x0600387A RID: 14458 RVA: 0x00100C58 File Offset: 0x000FEE58
			public void TickSkillHits(CombatSkillState ss)
			{
				this.m_owner.TickSkillHits(ss);
			}

			// Token: 0x0600387B RID: 14459 RVA: 0x00100C68 File Offset: 0x000FEE68
			public bool Attack(CombatActor target, ConfigDataSkillInfo skillInfo, bool isCritical)
			{
				return this.m_owner.Attack(target, skillInfo, isCritical);
			}

			// Token: 0x0600387C RID: 14460 RVA: 0x00100C78 File Offset: 0x000FEE78
			public bool Shoot(CombatSkillState ss, CombatActor target)
			{
				return this.m_owner.Shoot(ss, target);
			}

			// Token: 0x0600387D RID: 14461 RVA: 0x00100C88 File Offset: 0x000FEE88
			public CombatSkillState CreateSkillState(ConfigDataSkillInfo skillInfo)
			{
				return this.m_owner.CreateSkillState(skillInfo);
			}

			// Token: 0x0600387E RID: 14462 RVA: 0x00100C98 File Offset: 0x000FEE98
			public void AddSkillDelayHit(CombatSkillState ss, CombatActor target, int delay)
			{
				this.m_owner.AddSkillDelayHit(ss, target, delay);
			}

			// Token: 0x0600387F RID: 14463 RVA: 0x00100CA8 File Offset: 0x000FEEA8
			public void AddMagicDamageSkillDelayHits(CombatSkillState ss)
			{
				this.m_owner.AddMagicDamageSkillDelayHits(ss);
			}

			// Token: 0x06003880 RID: 14464 RVA: 0x00100CB8 File Offset: 0x000FEEB8
			public void AddChargeSkillDelayHits(CombatSkillState ss)
			{
				this.m_owner.AddChargeSkillDelayHits(ss);
			}

			// Token: 0x06003881 RID: 14465 RVA: 0x00100CC8 File Offset: 0x000FEEC8
			public void ChangeFightTarget(CombatActor target)
			{
				this.m_owner.ChangeFightTarget(target);
			}

			// Token: 0x06003882 RID: 14466 RVA: 0x00100CD8 File Offset: 0x000FEED8
			public CombatActor SearchTarget()
			{
				return this.m_owner.SearchTarget();
			}

			// Token: 0x06003883 RID: 14467 RVA: 0x00100CE8 File Offset: 0x000FEEE8
			public CombatActor SearchRangeTarget(Vector2i pos, int maxDistance)
			{
				return this.m_owner.SearchRangeTarget(pos, maxDistance);
			}

			// Token: 0x06003884 RID: 14468 RVA: 0x00100CF8 File Offset: 0x000FEEF8
			public CombatActor SearchHitTarget(int attackDistance, ushort hitId)
			{
				return this.m_owner.SearchHitTarget(attackDistance, hitId);
			}

			// Token: 0x06003885 RID: 14469 RVA: 0x00100D08 File Offset: 0x000FEF08
			public CombatActor SearchRandomHitTarget(ushort hitId, int targetType)
			{
				return this.m_owner.SearchRandomHitTarget(hitId, targetType);
			}

			// Token: 0x06003886 RID: 14470 RVA: 0x00100D18 File Offset: 0x000FEF18
			public static int ComputeTargetScore(Vector2i pos, CombatActor target)
			{
				return CombatActor.ComputeTargetScore(pos, target);
			}

			// Token: 0x06003887 RID: 14471 RVA: 0x00100D24 File Offset: 0x000FEF24
			public bool IsTargetInAttackDistance(CombatActor target, int attackDistance)
			{
				return this.m_owner.IsTargetInAttackDistance(target, attackDistance);
			}

			// Token: 0x06003888 RID: 14472 RVA: 0x00100D34 File Offset: 0x000FEF34
			public void TickState()
			{
				this.m_owner.TickState();
			}

			// Token: 0x06003889 RID: 14473 RVA: 0x00100D44 File Offset: 0x000FEF44
			public void ChangeState(CombatActorState state)
			{
				this.m_owner.ChangeState(state);
			}

			// Token: 0x0600388A RID: 14474 RVA: 0x00100D54 File Offset: 0x000FEF54
			public void StateEnter()
			{
				this.m_owner.StateEnter();
			}

			// Token: 0x0600388B RID: 14475 RVA: 0x00100D64 File Offset: 0x000FEF64
			public void StateExit()
			{
				this.m_owner.StateExit();
			}

			// Token: 0x0600388C RID: 14476 RVA: 0x00100D74 File Offset: 0x000FEF74
			public void StateIdle()
			{
				this.m_owner.StateIdle();
			}

			// Token: 0x0600388D RID: 14477 RVA: 0x00100D84 File Offset: 0x000FEF84
			public void StateFight()
			{
				this.m_owner.StateFight();
			}

			// Token: 0x0600388E RID: 14478 RVA: 0x00100D94 File Offset: 0x000FEF94
			public void StateFightEnd()
			{
				this.m_owner.StateFightEnd();
			}

			// Token: 0x0600388F RID: 14479 RVA: 0x00100DA4 File Offset: 0x000FEFA4
			public void StateFightAgain()
			{
				this.m_owner.StateFightAgain();
			}

			// Token: 0x06003890 RID: 14480 RVA: 0x00100DB4 File Offset: 0x000FEFB4
			public void StateSkill()
			{
				this.m_owner.StateSkill();
			}

			// Token: 0x06003891 RID: 14481 RVA: 0x00100DC4 File Offset: 0x000FEFC4
			public void StateDie()
			{
				this.m_owner.StateDie();
			}

			// Token: 0x06003892 RID: 14482 RVA: 0x00100DD4 File Offset: 0x000FEFD4
			public void StateReturn()
			{
				this.m_owner.StateReturn();
			}

			// Token: 0x06003893 RID: 14483 RVA: 0x00100DE4 File Offset: 0x000FEFE4
			public void StateStop()
			{
				this.m_owner.StateStop();
			}

			// Token: 0x04002B7D RID: 11133
			private CombatActor m_owner;
		}
	}
}
