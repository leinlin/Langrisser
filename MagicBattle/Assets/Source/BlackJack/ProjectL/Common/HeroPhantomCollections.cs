using System;
using System.Collections.Generic;
using System.Linq;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000551 RID: 1361
	[CustomLuaClass]
	public class HeroPhantomCollections
	{
		// Token: 0x170013C1 RID: 5057
		// (get) Token: 0x06005008 RID: 20488 RVA: 0x0017FFD4 File Offset: 0x0017E1D4
		// (set) Token: 0x06005009 RID: 20489 RVA: 0x0017FFDC File Offset: 0x0017E1DC
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

		// Token: 0x0600500A RID: 20490 RVA: 0x0017FFF8 File Offset: 0x0017E1F8
		public HeroPhantom GetHeroPhantom(int HeroPhantomId)
		{
			return this.HeroPhantoms.Find((HeroPhantom hp) => hp.ID == HeroPhantomId);
		}

		// Token: 0x0600500B RID: 20491 RVA: 0x0018002C File Offset: 0x0017E22C
		public HeroPhantomLevel GetHeroPhantomLevel(int LevelId)
		{
			foreach (HeroPhantom heroPhantom in this.HeroPhantoms)
			{
				HeroPhantomLevel heroPhantomLevel = heroPhantom.Levels.Find((HeroPhantomLevel l) => l.ID == LevelId);
				if (heroPhantomLevel != null)
				{
					return heroPhantomLevel;
				}
			}
			return null;
		}

		// Token: 0x0600500C RID: 20492 RVA: 0x001800B8 File Offset: 0x0017E2B8
		public void ReloadConfigData()
		{
			IEnumerable<KeyValuePair<int, ConfigDataHeroPhantomInfo>> allConfigDataHeroPhantomInfo = this.ConfigDataLoader.GetAllConfigDataHeroPhantomInfo();
			using (IEnumerator<KeyValuePair<int, ConfigDataHeroPhantomInfo>> enumerator = allConfigDataHeroPhantomInfo.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<int, ConfigDataHeroPhantomInfo> kv = enumerator.Current;
					HeroPhantom heroPhantom = this.HeroPhantoms.Find((HeroPhantom p) => p.ID == kv.Key);
					if (heroPhantom == null)
					{
						this.HeroPhantoms.Add(new HeroPhantom
						{
							ID = kv.Key,
							ConfigDataLoader = this.ConfigDataLoader,
							WhichCollection = this
						});
					}
					else
					{
						heroPhantom.ConfigDataLoader = this.ConfigDataLoader;
					}
				}
			}
			List<int> list = new List<int>();
			int i;
			for (i = this.HeroPhantoms.Count - 1; i >= 0; i--)
			{
				HeroPhantom heroPhantom2 = this.HeroPhantoms[i];
				if (!allConfigDataHeroPhantomInfo.Any((KeyValuePair<int, ConfigDataHeroPhantomInfo> kv) => kv.Key == this.HeroPhantoms[i].ID))
				{
					list.Add(i);
				}
			}
			foreach (int index in list)
			{
				this.HeroPhantoms.RemoveAt(index);
			}
		}

		// Token: 0x040039EF RID: 14831
		public CurrentTime Now;

		// Token: 0x040039F0 RID: 14832
		public List<HeroPhantom> HeroPhantoms = new List<HeroPhantom>();

		// Token: 0x040039F1 RID: 14833
		private IConfigDataLoader _ConfigDataLoader;
	}
}
