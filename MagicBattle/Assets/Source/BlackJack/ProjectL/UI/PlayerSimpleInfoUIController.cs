using System;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectLBasic;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000BEA RID: 3050
	[HotFix]
	public class PlayerSimpleInfoUIController : UIControllerBase
	{
		// Token: 0x0600D3FF RID: 54271 RVA: 0x0039CD80 File Offset: 0x0039AF80
		protected override void OnBindFiledsCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBindFiledsCompleted_hotfix != null)
			{
				this.m_OnBindFiledsCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnBindFiledsCompleted();
			this.WatchButton.onClick.AddListener(new UnityAction(this.OnWatchCardButtonClick));
			this.FightButton.onClick.AddListener(new UnityAction(this.OnPKButtonClick));
			this.FightGreyButton.onClick.AddListener(new UnityAction(this.OnPKGreyButton));
			this.ChatButton.onClick.AddListener(new UnityAction(this.OnPrivateChatButtonClick));
			this.DeleteFriendButton.onClick.AddListener(new UnityAction(this.OnDeleteFriendButtonClick));
			this.AddFriendButton.onClick.AddListener(new UnityAction(this.OnAddFriendButtonClick));
			this.LikeButton.onClick.AddListener(new UnityAction(this.OnLikeButtonClick));
			this.ShieldButton.onClick.AddListener(new UnityAction(this.OnBlockButtonClick));
			this.BGButton.onClick.AddListener(new UnityAction(this.OnBGButtonClick));
			this.SetGuildButtonGroupListener();
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
		}

		// Token: 0x0600D400 RID: 54272 RVA: 0x0039CF00 File Offset: 0x0039B100
		public void UpdatePlayerInfo(BusinessCard playerInfo, bool isFriend, bool canSendLike, bool isInBattle, bool isInTeamRoom)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdatePlayerInfoBusinessCardBooleanBooleanBooleanBoolean_hotfix != null)
			{
				this.m_UpdatePlayerInfoBusinessCardBooleanBooleanBooleanBoolean_hotfix.call(new object[]
				{
					this,
					playerInfo,
					isFriend,
					canSendLike,
					isInBattle,
					isInTeamRoom
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerInfo = playerInfo;
			this.PanelShowStateCtrl.SetToUIState((!isFriend) ? "Stranger" : "Friend", false, true);
			this.PlayerIcon.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerSmallHeadIconImageName(HeadIconTools.GetHeadPortrait(playerInfo.HeadIcon)));
			UIUtility.SetPlayerHeadFrame(this.m_headFrameTransform, HeadIconTools.GetHeadFrame(playerInfo.HeadIcon), true, "Normal");
			this.PlayerNameText.text = playerInfo.Name;
			this.LevelText.text = playerInfo.Level.ToString();
			this.LikeNumberText.text = playerInfo.Likes.ToString();
			this.m_canNotFightStringTableId = (StringTableId)0;
			if (isInBattle)
			{
				this.m_canNotFightStringTableId = StringTableId.StringTableId_PlayerSimpleInfo_InBattleCanNotPVP;
			}
			else if (isInTeamRoom)
			{
				this.m_canNotFightStringTableId = StringTableId.StringTableId_PlayerSimpleInfo_InTeamRoomCanNotPVP;
			}
			else if (!playerInfo.IsOnLine)
			{
				this.m_canNotFightStringTableId = StringTableId.StringTableId_PlayerSimpleInfo_PlayerNotOnlineCanNotPVP;
			}
			this.FightButton.gameObject.SetActive(this.m_canNotFightStringTableId == (StringTableId)0);
			this.FightGreyButton.gameObject.SetActive(this.m_canNotFightStringTableId != (StringTableId)0);
			this.m_likeUIStateController.SetToUIState((!canSendLike) ? "Normal" : "Grey", false, true);
		}

		// Token: 0x0600D401 RID: 54273 RVA: 0x0039D10C File Offset: 0x0039B30C
		public void ShowOrHide(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowOrHideBoolean_hotfix != null)
			{
				this.m_ShowOrHideBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.PanelOpenOrCloseStateCtrl.SetToUIState((!isShow) ? "Close" : "Show", false, true);
		}

		// Token: 0x0600D402 RID: 54274 RVA: 0x0039D1A0 File Offset: 0x0039B3A0
		public Rect GetViewRect()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetViewRect_hotfix != null)
			{
				return (Rect)this.m_GetViewRect_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Vector3[] array = new Vector3[4];
			(this.BGButton.gameObject.transform as RectTransform).GetWorldCorners(array);
			Vector2 size = new Vector2(array[3].x - array[0].x, array[1].y - array[0].y);
			return new Rect(array[0], size);
		}

		// Token: 0x0600D403 RID: 54275 RVA: 0x0039D280 File Offset: 0x0039B480
		private Vector2 GetPanelSize()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPanelSize_hotfix != null)
			{
				return (Vector2)this.m_GetPanelSize_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Canvas.ForceUpdateCanvases();
			Vector3[] array = new Vector3[4];
			(this.PanelRoot.transform as RectTransform).GetWorldCorners(array);
			return new Vector2(Mathf.Abs(array[2].x - array[0].x), Mathf.Abs(array[2].y - array[0].y));
		}

		// Token: 0x0600D404 RID: 54276 RVA: 0x0039D350 File Offset: 0x0039B550
		public void SetPanelPosition(Vector3 pos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPanelPositionVector3_hotfix != null)
			{
				this.m_SetPanelPositionVector3_hotfix.call(new object[]
				{
					this,
					pos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.PanelRoot.transform.position = pos;
			Vector3 localPosition = this.PanelRoot.transform.localPosition;
			this.PanelRoot.transform.localPosition = new Vector3(localPosition.x, localPosition.y, 0f);
		}

		// Token: 0x0600D405 RID: 54277 RVA: 0x0039D40C File Offset: 0x0039B60C
		public void SetGuildButtonGroupStateByMode(string mode)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGuildButtonGroupStateByModeString_hotfix != null)
			{
				this.m_SetGuildButtonGroupStateByModeString_hotfix.call(new object[]
				{
					this,
					mode
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string text = null;
			if (mode != null)
			{
				if (!(mode == "StrangerInfoMode") && !(mode == "FriendInfoMode"))
				{
					if (mode == "GuildInfoMode")
					{
						GuildTitle title = this.m_playerContext.GetGuildInfo().FindMember(this.m_playerInfo.UserId).Member.Title;
						GuildTitle title2 = this.m_playerContext.GetGuildInfo().FindMember(this.m_playerContext.GetUserId()).Member.Title;
						if (title2 == GuildTitle.President)
						{
							if (title == GuildTitle.VP)
							{
								text = "ChairmanToVC";
							}
							else
							{
								text = "ChairmanToEliteAndNormal";
							}
						}
						else if (title2 == GuildTitle.VP)
						{
							if (title == GuildTitle.President)
							{
								text = "VCToChairman";
							}
							else if (title == GuildTitle.VP)
							{
								text = "NormalToOther";
							}
							else
							{
								text = "VCToEliteAndNormal";
							}
						}
						else if (title2 == GuildTitle.Elite)
						{
							if (title == GuildTitle.President)
							{
								text = "EliteToChairman";
							}
							else
							{
								text = "NormalToOther";
							}
						}
						else if (title2 == GuildTitle.Normal)
						{
							text = "NormalToOther";
						}
					}
				}
				else
				{
					text = "NormalToOther";
				}
			}
			if (text != null)
			{
				UIUtility.SetUIState(this.SociatyButtonGroupStateCtrl, text, null, false, true);
			}
		}

		// Token: 0x0600D406 RID: 54278 RVA: 0x0039D5BC File Offset: 0x0039B7BC
		private void SetGuildButtonGroupListener()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGuildButtonGroupListener_hotfix != null)
			{
				this.m_SetGuildButtonGroupListener_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ChairmanRelieveButton.onClick.AddListener(new UnityAction(this.OnChairmanRelieveButtonClick));
			this.ChairmanMoveButton.onClick.AddListener(new UnityAction(this.OnChairmanMoveButtonClick));
			this.VChairmanButton.onClick.AddListener(new UnityAction(this.OnVChairmanButtonClick));
			this.VChairmanChangeButton.onClick.AddListener(new UnityAction(this.OnVChairmanChangeButtonClick));
			this.ExpelButton.onClick.AddListener(new UnityAction(this.OnExpelButtonClick));
		}

		// Token: 0x0600D407 RID: 54279 RVA: 0x0039D6A8 File Offset: 0x0039B8A8
		private void OnExpelButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnExpelButtonClick_hotfix != null)
			{
				this.m_OnExpelButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			string msgText = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Guild_ConfirmRemoveMember);
			CommonUIController.Instance.ShowDialogBox(msgText, delegate(DialogBoxResult result)
			{
				if (result == DialogBoxResult.Ok)
				{
					int num = this.m_playerContext.CanKickOutGuild();
					if (num == 0)
					{
						if (this.EventOnExpelButtonClick != null)
						{
							this.EventOnExpelButtonClick(this.m_playerInfo.UserId);
						}
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
					}
				}
			}, string.Empty, null);
		}

		// Token: 0x0600D408 RID: 54280 RVA: 0x0039D744 File Offset: 0x0039B944
		private void OnVChairmanChangeButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnVChairmanChangeButtonClick_hotfix != null)
			{
				this.m_OnVChairmanChangeButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnVChairmanChangeButtonClick != null)
			{
				this.EventOnVChairmanChangeButtonClick(this.m_playerInfo.UserId, false);
			}
		}

		// Token: 0x0600D409 RID: 54281 RVA: 0x0039D7C8 File Offset: 0x0039B9C8
		private void OnVChairmanButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnVChairmanButtonClick_hotfix != null)
			{
				this.m_OnVChairmanButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnVChairmanChangeButtonClick != null)
			{
				this.EventOnVChairmanChangeButtonClick(this.m_playerInfo.UserId, true);
			}
		}

		// Token: 0x0600D40A RID: 54282 RVA: 0x0039D84C File Offset: 0x0039BA4C
		private void OnChairmanMoveButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnChairmanMoveButtonClick_hotfix != null)
			{
				this.m_OnChairmanMoveButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			string msgText = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Guild_ConfirmMoveChairman);
			CommonUIController.Instance.ShowDialogBox(msgText, delegate(DialogBoxResult result)
			{
				if (result == DialogBoxResult.Ok && this.EventOnChairmanMoveButtonClick != null)
				{
					this.EventOnChairmanMoveButtonClick(this.m_playerInfo.UserId);
				}
			}, string.Empty, null);
		}

		// Token: 0x0600D40B RID: 54283 RVA: 0x0039D8E8 File Offset: 0x0039BAE8
		private void OnChairmanRelieveButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnChairmanRelieveButtonClick_hotfix != null)
			{
				this.m_OnChairmanRelieveButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnChairmanRelieveButtonClick != null)
			{
				this.EventOnChairmanRelieveButtonClick(this.m_playerInfo.UserId);
			}
		}

		// Token: 0x0600D40C RID: 54284 RVA: 0x0039D96C File Offset: 0x0039BB6C
		private void OnWatchCardButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnWatchCardButtonClick_hotfix != null)
			{
				this.m_OnWatchCardButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnWatchCardButtonClick != null)
			{
				this.EventOnWatchCardButtonClick(this.m_playerInfo.UserId);
			}
		}

		// Token: 0x0600D40D RID: 54285 RVA: 0x0039D9F0 File Offset: 0x0039BBF0
		private void OnPrivateChatButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPrivateChatButtonClick_hotfix != null)
			{
				this.m_OnPrivateChatButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnPrivateChatButtonClick != null)
			{
				this.EventOnPrivateChatButtonClick();
			}
		}

		// Token: 0x0600D40E RID: 54286 RVA: 0x0039DA68 File Offset: 0x0039BC68
		private void OnPKButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPKButtonClick_hotfix != null)
			{
				this.m_OnPKButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnPKButtonClick != null)
			{
				this.EventOnPKButtonClick(this.m_playerInfo.UserId);
			}
		}

		// Token: 0x0600D40F RID: 54287 RVA: 0x0039DAEC File Offset: 0x0039BCEC
		private void OnPKGreyButton()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPKGreyButton_hotfix != null)
			{
				this.m_OnPKGreyButton_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowMessage(this.m_canNotFightStringTableId, 2f, null, true);
		}

		// Token: 0x0600D410 RID: 54288 RVA: 0x0039DB64 File Offset: 0x0039BD64
		private void OnDeleteFriendButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDeleteFriendButtonClick_hotfix != null)
			{
				this.m_OnDeleteFriendButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnDeleteFriendButtonClick != null)
			{
				this.EventOnDeleteFriendButtonClick(this.m_playerInfo);
			}
		}

		// Token: 0x0600D411 RID: 54289 RVA: 0x0039DBE0 File Offset: 0x0039BDE0
		private void OnAddFriendButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAddFriendButtonClick_hotfix != null)
			{
				this.m_OnAddFriendButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnAddFriendButtonClick != null)
			{
				this.EventOnAddFriendButtonClick(this.m_playerInfo.UserId);
			}
		}

		// Token: 0x0600D412 RID: 54290 RVA: 0x0039DC64 File Offset: 0x0039BE64
		private void OnBlockButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBlockButtonClick_hotfix != null)
			{
				this.m_OnBlockButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnBlockButtonClick != null)
			{
				this.EventOnBlockButtonClick(this.m_playerInfo.UserId);
			}
		}

		// Token: 0x0600D413 RID: 54291 RVA: 0x0039DCE8 File Offset: 0x0039BEE8
		private void OnLikeButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLikeButtonClick_hotfix != null)
			{
				this.m_OnLikeButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnLikeButtonClick != null)
			{
				this.EventOnLikeButtonClick(this.m_playerInfo.UserId);
			}
		}

		// Token: 0x0600D414 RID: 54292 RVA: 0x0039DD6C File Offset: 0x0039BF6C
		private void OnBGButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBGButtonClick_hotfix != null)
			{
				this.m_OnBGButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnBGButtonClick != null)
			{
				this.EventOnBGButtonClick();
			}
		}

		// Token: 0x14000297 RID: 663
		// (add) Token: 0x0600D415 RID: 54293 RVA: 0x0039DDE4 File Offset: 0x0039BFE4
		// (remove) Token: 0x0600D416 RID: 54294 RVA: 0x0039DE80 File Offset: 0x0039C080
		public event Action<string> EventOnWatchCardButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnWatchCardButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnWatchCardButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnWatchCardButtonClick;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnWatchCardButtonClick, (Action<string>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnWatchCardButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnWatchCardButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnWatchCardButtonClick;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnWatchCardButtonClick, (Action<string>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000298 RID: 664
		// (add) Token: 0x0600D417 RID: 54295 RVA: 0x0039DF1C File Offset: 0x0039C11C
		// (remove) Token: 0x0600D418 RID: 54296 RVA: 0x0039DFB8 File Offset: 0x0039C1B8
		public event Action EventOnPrivateChatButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnPrivateChatButtonClickAction_hotfix != null)
				{
					this.m_add_EventOnPrivateChatButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnPrivateChatButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnPrivateChatButtonClick, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnPrivateChatButtonClickAction_hotfix != null)
				{
					this.m_remove_EventOnPrivateChatButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnPrivateChatButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnPrivateChatButtonClick, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000299 RID: 665
		// (add) Token: 0x0600D419 RID: 54297 RVA: 0x0039E054 File Offset: 0x0039C254
		// (remove) Token: 0x0600D41A RID: 54298 RVA: 0x0039E0F0 File Offset: 0x0039C2F0
		public event Action<string> EventOnPKButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnPKButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnPKButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnPKButtonClick;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnPKButtonClick, (Action<string>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnPKButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnPKButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnPKButtonClick;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnPKButtonClick, (Action<string>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400029A RID: 666
		// (add) Token: 0x0600D41B RID: 54299 RVA: 0x0039E18C File Offset: 0x0039C38C
		// (remove) Token: 0x0600D41C RID: 54300 RVA: 0x0039E228 File Offset: 0x0039C428
		public event Action<BusinessCard> EventOnDeleteFriendButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnDeleteFriendButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnDeleteFriendButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BusinessCard> action = this.EventOnDeleteFriendButtonClick;
				Action<BusinessCard> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BusinessCard>>(ref this.EventOnDeleteFriendButtonClick, (Action<BusinessCard>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnDeleteFriendButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnDeleteFriendButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BusinessCard> action = this.EventOnDeleteFriendButtonClick;
				Action<BusinessCard> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BusinessCard>>(ref this.EventOnDeleteFriendButtonClick, (Action<BusinessCard>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400029B RID: 667
		// (add) Token: 0x0600D41D RID: 54301 RVA: 0x0039E2C4 File Offset: 0x0039C4C4
		// (remove) Token: 0x0600D41E RID: 54302 RVA: 0x0039E360 File Offset: 0x0039C560
		public event Action<string> EventOnAddFriendButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAddFriendButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnAddFriendButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnAddFriendButtonClick;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnAddFriendButtonClick, (Action<string>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAddFriendButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnAddFriendButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnAddFriendButtonClick;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnAddFriendButtonClick, (Action<string>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400029C RID: 668
		// (add) Token: 0x0600D41F RID: 54303 RVA: 0x0039E3FC File Offset: 0x0039C5FC
		// (remove) Token: 0x0600D420 RID: 54304 RVA: 0x0039E498 File Offset: 0x0039C698
		public event Action<string> EventOnBlockButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnBlockButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnBlockButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnBlockButtonClick;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnBlockButtonClick, (Action<string>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnBlockButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnBlockButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnBlockButtonClick;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnBlockButtonClick, (Action<string>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400029D RID: 669
		// (add) Token: 0x0600D421 RID: 54305 RVA: 0x0039E534 File Offset: 0x0039C734
		// (remove) Token: 0x0600D422 RID: 54306 RVA: 0x0039E5D0 File Offset: 0x0039C7D0
		public event Action<string> EventOnLikeButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnLikeButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnLikeButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnLikeButtonClick;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnLikeButtonClick, (Action<string>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnLikeButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnLikeButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnLikeButtonClick;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnLikeButtonClick, (Action<string>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400029E RID: 670
		// (add) Token: 0x0600D423 RID: 54307 RVA: 0x0039E66C File Offset: 0x0039C86C
		// (remove) Token: 0x0600D424 RID: 54308 RVA: 0x0039E708 File Offset: 0x0039C908
		public event Action EventOnBGButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnBGButtonClickAction_hotfix != null)
				{
					this.m_add_EventOnBGButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnBGButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnBGButtonClick, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnBGButtonClickAction_hotfix != null)
				{
					this.m_remove_EventOnBGButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnBGButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnBGButtonClick, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400029F RID: 671
		// (add) Token: 0x0600D425 RID: 54309 RVA: 0x0039E7A4 File Offset: 0x0039C9A4
		// (remove) Token: 0x0600D426 RID: 54310 RVA: 0x0039E840 File Offset: 0x0039CA40
		public event Action<string> EventOnChairmanRelieveButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnChairmanRelieveButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnChairmanRelieveButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnChairmanRelieveButtonClick;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnChairmanRelieveButtonClick, (Action<string>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnChairmanRelieveButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnChairmanRelieveButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnChairmanRelieveButtonClick;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnChairmanRelieveButtonClick, (Action<string>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002A0 RID: 672
		// (add) Token: 0x0600D427 RID: 54311 RVA: 0x0039E8DC File Offset: 0x0039CADC
		// (remove) Token: 0x0600D428 RID: 54312 RVA: 0x0039E978 File Offset: 0x0039CB78
		public event Action<string> EventOnChairmanMoveButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnChairmanMoveButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnChairmanMoveButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnChairmanMoveButtonClick;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnChairmanMoveButtonClick, (Action<string>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnChairmanMoveButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnChairmanMoveButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnChairmanMoveButtonClick;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnChairmanMoveButtonClick, (Action<string>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002A1 RID: 673
		// (add) Token: 0x0600D429 RID: 54313 RVA: 0x0039EA14 File Offset: 0x0039CC14
		// (remove) Token: 0x0600D42A RID: 54314 RVA: 0x0039EAB0 File Offset: 0x0039CCB0
		public event Action<string, bool> EventOnVChairmanChangeButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnVChairmanChangeButtonClickAction`2_hotfix != null)
				{
					this.m_add_EventOnVChairmanChangeButtonClickAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string, bool> action = this.EventOnVChairmanChangeButtonClick;
				Action<string, bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string, bool>>(ref this.EventOnVChairmanChangeButtonClick, (Action<string, bool>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnVChairmanChangeButtonClickAction`2_hotfix != null)
				{
					this.m_remove_EventOnVChairmanChangeButtonClickAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string, bool> action = this.EventOnVChairmanChangeButtonClick;
				Action<string, bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string, bool>>(ref this.EventOnVChairmanChangeButtonClick, (Action<string, bool>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002A2 RID: 674
		// (add) Token: 0x0600D42B RID: 54315 RVA: 0x0039EB4C File Offset: 0x0039CD4C
		// (remove) Token: 0x0600D42C RID: 54316 RVA: 0x0039EBE8 File Offset: 0x0039CDE8
		public event Action<string> EventOnExpelButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnExpelButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnExpelButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnExpelButtonClick;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnExpelButtonClick, (Action<string>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnExpelButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnExpelButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnExpelButtonClick;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnExpelButtonClick, (Action<string>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002986 RID: 10630
		// (get) Token: 0x0600D42D RID: 54317 RVA: 0x0039EC84 File Offset: 0x0039CE84
		public Vector2 PanelSize
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_PanelSize_hotfix != null)
				{
					return (Vector2)this.m_get_PanelSize_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.GetPanelSize();
			}
		}

		// Token: 0x17002987 RID: 10631
		// (get) Token: 0x0600D42E RID: 54318 RVA: 0x0039ECF8 File Offset: 0x0039CEF8
		// (set) Token: 0x0600D42F RID: 54319 RVA: 0x0039ED18 File Offset: 0x0039CF18
		[DoNotToLua]
		public new PlayerSimpleInfoUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new PlayerSimpleInfoUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600D430 RID: 54320 RVA: 0x0039ED24 File Offset: 0x0039CF24
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600D431 RID: 54321 RVA: 0x0039ED30 File Offset: 0x0039CF30
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600D432 RID: 54322 RVA: 0x0039ED38 File Offset: 0x0039CF38
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600D433 RID: 54323 RVA: 0x0039ED40 File Offset: 0x0039CF40
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600D434 RID: 54324 RVA: 0x0039ED54 File Offset: 0x0039CF54
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600D435 RID: 54325 RVA: 0x0039ED5C File Offset: 0x0039CF5C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600D436 RID: 54326 RVA: 0x0039ED68 File Offset: 0x0039CF68
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600D437 RID: 54327 RVA: 0x0039ED74 File Offset: 0x0039CF74
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600D438 RID: 54328 RVA: 0x0039ED80 File Offset: 0x0039CF80
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600D439 RID: 54329 RVA: 0x0039ED8C File Offset: 0x0039CF8C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600D43A RID: 54330 RVA: 0x0039ED98 File Offset: 0x0039CF98
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600D43B RID: 54331 RVA: 0x0039EDA4 File Offset: 0x0039CFA4
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600D43C RID: 54332 RVA: 0x0039EDB0 File Offset: 0x0039CFB0
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600D43D RID: 54333 RVA: 0x0039EDBC File Offset: 0x0039CFBC
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600D43E RID: 54334 RVA: 0x0039EDC8 File Offset: 0x0039CFC8
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600D43F RID: 54335 RVA: 0x0039EDD0 File Offset: 0x0039CFD0
		private void __callDele_EventOnWatchCardButtonClick(string obj)
		{
			Action<string> eventOnWatchCardButtonClick = this.EventOnWatchCardButtonClick;
			if (eventOnWatchCardButtonClick != null)
			{
				eventOnWatchCardButtonClick(obj);
			}
		}

		// Token: 0x0600D440 RID: 54336 RVA: 0x0039EDF4 File Offset: 0x0039CFF4
		private void __clearDele_EventOnWatchCardButtonClick(string obj)
		{
			this.EventOnWatchCardButtonClick = null;
		}

		// Token: 0x0600D441 RID: 54337 RVA: 0x0039EE00 File Offset: 0x0039D000
		private void __callDele_EventOnPrivateChatButtonClick()
		{
			Action eventOnPrivateChatButtonClick = this.EventOnPrivateChatButtonClick;
			if (eventOnPrivateChatButtonClick != null)
			{
				eventOnPrivateChatButtonClick();
			}
		}

		// Token: 0x0600D442 RID: 54338 RVA: 0x0039EE20 File Offset: 0x0039D020
		private void __clearDele_EventOnPrivateChatButtonClick()
		{
			this.EventOnPrivateChatButtonClick = null;
		}

		// Token: 0x0600D443 RID: 54339 RVA: 0x0039EE2C File Offset: 0x0039D02C
		private void __callDele_EventOnPKButtonClick(string obj)
		{
			Action<string> eventOnPKButtonClick = this.EventOnPKButtonClick;
			if (eventOnPKButtonClick != null)
			{
				eventOnPKButtonClick(obj);
			}
		}

		// Token: 0x0600D444 RID: 54340 RVA: 0x0039EE50 File Offset: 0x0039D050
		private void __clearDele_EventOnPKButtonClick(string obj)
		{
			this.EventOnPKButtonClick = null;
		}

		// Token: 0x0600D445 RID: 54341 RVA: 0x0039EE5C File Offset: 0x0039D05C
		private void __callDele_EventOnDeleteFriendButtonClick(BusinessCard obj)
		{
			Action<BusinessCard> eventOnDeleteFriendButtonClick = this.EventOnDeleteFriendButtonClick;
			if (eventOnDeleteFriendButtonClick != null)
			{
				eventOnDeleteFriendButtonClick(obj);
			}
		}

		// Token: 0x0600D446 RID: 54342 RVA: 0x0039EE80 File Offset: 0x0039D080
		private void __clearDele_EventOnDeleteFriendButtonClick(BusinessCard obj)
		{
			this.EventOnDeleteFriendButtonClick = null;
		}

		// Token: 0x0600D447 RID: 54343 RVA: 0x0039EE8C File Offset: 0x0039D08C
		private void __callDele_EventOnAddFriendButtonClick(string obj)
		{
			Action<string> eventOnAddFriendButtonClick = this.EventOnAddFriendButtonClick;
			if (eventOnAddFriendButtonClick != null)
			{
				eventOnAddFriendButtonClick(obj);
			}
		}

		// Token: 0x0600D448 RID: 54344 RVA: 0x0039EEB0 File Offset: 0x0039D0B0
		private void __clearDele_EventOnAddFriendButtonClick(string obj)
		{
			this.EventOnAddFriendButtonClick = null;
		}

		// Token: 0x0600D449 RID: 54345 RVA: 0x0039EEBC File Offset: 0x0039D0BC
		private void __callDele_EventOnBlockButtonClick(string obj)
		{
			Action<string> eventOnBlockButtonClick = this.EventOnBlockButtonClick;
			if (eventOnBlockButtonClick != null)
			{
				eventOnBlockButtonClick(obj);
			}
		}

		// Token: 0x0600D44A RID: 54346 RVA: 0x0039EEE0 File Offset: 0x0039D0E0
		private void __clearDele_EventOnBlockButtonClick(string obj)
		{
			this.EventOnBlockButtonClick = null;
		}

		// Token: 0x0600D44B RID: 54347 RVA: 0x0039EEEC File Offset: 0x0039D0EC
		private void __callDele_EventOnLikeButtonClick(string obj)
		{
			Action<string> eventOnLikeButtonClick = this.EventOnLikeButtonClick;
			if (eventOnLikeButtonClick != null)
			{
				eventOnLikeButtonClick(obj);
			}
		}

		// Token: 0x0600D44C RID: 54348 RVA: 0x0039EF10 File Offset: 0x0039D110
		private void __clearDele_EventOnLikeButtonClick(string obj)
		{
			this.EventOnLikeButtonClick = null;
		}

		// Token: 0x0600D44D RID: 54349 RVA: 0x0039EF1C File Offset: 0x0039D11C
		private void __callDele_EventOnBGButtonClick()
		{
			Action eventOnBGButtonClick = this.EventOnBGButtonClick;
			if (eventOnBGButtonClick != null)
			{
				eventOnBGButtonClick();
			}
		}

		// Token: 0x0600D44E RID: 54350 RVA: 0x0039EF3C File Offset: 0x0039D13C
		private void __clearDele_EventOnBGButtonClick()
		{
			this.EventOnBGButtonClick = null;
		}

		// Token: 0x0600D44F RID: 54351 RVA: 0x0039EF48 File Offset: 0x0039D148
		private void __callDele_EventOnChairmanRelieveButtonClick(string obj)
		{
			Action<string> eventOnChairmanRelieveButtonClick = this.EventOnChairmanRelieveButtonClick;
			if (eventOnChairmanRelieveButtonClick != null)
			{
				eventOnChairmanRelieveButtonClick(obj);
			}
		}

		// Token: 0x0600D450 RID: 54352 RVA: 0x0039EF6C File Offset: 0x0039D16C
		private void __clearDele_EventOnChairmanRelieveButtonClick(string obj)
		{
			this.EventOnChairmanRelieveButtonClick = null;
		}

		// Token: 0x0600D451 RID: 54353 RVA: 0x0039EF78 File Offset: 0x0039D178
		private void __callDele_EventOnChairmanMoveButtonClick(string obj)
		{
			Action<string> eventOnChairmanMoveButtonClick = this.EventOnChairmanMoveButtonClick;
			if (eventOnChairmanMoveButtonClick != null)
			{
				eventOnChairmanMoveButtonClick(obj);
			}
		}

		// Token: 0x0600D452 RID: 54354 RVA: 0x0039EF9C File Offset: 0x0039D19C
		private void __clearDele_EventOnChairmanMoveButtonClick(string obj)
		{
			this.EventOnChairmanMoveButtonClick = null;
		}

		// Token: 0x0600D453 RID: 54355 RVA: 0x0039EFA8 File Offset: 0x0039D1A8
		private void __callDele_EventOnVChairmanChangeButtonClick(string arg1, bool arg2)
		{
			Action<string, bool> eventOnVChairmanChangeButtonClick = this.EventOnVChairmanChangeButtonClick;
			if (eventOnVChairmanChangeButtonClick != null)
			{
				eventOnVChairmanChangeButtonClick(arg1, arg2);
			}
		}

		// Token: 0x0600D454 RID: 54356 RVA: 0x0039EFCC File Offset: 0x0039D1CC
		private void __clearDele_EventOnVChairmanChangeButtonClick(string arg1, bool arg2)
		{
			this.EventOnVChairmanChangeButtonClick = null;
		}

		// Token: 0x0600D455 RID: 54357 RVA: 0x0039EFD8 File Offset: 0x0039D1D8
		private void __callDele_EventOnExpelButtonClick(string obj)
		{
			Action<string> eventOnExpelButtonClick = this.EventOnExpelButtonClick;
			if (eventOnExpelButtonClick != null)
			{
				eventOnExpelButtonClick(obj);
			}
		}

		// Token: 0x0600D456 RID: 54358 RVA: 0x0039EFFC File Offset: 0x0039D1FC
		private void __clearDele_EventOnExpelButtonClick(string obj)
		{
			this.EventOnExpelButtonClick = null;
		}

		// Token: 0x0600D459 RID: 54361 RVA: 0x0039F094 File Offset: 0x0039D294
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
					this.m_OnBindFiledsCompleted_hotfix = (luaObj.RawGet("OnBindFiledsCompleted") as LuaFunction);
					this.m_UpdatePlayerInfoBusinessCardBooleanBooleanBooleanBoolean_hotfix = (luaObj.RawGet("UpdatePlayerInfo") as LuaFunction);
					this.m_ShowOrHideBoolean_hotfix = (luaObj.RawGet("ShowOrHide") as LuaFunction);
					this.m_GetViewRect_hotfix = (luaObj.RawGet("GetViewRect") as LuaFunction);
					this.m_GetPanelSize_hotfix = (luaObj.RawGet("GetPanelSize") as LuaFunction);
					this.m_SetPanelPositionVector3_hotfix = (luaObj.RawGet("SetPanelPosition") as LuaFunction);
					this.m_SetGuildButtonGroupStateByModeString_hotfix = (luaObj.RawGet("SetGuildButtonGroupStateByMode") as LuaFunction);
					this.m_SetGuildButtonGroupListener_hotfix = (luaObj.RawGet("SetGuildButtonGroupListener") as LuaFunction);
					this.m_OnExpelButtonClick_hotfix = (luaObj.RawGet("OnExpelButtonClick") as LuaFunction);
					this.m_OnVChairmanChangeButtonClick_hotfix = (luaObj.RawGet("OnVChairmanChangeButtonClick") as LuaFunction);
					this.m_OnVChairmanButtonClick_hotfix = (luaObj.RawGet("OnVChairmanButtonClick") as LuaFunction);
					this.m_OnChairmanMoveButtonClick_hotfix = (luaObj.RawGet("OnChairmanMoveButtonClick") as LuaFunction);
					this.m_OnChairmanRelieveButtonClick_hotfix = (luaObj.RawGet("OnChairmanRelieveButtonClick") as LuaFunction);
					this.m_OnWatchCardButtonClick_hotfix = (luaObj.RawGet("OnWatchCardButtonClick") as LuaFunction);
					this.m_OnPrivateChatButtonClick_hotfix = (luaObj.RawGet("OnPrivateChatButtonClick") as LuaFunction);
					this.m_OnPKButtonClick_hotfix = (luaObj.RawGet("OnPKButtonClick") as LuaFunction);
					this.m_OnPKGreyButton_hotfix = (luaObj.RawGet("OnPKGreyButton") as LuaFunction);
					this.m_OnDeleteFriendButtonClick_hotfix = (luaObj.RawGet("OnDeleteFriendButtonClick") as LuaFunction);
					this.m_OnAddFriendButtonClick_hotfix = (luaObj.RawGet("OnAddFriendButtonClick") as LuaFunction);
					this.m_OnBlockButtonClick_hotfix = (luaObj.RawGet("OnBlockButtonClick") as LuaFunction);
					this.m_OnLikeButtonClick_hotfix = (luaObj.RawGet("OnLikeButtonClick") as LuaFunction);
					this.m_OnBGButtonClick_hotfix = (luaObj.RawGet("OnBGButtonClick") as LuaFunction);
					this.m_add_EventOnWatchCardButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnWatchCardButtonClick") as LuaFunction);
					this.m_remove_EventOnWatchCardButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnWatchCardButtonClick") as LuaFunction);
					this.m_add_EventOnPrivateChatButtonClickAction_hotfix = (luaObj.RawGet("add_EventOnPrivateChatButtonClick") as LuaFunction);
					this.m_remove_EventOnPrivateChatButtonClickAction_hotfix = (luaObj.RawGet("remove_EventOnPrivateChatButtonClick") as LuaFunction);
					this.m_add_EventOnPKButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnPKButtonClick") as LuaFunction);
					this.m_remove_EventOnPKButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnPKButtonClick") as LuaFunction);
					this.m_add_EventOnDeleteFriendButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnDeleteFriendButtonClick") as LuaFunction);
					this.m_remove_EventOnDeleteFriendButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnDeleteFriendButtonClick") as LuaFunction);
					this.m_add_EventOnAddFriendButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnAddFriendButtonClick") as LuaFunction);
					this.m_remove_EventOnAddFriendButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnAddFriendButtonClick") as LuaFunction);
					this.m_add_EventOnBlockButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnBlockButtonClick") as LuaFunction);
					this.m_remove_EventOnBlockButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnBlockButtonClick") as LuaFunction);
					this.m_add_EventOnLikeButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnLikeButtonClick") as LuaFunction);
					this.m_remove_EventOnLikeButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnLikeButtonClick") as LuaFunction);
					this.m_add_EventOnBGButtonClickAction_hotfix = (luaObj.RawGet("add_EventOnBGButtonClick") as LuaFunction);
					this.m_remove_EventOnBGButtonClickAction_hotfix = (luaObj.RawGet("remove_EventOnBGButtonClick") as LuaFunction);
					this.m_add_EventOnChairmanRelieveButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnChairmanRelieveButtonClick") as LuaFunction);
					this.m_remove_EventOnChairmanRelieveButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnChairmanRelieveButtonClick") as LuaFunction);
					this.m_add_EventOnChairmanMoveButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnChairmanMoveButtonClick") as LuaFunction);
					this.m_remove_EventOnChairmanMoveButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnChairmanMoveButtonClick") as LuaFunction);
					this.m_add_EventOnVChairmanChangeButtonClickAction`2_hotfix = (luaObj.RawGet("add_EventOnVChairmanChangeButtonClick") as LuaFunction);
					this.m_remove_EventOnVChairmanChangeButtonClickAction`2_hotfix = (luaObj.RawGet("remove_EventOnVChairmanChangeButtonClick") as LuaFunction);
					this.m_add_EventOnExpelButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnExpelButtonClick") as LuaFunction);
					this.m_remove_EventOnExpelButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnExpelButtonClick") as LuaFunction);
					this.m_get_PanelSize_hotfix = (luaObj.RawGet("get_PanelSize") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600D45A RID: 54362 RVA: 0x0039F5E0 File Offset: 0x0039D7E0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PlayerSimpleInfoUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008318 RID: 33560
		private BusinessCard m_playerInfo;

		// Token: 0x04008319 RID: 33561
		[AutoBind("./Detail", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject PanelRoot;

		// Token: 0x0400831A RID: 33562
		[AutoBind("./Detail/BGImage/FrameImage/PlayerPanel/PlayerIconImage", AutoBindAttribute.InitState.NotInit, false)]
		public Image PlayerIcon;

		// Token: 0x0400831B RID: 33563
		[AutoBind("./Detail/BGImage/FrameImage/PlayerPanel/PlayerIconImage/HeadFrameDummy", AutoBindAttribute.InitState.NotInit, false)]
		public Transform m_headFrameTransform;

		// Token: 0x0400831C RID: 33564
		[AutoBind("./Detail/BGImage/FrameImage/PlayerPanel/GoodImageButton", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController m_likeUIStateController;

		// Token: 0x0400831D RID: 33565
		[AutoBind("./Detail/BGImage/FrameImage/PlayerPanel/LevelText", AutoBindAttribute.InitState.NotInit, false)]
		public Text LevelText;

		// Token: 0x0400831E RID: 33566
		[AutoBind("./Detail/BGImage/FrameImage/PlayerPanel/PlayerNameText", AutoBindAttribute.InitState.NotInit, false)]
		public Text PlayerNameText;

		// Token: 0x0400831F RID: 33567
		[AutoBind("./Detail/BGImage/FrameImage/PlayerPanel/GoodCount", AutoBindAttribute.InitState.NotInit, false)]
		public Text LikeNumberText;

		// Token: 0x04008320 RID: 33568
		[AutoBind("./Detail/BGImage/FrameImage/ButtonGroup/WatchButton", AutoBindAttribute.InitState.NotInit, false)]
		public Button WatchButton;

		// Token: 0x04008321 RID: 33569
		[AutoBind("./Detail/BGImage/FrameImage/ButtonGroup/FightButton", AutoBindAttribute.InitState.NotInit, false)]
		public Button FightButton;

		// Token: 0x04008322 RID: 33570
		[AutoBind("./Detail/BGImage/FrameImage/ButtonGroup/FightGreyButton", AutoBindAttribute.InitState.NotInit, false)]
		public Button FightGreyButton;

		// Token: 0x04008323 RID: 33571
		[AutoBind("./Detail/BGImage/FrameImage/ButtonGroup/DeleteButton", AutoBindAttribute.InitState.NotInit, false)]
		public Button DeleteFriendButton;

		// Token: 0x04008324 RID: 33572
		[AutoBind("./Detail/BGImage/FrameImage/ButtonGroup/ChatButton", AutoBindAttribute.InitState.NotInit, false)]
		public Button ChatButton;

		// Token: 0x04008325 RID: 33573
		[AutoBind("./Detail/BGImage/FrameImage/PlayerPanel/GoodImageButton", AutoBindAttribute.InitState.NotInit, false)]
		public Button LikeButton;

		// Token: 0x04008326 RID: 33574
		[AutoBind("./Detail/BGImage/FrameImage/ButtonGroup/AddButton", AutoBindAttribute.InitState.NotInit, false)]
		public Button AddFriendButton;

		// Token: 0x04008327 RID: 33575
		[AutoBind("./Detail/BGImage/FrameImage/ButtonGroup/ShieldButton", AutoBindAttribute.InitState.NotInit, false)]
		public Button ShieldButton;

		// Token: 0x04008328 RID: 33576
		[AutoBind("./BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		public Button BGButton;

		// Token: 0x04008329 RID: 33577
		[AutoBind(".", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController PanelOpenOrCloseStateCtrl;

		// Token: 0x0400832A RID: 33578
		[AutoBind("./Detail", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController PanelShowStateCtrl;

		// Token: 0x0400832B RID: 33579
		[AutoBind("./Detail/BGImage/FrameImage/SociatyButtonGroup", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController SociatyButtonGroupStateCtrl;

		// Token: 0x0400832C RID: 33580
		[AutoBind("./Detail/BGImage/FrameImage/SociatyButtonGroup/SociatyButtonGroup/ChairmanRelieveButton", AutoBindAttribute.InitState.NotInit, false)]
		public Button ChairmanRelieveButton;

		// Token: 0x0400832D RID: 33581
		[AutoBind("./Detail/BGImage/FrameImage/SociatyButtonGroup/SociatyButtonGroup/ChairmanMoveButton", AutoBindAttribute.InitState.NotInit, false)]
		public Button ChairmanMoveButton;

		// Token: 0x0400832E RID: 33582
		[AutoBind("./Detail/BGImage/FrameImage/SociatyButtonGroup/SociatyButtonGroup/VChairmanButton", AutoBindAttribute.InitState.NotInit, false)]
		public Button VChairmanButton;

		// Token: 0x0400832F RID: 33583
		[AutoBind("./Detail/BGImage/FrameImage/SociatyButtonGroup/SociatyButtonGroup/VChairmanChangeButton", AutoBindAttribute.InitState.NotInit, false)]
		public Button VChairmanChangeButton;

		// Token: 0x04008330 RID: 33584
		[AutoBind("./Detail/BGImage/FrameImage/SociatyButtonGroup/SociatyButtonGroup/ExpelButton", AutoBindAttribute.InitState.NotInit, false)]
		public Button ExpelButton;

		// Token: 0x04008331 RID: 33585
		private StringTableId m_canNotFightStringTableId;

		// Token: 0x04008332 RID: 33586
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04008333 RID: 33587
		[DoNotToLua]
		private PlayerSimpleInfoUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008334 RID: 33588
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008335 RID: 33589
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008336 RID: 33590
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008337 RID: 33591
		private LuaFunction m_UpdatePlayerInfoBusinessCardBooleanBooleanBooleanBoolean_hotfix;

		// Token: 0x04008338 RID: 33592
		private LuaFunction m_ShowOrHideBoolean_hotfix;

		// Token: 0x04008339 RID: 33593
		private LuaFunction m_GetViewRect_hotfix;

		// Token: 0x0400833A RID: 33594
		private LuaFunction m_GetPanelSize_hotfix;

		// Token: 0x0400833B RID: 33595
		private LuaFunction m_SetPanelPositionVector3_hotfix;

		// Token: 0x0400833C RID: 33596
		private LuaFunction m_SetGuildButtonGroupStateByModeString_hotfix;

		// Token: 0x0400833D RID: 33597
		private LuaFunction m_SetGuildButtonGroupListener_hotfix;

		// Token: 0x0400833E RID: 33598
		private LuaFunction m_OnExpelButtonClick_hotfix;

		// Token: 0x0400833F RID: 33599
		private LuaFunction m_OnVChairmanChangeButtonClick_hotfix;

		// Token: 0x04008340 RID: 33600
		private LuaFunction m_OnVChairmanButtonClick_hotfix;

		// Token: 0x04008341 RID: 33601
		private LuaFunction m_OnChairmanMoveButtonClick_hotfix;

		// Token: 0x04008342 RID: 33602
		private LuaFunction m_OnChairmanRelieveButtonClick_hotfix;

		// Token: 0x04008343 RID: 33603
		private LuaFunction m_OnWatchCardButtonClick_hotfix;

		// Token: 0x04008344 RID: 33604
		private LuaFunction m_OnPrivateChatButtonClick_hotfix;

		// Token: 0x04008345 RID: 33605
		private LuaFunction m_OnPKButtonClick_hotfix;

		// Token: 0x04008346 RID: 33606
		private LuaFunction m_OnPKGreyButton_hotfix;

		// Token: 0x04008347 RID: 33607
		private LuaFunction m_OnDeleteFriendButtonClick_hotfix;

		// Token: 0x04008348 RID: 33608
		private LuaFunction m_OnAddFriendButtonClick_hotfix;

		// Token: 0x04008349 RID: 33609
		private LuaFunction m_OnBlockButtonClick_hotfix;

		// Token: 0x0400834A RID: 33610
		private LuaFunction m_OnLikeButtonClick_hotfix;

		// Token: 0x0400834B RID: 33611
		private LuaFunction m_OnBGButtonClick_hotfix;

		// Token: 0x0400834C RID: 33612
		private LuaFunction m_add_EventOnWatchCardButtonClickAction;

		// Token: 0x0400834D RID: 33613
		private LuaFunction m_remove_EventOnWatchCardButtonClickAction;

		// Token: 0x0400834E RID: 33614
		private LuaFunction m_add_EventOnPrivateChatButtonClickAction_hotfix;

		// Token: 0x0400834F RID: 33615
		private LuaFunction m_remove_EventOnPrivateChatButtonClickAction_hotfix;

		// Token: 0x04008350 RID: 33616
		private LuaFunction m_add_EventOnPKButtonClickAction;

		// Token: 0x04008351 RID: 33617
		private LuaFunction m_remove_EventOnPKButtonClickAction;

		// Token: 0x04008352 RID: 33618
		private LuaFunction m_add_EventOnDeleteFriendButtonClickAction;

		// Token: 0x04008353 RID: 33619
		private LuaFunction m_remove_EventOnDeleteFriendButtonClickAction;

		// Token: 0x04008354 RID: 33620
		private LuaFunction m_add_EventOnAddFriendButtonClickAction;

		// Token: 0x04008355 RID: 33621
		private LuaFunction m_remove_EventOnAddFriendButtonClickAction;

		// Token: 0x04008356 RID: 33622
		private LuaFunction m_add_EventOnBlockButtonClickAction;

		// Token: 0x04008357 RID: 33623
		private LuaFunction m_remove_EventOnBlockButtonClickAction;

		// Token: 0x04008358 RID: 33624
		private LuaFunction m_add_EventOnLikeButtonClickAction;

		// Token: 0x04008359 RID: 33625
		private LuaFunction m_remove_EventOnLikeButtonClickAction;

		// Token: 0x0400835A RID: 33626
		private LuaFunction m_add_EventOnBGButtonClickAction_hotfix;

		// Token: 0x0400835B RID: 33627
		private LuaFunction m_remove_EventOnBGButtonClickAction_hotfix;

		// Token: 0x0400835C RID: 33628
		private LuaFunction m_add_EventOnChairmanRelieveButtonClickAction;

		// Token: 0x0400835D RID: 33629
		private LuaFunction m_remove_EventOnChairmanRelieveButtonClickAction;

		// Token: 0x0400835E RID: 33630
		private LuaFunction m_add_EventOnChairmanMoveButtonClickAction;

		// Token: 0x0400835F RID: 33631
		private LuaFunction m_remove_EventOnChairmanMoveButtonClickAction;

		// Token: 0x04008360 RID: 33632
		private LuaFunction m_add_EventOnVChairmanChangeButtonClickAction;

		// Token: 0x04008361 RID: 33633
		private LuaFunction m_remove_EventOnVChairmanChangeButtonClickAction;

		// Token: 0x04008362 RID: 33634
		private LuaFunction m_add_EventOnExpelButtonClickAction;

		// Token: 0x04008363 RID: 33635
		private LuaFunction m_remove_EventOnExpelButtonClickAction;

		// Token: 0x04008364 RID: 33636
		private LuaFunction m_get_PanelSize_hotfix;

		// Token: 0x02000BEB RID: 3051
		public new class LuaExportHelper
		{
			// Token: 0x0600D45B RID: 54363 RVA: 0x0039F648 File Offset: 0x0039D848
			public LuaExportHelper(PlayerSimpleInfoUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600D45C RID: 54364 RVA: 0x0039F658 File Offset: 0x0039D858
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600D45D RID: 54365 RVA: 0x0039F668 File Offset: 0x0039D868
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600D45E RID: 54366 RVA: 0x0039F678 File Offset: 0x0039D878
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600D45F RID: 54367 RVA: 0x0039F688 File Offset: 0x0039D888
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600D460 RID: 54368 RVA: 0x0039F6A0 File Offset: 0x0039D8A0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600D461 RID: 54369 RVA: 0x0039F6B0 File Offset: 0x0039D8B0
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600D462 RID: 54370 RVA: 0x0039F6C0 File Offset: 0x0039D8C0
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600D463 RID: 54371 RVA: 0x0039F6D0 File Offset: 0x0039D8D0
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600D464 RID: 54372 RVA: 0x0039F6E0 File Offset: 0x0039D8E0
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600D465 RID: 54373 RVA: 0x0039F6F0 File Offset: 0x0039D8F0
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600D466 RID: 54374 RVA: 0x0039F700 File Offset: 0x0039D900
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600D467 RID: 54375 RVA: 0x0039F710 File Offset: 0x0039D910
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600D468 RID: 54376 RVA: 0x0039F720 File Offset: 0x0039D920
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600D469 RID: 54377 RVA: 0x0039F730 File Offset: 0x0039D930
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600D46A RID: 54378 RVA: 0x0039F740 File Offset: 0x0039D940
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600D46B RID: 54379 RVA: 0x0039F750 File Offset: 0x0039D950
			public void __callDele_EventOnWatchCardButtonClick(string obj)
			{
				this.m_owner.__callDele_EventOnWatchCardButtonClick(obj);
			}

			// Token: 0x0600D46C RID: 54380 RVA: 0x0039F760 File Offset: 0x0039D960
			public void __clearDele_EventOnWatchCardButtonClick(string obj)
			{
				this.m_owner.__clearDele_EventOnWatchCardButtonClick(obj);
			}

			// Token: 0x0600D46D RID: 54381 RVA: 0x0039F770 File Offset: 0x0039D970
			public void __callDele_EventOnPrivateChatButtonClick()
			{
				this.m_owner.__callDele_EventOnPrivateChatButtonClick();
			}

			// Token: 0x0600D46E RID: 54382 RVA: 0x0039F780 File Offset: 0x0039D980
			public void __clearDele_EventOnPrivateChatButtonClick()
			{
				this.m_owner.__clearDele_EventOnPrivateChatButtonClick();
			}

			// Token: 0x0600D46F RID: 54383 RVA: 0x0039F790 File Offset: 0x0039D990
			public void __callDele_EventOnPKButtonClick(string obj)
			{
				this.m_owner.__callDele_EventOnPKButtonClick(obj);
			}

			// Token: 0x0600D470 RID: 54384 RVA: 0x0039F7A0 File Offset: 0x0039D9A0
			public void __clearDele_EventOnPKButtonClick(string obj)
			{
				this.m_owner.__clearDele_EventOnPKButtonClick(obj);
			}

			// Token: 0x0600D471 RID: 54385 RVA: 0x0039F7B0 File Offset: 0x0039D9B0
			public void __callDele_EventOnDeleteFriendButtonClick(BusinessCard obj)
			{
				this.m_owner.__callDele_EventOnDeleteFriendButtonClick(obj);
			}

			// Token: 0x0600D472 RID: 54386 RVA: 0x0039F7C0 File Offset: 0x0039D9C0
			public void __clearDele_EventOnDeleteFriendButtonClick(BusinessCard obj)
			{
				this.m_owner.__clearDele_EventOnDeleteFriendButtonClick(obj);
			}

			// Token: 0x0600D473 RID: 54387 RVA: 0x0039F7D0 File Offset: 0x0039D9D0
			public void __callDele_EventOnAddFriendButtonClick(string obj)
			{
				this.m_owner.__callDele_EventOnAddFriendButtonClick(obj);
			}

			// Token: 0x0600D474 RID: 54388 RVA: 0x0039F7E0 File Offset: 0x0039D9E0
			public void __clearDele_EventOnAddFriendButtonClick(string obj)
			{
				this.m_owner.__clearDele_EventOnAddFriendButtonClick(obj);
			}

			// Token: 0x0600D475 RID: 54389 RVA: 0x0039F7F0 File Offset: 0x0039D9F0
			public void __callDele_EventOnBlockButtonClick(string obj)
			{
				this.m_owner.__callDele_EventOnBlockButtonClick(obj);
			}

			// Token: 0x0600D476 RID: 54390 RVA: 0x0039F800 File Offset: 0x0039DA00
			public void __clearDele_EventOnBlockButtonClick(string obj)
			{
				this.m_owner.__clearDele_EventOnBlockButtonClick(obj);
			}

			// Token: 0x0600D477 RID: 54391 RVA: 0x0039F810 File Offset: 0x0039DA10
			public void __callDele_EventOnLikeButtonClick(string obj)
			{
				this.m_owner.__callDele_EventOnLikeButtonClick(obj);
			}

			// Token: 0x0600D478 RID: 54392 RVA: 0x0039F820 File Offset: 0x0039DA20
			public void __clearDele_EventOnLikeButtonClick(string obj)
			{
				this.m_owner.__clearDele_EventOnLikeButtonClick(obj);
			}

			// Token: 0x0600D479 RID: 54393 RVA: 0x0039F830 File Offset: 0x0039DA30
			public void __callDele_EventOnBGButtonClick()
			{
				this.m_owner.__callDele_EventOnBGButtonClick();
			}

			// Token: 0x0600D47A RID: 54394 RVA: 0x0039F840 File Offset: 0x0039DA40
			public void __clearDele_EventOnBGButtonClick()
			{
				this.m_owner.__clearDele_EventOnBGButtonClick();
			}

			// Token: 0x0600D47B RID: 54395 RVA: 0x0039F850 File Offset: 0x0039DA50
			public void __callDele_EventOnChairmanRelieveButtonClick(string obj)
			{
				this.m_owner.__callDele_EventOnChairmanRelieveButtonClick(obj);
			}

			// Token: 0x0600D47C RID: 54396 RVA: 0x0039F860 File Offset: 0x0039DA60
			public void __clearDele_EventOnChairmanRelieveButtonClick(string obj)
			{
				this.m_owner.__clearDele_EventOnChairmanRelieveButtonClick(obj);
			}

			// Token: 0x0600D47D RID: 54397 RVA: 0x0039F870 File Offset: 0x0039DA70
			public void __callDele_EventOnChairmanMoveButtonClick(string obj)
			{
				this.m_owner.__callDele_EventOnChairmanMoveButtonClick(obj);
			}

			// Token: 0x0600D47E RID: 54398 RVA: 0x0039F880 File Offset: 0x0039DA80
			public void __clearDele_EventOnChairmanMoveButtonClick(string obj)
			{
				this.m_owner.__clearDele_EventOnChairmanMoveButtonClick(obj);
			}

			// Token: 0x0600D47F RID: 54399 RVA: 0x0039F890 File Offset: 0x0039DA90
			public void __callDele_EventOnVChairmanChangeButtonClick(string arg1, bool arg2)
			{
				this.m_owner.__callDele_EventOnVChairmanChangeButtonClick(arg1, arg2);
			}

			// Token: 0x0600D480 RID: 54400 RVA: 0x0039F8A0 File Offset: 0x0039DAA0
			public void __clearDele_EventOnVChairmanChangeButtonClick(string arg1, bool arg2)
			{
				this.m_owner.__clearDele_EventOnVChairmanChangeButtonClick(arg1, arg2);
			}

			// Token: 0x0600D481 RID: 54401 RVA: 0x0039F8B0 File Offset: 0x0039DAB0
			public void __callDele_EventOnExpelButtonClick(string obj)
			{
				this.m_owner.__callDele_EventOnExpelButtonClick(obj);
			}

			// Token: 0x0600D482 RID: 54402 RVA: 0x0039F8C0 File Offset: 0x0039DAC0
			public void __clearDele_EventOnExpelButtonClick(string obj)
			{
				this.m_owner.__clearDele_EventOnExpelButtonClick(obj);
			}

			// Token: 0x17002988 RID: 10632
			// (get) Token: 0x0600D483 RID: 54403 RVA: 0x0039F8D0 File Offset: 0x0039DAD0
			// (set) Token: 0x0600D484 RID: 54404 RVA: 0x0039F8E0 File Offset: 0x0039DAE0
			public BusinessCard m_playerInfo
			{
				get
				{
					return this.m_owner.m_playerInfo;
				}
				set
				{
					this.m_owner.m_playerInfo = value;
				}
			}

			// Token: 0x17002989 RID: 10633
			// (get) Token: 0x0600D485 RID: 54405 RVA: 0x0039F8F0 File Offset: 0x0039DAF0
			// (set) Token: 0x0600D486 RID: 54406 RVA: 0x0039F900 File Offset: 0x0039DB00
			public StringTableId m_canNotFightStringTableId
			{
				get
				{
					return this.m_owner.m_canNotFightStringTableId;
				}
				set
				{
					this.m_owner.m_canNotFightStringTableId = value;
				}
			}

			// Token: 0x1700298A RID: 10634
			// (get) Token: 0x0600D487 RID: 54407 RVA: 0x0039F910 File Offset: 0x0039DB10
			// (set) Token: 0x0600D488 RID: 54408 RVA: 0x0039F920 File Offset: 0x0039DB20
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

			// Token: 0x0600D489 RID: 54409 RVA: 0x0039F930 File Offset: 0x0039DB30
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600D48A RID: 54410 RVA: 0x0039F940 File Offset: 0x0039DB40
			public Vector2 GetPanelSize()
			{
				return this.m_owner.GetPanelSize();
			}

			// Token: 0x0600D48B RID: 54411 RVA: 0x0039F950 File Offset: 0x0039DB50
			public void SetGuildButtonGroupListener()
			{
				this.m_owner.SetGuildButtonGroupListener();
			}

			// Token: 0x0600D48C RID: 54412 RVA: 0x0039F960 File Offset: 0x0039DB60
			public void OnExpelButtonClick()
			{
				this.m_owner.OnExpelButtonClick();
			}

			// Token: 0x0600D48D RID: 54413 RVA: 0x0039F970 File Offset: 0x0039DB70
			public void OnVChairmanChangeButtonClick()
			{
				this.m_owner.OnVChairmanChangeButtonClick();
			}

			// Token: 0x0600D48E RID: 54414 RVA: 0x0039F980 File Offset: 0x0039DB80
			public void OnVChairmanButtonClick()
			{
				this.m_owner.OnVChairmanButtonClick();
			}

			// Token: 0x0600D48F RID: 54415 RVA: 0x0039F990 File Offset: 0x0039DB90
			public void OnChairmanMoveButtonClick()
			{
				this.m_owner.OnChairmanMoveButtonClick();
			}

			// Token: 0x0600D490 RID: 54416 RVA: 0x0039F9A0 File Offset: 0x0039DBA0
			public void OnChairmanRelieveButtonClick()
			{
				this.m_owner.OnChairmanRelieveButtonClick();
			}

			// Token: 0x0600D491 RID: 54417 RVA: 0x0039F9B0 File Offset: 0x0039DBB0
			public void OnWatchCardButtonClick()
			{
				this.m_owner.OnWatchCardButtonClick();
			}

			// Token: 0x0600D492 RID: 54418 RVA: 0x0039F9C0 File Offset: 0x0039DBC0
			public void OnPrivateChatButtonClick()
			{
				this.m_owner.OnPrivateChatButtonClick();
			}

			// Token: 0x0600D493 RID: 54419 RVA: 0x0039F9D0 File Offset: 0x0039DBD0
			public void OnPKButtonClick()
			{
				this.m_owner.OnPKButtonClick();
			}

			// Token: 0x0600D494 RID: 54420 RVA: 0x0039F9E0 File Offset: 0x0039DBE0
			public void OnPKGreyButton()
			{
				this.m_owner.OnPKGreyButton();
			}

			// Token: 0x0600D495 RID: 54421 RVA: 0x0039F9F0 File Offset: 0x0039DBF0
			public void OnDeleteFriendButtonClick()
			{
				this.m_owner.OnDeleteFriendButtonClick();
			}

			// Token: 0x0600D496 RID: 54422 RVA: 0x0039FA00 File Offset: 0x0039DC00
			public void OnAddFriendButtonClick()
			{
				this.m_owner.OnAddFriendButtonClick();
			}

			// Token: 0x0600D497 RID: 54423 RVA: 0x0039FA10 File Offset: 0x0039DC10
			public void OnBlockButtonClick()
			{
				this.m_owner.OnBlockButtonClick();
			}

			// Token: 0x0600D498 RID: 54424 RVA: 0x0039FA20 File Offset: 0x0039DC20
			public void OnLikeButtonClick()
			{
				this.m_owner.OnLikeButtonClick();
			}

			// Token: 0x0600D499 RID: 54425 RVA: 0x0039FA30 File Offset: 0x0039DC30
			public void OnBGButtonClick()
			{
				this.m_owner.OnBGButtonClick();
			}

			// Token: 0x04008365 RID: 33637
			private PlayerSimpleInfoUIController m_owner;
		}
	}
}
