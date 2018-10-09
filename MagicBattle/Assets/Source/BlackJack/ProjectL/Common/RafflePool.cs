using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000568 RID: 1384
	[CustomLuaClass]
	public class RafflePool
	{
		// Token: 0x060050C1 RID: 20673 RVA: 0x00181C94 File Offset: 0x0017FE94
		public RafflePool(int poolId)
		{
			this.PoolId = poolId;
			this.DrawedRaffleIds = new HashSet<int>();
			this.DrawedCount = 0;
			this.ActivityInstanceId = 0UL;
		}

		// Token: 0x060050C2 RID: 20674 RVA: 0x00181CC0 File Offset: 0x0017FEC0
		public static List<ProRafflePool> RafflePools2PbActivityRafflePools(List<RafflePool> rafflePools)
		{
			List<ProRafflePool> list = new List<ProRafflePool>();
			foreach (RafflePool rafflePool in rafflePools)
			{
				ProRafflePool proRafflePool = RafflePool.RafflePool2PbRafflePool(rafflePool);
				if (proRafflePool != null)
				{
					list.Add(proRafflePool);
				}
			}
			return list;
		}

		// Token: 0x060050C3 RID: 20675 RVA: 0x00181D2C File Offset: 0x0017FF2C
		private static ProRafflePool RafflePool2PbRafflePool(RafflePool rafflePool)
		{
			ProRafflePool proRafflePool = new ProRafflePool
			{
				RafflePoolId = rafflePool.PoolId,
				DrawedCount = rafflePool.DrawedCount,
				FreeDrawedCount = rafflePool.FreeDrawedCount
			};
			proRafflePool.DrawedItemIds.AddRange(rafflePool.DrawedRaffleIds);
			return proRafflePool;
		}

		// Token: 0x060050C4 RID: 20676 RVA: 0x00181D78 File Offset: 0x0017FF78
		public static RafflePool PBRafflePoolToRafflePool(ProRafflePool pbRafflePool)
		{
			RafflePool rafflePool = new RafflePool(pbRafflePool.RafflePoolId)
			{
				DrawedCount = pbRafflePool.DrawedCount,
				FreeDrawedCount = pbRafflePool.FreeDrawedCount
			};
			pbRafflePool.DrawedItemIds.ForEach(delegate(int e)
			{
				rafflePool.DrawedRaffleIds.Add(e);
			});
			return rafflePool;
		}

		// Token: 0x060050C5 RID: 20677 RVA: 0x00181DD4 File Offset: 0x0017FFD4
		public static List<RafflePool> PBRafflePoolsToRafflePools(List<ProRafflePool> pbRafflePools)
		{
			if (RafflePool.<>f__mg$cache0 == null)
			{
				RafflePool.<>f__mg$cache0 = new Func<ProRafflePool, RafflePool>(RafflePool.PBRafflePoolToRafflePool);
			}
			return pbRafflePools.Select(RafflePool.<>f__mg$cache0).ToList<RafflePool>();
		}

		// Token: 0x060050C6 RID: 20678 RVA: 0x00181E00 File Offset: 0x00180000
		public void Drawed(int darwedRaffleId)
		{
			this.DrawedRaffleIds.Add(darwedRaffleId);
		}

		// Token: 0x170013EC RID: 5100
		// (get) Token: 0x060050C7 RID: 20679 RVA: 0x00181E10 File Offset: 0x00180010
		// (set) Token: 0x060050C8 RID: 20680 RVA: 0x00181E18 File Offset: 0x00180018
		public ulong ActivityInstanceId { get; set; }

		// Token: 0x170013ED RID: 5101
		// (get) Token: 0x060050C9 RID: 20681 RVA: 0x00181E24 File Offset: 0x00180024
		// (set) Token: 0x060050CA RID: 20682 RVA: 0x00181E2C File Offset: 0x0018002C
		public int PoolId { get; set; }

		// Token: 0x170013EE RID: 5102
		// (get) Token: 0x060050CB RID: 20683 RVA: 0x00181E38 File Offset: 0x00180038
		// (set) Token: 0x060050CC RID: 20684 RVA: 0x00181E40 File Offset: 0x00180040
		public HashSet<int> DrawedRaffleIds { get; set; }

		// Token: 0x170013EF RID: 5103
		// (get) Token: 0x060050CD RID: 20685 RVA: 0x00181E4C File Offset: 0x0018004C
		// (set) Token: 0x060050CE RID: 20686 RVA: 0x00181E54 File Offset: 0x00180054
		public int DrawedCount { get; set; }

		// Token: 0x170013F0 RID: 5104
		// (get) Token: 0x060050CF RID: 20687 RVA: 0x00181E60 File Offset: 0x00180060
		// (set) Token: 0x060050D0 RID: 20688 RVA: 0x00181E68 File Offset: 0x00180068
		public int FreeDrawedCount { get; set; }

		// Token: 0x170013F1 RID: 5105
		// (get) Token: 0x060050D1 RID: 20689 RVA: 0x00181E74 File Offset: 0x00180074
		// (set) Token: 0x060050D2 RID: 20690 RVA: 0x00181E7C File Offset: 0x0018007C
		public ConfigDataRafflePoolInfo Config { get; set; }

		// Token: 0x04003A31 RID: 14897
		[CompilerGenerated]
		private static Func<ProRafflePool, RafflePool> <>f__mg$cache0;
	}
}
