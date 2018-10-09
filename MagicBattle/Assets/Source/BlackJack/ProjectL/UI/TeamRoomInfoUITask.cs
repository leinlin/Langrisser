using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F6D RID: 3949
	[HotFix]
	public class TeamRoomInfoUITask : UITask
	{
		// Token: 0x06013ACB RID: 80587 RVA: 0x005036F4 File Offset: 0x005018F4
		public TeamRoomInfoUITask(string name) : base(name)
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

		// Token: 0x06013ACC RID: 80588 RVA: 0x0050382C File Offset: 0x00501A2C
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
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			base.ClearAssetList();
			this.m_teamRoomPlayers.Clear();
			this.m_isLeader = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			TeamRoom teamRoom = projectLPlayerContext.GetTeamRoom();
			if (teamRoom != null)
			{
				this.m_teamRoomPlayers.AddRange(teamRoom.Players);
				this.m_isLeader = (teamRoom.Leader != null && projectLPlayerContext.IsMe(teamRoom.Leader.UserId));
				foreach (TeamRoomPlayer teamRoomPlayer in this.m_teamRoomPlayers)
				{
					ConfigDataModelSkinResourceInfo heroModelSkinResourceInfo = BattleUtility.GetHeroModelSkinResourceInfo(configDataLoader, teamRoomPlayer.ModenSkinId, teamRoomPlayer.ActiveHeroJobRelatedId);
					if (heroModelSkinResourceInfo != null)
					{
						base.CollectAsset(heroModelSkinResourceInfo.Model);
					}
					else
					{
						ConfigDataJobConnectionInfo configDataJobConnectionInfo = configDataLoader.GetConfigDataJobConnectionInfo(teamRoomPlayer.ActiveHeroJobRelatedId);
						if (configDataJobConnectionInfo != null)
						{
							base.CollectAsset(configDataJobConnectionInfo.Model);
						}
					}
				}
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06013ACD RID: 80589 RVA: 0x005039B4 File Offset: 0x00501BB4
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
			this.InitTeamRoomInfoUIController();
		}

		// Token: 0x06013ACE RID: 80590 RVA: 0x00503A20 File Offset: 0x00501C20
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
			this.UninitTeamRoomInfoUIController();
		}

		// Token: 0x06013ACF RID: 80591 RVA: 0x00503A8C File Offset: 0x00501C8C
		protected override void RegisterPlayerContextEvents()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RegisterPlayerContextEvents_hotfix != null)
			{
				this.m_RegisterPlayerContextEvents_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.RegisterPlayerContextEvents();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnTeamRoomPlayerJoinNtf += this.PlayerContext_OnTeamRoomPlayerJoinNtf;
				projectLPlayerContext.EventOnTeamRoomPlayerQuitNtf += this.PlayerContext_OnTeamRoomPlayerQuitNtf;
				projectLPlayerContext.EventOnTeamRoomPlayerPositionChangeNtf += this.PlayerContext_OnTeamRoomPlayerPositionChangeNtf;
				projectLPlayerContext.EventOnTeamRoomSelfKickOutNtf += this.PlayerContext_OnTeamRoomSelfKickOutNtf;
				projectLPlayerContext.EventOnTeamRoomAuthorityChangeNtf += this.PlayerContext_OnTeamRoomAuthorityChangeNtf;
				projectLPlayerContext.EventOnTeamRoomInvitationRefusedNtf += this.PlayerContext_OnOnTeamRoomInvitationRefusedNtf;
				projectLPlayerContext.EventOnChatMessageNtf += this.PlayerContext_OnChatMessageNtf;
				projectLPlayerContext.EventOnPlayerInfoInitEnd += this.PlayerContext_OnPlayerInfoInitEnd;
			}
		}

		// Token: 0x06013AD0 RID: 80592 RVA: 0x00503B98 File Offset: 0x00501D98
		protected override void UnregisterPlayerContextEvents()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UnregisterPlayerContextEvents_hotfix != null)
			{
				this.m_UnregisterPlayerContextEvents_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.UnregisterPlayerContextEvents();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnTeamRoomPlayerJoinNtf -= this.PlayerContext_OnTeamRoomPlayerJoinNtf;
				projectLPlayerContext.EventOnTeamRoomPlayerQuitNtf -= this.PlayerContext_OnTeamRoomPlayerQuitNtf;
				projectLPlayerContext.EventOnTeamRoomPlayerPositionChangeNtf -= this.PlayerContext_OnTeamRoomPlayerPositionChangeNtf;
				projectLPlayerContext.EventOnTeamRoomSelfKickOutNtf -= this.PlayerContext_OnTeamRoomSelfKickOutNtf;
				projectLPlayerContext.EventOnTeamRoomAuthorityChangeNtf -= this.PlayerContext_OnTeamRoomAuthorityChangeNtf;
				projectLPlayerContext.EventOnTeamRoomInvitationRefusedNtf -= this.PlayerContext_OnOnTeamRoomInvitationRefusedNtf;
				projectLPlayerContext.EventOnChatMessageNtf -= this.PlayerContext_OnChatMessageNtf;
				projectLPlayerContext.EventOnPlayerInfoInitEnd -= this.PlayerContext_OnPlayerInfoInitEnd;
			}
		}

		// Token: 0x06013AD1 RID: 80593 RVA: 0x00503CA4 File Offset: 0x00501EA4
		private void InitTeamRoomInfoUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitTeamRoomInfoUIController_hotfix != null)
			{
				this.m_InitTeamRoomInfoUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_teamRoomInfoUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_teamRoomInfoUIController = (this.m_uiCtrlArray[0] as TeamRoomInfoUIController);
				}
				if (!(this.m_teamRoomInfoUIController != null))
				{
					global::Debug.LogError("TeamRoomInfoUIController is null");
					return;
				}
				this.m_teamRoomInfoUIController.EventOnLeave += this.TeamRoomInfoUIController_OnLeave;
				this.m_teamRoomInfoUIController.EventOnStart += this.TeamRoomInfoUIController_OnStart;
				this.m_teamRoomInfoUIController.EventOnShowChangePlayerPosition += this.TeamRoomInfoUIController_OnShowChangePlayerPosition;
				this.m_teamRoomInfoUIController.EventOnChangePlayerPositionComplete += this.TeamRoomInfoUIController_OnChangePlayerPositionComplete;
				this.m_teamRoomInfoUIController.EventOnShowChat += this.TeamRoomInfoUIController_OnShowChat;
				this.m_teamRoomInfoUIController.EventOnChangeAuthority += this.TeamRoomInfoUIController_OnChangeAuthority;
				this.m_teamRoomInfoUIController.EventOnShowInvite += this.TeamRoomInfoUIController_OnShowInvite;
				this.m_teamRoomInfoUIController.EventOnShowPlayerInfo += this.TeamRoomInfoUIController_OnShowPlayerInfo;
			}
			if (this.m_playerResourceUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 1)
				{
					this.m_playerResourceUIController = (this.m_uiCtrlArray[1] as PlayerResourceUIController);
				}
				if (!(this.m_playerResourceUIController != null))
				{
					global::Debug.LogError("PlayerResourceUIController is null");
					return;
				}
			}
		}

		// Token: 0x06013AD2 RID: 80594 RVA: 0x00503E64 File Offset: 0x00502064
		private void UninitTeamRoomInfoUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitTeamRoomInfoUIController_hotfix != null)
			{
				this.m_UninitTeamRoomInfoUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_teamRoomInfoUIController != null)
			{
				this.m_teamRoomInfoUIController.EventOnLeave -= this.TeamRoomInfoUIController_OnLeave;
				this.m_teamRoomInfoUIController.EventOnStart -= this.TeamRoomInfoUIController_OnStart;
				this.m_teamRoomInfoUIController.EventOnShowChat -= this.TeamRoomInfoUIController_OnShowChat;
				this.m_teamRoomInfoUIController.EventOnChangeAuthority -= this.TeamRoomInfoUIController_OnChangeAuthority;
				this.m_teamRoomInfoUIController.EventOnShowInvite -= this.TeamRoomInfoUIController_OnShowInvite;
				this.m_teamRoomInfoUIController.EventOnShowPlayerInfo -= this.TeamRoomInfoUIController_OnShowPlayerInfo;
				this.m_teamRoomInfoUIController = null;
			}
			if (this.m_playerResourceUIController != null)
			{
				this.m_playerResourceUIController = null;
			}
		}

		// Token: 0x06013AD3 RID: 80595 RVA: 0x00503F80 File Offset: 0x00502180
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
			if (this.m_teamRoomInfoUIController == null)
			{
				return;
			}
			int second = DateTime.Now.Second;
			if (second != this.m_nowSeconds)
			{
				this.m_nowSeconds = second;
				this.UpdateQuitCountdown();
			}
			CommonUITask.TickCheckOnline();
		}

		// Token: 0x06013AD4 RID: 80596 RVA: 0x00504024 File Offset: 0x00502224
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
				this.m_teamRoomInfoUIController.Open();
				this.m_teamRoomInfoUIController.HideChangePlayerPosition();
				UIUtility.ActivateLayer(this.m_playerResourceUIController, true);
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			TeamRoom teamRoom = projectLPlayerContext.GetTeamRoom();
			if (teamRoom != null)
			{
				this.m_teamRoomInfoUIController.SetTeamRoomSetting(teamRoom.Setting);
				this.m_teamRoomInfoUIController.SetTeamRoomPlayers(this.m_teamRoomPlayers, this.m_isLeader);
				this.UpdateQuitCountdown();
			}
			this.m_playerResourceUIController.UpdatePlayerResource();
		}

		// Token: 0x06013AD5 RID: 80597 RVA: 0x00504108 File Offset: 0x00502308
		private void UpdateQuitCountdown()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateQuitCountdown_hotfix != null)
			{
				this.m_UpdateQuitCountdown_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			TeamRoom teamRoom = projectLPlayerContext.GetTeamRoom();
			if (teamRoom != null)
			{
				TimeSpan quitCountdown = teamRoom.LeaderKickOutTime - projectLPlayerContext.GetServerTime();
				if (quitCountdown.Ticks < 0L)
				{
					quitCountdown = TimeSpan.Zero;
				}
				this.m_teamRoomInfoUIController.SetQuitCountdown(quitCountdown);
			}
		}

		// Token: 0x06013AD6 RID: 80598 RVA: 0x005041B8 File Offset: 0x005023B8
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
			this.m_teamRoomInfoUIController.Close(delegate
			{
				base.Pause();
				base.ReturnPrevUITask();
				if (this.EventOnClose != null)
				{
					this.EventOnClose();
				}
			});
		}

		// Token: 0x06013AD7 RID: 80599 RVA: 0x00504230 File Offset: 0x00502430
		private void StartTeamRoomInviteUITask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartTeamRoomInviteUITask_hotfix != null)
			{
				this.m_StartTeamRoomInviteUITask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable intent = new UIIntentReturnable(this.m_currIntent, typeof(TeamRoomInviteUITask).Name, null);
			UIManager.Instance.StartUITaskWithPrepare(intent, new Action<bool>(this.TeamRoomInviteUITask_OnPrepareEnd), true);
		}

		// Token: 0x06013AD8 RID: 80600 RVA: 0x005042C4 File Offset: 0x005024C4
		private void TeamRoomInviteUITask_OnPrepareEnd(bool ret)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeamRoomInviteUITask_OnPrepareEndBoolean_hotfix != null)
			{
				this.m_TeamRoomInviteUITask_OnPrepareEndBoolean_hotfix.call(new object[]
				{
					this,
					ret
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06013AD9 RID: 80601 RVA: 0x00504334 File Offset: 0x00502534
		private void TeamRoomInfoUIController_OnLeave()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeamRoomInfoUIController_OnLeave_hotfix != null)
			{
				this.m_TeamRoomInfoUIController_OnLeave_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			TeamRoomQuitNetTask teamRoomQuitNetTask = new TeamRoomQuitNetTask();
			teamRoomQuitNetTask.EventOnStop += delegate(Task task)
			{
				TeamRoomQuitNetTask teamRoomQuitNetTask2 = task as TeamRoomQuitNetTask;
				if (teamRoomQuitNetTask2.Result != 0)
				{
					CommonUIController.Instance.ShowErrorMessage(teamRoomQuitNetTask2.Result, 2f, null, true);
				}
				this.CloseAndReturnPrevUITask();
			};
			teamRoomQuitNetTask.Start(null);
		}

		// Token: 0x06013ADA RID: 80602 RVA: 0x005043B4 File Offset: 0x005025B4
		private void TeamRoomInfoUIController_OnStart()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeamRoomInfoUIController_OnStart_hotfix != null)
			{
				this.m_TeamRoomInfoUIController_OnStart_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			TeamBattleRoomCreateNetTask teamBattleRoomCreateNetTask = new TeamBattleRoomCreateNetTask();
			teamBattleRoomCreateNetTask.EventOnStop += delegate(Task task)
			{
				TeamBattleRoomCreateNetTask teamBattleRoomCreateNetTask2 = task as TeamBattleRoomCreateNetTask;
				if (teamBattleRoomCreateNetTask2.Result == 0)
				{
					this.m_teamRoomInfoUIController.ShowWaitStartBattle(true);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(teamBattleRoomCreateNetTask2.Result, 2f, null, true);
				}
			};
			teamBattleRoomCreateNetTask.Start(null);
		}

		// Token: 0x06013ADB RID: 80603 RVA: 0x00504434 File Offset: 0x00502634
		private void TeamRoomInfoUIController_OnShowChangePlayerPosition()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeamRoomInfoUIController_OnShowChangePlayerPosition_hotfix != null)
			{
				this.m_TeamRoomInfoUIController_OnShowChangePlayerPosition_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			TeamRoom teamRoom = projectLPlayerContext.GetTeamRoom();
			if (teamRoom == null)
			{
				return;
			}
			this.m_teamRoomInfoUIController.ShowChangePlayerPosition(teamRoom);
			UIUtility.ActivateLayer(this.m_playerResourceUIController, false);
		}

		// Token: 0x06013ADC RID: 80604 RVA: 0x005044CC File Offset: 0x005026CC
		private void TeamRoomInfoUIController_OnChangePlayerPositionComplete()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeamRoomInfoUIController_OnChangePlayerPositionComplete_hotfix != null)
			{
				this.m_TeamRoomInfoUIController_OnChangePlayerPositionComplete_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_teamRoomInfoUIController.HideChangePlayerPosition();
			UIUtility.ActivateLayer(this.m_playerResourceUIController, true);
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			TeamRoom teamRoom = projectLPlayerContext.GetTeamRoom();
			if (teamRoom == null)
			{
				return;
			}
			List<ProTeamRoomPlayerPositionInfo> list = new List<ProTeamRoomPlayerPositionInfo>();
			foreach (TeamRoomPlayer teamRoomPlayer in this.m_teamRoomPlayers)
			{
				int playerChangedPosition = this.m_teamRoomInfoUIController.GetPlayerChangedPosition(teamRoomPlayer);
				if (playerChangedPosition >= 0 && playerChangedPosition != teamRoomPlayer.Position)
				{
					TeamRoomPlayer teamRoomPlayer2 = teamRoom.FindTeamRoomPlayerAtPosition(playerChangedPosition);
					if (teamRoomPlayer2 == null || this.m_teamRoomInfoUIController.GetPlayerChangedPosition(teamRoomPlayer2) >= 0)
					{
						list.Add(new ProTeamRoomPlayerPositionInfo
						{
							SessionId = teamRoomPlayer.SessionId,
							Position = playerChangedPosition
						});
					}
				}
			}
			if (list.Count > 0)
			{
				TeamRoomPlayerPositionChangeNetTask teamRoomPlayerPositionChangeNetTask = new TeamRoomPlayerPositionChangeNetTask(list);
				teamRoomPlayerPositionChangeNetTask.EventOnStop += delegate(Task task)
				{
					TeamRoomPlayerPositionChangeNetTask teamRoomPlayerPositionChangeNetTask2 = task as TeamRoomPlayerPositionChangeNetTask;
					if (teamRoomPlayerPositionChangeNetTask2.Result != 0)
					{
						CommonUIController.Instance.ShowErrorMessage(teamRoomPlayerPositionChangeNetTask2.Result, 2f, null, true);
					}
				};
				teamRoomPlayerPositionChangeNetTask.Start(null);
			}
		}

		// Token: 0x06013ADD RID: 80605 RVA: 0x00504664 File Offset: 0x00502864
		private void TeamRoomInfoUIController_OnShowChat()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeamRoomInfoUIController_OnShowChat_hotfix != null)
			{
				this.m_TeamRoomInfoUIController_OnShowChat_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ChatChannel channel = ChatChannel.Team;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			TeamRoom teamRoom = projectLPlayerContext.GetTeamRoom();
			if (teamRoom != null && teamRoom.Setting.GameFunctionTypeId == GameFunctionType.GameFunctionType_GuildMassiveCombat)
			{
				channel = ChatChannel.Guild;
			}
			ChatUITask.StartChatUITaskToEnterAppointChannel(channel, this.m_currIntent, string.Empty);
		}

		// Token: 0x06013ADE RID: 80606 RVA: 0x0050470C File Offset: 0x0050290C
		private void TeamRoomInfoUIController_OnChangeAuthority(TeamRoomAuthority authority)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeamRoomInfoUIController_OnChangeAuthorityTeamRoomAuthority_hotfix != null)
			{
				this.m_TeamRoomInfoUIController_OnChangeAuthorityTeamRoomAuthority_hotfix.call(new object[]
				{
					this,
					authority2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			TeamRoomAuthority authority = authority2;
			TeamRoomInfoUITask $this = this;
			TeamRoomAuthorityChangeNetTask teamRoomAuthorityChangeNetTask = new TeamRoomAuthorityChangeNetTask(authority);
			teamRoomAuthorityChangeNetTask.EventOnStop += delegate(Task task)
			{
				TeamRoomAuthorityChangeNetTask teamRoomAuthorityChangeNetTask2 = task as TeamRoomAuthorityChangeNetTask;
				if (teamRoomAuthorityChangeNetTask2.Result == 0)
				{
					$this.m_teamRoomInfoUIController.SetAuthority(authority);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(teamRoomAuthorityChangeNetTask2.Result, 2f, null, true);
				}
			};
			teamRoomAuthorityChangeNetTask.Start(null);
		}

		// Token: 0x06013ADF RID: 80607 RVA: 0x005047B8 File Offset: 0x005029B8
		private void TeamRoomInfoUIController_OnShowInvite()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeamRoomInfoUIController_OnShowInvite_hotfix != null)
			{
				this.m_TeamRoomInfoUIController_OnShowInvite_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartTeamRoomInviteUITask();
		}

		// Token: 0x06013AE0 RID: 80608 RVA: 0x00504820 File Offset: 0x00502A20
		private void TeamRoomInfoUIController_OnShowPlayerInfo(int index, RectTransform rt)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeamRoomInfoUIController_OnShowPlayerInfoInt32RectTransform_hotfix != null)
			{
				this.m_TeamRoomInfoUIController_OnShowPlayerInfoInt32RectTransform_hotfix.call(new object[]
				{
					this,
					index,
					rt2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			RectTransform rt = rt2;
			TeamRoomInfoUITask $this = this;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			TeamRoom teamRoom = projectLPlayerContext.GetTeamRoom();
			if (teamRoom == null)
			{
				return;
			}
			TeamRoomPlayer teamRoomPlayer = teamRoom.FindTeamRoomPlayerAtPosition(index);
			if (teamRoomPlayer == null)
			{
				return;
			}
			if (projectLPlayerContext.IsMe(teamRoomPlayer.UserId))
			{
				return;
			}
			BusinessCardGetNetTask businessCardGetNetTask = new BusinessCardGetNetTask(teamRoomPlayer.UserId);
			businessCardGetNetTask.EventOnStop += delegate(Task task)
			{
				BusinessCardGetNetTask businessCardGetNetTask2 = task as BusinessCardGetNetTask;
				if (businessCardGetNetTask2.Result == 0)
				{
					$this.ShowPlayerSimpleInfo(rt);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(businessCardGetNetTask2.Result, 2f, null, true);
				}
			};
			businessCardGetNetTask.Start(null);
		}

		// Token: 0x06013AE1 RID: 80609 RVA: 0x0050491C File Offset: 0x00502B1C
		private void ShowPlayerSimpleInfo(RectTransform rt)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowPlayerSimpleInfoRectTransform_hotfix != null)
			{
				this.m_ShowPlayerSimpleInfoRectTransform_hotfix.call(new object[]
				{
					this,
					rt
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			PlayerSimpleInfoUITask playerSimpleInfoUITask = PlayerSimpleInfoUITask.ShowPlayerSimpleInfoPanel(rt.position, PlayerSimpleInfoUITask.PostionType.UseInput, this.m_currIntent, false);
			if (this.m_playerSimpleInfoUITask == null)
			{
				this.m_playerSimpleInfoUITask = playerSimpleInfoUITask;
				this.m_playerSimpleInfoUITask.EventOnClose += this.PlayerSimpleInfoUITask_OnClose;
				this.m_playerSimpleInfoUITask.EventOnPrivateChatButtonClick += this.PlayerSimpleInfoUITask_OnPrivateChatButtonClick;
			}
		}

		// Token: 0x06013AE2 RID: 80610 RVA: 0x005049E0 File Offset: 0x00502BE0
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
		}

		// Token: 0x06013AE3 RID: 80611 RVA: 0x00504A80 File Offset: 0x00502C80
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

		// Token: 0x06013AE4 RID: 80612 RVA: 0x00504B04 File Offset: 0x00502D04
		private void PlayerContext_OnTeamRoomPlayerJoinNtf(TeamRoomPlayer player)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnTeamRoomPlayerJoinNtfTeamRoomPlayer_hotfix != null)
			{
				this.m_PlayerContext_OnTeamRoomPlayerJoinNtfTeamRoomPlayer_hotfix.call(new object[]
				{
					this,
					player
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x06013AE5 RID: 80613 RVA: 0x00504B80 File Offset: 0x00502D80
		private void PlayerContext_OnTeamRoomPlayerQuitNtf(TeamRoomPlayer player)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnTeamRoomPlayerQuitNtfTeamRoomPlayer_hotfix != null)
			{
				this.m_PlayerContext_OnTeamRoomPlayerQuitNtfTeamRoomPlayer_hotfix.call(new object[]
				{
					this,
					player
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x06013AE6 RID: 80614 RVA: 0x00504BFC File Offset: 0x00502DFC
		private void PlayerContext_OnTeamRoomPlayerPositionChangeNtf()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnTeamRoomPlayerPositionChangeNtf_hotfix != null)
			{
				this.m_PlayerContext_OnTeamRoomPlayerPositionChangeNtf_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x06013AE7 RID: 80615 RVA: 0x00504C68 File Offset: 0x00502E68
		private void PlayerContext_OnTeamRoomSelfKickOutNtf()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnTeamRoomSelfKickOutNtf_hotfix != null)
			{
				this.m_PlayerContext_OnTeamRoomSelfKickOutNtf_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.CloseAndReturnPrevUITask();
		}

		// Token: 0x06013AE8 RID: 80616 RVA: 0x00504CD0 File Offset: 0x00502ED0
		private void PlayerContext_OnTeamRoomAuthorityChangeNtf(TeamRoomAuthority authority)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnTeamRoomAuthorityChangeNtfTeamRoomAuthority_hotfix != null)
			{
				this.m_PlayerContext_OnTeamRoomAuthorityChangeNtfTeamRoomAuthority_hotfix.call(new object[]
				{
					this,
					authority
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_teamRoomInfoUIController.SetAuthority(authority);
		}

		// Token: 0x06013AE9 RID: 80617 RVA: 0x00504D4C File Offset: 0x00502F4C
		private void PlayerContext_OnOnTeamRoomInvitationRefusedNtf(int result, string inviteeName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnOnTeamRoomInvitationRefusedNtfInt32String_hotfix != null)
			{
				this.m_PlayerContext_OnOnTeamRoomInvitationRefusedNtfInt32String_hotfix.call(new object[]
				{
					this,
					result,
					inviteeName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			string txt = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Team_InvitationRefused), inviteeName);
			CommonUIController.Instance.ShowMessage(txt, 2f, null, false);
		}

		// Token: 0x06013AEA RID: 80618 RVA: 0x00504E00 File Offset: 0x00503000
		private void PlayerContext_OnChatMessageNtf(ChatMessage msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnChatMessageNtfChatMessage_hotfix != null)
			{
				this.m_PlayerContext_OnChatMessageNtfChatMessage_hotfix.call(new object[]
				{
					this,
					msg2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ChatMessage msg = msg2;
			if (msg.ChannelId == ChatChannel.Team && (msg.ChatContentType == ChatContentType.Text || msg.ChatContentType == ChatContentType.CustomBigExpression))
			{
				TeamRoomPlayer teamRoomPlayer = this.m_teamRoomPlayers.Find((TeamRoomPlayer x) => x.UserId == msg.SrcGameUserID);
				if (teamRoomPlayer != null)
				{
					ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
					projectLPlayerContext.GetChatComponent().SetRecentTeamMsgRead();
					if (msg.ChatContentType == ChatContentType.Text)
					{
						ChatTextMessage chatTextMessage = msg as ChatTextMessage;
						this.m_teamRoomInfoUIController.ShowPlayerChat(teamRoomPlayer.Position, chatTextMessage.Text);
					}
					else if (msg.ChatContentType == ChatContentType.CustomBigExpression)
					{
						ChatTextMessage chatTextMessage2 = msg as ChatTextMessage;
						int expressionID = int.Parse(chatTextMessage2.Text);
						this.m_teamRoomInfoUIController.ShowPlayerBigExpression(teamRoomPlayer.Position, expressionID);
					}
				}
			}
		}

		// Token: 0x06013AEB RID: 80619 RVA: 0x00504F60 File Offset: 0x00503160
		private void PlayerContext_OnPlayerInfoInitEnd()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnPlayerInfoInitEnd_hotfix != null)
			{
				this.m_PlayerContext_OnPlayerInfoInitEnd_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (!projectLPlayerContext.IsInBattleRoom())
			{
				if (projectLPlayerContext.IsInTeamRoom())
				{
					TeamRoomGetNetTask teamRoomGetNetTask = new TeamRoomGetNetTask();
					teamRoomGetNetTask.EventOnStop += delegate(Task task)
					{
						TeamRoomGetNetTask teamRoomGetNetTask2 = task as TeamRoomGetNetTask;
						if (teamRoomGetNetTask2.Result == 0)
						{
							base.StartUpdatePipeLine(null, false, false, true);
						}
						else
						{
							CommonUIController.Instance.ShowErrorMessage(teamRoomGetNetTask2.Result, 2f, null, true);
						}
					};
					teamRoomGetNetTask.Start(null);
				}
				else
				{
					this.CloseAndReturnPrevUITask();
				}
			}
		}

		// Token: 0x14000452 RID: 1106
		// (add) Token: 0x06013AEC RID: 80620 RVA: 0x00505018 File Offset: 0x00503218
		// (remove) Token: 0x06013AED RID: 80621 RVA: 0x005050B4 File Offset: 0x005032B4
		public event Action EventOnClose
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCloseAction_hotfix != null)
				{
					this.m_add_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCloseAction_hotfix != null)
				{
					this.m_remove_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003AFD RID: 15101
		// (get) Token: 0x06013AEE RID: 80622 RVA: 0x00505150 File Offset: 0x00503350
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

		// Token: 0x17003AFE RID: 15102
		// (get) Token: 0x06013AEF RID: 80623 RVA: 0x005051C4 File Offset: 0x005033C4
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

		// Token: 0x17003AFF RID: 15103
		// (get) Token: 0x06013AF0 RID: 80624 RVA: 0x00505238 File Offset: 0x00503438
		// (set) Token: 0x06013AF1 RID: 80625 RVA: 0x00505258 File Offset: 0x00503458
		[DoNotToLua]
		public new TeamRoomInfoUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new TeamRoomInfoUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06013AF2 RID: 80626 RVA: 0x00505264 File Offset: 0x00503464
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x06013AF3 RID: 80627 RVA: 0x00505270 File Offset: 0x00503470
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x06013AF4 RID: 80628 RVA: 0x00505278 File Offset: 0x00503478
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x06013AF5 RID: 80629 RVA: 0x00505280 File Offset: 0x00503480
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x06013AF6 RID: 80630 RVA: 0x0050528C File Offset: 0x0050348C
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x06013AF7 RID: 80631 RVA: 0x00505298 File Offset: 0x00503498
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x06013AF8 RID: 80632 RVA: 0x005052A4 File Offset: 0x005034A4
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06013AF9 RID: 80633 RVA: 0x005052AC File Offset: 0x005034AC
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x06013AFA RID: 80634 RVA: 0x005052B4 File Offset: 0x005034B4
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x06013AFB RID: 80635 RVA: 0x005052BC File Offset: 0x005034BC
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x06013AFC RID: 80636 RVA: 0x005052C4 File Offset: 0x005034C4
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x06013AFD RID: 80637 RVA: 0x005052CC File Offset: 0x005034CC
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x06013AFE RID: 80638 RVA: 0x005052D4 File Offset: 0x005034D4
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x06013AFF RID: 80639 RVA: 0x005052DC File Offset: 0x005034DC
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x06013B00 RID: 80640 RVA: 0x005052E8 File Offset: 0x005034E8
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x06013B01 RID: 80641 RVA: 0x005052F4 File Offset: 0x005034F4
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x06013B02 RID: 80642 RVA: 0x00505300 File Offset: 0x00503500
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x06013B03 RID: 80643 RVA: 0x0050530C File Offset: 0x0050350C
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x06013B04 RID: 80644 RVA: 0x00505314 File Offset: 0x00503514
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x06013B05 RID: 80645 RVA: 0x0050531C File Offset: 0x0050351C
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x06013B06 RID: 80646 RVA: 0x00505324 File Offset: 0x00503524
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x06013B07 RID: 80647 RVA: 0x0050532C File Offset: 0x0050352C
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x06013B08 RID: 80648 RVA: 0x00505334 File Offset: 0x00503534
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x06013B09 RID: 80649 RVA: 0x0050533C File Offset: 0x0050353C
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x06013B0A RID: 80650 RVA: 0x0050535C File Offset: 0x0050355C
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x06013B10 RID: 80656 RVA: 0x005054A0 File Offset: 0x005036A0
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
					this.m_RegisterPlayerContextEvents_hotfix = (luaObj.RawGet("RegisterPlayerContextEvents") as LuaFunction);
					this.m_UnregisterPlayerContextEvents_hotfix = (luaObj.RawGet("UnregisterPlayerContextEvents") as LuaFunction);
					this.m_InitTeamRoomInfoUIController_hotfix = (luaObj.RawGet("InitTeamRoomInfoUIController") as LuaFunction);
					this.m_UninitTeamRoomInfoUIController_hotfix = (luaObj.RawGet("UninitTeamRoomInfoUIController") as LuaFunction);
					this.m_OnTick_hotfix = (luaObj.RawGet("OnTick") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_UpdateQuitCountdown_hotfix = (luaObj.RawGet("UpdateQuitCountdown") as LuaFunction);
					this.m_CloseAndReturnPrevUITask_hotfix = (luaObj.RawGet("CloseAndReturnPrevUITask") as LuaFunction);
					this.m_StartTeamRoomInviteUITask_hotfix = (luaObj.RawGet("StartTeamRoomInviteUITask") as LuaFunction);
					this.m_TeamRoomInviteUITask_OnPrepareEndBoolean_hotfix = (luaObj.RawGet("TeamRoomInviteUITask_OnPrepareEnd") as LuaFunction);
					this.m_TeamRoomInfoUIController_OnLeave_hotfix = (luaObj.RawGet("TeamRoomInfoUIController_OnLeave") as LuaFunction);
					this.m_TeamRoomInfoUIController_OnStart_hotfix = (luaObj.RawGet("TeamRoomInfoUIController_OnStart") as LuaFunction);
					this.m_TeamRoomInfoUIController_OnShowChangePlayerPosition_hotfix = (luaObj.RawGet("TeamRoomInfoUIController_OnShowChangePlayerPosition") as LuaFunction);
					this.m_TeamRoomInfoUIController_OnChangePlayerPositionComplete_hotfix = (luaObj.RawGet("TeamRoomInfoUIController_OnChangePlayerPositionComplete") as LuaFunction);
					this.m_TeamRoomInfoUIController_OnShowChat_hotfix = (luaObj.RawGet("TeamRoomInfoUIController_OnShowChat") as LuaFunction);
					this.m_TeamRoomInfoUIController_OnChangeAuthorityTeamRoomAuthority_hotfix = (luaObj.RawGet("TeamRoomInfoUIController_OnChangeAuthority") as LuaFunction);
					this.m_TeamRoomInfoUIController_OnShowInvite_hotfix = (luaObj.RawGet("TeamRoomInfoUIController_OnShowInvite") as LuaFunction);
					this.m_TeamRoomInfoUIController_OnShowPlayerInfoInt32RectTransform_hotfix = (luaObj.RawGet("TeamRoomInfoUIController_OnShowPlayerInfo") as LuaFunction);
					this.m_ShowPlayerSimpleInfoRectTransform_hotfix = (luaObj.RawGet("ShowPlayerSimpleInfo") as LuaFunction);
					this.m_PlayerSimpleInfoUITask_OnClose_hotfix = (luaObj.RawGet("PlayerSimpleInfoUITask_OnClose") as LuaFunction);
					this.m_PlayerSimpleInfoUITask_OnPrivateChatButtonClickBusinessCard_hotfix = (luaObj.RawGet("PlayerSimpleInfoUITask_OnPrivateChatButtonClick") as LuaFunction);
					this.m_PlayerContext_OnTeamRoomPlayerJoinNtfTeamRoomPlayer_hotfix = (luaObj.RawGet("PlayerContext_OnTeamRoomPlayerJoinNtf") as LuaFunction);
					this.m_PlayerContext_OnTeamRoomPlayerQuitNtfTeamRoomPlayer_hotfix = (luaObj.RawGet("PlayerContext_OnTeamRoomPlayerQuitNtf") as LuaFunction);
					this.m_PlayerContext_OnTeamRoomPlayerPositionChangeNtf_hotfix = (luaObj.RawGet("PlayerContext_OnTeamRoomPlayerPositionChangeNtf") as LuaFunction);
					this.m_PlayerContext_OnTeamRoomSelfKickOutNtf_hotfix = (luaObj.RawGet("PlayerContext_OnTeamRoomSelfKickOutNtf") as LuaFunction);
					this.m_PlayerContext_OnTeamRoomAuthorityChangeNtfTeamRoomAuthority_hotfix = (luaObj.RawGet("PlayerContext_OnTeamRoomAuthorityChangeNtf") as LuaFunction);
					this.m_PlayerContext_OnOnTeamRoomInvitationRefusedNtfInt32String_hotfix = (luaObj.RawGet("PlayerContext_OnOnTeamRoomInvitationRefusedNtf") as LuaFunction);
					this.m_PlayerContext_OnChatMessageNtfChatMessage_hotfix = (luaObj.RawGet("PlayerContext_OnChatMessageNtf") as LuaFunction);
					this.m_PlayerContext_OnPlayerInfoInitEnd_hotfix = (luaObj.RawGet("PlayerContext_OnPlayerInfoInitEnd") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06013B11 RID: 80657 RVA: 0x005058F0 File Offset: 0x00503AF0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomInfoUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400AE6A RID: 44650
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "TeamRoomInfoUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Team_ABS/Prefab/TeamRoomInfoUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400AE6B RID: 44651
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "TeamRoomInfoUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.TeamRoomInfoUIController"),
				m_ctrlName = "TeamRoomInfoUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "TeamRoomInfoUILayer",
				m_attachPath = "./PlayerResource",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.PlayerResourceUIController"),
				m_ctrlName = "PlayerResourceUIController"
			}
		};

		// Token: 0x0400AE6C RID: 44652
		private TeamRoomInfoUIController m_teamRoomInfoUIController;

		// Token: 0x0400AE6D RID: 44653
		private PlayerResourceUIController m_playerResourceUIController;

		// Token: 0x0400AE6E RID: 44654
		private int m_nowSeconds;

		// Token: 0x0400AE6F RID: 44655
		private List<TeamRoomPlayer> m_teamRoomPlayers = new List<TeamRoomPlayer>();

		// Token: 0x0400AE70 RID: 44656
		private bool m_isLeader;

		// Token: 0x0400AE71 RID: 44657
		private PlayerSimpleInfoUITask m_playerSimpleInfoUITask;

		// Token: 0x0400AE72 RID: 44658
		[DoNotToLua]
		private TeamRoomInfoUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400AE74 RID: 44660
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400AE75 RID: 44661
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400AE76 RID: 44662
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400AE77 RID: 44663
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x0400AE78 RID: 44664
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400AE79 RID: 44665
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400AE7A RID: 44666
		private LuaFunction m_RegisterPlayerContextEvents_hotfix;

		// Token: 0x0400AE7B RID: 44667
		private LuaFunction m_UnregisterPlayerContextEvents_hotfix;

		// Token: 0x0400AE7C RID: 44668
		private LuaFunction m_InitTeamRoomInfoUIController_hotfix;

		// Token: 0x0400AE7D RID: 44669
		private LuaFunction m_UninitTeamRoomInfoUIController_hotfix;

		// Token: 0x0400AE7E RID: 44670
		private LuaFunction m_OnTick_hotfix;

		// Token: 0x0400AE7F RID: 44671
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400AE80 RID: 44672
		private LuaFunction m_UpdateQuitCountdown_hotfix;

		// Token: 0x0400AE81 RID: 44673
		private LuaFunction m_CloseAndReturnPrevUITask_hotfix;

		// Token: 0x0400AE82 RID: 44674
		private LuaFunction m_StartTeamRoomInviteUITask_hotfix;

		// Token: 0x0400AE83 RID: 44675
		private LuaFunction m_TeamRoomInviteUITask_OnPrepareEndBoolean_hotfix;

		// Token: 0x0400AE84 RID: 44676
		private LuaFunction m_TeamRoomInfoUIController_OnLeave_hotfix;

		// Token: 0x0400AE85 RID: 44677
		private LuaFunction m_TeamRoomInfoUIController_OnStart_hotfix;

		// Token: 0x0400AE86 RID: 44678
		private LuaFunction m_TeamRoomInfoUIController_OnShowChangePlayerPosition_hotfix;

		// Token: 0x0400AE87 RID: 44679
		private LuaFunction m_TeamRoomInfoUIController_OnChangePlayerPositionComplete_hotfix;

		// Token: 0x0400AE88 RID: 44680
		private LuaFunction m_TeamRoomInfoUIController_OnShowChat_hotfix;

		// Token: 0x0400AE89 RID: 44681
		private LuaFunction m_TeamRoomInfoUIController_OnChangeAuthorityTeamRoomAuthority_hotfix;

		// Token: 0x0400AE8A RID: 44682
		private LuaFunction m_TeamRoomInfoUIController_OnShowInvite_hotfix;

		// Token: 0x0400AE8B RID: 44683
		private LuaFunction m_TeamRoomInfoUIController_OnShowPlayerInfoInt32RectTransform_hotfix;

		// Token: 0x0400AE8C RID: 44684
		private LuaFunction m_ShowPlayerSimpleInfoRectTransform_hotfix;

		// Token: 0x0400AE8D RID: 44685
		private LuaFunction m_PlayerSimpleInfoUITask_OnClose_hotfix;

		// Token: 0x0400AE8E RID: 44686
		private LuaFunction m_PlayerSimpleInfoUITask_OnPrivateChatButtonClickBusinessCard_hotfix;

		// Token: 0x0400AE8F RID: 44687
		private LuaFunction m_PlayerContext_OnTeamRoomPlayerJoinNtfTeamRoomPlayer_hotfix;

		// Token: 0x0400AE90 RID: 44688
		private LuaFunction m_PlayerContext_OnTeamRoomPlayerQuitNtfTeamRoomPlayer_hotfix;

		// Token: 0x0400AE91 RID: 44689
		private LuaFunction m_PlayerContext_OnTeamRoomPlayerPositionChangeNtf_hotfix;

		// Token: 0x0400AE92 RID: 44690
		private LuaFunction m_PlayerContext_OnTeamRoomSelfKickOutNtf_hotfix;

		// Token: 0x0400AE93 RID: 44691
		private LuaFunction m_PlayerContext_OnTeamRoomAuthorityChangeNtfTeamRoomAuthority_hotfix;

		// Token: 0x0400AE94 RID: 44692
		private LuaFunction m_PlayerContext_OnOnTeamRoomInvitationRefusedNtfInt32String_hotfix;

		// Token: 0x0400AE95 RID: 44693
		private LuaFunction m_PlayerContext_OnChatMessageNtfChatMessage_hotfix;

		// Token: 0x0400AE96 RID: 44694
		private LuaFunction m_PlayerContext_OnPlayerInfoInitEnd_hotfix;

		// Token: 0x0400AE97 RID: 44695
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x0400AE98 RID: 44696
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x0400AE99 RID: 44697
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400AE9A RID: 44698
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000F6E RID: 3950
		public new class LuaExportHelper
		{
			// Token: 0x06013B12 RID: 80658 RVA: 0x00505958 File Offset: 0x00503B58
			public LuaExportHelper(TeamRoomInfoUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06013B13 RID: 80659 RVA: 0x00505968 File Offset: 0x00503B68
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x06013B14 RID: 80660 RVA: 0x00505978 File Offset: 0x00503B78
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x06013B15 RID: 80661 RVA: 0x00505988 File Offset: 0x00503B88
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x06013B16 RID: 80662 RVA: 0x00505998 File Offset: 0x00503B98
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x06013B17 RID: 80663 RVA: 0x005059A8 File Offset: 0x00503BA8
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x06013B18 RID: 80664 RVA: 0x005059B8 File Offset: 0x00503BB8
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x06013B19 RID: 80665 RVA: 0x005059C8 File Offset: 0x00503BC8
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x06013B1A RID: 80666 RVA: 0x005059D8 File Offset: 0x00503BD8
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x06013B1B RID: 80667 RVA: 0x005059E8 File Offset: 0x00503BE8
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x06013B1C RID: 80668 RVA: 0x005059F8 File Offset: 0x00503BF8
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x06013B1D RID: 80669 RVA: 0x00505A08 File Offset: 0x00503C08
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x06013B1E RID: 80670 RVA: 0x00505A18 File Offset: 0x00503C18
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x06013B1F RID: 80671 RVA: 0x00505A28 File Offset: 0x00503C28
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x06013B20 RID: 80672 RVA: 0x00505A38 File Offset: 0x00503C38
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x06013B21 RID: 80673 RVA: 0x00505A48 File Offset: 0x00503C48
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x06013B22 RID: 80674 RVA: 0x00505A58 File Offset: 0x00503C58
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x06013B23 RID: 80675 RVA: 0x00505A68 File Offset: 0x00503C68
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x06013B24 RID: 80676 RVA: 0x00505A78 File Offset: 0x00503C78
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x06013B25 RID: 80677 RVA: 0x00505A88 File Offset: 0x00503C88
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x06013B26 RID: 80678 RVA: 0x00505A98 File Offset: 0x00503C98
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x06013B27 RID: 80679 RVA: 0x00505AA8 File Offset: 0x00503CA8
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x06013B28 RID: 80680 RVA: 0x00505AB8 File Offset: 0x00503CB8
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x06013B29 RID: 80681 RVA: 0x00505AC8 File Offset: 0x00503CC8
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x06013B2A RID: 80682 RVA: 0x00505AD8 File Offset: 0x00503CD8
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x06013B2B RID: 80683 RVA: 0x00505AE8 File Offset: 0x00503CE8
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x17003B00 RID: 15104
			// (get) Token: 0x06013B2C RID: 80684 RVA: 0x00505AF8 File Offset: 0x00503CF8
			// (set) Token: 0x06013B2D RID: 80685 RVA: 0x00505B08 File Offset: 0x00503D08
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

			// Token: 0x17003B01 RID: 15105
			// (get) Token: 0x06013B2E RID: 80686 RVA: 0x00505B18 File Offset: 0x00503D18
			// (set) Token: 0x06013B2F RID: 80687 RVA: 0x00505B28 File Offset: 0x00503D28
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

			// Token: 0x17003B02 RID: 15106
			// (get) Token: 0x06013B30 RID: 80688 RVA: 0x00505B38 File Offset: 0x00503D38
			// (set) Token: 0x06013B31 RID: 80689 RVA: 0x00505B48 File Offset: 0x00503D48
			public TeamRoomInfoUIController m_teamRoomInfoUIController
			{
				get
				{
					return this.m_owner.m_teamRoomInfoUIController;
				}
				set
				{
					this.m_owner.m_teamRoomInfoUIController = value;
				}
			}

			// Token: 0x17003B03 RID: 15107
			// (get) Token: 0x06013B32 RID: 80690 RVA: 0x00505B58 File Offset: 0x00503D58
			// (set) Token: 0x06013B33 RID: 80691 RVA: 0x00505B68 File Offset: 0x00503D68
			public PlayerResourceUIController m_playerResourceUIController
			{
				get
				{
					return this.m_owner.m_playerResourceUIController;
				}
				set
				{
					this.m_owner.m_playerResourceUIController = value;
				}
			}

			// Token: 0x17003B04 RID: 15108
			// (get) Token: 0x06013B34 RID: 80692 RVA: 0x00505B78 File Offset: 0x00503D78
			// (set) Token: 0x06013B35 RID: 80693 RVA: 0x00505B88 File Offset: 0x00503D88
			public int m_nowSeconds
			{
				get
				{
					return this.m_owner.m_nowSeconds;
				}
				set
				{
					this.m_owner.m_nowSeconds = value;
				}
			}

			// Token: 0x17003B05 RID: 15109
			// (get) Token: 0x06013B36 RID: 80694 RVA: 0x00505B98 File Offset: 0x00503D98
			// (set) Token: 0x06013B37 RID: 80695 RVA: 0x00505BA8 File Offset: 0x00503DA8
			public List<TeamRoomPlayer> m_teamRoomPlayers
			{
				get
				{
					return this.m_owner.m_teamRoomPlayers;
				}
				set
				{
					this.m_owner.m_teamRoomPlayers = value;
				}
			}

			// Token: 0x17003B06 RID: 15110
			// (get) Token: 0x06013B38 RID: 80696 RVA: 0x00505BB8 File Offset: 0x00503DB8
			// (set) Token: 0x06013B39 RID: 80697 RVA: 0x00505BC8 File Offset: 0x00503DC8
			public bool m_isLeader
			{
				get
				{
					return this.m_owner.m_isLeader;
				}
				set
				{
					this.m_owner.m_isLeader = value;
				}
			}

			// Token: 0x17003B07 RID: 15111
			// (get) Token: 0x06013B3A RID: 80698 RVA: 0x00505BD8 File Offset: 0x00503DD8
			// (set) Token: 0x06013B3B RID: 80699 RVA: 0x00505BE8 File Offset: 0x00503DE8
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

			// Token: 0x17003B08 RID: 15112
			// (get) Token: 0x06013B3C RID: 80700 RVA: 0x00505BF8 File Offset: 0x00503DF8
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17003B09 RID: 15113
			// (get) Token: 0x06013B3D RID: 80701 RVA: 0x00505C08 File Offset: 0x00503E08
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x06013B3E RID: 80702 RVA: 0x00505C18 File Offset: 0x00503E18
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x06013B3F RID: 80703 RVA: 0x00505C28 File Offset: 0x00503E28
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x06013B40 RID: 80704 RVA: 0x00505C38 File Offset: 0x00503E38
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x06013B41 RID: 80705 RVA: 0x00505C48 File Offset: 0x00503E48
			public void RegisterPlayerContextEvents()
			{
				this.m_owner.RegisterPlayerContextEvents();
			}

			// Token: 0x06013B42 RID: 80706 RVA: 0x00505C58 File Offset: 0x00503E58
			public void UnregisterPlayerContextEvents()
			{
				this.m_owner.UnregisterPlayerContextEvents();
			}

			// Token: 0x06013B43 RID: 80707 RVA: 0x00505C68 File Offset: 0x00503E68
			public void InitTeamRoomInfoUIController()
			{
				this.m_owner.InitTeamRoomInfoUIController();
			}

			// Token: 0x06013B44 RID: 80708 RVA: 0x00505C78 File Offset: 0x00503E78
			public void UninitTeamRoomInfoUIController()
			{
				this.m_owner.UninitTeamRoomInfoUIController();
			}

			// Token: 0x06013B45 RID: 80709 RVA: 0x00505C88 File Offset: 0x00503E88
			public void OnTick()
			{
				this.m_owner.OnTick();
			}

			// Token: 0x06013B46 RID: 80710 RVA: 0x00505C98 File Offset: 0x00503E98
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x06013B47 RID: 80711 RVA: 0x00505CA8 File Offset: 0x00503EA8
			public void UpdateQuitCountdown()
			{
				this.m_owner.UpdateQuitCountdown();
			}

			// Token: 0x06013B48 RID: 80712 RVA: 0x00505CB8 File Offset: 0x00503EB8
			public void CloseAndReturnPrevUITask()
			{
				this.m_owner.CloseAndReturnPrevUITask();
			}

			// Token: 0x06013B49 RID: 80713 RVA: 0x00505CC8 File Offset: 0x00503EC8
			public void StartTeamRoomInviteUITask()
			{
				this.m_owner.StartTeamRoomInviteUITask();
			}

			// Token: 0x06013B4A RID: 80714 RVA: 0x00505CD8 File Offset: 0x00503ED8
			public void TeamRoomInviteUITask_OnPrepareEnd(bool ret)
			{
				this.m_owner.TeamRoomInviteUITask_OnPrepareEnd(ret);
			}

			// Token: 0x06013B4B RID: 80715 RVA: 0x00505CE8 File Offset: 0x00503EE8
			public void TeamRoomInfoUIController_OnLeave()
			{
				this.m_owner.TeamRoomInfoUIController_OnLeave();
			}

			// Token: 0x06013B4C RID: 80716 RVA: 0x00505CF8 File Offset: 0x00503EF8
			public void TeamRoomInfoUIController_OnStart()
			{
				this.m_owner.TeamRoomInfoUIController_OnStart();
			}

			// Token: 0x06013B4D RID: 80717 RVA: 0x00505D08 File Offset: 0x00503F08
			public void TeamRoomInfoUIController_OnShowChangePlayerPosition()
			{
				this.m_owner.TeamRoomInfoUIController_OnShowChangePlayerPosition();
			}

			// Token: 0x06013B4E RID: 80718 RVA: 0x00505D18 File Offset: 0x00503F18
			public void TeamRoomInfoUIController_OnChangePlayerPositionComplete()
			{
				this.m_owner.TeamRoomInfoUIController_OnChangePlayerPositionComplete();
			}

			// Token: 0x06013B4F RID: 80719 RVA: 0x00505D28 File Offset: 0x00503F28
			public void TeamRoomInfoUIController_OnShowChat()
			{
				this.m_owner.TeamRoomInfoUIController_OnShowChat();
			}

			// Token: 0x06013B50 RID: 80720 RVA: 0x00505D38 File Offset: 0x00503F38
			public void TeamRoomInfoUIController_OnChangeAuthority(TeamRoomAuthority authority)
			{
				this.m_owner.TeamRoomInfoUIController_OnChangeAuthority(authority);
			}

			// Token: 0x06013B51 RID: 80721 RVA: 0x00505D48 File Offset: 0x00503F48
			public void TeamRoomInfoUIController_OnShowInvite()
			{
				this.m_owner.TeamRoomInfoUIController_OnShowInvite();
			}

			// Token: 0x06013B52 RID: 80722 RVA: 0x00505D58 File Offset: 0x00503F58
			public void TeamRoomInfoUIController_OnShowPlayerInfo(int index, RectTransform rt)
			{
				this.m_owner.TeamRoomInfoUIController_OnShowPlayerInfo(index, rt);
			}

			// Token: 0x06013B53 RID: 80723 RVA: 0x00505D68 File Offset: 0x00503F68
			public void ShowPlayerSimpleInfo(RectTransform rt)
			{
				this.m_owner.ShowPlayerSimpleInfo(rt);
			}

			// Token: 0x06013B54 RID: 80724 RVA: 0x00505D78 File Offset: 0x00503F78
			public void PlayerSimpleInfoUITask_OnClose()
			{
				this.m_owner.PlayerSimpleInfoUITask_OnClose();
			}

			// Token: 0x06013B55 RID: 80725 RVA: 0x00505D88 File Offset: 0x00503F88
			public void PlayerSimpleInfoUITask_OnPrivateChatButtonClick(BusinessCard playerInfo)
			{
				this.m_owner.PlayerSimpleInfoUITask_OnPrivateChatButtonClick(playerInfo);
			}

			// Token: 0x06013B56 RID: 80726 RVA: 0x00505D98 File Offset: 0x00503F98
			public void PlayerContext_OnTeamRoomPlayerJoinNtf(TeamRoomPlayer player)
			{
				this.m_owner.PlayerContext_OnTeamRoomPlayerJoinNtf(player);
			}

			// Token: 0x06013B57 RID: 80727 RVA: 0x00505DA8 File Offset: 0x00503FA8
			public void PlayerContext_OnTeamRoomPlayerQuitNtf(TeamRoomPlayer player)
			{
				this.m_owner.PlayerContext_OnTeamRoomPlayerQuitNtf(player);
			}

			// Token: 0x06013B58 RID: 80728 RVA: 0x00505DB8 File Offset: 0x00503FB8
			public void PlayerContext_OnTeamRoomPlayerPositionChangeNtf()
			{
				this.m_owner.PlayerContext_OnTeamRoomPlayerPositionChangeNtf();
			}

			// Token: 0x06013B59 RID: 80729 RVA: 0x00505DC8 File Offset: 0x00503FC8
			public void PlayerContext_OnTeamRoomSelfKickOutNtf()
			{
				this.m_owner.PlayerContext_OnTeamRoomSelfKickOutNtf();
			}

			// Token: 0x06013B5A RID: 80730 RVA: 0x00505DD8 File Offset: 0x00503FD8
			public void PlayerContext_OnTeamRoomAuthorityChangeNtf(TeamRoomAuthority authority)
			{
				this.m_owner.PlayerContext_OnTeamRoomAuthorityChangeNtf(authority);
			}

			// Token: 0x06013B5B RID: 80731 RVA: 0x00505DE8 File Offset: 0x00503FE8
			public void PlayerContext_OnOnTeamRoomInvitationRefusedNtf(int result, string inviteeName)
			{
				this.m_owner.PlayerContext_OnOnTeamRoomInvitationRefusedNtf(result, inviteeName);
			}

			// Token: 0x06013B5C RID: 80732 RVA: 0x00505DF8 File Offset: 0x00503FF8
			public void PlayerContext_OnChatMessageNtf(ChatMessage msg)
			{
				this.m_owner.PlayerContext_OnChatMessageNtf(msg);
			}

			// Token: 0x06013B5D RID: 80733 RVA: 0x00505E08 File Offset: 0x00504008
			public void PlayerContext_OnPlayerInfoInitEnd()
			{
				this.m_owner.PlayerContext_OnPlayerInfoInitEnd();
			}

			// Token: 0x0400AE9B RID: 44699
			private TeamRoomInfoUITask m_owner;
		}
	}
}
