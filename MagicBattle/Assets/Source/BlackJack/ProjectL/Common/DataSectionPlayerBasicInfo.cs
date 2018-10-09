using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using BlackJack.UtilityTools;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004EC RID: 1260
	[CustomLuaClass]
	public class DataSectionPlayerBasicInfo : DataSection
	{
		// Token: 0x06004C58 RID: 19544 RVA: 0x00178784 File Offset: 0x00176984
		public override object SerializeToClient()
		{
			DSPlayerBasicNtf dsplayerBasicNtf = new DSPlayerBasicNtf();
			dsplayerBasicNtf.Version = (uint)base.Version;
			dsplayerBasicNtf.PlayerLevel = this.PlayerLevel;
			dsplayerBasicNtf.RechargeCsystal = (long)this.RechargeCrystal;
			dsplayerBasicNtf.RechargeRMB = this.RechargeRMB;
			dsplayerBasicNtf.ExpCurr = this.Exp;
			dsplayerBasicNtf.Energy = this.Energy;
			dsplayerBasicNtf.Gold = (long)this.Gold;
			dsplayerBasicNtf.Crystal = (long)this.Crystal;
			dsplayerBasicNtf.SignDays = this.SignDays;
			dsplayerBasicNtf.HeadIcon = this.HeadIcon;
			dsplayerBasicNtf.LastSignTime = this.LastSignTime.Ticks;
			dsplayerBasicNtf.BuyEngryNums = this.BuyEngryNums;
			dsplayerBasicNtf.PlayerActionNextFlushTime = this.NextFlushPlayerActionTime.Ticks;
			dsplayerBasicNtf.ArenaTickets = this.ArenaTickets;
			dsplayerBasicNtf.ArenaHonour = this.ArenaHonour;
			dsplayerBasicNtf.RealTimePVPHonor = this.RealTimePVPHonor;
			dsplayerBasicNtf.BuyArenaTicketsNums = this.BuyArenaTicketsNums;
			dsplayerBasicNtf.GuideCompleteFlags.AddRange(this.GuideCompleteFlags.Bits);
			dsplayerBasicNtf.EnergyFlushTime = this.EnergyFlushTime.Ticks;
			dsplayerBasicNtf.FriendshipPoints = this.FriendshipPoints;
			dsplayerBasicNtf.CreateTime = this.CreateTime.Ticks;
			dsplayerBasicNtf.OpenGameRating = this.OpenGameRating;
			dsplayerBasicNtf.SkinTickets = this.SkinTickets;
			dsplayerBasicNtf.MemoryEssence = this.MemoryEssence;
			dsplayerBasicNtf.MithralStone = this.MithralStone;
			dsplayerBasicNtf.MemoryStoreOpen = this.MemoryStoreOpen;
			dsplayerBasicNtf.BrillianceMithralStone = this.BrillianceMithralStone;
			return dsplayerBasicNtf;
		}

		// Token: 0x06004C59 RID: 19545 RVA: 0x00178900 File Offset: 0x00176B00
		public override void ClearInitedData()
		{
			this.GuideCompleteFlags.Clear();
		}

		// Token: 0x06004C5A RID: 19546 RVA: 0x00178910 File Offset: 0x00176B10
		public void SetPlayerExp(int currentExp)
		{
			this.Exp = currentExp;
			base.SetDirty(true);
		}

		// Token: 0x06004C5B RID: 19547 RVA: 0x00178920 File Offset: 0x00176B20
		public void ChangePlayerName(string newName)
		{
			this.PlayerName = newName;
			base.SetDirty(true);
		}

		// Token: 0x06004C5C RID: 19548 RVA: 0x00178930 File Offset: 0x00176B30
		public void PlayerLevelUp()
		{
			this.PlayerLevel++;
			this.Exp = 0;
			base.SetDirty(true);
		}

		// Token: 0x06004C5D RID: 19549 RVA: 0x00178950 File Offset: 0x00176B50
		public int AddRechargedCrystal(int nums)
		{
			this.RechargeCrystal += nums;
			base.SetDirty(true);
			return this.RechargeCrystal;
		}

		// Token: 0x06004C5E RID: 19550 RVA: 0x00178970 File Offset: 0x00176B70
		public long AddRechargeRMB(int nums)
		{
			this.RechargeRMB += (long)nums;
			base.SetDirty(true);
			return this.RechargeRMB;
		}

		// Token: 0x06004C5F RID: 19551 RVA: 0x00178990 File Offset: 0x00176B90
		public int AddGold(int nums)
		{
			int gold = this.Gold;
			this.Gold += nums;
			if (this.Gold < 0 && gold > 0 && nums > 0)
			{
				this.Gold = int.MaxValue;
			}
			base.SetDirty(true);
			return this.Gold;
		}

		// Token: 0x06004C60 RID: 19552 RVA: 0x001789E4 File Offset: 0x00176BE4
		public int AddCrystal(int nums)
		{
			this.Crystal += nums;
			base.SetDirty(true);
			return this.Crystal;
		}

		// Token: 0x06004C61 RID: 19553 RVA: 0x00178A04 File Offset: 0x00176C04
		public void SetUserGuide(List<int> completeStepIds)
		{
			this.GuideCompleteFlags.SetBits(completeStepIds);
			base.SetDirty(true);
		}

		// Token: 0x06004C62 RID: 19554 RVA: 0x00178A1C File Offset: 0x00176C1C
		public void CleanUserGuide(List<int> completeStepIds)
		{
			this.GuideCompleteFlags.CleanBits(completeStepIds);
			base.SetDirty(true);
		}

		// Token: 0x06004C63 RID: 19555 RVA: 0x00178A34 File Offset: 0x00176C34
		public bool IsUserGuideCompleted(int stepId)
		{
			return this.GuideCompleteFlags.IsBitSet(stepId);
		}

		// Token: 0x06004C64 RID: 19556 RVA: 0x00178A44 File Offset: 0x00176C44
		public void SetEnergy(int energy)
		{
			this.Energy = energy;
			base.SetDirty(true);
		}

		// Token: 0x06004C65 RID: 19557 RVA: 0x00178A54 File Offset: 0x00176C54
		public void InitSignDays(int signDays)
		{
			this.SignDays = signDays;
		}

		// Token: 0x06004C66 RID: 19558 RVA: 0x00178A60 File Offset: 0x00176C60
		public void ResetSignDays()
		{
			this.SignDays = 0;
			base.SetDirty(true);
		}

		// Token: 0x06004C67 RID: 19559 RVA: 0x00178A70 File Offset: 0x00176C70
		public void SetSignDays(int days)
		{
			this.SignDays = days;
			base.SetDirty(true);
		}

		// Token: 0x06004C68 RID: 19560 RVA: 0x00178A80 File Offset: 0x00176C80
		public void AddSignDays()
		{
			this.SignDays++;
			base.SetDirty(true);
		}

		// Token: 0x06004C69 RID: 19561 RVA: 0x00178A98 File Offset: 0x00176C98
		public void SetLastSignTime(DateTime time)
		{
			this.LastSignTime = time;
			base.SetDirty(true);
		}

		// Token: 0x06004C6A RID: 19562 RVA: 0x00178AA8 File Offset: 0x00176CA8
		public void ResetBuyEngryNums()
		{
			this.BuyEngryNums = 0;
			base.SetDirty(true);
		}

		// Token: 0x06004C6B RID: 19563 RVA: 0x00178AB8 File Offset: 0x00176CB8
		public void BuyEngry()
		{
			this.BuyEngryNums++;
			base.SetDirty(true);
		}

		// Token: 0x06004C6C RID: 19564 RVA: 0x00178AD0 File Offset: 0x00176CD0
		public void BuyArenaTickets()
		{
			this.BuyArenaTicketsNums++;
			base.SetDirty(true);
		}

		// Token: 0x06004C6D RID: 19565 RVA: 0x00178AE8 File Offset: 0x00176CE8
		public void ResetBuyArenaTicketsNums()
		{
			this.BuyArenaTicketsNums = 0;
			base.SetDirty(true);
		}

		// Token: 0x06004C6E RID: 19566 RVA: 0x00178AF8 File Offset: 0x00176CF8
		public void SetNextPlayerActionFlushTime(DateTime setTime)
		{
			this.NextFlushPlayerActionTime = setTime;
			base.SetDirty(true);
		}

		// Token: 0x06004C6F RID: 19567 RVA: 0x00178B08 File Offset: 0x00176D08
		public void SetArenaTickets(int nums)
		{
			this.ArenaTickets = nums;
			base.SetDirty(true);
		}

		// Token: 0x06004C70 RID: 19568 RVA: 0x00178B18 File Offset: 0x00176D18
		public void AddArenaTickets(int nums)
		{
			this.ArenaTickets += nums;
			base.SetDirty(true);
		}

		// Token: 0x06004C71 RID: 19569 RVA: 0x00178B30 File Offset: 0x00176D30
		public int AddMemoryEssence(int nums)
		{
			this.MemoryEssence += nums;
			base.SetDirty(true);
			return this.MemoryEssence;
		}

		// Token: 0x06004C72 RID: 19570 RVA: 0x00178B50 File Offset: 0x00176D50
		public void SetMemoryEssence(int nums)
		{
			this.MemoryEssence = nums;
			base.SetDirty(true);
		}

		// Token: 0x06004C73 RID: 19571 RVA: 0x00178B60 File Offset: 0x00176D60
		public int AddBrillianceMithralStone(int nums)
		{
			this.BrillianceMithralStone += nums;
			base.SetDirty(true);
			return this.BrillianceMithralStone;
		}

		// Token: 0x06004C74 RID: 19572 RVA: 0x00178B80 File Offset: 0x00176D80
		public int AddMithralStone(int nums)
		{
			this.MithralStone += nums;
			base.SetDirty(true);
			return this.MithralStone;
		}

		// Token: 0x06004C75 RID: 19573 RVA: 0x00178BA0 File Offset: 0x00176DA0
		public int AddGuildMedal(int nums)
		{
			this.GuildMedal += nums;
			base.SetDirty(true);
			return this.GuildMedal;
		}

		// Token: 0x06004C76 RID: 19574 RVA: 0x00178BC0 File Offset: 0x00176DC0
		public int AddArenaHonour(int nums)
		{
			this.ArenaHonour += nums;
			base.SetDirty(true);
			return this.ArenaHonour;
		}

		// Token: 0x06004C77 RID: 19575 RVA: 0x00178BE0 File Offset: 0x00176DE0
		public int AddRealTimePVPHonor(int nums)
		{
			this.RealTimePVPHonor += nums;
			base.SetDirty(true);
			return this.RealTimePVPHonor;
		}

		// Token: 0x06004C78 RID: 19576 RVA: 0x00178C00 File Offset: 0x00176E00
		public int AddFriendshipPoints(int nums)
		{
			this.FriendshipPoints += nums;
			base.SetDirty(true);
			return this.FriendshipPoints;
		}

		// Token: 0x06004C79 RID: 19577 RVA: 0x00178C20 File Offset: 0x00176E20
		public void SetEnergyFlushTime(DateTime time)
		{
			this.EnergyFlushTime = time;
			base.SetDirty(true);
		}

		// Token: 0x06004C7A RID: 19578 RVA: 0x00178C30 File Offset: 0x00176E30
		public void SetHeadIcon(int headIcon)
		{
			this.HeadIcon = headIcon;
			base.SetDirty(true);
		}

		// Token: 0x06004C7B RID: 19579 RVA: 0x00178C40 File Offset: 0x00176E40
		public int AddSkinTickets(int nums)
		{
			this.SkinTickets += nums;
			base.SetDirty(true);
			return this.SkinTickets;
		}

		// Token: 0x06004C7C RID: 19580 RVA: 0x00178C60 File Offset: 0x00176E60
		public void SetMemoryStoreOpenStatus(bool open)
		{
			this.MemoryStoreOpen = open;
			base.SetDirty(true);
		}

		// Token: 0x170012A3 RID: 4771
		// (get) Token: 0x06004C7D RID: 19581 RVA: 0x00178C70 File Offset: 0x00176E70
		// (set) Token: 0x06004C7E RID: 19582 RVA: 0x00178C78 File Offset: 0x00176E78
		public string UserId { get; set; }

		// Token: 0x170012A4 RID: 4772
		// (get) Token: 0x06004C7F RID: 19583 RVA: 0x00178C84 File Offset: 0x00176E84
		// (set) Token: 0x06004C80 RID: 19584 RVA: 0x00178C8C File Offset: 0x00176E8C
		public string PlayerName { get; set; }

		// Token: 0x170012A5 RID: 4773
		// (get) Token: 0x06004C81 RID: 19585 RVA: 0x00178C98 File Offset: 0x00176E98
		// (set) Token: 0x06004C82 RID: 19586 RVA: 0x00178CA0 File Offset: 0x00176EA0
		public long RechargeRMB { get; set; }

		// Token: 0x170012A6 RID: 4774
		// (get) Token: 0x06004C83 RID: 19587 RVA: 0x00178CAC File Offset: 0x00176EAC
		// (set) Token: 0x06004C84 RID: 19588 RVA: 0x00178CB4 File Offset: 0x00176EB4
		public int Energy { get; set; }

		// Token: 0x170012A7 RID: 4775
		// (get) Token: 0x06004C85 RID: 19589 RVA: 0x00178CC0 File Offset: 0x00176EC0
		// (set) Token: 0x06004C86 RID: 19590 RVA: 0x00178CC8 File Offset: 0x00176EC8
		public int Exp { get; set; }

		// Token: 0x170012A8 RID: 4776
		// (get) Token: 0x06004C87 RID: 19591 RVA: 0x00178CD4 File Offset: 0x00176ED4
		// (set) Token: 0x06004C88 RID: 19592 RVA: 0x00178CDC File Offset: 0x00176EDC
		public int SignDays { get; set; }

		// Token: 0x170012A9 RID: 4777
		// (get) Token: 0x06004C89 RID: 19593 RVA: 0x00178CE8 File Offset: 0x00176EE8
		// (set) Token: 0x06004C8A RID: 19594 RVA: 0x00178CF0 File Offset: 0x00176EF0
		public int HeadIcon { get; set; }

		// Token: 0x0400389B RID: 14491
		public int PlayerLevel = 1;

		// Token: 0x0400389C RID: 14492
		public int RechargeCrystal;

		// Token: 0x0400389F RID: 14495
		public int Gold;

		// Token: 0x040038A0 RID: 14496
		public int Crystal;

		// Token: 0x040038A2 RID: 14498
		public BitArray GuideCompleteFlags = new BitArray();

		// Token: 0x040038A3 RID: 14499
		public DateTime EnergyFlushTime = DateTime.MinValue;

		// Token: 0x040038A4 RID: 14500
		public DateTime CreateTime = DateTime.MinValue;

		// Token: 0x040038A5 RID: 14501
		public DateTime CreateTimeUtc = DateTime.MinValue;

		// Token: 0x040038A6 RID: 14502
		public DateTime LogoutTime = DateTime.MinValue;

		// Token: 0x040038A7 RID: 14503
		public DateTime LoginTime = DateTime.MinValue;

		// Token: 0x040038A8 RID: 14504
		public DateTime LastSignTime = DateTime.MinValue;

		// Token: 0x040038AB RID: 14507
		public int BuyEngryNums;

		// Token: 0x040038AC RID: 14508
		public int BuyArenaTicketsNums;

		// Token: 0x040038AD RID: 14509
		public DateTime NextFlushPlayerActionTime = DateTime.MinValue;

		// Token: 0x040038AE RID: 14510
		public int ArenaTickets;

		// Token: 0x040038AF RID: 14511
		public int ArenaHonour;

		// Token: 0x040038B0 RID: 14512
		public int RealTimePVPHonor;

		// Token: 0x040038B1 RID: 14513
		public int FriendshipPoints;

		// Token: 0x040038B2 RID: 14514
		public bool OpenGameRating;

		// Token: 0x040038B3 RID: 14515
		public int SkinTickets;

		// Token: 0x040038B4 RID: 14516
		public int MemoryEssence;

		// Token: 0x040038B5 RID: 14517
		public int MithralStone;

		// Token: 0x040038B6 RID: 14518
		public int BrillianceMithralStone;

		// Token: 0x040038B7 RID: 14519
		public int GuildMedal;

		// Token: 0x040038B8 RID: 14520
		public bool MemoryStoreOpen;
	}
}
