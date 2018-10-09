using System;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.Scene;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F6B RID: 3947
	[HotFix]
	public class TeamRoomPlayerInfoUIController : UIControllerBase, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler, IEventSystemHandler
	{
		// Token: 0x06013A40 RID: 80448 RVA: 0x00501404 File Offset: 0x004FF604
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
			this.m_inviteButton.onClick.AddListener(new UnityAction(this.OnInviteButtonClick));
			this.m_playerButton.onClick.AddListener(new UnityAction(this.OnPlayerButtonClick));
			this.m_chatUIStateController.gameObject.SetActive(false);
		}

		// Token: 0x06013A41 RID: 80449 RVA: 0x005014B4 File Offset: 0x004FF6B4
		public void InitEmojiText(int fontSize, Image image)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitEmojiTextInt32Image_hotfix != null)
			{
				this.m_InitEmojiTextInt32Image_hotfix.call(new object[]
				{
					this,
					fontSize,
					image
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_dialogText.Init(fontSize, image);
		}

		// Token: 0x06013A42 RID: 80450 RVA: 0x00501544 File Offset: 0x004FF744
		public void SetIndex(int idx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetIndexInt32_hotfix != null)
			{
				this.m_SetIndexInt32_hotfix.call(new object[]
				{
					this,
					idx
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_index = idx;
		}

		// Token: 0x06013A43 RID: 80451 RVA: 0x005015BC File Offset: 0x004FF7BC
		public int GetIndex()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetIndex_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetIndex_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_index;
		}

		// Token: 0x06013A44 RID: 80452 RVA: 0x00501630 File Offset: 0x004FF830
		public void SetPlayerIndex(int idx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPlayerIndexInt32_hotfix != null)
			{
				this.m_SetPlayerIndexInt32_hotfix.call(new object[]
				{
					this,
					idx
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerTagImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetBattlePlayerTagImageName(idx));
		}

		// Token: 0x06013A45 RID: 80453 RVA: 0x005016BC File Offset: 0x004FF8BC
		public void SetPlayer(TeamRoomPlayer player)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPlayerTeamRoomPlayer_hotfix != null)
			{
				this.m_SetPlayerTeamRoomPlayer_hotfix.call(new object[]
				{
					this,
					player
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_player = player;
			if (player != null)
			{
				this.SetName(player.Name);
				this.SetLevel(player.Level);
				this.SetHeadIcon(player.HeadIcon);
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				ConfigDataJobConnectionInfo configDataJobConnectionInfo = configDataLoader.GetConfigDataJobConnectionInfo(player.ActiveHeroJobRelatedId);
				ConfigDataModelSkinResourceInfo heroModelSkinResourceInfo = BattleUtility.GetHeroModelSkinResourceInfo(configDataLoader, player.ModenSkinId, player.ActiveHeroJobRelatedId);
				this.CreateSpineGraphic(configDataJobConnectionInfo, heroModelSkinResourceInfo);
			}
			else
			{
				this.DestroySpineGraphic();
			}
		}

		// Token: 0x06013A46 RID: 80454 RVA: 0x005017A0 File Offset: 0x004FF9A0
		public TeamRoomPlayer GetPlayer()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPlayer_hotfix != null)
			{
				return (TeamRoomPlayer)this.m_GetPlayer_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_player;
		}

		// Token: 0x06013A47 RID: 80455 RVA: 0x00501814 File Offset: 0x004FFA14
		private void SetName(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetNameString_hotfix != null)
			{
				this.m_SetNameString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_nameText.text = name;
		}

		// Token: 0x06013A48 RID: 80456 RVA: 0x00501890 File Offset: 0x004FFA90
		private void SetLevel(int level)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLevelInt32_hotfix != null)
			{
				this.m_SetLevelInt32_hotfix.call(new object[]
				{
					this,
					level
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_levelText.text = level.ToString();
		}

		// Token: 0x06013A49 RID: 80457 RVA: 0x00501918 File Offset: 0x004FFB18
		private void SetHeadIcon(int headIconId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeadIconInt32_hotfix != null)
			{
				this.m_SetHeadIconInt32_hotfix.call(new object[]
				{
					this,
					headIconId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_headIconImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerSmallHeadIconImageName(HeadIconTools.GetHeadPortrait(headIconId)));
			UIUtility.SetPlayerHeadFrame(this.m_headFrameTransform, HeadIconTools.GetHeadFrame(headIconId), true, "Normal");
		}

		// Token: 0x06013A4A RID: 80458 RVA: 0x005019C0 File Offset: 0x004FFBC0
		public void SetOn(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetOnBoolean_hotfix != null)
			{
				this.m_SetOnBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_uiStateController.SetToUIState((!on) ? "Empty" : "Have", false, true);
			if (!on)
			{
				this.DestroySpineGraphic();
				this.m_chatUIStateController.gameObject.SetActive(false);
			}
		}

		// Token: 0x06013A4B RID: 80459 RVA: 0x00501A70 File Offset: 0x004FFC70
		public void SetEditOn(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetEditOnBoolean_hotfix != null)
			{
				this.m_SetEditOnBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_uiStateController.SetToUIState((!on) ? "ChangeEmpty" : "Change", false, true);
			if (!on)
			{
				this.DestroySpineGraphic();
				this.m_chatUIStateController.gameObject.SetActive(false);
			}
		}

		// Token: 0x06013A4C RID: 80460 RVA: 0x00501B20 File Offset: 0x004FFD20
		public void ShowChat(string txt)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowChatString_hotfix != null)
			{
				this.m_ShowChatString_hotfix.call(new object[]
				{
					this,
					txt
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_dialogText.gameObject.SetActive(true);
			this.m_dialogBigExpression.gameObject.SetActive(false);
			this.m_dialogText.SetContent(txt);
			this.m_chatUIStateController.SetToUIState("Show", false, true);
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.m_hideChatTime = (float)configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_TeamChatBubbleStayTime) * 0.001f;
		}

		// Token: 0x06013A4D RID: 80461 RVA: 0x00501BF8 File Offset: 0x004FFDF8
		public void ShowBigExpression(int id)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowBigExpressionInt32_hotfix != null)
			{
				this.m_ShowBigExpressionInt32_hotfix.call(new object[]
				{
					this,
					id
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_dialogText.gameObject.SetActive(false);
			this.m_dialogBigExpression.gameObject.SetActive(true);
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataBigExpressionInfo configDataBigExpressionInfo = configDataLoader.GetConfigDataBigExpressionInfo(id);
			this.m_dialogBigExpression.sprite = AssetUtility.Instance.GetSprite(configDataBigExpressionInfo.ExpressionIconPath);
			this.m_chatUIStateController.SetToUIState("Show", false, true);
			this.m_hideChatTime = (float)configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_TeamChatBubbleStayTime) * 0.001f;
		}

		// Token: 0x06013A4E RID: 80462 RVA: 0x00501CE8 File Offset: 0x004FFEE8
		private void HideChat()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideChat_hotfix != null)
			{
				this.m_HideChat_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_chatUIStateController.SetToUIState("Close", false, true);
			this.m_hideChatTime = 0f;
		}

		// Token: 0x06013A4F RID: 80463 RVA: 0x00501D68 File Offset: 0x004FFF68
		private void CreateSpineGraphic(ConfigDataJobConnectionInfo jobConnectionInfo, ConfigDataModelSkinResourceInfo skinResInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateSpineGraphicConfigDataJobConnectionInfoConfigDataModelSkinResourceInfo_hotfix != null)
			{
				this.m_CreateSpineGraphicConfigDataJobConnectionInfoConfigDataModelSkinResourceInfo_hotfix.call(new object[]
				{
					this,
					jobConnectionInfo,
					skinResInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DestroySpineGraphic();
			if (jobConnectionInfo == null)
			{
				return;
			}
			string text = string.Empty;
			if (skinResInfo != null)
			{
				text = skinResInfo.Model;
			}
			if (string.IsNullOrEmpty(text))
			{
				text = jobConnectionInfo.Model;
			}
			float scale = (float)jobConnectionInfo.UI_ModelScale * 0.01f * 1.4f;
			Vector2 position = new Vector2((float)jobConnectionInfo.UI_ModelOffsetX, (float)jobConnectionInfo.UI_ModelOffsetY);
			UISpineGraphic uispineGraphic = new UISpineGraphic();
			uispineGraphic.Create(text);
			uispineGraphic.SetParent(this.m_graphicGameObject);
			uispineGraphic.SetPosition(position);
			uispineGraphic.SetScale(scale);
			uispineGraphic.SetReplaceAnimations(jobConnectionInfo.ReplaceAnims);
			uispineGraphic.PlayAnimation("idle", true, 0);
			uispineGraphic.ForceUpdate();
			this.m_spineGraphic = uispineGraphic;
		}

		// Token: 0x06013A50 RID: 80464 RVA: 0x00501E94 File Offset: 0x00500094
		public void DestroySpineGraphic()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroySpineGraphic_hotfix != null)
			{
				this.m_DestroySpineGraphic_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_spineGraphic != null)
			{
				this.m_spineGraphic.Destroy();
				this.m_spineGraphic = null;
			}
		}

		// Token: 0x06013A51 RID: 80465 RVA: 0x00501F14 File Offset: 0x00500114
		public void SetAnimationTime(float time)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetAnimationTimeSingle_hotfix != null)
			{
				this.m_SetAnimationTimeSingle_hotfix.call(new object[]
				{
					this,
					time
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_spineGraphic != null)
			{
				this.m_spineGraphic.SetAnimationTime(0, time);
			}
		}

		// Token: 0x06013A52 RID: 80466 RVA: 0x00501F9C File Offset: 0x0050019C
		public float GetAnimationTime()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAnimationTime_hotfix != null)
			{
				return Convert.ToSingle(this.m_GetAnimationTime_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_spineGraphic != null)
			{
				return this.m_spineGraphic.GetAnimationTime(0);
			}
			return 0f;
		}

		// Token: 0x06013A53 RID: 80467 RVA: 0x00502028 File Offset: 0x00500228
		private void OnInviteButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnInviteButtonClick_hotfix != null)
			{
				this.m_OnInviteButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnInviteButtonClick != null)
			{
				this.EventOnInviteButtonClick(this);
			}
		}

		// Token: 0x06013A54 RID: 80468 RVA: 0x005020A0 File Offset: 0x005002A0
		private void OnPlayerButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPlayerButtonClick_hotfix != null)
			{
				this.m_OnPlayerButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnPlayerButtonClick != null)
			{
				this.EventOnPlayerButtonClick(this);
			}
		}

		// Token: 0x06013A55 RID: 80469 RVA: 0x00502118 File Offset: 0x00500318
		public void OnBeginDrag(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBeginDragPointerEventData_hotfix != null)
			{
				this.m_OnBeginDragPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnBeginDrag != null)
			{
				this.EventOnBeginDrag(this, eventData);
			}
		}

		// Token: 0x06013A56 RID: 80470 RVA: 0x005021A0 File Offset: 0x005003A0
		public void OnEndDrag(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEndDragPointerEventData_hotfix != null)
			{
				this.m_OnEndDragPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnEndDrag != null)
			{
				this.EventOnEndDrag(this, eventData);
			}
		}

		// Token: 0x06013A57 RID: 80471 RVA: 0x00502228 File Offset: 0x00500428
		public void OnDrag(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDragPointerEventData_hotfix != null)
			{
				this.m_OnDragPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnDrag != null)
			{
				this.EventOnDrag(eventData);
			}
		}

		// Token: 0x06013A58 RID: 80472 RVA: 0x005022B0 File Offset: 0x005004B0
		public void OnDrop(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDropPointerEventData_hotfix != null)
			{
				this.m_OnDropPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnDrop != null)
			{
				this.EventOnDrop(eventData);
			}
		}

		// Token: 0x06013A59 RID: 80473 RVA: 0x00502338 File Offset: 0x00500538
		public void ClearEvents()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearEvents_hotfix != null)
			{
				this.m_ClearEvents_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.EventOnInviteButtonClick = null;
			this.EventOnPlayerButtonClick = null;
			this.EventOnBeginDrag = null;
			this.EventOnEndDrag = null;
			this.EventOnDrag = null;
			this.EventOnDrop = null;
		}

		// Token: 0x06013A5A RID: 80474 RVA: 0x005023C4 File Offset: 0x005005C4
		private void Update()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Update_hotfix != null)
			{
				this.m_Update_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_hideChatTime > 0f)
			{
				this.m_hideChatTime -= Time.unscaledDeltaTime;
				if (this.m_hideChatTime <= 0f)
				{
					this.m_hideChatTime = 0f;
					this.HideChat();
				}
			}
		}

		// Token: 0x1400044C RID: 1100
		// (add) Token: 0x06013A5B RID: 80475 RVA: 0x00502468 File Offset: 0x00500668
		// (remove) Token: 0x06013A5C RID: 80476 RVA: 0x00502504 File Offset: 0x00500704
		public event Action<TeamRoomPlayerInfoUIController> EventOnInviteButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnInviteButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnInviteButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<TeamRoomPlayerInfoUIController> action = this.EventOnInviteButtonClick;
				Action<TeamRoomPlayerInfoUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<TeamRoomPlayerInfoUIController>>(ref this.EventOnInviteButtonClick, (Action<TeamRoomPlayerInfoUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnInviteButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnInviteButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<TeamRoomPlayerInfoUIController> action = this.EventOnInviteButtonClick;
				Action<TeamRoomPlayerInfoUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<TeamRoomPlayerInfoUIController>>(ref this.EventOnInviteButtonClick, (Action<TeamRoomPlayerInfoUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400044D RID: 1101
		// (add) Token: 0x06013A5D RID: 80477 RVA: 0x005025A0 File Offset: 0x005007A0
		// (remove) Token: 0x06013A5E RID: 80478 RVA: 0x0050263C File Offset: 0x0050083C
		public event Action<TeamRoomPlayerInfoUIController> EventOnPlayerButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnPlayerButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnPlayerButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<TeamRoomPlayerInfoUIController> action = this.EventOnPlayerButtonClick;
				Action<TeamRoomPlayerInfoUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<TeamRoomPlayerInfoUIController>>(ref this.EventOnPlayerButtonClick, (Action<TeamRoomPlayerInfoUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnPlayerButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnPlayerButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<TeamRoomPlayerInfoUIController> action = this.EventOnPlayerButtonClick;
				Action<TeamRoomPlayerInfoUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<TeamRoomPlayerInfoUIController>>(ref this.EventOnPlayerButtonClick, (Action<TeamRoomPlayerInfoUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400044E RID: 1102
		// (add) Token: 0x06013A5F RID: 80479 RVA: 0x005026D8 File Offset: 0x005008D8
		// (remove) Token: 0x06013A60 RID: 80480 RVA: 0x00502774 File Offset: 0x00500974
		public event Action<TeamRoomPlayerInfoUIController, PointerEventData> EventOnBeginDrag
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnBeginDragAction`2_hotfix != null)
				{
					this.m_add_EventOnBeginDragAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<TeamRoomPlayerInfoUIController, PointerEventData> action = this.EventOnBeginDrag;
				Action<TeamRoomPlayerInfoUIController, PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<TeamRoomPlayerInfoUIController, PointerEventData>>(ref this.EventOnBeginDrag, (Action<TeamRoomPlayerInfoUIController, PointerEventData>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnBeginDragAction`2_hotfix != null)
				{
					this.m_remove_EventOnBeginDragAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<TeamRoomPlayerInfoUIController, PointerEventData> action = this.EventOnBeginDrag;
				Action<TeamRoomPlayerInfoUIController, PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<TeamRoomPlayerInfoUIController, PointerEventData>>(ref this.EventOnBeginDrag, (Action<TeamRoomPlayerInfoUIController, PointerEventData>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400044F RID: 1103
		// (add) Token: 0x06013A61 RID: 80481 RVA: 0x00502810 File Offset: 0x00500A10
		// (remove) Token: 0x06013A62 RID: 80482 RVA: 0x005028AC File Offset: 0x00500AAC
		public event Action<TeamRoomPlayerInfoUIController, PointerEventData> EventOnEndDrag
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnEndDragAction`2_hotfix != null)
				{
					this.m_add_EventOnEndDragAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<TeamRoomPlayerInfoUIController, PointerEventData> action = this.EventOnEndDrag;
				Action<TeamRoomPlayerInfoUIController, PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<TeamRoomPlayerInfoUIController, PointerEventData>>(ref this.EventOnEndDrag, (Action<TeamRoomPlayerInfoUIController, PointerEventData>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnEndDragAction`2_hotfix != null)
				{
					this.m_remove_EventOnEndDragAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<TeamRoomPlayerInfoUIController, PointerEventData> action = this.EventOnEndDrag;
				Action<TeamRoomPlayerInfoUIController, PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<TeamRoomPlayerInfoUIController, PointerEventData>>(ref this.EventOnEndDrag, (Action<TeamRoomPlayerInfoUIController, PointerEventData>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000450 RID: 1104
		// (add) Token: 0x06013A63 RID: 80483 RVA: 0x00502948 File Offset: 0x00500B48
		// (remove) Token: 0x06013A64 RID: 80484 RVA: 0x005029E4 File Offset: 0x00500BE4
		public event Action<PointerEventData> EventOnDrag
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnDragAction`1_hotfix != null)
				{
					this.m_add_EventOnDragAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnDrag;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnDrag, (Action<PointerEventData>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnDragAction`1_hotfix != null)
				{
					this.m_remove_EventOnDragAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnDrag;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnDrag, (Action<PointerEventData>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000451 RID: 1105
		// (add) Token: 0x06013A65 RID: 80485 RVA: 0x00502A80 File Offset: 0x00500C80
		// (remove) Token: 0x06013A66 RID: 80486 RVA: 0x00502B1C File Offset: 0x00500D1C
		public event Action<PointerEventData> EventOnDrop
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnDropAction`1_hotfix != null)
				{
					this.m_add_EventOnDropAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnDrop;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnDrop, (Action<PointerEventData>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnDropAction`1_hotfix != null)
				{
					this.m_remove_EventOnDropAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnDrop;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnDrop, (Action<PointerEventData>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003AEC RID: 15084
		// (get) Token: 0x06013A67 RID: 80487 RVA: 0x00502BB8 File Offset: 0x00500DB8
		// (set) Token: 0x06013A68 RID: 80488 RVA: 0x00502BD8 File Offset: 0x00500DD8
		[DoNotToLua]
		public new TeamRoomPlayerInfoUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new TeamRoomPlayerInfoUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06013A69 RID: 80489 RVA: 0x00502BE4 File Offset: 0x00500DE4
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06013A6A RID: 80490 RVA: 0x00502BF0 File Offset: 0x00500DF0
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06013A6B RID: 80491 RVA: 0x00502BF8 File Offset: 0x00500DF8
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06013A6C RID: 80492 RVA: 0x00502C00 File Offset: 0x00500E00
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06013A6D RID: 80493 RVA: 0x00502C14 File Offset: 0x00500E14
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06013A6E RID: 80494 RVA: 0x00502C1C File Offset: 0x00500E1C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06013A6F RID: 80495 RVA: 0x00502C28 File Offset: 0x00500E28
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06013A70 RID: 80496 RVA: 0x00502C34 File Offset: 0x00500E34
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06013A71 RID: 80497 RVA: 0x00502C40 File Offset: 0x00500E40
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06013A72 RID: 80498 RVA: 0x00502C4C File Offset: 0x00500E4C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06013A73 RID: 80499 RVA: 0x00502C58 File Offset: 0x00500E58
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06013A74 RID: 80500 RVA: 0x00502C64 File Offset: 0x00500E64
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06013A75 RID: 80501 RVA: 0x00502C70 File Offset: 0x00500E70
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06013A76 RID: 80502 RVA: 0x00502C7C File Offset: 0x00500E7C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06013A77 RID: 80503 RVA: 0x00502C88 File Offset: 0x00500E88
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06013A78 RID: 80504 RVA: 0x00502C90 File Offset: 0x00500E90
		private void __callDele_EventOnInviteButtonClick(TeamRoomPlayerInfoUIController obj)
		{
			Action<TeamRoomPlayerInfoUIController> eventOnInviteButtonClick = this.EventOnInviteButtonClick;
			if (eventOnInviteButtonClick != null)
			{
				eventOnInviteButtonClick(obj);
			}
		}

		// Token: 0x06013A79 RID: 80505 RVA: 0x00502CB4 File Offset: 0x00500EB4
		private void __clearDele_EventOnInviteButtonClick(TeamRoomPlayerInfoUIController obj)
		{
			this.EventOnInviteButtonClick = null;
		}

		// Token: 0x06013A7A RID: 80506 RVA: 0x00502CC0 File Offset: 0x00500EC0
		private void __callDele_EventOnPlayerButtonClick(TeamRoomPlayerInfoUIController obj)
		{
			Action<TeamRoomPlayerInfoUIController> eventOnPlayerButtonClick = this.EventOnPlayerButtonClick;
			if (eventOnPlayerButtonClick != null)
			{
				eventOnPlayerButtonClick(obj);
			}
		}

		// Token: 0x06013A7B RID: 80507 RVA: 0x00502CE4 File Offset: 0x00500EE4
		private void __clearDele_EventOnPlayerButtonClick(TeamRoomPlayerInfoUIController obj)
		{
			this.EventOnPlayerButtonClick = null;
		}

		// Token: 0x06013A7C RID: 80508 RVA: 0x00502CF0 File Offset: 0x00500EF0
		private void __callDele_EventOnBeginDrag(TeamRoomPlayerInfoUIController arg1, PointerEventData arg2)
		{
			Action<TeamRoomPlayerInfoUIController, PointerEventData> eventOnBeginDrag = this.EventOnBeginDrag;
			if (eventOnBeginDrag != null)
			{
				eventOnBeginDrag(arg1, arg2);
			}
		}

		// Token: 0x06013A7D RID: 80509 RVA: 0x00502D14 File Offset: 0x00500F14
		private void __clearDele_EventOnBeginDrag(TeamRoomPlayerInfoUIController arg1, PointerEventData arg2)
		{
			this.EventOnBeginDrag = null;
		}

		// Token: 0x06013A7E RID: 80510 RVA: 0x00502D20 File Offset: 0x00500F20
		private void __callDele_EventOnEndDrag(TeamRoomPlayerInfoUIController arg1, PointerEventData arg2)
		{
			Action<TeamRoomPlayerInfoUIController, PointerEventData> eventOnEndDrag = this.EventOnEndDrag;
			if (eventOnEndDrag != null)
			{
				eventOnEndDrag(arg1, arg2);
			}
		}

		// Token: 0x06013A7F RID: 80511 RVA: 0x00502D44 File Offset: 0x00500F44
		private void __clearDele_EventOnEndDrag(TeamRoomPlayerInfoUIController arg1, PointerEventData arg2)
		{
			this.EventOnEndDrag = null;
		}

		// Token: 0x06013A80 RID: 80512 RVA: 0x00502D50 File Offset: 0x00500F50
		private void __callDele_EventOnDrag(PointerEventData obj)
		{
			Action<PointerEventData> eventOnDrag = this.EventOnDrag;
			if (eventOnDrag != null)
			{
				eventOnDrag(obj);
			}
		}

		// Token: 0x06013A81 RID: 80513 RVA: 0x00502D74 File Offset: 0x00500F74
		private void __clearDele_EventOnDrag(PointerEventData obj)
		{
			this.EventOnDrag = null;
		}

		// Token: 0x06013A82 RID: 80514 RVA: 0x00502D80 File Offset: 0x00500F80
		private void __callDele_EventOnDrop(PointerEventData obj)
		{
			Action<PointerEventData> eventOnDrop = this.EventOnDrop;
			if (eventOnDrop != null)
			{
				eventOnDrop(obj);
			}
		}

		// Token: 0x06013A83 RID: 80515 RVA: 0x00502DA4 File Offset: 0x00500FA4
		private void __clearDele_EventOnDrop(PointerEventData obj)
		{
			this.EventOnDrop = null;
		}

		// Token: 0x06013A84 RID: 80516 RVA: 0x00502DB0 File Offset: 0x00500FB0
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
					this.m_InitEmojiTextInt32Image_hotfix = (luaObj.RawGet("InitEmojiText") as LuaFunction);
					this.m_SetIndexInt32_hotfix = (luaObj.RawGet("SetIndex") as LuaFunction);
					this.m_GetIndex_hotfix = (luaObj.RawGet("GetIndex") as LuaFunction);
					this.m_SetPlayerIndexInt32_hotfix = (luaObj.RawGet("SetPlayerIndex") as LuaFunction);
					this.m_SetPlayerTeamRoomPlayer_hotfix = (luaObj.RawGet("SetPlayer") as LuaFunction);
					this.m_GetPlayer_hotfix = (luaObj.RawGet("GetPlayer") as LuaFunction);
					this.m_SetNameString_hotfix = (luaObj.RawGet("SetName") as LuaFunction);
					this.m_SetLevelInt32_hotfix = (luaObj.RawGet("SetLevel") as LuaFunction);
					this.m_SetHeadIconInt32_hotfix = (luaObj.RawGet("SetHeadIcon") as LuaFunction);
					this.m_SetOnBoolean_hotfix = (luaObj.RawGet("SetOn") as LuaFunction);
					this.m_SetEditOnBoolean_hotfix = (luaObj.RawGet("SetEditOn") as LuaFunction);
					this.m_ShowChatString_hotfix = (luaObj.RawGet("ShowChat") as LuaFunction);
					this.m_ShowBigExpressionInt32_hotfix = (luaObj.RawGet("ShowBigExpression") as LuaFunction);
					this.m_HideChat_hotfix = (luaObj.RawGet("HideChat") as LuaFunction);
					this.m_CreateSpineGraphicConfigDataJobConnectionInfoConfigDataModelSkinResourceInfo_hotfix = (luaObj.RawGet("CreateSpineGraphic") as LuaFunction);
					this.m_DestroySpineGraphic_hotfix = (luaObj.RawGet("DestroySpineGraphic") as LuaFunction);
					this.m_SetAnimationTimeSingle_hotfix = (luaObj.RawGet("SetAnimationTime") as LuaFunction);
					this.m_GetAnimationTime_hotfix = (luaObj.RawGet("GetAnimationTime") as LuaFunction);
					this.m_OnInviteButtonClick_hotfix = (luaObj.RawGet("OnInviteButtonClick") as LuaFunction);
					this.m_OnPlayerButtonClick_hotfix = (luaObj.RawGet("OnPlayerButtonClick") as LuaFunction);
					this.m_OnBeginDragPointerEventData_hotfix = (luaObj.RawGet("OnBeginDrag") as LuaFunction);
					this.m_OnEndDragPointerEventData_hotfix = (luaObj.RawGet("OnEndDrag") as LuaFunction);
					this.m_OnDragPointerEventData_hotfix = (luaObj.RawGet("OnDrag") as LuaFunction);
					this.m_OnDropPointerEventData_hotfix = (luaObj.RawGet("OnDrop") as LuaFunction);
					this.m_ClearEvents_hotfix = (luaObj.RawGet("ClearEvents") as LuaFunction);
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_add_EventOnInviteButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnInviteButtonClick") as LuaFunction);
					this.m_remove_EventOnInviteButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnInviteButtonClick") as LuaFunction);
					this.m_add_EventOnPlayerButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnPlayerButtonClick") as LuaFunction);
					this.m_remove_EventOnPlayerButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnPlayerButtonClick") as LuaFunction);
					this.m_add_EventOnBeginDragAction`2_hotfix = (luaObj.RawGet("add_EventOnBeginDrag") as LuaFunction);
					this.m_remove_EventOnBeginDragAction`2_hotfix = (luaObj.RawGet("remove_EventOnBeginDrag") as LuaFunction);
					this.m_add_EventOnEndDragAction`2_hotfix = (luaObj.RawGet("add_EventOnEndDrag") as LuaFunction);
					this.m_remove_EventOnEndDragAction`2_hotfix = (luaObj.RawGet("remove_EventOnEndDrag") as LuaFunction);
					this.m_add_EventOnDragAction`1_hotfix = (luaObj.RawGet("add_EventOnDrag") as LuaFunction);
					this.m_remove_EventOnDragAction`1_hotfix = (luaObj.RawGet("remove_EventOnDrag") as LuaFunction);
					this.m_add_EventOnDropAction`1_hotfix = (luaObj.RawGet("add_EventOnDrop") as LuaFunction);
					this.m_remove_EventOnDropAction`1_hotfix = (luaObj.RawGet("remove_EventOnDrop") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06013A85 RID: 80517 RVA: 0x00503234 File Offset: 0x00501434
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomPlayerInfoUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400AE2E RID: 44590
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400AE2F RID: 44591
		[AutoBind("./PlayerIn", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_playerButton;

		// Token: 0x0400AE30 RID: 44592
		[AutoBind("./PlayerIn/PlayerTag", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_playerTagImage;

		// Token: 0x0400AE31 RID: 44593
		[AutoBind("./PlayerIn/Name/NameWord/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x0400AE32 RID: 44594
		[AutoBind("./PlayerIn/Name/NameWord/LVText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_levelText;

		// Token: 0x0400AE33 RID: 44595
		[AutoBind("./PlayerIn/Name/NameBG/HeadImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_headIconImage;

		// Token: 0x0400AE34 RID: 44596
		[AutoBind("./PlayerIn/Name/NameBG/HeadFrameDummy", AutoBindAttribute.InitState.NotInit, false)]
		private Transform m_headFrameTransform;

		// Token: 0x0400AE35 RID: 44597
		[AutoBind("./PlayerIn/Graphic", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_graphicGameObject;

		// Token: 0x0400AE36 RID: 44598
		[AutoBind("./NoPlayer/Button", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_inviteButton;

		// Token: 0x0400AE37 RID: 44599
		[AutoBind("./Chat", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_chatUIStateController;

		// Token: 0x0400AE38 RID: 44600
		[AutoBind("./Chat/BGImage/Text", AutoBindAttribute.InitState.NotInit, false)]
		private EmojiText m_dialogText;

		// Token: 0x0400AE39 RID: 44601
		[AutoBind("./Chat/BGImage/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_dialogBigExpression;

		// Token: 0x0400AE3A RID: 44602
		private int m_index;

		// Token: 0x0400AE3B RID: 44603
		private TeamRoomPlayer m_player;

		// Token: 0x0400AE3C RID: 44604
		private UISpineGraphic m_spineGraphic;

		// Token: 0x0400AE3D RID: 44605
		private float m_hideChatTime;

		// Token: 0x0400AE3E RID: 44606
		[DoNotToLua]
		private TeamRoomPlayerInfoUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400AE3F RID: 44607
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400AE40 RID: 44608
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400AE41 RID: 44609
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400AE42 RID: 44610
		private LuaFunction m_InitEmojiTextInt32Image_hotfix;

		// Token: 0x0400AE43 RID: 44611
		private LuaFunction m_SetIndexInt32_hotfix;

		// Token: 0x0400AE44 RID: 44612
		private LuaFunction m_GetIndex_hotfix;

		// Token: 0x0400AE45 RID: 44613
		private LuaFunction m_SetPlayerIndexInt32_hotfix;

		// Token: 0x0400AE46 RID: 44614
		private LuaFunction m_SetPlayerTeamRoomPlayer_hotfix;

		// Token: 0x0400AE47 RID: 44615
		private LuaFunction m_GetPlayer_hotfix;

		// Token: 0x0400AE48 RID: 44616
		private LuaFunction m_SetNameString_hotfix;

		// Token: 0x0400AE49 RID: 44617
		private LuaFunction m_SetLevelInt32_hotfix;

		// Token: 0x0400AE4A RID: 44618
		private LuaFunction m_SetHeadIconInt32_hotfix;

		// Token: 0x0400AE4B RID: 44619
		private LuaFunction m_SetOnBoolean_hotfix;

		// Token: 0x0400AE4C RID: 44620
		private LuaFunction m_SetEditOnBoolean_hotfix;

		// Token: 0x0400AE4D RID: 44621
		private LuaFunction m_ShowChatString_hotfix;

		// Token: 0x0400AE4E RID: 44622
		private LuaFunction m_ShowBigExpressionInt32_hotfix;

		// Token: 0x0400AE4F RID: 44623
		private LuaFunction m_HideChat_hotfix;

		// Token: 0x0400AE50 RID: 44624
		private LuaFunction m_CreateSpineGraphicConfigDataJobConnectionInfoConfigDataModelSkinResourceInfo_hotfix;

		// Token: 0x0400AE51 RID: 44625
		private LuaFunction m_DestroySpineGraphic_hotfix;

		// Token: 0x0400AE52 RID: 44626
		private LuaFunction m_SetAnimationTimeSingle_hotfix;

		// Token: 0x0400AE53 RID: 44627
		private LuaFunction m_GetAnimationTime_hotfix;

		// Token: 0x0400AE54 RID: 44628
		private LuaFunction m_OnInviteButtonClick_hotfix;

		// Token: 0x0400AE55 RID: 44629
		private LuaFunction m_OnPlayerButtonClick_hotfix;

		// Token: 0x0400AE56 RID: 44630
		private LuaFunction m_OnBeginDragPointerEventData_hotfix;

		// Token: 0x0400AE57 RID: 44631
		private LuaFunction m_OnEndDragPointerEventData_hotfix;

		// Token: 0x0400AE58 RID: 44632
		private LuaFunction m_OnDragPointerEventData_hotfix;

		// Token: 0x0400AE59 RID: 44633
		private LuaFunction m_OnDropPointerEventData_hotfix;

		// Token: 0x0400AE5A RID: 44634
		private LuaFunction m_ClearEvents_hotfix;

		// Token: 0x0400AE5B RID: 44635
		private LuaFunction m_Update_hotfix;

		// Token: 0x0400AE5C RID: 44636
		private LuaFunction m_add_EventOnInviteButtonClickAction;

		// Token: 0x0400AE5D RID: 44637
		private LuaFunction m_remove_EventOnInviteButtonClickAction;

		// Token: 0x0400AE5E RID: 44638
		private LuaFunction m_add_EventOnPlayerButtonClickAction;

		// Token: 0x0400AE5F RID: 44639
		private LuaFunction m_remove_EventOnPlayerButtonClickAction;

		// Token: 0x0400AE60 RID: 44640
		private LuaFunction m_add_EventOnBeginDragAction;

		// Token: 0x0400AE61 RID: 44641
		private LuaFunction m_remove_EventOnBeginDragAction;

		// Token: 0x0400AE62 RID: 44642
		private LuaFunction m_add_EventOnEndDragAction;

		// Token: 0x0400AE63 RID: 44643
		private LuaFunction m_remove_EventOnEndDragAction;

		// Token: 0x0400AE64 RID: 44644
		private LuaFunction m_add_EventOnDragAction;

		// Token: 0x0400AE65 RID: 44645
		private LuaFunction m_remove_EventOnDragAction;

		// Token: 0x0400AE66 RID: 44646
		private LuaFunction m_add_EventOnDropAction;

		// Token: 0x0400AE67 RID: 44647
		private LuaFunction m_remove_EventOnDropAction;

		// Token: 0x02000F6C RID: 3948
		public new class LuaExportHelper
		{
			// Token: 0x06013A86 RID: 80518 RVA: 0x0050329C File Offset: 0x0050149C
			public LuaExportHelper(TeamRoomPlayerInfoUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06013A87 RID: 80519 RVA: 0x005032AC File Offset: 0x005014AC
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06013A88 RID: 80520 RVA: 0x005032BC File Offset: 0x005014BC
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06013A89 RID: 80521 RVA: 0x005032CC File Offset: 0x005014CC
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06013A8A RID: 80522 RVA: 0x005032DC File Offset: 0x005014DC
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06013A8B RID: 80523 RVA: 0x005032F4 File Offset: 0x005014F4
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06013A8C RID: 80524 RVA: 0x00503304 File Offset: 0x00501504
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06013A8D RID: 80525 RVA: 0x00503314 File Offset: 0x00501514
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06013A8E RID: 80526 RVA: 0x00503324 File Offset: 0x00501524
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06013A8F RID: 80527 RVA: 0x00503334 File Offset: 0x00501534
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06013A90 RID: 80528 RVA: 0x00503344 File Offset: 0x00501544
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06013A91 RID: 80529 RVA: 0x00503354 File Offset: 0x00501554
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06013A92 RID: 80530 RVA: 0x00503364 File Offset: 0x00501564
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06013A93 RID: 80531 RVA: 0x00503374 File Offset: 0x00501574
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06013A94 RID: 80532 RVA: 0x00503384 File Offset: 0x00501584
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06013A95 RID: 80533 RVA: 0x00503394 File Offset: 0x00501594
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06013A96 RID: 80534 RVA: 0x005033A4 File Offset: 0x005015A4
			public void __callDele_EventOnInviteButtonClick(TeamRoomPlayerInfoUIController obj)
			{
				this.m_owner.__callDele_EventOnInviteButtonClick(obj);
			}

			// Token: 0x06013A97 RID: 80535 RVA: 0x005033B4 File Offset: 0x005015B4
			public void __clearDele_EventOnInviteButtonClick(TeamRoomPlayerInfoUIController obj)
			{
				this.m_owner.__clearDele_EventOnInviteButtonClick(obj);
			}

			// Token: 0x06013A98 RID: 80536 RVA: 0x005033C4 File Offset: 0x005015C4
			public void __callDele_EventOnPlayerButtonClick(TeamRoomPlayerInfoUIController obj)
			{
				this.m_owner.__callDele_EventOnPlayerButtonClick(obj);
			}

			// Token: 0x06013A99 RID: 80537 RVA: 0x005033D4 File Offset: 0x005015D4
			public void __clearDele_EventOnPlayerButtonClick(TeamRoomPlayerInfoUIController obj)
			{
				this.m_owner.__clearDele_EventOnPlayerButtonClick(obj);
			}

			// Token: 0x06013A9A RID: 80538 RVA: 0x005033E4 File Offset: 0x005015E4
			public void __callDele_EventOnBeginDrag(TeamRoomPlayerInfoUIController arg1, PointerEventData arg2)
			{
				this.m_owner.__callDele_EventOnBeginDrag(arg1, arg2);
			}

			// Token: 0x06013A9B RID: 80539 RVA: 0x005033F4 File Offset: 0x005015F4
			public void __clearDele_EventOnBeginDrag(TeamRoomPlayerInfoUIController arg1, PointerEventData arg2)
			{
				this.m_owner.__clearDele_EventOnBeginDrag(arg1, arg2);
			}

			// Token: 0x06013A9C RID: 80540 RVA: 0x00503404 File Offset: 0x00501604
			public void __callDele_EventOnEndDrag(TeamRoomPlayerInfoUIController arg1, PointerEventData arg2)
			{
				this.m_owner.__callDele_EventOnEndDrag(arg1, arg2);
			}

			// Token: 0x06013A9D RID: 80541 RVA: 0x00503414 File Offset: 0x00501614
			public void __clearDele_EventOnEndDrag(TeamRoomPlayerInfoUIController arg1, PointerEventData arg2)
			{
				this.m_owner.__clearDele_EventOnEndDrag(arg1, arg2);
			}

			// Token: 0x06013A9E RID: 80542 RVA: 0x00503424 File Offset: 0x00501624
			public void __callDele_EventOnDrag(PointerEventData obj)
			{
				this.m_owner.__callDele_EventOnDrag(obj);
			}

			// Token: 0x06013A9F RID: 80543 RVA: 0x00503434 File Offset: 0x00501634
			public void __clearDele_EventOnDrag(PointerEventData obj)
			{
				this.m_owner.__clearDele_EventOnDrag(obj);
			}

			// Token: 0x06013AA0 RID: 80544 RVA: 0x00503444 File Offset: 0x00501644
			public void __callDele_EventOnDrop(PointerEventData obj)
			{
				this.m_owner.__callDele_EventOnDrop(obj);
			}

			// Token: 0x06013AA1 RID: 80545 RVA: 0x00503454 File Offset: 0x00501654
			public void __clearDele_EventOnDrop(PointerEventData obj)
			{
				this.m_owner.__clearDele_EventOnDrop(obj);
			}

			// Token: 0x17003AED RID: 15085
			// (get) Token: 0x06013AA2 RID: 80546 RVA: 0x00503464 File Offset: 0x00501664
			// (set) Token: 0x06013AA3 RID: 80547 RVA: 0x00503474 File Offset: 0x00501674
			public CommonUIStateController m_uiStateController
			{
				get
				{
					return this.m_owner.m_uiStateController;
				}
				set
				{
					this.m_owner.m_uiStateController = value;
				}
			}

			// Token: 0x17003AEE RID: 15086
			// (get) Token: 0x06013AA4 RID: 80548 RVA: 0x00503484 File Offset: 0x00501684
			// (set) Token: 0x06013AA5 RID: 80549 RVA: 0x00503494 File Offset: 0x00501694
			public Button m_playerButton
			{
				get
				{
					return this.m_owner.m_playerButton;
				}
				set
				{
					this.m_owner.m_playerButton = value;
				}
			}

			// Token: 0x17003AEF RID: 15087
			// (get) Token: 0x06013AA6 RID: 80550 RVA: 0x005034A4 File Offset: 0x005016A4
			// (set) Token: 0x06013AA7 RID: 80551 RVA: 0x005034B4 File Offset: 0x005016B4
			public Image m_playerTagImage
			{
				get
				{
					return this.m_owner.m_playerTagImage;
				}
				set
				{
					this.m_owner.m_playerTagImage = value;
				}
			}

			// Token: 0x17003AF0 RID: 15088
			// (get) Token: 0x06013AA8 RID: 80552 RVA: 0x005034C4 File Offset: 0x005016C4
			// (set) Token: 0x06013AA9 RID: 80553 RVA: 0x005034D4 File Offset: 0x005016D4
			public Text m_nameText
			{
				get
				{
					return this.m_owner.m_nameText;
				}
				set
				{
					this.m_owner.m_nameText = value;
				}
			}

			// Token: 0x17003AF1 RID: 15089
			// (get) Token: 0x06013AAA RID: 80554 RVA: 0x005034E4 File Offset: 0x005016E4
			// (set) Token: 0x06013AAB RID: 80555 RVA: 0x005034F4 File Offset: 0x005016F4
			public Text m_levelText
			{
				get
				{
					return this.m_owner.m_levelText;
				}
				set
				{
					this.m_owner.m_levelText = value;
				}
			}

			// Token: 0x17003AF2 RID: 15090
			// (get) Token: 0x06013AAC RID: 80556 RVA: 0x00503504 File Offset: 0x00501704
			// (set) Token: 0x06013AAD RID: 80557 RVA: 0x00503514 File Offset: 0x00501714
			public Image m_headIconImage
			{
				get
				{
					return this.m_owner.m_headIconImage;
				}
				set
				{
					this.m_owner.m_headIconImage = value;
				}
			}

			// Token: 0x17003AF3 RID: 15091
			// (get) Token: 0x06013AAE RID: 80558 RVA: 0x00503524 File Offset: 0x00501724
			// (set) Token: 0x06013AAF RID: 80559 RVA: 0x00503534 File Offset: 0x00501734
			public Transform m_headFrameTransform
			{
				get
				{
					return this.m_owner.m_headFrameTransform;
				}
				set
				{
					this.m_owner.m_headFrameTransform = value;
				}
			}

			// Token: 0x17003AF4 RID: 15092
			// (get) Token: 0x06013AB0 RID: 80560 RVA: 0x00503544 File Offset: 0x00501744
			// (set) Token: 0x06013AB1 RID: 80561 RVA: 0x00503554 File Offset: 0x00501754
			public GameObject m_graphicGameObject
			{
				get
				{
					return this.m_owner.m_graphicGameObject;
				}
				set
				{
					this.m_owner.m_graphicGameObject = value;
				}
			}

			// Token: 0x17003AF5 RID: 15093
			// (get) Token: 0x06013AB2 RID: 80562 RVA: 0x00503564 File Offset: 0x00501764
			// (set) Token: 0x06013AB3 RID: 80563 RVA: 0x00503574 File Offset: 0x00501774
			public Button m_inviteButton
			{
				get
				{
					return this.m_owner.m_inviteButton;
				}
				set
				{
					this.m_owner.m_inviteButton = value;
				}
			}

			// Token: 0x17003AF6 RID: 15094
			// (get) Token: 0x06013AB4 RID: 80564 RVA: 0x00503584 File Offset: 0x00501784
			// (set) Token: 0x06013AB5 RID: 80565 RVA: 0x00503594 File Offset: 0x00501794
			public CommonUIStateController m_chatUIStateController
			{
				get
				{
					return this.m_owner.m_chatUIStateController;
				}
				set
				{
					this.m_owner.m_chatUIStateController = value;
				}
			}

			// Token: 0x17003AF7 RID: 15095
			// (get) Token: 0x06013AB6 RID: 80566 RVA: 0x005035A4 File Offset: 0x005017A4
			// (set) Token: 0x06013AB7 RID: 80567 RVA: 0x005035B4 File Offset: 0x005017B4
			public EmojiText m_dialogText
			{
				get
				{
					return this.m_owner.m_dialogText;
				}
				set
				{
					this.m_owner.m_dialogText = value;
				}
			}

			// Token: 0x17003AF8 RID: 15096
			// (get) Token: 0x06013AB8 RID: 80568 RVA: 0x005035C4 File Offset: 0x005017C4
			// (set) Token: 0x06013AB9 RID: 80569 RVA: 0x005035D4 File Offset: 0x005017D4
			public Image m_dialogBigExpression
			{
				get
				{
					return this.m_owner.m_dialogBigExpression;
				}
				set
				{
					this.m_owner.m_dialogBigExpression = value;
				}
			}

			// Token: 0x17003AF9 RID: 15097
			// (get) Token: 0x06013ABA RID: 80570 RVA: 0x005035E4 File Offset: 0x005017E4
			// (set) Token: 0x06013ABB RID: 80571 RVA: 0x005035F4 File Offset: 0x005017F4
			public int m_index
			{
				get
				{
					return this.m_owner.m_index;
				}
				set
				{
					this.m_owner.m_index = value;
				}
			}

			// Token: 0x17003AFA RID: 15098
			// (get) Token: 0x06013ABC RID: 80572 RVA: 0x00503604 File Offset: 0x00501804
			// (set) Token: 0x06013ABD RID: 80573 RVA: 0x00503614 File Offset: 0x00501814
			public TeamRoomPlayer m_player
			{
				get
				{
					return this.m_owner.m_player;
				}
				set
				{
					this.m_owner.m_player = value;
				}
			}

			// Token: 0x17003AFB RID: 15099
			// (get) Token: 0x06013ABE RID: 80574 RVA: 0x00503624 File Offset: 0x00501824
			// (set) Token: 0x06013ABF RID: 80575 RVA: 0x00503634 File Offset: 0x00501834
			public UISpineGraphic m_spineGraphic
			{
				get
				{
					return this.m_owner.m_spineGraphic;
				}
				set
				{
					this.m_owner.m_spineGraphic = value;
				}
			}

			// Token: 0x17003AFC RID: 15100
			// (get) Token: 0x06013AC0 RID: 80576 RVA: 0x00503644 File Offset: 0x00501844
			// (set) Token: 0x06013AC1 RID: 80577 RVA: 0x00503654 File Offset: 0x00501854
			public float m_hideChatTime
			{
				get
				{
					return this.m_owner.m_hideChatTime;
				}
				set
				{
					this.m_owner.m_hideChatTime = value;
				}
			}

			// Token: 0x06013AC2 RID: 80578 RVA: 0x00503664 File Offset: 0x00501864
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06013AC3 RID: 80579 RVA: 0x00503674 File Offset: 0x00501874
			public void SetName(string name)
			{
				this.m_owner.SetName(name);
			}

			// Token: 0x06013AC4 RID: 80580 RVA: 0x00503684 File Offset: 0x00501884
			public void SetLevel(int level)
			{
				this.m_owner.SetLevel(level);
			}

			// Token: 0x06013AC5 RID: 80581 RVA: 0x00503694 File Offset: 0x00501894
			public void SetHeadIcon(int headIconId)
			{
				this.m_owner.SetHeadIcon(headIconId);
			}

			// Token: 0x06013AC6 RID: 80582 RVA: 0x005036A4 File Offset: 0x005018A4
			public void HideChat()
			{
				this.m_owner.HideChat();
			}

			// Token: 0x06013AC7 RID: 80583 RVA: 0x005036B4 File Offset: 0x005018B4
			public void CreateSpineGraphic(ConfigDataJobConnectionInfo jobConnectionInfo, ConfigDataModelSkinResourceInfo skinResInfo)
			{
				this.m_owner.CreateSpineGraphic(jobConnectionInfo, skinResInfo);
			}

			// Token: 0x06013AC8 RID: 80584 RVA: 0x005036C4 File Offset: 0x005018C4
			public void OnInviteButtonClick()
			{
				this.m_owner.OnInviteButtonClick();
			}

			// Token: 0x06013AC9 RID: 80585 RVA: 0x005036D4 File Offset: 0x005018D4
			public void OnPlayerButtonClick()
			{
				this.m_owner.OnPlayerButtonClick();
			}

			// Token: 0x06013ACA RID: 80586 RVA: 0x005036E4 File Offset: 0x005018E4
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x0400AE68 RID: 44648
			private TeamRoomPlayerInfoUIController m_owner;
		}
	}
}
