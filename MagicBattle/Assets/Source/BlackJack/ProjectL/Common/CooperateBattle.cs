using System;
using System.Collections.Generic;
using BlackJack.ConfigData;
using BlackJack.UtilityTools;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000535 RID: 1333
	[CustomLuaClass]
	public class CooperateBattle
	{
		// Token: 0x1700136E RID: 4974
		// (get) Token: 0x06004F49 RID: 20297 RVA: 0x0017E6AC File Offset: 0x0017C8AC
		// (set) Token: 0x06004F4A RID: 20298 RVA: 0x0017E6B4 File Offset: 0x0017C8B4
		public int ID { get; set; }

		// Token: 0x1700136F RID: 4975
		// (get) Token: 0x06004F4B RID: 20299 RVA: 0x0017E6C0 File Offset: 0x0017C8C0
		public string Name
		{
			get
			{
				return this.Config.Name;
			}
		}

		// Token: 0x17001370 RID: 4976
		// (get) Token: 0x06004F4C RID: 20300 RVA: 0x0017E6D0 File Offset: 0x0017C8D0
		public string Description
		{
			get
			{
				return this.Config.Desc;
			}
		}

		// Token: 0x17001371 RID: 4977
		// (get) Token: 0x06004F4D RID: 20301 RVA: 0x0017E6E0 File Offset: 0x0017C8E0
		public DateTime OpenDateTime
		{
			get
			{
				DateTime dt = this.WhichBattleCollections.Now();
				int num = this.ShowWeekDays.BinarySearch(dt.Date.DayOfWeek);
				if (num >= 0)
				{
					return dt.StartOfWeek(dt.Date.DayOfWeek).Add(this.Config.OpenTimeSpan);
				}
				num = ~num;
				if (num < this.ShowWeekDays.Count)
				{
					return dt.StartOfWeek(this.ShowWeekDays[num]).Add(this.Config.OpenTimeSpan);
				}
				return dt.StartOfWeek(this.ShowWeekDays[num % this.ShowWeekDays.Count]).Add(this.Config.OpenTimeSpan).AddDays(7.0);
			}
		}

		// Token: 0x17001372 RID: 4978
		// (get) Token: 0x06004F4E RID: 20302 RVA: 0x0017E7CC File Offset: 0x0017C9CC
		public DateTime CloseDateTime
		{
			get
			{
				DateTime dt = this.WhichBattleCollections.Now();
				int num = this.ShowWeekDays.BinarySearch(dt.Date.DayOfWeek);
				if (num >= 0)
				{
					return dt.StartOfWeek(dt.Date.DayOfWeek).Add(this.Config.CloseTimeSpan);
				}
				num = ~num;
				if (num < this.ShowWeekDays.Count)
				{
					return dt.StartOfWeek(this.ShowWeekDays[num]).Add(this.Config.CloseTimeSpan);
				}
				return dt.StartOfWeek(this.ShowWeekDays[num % this.ShowWeekDays.Count]).Add(this.Config.CloseTimeSpan).AddDays(7.0);
			}
		}

		// Token: 0x17001373 RID: 4979
		// (get) Token: 0x06004F4F RID: 20303 RVA: 0x0017E8B8 File Offset: 0x0017CAB8
		public List<DayOfWeek> ShowWeekDays
		{
			get
			{
				return this.Config.OpenDaysOfWeek;
			}
		}

		// Token: 0x17001374 RID: 4980
		// (get) Token: 0x06004F50 RID: 20304 RVA: 0x0017E8C8 File Offset: 0x0017CAC8
		// (set) Token: 0x06004F51 RID: 20305 RVA: 0x0017E8D0 File Offset: 0x0017CAD0
		public int ChallengedNums { get; set; }

		// Token: 0x17001375 RID: 4981
		// (get) Token: 0x06004F52 RID: 20306 RVA: 0x0017E8DC File Offset: 0x0017CADC
		public bool IsAvailableForChallenge
		{
			get
			{
				DateTime dateTime = this.WhichBattleCollections.Now();
				return this.OpenDateTime <= dateTime && dateTime < this.CloseDateTime;
			}
		}

		// Token: 0x17001376 RID: 4982
		// (get) Token: 0x06004F53 RID: 20307 RVA: 0x0017E91C File Offset: 0x0017CB1C
		public bool IsAvailableForDisplay
		{
			get
			{
				DateTime dateTime = this.WhichBattleCollections.Now();
				return this.ShowWeekDays.Contains(dateTime.DayOfWeek);
			}
		}

		// Token: 0x17001377 RID: 4983
		// (get) Token: 0x06004F54 RID: 20308 RVA: 0x0017E94C File Offset: 0x0017CB4C
		public ConfigDataCooperateBattleInfo Config
		{
			get
			{
				return this.ConfigDataLoader.GetConfigDataCooperateBattleInfo(this.ID);
			}
		}

		// Token: 0x17001378 RID: 4984
		// (get) Token: 0x06004F55 RID: 20309 RVA: 0x0017E960 File Offset: 0x0017CB60
		// (set) Token: 0x06004F56 RID: 20310 RVA: 0x0017E968 File Offset: 0x0017CB68
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

		// Token: 0x06004F57 RID: 20311 RVA: 0x0017E984 File Offset: 0x0017CB84
		public void ReloadConfigData()
		{
			List<int> list = new List<int>();
			for (int i = this.Levels.Count - 1; i >= 0; i--)
			{
				if (this.ConfigDataLoader.GetConfigDataCooperateBattleInfo(this.Levels[i].ID) == null)
				{
					list.Add(i);
				}
			}
			foreach (int index in list)
			{
				this.Levels.RemoveAt(index);
			}
			foreach (int id in this.Config.LevelList)
			{
				this.Levels.Add(new CooperateBattleLevel
				{
					ID = id,
					WhichCooperateBattle = this,
					ConfigDataLoader = this.ConfigDataLoader
				});
			}
		}

		// Token: 0x040039A9 RID: 14761
		public CooperateBattleCollections WhichBattleCollections;

		// Token: 0x040039AA RID: 14762
		public List<CooperateBattleLevel> Levels = new List<CooperateBattleLevel>();

		// Token: 0x040039AC RID: 14764
		private IConfigDataLoader _ConfigDataLoader;
	}
}
