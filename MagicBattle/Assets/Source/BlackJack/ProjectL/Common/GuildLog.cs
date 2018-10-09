using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020003F5 RID: 1013
	public class GuildLog
	{
		// Token: 0x17001032 RID: 4146
		// (get) Token: 0x06003BA9 RID: 15273 RVA: 0x0010FEA8 File Offset: 0x0010E0A8
		// (set) Token: 0x06003BAA RID: 15274 RVA: 0x0010FEB0 File Offset: 0x0010E0B0
		public int ModeId { get; set; }

		// Token: 0x17001033 RID: 4147
		// (get) Token: 0x06003BAB RID: 15275 RVA: 0x0010FEBC File Offset: 0x0010E0BC
		// (set) Token: 0x06003BAC RID: 15276 RVA: 0x0010FEC4 File Offset: 0x0010E0C4
		public string Content { get; set; }

		// Token: 0x17001034 RID: 4148
		// (get) Token: 0x06003BAD RID: 15277 RVA: 0x0010FED0 File Offset: 0x0010E0D0
		// (set) Token: 0x06003BAE RID: 15278 RVA: 0x0010FED8 File Offset: 0x0010E0D8
		public DateTime SendTime { get; set; }

		// Token: 0x06003BAF RID: 15279 RVA: 0x0010FEE4 File Offset: 0x0010E0E4
		public static ProGuildLog ToPB(GuildLog log)
		{
			return new ProGuildLog
			{
				GuildLogModeId = log.ModeId,
				Content = log.Content,
				SendTime = log.SendTime.Ticks
			};
		}

		// Token: 0x06003BB0 RID: 15280 RVA: 0x0010FF28 File Offset: 0x0010E128
		public static List<ProGuildLog> ToPBs(List<GuildLog> logs)
		{
			List<ProGuildLog> list = new List<ProGuildLog>();
			foreach (GuildLog log in logs)
			{
				list.Add(GuildLog.ToPB(log));
			}
			return list;
		}

		// Token: 0x06003BB1 RID: 15281 RVA: 0x0010FF8C File Offset: 0x0010E18C
		public static List<GuildLog> FromPBs(List<ProGuildLog> pbLogs)
		{
			List<GuildLog> list = new List<GuildLog>();
			foreach (ProGuildLog pbLog in pbLogs)
			{
				list.Add(GuildLog.FromPB(pbLog));
			}
			return list;
		}

		// Token: 0x06003BB2 RID: 15282 RVA: 0x0010FFF0 File Offset: 0x0010E1F0
		public static GuildLog FromPB(ProGuildLog pbLog)
		{
			return new GuildLog
			{
				ModeId = pbLog.GuildLogModeId,
				Content = pbLog.Content,
				SendTime = new DateTime(pbLog.SendTime)
			};
		}
	}
}
