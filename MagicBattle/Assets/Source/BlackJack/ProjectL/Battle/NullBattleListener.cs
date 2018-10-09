using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using FixMath.NET;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x020003C8 RID: 968
	[HotFix]
	public class NullBattleListener : IBattleListener
	{
		// Token: 0x060039E2 RID: 14818 RVA: 0x00106E90 File Offset: 0x00105090
		public NullBattleListener()
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

		// Token: 0x060039E3 RID: 14819 RVA: 0x00106EF8 File Offset: 0x001050F8
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
		}

		// Token: 0x060039E4 RID: 14820 RVA: 0x00106F78 File Offset: 0x00105178
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
		}

		// Token: 0x060039E5 RID: 14821 RVA: 0x00106FE8 File Offset: 0x001051E8
		public void OnBattleActorActive(BattleActor a, bool autoSelect)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorActiveBattleActorBoolean_hotfix != null)
			{
				this.m_OnBattleActorActiveBattleActorBoolean_hotfix.call(new object[]
				{
					this,
					a,
					autoSelect
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060039E6 RID: 14822 RVA: 0x00107068 File Offset: 0x00105268
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
		}

		// Token: 0x060039E7 RID: 14823 RVA: 0x001070D8 File Offset: 0x001052D8
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
		}

		// Token: 0x060039E8 RID: 14824 RVA: 0x00107148 File Offset: 0x00105348
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
		}

		// Token: 0x060039E9 RID: 14825 RVA: 0x001071D8 File Offset: 0x001053D8
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
		}

		// Token: 0x060039EA RID: 14826 RVA: 0x00107278 File Offset: 0x00105478
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
		}

		// Token: 0x060039EB RID: 14827 RVA: 0x00107308 File Offset: 0x00105508
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
		}

		// Token: 0x060039EC RID: 14828 RVA: 0x001073A8 File Offset: 0x001055A8
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
		}

		// Token: 0x060039ED RID: 14829 RVA: 0x00107428 File Offset: 0x00105628
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
		}

		// Token: 0x060039EE RID: 14830 RVA: 0x001074B8 File Offset: 0x001056B8
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
		}

		// Token: 0x060039EF RID: 14831 RVA: 0x00107548 File Offset: 0x00105748
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
		}

		// Token: 0x060039F0 RID: 14832 RVA: 0x001075C8 File Offset: 0x001057C8
		public void OnBattleActorSkill(BattleActor a, ConfigDataSkillInfo skillInfo, GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorSkillBattleActorConfigDataSkillInfoGridPosition_hotfix != null)
			{
				this.m_OnBattleActorSkillBattleActorConfigDataSkillInfoGridPosition_hotfix.call(new object[]
				{
					this,
					a,
					skillInfo,
					p
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060039F1 RID: 14833 RVA: 0x00107658 File Offset: 0x00105858
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
		}

		// Token: 0x060039F2 RID: 14834 RVA: 0x001076E8 File Offset: 0x001058E8
		public void OnBattleActorSkillHit(BattleActor a, ConfigDataSkillInfo skillInfo, int heroHpModify, int soldierHpModify, DamageNumberType damageNumberType, bool isRebound)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorSkillHitBattleActorConfigDataSkillInfoInt32Int32DamageNumberTypeBoolean_hotfix != null)
			{
				this.m_OnBattleActorSkillHitBattleActorConfigDataSkillInfoInt32Int32DamageNumberTypeBoolean_hotfix.call(new object[]
				{
					this,
					a,
					skillInfo,
					heroHpModify,
					soldierHpModify,
					damageNumberType,
					isRebound
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060039F3 RID: 14835 RVA: 0x001077A8 File Offset: 0x001059A8
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
		}

		// Token: 0x060039F4 RID: 14836 RVA: 0x00107838 File Offset: 0x00105A38
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
		}

		// Token: 0x060039F5 RID: 14837 RVA: 0x001078B8 File Offset: 0x00105AB8
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
		}

		// Token: 0x060039F6 RID: 14838 RVA: 0x00107938 File Offset: 0x00105B38
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
		}

		// Token: 0x060039F7 RID: 14839 RVA: 0x001079A8 File Offset: 0x00105BA8
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
		}

		// Token: 0x060039F8 RID: 14840 RVA: 0x00107A38 File Offset: 0x00105C38
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
		}

		// Token: 0x060039F9 RID: 14841 RVA: 0x00107AE8 File Offset: 0x00105CE8
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
		}

		// Token: 0x060039FA RID: 14842 RVA: 0x00107B98 File Offset: 0x00105D98
		public void OnBattleActorTeleport(BattleActor a, ConfigDataSkillInfo skillInfo, GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorTeleportBattleActorConfigDataSkillInfoGridPosition_hotfix != null)
			{
				this.m_OnBattleActorTeleportBattleActorConfigDataSkillInfoGridPosition_hotfix.call(new object[]
				{
					this,
					a,
					skillInfo,
					p
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060039FB RID: 14843 RVA: 0x00107C28 File Offset: 0x00105E28
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
		}

		// Token: 0x060039FC RID: 14844 RVA: 0x00107CA8 File Offset: 0x00105EA8
		public void OnBattleActorDie(BattleActor actor, bool isAfterCombat)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorDieBattleActorBoolean_hotfix != null)
			{
				this.m_OnBattleActorDieBattleActorBoolean_hotfix.call(new object[]
				{
					this,
					actor,
					isAfterCombat
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060039FD RID: 14845 RVA: 0x00107D28 File Offset: 0x00105F28
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
		}

		// Token: 0x060039FE RID: 14846 RVA: 0x00107DB8 File Offset: 0x00105FB8
		public void OnBattleActorDisappear(BattleActor actor, int effectType, string fxName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorDisappearBattleActorInt32String_hotfix != null)
			{
				this.m_OnBattleActorDisappearBattleActorInt32String_hotfix.call(new object[]
				{
					this,
					actor,
					effectType,
					fxName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060039FF RID: 14847 RVA: 0x00107E48 File Offset: 0x00106048
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
		}

		// Token: 0x06003A00 RID: 14848 RVA: 0x00107EB8 File Offset: 0x001060B8
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
		}

		// Token: 0x06003A01 RID: 14849 RVA: 0x00107F28 File Offset: 0x00106128
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
		}

		// Token: 0x06003A02 RID: 14850 RVA: 0x00107FB8 File Offset: 0x001061B8
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
		}

		// Token: 0x06003A03 RID: 14851 RVA: 0x00108028 File Offset: 0x00106228
		public void OnBattleActorGainBattleTreasure(BattleActor a, ConfigDataBattleTreasureInfo t)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleActorGainBattleTreasureBattleActorConfigDataBattleTreasureInfo_hotfix != null)
			{
				this.m_OnBattleActorGainBattleTreasureBattleActorConfigDataBattleTreasureInfo_hotfix.call(new object[]
				{
					this,
					a,
					t
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06003A04 RID: 14852 RVA: 0x001080A8 File Offset: 0x001062A8
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
		}

		// Token: 0x06003A05 RID: 14853 RVA: 0x00108128 File Offset: 0x00106328
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
		}

		// Token: 0x06003A06 RID: 14854 RVA: 0x001081A8 File Offset: 0x001063A8
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
		}

		// Token: 0x06003A07 RID: 14855 RVA: 0x00108238 File Offset: 0x00106438
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
		}

		// Token: 0x06003A08 RID: 14856 RVA: 0x00108298 File Offset: 0x00106498
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
		}

		// Token: 0x06003A09 RID: 14857 RVA: 0x00108328 File Offset: 0x00106528
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
		}

		// Token: 0x06003A0A RID: 14858 RVA: 0x00108388 File Offset: 0x00106588
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
		}

		// Token: 0x06003A0B RID: 14859 RVA: 0x00108448 File Offset: 0x00106648
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
		}

		// Token: 0x06003A0C RID: 14860 RVA: 0x001084B8 File Offset: 0x001066B8
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
		}

		// Token: 0x06003A0D RID: 14861 RVA: 0x00108538 File Offset: 0x00106738
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
		}

		// Token: 0x06003A0E RID: 14862 RVA: 0x001085B8 File Offset: 0x001067B8
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
		}

		// Token: 0x06003A0F RID: 14863 RVA: 0x00108628 File Offset: 0x00106828
		public void OnCombatActorSkill(CombatActor a, ConfigDataSkillInfo skillInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCombatActorSkillCombatActorConfigDataSkillInfo_hotfix != null)
			{
				this.m_OnCombatActorSkillCombatActorConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					a,
					skillInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06003A10 RID: 14864 RVA: 0x001086A8 File Offset: 0x001068A8
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
		}

		// Token: 0x06003A11 RID: 14865 RVA: 0x00108768 File Offset: 0x00106968
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
		}

		// Token: 0x06003A12 RID: 14866 RVA: 0x001087D8 File Offset: 0x001069D8
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
		}

		// Token: 0x06003A13 RID: 14867 RVA: 0x00108868 File Offset: 0x00106A68
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
		}

		// Token: 0x06003A14 RID: 14868 RVA: 0x001088E8 File Offset: 0x00106AE8
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
		}

		// Token: 0x06003A15 RID: 14869 RVA: 0x00108948 File Offset: 0x00106B48
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
		}

		// Token: 0x06003A16 RID: 14870 RVA: 0x001089B8 File Offset: 0x00106BB8
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
		}

		// Token: 0x06003A17 RID: 14871 RVA: 0x00108A28 File Offset: 0x00106C28
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
		}

		// Token: 0x06003A18 RID: 14872 RVA: 0x00108A88 File Offset: 0x00106C88
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
		}

		// Token: 0x06003A19 RID: 14873 RVA: 0x00108B08 File Offset: 0x00106D08
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
		}

		// Token: 0x06003A1A RID: 14874 RVA: 0x00108B78 File Offset: 0x00106D78
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
		}

		// Token: 0x06003A1B RID: 14875 RVA: 0x00108BE8 File Offset: 0x00106DE8
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
		}

		// Token: 0x06003A1C RID: 14876 RVA: 0x00108C58 File Offset: 0x00106E58
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
		}

		// Token: 0x06003A1D RID: 14877 RVA: 0x00108CD8 File Offset: 0x00106ED8
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
		}

		// Token: 0x06003A1E RID: 14878 RVA: 0x00108D48 File Offset: 0x00106F48
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
		}

		// Token: 0x06003A1F RID: 14879 RVA: 0x00108DC8 File Offset: 0x00106FC8
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
			return null;
		}

		// Token: 0x06003A20 RID: 14880 RVA: 0x00108E58 File Offset: 0x00107058
		public void DestroyCombatGraphic(IBattleGraphic model)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroyCombatGraphicIBattleGraphic_hotfix != null)
			{
				this.m_DestroyCombatGraphicIBattleGraphic_hotfix.call(new object[]
				{
					this,
					model
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06003A21 RID: 14881 RVA: 0x00108EC8 File Offset: 0x001070C8
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
			return null;
		}

		// Token: 0x06003A22 RID: 14882 RVA: 0x00108F58 File Offset: 0x00107158
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
		}

		// Token: 0x06003A23 RID: 14883 RVA: 0x00108FC8 File Offset: 0x001071C8
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
		}

		// Token: 0x06003A24 RID: 14884 RVA: 0x00109058 File Offset: 0x00107258
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
		}

		// Token: 0x06003A25 RID: 14885 RVA: 0x00109108 File Offset: 0x00107308
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
		}

		// Token: 0x06003A26 RID: 14886 RVA: 0x00109168 File Offset: 0x00107368
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
		}

		// Token: 0x06003A27 RID: 14887 RVA: 0x001091D8 File Offset: 0x001073D8
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
		}

		// Token: 0x06003A28 RID: 14888 RVA: 0x00109258 File Offset: 0x00107458
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
		}

		// Token: 0x06003A29 RID: 14889 RVA: 0x001092E8 File Offset: 0x001074E8
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
		}

		// Token: 0x06003A2A RID: 14890 RVA: 0x00109358 File Offset: 0x00107558
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
		}

		// Token: 0x06003A2B RID: 14891 RVA: 0x001093D8 File Offset: 0x001075D8
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
		}

		// Token: 0x06003A2C RID: 14892 RVA: 0x00109478 File Offset: 0x00107678
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
		}

		// Token: 0x17000FD4 RID: 4052
		// (get) Token: 0x06003A2D RID: 14893 RVA: 0x001094F8 File Offset: 0x001076F8
		// (set) Token: 0x06003A2E RID: 14894 RVA: 0x00109518 File Offset: 0x00107718
		[DoNotToLua]
		public NullBattleListener.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new NullBattleListener.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06003A2F RID: 14895 RVA: 0x00109524 File Offset: 0x00107724
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
					this.m_OnCombatActorSkillCombatActorConfigDataSkillInfo_hotfix = (luaObj.RawGet("OnCombatActorSkill") as LuaFunction);
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
					this.m_DrawLineVector2iVector2iColori_hotfix = (luaObj.RawGet("DrawLine") as LuaFunction);
					this.m_DrawLineVector2iFix64Vector2iFix64Colori_hotfix = (luaObj.RawGet("DrawLine") as LuaFunction);
					this.m_LogBattleStart_hotfix = (luaObj.RawGet("LogBattleStart") as LuaFunction);
					this.m_LogBattleStopBoolean_hotfix = (luaObj.RawGet("LogBattleStop") as LuaFunction);
					this.m_LogBattleTeamBattleTeamBattleTeam_hotfix = (luaObj.RawGet("LogBattleTeam") as LuaFunction);
					this.m_LogActorMoveBattleActorGridPositionGridPosition_hotfix = (luaObj.RawGet("LogActorMove") as LuaFunction);
					this.m_LogActorStandbyBattleActor_hotfix = (luaObj.RawGet("LogActorStandby") as LuaFunction);
					this.m_LogActorAttackBattleActorBattleActor_hotfix = (luaObj.RawGet("LogActorAttack") as LuaFunction);
					this.m_LogActorSkillBattleActorConfigDataSkillInfoBattleActorGridPosition_hotfix = (luaObj.RawGet("LogActorSkill") as LuaFunction);
					this.m_LogActorDieBattleActorBattleActor_hotfix = (luaObj.RawGet("LogActorDie") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06003A30 RID: 14896 RVA: 0x00109D2C File Offset: 0x00107F2C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(NullBattleListener));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002C42 RID: 11330
		[DoNotToLua]
		private NullBattleListener.LuaExportHelper luaExportHelper;

		// Token: 0x04002C43 RID: 11331
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002C44 RID: 11332
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002C45 RID: 11333
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04002C46 RID: 11334
		private LuaFunction m_OnBattleActorCreateBattleActorBoolean_hotfix;

		// Token: 0x04002C47 RID: 11335
		private LuaFunction m_OnBattleActorCreateEndBattleActor_hotfix;

		// Token: 0x04002C48 RID: 11336
		private LuaFunction m_OnBattleActorActiveBattleActorBoolean_hotfix;

		// Token: 0x04002C49 RID: 11337
		private LuaFunction m_OnBattleActorActionBeginBattleActor_hotfix;

		// Token: 0x04002C4A RID: 11338
		private LuaFunction m_OnBattleActorActionEndBattleActor_hotfix;

		// Token: 0x04002C4B RID: 11339
		private LuaFunction m_OnBattleActorMoveBattleActorGridPositionInt32_hotfix;

		// Token: 0x04002C4C RID: 11340
		private LuaFunction m_OnBattleActorPerformMoveBattleActorGridPositionInt32Boolean_hotfix;

		// Token: 0x04002C4D RID: 11341
		private LuaFunction m_OnBattleActorPunchMoveBattleActorStringBoolean_hotfix;

		// Token: 0x04002C4E RID: 11342
		private LuaFunction m_OnBattleActorExchangeMoveBattleActorBattleActorInt32String_hotfix;

		// Token: 0x04002C4F RID: 11343
		private LuaFunction m_OnBattleActorSetDirBattleActorInt32_hotfix;

		// Token: 0x04002C50 RID: 11344
		private LuaFunction m_OnBattleActorPlayFxBattleActorStringInt32_hotfix;

		// Token: 0x04002C51 RID: 11345
		private LuaFunction m_OnBattleActorPlayAnimationBattleActorStringInt32_hotfix;

		// Token: 0x04002C52 RID: 11346
		private LuaFunction m_OnBattleActorChangeIdleAnimationBattleActorString_hotfix;

		// Token: 0x04002C53 RID: 11347
		private LuaFunction m_OnBattleActorSkillBattleActorConfigDataSkillInfoGridPosition_hotfix;

		// Token: 0x04002C54 RID: 11348
		private LuaFunction m_OnBattleActorSkillHitBeginBattleActorConfigDataSkillInfoBoolean_hotfix;

		// Token: 0x04002C55 RID: 11349
		private LuaFunction m_OnBattleActorSkillHitBattleActorConfigDataSkillInfoInt32Int32DamageNumberTypeBoolean_hotfix;

		// Token: 0x04002C56 RID: 11350
		private LuaFunction m_OnBattleActorSkillHitEndBattleActorConfigDataSkillInfoBoolean_hotfix;

		// Token: 0x04002C57 RID: 11351
		private LuaFunction m_OnBattleActorAttachBuffBattleActorBuffState_hotfix;

		// Token: 0x04002C58 RID: 11352
		private LuaFunction m_OnBattleActorDetachBuffBattleActorBuffState_hotfix;

		// Token: 0x04002C59 RID: 11353
		private LuaFunction m_OnBattleActorImmuneBattleActor_hotfix;

		// Token: 0x04002C5A RID: 11354
		private LuaFunction m_OnBattleActorPassiveSkillBattleActorBattleActorBuffState_hotfix;

		// Token: 0x04002C5B RID: 11355
		private LuaFunction m_OnBattleActorBuffHitBattleActorBuffStateInt32Int32DamageNumberType_hotfix;

		// Token: 0x04002C5C RID: 11356
		private LuaFunction m_OnBattleActorTerrainHitBattleActorConfigDataTerrainInfoInt32Int32DamageNumberType_hotfix;

		// Token: 0x04002C5D RID: 11357
		private LuaFunction m_OnBattleActorTeleportBattleActorConfigDataSkillInfoGridPosition_hotfix;

		// Token: 0x04002C5E RID: 11358
		private LuaFunction m_OnBattleActorSummonBattleActorConfigDataSkillInfo_hotfix;

		// Token: 0x04002C5F RID: 11359
		private LuaFunction m_OnBattleActorDieBattleActorBoolean_hotfix;

		// Token: 0x04002C60 RID: 11360
		private LuaFunction m_OnBattleActorAppearBattleActorInt32String_hotfix;

		// Token: 0x04002C61 RID: 11361
		private LuaFunction m_OnBattleActorDisappearBattleActorInt32String_hotfix;

		// Token: 0x04002C62 RID: 11362
		private LuaFunction m_OnBattleActorChangeTeamBattleActor_hotfix;

		// Token: 0x04002C63 RID: 11363
		private LuaFunction m_OnBattleActorChangeArmyBattleActor_hotfix;

		// Token: 0x04002C64 RID: 11364
		private LuaFunction m_OnBattleActorReplaceBattleActorBattleActorString_hotfix;

		// Token: 0x04002C65 RID: 11365
		private LuaFunction m_OnBattleActorCameraFocusBattleActor_hotfix;

		// Token: 0x04002C66 RID: 11366
		private LuaFunction m_OnBattleActorGainBattleTreasureBattleActorConfigDataBattleTreasureInfo_hotfix;

		// Token: 0x04002C67 RID: 11367
		private LuaFunction m_OnStartGuardBattleActorBattleActor_hotfix;

		// Token: 0x04002C68 RID: 11368
		private LuaFunction m_OnStopGuardBattleActorBattleActor_hotfix;

		// Token: 0x04002C69 RID: 11369
		private LuaFunction m_OnBeforeStartCombatBattleActorBattleActorConfigDataSkillInfo_hotfix;

		// Token: 0x04002C6A RID: 11370
		private LuaFunction m_OnCancelCombat_hotfix;

		// Token: 0x04002C6B RID: 11371
		private LuaFunction m_OnStartCombatBattleActorBattleActorConfigDataSkillInfo_hotfix;

		// Token: 0x04002C6C RID: 11372
		private LuaFunction m_OnPreStopCombat_hotfix;

		// Token: 0x04002C6D RID: 11373
		private LuaFunction m_OnStopCombatInt32Int32BooleanInt32Int32Boolean_hotfix;

		// Token: 0x04002C6E RID: 11374
		private LuaFunction m_OnBattleNextTurnInt32_hotfix;

		// Token: 0x04002C6F RID: 11375
		private LuaFunction m_OnBattleNextTeamInt32Boolean_hotfix;

		// Token: 0x04002C70 RID: 11376
		private LuaFunction m_OnBattleNextPlayerInt32Int32_hotfix;

		// Token: 0x04002C71 RID: 11377
		private LuaFunction m_OnBattleNextActorBattleActor_hotfix;

		// Token: 0x04002C72 RID: 11378
		private LuaFunction m_OnCombatActorSkillCombatActorConfigDataSkillInfo_hotfix;

		// Token: 0x04002C73 RID: 11379
		private LuaFunction m_OnCombatActorHitCombatActorCombatActorConfigDataSkillInfoInt32Int32DamageNumberType_hotfix;

		// Token: 0x04002C74 RID: 11380
		private LuaFunction m_OnCombatActorDieCombatActor_hotfix;

		// Token: 0x04002C75 RID: 11381
		private LuaFunction m_OnStartSkillCutsceneConfigDataSkillInfoConfigDataCutsceneInfoInt32_hotfix;

		// Token: 0x04002C76 RID: 11382
		private LuaFunction m_OnStartPassiveSkillCutsceneBuffStateInt32_hotfix;

		// Token: 0x04002C77 RID: 11383
		private LuaFunction m_OnStopSkillCutscene_hotfix;

		// Token: 0x04002C78 RID: 11384
		private LuaFunction m_OnStartBattleDialogConfigDataBattleDialogInfo_hotfix;

		// Token: 0x04002C79 RID: 11385
		private LuaFunction m_OnStartBattlePerformConfigDataBattlePerformInfo_hotfix;

		// Token: 0x04002C7A RID: 11386
		private LuaFunction m_OnStopBattlePerform_hotfix;

		// Token: 0x04002C7B RID: 11387
		private LuaFunction m_OnChangeMapTerrainGridPositionConfigDataTerrainInfo_hotfix;

		// Token: 0x04002C7C RID: 11388
		private LuaFunction m_OnCameraFocusGridPosition_hotfix;

		// Token: 0x04002C7D RID: 11389
		private LuaFunction m_OnPlayMusicString_hotfix;

		// Token: 0x04002C7E RID: 11390
		private LuaFunction m_OnPlaySoundString_hotfix;

		// Token: 0x04002C7F RID: 11391
		private LuaFunction m_OnPlayFxStringGridPosition_hotfix;

		// Token: 0x04002C80 RID: 11392
		private LuaFunction m_OnWaitTimeInt32_hotfix;

		// Token: 0x04002C81 RID: 11393
		private LuaFunction m_OnBattleTreasureCreateConfigDataBattleTreasureInfoBoolean_hotfix;

		// Token: 0x04002C82 RID: 11394
		private LuaFunction m_CreateCombatGraphicStringSingle_hotfix;

		// Token: 0x04002C83 RID: 11395
		private LuaFunction m_DestroyCombatGraphicIBattleGraphic_hotfix;

		// Token: 0x04002C84 RID: 11396
		private LuaFunction m_PlayFxStringSingle_hotfix;

		// Token: 0x04002C85 RID: 11397
		private LuaFunction m_PlaySoundString_hotfix;

		// Token: 0x04002C86 RID: 11398
		private LuaFunction m_DrawLineVector2iVector2iColori_hotfix;

		// Token: 0x04002C87 RID: 11399
		private LuaFunction m_DrawLineVector2iFix64Vector2iFix64Colori_hotfix;

		// Token: 0x04002C88 RID: 11400
		private LuaFunction m_LogBattleStart_hotfix;

		// Token: 0x04002C89 RID: 11401
		private LuaFunction m_LogBattleStopBoolean_hotfix;

		// Token: 0x04002C8A RID: 11402
		private LuaFunction m_LogBattleTeamBattleTeamBattleTeam_hotfix;

		// Token: 0x04002C8B RID: 11403
		private LuaFunction m_LogActorMoveBattleActorGridPositionGridPosition_hotfix;

		// Token: 0x04002C8C RID: 11404
		private LuaFunction m_LogActorStandbyBattleActor_hotfix;

		// Token: 0x04002C8D RID: 11405
		private LuaFunction m_LogActorAttackBattleActorBattleActor_hotfix;

		// Token: 0x04002C8E RID: 11406
		private LuaFunction m_LogActorSkillBattleActorConfigDataSkillInfoBattleActorGridPosition_hotfix;

		// Token: 0x04002C8F RID: 11407
		private LuaFunction m_LogActorDieBattleActorBattleActor_hotfix;

		// Token: 0x020003C9 RID: 969
		public class LuaExportHelper
		{
			// Token: 0x06003A31 RID: 14897 RVA: 0x00109D94 File Offset: 0x00107F94
			public LuaExportHelper(NullBattleListener owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x04002C90 RID: 11408
			private NullBattleListener m_owner;
		}
	}
}
