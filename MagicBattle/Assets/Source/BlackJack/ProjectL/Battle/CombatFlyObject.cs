using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using FixMath.NET;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x020003BC RID: 956
	[HotFix]
	public class CombatFlyObject : Entity
	{
		// Token: 0x0600389D RID: 14493 RVA: 0x00101278 File Offset: 0x000FF478
		public CombatFlyObject()
		{
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

		// Token: 0x0600389E RID: 14494 RVA: 0x001012E0 File Offset: 0x000FF4E0
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
			if (this.m_fx != null)
			{
				this.m_fx.FxStop(true);
				this.m_fx = null;
			}
			this.m_team = null;
			this.m_sourceActor = null;
			this.m_targetActor = null;
			if (this.m_delayHits != null)
			{
				this.m_delayHits.Clear();
			}
		}

		// Token: 0x0600389F RID: 14495 RVA: 0x0010138C File Offset: 0x000FF58C
		public void Initialize(CombatTeam team)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitializeCombatTeam_hotfix != null)
			{
				this.m_InitializeCombatTeam_hotfix.call(new object[]
				{
					this,
					team
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_team = team;
			this.m_id = this.Combat.GetNextEntityId();
		}

		// Token: 0x060038A0 RID: 14496 RVA: 0x00101414 File Offset: 0x000FF614
		public void Setup(ConfigDataFlyObjectInfo flyObjInfo, CombatSkillState ss, CombatActor sourceActor, CombatActor targetActor)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetupConfigDataFlyObjectInfoCombatSkillStateCombatActorCombatActor_hotfix != null)
			{
				this.m_SetupConfigDataFlyObjectInfoCombatSkillStateCombatActorCombatActor_hotfix.call(new object[]
				{
					this,
					flyObjInfo,
					ss,
					sourceActor,
					targetActor
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (flyObjInfo == null || ss == null || sourceActor == null || targetActor == null)
			{
				base.DeleteMe();
				return;
			}
			this.m_configDataFlyObjectInfo = flyObjInfo;
			this.m_sourceSkillState = ss;
			this.m_sourceActor = sourceActor;
			this.m_targetActor = targetActor;
			this.m_targetTeamNumber = targetActor.TeamNumber;
			this.m_startPosition = sourceActor.Position;
			this.m_startZ = sourceActor.Height * 2 / 3 + sourceActor.FootHeight;
			if (flyObjInfo.TrackType == TrackType.TrackType_Parabolic)
			{
				Vector2i vector2i = targetActor.Position - sourceActor.Position;
				int num = Math.Max((int)((long)vector2i.magnitude), 1);
				int num2 = Combat.MillisecondToFrame1(num * 1000 / flyObjInfo.Speed);
				this.m_endZ = targetActor.Height * 2 / 3 + targetActor.FootHeight;
				Fix64 fix = (Fix64)((long)(-(long)this.m_configDataFlyObjectInfo.Gravity));
				Fix64 fix2 = (Fix64)((long)num) / (Fix64)((long)flyObjInfo.Speed);
				Fix64 fix3 = this.m_vz = Fix64.Zero;
				if (fix2 > Fix64.Zero)
				{
					fix3 = (this.m_vz = (Fix64)((long)(this.m_endZ - this.m_startZ)) / fix2 - fix * fix2 * (Fix64)0.5f);
				}
				Fix64 x = MathUtility.Max(fix3 * fix3 - (Fix64)((long)(2 * this.m_startZ)) * fix, Fix64.Zero);
				Fix64 x2;
				if (fix < Fix64.Zero)
				{
					x2 = (-fix3 - Fix64.Sqrt(x)) / fix;
				}
				else
				{
					x2 = fix2;
				}
				this.m_lifeMax = Combat.MillisecondToFrame1((int)((long)(x2 * (Fix64)1000L)));
				int num3 = num * this.m_lifeMax / num2;
				this.m_endPosition = this.m_startPosition + vector2i.normalized * (Fix64)((long)num3);
				this.m_endZ = 0;
			}
			else
			{
				int num4 = flyObjInfo.Distance;
				if (num4 <= 0)
				{
					num4 = 1000;
				}
				if (flyObjInfo.TrackType == TrackType.TrackType_Straight)
				{
					this.m_endPosition.x = this.m_startPosition.x + (Fix64)((long)(Fix64.Sign(targetActor.Position.x - sourceActor.Position.x) * num4));
					this.m_endPosition.y = this.m_startPosition.y;
					this.m_endZ = this.m_startZ;
				}
				else if (flyObjInfo.TrackType == TrackType.TrackType_DownStraight)
				{
					this.m_endPosition.x = this.m_startPosition.x + (Fix64)((long)(Fix64.Sign(targetActor.Position.x - sourceActor.Position.x) * num4));
					this.m_endPosition.y = this.m_startPosition.y;
					this.m_endZ = (this.m_startZ = 80);
				}
				else if (flyObjInfo.TrackType == TrackType.TrackType_UpStraight)
				{
					this.m_endPosition.x = this.m_startPosition.x + (Fix64)((long)(Fix64.Sign(targetActor.Position.x - sourceActor.Position.x) * num4));
					this.m_endPosition.y = this.m_startPosition.y;
					this.m_endZ = (this.m_startZ = 150);
				}
				this.m_lifeMax = Combat.MillisecondToFrame1(num4 * 1000 / flyObjInfo.Speed);
			}
			this.m_frameCount = 0;
			this.m_life = 0;
			this.m_fxLife = Fix64.Zero;
			this.m_isGraphicSkillFade = false;
			this.m_hitId = this.Combat.GetNextHitId();
			this.CreateFx(flyObjInfo.Model, (float)flyObjInfo.ModelScale * 0.01f);
		}

		// Token: 0x060038A1 RID: 14497 RVA: 0x001018E0 File Offset: 0x000FFAE0
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
			return this.m_sourceActor != null && this.m_sourceActor.IsHero();
		}

		// Token: 0x060038A2 RID: 14498 RVA: 0x00101968 File Offset: 0x000FFB68
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

		// Token: 0x060038A3 RID: 14499 RVA: 0x001019E0 File Offset: 0x000FFBE0
		private static int ComputeTargetScore(Fix64 x, CombatActor target)
		{
			int num = 0;
			if (target.GetPreAttackHealthPoint() <= 0)
			{
				num = 1000000;
			}
			num += target.FormationLine * 100000;
			int num2 = (int)((long)(x - target.Position.x));
			return num + num2 * num2 / 100;
		}

		// Token: 0x060038A4 RID: 14500 RVA: 0x00101A38 File Offset: 0x000FFC38
		private CombatActor SearchHitTarget(Fix64 x0, Fix64 x1, ushort hitId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SearchHitTargetFix64Fix64UInt16_hotfix != null)
			{
				return (CombatActor)this.m_SearchHitTargetFix64Fix64UInt16_hotfix.call(new object[]
				{
					this,
					x0,
					x1,
					hitId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CombatTeam team = this.Combat.GetTeam(this.m_targetTeamNumber);
			int num = int.MaxValue;
			CombatActor result = null;
			int num2 = (int)((long)(x0 + x1)) / 2;
			int num3 = Math.Abs((int)((long)(x0 - x1)) / 2) + this.m_configDataFlyObjectInfo.CollisionRadius;
			if (!this.m_team.IsAttackHeroOnly())
			{
				foreach (CombatActor combatActor in team.GetActors())
				{
					if (combatActor.CanBeTarget())
					{
						if (Math.Abs((int)((long)combatActor.Position.x) - num2) <= num3 + combatActor.Radius)
						{
							if (!combatActor.HasBeHitId(hitId))
							{
								int num4 = CombatFlyObject.ComputeTargetScore(x1, combatActor);
								if (num4 < num)
								{
									num = num4;
									result = combatActor;
								}
							}
						}
					}
				}
				return result;
			}
			CombatActor hero = team.GetHero();
			if (hero != null && hero.CanBeTarget() && Math.Abs((int)((long)hero.Position.x) - num2) <= num3 + hero.Radius)
			{
				return hero;
			}
			return null;
		}

		// Token: 0x060038A5 RID: 14501 RVA: 0x00101C34 File Offset: 0x000FFE34
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
			this.m_life++;
			this.m_frameCount++;
			if (this.m_life <= this.m_lifeMax)
			{
				if (this.m_configDataFlyObjectInfo.TrackType == TrackType.TrackType_Parabolic)
				{
					CombatActor targetActor = this.m_targetActor;
					Fix64 value = MathUtility.Lerp(this.m_startPosition.x, this.m_endPosition.x, (Fix64)((long)this.m_life) / (Fix64)((long)this.m_lifeMax));
					int num = this.m_configDataFlyObjectInfo.CollisionRadius + targetActor.Radius;
					if (((this.m_endPosition.x >= this.m_startPosition.x && (int)((long)value) >= (int)((long)targetActor.Position.x) - num) || (this.m_endPosition.x < this.m_startPosition.x && (int)((long)value) <= (int)((long)targetActor.Position.x) + num)) && targetActor.CanBeTarget())
					{
						this.Attack(this.m_targetActor);
						this.m_targetActor.AddBeHitId(this.m_hitId);
						this.m_sourceSkillState.m_hitCount++;
						base.DeleteMe();
					}
				}
				else
				{
					Fix64 x = MathUtility.Lerp(this.m_startPosition.x, this.m_endPosition.x, (Fix64)((long)(this.m_life - 1)) / (Fix64)((long)this.m_lifeMax));
					Fix64 x2 = MathUtility.Lerp(this.m_startPosition.x, this.m_endPosition.x, (Fix64)((long)this.m_life) / (Fix64)((long)this.m_lifeMax));
					this.AddSkillDelayHits(this.m_sourceSkillState, x, x2);
					this.TickDelayHits();
				}
			}
			else if (this.HasDelayHit())
			{
				this.TickDelayHits();
				if (this.m_fx != null)
				{
					this.m_fx.FxStop(true);
					this.m_fx = null;
				}
			}
			else
			{
				base.DeleteMe();
			}
		}

		// Token: 0x060038A6 RID: 14502 RVA: 0x00101EBC File Offset: 0x001000BC
		private void AddSkillDelayHits(CombatSkillState ss, Fix64 x0, Fix64 x1)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddSkillDelayHitsCombatSkillStateFix64Fix64_hotfix != null)
			{
				this.m_AddSkillDelayHitsCombatSkillStateFix64Fix64_hotfix.call(new object[]
				{
					this,
					ss,
					x0,
					x1
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			int num2 = 0;
			int num3 = this.GetDelayHitFrameMax() - this.m_frameCount;
			if (num3 >= 0 && ss.m_skillInfo.Time_MultiHit.Count > 0)
			{
				num = Combat.FrameToMillisecond(num3) + ss.m_skillInfo.Time_MultiHit[0];
				num2 = 1;
			}
			while (ss.m_preAttackHitCount < ss.m_skillInfo.HitCountMax)
			{
				CombatActor combatActor = this.SearchHitTarget(x0, x1, this.m_hitId);
				if (combatActor != null)
				{
					bool isCritical = ss.IsCritical(combatActor.IsHero());
					do
					{
						this.AddDelayHit(combatActor, num);
						this.m_sourceActor.PreAttack(combatActor, ss.m_skillInfo, isCritical);
						if (ss.m_skillInfo.Time_MultiHit.Count > 0)
						{
							num += ss.m_skillInfo.Time_MultiHit[num2 % ss.m_skillInfo.Time_MultiHit.Count];
							num2++;
						}
						ss.m_preAttackHitCount++;
						if (combatActor.GetPreAttackHealthPoint() <= 0 && !combatActor.IsHero())
						{
							break;
						}
					}
					while (ss.m_preAttackHitCount < ss.m_skillInfo.HitCountMax);
					IL_190:
					combatActor.AddBeHitId(this.m_hitId);
					continue;
					goto IL_190;
				}
				break;
			}
		}

		// Token: 0x060038A7 RID: 14503 RVA: 0x00102088 File Offset: 0x00100288
		private bool Attack(CombatActor target)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AttackCombatActor_hotfix != null)
			{
				return Convert.ToBoolean(this.m_AttackCombatActor_hotfix.call(new object[]
				{
					this,
					target
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (target == null)
			{
				return false;
			}
			bool isCritical = this.m_sourceSkillState.IsCritical(target.IsHero());
			target.AttackBy(this.m_sourceActor, this.m_sourceSkillState.m_skillInfo, isCritical);
			return true;
		}

		// Token: 0x060038A8 RID: 14504 RVA: 0x00102138 File Offset: 0x00100338
		private void AddDelayHit(CombatActor target, int delay)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddDelayHitCombatActorInt32_hotfix != null)
			{
				this.m_AddDelayHitCombatActorInt32_hotfix.call(new object[]
				{
					this,
					target,
					delay
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (target == null)
			{
				return;
			}
			if (this.m_delayHits == null)
			{
				this.m_delayHits = new List<DelayHit>();
			}
			int num = this.m_frameCount + Combat.MillisecondToFrame(delay);
			int index = 0;
			for (int i = this.m_delayHits.Count - 1; i >= 0; i--)
			{
				if (this.m_delayHits[i].m_frame <= num)
				{
					index = i + 1;
					break;
				}
			}
			DelayHit item = default(DelayHit);
			item.m_frame = num;
			item.m_targetActor = target;
			this.m_delayHits.Insert(index, item);
			this.m_sourceActor.SetCanStopFrame(delay + this.Combat.ConfigDataLoader.Const_DamagePostDelay);
		}

		// Token: 0x060038A9 RID: 14505 RVA: 0x0010226C File Offset: 0x0010046C
		private int GetDelayHitFrameMax()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDelayHitFrameMax_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetDelayHitFrameMax_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_delayHits == null || this.m_delayHits.Count <= 0)
			{
				return -1;
			}
			return this.m_delayHits[this.m_delayHits.Count - 1].m_frame;
		}

		// Token: 0x060038AA RID: 14506 RVA: 0x00102318 File Offset: 0x00100518
		private bool HasDelayHit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasDelayHit_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasDelayHit_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_delayHits != null && this.m_delayHits.Count > 0;
		}

		// Token: 0x060038AB RID: 14507 RVA: 0x001023A0 File Offset: 0x001005A0
		private void TickDelayHits()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickDelayHits_hotfix != null)
			{
				this.m_TickDelayHits_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_delayHits == null || this.m_delayHits.Count <= 0)
			{
				return;
			}
			DelayHit delayHit = this.m_delayHits[0];
			while (delayHit.m_frame <= this.m_frameCount)
			{
				if (this.Attack(delayHit.m_targetActor))
				{
					this.m_sourceSkillState.m_hitCount++;
					if (this.m_sourceSkillState.m_hitCount >= this.m_sourceSkillState.m_skillInfo.HitCountMax)
					{
						this.m_delayHits.Clear();
						base.DeleteMe();
						break;
					}
				}
				this.m_delayHits.RemoveAt(0);
				if (this.m_delayHits.Count <= 0)
				{
					break;
				}
				delayHit = this.m_delayHits[0];
			}
		}

		// Token: 0x060038AC RID: 14508 RVA: 0x001024D0 File Offset: 0x001006D0
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
			if (this.m_fx != null)
			{
				this.m_fxLife += (Fix64)(dt * 30f);
				int zoffset = (!this.m_isGraphicSkillFade) ? 0 : 25;
				if (this.m_configDataFlyObjectInfo.TrackType == TrackType.TrackType_Parabolic)
				{
					Vector2i b;
					Fix64 y;
					this.ComputeParabolicPosition(this.m_fxLife - Fix64.One, out b, out y);
					Vector2i vector2i;
					Fix64 fix;
					this.ComputeParabolicPosition(this.m_fxLife, out vector2i, out fix);
					this.m_fx.SetCombatPosition(vector2i, fix, zoffset);
					this.m_fx.SetCombatDirection(vector2i - b, fix - y);
				}
				else
				{
					Fix64 t = this.m_fxLife / (Fix64)((long)this.m_lifeMax);
					Vector2i pos = Vector2i.Lerp(this.m_startPosition, this.m_endPosition, t);
					Fix64 z = MathUtility.Lerp((Fix64)((long)this.m_startZ), (Fix64)((long)this.m_endZ), t);
					this.m_fx.SetCombatPosition(pos, z, zoffset);
					this.m_fx.SetCombatDirection(this.m_endPosition - this.m_startPosition, (Fix64)((long)(this.m_endZ - this.m_startZ)));
				}
			}
		}

		// Token: 0x060038AD RID: 14509 RVA: 0x00102674 File Offset: 0x00100874
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
			if (this.m_configDataFlyObjectInfo.TrackType == TrackType.TrackType_Parabolic)
			{
				Vector2i p;
				Fix64 z;
				this.ComputeParabolicPosition((Fix64)((long)(this.m_life - 1)), out p, out z);
				Vector2i p2;
				Fix64 z2;
				this.ComputeParabolicPosition((Fix64)((long)this.m_life), out p2, out z2);
				this.Combat.Listener.DrawLine(p, z, p2, z2, color);
			}
			else
			{
				Fix64 t = (Fix64)((long)(this.m_life - 1)) / (Fix64)((long)this.m_lifeMax);
				Fix64 t2 = (Fix64)((long)this.m_life) / (Fix64)((long)this.m_lifeMax);
				Vector2i p3 = Vector2i.Lerp(this.m_startPosition, this.m_endPosition, t);
				Vector2i p4 = Vector2i.Lerp(this.m_startPosition, this.m_endPosition, t2);
				Fix64 z3 = MathUtility.Lerp((Fix64)((long)this.m_startZ), (Fix64)((long)this.m_endZ), t);
				Fix64 z4 = MathUtility.Lerp((Fix64)((long)this.m_startZ), (Fix64)((long)this.m_endZ), t2);
				this.Combat.Listener.DrawLine(p3, z3, p4, z4, color);
			}
		}

		// Token: 0x060038AE RID: 14510 RVA: 0x00102800 File Offset: 0x00100A00
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
			if (this.m_fx != null)
			{
				this.m_fx.Pause(pause);
			}
		}

		// Token: 0x060038AF RID: 14511 RVA: 0x00102888 File Offset: 0x00100A88
		private void ComputeParabolicPosition(Fix64 life, out Vector2i pos, out Fix64 z)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeParabolicPositionFix64Vector2i_Fix64__hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_ProjectL_Battle_CombatFlyObject_ComputeParabolicPosition_Fix64_Vector2i_Fix64(this, this.m_ComputeParabolicPositionFix64Vector2i_Fix64__hotfix, life, out pos, out z);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			pos = Vector2i.Lerp(this.m_startPosition, this.m_endPosition, life / (Fix64)((long)this.m_lifeMax));
			Fix64 x = (Fix64)((long)(-(long)this.m_configDataFlyObjectInfo.Gravity));
			Fix64 y = life * CombatConst.TickTime;
			z = this.m_vz * y + x * y * y * (Fix64)0.5f + (Fix64)((long)this.m_startZ);
		}

		// Token: 0x060038B0 RID: 14512 RVA: 0x0010296C File Offset: 0x00100B6C
		private void CreateFx(string assetName, float scale)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateFxStringSingle_hotfix != null)
			{
				this.m_CreateFxStringSingle_hotfix.call(new object[]
				{
					this,
					assetName,
					scale
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_fx != null)
			{
				this.m_fx.FxStop(false);
			}
			this.m_fx = this.Combat.Listener.PlayFx(assetName, scale);
			if (this.m_fx != null)
			{
				this.m_fx.SetName("Fly_" + this.m_id);
			}
		}

		// Token: 0x17000F8A RID: 3978
		// (get) Token: 0x060038B1 RID: 14513 RVA: 0x00102A48 File Offset: 0x00100C48
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

		// Token: 0x17000F8B RID: 3979
		// (get) Token: 0x060038B2 RID: 14514 RVA: 0x00102AC0 File Offset: 0x00100CC0
		// (set) Token: 0x060038B3 RID: 14515 RVA: 0x00102AE0 File Offset: 0x00100CE0
		[DoNotToLua]
		public new CombatFlyObject.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new CombatFlyObject.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060038B4 RID: 14516 RVA: 0x00102AEC File Offset: 0x00100CEC
		private void __callBase_Dispose()
		{
			base.Dispose();
		}

		// Token: 0x060038B5 RID: 14517 RVA: 0x00102AF4 File Offset: 0x00100CF4
		private void __callBase_Tick()
		{
			base.Tick();
		}

		// Token: 0x060038B6 RID: 14518 RVA: 0x00102AFC File Offset: 0x00100CFC
		private void __callBase_TickGraphic(float dt)
		{
			base.TickGraphic(dt);
		}

		// Token: 0x060038B7 RID: 14519 RVA: 0x00102B08 File Offset: 0x00100D08
		private void __callBase_Draw()
		{
			base.Draw();
		}

		// Token: 0x060038B8 RID: 14520 RVA: 0x00102B10 File Offset: 0x00100D10
		private void __callBase_Pause(bool pause)
		{
			base.Pause(pause);
		}

		// Token: 0x060038B9 RID: 14521 RVA: 0x00102B1C File Offset: 0x00100D1C
		private void __callBase_DoPause(bool pause)
		{
			base.DoPause(pause);
		}

		// Token: 0x060038BA RID: 14522 RVA: 0x00102B28 File Offset: 0x00100D28
		private void __callBase_DeleteMe()
		{
			base.DeleteMe();
		}

		// Token: 0x060038BB RID: 14523 RVA: 0x00102B30 File Offset: 0x00100D30
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
					this.m_InitializeCombatTeam_hotfix = (luaObj.RawGet("Initialize") as LuaFunction);
					this.m_SetupConfigDataFlyObjectInfoCombatSkillStateCombatActorCombatActor_hotfix = (luaObj.RawGet("Setup") as LuaFunction);
					this.m_IsHero_hotfix = (luaObj.RawGet("IsHero") as LuaFunction);
					this.m_SetGraphicSkillFadeBoolean_hotfix = (luaObj.RawGet("SetGraphicSkillFade") as LuaFunction);
					this.m_SearchHitTargetFix64Fix64UInt16_hotfix = (luaObj.RawGet("SearchHitTarget") as LuaFunction);
					this.m_Tick_hotfix = (luaObj.RawGet("Tick") as LuaFunction);
					this.m_AddSkillDelayHitsCombatSkillStateFix64Fix64_hotfix = (luaObj.RawGet("AddSkillDelayHits") as LuaFunction);
					this.m_AttackCombatActor_hotfix = (luaObj.RawGet("Attack") as LuaFunction);
					this.m_AddDelayHitCombatActorInt32_hotfix = (luaObj.RawGet("AddDelayHit") as LuaFunction);
					this.m_GetDelayHitFrameMax_hotfix = (luaObj.RawGet("GetDelayHitFrameMax") as LuaFunction);
					this.m_HasDelayHit_hotfix = (luaObj.RawGet("HasDelayHit") as LuaFunction);
					this.m_TickDelayHits_hotfix = (luaObj.RawGet("TickDelayHits") as LuaFunction);
					this.m_TickGraphicSingle_hotfix = (luaObj.RawGet("TickGraphic") as LuaFunction);
					this.m_Draw_hotfix = (luaObj.RawGet("Draw") as LuaFunction);
					this.m_DoPauseBoolean_hotfix = (luaObj.RawGet("DoPause") as LuaFunction);
					this.m_ComputeParabolicPositionFix64Vector2i_Fix64__hotfix = (luaObj.RawGet("ComputeParabolicPosition") as LuaFunction);
					this.m_CreateFxStringSingle_hotfix = (luaObj.RawGet("CreateFx") as LuaFunction);
					this.m_get_Combat_hotfix = (luaObj.RawGet("get_Combat") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060038BC RID: 14524 RVA: 0x00102DD8 File Offset: 0x00100FD8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CombatFlyObject));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002B9C RID: 11164
		private CombatTeam m_team;

		// Token: 0x04002B9D RID: 11165
		private Vector2i m_startPosition;

		// Token: 0x04002B9E RID: 11166
		private Vector2i m_endPosition;

		// Token: 0x04002B9F RID: 11167
		private int m_startZ;

		// Token: 0x04002BA0 RID: 11168
		private int m_endZ;

		// Token: 0x04002BA1 RID: 11169
		private Fix64 m_vz;

		// Token: 0x04002BA2 RID: 11170
		private int m_life;

		// Token: 0x04002BA3 RID: 11171
		private int m_lifeMax;

		// Token: 0x04002BA4 RID: 11172
		private int m_frameCount;

		// Token: 0x04002BA5 RID: 11173
		private ushort m_hitId;

		// Token: 0x04002BA6 RID: 11174
		private List<DelayHit> m_delayHits;

		// Token: 0x04002BA7 RID: 11175
		private CombatActor m_targetActor;

		// Token: 0x04002BA8 RID: 11176
		private int m_targetTeamNumber;

		// Token: 0x04002BA9 RID: 11177
		private CombatActor m_sourceActor;

		// Token: 0x04002BAA RID: 11178
		private CombatSkillState m_sourceSkillState;

		// Token: 0x04002BAB RID: 11179
		private ConfigDataFlyObjectInfo m_configDataFlyObjectInfo;

		// Token: 0x04002BAC RID: 11180
		private IBattleGraphic m_fx;

		// Token: 0x04002BAD RID: 11181
		private Fix64 m_fxLife;

		// Token: 0x04002BAE RID: 11182
		private bool m_isGraphicSkillFade;

		// Token: 0x04002BAF RID: 11183
		[DoNotToLua]
		private CombatFlyObject.LuaExportHelper luaExportHelper;

		// Token: 0x04002BB0 RID: 11184
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002BB1 RID: 11185
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002BB2 RID: 11186
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04002BB3 RID: 11187
		private LuaFunction m_Dispose_hotfix;

		// Token: 0x04002BB4 RID: 11188
		private LuaFunction m_InitializeCombatTeam_hotfix;

		// Token: 0x04002BB5 RID: 11189
		private LuaFunction m_SetupConfigDataFlyObjectInfoCombatSkillStateCombatActorCombatActor_hotfix;

		// Token: 0x04002BB6 RID: 11190
		private LuaFunction m_IsHero_hotfix;

		// Token: 0x04002BB7 RID: 11191
		private LuaFunction m_SetGraphicSkillFadeBoolean_hotfix;

		// Token: 0x04002BB8 RID: 11192
		private LuaFunction m_SearchHitTargetFix64Fix64UInt16_hotfix;

		// Token: 0x04002BB9 RID: 11193
		private LuaFunction m_Tick_hotfix;

		// Token: 0x04002BBA RID: 11194
		private LuaFunction m_AddSkillDelayHitsCombatSkillStateFix64Fix64_hotfix;

		// Token: 0x04002BBB RID: 11195
		private LuaFunction m_AttackCombatActor_hotfix;

		// Token: 0x04002BBC RID: 11196
		private LuaFunction m_AddDelayHitCombatActorInt32_hotfix;

		// Token: 0x04002BBD RID: 11197
		private LuaFunction m_GetDelayHitFrameMax_hotfix;

		// Token: 0x04002BBE RID: 11198
		private LuaFunction m_HasDelayHit_hotfix;

		// Token: 0x04002BBF RID: 11199
		private LuaFunction m_TickDelayHits_hotfix;

		// Token: 0x04002BC0 RID: 11200
		private LuaFunction m_TickGraphicSingle_hotfix;

		// Token: 0x04002BC1 RID: 11201
		private LuaFunction m_Draw_hotfix;

		// Token: 0x04002BC2 RID: 11202
		private LuaFunction m_DoPauseBoolean_hotfix;

		// Token: 0x04002BC3 RID: 11203
		private LuaFunction m_ComputeParabolicPositionFix64Vector2i_Fix64__hotfix;

		// Token: 0x04002BC4 RID: 11204
		private LuaFunction m_CreateFxStringSingle_hotfix;

		// Token: 0x04002BC5 RID: 11205
		private LuaFunction m_get_Combat_hotfix;

		// Token: 0x020003BD RID: 957
		public new class LuaExportHelper
		{
			// Token: 0x060038BD RID: 14525 RVA: 0x00102E40 File Offset: 0x00101040
			public LuaExportHelper(CombatFlyObject owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060038BE RID: 14526 RVA: 0x00102E50 File Offset: 0x00101050
			public void __callBase_Dispose()
			{
				this.m_owner.__callBase_Dispose();
			}

			// Token: 0x060038BF RID: 14527 RVA: 0x00102E60 File Offset: 0x00101060
			public void __callBase_Tick()
			{
				this.m_owner.__callBase_Tick();
			}

			// Token: 0x060038C0 RID: 14528 RVA: 0x00102E70 File Offset: 0x00101070
			public void __callBase_TickGraphic(float dt)
			{
				this.m_owner.__callBase_TickGraphic(dt);
			}

			// Token: 0x060038C1 RID: 14529 RVA: 0x00102E80 File Offset: 0x00101080
			public void __callBase_Draw()
			{
				this.m_owner.__callBase_Draw();
			}

			// Token: 0x060038C2 RID: 14530 RVA: 0x00102E90 File Offset: 0x00101090
			public void __callBase_Pause(bool pause)
			{
				this.m_owner.__callBase_Pause(pause);
			}

			// Token: 0x060038C3 RID: 14531 RVA: 0x00102EA0 File Offset: 0x001010A0
			public void __callBase_DoPause(bool pause)
			{
				this.m_owner.__callBase_DoPause(pause);
			}

			// Token: 0x060038C4 RID: 14532 RVA: 0x00102EB0 File Offset: 0x001010B0
			public void __callBase_DeleteMe()
			{
				this.m_owner.__callBase_DeleteMe();
			}

			// Token: 0x17000F8C RID: 3980
			// (get) Token: 0x060038C5 RID: 14533 RVA: 0x00102EC0 File Offset: 0x001010C0
			// (set) Token: 0x060038C6 RID: 14534 RVA: 0x00102ED0 File Offset: 0x001010D0
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

			// Token: 0x17000F8D RID: 3981
			// (get) Token: 0x060038C7 RID: 14535 RVA: 0x00102EE0 File Offset: 0x001010E0
			// (set) Token: 0x060038C8 RID: 14536 RVA: 0x00102EF0 File Offset: 0x001010F0
			public Vector2i m_startPosition
			{
				get
				{
					return this.m_owner.m_startPosition;
				}
				set
				{
					this.m_owner.m_startPosition = value;
				}
			}

			// Token: 0x17000F8E RID: 3982
			// (get) Token: 0x060038C9 RID: 14537 RVA: 0x00102F00 File Offset: 0x00101100
			// (set) Token: 0x060038CA RID: 14538 RVA: 0x00102F10 File Offset: 0x00101110
			public Vector2i m_endPosition
			{
				get
				{
					return this.m_owner.m_endPosition;
				}
				set
				{
					this.m_owner.m_endPosition = value;
				}
			}

			// Token: 0x17000F8F RID: 3983
			// (get) Token: 0x060038CB RID: 14539 RVA: 0x00102F20 File Offset: 0x00101120
			// (set) Token: 0x060038CC RID: 14540 RVA: 0x00102F30 File Offset: 0x00101130
			public int m_startZ
			{
				get
				{
					return this.m_owner.m_startZ;
				}
				set
				{
					this.m_owner.m_startZ = value;
				}
			}

			// Token: 0x17000F90 RID: 3984
			// (get) Token: 0x060038CD RID: 14541 RVA: 0x00102F40 File Offset: 0x00101140
			// (set) Token: 0x060038CE RID: 14542 RVA: 0x00102F50 File Offset: 0x00101150
			public int m_endZ
			{
				get
				{
					return this.m_owner.m_endZ;
				}
				set
				{
					this.m_owner.m_endZ = value;
				}
			}

			// Token: 0x17000F91 RID: 3985
			// (get) Token: 0x060038CF RID: 14543 RVA: 0x00102F60 File Offset: 0x00101160
			// (set) Token: 0x060038D0 RID: 14544 RVA: 0x00102F70 File Offset: 0x00101170
			public Fix64 m_vz
			{
				get
				{
					return this.m_owner.m_vz;
				}
				set
				{
					this.m_owner.m_vz = value;
				}
			}

			// Token: 0x17000F92 RID: 3986
			// (get) Token: 0x060038D1 RID: 14545 RVA: 0x00102F80 File Offset: 0x00101180
			// (set) Token: 0x060038D2 RID: 14546 RVA: 0x00102F90 File Offset: 0x00101190
			public int m_life
			{
				get
				{
					return this.m_owner.m_life;
				}
				set
				{
					this.m_owner.m_life = value;
				}
			}

			// Token: 0x17000F93 RID: 3987
			// (get) Token: 0x060038D3 RID: 14547 RVA: 0x00102FA0 File Offset: 0x001011A0
			// (set) Token: 0x060038D4 RID: 14548 RVA: 0x00102FB0 File Offset: 0x001011B0
			public int m_lifeMax
			{
				get
				{
					return this.m_owner.m_lifeMax;
				}
				set
				{
					this.m_owner.m_lifeMax = value;
				}
			}

			// Token: 0x17000F94 RID: 3988
			// (get) Token: 0x060038D5 RID: 14549 RVA: 0x00102FC0 File Offset: 0x001011C0
			// (set) Token: 0x060038D6 RID: 14550 RVA: 0x00102FD0 File Offset: 0x001011D0
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

			// Token: 0x17000F95 RID: 3989
			// (get) Token: 0x060038D7 RID: 14551 RVA: 0x00102FE0 File Offset: 0x001011E0
			// (set) Token: 0x060038D8 RID: 14552 RVA: 0x00102FF0 File Offset: 0x001011F0
			public ushort m_hitId
			{
				get
				{
					return this.m_owner.m_hitId;
				}
				set
				{
					this.m_owner.m_hitId = value;
				}
			}

			// Token: 0x17000F96 RID: 3990
			// (get) Token: 0x060038D9 RID: 14553 RVA: 0x00103000 File Offset: 0x00101200
			// (set) Token: 0x060038DA RID: 14554 RVA: 0x00103010 File Offset: 0x00101210
			public List<DelayHit> m_delayHits
			{
				get
				{
					return this.m_owner.m_delayHits;
				}
				set
				{
					this.m_owner.m_delayHits = value;
				}
			}

			// Token: 0x17000F97 RID: 3991
			// (get) Token: 0x060038DB RID: 14555 RVA: 0x00103020 File Offset: 0x00101220
			// (set) Token: 0x060038DC RID: 14556 RVA: 0x00103030 File Offset: 0x00101230
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

			// Token: 0x17000F98 RID: 3992
			// (get) Token: 0x060038DD RID: 14557 RVA: 0x00103040 File Offset: 0x00101240
			// (set) Token: 0x060038DE RID: 14558 RVA: 0x00103050 File Offset: 0x00101250
			public int m_targetTeamNumber
			{
				get
				{
					return this.m_owner.m_targetTeamNumber;
				}
				set
				{
					this.m_owner.m_targetTeamNumber = value;
				}
			}

			// Token: 0x17000F99 RID: 3993
			// (get) Token: 0x060038DF RID: 14559 RVA: 0x00103060 File Offset: 0x00101260
			// (set) Token: 0x060038E0 RID: 14560 RVA: 0x00103070 File Offset: 0x00101270
			public CombatActor m_sourceActor
			{
				get
				{
					return this.m_owner.m_sourceActor;
				}
				set
				{
					this.m_owner.m_sourceActor = value;
				}
			}

			// Token: 0x17000F9A RID: 3994
			// (get) Token: 0x060038E1 RID: 14561 RVA: 0x00103080 File Offset: 0x00101280
			// (set) Token: 0x060038E2 RID: 14562 RVA: 0x00103090 File Offset: 0x00101290
			public CombatSkillState m_sourceSkillState
			{
				get
				{
					return this.m_owner.m_sourceSkillState;
				}
				set
				{
					this.m_owner.m_sourceSkillState = value;
				}
			}

			// Token: 0x17000F9B RID: 3995
			// (get) Token: 0x060038E3 RID: 14563 RVA: 0x001030A0 File Offset: 0x001012A0
			// (set) Token: 0x060038E4 RID: 14564 RVA: 0x001030B0 File Offset: 0x001012B0
			public ConfigDataFlyObjectInfo m_configDataFlyObjectInfo
			{
				get
				{
					return this.m_owner.m_configDataFlyObjectInfo;
				}
				set
				{
					this.m_owner.m_configDataFlyObjectInfo = value;
				}
			}

			// Token: 0x17000F9C RID: 3996
			// (get) Token: 0x060038E5 RID: 14565 RVA: 0x001030C0 File Offset: 0x001012C0
			// (set) Token: 0x060038E6 RID: 14566 RVA: 0x001030D0 File Offset: 0x001012D0
			public IBattleGraphic m_fx
			{
				get
				{
					return this.m_owner.m_fx;
				}
				set
				{
					this.m_owner.m_fx = value;
				}
			}

			// Token: 0x17000F9D RID: 3997
			// (get) Token: 0x060038E7 RID: 14567 RVA: 0x001030E0 File Offset: 0x001012E0
			// (set) Token: 0x060038E8 RID: 14568 RVA: 0x001030F0 File Offset: 0x001012F0
			public Fix64 m_fxLife
			{
				get
				{
					return this.m_owner.m_fxLife;
				}
				set
				{
					this.m_owner.m_fxLife = value;
				}
			}

			// Token: 0x17000F9E RID: 3998
			// (get) Token: 0x060038E9 RID: 14569 RVA: 0x00103100 File Offset: 0x00101300
			// (set) Token: 0x060038EA RID: 14570 RVA: 0x00103110 File Offset: 0x00101310
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

			// Token: 0x060038EB RID: 14571 RVA: 0x00103120 File Offset: 0x00101320
			public static int ComputeTargetScore(Fix64 x, CombatActor target)
			{
				return CombatFlyObject.ComputeTargetScore(x, target);
			}

			// Token: 0x060038EC RID: 14572 RVA: 0x0010312C File Offset: 0x0010132C
			public CombatActor SearchHitTarget(Fix64 x0, Fix64 x1, ushort hitId)
			{
				return this.m_owner.SearchHitTarget(x0, x1, hitId);
			}

			// Token: 0x060038ED RID: 14573 RVA: 0x0010313C File Offset: 0x0010133C
			public void AddSkillDelayHits(CombatSkillState ss, Fix64 x0, Fix64 x1)
			{
				this.m_owner.AddSkillDelayHits(ss, x0, x1);
			}

			// Token: 0x060038EE RID: 14574 RVA: 0x0010314C File Offset: 0x0010134C
			public bool Attack(CombatActor target)
			{
				return this.m_owner.Attack(target);
			}

			// Token: 0x060038EF RID: 14575 RVA: 0x0010315C File Offset: 0x0010135C
			public void AddDelayHit(CombatActor target, int delay)
			{
				this.m_owner.AddDelayHit(target, delay);
			}

			// Token: 0x060038F0 RID: 14576 RVA: 0x0010316C File Offset: 0x0010136C
			public int GetDelayHitFrameMax()
			{
				return this.m_owner.GetDelayHitFrameMax();
			}

			// Token: 0x060038F1 RID: 14577 RVA: 0x0010317C File Offset: 0x0010137C
			public bool HasDelayHit()
			{
				return this.m_owner.HasDelayHit();
			}

			// Token: 0x060038F2 RID: 14578 RVA: 0x0010318C File Offset: 0x0010138C
			public void TickDelayHits()
			{
				this.m_owner.TickDelayHits();
			}

			// Token: 0x060038F3 RID: 14579 RVA: 0x0010319C File Offset: 0x0010139C
			public void ComputeParabolicPosition(Fix64 life, out Vector2i pos, out Fix64 z)
			{
				this.m_owner.ComputeParabolicPosition(life, out pos, out z);
			}

			// Token: 0x060038F4 RID: 14580 RVA: 0x001031AC File Offset: 0x001013AC
			public void CreateFx(string assetName, float scale)
			{
				this.m_owner.CreateFx(assetName, scale);
			}

			// Token: 0x04002BC6 RID: 11206
			private CombatFlyObject m_owner;
		}
	}
}
