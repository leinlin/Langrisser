using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004D8 RID: 1240
	[CustomLuaClass]
	public class DataSectionHeroAssistants : DataSection
	{
		// Token: 0x06004B96 RID: 19350 RVA: 0x00176844 File Offset: 0x00174A44
		public override void ClearInitedData()
		{
			this.HeroAssistants = new HeroAssistants
			{
				ConfigDataLoader = this.HeroAssistants.ConfigDataLoader,
				Finder = this.HeroAssistants.Finder,
				Compute = this.HeroAssistants.Compute,
				GetLevel = this.HeroAssistants.GetLevel,
				Now = this.HeroAssistants.Now
			};
		}

		// Token: 0x06004B97 RID: 19351 RVA: 0x001768B4 File Offset: 0x00174AB4
		public override object SerializeToClient()
		{
			DSHeroAssistantNtf dsheroAssistantNtf = new DSHeroAssistantNtf();
			dsheroAssistantNtf.Version = (uint)base.Version;
			if (this.HeroAssistants != null)
			{
				foreach (HeroAssistantsTaskAssignment heroAssistantsTaskAssignment in this.HeroAssistants.Assignments)
				{
					ProHeroAssistantTask proHeroAssistantTask = new ProHeroAssistantTask
					{
						ConfigId = heroAssistantsTaskAssignment.TaskId,
						StartTime = heroAssistantsTaskAssignment.StartTime.Ticks,
						EndTime = heroAssistantsTaskAssignment.EndTime.Ticks,
						Slot = heroAssistantsTaskAssignment.Slot
					};
					foreach (int item in heroAssistantsTaskAssignment.AssignedHeroIds)
					{
						proHeroAssistantTask.AssignedHeroIds.Add(item);
					}
					dsheroAssistantNtf.Tasks.Add(proHeroAssistantTask);
				}
			}
			return dsheroAssistantNtf;
		}

		// Token: 0x06004B98 RID: 19352 RVA: 0x001769D4 File Offset: 0x00174BD4
		public void UpdateInstantiatedData(DSHeroAssistantNtf DS)
		{
			using (List<ProHeroAssistantTask>.Enumerator enumerator = DS.Tasks.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ProHeroAssistantTask AT = enumerator.Current;
					HeroAssistantsTask heroAssistantsTask = this.HeroAssistants.Tasks.Find((HeroAssistantsTask t) => t.ConfigId == AT.ConfigId);
					if (heroAssistantsTask != null)
					{
						HeroAssistantsTaskAssignment item = new HeroAssistantsTaskAssignment
						{
							Task = heroAssistantsTask,
							TaskId = heroAssistantsTask.ConfigId,
							EndTime = new DateTime(AT.EndTime),
							StartTime = new DateTime(AT.StartTime),
							Slot = AT.Slot,
							AssignedHeroIds = AT.AssignedHeroIds
						};
						this.HeroAssistants.Assignments.Add(item);
					}
				}
			}
		}

		// Token: 0x04003872 RID: 14450
		public HeroAssistants HeroAssistants = new HeroAssistants();
	}
}
