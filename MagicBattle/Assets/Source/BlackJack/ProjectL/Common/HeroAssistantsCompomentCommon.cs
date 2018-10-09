using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000461 RID: 1121
	[HotFix]
	public class HeroAssistantsCompomentCommon : IComponentBase
	{
		// Token: 0x06004158 RID: 16728 RVA: 0x00132DB0 File Offset: 0x00130FB0
		public HeroAssistantsCompomentCommon()
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

		// Token: 0x06004159 RID: 16729 RVA: 0x00132E2C File Offset: 0x0013102C
		public string GetName()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetName_hotfix != null)
			{
				return (string)this.m_GetName_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return "HeroAssistants";
		}

		// Token: 0x0600415A RID: 16730 RVA: 0x00132EA0 File Offset: 0x001310A0
		public virtual void Init()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Init_hotfix != null)
			{
				this.m_Init_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_changedGoods = new List<BagItemBase>();
		}

		// Token: 0x0600415B RID: 16731 RVA: 0x00132F0C File Offset: 0x0013110C
		public virtual void PostInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostInit_hotfix != null)
			{
				this.m_PostInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_basicInfo = (this.Owner.GetOwnerComponent("PlayerBasicInfo") as PlayerBasicInfoComponentCommon);
			this.m_bag = (this.Owner.GetOwnerComponent("Bag") as BagComponentCommon);
			this.m_hero = (this.Owner.GetOwnerComponent("Hero") as HeroComponentCommon);
			this.m_battle = (this.Owner.GetOwnerComponent("Battle") as BattleComponentCommon);
			this.m_rift = (this.Owner.GetOwnerComponent("Rift") as RiftComponentCommon);
			this.m_heroAssistantsDS.HeroAssistants.Finder = new FindHero(this.m_hero.FindHero);
			this.m_heroAssistantsDS.HeroAssistants.Compute = new ComputeBattlePower(this.m_battle.ComputeBattlePower);
			this.m_heroAssistantsDS.HeroAssistants.GetLevel = new GetUserLevel(this.m_basicInfo.GetLevel);
			this.m_heroAssistantsDS.HeroAssistants.Now = new CurrentTime(this.m_basicInfo.GetCurrentTime);
		}

		// Token: 0x0600415C RID: 16732 RVA: 0x00133078 File Offset: 0x00131278
		public virtual void DeInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeInit_hotfix != null)
			{
				this.m_DeInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600415D RID: 16733 RVA: 0x001330D8 File Offset: 0x001312D8
		public virtual void Tick(uint deltaMillisecond)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickUInt32_hotfix != null)
			{
				this.m_TickUInt32_hotfix.call(new object[]
				{
					this,
					deltaMillisecond
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600415E RID: 16734 RVA: 0x00133148 File Offset: 0x00131348
		public virtual bool Serialize<T>(T dest)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SerializeT_hotfix != null)
			{
				return Convert.ToBoolean(this.m_SerializeT_hotfix.call(new object[]
				{
					this,
					dest
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return false;
		}

		// Token: 0x0600415F RID: 16735 RVA: 0x001331C8 File Offset: 0x001313C8
		public virtual void DeSerialize<T>(T source)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeT_hotfix != null)
			{
				this.m_DeSerializeT_hotfix.call(new object[]
				{
					this,
					source
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06004160 RID: 16736 RVA: 0x00133238 File Offset: 0x00131438
		public virtual void PostDeSerialize()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostDeSerialize_hotfix != null)
			{
				this.m_PostDeSerialize_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x1700114E RID: 4430
		// (get) Token: 0x06004161 RID: 16737 RVA: 0x00133298 File Offset: 0x00131498
		// (set) Token: 0x06004162 RID: 16738 RVA: 0x0013330C File Offset: 0x0013150C
		public IComponentOwner Owner
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Owner_hotfix != null)
				{
					return (IComponentOwner)this.m_get_Owner_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Owner>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_OwnerIComponentOwner_hotfix != null)
				{
					this.m_set_OwnerIComponentOwner_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Owner>k__BackingField = value;
			}
		}

		// Token: 0x06004163 RID: 16739 RVA: 0x00133384 File Offset: 0x00131584
		public bool IsHeroAssigned(int HeroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsHeroAssignedInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsHeroAssignedInt32_hotfix.call(new object[]
				{
					this,
					HeroId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (HeroAssistantsTaskAssignment heroAssistantsTaskAssignment in this.m_heroAssistantsDS.HeroAssistants.Assignments)
			{
				if (heroAssistantsTaskAssignment.AssignedHeroIds.Contains(HeroId))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06004164 RID: 16740 RVA: 0x00133470 File Offset: 0x00131670
		public int CanAssignHero(List<int> HeroIds, int TaskId, int Slot, int WorkSeconds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAssignHeroList`1Int32Int32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAssignHeroList`1Int32Int32Int32_hotfix.call(new object[]
				{
					this,
					HeroIds,
					TaskId2,
					Slot2,
					WorkSeconds
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int TaskId = TaskId2;
			int Slot = Slot2;
			if (HeroIds == null || HeroIds.Count == 0)
			{
				return -2111;
			}
			HeroAssistants heroAssistants = this.m_heroAssistantsDS.HeroAssistants;
			HeroAssistantsTask heroAssistantsTask = heroAssistants.Tasks.Find((HeroAssistantsTask t) => t.ConfigId == TaskId);
			if (heroAssistantsTask == null)
			{
				return -2102;
			}
			if (heroAssistantsTask.Locked)
			{
				return -2101;
			}
			if (heroAssistants.Assignments.Count >= this.m_configDataLoader.ConfigableConstId_HeroAssistantTaskSlotCount)
			{
				return -2112;
			}
			HeroAssistantsTaskAssignment heroAssistantsTaskAssignment = heroAssistants.Assignments.Find((HeroAssistantsTaskAssignment a) => a.Slot == Slot);
			if (heroAssistantsTaskAssignment != null && heroAssistantsTaskAssignment.AssignedHeroIds.Count > 0)
			{
				return -2105;
			}
			if (HeroIds.Count > this.m_configDataLoader.ConfigableConstId_HeroAssistantTaskHeroAssignMaxCount)
			{
				return -2109;
			}
			return 0;
		}

		// Token: 0x06004165 RID: 16741 RVA: 0x001335FC File Offset: 0x001317FC
		public virtual int AssignHero(List<int> HeroIds, int TaskId, int Slot, int WorkSeconds, bool NoCheck = false)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AssignHeroList`1Int32Int32Int32Boolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_AssignHeroList`1Int32Int32Int32Boolean_hotfix.call(new object[]
				{
					this,
					HeroIds,
					TaskId2,
					Slot,
					WorkSeconds,
					NoCheck
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int TaskId = TaskId2;
			if (!NoCheck)
			{
				int num = this.CanAssignHero(HeroIds, TaskId, Slot, WorkSeconds);
				if (num != 0)
				{
					return num;
				}
			}
			HeroAssistantsTask heroAssistantsTask = this.m_heroAssistantsDS.HeroAssistants.Tasks.Find((HeroAssistantsTask t) => t.ConfigId == TaskId);
			HeroAssistantsTaskAssignment heroAssistantsTaskAssignment = new HeroAssistantsTaskAssignment
			{
				Task = heroAssistantsTask,
				TaskId = heroAssistantsTask.ConfigId,
				AssignedHeroIds = HeroIds,
				Slot = Slot,
				StartTime = this.m_basicInfo.GetCurrentTime()
			};
			int num2 = heroAssistantsTask.RewardWorkSeconds.BinarySearch(WorkSeconds);
			if (num2 < 0)
			{
				num2 = ~num2 - 1;
			}
			if (num2 < 0)
			{
				return -2110;
			}
			this.m_heroAssistantsDS.HeroAssistants.Assignments.Add(heroAssistantsTaskAssignment);
			heroAssistantsTaskAssignment.EndTime = this.m_basicInfo.GetCurrentTime().AddSeconds((double)heroAssistantsTask.RewardWorkSeconds[num2]);
			if (this.AssignHeroToTaskMissionEvent != null)
			{
				this.AssignHeroToTaskMissionEvent();
			}
			return 0;
		}

		// Token: 0x06004166 RID: 16742 RVA: 0x001337CC File Offset: 0x001319CC
		public int CanCancelTask(int TaskId, int Slot)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanCancelTaskInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanCancelTaskInt32Int32_hotfix.call(new object[]
				{
					this,
					TaskId2,
					Slot2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int TaskId = TaskId2;
			int Slot = Slot2;
			HeroAssistants heroAssistants = this.m_heroAssistantsDS.HeroAssistants;
			if (this.m_heroAssistantsDS.HeroAssistants.Tasks.Find((HeroAssistantsTask t) => t.ConfigId == TaskId) == null)
			{
				return -2102;
			}
			HeroAssistantsTaskAssignment heroAssistantsTaskAssignment = heroAssistants.Assignments.Find((HeroAssistantsTaskAssignment a) => a.Slot == Slot);
			if (heroAssistantsTaskAssignment == null || heroAssistantsTaskAssignment.AssignedHeroIds.Count == 0)
			{
				return -2106;
			}
			return 0;
		}

		// Token: 0x06004167 RID: 16743 RVA: 0x001338DC File Offset: 0x00131ADC
		public virtual int CancelTask(int TaskId, int Slot, bool NoCheck = false)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CancelTaskInt32Int32Boolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_CancelTaskInt32Int32Boolean_hotfix.call(new object[]
				{
					this,
					TaskId2,
					Slot2,
					NoCheck
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int TaskId = TaskId2;
			int Slot = Slot2;
			if (!NoCheck)
			{
				int num = this.CanCancelTask(TaskId, Slot);
				if (num != 0)
				{
					return num;
				}
			}
			HeroAssistantsTask heroAssistantsTask = this.m_heroAssistantsDS.HeroAssistants.Tasks.Find((HeroAssistantsTask t) => t.ConfigId == TaskId);
			if (heroAssistantsTask != null)
			{
				this.m_heroAssistantsDS.HeroAssistants.Assignments.RemoveAll((HeroAssistantsTaskAssignment a) => a.Slot == Slot);
			}
			return 0;
		}

		// Token: 0x06004168 RID: 16744 RVA: 0x001339FC File Offset: 0x00131BFC
		public int CanClaimRewards(int TaskId, int Slot)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanClaimRewardsInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanClaimRewardsInt32Int32_hotfix.call(new object[]
				{
					this,
					TaskId2,
					Slot2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int TaskId = TaskId2;
			int Slot = Slot2;
			HeroAssistants heroAssistants = this.m_heroAssistantsDS.HeroAssistants;
			if (heroAssistants.Tasks.Find((HeroAssistantsTask t) => t.ConfigId == TaskId) == null)
			{
				return -2102;
			}
			HeroAssistantsTaskAssignment heroAssistantsTaskAssignment = heroAssistants.Assignments.Find((HeroAssistantsTaskAssignment a) => a.Slot == Slot);
			if (heroAssistantsTaskAssignment == null || heroAssistantsTaskAssignment.AssignedHeroIds.Count == 0)
			{
				return -2106;
			}
			if (heroAssistantsTaskAssignment.EndTime > this.m_basicInfo.GetCurrentTime())
			{
				return -2107;
			}
			return 0;
		}

		// Token: 0x06004169 RID: 16745 RVA: 0x00133B24 File Offset: 0x00131D24
		public virtual int ClaimRewards(int TaskId, int Slot, bool NoCheck = false)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClaimRewardsInt32Int32Boolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_ClaimRewardsInt32Int32Boolean_hotfix.call(new object[]
				{
					this,
					TaskId2,
					Slot2,
					NoCheck
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int TaskId = TaskId2;
			int Slot = Slot2;
			if (!NoCheck)
			{
				int num = this.CanClaimRewards(TaskId, Slot);
				if (num != 0)
				{
					return num;
				}
			}
			HeroAssistants heroAssistants = this.m_heroAssistantsDS.HeroAssistants;
			HeroAssistantsTask heroAssistantsTask = heroAssistants.Tasks.Find((HeroAssistantsTask t) => t.ConfigId == TaskId);
			if (heroAssistantsTask != null)
			{
				heroAssistants.Assignments.RemoveAll((HeroAssistantsTaskAssignment a) => a.Slot == Slot);
			}
			return 0;
		}

		// Token: 0x0600416A RID: 16746 RVA: 0x00133C3C File Offset: 0x00131E3C
		public TimeSpan GetTaskRemainingTime(int TaskId, int Slot)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTaskRemainingTimeInt32Int32_hotfix != null)
			{
				return (TimeSpan)this.m_GetTaskRemainingTimeInt32Int32_hotfix.call(new object[]
				{
					this,
					TaskId2,
					Slot2
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int TaskId = TaskId2;
			int Slot = Slot2;
			HeroAssistants heroAssistants = this.m_heroAssistantsDS.HeroAssistants;
			if (heroAssistants.Tasks.Find((HeroAssistantsTask t) => t.ConfigId == TaskId) == null)
			{
				return TimeSpan.MaxValue;
			}
			HeroAssistantsTaskAssignment heroAssistantsTaskAssignment = heroAssistants.Assignments.Find((HeroAssistantsTaskAssignment a) => a.Slot == Slot);
			if (heroAssistantsTaskAssignment == null)
			{
				return TimeSpan.MaxValue;
			}
			return (!(heroAssistantsTaskAssignment.EndTime > this.m_basicInfo.GetCurrentTime())) ? TimeSpan.Zero : (heroAssistantsTaskAssignment.EndTime - this.m_basicInfo.GetCurrentTime());
		}

		// Token: 0x0600416B RID: 16747 RVA: 0x00133D6C File Offset: 0x00131F6C
		public int GetDropIdByTaskCompleteRate(int TaskId, int CompleteRate)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDropIdByTaskCompleteRateInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetDropIdByTaskCompleteRateInt32Int32_hotfix.call(new object[]
				{
					this,
					TaskId2,
					CompleteRate
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int TaskId = TaskId2;
			HeroAssistantsTask heroAssistantsTask = this.m_heroAssistantsDS.HeroAssistants.Tasks.Find((HeroAssistantsTask t) => t.ConfigId == TaskId);
			if (heroAssistantsTask == null)
			{
				return -1;
			}
			int num = heroAssistantsTask.RewardCompleteRate.BinarySearch(CompleteRate);
			if (num < 0)
			{
				num = ~num - 1;
			}
			if (num < 0)
			{
				return -1;
			}
			return heroAssistantsTask.RewardDropId[num];
		}

		// Token: 0x0600416C RID: 16748 RVA: 0x00133E60 File Offset: 0x00132060
		public int GetDropCountByTaskWorkSeconds(int TaskId, int WorkSeconds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDropCountByTaskWorkSecondsInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetDropCountByTaskWorkSecondsInt32Int32_hotfix.call(new object[]
				{
					this,
					TaskId2,
					WorkSeconds
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int TaskId = TaskId2;
			HeroAssistantsTask heroAssistantsTask = this.m_heroAssistantsDS.HeroAssistants.Tasks.Find((HeroAssistantsTask t) => t.ConfigId == TaskId);
			if (heroAssistantsTask == null)
			{
				return -1;
			}
			int num = heroAssistantsTask.RewardWorkSeconds.BinarySearch(WorkSeconds);
			if (num < 0)
			{
				num = ~num - 1;
			}
			if (num < 0)
			{
				return -1;
			}
			return heroAssistantsTask.RewardDropCount[num];
		}

		// Token: 0x1700114F RID: 4431
		// (get) Token: 0x0600416D RID: 16749 RVA: 0x00133F54 File Offset: 0x00132154
		// (set) Token: 0x0600416E RID: 16750 RVA: 0x00133FC8 File Offset: 0x001321C8
		protected IConfigDataLoader m_configDataLoader
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_m_configDataLoader_hotfix != null)
				{
					return (IConfigDataLoader)this.m_get_m_configDataLoader_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this._configDataLoader;
			}
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_m_configDataLoaderIConfigDataLoader_hotfix != null)
				{
					this.m_set_m_configDataLoaderIConfigDataLoader_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				if (this._configDataLoader != null)
				{
					HeroAssistants heroAssistants = this.m_heroAssistantsDS.HeroAssistants;
					this._configDataLoader = value;
					heroAssistants.ConfigDataLoader = value;
				}
				else
				{
					this._configDataLoader = value;
				}
			}
		}

		// Token: 0x14000038 RID: 56
		// (add) Token: 0x0600416F RID: 16751 RVA: 0x0013406C File Offset: 0x0013226C
		// (remove) Token: 0x06004170 RID: 16752 RVA: 0x00134108 File Offset: 0x00132308
		public event Action AssignHeroToTaskMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_AssignHeroToTaskMissionEventAction_hotfix != null)
				{
					this.m_add_AssignHeroToTaskMissionEventAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.AssignHeroToTaskMissionEvent;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.AssignHeroToTaskMissionEvent, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_AssignHeroToTaskMissionEventAction_hotfix != null)
				{
					this.m_remove_AssignHeroToTaskMissionEventAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.AssignHeroToTaskMissionEvent;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.AssignHeroToTaskMissionEvent, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17001150 RID: 4432
		// (get) Token: 0x06004171 RID: 16753 RVA: 0x001341A4 File Offset: 0x001323A4
		// (set) Token: 0x06004172 RID: 16754 RVA: 0x001341C4 File Offset: 0x001323C4
		[DoNotToLua]
		public HeroAssistantsCompomentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroAssistantsCompomentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06004173 RID: 16755 RVA: 0x001341D0 File Offset: 0x001323D0
		private void __callDele_AssignHeroToTaskMissionEvent()
		{
			Action assignHeroToTaskMissionEvent = this.AssignHeroToTaskMissionEvent;
			if (assignHeroToTaskMissionEvent != null)
			{
				assignHeroToTaskMissionEvent();
			}
		}

		// Token: 0x06004174 RID: 16756 RVA: 0x001341F0 File Offset: 0x001323F0
		private void __clearDele_AssignHeroToTaskMissionEvent()
		{
			this.AssignHeroToTaskMissionEvent = null;
		}

		// Token: 0x06004175 RID: 16757 RVA: 0x001341FC File Offset: 0x001323FC
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
					this.m_GetName_hotfix = (luaObj.RawGet("GetName") as LuaFunction);
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_PostInit_hotfix = (luaObj.RawGet("PostInit") as LuaFunction);
					this.m_DeInit_hotfix = (luaObj.RawGet("DeInit") as LuaFunction);
					this.m_TickUInt32_hotfix = (luaObj.RawGet("Tick") as LuaFunction);
					this.m_SerializeT_hotfix = (luaObj.RawGet("Serialize") as LuaFunction);
					this.m_DeSerializeT_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_PostDeSerialize_hotfix = (luaObj.RawGet("PostDeSerialize") as LuaFunction);
					this.m_get_Owner_hotfix = (luaObj.RawGet("get_Owner") as LuaFunction);
					this.m_set_OwnerIComponentOwner_hotfix = (luaObj.RawGet("set_Owner") as LuaFunction);
					this.m_IsHeroAssignedInt32_hotfix = (luaObj.RawGet("IsHeroAssigned") as LuaFunction);
					this.m_CanAssignHeroList`1Int32Int32Int32_hotfix = (luaObj.RawGet("CanAssignHero") as LuaFunction);
					this.m_AssignHeroList`1Int32Int32Int32Boolean_hotfix = (luaObj.RawGet("AssignHero") as LuaFunction);
					this.m_CanCancelTaskInt32Int32_hotfix = (luaObj.RawGet("CanCancelTask") as LuaFunction);
					this.m_CancelTaskInt32Int32Boolean_hotfix = (luaObj.RawGet("CancelTask") as LuaFunction);
					this.m_CanClaimRewardsInt32Int32_hotfix = (luaObj.RawGet("CanClaimRewards") as LuaFunction);
					this.m_ClaimRewardsInt32Int32Boolean_hotfix = (luaObj.RawGet("ClaimRewards") as LuaFunction);
					this.m_GetTaskRemainingTimeInt32Int32_hotfix = (luaObj.RawGet("GetTaskRemainingTime") as LuaFunction);
					this.m_GetDropIdByTaskCompleteRateInt32Int32_hotfix = (luaObj.RawGet("GetDropIdByTaskCompleteRate") as LuaFunction);
					this.m_GetDropCountByTaskWorkSecondsInt32Int32_hotfix = (luaObj.RawGet("GetDropCountByTaskWorkSeconds") as LuaFunction);
					this.m_get_m_configDataLoader_hotfix = (luaObj.RawGet("get_m_configDataLoader") as LuaFunction);
					this.m_set_m_configDataLoaderIConfigDataLoader_hotfix = (luaObj.RawGet("set_m_configDataLoader") as LuaFunction);
					this.m_add_AssignHeroToTaskMissionEventAction_hotfix = (luaObj.RawGet("add_AssignHeroToTaskMissionEvent") as LuaFunction);
					this.m_remove_AssignHeroToTaskMissionEventAction_hotfix = (luaObj.RawGet("remove_AssignHeroToTaskMissionEvent") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06004176 RID: 16758 RVA: 0x00134520 File Offset: 0x00132720
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroAssistantsCompomentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040031DA RID: 12762
		private IConfigDataLoader _configDataLoader;

		// Token: 0x040031DB RID: 12763
		protected List<BagItemBase> m_changedGoods = new List<BagItemBase>();

		// Token: 0x040031DC RID: 12764
		protected DataSectionHeroAssistants m_heroAssistantsDS = new DataSectionHeroAssistants();

		// Token: 0x040031DD RID: 12765
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x040031DE RID: 12766
		protected BattleComponentCommon m_battle;

		// Token: 0x040031DF RID: 12767
		protected BagComponentCommon m_bag;

		// Token: 0x040031E0 RID: 12768
		protected HeroComponentCommon m_hero;

		// Token: 0x040031E1 RID: 12769
		protected RiftComponentCommon m_rift;

		// Token: 0x040031E3 RID: 12771
		[DoNotToLua]
		private HeroAssistantsCompomentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x040031E4 RID: 12772
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040031E5 RID: 12773
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040031E6 RID: 12774
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040031E7 RID: 12775
		private LuaFunction m_GetName_hotfix;

		// Token: 0x040031E8 RID: 12776
		private LuaFunction m_Init_hotfix;

		// Token: 0x040031E9 RID: 12777
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x040031EA RID: 12778
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x040031EB RID: 12779
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x040031EC RID: 12780
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x040031ED RID: 12781
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x040031EE RID: 12782
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x040031EF RID: 12783
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x040031F0 RID: 12784
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x040031F1 RID: 12785
		private LuaFunction m_IsHeroAssignedInt32_hotfix;

		// Token: 0x040031F2 RID: 12786
		private LuaFunction m_CanAssignHeroList;

		// Token: 0x040031F3 RID: 12787
		private LuaFunction m_AssignHeroList;

		// Token: 0x040031F4 RID: 12788
		private LuaFunction m_CanCancelTaskInt32Int32_hotfix;

		// Token: 0x040031F5 RID: 12789
		private LuaFunction m_CancelTaskInt32Int32Boolean_hotfix;

		// Token: 0x040031F6 RID: 12790
		private LuaFunction m_CanClaimRewardsInt32Int32_hotfix;

		// Token: 0x040031F7 RID: 12791
		private LuaFunction m_ClaimRewardsInt32Int32Boolean_hotfix;

		// Token: 0x040031F8 RID: 12792
		private LuaFunction m_GetTaskRemainingTimeInt32Int32_hotfix;

		// Token: 0x040031F9 RID: 12793
		private LuaFunction m_GetDropIdByTaskCompleteRateInt32Int32_hotfix;

		// Token: 0x040031FA RID: 12794
		private LuaFunction m_GetDropCountByTaskWorkSecondsInt32Int32_hotfix;

		// Token: 0x040031FB RID: 12795
		private LuaFunction m_get_m_configDataLoader_hotfix;

		// Token: 0x040031FC RID: 12796
		private LuaFunction m_set_m_configDataLoaderIConfigDataLoader_hotfix;

		// Token: 0x040031FD RID: 12797
		private LuaFunction m_add_AssignHeroToTaskMissionEventAction_hotfix;

		// Token: 0x040031FE RID: 12798
		private LuaFunction m_remove_AssignHeroToTaskMissionEventAction_hotfix;

		// Token: 0x02000462 RID: 1122
		public class LuaExportHelper
		{
			// Token: 0x06004177 RID: 16759 RVA: 0x00134588 File Offset: 0x00132788
			public LuaExportHelper(HeroAssistantsCompomentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06004178 RID: 16760 RVA: 0x00134598 File Offset: 0x00132798
			public void __callDele_AssignHeroToTaskMissionEvent()
			{
				this.m_owner.__callDele_AssignHeroToTaskMissionEvent();
			}

			// Token: 0x06004179 RID: 16761 RVA: 0x001345A8 File Offset: 0x001327A8
			public void __clearDele_AssignHeroToTaskMissionEvent()
			{
				this.m_owner.__clearDele_AssignHeroToTaskMissionEvent();
			}

			// Token: 0x17001151 RID: 4433
			// (get) Token: 0x0600417A RID: 16762 RVA: 0x001345B8 File Offset: 0x001327B8
			// (set) Token: 0x0600417B RID: 16763 RVA: 0x001345C8 File Offset: 0x001327C8
			public IConfigDataLoader _configDataLoader
			{
				get
				{
					return this.m_owner._configDataLoader;
				}
				set
				{
					this.m_owner._configDataLoader = value;
				}
			}

			// Token: 0x17001152 RID: 4434
			// (get) Token: 0x0600417C RID: 16764 RVA: 0x001345D8 File Offset: 0x001327D8
			// (set) Token: 0x0600417D RID: 16765 RVA: 0x001345E8 File Offset: 0x001327E8
			public List<BagItemBase> m_changedGoods
			{
				get
				{
					return this.m_owner.m_changedGoods;
				}
				set
				{
					this.m_owner.m_changedGoods = value;
				}
			}

			// Token: 0x17001153 RID: 4435
			// (get) Token: 0x0600417E RID: 16766 RVA: 0x001345F8 File Offset: 0x001327F8
			// (set) Token: 0x0600417F RID: 16767 RVA: 0x00134608 File Offset: 0x00132808
			public DataSectionHeroAssistants m_heroAssistantsDS
			{
				get
				{
					return this.m_owner.m_heroAssistantsDS;
				}
				set
				{
					this.m_owner.m_heroAssistantsDS = value;
				}
			}

			// Token: 0x17001154 RID: 4436
			// (get) Token: 0x06004180 RID: 16768 RVA: 0x00134618 File Offset: 0x00132818
			// (set) Token: 0x06004181 RID: 16769 RVA: 0x00134628 File Offset: 0x00132828
			public PlayerBasicInfoComponentCommon m_basicInfo
			{
				get
				{
					return this.m_owner.m_basicInfo;
				}
				set
				{
					this.m_owner.m_basicInfo = value;
				}
			}

			// Token: 0x17001155 RID: 4437
			// (get) Token: 0x06004182 RID: 16770 RVA: 0x00134638 File Offset: 0x00132838
			// (set) Token: 0x06004183 RID: 16771 RVA: 0x00134648 File Offset: 0x00132848
			public BattleComponentCommon m_battle
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

			// Token: 0x17001156 RID: 4438
			// (get) Token: 0x06004184 RID: 16772 RVA: 0x00134658 File Offset: 0x00132858
			// (set) Token: 0x06004185 RID: 16773 RVA: 0x00134668 File Offset: 0x00132868
			public BagComponentCommon m_bag
			{
				get
				{
					return this.m_owner.m_bag;
				}
				set
				{
					this.m_owner.m_bag = value;
				}
			}

			// Token: 0x17001157 RID: 4439
			// (get) Token: 0x06004186 RID: 16774 RVA: 0x00134678 File Offset: 0x00132878
			// (set) Token: 0x06004187 RID: 16775 RVA: 0x00134688 File Offset: 0x00132888
			public HeroComponentCommon m_hero
			{
				get
				{
					return this.m_owner.m_hero;
				}
				set
				{
					this.m_owner.m_hero = value;
				}
			}

			// Token: 0x17001158 RID: 4440
			// (get) Token: 0x06004188 RID: 16776 RVA: 0x00134698 File Offset: 0x00132898
			// (set) Token: 0x06004189 RID: 16777 RVA: 0x001346A8 File Offset: 0x001328A8
			public RiftComponentCommon m_rift
			{
				get
				{
					return this.m_owner.m_rift;
				}
				set
				{
					this.m_owner.m_rift = value;
				}
			}

			// Token: 0x17001159 RID: 4441
			// (get) Token: 0x0600418A RID: 16778 RVA: 0x001346B8 File Offset: 0x001328B8
			// (set) Token: 0x0600418B RID: 16779 RVA: 0x001346C8 File Offset: 0x001328C8
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

			// Token: 0x040031FF RID: 12799
			private HeroAssistantsCompomentCommon m_owner;
		}
	}
}
