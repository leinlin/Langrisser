using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x020003AF RID: 943
	[HotFix]
	public class BattleTeam
	{
		// Token: 0x06003731 RID: 14129 RVA: 0x000F6D30 File Offset: 0x000F4F30
		public BattleTeam(BattleBase battle, int teamNumer)
		{
			this.m_battle = battle;
			this.m_teamNumber = teamNumer;
			this.m_actors = new List<BattleActor>();
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctorBattleBaseInt32_hotfix != null)
			{
				this.m_ctorBattleBaseInt32_hotfix.call(new object[]
				{
					this,
					battle,
					teamNumer
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06003732 RID: 14130 RVA: 0x000F6DE8 File Offset: 0x000F4FE8
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
			EntityList.RemoveDeleted<BattleActor>(this.m_actors);
		}

		// Token: 0x06003733 RID: 14131 RVA: 0x000F6E54 File Offset: 0x000F5054
		public BattleActor CreateActor()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateActor_hotfix != null)
			{
				return (BattleActor)this.m_CreateActor_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleActor battleActor = new BattleActor();
			this.m_actors.Add(battleActor);
			return battleActor;
		}

		// Token: 0x06003734 RID: 14132 RVA: 0x000F6ED4 File Offset: 0x000F50D4
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
			EntityList.RemoveAll<BattleActor>(this.m_actors);
		}

		// Token: 0x06003735 RID: 14133 RVA: 0x000F6F40 File Offset: 0x000F5140
		public List<BattleActor> GetActors()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetActors_hotfix != null)
			{
				return (List<BattleActor>)this.m_GetActors_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_actors;
		}

		// Token: 0x06003736 RID: 14134 RVA: 0x000F6FB4 File Offset: 0x000F51B4
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
			foreach (BattleActor battleActor in this.m_actors)
			{
				if (battleActor.Id == id)
				{
					return battleActor;
				}
			}
			return null;
		}

		// Token: 0x06003737 RID: 14135 RVA: 0x000F7090 File Offset: 0x000F5290
		public BattleActor GetActorByHeroId(int heroId, bool ignoreDead = false)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetActorByHeroIdInt32Boolean_hotfix != null)
			{
				return (BattleActor)this.m_GetActorByHeroIdInt32Boolean_hotfix.call(new object[]
				{
					this,
					heroId,
					ignoreDead
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleActor battleActor in this.m_actors)
			{
				if (!ignoreDead || !battleActor.IsDeadOrRetreat())
				{
					if (battleActor.HeroId == heroId)
					{
						return battleActor;
					}
				}
			}
			return null;
		}

		// Token: 0x06003738 RID: 14136 RVA: 0x000F7190 File Offset: 0x000F5390
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
			this.m_deadActorCount = 0;
			this.m_initNotNpcActorCount = 0;
			foreach (BattleActor battleActor in this.m_actors)
			{
				if (!battleActor.IsNpc())
				{
					this.m_initNotNpcActorCount++;
				}
			}
			foreach (BattleActor battleActor2 in this.m_actors)
			{
				battleActor2.StartBattle();
			}
		}

		// Token: 0x06003739 RID: 14137 RVA: 0x000F72AC File Offset: 0x000F54AC
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
			foreach (BattleActor battleActor in this.m_actors)
			{
				battleActor.StopBattle(win);
			}
		}

		// Token: 0x0600373A RID: 14138 RVA: 0x000F736C File Offset: 0x000F556C
		public bool HasAliveActor()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasAliveActor_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasAliveActor_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleActor battleActor in this.m_actors)
			{
				if (!battleActor.IsDeadOrRetreat())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600373B RID: 14139 RVA: 0x000F7438 File Offset: 0x000F5638
		public bool HasNotActionFinishedActor()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasNotActionFinishedActor_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasNotActionFinishedActor_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleActor battleActor in this.m_actors)
			{
				if (!battleActor.IsDeadOrRetreat() && !battleActor.IsActionFinished())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600373C RID: 14140 RVA: 0x000F750C File Offset: 0x000F570C
		public bool HasFinishActionNpcActor()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasFinishActionNpcActor_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasFinishActionNpcActor_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleActor battleActor in this.m_actors)
			{
				if (!battleActor.IsDeadOrRetreat() && battleActor.IsAINpc() && battleActor.IsActionFinished())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600373D RID: 14141 RVA: 0x000F75EC File Offset: 0x000F57EC
		public BattleTeam GetOtherTeam()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetOtherTeam_hotfix != null)
			{
				return (BattleTeam)this.m_GetOtherTeam_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_teamNumber == 0)
			{
				return this.m_battle.GetTeam(1);
			}
			return this.m_battle.GetTeam(0);
		}

		// Token: 0x0600373E RID: 14142 RVA: 0x000F767C File Offset: 0x000F587C
		public void OnMyActorDie(BattleActor actor)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMyActorDieBattleActor_hotfix != null)
			{
				this.m_OnMyActorDieBattleActor_hotfix.call(new object[]
				{
					this,
					actor
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!actor.IsSummoned())
			{
				this.m_deadActorCount++;
			}
			this.m_battle.OnActorDie(actor);
		}

		// Token: 0x0600373F RID: 14143 RVA: 0x000F7714 File Offset: 0x000F5914
		public void OnMyActorRetreat(BattleActor actor, int effectType, string fxName, bool notifyListener)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMyActorRetreatBattleActorInt32StringBoolean_hotfix != null)
			{
				this.m_OnMyActorRetreatBattleActorInt32StringBoolean_hotfix.call(new object[]
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
			this.m_battle.OnActorRetreat(actor, effectType, fxName, notifyListener);
		}

		// Token: 0x06003740 RID: 14144 RVA: 0x000F77C4 File Offset: 0x000F59C4
		public int ComputeDeadActorCount(List<int> heroIds, NpcCondition npcCondition)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeDeadActorCountList`1NpcCondition_hotfix != null)
			{
				return Convert.ToInt32(this.m_ComputeDeadActorCountList`1NpcCondition_hotfix.call(new object[]
				{
					this,
					heroIds,
					npcCondition
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			foreach (BattleActor battleActor in this.m_actors)
			{
				if (battleActor.IsDead() && !battleActor.IsSummoned())
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
					if (heroIds != null && heroIds.Count > 0)
					{
						if (heroIds.Contains(battleActor.HeroId))
						{
							num++;
						}
					}
					else
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x06003741 RID: 14145 RVA: 0x000F7914 File Offset: 0x000F5B14
		public int ComputeAliveActorCount(List<int> heroIds, NpcCondition npcCondition)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeAliveActorCountList`1NpcCondition_hotfix != null)
			{
				return Convert.ToInt32(this.m_ComputeAliveActorCountList`1NpcCondition_hotfix.call(new object[]
				{
					this,
					heroIds,
					npcCondition
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			foreach (BattleActor battleActor in this.m_actors)
			{
				if (!battleActor.IsDeadOrRetreat() && !battleActor.IsSummoned())
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
					if (heroIds != null && heroIds.Count > 0)
					{
						if (heroIds.Contains(battleActor.HeroId))
						{
							num++;
						}
					}
					else
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x06003742 RID: 14146 RVA: 0x000F7A64 File Offset: 0x000F5C64
		public bool IsGroupDie(int groupId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsGroupDieInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsGroupDieInt32_hotfix.call(new object[]
				{
					this,
					groupId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			foreach (BattleActor battleActor in this.m_actors)
			{
				if (battleActor.GroupId == groupId)
				{
					if (!battleActor.IsDeadOrRetreat())
					{
						return false;
					}
					num++;
				}
			}
			return num > 0;
		}

		// Token: 0x06003743 RID: 14147 RVA: 0x000F7B54 File Offset: 0x000F5D54
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
			foreach (BattleActor battleActor in this.m_actors)
			{
				battleActor.NextTurn();
			}
		}

		// Token: 0x17000F2F RID: 3887
		// (get) Token: 0x06003744 RID: 14148 RVA: 0x000F7C04 File Offset: 0x000F5E04
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

		// Token: 0x17000F30 RID: 3888
		// (get) Token: 0x06003745 RID: 14149 RVA: 0x000F7C78 File Offset: 0x000F5E78
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

		// Token: 0x17000F31 RID: 3889
		// (get) Token: 0x06003746 RID: 14150 RVA: 0x000F7CEC File Offset: 0x000F5EEC
		public int InitNotNpcActorCount
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_InitNotNpcActorCount_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_InitNotNpcActorCount_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_initNotNpcActorCount;
			}
		}

		// Token: 0x17000F32 RID: 3890
		// (get) Token: 0x06003747 RID: 14151 RVA: 0x000F7D60 File Offset: 0x000F5F60
		public int DeadActorCount
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_DeadActorCount_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_DeadActorCount_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_deadActorCount;
			}
		}

		// Token: 0x06003748 RID: 14152 RVA: 0x000F7DD4 File Offset: 0x000F5FD4
		public void SetGroupBehaviorDict(Dictionary<int, int> behaviors)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGroupBehaviorDictDictionary`2_hotfix != null)
			{
				this.m_SetGroupBehaviorDictDictionary`2_hotfix.call(new object[]
				{
					this,
					behaviors
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_groupBehaviorDict = behaviors;
		}

		// Token: 0x06003749 RID: 14153 RVA: 0x000F7E4C File Offset: 0x000F604C
		public void AddGroupBehaviors(Dictionary<int, int> behaviors)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddGroupBehaviorsDictionary`2_hotfix != null)
			{
				this.m_AddGroupBehaviorsDictionary`2_hotfix.call(new object[]
				{
					this,
					behaviors
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (behaviors == null)
			{
				return;
			}
			if (this.m_groupBehaviorDict == null)
			{
				this.m_groupBehaviorDict = new Dictionary<int, int>();
			}
			foreach (KeyValuePair<int, int> keyValuePair in behaviors)
			{
				this.m_groupBehaviorDict[keyValuePair.Key] = keyValuePair.Value;
			}
		}

		// Token: 0x0600374A RID: 14154 RVA: 0x000F7F38 File Offset: 0x000F6138
		public void CreateGroups()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateGroups_hotfix != null)
			{
				this.m_CreateGroups_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_groups.Clear();
			foreach (BattleActor battleActor in this.m_actors)
			{
				BehaviorGroup behaviorGroup = this.GetGroup(battleActor.GroupId);
				if (behaviorGroup == null)
				{
					behaviorGroup = this.CreateGroup(battleActor.GroupId);
					if (behaviorGroup == null)
					{
						if (this.Battle.IsEnableDebugLog())
						{
							DebugUtility.LogError(string.Format("Failed to creat group: {0}.", battleActor.GroupId));
						}
						return;
					}
				}
				behaviorGroup.AddActor(battleActor);
			}
			this.m_groups.Sort((BehaviorGroup a, BehaviorGroup b) => a.ID - b.ID);
			foreach (BehaviorGroup behaviorGroup2 in this.m_groups)
			{
				int bahvior;
				if (this.m_groupBehaviorDict != null && this.m_groupBehaviorDict.TryGetValue(behaviorGroup2.ID, out bahvior))
				{
					behaviorGroup2.SetBahvior(bahvior);
				}
			}
		}

		// Token: 0x0600374B RID: 14155 RVA: 0x000F80E0 File Offset: 0x000F62E0
		private BehaviorGroup GetGroup(int groupID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetGroupInt32_hotfix != null)
			{
				return (BehaviorGroup)this.m_GetGroupInt32_hotfix.call(new object[]
				{
					this,
					groupID
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_groups == null)
			{
				return null;
			}
			foreach (BehaviorGroup behaviorGroup in this.m_groups)
			{
				if (behaviorGroup.ID == groupID)
				{
					return behaviorGroup;
				}
			}
			return null;
		}

		// Token: 0x0600374C RID: 14156 RVA: 0x000F81C8 File Offset: 0x000F63C8
		private BehaviorGroup CreateGroup(int id)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateGroupInt32_hotfix != null)
			{
				return (BehaviorGroup)this.m_CreateGroupInt32_hotfix.call(new object[]
				{
					this,
					id
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BehaviorGroup behaviorGroup = this.GetGroup(id);
			if (behaviorGroup != null)
			{
				if (this.Battle.IsEnableDebugLog())
				{
					DebugUtility.LogError(string.Format("group {0} already exist.", id));
				}
				return behaviorGroup;
			}
			behaviorGroup = new BehaviorGroup(id, this);
			this.m_groups.Add(behaviorGroup);
			return behaviorGroup;
		}

		// Token: 0x0600374D RID: 14157 RVA: 0x000F8290 File Offset: 0x000F6490
		public void DoGroupBehavior()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DoGroupBehavior_hotfix != null)
			{
				this.m_DoGroupBehavior_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BehaviorGroup behaviorGroup in this.m_groups)
			{
				behaviorGroup.DoBehavor();
			}
		}

		// Token: 0x0600374E RID: 14158 RVA: 0x000F8340 File Offset: 0x000F6540
		public void UpdateGroups()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateGroups_hotfix != null)
			{
				this.m_UpdateGroups_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleActor battleActor in this.m_actors)
			{
				if (battleActor.Group == null)
				{
					BehaviorGroup behaviorGroup = this.GetGroup(battleActor.GroupId);
					if (behaviorGroup == null)
					{
						behaviorGroup = this.CreateGroup(battleActor.GroupId);
						if (behaviorGroup == null)
						{
							if (this.Battle.IsEnableDebugLog())
							{
								DebugUtility.LogError(string.Format("Failed to creat group: {0}.", battleActor.GroupId));
							}
							return;
						}
					}
					behaviorGroup.AddActor(battleActor);
				}
			}
			this.m_groups.Sort((BehaviorGroup a, BehaviorGroup b) => a.ID - b.ID);
			foreach (BehaviorGroup behaviorGroup2 in this.m_groups)
			{
				int bahvior;
				if (this.m_groupBehaviorDict != null && this.m_groupBehaviorDict.TryGetValue(behaviorGroup2.ID, out bahvior))
				{
					behaviorGroup2.SetBahvior(bahvior);
				}
			}
			foreach (BehaviorGroup behaviorGroup3 in this.m_groups)
			{
				if (this.Battle.IsEnableDebugLog())
				{
					DebugUtility.Log(string.Format("!@# UpdateGroups() Team {0} Group {1} Behavior {2} Members count {3}", new object[]
					{
						this.TeamNumber,
						behaviorGroup3.ID,
						(behaviorGroup3.Behavior != null) ? behaviorGroup3.Behavior.ID : -1,
						behaviorGroup3.Actors.Count
					}));
				}
			}
		}

		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x0600374F RID: 14159 RVA: 0x000F85B0 File Offset: 0x000F67B0
		// (set) Token: 0x06003750 RID: 14160 RVA: 0x000F85D0 File Offset: 0x000F67D0
		[DoNotToLua]
		public BattleTeam.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleTeam.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06003753 RID: 14163 RVA: 0x000F85FC File Offset: 0x000F67FC
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
					this.m_ctorBattleBaseInt32_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_RemoveDeleted_hotfix = (luaObj.RawGet("RemoveDeleted") as LuaFunction);
					this.m_CreateActor_hotfix = (luaObj.RawGet("CreateActor") as LuaFunction);
					this.m_RemoveAll_hotfix = (luaObj.RawGet("RemoveAll") as LuaFunction);
					this.m_GetActors_hotfix = (luaObj.RawGet("GetActors") as LuaFunction);
					this.m_GetActorByIdInt32_hotfix = (luaObj.RawGet("GetActorById") as LuaFunction);
					this.m_GetActorByHeroIdInt32Boolean_hotfix = (luaObj.RawGet("GetActorByHeroId") as LuaFunction);
					this.m_StartBattle_hotfix = (luaObj.RawGet("StartBattle") as LuaFunction);
					this.m_StopBattleBoolean_hotfix = (luaObj.RawGet("StopBattle") as LuaFunction);
					this.m_HasAliveActor_hotfix = (luaObj.RawGet("HasAliveActor") as LuaFunction);
					this.m_HasNotActionFinishedActor_hotfix = (luaObj.RawGet("HasNotActionFinishedActor") as LuaFunction);
					this.m_HasFinishActionNpcActor_hotfix = (luaObj.RawGet("HasFinishActionNpcActor") as LuaFunction);
					this.m_GetOtherTeam_hotfix = (luaObj.RawGet("GetOtherTeam") as LuaFunction);
					this.m_OnMyActorDieBattleActor_hotfix = (luaObj.RawGet("OnMyActorDie") as LuaFunction);
					this.m_OnMyActorRetreatBattleActorInt32StringBoolean_hotfix = (luaObj.RawGet("OnMyActorRetreat") as LuaFunction);
					this.m_ComputeDeadActorCountList`1NpcCondition_hotfix = (luaObj.RawGet("ComputeDeadActorCount") as LuaFunction);
					this.m_ComputeAliveActorCountList`1NpcCondition_hotfix = (luaObj.RawGet("ComputeAliveActorCount") as LuaFunction);
					this.m_IsGroupDieInt32_hotfix = (luaObj.RawGet("IsGroupDie") as LuaFunction);
					this.m_NextTurn_hotfix = (luaObj.RawGet("NextTurn") as LuaFunction);
					this.m_get_Battle_hotfix = (luaObj.RawGet("get_Battle") as LuaFunction);
					this.m_get_TeamNumber_hotfix = (luaObj.RawGet("get_TeamNumber") as LuaFunction);
					this.m_get_InitNotNpcActorCount_hotfix = (luaObj.RawGet("get_InitNotNpcActorCount") as LuaFunction);
					this.m_get_DeadActorCount_hotfix = (luaObj.RawGet("get_DeadActorCount") as LuaFunction);
					this.m_SetGroupBehaviorDictDictionary`2_hotfix = (luaObj.RawGet("SetGroupBehaviorDict") as LuaFunction);
					this.m_AddGroupBehaviorsDictionary`2_hotfix = (luaObj.RawGet("AddGroupBehaviors") as LuaFunction);
					this.m_CreateGroups_hotfix = (luaObj.RawGet("CreateGroups") as LuaFunction);
					this.m_GetGroupInt32_hotfix = (luaObj.RawGet("GetGroup") as LuaFunction);
					this.m_CreateGroupInt32_hotfix = (luaObj.RawGet("CreateGroup") as LuaFunction);
					this.m_DoGroupBehavior_hotfix = (luaObj.RawGet("DoGroupBehavior") as LuaFunction);
					this.m_UpdateGroups_hotfix = (luaObj.RawGet("UpdateGroups") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06003754 RID: 14164 RVA: 0x000F899C File Offset: 0x000F6B9C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleTeam));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002A94 RID: 10900
		private int m_initNotNpcActorCount;

		// Token: 0x04002A95 RID: 10901
		private int m_deadActorCount;

		// Token: 0x04002A96 RID: 10902
		private List<BattleActor> m_actors;

		// Token: 0x04002A97 RID: 10903
		private BattleBase m_battle;

		// Token: 0x04002A98 RID: 10904
		private int m_teamNumber;

		// Token: 0x04002A99 RID: 10905
		private Dictionary<int, int> m_groupBehaviorDict = new Dictionary<int, int>();

		// Token: 0x04002A9A RID: 10906
		private List<BehaviorGroup> m_groups = new List<BehaviorGroup>();

		// Token: 0x04002A9B RID: 10907
		[DoNotToLua]
		private BattleTeam.LuaExportHelper luaExportHelper;

		// Token: 0x04002A9E RID: 10910
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002A9F RID: 10911
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002AA0 RID: 10912
		private LuaFunction m_ctorBattleBaseInt32_hotfix;

		// Token: 0x04002AA1 RID: 10913
		private LuaFunction m_RemoveDeleted_hotfix;

		// Token: 0x04002AA2 RID: 10914
		private LuaFunction m_CreateActor_hotfix;

		// Token: 0x04002AA3 RID: 10915
		private LuaFunction m_RemoveAll_hotfix;

		// Token: 0x04002AA4 RID: 10916
		private LuaFunction m_GetActors_hotfix;

		// Token: 0x04002AA5 RID: 10917
		private LuaFunction m_GetActorByIdInt32_hotfix;

		// Token: 0x04002AA6 RID: 10918
		private LuaFunction m_GetActorByHeroIdInt32Boolean_hotfix;

		// Token: 0x04002AA7 RID: 10919
		private LuaFunction m_StartBattle_hotfix;

		// Token: 0x04002AA8 RID: 10920
		private LuaFunction m_StopBattleBoolean_hotfix;

		// Token: 0x04002AA9 RID: 10921
		private LuaFunction m_HasAliveActor_hotfix;

		// Token: 0x04002AAA RID: 10922
		private LuaFunction m_HasNotActionFinishedActor_hotfix;

		// Token: 0x04002AAB RID: 10923
		private LuaFunction m_HasFinishActionNpcActor_hotfix;

		// Token: 0x04002AAC RID: 10924
		private LuaFunction m_GetOtherTeam_hotfix;

		// Token: 0x04002AAD RID: 10925
		private LuaFunction m_OnMyActorDieBattleActor_hotfix;

		// Token: 0x04002AAE RID: 10926
		private LuaFunction m_OnMyActorRetreatBattleActorInt32StringBoolean_hotfix;

		// Token: 0x04002AAF RID: 10927
		private LuaFunction m_ComputeDeadActorCountList;

		// Token: 0x04002AB0 RID: 10928
		private LuaFunction m_ComputeAliveActorCountList;

		// Token: 0x04002AB1 RID: 10929
		private LuaFunction m_IsGroupDieInt32_hotfix;

		// Token: 0x04002AB2 RID: 10930
		private LuaFunction m_NextTurn_hotfix;

		// Token: 0x04002AB3 RID: 10931
		private LuaFunction m_get_Battle_hotfix;

		// Token: 0x04002AB4 RID: 10932
		private LuaFunction m_get_TeamNumber_hotfix;

		// Token: 0x04002AB5 RID: 10933
		private LuaFunction m_get_InitNotNpcActorCount_hotfix;

		// Token: 0x04002AB6 RID: 10934
		private LuaFunction m_get_DeadActorCount_hotfix;

		// Token: 0x04002AB7 RID: 10935
		private LuaFunction m_SetGroupBehaviorDictDictionary;

		// Token: 0x04002AB8 RID: 10936
		private LuaFunction m_AddGroupBehaviorsDictionary;

		// Token: 0x04002AB9 RID: 10937
		private LuaFunction m_CreateGroups_hotfix;

		// Token: 0x04002ABA RID: 10938
		private LuaFunction m_GetGroupInt32_hotfix;

		// Token: 0x04002ABB RID: 10939
		private LuaFunction m_CreateGroupInt32_hotfix;

		// Token: 0x04002ABC RID: 10940
		private LuaFunction m_DoGroupBehavior_hotfix;

		// Token: 0x04002ABD RID: 10941
		private LuaFunction m_UpdateGroups_hotfix;

		// Token: 0x020003B0 RID: 944
		public class LuaExportHelper
		{
			// Token: 0x06003755 RID: 14165 RVA: 0x000F8A04 File Offset: 0x000F6C04
			public LuaExportHelper(BattleTeam owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17000F34 RID: 3892
			// (get) Token: 0x06003756 RID: 14166 RVA: 0x000F8A14 File Offset: 0x000F6C14
			// (set) Token: 0x06003757 RID: 14167 RVA: 0x000F8A24 File Offset: 0x000F6C24
			public int m_initNotNpcActorCount
			{
				get
				{
					return this.m_owner.m_initNotNpcActorCount;
				}
				set
				{
					this.m_owner.m_initNotNpcActorCount = value;
				}
			}

			// Token: 0x17000F35 RID: 3893
			// (get) Token: 0x06003758 RID: 14168 RVA: 0x000F8A34 File Offset: 0x000F6C34
			// (set) Token: 0x06003759 RID: 14169 RVA: 0x000F8A44 File Offset: 0x000F6C44
			public int m_deadActorCount
			{
				get
				{
					return this.m_owner.m_deadActorCount;
				}
				set
				{
					this.m_owner.m_deadActorCount = value;
				}
			}

			// Token: 0x17000F36 RID: 3894
			// (get) Token: 0x0600375A RID: 14170 RVA: 0x000F8A54 File Offset: 0x000F6C54
			// (set) Token: 0x0600375B RID: 14171 RVA: 0x000F8A64 File Offset: 0x000F6C64
			public List<BattleActor> m_actors
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

			// Token: 0x17000F37 RID: 3895
			// (get) Token: 0x0600375C RID: 14172 RVA: 0x000F8A74 File Offset: 0x000F6C74
			// (set) Token: 0x0600375D RID: 14173 RVA: 0x000F8A84 File Offset: 0x000F6C84
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

			// Token: 0x17000F38 RID: 3896
			// (get) Token: 0x0600375E RID: 14174 RVA: 0x000F8A94 File Offset: 0x000F6C94
			// (set) Token: 0x0600375F RID: 14175 RVA: 0x000F8AA4 File Offset: 0x000F6CA4
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

			// Token: 0x17000F39 RID: 3897
			// (get) Token: 0x06003760 RID: 14176 RVA: 0x000F8AB4 File Offset: 0x000F6CB4
			// (set) Token: 0x06003761 RID: 14177 RVA: 0x000F8AC4 File Offset: 0x000F6CC4
			public Dictionary<int, int> m_groupBehaviorDict
			{
				get
				{
					return this.m_owner.m_groupBehaviorDict;
				}
				set
				{
					this.m_owner.m_groupBehaviorDict = value;
				}
			}

			// Token: 0x17000F3A RID: 3898
			// (get) Token: 0x06003762 RID: 14178 RVA: 0x000F8AD4 File Offset: 0x000F6CD4
			// (set) Token: 0x06003763 RID: 14179 RVA: 0x000F8AE4 File Offset: 0x000F6CE4
			public List<BehaviorGroup> m_groups
			{
				get
				{
					return this.m_owner.m_groups;
				}
				set
				{
					this.m_owner.m_groups = value;
				}
			}

			// Token: 0x06003764 RID: 14180 RVA: 0x000F8AF4 File Offset: 0x000F6CF4
			public BehaviorGroup GetGroup(int groupID)
			{
				return this.m_owner.GetGroup(groupID);
			}

			// Token: 0x06003765 RID: 14181 RVA: 0x000F8B04 File Offset: 0x000F6D04
			public BehaviorGroup CreateGroup(int id)
			{
				return this.m_owner.CreateGroup(id);
			}

			// Token: 0x04002ABE RID: 10942
			private BattleTeam m_owner;
		}
	}
}
