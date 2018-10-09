using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020003F2 RID: 1010
	[CustomLuaClass]
	public class Guild
	{
		// Token: 0x06003B67 RID: 15207 RVA: 0x0010F6AC File Offset: 0x0010D8AC
		public Guild()
		{
			this.Members = new List<GuildMemberCacheObject>();
		}

		// Token: 0x1700101B RID: 4123
		// (get) Token: 0x06003B68 RID: 15208 RVA: 0x0010F6D8 File Offset: 0x0010D8D8
		// (set) Token: 0x06003B69 RID: 15209 RVA: 0x0010F6E0 File Offset: 0x0010D8E0
		public string Id { get; set; }

		// Token: 0x1700101C RID: 4124
		// (get) Token: 0x06003B6A RID: 15210 RVA: 0x0010F6EC File Offset: 0x0010D8EC
		// (set) Token: 0x06003B6B RID: 15211 RVA: 0x0010F6F4 File Offset: 0x0010D8F4
		public string Name { get; set; }

		// Token: 0x1700101D RID: 4125
		// (get) Token: 0x06003B6C RID: 15212 RVA: 0x0010F700 File Offset: 0x0010D900
		// (set) Token: 0x06003B6D RID: 15213 RVA: 0x0010F708 File Offset: 0x0010D908
		public string Bulletin { get; set; }

		// Token: 0x1700101E RID: 4126
		// (get) Token: 0x06003B6E RID: 15214 RVA: 0x0010F714 File Offset: 0x0010D914
		// (set) Token: 0x06003B6F RID: 15215 RVA: 0x0010F71C File Offset: 0x0010D91C
		public string HiringDeclaration { get; set; }

		// Token: 0x1700101F RID: 4127
		// (get) Token: 0x06003B70 RID: 15216 RVA: 0x0010F728 File Offset: 0x0010D928
		// (set) Token: 0x06003B71 RID: 15217 RVA: 0x0010F730 File Offset: 0x0010D930
		public bool AutoJoin { get; set; }

		// Token: 0x17001020 RID: 4128
		// (get) Token: 0x06003B72 RID: 15218 RVA: 0x0010F73C File Offset: 0x0010D93C
		// (set) Token: 0x06003B73 RID: 15219 RVA: 0x0010F744 File Offset: 0x0010D944
		public int JoinLevel { get; set; }

		// Token: 0x17001021 RID: 4129
		// (get) Token: 0x06003B74 RID: 15220 RVA: 0x0010F750 File Offset: 0x0010D950
		// (set) Token: 0x06003B75 RID: 15221 RVA: 0x0010F758 File Offset: 0x0010D958
		public int TotalBattlePower { get; set; }

		// Token: 0x17001022 RID: 4130
		// (get) Token: 0x06003B76 RID: 15222 RVA: 0x0010F764 File Offset: 0x0010D964
		// (set) Token: 0x06003B77 RID: 15223 RVA: 0x0010F76C File Offset: 0x0010D96C
		public int TotalActivities { get; set; }

		// Token: 0x17001023 RID: 4131
		// (get) Token: 0x06003B78 RID: 15224 RVA: 0x0010F778 File Offset: 0x0010D978
		// (set) Token: 0x06003B79 RID: 15225 RVA: 0x0010F780 File Offset: 0x0010D980
		public int LastWeekActivities { get; set; }

		// Token: 0x17001024 RID: 4132
		// (get) Token: 0x06003B7A RID: 15226 RVA: 0x0010F78C File Offset: 0x0010D98C
		// (set) Token: 0x06003B7B RID: 15227 RVA: 0x0010F794 File Offset: 0x0010D994
		public int CurrentWeekActivities { get; set; }

		// Token: 0x17001025 RID: 4133
		// (get) Token: 0x06003B7C RID: 15228 RVA: 0x0010F7A0 File Offset: 0x0010D9A0
		// (set) Token: 0x06003B7D RID: 15229 RVA: 0x0010F7A8 File Offset: 0x0010D9A8
		public int Activities { get; set; }

		// Token: 0x17001026 RID: 4134
		// (get) Token: 0x06003B7E RID: 15230 RVA: 0x0010F7B4 File Offset: 0x0010D9B4
		// (set) Token: 0x06003B7F RID: 15231 RVA: 0x0010F7BC File Offset: 0x0010D9BC
		public List<GuildMemberCacheObject> Members { get; set; }

		// Token: 0x17001027 RID: 4135
		// (get) Token: 0x06003B80 RID: 15232 RVA: 0x0010F7C8 File Offset: 0x0010D9C8
		public bool IsMemberFull
		{
			get
			{
				return this.Members.Count >= Guild.GuildMemberCountMax;
			}
		}

		// Token: 0x06003B81 RID: 15233 RVA: 0x0010F7E0 File Offset: 0x0010D9E0
		public void WeeklyFlush()
		{
			this.LastWeekActivities = this.CurrentWeekActivities;
			this.CurrentWeekActivities = 0;
		}

		// Token: 0x06003B82 RID: 15234 RVA: 0x0010F7F8 File Offset: 0x0010D9F8
		public GuildMemberCacheObject AddMember(GuildMember member)
		{
			GuildMemberCacheObject guildMemberCacheObject = new GuildMemberCacheObject
			{
				Member = member
			};
			this.Members.Add(guildMemberCacheObject);
			this.TotalBattlePower += member.TopHeroBattlePower;
			return guildMemberCacheObject;
		}

		// Token: 0x06003B83 RID: 15235 RVA: 0x0010F834 File Offset: 0x0010DA34
		public GuildMemberCacheObject FindMember(string userId)
		{
			return this.Members.Find((GuildMemberCacheObject m) => m.Member.UserId == userId);
		}

		// Token: 0x06003B84 RID: 15236 RVA: 0x0010F868 File Offset: 0x0010DA68
		public void RemoveMember(GuildMemberCacheObject cache)
		{
			this.Members.Remove(cache);
			this.TotalBattlePower -= cache.Member.TopHeroBattlePower;
		}

		// Token: 0x06003B85 RID: 15237 RVA: 0x0010F890 File Offset: 0x0010DA90
		public bool IsEmpty()
		{
			return this.Members.Count == 0;
		}

		// Token: 0x06003B86 RID: 15238 RVA: 0x0010F8A0 File Offset: 0x0010DAA0
		public GuildMemberCacheObject GetPresident()
		{
			return this.Members.Find((GuildMemberCacheObject m) => m.Member.Title == GuildTitle.President);
		}

		// Token: 0x06003B87 RID: 15239 RVA: 0x0010F8CC File Offset: 0x0010DACC
		public int GetVicePresidentNums()
		{
			int num = 0;
			foreach (GuildMemberCacheObject guildMemberCacheObject in this.Members)
			{
				if (guildMemberCacheObject.Member.Title == GuildTitle.VP)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06003B88 RID: 15240 RVA: 0x0010F93C File Offset: 0x0010DB3C
		public List<string> GetMemberUserIds()
		{
			List<string> list = new List<string>();
			foreach (GuildMemberCacheObject guildMemberCacheObject in this.Members)
			{
				list.Add(guildMemberCacheObject.Member.UserId);
			}
			return list;
		}

		// Token: 0x06003B89 RID: 15241 RVA: 0x0010F9AC File Offset: 0x0010DBAC
		public List<string> GetAdminUserIds()
		{
			List<string> list = new List<string>();
			foreach (GuildMemberCacheObject guildMemberCacheObject in this.Members)
			{
				if (guildMemberCacheObject.Member.IsAdmin())
				{
					list.Add(guildMemberCacheObject.Member.UserId);
				}
			}
			return list;
		}

		// Token: 0x06003B8A RID: 15242 RVA: 0x0010FA2C File Offset: 0x0010DC2C
		public static ProGuild ToPb(Guild g)
		{
			ProGuild proGuild = new ProGuild
			{
				Id = g.Id,
				Name = g.Name,
				Bulletin = g.Bulletin,
				HiringDeclaration = g.HiringDeclaration,
				AutoJoin = g.AutoJoin,
				TotalBattlePower = g.TotalBattlePower,
				TotalActivities = g.TotalActivities,
				LastWeekActivities = g.LastWeekActivities,
				Activities = g.Activities,
				CurrentWeekActivities = g.CurrentWeekActivities,
				JoinLevel = g.JoinLevel,
				MassiveCombatInfo = g.MassiveCombat.ToPro()
			};
			foreach (GuildMemberCacheObject guildMemberCacheObject in g.Members)
			{
				proGuild.Members.Add(GuildMember.ToPb(guildMemberCacheObject.Member));
			}
			return proGuild;
		}

		// Token: 0x06003B8B RID: 15243 RVA: 0x0010FB38 File Offset: 0x0010DD38
		public static Guild FromPb(ProGuild pb)
		{
			Guild guild = new Guild
			{
				Id = pb.Id,
				Name = pb.Name,
				Bulletin = pb.Bulletin,
				HiringDeclaration = pb.HiringDeclaration,
				AutoJoin = pb.AutoJoin,
				TotalBattlePower = pb.TotalBattlePower,
				TotalActivities = pb.TotalActivities,
				LastWeekActivities = pb.LastWeekActivities,
				Activities = pb.Activities,
				CurrentWeekActivities = pb.CurrentWeekActivities,
				JoinLevel = pb.JoinLevel,
				MassiveCombat = pb.MassiveCombatInfo.ToMemory()
			};
			foreach (ProGuildMember pb2 in pb.Members)
			{
				GuildMemberCacheObject item = new GuildMemberCacheObject
				{
					Member = GuildMember.FromPb(pb2)
				};
				guild.Members.Add(item);
			}
			return guild;
		}

		// Token: 0x04002D66 RID: 11622
		public List<GuildLog> Logs = new List<GuildLog>();

		// Token: 0x04002D67 RID: 11623
		public GuildMassiveCombatGeneral MassiveCombat = new GuildMassiveCombatGeneral();

		// Token: 0x04002D68 RID: 11624
		public static int GuildMemberCountMax;
	}
}
