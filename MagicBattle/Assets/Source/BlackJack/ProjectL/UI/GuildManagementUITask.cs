using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D06 RID: 3334
	[HotFix]
	public class GuildManagementUITask : UITask
	{
		// Token: 0x0600F5EB RID: 62955 RVA: 0x00410618 File Offset: 0x0040E818
		public GuildManagementUITask(string name) : base(name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctorString_hotfix != null)
			{
				this.m_ctorString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600F5EC RID: 62956 RVA: 0x0041070C File Offset: 0x0040E90C
		public static GuildManagementUITask StartUITask(string guildId = null, UIIntent intent = null)
		{
			GuildManagementUITask.m_guildId = guildId;
			UIIntentReturnable uiintentReturnable = new UIIntentReturnable(intent, typeof(GuildManagementUITask).Name, null);
			UIManager instance = UIManager.Instance;
			UIIntent intent2 = uiintentReturnable;
			bool pushIntentToStack = true;
			bool clearIntentStack = false;
			if (GuildManagementUITask.<>f__mg$cache0 == null)
			{
				GuildManagementUITask.<>f__mg$cache0 = new Action(GuildManagementUITask.GuildManagementUITask_OnLoadAllResCompleted);
			}
			return instance.StartUITask(intent2, pushIntentToStack, clearIntentStack, GuildManagementUITask.<>f__mg$cache0) as GuildManagementUITask;
		}

		// Token: 0x0600F5ED RID: 62957 RVA: 0x00410768 File Offset: 0x0040E968
		public static void GuildManagementUITask_OnLoadAllResCompleted()
		{
			ProjectLPlayerContext playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (GuildManagementUITask.m_guildId == null)
			{
				GuildManagementUITask.m_guildId = playerContext.GetGuildId();
			}
			GuildGetReqNetTask guildGetReqNetTask = new GuildGetReqNetTask(GuildManagementUITask.m_guildId);
			guildGetReqNetTask.EventOnStop += delegate(Task task)
			{
				GuildGetReqNetTask guildGetReqNetTask2 = task as GuildGetReqNetTask;
				if (guildGetReqNetTask2.Result != 0)
				{
					CommonUIController.Instance.ShowErrorMessage(guildGetReqNetTask2.Result, 2f, null, true);
					UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(GuildManagementUITask));
					if (uitaskBase != null)
					{
						uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
					}
					return;
				}
				GuildManagementUITask.m_guild = guildGetReqNetTask2.GuildInfo;
				GuildMemberCacheObject guildMemberCacheObject = GuildManagementUITask.m_guild.FindMember(playerContext.GetUserId());
				if (guildMemberCacheObject == null)
				{
					UITaskBase uitaskBase2 = UIUtility.FindUITaskWithType(typeof(GuildManagementUITask));
					if (uitaskBase2 != null)
					{
						uitaskBase2.ReturnFromRedirectPipLineOnLoadAllResCompleted();
					}
					return;
				}
				GuildTitle title = guildMemberCacheObject.Member.Title;
				if (title == GuildTitle.President || title == GuildTitle.VP)
				{
					GuildJoinApplyGetReqNetTask guildJoinApplyGetReqNetTask = new GuildJoinApplyGetReqNetTask();
					guildJoinApplyGetReqNetTask.EventOnStop += delegate(Task task2)
					{
						UITaskBase uitaskBase4 = UIUtility.FindUITaskWithType(typeof(GuildManagementUITask));
						if (uitaskBase4 != null)
						{
							uitaskBase4.ReturnFromRedirectPipLineOnLoadAllResCompleted();
						}
						GuildJoinApplyGetReqNetTask guildJoinApplyGetReqNetTask2 = task2 as GuildJoinApplyGetReqNetTask;
						if (guildJoinApplyGetReqNetTask2.Result != 0)
						{
							CommonUIController.Instance.ShowErrorMessage(guildJoinApplyGetReqNetTask2.Result, 2f, null, true);
						}
					};
					guildJoinApplyGetReqNetTask.Start(null);
				}
				else
				{
					UITaskBase uitaskBase3 = UIUtility.FindUITaskWithType(typeof(GuildManagementUITask));
					if (uitaskBase3 != null)
					{
						uitaskBase3.ReturnFromRedirectPipLineOnLoadAllResCompleted();
					}
				}
			};
			guildGetReqNetTask.Start(null);
		}

		// Token: 0x0600F5EE RID: 62958 RVA: 0x004107D0 File Offset: 0x0040E9D0
		protected override bool IsNeedLoadDynamicRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedLoadDynamicRes_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedLoadDynamicRes_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearAssetList();
			return this.m_assets.Count > 0;
		}

		// Token: 0x0600F5EF RID: 62959 RVA: 0x00410850 File Offset: 0x0040EA50
		protected override void InitAllUIControllers()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitAllUIControllers_hotfix != null)
			{
				this.m_InitAllUIControllers_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.InitAllUIControllers();
			if (this.m_guildManagementUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_guildManagementUIController = (this.m_uiCtrlArray[0] as GuildManagementUIController);
				}
				if (this.m_guildManagementUIController != null)
				{
					this.m_guildManagementUIController.EventOnClose += this.GuildManagementUIController_OnClose;
					this.m_guildManagementUIController.EventOnQuitGuild += this.GuildManagementUIController_OnQuitGuild;
					this.m_guildManagementUIController.EventOnGetCanInvitePlayerList += this.GuildManagementUIController_OnGetCanInvitePlayerList;
					this.m_guildManagementUIController.EventOnGuildHiringDeclarationSet += this.GuildManagementUIController_OnGuildHiringDeclarationSet;
					this.m_guildManagementUIController.EventOnGuildInfoSet += this.GuildManagementUIController_OnGuildInfoSet;
					this.m_guildManagementUIController.EventOnGuildAnnouncementSet += this.GuildManagementUIController_OnGuildAnnouncementSet;
					this.m_guildManagementUIController.EventOnGetGuildJoinApply += this.GuildManagementUIController_OnGetGuildJoinApply;
					this.m_guildManagementUIController.EventOnGuildJoinConfirmOrRefuse += this.GuildManagementUIController_OnGuildJoinConfirmOrRefuse;
					this.m_guildManagementUIController.EventOnChangeGuildName += this.GuildManagementUIController_OnChangeGuildName;
					this.m_guildManagementUIController.EventOnGetGuildJournal += this.GuildManagementUIController_OnGetGuildJournal;
					this.m_guildManagementUIController.EventOnGuildInviteMember += this.GuildManagementUIController_OnGuildInviteMember;
					this.m_guildManagementUIController.EventOnGuildMemberClick += this.GuildManagementUIController_OnGuildMemberClick;
					this.m_guildManagementUIController.EventOnAllRefuseButtonClick += this.GuildManagementUIController_OnAllRefuseButtonClick;
					this.m_guildManagementUIController.EventOnGotoGuildStore += this.GuildManagementUIController_OnGotoGuildStore;
					this.m_guildManagementUIController.EventOnGotoGuildGameListPanel += this.GuildManagementUIController_OnGotoGuildGameListPanel;
				}
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGuildUpdateInfo += this.PlayerContext_EventOnGuildUpdateInfo;
		}

		// Token: 0x0600F5F0 RID: 62960 RVA: 0x00410A74 File Offset: 0x0040EC74
		protected override void ClearAllContextAndRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearAllContextAndRes_hotfix != null)
			{
				this.m_ClearAllContextAndRes_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearAllContextAndRes();
			if (this.m_guildManagementUIController != null)
			{
				this.m_guildManagementUIController.EventOnClose -= this.GuildManagementUIController_OnClose;
				this.m_guildManagementUIController.EventOnQuitGuild -= this.GuildManagementUIController_OnQuitGuild;
				this.m_guildManagementUIController.EventOnGetCanInvitePlayerList -= this.GuildManagementUIController_OnGetCanInvitePlayerList;
				this.m_guildManagementUIController.EventOnGuildHiringDeclarationSet -= this.GuildManagementUIController_OnGuildHiringDeclarationSet;
				this.m_guildManagementUIController.EventOnGuildInfoSet -= this.GuildManagementUIController_OnGuildInfoSet;
				this.m_guildManagementUIController.EventOnGuildAnnouncementSet -= this.GuildManagementUIController_OnGuildAnnouncementSet;
				this.m_guildManagementUIController.EventOnGetGuildJoinApply -= this.GuildManagementUIController_OnGetGuildJoinApply;
				this.m_guildManagementUIController.EventOnGuildJoinConfirmOrRefuse -= this.GuildManagementUIController_OnGuildJoinConfirmOrRefuse;
				this.m_guildManagementUIController.EventOnChangeGuildName -= this.GuildManagementUIController_OnChangeGuildName;
				this.m_guildManagementUIController.EventOnGetGuildJournal -= this.GuildManagementUIController_OnGetGuildJournal;
				this.m_guildManagementUIController.EventOnGuildInviteMember -= this.GuildManagementUIController_OnGuildInviteMember;
				this.m_guildManagementUIController.EventOnGuildMemberClick -= this.GuildManagementUIController_OnGuildMemberClick;
				this.m_guildManagementUIController.EventOnAllRefuseButtonClick -= this.GuildManagementUIController_OnAllRefuseButtonClick;
				this.m_guildManagementUIController.EventOnGotoGuildStore -= this.GuildManagementUIController_OnGotoGuildStore;
				this.m_guildManagementUIController.EventOnGotoGuildGameListPanel -= this.GuildManagementUIController_OnGotoGuildGameListPanel;
				this.m_guildManagementUIController = null;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGuildUpdateInfo -= this.PlayerContext_EventOnGuildUpdateInfo;
			}
		}

		// Token: 0x0600F5F1 RID: 62961 RVA: 0x00410C74 File Offset: 0x0040EE74
		protected override bool OnStart(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnStartUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.InitDataFromUIIntent(intent);
			return base.OnStart(intent);
		}

		// Token: 0x0600F5F2 RID: 62962 RVA: 0x00410D00 File Offset: 0x0040EF00
		protected override bool OnResume(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnResumeUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnResumeUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.InitDataFromUIIntent(intent);
			return base.OnResume(intent);
		}

		// Token: 0x0600F5F3 RID: 62963 RVA: 0x00410D8C File Offset: 0x0040EF8C
		private void InitDataFromUIIntent(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitDataFromUIIntentUIIntent_hotfix != null)
			{
				this.m_InitDataFromUIIntentUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentCustom uiintentCustom = intent as UIIntentCustom;
			if (uiintentCustom != null)
			{
			}
		}

		// Token: 0x0600F5F4 RID: 62964 RVA: 0x00410E0C File Offset: 0x0040F00C
		protected override void UpdateView()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateView_hotfix != null)
			{
				this.m_UpdateView_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (base.IsOpeningUI())
			{
				this.m_guildManagementUIController.Open();
			}
			this.m_guildManagementUIController.UpdateView(GuildManagementUITask.m_guild);
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			this.m_guildManagementUIController.SetMessageRedPoint(projectLPlayerContext.GetGuildJoinApplyList().Count > 0);
		}

		// Token: 0x0600F5F5 RID: 62965 RVA: 0x00410EBC File Offset: 0x0040F0BC
		protected override void PostUpdateView()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostUpdateView_hotfix != null)
			{
				this.m_PostUpdateView_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentCustom uiintentCustom = this.m_currIntent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				bool structParam = uiintentCustom.GetStructParam<bool>("GoToGuildMassiveCombat");
				uiintentCustom.SetParam("GoToGuildMassiveCombat", false);
				if (structParam)
				{
					UIIntentReturnable uiintentReturnable = new UIIntentReturnable(this.m_currIntent, typeof(GuildGameListUITask).Name, null);
					uiintentReturnable.SetParam("GoToGuildMassiveCombat", true);
					UIManager.Instance.StartUITask(uiintentReturnable, true, false, new Action(this.GuildGameListUITask_OnLoadAllResCompleted));
					this.GuildManagementUIController_OnGotoGuildGameListPanel();
				}
			}
			base.PostUpdateView();
		}

		// Token: 0x0600F5F6 RID: 62966 RVA: 0x00410FA4 File Offset: 0x0040F1A4
		private void GuildManagementUIController_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GuildManagementUIController_OnClose_hotfix != null)
			{
				this.m_GuildManagementUIController_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
				GuildManagementUITask.m_guildId = null;
				base.Pause();
				base.ReturnPrevUITask();
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600F5F7 RID: 62967 RVA: 0x00411028 File Offset: 0x0040F228
		private void PlayerContext_EventOnGuildUpdateInfo(GuildLog log)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_EventOnGuildUpdateInfoGuildLog_hotfix != null)
			{
				this.m_PlayerContext_EventOnGuildUpdateInfoGuildLog_hotfix.call(new object[]
				{
					this,
					log
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (log.ModeId)
			{
			case 20011:
				this.m_guildManagementUIController.Close();
				this.GuildManagementUIController_OnClose();
				break;
			case 20012:
			case 20013:
			case 20014:
			case 20015:
				this.UpdateView();
				break;
			}
		}

		// Token: 0x0600F5F8 RID: 62968 RVA: 0x004110EC File Offset: 0x0040F2EC
		private void GuildManagementUIController_OnQuitGuild(Action OnSucceed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GuildManagementUIController_OnQuitGuildAction_hotfix != null)
			{
				this.m_GuildManagementUIController_OnQuitGuildAction_hotfix.call(new object[]
				{
					this,
					OnSucceed2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action OnSucceed = OnSucceed2;
			GuildManagementUITask $this = this;
			GuildQuitReqNetTask guildQuitReqNetTask = new GuildQuitReqNetTask();
			guildQuitReqNetTask.EventOnStop += delegate(Task task)
			{
				GuildQuitReqNetTask guildQuitReqNetTask2 = task as GuildQuitReqNetTask;
				if (guildQuitReqNetTask2.Result == 0)
				{
					OnSucceed();
					$this.GuildManagementUIController_OnClose();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(guildQuitReqNetTask2.Result, 2f, null, true);
				}
			};
			guildQuitReqNetTask.Start(null);
		}

		// Token: 0x0600F5F9 RID: 62969 RVA: 0x00411190 File Offset: 0x0040F390
		private void GuildManagementUIController_OnGetCanInvitePlayerList(Action<List<UserSummary>> OnSucceed, bool isShowSucceedTip)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GuildManagementUIController_OnGetCanInvitePlayerListAction`1Boolean_hotfix != null)
			{
				this.m_GuildManagementUIController_OnGetCanInvitePlayerListAction`1Boolean_hotfix.call(new object[]
				{
					this,
					OnSucceed2,
					isShowSucceedTip2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action<List<UserSummary>> OnSucceed = OnSucceed2;
			bool isShowSucceedTip = isShowSucceedTip2;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CheckGuildInvitePlayerList();
			if (num != 0)
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
				return;
			}
			GuildInvitePlayerListReqNetTask guildInvitePlayerListReqNetTask = new GuildInvitePlayerListReqNetTask();
			guildInvitePlayerListReqNetTask.EventOnStop += delegate(Task task)
			{
				GuildInvitePlayerListReqNetTask guildInvitePlayerListReqNetTask2 = task as GuildInvitePlayerListReqNetTask;
				if (guildInvitePlayerListReqNetTask2.Result == 0)
				{
					OnSucceed(guildInvitePlayerListReqNetTask2.PlayerList);
					if (isShowSucceedTip)
					{
						IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
						string txt = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Guild_RefreshGuildSuccess);
						CommonUIController.Instance.ShowTip(txt);
					}
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(guildInvitePlayerListReqNetTask2.Result, 2f, null, true);
				}
			};
			guildInvitePlayerListReqNetTask.Start(null);
		}

		// Token: 0x0600F5FA RID: 62970 RVA: 0x00411274 File Offset: 0x0040F474
		private void GuildManagementUIController_OnGuildHiringDeclarationSet(string hiringDeclaration, Action OnSucceed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GuildManagementUIController_OnGuildHiringDeclarationSetStringAction_hotfix != null)
			{
				this.m_GuildManagementUIController_OnGuildHiringDeclarationSetStringAction_hotfix.call(new object[]
				{
					this,
					hiringDeclaration,
					OnSucceed2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action OnSucceed = OnSucceed2;
			GuildHiringDeclarationSetReqNetTask guildHiringDeclarationSetReqNetTask = new GuildHiringDeclarationSetReqNetTask(hiringDeclaration);
			guildHiringDeclarationSetReqNetTask.EventOnStop += delegate(Task task)
			{
				GuildHiringDeclarationSetReqNetTask guildHiringDeclarationSetReqNetTask2 = task as GuildHiringDeclarationSetReqNetTask;
				if (guildHiringDeclarationSetReqNetTask2.Result == 0)
				{
					OnSucceed();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(guildHiringDeclarationSetReqNetTask2.Result, 2f, null, true);
				}
			};
			guildHiringDeclarationSetReqNetTask.Start(null);
		}

		// Token: 0x0600F5FB RID: 62971 RVA: 0x00411324 File Offset: 0x0040F524
		private void GuildManagementUIController_OnGuildInfoSet(bool autoJoin, int joinLevel, string announcement, Action OnSucceed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GuildManagementUIController_OnGuildInfoSetBooleanInt32StringAction_hotfix != null)
			{
				this.m_GuildManagementUIController_OnGuildInfoSetBooleanInt32StringAction_hotfix.call(new object[]
				{
					this,
					autoJoin,
					joinLevel,
					announcement,
					OnSucceed2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action OnSucceed = OnSucceed2;
			GuildInfoSetReqNetTask guildInfoSetReqNetTask = new GuildInfoSetReqNetTask(autoJoin, joinLevel, announcement);
			guildInfoSetReqNetTask.EventOnStop += delegate(Task task)
			{
				GuildInfoSetReqNetTask guildInfoSetReqNetTask2 = task as GuildInfoSetReqNetTask;
				if (guildInfoSetReqNetTask2.Result == 0)
				{
					OnSucceed();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(guildInfoSetReqNetTask2.Result, 2f, null, true);
				}
			};
			guildInfoSetReqNetTask.Start(null);
		}

		// Token: 0x0600F5FC RID: 62972 RVA: 0x004113F8 File Offset: 0x0040F5F8
		private void GuildManagementUIController_OnGuildAnnouncementSet(string announcement, Action OnSucceed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GuildManagementUIController_OnGuildAnnouncementSetStringAction_hotfix != null)
			{
				this.m_GuildManagementUIController_OnGuildAnnouncementSetStringAction_hotfix.call(new object[]
				{
					this,
					announcement,
					OnSucceed2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action OnSucceed = OnSucceed2;
			GuildAnnouncementSetReqNetTask guildAnnouncementSetReqNetTask = new GuildAnnouncementSetReqNetTask(announcement);
			guildAnnouncementSetReqNetTask.EventOnStop += delegate(Task task)
			{
				GuildAnnouncementSetReqNetTask guildAnnouncementSetReqNetTask2 = task as GuildAnnouncementSetReqNetTask;
				if (guildAnnouncementSetReqNetTask2.Result == 0)
				{
					OnSucceed();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(guildAnnouncementSetReqNetTask2.Result, 2f, null, true);
				}
			};
			guildAnnouncementSetReqNetTask.Start(null);
		}

		// Token: 0x0600F5FD RID: 62973 RVA: 0x004114A8 File Offset: 0x0040F6A8
		private void GuildManagementUIController_OnGetGuildJoinApply(Action<List<UserSummary>> OnSucceed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GuildManagementUIController_OnGetGuildJoinApplyAction`1_hotfix != null)
			{
				this.m_GuildManagementUIController_OnGetGuildJoinApplyAction`1_hotfix.call(new object[]
				{
					this,
					OnSucceed2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action<List<UserSummary>> OnSucceed = OnSucceed2;
			GuildManagementUITask $this = this;
			GuildJoinApplyGetReqNetTask guildJoinApplyGetReqNetTask = new GuildJoinApplyGetReqNetTask();
			guildJoinApplyGetReqNetTask.EventOnStop += delegate(Task task)
			{
				GuildJoinApplyGetReqNetTask guildJoinApplyGetReqNetTask2 = task as GuildJoinApplyGetReqNetTask;
				if (guildJoinApplyGetReqNetTask2.Result == 0)
				{
					ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
					$this.m_guildManagementUIController.SetMessageRedPoint(projectLPlayerContext.GetGuildJoinApplyList().Count > 0);
					List<UserSummary> list = new List<UserSummary>(guildJoinApplyGetReqNetTask2.Players);
					list.Reverse();
					OnSucceed(list);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(guildJoinApplyGetReqNetTask2.Result, 2f, null, true);
				}
			};
			guildJoinApplyGetReqNetTask.Start(null);
		}

		// Token: 0x0600F5FE RID: 62974 RVA: 0x0041154C File Offset: 0x0040F74C
		private void GuildManagementUIController_OnGuildJoinConfirmOrRefuse(string userId, bool isAccept, Action OnEnd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GuildManagementUIController_OnGuildJoinConfirmOrRefuseStringBooleanAction_hotfix != null)
			{
				this.m_GuildManagementUIController_OnGuildJoinConfirmOrRefuseStringBooleanAction_hotfix.call(new object[]
				{
					this,
					userId,
					isAccept,
					OnEnd2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action OnEnd = OnEnd2;
			GuildManagementUITask $this = this;
			ProjectLPlayerContext playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (isAccept)
			{
				Guild guildInfo = playerContext.GetGuildInfo();
				if (guildInfo.IsMemberFull)
				{
					CommonUIController.Instance.ShowErrorMessage(-5224, 2f, null, true);
					return;
				}
				GuildJoinAdminConfirmReqNetTask guildJoinAdminConfirmReqNetTask = new GuildJoinAdminConfirmReqNetTask(userId);
				guildJoinAdminConfirmReqNetTask.EventOnStop += delegate(Task task)
				{
					GuildJoinAdminConfirmReqNetTask guildJoinAdminConfirmReqNetTask2 = task as GuildJoinAdminConfirmReqNetTask;
					if (guildJoinAdminConfirmReqNetTask2.Result != 0)
					{
						CommonUIController.Instance.ShowErrorMessage(guildJoinAdminConfirmReqNetTask2.Result, 2f, null, true);
					}
					$this.m_guildManagementUIController.SetMessageRedPoint(playerContext.GetGuildJoinApplyList().Count > 0);
					OnEnd();
				};
				guildJoinAdminConfirmReqNetTask.Start(null);
			}
			else
			{
				GuildJoinAdminRefuseReqNetTask guildJoinAdminRefuseReqNetTask = new GuildJoinAdminRefuseReqNetTask(userId);
				guildJoinAdminRefuseReqNetTask.EventOnStop += delegate(Task task)
				{
					GuildJoinAdminRefuseReqNetTask guildJoinAdminRefuseReqNetTask2 = task as GuildJoinAdminRefuseReqNetTask;
					if (guildJoinAdminRefuseReqNetTask2.Result != 0)
					{
						CommonUIController.Instance.ShowErrorMessage(guildJoinAdminRefuseReqNetTask2.Result, 2f, null, true);
					}
					$this.m_guildManagementUIController.SetMessageRedPoint(playerContext.GetGuildJoinApplyList().Count > 0);
					OnEnd();
				};
				guildJoinAdminRefuseReqNetTask.Start(null);
			}
		}

		// Token: 0x0600F5FF RID: 62975 RVA: 0x00411680 File Offset: 0x0040F880
		private void GuildManagementUIController_OnChangeGuildName(string name, Action OnSucceed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GuildManagementUIController_OnChangeGuildNameStringAction_hotfix != null)
			{
				this.m_GuildManagementUIController_OnChangeGuildNameStringAction_hotfix.call(new object[]
				{
					this,
					name,
					OnSucceed2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action OnSucceed = OnSucceed2;
			GuildManagementUITask $this = this;
			GuildNameChangeReqNetTask guildNameChangeReqNetTask = new GuildNameChangeReqNetTask(name);
			guildNameChangeReqNetTask.EventOnStop += delegate(Task task)
			{
				GuildNameChangeReqNetTask guildNameChangeReqNetTask2 = task as GuildNameChangeReqNetTask;
				if (guildNameChangeReqNetTask2.Result == 0)
				{
					OnSucceed();
				}
				else if (guildNameChangeReqNetTask2.Result == -401)
				{
					CommonUIController.Instance.ShowDialogBox(StringTableId.StringTableId_Msg_CrystalNotEnough, delegate(DialogBoxResult dialogResult)
					{
						if (dialogResult == DialogBoxResult.Ok)
						{
							StoreUITask.StartUITask($this.m_currIntent, StoreId.StoreId_Recharge, null, false);
						}
					}, (StringTableId)0, (StringTableId)0);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(guildNameChangeReqNetTask2.Result, 2f, null, true);
				}
			};
			guildNameChangeReqNetTask.Start(null);
		}

		// Token: 0x0600F600 RID: 62976 RVA: 0x00411738 File Offset: 0x0040F938
		private void GuildManagementUIController_OnGetGuildJournal(Action<List<GuildLog>> OnSucceed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GuildManagementUIController_OnGetGuildJournalAction`1_hotfix != null)
			{
				this.m_GuildManagementUIController_OnGetGuildJournalAction`1_hotfix.call(new object[]
				{
					this,
					OnSucceed2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action<List<GuildLog>> OnSucceed = OnSucceed2;
			GuildLogGetReqNetTask guildLogGetReqNetTask = new GuildLogGetReqNetTask();
			guildLogGetReqNetTask.EventOnStop += delegate(Task task)
			{
				GuildLogGetReqNetTask guildLogGetReqNetTask2 = task as GuildLogGetReqNetTask;
				if (guildLogGetReqNetTask2.Result == 0)
				{
					OnSucceed(guildLogGetReqNetTask2.GuildLogs);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(guildLogGetReqNetTask2.Result, 2f, null, true);
				}
			};
			guildLogGetReqNetTask.Start(null);
		}

		// Token: 0x0600F601 RID: 62977 RVA: 0x004117D8 File Offset: 0x0040F9D8
		private void GuildManagementUIController_OnGuildInviteMember(string userId, Action OnSucceed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GuildManagementUIController_OnGuildInviteMemberStringAction_hotfix != null)
			{
				this.m_GuildManagementUIController_OnGuildInviteMemberStringAction_hotfix.call(new object[]
				{
					this,
					userId,
					OnSucceed2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action OnSucceed = OnSucceed2;
			GuildJoinInviteReqNetTask guildJoinInviteReqNetTask = new GuildJoinInviteReqNetTask(userId);
			guildJoinInviteReqNetTask.EventOnStop += delegate(Task task)
			{
				GuildJoinInviteReqNetTask guildJoinInviteReqNetTask2 = task as GuildJoinInviteReqNetTask;
				if (guildJoinInviteReqNetTask2.Result == 0)
				{
					OnSucceed();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(guildJoinInviteReqNetTask2.Result, 2f, null, true);
				}
			};
			guildJoinInviteReqNetTask.Start(null);
		}

		// Token: 0x0600F602 RID: 62978 RVA: 0x00411888 File Offset: 0x0040FA88
		private void GuildManagementUIController_OnAllRefuseButtonClick(Action OnSucceed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GuildManagementUIController_OnAllRefuseButtonClickAction_hotfix != null)
			{
				this.m_GuildManagementUIController_OnAllRefuseButtonClickAction_hotfix.call(new object[]
				{
					this,
					OnSucceed2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action OnSucceed = OnSucceed2;
			GuildManagementUITask $this = this;
			AllGuildJoinApplyRefuseReqNetTask allGuildJoinApplyRefuseReqNetTask = new AllGuildJoinApplyRefuseReqNetTask();
			allGuildJoinApplyRefuseReqNetTask.EventOnStop += delegate(Task task)
			{
				AllGuildJoinApplyRefuseReqNetTask allGuildJoinApplyRefuseReqNetTask2 = task as AllGuildJoinApplyRefuseReqNetTask;
				if (allGuildJoinApplyRefuseReqNetTask2.Result == 0)
				{
					if (OnSucceed != null)
					{
						OnSucceed();
					}
					$this.UpdateView();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(allGuildJoinApplyRefuseReqNetTask2.Result, 2f, null, true);
				}
			};
			allGuildJoinApplyRefuseReqNetTask.Start(null);
		}

		// Token: 0x0600F603 RID: 62979 RVA: 0x0041192C File Offset: 0x0040FB2C
		private void GuildManagementUIController_OnGuildMemberClick(string userId, Vector3 pos, PlayerSimpleInfoUITask.PostionType posType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GuildManagementUIController_OnGuildMemberClickStringVector3PostionType_hotfix != null)
			{
				this.m_GuildManagementUIController_OnGuildMemberClickStringVector3PostionType_hotfix.call(new object[]
				{
					this,
					userId,
					pos2,
					posType2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Vector3 pos = pos2;
			PlayerSimpleInfoUITask.PostionType posType = posType2;
			GuildManagementUITask $this = this;
			BusinessCardGetNetTask businessCardGetNetTask = new BusinessCardGetNetTask(userId);
			businessCardGetNetTask.EventOnStop += delegate(Task task)
			{
				BusinessCardGetNetTask businessCardGetNetTask2 = task as BusinessCardGetNetTask;
				if (businessCardGetNetTask2.Result == 0)
				{
					PlayerSimpleInfoUITask playerSimpleInfoUITask = PlayerSimpleInfoUITask.ShowPlayerSimpleInfoPanel(pos, posType, $this.m_currIntent, true);
					if ($this.m_playerSimpleInfoUITask == null)
					{
						$this.m_playerSimpleInfoUITask = playerSimpleInfoUITask;
						$this.m_playerSimpleInfoUITask.EventOnClose += $this.PlayerSimpleInfoUITask_OnClose;
						$this.m_playerSimpleInfoUITask.EventOnPrivateChatButtonClick += $this.PlayerSimpleInfoUITask_OnPrivateChatButtonClick;
					}
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(businessCardGetNetTask2.Result, 2f, null, true);
				}
			};
			businessCardGetNetTask.Start(null);
		}

		// Token: 0x0600F604 RID: 62980 RVA: 0x004119F8 File Offset: 0x0040FBF8
		private void GuildManagementUIController_OnGotoGuildStore()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GuildManagementUIController_OnGotoGuildStore_hotfix != null)
			{
				this.m_GuildManagementUIController_OnGotoGuildStore_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GuildStoreUITask.StartUITask(base.CurrentIntent);
		}

		// Token: 0x0600F605 RID: 62981 RVA: 0x00411A64 File Offset: 0x0040FC64
		private void GuildManagementUIController_OnGotoGuildGameListPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GuildManagementUIController_OnGotoGuildGameListPanel_hotfix != null)
			{
				this.m_GuildManagementUIController_OnGotoGuildGameListPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIIntentReturnable intent = new UIIntentReturnable(this.m_currIntent, typeof(GuildGameListUITask).Name, null);
				UIManager.Instance.StartUITask(intent, true, false, new Action(this.GuildGameListUITask_OnLoadAllResCompleted));
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600F606 RID: 62982 RVA: 0x00411AE8 File Offset: 0x0040FCE8
		private void GuildGameListUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GuildGameListUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_GuildGameListUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(GuildGameListUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x0600F607 RID: 62983 RVA: 0x00411B74 File Offset: 0x0040FD74
		private void PlayerSimpleInfoUITask_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerSimpleInfoUITask_OnClose_hotfix != null)
			{
				this.m_PlayerSimpleInfoUITask_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_playerSimpleInfoUITask != null)
			{
				this.m_playerSimpleInfoUITask.EventOnClose -= this.PlayerSimpleInfoUITask_OnClose;
				this.m_playerSimpleInfoUITask.EventOnPrivateChatButtonClick -= this.PlayerSimpleInfoUITask_OnPrivateChatButtonClick;
				this.m_playerSimpleInfoUITask = null;
			}
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x0600F608 RID: 62984 RVA: 0x00411C20 File Offset: 0x0040FE20
		private void PlayerSimpleInfoUITask_OnPrivateChatButtonClick(BusinessCard playerInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerSimpleInfoUITask_OnPrivateChatButtonClickBusinessCard_hotfix != null)
			{
				this.m_PlayerSimpleInfoUITask_OnPrivateChatButtonClickBusinessCard_hotfix.call(new object[]
				{
					this,
					playerInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ChatUITask.StartChatUITaskToEnterAppointChannel(ChatChannel.Private, this.m_currIntent, playerInfo.UserId);
		}

		// Token: 0x0600F609 RID: 62985 RVA: 0x00411CA4 File Offset: 0x0040FEA4
		protected override void OnTick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTick_hotfix != null)
			{
				this.m_OnTick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnTick();
			if (this.m_guildManagementUIController == null)
			{
				return;
			}
			int num = 10;
			if (Time.time - this.m_lastUpdateTime >= (float)num)
			{
				this.m_lastUpdateTime = Time.time;
				this.SendRefreshGuildReq();
			}
		}

		// Token: 0x0600F60A RID: 62986 RVA: 0x00411D44 File Offset: 0x0040FF44
		private void SendRefreshGuildReq()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SendRefreshGuildReq_hotfix != null)
			{
				this.m_SendRefreshGuildReq_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			string guildId = projectLPlayerContext.GetGuildId();
			if (string.IsNullOrEmpty(guildId))
			{
				return;
			}
			GuildGetReqNetTask guildGetReqNetTask = new GuildGetReqNetTask(guildId);
			guildGetReqNetTask.EventOnStop += delegate(Task task)
			{
				GuildGetReqNetTask guildGetReqNetTask2 = task as GuildGetReqNetTask;
				if (guildGetReqNetTask2.Result == 0)
				{
					this.UpdateView();
				}
			};
			guildGetReqNetTask.Start(null);
		}

		// Token: 0x17002F3A RID: 12090
		// (get) Token: 0x0600F60B RID: 62987 RVA: 0x00411DE8 File Offset: 0x0040FFE8
		protected override UITaskBase.LayerDesc[] LayerDescArray
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_LayerDescArray_hotfix != null)
				{
					return (UITaskBase.LayerDesc[])this.m_get_LayerDescArray_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_layerDescArray;
			}
		}

		// Token: 0x17002F3B RID: 12091
		// (get) Token: 0x0600F60C RID: 62988 RVA: 0x00411E5C File Offset: 0x0041005C
		protected override UITaskBase.UIControllerDesc[] UICtrlDescArray
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_UICtrlDescArray_hotfix != null)
				{
					return (UITaskBase.UIControllerDesc[])this.m_get_UICtrlDescArray_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_uiCtrlDescArray;
			}
		}

		// Token: 0x17002F3C RID: 12092
		// (get) Token: 0x0600F60D RID: 62989 RVA: 0x00411ED0 File Offset: 0x004100D0
		// (set) Token: 0x0600F60E RID: 62990 RVA: 0x00411EF0 File Offset: 0x004100F0
		[DoNotToLua]
		public new GuildManagementUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GuildManagementUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600F60F RID: 62991 RVA: 0x00411EFC File Offset: 0x004100FC
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600F610 RID: 62992 RVA: 0x00411F08 File Offset: 0x00410108
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600F611 RID: 62993 RVA: 0x00411F10 File Offset: 0x00410110
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600F612 RID: 62994 RVA: 0x00411F18 File Offset: 0x00410118
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600F613 RID: 62995 RVA: 0x00411F24 File Offset: 0x00410124
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600F614 RID: 62996 RVA: 0x00411F30 File Offset: 0x00410130
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600F615 RID: 62997 RVA: 0x00411F3C File Offset: 0x0041013C
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600F616 RID: 62998 RVA: 0x00411F44 File Offset: 0x00410144
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600F617 RID: 62999 RVA: 0x00411F4C File Offset: 0x0041014C
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600F618 RID: 63000 RVA: 0x00411F54 File Offset: 0x00410154
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600F619 RID: 63001 RVA: 0x00411F5C File Offset: 0x0041015C
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600F61A RID: 63002 RVA: 0x00411F64 File Offset: 0x00410164
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600F61B RID: 63003 RVA: 0x00411F6C File Offset: 0x0041016C
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600F61C RID: 63004 RVA: 0x00411F74 File Offset: 0x00410174
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600F61D RID: 63005 RVA: 0x00411F80 File Offset: 0x00410180
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600F61E RID: 63006 RVA: 0x00411F8C File Offset: 0x0041018C
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600F61F RID: 63007 RVA: 0x00411F98 File Offset: 0x00410198
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600F620 RID: 63008 RVA: 0x00411FA4 File Offset: 0x004101A4
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600F621 RID: 63009 RVA: 0x00411FAC File Offset: 0x004101AC
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600F622 RID: 63010 RVA: 0x00411FB4 File Offset: 0x004101B4
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600F623 RID: 63011 RVA: 0x00411FBC File Offset: 0x004101BC
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600F624 RID: 63012 RVA: 0x00411FC4 File Offset: 0x004101C4
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600F625 RID: 63013 RVA: 0x00411FCC File Offset: 0x004101CC
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600F629 RID: 63017 RVA: 0x00412060 File Offset: 0x00410260
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				global::Debug.LogError("Can't find HotFixObject Func");
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
					this.m_ctorString_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_OnResumeUIIntent_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_InitDataFromUIIntentUIIntent_hotfix = (luaObj.RawGet("InitDataFromUIIntent") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_PostUpdateView_hotfix = (luaObj.RawGet("PostUpdateView") as LuaFunction);
					this.m_GuildManagementUIController_OnClose_hotfix = (luaObj.RawGet("GuildManagementUIController_OnClose") as LuaFunction);
					this.m_PlayerContext_EventOnGuildUpdateInfoGuildLog_hotfix = (luaObj.RawGet("PlayerContext_EventOnGuildUpdateInfo") as LuaFunction);
					this.m_GuildManagementUIController_OnQuitGuildAction_hotfix = (luaObj.RawGet("GuildManagementUIController_OnQuitGuild") as LuaFunction);
					this.m_GuildManagementUIController_OnGetCanInvitePlayerListAction`1Boolean_hotfix = (luaObj.RawGet("GuildManagementUIController_OnGetCanInvitePlayerList") as LuaFunction);
					this.m_GuildManagementUIController_OnGuildHiringDeclarationSetStringAction_hotfix = (luaObj.RawGet("GuildManagementUIController_OnGuildHiringDeclarationSet") as LuaFunction);
					this.m_GuildManagementUIController_OnGuildInfoSetBooleanInt32StringAction_hotfix = (luaObj.RawGet("GuildManagementUIController_OnGuildInfoSet") as LuaFunction);
					this.m_GuildManagementUIController_OnGuildAnnouncementSetStringAction_hotfix = (luaObj.RawGet("GuildManagementUIController_OnGuildAnnouncementSet") as LuaFunction);
					this.m_GuildManagementUIController_OnGetGuildJoinApplyAction`1_hotfix = (luaObj.RawGet("GuildManagementUIController_OnGetGuildJoinApply") as LuaFunction);
					this.m_GuildManagementUIController_OnGuildJoinConfirmOrRefuseStringBooleanAction_hotfix = (luaObj.RawGet("GuildManagementUIController_OnGuildJoinConfirmOrRefuse") as LuaFunction);
					this.m_GuildManagementUIController_OnChangeGuildNameStringAction_hotfix = (luaObj.RawGet("GuildManagementUIController_OnChangeGuildName") as LuaFunction);
					this.m_GuildManagementUIController_OnGetGuildJournalAction`1_hotfix = (luaObj.RawGet("GuildManagementUIController_OnGetGuildJournal") as LuaFunction);
					this.m_GuildManagementUIController_OnGuildInviteMemberStringAction_hotfix = (luaObj.RawGet("GuildManagementUIController_OnGuildInviteMember") as LuaFunction);
					this.m_GuildManagementUIController_OnAllRefuseButtonClickAction_hotfix = (luaObj.RawGet("GuildManagementUIController_OnAllRefuseButtonClick") as LuaFunction);
					this.m_GuildManagementUIController_OnGuildMemberClickStringVector3PostionType_hotfix = (luaObj.RawGet("GuildManagementUIController_OnGuildMemberClick") as LuaFunction);
					this.m_GuildManagementUIController_OnGotoGuildStore_hotfix = (luaObj.RawGet("GuildManagementUIController_OnGotoGuildStore") as LuaFunction);
					this.m_GuildManagementUIController_OnGotoGuildGameListPanel_hotfix = (luaObj.RawGet("GuildManagementUIController_OnGotoGuildGameListPanel") as LuaFunction);
					this.m_GuildGameListUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("GuildGameListUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_PlayerSimpleInfoUITask_OnClose_hotfix = (luaObj.RawGet("PlayerSimpleInfoUITask_OnClose") as LuaFunction);
					this.m_PlayerSimpleInfoUITask_OnPrivateChatButtonClickBusinessCard_hotfix = (luaObj.RawGet("PlayerSimpleInfoUITask_OnPrivateChatButtonClick") as LuaFunction);
					this.m_OnTick_hotfix = (luaObj.RawGet("OnTick") as LuaFunction);
					this.m_SendRefreshGuildReq_hotfix = (luaObj.RawGet("SendRefreshGuildReq") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600F62A RID: 63018 RVA: 0x00412434 File Offset: 0x00410634
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildManagementUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009144 RID: 37188
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "GuildManagementUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Guild_ABS/Prefab/GuildDetailUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04009145 RID: 37189
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "GuildManagementUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.GuildManagementUIController"),
				m_ctrlName = "GuildManagementUIController"
			}
		};

		// Token: 0x04009146 RID: 37190
		private GuildManagementUIController m_guildManagementUIController;

		// Token: 0x04009147 RID: 37191
		private static string m_guildId;

		// Token: 0x04009148 RID: 37192
		private PlayerSimpleInfoUITask m_playerSimpleInfoUITask;

		// Token: 0x04009149 RID: 37193
		private float m_lastUpdateTime;

		// Token: 0x0400914A RID: 37194
		private static Guild m_guild;

		// Token: 0x0400914B RID: 37195
		[DoNotToLua]
		private GuildManagementUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400914C RID: 37196
		[CompilerGenerated]
		private static Action <>f__mg$cache0;

		// Token: 0x0400914D RID: 37197
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400914E RID: 37198
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400914F RID: 37199
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x04009150 RID: 37200
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x04009151 RID: 37201
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x04009152 RID: 37202
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x04009153 RID: 37203
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x04009154 RID: 37204
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x04009155 RID: 37205
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x04009156 RID: 37206
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04009157 RID: 37207
		private LuaFunction m_PostUpdateView_hotfix;

		// Token: 0x04009158 RID: 37208
		private LuaFunction m_GuildManagementUIController_OnClose_hotfix;

		// Token: 0x04009159 RID: 37209
		private LuaFunction m_PlayerContext_EventOnGuildUpdateInfoGuildLog_hotfix;

		// Token: 0x0400915A RID: 37210
		private LuaFunction m_GuildManagementUIController_OnQuitGuildAction_hotfix;

		// Token: 0x0400915B RID: 37211
		private LuaFunction m_GuildManagementUIController_OnGetCanInvitePlayerListAction;

		// Token: 0x0400915C RID: 37212
		private LuaFunction m_GuildManagementUIController_OnGuildHiringDeclarationSetStringAction_hotfix;

		// Token: 0x0400915D RID: 37213
		private LuaFunction m_GuildManagementUIController_OnGuildInfoSetBooleanInt32StringAction_hotfix;

		// Token: 0x0400915E RID: 37214
		private LuaFunction m_GuildManagementUIController_OnGuildAnnouncementSetStringAction_hotfix;

		// Token: 0x0400915F RID: 37215
		private LuaFunction m_GuildManagementUIController_OnGetGuildJoinApplyAction;

		// Token: 0x04009160 RID: 37216
		private LuaFunction m_GuildManagementUIController_OnGuildJoinConfirmOrRefuseStringBooleanAction_hotfix;

		// Token: 0x04009161 RID: 37217
		private LuaFunction m_GuildManagementUIController_OnChangeGuildNameStringAction_hotfix;

		// Token: 0x04009162 RID: 37218
		private LuaFunction m_GuildManagementUIController_OnGetGuildJournalAction;

		// Token: 0x04009163 RID: 37219
		private LuaFunction m_GuildManagementUIController_OnGuildInviteMemberStringAction_hotfix;

		// Token: 0x04009164 RID: 37220
		private LuaFunction m_GuildManagementUIController_OnAllRefuseButtonClickAction_hotfix;

		// Token: 0x04009165 RID: 37221
		private LuaFunction m_GuildManagementUIController_OnGuildMemberClickStringVector3PostionType_hotfix;

		// Token: 0x04009166 RID: 37222
		private LuaFunction m_GuildManagementUIController_OnGotoGuildStore_hotfix;

		// Token: 0x04009167 RID: 37223
		private LuaFunction m_GuildManagementUIController_OnGotoGuildGameListPanel_hotfix;

		// Token: 0x04009168 RID: 37224
		private LuaFunction m_GuildGameListUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x04009169 RID: 37225
		private LuaFunction m_PlayerSimpleInfoUITask_OnClose_hotfix;

		// Token: 0x0400916A RID: 37226
		private LuaFunction m_PlayerSimpleInfoUITask_OnPrivateChatButtonClickBusinessCard_hotfix;

		// Token: 0x0400916B RID: 37227
		private LuaFunction m_OnTick_hotfix;

		// Token: 0x0400916C RID: 37228
		private LuaFunction m_SendRefreshGuildReq_hotfix;

		// Token: 0x0400916D RID: 37229
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400916E RID: 37230
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000D07 RID: 3335
		public new class LuaExportHelper
		{
			// Token: 0x0600F62B RID: 63019 RVA: 0x0041249C File Offset: 0x0041069C
			public LuaExportHelper(GuildManagementUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600F62C RID: 63020 RVA: 0x004124AC File Offset: 0x004106AC
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600F62D RID: 63021 RVA: 0x004124BC File Offset: 0x004106BC
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600F62E RID: 63022 RVA: 0x004124CC File Offset: 0x004106CC
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600F62F RID: 63023 RVA: 0x004124DC File Offset: 0x004106DC
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600F630 RID: 63024 RVA: 0x004124EC File Offset: 0x004106EC
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600F631 RID: 63025 RVA: 0x004124FC File Offset: 0x004106FC
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600F632 RID: 63026 RVA: 0x0041250C File Offset: 0x0041070C
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600F633 RID: 63027 RVA: 0x0041251C File Offset: 0x0041071C
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600F634 RID: 63028 RVA: 0x0041252C File Offset: 0x0041072C
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600F635 RID: 63029 RVA: 0x0041253C File Offset: 0x0041073C
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600F636 RID: 63030 RVA: 0x0041254C File Offset: 0x0041074C
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600F637 RID: 63031 RVA: 0x0041255C File Offset: 0x0041075C
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600F638 RID: 63032 RVA: 0x0041256C File Offset: 0x0041076C
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600F639 RID: 63033 RVA: 0x0041257C File Offset: 0x0041077C
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600F63A RID: 63034 RVA: 0x0041258C File Offset: 0x0041078C
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600F63B RID: 63035 RVA: 0x0041259C File Offset: 0x0041079C
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600F63C RID: 63036 RVA: 0x004125AC File Offset: 0x004107AC
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600F63D RID: 63037 RVA: 0x004125BC File Offset: 0x004107BC
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600F63E RID: 63038 RVA: 0x004125CC File Offset: 0x004107CC
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600F63F RID: 63039 RVA: 0x004125DC File Offset: 0x004107DC
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600F640 RID: 63040 RVA: 0x004125EC File Offset: 0x004107EC
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600F641 RID: 63041 RVA: 0x004125FC File Offset: 0x004107FC
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600F642 RID: 63042 RVA: 0x0041260C File Offset: 0x0041080C
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x17002F3D RID: 12093
			// (get) Token: 0x0600F643 RID: 63043 RVA: 0x0041261C File Offset: 0x0041081C
			// (set) Token: 0x0600F644 RID: 63044 RVA: 0x0041262C File Offset: 0x0041082C
			public UITaskBase.LayerDesc[] m_layerDescArray
			{
				get
				{
					return this.m_owner.m_layerDescArray;
				}
				set
				{
					this.m_owner.m_layerDescArray = value;
				}
			}

			// Token: 0x17002F3E RID: 12094
			// (get) Token: 0x0600F645 RID: 63045 RVA: 0x0041263C File Offset: 0x0041083C
			// (set) Token: 0x0600F646 RID: 63046 RVA: 0x0041264C File Offset: 0x0041084C
			public UITaskBase.UIControllerDesc[] m_uiCtrlDescArray
			{
				get
				{
					return this.m_owner.m_uiCtrlDescArray;
				}
				set
				{
					this.m_owner.m_uiCtrlDescArray = value;
				}
			}

			// Token: 0x17002F3F RID: 12095
			// (get) Token: 0x0600F647 RID: 63047 RVA: 0x0041265C File Offset: 0x0041085C
			// (set) Token: 0x0600F648 RID: 63048 RVA: 0x0041266C File Offset: 0x0041086C
			public GuildManagementUIController m_guildManagementUIController
			{
				get
				{
					return this.m_owner.m_guildManagementUIController;
				}
				set
				{
					this.m_owner.m_guildManagementUIController = value;
				}
			}

			// Token: 0x17002F40 RID: 12096
			// (get) Token: 0x0600F649 RID: 63049 RVA: 0x0041267C File Offset: 0x0041087C
			// (set) Token: 0x0600F64A RID: 63050 RVA: 0x00412684 File Offset: 0x00410884
			public static string m_guildId
			{
				get
				{
					return GuildManagementUITask.m_guildId;
				}
				set
				{
					GuildManagementUITask.m_guildId = value;
				}
			}

			// Token: 0x17002F41 RID: 12097
			// (get) Token: 0x0600F64B RID: 63051 RVA: 0x0041268C File Offset: 0x0041088C
			// (set) Token: 0x0600F64C RID: 63052 RVA: 0x0041269C File Offset: 0x0041089C
			public PlayerSimpleInfoUITask m_playerSimpleInfoUITask
			{
				get
				{
					return this.m_owner.m_playerSimpleInfoUITask;
				}
				set
				{
					this.m_owner.m_playerSimpleInfoUITask = value;
				}
			}

			// Token: 0x17002F42 RID: 12098
			// (get) Token: 0x0600F64D RID: 63053 RVA: 0x004126AC File Offset: 0x004108AC
			// (set) Token: 0x0600F64E RID: 63054 RVA: 0x004126BC File Offset: 0x004108BC
			public float m_lastUpdateTime
			{
				get
				{
					return this.m_owner.m_lastUpdateTime;
				}
				set
				{
					this.m_owner.m_lastUpdateTime = value;
				}
			}

			// Token: 0x17002F43 RID: 12099
			// (get) Token: 0x0600F64F RID: 63055 RVA: 0x004126CC File Offset: 0x004108CC
			// (set) Token: 0x0600F650 RID: 63056 RVA: 0x004126D4 File Offset: 0x004108D4
			public static Guild m_guild
			{
				get
				{
					return GuildManagementUITask.m_guild;
				}
				set
				{
					GuildManagementUITask.m_guild = value;
				}
			}

			// Token: 0x17002F44 RID: 12100
			// (get) Token: 0x0600F651 RID: 63057 RVA: 0x004126DC File Offset: 0x004108DC
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17002F45 RID: 12101
			// (get) Token: 0x0600F652 RID: 63058 RVA: 0x004126EC File Offset: 0x004108EC
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600F653 RID: 63059 RVA: 0x004126FC File Offset: 0x004108FC
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x0600F654 RID: 63060 RVA: 0x0041270C File Offset: 0x0041090C
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600F655 RID: 63061 RVA: 0x0041271C File Offset: 0x0041091C
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600F656 RID: 63062 RVA: 0x0041272C File Offset: 0x0041092C
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0600F657 RID: 63063 RVA: 0x0041273C File Offset: 0x0041093C
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x0600F658 RID: 63064 RVA: 0x0041274C File Offset: 0x0041094C
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x0600F659 RID: 63065 RVA: 0x0041275C File Offset: 0x0041095C
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600F65A RID: 63066 RVA: 0x0041276C File Offset: 0x0041096C
			public void PostUpdateView()
			{
				this.m_owner.PostUpdateView();
			}

			// Token: 0x0600F65B RID: 63067 RVA: 0x0041277C File Offset: 0x0041097C
			public void GuildManagementUIController_OnClose()
			{
				this.m_owner.GuildManagementUIController_OnClose();
			}

			// Token: 0x0600F65C RID: 63068 RVA: 0x0041278C File Offset: 0x0041098C
			public void PlayerContext_EventOnGuildUpdateInfo(GuildLog log)
			{
				this.m_owner.PlayerContext_EventOnGuildUpdateInfo(log);
			}

			// Token: 0x0600F65D RID: 63069 RVA: 0x0041279C File Offset: 0x0041099C
			public void GuildManagementUIController_OnQuitGuild(Action OnSucceed)
			{
				this.m_owner.GuildManagementUIController_OnQuitGuild(OnSucceed);
			}

			// Token: 0x0600F65E RID: 63070 RVA: 0x004127AC File Offset: 0x004109AC
			public void GuildManagementUIController_OnGetCanInvitePlayerList(Action<List<UserSummary>> OnSucceed, bool isShowSucceedTip)
			{
				this.m_owner.GuildManagementUIController_OnGetCanInvitePlayerList(OnSucceed, isShowSucceedTip);
			}

			// Token: 0x0600F65F RID: 63071 RVA: 0x004127BC File Offset: 0x004109BC
			public void GuildManagementUIController_OnGuildHiringDeclarationSet(string hiringDeclaration, Action OnSucceed)
			{
				this.m_owner.GuildManagementUIController_OnGuildHiringDeclarationSet(hiringDeclaration, OnSucceed);
			}

			// Token: 0x0600F660 RID: 63072 RVA: 0x004127CC File Offset: 0x004109CC
			public void GuildManagementUIController_OnGuildInfoSet(bool autoJoin, int joinLevel, string announcement, Action OnSucceed)
			{
				this.m_owner.GuildManagementUIController_OnGuildInfoSet(autoJoin, joinLevel, announcement, OnSucceed);
			}

			// Token: 0x0600F661 RID: 63073 RVA: 0x004127E0 File Offset: 0x004109E0
			public void GuildManagementUIController_OnGuildAnnouncementSet(string announcement, Action OnSucceed)
			{
				this.m_owner.GuildManagementUIController_OnGuildAnnouncementSet(announcement, OnSucceed);
			}

			// Token: 0x0600F662 RID: 63074 RVA: 0x004127F0 File Offset: 0x004109F0
			public void GuildManagementUIController_OnGetGuildJoinApply(Action<List<UserSummary>> OnSucceed)
			{
				this.m_owner.GuildManagementUIController_OnGetGuildJoinApply(OnSucceed);
			}

			// Token: 0x0600F663 RID: 63075 RVA: 0x00412800 File Offset: 0x00410A00
			public void GuildManagementUIController_OnGuildJoinConfirmOrRefuse(string userId, bool isAccept, Action OnEnd)
			{
				this.m_owner.GuildManagementUIController_OnGuildJoinConfirmOrRefuse(userId, isAccept, OnEnd);
			}

			// Token: 0x0600F664 RID: 63076 RVA: 0x00412810 File Offset: 0x00410A10
			public void GuildManagementUIController_OnChangeGuildName(string name, Action OnSucceed)
			{
				this.m_owner.GuildManagementUIController_OnChangeGuildName(name, OnSucceed);
			}

			// Token: 0x0600F665 RID: 63077 RVA: 0x00412820 File Offset: 0x00410A20
			public void GuildManagementUIController_OnGetGuildJournal(Action<List<GuildLog>> OnSucceed)
			{
				this.m_owner.GuildManagementUIController_OnGetGuildJournal(OnSucceed);
			}

			// Token: 0x0600F666 RID: 63078 RVA: 0x00412830 File Offset: 0x00410A30
			public void GuildManagementUIController_OnGuildInviteMember(string userId, Action OnSucceed)
			{
				this.m_owner.GuildManagementUIController_OnGuildInviteMember(userId, OnSucceed);
			}

			// Token: 0x0600F667 RID: 63079 RVA: 0x00412840 File Offset: 0x00410A40
			public void GuildManagementUIController_OnAllRefuseButtonClick(Action OnSucceed)
			{
				this.m_owner.GuildManagementUIController_OnAllRefuseButtonClick(OnSucceed);
			}

			// Token: 0x0600F668 RID: 63080 RVA: 0x00412850 File Offset: 0x00410A50
			public void GuildManagementUIController_OnGuildMemberClick(string userId, Vector3 pos, PlayerSimpleInfoUITask.PostionType posType)
			{
				this.m_owner.GuildManagementUIController_OnGuildMemberClick(userId, pos, posType);
			}

			// Token: 0x0600F669 RID: 63081 RVA: 0x00412860 File Offset: 0x00410A60
			public void GuildManagementUIController_OnGotoGuildStore()
			{
				this.m_owner.GuildManagementUIController_OnGotoGuildStore();
			}

			// Token: 0x0600F66A RID: 63082 RVA: 0x00412870 File Offset: 0x00410A70
			public void GuildManagementUIController_OnGotoGuildGameListPanel()
			{
				this.m_owner.GuildManagementUIController_OnGotoGuildGameListPanel();
			}

			// Token: 0x0600F66B RID: 63083 RVA: 0x00412880 File Offset: 0x00410A80
			public void GuildGameListUITask_OnLoadAllResCompleted()
			{
				this.m_owner.GuildGameListUITask_OnLoadAllResCompleted();
			}

			// Token: 0x0600F66C RID: 63084 RVA: 0x00412890 File Offset: 0x00410A90
			public void PlayerSimpleInfoUITask_OnClose()
			{
				this.m_owner.PlayerSimpleInfoUITask_OnClose();
			}

			// Token: 0x0600F66D RID: 63085 RVA: 0x004128A0 File Offset: 0x00410AA0
			public void PlayerSimpleInfoUITask_OnPrivateChatButtonClick(BusinessCard playerInfo)
			{
				this.m_owner.PlayerSimpleInfoUITask_OnPrivateChatButtonClick(playerInfo);
			}

			// Token: 0x0600F66E RID: 63086 RVA: 0x004128B0 File Offset: 0x00410AB0
			public void OnTick()
			{
				this.m_owner.OnTick();
			}

			// Token: 0x0600F66F RID: 63087 RVA: 0x004128C0 File Offset: 0x00410AC0
			public void SendRefreshGuildReq()
			{
				this.m_owner.SendRefreshGuildReq();
			}

			// Token: 0x0400916F RID: 37231
			private GuildManagementUITask m_owner;
		}
	}
}
