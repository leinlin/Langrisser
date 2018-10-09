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
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F78 RID: 3960
	[HotFix]
	public class TeamRoomInviteUITask : UITask
	{
		// Token: 0x06013C15 RID: 80917 RVA: 0x005082AC File Offset: 0x005064AC
		public TeamRoomInviteUITask(string name) : base(name)
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

		// Token: 0x06013C16 RID: 80918 RVA: 0x005083C0 File Offset: 0x005065C0
		public override void PrepareForStartOrResume(UIIntent intent, Action<bool> onPrepareEnd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PrepareForStartOrResumeUIIntentAction`1_hotfix != null)
			{
				this.m_PrepareForStartOrResumeUIIntentAction`1_hotfix.call(new object[]
				{
					this,
					intent,
					onPrepareEnd2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action<bool> onPrepareEnd = onPrepareEnd2;
			TeamRoomInviteUITask $this = this;
			GetFriendSocialRelationNetTask getFriendSocialRelationNetTask = new GetFriendSocialRelationNetTask((FriendSocialRelationFlag)33);
			getFriendSocialRelationNetTask.EventOnStop += delegate(Task task)
			{
				GetFriendSocialRelationNetTask getFriendSocialRelationNetTask2 = task as GetFriendSocialRelationNetTask;
				if (getFriendSocialRelationNetTask2.Result == 0)
				{
					$this.GetGuildInfo(onPrepareEnd);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(getFriendSocialRelationNetTask2.Result, 2f, null, true);
					onPrepareEnd(false);
				}
			};
			getFriendSocialRelationNetTask.Start(null);
		}

		// Token: 0x06013C17 RID: 80919 RVA: 0x00508478 File Offset: 0x00506678
		private void GetGuildInfo(Action<bool> onPrepareEnd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetGuildInfoAction`1_hotfix != null)
			{
				this.m_GetGuildInfoAction`1_hotfix.call(new object[]
				{
					this,
					onPrepareEnd2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action<bool> onPrepareEnd = onPrepareEnd2;
			ProjectLPlayerContext playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			string guildId = playerContext.GetGuildId();
			if (!string.IsNullOrEmpty(guildId))
			{
				GuildGetReqNetTask guildGetReqNetTask = new GuildGetReqNetTask(guildId);
				guildGetReqNetTask.EventOnStop += delegate(Task task)
				{
					GuildGetReqNetTask guildGetReqNetTask2 = task as GuildGetReqNetTask;
					if (guildGetReqNetTask2.Result == 0)
					{
						List<string> list = new List<string>();
						foreach (GuildMemberCacheObject guildMemberCacheObject in playerContext.GetGuildInfo().Members)
						{
							if (!playerContext.IsMe(guildMemberCacheObject.Member.UserId))
							{
								list.Add(guildMemberCacheObject.Member.UserId);
							}
						}
						if (list.Count > 0)
						{
							FriendGetUserSummaryReqNetTask friendGetUserSummaryReqNetTask = new FriendGetUserSummaryReqNetTask(list);
							friendGetUserSummaryReqNetTask.EventOnStop += delegate(Task task2)
							{
								FriendGetUserSummaryReqNetTask friendGetUserSummaryReqNetTask2 = task2 as FriendGetUserSummaryReqNetTask;
								if (friendGetUserSummaryReqNetTask2.Result == 0)
								{
									onPrepareEnd(true);
								}
								else
								{
									CommonUIController.Instance.ShowErrorMessage(friendGetUserSummaryReqNetTask2.Result, 2f, null, true);
									onPrepareEnd(false);
								}
							};
							friendGetUserSummaryReqNetTask.Start(null);
						}
						else
						{
							onPrepareEnd(true);
						}
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(guildGetReqNetTask2.Result, 2f, null, true);
						onPrepareEnd(false);
					}
				};
				guildGetReqNetTask.Start(null);
			}
			else
			{
				onPrepareEnd(true);
			}
		}

		// Token: 0x06013C18 RID: 80920 RVA: 0x00508554 File Offset: 0x00506754
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
			this.InitTeamRoomInviteUIController();
		}

		// Token: 0x06013C19 RID: 80921 RVA: 0x005085C0 File Offset: 0x005067C0
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
			this.UninitTeamRoomInviteUIController();
		}

		// Token: 0x06013C1A RID: 80922 RVA: 0x0050862C File Offset: 0x0050682C
		private void InitTeamRoomInviteUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitTeamRoomInviteUIController_hotfix != null)
			{
				this.m_InitTeamRoomInviteUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_teamRoomInviteUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_teamRoomInviteUIController = (this.m_uiCtrlArray[0] as TeamRoomInviteUIController);
				}
				if (!(this.m_teamRoomInviteUIController != null))
				{
					Debug.LogError("TeamRoomInviteUIController is null");
					return;
				}
				this.m_teamRoomInviteUIController.EventOnConfirm += this.TeamRoomInviteUIController_OnConfirm;
				this.m_teamRoomInviteUIController.EventOnCancel += this.TeamRoomInviteUIController_OnCancel;
				this.m_teamRoomInviteUIController.EventOnChangePlayerType += this.TeamRoomInviteUIController_OnChangePlayerType;
				ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				projectLPlayerContext.EventOnTeamRoomInviteeInfoNtf += this.PlayerContext_OnTeamRoomInviteeInfoNtf;
			}
		}

		// Token: 0x06013C1B RID: 80923 RVA: 0x00508748 File Offset: 0x00506948
		private void UninitTeamRoomInviteUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitTeamRoomInviteUIController_hotfix != null)
			{
				this.m_UninitTeamRoomInviteUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_teamRoomInviteUIController != null)
			{
				this.m_teamRoomInviteUIController.EventOnConfirm -= this.TeamRoomInviteUIController_OnConfirm;
				this.m_teamRoomInviteUIController.EventOnCancel -= this.TeamRoomInviteUIController_OnCancel;
				this.m_teamRoomInviteUIController.EventOnChangePlayerType -= this.TeamRoomInviteUIController_OnChangePlayerType;
				this.m_teamRoomInviteUIController = null;
				ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				if (projectLPlayerContext != null)
				{
					projectLPlayerContext.EventOnTeamRoomInviteeInfoNtf -= this.PlayerContext_OnTeamRoomInviteeInfoNtf;
				}
			}
		}

		// Token: 0x06013C1C RID: 80924 RVA: 0x00508830 File Offset: 0x00506A30
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
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			TeamRoom teamRoom = projectLPlayerContext.GetTeamRoom();
			if (base.IsOpeningUI())
			{
				this.m_teamRoomInviteUIController.Open();
				bool canChangePlayerType = true;
				if (teamRoom.Setting.GameFunctionTypeId == GameFunctionType.GameFunctionType_GuildMassiveCombat)
				{
					this.m_playerType = TeamRoomInvitePlayerType.Guild;
					canChangePlayerType = false;
				}
				this.m_teamRoomInviteUIController.SetPlayerType(this.m_playerType, canChangePlayerType);
			}
			if (this.m_playerType == TeamRoomInvitePlayerType.Friend)
			{
				this.m_playerList.Clear();
				foreach (UserSummary userSummary in projectLPlayerContext.GetFriendList())
				{
					if (userSummary.Online)
					{
						this.m_playerList.Add(userSummary);
					}
				}
				foreach (UserSummary userSummary2 in projectLPlayerContext.GetAcrossServerFriendList())
				{
					if (userSummary2.Online)
					{
						this.m_playerList.Add(userSummary2);
					}
				}
				List<UserSummary> playerList = this.m_playerList;
				if (TeamRoomInviteUITask.<>f__mg$cache0 == null)
				{
					TeamRoomInviteUITask.<>f__mg$cache0 = new Comparison<UserSummary>(TeamRoomInviteUITask.ComparePlayerLevel);
				}
				playerList.Sort(TeamRoomInviteUITask.<>f__mg$cache0);
				this.m_teamRoomInviteUIController.SetPlayers(this.m_playerList);
			}
			else if (this.m_playerType == TeamRoomInvitePlayerType.Recent)
			{
				this.m_playerList.Clear();
				foreach (UserSummary userSummary3 in projectLPlayerContext.GetRecentTeamBattlePlayerList())
				{
					if (userSummary3.Online && !this.IsUserInTeamRoom(userSummary3.UserId))
					{
						this.m_playerList.Add(userSummary3);
					}
				}
				this.m_teamRoomInviteUIController.SetPlayers(this.m_playerList);
			}
			else if (this.m_playerType == TeamRoomInvitePlayerType.Guild)
			{
				this.m_playerList.Clear();
				Guild guildInfo = projectLPlayerContext.GetGuildInfo();
				if (guildInfo != null)
				{
					foreach (UserSummary userSummary4 in projectLPlayerContext.GetGuildPlayerList())
					{
						if (userSummary4.Online && !this.IsUserInTeamRoom(userSummary4.UserId))
						{
							this.m_playerList.Add(userSummary4);
						}
					}
				}
				this.m_teamRoomInviteUIController.SetPlayers(this.m_playerList);
			}
			if (teamRoom.Setting.GameFunctionTypeId != this.m_onlinePlayersStatusGameFunctionType || teamRoom.Setting.LocationId != this.m_onlinePlayersStatusLocationId)
			{
				this.m_onlinePlayersStatus.Clear();
				this.m_onlinePlayersStatusGameFunctionType = teamRoom.Setting.GameFunctionTypeId;
				this.m_onlinePlayersStatusLocationId = teamRoom.Setting.LocationId;
			}
			this.m_updateStatusUserIds.Clear();
			DateTime now = DateTime.Now;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			float num = (float)configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_TeamRoomInviteeLevelInfoGetTime);
			foreach (UserSummary userSummary5 in this.m_playerList)
			{
				TeamRoomInviteUITask.OnlinePlayerStatus onlinePlayerStatus = this.GetOnlinePlayerStatus(userSummary5.UserId);
				if (onlinePlayerStatus != null)
				{
					this.m_teamRoomInviteUIController.UpdatePlayerStatus(userSummary5.UserId, onlinePlayerStatus.InviteState);
					if ((now - onlinePlayerStatus.UpdateTime).TotalSeconds > (double)num)
					{
						this.m_updateStatusUserIds.Add(userSummary5.UserId);
					}
				}
				else
				{
					this.m_updateStatusUserIds.Add(userSummary5.UserId);
				}
			}
			if (base.IsOpeningUI() && this.m_updateStatusUserIds.Count > 0)
			{
				TeamRoomInviteeInfoType infoType = TeamRoomInviteeInfoType.Level;
				if (teamRoom.Setting.GameFunctionTypeId == GameFunctionType.GameFunctionType_GuildMassiveCombat)
				{
					infoType = TeamRoomInviteeInfoType.GuildMassiveCombat;
				}
				this.StartTeamRoomInviteeInfoGetNetTask(this.m_updateStatusUserIds, infoType);
			}
			this.m_teamRoomInviteUIController.ShowGildToggleUnopenMask(string.IsNullOrEmpty(projectLPlayerContext.GetGuildId()));
		}

		// Token: 0x06013C1D RID: 80925 RVA: 0x00508CE8 File Offset: 0x00506EE8
		private void StartTeamRoomInviteeInfoGetNetTask(List<string> userIds, TeamRoomInviteeInfoType infoType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartTeamRoomInviteeInfoGetNetTaskList`1TeamRoomInviteeInfoType_hotfix != null)
			{
				this.m_StartTeamRoomInviteeInfoGetNetTaskList`1TeamRoomInviteeInfoType_hotfix.call(new object[]
				{
					this,
					userIds,
					infoType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			TeamRoomInviteeInfoGetNetTask teamRoomInviteeInfoGetNetTask = new TeamRoomInviteeInfoGetNetTask(userIds, infoType);
			teamRoomInviteeInfoGetNetTask.EventOnStop += delegate(Task task)
			{
				TeamRoomInviteeInfoGetNetTask teamRoomInviteeInfoGetNetTask2 = task as TeamRoomInviteeInfoGetNetTask;
				if (teamRoomInviteeInfoGetNetTask2.Result != 0)
				{
					CommonUIController.Instance.ShowErrorMessage(teamRoomInviteeInfoGetNetTask2.Result, 2f, null, true);
				}
			};
			teamRoomInviteeInfoGetNetTask.Start(null);
		}

		// Token: 0x06013C1E RID: 80926 RVA: 0x00508D9C File Offset: 0x00506F9C
		private bool IsUserInTeamRoom(string userId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsUserInTeamRoomString_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsUserInTeamRoomString_hotfix.call(new object[]
				{
					this,
					userId2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string userId = userId2;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			TeamRoom teamRoom = projectLPlayerContext.GetTeamRoom();
			return teamRoom != null && teamRoom.Players.Find((TeamRoomPlayer x) => x.UserId == userId) != null;
		}

		// Token: 0x06013C1F RID: 80927 RVA: 0x00508E64 File Offset: 0x00507064
		private static int ComparePlayerLevel(UserSummary u1, UserSummary u2)
		{
			int num = u2.Level - u1.Level;
			if (num != 0)
			{
				return num;
			}
			return string.Compare(u1.UserId, u2.UserId);
		}

		// Token: 0x06013C20 RID: 80928 RVA: 0x00508E98 File Offset: 0x00507098
		private void CloseAndReturnPrevUITask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseAndReturnPrevUITask_hotfix != null)
			{
				this.m_CloseAndReturnPrevUITask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_teamRoomInviteUIController.Close(delegate
			{
				base.Pause();
				base.ReturnPrevUITask();
			});
		}

		// Token: 0x06013C21 RID: 80929 RVA: 0x00508F10 File Offset: 0x00507110
		private void UpdateOnlinePlayerStatus(string userId, TeamRoomPlayerInviteState inviteState)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateOnlinePlayerStatusStringTeamRoomPlayerInviteState_hotfix != null)
			{
				this.m_UpdateOnlinePlayerStatusStringTeamRoomPlayerInviteState_hotfix.call(new object[]
				{
					this,
					userId,
					inviteState
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			TeamRoomInviteUITask.OnlinePlayerStatus onlinePlayerStatus = this.GetOnlinePlayerStatus(userId);
			if (onlinePlayerStatus == null)
			{
				onlinePlayerStatus = new TeamRoomInviteUITask.OnlinePlayerStatus();
				onlinePlayerStatus.UserId = userId;
				this.m_onlinePlayersStatus.Add(onlinePlayerStatus);
			}
			onlinePlayerStatus.UpdateTime = DateTime.Now;
			onlinePlayerStatus.InviteState = inviteState;
			this.m_teamRoomInviteUIController.UpdatePlayerStatus(userId, inviteState);
		}

		// Token: 0x06013C22 RID: 80930 RVA: 0x00508FD8 File Offset: 0x005071D8
		private TeamRoomInviteUITask.OnlinePlayerStatus GetOnlinePlayerStatus(string userId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetOnlinePlayerStatusString_hotfix != null)
			{
				return (TeamRoomInviteUITask.OnlinePlayerStatus)this.m_GetOnlinePlayerStatusString_hotfix.call(new object[]
				{
					this,
					userId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (TeamRoomInviteUITask.OnlinePlayerStatus onlinePlayerStatus in this.m_onlinePlayersStatus)
			{
				if (onlinePlayerStatus.UserId == userId)
				{
					return onlinePlayerStatus;
				}
			}
			return null;
		}

		// Token: 0x06013C23 RID: 80931 RVA: 0x005090B8 File Offset: 0x005072B8
		private void TeamRoomInviteUIController_OnConfirm(List<string> playerUserIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeamRoomInviteUIController_OnConfirmList`1_hotfix != null)
			{
				this.m_TeamRoomInviteUIController_OnConfirmList`1_hotfix.call(new object[]
				{
					this,
					playerUserIds
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (playerUserIds.Count > 0)
			{
				TeamRoomInviteNetTask teamRoomInviteNetTask = new TeamRoomInviteNetTask(playerUserIds);
				teamRoomInviteNetTask.EventOnStop += delegate(Task task)
				{
					TeamRoomInviteNetTask teamRoomInviteNetTask2 = task as TeamRoomInviteNetTask;
					if (teamRoomInviteNetTask2.Result == 0)
					{
						this.CloseAndReturnPrevUITask();
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(teamRoomInviteNetTask2.Result, 2f, null, true);
					}
				};
				teamRoomInviteNetTask.Start(null);
			}
		}

		// Token: 0x06013C24 RID: 80932 RVA: 0x00509158 File Offset: 0x00507358
		private void TeamRoomInviteUIController_OnCancel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeamRoomInviteUIController_OnCancel_hotfix != null)
			{
				this.m_TeamRoomInviteUIController_OnCancel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.CloseAndReturnPrevUITask();
		}

		// Token: 0x06013C25 RID: 80933 RVA: 0x005091C0 File Offset: 0x005073C0
		private void TeamRoomInviteUIController_OnChangePlayerType(TeamRoomInvitePlayerType playerType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeamRoomInviteUIController_OnChangePlayerTypeTeamRoomInvitePlayerType_hotfix != null)
			{
				this.m_TeamRoomInviteUIController_OnChangePlayerTypeTeamRoomInvitePlayerType_hotfix.call(new object[]
				{
					this,
					playerType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerType = playerType;
			this.UpdateView();
		}

		// Token: 0x06013C26 RID: 80934 RVA: 0x00509240 File Offset: 0x00507440
		private void PlayerContext_OnTeamRoomInviteeInfoNtf(string inviteeUserId, int levelUnlocked, int guildMassiveCombatAvailable)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnTeamRoomInviteeInfoNtfStringInt32Int32_hotfix != null)
			{
				this.m_PlayerContext_OnTeamRoomInviteeInfoNtfStringInt32Int32_hotfix.call(new object[]
				{
					this,
					inviteeUserId,
					levelUnlocked,
					guildMassiveCombatAvailable
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			TeamRoomPlayerInviteState inviteState = TeamRoomPlayerInviteState.CanInvite;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			TeamRoom teamRoom = projectLPlayerContext.GetTeamRoom();
			if (teamRoom.Setting.GameFunctionTypeId == GameFunctionType.GameFunctionType_GuildMassiveCombat)
			{
				if (guildMassiveCombatAvailable <= 0)
				{
					inviteState = TeamRoomPlayerInviteState.TodayHasNoHero;
				}
			}
			else if (levelUnlocked != 0)
			{
				inviteState = TeamRoomPlayerInviteState.LevelNotOpen;
			}
			this.UpdateOnlinePlayerStatus(inviteeUserId, inviteState);
		}

		// Token: 0x17003B24 RID: 15140
		// (get) Token: 0x06013C27 RID: 80935 RVA: 0x0050931C File Offset: 0x0050751C
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

		// Token: 0x17003B25 RID: 15141
		// (get) Token: 0x06013C28 RID: 80936 RVA: 0x00509390 File Offset: 0x00507590
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

		// Token: 0x17003B26 RID: 15142
		// (get) Token: 0x06013C29 RID: 80937 RVA: 0x00509404 File Offset: 0x00507604
		// (set) Token: 0x06013C2A RID: 80938 RVA: 0x00509424 File Offset: 0x00507624
		[DoNotToLua]
		public new TeamRoomInviteUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new TeamRoomInviteUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06013C2B RID: 80939 RVA: 0x00509430 File Offset: 0x00507630
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x06013C2C RID: 80940 RVA: 0x0050943C File Offset: 0x0050763C
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x06013C2D RID: 80941 RVA: 0x00509444 File Offset: 0x00507644
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x06013C2E RID: 80942 RVA: 0x0050944C File Offset: 0x0050764C
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x06013C2F RID: 80943 RVA: 0x00509458 File Offset: 0x00507658
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x06013C30 RID: 80944 RVA: 0x00509464 File Offset: 0x00507664
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x06013C31 RID: 80945 RVA: 0x00509470 File Offset: 0x00507670
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06013C32 RID: 80946 RVA: 0x00509478 File Offset: 0x00507678
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x06013C33 RID: 80947 RVA: 0x00509480 File Offset: 0x00507680
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x06013C34 RID: 80948 RVA: 0x00509488 File Offset: 0x00507688
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x06013C35 RID: 80949 RVA: 0x00509490 File Offset: 0x00507690
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x06013C36 RID: 80950 RVA: 0x00509498 File Offset: 0x00507698
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x06013C37 RID: 80951 RVA: 0x005094A0 File Offset: 0x005076A0
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x06013C38 RID: 80952 RVA: 0x005094A8 File Offset: 0x005076A8
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x06013C39 RID: 80953 RVA: 0x005094B4 File Offset: 0x005076B4
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x06013C3A RID: 80954 RVA: 0x005094C0 File Offset: 0x005076C0
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x06013C3B RID: 80955 RVA: 0x005094CC File Offset: 0x005076CC
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x06013C3C RID: 80956 RVA: 0x005094D8 File Offset: 0x005076D8
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x06013C3D RID: 80957 RVA: 0x005094E0 File Offset: 0x005076E0
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x06013C3E RID: 80958 RVA: 0x005094E8 File Offset: 0x005076E8
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x06013C3F RID: 80959 RVA: 0x005094F0 File Offset: 0x005076F0
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x06013C40 RID: 80960 RVA: 0x005094F8 File Offset: 0x005076F8
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x06013C41 RID: 80961 RVA: 0x00509500 File Offset: 0x00507700
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x06013C45 RID: 80965 RVA: 0x00509598 File Offset: 0x00507798
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
					this.m_ctorString_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_PrepareForStartOrResumeUIIntentAction`1_hotfix = (luaObj.RawGet("PrepareForStartOrResume") as LuaFunction);
					this.m_GetGuildInfoAction`1_hotfix = (luaObj.RawGet("GetGuildInfo") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_InitTeamRoomInviteUIController_hotfix = (luaObj.RawGet("InitTeamRoomInviteUIController") as LuaFunction);
					this.m_UninitTeamRoomInviteUIController_hotfix = (luaObj.RawGet("UninitTeamRoomInviteUIController") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_StartTeamRoomInviteeInfoGetNetTaskList`1TeamRoomInviteeInfoType_hotfix = (luaObj.RawGet("StartTeamRoomInviteeInfoGetNetTask") as LuaFunction);
					this.m_IsUserInTeamRoomString_hotfix = (luaObj.RawGet("IsUserInTeamRoom") as LuaFunction);
					this.m_CloseAndReturnPrevUITask_hotfix = (luaObj.RawGet("CloseAndReturnPrevUITask") as LuaFunction);
					this.m_UpdateOnlinePlayerStatusStringTeamRoomPlayerInviteState_hotfix = (luaObj.RawGet("UpdateOnlinePlayerStatus") as LuaFunction);
					this.m_GetOnlinePlayerStatusString_hotfix = (luaObj.RawGet("GetOnlinePlayerStatus") as LuaFunction);
					this.m_TeamRoomInviteUIController_OnConfirmList`1_hotfix = (luaObj.RawGet("TeamRoomInviteUIController_OnConfirm") as LuaFunction);
					this.m_TeamRoomInviteUIController_OnCancel_hotfix = (luaObj.RawGet("TeamRoomInviteUIController_OnCancel") as LuaFunction);
					this.m_TeamRoomInviteUIController_OnChangePlayerTypeTeamRoomInvitePlayerType_hotfix = (luaObj.RawGet("TeamRoomInviteUIController_OnChangePlayerType") as LuaFunction);
					this.m_PlayerContext_OnTeamRoomInviteeInfoNtfStringInt32Int32_hotfix = (luaObj.RawGet("PlayerContext_OnTeamRoomInviteeInfoNtf") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06013C46 RID: 80966 RVA: 0x00509828 File Offset: 0x00507A28
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomInviteUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400AEED RID: 44781
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "TeamRoomInviteUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Team_ABS/Prefab/TeamRoomInviteUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400AEEE RID: 44782
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "TeamRoomInviteUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.TeamRoomInviteUIController"),
				m_ctrlName = "TeamRoomInviteUIController"
			}
		};

		// Token: 0x0400AEEF RID: 44783
		private TeamRoomInviteUIController m_teamRoomInviteUIController;

		// Token: 0x0400AEF0 RID: 44784
		private TeamRoomInvitePlayerType m_playerType;

		// Token: 0x0400AEF1 RID: 44785
		private List<UserSummary> m_playerList = new List<UserSummary>();

		// Token: 0x0400AEF2 RID: 44786
		private List<string> m_updateStatusUserIds = new List<string>();

		// Token: 0x0400AEF3 RID: 44787
		private List<TeamRoomInviteUITask.OnlinePlayerStatus> m_onlinePlayersStatus = new List<TeamRoomInviteUITask.OnlinePlayerStatus>();

		// Token: 0x0400AEF4 RID: 44788
		private GameFunctionType m_onlinePlayersStatusGameFunctionType;

		// Token: 0x0400AEF5 RID: 44789
		private int m_onlinePlayersStatusLocationId;

		// Token: 0x0400AEF6 RID: 44790
		[DoNotToLua]
		private TeamRoomInviteUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400AEF7 RID: 44791
		[CompilerGenerated]
		private static Comparison<UserSummary> <>f__mg$cache0;

		// Token: 0x0400AEF9 RID: 44793
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400AEFA RID: 44794
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400AEFB RID: 44795
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400AEFC RID: 44796
		private LuaFunction m_PrepareForStartOrResumeUIIntentAction;

		// Token: 0x0400AEFD RID: 44797
		private LuaFunction m_GetGuildInfoAction;

		// Token: 0x0400AEFE RID: 44798
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400AEFF RID: 44799
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400AF00 RID: 44800
		private LuaFunction m_InitTeamRoomInviteUIController_hotfix;

		// Token: 0x0400AF01 RID: 44801
		private LuaFunction m_UninitTeamRoomInviteUIController_hotfix;

		// Token: 0x0400AF02 RID: 44802
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400AF03 RID: 44803
		private LuaFunction m_StartTeamRoomInviteeInfoGetNetTaskList;

		// Token: 0x0400AF04 RID: 44804
		private LuaFunction m_IsUserInTeamRoomString_hotfix;

		// Token: 0x0400AF05 RID: 44805
		private LuaFunction m_CloseAndReturnPrevUITask_hotfix;

		// Token: 0x0400AF06 RID: 44806
		private LuaFunction m_UpdateOnlinePlayerStatusStringTeamRoomPlayerInviteState_hotfix;

		// Token: 0x0400AF07 RID: 44807
		private LuaFunction m_GetOnlinePlayerStatusString_hotfix;

		// Token: 0x0400AF08 RID: 44808
		private LuaFunction m_TeamRoomInviteUIController_OnConfirmList;

		// Token: 0x0400AF09 RID: 44809
		private LuaFunction m_TeamRoomInviteUIController_OnCancel_hotfix;

		// Token: 0x0400AF0A RID: 44810
		private LuaFunction m_TeamRoomInviteUIController_OnChangePlayerTypeTeamRoomInvitePlayerType_hotfix;

		// Token: 0x0400AF0B RID: 44811
		private LuaFunction m_PlayerContext_OnTeamRoomInviteeInfoNtfStringInt32Int32_hotfix;

		// Token: 0x0400AF0C RID: 44812
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400AF0D RID: 44813
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000F79 RID: 3961
		[HotFix]
		public class OnlinePlayerStatus
		{
			// Token: 0x0400AF0E RID: 44814
			public DateTime UpdateTime;

			// Token: 0x0400AF0F RID: 44815
			public string UserId;

			// Token: 0x0400AF10 RID: 44816
			public TeamRoomPlayerInviteState InviteState;
		}

		// Token: 0x02000F7A RID: 3962
		public new class LuaExportHelper
		{
			// Token: 0x06013C48 RID: 80968 RVA: 0x00509898 File Offset: 0x00507A98
			public LuaExportHelper(TeamRoomInviteUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06013C49 RID: 80969 RVA: 0x005098A8 File Offset: 0x00507AA8
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x06013C4A RID: 80970 RVA: 0x005098B8 File Offset: 0x00507AB8
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x06013C4B RID: 80971 RVA: 0x005098C8 File Offset: 0x00507AC8
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x06013C4C RID: 80972 RVA: 0x005098D8 File Offset: 0x00507AD8
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x06013C4D RID: 80973 RVA: 0x005098E8 File Offset: 0x00507AE8
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x06013C4E RID: 80974 RVA: 0x005098F8 File Offset: 0x00507AF8
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x06013C4F RID: 80975 RVA: 0x00509908 File Offset: 0x00507B08
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x06013C50 RID: 80976 RVA: 0x00509918 File Offset: 0x00507B18
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x06013C51 RID: 80977 RVA: 0x00509928 File Offset: 0x00507B28
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x06013C52 RID: 80978 RVA: 0x00509938 File Offset: 0x00507B38
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x06013C53 RID: 80979 RVA: 0x00509948 File Offset: 0x00507B48
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x06013C54 RID: 80980 RVA: 0x00509958 File Offset: 0x00507B58
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x06013C55 RID: 80981 RVA: 0x00509968 File Offset: 0x00507B68
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x06013C56 RID: 80982 RVA: 0x00509978 File Offset: 0x00507B78
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x06013C57 RID: 80983 RVA: 0x00509988 File Offset: 0x00507B88
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x06013C58 RID: 80984 RVA: 0x00509998 File Offset: 0x00507B98
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x06013C59 RID: 80985 RVA: 0x005099A8 File Offset: 0x00507BA8
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x06013C5A RID: 80986 RVA: 0x005099B8 File Offset: 0x00507BB8
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x06013C5B RID: 80987 RVA: 0x005099C8 File Offset: 0x00507BC8
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x06013C5C RID: 80988 RVA: 0x005099D8 File Offset: 0x00507BD8
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x06013C5D RID: 80989 RVA: 0x005099E8 File Offset: 0x00507BE8
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x06013C5E RID: 80990 RVA: 0x005099F8 File Offset: 0x00507BF8
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x06013C5F RID: 80991 RVA: 0x00509A08 File Offset: 0x00507C08
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x17003B27 RID: 15143
			// (get) Token: 0x06013C60 RID: 80992 RVA: 0x00509A18 File Offset: 0x00507C18
			// (set) Token: 0x06013C61 RID: 80993 RVA: 0x00509A28 File Offset: 0x00507C28
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

			// Token: 0x17003B28 RID: 15144
			// (get) Token: 0x06013C62 RID: 80994 RVA: 0x00509A38 File Offset: 0x00507C38
			// (set) Token: 0x06013C63 RID: 80995 RVA: 0x00509A48 File Offset: 0x00507C48
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

			// Token: 0x17003B29 RID: 15145
			// (get) Token: 0x06013C64 RID: 80996 RVA: 0x00509A58 File Offset: 0x00507C58
			// (set) Token: 0x06013C65 RID: 80997 RVA: 0x00509A68 File Offset: 0x00507C68
			public TeamRoomInviteUIController m_teamRoomInviteUIController
			{
				get
				{
					return this.m_owner.m_teamRoomInviteUIController;
				}
				set
				{
					this.m_owner.m_teamRoomInviteUIController = value;
				}
			}

			// Token: 0x17003B2A RID: 15146
			// (get) Token: 0x06013C66 RID: 80998 RVA: 0x00509A78 File Offset: 0x00507C78
			// (set) Token: 0x06013C67 RID: 80999 RVA: 0x00509A88 File Offset: 0x00507C88
			public TeamRoomInvitePlayerType m_playerType
			{
				get
				{
					return this.m_owner.m_playerType;
				}
				set
				{
					this.m_owner.m_playerType = value;
				}
			}

			// Token: 0x17003B2B RID: 15147
			// (get) Token: 0x06013C68 RID: 81000 RVA: 0x00509A98 File Offset: 0x00507C98
			// (set) Token: 0x06013C69 RID: 81001 RVA: 0x00509AA8 File Offset: 0x00507CA8
			public List<UserSummary> m_playerList
			{
				get
				{
					return this.m_owner.m_playerList;
				}
				set
				{
					this.m_owner.m_playerList = value;
				}
			}

			// Token: 0x17003B2C RID: 15148
			// (get) Token: 0x06013C6A RID: 81002 RVA: 0x00509AB8 File Offset: 0x00507CB8
			// (set) Token: 0x06013C6B RID: 81003 RVA: 0x00509AC8 File Offset: 0x00507CC8
			public List<string> m_updateStatusUserIds
			{
				get
				{
					return this.m_owner.m_updateStatusUserIds;
				}
				set
				{
					this.m_owner.m_updateStatusUserIds = value;
				}
			}

			// Token: 0x17003B2D RID: 15149
			// (get) Token: 0x06013C6C RID: 81004 RVA: 0x00509AD8 File Offset: 0x00507CD8
			// (set) Token: 0x06013C6D RID: 81005 RVA: 0x00509AE8 File Offset: 0x00507CE8
			public List<TeamRoomInviteUITask.OnlinePlayerStatus> m_onlinePlayersStatus
			{
				get
				{
					return this.m_owner.m_onlinePlayersStatus;
				}
				set
				{
					this.m_owner.m_onlinePlayersStatus = value;
				}
			}

			// Token: 0x17003B2E RID: 15150
			// (get) Token: 0x06013C6E RID: 81006 RVA: 0x00509AF8 File Offset: 0x00507CF8
			// (set) Token: 0x06013C6F RID: 81007 RVA: 0x00509B08 File Offset: 0x00507D08
			public GameFunctionType m_onlinePlayersStatusGameFunctionType
			{
				get
				{
					return this.m_owner.m_onlinePlayersStatusGameFunctionType;
				}
				set
				{
					this.m_owner.m_onlinePlayersStatusGameFunctionType = value;
				}
			}

			// Token: 0x17003B2F RID: 15151
			// (get) Token: 0x06013C70 RID: 81008 RVA: 0x00509B18 File Offset: 0x00507D18
			// (set) Token: 0x06013C71 RID: 81009 RVA: 0x00509B28 File Offset: 0x00507D28
			public int m_onlinePlayersStatusLocationId
			{
				get
				{
					return this.m_owner.m_onlinePlayersStatusLocationId;
				}
				set
				{
					this.m_owner.m_onlinePlayersStatusLocationId = value;
				}
			}

			// Token: 0x17003B30 RID: 15152
			// (get) Token: 0x06013C72 RID: 81010 RVA: 0x00509B38 File Offset: 0x00507D38
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17003B31 RID: 15153
			// (get) Token: 0x06013C73 RID: 81011 RVA: 0x00509B48 File Offset: 0x00507D48
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x06013C74 RID: 81012 RVA: 0x00509B58 File Offset: 0x00507D58
			public void GetGuildInfo(Action<bool> onPrepareEnd)
			{
				this.m_owner.GetGuildInfo(onPrepareEnd);
			}

			// Token: 0x06013C75 RID: 81013 RVA: 0x00509B68 File Offset: 0x00507D68
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x06013C76 RID: 81014 RVA: 0x00509B78 File Offset: 0x00507D78
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x06013C77 RID: 81015 RVA: 0x00509B88 File Offset: 0x00507D88
			public void InitTeamRoomInviteUIController()
			{
				this.m_owner.InitTeamRoomInviteUIController();
			}

			// Token: 0x06013C78 RID: 81016 RVA: 0x00509B98 File Offset: 0x00507D98
			public void UninitTeamRoomInviteUIController()
			{
				this.m_owner.UninitTeamRoomInviteUIController();
			}

			// Token: 0x06013C79 RID: 81017 RVA: 0x00509BA8 File Offset: 0x00507DA8
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x06013C7A RID: 81018 RVA: 0x00509BB8 File Offset: 0x00507DB8
			public void StartTeamRoomInviteeInfoGetNetTask(List<string> userIds, TeamRoomInviteeInfoType infoType)
			{
				this.m_owner.StartTeamRoomInviteeInfoGetNetTask(userIds, infoType);
			}

			// Token: 0x06013C7B RID: 81019 RVA: 0x00509BC8 File Offset: 0x00507DC8
			public bool IsUserInTeamRoom(string userId)
			{
				return this.m_owner.IsUserInTeamRoom(userId);
			}

			// Token: 0x06013C7C RID: 81020 RVA: 0x00509BD8 File Offset: 0x00507DD8
			public static int ComparePlayerLevel(UserSummary u1, UserSummary u2)
			{
				return TeamRoomInviteUITask.ComparePlayerLevel(u1, u2);
			}

			// Token: 0x06013C7D RID: 81021 RVA: 0x00509BE4 File Offset: 0x00507DE4
			public void CloseAndReturnPrevUITask()
			{
				this.m_owner.CloseAndReturnPrevUITask();
			}

			// Token: 0x06013C7E RID: 81022 RVA: 0x00509BF4 File Offset: 0x00507DF4
			public void UpdateOnlinePlayerStatus(string userId, TeamRoomPlayerInviteState inviteState)
			{
				this.m_owner.UpdateOnlinePlayerStatus(userId, inviteState);
			}

			// Token: 0x06013C7F RID: 81023 RVA: 0x00509C04 File Offset: 0x00507E04
			public TeamRoomInviteUITask.OnlinePlayerStatus GetOnlinePlayerStatus(string userId)
			{
				return this.m_owner.GetOnlinePlayerStatus(userId);
			}

			// Token: 0x06013C80 RID: 81024 RVA: 0x00509C14 File Offset: 0x00507E14
			public void TeamRoomInviteUIController_OnConfirm(List<string> playerUserIds)
			{
				this.m_owner.TeamRoomInviteUIController_OnConfirm(playerUserIds);
			}

			// Token: 0x06013C81 RID: 81025 RVA: 0x00509C24 File Offset: 0x00507E24
			public void TeamRoomInviteUIController_OnCancel()
			{
				this.m_owner.TeamRoomInviteUIController_OnCancel();
			}

			// Token: 0x06013C82 RID: 81026 RVA: 0x00509C34 File Offset: 0x00507E34
			public void TeamRoomInviteUIController_OnChangePlayerType(TeamRoomInvitePlayerType playerType)
			{
				this.m_owner.TeamRoomInviteUIController_OnChangePlayerType(playerType);
			}

			// Token: 0x06013C83 RID: 81027 RVA: 0x00509C44 File Offset: 0x00507E44
			public void PlayerContext_OnTeamRoomInviteeInfoNtf(string inviteeUserId, int levelUnlocked, int guildMassiveCombatAvailable)
			{
				this.m_owner.PlayerContext_OnTeamRoomInviteeInfoNtf(inviteeUserId, levelUnlocked, guildMassiveCombatAvailable);
			}

			// Token: 0x0400AF11 RID: 44817
			private TeamRoomInviteUITask m_owner;
		}
	}
}
