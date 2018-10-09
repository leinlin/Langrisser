using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.UtilityTools;
using FixMath.NET;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x0200036D RID: 877
	[HotFix]
	public class BattleActor : Entity
	{
		// Token: 0x060031E4 RID: 12772 RVA: 0x000C4580 File Offset: 0x000C2780
		public BattleActor()
		{
			this.m_heroBattleProperty = new BattleProperty();
			this.m_soldierBattleProperty = new BattleProperty();
			this.m_skillStates = new List<BattleSkillState>();
			this.m_buffStates = new List<BuffState>();
			this.m_position.Set(-1, -1);
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

		// Token: 0x060031E5 RID: 12773 RVA: 0x000C4630 File Offset: 0x000C2830
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
			this.m_skillStates.Clear();
			this.m_buffStates.Clear();
			this.ClearMapActor();
			this.m_heroBattleProperty = null;
			this.m_soldierBattleProperty = null;
			this.m_skillStates = null;
			this.m_buffStates = null;
			this.m_masterJobInfos = null;
			this.m_equipments = null;
			this.m_resonanceSkillInfos = null;
			this.m_fetterSkillInfos = null;
			this.m_summoner = null;
			this.m_killerActor = null;
		}

		// Token: 0x060031E6 RID: 12774 RVA: 0x000C46F4 File Offset: 0x000C28F4
		public void Initialize(BattleTeam team, ConfigDataHeroInfo heroInfo, ConfigDataJobConnectionInfo jobConnectionInfo, ConfigDataSoldierInfo soldierInfo, ConfigDataSkillInfo[] skillInfos, ConfigDataJobInfo[] masterJobInfos, BattleActorEquipment[] equipments, ConfigDataSkillInfo[] resonanceSkillInfos, ConfigDataSkillInfo[] fetterSkillInfos, int heroLevel, int heroStar, int jobLevel, int soldierCount, GridPosition pos, int dir, bool isNpc, int actionValue, int behaviorId, int groupId, BattleActorSourceType sourceType, int playerIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitializeBattleTeamConfigDataHeroInfoConfigDataJobConnectionInfoConfigDataSoldierInfoConfigDataSkillInfobeConfigDataJobInfobeBattleActorEquipmentbeConfigDataSkillInfobeConfigDataSkillInfobeInt32Int32Int32Int32GridPositionInt32BooleanInt32Int32Int32BattleActorSourceTypeInt32_hotfix != null)
			{
				this.m_InitializeBattleTeamConfigDataHeroInfoConfigDataJobConnectionInfoConfigDataSoldierInfoConfigDataSkillInfobeConfigDataJobInfobeBattleActorEquipmentbeConfigDataSkillInfobeConfigDataSkillInfobeInt32Int32Int32Int32GridPositionInt32BooleanInt32Int32Int32BattleActorSourceTypeInt32_hotfix.call(new object[]
				{
					this,
					team,
					heroInfo,
					jobConnectionInfo,
					soldierInfo,
					skillInfos,
					masterJobInfos,
					equipments,
					resonanceSkillInfos,
					fetterSkillInfos,
					heroLevel,
					heroStar,
					jobLevel,
					soldierCount,
					pos,
					dir,
					isNpc,
					actionValue,
					behaviorId,
					groupId,
					sourceType,
					playerIndex
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_team = team;
			this.m_id = this.Battle.GetNextEntityId();
			this.m_heroInfo = heroInfo;
			this.m_jobConnectionInfo = jobConnectionInfo;
			this.m_soldierInfo = soldierInfo;
			this.m_heroLevel = heroLevel;
			this.m_heroStar = heroStar;
			this.m_jobLevel = jobLevel;
			this.m_initSoldierCount = soldierCount;
			this.m_sourceType = sourceType;
			this.m_playerIndex = playerIndex;
			if (jobConnectionInfo != null)
			{
				this.m_jobInfo = jobConnectionInfo.m_jobInfo;
				this.m_heroArmyInfo = this.m_jobInfo.m_armyInfo;
			}
			else
			{
				this.m_jobInfo = null;
				this.m_heroArmyInfo = null;
			}
			if (soldierInfo != null)
			{
				this.m_soldierArmyInfo = soldierInfo.m_armyInfo;
			}
			else
			{
				this.m_soldierArmyInfo = null;
			}
			if (heroInfo != null)
			{
				if (actionValue > 0)
				{
					this.m_actionValue = actionValue * 10;
				}
				else
				{
					this.m_actionValue = this.m_jobInfo.BF_ActionValue * 10;
				}
			}
			else
			{
				this.m_actionValue = 0;
			}
			this.m_skillStates.Clear();
			if (skillInfos != null)
			{
				foreach (ConfigDataSkillInfo configDataSkillInfo in skillInfos)
				{
					if (configDataSkillInfo != null)
					{
						BattleSkillState battleSkillState = new BattleSkillState();
						battleSkillState.m_skillInfo = configDataSkillInfo;
						battleSkillState.m_cooldown = configDataSkillInfo.BF_InitCooldown;
						battleSkillState.m_isSkillUseable = true;
						this.m_skillStates.Add(battleSkillState);
					}
				}
			}
			if (masterJobInfos != null && masterJobInfos.Length > 0)
			{
				this.m_masterJobInfos = new ConfigDataJobInfo[masterJobInfos.Length];
				Array.Copy(masterJobInfos, this.m_masterJobInfos, masterJobInfos.Length);
			}
			else
			{
				this.m_masterJobInfos = null;
			}
			if (equipments != null && equipments.Length > 0)
			{
				this.m_equipments = new BattleActorEquipment[equipments.Length];
				Array.Copy(equipments, this.m_equipments, equipments.Length);
			}
			else
			{
				this.m_equipments = null;
			}
			if (resonanceSkillInfos != null && resonanceSkillInfos.Length > 0)
			{
				this.m_resonanceSkillInfos = new ConfigDataSkillInfo[resonanceSkillInfos.Length];
				Array.Copy(resonanceSkillInfos, this.m_resonanceSkillInfos, resonanceSkillInfos.Length);
			}
			else
			{
				this.m_resonanceSkillInfos = null;
			}
			if (fetterSkillInfos != null && fetterSkillInfos.Length > 0)
			{
				this.m_fetterSkillInfos = new ConfigDataSkillInfo[fetterSkillInfos.Length];
				Array.Copy(fetterSkillInfos, this.m_fetterSkillInfos, fetterSkillInfos.Length);
			}
			else
			{
				this.m_fetterSkillInfos = null;
			}
			this.m_extraPassiveSkillInfos = null;
			this.m_extraTalentSkillInfo = null;
			this.m_moveType = BattleActor.ComputeMoveType(this.m_jobInfo, this.m_soldierInfo);
			this.UpdateBattleProperties();
			this.m_heroHealthPoint = this.m_heroBattleProperty.HealthPointMax;
			this.m_soldierTotalHealthPoint = this.m_soldierBattleProperty.HealthPointMax;
			this.m_buffStates.Clear();
			this.m_buffIdCounter = 0;
			this.m_buffTypes = 0UL;
			this.m_fightTags = 0u;
			this.m_isDie = false;
			this.m_isRetreat = false;
			if (this.TeamNumber == 0)
			{
				this.m_isNpc = isNpc;
			}
			else
			{
				this.m_isNpc = false;
			}
			this.m_isPlayerNpc = false;
			if (behaviorId > 0)
			{
				this.SetBehavior(behaviorId);
			}
			else
			{
				this.SetBehavior(this.JobInfo.Behavior);
				if (this.m_isNpc && behaviorId < 0)
				{
					this.m_isPlayerNpc = true;
				}
			}
			this.m_groupId = groupId;
			this.m_summoner = null;
			this.m_killerActor = null;
			this.m_isActionFinished = false;
			this.m_hasExtraAction = false;
			this.m_hasExtraActionCount = 0;
			this.m_isExtraAction = false;
			this.m_extraActionMovePoint = 0;
			this.m_lastDamageBySkillInfo = null;
			this.m_firstDamageTurn = 0;
			this.m_satisfyConditions = 0UL;
			this.m_actionCount = 0;
			this.m_combatAttackCount = 0;
			this.m_beCombatAttackCount = 0;
			this.m_useSkillCount = 0;
			this.m_killActorCount = 0;
			this.m_dieTurn = -1;
			this.m_initPosition = pos;
			this.m_beforeGuardPosition = GridPosition.Null;
			this.m_deathAnimType = 0;
			this.SetPosition(pos);
			this.SetDirection(dir);
			this.SetVisible(true);
		}

		// Token: 0x060031E7 RID: 12775 RVA: 0x000C4C7C File Offset: 0x000C2E7C
		public void InitializeSkin(ConfigDataCharImageSkinResourceInfo heroCharImageSkinInfo, ConfigDataModelSkinResourceInfo heroModelSkinInfo, ConfigDataModelSkinResourceInfo soldierModelSkinInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitializeSkinConfigDataCharImageSkinResourceInfoConfigDataModelSkinResourceInfoConfigDataModelSkinResourceInfo_hotfix != null)
			{
				this.m_InitializeSkinConfigDataCharImageSkinResourceInfoConfigDataModelSkinResourceInfoConfigDataModelSkinResourceInfo_hotfix.call(new object[]
				{
					this,
					heroCharImageSkinInfo,
					heroModelSkinInfo,
					soldierModelSkinInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroCharImageSkinResourceInfo = heroCharImageSkinInfo;
			this.m_heroModelSkinResourceInfo = heroModelSkinInfo;
			this.m_soldierModelSkinResourceInfo = soldierModelSkinInfo;
		}

		// Token: 0x060031E8 RID: 12776 RVA: 0x000C4D24 File Offset: 0x000C2F24
		public void InitializeExtraPassiveSkillAndTalent(List<ConfigDataSkillInfo> skillInfos, ConfigDataSkillInfo talentSkillInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitializeExtraPassiveSkillAndTalentList`1ConfigDataSkillInfo_hotfix != null)
			{
				this.m_InitializeExtraPassiveSkillAndTalentList`1ConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					skillInfos,
					talentSkillInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (skillInfos != null && skillInfos.Count > 0)
			{
				this.m_extraPassiveSkillInfos = skillInfos.ToArray();
			}
			else
			{
				this.m_extraPassiveSkillInfos = null;
			}
			this.m_extraTalentSkillInfo = talentSkillInfo;
		}

		// Token: 0x060031E9 RID: 12777 RVA: 0x000C4DD8 File Offset: 0x000C2FD8
		public void InitializeEnd(bool visible = true, int heroHp = -1, int soldierHp = -1)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitializeEndBooleanInt32Int32_hotfix != null)
			{
				this.m_InitializeEndBooleanInt32Int32_hotfix.call(new object[]
				{
					this,
					visible,
					heroHp,
					soldierHp
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.Battle.Listener.OnBattleActorCreate(this, visible);
			this.InitializeBuffs();
			if (heroHp >= 0)
			{
				this.SetHeroHealthPoint(heroHp);
			}
			else
			{
				this.SetHeroHealthPoint(this.m_heroBattleProperty.HealthPointMax);
			}
			if (soldierHp >= 0)
			{
				this.SetSoldierTotalHealthPoint(soldierHp);
			}
			else
			{
				this.SetSoldierTotalHealthPoint(this.m_soldierBattleProperty.HealthPointMax);
			}
			if (this.Battle.IsEnableDebugLog())
			{
				if (this.m_heroHealthPoint <= 0)
				{
					DebugUtility.LogError(string.Format("!@# {0} HealthPointMax: {1}", this.InstanceID, this.m_heroHealthPoint));
				}
				if (this.m_soldierInfo != null && this.m_soldierTotalHealthPoint <= 0 && this.m_initSoldierCount > 0 && soldierHp < 0)
				{
					DebugUtility.LogError(string.Format("!@# {0} SoldierTotalHealthPoint: {1}", this.InstanceID, this.m_soldierTotalHealthPoint));
				}
			}
			this.Battle.Listener.OnBattleActorCreateEnd(this);
		}

		// Token: 0x060031EA RID: 12778 RVA: 0x000C4F60 File Offset: 0x000C3160
		public void UpdateBattleProperties()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateBattleProperties_hotfix != null)
			{
				this.m_UpdateBattleProperties_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattlePropertyModifier tempBattlePropertyModifier = this.Battle.GetTempBattlePropertyModifier();
			this.m_fightTags = 0u;
			this.CollectJobMasterPropertyModifiers(tempBattlePropertyModifier);
			this.CollectEquipmentPropertyModifiers(tempBattlePropertyModifier);
			this.CollectBuffPropertyModifiersAndFightTags(tempBattlePropertyModifier, ref this.m_fightTags);
			this.CollectBuffPropertyReplace();
			this.ComputeBattleProperties(tempBattlePropertyModifier);
		}

		// Token: 0x060031EB RID: 12779 RVA: 0x000C4FFC File Offset: 0x000C31FC
		public void UpdateBattlePropertiesInCombat(BattleActor other, bool isAttacker, int distance)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateBattlePropertiesInCombatBattleActorBooleanInt32_hotfix != null)
			{
				this.m_UpdateBattlePropertiesInCombatBattleActorBooleanInt32_hotfix.call(new object[]
				{
					this,
					other,
					isAttacker,
					distance
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattlePropertyModifier tempBattlePropertyModifier = this.Battle.GetTempBattlePropertyModifier();
			this.m_fightTags = 0u;
			this.CollectJobMasterPropertyModifiers(tempBattlePropertyModifier);
			this.CollectEquipmentPropertyModifiers(tempBattlePropertyModifier);
			this.CollectBuffPropertyModifiersAndFightTags(tempBattlePropertyModifier, ref this.m_fightTags);
			this.CollectBuffPropertyReplace();
			if (other != null)
			{
				this.CollectBuffPropertyModifiersAndFightTagsInCombat(tempBattlePropertyModifier, ref this.m_fightTags, other, isAttacker, distance);
			}
			this.ComputeBattleProperties(tempBattlePropertyModifier);
		}

		// Token: 0x060031EC RID: 12780 RVA: 0x000C50E0 File Offset: 0x000C32E0
		private void ComputeBattleProperties(BattlePropertyModifier pm)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeBattlePropertiesBattlePropertyModifier_hotfix != null)
			{
				this.m_ComputeBattlePropertiesBattlePropertyModifier_hotfix.call(new object[]
				{
					this,
					pm
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroBattleProperty.Clear();
			this.m_soldierBattleProperty.Clear();
			this.m_soldierSingleHealthPointMax = 0;
			if (this.m_heroInfo != null)
			{
				this.m_heroBattleProperty.ComputeHeroProperties(this.Battle.ConfigDataLoader, this.m_heroInfo, this.m_jobConnectionInfo, this.m_jobLevel, this.m_heroLevel, this.m_heroStar, pm);
				this.CollectBuffPropertyExchange(this.m_heroBattleProperty, pm);
				this.m_heroBattleProperty.ApplyExchangeProperty(pm);
				if (this.m_buffReplaceMovePoint > 0)
				{
					this.m_heroBattleProperty.MovePoint = this.m_buffReplaceMovePoint;
				}
			}
			if (this.m_soldierInfo != null)
			{
				this.m_soldierBattleProperty.ComputeSoldierProperties(this.Battle.ConfigDataLoader, this.m_soldierInfo, this.m_heroInfo, this.m_heroLevel, pm);
				this.m_soldierSingleHealthPointMax = this.m_soldierBattleProperty.HealthPointMax;
				this.m_soldierBattleProperty.HealthPointMax = this.m_soldierSingleHealthPointMax * this.m_initSoldierCount;
				if (this.m_buffReplaceMovePoint > 0)
				{
					this.m_heroBattleProperty.MovePoint = this.m_buffReplaceMovePoint;
				}
			}
		}

		// Token: 0x060031ED RID: 12781 RVA: 0x000C5260 File Offset: 0x000C3460
		public void CollectJobMasterPropertyModifiers(BattlePropertyModifier pm)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectJobMasterPropertyModifiersBattlePropertyModifier_hotfix != null)
			{
				this.m_CollectJobMasterPropertyModifiersBattlePropertyModifier_hotfix.call(new object[]
				{
					this,
					pm
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_masterJobInfos == null)
			{
				return;
			}
			foreach (ConfigDataJobInfo configDataJobInfo in this.m_masterJobInfos)
			{
				pm.Collect(configDataJobInfo.Property1_ID, configDataJobInfo.Property1_Value);
				pm.Collect(configDataJobInfo.Property2_ID, configDataJobInfo.Property2_Value);
				pm.Collect(configDataJobInfo.Property3_ID, configDataJobInfo.Property3_Value);
			}
		}

		// Token: 0x060031EE RID: 12782 RVA: 0x000C5334 File Offset: 0x000C3534
		public void CollectEquipmentPropertyModifiers(BattlePropertyModifier pm)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectEquipmentPropertyModifiersBattlePropertyModifier_hotfix != null)
			{
				this.m_CollectEquipmentPropertyModifiersBattlePropertyModifier_hotfix.call(new object[]
				{
					this,
					pm
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_equipments == null)
			{
				return;
			}
			foreach (BattleActorEquipment battleActorEquipment in this.m_equipments)
			{
				pm.Collect(battleActorEquipment.EquipmentInfo.Property1_ID, BattleFormula.ComputeEquipmentPropertyAdd(battleActorEquipment.EquipmentInfo.Property1_Value, battleActorEquipment.EquipmentInfo.Property1_LevelUpValue, battleActorEquipment.Level));
				pm.Collect(battleActorEquipment.EquipmentInfo.Property2_ID, BattleFormula.ComputeEquipmentPropertyAdd(battleActorEquipment.EquipmentInfo.Property2_Value, battleActorEquipment.EquipmentInfo.Property2_LevelUpValue, battleActorEquipment.Level));
				if (battleActorEquipment.EnchantProperties != null)
				{
					foreach (CommonBattleProperty commonBattleProperty in battleActorEquipment.EnchantProperties)
					{
						pm.Collect(commonBattleProperty.Id, commonBattleProperty.Value);
					}
				}
			}
		}

		// Token: 0x060031EF RID: 12783 RVA: 0x000C5478 File Offset: 0x000C3678
		private void SetPosition(GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPositionGridPosition_hotfix != null)
			{
				this.m_SetPositionGridPosition_hotfix.call(new object[]
				{
					this,
					p
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ClearMapActor();
			this.m_position = p;
			this.Battle.Map.SetActor(p, this);
		}

		// Token: 0x060031F0 RID: 12784 RVA: 0x000C5508 File Offset: 0x000C3708
		public void SetDirection(int dir)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetDirectionInt32_hotfix != null)
			{
				this.m_SetDirectionInt32_hotfix.call(new object[]
				{
					this,
					dir
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_direction = dir;
		}

		// Token: 0x060031F1 RID: 12785 RVA: 0x000C5580 File Offset: 0x000C3780
		public void FaceTo(GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FaceToGridPosition_hotfix != null)
			{
				this.m_FaceToGridPosition_hotfix.call(new object[]
				{
					this,
					p
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (p == this.m_position)
			{
				return;
			}
			int num = p.x - this.m_position.x;
			if (num > 0)
			{
				this.m_direction = 1;
			}
			else if (num < 0)
			{
				this.m_direction = -1;
			}
		}

		// Token: 0x060031F2 RID: 12786 RVA: 0x000C5638 File Offset: 0x000C3838
		public void GuardMove(GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GuardMoveGridPosition_hotfix != null)
			{
				this.m_GuardMoveGridPosition_hotfix.call(new object[]
				{
					this,
					p
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_beforeGuardPosition = this.m_position;
			this.FaceTo(p);
			this.m_position = p;
		}

		// Token: 0x060031F3 RID: 12787 RVA: 0x000C56C4 File Offset: 0x000C38C4
		public void UnguardMove()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UnguardMove_hotfix != null)
			{
				this.m_UnguardMove_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_beforeGuardPosition != GridPosition.Null)
			{
				this.FaceTo(this.m_beforeGuardPosition);
				this.m_position = this.m_beforeGuardPosition;
				this.m_beforeGuardPosition = GridPosition.Null;
			}
		}

		// Token: 0x060031F4 RID: 12788 RVA: 0x000C575C File Offset: 0x000C395C
		private void MoveTo(GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_MoveToGridPosition_hotfix != null)
			{
				this.m_MoveToGridPosition_hotfix.call(new object[]
				{
					this,
					p
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetPosition(p);
			this.UpdateBattleProperties();
			this.UpdateAllAuras();
		}

		// Token: 0x060031F5 RID: 12789 RVA: 0x000C57E0 File Offset: 0x000C39E0
		private void ClearMapActor()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearMapActor_hotfix != null)
			{
				this.m_ClearMapActor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleMap map = this.Battle.Map;
			if (this.m_position.y >= 0 && map.GetActor(this.m_position) == this)
			{
				map.SetActor(this.m_position, null);
			}
		}

		// Token: 0x060031F6 RID: 12790 RVA: 0x000C587C File Offset: 0x000C3A7C
		public ConfigDataTerrainInfo GetTerrain()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTerrain_hotfix != null)
			{
				return (ConfigDataTerrainInfo)this.m_GetTerrain_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.Battle.Map.GetTerrain(this.m_position);
		}

		// Token: 0x060031F7 RID: 12791 RVA: 0x000C5900 File Offset: 0x000C3B00
		public ConfigDataTerrainInfo GetBuffEffectedTerrain()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetBuffEffectedTerrain_hotfix != null)
			{
				return (ConfigDataTerrainInfo)this.m_GetBuffEffectedTerrain_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataTerrainInfo buffOverrideTerrain = this.GetBuffOverrideTerrain();
			if (buffOverrideTerrain != null)
			{
				return buffOverrideTerrain;
			}
			return this.Battle.Map.GetTerrain(this.m_position);
		}

		// Token: 0x060031F8 RID: 12792 RVA: 0x000C5994 File Offset: 0x000C3B94
		public void ChangeTeam(int team, bool isNpc)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ChangeTeamInt32Boolean_hotfix != null)
			{
				this.m_ChangeTeamInt32Boolean_hotfix.call(new object[]
				{
					this,
					team,
					isNpc
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (team == this.TeamNumber && isNpc == this.m_isNpc)
			{
				return;
			}
			if (team != this.TeamNumber)
			{
				BattleTeam team2 = this.Battle.GetTeam(this.TeamNumber);
				BattleTeam team3 = this.Battle.GetTeam(team);
				team2.GetActors().Remove(this);
				team3.GetActors().Add(this);
				this.m_team = team3;
			}
			if (team == 0)
			{
				this.m_isNpc = isNpc;
				this.m_isPlayerNpc = (isNpc && this.GetBehaviorId() < 0);
			}
			else
			{
				this.m_isNpc = (this.m_isPlayerNpc = false);
			}
			this.Battle.OnActorChangeTeam(this);
		}

		// Token: 0x060031F9 RID: 12793 RVA: 0x000C5AC0 File Offset: 0x000C3CC0
		public BattleCommand CreateBattleCommand(BattleCommandType type)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateBattleCommandBattleCommandType_hotfix != null)
			{
				return (BattleCommand)this.m_CreateBattleCommandBattleCommandType_hotfix.call(new object[]
				{
					this,
					type
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.Battle.IsEnableDebugLog())
			{
				DebugUtility.Log(string.Format("!@# {0} create command: {1}", this.InstanceID, type));
			}
			BattleCommand battleCommand = new BattleCommand();
			battleCommand.Type = type;
			battleCommand.Step = this.Battle.Step;
			battleCommand.ActorId = this.m_id;
			this.Battle.AddBattleCommand(battleCommand);
			return battleCommand;
		}

		// Token: 0x060031FA RID: 12794 RVA: 0x000C5BA0 File Offset: 0x000C3DA0
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
		}

		// Token: 0x060031FB RID: 12795 RVA: 0x000C5C00 File Offset: 0x000C3E00
		public void StopBattle(bool win)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StopBattleBoolean_hotfix != null)
			{
				this.m_StopBattleBoolean_hotfix.call(new object[]
				{
					this,
					win
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060031FC RID: 12796 RVA: 0x000C5C70 File Offset: 0x000C3E70
		public void NextTurn()
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
			this.m_isActionFinished = false;
			this.m_hasExtraAction = false;
			this.m_hasExtraActionCount = 0;
			this.m_hasExtraMovePoint = 0;
			this.m_isExtraAction = false;
			this.m_extraActionMovePoint = 0;
		}

		// Token: 0x060031FD RID: 12797 RVA: 0x000C5CFC File Offset: 0x000C3EFC
		public void ActionBegin()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActionBegin_hotfix != null)
			{
				this.m_ActionBegin_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsExtraActionMoving())
			{
				this.m_actionMoveGrids = 0;
				this.m_actionRemainMovePoint = this.GetMovePoint();
				this.m_executedCommandTypes = 0u;
				this.m_executedSkillInfo = null;
				this.m_isActionCriticalAttack = false;
				this.m_isActionKillActor = false;
				this.m_isActionDamageActor = false;
			}
			this.UpdateAllAuras();
		}

		// Token: 0x060031FE RID: 12798 RVA: 0x000C5DA4 File Offset: 0x000C3FA4
		public void ActionEnd()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActionEnd_hotfix != null)
			{
				this.m_ActionEnd_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsExtraActionMoving())
			{
				foreach (BattleSkillState battleSkillState in this.m_skillStates)
				{
					if (battleSkillState.m_cooldown > 0)
					{
						battleSkillState.m_cooldown--;
					}
				}
			}
			this.UpdateAllAuras();
			bool flag = this.Battle.IsPlay();
			if (flag)
			{
				this.ActionEndBuffEffect();
				this.PostActionTerrainDamage();
				this.CheckDie(null);
				if (this.IsDead())
				{
					this.Battle.CheckOnActorDie(this);
				}
			}
			bool flag2 = this.IsDeadOrRetreat();
			if (this.m_hasExtraMovePoint > 0 && !flag2 && flag)
			{
				this.m_extraActionMovePoint = this.m_hasExtraMovePoint;
				this.m_hasExtraMovePoint = 0;
			}
			else if (this.m_hasExtraAction && !flag2 && flag)
			{
				this.m_hasExtraAction = false;
				this.m_extraActionMovePoint = 0;
				this.m_isExtraAction = true;
				this.m_isActionCriticalAttack = false;
				this.m_isActionKillActor = false;
				this.m_isActionDamageActor = false;
				this.m_buffReplaceMovePoint = 0;
			}
			else
			{
				this.m_isActionFinished = true;
				this.m_isExtraAction = false;
				this.m_hasExtraActionCount = 0;
				this.m_extraActionMovePoint = 0;
				this.m_actionCount += 1;
				this.m_isActionCriticalAttack = false;
				this.m_isActionKillActor = false;
				this.m_isActionDamageActor = false;
				this.m_buffReplaceMovePoint = 0;
			}
			this.m_actionMoveGrids = 0;
			this.m_actionRemainMovePoint = 0;
		}

		// Token: 0x060031FF RID: 12799 RVA: 0x000C5F8C File Offset: 0x000C418C
		public bool IsActionFinished()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsActionFinished_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsActionFinished_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isActionFinished;
		}

		// Token: 0x06003200 RID: 12800 RVA: 0x000C6000 File Offset: 0x000C4200
		public bool CanAction()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAction_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CanAction_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return !this.m_isActionFinished && !this.HasFightTag(FightTag.FightTag_Stun) && !this.IsDeadOrRetreat();
		}

		// Token: 0x06003201 RID: 12801 RVA: 0x000C6090 File Offset: 0x000C4290
		private void PostActionTerrainDamage()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostActionTerrainDamage_hotfix != null)
			{
				this.m_PostActionTerrainDamage_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataTerrainInfo terrain = this.GetTerrain();
			if (terrain == null || terrain.Damage == 0)
			{
				return;
			}
			int num = 0;
			int num2 = 0;
			if (this.m_heroInfo != null)
			{
				num = this.m_heroBattleProperty.HealthPointMax * terrain.Damage / -100;
				this.SetHeroHealthPoint(this.m_heroHealthPoint + num);
			}
			if (this.m_soldierInfo != null)
			{
				num2 = this.m_soldierBattleProperty.HealthPointMax * terrain.Damage / -100;
				this.SetSoldierTotalHealthPoint(this.m_soldierTotalHealthPoint + num2);
			}
			this.UpdateBattleProperties();
			DamageNumberType damageNumberType = (num > 0) ? DamageNumberType.Heal : DamageNumberType.Normal;
			this.Battle.Listener.OnBattleActorTerrainHit(this, terrain, num, num2, damageNumberType);
		}

		// Token: 0x06003202 RID: 12802 RVA: 0x000C6198 File Offset: 0x000C4398
		public bool FindPath(GridPosition start, GridPosition goal, int movePoint, int inRegion, List<GridPosition> path, bool findNearestIfFail = false)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindPathGridPositionGridPositionInt32Int32List`1Boolean_hotfix != null)
			{
				return Convert.ToBoolean(this.m_FindPathGridPositionGridPositionInt32Int32List`1Boolean_hotfix.call(new object[]
				{
					this,
					start,
					goal,
					movePoint,
					inRegion,
					path,
					findNearestIfFail
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.Battle.FindPath(start, goal, movePoint, this.GetMoveType(), this.TeamNumber, this.GetBuffOverrideMovePointCost(), inRegion, path, findNearestIfFail);
		}

		// Token: 0x06003203 RID: 12803 RVA: 0x000C628C File Offset: 0x000C448C
		public void FindMoveRegion(GridPosition start, List<GridPosition> region)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindMoveRegionGridPositionList`1_hotfix != null)
			{
				this.m_FindMoveRegionGridPositionList`1_hotfix.call(new object[]
				{
					this,
					start,
					region
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.Battle.FindMoveRegion(start, this.GetMovePoint(), this.GetMoveType(), this.TeamNumber, this.GetBuffOverrideMovePointCost(), 0, region);
		}

		// Token: 0x06003204 RID: 12804 RVA: 0x000C6334 File Offset: 0x000C4534
		private bool ShouldLog()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShouldLog_hotfix != null)
			{
				return Convert.ToBoolean(this.m_ShouldLog_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.IsPlayerActor();
		}

		// Token: 0x06003205 RID: 12805 RVA: 0x000C63A8 File Offset: 0x000C45A8
		private void AddExecutedCommandType(BattleCommandType cmdType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddExecutedCommandTypeBattleCommandType_hotfix != null)
			{
				this.m_AddExecutedCommandTypeBattleCommandType_hotfix.call(new object[]
				{
					this,
					cmdType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_executedCommandTypes = MathUtility.SetBit(this.m_executedCommandTypes, (int)cmdType, true);
		}

		// Token: 0x06003206 RID: 12806 RVA: 0x000C642C File Offset: 0x000C462C
		public bool HasExecutedCommandType(BattleCommandType cmdType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasExecutedCommandTypeBattleCommandType_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasExecutedCommandTypeBattleCommandType_hotfix.call(new object[]
				{
					this,
					cmdType
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return MathUtility.GetBit(this.m_executedCommandTypes, (int)cmdType);
		}

		// Token: 0x06003207 RID: 12807 RVA: 0x000C64B4 File Offset: 0x000C46B4
		private bool IsExecutedCommandType(BattleCommandType cmdType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsExecutedCommandTypeBattleCommandType_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsExecutedCommandTypeBattleCommandType_hotfix.call(new object[]
				{
					this,
					cmdType
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_executedCommandTypes == MathUtility.SetBit(0u, (int)cmdType, true);
		}

		// Token: 0x06003208 RID: 12808 RVA: 0x000C6540 File Offset: 0x000C4740
		public bool ExecuteMoveCommand(GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteMoveCommandGridPosition_hotfix != null)
			{
				return Convert.ToBoolean(this.m_ExecuteMoveCommandGridPosition_hotfix.call(new object[]
				{
					this,
					p
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_actionMoveGrids = 0;
			this.m_actionRemainMovePoint = this.GetMovePoint();
			BattleActor actor = this.Battle.Map.GetActor(p);
			if (actor != null && actor != this)
			{
				if (this.Battle.IsEnableDebugLog())
				{
					DebugUtility.LogError(string.Format("{2} ExecuteMoveCommand() error, There already is a hero at: {0}, {1}", p.x, p.y, this.InstanceID));
				}
				return false;
			}
			List<GridPosition> list = this.Battle.AllocateTempGridPositionList();
			GridPosition position = this.m_position;
			bool flag;
			if (this.FindPath(this.m_position, p, this.GetMovePoint(), 0, list, false))
			{
				for (int i = 1; i < list.Count; i++)
				{
					GridPosition p2 = list[i];
					int num = p2.x - list[i - 1].x;
					if (num > 0)
					{
						this.m_direction = 1;
					}
					else if (num < 0)
					{
						this.m_direction = -1;
					}
					this.Battle.Listener.OnBattleActorMove(this, p2, this.m_direction);
					this.m_actionMoveGrids++;
					this.m_actionRemainMovePoint -= this.Battle.Map.GetMovePointCost(p2, this.GetMoveType());
				}
				this.MoveTo(p);
				flag = true;
			}
			else
			{
				if (this.Battle.IsEnableDebugLog())
				{
					DebugUtility.LogError(string.Format("{3} ExecuteMoveCommand() error, move points: {0}, move to: {1}, {2}.", new object[]
					{
						this.GetMovePoint(),
						p.x,
						p.y,
						this.InstanceID
					}));
				}
				flag = false;
			}
			if (flag)
			{
				this.AddExecutedCommandType(BattleCommandType.Move);
				if (this.ShouldLog())
				{
					this.Battle.Listener.LogActorMove(this, position, this.m_position);
				}
			}
			this.Battle.FreeTempGridPositionList(list);
			return flag;
		}

		// Token: 0x06003209 RID: 12809 RVA: 0x000C67B8 File Offset: 0x000C49B8
		public bool ExecutePerformMoveCommand(GridPosition p, bool cameraFollow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecutePerformMoveCommandGridPositionBoolean_hotfix != null)
			{
				return Convert.ToBoolean(this.m_ExecutePerformMoveCommandGridPositionBoolean_hotfix.call(new object[]
				{
					this,
					p,
					cameraFollow
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleActor actor = this.Battle.Map.GetActor(p);
			if (actor != null && actor != this)
			{
				if (this.Battle.IsEnableDebugLog())
				{
					DebugUtility.LogError(string.Format("{2} ExecutePerformMoveCommand() error, There already is a hero at: {0}, {1}", p.x, p.y, this.InstanceID));
				}
				return false;
			}
			List<GridPosition> list = this.Battle.AllocateTempGridPositionList();
			bool flag;
			if (this.FindPath(this.m_position, p, 10000, 0, list, false))
			{
				for (int i = 1; i < list.Count; i++)
				{
					GridPosition p2 = list[i];
					int num = p2.x - list[i - 1].x;
					if (num > 0)
					{
						this.m_direction = 1;
					}
					else if (num < 0)
					{
						this.m_direction = -1;
					}
					this.Battle.Listener.OnBattleActorPerformMove(this, p2, this.m_direction, cameraFollow);
				}
				this.MoveTo(p);
				flag = true;
			}
			else
			{
				if (this.Battle.IsEnableDebugLog())
				{
					DebugUtility.LogError(string.Format("{0} ExecutePerformMoveCommand() error, move to: {1}, {2}.", this.InstanceID, p.x, p.y));
				}
				flag = false;
			}
			if (flag)
			{
				this.AddExecutedCommandType(BattleCommandType.Move);
			}
			this.Battle.FreeTempGridPositionList(list);
			return flag;
		}

		// Token: 0x0600320A RID: 12810 RVA: 0x000C69AC File Offset: 0x000C4BAC
		public bool ExecuteCombatCommand(BattleActor target, ConfigDataSkillInfo skillInfo, bool isPerform)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteCombatCommandBattleActorConfigDataSkillInfoBoolean_hotfix != null)
			{
				return Convert.ToBoolean(this.m_ExecuteCombatCommandBattleActorConfigDataSkillInfoBoolean_hotfix.call(new object[]
				{
					this,
					target,
					skillInfo,
					isPerform
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (target == null)
			{
				if (this.Battle.IsEnableDebugLog())
				{
					DebugUtility.LogError(string.Format("{0} ExecuteCombatCommand() error, target is null.", this.InstanceID));
				}
				return false;
			}
			if (!isPerform)
			{
				if (target.TeamNumber == this.TeamNumber)
				{
					if (this.Battle.IsEnableDebugLog())
					{
						DebugUtility.LogError(string.Format("{0} ExecuteCombatCommand() error, attack teamate.", this.InstanceID));
					}
					return false;
				}
				if (target.IsDeadOrRetreat())
				{
					if (this.Battle.IsEnableDebugLog())
					{
						DebugUtility.LogError(string.Format("{0} ExecuteCombatCommand() error, target is dead or retreat.", this.InstanceID));
					}
					return false;
				}
				if (this.IsExtraActionMoving())
				{
					if (this.Battle.IsEnableDebugLog())
					{
						DebugUtility.LogError(string.Format("{0} ExecuteCombatCommand() error, IsExtraActionMoving.", this.InstanceID));
					}
					return false;
				}
				int num;
				if (skillInfo != null)
				{
					num = this.GetSkillDistance(skillInfo);
				}
				else
				{
					num = this.GetMaxAttackDistance();
				}
				int num2 = GridPosition.Distance(this.m_position, target.m_position);
				if (num2 > num)
				{
					if (this.Battle.IsEnableDebugLog())
					{
						DebugUtility.LogError(string.Format("{0} ExecuteCombatCommand() error, target distance {1}, max distance {2}.", this.InstanceID, num2, num));
					}
					return false;
				}
			}
			if (skillInfo != null && skillInfo.m_selfBuffInfos != null)
			{
				foreach (ConfigDataBuffInfo buffInfo in skillInfo.m_selfBuffInfos)
				{
					this.AttachBuff(buffInfo, this, BuffSourceType.SkillSelf, skillInfo, null);
				}
			}
			this.FaceTo(target.m_position);
			target.FaceTo(this.m_position);
			this.Battle.StartCombat(this, target, skillInfo);
			this.AddExecutedCommandType(BattleCommandType.Combat);
			if (!isPerform && this.ShouldLog() && skillInfo == null)
			{
				this.Battle.Listener.LogActorAttack(this, target);
			}
			return true;
		}

		// Token: 0x0600320B RID: 12811 RVA: 0x000C6C18 File Offset: 0x000C4E18
		public bool ExecuteSkillCommand(int skillIndex, GridPosition p, GridPosition p2)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteSkillCommandInt32GridPositionGridPosition_hotfix != null)
			{
				return Convert.ToBoolean(this.m_ExecuteSkillCommandInt32GridPositionGridPosition_hotfix.call(new object[]
				{
					this,
					skillIndex,
					p,
					p2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleSkillState skillState = this.GetSkillState(skillIndex);
			if (skillState == null)
			{
				if (this.Battle.IsEnableDebugLog())
				{
					DebugUtility.LogError(string.Format("{0} ExecuteSkillCommand() error, skillIndex {1} is invalid.", this.InstanceID, skillIndex));
				}
				return false;
			}
			ConfigDataSkillInfo skillInfo = skillState.m_skillInfo;
			if (skillInfo == null)
			{
				if (this.Battle.IsEnableDebugLog())
				{
					DebugUtility.LogError(string.Format("{0} ExecuteSkillCommand() error, skillInfo of skillIndex {1} is null.", this.InstanceID, skillIndex));
				}
				return false;
			}
			if (skillInfo.IsPassiveSkill())
			{
				if (this.Battle.IsEnableDebugLog())
				{
					DebugUtility.LogError(string.Format("{0} ExecuteSkillCommand() error, skill {1} is a passive skill.", this.InstanceID, skillInfo.Name));
				}
				return false;
			}
			BattleMap map = this.Battle.Map;
			BattleActor actor = map.GetActor(p);
			if (this.IsExtraActionMoving())
			{
				if (this.Battle.IsEnableDebugLog())
				{
					DebugUtility.LogError(string.Format("{0} ExecuteSkillCommand() error, skill {1} IsExtraActionMoving.", this.InstanceID, skillInfo.Name));
				}
				return false;
			}
			if (this.HasFightTag(FightTag.FightTag_BanActiveSkill))
			{
				if (this.Battle.IsEnableDebugLog())
				{
					DebugUtility.LogError(string.Format("{0} ExecuteSkillCommand() error, skill {1} is ban by active skill.", this.InstanceID, skillInfo.Name));
				}
				return false;
			}
			if (skillState.m_cooldown > 0)
			{
				if (this.Battle.IsEnableDebugLog())
				{
					DebugUtility.LogError(string.Format("{0} ExecuteSkillCommand() error, skill {1} is cooldown.", this.InstanceID, skillInfo.Name));
				}
				return false;
			}
			if (!BattleBase.IsInRegion(this.m_position, p, this.GetSkillDistance(skillInfo), skillInfo.CastSkillShape))
			{
				if (this.Battle.IsEnableDebugLog())
				{
					DebugUtility.LogError(string.Format("{0} ExecuteSkillCommand() error, the distance to target {1},{2} is greater than skill {3} 's range.", new object[]
					{
						this.InstanceID,
						p.x,
						p.y,
						skillInfo.Name
					}));
				}
				return false;
			}
			if (!this.CanUseSkillOnTarget(skillInfo, actor))
			{
				if (this.Battle.IsEnableDebugLog())
				{
					DebugUtility.LogError(string.Format("{0} ExecuteSkillCommand() error, can not use skill {1} on {2}.", this.InstanceID, skillInfo.Name, (actor != null) ? actor.InstanceID : "null"));
				}
				return false;
			}
			this.Battle.CheckEventTriggerOnActorUseSkill(this);
			this.IncreaseUseSkillCount();
			this.FaceTo(p);
			skillState.m_cooldown = skillInfo.BF_Cooldown + 1;
			if (skillInfo.IsBattlefieldSkill())
			{
				this.ExecuteBattlefieldSkill(skillInfo, p, p2);
			}
			else if (!this.ExecuteCombatCommand(actor, skillInfo, false))
			{
				return false;
			}
			if (skillInfo.IsNewTurn)
			{
				this.m_hasExtraAction = true;
			}
			this.AddExecutedCommandType(BattleCommandType.Skill);
			this.m_executedSkillInfo = skillInfo;
			if (this.ShouldLog())
			{
				this.Battle.Listener.LogActorSkill(this, skillInfo, actor, p);
			}
			return true;
		}

		// Token: 0x0600320C RID: 12812 RVA: 0x000C6F78 File Offset: 0x000C5178
		public bool ExecutePerformSkillCommand(ConfigDataSkillInfo skillInfo, GridPosition p, GridPosition p2)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecutePerformSkillCommandConfigDataSkillInfoGridPositionGridPosition_hotfix != null)
			{
				return Convert.ToBoolean(this.m_ExecutePerformSkillCommandConfigDataSkillInfoGridPositionGridPosition_hotfix.call(new object[]
				{
					this,
					skillInfo,
					p,
					p2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (skillInfo == null)
			{
				return false;
			}
			BattleMap map = this.Battle.Map;
			BattleActor actor = map.GetActor(p);
			this.Battle.CheckEventTriggerOnActorUseSkill(this);
			this.IncreaseUseSkillCount();
			this.FaceTo(p);
			if (skillInfo.IsBattlefieldSkill())
			{
				this.ExecuteBattlefieldSkill(skillInfo, p, p2);
			}
			else if (!this.ExecuteCombatCommand(actor, skillInfo, true))
			{
				return false;
			}
			if (skillInfo.IsNewTurn)
			{
				this.m_hasExtraAction = true;
			}
			this.AddExecutedCommandType(BattleCommandType.Skill);
			return true;
		}

		// Token: 0x0600320D RID: 12813 RVA: 0x000C7090 File Offset: 0x000C5290
		public bool ExecuteDoneCommand()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteDoneCommand_hotfix != null)
			{
				return Convert.ToBoolean(this.m_ExecuteDoneCommand_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.AddExecutedCommandType(BattleCommandType.Done);
			if (this.ShouldLog() && this.IsExecutedCommandType(BattleCommandType.Done))
			{
				this.Battle.Listener.LogActorStandby(this);
			}
			return true;
		}

		// Token: 0x0600320E RID: 12814 RVA: 0x000C712C File Offset: 0x000C532C
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
			if (this.m_heroInfo != null)
			{
				return this.m_heroHealthPoint <= 0;
			}
			return this.m_soldierTotalHealthPoint <= 0;
		}

		// Token: 0x0600320F RID: 12815 RVA: 0x000C71BC File Offset: 0x000C53BC
		public bool IsRetreat()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsRetreat_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsRetreat_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isRetreat;
		}

		// Token: 0x06003210 RID: 12816 RVA: 0x000C7230 File Offset: 0x000C5430
		public bool IsDeadOrRetreat()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsDeadOrRetreat_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsDeadOrRetreat_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.IsDead() || this.IsRetreat();
		}

		// Token: 0x06003211 RID: 12817 RVA: 0x000C72B0 File Offset: 0x000C54B0
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
		}

		// Token: 0x06003212 RID: 12818 RVA: 0x000C7328 File Offset: 0x000C5528
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

		// Token: 0x06003213 RID: 12819 RVA: 0x000C739C File Offset: 0x000C559C
		public bool IsInvincible()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsInvincible_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsInvincible_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.IsDeadOrRetreat() || !this.IsVisible();
		}

		// Token: 0x06003214 RID: 12820 RVA: 0x000C7420 File Offset: 0x000C5620
		public bool IsSummoned()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsSummoned_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsSummoned_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_summoner != null;
		}

		// Token: 0x06003215 RID: 12821 RVA: 0x000C7498 File Offset: 0x000C5698
		public bool IsNpc()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNpc_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNpc_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isNpc;
		}

		// Token: 0x06003216 RID: 12822 RVA: 0x000C750C File Offset: 0x000C570C
		public bool IsAINpc()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsAINpc_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsAINpc_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isNpc && !this.m_isPlayerNpc;
		}

		// Token: 0x06003217 RID: 12823 RVA: 0x000C7590 File Offset: 0x000C5790
		public bool IsPlayerNpc()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsPlayerNpc_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsPlayerNpc_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isNpc && this.m_isPlayerNpc;
		}

		// Token: 0x06003218 RID: 12824 RVA: 0x000C7610 File Offset: 0x000C5810
		public bool IsPlayerActor()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsPlayerActor_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsPlayerActor_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return (this.TeamNumber == 0 && !this.IsAINpc()) || this.m_playerIndex >= 0;
		}

		// Token: 0x06003219 RID: 12825 RVA: 0x000C76A4 File Offset: 0x000C58A4
		public bool IsAIActor()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsAIActor_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsAIActor_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return (this.TeamNumber != 0 || this.IsAINpc()) && this.m_playerIndex < 0;
		}

		// Token: 0x0600321A RID: 12826 RVA: 0x000C7734 File Offset: 0x000C5934
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
			return !this.IsDeadOrRetreat() && this.IsVisible();
		}

		// Token: 0x0600321B RID: 12827 RVA: 0x000C77B4 File Offset: 0x000C59B4
		public void SetHeroHealthPoint(int value)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroHealthPointInt32_hotfix != null)
			{
				this.m_SetHeroHealthPointInt32_hotfix.call(new object[]
				{
					this,
					value
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroHealthPoint = value;
			if (this.m_heroHealthPoint < 0)
			{
				this.m_heroHealthPoint = 0;
			}
			else if (this.m_heroHealthPoint > this.m_heroBattleProperty.HealthPointMax)
			{
				this.m_heroHealthPoint = this.m_heroBattleProperty.HealthPointMax;
			}
		}

		// Token: 0x0600321C RID: 12828 RVA: 0x000C786C File Offset: 0x000C5A6C
		public void SetSoldierTotalHealthPoint(int value)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSoldierTotalHealthPointInt32_hotfix != null)
			{
				this.m_SetSoldierTotalHealthPointInt32_hotfix.call(new object[]
				{
					this,
					value
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_soldierTotalHealthPoint = value;
			if (this.m_soldierTotalHealthPoint < 0)
			{
				this.m_soldierTotalHealthPoint = 0;
			}
			else if (this.m_soldierTotalHealthPoint > this.m_soldierBattleProperty.HealthPointMax)
			{
				this.m_soldierTotalHealthPoint = this.m_soldierBattleProperty.HealthPointMax;
			}
		}

		// Token: 0x0600321D RID: 12829 RVA: 0x000C7924 File Offset: 0x000C5B24
		public void CheckDie(BattleActor attacker)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckDieBattleActor_hotfix != null)
			{
				this.m_CheckDieBattleActor_hotfix.call(new object[]
				{
					this,
					attacker
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsDead())
			{
				this.BuffUndead();
			}
			if (this.IsDead() && !this.m_isDie)
			{
				this.UpdateAllAuras();
				this.m_isDie = true;
				this.m_heroHealthPoint = (this.m_soldierTotalHealthPoint = 0);
				this.m_killerActor = attacker;
				this.m_dieTurn = this.Battle.Turn;
				this.RemoveAllBuffs();
				this.UnguardMove();
				this.ClearMapActor();
				this.m_team.OnMyActorDie(this);
				if (this.ShouldLog())
				{
					this.Battle.Listener.LogActorDie(this, attacker);
				}
			}
		}

		// Token: 0x0600321E RID: 12830 RVA: 0x000C7A2C File Offset: 0x000C5C2C
		public void Retreat(int effectType, string fxName, bool notifyListener = true)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RetreatInt32StringBoolean_hotfix != null)
			{
				this.m_RetreatInt32StringBoolean_hotfix.call(new object[]
				{
					this,
					effectType,
					fxName,
					notifyListener
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isRetreat = true;
			this.RemoveAllBuffs();
			this.ClearMapActor();
			this.m_team.OnMyActorRetreat(this, effectType, fxName, notifyListener);
		}

		// Token: 0x0600321F RID: 12831 RVA: 0x000C7AE0 File Offset: 0x000C5CE0
		public int GetSoldierAttackDistance()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSoldierAttackDistance_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetSoldierAttackDistance_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_soldierInfo == null || this.m_soldierTotalHealthPoint <= 0)
			{
				return -1;
			}
			return this.m_soldierBattleProperty.AttackDistance;
		}

		// Token: 0x06003220 RID: 12832 RVA: 0x000C7B70 File Offset: 0x000C5D70
		public int GetMaxAttackDistance()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetMaxAttackDistance_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetMaxAttackDistance_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_soldierInfo == null || this.m_soldierTotalHealthPoint <= 0)
			{
				return this.m_heroBattleProperty.AttackDistance;
			}
			if (this.m_jobInfo == null)
			{
				return this.m_soldierBattleProperty.AttackDistance;
			}
			return Math.Max(this.m_heroBattleProperty.AttackDistance, this.m_soldierBattleProperty.AttackDistance);
		}

		// Token: 0x06003221 RID: 12833 RVA: 0x000C7C34 File Offset: 0x000C5E34
		public ConfigDataSkillInfo GetTalentSkillInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTalentSkillInfo_hotfix != null)
			{
				return (ConfigDataSkillInfo)this.m_GetTalentSkillInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_extraTalentSkillInfo != null)
			{
				return this.m_extraTalentSkillInfo;
			}
			return this.m_jobConnectionInfo.GetTalentSkillInfo(this.m_heroStar);
		}

		// Token: 0x06003222 RID: 12834 RVA: 0x000C7CC4 File Offset: 0x000C5EC4
		public int GetSkillDistance(ConfigDataSkillInfo skillInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSkillDistanceConfigDataSkillInfo_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetSkillDistanceConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					skillInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (skillInfo == null)
			{
				return 0;
			}
			int num;
			if (skillInfo.IsMagic)
			{
				num = skillInfo.BF_Distance + this.m_heroBattleProperty.MagicSkillDistanceAdd;
			}
			else
			{
				num = skillInfo.BF_Distance + this.m_heroBattleProperty.PhysicalSkillDistanceAdd;
			}
			if (num < 0)
			{
				num = 0;
			}
			return num;
		}

		// Token: 0x06003223 RID: 12835 RVA: 0x000C7D8C File Offset: 0x000C5F8C
		public int GetMovePoint()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetMovePoint_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetMovePoint_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_extraActionMovePoint > 0)
			{
				return this.m_extraActionMovePoint;
			}
			if (this.m_soldierInfo == null)
			{
				return this.m_heroBattleProperty.MovePoint;
			}
			if (this.m_jobInfo == null)
			{
				return this.m_soldierBattleProperty.MovePoint;
			}
			return Math.Min(this.m_heroBattleProperty.MovePoint, this.m_soldierBattleProperty.MovePoint);
		}

		// Token: 0x06003224 RID: 12836 RVA: 0x000C7E54 File Offset: 0x000C6054
		public MoveType GetMoveType()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetMoveType_hotfix != null)
			{
				return (MoveType)this.m_GetMoveType_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_moveType;
		}

		// Token: 0x06003225 RID: 12837 RVA: 0x000C7EC8 File Offset: 0x000C60C8
		public static MoveType ComputeMoveType(ConfigDataJobInfo heroJobInfo, ConfigDataSoldierInfo soldierInfo)
		{
			if (soldierInfo == null)
			{
				return heroJobInfo.MoveType;
			}
			if (heroJobInfo == null)
			{
				return soldierInfo.MoveType;
			}
			return (MoveType)Math.Min((int)heroJobInfo.MoveType, (int)soldierInfo.MoveType);
		}

		// Token: 0x06003226 RID: 12838 RVA: 0x000C7EF8 File Offset: 0x000C60F8
		public static MoveType ComputeDefaultMoveType(ConfigDataHeroInfo heroInfo)
		{
			if (heroInfo == null)
			{
				return MoveType.MoveType_None;
			}
			ConfigDataJobInfo jobInfo = heroInfo.m_jobConnectionInfo.m_jobInfo;
			ConfigDataSoldierInfo soldierInfo = heroInfo.m_soldierInfo;
			return BattleActor.ComputeMoveType(jobInfo, soldierInfo);
		}

		// Token: 0x06003227 RID: 12839 RVA: 0x000C7F28 File Offset: 0x000C6128
		public int GetTotalHealthPoint()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTotalHealthPoint_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetTotalHealthPoint_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroHealthPoint + this.m_soldierTotalHealthPoint;
		}

		// Token: 0x06003228 RID: 12840 RVA: 0x000C7FA4 File Offset: 0x000C61A4
		public int GetTotalHealthPointMax()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTotalHealthPointMax_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetTotalHealthPointMax_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroBattleProperty.HealthPointMax + this.m_soldierBattleProperty.HealthPointMax;
		}

		// Token: 0x06003229 RID: 12841 RVA: 0x000C8028 File Offset: 0x000C6228
		public int GetSoldierCount()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSoldierCount_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetSoldierCount_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_soldierInfo == null)
			{
				return 0;
			}
			return (this.m_soldierTotalHealthPoint + this.m_soldierSingleHealthPointMax - 1) / this.m_soldierSingleHealthPointMax;
		}

		// Token: 0x0600322A RID: 12842 RVA: 0x000C80B8 File Offset: 0x000C62B8
		public void SetLastDamageBySkill(ConfigDataSkillInfo skillInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLastDamageBySkillConfigDataSkillInfo_hotfix != null)
			{
				this.m_SetLastDamageBySkillConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					skillInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_lastDamageBySkillInfo = skillInfo;
			if (skillInfo != null)
			{
				this.m_deathAnimType = skillInfo.DeadAnimType;
			}
		}

		// Token: 0x0600322B RID: 12843 RVA: 0x000C8144 File Offset: 0x000C6344
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
			return this.m_lastDamageBySkillInfo;
		}

		// Token: 0x0600322C RID: 12844 RVA: 0x000C81B8 File Offset: 0x000C63B8
		public void SetFirstDamageTurn(int turn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetFirstDamageTurnInt32_hotfix != null)
			{
				this.m_SetFirstDamageTurnInt32_hotfix.call(new object[]
				{
					this,
					turn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_firstDamageTurn = turn;
		}

		// Token: 0x0600322D RID: 12845 RVA: 0x000C8230 File Offset: 0x000C6430
		public int GetFirstDamageTurn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetFirstDamageTurn_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetFirstDamageTurn_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_firstDamageTurn;
		}

		// Token: 0x0600322E RID: 12846 RVA: 0x000C82A4 File Offset: 0x000C64A4
		public void SetSetisfyCondition(int conditionId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSetisfyConditionInt32_hotfix != null)
			{
				this.m_SetSetisfyConditionInt32_hotfix.call(new object[]
				{
					this,
					conditionId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_satisfyConditions = MathUtility.SetBit(this.m_satisfyConditions, conditionId, true);
		}

		// Token: 0x0600322F RID: 12847 RVA: 0x000C8328 File Offset: 0x000C6528
		public bool IsSatisfyCondition(int conditionId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsSatisfyConditionInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsSatisfyConditionInt32_hotfix.call(new object[]
				{
					this,
					conditionId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return MathUtility.GetBit(this.m_satisfyConditions, conditionId);
		}

		// Token: 0x06003230 RID: 12848 RVA: 0x000C83B0 File Offset: 0x000C65B0
		public int GetDeathAnimType()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDeathAnimType_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetDeathAnimType_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_deathAnimType;
		}

		// Token: 0x06003231 RID: 12849 RVA: 0x000C8424 File Offset: 0x000C6624
		public void SetBeCriticalAttack(bool a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBeCriticalAttackBoolean_hotfix != null)
			{
				this.m_SetBeCriticalAttackBoolean_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isBeCriticalAttack = a;
		}

		// Token: 0x06003232 RID: 12850 RVA: 0x000C849C File Offset: 0x000C669C
		public void SetBeKillAttack(bool a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBeKillAttackBoolean_hotfix != null)
			{
				this.m_SetBeKillAttackBoolean_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isBeKillAttack = a;
		}

		// Token: 0x06003233 RID: 12851 RVA: 0x000C8514 File Offset: 0x000C6714
		public void SetActionCriticalAttack()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetActionCriticalAttack_hotfix != null)
			{
				this.m_SetActionCriticalAttack_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isActionCriticalAttack = true;
		}

		// Token: 0x06003234 RID: 12852 RVA: 0x000C857C File Offset: 0x000C677C
		public void SetActionKillActor()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetActionKillActor_hotfix != null)
			{
				this.m_SetActionKillActor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isActionKillActor = true;
		}

		// Token: 0x06003235 RID: 12853 RVA: 0x000C85E4 File Offset: 0x000C67E4
		public void SetActionDamageActor()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetActionDamageActor_hotfix != null)
			{
				this.m_SetActionDamageActor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isActionDamageActor = true;
		}

		// Token: 0x06003236 RID: 12854 RVA: 0x000C864C File Offset: 0x000C684C
		public bool IsExtraAction()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsExtraAction_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsExtraAction_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isExtraAction;
		}

		// Token: 0x06003237 RID: 12855 RVA: 0x000C86C0 File Offset: 0x000C68C0
		public bool IsExtraActionMoving()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsExtraActionMoving_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsExtraActionMoving_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_extraActionMovePoint > 0;
		}

		// Token: 0x06003238 RID: 12856 RVA: 0x000C8738 File Offset: 0x000C6938
		public short GetActionCount()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetActionCount_hotfix != null)
			{
				return Convert.ToInt16(this.m_GetActionCount_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_actionCount;
		}

		// Token: 0x06003239 RID: 12857 RVA: 0x000C87AC File Offset: 0x000C69AC
		public void IncreaseCombatAttackCount()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IncreaseCombatAttackCount_hotfix != null)
			{
				this.m_IncreaseCombatAttackCount_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_combatAttackCount += 1;
		}

		// Token: 0x0600323A RID: 12858 RVA: 0x000C881C File Offset: 0x000C6A1C
		public short GetCombatAttackCount()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCombatAttackCount_hotfix != null)
			{
				return Convert.ToInt16(this.m_GetCombatAttackCount_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_combatAttackCount;
		}

		// Token: 0x0600323B RID: 12859 RVA: 0x000C8890 File Offset: 0x000C6A90
		public void IncreaseBeCombatAttackCount()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IncreaseBeCombatAttackCount_hotfix != null)
			{
				this.m_IncreaseBeCombatAttackCount_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_beCombatAttackCount += 1;
		}

		// Token: 0x0600323C RID: 12860 RVA: 0x000C8900 File Offset: 0x000C6B00
		public short GetBeCombatAttackCount()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetBeCombatAttackCount_hotfix != null)
			{
				return Convert.ToInt16(this.m_GetBeCombatAttackCount_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_beCombatAttackCount;
		}

		// Token: 0x0600323D RID: 12861 RVA: 0x000C8974 File Offset: 0x000C6B74
		public void IncreaseUseSkillCount()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IncreaseUseSkillCount_hotfix != null)
			{
				this.m_IncreaseUseSkillCount_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_useSkillCount += 1;
		}

		// Token: 0x0600323E RID: 12862 RVA: 0x000C89E4 File Offset: 0x000C6BE4
		public short GetUseSkillCount()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetUseSkillCount_hotfix != null)
			{
				return Convert.ToInt16(this.m_GetUseSkillCount_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_useSkillCount;
		}

		// Token: 0x0600323F RID: 12863 RVA: 0x000C8A58 File Offset: 0x000C6C58
		public void IncreaseKillActorCount()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IncreaseKillActorCount_hotfix != null)
			{
				this.m_IncreaseKillActorCount_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_killActorCount += 1;
		}

		// Token: 0x06003240 RID: 12864 RVA: 0x000C8AC8 File Offset: 0x000C6CC8
		public int GetKillActorCount()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetKillActorCount_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetKillActorCount_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return (int)this.m_killActorCount;
		}

		// Token: 0x06003241 RID: 12865 RVA: 0x000C8B3C File Offset: 0x000C6D3C
		public BattleActor GetKillerActor()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetKillerActor_hotfix != null)
			{
				return (BattleActor)this.m_GetKillerActor_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_killerActor;
		}

		// Token: 0x06003242 RID: 12866 RVA: 0x000C8BB0 File Offset: 0x000C6DB0
		public int GetDieTurn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDieTurn_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetDieTurn_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_dieTurn;
		}

		// Token: 0x06003243 RID: 12867 RVA: 0x000C8C24 File Offset: 0x000C6E24
		public BattleActorSourceType GetSourceType()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSourceType_hotfix != null)
			{
				return (BattleActorSourceType)this.m_GetSourceType_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_sourceType;
		}

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x06003244 RID: 12868 RVA: 0x000C8C98 File Offset: 0x000C6E98
		public GridPosition Position
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Position_hotfix != null)
				{
					return (GridPosition)this.m_get_Position_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_position;
			}
		}

		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x06003245 RID: 12869 RVA: 0x000C8D0C File Offset: 0x000C6F0C
		public GridPosition InitPosition
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_InitPosition_hotfix != null)
				{
					return (GridPosition)this.m_get_InitPosition_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_initPosition;
			}
		}

		// Token: 0x17000E3A RID: 3642
		// (get) Token: 0x06003246 RID: 12870 RVA: 0x000C8D80 File Offset: 0x000C6F80
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

		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x06003247 RID: 12871 RVA: 0x000C8DF4 File Offset: 0x000C6FF4
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
				return this.m_team.Battle;
			}
		}

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x06003248 RID: 12872 RVA: 0x000C8E6C File Offset: 0x000C706C
		public BattleTeam Team
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Team_hotfix != null)
				{
					return (BattleTeam)this.m_get_Team_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_team;
			}
		}

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x06003249 RID: 12873 RVA: 0x000C8EE0 File Offset: 0x000C70E0
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

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x0600324A RID: 12874 RVA: 0x000C8F58 File Offset: 0x000C7158
		public BattleProperty HeroBattleProperty
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_HeroBattleProperty_hotfix != null)
				{
					return (BattleProperty)this.m_get_HeroBattleProperty_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_heroBattleProperty;
			}
		}

		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x0600324B RID: 12875 RVA: 0x000C8FCC File Offset: 0x000C71CC
		public BattleProperty SoldierBattleProperty
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_SoldierBattleProperty_hotfix != null)
				{
					return (BattleProperty)this.m_get_SoldierBattleProperty_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_soldierBattleProperty;
			}
		}

		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x0600324C RID: 12876 RVA: 0x000C9040 File Offset: 0x000C7240
		public int HeroHealthPoint
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_HeroHealthPoint_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_HeroHealthPoint_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_heroHealthPoint;
			}
		}

		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x0600324D RID: 12877 RVA: 0x000C90B4 File Offset: 0x000C72B4
		public int SoldierTotalHealthPoint
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_SoldierTotalHealthPoint_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_SoldierTotalHealthPoint_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_soldierTotalHealthPoint;
			}
		}

		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x0600324E RID: 12878 RVA: 0x000C9128 File Offset: 0x000C7328
		public int SoldierSingleHealthPointMax
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_SoldierSingleHealthPointMax_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_SoldierSingleHealthPointMax_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_soldierSingleHealthPointMax;
			}
		}

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x0600324F RID: 12879 RVA: 0x000C919C File Offset: 0x000C739C
		public uint FightTags
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_FightTags_hotfix != null)
				{
					return Convert.ToUInt32(this.m_get_FightTags_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_fightTags;
			}
		}

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x06003250 RID: 12880 RVA: 0x000C9210 File Offset: 0x000C7410
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
				return this.m_heroLevel;
			}
		}

		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x06003251 RID: 12881 RVA: 0x000C9284 File Offset: 0x000C7484
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
				return this.m_heroStar;
			}
		}

		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x06003252 RID: 12882 RVA: 0x000C92F8 File Offset: 0x000C74F8
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
				return this.m_jobLevel;
			}
		}

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x06003253 RID: 12883 RVA: 0x000C936C File Offset: 0x000C756C
		// (set) Token: 0x06003254 RID: 12884 RVA: 0x000C93E0 File Offset: 0x000C75E0
		public int ActionValue
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_ActionValue_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_ActionValue_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_actionValue;
			}
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_ActionValueInt32_hotfix != null)
				{
					this.m_set_ActionValueInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.m_actionValue = value;
			}
		}

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x06003255 RID: 12885 RVA: 0x000C9458 File Offset: 0x000C7658
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
				return this.m_heroInfo;
			}
		}

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x06003256 RID: 12886 RVA: 0x000C94CC File Offset: 0x000C76CC
		public int HeroId
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_HeroId_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_HeroId_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return (this.m_heroInfo == null) ? 0 : this.m_heroInfo.ID;
			}
		}

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x06003257 RID: 12887 RVA: 0x000C9554 File Offset: 0x000C7754
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
				return this.m_heroArmyInfo;
			}
		}

		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x06003258 RID: 12888 RVA: 0x000C95C8 File Offset: 0x000C77C8
		public int HeroArmyId
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_HeroArmyId_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_HeroArmyId_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return (this.m_heroArmyInfo == null) ? 0 : this.m_heroArmyInfo.ID;
			}
		}

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x06003259 RID: 12889 RVA: 0x000C9650 File Offset: 0x000C7850
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
				return this.m_jobConnectionInfo;
			}
		}

		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x0600325A RID: 12890 RVA: 0x000C96C4 File Offset: 0x000C78C4
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
				return this.m_jobInfo;
			}
		}

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x0600325B RID: 12891 RVA: 0x000C9738 File Offset: 0x000C7938
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
				return this.m_soldierInfo;
			}
		}

		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x0600325C RID: 12892 RVA: 0x000C97AC File Offset: 0x000C79AC
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
				return this.m_soldierArmyInfo;
			}
		}

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x0600325D RID: 12893 RVA: 0x000C9820 File Offset: 0x000C7A20
		public ConfigDataCharImageSkinResourceInfo HeroCharImageSkinResourceInfo
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_HeroCharImageSkinResourceInfo_hotfix != null)
				{
					return (ConfigDataCharImageSkinResourceInfo)this.m_get_HeroCharImageSkinResourceInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_heroCharImageSkinResourceInfo;
			}
		}

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x0600325E RID: 12894 RVA: 0x000C9894 File Offset: 0x000C7A94
		public ConfigDataModelSkinResourceInfo HeroModelSkinResourceInfo
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_HeroModelSkinResourceInfo_hotfix != null)
				{
					return (ConfigDataModelSkinResourceInfo)this.m_get_HeroModelSkinResourceInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_heroModelSkinResourceInfo;
			}
		}

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x0600325F RID: 12895 RVA: 0x000C9908 File Offset: 0x000C7B08
		public ConfigDataModelSkinResourceInfo SoldierModelSkinResourceInfo
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_SoldierModelSkinResourceInfo_hotfix != null)
				{
					return (ConfigDataModelSkinResourceInfo)this.m_get_SoldierModelSkinResourceInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_soldierModelSkinResourceInfo;
			}
		}

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x06003260 RID: 12896 RVA: 0x000C997C File Offset: 0x000C7B7C
		public int PlayerIndex
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_PlayerIndex_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_PlayerIndex_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_playerIndex;
			}
		}

		// Token: 0x06003261 RID: 12897 RVA: 0x000C99F0 File Offset: 0x000C7BF0
		private void FindMoveAndAttackRegion(int distance, int shape)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindMoveAndAttackRegionInt32Int32_hotfix != null)
			{
				this.m_FindMoveAndAttackRegionInt32Int32_hotfix.call(new object[]
				{
					this,
					distance,
					shape
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleBase battle = this.Battle;
			BattleMap map = battle.Map;
			map.ClearRegion();
			List<GridPosition> list = battle.AllocateTempGridPositionList();
			List<GridPosition> list2 = battle.AllocateTempGridPositionList();
			this.FindMoveRegion(this.m_position, list);
			foreach (GridPosition p in list)
			{
				BattleActor actor = map.GetActor(p);
				if (actor == null || actor == this)
				{
					map.SetRegionBit(p, 1);
				}
			}
			foreach (GridPosition gridPosition in list)
			{
				BattleActor actor2 = map.GetActor(gridPosition);
				if (actor2 == null || actor2 == this)
				{
					list2.Clear();
					battle.FindAttackRegion(gridPosition, distance, shape, list2);
					foreach (GridPosition p2 in list2)
					{
						map.SetRegionBit(p2, 2);
					}
				}
			}
			battle.FreeTempGridPositionList(list2);
			battle.FreeTempGridPositionList(list);
		}

		// Token: 0x06003262 RID: 12898 RVA: 0x000C9BD4 File Offset: 0x000C7DD4
		private bool FindRandomEmptyPosition(int attackDistance, int shape, ref GridPosition position)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindRandomEmptyPositionInt32Int32GridPosition__hotfix != null)
			{
				return LuaDelegation.Lua_BlackJack_ProjectL_Battle_BattleActor_FindRandomEmptyPosition_Int32_Int32_GridPosition(this, this.m_FindRandomEmptyPositionInt32Int32GridPosition__hotfix, attackDistance, shape, ref position);
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleBase battle = this.Battle;
			BattleMap map = battle.Map;
			List<GridPosition> list = battle.AllocateTempGridPositionList();
			battle.FindAttackRegion(this.m_position, attackDistance, shape, list);
			int num = this.GetAIRandomNumber().Next(0, list.Count);
			for (int i = 0; i < list.Count; i++)
			{
				int index = (num + i) % list.Count;
				GridPosition gridPosition = list[index];
				if (map.GetActor(gridPosition) == null)
				{
					position = gridPosition;
					battle.FreeTempGridPositionList(list);
					return true;
				}
			}
			battle.FreeTempGridPositionList(list);
			return false;
		}

		// Token: 0x06003263 RID: 12899 RVA: 0x000C9CC0 File Offset: 0x000C7EC0
		private GridPosition FindAttackPosition(int attackDistance, int shape, GridPosition targetPos, bool checkMoveRegion, bool farAway)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindAttackPositionInt32Int32GridPositionBooleanBoolean_hotfix != null)
			{
				return (GridPosition)this.m_FindAttackPositionInt32Int32GridPositionBooleanBoolean_hotfix.call(new object[]
				{
					this,
					attackDistance,
					shape,
					targetPos,
					checkMoveRegion,
					farAway
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.Battle.IsEnableDebugLog())
			{
				DebugUtility.Log(string.Format("!@# {6} findAttackPosition(), SelfPos={3},{4} , MovePoint={5}, attackDistance={0}, targetPos={1},{2}.", new object[]
				{
					attackDistance,
					targetPos.x,
					targetPos.y,
					this.m_position.x,
					this.m_position.y,
					this.GetMovePoint(),
					this.InstanceID
				}));
			}
			BattleBase battle = this.Battle;
			BattleMap map = battle.Map;
			GridPosition result = GridPosition.Null;
			int num = 10000;
			int num2 = 0;
			int num3 = 10000;
			List<GridPosition> list = battle.AllocateTempGridPositionList();
			battle.FindAttackRegion(targetPos, attackDistance, shape, list);
			foreach (GridPosition gridPosition in list)
			{
				if (checkMoveRegion)
				{
					if (!map.HasRegionBit(gridPosition, 1))
					{
						continue;
					}
				}
				else if (map.GetMovePointCost(gridPosition, this.GetMoveType()) <= 0)
				{
					continue;
				}
				BattleActor actor = map.GetActor(gridPosition);
				if (actor == null || actor == this)
				{
					int num4 = GridPosition.Distance(this.m_position, gridPosition);
					int num5 = GridPosition.Distance(gridPosition, targetPos);
					if (farAway)
					{
						if (num5 > num2 || (num5 == num2 && num4 < num))
						{
							num = num4;
							num2 = num5;
							result = gridPosition;
						}
					}
					else if (num5 < num3 || (num5 == num3 && num4 < num))
					{
						num = num4;
						num3 = num5;
						result = gridPosition;
					}
				}
			}
			battle.FreeTempGridPositionList(list);
			return result;
		}

		// Token: 0x06003264 RID: 12900 RVA: 0x000C9F50 File Offset: 0x000C8150
		private static int ComputeActorScoreDamage(BattleActor a, int param)
		{
			if (a.HasFightTag(FightTag.FightTag_Hide))
			{
				return 0;
			}
			int totalHealthPoint = a.GetTotalHealthPoint();
			int totalHealthPointMax = a.GetTotalHealthPointMax();
			if (totalHealthPoint > 0 && totalHealthPointMax > 0)
			{
				return 1000000 - (int)((long)totalHealthPoint * 1000000L / (long)totalHealthPointMax);
			}
			return -1;
		}

		// Token: 0x06003265 RID: 12901 RVA: 0x000C9FA0 File Offset: 0x000C81A0
		private static int ComputeActorScoreHeal(BattleActor a, int param)
		{
			int totalHealthPoint = a.GetTotalHealthPoint();
			int totalHealthPointMax = a.GetTotalHealthPointMax();
			if (totalHealthPoint <= 0 || totalHealthPointMax <= 0)
			{
				return -1;
			}
			int num = (int)((long)totalHealthPoint * 1000000L / (long)totalHealthPointMax);
			if (num <= 700000)
			{
				return 1000000 - num;
			}
			return -1;
		}

		// Token: 0x06003266 RID: 12902 RVA: 0x000C9FF0 File Offset: 0x000C81F0
		private int ComputeActorScoreBuff(BattleActor a, int param)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeActorScoreBuffBattleActorInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_ComputeActorScoreBuffBattleActorInt32_hotfix.call(new object[]
				{
					this,
					a,
					param
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (a == this)
			{
				return 0;
			}
			if (a.HasBuff(param))
			{
				return -1;
			}
			int totalHealthPoint = a.GetTotalHealthPoint();
			int totalHealthPointMax = a.GetTotalHealthPointMax();
			if (totalHealthPoint > 0 && totalHealthPointMax > 0)
			{
				int num = (int)((long)totalHealthPoint * 1000000L / (long)totalHealthPointMax);
				return 1000001 - num;
			}
			return -1;
		}

		// Token: 0x06003267 RID: 12903 RVA: 0x000CA0C8 File Offset: 0x000C82C8
		private BattleActor SelectNearestTarget(BattleTeam team)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SelectNearestTargetBattleTeam_hotfix != null)
			{
				return (BattleActor)this.m_SelectNearestTargetBattleTeam_hotfix.call(new object[]
				{
					this,
					team
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleActor result = null;
			int num = 10000;
			int num2 = 10000000;
			foreach (BattleActor battleActor in team.GetActors())
			{
				if (battleActor.CanBeTarget())
				{
					if (battleActor != this)
					{
						int num3 = GridPosition.Distance(this.m_position, battleActor.m_position);
						if (num3 < num)
						{
							num = num3;
							result = battleActor;
						}
						else if (num3 == num)
						{
							int num4 = battleActor.GetTotalHealthPoint() * 1000000 / battleActor.GetTotalHealthPointMax();
							if (num4 < num2)
							{
								num2 = num4;
								result = battleActor;
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06003268 RID: 12904 RVA: 0x000CA208 File Offset: 0x000C8408
		private RandomNumber GetAIRandomNumber()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAIRandomNumber_hotfix != null)
			{
				return (RandomNumber)this.m_GetAIRandomNumber_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsPlayerActor())
			{
				return this.Battle.AIRandomNumber1;
			}
			return this.Battle.AIRandomNumber2;
		}

		// Token: 0x06003269 RID: 12905 RVA: 0x000CA298 File Offset: 0x000C8498
		private BattleTeam GetSkillTargetTeam(ConfigDataSkillInfo skillInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSkillTargetTeamConfigDataSkillInfo_hotfix != null)
			{
				return (BattleTeam)this.m_GetSkillTargetTeamConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					skillInfo
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (skillInfo.BF_TargetType == SkillTargetType.SkillTargetType_Ally || skillInfo.BF_TargetType == SkillTargetType.SkillTargetType_NoNpcAlly || skillInfo.BF_TargetType == SkillTargetType.SkillTargetType_NoSelfNpcAlly)
			{
				return this.m_team;
			}
			return this.m_team.GetOtherTeam();
		}

		// Token: 0x0600326A RID: 12906 RVA: 0x000CA34C File Offset: 0x000C854C
		private bool CanAttackOrUseSkill()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAttackOrUseSkill_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CanAttackOrUseSkill_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return !this.IsDeadOrRetreat() && !this.IsExtraActionMoving();
		}

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x0600326B RID: 12907 RVA: 0x000CA3D4 File Offset: 0x000C85D4
		// (set) Token: 0x0600326C RID: 12908 RVA: 0x000CA448 File Offset: 0x000C8648
		public BehaviorGroup Group
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Group_hotfix != null)
				{
					return (BehaviorGroup)this.m_get_Group_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Group>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_GroupBehaviorGroup_hotfix != null)
				{
					this.m_set_GroupBehaviorGroup_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Group>k__BackingField = value;
			}
		}

		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x0600326D RID: 12909 RVA: 0x000CA4C0 File Offset: 0x000C86C0
		public int GroupId
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_GroupId_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_GroupId_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_groupId;
			}
		}

		// Token: 0x0600326E RID: 12910 RVA: 0x000CA534 File Offset: 0x000C8734
		public void IncreaseBeAttackedCount()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IncreaseBeAttackedCount_hotfix != null)
			{
				this.m_IncreaseBeAttackedCount_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_beAttackedCountOfTurns == null)
			{
				this.m_beAttackedCountOfTurns = new int[this.Battle.TurnMax * 2];
			}
			if (this.Battle.Turn >= this.m_beAttackedCountOfTurns.Length)
			{
				if (this.Battle.IsEnableDebugLog())
				{
					DebugUtility.LogError(string.Format("Battle's turn number {0} is greater than the TurnMax.", this.Battle.Turn));
				}
				return;
			}
			this.m_beAttackedCountOfTurns[this.Battle.Turn]++;
		}

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x0600326F RID: 12911 RVA: 0x000CA61C File Offset: 0x000C881C
		private bool IsAttackedByEnemy
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_IsAttackedByEnemy_hotfix != null)
				{
					return Convert.ToBoolean(this.m_get_IsAttackedByEnemy_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				if (this.m_beAttackedCountOfTurns == null)
				{
					return false;
				}
				foreach (int num in this.m_beAttackedCountOfTurns)
				{
					if (num > 0)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x06003270 RID: 12912 RVA: 0x000CA6C0 File Offset: 0x000C88C0
		private bool IsAttackedByEnemyInLastTrun
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_IsAttackedByEnemyInLastTrun_hotfix != null)
				{
					return Convert.ToBoolean(this.m_get_IsAttackedByEnemyInLastTrun_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				if (this.m_beAttackedCountOfTurns == null)
				{
					return false;
				}
				int num = this.Battle.Turn - 1;
				return num >= 0 && this.Battle.Turn < this.m_beAttackedCountOfTurns.Length && (this.m_beAttackedCountOfTurns[num] > 0 || this.m_beAttackedCountOfTurns[this.Battle.Turn] > 0);
			}
		}

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x06003271 RID: 12913 RVA: 0x000CA790 File Offset: 0x000C8990
		public string InstanceID
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_InstanceID_hotfix != null)
				{
					return (string)this.m_get_InstanceID_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				ConfigDataSkillInfo behaviorSelectSkillInfo = this.BehaviorSelectSkillInfo;
				return string.Format("[{0},{1}:{2}_{3}_{4}]{5}{6}", new object[]
				{
					this.m_position.x,
					this.m_position.y,
					this.TeamNumber,
					this.HeroInfo.Name,
					this.m_id,
					(this.m_curBehaviorCfg != null) ? string.Format("[B:{0}:{1}..]", this.m_curBehaviorCfg.ID, this.m_curBehaviorCfg.Desc.Substring(0, Math.Min(5, this.m_curBehaviorCfg.Desc.Length))) : string.Empty,
					(behaviorSelectSkillInfo != null) ? string.Format("[{0}:{1}]", behaviorSelectSkillInfo.ID, behaviorSelectSkillInfo.Name) : string.Empty
				});
			}
		}

		// Token: 0x06003272 RID: 12914 RVA: 0x000CA8EC File Offset: 0x000C8AEC
		public int GetBehaviorId()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetBehaviorId_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetBehaviorId_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return (this.m_curBehaviorCfg != null) ? this.m_curBehaviorCfg.ID : -1;
		}

		// Token: 0x06003273 RID: 12915 RVA: 0x000CA974 File Offset: 0x000C8B74
		public void SetBehavior(int id)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBehaviorInt32_hotfix != null)
			{
				this.m_SetBehaviorInt32_hotfix.call(new object[]
				{
					this,
					id
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (id < 1)
			{
				return;
			}
			if (this.m_curBehaviorCfg != null && this.m_curBehaviorCfg.ID == id)
			{
				return;
			}
			ConfigDataBehavior configDataBehavior = this.Battle.ConfigDataLoader.GetConfigDataBehavior(id);
			if (configDataBehavior == null)
			{
				if (this.Battle.IsEnableDebugLog())
				{
					DebugUtility.LogError(string.Format("Actor {1} failed to find behavior {0} conifg.", id, this.InstanceID));
				}
				return;
			}
			if (this.m_curBehaviorCfg == null || this.m_curBehaviorCfg.MoveTarget != configDataBehavior.MoveTarget || this.m_curBehaviorCfg.MTParam != configDataBehavior.MTParam)
			{
				this.m_moveTarget = null;
			}
			this.m_curBehaviorCfg = configDataBehavior;
			this.m_attackTarget = null;
			this.m_attackSkillIndex = -1;
			this.m_beAttackedCountOfTurns = null;
			this.SetBehaviorState(BattleActor.BehaviorState.Move);
		}

		// Token: 0x06003274 RID: 12916 RVA: 0x000CAAB4 File Offset: 0x000C8CB4
		private void SetBehaviorState(BattleActor.BehaviorState state)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBehaviorStateBehaviorState_hotfix != null)
			{
				this.m_SetBehaviorStateBehaviorState_hotfix.call(new object[]
				{
					this,
					state
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curBehaviorState == state)
			{
				return;
			}
			this.m_curBehaviorState = state;
		}

		// Token: 0x06003275 RID: 12917 RVA: 0x000CAB38 File Offset: 0x000C8D38
		public bool CheckBehaviorCondition(BehaviorCondition condition, ConfigDataBehavior.ParamData param)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckBehaviorConditionBehaviorConditionParamData_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CheckBehaviorConditionBehaviorConditionParamData_hotfix.call(new object[]
				{
					this,
					condition,
					param2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataBehavior.ParamData param = param2;
			if (param == null)
			{
				if (this.Battle.IsEnableDebugLog())
				{
					DebugUtility.LogError("CheckBehaviorCondition param is null.");
				}
				return false;
			}
			if (condition == BehaviorCondition.BehaviorCondition_AttackedByEnemy)
			{
				return this.IsAttackedByEnemy;
			}
			if (condition == BehaviorCondition.BehaviorCondition_MemberAttackedByEnemy)
			{
				BattleActor actorById = this.m_team.GetActorById(param._int);
				return actorById != null && !actorById.IsDeadOrRetreat() && actorById.IsAttackedByEnemy;
			}
			if (condition == BehaviorCondition.BehaviorCondition_AttackedByEnemyInLastTurn)
			{
				return this.IsAttackedByEnemyInLastTrun;
			}
			if (condition == BehaviorCondition.BehaviorCondition_EnemyEnterMoveAndAttackRange)
			{
				List<BattleActor> list = this.FindActorsInCanAttackAndTouchRange(BattleActor.FindActorsAlive(this.m_team.GetOtherTeam().GetActors()), this.m_position, this.GetMaxAttackDistance(), 0, true);
				return list != null && list.Count > 0;
			}
			if (condition == BehaviorCondition.BehaviorCondition_EnemyEnterMoveAndAttackRangeExcept)
			{
				List<BattleActor> list2 = this.FindActorsInCanAttackAndTouchRange(this.FindActorsByIDFilter(BattleActor.FindActorsAlive(this.m_team.GetOtherTeam().GetActors()), null, param._ints), this.m_position, this.GetMaxAttackDistance(), 0, true);
				return list2 != null && list2.Count > 0;
			}
			if (condition == BehaviorCondition.BehaviorCondition_NoEnemyEnterMoveAndAttackRangeExcept)
			{
				List<BattleActor> list3 = this.FindActorsInCanAttackAndTouchRange(this.FindActorsByIDFilter(BattleActor.FindActorsAlive(this.m_team.GetOtherTeam().GetActors()), null, param._ints), this.m_position, this.GetMaxAttackDistance(), 0, true);
				return list3 == null || list3.Count == 0;
			}
			if (condition == BehaviorCondition.BehaviorCondition_Never)
			{
				return false;
			}
			if (condition == BehaviorCondition.BehaviorCondition_EnemyEnterMoveAndAttackRangeOfMoveTarget)
			{
				if (this.m_moveTarget == null)
				{
					return false;
				}
				List<BattleActor> list4 = this.FindActorsInCanAttackAndTouchRange(BattleActor.FindActorsAlive(this.m_team.GetOtherTeam().GetActors()), this.m_moveTarget.Position, this.GetMaxAttackDistance(), 0, true);
				if (this.Battle.IsEnableDebugLog())
				{
					DebugUtility.Log(string.Format("!@# {0} 's BehaviorCondition_EnemyEnterMoveAndAttackRangeOfMoveTarget is {1}", this.InstanceID, list4 != null && list4.Count > 0));
				}
				return list4 != null && list4.Count > 0;
			}
			else
			{
				if (condition == BehaviorCondition.BehaviorCondition_NoEnemyEnterMoveAndAttackRange)
				{
					List<BattleActor> list5 = this.FindActorsInCanAttackAndTouchRange(BattleActor.FindActorsAlive(this.m_team.GetOtherTeam().GetActors()), this.Position, this.GetMaxAttackDistance(), 0, true);
					return list5 == null || list5.Count == 0;
				}
				if (condition == BehaviorCondition.BehaviorCondition_Never)
				{
					return false;
				}
				if (condition == BehaviorCondition.BehaviorCondition_NoEnemyEnterMoveAndAttackRangeOfMoveTarget)
				{
					if (this.m_moveTarget == null)
					{
						return true;
					}
					List<BattleActor> list6 = this.FindActorsInCanAttackAndTouchRange(BattleActor.FindActorsAlive(this.m_team.GetOtherTeam().GetActors()), this.m_moveTarget.Position, this.GetMaxAttackDistance(), 0, true);
					return list6 == null || list6.Count == 0;
				}
				else
				{
					if (condition == BehaviorCondition.BehaviorCondition_EveryTurn)
					{
						return !this.IsDeadOrRetreat();
					}
					if (condition == BehaviorCondition.BehaviorCondition_EnemyHPPercentLessEqual)
					{
						return this.m_attackTarget == null || this.m_attackTarget.Actor == null || this.m_attackTarget.Actor.TotalHPPercent <= param._float;
					}
					if (condition == BehaviorCondition.BehaviorCondition_MemberHPPercentLessEqual)
					{
						BattleActor actorById2 = this.m_team.GetActorById(param._int);
						return actorById2 != null && actorById2.TotalHPPercent <= param._float;
					}
					if (condition == BehaviorCondition.BehaviorCondition_DistanceToMoveTargetLestEqual)
					{
						return this.m_moveTarget != null && (float)GridPosition.Distance(this.Position, this.m_moveTarget.Position) <= param._float;
					}
					if (condition == BehaviorCondition.BehaviorCondition_TurnN)
					{
						return this.Battle.Turn == param._int;
					}
					if (condition == BehaviorCondition.BehaviorCondition_SelfHPPercentLessEqual)
					{
						return this.TotalHPPercent <= param._float;
					}
					if (condition == BehaviorCondition.BehaviorCondition_SelfHPPercentGreaterEqual)
					{
						return this.TotalHPPercent >= param._float;
					}
					if (condition == BehaviorCondition.BehaviorCondition_LeaderStartAttack)
					{
						return this.Group.Leader != null && this.Group.Leader != this && this.Group.Leader.m_curBehaviorState == BattleActor.BehaviorState.Attack;
					}
					if (condition == BehaviorCondition.BehaviorCondition_LeaderStopAttack)
					{
						return this.Group.Leader == null || this.Group.Leader.m_curBehaviorState == BattleActor.BehaviorState.Move;
					}
					if (condition == BehaviorCondition.BehaviorCondition_DoingBehaviorN)
					{
						return this.NextBehaviorByChangeRules == param._int;
					}
					if (condition == BehaviorCondition.BehaviorCondition_HeroNExist)
					{
						return this.m_team.GetActors().Find((BattleActor a) => a.TotalHPPercent > 0f && a.HeroInfo.ID == param._int) != null || this.m_team.GetOtherTeam().GetActors().Find((BattleActor a) => a.TotalHPPercent > 0f && a.HeroInfo.ID == param._int) != null;
					}
					if (condition == BehaviorCondition.BehaviorCondition_FoundEnemyWithBuffN)
					{
						List<BattleActor> list7 = this.FindActorsWithBuffN(this.m_team.GetOtherTeam().GetActors(), param._int);
						return list7 != null && list7.Count > 0;
					}
					if (condition == BehaviorCondition.BehaviorCondition_NoEnemyWithBuffN)
					{
						List<BattleActor> list8 = this.FindActorsWithBuffN(this.m_team.GetOtherTeam().GetActors(), param._int);
						return list8 == null || list8.Count == 0;
					}
					if (this.Battle.IsEnableDebugLog())
					{
						DebugUtility.LogError(string.Format("{0} has an unknown behavior condition: {1} in Behavior[{2}]", this.InstanceID, condition, this.m_curBehaviorCfg.ID));
					}
					return false;
				}
			}
		}

		// Token: 0x06003276 RID: 12918 RVA: 0x000CB15C File Offset: 0x000C935C
		private void DoBehaviorChangeRules()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DoBehaviorChangeRules_hotfix != null)
			{
				this.m_DoBehaviorChangeRules_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int nextBehaviorByChangeRules = this.NextBehaviorByChangeRules;
			if (nextBehaviorByChangeRules > 0)
			{
				this.SetBehavior(nextBehaviorByChangeRules);
			}
		}

		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x06003277 RID: 12919 RVA: 0x000CB1D4 File Offset: 0x000C93D4
		private int NextBehaviorByChangeRules
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_NextBehaviorByChangeRules_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_NextBehaviorByChangeRules_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				if (this.m_curBehaviorCfg == null)
				{
					return -1;
				}
				if (this.m_curBehaviorCfg.BehaviorChangeRules.Count == 0)
				{
					return this.m_curBehaviorCfg.ID;
				}
				foreach (int key in this.m_curBehaviorCfg.BehaviorChangeRules)
				{
					ConfigDataBehaviorChangeRule configDataBehaviorChangeRule = this.Battle.ConfigDataLoader.GetConfigDataBehaviorChangeRule(key);
					if (configDataBehaviorChangeRule != null)
					{
						if (this.CheckBehaviorCondition(configDataBehaviorChangeRule.ChangeCondition, configDataBehaviorChangeRule.CCParamData))
						{
							return configDataBehaviorChangeRule.NextBehaviorID;
						}
					}
				}
				return this.m_curBehaviorCfg.ID;
			}
		}

		// Token: 0x06003278 RID: 12920 RVA: 0x000CB308 File Offset: 0x000C9508
		public GridPosition FindEmptyGridInCanAttackAndTouchRange(GridPosition startPoint, int attackDistance, int shape)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindEmptyGridInCanAttackAndTouchRangeGridPositionInt32Int32_hotfix != null)
			{
				return (GridPosition)this.m_FindEmptyGridInCanAttackAndTouchRangeGridPositionInt32Int32_hotfix.call(new object[]
				{
					this,
					startPoint,
					attackDistance,
					shape
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleBase battle = this.Battle;
			BattleMap map = battle.Map;
			List<GridPosition> list = new List<GridPosition>();
			List<GridPosition> list2 = new List<GridPosition>();
			this.FindMoveRegion(startPoint, list);
			foreach (GridPosition gridPosition in list)
			{
				if (map.GetActor(gridPosition) != null)
				{
					return gridPosition;
				}
			}
			foreach (GridPosition start in list)
			{
				list2.Clear();
				battle.FindAttackRegion(start, attackDistance, shape, list2);
				foreach (GridPosition gridPosition2 in list2)
				{
					if (map.GetActor(gridPosition2) != null)
					{
						return gridPosition2;
					}
				}
			}
			return GridPosition.Null;
		}

		// Token: 0x06003279 RID: 12921 RVA: 0x000CB4D4 File Offset: 0x000C96D4
		public List<BattleActor> FindActorsInCanAttackAndTouchRange(List<BattleActor> destActors, GridPosition startPoint, int attackDistance, int shape, bool excludeSelf = true)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindActorsInCanAttackAndTouchRangeList`1GridPositionInt32Int32Boolean_hotfix != null)
			{
				return (List<BattleActor>)this.m_FindActorsInCanAttackAndTouchRangeList`1GridPositionInt32Int32Boolean_hotfix.call(new object[]
				{
					this,
					destActors,
					startPoint,
					attackDistance,
					shape,
					excludeSelf
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<BattleActor> list = new List<BattleActor>();
			if (destActors == null || destActors.Count == 0)
			{
				return list;
			}
			BattleBase battle = this.Battle;
			BattleMap map = battle.Map;
			List<GridPosition> list2 = new List<GridPosition>();
			List<GridPosition> list3 = new List<GridPosition>();
			this.FindMoveRegion(startPoint, list2);
			foreach (GridPosition p in list2)
			{
				BattleActor actor = map.GetActor(p);
				if (actor != null)
				{
					if (!excludeSelf || actor != this)
					{
						if (destActors.Contains(actor) && !list.Contains(actor))
						{
							list.Add(actor);
						}
					}
				}
			}
			foreach (GridPosition gridPosition in list2)
			{
				BattleActor actor2 = map.GetActor(gridPosition);
				if (actor2 == null || actor2 == this)
				{
					list3.Clear();
					battle.FindAttackRegion(gridPosition, attackDistance, shape, list3);
					foreach (GridPosition p2 in list3)
					{
						BattleActor actor3 = map.GetActor(p2);
						if (actor3 != null)
						{
							if (!excludeSelf || actor3 != this)
							{
								if (destActors.Contains(actor3) && !list.Contains(actor3))
								{
									list.Add(actor3);
								}
							}
						}
					}
				}
			}
			return list;
		}

		// Token: 0x0600327A RID: 12922 RVA: 0x000CB76C File Offset: 0x000C996C
		private GridPosition FindFarthestPosition(List<GridPosition> positions, GridPosition startPos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindFarthestPositionList`1GridPosition_hotfix != null)
			{
				return (GridPosition)this.m_FindFarthestPositionList`1GridPosition_hotfix.call(new object[]
				{
					this,
					positions,
					startPos2
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GridPosition startPos = startPos2;
			BattleActor $this = this;
			if (positions.Count == 0)
			{
				return GridPosition.Null;
			}
			List<GridPosition> path = new List<GridPosition>(100);
			return Find.MaxInt<GridPosition>(positions, (GridPosition p) => (!$this.FindPath(startPos, p, int.MaxValue, 0, path, false)) ? int.MinValue : path.Count);
		}

		// Token: 0x0600327B RID: 12923 RVA: 0x000CB83C File Offset: 0x000C9A3C
		private GridPosition FindNearestPosition(List<GridPosition> positions, GridPosition startPos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindNearestPositionList`1GridPosition_hotfix != null)
			{
				return (GridPosition)this.m_FindNearestPositionList`1GridPosition_hotfix.call(new object[]
				{
					this,
					positions,
					startPos2
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GridPosition startPos = startPos2;
			BattleActor $this = this;
			if (positions.Count == 0)
			{
				return GridPosition.Null;
			}
			List<GridPosition> path = new List<GridPosition>(100);
			return Find.MinInt<GridPosition>(positions, (GridPosition p) => (!$this.FindPath(startPos, p, int.MaxValue, 0, path, false)) ? int.MaxValue : path.Count);
		}

		// Token: 0x0600327C RID: 12924 RVA: 0x000CB90C File Offset: 0x000C9B0C
		private BattleActor FindNearestActor(List<BattleActor> actors, GridPosition startPos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindNearestActorList`1GridPosition_hotfix != null)
			{
				return (BattleActor)this.m_FindNearestActorList`1GridPosition_hotfix.call(new object[]
				{
					this,
					actors,
					startPos2
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GridPosition startPos = startPos2;
			BattleActor $this = this;
			if (actors.Count == 0)
			{
				return null;
			}
			List<GridPosition> path = new List<GridPosition>(100);
			return Find.MinInt<BattleActor>(actors, (BattleActor a) => (!$this.FindPath(startPos, a.Position, int.MaxValue, 0, path, false)) ? int.MaxValue : path.Count);
		}

		// Token: 0x0600327D RID: 12925 RVA: 0x000CB9D8 File Offset: 0x000C9BD8
		private BehaviorTarget DoSelectTarget(SelectTarget st, ConfigDataBehavior.ParamData param)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DoSelectTargetSelectTargetParamData_hotfix != null)
			{
				return (BehaviorTarget)this.m_DoSelectTargetSelectTargetParamData_hotfix.call(new object[]
				{
					this,
					st,
					param
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (st == SelectTarget.SelectTarget_MemberIndex)
			{
				List<BattleActor> actors = this.Team.GetActors();
				if (param._int < 0 || param._int >= actors.Count)
				{
					if (this.Battle.IsEnableDebugLog())
					{
						DebugUtility.LogError(string.Format("{0} SelectMoveTarget() MemberIndex {1} is invalid.", this.InstanceID, param._int));
					}
					return null;
				}
				BattleActor battleActor = actors[param._int];
				if (battleActor != this && !battleActor.IsDeadOrRetreat())
				{
					return new BehaviorTarget(battleActor);
				}
				battleActor = this.FindNearestActor(BattleActor.FindActorsAlive(this.m_team.GetActors()), this.Position);
				if (battleActor != null)
				{
					return new BehaviorTarget(battleActor);
				}
			}
			else if (st == SelectTarget.SelectTarget_MemberHeroID)
			{
				BattleActor battleActor2 = this.Team.GetActorByHeroId(param._int, false);
				if (battleActor2 != null && battleActor2 != this && !battleActor2.IsDeadOrRetreat())
				{
					return new BehaviorTarget(battleActor2);
				}
				battleActor2 = this.FindNearestActor(BattleActor.FindActorsAlive(this.m_team.GetActors()), this.Position);
				if (battleActor2 != null)
				{
					return new BehaviorTarget(battleActor2);
				}
			}
			else if (st == SelectTarget.SelectTarget_EnemyIDFilter)
			{
				BattleActor battleActor3 = this.DefaultSelectDamageSkillTarget(this.FindActorsInCanAttackAndTouchRange(this.FindActorsByIDFilter(BattleActor.FindActorsAlive(this.m_team.GetOtherTeam().GetActors()), param._ints, param._ints2), this.Position, this.GetMaxAttackDistance(), 0, true));
				if (battleActor3 != null)
				{
					return new BehaviorTarget(battleActor3);
				}
				battleActor3 = this.DefaultSelectDamageSkillTarget(this.FindActorsByIDFilter(BattleActor.FindActorsAlive(this.m_team.GetOtherTeam().GetActors()), param._ints, param._ints2));
				if (battleActor3 != null)
				{
					return new BehaviorTarget(battleActor3);
				}
			}
			return null;
		}

		// Token: 0x0600327E RID: 12926 RVA: 0x000CBC18 File Offset: 0x000C9E18
		private List<BattleActor> FindActorsByIDFilter(List<BattleActor> actors, int[] priorIDs, int[] excludeIDs)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindActorsByIDFilterList`1Int32beInt32be_hotfix != null)
			{
				return (List<BattleActor>)this.m_FindActorsByIDFilterList`1Int32beInt32be_hotfix.call(new object[]
				{
					this,
					actors,
					priorIDs,
					excludeIDs
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<BattleActor> list = new List<BattleActor>(actors.Count);
			List<BattleActor> list2 = new List<BattleActor>(actors.Count);
			foreach (BattleActor battleActor in actors)
			{
				if (!BattleActor.Contains(excludeIDs, battleActor.HeroInfo.ID))
				{
					if (BattleActor.Contains(priorIDs, battleActor.HeroInfo.ID))
					{
						list2.Add(battleActor);
					}
					else
					{
						list.Add(battleActor);
					}
				}
			}
			if (list2.Count > 0)
			{
				return list2;
			}
			return list;
		}

		// Token: 0x0600327F RID: 12927 RVA: 0x000CBD64 File Offset: 0x000C9F64
		private static bool Contains(int[] target, int nr)
		{
			if (target == null)
			{
				return false;
			}
			for (int i = 0; i < target.Length; i++)
			{
				if (target[i] == nr)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06003280 RID: 12928 RVA: 0x000CBD9C File Offset: 0x000C9F9C
		private void SelectMoveTarget()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SelectMoveTarget_hotfix != null)
			{
				this.m_SelectMoveTarget_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_moveTarget != null && (this.m_moveTarget.Actor == null || !this.m_moveTarget.Actor.IsDeadOrRetreat()))
			{
				return;
			}
			if (this.m_curBehaviorCfg == null)
			{
				if (this.Battle.IsEnableDebugLog())
				{
					DebugUtility.LogError("SelectMoveTarget() m_curBehaviorCfg is null.");
				}
				return;
			}
			if (this.m_curBehaviorCfg.MoveTarget == SelectTarget.SelectTarget_EnemyNearest)
			{
				BattleActor battleActor = this.FindNearestActor(BattleActor.FindActorsAlive(this.m_team.GetOtherTeam().GetActors()), this.Position);
				if (battleActor == null)
				{
					return;
				}
				if (this.Battle.IsEnableDebugLog())
				{
					DebugUtility.Log(string.Format("!@# {0} 's nearest actor is {1}", this.InstanceID, battleActor.InstanceID));
				}
				this.m_moveTarget = new BehaviorTarget(battleActor);
			}
			else if (this.m_curBehaviorCfg.MoveTarget == SelectTarget.SelectTarget_SelfPosition)
			{
				this.m_moveTarget = new BehaviorTarget(this.Position);
			}
			else if (this.m_curBehaviorCfg.MoveTarget == SelectTarget.SelectTarget_PositionNearest)
			{
				this.m_moveTarget = new BehaviorTarget(this.FindNearestPosition(this.m_curBehaviorCfg.MTParamData._GridPositions, this.Position));
			}
			else if (this.m_curBehaviorCfg.MoveTarget == SelectTarget.SelectTarget_MemberIndex || this.m_curBehaviorCfg.MoveTarget == SelectTarget.SelectTarget_MemberHeroID || this.m_curBehaviorCfg.MoveTarget == SelectTarget.SelectTarget_EnemyIDFilter)
			{
				this.m_moveTarget = this.DoSelectTarget(this.m_curBehaviorCfg.MoveTarget, this.m_curBehaviorCfg.MTParamData);
			}
			else if (this.m_curBehaviorCfg.MoveTarget == SelectTarget.SelectTarget_EnemyWithBuffN)
			{
				List<BattleActor> list = this.FindActorsWithBuffN(this.m_team.GetOtherTeam().GetActors(), this.m_curBehaviorCfg.SATParamData._int);
				if (list != null && list.Count > 0)
				{
					this.m_moveTarget = new BehaviorTarget(list[0]);
				}
			}
			else if (this.m_curBehaviorCfg.MoveTarget == SelectTarget.SelectTarget_Leader)
			{
				if (this.Group != null && this.Group.Leader != null)
				{
					this.m_moveTarget = new BehaviorTarget(this.Group.Leader);
				}
			}
			else if (this.m_curBehaviorCfg.MoveTarget == SelectTarget.SelectTarget_RandomReachableEmptyPosition)
			{
				List<GridPosition> list2 = new List<GridPosition>();
				this.FindMoveRegion(this.Position, list2);
				if (list2.Count > 0)
				{
					this.m_moveTarget = new BehaviorTarget(list2[this.GetAIRandomNumber().Next(0, list2.Count)]);
				}
			}
			else if (this.Battle.IsEnableDebugLog())
			{
				DebugUtility.LogError(string.Format("{0} has a unknown move Target: {1} in Behavior[{2}].", this.InstanceID, this.m_curBehaviorCfg.MoveTarget, this.m_curBehaviorCfg.ID));
			}
		}

		// Token: 0x06003281 RID: 12929 RVA: 0x000CC0D0 File Offset: 0x000CA2D0
		public bool FindPath(GridPosition start, GridPosition goal, int movePoint, int ignoreTeamNumber, int inRegion, List<GridPosition> path)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindPathGridPositionGridPositionInt32Int32Int32List`1_hotfix != null)
			{
				return Convert.ToBoolean(this.m_FindPathGridPositionGridPositionInt32Int32Int32List`1_hotfix.call(new object[]
				{
					this,
					start,
					goal,
					movePoint,
					ignoreTeamNumber,
					inRegion,
					path
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.Battle.FindPath(start, goal, movePoint, this.GetMoveType(), ignoreTeamNumber, this.GetBuffOverrideMovePointCost(), inRegion, path, false);
		}

		// Token: 0x06003282 RID: 12930 RVA: 0x000CC1C0 File Offset: 0x000CA3C0
		private void GenerateCommandOfMove(GridPosition target)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GenerateCommandOfMoveGridPosition_hotfix != null)
			{
				this.m_GenerateCommandOfMoveGridPosition_hotfix.call(new object[]
				{
					this,
					target
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GridPosition gridPosition = this.FindPositionToMoveToTarget(target);
			if (gridPosition == GridPosition.Null)
			{
				if (this.Battle.IsEnableDebugLog())
				{
					DebugUtility.Log(string.Format("!@# {0} has no path to the target {1}.", this.InstanceID, target));
				}
				return;
			}
			BattleCommand battleCommand = this.AICreateBattleCommand(BattleCommandType.Move);
			battleCommand.TargetPosition = gridPosition;
		}

		// Token: 0x06003283 RID: 12931 RVA: 0x000CC284 File Offset: 0x000CA484
		private GridPosition FindPositionToMoveToTarget(GridPosition target)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindPositionToMoveToTargetGridPosition_hotfix != null)
			{
				return (GridPosition)this.m_FindPositionToMoveToTargetGridPosition_hotfix.call(new object[]
				{
					this,
					target
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (target == GridPosition.Null)
			{
				return GridPosition.Null;
			}
			if (target == this.Position)
			{
				return target;
			}
			List<GridPosition> list = new List<GridPosition>();
			for (int i = 0; i < 2; i++)
			{
				if (i == 0)
				{
					if (!this.FindPath(this.Position, target, 2147483647, 0, list, false))
					{
						if (!this.Battle.FindPath(this.Position, target, 2147483647, this.GetMoveType(), -1, this.GetBuffOverrideMovePointCost(), 0, list, false))
						{
							return GridPosition.Null;
						}
						i = 2;
						for (int j = 1; j < list.Count; j++)
						{
							BattleActor actor = this.Battle.Map.GetActor(list[j]);
							if (actor != null && actor.TeamNumber != this.TeamNumber)
							{
								list.RemoveRange(j, list.Count - j);
								break;
							}
						}
					}
				}
				else if (i == 1 && !this.FindPath(this.Position, target, 2147483647, -2147483648, 0, list))
				{
					return GridPosition.Null;
				}
				int num = 0;
				for (int k = 1; k < list.Count; k++)
				{
					num += this.Battle.Map.GetMovePointCost(list[k], this.GetMoveType());
					if (num > this.GetMovePoint())
					{
						list.RemoveRange(k, list.Count - k);
						break;
					}
				}
				for (int l = list.Count - 1; l > 0; l--)
				{
					if (this.Battle.Map.GetActor(list[l]) == null)
					{
						return list[l];
					}
				}
			}
			return GridPosition.Null;
		}

		// Token: 0x06003284 RID: 12932 RVA: 0x000CC4CC File Offset: 0x000CA6CC
		private int ComputeRestrictScore(BattleActor srcActor, BattleActor destActor)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeRestrictScoreBattleActorBattleActor_hotfix != null)
			{
				return Convert.ToInt32(this.m_ComputeRestrictScoreBattleActorBattleActor_hotfix.call(new object[]
				{
					this,
					srcActor,
					destActor
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (srcActor == null || destActor == null)
			{
				if (this.Battle.IsEnableDebugLog())
				{
					DebugUtility.LogError("ComputeRestrictScore() srcActor or destActor is null.");
				}
				return 0;
			}
			if (srcActor.HeroHealthPoint == 0 || destActor.HeroHealthPoint == 0)
			{
				if (this.Battle.IsEnableDebugLog())
				{
					DebugUtility.LogError(string.Format("ComputeRestrictScore error: srcActor {0} or destActor {1} has died.", srcActor.InstanceID, destActor.InstanceID));
				}
				return 0;
			}
			int num = 0;
			num += this.GetArmyRistrictScore(srcActor.m_heroArmyInfo.ArmyTag, destActor.m_heroArmyInfo.ArmyTag);
			if (srcActor.SoldierTotalHealthPoint > 0 && destActor.SoldierTotalHealthPoint > 0)
			{
				num += this.GetArmyRistrictScore(srcActor.m_soldierArmyInfo.ArmyTag, destActor.m_soldierArmyInfo.ArmyTag);
			}
			if (destActor.SoldierTotalHealthPoint > 0)
			{
				num += this.GetArmyRistrictScore(srcActor.m_heroArmyInfo.ArmyTag, destActor.m_soldierArmyInfo.ArmyTag);
			}
			if (srcActor.SoldierTotalHealthPoint > 0)
			{
				num += this.GetArmyRistrictScore(srcActor.m_soldierArmyInfo.ArmyTag, destActor.m_heroArmyInfo.ArmyTag);
			}
			return num;
		}

		// Token: 0x06003285 RID: 12933 RVA: 0x000CC674 File Offset: 0x000CA874
		private int GetArmyRistrictScore(ArmyTag a, ArmyTag b)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetArmyRistrictScoreArmyTagArmyTag_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetArmyRistrictScoreArmyTagArmyTag_hotfix.call(new object[]
				{
					this,
					a,
					b
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ArmyRelationData armyRelationData = this.Battle.ConfigDataLoader.UtilityGetArmyRelationData(a, b);
			if (armyRelationData.Attack > 0)
			{
				return 1;
			}
			if (armyRelationData.Attack < 0)
			{
				return -1;
			}
			if (armyRelationData.Defend > 0)
			{
				return -1;
			}
			return 0;
		}

		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x06003286 RID: 12934 RVA: 0x000CC744 File Offset: 0x000CA944
		private float TotalHPPercent
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_TotalHPPercent_hotfix != null)
				{
					return Convert.ToSingle(this.m_get_TotalHPPercent_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return (this.GetTotalHealthPointMax() != 0) ? ((float)this.GetTotalHealthPoint() / (float)this.GetTotalHealthPointMax()) : 0f;
			}
		}

		// Token: 0x06003287 RID: 12935 RVA: 0x000CC7D4 File Offset: 0x000CA9D4
		public static BattleActor SelectMinHPPercentActor(List<BattleActor> actors)
		{
			float num = float.MaxValue;
			BattleActor result = null;
			foreach (BattleActor battleActor in actors)
			{
				float totalHPPercent = battleActor.TotalHPPercent;
				if (totalHPPercent < num)
				{
					num = totalHPPercent;
					result = battleActor;
				}
			}
			return result;
		}

		// Token: 0x06003288 RID: 12936 RVA: 0x000CC844 File Offset: 0x000CAA44
		public static List<BattleActor> FindActorsAlive(List<BattleActor> actors)
		{
			if (actors == null)
			{
				return null;
			}
			return actors.FindAll((BattleActor a) => !a.IsDeadOrRetreat());
		}

		// Token: 0x06003289 RID: 12937 RVA: 0x000CC874 File Offset: 0x000CAA74
		private BattleActor DefaultSelectDamageSkillTarget(List<BattleActor> actors)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DefaultSelectDamageSkillTargetList`1_hotfix != null)
			{
				return (BattleActor)this.m_DefaultSelectDamageSkillTargetList`1_hotfix.call(new object[]
				{
					this,
					actors
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (actors == null || actors.Count == 0)
			{
				return null;
			}
			if (actors.Count == 1)
			{
				return actors[0];
			}
			BattleActor battleActor = BattleActor.SelectMinHPPercentActor(actors);
			if (battleActor != null && battleActor.TotalHPPercent < 0.2f)
			{
				if (this.Battle.IsEnableDebugLog())
				{
					DebugUtility.Log(string.Format("!@# DefaultSelectDamageSkillTarget hp percent < 0.2, {0}.", battleActor.InstanceID));
				}
				return battleActor;
			}
			List<KeyValuePair<BattleActor, int[]>> list = new List<KeyValuePair<BattleActor, int[]>>(actors.Count);
			foreach (BattleActor battleActor2 in actors)
			{
				list.Add(new KeyValuePair<BattleActor, int[]>(battleActor2, new int[]
				{
					this.ComputeRestrictScore(this, battleActor2),
					GridPosition.Distance(this.Position, battleActor2.Position)
				}));
			}
			list.Sort(delegate(KeyValuePair<BattleActor, int[]> a, KeyValuePair<BattleActor, int[]> b)
			{
				if (b.Value[0] != a.Value[0])
				{
					return b.Value[0] - a.Value[0];
				}
				if (b.Value[1] != a.Value[1])
				{
					return a.Value[1] - b.Value[1];
				}
				if (b.Key.Position.x != a.Key.Position.x)
				{
					return b.Key.Position.x - a.Key.Position.x;
				}
				if (b.Key.Position.y != a.Key.Position.y)
				{
					return b.Key.Position.y - a.Key.Position.y;
				}
				return b.Key.Id - a.Key.Id;
			});
			if (list[0].Value[0] == 0)
			{
				KeyValuePair<BattleActor, int[]> keyValuePair;
				if (this.IsSelectRangeSkill())
				{
					keyValuePair = list.Find((KeyValuePair<BattleActor, int[]> a) => a.Key.GetMaxAttackDistance() < 2 && a.Value[0] == 0);
				}
				else
				{
					keyValuePair = list.Find((KeyValuePair<BattleActor, int[]> a) => a.Key.GetMaxAttackDistance() > 1 && a.Value[0] == 0);
				}
				if (keyValuePair.Key != null && keyValuePair.Value.Length > 0)
				{
					return keyValuePair.Key;
				}
			}
			return list[0].Key;
		}

		// Token: 0x0600328A RID: 12938 RVA: 0x000CCAA4 File Offset: 0x000CACA4
		private bool IsSelectRangeSkill()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsSelectRangeSkill_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsSelectRangeSkill_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_attackSkillIndex > -1 && this.m_attackSkillIndex < this.m_skillStates.Count)
			{
				return this.m_skillStates[this.m_attackSkillIndex].m_skillInfo.AIIsRangeSkill;
			}
			return this.GetMaxAttackDistance() > 1;
		}

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x0600328B RID: 12939 RVA: 0x000CCB58 File Offset: 0x000CAD58
		private ConfigDataSkillInfo BehaviorSelectSkillInfo
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_BehaviorSelectSkillInfo_hotfix != null)
				{
					return (ConfigDataSkillInfo)this.m_get_BehaviorSelectSkillInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				if (this.m_attackSkillIndex < 0)
				{
					if (this.m_soldierInfo != null)
					{
						return this.GetSoldierAttackSkillInfo(MoveType.MoveType_None, 0);
					}
					return this.GetHeroAttackSkillInfo(MoveType.MoveType_None, 0);
				}
				else
				{
					if (this.m_attackSkillIndex < this.m_skillStates.Count)
					{
						return this.m_skillStates[this.m_attackSkillIndex].m_skillInfo;
					}
					if (this.Battle.IsEnableDebugLog())
					{
						DebugUtility.LogError(string.Format("BattleActor.BehaviorSelectSkillInfo.get Actor {0} 's attack skill index {1} is invalid.", this.InstanceID, this.m_attackSkillIndex));
					}
					return null;
				}
			}
		}

		// Token: 0x0600328C RID: 12940 RVA: 0x000CCC4C File Offset: 0x000CAE4C
		private List<BattleActor> FindActorsInGrids(List<BattleActor> actors, List<GridPosition> grids)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindActorsInGridsList`1List`1_hotfix != null)
			{
				return (List<BattleActor>)this.m_FindActorsInGridsList`1List`1_hotfix.call(new object[]
				{
					this,
					actors,
					grids
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<BattleActor> list = new List<BattleActor>();
			if (actors == null || grids == null)
			{
				return list;
			}
			foreach (GridPosition p in grids)
			{
				BattleActor a = this.Battle.Map.GetActor(p);
				if (a != null)
				{
					if (actors.Find((BattleActor actor) => a == actor) != null)
					{
						list.Add(a);
					}
				}
			}
			return list;
		}

		// Token: 0x0600328D RID: 12941 RVA: 0x000CCD80 File Offset: 0x000CAF80
		private GridPosition FindMaxAoeSkillCoverPosition(ConfigDataSkillInfo si, List<GridPosition> asCenterPositions, List<BattleActor> beCoveredActors, ClassValue<int> maxCoverActorsCount = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindMaxAoeSkillCoverPositionConfigDataSkillInfoList`1List`1ClassValue`1_hotfix != null)
			{
				return (GridPosition)this.m_FindMaxAoeSkillCoverPositionConfigDataSkillInfoList`1List`1ClassValue`1_hotfix.call(new object[]
				{
					this,
					si2,
					asCenterPositions,
					beCoveredActors2,
					maxCoverActorsCount2
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataSkillInfo si = si2;
			List<BattleActor> beCoveredActors = beCoveredActors2;
			ClassValue<int> maxCoverActorsCount = maxCoverActorsCount2;
			BattleActor $this = this;
			if (si == null || asCenterPositions == null || beCoveredActors == null || asCenterPositions.Count == 0 || beCoveredActors.Count == 0)
			{
				return GridPosition.Null;
			}
			List<GridPosition> aoeGrids = new List<GridPosition>();
			if (maxCoverActorsCount != null)
			{
				maxCoverActorsCount.value = int.MinValue;
			}
			return Find.MaxInt<GridPosition>(asCenterPositions, delegate(GridPosition p)
			{
				$this.Battle.FindAttackRegion(p, si.BF_Range - 1, si.BF_RangeShape, aoeGrids);
				int count = $this.FindActorsInGrids(beCoveredActors, aoeGrids).Count;
				if (maxCoverActorsCount != null)
				{
					maxCoverActorsCount.value = Math.Max(maxCoverActorsCount.value, count);
				}
				return count;
			});
		}

		// Token: 0x0600328E RID: 12942 RVA: 0x000CCEC4 File Offset: 0x000CB0C4
		private BattleActor FindMaxAoeSkillCoverActor(ConfigDataSkillInfo si, List<BattleActor> asCenterActors, List<BattleActor> beCoveredActors, ClassValue<int> maxCoverActorsCount = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindMaxAoeSkillCoverActorConfigDataSkillInfoList`1List`1ClassValue`1_hotfix != null)
			{
				return (BattleActor)this.m_FindMaxAoeSkillCoverActorConfigDataSkillInfoList`1List`1ClassValue`1_hotfix.call(new object[]
				{
					this,
					si2,
					asCenterActors,
					beCoveredActors2,
					maxCoverActorsCount2
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataSkillInfo si = si2;
			List<BattleActor> beCoveredActors = beCoveredActors2;
			ClassValue<int> maxCoverActorsCount = maxCoverActorsCount2;
			BattleActor $this = this;
			if (si == null || asCenterActors == null || beCoveredActors == null)
			{
				return null;
			}
			List<GridPosition> aoeGrids = new List<GridPosition>();
			if (maxCoverActorsCount != null)
			{
				maxCoverActorsCount.value = int.MinValue;
			}
			return Find.MaxInt<BattleActor>(asCenterActors, delegate(BattleActor a)
			{
				if (a == $this)
				{
					return -1;
				}
				$this.Battle.FindAttackRegion(a.m_position, si.BF_Range - 1, si.BF_RangeShape, aoeGrids);
				int count = $this.FindActorsInGrids(beCoveredActors, aoeGrids).Count;
				if (maxCoverActorsCount != null)
				{
					maxCoverActorsCount.value = Math.Max(maxCoverActorsCount.value, count);
				}
				return count;
			});
		}

		// Token: 0x0600328F RID: 12943 RVA: 0x000CCFEC File Offset: 0x000CB1EC
		private void DefaultSelectAttackTarget()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DefaultSelectAttackTarget_hotfix != null)
			{
				this.m_DefaultSelectAttackTarget_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataSkillInfo behaviorSelectSkillInfo = this.BehaviorSelectSkillInfo;
			if (behaviorSelectSkillInfo == null)
			{
				return;
			}
			if (this.m_attackSkillIndex >= 0)
			{
				if (behaviorSelectSkillInfo.SkillAIType == SkillAIType.SkillAIType_DamageAOE)
				{
					List<BattleActor> list = BattleActor.FindActorsAlive(this.m_team.GetOtherTeam().GetActors());
					List<BattleActor> asCenterActors = this.FindActorsInCanAttackAndTouchRange(list, this.Position, this.GetSkillDistance(behaviorSelectSkillInfo), behaviorSelectSkillInfo.CastSkillShape, true);
					this.m_attackTarget = new BehaviorTarget(this.FindMaxAoeSkillCoverActor(behaviorSelectSkillInfo, asCenterActors, list, null));
				}
				else if (behaviorSelectSkillInfo.SkillAIType == SkillAIType.SkillAIType_DamageAOESelf || behaviorSelectSkillInfo.SkillAIType == SkillAIType.SkillAIType_DamageAOESelfSingle)
				{
					this.m_attackTarget = new BehaviorTarget(this);
				}
				else if (behaviorSelectSkillInfo.SkillAIType == SkillAIType.SkillAIType_Heal)
				{
					List<BattleActor> list2 = this.FindActorsInCanAttackAndTouchRange(BattleActor.FindActorsAlive(this.m_team.GetActors()).FindAll((BattleActor a) => a.TotalHPPercent < 0.7f), this.m_position, this.GetSkillDistance(behaviorSelectSkillInfo), behaviorSelectSkillInfo.CastSkillShape, false);
					if (list2.Count > 0)
					{
						this.m_attackTarget = new BehaviorTarget(Find.MinInt<BattleActor>(list2, (BattleActor a) => a.GetTotalHealthPoint()));
					}
				}
				else if (behaviorSelectSkillInfo.SkillAIType == SkillAIType.SkillAIType_HealRange)
				{
					List<BattleActor> list3 = BattleActor.FindActorsAlive(this.m_team.GetActors()).FindAll((BattleActor a) => a.TotalHPPercent < 0.7f);
					List<BattleActor> asCenterActors2 = this.FindActorsInCanAttackAndTouchRange(list3, this.m_position, this.GetSkillDistance(behaviorSelectSkillInfo), behaviorSelectSkillInfo.CastSkillShape, false);
					this.m_attackTarget = new BehaviorTarget(this.FindMaxAoeSkillCoverActor(behaviorSelectSkillInfo, asCenterActors2, list3, null));
				}
				else if (behaviorSelectSkillInfo.SkillAIType == SkillAIType.SkillAIType_BuffSingle)
				{
					List<BattleActor> list4 = this.FindActorsInCanAttackAndTouchRange(BattleActor.FindActorsAlive(this.m_team.GetActors()), this.m_position, this.GetSkillDistance(behaviorSelectSkillInfo), behaviorSelectSkillInfo.CastSkillShape, false);
					this.m_attackTarget = new BehaviorTarget(Find.MaxInt<BattleActor>(list4, (BattleActor a) => (a != this) ? (a.m_heroBattleProperty.Attack + a.m_soldierBattleProperty.Attack) : -1));
				}
				else if (behaviorSelectSkillInfo.SkillAIType == SkillAIType.SkillAIType_BuffAOE)
				{
					if (this.GetSkillDistance(behaviorSelectSkillInfo) == 0 && this.Battle.IsEnableDebugLog())
					{
						DebugUtility.LogError(string.Format("{0} 's skill distance is {1}, it's SkillAIType should be BuffSelf.", this.InstanceID, this.GetSkillDistance(behaviorSelectSkillInfo)));
					}
					List<BattleActor> list5 = BattleActor.FindActorsAlive(this.m_team.GetActors());
					List<BattleActor> asCenterActors3 = this.FindActorsInCanAttackAndTouchRange(list5, this.m_position, this.GetSkillDistance(behaviorSelectSkillInfo), behaviorSelectSkillInfo.CastSkillShape, false);
					this.m_attackTarget = new BehaviorTarget(this.FindMaxAoeSkillCoverActor(behaviorSelectSkillInfo, asCenterActors3, list5, null));
				}
				else if (behaviorSelectSkillInfo.SkillAIType == SkillAIType.SkillAIType_Dispel)
				{
					List<BattleActor> list6 = BattleActor.FindActorsAlive(this.m_team.GetActors());
					List<BattleActor> asCenterActors4 = this.FindActorsInCanAttackAndTouchRange(list6, this.m_position, this.GetSkillDistance(behaviorSelectSkillInfo), behaviorSelectSkillInfo.CastSkillShape, false).FindAll((BattleActor a) => null != a.m_buffStates.Find((BuffState b) => b.m_buffInfo.IsDebuff));
					this.m_attackTarget = new BehaviorTarget(this.FindMaxAoeSkillCoverActor(behaviorSelectSkillInfo, asCenterActors4, list6, null));
				}
				else if (behaviorSelectSkillInfo.SkillAIType == SkillAIType.SkillAIType_BuffSelf1 || behaviorSelectSkillInfo.SkillAIType == SkillAIType.SkillAIType_BuffSelf2 || behaviorSelectSkillInfo.SkillAIType == SkillAIType.SkillAIType_Guard)
				{
					this.m_attackTarget = new BehaviorTarget(this);
				}
				else if (behaviorSelectSkillInfo.SkillAIType == SkillAIType.SkillAIType_NewTurn)
				{
					List<BattleActor> list7 = this.FindActorsInCanAttackAndTouchRange(BattleActor.FindActorsAlive(this.m_team.GetActors()), this.m_position, this.GetSkillDistance(behaviorSelectSkillInfo), behaviorSelectSkillInfo.CastSkillShape, true).FindAll((BattleActor a) => a != this && a.IsActionFinished());
					this.m_attackTarget = new BehaviorTarget(Find.MaxInt<BattleActor>(list7, (BattleActor a) => (a != this) ? (a.m_heroBattleProperty.Attack + a.m_soldierBattleProperty.Attack) : -1));
				}
				else if (behaviorSelectSkillInfo.SkillAIType == SkillAIType.SkillAIType_RemoveCD)
				{
					List<BattleActor> list8 = this.FindActorsInCanAttackAndTouchRange(BattleActor.FindActorsAlive(this.m_team.GetActors()), this.m_position, this.GetSkillDistance(behaviorSelectSkillInfo), behaviorSelectSkillInfo.CastSkillShape, false).FindAll((BattleActor a) => a.m_skillStates.Find((BattleSkillState s) => s.m_cooldown > 0) != null);
					this.m_attackTarget = new BehaviorTarget(Find.MaxInt<BattleActor>(list8, (BattleActor a) => (a != this) ? (a.m_heroBattleProperty.Attack + a.m_soldierBattleProperty.Attack) : -1));
				}
				else if (behaviorSelectSkillInfo.SkillAIType == SkillAIType.SkillAIType_Summon)
				{
					this.SelectMoveTarget();
					if (this.m_moveTarget != null && !this.m_moveTarget.IsEmpty())
					{
						GridPosition p = this.FindPositionToMoveToTarget(this.m_moveTarget.Position);
						if (p != GridPosition.Null)
						{
							List<GridPosition> list9 = new List<GridPosition>();
							this.Battle.FindAttackRegion(p, this.GetSkillDistance(behaviorSelectSkillInfo), behaviorSelectSkillInfo.CastSkillShape, list9);
							this.m_attackTarget = new BehaviorTarget(Find.MinInt<GridPosition>(list9.FindAll((GridPosition pos) => pos != p && this.Battle.Map.GetActor(pos) == null), (GridPosition pos) => GridPosition.Distance(pos, p)));
						}
					}
				}
			}
			if (this.m_attackTarget == null || this.m_attackTarget.IsEmpty())
			{
				if (behaviorSelectSkillInfo.IsDamageSkill())
				{
					List<BattleActor> list10 = this.FindActorsInCanAttackAndTouchRange(BattleActor.FindActorsAlive(this.GetSkillTargetTeam(behaviorSelectSkillInfo).GetActors()), this.Position, (this.m_attackSkillIndex >= 0) ? this.GetSkillDistance(behaviorSelectSkillInfo) : this.GetMaxAttackDistance(), (this.m_attackSkillIndex >= 0) ? behaviorSelectSkillInfo.CastSkillShape : 0, true);
					if (list10.Count == 0)
					{
						if (this.Battle.IsEnableDebugLog())
						{
							DebugUtility.Log(string.Format("!@# No enemy inside {0}'s attack range {1}.", this.InstanceID, this.GetMovePoint() + this.GetSkillDistance(behaviorSelectSkillInfo)));
						}
						return;
					}
					this.m_attackTarget = new BehaviorTarget(this.DefaultSelectDamageSkillTarget(list10));
				}
				else if (behaviorSelectSkillInfo.IsHealSkill())
				{
					this.FindMoveAndAttackRegion(this.GetSkillDistance(behaviorSelectSkillInfo), behaviorSelectSkillInfo.CastSkillShape);
					BattleTeam skillTargetTeam = this.GetSkillTargetTeam(behaviorSelectSkillInfo);
					if (BattleActor.<>f__mg$cache0 == null)
					{
						BattleActor.<>f__mg$cache0 = new BattleActor.ComputeActorScoreFunc(BattleActor.ComputeActorScoreHeal);
					}
					this.m_attackTarget = new BehaviorTarget(this.SelectAttackRegionTarget(skillTargetTeam, BattleActor.<>f__mg$cache0, 0));
				}
				else if (behaviorSelectSkillInfo.IsBuffSkill())
				{
					int computeScoreParam = 0;
					if (behaviorSelectSkillInfo.Buffs_ID.Count > 0)
					{
						computeScoreParam = behaviorSelectSkillInfo.Buffs_ID[0];
					}
					this.FindMoveAndAttackRegion(this.GetSkillDistance(behaviorSelectSkillInfo), behaviorSelectSkillInfo.CastSkillShape);
					this.m_attackTarget = new BehaviorTarget(this.SelectAttackRegionTarget(this.GetSkillTargetTeam(behaviorSelectSkillInfo), new BattleActor.ComputeActorScoreFunc(this.ComputeActorScoreBuff), computeScoreParam));
				}
				else
				{
					if (!behaviorSelectSkillInfo.IsSummonSkill())
					{
						if (this.Battle.IsEnableDebugLog())
						{
							DebugUtility.LogError(string.Format("Skill {0} 's type is invalid for AI behavior.", behaviorSelectSkillInfo.ID));
						}
						return;
					}
					GridPosition @null = GridPosition.Null;
					this.FindRandomEmptyPosition(this.GetSkillDistance(behaviorSelectSkillInfo), behaviorSelectSkillInfo.CastSkillShape, ref @null);
					this.m_attackTarget = new BehaviorTarget(@null);
				}
			}
			if (this.Battle.IsEnableDebugLog())
			{
				DebugUtility.Log(string.Format("!@# {2} Cast skill {0} on actor {1}.", behaviorSelectSkillInfo.Name, this.m_attackTarget, this.InstanceID));
			}
		}

		// Token: 0x06003290 RID: 12944 RVA: 0x000CD780 File Offset: 0x000CB980
		private List<GridPosition> FindGridsLessEqualDistance(GridPosition startPos, int dist)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindGridsLessEqualDistanceGridPositionInt32_hotfix != null)
			{
				return (List<GridPosition>)this.m_FindGridsLessEqualDistanceGridPositionInt32_hotfix.call(new object[]
				{
					this,
					startPos,
					dist
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<GridPosition> list = new List<GridPosition>();
			if (dist < 1)
			{
				list.Add(startPos);
				return list;
			}
			for (int i = startPos.x - dist; i < startPos.x + dist; i++)
			{
				for (int j = startPos.y - dist; j < startPos.y + dist; j++)
				{
					GridPosition gridPosition = new GridPosition(i, j);
					if (GridPosition.Distance(startPos, gridPosition) <= dist)
					{
						list.Add(gridPosition);
					}
				}
			}
			return list;
		}

		// Token: 0x06003291 RID: 12945 RVA: 0x000CD88C File Offset: 0x000CBA8C
		private List<BattleActor> FindActorsLessEqualDistance(List<BattleActor> actors, GridPosition startPos, int dist)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindActorsLessEqualDistanceList`1GridPositionInt32_hotfix != null)
			{
				return (List<BattleActor>)this.m_FindActorsLessEqualDistanceList`1GridPositionInt32_hotfix.call(new object[]
				{
					this,
					actors,
					startPos,
					dist
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (actors == null)
			{
				return null;
			}
			List<BattleActor> list = new List<BattleActor>(actors.Count);
			foreach (BattleActor battleActor in actors)
			{
				if (GridPosition.Distance(startPos, battleActor.Position) <= dist)
				{
					list.Add(battleActor);
				}
			}
			return list;
		}

		// Token: 0x06003292 RID: 12946 RVA: 0x000CD9A0 File Offset: 0x000CBBA0
		private BattleActor DefaultSelectHealSkillTarget(List<BattleActor> actors)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DefaultSelectHealSkillTargetList`1_hotfix != null)
			{
				return (BattleActor)this.m_DefaultSelectHealSkillTargetList`1_hotfix.call(new object[]
				{
					this,
					actors
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleActor result = null;
			int num = -1;
			int num2 = 10000;
			BattleMap map = this.Battle.Map;
			foreach (BattleActor battleActor in actors)
			{
				int num3 = BattleActor.ComputeActorScoreHeal(battleActor, 0);
				if (num3 >= 0)
				{
					if (num3 > num)
					{
						result = battleActor;
						num = num3;
						num2 = GridPosition.Distance(this.m_position, battleActor.m_position);
					}
					else if (num3 == num)
					{
						int num4 = GridPosition.Distance(this.m_position, battleActor.m_position);
						if (num4 < num2)
						{
							result = battleActor;
							num2 = num4;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06003293 RID: 12947 RVA: 0x000CDAE0 File Offset: 0x000CBCE0
		private BattleActor DefaultSelectBuffSkillTarget(List<BattleActor> actors, ConfigDataSkillInfo skill)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DefaultSelectBuffSkillTargetList`1ConfigDataSkillInfo_hotfix != null)
			{
				return (BattleActor)this.m_DefaultSelectBuffSkillTargetList`1ConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					actors,
					skill
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleActor result = null;
			int num = -1;
			int num2 = 10000;
			BattleMap map = this.Battle.Map;
			int param = 0;
			if (skill != null && skill.Buffs_ID.Count > 0)
			{
				param = skill.Buffs_ID[0];
			}
			foreach (BattleActor battleActor in actors)
			{
				int num3 = this.ComputeActorScoreBuff(battleActor, param);
				if (num3 >= 0)
				{
					if (num3 > num)
					{
						result = battleActor;
						num = num3;
						num2 = GridPosition.Distance(this.m_position, battleActor.m_position);
					}
					else if (num3 == num)
					{
						int num4 = GridPosition.Distance(this.m_position, battleActor.m_position);
						if (num4 < num2)
						{
							result = battleActor;
							num2 = num4;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06003294 RID: 12948 RVA: 0x000CDC5C File Offset: 0x000CBE5C
		private void SelectAttackTargetInSkillRange()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SelectAttackTargetInSkillRange_hotfix != null)
			{
				this.m_SelectAttackTargetInSkillRange_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataSkillInfo behaviorSelectSkillInfo = this.BehaviorSelectSkillInfo;
			if (behaviorSelectSkillInfo == null)
			{
				return;
			}
			if (behaviorSelectSkillInfo.IsDamageSkill())
			{
				List<BattleActor> list = this.FindActorsLessEqualDistance(BattleActor.FindActorsAlive(this.GetSkillTargetTeam(behaviorSelectSkillInfo).GetActors()), this.Position, this.GetSkillDistance(behaviorSelectSkillInfo));
				if (list.Count == 0)
				{
					if (this.Battle.IsEnableDebugLog())
					{
						DebugUtility.Log(string.Format("!@# No enemy inside {0}'s skill range {1}.", this.InstanceID, this.GetSkillDistance(behaviorSelectSkillInfo)));
					}
					return;
				}
				this.m_attackTarget = new BehaviorTarget(this.DefaultSelectDamageSkillTarget(list));
			}
			else if (behaviorSelectSkillInfo.IsHealSkill())
			{
				List<BattleActor> list2 = this.FindActorsLessEqualDistance(BattleActor.FindActorsAlive(this.GetSkillTargetTeam(behaviorSelectSkillInfo).GetActors()), this.Position, this.GetSkillDistance(behaviorSelectSkillInfo));
				if (list2 == null || list2.Count == 0)
				{
					if (this.Battle.IsEnableDebugLog())
					{
						DebugUtility.LogError(string.Format("No enemy inside {0}'s skill range {1}.", this.InstanceID, this.GetMovePoint() + this.GetSkillDistance(behaviorSelectSkillInfo)));
					}
					return;
				}
				this.m_attackTarget = new BehaviorTarget(this.DefaultSelectHealSkillTarget(list2));
			}
			else if (behaviorSelectSkillInfo.IsBuffSkill())
			{
				List<BattleActor> list3 = this.FindActorsLessEqualDistance(BattleActor.FindActorsAlive(this.GetSkillTargetTeam(behaviorSelectSkillInfo).GetActors()), this.Position, this.GetSkillDistance(behaviorSelectSkillInfo));
				if (list3.Count == 0)
				{
					if (this.Battle.IsEnableDebugLog())
					{
						DebugUtility.Log(string.Format("!@# No enemy inside {0}'s skill range {1}.", this.InstanceID, this.GetMovePoint() + this.GetSkillDistance(behaviorSelectSkillInfo)));
					}
					return;
				}
				this.m_attackTarget = new BehaviorTarget(this.DefaultSelectBuffSkillTarget(list3, behaviorSelectSkillInfo));
			}
			else
			{
				if (!behaviorSelectSkillInfo.IsSummonSkill())
				{
					if (this.Battle.IsEnableDebugLog())
					{
						DebugUtility.LogError(string.Format("Skill {0} 's type is invalid for AI behavior.", behaviorSelectSkillInfo.ID));
					}
					return;
				}
				GridPosition @null = GridPosition.Null;
				this.FindRandomEmptyPosition(this.GetSkillDistance(behaviorSelectSkillInfo), behaviorSelectSkillInfo.CastSkillShape, ref @null);
				this.m_attackTarget = new BehaviorTarget(@null);
			}
			if (this.Battle.IsEnableDebugLog())
			{
				DebugUtility.Log(string.Format("!@# {2} Cast skill {0} on actor {1}.", behaviorSelectSkillInfo.Name, (this.m_attackTarget != null) ? this.m_attackTarget.ToString() : "null", this.InstanceID));
			}
		}

		// Token: 0x06003295 RID: 12949 RVA: 0x000CDF1C File Offset: 0x000CC11C
		private List<BattleActor> FindActorsWithBuffN(List<BattleActor> actors, int buffID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindActorsWithBuffNList`1Int32_hotfix != null)
			{
				return (List<BattleActor>)this.m_FindActorsWithBuffNList`1Int32_hotfix.call(new object[]
				{
					this,
					actors,
					buffID
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<BattleActor> list = new List<BattleActor>(actors.Count);
			foreach (BattleActor battleActor in actors)
			{
				if (battleActor.HasBuff(buffID))
				{
					list.Add(battleActor);
				}
			}
			if (this.Battle.IsEnableDebugLog())
			{
				DebugUtility.Log(string.Format("!@# {0} enemies have buff {1}.", list.Count, buffID));
			}
			return list;
		}

		// Token: 0x06003296 RID: 12950 RVA: 0x000CE040 File Offset: 0x000CC240
		private void SelectAttackTarget()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SelectAttackTarget_hotfix != null)
			{
				this.m_SelectAttackTarget_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curBehaviorCfg == null)
			{
				return;
			}
			this.m_attackTarget = null;
			if (this.m_curBehaviorCfg.SelectAttackTarget == SelectTarget.SelectTarget_DefaultSelection)
			{
				this.DefaultSelectAttackTarget();
			}
			else if (this.m_curBehaviorCfg.SelectAttackTarget == SelectTarget.SelectTarget_SameAsLeader)
			{
				if (this.Group.Leader != null && this.Group.Leader.m_attackTarget != null && this.Group.Leader.m_attackTarget.Actor != null && this.CanUseSkillOnTarget(this.BehaviorSelectSkillInfo, this.Group.Leader.m_attackTarget.Actor))
				{
					this.m_attackTarget = this.Group.Leader.m_attackTarget;
				}
				else
				{
					this.DefaultSelectAttackTarget();
				}
			}
			else if (this.m_curBehaviorCfg.SelectAttackTarget == SelectTarget.SelectTarget_TargetInSkillRange)
			{
				this.SelectAttackTargetInSkillRange();
			}
			else if (this.m_curBehaviorCfg.SelectAttackTarget == SelectTarget.SelectTarget_EnemyWithBuffN)
			{
				List<BattleActor> list = this.FindActorsWithBuffN(this.m_team.GetOtherTeam().GetActors(), this.m_curBehaviorCfg.SATParamData._int);
				if (list != null && list.Count > 0)
				{
					this.m_attackTarget = new BehaviorTarget(list[0]);
				}
			}
			else if (this.m_curBehaviorCfg.SelectAttackTarget == SelectTarget.SelectTarget_MemberHeroID || this.m_curBehaviorCfg.SelectAttackTarget == SelectTarget.SelectTarget_MemberHeroID)
			{
				this.m_attackTarget = this.DoSelectTarget(this.m_curBehaviorCfg.SelectAttackTarget, this.m_curBehaviorCfg.SATParamData);
			}
			else if (this.m_curBehaviorCfg.SelectAttackTarget == SelectTarget.SelectTarget_EnemyIDFilter)
			{
				ConfigDataSkillInfo behaviorSelectSkillInfo = this.BehaviorSelectSkillInfo;
				if (behaviorSelectSkillInfo != null && behaviorSelectSkillInfo.IsDamageSkill() && (behaviorSelectSkillInfo.SkillAIType != SkillAIType.SkillAIType_DamageAOESelf || behaviorSelectSkillInfo.SkillAIType != SkillAIType.SkillAIType_DamageAOESelfSingle))
				{
					this.m_attackTarget = this.DoSelectTarget(this.m_curBehaviorCfg.SelectAttackTarget, this.m_curBehaviorCfg.SATParamData);
				}
				else
				{
					this.DefaultSelectAttackTarget();
				}
			}
			else if (this.Battle.IsEnableDebugLog())
			{
				DebugUtility.LogError(string.Format("{0} has a unknown select attack target: {1} in Behavior[{2}].", this.InstanceID, this.m_curBehaviorCfg.SelectAttackTarget, this.m_curBehaviorCfg.ID));
			}
		}

		// Token: 0x06003297 RID: 12951 RVA: 0x000CE2EC File Offset: 0x000CC4EC
		private void SelectSkill()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SelectSkill_hotfix != null)
			{
				this.m_SelectSkill_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curBehaviorCfg == null)
			{
				return;
			}
			this.m_attackSkillIndex = -1;
			if (this.m_curBehaviorCfg.SelectSkill == BlackJack.ConfigData.SelectSkill.SelectSkill_DefaultSelection)
			{
				this.DefaultSelectSkill(null, null);
			}
			else if (this.m_curBehaviorCfg.SelectSkill == BlackJack.ConfigData.SelectSkill.SelectSkill_DirectReachTargetSkill)
			{
				this.SelectSkillDirectReachTarget();
			}
			else if (this.m_curBehaviorCfg.SelectSkill == BlackJack.ConfigData.SelectSkill.SelectSkill_ExcludeSkillID)
			{
				this.DefaultSelectSkill(null, this.m_curBehaviorCfg.SSParamData._ints);
			}
			else if (this.m_curBehaviorCfg.SelectSkill == BlackJack.ConfigData.SelectSkill.SelectSkill_IncludeSkillID)
			{
				this.DefaultSelectSkill(this.m_curBehaviorCfg.SSParamData._ints, null);
			}
			else if (this.Battle.IsEnableDebugLog())
			{
				DebugUtility.LogError(string.Format("{0} has a unknown SelectSkill: {1} in Behavior[{2}].", this.InstanceID, this.m_curBehaviorCfg.SelectSkill, this.m_curBehaviorCfg.ID));
			}
		}

		// Token: 0x06003298 RID: 12952 RVA: 0x000CE438 File Offset: 0x000CC638
		private void SelectSkillDirectReachTarget()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SelectSkillDirectReachTarget_hotfix != null)
			{
				this.m_SelectSkillDirectReachTarget_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.GetAIRandomNumber().Next(0, this.m_skillStates.Count);
			List<BattleActor> list = null;
			GridPosition gridPosition = new GridPosition(0, 0);
			for (int i = 0; i < this.m_skillStates.Count; i++)
			{
				int num2 = (i + num) % this.m_skillStates.Count;
				if (this.IsSkillUseable(num2))
				{
					BattleSkillState battleSkillState = this.m_skillStates[num2];
					if (battleSkillState.m_skillInfo.IsDamageSkill())
					{
						list = this.GetSkillTargetTeam(battleSkillState.m_skillInfo).GetActors();
					}
					else if (battleSkillState.m_skillInfo.IsHealSkill() || battleSkillState.m_skillInfo.IsBuffSkill())
					{
						list = this.GetSkillTargetTeam(battleSkillState.m_skillInfo).GetActors();
					}
					else if (battleSkillState.m_skillInfo.IsSummonSkill() && this.FindRandomEmptyPosition(this.GetSkillDistance(battleSkillState.m_skillInfo), battleSkillState.m_skillInfo.CastSkillShape, ref gridPosition))
					{
						this.m_attackSkillIndex = num2;
						return;
					}
					if (list != null)
					{
						if (this.FindActorsLessEqualDistance(BattleActor.FindActorsAlive(list), this.Position, this.GetSkillDistance(battleSkillState.m_skillInfo)).Count > 0)
						{
							this.m_attackSkillIndex = num2;
							return;
						}
						if (battleSkillState.m_skillInfo.BF_Distance == 0)
						{
							List<GridPosition> skillRegion = new List<GridPosition>(20);
							this.Battle.FindAttackRegion(this.Position, battleSkillState.m_skillInfo.BF_Range - 1, battleSkillState.m_skillInfo.BF_RangeShape, skillRegion);
							if (BattleActor.FindActorsAlive(list).Find((BattleActor a) => skillRegion.FindAll((GridPosition grid) => grid == a.Position).Count > 0) != null)
							{
								this.m_attackSkillIndex = num2;
								return;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003299 RID: 12953 RVA: 0x000CE668 File Offset: 0x000CC868
		private static bool HasInt(int value, int[] arr)
		{
			if (arr == null)
			{
				return false;
			}
			foreach (int num in arr)
			{
				if (value == num)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600329A RID: 12954 RVA: 0x000CE6A4 File Offset: 0x000CC8A4
		private void DefaultSelectSkill(int[] includeSkillIDs, int[] excludeSkillIDs)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DefaultSelectSkillInt32beInt32be_hotfix != null)
			{
				this.m_DefaultSelectSkillInt32beInt32be_hotfix.call(new object[]
				{
					this,
					includeSkillIDs,
					excludeSkillIDs
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.GetAIRandomNumber().Next(0, this.m_skillStates.Count);
			for (int i = 0; i < this.m_skillStates.Count; i++)
			{
				int num2 = (i + num) % this.m_skillStates.Count;
				if (this.IsSkillUseable(num2))
				{
					BattleSkillState battleSkillState = this.m_skillStates[num2];
					if (includeSkillIDs == null || BattleActor.HasInt(battleSkillState.m_skillInfo.ID, includeSkillIDs))
					{
						if (excludeSkillIDs == null || !BattleActor.HasInt(battleSkillState.m_skillInfo.ID, excludeSkillIDs))
						{
							if (this.IsSkillAGoodAISelection(battleSkillState.m_skillInfo))
							{
								this.m_attackSkillIndex = num2;
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600329B RID: 12955 RVA: 0x000CE7EC File Offset: 0x000CC9EC
		private List<BattleActor> FindActorsInCanNormalAttackAndTouchRange(List<BattleActor> destActors, List<BattleActor> srcActors)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindActorsInCanNormalAttackAndTouchRangeList`1List`1_hotfix != null)
			{
				return (List<BattleActor>)this.m_FindActorsInCanNormalAttackAndTouchRangeList`1List`1_hotfix.call(new object[]
				{
					this,
					destActors,
					srcActors
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<BattleActor> list = new List<BattleActor>();
			if (destActors == null || destActors.Count == 0 || srcActors == null || srcActors.Count == 0)
			{
				return list;
			}
			HashSet<BattleActor> hashSet = new HashSet<BattleActor>();
			foreach (BattleActor battleActor in srcActors)
			{
				foreach (BattleActor item in battleActor.FindActorsInCanAttackAndTouchRange(destActors, battleActor.m_position, battleActor.GetMaxAttackDistance(), 0, true))
				{
					hashSet.Add(item);
				}
			}
			list.AddRange(hashSet);
			return list;
		}

		// Token: 0x0600329C RID: 12956 RVA: 0x000CE954 File Offset: 0x000CCB54
		private bool IsSkillAGoodAISelection(ConfigDataSkillInfo si)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsSkillAGoodAISelectionConfigDataSkillInfo_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsSkillAGoodAISelectionConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					si
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (si == null)
			{
				return false;
			}
			if (si.SkillAIType == SkillAIType.SkillAIType_DamageSingle || si.SkillAIType == SkillAIType.SkillAIType_DamageAssault)
			{
				return this.FindActorsInCanAttackAndTouchRange(BattleActor.FindActorsAlive(this.m_team.GetOtherTeam().GetActors()), this.m_position, this.GetSkillDistance(si), si.CastSkillShape, true).Count > 0;
			}
			if (si.SkillAIType == SkillAIType.SkillAIType_DamageAOE)
			{
				List<BattleActor> list = BattleActor.FindActorsAlive(this.m_team.GetOtherTeam().GetActors());
				List<BattleActor> list2 = this.FindActorsInCanAttackAndTouchRange(list, this.Position, this.GetSkillDistance(si), si.CastSkillShape, true);
				if (list2.Count <= 0)
				{
					return false;
				}
				if (list.Count > 1)
				{
					ClassValue<int> classValue = new ClassValue<int>(0);
					this.FindMaxAoeSkillCoverActor(si, list2, list, classValue);
					return classValue.value > 1;
				}
				return true;
			}
			else if (si.SkillAIType == SkillAIType.SkillAIType_DamageAOESelf || si.SkillAIType == SkillAIType.SkillAIType_DamageAOESelfSingle)
			{
				List<BattleActor> list3 = BattleActor.FindActorsAlive(this.m_team.GetOtherTeam().GetActors());
				if (list3.Count <= 1)
				{
					return this.FindActorsInCanAttackAndTouchRange(list3, this.Position, si.BF_Range - 1, si.CastSkillShape, true).Count > 0;
				}
				List<GridPosition> list4 = new List<GridPosition>();
				this.FindMoveRegion(this.Position, list4);
				list4 = list4.FindAll((GridPosition p) => this.Battle.Map.GetActor(p) == null || this.Position == p);
				ClassValue<int> classValue2 = new ClassValue<int>(0);
				this.FindMaxAoeSkillCoverPosition(si, list4, list3, classValue2);
				if (si.SkillAIType == SkillAIType.SkillAIType_DamageAOESelf)
				{
					return classValue2.value > 1;
				}
				return classValue2.value > 0;
			}
			else
			{
				if (si.SkillAIType == SkillAIType.SkillAIType_Heal || si.SkillAIType == SkillAIType.SkillAIType_HealRange || si.SkillAIType == SkillAIType.SkillAIType_HealRangeSelf)
				{
					List<BattleActor> list5 = this.FindActorsInCanAttackAndTouchRange(BattleActor.FindActorsAlive(this.m_team.GetActors()).FindAll((BattleActor a) => a.TotalHPPercent < 0.7f), this.m_position, this.GetSkillDistance(si), si.CastSkillShape, false);
					return list5.Count > 0;
				}
				if (si.SkillAIType == SkillAIType.SkillAIType_BuffSingle || si.SkillAIType == SkillAIType.SkillAIType_BuffAOE)
				{
					List<BattleActor> list6 = BattleActor.FindActorsAlive(this.m_team.GetActors());
					if (list6.Count <= 1)
					{
						return true;
					}
					List<BattleActor> list7 = this.FindActorsInCanAttackAndTouchRange(list6, this.Position, this.GetSkillDistance(si), si.CastSkillShape, false);
					return list7.Count > 0;
				}
				else
				{
					if (si.SkillAIType == SkillAIType.SkillAIType_Dispel)
					{
						List<BattleActor> list8 = this.FindActorsInCanAttackAndTouchRange(BattleActor.FindActorsAlive(this.m_team.GetActors()), this.m_position, this.GetSkillDistance(si), si.CastSkillShape, false);
						return null != list8.Find((BattleActor a) => null != a.m_buffStates.Find((BuffState b) => b.m_buffInfo.IsDebuff));
					}
					if (si.SkillAIType == SkillAIType.SkillAIType_BuffSelf1 || si.SkillAIType == SkillAIType.SkillAIType_BuffSelf2)
					{
						return true;
					}
					if (si.SkillAIType == SkillAIType.SkillAIType_Guard)
					{
						List<BattleActor> destActors = this.FindActorsInCanNormalAttackAndTouchRange(BattleActor.FindActorsAlive(this.m_team.GetActors()), BattleActor.FindActorsAlive(this.m_team.GetOtherTeam().GetActors()));
						return null != this.FindActorsInCanAttackAndTouchRange(destActors, this.m_position, 2, 0, true).Find((BattleActor a) => a != this);
					}
					if (si.SkillAIType == SkillAIType.SkillAIType_NewTurn)
					{
						return null != this.FindActorsInCanAttackAndTouchRange(BattleActor.FindActorsAlive(this.m_team.GetActors()), this.m_position, this.GetSkillDistance(si), si.CastSkillShape, true).Find((BattleActor a) => a != this && a.IsActionFinished());
					}
					if (si.SkillAIType == SkillAIType.SkillAIType_RemoveCD)
					{
						return null != this.FindActorsInCanAttackAndTouchRange(BattleActor.FindActorsAlive(this.m_team.GetActors()), this.m_position, this.GetSkillDistance(si), si.CastSkillShape, false).Find((BattleActor a) => a.m_skillStates.Find((BattleSkillState s) => s.m_cooldown > 0) != null);
					}
					return si.SkillAIType == SkillAIType.SkillAIType_Summon && GridPosition.Null != this.FindEmptyGridInCanAttackAndTouchRange(this.m_position, this.GetSkillDistance(si), si.CastSkillShape);
				}
			}
		}

		// Token: 0x0600329D RID: 12957 RVA: 0x000CEE04 File Offset: 0x000CD004
		private GridPosition FindCastSkillPosition(ConfigDataSkillInfo si, BehaviorTarget t)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindCastSkillPositionConfigDataSkillInfoBehaviorTarget_hotfix != null)
			{
				return (GridPosition)this.m_FindCastSkillPositionConfigDataSkillInfoBehaviorTarget_hotfix.call(new object[]
				{
					this,
					si,
					t
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (si.SkillAIType == SkillAIType.SkillAIType_DamageAssault)
			{
				List<GridPosition> positions = new List<GridPosition>();
				this.FindAttackPositions(this.GetSkillDistance(si), si.CastSkillShape, t.Position, positions);
				return this.FindFarthestPosition(positions, this.Position);
			}
			if (si.SkillAIType == SkillAIType.SkillAIType_DamageAOESelf || si.SkillAIType == SkillAIType.SkillAIType_DamageAOESelfSingle)
			{
				List<BattleActor> beCoveredActors = BattleActor.FindActorsAlive(this.m_team.GetOtherTeam().GetActors());
				List<GridPosition> list = new List<GridPosition>();
				this.FindMoveRegion(this.Position, list);
				return this.FindMaxAoeSkillCoverPosition(si, list.FindAll((GridPosition p) => this.Battle.Map.GetActor(p) == null || this.Position == p), beCoveredActors, null);
			}
			if (si.SkillAIType == SkillAIType.SkillAIType_HealRangeSelf)
			{
				List<BattleActor> list2 = BattleActor.FindActorsAlive(this.m_team.GetActors()).FindAll((BattleActor a) => a != this && a.TotalHPPercent < 0.7f);
				if (list2.Count > 0)
				{
					List<GridPosition> list3 = new List<GridPosition>();
					this.FindMoveRegion(this.Position, list3);
					return this.FindMaxAoeSkillCoverPosition(si, list3.FindAll((GridPosition p) => this.Battle.Map.GetActor(p) == null || this.Position == p), list2, null);
				}
			}
			else if (si.SkillAIType == SkillAIType.SkillAIType_BuffSingle || si.SkillAIType == SkillAIType.SkillAIType_BuffAOE || si.SkillAIType == SkillAIType.SkillAIType_Dispel || si.SkillAIType == SkillAIType.SkillAIType_BuffSelf2 || si.SkillAIType == SkillAIType.SkillAIType_RemoveCD)
			{
				if (this == t.Actor)
				{
					this.SelectMoveTarget();
					if (this.m_moveTarget != null && !this.m_moveTarget.IsEmpty())
					{
						GridPosition gridPosition = this.FindPositionToMoveToTarget(this.m_moveTarget.Position);
						if (gridPosition != GridPosition.Null)
						{
							return gridPosition;
						}
					}
				}
			}
			else if (si.SkillAIType == SkillAIType.SkillAIType_Guard)
			{
				List<BattleActor> destActors = this.FindActorsInCanNormalAttackAndTouchRange(BattleActor.FindActorsAlive(this.m_team.GetActors()), BattleActor.FindActorsAlive(this.m_team.GetOtherTeam().GetActors()));
				List<BattleActor> inGuardRangeActors = this.FindActorsInCanAttackAndTouchRange(destActors, this.m_position, 2, 0, true).FindAll((BattleActor a) => a != this);
				if (inGuardRangeActors.Count > 0)
				{
					if (inGuardRangeActors.Count == 1)
					{
						return this.FindAttackPosition(2, 0, inGuardRangeActors[0].Position, true, false);
					}
					BattleActor battleActor = Find.MinFloat<BattleActor>(inGuardRangeActors, (BattleActor i) => i.TotalHPPercent);
					if (battleActor.TotalHPPercent < 0.99f)
					{
						return this.FindAttackPosition(2, 0, battleActor.Position, true, false);
					}
					List<GridPosition> list4 = new List<GridPosition>();
					List<GridPosition> guardGrids = new List<GridPosition>();
					this.FindMoveRegion(this.Position, list4);
					list4 = list4.FindAll((GridPosition p) => this.Battle.Map.GetActor(p) == null || this.Position == p);
					if (list4.Count > 0)
					{
						return Find.MaxInt<GridPosition>(list4, delegate(GridPosition p)
						{
							this.Battle.FindAttackRegion(p, 2, 0, guardGrids);
							return this.FindActorsInGrids(inGuardRangeActors, guardGrids).Count;
						});
					}
				}
			}
			else if (si.SkillAIType == SkillAIType.SkillAIType_Summon && t != null && this.m_moveTarget != null && !this.m_moveTarget.IsEmpty())
			{
				GridPosition gridPosition2 = this.FindPositionToMoveToTarget(this.m_moveTarget.Position);
				if (gridPosition2 != GridPosition.Null)
				{
					return gridPosition2;
				}
			}
			return this.FindAttackPosition(this.GetSkillDistance(si), si.CastSkillShape, t.Position, true, si.IsDamageSkill());
		}

		// Token: 0x0600329E RID: 12958 RVA: 0x000CF218 File Offset: 0x000CD418
		private void FindAttackPositions(int attackDistance, int shape, GridPosition targetPos, List<GridPosition> positions)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindAttackPositionsInt32Int32GridPositionList`1_hotfix != null)
			{
				this.m_FindAttackPositionsInt32Int32GridPositionList`1_hotfix.call(new object[]
				{
					this,
					attackDistance,
					shape,
					targetPos,
					positions
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (positions == null)
			{
				return;
			}
			positions.Clear();
			BattleBase battle = this.Battle;
			BattleMap map = battle.Map;
			GridPosition @null = GridPosition.Null;
			List<GridPosition> list = battle.AllocateTempGridPositionList();
			battle.FindAttackRegion(targetPos, attackDistance, shape, list);
			foreach (GridPosition gridPosition in list)
			{
				if (map.HasRegionBit(gridPosition, 1))
				{
					BattleActor actor = map.GetActor(gridPosition);
					if (actor == null || actor == this)
					{
						positions.Add(gridPosition);
					}
				}
			}
			battle.FreeTempGridPositionList(list);
		}

		// Token: 0x0600329F RID: 12959 RVA: 0x000CF374 File Offset: 0x000CD574
		private void GenerateCommandOfAttack()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GenerateCommandOfAttack_hotfix != null)
			{
				this.m_GenerateCommandOfAttack_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_attackTarget == null)
			{
				return;
			}
			if (this.m_attackSkillIndex >= 0)
			{
				ConfigDataSkillInfo skillInfo = this.m_skillStates[this.m_attackSkillIndex].m_skillInfo;
				this.FindMoveAndAttackRegion(this.GetSkillDistance(skillInfo), skillInfo.CastSkillShape);
				GridPosition gridPosition = this.FindCastSkillPosition(skillInfo, this.m_attackTarget);
				if (gridPosition != GridPosition.Null)
				{
					if (this.Battle.IsEnableDebugLog())
					{
						DebugUtility.Log(string.Format("!@# {3} Use skill {2}, Move to pre-attack position: {0}, {1}.", new object[]
						{
							gridPosition.x,
							gridPosition.y,
							skillInfo.Name,
							this.InstanceID
						}));
					}
					BattleCommand battleCommand = this.AICreateBattleCommand(BattleCommandType.Move);
					battleCommand.TargetPosition = gridPosition;
					BattleCommand battleCommand2 = this.AICreateBattleCommand(BattleCommandType.Skill);
					battleCommand2.SkillIndex = this.m_attackSkillIndex;
					battleCommand2.TargetPosition = ((!(this.m_attackTarget.Position == this.Position) || skillInfo.SkillAIType == SkillAIType.SkillAIType_Summon) ? this.m_attackTarget.Position : gridPosition);
				}
				else
				{
					this.GenerateCommandOfMove(this.m_attackTarget.Position);
					this.AICreateBattleCommand(BattleCommandType.Done);
				}
			}
			else
			{
				this.FindMoveAndAttackRegion(this.GetMaxAttackDistance(), 0);
				GridPosition gridPosition2 = this.FindAttackPosition(this.GetMaxAttackDistance(), 0, this.m_attackTarget.Position, true, true);
				if (gridPosition2 != GridPosition.Null)
				{
					if (this.Battle.IsEnableDebugLog())
					{
						DebugUtility.Log(string.Format("!@# {2} use Normal attack, Move to pre-attack position: {0}, {1}.", gridPosition2.x, gridPosition2.y, this.InstanceID));
					}
					BattleCommand battleCommand3 = this.AICreateBattleCommand(BattleCommandType.Move);
					battleCommand3.TargetPosition = gridPosition2;
					BattleCommand battleCommand4 = this.AICreateBattleCommand(BattleCommandType.Combat);
					battleCommand4.TargetPosition = this.m_attackTarget.Position;
					return;
				}
				gridPosition2 = this.FindAttackPosition(this.GetMaxAttackDistance(), 0, this.m_attackTarget.Position, false, true);
				if (gridPosition2 != GridPosition.Null)
				{
					this.GenerateCommandOfMove(gridPosition2);
					this.AICreateBattleCommand(BattleCommandType.Done);
				}
				else if (this.Battle.IsEnableDebugLog())
				{
					DebugUtility.LogError(string.Format("!@# {0} found no attack position.", this.InstanceID));
				}
			}
		}

		// Token: 0x060032A0 RID: 12960 RVA: 0x000CF61C File Offset: 0x000CD81C
		private void DoBehaviorMove()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DoBehaviorMove_hotfix != null)
			{
				this.m_DoBehaviorMove_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SelectMoveTarget();
			if (this.m_moveTarget != null)
			{
				this.GenerateCommandOfMove(this.m_moveTarget.Position);
			}
			this.AICreateBattleCommand(BattleCommandType.Done);
		}

		// Token: 0x060032A1 RID: 12961 RVA: 0x000CF6A8 File Offset: 0x000CD8A8
		private bool IsAttackTargetStillValid()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsAttackTargetStillValid_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsAttackTargetStillValid_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_attackTarget != null && this.m_curBehaviorCfg != null && (this.m_curBehaviorCfg.SelectAttackTarget != SelectTarget.SelectTarget_TargetInSkillRange || GridPosition.Distance(this.m_attackTarget.Position, this.Position) <= this.GetSkillDistance(this.BehaviorSelectSkillInfo));
		}

		// Token: 0x060032A2 RID: 12962 RVA: 0x000CF768 File Offset: 0x000CD968
		private void DoBehaviorAttack()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DoBehaviorAttack_hotfix != null)
			{
				this.m_DoBehaviorAttack_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SelectSkill();
			if (this.m_attackTarget == null || this.CheckBehaviorCondition(this.m_curBehaviorCfg.ReselectAttackTargetCondition, this.m_curBehaviorCfg.RATCParamData) || !this.CanUseSkillOnTarget(this.BehaviorSelectSkillInfo, this.m_attackTarget.Actor) || !this.IsAttackTargetStillValid())
			{
				this.SelectAttackTarget();
				if (this.m_attackTarget == null || this.m_attackTarget.IsEmpty())
				{
					this.DoBehaviorMove();
					return;
				}
			}
			this.GenerateCommandOfAttack();
		}

		// Token: 0x060032A3 RID: 12963 RVA: 0x000CF850 File Offset: 0x000CDA50
		public void GenerateAIBattleCommand()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GenerateAIBattleCommand_hotfix != null)
			{
				this.m_GenerateAIBattleCommand_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.Battle.IsEnableDebugLog())
			{
				DebugUtility.Log(string.Format("{0} GenerateAIBattleCommand.", this.InstanceID));
			}
			StopwatchManager.Start(0);
			if (this.m_curBehaviorCfg == null)
			{
				this.AICreateBattleCommand(BattleCommandType.Done);
				return;
			}
			this.m_aiCreateBattleCommandCount = 0;
			this.SelectMoveTarget();
			this.DoBehaviorChangeRules();
			if (this.m_curBehaviorState == BattleActor.BehaviorState.Move)
			{
				if (this.CheckBehaviorCondition(this.m_curBehaviorCfg.StartAttackCondition, this.m_curBehaviorCfg.StartACParamData) && this.CanAttackOrUseSkill())
				{
					this.SetBehaviorState(BattleActor.BehaviorState.Attack);
				}
			}
			else
			{
				if (this.m_curBehaviorState != BattleActor.BehaviorState.Attack)
				{
					return;
				}
				if (this.CheckBehaviorCondition(this.m_curBehaviorCfg.StopAttackCondition, this.m_curBehaviorCfg.StopACParamData) || !this.CanAttackOrUseSkill())
				{
					this.SetBehaviorState(BattleActor.BehaviorState.Move);
				}
			}
			if (this.m_curBehaviorState == BattleActor.BehaviorState.Move)
			{
				this.DoBehaviorMove();
			}
			else if (this.m_curBehaviorState == BattleActor.BehaviorState.Attack)
			{
				this.DoBehaviorAttack();
			}
			if (this.m_aiCreateBattleCommandCount == 0)
			{
				this.AICreateBattleCommand(BattleCommandType.Done);
			}
			StopwatchManager.Stop(0, "GenerateAIPlyaerCommand()");
		}

		// Token: 0x060032A4 RID: 12964 RVA: 0x000CF9D0 File Offset: 0x000CDBD0
		private BattleCommand AICreateBattleCommand(BattleCommandType type)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AICreateBattleCommandBattleCommandType_hotfix != null)
			{
				return (BattleCommand)this.m_AICreateBattleCommandBattleCommandType_hotfix.call(new object[]
				{
					this,
					type
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_aiCreateBattleCommandCount++;
			return this.CreateBattleCommand(type);
		}

		// Token: 0x060032A5 RID: 12965 RVA: 0x000CFA64 File Offset: 0x000CDC64
		private BattleActor SelectAttackRegionTarget(BattleTeam team, BattleActor.ComputeActorScoreFunc computeScore, int computeScoreParam = 0)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SelectAttackRegionTargetBattleTeamComputeActorScoreFuncInt32_hotfix != null)
			{
				return (BattleActor)this.m_SelectAttackRegionTargetBattleTeamComputeActorScoreFuncInt32_hotfix.call(new object[]
				{
					this,
					team,
					computeScore,
					computeScoreParam
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleActor result = null;
			int num = -1;
			int num2 = 10000;
			BattleMap map = this.Battle.Map;
			foreach (BattleActor battleActor in team.GetActors())
			{
				if (map.HasRegionBit(battleActor.Position, 2))
				{
					if (battleActor.CanBeTarget())
					{
						int num3 = computeScore(battleActor, computeScoreParam);
						if (num3 >= 0)
						{
							if (num3 > num)
							{
								result = battleActor;
								num = num3;
								num2 = GridPosition.Distance(this.m_position, battleActor.m_position);
							}
							else if (num3 == num)
							{
								int num4 = GridPosition.Distance(this.m_position, battleActor.m_position);
								if (num4 < num2)
								{
									result = battleActor;
									num2 = num4;
								}
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x060032A6 RID: 12966 RVA: 0x000CFBF4 File Offset: 0x000CDDF4
		public List<BuffState> GetBuffStates()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetBuffStates_hotfix != null)
			{
				return (List<BuffState>)this.m_GetBuffStates_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_buffStates;
		}

		// Token: 0x060032A7 RID: 12967 RVA: 0x000CFC68 File Offset: 0x000CDE68
		private void InitializeBuffs()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitializeBuffs_hotfix != null)
			{
				this.m_InitializeBuffs_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = this.Battle.ConfigDataLoader;
			foreach (BattleSkillState battleSkillState in this.m_skillStates)
			{
				this.AttachPassiveSkillBuffs(battleSkillState.m_skillInfo, BuffSourceType.PassiveSkill);
			}
			ConfigDataSkillInfo talentSkillInfo = this.GetTalentSkillInfo();
			if (talentSkillInfo != null)
			{
				this.AttachPassiveSkillBuffs(talentSkillInfo, BuffSourceType.TalentPassiveSkill);
			}
			if (this.m_heroInfo.m_hiddenSkillInfos != null)
			{
				foreach (ConfigDataSkillInfo skillInfo in this.m_heroInfo.m_hiddenSkillInfos)
				{
					this.AttachPassiveSkillBuffs(skillInfo, BuffSourceType.JobPassiveSkill);
				}
			}
			if (this.m_jobConnectionInfo.m_jobInfo.m_jobSkillInfos != null)
			{
				foreach (ConfigDataSkillInfo skillInfo2 in this.m_jobConnectionInfo.m_jobInfo.m_jobSkillInfos)
				{
					this.AttachPassiveSkillBuffs(skillInfo2, BuffSourceType.JobPassiveSkill);
				}
			}
			if (this.m_equipments != null)
			{
				foreach (BattleActorEquipment battleActorEquipment in this.m_equipments)
				{
					ConfigDataSkillInfo configDataSkillInfo = configDataLoader.GetConfigDataSkillInfo(battleActorEquipment.GetActiveSkillId());
					if (configDataSkillInfo != null)
					{
						this.AttachPassiveSkillBuffs(configDataSkillInfo, BuffSourceType.EquipmentPassiveSkill);
					}
				}
			}
			if (this.m_resonanceSkillInfos != null)
			{
				foreach (ConfigDataSkillInfo skillInfo3 in this.m_resonanceSkillInfos)
				{
					this.AttachPassiveSkillBuffs(skillInfo3, BuffSourceType.EquipmentPassiveSkill);
				}
			}
			if (this.m_fetterSkillInfos != null)
			{
				foreach (ConfigDataSkillInfo skillInfo4 in this.m_fetterSkillInfos)
				{
					this.AttachPassiveSkillBuffs(skillInfo4, BuffSourceType.FetterPassiveSkill);
				}
			}
			this.UpdateAllAuras();
			int num = 0;
			BattlePlayer battlePlayer = null;
			if (this.Battle.ArenaBattleInfo != null)
			{
				battlePlayer = this.Battle.GetBattlePlayer(this.TeamNumber);
			}
			else if ((this.IsPlayerActor() && !this.IsNpc()) || (this.Battle.BattleType == BattleType.None && this.HeroInfo.Useable))
			{
				battlePlayer = this.Battle.GetBattlePlayer(this.m_playerIndex);
			}
			if (battlePlayer != null)
			{
				if (this.IsSummoned())
				{
					List<ConfigDataSkillInfo> trainingTechSummonSkills = battlePlayer.GetTrainingTechSummonSkills(configDataLoader, this.m_heroInfo);
					foreach (ConfigDataSkillInfo skillInfo5 in trainingTechSummonSkills)
					{
						this.AttachPassiveSkillBuffs(skillInfo5, BuffSourceType.TrainingTechPassiveSkill);
					}
				}
				if (this.m_soldierInfo != null)
				{
					List<ConfigDataSkillInfo> trainingTechSoldierSkillInfos = battlePlayer.GetTrainingTechSoldierSkillInfos(configDataLoader, this.m_soldierInfo, out num);
					foreach (ConfigDataSkillInfo skillInfo6 in trainingTechSoldierSkillInfos)
					{
						this.AttachPassiveSkillBuffs(skillInfo6, BuffSourceType.TrainingTechPassiveSkill);
					}
				}
			}
			if (this.m_soldierInfo != null)
			{
				ConfigDataSkillInfo levelUpSkillInfo = this.m_soldierInfo.GetLevelUpSkillInfo(num);
				if (levelUpSkillInfo != null)
				{
					this.AttachPassiveSkillBuffs(levelUpSkillInfo, (num <= 0) ? BuffSourceType.SoldierPassiveSkill : BuffSourceType.TrainingTechPassiveSkill);
				}
			}
			if (this.m_heroModelSkinResourceInfo != null && this.m_heroModelSkinResourceInfo.m_skinSkillInfo != null)
			{
				this.AttachPassiveSkillBuffs(this.m_heroModelSkinResourceInfo.m_skinSkillInfo, BuffSourceType.SkinPassiveSkill);
			}
			if (this.m_soldierModelSkinResourceInfo != null && this.m_soldierModelSkinResourceInfo.m_skinSkillInfo != null)
			{
				this.AttachPassiveSkillBuffs(this.m_soldierModelSkinResourceInfo.m_skinSkillInfo, BuffSourceType.SkinPassiveSkill);
			}
			if (this.Battle.ArenaBattleInfo != null)
			{
				ConfigDataPlayerLevelInfo maxPlayerLevelInfo = this.Battle.MaxPlayerLevelInfo;
				if (maxPlayerLevelInfo != null)
				{
					ConfigDataBuffInfo configDataBuffInfo = configDataLoader.GetConfigDataBuffInfo(maxPlayerLevelInfo.ArenaBuffID);
					if (configDataBuffInfo != null)
					{
						this.AttachBuff(configDataBuffInfo, this, BuffSourceType.RuleApply, null, null);
					}
				}
			}
			if (this.Battle.PVPBattleInfo != null || this.Battle.RealTimePVPBattleInfo != null)
			{
				ConfigDataPlayerLevelInfo maxPlayerLevelInfo2 = this.Battle.MaxPlayerLevelInfo;
				if (maxPlayerLevelInfo2 != null)
				{
					ConfigDataBuffInfo configDataBuffInfo2 = configDataLoader.GetConfigDataBuffInfo(maxPlayerLevelInfo2.PVPBuffID);
					if (configDataBuffInfo2 != null)
					{
						this.AttachBuff(configDataBuffInfo2, this, BuffSourceType.RuleApply, null, null);
					}
				}
			}
			if (this.m_extraPassiveSkillInfos != null)
			{
				foreach (ConfigDataSkillInfo skillInfo7 in this.m_extraPassiveSkillInfos)
				{
					this.AttachPassiveSkillBuffs(skillInfo7, BuffSourceType.RuleApply);
				}
			}
		}

		// Token: 0x060032A8 RID: 12968 RVA: 0x000D0164 File Offset: 0x000CE364
		private void AttachPassiveSkillBuffs(ConfigDataSkillInfo skillInfo, BuffSourceType sourceType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AttachPassiveSkillBuffsConfigDataSkillInfoBuffSourceType_hotfix != null)
			{
				this.m_AttachPassiveSkillBuffsConfigDataSkillInfoBuffSourceType_hotfix.call(new object[]
				{
					this,
					skillInfo,
					sourceType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (skillInfo == null)
			{
				return;
			}
			if (skillInfo.m_passiveBuffInfos != null)
			{
				foreach (ConfigDataBuffInfo buffInfo in skillInfo.m_passiveBuffInfos)
				{
					this.AttachBuff(buffInfo, this, sourceType, skillInfo, null);
				}
			}
		}

		// Token: 0x060032A9 RID: 12969 RVA: 0x000D0224 File Offset: 0x000CE424
		public bool AttachBuff(ConfigDataBuffInfo buffInfo, BattleActor applyer, BuffSourceType sourceType, ConfigDataSkillInfo sourceSkillInfo, BuffState sourceBuffState)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AttachBuffConfigDataBuffInfoBattleActorBuffSourceTypeConfigDataSkillInfoBuffState_hotfix != null)
			{
				return Convert.ToBoolean(this.m_AttachBuffConfigDataBuffInfoBattleActorBuffSourceTypeConfigDataSkillInfoBuffState_hotfix.call(new object[]
				{
					this,
					buffInfo,
					applyer,
					sourceType,
					sourceSkillInfo,
					sourceBuffState
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (buffInfo == null)
			{
				return false;
			}
			if (applyer == null)
			{
				return false;
			}
			if (this.IsDeadOrRetreat())
			{
				return false;
			}
			if (sourceType != BuffSourceType.AuraApply)
			{
				if (buffInfo.IsEnhance && this.HasFightTag(FightTag.FightTag_BanBuff))
				{
					this.Battle.Listener.OnBattleActorImmune(this);
					return false;
				}
				if (buffInfo.IsDebuff && this.HasFightTag(FightTag.FightTag_BanDeBuff))
				{
					this.Battle.Listener.OnBattleActorImmune(this);
					return false;
				}
				if (this.IsImmuneBuffSubType(buffInfo.SubType))
				{
					this.Battle.Listener.OnBattleActorImmune(this);
					return false;
				}
			}
			if (sourceType == BuffSourceType.BuffApply)
			{
				this.Battle.Listener.OnBattleActorPassiveSkill(applyer, this, sourceBuffState);
			}
			int num = -1;
			if (buffInfo.ReplaceRule == 0)
			{
				for (int i = 0; i < this.m_buffStates.Count; i++)
				{
					BuffState buffState = this.m_buffStates[i];
					if (!buffState.IsChild())
					{
						if (buffInfo.SubType != 0 && buffState.m_buffInfo.SubType == buffInfo.SubType)
						{
							if (buffInfo.ReplacePriority >= buffState.m_buffInfo.ReplacePriority)
							{
								num = i;
								break;
							}
							return false;
						}
					}
				}
			}
			else if (buffInfo.ReplaceRule == 1)
			{
				for (int j = 0; j < this.m_buffStates.Count; j++)
				{
					BuffState buffState2 = this.m_buffStates[j];
					if (!buffState2.IsChild())
					{
						if (buffState2.m_buffInfo.ID == buffInfo.ID)
						{
							num = j;
							break;
						}
					}
				}
			}
			else if (buffInfo.ReplaceRule == 3 && this.ComputeBuffCount(buffInfo.ID) >= buffInfo.ReplacePriority)
			{
				int num2 = 9999;
				for (int k = 0; k < this.m_buffStates.Count; k++)
				{
					BuffState buffState3 = this.m_buffStates[k];
					if (!buffState3.IsChild())
					{
						if (buffState3.m_buffInfo.ID == buffInfo.ID && buffState3.m_time < num2)
						{
							num = k;
							num2 = buffState3.m_time;
						}
					}
				}
			}
			if (num >= 0)
			{
				this.RemoveBuff(this.m_buffStates[num]);
			}
			this.m_buffIdCounter++;
			BuffState buffState4 = new BuffState(this.m_buffIdCounter, buffInfo, applyer, sourceType, sourceSkillInfo);
			if (buffState4.m_time > 0 && applyer == this && this.Battle.GetActionActor() == this && !buffInfo.SelfNoExtraTime)
			{
				buffState4.m_hasExtraTime = true;
			}
			this.m_buffStates.Add(buffState4);
			this.SetBuffType(buffInfo.BuffType, true);
			List<BuffState> list = null;
			if (buffInfo.BuffType == BuffType.BuffType_BuffPack)
			{
				list = this.Battle.AllocateTempBuffStateList(null);
				foreach (int key in buffInfo.BuffTypeParam4)
				{
					ConfigDataBuffInfo configDataBuffInfo = this.Battle.ConfigDataLoader.GetConfigDataBuffInfo(key);
					if (configDataBuffInfo != null)
					{
						this.m_buffIdCounter++;
						BuffState buffState5 = new BuffState(this.m_buffIdCounter, configDataBuffInfo, applyer, sourceType, sourceSkillInfo);
						buffState5.m_parent = buffState4;
						buffState5.m_time = buffState4.m_time;
						buffState5.m_hasExtraTime = buffState4.m_hasExtraTime;
						this.m_buffStates.Add(buffState5);
						this.SetBuffType(configDataBuffInfo.BuffType, true);
						list.Add(buffState5);
					}
				}
			}
			List<BuffState> buffStates = this.m_buffStates;
			if (BattleActor.<>f__mg$cache1 == null)
			{
				BattleActor.<>f__mg$cache1 = new Comparison<BuffState>(BattleActor.CompareBuffOrder);
			}
			buffStates.Sort(BattleActor.<>f__mg$cache1);
			for (int l = 0; l < this.m_buffStates.Count; l++)
			{
				this.m_buffStates[l].m_displayOrder = l;
			}
			this.UpdateBattleProperties();
			this.Battle.Listener.OnBattleActorAttachBuff(this, buffState4);
			if (list != null)
			{
				foreach (BuffState buffState6 in list)
				{
					this.Battle.Listener.OnBattleActorAttachBuff(this, buffState6);
				}
				this.Battle.FreeTempBuffStateList(list);
			}
			return true;
		}

		// Token: 0x060032AA RID: 12970 RVA: 0x000D0784 File Offset: 0x000CE984
		private static int CompareBuffOrder(BuffState b0, BuffState b1)
		{
			if (b0.m_buffInfo.IsInfiniteTime() || b1.m_buffInfo.IsInfiniteTime())
			{
				int num = b0.m_buffInfo.Time - b1.m_buffInfo.Time;
				if (num != 0)
				{
					return num;
				}
			}
			return b0.m_id - b1.m_id;
		}

		// Token: 0x060032AB RID: 12971 RVA: 0x000D07E0 File Offset: 0x000CE9E0
		private bool RemoveBuff(BuffState bs)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RemoveBuffBuffState_hotfix != null)
			{
				return Convert.ToBoolean(this.m_RemoveBuffBuffState_hotfix.call(new object[]
				{
					this,
					bs
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_buffStates.IndexOf(bs);
			if (num >= 0)
			{
				this.m_buffStates.RemoveAt(num);
				this.UpdateBuffTypes();
				this.UpdateBattleProperties();
				this.Battle.Listener.OnBattleActorDetachBuff(this, bs);
				if (bs.m_buffInfo.IsAuraBuff())
				{
					this.RemoveAuraAppliedBuffs(bs.m_buffInfo);
				}
				if (bs.m_buffInfo.BuffType == BuffType.BuffType_BuffPack)
				{
					this.RemovePackChildBuffs(bs);
				}
				return true;
			}
			return false;
		}

		// Token: 0x060032AC RID: 12972 RVA: 0x000D08D4 File Offset: 0x000CEAD4
		public int RemoveBuffList(List<int> buffIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RemoveBuffListList`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_RemoveBuffListList`1_hotfix.call(new object[]
				{
					this,
					buffIds
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<BuffState> list = this.Battle.AllocateTempBuffStateList(null);
			foreach (BuffState buffState in this.m_buffStates)
			{
				if (buffIds.Contains(buffState.m_buffInfo.ID))
				{
					list.Add(buffState);
				}
			}
			foreach (BuffState bs in list)
			{
				this.RemoveBuff(bs);
			}
			this.Battle.FreeTempBuffStateList(list);
			return list.Count;
		}

		// Token: 0x060032AD RID: 12973 RVA: 0x000D0A1C File Offset: 0x000CEC1C
		private int RemoveBuffList(List<int> buffIds, BattleActor applyer)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RemoveBuffListList`1BattleActor_hotfix != null)
			{
				return Convert.ToInt32(this.m_RemoveBuffListList`1BattleActor_hotfix.call(new object[]
				{
					this,
					buffIds,
					applyer
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<BuffState> list = this.Battle.AllocateTempBuffStateList(null);
			foreach (BuffState buffState in this.m_buffStates)
			{
				if (buffState.m_applyer == applyer && buffIds.Contains(buffState.m_buffInfo.ID))
				{
					list.Add(buffState);
				}
			}
			foreach (BuffState bs in list)
			{
				this.RemoveBuff(bs);
			}
			this.Battle.FreeTempBuffStateList(list);
			return list.Count;
		}

		// Token: 0x060032AE RID: 12974 RVA: 0x000D0B80 File Offset: 0x000CED80
		private BuffState FindBuff(int buffId, BattleActor applyer)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindBuffInt32BattleActor_hotfix != null)
			{
				return (BuffState)this.m_FindBuffInt32BattleActor_hotfix.call(new object[]
				{
					this,
					buffId,
					applyer
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BuffState buffState in this.m_buffStates)
			{
				if (buffState.m_applyer == applyer && buffState.m_buffInfo.ID == buffId)
				{
					return buffState;
				}
			}
			return null;
		}

		// Token: 0x060032AF RID: 12975 RVA: 0x000D0C7C File Offset: 0x000CEE7C
		private void RemoveAllBuffs()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RemoveAllBuffs_hotfix != null)
			{
				this.m_RemoveAllBuffs_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<BuffState> list = this.Battle.AllocateTempBuffStateList(this.m_buffStates);
			foreach (BuffState bs in list)
			{
				this.RemoveBuff(bs);
			}
			this.Battle.FreeTempBuffStateList(list);
		}

		// Token: 0x060032B0 RID: 12976 RVA: 0x000D0D48 File Offset: 0x000CEF48
		public void SkillDispelBuff(ConfigDataSkillInfo skillInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SkillDispelBuffConfigDataSkillInfo_hotfix != null)
			{
				this.m_SkillDispelBuffConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					skillInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (skillInfo == null)
			{
				return;
			}
			bool flag = skillInfo.IsMagicDamageSkill();
			bool flag2 = skillInfo.IsHealSkill() || skillInfo.IsBuffSkill();
			if (!flag && !flag2)
			{
				return;
			}
			int skillTypeParam = skillInfo.SkillTypeParam1;
			if (skillTypeParam == 0)
			{
				return;
			}
			int skillTypeParam2 = skillInfo.SkillTypeParam2;
			if (skillTypeParam2 <= 0)
			{
				return;
			}
			List<BuffState> list = this.Battle.AllocateTempBuffStateList(this.m_buffStates);
			this.Battle.RandomizeBuffStateList(list);
			int num = 0;
			foreach (BuffState buffState in list)
			{
				if (!buffState.CanNotDispel())
				{
					if (skillTypeParam == -1 || skillTypeParam == buffState.m_buffInfo.SubType)
					{
						if (((flag && buffState.m_buffInfo.IsEnhance) || (flag2 && buffState.m_buffInfo.IsDebuff)) && this.RemoveBuff(buffState))
						{
							num++;
							if (num >= skillTypeParam2)
							{
								break;
							}
						}
					}
				}
			}
			this.Battle.FreeTempBuffStateList(list);
		}

		// Token: 0x060032B1 RID: 12977 RVA: 0x000D0EF8 File Offset: 0x000CF0F8
		private bool HasBuff(int buffId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasBuffInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasBuffInt32_hotfix.call(new object[]
				{
					this,
					buffId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (buffId == 0)
			{
				return false;
			}
			foreach (BuffState buffState in this.m_buffStates)
			{
				if (buffState.m_buffInfo.ID == buffId)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060032B2 RID: 12978 RVA: 0x000D0FE0 File Offset: 0x000CF1E0
		private void CollectBuffPropertyModifiersAndFightTags(BattlePropertyModifier pm, ref uint fightTags)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectBuffPropertyModifiersAndFightTagsBattlePropertyModifierUInt32__hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_ProjectL_Battle_BattleActor_CollectBuffPropertyModifiersAndFightTags_BattlePropertyModifier_UInt32(this, this.m_CollectBuffPropertyModifiersAndFightTagsBattlePropertyModifierUInt32__hotfix, pm, ref fightTags);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.CollectBuffPropertyModifiersAndFightTags(pm, ref fightTags, true, true);
		}

		// Token: 0x060032B3 RID: 12979 RVA: 0x000D1040 File Offset: 0x000CF240
		public void CollectBuffPropertyModifiersAndFightTags(BattlePropertyModifier pm, ref uint fightTags, bool collectStatic, bool collectDynamic)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectBuffPropertyModifiersAndFightTagsBattlePropertyModifierUInt32_BooleanBoolean_hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_ProjectL_Battle_BattleActor_CollectBuffPropertyModifiersAndFightTags_BattlePropertyModifier_UInt32_Boolean_Boolean(this, this.m_CollectBuffPropertyModifiersAndFightTagsBattlePropertyModifierUInt32_BooleanBoolean_hotfix, pm, ref fightTags, collectStatic, collectDynamic);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BuffState buffState in this.m_buffStates)
			{
				ConfigDataBuffInfo buffInfo = buffState.m_buffInfo;
				if (buffInfo.BuffType != BuffType.BuffType_CombatPropertiesModify)
				{
					if (this.IsBuffEffective(buffState))
					{
						if (buffInfo.BuffType == BuffType.BuffType_PropertiesModify)
						{
							if (buffInfo.BuffTypeParam2 == 1)
							{
								continue;
							}
							if (buffInfo.BuffTypeParam3 == 1)
							{
								continue;
							}
							if (buffInfo.BuffTypeParam4.Count > 0)
							{
								int num = buffInfo.BuffTypeParam4[0];
								if (num != 0 && num != this.HeroArmyId)
								{
									continue;
								}
							}
						}
						if (collectStatic && collectDynamic)
						{
							pm.Collect(buffInfo.Property1_ID, buffInfo.Property1_Value);
							pm.Collect(buffInfo.Property2_ID, buffInfo.Property2_Value);
							pm.Collect(buffInfo.Property3_ID, buffInfo.Property3_Value);
							pm.Collect(buffInfo.Property4_ID, buffInfo.Property4_Value);
						}
						else
						{
							this.CollectPropertyModifier(pm, buffInfo.Property1_ID, buffInfo.Property1_Value, collectStatic, collectDynamic);
							this.CollectPropertyModifier(pm, buffInfo.Property2_ID, buffInfo.Property2_Value, collectStatic, collectDynamic);
							this.CollectPropertyModifier(pm, buffInfo.Property3_ID, buffInfo.Property3_Value, collectStatic, collectDynamic);
							this.CollectPropertyModifier(pm, buffInfo.Property4_ID, buffInfo.Property4_Value, collectStatic, collectDynamic);
						}
						foreach (FightTag idx in buffInfo.FightTags)
						{
							fightTags = MathUtility.SetBit(fightTags, (int)idx, true);
						}
						if (collectDynamic)
						{
							if (buffInfo.BuffType == BuffType.BuffType_Charge)
							{
								if (this.m_actionMoveGrids > 0)
								{
									int num2 = this.m_actionMoveGrids * buffInfo.BuffTypeParam1;
									if (buffInfo.BuffTypeParam1 > 0)
									{
										if (num2 > buffInfo.BuffTypeParam2)
										{
											num2 = buffInfo.BuffTypeParam2;
										}
									}
									else if (buffInfo.BuffTypeParam1 < 0 && num2 < buffInfo.BuffTypeParam2)
									{
										num2 = buffInfo.BuffTypeParam2;
									}
									pm.Collect(buffInfo.BuffTypeParam5, num2);
								}
							}
							else if (buffInfo.BuffType == BuffType.BuffType_FieldArmy)
							{
								ConfigDataTerrainInfo terrain = this.GetTerrain();
								if (terrain != null && terrain.BattleBonus != 0)
								{
									int value = terrain.BattleBonus * buffInfo.BuffTypeParam2 * 100;
									pm.Collect(buffInfo.BuffTypeParam5, value);
								}
							}
							else if (buffInfo.BuffType == BuffType.BuffType_TerrainAdv)
							{
								ConfigDataTerrainInfo buffEffectedTerrain = this.GetBuffEffectedTerrain();
								if (buffEffectedTerrain != null && buffEffectedTerrain.ID == buffInfo.BuffTypeParam1)
								{
									pm.Collect(buffInfo.BuffTypeParam5, buffInfo.BuffTypeParam2);
								}
							}
							else if (buffInfo.BuffType == BuffType.BuffType_TeamBuff)
							{
								int buffTypeParam = buffInfo.BuffTypeParam3;
								int num3 = 0;
								foreach (BattleActor battleActor in this.m_team.GetActors())
								{
									if (battleActor.HasBuffType(BuffType.BuffType_TeamBuff))
									{
										if (!battleActor.IsDeadOrRetreat())
										{
											foreach (BuffState buffState2 in battleActor.m_buffStates)
											{
												ConfigDataBuffInfo buffInfo2 = buffState2.m_buffInfo;
												if (buffInfo2.BuffType == BuffType.BuffType_TeamBuff)
												{
													if (buffInfo2.BuffTypeParam3 == buffTypeParam)
													{
														num3++;
													}
												}
											}
										}
									}
								}
								if (num3 > 0)
								{
									int num4 = num3 * buffInfo.BuffTypeParam1;
									if (num4 > buffInfo.BuffTypeParam2)
									{
										num4 = buffInfo.BuffTypeParam2;
									}
									pm.Collect(buffInfo.BuffTypeParam5, num4);
								}
							}
							else if (buffInfo.BuffType == BuffType.BuffType_BuffPropertiesModify)
							{
								int enhanceDebuffType = 0;
								if (buffInfo.BuffTypeParam6.Count > 0)
								{
									enhanceDebuffType = buffInfo.BuffTypeParam6[0];
								}
								int num5 = this.ComputeEnhanceOrDebuffCount(enhanceDebuffType);
								if (num5 > 0)
								{
									int num6 = num5 * buffInfo.BuffTypeParam1;
									if (num6 > buffInfo.BuffTypeParam2)
									{
										num6 = buffInfo.BuffTypeParam2;
									}
									pm.Collect(buffInfo.BuffTypeParam5, num6);
								}
							}
						}
					}
				}
			}
			if (collectDynamic)
			{
				this.CollectOtherActorBuffPropertyModifiersAndFightTags(pm, ref fightTags);
			}
		}

		// Token: 0x060032B4 RID: 12980 RVA: 0x000D1570 File Offset: 0x000CF770
		private void CollectPropertyModifier(BattlePropertyModifier pm, PropertyModifyType modifyType, int value, bool collectStatic, bool collectDynamic)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectPropertyModifierBattlePropertyModifierPropertyModifyTypeInt32BooleanBoolean_hotfix != null)
			{
				this.m_CollectPropertyModifierBattlePropertyModifierPropertyModifyTypeInt32BooleanBoolean_hotfix.call(new object[]
				{
					this,
					pm,
					modifyType,
					value,
					collectStatic,
					collectDynamic
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataPropertyModifyInfo configDataPropertyModifyInfo = this.Battle.ConfigDataLoader.GetConfigDataPropertyModifyInfo((int)modifyType);
			if (configDataPropertyModifyInfo != null && ((!configDataPropertyModifyInfo.IsDynamic && collectStatic) || (configDataPropertyModifyInfo.IsDynamic && collectDynamic)))
			{
				pm.Collect(modifyType, value);
			}
		}

		// Token: 0x060032B5 RID: 12981 RVA: 0x000D1664 File Offset: 0x000CF864
		private void CollectOtherActorBuffPropertyModifiersAndFightTags(BattlePropertyModifier pm, ref uint fightTags)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectOtherActorBuffPropertyModifiersAndFightTagsBattlePropertyModifierUInt32__hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_ProjectL_Battle_BattleActor_CollectOtherActorBuffPropertyModifiersAndFightTags_BattlePropertyModifier_UInt32(this, this.m_CollectOtherActorBuffPropertyModifiersAndFightTagsBattlePropertyModifierUInt32__hotfix, pm, ref fightTags);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			for (int i = 0; i < 2; i++)
			{
				foreach (BattleActor battleActor in this.Battle.GetTeam(i).GetActors())
				{
					if (battleActor.HasBuffType(BuffType.BuffType_PropertiesModify))
					{
						if (!battleActor.IsDeadOrRetreat())
						{
							if (battleActor != this)
							{
								foreach (BuffState buffState in battleActor.m_buffStates)
								{
									ConfigDataBuffInfo buffInfo = buffState.m_buffInfo;
									if (buffInfo.BuffType == BuffType.BuffType_PropertiesModify)
									{
										if (buffInfo.BuffTypeParam1 != 0)
										{
											if (buffInfo.BuffTypeParam1 <= 0 || GridPosition.Distance(this.m_position, battleActor.m_position) <= buffInfo.BuffTypeParam1)
											{
												if (buffInfo.BuffTypeParam4.Count > 0)
												{
													int num = buffInfo.BuffTypeParam4[0];
													if (num != 0 && num != this.HeroArmyId)
													{
														continue;
													}
												}
												if (battleActor.IsBuffEffective(buffState))
												{
													if (buffInfo.BuffTypeParam2 == 0)
													{
														if (i != this.TeamNumber)
														{
															continue;
														}
													}
													else if (buffInfo.BuffTypeParam2 == 1 && i == this.TeamNumber)
													{
														continue;
													}
													pm.Collect(buffInfo.Property1_ID, buffInfo.Property1_Value);
													pm.Collect(buffInfo.Property2_ID, buffInfo.Property2_Value);
													pm.Collect(buffInfo.Property3_ID, buffInfo.Property3_Value);
													pm.Collect(buffInfo.Property4_ID, buffInfo.Property4_Value);
													foreach (FightTag idx in buffInfo.FightTags)
													{
														fightTags = MathUtility.SetBit(fightTags, (int)idx, true);
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060032B6 RID: 12982 RVA: 0x000D193C File Offset: 0x000CFB3C
		private void CollectBuffPropertyModifiersAndFightTagsInCombat(BattlePropertyModifier pm, ref uint fightTags, BattleActor target, bool isAttacker, int distance)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectBuffPropertyModifiersAndFightTagsInCombatBattlePropertyModifierUInt32_BattleActorBooleanInt32_hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_ProjectL_Battle_BattleActor_CollectBuffPropertyModifiersAndFightTagsInCombat_BattlePropertyModifier_UInt32_BattleActor_Boolean_Int32(this, this.m_CollectBuffPropertyModifiersAndFightTagsInCombatBattlePropertyModifierUInt32_BattleActorBooleanInt32_hotfix, pm, ref fightTags, target, isAttacker, distance);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasBuffType(BuffType.BuffType_CombatPropertiesModify))
			{
				return;
			}
			foreach (BuffState buffState in this.m_buffStates)
			{
				ConfigDataBuffInfo buffInfo = buffState.m_buffInfo;
				if (buffInfo.BuffType == BuffType.BuffType_CombatPropertiesModify)
				{
					if (this.IsBuffEffective(buffState))
					{
						if (this.IsBuffCombatConditionSatisfied(target, isAttacker, distance, buffInfo.BuffTypeParam1, buffInfo.BuffTypeParam2, buffInfo.BuffTypeParam3))
						{
							if (buffInfo.BuffTypeParam4.Count < 3 || target.IsBuffHpConditionSatisfied(buffInfo.BuffTypeParam4[0], buffInfo.BuffTypeParam4[1], buffInfo.BuffTypeParam4[2]))
							{
								if (buffInfo.BuffTypeParam6.Count >= 3)
								{
									if (buffInfo.BuffTypeParam6[0] == 1)
									{
										if (this.ComputeEnhanceOrDebuffCount(buffInfo.BuffTypeParam6[1]) < buffInfo.BuffTypeParam6[2])
										{
											continue;
										}
									}
									else if (buffInfo.BuffTypeParam6[0] == 2 && target.ComputeEnhanceOrDebuffCount(buffInfo.BuffTypeParam6[1]) < buffInfo.BuffTypeParam6[2])
									{
										continue;
									}
								}
								pm.Collect(buffInfo.Property1_ID, buffInfo.Property1_Value);
								pm.Collect(buffInfo.Property2_ID, buffInfo.Property2_Value);
								pm.Collect(buffInfo.Property3_ID, buffInfo.Property3_Value);
								pm.Collect(buffInfo.Property4_ID, buffInfo.Property4_Value);
								foreach (FightTag idx in buffInfo.FightTags)
								{
									fightTags = MathUtility.SetBit(fightTags, (int)idx, true);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060032B7 RID: 12983 RVA: 0x000D1BBC File Offset: 0x000CFDBC
		public void CollectBuffPropertyExchange(BattleProperty battleProperty, BattlePropertyModifier pm)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectBuffPropertyExchangeBattlePropertyBattlePropertyModifier_hotfix != null)
			{
				this.m_CollectBuffPropertyExchangeBattlePropertyBattlePropertyModifier_hotfix.call(new object[]
				{
					this,
					battleProperty,
					pm
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasBuffType(BuffType.BuffType_PropertiesExchange))
			{
				return;
			}
			foreach (BuffState buffState in this.m_buffStates)
			{
				ConfigDataBuffInfo buffInfo = buffState.m_buffInfo;
				if (buffInfo.BuffType == BuffType.BuffType_PropertiesExchange)
				{
					if (this.IsBuffEffective(buffState))
					{
						int value = 0;
						switch (buffInfo.BuffTypeParam1)
						{
						case 1:
							value = battleProperty.Attack;
							break;
						case 2:
							value = battleProperty.Magic;
							break;
						case 3:
							value = battleProperty.Defense;
							break;
						case 4:
							value = battleProperty.MagicDefense;
							break;
						case 5:
							value = battleProperty.Dexterity;
							break;
						case 6:
							value = battleProperty.HealthPointMax;
							break;
						}
						int num = BattleFormula.ComputeBuffExchangeValue(value, buffInfo.BuffTypeParam3);
						switch (buffInfo.BuffTypeParam2)
						{
						case 1:
							pm.ExchangeAttack += num;
							break;
						case 2:
							pm.ExchangeMagic += num;
							break;
						case 3:
							pm.ExchangeDefense += num;
							break;
						case 4:
							pm.ExchangeMagicDefense += num;
							break;
						case 5:
							pm.ExchangeDexterity += num;
							break;
						case 6:
							pm.ExchangeHealthPointMax += num;
							break;
						}
					}
				}
			}
		}

		// Token: 0x060032B8 RID: 12984 RVA: 0x000D1DF4 File Offset: 0x000CFFF4
		public void CollectBuffPropertyReplace()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectBuffPropertyReplace_hotfix != null)
			{
				this.m_CollectBuffPropertyReplace_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasBuffType(BuffType.BuffType_BattlePropertiesSet))
			{
				return;
			}
			foreach (BuffState buffState in this.m_buffStates)
			{
				ConfigDataBuffInfo buffInfo = buffState.m_buffInfo;
				if (buffInfo.BuffType == BuffType.BuffType_BattlePropertiesSet)
				{
					if (this.IsBuffEffective(buffState))
					{
						int buffTypeParam = buffInfo.BuffTypeParam1;
						if (buffTypeParam == 1)
						{
							this.m_buffReplaceMovePoint = buffInfo.BuffTypeParam2;
						}
					}
				}
			}
		}

		// Token: 0x060032B9 RID: 12985 RVA: 0x000D1EF8 File Offset: 0x000D00F8
		public void UpdateAllAuras()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateAllAuras_hotfix != null)
			{
				this.m_UpdateAllAuras_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<BattleActor> list = this.Battle.AllocateTempActorList();
			List<BattleActor> list2 = this.Battle.AllocateTempActorList();
			for (int i = 0; i < 2; i++)
			{
				foreach (BattleActor battleActor in this.Battle.GetTeam(i).GetActors())
				{
					list.Add(battleActor);
					if (battleActor.HasBuffType(BuffType.BuffType_HeroAura) || battleActor.HasBuffType(BuffType.BuffType_TagAura))
					{
						list2.Add(battleActor);
					}
				}
			}
			foreach (BattleActor battleActor2 in list2)
			{
				List<BuffState> list3 = this.Battle.AllocateTempBuffStateList(null);
				foreach (BuffState buffState in battleActor2.m_buffStates)
				{
					if (buffState.m_buffInfo.IsAuraBuff())
					{
						list3.Add(buffState);
					}
				}
				foreach (BuffState buffState2 in list3)
				{
					ConfigDataBuffInfo buffInfo = buffState2.m_buffInfo;
					foreach (BattleActor battleActor3 in list)
					{
						bool flag = true;
						if (battleActor2.IsDeadOrRetreat() || !battleActor2.IsBuffEffective(buffState2))
						{
							flag = false;
						}
						if (flag)
						{
							if (buffInfo.BuffTypeParam1 == 0)
							{
								if (battleActor2 != battleActor3)
								{
									flag = false;
								}
							}
							else if (buffInfo.BuffTypeParam1 > 0 && GridPosition.Distance(battleActor2.m_position, battleActor3.m_position) > buffInfo.BuffTypeParam1)
							{
								flag = false;
							}
						}
						if (flag)
						{
							if (buffInfo.BuffTypeParam2 == 0)
							{
								if (battleActor2.TeamNumber != battleActor3.TeamNumber)
								{
									flag = false;
								}
							}
							else if (buffInfo.BuffTypeParam2 == 1 && battleActor2.TeamNumber == battleActor3.TeamNumber)
							{
								flag = false;
							}
						}
						if (flag && buffInfo.BuffTypeParam3 == 1 && battleActor2 == battleActor3)
						{
							flag = false;
						}
						if (flag)
						{
							if (buffInfo.BuffType == BuffType.BuffType_HeroAura)
							{
								if (buffInfo.BuffTypeParam4.Count > 0)
								{
									int num = buffInfo.BuffTypeParam4[0];
									if (num != 0 && num != battleActor3.HeroArmyId)
									{
										flag = false;
									}
								}
							}
							else if (buffInfo.BuffType == BuffType.BuffType_TagAura && buffInfo.BuffTypeParam4.Count > 0)
							{
								int num2 = buffInfo.BuffTypeParam4[0];
								if (num2 != 0 && !battleActor3.HeroInfo.m_heroTagIds.Contains(num2))
								{
									flag = false;
								}
							}
						}
						foreach (int num3 in buffInfo.BuffTypeParam6)
						{
							BuffState buffState3 = battleActor3.FindBuff(num3, battleActor2);
							if (flag)
							{
								if (buffState3 == null)
								{
									ConfigDataBuffInfo configDataBuffInfo = this.Battle.ConfigDataLoader.GetConfigDataBuffInfo(num3);
									if (configDataBuffInfo != null)
									{
										battleActor3.AttachBuff(configDataBuffInfo, battleActor2, BuffSourceType.AuraApply, null, buffState2);
									}
								}
							}
							else if (buffState3 != null)
							{
								battleActor3.RemoveBuff(buffState3);
							}
						}
					}
				}
				this.Battle.FreeTempBuffStateList(list3);
			}
			this.Battle.FreeTempActorList(list2);
			this.Battle.FreeTempActorList(list);
		}

		// Token: 0x060032BA RID: 12986 RVA: 0x000D23D4 File Offset: 0x000D05D4
		private void RemoveAuraAppliedBuffs(ConfigDataBuffInfo auraBuffInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RemoveAuraAppliedBuffsConfigDataBuffInfo_hotfix != null)
			{
				this.m_RemoveAuraAppliedBuffsConfigDataBuffInfo_hotfix.call(new object[]
				{
					this,
					auraBuffInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!auraBuffInfo.IsAuraBuff())
			{
				return;
			}
			for (int i = 0; i < 2; i++)
			{
				foreach (BattleActor battleActor in this.Battle.GetTeam(i).GetActors())
				{
					battleActor.RemoveBuffList(auraBuffInfo.BuffTypeParam6, this);
				}
			}
		}

		// Token: 0x060032BB RID: 12987 RVA: 0x000D24C4 File Offset: 0x000D06C4
		private void RemovePackChildBuffs(BuffState packBuff)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RemovePackChildBuffsBuffState_hotfix != null)
			{
				this.m_RemovePackChildBuffsBuffState_hotfix.call(new object[]
				{
					this,
					packBuff
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<BuffState> list = this.Battle.AllocateTempBuffStateList(null);
			foreach (BuffState buffState in this.m_buffStates)
			{
				if (buffState.m_parent == packBuff)
				{
					list.Add(buffState);
				}
			}
			foreach (BuffState bs in list)
			{
				this.RemoveBuff(bs);
			}
			this.Battle.FreeTempBuffStateList(list);
		}

		// Token: 0x060032BC RID: 12988 RVA: 0x000D25F0 File Offset: 0x000D07F0
		private void OnBuffHit(BuffState buffState, int heroHpModify, int soldierHpModify, DamageNumberType damageNumberType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBuffHitBuffStateInt32Int32DamageNumberType_hotfix != null)
			{
				this.m_OnBuffHitBuffStateInt32Int32DamageNumberType_hotfix.call(new object[]
				{
					this,
					buffState,
					heroHpModify,
					soldierHpModify,
					damageNumberType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetHeroHealthPoint(this.m_heroHealthPoint + heroHpModify);
			this.SetSoldierTotalHealthPoint(this.m_soldierTotalHealthPoint + soldierHpModify);
			this.UpdateBattleProperties();
			this.Battle.Listener.OnBattleActorBuffHit(this, buffState, heroHpModify, soldierHpModify, damageNumberType);
		}

		// Token: 0x060032BD RID: 12989 RVA: 0x000D26C8 File Offset: 0x000D08C8
		public bool HasFightTag(FightTag ft)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasFightTagFightTag_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasFightTagFightTag_hotfix.call(new object[]
				{
					this,
					ft
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return MathUtility.GetBit(this.m_fightTags, (int)ft);
		}

		// Token: 0x060032BE RID: 12990 RVA: 0x000D2750 File Offset: 0x000D0950
		private void UpdateBuffTypes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateBuffTypes_hotfix != null)
			{
				this.m_UpdateBuffTypes_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_buffTypes = 0UL;
			foreach (BuffState buffState in this.m_buffStates)
			{
				this.SetBuffType(buffState.m_buffInfo.BuffType, true);
			}
		}

		// Token: 0x060032BF RID: 12991 RVA: 0x000D2814 File Offset: 0x000D0A14
		private void SetBuffType(BuffType bt, bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBuffTypeBuffTypeBoolean_hotfix != null)
			{
				this.m_SetBuffTypeBuffTypeBoolean_hotfix.call(new object[]
				{
					this,
					bt,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_buffTypes = MathUtility.SetBit(this.m_buffTypes, (int)bt, on);
		}

		// Token: 0x060032C0 RID: 12992 RVA: 0x000D28A8 File Offset: 0x000D0AA8
		public bool HasBuffType(BuffType bt)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasBuffTypeBuffType_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasBuffTypeBuffType_hotfix.call(new object[]
				{
					this,
					bt
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return MathUtility.GetBit(this.m_buffTypes, (int)bt);
		}

		// Token: 0x060032C1 RID: 12993 RVA: 0x000D2930 File Offset: 0x000D0B30
		public bool IsBuffEffective(BuffState bs)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsBuffEffectiveBuffState_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsBuffEffectiveBuffState_hotfix.call(new object[]
				{
					this,
					bs
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return (!this.HasFightTag(FightTag.FightTag_BanPassiveSkill) || bs.m_sourceType != BuffSourceType.PassiveSkill) && this.IsBuffHpConditionSatisfied(bs.m_buffInfo) && this.IsBuffEffectiveConditionSatisfied(bs.m_buffInfo);
		}

		// Token: 0x060032C2 RID: 12994 RVA: 0x000D29F0 File Offset: 0x000D0BF0
		private bool IsBuffHpConditionSatisfied(ConfigDataBuffInfo buffInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsBuffHpConditionSatisfiedConfigDataBuffInfo_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsBuffHpConditionSatisfiedConfigDataBuffInfo_hotfix.call(new object[]
				{
					this,
					buffInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return buffInfo != null && this.IsBuffHpConditionSatisfied(buffInfo.Cond_HP_Operator, buffInfo.Cond_HP_Value, buffInfo.Cond_HP_Target);
		}

		// Token: 0x060032C3 RID: 12995 RVA: 0x000D2A8C File Offset: 0x000D0C8C
		private bool IsBuffHpConditionSatisfied(int operatorType, int value, int targetType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsBuffHpConditionSatisfiedInt32Int32Int32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsBuffHpConditionSatisfiedInt32Int32Int32_hotfix.call(new object[]
				{
					this,
					operatorType,
					value,
					targetType
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (targetType == 0 || operatorType == 0)
			{
				return true;
			}
			int num;
			int num2;
			if (targetType == 2)
			{
				num = this.m_heroHealthPoint;
				num2 = this.m_heroBattleProperty.HealthPointMax;
			}
			else if (targetType == 3)
			{
				num = this.m_soldierTotalHealthPoint;
				num2 = this.m_soldierBattleProperty.HealthPointMax;
			}
			else
			{
				num = this.GetTotalHealthPoint();
				num2 = this.GetTotalHealthPointMax();
			}
			int num3 = 0;
			if (num2 > 0)
			{
				num3 = num * 10000 / num2;
			}
			if (operatorType == 1)
			{
				return num3 <= value;
			}
			if (operatorType == 2)
			{
				return num3 >= value;
			}
			return num3 == value;
		}

		// Token: 0x060032C4 RID: 12996 RVA: 0x000D2BB8 File Offset: 0x000D0DB8
		private bool IsBuffEffectiveConditionSatisfied(ConfigDataBuffInfo buffInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsBuffEffectiveConditionSatisfiedConfigDataBuffInfo_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsBuffEffectiveConditionSatisfiedConfigDataBuffInfo_hotfix.call(new object[]
				{
					this,
					buffInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (buffInfo == null)
			{
				return false;
			}
			if (buffInfo.ConditionType == BuffConditionType.BuffConditionType_None)
			{
				return true;
			}
			if (buffInfo.ConditionType == BuffConditionType.BuffConditionType_IsAlone)
			{
				if (buffInfo.ConditionParam.Count >= 2)
				{
					int distance = buffInfo.ConditionParam[0];
					int teamType = buffInfo.ConditionParam[1];
					return this.ComputeNeighborAliveActorCount(teamType, distance) == 0;
				}
			}
			else if (buffInfo.ConditionType == BuffConditionType.BuffConditionType_NotAlone)
			{
				if (buffInfo.ConditionParam.Count >= 3)
				{
					int distance2 = buffInfo.ConditionParam[0];
					int teamType2 = buffInfo.ConditionParam[1];
					int num = buffInfo.ConditionParam[2];
					return this.ComputeNeighborAliveActorCount(teamType2, distance2) >= num;
				}
			}
			else if (buffInfo.ConditionType == BuffConditionType.BuffConditionType_Terrain)
			{
				ConfigDataTerrainInfo buffEffectedTerrain = this.GetBuffEffectedTerrain();
				if (buffEffectedTerrain != null)
				{
					return buffInfo.ConditionParam.Contains(buffEffectedTerrain.ID);
				}
			}
			else
			{
				if (buffInfo.ConditionType == BuffConditionType.BuffConditionType_HeroArmy)
				{
					return buffInfo.ConditionParam.Contains(this.HeroArmyId);
				}
				if (buffInfo.ConditionType == BuffConditionType.BuffConditionType_TerrainIsDF)
				{
					ConfigDataTerrainInfo buffEffectedTerrain2 = this.GetBuffEffectedTerrain();
					if (buffEffectedTerrain2 != null)
					{
						int num2 = 0;
						if (buffInfo.ConditionParam.Count > 0)
						{
							num2 = buffInfo.ConditionParam[0];
						}
						if (num2 == 0)
						{
							return buffEffectedTerrain2.BattleBonus == 0;
						}
						return buffEffectedTerrain2.BattleBonus != 0;
					}
				}
			}
			return false;
		}

		// Token: 0x060032C5 RID: 12997 RVA: 0x000D2D9C File Offset: 0x000D0F9C
		private bool IsBuffCombatConditionSatisfied(BattleActor target, bool isAttacker, int distance, int param1, int param2, int param3)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsBuffCombatConditionSatisfiedBattleActorBooleanInt32Int32Int32Int32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsBuffCombatConditionSatisfiedBattleActorBooleanInt32Int32Int32Int32_hotfix.call(new object[]
				{
					this,
					target,
					isAttacker,
					distance,
					param1,
					param2,
					param3
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (param1 == 1)
			{
				if (!isAttacker)
				{
					return false;
				}
			}
			else if (param1 == 2 && isAttacker)
			{
				return false;
			}
			if (param2 == 1)
			{
				if (distance > 1)
				{
					return false;
				}
			}
			else if (param2 == 2 && distance <= 1)
			{
				return false;
			}
			if (param3 == 1)
			{
				int num = this.GetTotalHealthPoint() * 10000 / this.GetTotalHealthPointMax();
				int num2 = target.GetTotalHealthPoint() * 10000 / target.GetTotalHealthPointMax();
				if (num <= num2)
				{
					return false;
				}
			}
			else if (param3 == 2)
			{
				int num3 = this.GetTotalHealthPoint() * 10000 / this.GetTotalHealthPointMax();
				int num4 = target.GetTotalHealthPoint() * 10000 / target.GetTotalHealthPointMax();
				if (num3 >= num4)
				{
					return false;
				}
			}
			else if (param3 == 3)
			{
				if (this.GetTotalHealthPoint() <= target.GetTotalHealthPoint())
				{
					return false;
				}
			}
			else if (param3 == 4 && this.GetTotalHealthPoint() >= target.GetTotalHealthPoint())
			{
				return false;
			}
			return true;
		}

		// Token: 0x060032C6 RID: 12998 RVA: 0x000D2F6C File Offset: 0x000D116C
		private bool IsBuffCombatConditionSatisfied(BattleActor target, bool beforeCombat, bool isAttacker, int distance, bool isCritical, List<int> paramList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsBuffCombatConditionSatisfiedBattleActorBooleanBooleanInt32BooleanList`1_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsBuffCombatConditionSatisfiedBattleActorBooleanBooleanInt32BooleanList`1_hotfix.call(new object[]
				{
					this,
					target,
					beforeCombat,
					isAttacker,
					distance,
					isCritical,
					paramList
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (paramList.Count >= 4)
			{
				if (paramList[0] == 1)
				{
					if (!beforeCombat)
					{
						return false;
					}
				}
				else if (paramList[0] == 2 && beforeCombat)
				{
					return false;
				}
				if (!this.IsBuffCombatConditionSatisfied(target, isAttacker, distance, paramList[1], paramList[2], paramList[3]))
				{
					return false;
				}
				if (paramList.Count > 4 && paramList[4] == 1 && !isCritical)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060032C7 RID: 12999 RVA: 0x000D30C4 File Offset: 0x000D12C4
		private int ComputeNeighborAliveActorCount(int teamType, int distance)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeNeighborAliveActorCountInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_ComputeNeighborAliveActorCountInt32Int32_hotfix.call(new object[]
				{
					this,
					teamType,
					distance
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = -1;
			if (teamType == 0)
			{
				num = this.TeamNumber;
			}
			else if (teamType == 1)
			{
				num = 1 - this.TeamNumber;
			}
			int num2 = 0;
			for (int i = 0; i < 2; i++)
			{
				if (num == -1 || num == i)
				{
					BattleTeam team = this.Battle.GetTeam(i);
					foreach (BattleActor battleActor in team.GetActors())
					{
						if (battleActor != this)
						{
							if (!battleActor.IsDeadOrRetreat() && !battleActor.IsSummoned() && GridPosition.Distance(this.m_position, battleActor.m_position) <= distance)
							{
								num2++;
							}
						}
					}
				}
			}
			return num2;
		}

		// Token: 0x060032C8 RID: 13000 RVA: 0x000D3234 File Offset: 0x000D1434
		private bool IsBuffCooldown(BuffState bs)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsBuffCooldownBuffState_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsBuffCooldownBuffState_hotfix.call(new object[]
				{
					this,
					bs
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataBuffInfo cdBuffInfo = bs.m_buffInfo.m_cdBuffInfo;
			return cdBuffInfo != null && this.HasBuff(cdBuffInfo.ID);
		}

		// Token: 0x060032C9 RID: 13001 RVA: 0x000D32D8 File Offset: 0x000D14D8
		private void StartBuffCooldown(BuffState bs)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartBuffCooldownBuffState_hotfix != null)
			{
				this.m_StartBuffCooldownBuffState_hotfix.call(new object[]
				{
					this,
					bs
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataBuffInfo cdBuffInfo = bs.m_buffInfo.m_cdBuffInfo;
			if (cdBuffInfo == null)
			{
				return;
			}
			if (this.HasBuff(cdBuffInfo.ID))
			{
				return;
			}
			this.AttachBuff(cdBuffInfo, this, BuffSourceType.CooldownApply, null, bs);
		}

		// Token: 0x060032CA RID: 13002 RVA: 0x000D337C File Offset: 0x000D157C
		private int ComputeBuffCount(int buffId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeBuffCountInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_ComputeBuffCountInt32_hotfix.call(new object[]
				{
					this,
					buffId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			foreach (BuffState buffState in this.m_buffStates)
			{
				if (!buffState.IsChild())
				{
					if (buffState.m_buffInfo.ID == buffId)
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x060032CB RID: 13003 RVA: 0x000D3468 File Offset: 0x000D1668
		private int ComputeEnhanceOrDebuffCount(int enhanceDebuffType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeEnhanceOrDebuffCountInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_ComputeEnhanceOrDebuffCountInt32_hotfix.call(new object[]
				{
					this,
					enhanceDebuffType
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			foreach (BuffState buffState in this.m_buffStates)
			{
				if (!buffState.IsChild())
				{
					ConfigDataBuffInfo buffInfo = buffState.m_buffInfo;
					if (enhanceDebuffType == 0)
					{
						if (buffInfo.IsEnhance || buffInfo.IsDebuff)
						{
							num++;
						}
					}
					else if (enhanceDebuffType == 1)
					{
						if (buffInfo.IsEnhance)
						{
							num++;
						}
					}
					else if (enhanceDebuffType == 2 && buffInfo.IsDebuff)
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x060032CC RID: 13004 RVA: 0x000D359C File Offset: 0x000D179C
		private bool IsImmuneBuffSubType(int subType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsImmuneBuffSubTypeInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsImmuneBuffSubTypeInt32_hotfix.call(new object[]
				{
					this,
					subType
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasBuffType(BuffType.BuffType_Immune))
			{
				return false;
			}
			foreach (BuffState buffState in this.m_buffStates)
			{
				if (buffState.m_buffInfo.BuffType == BuffType.BuffType_Immune)
				{
					if (this.IsBuffEffective(buffState))
					{
						foreach (int num in buffState.m_buffInfo.BuffTypeParam4)
						{
							if (num == subType)
							{
								return true;
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x060032CD RID: 13005 RVA: 0x000D36F4 File Offset: 0x000D18F4
		public int ComputeBuffReboundDamage(ConfigDataSkillInfo skillInfo, int damage)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeBuffReboundDamageConfigDataSkillInfoInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_ComputeBuffReboundDamageConfigDataSkillInfoInt32_hotfix.call(new object[]
				{
					this,
					skillInfo,
					damage
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (skillInfo == null || damage == 0)
			{
				return 0;
			}
			if (!this.HasBuffType(BuffType.BuffType_DamageRebound))
			{
				return 0;
			}
			int num = 0;
			foreach (BuffState buffState in this.m_buffStates)
			{
				ConfigDataBuffInfo buffInfo = buffState.m_buffInfo;
				if (buffInfo.BuffType == BuffType.BuffType_DamageRebound)
				{
					if (this.IsBuffEffective(buffState))
					{
						if (buffInfo.BuffTypeParam1 == 1)
						{
							if (!skillInfo.IsPhysicalDamageSkill() || skillInfo.BF_Distance > 1)
							{
								continue;
							}
						}
						else if (buffInfo.BuffTypeParam1 == 2)
						{
							if (!skillInfo.IsPhysicalDamageSkill() || skillInfo.BF_Distance <= 1)
							{
								continue;
							}
						}
						else if (buffInfo.BuffTypeParam1 == 3 && !skillInfo.IsMagicDamageSkill())
						{
							continue;
						}
						num += BattleFormula.ComputeBuffDamageValue(damage, buffInfo.BuffTypeParam2);
					}
				}
			}
			return num;
		}

		// Token: 0x060032CE RID: 13006 RVA: 0x000D3898 File Offset: 0x000D1A98
		public int GetBuffOverrideMovePointCost()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetBuffOverrideMovePointCost_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetBuffOverrideMovePointCost_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataTerrainInfo buffOverrideTerrain = this.GetBuffOverrideTerrain();
			if (buffOverrideTerrain != null)
			{
				return BattleMap.GetMovePointCost(buffOverrideTerrain, this.GetMoveType());
			}
			return 0;
		}

		// Token: 0x060032CF RID: 13007 RVA: 0x000D3920 File Offset: 0x000D1B20
		public ConfigDataTerrainInfo GetBuffOverrideTerrain()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetBuffOverrideTerrain_hotfix != null)
			{
				return (ConfigDataTerrainInfo)this.m_GetBuffOverrideTerrain_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasBuffType(BuffType.BuffType_FieldArmy))
			{
				return null;
			}
			foreach (BuffState buffState in this.m_buffStates)
			{
				ConfigDataBuffInfo buffInfo = buffState.m_buffInfo;
				if (buffInfo.BuffType == BuffType.BuffType_FieldArmy)
				{
					return this.Battle.ConfigDataLoader.GetConfigDataTerrainInfo(buffInfo.BuffTypeParam1);
				}
			}
			return null;
		}

		// Token: 0x060032D0 RID: 13008 RVA: 0x000D3A14 File Offset: 0x000D1C14
		public void AddBuffArmyRelationAttack(int targetArmyId, bool targetIsHero, ref ArmyRelationData armyRelation)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddBuffArmyRelationAttackInt32BooleanArmyRelationData__hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_ProjectL_Battle_BattleActor_AddBuffArmyRelationAttack_Int32_Boolean_ArmyRelationData(this, this.m_AddBuffArmyRelationAttackInt32BooleanArmyRelationData__hotfix, targetArmyId, targetIsHero, ref armyRelation);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasBuffType(BuffType.BuffType_Restrain))
			{
				return;
			}
			foreach (BuffState buffState in this.m_buffStates)
			{
				ConfigDataBuffInfo buffInfo = buffState.m_buffInfo;
				if (buffInfo.BuffType == BuffType.BuffType_Restrain)
				{
					if (buffInfo.BuffTypeParam1 == targetArmyId)
					{
						if ((buffInfo.BuffTypeParam2 != 1 || targetIsHero) && (buffInfo.BuffTypeParam2 != 2 || !targetIsHero))
						{
							if (this.IsBuffEffective(buffState))
							{
								if (buffInfo.BuffTypeParam4.Count > 0)
								{
									armyRelation.Attack += buffInfo.BuffTypeParam4[0];
								}
								if (buffInfo.BuffTypeParam4.Count > 2 && buffInfo.BuffTypeParam2 != 2)
								{
									armyRelation.Magic += buffInfo.BuffTypeParam4[2];
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060032D1 RID: 13009 RVA: 0x000D3B84 File Offset: 0x000D1D84
		public void AddBuffArmyRelationDefend(int targetArmyId, bool targetIsHero, ref ArmyRelationData armyRelation)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddBuffArmyRelationDefendInt32BooleanArmyRelationData__hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_ProjectL_Battle_BattleActor_AddBuffArmyRelationDefend_Int32_Boolean_ArmyRelationData(this, this.m_AddBuffArmyRelationDefendInt32BooleanArmyRelationData__hotfix, targetArmyId, targetIsHero, ref armyRelation);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasBuffType(BuffType.BuffType_Restrain))
			{
				return;
			}
			foreach (BuffState buffState in this.m_buffStates)
			{
				ConfigDataBuffInfo buffInfo = buffState.m_buffInfo;
				if (buffInfo.BuffType == BuffType.BuffType_Restrain)
				{
					if (buffInfo.BuffTypeParam1 == targetArmyId)
					{
						if ((buffInfo.BuffTypeParam2 != 1 || targetIsHero) && (buffInfo.BuffTypeParam2 != 2 || !targetIsHero))
						{
							if (this.IsBuffEffective(buffState))
							{
								if (buffInfo.BuffTypeParam4.Count > 1)
								{
									armyRelation.Defend += buffInfo.BuffTypeParam4[1];
								}
								if (buffInfo.BuffTypeParam4.Count > 3)
								{
									armyRelation.MagicDefend += buffInfo.BuffTypeParam4[3];
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060032D2 RID: 13010 RVA: 0x000D3CE8 File Offset: 0x000D1EE8
		public void AddBuffArmyRelationModifyAttack(int restrainValue, bool targetIsHero, ref ArmyRelationData armyRelation)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddBuffArmyRelationModifyAttackInt32BooleanArmyRelationData__hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_ProjectL_Battle_BattleActor_AddBuffArmyRelationModifyAttack_Int32_Boolean_ArmyRelationData(this, this.m_AddBuffArmyRelationModifyAttackInt32BooleanArmyRelationData__hotfix, restrainValue, targetIsHero, ref armyRelation);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasBuffType(BuffType.BuffType_RelationModify))
			{
				return;
			}
			foreach (BuffState buffState in this.m_buffStates)
			{
				ConfigDataBuffInfo buffInfo = buffState.m_buffInfo;
				if (buffInfo.BuffType == BuffType.BuffType_RelationModify)
				{
					if ((buffInfo.BuffTypeParam1 != 0 || restrainValue > 0) && (buffInfo.BuffTypeParam1 != 1 || restrainValue < 0))
					{
						if ((buffInfo.BuffTypeParam2 != 1 || targetIsHero) && (buffInfo.BuffTypeParam2 != 2 || !targetIsHero))
						{
							if (this.IsBuffEffective(buffState))
							{
								if (buffInfo.BuffTypeParam4.Count > 0)
								{
									armyRelation.Attack += buffInfo.BuffTypeParam4[0];
								}
								if (buffInfo.BuffTypeParam4.Count > 2 && buffInfo.BuffTypeParam2 != 2)
								{
									armyRelation.Magic += buffInfo.BuffTypeParam4[2];
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060032D3 RID: 13011 RVA: 0x000D3E70 File Offset: 0x000D2070
		public void AddBuffArmyRelationModifyDefend(int restrainValue, bool targetIsHero, ref ArmyRelationData armyRelation)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddBuffArmyRelationModifyDefendInt32BooleanArmyRelationData__hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_ProjectL_Battle_BattleActor_AddBuffArmyRelationModifyDefend_Int32_Boolean_ArmyRelationData(this, this.m_AddBuffArmyRelationModifyDefendInt32BooleanArmyRelationData__hotfix, restrainValue, targetIsHero, ref armyRelation);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasBuffType(BuffType.BuffType_RelationModify))
			{
				return;
			}
			foreach (BuffState buffState in this.m_buffStates)
			{
				ConfigDataBuffInfo buffInfo = buffState.m_buffInfo;
				if (buffInfo.BuffType == BuffType.BuffType_RelationModify)
				{
					if ((buffInfo.BuffTypeParam1 != 0 || restrainValue > 0) && (buffInfo.BuffTypeParam1 != 1 || restrainValue < 0))
					{
						if ((buffInfo.BuffTypeParam2 != 1 || targetIsHero) && (buffInfo.BuffTypeParam2 != 2 || !targetIsHero))
						{
							if (this.IsBuffEffective(buffState))
							{
								if (buffInfo.BuffTypeParam4.Count > 1)
								{
									armyRelation.Defend += buffInfo.BuffTypeParam4[1];
								}
								if (buffInfo.BuffTypeParam4.Count > 3)
								{
									armyRelation.MagicDefend += buffInfo.BuffTypeParam4[3];
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060032D4 RID: 13012 RVA: 0x000D3FEC File Offset: 0x000D21EC
		public bool IsBuffForceMagicDamage(bool attackerIsHero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsBuffForceMagicDamageBoolean_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsBuffForceMagicDamageBoolean_hotfix.call(new object[]
				{
					this,
					attackerIsHero
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasBuffType(BuffType.BuffType_MagicAttack))
			{
				return false;
			}
			foreach (BuffState buffState in this.m_buffStates)
			{
				ConfigDataBuffInfo buffInfo = buffState.m_buffInfo;
				if (buffInfo.BuffType == BuffType.BuffType_MagicAttack)
				{
					if ((buffInfo.BuffTypeParam2 != 1 || attackerIsHero) && (buffInfo.BuffTypeParam2 != 2 || !attackerIsHero))
					{
						if (this.IsBuffEffective(buffState))
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x060032D5 RID: 13013 RVA: 0x000D411C File Offset: 0x000D231C
		private void ActionEndBuffEffect()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActionEndBuffEffect_hotfix != null)
			{
				this.m_ActionEndBuffEffect_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsExtraActionMoving())
			{
				this.ActionEndBuffDoubleMove(this.m_isActionKillActor, this.m_isActionCriticalAttack);
				if (this.m_hasExtraMovePoint > 0)
				{
					return;
				}
			}
			this.ActionEndBuffHealOverTime(this.m_isActionDamageActor);
			this.ActionEndBuffDamageOverTime();
			this.ActionEndRemoveDebuff();
			this.ActionEndRemoveEnhanceBuff(this.m_isActionKillActor, this.m_isActionCriticalAttack, this.m_isActionDamageActor);
			this.ActionEndAddBuff();
			this.ActionEndAddBuffSuper(this.m_isActionKillActor, this.m_isActionCriticalAttack);
			this.ActionEndBuffBattlefieldSkill(this.m_isActionKillActor, this.m_isActionCriticalAttack, this.m_isActionDamageActor);
			this.ActionEndBuffNewTurn(this.m_isActionKillActor, this.m_isActionCriticalAttack);
			this.UpdateBuffTime();
		}

		// Token: 0x060032D6 RID: 13014 RVA: 0x000D4220 File Offset: 0x000D2420
		private void UpdateBuffTime()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateBuffTime_hotfix != null)
			{
				this.m_UpdateBuffTime_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<BuffState> list = this.Battle.AllocateTempBuffStateList(this.m_buffStates);
			foreach (BuffState buffState in list)
			{
				if (!buffState.m_buffInfo.IsInfiniteTime())
				{
					if (buffState.m_hasExtraTime)
					{
						buffState.m_hasExtraTime = false;
					}
					else
					{
						buffState.m_time--;
					}
					if (buffState.m_time <= 0)
					{
						this.RemoveBuff(buffState);
					}
				}
			}
			this.Battle.FreeTempBuffStateList(list);
		}

		// Token: 0x060032D7 RID: 13015 RVA: 0x000D4330 File Offset: 0x000D2530
		public void ActionEndBuffDoubleMove(bool isKill, bool isCritical)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActionEndBuffDoubleMoveBooleanBoolean_hotfix != null)
			{
				this.m_ActionEndBuffDoubleMoveBooleanBoolean_hotfix.call(new object[]
				{
					this,
					isKill,
					isCritical
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasExecutedCommandType(BattleCommandType.Combat) && !this.HasExecutedCommandType(BattleCommandType.Skill))
			{
				return;
			}
			if (!this.HasBuffType(BuffType.BuffType_DoubleMove))
			{
				return;
			}
			if (this.IsDeadOrRetreat())
			{
				return;
			}
			this.m_hasExtraMovePoint = 0;
			List<BuffState> list = this.Battle.AllocateTempBuffStateList(this.m_buffStates);
			foreach (BuffState buffState in list)
			{
				ConfigDataBuffInfo buffInfo = buffState.m_buffInfo;
				if (buffInfo.BuffType == BuffType.BuffType_DoubleMove)
				{
					if (this.IsBuffEffective(buffState))
					{
						if (!this.IsBuffCooldown(buffState))
						{
							if (buffInfo.BuffTypeParam3 == 1)
							{
								if (!isKill)
								{
									continue;
								}
							}
							else if (buffInfo.BuffTypeParam3 == 2 && !isCritical)
							{
								continue;
							}
							if (buffInfo.BuffTypeParam4.Count <= 0 || this.m_executedSkillInfo == null || !buffInfo.BuffTypeParam4.Contains((int)this.m_executedSkillInfo.SkillType))
							{
								if (buffInfo.BuffTypeParam1 == 1)
								{
									if (this.m_actionRemainMovePoint > this.m_hasExtraMovePoint)
									{
										this.m_hasExtraMovePoint = this.m_actionRemainMovePoint;
									}
								}
								else if (buffInfo.BuffTypeParam1 == 2 && buffInfo.BuffTypeParam2 > this.m_hasExtraMovePoint)
								{
									this.m_hasExtraMovePoint = buffInfo.BuffTypeParam2;
								}
								this.StartBuffCooldown(buffState);
							}
						}
					}
				}
			}
			this.Battle.FreeTempBuffStateList(list);
		}

		// Token: 0x060032D8 RID: 13016 RVA: 0x000D4560 File Offset: 0x000D2760
		private void ActionEndBuffHealOverTime(bool isDamage)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActionEndBuffHealOverTimeBoolean_hotfix != null)
			{
				this.m_ActionEndBuffHealOverTimeBoolean_hotfix.call(new object[]
				{
					this,
					isDamage
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasBuffType(BuffType.BuffType_HealOverTime))
			{
				return;
			}
			if (this.IsDeadOrRetreat())
			{
				return;
			}
			List<BuffState> list = this.Battle.AllocateTempBuffStateList(this.m_buffStates);
			List<BattleActor> list2 = this.Battle.AllocateTempActorList();
			foreach (BuffState buffState in list)
			{
				ConfigDataBuffInfo buffInfo = buffState.m_buffInfo;
				if (buffInfo.BuffType == BuffType.BuffType_HealOverTime)
				{
					if (this.IsBuffEffective(buffState))
					{
						if (!this.IsBuffCooldown(buffState))
						{
							if (buffInfo.BuffTypeParam6.Count <= 0 || buffInfo.BuffTypeParam6[0] != 1 || isDamage)
							{
								int buffTypeParam = buffInfo.BuffTypeParam3;
								int num = 0;
								int num2 = 9999;
								int num3 = 0;
								if (buffInfo.BuffTypeParam4.Count > 0)
								{
									num = buffInfo.BuffTypeParam4[0];
								}
								if (buffInfo.BuffTypeParam4.Count > 1)
								{
									num2 = buffInfo.BuffTypeParam4[1];
								}
								if (buffInfo.BuffTypeParam4.Count > 2)
								{
									num3 = buffInfo.BuffTypeParam4[2];
								}
								list2.Clear();
								foreach (BattleActor battleActor in this.m_team.GetActors())
								{
									if (!battleActor.IsDeadOrRetreat())
									{
										if (!battleActor.HasFightTag(FightTag.FightTag_BanHeal))
										{
											if (buffTypeParam < 0 || GridPosition.Distance(this.m_position, battleActor.m_position) <= buffTypeParam)
											{
												if (num3 != 1 || battleActor != this)
												{
													list2.Add(battleActor);
												}
											}
										}
									}
								}
								if (list2.Count > 0)
								{
									if (list2.Count > num2)
									{
										List<BattleActor> list3 = list2;
										if (BattleActor.<>f__mg$cache2 == null)
										{
											BattleActor.<>f__mg$cache2 = new Comparison<BattleActor>(BattleActor.CompareHealActor);
										}
										list3.Sort(BattleActor.<>f__mg$cache2);
										list2.RemoveRange(num2, list2.Count - num2);
									}
									int magic = buffState.m_applyer.HeroBattleProperty.Magic;
									int buff_HealMul = buffState.m_applyer.HeroBattleProperty.Buff_HealMul;
									foreach (BattleActor battleActor2 in list2)
									{
										int heroHpModify = 0;
										int soldierHpModify = 0;
										int buff_HealReceiveMul = battleActor2.m_heroBattleProperty.Buff_HealReceiveMul;
										if (buffInfo.BuffTypeParam1 == 1)
										{
											soldierHpModify = (heroHpModify = BattleFormula.ComputeBuffHealValue(magic, buffInfo.BuffTypeParam2, buff_HealMul, buff_HealReceiveMul));
										}
										else if (buffInfo.BuffTypeParam1 == 2)
										{
											heroHpModify = BattleFormula.ComputeBuffHealValue(battleActor2.m_heroBattleProperty.HealthPointMax, buffInfo.BuffTypeParam2, buff_HealMul, buff_HealReceiveMul);
											soldierHpModify = BattleFormula.ComputeBuffHealValue(battleActor2.m_soldierBattleProperty.HealthPointMax, buffInfo.BuffTypeParam2, buff_HealMul, buff_HealReceiveMul);
										}
										if (num > 0)
										{
											if (num == 1)
											{
												soldierHpModify = 0;
											}
											else if (num == 2)
											{
												heroHpModify = 0;
											}
										}
										battleActor2.OnBuffHit(buffState, heroHpModify, soldierHpModify, DamageNumberType.Heal);
										this.StartBuffCooldown(buffState);
									}
								}
							}
						}
					}
				}
			}
			this.Battle.FreeTempActorList(list2);
			this.Battle.FreeTempBuffStateList(list);
		}

		// Token: 0x060032D9 RID: 13017 RVA: 0x000D4998 File Offset: 0x000D2B98
		private void ActionEndBuffDamageOverTime()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActionEndBuffDamageOverTime_hotfix != null)
			{
				this.m_ActionEndBuffDamageOverTime_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasBuffType(BuffType.BuffType_DamageOverTime))
			{
				return;
			}
			if (this.IsDeadOrRetreat())
			{
				return;
			}
			List<BuffState> list = this.Battle.AllocateTempBuffStateList(this.m_buffStates);
			foreach (BuffState buffState in list)
			{
				ConfigDataBuffInfo buffInfo = buffState.m_buffInfo;
				if (buffInfo.BuffType == BuffType.BuffType_DamageOverTime)
				{
					if (this.IsBuffEffective(buffState))
					{
						if (!this.IsBuffCooldown(buffState))
						{
							if (this.HasFightTag(FightTag.FightTag_BanDamage) || this.HasFightTag(FightTag.FightTag_BanPercentDamage))
							{
								this.Battle.Listener.OnBattleActorImmune(this);
							}
							else
							{
								int num = 0;
								int num2 = 0;
								if (buffInfo.BuffTypeParam1 == 1)
								{
									int magic = buffState.m_applyer.HeroBattleProperty.Magic;
									num2 = (num = BattleFormula.ComputeBuffDamageValue(magic, buffInfo.BuffTypeParam2));
								}
								else if (buffInfo.BuffTypeParam1 == 2)
								{
									num = BattleFormula.ComputeBuffDamageValue(this.m_heroBattleProperty.HealthPointMax, buffInfo.BuffTypeParam2);
									num2 = BattleFormula.ComputeBuffDamageValue(this.m_soldierBattleProperty.HealthPointMax, buffInfo.BuffTypeParam2);
								}
								else if (buffInfo.BuffTypeParam1 == 3)
								{
									int attack = buffState.m_applyer.HeroBattleProperty.Attack;
									num2 = (num = BattleFormula.ComputeBuffDamageValue(attack, buffInfo.BuffTypeParam2));
								}
								this.OnBuffHit(buffState, -num, -num2, DamageNumberType.Normal);
								this.CheckDie(null);
							}
							this.StartBuffCooldown(buffState);
						}
					}
				}
			}
			this.Battle.FreeTempBuffStateList(list);
		}

		// Token: 0x060032DA RID: 13018 RVA: 0x000D4BB4 File Offset: 0x000D2DB4
		private void ActionEndAddBuff()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActionEndAddBuff_hotfix != null)
			{
				this.m_ActionEndAddBuff_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasBuffType(BuffType.BuffType_AddBuff))
			{
				return;
			}
			if (this.HasFightTag(FightTag.FightTag_Stun))
			{
				return;
			}
			if (this.IsDeadOrRetreat())
			{
				return;
			}
			List<BuffState> list = this.Battle.AllocateTempBuffStateList(this.m_buffStates);
			List<BattleActor> list2 = this.Battle.AllocateTempActorList();
			foreach (BuffState buffState in list)
			{
				ConfigDataBuffInfo buffInfo = buffState.m_buffInfo;
				if (buffInfo.BuffType == BuffType.BuffType_AddBuff)
				{
					if (this.IsBuffEffective(buffState))
					{
						if (!this.IsBuffCooldown(buffState))
						{
							if (buffInfo.BuffTypeParam4.Count > 0)
							{
								list2.Clear();
								int num = -1;
								if (buffInfo.BuffTypeParam2 == 0)
								{
									num = this.TeamNumber;
								}
								else if (buffInfo.BuffTypeParam2 == 1)
								{
									num = 1 - this.TeamNumber;
								}
								for (int i = 0; i < 2; i++)
								{
									if (num == -1 || num == i)
									{
										BattleTeam team = this.Battle.GetTeam(i);
										foreach (BattleActor battleActor in team.GetActors())
										{
											if (!battleActor.IsDeadOrRetreat())
											{
												if (battleActor != this || buffInfo.BuffTypeParam3 != 1)
												{
													if (buffInfo.BuffTypeParam1 < 0 || GridPosition.Distance(this.m_position, battleActor.m_position) <= buffInfo.BuffTypeParam1)
													{
														list2.Add(battleActor);
													}
												}
											}
										}
									}
								}
								if (buffInfo.BuffTypeParam6.Count > 0)
								{
									while (list2.Count > buffInfo.BuffTypeParam6[0])
									{
										int index = this.Battle.RandomNumber.Next(0, list2.Count);
										list2.RemoveAt(index);
									}
								}
								if (list2.Count > 0)
								{
									foreach (BattleActor battleActor2 in list2)
									{
										int index2 = this.Battle.RandomNumber.Next(0, buffInfo.BuffTypeParam4.Count);
										ConfigDataBuffInfo configDataBuffInfo = this.Battle.ConfigDataLoader.GetConfigDataBuffInfo(buffInfo.BuffTypeParam4[index2]);
										if (configDataBuffInfo != null)
										{
											battleActor2.AttachBuff(configDataBuffInfo, this, BuffSourceType.BuffApply, null, buffState);
										}
										this.StartBuffCooldown(buffState);
									}
								}
							}
						}
					}
				}
			}
			this.Battle.FreeTempActorList(list2);
			this.Battle.FreeTempBuffStateList(list);
		}

		// Token: 0x060032DB RID: 13019 RVA: 0x000D4F4C File Offset: 0x000D314C
		private void ActionEndAddBuffSuper(bool isKill, bool isCritical)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActionEndAddBuffSuperBooleanBoolean_hotfix != null)
			{
				this.m_ActionEndAddBuffSuperBooleanBoolean_hotfix.call(new object[]
				{
					this,
					isKill,
					isCritical
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasBuffType(BuffType.BuffType_AddBuffSuper))
			{
				return;
			}
			if (this.HasFightTag(FightTag.FightTag_Stun))
			{
				return;
			}
			if (this.IsDeadOrRetreat())
			{
				return;
			}
			List<BuffState> list = this.Battle.AllocateTempBuffStateList(this.m_buffStates);
			List<BattleActor> list2 = this.Battle.AllocateTempActorList();
			List<ConfigDataBuffInfo> list3 = this.Battle.AllocateTempBuffList();
			foreach (BuffState buffState in list)
			{
				ConfigDataBuffInfo buffInfo = buffState.m_buffInfo;
				if (buffInfo.BuffType == BuffType.BuffType_AddBuffSuper)
				{
					if (this.IsBuffEffective(buffState))
					{
						if (!this.IsBuffCooldown(buffState))
						{
							if (buffInfo.BuffTypeParam4.Count > 0)
							{
								if (buffInfo.BuffTypeParam6.Count >= 3)
								{
									if (buffInfo.BuffTypeParam6.Count <= 3 || buffInfo.BuffTypeParam6[3] != 1 || isKill)
									{
										if (buffInfo.BuffTypeParam6.Count <= 4 || buffInfo.BuffTypeParam6[4] != 1 || isCritical)
										{
											if (buffInfo.BuffTypeParam6.Count <= 5 || buffInfo.BuffTypeParam6[5] != 1 || this.HasExecutedCommandType(BattleCommandType.Skill))
											{
												if (buffInfo.BuffTypeParam6.Count <= 6 || buffInfo.BuffTypeParam6[6] != 1 || !this.HasExecutedCommandType(BattleCommandType.Combat))
												{
													if (buffInfo.BuffTypeParam6.Count > 7)
													{
														int team = 1 - this.TeamNumber;
														if (buffInfo.BuffTypeParam6[7] == 1)
														{
															if (this.Battle.IsInDangerRegion(team, this.m_position))
															{
																continue;
															}
														}
														else if (buffInfo.BuffTypeParam6[7] == 2 && !this.Battle.IsInDangerRegion(team, this.m_position))
														{
															continue;
														}
													}
													if (this.Battle.IsProbabilitySatisfied(buffInfo.BuffTypeParam2))
													{
														list2.Clear();
														int num = -1;
														if (buffInfo.BuffTypeParam6[1] == 0)
														{
															num = this.TeamNumber;
														}
														else if (buffInfo.BuffTypeParam6[1] == 1)
														{
															num = 1 - this.TeamNumber;
														}
														for (int i = 0; i < 2; i++)
														{
															if (num == -1 || num == i)
															{
																BattleTeam team2 = this.Battle.GetTeam(i);
																foreach (BattleActor battleActor in team2.GetActors())
																{
																	if (!battleActor.IsDeadOrRetreat())
																	{
																		if (battleActor != this || buffInfo.BuffTypeParam3 != 1)
																		{
																			if (buffInfo.BuffTypeParam1 < 0 || GridPosition.Distance(this.m_position, battleActor.m_position) <= buffInfo.BuffTypeParam1)
																			{
																				list2.Add(battleActor);
																			}
																		}
																	}
																}
															}
														}
														while (list2.Count > buffInfo.BuffTypeParam6[0])
														{
															int index = this.Battle.RandomNumber.Next(0, list2.Count);
															list2.RemoveAt(index);
														}
														if (list2.Count > 0)
														{
															foreach (BattleActor battleActor2 in list2)
															{
																this.Battle.GetRandomBuffList(buffInfo.BuffTypeParam4, buffInfo.BuffTypeParam6[2], list3);
																foreach (ConfigDataBuffInfo buffInfo2 in list3)
																{
																	battleActor2.AttachBuff(buffInfo2, this, BuffSourceType.BuffApply, null, buffState);
																}
																this.StartBuffCooldown(buffState);
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			this.Battle.FreeTempBuffList(list3);
			this.Battle.FreeTempActorList(list2);
			this.Battle.FreeTempBuffStateList(list);
		}

		// Token: 0x060032DC RID: 13020 RVA: 0x000D54BC File Offset: 0x000D36BC
		private void ActionEndRemoveDebuff()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActionEndRemoveDebuff_hotfix != null)
			{
				this.m_ActionEndRemoveDebuff_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasBuffType(BuffType.BuffType_RemoveDebuff))
			{
				return;
			}
			if (this.HasFightTag(FightTag.FightTag_Stun))
			{
				return;
			}
			if (this.IsDeadOrRetreat())
			{
				return;
			}
			List<BuffState> list = this.Battle.AllocateTempBuffStateList(this.m_buffStates);
			List<BattleActor> list2 = this.Battle.AllocateTempActorList();
			List<BuffState> list3 = this.Battle.AllocateTempBuffStateList(null);
			foreach (BuffState buffState in list)
			{
				ConfigDataBuffInfo buffInfo = buffState.m_buffInfo;
				if (buffInfo.BuffType == BuffType.BuffType_RemoveDebuff)
				{
					if (this.IsBuffEffective(buffState))
					{
						if (!this.IsBuffCooldown(buffState))
						{
							int num = 0;
							int num2 = 9999;
							int num3 = 9999;
							if (buffInfo.BuffTypeParam6.Count > 0)
							{
								num2 = buffInfo.BuffTypeParam6[0];
							}
							if (buffInfo.BuffTypeParam6.Count > 1)
							{
								num3 = buffInfo.BuffTypeParam6[1];
							}
							list2.Clear();
							foreach (BattleActor battleActor in this.m_team.GetActors())
							{
								if (!battleActor.IsDeadOrRetreat())
								{
									if (battleActor != this || buffInfo.BuffTypeParam3 != 1)
									{
										if (buffInfo.BuffTypeParam2 < 0 || GridPosition.Distance(this.m_position, battleActor.m_position) <= buffInfo.BuffTypeParam2)
										{
											list2.Add(battleActor);
										}
									}
								}
							}
							if (list2.Count > 0)
							{
								if (list2.Count > num3)
								{
									for (int i = 0; i < list2.Count; i++)
									{
										int index = this.Battle.RandomNumber.Next(0, list2.Count);
										BattleActor value = list2[i];
										list2[i] = list2[index];
										list2[index] = value;
									}
								}
								foreach (BattleActor battleActor2 in list2)
								{
									list3.Clear();
									list3.AddRange(battleActor2.m_buffStates);
									this.Battle.RandomizeBuffStateList(list3);
									int num4 = 0;
									foreach (BuffState buffState2 in list3)
									{
										if (!buffState2.CanNotDispel())
										{
											if (buffState2.m_buffInfo.IsDebuff)
											{
												if (num4 == 0)
												{
													this.Battle.Listener.OnBattleActorPassiveSkill(this, battleActor2, buffState);
												}
												if (battleActor2.RemoveBuff(buffState2))
												{
													num4++;
													if (num4 >= num2)
													{
														break;
													}
												}
											}
										}
									}
									if (num4 > 0)
									{
										if (buffInfo.BuffTypeParam1 == 2)
										{
											foreach (int key in buffInfo.BuffTypeParam4)
											{
												ConfigDataBuffInfo configDataBuffInfo = this.Battle.ConfigDataLoader.GetConfigDataBuffInfo(key);
												if (configDataBuffInfo != null)
												{
													battleActor2.AttachBuff(configDataBuffInfo, this, BuffSourceType.BuffApply, null, buffState);
												}
											}
										}
										num++;
										if (num >= num3)
										{
											break;
										}
									}
									this.StartBuffCooldown(buffState);
								}
							}
						}
					}
				}
			}
			this.Battle.FreeTempBuffStateList(list3);
			this.Battle.FreeTempActorList(list2);
			this.Battle.FreeTempBuffStateList(list);
		}

		// Token: 0x060032DD RID: 13021 RVA: 0x000D5974 File Offset: 0x000D3B74
		private void ActionEndRemoveEnhanceBuff(bool isKill, bool isCritical, bool isDamage)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActionEndRemoveEnhanceBuffBooleanBooleanBoolean_hotfix != null)
			{
				this.m_ActionEndRemoveEnhanceBuffBooleanBooleanBoolean_hotfix.call(new object[]
				{
					this,
					isKill,
					isCritical,
					isDamage
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasBuffType(BuffType.BuffType_Removebuff))
			{
				return;
			}
			if (this.HasFightTag(FightTag.FightTag_Stun))
			{
				return;
			}
			if (this.IsDeadOrRetreat())
			{
				return;
			}
			List<BuffState> list = this.Battle.AllocateTempBuffStateList(this.m_buffStates);
			List<BattleActor> list2 = this.Battle.AllocateTempActorList();
			List<BuffState> list3 = this.Battle.AllocateTempBuffStateList(null);
			foreach (BuffState buffState in list)
			{
				ConfigDataBuffInfo buffInfo = buffState.m_buffInfo;
				if (buffInfo.BuffType == BuffType.BuffType_Removebuff)
				{
					if (this.IsBuffEffective(buffState))
					{
						if (!this.IsBuffCooldown(buffState))
						{
							int num = 0;
							int num2 = 9999;
							int num3 = 9999;
							if (buffInfo.BuffTypeParam6.Count > 0)
							{
								num2 = buffInfo.BuffTypeParam6[0];
							}
							if (buffInfo.BuffTypeParam6.Count > 1)
							{
								num3 = buffInfo.BuffTypeParam6[1];
							}
							if (buffInfo.BuffTypeParam6.Count <= 2 || buffInfo.BuffTypeParam6[2] != 1 || isKill)
							{
								if (buffInfo.BuffTypeParam6.Count <= 3 || buffInfo.BuffTypeParam6[3] != 1 || isCritical)
								{
									if (buffInfo.BuffTypeParam6.Count <= 4 || buffInfo.BuffTypeParam6[4] != 1 || this.HasExecutedCommandType(BattleCommandType.Skill))
									{
										if (buffInfo.BuffTypeParam6.Count <= 5 || buffInfo.BuffTypeParam6[5] != 1 || isDamage)
										{
											if (this.Battle.IsProbabilitySatisfied(buffInfo.BuffTypeParam3))
											{
												list2.Clear();
												foreach (BattleActor battleActor in this.m_team.GetOtherTeam().GetActors())
												{
													if (!battleActor.IsDeadOrRetreat())
													{
														if (buffInfo.BuffTypeParam2 < 0 || GridPosition.Distance(this.m_position, battleActor.m_position) <= buffInfo.BuffTypeParam2)
														{
															list2.Add(battleActor);
														}
													}
												}
												if (list2.Count > 0)
												{
													if (list2.Count > num3)
													{
														for (int i = 0; i < list2.Count; i++)
														{
															int index = this.Battle.RandomNumber.Next(0, list2.Count);
															BattleActor value = list2[i];
															list2[i] = list2[index];
															list2[index] = value;
														}
													}
													foreach (BattleActor battleActor2 in list2)
													{
														list3.Clear();
														list3.AddRange(battleActor2.m_buffStates);
														this.Battle.RandomizeBuffStateList(list3);
														int num4 = 0;
														foreach (BuffState buffState2 in list3)
														{
															if (!buffState2.CanNotDispel())
															{
																if (buffState2.m_buffInfo.IsEnhance)
																{
																	if (num4 == 0)
																	{
																		this.Battle.Listener.OnBattleActorPassiveSkill(this, battleActor2, buffState);
																	}
																	if (battleActor2.RemoveBuff(buffState2))
																	{
																		num4++;
																		if (num4 >= num2)
																		{
																			break;
																		}
																	}
																}
															}
														}
														if (num4 > 0)
														{
															if (buffInfo.BuffTypeParam1 == 2)
															{
																foreach (int key in buffInfo.BuffTypeParam4)
																{
																	ConfigDataBuffInfo configDataBuffInfo = this.Battle.ConfigDataLoader.GetConfigDataBuffInfo(key);
																	if (configDataBuffInfo != null)
																	{
																		battleActor2.AttachBuff(configDataBuffInfo, this, BuffSourceType.BuffApply, null, buffState);
																	}
																}
															}
															num++;
															if (num >= num3)
															{
																break;
															}
														}
														this.StartBuffCooldown(buffState);
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			this.Battle.FreeTempBuffStateList(list3);
			this.Battle.FreeTempActorList(list2);
			this.Battle.FreeTempBuffStateList(list);
		}

		// Token: 0x060032DE RID: 13022 RVA: 0x000D5F28 File Offset: 0x000D4128
		private void ActionEndBuffBattlefieldSkill(bool isKill, bool isCritical, bool isDamage)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActionEndBuffBattlefieldSkillBooleanBooleanBoolean_hotfix != null)
			{
				this.m_ActionEndBuffBattlefieldSkillBooleanBooleanBoolean_hotfix.call(new object[]
				{
					this,
					isKill,
					isCritical,
					isDamage
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.HasFightTag(FightTag.FightTag_Stun))
			{
				return;
			}
			if (!this.HasBuffType(BuffType.BuffType_BFSkill))
			{
				return;
			}
			if (this.IsDeadOrRetreat())
			{
				return;
			}
			List<BuffState> list = this.Battle.AllocateTempBuffStateList(this.m_buffStates);
			foreach (BuffState buffState in list)
			{
				ConfigDataBuffInfo buffInfo = buffState.m_buffInfo;
				if (buffInfo.BuffType == BuffType.BuffType_BFSkill)
				{
					if (this.IsBuffEffective(buffState))
					{
						if (!this.IsBuffCooldown(buffState))
						{
							int rate = buffInfo.BuffTypeParam1;
							if (buffInfo.BuffTypeParam2 == 1)
							{
								if (isKill)
								{
									rate = buffInfo.BuffTypeParam3;
								}
							}
							else if (buffInfo.BuffTypeParam2 == 2)
							{
								if (isCritical)
								{
									rate = buffInfo.BuffTypeParam3;
								}
							}
							else if (buffInfo.BuffTypeParam2 == 3 && isDamage)
							{
								rate = buffInfo.BuffTypeParam3;
							}
							if (this.Battle.IsProbabilitySatisfied(rate))
							{
								if (buffInfo.BuffTypeParam4.Count > 0)
								{
									ConfigDataSkillInfo configDataSkillInfo = this.Battle.ConfigDataLoader.GetConfigDataSkillInfo(buffInfo.BuffTypeParam4[0]);
									if (configDataSkillInfo != null)
									{
										this.ExecuteBattlefieldSkill(configDataSkillInfo, this.m_position, this.m_position);
									}
								}
								this.StartBuffCooldown(buffState);
							}
						}
					}
				}
			}
			this.Battle.FreeTempBuffStateList(list);
		}

		// Token: 0x060032DF RID: 13023 RVA: 0x000D6154 File Offset: 0x000D4354
		private void ActionEndBuffNewTurn(bool isKill, bool isCritical)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActionEndBuffNewTurnBooleanBoolean_hotfix != null)
			{
				this.m_ActionEndBuffNewTurnBooleanBoolean_hotfix.call(new object[]
				{
					this,
					isKill,
					isCritical
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_hasExtraAction)
			{
				return;
			}
			if (!this.HasBuffType(BuffType.BuffType_NewTurn))
			{
				return;
			}
			if (this.HasFightTag(FightTag.FightTag_Stun))
			{
				return;
			}
			if (this.IsDeadOrRetreat())
			{
				return;
			}
			if (!this.HasExecutedCommandType(BattleCommandType.Combat) && !this.HasExecutedCommandType(BattleCommandType.Skill) && !this.HasExecutedCommandType(BattleCommandType.Move))
			{
				return;
			}
			List<BuffState> list = this.Battle.AllocateTempBuffStateList(this.m_buffStates);
			foreach (BuffState buffState in list)
			{
				ConfigDataBuffInfo buffInfo = buffState.m_buffInfo;
				if (buffInfo.BuffType == BuffType.BuffType_NewTurn)
				{
					if (this.IsBuffEffective(buffState))
					{
						if (!this.IsBuffCooldown(buffState))
						{
							if (buffInfo.BuffTypeParam4.Count <= 0 || this.m_hasExtraActionCount < buffInfo.BuffTypeParam4[0])
							{
								int rate = buffInfo.BuffTypeParam1;
								if (buffInfo.BuffTypeParam2 == 1)
								{
									if (isKill)
									{
										rate = buffInfo.BuffTypeParam3;
									}
								}
								else if (buffInfo.BuffTypeParam2 == 2 && isCritical)
								{
									rate = buffInfo.BuffTypeParam3;
								}
								if (this.Battle.IsProbabilitySatisfied(rate))
								{
									this.Battle.Listener.OnBattleActorPassiveSkill(this, null, buffState);
									this.m_hasExtraAction = true;
									this.m_hasExtraActionCount++;
									this.StartBuffCooldown(buffState);
									break;
								}
							}
						}
					}
				}
			}
			this.Battle.FreeTempBuffStateList(list);
		}

		// Token: 0x060032E0 RID: 13024 RVA: 0x000D6390 File Offset: 0x000D4590
		private static int CompareHealActor(BattleActor a0, BattleActor a1)
		{
			int num = a0.GetTotalHealthPoint() * 100000 / a0.GetTotalHealthPointMax();
			int num2 = a1.GetTotalHealthPoint() * 100000 / a1.GetTotalHealthPointMax();
			if (num != num2)
			{
				return num - num2;
			}
			return a0.Id - a1.Id;
		}

		// Token: 0x060032E1 RID: 13025 RVA: 0x000D63E0 File Offset: 0x000D45E0
		public void CombatBuffHeal(BattleActor target, bool beforeCombat, bool isAttacker, int distance, bool isCritical, int heroDamage, int soldierDamage)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CombatBuffHealBattleActorBooleanBooleanInt32BooleanInt32Int32_hotfix != null)
			{
				this.m_CombatBuffHealBattleActorBooleanBooleanInt32BooleanInt32Int32_hotfix.call(new object[]
				{
					this,
					target,
					beforeCombat,
					isAttacker,
					distance,
					isCritical,
					heroDamage,
					soldierDamage
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasBuffType(BuffType.BuffType_CombatHeal))
			{
				return;
			}
			if (this.IsDeadOrRetreat())
			{
				return;
			}
			List<BuffState> list = this.Battle.AllocateTempBuffStateList(this.m_buffStates);
			foreach (BuffState buffState in list)
			{
				ConfigDataBuffInfo buffInfo = buffState.m_buffInfo;
				if (buffInfo.BuffType == BuffType.BuffType_CombatHeal)
				{
					if (this.IsBuffCombatConditionSatisfied(target, beforeCombat, isAttacker, distance, isCritical, buffInfo.BuffTypeParam4))
					{
						if (this.IsBuffEffective(buffState))
						{
							if (!this.IsBuffCooldown(buffState))
							{
								if (this.Battle.IsProbabilitySatisfied(buffInfo.BuffTypeParam1))
								{
									int num = 0;
									int num2 = 0;
									if (!this.HasFightTag(FightTag.FightTag_BanHeal))
									{
										int magic = buffState.m_applyer.HeroBattleProperty.Magic;
										int buff_HealMul = buffState.m_applyer.HeroBattleProperty.Buff_HealMul;
										int buff_HealReceiveMul = this.m_heroBattleProperty.Buff_HealReceiveMul;
										if (buffInfo.BuffTypeParam2 == 1)
										{
											num = BattleFormula.ComputeBuffHealValue(this.m_heroBattleProperty.HealthPointMax, buffInfo.BuffTypeParam3, buff_HealMul, buff_HealReceiveMul);
											num2 = BattleFormula.ComputeBuffHealValue(this.m_soldierBattleProperty.HealthPointMax, buffInfo.BuffTypeParam3, buff_HealMul, buff_HealReceiveMul);
										}
										else if (buffInfo.BuffTypeParam2 == 2)
										{
											num2 = (num = BattleFormula.ComputeBuffHealValue(heroDamage + soldierDamage, buffInfo.BuffTypeParam3, buff_HealMul, buff_HealReceiveMul));
										}
										else if (buffInfo.BuffTypeParam2 == 3)
										{
											num2 = (num = BattleFormula.ComputeBuffHealValue(magic, buffInfo.BuffTypeParam3, buff_HealMul, buff_HealReceiveMul));
										}
										if (buffInfo.BuffTypeParam6.Count > 0)
										{
											if (buffInfo.BuffTypeParam6[0] == 1)
											{
												num2 = 0;
											}
											else if (buffInfo.BuffTypeParam6[0] == 2)
											{
												num = 0;
											}
										}
									}
									if (num != 0 || num2 != 0)
									{
										this.Battle.Listener.OnBattleActorPassiveSkill(this, null, buffState);
										this.OnBuffHit(buffState, num, num2, DamageNumberType.Heal);
										this.StartBuffCooldown(buffState);
									}
								}
							}
						}
					}
				}
			}
			this.Battle.FreeTempBuffStateList(list);
		}

		// Token: 0x060032E2 RID: 13026 RVA: 0x000D66FC File Offset: 0x000D48FC
		public void CombatBuffHealOther(BattleActor target, bool beforeCombat, bool isAttacker, int soldierDamage, bool isCritical, int distance, int heroDamage)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CombatBuffHealOtherBattleActorBooleanBooleanInt32BooleanInt32Int32_hotfix != null)
			{
				this.m_CombatBuffHealOtherBattleActorBooleanBooleanInt32BooleanInt32Int32_hotfix.call(new object[]
				{
					this,
					target,
					beforeCombat,
					isAttacker,
					soldierDamage,
					isCritical,
					distance,
					heroDamage
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasBuffType(BuffType.BuffType_CombatHealOther))
			{
				return;
			}
			if (this.IsDeadOrRetreat())
			{
				return;
			}
			List<BuffState> list = this.Battle.AllocateTempBuffStateList(this.m_buffStates);
			List<BattleActor> list2 = this.Battle.AllocateTempActorList();
			foreach (BuffState buffState in list)
			{
				ConfigDataBuffInfo buffInfo = buffState.m_buffInfo;
				if (buffInfo.BuffType == BuffType.BuffType_CombatHealOther)
				{
					if (this.IsBuffCombatConditionSatisfied(target, beforeCombat, isAttacker, distance, isCritical, buffInfo.BuffTypeParam4))
					{
						if (this.IsBuffEffective(buffState))
						{
							if (!this.IsBuffCooldown(buffState))
							{
								if (this.Battle.IsProbabilitySatisfied(buffInfo.BuffTypeParam1))
								{
									int num = -1;
									int num2 = 9999;
									int num3 = 0;
									if (buffInfo.BuffTypeParam6.Count > 0)
									{
										num = buffInfo.BuffTypeParam6[0];
									}
									if (buffInfo.BuffTypeParam6.Count > 1)
									{
										num2 = buffInfo.BuffTypeParam6[1];
									}
									if (buffInfo.BuffTypeParam6.Count > 2)
									{
										num3 = buffInfo.BuffTypeParam6[2];
									}
									list2.Clear();
									foreach (BattleActor battleActor in this.m_team.GetActors())
									{
										if (!battleActor.IsDeadOrRetreat())
										{
											if (!battleActor.HasFightTag(FightTag.FightTag_BanHeal))
											{
												if (num < 0 || GridPosition.Distance(this.m_position, battleActor.m_position) <= num)
												{
													if (num3 != 1 || battleActor != this)
													{
														list2.Add(battleActor);
													}
												}
											}
										}
									}
									if (list2.Count > 0)
									{
										if (list2.Count > num2)
										{
											List<BattleActor> list3 = list2;
											if (BattleActor.<>f__mg$cache3 == null)
											{
												BattleActor.<>f__mg$cache3 = new Comparison<BattleActor>(BattleActor.CompareHealActor);
											}
											list3.Sort(BattleActor.<>f__mg$cache3);
											list2.RemoveRange(num2, list2.Count - num2);
										}
										this.Battle.Listener.OnBattleActorPassiveSkill(this, null, buffState);
										foreach (BattleActor battleActor2 in list2)
										{
											int heroHpModify = 0;
											int soldierHpModify = 0;
											int buff_HealMul = buffState.m_applyer.HeroBattleProperty.Buff_HealMul;
											int buff_HealReceiveMul = battleActor2.m_heroBattleProperty.Buff_HealReceiveMul;
											if (buffInfo.BuffTypeParam2 == 1)
											{
												heroHpModify = BattleFormula.ComputeBuffHealValue(this.m_heroBattleProperty.HealthPointMax, buffInfo.BuffTypeParam3, buff_HealMul, buff_HealReceiveMul);
												soldierHpModify = BattleFormula.ComputeBuffHealValue(this.m_soldierBattleProperty.HealthPointMax, buffInfo.BuffTypeParam3, buff_HealMul, buff_HealReceiveMul);
											}
											else if (buffInfo.BuffTypeParam2 == 2)
											{
												soldierHpModify = (heroHpModify = BattleFormula.ComputeBuffHealValue(heroDamage + soldierDamage, buffInfo.BuffTypeParam3, buff_HealMul, buff_HealReceiveMul));
											}
											else if (buffInfo.BuffTypeParam2 == 3)
											{
												heroHpModify = (int)((long)Fix64.Round(BattleFormula.ComputeHealValue(this.m_heroBattleProperty, battleActor2.m_heroBattleProperty, buffInfo.BuffTypeParam3, false, false)));
												soldierHpModify = (int)((long)Fix64.Round(BattleFormula.ComputeHealValue(this.m_heroBattleProperty, battleActor2.m_soldierBattleProperty, buffInfo.BuffTypeParam3, false, false)));
											}
											else if (buffInfo.BuffTypeParam2 == 4)
											{
												heroHpModify = (int)((long)Fix64.Round(BattleFormula.ComputeHealValue(this.m_heroBattleProperty, battleActor2.m_heroBattleProperty, buffInfo.BuffTypeParam3, false, true)));
												soldierHpModify = (int)((long)Fix64.Round(BattleFormula.ComputeHealValue(this.m_heroBattleProperty, battleActor2.m_soldierBattleProperty, buffInfo.BuffTypeParam3, false, true)));
											}
											battleActor2.OnBuffHit(buffState, heroHpModify, soldierHpModify, DamageNumberType.Heal);
											this.StartBuffCooldown(buffState);
										}
									}
								}
							}
						}
					}
				}
			}
			this.Battle.FreeTempActorList(list2);
			this.Battle.FreeTempBuffStateList(list);
		}

		// Token: 0x060032E3 RID: 13027 RVA: 0x000D6C38 File Offset: 0x000D4E38
		public void CombatBuffDamage(BattleActor target, bool beforeCombat, bool isAttacker, int distance, bool isCritical)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CombatBuffDamageBattleActorBooleanBooleanInt32Boolean_hotfix != null)
			{
				this.m_CombatBuffDamageBattleActorBooleanBooleanInt32Boolean_hotfix.call(new object[]
				{
					this,
					target,
					beforeCombat,
					isAttacker,
					distance,
					isCritical
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasBuffType(BuffType.BuffType_CombatDamage))
			{
				return;
			}
			if (this.IsDeadOrRetreat())
			{
				return;
			}
			List<BuffState> list = this.Battle.AllocateTempBuffStateList(this.m_buffStates);
			foreach (BuffState buffState in list)
			{
				ConfigDataBuffInfo buffInfo = buffState.m_buffInfo;
				if (buffInfo.BuffType == BuffType.BuffType_CombatDamage)
				{
					if (this.IsBuffCombatConditionSatisfied(target, beforeCombat, isAttacker, distance, isCritical, buffInfo.BuffTypeParam4))
					{
						if (buffInfo.BuffTypeParam4.Count > 5)
						{
							int num = target.GetTotalHealthPoint() * 10000 / target.GetTotalHealthPointMax();
							if (num < buffInfo.BuffTypeParam4[5])
							{
								continue;
							}
						}
						if (this.IsBuffEffective(buffState))
						{
							if (!this.IsBuffCooldown(buffState))
							{
								if (this.Battle.IsProbabilitySatisfied(buffInfo.BuffTypeParam1))
								{
									BattleActor battleActor;
									if (buffInfo.BuffTypeParam6.Count > 0 && buffInfo.BuffTypeParam6[0] == 1)
									{
										battleActor = this;
									}
									else
									{
										battleActor = target;
									}
									if (!battleActor.IsDeadOrRetreat())
									{
										this.Battle.Listener.OnBattleActorPassiveSkill(this, null, buffState);
										if (battleActor.HasFightTag(FightTag.FightTag_BanDamage) || battleActor.HasFightTag(FightTag.FightTag_BanPercentDamage))
										{
											this.Battle.Listener.OnBattleActorImmune(battleActor);
										}
										else
										{
											int num2 = 0;
											int num3 = 0;
											if (buffInfo.BuffTypeParam2 == 1)
											{
												num3 = (num2 = BattleFormula.ComputeBuffDamageValue(this.m_heroBattleProperty.Magic, buffInfo.BuffTypeParam3));
											}
											else if (buffInfo.BuffTypeParam2 == 2)
											{
												num2 = BattleFormula.ComputeBuffDamageValue(battleActor.HeroBattleProperty.HealthPointMax, buffInfo.BuffTypeParam3);
												num3 = BattleFormula.ComputeBuffDamageValue(battleActor.SoldierBattleProperty.HealthPointMax, buffInfo.BuffTypeParam3);
											}
											else if (buffInfo.BuffTypeParam2 == 3)
											{
												num3 = (num2 = BattleFormula.ComputeBuffDamageValue(this.m_heroBattleProperty.Attack, buffInfo.BuffTypeParam3));
											}
											else if (buffInfo.BuffTypeParam2 == 4)
											{
												num3 = (num2 = BattleFormula.ComputeBuffDamageValue(this.m_heroBattleProperty.Defense, buffInfo.BuffTypeParam3));
											}
											else if (buffInfo.BuffTypeParam2 == 5)
											{
												num3 = (num2 = BattleFormula.ComputeBuffDamageValue(this.m_heroBattleProperty.MagicDefense, buffInfo.BuffTypeParam3));
											}
											else if (buffInfo.BuffTypeParam2 == 6)
											{
												num2 = BattleFormula.ComputeBuffDamageValue(battleActor.HeroHealthPoint, buffInfo.BuffTypeParam3);
												num3 = BattleFormula.ComputeBuffDamageValue(battleActor.SoldierTotalHealthPoint, buffInfo.BuffTypeParam3);
											}
											battleActor.OnBuffHit(buffState, -num2, -num3, DamageNumberType.Normal);
											battleActor.CheckDie(this);
										}
										this.StartBuffCooldown(buffState);
									}
								}
							}
						}
					}
				}
			}
			this.Battle.FreeTempBuffStateList(list);
		}

		// Token: 0x060032E4 RID: 13028 RVA: 0x000D6FF4 File Offset: 0x000D51F4
		public void CombatApplyBuff(BattleActor target, bool beforeCombat, bool isAttacker, int distance, bool isCritical)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CombatApplyBuffBattleActorBooleanBooleanInt32Boolean_hotfix != null)
			{
				this.m_CombatApplyBuffBattleActorBooleanBooleanInt32Boolean_hotfix.call(new object[]
				{
					this,
					target,
					beforeCombat,
					isAttacker,
					distance,
					isCritical
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasBuffType(BuffType.BuffType_CombatAttachBuff))
			{
				return;
			}
			if (this.HasFightTag(FightTag.FightTag_Stun))
			{
				return;
			}
			if (this.IsDeadOrRetreat())
			{
				return;
			}
			List<BuffState> list = this.Battle.AllocateTempBuffStateList(this.m_buffStates);
			List<BuffState> list2 = this.Battle.AllocateTempBuffStateList(null);
			List<ConfigDataBuffInfo> list3 = this.Battle.AllocateTempBuffList();
			foreach (BuffState buffState in list)
			{
				ConfigDataBuffInfo buffInfo = buffState.m_buffInfo;
				if (buffInfo.BuffType == BuffType.BuffType_CombatAttachBuff)
				{
					if (this.IsBuffCombatConditionSatisfied(target, beforeCombat, isAttacker, distance, isCritical, buffInfo.BuffTypeParam4))
					{
						if (this.IsBuffEffective(buffState))
						{
							if (!this.IsBuffCooldown(buffState))
							{
								if (this.Battle.IsProbabilitySatisfied(buffInfo.BuffTypeParam1))
								{
									if (buffInfo.BuffTypeParam4.Count > 5)
									{
										int num = 0;
										int num2 = buffInfo.BuffTypeParam4[5];
										if (num2 > 0)
										{
											list2.Clear();
											list2.AddRange(target.m_buffStates);
											this.Battle.RandomizeBuffStateList(list2);
											foreach (BuffState buffState2 in list2)
											{
												if (!buffState2.CanNotDispel())
												{
													if (buffState2.m_buffInfo.IsEnhance && target.RemoveBuff(buffState2))
													{
														num++;
														if (num >= num2)
														{
															break;
														}
													}
												}
											}
										}
										else if (num2 < 0)
										{
											list2.Clear();
											list2.AddRange(this.m_buffStates);
											this.Battle.RandomizeBuffStateList(list2);
											foreach (BuffState buffState3 in list2)
											{
												if (!buffState3.CanNotDispel())
												{
													if (buffState3.m_buffInfo.IsDebuff && this.RemoveBuff(buffState3))
													{
														num++;
														if (num >= -num2)
														{
															break;
														}
													}
												}
											}
										}
									}
									this.Battle.GetRandomBuffList(buffInfo.BuffTypeParam6, buffInfo.BuffTypeParam2, list3);
									foreach (ConfigDataBuffInfo buffInfo2 in list3)
									{
										if (buffInfo.BuffTypeParam3 == 1)
										{
											this.AttachBuff(buffInfo2, this, BuffSourceType.BuffApply, null, buffState);
										}
										else if (buffInfo.BuffTypeParam3 == 2)
										{
											target.AttachBuff(buffInfo2, this, BuffSourceType.BuffApply, null, buffState);
										}
									}
									this.StartBuffCooldown(buffState);
								}
							}
						}
					}
				}
			}
			this.Battle.FreeTempBuffList(list3);
			this.Battle.FreeTempBuffStateList(list2);
			this.Battle.FreeTempBuffStateList(list);
		}

		// Token: 0x060032E5 RID: 13029 RVA: 0x000D7420 File Offset: 0x000D5620
		public void AttackApplyBuff(List<BattleActor> targets)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AttackApplyBuffList`1_hotfix != null)
			{
				this.m_AttackApplyBuffList`1_hotfix.call(new object[]
				{
					this,
					targets
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasBuffType(BuffType.BuffType_DamageAttachBuff))
			{
				return;
			}
			if (this.IsDeadOrRetreat())
			{
				return;
			}
			List<BuffState> list = this.Battle.AllocateTempBuffStateList(this.m_buffStates);
			List<ConfigDataBuffInfo> list2 = this.Battle.AllocateTempBuffList();
			foreach (BuffState buffState in list)
			{
				ConfigDataBuffInfo buffInfo = buffState.m_buffInfo;
				if (buffInfo.BuffType == BuffType.BuffType_DamageAttachBuff)
				{
					if (this.IsBuffEffective(buffState))
					{
						if (!this.IsBuffCooldown(buffState))
						{
							foreach (BattleActor battleActor in targets)
							{
								int rate = buffInfo.BuffTypeParam1;
								BattleActor battleActor2 = battleActor;
								if (buffInfo.BuffTypeParam3 == 1)
								{
									if (battleActor.m_isBeCriticalAttack && buffInfo.BuffTypeParam4.Count > 0)
									{
										rate = buffInfo.BuffTypeParam4[0];
									}
								}
								else if (buffInfo.BuffTypeParam3 == 2 && battleActor.m_isBeKillAttack && buffInfo.BuffTypeParam4.Count > 0)
								{
									rate = buffInfo.BuffTypeParam4[0];
									battleActor2 = this;
								}
								if (!battleActor2.IsDeadOrRetreat())
								{
									if (this.Battle.IsProbabilitySatisfied(rate))
									{
										this.Battle.GetRandomBuffList(buffInfo.BuffTypeParam6, buffInfo.BuffTypeParam2, list2);
										foreach (ConfigDataBuffInfo buffInfo2 in list2)
										{
											battleActor2.AttachBuff(buffInfo2, this, BuffSourceType.BuffApply, null, buffState);
										}
										this.StartBuffCooldown(buffState);
									}
								}
							}
						}
					}
				}
			}
			this.Battle.FreeTempBuffList(list2);
			this.Battle.FreeTempBuffStateList(list);
		}

		// Token: 0x060032E6 RID: 13030 RVA: 0x000D76E8 File Offset: 0x000D58E8
		public void AttackBuffDamage(List<BattleActor> targets, bool beforeCombat, bool isAttacker, int combatDistance = -1)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AttackBuffDamageList`1BooleanBooleanInt32_hotfix != null)
			{
				this.m_AttackBuffDamageList`1BooleanBooleanInt32_hotfix.call(new object[]
				{
					this,
					targets,
					beforeCombat,
					isAttacker,
					combatDistance
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasBuffType(BuffType.BuffType_DamageAfterDamage))
			{
				return;
			}
			if (this.IsDeadOrRetreat())
			{
				return;
			}
			List<BuffState> list = this.Battle.AllocateTempBuffStateList(this.m_buffStates);
			foreach (BuffState buffState in list)
			{
				ConfigDataBuffInfo buffInfo = buffState.m_buffInfo;
				if (buffInfo.BuffType == BuffType.BuffType_DamageAfterDamage)
				{
					if (this.IsBuffEffective(buffState))
					{
						if (!this.IsBuffCooldown(buffState))
						{
							foreach (BattleActor battleActor in targets)
							{
								int num = combatDistance;
								if (num < 0)
								{
									num = GridPosition.Distance(this.m_position, battleActor.m_position);
								}
								if (this.IsBuffCombatConditionSatisfied(battleActor, beforeCombat, isAttacker, num, battleActor.m_isBeCriticalAttack, buffInfo.BuffTypeParam4))
								{
									if (this.Battle.IsProbabilitySatisfied(buffInfo.BuffTypeParam1))
									{
										BattleActor battleActor2;
										if (buffInfo.BuffTypeParam6.Count > 0 && buffInfo.BuffTypeParam6[0] == 1)
										{
											battleActor2 = this;
										}
										else
										{
											battleActor2 = battleActor;
										}
										if (!battleActor2.IsDeadOrRetreat())
										{
											this.Battle.Listener.OnBattleActorPassiveSkill(this, null, buffState);
											if (battleActor2.HasFightTag(FightTag.FightTag_BanDamage) || battleActor2.HasFightTag(FightTag.FightTag_BanPercentDamage))
											{
												this.Battle.Listener.OnBattleActorImmune(battleActor2);
											}
											else
											{
												int num2 = 0;
												int num3 = 0;
												if (buffInfo.BuffTypeParam2 == 1)
												{
													num3 = (num2 = BattleFormula.ComputeBuffDamageValue(this.m_heroBattleProperty.Magic, buffInfo.BuffTypeParam3));
												}
												else if (buffInfo.BuffTypeParam2 == 2)
												{
													num2 = BattleFormula.ComputeBuffDamageValue(battleActor2.HeroBattleProperty.HealthPointMax, buffInfo.BuffTypeParam3);
													num3 = BattleFormula.ComputeBuffDamageValue(battleActor2.SoldierBattleProperty.HealthPointMax, buffInfo.BuffTypeParam3);
												}
												else if (buffInfo.BuffTypeParam2 == 3)
												{
													num3 = (num2 = BattleFormula.ComputeBuffDamageValue(this.m_heroBattleProperty.Attack, buffInfo.BuffTypeParam3));
												}
												else if (buffInfo.BuffTypeParam2 == 4)
												{
													num3 = (num2 = BattleFormula.ComputeBuffDamageValue(this.m_heroBattleProperty.Defense, buffInfo.BuffTypeParam3));
												}
												else if (buffInfo.BuffTypeParam2 == 5)
												{
													num3 = (num2 = BattleFormula.ComputeBuffDamageValue(this.m_heroBattleProperty.MagicDefense, buffInfo.BuffTypeParam3));
												}
												else if (buffInfo.BuffTypeParam2 == 6)
												{
													num2 = BattleFormula.ComputeBuffDamageValue(battleActor2.HeroHealthPoint, buffInfo.BuffTypeParam3);
													num3 = BattleFormula.ComputeBuffDamageValue(battleActor2.SoldierTotalHealthPoint, buffInfo.BuffTypeParam3);
												}
												battleActor2.OnBuffHit(buffState, -num2, -num3, DamageNumberType.Normal);
											}
											this.StartBuffCooldown(buffState);
										}
									}
								}
							}
							foreach (BattleActor battleActor3 in targets)
							{
								battleActor3.CheckDie(this);
							}
						}
					}
				}
			}
			this.Battle.FreeTempBuffStateList(list);
		}

		// Token: 0x060032E7 RID: 13031 RVA: 0x000D7B18 File Offset: 0x000D5D18
		public void AttackRemoveBuff(List<BattleActor> targets, bool beforeCombat, bool isAttacker, int combatDistance = -1)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AttackRemoveBuffList`1BooleanBooleanInt32_hotfix != null)
			{
				this.m_AttackRemoveBuffList`1BooleanBooleanInt32_hotfix.call(new object[]
				{
					this,
					targets,
					beforeCombat,
					isAttacker,
					combatDistance
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasBuffType(BuffType.BuffType_DamageRemoveBuff))
			{
				return;
			}
			if (this.IsDeadOrRetreat())
			{
				return;
			}
			List<BuffState> list = this.Battle.AllocateTempBuffStateList(this.m_buffStates);
			List<BuffState> list2 = this.Battle.AllocateTempBuffStateList(null);
			foreach (BuffState buffState in list)
			{
				ConfigDataBuffInfo buffInfo = buffState.m_buffInfo;
				if (buffInfo.BuffType == BuffType.BuffType_DamageRemoveBuff)
				{
					if (this.IsBuffEffective(buffState))
					{
						if (!this.IsBuffCooldown(buffState))
						{
							foreach (BattleActor battleActor in targets)
							{
								if (!battleActor.IsDeadOrRetreat())
								{
									if (battleActor.ComputeEnhanceOrDebuffCount(1) > 0)
									{
										int num = combatDistance;
										if (num < 0)
										{
											num = GridPosition.Distance(this.m_position, battleActor.m_position);
										}
										if (this.IsBuffCombatConditionSatisfied(battleActor, beforeCombat, isAttacker, num, battleActor.m_isBeCriticalAttack, buffInfo.BuffTypeParam4))
										{
											if (this.Battle.IsProbabilitySatisfied(buffInfo.BuffTypeParam1))
											{
												if (buffInfo.BuffTypeParam2 != 2)
												{
													this.Battle.Listener.OnBattleActorPassiveSkill(this, battleActor, buffState);
												}
												list2.Clear();
												list2.AddRange(battleActor.m_buffStates);
												this.Battle.RandomizeBuffStateList(list2);
												int num2 = 0;
												foreach (BuffState buffState2 in list2)
												{
													if (!buffState2.CanNotDispel())
													{
														if (buffState2.m_buffInfo.IsEnhance && battleActor.RemoveBuff(buffState2))
														{
															if (buffInfo.BuffTypeParam2 == 2)
															{
																this.AttachBuff(buffState2.m_buffInfo, this, BuffSourceType.BuffApply, null, buffState);
															}
															num2++;
															if (num2 >= buffInfo.BuffTypeParam3)
															{
																break;
															}
														}
													}
												}
												this.StartBuffCooldown(buffState);
											}
										}
									}
								}
							}
						}
					}
				}
			}
			this.Battle.FreeTempBuffStateList(list2);
			this.Battle.FreeTempBuffStateList(list);
		}

		// Token: 0x060032E8 RID: 13032 RVA: 0x000D7E68 File Offset: 0x000D6068
		public void AttackRemoveSkillCooldown(ConfigDataSkillInfo skillInfo, bool isCritical, bool isKill)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AttackRemoveSkillCooldownConfigDataSkillInfoBooleanBoolean_hotfix != null)
			{
				this.m_AttackRemoveSkillCooldownConfigDataSkillInfoBooleanBoolean_hotfix.call(new object[]
				{
					this,
					skillInfo,
					isCritical,
					isKill
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasBuffType(BuffType.BuffType_DamageRemoveCD))
			{
				return;
			}
			if (this.IsDeadOrRetreat())
			{
				return;
			}
			List<BuffState> list = this.Battle.AllocateTempBuffStateList(this.m_buffStates);
			foreach (BuffState buffState in list)
			{
				ConfigDataBuffInfo buffInfo = buffState.m_buffInfo;
				if (buffInfo.BuffType == BuffType.BuffType_DamageRemoveCD)
				{
					if (this.IsBuffEffective(buffState))
					{
						if (!this.IsBuffCooldown(buffState))
						{
							if (buffInfo.BuffTypeParam3 == 1)
							{
								if (!isCritical)
								{
									continue;
								}
							}
							else if (buffInfo.BuffTypeParam3 == 2 && !isKill)
							{
								continue;
							}
							if (buffInfo.BuffTypeParam6.Count <= 0 || buffInfo.BuffTypeParam6[0] != 1 || skillInfo != null)
							{
								if (this.Battle.IsProbabilitySatisfied(buffInfo.BuffTypeParam1))
								{
									bool flag = false;
									foreach (BattleSkillState battleSkillState in this.m_skillStates)
									{
										if (battleSkillState.m_cooldown > 0)
										{
											if (battleSkillState.m_skillInfo.SkillType != SkillType.SkillType_BF_HealRemoveCD)
											{
												if ((buffInfo.BuffTypeParam4.Count > 0 && buffInfo.BuffTypeParam4[0] != 0) || skillInfo == null || battleSkillState.m_skillInfo == skillInfo)
												{
													if (battleSkillState.m_cooldown > 0)
													{
														battleSkillState.m_cooldown -= buffInfo.BuffTypeParam2;
														if (battleSkillState.m_cooldown < 0)
														{
															battleSkillState.m_cooldown = 0;
														}
														flag = true;
													}
												}
											}
										}
									}
									if (flag)
									{
										this.Battle.Listener.OnBattleActorPassiveSkill(this, null, buffState);
										this.StartBuffCooldown(buffState);
									}
								}
							}
						}
					}
				}
			}
			this.Battle.FreeTempBuffStateList(list);
		}

		// Token: 0x060032E9 RID: 13033 RVA: 0x000D8150 File Offset: 0x000D6350
		public void BattleFieldSkillApplyBuff(List<BattleActor> targets)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleFieldSkillApplyBuffList`1_hotfix != null)
			{
				this.m_BattleFieldSkillApplyBuffList`1_hotfix.call(new object[]
				{
					this,
					targets
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasBuffType(BuffType.BuffType_BFSkillAttachBuff))
			{
				return;
			}
			if (this.IsDeadOrRetreat())
			{
				return;
			}
			List<BuffState> list = this.Battle.AllocateTempBuffStateList(this.m_buffStates);
			List<ConfigDataBuffInfo> list2 = this.Battle.AllocateTempBuffList();
			foreach (BuffState buffState in list)
			{
				ConfigDataBuffInfo buffInfo = buffState.m_buffInfo;
				if (buffInfo.BuffType == BuffType.BuffType_BFSkillAttachBuff)
				{
					if (this.IsBuffEffective(buffState))
					{
						if (!this.IsBuffCooldown(buffState))
						{
							foreach (BattleActor battleActor in targets)
							{
								if (!battleActor.IsDeadOrRetreat())
								{
									if (buffInfo.BuffTypeParam3 == 1)
									{
										if (battleActor.Team != this.m_team)
										{
											continue;
										}
									}
									else if (buffInfo.BuffTypeParam3 == 2 && battleActor.Team == this.m_team)
									{
										continue;
									}
									if (this.Battle.IsProbabilitySatisfied(buffInfo.BuffTypeParam1))
									{
										this.Battle.GetRandomBuffList(buffInfo.BuffTypeParam4, buffInfo.BuffTypeParam2, list2);
										foreach (ConfigDataBuffInfo buffInfo2 in list2)
										{
											battleActor.AttachBuff(buffInfo2, this, BuffSourceType.BuffApply, null, buffState);
										}
										this.StartBuffCooldown(buffState);
									}
								}
							}
						}
					}
				}
			}
			this.Battle.FreeTempBuffList(list2);
			this.Battle.FreeTempBuffStateList(list);
		}

		// Token: 0x060032EA RID: 13034 RVA: 0x000D83E0 File Offset: 0x000D65E0
		public void AttackBuffPunch(BattleActor target)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AttackBuffPunchBattleActor_hotfix != null)
			{
				this.m_AttackBuffPunchBattleActor_hotfix.call(new object[]
				{
					this,
					target
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasBuffType(BuffType.BuffType_Punch))
			{
				return;
			}
			if (this.IsDeadOrRetreat())
			{
				return;
			}
			if (target.IsDeadOrRetreat())
			{
				return;
			}
			if (target == this)
			{
				return;
			}
			List<BuffState> list = this.Battle.AllocateTempBuffStateList(this.m_buffStates);
			int num = 0;
			BuffState buffState = null;
			foreach (BuffState buffState2 in list)
			{
				ConfigDataBuffInfo buffInfo = buffState2.m_buffInfo;
				if (buffInfo.BuffType == BuffType.BuffType_Punch)
				{
					if (this.IsBuffEffective(buffState2))
					{
						if (!this.IsBuffCooldown(buffState2))
						{
							if (this.Battle.IsProbabilitySatisfied(buffInfo.BuffTypeParam1))
							{
								if (buffInfo.BuffTypeParam2 >= num)
								{
									num = buffInfo.BuffTypeParam2;
									buffState = buffState2;
								}
							}
						}
					}
				}
			}
			if (buffState != null)
			{
				this.Battle.Listener.OnBattleActorPassiveSkill(this, null, buffState);
				if (target.HasFightTag(FightTag.FightTag_BanPunch))
				{
					this.Battle.Listener.OnBattleActorImmune(target);
				}
				else
				{
					int num2 = target.m_position.x - this.m_position.x;
					int num3 = target.m_position.y - this.m_position.y;
					int num4 = 0;
					int num5 = 0;
					if (num3 == 0)
					{
						if (num2 > 0)
						{
							num4 = 1;
						}
						else
						{
							num4 = -1;
						}
					}
					else if (num3 > 0)
					{
						num5 = 1;
					}
					else
					{
						num5 = -1;
					}
					GridPosition position = target.m_position;
					GridPosition position2 = position;
					bool flag = false;
					for (int i = 0; i < buffState.m_buffInfo.BuffTypeParam2; i++)
					{
						position.x += num4;
						position.y += num5;
						if (this.Battle.Map.GetMovePointCost(position, target.GetMoveType()) <= 0 || this.Battle.Map.GetActor(position) != null)
						{
							flag = true;
							break;
						}
						position2 = position;
					}
					target.SetPosition(position2);
					this.Battle.Listener.OnBattleActorPunchMove(target, buffState.m_buffInfo.Effect_ActingTarget, false);
					if (flag)
					{
						ConfigDataBuffInfo configDataBuffInfo = this.Battle.ConfigDataLoader.GetConfigDataBuffInfo(buffState.m_buffInfo.BuffTypeParam3);
						if (configDataBuffInfo != null)
						{
							target.AttachBuff(configDataBuffInfo, this, BuffSourceType.BuffApply, null, buffState);
						}
					}
					target.MoveTo(target.m_position);
					this.Battle.CheckOnActorMove(target);
				}
				this.StartBuffCooldown(buffState);
			}
			this.Battle.FreeTempBuffStateList(list);
		}

		// Token: 0x060032EB RID: 13035 RVA: 0x000D870C File Offset: 0x000D690C
		public void AttackBuffDrag(BattleActor target)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AttackBuffDragBattleActor_hotfix != null)
			{
				this.m_AttackBuffDragBattleActor_hotfix.call(new object[]
				{
					this,
					target
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasBuffType(BuffType.BuffType_Drag))
			{
				return;
			}
			if (this.IsDeadOrRetreat())
			{
				return;
			}
			if (target.IsDeadOrRetreat())
			{
				return;
			}
			if (target == this)
			{
				return;
			}
			List<BuffState> list = this.Battle.AllocateTempBuffStateList(this.m_buffStates);
			int num = 0;
			BuffState buffState = null;
			foreach (BuffState buffState2 in list)
			{
				ConfigDataBuffInfo buffInfo = buffState2.m_buffInfo;
				if (buffInfo.BuffType == BuffType.BuffType_Drag)
				{
					if (this.IsBuffEffective(buffState2))
					{
						if (!this.IsBuffCooldown(buffState2))
						{
							if (this.Battle.IsProbabilitySatisfied(buffInfo.BuffTypeParam1))
							{
								if (buffInfo.BuffTypeParam2 >= num)
								{
									num = buffInfo.BuffTypeParam2;
									buffState = buffState2;
								}
							}
						}
					}
				}
			}
			if (buffState != null)
			{
				bool flag = buffState.m_buffInfo.BuffTypeParam4.Count > 0 && buffState.m_buffInfo.BuffTypeParam4[0] == 1 && !this.HasFightTag(FightTag.FightTag_BanPunch);
				if (!flag)
				{
					this.Battle.Listener.OnBattleActorPassiveSkill(this, null, buffState);
				}
				if (target.HasFightTag(FightTag.FightTag_BanPunch))
				{
					this.Battle.Listener.OnBattleActorImmune(target);
				}
				else
				{
					int num2 = target.m_position.x - this.m_position.x;
					int num3 = target.m_position.y - this.m_position.y;
					int num4 = 0;
					int num5 = 0;
					if (num3 == 0)
					{
						if (num2 > 0)
						{
							num4 = -1;
						}
						else
						{
							num4 = 1;
						}
					}
					else if (num3 > 0)
					{
						num5 = -1;
					}
					else
					{
						num5 = 1;
					}
					GridPosition position = target.m_position;
					GridPosition position2 = position;
					bool flag2 = false;
					for (int i = 0; i < num; i++)
					{
						position.x += num4;
						position.y += num5;
						if (this.Battle.Map.GetMovePointCost(position, target.GetMoveType()) <= 0 || this.Battle.Map.GetActor(position) != null)
						{
							if (position != this.m_position)
							{
								flag2 = true;
							}
							break;
						}
						position2 = position;
					}
					target.SetPosition(position2);
					this.Battle.Listener.OnBattleActorPunchMove(target, buffState.m_buffInfo.Effect_ActingTarget, flag);
					if (flag2)
					{
						ConfigDataBuffInfo configDataBuffInfo = this.Battle.ConfigDataLoader.GetConfigDataBuffInfo(buffState.m_buffInfo.BuffTypeParam3);
						if (configDataBuffInfo != null)
						{
							target.AttachBuff(configDataBuffInfo, this, BuffSourceType.BuffApply, null, buffState);
						}
					}
					if (flag && GridPosition.Distance(this.m_position, target.m_position) == 1 && this.Battle.Map.GetMovePointCost(target.Position, this.GetMoveType()) > 0 && this.Battle.Map.GetMovePointCost(this.m_position, target.GetMoveType()) > 0)
					{
						this.ClearMapActor();
						target.SetPosition(this.m_position);
						this.SetPosition(position2);
						int moveType = (buffState.m_buffInfo.BuffTypeParam6.Count <= 0) ? 0 : buffState.m_buffInfo.BuffTypeParam6[0];
						this.Battle.Listener.OnBattleActorExchangeMove(this, target, moveType, buffState.m_buffInfo.Effect_ActingTarget);
						this.MoveTo(this.m_position);
						this.Battle.CheckOnActorMove(this);
					}
					target.MoveTo(target.m_position);
					this.Battle.CheckOnActorMove(target);
				}
				this.StartBuffCooldown(buffState);
			}
			this.Battle.FreeTempBuffStateList(list);
		}

		// Token: 0x060032EC RID: 13036 RVA: 0x000D8B68 File Offset: 0x000D6D68
		public void AttackBuffExchangePosition(BattleActor target, bool isTargetGurad)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AttackBuffExchangePositionBattleActorBoolean_hotfix != null)
			{
				this.m_AttackBuffExchangePositionBattleActorBoolean_hotfix.call(new object[]
				{
					this,
					target,
					isTargetGurad
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasBuffType(BuffType.BuffType_Replace))
			{
				return;
			}
			if (this.IsDeadOrRetreat())
			{
				return;
			}
			if (target.IsDeadOrRetreat())
			{
				return;
			}
			List<BuffState> list = this.Battle.AllocateTempBuffStateList(this.m_buffStates);
			foreach (BuffState buffState in list)
			{
				ConfigDataBuffInfo buffInfo = buffState.m_buffInfo;
				if (buffInfo.BuffType == BuffType.BuffType_Replace)
				{
					if (this.IsBuffEffective(buffState))
					{
						if (!this.IsBuffCooldown(buffState))
						{
							if (!isTargetGurad || buffInfo.BuffTypeParam2 != 0)
							{
								if (this.Battle.Map.GetMovePointCost(target.Position, this.GetMoveType()) > 0 && this.Battle.Map.GetMovePointCost(this.m_position, target.GetMoveType()) > 0)
								{
									if (this.Battle.IsProbabilitySatisfied(buffInfo.BuffTypeParam1))
									{
										this.Battle.Listener.OnBattleActorPassiveSkill(this, null, buffState);
										if (target.HasFightTag(FightTag.FightTag_BanPunch))
										{
											this.Battle.Listener.OnBattleActorImmune(target);
										}
										else
										{
											GridPosition position = target.m_position;
											this.ClearMapActor();
											target.SetPosition(this.m_position);
											this.SetPosition(position);
											this.Battle.Listener.OnBattleActorExchangeMove(this, target, buffInfo.BuffTypeParam3, buffState.m_buffInfo.Effect_ActingTarget);
											this.MoveTo(this.m_position);
											this.Battle.CheckOnActorMove(this);
											target.MoveTo(target.m_position);
											this.Battle.CheckOnActorMove(target);
										}
										this.StartBuffCooldown(buffState);
									}
								}
							}
						}
					}
				}
			}
			this.Battle.FreeTempBuffStateList(list);
		}

		// Token: 0x060032ED RID: 13037 RVA: 0x000D8DE4 File Offset: 0x000D6FE4
		public void CombatArmyChange(BattleActor target)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CombatArmyChangeBattleActor_hotfix != null)
			{
				this.m_CombatArmyChangeBattleActor_hotfix.call(new object[]
				{
					this,
					target
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasBuffType(BuffType.BuffType_ArmyChange))
			{
				return;
			}
			if (this.IsDeadOrRetreat())
			{
				return;
			}
			List<BuffState> list = this.Battle.AllocateTempBuffStateList(this.m_buffStates);
			List<ConfigDataBuffInfo> list2 = this.Battle.AllocateTempBuffList();
			foreach (BuffState buffState in list)
			{
				ConfigDataBuffInfo buffInfo = buffState.m_buffInfo;
				if (buffInfo.BuffType == BuffType.BuffType_ArmyChange)
				{
					if (this.IsBuffEffective(buffState))
					{
						if (!this.IsBuffCooldown(buffState))
						{
							if (target.HeroArmyId != this.HeroArmyId)
							{
								if (this.Battle.IsProbabilitySatisfied(buffInfo.BuffTypeParam1))
								{
									this.m_heroArmyInfo = target.HeroArmyInfo;
									this.Battle.Listener.OnBattleActorChangeArmy(this);
									this.Battle.GetRandomBuffList(buffInfo.BuffTypeParam6, buffInfo.BuffTypeParam2, list2);
									foreach (ConfigDataBuffInfo buffInfo2 in list2)
									{
										this.AttachBuff(buffInfo2, this, BuffSourceType.BuffApply, null, buffState);
									}
									if (buffInfo.BuffTypeParam3 == 1)
									{
										this.m_hasExtraAction = true;
									}
									this.StartBuffCooldown(buffState);
								}
							}
						}
					}
				}
			}
			this.Battle.FreeTempBuffList(list2);
			this.Battle.FreeTempBuffStateList(list);
		}

		// Token: 0x060032EE RID: 13038 RVA: 0x000D9010 File Offset: 0x000D7210
		public BuffState BuffDoubleAttack()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BuffDoubleAttack_hotfix != null)
			{
				return (BuffState)this.m_BuffDoubleAttack_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasBuffType(BuffType.BuffType_DoubleAttack))
			{
				return null;
			}
			if (this.IsDeadOrRetreat())
			{
				return null;
			}
			List<BuffState> list = this.Battle.AllocateTempBuffStateList(this.m_buffStates);
			BuffState result = null;
			foreach (BuffState buffState in list)
			{
				ConfigDataBuffInfo buffInfo = buffState.m_buffInfo;
				if (buffInfo.BuffType == BuffType.BuffType_DoubleAttack)
				{
					if (this.IsBuffEffective(buffState))
					{
						if (!this.IsBuffCooldown(buffState))
						{
							if (this.Battle.IsProbabilitySatisfied(buffInfo.BuffTypeParam1))
							{
								result = buffState;
								this.StartBuffCooldown(buffState);
								break;
							}
						}
					}
				}
			}
			this.Battle.FreeTempBuffStateList(list);
			return result;
		}

		// Token: 0x060032EF RID: 13039 RVA: 0x000D9164 File Offset: 0x000D7364
		public void BuffUndead()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BuffUndead_hotfix != null)
			{
				this.m_BuffUndead_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasBuffType(BuffType.BuffType_NerverDie))
			{
				return;
			}
			List<BuffState> list = this.Battle.AllocateTempBuffStateList(this.m_buffStates);
			BuffState buffState = null;
			foreach (BuffState buffState2 in list)
			{
				ConfigDataBuffInfo buffInfo = buffState2.m_buffInfo;
				if (buffInfo.BuffType == BuffType.BuffType_NerverDie)
				{
					if (buffInfo.BuffTypeParam3 != 1 || buffState2.m_effectTimes <= 0)
					{
						if (this.IsBuffEffective(buffState2))
						{
							if (!this.IsBuffCooldown(buffState2))
							{
								if (this.Battle.IsProbabilitySatisfied(buffInfo.BuffTypeParam1))
								{
									buffState = buffState2;
									break;
								}
							}
						}
					}
				}
			}
			if (buffState != null)
			{
				this.Battle.Listener.OnBattleActorPassiveSkill(this, null, buffState);
				ConfigDataBuffInfo buffInfo2 = buffState.m_buffInfo;
				int buff_HealMul = buffState.m_applyer.HeroBattleProperty.Buff_HealMul;
				int buff_HealReceiveMul = this.m_heroBattleProperty.Buff_HealReceiveMul;
				int num = BattleFormula.ComputeBuffHealValue(this.m_heroBattleProperty.HealthPointMax, buffInfo2.BuffTypeParam2, buff_HealMul, buff_HealReceiveMul);
				int num2 = BattleFormula.ComputeBuffHealValue(this.m_soldierBattleProperty.HealthPointMax, buffInfo2.BuffTypeParam2, buff_HealMul, buff_HealReceiveMul);
				if (num <= 0)
				{
					num = 1;
				}
				if (num2 <= 0)
				{
					num2 = 1;
				}
				this.OnBuffHit(buffState, num, num2, DamageNumberType.Heal);
				buffState.m_effectTimes++;
				if (buffInfo2.BuffTypeParam3 == 1 && buffState.m_effectTimes > 0 && buffState.m_sourceSkillInfo != null)
				{
					BattleSkillState skillStateById = this.GetSkillStateById(buffState.m_sourceSkillInfo.ID);
					if (skillStateById != null)
					{
						skillStateById.m_isSkillUseable = false;
					}
				}
				this.StartBuffCooldown(buffState);
			}
			this.Battle.FreeTempBuffStateList(list);
		}

		// Token: 0x060032F0 RID: 13040 RVA: 0x000D93AC File Offset: 0x000D75AC
		private bool CanBuffGuard(BattleActor target, ConfigDataSkillInfo skillInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanBuffGuardBattleActorConfigDataSkillInfo_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CanBuffGuardBattleActorConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					target,
					skillInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasBuffType(BuffType.BuffType_Guard))
			{
				return false;
			}
			if (this.HasFightTag(FightTag.FightTag_BanGuard))
			{
				return false;
			}
			if (this.HasFightTag(FightTag.FightTag_Stun))
			{
				return false;
			}
			if (this.IsDeadOrRetreat())
			{
				return false;
			}
			if (target == this)
			{
				return false;
			}
			if (target.IsDeadOrRetreat())
			{
				return false;
			}
			List<BuffState> list = this.Battle.AllocateTempBuffStateList(this.m_buffStates);
			bool result = false;
			foreach (BuffState buffState in list)
			{
				ConfigDataBuffInfo buffInfo = buffState.m_buffInfo;
				if (buffInfo.BuffType == BuffType.BuffType_Guard)
				{
					if (this.IsBuffEffective(buffState))
					{
						if (!this.IsBuffCooldown(buffState))
						{
							if (GridPosition.Distance(this.m_position, target.m_position) <= buffInfo.BuffTypeParam2)
							{
								if (buffInfo.BuffTypeParam3 == 1)
								{
									if (skillInfo != null && !skillInfo.IsPhysicalDamageSkill())
									{
										continue;
									}
								}
								else if (buffInfo.BuffTypeParam3 == 2 && (skillInfo == null || !skillInfo.IsMagicDamageSkill()))
								{
									continue;
								}
								if (this.Battle.IsProbabilitySatisfied(buffInfo.BuffTypeParam1))
								{
									result = true;
									this.StartBuffCooldown(buffState);
									break;
								}
							}
						}
					}
				}
			}
			this.Battle.FreeTempBuffStateList(list);
			return result;
		}

		// Token: 0x060032F1 RID: 13041 RVA: 0x000D95C0 File Offset: 0x000D77C0
		public BattleActor GetGuardActor(ConfigDataSkillInfo skillInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetGuardActorConfigDataSkillInfo_hotfix != null)
			{
				return (BattleActor)this.m_GetGuardActorConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					skillInfo
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleActor battleActor in this.m_team.GetActors())
			{
				if (battleActor.CanBuffGuard(this, skillInfo))
				{
					return battleActor;
				}
			}
			return null;
		}

		// Token: 0x060032F2 RID: 13042 RVA: 0x000D96A0 File Offset: 0x000D78A0
		public void AfterCombatDetachBuff()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AfterCombatDetachBuff_hotfix != null)
			{
				this.m_AfterCombatDetachBuff_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<BuffState> list = this.Battle.AllocateTempBuffStateList(this.m_buffStates);
			foreach (BuffState buffState in list)
			{
				if (buffState.m_time == 0)
				{
					this.RemoveBuff(buffState);
				}
			}
			this.Battle.FreeTempBuffStateList(list);
		}

		// Token: 0x060032F3 RID: 13043 RVA: 0x000D9774 File Offset: 0x000D7974
		public BattleSkillState GetSkillState(int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSkillStateInt32_hotfix != null)
			{
				return (BattleSkillState)this.m_GetSkillStateInt32_hotfix.call(new object[]
				{
					this,
					index
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (index < 0 || index >= this.m_skillStates.Count)
			{
				return null;
			}
			return this.m_skillStates[index];
		}

		// Token: 0x060032F4 RID: 13044 RVA: 0x000D9818 File Offset: 0x000D7A18
		public BattleSkillState GetSkillStateById(int skillID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSkillStateByIdInt32_hotfix != null)
			{
				return (BattleSkillState)this.m_GetSkillStateByIdInt32_hotfix.call(new object[]
				{
					this,
					skillID
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleSkillState battleSkillState in this.m_skillStates)
			{
				if (battleSkillState.m_skillInfo.ID == skillID)
				{
					return battleSkillState;
				}
			}
			return null;
		}

		// Token: 0x060032F5 RID: 13045 RVA: 0x000D98F8 File Offset: 0x000D7AF8
		public List<BattleSkillState> GetSkillStates()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSkillStates_hotfix != null)
			{
				return (List<BattleSkillState>)this.m_GetSkillStates_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_skillStates;
		}

		// Token: 0x060032F6 RID: 13046 RVA: 0x000D996C File Offset: 0x000D7B6C
		private bool IsSkillUseable(int skillIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsSkillUseableInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsSkillUseableInt32_hotfix.call(new object[]
				{
					this,
					skillIndex
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleSkillState skillState = this.GetSkillState(skillIndex);
			if (skillState == null)
			{
				return false;
			}
			ConfigDataSkillInfo skillInfo = skillState.m_skillInfo;
			return skillInfo != null && !skillInfo.IsPassiveSkill() && !this.IsExtraActionMoving() && !this.HasFightTag(FightTag.FightTag_BanActiveSkill) && skillState.m_cooldown <= 0;
		}

		// Token: 0x060032F7 RID: 13047 RVA: 0x000D9A40 File Offset: 0x000D7C40
		public bool CanUseSkillOnTarget(ConfigDataSkillInfo skillInfo, BattleActor target)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanUseSkillOnTargetConfigDataSkillInfoBattleActor_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CanUseSkillOnTargetConfigDataSkillInfoBattleActor_hotfix.call(new object[]
				{
					this,
					skillInfo,
					target
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (skillInfo == null || this.IsDeadOrRetreat())
			{
				return false;
			}
			if (skillInfo.IsPassiveSkill())
			{
				return false;
			}
			bool flag = target != null && target.IsDeadOrRetreat();
			if (skillInfo.BF_TargetType == SkillTargetType.SkillTargetType_Enemy)
			{
				if (target == null || flag || target.TeamNumber == this.TeamNumber)
				{
					return false;
				}
			}
			else if (skillInfo.BF_TargetType == SkillTargetType.SkillTargetType_Ally)
			{
				if (target == null || flag || target.TeamNumber != this.TeamNumber)
				{
					return false;
				}
			}
			else if (skillInfo.BF_TargetType == SkillTargetType.SkillTargetType_NoNpcAlly)
			{
				if (target == null || flag || target.TeamNumber != this.TeamNumber || target.IsNpc())
				{
					return false;
				}
			}
			else if (skillInfo.BF_TargetType == SkillTargetType.SkillTargetType_NoSelfNpcAlly)
			{
				if (target == null || flag || target.TeamNumber != this.TeamNumber || target.IsNpc() || target == this)
				{
					return false;
				}
			}
			else if (skillInfo.BF_TargetType == SkillTargetType.SkillTargetType_Any)
			{
				if (target == null || flag)
				{
					return false;
				}
			}
			else if (skillInfo.BF_TargetType != SkillTargetType.SkillTargetType_Position)
			{
				if (skillInfo.BF_TargetType == SkillTargetType.SkillTargetType_EmptyPosition && target != null && !flag)
				{
					return false;
				}
			}
			return !skillInfo.IsSummonSkill() || target == null || flag;
		}

		// Token: 0x060032F8 RID: 13048 RVA: 0x000D9C40 File Offset: 0x000D7E40
		public bool IsBattlefiledSkillApplyTarget(ConfigDataSkillInfo skillInfo, BattleActor target)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsBattlefiledSkillApplyTargetConfigDataSkillInfoBattleActor_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsBattlefiledSkillApplyTargetConfigDataSkillInfoBattleActor_hotfix.call(new object[]
				{
					this,
					skillInfo,
					target
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (target == null)
			{
				return false;
			}
			if (skillInfo.BF_TargetFaction != SkillTargetType.SkillTargetType_Any)
			{
				if (skillInfo.BF_TargetFaction == SkillTargetType.SkillTargetType_Ally && target.TeamNumber != this.TeamNumber)
				{
					return false;
				}
				if (skillInfo.BF_TargetFaction == SkillTargetType.SkillTargetType_NoNpcAlly && (target.TeamNumber != this.TeamNumber || target.IsNpc()))
				{
					return false;
				}
				if (skillInfo.BF_TargetFaction == SkillTargetType.SkillTargetType_NoSelfNpcAlly)
				{
					if (target.TeamNumber != this.TeamNumber || target.IsNpc() || target == this)
					{
						return false;
					}
				}
				else if (skillInfo.BF_TargetFaction == SkillTargetType.SkillTargetType_Enemy && target.TeamNumber == this.TeamNumber)
				{
					return false;
				}
			}
			if (skillInfo.SkillType == SkillType.SkillType_BF_AddBuff)
			{
				if (skillInfo.SkillTypeParam1 == 1)
				{
					return target.HeroArmyId == skillInfo.SkillTypeParam2 || target.HeroArmyId == skillInfo.SkillTypeParam3;
				}
				if (skillInfo.SkillTypeParam1 == 2)
				{
					ConfigDataHeroTagInfo configDataHeroTagInfo = this.Battle.ConfigDataLoader.GetConfigDataHeroTagInfo(skillInfo.SkillTypeParam2);
					ConfigDataHeroTagInfo configDataHeroTagInfo2 = this.Battle.ConfigDataLoader.GetConfigDataHeroTagInfo(skillInfo.SkillTypeParam3);
					return (configDataHeroTagInfo != null && configDataHeroTagInfo.RelatedHeros_ID.Contains(target.HeroId)) || (configDataHeroTagInfo2 != null && configDataHeroTagInfo2.RelatedHeros_ID.Contains(target.HeroId));
				}
			}
			return true;
		}

		// Token: 0x060032F9 RID: 13049 RVA: 0x000D9E30 File Offset: 0x000D8030
		private void FindBattlefieldSkillApplyTargets(ConfigDataSkillInfo skillInfo, GridPosition targetPos, List<BattleActor> targetActors)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindBattlefieldSkillApplyTargetsConfigDataSkillInfoGridPositionList`1_hotfix != null)
			{
				this.m_FindBattlefieldSkillApplyTargetsConfigDataSkillInfoGridPositionList`1_hotfix.call(new object[]
				{
					this,
					skillInfo,
					targetPos,
					targetActors
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			targetActors.Clear();
			if (skillInfo == null)
			{
				return;
			}
			List<GridPosition> list = this.Battle.AllocateTempGridPositionList();
			this.Battle.FindAttackRegion(targetPos, skillInfo.BF_Range - 1, skillInfo.BF_RangeShape, list);
			BattleMap map = this.Battle.Map;
			bool flag = false;
			foreach (GridPosition p in list)
			{
				BattleActor actor = map.GetActor(p);
				if (actor != null)
				{
					if (!actor.IsDeadOrRetreat())
					{
						if (this.IsBattlefiledSkillApplyTarget(skillInfo, actor))
						{
							if (actor == this)
							{
								flag = true;
							}
							else
							{
								targetActors.Add(actor);
							}
						}
					}
				}
			}
			if (flag)
			{
				targetActors.Add(this);
			}
			this.Battle.FreeTempGridPositionList(list);
		}

		// Token: 0x060032FA RID: 13050 RVA: 0x000D9FB0 File Offset: 0x000D81B0
		private bool ExecuteBattlefieldSkill(ConfigDataSkillInfo skillInfo, GridPosition p, GridPosition p2)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ExecuteBattlefieldSkillConfigDataSkillInfoGridPositionGridPosition_hotfix != null)
			{
				return Convert.ToBoolean(this.m_ExecuteBattlefieldSkillConfigDataSkillInfoGridPositionGridPosition_hotfix.call(new object[]
				{
					this,
					skillInfo,
					p,
					p2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (skillInfo == null)
			{
				return false;
			}
			if (!skillInfo.IsBattlefieldSkill())
			{
				return false;
			}
			if (skillInfo.m_selfBuffInfos != null)
			{
				foreach (ConfigDataBuffInfo buffInfo in skillInfo.m_selfBuffInfos)
				{
					this.AttachBuff(buffInfo, this, BuffSourceType.SkillSelf, skillInfo, null);
				}
			}
			this.UpdateBattleProperties();
			this.Battle.Listener.OnBattleActorSkill(this, skillInfo, p);
			if (skillInfo.SkillType != SkillType.SkillType_BF_Summon)
			{
				List<BattleActor> list = this.Battle.AllocateTempActorList();
				this.FindBattlefieldSkillApplyTargets(skillInfo, p, list);
				foreach (BattleActor battleActor in list)
				{
					if (skillInfo.SkillType == SkillType.SkillType_BF_Teleport)
					{
						if (!this.SkillTeleport(skillInfo, battleActor, p2))
						{
							if (this.Battle.IsEnableDebugLog())
							{
								DebugUtility.LogError(string.Format("{0} ExecuteBattlefieldSkill() SkillTeleport() skill {1} on {2}, {3} FAILED.", new object[]
								{
									this.InstanceID,
									skillInfo.Name,
									battleActor.InstanceID,
									p2.ToString()
								}));
							}
							return false;
						}
					}
					else
					{
						if (battleActor != this)
						{
							battleActor.UpdateBattleProperties();
						}
						if (!this.SkillAttack(skillInfo, battleActor))
						{
							if (this.Battle.IsEnableDebugLog())
							{
								DebugUtility.LogError(string.Format("{0} ExecuteBattlefieldSkill() SkillAttack() skill {1} on {2} FAILED.", this.InstanceID, skillInfo.Name, battleActor.InstanceID));
							}
							return false;
						}
					}
				}
				this.SkillAttackEnd(skillInfo, list);
				if (skillInfo.IsDamageSkill())
				{
					this.AttackRemoveSkillCooldown(skillInfo, this.m_isActionCriticalAttack, this.m_isActionKillActor);
				}
				this.CheckDie(null);
				foreach (BattleActor battleActor2 in list)
				{
					if (battleActor2.IsDead())
					{
						this.Battle.CheckOnActorDie(battleActor2);
						this.IncreaseKillActorCount();
					}
				}
				if (this.IsDead())
				{
					this.Battle.CheckOnActorDie(this);
				}
				this.Battle.FreeTempActorList(list);
				return true;
			}
			if (!this.SkillSummon(skillInfo, p))
			{
				if (this.Battle.IsEnableDebugLog())
				{
					DebugUtility.LogError(string.Format("{0} ExecuteBattlefieldSkill() SkillSummon() skill {1} on {2} FAILED.", this.InstanceID, skillInfo.Name, p.ToString()));
				}
				return false;
			}
			return true;
		}

		// Token: 0x060032FB RID: 13051 RVA: 0x000DA2E8 File Offset: 0x000D84E8
		private bool SkillAttack(ConfigDataSkillInfo skillInfo, BattleActor target)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SkillAttackConfigDataSkillInfoBattleActor_hotfix != null)
			{
				return Convert.ToBoolean(this.m_SkillAttackConfigDataSkillInfoBattleActor_hotfix.call(new object[]
				{
					this,
					skillInfo,
					target
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (skillInfo == null)
			{
				return false;
			}
			if (target == null)
			{
				return false;
			}
			target.AttackBy(this, skillInfo);
			return true;
		}

		// Token: 0x060032FC RID: 13052 RVA: 0x000DA390 File Offset: 0x000D8590
		private bool SkillSummon(ConfigDataSkillInfo skillInfo, GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SkillSummonConfigDataSkillInfoGridPosition_hotfix != null)
			{
				return Convert.ToBoolean(this.m_SkillSummonConfigDataSkillInfoGridPosition_hotfix.call(new object[]
				{
					this,
					skillInfo,
					p
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (skillInfo == null)
			{
				if (this.Battle.IsEnableDebugLog())
				{
					DebugUtility.LogError(string.Format("{0} SkillSummon() skillInfo is null.", this.InstanceID));
				}
				return false;
			}
			BattleMap map = this.Battle.Map;
			if (!map.IsValidPosition(p))
			{
				if (this.Battle.IsEnableDebugLog())
				{
					DebugUtility.LogError(string.Format("{0} SkillSummon() position {1} is not valid.", this.InstanceID, p.ToString()));
				}
				return false;
			}
			if (map.GetActor(p) != null)
			{
				if (this.Battle.IsEnableDebugLog())
				{
					DebugUtility.LogError(string.Format("{0} SkillSummon() position {1} is not empty.", this.InstanceID, p.ToString()));
				}
				return false;
			}
			IConfigDataLoader configDataLoader = this.Battle.ConfigDataLoader;
			ConfigDataHeroInfo configDataHeroInfo = configDataLoader.GetConfigDataHeroInfo(skillInfo.SkillTypeParam1);
			if (configDataHeroInfo == null)
			{
				if (this.Battle.IsEnableDebugLog())
				{
					DebugUtility.LogError(string.Format("{0} SkillSummon() hero id {1} dose not exist.", this.InstanceID, skillInfo.SkillTypeParam1));
				}
				return false;
			}
			ConfigDataJobConnectionInfo jobConnectionInfo = configDataHeroInfo.m_jobConnectionInfo;
			ConfigDataJobInfo jobInfo = jobConnectionInfo.m_jobInfo;
			ConfigDataSoldierInfo soldierInfo = configDataHeroInfo.m_soldierInfo;
			int const_SoldierCountMax = this.Battle.ConfigDataLoader.Const_SoldierCountMax;
			BattleActor battleActor = this.m_team.CreateActor();
			battleActor.Initialize(this.m_team, configDataHeroInfo, jobConnectionInfo, soldierInfo, configDataHeroInfo.m_skillInfos, null, null, null, null, this.m_heroLevel, configDataHeroInfo.Star, 0, const_SoldierCountMax, p, this.m_direction, this.m_isNpc, 0, jobInfo.Behavior, 0, BattleActorSourceType.Summon, this.m_playerIndex);
			battleActor.m_actionValue = this.m_actionValue - 1;
			battleActor.InitializeEnd(false, -1, -1);
			battleActor.SummonBy(this, skillInfo, p);
			return true;
		}

		// Token: 0x060032FD RID: 13053 RVA: 0x000DA5C8 File Offset: 0x000D87C8
		private bool SkillTeleport(ConfigDataSkillInfo skillInfo, BattleActor target, GridPosition teleportPos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SkillTeleportConfigDataSkillInfoBattleActorGridPosition_hotfix != null)
			{
				return Convert.ToBoolean(this.m_SkillTeleportConfigDataSkillInfoBattleActorGridPosition_hotfix.call(new object[]
				{
					this,
					skillInfo,
					target,
					teleportPos
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (skillInfo == null)
			{
				return false;
			}
			if (target == null)
			{
				return false;
			}
			BattleMap map = this.Battle.Map;
			BattleActor actor = map.GetActor(teleportPos);
			if (actor != null && actor != target)
			{
				return false;
			}
			if (map.GetMovePointCost(teleportPos, target.GetMoveType()) <= 0)
			{
				return false;
			}
			if (GridPosition.Distance(target.Position, teleportPos) > skillInfo.SkillTypeParam1)
			{
				return false;
			}
			target.TeleportBy(this, skillInfo, teleportPos);
			return true;
		}

		// Token: 0x060032FE RID: 13054 RVA: 0x000DA6D0 File Offset: 0x000D88D0
		private void AttackBy(BattleActor attacker, ConfigDataSkillInfo skillInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AttackByBattleActorConfigDataSkillInfo_hotfix != null)
			{
				this.m_AttackByBattleActorConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					attacker,
					skillInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (attacker == null || skillInfo == null)
			{
				return;
			}
			if (this.IsInvincible())
			{
				return;
			}
			this.FaceTo(attacker.m_position);
			ConfigDataTerrainInfo terrain = this.GetTerrain();
			int gridDistance = GridPosition.Distance(attacker.m_position, this.m_position);
			bool flag = false;
			bool flag2 = false;
			ArmyRelationData armyRelation;
			if (this.m_heroInfo != null)
			{
				armyRelation = this.Battle.ComputeArmyRelationData(attacker.m_heroArmyInfo, this.m_heroArmyInfo, attacker, this, true, skillInfo.IsMagic);
				flag = this.Battle.IsProbabilitySatisfied(attacker.m_heroBattleProperty.CriticalRate + this.m_heroBattleProperty.Buff_ReceiveCriticalRateAdd);
			}
			else
			{
				armyRelation = default(ArmyRelationData);
			}
			ArmyRelationData armyRelation2;
			if (this.m_soldierInfo != null && this.m_soldierTotalHealthPoint > 0)
			{
				armyRelation2 = this.Battle.ComputeArmyRelationData(attacker.m_heroArmyInfo, this.m_soldierArmyInfo, attacker, this, false, skillInfo.IsMagic);
				flag2 = this.Battle.IsProbabilitySatisfied(attacker.m_heroBattleProperty.CriticalRate + this.m_soldierBattleProperty.Buff_ReceiveCriticalRateAdd);
			}
			else
			{
				armyRelation2 = default(ArmyRelationData);
			}
			bool flag3 = this.m_team == attacker.m_team;
			DamageNumberType damageNumberType = BattleFormula.ComputeDamangeNumberType(skillInfo, flag, armyRelation, flag3);
			IBattleListener listener = this.Battle.Listener;
			listener.OnBattleActorSkillHitBegin(this, skillInfo, false);
			int num = 0;
			bool flag4 = skillInfo.IsDamageSkill();
			bool flag5 = skillInfo.IsHealSkill() || skillInfo.IsBuffSkill();
			if (skillInfo.SkillType == SkillType.SkillType_BF_DamageHeal && flag3)
			{
				flag4 = false;
				flag5 = true;
			}
			bool isBuffForceMagicDamage = !skillInfo.IsMagic && attacker.IsBuffForceMagicDamage(true);
			bool isBuffForceMagicDamage2 = !skillInfo.IsMagic && attacker.IsBuffForceMagicDamage(false);
			bool isBanMeleePunish = attacker.HasFightTag(FightTag.FightTag_BanMeleePunish);
			for (int i = 0; i < skillInfo.HitCountMax; i++)
			{
				int num2 = 0;
				if (this.m_heroInfo != null)
				{
					num2 = BattleFormula.ComputeSkillHpModifyValue(attacker.m_heroBattleProperty, this.m_heroBattleProperty, armyRelation, skillInfo, flag, isBuffForceMagicDamage, isBanMeleePunish, terrain, gridDistance, flag3, this.Battle.RandomNumber, this.Battle.ConfigDataLoader);
				}
				int num3 = 0;
				if (this.m_soldierInfo != null)
				{
					num3 = BattleFormula.ComputeSkillHpModifyValue(attacker.m_heroBattleProperty, this.m_soldierBattleProperty, armyRelation2, skillInfo, flag2, isBuffForceMagicDamage2, isBanMeleePunish, terrain, gridDistance, flag3, this.Battle.RandomNumber, this.Battle.ConfigDataLoader);
				}
				int num4 = 0;
				int num5 = 0;
				if (flag4)
				{
					if (num2 < 0)
					{
						num4 = -this.ComputeBuffReboundDamage(skillInfo, -num2);
					}
					if (num3 < 0)
					{
						num5 = -this.ComputeBuffReboundDamage(skillInfo, -num3);
					}
				}
				if (this.HasFightTag(FightTag.FightTag_BanDamage) && flag4)
				{
					if (num2 < 0)
					{
						num2 = 0;
					}
					if (num3 < 0)
					{
						num3 = 0;
					}
				}
				if (this.HasFightTag(FightTag.FightTag_BanHeal) && flag5)
				{
					if (num2 > 0)
					{
						num2 = 0;
					}
					if (num3 > 0)
					{
						num3 = 0;
					}
				}
				if (num2 < 0 || num3 < 0)
				{
					attacker.SetActionDamageActor();
				}
				this.SetHeroHealthPoint(this.m_heroHealthPoint + num2);
				this.SetSoldierTotalHealthPoint(this.m_soldierTotalHealthPoint + num3);
				listener.OnBattleActorSkillHit(this, skillInfo, num2, num3, damageNumberType, false);
				if (num4 != 0 || num5 != 0)
				{
					attacker.SetHeroHealthPoint(attacker.m_heroHealthPoint + num4);
					attacker.SetSoldierTotalHealthPoint(attacker.m_soldierTotalHealthPoint + num5);
					listener.OnBattleActorSkillHit(attacker, skillInfo, num4, num5, DamageNumberType.Normal, true);
					num++;
				}
				if (this.IsDead())
				{
					break;
				}
			}
			this.UpdateBattleProperties();
			listener.OnBattleActorSkillHitEnd(this, skillInfo, false);
			if (num > 0)
			{
				attacker.UpdateBattleProperties();
				listener.OnBattleActorSkillHitEnd(attacker, skillInfo, true);
			}
			bool flag6 = flag || flag2;
			this.SetBeCriticalAttack(flag6);
			if (flag6)
			{
				attacker.SetActionCriticalAttack();
			}
			if (flag4)
			{
				this.m_lastDamageBySkillInfo = skillInfo;
				if (this.m_firstDamageTurn == 0)
				{
					this.m_firstDamageTurn = this.Battle.Turn;
				}
			}
			else if (skillInfo.SkillType == SkillType.SkillType_BF_HealRemoveCD)
			{
				foreach (BattleSkillState battleSkillState in this.m_skillStates)
				{
					if (battleSkillState.m_cooldown > 0)
					{
						if (battleSkillState.m_skillInfo.SkillType != SkillType.SkillType_BF_HealRemoveCD)
						{
							battleSkillState.m_cooldown -= skillInfo.SkillTypeParam3;
							if (battleSkillState.m_cooldown < 0)
							{
								battleSkillState.m_cooldown = 0;
							}
						}
					}
				}
			}
			else if (skillInfo.SkillType == SkillType.SkillType_BF_HealNewTurn && this.m_isActionFinished)
			{
				this.m_isActionFinished = false;
			}
			this.m_deathAnimType = skillInfo.DeadAnimType;
			if (attacker.TeamNumber != this.TeamNumber)
			{
				this.IncreaseBeAttackedCount();
			}
		}

		// Token: 0x060032FF RID: 13055 RVA: 0x000DAC28 File Offset: 0x000D8E28
		private void SkillAttackEnd(ConfigDataSkillInfo skillInfo, List<BattleActor> targets)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SkillAttackEndConfigDataSkillInfoList`1_hotfix != null)
			{
				this.m_SkillAttackEndConfigDataSkillInfoList`1_hotfix.call(new object[]
				{
					this,
					skillInfo,
					targets
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (skillInfo == null)
			{
				return;
			}
			if (targets == null)
			{
				return;
			}
			foreach (BattleActor battleActor in targets)
			{
				battleActor.CheckDie(this);
				battleActor.SetBeKillAttack(battleActor.IsDead());
				battleActor.SkillDispelBuff(skillInfo);
			}
			if (!this.IsDeadOrRetreat() && targets.Count > 0)
			{
				BattleActor battleActor2 = targets[0];
				if (!battleActor2.IsDeadOrRetreat())
				{
					this.AttackBuffPunch(battleActor2);
					this.AttackBuffDrag(battleActor2);
					this.AttackBuffExchangePosition(battleActor2, false);
				}
			}
			if (skillInfo.Buffs_ID.Count > 0)
			{
				foreach (BattleActor battleActor3 in targets)
				{
					if (this.Battle.IsProbabilitySatisfied(skillInfo.BuffRate))
					{
						List<ConfigDataBuffInfo> list = this.Battle.AllocateTempBuffList();
						this.Battle.GetRandomBuffList(skillInfo.Buffs_ID, skillInfo.BuffNum, list);
						foreach (ConfigDataBuffInfo buffInfo in list)
						{
							battleActor3.AttachBuff(buffInfo, this, BuffSourceType.SkillApply, skillInfo, null);
						}
						this.Battle.FreeTempBuffList(list);
					}
				}
			}
			if (skillInfo.IsDamageSkill())
			{
				this.AttackApplyBuff(targets);
				this.AttackBuffDamage(targets, false, true, -1);
				this.AttackRemoveBuff(targets, false, true, -1);
			}
			this.BattleFieldSkillApplyBuff(targets);
			foreach (BattleActor battleActor4 in targets)
			{
				battleActor4.CheckDie(this);
				if (battleActor4.IsDead())
				{
					this.SetActionKillActor();
				}
			}
		}

		// Token: 0x06003300 RID: 13056 RVA: 0x000DAEC4 File Offset: 0x000D90C4
		public void CombatBy(BattleActor attacker)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CombatByBattleActor_hotfix != null)
			{
				this.m_CombatByBattleActor_hotfix.call(new object[]
				{
					this,
					attacker
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (attacker == null)
			{
				return;
			}
			if (this.TeamNumber != attacker.TeamNumber)
			{
				this.IncreaseBeAttackedCount();
			}
		}

		// Token: 0x06003301 RID: 13057 RVA: 0x000DAF54 File Offset: 0x000D9154
		private void TeleportBy(BattleActor attacker, ConfigDataSkillInfo skillInfo, GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeleportByBattleActorConfigDataSkillInfoGridPosition_hotfix != null)
			{
				this.m_TeleportByBattleActorConfigDataSkillInfoGridPosition_hotfix.call(new object[]
				{
					this,
					attacker,
					skillInfo,
					p
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (attacker == null || skillInfo == null)
			{
				return;
			}
			if (this.IsInvincible())
			{
				return;
			}
			this.Battle.Listener.OnBattleActorTeleport(this, skillInfo, p);
			this.MoveTo(p);
			this.Battle.CheckOnActorMove(this);
		}

		// Token: 0x06003302 RID: 13058 RVA: 0x000DB024 File Offset: 0x000D9224
		private void SummonBy(BattleActor attacker, ConfigDataSkillInfo skillInfo, GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SummonByBattleActorConfigDataSkillInfoGridPosition_hotfix != null)
			{
				this.m_SummonByBattleActorConfigDataSkillInfoGridPosition_hotfix.call(new object[]
				{
					this,
					attacker,
					skillInfo,
					p
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (attacker == null || skillInfo == null)
			{
				return;
			}
			if (this.IsInvincible())
			{
				return;
			}
			this.m_summoner = attacker;
			this.SetPosition(p);
			this.Battle.Listener.OnBattleActorSummon(this, skillInfo);
		}

		// Token: 0x06003303 RID: 13059 RVA: 0x000DB0F0 File Offset: 0x000D92F0
		public ConfigDataSkillInfo GetHeroAttackSkillInfo(MoveType targetMoveType, int distance)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroAttackSkillInfoMoveTypeInt32_hotfix != null)
			{
				return (ConfigDataSkillInfo)this.m_GetHeroAttackSkillInfoMoveTypeInt32_hotfix.call(new object[]
				{
					this,
					targetMoveType,
					distance
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_jobInfo == null)
			{
				return null;
			}
			bool isMelee = this.m_jobInfo.IsMelee;
			if (targetMoveType != MoveType.MoveType_None)
			{
				if (this.m_jobInfo.MoveType == MoveType.MoveType_Fly)
				{
					isMelee = (distance <= 1 && targetMoveType == MoveType.MoveType_Fly);
				}
				else
				{
					isMelee = (distance <= 1 && targetMoveType != MoveType.MoveType_Fly);
				}
			}
			return this.GetHeroAttackSkillInfo(isMelee);
		}

		// Token: 0x06003304 RID: 13060 RVA: 0x000DB1DC File Offset: 0x000D93DC
		public ConfigDataSkillInfo GetSoldierAttackSkillInfo(MoveType targetMoveType, int distance)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSoldierAttackSkillInfoMoveTypeInt32_hotfix != null)
			{
				return (ConfigDataSkillInfo)this.m_GetSoldierAttackSkillInfoMoveTypeInt32_hotfix.call(new object[]
				{
					this,
					targetMoveType,
					distance
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_soldierInfo == null)
			{
				return null;
			}
			bool isMelee = this.m_soldierInfo.IsMelee;
			if (targetMoveType != MoveType.MoveType_None)
			{
				if (this.m_soldierInfo.MoveType == MoveType.MoveType_Fly)
				{
					isMelee = (distance <= 1 && targetMoveType == MoveType.MoveType_Fly);
				}
				else
				{
					isMelee = (distance <= 1 && targetMoveType != MoveType.MoveType_Fly);
				}
			}
			return this.GetSoldierAttackSkillInfo(isMelee);
		}

		// Token: 0x06003305 RID: 13061 RVA: 0x000DB2C8 File Offset: 0x000D94C8
		private ConfigDataSkillInfo GetHeroAttackSkillInfo(bool isMelee)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroAttackSkillInfoBoolean_hotfix != null)
			{
				return (ConfigDataSkillInfo)this.m_GetHeroAttackSkillInfoBoolean_hotfix.call(new object[]
				{
					this,
					isMelee
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isMelee)
			{
				if (this.m_heroModelSkinResourceInfo != null && this.m_heroModelSkinResourceInfo.m_meleeSkillInfo != null)
				{
					return this.m_heroModelSkinResourceInfo.m_meleeSkillInfo;
				}
				return this.m_jobInfo.m_meleeSkillInfo;
			}
			else
			{
				if (this.m_heroModelSkinResourceInfo != null && this.m_heroModelSkinResourceInfo.m_rangeSkillInfo != null)
				{
					return this.m_heroModelSkinResourceInfo.m_rangeSkillInfo;
				}
				return this.m_jobInfo.m_rangeSkillInfo;
			}
		}

		// Token: 0x06003306 RID: 13062 RVA: 0x000DB3B0 File Offset: 0x000D95B0
		private ConfigDataSkillInfo GetSoldierAttackSkillInfo(bool isMelee)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSoldierAttackSkillInfoBoolean_hotfix != null)
			{
				return (ConfigDataSkillInfo)this.m_GetSoldierAttackSkillInfoBoolean_hotfix.call(new object[]
				{
					this,
					isMelee
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_soldierInfo == null)
			{
				return null;
			}
			if (isMelee)
			{
				if (this.m_soldierModelSkinResourceInfo != null && this.m_soldierModelSkinResourceInfo.m_meleeSkillInfo != null)
				{
					return this.m_soldierModelSkinResourceInfo.m_meleeSkillInfo;
				}
				return this.m_soldierInfo.m_meleeSkillInfo;
			}
			else
			{
				if (this.m_soldierModelSkinResourceInfo != null && this.m_soldierModelSkinResourceInfo.m_rangeSkillInfo != null)
				{
					return this.m_soldierModelSkinResourceInfo.m_rangeSkillInfo;
				}
				return this.m_soldierInfo.m_rangeSkillInfo;
			}
		}

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x06003307 RID: 13063 RVA: 0x000DB4A4 File Offset: 0x000D96A4
		// (set) Token: 0x06003308 RID: 13064 RVA: 0x000DB4C4 File Offset: 0x000D96C4
		[DoNotToLua]
		public new BattleActor.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleActor.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06003309 RID: 13065 RVA: 0x000DB4D0 File Offset: 0x000D96D0
		private void __callBase_Dispose()
		{
			base.Dispose();
		}

		// Token: 0x0600330A RID: 13066 RVA: 0x000DB4D8 File Offset: 0x000D96D8
		private void __callBase_Tick()
		{
			base.Tick();
		}

		// Token: 0x0600330B RID: 13067 RVA: 0x000DB4E0 File Offset: 0x000D96E0
		private void __callBase_TickGraphic(float dt)
		{
			base.TickGraphic(dt);
		}

		// Token: 0x0600330C RID: 13068 RVA: 0x000DB4EC File Offset: 0x000D96EC
		private void __callBase_Draw()
		{
			base.Draw();
		}

		// Token: 0x0600330D RID: 13069 RVA: 0x000DB4F4 File Offset: 0x000D96F4
		private void __callBase_Pause(bool pause)
		{
			base.Pause(pause);
		}

		// Token: 0x0600330E RID: 13070 RVA: 0x000DB500 File Offset: 0x000D9700
		private void __callBase_DoPause(bool pause)
		{
			base.DoPause(pause);
		}

		// Token: 0x0600330F RID: 13071 RVA: 0x000DB50C File Offset: 0x000D970C
		private void __callBase_DeleteMe()
		{
			base.DeleteMe();
		}

		// Token: 0x0600332B RID: 13099 RVA: 0x000DB910 File Offset: 0x000D9B10
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
					this.m_InitializeBattleTeamConfigDataHeroInfoConfigDataJobConnectionInfoConfigDataSoldierInfoConfigDataSkillInfobeConfigDataJobInfobeBattleActorEquipmentbeConfigDataSkillInfobeConfigDataSkillInfobeInt32Int32Int32Int32GridPositionInt32BooleanInt32Int32Int32BattleActorSourceTypeInt32_hotfix = (luaObj.RawGet("Initialize") as LuaFunction);
					this.m_InitializeSkinConfigDataCharImageSkinResourceInfoConfigDataModelSkinResourceInfoConfigDataModelSkinResourceInfo_hotfix = (luaObj.RawGet("InitializeSkin") as LuaFunction);
					this.m_InitializeExtraPassiveSkillAndTalentList`1ConfigDataSkillInfo_hotfix = (luaObj.RawGet("InitializeExtraPassiveSkillAndTalent") as LuaFunction);
					this.m_InitializeEndBooleanInt32Int32_hotfix = (luaObj.RawGet("InitializeEnd") as LuaFunction);
					this.m_UpdateBattleProperties_hotfix = (luaObj.RawGet("UpdateBattleProperties") as LuaFunction);
					this.m_UpdateBattlePropertiesInCombatBattleActorBooleanInt32_hotfix = (luaObj.RawGet("UpdateBattlePropertiesInCombat") as LuaFunction);
					this.m_ComputeBattlePropertiesBattlePropertyModifier_hotfix = (luaObj.RawGet("ComputeBattleProperties") as LuaFunction);
					this.m_CollectJobMasterPropertyModifiersBattlePropertyModifier_hotfix = (luaObj.RawGet("CollectJobMasterPropertyModifiers") as LuaFunction);
					this.m_CollectEquipmentPropertyModifiersBattlePropertyModifier_hotfix = (luaObj.RawGet("CollectEquipmentPropertyModifiers") as LuaFunction);
					this.m_SetPositionGridPosition_hotfix = (luaObj.RawGet("SetPosition") as LuaFunction);
					this.m_SetDirectionInt32_hotfix = (luaObj.RawGet("SetDirection") as LuaFunction);
					this.m_FaceToGridPosition_hotfix = (luaObj.RawGet("FaceTo") as LuaFunction);
					this.m_GuardMoveGridPosition_hotfix = (luaObj.RawGet("GuardMove") as LuaFunction);
					this.m_UnguardMove_hotfix = (luaObj.RawGet("UnguardMove") as LuaFunction);
					this.m_MoveToGridPosition_hotfix = (luaObj.RawGet("MoveTo") as LuaFunction);
					this.m_ClearMapActor_hotfix = (luaObj.RawGet("ClearMapActor") as LuaFunction);
					this.m_GetTerrain_hotfix = (luaObj.RawGet("GetTerrain") as LuaFunction);
					this.m_GetBuffEffectedTerrain_hotfix = (luaObj.RawGet("GetBuffEffectedTerrain") as LuaFunction);
					this.m_ChangeTeamInt32Boolean_hotfix = (luaObj.RawGet("ChangeTeam") as LuaFunction);
					this.m_CreateBattleCommandBattleCommandType_hotfix = (luaObj.RawGet("CreateBattleCommand") as LuaFunction);
					this.m_StartBattle_hotfix = (luaObj.RawGet("StartBattle") as LuaFunction);
					this.m_StopBattleBoolean_hotfix = (luaObj.RawGet("StopBattle") as LuaFunction);
					this.m_NextTurn_hotfix = (luaObj.RawGet("NextTurn") as LuaFunction);
					this.m_ActionBegin_hotfix = (luaObj.RawGet("ActionBegin") as LuaFunction);
					this.m_ActionEnd_hotfix = (luaObj.RawGet("ActionEnd") as LuaFunction);
					this.m_IsActionFinished_hotfix = (luaObj.RawGet("IsActionFinished") as LuaFunction);
					this.m_CanAction_hotfix = (luaObj.RawGet("CanAction") as LuaFunction);
					this.m_PostActionTerrainDamage_hotfix = (luaObj.RawGet("PostActionTerrainDamage") as LuaFunction);
					this.m_FindPathGridPositionGridPositionInt32Int32List`1Boolean_hotfix = (luaObj.RawGet("FindPath") as LuaFunction);
					this.m_FindMoveRegionGridPositionList`1_hotfix = (luaObj.RawGet("FindMoveRegion") as LuaFunction);
					this.m_ShouldLog_hotfix = (luaObj.RawGet("ShouldLog") as LuaFunction);
					this.m_AddExecutedCommandTypeBattleCommandType_hotfix = (luaObj.RawGet("AddExecutedCommandType") as LuaFunction);
					this.m_HasExecutedCommandTypeBattleCommandType_hotfix = (luaObj.RawGet("HasExecutedCommandType") as LuaFunction);
					this.m_IsExecutedCommandTypeBattleCommandType_hotfix = (luaObj.RawGet("IsExecutedCommandType") as LuaFunction);
					this.m_ExecuteMoveCommandGridPosition_hotfix = (luaObj.RawGet("ExecuteMoveCommand") as LuaFunction);
					this.m_ExecutePerformMoveCommandGridPositionBoolean_hotfix = (luaObj.RawGet("ExecutePerformMoveCommand") as LuaFunction);
					this.m_ExecuteCombatCommandBattleActorConfigDataSkillInfoBoolean_hotfix = (luaObj.RawGet("ExecuteCombatCommand") as LuaFunction);
					this.m_ExecuteSkillCommandInt32GridPositionGridPosition_hotfix = (luaObj.RawGet("ExecuteSkillCommand") as LuaFunction);
					this.m_ExecutePerformSkillCommandConfigDataSkillInfoGridPositionGridPosition_hotfix = (luaObj.RawGet("ExecutePerformSkillCommand") as LuaFunction);
					this.m_ExecuteDoneCommand_hotfix = (luaObj.RawGet("ExecuteDoneCommand") as LuaFunction);
					this.m_IsDead_hotfix = (luaObj.RawGet("IsDead") as LuaFunction);
					this.m_IsRetreat_hotfix = (luaObj.RawGet("IsRetreat") as LuaFunction);
					this.m_IsDeadOrRetreat_hotfix = (luaObj.RawGet("IsDeadOrRetreat") as LuaFunction);
					this.m_SetVisibleBoolean_hotfix = (luaObj.RawGet("SetVisible") as LuaFunction);
					this.m_IsVisible_hotfix = (luaObj.RawGet("IsVisible") as LuaFunction);
					this.m_IsInvincible_hotfix = (luaObj.RawGet("IsInvincible") as LuaFunction);
					this.m_IsSummoned_hotfix = (luaObj.RawGet("IsSummoned") as LuaFunction);
					this.m_IsNpc_hotfix = (luaObj.RawGet("IsNpc") as LuaFunction);
					this.m_IsAINpc_hotfix = (luaObj.RawGet("IsAINpc") as LuaFunction);
					this.m_IsPlayerNpc_hotfix = (luaObj.RawGet("IsPlayerNpc") as LuaFunction);
					this.m_IsPlayerActor_hotfix = (luaObj.RawGet("IsPlayerActor") as LuaFunction);
					this.m_IsAIActor_hotfix = (luaObj.RawGet("IsAIActor") as LuaFunction);
					this.m_CanBeTarget_hotfix = (luaObj.RawGet("CanBeTarget") as LuaFunction);
					this.m_SetHeroHealthPointInt32_hotfix = (luaObj.RawGet("SetHeroHealthPoint") as LuaFunction);
					this.m_SetSoldierTotalHealthPointInt32_hotfix = (luaObj.RawGet("SetSoldierTotalHealthPoint") as LuaFunction);
					this.m_CheckDieBattleActor_hotfix = (luaObj.RawGet("CheckDie") as LuaFunction);
					this.m_RetreatInt32StringBoolean_hotfix = (luaObj.RawGet("Retreat") as LuaFunction);
					this.m_GetSoldierAttackDistance_hotfix = (luaObj.RawGet("GetSoldierAttackDistance") as LuaFunction);
					this.m_GetMaxAttackDistance_hotfix = (luaObj.RawGet("GetMaxAttackDistance") as LuaFunction);
					this.m_GetTalentSkillInfo_hotfix = (luaObj.RawGet("GetTalentSkillInfo") as LuaFunction);
					this.m_GetSkillDistanceConfigDataSkillInfo_hotfix = (luaObj.RawGet("GetSkillDistance") as LuaFunction);
					this.m_GetMovePoint_hotfix = (luaObj.RawGet("GetMovePoint") as LuaFunction);
					this.m_GetMoveType_hotfix = (luaObj.RawGet("GetMoveType") as LuaFunction);
					this.m_GetTotalHealthPoint_hotfix = (luaObj.RawGet("GetTotalHealthPoint") as LuaFunction);
					this.m_GetTotalHealthPointMax_hotfix = (luaObj.RawGet("GetTotalHealthPointMax") as LuaFunction);
					this.m_GetSoldierCount_hotfix = (luaObj.RawGet("GetSoldierCount") as LuaFunction);
					this.m_SetLastDamageBySkillConfigDataSkillInfo_hotfix = (luaObj.RawGet("SetLastDamageBySkill") as LuaFunction);
					this.m_GetLastDamageBySkill_hotfix = (luaObj.RawGet("GetLastDamageBySkill") as LuaFunction);
					this.m_SetFirstDamageTurnInt32_hotfix = (luaObj.RawGet("SetFirstDamageTurn") as LuaFunction);
					this.m_GetFirstDamageTurn_hotfix = (luaObj.RawGet("GetFirstDamageTurn") as LuaFunction);
					this.m_SetSetisfyConditionInt32_hotfix = (luaObj.RawGet("SetSetisfyCondition") as LuaFunction);
					this.m_IsSatisfyConditionInt32_hotfix = (luaObj.RawGet("IsSatisfyCondition") as LuaFunction);
					this.m_GetDeathAnimType_hotfix = (luaObj.RawGet("GetDeathAnimType") as LuaFunction);
					this.m_SetBeCriticalAttackBoolean_hotfix = (luaObj.RawGet("SetBeCriticalAttack") as LuaFunction);
					this.m_SetBeKillAttackBoolean_hotfix = (luaObj.RawGet("SetBeKillAttack") as LuaFunction);
					this.m_SetActionCriticalAttack_hotfix = (luaObj.RawGet("SetActionCriticalAttack") as LuaFunction);
					this.m_SetActionKillActor_hotfix = (luaObj.RawGet("SetActionKillActor") as LuaFunction);
					this.m_SetActionDamageActor_hotfix = (luaObj.RawGet("SetActionDamageActor") as LuaFunction);
					this.m_IsExtraAction_hotfix = (luaObj.RawGet("IsExtraAction") as LuaFunction);
					this.m_IsExtraActionMoving_hotfix = (luaObj.RawGet("IsExtraActionMoving") as LuaFunction);
					this.m_GetActionCount_hotfix = (luaObj.RawGet("GetActionCount") as LuaFunction);
					this.m_IncreaseCombatAttackCount_hotfix = (luaObj.RawGet("IncreaseCombatAttackCount") as LuaFunction);
					this.m_GetCombatAttackCount_hotfix = (luaObj.RawGet("GetCombatAttackCount") as LuaFunction);
					this.m_IncreaseBeCombatAttackCount_hotfix = (luaObj.RawGet("IncreaseBeCombatAttackCount") as LuaFunction);
					this.m_GetBeCombatAttackCount_hotfix = (luaObj.RawGet("GetBeCombatAttackCount") as LuaFunction);
					this.m_IncreaseUseSkillCount_hotfix = (luaObj.RawGet("IncreaseUseSkillCount") as LuaFunction);
					this.m_GetUseSkillCount_hotfix = (luaObj.RawGet("GetUseSkillCount") as LuaFunction);
					this.m_IncreaseKillActorCount_hotfix = (luaObj.RawGet("IncreaseKillActorCount") as LuaFunction);
					this.m_GetKillActorCount_hotfix = (luaObj.RawGet("GetKillActorCount") as LuaFunction);
					this.m_GetKillerActor_hotfix = (luaObj.RawGet("GetKillerActor") as LuaFunction);
					this.m_GetDieTurn_hotfix = (luaObj.RawGet("GetDieTurn") as LuaFunction);
					this.m_GetSourceType_hotfix = (luaObj.RawGet("GetSourceType") as LuaFunction);
					this.m_get_Position_hotfix = (luaObj.RawGet("get_Position") as LuaFunction);
					this.m_get_InitPosition_hotfix = (luaObj.RawGet("get_InitPosition") as LuaFunction);
					this.m_get_Direction_hotfix = (luaObj.RawGet("get_Direction") as LuaFunction);
					this.m_get_Battle_hotfix = (luaObj.RawGet("get_Battle") as LuaFunction);
					this.m_get_Team_hotfix = (luaObj.RawGet("get_Team") as LuaFunction);
					this.m_get_TeamNumber_hotfix = (luaObj.RawGet("get_TeamNumber") as LuaFunction);
					this.m_get_HeroBattleProperty_hotfix = (luaObj.RawGet("get_HeroBattleProperty") as LuaFunction);
					this.m_get_SoldierBattleProperty_hotfix = (luaObj.RawGet("get_SoldierBattleProperty") as LuaFunction);
					this.m_get_HeroHealthPoint_hotfix = (luaObj.RawGet("get_HeroHealthPoint") as LuaFunction);
					this.m_get_SoldierTotalHealthPoint_hotfix = (luaObj.RawGet("get_SoldierTotalHealthPoint") as LuaFunction);
					this.m_get_SoldierSingleHealthPointMax_hotfix = (luaObj.RawGet("get_SoldierSingleHealthPointMax") as LuaFunction);
					this.m_get_FightTags_hotfix = (luaObj.RawGet("get_FightTags") as LuaFunction);
					this.m_get_HeroLevel_hotfix = (luaObj.RawGet("get_HeroLevel") as LuaFunction);
					this.m_get_HeroStar_hotfix = (luaObj.RawGet("get_HeroStar") as LuaFunction);
					this.m_get_JobLevel_hotfix = (luaObj.RawGet("get_JobLevel") as LuaFunction);
					this.m_get_ActionValue_hotfix = (luaObj.RawGet("get_ActionValue") as LuaFunction);
					this.m_set_ActionValueInt32_hotfix = (luaObj.RawGet("set_ActionValue") as LuaFunction);
					this.m_get_HeroInfo_hotfix = (luaObj.RawGet("get_HeroInfo") as LuaFunction);
					this.m_get_HeroId_hotfix = (luaObj.RawGet("get_HeroId") as LuaFunction);
					this.m_get_HeroArmyInfo_hotfix = (luaObj.RawGet("get_HeroArmyInfo") as LuaFunction);
					this.m_get_HeroArmyId_hotfix = (luaObj.RawGet("get_HeroArmyId") as LuaFunction);
					this.m_get_JobConnectionInfo_hotfix = (luaObj.RawGet("get_JobConnectionInfo") as LuaFunction);
					this.m_get_JobInfo_hotfix = (luaObj.RawGet("get_JobInfo") as LuaFunction);
					this.m_get_SoldierInfo_hotfix = (luaObj.RawGet("get_SoldierInfo") as LuaFunction);
					this.m_get_SoldierArmyInfo_hotfix = (luaObj.RawGet("get_SoldierArmyInfo") as LuaFunction);
					this.m_get_HeroCharImageSkinResourceInfo_hotfix = (luaObj.RawGet("get_HeroCharImageSkinResourceInfo") as LuaFunction);
					this.m_get_HeroModelSkinResourceInfo_hotfix = (luaObj.RawGet("get_HeroModelSkinResourceInfo") as LuaFunction);
					this.m_get_SoldierModelSkinResourceInfo_hotfix = (luaObj.RawGet("get_SoldierModelSkinResourceInfo") as LuaFunction);
					this.m_get_PlayerIndex_hotfix = (luaObj.RawGet("get_PlayerIndex") as LuaFunction);
					this.m_FindMoveAndAttackRegionInt32Int32_hotfix = (luaObj.RawGet("FindMoveAndAttackRegion") as LuaFunction);
					this.m_FindRandomEmptyPositionInt32Int32GridPosition__hotfix = (luaObj.RawGet("FindRandomEmptyPosition") as LuaFunction);
					this.m_FindAttackPositionInt32Int32GridPositionBooleanBoolean_hotfix = (luaObj.RawGet("FindAttackPosition") as LuaFunction);
					this.m_ComputeActorScoreBuffBattleActorInt32_hotfix = (luaObj.RawGet("ComputeActorScoreBuff") as LuaFunction);
					this.m_SelectNearestTargetBattleTeam_hotfix = (luaObj.RawGet("SelectNearestTarget") as LuaFunction);
					this.m_GetAIRandomNumber_hotfix = (luaObj.RawGet("GetAIRandomNumber") as LuaFunction);
					this.m_GetSkillTargetTeamConfigDataSkillInfo_hotfix = (luaObj.RawGet("GetSkillTargetTeam") as LuaFunction);
					this.m_CanAttackOrUseSkill_hotfix = (luaObj.RawGet("CanAttackOrUseSkill") as LuaFunction);
					this.m_get_Group_hotfix = (luaObj.RawGet("get_Group") as LuaFunction);
					this.m_set_GroupBehaviorGroup_hotfix = (luaObj.RawGet("set_Group") as LuaFunction);
					this.m_get_GroupId_hotfix = (luaObj.RawGet("get_GroupId") as LuaFunction);
					this.m_IncreaseBeAttackedCount_hotfix = (luaObj.RawGet("IncreaseBeAttackedCount") as LuaFunction);
					this.m_get_IsAttackedByEnemy_hotfix = (luaObj.RawGet("get_IsAttackedByEnemy") as LuaFunction);
					this.m_get_IsAttackedByEnemyInLastTrun_hotfix = (luaObj.RawGet("get_IsAttackedByEnemyInLastTrun") as LuaFunction);
					this.m_get_InstanceID_hotfix = (luaObj.RawGet("get_InstanceID") as LuaFunction);
					this.m_GetBehaviorId_hotfix = (luaObj.RawGet("GetBehaviorId") as LuaFunction);
					this.m_SetBehaviorInt32_hotfix = (luaObj.RawGet("SetBehavior") as LuaFunction);
					this.m_SetBehaviorStateBehaviorState_hotfix = (luaObj.RawGet("SetBehaviorState") as LuaFunction);
					this.m_CheckBehaviorConditionBehaviorConditionParamData_hotfix = (luaObj.RawGet("CheckBehaviorCondition") as LuaFunction);
					this.m_DoBehaviorChangeRules_hotfix = (luaObj.RawGet("DoBehaviorChangeRules") as LuaFunction);
					this.m_get_NextBehaviorByChangeRules_hotfix = (luaObj.RawGet("get_NextBehaviorByChangeRules") as LuaFunction);
					this.m_FindEmptyGridInCanAttackAndTouchRangeGridPositionInt32Int32_hotfix = (luaObj.RawGet("FindEmptyGridInCanAttackAndTouchRange") as LuaFunction);
					this.m_FindActorsInCanAttackAndTouchRangeList`1GridPositionInt32Int32Boolean_hotfix = (luaObj.RawGet("FindActorsInCanAttackAndTouchRange") as LuaFunction);
					this.m_FindFarthestPositionList`1GridPosition_hotfix = (luaObj.RawGet("FindFarthestPosition") as LuaFunction);
					this.m_FindNearestPositionList`1GridPosition_hotfix = (luaObj.RawGet("FindNearestPosition") as LuaFunction);
					this.m_FindNearestActorList`1GridPosition_hotfix = (luaObj.RawGet("FindNearestActor") as LuaFunction);
					this.m_DoSelectTargetSelectTargetParamData_hotfix = (luaObj.RawGet("DoSelectTarget") as LuaFunction);
					this.m_FindActorsByIDFilterList`1Int32beInt32be_hotfix = (luaObj.RawGet("FindActorsByIDFilter") as LuaFunction);
					this.m_SelectMoveTarget_hotfix = (luaObj.RawGet("SelectMoveTarget") as LuaFunction);
					this.m_FindPathGridPositionGridPositionInt32Int32Int32List`1_hotfix = (luaObj.RawGet("FindPath") as LuaFunction);
					this.m_GenerateCommandOfMoveGridPosition_hotfix = (luaObj.RawGet("GenerateCommandOfMove") as LuaFunction);
					this.m_FindPositionToMoveToTargetGridPosition_hotfix = (luaObj.RawGet("FindPositionToMoveToTarget") as LuaFunction);
					this.m_ComputeRestrictScoreBattleActorBattleActor_hotfix = (luaObj.RawGet("ComputeRestrictScore") as LuaFunction);
					this.m_GetArmyRistrictScoreArmyTagArmyTag_hotfix = (luaObj.RawGet("GetArmyRistrictScore") as LuaFunction);
					this.m_get_TotalHPPercent_hotfix = (luaObj.RawGet("get_TotalHPPercent") as LuaFunction);
					this.m_DefaultSelectDamageSkillTargetList`1_hotfix = (luaObj.RawGet("DefaultSelectDamageSkillTarget") as LuaFunction);
					this.m_IsSelectRangeSkill_hotfix = (luaObj.RawGet("IsSelectRangeSkill") as LuaFunction);
					this.m_get_BehaviorSelectSkillInfo_hotfix = (luaObj.RawGet("get_BehaviorSelectSkillInfo") as LuaFunction);
					this.m_FindActorsInGridsList`1List`1_hotfix = (luaObj.RawGet("FindActorsInGrids") as LuaFunction);
					this.m_FindMaxAoeSkillCoverPositionConfigDataSkillInfoList`1List`1ClassValue`1_hotfix = (luaObj.RawGet("FindMaxAoeSkillCoverPosition") as LuaFunction);
					this.m_FindMaxAoeSkillCoverActorConfigDataSkillInfoList`1List`1ClassValue`1_hotfix = (luaObj.RawGet("FindMaxAoeSkillCoverActor") as LuaFunction);
					this.m_DefaultSelectAttackTarget_hotfix = (luaObj.RawGet("DefaultSelectAttackTarget") as LuaFunction);
					this.m_FindGridsLessEqualDistanceGridPositionInt32_hotfix = (luaObj.RawGet("FindGridsLessEqualDistance") as LuaFunction);
					this.m_FindActorsLessEqualDistanceList`1GridPositionInt32_hotfix = (luaObj.RawGet("FindActorsLessEqualDistance") as LuaFunction);
					this.m_DefaultSelectHealSkillTargetList`1_hotfix = (luaObj.RawGet("DefaultSelectHealSkillTarget") as LuaFunction);
					this.m_DefaultSelectBuffSkillTargetList`1ConfigDataSkillInfo_hotfix = (luaObj.RawGet("DefaultSelectBuffSkillTarget") as LuaFunction);
					this.m_SelectAttackTargetInSkillRange_hotfix = (luaObj.RawGet("SelectAttackTargetInSkillRange") as LuaFunction);
					this.m_FindActorsWithBuffNList`1Int32_hotfix = (luaObj.RawGet("FindActorsWithBuffN") as LuaFunction);
					this.m_SelectAttackTarget_hotfix = (luaObj.RawGet("SelectAttackTarget") as LuaFunction);
					this.m_SelectSkill_hotfix = (luaObj.RawGet("SelectSkill") as LuaFunction);
					this.m_SelectSkillDirectReachTarget_hotfix = (luaObj.RawGet("SelectSkillDirectReachTarget") as LuaFunction);
					this.m_DefaultSelectSkillInt32beInt32be_hotfix = (luaObj.RawGet("DefaultSelectSkill") as LuaFunction);
					this.m_FindActorsInCanNormalAttackAndTouchRangeList`1List`1_hotfix = (luaObj.RawGet("FindActorsInCanNormalAttackAndTouchRange") as LuaFunction);
					this.m_IsSkillAGoodAISelectionConfigDataSkillInfo_hotfix = (luaObj.RawGet("IsSkillAGoodAISelection") as LuaFunction);
					this.m_FindCastSkillPositionConfigDataSkillInfoBehaviorTarget_hotfix = (luaObj.RawGet("FindCastSkillPosition") as LuaFunction);
					this.m_FindAttackPositionsInt32Int32GridPositionList`1_hotfix = (luaObj.RawGet("FindAttackPositions") as LuaFunction);
					this.m_GenerateCommandOfAttack_hotfix = (luaObj.RawGet("GenerateCommandOfAttack") as LuaFunction);
					this.m_DoBehaviorMove_hotfix = (luaObj.RawGet("DoBehaviorMove") as LuaFunction);
					this.m_IsAttackTargetStillValid_hotfix = (luaObj.RawGet("IsAttackTargetStillValid") as LuaFunction);
					this.m_DoBehaviorAttack_hotfix = (luaObj.RawGet("DoBehaviorAttack") as LuaFunction);
					this.m_GenerateAIBattleCommand_hotfix = (luaObj.RawGet("GenerateAIBattleCommand") as LuaFunction);
					this.m_AICreateBattleCommandBattleCommandType_hotfix = (luaObj.RawGet("AICreateBattleCommand") as LuaFunction);
					this.m_SelectAttackRegionTargetBattleTeamComputeActorScoreFuncInt32_hotfix = (luaObj.RawGet("SelectAttackRegionTarget") as LuaFunction);
					this.m_GetBuffStates_hotfix = (luaObj.RawGet("GetBuffStates") as LuaFunction);
					this.m_InitializeBuffs_hotfix = (luaObj.RawGet("InitializeBuffs") as LuaFunction);
					this.m_AttachPassiveSkillBuffsConfigDataSkillInfoBuffSourceType_hotfix = (luaObj.RawGet("AttachPassiveSkillBuffs") as LuaFunction);
					this.m_AttachBuffConfigDataBuffInfoBattleActorBuffSourceTypeConfigDataSkillInfoBuffState_hotfix = (luaObj.RawGet("AttachBuff") as LuaFunction);
					this.m_RemoveBuffBuffState_hotfix = (luaObj.RawGet("RemoveBuff") as LuaFunction);
					this.m_RemoveBuffListList`1_hotfix = (luaObj.RawGet("RemoveBuffList") as LuaFunction);
					this.m_RemoveBuffListList`1BattleActor_hotfix = (luaObj.RawGet("RemoveBuffList") as LuaFunction);
					this.m_FindBuffInt32BattleActor_hotfix = (luaObj.RawGet("FindBuff") as LuaFunction);
					this.m_RemoveAllBuffs_hotfix = (luaObj.RawGet("RemoveAllBuffs") as LuaFunction);
					this.m_SkillDispelBuffConfigDataSkillInfo_hotfix = (luaObj.RawGet("SkillDispelBuff") as LuaFunction);
					this.m_HasBuffInt32_hotfix = (luaObj.RawGet("HasBuff") as LuaFunction);
					this.m_CollectBuffPropertyModifiersAndFightTagsBattlePropertyModifierUInt32__hotfix = (luaObj.RawGet("CollectBuffPropertyModifiersAndFightTags") as LuaFunction);
					this.m_CollectBuffPropertyModifiersAndFightTagsBattlePropertyModifierUInt32_BooleanBoolean_hotfix = (luaObj.RawGet("CollectBuffPropertyModifiersAndFightTags") as LuaFunction);
					this.m_CollectPropertyModifierBattlePropertyModifierPropertyModifyTypeInt32BooleanBoolean_hotfix = (luaObj.RawGet("CollectPropertyModifier") as LuaFunction);
					this.m_CollectOtherActorBuffPropertyModifiersAndFightTagsBattlePropertyModifierUInt32__hotfix = (luaObj.RawGet("CollectOtherActorBuffPropertyModifiersAndFightTags") as LuaFunction);
					this.m_CollectBuffPropertyModifiersAndFightTagsInCombatBattlePropertyModifierUInt32_BattleActorBooleanInt32_hotfix = (luaObj.RawGet("CollectBuffPropertyModifiersAndFightTagsInCombat") as LuaFunction);
					this.m_CollectBuffPropertyExchangeBattlePropertyBattlePropertyModifier_hotfix = (luaObj.RawGet("CollectBuffPropertyExchange") as LuaFunction);
					this.m_CollectBuffPropertyReplace_hotfix = (luaObj.RawGet("CollectBuffPropertyReplace") as LuaFunction);
					this.m_UpdateAllAuras_hotfix = (luaObj.RawGet("UpdateAllAuras") as LuaFunction);
					this.m_RemoveAuraAppliedBuffsConfigDataBuffInfo_hotfix = (luaObj.RawGet("RemoveAuraAppliedBuffs") as LuaFunction);
					this.m_RemovePackChildBuffsBuffState_hotfix = (luaObj.RawGet("RemovePackChildBuffs") as LuaFunction);
					this.m_OnBuffHitBuffStateInt32Int32DamageNumberType_hotfix = (luaObj.RawGet("OnBuffHit") as LuaFunction);
					this.m_HasFightTagFightTag_hotfix = (luaObj.RawGet("HasFightTag") as LuaFunction);
					this.m_UpdateBuffTypes_hotfix = (luaObj.RawGet("UpdateBuffTypes") as LuaFunction);
					this.m_SetBuffTypeBuffTypeBoolean_hotfix = (luaObj.RawGet("SetBuffType") as LuaFunction);
					this.m_HasBuffTypeBuffType_hotfix = (luaObj.RawGet("HasBuffType") as LuaFunction);
					this.m_IsBuffEffectiveBuffState_hotfix = (luaObj.RawGet("IsBuffEffective") as LuaFunction);
					this.m_IsBuffHpConditionSatisfiedConfigDataBuffInfo_hotfix = (luaObj.RawGet("IsBuffHpConditionSatisfied") as LuaFunction);
					this.m_IsBuffHpConditionSatisfiedInt32Int32Int32_hotfix = (luaObj.RawGet("IsBuffHpConditionSatisfied") as LuaFunction);
					this.m_IsBuffEffectiveConditionSatisfiedConfigDataBuffInfo_hotfix = (luaObj.RawGet("IsBuffEffectiveConditionSatisfied") as LuaFunction);
					this.m_IsBuffCombatConditionSatisfiedBattleActorBooleanInt32Int32Int32Int32_hotfix = (luaObj.RawGet("IsBuffCombatConditionSatisfied") as LuaFunction);
					this.m_IsBuffCombatConditionSatisfiedBattleActorBooleanBooleanInt32BooleanList`1_hotfix = (luaObj.RawGet("IsBuffCombatConditionSatisfied") as LuaFunction);
					this.m_ComputeNeighborAliveActorCountInt32Int32_hotfix = (luaObj.RawGet("ComputeNeighborAliveActorCount") as LuaFunction);
					this.m_IsBuffCooldownBuffState_hotfix = (luaObj.RawGet("IsBuffCooldown") as LuaFunction);
					this.m_StartBuffCooldownBuffState_hotfix = (luaObj.RawGet("StartBuffCooldown") as LuaFunction);
					this.m_ComputeBuffCountInt32_hotfix = (luaObj.RawGet("ComputeBuffCount") as LuaFunction);
					this.m_ComputeEnhanceOrDebuffCountInt32_hotfix = (luaObj.RawGet("ComputeEnhanceOrDebuffCount") as LuaFunction);
					this.m_IsImmuneBuffSubTypeInt32_hotfix = (luaObj.RawGet("IsImmuneBuffSubType") as LuaFunction);
					this.m_ComputeBuffReboundDamageConfigDataSkillInfoInt32_hotfix = (luaObj.RawGet("ComputeBuffReboundDamage") as LuaFunction);
					this.m_GetBuffOverrideMovePointCost_hotfix = (luaObj.RawGet("GetBuffOverrideMovePointCost") as LuaFunction);
					this.m_GetBuffOverrideTerrain_hotfix = (luaObj.RawGet("GetBuffOverrideTerrain") as LuaFunction);
					this.m_AddBuffArmyRelationAttackInt32BooleanArmyRelationData__hotfix = (luaObj.RawGet("AddBuffArmyRelationAttack") as LuaFunction);
					this.m_AddBuffArmyRelationDefendInt32BooleanArmyRelationData__hotfix = (luaObj.RawGet("AddBuffArmyRelationDefend") as LuaFunction);
					this.m_AddBuffArmyRelationModifyAttackInt32BooleanArmyRelationData__hotfix = (luaObj.RawGet("AddBuffArmyRelationModifyAttack") as LuaFunction);
					this.m_AddBuffArmyRelationModifyDefendInt32BooleanArmyRelationData__hotfix = (luaObj.RawGet("AddBuffArmyRelationModifyDefend") as LuaFunction);
					this.m_IsBuffForceMagicDamageBoolean_hotfix = (luaObj.RawGet("IsBuffForceMagicDamage") as LuaFunction);
					this.m_ActionEndBuffEffect_hotfix = (luaObj.RawGet("ActionEndBuffEffect") as LuaFunction);
					this.m_UpdateBuffTime_hotfix = (luaObj.RawGet("UpdateBuffTime") as LuaFunction);
					this.m_ActionEndBuffDoubleMoveBooleanBoolean_hotfix = (luaObj.RawGet("ActionEndBuffDoubleMove") as LuaFunction);
					this.m_ActionEndBuffHealOverTimeBoolean_hotfix = (luaObj.RawGet("ActionEndBuffHealOverTime") as LuaFunction);
					this.m_ActionEndBuffDamageOverTime_hotfix = (luaObj.RawGet("ActionEndBuffDamageOverTime") as LuaFunction);
					this.m_ActionEndAddBuff_hotfix = (luaObj.RawGet("ActionEndAddBuff") as LuaFunction);
					this.m_ActionEndAddBuffSuperBooleanBoolean_hotfix = (luaObj.RawGet("ActionEndAddBuffSuper") as LuaFunction);
					this.m_ActionEndRemoveDebuff_hotfix = (luaObj.RawGet("ActionEndRemoveDebuff") as LuaFunction);
					this.m_ActionEndRemoveEnhanceBuffBooleanBooleanBoolean_hotfix = (luaObj.RawGet("ActionEndRemoveEnhanceBuff") as LuaFunction);
					this.m_ActionEndBuffBattlefieldSkillBooleanBooleanBoolean_hotfix = (luaObj.RawGet("ActionEndBuffBattlefieldSkill") as LuaFunction);
					this.m_ActionEndBuffNewTurnBooleanBoolean_hotfix = (luaObj.RawGet("ActionEndBuffNewTurn") as LuaFunction);
					this.m_CombatBuffHealBattleActorBooleanBooleanInt32BooleanInt32Int32_hotfix = (luaObj.RawGet("CombatBuffHeal") as LuaFunction);
					this.m_CombatBuffHealOtherBattleActorBooleanBooleanInt32BooleanInt32Int32_hotfix = (luaObj.RawGet("CombatBuffHealOther") as LuaFunction);
					this.m_CombatBuffDamageBattleActorBooleanBooleanInt32Boolean_hotfix = (luaObj.RawGet("CombatBuffDamage") as LuaFunction);
					this.m_CombatApplyBuffBattleActorBooleanBooleanInt32Boolean_hotfix = (luaObj.RawGet("CombatApplyBuff") as LuaFunction);
					this.m_AttackApplyBuffList`1_hotfix = (luaObj.RawGet("AttackApplyBuff") as LuaFunction);
					this.m_AttackBuffDamageList`1BooleanBooleanInt32_hotfix = (luaObj.RawGet("AttackBuffDamage") as LuaFunction);
					this.m_AttackRemoveBuffList`1BooleanBooleanInt32_hotfix = (luaObj.RawGet("AttackRemoveBuff") as LuaFunction);
					this.m_AttackRemoveSkillCooldownConfigDataSkillInfoBooleanBoolean_hotfix = (luaObj.RawGet("AttackRemoveSkillCooldown") as LuaFunction);
					this.m_BattleFieldSkillApplyBuffList`1_hotfix = (luaObj.RawGet("BattleFieldSkillApplyBuff") as LuaFunction);
					this.m_AttackBuffPunchBattleActor_hotfix = (luaObj.RawGet("AttackBuffPunch") as LuaFunction);
					this.m_AttackBuffDragBattleActor_hotfix = (luaObj.RawGet("AttackBuffDrag") as LuaFunction);
					this.m_AttackBuffExchangePositionBattleActorBoolean_hotfix = (luaObj.RawGet("AttackBuffExchangePosition") as LuaFunction);
					this.m_CombatArmyChangeBattleActor_hotfix = (luaObj.RawGet("CombatArmyChange") as LuaFunction);
					this.m_BuffDoubleAttack_hotfix = (luaObj.RawGet("BuffDoubleAttack") as LuaFunction);
					this.m_BuffUndead_hotfix = (luaObj.RawGet("BuffUndead") as LuaFunction);
					this.m_CanBuffGuardBattleActorConfigDataSkillInfo_hotfix = (luaObj.RawGet("CanBuffGuard") as LuaFunction);
					this.m_GetGuardActorConfigDataSkillInfo_hotfix = (luaObj.RawGet("GetGuardActor") as LuaFunction);
					this.m_AfterCombatDetachBuff_hotfix = (luaObj.RawGet("AfterCombatDetachBuff") as LuaFunction);
					this.m_GetSkillStateInt32_hotfix = (luaObj.RawGet("GetSkillState") as LuaFunction);
					this.m_GetSkillStateByIdInt32_hotfix = (luaObj.RawGet("GetSkillStateById") as LuaFunction);
					this.m_GetSkillStates_hotfix = (luaObj.RawGet("GetSkillStates") as LuaFunction);
					this.m_IsSkillUseableInt32_hotfix = (luaObj.RawGet("IsSkillUseable") as LuaFunction);
					this.m_CanUseSkillOnTargetConfigDataSkillInfoBattleActor_hotfix = (luaObj.RawGet("CanUseSkillOnTarget") as LuaFunction);
					this.m_IsBattlefiledSkillApplyTargetConfigDataSkillInfoBattleActor_hotfix = (luaObj.RawGet("IsBattlefiledSkillApplyTarget") as LuaFunction);
					this.m_FindBattlefieldSkillApplyTargetsConfigDataSkillInfoGridPositionList`1_hotfix = (luaObj.RawGet("FindBattlefieldSkillApplyTargets") as LuaFunction);
					this.m_ExecuteBattlefieldSkillConfigDataSkillInfoGridPositionGridPosition_hotfix = (luaObj.RawGet("ExecuteBattlefieldSkill") as LuaFunction);
					this.m_SkillAttackConfigDataSkillInfoBattleActor_hotfix = (luaObj.RawGet("SkillAttack") as LuaFunction);
					this.m_SkillSummonConfigDataSkillInfoGridPosition_hotfix = (luaObj.RawGet("SkillSummon") as LuaFunction);
					this.m_SkillTeleportConfigDataSkillInfoBattleActorGridPosition_hotfix = (luaObj.RawGet("SkillTeleport") as LuaFunction);
					this.m_AttackByBattleActorConfigDataSkillInfo_hotfix = (luaObj.RawGet("AttackBy") as LuaFunction);
					this.m_SkillAttackEndConfigDataSkillInfoList`1_hotfix = (luaObj.RawGet("SkillAttackEnd") as LuaFunction);
					this.m_CombatByBattleActor_hotfix = (luaObj.RawGet("CombatBy") as LuaFunction);
					this.m_TeleportByBattleActorConfigDataSkillInfoGridPosition_hotfix = (luaObj.RawGet("TeleportBy") as LuaFunction);
					this.m_SummonByBattleActorConfigDataSkillInfoGridPosition_hotfix = (luaObj.RawGet("SummonBy") as LuaFunction);
					this.m_GetHeroAttackSkillInfoMoveTypeInt32_hotfix = (luaObj.RawGet("GetHeroAttackSkillInfo") as LuaFunction);
					this.m_GetSoldierAttackSkillInfoMoveTypeInt32_hotfix = (luaObj.RawGet("GetSoldierAttackSkillInfo") as LuaFunction);
					this.m_GetHeroAttackSkillInfoBoolean_hotfix = (luaObj.RawGet("GetHeroAttackSkillInfo") as LuaFunction);
					this.m_GetSoldierAttackSkillInfoBoolean_hotfix = (luaObj.RawGet("GetSoldierAttackSkillInfo") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600332C RID: 13100 RVA: 0x000DD534 File Offset: 0x000DB734
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleActor));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002665 RID: 9829
		private BattleTeam m_team;

		// Token: 0x04002666 RID: 9830
		private GridPosition m_position;

		// Token: 0x04002667 RID: 9831
		private int m_direction;

		// Token: 0x04002668 RID: 9832
		private GridPosition m_initPosition;

		// Token: 0x04002669 RID: 9833
		private GridPosition m_beforeGuardPosition;

		// Token: 0x0400266A RID: 9834
		private BattleProperty m_heroBattleProperty;

		// Token: 0x0400266B RID: 9835
		private BattleProperty m_soldierBattleProperty;

		// Token: 0x0400266C RID: 9836
		private int m_heroHealthPoint;

		// Token: 0x0400266D RID: 9837
		private int m_soldierTotalHealthPoint;

		// Token: 0x0400266E RID: 9838
		private int m_soldierSingleHealthPointMax;

		// Token: 0x0400266F RID: 9839
		private int m_initSoldierCount;

		// Token: 0x04002670 RID: 9840
		private int m_heroLevel;

		// Token: 0x04002671 RID: 9841
		private int m_heroStar;

		// Token: 0x04002672 RID: 9842
		private int m_jobLevel;

		// Token: 0x04002673 RID: 9843
		private ConfigDataJobInfo[] m_masterJobInfos;

		// Token: 0x04002674 RID: 9844
		private BattleActorEquipment[] m_equipments;

		// Token: 0x04002675 RID: 9845
		private ConfigDataSkillInfo[] m_resonanceSkillInfos;

		// Token: 0x04002676 RID: 9846
		private ConfigDataSkillInfo[] m_fetterSkillInfos;

		// Token: 0x04002677 RID: 9847
		private int m_actionValue;

		// Token: 0x04002678 RID: 9848
		private MoveType m_moveType;

		// Token: 0x04002679 RID: 9849
		private bool m_isActionFinished;

		// Token: 0x0400267A RID: 9850
		private bool m_hasExtraAction;

		// Token: 0x0400267B RID: 9851
		private int m_hasExtraActionCount;

		// Token: 0x0400267C RID: 9852
		private int m_hasExtraMovePoint;

		// Token: 0x0400267D RID: 9853
		private bool m_isExtraAction;

		// Token: 0x0400267E RID: 9854
		private int m_extraActionMovePoint;

		// Token: 0x0400267F RID: 9855
		private bool m_isVisible;

		// Token: 0x04002680 RID: 9856
		private bool m_isDie;

		// Token: 0x04002681 RID: 9857
		private bool m_isRetreat;

		// Token: 0x04002682 RID: 9858
		private List<BattleSkillState> m_skillStates;

		// Token: 0x04002683 RID: 9859
		private List<BuffState> m_buffStates;

		// Token: 0x04002684 RID: 9860
		private int m_buffIdCounter;

		// Token: 0x04002685 RID: 9861
		private ulong m_buffTypes;

		// Token: 0x04002686 RID: 9862
		private uint m_fightTags;

		// Token: 0x04002687 RID: 9863
		private BattleActor m_summoner;

		// Token: 0x04002688 RID: 9864
		private BattleActor m_killerActor;

		// Token: 0x04002689 RID: 9865
		private bool m_isNpc;

		// Token: 0x0400268A RID: 9866
		private bool m_isPlayerNpc;

		// Token: 0x0400268B RID: 9867
		private BattleActorSourceType m_sourceType;

		// Token: 0x0400268C RID: 9868
		private ConfigDataHeroInfo m_heroInfo;

		// Token: 0x0400268D RID: 9869
		private ConfigDataJobConnectionInfo m_jobConnectionInfo;

		// Token: 0x0400268E RID: 9870
		private ConfigDataJobInfo m_jobInfo;

		// Token: 0x0400268F RID: 9871
		private ConfigDataArmyInfo m_heroArmyInfo;

		// Token: 0x04002690 RID: 9872
		private ConfigDataSoldierInfo m_soldierInfo;

		// Token: 0x04002691 RID: 9873
		private ConfigDataArmyInfo m_soldierArmyInfo;

		// Token: 0x04002692 RID: 9874
		private ConfigDataCharImageSkinResourceInfo m_heroCharImageSkinResourceInfo;

		// Token: 0x04002693 RID: 9875
		private ConfigDataModelSkinResourceInfo m_heroModelSkinResourceInfo;

		// Token: 0x04002694 RID: 9876
		private ConfigDataModelSkinResourceInfo m_soldierModelSkinResourceInfo;

		// Token: 0x04002695 RID: 9877
		private ConfigDataSkillInfo[] m_extraPassiveSkillInfos;

		// Token: 0x04002696 RID: 9878
		private ConfigDataSkillInfo m_extraTalentSkillInfo;

		// Token: 0x04002697 RID: 9879
		private bool m_isActionCriticalAttack;

		// Token: 0x04002698 RID: 9880
		private bool m_isActionKillActor;

		// Token: 0x04002699 RID: 9881
		private bool m_isActionDamageActor;

		// Token: 0x0400269A RID: 9882
		private bool m_isBeCriticalAttack;

		// Token: 0x0400269B RID: 9883
		private bool m_isBeKillAttack;

		// Token: 0x0400269C RID: 9884
		private int m_actionMoveGrids;

		// Token: 0x0400269D RID: 9885
		private int m_actionRemainMovePoint;

		// Token: 0x0400269E RID: 9886
		private int m_buffReplaceMovePoint;

		// Token: 0x0400269F RID: 9887
		private ConfigDataSkillInfo m_lastDamageBySkillInfo;

		// Token: 0x040026A0 RID: 9888
		private int m_firstDamageTurn;

		// Token: 0x040026A1 RID: 9889
		private ulong m_satisfyConditions;

		// Token: 0x040026A2 RID: 9890
		private short m_actionCount;

		// Token: 0x040026A3 RID: 9891
		private short m_combatAttackCount;

		// Token: 0x040026A4 RID: 9892
		private short m_beCombatAttackCount;

		// Token: 0x040026A5 RID: 9893
		private short m_useSkillCount;

		// Token: 0x040026A6 RID: 9894
		private short m_killActorCount;

		// Token: 0x040026A7 RID: 9895
		private int m_dieTurn;

		// Token: 0x040026A8 RID: 9896
		private int m_deathAnimType;

		// Token: 0x040026A9 RID: 9897
		private uint m_executedCommandTypes;

		// Token: 0x040026AA RID: 9898
		private ConfigDataSkillInfo m_executedSkillInfo;

		// Token: 0x040026AB RID: 9899
		private int m_playerIndex;

		// Token: 0x040026AC RID: 9900
		private ConfigDataBehavior m_curBehaviorCfg;

		// Token: 0x040026AD RID: 9901
		private BattleActor.BehaviorState m_curBehaviorState;

		// Token: 0x040026AE RID: 9902
		private BehaviorTarget m_moveTarget;

		// Token: 0x040026AF RID: 9903
		private BehaviorTarget m_attackTarget;

		// Token: 0x040026B0 RID: 9904
		private int m_attackSkillIndex = -1;

		// Token: 0x040026B1 RID: 9905
		private int[] m_beAttackedCountOfTurns;

		// Token: 0x040026B2 RID: 9906
		private int m_groupId;

		// Token: 0x040026B3 RID: 9907
		private int m_aiCreateBattleCommandCount;

		// Token: 0x040026B4 RID: 9908
		private const float m_healSkillTargetHPThresh = 0.7f;

		// Token: 0x040026B6 RID: 9910
		[DoNotToLua]
		private BattleActor.LuaExportHelper luaExportHelper;

		// Token: 0x040026BB RID: 9915
		[CompilerGenerated]
		private static BattleActor.ComputeActorScoreFunc <>f__mg$cache0;

		// Token: 0x040026C5 RID: 9925
		[CompilerGenerated]
		private static Comparison<BuffState> <>f__mg$cache1;

		// Token: 0x040026C6 RID: 9926
		[CompilerGenerated]
		private static Comparison<BattleActor> <>f__mg$cache2;

		// Token: 0x040026C7 RID: 9927
		[CompilerGenerated]
		private static Comparison<BattleActor> <>f__mg$cache3;

		// Token: 0x040026CC RID: 9932
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040026CD RID: 9933
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040026CE RID: 9934
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040026CF RID: 9935
		private LuaFunction m_Dispose_hotfix;

		// Token: 0x040026D0 RID: 9936
		private LuaFunction m_InitializeBattleTeamConfigDataHeroInfoConfigDataJobConnectionInfoConfigDataSoldierInfoConfigDataSkillInfobeConfigDataJobInfobeBattleActorEquipmentbeConfigDataSkillInfobeConfigDataSkillInfobeInt32Int32Int32Int32GridPositionInt32BooleanInt32Int32Int32BattleActorSourceTypeInt32_hotfix;

		// Token: 0x040026D1 RID: 9937
		private LuaFunction m_InitializeSkinConfigDataCharImageSkinResourceInfoConfigDataModelSkinResourceInfoConfigDataModelSkinResourceInfo_hotfix;

		// Token: 0x040026D2 RID: 9938
		private LuaFunction m_InitializeExtraPassiveSkillAndTalentList;

		// Token: 0x040026D3 RID: 9939
		private LuaFunction m_InitializeEndBooleanInt32Int32_hotfix;

		// Token: 0x040026D4 RID: 9940
		private LuaFunction m_UpdateBattleProperties_hotfix;

		// Token: 0x040026D5 RID: 9941
		private LuaFunction m_UpdateBattlePropertiesInCombatBattleActorBooleanInt32_hotfix;

		// Token: 0x040026D6 RID: 9942
		private LuaFunction m_ComputeBattlePropertiesBattlePropertyModifier_hotfix;

		// Token: 0x040026D7 RID: 9943
		private LuaFunction m_CollectJobMasterPropertyModifiersBattlePropertyModifier_hotfix;

		// Token: 0x040026D8 RID: 9944
		private LuaFunction m_CollectEquipmentPropertyModifiersBattlePropertyModifier_hotfix;

		// Token: 0x040026D9 RID: 9945
		private LuaFunction m_SetPositionGridPosition_hotfix;

		// Token: 0x040026DA RID: 9946
		private LuaFunction m_SetDirectionInt32_hotfix;

		// Token: 0x040026DB RID: 9947
		private LuaFunction m_FaceToGridPosition_hotfix;

		// Token: 0x040026DC RID: 9948
		private LuaFunction m_GuardMoveGridPosition_hotfix;

		// Token: 0x040026DD RID: 9949
		private LuaFunction m_UnguardMove_hotfix;

		// Token: 0x040026DE RID: 9950
		private LuaFunction m_MoveToGridPosition_hotfix;

		// Token: 0x040026DF RID: 9951
		private LuaFunction m_ClearMapActor_hotfix;

		// Token: 0x040026E0 RID: 9952
		private LuaFunction m_GetTerrain_hotfix;

		// Token: 0x040026E1 RID: 9953
		private LuaFunction m_GetBuffEffectedTerrain_hotfix;

		// Token: 0x040026E2 RID: 9954
		private LuaFunction m_ChangeTeamInt32Boolean_hotfix;

		// Token: 0x040026E3 RID: 9955
		private LuaFunction m_CreateBattleCommandBattleCommandType_hotfix;

		// Token: 0x040026E4 RID: 9956
		private LuaFunction m_StartBattle_hotfix;

		// Token: 0x040026E5 RID: 9957
		private LuaFunction m_StopBattleBoolean_hotfix;

		// Token: 0x040026E6 RID: 9958
		private LuaFunction m_NextTurn_hotfix;

		// Token: 0x040026E7 RID: 9959
		private LuaFunction m_ActionBegin_hotfix;

		// Token: 0x040026E8 RID: 9960
		private LuaFunction m_ActionEnd_hotfix;

		// Token: 0x040026E9 RID: 9961
		private LuaFunction m_IsActionFinished_hotfix;

		// Token: 0x040026EA RID: 9962
		private LuaFunction m_CanAction_hotfix;

		// Token: 0x040026EB RID: 9963
		private LuaFunction m_PostActionTerrainDamage_hotfix;

		// Token: 0x040026EC RID: 9964
		private LuaFunction m_FindPathGridPositionGridPositionInt32Int32List;

		// Token: 0x040026ED RID: 9965
		private LuaFunction m_FindMoveRegionGridPositionList;

		// Token: 0x040026EE RID: 9966
		private LuaFunction m_ShouldLog_hotfix;

		// Token: 0x040026EF RID: 9967
		private LuaFunction m_AddExecutedCommandTypeBattleCommandType_hotfix;

		// Token: 0x040026F0 RID: 9968
		private LuaFunction m_HasExecutedCommandTypeBattleCommandType_hotfix;

		// Token: 0x040026F1 RID: 9969
		private LuaFunction m_IsExecutedCommandTypeBattleCommandType_hotfix;

		// Token: 0x040026F2 RID: 9970
		private LuaFunction m_ExecuteMoveCommandGridPosition_hotfix;

		// Token: 0x040026F3 RID: 9971
		private LuaFunction m_ExecutePerformMoveCommandGridPositionBoolean_hotfix;

		// Token: 0x040026F4 RID: 9972
		private LuaFunction m_ExecuteCombatCommandBattleActorConfigDataSkillInfoBoolean_hotfix;

		// Token: 0x040026F5 RID: 9973
		private LuaFunction m_ExecuteSkillCommandInt32GridPositionGridPosition_hotfix;

		// Token: 0x040026F6 RID: 9974
		private LuaFunction m_ExecutePerformSkillCommandConfigDataSkillInfoGridPositionGridPosition_hotfix;

		// Token: 0x040026F7 RID: 9975
		private LuaFunction m_ExecuteDoneCommand_hotfix;

		// Token: 0x040026F8 RID: 9976
		private LuaFunction m_IsDead_hotfix;

		// Token: 0x040026F9 RID: 9977
		private LuaFunction m_IsRetreat_hotfix;

		// Token: 0x040026FA RID: 9978
		private LuaFunction m_IsDeadOrRetreat_hotfix;

		// Token: 0x040026FB RID: 9979
		private LuaFunction m_SetVisibleBoolean_hotfix;

		// Token: 0x040026FC RID: 9980
		private LuaFunction m_IsVisible_hotfix;

		// Token: 0x040026FD RID: 9981
		private LuaFunction m_IsInvincible_hotfix;

		// Token: 0x040026FE RID: 9982
		private LuaFunction m_IsSummoned_hotfix;

		// Token: 0x040026FF RID: 9983
		private LuaFunction m_IsNpc_hotfix;

		// Token: 0x04002700 RID: 9984
		private LuaFunction m_IsAINpc_hotfix;

		// Token: 0x04002701 RID: 9985
		private LuaFunction m_IsPlayerNpc_hotfix;

		// Token: 0x04002702 RID: 9986
		private LuaFunction m_IsPlayerActor_hotfix;

		// Token: 0x04002703 RID: 9987
		private LuaFunction m_IsAIActor_hotfix;

		// Token: 0x04002704 RID: 9988
		private LuaFunction m_CanBeTarget_hotfix;

		// Token: 0x04002705 RID: 9989
		private LuaFunction m_SetHeroHealthPointInt32_hotfix;

		// Token: 0x04002706 RID: 9990
		private LuaFunction m_SetSoldierTotalHealthPointInt32_hotfix;

		// Token: 0x04002707 RID: 9991
		private LuaFunction m_CheckDieBattleActor_hotfix;

		// Token: 0x04002708 RID: 9992
		private LuaFunction m_RetreatInt32StringBoolean_hotfix;

		// Token: 0x04002709 RID: 9993
		private LuaFunction m_GetSoldierAttackDistance_hotfix;

		// Token: 0x0400270A RID: 9994
		private LuaFunction m_GetMaxAttackDistance_hotfix;

		// Token: 0x0400270B RID: 9995
		private LuaFunction m_GetTalentSkillInfo_hotfix;

		// Token: 0x0400270C RID: 9996
		private LuaFunction m_GetSkillDistanceConfigDataSkillInfo_hotfix;

		// Token: 0x0400270D RID: 9997
		private LuaFunction m_GetMovePoint_hotfix;

		// Token: 0x0400270E RID: 9998
		private LuaFunction m_GetMoveType_hotfix;

		// Token: 0x0400270F RID: 9999
		private LuaFunction m_GetTotalHealthPoint_hotfix;

		// Token: 0x04002710 RID: 10000
		private LuaFunction m_GetTotalHealthPointMax_hotfix;

		// Token: 0x04002711 RID: 10001
		private LuaFunction m_GetSoldierCount_hotfix;

		// Token: 0x04002712 RID: 10002
		private LuaFunction m_SetLastDamageBySkillConfigDataSkillInfo_hotfix;

		// Token: 0x04002713 RID: 10003
		private LuaFunction m_GetLastDamageBySkill_hotfix;

		// Token: 0x04002714 RID: 10004
		private LuaFunction m_SetFirstDamageTurnInt32_hotfix;

		// Token: 0x04002715 RID: 10005
		private LuaFunction m_GetFirstDamageTurn_hotfix;

		// Token: 0x04002716 RID: 10006
		private LuaFunction m_SetSetisfyConditionInt32_hotfix;

		// Token: 0x04002717 RID: 10007
		private LuaFunction m_IsSatisfyConditionInt32_hotfix;

		// Token: 0x04002718 RID: 10008
		private LuaFunction m_GetDeathAnimType_hotfix;

		// Token: 0x04002719 RID: 10009
		private LuaFunction m_SetBeCriticalAttackBoolean_hotfix;

		// Token: 0x0400271A RID: 10010
		private LuaFunction m_SetBeKillAttackBoolean_hotfix;

		// Token: 0x0400271B RID: 10011
		private LuaFunction m_SetActionCriticalAttack_hotfix;

		// Token: 0x0400271C RID: 10012
		private LuaFunction m_SetActionKillActor_hotfix;

		// Token: 0x0400271D RID: 10013
		private LuaFunction m_SetActionDamageActor_hotfix;

		// Token: 0x0400271E RID: 10014
		private LuaFunction m_IsExtraAction_hotfix;

		// Token: 0x0400271F RID: 10015
		private LuaFunction m_IsExtraActionMoving_hotfix;

		// Token: 0x04002720 RID: 10016
		private LuaFunction m_GetActionCount_hotfix;

		// Token: 0x04002721 RID: 10017
		private LuaFunction m_IncreaseCombatAttackCount_hotfix;

		// Token: 0x04002722 RID: 10018
		private LuaFunction m_GetCombatAttackCount_hotfix;

		// Token: 0x04002723 RID: 10019
		private LuaFunction m_IncreaseBeCombatAttackCount_hotfix;

		// Token: 0x04002724 RID: 10020
		private LuaFunction m_GetBeCombatAttackCount_hotfix;

		// Token: 0x04002725 RID: 10021
		private LuaFunction m_IncreaseUseSkillCount_hotfix;

		// Token: 0x04002726 RID: 10022
		private LuaFunction m_GetUseSkillCount_hotfix;

		// Token: 0x04002727 RID: 10023
		private LuaFunction m_IncreaseKillActorCount_hotfix;

		// Token: 0x04002728 RID: 10024
		private LuaFunction m_GetKillActorCount_hotfix;

		// Token: 0x04002729 RID: 10025
		private LuaFunction m_GetKillerActor_hotfix;

		// Token: 0x0400272A RID: 10026
		private LuaFunction m_GetDieTurn_hotfix;

		// Token: 0x0400272B RID: 10027
		private LuaFunction m_GetSourceType_hotfix;

		// Token: 0x0400272C RID: 10028
		private LuaFunction m_get_Position_hotfix;

		// Token: 0x0400272D RID: 10029
		private LuaFunction m_get_InitPosition_hotfix;

		// Token: 0x0400272E RID: 10030
		private LuaFunction m_get_Direction_hotfix;

		// Token: 0x0400272F RID: 10031
		private LuaFunction m_get_Battle_hotfix;

		// Token: 0x04002730 RID: 10032
		private LuaFunction m_get_Team_hotfix;

		// Token: 0x04002731 RID: 10033
		private LuaFunction m_get_TeamNumber_hotfix;

		// Token: 0x04002732 RID: 10034
		private LuaFunction m_get_HeroBattleProperty_hotfix;

		// Token: 0x04002733 RID: 10035
		private LuaFunction m_get_SoldierBattleProperty_hotfix;

		// Token: 0x04002734 RID: 10036
		private LuaFunction m_get_HeroHealthPoint_hotfix;

		// Token: 0x04002735 RID: 10037
		private LuaFunction m_get_SoldierTotalHealthPoint_hotfix;

		// Token: 0x04002736 RID: 10038
		private LuaFunction m_get_SoldierSingleHealthPointMax_hotfix;

		// Token: 0x04002737 RID: 10039
		private LuaFunction m_get_FightTags_hotfix;

		// Token: 0x04002738 RID: 10040
		private LuaFunction m_get_HeroLevel_hotfix;

		// Token: 0x04002739 RID: 10041
		private LuaFunction m_get_HeroStar_hotfix;

		// Token: 0x0400273A RID: 10042
		private LuaFunction m_get_JobLevel_hotfix;

		// Token: 0x0400273B RID: 10043
		private LuaFunction m_get_ActionValue_hotfix;

		// Token: 0x0400273C RID: 10044
		private LuaFunction m_set_ActionValueInt32_hotfix;

		// Token: 0x0400273D RID: 10045
		private LuaFunction m_get_HeroInfo_hotfix;

		// Token: 0x0400273E RID: 10046
		private LuaFunction m_get_HeroId_hotfix;

		// Token: 0x0400273F RID: 10047
		private LuaFunction m_get_HeroArmyInfo_hotfix;

		// Token: 0x04002740 RID: 10048
		private LuaFunction m_get_HeroArmyId_hotfix;

		// Token: 0x04002741 RID: 10049
		private LuaFunction m_get_JobConnectionInfo_hotfix;

		// Token: 0x04002742 RID: 10050
		private LuaFunction m_get_JobInfo_hotfix;

		// Token: 0x04002743 RID: 10051
		private LuaFunction m_get_SoldierInfo_hotfix;

		// Token: 0x04002744 RID: 10052
		private LuaFunction m_get_SoldierArmyInfo_hotfix;

		// Token: 0x04002745 RID: 10053
		private LuaFunction m_get_HeroCharImageSkinResourceInfo_hotfix;

		// Token: 0x04002746 RID: 10054
		private LuaFunction m_get_HeroModelSkinResourceInfo_hotfix;

		// Token: 0x04002747 RID: 10055
		private LuaFunction m_get_SoldierModelSkinResourceInfo_hotfix;

		// Token: 0x04002748 RID: 10056
		private LuaFunction m_get_PlayerIndex_hotfix;

		// Token: 0x04002749 RID: 10057
		private LuaFunction m_FindMoveAndAttackRegionInt32Int32_hotfix;

		// Token: 0x0400274A RID: 10058
		private LuaFunction m_FindRandomEmptyPositionInt32Int32GridPosition__hotfix;

		// Token: 0x0400274B RID: 10059
		private LuaFunction m_FindAttackPositionInt32Int32GridPositionBooleanBoolean_hotfix;

		// Token: 0x0400274C RID: 10060
		private LuaFunction m_ComputeActorScoreBuffBattleActorInt32_hotfix;

		// Token: 0x0400274D RID: 10061
		private LuaFunction m_SelectNearestTargetBattleTeam_hotfix;

		// Token: 0x0400274E RID: 10062
		private LuaFunction m_GetAIRandomNumber_hotfix;

		// Token: 0x0400274F RID: 10063
		private LuaFunction m_GetSkillTargetTeamConfigDataSkillInfo_hotfix;

		// Token: 0x04002750 RID: 10064
		private LuaFunction m_CanAttackOrUseSkill_hotfix;

		// Token: 0x04002751 RID: 10065
		private LuaFunction m_get_Group_hotfix;

		// Token: 0x04002752 RID: 10066
		private LuaFunction m_set_GroupBehaviorGroup_hotfix;

		// Token: 0x04002753 RID: 10067
		private LuaFunction m_get_GroupId_hotfix;

		// Token: 0x04002754 RID: 10068
		private LuaFunction m_IncreaseBeAttackedCount_hotfix;

		// Token: 0x04002755 RID: 10069
		private LuaFunction m_get_IsAttackedByEnemy_hotfix;

		// Token: 0x04002756 RID: 10070
		private LuaFunction m_get_IsAttackedByEnemyInLastTrun_hotfix;

		// Token: 0x04002757 RID: 10071
		private LuaFunction m_get_InstanceID_hotfix;

		// Token: 0x04002758 RID: 10072
		private LuaFunction m_GetBehaviorId_hotfix;

		// Token: 0x04002759 RID: 10073
		private LuaFunction m_SetBehaviorInt32_hotfix;

		// Token: 0x0400275A RID: 10074
		private LuaFunction m_SetBehaviorStateBehaviorState_hotfix;

		// Token: 0x0400275B RID: 10075
		private LuaFunction m_CheckBehaviorConditionBehaviorConditionParamData_hotfix;

		// Token: 0x0400275C RID: 10076
		private LuaFunction m_DoBehaviorChangeRules_hotfix;

		// Token: 0x0400275D RID: 10077
		private LuaFunction m_get_NextBehaviorByChangeRules_hotfix;

		// Token: 0x0400275E RID: 10078
		private LuaFunction m_FindEmptyGridInCanAttackAndTouchRangeGridPositionInt32Int32_hotfix;

		// Token: 0x0400275F RID: 10079
		private LuaFunction m_FindActorsInCanAttackAndTouchRangeList;

		// Token: 0x04002760 RID: 10080
		private LuaFunction m_FindFarthestPositionList;

		// Token: 0x04002761 RID: 10081
		private LuaFunction m_FindNearestPositionList;

		// Token: 0x04002762 RID: 10082
		private LuaFunction m_FindNearestActorList;

		// Token: 0x04002763 RID: 10083
		private LuaFunction m_DoSelectTargetSelectTargetParamData_hotfix;

		// Token: 0x04002764 RID: 10084
		private LuaFunction m_FindActorsByIDFilterList;

		// Token: 0x04002765 RID: 10085
		private LuaFunction m_SelectMoveTarget_hotfix;

		// Token: 0x04002766 RID: 10086
		private LuaFunction m_FindPathGridPositionGridPositionInt32Int32Int32List;

		// Token: 0x04002767 RID: 10087
		private LuaFunction m_GenerateCommandOfMoveGridPosition_hotfix;

		// Token: 0x04002768 RID: 10088
		private LuaFunction m_FindPositionToMoveToTargetGridPosition_hotfix;

		// Token: 0x04002769 RID: 10089
		private LuaFunction m_ComputeRestrictScoreBattleActorBattleActor_hotfix;

		// Token: 0x0400276A RID: 10090
		private LuaFunction m_GetArmyRistrictScoreArmyTagArmyTag_hotfix;

		// Token: 0x0400276B RID: 10091
		private LuaFunction m_get_TotalHPPercent_hotfix;

		// Token: 0x0400276C RID: 10092
		private LuaFunction m_DefaultSelectDamageSkillTargetList;

		// Token: 0x0400276D RID: 10093
		private LuaFunction m_IsSelectRangeSkill_hotfix;

		// Token: 0x0400276E RID: 10094
		private LuaFunction m_get_BehaviorSelectSkillInfo_hotfix;

		// Token: 0x0400276F RID: 10095
		private LuaFunction m_FindActorsInGridsList`1List;

		// Token: 0x04002770 RID: 10096
		private LuaFunction m_FindMaxAoeSkillCoverPositionConfigDataSkillInfoList`1List`1ClassValue;

		// Token: 0x04002771 RID: 10097
		private LuaFunction m_FindMaxAoeSkillCoverActorConfigDataSkillInfoList`1List`1ClassValue;

		// Token: 0x04002772 RID: 10098
		private LuaFunction m_DefaultSelectAttackTarget_hotfix;

		// Token: 0x04002773 RID: 10099
		private LuaFunction m_FindGridsLessEqualDistanceGridPositionInt32_hotfix;

		// Token: 0x04002774 RID: 10100
		private LuaFunction m_FindActorsLessEqualDistanceList;

		// Token: 0x04002775 RID: 10101
		private LuaFunction m_DefaultSelectHealSkillTargetList;

		// Token: 0x04002776 RID: 10102
		private LuaFunction m_DefaultSelectBuffSkillTargetList;

		// Token: 0x04002777 RID: 10103
		private LuaFunction m_SelectAttackTargetInSkillRange_hotfix;

		// Token: 0x04002778 RID: 10104
		private LuaFunction m_FindActorsWithBuffNList;

		// Token: 0x04002779 RID: 10105
		private LuaFunction m_SelectAttackTarget_hotfix;

		// Token: 0x0400277A RID: 10106
		private LuaFunction m_SelectSkill_hotfix;

		// Token: 0x0400277B RID: 10107
		private LuaFunction m_SelectSkillDirectReachTarget_hotfix;

		// Token: 0x0400277C RID: 10108
		private LuaFunction m_DefaultSelectSkillInt32beInt32be_hotfix;

		// Token: 0x0400277D RID: 10109
		private LuaFunction m_FindActorsInCanNormalAttackAndTouchRangeList`1List;

		// Token: 0x0400277E RID: 10110
		private LuaFunction m_IsSkillAGoodAISelectionConfigDataSkillInfo_hotfix;

		// Token: 0x0400277F RID: 10111
		private LuaFunction m_FindCastSkillPositionConfigDataSkillInfoBehaviorTarget_hotfix;

		// Token: 0x04002780 RID: 10112
		private LuaFunction m_FindAttackPositionsInt32Int32GridPositionList;

		// Token: 0x04002781 RID: 10113
		private LuaFunction m_GenerateCommandOfAttack_hotfix;

		// Token: 0x04002782 RID: 10114
		private LuaFunction m_DoBehaviorMove_hotfix;

		// Token: 0x04002783 RID: 10115
		private LuaFunction m_IsAttackTargetStillValid_hotfix;

		// Token: 0x04002784 RID: 10116
		private LuaFunction m_DoBehaviorAttack_hotfix;

		// Token: 0x04002785 RID: 10117
		private LuaFunction m_GenerateAIBattleCommand_hotfix;

		// Token: 0x04002786 RID: 10118
		private LuaFunction m_AICreateBattleCommandBattleCommandType_hotfix;

		// Token: 0x04002787 RID: 10119
		private LuaFunction m_SelectAttackRegionTargetBattleTeamComputeActorScoreFuncInt32_hotfix;

		// Token: 0x04002788 RID: 10120
		private LuaFunction m_GetBuffStates_hotfix;

		// Token: 0x04002789 RID: 10121
		private LuaFunction m_InitializeBuffs_hotfix;

		// Token: 0x0400278A RID: 10122
		private LuaFunction m_AttachPassiveSkillBuffsConfigDataSkillInfoBuffSourceType_hotfix;

		// Token: 0x0400278B RID: 10123
		private LuaFunction m_AttachBuffConfigDataBuffInfoBattleActorBuffSourceTypeConfigDataSkillInfoBuffState_hotfix;

		// Token: 0x0400278C RID: 10124
		private LuaFunction m_RemoveBuffBuffState_hotfix;

		// Token: 0x0400278D RID: 10125
		private LuaFunction m_RemoveBuffListList;

		// Token: 0x0400278E RID: 10126
		private LuaFunction m_RemoveBuffListList;

		// Token: 0x0400278F RID: 10127
		private LuaFunction m_FindBuffInt32BattleActor_hotfix;

		// Token: 0x04002790 RID: 10128
		private LuaFunction m_RemoveAllBuffs_hotfix;

		// Token: 0x04002791 RID: 10129
		private LuaFunction m_SkillDispelBuffConfigDataSkillInfo_hotfix;

		// Token: 0x04002792 RID: 10130
		private LuaFunction m_HasBuffInt32_hotfix;

		// Token: 0x04002793 RID: 10131
		private LuaFunction m_CollectBuffPropertyModifiersAndFightTagsBattlePropertyModifierUInt32__hotfix;

		// Token: 0x04002794 RID: 10132
		private LuaFunction m_CollectBuffPropertyModifiersAndFightTagsBattlePropertyModifierUInt32_BooleanBoolean_hotfix;

		// Token: 0x04002795 RID: 10133
		private LuaFunction m_CollectPropertyModifierBattlePropertyModifierPropertyModifyTypeInt32BooleanBoolean_hotfix;

		// Token: 0x04002796 RID: 10134
		private LuaFunction m_CollectOtherActorBuffPropertyModifiersAndFightTagsBattlePropertyModifierUInt32__hotfix;

		// Token: 0x04002797 RID: 10135
		private LuaFunction m_CollectBuffPropertyModifiersAndFightTagsInCombatBattlePropertyModifierUInt32_BattleActorBooleanInt32_hotfix;

		// Token: 0x04002798 RID: 10136
		private LuaFunction m_CollectBuffPropertyExchangeBattlePropertyBattlePropertyModifier_hotfix;

		// Token: 0x04002799 RID: 10137
		private LuaFunction m_CollectBuffPropertyReplace_hotfix;

		// Token: 0x0400279A RID: 10138
		private LuaFunction m_UpdateAllAuras_hotfix;

		// Token: 0x0400279B RID: 10139
		private LuaFunction m_RemoveAuraAppliedBuffsConfigDataBuffInfo_hotfix;

		// Token: 0x0400279C RID: 10140
		private LuaFunction m_RemovePackChildBuffsBuffState_hotfix;

		// Token: 0x0400279D RID: 10141
		private LuaFunction m_OnBuffHitBuffStateInt32Int32DamageNumberType_hotfix;

		// Token: 0x0400279E RID: 10142
		private LuaFunction m_HasFightTagFightTag_hotfix;

		// Token: 0x0400279F RID: 10143
		private LuaFunction m_UpdateBuffTypes_hotfix;

		// Token: 0x040027A0 RID: 10144
		private LuaFunction m_SetBuffTypeBuffTypeBoolean_hotfix;

		// Token: 0x040027A1 RID: 10145
		private LuaFunction m_HasBuffTypeBuffType_hotfix;

		// Token: 0x040027A2 RID: 10146
		private LuaFunction m_IsBuffEffectiveBuffState_hotfix;

		// Token: 0x040027A3 RID: 10147
		private LuaFunction m_IsBuffHpConditionSatisfiedConfigDataBuffInfo_hotfix;

		// Token: 0x040027A4 RID: 10148
		private LuaFunction m_IsBuffHpConditionSatisfiedInt32Int32Int32_hotfix;

		// Token: 0x040027A5 RID: 10149
		private LuaFunction m_IsBuffEffectiveConditionSatisfiedConfigDataBuffInfo_hotfix;

		// Token: 0x040027A6 RID: 10150
		private LuaFunction m_IsBuffCombatConditionSatisfiedBattleActorBooleanInt32Int32Int32Int32_hotfix;

		// Token: 0x040027A7 RID: 10151
		private LuaFunction m_IsBuffCombatConditionSatisfiedBattleActorBooleanBooleanInt32BooleanList;

		// Token: 0x040027A8 RID: 10152
		private LuaFunction m_ComputeNeighborAliveActorCountInt32Int32_hotfix;

		// Token: 0x040027A9 RID: 10153
		private LuaFunction m_IsBuffCooldownBuffState_hotfix;

		// Token: 0x040027AA RID: 10154
		private LuaFunction m_StartBuffCooldownBuffState_hotfix;

		// Token: 0x040027AB RID: 10155
		private LuaFunction m_ComputeBuffCountInt32_hotfix;

		// Token: 0x040027AC RID: 10156
		private LuaFunction m_ComputeEnhanceOrDebuffCountInt32_hotfix;

		// Token: 0x040027AD RID: 10157
		private LuaFunction m_IsImmuneBuffSubTypeInt32_hotfix;

		// Token: 0x040027AE RID: 10158
		private LuaFunction m_ComputeBuffReboundDamageConfigDataSkillInfoInt32_hotfix;

		// Token: 0x040027AF RID: 10159
		private LuaFunction m_GetBuffOverrideMovePointCost_hotfix;

		// Token: 0x040027B0 RID: 10160
		private LuaFunction m_GetBuffOverrideTerrain_hotfix;

		// Token: 0x040027B1 RID: 10161
		private LuaFunction m_AddBuffArmyRelationAttackInt32BooleanArmyRelationData__hotfix;

		// Token: 0x040027B2 RID: 10162
		private LuaFunction m_AddBuffArmyRelationDefendInt32BooleanArmyRelationData__hotfix;

		// Token: 0x040027B3 RID: 10163
		private LuaFunction m_AddBuffArmyRelationModifyAttackInt32BooleanArmyRelationData__hotfix;

		// Token: 0x040027B4 RID: 10164
		private LuaFunction m_AddBuffArmyRelationModifyDefendInt32BooleanArmyRelationData__hotfix;

		// Token: 0x040027B5 RID: 10165
		private LuaFunction m_IsBuffForceMagicDamageBoolean_hotfix;

		// Token: 0x040027B6 RID: 10166
		private LuaFunction m_ActionEndBuffEffect_hotfix;

		// Token: 0x040027B7 RID: 10167
		private LuaFunction m_UpdateBuffTime_hotfix;

		// Token: 0x040027B8 RID: 10168
		private LuaFunction m_ActionEndBuffDoubleMoveBooleanBoolean_hotfix;

		// Token: 0x040027B9 RID: 10169
		private LuaFunction m_ActionEndBuffHealOverTimeBoolean_hotfix;

		// Token: 0x040027BA RID: 10170
		private LuaFunction m_ActionEndBuffDamageOverTime_hotfix;

		// Token: 0x040027BB RID: 10171
		private LuaFunction m_ActionEndAddBuff_hotfix;

		// Token: 0x040027BC RID: 10172
		private LuaFunction m_ActionEndAddBuffSuperBooleanBoolean_hotfix;

		// Token: 0x040027BD RID: 10173
		private LuaFunction m_ActionEndRemoveDebuff_hotfix;

		// Token: 0x040027BE RID: 10174
		private LuaFunction m_ActionEndRemoveEnhanceBuffBooleanBooleanBoolean_hotfix;

		// Token: 0x040027BF RID: 10175
		private LuaFunction m_ActionEndBuffBattlefieldSkillBooleanBooleanBoolean_hotfix;

		// Token: 0x040027C0 RID: 10176
		private LuaFunction m_ActionEndBuffNewTurnBooleanBoolean_hotfix;

		// Token: 0x040027C1 RID: 10177
		private LuaFunction m_CombatBuffHealBattleActorBooleanBooleanInt32BooleanInt32Int32_hotfix;

		// Token: 0x040027C2 RID: 10178
		private LuaFunction m_CombatBuffHealOtherBattleActorBooleanBooleanInt32BooleanInt32Int32_hotfix;

		// Token: 0x040027C3 RID: 10179
		private LuaFunction m_CombatBuffDamageBattleActorBooleanBooleanInt32Boolean_hotfix;

		// Token: 0x040027C4 RID: 10180
		private LuaFunction m_CombatApplyBuffBattleActorBooleanBooleanInt32Boolean_hotfix;

		// Token: 0x040027C5 RID: 10181
		private LuaFunction m_AttackApplyBuffList;

		// Token: 0x040027C6 RID: 10182
		private LuaFunction m_AttackBuffDamageList;

		// Token: 0x040027C7 RID: 10183
		private LuaFunction m_AttackRemoveBuffList;

		// Token: 0x040027C8 RID: 10184
		private LuaFunction m_AttackRemoveSkillCooldownConfigDataSkillInfoBooleanBoolean_hotfix;

		// Token: 0x040027C9 RID: 10185
		private LuaFunction m_BattleFieldSkillApplyBuffList;

		// Token: 0x040027CA RID: 10186
		private LuaFunction m_AttackBuffPunchBattleActor_hotfix;

		// Token: 0x040027CB RID: 10187
		private LuaFunction m_AttackBuffDragBattleActor_hotfix;

		// Token: 0x040027CC RID: 10188
		private LuaFunction m_AttackBuffExchangePositionBattleActorBoolean_hotfix;

		// Token: 0x040027CD RID: 10189
		private LuaFunction m_CombatArmyChangeBattleActor_hotfix;

		// Token: 0x040027CE RID: 10190
		private LuaFunction m_BuffDoubleAttack_hotfix;

		// Token: 0x040027CF RID: 10191
		private LuaFunction m_BuffUndead_hotfix;

		// Token: 0x040027D0 RID: 10192
		private LuaFunction m_CanBuffGuardBattleActorConfigDataSkillInfo_hotfix;

		// Token: 0x040027D1 RID: 10193
		private LuaFunction m_GetGuardActorConfigDataSkillInfo_hotfix;

		// Token: 0x040027D2 RID: 10194
		private LuaFunction m_AfterCombatDetachBuff_hotfix;

		// Token: 0x040027D3 RID: 10195
		private LuaFunction m_GetSkillStateInt32_hotfix;

		// Token: 0x040027D4 RID: 10196
		private LuaFunction m_GetSkillStateByIdInt32_hotfix;

		// Token: 0x040027D5 RID: 10197
		private LuaFunction m_GetSkillStates_hotfix;

		// Token: 0x040027D6 RID: 10198
		private LuaFunction m_IsSkillUseableInt32_hotfix;

		// Token: 0x040027D7 RID: 10199
		private LuaFunction m_CanUseSkillOnTargetConfigDataSkillInfoBattleActor_hotfix;

		// Token: 0x040027D8 RID: 10200
		private LuaFunction m_IsBattlefiledSkillApplyTargetConfigDataSkillInfoBattleActor_hotfix;

		// Token: 0x040027D9 RID: 10201
		private LuaFunction m_FindBattlefieldSkillApplyTargetsConfigDataSkillInfoGridPositionList;

		// Token: 0x040027DA RID: 10202
		private LuaFunction m_ExecuteBattlefieldSkillConfigDataSkillInfoGridPositionGridPosition_hotfix;

		// Token: 0x040027DB RID: 10203
		private LuaFunction m_SkillAttackConfigDataSkillInfoBattleActor_hotfix;

		// Token: 0x040027DC RID: 10204
		private LuaFunction m_SkillSummonConfigDataSkillInfoGridPosition_hotfix;

		// Token: 0x040027DD RID: 10205
		private LuaFunction m_SkillTeleportConfigDataSkillInfoBattleActorGridPosition_hotfix;

		// Token: 0x040027DE RID: 10206
		private LuaFunction m_AttackByBattleActorConfigDataSkillInfo_hotfix;

		// Token: 0x040027DF RID: 10207
		private LuaFunction m_SkillAttackEndConfigDataSkillInfoList;

		// Token: 0x040027E0 RID: 10208
		private LuaFunction m_CombatByBattleActor_hotfix;

		// Token: 0x040027E1 RID: 10209
		private LuaFunction m_TeleportByBattleActorConfigDataSkillInfoGridPosition_hotfix;

		// Token: 0x040027E2 RID: 10210
		private LuaFunction m_SummonByBattleActorConfigDataSkillInfoGridPosition_hotfix;

		// Token: 0x040027E3 RID: 10211
		private LuaFunction m_GetHeroAttackSkillInfoMoveTypeInt32_hotfix;

		// Token: 0x040027E4 RID: 10212
		private LuaFunction m_GetSoldierAttackSkillInfoMoveTypeInt32_hotfix;

		// Token: 0x040027E5 RID: 10213
		private LuaFunction m_GetHeroAttackSkillInfoBoolean_hotfix;

		// Token: 0x040027E6 RID: 10214
		private LuaFunction m_GetSoldierAttackSkillInfoBoolean_hotfix;

		// Token: 0x0200036E RID: 878
		// (Invoke) Token: 0x0600332E RID: 13102
		public delegate int ComputeActorScoreFunc(BattleActor a, int param);

		// Token: 0x0200036F RID: 879
		public enum BehaviorState
		{
			// Token: 0x040027E8 RID: 10216
			Move,
			// Token: 0x040027E9 RID: 10217
			Attack
		}

		// Token: 0x02000370 RID: 880
		public new class LuaExportHelper
		{
			// Token: 0x06003331 RID: 13105 RVA: 0x000DD59C File Offset: 0x000DB79C
			public LuaExportHelper(BattleActor owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06003332 RID: 13106 RVA: 0x000DD5AC File Offset: 0x000DB7AC
			public void __callBase_Dispose()
			{
				this.m_owner.__callBase_Dispose();
			}

			// Token: 0x06003333 RID: 13107 RVA: 0x000DD5BC File Offset: 0x000DB7BC
			public void __callBase_Tick()
			{
				this.m_owner.__callBase_Tick();
			}

			// Token: 0x06003334 RID: 13108 RVA: 0x000DD5CC File Offset: 0x000DB7CC
			public void __callBase_TickGraphic(float dt)
			{
				this.m_owner.__callBase_TickGraphic(dt);
			}

			// Token: 0x06003335 RID: 13109 RVA: 0x000DD5DC File Offset: 0x000DB7DC
			public void __callBase_Draw()
			{
				this.m_owner.__callBase_Draw();
			}

			// Token: 0x06003336 RID: 13110 RVA: 0x000DD5EC File Offset: 0x000DB7EC
			public void __callBase_Pause(bool pause)
			{
				this.m_owner.__callBase_Pause(pause);
			}

			// Token: 0x06003337 RID: 13111 RVA: 0x000DD5FC File Offset: 0x000DB7FC
			public void __callBase_DoPause(bool pause)
			{
				this.m_owner.__callBase_DoPause(pause);
			}

			// Token: 0x06003338 RID: 13112 RVA: 0x000DD60C File Offset: 0x000DB80C
			public void __callBase_DeleteMe()
			{
				this.m_owner.__callBase_DeleteMe();
			}

			// Token: 0x17000E5D RID: 3677
			// (get) Token: 0x06003339 RID: 13113 RVA: 0x000DD61C File Offset: 0x000DB81C
			// (set) Token: 0x0600333A RID: 13114 RVA: 0x000DD62C File Offset: 0x000DB82C
			public BattleTeam m_team
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

			// Token: 0x17000E5E RID: 3678
			// (get) Token: 0x0600333B RID: 13115 RVA: 0x000DD63C File Offset: 0x000DB83C
			// (set) Token: 0x0600333C RID: 13116 RVA: 0x000DD64C File Offset: 0x000DB84C
			public GridPosition m_position
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

			// Token: 0x17000E5F RID: 3679
			// (get) Token: 0x0600333D RID: 13117 RVA: 0x000DD65C File Offset: 0x000DB85C
			// (set) Token: 0x0600333E RID: 13118 RVA: 0x000DD66C File Offset: 0x000DB86C
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

			// Token: 0x17000E60 RID: 3680
			// (get) Token: 0x0600333F RID: 13119 RVA: 0x000DD67C File Offset: 0x000DB87C
			// (set) Token: 0x06003340 RID: 13120 RVA: 0x000DD68C File Offset: 0x000DB88C
			public GridPosition m_initPosition
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

			// Token: 0x17000E61 RID: 3681
			// (get) Token: 0x06003341 RID: 13121 RVA: 0x000DD69C File Offset: 0x000DB89C
			// (set) Token: 0x06003342 RID: 13122 RVA: 0x000DD6AC File Offset: 0x000DB8AC
			public GridPosition m_beforeGuardPosition
			{
				get
				{
					return this.m_owner.m_beforeGuardPosition;
				}
				set
				{
					this.m_owner.m_beforeGuardPosition = value;
				}
			}

			// Token: 0x17000E62 RID: 3682
			// (get) Token: 0x06003343 RID: 13123 RVA: 0x000DD6BC File Offset: 0x000DB8BC
			// (set) Token: 0x06003344 RID: 13124 RVA: 0x000DD6CC File Offset: 0x000DB8CC
			public BattleProperty m_heroBattleProperty
			{
				get
				{
					return this.m_owner.m_heroBattleProperty;
				}
				set
				{
					this.m_owner.m_heroBattleProperty = value;
				}
			}

			// Token: 0x17000E63 RID: 3683
			// (get) Token: 0x06003345 RID: 13125 RVA: 0x000DD6DC File Offset: 0x000DB8DC
			// (set) Token: 0x06003346 RID: 13126 RVA: 0x000DD6EC File Offset: 0x000DB8EC
			public BattleProperty m_soldierBattleProperty
			{
				get
				{
					return this.m_owner.m_soldierBattleProperty;
				}
				set
				{
					this.m_owner.m_soldierBattleProperty = value;
				}
			}

			// Token: 0x17000E64 RID: 3684
			// (get) Token: 0x06003347 RID: 13127 RVA: 0x000DD6FC File Offset: 0x000DB8FC
			// (set) Token: 0x06003348 RID: 13128 RVA: 0x000DD70C File Offset: 0x000DB90C
			public int m_heroHealthPoint
			{
				get
				{
					return this.m_owner.m_heroHealthPoint;
				}
				set
				{
					this.m_owner.m_heroHealthPoint = value;
				}
			}

			// Token: 0x17000E65 RID: 3685
			// (get) Token: 0x06003349 RID: 13129 RVA: 0x000DD71C File Offset: 0x000DB91C
			// (set) Token: 0x0600334A RID: 13130 RVA: 0x000DD72C File Offset: 0x000DB92C
			public int m_soldierTotalHealthPoint
			{
				get
				{
					return this.m_owner.m_soldierTotalHealthPoint;
				}
				set
				{
					this.m_owner.m_soldierTotalHealthPoint = value;
				}
			}

			// Token: 0x17000E66 RID: 3686
			// (get) Token: 0x0600334B RID: 13131 RVA: 0x000DD73C File Offset: 0x000DB93C
			// (set) Token: 0x0600334C RID: 13132 RVA: 0x000DD74C File Offset: 0x000DB94C
			public int m_soldierSingleHealthPointMax
			{
				get
				{
					return this.m_owner.m_soldierSingleHealthPointMax;
				}
				set
				{
					this.m_owner.m_soldierSingleHealthPointMax = value;
				}
			}

			// Token: 0x17000E67 RID: 3687
			// (get) Token: 0x0600334D RID: 13133 RVA: 0x000DD75C File Offset: 0x000DB95C
			// (set) Token: 0x0600334E RID: 13134 RVA: 0x000DD76C File Offset: 0x000DB96C
			public int m_initSoldierCount
			{
				get
				{
					return this.m_owner.m_initSoldierCount;
				}
				set
				{
					this.m_owner.m_initSoldierCount = value;
				}
			}

			// Token: 0x17000E68 RID: 3688
			// (get) Token: 0x0600334F RID: 13135 RVA: 0x000DD77C File Offset: 0x000DB97C
			// (set) Token: 0x06003350 RID: 13136 RVA: 0x000DD78C File Offset: 0x000DB98C
			public int m_heroLevel
			{
				get
				{
					return this.m_owner.m_heroLevel;
				}
				set
				{
					this.m_owner.m_heroLevel = value;
				}
			}

			// Token: 0x17000E69 RID: 3689
			// (get) Token: 0x06003351 RID: 13137 RVA: 0x000DD79C File Offset: 0x000DB99C
			// (set) Token: 0x06003352 RID: 13138 RVA: 0x000DD7AC File Offset: 0x000DB9AC
			public int m_heroStar
			{
				get
				{
					return this.m_owner.m_heroStar;
				}
				set
				{
					this.m_owner.m_heroStar = value;
				}
			}

			// Token: 0x17000E6A RID: 3690
			// (get) Token: 0x06003353 RID: 13139 RVA: 0x000DD7BC File Offset: 0x000DB9BC
			// (set) Token: 0x06003354 RID: 13140 RVA: 0x000DD7CC File Offset: 0x000DB9CC
			public int m_jobLevel
			{
				get
				{
					return this.m_owner.m_jobLevel;
				}
				set
				{
					this.m_owner.m_jobLevel = value;
				}
			}

			// Token: 0x17000E6B RID: 3691
			// (get) Token: 0x06003355 RID: 13141 RVA: 0x000DD7DC File Offset: 0x000DB9DC
			// (set) Token: 0x06003356 RID: 13142 RVA: 0x000DD7EC File Offset: 0x000DB9EC
			public ConfigDataJobInfo[] m_masterJobInfos
			{
				get
				{
					return this.m_owner.m_masterJobInfos;
				}
				set
				{
					this.m_owner.m_masterJobInfos = value;
				}
			}

			// Token: 0x17000E6C RID: 3692
			// (get) Token: 0x06003357 RID: 13143 RVA: 0x000DD7FC File Offset: 0x000DB9FC
			// (set) Token: 0x06003358 RID: 13144 RVA: 0x000DD80C File Offset: 0x000DBA0C
			public BattleActorEquipment[] m_equipments
			{
				get
				{
					return this.m_owner.m_equipments;
				}
				set
				{
					this.m_owner.m_equipments = value;
				}
			}

			// Token: 0x17000E6D RID: 3693
			// (get) Token: 0x06003359 RID: 13145 RVA: 0x000DD81C File Offset: 0x000DBA1C
			// (set) Token: 0x0600335A RID: 13146 RVA: 0x000DD82C File Offset: 0x000DBA2C
			public ConfigDataSkillInfo[] m_resonanceSkillInfos
			{
				get
				{
					return this.m_owner.m_resonanceSkillInfos;
				}
				set
				{
					this.m_owner.m_resonanceSkillInfos = value;
				}
			}

			// Token: 0x17000E6E RID: 3694
			// (get) Token: 0x0600335B RID: 13147 RVA: 0x000DD83C File Offset: 0x000DBA3C
			// (set) Token: 0x0600335C RID: 13148 RVA: 0x000DD84C File Offset: 0x000DBA4C
			public ConfigDataSkillInfo[] m_fetterSkillInfos
			{
				get
				{
					return this.m_owner.m_fetterSkillInfos;
				}
				set
				{
					this.m_owner.m_fetterSkillInfos = value;
				}
			}

			// Token: 0x17000E6F RID: 3695
			// (get) Token: 0x0600335D RID: 13149 RVA: 0x000DD85C File Offset: 0x000DBA5C
			// (set) Token: 0x0600335E RID: 13150 RVA: 0x000DD86C File Offset: 0x000DBA6C
			public int m_actionValue
			{
				get
				{
					return this.m_owner.m_actionValue;
				}
				set
				{
					this.m_owner.m_actionValue = value;
				}
			}

			// Token: 0x17000E70 RID: 3696
			// (get) Token: 0x0600335F RID: 13151 RVA: 0x000DD87C File Offset: 0x000DBA7C
			// (set) Token: 0x06003360 RID: 13152 RVA: 0x000DD88C File Offset: 0x000DBA8C
			public MoveType m_moveType
			{
				get
				{
					return this.m_owner.m_moveType;
				}
				set
				{
					this.m_owner.m_moveType = value;
				}
			}

			// Token: 0x17000E71 RID: 3697
			// (get) Token: 0x06003361 RID: 13153 RVA: 0x000DD89C File Offset: 0x000DBA9C
			// (set) Token: 0x06003362 RID: 13154 RVA: 0x000DD8AC File Offset: 0x000DBAAC
			public bool m_isActionFinished
			{
				get
				{
					return this.m_owner.m_isActionFinished;
				}
				set
				{
					this.m_owner.m_isActionFinished = value;
				}
			}

			// Token: 0x17000E72 RID: 3698
			// (get) Token: 0x06003363 RID: 13155 RVA: 0x000DD8BC File Offset: 0x000DBABC
			// (set) Token: 0x06003364 RID: 13156 RVA: 0x000DD8CC File Offset: 0x000DBACC
			public bool m_hasExtraAction
			{
				get
				{
					return this.m_owner.m_hasExtraAction;
				}
				set
				{
					this.m_owner.m_hasExtraAction = value;
				}
			}

			// Token: 0x17000E73 RID: 3699
			// (get) Token: 0x06003365 RID: 13157 RVA: 0x000DD8DC File Offset: 0x000DBADC
			// (set) Token: 0x06003366 RID: 13158 RVA: 0x000DD8EC File Offset: 0x000DBAEC
			public int m_hasExtraActionCount
			{
				get
				{
					return this.m_owner.m_hasExtraActionCount;
				}
				set
				{
					this.m_owner.m_hasExtraActionCount = value;
				}
			}

			// Token: 0x17000E74 RID: 3700
			// (get) Token: 0x06003367 RID: 13159 RVA: 0x000DD8FC File Offset: 0x000DBAFC
			// (set) Token: 0x06003368 RID: 13160 RVA: 0x000DD90C File Offset: 0x000DBB0C
			public int m_hasExtraMovePoint
			{
				get
				{
					return this.m_owner.m_hasExtraMovePoint;
				}
				set
				{
					this.m_owner.m_hasExtraMovePoint = value;
				}
			}

			// Token: 0x17000E75 RID: 3701
			// (get) Token: 0x06003369 RID: 13161 RVA: 0x000DD91C File Offset: 0x000DBB1C
			// (set) Token: 0x0600336A RID: 13162 RVA: 0x000DD92C File Offset: 0x000DBB2C
			public bool m_isExtraAction
			{
				get
				{
					return this.m_owner.m_isExtraAction;
				}
				set
				{
					this.m_owner.m_isExtraAction = value;
				}
			}

			// Token: 0x17000E76 RID: 3702
			// (get) Token: 0x0600336B RID: 13163 RVA: 0x000DD93C File Offset: 0x000DBB3C
			// (set) Token: 0x0600336C RID: 13164 RVA: 0x000DD94C File Offset: 0x000DBB4C
			public int m_extraActionMovePoint
			{
				get
				{
					return this.m_owner.m_extraActionMovePoint;
				}
				set
				{
					this.m_owner.m_extraActionMovePoint = value;
				}
			}

			// Token: 0x17000E77 RID: 3703
			// (get) Token: 0x0600336D RID: 13165 RVA: 0x000DD95C File Offset: 0x000DBB5C
			// (set) Token: 0x0600336E RID: 13166 RVA: 0x000DD96C File Offset: 0x000DBB6C
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

			// Token: 0x17000E78 RID: 3704
			// (get) Token: 0x0600336F RID: 13167 RVA: 0x000DD97C File Offset: 0x000DBB7C
			// (set) Token: 0x06003370 RID: 13168 RVA: 0x000DD98C File Offset: 0x000DBB8C
			public bool m_isDie
			{
				get
				{
					return this.m_owner.m_isDie;
				}
				set
				{
					this.m_owner.m_isDie = value;
				}
			}

			// Token: 0x17000E79 RID: 3705
			// (get) Token: 0x06003371 RID: 13169 RVA: 0x000DD99C File Offset: 0x000DBB9C
			// (set) Token: 0x06003372 RID: 13170 RVA: 0x000DD9AC File Offset: 0x000DBBAC
			public bool m_isRetreat
			{
				get
				{
					return this.m_owner.m_isRetreat;
				}
				set
				{
					this.m_owner.m_isRetreat = value;
				}
			}

			// Token: 0x17000E7A RID: 3706
			// (get) Token: 0x06003373 RID: 13171 RVA: 0x000DD9BC File Offset: 0x000DBBBC
			// (set) Token: 0x06003374 RID: 13172 RVA: 0x000DD9CC File Offset: 0x000DBBCC
			public List<BattleSkillState> m_skillStates
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

			// Token: 0x17000E7B RID: 3707
			// (get) Token: 0x06003375 RID: 13173 RVA: 0x000DD9DC File Offset: 0x000DBBDC
			// (set) Token: 0x06003376 RID: 13174 RVA: 0x000DD9EC File Offset: 0x000DBBEC
			public List<BuffState> m_buffStates
			{
				get
				{
					return this.m_owner.m_buffStates;
				}
				set
				{
					this.m_owner.m_buffStates = value;
				}
			}

			// Token: 0x17000E7C RID: 3708
			// (get) Token: 0x06003377 RID: 13175 RVA: 0x000DD9FC File Offset: 0x000DBBFC
			// (set) Token: 0x06003378 RID: 13176 RVA: 0x000DDA0C File Offset: 0x000DBC0C
			public int m_buffIdCounter
			{
				get
				{
					return this.m_owner.m_buffIdCounter;
				}
				set
				{
					this.m_owner.m_buffIdCounter = value;
				}
			}

			// Token: 0x17000E7D RID: 3709
			// (get) Token: 0x06003379 RID: 13177 RVA: 0x000DDA1C File Offset: 0x000DBC1C
			// (set) Token: 0x0600337A RID: 13178 RVA: 0x000DDA2C File Offset: 0x000DBC2C
			public ulong m_buffTypes
			{
				get
				{
					return this.m_owner.m_buffTypes;
				}
				set
				{
					this.m_owner.m_buffTypes = value;
				}
			}

			// Token: 0x17000E7E RID: 3710
			// (get) Token: 0x0600337B RID: 13179 RVA: 0x000DDA3C File Offset: 0x000DBC3C
			// (set) Token: 0x0600337C RID: 13180 RVA: 0x000DDA4C File Offset: 0x000DBC4C
			public uint m_fightTags
			{
				get
				{
					return this.m_owner.m_fightTags;
				}
				set
				{
					this.m_owner.m_fightTags = value;
				}
			}

			// Token: 0x17000E7F RID: 3711
			// (get) Token: 0x0600337D RID: 13181 RVA: 0x000DDA5C File Offset: 0x000DBC5C
			// (set) Token: 0x0600337E RID: 13182 RVA: 0x000DDA6C File Offset: 0x000DBC6C
			public BattleActor m_summoner
			{
				get
				{
					return this.m_owner.m_summoner;
				}
				set
				{
					this.m_owner.m_summoner = value;
				}
			}

			// Token: 0x17000E80 RID: 3712
			// (get) Token: 0x0600337F RID: 13183 RVA: 0x000DDA7C File Offset: 0x000DBC7C
			// (set) Token: 0x06003380 RID: 13184 RVA: 0x000DDA8C File Offset: 0x000DBC8C
			public BattleActor m_killerActor
			{
				get
				{
					return this.m_owner.m_killerActor;
				}
				set
				{
					this.m_owner.m_killerActor = value;
				}
			}

			// Token: 0x17000E81 RID: 3713
			// (get) Token: 0x06003381 RID: 13185 RVA: 0x000DDA9C File Offset: 0x000DBC9C
			// (set) Token: 0x06003382 RID: 13186 RVA: 0x000DDAAC File Offset: 0x000DBCAC
			public bool m_isNpc
			{
				get
				{
					return this.m_owner.m_isNpc;
				}
				set
				{
					this.m_owner.m_isNpc = value;
				}
			}

			// Token: 0x17000E82 RID: 3714
			// (get) Token: 0x06003383 RID: 13187 RVA: 0x000DDABC File Offset: 0x000DBCBC
			// (set) Token: 0x06003384 RID: 13188 RVA: 0x000DDACC File Offset: 0x000DBCCC
			public bool m_isPlayerNpc
			{
				get
				{
					return this.m_owner.m_isPlayerNpc;
				}
				set
				{
					this.m_owner.m_isPlayerNpc = value;
				}
			}

			// Token: 0x17000E83 RID: 3715
			// (get) Token: 0x06003385 RID: 13189 RVA: 0x000DDADC File Offset: 0x000DBCDC
			// (set) Token: 0x06003386 RID: 13190 RVA: 0x000DDAEC File Offset: 0x000DBCEC
			public BattleActorSourceType m_sourceType
			{
				get
				{
					return this.m_owner.m_sourceType;
				}
				set
				{
					this.m_owner.m_sourceType = value;
				}
			}

			// Token: 0x17000E84 RID: 3716
			// (get) Token: 0x06003387 RID: 13191 RVA: 0x000DDAFC File Offset: 0x000DBCFC
			// (set) Token: 0x06003388 RID: 13192 RVA: 0x000DDB0C File Offset: 0x000DBD0C
			public ConfigDataHeroInfo m_heroInfo
			{
				get
				{
					return this.m_owner.m_heroInfo;
				}
				set
				{
					this.m_owner.m_heroInfo = value;
				}
			}

			// Token: 0x17000E85 RID: 3717
			// (get) Token: 0x06003389 RID: 13193 RVA: 0x000DDB1C File Offset: 0x000DBD1C
			// (set) Token: 0x0600338A RID: 13194 RVA: 0x000DDB2C File Offset: 0x000DBD2C
			public ConfigDataJobConnectionInfo m_jobConnectionInfo
			{
				get
				{
					return this.m_owner.m_jobConnectionInfo;
				}
				set
				{
					this.m_owner.m_jobConnectionInfo = value;
				}
			}

			// Token: 0x17000E86 RID: 3718
			// (get) Token: 0x0600338B RID: 13195 RVA: 0x000DDB3C File Offset: 0x000DBD3C
			// (set) Token: 0x0600338C RID: 13196 RVA: 0x000DDB4C File Offset: 0x000DBD4C
			public ConfigDataJobInfo m_jobInfo
			{
				get
				{
					return this.m_owner.m_jobInfo;
				}
				set
				{
					this.m_owner.m_jobInfo = value;
				}
			}

			// Token: 0x17000E87 RID: 3719
			// (get) Token: 0x0600338D RID: 13197 RVA: 0x000DDB5C File Offset: 0x000DBD5C
			// (set) Token: 0x0600338E RID: 13198 RVA: 0x000DDB6C File Offset: 0x000DBD6C
			public ConfigDataArmyInfo m_heroArmyInfo
			{
				get
				{
					return this.m_owner.m_heroArmyInfo;
				}
				set
				{
					this.m_owner.m_heroArmyInfo = value;
				}
			}

			// Token: 0x17000E88 RID: 3720
			// (get) Token: 0x0600338F RID: 13199 RVA: 0x000DDB7C File Offset: 0x000DBD7C
			// (set) Token: 0x06003390 RID: 13200 RVA: 0x000DDB8C File Offset: 0x000DBD8C
			public ConfigDataSoldierInfo m_soldierInfo
			{
				get
				{
					return this.m_owner.m_soldierInfo;
				}
				set
				{
					this.m_owner.m_soldierInfo = value;
				}
			}

			// Token: 0x17000E89 RID: 3721
			// (get) Token: 0x06003391 RID: 13201 RVA: 0x000DDB9C File Offset: 0x000DBD9C
			// (set) Token: 0x06003392 RID: 13202 RVA: 0x000DDBAC File Offset: 0x000DBDAC
			public ConfigDataArmyInfo m_soldierArmyInfo
			{
				get
				{
					return this.m_owner.m_soldierArmyInfo;
				}
				set
				{
					this.m_owner.m_soldierArmyInfo = value;
				}
			}

			// Token: 0x17000E8A RID: 3722
			// (get) Token: 0x06003393 RID: 13203 RVA: 0x000DDBBC File Offset: 0x000DBDBC
			// (set) Token: 0x06003394 RID: 13204 RVA: 0x000DDBCC File Offset: 0x000DBDCC
			public ConfigDataCharImageSkinResourceInfo m_heroCharImageSkinResourceInfo
			{
				get
				{
					return this.m_owner.m_heroCharImageSkinResourceInfo;
				}
				set
				{
					this.m_owner.m_heroCharImageSkinResourceInfo = value;
				}
			}

			// Token: 0x17000E8B RID: 3723
			// (get) Token: 0x06003395 RID: 13205 RVA: 0x000DDBDC File Offset: 0x000DBDDC
			// (set) Token: 0x06003396 RID: 13206 RVA: 0x000DDBEC File Offset: 0x000DBDEC
			public ConfigDataModelSkinResourceInfo m_heroModelSkinResourceInfo
			{
				get
				{
					return this.m_owner.m_heroModelSkinResourceInfo;
				}
				set
				{
					this.m_owner.m_heroModelSkinResourceInfo = value;
				}
			}

			// Token: 0x17000E8C RID: 3724
			// (get) Token: 0x06003397 RID: 13207 RVA: 0x000DDBFC File Offset: 0x000DBDFC
			// (set) Token: 0x06003398 RID: 13208 RVA: 0x000DDC0C File Offset: 0x000DBE0C
			public ConfigDataModelSkinResourceInfo m_soldierModelSkinResourceInfo
			{
				get
				{
					return this.m_owner.m_soldierModelSkinResourceInfo;
				}
				set
				{
					this.m_owner.m_soldierModelSkinResourceInfo = value;
				}
			}

			// Token: 0x17000E8D RID: 3725
			// (get) Token: 0x06003399 RID: 13209 RVA: 0x000DDC1C File Offset: 0x000DBE1C
			// (set) Token: 0x0600339A RID: 13210 RVA: 0x000DDC2C File Offset: 0x000DBE2C
			public ConfigDataSkillInfo[] m_extraPassiveSkillInfos
			{
				get
				{
					return this.m_owner.m_extraPassiveSkillInfos;
				}
				set
				{
					this.m_owner.m_extraPassiveSkillInfos = value;
				}
			}

			// Token: 0x17000E8E RID: 3726
			// (get) Token: 0x0600339B RID: 13211 RVA: 0x000DDC3C File Offset: 0x000DBE3C
			// (set) Token: 0x0600339C RID: 13212 RVA: 0x000DDC4C File Offset: 0x000DBE4C
			public ConfigDataSkillInfo m_extraTalentSkillInfo
			{
				get
				{
					return this.m_owner.m_extraTalentSkillInfo;
				}
				set
				{
					this.m_owner.m_extraTalentSkillInfo = value;
				}
			}

			// Token: 0x17000E8F RID: 3727
			// (get) Token: 0x0600339D RID: 13213 RVA: 0x000DDC5C File Offset: 0x000DBE5C
			// (set) Token: 0x0600339E RID: 13214 RVA: 0x000DDC6C File Offset: 0x000DBE6C
			public bool m_isActionCriticalAttack
			{
				get
				{
					return this.m_owner.m_isActionCriticalAttack;
				}
				set
				{
					this.m_owner.m_isActionCriticalAttack = value;
				}
			}

			// Token: 0x17000E90 RID: 3728
			// (get) Token: 0x0600339F RID: 13215 RVA: 0x000DDC7C File Offset: 0x000DBE7C
			// (set) Token: 0x060033A0 RID: 13216 RVA: 0x000DDC8C File Offset: 0x000DBE8C
			public bool m_isActionKillActor
			{
				get
				{
					return this.m_owner.m_isActionKillActor;
				}
				set
				{
					this.m_owner.m_isActionKillActor = value;
				}
			}

			// Token: 0x17000E91 RID: 3729
			// (get) Token: 0x060033A1 RID: 13217 RVA: 0x000DDC9C File Offset: 0x000DBE9C
			// (set) Token: 0x060033A2 RID: 13218 RVA: 0x000DDCAC File Offset: 0x000DBEAC
			public bool m_isActionDamageActor
			{
				get
				{
					return this.m_owner.m_isActionDamageActor;
				}
				set
				{
					this.m_owner.m_isActionDamageActor = value;
				}
			}

			// Token: 0x17000E92 RID: 3730
			// (get) Token: 0x060033A3 RID: 13219 RVA: 0x000DDCBC File Offset: 0x000DBEBC
			// (set) Token: 0x060033A4 RID: 13220 RVA: 0x000DDCCC File Offset: 0x000DBECC
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

			// Token: 0x17000E93 RID: 3731
			// (get) Token: 0x060033A5 RID: 13221 RVA: 0x000DDCDC File Offset: 0x000DBEDC
			// (set) Token: 0x060033A6 RID: 13222 RVA: 0x000DDCEC File Offset: 0x000DBEEC
			public bool m_isBeKillAttack
			{
				get
				{
					return this.m_owner.m_isBeKillAttack;
				}
				set
				{
					this.m_owner.m_isBeKillAttack = value;
				}
			}

			// Token: 0x17000E94 RID: 3732
			// (get) Token: 0x060033A7 RID: 13223 RVA: 0x000DDCFC File Offset: 0x000DBEFC
			// (set) Token: 0x060033A8 RID: 13224 RVA: 0x000DDD0C File Offset: 0x000DBF0C
			public int m_actionMoveGrids
			{
				get
				{
					return this.m_owner.m_actionMoveGrids;
				}
				set
				{
					this.m_owner.m_actionMoveGrids = value;
				}
			}

			// Token: 0x17000E95 RID: 3733
			// (get) Token: 0x060033A9 RID: 13225 RVA: 0x000DDD1C File Offset: 0x000DBF1C
			// (set) Token: 0x060033AA RID: 13226 RVA: 0x000DDD2C File Offset: 0x000DBF2C
			public int m_actionRemainMovePoint
			{
				get
				{
					return this.m_owner.m_actionRemainMovePoint;
				}
				set
				{
					this.m_owner.m_actionRemainMovePoint = value;
				}
			}

			// Token: 0x17000E96 RID: 3734
			// (get) Token: 0x060033AB RID: 13227 RVA: 0x000DDD3C File Offset: 0x000DBF3C
			// (set) Token: 0x060033AC RID: 13228 RVA: 0x000DDD4C File Offset: 0x000DBF4C
			public int m_buffReplaceMovePoint
			{
				get
				{
					return this.m_owner.m_buffReplaceMovePoint;
				}
				set
				{
					this.m_owner.m_buffReplaceMovePoint = value;
				}
			}

			// Token: 0x17000E97 RID: 3735
			// (get) Token: 0x060033AD RID: 13229 RVA: 0x000DDD5C File Offset: 0x000DBF5C
			// (set) Token: 0x060033AE RID: 13230 RVA: 0x000DDD6C File Offset: 0x000DBF6C
			public ConfigDataSkillInfo m_lastDamageBySkillInfo
			{
				get
				{
					return this.m_owner.m_lastDamageBySkillInfo;
				}
				set
				{
					this.m_owner.m_lastDamageBySkillInfo = value;
				}
			}

			// Token: 0x17000E98 RID: 3736
			// (get) Token: 0x060033AF RID: 13231 RVA: 0x000DDD7C File Offset: 0x000DBF7C
			// (set) Token: 0x060033B0 RID: 13232 RVA: 0x000DDD8C File Offset: 0x000DBF8C
			public int m_firstDamageTurn
			{
				get
				{
					return this.m_owner.m_firstDamageTurn;
				}
				set
				{
					this.m_owner.m_firstDamageTurn = value;
				}
			}

			// Token: 0x17000E99 RID: 3737
			// (get) Token: 0x060033B1 RID: 13233 RVA: 0x000DDD9C File Offset: 0x000DBF9C
			// (set) Token: 0x060033B2 RID: 13234 RVA: 0x000DDDAC File Offset: 0x000DBFAC
			public ulong m_satisfyConditions
			{
				get
				{
					return this.m_owner.m_satisfyConditions;
				}
				set
				{
					this.m_owner.m_satisfyConditions = value;
				}
			}

			// Token: 0x17000E9A RID: 3738
			// (get) Token: 0x060033B3 RID: 13235 RVA: 0x000DDDBC File Offset: 0x000DBFBC
			// (set) Token: 0x060033B4 RID: 13236 RVA: 0x000DDDCC File Offset: 0x000DBFCC
			public short m_actionCount
			{
				get
				{
					return this.m_owner.m_actionCount;
				}
				set
				{
					this.m_owner.m_actionCount = value;
				}
			}

			// Token: 0x17000E9B RID: 3739
			// (get) Token: 0x060033B5 RID: 13237 RVA: 0x000DDDDC File Offset: 0x000DBFDC
			// (set) Token: 0x060033B6 RID: 13238 RVA: 0x000DDDEC File Offset: 0x000DBFEC
			public short m_combatAttackCount
			{
				get
				{
					return this.m_owner.m_combatAttackCount;
				}
				set
				{
					this.m_owner.m_combatAttackCount = value;
				}
			}

			// Token: 0x17000E9C RID: 3740
			// (get) Token: 0x060033B7 RID: 13239 RVA: 0x000DDDFC File Offset: 0x000DBFFC
			// (set) Token: 0x060033B8 RID: 13240 RVA: 0x000DDE0C File Offset: 0x000DC00C
			public short m_beCombatAttackCount
			{
				get
				{
					return this.m_owner.m_beCombatAttackCount;
				}
				set
				{
					this.m_owner.m_beCombatAttackCount = value;
				}
			}

			// Token: 0x17000E9D RID: 3741
			// (get) Token: 0x060033B9 RID: 13241 RVA: 0x000DDE1C File Offset: 0x000DC01C
			// (set) Token: 0x060033BA RID: 13242 RVA: 0x000DDE2C File Offset: 0x000DC02C
			public short m_useSkillCount
			{
				get
				{
					return this.m_owner.m_useSkillCount;
				}
				set
				{
					this.m_owner.m_useSkillCount = value;
				}
			}

			// Token: 0x17000E9E RID: 3742
			// (get) Token: 0x060033BB RID: 13243 RVA: 0x000DDE3C File Offset: 0x000DC03C
			// (set) Token: 0x060033BC RID: 13244 RVA: 0x000DDE4C File Offset: 0x000DC04C
			public short m_killActorCount
			{
				get
				{
					return this.m_owner.m_killActorCount;
				}
				set
				{
					this.m_owner.m_killActorCount = value;
				}
			}

			// Token: 0x17000E9F RID: 3743
			// (get) Token: 0x060033BD RID: 13245 RVA: 0x000DDE5C File Offset: 0x000DC05C
			// (set) Token: 0x060033BE RID: 13246 RVA: 0x000DDE6C File Offset: 0x000DC06C
			public int m_dieTurn
			{
				get
				{
					return this.m_owner.m_dieTurn;
				}
				set
				{
					this.m_owner.m_dieTurn = value;
				}
			}

			// Token: 0x17000EA0 RID: 3744
			// (get) Token: 0x060033BF RID: 13247 RVA: 0x000DDE7C File Offset: 0x000DC07C
			// (set) Token: 0x060033C0 RID: 13248 RVA: 0x000DDE8C File Offset: 0x000DC08C
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

			// Token: 0x17000EA1 RID: 3745
			// (get) Token: 0x060033C1 RID: 13249 RVA: 0x000DDE9C File Offset: 0x000DC09C
			// (set) Token: 0x060033C2 RID: 13250 RVA: 0x000DDEAC File Offset: 0x000DC0AC
			public uint m_executedCommandTypes
			{
				get
				{
					return this.m_owner.m_executedCommandTypes;
				}
				set
				{
					this.m_owner.m_executedCommandTypes = value;
				}
			}

			// Token: 0x17000EA2 RID: 3746
			// (get) Token: 0x060033C3 RID: 13251 RVA: 0x000DDEBC File Offset: 0x000DC0BC
			// (set) Token: 0x060033C4 RID: 13252 RVA: 0x000DDECC File Offset: 0x000DC0CC
			public ConfigDataSkillInfo m_executedSkillInfo
			{
				get
				{
					return this.m_owner.m_executedSkillInfo;
				}
				set
				{
					this.m_owner.m_executedSkillInfo = value;
				}
			}

			// Token: 0x17000EA3 RID: 3747
			// (get) Token: 0x060033C5 RID: 13253 RVA: 0x000DDEDC File Offset: 0x000DC0DC
			// (set) Token: 0x060033C6 RID: 13254 RVA: 0x000DDEEC File Offset: 0x000DC0EC
			public int m_playerIndex
			{
				get
				{
					return this.m_owner.m_playerIndex;
				}
				set
				{
					this.m_owner.m_playerIndex = value;
				}
			}

			// Token: 0x17000EA4 RID: 3748
			// (get) Token: 0x060033C7 RID: 13255 RVA: 0x000DDEFC File Offset: 0x000DC0FC
			// (set) Token: 0x060033C8 RID: 13256 RVA: 0x000DDF0C File Offset: 0x000DC10C
			public ConfigDataBehavior m_curBehaviorCfg
			{
				get
				{
					return this.m_owner.m_curBehaviorCfg;
				}
				set
				{
					this.m_owner.m_curBehaviorCfg = value;
				}
			}

			// Token: 0x17000EA5 RID: 3749
			// (get) Token: 0x060033C9 RID: 13257 RVA: 0x000DDF1C File Offset: 0x000DC11C
			// (set) Token: 0x060033CA RID: 13258 RVA: 0x000DDF2C File Offset: 0x000DC12C
			public BattleActor.BehaviorState m_curBehaviorState
			{
				get
				{
					return this.m_owner.m_curBehaviorState;
				}
				set
				{
					this.m_owner.m_curBehaviorState = value;
				}
			}

			// Token: 0x17000EA6 RID: 3750
			// (get) Token: 0x060033CB RID: 13259 RVA: 0x000DDF3C File Offset: 0x000DC13C
			// (set) Token: 0x060033CC RID: 13260 RVA: 0x000DDF4C File Offset: 0x000DC14C
			public BehaviorTarget m_moveTarget
			{
				get
				{
					return this.m_owner.m_moveTarget;
				}
				set
				{
					this.m_owner.m_moveTarget = value;
				}
			}

			// Token: 0x17000EA7 RID: 3751
			// (get) Token: 0x060033CD RID: 13261 RVA: 0x000DDF5C File Offset: 0x000DC15C
			// (set) Token: 0x060033CE RID: 13262 RVA: 0x000DDF6C File Offset: 0x000DC16C
			public BehaviorTarget m_attackTarget
			{
				get
				{
					return this.m_owner.m_attackTarget;
				}
				set
				{
					this.m_owner.m_attackTarget = value;
				}
			}

			// Token: 0x17000EA8 RID: 3752
			// (get) Token: 0x060033CF RID: 13263 RVA: 0x000DDF7C File Offset: 0x000DC17C
			// (set) Token: 0x060033D0 RID: 13264 RVA: 0x000DDF8C File Offset: 0x000DC18C
			public int m_attackSkillIndex
			{
				get
				{
					return this.m_owner.m_attackSkillIndex;
				}
				set
				{
					this.m_owner.m_attackSkillIndex = value;
				}
			}

			// Token: 0x17000EA9 RID: 3753
			// (get) Token: 0x060033D1 RID: 13265 RVA: 0x000DDF9C File Offset: 0x000DC19C
			// (set) Token: 0x060033D2 RID: 13266 RVA: 0x000DDFAC File Offset: 0x000DC1AC
			public int[] m_beAttackedCountOfTurns
			{
				get
				{
					return this.m_owner.m_beAttackedCountOfTurns;
				}
				set
				{
					this.m_owner.m_beAttackedCountOfTurns = value;
				}
			}

			// Token: 0x17000EAA RID: 3754
			// (get) Token: 0x060033D3 RID: 13267 RVA: 0x000DDFBC File Offset: 0x000DC1BC
			// (set) Token: 0x060033D4 RID: 13268 RVA: 0x000DDFCC File Offset: 0x000DC1CC
			public int m_groupId
			{
				get
				{
					return this.m_owner.m_groupId;
				}
				set
				{
					this.m_owner.m_groupId = value;
				}
			}

			// Token: 0x17000EAB RID: 3755
			// (get) Token: 0x060033D5 RID: 13269 RVA: 0x000DDFDC File Offset: 0x000DC1DC
			// (set) Token: 0x060033D6 RID: 13270 RVA: 0x000DDFEC File Offset: 0x000DC1EC
			public int m_aiCreateBattleCommandCount
			{
				get
				{
					return this.m_owner.m_aiCreateBattleCommandCount;
				}
				set
				{
					this.m_owner.m_aiCreateBattleCommandCount = value;
				}
			}

			// Token: 0x17000EAC RID: 3756
			// (get) Token: 0x060033D7 RID: 13271 RVA: 0x000DDFFC File Offset: 0x000DC1FC
			public static float m_healSkillTargetHPThresh
			{
				get
				{
					return 0.7f;
				}
			}

			// Token: 0x17000EAD RID: 3757
			// (get) Token: 0x060033D8 RID: 13272 RVA: 0x000DE004 File Offset: 0x000DC204
			public bool IsAttackedByEnemy
			{
				get
				{
					return this.m_owner.IsAttackedByEnemy;
				}
			}

			// Token: 0x17000EAE RID: 3758
			// (get) Token: 0x060033D9 RID: 13273 RVA: 0x000DE014 File Offset: 0x000DC214
			public bool IsAttackedByEnemyInLastTrun
			{
				get
				{
					return this.m_owner.IsAttackedByEnemyInLastTrun;
				}
			}

			// Token: 0x17000EAF RID: 3759
			// (get) Token: 0x060033DA RID: 13274 RVA: 0x000DE024 File Offset: 0x000DC224
			public int NextBehaviorByChangeRules
			{
				get
				{
					return this.m_owner.NextBehaviorByChangeRules;
				}
			}

			// Token: 0x17000EB0 RID: 3760
			// (get) Token: 0x060033DB RID: 13275 RVA: 0x000DE034 File Offset: 0x000DC234
			public float TotalHPPercent
			{
				get
				{
					return this.m_owner.TotalHPPercent;
				}
			}

			// Token: 0x17000EB1 RID: 3761
			// (get) Token: 0x060033DC RID: 13276 RVA: 0x000DE044 File Offset: 0x000DC244
			public ConfigDataSkillInfo BehaviorSelectSkillInfo
			{
				get
				{
					return this.m_owner.BehaviorSelectSkillInfo;
				}
			}

			// Token: 0x060033DD RID: 13277 RVA: 0x000DE054 File Offset: 0x000DC254
			public void ComputeBattleProperties(BattlePropertyModifier pm)
			{
				this.m_owner.ComputeBattleProperties(pm);
			}

			// Token: 0x060033DE RID: 13278 RVA: 0x000DE064 File Offset: 0x000DC264
			public void SetPosition(GridPosition p)
			{
				this.m_owner.SetPosition(p);
			}

			// Token: 0x060033DF RID: 13279 RVA: 0x000DE074 File Offset: 0x000DC274
			public void MoveTo(GridPosition p)
			{
				this.m_owner.MoveTo(p);
			}

			// Token: 0x060033E0 RID: 13280 RVA: 0x000DE084 File Offset: 0x000DC284
			public void ClearMapActor()
			{
				this.m_owner.ClearMapActor();
			}

			// Token: 0x060033E1 RID: 13281 RVA: 0x000DE094 File Offset: 0x000DC294
			public void PostActionTerrainDamage()
			{
				this.m_owner.PostActionTerrainDamage();
			}

			// Token: 0x060033E2 RID: 13282 RVA: 0x000DE0A4 File Offset: 0x000DC2A4
			public bool ShouldLog()
			{
				return this.m_owner.ShouldLog();
			}

			// Token: 0x060033E3 RID: 13283 RVA: 0x000DE0B4 File Offset: 0x000DC2B4
			public void AddExecutedCommandType(BattleCommandType cmdType)
			{
				this.m_owner.AddExecutedCommandType(cmdType);
			}

			// Token: 0x060033E4 RID: 13284 RVA: 0x000DE0C4 File Offset: 0x000DC2C4
			public bool IsExecutedCommandType(BattleCommandType cmdType)
			{
				return this.m_owner.IsExecutedCommandType(cmdType);
			}

			// Token: 0x060033E5 RID: 13285 RVA: 0x000DE0D4 File Offset: 0x000DC2D4
			public void FindMoveAndAttackRegion(int distance, int shape)
			{
				this.m_owner.FindMoveAndAttackRegion(distance, shape);
			}

			// Token: 0x060033E6 RID: 13286 RVA: 0x000DE0E4 File Offset: 0x000DC2E4
			public bool FindRandomEmptyPosition(int attackDistance, int shape, ref GridPosition position)
			{
				return this.m_owner.FindRandomEmptyPosition(attackDistance, shape, ref position);
			}

			// Token: 0x060033E7 RID: 13287 RVA: 0x000DE0F4 File Offset: 0x000DC2F4
			public GridPosition FindAttackPosition(int attackDistance, int shape, GridPosition targetPos, bool checkMoveRegion, bool farAway)
			{
				return this.m_owner.FindAttackPosition(attackDistance, shape, targetPos, checkMoveRegion, farAway);
			}

			// Token: 0x060033E8 RID: 13288 RVA: 0x000DE108 File Offset: 0x000DC308
			public static int ComputeActorScoreDamage(BattleActor a, int param)
			{
				return BattleActor.ComputeActorScoreDamage(a, param);
			}

			// Token: 0x060033E9 RID: 13289 RVA: 0x000DE114 File Offset: 0x000DC314
			public static int ComputeActorScoreHeal(BattleActor a, int param)
			{
				return BattleActor.ComputeActorScoreHeal(a, param);
			}

			// Token: 0x060033EA RID: 13290 RVA: 0x000DE120 File Offset: 0x000DC320
			public int ComputeActorScoreBuff(BattleActor a, int param)
			{
				return this.m_owner.ComputeActorScoreBuff(a, param);
			}

			// Token: 0x060033EB RID: 13291 RVA: 0x000DE130 File Offset: 0x000DC330
			public BattleActor SelectNearestTarget(BattleTeam team)
			{
				return this.m_owner.SelectNearestTarget(team);
			}

			// Token: 0x060033EC RID: 13292 RVA: 0x000DE140 File Offset: 0x000DC340
			public RandomNumber GetAIRandomNumber()
			{
				return this.m_owner.GetAIRandomNumber();
			}

			// Token: 0x060033ED RID: 13293 RVA: 0x000DE150 File Offset: 0x000DC350
			public BattleTeam GetSkillTargetTeam(ConfigDataSkillInfo skillInfo)
			{
				return this.m_owner.GetSkillTargetTeam(skillInfo);
			}

			// Token: 0x060033EE RID: 13294 RVA: 0x000DE160 File Offset: 0x000DC360
			public bool CanAttackOrUseSkill()
			{
				return this.m_owner.CanAttackOrUseSkill();
			}

			// Token: 0x060033EF RID: 13295 RVA: 0x000DE170 File Offset: 0x000DC370
			public void SetBehaviorState(BattleActor.BehaviorState state)
			{
				this.m_owner.SetBehaviorState(state);
			}

			// Token: 0x060033F0 RID: 13296 RVA: 0x000DE180 File Offset: 0x000DC380
			public void DoBehaviorChangeRules()
			{
				this.m_owner.DoBehaviorChangeRules();
			}

			// Token: 0x060033F1 RID: 13297 RVA: 0x000DE190 File Offset: 0x000DC390
			public GridPosition FindFarthestPosition(List<GridPosition> positions, GridPosition startPos)
			{
				return this.m_owner.FindFarthestPosition(positions, startPos);
			}

			// Token: 0x060033F2 RID: 13298 RVA: 0x000DE1A0 File Offset: 0x000DC3A0
			public GridPosition FindNearestPosition(List<GridPosition> positions, GridPosition startPos)
			{
				return this.m_owner.FindNearestPosition(positions, startPos);
			}

			// Token: 0x060033F3 RID: 13299 RVA: 0x000DE1B0 File Offset: 0x000DC3B0
			public BattleActor FindNearestActor(List<BattleActor> actors, GridPosition startPos)
			{
				return this.m_owner.FindNearestActor(actors, startPos);
			}

			// Token: 0x060033F4 RID: 13300 RVA: 0x000DE1C0 File Offset: 0x000DC3C0
			public BehaviorTarget DoSelectTarget(SelectTarget st, ConfigDataBehavior.ParamData param)
			{
				return this.m_owner.DoSelectTarget(st, param);
			}

			// Token: 0x060033F5 RID: 13301 RVA: 0x000DE1D0 File Offset: 0x000DC3D0
			public List<BattleActor> FindActorsByIDFilter(List<BattleActor> actors, int[] priorIDs, int[] excludeIDs)
			{
				return this.m_owner.FindActorsByIDFilter(actors, priorIDs, excludeIDs);
			}

			// Token: 0x060033F6 RID: 13302 RVA: 0x000DE1E0 File Offset: 0x000DC3E0
			public static bool Contains(int[] target, int nr)
			{
				return BattleActor.Contains(target, nr);
			}

			// Token: 0x060033F7 RID: 13303 RVA: 0x000DE1EC File Offset: 0x000DC3EC
			public void SelectMoveTarget()
			{
				this.m_owner.SelectMoveTarget();
			}

			// Token: 0x060033F8 RID: 13304 RVA: 0x000DE1FC File Offset: 0x000DC3FC
			public void GenerateCommandOfMove(GridPosition target)
			{
				this.m_owner.GenerateCommandOfMove(target);
			}

			// Token: 0x060033F9 RID: 13305 RVA: 0x000DE20C File Offset: 0x000DC40C
			public GridPosition FindPositionToMoveToTarget(GridPosition target)
			{
				return this.m_owner.FindPositionToMoveToTarget(target);
			}

			// Token: 0x060033FA RID: 13306 RVA: 0x000DE21C File Offset: 0x000DC41C
			public int ComputeRestrictScore(BattleActor srcActor, BattleActor destActor)
			{
				return this.m_owner.ComputeRestrictScore(srcActor, destActor);
			}

			// Token: 0x060033FB RID: 13307 RVA: 0x000DE22C File Offset: 0x000DC42C
			public int GetArmyRistrictScore(ArmyTag a, ArmyTag b)
			{
				return this.m_owner.GetArmyRistrictScore(a, b);
			}

			// Token: 0x060033FC RID: 13308 RVA: 0x000DE23C File Offset: 0x000DC43C
			public BattleActor DefaultSelectDamageSkillTarget(List<BattleActor> actors)
			{
				return this.m_owner.DefaultSelectDamageSkillTarget(actors);
			}

			// Token: 0x060033FD RID: 13309 RVA: 0x000DE24C File Offset: 0x000DC44C
			public bool IsSelectRangeSkill()
			{
				return this.m_owner.IsSelectRangeSkill();
			}

			// Token: 0x060033FE RID: 13310 RVA: 0x000DE25C File Offset: 0x000DC45C
			public List<BattleActor> FindActorsInGrids(List<BattleActor> actors, List<GridPosition> grids)
			{
				return this.m_owner.FindActorsInGrids(actors, grids);
			}

			// Token: 0x060033FF RID: 13311 RVA: 0x000DE26C File Offset: 0x000DC46C
			public GridPosition FindMaxAoeSkillCoverPosition(ConfigDataSkillInfo si, List<GridPosition> asCenterPositions, List<BattleActor> beCoveredActors, ClassValue<int> maxCoverActorsCount)
			{
				return this.m_owner.FindMaxAoeSkillCoverPosition(si, asCenterPositions, beCoveredActors, maxCoverActorsCount);
			}

			// Token: 0x06003400 RID: 13312 RVA: 0x000DE280 File Offset: 0x000DC480
			public BattleActor FindMaxAoeSkillCoverActor(ConfigDataSkillInfo si, List<BattleActor> asCenterActors, List<BattleActor> beCoveredActors, ClassValue<int> maxCoverActorsCount)
			{
				return this.m_owner.FindMaxAoeSkillCoverActor(si, asCenterActors, beCoveredActors, maxCoverActorsCount);
			}

			// Token: 0x06003401 RID: 13313 RVA: 0x000DE294 File Offset: 0x000DC494
			public void DefaultSelectAttackTarget()
			{
				this.m_owner.DefaultSelectAttackTarget();
			}

			// Token: 0x06003402 RID: 13314 RVA: 0x000DE2A4 File Offset: 0x000DC4A4
			public List<GridPosition> FindGridsLessEqualDistance(GridPosition startPos, int dist)
			{
				return this.m_owner.FindGridsLessEqualDistance(startPos, dist);
			}

			// Token: 0x06003403 RID: 13315 RVA: 0x000DE2B4 File Offset: 0x000DC4B4
			public List<BattleActor> FindActorsLessEqualDistance(List<BattleActor> actors, GridPosition startPos, int dist)
			{
				return this.m_owner.FindActorsLessEqualDistance(actors, startPos, dist);
			}

			// Token: 0x06003404 RID: 13316 RVA: 0x000DE2C4 File Offset: 0x000DC4C4
			public BattleActor DefaultSelectHealSkillTarget(List<BattleActor> actors)
			{
				return this.m_owner.DefaultSelectHealSkillTarget(actors);
			}

			// Token: 0x06003405 RID: 13317 RVA: 0x000DE2D4 File Offset: 0x000DC4D4
			public BattleActor DefaultSelectBuffSkillTarget(List<BattleActor> actors, ConfigDataSkillInfo skill)
			{
				return this.m_owner.DefaultSelectBuffSkillTarget(actors, skill);
			}

			// Token: 0x06003406 RID: 13318 RVA: 0x000DE2E4 File Offset: 0x000DC4E4
			public void SelectAttackTargetInSkillRange()
			{
				this.m_owner.SelectAttackTargetInSkillRange();
			}

			// Token: 0x06003407 RID: 13319 RVA: 0x000DE2F4 File Offset: 0x000DC4F4
			public List<BattleActor> FindActorsWithBuffN(List<BattleActor> actors, int buffID)
			{
				return this.m_owner.FindActorsWithBuffN(actors, buffID);
			}

			// Token: 0x06003408 RID: 13320 RVA: 0x000DE304 File Offset: 0x000DC504
			public void SelectAttackTarget()
			{
				this.m_owner.SelectAttackTarget();
			}

			// Token: 0x06003409 RID: 13321 RVA: 0x000DE314 File Offset: 0x000DC514
			public void SelectSkill()
			{
				this.m_owner.SelectSkill();
			}

			// Token: 0x0600340A RID: 13322 RVA: 0x000DE324 File Offset: 0x000DC524
			public void SelectSkillDirectReachTarget()
			{
				this.m_owner.SelectSkillDirectReachTarget();
			}

			// Token: 0x0600340B RID: 13323 RVA: 0x000DE334 File Offset: 0x000DC534
			public static bool HasInt(int value, int[] arr)
			{
				return BattleActor.HasInt(value, arr);
			}

			// Token: 0x0600340C RID: 13324 RVA: 0x000DE340 File Offset: 0x000DC540
			public void DefaultSelectSkill(int[] includeSkillIDs, int[] excludeSkillIDs)
			{
				this.m_owner.DefaultSelectSkill(includeSkillIDs, excludeSkillIDs);
			}

			// Token: 0x0600340D RID: 13325 RVA: 0x000DE350 File Offset: 0x000DC550
			public List<BattleActor> FindActorsInCanNormalAttackAndTouchRange(List<BattleActor> destActors, List<BattleActor> srcActors)
			{
				return this.m_owner.FindActorsInCanNormalAttackAndTouchRange(destActors, srcActors);
			}

			// Token: 0x0600340E RID: 13326 RVA: 0x000DE360 File Offset: 0x000DC560
			public bool IsSkillAGoodAISelection(ConfigDataSkillInfo si)
			{
				return this.m_owner.IsSkillAGoodAISelection(si);
			}

			// Token: 0x0600340F RID: 13327 RVA: 0x000DE370 File Offset: 0x000DC570
			public GridPosition FindCastSkillPosition(ConfigDataSkillInfo si, BehaviorTarget t)
			{
				return this.m_owner.FindCastSkillPosition(si, t);
			}

			// Token: 0x06003410 RID: 13328 RVA: 0x000DE380 File Offset: 0x000DC580
			public void FindAttackPositions(int attackDistance, int shape, GridPosition targetPos, List<GridPosition> positions)
			{
				this.m_owner.FindAttackPositions(attackDistance, shape, targetPos, positions);
			}

			// Token: 0x06003411 RID: 13329 RVA: 0x000DE394 File Offset: 0x000DC594
			public void GenerateCommandOfAttack()
			{
				this.m_owner.GenerateCommandOfAttack();
			}

			// Token: 0x06003412 RID: 13330 RVA: 0x000DE3A4 File Offset: 0x000DC5A4
			public void DoBehaviorMove()
			{
				this.m_owner.DoBehaviorMove();
			}

			// Token: 0x06003413 RID: 13331 RVA: 0x000DE3B4 File Offset: 0x000DC5B4
			public bool IsAttackTargetStillValid()
			{
				return this.m_owner.IsAttackTargetStillValid();
			}

			// Token: 0x06003414 RID: 13332 RVA: 0x000DE3C4 File Offset: 0x000DC5C4
			public void DoBehaviorAttack()
			{
				this.m_owner.DoBehaviorAttack();
			}

			// Token: 0x06003415 RID: 13333 RVA: 0x000DE3D4 File Offset: 0x000DC5D4
			public BattleCommand AICreateBattleCommand(BattleCommandType type)
			{
				return this.m_owner.AICreateBattleCommand(type);
			}

			// Token: 0x06003416 RID: 13334 RVA: 0x000DE3E4 File Offset: 0x000DC5E4
			public BattleActor SelectAttackRegionTarget(BattleTeam team, BattleActor.ComputeActorScoreFunc computeScore, int computeScoreParam)
			{
				return this.m_owner.SelectAttackRegionTarget(team, computeScore, computeScoreParam);
			}

			// Token: 0x06003417 RID: 13335 RVA: 0x000DE3F4 File Offset: 0x000DC5F4
			public void InitializeBuffs()
			{
				this.m_owner.InitializeBuffs();
			}

			// Token: 0x06003418 RID: 13336 RVA: 0x000DE404 File Offset: 0x000DC604
			public void AttachPassiveSkillBuffs(ConfigDataSkillInfo skillInfo, BuffSourceType sourceType)
			{
				this.m_owner.AttachPassiveSkillBuffs(skillInfo, sourceType);
			}

			// Token: 0x06003419 RID: 13337 RVA: 0x000DE414 File Offset: 0x000DC614
			public static int CompareBuffOrder(BuffState b0, BuffState b1)
			{
				return BattleActor.CompareBuffOrder(b0, b1);
			}

			// Token: 0x0600341A RID: 13338 RVA: 0x000DE420 File Offset: 0x000DC620
			public bool RemoveBuff(BuffState bs)
			{
				return this.m_owner.RemoveBuff(bs);
			}

			// Token: 0x0600341B RID: 13339 RVA: 0x000DE430 File Offset: 0x000DC630
			public int RemoveBuffList(List<int> buffIds, BattleActor applyer)
			{
				return this.m_owner.RemoveBuffList(buffIds, applyer);
			}

			// Token: 0x0600341C RID: 13340 RVA: 0x000DE440 File Offset: 0x000DC640
			public BuffState FindBuff(int buffId, BattleActor applyer)
			{
				return this.m_owner.FindBuff(buffId, applyer);
			}

			// Token: 0x0600341D RID: 13341 RVA: 0x000DE450 File Offset: 0x000DC650
			public void RemoveAllBuffs()
			{
				this.m_owner.RemoveAllBuffs();
			}

			// Token: 0x0600341E RID: 13342 RVA: 0x000DE460 File Offset: 0x000DC660
			public bool HasBuff(int buffId)
			{
				return this.m_owner.HasBuff(buffId);
			}

			// Token: 0x0600341F RID: 13343 RVA: 0x000DE470 File Offset: 0x000DC670
			public void CollectBuffPropertyModifiersAndFightTags(BattlePropertyModifier pm, ref uint fightTags)
			{
				this.m_owner.CollectBuffPropertyModifiersAndFightTags(pm, ref fightTags);
			}

			// Token: 0x06003420 RID: 13344 RVA: 0x000DE480 File Offset: 0x000DC680
			public void CollectPropertyModifier(BattlePropertyModifier pm, PropertyModifyType modifyType, int value, bool collectStatic, bool collectDynamic)
			{
				this.m_owner.CollectPropertyModifier(pm, modifyType, value, collectStatic, collectDynamic);
			}

			// Token: 0x06003421 RID: 13345 RVA: 0x000DE494 File Offset: 0x000DC694
			public void CollectOtherActorBuffPropertyModifiersAndFightTags(BattlePropertyModifier pm, ref uint fightTags)
			{
				this.m_owner.CollectOtherActorBuffPropertyModifiersAndFightTags(pm, ref fightTags);
			}

			// Token: 0x06003422 RID: 13346 RVA: 0x000DE4A4 File Offset: 0x000DC6A4
			public void CollectBuffPropertyModifiersAndFightTagsInCombat(BattlePropertyModifier pm, ref uint fightTags, BattleActor target, bool isAttacker, int distance)
			{
				this.m_owner.CollectBuffPropertyModifiersAndFightTagsInCombat(pm, ref fightTags, target, isAttacker, distance);
			}

			// Token: 0x06003423 RID: 13347 RVA: 0x000DE4B8 File Offset: 0x000DC6B8
			public void RemoveAuraAppliedBuffs(ConfigDataBuffInfo auraBuffInfo)
			{
				this.m_owner.RemoveAuraAppliedBuffs(auraBuffInfo);
			}

			// Token: 0x06003424 RID: 13348 RVA: 0x000DE4C8 File Offset: 0x000DC6C8
			public void RemovePackChildBuffs(BuffState packBuff)
			{
				this.m_owner.RemovePackChildBuffs(packBuff);
			}

			// Token: 0x06003425 RID: 13349 RVA: 0x000DE4D8 File Offset: 0x000DC6D8
			public void OnBuffHit(BuffState buffState, int heroHpModify, int soldierHpModify, DamageNumberType damageNumberType)
			{
				this.m_owner.OnBuffHit(buffState, heroHpModify, soldierHpModify, damageNumberType);
			}

			// Token: 0x06003426 RID: 13350 RVA: 0x000DE4EC File Offset: 0x000DC6EC
			public void UpdateBuffTypes()
			{
				this.m_owner.UpdateBuffTypes();
			}

			// Token: 0x06003427 RID: 13351 RVA: 0x000DE4FC File Offset: 0x000DC6FC
			public void SetBuffType(BuffType bt, bool on)
			{
				this.m_owner.SetBuffType(bt, on);
			}

			// Token: 0x06003428 RID: 13352 RVA: 0x000DE50C File Offset: 0x000DC70C
			public bool IsBuffHpConditionSatisfied(ConfigDataBuffInfo buffInfo)
			{
				return this.m_owner.IsBuffHpConditionSatisfied(buffInfo);
			}

			// Token: 0x06003429 RID: 13353 RVA: 0x000DE51C File Offset: 0x000DC71C
			public bool IsBuffHpConditionSatisfied(int operatorType, int value, int targetType)
			{
				return this.m_owner.IsBuffHpConditionSatisfied(operatorType, value, targetType);
			}

			// Token: 0x0600342A RID: 13354 RVA: 0x000DE52C File Offset: 0x000DC72C
			public bool IsBuffEffectiveConditionSatisfied(ConfigDataBuffInfo buffInfo)
			{
				return this.m_owner.IsBuffEffectiveConditionSatisfied(buffInfo);
			}

			// Token: 0x0600342B RID: 13355 RVA: 0x000DE53C File Offset: 0x000DC73C
			public bool IsBuffCombatConditionSatisfied(BattleActor target, bool isAttacker, int distance, int param1, int param2, int param3)
			{
				return this.m_owner.IsBuffCombatConditionSatisfied(target, isAttacker, distance, param1, param2, param3);
			}

			// Token: 0x0600342C RID: 13356 RVA: 0x000DE554 File Offset: 0x000DC754
			public bool IsBuffCombatConditionSatisfied(BattleActor target, bool beforeCombat, bool isAttacker, int distance, bool isCritical, List<int> paramList)
			{
				return this.m_owner.IsBuffCombatConditionSatisfied(target, beforeCombat, isAttacker, distance, isCritical, paramList);
			}

			// Token: 0x0600342D RID: 13357 RVA: 0x000DE56C File Offset: 0x000DC76C
			public int ComputeNeighborAliveActorCount(int teamType, int distance)
			{
				return this.m_owner.ComputeNeighborAliveActorCount(teamType, distance);
			}

			// Token: 0x0600342E RID: 13358 RVA: 0x000DE57C File Offset: 0x000DC77C
			public bool IsBuffCooldown(BuffState bs)
			{
				return this.m_owner.IsBuffCooldown(bs);
			}

			// Token: 0x0600342F RID: 13359 RVA: 0x000DE58C File Offset: 0x000DC78C
			public void StartBuffCooldown(BuffState bs)
			{
				this.m_owner.StartBuffCooldown(bs);
			}

			// Token: 0x06003430 RID: 13360 RVA: 0x000DE59C File Offset: 0x000DC79C
			public int ComputeBuffCount(int buffId)
			{
				return this.m_owner.ComputeBuffCount(buffId);
			}

			// Token: 0x06003431 RID: 13361 RVA: 0x000DE5AC File Offset: 0x000DC7AC
			public int ComputeEnhanceOrDebuffCount(int enhanceDebuffType)
			{
				return this.m_owner.ComputeEnhanceOrDebuffCount(enhanceDebuffType);
			}

			// Token: 0x06003432 RID: 13362 RVA: 0x000DE5BC File Offset: 0x000DC7BC
			public bool IsImmuneBuffSubType(int subType)
			{
				return this.m_owner.IsImmuneBuffSubType(subType);
			}

			// Token: 0x06003433 RID: 13363 RVA: 0x000DE5CC File Offset: 0x000DC7CC
			public void ActionEndBuffEffect()
			{
				this.m_owner.ActionEndBuffEffect();
			}

			// Token: 0x06003434 RID: 13364 RVA: 0x000DE5DC File Offset: 0x000DC7DC
			public void UpdateBuffTime()
			{
				this.m_owner.UpdateBuffTime();
			}

			// Token: 0x06003435 RID: 13365 RVA: 0x000DE5EC File Offset: 0x000DC7EC
			public void ActionEndBuffHealOverTime(bool isDamage)
			{
				this.m_owner.ActionEndBuffHealOverTime(isDamage);
			}

			// Token: 0x06003436 RID: 13366 RVA: 0x000DE5FC File Offset: 0x000DC7FC
			public void ActionEndBuffDamageOverTime()
			{
				this.m_owner.ActionEndBuffDamageOverTime();
			}

			// Token: 0x06003437 RID: 13367 RVA: 0x000DE60C File Offset: 0x000DC80C
			public void ActionEndAddBuff()
			{
				this.m_owner.ActionEndAddBuff();
			}

			// Token: 0x06003438 RID: 13368 RVA: 0x000DE61C File Offset: 0x000DC81C
			public void ActionEndAddBuffSuper(bool isKill, bool isCritical)
			{
				this.m_owner.ActionEndAddBuffSuper(isKill, isCritical);
			}

			// Token: 0x06003439 RID: 13369 RVA: 0x000DE62C File Offset: 0x000DC82C
			public void ActionEndRemoveDebuff()
			{
				this.m_owner.ActionEndRemoveDebuff();
			}

			// Token: 0x0600343A RID: 13370 RVA: 0x000DE63C File Offset: 0x000DC83C
			public void ActionEndRemoveEnhanceBuff(bool isKill, bool isCritical, bool isDamage)
			{
				this.m_owner.ActionEndRemoveEnhanceBuff(isKill, isCritical, isDamage);
			}

			// Token: 0x0600343B RID: 13371 RVA: 0x000DE64C File Offset: 0x000DC84C
			public void ActionEndBuffBattlefieldSkill(bool isKill, bool isCritical, bool isDamage)
			{
				this.m_owner.ActionEndBuffBattlefieldSkill(isKill, isCritical, isDamage);
			}

			// Token: 0x0600343C RID: 13372 RVA: 0x000DE65C File Offset: 0x000DC85C
			public void ActionEndBuffNewTurn(bool isKill, bool isCritical)
			{
				this.m_owner.ActionEndBuffNewTurn(isKill, isCritical);
			}

			// Token: 0x0600343D RID: 13373 RVA: 0x000DE66C File Offset: 0x000DC86C
			public static int CompareHealActor(BattleActor a0, BattleActor a1)
			{
				return BattleActor.CompareHealActor(a0, a1);
			}

			// Token: 0x0600343E RID: 13374 RVA: 0x000DE678 File Offset: 0x000DC878
			public bool CanBuffGuard(BattleActor target, ConfigDataSkillInfo skillInfo)
			{
				return this.m_owner.CanBuffGuard(target, skillInfo);
			}

			// Token: 0x0600343F RID: 13375 RVA: 0x000DE688 File Offset: 0x000DC888
			public bool IsSkillUseable(int skillIndex)
			{
				return this.m_owner.IsSkillUseable(skillIndex);
			}

			// Token: 0x06003440 RID: 13376 RVA: 0x000DE698 File Offset: 0x000DC898
			public void FindBattlefieldSkillApplyTargets(ConfigDataSkillInfo skillInfo, GridPosition targetPos, List<BattleActor> targetActors)
			{
				this.m_owner.FindBattlefieldSkillApplyTargets(skillInfo, targetPos, targetActors);
			}

			// Token: 0x06003441 RID: 13377 RVA: 0x000DE6A8 File Offset: 0x000DC8A8
			public bool ExecuteBattlefieldSkill(ConfigDataSkillInfo skillInfo, GridPosition p, GridPosition p2)
			{
				return this.m_owner.ExecuteBattlefieldSkill(skillInfo, p, p2);
			}

			// Token: 0x06003442 RID: 13378 RVA: 0x000DE6B8 File Offset: 0x000DC8B8
			public bool SkillAttack(ConfigDataSkillInfo skillInfo, BattleActor target)
			{
				return this.m_owner.SkillAttack(skillInfo, target);
			}

			// Token: 0x06003443 RID: 13379 RVA: 0x000DE6C8 File Offset: 0x000DC8C8
			public bool SkillSummon(ConfigDataSkillInfo skillInfo, GridPosition p)
			{
				return this.m_owner.SkillSummon(skillInfo, p);
			}

			// Token: 0x06003444 RID: 13380 RVA: 0x000DE6D8 File Offset: 0x000DC8D8
			public bool SkillTeleport(ConfigDataSkillInfo skillInfo, BattleActor target, GridPosition teleportPos)
			{
				return this.m_owner.SkillTeleport(skillInfo, target, teleportPos);
			}

			// Token: 0x06003445 RID: 13381 RVA: 0x000DE6E8 File Offset: 0x000DC8E8
			public void AttackBy(BattleActor attacker, ConfigDataSkillInfo skillInfo)
			{
				this.m_owner.AttackBy(attacker, skillInfo);
			}

			// Token: 0x06003446 RID: 13382 RVA: 0x000DE6F8 File Offset: 0x000DC8F8
			public void SkillAttackEnd(ConfigDataSkillInfo skillInfo, List<BattleActor> targets)
			{
				this.m_owner.SkillAttackEnd(skillInfo, targets);
			}

			// Token: 0x06003447 RID: 13383 RVA: 0x000DE708 File Offset: 0x000DC908
			public void TeleportBy(BattleActor attacker, ConfigDataSkillInfo skillInfo, GridPosition p)
			{
				this.m_owner.TeleportBy(attacker, skillInfo, p);
			}

			// Token: 0x06003448 RID: 13384 RVA: 0x000DE718 File Offset: 0x000DC918
			public void SummonBy(BattleActor attacker, ConfigDataSkillInfo skillInfo, GridPosition p)
			{
				this.m_owner.SummonBy(attacker, skillInfo, p);
			}

			// Token: 0x06003449 RID: 13385 RVA: 0x000DE728 File Offset: 0x000DC928
			public ConfigDataSkillInfo GetHeroAttackSkillInfo(bool isMelee)
			{
				return this.m_owner.GetHeroAttackSkillInfo(isMelee);
			}

			// Token: 0x0600344A RID: 13386 RVA: 0x000DE738 File Offset: 0x000DC938
			public ConfigDataSkillInfo GetSoldierAttackSkillInfo(bool isMelee)
			{
				return this.m_owner.GetSoldierAttackSkillInfo(isMelee);
			}

			// Token: 0x040027EA RID: 10218
			private BattleActor m_owner;
		}
	}
}
