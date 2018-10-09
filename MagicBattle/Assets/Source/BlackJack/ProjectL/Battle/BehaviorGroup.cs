using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x020003B1 RID: 945
	[HotFix]
	public class BehaviorGroup
	{
		// Token: 0x06003766 RID: 14182 RVA: 0x000F8B14 File Offset: 0x000F6D14
		public BehaviorGroup(int id, BattleTeam team)
		{
			this.m_ID = id;
			this.m_team = team;
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctorInt32BattleTeam_hotfix != null)
			{
				this.m_ctorInt32BattleTeam_hotfix.call(new object[]
				{
					this,
					id,
					team
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x06003767 RID: 14183 RVA: 0x000F8BC8 File Offset: 0x000F6DC8
		public int ID
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_ID_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_ID_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_ID;
			}
		}

		// Token: 0x06003768 RID: 14184 RVA: 0x000F8C3C File Offset: 0x000F6E3C
		public void AddActor(BattleActor actor)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddActorBattleActor_hotfix != null)
			{
				this.m_AddActorBattleActor_hotfix.call(new object[]
				{
					this,
					actor
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_actors.Add(actor);
			actor.Group = this;
		}

		// Token: 0x17000F3C RID: 3900
		// (get) Token: 0x06003769 RID: 14185 RVA: 0x000F8CC0 File Offset: 0x000F6EC0
		public BattleActor Leader
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Leader_hotfix != null)
				{
					return (BattleActor)this.m_get_Leader_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_leader;
			}
		}

		// Token: 0x0600376A RID: 14186 RVA: 0x000F8D34 File Offset: 0x000F6F34
		public void SetBahvior(int id)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBahviorInt32_hotfix != null)
			{
				this.m_SetBahviorInt32_hotfix.call(new object[]
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
			ConfigDataGroupBehavior configDataGroupBehavior = this.m_team.Battle.ConfigDataLoader.GetConfigDataGroupBehavior(id);
			if (configDataGroupBehavior == null)
			{
				if (this.m_team.Battle.IsEnableDebugLog())
				{
					DebugUtility.LogError(string.Format("Failed to find battle {0} 's group behavior {1}.", this.m_team.Battle.BattleInfo.ID, id));
				}
				return;
			}
			this.m_curBehaviorCfg = configDataGroupBehavior;
		}

		// Token: 0x17000F3D RID: 3901
		// (get) Token: 0x0600376B RID: 14187 RVA: 0x000F8E18 File Offset: 0x000F7018
		public ConfigDataGroupBehavior Behavior
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Behavior_hotfix != null)
				{
					return (ConfigDataGroupBehavior)this.m_get_Behavior_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_curBehaviorCfg;
			}
		}

		// Token: 0x17000F3E RID: 3902
		// (get) Token: 0x0600376C RID: 14188 RVA: 0x000F8E8C File Offset: 0x000F708C
		public List<BattleActor> Actors
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Actors_hotfix != null)
				{
					return (List<BattleActor>)this.m_get_Actors_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_actors;
			}
		}

		// Token: 0x17000F3F RID: 3903
		// (get) Token: 0x0600376D RID: 14189 RVA: 0x000F8F00 File Offset: 0x000F7100
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
				return string.Format("[{0}Group{1}]", (this.m_team.TeamNumber != 0) ? "敌方" : "我方", this.ID);
			}
		}

		// Token: 0x0600376E RID: 14190 RVA: 0x000F8FA0 File Offset: 0x000F71A0
		public void DoBehavor()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DoBehavor_hotfix != null)
			{
				this.m_DoBehavor_hotfix.call(new object[]
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
			BattleActor leader = this.m_leader;
			if (this.m_singleBehaviors.Count != this.m_actors.Count)
			{
				if (this.m_team.Battle.IsEnableDebugLog())
				{
					DebugUtility.Log(string.Format("!@# {0}: 存储群组成员的个体行为", this.InstanceID));
				}
				this.m_singleBehaviors.Clear();
				foreach (BattleActor battleActor in this.m_actors)
				{
					this.m_singleBehaviors.Add(battleActor.GetBehaviorId());
				}
			}
			if (this.m_leader != null && (this.m_leader.IsDeadOrRetreat() || !this.m_leader.CheckBehaviorCondition(this.m_curBehaviorCfg.SelectLeaderCondition, this.m_curBehaviorCfg.SLCParamData)))
			{
				if (this.m_team.Battle.IsEnableDebugLog())
				{
					DebugUtility.Log(string.Format("!@# {0}: 老队长{1}卸任", this.InstanceID, this.m_leader.InstanceID));
				}
				this.m_leader.ActionValue = this.m_leaderNormalActionPriority;
				this.m_leader = null;
			}
			if (this.m_leader == null)
			{
				foreach (BattleActor battleActor2 in BattleActor.FindActorsAlive(this.m_actors))
				{
					if (battleActor2.CheckBehaviorCondition(this.m_curBehaviorCfg.SelectLeaderCondition, this.m_curBehaviorCfg.SLCParamData))
					{
						this.m_leader = battleActor2;
						if (this.m_team.Battle.IsEnableDebugLog())
						{
							DebugUtility.Log(string.Format("!@# {0}: 新队长{1}上任", this.InstanceID, this.m_leader.InstanceID));
						}
						this.m_leaderNormalActionPriority = this.m_leader.ActionValue;
						this.m_leader.ActionValue = 32767;
						this.m_leader.SetBehavior(this.m_curBehaviorCfg.LeaderBehavior);
						foreach (BattleActor battleActor3 in this.m_actors)
						{
							if (battleActor3 != this.m_leader)
							{
								battleActor3.SetBehavior(this.m_curBehaviorCfg.MemberBehavior);
							}
						}
						break;
					}
				}
			}
			if (this.m_leader == null && leader != null && this.m_singleBehaviors.Count == this.m_actors.Count)
			{
				if (this.m_team.Battle.IsEnableDebugLog())
				{
					DebugUtility.Log(string.Format("!@# {0}: 没有合适的队长，恢复群组成员的个体行为", this.InstanceID));
				}
				for (int i = 0; i < this.m_singleBehaviors.Count; i++)
				{
					this.m_actors[i].SetBehavior(this.m_singleBehaviors[i]);
				}
				this.m_singleBehaviors.Clear();
			}
		}

		// Token: 0x17000F40 RID: 3904
		// (get) Token: 0x0600376F RID: 14191 RVA: 0x000F9368 File Offset: 0x000F7568
		// (set) Token: 0x06003770 RID: 14192 RVA: 0x000F9388 File Offset: 0x000F7588
		[DoNotToLua]
		public BehaviorGroup.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BehaviorGroup.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06003771 RID: 14193 RVA: 0x000F9394 File Offset: 0x000F7594
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
					this.m_ctorInt32BattleTeam_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_get_ID_hotfix = (luaObj.RawGet("get_ID") as LuaFunction);
					this.m_AddActorBattleActor_hotfix = (luaObj.RawGet("AddActor") as LuaFunction);
					this.m_get_Leader_hotfix = (luaObj.RawGet("get_Leader") as LuaFunction);
					this.m_SetBahviorInt32_hotfix = (luaObj.RawGet("SetBahvior") as LuaFunction);
					this.m_get_Behavior_hotfix = (luaObj.RawGet("get_Behavior") as LuaFunction);
					this.m_get_Actors_hotfix = (luaObj.RawGet("get_Actors") as LuaFunction);
					this.m_get_InstanceID_hotfix = (luaObj.RawGet("get_InstanceID") as LuaFunction);
					this.m_DoBehavor_hotfix = (luaObj.RawGet("DoBehavor") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06003772 RID: 14194 RVA: 0x000F9528 File Offset: 0x000F7728
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BehaviorGroup));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002ABF RID: 10943
		private int m_ID;

		// Token: 0x04002AC0 RID: 10944
		private BattleTeam m_team;

		// Token: 0x04002AC1 RID: 10945
		private List<BattleActor> m_actors = new List<BattleActor>();

		// Token: 0x04002AC2 RID: 10946
		private ConfigDataGroupBehavior m_curBehaviorCfg;

		// Token: 0x04002AC3 RID: 10947
		private BattleActor m_leader;

		// Token: 0x04002AC4 RID: 10948
		private int m_leaderNormalActionPriority = -1;

		// Token: 0x04002AC5 RID: 10949
		private List<int> m_singleBehaviors = new List<int>();

		// Token: 0x04002AC6 RID: 10950
		[DoNotToLua]
		private BehaviorGroup.LuaExportHelper luaExportHelper;

		// Token: 0x04002AC7 RID: 10951
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002AC8 RID: 10952
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002AC9 RID: 10953
		private LuaFunction m_ctorInt32BattleTeam_hotfix;

		// Token: 0x04002ACA RID: 10954
		private LuaFunction m_get_ID_hotfix;

		// Token: 0x04002ACB RID: 10955
		private LuaFunction m_AddActorBattleActor_hotfix;

		// Token: 0x04002ACC RID: 10956
		private LuaFunction m_get_Leader_hotfix;

		// Token: 0x04002ACD RID: 10957
		private LuaFunction m_SetBahviorInt32_hotfix;

		// Token: 0x04002ACE RID: 10958
		private LuaFunction m_get_Behavior_hotfix;

		// Token: 0x04002ACF RID: 10959
		private LuaFunction m_get_Actors_hotfix;

		// Token: 0x04002AD0 RID: 10960
		private LuaFunction m_get_InstanceID_hotfix;

		// Token: 0x04002AD1 RID: 10961
		private LuaFunction m_DoBehavor_hotfix;

		// Token: 0x020003B2 RID: 946
		public class LuaExportHelper
		{
			// Token: 0x06003773 RID: 14195 RVA: 0x000F9590 File Offset: 0x000F7790
			public LuaExportHelper(BehaviorGroup owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17000F41 RID: 3905
			// (get) Token: 0x06003774 RID: 14196 RVA: 0x000F95A0 File Offset: 0x000F77A0
			// (set) Token: 0x06003775 RID: 14197 RVA: 0x000F95B0 File Offset: 0x000F77B0
			public int m_ID
			{
				get
				{
					return this.m_owner.m_ID;
				}
				set
				{
					this.m_owner.m_ID = value;
				}
			}

			// Token: 0x17000F42 RID: 3906
			// (get) Token: 0x06003776 RID: 14198 RVA: 0x000F95C0 File Offset: 0x000F77C0
			// (set) Token: 0x06003777 RID: 14199 RVA: 0x000F95D0 File Offset: 0x000F77D0
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

			// Token: 0x17000F43 RID: 3907
			// (get) Token: 0x06003778 RID: 14200 RVA: 0x000F95E0 File Offset: 0x000F77E0
			// (set) Token: 0x06003779 RID: 14201 RVA: 0x000F95F0 File Offset: 0x000F77F0
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

			// Token: 0x17000F44 RID: 3908
			// (get) Token: 0x0600377A RID: 14202 RVA: 0x000F9600 File Offset: 0x000F7800
			// (set) Token: 0x0600377B RID: 14203 RVA: 0x000F9610 File Offset: 0x000F7810
			public ConfigDataGroupBehavior m_curBehaviorCfg
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

			// Token: 0x17000F45 RID: 3909
			// (get) Token: 0x0600377C RID: 14204 RVA: 0x000F9620 File Offset: 0x000F7820
			// (set) Token: 0x0600377D RID: 14205 RVA: 0x000F9630 File Offset: 0x000F7830
			public BattleActor m_leader
			{
				get
				{
					return this.m_owner.m_leader;
				}
				set
				{
					this.m_owner.m_leader = value;
				}
			}

			// Token: 0x17000F46 RID: 3910
			// (get) Token: 0x0600377E RID: 14206 RVA: 0x000F9640 File Offset: 0x000F7840
			// (set) Token: 0x0600377F RID: 14207 RVA: 0x000F9650 File Offset: 0x000F7850
			public int m_leaderNormalActionPriority
			{
				get
				{
					return this.m_owner.m_leaderNormalActionPriority;
				}
				set
				{
					this.m_owner.m_leaderNormalActionPriority = value;
				}
			}

			// Token: 0x17000F47 RID: 3911
			// (get) Token: 0x06003780 RID: 14208 RVA: 0x000F9660 File Offset: 0x000F7860
			// (set) Token: 0x06003781 RID: 14209 RVA: 0x000F9670 File Offset: 0x000F7870
			public List<int> m_singleBehaviors
			{
				get
				{
					return this.m_owner.m_singleBehaviors;
				}
				set
				{
					this.m_owner.m_singleBehaviors = value;
				}
			}

			// Token: 0x04002AD2 RID: 10962
			private BehaviorGroup m_owner;
		}
	}
}
