using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ProjectL.Misc
{
	// Token: 0x02000879 RID: 2169
	[CustomLuaClass]
	public class LocalAccountConfig
	{
		// Token: 0x06006B9C RID: 27548 RVA: 0x001E2B0C File Offset: 0x001E0D0C
		public LocalAccountConfig()
		{
			this.m_data = new LocalAccountConfigData();
		}

		// Token: 0x06006B9D RID: 27549 RVA: 0x001E2B20 File Offset: 0x001E0D20
		public void SetFileName(string name)
		{
			LocalAccountConfig.m_fileName = name;
		}

		// Token: 0x06006B9E RID: 27550 RVA: 0x001E2B28 File Offset: 0x001E0D28
		public bool Save()
		{
			if (string.IsNullOrEmpty(LocalAccountConfig.m_fileName))
			{
				return false;
			}
			string txt = JsonUtility.Serialize(this.m_data);
			return FileUtility.WriteText(LocalAccountConfig.m_fileName, txt);
		}

		// Token: 0x06006B9F RID: 27551 RVA: 0x001E2B60 File Offset: 0x001E0D60
		public bool Load()
		{
			if (string.IsNullOrEmpty(LocalAccountConfig.m_fileName))
			{
				this.ResetLocalAccountConfigData();
				return false;
			}
			if (!FileUtility.IsFileExist(LocalAccountConfig.m_fileName))
			{
				this.ResetLocalAccountConfigData();
				return false;
			}
			string text = FileUtility.ReadText(LocalAccountConfig.m_fileName);
			if (string.IsNullOrEmpty(text))
			{
				this.ResetLocalAccountConfigData();
				return false;
			}
			LocalAccountConfigData localAccountConfigData = JsonUtility.Deserialize<LocalAccountConfigData>(text);
			if (localAccountConfigData == null)
			{
				Debug.LogError(string.Format("LocalAccountConfig.Load {0} failed.", text));
				this.ResetLocalAccountConfigData();
				return false;
			}
			this.m_data = localAccountConfigData;
			return true;
		}

		// Token: 0x06006BA0 RID: 27552 RVA: 0x001E2BE8 File Offset: 0x001E0DE8
		private void ResetLocalAccountConfigData()
		{
			this.Data.HaveReadAnnounceActivities = null;
			this.Data.HaveReadHeroBiographyIds = null;
			this.Data.HaveReadHeroPerformanceIds = null;
			this.Data.UnlockHeroBiographyIds = null;
			this.Data.UnlockHeroPerformanceIds = null;
			this.Data.UnlockHeroDungeonLevelIds = null;
			this.Data.UnlockHeroFetterIds = null;
			this.Data.ArenaAttackerHeroIds = null;
			this.Data.TeamPlayerLevelMin = 0;
			this.Data.TeamPlayerLevelMax = 0;
			this.Data.IsRealtimePVPShowNotice = true;
			this.Data.HaveDoneMemoryExtraction = false;
		}

		// Token: 0x06006BA1 RID: 27553 RVA: 0x001E2C88 File Offset: 0x001E0E88
		public void AddHaveReadHeroBiography(int id)
		{
			List<int> list;
			if (this.Data.HaveReadHeroBiographyIds != null)
			{
				list = new List<int>(this.Data.HaveReadHeroBiographyIds);
			}
			else
			{
				list = new List<int>();
			}
			if (!list.Contains(id))
			{
				list.Add(id);
			}
			this.Data.HaveReadHeroBiographyIds = list.ToArray();
			this.Save();
		}

		// Token: 0x06006BA2 RID: 27554 RVA: 0x001E2CEC File Offset: 0x001E0EEC
		public void AddHaveReadHeroPerformance(int id)
		{
			List<int> list;
			if (this.Data.HaveReadHeroPerformanceIds != null)
			{
				list = new List<int>(this.Data.HaveReadHeroPerformanceIds);
			}
			else
			{
				list = new List<int>();
			}
			if (!list.Contains(id))
			{
				list.Add(id);
			}
			this.Data.HaveReadHeroPerformanceIds = list.ToArray();
			this.Save();
		}

		// Token: 0x06006BA3 RID: 27555 RVA: 0x001E2D50 File Offset: 0x001E0F50
		public void AddUnlockHeroBiography(int id)
		{
			List<int> list;
			if (this.Data.UnlockHeroBiographyIds != null)
			{
				list = new List<int>(this.Data.UnlockHeroBiographyIds);
			}
			else
			{
				list = new List<int>();
			}
			if (!list.Contains(id))
			{
				list.Add(id);
			}
			this.Data.UnlockHeroBiographyIds = list.ToArray();
			this.Save();
		}

		// Token: 0x06006BA4 RID: 27556 RVA: 0x001E2DB4 File Offset: 0x001E0FB4
		public void AddUnlockHeroPerformance(int id)
		{
			List<int> list;
			if (this.Data.UnlockHeroPerformanceIds != null)
			{
				list = new List<int>(this.Data.UnlockHeroPerformanceIds);
			}
			else
			{
				list = new List<int>();
			}
			if (!list.Contains(id))
			{
				list.Add(id);
			}
			this.Data.UnlockHeroPerformanceIds = list.ToArray();
			this.Save();
		}

		// Token: 0x06006BA5 RID: 27557 RVA: 0x001E2E18 File Offset: 0x001E1018
		public void AddUnlockHeroDungeonLevelId(int id)
		{
			List<int> list;
			if (this.Data.UnlockHeroDungeonLevelIds != null)
			{
				list = new List<int>(this.Data.UnlockHeroDungeonLevelIds);
			}
			else
			{
				list = new List<int>();
			}
			if (!list.Contains(id))
			{
				list.Add(id);
			}
			this.Data.UnlockHeroDungeonLevelIds = list.ToArray();
			this.Save();
		}

		// Token: 0x06006BA6 RID: 27558 RVA: 0x001E2E7C File Offset: 0x001E107C
		public void AddUnlockHeroFetterId(int id)
		{
			List<int> list;
			if (this.Data.UnlockHeroFetterIds != null)
			{
				list = new List<int>(this.Data.UnlockHeroFetterIds);
			}
			else
			{
				list = new List<int>();
			}
			if (!list.Contains(id))
			{
				list.Add(id);
			}
			this.Data.UnlockHeroFetterIds = list.ToArray();
			this.Save();
		}

		// Token: 0x06006BA7 RID: 27559 RVA: 0x001E2EE0 File Offset: 0x001E10E0
		public void SetArenaAttackerHeroIds(List<int> heroIds)
		{
			this.Data.ArenaAttackerHeroIds = heroIds.ToArray();
			this.Save();
		}

		// Token: 0x06006BA8 RID: 27560 RVA: 0x001E2EFC File Offset: 0x001E10FC
		public void SetHaveDoneMemoryExtraction(bool haveDoneMemoryExtraction)
		{
			this.Data.HaveDoneMemoryExtraction = haveDoneMemoryExtraction;
			this.Save();
		}

		// Token: 0x17001B8E RID: 7054
		// (get) Token: 0x06006BA9 RID: 27561 RVA: 0x001E2F14 File Offset: 0x001E1114
		public LocalAccountConfigData Data
		{
			get
			{
				return this.m_data;
			}
		}

		// Token: 0x17001B8F RID: 7055
		// (get) Token: 0x06006BAB RID: 27563 RVA: 0x001E2F24 File Offset: 0x001E1124
		// (set) Token: 0x06006BAA RID: 27562 RVA: 0x001E2F1C File Offset: 0x001E111C
		public static LocalAccountConfig Instance
		{
			get
			{
				return LocalAccountConfig.s_instance;
			}
			set
			{
				LocalAccountConfig.s_instance = value;
			}
		}

		// Token: 0x040052BC RID: 21180
		private static LocalAccountConfig s_instance;

		// Token: 0x040052BD RID: 21181
		private static string m_fileName;

		// Token: 0x040052BE RID: 21182
		private LocalAccountConfigData m_data;
	}
}
