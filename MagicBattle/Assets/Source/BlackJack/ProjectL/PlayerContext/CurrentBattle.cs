using System;
using System.Collections.Generic;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x0200090A RID: 2314
	[CustomLuaClass]
	public class CurrentBattle
	{
		// Token: 0x0600864E RID: 34382 RVA: 0x00268430 File Offset: 0x00266630
		public void Clear()
		{
			this.BattleType = BattleType.None;
			this.BattleInfo = null;
			this.PVPBattleInfo = null;
			this.RealTimePVPBattleInfo = null;
			this.RealTimePVPBattleReport = null;
			this.ArenaBattleInfo = null;
			this.ArenaDefendRuleInfo = null;
			this.ArenaDefenderPlayerLevel = 0;
			this.ArenaDefenderHeros = null;
			this.ArenaDefenderTrainTechs = null;
			this.ArenaBattleReport = null;
			this.IsArenaRevenge = false;
		}

		// Token: 0x04005F1C RID: 24348
		public BattleType BattleType;

		// Token: 0x04005F1D RID: 24349
		public ConfigDataBattleInfo BattleInfo;

		// Token: 0x04005F1E RID: 24350
		public ConfigDataPVPBattleInfo PVPBattleInfo;

		// Token: 0x04005F1F RID: 24351
		public ConfigDataRealTimePVPBattleInfo RealTimePVPBattleInfo;

		// Token: 0x04005F20 RID: 24352
		public RealTimePVPBattleReport RealTimePVPBattleReport;

		// Token: 0x04005F21 RID: 24353
		public ConfigDataArenaBattleInfo ArenaBattleInfo;

		// Token: 0x04005F22 RID: 24354
		public ConfigDataArenaDefendRuleInfo ArenaDefendRuleInfo;

		// Token: 0x04005F23 RID: 24355
		public int ArenaDefenderPlayerLevel;

		// Token: 0x04005F24 RID: 24356
		public List<BattleHero> ArenaDefenderHeros;

		// Token: 0x04005F25 RID: 24357
		public List<TrainingTech> ArenaDefenderTrainTechs;

		// Token: 0x04005F26 RID: 24358
		public ArenaBattleReport ArenaBattleReport;

		// Token: 0x04005F27 RID: 24359
		public bool IsArenaRevenge;
	}
}
