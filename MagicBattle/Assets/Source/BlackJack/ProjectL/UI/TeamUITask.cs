using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Scene;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectLBasic;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F86 RID: 3974
	[HotFix]
	public class TeamUITask : UITask
	{
		// Token: 0x06013E2F RID: 81455 RVA: 0x005103BC File Offset: 0x0050E5BC
		public TeamUITask(string name) : base(name)
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

		// Token: 0x06013E30 RID: 81456 RVA: 0x00510564 File Offset: 0x0050E764
		public static UIIntentReturnable CreateIntent(UIIntent fromIntent, GameFunctionType gameFunctionType = GameFunctionType.GameFunctionType_None, int chapterId = 0, int locationId = 0)
		{
			UIIntentReturnable uiintentReturnable = new UIIntentReturnable(fromIntent, typeof(TeamUITask).Name, null);
			uiintentReturnable.SetParam("GameFunctionType", gameFunctionType);
			uiintentReturnable.SetParam("ChapterId", chapterId);
			uiintentReturnable.SetParam("LocationId", locationId);
			return uiintentReturnable;
		}

		// Token: 0x06013E31 RID: 81457 RVA: 0x005105BC File Offset: 0x0050E7BC
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
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06013E32 RID: 81458 RVA: 0x00510630 File Offset: 0x0050E830
		protected override void InitLayerStateOnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitLayerStateOnLoadAllResCompleted_hotfix != null)
			{
				this.m_InitLayerStateOnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.InitLayerStateOnLoadAllResCompleted();
			foreach (SceneLayerBase sceneLayerBase in this.m_layerArray)
			{
				if (sceneLayerBase.State != SceneLayerBase.LayerState.InStack)
				{
					SceneManager.Instance.PushLayer(sceneLayerBase);
				}
			}
		}

		// Token: 0x06013E33 RID: 81459 RVA: 0x005106D0 File Offset: 0x0050E8D0
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
			this.InitTeamUIController();
			this.InitCreateTeamRoomUIController();
			UIUtility.ActivateLayer(this.m_createTeamRoomUIController, false);
		}

		// Token: 0x06013E34 RID: 81460 RVA: 0x00510750 File Offset: 0x0050E950
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
			this.UninitTeamUIController();
			this.UninitCreateTeamRoomUIController();
		}

		// Token: 0x06013E35 RID: 81461 RVA: 0x005107C4 File Offset: 0x0050E9C4
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
				projectLPlayerContext.EventOnTeamRoomPlayerLeaveWaitingListAndJoinRoomNtf += this.PlayerContext_OnTeamRoomPlayerLeaveWaitingListAndJoinRoomNtf;
				projectLPlayerContext.EventOnTeamRoomAutoMatchInfoNtf += this.PlayerContext_OnTeamRoomAutoMatchInfoNtf;
				projectLPlayerContext.EventOnPlayerInfoInitEnd += this.PlayerContext_OnPlayerInfoInitEnd;
			}
		}

		// Token: 0x06013E36 RID: 81462 RVA: 0x00510878 File Offset: 0x0050EA78
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
				projectLPlayerContext.EventOnTeamRoomPlayerLeaveWaitingListAndJoinRoomNtf -= this.PlayerContext_OnTeamRoomPlayerLeaveWaitingListAndJoinRoomNtf;
				projectLPlayerContext.EventOnTeamRoomAutoMatchInfoNtf -= this.PlayerContext_OnTeamRoomAutoMatchInfoNtf;
				projectLPlayerContext.EventOnPlayerInfoInitEnd -= this.PlayerContext_OnPlayerInfoInitEnd;
			}
		}

		// Token: 0x06013E37 RID: 81463 RVA: 0x0051092C File Offset: 0x0050EB2C
		private void InitTeamUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitTeamUIController_hotfix != null)
			{
				this.m_InitTeamUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_teamUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_teamUIController = (this.m_uiCtrlArray[0] as TeamUIController);
				}
				if (!(this.m_teamUIController != null))
				{
					Debug.LogError("TeamUIController is null");
					return;
				}
				this.m_teamUIController.EventOnReturn += this.TeamUIController_OnReturn;
				this.m_teamUIController.EventOnShowHelp += this.TeamUIController_OnShowHelp;
				this.m_teamUIController.EventOnRefreshTeamRoom += this.TeamUIController_OnRefreshTeamRoom;
				this.m_teamUIController.EventOnShowCreateTeamRoom += this.TeamUIController_OnShowCreateTeamRoom;
				this.m_teamUIController.EventOnAutoMatch += this.TeamUIController_OnAutoMatch;
				this.m_teamUIController.EventOnAutoMatchCancel += this.TeamUIController_OnAutoMatchCancel;
				this.m_teamUIController.EventOnSelectGameFunctionTypeAndLocation += this.TeamUIController_OnSelectGameFunctionTypeAndLocation;
				this.m_teamUIController.EventOnJoinTeamRoom += this.TeamUIController_OnJoinTeamRoom;
			}
			if (this.m_playerResourceUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 1)
				{
					this.m_playerResourceUIController = (this.m_uiCtrlArray[1] as PlayerResourceUIController);
				}
				if (!(this.m_playerResourceUIController != null))
				{
					Debug.LogError("PlayerResourceUIController is null");
					return;
				}
			}
		}

		// Token: 0x06013E38 RID: 81464 RVA: 0x00510AEC File Offset: 0x0050ECEC
		private void UninitTeamUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitTeamUIController_hotfix != null)
			{
				this.m_UninitTeamUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_teamUIController != null)
			{
				this.m_teamUIController.EventOnReturn -= this.TeamUIController_OnReturn;
				this.m_teamUIController.EventOnShowHelp -= this.TeamUIController_OnShowHelp;
				this.m_teamUIController.EventOnRefreshTeamRoom -= this.TeamUIController_OnRefreshTeamRoom;
				this.m_teamUIController.EventOnShowCreateTeamRoom -= this.TeamUIController_OnShowCreateTeamRoom;
				this.m_teamUIController.EventOnAutoMatch -= this.TeamUIController_OnAutoMatch;
				this.m_teamUIController.EventOnAutoMatchCancel -= this.TeamUIController_OnAutoMatchCancel;
				this.m_teamUIController.EventOnSelectGameFunctionTypeAndLocation -= this.TeamUIController_OnSelectGameFunctionTypeAndLocation;
				this.m_teamUIController.EventOnJoinTeamRoom -= this.TeamUIController_OnJoinTeamRoom;
				this.m_teamUIController = null;
			}
			if (this.m_playerResourceUIController != null)
			{
				this.m_playerResourceUIController = null;
			}
		}

		// Token: 0x06013E39 RID: 81465 RVA: 0x00510C34 File Offset: 0x0050EE34
		private void InitCreateTeamRoomUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitCreateTeamRoomUIController_hotfix != null)
			{
				this.m_InitCreateTeamRoomUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_createTeamRoomUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 2)
				{
					this.m_createTeamRoomUIController = (this.m_uiCtrlArray[2] as CreateTeamRoomUIController);
				}
				if (!(this.m_createTeamRoomUIController != null))
				{
					Debug.LogError("CreateTeamRoomUIController is null");
					return;
				}
				this.m_createTeamRoomUIController.EventOnCreateTeamRoom += this.CreateTeamRoomUIController_OnCreateTeamRoom;
			}
		}

		// Token: 0x06013E3A RID: 81466 RVA: 0x00510D00 File Offset: 0x0050EF00
		private void UninitCreateTeamRoomUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitCreateTeamRoomUIController_hotfix != null)
			{
				this.m_UninitCreateTeamRoomUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_createTeamRoomUIController != null)
			{
				this.m_createTeamRoomUIController.EventOnCreateTeamRoom -= this.CreateTeamRoomUIController_OnCreateTeamRoom;
				this.m_createTeamRoomUIController = null;
			}
		}

		// Token: 0x06013E3B RID: 81467 RVA: 0x00510D90 File Offset: 0x0050EF90
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
				this.m_teamUIController.Open();
				GameFunctionType gameFunctionType = GameFunctionType.GameFunctionType_None;
				int chapterId = 0;
				int locationId = 0;
				UIIntentCustom uiintentCustom = this.m_currIntent as UIIntentCustom;
				if (uiintentCustom != null)
				{
					gameFunctionType = uiintentCustom.GetStructParam<GameFunctionType>("GameFunctionType");
					chapterId = uiintentCustom.GetStructParam<int>("ChapterId");
					locationId = uiintentCustom.GetStructParam<int>("LocationId");
				}
				this.m_teamUIController.SelectGameFunctionTypeAndLocation(gameFunctionType, chapterId, locationId);
				this.CheckTeamRoomInviteAgain();
			}
			this.m_playerResourceUIController.UpdatePlayerResource();
		}

		// Token: 0x06013E3C RID: 81468 RVA: 0x00510E64 File Offset: 0x0050F064
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
			if (this.m_teamUIController == null)
			{
				return;
			}
			if (this.m_teamUIController.IsAutoMatching())
			{
				CommonUITask.TickCheckOnline();
			}
		}

		// Token: 0x06013E3D RID: 81469 RVA: 0x00510EF4 File Offset: 0x0050F0F4
		private void StartTeamRoomInviteNetTask(List<string> userIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartTeamRoomInviteNetTaskList`1_hotfix != null)
			{
				this.m_StartTeamRoomInviteNetTaskList`1_hotfix.call(new object[]
				{
					this,
					userIds
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			TeamRoomInviteNetTask teamRoomInviteNetTask = new TeamRoomInviteNetTask(userIds);
			teamRoomInviteNetTask.EventOnStop += delegate(Task task)
			{
				TeamRoomInviteNetTask teamRoomInviteNetTask2 = task as TeamRoomInviteNetTask;
				if (teamRoomInviteNetTask2.Result != 0)
				{
					CommonUIController.Instance.ShowErrorMessage(teamRoomInviteNetTask2.Result, 2f, null, true);
				}
			};
			teamRoomInviteNetTask.Start(null);
		}

		// Token: 0x06013E3E RID: 81470 RVA: 0x00510F98 File Offset: 0x0050F198
		private bool CheckTeamRoomInviteAgain()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckTeamRoomInviteAgain_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CheckTeamRoomInviteAgain_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (!playerContext.IsTeamRoomInviteAgain())
			{
				return false;
			}
			TeamRoom teamRoom = playerContext.GetTeamRoom();
			if (teamRoom != null)
			{
				TeamRoomCreateNetTask teamRoomCreateNetTask = new TeamRoomCreateNetTask(teamRoom.Setting);
				teamRoomCreateNetTask.EventOnStop += delegate(Task task)
				{
					TeamRoomCreateNetTask teamRoomCreateNetTask2 = task as TeamRoomCreateNetTask;
					if (teamRoomCreateNetTask2.Result == 0)
					{
						this.StartTeamRoomInfoUITask();
						List<string> list = new List<string>();
						foreach (TeamRoomPlayer teamRoomPlayer in teamRoom.Players)
						{
							if (teamRoomPlayer.SessionId != 0UL)
							{
								if (!playerContext.IsMe(teamRoomPlayer.UserId))
								{
									list.Add(teamRoomPlayer.UserId);
								}
							}
						}
						this.StartTeamRoomInviteNetTask(list);
					}
					else
					{
						playerContext.SetTeamRoomInviteAgain(false);
						CommonUIController.Instance.ShowErrorMessage(teamRoomCreateNetTask2.Result, 2f, null, true);
					}
				};
				teamRoomCreateNetTask.Start(null);
			}
			playerContext.SetTeamRoomInviteAgain(false);
			return true;
		}

		// Token: 0x06013E3F RID: 81471 RVA: 0x0051108C File Offset: 0x0050F28C
		private bool CheckOpenTeamRoomInfoUI()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckOpenTeamRoomInfoUI_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CheckOpenTeamRoomInfoUI_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (!projectLPlayerContext.IsInTeamRoom())
			{
				return false;
			}
			TeamRoomGetNetTask teamRoomGetNetTask = new TeamRoomGetNetTask();
			teamRoomGetNetTask.EventOnStop += delegate(Task task)
			{
				TeamRoomGetNetTask teamRoomGetNetTask2 = task as TeamRoomGetNetTask;
				if (teamRoomGetNetTask2.Result == 0)
				{
					this.StartTeamRoomInfoUITask();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(teamRoomGetNetTask2.Result, 2f, null, true);
				}
			};
			teamRoomGetNetTask.Start(null);
			return true;
		}

		// Token: 0x06013E40 RID: 81472 RVA: 0x00511138 File Offset: 0x0050F338
		private void StartTeamRoomInfoUITask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartTeamRoomInfoUITask_hotfix != null)
			{
				this.m_StartTeamRoomInfoUITask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_teamUIController.IsAutoMatching())
			{
				this.m_teamUIController.SetAutoMatchMode(false);
			}
			UIIntentReturnable uiintentReturnable = new UIIntentReturnable(this.m_currIntent, typeof(TeamRoomInfoUITask).Name, null);
			UIManager instance = UIManager.Instance;
			UIIntent intent = uiintentReturnable;
			bool pushIntentToStack = true;
			bool clearIntentStack = false;
			if (TeamUITask.<>f__mg$cache0 == null)
			{
				TeamUITask.<>f__mg$cache0 = new Action(TeamUITask.TeamRoomInfoUITask_OnLoadAllResCompleted);
			}
			TeamRoomInfoUITask teamRoomInfoUITask = instance.StartUITask(intent, pushIntentToStack, clearIntentStack, TeamUITask.<>f__mg$cache0) as TeamRoomInfoUITask;
			if (this.m_teamRoomInfoUITask == null)
			{
				this.m_teamRoomInfoUITask = teamRoomInfoUITask;
				this.m_teamRoomInfoUITask.EventOnClose += this.TeamRoomInfoUITask_OnClose;
			}
		}

		// Token: 0x06013E41 RID: 81473 RVA: 0x0051122C File Offset: 0x0050F42C
		private static void TeamRoomInfoUITask_OnLoadAllResCompleted()
		{
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(TeamRoomInfoUITask));
			if (uitaskBase != null)
			{
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x06013E42 RID: 81474 RVA: 0x00511258 File Offset: 0x0050F458
		private void TeamRoomInfoUITask_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeamRoomInfoUITask_OnClose_hotfix != null)
			{
				this.m_TeamRoomInfoUITask_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_teamRoomInfoUITask != null)
			{
				this.m_teamRoomInfoUITask = null;
				this.RefreshTeamRoom(false);
			}
		}

		// Token: 0x06013E43 RID: 81475 RVA: 0x005112D4 File Offset: 0x0050F4D4
		private void RefreshTeamRoom(bool checkRefreshTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RefreshTeamRoomBoolean_hotfix != null)
			{
				this.m_RefreshTeamRoomBoolean_hotfix.call(new object[]
				{
					this,
					checkRefreshTime
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.CheckOpenTeamRoomInfoUI())
			{
				return;
			}
			GameFunctionType gameFunctionType = this.m_teamUIController.GetGameFunctionType();
			int chapterId = this.m_teamUIController.GetChapterId();
			int locationId = this.m_teamUIController.GetLocationId();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanViewTeamRoom(gameFunctionType, chapterId, locationId);
			if (num == 0)
			{
				if (checkRefreshTime)
				{
					IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
					DateTime t = this.m_lastRefreshTeamRoomTime.AddSeconds((double)configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_TeamRoomViewRefreshClientTime));
					if (gameFunctionType == this.m_lastRefreshGameFunctionType && chapterId == this.m_lastRefreshChapterId && locationId == this.m_lastRefreshLocationId && DateTime.Now < t)
					{
						return;
					}
				}
				TeamRoomViewNetTask teamRoomViewNetTask = new TeamRoomViewNetTask(gameFunctionType, chapterId, locationId);
				teamRoomViewNetTask.EventOnStop += delegate(Task task)
				{
					TeamRoomViewNetTask teamRoomViewNetTask2 = task as TeamRoomViewNetTask;
					if (teamRoomViewNetTask2.Result == 0)
					{
						this.m_teamUIController.SetTeamRooms(teamRoomViewNetTask2.TeamRooms);
					}
					else
					{
						this.m_teamUIController.SetTeamRooms(null);
						CommonUIController.Instance.ShowErrorMessage(teamRoomViewNetTask2.Result, 2f, null, true);
					}
					this.m_lastRefreshTeamRoomTime = DateTime.Now;
					this.m_lastRefreshGameFunctionType = gameFunctionType;
					this.m_lastRefreshChapterId = chapterId;
					this.m_lastRefreshLocationId = locationId;
				};
				teamRoomViewNetTask.Start(null);
			}
			else
			{
				this.m_teamUIController.SetTeamRooms(null);
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x06013E44 RID: 81476 RVA: 0x0051148C File Offset: 0x0050F68C
		private void TeamUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeamUIController_OnReturn_hotfix != null)
			{
				this.m_TeamUIController_OnReturn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
				base.Pause();
				base.ReturnPrevUITask();
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x06013E45 RID: 81477 RVA: 0x00511510 File Offset: 0x0050F710
		private void TeamUIController_OnShowHelp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeamUIController_OnShowHelp_hotfix != null)
			{
				this.m_TeamUIController_OnShowHelp_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowExplanation(ExplanationId.ExplanationId_Team);
		}

		// Token: 0x06013E46 RID: 81478 RVA: 0x0051157C File Offset: 0x0050F77C
		private void TeamUIController_OnRefreshTeamRoom()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeamUIController_OnRefreshTeamRoom_hotfix != null)
			{
				this.m_TeamUIController_OnRefreshTeamRoom_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.RefreshTeamRoom(true);
		}

		// Token: 0x06013E47 RID: 81479 RVA: 0x005115E4 File Offset: 0x0050F7E4
		private void TeamUIController_OnShowCreateTeamRoom()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeamUIController_OnShowCreateTeamRoom_hotfix != null)
			{
				this.m_TeamUIController_OnShowCreateTeamRoom_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_createTeamRoomUIController.Open();
			GameFunctionType gameFunctionType = this.m_teamUIController.GetGameFunctionType();
			if (gameFunctionType != GameFunctionType.GameFunctionType_None)
			{
				int chapterId = this.m_teamUIController.GetChapterId();
				this.m_createTeamRoomUIController.SetGameFunctionType(gameFunctionType, chapterId);
			}
			int locationId = this.m_teamUIController.GetLocationId();
			if (locationId != 0)
			{
				this.m_createTeamRoomUIController.SetLocation(locationId);
			}
		}

		// Token: 0x06013E48 RID: 81480 RVA: 0x00511698 File Offset: 0x0050F898
		private void TeamUIController_OnAutoMatch()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeamUIController_OnAutoMatch_hotfix != null)
			{
				this.m_TeamUIController_OnAutoMatch_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameFunctionType gameFunctionType = this.m_teamUIController.GetGameFunctionType();
			int locationId = this.m_teamUIController.GetLocationId();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanAutoMatchTeamRoom(gameFunctionType, locationId);
			if (num == 0)
			{
				TeamRoomAutoMatchNetTaskNetTask teamRoomAutoMatchNetTaskNetTask = new TeamRoomAutoMatchNetTaskNetTask(gameFunctionType, locationId);
				teamRoomAutoMatchNetTaskNetTask.EventOnStop += delegate(Task task)
				{
					TeamRoomAutoMatchNetTaskNetTask teamRoomAutoMatchNetTaskNetTask2 = task as TeamRoomAutoMatchNetTaskNetTask;
					if (teamRoomAutoMatchNetTaskNetTask2.Result == 0)
					{
						if (teamRoomAutoMatchNetTaskNetTask2.IsEnterRoom)
						{
							this.StartTeamRoomInfoUITask();
						}
						else
						{
							this.m_teamUIController.SetAutoMatchMode(true);
							this.m_teamUIController.SetAutoMatchWaitCount(teamRoomAutoMatchNetTaskNetTask2.FrontOfYouWaitingNums);
						}
					}
					else
					{
						WorldUITask.HandleAttackFailResult(teamRoomAutoMatchNetTaskNetTask2.Result, this.m_currIntent);
						if (this.m_teamUIController.IsAutoMatching())
						{
							this.m_teamUIController.SetAutoMatchMode(false);
						}
					}
				};
				teamRoomAutoMatchNetTaskNetTask.Start(null);
			}
			else
			{
				WorldUITask.HandleAttackFailResult(num, this.m_currIntent);
				if (this.m_teamUIController.IsAutoMatching())
				{
					this.m_teamUIController.SetAutoMatchMode(false);
				}
			}
		}

		// Token: 0x06013E49 RID: 81481 RVA: 0x00511784 File Offset: 0x0050F984
		private void TeamUIController_OnAutoMatchCancel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeamUIController_OnAutoMatchCancel_hotfix != null)
			{
				this.m_TeamUIController_OnAutoMatchCancel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowDialogBox(StringTableId.StringTableId_Team_ExitMatch, new Action<DialogBoxResult>(this.AutoMatchCancelDialogBoxCallback), (StringTableId)0, (StringTableId)0);
		}

		// Token: 0x06013E4A RID: 81482 RVA: 0x00511804 File Offset: 0x0050FA04
		private void AutoMatchCancelDialogBoxCallback(DialogBoxResult r)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AutoMatchCancelDialogBoxCallbackDialogBoxResult_hotfix != null)
			{
				this.m_AutoMatchCancelDialogBoxCallbackDialogBoxResult_hotfix.call(new object[]
				{
					this,
					r
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (r != DialogBoxResult.Ok)
			{
				return;
			}
			TeamRoomAutoMatchCancelNetTask teamRoomAutoMatchCancelNetTask = new TeamRoomAutoMatchCancelNetTask();
			teamRoomAutoMatchCancelNetTask.EventOnStop += delegate(Task task)
			{
				TeamRoomAutoMatchCancelNetTask teamRoomAutoMatchCancelNetTask2 = task as TeamRoomAutoMatchCancelNetTask;
				if (teamRoomAutoMatchCancelNetTask2.Result != 0)
				{
					CommonUIController.Instance.ShowErrorMessage(teamRoomAutoMatchCancelNetTask2.Result, 2f, null, true);
				}
				this.m_teamUIController.SetAutoMatchMode(false);
				this.RefreshTeamRoom(false);
			};
			teamRoomAutoMatchCancelNetTask.Start(null);
		}

		// Token: 0x06013E4B RID: 81483 RVA: 0x0051189C File Offset: 0x0050FA9C
		private void TeamUIController_OnSelectGameFunctionTypeAndLocation(GameFunctionType gameFunctionType, int locationId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeamUIController_OnSelectGameFunctionTypeAndLocationGameFunctionTypeInt32_hotfix != null)
			{
				this.m_TeamUIController_OnSelectGameFunctionTypeAndLocationGameFunctionTypeInt32_hotfix.call(new object[]
				{
					this,
					gameFunctionType,
					locationId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.RefreshTeamRoom(true);
		}

		// Token: 0x06013E4C RID: 81484 RVA: 0x00511924 File Offset: 0x0050FB24
		private void TeamUIController_OnJoinTeamRoom(int roomId, GameFunctionType gameFunctionType, int locationId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeamUIController_OnJoinTeamRoomInt32GameFunctionTypeInt32_hotfix != null)
			{
				this.m_TeamUIController_OnJoinTeamRoomInt32GameFunctionTypeInt32_hotfix.call(new object[]
				{
					this,
					roomId,
					gameFunctionType,
					locationId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanJoinTeamRoom(gameFunctionType, locationId);
			if (num == 0)
			{
				TeamRoomJoinNetTask teamRoomJoinNetTask = new TeamRoomJoinNetTask(roomId, gameFunctionType, locationId, 0UL);
				teamRoomJoinNetTask.EventOnStop += delegate(Task task)
				{
					TeamRoomJoinNetTask teamRoomJoinNetTask2 = task as TeamRoomJoinNetTask;
					if (teamRoomJoinNetTask2.Result == 0)
					{
						this.StartTeamRoomInfoUITask();
					}
					else
					{
						this.HandleJoinTeamRoomResultError(teamRoomJoinNetTask2.Result);
					}
				};
				teamRoomJoinNetTask.Start(null);
			}
			else
			{
				this.HandleJoinTeamRoomResultError(num);
			}
		}

		// Token: 0x06013E4D RID: 81485 RVA: 0x00511A04 File Offset: 0x0050FC04
		private void HandleJoinTeamRoomResultError(int result)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HandleJoinTeamRoomResultErrorInt32_hotfix != null)
			{
				this.m_HandleJoinTeamRoomResultErrorInt32_hotfix.call(new object[]
				{
					this,
					result
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (result != 0)
			{
				if (result == -3007)
				{
					CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Team_LocationLock, 2f, null, true);
				}
				else if (result == -3018 || result == -3006 || result == -3016 || result == -3003)
				{
					CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Team_NoTeamRoom, 2f, null, true);
					this.RefreshTeamRoom(false);
				}
				else
				{
					WorldUITask.HandleAttackFailResult(result, this.m_currIntent);
					CommonUIController.Instance.ShowErrorMessage(result, 2f, null, true);
				}
			}
		}

		// Token: 0x06013E4E RID: 81486 RVA: 0x00511B14 File Offset: 0x0050FD14
		private void CreateTeamRoomUIController_OnCreateTeamRoom(TeamRoomSetting setting)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateTeamRoomUIController_OnCreateTeamRoomTeamRoomSetting_hotfix != null)
			{
				this.m_CreateTeamRoomUIController_OnCreateTeamRoomTeamRoomSetting_hotfix.call(new object[]
				{
					this,
					setting
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanCreateTeam(setting);
			if (num == 0)
			{
				TeamRoomCreateNetTask teamRoomCreateNetTask = new TeamRoomCreateNetTask(setting);
				teamRoomCreateNetTask.EventOnStop += delegate(Task task)
				{
					TeamRoomCreateNetTask teamRoomCreateNetTask2 = task as TeamRoomCreateNetTask;
					if (teamRoomCreateNetTask2.Result == 0)
					{
						this.m_createTeamRoomUIController.Close(delegate
						{
							this.StartTeamRoomInfoUITask();
						});
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(teamRoomCreateNetTask2.Result, 2f, null, true);
					}
				};
				teamRoomCreateNetTask.Start(null);
			}
			else
			{
				WorldUITask.HandleAttackFailResult(num, this.m_currIntent);
			}
		}

		// Token: 0x06013E4F RID: 81487 RVA: 0x00511BD4 File Offset: 0x0050FDD4
		private void PlayerContext_OnTeamRoomPlayerLeaveWaitingListAndJoinRoomNtf()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnTeamRoomPlayerLeaveWaitingListAndJoinRoomNtf_hotfix != null)
			{
				this.m_PlayerContext_OnTeamRoomPlayerLeaveWaitingListAndJoinRoomNtf_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartTeamRoomInfoUITask();
		}

		// Token: 0x06013E50 RID: 81488 RVA: 0x00511C3C File Offset: 0x0050FE3C
		private void PlayerContext_OnTeamRoomAutoMatchInfoNtf(int frontOfYouWaitingNums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnTeamRoomAutoMatchInfoNtfInt32_hotfix != null)
			{
				this.m_PlayerContext_OnTeamRoomAutoMatchInfoNtfInt32_hotfix.call(new object[]
				{
					this,
					frontOfYouWaitingNums
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_teamUIController.SetAutoMatchWaitCount(frontOfYouWaitingNums);
		}

		// Token: 0x06013E51 RID: 81489 RVA: 0x00511CB8 File Offset: 0x0050FEB8
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
			if (this.m_teamRoomInfoUITask != null)
			{
				return;
			}
			if (this.CheckOpenTeamRoomInfoUI())
			{
				return;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (!projectLPlayerContext.IsInBattleRoom())
			{
				if (this.m_teamUIController.IsAutoMatching())
				{
					this.TeamUIController_OnAutoMatch();
				}
				else
				{
					this.RefreshTeamRoom(false);
				}
			}
		}

		// Token: 0x17003B6B RID: 15211
		// (get) Token: 0x06013E52 RID: 81490 RVA: 0x00511D74 File Offset: 0x0050FF74
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

		// Token: 0x17003B6C RID: 15212
		// (get) Token: 0x06013E53 RID: 81491 RVA: 0x00511DE8 File Offset: 0x0050FFE8
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

		// Token: 0x17003B6D RID: 15213
		// (get) Token: 0x06013E54 RID: 81492 RVA: 0x00511E5C File Offset: 0x0051005C
		// (set) Token: 0x06013E55 RID: 81493 RVA: 0x00511E7C File Offset: 0x0051007C
		[DoNotToLua]
		public new TeamUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new TeamUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06013E56 RID: 81494 RVA: 0x00511E88 File Offset: 0x00510088
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x06013E57 RID: 81495 RVA: 0x00511E94 File Offset: 0x00510094
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x06013E58 RID: 81496 RVA: 0x00511E9C File Offset: 0x0051009C
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x06013E59 RID: 81497 RVA: 0x00511EA4 File Offset: 0x005100A4
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x06013E5A RID: 81498 RVA: 0x00511EB0 File Offset: 0x005100B0
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x06013E5B RID: 81499 RVA: 0x00511EBC File Offset: 0x005100BC
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x06013E5C RID: 81500 RVA: 0x00511EC8 File Offset: 0x005100C8
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06013E5D RID: 81501 RVA: 0x00511ED0 File Offset: 0x005100D0
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x06013E5E RID: 81502 RVA: 0x00511ED8 File Offset: 0x005100D8
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x06013E5F RID: 81503 RVA: 0x00511EE0 File Offset: 0x005100E0
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x06013E60 RID: 81504 RVA: 0x00511EE8 File Offset: 0x005100E8
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x06013E61 RID: 81505 RVA: 0x00511EF0 File Offset: 0x005100F0
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x06013E62 RID: 81506 RVA: 0x00511EF8 File Offset: 0x005100F8
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x06013E63 RID: 81507 RVA: 0x00511F00 File Offset: 0x00510100
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x06013E64 RID: 81508 RVA: 0x00511F0C File Offset: 0x0051010C
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x06013E65 RID: 81509 RVA: 0x00511F18 File Offset: 0x00510118
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x06013E66 RID: 81510 RVA: 0x00511F24 File Offset: 0x00510124
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x06013E67 RID: 81511 RVA: 0x00511F30 File Offset: 0x00510130
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x06013E68 RID: 81512 RVA: 0x00511F38 File Offset: 0x00510138
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x06013E69 RID: 81513 RVA: 0x00511F40 File Offset: 0x00510140
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x06013E6A RID: 81514 RVA: 0x00511F48 File Offset: 0x00510148
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x06013E6B RID: 81515 RVA: 0x00511F50 File Offset: 0x00510150
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x06013E6C RID: 81516 RVA: 0x00511F58 File Offset: 0x00510158
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x06013E75 RID: 81525 RVA: 0x00512164 File Offset: 0x00510364
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
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_InitLayerStateOnLoadAllResCompleted_hotfix = (luaObj.RawGet("InitLayerStateOnLoadAllResCompleted") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_RegisterPlayerContextEvents_hotfix = (luaObj.RawGet("RegisterPlayerContextEvents") as LuaFunction);
					this.m_UnregisterPlayerContextEvents_hotfix = (luaObj.RawGet("UnregisterPlayerContextEvents") as LuaFunction);
					this.m_InitTeamUIController_hotfix = (luaObj.RawGet("InitTeamUIController") as LuaFunction);
					this.m_UninitTeamUIController_hotfix = (luaObj.RawGet("UninitTeamUIController") as LuaFunction);
					this.m_InitCreateTeamRoomUIController_hotfix = (luaObj.RawGet("InitCreateTeamRoomUIController") as LuaFunction);
					this.m_UninitCreateTeamRoomUIController_hotfix = (luaObj.RawGet("UninitCreateTeamRoomUIController") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_OnTick_hotfix = (luaObj.RawGet("OnTick") as LuaFunction);
					this.m_StartTeamRoomInviteNetTaskList`1_hotfix = (luaObj.RawGet("StartTeamRoomInviteNetTask") as LuaFunction);
					this.m_CheckTeamRoomInviteAgain_hotfix = (luaObj.RawGet("CheckTeamRoomInviteAgain") as LuaFunction);
					this.m_CheckOpenTeamRoomInfoUI_hotfix = (luaObj.RawGet("CheckOpenTeamRoomInfoUI") as LuaFunction);
					this.m_StartTeamRoomInfoUITask_hotfix = (luaObj.RawGet("StartTeamRoomInfoUITask") as LuaFunction);
					this.m_TeamRoomInfoUITask_OnClose_hotfix = (luaObj.RawGet("TeamRoomInfoUITask_OnClose") as LuaFunction);
					this.m_RefreshTeamRoomBoolean_hotfix = (luaObj.RawGet("RefreshTeamRoom") as LuaFunction);
					this.m_TeamUIController_OnReturn_hotfix = (luaObj.RawGet("TeamUIController_OnReturn") as LuaFunction);
					this.m_TeamUIController_OnShowHelp_hotfix = (luaObj.RawGet("TeamUIController_OnShowHelp") as LuaFunction);
					this.m_TeamUIController_OnRefreshTeamRoom_hotfix = (luaObj.RawGet("TeamUIController_OnRefreshTeamRoom") as LuaFunction);
					this.m_TeamUIController_OnShowCreateTeamRoom_hotfix = (luaObj.RawGet("TeamUIController_OnShowCreateTeamRoom") as LuaFunction);
					this.m_TeamUIController_OnAutoMatch_hotfix = (luaObj.RawGet("TeamUIController_OnAutoMatch") as LuaFunction);
					this.m_TeamUIController_OnAutoMatchCancel_hotfix = (luaObj.RawGet("TeamUIController_OnAutoMatchCancel") as LuaFunction);
					this.m_AutoMatchCancelDialogBoxCallbackDialogBoxResult_hotfix = (luaObj.RawGet("AutoMatchCancelDialogBoxCallback") as LuaFunction);
					this.m_TeamUIController_OnSelectGameFunctionTypeAndLocationGameFunctionTypeInt32_hotfix = (luaObj.RawGet("TeamUIController_OnSelectGameFunctionTypeAndLocation") as LuaFunction);
					this.m_TeamUIController_OnJoinTeamRoomInt32GameFunctionTypeInt32_hotfix = (luaObj.RawGet("TeamUIController_OnJoinTeamRoom") as LuaFunction);
					this.m_HandleJoinTeamRoomResultErrorInt32_hotfix = (luaObj.RawGet("HandleJoinTeamRoomResultError") as LuaFunction);
					this.m_CreateTeamRoomUIController_OnCreateTeamRoomTeamRoomSetting_hotfix = (luaObj.RawGet("CreateTeamRoomUIController_OnCreateTeamRoom") as LuaFunction);
					this.m_PlayerContext_OnTeamRoomPlayerLeaveWaitingListAndJoinRoomNtf_hotfix = (luaObj.RawGet("PlayerContext_OnTeamRoomPlayerLeaveWaitingListAndJoinRoomNtf") as LuaFunction);
					this.m_PlayerContext_OnTeamRoomAutoMatchInfoNtfInt32_hotfix = (luaObj.RawGet("PlayerContext_OnTeamRoomAutoMatchInfoNtf") as LuaFunction);
					this.m_PlayerContext_OnPlayerInfoInitEnd_hotfix = (luaObj.RawGet("PlayerContext_OnPlayerInfoInitEnd") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06013E76 RID: 81526 RVA: 0x00512584 File Offset: 0x00510784
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400AFC3 RID: 44995
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "TeamUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Team_ABS/Prefab/TeamUIPrefab.prefab",
				m_isUILayer = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "CreateTeamRoomUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Team_ABS/Prefab/CreateTeamRoomUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400AFC4 RID: 44996
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "TeamUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.TeamUIController"),
				m_ctrlName = "TeamUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "TeamUILayer",
				m_attachPath = "./PlayerResource",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.PlayerResourceUIController"),
				m_ctrlName = "PlayerResourceUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "CreateTeamRoomUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.CreateTeamRoomUIController"),
				m_ctrlName = "CreateTeamRoomUIController"
			}
		};

		// Token: 0x0400AFC5 RID: 44997
		private TeamUIController m_teamUIController;

		// Token: 0x0400AFC6 RID: 44998
		private PlayerResourceUIController m_playerResourceUIController;

		// Token: 0x0400AFC7 RID: 44999
		private CreateTeamRoomUIController m_createTeamRoomUIController;

		// Token: 0x0400AFC8 RID: 45000
		private TeamRoomInfoUITask m_teamRoomInfoUITask;

		// Token: 0x0400AFC9 RID: 45001
		private GameFunctionType m_lastRefreshGameFunctionType;

		// Token: 0x0400AFCA RID: 45002
		private int m_lastRefreshChapterId = -1;

		// Token: 0x0400AFCB RID: 45003
		private int m_lastRefreshLocationId = -1;

		// Token: 0x0400AFCC RID: 45004
		private DateTime m_lastRefreshTeamRoomTime = DateTime.MinValue;

		// Token: 0x0400AFCD RID: 45005
		[DoNotToLua]
		private TeamUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400AFCF RID: 45007
		[CompilerGenerated]
		private static Action <>f__mg$cache0;

		// Token: 0x0400AFD0 RID: 45008
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400AFD1 RID: 45009
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400AFD2 RID: 45010
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400AFD3 RID: 45011
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x0400AFD4 RID: 45012
		private LuaFunction m_InitLayerStateOnLoadAllResCompleted_hotfix;

		// Token: 0x0400AFD5 RID: 45013
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400AFD6 RID: 45014
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400AFD7 RID: 45015
		private LuaFunction m_RegisterPlayerContextEvents_hotfix;

		// Token: 0x0400AFD8 RID: 45016
		private LuaFunction m_UnregisterPlayerContextEvents_hotfix;

		// Token: 0x0400AFD9 RID: 45017
		private LuaFunction m_InitTeamUIController_hotfix;

		// Token: 0x0400AFDA RID: 45018
		private LuaFunction m_UninitTeamUIController_hotfix;

		// Token: 0x0400AFDB RID: 45019
		private LuaFunction m_InitCreateTeamRoomUIController_hotfix;

		// Token: 0x0400AFDC RID: 45020
		private LuaFunction m_UninitCreateTeamRoomUIController_hotfix;

		// Token: 0x0400AFDD RID: 45021
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400AFDE RID: 45022
		private LuaFunction m_OnTick_hotfix;

		// Token: 0x0400AFDF RID: 45023
		private LuaFunction m_StartTeamRoomInviteNetTaskList;

		// Token: 0x0400AFE0 RID: 45024
		private LuaFunction m_CheckTeamRoomInviteAgain_hotfix;

		// Token: 0x0400AFE1 RID: 45025
		private LuaFunction m_CheckOpenTeamRoomInfoUI_hotfix;

		// Token: 0x0400AFE2 RID: 45026
		private LuaFunction m_StartTeamRoomInfoUITask_hotfix;

		// Token: 0x0400AFE3 RID: 45027
		private LuaFunction m_TeamRoomInfoUITask_OnClose_hotfix;

		// Token: 0x0400AFE4 RID: 45028
		private LuaFunction m_RefreshTeamRoomBoolean_hotfix;

		// Token: 0x0400AFE5 RID: 45029
		private LuaFunction m_TeamUIController_OnReturn_hotfix;

		// Token: 0x0400AFE6 RID: 45030
		private LuaFunction m_TeamUIController_OnShowHelp_hotfix;

		// Token: 0x0400AFE7 RID: 45031
		private LuaFunction m_TeamUIController_OnRefreshTeamRoom_hotfix;

		// Token: 0x0400AFE8 RID: 45032
		private LuaFunction m_TeamUIController_OnShowCreateTeamRoom_hotfix;

		// Token: 0x0400AFE9 RID: 45033
		private LuaFunction m_TeamUIController_OnAutoMatch_hotfix;

		// Token: 0x0400AFEA RID: 45034
		private LuaFunction m_TeamUIController_OnAutoMatchCancel_hotfix;

		// Token: 0x0400AFEB RID: 45035
		private LuaFunction m_AutoMatchCancelDialogBoxCallbackDialogBoxResult_hotfix;

		// Token: 0x0400AFEC RID: 45036
		private LuaFunction m_TeamUIController_OnSelectGameFunctionTypeAndLocationGameFunctionTypeInt32_hotfix;

		// Token: 0x0400AFED RID: 45037
		private LuaFunction m_TeamUIController_OnJoinTeamRoomInt32GameFunctionTypeInt32_hotfix;

		// Token: 0x0400AFEE RID: 45038
		private LuaFunction m_HandleJoinTeamRoomResultErrorInt32_hotfix;

		// Token: 0x0400AFEF RID: 45039
		private LuaFunction m_CreateTeamRoomUIController_OnCreateTeamRoomTeamRoomSetting_hotfix;

		// Token: 0x0400AFF0 RID: 45040
		private LuaFunction m_PlayerContext_OnTeamRoomPlayerLeaveWaitingListAndJoinRoomNtf_hotfix;

		// Token: 0x0400AFF1 RID: 45041
		private LuaFunction m_PlayerContext_OnTeamRoomAutoMatchInfoNtfInt32_hotfix;

		// Token: 0x0400AFF2 RID: 45042
		private LuaFunction m_PlayerContext_OnPlayerInfoInitEnd_hotfix;

		// Token: 0x0400AFF3 RID: 45043
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400AFF4 RID: 45044
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000F87 RID: 3975
		public new class LuaExportHelper
		{
			// Token: 0x06013E77 RID: 81527 RVA: 0x005125EC File Offset: 0x005107EC
			public LuaExportHelper(TeamUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06013E78 RID: 81528 RVA: 0x005125FC File Offset: 0x005107FC
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x06013E79 RID: 81529 RVA: 0x0051260C File Offset: 0x0051080C
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x06013E7A RID: 81530 RVA: 0x0051261C File Offset: 0x0051081C
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x06013E7B RID: 81531 RVA: 0x0051262C File Offset: 0x0051082C
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x06013E7C RID: 81532 RVA: 0x0051263C File Offset: 0x0051083C
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x06013E7D RID: 81533 RVA: 0x0051264C File Offset: 0x0051084C
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x06013E7E RID: 81534 RVA: 0x0051265C File Offset: 0x0051085C
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x06013E7F RID: 81535 RVA: 0x0051266C File Offset: 0x0051086C
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x06013E80 RID: 81536 RVA: 0x0051267C File Offset: 0x0051087C
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x06013E81 RID: 81537 RVA: 0x0051268C File Offset: 0x0051088C
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x06013E82 RID: 81538 RVA: 0x0051269C File Offset: 0x0051089C
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x06013E83 RID: 81539 RVA: 0x005126AC File Offset: 0x005108AC
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x06013E84 RID: 81540 RVA: 0x005126BC File Offset: 0x005108BC
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x06013E85 RID: 81541 RVA: 0x005126CC File Offset: 0x005108CC
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x06013E86 RID: 81542 RVA: 0x005126DC File Offset: 0x005108DC
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x06013E87 RID: 81543 RVA: 0x005126EC File Offset: 0x005108EC
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x06013E88 RID: 81544 RVA: 0x005126FC File Offset: 0x005108FC
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x06013E89 RID: 81545 RVA: 0x0051270C File Offset: 0x0051090C
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x06013E8A RID: 81546 RVA: 0x0051271C File Offset: 0x0051091C
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x06013E8B RID: 81547 RVA: 0x0051272C File Offset: 0x0051092C
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x06013E8C RID: 81548 RVA: 0x0051273C File Offset: 0x0051093C
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x06013E8D RID: 81549 RVA: 0x0051274C File Offset: 0x0051094C
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x06013E8E RID: 81550 RVA: 0x0051275C File Offset: 0x0051095C
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x17003B6E RID: 15214
			// (get) Token: 0x06013E8F RID: 81551 RVA: 0x0051276C File Offset: 0x0051096C
			// (set) Token: 0x06013E90 RID: 81552 RVA: 0x0051277C File Offset: 0x0051097C
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

			// Token: 0x17003B6F RID: 15215
			// (get) Token: 0x06013E91 RID: 81553 RVA: 0x0051278C File Offset: 0x0051098C
			// (set) Token: 0x06013E92 RID: 81554 RVA: 0x0051279C File Offset: 0x0051099C
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

			// Token: 0x17003B70 RID: 15216
			// (get) Token: 0x06013E93 RID: 81555 RVA: 0x005127AC File Offset: 0x005109AC
			// (set) Token: 0x06013E94 RID: 81556 RVA: 0x005127BC File Offset: 0x005109BC
			public TeamUIController m_teamUIController
			{
				get
				{
					return this.m_owner.m_teamUIController;
				}
				set
				{
					this.m_owner.m_teamUIController = value;
				}
			}

			// Token: 0x17003B71 RID: 15217
			// (get) Token: 0x06013E95 RID: 81557 RVA: 0x005127CC File Offset: 0x005109CC
			// (set) Token: 0x06013E96 RID: 81558 RVA: 0x005127DC File Offset: 0x005109DC
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

			// Token: 0x17003B72 RID: 15218
			// (get) Token: 0x06013E97 RID: 81559 RVA: 0x005127EC File Offset: 0x005109EC
			// (set) Token: 0x06013E98 RID: 81560 RVA: 0x005127FC File Offset: 0x005109FC
			public CreateTeamRoomUIController m_createTeamRoomUIController
			{
				get
				{
					return this.m_owner.m_createTeamRoomUIController;
				}
				set
				{
					this.m_owner.m_createTeamRoomUIController = value;
				}
			}

			// Token: 0x17003B73 RID: 15219
			// (get) Token: 0x06013E99 RID: 81561 RVA: 0x0051280C File Offset: 0x00510A0C
			// (set) Token: 0x06013E9A RID: 81562 RVA: 0x0051281C File Offset: 0x00510A1C
			public TeamRoomInfoUITask m_teamRoomInfoUITask
			{
				get
				{
					return this.m_owner.m_teamRoomInfoUITask;
				}
				set
				{
					this.m_owner.m_teamRoomInfoUITask = value;
				}
			}

			// Token: 0x17003B74 RID: 15220
			// (get) Token: 0x06013E9B RID: 81563 RVA: 0x0051282C File Offset: 0x00510A2C
			// (set) Token: 0x06013E9C RID: 81564 RVA: 0x0051283C File Offset: 0x00510A3C
			public GameFunctionType m_lastRefreshGameFunctionType
			{
				get
				{
					return this.m_owner.m_lastRefreshGameFunctionType;
				}
				set
				{
					this.m_owner.m_lastRefreshGameFunctionType = value;
				}
			}

			// Token: 0x17003B75 RID: 15221
			// (get) Token: 0x06013E9D RID: 81565 RVA: 0x0051284C File Offset: 0x00510A4C
			// (set) Token: 0x06013E9E RID: 81566 RVA: 0x0051285C File Offset: 0x00510A5C
			public int m_lastRefreshChapterId
			{
				get
				{
					return this.m_owner.m_lastRefreshChapterId;
				}
				set
				{
					this.m_owner.m_lastRefreshChapterId = value;
				}
			}

			// Token: 0x17003B76 RID: 15222
			// (get) Token: 0x06013E9F RID: 81567 RVA: 0x0051286C File Offset: 0x00510A6C
			// (set) Token: 0x06013EA0 RID: 81568 RVA: 0x0051287C File Offset: 0x00510A7C
			public int m_lastRefreshLocationId
			{
				get
				{
					return this.m_owner.m_lastRefreshLocationId;
				}
				set
				{
					this.m_owner.m_lastRefreshLocationId = value;
				}
			}

			// Token: 0x17003B77 RID: 15223
			// (get) Token: 0x06013EA1 RID: 81569 RVA: 0x0051288C File Offset: 0x00510A8C
			// (set) Token: 0x06013EA2 RID: 81570 RVA: 0x0051289C File Offset: 0x00510A9C
			public DateTime m_lastRefreshTeamRoomTime
			{
				get
				{
					return this.m_owner.m_lastRefreshTeamRoomTime;
				}
				set
				{
					this.m_owner.m_lastRefreshTeamRoomTime = value;
				}
			}

			// Token: 0x17003B78 RID: 15224
			// (get) Token: 0x06013EA3 RID: 81571 RVA: 0x005128AC File Offset: 0x00510AAC
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17003B79 RID: 15225
			// (get) Token: 0x06013EA4 RID: 81572 RVA: 0x005128BC File Offset: 0x00510ABC
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x06013EA5 RID: 81573 RVA: 0x005128CC File Offset: 0x00510ACC
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x06013EA6 RID: 81574 RVA: 0x005128DC File Offset: 0x00510ADC
			public void InitLayerStateOnLoadAllResCompleted()
			{
				this.m_owner.InitLayerStateOnLoadAllResCompleted();
			}

			// Token: 0x06013EA7 RID: 81575 RVA: 0x005128EC File Offset: 0x00510AEC
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x06013EA8 RID: 81576 RVA: 0x005128FC File Offset: 0x00510AFC
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x06013EA9 RID: 81577 RVA: 0x0051290C File Offset: 0x00510B0C
			public void RegisterPlayerContextEvents()
			{
				this.m_owner.RegisterPlayerContextEvents();
			}

			// Token: 0x06013EAA RID: 81578 RVA: 0x0051291C File Offset: 0x00510B1C
			public void UnregisterPlayerContextEvents()
			{
				this.m_owner.UnregisterPlayerContextEvents();
			}

			// Token: 0x06013EAB RID: 81579 RVA: 0x0051292C File Offset: 0x00510B2C
			public void InitTeamUIController()
			{
				this.m_owner.InitTeamUIController();
			}

			// Token: 0x06013EAC RID: 81580 RVA: 0x0051293C File Offset: 0x00510B3C
			public void UninitTeamUIController()
			{
				this.m_owner.UninitTeamUIController();
			}

			// Token: 0x06013EAD RID: 81581 RVA: 0x0051294C File Offset: 0x00510B4C
			public void InitCreateTeamRoomUIController()
			{
				this.m_owner.InitCreateTeamRoomUIController();
			}

			// Token: 0x06013EAE RID: 81582 RVA: 0x0051295C File Offset: 0x00510B5C
			public void UninitCreateTeamRoomUIController()
			{
				this.m_owner.UninitCreateTeamRoomUIController();
			}

			// Token: 0x06013EAF RID: 81583 RVA: 0x0051296C File Offset: 0x00510B6C
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x06013EB0 RID: 81584 RVA: 0x0051297C File Offset: 0x00510B7C
			public void OnTick()
			{
				this.m_owner.OnTick();
			}

			// Token: 0x06013EB1 RID: 81585 RVA: 0x0051298C File Offset: 0x00510B8C
			public void StartTeamRoomInviteNetTask(List<string> userIds)
			{
				this.m_owner.StartTeamRoomInviteNetTask(userIds);
			}

			// Token: 0x06013EB2 RID: 81586 RVA: 0x0051299C File Offset: 0x00510B9C
			public bool CheckTeamRoomInviteAgain()
			{
				return this.m_owner.CheckTeamRoomInviteAgain();
			}

			// Token: 0x06013EB3 RID: 81587 RVA: 0x005129AC File Offset: 0x00510BAC
			public bool CheckOpenTeamRoomInfoUI()
			{
				return this.m_owner.CheckOpenTeamRoomInfoUI();
			}

			// Token: 0x06013EB4 RID: 81588 RVA: 0x005129BC File Offset: 0x00510BBC
			public void StartTeamRoomInfoUITask()
			{
				this.m_owner.StartTeamRoomInfoUITask();
			}

			// Token: 0x06013EB5 RID: 81589 RVA: 0x005129CC File Offset: 0x00510BCC
			public static void TeamRoomInfoUITask_OnLoadAllResCompleted()
			{
				TeamUITask.TeamRoomInfoUITask_OnLoadAllResCompleted();
			}

			// Token: 0x06013EB6 RID: 81590 RVA: 0x005129D4 File Offset: 0x00510BD4
			public void TeamRoomInfoUITask_OnClose()
			{
				this.m_owner.TeamRoomInfoUITask_OnClose();
			}

			// Token: 0x06013EB7 RID: 81591 RVA: 0x005129E4 File Offset: 0x00510BE4
			public void RefreshTeamRoom(bool checkRefreshTime)
			{
				this.m_owner.RefreshTeamRoom(checkRefreshTime);
			}

			// Token: 0x06013EB8 RID: 81592 RVA: 0x005129F4 File Offset: 0x00510BF4
			public void TeamUIController_OnReturn()
			{
				this.m_owner.TeamUIController_OnReturn();
			}

			// Token: 0x06013EB9 RID: 81593 RVA: 0x00512A04 File Offset: 0x00510C04
			public void TeamUIController_OnShowHelp()
			{
				this.m_owner.TeamUIController_OnShowHelp();
			}

			// Token: 0x06013EBA RID: 81594 RVA: 0x00512A14 File Offset: 0x00510C14
			public void TeamUIController_OnRefreshTeamRoom()
			{
				this.m_owner.TeamUIController_OnRefreshTeamRoom();
			}

			// Token: 0x06013EBB RID: 81595 RVA: 0x00512A24 File Offset: 0x00510C24
			public void TeamUIController_OnShowCreateTeamRoom()
			{
				this.m_owner.TeamUIController_OnShowCreateTeamRoom();
			}

			// Token: 0x06013EBC RID: 81596 RVA: 0x00512A34 File Offset: 0x00510C34
			public void TeamUIController_OnAutoMatch()
			{
				this.m_owner.TeamUIController_OnAutoMatch();
			}

			// Token: 0x06013EBD RID: 81597 RVA: 0x00512A44 File Offset: 0x00510C44
			public void TeamUIController_OnAutoMatchCancel()
			{
				this.m_owner.TeamUIController_OnAutoMatchCancel();
			}

			// Token: 0x06013EBE RID: 81598 RVA: 0x00512A54 File Offset: 0x00510C54
			public void AutoMatchCancelDialogBoxCallback(DialogBoxResult r)
			{
				this.m_owner.AutoMatchCancelDialogBoxCallback(r);
			}

			// Token: 0x06013EBF RID: 81599 RVA: 0x00512A64 File Offset: 0x00510C64
			public void TeamUIController_OnSelectGameFunctionTypeAndLocation(GameFunctionType gameFunctionType, int locationId)
			{
				this.m_owner.TeamUIController_OnSelectGameFunctionTypeAndLocation(gameFunctionType, locationId);
			}

			// Token: 0x06013EC0 RID: 81600 RVA: 0x00512A74 File Offset: 0x00510C74
			public void TeamUIController_OnJoinTeamRoom(int roomId, GameFunctionType gameFunctionType, int locationId)
			{
				this.m_owner.TeamUIController_OnJoinTeamRoom(roomId, gameFunctionType, locationId);
			}

			// Token: 0x06013EC1 RID: 81601 RVA: 0x00512A84 File Offset: 0x00510C84
			public void HandleJoinTeamRoomResultError(int result)
			{
				this.m_owner.HandleJoinTeamRoomResultError(result);
			}

			// Token: 0x06013EC2 RID: 81602 RVA: 0x00512A94 File Offset: 0x00510C94
			public void CreateTeamRoomUIController_OnCreateTeamRoom(TeamRoomSetting setting)
			{
				this.m_owner.CreateTeamRoomUIController_OnCreateTeamRoom(setting);
			}

			// Token: 0x06013EC3 RID: 81603 RVA: 0x00512AA4 File Offset: 0x00510CA4
			public void PlayerContext_OnTeamRoomPlayerLeaveWaitingListAndJoinRoomNtf()
			{
				this.m_owner.PlayerContext_OnTeamRoomPlayerLeaveWaitingListAndJoinRoomNtf();
			}

			// Token: 0x06013EC4 RID: 81604 RVA: 0x00512AB4 File Offset: 0x00510CB4
			public void PlayerContext_OnTeamRoomAutoMatchInfoNtf(int frontOfYouWaitingNums)
			{
				this.m_owner.PlayerContext_OnTeamRoomAutoMatchInfoNtf(frontOfYouWaitingNums);
			}

			// Token: 0x06013EC5 RID: 81605 RVA: 0x00512AC4 File Offset: 0x00510CC4
			public void PlayerContext_OnPlayerInfoInitEnd()
			{
				this.m_owner.PlayerContext_OnPlayerInfoInitEnd();
			}

			// Token: 0x0400AFF5 RID: 45045
			private TeamUITask m_owner;
		}
	}
}
