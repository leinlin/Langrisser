using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x020003BE RID: 958
	[HotFix]
	public class CombatTeam
	{
		// Token: 0x060038F5 RID: 14581 RVA: 0x001031BC File Offset: 0x001013BC
		public CombatTeam()
		{
			this.m_actors = new List<CombatActor>();
			this.m_flyObjects = new List<CombatFlyObject>();
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

		// Token: 0x060038F6 RID: 14582 RVA: 0x00103238 File Offset: 0x00101438
		static CombatTeam()
		{
			int num = 80;
			int num2 = num / 2;
			int num3 = 60;
			int num4 = 1;
			int num5 = 50;
			CombatTeam.s_formationPositions = new Position2i[]
			{
				new Position2i(num3, num4),
				new Position2i(num3, num4 + num),
				new Position2i(num3, num4 - num),
				new Position2i(num3 + num5, num4 + num - num2),
				new Position2i(num3 + num5, num4 - num2),
				new Position2i(num3 + num5 * 2, num4),
				new Position2i(num3 + num5 * 2, num4 + num),
				new Position2i(num3 + num5 * 2, num4 - num),
				new Position2i(num3 + num5 * 3, num4 + num - num2),
				new Position2i(num3 + num5 * 3, num4 - num2)
			};
		}

		// Token: 0x060038F7 RID: 14583 RVA: 0x00103354 File Offset: 0x00101554
		public void Initialize(Combat combat, int team, BattleActor battleActor, ConfigDataSkillInfo heroSkillInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitializeCombatInt32BattleActorConfigDataSkillInfo_hotfix != null)
			{
				this.m_InitializeCombatInt32BattleActorConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					combat,
					team,
					battleActor,
					heroSkillInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_combat = combat;
			this.m_teamNumber = team;
			this.m_battleActor = battleActor;
			this.m_heroSkillInfo = heroSkillInfo;
		}

		// Token: 0x060038F8 RID: 14584 RVA: 0x00103414 File Offset: 0x00101614
		private void ComputeHeroCriticalAttack()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeHeroCriticalAttack_hotfix != null)
			{
				this.m_ComputeHeroCriticalAttack_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleActor battleActor = this.GetTargetTeam().BattleActor;
			this.m_shouldHeroToHeroCriticalAttack = this.m_combat.IsProbabilitySatisfied(this.m_battleActor.HeroBattleProperty.CriticalRate + battleActor.HeroBattleProperty.Buff_ReceiveCriticalRateAdd);
			this.m_shouldHeroToSoldierCriticalAttack = this.m_combat.IsProbabilitySatisfied(this.m_battleActor.HeroBattleProperty.CriticalRate + battleActor.SoldierBattleProperty.Buff_ReceiveCriticalRateAdd);
		}

		// Token: 0x060038F9 RID: 14585 RVA: 0x001034DC File Offset: 0x001016DC
		private void ComputeSoldierCriticalAttack()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeSoldierCriticalAttack_hotfix != null)
			{
				this.m_ComputeSoldierCriticalAttack_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleActor battleActor = this.GetTargetTeam().BattleActor;
			this.m_shouldSoldierToHeroCriticalAttack = this.m_combat.IsProbabilitySatisfied(this.m_battleActor.SoldierBattleProperty.CriticalRate + battleActor.HeroBattleProperty.Buff_ReceiveCriticalRateAdd);
			this.m_shouldSoldierToSoldierCriticalAttack = this.m_combat.IsProbabilitySatisfied(this.m_battleActor.SoldierBattleProperty.CriticalRate + battleActor.SoldierBattleProperty.Buff_ReceiveCriticalRateAdd);
		}

		// Token: 0x060038FA RID: 14586 RVA: 0x001035A4 File Offset: 0x001017A4
		public bool IsAttackHeroOnly()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsAttackHeroOnly_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsAttackHeroOnly_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_battleActor.HasFightTag(FightTag.FightTag_OnlyAttackHero);
		}

		// Token: 0x060038FB RID: 14587 RVA: 0x00103620 File Offset: 0x00101820
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
			EntityList.Tick<CombatActor>(this.m_actors);
			EntityList.Tick<CombatFlyObject>(this.m_flyObjects);
		}

		// Token: 0x060038FC RID: 14588 RVA: 0x00103698 File Offset: 0x00101898
		public void RemoveDeleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RemoveDeleted_hotfix != null)
			{
				this.m_RemoveDeleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			EntityList.RemoveDeleted<CombatActor>(this.m_actors);
			EntityList.RemoveDeleted<CombatFlyObject>(this.m_flyObjects);
		}

		// Token: 0x060038FD RID: 14589 RVA: 0x00103710 File Offset: 0x00101910
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
			EntityList.TickGraphic<CombatActor>(this.m_actors, dt);
			EntityList.TickGraphic<CombatFlyObject>(this.m_flyObjects, dt);
		}

		// Token: 0x060038FE RID: 14590 RVA: 0x00103798 File Offset: 0x00101998
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
			EntityList.Draw<CombatActor>(this.m_actors);
			EntityList.Draw<CombatFlyObject>(this.m_flyObjects);
		}

		// Token: 0x060038FF RID: 14591 RVA: 0x00103810 File Offset: 0x00101A10
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
			EntityList.Pause<CombatActor>(this.m_actors, pause);
			EntityList.Pause<CombatFlyObject>(this.m_flyObjects, pause);
		}

		// Token: 0x06003900 RID: 14592 RVA: 0x00103898 File Offset: 0x00101A98
		public Colori GetColor()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetColor_hotfix != null)
			{
				return (Colori)this.m_GetColor_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_teamNumber == 0)
			{
				return new Colori(150, 150, 150, byte.MaxValue);
			}
			return new Colori(100, 100, 200, byte.MaxValue);
		}

		// Token: 0x06003901 RID: 14593 RVA: 0x0010393C File Offset: 0x00101B3C
		public CombatActor CreateActor(bool isHero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateActorBoolean_hotfix != null)
			{
				return (CombatActor)this.m_CreateActorBoolean_hotfix.call(new object[]
				{
					this,
					isHero
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.HeroInfo == null)
			{
				return null;
			}
			CombatActor combatActor = new CombatActor();
			combatActor.Initialize(this, isHero);
			this.m_actors.Add(combatActor);
			return combatActor;
		}

		// Token: 0x06003902 RID: 14594 RVA: 0x001039E0 File Offset: 0x00101BE0
		public CombatFlyObject CreateFlyObject()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateFlyObject_hotfix != null)
			{
				return (CombatFlyObject)this.m_CreateFlyObject_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CombatFlyObject combatFlyObject = new CombatFlyObject();
			combatFlyObject.Initialize(this);
			this.m_flyObjects.Add(combatFlyObject);
			return combatFlyObject;
		}

		// Token: 0x06003903 RID: 14595 RVA: 0x00103A68 File Offset: 0x00101C68
		public void RemoveAll()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RemoveAll_hotfix != null)
			{
				this.m_RemoveAll_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			EntityList.RemoveAll<CombatActor>(this.m_actors);
			EntityList.RemoveAll<CombatFlyObject>(this.m_flyObjects);
		}

		// Token: 0x06003904 RID: 14596 RVA: 0x00103AE0 File Offset: 0x00101CE0
		public void OnMyActorCastSkill(CombatActor a, ConfigDataSkillInfo skillInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMyActorCastSkillCombatActorConfigDataSkillInfo_hotfix != null)
			{
				this.m_OnMyActorCastSkillCombatActorConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					a,
					skillInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (skillInfo.IsDamageSkill())
			{
				this.m_isCastAnyDamageSkill = true;
			}
			this.m_combat.OnActorCastSkill(a, skillInfo);
		}

		// Token: 0x06003905 RID: 14597 RVA: 0x00103B80 File Offset: 0x00101D80
		public void OnMyActorAttackBy(CombatActor a, CombatActor attacker, ConfigDataSkillInfo skillInfo, int hpModify, bool isCritical, ArmyRelationData armyRelation)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMyActorAttackByCombatActorCombatActorConfigDataSkillInfoInt32BooleanArmyRelationData_hotfix != null)
			{
				this.m_OnMyActorAttackByCombatActorCombatActorConfigDataSkillInfoInt32BooleanArmyRelationData_hotfix.call(new object[]
				{
					this,
					a,
					attacker,
					skillInfo,
					hpModify,
					isCritical,
					armyRelation
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (a == null || attacker == null || skillInfo == null)
			{
				return;
			}
			int num = Math.Abs(hpModify);
			if (a.IsHero())
			{
				this.m_heroReceiveTotalDamage += num;
			}
			else
			{
				this.m_soldierReceiveTotalDamage += num;
			}
			if (attacker.IsHero())
			{
				attacker.Team.m_heroApplyTotalDamage += num;
			}
			else
			{
				attacker.Team.m_soldierApplyTotalDamage += num;
			}
			if (skillInfo.IsDamageSkill())
			{
				this.m_lastDamageBySkill = skillInfo;
			}
			if (isCritical)
			{
				this.m_isBeCriticalAttack = true;
			}
			DamageNumberType damageNumberType = BattleFormula.ComputeDamangeNumberType(skillInfo, isCritical, armyRelation, false);
			this.m_combat.Listener.OnCombatActorHit(a, attacker, skillInfo, hpModify, this.m_heroReceiveTotalDamage + this.m_soldierReceiveTotalDamage, damageNumberType);
			if (skillInfo.Buffs_ID.Count > 0 && !attacker.Team.m_isTryApplyBuff)
			{
				this.m_attachBuffSourceSkillInfo = skillInfo;
				attacker.Team.m_isTryApplyBuff = true;
			}
		}

		// Token: 0x06003906 RID: 14598 RVA: 0x00103D40 File Offset: 0x00101F40
		public void OnMyActorReboundDamage(CombatActor a, CombatActor attacker, ConfigDataSkillInfo skillInfo, int hpModify)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMyActorReboundDamageCombatActorCombatActorConfigDataSkillInfoInt32_hotfix != null)
			{
				this.m_OnMyActorReboundDamageCombatActorCombatActorConfigDataSkillInfoInt32_hotfix.call(new object[]
				{
					this,
					a,
					attacker,
					skillInfo,
					hpModify
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (a == null || attacker == null || skillInfo == null)
			{
				return;
			}
			int num = Math.Abs(hpModify);
			if (a.IsHero())
			{
				this.m_heroReceiveTotalDamage += num;
			}
			else
			{
				this.m_soldierReceiveTotalDamage += num;
			}
			if (attacker.IsHero())
			{
				attacker.Team.m_heroApplyTotalDamage += num;
			}
			else
			{
				attacker.Team.m_soldierApplyTotalDamage += num;
			}
			this.m_combat.Listener.OnCombatActorHit(a, attacker, skillInfo, hpModify, this.m_heroReceiveTotalDamage + this.m_soldierReceiveTotalDamage, DamageNumberType.Normal);
		}

		// Token: 0x06003907 RID: 14599 RVA: 0x00103E80 File Offset: 0x00102080
		public void OnMyActorDie(CombatActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMyActorDieCombatActor_hotfix != null)
			{
				this.m_OnMyActorDieCombatActor_hotfix.call(new object[]
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
			if (a.IsHero())
			{
				foreach (CombatActor combatActor in this.m_actors)
				{
					if (!combatActor.IsHero())
					{
						combatActor.SetHealthPoint(0);
					}
				}
				ConfigDataCharImageInfo charImageInfo = this.HeroInfo.GetCharImageInfo(this.HeroStar);
				if (charImageInfo != null)
				{
					this.m_combat.Listener.PlaySound(charImageInfo.Sound_Die);
				}
			}
			else
			{
				this.m_combat.Listener.PlaySound(this.SoldierInfo.Sound_Die);
			}
			this.m_combat.OnActorDie(a);
		}

		// Token: 0x06003908 RID: 14600 RVA: 0x00103FB8 File Offset: 0x001021B8
		public void OnMyActorFightAgain(CombatActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMyActorFightAgainCombatActor_hotfix != null)
			{
				this.m_OnMyActorFightAgainCombatActor_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (a.IsHero())
			{
				this.ComputeHeroCriticalAttack();
				BuffState doubleAttackBuff = this.GetDoubleAttackBuff();
				if (doubleAttackBuff != null)
				{
					this.m_combat.OnActorCastPassiveSkill(a, doubleAttackBuff);
				}
			}
		}

		// Token: 0x06003909 RID: 14601 RVA: 0x00104054 File Offset: 0x00102254
		public Position2i GetFormationPosition(int idx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetFormationPositionInt32_hotfix != null)
			{
				return (Position2i)this.m_GetFormationPositionInt32_hotfix.call(new object[]
				{
					this,
					idx
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = idx % CombatTeam.s_formationPositions.Length;
			return CombatTeam.s_formationPositions[num];
		}

		// Token: 0x0600390A RID: 14602 RVA: 0x001040EC File Offset: 0x001022EC
		public int GetFormationLine(int idx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetFormationLineInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetFormationLineInt32_hotfix.call(new object[]
				{
					this,
					idx
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 1;
			if (idx < 8)
			{
				num++;
				if (idx < 5)
				{
					num++;
					if (idx < 3)
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x0600390B RID: 14603 RVA: 0x0010418C File Offset: 0x0010238C
		public CombatActor GetHero()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHero_hotfix != null)
			{
				return (CombatActor)this.m_GetHero_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actors.Count <= 0)
			{
				return null;
			}
			CombatActor combatActor = this.m_actors[0];
			if (combatActor.IsHero())
			{
				return combatActor;
			}
			return null;
		}

		// Token: 0x0600390C RID: 14604 RVA: 0x00104228 File Offset: 0x00102428
		public List<CombatActor> GetActors()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetActors_hotfix != null)
			{
				return (List<CombatActor>)this.m_GetActors_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_actors;
		}

		// Token: 0x0600390D RID: 14605 RVA: 0x0010429C File Offset: 0x0010249C
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
			this.m_heroReceiveTotalDamage = 0;
			this.m_soldierReceiveTotalDamage = 0;
			this.m_heroApplyTotalDamage = 0;
			this.m_soldierApplyTotalDamage = 0;
			this.m_isCastAnyDamageSkill = false;
			this.m_isBeCriticalAttack = false;
			this.m_lastDamageBySkill = null;
			this.m_isTryApplyBuff = false;
			this.m_attachBuffSourceSkillInfo = null;
			if (this.m_heroSkillInfo == null)
			{
				this.m_doubleAttackBuffState = this.m_battleActor.BuffDoubleAttack();
			}
			else
			{
				this.m_doubleAttackBuffState = null;
			}
			this.ComputeHeroCriticalAttack();
			this.ComputeSoldierCriticalAttack();
			foreach (CombatActor combatActor in this.m_actors)
			{
				combatActor.EnterCombat();
			}
		}

		// Token: 0x0600390E RID: 14606 RVA: 0x001043C0 File Offset: 0x001025C0
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
			foreach (CombatActor combatActor in this.m_actors)
			{
				combatActor.StartCombat();
			}
		}

		// Token: 0x0600390F RID: 14607 RVA: 0x00104470 File Offset: 0x00102670
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
			foreach (CombatActor combatActor in this.m_actors)
			{
				combatActor.StopCombat();
			}
		}

		// Token: 0x06003910 RID: 14608 RVA: 0x00104520 File Offset: 0x00102720
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
			if (this.m_flyObjects.Count > 0)
			{
				return false;
			}
			foreach (CombatActor combatActor in this.m_actors)
			{
				if (!combatActor.CanStopCombat())
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06003911 RID: 14609 RVA: 0x001045FC File Offset: 0x001027FC
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
			DebugUtility.LogError(string.Format("CombatTeam {0} can not stop combat", this.m_teamNumber));
			if (this.m_flyObjects.Count > 0)
			{
				DebugUtility.LogError(string.Format("flyObjects count: {0}", this.m_flyObjects.Count));
			}
			foreach (CombatActor combatActor in this.m_actors)
			{
				combatActor.LogCanNotStopCombat();
			}
		}

		// Token: 0x06003912 RID: 14610 RVA: 0x00104700 File Offset: 0x00102900
		public bool CanReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanReturn_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CanReturn_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.IsAllAliveActorState(CombatActorState.FightEnd, CombatActorState.Return, CombatActorState.Stop) || !this.GetTargetTeam().HasAliveActor();
		}

		// Token: 0x06003913 RID: 14611 RVA: 0x00104790 File Offset: 0x00102990
		private bool HasAliveActor()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasAliveActor_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasAliveActor_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (CombatActor combatActor in this.m_actors)
			{
				if (!combatActor.IsDead())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06003914 RID: 14612 RVA: 0x0010485C File Offset: 0x00102A5C
		private int GetAliveActorCount()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAliveActorCount_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetAliveActorCount_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			foreach (CombatActor combatActor in this.m_actors)
			{
				if (!combatActor.IsDead())
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06003915 RID: 14613 RVA: 0x00104924 File Offset: 0x00102B24
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
			foreach (CombatActor combatActor in this.m_actors)
			{
				if (!combatActor.IsHero())
				{
					combatActor.SetGraphicSkillFade(fade);
				}
			}
			foreach (CombatFlyObject combatFlyObject in this.m_flyObjects)
			{
				if (!combatFlyObject.IsHero())
				{
					combatFlyObject.SetGraphicSkillFade(fade);
				}
			}
		}

		// Token: 0x06003916 RID: 14614 RVA: 0x00104A44 File Offset: 0x00102C44
		private bool IsAllAliveActorState(CombatActorState state1, CombatActorState state2, CombatActorState state3)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsAllAliveActorStateCombatActorStateCombatActorStateCombatActorState_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsAllAliveActorStateCombatActorStateCombatActorStateCombatActorState_hotfix.call(new object[]
				{
					this,
					state1,
					state2,
					state3
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (CombatActor combatActor in this.m_actors)
			{
				if (!combatActor.IsDead() && combatActor.State != state1 && combatActor.State != state2 && combatActor.State != state3)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06003917 RID: 14615 RVA: 0x00104B64 File Offset: 0x00102D64
		public CombatTeam GetTargetTeam()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTargetTeam_hotfix != null)
			{
				return (CombatTeam)this.m_GetTargetTeam_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_combat.GetTeam(1 - this.m_teamNumber);
		}

		// Token: 0x06003918 RID: 14616 RVA: 0x00104BE4 File Offset: 0x00102DE4
		public int ComputeSoldierTotalHealthPoint()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeSoldierTotalHealthPoint_hotfix != null)
			{
				return Convert.ToInt32(this.m_ComputeSoldierTotalHealthPoint_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			foreach (CombatActor combatActor in this.m_actors)
			{
				if (!combatActor.IsHero())
				{
					num += combatActor.HealthPoint;
				}
			}
			return num;
		}

		// Token: 0x06003919 RID: 14617 RVA: 0x00104CB0 File Offset: 0x00102EB0
		public ConfigDataSkillInfo GetLastDamageBySkill()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetLastDamageBySkill_hotfix != null)
			{
				return (ConfigDataSkillInfo)this.m_GetLastDamageBySkill_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_lastDamageBySkill;
		}

		// Token: 0x0600391A RID: 14618 RVA: 0x00104D24 File Offset: 0x00102F24
		public ConfigDataSkillInfo GetAttachBuffSourceSkillInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAttachBuffSourceSkillInfo_hotfix != null)
			{
				return (ConfigDataSkillInfo)this.m_GetAttachBuffSourceSkillInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_attachBuffSourceSkillInfo;
		}

		// Token: 0x0600391B RID: 14619 RVA: 0x00104D98 File Offset: 0x00102F98
		public BuffState GetDoubleAttackBuff()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDoubleAttackBuff_hotfix != null)
			{
				return (BuffState)this.m_GetDoubleAttackBuff_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_doubleAttackBuffState;
		}

		// Token: 0x17000F9F RID: 3999
		// (get) Token: 0x0600391C RID: 14620 RVA: 0x00104E0C File Offset: 0x0010300C
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

		// Token: 0x17000FA0 RID: 4000
		// (get) Token: 0x0600391D RID: 14621 RVA: 0x00104E80 File Offset: 0x00103080
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
				return this.m_teamNumber;
			}
		}

		// Token: 0x17000FA1 RID: 4001
		// (get) Token: 0x0600391E RID: 14622 RVA: 0x00104EF4 File Offset: 0x001030F4
		public BattleActor BattleActor
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_BattleActor_hotfix != null)
				{
					return (BattleActor)this.m_get_BattleActor_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_battleActor;
			}
		}

		// Token: 0x17000FA2 RID: 4002
		// (get) Token: 0x0600391F RID: 14623 RVA: 0x00104F68 File Offset: 0x00103168
		public ConfigDataHeroInfo HeroInfo
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_HeroInfo_hotfix != null)
				{
					return (ConfigDataHeroInfo)this.m_get_HeroInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_battleActor.HeroInfo;
			}
		}

		// Token: 0x17000FA3 RID: 4003
		// (get) Token: 0x06003920 RID: 14624 RVA: 0x00104FE0 File Offset: 0x001031E0
		public ConfigDataArmyInfo HeroArmyInfo
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_HeroArmyInfo_hotfix != null)
				{
					return (ConfigDataArmyInfo)this.m_get_HeroArmyInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_battleActor.HeroArmyInfo;
			}
		}

		// Token: 0x17000FA4 RID: 4004
		// (get) Token: 0x06003921 RID: 14625 RVA: 0x00105058 File Offset: 0x00103258
		public ConfigDataJobConnectionInfo JobConnectionInfo
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_JobConnectionInfo_hotfix != null)
				{
					return (ConfigDataJobConnectionInfo)this.m_get_JobConnectionInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_battleActor.JobConnectionInfo;
			}
		}

		// Token: 0x17000FA5 RID: 4005
		// (get) Token: 0x06003922 RID: 14626 RVA: 0x001050D0 File Offset: 0x001032D0
		public ConfigDataJobInfo JobInfo
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_JobInfo_hotfix != null)
				{
					return (ConfigDataJobInfo)this.m_get_JobInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_battleActor.JobInfo;
			}
		}

		// Token: 0x17000FA6 RID: 4006
		// (get) Token: 0x06003923 RID: 14627 RVA: 0x00105148 File Offset: 0x00103348
		public ConfigDataSoldierInfo SoldierInfo
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_SoldierInfo_hotfix != null)
				{
					return (ConfigDataSoldierInfo)this.m_get_SoldierInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_battleActor.SoldierInfo;
			}
		}

		// Token: 0x17000FA7 RID: 4007
		// (get) Token: 0x06003924 RID: 14628 RVA: 0x001051C0 File Offset: 0x001033C0
		public ConfigDataArmyInfo SoldierArmyInfo
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_SoldierArmyInfo_hotfix != null)
				{
					return (ConfigDataArmyInfo)this.m_get_SoldierArmyInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_battleActor.SoldierArmyInfo;
			}
		}

		// Token: 0x17000FA8 RID: 4008
		// (get) Token: 0x06003925 RID: 14629 RVA: 0x00105238 File Offset: 0x00103438
		public ConfigDataSkillInfo HeroSkill
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_HeroSkill_hotfix != null)
				{
					return (ConfigDataSkillInfo)this.m_get_HeroSkill_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_heroSkillInfo;
			}
		}

		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x06003926 RID: 14630 RVA: 0x001052AC File Offset: 0x001034AC
		public int HeroLevel
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_HeroLevel_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_HeroLevel_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_battleActor.HeroLevel;
			}
		}

		// Token: 0x17000FAA RID: 4010
		// (get) Token: 0x06003927 RID: 14631 RVA: 0x00105324 File Offset: 0x00103524
		public int HeroStar
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_HeroStar_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_HeroStar_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_battleActor.HeroStar;
			}
		}

		// Token: 0x17000FAB RID: 4011
		// (get) Token: 0x06003928 RID: 14632 RVA: 0x0010539C File Offset: 0x0010359C
		public int JobLevel
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_JobLevel_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_JobLevel_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_battleActor.JobLevel;
			}
		}

		// Token: 0x17000FAC RID: 4012
		// (get) Token: 0x06003929 RID: 14633 RVA: 0x00105414 File Offset: 0x00103614
		public bool ShouldHeroToHeroCriticalAttack
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_ShouldHeroToHeroCriticalAttack_hotfix != null)
				{
					return Convert.ToBoolean(this.m_get_ShouldHeroToHeroCriticalAttack_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_shouldHeroToHeroCriticalAttack;
			}
		}

		// Token: 0x17000FAD RID: 4013
		// (get) Token: 0x0600392A RID: 14634 RVA: 0x00105488 File Offset: 0x00103688
		public bool ShouldHeroToSoldierCriticalAttack
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_ShouldHeroToSoldierCriticalAttack_hotfix != null)
				{
					return Convert.ToBoolean(this.m_get_ShouldHeroToSoldierCriticalAttack_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_shouldHeroToSoldierCriticalAttack;
			}
		}

		// Token: 0x17000FAE RID: 4014
		// (get) Token: 0x0600392B RID: 14635 RVA: 0x001054FC File Offset: 0x001036FC
		public bool ShouldSoldierToHeroCriticalAttack
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_ShouldSoldierToHeroCriticalAttack_hotfix != null)
				{
					return Convert.ToBoolean(this.m_get_ShouldSoldierToHeroCriticalAttack_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_shouldSoldierToHeroCriticalAttack;
			}
		}

		// Token: 0x17000FAF RID: 4015
		// (get) Token: 0x0600392C RID: 14636 RVA: 0x00105570 File Offset: 0x00103770
		public bool ShouldSoldierToSoldierCriticalAttack
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_ShouldSoldierToSoldierCriticalAttack_hotfix != null)
				{
					return Convert.ToBoolean(this.m_get_ShouldSoldierToSoldierCriticalAttack_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_shouldSoldierToSoldierCriticalAttack;
			}
		}

		// Token: 0x17000FB0 RID: 4016
		// (get) Token: 0x0600392D RID: 14637 RVA: 0x001055E4 File Offset: 0x001037E4
		public bool IsCastAnyDamageSkill
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_IsCastAnyDamageSkill_hotfix != null)
				{
					return Convert.ToBoolean(this.m_get_IsCastAnyDamageSkill_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_isCastAnyDamageSkill;
			}
		}

		// Token: 0x17000FB1 RID: 4017
		// (get) Token: 0x0600392E RID: 14638 RVA: 0x00105658 File Offset: 0x00103858
		public bool IsBeCriticalAttack
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_IsBeCriticalAttack_hotfix != null)
				{
					return Convert.ToBoolean(this.m_get_IsBeCriticalAttack_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_isBeCriticalAttack;
			}
		}

		// Token: 0x17000FB2 RID: 4018
		// (get) Token: 0x0600392F RID: 14639 RVA: 0x001056CC File Offset: 0x001038CC
		public int HeroReceiveTotalDamage
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_HeroReceiveTotalDamage_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_HeroReceiveTotalDamage_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_heroReceiveTotalDamage;
			}
		}

		// Token: 0x17000FB3 RID: 4019
		// (get) Token: 0x06003930 RID: 14640 RVA: 0x00105740 File Offset: 0x00103940
		public int SoldierReceiveTotalDamage
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_SoldierReceiveTotalDamage_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_SoldierReceiveTotalDamage_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_soldierReceiveTotalDamage;
			}
		}

		// Token: 0x17000FB4 RID: 4020
		// (get) Token: 0x06003931 RID: 14641 RVA: 0x001057B4 File Offset: 0x001039B4
		public int HeroApplyTotalDamage
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_HeroApplyTotalDamage_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_HeroApplyTotalDamage_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_heroApplyTotalDamage;
			}
		}

		// Token: 0x17000FB5 RID: 4021
		// (get) Token: 0x06003932 RID: 14642 RVA: 0x00105828 File Offset: 0x00103A28
		public int SoldierApplyTotalDamage
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_SoldierApplyTotalDamage_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_SoldierApplyTotalDamage_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_soldierApplyTotalDamage;
			}
		}

		// Token: 0x17000FB6 RID: 4022
		// (get) Token: 0x06003933 RID: 14643 RVA: 0x0010589C File Offset: 0x00103A9C
		// (set) Token: 0x06003934 RID: 14644 RVA: 0x001058BC File Offset: 0x00103ABC
		[DoNotToLua]
		public CombatTeam.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new CombatTeam.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06003935 RID: 14645 RVA: 0x001058C8 File Offset: 0x00103AC8
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
					this.m_InitializeCombatInt32BattleActorConfigDataSkillInfo_hotfix = (luaObj.RawGet("Initialize") as LuaFunction);
					this.m_ComputeHeroCriticalAttack_hotfix = (luaObj.RawGet("ComputeHeroCriticalAttack") as LuaFunction);
					this.m_ComputeSoldierCriticalAttack_hotfix = (luaObj.RawGet("ComputeSoldierCriticalAttack") as LuaFunction);
					this.m_IsAttackHeroOnly_hotfix = (luaObj.RawGet("IsAttackHeroOnly") as LuaFunction);
					this.m_Tick_hotfix = (luaObj.RawGet("Tick") as LuaFunction);
					this.m_RemoveDeleted_hotfix = (luaObj.RawGet("RemoveDeleted") as LuaFunction);
					this.m_TickGraphicSingle_hotfix = (luaObj.RawGet("TickGraphic") as LuaFunction);
					this.m_Draw_hotfix = (luaObj.RawGet("Draw") as LuaFunction);
					this.m_PauseBoolean_hotfix = (luaObj.RawGet("Pause") as LuaFunction);
					this.m_GetColor_hotfix = (luaObj.RawGet("GetColor") as LuaFunction);
					this.m_CreateActorBoolean_hotfix = (luaObj.RawGet("CreateActor") as LuaFunction);
					this.m_CreateFlyObject_hotfix = (luaObj.RawGet("CreateFlyObject") as LuaFunction);
					this.m_RemoveAll_hotfix = (luaObj.RawGet("RemoveAll") as LuaFunction);
					this.m_OnMyActorCastSkillCombatActorConfigDataSkillInfo_hotfix = (luaObj.RawGet("OnMyActorCastSkill") as LuaFunction);
					this.m_OnMyActorAttackByCombatActorCombatActorConfigDataSkillInfoInt32BooleanArmyRelationData_hotfix = (luaObj.RawGet("OnMyActorAttackBy") as LuaFunction);
					this.m_OnMyActorReboundDamageCombatActorCombatActorConfigDataSkillInfoInt32_hotfix = (luaObj.RawGet("OnMyActorReboundDamage") as LuaFunction);
					this.m_OnMyActorDieCombatActor_hotfix = (luaObj.RawGet("OnMyActorDie") as LuaFunction);
					this.m_OnMyActorFightAgainCombatActor_hotfix = (luaObj.RawGet("OnMyActorFightAgain") as LuaFunction);
					this.m_GetFormationPositionInt32_hotfix = (luaObj.RawGet("GetFormationPosition") as LuaFunction);
					this.m_GetFormationLineInt32_hotfix = (luaObj.RawGet("GetFormationLine") as LuaFunction);
					this.m_GetHero_hotfix = (luaObj.RawGet("GetHero") as LuaFunction);
					this.m_GetActors_hotfix = (luaObj.RawGet("GetActors") as LuaFunction);
					this.m_EnterCombat_hotfix = (luaObj.RawGet("EnterCombat") as LuaFunction);
					this.m_StartCombat_hotfix = (luaObj.RawGet("StartCombat") as LuaFunction);
					this.m_StopCombat_hotfix = (luaObj.RawGet("StopCombat") as LuaFunction);
					this.m_CanStopCombat_hotfix = (luaObj.RawGet("CanStopCombat") as LuaFunction);
					this.m_LogCanNotStopCombat_hotfix = (luaObj.RawGet("LogCanNotStopCombat") as LuaFunction);
					this.m_CanReturn_hotfix = (luaObj.RawGet("CanReturn") as LuaFunction);
					this.m_HasAliveActor_hotfix = (luaObj.RawGet("HasAliveActor") as LuaFunction);
					this.m_GetAliveActorCount_hotfix = (luaObj.RawGet("GetAliveActorCount") as LuaFunction);
					this.m_SetGraphicSkillFadeBoolean_hotfix = (luaObj.RawGet("SetGraphicSkillFade") as LuaFunction);
					this.m_IsAllAliveActorStateCombatActorStateCombatActorStateCombatActorState_hotfix = (luaObj.RawGet("IsAllAliveActorState") as LuaFunction);
					this.m_GetTargetTeam_hotfix = (luaObj.RawGet("GetTargetTeam") as LuaFunction);
					this.m_ComputeSoldierTotalHealthPoint_hotfix = (luaObj.RawGet("ComputeSoldierTotalHealthPoint") as LuaFunction);
					this.m_GetLastDamageBySkill_hotfix = (luaObj.RawGet("GetLastDamageBySkill") as LuaFunction);
					this.m_GetAttachBuffSourceSkillInfo_hotfix = (luaObj.RawGet("GetAttachBuffSourceSkillInfo") as LuaFunction);
					this.m_GetDoubleAttackBuff_hotfix = (luaObj.RawGet("GetDoubleAttackBuff") as LuaFunction);
					this.m_get_Combat_hotfix = (luaObj.RawGet("get_Combat") as LuaFunction);
					this.m_get_TeamNumber_hotfix = (luaObj.RawGet("get_TeamNumber") as LuaFunction);
					this.m_get_BattleActor_hotfix = (luaObj.RawGet("get_BattleActor") as LuaFunction);
					this.m_get_HeroInfo_hotfix = (luaObj.RawGet("get_HeroInfo") as LuaFunction);
					this.m_get_HeroArmyInfo_hotfix = (luaObj.RawGet("get_HeroArmyInfo") as LuaFunction);
					this.m_get_JobConnectionInfo_hotfix = (luaObj.RawGet("get_JobConnectionInfo") as LuaFunction);
					this.m_get_JobInfo_hotfix = (luaObj.RawGet("get_JobInfo") as LuaFunction);
					this.m_get_SoldierInfo_hotfix = (luaObj.RawGet("get_SoldierInfo") as LuaFunction);
					this.m_get_SoldierArmyInfo_hotfix = (luaObj.RawGet("get_SoldierArmyInfo") as LuaFunction);
					this.m_get_HeroSkill_hotfix = (luaObj.RawGet("get_HeroSkill") as LuaFunction);
					this.m_get_HeroLevel_hotfix = (luaObj.RawGet("get_HeroLevel") as LuaFunction);
					this.m_get_HeroStar_hotfix = (luaObj.RawGet("get_HeroStar") as LuaFunction);
					this.m_get_JobLevel_hotfix = (luaObj.RawGet("get_JobLevel") as LuaFunction);
					this.m_get_ShouldHeroToHeroCriticalAttack_hotfix = (luaObj.RawGet("get_ShouldHeroToHeroCriticalAttack") as LuaFunction);
					this.m_get_ShouldHeroToSoldierCriticalAttack_hotfix = (luaObj.RawGet("get_ShouldHeroToSoldierCriticalAttack") as LuaFunction);
					this.m_get_ShouldSoldierToHeroCriticalAttack_hotfix = (luaObj.RawGet("get_ShouldSoldierToHeroCriticalAttack") as LuaFunction);
					this.m_get_ShouldSoldierToSoldierCriticalAttack_hotfix = (luaObj.RawGet("get_ShouldSoldierToSoldierCriticalAttack") as LuaFunction);
					this.m_get_IsCastAnyDamageSkill_hotfix = (luaObj.RawGet("get_IsCastAnyDamageSkill") as LuaFunction);
					this.m_get_IsBeCriticalAttack_hotfix = (luaObj.RawGet("get_IsBeCriticalAttack") as LuaFunction);
					this.m_get_HeroReceiveTotalDamage_hotfix = (luaObj.RawGet("get_HeroReceiveTotalDamage") as LuaFunction);
					this.m_get_SoldierReceiveTotalDamage_hotfix = (luaObj.RawGet("get_SoldierReceiveTotalDamage") as LuaFunction);
					this.m_get_HeroApplyTotalDamage_hotfix = (luaObj.RawGet("get_HeroApplyTotalDamage") as LuaFunction);
					this.m_get_SoldierApplyTotalDamage_hotfix = (luaObj.RawGet("get_SoldierApplyTotalDamage") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06003936 RID: 14646 RVA: 0x00105F70 File Offset: 0x00104170
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CombatTeam));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002BC7 RID: 11207
		private Combat m_combat;

		// Token: 0x04002BC8 RID: 11208
		private int m_teamNumber;

		// Token: 0x04002BC9 RID: 11209
		private BattleActor m_battleActor;

		// Token: 0x04002BCA RID: 11210
		private List<CombatActor> m_actors;

		// Token: 0x04002BCB RID: 11211
		private List<CombatFlyObject> m_flyObjects;

		// Token: 0x04002BCC RID: 11212
		private static Position2i[] s_formationPositions;

		// Token: 0x04002BCD RID: 11213
		private ConfigDataSkillInfo m_heroSkillInfo;

		// Token: 0x04002BCE RID: 11214
		private bool m_shouldHeroToHeroCriticalAttack;

		// Token: 0x04002BCF RID: 11215
		private bool m_shouldHeroToSoldierCriticalAttack;

		// Token: 0x04002BD0 RID: 11216
		private bool m_shouldSoldierToHeroCriticalAttack;

		// Token: 0x04002BD1 RID: 11217
		private bool m_shouldSoldierToSoldierCriticalAttack;

		// Token: 0x04002BD2 RID: 11218
		private bool m_isCastAnyDamageSkill;

		// Token: 0x04002BD3 RID: 11219
		private bool m_isBeCriticalAttack;

		// Token: 0x04002BD4 RID: 11220
		private ConfigDataSkillInfo m_lastDamageBySkill;

		// Token: 0x04002BD5 RID: 11221
		private int m_heroReceiveTotalDamage;

		// Token: 0x04002BD6 RID: 11222
		private int m_soldierReceiveTotalDamage;

		// Token: 0x04002BD7 RID: 11223
		private int m_heroApplyTotalDamage;

		// Token: 0x04002BD8 RID: 11224
		private int m_soldierApplyTotalDamage;

		// Token: 0x04002BD9 RID: 11225
		private bool m_isTryApplyBuff;

		// Token: 0x04002BDA RID: 11226
		private ConfigDataSkillInfo m_attachBuffSourceSkillInfo;

		// Token: 0x04002BDB RID: 11227
		private BuffState m_doubleAttackBuffState;

		// Token: 0x04002BDC RID: 11228
		[DoNotToLua]
		private CombatTeam.LuaExportHelper luaExportHelper;

		// Token: 0x04002BDD RID: 11229
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002BDE RID: 11230
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002BDF RID: 11231
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04002BE0 RID: 11232
		private LuaFunction m_InitializeCombatInt32BattleActorConfigDataSkillInfo_hotfix;

		// Token: 0x04002BE1 RID: 11233
		private LuaFunction m_ComputeHeroCriticalAttack_hotfix;

		// Token: 0x04002BE2 RID: 11234
		private LuaFunction m_ComputeSoldierCriticalAttack_hotfix;

		// Token: 0x04002BE3 RID: 11235
		private LuaFunction m_IsAttackHeroOnly_hotfix;

		// Token: 0x04002BE4 RID: 11236
		private LuaFunction m_Tick_hotfix;

		// Token: 0x04002BE5 RID: 11237
		private LuaFunction m_RemoveDeleted_hotfix;

		// Token: 0x04002BE6 RID: 11238
		private LuaFunction m_TickGraphicSingle_hotfix;

		// Token: 0x04002BE7 RID: 11239
		private LuaFunction m_Draw_hotfix;

		// Token: 0x04002BE8 RID: 11240
		private LuaFunction m_PauseBoolean_hotfix;

		// Token: 0x04002BE9 RID: 11241
		private LuaFunction m_GetColor_hotfix;

		// Token: 0x04002BEA RID: 11242
		private LuaFunction m_CreateActorBoolean_hotfix;

		// Token: 0x04002BEB RID: 11243
		private LuaFunction m_CreateFlyObject_hotfix;

		// Token: 0x04002BEC RID: 11244
		private LuaFunction m_RemoveAll_hotfix;

		// Token: 0x04002BED RID: 11245
		private LuaFunction m_OnMyActorCastSkillCombatActorConfigDataSkillInfo_hotfix;

		// Token: 0x04002BEE RID: 11246
		private LuaFunction m_OnMyActorAttackByCombatActorCombatActorConfigDataSkillInfoInt32BooleanArmyRelationData_hotfix;

		// Token: 0x04002BEF RID: 11247
		private LuaFunction m_OnMyActorReboundDamageCombatActorCombatActorConfigDataSkillInfoInt32_hotfix;

		// Token: 0x04002BF0 RID: 11248
		private LuaFunction m_OnMyActorDieCombatActor_hotfix;

		// Token: 0x04002BF1 RID: 11249
		private LuaFunction m_OnMyActorFightAgainCombatActor_hotfix;

		// Token: 0x04002BF2 RID: 11250
		private LuaFunction m_GetFormationPositionInt32_hotfix;

		// Token: 0x04002BF3 RID: 11251
		private LuaFunction m_GetFormationLineInt32_hotfix;

		// Token: 0x04002BF4 RID: 11252
		private LuaFunction m_GetHero_hotfix;

		// Token: 0x04002BF5 RID: 11253
		private LuaFunction m_GetActors_hotfix;

		// Token: 0x04002BF6 RID: 11254
		private LuaFunction m_EnterCombat_hotfix;

		// Token: 0x04002BF7 RID: 11255
		private LuaFunction m_StartCombat_hotfix;

		// Token: 0x04002BF8 RID: 11256
		private LuaFunction m_StopCombat_hotfix;

		// Token: 0x04002BF9 RID: 11257
		private LuaFunction m_CanStopCombat_hotfix;

		// Token: 0x04002BFA RID: 11258
		private LuaFunction m_LogCanNotStopCombat_hotfix;

		// Token: 0x04002BFB RID: 11259
		private LuaFunction m_CanReturn_hotfix;

		// Token: 0x04002BFC RID: 11260
		private LuaFunction m_HasAliveActor_hotfix;

		// Token: 0x04002BFD RID: 11261
		private LuaFunction m_GetAliveActorCount_hotfix;

		// Token: 0x04002BFE RID: 11262
		private LuaFunction m_SetGraphicSkillFadeBoolean_hotfix;

		// Token: 0x04002BFF RID: 11263
		private LuaFunction m_IsAllAliveActorStateCombatActorStateCombatActorStateCombatActorState_hotfix;

		// Token: 0x04002C00 RID: 11264
		private LuaFunction m_GetTargetTeam_hotfix;

		// Token: 0x04002C01 RID: 11265
		private LuaFunction m_ComputeSoldierTotalHealthPoint_hotfix;

		// Token: 0x04002C02 RID: 11266
		private LuaFunction m_GetLastDamageBySkill_hotfix;

		// Token: 0x04002C03 RID: 11267
		private LuaFunction m_GetAttachBuffSourceSkillInfo_hotfix;

		// Token: 0x04002C04 RID: 11268
		private LuaFunction m_GetDoubleAttackBuff_hotfix;

		// Token: 0x04002C05 RID: 11269
		private LuaFunction m_get_Combat_hotfix;

		// Token: 0x04002C06 RID: 11270
		private LuaFunction m_get_TeamNumber_hotfix;

		// Token: 0x04002C07 RID: 11271
		private LuaFunction m_get_BattleActor_hotfix;

		// Token: 0x04002C08 RID: 11272
		private LuaFunction m_get_HeroInfo_hotfix;

		// Token: 0x04002C09 RID: 11273
		private LuaFunction m_get_HeroArmyInfo_hotfix;

		// Token: 0x04002C0A RID: 11274
		private LuaFunction m_get_JobConnectionInfo_hotfix;

		// Token: 0x04002C0B RID: 11275
		private LuaFunction m_get_JobInfo_hotfix;

		// Token: 0x04002C0C RID: 11276
		private LuaFunction m_get_SoldierInfo_hotfix;

		// Token: 0x04002C0D RID: 11277
		private LuaFunction m_get_SoldierArmyInfo_hotfix;

		// Token: 0x04002C0E RID: 11278
		private LuaFunction m_get_HeroSkill_hotfix;

		// Token: 0x04002C0F RID: 11279
		private LuaFunction m_get_HeroLevel_hotfix;

		// Token: 0x04002C10 RID: 11280
		private LuaFunction m_get_HeroStar_hotfix;

		// Token: 0x04002C11 RID: 11281
		private LuaFunction m_get_JobLevel_hotfix;

		// Token: 0x04002C12 RID: 11282
		private LuaFunction m_get_ShouldHeroToHeroCriticalAttack_hotfix;

		// Token: 0x04002C13 RID: 11283
		private LuaFunction m_get_ShouldHeroToSoldierCriticalAttack_hotfix;

		// Token: 0x04002C14 RID: 11284
		private LuaFunction m_get_ShouldSoldierToHeroCriticalAttack_hotfix;

		// Token: 0x04002C15 RID: 11285
		private LuaFunction m_get_ShouldSoldierToSoldierCriticalAttack_hotfix;

		// Token: 0x04002C16 RID: 11286
		private LuaFunction m_get_IsCastAnyDamageSkill_hotfix;

		// Token: 0x04002C17 RID: 11287
		private LuaFunction m_get_IsBeCriticalAttack_hotfix;

		// Token: 0x04002C18 RID: 11288
		private LuaFunction m_get_HeroReceiveTotalDamage_hotfix;

		// Token: 0x04002C19 RID: 11289
		private LuaFunction m_get_SoldierReceiveTotalDamage_hotfix;

		// Token: 0x04002C1A RID: 11290
		private LuaFunction m_get_HeroApplyTotalDamage_hotfix;

		// Token: 0x04002C1B RID: 11291
		private LuaFunction m_get_SoldierApplyTotalDamage_hotfix;

		// Token: 0x020003BF RID: 959
		public class LuaExportHelper
		{
			// Token: 0x06003937 RID: 14647 RVA: 0x00105FD8 File Offset: 0x001041D8
			public LuaExportHelper(CombatTeam owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17000FB7 RID: 4023
			// (get) Token: 0x06003938 RID: 14648 RVA: 0x00105FE8 File Offset: 0x001041E8
			// (set) Token: 0x06003939 RID: 14649 RVA: 0x00105FF8 File Offset: 0x001041F8
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

			// Token: 0x17000FB8 RID: 4024
			// (get) Token: 0x0600393A RID: 14650 RVA: 0x00106008 File Offset: 0x00104208
			// (set) Token: 0x0600393B RID: 14651 RVA: 0x00106018 File Offset: 0x00104218
			public int m_teamNumber
			{
				get
				{
					return this.m_owner.m_teamNumber;
				}
				set
				{
					this.m_owner.m_teamNumber = value;
				}
			}

			// Token: 0x17000FB9 RID: 4025
			// (get) Token: 0x0600393C RID: 14652 RVA: 0x00106028 File Offset: 0x00104228
			// (set) Token: 0x0600393D RID: 14653 RVA: 0x00106038 File Offset: 0x00104238
			public BattleActor m_battleActor
			{
				get
				{
					return this.m_owner.m_battleActor;
				}
				set
				{
					this.m_owner.m_battleActor = value;
				}
			}

			// Token: 0x17000FBA RID: 4026
			// (get) Token: 0x0600393E RID: 14654 RVA: 0x00106048 File Offset: 0x00104248
			// (set) Token: 0x0600393F RID: 14655 RVA: 0x00106058 File Offset: 0x00104258
			public List<CombatActor> m_actors
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

			// Token: 0x17000FBB RID: 4027
			// (get) Token: 0x06003940 RID: 14656 RVA: 0x00106068 File Offset: 0x00104268
			// (set) Token: 0x06003941 RID: 14657 RVA: 0x00106078 File Offset: 0x00104278
			public List<CombatFlyObject> m_flyObjects
			{
				get
				{
					return this.m_owner.m_flyObjects;
				}
				set
				{
					this.m_owner.m_flyObjects = value;
				}
			}

			// Token: 0x17000FBC RID: 4028
			// (get) Token: 0x06003942 RID: 14658 RVA: 0x00106088 File Offset: 0x00104288
			// (set) Token: 0x06003943 RID: 14659 RVA: 0x00106090 File Offset: 0x00104290
			public static Position2i[] s_formationPositions
			{
				get
				{
					return CombatTeam.s_formationPositions;
				}
				set
				{
					CombatTeam.s_formationPositions = value;
				}
			}

			// Token: 0x17000FBD RID: 4029
			// (get) Token: 0x06003944 RID: 14660 RVA: 0x00106098 File Offset: 0x00104298
			// (set) Token: 0x06003945 RID: 14661 RVA: 0x001060A8 File Offset: 0x001042A8
			public ConfigDataSkillInfo m_heroSkillInfo
			{
				get
				{
					return this.m_owner.m_heroSkillInfo;
				}
				set
				{
					this.m_owner.m_heroSkillInfo = value;
				}
			}

			// Token: 0x17000FBE RID: 4030
			// (get) Token: 0x06003946 RID: 14662 RVA: 0x001060B8 File Offset: 0x001042B8
			// (set) Token: 0x06003947 RID: 14663 RVA: 0x001060C8 File Offset: 0x001042C8
			public bool m_shouldHeroToHeroCriticalAttack
			{
				get
				{
					return this.m_owner.m_shouldHeroToHeroCriticalAttack;
				}
				set
				{
					this.m_owner.m_shouldHeroToHeroCriticalAttack = value;
				}
			}

			// Token: 0x17000FBF RID: 4031
			// (get) Token: 0x06003948 RID: 14664 RVA: 0x001060D8 File Offset: 0x001042D8
			// (set) Token: 0x06003949 RID: 14665 RVA: 0x001060E8 File Offset: 0x001042E8
			public bool m_shouldHeroToSoldierCriticalAttack
			{
				get
				{
					return this.m_owner.m_shouldHeroToSoldierCriticalAttack;
				}
				set
				{
					this.m_owner.m_shouldHeroToSoldierCriticalAttack = value;
				}
			}

			// Token: 0x17000FC0 RID: 4032
			// (get) Token: 0x0600394A RID: 14666 RVA: 0x001060F8 File Offset: 0x001042F8
			// (set) Token: 0x0600394B RID: 14667 RVA: 0x00106108 File Offset: 0x00104308
			public bool m_shouldSoldierToHeroCriticalAttack
			{
				get
				{
					return this.m_owner.m_shouldSoldierToHeroCriticalAttack;
				}
				set
				{
					this.m_owner.m_shouldSoldierToHeroCriticalAttack = value;
				}
			}

			// Token: 0x17000FC1 RID: 4033
			// (get) Token: 0x0600394C RID: 14668 RVA: 0x00106118 File Offset: 0x00104318
			// (set) Token: 0x0600394D RID: 14669 RVA: 0x00106128 File Offset: 0x00104328
			public bool m_shouldSoldierToSoldierCriticalAttack
			{
				get
				{
					return this.m_owner.m_shouldSoldierToSoldierCriticalAttack;
				}
				set
				{
					this.m_owner.m_shouldSoldierToSoldierCriticalAttack = value;
				}
			}

			// Token: 0x17000FC2 RID: 4034
			// (get) Token: 0x0600394E RID: 14670 RVA: 0x00106138 File Offset: 0x00104338
			// (set) Token: 0x0600394F RID: 14671 RVA: 0x00106148 File Offset: 0x00104348
			public bool m_isCastAnyDamageSkill
			{
				get
				{
					return this.m_owner.m_isCastAnyDamageSkill;
				}
				set
				{
					this.m_owner.m_isCastAnyDamageSkill = value;
				}
			}

			// Token: 0x17000FC3 RID: 4035
			// (get) Token: 0x06003950 RID: 14672 RVA: 0x00106158 File Offset: 0x00104358
			// (set) Token: 0x06003951 RID: 14673 RVA: 0x00106168 File Offset: 0x00104368
			public bool m_isBeCriticalAttack
			{
				get
				{
					return this.m_owner.m_isBeCriticalAttack;
				}
				set
				{
					this.m_owner.m_isBeCriticalAttack = value;
				}
			}

			// Token: 0x17000FC4 RID: 4036
			// (get) Token: 0x06003952 RID: 14674 RVA: 0x00106178 File Offset: 0x00104378
			// (set) Token: 0x06003953 RID: 14675 RVA: 0x00106188 File Offset: 0x00104388
			public ConfigDataSkillInfo m_lastDamageBySkill
			{
				get
				{
					return this.m_owner.m_lastDamageBySkill;
				}
				set
				{
					this.m_owner.m_lastDamageBySkill = value;
				}
			}

			// Token: 0x17000FC5 RID: 4037
			// (get) Token: 0x06003954 RID: 14676 RVA: 0x00106198 File Offset: 0x00104398
			// (set) Token: 0x06003955 RID: 14677 RVA: 0x001061A8 File Offset: 0x001043A8
			public int m_heroReceiveTotalDamage
			{
				get
				{
					return this.m_owner.m_heroReceiveTotalDamage;
				}
				set
				{
					this.m_owner.m_heroReceiveTotalDamage = value;
				}
			}

			// Token: 0x17000FC6 RID: 4038
			// (get) Token: 0x06003956 RID: 14678 RVA: 0x001061B8 File Offset: 0x001043B8
			// (set) Token: 0x06003957 RID: 14679 RVA: 0x001061C8 File Offset: 0x001043C8
			public int m_soldierReceiveTotalDamage
			{
				get
				{
					return this.m_owner.m_soldierReceiveTotalDamage;
				}
				set
				{
					this.m_owner.m_soldierReceiveTotalDamage = value;
				}
			}

			// Token: 0x17000FC7 RID: 4039
			// (get) Token: 0x06003958 RID: 14680 RVA: 0x001061D8 File Offset: 0x001043D8
			// (set) Token: 0x06003959 RID: 14681 RVA: 0x001061E8 File Offset: 0x001043E8
			public int m_heroApplyTotalDamage
			{
				get
				{
					return this.m_owner.m_heroApplyTotalDamage;
				}
				set
				{
					this.m_owner.m_heroApplyTotalDamage = value;
				}
			}

			// Token: 0x17000FC8 RID: 4040
			// (get) Token: 0x0600395A RID: 14682 RVA: 0x001061F8 File Offset: 0x001043F8
			// (set) Token: 0x0600395B RID: 14683 RVA: 0x00106208 File Offset: 0x00104408
			public int m_soldierApplyTotalDamage
			{
				get
				{
					return this.m_owner.m_soldierApplyTotalDamage;
				}
				set
				{
					this.m_owner.m_soldierApplyTotalDamage = value;
				}
			}

			// Token: 0x17000FC9 RID: 4041
			// (get) Token: 0x0600395C RID: 14684 RVA: 0x00106218 File Offset: 0x00104418
			// (set) Token: 0x0600395D RID: 14685 RVA: 0x00106228 File Offset: 0x00104428
			public bool m_isTryApplyBuff
			{
				get
				{
					return this.m_owner.m_isTryApplyBuff;
				}
				set
				{
					this.m_owner.m_isTryApplyBuff = value;
				}
			}

			// Token: 0x17000FCA RID: 4042
			// (get) Token: 0x0600395E RID: 14686 RVA: 0x00106238 File Offset: 0x00104438
			// (set) Token: 0x0600395F RID: 14687 RVA: 0x00106248 File Offset: 0x00104448
			public ConfigDataSkillInfo m_attachBuffSourceSkillInfo
			{
				get
				{
					return this.m_owner.m_attachBuffSourceSkillInfo;
				}
				set
				{
					this.m_owner.m_attachBuffSourceSkillInfo = value;
				}
			}

			// Token: 0x17000FCB RID: 4043
			// (get) Token: 0x06003960 RID: 14688 RVA: 0x00106258 File Offset: 0x00104458
			// (set) Token: 0x06003961 RID: 14689 RVA: 0x00106268 File Offset: 0x00104468
			public BuffState m_doubleAttackBuffState
			{
				get
				{
					return this.m_owner.m_doubleAttackBuffState;
				}
				set
				{
					this.m_owner.m_doubleAttackBuffState = value;
				}
			}

			// Token: 0x06003962 RID: 14690 RVA: 0x00106278 File Offset: 0x00104478
			public void ComputeHeroCriticalAttack()
			{
				this.m_owner.ComputeHeroCriticalAttack();
			}

			// Token: 0x06003963 RID: 14691 RVA: 0x00106288 File Offset: 0x00104488
			public void ComputeSoldierCriticalAttack()
			{
				this.m_owner.ComputeSoldierCriticalAttack();
			}

			// Token: 0x06003964 RID: 14692 RVA: 0x00106298 File Offset: 0x00104498
			public bool HasAliveActor()
			{
				return this.m_owner.HasAliveActor();
			}

			// Token: 0x06003965 RID: 14693 RVA: 0x001062A8 File Offset: 0x001044A8
			public int GetAliveActorCount()
			{
				return this.m_owner.GetAliveActorCount();
			}

			// Token: 0x06003966 RID: 14694 RVA: 0x001062B8 File Offset: 0x001044B8
			public bool IsAllAliveActorState(CombatActorState state1, CombatActorState state2, CombatActorState state3)
			{
				return this.m_owner.IsAllAliveActorState(state1, state2, state3);
			}

			// Token: 0x04002C1C RID: 11292
			private CombatTeam m_owner;
		}
	}
}
