using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.UtilityTools;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200045E RID: 1118
	[HotFix]
	public class GuildComponentCommon : IComponentBase
	{
		// Token: 0x06004114 RID: 16660 RVA: 0x00130C34 File Offset: 0x0012EE34
		public GuildComponentCommon()
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

		// Token: 0x06004115 RID: 16661 RVA: 0x00130CA8 File Offset: 0x0012EEA8
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
			return "Guild";
		}

		// Token: 0x06004116 RID: 16662 RVA: 0x00130D1C File Offset: 0x0012EF1C
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

		// Token: 0x06004117 RID: 16663 RVA: 0x00130D7C File Offset: 0x0012EF7C
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
			this.m_basicInfo.PlayerActionFlushEvent += this.OnFlushPlayerGuild;
		}

		// Token: 0x06004118 RID: 16664 RVA: 0x00130E44 File Offset: 0x0012F044
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

		// Token: 0x06004119 RID: 16665 RVA: 0x00130EA4 File Offset: 0x0012F0A4
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

		// Token: 0x0600411A RID: 16666 RVA: 0x00130F14 File Offset: 0x0012F114
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

		// Token: 0x0600411B RID: 16667 RVA: 0x00130F94 File Offset: 0x0012F194
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

		// Token: 0x0600411C RID: 16668 RVA: 0x00131004 File Offset: 0x0012F204
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

		// Token: 0x17001140 RID: 4416
		// (get) Token: 0x0600411D RID: 16669 RVA: 0x00131064 File Offset: 0x0012F264
		// (set) Token: 0x0600411E RID: 16670 RVA: 0x001310D8 File Offset: 0x0012F2D8
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

		// Token: 0x0600411F RID: 16671 RVA: 0x00131150 File Offset: 0x0012F350
		private void OnFlushPlayerGuild()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFlushPlayerGuild_hotfix != null)
			{
				this.m_OnFlushPlayerGuild_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DateTime nextFlushPlayerActionTime = this.m_basicInfo.GetNextFlushPlayerActionTime();
			DateTime currentTime = this.m_basicInfo.GetCurrentTime();
			if (nextFlushPlayerActionTime.DayOfWeek != DayOfWeek.Monday && currentTime.StartOfWeek(DayOfWeek.Monday) < nextFlushPlayerActionTime)
			{
				return;
			}
			this.m_guildDS.SetDirty(true);
		}

		// Token: 0x06004120 RID: 16672 RVA: 0x001311F4 File Offset: 0x0012F3F4
		public bool HasOwnGuild()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasOwnGuild_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasOwnGuild_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_guildDS.GuildId != null;
		}

		// Token: 0x06004121 RID: 16673 RVA: 0x00131274 File Offset: 0x0012F474
		public void QuitGuild(DateTime nextJoinTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_QuitGuildDateTime_hotfix != null)
			{
				this.m_QuitGuildDateTime_hotfix.call(new object[]
				{
					this,
					nextJoinTime
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_guildDS.GuildId = null;
			this.m_guildDS.NextJoinTime = nextJoinTime;
		}

		// Token: 0x06004122 RID: 16674 RVA: 0x001312FC File Offset: 0x0012F4FC
		public string GetGuildId()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetGuildId_hotfix != null)
			{
				return (string)this.m_GetGuildId_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_guildDS.GuildId;
		}

		// Token: 0x06004123 RID: 16675 RVA: 0x00131374 File Offset: 0x0012F574
		public void SetGuildId(string id)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGuildIdString_hotfix != null)
			{
				this.m_SetGuildIdString_hotfix.call(new object[]
				{
					this,
					id
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_guildDS.GuildId = id;
		}

		// Token: 0x06004124 RID: 16676 RVA: 0x001313F0 File Offset: 0x0012F5F0
		public int CanCreateGuild(string guildName, string hiringDeclaration, int joinLevel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanCreateGuildStringStringInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanCreateGuildStringStringInt32_hotfix.call(new object[]
				{
					this,
					guildName,
					hiringDeclaration,
					joinLevel
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_basicInfo.GetLevel() < this.m_configDataLoader.ConfigableConstId_GuildCreateJoinLevel)
			{
				return -5200;
			}
			if (this.HasOwnGuild())
			{
				return -5201;
			}
			if (joinLevel > this.m_configDataLoader.ConfigableConstId_PlayerLevelMaxLevel || joinLevel <= 0)
			{
				return -5228;
			}
			if (!this.m_bag.IsBagItemEnough(GoodsType.GoodsType_Item, this.m_configDataLoader.ConfigableConstId_GuildCreateItemId, 1))
			{
				return -501;
			}
			int num = this.CheckGuildHiringDeclaration(hiringDeclaration);
			if (num != 0)
			{
				return num;
			}
			return this.CheckGuildName(guildName);
		}

		// Token: 0x06004125 RID: 16677 RVA: 0x00131518 File Offset: 0x0012F718
		public int CanJoinGuild()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanJoinGuild_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanJoinGuild_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_basicInfo.GetLevel() < this.m_configDataLoader.ConfigableConstId_GuildCreateJoinLevel)
			{
				return -5200;
			}
			if (this.HasOwnGuild())
			{
				return -5201;
			}
			if (this.m_basicInfo.GetCurrentTime() < this.m_guildDS.NextJoinTime)
			{
				return -5203;
			}
			return 0;
		}

		// Token: 0x06004126 RID: 16678 RVA: 0x001315E0 File Offset: 0x0012F7E0
		public int CanQuitGuild()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanQuitGuild_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanQuitGuild_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return (!this.HasOwnGuild()) ? -5207 : 0;
		}

		// Token: 0x06004127 RID: 16679 RVA: 0x00131664 File Offset: 0x0012F864
		public int CanKickOutGuild()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanKickOutGuild_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanKickOutGuild_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return (!this.HasOwnGuild()) ? -5207 : 0;
		}

		// Token: 0x06004128 RID: 16680 RVA: 0x001316E8 File Offset: 0x0012F8E8
		public int CanApplyToJoinGuild()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanApplyToJoinGuild_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanApplyToJoinGuild_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.CanJoinGuild();
		}

		// Token: 0x06004129 RID: 16681 RVA: 0x0013175C File Offset: 0x0012F95C
		public int CanConfirmJoinGuildInvitation(string guildId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanConfirmJoinGuildInvitationString_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanConfirmJoinGuildInvitationString_hotfix.call(new object[]
				{
					this,
					guildId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_guildDS.IsInInvitedGuild(guildId))
			{
				return -5226;
			}
			if (this.HasOwnGuild())
			{
				return -5201;
			}
			if (this.m_basicInfo.GetCurrentTime() < this.m_guildDS.NextJoinTime)
			{
				return -5203;
			}
			return 0;
		}

		// Token: 0x0600412A RID: 16682 RVA: 0x00131828 File Offset: 0x0012FA28
		public void RefuseJoinGuildInvitation(string guildId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RefuseJoinGuildInvitationString_hotfix != null)
			{
				this.m_RefuseJoinGuildInvitationString_hotfix.call(new object[]
				{
					this,
					guildId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_guildDS.RemoveJoinGuildInvitation(guildId);
		}

		// Token: 0x0600412B RID: 16683 RVA: 0x001318A4 File Offset: 0x0012FAA4
		public void RefuseAllJoinGuildInvitation()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RefuseAllJoinGuildInvitation_hotfix != null)
			{
				this.m_RefuseAllJoinGuildInvitation_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_guildDS.ClearJoinGuildInvitation();
		}

		// Token: 0x0600412C RID: 16684 RVA: 0x00131910 File Offset: 0x0012FB10
		public virtual int CheckGuildName(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckGuildNameString_hotfix != null)
			{
				return Convert.ToInt32(this.m_CheckGuildNameString_hotfix.call(new object[]
				{
					this,
					name
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (string.IsNullOrEmpty(name))
			{
				return -5206;
			}
			if (!StringCheck.IsStringLegal(name))
			{
				return -5206;
			}
			if (this.m_configDataLoader.UtilityGetSensitiveWords().IsSensitiveWord(name))
			{
				return -5206;
			}
			if (name.Length > this.m_configDataLoader.ConfigableConstId_GuildNameMaxLength)
			{
				return -5212;
			}
			return 0;
		}

		// Token: 0x0600412D RID: 16685 RVA: 0x001319E8 File Offset: 0x0012FBE8
		public int CheckGuildSearch(string searchText)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckGuildSearchString_hotfix != null)
			{
				return Convert.ToInt32(this.m_CheckGuildSearchString_hotfix.call(new object[]
				{
					this,
					searchText
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (string.IsNullOrEmpty(searchText))
			{
				return int.MinValue;
			}
			int num = this.CheckGuildName(searchText);
			if (num != 0)
			{
				return num;
			}
			if (this.m_latGuildSearchTime.AddMilliseconds(3000.0) >= this.m_basicInfo.GetCurrentTime())
			{
				return -5205;
			}
			this.m_latGuildSearchTime = this.m_basicInfo.GetCurrentTime();
			return 0;
		}

		// Token: 0x0600412E RID: 16686 RVA: 0x00131AC8 File Offset: 0x0012FCC8
		public int CheckGuildRandomList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckGuildRandomList_hotfix != null)
			{
				return Convert.ToInt32(this.m_CheckGuildRandomList_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.HasOwnGuild())
			{
				return -5201;
			}
			if (this.m_latGuildRandomListTime.AddMilliseconds(3000.0) >= this.m_basicInfo.GetCurrentTime())
			{
				return -5205;
			}
			this.m_latGuildRandomListTime = this.m_basicInfo.GetCurrentTime();
			return 0;
		}

		// Token: 0x0600412F RID: 16687 RVA: 0x00131B88 File Offset: 0x0012FD88
		public int CheckGuildInvitePlayerList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckGuildInvitePlayerList_hotfix != null)
			{
				return Convert.ToInt32(this.m_CheckGuildInvitePlayerList_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasOwnGuild())
			{
				return -5207;
			}
			if (this.m_latGuildInvitePlayerListTime.AddMilliseconds(3000.0) >= this.m_basicInfo.GetCurrentTime())
			{
				return -5205;
			}
			this.m_latGuildInvitePlayerListTime = this.m_basicInfo.GetCurrentTime();
			return 0;
		}

		// Token: 0x06004130 RID: 16688 RVA: 0x00131C48 File Offset: 0x0012FE48
		public int CanSetGuildHiringDeclaration(string hiringDeclaration)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanSetGuildHiringDeclarationString_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanSetGuildHiringDeclarationString_hotfix.call(new object[]
				{
					this,
					hiringDeclaration
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasOwnGuild())
			{
				return -5207;
			}
			return this.CheckGuildHiringDeclaration(hiringDeclaration);
		}

		// Token: 0x06004131 RID: 16689 RVA: 0x00131CDC File Offset: 0x0012FEDC
		public int CheckGuildHiringDeclaration(string hiringDeclaration)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckGuildHiringDeclarationString_hotfix != null)
			{
				return Convert.ToInt32(this.m_CheckGuildHiringDeclarationString_hotfix.call(new object[]
				{
					this,
					hiringDeclaration
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (string.IsNullOrEmpty(hiringDeclaration))
			{
				return 0;
			}
			if (hiringDeclaration.Length > this.m_configDataLoader.ConfigableConstId_GuildHiringDeclarationMaxLength)
			{
				return -5210;
			}
			return 0;
		}

		// Token: 0x06004132 RID: 16690 RVA: 0x00131D84 File Offset: 0x0012FF84
		public int CanSetGuildAnnouncement(string announcement)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanSetGuildAnnouncementString_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanSetGuildAnnouncementString_hotfix.call(new object[]
				{
					this,
					announcement
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasOwnGuild())
			{
				return -5207;
			}
			return this.CheckGuildAnnouncement(announcement);
		}

		// Token: 0x06004133 RID: 16691 RVA: 0x00131E18 File Offset: 0x00130018
		public int CheckGuildAnnouncement(string announcement)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckGuildAnnouncementString_hotfix != null)
			{
				return Convert.ToInt32(this.m_CheckGuildAnnouncementString_hotfix.call(new object[]
				{
					this,
					announcement
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (string.IsNullOrEmpty(announcement))
			{
				return 0;
			}
			if (announcement.Length > this.m_configDataLoader.ConfigableConstId_GuildAnnouncementMaxLength)
			{
				return -5223;
			}
			return 0;
		}

		// Token: 0x06004134 RID: 16692 RVA: 0x00131EC0 File Offset: 0x001300C0
		public int CanStartMassiveCombat()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanStartMassiveCombat_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanStartMassiveCombat_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.HasOwnGuild())
			{
				return -5207;
			}
			return 0;
		}

		// Token: 0x06004135 RID: 16693 RVA: 0x00131F40 File Offset: 0x00130140
		public int CanTheseHeroesAttackStronghold(List<int> heroIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanTheseHeroesAttackStrongholdList`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanTheseHeroesAttackStrongholdList`1_hotfix.call(new object[]
				{
					this,
					heroIds
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (int item in this.GuildDS.MassiveCombat.UsedHeroIds)
			{
				if (heroIds.Contains(item))
				{
					return -5237;
				}
			}
			return 0;
		}

		// Token: 0x06004136 RID: 16694 RVA: 0x00132028 File Offset: 0x00130228
		public int CanAttackStronghold(int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAttackStrongholdInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAttackStrongholdInt32_hotfix.call(new object[]
				{
					this,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!string.IsNullOrEmpty(this.GuildDS.MassiveCombat.BindedGuildId) && this.GuildDS.MassiveCombat.BindedGuildId != this.GuildId)
			{
				return -5236;
			}
			if (this.GetMassiveCombatUnusedHeroes().Count < 1)
			{
				return -937;
			}
			return 0;
		}

		// Token: 0x06004137 RID: 16695 RVA: 0x001320FC File Offset: 0x001302FC
		public List<Hero> GetMassiveCombatUnusedHeroes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetMassiveCombatUnusedHeroes_hotfix != null)
			{
				return (List<Hero>)this.m_GetMassiveCombatUnusedHeroes_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Hero> allHeros = this.m_hero.GetAllHeros();
			List<int> usedIds = this.GuildDS.MassiveCombat.UsedHeroIds;
			allHeros.RemoveAll((Hero m) => usedIds.Contains(m.HeroId));
			return allHeros;
		}

		// Token: 0x06004138 RID: 16696 RVA: 0x001321A4 File Offset: 0x001303A4
		public int GetEliminateRate(GuildMassiveCombatInfo combat)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetEliminateRateGuildMassiveCombatInfo_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetEliminateRateGuildMassiveCombatInfo_hotfix.call(new object[]
				{
					this,
					combat
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DateTime currentTime = this.m_basicInfo.GetCurrentTime();
			int num = 0;
			int num2 = 0;
			foreach (GuildMassiveCombatStronghold guildMassiveCombatStronghold in combat.Strongholds)
			{
				ConfigDataGuildMassiveCombatStrongholdInfo configDataGuildMassiveCombatStrongholdInfo = this.m_configDataLoader.GetConfigDataGuildMassiveCombatStrongholdInfo(guildMassiveCombatStronghold.ConfigId);
				num2 += configDataGuildMassiveCombatStrongholdInfo.EnemyCount;
				num += guildMassiveCombatStronghold.EnemyEliminated;
			}
			return Math.Min(10000 * num / num2, 10000);
		}

		// Token: 0x06004139 RID: 16697 RVA: 0x001322B4 File Offset: 0x001304B4
		public int GetStrongholdEliminateRate(GuildMassiveCombatStronghold stronghold)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetStrongholdEliminateRateGuildMassiveCombatStronghold_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetStrongholdEliminateRateGuildMassiveCombatStronghold_hotfix.call(new object[]
				{
					this,
					stronghold
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DateTime currentTime = this.m_basicInfo.GetCurrentTime();
			ConfigDataGuildMassiveCombatStrongholdInfo configDataGuildMassiveCombatStrongholdInfo = this.m_configDataLoader.GetConfigDataGuildMassiveCombatStrongholdInfo(stronghold.ConfigId);
			int enemyCount = configDataGuildMassiveCombatStrongholdInfo.EnemyCount;
			int enemyEliminated = stronghold.EnemyEliminated;
			return Math.Min(10000 * enemyEliminated / enemyCount, 10000);
		}

		// Token: 0x0600413A RID: 16698 RVA: 0x00132374 File Offset: 0x00130574
		public int GetStartedCombatThisWeek(GuildMassiveCombatGeneral generalInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetStartedCombatThisWeekGuildMassiveCombatGeneral_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetStartedCombatThisWeekGuildMassiveCombatGeneral_hotfix.call(new object[]
				{
					this,
					generalInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DateTime currentTime = this.m_basicInfo.GetCurrentTime();
			DateTime t = currentTime.StartOfWeek(DayOfWeek.Monday);
			int num = 0;
			if (generalInfo != null)
			{
				foreach (GuildMassiveCombatInfo guildMassiveCombatInfo in generalInfo.FinishedCombats)
				{
					if (guildMassiveCombatInfo.CreateTime > t)
					{
						num++;
					}
				}
				if (generalInfo.RecentCombat != null && generalInfo.RecentCombat.CreateTime > t)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x17001141 RID: 4417
		// (get) Token: 0x0600413B RID: 16699 RVA: 0x00132490 File Offset: 0x00130690
		public string GuildId
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_GuildId_hotfix != null)
				{
					return (string)this.m_get_GuildId_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_guildDS.GuildId;
			}
		}

		// Token: 0x17001142 RID: 4418
		// (get) Token: 0x0600413C RID: 16700 RVA: 0x00132508 File Offset: 0x00130708
		public DateTime NextJoinTime
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_NextJoinTime_hotfix != null)
				{
					return (DateTime)this.m_get_NextJoinTime_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_guildDS.NextJoinTime;
			}
		}

		// Token: 0x17001143 RID: 4419
		// (get) Token: 0x0600413D RID: 16701 RVA: 0x00132580 File Offset: 0x00130780
		public DataSectionGuild GuildDS
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_GuildDS_hotfix != null)
				{
					return (DataSectionGuild)this.m_get_GuildDS_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_guildDS;
			}
		}

		// Token: 0x17001144 RID: 4420
		// (get) Token: 0x0600413E RID: 16702 RVA: 0x001325F4 File Offset: 0x001307F4
		// (set) Token: 0x0600413F RID: 16703 RVA: 0x00132668 File Offset: 0x00130868
		public long GetGuildLastUpdateTime
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_GetGuildLastUpdateTime_hotfix != null)
				{
					return Convert.ToInt64(this.m_get_GetGuildLastUpdateTime_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<GetGuildLastUpdateTime>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_GetGuildLastUpdateTimeInt64_hotfix != null)
				{
					this.m_set_GetGuildLastUpdateTimeInt64_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<GetGuildLastUpdateTime>k__BackingField = value;
			}
		}

		// Token: 0x17001145 RID: 4421
		// (get) Token: 0x06004140 RID: 16704 RVA: 0x001326E0 File Offset: 0x001308E0
		// (set) Token: 0x06004141 RID: 16705 RVA: 0x00132700 File Offset: 0x00130900
		[DoNotToLua]
		public GuildComponentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GuildComponentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06004142 RID: 16706 RVA: 0x0013270C File Offset: 0x0013090C
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
					this.m_OnFlushPlayerGuild_hotfix = (luaObj.RawGet("OnFlushPlayerGuild") as LuaFunction);
					this.m_HasOwnGuild_hotfix = (luaObj.RawGet("HasOwnGuild") as LuaFunction);
					this.m_QuitGuildDateTime_hotfix = (luaObj.RawGet("QuitGuild") as LuaFunction);
					this.m_GetGuildId_hotfix = (luaObj.RawGet("GetGuildId") as LuaFunction);
					this.m_SetGuildIdString_hotfix = (luaObj.RawGet("SetGuildId") as LuaFunction);
					this.m_CanCreateGuildStringStringInt32_hotfix = (luaObj.RawGet("CanCreateGuild") as LuaFunction);
					this.m_CanJoinGuild_hotfix = (luaObj.RawGet("CanJoinGuild") as LuaFunction);
					this.m_CanQuitGuild_hotfix = (luaObj.RawGet("CanQuitGuild") as LuaFunction);
					this.m_CanKickOutGuild_hotfix = (luaObj.RawGet("CanKickOutGuild") as LuaFunction);
					this.m_CanApplyToJoinGuild_hotfix = (luaObj.RawGet("CanApplyToJoinGuild") as LuaFunction);
					this.m_CanConfirmJoinGuildInvitationString_hotfix = (luaObj.RawGet("CanConfirmJoinGuildInvitation") as LuaFunction);
					this.m_RefuseJoinGuildInvitationString_hotfix = (luaObj.RawGet("RefuseJoinGuildInvitation") as LuaFunction);
					this.m_RefuseAllJoinGuildInvitation_hotfix = (luaObj.RawGet("RefuseAllJoinGuildInvitation") as LuaFunction);
					this.m_CheckGuildNameString_hotfix = (luaObj.RawGet("CheckGuildName") as LuaFunction);
					this.m_CheckGuildSearchString_hotfix = (luaObj.RawGet("CheckGuildSearch") as LuaFunction);
					this.m_CheckGuildRandomList_hotfix = (luaObj.RawGet("CheckGuildRandomList") as LuaFunction);
					this.m_CheckGuildInvitePlayerList_hotfix = (luaObj.RawGet("CheckGuildInvitePlayerList") as LuaFunction);
					this.m_CanSetGuildHiringDeclarationString_hotfix = (luaObj.RawGet("CanSetGuildHiringDeclaration") as LuaFunction);
					this.m_CheckGuildHiringDeclarationString_hotfix = (luaObj.RawGet("CheckGuildHiringDeclaration") as LuaFunction);
					this.m_CanSetGuildAnnouncementString_hotfix = (luaObj.RawGet("CanSetGuildAnnouncement") as LuaFunction);
					this.m_CheckGuildAnnouncementString_hotfix = (luaObj.RawGet("CheckGuildAnnouncement") as LuaFunction);
					this.m_CanStartMassiveCombat_hotfix = (luaObj.RawGet("CanStartMassiveCombat") as LuaFunction);
					this.m_CanTheseHeroesAttackStrongholdList`1_hotfix = (luaObj.RawGet("CanTheseHeroesAttackStronghold") as LuaFunction);
					this.m_CanAttackStrongholdInt32_hotfix = (luaObj.RawGet("CanAttackStronghold") as LuaFunction);
					this.m_GetMassiveCombatUnusedHeroes_hotfix = (luaObj.RawGet("GetMassiveCombatUnusedHeroes") as LuaFunction);
					this.m_GetEliminateRateGuildMassiveCombatInfo_hotfix = (luaObj.RawGet("GetEliminateRate") as LuaFunction);
					this.m_GetStrongholdEliminateRateGuildMassiveCombatStronghold_hotfix = (luaObj.RawGet("GetStrongholdEliminateRate") as LuaFunction);
					this.m_GetStartedCombatThisWeekGuildMassiveCombatGeneral_hotfix = (luaObj.RawGet("GetStartedCombatThisWeek") as LuaFunction);
					this.m_get_GuildId_hotfix = (luaObj.RawGet("get_GuildId") as LuaFunction);
					this.m_get_NextJoinTime_hotfix = (luaObj.RawGet("get_NextJoinTime") as LuaFunction);
					this.m_get_GuildDS_hotfix = (luaObj.RawGet("get_GuildDS") as LuaFunction);
					this.m_get_GetGuildLastUpdateTime_hotfix = (luaObj.RawGet("get_GetGuildLastUpdateTime") as LuaFunction);
					this.m_set_GetGuildLastUpdateTimeInt64_hotfix = (luaObj.RawGet("set_GetGuildLastUpdateTime") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06004143 RID: 16707 RVA: 0x00132C0C File Offset: 0x00130E0C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildComponentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400319F RID: 12703
		protected IConfigDataLoader m_configDataLoader;

		// Token: 0x040031A0 RID: 12704
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x040031A1 RID: 12705
		protected HeroComponentCommon m_hero;

		// Token: 0x040031A2 RID: 12706
		protected BagComponentCommon m_bag;

		// Token: 0x040031A3 RID: 12707
		protected DataSectionGuild m_guildDS = new DataSectionGuild();

		// Token: 0x040031A4 RID: 12708
		private DateTime m_latGuildSearchTime;

		// Token: 0x040031A5 RID: 12709
		private DateTime m_latGuildRandomListTime;

		// Token: 0x040031A6 RID: 12710
		private DateTime m_latGuildInvitePlayerListTime;

		// Token: 0x040031A8 RID: 12712
		[DoNotToLua]
		private GuildComponentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x040031A9 RID: 12713
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040031AA RID: 12714
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040031AB RID: 12715
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040031AC RID: 12716
		private LuaFunction m_GetName_hotfix;

		// Token: 0x040031AD RID: 12717
		private LuaFunction m_Init_hotfix;

		// Token: 0x040031AE RID: 12718
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x040031AF RID: 12719
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x040031B0 RID: 12720
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x040031B1 RID: 12721
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x040031B2 RID: 12722
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x040031B3 RID: 12723
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x040031B4 RID: 12724
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x040031B5 RID: 12725
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x040031B6 RID: 12726
		private LuaFunction m_OnFlushPlayerGuild_hotfix;

		// Token: 0x040031B7 RID: 12727
		private LuaFunction m_HasOwnGuild_hotfix;

		// Token: 0x040031B8 RID: 12728
		private LuaFunction m_QuitGuildDateTime_hotfix;

		// Token: 0x040031B9 RID: 12729
		private LuaFunction m_GetGuildId_hotfix;

		// Token: 0x040031BA RID: 12730
		private LuaFunction m_SetGuildIdString_hotfix;

		// Token: 0x040031BB RID: 12731
		private LuaFunction m_CanCreateGuildStringStringInt32_hotfix;

		// Token: 0x040031BC RID: 12732
		private LuaFunction m_CanJoinGuild_hotfix;

		// Token: 0x040031BD RID: 12733
		private LuaFunction m_CanQuitGuild_hotfix;

		// Token: 0x040031BE RID: 12734
		private LuaFunction m_CanKickOutGuild_hotfix;

		// Token: 0x040031BF RID: 12735
		private LuaFunction m_CanApplyToJoinGuild_hotfix;

		// Token: 0x040031C0 RID: 12736
		private LuaFunction m_CanConfirmJoinGuildInvitationString_hotfix;

		// Token: 0x040031C1 RID: 12737
		private LuaFunction m_RefuseJoinGuildInvitationString_hotfix;

		// Token: 0x040031C2 RID: 12738
		private LuaFunction m_RefuseAllJoinGuildInvitation_hotfix;

		// Token: 0x040031C3 RID: 12739
		private LuaFunction m_CheckGuildNameString_hotfix;

		// Token: 0x040031C4 RID: 12740
		private LuaFunction m_CheckGuildSearchString_hotfix;

		// Token: 0x040031C5 RID: 12741
		private LuaFunction m_CheckGuildRandomList_hotfix;

		// Token: 0x040031C6 RID: 12742
		private LuaFunction m_CheckGuildInvitePlayerList_hotfix;

		// Token: 0x040031C7 RID: 12743
		private LuaFunction m_CanSetGuildHiringDeclarationString_hotfix;

		// Token: 0x040031C8 RID: 12744
		private LuaFunction m_CheckGuildHiringDeclarationString_hotfix;

		// Token: 0x040031C9 RID: 12745
		private LuaFunction m_CanSetGuildAnnouncementString_hotfix;

		// Token: 0x040031CA RID: 12746
		private LuaFunction m_CheckGuildAnnouncementString_hotfix;

		// Token: 0x040031CB RID: 12747
		private LuaFunction m_CanStartMassiveCombat_hotfix;

		// Token: 0x040031CC RID: 12748
		private LuaFunction m_CanTheseHeroesAttackStrongholdList;

		// Token: 0x040031CD RID: 12749
		private LuaFunction m_CanAttackStrongholdInt32_hotfix;

		// Token: 0x040031CE RID: 12750
		private LuaFunction m_GetMassiveCombatUnusedHeroes_hotfix;

		// Token: 0x040031CF RID: 12751
		private LuaFunction m_GetEliminateRateGuildMassiveCombatInfo_hotfix;

		// Token: 0x040031D0 RID: 12752
		private LuaFunction m_GetStrongholdEliminateRateGuildMassiveCombatStronghold_hotfix;

		// Token: 0x040031D1 RID: 12753
		private LuaFunction m_GetStartedCombatThisWeekGuildMassiveCombatGeneral_hotfix;

		// Token: 0x040031D2 RID: 12754
		private LuaFunction m_get_GuildId_hotfix;

		// Token: 0x040031D3 RID: 12755
		private LuaFunction m_get_NextJoinTime_hotfix;

		// Token: 0x040031D4 RID: 12756
		private LuaFunction m_get_GuildDS_hotfix;

		// Token: 0x040031D5 RID: 12757
		private LuaFunction m_get_GetGuildLastUpdateTime_hotfix;

		// Token: 0x040031D6 RID: 12758
		private LuaFunction m_set_GetGuildLastUpdateTimeInt64_hotfix;

		// Token: 0x0200045F RID: 1119
		public class LuaExportHelper
		{
			// Token: 0x06004144 RID: 16708 RVA: 0x00132C74 File Offset: 0x00130E74
			public LuaExportHelper(GuildComponentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17001146 RID: 4422
			// (get) Token: 0x06004145 RID: 16709 RVA: 0x00132C84 File Offset: 0x00130E84
			// (set) Token: 0x06004146 RID: 16710 RVA: 0x00132C94 File Offset: 0x00130E94
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

			// Token: 0x17001147 RID: 4423
			// (get) Token: 0x06004147 RID: 16711 RVA: 0x00132CA4 File Offset: 0x00130EA4
			// (set) Token: 0x06004148 RID: 16712 RVA: 0x00132CB4 File Offset: 0x00130EB4
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

			// Token: 0x17001148 RID: 4424
			// (get) Token: 0x06004149 RID: 16713 RVA: 0x00132CC4 File Offset: 0x00130EC4
			// (set) Token: 0x0600414A RID: 16714 RVA: 0x00132CD4 File Offset: 0x00130ED4
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

			// Token: 0x17001149 RID: 4425
			// (get) Token: 0x0600414B RID: 16715 RVA: 0x00132CE4 File Offset: 0x00130EE4
			// (set) Token: 0x0600414C RID: 16716 RVA: 0x00132CF4 File Offset: 0x00130EF4
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

			// Token: 0x1700114A RID: 4426
			// (get) Token: 0x0600414D RID: 16717 RVA: 0x00132D04 File Offset: 0x00130F04
			// (set) Token: 0x0600414E RID: 16718 RVA: 0x00132D14 File Offset: 0x00130F14
			public DataSectionGuild m_guildDS
			{
				get
				{
					return this.m_owner.m_guildDS;
				}
				set
				{
					this.m_owner.m_guildDS = value;
				}
			}

			// Token: 0x1700114B RID: 4427
			// (get) Token: 0x0600414F RID: 16719 RVA: 0x00132D24 File Offset: 0x00130F24
			// (set) Token: 0x06004150 RID: 16720 RVA: 0x00132D34 File Offset: 0x00130F34
			public DateTime m_latGuildSearchTime
			{
				get
				{
					return this.m_owner.m_latGuildSearchTime;
				}
				set
				{
					this.m_owner.m_latGuildSearchTime = value;
				}
			}

			// Token: 0x1700114C RID: 4428
			// (get) Token: 0x06004151 RID: 16721 RVA: 0x00132D44 File Offset: 0x00130F44
			// (set) Token: 0x06004152 RID: 16722 RVA: 0x00132D54 File Offset: 0x00130F54
			public DateTime m_latGuildRandomListTime
			{
				get
				{
					return this.m_owner.m_latGuildRandomListTime;
				}
				set
				{
					this.m_owner.m_latGuildRandomListTime = value;
				}
			}

			// Token: 0x1700114D RID: 4429
			// (get) Token: 0x06004153 RID: 16723 RVA: 0x00132D64 File Offset: 0x00130F64
			// (set) Token: 0x06004154 RID: 16724 RVA: 0x00132D74 File Offset: 0x00130F74
			public DateTime m_latGuildInvitePlayerListTime
			{
				get
				{
					return this.m_owner.m_latGuildInvitePlayerListTime;
				}
				set
				{
					this.m_owner.m_latGuildInvitePlayerListTime = value;
				}
			}

			// Token: 0x06004155 RID: 16725 RVA: 0x00132D84 File Offset: 0x00130F84
			public void OnFlushPlayerGuild()
			{
				this.m_owner.OnFlushPlayerGuild();
			}

			// Token: 0x040031D7 RID: 12759
			private GuildComponentCommon m_owner;
		}
	}
}
