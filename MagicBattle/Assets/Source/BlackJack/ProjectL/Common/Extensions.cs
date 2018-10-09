using System;
using BlackJack.ProjectL.Protocol;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000401 RID: 1025
	public static class Extensions
	{
		// Token: 0x06003BF4 RID: 15348 RVA: 0x00110A24 File Offset: 0x0010EC24
		public static ProGuildMassiveCombatStrongholdInfo ToPro(this GuildMassiveCombatStronghold Stronghold)
		{
			if (Stronghold == null)
			{
				return null;
			}
			ProGuildMassiveCombatStrongholdInfo proGuildMassiveCombatStrongholdInfo = new ProGuildMassiveCombatStrongholdInfo
			{
				ConfigId = Stronghold.ConfigId,
				EnemyEliminated = Stronghold.EnemyEliminated,
				LevelId = Stronghold.LevelId,
				TakenOverTime = Stronghold.TakenOverTime.Ticks,
				RandomSeed = Stronghold.RandomSeed
			};
			proGuildMassiveCombatStrongholdInfo.PreferredHeroTagIds.AddRange(Stronghold.PreferredHeroTagIds);
			return proGuildMassiveCombatStrongholdInfo;
		}

		// Token: 0x06003BF5 RID: 15349 RVA: 0x00110A94 File Offset: 0x0010EC94
		public static GuildMassiveCombatStronghold ToMemory(this ProGuildMassiveCombatStrongholdInfo Stronghold)
		{
			if (Stronghold == null)
			{
				return null;
			}
			GuildMassiveCombatStronghold guildMassiveCombatStronghold = new GuildMassiveCombatStronghold
			{
				ConfigId = Stronghold.ConfigId,
				EnemyEliminated = Stronghold.EnemyEliminated,
				LevelId = Stronghold.LevelId,
				TakenOverTime = new DateTime(Stronghold.TakenOverTime),
				RandomSeed = Stronghold.RandomSeed
			};
			guildMassiveCombatStronghold.PreferredHeroTagIds.AddRange(Stronghold.PreferredHeroTagIds);
			return guildMassiveCombatStronghold;
		}

		// Token: 0x06003BF6 RID: 15350 RVA: 0x00110B04 File Offset: 0x0010ED04
		public static ProGuildMassiveCombatMemberInfo ToPro(this GuildMassiveCombatMemberInfo MemberInfo)
		{
			if (MemberInfo == null)
			{
				return null;
			}
			return new ProGuildMassiveCombatMemberInfo
			{
				Points = MemberInfo.Points,
				UserId = MemberInfo.UserId,
				PointsToday = MemberInfo.PointsToday
			};
		}

		// Token: 0x06003BF7 RID: 15351 RVA: 0x00110B44 File Offset: 0x0010ED44
		public static GuildMassiveCombatMemberInfo ToMemory(this ProGuildMassiveCombatMemberInfo MemberInfo)
		{
			if (MemberInfo == null)
			{
				return null;
			}
			return new GuildMassiveCombatMemberInfo
			{
				Points = MemberInfo.Points,
				UserId = MemberInfo.UserId,
				PointsToday = MemberInfo.PointsToday,
				Title = (GuildTitle)MemberInfo.Title
			};
		}

		// Token: 0x06003BF8 RID: 15352 RVA: 0x00110B90 File Offset: 0x0010ED90
		public static ProGuildMassiveCombatInfo ToPro(this GuildMassiveCombatInfo CombatInfo)
		{
			if (CombatInfo == null)
			{
				return null;
			}
			ProGuildMassiveCombatInfo proGuildMassiveCombatInfo = new ProGuildMassiveCombatInfo
			{
				CreateTime = CombatInfo.CreateTime.Ticks,
				Difficulty = CombatInfo.Difficulty,
				InstanceId = CombatInfo.InstanceId,
				FinishTime = CombatInfo.FinishTime.Ticks
			};
			foreach (GuildMassiveCombatMemberInfo memberInfo in CombatInfo.Members)
			{
				proGuildMassiveCombatInfo.Members.Add(memberInfo.ToPro());
			}
			foreach (GuildMassiveCombatStronghold stronghold in CombatInfo.Strongholds)
			{
				proGuildMassiveCombatInfo.Strongholds.Add(stronghold.ToPro());
			}
			return proGuildMassiveCombatInfo;
		}

		// Token: 0x06003BF9 RID: 15353 RVA: 0x00110C9C File Offset: 0x0010EE9C
		public static GuildMassiveCombatInfo ToMemory(this ProGuildMassiveCombatInfo CombatInfo)
		{
			if (CombatInfo == null)
			{
				return null;
			}
			GuildMassiveCombatInfo guildMassiveCombatInfo = new GuildMassiveCombatInfo
			{
				CreateTime = new DateTime(CombatInfo.CreateTime),
				Difficulty = CombatInfo.Difficulty,
				InstanceId = CombatInfo.InstanceId,
				FinishTime = new DateTime(CombatInfo.FinishTime)
			};
			foreach (ProGuildMassiveCombatMemberInfo memberInfo in CombatInfo.Members)
			{
				guildMassiveCombatInfo.Members.Add(memberInfo.ToMemory());
			}
			foreach (ProGuildMassiveCombatStrongholdInfo stronghold in CombatInfo.Strongholds)
			{
				GuildMassiveCombatStronghold item = stronghold.ToMemory();
				guildMassiveCombatInfo.Strongholds.Add(item);
			}
			return guildMassiveCombatInfo;
		}

		// Token: 0x06003BFA RID: 15354 RVA: 0x00110DAC File Offset: 0x0010EFAC
		public static ProGuildMassiveCombatGeneralInfo ToPro(this GuildMassiveCombatGeneral General)
		{
			if (General == null)
			{
				return null;
			}
			ProGuildMassiveCombatGeneralInfo proGuildMassiveCombatGeneralInfo = new ProGuildMassiveCombatGeneralInfo
			{
				RecentCombat = ((General.RecentCombat != null) ? General.RecentCombat.ToPro() : null)
			};
			foreach (GuildMassiveCombatInfo combatInfo in General.FinishedCombats)
			{
				proGuildMassiveCombatGeneralInfo.FinishedCombats.Add(combatInfo.ToPro());
			}
			return proGuildMassiveCombatGeneralInfo;
		}

		// Token: 0x06003BFB RID: 15355 RVA: 0x00110E48 File Offset: 0x0010F048
		public static GuildMassiveCombatGeneral ToMemory(this ProGuildMassiveCombatGeneralInfo General)
		{
			if (General == null)
			{
				return null;
			}
			GuildMassiveCombatGeneral guildMassiveCombatGeneral = new GuildMassiveCombatGeneral
			{
				RecentCombat = ((General.RecentCombat != null) ? General.RecentCombat.ToMemory() : null)
			};
			foreach (ProGuildMassiveCombatInfo combatInfo in General.FinishedCombats)
			{
				guildMassiveCombatGeneral.FinishedCombats.Add(combatInfo.ToMemory());
			}
			return guildMassiveCombatGeneral;
		}

		// Token: 0x06003BFC RID: 15356 RVA: 0x00110EE4 File Offset: 0x0010F0E4
		public static ProGuildPlayerMassiveCombatInfo ToPro(this GuildPlayerMassiveCombatInfo Info)
		{
			if (Info == null)
			{
				return null;
			}
			ProGuildPlayerMassiveCombatInfo proGuildPlayerMassiveCombatInfo = new ProGuildPlayerMassiveCombatInfo
			{
				BindedGuildId = Info.BindedGuildId
			};
			proGuildPlayerMassiveCombatInfo.UsedHeroIds.AddRange(Info.UsedHeroIds);
			proGuildPlayerMassiveCombatInfo.Points = Info.Points;
			return proGuildPlayerMassiveCombatInfo;
		}

		// Token: 0x06003BFD RID: 15357 RVA: 0x00110F2C File Offset: 0x0010F12C
		public static GuildPlayerMassiveCombatInfo ToMemory(this ProGuildPlayerMassiveCombatInfo Info)
		{
			if (Info == null)
			{
				return null;
			}
			GuildPlayerMassiveCombatInfo guildPlayerMassiveCombatInfo = new GuildPlayerMassiveCombatInfo
			{
				BindedGuildId = Info.BindedGuildId
			};
			guildPlayerMassiveCombatInfo.UsedHeroIds.AddRange(Info.UsedHeroIds);
			guildPlayerMassiveCombatInfo.Points = Info.Points;
			return guildPlayerMassiveCombatInfo;
		}
	}
}
