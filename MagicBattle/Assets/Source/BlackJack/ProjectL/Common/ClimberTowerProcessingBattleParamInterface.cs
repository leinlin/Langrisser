using System;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000522 RID: 1314
	public class ClimberTowerProcessingBattleParamInterface
	{
		// Token: 0x06004E9D RID: 20125 RVA: 0x0017D440 File Offset: 0x0017B640
		public ClimberTowerProcessingBattleParamInterface(ProcessingBattle processingBattle)
		{
			this.processingBattle = processingBattle;
			this.CheckInit();
		}

		// Token: 0x06004E9E RID: 20126 RVA: 0x0017D458 File Offset: 0x0017B658
		private void CheckInit()
		{
			if (this.processingBattle.Params.Count < 4)
			{
				while (this.processingBattle.Params.Count != 4)
				{
					this.processingBattle.Params.Add(0);
				}
			}
		}

		// Token: 0x06004E9F RID: 20127 RVA: 0x0017D4A8 File Offset: 0x0017B6A8
		public int GetFloorId()
		{
			return this.processingBattle.Params[0];
		}

		// Token: 0x06004EA0 RID: 20128 RVA: 0x0017D4BC File Offset: 0x0017B6BC
		public void SetFloorId(int floorId)
		{
			this.processingBattle.Params[0] = floorId;
		}

		// Token: 0x06004EA1 RID: 20129 RVA: 0x0017D4D0 File Offset: 0x0017B6D0
		public int GetLevelId()
		{
			return this.processingBattle.Params[1];
		}

		// Token: 0x06004EA2 RID: 20130 RVA: 0x0017D4E4 File Offset: 0x0017B6E4
		public void SetLevelId(int floorId)
		{
			this.processingBattle.Params[1] = floorId;
		}

		// Token: 0x06004EA3 RID: 20131 RVA: 0x0017D4F8 File Offset: 0x0017B6F8
		public int GetRuleId()
		{
			return this.processingBattle.Params[2];
		}

		// Token: 0x06004EA4 RID: 20132 RVA: 0x0017D50C File Offset: 0x0017B70C
		public void SetRuleId(int buffId)
		{
			this.processingBattle.Params[2] = buffId;
		}

		// Token: 0x06004EA5 RID: 20133 RVA: 0x0017D520 File Offset: 0x0017B720
		public int GetBonusHeroGroupId()
		{
			return this.processingBattle.Params[3];
		}

		// Token: 0x06004EA6 RID: 20134 RVA: 0x0017D534 File Offset: 0x0017B734
		public void SetBonusHeroGroupId(int groupId)
		{
			this.processingBattle.Params[3] = groupId;
		}

		// Token: 0x0400395D RID: 14685
		private readonly ProcessingBattle processingBattle;
	}
}
