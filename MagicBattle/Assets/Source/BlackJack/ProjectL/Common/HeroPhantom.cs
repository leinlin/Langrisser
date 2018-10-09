using System;
using System.Collections.Generic;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200054D RID: 1357
	[CustomLuaClass]
	public class HeroPhantom
	{
		// Token: 0x170013B4 RID: 5044
		// (get) Token: 0x06004FEF RID: 20463 RVA: 0x0017FC3C File Offset: 0x0017DE3C
		// (set) Token: 0x06004FF0 RID: 20464 RVA: 0x0017FC44 File Offset: 0x0017DE44
		public int ID { get; set; }

		// Token: 0x170013B5 RID: 5045
		// (get) Token: 0x06004FF1 RID: 20465 RVA: 0x0017FC50 File Offset: 0x0017DE50
		public string Name
		{
			get
			{
				return this.Config.Name;
			}
		}

		// Token: 0x170013B6 RID: 5046
		// (get) Token: 0x06004FF2 RID: 20466 RVA: 0x0017FC60 File Offset: 0x0017DE60
		public string Description
		{
			get
			{
				return this.Config.Desc;
			}
		}

		// Token: 0x170013B7 RID: 5047
		// (get) Token: 0x06004FF3 RID: 20467 RVA: 0x0017FC70 File Offset: 0x0017DE70
		public List<ConfigDataHeroPhantomLevelInfo> LevelConfigs
		{
			get
			{
				return this.Config.m_levels;
			}
		}

		// Token: 0x170013B8 RID: 5048
		// (get) Token: 0x06004FF4 RID: 20468 RVA: 0x0017FC80 File Offset: 0x0017DE80
		public DateTime OpenDateTime
		{
			get
			{
				return Convert.ToDateTime(this.Config.OpenDateTime);
			}
		}

		// Token: 0x170013B9 RID: 5049
		// (get) Token: 0x06004FF5 RID: 20469 RVA: 0x0017FC94 File Offset: 0x0017DE94
		public DateTime CloseDateTime
		{
			get
			{
				return Convert.ToDateTime(this.Config.CloseDateTime);
			}
		}

		// Token: 0x170013BA RID: 5050
		// (get) Token: 0x06004FF6 RID: 20470 RVA: 0x0017FCA8 File Offset: 0x0017DEA8
		public DateTime ShowDateTime
		{
			get
			{
				return Convert.ToDateTime(this.Config.ShowDateTime);
			}
		}

		// Token: 0x170013BB RID: 5051
		// (get) Token: 0x06004FF7 RID: 20471 RVA: 0x0017FCBC File Offset: 0x0017DEBC
		public DateTime HideDateTime
		{
			get
			{
				return Convert.ToDateTime(this.Config.HideDateTime);
			}
		}

		// Token: 0x170013BC RID: 5052
		// (get) Token: 0x06004FF8 RID: 20472 RVA: 0x0017FCD0 File Offset: 0x0017DED0
		// (set) Token: 0x06004FF9 RID: 20473 RVA: 0x0017FCD8 File Offset: 0x0017DED8
		public HeroPhantomCollections WhichCollection { get; set; }

		// Token: 0x170013BD RID: 5053
		// (get) Token: 0x06004FFA RID: 20474 RVA: 0x0017FCE4 File Offset: 0x0017DEE4
		public ConfigDataHeroPhantomInfo Config
		{
			get
			{
				return this.ConfigDataLoader.GetConfigDataHeroPhantomInfo(this.ID);
			}
		}

		// Token: 0x170013BE RID: 5054
		// (get) Token: 0x06004FFB RID: 20475 RVA: 0x0017FCF8 File Offset: 0x0017DEF8
		// (set) Token: 0x06004FFC RID: 20476 RVA: 0x0017FD00 File Offset: 0x0017DF00
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

		// Token: 0x170013BF RID: 5055
		// (get) Token: 0x06004FFD RID: 20477 RVA: 0x0017FD1C File Offset: 0x0017DF1C
		public bool IsAvailableForShow
		{
			get
			{
				DateTime dateTime = this.WhichCollection.Now();
				return this.ShowDateTime < dateTime && dateTime < this.HideDateTime;
			}
		}

		// Token: 0x170013C0 RID: 5056
		// (get) Token: 0x06004FFE RID: 20478 RVA: 0x0017FD5C File Offset: 0x0017DF5C
		public bool IsAvailableForChallenge
		{
			get
			{
				DateTime dateTime = this.WhichCollection.Now();
				return this.OpenDateTime < dateTime && dateTime < this.CloseDateTime;
			}
		}

		// Token: 0x06004FFF RID: 20479 RVA: 0x0017FD9C File Offset: 0x0017DF9C
		public HeroPhantomLevel GetLevel(int LevelId)
		{
			return this.Levels.Find((HeroPhantomLevel l) => l.ID == LevelId);
		}

		// Token: 0x06005000 RID: 20480 RVA: 0x0017FDD0 File Offset: 0x0017DFD0
		private void ReloadConfigData()
		{
			using (List<int>.Enumerator enumerator = this.Config.LevelList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					int Level = enumerator.Current;
					HeroPhantomLevel heroPhantomLevel = this.Levels.Find((HeroPhantomLevel l) => l.ID == Level);
					if (heroPhantomLevel == null)
					{
						this.Levels.Add(new HeroPhantomLevel
						{
							ID = Level,
							WhichPhantom = this,
							ConfigDataLoader = this.ConfigDataLoader
						});
					}
					else
					{
						heroPhantomLevel.ConfigDataLoader = this.ConfigDataLoader;
					}
				}
			}
			List<int> list = new List<int>();
			int i;
			for (i = this.Levels.Count - 1; i >= 0; i--)
			{
				int num = this.Config.LevelList.FindIndex((int l) => l == this.Levels[i].ID);
				if (num < 0)
				{
					list.Add(i);
				}
			}
			foreach (int index in list)
			{
				this.Levels.RemoveAt(index);
			}
		}

		// Token: 0x040039E8 RID: 14824
		public List<HeroPhantomLevel> Levels = new List<HeroPhantomLevel>();

		// Token: 0x040039EA RID: 14826
		private IConfigDataLoader _ConfigDataLoader;
	}
}
