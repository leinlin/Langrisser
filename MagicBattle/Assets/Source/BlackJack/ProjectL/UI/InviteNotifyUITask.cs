using System;
using System.Collections.Generic;
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
	// Token: 0x02000BCE RID: 3022
	[HotFix]
	public class InviteNotifyUITask : UITask
	{
		// Token: 0x0600D08B RID: 53387 RVA: 0x00391F8C File Offset: 0x0039018C
		public InviteNotifyUITask(string name) : base(name)
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

		// Token: 0x0600D08C RID: 53388 RVA: 0x00392088 File Offset: 0x00390288
		public static void StartUITask()
		{
			UIIntentCustom intent = new UIIntentCustom(typeof(InviteNotifyUITask).Name, null);
			UIManager.Instance.StartUITask(intent, false, false, null);
		}

		// Token: 0x0600D08D RID: 53389 RVA: 0x003920BC File Offset: 0x003902BC
		public static void StopUITask()
		{
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(InviteNotifyUITask));
			if (uitaskBase != null)
			{
				uitaskBase.Stop();
			}
		}

		// Token: 0x0600D08E RID: 53390 RVA: 0x003920E8 File Offset: 0x003902E8
		public static void CheckPendingInviteInfo()
		{
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			List<GeneralInviteInfo> list = new List<GeneralInviteInfo>();
			projectLPlayerContext.UpdateGeneralInviteInfos(list);
			if (list.Count > 0)
			{
				if (!UIUtility.IsUITaskRunning(typeof(InviteNotifyUITask)))
				{
					InviteNotifyUITask.StartUITask();
				}
			}
		}

		// Token: 0x0600D08F RID: 53391 RVA: 0x0039213C File Offset: 0x0039033C
		public static void DisableDisplay()
		{
			InviteNotifyUITask.m_isDisableDisplay++;
			InviteNotifyUITask.StopUITask();
		}

		// Token: 0x0600D090 RID: 53392 RVA: 0x00392150 File Offset: 0x00390350
		public static void EnableDispaly()
		{
			InviteNotifyUITask.m_isDisableDisplay--;
			if (InviteNotifyUITask.m_isDisableDisplay == 0)
			{
				InviteNotifyUITask.CheckPendingInviteInfo();
			}
		}

		// Token: 0x0600D091 RID: 53393 RVA: 0x00392170 File Offset: 0x00390370
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
			return this.InitDataFromUIIntent(intent) && base.OnStart(intent);
		}

		// Token: 0x0600D092 RID: 53394 RVA: 0x00392204 File Offset: 0x00390404
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
			return this.InitDataFromUIIntent(intent) && base.OnResume(intent);
		}

		// Token: 0x0600D093 RID: 53395 RVA: 0x00392298 File Offset: 0x00390498
		public override bool OnNewIntent(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnNewIntentUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnNewIntentUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.InitDataFromUIIntent(intent) && base.StartUpdatePipeLine(intent, false, false, true);
		}

		// Token: 0x0600D094 RID: 53396 RVA: 0x0039232C File Offset: 0x0039052C
		private bool InitDataFromUIIntent(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitDataFromUIIntentUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_InitDataFromUIIntentUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.NextInviteInfo();
		}

		// Token: 0x0600D095 RID: 53397 RVA: 0x003923B0 File Offset: 0x003905B0
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
			this.InitInviteNotifyUIController();
		}

		// Token: 0x0600D096 RID: 53398 RVA: 0x0039241C File Offset: 0x0039061C
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
			this.UninitInviteNotifyUIController();
		}

		// Token: 0x0600D097 RID: 53399 RVA: 0x00392488 File Offset: 0x00390688
		private void InitInviteNotifyUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitInviteNotifyUIController_hotfix != null)
			{
				this.m_InitInviteNotifyUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_inviteNotifyUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_inviteNotifyUIController = (this.m_uiCtrlArray[0] as InviteNotifyUIController);
				}
				if (!(this.m_inviteNotifyUIController != null))
				{
					Debug.LogError("InviteNotifyUIController is null");
					return;
				}
				this.m_inviteNotifyUIController.EventOnAccept += this.InviteNotifyUIController_OnAccept;
				this.m_inviteNotifyUIController.EventOnRefuse += this.InviteNotifyUIController_OnRefuse;
				this.m_inviteNotifyUIController.EventOnClickIcon += this.InviteNotifyUIController_OnClickIcon;
			}
		}

		// Token: 0x0600D098 RID: 53400 RVA: 0x00392580 File Offset: 0x00390780
		private void UninitInviteNotifyUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitInviteNotifyUIController_hotfix != null)
			{
				this.m_UninitInviteNotifyUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_inviteNotifyUIController != null)
			{
				this.m_inviteNotifyUIController.EventOnAccept -= this.InviteNotifyUIController_OnAccept;
				this.m_inviteNotifyUIController.EventOnRefuse -= this.InviteNotifyUIController_OnRefuse;
				this.m_inviteNotifyUIController.EventOnClickIcon -= this.InviteNotifyUIController_OnClickIcon;
				this.m_inviteNotifyUIController = null;
			}
		}

		// Token: 0x0600D099 RID: 53401 RVA: 0x00392640 File Offset: 0x00390840
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
			if (InviteNotifyUITask.m_isDisableDisplay > 0)
			{
				this.m_inviteNotifyUIController.gameObject.SetActive(false);
				return;
			}
			this.m_inviteNotifyUIController.gameObject.SetActive(true);
			bool flag = this.IsInBattle();
			if (base.IsOpeningUI())
			{
				this.m_inviteNotifyUIController.OpenIcon();
				if (!flag)
				{
					this.m_inviteNotifyUIController.OpenPanel();
				}
			}
			if (this.m_inviteInfo != null)
			{
				if (this.m_inviteInfo.TeamRoomInviteInfo != null)
				{
					this.m_inviteNotifyUIController.SetTeamRoomInviteInfo(this.m_inviteInfo.TeamRoomInviteInfo, this.m_inviteCount, flag);
				}
				else if (this.m_inviteInfo.PVPInviteInfo != null)
				{
					this.m_inviteNotifyUIController.SetPVPInviteInfo(this.m_inviteInfo.PVPInviteInfo, this.m_inviteCount, flag);
				}
			}
		}

		// Token: 0x0600D09A RID: 53402 RVA: 0x00392768 File Offset: 0x00390968
		private bool NextInviteInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_NextInviteInfo_hotfix != null)
			{
				return Convert.ToBoolean(this.m_NextInviteInfo_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.UpdateGeneralInviteInfos(this.m_inviteInfoList);
			this.m_inviteCount = this.m_inviteInfoList.Count;
			if (this.m_inviteInfoList.Count <= 0)
			{
				this.m_inviteInfo = null;
				return false;
			}
			if (this.m_inviteInfo == null)
			{
				this.m_inviteInfo = this.m_inviteInfoList[0];
			}
			else
			{
				int num = -1;
				for (int i = 0; i < this.m_inviteInfoList.Count; i++)
				{
					if (this.m_inviteInfoList[i].TeamRoomInviteInfo == this.m_inviteInfo.TeamRoomInviteInfo && this.m_inviteInfoList[i].PVPInviteInfo == this.m_inviteInfo.PVPInviteInfo)
					{
						num = i;
						break;
					}
				}
				num = (num + 1) % this.m_inviteInfoList.Count;
				this.m_inviteInfo = this.m_inviteInfoList[num];
			}
			return true;
		}

		// Token: 0x0600D09B RID: 53403 RVA: 0x003928C8 File Offset: 0x00390AC8
		private bool IsInBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsInBattle_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsInBattle_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return UIUtility.FindUITaskWithType(typeof(BattleUITask)) != null;
		}

		// Token: 0x0600D09C RID: 53404 RVA: 0x0039294C File Offset: 0x00390B4C
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
			UIIntent intent = new UIIntent(typeof(TeamRoomInfoUITask).Name, null);
			UIManager.Instance.StartUITask(intent, true, false, null);
		}

		// Token: 0x0600D09D RID: 53405 RVA: 0x003929D4 File Offset: 0x00390BD4
		private void CloseAndPause()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseAndPause_hotfix != null)
			{
				this.m_CloseAndPause_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_inviteNotifyUIController.Close(delegate
			{
				this.m_inviteInfo = null;
				this.m_inviteCount = 0;
				this.m_inviteInfoList.Clear();
				base.Pause();
			});
		}

		// Token: 0x0600D09E RID: 53406 RVA: 0x00392A4C File Offset: 0x00390C4C
		private void InviteNotifyUIController_OnAccept()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InviteNotifyUIController_OnAccept_hotfix != null)
			{
				this.m_InviteNotifyUIController_OnAccept_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (CommonUIController.Instance.IsAnyDisableInput() || CommonUIController.Instance.IsFading())
			{
				return;
			}
			ProjectLPlayerContext playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (this.m_inviteInfo.TeamRoomInviteInfo != null)
			{
				TeamRoomInviteInfo inviteInfo = this.m_inviteInfo.TeamRoomInviteInfo;
				TeamRoomJoinNetTask teamRoomJoinNetTask = new TeamRoomJoinNetTask(inviteInfo.RoomId, (GameFunctionType)inviteInfo.GameFunctionTypeId, inviteInfo.LocationId, inviteInfo.SessionId);
				teamRoomJoinNetTask.EventOnStop += delegate(Task task)
				{
					playerContext.RemoveTeamRoomAInviteInfo(inviteInfo.SessionId, inviteInfo.RoomId);
					TeamRoomJoinNetTask teamRoomJoinNetTask2 = task as TeamRoomJoinNetTask;
					if (teamRoomJoinNetTask2.Result == 0)
					{
						ChatUITask.PauseUITask();
						this.StartTeamRoomInfoUITask();
						this.CloseAndPause();
					}
					else
					{
						if (this.NextInviteInfo())
						{
							this.UpdateView();
						}
						else
						{
							this.CloseAndPause();
						}
						if (teamRoomJoinNetTask2.Result == -3007)
						{
							CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Team_LocationLock, 2f, null, true);
						}
						else if (teamRoomJoinNetTask2.Result == -3018 || teamRoomJoinNetTask2.Result == -3006 || teamRoomJoinNetTask2.Result == -3016 || teamRoomJoinNetTask2.Result == -3003)
						{
							CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Team_NoTeamRoom, 2f, null, true);
						}
						else
						{
							WorldUITask.HandleAttackFailResult(teamRoomJoinNetTask2.Result, this.m_currIntent);
						}
					}
				};
				teamRoomJoinNetTask.Start(null);
			}
			else if (this.m_inviteInfo.PVPInviteInfo != null)
			{
				PVPInviteInfo inviteInfo = this.m_inviteInfo.PVPInviteInfo;
				BattlePracticeAcceptNetTask battlePracticeAcceptNetTask = new BattlePracticeAcceptNetTask(inviteInfo.Inviter.UserId);
				battlePracticeAcceptNetTask.EventOnStop += delegate(Task task)
				{
					playerContext.RemovePVPInviteInfo(inviteInfo.Inviter.UserId);
					BattlePracticeAcceptNetTask battlePracticeAcceptNetTask2 = task as BattlePracticeAcceptNetTask;
					if (battlePracticeAcceptNetTask2.Result != 0)
					{
						CommonUIController.Instance.ShowErrorMessage(battlePracticeAcceptNetTask2.Result, 2f, null, true);
					}
					if (this.NextInviteInfo())
					{
						this.UpdateView();
					}
					else
					{
						this.CloseAndPause();
					}
				};
				battlePracticeAcceptNetTask.Start(null);
			}
		}

		// Token: 0x0600D09F RID: 53407 RVA: 0x00392BD0 File Offset: 0x00390DD0
		private void InviteNotifyUIController_OnRefuse()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InviteNotifyUIController_OnRefuse_hotfix != null)
			{
				this.m_InviteNotifyUIController_OnRefuse_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (this.m_inviteInfo.TeamRoomInviteInfo != null)
			{
				TeamRoomInviteInfo inviteInfo = this.m_inviteInfo.TeamRoomInviteInfo;
				TeamRoomInvitationRefusedNetTask teamRoomInvitationRefusedNetTask = new TeamRoomInvitationRefusedNetTask(inviteInfo.SessionId, inviteInfo.ChannelId, inviteInfo.RoomId);
				teamRoomInvitationRefusedNetTask.EventOnStop += delegate(Task task)
				{
					playerContext.RemoveTeamRoomAInviteInfo(inviteInfo.SessionId, inviteInfo.RoomId);
					TeamRoomInvitationRefusedNetTask teamRoomInvitationRefusedNetTask2 = task as TeamRoomInvitationRefusedNetTask;
					if (teamRoomInvitationRefusedNetTask2.Result != 0)
					{
						CommonUIController.Instance.ShowErrorMessage(teamRoomInvitationRefusedNetTask2.Result, 2f, null, true);
					}
					if (this.NextInviteInfo())
					{
						this.UpdateView();
					}
					else
					{
						this.CloseAndPause();
					}
				};
				teamRoomInvitationRefusedNetTask.Start(null);
			}
			else if (this.m_inviteInfo.PVPInviteInfo != null)
			{
				PVPInviteInfo inviteInfo = this.m_inviteInfo.PVPInviteInfo;
				BattlePracticeDeclineNetTask battlePracticeDeclineNetTask = new BattlePracticeDeclineNetTask(inviteInfo.Inviter.UserId);
				battlePracticeDeclineNetTask.EventOnStop += delegate(Task task)
				{
					playerContext.RemovePVPInviteInfo(inviteInfo.Inviter.UserId);
					BattlePracticeDeclineNetTask battlePracticeDeclineNetTask2 = task as BattlePracticeDeclineNetTask;
					if (battlePracticeDeclineNetTask2.Result != 0)
					{
						CommonUIController.Instance.ShowErrorMessage(battlePracticeDeclineNetTask2.Result, 2f, null, true);
					}
					if (this.NextInviteInfo())
					{
						this.UpdateView();
					}
					else
					{
						this.CloseAndPause();
					}
				};
				battlePracticeDeclineNetTask.Start(null);
			}
		}

		// Token: 0x0600D0A0 RID: 53408 RVA: 0x00392D28 File Offset: 0x00390F28
		private void InviteNotifyUIController_OnClickIcon()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InviteNotifyUIController_OnClickIcon_hotfix != null)
			{
				this.m_InviteNotifyUIController_OnClickIcon_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_inviteNotifyUIController.IsPanelOpened())
			{
				this.m_inviteNotifyUIController.OpenPanel();
				this.UpdateView();
			}
			else if (this.NextInviteInfo())
			{
				this.UpdateView();
			}
			else
			{
				this.CloseAndPause();
			}
		}

		// Token: 0x17002914 RID: 10516
		// (get) Token: 0x0600D0A1 RID: 53409 RVA: 0x00392DCC File Offset: 0x00390FCC
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

		// Token: 0x17002915 RID: 10517
		// (get) Token: 0x0600D0A2 RID: 53410 RVA: 0x00392E40 File Offset: 0x00391040
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

		// Token: 0x17002916 RID: 10518
		// (get) Token: 0x0600D0A3 RID: 53411 RVA: 0x00392EB4 File Offset: 0x003910B4
		// (set) Token: 0x0600D0A4 RID: 53412 RVA: 0x00392ED4 File Offset: 0x003910D4
		[DoNotToLua]
		public new InviteNotifyUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new InviteNotifyUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600D0A5 RID: 53413 RVA: 0x00392EE0 File Offset: 0x003910E0
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600D0A6 RID: 53414 RVA: 0x00392EEC File Offset: 0x003910EC
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600D0A7 RID: 53415 RVA: 0x00392EF4 File Offset: 0x003910F4
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600D0A8 RID: 53416 RVA: 0x00392EFC File Offset: 0x003910FC
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600D0A9 RID: 53417 RVA: 0x00392F08 File Offset: 0x00391108
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600D0AA RID: 53418 RVA: 0x00392F14 File Offset: 0x00391114
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600D0AB RID: 53419 RVA: 0x00392F20 File Offset: 0x00391120
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600D0AC RID: 53420 RVA: 0x00392F28 File Offset: 0x00391128
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600D0AD RID: 53421 RVA: 0x00392F30 File Offset: 0x00391130
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600D0AE RID: 53422 RVA: 0x00392F38 File Offset: 0x00391138
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600D0AF RID: 53423 RVA: 0x00392F40 File Offset: 0x00391140
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600D0B0 RID: 53424 RVA: 0x00392F48 File Offset: 0x00391148
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600D0B1 RID: 53425 RVA: 0x00392F50 File Offset: 0x00391150
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600D0B2 RID: 53426 RVA: 0x00392F58 File Offset: 0x00391158
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600D0B3 RID: 53427 RVA: 0x00392F64 File Offset: 0x00391164
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600D0B4 RID: 53428 RVA: 0x00392F70 File Offset: 0x00391170
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600D0B5 RID: 53429 RVA: 0x00392F7C File Offset: 0x0039117C
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600D0B6 RID: 53430 RVA: 0x00392F88 File Offset: 0x00391188
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600D0B7 RID: 53431 RVA: 0x00392F90 File Offset: 0x00391190
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600D0B8 RID: 53432 RVA: 0x00392F98 File Offset: 0x00391198
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600D0B9 RID: 53433 RVA: 0x00392FA0 File Offset: 0x003911A0
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600D0BA RID: 53434 RVA: 0x00392FA8 File Offset: 0x003911A8
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600D0BB RID: 53435 RVA: 0x00392FB0 File Offset: 0x003911B0
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600D0BE RID: 53438 RVA: 0x00392FE0 File Offset: 0x003911E0
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
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_OnResumeUIIntent_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_OnNewIntentUIIntent_hotfix = (luaObj.RawGet("OnNewIntent") as LuaFunction);
					this.m_InitDataFromUIIntentUIIntent_hotfix = (luaObj.RawGet("InitDataFromUIIntent") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_InitInviteNotifyUIController_hotfix = (luaObj.RawGet("InitInviteNotifyUIController") as LuaFunction);
					this.m_UninitInviteNotifyUIController_hotfix = (luaObj.RawGet("UninitInviteNotifyUIController") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_NextInviteInfo_hotfix = (luaObj.RawGet("NextInviteInfo") as LuaFunction);
					this.m_IsInBattle_hotfix = (luaObj.RawGet("IsInBattle") as LuaFunction);
					this.m_StartTeamRoomInfoUITask_hotfix = (luaObj.RawGet("StartTeamRoomInfoUITask") as LuaFunction);
					this.m_CloseAndPause_hotfix = (luaObj.RawGet("CloseAndPause") as LuaFunction);
					this.m_InviteNotifyUIController_OnAccept_hotfix = (luaObj.RawGet("InviteNotifyUIController_OnAccept") as LuaFunction);
					this.m_InviteNotifyUIController_OnRefuse_hotfix = (luaObj.RawGet("InviteNotifyUIController_OnRefuse") as LuaFunction);
					this.m_InviteNotifyUIController_OnClickIcon_hotfix = (luaObj.RawGet("InviteNotifyUIController_OnClickIcon") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600D0BF RID: 53439 RVA: 0x00393270 File Offset: 0x00391470
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(InviteNotifyUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040081CA RID: 33226
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "InviteNotifyUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Common_ABS/Prefab/InviteNotifyUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x040081CB RID: 33227
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "InviteNotifyUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.InviteNotifyUIController"),
				m_ctrlName = "InviteNotifyUIController"
			}
		};

		// Token: 0x040081CC RID: 33228
		private InviteNotifyUIController m_inviteNotifyUIController;

		// Token: 0x040081CD RID: 33229
		private GeneralInviteInfo m_inviteInfo;

		// Token: 0x040081CE RID: 33230
		private List<GeneralInviteInfo> m_inviteInfoList = new List<GeneralInviteInfo>();

		// Token: 0x040081CF RID: 33231
		private int m_inviteCount;

		// Token: 0x040081D0 RID: 33232
		private static int m_isDisableDisplay;

		// Token: 0x040081D1 RID: 33233
		[DoNotToLua]
		private InviteNotifyUITask.LuaExportHelper luaExportHelper;

		// Token: 0x040081D2 RID: 33234
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040081D3 RID: 33235
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040081D4 RID: 33236
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x040081D5 RID: 33237
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x040081D6 RID: 33238
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x040081D7 RID: 33239
		private LuaFunction m_OnNewIntentUIIntent_hotfix;

		// Token: 0x040081D8 RID: 33240
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x040081D9 RID: 33241
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x040081DA RID: 33242
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x040081DB RID: 33243
		private LuaFunction m_InitInviteNotifyUIController_hotfix;

		// Token: 0x040081DC RID: 33244
		private LuaFunction m_UninitInviteNotifyUIController_hotfix;

		// Token: 0x040081DD RID: 33245
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x040081DE RID: 33246
		private LuaFunction m_NextInviteInfo_hotfix;

		// Token: 0x040081DF RID: 33247
		private LuaFunction m_IsInBattle_hotfix;

		// Token: 0x040081E0 RID: 33248
		private LuaFunction m_StartTeamRoomInfoUITask_hotfix;

		// Token: 0x040081E1 RID: 33249
		private LuaFunction m_CloseAndPause_hotfix;

		// Token: 0x040081E2 RID: 33250
		private LuaFunction m_InviteNotifyUIController_OnAccept_hotfix;

		// Token: 0x040081E3 RID: 33251
		private LuaFunction m_InviteNotifyUIController_OnRefuse_hotfix;

		// Token: 0x040081E4 RID: 33252
		private LuaFunction m_InviteNotifyUIController_OnClickIcon_hotfix;

		// Token: 0x040081E5 RID: 33253
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x040081E6 RID: 33254
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000BCF RID: 3023
		public new class LuaExportHelper
		{
			// Token: 0x0600D0C0 RID: 53440 RVA: 0x003932D8 File Offset: 0x003914D8
			public LuaExportHelper(InviteNotifyUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600D0C1 RID: 53441 RVA: 0x003932E8 File Offset: 0x003914E8
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600D0C2 RID: 53442 RVA: 0x003932F8 File Offset: 0x003914F8
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600D0C3 RID: 53443 RVA: 0x00393308 File Offset: 0x00391508
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600D0C4 RID: 53444 RVA: 0x00393318 File Offset: 0x00391518
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600D0C5 RID: 53445 RVA: 0x00393328 File Offset: 0x00391528
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600D0C6 RID: 53446 RVA: 0x00393338 File Offset: 0x00391538
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600D0C7 RID: 53447 RVA: 0x00393348 File Offset: 0x00391548
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600D0C8 RID: 53448 RVA: 0x00393358 File Offset: 0x00391558
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600D0C9 RID: 53449 RVA: 0x00393368 File Offset: 0x00391568
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600D0CA RID: 53450 RVA: 0x00393378 File Offset: 0x00391578
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600D0CB RID: 53451 RVA: 0x00393388 File Offset: 0x00391588
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600D0CC RID: 53452 RVA: 0x00393398 File Offset: 0x00391598
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600D0CD RID: 53453 RVA: 0x003933A8 File Offset: 0x003915A8
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600D0CE RID: 53454 RVA: 0x003933B8 File Offset: 0x003915B8
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600D0CF RID: 53455 RVA: 0x003933C8 File Offset: 0x003915C8
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600D0D0 RID: 53456 RVA: 0x003933D8 File Offset: 0x003915D8
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600D0D1 RID: 53457 RVA: 0x003933E8 File Offset: 0x003915E8
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600D0D2 RID: 53458 RVA: 0x003933F8 File Offset: 0x003915F8
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600D0D3 RID: 53459 RVA: 0x00393408 File Offset: 0x00391608
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600D0D4 RID: 53460 RVA: 0x00393418 File Offset: 0x00391618
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600D0D5 RID: 53461 RVA: 0x00393428 File Offset: 0x00391628
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600D0D6 RID: 53462 RVA: 0x00393438 File Offset: 0x00391638
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600D0D7 RID: 53463 RVA: 0x00393448 File Offset: 0x00391648
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x17002917 RID: 10519
			// (get) Token: 0x0600D0D8 RID: 53464 RVA: 0x00393458 File Offset: 0x00391658
			// (set) Token: 0x0600D0D9 RID: 53465 RVA: 0x00393468 File Offset: 0x00391668
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

			// Token: 0x17002918 RID: 10520
			// (get) Token: 0x0600D0DA RID: 53466 RVA: 0x00393478 File Offset: 0x00391678
			// (set) Token: 0x0600D0DB RID: 53467 RVA: 0x00393488 File Offset: 0x00391688
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

			// Token: 0x17002919 RID: 10521
			// (get) Token: 0x0600D0DC RID: 53468 RVA: 0x00393498 File Offset: 0x00391698
			// (set) Token: 0x0600D0DD RID: 53469 RVA: 0x003934A8 File Offset: 0x003916A8
			public InviteNotifyUIController m_inviteNotifyUIController
			{
				get
				{
					return this.m_owner.m_inviteNotifyUIController;
				}
				set
				{
					this.m_owner.m_inviteNotifyUIController = value;
				}
			}

			// Token: 0x1700291A RID: 10522
			// (get) Token: 0x0600D0DE RID: 53470 RVA: 0x003934B8 File Offset: 0x003916B8
			// (set) Token: 0x0600D0DF RID: 53471 RVA: 0x003934C8 File Offset: 0x003916C8
			public GeneralInviteInfo m_inviteInfo
			{
				get
				{
					return this.m_owner.m_inviteInfo;
				}
				set
				{
					this.m_owner.m_inviteInfo = value;
				}
			}

			// Token: 0x1700291B RID: 10523
			// (get) Token: 0x0600D0E0 RID: 53472 RVA: 0x003934D8 File Offset: 0x003916D8
			// (set) Token: 0x0600D0E1 RID: 53473 RVA: 0x003934E8 File Offset: 0x003916E8
			public List<GeneralInviteInfo> m_inviteInfoList
			{
				get
				{
					return this.m_owner.m_inviteInfoList;
				}
				set
				{
					this.m_owner.m_inviteInfoList = value;
				}
			}

			// Token: 0x1700291C RID: 10524
			// (get) Token: 0x0600D0E2 RID: 53474 RVA: 0x003934F8 File Offset: 0x003916F8
			// (set) Token: 0x0600D0E3 RID: 53475 RVA: 0x00393508 File Offset: 0x00391708
			public int m_inviteCount
			{
				get
				{
					return this.m_owner.m_inviteCount;
				}
				set
				{
					this.m_owner.m_inviteCount = value;
				}
			}

			// Token: 0x1700291D RID: 10525
			// (get) Token: 0x0600D0E4 RID: 53476 RVA: 0x00393518 File Offset: 0x00391718
			// (set) Token: 0x0600D0E5 RID: 53477 RVA: 0x00393520 File Offset: 0x00391720
			public static int m_isDisableDisplay
			{
				get
				{
					return InviteNotifyUITask.m_isDisableDisplay;
				}
				set
				{
					InviteNotifyUITask.m_isDisableDisplay = value;
				}
			}

			// Token: 0x1700291E RID: 10526
			// (get) Token: 0x0600D0E6 RID: 53478 RVA: 0x00393528 File Offset: 0x00391728
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x1700291F RID: 10527
			// (get) Token: 0x0600D0E7 RID: 53479 RVA: 0x00393538 File Offset: 0x00391738
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600D0E8 RID: 53480 RVA: 0x00393548 File Offset: 0x00391748
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0600D0E9 RID: 53481 RVA: 0x00393558 File Offset: 0x00391758
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x0600D0EA RID: 53482 RVA: 0x00393568 File Offset: 0x00391768
			public bool InitDataFromUIIntent(UIIntent intent)
			{
				return this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x0600D0EB RID: 53483 RVA: 0x00393578 File Offset: 0x00391778
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600D0EC RID: 53484 RVA: 0x00393588 File Offset: 0x00391788
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600D0ED RID: 53485 RVA: 0x00393598 File Offset: 0x00391798
			public void InitInviteNotifyUIController()
			{
				this.m_owner.InitInviteNotifyUIController();
			}

			// Token: 0x0600D0EE RID: 53486 RVA: 0x003935A8 File Offset: 0x003917A8
			public void UninitInviteNotifyUIController()
			{
				this.m_owner.UninitInviteNotifyUIController();
			}

			// Token: 0x0600D0EF RID: 53487 RVA: 0x003935B8 File Offset: 0x003917B8
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600D0F0 RID: 53488 RVA: 0x003935C8 File Offset: 0x003917C8
			public bool NextInviteInfo()
			{
				return this.m_owner.NextInviteInfo();
			}

			// Token: 0x0600D0F1 RID: 53489 RVA: 0x003935D8 File Offset: 0x003917D8
			public bool IsInBattle()
			{
				return this.m_owner.IsInBattle();
			}

			// Token: 0x0600D0F2 RID: 53490 RVA: 0x003935E8 File Offset: 0x003917E8
			public void StartTeamRoomInfoUITask()
			{
				this.m_owner.StartTeamRoomInfoUITask();
			}

			// Token: 0x0600D0F3 RID: 53491 RVA: 0x003935F8 File Offset: 0x003917F8
			public void CloseAndPause()
			{
				this.m_owner.CloseAndPause();
			}

			// Token: 0x0600D0F4 RID: 53492 RVA: 0x00393608 File Offset: 0x00391808
			public void InviteNotifyUIController_OnAccept()
			{
				this.m_owner.InviteNotifyUIController_OnAccept();
			}

			// Token: 0x0600D0F5 RID: 53493 RVA: 0x00393618 File Offset: 0x00391818
			public void InviteNotifyUIController_OnRefuse()
			{
				this.m_owner.InviteNotifyUIController_OnRefuse();
			}

			// Token: 0x0600D0F6 RID: 53494 RVA: 0x00393628 File Offset: 0x00391828
			public void InviteNotifyUIController_OnClickIcon()
			{
				this.m_owner.InviteNotifyUIController_OnClickIcon();
			}

			// Token: 0x040081E7 RID: 33255
			private InviteNotifyUITask m_owner;
		}
	}
}
