using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004DC RID: 1244
	[CustomLuaClass]
	public class DataSectionHeroPhantom : DataSection
	{
		// Token: 0x06004BB9 RID: 19385 RVA: 0x00176F3C File Offset: 0x0017513C
		public override void ClearInitedData()
		{
			this.PhantomCollections = new HeroPhantomCollections
			{
				ConfigDataLoader = this.PhantomCollections.ConfigDataLoader,
				Now = this.PhantomCollections.Now
			};
		}

		// Token: 0x06004BBA RID: 19386 RVA: 0x00176F78 File Offset: 0x00175178
		public override object SerializeToClient()
		{
			DSHeroPhantomNtf dsheroPhantomNtf = new DSHeroPhantomNtf();
			dsheroPhantomNtf.Version = (uint)base.Version;
			if (this.PhantomCollections != null)
			{
				foreach (HeroPhantom heroPhantom in this.PhantomCollections.HeroPhantoms)
				{
					if (heroPhantom.Levels.Exists((HeroPhantomLevel l) => l.Cleared))
					{
						ProHeroPhantom proHeroPhantom = new ProHeroPhantom
						{
							ConfigId = heroPhantom.ID
						};
						foreach (HeroPhantomLevel heroPhantomLevel in heroPhantom.Levels)
						{
							if (heroPhantomLevel.Cleared)
							{
								ProHeroPhantomLevel proHeroPhantomLevel = new ProHeroPhantomLevel
								{
									ConfigId = heroPhantomLevel.ID,
									FirstClear = heroPhantomLevel.FirstClear.Ticks
								};
								foreach (int item in heroPhantomLevel.AchievementIdsFinished)
								{
									proHeroPhantomLevel.AchievementsFinished.Add(item);
								}
								proHeroPhantom.LevelsCleared.Add(proHeroPhantomLevel);
							}
						}
						dsheroPhantomNtf.HeroPhantoms.Add(proHeroPhantom);
					}
				}
			}
			return dsheroPhantomNtf;
		}

		// Token: 0x06004BBB RID: 19387 RVA: 0x0017714C File Offset: 0x0017534C
		public void UpdateInstantiatedData(DSHeroPhantomNtf DS)
		{
			using (List<ProHeroPhantom>.Enumerator enumerator = DS.HeroPhantoms.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ProHeroPhantom HP = enumerator.Current;
					int num = this.PhantomCollections.HeroPhantoms.FindIndex((HeroPhantom p) => p.ID == HP.ConfigId);
					if (num >= 0)
					{
						HeroPhantom heroPhantom = this.PhantomCollections.HeroPhantoms[num];
						using (List<ProHeroPhantomLevel>.Enumerator enumerator2 = HP.LevelsCleared.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								ProHeroPhantomLevel LevelCleared = enumerator2.Current;
								HeroPhantomLevel heroPhantomLevel = heroPhantom.Levels.Find((HeroPhantomLevel l) => l.ID == LevelCleared.ConfigId);
								if (heroPhantomLevel != null)
								{
									heroPhantomLevel.FirstClear = new DateTime(LevelCleared.FirstClear);
									heroPhantomLevel.AchievementIdsFinished.AddRange(LevelCleared.AchievementsFinished);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004BBC RID: 19388 RVA: 0x0017728C File Offset: 0x0017548C
		public HeroPhantom GetHeroPhantom(int HeroPhantomId)
		{
			return this.PhantomCollections.HeroPhantoms.Find((HeroPhantom hp) => hp.ID == HeroPhantomId);
		}

		// Token: 0x06004BBD RID: 19389 RVA: 0x001772C4 File Offset: 0x001754C4
		public HeroPhantomLevel GetHeroPhantomLevel(int LevelId)
		{
			foreach (HeroPhantom heroPhantom in this.PhantomCollections.HeroPhantoms)
			{
				HeroPhantomLevel heroPhantomLevel = heroPhantom.Levels.Find((HeroPhantomLevel l) => l.ID == LevelId);
				if (heroPhantomLevel != null)
				{
					return heroPhantomLevel;
				}
			}
			return null;
		}

		// Token: 0x04003879 RID: 14457
		public HeroPhantomCollections PhantomCollections = new HeroPhantomCollections();
	}
}
