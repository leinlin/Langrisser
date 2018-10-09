using System;
using System.Collections.Generic;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004C7 RID: 1223
	[CustomLuaClass]
	public class DataSectionCooperateBattle : DataSection
	{
		// Token: 0x06004ACE RID: 19150 RVA: 0x00174D44 File Offset: 0x00172F44
		public override void ClearInitedData()
		{
			IConfigDataLoader configDataLoader = this.BattleCollections.ConfigDataLoader;
			GetUserLevel getLevel = this.BattleCollections.GetLevel;
			CurrentTime now = this.BattleCollections.Now;
			this.BattleCollections = new CooperateBattleCollections
			{
				ConfigDataLoader = configDataLoader,
				GetLevel = getLevel,
				Now = now
			};
		}

		// Token: 0x06004ACF RID: 19151 RVA: 0x00174D98 File Offset: 0x00172F98
		public override object SerializeToClient()
		{
			DSCooperateBattleNtf dscooperateBattleNtf = new DSCooperateBattleNtf();
			dscooperateBattleNtf.Version = (uint)base.Version;
			if (this.BattleCollections != null)
			{
				foreach (CooperateBattle cooperateBattle in this.BattleCollections.Battles)
				{
					if (cooperateBattle.Levels.Exists((CooperateBattleLevel l) => l.Cleared))
					{
						ProCooperateBattle proCooperateBattle = new ProCooperateBattle
						{
							ConfigId = cooperateBattle.ID,
							ChallengedNums = cooperateBattle.ChallengedNums
						};
						foreach (CooperateBattleLevel cooperateBattleLevel in cooperateBattle.Levels)
						{
							if (cooperateBattleLevel.Cleared)
							{
								ProCooperateBattleLevel item = new ProCooperateBattleLevel
								{
									ConfigId = cooperateBattleLevel.ID,
									FirstClear = cooperateBattleLevel.FirstClear.Ticks
								};
								proCooperateBattle.LevelsCleared.Add(item);
							}
						}
						dscooperateBattleNtf.CooperateBattles.Add(proCooperateBattle);
					}
				}
			}
			return dscooperateBattleNtf;
		}

		// Token: 0x06004AD0 RID: 19152 RVA: 0x00174F00 File Offset: 0x00173100
		public void UpdateInstantiatedData(DSCooperateBattleNtf DS)
		{
			using (List<ProCooperateBattle>.Enumerator enumerator = DS.CooperateBattles.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ProCooperateBattle CB = enumerator.Current;
					int num = this.BattleCollections.Battles.FindIndex((CooperateBattle p) => p.ID == CB.ConfigId);
					if (num >= 0)
					{
						CooperateBattle cooperateBattle = this.BattleCollections.Battles[num];
						using (List<ProCooperateBattleLevel>.Enumerator enumerator2 = CB.LevelsCleared.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								ProCooperateBattleLevel LevelCleared = enumerator2.Current;
								CooperateBattleLevel cooperateBattleLevel = cooperateBattle.Levels.Find((CooperateBattleLevel l) => l.ID == LevelCleared.ConfigId);
								if (cooperateBattleLevel != null)
								{
									cooperateBattleLevel.FirstClear = new DateTime(LevelCleared.FirstClear);
								}
							}
						}
						cooperateBattle.ChallengedNums = CB.ChallengedNums;
					}
				}
			}
		}

		// Token: 0x06004AD1 RID: 19153 RVA: 0x00175038 File Offset: 0x00173238
		public CooperateBattle GetCooperateBattle(int BattleID)
		{
			return this.BattleCollections.Battles.Find((CooperateBattle b) => b.ID == BattleID);
		}

		// Token: 0x06004AD2 RID: 19154 RVA: 0x00175070 File Offset: 0x00173270
		public CooperateBattleLevel GetCooperateBattleLevel(int BattleId, int LevelId)
		{
			CooperateBattle cooperateBattle = this.BattleCollections.Battles.Find((CooperateBattle b) => b.ID == BattleId);
			if (cooperateBattle != null)
			{
				return cooperateBattle.Levels.Find((CooperateBattleLevel l) => l.ID == LevelId);
			}
			return null;
		}

		// Token: 0x06004AD3 RID: 19155 RVA: 0x001750D0 File Offset: 0x001732D0
		public CooperateBattleLevel GetFirstCooperateBattleLevel(int LevelId, bool MustBeAvailable)
		{
			foreach (CooperateBattle cooperateBattle in this.BattleCollections.Battles)
			{
				if (!MustBeAvailable || cooperateBattle.IsAvailableForChallenge)
				{
					CooperateBattleLevel cooperateBattleLevel = cooperateBattle.Levels.Find((CooperateBattleLevel l) => l.ID == LevelId);
					if (cooperateBattleLevel != null)
					{
						return cooperateBattleLevel;
					}
				}
			}
			return null;
		}

		// Token: 0x06004AD4 RID: 19156 RVA: 0x00175178 File Offset: 0x00173378
		public void SetChallengedNums(int Nums)
		{
			foreach (CooperateBattle cooperateBattle in this.BattleCollections.Battles)
			{
				cooperateBattle.ChallengedNums = Nums;
			}
			base.SetDirty(true);
		}

		// Token: 0x06004AD5 RID: 19157 RVA: 0x001751E0 File Offset: 0x001733E0
		public void IncreaseChallengedNums(int BattleId, int Nums)
		{
			CooperateBattle cooperateBattle = this.BattleCollections.Battles.Find((CooperateBattle b) => b.ID == BattleId);
			if (cooperateBattle != null)
			{
				cooperateBattle.ChallengedNums += Nums;
				base.SetDirty(true);
			}
		}

		// Token: 0x0400383F RID: 14399
		public CooperateBattleCollections BattleCollections = new CooperateBattleCollections();
	}
}
