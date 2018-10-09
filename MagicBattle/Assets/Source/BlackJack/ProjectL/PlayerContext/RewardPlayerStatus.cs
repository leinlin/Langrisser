using System;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x02000908 RID: 2312
	[CustomLuaClass]
	public class RewardPlayerStatus
	{
		// Token: 0x0600864B RID: 34379 RVA: 0x002683BC File Offset: 0x002665BC
		public void Clear()
		{
			this.Level = 0;
			this.Exp = 0;
			this.NextLevelExp = 0;
			this.Energy = 0;
			this.ArenaVictoryPoints = 0;
			this.ArenaVictoryPoints = 0;
			this.RealTimePVPScore = 0;
			this.RealTimePVPDan = 0;
			this.RealTimePVPIsPromotion = false;
			this.RealtTimePVPBattleMode = (BattleMode)(-1);
			this.ClimbTowerFinishedFloorId = 0;
			this.GuildMassiveCombatEliminateRate = 0;
		}

		// Token: 0x04005F0C RID: 24332
		public int Level;

		// Token: 0x04005F0D RID: 24333
		public int Exp;

		// Token: 0x04005F0E RID: 24334
		public int NextLevelExp;

		// Token: 0x04005F0F RID: 24335
		public int Energy;

		// Token: 0x04005F10 RID: 24336
		public int ArenaVictoryPoints;

		// Token: 0x04005F11 RID: 24337
		public int ArenaLevelID;

		// Token: 0x04005F12 RID: 24338
		public int RealTimePVPScore;

		// Token: 0x04005F13 RID: 24339
		public int RealTimePVPDan;

		// Token: 0x04005F14 RID: 24340
		public bool RealTimePVPIsPromotion;

		// Token: 0x04005F15 RID: 24341
		public BattleMode RealtTimePVPBattleMode;

		// Token: 0x04005F16 RID: 24342
		public int ClimbTowerFinishedFloorId;

		// Token: 0x04005F17 RID: 24343
		public int GuildMassiveCombatEliminateRate;
	}
}
