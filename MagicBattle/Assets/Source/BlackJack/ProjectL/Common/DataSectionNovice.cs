using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using BlackJack.UtilityTools;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004E9 RID: 1257
	[CustomLuaClass]
	public class DataSectionNovice : DataSection
	{
		// Token: 0x06004C39 RID: 19513 RVA: 0x00178388 File Offset: 0x00176588
		public override void ClearInitedData()
		{
			base.ClearInitedData();
			this.MissionPoints = 0;
			this.RewardClaimedSlots.Clear();
		}

		// Token: 0x06004C3A RID: 19514 RVA: 0x001783A4 File Offset: 0x001765A4
		public override object SerializeToClient()
		{
			DSNoviceNtf dsnoviceNtf = new DSNoviceNtf
			{
				Version = (uint)base.Version,
				Novice = new ProNovice
				{
					MissionPoints = this.MissionPoints
				}
			};
			dsnoviceNtf.Novice.RewardClaimedSlots.AddRange(this.RewardClaimedSlots);
			return dsnoviceNtf;
		}

		// Token: 0x06004C3B RID: 19515 RVA: 0x001783F8 File Offset: 0x001765F8
		public void AddMissionPoints(int Delta)
		{
			this.MissionPoints += Delta;
			base.SetDirty(true);
		}

		// Token: 0x06004C3C RID: 19516 RVA: 0x00178410 File Offset: 0x00176610
		public void AddRewardClaimSlot(int Slot)
		{
			this.RewardClaimedSlots.AddUnique(Slot);
			base.SetDirty(true);
		}

		// Token: 0x170012A1 RID: 4769
		// (get) Token: 0x06004C3D RID: 19517 RVA: 0x00178428 File Offset: 0x00176628
		// (set) Token: 0x06004C3E RID: 19518 RVA: 0x00178430 File Offset: 0x00176630
		public int MissionPoints { get; set; }

		// Token: 0x04003894 RID: 14484
		public List<int> RewardClaimedSlots = new List<int>();
	}
}
