using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using BlackJack.ProjectL.UI;
using BlackJack.UtilityTools;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x020008B8 RID: 2232
	[HotFix]
	public class GuildComponent : GuildComponentCommon
	{
		// Token: 0x06007059 RID: 28761 RVA: 0x001F62C4 File Offset: 0x001F44C4
		public GuildComponent()
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

		// Token: 0x0600705A RID: 28762 RVA: 0x001F6358 File Offset: 0x001F4558
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
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			this.ResetGuild();
		}

		// Token: 0x0600705B RID: 28763 RVA: 0x001F63DC File Offset: 0x001F45DC
		public string GetGuildLogContent(GuildLog log)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetGuildLogContentGuildLog_hotfix != null)
			{
				return (string)this.m_GetGuildLogContentGuildLog_hotfix.call(new object[]
				{
					this,
					log
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataStringTable configDataStringTable = this.m_configDataLoader.GetConfigDataStringTable(log.ModeId);
			if (configDataStringTable == null)
			{
				return null;
			}
			if (configDataStringTable.Value == null || log.Content == null)
			{
				return null;
			}
			return CombineStringTools.ReplaceHasParamContent(configDataStringTable.Value, log.Content);
		}

		// Token: 0x0600705C RID: 28764 RVA: 0x001F649C File Offset: 0x001F469C
		public void SetGuildDataSection(DSGuildNtf dsGuildNtf)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGuildDataSectionDSGuildNtf_hotfix != null)
			{
				this.m_SetGuildDataSectionDSGuildNtf_hotfix.call(new object[]
				{
					this,
					dsGuildNtf
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_guildDS.ClearInitedData();
			base.SetGuildId(dsGuildNtf.GuildId);
			this.m_guildDS.NextJoinTime = new DateTime(dsGuildNtf.NextJoinTime);
		}

		// Token: 0x0600705D RID: 28765 RVA: 0x001F653C File Offset: 0x001F473C
		public void RefreshGuild(ProGuild proGuild)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RefreshGuildProGuild_hotfix != null)
			{
				this.m_RefreshGuildProGuild_hotfix.call(new object[]
				{
					this,
					proGuild
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (proGuild == null)
			{
				base.SetGuildId(null);
				this.m_guild = null;
				return;
			}
			base.SetGuildId(proGuild.Id);
			Guild guild = Guild.FromPb(proGuild);
			if (guild == null)
			{
				this.m_guild = null;
			}
			else
			{
				if (this.m_guild == null)
				{
					this.m_guild = guild;
					return;
				}
				this.m_guild.Id = guild.Id;
				this.m_guild.Name = guild.Name;
				this.m_guild.Bulletin = guild.Bulletin;
				this.m_guild.HiringDeclaration = guild.HiringDeclaration;
				this.m_guild.AutoJoin = guild.AutoJoin;
				this.m_guild.TotalBattlePower = guild.TotalBattlePower;
				this.m_guild.TotalActivities = guild.TotalActivities;
				this.m_guild.LastWeekActivities = guild.LastWeekActivities;
				this.m_guild.Activities = guild.Activities;
				this.m_guild.CurrentWeekActivities = guild.CurrentWeekActivities;
				this.m_guild.Members = guild.Members;
			}
		}

		// Token: 0x0600705E RID: 28766 RVA: 0x001F66B4 File Offset: 0x001F48B4
		public void RefreshGuildListJoinState(string id, bool isJoinRequest)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RefreshGuildListJoinStateStringBoolean_hotfix != null)
			{
				this.m_RefreshGuildListJoinStateStringBoolean_hotfix.call(new object[]
				{
					this,
					id,
					isJoinRequest
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_guildSearchList != null)
			{
				foreach (GuildSearchInfo guildSearchInfo in this.m_guildSearchList)
				{
					if (guildSearchInfo.Id == id)
					{
						guildSearchInfo.HaveSendJoinReq = isJoinRequest;
					}
				}
			}
			if (this.m_guildRecommendList != null)
			{
				foreach (GuildSearchInfo guildSearchInfo2 in this.m_guildRecommendList)
				{
					if (guildSearchInfo2.Id == id)
					{
						guildSearchInfo2.HaveSendJoinReq = isJoinRequest;
					}
				}
			}
		}

		// Token: 0x0600705F RID: 28767 RVA: 0x001F6808 File Offset: 0x001F4A08
		public void PlayerRefuseGuild(string guildID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerRefuseGuildString_hotfix != null)
			{
				this.m_PlayerRefuseGuildString_hotfix.call(new object[]
				{
					this,
					guildID
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			for (int i = 0; i < this.m_guildJoinInvitationList.Count; i++)
			{
				if (this.m_guildJoinInvitationList[i].GuildId == guildID)
				{
					this.m_guildJoinInvitationList.RemoveAt(i);
					return;
				}
			}
		}

		// Token: 0x06007060 RID: 28768 RVA: 0x001F68C0 File Offset: 0x001F4AC0
		public void ResetGuild()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ResetGuild_hotfix != null)
			{
				this.m_ResetGuild_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_guild = null;
			this.m_guildInviteUserIdList.Clear();
			this.m_guildSearchList.Clear();
			if (this.m_guildRecommendList != null)
			{
				this.m_guildRecommendList.Clear();
				this.m_guildRecommendList = null;
			}
			this.m_guildJoinInvitationList.Clear();
			this.m_guildJoinApplyList.Clear();
		}

		// Token: 0x17001BCD RID: 7117
		// (get) Token: 0x06007061 RID: 28769 RVA: 0x001F6970 File Offset: 0x001F4B70
		// (set) Token: 0x06007062 RID: 28770 RVA: 0x001F6990 File Offset: 0x001F4B90
		[DoNotToLua]
		public new GuildComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GuildComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06007063 RID: 28771 RVA: 0x001F699C File Offset: 0x001F4B9C
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x06007064 RID: 28772 RVA: 0x001F69A4 File Offset: 0x001F4BA4
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x06007065 RID: 28773 RVA: 0x001F69AC File Offset: 0x001F4BAC
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x06007066 RID: 28774 RVA: 0x001F69B4 File Offset: 0x001F4BB4
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x06007067 RID: 28775 RVA: 0x001F69BC File Offset: 0x001F4BBC
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x06007068 RID: 28776 RVA: 0x001F69C8 File Offset: 0x001F4BC8
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x06007069 RID: 28777 RVA: 0x001F69D0 File Offset: 0x001F4BD0
		private bool __callBase_HasOwnGuild()
		{
			return base.HasOwnGuild();
		}

		// Token: 0x0600706A RID: 28778 RVA: 0x001F69D8 File Offset: 0x001F4BD8
		private void __callBase_QuitGuild(DateTime nextJoinTime)
		{
			base.QuitGuild(nextJoinTime);
		}

		// Token: 0x0600706B RID: 28779 RVA: 0x001F69E4 File Offset: 0x001F4BE4
		private string __callBase_GetGuildId()
		{
			return base.GetGuildId();
		}

		// Token: 0x0600706C RID: 28780 RVA: 0x001F69EC File Offset: 0x001F4BEC
		private void __callBase_SetGuildId(string id)
		{
			base.SetGuildId(id);
		}

		// Token: 0x0600706D RID: 28781 RVA: 0x001F69F8 File Offset: 0x001F4BF8
		private int __callBase_CanCreateGuild(string guildName, string hiringDeclaration, int joinLevel)
		{
			return base.CanCreateGuild(guildName, hiringDeclaration, joinLevel);
		}

		// Token: 0x0600706E RID: 28782 RVA: 0x001F6A04 File Offset: 0x001F4C04
		private int __callBase_CanJoinGuild()
		{
			return base.CanJoinGuild();
		}

		// Token: 0x0600706F RID: 28783 RVA: 0x001F6A0C File Offset: 0x001F4C0C
		private int __callBase_CanQuitGuild()
		{
			return base.CanQuitGuild();
		}

		// Token: 0x06007070 RID: 28784 RVA: 0x001F6A14 File Offset: 0x001F4C14
		private int __callBase_CanKickOutGuild()
		{
			return base.CanKickOutGuild();
		}

		// Token: 0x06007071 RID: 28785 RVA: 0x001F6A1C File Offset: 0x001F4C1C
		private int __callBase_CanApplyToJoinGuild()
		{
			return base.CanApplyToJoinGuild();
		}

		// Token: 0x06007072 RID: 28786 RVA: 0x001F6A24 File Offset: 0x001F4C24
		private int __callBase_CanConfirmJoinGuildInvitation(string guildId)
		{
			return base.CanConfirmJoinGuildInvitation(guildId);
		}

		// Token: 0x06007073 RID: 28787 RVA: 0x001F6A30 File Offset: 0x001F4C30
		private void __callBase_RefuseJoinGuildInvitation(string guildId)
		{
			base.RefuseJoinGuildInvitation(guildId);
		}

		// Token: 0x06007074 RID: 28788 RVA: 0x001F6A3C File Offset: 0x001F4C3C
		private void __callBase_RefuseAllJoinGuildInvitation()
		{
			base.RefuseAllJoinGuildInvitation();
		}

		// Token: 0x06007075 RID: 28789 RVA: 0x001F6A44 File Offset: 0x001F4C44
		private int __callBase_CheckGuildName(string name)
		{
			return base.CheckGuildName(name);
		}

		// Token: 0x06007076 RID: 28790 RVA: 0x001F6A50 File Offset: 0x001F4C50
		private int __callBase_CheckGuildSearch(string searchText)
		{
			return base.CheckGuildSearch(searchText);
		}

		// Token: 0x06007077 RID: 28791 RVA: 0x001F6A5C File Offset: 0x001F4C5C
		private int __callBase_CheckGuildRandomList()
		{
			return base.CheckGuildRandomList();
		}

		// Token: 0x06007078 RID: 28792 RVA: 0x001F6A64 File Offset: 0x001F4C64
		private int __callBase_CheckGuildInvitePlayerList()
		{
			return base.CheckGuildInvitePlayerList();
		}

		// Token: 0x06007079 RID: 28793 RVA: 0x001F6A6C File Offset: 0x001F4C6C
		private int __callBase_CanSetGuildHiringDeclaration(string hiringDeclaration)
		{
			return base.CanSetGuildHiringDeclaration(hiringDeclaration);
		}

		// Token: 0x0600707A RID: 28794 RVA: 0x001F6A78 File Offset: 0x001F4C78
		private int __callBase_CheckGuildHiringDeclaration(string hiringDeclaration)
		{
			return base.CheckGuildHiringDeclaration(hiringDeclaration);
		}

		// Token: 0x0600707B RID: 28795 RVA: 0x001F6A84 File Offset: 0x001F4C84
		private int __callBase_CanSetGuildAnnouncement(string announcement)
		{
			return base.CanSetGuildAnnouncement(announcement);
		}

		// Token: 0x0600707C RID: 28796 RVA: 0x001F6A90 File Offset: 0x001F4C90
		private int __callBase_CheckGuildAnnouncement(string announcement)
		{
			return base.CheckGuildAnnouncement(announcement);
		}

		// Token: 0x0600707D RID: 28797 RVA: 0x001F6A9C File Offset: 0x001F4C9C
		private int __callBase_CanStartMassiveCombat()
		{
			return base.CanStartMassiveCombat();
		}

		// Token: 0x0600707E RID: 28798 RVA: 0x001F6AA4 File Offset: 0x001F4CA4
		private int __callBase_CanTheseHeroesAttackStronghold(List<int> heroIds)
		{
			return base.CanTheseHeroesAttackStronghold(heroIds);
		}

		// Token: 0x0600707F RID: 28799 RVA: 0x001F6AB0 File Offset: 0x001F4CB0
		private int __callBase_CanAttackStronghold(int levelId)
		{
			return base.CanAttackStronghold(levelId);
		}

		// Token: 0x06007080 RID: 28800 RVA: 0x001F6ABC File Offset: 0x001F4CBC
		private List<Hero> __callBase_GetMassiveCombatUnusedHeroes()
		{
			return base.GetMassiveCombatUnusedHeroes();
		}

		// Token: 0x06007081 RID: 28801 RVA: 0x001F6AC4 File Offset: 0x001F4CC4
		private int __callBase_GetEliminateRate(GuildMassiveCombatInfo combat)
		{
			return base.GetEliminateRate(combat);
		}

		// Token: 0x06007082 RID: 28802 RVA: 0x001F6AD0 File Offset: 0x001F4CD0
		private int __callBase_GetStrongholdEliminateRate(GuildMassiveCombatStronghold stronghold)
		{
			return base.GetStrongholdEliminateRate(stronghold);
		}

		// Token: 0x06007083 RID: 28803 RVA: 0x001F6ADC File Offset: 0x001F4CDC
		private int __callBase_GetStartedCombatThisWeek(GuildMassiveCombatGeneral generalInfo)
		{
			return base.GetStartedCombatThisWeek(generalInfo);
		}

		// Token: 0x06007084 RID: 28804 RVA: 0x001F6AE8 File Offset: 0x001F4CE8
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
					this.m_GetGuildLogContentGuildLog_hotfix = (luaObj.RawGet("GetGuildLogContent") as LuaFunction);
					this.m_SetGuildDataSectionDSGuildNtf_hotfix = (luaObj.RawGet("SetGuildDataSection") as LuaFunction);
					this.m_RefreshGuildProGuild_hotfix = (luaObj.RawGet("RefreshGuild") as LuaFunction);
					this.m_RefreshGuildListJoinStateStringBoolean_hotfix = (luaObj.RawGet("RefreshGuildListJoinState") as LuaFunction);
					this.m_PlayerRefuseGuildString_hotfix = (luaObj.RawGet("PlayerRefuseGuild") as LuaFunction);
					this.m_ResetGuild_hotfix = (luaObj.RawGet("ResetGuild") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06007085 RID: 28805 RVA: 0x001F6C64 File Offset: 0x001F4E64
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040054E9 RID: 21737
		public Guild m_guild;

		// Token: 0x040054EA RID: 21738
		public List<string> m_guildInviteUserIdList = new List<string>();

		// Token: 0x040054EB RID: 21739
		public List<GuildSearchInfo> m_guildSearchList = new List<GuildSearchInfo>();

		// Token: 0x040054EC RID: 21740
		public List<GuildSearchInfo> m_guildRecommendList;

		// Token: 0x040054ED RID: 21741
		public List<GuildJoinInvitation> m_guildJoinInvitationList = new List<GuildJoinInvitation>();

		// Token: 0x040054EE RID: 21742
		public List<UserSummary> m_guildJoinApplyList = new List<UserSummary>();

		// Token: 0x040054EF RID: 21743
		[DoNotToLua]
		private GuildComponent.LuaExportHelper luaExportHelper;

		// Token: 0x040054F0 RID: 21744
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040054F1 RID: 21745
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040054F2 RID: 21746
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040054F3 RID: 21747
		private LuaFunction m_Init_hotfix;

		// Token: 0x040054F4 RID: 21748
		private LuaFunction m_GetGuildLogContentGuildLog_hotfix;

		// Token: 0x040054F5 RID: 21749
		private LuaFunction m_SetGuildDataSectionDSGuildNtf_hotfix;

		// Token: 0x040054F6 RID: 21750
		private LuaFunction m_RefreshGuildProGuild_hotfix;

		// Token: 0x040054F7 RID: 21751
		private LuaFunction m_RefreshGuildListJoinStateStringBoolean_hotfix;

		// Token: 0x040054F8 RID: 21752
		private LuaFunction m_PlayerRefuseGuildString_hotfix;

		// Token: 0x040054F9 RID: 21753
		private LuaFunction m_ResetGuild_hotfix;

		// Token: 0x020008B9 RID: 2233
		public new class LuaExportHelper
		{
			// Token: 0x06007086 RID: 28806 RVA: 0x001F6CCC File Offset: 0x001F4ECC
			public LuaExportHelper(GuildComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06007087 RID: 28807 RVA: 0x001F6CDC File Offset: 0x001F4EDC
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x06007088 RID: 28808 RVA: 0x001F6CEC File Offset: 0x001F4EEC
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x06007089 RID: 28809 RVA: 0x001F6CFC File Offset: 0x001F4EFC
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x0600708A RID: 28810 RVA: 0x001F6D0C File Offset: 0x001F4F0C
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x0600708B RID: 28811 RVA: 0x001F6D1C File Offset: 0x001F4F1C
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x0600708C RID: 28812 RVA: 0x001F6D2C File Offset: 0x001F4F2C
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x0600708D RID: 28813 RVA: 0x001F6D3C File Offset: 0x001F4F3C
			public bool __callBase_HasOwnGuild()
			{
				return this.m_owner.__callBase_HasOwnGuild();
			}

			// Token: 0x0600708E RID: 28814 RVA: 0x001F6D4C File Offset: 0x001F4F4C
			public void __callBase_QuitGuild(DateTime nextJoinTime)
			{
				this.m_owner.__callBase_QuitGuild(nextJoinTime);
			}

			// Token: 0x0600708F RID: 28815 RVA: 0x001F6D5C File Offset: 0x001F4F5C
			public string __callBase_GetGuildId()
			{
				return this.m_owner.__callBase_GetGuildId();
			}

			// Token: 0x06007090 RID: 28816 RVA: 0x001F6D6C File Offset: 0x001F4F6C
			public void __callBase_SetGuildId(string id)
			{
				this.m_owner.__callBase_SetGuildId(id);
			}

			// Token: 0x06007091 RID: 28817 RVA: 0x001F6D7C File Offset: 0x001F4F7C
			public int __callBase_CanCreateGuild(string guildName, string hiringDeclaration, int joinLevel)
			{
				return this.m_owner.__callBase_CanCreateGuild(guildName, hiringDeclaration, joinLevel);
			}

			// Token: 0x06007092 RID: 28818 RVA: 0x001F6D8C File Offset: 0x001F4F8C
			public int __callBase_CanJoinGuild()
			{
				return this.m_owner.__callBase_CanJoinGuild();
			}

			// Token: 0x06007093 RID: 28819 RVA: 0x001F6D9C File Offset: 0x001F4F9C
			public int __callBase_CanQuitGuild()
			{
				return this.m_owner.__callBase_CanQuitGuild();
			}

			// Token: 0x06007094 RID: 28820 RVA: 0x001F6DAC File Offset: 0x001F4FAC
			public int __callBase_CanKickOutGuild()
			{
				return this.m_owner.__callBase_CanKickOutGuild();
			}

			// Token: 0x06007095 RID: 28821 RVA: 0x001F6DBC File Offset: 0x001F4FBC
			public int __callBase_CanApplyToJoinGuild()
			{
				return this.m_owner.__callBase_CanApplyToJoinGuild();
			}

			// Token: 0x06007096 RID: 28822 RVA: 0x001F6DCC File Offset: 0x001F4FCC
			public int __callBase_CanConfirmJoinGuildInvitation(string guildId)
			{
				return this.m_owner.__callBase_CanConfirmJoinGuildInvitation(guildId);
			}

			// Token: 0x06007097 RID: 28823 RVA: 0x001F6DDC File Offset: 0x001F4FDC
			public void __callBase_RefuseJoinGuildInvitation(string guildId)
			{
				this.m_owner.__callBase_RefuseJoinGuildInvitation(guildId);
			}

			// Token: 0x06007098 RID: 28824 RVA: 0x001F6DEC File Offset: 0x001F4FEC
			public void __callBase_RefuseAllJoinGuildInvitation()
			{
				this.m_owner.__callBase_RefuseAllJoinGuildInvitation();
			}

			// Token: 0x06007099 RID: 28825 RVA: 0x001F6DFC File Offset: 0x001F4FFC
			public int __callBase_CheckGuildName(string name)
			{
				return this.m_owner.__callBase_CheckGuildName(name);
			}

			// Token: 0x0600709A RID: 28826 RVA: 0x001F6E0C File Offset: 0x001F500C
			public int __callBase_CheckGuildSearch(string searchText)
			{
				return this.m_owner.__callBase_CheckGuildSearch(searchText);
			}

			// Token: 0x0600709B RID: 28827 RVA: 0x001F6E1C File Offset: 0x001F501C
			public int __callBase_CheckGuildRandomList()
			{
				return this.m_owner.__callBase_CheckGuildRandomList();
			}

			// Token: 0x0600709C RID: 28828 RVA: 0x001F6E2C File Offset: 0x001F502C
			public int __callBase_CheckGuildInvitePlayerList()
			{
				return this.m_owner.__callBase_CheckGuildInvitePlayerList();
			}

			// Token: 0x0600709D RID: 28829 RVA: 0x001F6E3C File Offset: 0x001F503C
			public int __callBase_CanSetGuildHiringDeclaration(string hiringDeclaration)
			{
				return this.m_owner.__callBase_CanSetGuildHiringDeclaration(hiringDeclaration);
			}

			// Token: 0x0600709E RID: 28830 RVA: 0x001F6E4C File Offset: 0x001F504C
			public int __callBase_CheckGuildHiringDeclaration(string hiringDeclaration)
			{
				return this.m_owner.__callBase_CheckGuildHiringDeclaration(hiringDeclaration);
			}

			// Token: 0x0600709F RID: 28831 RVA: 0x001F6E5C File Offset: 0x001F505C
			public int __callBase_CanSetGuildAnnouncement(string announcement)
			{
				return this.m_owner.__callBase_CanSetGuildAnnouncement(announcement);
			}

			// Token: 0x060070A0 RID: 28832 RVA: 0x001F6E6C File Offset: 0x001F506C
			public int __callBase_CheckGuildAnnouncement(string announcement)
			{
				return this.m_owner.__callBase_CheckGuildAnnouncement(announcement);
			}

			// Token: 0x060070A1 RID: 28833 RVA: 0x001F6E7C File Offset: 0x001F507C
			public int __callBase_CanStartMassiveCombat()
			{
				return this.m_owner.__callBase_CanStartMassiveCombat();
			}

			// Token: 0x060070A2 RID: 28834 RVA: 0x001F6E8C File Offset: 0x001F508C
			public int __callBase_CanTheseHeroesAttackStronghold(List<int> heroIds)
			{
				return this.m_owner.__callBase_CanTheseHeroesAttackStronghold(heroIds);
			}

			// Token: 0x060070A3 RID: 28835 RVA: 0x001F6E9C File Offset: 0x001F509C
			public int __callBase_CanAttackStronghold(int levelId)
			{
				return this.m_owner.__callBase_CanAttackStronghold(levelId);
			}

			// Token: 0x060070A4 RID: 28836 RVA: 0x001F6EAC File Offset: 0x001F50AC
			public List<Hero> __callBase_GetMassiveCombatUnusedHeroes()
			{
				return this.m_owner.__callBase_GetMassiveCombatUnusedHeroes();
			}

			// Token: 0x060070A5 RID: 28837 RVA: 0x001F6EBC File Offset: 0x001F50BC
			public int __callBase_GetEliminateRate(GuildMassiveCombatInfo combat)
			{
				return this.m_owner.__callBase_GetEliminateRate(combat);
			}

			// Token: 0x060070A6 RID: 28838 RVA: 0x001F6ECC File Offset: 0x001F50CC
			public int __callBase_GetStrongholdEliminateRate(GuildMassiveCombatStronghold stronghold)
			{
				return this.m_owner.__callBase_GetStrongholdEliminateRate(stronghold);
			}

			// Token: 0x060070A7 RID: 28839 RVA: 0x001F6EDC File Offset: 0x001F50DC
			public int __callBase_GetStartedCombatThisWeek(GuildMassiveCombatGeneral generalInfo)
			{
				return this.m_owner.__callBase_GetStartedCombatThisWeek(generalInfo);
			}

			// Token: 0x040054FA RID: 21754
			private GuildComponent m_owner;
		}
	}
}
