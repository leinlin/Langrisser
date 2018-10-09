using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x020008BA RID: 2234
	[HotFix]
	public class HeroAssistantsCompoment : HeroAssistantsCompomentCommon
	{
		// Token: 0x060070A8 RID: 28840 RVA: 0x001F6EEC File Offset: 0x001F50EC
		public HeroAssistantsCompoment()
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

		// Token: 0x060070A9 RID: 28841 RVA: 0x001F6F54 File Offset: 0x001F5154
		public override void Init()
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
			base.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			base.Init();
		}

		// Token: 0x060070AA RID: 28842 RVA: 0x001F6FD0 File Offset: 0x001F51D0
		public override void PostInit()
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
			base.PostInit();
		}

		// Token: 0x060070AB RID: 28843 RVA: 0x001F7038 File Offset: 0x001F5238
		public override void DeInit()
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
			base.DeInit();
		}

		// Token: 0x060070AC RID: 28844 RVA: 0x001F70A0 File Offset: 0x001F52A0
		public void DeSerialize(DSHeroAssistantNtf ntf)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeDSHeroAssistantNtf_hotfix != null)
			{
				this.m_DeSerializeDSHeroAssistantNtf_hotfix.call(new object[]
				{
					this,
					ntf
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroAssistantsDS.ClearInitedData();
			this.m_heroAssistantsDS.InitVersion((ushort)ntf.Version, (ushort)ntf.Version);
			this.m_heroAssistantsDS.HeroAssistants.ConfigDataLoader = base.m_configDataLoader;
			this.m_heroAssistantsDS.UpdateInstantiatedData(ntf);
		}

		// Token: 0x060070AD RID: 28845 RVA: 0x001F7158 File Offset: 0x001F5358
		public ushort GetDSVersion()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDSVersion_hotfix != null)
			{
				return Convert.ToUInt16(this.m_GetDSVersion_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroAssistantsDS.ClientVersion;
		}

		// Token: 0x060070AE RID: 28846 RVA: 0x001F71D0 File Offset: 0x001F53D0
		public List<HeroAssistantsTask> GetTodayHeroAssistantsTask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTodayHeroAssistantsTask_hotfix != null)
			{
				return (List<HeroAssistantsTask>)this.m_GetTodayHeroAssistantsTask_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int dayOfWeek = (int)this.m_basicInfo.GetCurrentTime().DayOfWeek;
			return this.GetHeroAssistantsTaskByWeekDay(dayOfWeek);
		}

		// Token: 0x060070AF RID: 28847 RVA: 0x001F7258 File Offset: 0x001F5458
		public List<HeroAssistantsTask> GetHeroAssistantsTaskByWeekDay(int weekDay)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroAssistantsTaskByWeekDayInt32_hotfix != null)
			{
				return (List<HeroAssistantsTask>)this.m_GetHeroAssistantsTaskByWeekDayInt32_hotfix.call(new object[]
				{
					this,
					weekDay
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<HeroAssistantsTask> list = new List<HeroAssistantsTask>();
			List<HeroAssistantsTask> tasks = this.m_heroAssistantsDS.HeroAssistants.Tasks;
			IEnumerable<KeyValuePair<int, ConfigDataHeroAssistantTaskScheduleInfo>> allConfigDataHeroAssistantTaskScheduleInfo = base.m_configDataLoader.GetAllConfigDataHeroAssistantTaskScheduleInfo();
			foreach (KeyValuePair<int, ConfigDataHeroAssistantTaskScheduleInfo> keyValuePair in allConfigDataHeroAssistantTaskScheduleInfo)
			{
				ConfigDataHeroAssistantTaskScheduleInfo value = keyValuePair.Value;
				if (value.Weekday % 7 == weekDay % 7)
				{
					using (List<int>.Enumerator enumerator2 = value.TaskIDs.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							int id = enumerator2.Current;
							list.Add(tasks.Find((HeroAssistantsTask t) => t.ConfigId == id));
						}
					}
					break;
				}
			}
			return list;
		}

		// Token: 0x060070B0 RID: 28848 RVA: 0x001F73C8 File Offset: 0x001F55C8
		public List<HeroAssistantsTaskAssignment> GetAssignedHeroAssistantsTask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAssignedHeroAssistantsTask_hotfix != null)
			{
				return (List<HeroAssistantsTaskAssignment>)this.m_GetAssignedHeroAssistantsTask_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroAssistantsDS.HeroAssistants.Assignments;
		}

		// Token: 0x17001BCE RID: 7118
		// (get) Token: 0x060070B1 RID: 28849 RVA: 0x001F7444 File Offset: 0x001F5644
		// (set) Token: 0x060070B2 RID: 28850 RVA: 0x001F7464 File Offset: 0x001F5664
		[DoNotToLua]
		public new HeroAssistantsCompoment.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroAssistantsCompoment.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060070B3 RID: 28851 RVA: 0x001F7470 File Offset: 0x001F5670
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x060070B4 RID: 28852 RVA: 0x001F7478 File Offset: 0x001F5678
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x060070B5 RID: 28853 RVA: 0x001F7480 File Offset: 0x001F5680
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x060070B6 RID: 28854 RVA: 0x001F7488 File Offset: 0x001F5688
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x060070B7 RID: 28855 RVA: 0x001F7490 File Offset: 0x001F5690
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x060070B8 RID: 28856 RVA: 0x001F749C File Offset: 0x001F569C
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x060070B9 RID: 28857 RVA: 0x001F74A4 File Offset: 0x001F56A4
		private bool __callBase_IsHeroAssigned(int HeroId)
		{
			return base.IsHeroAssigned(HeroId);
		}

		// Token: 0x060070BA RID: 28858 RVA: 0x001F74B0 File Offset: 0x001F56B0
		private int __callBase_CanAssignHero(List<int> HeroIds, int TaskId, int Slot, int WorkSeconds)
		{
			return base.CanAssignHero(HeroIds, TaskId, Slot, WorkSeconds);
		}

		// Token: 0x060070BB RID: 28859 RVA: 0x001F74C0 File Offset: 0x001F56C0
		private int __callBase_AssignHero(List<int> HeroIds, int TaskId, int Slot, int WorkSeconds, bool NoCheck)
		{
			return base.AssignHero(HeroIds, TaskId, Slot, WorkSeconds, NoCheck);
		}

		// Token: 0x060070BC RID: 28860 RVA: 0x001F74D0 File Offset: 0x001F56D0
		private int __callBase_CanCancelTask(int TaskId, int Slot)
		{
			return base.CanCancelTask(TaskId, Slot);
		}

		// Token: 0x060070BD RID: 28861 RVA: 0x001F74DC File Offset: 0x001F56DC
		private int __callBase_CancelTask(int TaskId, int Slot, bool NoCheck)
		{
			return base.CancelTask(TaskId, Slot, NoCheck);
		}

		// Token: 0x060070BE RID: 28862 RVA: 0x001F74E8 File Offset: 0x001F56E8
		private int __callBase_CanClaimRewards(int TaskId, int Slot)
		{
			return base.CanClaimRewards(TaskId, Slot);
		}

		// Token: 0x060070BF RID: 28863 RVA: 0x001F74F4 File Offset: 0x001F56F4
		private int __callBase_ClaimRewards(int TaskId, int Slot, bool NoCheck)
		{
			return base.ClaimRewards(TaskId, Slot, NoCheck);
		}

		// Token: 0x060070C0 RID: 28864 RVA: 0x001F7500 File Offset: 0x001F5700
		private TimeSpan __callBase_GetTaskRemainingTime(int TaskId, int Slot)
		{
			return base.GetTaskRemainingTime(TaskId, Slot);
		}

		// Token: 0x060070C1 RID: 28865 RVA: 0x001F750C File Offset: 0x001F570C
		private int __callBase_GetDropIdByTaskCompleteRate(int TaskId, int CompleteRate)
		{
			return base.GetDropIdByTaskCompleteRate(TaskId, CompleteRate);
		}

		// Token: 0x060070C2 RID: 28866 RVA: 0x001F7518 File Offset: 0x001F5718
		private int __callBase_GetDropCountByTaskWorkSeconds(int TaskId, int WorkSeconds)
		{
			return base.GetDropCountByTaskWorkSeconds(TaskId, WorkSeconds);
		}

		// Token: 0x060070C3 RID: 28867 RVA: 0x001F7524 File Offset: 0x001F5724
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
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_PostInit_hotfix = (luaObj.RawGet("PostInit") as LuaFunction);
					this.m_DeInit_hotfix = (luaObj.RawGet("DeInit") as LuaFunction);
					this.m_DeSerializeDSHeroAssistantNtf_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_GetDSVersion_hotfix = (luaObj.RawGet("GetDSVersion") as LuaFunction);
					this.m_GetTodayHeroAssistantsTask_hotfix = (luaObj.RawGet("GetTodayHeroAssistantsTask") as LuaFunction);
					this.m_GetHeroAssistantsTaskByWeekDayInt32_hotfix = (luaObj.RawGet("GetHeroAssistantsTaskByWeekDay") as LuaFunction);
					this.m_GetAssignedHeroAssistantsTask_hotfix = (luaObj.RawGet("GetAssignedHeroAssistantsTask") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060070C4 RID: 28868 RVA: 0x001F76B8 File Offset: 0x001F58B8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroAssistantsCompoment));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040054FB RID: 21755
		[DoNotToLua]
		private HeroAssistantsCompoment.LuaExportHelper luaExportHelper;

		// Token: 0x040054FC RID: 21756
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040054FD RID: 21757
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040054FE RID: 21758
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040054FF RID: 21759
		private LuaFunction m_Init_hotfix;

		// Token: 0x04005500 RID: 21760
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04005501 RID: 21761
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04005502 RID: 21762
		private LuaFunction m_DeSerializeDSHeroAssistantNtf_hotfix;

		// Token: 0x04005503 RID: 21763
		private LuaFunction m_GetDSVersion_hotfix;

		// Token: 0x04005504 RID: 21764
		private LuaFunction m_GetTodayHeroAssistantsTask_hotfix;

		// Token: 0x04005505 RID: 21765
		private LuaFunction m_GetHeroAssistantsTaskByWeekDayInt32_hotfix;

		// Token: 0x04005506 RID: 21766
		private LuaFunction m_GetAssignedHeroAssistantsTask_hotfix;

		// Token: 0x020008BB RID: 2235
		public new class LuaExportHelper
		{
			// Token: 0x060070C5 RID: 28869 RVA: 0x001F7720 File Offset: 0x001F5920
			public LuaExportHelper(HeroAssistantsCompoment owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060070C6 RID: 28870 RVA: 0x001F7730 File Offset: 0x001F5930
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x060070C7 RID: 28871 RVA: 0x001F7740 File Offset: 0x001F5940
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x060070C8 RID: 28872 RVA: 0x001F7750 File Offset: 0x001F5950
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x060070C9 RID: 28873 RVA: 0x001F7760 File Offset: 0x001F5960
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x060070CA RID: 28874 RVA: 0x001F7770 File Offset: 0x001F5970
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x060070CB RID: 28875 RVA: 0x001F7780 File Offset: 0x001F5980
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x060070CC RID: 28876 RVA: 0x001F7790 File Offset: 0x001F5990
			public bool __callBase_IsHeroAssigned(int HeroId)
			{
				return this.m_owner.__callBase_IsHeroAssigned(HeroId);
			}

			// Token: 0x060070CD RID: 28877 RVA: 0x001F77A0 File Offset: 0x001F59A0
			public int __callBase_CanAssignHero(List<int> HeroIds, int TaskId, int Slot, int WorkSeconds)
			{
				return this.m_owner.__callBase_CanAssignHero(HeroIds, TaskId, Slot, WorkSeconds);
			}

			// Token: 0x060070CE RID: 28878 RVA: 0x001F77B4 File Offset: 0x001F59B4
			public int __callBase_AssignHero(List<int> HeroIds, int TaskId, int Slot, int WorkSeconds, bool NoCheck)
			{
				return this.m_owner.__callBase_AssignHero(HeroIds, TaskId, Slot, WorkSeconds, NoCheck);
			}

			// Token: 0x060070CF RID: 28879 RVA: 0x001F77C8 File Offset: 0x001F59C8
			public int __callBase_CanCancelTask(int TaskId, int Slot)
			{
				return this.m_owner.__callBase_CanCancelTask(TaskId, Slot);
			}

			// Token: 0x060070D0 RID: 28880 RVA: 0x001F77D8 File Offset: 0x001F59D8
			public int __callBase_CancelTask(int TaskId, int Slot, bool NoCheck)
			{
				return this.m_owner.__callBase_CancelTask(TaskId, Slot, NoCheck);
			}

			// Token: 0x060070D1 RID: 28881 RVA: 0x001F77E8 File Offset: 0x001F59E8
			public int __callBase_CanClaimRewards(int TaskId, int Slot)
			{
				return this.m_owner.__callBase_CanClaimRewards(TaskId, Slot);
			}

			// Token: 0x060070D2 RID: 28882 RVA: 0x001F77F8 File Offset: 0x001F59F8
			public int __callBase_ClaimRewards(int TaskId, int Slot, bool NoCheck)
			{
				return this.m_owner.__callBase_ClaimRewards(TaskId, Slot, NoCheck);
			}

			// Token: 0x060070D3 RID: 28883 RVA: 0x001F7808 File Offset: 0x001F5A08
			public TimeSpan __callBase_GetTaskRemainingTime(int TaskId, int Slot)
			{
				return this.m_owner.__callBase_GetTaskRemainingTime(TaskId, Slot);
			}

			// Token: 0x060070D4 RID: 28884 RVA: 0x001F7818 File Offset: 0x001F5A18
			public int __callBase_GetDropIdByTaskCompleteRate(int TaskId, int CompleteRate)
			{
				return this.m_owner.__callBase_GetDropIdByTaskCompleteRate(TaskId, CompleteRate);
			}

			// Token: 0x060070D5 RID: 28885 RVA: 0x001F7828 File Offset: 0x001F5A28
			public int __callBase_GetDropCountByTaskWorkSeconds(int TaskId, int WorkSeconds)
			{
				return this.m_owner.__callBase_GetDropCountByTaskWorkSeconds(TaskId, WorkSeconds);
			}

			// Token: 0x04005507 RID: 21767
			private HeroAssistantsCompoment m_owner;
		}
	}
}
