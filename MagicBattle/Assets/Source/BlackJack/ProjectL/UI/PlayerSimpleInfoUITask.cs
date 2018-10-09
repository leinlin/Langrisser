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
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000BEC RID: 3052
	[HotFix]
	public class PlayerSimpleInfoUITask : UITask
	{
		// Token: 0x0600D49A RID: 54426 RVA: 0x0039FA40 File Offset: 0x0039DC40
		public PlayerSimpleInfoUITask(string name) : base(name)
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

		// Token: 0x0600D49B RID: 54427 RVA: 0x0039FB78 File Offset: 0x0039DD78
		public static PlayerSimpleInfoUITask ShowPlayerSimpleInfoPanel(Vector3 pos, PlayerSimpleInfoUITask.PostionType postionType = PlayerSimpleInfoUITask.PostionType.Right, UIIntent returnIntent = null, bool isFromGuild = false)
		{
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.BusinessCard == null)
			{
				global::Debug.LogError("ShowPlayerSimpleInfoPanel::PlayerInfo is Null !");
				return null;
			}
			string targetMode = (!projectLPlayerContext.IsFriend(projectLPlayerContext.BusinessCard.UserId)) ? "StrangerInfoMode" : "FriendInfoMode";
			if (isFromGuild)
			{
				targetMode = "GuildInfoMode";
			}
			UIIntentCustom uiintentCustom = new UIIntentCustom(typeof(PlayerSimpleInfoUITask).Name, targetMode);
			uiintentCustom.SetParam("PlayerSimpleInfoPanelPostion", pos);
			uiintentCustom.SetParam("PlayerSimpleInfoPanelType", postionType);
			uiintentCustom.SetParam("PlayerSimpleInfoReturnToIntent", returnIntent);
			return UIManager.Instance.StartUITask(uiintentCustom, true, false, null) as PlayerSimpleInfoUITask;
		}

		// Token: 0x0600D49C RID: 54428 RVA: 0x0039FC38 File Offset: 0x0039DE38
		public override void InitlizeBeforeManagerStartIt()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitlizeBeforeManagerStartIt_hotfix != null)
			{
				this.m_InitlizeBeforeManagerStartIt_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.InitlizeBeforeManagerStartIt();
			base.RegisterModesDefine("StrangerInfoMode", new string[]
			{
				"FriendInfoMode",
				"GuildInfoMode"
			});
		}

		// Token: 0x0600D49D RID: 54429 RVA: 0x0039FCC0 File Offset: 0x0039DEC0
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
			return base.OnStart(intent);
		}

		// Token: 0x0600D49E RID: 54430 RVA: 0x0039FD44 File Offset: 0x0039DF44
		protected override void OnStop()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStop_hotfix != null)
			{
				this.m_OnStop_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnStop();
			this.UnRegiterUIEvent();
		}

		// Token: 0x0600D49F RID: 54431 RVA: 0x0039FDB0 File Offset: 0x0039DFB0
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
			return base.OnResume(intent);
		}

		// Token: 0x0600D4A0 RID: 54432 RVA: 0x0039FE34 File Offset: 0x0039E034
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
			if (this.m_uiCtrlArray != null && this.m_uiCtrlArray.Length != 0)
			{
				this.m_mainCtrl = (this.m_uiCtrlArray[0] as PlayerSimpleInfoUIController);
				this.RegisterUIEvent();
			}
		}

		// Token: 0x0600D4A1 RID: 54433 RVA: 0x0039FECC File Offset: 0x0039E0CC
		protected override bool IsNeedUpdateDataCache()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedUpdateDataCache_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedUpdateDataCache_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return true;
		}

		// Token: 0x0600D4A2 RID: 54434 RVA: 0x0039FF3C File Offset: 0x0039E13C
		protected override void UpdateDataCache()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateDataCache_hotfix != null)
			{
				this.m_UpdateDataCache_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.UpdateDataCache();
			UIIntentCustom uiintentCustom = this.m_currIntent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				object obj;
				if (uiintentCustom.TryGetParam("PlayerSimpleInfoPanelPostion", out obj))
				{
					this.m_panelPos = (Vector3)obj;
				}
				object obj2;
				if (uiintentCustom.TryGetParam("PlayerSimpleInfoPanelType", out obj2))
				{
					this.m_showPanelType = (PlayerSimpleInfoUITask.PostionType)obj2;
				}
				object obj3;
				if (uiintentCustom.TryGetParam("PlayerSimpleInfoReturnToIntent", out obj3))
				{
					this.m_returnUITaskIntent = (UIIntent)obj3;
				}
			}
		}

		// Token: 0x0600D4A3 RID: 54435 RVA: 0x003A0010 File Offset: 0x0039E210
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
			this.m_currInfo = this.m_playerContext.BusinessCard;
			bool isInBattle = this.IsInBattle();
			bool isInTeamRoom = this.m_playerContext.IsInTeamRoom();
			bool canSendLike = this.m_playerContext.CanSendLikes(this.m_currInfo.UserId) == 0;
			string currMode = this.m_currMode;
			if (currMode != null)
			{
				if (!(currMode == "StrangerInfoMode"))
				{
					if (!(currMode == "FriendInfoMode"))
					{
						if (currMode == "GuildInfoMode")
						{
							bool isFriend = this.m_playerContext.IsFriend(this.m_playerContext.BusinessCard.UserId);
							this.m_mainCtrl.UpdatePlayerInfo(this.m_currInfo, isFriend, canSendLike, isInBattle, isInTeamRoom);
						}
					}
					else
					{
						this.m_mainCtrl.UpdatePlayerInfo(this.m_currInfo, true, canSendLike, isInBattle, isInTeamRoom);
					}
				}
				else
				{
					this.m_mainCtrl.UpdatePlayerInfo(this.m_currInfo, false, canSendLike, isInBattle, isInTeamRoom);
				}
			}
			this.m_mainCtrl.SetGuildButtonGroupStateByMode(this.m_currMode);
			this.SetPanelPostion();
			if (base.IsOpeningUI())
			{
				this.m_mainCtrl.ShowOrHide(true);
			}
		}

		// Token: 0x0600D4A4 RID: 54436 RVA: 0x003A0190 File Offset: 0x0039E390
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

		// Token: 0x0600D4A5 RID: 54437 RVA: 0x003A0214 File Offset: 0x0039E414
		private void PlayerSimpleInfoUIController_OnWatchCard(string userID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerSimpleInfoUIController_OnWatchCardString_hotfix != null)
			{
				this.m_PlayerSimpleInfoUIController_OnWatchCardString_hotfix.call(new object[]
				{
					this,
					userID
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BusinessCardGetNetTask businessCardGetNetTask = new BusinessCardGetNetTask(userID);
			businessCardGetNetTask.EventOnStop += delegate(Task task)
			{
				BusinessCardGetNetTask businessCardGetNetTask2 = task as BusinessCardGetNetTask;
				if (businessCardGetNetTask2.Result == 0)
				{
					BusinessCardUITask.StartUITask(this.m_currIntent);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(businessCardGetNetTask2.Result, 2f, null, true);
				}
			};
			businessCardGetNetTask.Start(null);
		}

		// Token: 0x0600D4A6 RID: 54438 RVA: 0x003A02A8 File Offset: 0x0039E4A8
		private void PlayerSimpleInfoUIController_OnPrivateChat()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerSimpleInfoUIController_OnPrivateChat_hotfix != null)
			{
				this.m_PlayerSimpleInfoUIController_OnPrivateChat_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnPrivateChatButtonClick != null)
			{
				this.EventOnPrivateChatButtonClick(this.m_currInfo);
			}
			this.ClosePanel();
		}

		// Token: 0x0600D4A7 RID: 54439 RVA: 0x003A032C File Offset: 0x0039E52C
		private void PlayerSimpleInfoUIController_OnPK(string userID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerSimpleInfoUIController_OnPKString_hotfix != null)
			{
				this.m_PlayerSimpleInfoUIController_OnPKString_hotfix.call(new object[]
				{
					this,
					userID
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ClosePanel();
			WaitPVPInviteUITask.StartUITask(userID);
		}

		// Token: 0x0600D4A8 RID: 54440 RVA: 0x003A03A8 File Offset: 0x0039E5A8
		private void PlayerSimpleInfoUIController_OnDeleteFriend(BusinessCard userInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerSimpleInfoUIController_OnDeleteFriendBusinessCard_hotfix != null)
			{
				this.m_PlayerSimpleInfoUIController_OnDeleteFriendBusinessCard_hotfix.call(new object[]
				{
					this,
					userInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_deleteFriendUserID = userInfo.UserId;
			CommonUIController.Instance.ShowDialogBox(string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_ConfirmDeleteFriend), userInfo.Name), new Action<DialogBoxResult>(this.OnDeleteFreindDialogBoxCallback), string.Empty, null);
		}

		// Token: 0x0600D4A9 RID: 54441 RVA: 0x003A045C File Offset: 0x0039E65C
		private void OnDeleteFreindDialogBoxCallback(DialogBoxResult r)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDeleteFreindDialogBoxCallbackDialogBoxResult_hotfix != null)
			{
				this.m_OnDeleteFreindDialogBoxCallbackDialogBoxResult_hotfix.call(new object[]
				{
					this,
					r
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (r == DialogBoxResult.Ok)
			{
				FriendDeleteNetTask friendDeleteNetTask = new FriendDeleteNetTask(this.m_deleteFriendUserID);
				friendDeleteNetTask.EventOnStop += delegate(Task task)
				{
					FriendDeleteNetTask friendDeleteNetTask2 = task as FriendDeleteNetTask;
					if (friendDeleteNetTask2.Result == 0)
					{
						if (this.EventOnGetSocialRelation != null)
						{
							this.EventOnGetSocialRelation();
						}
						CommonUIController.Instance.ShowMessage(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_DeleteFriendSuccess), 2f, null, true);
						this.PlayerSimpleInfoUIController_OnReturn();
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(friendDeleteNetTask2.Result, 2f, null, true);
					}
				};
				friendDeleteNetTask.Start(null);
			}
		}

		// Token: 0x0600D4AA RID: 54442 RVA: 0x003A04FC File Offset: 0x0039E6FC
		private void PlayerSimpleInfoUIController_OnAddFriend(string userID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerSimpleInfoUIController_OnAddFriendString_hotfix != null)
			{
				this.m_PlayerSimpleInfoUIController_OnAddFriendString_hotfix.call(new object[]
				{
					this,
					userID
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_friendAddList.Clear();
			this.m_friendAddList.Add(userID);
			FriendAddNetTask friendAddNetTask = new FriendAddNetTask(this.m_friendAddList);
			friendAddNetTask.EventOnStop += delegate(Task task)
			{
				FriendAddNetTask friendAddNetTask2 = task as FriendAddNetTask;
				if (friendAddNetTask2.Result == 0)
				{
					if (this.EventOnGetSocialRelation != null)
					{
						this.EventOnGetSocialRelation();
					}
					CommonUIController.Instance.ShowMessage(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_InviteFriendSuccess), 2f, null, true);
					this.PlayerSimpleInfoUIController_OnReturn();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(friendAddNetTask2.Result, 2f, null, true);
				}
			};
			friendAddNetTask.Start(null);
		}

		// Token: 0x0600D4AB RID: 54443 RVA: 0x003A05AC File Offset: 0x0039E7AC
		private void PlayerSimpleInfoUIController_OnBlock(string userID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerSimpleInfoUIController_OnBlockString_hotfix != null)
			{
				this.m_PlayerSimpleInfoUIController_OnBlockString_hotfix.call(new object[]
				{
					this,
					userID
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_playerContext.IsMe(userID))
			{
				PlayerBlockNetTask playerBlockNetTask = new PlayerBlockNetTask(userID);
				playerBlockNetTask.EventOnStop += delegate(Task task)
				{
					PlayerBlockNetTask playerBlockNetTask2 = task as PlayerBlockNetTask;
					if (playerBlockNetTask2.Result == 0)
					{
						if (this.EventOnBlockUser != null)
						{
							this.EventOnBlockUser();
						}
						CommonUIController.Instance.ShowMessage(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_BlockSuccess), 2f, null, true);
						this.PlayerSimpleInfoUIController_OnReturn();
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(playerBlockNetTask2.Result, 2f, null, true);
					}
				};
				playerBlockNetTask.Start(null);
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(-4039, 2f, null, true);
			}
		}

		// Token: 0x0600D4AC RID: 54444 RVA: 0x003A066C File Offset: 0x0039E86C
		private void PlayerSimpleInfoUIController_OnLike(string userID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerSimpleInfoUIController_OnLikeString_hotfix != null)
			{
				this.m_PlayerSimpleInfoUIController_OnLikeString_hotfix.call(new object[]
				{
					this,
					userID
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_playerContext.CanSendLikes(userID);
			if (num == 0)
			{
				LikeNetTask likeNetTask = new LikeNetTask(userID);
				likeNetTask.EventOnStop += delegate(Task task)
				{
					LikeNetTask likeNetTask2 = task as LikeNetTask;
					if (likeNetTask2.Result == 0)
					{
						this.UpdateView();
						CommonUIController.Instance.ShowMessage(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_Like_Success), 2f, null, true);
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(likeNetTask2.Result, 2f, null, true);
					}
				};
				likeNetTask.Start(null);
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x0600D4AD RID: 54445 RVA: 0x003A0728 File Offset: 0x0039E928
		private void PlayerSimpleInfoUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerSimpleInfoUIController_OnReturn_hotfix != null)
			{
				this.m_PlayerSimpleInfoUIController_OnReturn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_mainCtrl.ShowOrHide(false);
			this.ClosePanel();
		}

		// Token: 0x0600D4AE RID: 54446 RVA: 0x003A079C File Offset: 0x0039E99C
		private void PlayerSimpleInfoUIController_OnExpel(string userId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerSimpleInfoUIController_OnExpelString_hotfix != null)
			{
				this.m_PlayerSimpleInfoUIController_OnExpelString_hotfix.call(new object[]
				{
					this,
					userId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GuildKickOutReqNetTask guildKickOutReqNetTask = new GuildKickOutReqNetTask(userId);
			guildKickOutReqNetTask.EventOnStop += delegate(Task task)
			{
				GuildKickOutReqNetTask guildKickOutReqNetTask2 = task as GuildKickOutReqNetTask;
				if (guildKickOutReqNetTask2.Result == 0)
				{
					string txt = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Guild_KickOutMemberSucceed);
					CommonUIController.Instance.ShowMessage(txt, 2f, null, true);
					this.PlayerSimpleInfoUIController_OnReturn();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(guildKickOutReqNetTask2.Result, 2f, null, true);
				}
			};
			guildKickOutReqNetTask.Start(null);
		}

		// Token: 0x0600D4AF RID: 54447 RVA: 0x003A0830 File Offset: 0x0039EA30
		private void PlayerSimpleInfoUIController_OnVChairmanChange(string userId, bool isAppiont)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerSimpleInfoUIController_OnVChairmanChangeStringBoolean_hotfix != null)
			{
				this.m_PlayerSimpleInfoUIController_OnVChairmanChangeStringBoolean_hotfix.call(new object[]
				{
					this,
					userId,
					isAppiont2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool isAppiont = isAppiont2;
			PlayerSimpleInfoUITask $this = this;
			GuildVicePresidentAppointReqNetTask guildVicePresidentAppointReqNetTask = new GuildVicePresidentAppointReqNetTask(userId, isAppiont);
			guildVicePresidentAppointReqNetTask.EventOnStop += delegate(Task task)
			{
				GuildVicePresidentAppointReqNetTask guildVicePresidentAppointReqNetTask2 = task as GuildVicePresidentAppointReqNetTask;
				if (guildVicePresidentAppointReqNetTask2.Result == 0)
				{
					string txt;
					if (isAppiont)
					{
						txt = $this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Guild_SetVPSucceed);
					}
					else
					{
						txt = $this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Guild_RelieveVPSucceed);
					}
					CommonUIController.Instance.ShowMessage(txt, 2f, null, true);
					$this.PlayerSimpleInfoUIController_OnReturn();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(guildVicePresidentAppointReqNetTask2.Result, 2f, null, true);
				}
			};
			guildVicePresidentAppointReqNetTask.Start(null);
		}

		// Token: 0x0600D4B0 RID: 54448 RVA: 0x003A08EC File Offset: 0x0039EAEC
		private void PlayerSimpleInfoUIController_ChairmanMove(string userId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerSimpleInfoUIController_ChairmanMoveString_hotfix != null)
			{
				this.m_PlayerSimpleInfoUIController_ChairmanMoveString_hotfix.call(new object[]
				{
					this,
					userId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GuildPresidentAppointReqNetTask guildPresidentAppointReqNetTask = new GuildPresidentAppointReqNetTask(userId);
			guildPresidentAppointReqNetTask.EventOnStop += delegate(Task task)
			{
				GuildPresidentAppointReqNetTask guildPresidentAppointReqNetTask2 = task as GuildPresidentAppointReqNetTask;
				if (guildPresidentAppointReqNetTask2.Result == 0)
				{
					string txt = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Guild_AppointPresidentSuccess);
					CommonUIController.Instance.ShowMessage(txt, 2f, null, true);
					this.PlayerSimpleInfoUIController_OnReturn();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(guildPresidentAppointReqNetTask2.Result, 2f, null, true);
				}
			};
			guildPresidentAppointReqNetTask.Start(null);
		}

		// Token: 0x0600D4B1 RID: 54449 RVA: 0x003A0980 File Offset: 0x0039EB80
		private void PlayerSimpleInfoUIController_OnChairmanRelieve(string userId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerSimpleInfoUIController_OnChairmanRelieveString_hotfix != null)
			{
				this.m_PlayerSimpleInfoUIController_OnChairmanRelieveString_hotfix.call(new object[]
				{
					this,
					userId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GuildPresidentRelieveReqNetTask guildPresidentRelieveReqNetTask = new GuildPresidentRelieveReqNetTask(userId);
			guildPresidentRelieveReqNetTask.EventOnStop += delegate(Task task)
			{
				GuildPresidentRelieveReqNetTask guildPresidentRelieveReqNetTask2 = task as GuildPresidentRelieveReqNetTask;
				if (guildPresidentRelieveReqNetTask2.Result == 0)
				{
					string txt = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Guild_RelievePresidentSucceed);
					CommonUIController.Instance.ShowMessage(txt, 2f, null, true);
					this.PlayerSimpleInfoUIController_OnReturn();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(guildPresidentRelieveReqNetTask2.Result, 2f, null, true);
				}
			};
			guildPresidentRelieveReqNetTask.Start(null);
		}

		// Token: 0x0600D4B2 RID: 54450 RVA: 0x003A0A14 File Offset: 0x0039EC14
		private void ClosePanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClosePanel_hotfix != null)
			{
				this.m_ClosePanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Pause();
			if (this.EventOnClose != null)
			{
				this.EventOnClose();
			}
		}

		// Token: 0x0600D4B3 RID: 54451 RVA: 0x003A0A90 File Offset: 0x0039EC90
		private void RegisterUIEvent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RegisterUIEvent_hotfix != null)
			{
				this.m_RegisterUIEvent_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_mainCtrl.EventOnWatchCardButtonClick += this.PlayerSimpleInfoUIController_OnWatchCard;
			this.m_mainCtrl.EventOnPrivateChatButtonClick += this.PlayerSimpleInfoUIController_OnPrivateChat;
			this.m_mainCtrl.EventOnAddFriendButtonClick += this.PlayerSimpleInfoUIController_OnAddFriend;
			this.m_mainCtrl.EventOnDeleteFriendButtonClick += this.PlayerSimpleInfoUIController_OnDeleteFriend;
			this.m_mainCtrl.EventOnPKButtonClick += this.PlayerSimpleInfoUIController_OnPK;
			this.m_mainCtrl.EventOnLikeButtonClick += this.PlayerSimpleInfoUIController_OnLike;
			this.m_mainCtrl.EventOnBlockButtonClick += this.PlayerSimpleInfoUIController_OnBlock;
			this.m_mainCtrl.EventOnBGButtonClick += this.PlayerSimpleInfoUIController_OnReturn;
			this.m_mainCtrl.EventOnChairmanRelieveButtonClick += this.PlayerSimpleInfoUIController_OnChairmanRelieve;
			this.m_mainCtrl.EventOnChairmanMoveButtonClick += this.PlayerSimpleInfoUIController_ChairmanMove;
			this.m_mainCtrl.EventOnVChairmanChangeButtonClick += this.PlayerSimpleInfoUIController_OnVChairmanChange;
			this.m_mainCtrl.EventOnExpelButtonClick += this.PlayerSimpleInfoUIController_OnExpel;
		}

		// Token: 0x0600D4B4 RID: 54452 RVA: 0x003A0C04 File Offset: 0x0039EE04
		private void UnRegiterUIEvent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UnRegiterUIEvent_hotfix != null)
			{
				this.m_UnRegiterUIEvent_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_mainCtrl.EventOnWatchCardButtonClick -= this.PlayerSimpleInfoUIController_OnWatchCard;
			this.m_mainCtrl.EventOnPrivateChatButtonClick -= this.PlayerSimpleInfoUIController_OnPrivateChat;
			this.m_mainCtrl.EventOnAddFriendButtonClick -= this.PlayerSimpleInfoUIController_OnAddFriend;
			this.m_mainCtrl.EventOnDeleteFriendButtonClick -= this.PlayerSimpleInfoUIController_OnDeleteFriend;
			this.m_mainCtrl.EventOnPKButtonClick -= this.PlayerSimpleInfoUIController_OnPK;
			this.m_mainCtrl.EventOnLikeButtonClick -= this.PlayerSimpleInfoUIController_OnLike;
			this.m_mainCtrl.EventOnBlockButtonClick -= this.PlayerSimpleInfoUIController_OnBlock;
			this.m_mainCtrl.EventOnBGButtonClick -= this.PlayerSimpleInfoUIController_OnReturn;
			this.m_mainCtrl.EventOnChairmanRelieveButtonClick -= this.PlayerSimpleInfoUIController_OnChairmanRelieve;
			this.m_mainCtrl.EventOnChairmanMoveButtonClick -= this.PlayerSimpleInfoUIController_ChairmanMove;
			this.m_mainCtrl.EventOnVChairmanChangeButtonClick -= this.PlayerSimpleInfoUIController_OnVChairmanChange;
			this.m_mainCtrl.EventOnExpelButtonClick -= this.PlayerSimpleInfoUIController_OnExpel;
			this.m_mainCtrl = null;
		}

		// Token: 0x0600D4B5 RID: 54453 RVA: 0x003A0D80 File Offset: 0x0039EF80
		private void SetPanelPostion()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPanelPostion_hotfix != null)
			{
				this.m_SetPanelPostion_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_mainCtrl != null)
			{
				Vector3 panelPos = this.m_panelPos;
				Vector2 panelSize = this.m_mainCtrl.PanelSize;
				Rect viewRect = this.m_mainCtrl.GetViewRect();
				PlayerSimpleInfoUITask.PostionType showPanelType = this.m_showPanelType;
				if (showPanelType != PlayerSimpleInfoUITask.PostionType.UseInput)
				{
					if (showPanelType != PlayerSimpleInfoUITask.PostionType.Left)
					{
						if (showPanelType == PlayerSimpleInfoUITask.PostionType.Right)
						{
							Vector2 point = new Vector2(this.m_panelPos.x, this.m_panelPos.y - panelSize.y - 0.3f);
							if (viewRect.Contains(point))
							{
								panelPos = new Vector3(this.m_panelPos.x + panelSize.x / 2f, this.m_panelPos.y - panelSize.y / 2f + 0.3f, this.m_panelPos.z);
							}
							else
							{
								Vector2 point2 = new Vector2(this.m_panelPos.x, this.m_panelPos.y + panelSize.y + 0.3f);
								if (viewRect.Contains(point2))
								{
									panelPos = new Vector3(this.m_panelPos.x + panelSize.x / 2f, this.m_panelPos.y + panelSize.y / 2f + 0.3f, this.m_panelPos.z);
								}
								else
								{
									panelPos = new Vector3(this.m_panelPos.x + panelSize.x / 2f, viewRect.position.y + panelSize.y / 2f + 0.3f, this.m_panelPos.z);
								}
							}
						}
					}
					else
					{
						Vector2 point3 = new Vector2(this.m_panelPos.x, this.m_panelPos.y - panelSize.y - 0.3f);
						if (viewRect.Contains(point3))
						{
							panelPos = new Vector3(this.m_panelPos.x - panelSize.x / 2f, this.m_panelPos.y - panelSize.y / 2f + 0.3f, this.m_panelPos.z);
						}
						else
						{
							Vector2 point4 = new Vector2(this.m_panelPos.x, this.m_panelPos.y + panelSize.y + 0.3f);
							if (viewRect.Contains(point4))
							{
								panelPos = new Vector3(this.m_panelPos.x - panelSize.x / 2f, this.m_panelPos.y + panelSize.y / 2f + 0.3f, this.m_panelPos.z);
							}
							else
							{
								panelPos = new Vector3(this.m_panelPos.x - panelSize.x / 2f, viewRect.position.y + panelSize.y / 2f + 0.3f, this.m_panelPos.z);
							}
						}
					}
				}
				else
				{
					panelPos = this.m_panelPos;
				}
				this.m_mainCtrl.SetPanelPosition(panelPos);
			}
		}

		// Token: 0x1700298B RID: 10635
		// (get) Token: 0x0600D4B6 RID: 54454 RVA: 0x003A1110 File Offset: 0x0039F310
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

		// Token: 0x1700298C RID: 10636
		// (get) Token: 0x0600D4B7 RID: 54455 RVA: 0x003A1184 File Offset: 0x0039F384
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

		// Token: 0x140002A3 RID: 675
		// (add) Token: 0x0600D4B8 RID: 54456 RVA: 0x003A11F8 File Offset: 0x0039F3F8
		// (remove) Token: 0x0600D4B9 RID: 54457 RVA: 0x003A1294 File Offset: 0x0039F494
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

		// Token: 0x140002A4 RID: 676
		// (add) Token: 0x0600D4BA RID: 54458 RVA: 0x003A1330 File Offset: 0x0039F530
		// (remove) Token: 0x0600D4BB RID: 54459 RVA: 0x003A13CC File Offset: 0x0039F5CC
		public event Action EventOnGetSocialRelation
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGetSocialRelationAction_hotfix != null)
				{
					this.m_add_EventOnGetSocialRelationAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGetSocialRelation;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGetSocialRelation, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGetSocialRelationAction_hotfix != null)
				{
					this.m_remove_EventOnGetSocialRelationAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGetSocialRelation;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGetSocialRelation, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002A5 RID: 677
		// (add) Token: 0x0600D4BC RID: 54460 RVA: 0x003A1468 File Offset: 0x0039F668
		// (remove) Token: 0x0600D4BD RID: 54461 RVA: 0x003A1504 File Offset: 0x0039F704
		public event Action<BusinessCard> EventOnPrivateChatButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnPrivateChatButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnPrivateChatButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BusinessCard> action = this.EventOnPrivateChatButtonClick;
				Action<BusinessCard> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BusinessCard>>(ref this.EventOnPrivateChatButtonClick, (Action<BusinessCard>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnPrivateChatButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnPrivateChatButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BusinessCard> action = this.EventOnPrivateChatButtonClick;
				Action<BusinessCard> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BusinessCard>>(ref this.EventOnPrivateChatButtonClick, (Action<BusinessCard>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002A6 RID: 678
		// (add) Token: 0x0600D4BE RID: 54462 RVA: 0x003A15A0 File Offset: 0x0039F7A0
		// (remove) Token: 0x0600D4BF RID: 54463 RVA: 0x003A163C File Offset: 0x0039F83C
		public event Action EventOnBlockUser
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnBlockUserAction_hotfix != null)
				{
					this.m_add_EventOnBlockUserAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnBlockUser;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnBlockUser, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnBlockUserAction_hotfix != null)
				{
					this.m_remove_EventOnBlockUserAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnBlockUser;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnBlockUser, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1700298D RID: 10637
		// (get) Token: 0x0600D4C0 RID: 54464 RVA: 0x003A16D8 File Offset: 0x0039F8D8
		// (set) Token: 0x0600D4C1 RID: 54465 RVA: 0x003A16F8 File Offset: 0x0039F8F8
		[DoNotToLua]
		public new PlayerSimpleInfoUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new PlayerSimpleInfoUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600D4C2 RID: 54466 RVA: 0x003A1704 File Offset: 0x0039F904
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600D4C3 RID: 54467 RVA: 0x003A1710 File Offset: 0x0039F910
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600D4C4 RID: 54468 RVA: 0x003A1718 File Offset: 0x0039F918
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600D4C5 RID: 54469 RVA: 0x003A1720 File Offset: 0x0039F920
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600D4C6 RID: 54470 RVA: 0x003A172C File Offset: 0x0039F92C
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600D4C7 RID: 54471 RVA: 0x003A1738 File Offset: 0x0039F938
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600D4C8 RID: 54472 RVA: 0x003A1744 File Offset: 0x0039F944
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600D4C9 RID: 54473 RVA: 0x003A174C File Offset: 0x0039F94C
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600D4CA RID: 54474 RVA: 0x003A1754 File Offset: 0x0039F954
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600D4CB RID: 54475 RVA: 0x003A175C File Offset: 0x0039F95C
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600D4CC RID: 54476 RVA: 0x003A1764 File Offset: 0x0039F964
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600D4CD RID: 54477 RVA: 0x003A176C File Offset: 0x0039F96C
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600D4CE RID: 54478 RVA: 0x003A1774 File Offset: 0x0039F974
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600D4CF RID: 54479 RVA: 0x003A177C File Offset: 0x0039F97C
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600D4D0 RID: 54480 RVA: 0x003A1788 File Offset: 0x0039F988
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600D4D1 RID: 54481 RVA: 0x003A1794 File Offset: 0x0039F994
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600D4D2 RID: 54482 RVA: 0x003A17A0 File Offset: 0x0039F9A0
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600D4D3 RID: 54483 RVA: 0x003A17AC File Offset: 0x0039F9AC
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600D4D4 RID: 54484 RVA: 0x003A17B4 File Offset: 0x0039F9B4
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600D4D5 RID: 54485 RVA: 0x003A17BC File Offset: 0x0039F9BC
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600D4D6 RID: 54486 RVA: 0x003A17C4 File Offset: 0x0039F9C4
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600D4D7 RID: 54487 RVA: 0x003A17CC File Offset: 0x0039F9CC
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600D4D8 RID: 54488 RVA: 0x003A17D4 File Offset: 0x0039F9D4
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600D4D9 RID: 54489 RVA: 0x003A17DC File Offset: 0x0039F9DC
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0600D4DA RID: 54490 RVA: 0x003A17FC File Offset: 0x0039F9FC
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600D4DB RID: 54491 RVA: 0x003A1808 File Offset: 0x0039FA08
		private void __callDele_EventOnGetSocialRelation()
		{
			Action eventOnGetSocialRelation = this.EventOnGetSocialRelation;
			if (eventOnGetSocialRelation != null)
			{
				eventOnGetSocialRelation();
			}
		}

		// Token: 0x0600D4DC RID: 54492 RVA: 0x003A1828 File Offset: 0x0039FA28
		private void __clearDele_EventOnGetSocialRelation()
		{
			this.EventOnGetSocialRelation = null;
		}

		// Token: 0x0600D4DD RID: 54493 RVA: 0x003A1834 File Offset: 0x0039FA34
		private void __callDele_EventOnPrivateChatButtonClick(BusinessCard obj)
		{
			Action<BusinessCard> eventOnPrivateChatButtonClick = this.EventOnPrivateChatButtonClick;
			if (eventOnPrivateChatButtonClick != null)
			{
				eventOnPrivateChatButtonClick(obj);
			}
		}

		// Token: 0x0600D4DE RID: 54494 RVA: 0x003A1858 File Offset: 0x0039FA58
		private void __clearDele_EventOnPrivateChatButtonClick(BusinessCard obj)
		{
			this.EventOnPrivateChatButtonClick = null;
		}

		// Token: 0x0600D4DF RID: 54495 RVA: 0x003A1864 File Offset: 0x0039FA64
		private void __callDele_EventOnBlockUser()
		{
			Action eventOnBlockUser = this.EventOnBlockUser;
			if (eventOnBlockUser != null)
			{
				eventOnBlockUser();
			}
		}

		// Token: 0x0600D4E0 RID: 54496 RVA: 0x003A1884 File Offset: 0x0039FA84
		private void __clearDele_EventOnBlockUser()
		{
			this.EventOnBlockUser = null;
		}

		// Token: 0x0600D4E9 RID: 54505 RVA: 0x003A1BD0 File Offset: 0x0039FDD0
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
					this.m_InitlizeBeforeManagerStartIt_hotfix = (luaObj.RawGet("InitlizeBeforeManagerStartIt") as LuaFunction);
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_OnStop_hotfix = (luaObj.RawGet("OnStop") as LuaFunction);
					this.m_OnResumeUIIntent_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_IsNeedUpdateDataCache_hotfix = (luaObj.RawGet("IsNeedUpdateDataCache") as LuaFunction);
					this.m_UpdateDataCache_hotfix = (luaObj.RawGet("UpdateDataCache") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_IsInBattle_hotfix = (luaObj.RawGet("IsInBattle") as LuaFunction);
					this.m_PlayerSimpleInfoUIController_OnWatchCardString_hotfix = (luaObj.RawGet("PlayerSimpleInfoUIController_OnWatchCard") as LuaFunction);
					this.m_PlayerSimpleInfoUIController_OnPrivateChat_hotfix = (luaObj.RawGet("PlayerSimpleInfoUIController_OnPrivateChat") as LuaFunction);
					this.m_PlayerSimpleInfoUIController_OnPKString_hotfix = (luaObj.RawGet("PlayerSimpleInfoUIController_OnPK") as LuaFunction);
					this.m_PlayerSimpleInfoUIController_OnDeleteFriendBusinessCard_hotfix = (luaObj.RawGet("PlayerSimpleInfoUIController_OnDeleteFriend") as LuaFunction);
					this.m_OnDeleteFreindDialogBoxCallbackDialogBoxResult_hotfix = (luaObj.RawGet("OnDeleteFreindDialogBoxCallback") as LuaFunction);
					this.m_PlayerSimpleInfoUIController_OnAddFriendString_hotfix = (luaObj.RawGet("PlayerSimpleInfoUIController_OnAddFriend") as LuaFunction);
					this.m_PlayerSimpleInfoUIController_OnBlockString_hotfix = (luaObj.RawGet("PlayerSimpleInfoUIController_OnBlock") as LuaFunction);
					this.m_PlayerSimpleInfoUIController_OnLikeString_hotfix = (luaObj.RawGet("PlayerSimpleInfoUIController_OnLike") as LuaFunction);
					this.m_PlayerSimpleInfoUIController_OnReturn_hotfix = (luaObj.RawGet("PlayerSimpleInfoUIController_OnReturn") as LuaFunction);
					this.m_PlayerSimpleInfoUIController_OnExpelString_hotfix = (luaObj.RawGet("PlayerSimpleInfoUIController_OnExpel") as LuaFunction);
					this.m_PlayerSimpleInfoUIController_OnVChairmanChangeStringBoolean_hotfix = (luaObj.RawGet("PlayerSimpleInfoUIController_OnVChairmanChange") as LuaFunction);
					this.m_PlayerSimpleInfoUIController_ChairmanMoveString_hotfix = (luaObj.RawGet("PlayerSimpleInfoUIController_ChairmanMove") as LuaFunction);
					this.m_PlayerSimpleInfoUIController_OnChairmanRelieveString_hotfix = (luaObj.RawGet("PlayerSimpleInfoUIController_OnChairmanRelieve") as LuaFunction);
					this.m_ClosePanel_hotfix = (luaObj.RawGet("ClosePanel") as LuaFunction);
					this.m_RegisterUIEvent_hotfix = (luaObj.RawGet("RegisterUIEvent") as LuaFunction);
					this.m_UnRegiterUIEvent_hotfix = (luaObj.RawGet("UnRegiterUIEvent") as LuaFunction);
					this.m_SetPanelPostion_hotfix = (luaObj.RawGet("SetPanelPostion") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_add_EventOnGetSocialRelationAction_hotfix = (luaObj.RawGet("add_EventOnGetSocialRelation") as LuaFunction);
					this.m_remove_EventOnGetSocialRelationAction_hotfix = (luaObj.RawGet("remove_EventOnGetSocialRelation") as LuaFunction);
					this.m_add_EventOnPrivateChatButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnPrivateChatButtonClick") as LuaFunction);
					this.m_remove_EventOnPrivateChatButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnPrivateChatButtonClick") as LuaFunction);
					this.m_add_EventOnBlockUserAction_hotfix = (luaObj.RawGet("add_EventOnBlockUser") as LuaFunction);
					this.m_remove_EventOnBlockUserAction_hotfix = (luaObj.RawGet("remove_EventOnBlockUser") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600D4EA RID: 54506 RVA: 0x003A2020 File Offset: 0x003A0220
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PlayerSimpleInfoUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008366 RID: 33638
		private PlayerSimpleInfoUIController m_mainCtrl;

		// Token: 0x04008367 RID: 33639
		private BusinessCard m_currInfo;

		// Token: 0x04008368 RID: 33640
		private UIIntent m_returnUITaskIntent;

		// Token: 0x04008369 RID: 33641
		private Vector3 m_panelPos = Vector3.zero;

		// Token: 0x0400836A RID: 33642
		private PlayerSimpleInfoUITask.PostionType m_showPanelType = PlayerSimpleInfoUITask.PostionType.Right;

		// Token: 0x0400836B RID: 33643
		private string m_deleteFriendUserID;

		// Token: 0x0400836C RID: 33644
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "PlayerSimpleInfoUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Common_ABS/Prefab/PlayerSimpleInfoUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400836D RID: 33645
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "PlayerSimpleInfoUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.PlayerSimpleInfoUIController"),
				m_ctrlName = "PlayerSimpleInfoUIController"
			}
		};

		// Token: 0x0400836E RID: 33646
		public const string ModeParams_Stranger = "StrangerInfoMode";

		// Token: 0x0400836F RID: 33647
		public const string ModeParams_Friend = "FriendInfoMode";

		// Token: 0x04008370 RID: 33648
		public const string ModeParams_Guild = "GuildInfoMode";

		// Token: 0x04008375 RID: 33653
		public const string Params_PanelPos = "PlayerSimpleInfoPanelPostion";

		// Token: 0x04008376 RID: 33654
		public const string Params_PanelType = "PlayerSimpleInfoPanelType";

		// Token: 0x04008377 RID: 33655
		public const string Params_ReturnToIntent = "PlayerSimpleInfoReturnToIntent";

		// Token: 0x04008378 RID: 33656
		private List<string> m_friendAddList = new List<string>();

		// Token: 0x04008379 RID: 33657
		private ProjectLPlayerContext m_playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x0400837A RID: 33658
		private IConfigDataLoader m_configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;

		// Token: 0x0400837B RID: 33659
		[DoNotToLua]
		private PlayerSimpleInfoUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400837C RID: 33660
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400837D RID: 33661
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400837E RID: 33662
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400837F RID: 33663
		private LuaFunction m_InitlizeBeforeManagerStartIt_hotfix;

		// Token: 0x04008380 RID: 33664
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x04008381 RID: 33665
		private LuaFunction m_OnStop_hotfix;

		// Token: 0x04008382 RID: 33666
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x04008383 RID: 33667
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x04008384 RID: 33668
		private LuaFunction m_IsNeedUpdateDataCache_hotfix;

		// Token: 0x04008385 RID: 33669
		private LuaFunction m_UpdateDataCache_hotfix;

		// Token: 0x04008386 RID: 33670
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04008387 RID: 33671
		private LuaFunction m_IsInBattle_hotfix;

		// Token: 0x04008388 RID: 33672
		private LuaFunction m_PlayerSimpleInfoUIController_OnWatchCardString_hotfix;

		// Token: 0x04008389 RID: 33673
		private LuaFunction m_PlayerSimpleInfoUIController_OnPrivateChat_hotfix;

		// Token: 0x0400838A RID: 33674
		private LuaFunction m_PlayerSimpleInfoUIController_OnPKString_hotfix;

		// Token: 0x0400838B RID: 33675
		private LuaFunction m_PlayerSimpleInfoUIController_OnDeleteFriendBusinessCard_hotfix;

		// Token: 0x0400838C RID: 33676
		private LuaFunction m_OnDeleteFreindDialogBoxCallbackDialogBoxResult_hotfix;

		// Token: 0x0400838D RID: 33677
		private LuaFunction m_PlayerSimpleInfoUIController_OnAddFriendString_hotfix;

		// Token: 0x0400838E RID: 33678
		private LuaFunction m_PlayerSimpleInfoUIController_OnBlockString_hotfix;

		// Token: 0x0400838F RID: 33679
		private LuaFunction m_PlayerSimpleInfoUIController_OnLikeString_hotfix;

		// Token: 0x04008390 RID: 33680
		private LuaFunction m_PlayerSimpleInfoUIController_OnReturn_hotfix;

		// Token: 0x04008391 RID: 33681
		private LuaFunction m_PlayerSimpleInfoUIController_OnExpelString_hotfix;

		// Token: 0x04008392 RID: 33682
		private LuaFunction m_PlayerSimpleInfoUIController_OnVChairmanChangeStringBoolean_hotfix;

		// Token: 0x04008393 RID: 33683
		private LuaFunction m_PlayerSimpleInfoUIController_ChairmanMoveString_hotfix;

		// Token: 0x04008394 RID: 33684
		private LuaFunction m_PlayerSimpleInfoUIController_OnChairmanRelieveString_hotfix;

		// Token: 0x04008395 RID: 33685
		private LuaFunction m_ClosePanel_hotfix;

		// Token: 0x04008396 RID: 33686
		private LuaFunction m_RegisterUIEvent_hotfix;

		// Token: 0x04008397 RID: 33687
		private LuaFunction m_UnRegiterUIEvent_hotfix;

		// Token: 0x04008398 RID: 33688
		private LuaFunction m_SetPanelPostion_hotfix;

		// Token: 0x04008399 RID: 33689
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400839A RID: 33690
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x0400839B RID: 33691
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x0400839C RID: 33692
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x0400839D RID: 33693
		private LuaFunction m_add_EventOnGetSocialRelationAction_hotfix;

		// Token: 0x0400839E RID: 33694
		private LuaFunction m_remove_EventOnGetSocialRelationAction_hotfix;

		// Token: 0x0400839F RID: 33695
		private LuaFunction m_add_EventOnPrivateChatButtonClickAction;

		// Token: 0x040083A0 RID: 33696
		private LuaFunction m_remove_EventOnPrivateChatButtonClickAction;

		// Token: 0x040083A1 RID: 33697
		private LuaFunction m_add_EventOnBlockUserAction_hotfix;

		// Token: 0x040083A2 RID: 33698
		private LuaFunction m_remove_EventOnBlockUserAction_hotfix;

		// Token: 0x02000BED RID: 3053
		public enum PostionType
		{
			// Token: 0x040083A4 RID: 33700
			UseInput,
			// Token: 0x040083A5 RID: 33701
			Left,
			// Token: 0x040083A6 RID: 33702
			Right
		}

		// Token: 0x02000BEE RID: 3054
		public new class LuaExportHelper
		{
			// Token: 0x0600D4EB RID: 54507 RVA: 0x003A2088 File Offset: 0x003A0288
			public LuaExportHelper(PlayerSimpleInfoUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600D4EC RID: 54508 RVA: 0x003A2098 File Offset: 0x003A0298
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600D4ED RID: 54509 RVA: 0x003A20A8 File Offset: 0x003A02A8
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600D4EE RID: 54510 RVA: 0x003A20B8 File Offset: 0x003A02B8
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600D4EF RID: 54511 RVA: 0x003A20C8 File Offset: 0x003A02C8
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600D4F0 RID: 54512 RVA: 0x003A20D8 File Offset: 0x003A02D8
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600D4F1 RID: 54513 RVA: 0x003A20E8 File Offset: 0x003A02E8
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600D4F2 RID: 54514 RVA: 0x003A20F8 File Offset: 0x003A02F8
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600D4F3 RID: 54515 RVA: 0x003A2108 File Offset: 0x003A0308
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600D4F4 RID: 54516 RVA: 0x003A2118 File Offset: 0x003A0318
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600D4F5 RID: 54517 RVA: 0x003A2128 File Offset: 0x003A0328
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600D4F6 RID: 54518 RVA: 0x003A2138 File Offset: 0x003A0338
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600D4F7 RID: 54519 RVA: 0x003A2148 File Offset: 0x003A0348
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600D4F8 RID: 54520 RVA: 0x003A2158 File Offset: 0x003A0358
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600D4F9 RID: 54521 RVA: 0x003A2168 File Offset: 0x003A0368
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600D4FA RID: 54522 RVA: 0x003A2178 File Offset: 0x003A0378
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600D4FB RID: 54523 RVA: 0x003A2188 File Offset: 0x003A0388
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600D4FC RID: 54524 RVA: 0x003A2198 File Offset: 0x003A0398
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600D4FD RID: 54525 RVA: 0x003A21A8 File Offset: 0x003A03A8
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600D4FE RID: 54526 RVA: 0x003A21B8 File Offset: 0x003A03B8
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600D4FF RID: 54527 RVA: 0x003A21C8 File Offset: 0x003A03C8
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600D500 RID: 54528 RVA: 0x003A21D8 File Offset: 0x003A03D8
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600D501 RID: 54529 RVA: 0x003A21E8 File Offset: 0x003A03E8
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600D502 RID: 54530 RVA: 0x003A21F8 File Offset: 0x003A03F8
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x0600D503 RID: 54531 RVA: 0x003A2208 File Offset: 0x003A0408
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0600D504 RID: 54532 RVA: 0x003A2218 File Offset: 0x003A0418
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x0600D505 RID: 54533 RVA: 0x003A2228 File Offset: 0x003A0428
			public void __callDele_EventOnGetSocialRelation()
			{
				this.m_owner.__callDele_EventOnGetSocialRelation();
			}

			// Token: 0x0600D506 RID: 54534 RVA: 0x003A2238 File Offset: 0x003A0438
			public void __clearDele_EventOnGetSocialRelation()
			{
				this.m_owner.__clearDele_EventOnGetSocialRelation();
			}

			// Token: 0x0600D507 RID: 54535 RVA: 0x003A2248 File Offset: 0x003A0448
			public void __callDele_EventOnPrivateChatButtonClick(BusinessCard obj)
			{
				this.m_owner.__callDele_EventOnPrivateChatButtonClick(obj);
			}

			// Token: 0x0600D508 RID: 54536 RVA: 0x003A2258 File Offset: 0x003A0458
			public void __clearDele_EventOnPrivateChatButtonClick(BusinessCard obj)
			{
				this.m_owner.__clearDele_EventOnPrivateChatButtonClick(obj);
			}

			// Token: 0x0600D509 RID: 54537 RVA: 0x003A2268 File Offset: 0x003A0468
			public void __callDele_EventOnBlockUser()
			{
				this.m_owner.__callDele_EventOnBlockUser();
			}

			// Token: 0x0600D50A RID: 54538 RVA: 0x003A2278 File Offset: 0x003A0478
			public void __clearDele_EventOnBlockUser()
			{
				this.m_owner.__clearDele_EventOnBlockUser();
			}

			// Token: 0x1700298E RID: 10638
			// (get) Token: 0x0600D50B RID: 54539 RVA: 0x003A2288 File Offset: 0x003A0488
			// (set) Token: 0x0600D50C RID: 54540 RVA: 0x003A2298 File Offset: 0x003A0498
			public PlayerSimpleInfoUIController m_mainCtrl
			{
				get
				{
					return this.m_owner.m_mainCtrl;
				}
				set
				{
					this.m_owner.m_mainCtrl = value;
				}
			}

			// Token: 0x1700298F RID: 10639
			// (get) Token: 0x0600D50D RID: 54541 RVA: 0x003A22A8 File Offset: 0x003A04A8
			// (set) Token: 0x0600D50E RID: 54542 RVA: 0x003A22B8 File Offset: 0x003A04B8
			public BusinessCard m_currInfo
			{
				get
				{
					return this.m_owner.m_currInfo;
				}
				set
				{
					this.m_owner.m_currInfo = value;
				}
			}

			// Token: 0x17002990 RID: 10640
			// (get) Token: 0x0600D50F RID: 54543 RVA: 0x003A22C8 File Offset: 0x003A04C8
			// (set) Token: 0x0600D510 RID: 54544 RVA: 0x003A22D8 File Offset: 0x003A04D8
			public UIIntent m_returnUITaskIntent
			{
				get
				{
					return this.m_owner.m_returnUITaskIntent;
				}
				set
				{
					this.m_owner.m_returnUITaskIntent = value;
				}
			}

			// Token: 0x17002991 RID: 10641
			// (get) Token: 0x0600D511 RID: 54545 RVA: 0x003A22E8 File Offset: 0x003A04E8
			// (set) Token: 0x0600D512 RID: 54546 RVA: 0x003A22F8 File Offset: 0x003A04F8
			public Vector3 m_panelPos
			{
				get
				{
					return this.m_owner.m_panelPos;
				}
				set
				{
					this.m_owner.m_panelPos = value;
				}
			}

			// Token: 0x17002992 RID: 10642
			// (get) Token: 0x0600D513 RID: 54547 RVA: 0x003A2308 File Offset: 0x003A0508
			// (set) Token: 0x0600D514 RID: 54548 RVA: 0x003A2318 File Offset: 0x003A0518
			public PlayerSimpleInfoUITask.PostionType m_showPanelType
			{
				get
				{
					return this.m_owner.m_showPanelType;
				}
				set
				{
					this.m_owner.m_showPanelType = value;
				}
			}

			// Token: 0x17002993 RID: 10643
			// (get) Token: 0x0600D515 RID: 54549 RVA: 0x003A2328 File Offset: 0x003A0528
			// (set) Token: 0x0600D516 RID: 54550 RVA: 0x003A2338 File Offset: 0x003A0538
			public string m_deleteFriendUserID
			{
				get
				{
					return this.m_owner.m_deleteFriendUserID;
				}
				set
				{
					this.m_owner.m_deleteFriendUserID = value;
				}
			}

			// Token: 0x17002994 RID: 10644
			// (get) Token: 0x0600D517 RID: 54551 RVA: 0x003A2348 File Offset: 0x003A0548
			// (set) Token: 0x0600D518 RID: 54552 RVA: 0x003A2358 File Offset: 0x003A0558
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

			// Token: 0x17002995 RID: 10645
			// (get) Token: 0x0600D519 RID: 54553 RVA: 0x003A2368 File Offset: 0x003A0568
			// (set) Token: 0x0600D51A RID: 54554 RVA: 0x003A2378 File Offset: 0x003A0578
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

			// Token: 0x17002996 RID: 10646
			// (get) Token: 0x0600D51B RID: 54555 RVA: 0x003A2388 File Offset: 0x003A0588
			// (set) Token: 0x0600D51C RID: 54556 RVA: 0x003A2398 File Offset: 0x003A0598
			public List<string> m_friendAddList
			{
				get
				{
					return this.m_owner.m_friendAddList;
				}
				set
				{
					this.m_owner.m_friendAddList = value;
				}
			}

			// Token: 0x17002997 RID: 10647
			// (get) Token: 0x0600D51D RID: 54557 RVA: 0x003A23A8 File Offset: 0x003A05A8
			// (set) Token: 0x0600D51E RID: 54558 RVA: 0x003A23B8 File Offset: 0x003A05B8
			public ProjectLPlayerContext m_playerContext
			{
				get
				{
					return this.m_owner.m_playerContext;
				}
				set
				{
					this.m_owner.m_playerContext = value;
				}
			}

			// Token: 0x17002998 RID: 10648
			// (get) Token: 0x0600D51F RID: 54559 RVA: 0x003A23C8 File Offset: 0x003A05C8
			// (set) Token: 0x0600D520 RID: 54560 RVA: 0x003A23D8 File Offset: 0x003A05D8
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

			// Token: 0x17002999 RID: 10649
			// (get) Token: 0x0600D521 RID: 54561 RVA: 0x003A23E8 File Offset: 0x003A05E8
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x1700299A RID: 10650
			// (get) Token: 0x0600D522 RID: 54562 RVA: 0x003A23F8 File Offset: 0x003A05F8
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600D523 RID: 54563 RVA: 0x003A2408 File Offset: 0x003A0608
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0600D524 RID: 54564 RVA: 0x003A2418 File Offset: 0x003A0618
			public void OnStop()
			{
				this.m_owner.OnStop();
			}

			// Token: 0x0600D525 RID: 54565 RVA: 0x003A2428 File Offset: 0x003A0628
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x0600D526 RID: 54566 RVA: 0x003A2438 File Offset: 0x003A0638
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600D527 RID: 54567 RVA: 0x003A2448 File Offset: 0x003A0648
			public bool IsNeedUpdateDataCache()
			{
				return this.m_owner.IsNeedUpdateDataCache();
			}

			// Token: 0x0600D528 RID: 54568 RVA: 0x003A2458 File Offset: 0x003A0658
			public void UpdateDataCache()
			{
				this.m_owner.UpdateDataCache();
			}

			// Token: 0x0600D529 RID: 54569 RVA: 0x003A2468 File Offset: 0x003A0668
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600D52A RID: 54570 RVA: 0x003A2478 File Offset: 0x003A0678
			public bool IsInBattle()
			{
				return this.m_owner.IsInBattle();
			}

			// Token: 0x0600D52B RID: 54571 RVA: 0x003A2488 File Offset: 0x003A0688
			public void PlayerSimpleInfoUIController_OnWatchCard(string userID)
			{
				this.m_owner.PlayerSimpleInfoUIController_OnWatchCard(userID);
			}

			// Token: 0x0600D52C RID: 54572 RVA: 0x003A2498 File Offset: 0x003A0698
			public void PlayerSimpleInfoUIController_OnPrivateChat()
			{
				this.m_owner.PlayerSimpleInfoUIController_OnPrivateChat();
			}

			// Token: 0x0600D52D RID: 54573 RVA: 0x003A24A8 File Offset: 0x003A06A8
			public void PlayerSimpleInfoUIController_OnPK(string userID)
			{
				this.m_owner.PlayerSimpleInfoUIController_OnPK(userID);
			}

			// Token: 0x0600D52E RID: 54574 RVA: 0x003A24B8 File Offset: 0x003A06B8
			public void PlayerSimpleInfoUIController_OnDeleteFriend(BusinessCard userInfo)
			{
				this.m_owner.PlayerSimpleInfoUIController_OnDeleteFriend(userInfo);
			}

			// Token: 0x0600D52F RID: 54575 RVA: 0x003A24C8 File Offset: 0x003A06C8
			public void OnDeleteFreindDialogBoxCallback(DialogBoxResult r)
			{
				this.m_owner.OnDeleteFreindDialogBoxCallback(r);
			}

			// Token: 0x0600D530 RID: 54576 RVA: 0x003A24D8 File Offset: 0x003A06D8
			public void PlayerSimpleInfoUIController_OnAddFriend(string userID)
			{
				this.m_owner.PlayerSimpleInfoUIController_OnAddFriend(userID);
			}

			// Token: 0x0600D531 RID: 54577 RVA: 0x003A24E8 File Offset: 0x003A06E8
			public void PlayerSimpleInfoUIController_OnBlock(string userID)
			{
				this.m_owner.PlayerSimpleInfoUIController_OnBlock(userID);
			}

			// Token: 0x0600D532 RID: 54578 RVA: 0x003A24F8 File Offset: 0x003A06F8
			public void PlayerSimpleInfoUIController_OnLike(string userID)
			{
				this.m_owner.PlayerSimpleInfoUIController_OnLike(userID);
			}

			// Token: 0x0600D533 RID: 54579 RVA: 0x003A2508 File Offset: 0x003A0708
			public void PlayerSimpleInfoUIController_OnReturn()
			{
				this.m_owner.PlayerSimpleInfoUIController_OnReturn();
			}

			// Token: 0x0600D534 RID: 54580 RVA: 0x003A2518 File Offset: 0x003A0718
			public void PlayerSimpleInfoUIController_OnExpel(string userId)
			{
				this.m_owner.PlayerSimpleInfoUIController_OnExpel(userId);
			}

			// Token: 0x0600D535 RID: 54581 RVA: 0x003A2528 File Offset: 0x003A0728
			public void PlayerSimpleInfoUIController_OnVChairmanChange(string userId, bool isAppiont)
			{
				this.m_owner.PlayerSimpleInfoUIController_OnVChairmanChange(userId, isAppiont);
			}

			// Token: 0x0600D536 RID: 54582 RVA: 0x003A2538 File Offset: 0x003A0738
			public void PlayerSimpleInfoUIController_ChairmanMove(string userId)
			{
				this.m_owner.PlayerSimpleInfoUIController_ChairmanMove(userId);
			}

			// Token: 0x0600D537 RID: 54583 RVA: 0x003A2548 File Offset: 0x003A0748
			public void PlayerSimpleInfoUIController_OnChairmanRelieve(string userId)
			{
				this.m_owner.PlayerSimpleInfoUIController_OnChairmanRelieve(userId);
			}

			// Token: 0x0600D538 RID: 54584 RVA: 0x003A2558 File Offset: 0x003A0758
			public void ClosePanel()
			{
				this.m_owner.ClosePanel();
			}

			// Token: 0x0600D539 RID: 54585 RVA: 0x003A2568 File Offset: 0x003A0768
			public void RegisterUIEvent()
			{
				this.m_owner.RegisterUIEvent();
			}

			// Token: 0x0600D53A RID: 54586 RVA: 0x003A2578 File Offset: 0x003A0778
			public void UnRegiterUIEvent()
			{
				this.m_owner.UnRegiterUIEvent();
			}

			// Token: 0x0600D53B RID: 54587 RVA: 0x003A2588 File Offset: 0x003A0788
			public void SetPanelPostion()
			{
				this.m_owner.SetPanelPostion();
			}

			// Token: 0x040083A7 RID: 33703
			private PlayerSimpleInfoUITask m_owner;
		}
	}
}
