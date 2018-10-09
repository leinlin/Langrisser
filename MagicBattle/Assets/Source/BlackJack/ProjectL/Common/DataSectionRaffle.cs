using System;
using System.Collections.Generic;
using System.Linq;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004ED RID: 1261
	[CustomLuaClass]
	public class DataSectionRaffle : DataSection
	{
		// Token: 0x06004C8B RID: 19595 RVA: 0x00178CFC File Offset: 0x00176EFC
		public DataSectionRaffle()
		{
			this.RafflePools = new Dictionary<int, RafflePool>();
		}

		// Token: 0x06004C8C RID: 19596 RVA: 0x00178D10 File Offset: 0x00176F10
		public override object SerializeToClient()
		{
			DSRaffleNtf dsraffleNtf = new DSRaffleNtf
			{
				Version = (uint)base.Version
			};
			dsraffleNtf.RafflePools.AddRange(RafflePool.RafflePools2PbActivityRafflePools(this.RafflePools.Values.ToList<RafflePool>()));
			return dsraffleNtf;
		}

		// Token: 0x06004C8D RID: 19597 RVA: 0x00178D54 File Offset: 0x00176F54
		public override void ClearInitedData()
		{
			this.RafflePools.Clear();
		}

		// Token: 0x06004C8E RID: 19598 RVA: 0x00178D64 File Offset: 0x00176F64
		public void InitRafflePools(List<RafflePool> rafflePools)
		{
			foreach (RafflePool rafflePool in rafflePools)
			{
				this.RafflePools.Add(rafflePool.PoolId, rafflePool);
			}
		}

		// Token: 0x06004C8F RID: 19599 RVA: 0x00178DC8 File Offset: 0x00176FC8
		public void SetRafflePools(List<RafflePool> rafflePools)
		{
			this.InitRafflePools(rafflePools);
			base.SetDirty(true);
		}

		// Token: 0x06004C90 RID: 19600 RVA: 0x00178DD8 File Offset: 0x00176FD8
		public void RemoveRafflePool(int poolId)
		{
			if (this.RafflePools.ContainsKey(poolId))
			{
				this.RafflePools.Remove(poolId);
				base.SetDirty(true);
			}
		}

		// Token: 0x06004C91 RID: 19601 RVA: 0x00178E00 File Offset: 0x00177000
		public RafflePool GetRafflePool(int rafflePoolId)
		{
			RafflePool result;
			this.RafflePools.TryGetValue(rafflePoolId, out result);
			return result;
		}

		// Token: 0x06004C92 RID: 19602 RVA: 0x00178E20 File Offset: 0x00177020
		public void Drawed(RafflePool pool, int darwedRaffleId)
		{
			pool.Drawed(darwedRaffleId);
			base.SetDirty(true);
		}

		// Token: 0x170012AA RID: 4778
		// (get) Token: 0x06004C93 RID: 19603 RVA: 0x00178E30 File Offset: 0x00177030
		// (set) Token: 0x06004C94 RID: 19604 RVA: 0x00178E38 File Offset: 0x00177038
		public Dictionary<int, RafflePool> RafflePools { get; set; }
	}
}
