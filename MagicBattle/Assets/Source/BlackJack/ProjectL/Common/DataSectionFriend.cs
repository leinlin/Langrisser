using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using BlackJack.UtilityTools;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004D1 RID: 1233
	[CustomLuaClass]
	public class DataSectionFriend : DataSection
	{
		// Token: 0x06004AFB RID: 19195 RVA: 0x001755A8 File Offset: 0x001737A8
		public override void ClearInitedData()
		{
			base.ClearInitedData();
			this.LikedUsers.Clear();
			this.FriendshipPointsSent.Clear();
			this.FriendshipPointsReceived.Clear();
			this.FriendshipPointsClaimedToday = 0;
			this.FriendshipPointsFromFightWithFriendsToday = 0;
			this.BannedTime = DateTime.MinValue;
		}

		// Token: 0x06004AFC RID: 19196 RVA: 0x001755F8 File Offset: 0x001737F8
		public override object SerializeToClient()
		{
			DSFriendNtf dsfriendNtf = new DSFriendNtf();
			dsfriendNtf.FriendshipPointsFromFightWithFriendsToday = this.FriendshipPointsFromFightWithFriendsToday;
			dsfriendNtf.FriendshipPointsClaimedToday = this.FriendshipPointsClaimedToday;
			dsfriendNtf.Likes = this.Likes;
			dsfriendNtf.LikedUsers.AddRange(this.LikedUsers);
			dsfriendNtf.FriendshipPointsSent.AddRange(this.FriendshipPointsSent);
			dsfriendNtf.FriendshipPointsReceived.AddRange(this.FriendshipPointsReceived);
			dsfriendNtf.SetInfo = BusinessCardInfoSet.ToProtocol(this.BusinessCardSetInfo);
			dsfriendNtf.Version = (uint)base.Version;
			dsfriendNtf.BannedTime = this.BannedTime.Ticks;
			return dsfriendNtf;
		}

		// Token: 0x06004AFD RID: 19197 RVA: 0x00175694 File Offset: 0x00173894
		public void SetBusinessCardInfo(BusinessCardInfoSet setInfo)
		{
			this.BusinessCardSetInfo = setInfo;
			base.SetDirty(true);
		}

		// Token: 0x06004AFE RID: 19198 RVA: 0x001756A4 File Offset: 0x001738A4
		public void OnFlushOfTime()
		{
			this.FriendshipPointsSent.Clear();
			this.LikedUsers.Clear();
			this.FriendshipPointsFromFightWithFriendsToday = 0;
			this.FriendshipPointsClaimedToday = 0;
			base.SetDirty(true);
		}

		// Token: 0x06004AFF RID: 19199 RVA: 0x001756D4 File Offset: 0x001738D4
		public void ClearLikedUsers()
		{
			this.LikedUsers.Clear();
			base.SetDirty(true);
		}

		// Token: 0x06004B00 RID: 19200 RVA: 0x001756E8 File Offset: 0x001738E8
		public void SetLikes(int likes)
		{
			this.Likes = likes;
			base.SetDirty(true);
		}

		// Token: 0x06004B01 RID: 19201 RVA: 0x001756F8 File Offset: 0x001738F8
		public int AddLikes(int addValue = 1)
		{
			this.Likes += addValue;
			base.SetDirty(true);
			return this.Likes;
		}

		// Token: 0x06004B02 RID: 19202 RVA: 0x00175718 File Offset: 0x00173918
		public void AddLikedUser(string userId)
		{
			this.LikedUsers.Add(userId);
			base.SetDirty(true);
		}

		// Token: 0x06004B03 RID: 19203 RVA: 0x00175730 File Offset: 0x00173930
		public void AddFriendshipPointsReceivedUser(string userId)
		{
			this.FriendshipPointsReceived.AddUnique(userId);
			base.SetDirty(true);
		}

		// Token: 0x06004B04 RID: 19204 RVA: 0x00175748 File Offset: 0x00173948
		public bool RemoveFriendshipPointsReceivedUser(string userId)
		{
			bool result = this.FriendshipPointsReceived.Remove(userId);
			base.SetDirty(true);
			return result;
		}

		// Token: 0x06004B05 RID: 19205 RVA: 0x0017576C File Offset: 0x0017396C
		public bool RemoveFriendshipPointsSentUser(string userId)
		{
			bool result = this.FriendshipPointsSent.Remove(userId);
			base.SetDirty(true);
			return result;
		}

		// Token: 0x06004B06 RID: 19206 RVA: 0x00175790 File Offset: 0x00173990
		public void AddFriendshipPointsSentUser(string userId)
		{
			this.FriendshipPointsSent.AddUnique(userId);
			base.SetDirty(true);
		}

		// Token: 0x06004B07 RID: 19207 RVA: 0x001757A8 File Offset: 0x001739A8
		public void SetBusinessCardDesc(string desc)
		{
			this.BusinessCardSetInfo.Desc = desc;
			base.SetDirty(true);
		}

		// Token: 0x06004B08 RID: 19208 RVA: 0x001757C0 File Offset: 0x001739C0
		public void SetBusinessCardHeroSet(List<BusinessCardHeroSet> heroSets)
		{
			this.BusinessCardSetInfo.Heroes.Clear();
			this.BusinessCardSetInfo.Heroes.AddRange(heroSets);
			base.SetDirty(true);
		}

		// Token: 0x06004B09 RID: 19209 RVA: 0x001757EC File Offset: 0x001739EC
		public void SetRandomHeroAction(bool actionRandom)
		{
			this.BusinessCardSetInfo.IsActionRandom = actionRandom;
			base.SetDirty(true);
		}

		// Token: 0x06004B0A RID: 19210 RVA: 0x00175804 File Offset: 0x00173A04
		public void SetFriendshipPointsFromFightWithFriendsToday(int points)
		{
			this.FriendshipPointsFromFightWithFriendsToday = points;
			base.SetDirty(true);
		}

		// Token: 0x06004B0B RID: 19211 RVA: 0x00175814 File Offset: 0x00173A14
		public void SetFriendshipPointsClaimedToday(int times)
		{
			this.FriendshipPointsClaimedToday = times;
			base.SetDirty(true);
		}

		// Token: 0x06004B0C RID: 19212 RVA: 0x00175824 File Offset: 0x00173A24
		public bool IsBanned(DateTime currentTime)
		{
			return this.BannedTime != DateTime.MinValue && this.BannedTime >= currentTime;
		}

		// Token: 0x06004B0D RID: 19213 RVA: 0x0017584C File Offset: 0x00173A4C
		public void Ban(DateTime banTime)
		{
			this.BannedTime = banTime;
			if (this.BannedTime != DateTime.MinValue && this.BusinessCardSetInfo != null)
			{
				this.BusinessCardSetInfo.Desc = string.Empty;
			}
			base.SetDirty(true);
		}

		// Token: 0x17001276 RID: 4726
		// (get) Token: 0x06004B0E RID: 19214 RVA: 0x0017588C File Offset: 0x00173A8C
		// (set) Token: 0x06004B0F RID: 19215 RVA: 0x00175894 File Offset: 0x00173A94
		public DateTime BannedTime { get; set; }

		// Token: 0x17001277 RID: 4727
		// (get) Token: 0x06004B10 RID: 19216 RVA: 0x001758A0 File Offset: 0x00173AA0
		// (set) Token: 0x06004B11 RID: 19217 RVA: 0x001758A8 File Offset: 0x00173AA8
		public BusinessCardInfoSet BusinessCardSetInfo { get; set; }

		// Token: 0x17001278 RID: 4728
		// (get) Token: 0x06004B12 RID: 19218 RVA: 0x001758B4 File Offset: 0x00173AB4
		// (set) Token: 0x06004B13 RID: 19219 RVA: 0x001758BC File Offset: 0x00173ABC
		public int Likes { get; set; }

		// Token: 0x17001279 RID: 4729
		// (get) Token: 0x06004B14 RID: 19220 RVA: 0x001758C8 File Offset: 0x00173AC8
		// (set) Token: 0x06004B15 RID: 19221 RVA: 0x001758D0 File Offset: 0x00173AD0
		public int FriendshipPointsFromFightWithFriendsToday { get; set; }

		// Token: 0x1700127A RID: 4730
		// (get) Token: 0x06004B16 RID: 19222 RVA: 0x001758DC File Offset: 0x00173ADC
		// (set) Token: 0x06004B17 RID: 19223 RVA: 0x001758E4 File Offset: 0x00173AE4
		public int FriendshipPointsClaimedToday { get; set; }

		// Token: 0x04003850 RID: 14416
		public List<string> LikedUsers = new List<string>();

		// Token: 0x04003851 RID: 14417
		public List<string> FriendshipPointsSent = new List<string>();

		// Token: 0x04003852 RID: 14418
		public List<string> FriendshipPointsReceived = new List<string>();
	}
}
