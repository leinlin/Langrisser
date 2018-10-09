using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000521 RID: 1313
	[CustomLuaClass]
	public class ProcessingBattle
	{
		// Token: 0x17001323 RID: 4899
		// (get) Token: 0x06004E93 RID: 20115 RVA: 0x0017D340 File Offset: 0x0017B540
		// (set) Token: 0x06004E94 RID: 20116 RVA: 0x0017D348 File Offset: 0x0017B548
		public BattleType Type { get; set; }

		// Token: 0x17001324 RID: 4900
		// (get) Token: 0x06004E95 RID: 20117 RVA: 0x0017D354 File Offset: 0x0017B554
		// (set) Token: 0x06004E96 RID: 20118 RVA: 0x0017D35C File Offset: 0x0017B55C
		public int TypeId { get; set; }

		// Token: 0x17001325 RID: 4901
		// (get) Token: 0x06004E97 RID: 20119 RVA: 0x0017D368 File Offset: 0x0017B568
		// (set) Token: 0x06004E98 RID: 20120 RVA: 0x0017D370 File Offset: 0x0017B570
		public int RandomSeed { get; set; }

		// Token: 0x17001326 RID: 4902
		// (get) Token: 0x06004E99 RID: 20121 RVA: 0x0017D37C File Offset: 0x0017B57C
		// (set) Token: 0x06004E9A RID: 20122 RVA: 0x0017D384 File Offset: 0x0017B584
		public int ArmyRandomSeed { get; set; }

		// Token: 0x06004E9B RID: 20123 RVA: 0x0017D390 File Offset: 0x0017B590
		public static ProBattleProcessing BattleProcessingToPbBattleProcessing(ProcessingBattle battleInfo)
		{
			ProBattleProcessing proBattleProcessing = new ProBattleProcessing
			{
				Type = (int)battleInfo.Type,
				TypeId = battleInfo.TypeId,
				RandomSeed = battleInfo.RandomSeed,
				ArmyRandomSeed = battleInfo.ArmyRandomSeed
			};
			proBattleProcessing.Params.AddRange(battleInfo.Params);
			return proBattleProcessing;
		}

		// Token: 0x06004E9C RID: 20124 RVA: 0x0017D3E8 File Offset: 0x0017B5E8
		public static ProcessingBattle PbBattleProcessingToBattleProcessing(ProBattleProcessing pbBattleInfo)
		{
			ProcessingBattle processingBattle = new ProcessingBattle
			{
				Type = (BattleType)pbBattleInfo.Type,
				TypeId = pbBattleInfo.TypeId,
				RandomSeed = pbBattleInfo.RandomSeed,
				ArmyRandomSeed = pbBattleInfo.ArmyRandomSeed
			};
			processingBattle.Params.AddRange(pbBattleInfo.Params);
			return processingBattle;
		}

		// Token: 0x0400395C RID: 14684
		public List<int> Params = new List<int>();
	}
}
