using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004D5 RID: 1237
	public class DataSectionGuild : DataSection
	{
		// Token: 0x06004B36 RID: 19254 RVA: 0x00175D50 File Offset: 0x00173F50
		public DataSectionGuild()
		{
			this.InvitedGuildIds = new List<string>();
			this.NextJoinTime = DateTime.MinValue;
			this.MassiveCombat = new GuildPlayerMassiveCombatInfo();
		}

		// Token: 0x06004B37 RID: 19255 RVA: 0x00175D7C File Offset: 0x00173F7C
		public override object SerializeToClient()
		{
			return new DSGuildNtf
			{
				GuildId = this.GuildId,
				Version = (uint)base.Version,
				NextJoinTime = this.NextJoinTime.Ticks
			};
		}

		// Token: 0x06004B38 RID: 19256 RVA: 0x00175DC0 File Offset: 0x00173FC0
		public override void ClearInitedData()
		{
			this.InvitedGuildIds.Clear();
		}

		// Token: 0x06004B39 RID: 19257 RVA: 0x00175DD0 File Offset: 0x00173FD0
		public bool IsInInvitedGuild(string guildId)
		{
			return this.InvitedGuildIds.Contains(guildId);
		}

		// Token: 0x06004B3A RID: 19258 RVA: 0x00175DE0 File Offset: 0x00173FE0
		public void AddJoinGuildInvitation(string guildId)
		{
			this.InvitedGuildIds.Add(guildId);
			base.SetDirty(true);
		}

		// Token: 0x06004B3B RID: 19259 RVA: 0x00175DF8 File Offset: 0x00173FF8
		public void RemoveJoinGuildInvitation(string guildId)
		{
			if (this.InvitedGuildIds.Remove(guildId))
			{
				base.SetDirty(true);
			}
		}

		// Token: 0x06004B3C RID: 19260 RVA: 0x00175E14 File Offset: 0x00174014
		public void ClearJoinGuildInvitation()
		{
			this.InvitedGuildIds.Clear();
			base.SetDirty(true);
		}

		// Token: 0x1700127C RID: 4732
		// (get) Token: 0x06004B3D RID: 19261 RVA: 0x00175E28 File Offset: 0x00174028
		// (set) Token: 0x06004B3E RID: 19262 RVA: 0x00175E30 File Offset: 0x00174030
		public string GuildId { get; set; }

		// Token: 0x1700127D RID: 4733
		// (get) Token: 0x06004B3F RID: 19263 RVA: 0x00175E3C File Offset: 0x0017403C
		// (set) Token: 0x06004B40 RID: 19264 RVA: 0x00175E44 File Offset: 0x00174044
		public DateTime NextJoinTime { get; set; }

		// Token: 0x1700127E RID: 4734
		// (get) Token: 0x06004B41 RID: 19265 RVA: 0x00175E50 File Offset: 0x00174050
		// (set) Token: 0x06004B42 RID: 19266 RVA: 0x00175E58 File Offset: 0x00174058
		public List<string> InvitedGuildIds { get; set; }

		// Token: 0x1700127F RID: 4735
		// (get) Token: 0x06004B43 RID: 19267 RVA: 0x00175E64 File Offset: 0x00174064
		// (set) Token: 0x06004B44 RID: 19268 RVA: 0x00175E6C File Offset: 0x0017406C
		public GuildPlayerMassiveCombatInfo MassiveCombat { get; set; }
	}
}
