using System;
using System.Collections.Generic;
using System.Linq;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000543 RID: 1347
	[CustomLuaClass]
	public class HeroAssistants
	{
		// Token: 0x1700138B RID: 5003
		// (get) Token: 0x06004FA7 RID: 20391 RVA: 0x0017F3A8 File Offset: 0x0017D5A8
		// (set) Token: 0x06004FA8 RID: 20392 RVA: 0x0017F3B0 File Offset: 0x0017D5B0
		public IConfigDataLoader ConfigDataLoader
		{
			get
			{
				return this._ConfigDataLoader;
			}
			set
			{
				if (value != this._ConfigDataLoader)
				{
					this._ConfigDataLoader = value;
					this.ReloadConfigData();
				}
			}
		}

		// Token: 0x06004FA9 RID: 20393 RVA: 0x0017F3CC File Offset: 0x0017D5CC
		public void ReloadConfigData()
		{
			IEnumerable<KeyValuePair<int, ConfigDataHeroAssistantTaskInfo>> allConfigDataHeroAssistantTaskInfo = this.ConfigDataLoader.GetAllConfigDataHeroAssistantTaskInfo();
			using (IEnumerator<KeyValuePair<int, ConfigDataHeroAssistantTaskInfo>> enumerator = allConfigDataHeroAssistantTaskInfo.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<int, ConfigDataHeroAssistantTaskInfo> kv = enumerator.Current;
					HeroAssistantsTask heroAssistantsTask = this.Tasks.Find((HeroAssistantsTask t) => t.ConfigId == kv.Key);
					if (heroAssistantsTask == null)
					{
						this.Tasks.Add(new HeroAssistantsTask
						{
							ConfigId = kv.Value.ID,
							WhichHeroAssistants = this,
							ConfigDataLoader = this.ConfigDataLoader
						});
					}
					else
					{
						heroAssistantsTask.ConfigDataLoader = this.ConfigDataLoader;
					}
				}
			}
			List<int> list = new List<int>();
			int i;
			for (i = this.Tasks.Count - 1; i >= 0; i--)
			{
				if (!allConfigDataHeroAssistantTaskInfo.Any((KeyValuePair<int, ConfigDataHeroAssistantTaskInfo> kv) => kv.Key == this.Tasks[i].ConfigId))
				{
					list.Add(i);
				}
			}
			foreach (int index in list)
			{
				this.Tasks.RemoveAt(index);
			}
		}

		// Token: 0x040039C6 RID: 14790
		public FindHero Finder;

		// Token: 0x040039C7 RID: 14791
		public ComputeBattlePower Compute;

		// Token: 0x040039C8 RID: 14792
		public GetUserLevel GetLevel;

		// Token: 0x040039C9 RID: 14793
		public CurrentTime Now;

		// Token: 0x040039CA RID: 14794
		public List<HeroAssistantsTask> Tasks = new List<HeroAssistantsTask>();

		// Token: 0x040039CB RID: 14795
		public List<HeroAssistantsTaskAssignment> Assignments = new List<HeroAssistantsTaskAssignment>();

		// Token: 0x040039CC RID: 14796
		private IConfigDataLoader _ConfigDataLoader;
	}
}
