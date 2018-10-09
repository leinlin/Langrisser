using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000457 RID: 1111
	[HotFix]
	public class FriendComponentCommon : IComponentBase
	{
		// Token: 0x06004080 RID: 16512 RVA: 0x0012CBCC File Offset: 0x0012ADCC
		public FriendComponentCommon()
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

		// Token: 0x06004081 RID: 16513 RVA: 0x0012CC40 File Offset: 0x0012AE40
		public string GetName()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetName_hotfix != null)
			{
				return (string)this.m_GetName_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return "Friend";
		}

		// Token: 0x06004082 RID: 16514 RVA: 0x0012CCB4 File Offset: 0x0012AEB4
		public virtual void Init()
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
		}

		// Token: 0x06004083 RID: 16515 RVA: 0x0012CD14 File Offset: 0x0012AF14
		public virtual void PostInit()
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
			this.m_basicInfo = (this.Owner.GetOwnerComponent("PlayerBasicInfo") as PlayerBasicInfoComponentCommon);
			this.m_hero = (this.Owner.GetOwnerComponent("Hero") as HeroComponentCommon);
			this.m_bag = (this.Owner.GetOwnerComponent("Bag") as BagComponentCommon);
			this.m_basicInfo.PlayerActionFlushEvent += this.OnFlushFriend;
		}

		// Token: 0x06004084 RID: 16516 RVA: 0x0012CDDC File Offset: 0x0012AFDC
		public virtual void DeInit()
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
		}

		// Token: 0x06004085 RID: 16517 RVA: 0x0012CE3C File Offset: 0x0012B03C
		public virtual void Tick(uint deltaMillisecond)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickUInt32_hotfix != null)
			{
				this.m_TickUInt32_hotfix.call(new object[]
				{
					this,
					deltaMillisecond
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06004086 RID: 16518 RVA: 0x0012CEAC File Offset: 0x0012B0AC
		public virtual bool Serialize<T>(T dest)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SerializeT_hotfix != null)
			{
				return Convert.ToBoolean(this.m_SerializeT_hotfix.call(new object[]
				{
					this,
					dest
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return false;
		}

		// Token: 0x06004087 RID: 16519 RVA: 0x0012CF2C File Offset: 0x0012B12C
		public virtual void DeSerialize<T>(T source)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeT_hotfix != null)
			{
				this.m_DeSerializeT_hotfix.call(new object[]
				{
					this,
					source
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06004088 RID: 16520 RVA: 0x0012CF9C File Offset: 0x0012B19C
		public virtual void PostDeSerialize()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostDeSerialize_hotfix != null)
			{
				this.m_PostDeSerialize_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x1700112B RID: 4395
		// (get) Token: 0x06004089 RID: 16521 RVA: 0x0012CFFC File Offset: 0x0012B1FC
		// (set) Token: 0x0600408A RID: 16522 RVA: 0x0012D070 File Offset: 0x0012B270
		public IComponentOwner Owner
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Owner_hotfix != null)
				{
					return (IComponentOwner)this.m_get_Owner_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Owner>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_OwnerIComponentOwner_hotfix != null)
				{
					this.m_set_OwnerIComponentOwner_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Owner>k__BackingField = value;
			}
		}

		// Token: 0x0600408B RID: 16523 RVA: 0x0012D0E8 File Offset: 0x0012B2E8
		private void OnFlushFriend()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFlushFriend_hotfix != null)
			{
				this.m_OnFlushFriend_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_friendDS.OnFlushOfTime();
		}

		// Token: 0x0600408C RID: 16524 RVA: 0x0012D154 File Offset: 0x0012B354
		public virtual void Ban(DateTime banTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BanDateTime_hotfix != null)
			{
				this.m_BanDateTime_hotfix.call(new object[]
				{
					this,
					banTime
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_friendDS.Ban(banTime);
		}

		// Token: 0x0600408D RID: 16525 RVA: 0x0012D1D0 File Offset: 0x0012B3D0
		public bool IsBanned(DateTime currentTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsBannedDateTime_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsBannedDateTime_hotfix.call(new object[]
				{
					this,
					currentTime
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_friendDS.IsBanned(currentTime);
		}

		// Token: 0x0600408E RID: 16526 RVA: 0x0012D258 File Offset: 0x0012B458
		public void SetBusinessCardInfo(BusinessCardInfoSet setInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBusinessCardInfoBusinessCardInfoSet_hotfix != null)
			{
				this.m_SetBusinessCardInfoBusinessCardInfoSet_hotfix.call(new object[]
				{
					this,
					setInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_friendDS.SetBusinessCardInfo(setInfo);
		}

		// Token: 0x0600408F RID: 16527 RVA: 0x0012D2D4 File Offset: 0x0012B4D4
		public void SetLikes(int likes)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLikesInt32_hotfix != null)
			{
				this.m_SetLikesInt32_hotfix.call(new object[]
				{
					this,
					likes
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_friendDS.SetLikes(likes);
		}

		// Token: 0x06004090 RID: 16528 RVA: 0x0012D350 File Offset: 0x0012B550
		public int CanSendLikes(string targetUserId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanSendLikesString_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanSendLikesString_hotfix.call(new object[]
				{
					this,
					targetUserId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsMySelf(targetUserId))
			{
				return -4009;
			}
			if (this.HasSendLikesToday(targetUserId))
			{
				return -4010;
			}
			return 0;
		}

		// Token: 0x06004091 RID: 16529 RVA: 0x0012D3F4 File Offset: 0x0012B5F4
		public void AddLikedUser(string userId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddLikedUserString_hotfix != null)
			{
				this.m_AddLikedUserString_hotfix.call(new object[]
				{
					this,
					userId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_friendDS.AddLikedUser(userId);
		}

		// Token: 0x06004092 RID: 16530 RVA: 0x0012D470 File Offset: 0x0012B670
		public int SendFriendshipPointsCheck(string targetUserId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SendFriendshipPointsCheckString_hotfix != null)
			{
				return Convert.ToInt32(this.m_SendFriendshipPointsCheckString_hotfix.call(new object[]
				{
					this,
					targetUserId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.HasSentFriendShipPoints(targetUserId))
			{
				return -4023;
			}
			if (this.m_friendDS.FriendshipPointsSent.Count >= this.m_configDataLoader.ConfigableConstId_SendFriendShipPointsMaxTimes)
			{
				return -4025;
			}
			return 0;
		}

		// Token: 0x06004093 RID: 16531 RVA: 0x0012D528 File Offset: 0x0012B728
		public List<string> FilterInvalidSendFriendPointsTargets(List<string> targetUserIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FilterInvalidSendFriendPointsTargetsList`1_hotfix != null)
			{
				return (List<string>)this.m_FilterInvalidSendFriendPointsTargetsList`1_hotfix.call(new object[]
				{
					this,
					targetUserIds
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<string> list = new List<string>();
			int num = this.m_friendDS.FriendshipPointsSent.Count;
			foreach (string text in targetUserIds)
			{
				if (num >= this.m_configDataLoader.ConfigableConstId_SendFriendShipPointsMaxTimes)
				{
					break;
				}
				if (this.SendFriendshipPointsCheck(text) == 0)
				{
					list.Add(text);
					num++;
				}
			}
			return list;
		}

		// Token: 0x06004094 RID: 16532 RVA: 0x0012D630 File Offset: 0x0012B830
		public virtual int SendFriendshipPoints(string targetUserId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SendFriendshipPointsString_hotfix != null)
			{
				return Convert.ToInt32(this.m_SendFriendshipPointsString_hotfix.call(new object[]
				{
					this,
					targetUserId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.SendFriendshipPointsCheck(targetUserId);
			if (num != 0)
			{
				return num;
			}
			this.m_friendDS.AddFriendshipPointsSentUser(targetUserId);
			return 0;
		}

		// Token: 0x06004095 RID: 16533 RVA: 0x0012D6CC File Offset: 0x0012B8CC
		public virtual int ReceiveFriendshipPointsFromFriend(string targetUserId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ReceiveFriendshipPointsFromFriendString_hotfix != null)
			{
				return Convert.ToInt32(this.m_ReceiveFriendshipPointsFromFriendString_hotfix.call(new object[]
				{
					this,
					targetUserId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_friendDS.AddFriendshipPointsReceivedUser(targetUserId);
			return 0;
		}

		// Token: 0x06004096 RID: 16534 RVA: 0x0012D758 File Offset: 0x0012B958
		public int ClaimFriendshipPointsFromFriendCheck(string targetUserId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClaimFriendshipPointsFromFriendCheckString_hotfix != null)
			{
				return Convert.ToInt32(this.m_ClaimFriendshipPointsFromFriendCheckString_hotfix.call(new object[]
				{
					this,
					targetUserId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_friendDS.FriendshipPointsClaimedToday > this.m_configDataLoader.ConfigableConstId_ReceiveFriendShipPointsMaxTimes)
			{
				return -4026;
			}
			return 0;
		}

		// Token: 0x06004097 RID: 16535 RVA: 0x0012D7F8 File Offset: 0x0012B9F8
		public virtual int ClaimFriendshipPointsFromFriend(string targetUserId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClaimFriendshipPointsFromFriendString_hotfix != null)
			{
				return Convert.ToInt32(this.m_ClaimFriendshipPointsFromFriendString_hotfix.call(new object[]
				{
					this,
					targetUserId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_friendDS.FriendshipPointsClaimedToday >= this.m_configDataLoader.ConfigableConstId_ReceiveFriendShipPointsMaxTimes)
			{
				return -4026;
			}
			if (this.m_friendDS.RemoveFriendshipPointsReceivedUser(targetUserId))
			{
				int configableConstId_SendFriendShipPointsEverytime = this.m_configDataLoader.ConfigableConstId_SendFriendShipPointsEverytime;
				this.ClaimFriendShipPoints(configableConstId_SendFriendShipPointsEverytime);
				return 0;
			}
			return -4027;
		}

		// Token: 0x06004098 RID: 16536 RVA: 0x0012D8C0 File Offset: 0x0012BAC0
		public void ClaimFriendShipPoints(int point)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClaimFriendShipPointsInt32_hotfix != null)
			{
				this.m_ClaimFriendShipPointsInt32_hotfix.call(new object[]
				{
					this,
					point
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_friendDS.SetFriendshipPointsClaimedToday(this.m_friendDS.FriendshipPointsClaimedToday + 1);
			this.m_basicInfo.AddFriendshipPoints(point, GameFunctionType.GameFunctionType_Friend, null);
		}

		// Token: 0x06004099 RID: 16537 RVA: 0x0012D958 File Offset: 0x0012BB58
		public int GetFriendshipPointsFromFightWithFriendsToday()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetFriendshipPointsFromFightWithFriendsToday_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetFriendshipPointsFromFightWithFriendsToday_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_friendDS.FriendshipPointsFromFightWithFriendsToday;
		}

		// Token: 0x0600409A RID: 16538 RVA: 0x0012D9D0 File Offset: 0x0012BBD0
		public int AddFriendshipPointsFromFightWithFriendsToday(int pointsToAdd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddFriendshipPointsFromFightWithFriendsTodayInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_AddFriendshipPointsFromFightWithFriendsTodayInt32_hotfix.call(new object[]
				{
					this,
					pointsToAdd
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int friendshipPointsFromFightWithFriendsToday = this.GetFriendshipPointsFromFightWithFriendsToday();
			int num = Math.Min(friendshipPointsFromFightWithFriendsToday + pointsToAdd, this.m_configDataLoader.ConfigableConstId_MaxFriendPointsFightWithFriendsEveryday) - friendshipPointsFromFightWithFriendsToday;
			num = Math.Max(0, num);
			this.m_friendDS.SetFriendshipPointsFromFightWithFriendsToday(pointsToAdd + this.GetFriendshipPointsFromFightWithFriendsToday());
			return num;
		}

		// Token: 0x0600409B RID: 16539 RVA: 0x0012DA88 File Offset: 0x0012BC88
		public int CanUpdateBusinessCardDesc(string desc)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanUpdateBusinessCardDescString_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanUpdateBusinessCardDescString_hotfix.call(new object[]
				{
					this,
					desc
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsBanned(this.m_basicInfo.GetCurrentTime()))
			{
				return -4040;
			}
			if (string.IsNullOrEmpty(desc))
			{
				return -4012;
			}
			if (desc.Length > this.m_configDataLoader.ConfigableConstId_BusinessCardDescMaxLength)
			{
				return -4013;
			}
			return 0;
		}

		// Token: 0x0600409C RID: 16540 RVA: 0x0012DB50 File Offset: 0x0012BD50
		public int CanUpdateBusinessCardHeroSets(List<BusinessCardHeroSet> heroSets)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanUpdateBusinessCardHeroSetsList`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanUpdateBusinessCardHeroSetsList`1_hotfix.call(new object[]
				{
					this,
					heroSets
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (heroSets == null)
			{
				return -4014;
			}
			foreach (BusinessCardHeroSet businessCardHeroSet in heroSets)
			{
				if (this.m_hero.FindHero(businessCardHeroSet.HeroId) == null)
				{
					return -618;
				}
			}
			return 0;
		}

		// Token: 0x0600409D RID: 16541 RVA: 0x0012DC40 File Offset: 0x0012BE40
		private bool IsMySelf(string userId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsMySelfString_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsMySelfString_hotfix.call(new object[]
				{
					this,
					userId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return string.Compare(this.m_basicInfo.GetUserId(), userId) == 0;
		}

		// Token: 0x0600409E RID: 16542 RVA: 0x0012DCD0 File Offset: 0x0012BED0
		private bool HasSendLikesToday(string userId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasSendLikesTodayString_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasSendLikesTodayString_hotfix.call(new object[]
				{
					this,
					userId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_friendDS.LikedUsers.Contains(userId);
		}

		// Token: 0x0600409F RID: 16543 RVA: 0x0012DD60 File Offset: 0x0012BF60
		public bool HasSentFriendShipPoints(string userId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasSentFriendShipPointsString_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasSentFriendShipPointsString_hotfix.call(new object[]
				{
					this,
					userId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_friendDS.FriendshipPointsSent.Contains(userId);
		}

		// Token: 0x060040A0 RID: 16544 RVA: 0x0012DDF0 File Offset: 0x0012BFF0
		public bool HasReceivedFriendShipPoints(string userId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasReceivedFriendShipPointsString_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasReceivedFriendShipPointsString_hotfix.call(new object[]
				{
					this,
					userId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_friendDS.FriendshipPointsReceived.Contains(userId);
		}

		// Token: 0x060040A1 RID: 16545 RVA: 0x0012DE80 File Offset: 0x0012C080
		public void SetBusinessCardDesc(string desc)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBusinessCardDescString_hotfix != null)
			{
				this.m_SetBusinessCardDescString_hotfix.call(new object[]
				{
					this,
					desc
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_friendDS.SetBusinessCardDesc(desc);
		}

		// Token: 0x060040A2 RID: 16546 RVA: 0x0012DEFC File Offset: 0x0012C0FC
		public void SetBusinessCardHeroSet(List<BusinessCardHeroSet> heroSets)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBusinessCardHeroSetList`1_hotfix != null)
			{
				this.m_SetBusinessCardHeroSetList`1_hotfix.call(new object[]
				{
					this,
					heroSets
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_friendDS.SetBusinessCardHeroSet(heroSets);
		}

		// Token: 0x060040A3 RID: 16547 RVA: 0x0012DF78 File Offset: 0x0012C178
		public void SetRandomHeroAction(bool actionRandom)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRandomHeroActionBoolean_hotfix != null)
			{
				this.m_SetRandomHeroActionBoolean_hotfix.call(new object[]
				{
					this,
					actionRandom
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_friendDS.SetRandomHeroAction(actionRandom);
		}

		// Token: 0x060040A4 RID: 16548 RVA: 0x0012DFF4 File Offset: 0x0012C1F4
		public void RemoveFriendshipPointsReceivedUser(string UserId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RemoveFriendshipPointsReceivedUserString_hotfix != null)
			{
				this.m_RemoveFriendshipPointsReceivedUserString_hotfix.call(new object[]
				{
					this,
					UserId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_friendDS.RemoveFriendshipPointsReceivedUser(UserId);
		}

		// Token: 0x060040A5 RID: 16549 RVA: 0x0012E074 File Offset: 0x0012C274
		public List<string> GetFriendshipPointsReceivedUsers()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetFriendshipPointsReceivedUsers_hotfix != null)
			{
				return (List<string>)this.m_GetFriendshipPointsReceivedUsers_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_friendDS.FriendshipPointsReceived;
		}

		// Token: 0x060040A6 RID: 16550 RVA: 0x0012E0EC File Offset: 0x0012C2EC
		public void OnInviteFriendSuccess()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnInviteFriendSuccess_hotfix != null)
			{
				this.m_OnInviteFriendSuccess_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.InviteFriendMissionEvent != null)
			{
				this.InviteFriendMissionEvent();
			}
		}

		// Token: 0x14000035 RID: 53
		// (add) Token: 0x060040A7 RID: 16551 RVA: 0x0012E164 File Offset: 0x0012C364
		// (remove) Token: 0x060040A8 RID: 16552 RVA: 0x0012E200 File Offset: 0x0012C400
		public event Action InviteFriendMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_InviteFriendMissionEventAction_hotfix != null)
				{
					this.m_add_InviteFriendMissionEventAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.InviteFriendMissionEvent;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.InviteFriendMissionEvent, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_InviteFriendMissionEventAction_hotfix != null)
				{
					this.m_remove_InviteFriendMissionEventAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.InviteFriendMissionEvent;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.InviteFriendMissionEvent, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1700112C RID: 4396
		// (get) Token: 0x060040A9 RID: 16553 RVA: 0x0012E29C File Offset: 0x0012C49C
		// (set) Token: 0x060040AA RID: 16554 RVA: 0x0012E2BC File Offset: 0x0012C4BC
		[DoNotToLua]
		public FriendComponentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new FriendComponentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060040AB RID: 16555 RVA: 0x0012E2C8 File Offset: 0x0012C4C8
		private void __callDele_InviteFriendMissionEvent()
		{
			Action inviteFriendMissionEvent = this.InviteFriendMissionEvent;
			if (inviteFriendMissionEvent != null)
			{
				inviteFriendMissionEvent();
			}
		}

		// Token: 0x060040AC RID: 16556 RVA: 0x0012E2E8 File Offset: 0x0012C4E8
		private void __clearDele_InviteFriendMissionEvent()
		{
			this.InviteFriendMissionEvent = null;
		}

		// Token: 0x060040AD RID: 16557 RVA: 0x0012E2F4 File Offset: 0x0012C4F4
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
					this.m_GetName_hotfix = (luaObj.RawGet("GetName") as LuaFunction);
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_PostInit_hotfix = (luaObj.RawGet("PostInit") as LuaFunction);
					this.m_DeInit_hotfix = (luaObj.RawGet("DeInit") as LuaFunction);
					this.m_TickUInt32_hotfix = (luaObj.RawGet("Tick") as LuaFunction);
					this.m_SerializeT_hotfix = (luaObj.RawGet("Serialize") as LuaFunction);
					this.m_DeSerializeT_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_PostDeSerialize_hotfix = (luaObj.RawGet("PostDeSerialize") as LuaFunction);
					this.m_get_Owner_hotfix = (luaObj.RawGet("get_Owner") as LuaFunction);
					this.m_set_OwnerIComponentOwner_hotfix = (luaObj.RawGet("set_Owner") as LuaFunction);
					this.m_OnFlushFriend_hotfix = (luaObj.RawGet("OnFlushFriend") as LuaFunction);
					this.m_BanDateTime_hotfix = (luaObj.RawGet("Ban") as LuaFunction);
					this.m_IsBannedDateTime_hotfix = (luaObj.RawGet("IsBanned") as LuaFunction);
					this.m_SetBusinessCardInfoBusinessCardInfoSet_hotfix = (luaObj.RawGet("SetBusinessCardInfo") as LuaFunction);
					this.m_SetLikesInt32_hotfix = (luaObj.RawGet("SetLikes") as LuaFunction);
					this.m_CanSendLikesString_hotfix = (luaObj.RawGet("CanSendLikes") as LuaFunction);
					this.m_AddLikedUserString_hotfix = (luaObj.RawGet("AddLikedUser") as LuaFunction);
					this.m_SendFriendshipPointsCheckString_hotfix = (luaObj.RawGet("SendFriendshipPointsCheck") as LuaFunction);
					this.m_FilterInvalidSendFriendPointsTargetsList`1_hotfix = (luaObj.RawGet("FilterInvalidSendFriendPointsTargets") as LuaFunction);
					this.m_SendFriendshipPointsString_hotfix = (luaObj.RawGet("SendFriendshipPoints") as LuaFunction);
					this.m_ReceiveFriendshipPointsFromFriendString_hotfix = (luaObj.RawGet("ReceiveFriendshipPointsFromFriend") as LuaFunction);
					this.m_ClaimFriendshipPointsFromFriendCheckString_hotfix = (luaObj.RawGet("ClaimFriendshipPointsFromFriendCheck") as LuaFunction);
					this.m_ClaimFriendshipPointsFromFriendString_hotfix = (luaObj.RawGet("ClaimFriendshipPointsFromFriend") as LuaFunction);
					this.m_ClaimFriendShipPointsInt32_hotfix = (luaObj.RawGet("ClaimFriendShipPoints") as LuaFunction);
					this.m_GetFriendshipPointsFromFightWithFriendsToday_hotfix = (luaObj.RawGet("GetFriendshipPointsFromFightWithFriendsToday") as LuaFunction);
					this.m_AddFriendshipPointsFromFightWithFriendsTodayInt32_hotfix = (luaObj.RawGet("AddFriendshipPointsFromFightWithFriendsToday") as LuaFunction);
					this.m_CanUpdateBusinessCardDescString_hotfix = (luaObj.RawGet("CanUpdateBusinessCardDesc") as LuaFunction);
					this.m_CanUpdateBusinessCardHeroSetsList`1_hotfix = (luaObj.RawGet("CanUpdateBusinessCardHeroSets") as LuaFunction);
					this.m_IsMySelfString_hotfix = (luaObj.RawGet("IsMySelf") as LuaFunction);
					this.m_HasSendLikesTodayString_hotfix = (luaObj.RawGet("HasSendLikesToday") as LuaFunction);
					this.m_HasSentFriendShipPointsString_hotfix = (luaObj.RawGet("HasSentFriendShipPoints") as LuaFunction);
					this.m_HasReceivedFriendShipPointsString_hotfix = (luaObj.RawGet("HasReceivedFriendShipPoints") as LuaFunction);
					this.m_SetBusinessCardDescString_hotfix = (luaObj.RawGet("SetBusinessCardDesc") as LuaFunction);
					this.m_SetBusinessCardHeroSetList`1_hotfix = (luaObj.RawGet("SetBusinessCardHeroSet") as LuaFunction);
					this.m_SetRandomHeroActionBoolean_hotfix = (luaObj.RawGet("SetRandomHeroAction") as LuaFunction);
					this.m_RemoveFriendshipPointsReceivedUserString_hotfix = (luaObj.RawGet("RemoveFriendshipPointsReceivedUser") as LuaFunction);
					this.m_GetFriendshipPointsReceivedUsers_hotfix = (luaObj.RawGet("GetFriendshipPointsReceivedUsers") as LuaFunction);
					this.m_OnInviteFriendSuccess_hotfix = (luaObj.RawGet("OnInviteFriendSuccess") as LuaFunction);
					this.m_add_InviteFriendMissionEventAction_hotfix = (luaObj.RawGet("add_InviteFriendMissionEvent") as LuaFunction);
					this.m_remove_InviteFriendMissionEventAction_hotfix = (luaObj.RawGet("remove_InviteFriendMissionEvent") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060040AE RID: 16558 RVA: 0x0012E7A8 File Offset: 0x0012C9A8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendComponentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400312B RID: 12587
		protected IConfigDataLoader m_configDataLoader;

		// Token: 0x0400312C RID: 12588
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x0400312D RID: 12589
		protected HeroComponentCommon m_hero;

		// Token: 0x0400312E RID: 12590
		protected BagComponentCommon m_bag;

		// Token: 0x0400312F RID: 12591
		protected DataSectionFriend m_friendDS = new DataSectionFriend();

		// Token: 0x04003131 RID: 12593
		[DoNotToLua]
		private FriendComponentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x04003132 RID: 12594
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003133 RID: 12595
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003134 RID: 12596
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04003135 RID: 12597
		private LuaFunction m_GetName_hotfix;

		// Token: 0x04003136 RID: 12598
		private LuaFunction m_Init_hotfix;

		// Token: 0x04003137 RID: 12599
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04003138 RID: 12600
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04003139 RID: 12601
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x0400313A RID: 12602
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x0400313B RID: 12603
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x0400313C RID: 12604
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x0400313D RID: 12605
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x0400313E RID: 12606
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x0400313F RID: 12607
		private LuaFunction m_OnFlushFriend_hotfix;

		// Token: 0x04003140 RID: 12608
		private LuaFunction m_BanDateTime_hotfix;

		// Token: 0x04003141 RID: 12609
		private LuaFunction m_IsBannedDateTime_hotfix;

		// Token: 0x04003142 RID: 12610
		private LuaFunction m_SetBusinessCardInfoBusinessCardInfoSet_hotfix;

		// Token: 0x04003143 RID: 12611
		private LuaFunction m_SetLikesInt32_hotfix;

		// Token: 0x04003144 RID: 12612
		private LuaFunction m_CanSendLikesString_hotfix;

		// Token: 0x04003145 RID: 12613
		private LuaFunction m_AddLikedUserString_hotfix;

		// Token: 0x04003146 RID: 12614
		private LuaFunction m_SendFriendshipPointsCheckString_hotfix;

		// Token: 0x04003147 RID: 12615
		private LuaFunction m_FilterInvalidSendFriendPointsTargetsList;

		// Token: 0x04003148 RID: 12616
		private LuaFunction m_SendFriendshipPointsString_hotfix;

		// Token: 0x04003149 RID: 12617
		private LuaFunction m_ReceiveFriendshipPointsFromFriendString_hotfix;

		// Token: 0x0400314A RID: 12618
		private LuaFunction m_ClaimFriendshipPointsFromFriendCheckString_hotfix;

		// Token: 0x0400314B RID: 12619
		private LuaFunction m_ClaimFriendshipPointsFromFriendString_hotfix;

		// Token: 0x0400314C RID: 12620
		private LuaFunction m_ClaimFriendShipPointsInt32_hotfix;

		// Token: 0x0400314D RID: 12621
		private LuaFunction m_GetFriendshipPointsFromFightWithFriendsToday_hotfix;

		// Token: 0x0400314E RID: 12622
		private LuaFunction m_AddFriendshipPointsFromFightWithFriendsTodayInt32_hotfix;

		// Token: 0x0400314F RID: 12623
		private LuaFunction m_CanUpdateBusinessCardDescString_hotfix;

		// Token: 0x04003150 RID: 12624
		private LuaFunction m_CanUpdateBusinessCardHeroSetsList;

		// Token: 0x04003151 RID: 12625
		private LuaFunction m_IsMySelfString_hotfix;

		// Token: 0x04003152 RID: 12626
		private LuaFunction m_HasSendLikesTodayString_hotfix;

		// Token: 0x04003153 RID: 12627
		private LuaFunction m_HasSentFriendShipPointsString_hotfix;

		// Token: 0x04003154 RID: 12628
		private LuaFunction m_HasReceivedFriendShipPointsString_hotfix;

		// Token: 0x04003155 RID: 12629
		private LuaFunction m_SetBusinessCardDescString_hotfix;

		// Token: 0x04003156 RID: 12630
		private LuaFunction m_SetBusinessCardHeroSetList;

		// Token: 0x04003157 RID: 12631
		private LuaFunction m_SetRandomHeroActionBoolean_hotfix;

		// Token: 0x04003158 RID: 12632
		private LuaFunction m_RemoveFriendshipPointsReceivedUserString_hotfix;

		// Token: 0x04003159 RID: 12633
		private LuaFunction m_GetFriendshipPointsReceivedUsers_hotfix;

		// Token: 0x0400315A RID: 12634
		private LuaFunction m_OnInviteFriendSuccess_hotfix;

		// Token: 0x0400315B RID: 12635
		private LuaFunction m_add_InviteFriendMissionEventAction_hotfix;

		// Token: 0x0400315C RID: 12636
		private LuaFunction m_remove_InviteFriendMissionEventAction_hotfix;

		// Token: 0x02000458 RID: 1112
		public class LuaExportHelper
		{
			// Token: 0x060040AF RID: 16559 RVA: 0x0012E810 File Offset: 0x0012CA10
			public LuaExportHelper(FriendComponentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060040B0 RID: 16560 RVA: 0x0012E820 File Offset: 0x0012CA20
			public void __callDele_InviteFriendMissionEvent()
			{
				this.m_owner.__callDele_InviteFriendMissionEvent();
			}

			// Token: 0x060040B1 RID: 16561 RVA: 0x0012E830 File Offset: 0x0012CA30
			public void __clearDele_InviteFriendMissionEvent()
			{
				this.m_owner.__clearDele_InviteFriendMissionEvent();
			}

			// Token: 0x1700112D RID: 4397
			// (get) Token: 0x060040B2 RID: 16562 RVA: 0x0012E840 File Offset: 0x0012CA40
			// (set) Token: 0x060040B3 RID: 16563 RVA: 0x0012E850 File Offset: 0x0012CA50
			public IConfigDataLoader m_configDataLoader
			{
				get
				{
					return this.m_owner.m_configDataLoader;
				}
				set
				{
					this.m_owner.m_configDataLoader = value;
				}
			}

			// Token: 0x1700112E RID: 4398
			// (get) Token: 0x060040B4 RID: 16564 RVA: 0x0012E860 File Offset: 0x0012CA60
			// (set) Token: 0x060040B5 RID: 16565 RVA: 0x0012E870 File Offset: 0x0012CA70
			public PlayerBasicInfoComponentCommon m_basicInfo
			{
				get
				{
					return this.m_owner.m_basicInfo;
				}
				set
				{
					this.m_owner.m_basicInfo = value;
				}
			}

			// Token: 0x1700112F RID: 4399
			// (get) Token: 0x060040B6 RID: 16566 RVA: 0x0012E880 File Offset: 0x0012CA80
			// (set) Token: 0x060040B7 RID: 16567 RVA: 0x0012E890 File Offset: 0x0012CA90
			public HeroComponentCommon m_hero
			{
				get
				{
					return this.m_owner.m_hero;
				}
				set
				{
					this.m_owner.m_hero = value;
				}
			}

			// Token: 0x17001130 RID: 4400
			// (get) Token: 0x060040B8 RID: 16568 RVA: 0x0012E8A0 File Offset: 0x0012CAA0
			// (set) Token: 0x060040B9 RID: 16569 RVA: 0x0012E8B0 File Offset: 0x0012CAB0
			public BagComponentCommon m_bag
			{
				get
				{
					return this.m_owner.m_bag;
				}
				set
				{
					this.m_owner.m_bag = value;
				}
			}

			// Token: 0x17001131 RID: 4401
			// (get) Token: 0x060040BA RID: 16570 RVA: 0x0012E8C0 File Offset: 0x0012CAC0
			// (set) Token: 0x060040BB RID: 16571 RVA: 0x0012E8D0 File Offset: 0x0012CAD0
			public DataSectionFriend m_friendDS
			{
				get
				{
					return this.m_owner.m_friendDS;
				}
				set
				{
					this.m_owner.m_friendDS = value;
				}
			}

			// Token: 0x060040BC RID: 16572 RVA: 0x0012E8E0 File Offset: 0x0012CAE0
			public void OnFlushFriend()
			{
				this.m_owner.OnFlushFriend();
			}

			// Token: 0x060040BD RID: 16573 RVA: 0x0012E8F0 File Offset: 0x0012CAF0
			public bool IsMySelf(string userId)
			{
				return this.m_owner.IsMySelf(userId);
			}

			// Token: 0x060040BE RID: 16574 RVA: 0x0012E900 File Offset: 0x0012CB00
			public bool HasSendLikesToday(string userId)
			{
				return this.m_owner.HasSendLikesToday(userId);
			}

			// Token: 0x0400315D RID: 12637
			private FriendComponentCommon m_owner;
		}
	}
}
