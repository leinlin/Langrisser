using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x020008AD RID: 2221
	[HotFix]
	public class FriendComponent : FriendComponentCommon
	{
		// Token: 0x06006F97 RID: 28567 RVA: 0x001F3380 File Offset: 0x001F1580
		public FriendComponent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06006F98 RID: 28568 RVA: 0x001F33E8 File Offset: 0x001F15E8
		public override void Init()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Init_hotfix != null)
			{
				this.m_Init_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Init();
			this.Friends = new List<UserSummary>();
			this.Blacklist = new List<UserSummary>();
			this.Invite = new List<UserSummary>();
			this.Invited = new List<UserSummary>();
			this.GuildPlayers = new List<UserSummary>();
			this.RecentContactsChat = new List<UserSummary>();
			this.RecentContactsTeamBattle = new List<UserSummary>();
			this.PVPInviteInfos = new List<PVPInviteInfo>();
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
		}

		// Token: 0x06006F99 RID: 28569 RVA: 0x001F34BC File Offset: 0x001F16BC
		public override void PostInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostInit_hotfix != null)
			{
				this.m_PostInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.PostInit();
		}

		// Token: 0x06006F9A RID: 28570 RVA: 0x001F3524 File Offset: 0x001F1724
		public override void DeInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeInit_hotfix != null)
			{
				this.m_DeInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.Friends.Clear();
			this.Blacklist.Clear();
			this.GuildPlayers.Clear();
			this.Invite.Clear();
			this.Invited.Clear();
			this.RecentContactsChat.Clear();
			this.RecentContactsTeamBattle.Clear();
			this.PVPInviteInfos.Clear();
		}

		// Token: 0x06006F9B RID: 28571 RVA: 0x001F35DC File Offset: 0x001F17DC
		public ushort GetDSVersion()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDSVersion_hotfix != null)
			{
				return Convert.ToUInt16(this.m_GetDSVersion_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_friendDS.ClientVersion;
		}

		// Token: 0x06006F9C RID: 28572 RVA: 0x001F3654 File Offset: 0x001F1854
		public void Deserialize(DSFriendNtf ntf)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeserializeDSFriendNtf_hotfix != null)
			{
				this.m_DeserializeDSFriendNtf_hotfix.call(new object[]
				{
					this,
					ntf
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_friendDS.ClearInitedData();
			this.LoadFromPBData(ntf);
		}

		// Token: 0x06006F9D RID: 28573 RVA: 0x001F36D8 File Offset: 0x001F18D8
		private void LoadFromPBData(DSFriendNtf pbFriendInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LoadFromPBDataDSFriendNtf_hotfix != null)
			{
				this.m_LoadFromPBDataDSFriendNtf_hotfix.call(new object[]
				{
					this,
					pbFriendInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_friendDS.Likes = pbFriendInfo.Likes;
			this.m_friendDS.LikedUsers.AddRange(pbFriendInfo.LikedUsers);
			this.m_friendDS.BusinessCardSetInfo = BusinessCardInfoSet.FromProtocol(pbFriendInfo.SetInfo);
			this.m_friendDS.FriendshipPointsSent.AddRange(pbFriendInfo.FriendshipPointsSent);
			this.m_friendDS.FriendshipPointsReceived.AddRange(pbFriendInfo.FriendshipPointsReceived);
			this.m_friendDS.FriendshipPointsClaimedToday = pbFriendInfo.FriendshipPointsClaimedToday;
			this.m_friendDS.FriendshipPointsFromFightWithFriendsToday = pbFriendInfo.FriendshipPointsFromFightWithFriendsToday;
			this.m_friendDS.BannedTime = new DateTime(pbFriendInfo.BannedTime);
			this.m_friendDS.InitVersion((ushort)pbFriendInfo.Version, (ushort)pbFriendInfo.Version);
		}

		// Token: 0x06006F9E RID: 28574 RVA: 0x001F3804 File Offset: 0x001F1A04
		public void Deserialize(FriendInfoUpdateNtf ntf)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeserializeFriendInfoUpdateNtf_hotfix != null)
			{
				this.m_DeserializeFriendInfoUpdateNtf_hotfix.call(new object[]
				{
					this,
					ntf
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (ntf.Likes != 0)
			{
				this.m_friendDS.SetLikes(ntf.Likes);
			}
			if (!string.IsNullOrEmpty(ntf.FriendshipPointsReceived) && !base.HasReceivedFriendShipPoints(ntf.FriendshipPointsReceived))
			{
				this.m_friendDS.AddFriendshipPointsReceivedUser(ntf.FriendshipPointsReceived);
			}
		}

		// Token: 0x06006F9F RID: 28575 RVA: 0x001F38C4 File Offset: 0x001F1AC4
		public List<BattleHero> GetBusinessCardHeroes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetBusinessCardHeroes_hotfix != null)
			{
				return (List<BattleHero>)this.m_GetBusinessCardHeroes_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<BattleHero> list = new List<BattleHero>();
			if (this.m_friendDS.BusinessCardSetInfo != null)
			{
				List<BusinessCardHeroSet> heroes = this.m_friendDS.BusinessCardSetInfo.Heroes;
				foreach (BusinessCardHeroSet businessCardHeroSet in heroes)
				{
					Hero hero = this.m_hero.FindHero(businessCardHeroSet.HeroId);
					BattleHero battleHero = BattleHero.HeroToBattleHero(hero);
					foreach (ulong num in hero.EquipmentIds)
					{
						if (num != 0UL)
						{
							EquipmentBagItem equipmentBagItem = this.m_bag.FindBagItemByInstanceId(num) as EquipmentBagItem;
							battleHero.Equipments.Add(equipmentBagItem.ToBattleHeroEquipment());
						}
					}
					list.Add(battleHero);
				}
			}
			return list;
		}

		// Token: 0x06006FA0 RID: 28576 RVA: 0x001F3A20 File Offset: 0x001F1C20
		public BusinessCardInfoSet GetBusinessCardInfoSet()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetBusinessCardInfoSet_hotfix != null)
			{
				return (BusinessCardInfoSet)this.m_GetBusinessCardInfoSet_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_friendDS.BusinessCardSetInfo;
		}

		// Token: 0x06006FA1 RID: 28577 RVA: 0x001F3A98 File Offset: 0x001F1C98
		public int GetSendFriendShipPointsCount()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSendFriendShipPointsCount_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetSendFriendShipPointsCount_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_friendDS.FriendshipPointsSent.Count;
		}

		// Token: 0x06006FA2 RID: 28578 RVA: 0x001F3B14 File Offset: 0x001F1D14
		public int GetClaimedFriendShipPointsCount()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetClaimedFriendShipPointsCount_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetClaimedFriendShipPointsCount_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_friendDS.FriendshipPointsClaimedToday;
		}

		// Token: 0x06006FA3 RID: 28579 RVA: 0x001F3B8C File Offset: 0x001F1D8C
		public int ReceivedFriendShipPointsCount()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ReceivedFriendShipPointsCount_hotfix != null)
			{
				return Convert.ToInt32(this.m_ReceivedFriendShipPointsCount_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_friendDS.FriendshipPointsReceived.Count;
		}

		// Token: 0x17001BBD RID: 7101
		// (get) Token: 0x06006FA4 RID: 28580 RVA: 0x001F3C08 File Offset: 0x001F1E08
		// (set) Token: 0x06006FA5 RID: 28581 RVA: 0x001F3C7C File Offset: 0x001F1E7C
		public List<UserSummary> Friends
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Friends_hotfix != null)
				{
					return (List<UserSummary>)this.m_get_Friends_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Friends>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_FriendsList`1_hotfix != null)
				{
					this.m_set_FriendsList`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Friends>k__BackingField = value;
			}
		}

		// Token: 0x17001BBE RID: 7102
		// (get) Token: 0x06006FA6 RID: 28582 RVA: 0x001F3CF4 File Offset: 0x001F1EF4
		// (set) Token: 0x06006FA7 RID: 28583 RVA: 0x001F3D68 File Offset: 0x001F1F68
		public List<UserSummary> Blacklist
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Blacklist_hotfix != null)
				{
					return (List<UserSummary>)this.m_get_Blacklist_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Blacklist>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_BlacklistList`1_hotfix != null)
				{
					this.m_set_BlacklistList`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Blacklist>k__BackingField = value;
			}
		}

		// Token: 0x17001BBF RID: 7103
		// (get) Token: 0x06006FA8 RID: 28584 RVA: 0x001F3DE0 File Offset: 0x001F1FE0
		// (set) Token: 0x06006FA9 RID: 28585 RVA: 0x001F3E54 File Offset: 0x001F2054
		public List<UserSummary> Invite
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Invite_hotfix != null)
				{
					return (List<UserSummary>)this.m_get_Invite_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Invite>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_InviteList`1_hotfix != null)
				{
					this.m_set_InviteList`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Invite>k__BackingField = value;
			}
		}

		// Token: 0x17001BC0 RID: 7104
		// (get) Token: 0x06006FAA RID: 28586 RVA: 0x001F3ECC File Offset: 0x001F20CC
		// (set) Token: 0x06006FAB RID: 28587 RVA: 0x001F3F40 File Offset: 0x001F2140
		public List<UserSummary> Invited
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Invited_hotfix != null)
				{
					return (List<UserSummary>)this.m_get_Invited_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Invited>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_InvitedList`1_hotfix != null)
				{
					this.m_set_InvitedList`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Invited>k__BackingField = value;
			}
		}

		// Token: 0x17001BC1 RID: 7105
		// (get) Token: 0x06006FAC RID: 28588 RVA: 0x001F3FB8 File Offset: 0x001F21B8
		// (set) Token: 0x06006FAD RID: 28589 RVA: 0x001F402C File Offset: 0x001F222C
		public List<UserSummary> GuildPlayers
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_GuildPlayers_hotfix != null)
				{
					return (List<UserSummary>)this.m_get_GuildPlayers_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<GuildPlayers>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_GuildPlayersList`1_hotfix != null)
				{
					this.m_set_GuildPlayersList`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<GuildPlayers>k__BackingField = value;
			}
		}

		// Token: 0x17001BC2 RID: 7106
		// (get) Token: 0x06006FAE RID: 28590 RVA: 0x001F40A4 File Offset: 0x001F22A4
		// (set) Token: 0x06006FAF RID: 28591 RVA: 0x001F4118 File Offset: 0x001F2318
		public List<UserSummary> RecentContactsChat
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_RecentContactsChat_hotfix != null)
				{
					return (List<UserSummary>)this.m_get_RecentContactsChat_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<RecentContactsChat>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_RecentContactsChatList`1_hotfix != null)
				{
					this.m_set_RecentContactsChatList`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<RecentContactsChat>k__BackingField = value;
			}
		}

		// Token: 0x17001BC3 RID: 7107
		// (get) Token: 0x06006FB0 RID: 28592 RVA: 0x001F4190 File Offset: 0x001F2390
		// (set) Token: 0x06006FB1 RID: 28593 RVA: 0x001F4204 File Offset: 0x001F2404
		public List<UserSummary> RecentContactsTeamBattle
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_RecentContactsTeamBattle_hotfix != null)
				{
					return (List<UserSummary>)this.m_get_RecentContactsTeamBattle_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<RecentContactsTeamBattle>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_RecentContactsTeamBattleList`1_hotfix != null)
				{
					this.m_set_RecentContactsTeamBattleList`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<RecentContactsTeamBattle>k__BackingField = value;
			}
		}

		// Token: 0x17001BC4 RID: 7108
		// (get) Token: 0x06006FB2 RID: 28594 RVA: 0x001F427C File Offset: 0x001F247C
		// (set) Token: 0x06006FB3 RID: 28595 RVA: 0x001F42F0 File Offset: 0x001F24F0
		public List<PVPInviteInfo> PVPInviteInfos
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_PVPInviteInfos_hotfix != null)
				{
					return (List<PVPInviteInfo>)this.m_get_PVPInviteInfos_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<PVPInviteInfos>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_PVPInviteInfosList`1_hotfix != null)
				{
					this.m_set_PVPInviteInfosList`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<PVPInviteInfos>k__BackingField = value;
			}
		}

		// Token: 0x17001BC5 RID: 7109
		// (get) Token: 0x06006FB4 RID: 28596 RVA: 0x001F4368 File Offset: 0x001F2568
		// (set) Token: 0x06006FB5 RID: 28597 RVA: 0x001F4388 File Offset: 0x001F2588
		[DoNotToLua]
		public new FriendComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new FriendComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06006FB6 RID: 28598 RVA: 0x001F4394 File Offset: 0x001F2594
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x06006FB7 RID: 28599 RVA: 0x001F439C File Offset: 0x001F259C
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x06006FB8 RID: 28600 RVA: 0x001F43A4 File Offset: 0x001F25A4
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x06006FB9 RID: 28601 RVA: 0x001F43AC File Offset: 0x001F25AC
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x06006FBA RID: 28602 RVA: 0x001F43B4 File Offset: 0x001F25B4
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x06006FBB RID: 28603 RVA: 0x001F43C0 File Offset: 0x001F25C0
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x06006FBC RID: 28604 RVA: 0x001F43C8 File Offset: 0x001F25C8
		private void __callBase_Ban(DateTime banTime)
		{
			base.Ban(banTime);
		}

		// Token: 0x06006FBD RID: 28605 RVA: 0x001F43D4 File Offset: 0x001F25D4
		private bool __callBase_IsBanned(DateTime currentTime)
		{
			return base.IsBanned(currentTime);
		}

		// Token: 0x06006FBE RID: 28606 RVA: 0x001F43E0 File Offset: 0x001F25E0
		private void __callBase_SetBusinessCardInfo(BusinessCardInfoSet setInfo)
		{
			base.SetBusinessCardInfo(setInfo);
		}

		// Token: 0x06006FBF RID: 28607 RVA: 0x001F43EC File Offset: 0x001F25EC
		private void __callBase_SetLikes(int likes)
		{
			base.SetLikes(likes);
		}

		// Token: 0x06006FC0 RID: 28608 RVA: 0x001F43F8 File Offset: 0x001F25F8
		private int __callBase_CanSendLikes(string targetUserId)
		{
			return base.CanSendLikes(targetUserId);
		}

		// Token: 0x06006FC1 RID: 28609 RVA: 0x001F4404 File Offset: 0x001F2604
		private void __callBase_AddLikedUser(string userId)
		{
			base.AddLikedUser(userId);
		}

		// Token: 0x06006FC2 RID: 28610 RVA: 0x001F4410 File Offset: 0x001F2610
		private int __callBase_SendFriendshipPointsCheck(string targetUserId)
		{
			return base.SendFriendshipPointsCheck(targetUserId);
		}

		// Token: 0x06006FC3 RID: 28611 RVA: 0x001F441C File Offset: 0x001F261C
		private List<string> __callBase_FilterInvalidSendFriendPointsTargets(List<string> targetUserIds)
		{
			return base.FilterInvalidSendFriendPointsTargets(targetUserIds);
		}

		// Token: 0x06006FC4 RID: 28612 RVA: 0x001F4428 File Offset: 0x001F2628
		private int __callBase_SendFriendshipPoints(string targetUserId)
		{
			return base.SendFriendshipPoints(targetUserId);
		}

		// Token: 0x06006FC5 RID: 28613 RVA: 0x001F4434 File Offset: 0x001F2634
		private int __callBase_ReceiveFriendshipPointsFromFriend(string targetUserId)
		{
			return base.ReceiveFriendshipPointsFromFriend(targetUserId);
		}

		// Token: 0x06006FC6 RID: 28614 RVA: 0x001F4440 File Offset: 0x001F2640
		private int __callBase_ClaimFriendshipPointsFromFriendCheck(string targetUserId)
		{
			return base.ClaimFriendshipPointsFromFriendCheck(targetUserId);
		}

		// Token: 0x06006FC7 RID: 28615 RVA: 0x001F444C File Offset: 0x001F264C
		private int __callBase_ClaimFriendshipPointsFromFriend(string targetUserId)
		{
			return base.ClaimFriendshipPointsFromFriend(targetUserId);
		}

		// Token: 0x06006FC8 RID: 28616 RVA: 0x001F4458 File Offset: 0x001F2658
		private void __callBase_ClaimFriendShipPoints(int point)
		{
			base.ClaimFriendShipPoints(point);
		}

		// Token: 0x06006FC9 RID: 28617 RVA: 0x001F4464 File Offset: 0x001F2664
		private int __callBase_GetFriendshipPointsFromFightWithFriendsToday()
		{
			return base.GetFriendshipPointsFromFightWithFriendsToday();
		}

		// Token: 0x06006FCA RID: 28618 RVA: 0x001F446C File Offset: 0x001F266C
		private int __callBase_AddFriendshipPointsFromFightWithFriendsToday(int pointsToAdd)
		{
			return base.AddFriendshipPointsFromFightWithFriendsToday(pointsToAdd);
		}

		// Token: 0x06006FCB RID: 28619 RVA: 0x001F4478 File Offset: 0x001F2678
		private int __callBase_CanUpdateBusinessCardDesc(string desc)
		{
			return base.CanUpdateBusinessCardDesc(desc);
		}

		// Token: 0x06006FCC RID: 28620 RVA: 0x001F4484 File Offset: 0x001F2684
		private int __callBase_CanUpdateBusinessCardHeroSets(List<BusinessCardHeroSet> heroSets)
		{
			return base.CanUpdateBusinessCardHeroSets(heroSets);
		}

		// Token: 0x06006FCD RID: 28621 RVA: 0x001F4490 File Offset: 0x001F2690
		private bool __callBase_HasSentFriendShipPoints(string userId)
		{
			return base.HasSentFriendShipPoints(userId);
		}

		// Token: 0x06006FCE RID: 28622 RVA: 0x001F449C File Offset: 0x001F269C
		private bool __callBase_HasReceivedFriendShipPoints(string userId)
		{
			return base.HasReceivedFriendShipPoints(userId);
		}

		// Token: 0x06006FCF RID: 28623 RVA: 0x001F44A8 File Offset: 0x001F26A8
		private void __callBase_SetBusinessCardDesc(string desc)
		{
			base.SetBusinessCardDesc(desc);
		}

		// Token: 0x06006FD0 RID: 28624 RVA: 0x001F44B4 File Offset: 0x001F26B4
		private void __callBase_SetBusinessCardHeroSet(List<BusinessCardHeroSet> heroSets)
		{
			base.SetBusinessCardHeroSet(heroSets);
		}

		// Token: 0x06006FD1 RID: 28625 RVA: 0x001F44C0 File Offset: 0x001F26C0
		private void __callBase_SetRandomHeroAction(bool actionRandom)
		{
			base.SetRandomHeroAction(actionRandom);
		}

		// Token: 0x06006FD2 RID: 28626 RVA: 0x001F44CC File Offset: 0x001F26CC
		private void __callBase_RemoveFriendshipPointsReceivedUser(string UserId)
		{
			base.RemoveFriendshipPointsReceivedUser(UserId);
		}

		// Token: 0x06006FD3 RID: 28627 RVA: 0x001F44D8 File Offset: 0x001F26D8
		private List<string> __callBase_GetFriendshipPointsReceivedUsers()
		{
			return base.GetFriendshipPointsReceivedUsers();
		}

		// Token: 0x06006FD4 RID: 28628 RVA: 0x001F44E0 File Offset: 0x001F26E0
		private void __callBase_OnInviteFriendSuccess()
		{
			base.OnInviteFriendSuccess();
		}

		// Token: 0x06006FD5 RID: 28629 RVA: 0x001F44E8 File Offset: 0x001F26E8
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_PostInit_hotfix = (luaObj.RawGet("PostInit") as LuaFunction);
					this.m_DeInit_hotfix = (luaObj.RawGet("DeInit") as LuaFunction);
					this.m_GetDSVersion_hotfix = (luaObj.RawGet("GetDSVersion") as LuaFunction);
					this.m_DeserializeDSFriendNtf_hotfix = (luaObj.RawGet("Deserialize") as LuaFunction);
					this.m_LoadFromPBDataDSFriendNtf_hotfix = (luaObj.RawGet("LoadFromPBData") as LuaFunction);
					this.m_DeserializeFriendInfoUpdateNtf_hotfix = (luaObj.RawGet("Deserialize") as LuaFunction);
					this.m_GetBusinessCardHeroes_hotfix = (luaObj.RawGet("GetBusinessCardHeroes") as LuaFunction);
					this.m_GetBusinessCardInfoSet_hotfix = (luaObj.RawGet("GetBusinessCardInfoSet") as LuaFunction);
					this.m_GetSendFriendShipPointsCount_hotfix = (luaObj.RawGet("GetSendFriendShipPointsCount") as LuaFunction);
					this.m_GetClaimedFriendShipPointsCount_hotfix = (luaObj.RawGet("GetClaimedFriendShipPointsCount") as LuaFunction);
					this.m_ReceivedFriendShipPointsCount_hotfix = (luaObj.RawGet("ReceivedFriendShipPointsCount") as LuaFunction);
					this.m_get_Friends_hotfix = (luaObj.RawGet("get_Friends") as LuaFunction);
					this.m_set_FriendsList`1_hotfix = (luaObj.RawGet("set_Friends") as LuaFunction);
					this.m_get_Blacklist_hotfix = (luaObj.RawGet("get_Blacklist") as LuaFunction);
					this.m_set_BlacklistList`1_hotfix = (luaObj.RawGet("set_Blacklist") as LuaFunction);
					this.m_get_Invite_hotfix = (luaObj.RawGet("get_Invite") as LuaFunction);
					this.m_set_InviteList`1_hotfix = (luaObj.RawGet("set_Invite") as LuaFunction);
					this.m_get_Invited_hotfix = (luaObj.RawGet("get_Invited") as LuaFunction);
					this.m_set_InvitedList`1_hotfix = (luaObj.RawGet("set_Invited") as LuaFunction);
					this.m_get_GuildPlayers_hotfix = (luaObj.RawGet("get_GuildPlayers") as LuaFunction);
					this.m_set_GuildPlayersList`1_hotfix = (luaObj.RawGet("set_GuildPlayers") as LuaFunction);
					this.m_get_RecentContactsChat_hotfix = (luaObj.RawGet("get_RecentContactsChat") as LuaFunction);
					this.m_set_RecentContactsChatList`1_hotfix = (luaObj.RawGet("set_RecentContactsChat") as LuaFunction);
					this.m_get_RecentContactsTeamBattle_hotfix = (luaObj.RawGet("get_RecentContactsTeamBattle") as LuaFunction);
					this.m_set_RecentContactsTeamBattleList`1_hotfix = (luaObj.RawGet("set_RecentContactsTeamBattle") as LuaFunction);
					this.m_get_PVPInviteInfos_hotfix = (luaObj.RawGet("get_PVPInviteInfos") as LuaFunction);
					this.m_set_PVPInviteInfosList`1_hotfix = (luaObj.RawGet("set_PVPInviteInfos") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06006FD6 RID: 28630 RVA: 0x001F4870 File Offset: 0x001F2A70
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400549C RID: 21660
		[DoNotToLua]
		private FriendComponent.LuaExportHelper luaExportHelper;

		// Token: 0x0400549D RID: 21661
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400549E RID: 21662
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400549F RID: 21663
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040054A0 RID: 21664
		private LuaFunction m_Init_hotfix;

		// Token: 0x040054A1 RID: 21665
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x040054A2 RID: 21666
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x040054A3 RID: 21667
		private LuaFunction m_GetDSVersion_hotfix;

		// Token: 0x040054A4 RID: 21668
		private LuaFunction m_DeserializeDSFriendNtf_hotfix;

		// Token: 0x040054A5 RID: 21669
		private LuaFunction m_LoadFromPBDataDSFriendNtf_hotfix;

		// Token: 0x040054A6 RID: 21670
		private LuaFunction m_DeserializeFriendInfoUpdateNtf_hotfix;

		// Token: 0x040054A7 RID: 21671
		private LuaFunction m_GetBusinessCardHeroes_hotfix;

		// Token: 0x040054A8 RID: 21672
		private LuaFunction m_GetBusinessCardInfoSet_hotfix;

		// Token: 0x040054A9 RID: 21673
		private LuaFunction m_GetSendFriendShipPointsCount_hotfix;

		// Token: 0x040054AA RID: 21674
		private LuaFunction m_GetClaimedFriendShipPointsCount_hotfix;

		// Token: 0x040054AB RID: 21675
		private LuaFunction m_ReceivedFriendShipPointsCount_hotfix;

		// Token: 0x040054AC RID: 21676
		private LuaFunction m_get_Friends_hotfix;

		// Token: 0x040054AD RID: 21677
		private LuaFunction m_set_FriendsList;

		// Token: 0x040054AE RID: 21678
		private LuaFunction m_get_Blacklist_hotfix;

		// Token: 0x040054AF RID: 21679
		private LuaFunction m_set_BlacklistList;

		// Token: 0x040054B0 RID: 21680
		private LuaFunction m_get_Invite_hotfix;

		// Token: 0x040054B1 RID: 21681
		private LuaFunction m_set_InviteList;

		// Token: 0x040054B2 RID: 21682
		private LuaFunction m_get_Invited_hotfix;

		// Token: 0x040054B3 RID: 21683
		private LuaFunction m_set_InvitedList;

		// Token: 0x040054B4 RID: 21684
		private LuaFunction m_get_GuildPlayers_hotfix;

		// Token: 0x040054B5 RID: 21685
		private LuaFunction m_set_GuildPlayersList;

		// Token: 0x040054B6 RID: 21686
		private LuaFunction m_get_RecentContactsChat_hotfix;

		// Token: 0x040054B7 RID: 21687
		private LuaFunction m_set_RecentContactsChatList;

		// Token: 0x040054B8 RID: 21688
		private LuaFunction m_get_RecentContactsTeamBattle_hotfix;

		// Token: 0x040054B9 RID: 21689
		private LuaFunction m_set_RecentContactsTeamBattleList;

		// Token: 0x040054BA RID: 21690
		private LuaFunction m_get_PVPInviteInfos_hotfix;

		// Token: 0x040054BB RID: 21691
		private LuaFunction m_set_PVPInviteInfosList;

		// Token: 0x020008AE RID: 2222
		public new class LuaExportHelper
		{
			// Token: 0x06006FD7 RID: 28631 RVA: 0x001F48D8 File Offset: 0x001F2AD8
			public LuaExportHelper(FriendComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06006FD8 RID: 28632 RVA: 0x001F48E8 File Offset: 0x001F2AE8
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x06006FD9 RID: 28633 RVA: 0x001F48F8 File Offset: 0x001F2AF8
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x06006FDA RID: 28634 RVA: 0x001F4908 File Offset: 0x001F2B08
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x06006FDB RID: 28635 RVA: 0x001F4918 File Offset: 0x001F2B18
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x06006FDC RID: 28636 RVA: 0x001F4928 File Offset: 0x001F2B28
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x06006FDD RID: 28637 RVA: 0x001F4938 File Offset: 0x001F2B38
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x06006FDE RID: 28638 RVA: 0x001F4948 File Offset: 0x001F2B48
			public void __callBase_Ban(DateTime banTime)
			{
				this.m_owner.__callBase_Ban(banTime);
			}

			// Token: 0x06006FDF RID: 28639 RVA: 0x001F4958 File Offset: 0x001F2B58
			public bool __callBase_IsBanned(DateTime currentTime)
			{
				return this.m_owner.__callBase_IsBanned(currentTime);
			}

			// Token: 0x06006FE0 RID: 28640 RVA: 0x001F4968 File Offset: 0x001F2B68
			public void __callBase_SetBusinessCardInfo(BusinessCardInfoSet setInfo)
			{
				this.m_owner.__callBase_SetBusinessCardInfo(setInfo);
			}

			// Token: 0x06006FE1 RID: 28641 RVA: 0x001F4978 File Offset: 0x001F2B78
			public void __callBase_SetLikes(int likes)
			{
				this.m_owner.__callBase_SetLikes(likes);
			}

			// Token: 0x06006FE2 RID: 28642 RVA: 0x001F4988 File Offset: 0x001F2B88
			public int __callBase_CanSendLikes(string targetUserId)
			{
				return this.m_owner.__callBase_CanSendLikes(targetUserId);
			}

			// Token: 0x06006FE3 RID: 28643 RVA: 0x001F4998 File Offset: 0x001F2B98
			public void __callBase_AddLikedUser(string userId)
			{
				this.m_owner.__callBase_AddLikedUser(userId);
			}

			// Token: 0x06006FE4 RID: 28644 RVA: 0x001F49A8 File Offset: 0x001F2BA8
			public int __callBase_SendFriendshipPointsCheck(string targetUserId)
			{
				return this.m_owner.__callBase_SendFriendshipPointsCheck(targetUserId);
			}

			// Token: 0x06006FE5 RID: 28645 RVA: 0x001F49B8 File Offset: 0x001F2BB8
			public List<string> __callBase_FilterInvalidSendFriendPointsTargets(List<string> targetUserIds)
			{
				return this.m_owner.__callBase_FilterInvalidSendFriendPointsTargets(targetUserIds);
			}

			// Token: 0x06006FE6 RID: 28646 RVA: 0x001F49C8 File Offset: 0x001F2BC8
			public int __callBase_SendFriendshipPoints(string targetUserId)
			{
				return this.m_owner.__callBase_SendFriendshipPoints(targetUserId);
			}

			// Token: 0x06006FE7 RID: 28647 RVA: 0x001F49D8 File Offset: 0x001F2BD8
			public int __callBase_ReceiveFriendshipPointsFromFriend(string targetUserId)
			{
				return this.m_owner.__callBase_ReceiveFriendshipPointsFromFriend(targetUserId);
			}

			// Token: 0x06006FE8 RID: 28648 RVA: 0x001F49E8 File Offset: 0x001F2BE8
			public int __callBase_ClaimFriendshipPointsFromFriendCheck(string targetUserId)
			{
				return this.m_owner.__callBase_ClaimFriendshipPointsFromFriendCheck(targetUserId);
			}

			// Token: 0x06006FE9 RID: 28649 RVA: 0x001F49F8 File Offset: 0x001F2BF8
			public int __callBase_ClaimFriendshipPointsFromFriend(string targetUserId)
			{
				return this.m_owner.__callBase_ClaimFriendshipPointsFromFriend(targetUserId);
			}

			// Token: 0x06006FEA RID: 28650 RVA: 0x001F4A08 File Offset: 0x001F2C08
			public void __callBase_ClaimFriendShipPoints(int point)
			{
				this.m_owner.__callBase_ClaimFriendShipPoints(point);
			}

			// Token: 0x06006FEB RID: 28651 RVA: 0x001F4A18 File Offset: 0x001F2C18
			public int __callBase_GetFriendshipPointsFromFightWithFriendsToday()
			{
				return this.m_owner.__callBase_GetFriendshipPointsFromFightWithFriendsToday();
			}

			// Token: 0x06006FEC RID: 28652 RVA: 0x001F4A28 File Offset: 0x001F2C28
			public int __callBase_AddFriendshipPointsFromFightWithFriendsToday(int pointsToAdd)
			{
				return this.m_owner.__callBase_AddFriendshipPointsFromFightWithFriendsToday(pointsToAdd);
			}

			// Token: 0x06006FED RID: 28653 RVA: 0x001F4A38 File Offset: 0x001F2C38
			public int __callBase_CanUpdateBusinessCardDesc(string desc)
			{
				return this.m_owner.__callBase_CanUpdateBusinessCardDesc(desc);
			}

			// Token: 0x06006FEE RID: 28654 RVA: 0x001F4A48 File Offset: 0x001F2C48
			public int __callBase_CanUpdateBusinessCardHeroSets(List<BusinessCardHeroSet> heroSets)
			{
				return this.m_owner.__callBase_CanUpdateBusinessCardHeroSets(heroSets);
			}

			// Token: 0x06006FEF RID: 28655 RVA: 0x001F4A58 File Offset: 0x001F2C58
			public bool __callBase_HasSentFriendShipPoints(string userId)
			{
				return this.m_owner.__callBase_HasSentFriendShipPoints(userId);
			}

			// Token: 0x06006FF0 RID: 28656 RVA: 0x001F4A68 File Offset: 0x001F2C68
			public bool __callBase_HasReceivedFriendShipPoints(string userId)
			{
				return this.m_owner.__callBase_HasReceivedFriendShipPoints(userId);
			}

			// Token: 0x06006FF1 RID: 28657 RVA: 0x001F4A78 File Offset: 0x001F2C78
			public void __callBase_SetBusinessCardDesc(string desc)
			{
				this.m_owner.__callBase_SetBusinessCardDesc(desc);
			}

			// Token: 0x06006FF2 RID: 28658 RVA: 0x001F4A88 File Offset: 0x001F2C88
			public void __callBase_SetBusinessCardHeroSet(List<BusinessCardHeroSet> heroSets)
			{
				this.m_owner.__callBase_SetBusinessCardHeroSet(heroSets);
			}

			// Token: 0x06006FF3 RID: 28659 RVA: 0x001F4A98 File Offset: 0x001F2C98
			public void __callBase_SetRandomHeroAction(bool actionRandom)
			{
				this.m_owner.__callBase_SetRandomHeroAction(actionRandom);
			}

			// Token: 0x06006FF4 RID: 28660 RVA: 0x001F4AA8 File Offset: 0x001F2CA8
			public void __callBase_RemoveFriendshipPointsReceivedUser(string UserId)
			{
				this.m_owner.__callBase_RemoveFriendshipPointsReceivedUser(UserId);
			}

			// Token: 0x06006FF5 RID: 28661 RVA: 0x001F4AB8 File Offset: 0x001F2CB8
			public List<string> __callBase_GetFriendshipPointsReceivedUsers()
			{
				return this.m_owner.__callBase_GetFriendshipPointsReceivedUsers();
			}

			// Token: 0x06006FF6 RID: 28662 RVA: 0x001F4AC8 File Offset: 0x001F2CC8
			public void __callBase_OnInviteFriendSuccess()
			{
				this.m_owner.__callBase_OnInviteFriendSuccess();
			}

			// Token: 0x06006FF7 RID: 28663 RVA: 0x001F4AD8 File Offset: 0x001F2CD8
			public void LoadFromPBData(DSFriendNtf pbFriendInfo)
			{
				this.m_owner.LoadFromPBData(pbFriendInfo);
			}

			// Token: 0x040054BC RID: 21692
			private FriendComponent m_owner;
		}
	}
}
