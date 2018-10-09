using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020003FD RID: 1021
	[CustomLuaClass]
	public class GuildMassiveCombatInfo
	{
		// Token: 0x17001048 RID: 4168
		// (get) Token: 0x06003BE4 RID: 15332 RVA: 0x0011092C File Offset: 0x0010EB2C
		// (set) Token: 0x06003BE5 RID: 15333 RVA: 0x00110934 File Offset: 0x0010EB34
		public ulong InstanceId { get; set; }

		// Token: 0x17001049 RID: 4169
		// (get) Token: 0x06003BE6 RID: 15334 RVA: 0x00110940 File Offset: 0x0010EB40
		// (set) Token: 0x06003BE7 RID: 15335 RVA: 0x00110948 File Offset: 0x0010EB48
		public int Difficulty { get; set; }

		// Token: 0x06003BE8 RID: 15336 RVA: 0x00110954 File Offset: 0x0010EB54
		public bool IsRewardSent(DateTime now)
		{
			return this.RewardSendTime < now.AddDays(14.0);
		}

		// Token: 0x06003BE9 RID: 15337 RVA: 0x00110974 File Offset: 0x0010EB74
		public GuildMassiveCombatStronghold GetStronghold(int LevelId)
		{
			return this.Strongholds.Find((GuildMassiveCombatStronghold s) => s.LevelId == LevelId);
		}

		// Token: 0x04002DB4 RID: 11700
		public List<GuildMassiveCombatStronghold> Strongholds = new List<GuildMassiveCombatStronghold>();

		// Token: 0x04002DB5 RID: 11701
		public List<GuildMassiveCombatMemberInfo> Members = new List<GuildMassiveCombatMemberInfo>();

		// Token: 0x04002DB6 RID: 11702
		public DateTime CreateTime = DateTime.MaxValue;

		// Token: 0x04002DB7 RID: 11703
		public DateTime FinishTime = DateTime.MaxValue;

		// Token: 0x04002DB8 RID: 11704
		public DateTime RewardSendTime = DateTime.MaxValue;
	}
}
