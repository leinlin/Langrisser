using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using BlackJack.ProjectL.Scene;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A24 RID: 2596
	[HotFix]
	public class ArenaUIController : UIControllerBase
	{
		// Token: 0x06009C14 RID: 39956 RVA: 0x002C5B98 File Offset: 0x002C3D98
		private ArenaUIController()
		{
		}

		// Token: 0x06009C15 RID: 39957 RVA: 0x002C5BAC File Offset: 0x002C3DAC
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
			this.OfflineOnBindFiledsCompleted();
			this.OnlineOnBindFiledsCompleted();
			this.m_returnButton.onClick.AddListener(new UnityAction(this.OnReturnButtonClick));
			this.m_helpButton.onClick.AddListener(new UnityAction(this.OnHelpButtonClick));
			this.m_switchButton.onClick.AddListener(new UnityAction(this.OnSwitchButtonClick));
			this.m_addArenaTicketButton.onClick.AddListener(new UnityAction(this.OnAddArenaTicketButtonClick));
			this.m_arenaTicketDescGameObject.SetActive(false);
			this.m_arenaTicketButton.onClick.AddListener(new UnityAction(this.ShowArenaTicketDesc));
			this.m_arenaTicketDescBackgroundButton.onClick.AddListener(new UnityAction(this.CloseArenaTicketDesc));
			this.m_buyArenaTicketUIStateController.gameObject.SetActive(false);
			this.m_buyArenaTicketBackgroundButton.onClick.AddListener(new UnityAction(this.OnBuyArenaTicketBackgroundButtonClick));
			this.m_buyArenaTicketBuyButton.onClick.AddListener(new UnityAction(this.OnBuyArenaTicketBuyButtonClick));
			this.m_rewardPreviewUIStateController.gameObject.SetActive(false);
			this.m_rewardPreviewBackgroundButton.onClick.AddListener(new UnityAction(this.OnRewardPreviewBackgroundButtonClick));
			this.m_prefabsGameObject.SetActive(false);
			UIUtility.MarginAdjustHorizontal(this.m_offlineMarginTransform);
			UIUtility.MarginAdjustHorizontal(this.m_onlineMarginTransform);
		}

		// Token: 0x06009C16 RID: 39958 RVA: 0x002C5D6C File Offset: 0x002C3F6C
		public void Open(ArenaUIType uiType, bool canSwitchOnline)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OpenArenaUITypeBoolean_hotfix != null)
			{
				this.m_OpenArenaUITypeBoolean_hotfix.call(new object[]
				{
					this,
					uiType,
					canSwitchOnline
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (uiType == ArenaUIType.Online)
			{
				UIUtility.SetUIStateOpen(this.m_uiStateController, "ShowOnline", null, false, true);
				this.m_switchUIStateController.SetToUIState("StartOnline", false, true);
			}
			else
			{
				UIUtility.SetUIStateOpen(this.m_uiStateController, "ShowOffline", null, false, true);
				this.m_switchUIStateController.SetToUIState("StartOffline", false, true);
			}
			this.m_switchButtonUIStateController.SetToUIState((!canSwitchOnline) ? "Lock" : "Unlock", false, true);
		}

		// Token: 0x06009C17 RID: 39959 RVA: 0x002C5E64 File Offset: 0x002C4064
		public void SwitchOfflineOnline(ArenaUIType uiType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SwitchOfflineOnlineArenaUIType_hotfix != null)
			{
				this.m_SwitchOfflineOnlineArenaUIType_hotfix.call(new object[]
				{
					this,
					uiType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_offlineGameObject.SetActive(true);
			this.m_onlineGameObject.SetActive(true);
			if (uiType == ArenaUIType.Online)
			{
				this.m_switchUIStateController.SetToUIState("Online", false, true);
				UIUtility.SetUIState(this.m_offlineOnlineChangeUIStateController, "Online", delegate
				{
					this.m_offlineGameObject.SetActive(false);
				}, false, true);
			}
			else
			{
				this.m_switchUIStateController.SetToUIState("Offline", false, true);
				UIUtility.SetUIState(this.m_offlineOnlineChangeUIStateController, "Offline", delegate
				{
					this.m_onlineGameObject.SetActive(false);
				}, false, true);
			}
		}

		// Token: 0x06009C18 RID: 39960 RVA: 0x002C5F58 File Offset: 0x002C4158
		public void SetPlayerHeadIcon(int playerHeadIconId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPlayerHeadIconInt32_hotfix != null)
			{
				this.m_SetPlayerHeadIconInt32_hotfix.call(new object[]
				{
					this,
					playerHeadIconId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int headPortrait = HeadIconTools.GetHeadPortrait(playerHeadIconId);
			Image offlinePlayerIconImage = this.m_offlinePlayerIconImage;
			Sprite sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerHeadIconImageName(headPortrait));
			this.m_onlinePlayerIconImage.sprite = sprite;
			offlinePlayerIconImage.sprite = sprite;
			Image offlineRankingPlayerIconImage = this.m_offlineRankingPlayerIconImage;
			sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerSmallHeadIconImageName(headPortrait));
			this.m_onlineRankingPlayerIconImage.sprite = sprite;
			offlineRankingPlayerIconImage.sprite = sprite;
			UIUtility.SetPlayerHeadFrame(this.m_offlineRankingPlayerHeadFrameTransform, HeadIconTools.GetHeadFrame(playerHeadIconId), true, "Normal");
			UIUtility.SetPlayerHeadFrame(this.m_onlineRankingPlayerHeadFrameTransform, HeadIconTools.GetHeadFrame(playerHeadIconId), true, "Normal");
		}

		// Token: 0x06009C19 RID: 39961 RVA: 0x002C6054 File Offset: 0x002C4254
		public void SetPlayerName(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPlayerNameString_hotfix != null)
			{
				this.m_SetPlayerNameString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Text offlinePlayerNameText = this.m_offlinePlayerNameText;
			this.m_onlinePlayerNameText.text = name;
			offlinePlayerNameText.text = name;
			Text offlineRankingPlayerNameText = this.m_offlineRankingPlayerNameText;
			this.m_onlineRankingPlayerNameText.text = name;
			offlineRankingPlayerNameText.text = name;
		}

		// Token: 0x06009C1A RID: 39962 RVA: 0x002C60F8 File Offset: 0x002C42F8
		public void SetPlayerLevel(int level)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPlayerLevelInt32_hotfix != null)
			{
				this.m_SetPlayerLevelInt32_hotfix.call(new object[]
				{
					this,
					level
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Text offlinePlayerLevelText = this.m_offlinePlayerLevelText;
			string text = level.ToString();
			this.m_onlineRankingPlayerLevelText.text = text;
			text = text;
			this.m_offlineRankingPlayerLevelText.text = text;
			text = text;
			this.m_onlinePlayerLevelText.text = text;
			offlinePlayerLevelText.text = text;
		}

		// Token: 0x06009C1B RID: 39963 RVA: 0x002C61AC File Offset: 0x002C43AC
		public void SetArenaHonor(int areanaCoin)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetArenaHonorInt32_hotfix != null)
			{
				this.m_SetArenaHonorInt32_hotfix.call(new object[]
				{
					this,
					areanaCoin
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Text offlineArenaCoinText = this.m_offlineArenaCoinText;
			string text = areanaCoin.ToString();
			this.m_onlineArenaCoinText.text = text;
			offlineArenaCoinText.text = text;
		}

		// Token: 0x06009C1C RID: 39964 RVA: 0x002C6244 File Offset: 0x002C4444
		public void SetArenaTicket(int count, int countMax)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetArenaTicketInt32Int32_hotfix != null)
			{
				this.m_SetArenaTicketInt32Int32_hotfix.call(new object[]
				{
					this,
					count,
					countMax
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			string format = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Arena_TicketCount);
			this.m_arenaTicketText.text = string.Format(format, count, countMax);
		}

		// Token: 0x06009C1D RID: 39965 RVA: 0x002C6300 File Offset: 0x002C4500
		public void SetBattlePower(int battlePower)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBattlePowerInt32_hotfix != null)
			{
				this.m_SetBattlePowerInt32_hotfix.call(new object[]
				{
					this,
					battlePower
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_offlinePlayerBattlePowerText.text = battlePower.ToString();
		}

		// Token: 0x06009C1E RID: 39966 RVA: 0x002C6388 File Offset: 0x002C4588
		private void ShowArenaTicketDesc()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowArenaTicketDesc_hotfix != null)
			{
				this.m_ShowArenaTicketDesc_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_arenaTicketDescUIStateCtrl, "PanelOpen", null, false, true);
		}

		// Token: 0x06009C1F RID: 39967 RVA: 0x002C63FC File Offset: 0x002C45FC
		private void CloseArenaTicketDesc()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseArenaTicketDesc_hotfix != null)
			{
				this.m_CloseArenaTicketDesc_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_arenaTicketDescUIStateCtrl, "PanelClose", null, false, true);
		}

		// Token: 0x06009C20 RID: 39968 RVA: 0x002C6470 File Offset: 0x002C4670
		private UISpineGraphic CreateSpineGraphic(ConfigDataJobConnectionInfo jobConnectionInfo, ConfigDataModelSkinResourceInfo skinResInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateSpineGraphicConfigDataJobConnectionInfoConfigDataModelSkinResourceInfo_hotfix != null)
			{
				return (UISpineGraphic)this.m_CreateSpineGraphicConfigDataJobConnectionInfoConfigDataModelSkinResourceInfo_hotfix.call(new object[]
				{
					this,
					jobConnectionInfo,
					skinResInfo
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (jobConnectionInfo == null)
			{
				return null;
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
			float scale = (float)jobConnectionInfo.ModelScale * 0.01f * 1.23f;
			UISpineGraphic uispineGraphic = new UISpineGraphic();
			uispineGraphic.Create(text);
			uispineGraphic.SetDirection(-1);
			uispineGraphic.SetScale(scale);
			uispineGraphic.SetReplaceAnimations(jobConnectionInfo.ReplaceAnims);
			uispineGraphic.PlayAnimation("idle", true, 0);
			uispineGraphic.ForceUpdate();
			return uispineGraphic;
		}

		// Token: 0x06009C21 RID: 39969 RVA: 0x002C657C File Offset: 0x002C477C
		private void AddRewardPreviewGoods(List<Goods> goods)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddRewardPreviewGoodsList`1_hotfix != null)
			{
				this.m_AddRewardPreviewGoodsList`1_hotfix.call(new object[]
				{
					this,
					goods
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyChildren(this.m_rewardPreviewScrollRect.content.gameObject);
			if (goods == null)
			{
				return;
			}
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("RewardGoods5");
			RewardGoodsUIController.CreateRewardGoodsList(goods, this.m_rewardPreviewScrollRect.content, assetInContainer, null, true, 1, true);
		}

		// Token: 0x06009C22 RID: 39970 RVA: 0x002C662C File Offset: 0x002C482C
		public void ShowBuyArenaTicket(int ticketCount, int price)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowBuyArenaTicketInt32Int32_hotfix != null)
			{
				this.m_ShowBuyArenaTicketInt32Int32_hotfix.call(new object[]
				{
					this,
					ticketCount,
					price
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_buyArenaTicketUIStateController, "Open", null, false, true);
			this.m_buyArenaTicketCountText.text = ticketCount.ToString();
			this.m_buyArenaTicketPriceText.text = price.ToString();
		}

		// Token: 0x06009C23 RID: 39971 RVA: 0x002C66F0 File Offset: 0x002C48F0
		public void HideBuyArenaTicket()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideBuyArenaTicket_hotfix != null)
			{
				this.m_HideBuyArenaTicket_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_buyArenaTicketUIStateController, "Close", null, true, true);
		}

		// Token: 0x06009C24 RID: 39972 RVA: 0x002C6764 File Offset: 0x002C4964
		private void OnReturnButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnReturnButtonClick_hotfix != null)
			{
				this.m_OnReturnButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnReturn != null)
			{
				this.EventOnReturn();
			}
		}

		// Token: 0x06009C25 RID: 39973 RVA: 0x002C67DC File Offset: 0x002C49DC
		private void OnHelpButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHelpButtonClick_hotfix != null)
			{
				this.m_OnHelpButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowHelp != null)
			{
				this.EventOnShowHelp();
			}
		}

		// Token: 0x06009C26 RID: 39974 RVA: 0x002C6854 File Offset: 0x002C4A54
		private void OnRewardPreviewBackgroundButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRewardPreviewBackgroundButtonClick_hotfix != null)
			{
				this.m_OnRewardPreviewBackgroundButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_rewardPreviewUIStateController, "PanelClose", null, true, true);
		}

		// Token: 0x06009C27 RID: 39975 RVA: 0x002C68C8 File Offset: 0x002C4AC8
		private void OnAddArenaTicketButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAddArenaTicketButtonClick_hotfix != null)
			{
				this.m_OnAddArenaTicketButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowBuyArenaTicket != null)
			{
				this.EventOnShowBuyArenaTicket();
			}
		}

		// Token: 0x06009C28 RID: 39976 RVA: 0x002C6940 File Offset: 0x002C4B40
		private void OnBuyArenaTicketBackgroundButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBuyArenaTicketBackgroundButtonClick_hotfix != null)
			{
				this.m_OnBuyArenaTicketBackgroundButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideBuyArenaTicket();
		}

		// Token: 0x06009C29 RID: 39977 RVA: 0x002C69A8 File Offset: 0x002C4BA8
		private void OnBuyArenaTicketBuyButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBuyArenaTicketBuyButtonClick_hotfix != null)
			{
				this.m_OnBuyArenaTicketBuyButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnBuyArenaTicket != null)
			{
				this.EventOnBuyArenaTicket();
			}
		}

		// Token: 0x06009C2A RID: 39978 RVA: 0x002C6A20 File Offset: 0x002C4C20
		private void OnSwitchButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSwitchButtonClick_hotfix != null)
			{
				this.m_OnSwitchButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (UIUtility.GetUIStateCurrentStateName(this.m_switchButtonUIStateController) == "Lock")
			{
				CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_RealTimePVP), 2f, null, true);
				this.m_switchUIStateController.SetToUIState("CanNotSwitch", false, true);
				return;
			}
			if (this.EventOnSwitchOnlineOffline != null)
			{
				this.EventOnSwitchOnlineOffline();
			}
		}

		// Token: 0x140001C5 RID: 453
		// (add) Token: 0x06009C2B RID: 39979 RVA: 0x002C6ADC File Offset: 0x002C4CDC
		// (remove) Token: 0x06009C2C RID: 39980 RVA: 0x002C6B78 File Offset: 0x002C4D78
		public event Action EventOnDefend
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnDefendAction_hotfix != null)
				{
					this.m_add_EventOnDefendAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnDefend;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnDefend, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnDefendAction_hotfix != null)
				{
					this.m_remove_EventOnDefendAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnDefend;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnDefend, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001C6 RID: 454
		// (add) Token: 0x06009C2D RID: 39981 RVA: 0x002C6C14 File Offset: 0x002C4E14
		// (remove) Token: 0x06009C2E RID: 39982 RVA: 0x002C6CB0 File Offset: 0x002C4EB0
		public event Action EventOnReturn
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnReturnAction_hotfix != null)
				{
					this.m_add_EventOnReturnAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnReturn;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnReturn, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnReturnAction_hotfix != null)
				{
					this.m_remove_EventOnReturnAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnReturn;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnReturn, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001C7 RID: 455
		// (add) Token: 0x06009C2F RID: 39983 RVA: 0x002C6D4C File Offset: 0x002C4F4C
		// (remove) Token: 0x06009C30 RID: 39984 RVA: 0x002C6DE8 File Offset: 0x002C4FE8
		public event Action EventOnShowHelp
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowHelpAction_hotfix != null)
				{
					this.m_add_EventOnShowHelpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowHelp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowHelp, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowHelpAction_hotfix != null)
				{
					this.m_remove_EventOnShowHelpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowHelp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowHelp, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001C8 RID: 456
		// (add) Token: 0x06009C31 RID: 39985 RVA: 0x002C6E84 File Offset: 0x002C5084
		// (remove) Token: 0x06009C32 RID: 39986 RVA: 0x002C6F20 File Offset: 0x002C5120
		public event Action EventOnShowBuyArenaTicket
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowBuyArenaTicketAction_hotfix != null)
				{
					this.m_add_EventOnShowBuyArenaTicketAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowBuyArenaTicket;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowBuyArenaTicket, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowBuyArenaTicketAction_hotfix != null)
				{
					this.m_remove_EventOnShowBuyArenaTicketAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowBuyArenaTicket;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowBuyArenaTicket, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001C9 RID: 457
		// (add) Token: 0x06009C33 RID: 39987 RVA: 0x002C6FBC File Offset: 0x002C51BC
		// (remove) Token: 0x06009C34 RID: 39988 RVA: 0x002C7058 File Offset: 0x002C5258
		public event Action EventOnBuyArenaTicket
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnBuyArenaTicketAction_hotfix != null)
				{
					this.m_add_EventOnBuyArenaTicketAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnBuyArenaTicket;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnBuyArenaTicket, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnBuyArenaTicketAction_hotfix != null)
				{
					this.m_remove_EventOnBuyArenaTicketAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnBuyArenaTicket;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnBuyArenaTicket, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001CA RID: 458
		// (add) Token: 0x06009C35 RID: 39989 RVA: 0x002C70F4 File Offset: 0x002C52F4
		// (remove) Token: 0x06009C36 RID: 39990 RVA: 0x002C7190 File Offset: 0x002C5390
		public event Action EventOnSwitchOnlineOffline
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSwitchOnlineOfflineAction_hotfix != null)
				{
					this.m_add_EventOnSwitchOnlineOfflineAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSwitchOnlineOffline;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSwitchOnlineOffline, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSwitchOnlineOfflineAction_hotfix != null)
				{
					this.m_remove_EventOnSwitchOnlineOfflineAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSwitchOnlineOffline;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSwitchOnlineOffline, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x06009C37 RID: 39991 RVA: 0x002C722C File Offset: 0x002C542C
		private void OfflineOnBindFiledsCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OfflineOnBindFiledsCompleted_hotfix != null)
			{
				this.m_OfflineOnBindFiledsCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_arenaOpponentPool = new GameObjectPool<ArenaOpponentListItemUIController>();
			this.m_arenaOpponentPool.Setup(this.m_arenaOpponentListItemPrefab, this.m_offlineArenaOpponentsGameObject);
			this.m_arenaRankingPool = new GameObjectPool<ArenaRankingListItemUIController>();
			this.m_arenaRankingPool.Setup(this.m_arenaRankingListItemPrefab, this.m_offlineRankingScrollRect.content.gameObject);
			this.m_offlineArenaBattleReportPool = new GameObjectPool<OfflineArenaBattleReportListItemUIController>();
			this.m_offlineArenaBattleReportPool.Setup(this.m_offlineArenaBattleReportListItemPrefab, this.m_offlineBattleReportScrollRect.content.gameObject);
			this.m_offlineArenaPointRewardPool = new GameObjectPool<ArenaPointRewardListItemUIController>();
			this.m_offlineArenaPointRewardPool.Setup(this.m_arenaPointRewardListItemPrefab, this.m_offlineArenaPointRewardScrollRect.content.gameObject);
			this.m_offlineDefendButton.onClick.AddListener(new UnityAction(this.OnDefendButtonClick));
			this.m_offlineClashToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnOfflineClashToggle));
			this.m_offlineBattleReportToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnOfflineBattleReportToggle));
			this.m_offlineRankingToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnOfflineRankingToggle));
			this.m_offlineInSettleGameObject.SetActive(false);
			this.m_offlineVictoryPointsRewardButtons = new GainRewardButton[3];
			this.m_offlineVictoryPointsRewardButtons[0] = GameObjectUtility.AddControllerToGameObject<GainRewardButton>(this.m_offlineVictoryPointsRewardButton1GameObject);
			this.m_offlineVictoryPointsRewardButtons[0].SetId(1);
			this.m_offlineVictoryPointsRewardButtons[0].EventOnClick += this.OnOfflineVictoryPointsRewardButtonClick;
			this.m_offlineVictoryPointsRewardButtons[1] = GameObjectUtility.AddControllerToGameObject<GainRewardButton>(this.m_offlineVictoryPointsRewardButton2GameObject);
			this.m_offlineVictoryPointsRewardButtons[1].SetId(2);
			this.m_offlineVictoryPointsRewardButtons[1].EventOnClick += this.OnOfflineVictoryPointsRewardButtonClick;
			this.m_offlineVictoryPointsRewardButtons[2] = GameObjectUtility.AddControllerToGameObject<GainRewardButton>(this.m_offlineVictoryPointsRewardButton3GameObject);
			this.m_offlineVictoryPointsRewardButtons[2].SetId(3);
			this.m_offlineVictoryPointsRewardButtons[2].EventOnClick += this.OnOfflineVictoryPointsRewardButtonClick;
			this.m_offlineArenaPointRewardButton.onClick.AddListener(new UnityAction(this.OnOfflineArenaPointRewardButtonClick));
			this.m_offlineArenaPointRewardBGButton.onClick.AddListener(new UnityAction(this.OnOfflineArenaPointRewardCloseButtonClick));
			this.m_offlineArenaPointRewardCloseButton.onClick.AddListener(new UnityAction(this.OnOfflineArenaPointRewardCloseButtonClick));
			this.m_attackUIStateController.gameObject.SetActive(false);
			this.m_attackConfirmButton.onClick.AddListener(new UnityAction(this.OnAttackConfirmButtonClick));
			this.m_attackAutoConfirmButton.onClick.AddListener(new UnityAction(this.OnAutoBattleButtonClick));
			this.m_attackBackgroundButton.onClick.AddListener(new UnityAction(this.OnAttackBackgroundButtonClick));
			this.m_autoBattleTipsConfirmButton.onClick.AddListener(new UnityAction(this.OnAutoBattleTipsConfirmButtonClick));
			this.m_autoBattleTipsCancelButton.onClick.AddListener(new UnityAction(this.OnAutoBattleTipsCancelButtonClick));
			this.m_autoBattleTipsBackgroundButton.onClick.AddListener(new UnityAction(this.OnAutoBattleTipsCancelButtonClick));
		}

		// Token: 0x06009C38 RID: 39992 RVA: 0x002C7578 File Offset: 0x002C5778
		public void SetOfflineArenaPointsAndLevel(int arenaPoints, int arenaLevelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetOfflineArenaPointsAndLevelInt32Int32_hotfix != null)
			{
				this.m_SetOfflineArenaPointsAndLevelInt32Int32_hotfix.call(new object[]
				{
					this,
					arenaPoints,
					arenaLevelId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Text offlineArenaPointsText = this.m_offlineArenaPointsText;
			string text = arenaPoints.ToString();
			this.m_offlineRankingArenaPointsText.text = text;
			offlineArenaPointsText.text = text;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataArenaLevelInfo configDataArenaLevelInfo = configDataLoader.GetConfigDataArenaLevelInfo(arenaLevelId);
			if (configDataArenaLevelInfo != null)
			{
				int num = 0;
				int num2 = 0;
				ConfigDataArenaLevelInfo configDataArenaLevelInfo2 = configDataLoader.GetConfigDataArenaLevelInfo(arenaLevelId + 1);
				if (configDataArenaLevelInfo2 != null)
				{
					num = configDataArenaLevelInfo.UpgradePoints;
					num2 = configDataArenaLevelInfo2.UpgradePoints;
				}
				else
				{
					ConfigDataArenaLevelInfo configDataArenaLevelInfo3 = configDataLoader.GetConfigDataArenaLevelInfo(arenaLevelId - 1);
					if (configDataArenaLevelInfo3 != null)
					{
						num = configDataArenaLevelInfo3.UpgradePoints;
						num2 = configDataArenaLevelInfo.UpgradePoints;
					}
				}
				this.m_offlineArenaPointsUpText1.text = num.ToString();
				this.m_offlineArenaPointsUpText2.text = num2.ToString();
				this.m_offlineArenaPointsUpBarImage.fillAmount = (float)(arenaPoints - num) / (float)(num2 - num);
			}
		}

		// Token: 0x06009C39 RID: 39993 RVA: 0x002C76D0 File Offset: 0x002C58D0
		public void SetOfflineWeekWin(int count, int countMax)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetOfflineWeekWinInt32Int32_hotfix != null)
			{
				this.m_SetOfflineWeekWinInt32Int32_hotfix.call(new object[]
				{
					this,
					count,
					countMax
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			string format = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Arena_WeekWin);
			this.m_offlineWeekWinText.text = string.Format(format, count, countMax);
		}

		// Token: 0x06009C3A RID: 39994 RVA: 0x002C778C File Offset: 0x002C598C
		public void SetOfflineInSettleTime(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetOfflineInSettleTimeBoolean_hotfix != null)
			{
				this.m_SetOfflineInSettleTimeBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_offlineInSettleGameObject.SetActive(on);
			this.m_offlineArenaOpponentsGameObject.SetActive(!on);
		}

		// Token: 0x06009C3B RID: 39995 RVA: 0x002C7818 File Offset: 0x002C5A18
		public void SetOfflineVictoryPointsRewardStatus(int idx, int num, GainRewardStatus status)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetOfflineVictoryPointsRewardStatusInt32Int32GainRewardStatus_hotfix != null)
			{
				this.m_SetOfflineVictoryPointsRewardStatusInt32Int32GainRewardStatus_hotfix.call(new object[]
				{
					this,
					idx,
					num,
					status
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (idx < 0 || idx >= this.m_offlineVictoryPointsRewardButtons.Length)
			{
				return;
			}
			this.m_offlineVictoryPointsRewardButtons[idx].SetNum(num);
			this.m_offlineVictoryPointsRewardButtons[idx].SetStatus(status);
		}

		// Token: 0x06009C3C RID: 39996 RVA: 0x002C78DC File Offset: 0x002C5ADC
		public void SetOfflineVictoryPointsRewardProgress(int victoryPoints, int victoryPointsMax)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetOfflineVictoryPointsRewardProgressInt32Int32_hotfix != null)
			{
				this.m_SetOfflineVictoryPointsRewardProgressInt32Int32_hotfix.call(new object[]
				{
					this,
					victoryPoints,
					victoryPointsMax
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_offlineVictoryPointsText.text = victoryPoints.ToString();
			if (victoryPoints > 0 && victoryPointsMax > 0)
			{
				this.m_offlineVictoryPointsRewardImage.fillAmount = (float)victoryPoints / (float)victoryPointsMax;
			}
			else
			{
				this.m_offlineVictoryPointsRewardImage.fillAmount = 0f;
			}
		}

		// Token: 0x06009C3D RID: 39997 RVA: 0x002C79A8 File Offset: 0x002C5BA8
		public void SetOfflineArenaOpponents(List<ArenaOpponent> opponents, bool isGuardBattle)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetOfflineArenaOpponentsList`1Boolean_hotfix != null)
			{
				this.m_SetOfflineArenaOpponentsList`1Boolean_hotfix.call(new object[]
				{
					this,
					opponents,
					isGuardBattle
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_arenaOpponentPool.Deactive();
			if (opponents == null)
			{
				return;
			}
			for (int i = 0; i < opponents.Count; i++)
			{
				bool flag;
				ArenaOpponentListItemUIController arenaOpponentListItemUIController = this.m_arenaOpponentPool.Allocate(out flag);
				if (arenaOpponentListItemUIController != null)
				{
					if (flag)
					{
						arenaOpponentListItemUIController.EventOnAttackButtonClick += this.OnOfflineArenaOpponentAttackButtonClick;
					}
					arenaOpponentListItemUIController.SetArenaOpponent(opponents[i], i, isGuardBattle);
				}
			}
		}

		// Token: 0x06009C3E RID: 39998 RVA: 0x002C7A94 File Offset: 0x002C5C94
		public void SetOfflineArenaOpponentsRefreshTime(TimeSpan ts)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetOfflineArenaOpponentsRefreshTimeTimeSpan_hotfix != null)
			{
				this.m_SetOfflineArenaOpponentsRefreshTimeTimeSpan_hotfix.call(new object[]
				{
					this,
					ts
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			string format = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Arena_OpponentFlushTime);
			this.m_offlineArenaOpponentsRefreshTimeText.text = string.Format(format, ts.Hours, ts.Minutes, ts.Seconds);
		}

		// Token: 0x06009C3F RID: 39999 RVA: 0x002C7B58 File Offset: 0x002C5D58
		public void SetOfflineArenaBattleReports(List<ArenaBattleReport> battleReports)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetOfflineArenaBattleReportsList`1_hotfix != null)
			{
				this.m_SetOfflineArenaBattleReportsList`1_hotfix.call(new object[]
				{
					this,
					battleReports
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_offlineArenaBattleReportPool.Deactive();
			if (battleReports == null)
			{
				return;
			}
			foreach (ArenaBattleReport arenaBattleReport in battleReports)
			{
				bool flag;
				OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = this.m_offlineArenaBattleReportPool.Allocate(out flag);
				if (offlineArenaBattleReportListItemUIController != null)
				{
					if (flag)
					{
						offlineArenaBattleReportListItemUIController.EventOnRevengeButtonClick += this.OnOfflineBattleReportRevengeButtonClick;
						offlineArenaBattleReportListItemUIController.EventOnReplayButtonClick += this.OnOfflineBattleReportReplayButtonClick;
					}
					offlineArenaBattleReportListItemUIController.SetArenaBattleReport(arenaBattleReport);
				}
			}
			this.m_offlineNoBattleReportGameObject.SetActive(battleReports.Count <= 0);
			this.m_offlineBattleReportScrollRect.normalizedPosition = Vector2.one;
		}

		// Token: 0x06009C40 RID: 40000 RVA: 0x002C7C90 File Offset: 0x002C5E90
		public void SetOfflineArenaRankings(int mineRank, List<ProArenaTopRankPlayer> players)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetOfflineArenaRankingsInt32List`1_hotfix != null)
			{
				this.m_SetOfflineArenaRankingsInt32List`1_hotfix.call(new object[]
				{
					this,
					mineRank,
					players
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string leaderboardRankingImageName = UIUtility.GetLeaderboardRankingImageName(mineRank);
			if (!string.IsNullOrEmpty(leaderboardRankingImageName))
			{
				this.m_offlineRankingPlayerRankingUIStateController.SetToUIState("TopThree", false, true);
				this.m_offlineRankingPlayerRankingImage.sprite = AssetUtility.Instance.GetSprite(leaderboardRankingImageName);
			}
			else
			{
				this.m_offlineRankingPlayerRankingUIStateController.SetToUIState("Normal", false, true);
				if (mineRank > 0)
				{
					this.m_offlineRankingPlayerRankingText.text = mineRank.ToString();
				}
				else
				{
					IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
					this.m_offlineRankingPlayerRankingText.text = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Arena_NoRanking);
				}
			}
			this.m_arenaRankingPool.Deactive();
			for (int i = 0; i < players.Count; i++)
			{
				ArenaRankingListItemUIController arenaRankingListItemUIController = this.m_arenaRankingPool.Allocate();
				if (arenaRankingListItemUIController != null)
				{
					arenaRankingListItemUIController.SetRanking(i + 1);
					arenaRankingListItemUIController.SetIndex(i);
					arenaRankingListItemUIController.SetPlayer(players[i]);
				}
			}
			this.m_offlineRankingScrollRect.normalizedPosition = Vector2.one;
		}

		// Token: 0x06009C41 RID: 40001 RVA: 0x002C7E14 File Offset: 0x002C6014
		public void ShowOfflinePanel(OfflineArenaPanelType panelType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowOfflinePanelOfflineArenaPanelType_hotfix != null)
			{
				this.m_ShowOfflinePanelOfflineArenaPanelType_hotfix.call(new object[]
				{
					this,
					panelType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_offlineClashPanelGameObject.SetActive(panelType == OfflineArenaPanelType.Clash);
			this.m_offlineBattleReportPanelGameObject.SetActive(panelType == OfflineArenaPanelType.BattleReport);
			this.m_offlineRankingPanelGameObject.SetActive(panelType == OfflineArenaPanelType.Ranking);
			this.m_isIgnoreToggleEvent = true;
			this.m_offlineClashToggle.isOn = (panelType == OfflineArenaPanelType.Clash);
			this.m_offlineBattleReportToggle.isOn = (panelType == OfflineArenaPanelType.BattleReport);
			this.m_offlineRankingToggle.isOn = (panelType == OfflineArenaPanelType.Ranking);
			this.m_isIgnoreToggleEvent = false;
		}

		// Token: 0x06009C42 RID: 40002 RVA: 0x002C7EEC File Offset: 0x002C60EC
		private void ShowAutoBattleTips()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowAutoBattleTips_hotfix != null)
			{
				this.m_ShowAutoBattleTips_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_autoBattleTipsUIStateController, "Open", null, false, true);
		}

		// Token: 0x06009C43 RID: 40003 RVA: 0x002C7F60 File Offset: 0x002C6160
		private void HideAutoBattleTips()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideAutoBattleTips_hotfix != null)
			{
				this.m_HideAutoBattleTips_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_autoBattleTipsUIStateController, "Close", null, true, true);
		}

		// Token: 0x06009C44 RID: 40004 RVA: 0x002C7FD4 File Offset: 0x002C61D4
		public void ShowArenaOpponent(ArenaOpponent opponent, List<BattleHero> heros, int battlePower, bool isRevenge)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowArenaOpponentArenaOpponentList`1Int32Boolean_hotfix != null)
			{
				this.m_ShowArenaOpponentArenaOpponentList`1Int32Boolean_hotfix.call(new object[]
				{
					this,
					opponent,
					heros,
					battlePower,
					isRevenge
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_attackUIStateController, "Show", null, false, true);
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.ClearOpponentGraphcs();
			for (int i = 0; i < heros.Count; i++)
			{
				Transform transform = this.m_attackGraphicsGameObject.transform.Find(i.ToString());
				if (transform == null)
				{
					break;
				}
				BattleHero battleHero = heros[i];
				ConfigDataJobConnectionInfo configDataJobConnectionInfo = configDataLoader.GetConfigDataJobConnectionInfo(battleHero.ActiveHeroJobRelatedId);
				if (configDataJobConnectionInfo != null)
				{
					UISpineGraphic uispineGraphic = this.CreateSpineGraphic(configDataJobConnectionInfo, battleHero.GetHeroActiveJobModelSkinResourceInfo(configDataLoader));
					if (uispineGraphic != null)
					{
						uispineGraphic.SetParent(transform.gameObject);
						this.m_opponentGraphics.Add(uispineGraphic);
					}
				}
			}
			this.m_attackPlayerIconImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerHeadIconImageName(HeadIconTools.GetHeadPortrait(opponent.HeadIcon)));
			this.m_attackPlayerNameText.text = opponent.Name;
			this.m_attackPlayerLVText.text = opponent.Level.ToString();
			this.m_attackPlayerArenaPointText.text = opponent.ArenaPoints.ToString();
			this.m_attackBattlePowerText.text = battlePower.ToString();
			this.m_isRevengeOpponent = isRevenge;
		}

		// Token: 0x06009C45 RID: 40005 RVA: 0x002C81C8 File Offset: 0x002C63C8
		private void HideArenaOpponent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideArenaOpponent_hotfix != null)
			{
				this.m_HideArenaOpponent_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_attackUIStateController, "Close", null, true, true);
		}

		// Token: 0x06009C46 RID: 40006 RVA: 0x002C823C File Offset: 0x002C643C
		private void ClearOpponentGraphcs()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearOpponentGraphcs_hotfix != null)
			{
				this.m_ClearOpponentGraphcs_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (UISpineGraphic uispineGraphic in this.m_opponentGraphics)
			{
				uispineGraphic.Destroy();
			}
			this.m_opponentGraphics.Clear();
		}

		// Token: 0x06009C47 RID: 40007 RVA: 0x002C82F8 File Offset: 0x002C64F8
		private void OnOfflineClashToggle(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnOfflineClashToggleBoolean_hotfix != null)
			{
				this.m_OnOfflineClashToggleBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (on && this.EventOnShowOfflinePanel != null)
			{
				this.EventOnShowOfflinePanel(OfflineArenaPanelType.Clash);
			}
		}

		// Token: 0x06009C48 RID: 40008 RVA: 0x002C8394 File Offset: 0x002C6594
		private void OnOfflineBattleReportToggle(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnOfflineBattleReportToggleBoolean_hotfix != null)
			{
				this.m_OnOfflineBattleReportToggleBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (on && this.EventOnShowOfflinePanel != null)
			{
				this.EventOnShowOfflinePanel(OfflineArenaPanelType.BattleReport);
			}
		}

		// Token: 0x06009C49 RID: 40009 RVA: 0x002C8430 File Offset: 0x002C6630
		private void OnOfflineRankingToggle(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnOfflineRankingToggleBoolean_hotfix != null)
			{
				this.m_OnOfflineRankingToggleBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (on && this.EventOnShowOfflinePanel != null)
			{
				this.EventOnShowOfflinePanel(OfflineArenaPanelType.Ranking);
			}
		}

		// Token: 0x06009C4A RID: 40010 RVA: 0x002C84CC File Offset: 0x002C66CC
		private void OnOfflineArenaPointRewardButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnOfflineArenaPointRewardButtonClick_hotfix != null)
			{
				this.m_OnOfflineArenaPointRewardButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			List<ConfigDataArenaLevelInfo> list = new List<ConfigDataArenaLevelInfo>();
			foreach (KeyValuePair<int, ConfigDataArenaLevelInfo> keyValuePair in configDataLoader.GetAllConfigDataArenaLevelInfo())
			{
				list.Add(keyValuePair.Value);
			}
			list.Reverse();
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("RewardGoods");
			this.m_offlineArenaPointRewardPool.Deactive();
			for (int i = 0; i < list.Count; i++)
			{
				ArenaPointRewardListItemUIController arenaPointRewardListItemUIController = this.m_offlineArenaPointRewardPool.Allocate();
				if (arenaPointRewardListItemUIController != null)
				{
					ConfigDataArenaLevelInfo prevLevelInfo = (i <= 0) ? null : list[i - 1];
					arenaPointRewardListItemUIController.SetArenaLevelInfo(list[i], prevLevelInfo, assetInContainer);
					arenaPointRewardListItemUIController.SetIndex(i);
				}
			}
			UIUtility.SetUIStateOpen(this.m_offineArenaPointRewardUIStateCtrl, "Show", null, false, true);
		}

		// Token: 0x06009C4B RID: 40011 RVA: 0x002C8630 File Offset: 0x002C6830
		private void OnOfflineArenaPointRewardCloseButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnOfflineArenaPointRewardCloseButtonClick_hotfix != null)
			{
				this.m_OnOfflineArenaPointRewardCloseButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_offineArenaPointRewardUIStateCtrl, "Close", null, true, true);
		}

		// Token: 0x06009C4C RID: 40012 RVA: 0x002C86A4 File Offset: 0x002C68A4
		private void OnOfflineVictoryPointsRewardButtonClick(GainRewardButton b)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnOfflineVictoryPointsRewardButtonClickGainRewardButton_hotfix != null)
			{
				this.m_OnOfflineVictoryPointsRewardButtonClickGainRewardButton_hotfix.call(new object[]
				{
					this,
					b
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (b.GetStatus() == GainRewardStatus.CanNotGet)
			{
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				ConfigDataArenaVictoryPointsRewardInfo configDataArenaVictoryPointsRewardInfo = configDataLoader.GetConfigDataArenaVictoryPointsRewardInfo(b.GetId());
				if (configDataArenaVictoryPointsRewardInfo != null)
				{
					this.AddRewardPreviewGoods(configDataArenaVictoryPointsRewardInfo.Reward);
					UIUtility.SetUIStateOpen(this.m_rewardPreviewUIStateController, "PanelOpen", null, false, true);
				}
				return;
			}
			if (this.EventOnGainOfflineVictoryPointsReward != null)
			{
				this.EventOnGainOfflineVictoryPointsReward(b.GetId());
			}
		}

		// Token: 0x06009C4D RID: 40013 RVA: 0x002C8780 File Offset: 0x002C6980
		private void OnOfflineArenaOpponentAttackButtonClick(ArenaOpponentListItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnOfflineArenaOpponentAttackButtonClickArenaOpponentListItemUIController_hotfix != null)
			{
				this.m_OnOfflineArenaOpponentAttackButtonClickArenaOpponentListItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowOfflineArenaOpponent != null)
			{
				this.EventOnShowOfflineArenaOpponent(ctrl.GetIndex());
			}
		}

		// Token: 0x06009C4E RID: 40014 RVA: 0x002C880C File Offset: 0x002C6A0C
		private void OnOfflineBattleReportRevengeButtonClick(OfflineArenaBattleReportListItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnOfflineBattleReportRevengeButtonClickOfflineArenaBattleReportListItemUIController_hotfix != null)
			{
				this.m_OnOfflineBattleReportRevengeButtonClickOfflineArenaBattleReportListItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowRevengeOfflineArenaOpponent != null)
			{
				this.EventOnShowRevengeOfflineArenaOpponent(ctrl.GetArenaBattleReport());
			}
		}

		// Token: 0x06009C4F RID: 40015 RVA: 0x002C8898 File Offset: 0x002C6A98
		private void OnOfflineBattleReportReplayButtonClick(OfflineArenaBattleReportListItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnOfflineBattleReportReplayButtonClickOfflineArenaBattleReportListItemUIController_hotfix != null)
			{
				this.m_OnOfflineBattleReportReplayButtonClickOfflineArenaBattleReportListItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnOfflineBattleReportReplay != null)
			{
				this.EventOnOfflineBattleReportReplay(ctrl.GetArenaBattleReport());
			}
		}

		// Token: 0x06009C50 RID: 40016 RVA: 0x002C8924 File Offset: 0x002C6B24
		private void OnDefendButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDefendButtonClick_hotfix != null)
			{
				this.m_OnDefendButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnDefend != null)
			{
				this.EventOnDefend();
			}
		}

		// Token: 0x06009C51 RID: 40017 RVA: 0x002C899C File Offset: 0x002C6B9C
		private void OnAttackConfirmButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAttackConfirmButtonClick_hotfix != null)
			{
				this.m_OnAttackConfirmButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isRevengeOpponent)
			{
				if (this.EventOnRevengeOfflineArenaOpponent != null)
				{
					this.EventOnRevengeOfflineArenaOpponent(false);
				}
			}
			else if (this.EventOnAttackOfflineArenaOpponent != null)
			{
				this.EventOnAttackOfflineArenaOpponent(false);
			}
		}

		// Token: 0x06009C52 RID: 40018 RVA: 0x002C8A3C File Offset: 0x002C6C3C
		private void OnAutoBattleButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAutoBattleButtonClick_hotfix != null)
			{
				this.m_OnAutoBattleButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (ArenaUIController.s_isShowAutoBattleTips)
			{
				this.HideArenaOpponent();
				this.ShowAutoBattleTips();
			}
			else if (this.m_isRevengeOpponent)
			{
				if (this.EventOnRevengeOfflineArenaOpponent != null)
				{
					this.EventOnRevengeOfflineArenaOpponent(true);
				}
			}
			else if (this.EventOnAttackOfflineArenaOpponent != null)
			{
				this.EventOnAttackOfflineArenaOpponent(true);
			}
		}

		// Token: 0x06009C53 RID: 40019 RVA: 0x002C8AF8 File Offset: 0x002C6CF8
		private void OnAttackBackgroundButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAttackBackgroundButtonClick_hotfix != null)
			{
				this.m_OnAttackBackgroundButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideArenaOpponent();
		}

		// Token: 0x06009C54 RID: 40020 RVA: 0x002C8B60 File Offset: 0x002C6D60
		private void OnAutoBattleTipsConfirmButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAutoBattleTipsConfirmButtonClick_hotfix != null)
			{
				this.m_OnAutoBattleTipsConfirmButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_autoBattleTipsShowToggle.isOn)
			{
				ArenaUIController.s_isShowAutoBattleTips = false;
			}
			if (this.m_isRevengeOpponent)
			{
				if (this.EventOnRevengeOfflineArenaOpponent != null)
				{
					this.EventOnRevengeOfflineArenaOpponent(true);
				}
			}
			else if (this.EventOnAttackOfflineArenaOpponent != null)
			{
				this.EventOnAttackOfflineArenaOpponent(true);
			}
		}

		// Token: 0x06009C55 RID: 40021 RVA: 0x002C8C14 File Offset: 0x002C6E14
		private void OnAutoBattleTipsCancelButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAutoBattleTipsCancelButtonClick_hotfix != null)
			{
				this.m_OnAutoBattleTipsCancelButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_autoBattleTipsShowToggle.isOn)
			{
				ArenaUIController.s_isShowAutoBattleTips = false;
			}
			this.HideAutoBattleTips();
		}

		// Token: 0x140001CB RID: 459
		// (add) Token: 0x06009C56 RID: 40022 RVA: 0x002C8C90 File Offset: 0x002C6E90
		// (remove) Token: 0x06009C57 RID: 40023 RVA: 0x002C8D2C File Offset: 0x002C6F2C
		public event Action<OfflineArenaPanelType> EventOnShowOfflinePanel
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowOfflinePanelAction`1_hotfix != null)
				{
					this.m_add_EventOnShowOfflinePanelAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<OfflineArenaPanelType> action = this.EventOnShowOfflinePanel;
				Action<OfflineArenaPanelType> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<OfflineArenaPanelType>>(ref this.EventOnShowOfflinePanel, (Action<OfflineArenaPanelType>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowOfflinePanelAction`1_hotfix != null)
				{
					this.m_remove_EventOnShowOfflinePanelAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<OfflineArenaPanelType> action = this.EventOnShowOfflinePanel;
				Action<OfflineArenaPanelType> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<OfflineArenaPanelType>>(ref this.EventOnShowOfflinePanel, (Action<OfflineArenaPanelType>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001CC RID: 460
		// (add) Token: 0x06009C58 RID: 40024 RVA: 0x002C8DC8 File Offset: 0x002C6FC8
		// (remove) Token: 0x06009C59 RID: 40025 RVA: 0x002C8E64 File Offset: 0x002C7064
		public event Action<int> EventOnGainOfflineVictoryPointsReward
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGainOfflineVictoryPointsRewardAction`1_hotfix != null)
				{
					this.m_add_EventOnGainOfflineVictoryPointsRewardAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnGainOfflineVictoryPointsReward;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnGainOfflineVictoryPointsReward, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGainOfflineVictoryPointsRewardAction`1_hotfix != null)
				{
					this.m_remove_EventOnGainOfflineVictoryPointsRewardAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnGainOfflineVictoryPointsReward;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnGainOfflineVictoryPointsReward, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001CD RID: 461
		// (add) Token: 0x06009C5A RID: 40026 RVA: 0x002C8F00 File Offset: 0x002C7100
		// (remove) Token: 0x06009C5B RID: 40027 RVA: 0x002C8F9C File Offset: 0x002C719C
		public event Action<int> EventOnShowOfflineArenaOpponent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowOfflineArenaOpponentAction`1_hotfix != null)
				{
					this.m_add_EventOnShowOfflineArenaOpponentAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnShowOfflineArenaOpponent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnShowOfflineArenaOpponent, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowOfflineArenaOpponentAction`1_hotfix != null)
				{
					this.m_remove_EventOnShowOfflineArenaOpponentAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnShowOfflineArenaOpponent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnShowOfflineArenaOpponent, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001CE RID: 462
		// (add) Token: 0x06009C5C RID: 40028 RVA: 0x002C9038 File Offset: 0x002C7238
		// (remove) Token: 0x06009C5D RID: 40029 RVA: 0x002C90D4 File Offset: 0x002C72D4
		public event Action<bool> EventOnAttackOfflineArenaOpponent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAttackOfflineArenaOpponentAction`1_hotfix != null)
				{
					this.m_add_EventOnAttackOfflineArenaOpponentAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnAttackOfflineArenaOpponent;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnAttackOfflineArenaOpponent, (Action<bool>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAttackOfflineArenaOpponentAction`1_hotfix != null)
				{
					this.m_remove_EventOnAttackOfflineArenaOpponentAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnAttackOfflineArenaOpponent;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnAttackOfflineArenaOpponent, (Action<bool>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001CF RID: 463
		// (add) Token: 0x06009C5E RID: 40030 RVA: 0x002C9170 File Offset: 0x002C7370
		// (remove) Token: 0x06009C5F RID: 40031 RVA: 0x002C920C File Offset: 0x002C740C
		public event Action<ArenaBattleReport> EventOnShowRevengeOfflineArenaOpponent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowRevengeOfflineArenaOpponentAction`1_hotfix != null)
				{
					this.m_add_EventOnShowRevengeOfflineArenaOpponentAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ArenaBattleReport> action = this.EventOnShowRevengeOfflineArenaOpponent;
				Action<ArenaBattleReport> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ArenaBattleReport>>(ref this.EventOnShowRevengeOfflineArenaOpponent, (Action<ArenaBattleReport>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowRevengeOfflineArenaOpponentAction`1_hotfix != null)
				{
					this.m_remove_EventOnShowRevengeOfflineArenaOpponentAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ArenaBattleReport> action = this.EventOnShowRevengeOfflineArenaOpponent;
				Action<ArenaBattleReport> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ArenaBattleReport>>(ref this.EventOnShowRevengeOfflineArenaOpponent, (Action<ArenaBattleReport>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001D0 RID: 464
		// (add) Token: 0x06009C60 RID: 40032 RVA: 0x002C92A8 File Offset: 0x002C74A8
		// (remove) Token: 0x06009C61 RID: 40033 RVA: 0x002C9344 File Offset: 0x002C7544
		public event Action<bool> EventOnRevengeOfflineArenaOpponent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnRevengeOfflineArenaOpponentAction`1_hotfix != null)
				{
					this.m_add_EventOnRevengeOfflineArenaOpponentAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnRevengeOfflineArenaOpponent;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnRevengeOfflineArenaOpponent, (Action<bool>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnRevengeOfflineArenaOpponentAction`1_hotfix != null)
				{
					this.m_remove_EventOnRevengeOfflineArenaOpponentAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnRevengeOfflineArenaOpponent;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnRevengeOfflineArenaOpponent, (Action<bool>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001D1 RID: 465
		// (add) Token: 0x06009C62 RID: 40034 RVA: 0x002C93E0 File Offset: 0x002C75E0
		// (remove) Token: 0x06009C63 RID: 40035 RVA: 0x002C947C File Offset: 0x002C767C
		public event Action<ArenaBattleReport> EventOnOfflineBattleReportReplay
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnOfflineBattleReportReplayAction`1_hotfix != null)
				{
					this.m_add_EventOnOfflineBattleReportReplayAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ArenaBattleReport> action = this.EventOnOfflineBattleReportReplay;
				Action<ArenaBattleReport> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ArenaBattleReport>>(ref this.EventOnOfflineBattleReportReplay, (Action<ArenaBattleReport>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnOfflineBattleReportReplayAction`1_hotfix != null)
				{
					this.m_remove_EventOnOfflineBattleReportReplayAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ArenaBattleReport> action = this.EventOnOfflineBattleReportReplay;
				Action<ArenaBattleReport> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ArenaBattleReport>>(ref this.EventOnOfflineBattleReportReplay, (Action<ArenaBattleReport>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x06009C64 RID: 40036 RVA: 0x002C9518 File Offset: 0x002C7718
		private void OnlineOnBindFiledsCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnlineOnBindFiledsCompleted_hotfix != null)
			{
				this.m_OnlineOnBindFiledsCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_onlineArenaLevelPool = new GameObjectPool<ArenaLevelListItemUIController>();
			this.m_onlineArenaLevelPool.Setup(this.m_arenaLevelListItemPrefab, this.m_onlineArenaLevelScrollRect.content.gameObject);
			this.m_onlineArenaRankingPool = new GameObjectPool<ArenaRankingListItemUIController>();
			this.m_onlineArenaRankingPool.Setup(this.m_arenaRankingListItemPrefab, this.m_onlineRankingScrollRect.content.gameObject);
			this.m_onlineArenaBattleReportPool = new GameObjectPool<OnlineArenaBattleReportListItemUIController>();
			this.m_onlineArenaBattleReportPool.Setup(this.m_onlineArenaBattleReportListItemPrefab, this.m_onlineBattleReportScrollRect.content.gameObject);
			this.m_onlineArenaRankingRewardPool = new GameObjectPool<ArenaRankingRewardListItemUIController>();
			this.m_onlineArenaRankingRewardPool.Setup(this.m_arenaPointRewardListItemPrefab, this.m_onlineArenaRankingRewardscrollRect.content.gameObject);
			this.m_onlineClashToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnOnlineClashToggle));
			this.m_onlineBattleReportToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnOnlineBattleReportToggle));
			this.m_onlineDanToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnOnlineDanToggle));
			this.m_onlineLocalRankingToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnOnlineLocalRankingToggle));
			this.m_onlineGlobalRankingToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnOnlineGlobalRankingToggle));
			this.m_onlineWeekWinRewardButtons = new GainRewardButton[3];
			this.m_onlineWeekWinRewardButtons[0] = GameObjectUtility.AddControllerToGameObject<GainRewardButton>(this.m_onlineWeekWinRewardButton1GameObject);
			this.m_onlineWeekWinRewardButtons[0].SetId(1);
			this.m_onlineWeekWinRewardButtons[0].EventOnClick += this.OnOnlineWeekWinRewardButtonClick;
			this.m_onlineWeekWinRewardButtons[1] = GameObjectUtility.AddControllerToGameObject<GainRewardButton>(this.m_onlineWeekWinRewardButton2GameObject);
			this.m_onlineWeekWinRewardButtons[1].SetId(2);
			this.m_onlineWeekWinRewardButtons[1].EventOnClick += this.OnOnlineWeekWinRewardButtonClick;
			this.m_onlineWeekWinRewardButtons[2] = GameObjectUtility.AddControllerToGameObject<GainRewardButton>(this.m_onlineWeekWinRewardButton3GameObject);
			this.m_onlineWeekWinRewardButtons[2].SetId(3);
			this.m_onlineWeekWinRewardButtons[2].EventOnClick += this.OnOnlineWeekWinRewardButtonClick;
			this.m_onlineClashLadderChallengeButton.onClick.AddListener(new UnityAction(this.OnOnlineClashLadderChallengeButtonClick));
			this.m_onlineClashCasualChallengeButton.onClick.AddListener(new UnityAction(this.OnOnlineClashCasualChallengeButtonClick));
			this.m_matchingNowCancelButton.onClick.AddListener(new UnityAction(this.OnMatchingNowCancelButtonClick));
			this.m_matchingFailedBGButton.onClick.AddListener(new UnityAction(this.OnMatchingFailedConfirmButtonClick));
			this.m_matchingFailedConfirmButton.onClick.AddListener(new UnityAction(this.OnMatchingFailedConfirmButtonClick));
			this.m_promoteBattleBGButton.onClick.AddListener(new UnityAction(this.OnPromoteBattleConfirmButtonClick));
			this.m_promoteBattleConfirmButton.onClick.AddListener(new UnityAction(this.OnPromoteBattleConfirmButtonClick));
			this.m_promoteSucceedBGButton.onClick.AddListener(new UnityAction(this.OnPromoteSucceedConfirmButtonClick));
			this.m_promoteSucceedConfirmButton.onClick.AddListener(new UnityAction(this.OnPromoteSucceedConfirmButtonClick));
			this.m_onlineArenaRankingRewardButton.onClick.AddListener(new UnityAction(this.OnOnlineArenaRankingRewardButtonClick));
			this.m_onlineArenaRankingRewardBGButton.onClick.AddListener(new UnityAction(this.OnOnlineArenaRankingRewardCloseButtonClick));
			this.m_onlineArenaRankingRewardCloseButton.onClick.AddListener(new UnityAction(this.OnOnlineArenaRankingRewardCloseButtonClick));
		}

		// Token: 0x06009C65 RID: 40037 RVA: 0x002C98C0 File Offset: 0x002C7AC0
		public void SetOnlineScoreAndDan(int score, int danId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetOnlineScoreAndDanInt32Int32_hotfix != null)
			{
				this.m_SetOnlineScoreAndDanInt32Int32_hotfix.call(new object[]
				{
					this,
					score,
					danId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Text onlineArenaPointsText = this.m_onlineArenaPointsText;
			string text = score.ToString();
			this.m_onlineRankingArenaPointsText.text = text;
			onlineArenaPointsText.text = text;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataRealTimePVPDanInfo configDataRealTimePVPDanInfo = configDataLoader.GetConfigDataRealTimePVPDanInfo(danId);
			if (configDataRealTimePVPDanInfo != null)
			{
				this.m_onlineDanText.text = configDataRealTimePVPDanInfo.Name;
				Image onlineDanIconImage = this.m_onlineDanIconImage;
				Sprite sprite = AssetUtility.Instance.GetSprite(configDataRealTimePVPDanInfo.Icon);
				this.m_onlineClashDanIconImage.sprite = sprite;
				onlineDanIconImage.sprite = sprite;
				int num = 0;
				int num2 = 0;
				ConfigDataRealTimePVPDanInfo configDataRealTimePVPDanInfo2 = configDataLoader.GetConfigDataRealTimePVPDanInfo(danId + 1);
				if (configDataRealTimePVPDanInfo2 != null)
				{
					num = configDataRealTimePVPDanInfo.RelegationScore;
					num2 = configDataRealTimePVPDanInfo2.RelegationScore;
				}
				else
				{
					ConfigDataRealTimePVPDanInfo configDataRealTimePVPDanInfo3 = configDataLoader.GetConfigDataRealTimePVPDanInfo(danId - 1);
					if (configDataRealTimePVPDanInfo3 != null)
					{
						num = configDataRealTimePVPDanInfo3.RelegationScore;
						num2 = configDataRealTimePVPDanInfo.RelegationScore;
					}
				}
				this.m_onlineArenaPointsUpText1.text = num.ToString();
				this.m_onlineArenaPointsUpText2.text = num2.ToString();
				this.m_onlineArenaPointsUpBarImage.fillAmount = (float)(score - num) / (float)(num2 - num);
			}
		}

		// Token: 0x06009C66 RID: 40038 RVA: 0x002C9A58 File Offset: 0x002C7C58
		public void SetLadderMode(bool isOpened, bool isPromote)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLadderModeBooleanBoolean_hotfix != null)
			{
				this.m_SetLadderModeBooleanBoolean_hotfix.call(new object[]
				{
					this,
					isOpened,
					isPromote
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_onlineClashLadderChallengeButtonUIStateController.SetToUIState((!isOpened) ? "Grey" : "Normal", false, false);
			this.m_onlineClashLadderOpenTimeGameObject.SetActive(!isOpened);
			this.m_onlineClashLadderModeUIStateController.SetToUIState((!isPromote || !isOpened) ? "Normal" : "Promote", false, false);
		}

		// Token: 0x06009C67 RID: 40039 RVA: 0x002C9B34 File Offset: 0x002C7D34
		public void SetLadderOpenTime(string openTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLadderOpenTimeString_hotfix != null)
			{
				this.m_SetLadderOpenTimeString_hotfix.call(new object[]
				{
					this,
					openTime
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string text = string.Empty;
			string[] array = openTime.Split(new char[]
			{
				'/'
			});
			foreach (string text2 in array)
			{
				string[] array3 = text2.Split(new char[]
				{
					'-'
				});
				if (array3.Length > 1)
				{
					text = text + array3[0] + " - " + array3[1];
				}
				text += '\n';
			}
			this.m_onlineClashLadderOpenTimeText.text = text;
		}

		// Token: 0x06009C68 RID: 40040 RVA: 0x002C9C28 File Offset: 0x002C7E28
		public void SetLadderWeekWin(int wins, int matches)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLadderWeekWinInt32Int32_hotfix != null)
			{
				this.m_SetLadderWeekWinInt32Int32_hotfix.call(new object[]
				{
					this,
					wins,
					matches
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			if (wins > 0 && matches > 0)
			{
				num = Mathf.RoundToInt((float)wins * 100f / (float)matches);
			}
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			string format = string.Empty;
			if (num < 31)
			{
				format = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Arena_WinRate0);
			}
			else if (num < 71)
			{
				format = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Arena_WinRate1);
			}
			else
			{
				format = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Arena_WinRate2);
			}
			this.m_onlineClashWinRateText.text = string.Format(format, num);
			this.m_onlineClashWinCountText.text = wins.ToString();
			this.m_onlineClashLoseCountText.text = (matches - wins).ToString();
			this.m_onlineClashTotalCountText.text = matches.ToString();
		}

		// Token: 0x06009C69 RID: 40041 RVA: 0x002C9D80 File Offset: 0x002C7F80
		public void SetOnlineWeekWinRewardStatus(int idx, int num, GainRewardStatus status)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetOnlineWeekWinRewardStatusInt32Int32GainRewardStatus_hotfix != null)
			{
				this.m_SetOnlineWeekWinRewardStatusInt32Int32GainRewardStatus_hotfix.call(new object[]
				{
					this,
					idx,
					num,
					status
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (idx < 0 || idx >= this.m_onlineWeekWinRewardButtons.Length)
			{
				return;
			}
			this.m_onlineWeekWinRewardButtons[idx].SetNum(num);
			this.m_onlineWeekWinRewardButtons[idx].SetStatus(status);
		}

		// Token: 0x06009C6A RID: 40042 RVA: 0x002C9E44 File Offset: 0x002C8044
		public void SetOnlineWeekWinRewardProgress(int wins, int countMax)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetOnlineWeekWinRewardProgressInt32Int32_hotfix != null)
			{
				this.m_SetOnlineWeekWinRewardProgressInt32Int32_hotfix.call(new object[]
				{
					this,
					wins,
					countMax
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_onlineWeekWinText.text = wins.ToString();
			if (wins > 0 && countMax > 0)
			{
				float num = 1f / (float)this.m_onlineWeekWinRewardButtons.Length;
				float num2 = 0f;
				for (int i = 0; i < this.m_onlineWeekWinRewardButtons.Length; i++)
				{
					if (this.m_onlineWeekWinRewardButtons[i].GetNum() >= wins)
					{
						int num3 = 0;
						if (i > 0)
						{
							num3 = this.m_onlineWeekWinRewardButtons[i - 1].GetNum();
						}
						int num4 = this.m_onlineWeekWinRewardButtons[i].GetNum();
						num2 += num * (float)(wins - num3) / (float)(num4 - num3);
						break;
					}
					num2 += num;
				}
				this.m_onlineWeekWinRewardImage.fillAmount = num2;
			}
			else
			{
				this.m_onlineWeekWinRewardImage.fillAmount = 0f;
			}
		}

		// Token: 0x06009C6B RID: 40043 RVA: 0x002C9F90 File Offset: 0x002C8190
		public void ShowPromoteBattle(int danId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowPromoteBattleInt32_hotfix != null)
			{
				this.m_ShowPromoteBattleInt32_hotfix.call(new object[]
				{
					this,
					danId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataRealTimePVPDanInfo configDataRealTimePVPDanInfo = configDataLoader.GetConfigDataRealTimePVPDanInfo(danId);
			if (configDataRealTimePVPDanInfo != null)
			{
				this.m_promoteBattleText.text = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Arena_PromoteBattleTips), configDataRealTimePVPDanInfo.PromotionScore);
				UIUtility.SetUIStateOpen(this.m_promoteBattleUIStateController, "Open", null, false, true);
			}
		}

		// Token: 0x06009C6C RID: 40044 RVA: 0x002CA058 File Offset: 0x002C8258
		public void ShowPromoteSucceed(int danId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowPromoteSucceedInt32_hotfix != null)
			{
				this.m_ShowPromoteSucceedInt32_hotfix.call(new object[]
				{
					this,
					danId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataRealTimePVPDanInfo configDataRealTimePVPDanInfo = configDataLoader.GetConfigDataRealTimePVPDanInfo(danId);
			if (configDataRealTimePVPDanInfo != null)
			{
				string format = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Arena_PromoteSucceed);
				this.m_promoteSucceedDanText.text = string.Format(format, configDataRealTimePVPDanInfo.Name);
				this.m_promoteSucceedDanImage.sprite = AssetUtility.Instance.GetSprite(configDataRealTimePVPDanInfo.Icon);
				UIUtility.SetUIStateOpen(this.m_promoteSucceedUIStateController, "Show", null, false, true);
			}
		}

		// Token: 0x06009C6D RID: 40045 RVA: 0x002CA138 File Offset: 0x002C8338
		public void SetPromoteBattleStatus(int danId, List<RealTimePVPBattleReport> promoteBattleReports)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPromoteBattleStatusInt32List`1_hotfix != null)
			{
				this.m_SetPromoteBattleStatusInt32List`1_hotfix.call(new object[]
				{
					this,
					danId,
					promoteBattleReports
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataRealTimePVPDanInfo configDataRealTimePVPDanInfo = configDataLoader.GetConfigDataRealTimePVPDanInfo(danId);
			if (configDataRealTimePVPDanInfo == null)
			{
				return;
			}
			this.m_onlineClashPromoteDanIconImage.sprite = AssetUtility.Instance.GetSprite(configDataRealTimePVPDanInfo.Icon);
			ConfigDataRealTimePVPDanInfo configDataRealTimePVPDanInfo2 = configDataLoader.GetConfigDataRealTimePVPDanInfo(danId + 1);
			if (configDataRealTimePVPDanInfo2 != null)
			{
				this.m_onlineClashPromoteNextDanIconImage.sprite = AssetUtility.Instance.GetSprite(configDataRealTimePVPDanInfo2.Icon);
			}
			this.m_onlineClashPromoteCountImage.sprite = AssetUtility.Instance.GetSprite(UIAsset.GoldNumbers[configDataRealTimePVPDanInfo.PromotionChallengeWinsRequired]);
			for (int i = 0; i < this.m_onlineClashPromoteRoundGroupGameObject.transform.childCount; i++)
			{
				GameObject gameObject = this.m_onlineClashPromoteRoundGroupGameObject.transform.GetChild(i).gameObject;
				if (i < configDataRealTimePVPDanInfo.PromotionChallengeCount)
				{
					gameObject.SetActive(true);
					CommonUIStateController component = gameObject.GetComponent<CommonUIStateController>();
					if (promoteBattleReports.Count > i)
					{
						component.SetToUIState((!promoteBattleReports[i].Win) ? "Failed" : "Succeed", false, true);
					}
					else
					{
						component.SetToUIState("Empty", false, true);
					}
				}
				else
				{
					gameObject.SetActive(false);
				}
			}
		}

		// Token: 0x06009C6E RID: 40046 RVA: 0x002CA2EC File Offset: 0x002C84EC
		public void SetOnlineDans(List<ConfigDataRealTimePVPDanInfo> danInfos, int danId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetOnlineDansList`1Int32_hotfix != null)
			{
				this.m_SetOnlineDansList`1Int32_hotfix.call(new object[]
				{
					this,
					danInfos,
					danId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("RewardGoods");
			this.m_onlineArenaLevelPool.Deactive();
			foreach (ConfigDataRealTimePVPDanInfo danInfo in danInfos)
			{
				ArenaLevelListItemUIController arenaLevelListItemUIController = this.m_onlineArenaLevelPool.Allocate();
				if (arenaLevelListItemUIController != null)
				{
					arenaLevelListItemUIController.SetDanInfo(danInfo, assetInContainer, danId);
				}
			}
		}

		// Token: 0x06009C6F RID: 40047 RVA: 0x002CA3E8 File Offset: 0x002C85E8
		public void SetOnlineArenaBattleReports(List<RealTimePVPBattleReport> battleReports)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetOnlineArenaBattleReportsList`1_hotfix != null)
			{
				this.m_SetOnlineArenaBattleReportsList`1_hotfix.call(new object[]
				{
					this,
					battleReports
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_onlineArenaBattleReportPool.Deactive();
			if (battleReports == null)
			{
				return;
			}
			foreach (RealTimePVPBattleReport realTimePVPBattleReport in battleReports)
			{
				bool flag;
				OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = this.m_onlineArenaBattleReportPool.Allocate(out flag);
				if (onlineArenaBattleReportListItemUIController != null)
				{
					if (flag)
					{
						onlineArenaBattleReportListItemUIController.EventOnReplayButtonClick += this.OnOnlineBattleReportReplayButtonClick;
					}
					onlineArenaBattleReportListItemUIController.SetRealTimePVPBattleReport(realTimePVPBattleReport);
				}
			}
			this.m_onlineNoBattleReportGameObject.SetActive(battleReports.Count <= 0);
			this.m_onlineBattleReportScrollRect.normalizedPosition = Vector2.one;
		}

		// Token: 0x06009C70 RID: 40048 RVA: 0x002CA510 File Offset: 0x002C8710
		public void SetOnlineArenaRankings(int mineRank, List<ProRealTimePVPLeaderboardPlayerInfo> playerInfos, List<ProUserSummary> userSummarys, bool isGlobal)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetOnlineArenaRankingsInt32List`1List`1Boolean_hotfix != null)
			{
				this.m_SetOnlineArenaRankingsInt32List`1List`1Boolean_hotfix.call(new object[]
				{
					this,
					mineRank,
					playerInfos,
					userSummarys,
					isGlobal
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			mineRank++;
			string leaderboardRankingImageName = UIUtility.GetLeaderboardRankingImageName(mineRank);
			if (!string.IsNullOrEmpty(leaderboardRankingImageName))
			{
				this.m_onlineRankingPlayerRankingUIStateController.SetToUIState("TopThree", false, true);
				this.m_onlineRankingPlayerRankingImage.sprite = AssetUtility.Instance.GetSprite(leaderboardRankingImageName);
			}
			else
			{
				this.m_onlineRankingPlayerRankingUIStateController.SetToUIState("Normal", false, true);
				this.m_onlineRankingPlayerRankingText.text = mineRank.ToString();
				if (mineRank > 0)
				{
					this.m_onlineRankingPlayerRankingText.text = mineRank.ToString();
				}
				else
				{
					IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
					this.m_onlineRankingPlayerRankingText.text = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Arena_NoRanking);
				}
			}
			this.m_onlineArenaRankingPool.Deactive();
			for (int i = 0; i < playerInfos.Count; i++)
			{
				ArenaRankingListItemUIController arenaRankingListItemUIController = this.m_onlineArenaRankingPool.Allocate();
				if (arenaRankingListItemUIController != null)
				{
					int num = (!isGlobal) ? playerInfos[i].LocalRank : playerInfos[i].GlobalRank;
					arenaRankingListItemUIController.SetRanking(num + 1);
					arenaRankingListItemUIController.SetIndex(i);
					arenaRankingListItemUIController.SetPlayer(playerInfos[i], userSummarys[i]);
				}
			}
			this.m_onlineRankingScrollRect.normalizedPosition = Vector2.one;
		}

		// Token: 0x06009C71 RID: 40049 RVA: 0x002CA700 File Offset: 0x002C8900
		public void ShowGlobalRankingToggle(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowGlobalRankingToggleBoolean_hotfix != null)
			{
				this.m_ShowGlobalRankingToggleBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_onlineGlobalRankingToggle.gameObject.SetActive(show);
		}

		// Token: 0x06009C72 RID: 40050 RVA: 0x002CA784 File Offset: 0x002C8984
		public void ShowOnlinePanel(OnlineArenaPanelType panelType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowOnlinePanelOnlineArenaPanelType_hotfix != null)
			{
				this.m_ShowOnlinePanelOnlineArenaPanelType_hotfix.call(new object[]
				{
					this,
					panelType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_onlineClashPanelGameObject.SetActive(panelType == OnlineArenaPanelType.Clash);
			this.m_onlineBattleReportPanelGameObject.SetActive(panelType == OnlineArenaPanelType.BattleReport);
			this.m_onlineDanPanelGameObject.SetActive(panelType == OnlineArenaPanelType.Dan);
			this.m_onlineRankingPanelGameObject.SetActive(panelType == OnlineArenaPanelType.LocalRanking || panelType == OnlineArenaPanelType.GlobalRanking);
			this.m_isIgnoreToggleEvent = true;
			this.m_onlineClashToggle.isOn = (panelType == OnlineArenaPanelType.Clash);
			this.m_onlineBattleReportToggle.isOn = (panelType == OnlineArenaPanelType.BattleReport);
			this.m_onlineDanToggle.isOn = (panelType == OnlineArenaPanelType.Dan);
			this.m_onlineLocalRankingToggle.isOn = (panelType == OnlineArenaPanelType.LocalRanking);
			this.m_onlineGlobalRankingToggle.isOn = (panelType == OnlineArenaPanelType.GlobalRanking);
			this.m_isIgnoreToggleEvent = false;
		}

		// Token: 0x06009C73 RID: 40051 RVA: 0x002CA894 File Offset: 0x002C8A94
		public void ShowMatchingNow()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowMatchingNow_hotfix != null)
			{
				this.m_ShowMatchingNow_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isMatchingNow)
			{
				return;
			}
			UIUtility.SetUIStateOpen(this.m_matchingNowUIStateController, "Show", null, false, true);
			this.m_isMatchingNow = true;
		}

		// Token: 0x06009C74 RID: 40052 RVA: 0x002CA91C File Offset: 0x002C8B1C
		public void HideMatchingNow()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideMatchingNow_hotfix != null)
			{
				this.m_HideMatchingNow_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_isMatchingNow)
			{
				return;
			}
			UIUtility.SetUIStateClose(this.m_matchingNowUIStateController, "Close", null, false, true);
			this.m_isMatchingNow = false;
		}

		// Token: 0x06009C75 RID: 40053 RVA: 0x002CA9A4 File Offset: 0x002C8BA4
		public void SetMatchingNowTime(TimeSpan ts)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetMatchingNowTimeTimeSpan_hotfix != null)
			{
				this.m_SetMatchingNowTimeTimeSpan_hotfix.call(new object[]
				{
					this,
					ts
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_matchingNowTimeText.text = string.Format("{0:d2}:{1:d2}", ts.Minutes, ts.Seconds);
		}

		// Token: 0x06009C76 RID: 40054 RVA: 0x002CAA44 File Offset: 0x002C8C44
		public void SetMatchingPredictTime(TimeSpan ts)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetMatchingPredictTimeTimeSpan_hotfix != null)
			{
				this.m_SetMatchingPredictTimeTimeSpan_hotfix.call(new object[]
				{
					this,
					ts
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (ts == TimeSpan.MinValue)
			{
				this.m_matchingNowPredictTimeGameObject.SetActive(false);
			}
			else
			{
				this.m_matchingNowPredictTimeGameObject.SetActive(true);
				this.m_matchingNowPredictTimeText.text = string.Format("{0:d2}:{1:d2}", ts.Minutes, ts.Seconds);
			}
		}

		// Token: 0x06009C77 RID: 40055 RVA: 0x002CAB10 File Offset: 0x002C8D10
		public bool IsMatchingNowPredictTimeActive()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsMatchingNowPredictTimeActive_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsMatchingNowPredictTimeActive_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_matchingNowPredictTimeGameObject.activeSelf;
		}

		// Token: 0x06009C78 RID: 40056 RVA: 0x002CAB88 File Offset: 0x002C8D88
		public void ShowMatchingFailed()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowMatchingFailed_hotfix != null)
			{
				this.m_ShowMatchingFailed_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_matchingFailedUIStateController, "Open", null, false, true);
		}

		// Token: 0x06009C79 RID: 40057 RVA: 0x002CABFC File Offset: 0x002C8DFC
		private void OnOnlineClashToggle(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnOnlineClashToggleBoolean_hotfix != null)
			{
				this.m_OnOnlineClashToggleBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (on && this.EventOnShowOnlinePanel != null)
			{
				this.EventOnShowOnlinePanel(OnlineArenaPanelType.Clash);
			}
		}

		// Token: 0x06009C7A RID: 40058 RVA: 0x002CAC98 File Offset: 0x002C8E98
		private void OnOnlineBattleReportToggle(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnOnlineBattleReportToggleBoolean_hotfix != null)
			{
				this.m_OnOnlineBattleReportToggleBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (on && this.EventOnShowOnlinePanel != null)
			{
				this.EventOnShowOnlinePanel(OnlineArenaPanelType.BattleReport);
			}
		}

		// Token: 0x06009C7B RID: 40059 RVA: 0x002CAD34 File Offset: 0x002C8F34
		private void OnOnlineDanToggle(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnOnlineDanToggleBoolean_hotfix != null)
			{
				this.m_OnOnlineDanToggleBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (on && this.EventOnShowOnlinePanel != null)
			{
				this.EventOnShowOnlinePanel(OnlineArenaPanelType.Dan);
			}
		}

		// Token: 0x06009C7C RID: 40060 RVA: 0x002CADD0 File Offset: 0x002C8FD0
		private void OnOnlineLocalRankingToggle(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnOnlineLocalRankingToggleBoolean_hotfix != null)
			{
				this.m_OnOnlineLocalRankingToggleBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (on && this.EventOnShowOnlinePanel != null)
			{
				this.EventOnShowOnlinePanel(OnlineArenaPanelType.LocalRanking);
			}
		}

		// Token: 0x06009C7D RID: 40061 RVA: 0x002CAE6C File Offset: 0x002C906C
		private void OnOnlineGlobalRankingToggle(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnOnlineGlobalRankingToggleBoolean_hotfix != null)
			{
				this.m_OnOnlineGlobalRankingToggleBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (on && this.EventOnShowOnlinePanel != null)
			{
				this.EventOnShowOnlinePanel(OnlineArenaPanelType.GlobalRanking);
			}
		}

		// Token: 0x06009C7E RID: 40062 RVA: 0x002CAF08 File Offset: 0x002C9108
		private void OnOnlineWeekWinRewardButtonClick(GainRewardButton b)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnOnlineWeekWinRewardButtonClickGainRewardButton_hotfix != null)
			{
				this.m_OnOnlineWeekWinRewardButtonClickGainRewardButton_hotfix.call(new object[]
				{
					this,
					b
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (b.GetStatus() == GainRewardStatus.CanNotGet)
			{
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				ConfigDataRealTimePVPWinsBonusInfo configDataRealTimePVPWinsBonusInfo = configDataLoader.GetConfigDataRealTimePVPWinsBonusInfo(b.GetId());
				if (configDataRealTimePVPWinsBonusInfo != null)
				{
					this.AddRewardPreviewGoods(configDataRealTimePVPWinsBonusInfo.Bonus);
					UIUtility.SetUIStateOpen(this.m_rewardPreviewUIStateController, "PanelOpen", null, false, true);
				}
				return;
			}
			if (this.EventOnGainOnlineWeekWinReward != null)
			{
				this.EventOnGainOnlineWeekWinReward(b.GetId());
			}
		}

		// Token: 0x06009C7F RID: 40063 RVA: 0x002CAFE4 File Offset: 0x002C91E4
		private void OnOnlineBattleReportReplayButtonClick(OnlineArenaBattleReportListItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnOnlineBattleReportReplayButtonClickOnlineArenaBattleReportListItemUIController_hotfix != null)
			{
				this.m_OnOnlineBattleReportReplayButtonClickOnlineArenaBattleReportListItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnOnlineBattleReportReplay != null)
			{
				this.EventOnOnlineBattleReportReplay(ctrl.GetRealTimePVPBattleReport());
			}
		}

		// Token: 0x06009C80 RID: 40064 RVA: 0x002CB070 File Offset: 0x002C9270
		private void OnOnlineClashLadderChallengeButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnOnlineClashLadderChallengeButtonClick_hotfix != null)
			{
				this.m_OnOnlineClashLadderChallengeButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (UIUtility.GetUIStateCurrentStateName(this.m_onlineClashLadderChallengeButtonUIStateController) == "Grey")
			{
				return;
			}
			if (this.EventOnLadderChallenge != null)
			{
				this.EventOnLadderChallenge();
			}
		}

		// Token: 0x06009C81 RID: 40065 RVA: 0x002CB104 File Offset: 0x002C9304
		private void OnOnlineClashCasualChallengeButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnOnlineClashCasualChallengeButtonClick_hotfix != null)
			{
				this.m_OnOnlineClashCasualChallengeButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnCasualChallenge != null)
			{
				this.EventOnCasualChallenge();
			}
		}

		// Token: 0x06009C82 RID: 40066 RVA: 0x002CB17C File Offset: 0x002C937C
		private void OnMatchingFailedConfirmButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMatchingFailedConfirmButtonClick_hotfix != null)
			{
				this.m_OnMatchingFailedConfirmButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_matchingFailedUIStateController, "Close", null, true, true);
		}

		// Token: 0x06009C83 RID: 40067 RVA: 0x002CB1F0 File Offset: 0x002C93F0
		private void OnMatchingNowCancelButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMatchingNowCancelButtonClick_hotfix != null)
			{
				this.m_OnMatchingNowCancelButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_isMatchingNow)
			{
				return;
			}
			if (this.EventOnMatchingCancel != null)
			{
				this.EventOnMatchingCancel();
			}
		}

		// Token: 0x06009C84 RID: 40068 RVA: 0x002CB274 File Offset: 0x002C9474
		private void OnOnlineArenaRankingRewardButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnOnlineArenaRankingRewardButtonClick_hotfix != null)
			{
				this.m_OnOnlineArenaRankingRewardButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			List<ConfigDataRealTimePVPRankingRewardInfo> list = new List<ConfigDataRealTimePVPRankingRewardInfo>();
			foreach (KeyValuePair<int, ConfigDataRealTimePVPRankingRewardInfo> keyValuePair in configDataLoader.GetAllConfigDataRealTimePVPRankingRewardInfo())
			{
				list.Add(keyValuePair.Value);
			}
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("RewardGoods");
			this.m_onlineArenaRankingRewardPool.Deactive();
			for (int i = 0; i < list.Count; i++)
			{
				ArenaRankingRewardListItemUIController arenaRankingRewardListItemUIController = this.m_onlineArenaRankingRewardPool.Allocate();
				if (arenaRankingRewardListItemUIController != null)
				{
					arenaRankingRewardListItemUIController.SetRealTimePVPRankBonusInfo(list[i], assetInContainer);
					arenaRankingRewardListItemUIController.SetIndex(i);
				}
			}
			UIUtility.SetUIStateOpen(this.m_onlineArenaRankingRewardUIStateCtrl, "Show", null, false, true);
		}

		// Token: 0x06009C85 RID: 40069 RVA: 0x002CB3B8 File Offset: 0x002C95B8
		private void OnOnlineArenaRankingRewardCloseButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnOnlineArenaRankingRewardCloseButtonClick_hotfix != null)
			{
				this.m_OnOnlineArenaRankingRewardCloseButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_onlineArenaRankingRewardUIStateCtrl, "Close", null, true, true);
		}

		// Token: 0x06009C86 RID: 40070 RVA: 0x002CB42C File Offset: 0x002C962C
		private void OnPromoteBattleConfirmButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPromoteBattleConfirmButtonClick_hotfix != null)
			{
				this.m_OnPromoteBattleConfirmButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_promoteBattleUIStateController, "Close", null, true, true);
		}

		// Token: 0x06009C87 RID: 40071 RVA: 0x002CB4A0 File Offset: 0x002C96A0
		private void OnPromoteSucceedConfirmButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPromoteSucceedConfirmButtonClick_hotfix != null)
			{
				this.m_OnPromoteSucceedConfirmButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_promoteSucceedUIStateController, "Close", null, true, true);
		}

		// Token: 0x140001D2 RID: 466
		// (add) Token: 0x06009C88 RID: 40072 RVA: 0x002CB514 File Offset: 0x002C9714
		// (remove) Token: 0x06009C89 RID: 40073 RVA: 0x002CB5B0 File Offset: 0x002C97B0
		public event Action<OnlineArenaPanelType> EventOnShowOnlinePanel
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowOnlinePanelAction`1_hotfix != null)
				{
					this.m_add_EventOnShowOnlinePanelAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<OnlineArenaPanelType> action = this.EventOnShowOnlinePanel;
				Action<OnlineArenaPanelType> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<OnlineArenaPanelType>>(ref this.EventOnShowOnlinePanel, (Action<OnlineArenaPanelType>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowOnlinePanelAction`1_hotfix != null)
				{
					this.m_remove_EventOnShowOnlinePanelAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<OnlineArenaPanelType> action = this.EventOnShowOnlinePanel;
				Action<OnlineArenaPanelType> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<OnlineArenaPanelType>>(ref this.EventOnShowOnlinePanel, (Action<OnlineArenaPanelType>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001D3 RID: 467
		// (add) Token: 0x06009C8A RID: 40074 RVA: 0x002CB64C File Offset: 0x002C984C
		// (remove) Token: 0x06009C8B RID: 40075 RVA: 0x002CB6E8 File Offset: 0x002C98E8
		public event Action<int> EventOnGainOnlineWeekWinReward
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGainOnlineWeekWinRewardAction`1_hotfix != null)
				{
					this.m_add_EventOnGainOnlineWeekWinRewardAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnGainOnlineWeekWinReward;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnGainOnlineWeekWinReward, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGainOnlineWeekWinRewardAction`1_hotfix != null)
				{
					this.m_remove_EventOnGainOnlineWeekWinRewardAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnGainOnlineWeekWinReward;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnGainOnlineWeekWinReward, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001D4 RID: 468
		// (add) Token: 0x06009C8C RID: 40076 RVA: 0x002CB784 File Offset: 0x002C9984
		// (remove) Token: 0x06009C8D RID: 40077 RVA: 0x002CB820 File Offset: 0x002C9A20
		public event Action<RealTimePVPBattleReport> EventOnOnlineBattleReportReplay
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnOnlineBattleReportReplayAction`1_hotfix != null)
				{
					this.m_add_EventOnOnlineBattleReportReplayAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<RealTimePVPBattleReport> action = this.EventOnOnlineBattleReportReplay;
				Action<RealTimePVPBattleReport> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<RealTimePVPBattleReport>>(ref this.EventOnOnlineBattleReportReplay, (Action<RealTimePVPBattleReport>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnOnlineBattleReportReplayAction`1_hotfix != null)
				{
					this.m_remove_EventOnOnlineBattleReportReplayAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<RealTimePVPBattleReport> action = this.EventOnOnlineBattleReportReplay;
				Action<RealTimePVPBattleReport> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<RealTimePVPBattleReport>>(ref this.EventOnOnlineBattleReportReplay, (Action<RealTimePVPBattleReport>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001D5 RID: 469
		// (add) Token: 0x06009C8E RID: 40078 RVA: 0x002CB8BC File Offset: 0x002C9ABC
		// (remove) Token: 0x06009C8F RID: 40079 RVA: 0x002CB958 File Offset: 0x002C9B58
		public event Action EventOnLadderChallenge
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnLadderChallengeAction_hotfix != null)
				{
					this.m_add_EventOnLadderChallengeAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnLadderChallenge;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnLadderChallenge, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnLadderChallengeAction_hotfix != null)
				{
					this.m_remove_EventOnLadderChallengeAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnLadderChallenge;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnLadderChallenge, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001D6 RID: 470
		// (add) Token: 0x06009C90 RID: 40080 RVA: 0x002CB9F4 File Offset: 0x002C9BF4
		// (remove) Token: 0x06009C91 RID: 40081 RVA: 0x002CBA90 File Offset: 0x002C9C90
		public event Action EventOnCasualChallenge
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCasualChallengeAction_hotfix != null)
				{
					this.m_add_EventOnCasualChallengeAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCasualChallenge;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCasualChallenge, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCasualChallengeAction_hotfix != null)
				{
					this.m_remove_EventOnCasualChallengeAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCasualChallenge;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCasualChallenge, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001D7 RID: 471
		// (add) Token: 0x06009C92 RID: 40082 RVA: 0x002CBB2C File Offset: 0x002C9D2C
		// (remove) Token: 0x06009C93 RID: 40083 RVA: 0x002CBBC8 File Offset: 0x002C9DC8
		public event Action EventOnMatchingCancel
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnMatchingCancelAction_hotfix != null)
				{
					this.m_add_EventOnMatchingCancelAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnMatchingCancel;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnMatchingCancel, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnMatchingCancelAction_hotfix != null)
				{
					this.m_remove_EventOnMatchingCancelAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnMatchingCancel;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnMatchingCancel, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17001FBA RID: 8122
		// (get) Token: 0x06009C94 RID: 40084 RVA: 0x002CBC64 File Offset: 0x002C9E64
		// (set) Token: 0x06009C95 RID: 40085 RVA: 0x002CBC84 File Offset: 0x002C9E84
		[DoNotToLua]
		public new ArenaUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ArenaUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06009C96 RID: 40086 RVA: 0x002CBC90 File Offset: 0x002C9E90
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06009C97 RID: 40087 RVA: 0x002CBC9C File Offset: 0x002C9E9C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06009C98 RID: 40088 RVA: 0x002CBCA4 File Offset: 0x002C9EA4
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06009C99 RID: 40089 RVA: 0x002CBCAC File Offset: 0x002C9EAC
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06009C9A RID: 40090 RVA: 0x002CBCC0 File Offset: 0x002C9EC0
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06009C9B RID: 40091 RVA: 0x002CBCC8 File Offset: 0x002C9EC8
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06009C9C RID: 40092 RVA: 0x002CBCD4 File Offset: 0x002C9ED4
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06009C9D RID: 40093 RVA: 0x002CBCE0 File Offset: 0x002C9EE0
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06009C9E RID: 40094 RVA: 0x002CBCEC File Offset: 0x002C9EEC
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06009C9F RID: 40095 RVA: 0x002CBCF8 File Offset: 0x002C9EF8
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06009CA0 RID: 40096 RVA: 0x002CBD04 File Offset: 0x002C9F04
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06009CA1 RID: 40097 RVA: 0x002CBD10 File Offset: 0x002C9F10
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06009CA2 RID: 40098 RVA: 0x002CBD1C File Offset: 0x002C9F1C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06009CA3 RID: 40099 RVA: 0x002CBD28 File Offset: 0x002C9F28
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06009CA4 RID: 40100 RVA: 0x002CBD34 File Offset: 0x002C9F34
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06009CA5 RID: 40101 RVA: 0x002CBD3C File Offset: 0x002C9F3C
		private void __callDele_EventOnDefend()
		{
			Action eventOnDefend = this.EventOnDefend;
			if (eventOnDefend != null)
			{
				eventOnDefend();
			}
		}

		// Token: 0x06009CA6 RID: 40102 RVA: 0x002CBD5C File Offset: 0x002C9F5C
		private void __clearDele_EventOnDefend()
		{
			this.EventOnDefend = null;
		}

		// Token: 0x06009CA7 RID: 40103 RVA: 0x002CBD68 File Offset: 0x002C9F68
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x06009CA8 RID: 40104 RVA: 0x002CBD88 File Offset: 0x002C9F88
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x06009CA9 RID: 40105 RVA: 0x002CBD94 File Offset: 0x002C9F94
		private void __callDele_EventOnShowHelp()
		{
			Action eventOnShowHelp = this.EventOnShowHelp;
			if (eventOnShowHelp != null)
			{
				eventOnShowHelp();
			}
		}

		// Token: 0x06009CAA RID: 40106 RVA: 0x002CBDB4 File Offset: 0x002C9FB4
		private void __clearDele_EventOnShowHelp()
		{
			this.EventOnShowHelp = null;
		}

		// Token: 0x06009CAB RID: 40107 RVA: 0x002CBDC0 File Offset: 0x002C9FC0
		private void __callDele_EventOnShowBuyArenaTicket()
		{
			Action eventOnShowBuyArenaTicket = this.EventOnShowBuyArenaTicket;
			if (eventOnShowBuyArenaTicket != null)
			{
				eventOnShowBuyArenaTicket();
			}
		}

		// Token: 0x06009CAC RID: 40108 RVA: 0x002CBDE0 File Offset: 0x002C9FE0
		private void __clearDele_EventOnShowBuyArenaTicket()
		{
			this.EventOnShowBuyArenaTicket = null;
		}

		// Token: 0x06009CAD RID: 40109 RVA: 0x002CBDEC File Offset: 0x002C9FEC
		private void __callDele_EventOnBuyArenaTicket()
		{
			Action eventOnBuyArenaTicket = this.EventOnBuyArenaTicket;
			if (eventOnBuyArenaTicket != null)
			{
				eventOnBuyArenaTicket();
			}
		}

		// Token: 0x06009CAE RID: 40110 RVA: 0x002CBE0C File Offset: 0x002CA00C
		private void __clearDele_EventOnBuyArenaTicket()
		{
			this.EventOnBuyArenaTicket = null;
		}

		// Token: 0x06009CAF RID: 40111 RVA: 0x002CBE18 File Offset: 0x002CA018
		private void __callDele_EventOnSwitchOnlineOffline()
		{
			Action eventOnSwitchOnlineOffline = this.EventOnSwitchOnlineOffline;
			if (eventOnSwitchOnlineOffline != null)
			{
				eventOnSwitchOnlineOffline();
			}
		}

		// Token: 0x06009CB0 RID: 40112 RVA: 0x002CBE38 File Offset: 0x002CA038
		private void __clearDele_EventOnSwitchOnlineOffline()
		{
			this.EventOnSwitchOnlineOffline = null;
		}

		// Token: 0x06009CB1 RID: 40113 RVA: 0x002CBE44 File Offset: 0x002CA044
		private void __callDele_EventOnShowOfflinePanel(OfflineArenaPanelType obj)
		{
			Action<OfflineArenaPanelType> eventOnShowOfflinePanel = this.EventOnShowOfflinePanel;
			if (eventOnShowOfflinePanel != null)
			{
				eventOnShowOfflinePanel(obj);
			}
		}

		// Token: 0x06009CB2 RID: 40114 RVA: 0x002CBE68 File Offset: 0x002CA068
		private void __clearDele_EventOnShowOfflinePanel(OfflineArenaPanelType obj)
		{
			this.EventOnShowOfflinePanel = null;
		}

		// Token: 0x06009CB3 RID: 40115 RVA: 0x002CBE74 File Offset: 0x002CA074
		private void __callDele_EventOnGainOfflineVictoryPointsReward(int obj)
		{
			Action<int> eventOnGainOfflineVictoryPointsReward = this.EventOnGainOfflineVictoryPointsReward;
			if (eventOnGainOfflineVictoryPointsReward != null)
			{
				eventOnGainOfflineVictoryPointsReward(obj);
			}
		}

		// Token: 0x06009CB4 RID: 40116 RVA: 0x002CBE98 File Offset: 0x002CA098
		private void __clearDele_EventOnGainOfflineVictoryPointsReward(int obj)
		{
			this.EventOnGainOfflineVictoryPointsReward = null;
		}

		// Token: 0x06009CB5 RID: 40117 RVA: 0x002CBEA4 File Offset: 0x002CA0A4
		private void __callDele_EventOnShowOfflineArenaOpponent(int obj)
		{
			Action<int> eventOnShowOfflineArenaOpponent = this.EventOnShowOfflineArenaOpponent;
			if (eventOnShowOfflineArenaOpponent != null)
			{
				eventOnShowOfflineArenaOpponent(obj);
			}
		}

		// Token: 0x06009CB6 RID: 40118 RVA: 0x002CBEC8 File Offset: 0x002CA0C8
		private void __clearDele_EventOnShowOfflineArenaOpponent(int obj)
		{
			this.EventOnShowOfflineArenaOpponent = null;
		}

		// Token: 0x06009CB7 RID: 40119 RVA: 0x002CBED4 File Offset: 0x002CA0D4
		private void __callDele_EventOnAttackOfflineArenaOpponent(bool obj)
		{
			Action<bool> eventOnAttackOfflineArenaOpponent = this.EventOnAttackOfflineArenaOpponent;
			if (eventOnAttackOfflineArenaOpponent != null)
			{
				eventOnAttackOfflineArenaOpponent(obj);
			}
		}

		// Token: 0x06009CB8 RID: 40120 RVA: 0x002CBEF8 File Offset: 0x002CA0F8
		private void __clearDele_EventOnAttackOfflineArenaOpponent(bool obj)
		{
			this.EventOnAttackOfflineArenaOpponent = null;
		}

		// Token: 0x06009CB9 RID: 40121 RVA: 0x002CBF04 File Offset: 0x002CA104
		private void __callDele_EventOnShowRevengeOfflineArenaOpponent(ArenaBattleReport obj)
		{
			Action<ArenaBattleReport> eventOnShowRevengeOfflineArenaOpponent = this.EventOnShowRevengeOfflineArenaOpponent;
			if (eventOnShowRevengeOfflineArenaOpponent != null)
			{
				eventOnShowRevengeOfflineArenaOpponent(obj);
			}
		}

		// Token: 0x06009CBA RID: 40122 RVA: 0x002CBF28 File Offset: 0x002CA128
		private void __clearDele_EventOnShowRevengeOfflineArenaOpponent(ArenaBattleReport obj)
		{
			this.EventOnShowRevengeOfflineArenaOpponent = null;
		}

		// Token: 0x06009CBB RID: 40123 RVA: 0x002CBF34 File Offset: 0x002CA134
		private void __callDele_EventOnRevengeOfflineArenaOpponent(bool obj)
		{
			Action<bool> eventOnRevengeOfflineArenaOpponent = this.EventOnRevengeOfflineArenaOpponent;
			if (eventOnRevengeOfflineArenaOpponent != null)
			{
				eventOnRevengeOfflineArenaOpponent(obj);
			}
		}

		// Token: 0x06009CBC RID: 40124 RVA: 0x002CBF58 File Offset: 0x002CA158
		private void __clearDele_EventOnRevengeOfflineArenaOpponent(bool obj)
		{
			this.EventOnRevengeOfflineArenaOpponent = null;
		}

		// Token: 0x06009CBD RID: 40125 RVA: 0x002CBF64 File Offset: 0x002CA164
		private void __callDele_EventOnOfflineBattleReportReplay(ArenaBattleReport obj)
		{
			Action<ArenaBattleReport> eventOnOfflineBattleReportReplay = this.EventOnOfflineBattleReportReplay;
			if (eventOnOfflineBattleReportReplay != null)
			{
				eventOnOfflineBattleReportReplay(obj);
			}
		}

		// Token: 0x06009CBE RID: 40126 RVA: 0x002CBF88 File Offset: 0x002CA188
		private void __clearDele_EventOnOfflineBattleReportReplay(ArenaBattleReport obj)
		{
			this.EventOnOfflineBattleReportReplay = null;
		}

		// Token: 0x06009CBF RID: 40127 RVA: 0x002CBF94 File Offset: 0x002CA194
		private void __callDele_EventOnShowOnlinePanel(OnlineArenaPanelType obj)
		{
			Action<OnlineArenaPanelType> eventOnShowOnlinePanel = this.EventOnShowOnlinePanel;
			if (eventOnShowOnlinePanel != null)
			{
				eventOnShowOnlinePanel(obj);
			}
		}

		// Token: 0x06009CC0 RID: 40128 RVA: 0x002CBFB8 File Offset: 0x002CA1B8
		private void __clearDele_EventOnShowOnlinePanel(OnlineArenaPanelType obj)
		{
			this.EventOnShowOnlinePanel = null;
		}

		// Token: 0x06009CC1 RID: 40129 RVA: 0x002CBFC4 File Offset: 0x002CA1C4
		private void __callDele_EventOnGainOnlineWeekWinReward(int obj)
		{
			Action<int> eventOnGainOnlineWeekWinReward = this.EventOnGainOnlineWeekWinReward;
			if (eventOnGainOnlineWeekWinReward != null)
			{
				eventOnGainOnlineWeekWinReward(obj);
			}
		}

		// Token: 0x06009CC2 RID: 40130 RVA: 0x002CBFE8 File Offset: 0x002CA1E8
		private void __clearDele_EventOnGainOnlineWeekWinReward(int obj)
		{
			this.EventOnGainOnlineWeekWinReward = null;
		}

		// Token: 0x06009CC3 RID: 40131 RVA: 0x002CBFF4 File Offset: 0x002CA1F4
		private void __callDele_EventOnOnlineBattleReportReplay(RealTimePVPBattleReport obj)
		{
			Action<RealTimePVPBattleReport> eventOnOnlineBattleReportReplay = this.EventOnOnlineBattleReportReplay;
			if (eventOnOnlineBattleReportReplay != null)
			{
				eventOnOnlineBattleReportReplay(obj);
			}
		}

		// Token: 0x06009CC4 RID: 40132 RVA: 0x002CC018 File Offset: 0x002CA218
		private void __clearDele_EventOnOnlineBattleReportReplay(RealTimePVPBattleReport obj)
		{
			this.EventOnOnlineBattleReportReplay = null;
		}

		// Token: 0x06009CC5 RID: 40133 RVA: 0x002CC024 File Offset: 0x002CA224
		private void __callDele_EventOnLadderChallenge()
		{
			Action eventOnLadderChallenge = this.EventOnLadderChallenge;
			if (eventOnLadderChallenge != null)
			{
				eventOnLadderChallenge();
			}
		}

		// Token: 0x06009CC6 RID: 40134 RVA: 0x002CC044 File Offset: 0x002CA244
		private void __clearDele_EventOnLadderChallenge()
		{
			this.EventOnLadderChallenge = null;
		}

		// Token: 0x06009CC7 RID: 40135 RVA: 0x002CC050 File Offset: 0x002CA250
		private void __callDele_EventOnCasualChallenge()
		{
			Action eventOnCasualChallenge = this.EventOnCasualChallenge;
			if (eventOnCasualChallenge != null)
			{
				eventOnCasualChallenge();
			}
		}

		// Token: 0x06009CC8 RID: 40136 RVA: 0x002CC070 File Offset: 0x002CA270
		private void __clearDele_EventOnCasualChallenge()
		{
			this.EventOnCasualChallenge = null;
		}

		// Token: 0x06009CC9 RID: 40137 RVA: 0x002CC07C File Offset: 0x002CA27C
		private void __callDele_EventOnMatchingCancel()
		{
			Action eventOnMatchingCancel = this.EventOnMatchingCancel;
			if (eventOnMatchingCancel != null)
			{
				eventOnMatchingCancel();
			}
		}

		// Token: 0x06009CCA RID: 40138 RVA: 0x002CC09C File Offset: 0x002CA29C
		private void __clearDele_EventOnMatchingCancel()
		{
			this.EventOnMatchingCancel = null;
		}

		// Token: 0x06009CCE RID: 40142 RVA: 0x002CC0D0 File Offset: 0x002CA2D0
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
					this.m_OpenArenaUITypeBoolean_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_SwitchOfflineOnlineArenaUIType_hotfix = (luaObj.RawGet("SwitchOfflineOnline") as LuaFunction);
					this.m_SetPlayerHeadIconInt32_hotfix = (luaObj.RawGet("SetPlayerHeadIcon") as LuaFunction);
					this.m_SetPlayerNameString_hotfix = (luaObj.RawGet("SetPlayerName") as LuaFunction);
					this.m_SetPlayerLevelInt32_hotfix = (luaObj.RawGet("SetPlayerLevel") as LuaFunction);
					this.m_SetArenaHonorInt32_hotfix = (luaObj.RawGet("SetArenaHonor") as LuaFunction);
					this.m_SetArenaTicketInt32Int32_hotfix = (luaObj.RawGet("SetArenaTicket") as LuaFunction);
					this.m_SetBattlePowerInt32_hotfix = (luaObj.RawGet("SetBattlePower") as LuaFunction);
					this.m_ShowArenaTicketDesc_hotfix = (luaObj.RawGet("ShowArenaTicketDesc") as LuaFunction);
					this.m_CloseArenaTicketDesc_hotfix = (luaObj.RawGet("CloseArenaTicketDesc") as LuaFunction);
					this.m_CreateSpineGraphicConfigDataJobConnectionInfoConfigDataModelSkinResourceInfo_hotfix = (luaObj.RawGet("CreateSpineGraphic") as LuaFunction);
					this.m_AddRewardPreviewGoodsList`1_hotfix = (luaObj.RawGet("AddRewardPreviewGoods") as LuaFunction);
					this.m_ShowBuyArenaTicketInt32Int32_hotfix = (luaObj.RawGet("ShowBuyArenaTicket") as LuaFunction);
					this.m_HideBuyArenaTicket_hotfix = (luaObj.RawGet("HideBuyArenaTicket") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_OnHelpButtonClick_hotfix = (luaObj.RawGet("OnHelpButtonClick") as LuaFunction);
					this.m_OnRewardPreviewBackgroundButtonClick_hotfix = (luaObj.RawGet("OnRewardPreviewBackgroundButtonClick") as LuaFunction);
					this.m_OnAddArenaTicketButtonClick_hotfix = (luaObj.RawGet("OnAddArenaTicketButtonClick") as LuaFunction);
					this.m_OnBuyArenaTicketBackgroundButtonClick_hotfix = (luaObj.RawGet("OnBuyArenaTicketBackgroundButtonClick") as LuaFunction);
					this.m_OnBuyArenaTicketBuyButtonClick_hotfix = (luaObj.RawGet("OnBuyArenaTicketBuyButtonClick") as LuaFunction);
					this.m_OnSwitchButtonClick_hotfix = (luaObj.RawGet("OnSwitchButtonClick") as LuaFunction);
					this.m_add_EventOnDefendAction_hotfix = (luaObj.RawGet("add_EventOnDefend") as LuaFunction);
					this.m_remove_EventOnDefendAction_hotfix = (luaObj.RawGet("remove_EventOnDefend") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnShowHelpAction_hotfix = (luaObj.RawGet("add_EventOnShowHelp") as LuaFunction);
					this.m_remove_EventOnShowHelpAction_hotfix = (luaObj.RawGet("remove_EventOnShowHelp") as LuaFunction);
					this.m_add_EventOnShowBuyArenaTicketAction_hotfix = (luaObj.RawGet("add_EventOnShowBuyArenaTicket") as LuaFunction);
					this.m_remove_EventOnShowBuyArenaTicketAction_hotfix = (luaObj.RawGet("remove_EventOnShowBuyArenaTicket") as LuaFunction);
					this.m_add_EventOnBuyArenaTicketAction_hotfix = (luaObj.RawGet("add_EventOnBuyArenaTicket") as LuaFunction);
					this.m_remove_EventOnBuyArenaTicketAction_hotfix = (luaObj.RawGet("remove_EventOnBuyArenaTicket") as LuaFunction);
					this.m_add_EventOnSwitchOnlineOfflineAction_hotfix = (luaObj.RawGet("add_EventOnSwitchOnlineOffline") as LuaFunction);
					this.m_remove_EventOnSwitchOnlineOfflineAction_hotfix = (luaObj.RawGet("remove_EventOnSwitchOnlineOffline") as LuaFunction);
					this.m_OfflineOnBindFiledsCompleted_hotfix = (luaObj.RawGet("OfflineOnBindFiledsCompleted") as LuaFunction);
					this.m_SetOfflineArenaPointsAndLevelInt32Int32_hotfix = (luaObj.RawGet("SetOfflineArenaPointsAndLevel") as LuaFunction);
					this.m_SetOfflineWeekWinInt32Int32_hotfix = (luaObj.RawGet("SetOfflineWeekWin") as LuaFunction);
					this.m_SetOfflineInSettleTimeBoolean_hotfix = (luaObj.RawGet("SetOfflineInSettleTime") as LuaFunction);
					this.m_SetOfflineVictoryPointsRewardStatusInt32Int32GainRewardStatus_hotfix = (luaObj.RawGet("SetOfflineVictoryPointsRewardStatus") as LuaFunction);
					this.m_SetOfflineVictoryPointsRewardProgressInt32Int32_hotfix = (luaObj.RawGet("SetOfflineVictoryPointsRewardProgress") as LuaFunction);
					this.m_SetOfflineArenaOpponentsList`1Boolean_hotfix = (luaObj.RawGet("SetOfflineArenaOpponents") as LuaFunction);
					this.m_SetOfflineArenaOpponentsRefreshTimeTimeSpan_hotfix = (luaObj.RawGet("SetOfflineArenaOpponentsRefreshTime") as LuaFunction);
					this.m_SetOfflineArenaBattleReportsList`1_hotfix = (luaObj.RawGet("SetOfflineArenaBattleReports") as LuaFunction);
					this.m_SetOfflineArenaRankingsInt32List`1_hotfix = (luaObj.RawGet("SetOfflineArenaRankings") as LuaFunction);
					this.m_ShowOfflinePanelOfflineArenaPanelType_hotfix = (luaObj.RawGet("ShowOfflinePanel") as LuaFunction);
					this.m_ShowAutoBattleTips_hotfix = (luaObj.RawGet("ShowAutoBattleTips") as LuaFunction);
					this.m_HideAutoBattleTips_hotfix = (luaObj.RawGet("HideAutoBattleTips") as LuaFunction);
					this.m_ShowArenaOpponentArenaOpponentList`1Int32Boolean_hotfix = (luaObj.RawGet("ShowArenaOpponent") as LuaFunction);
					this.m_HideArenaOpponent_hotfix = (luaObj.RawGet("HideArenaOpponent") as LuaFunction);
					this.m_ClearOpponentGraphcs_hotfix = (luaObj.RawGet("ClearOpponentGraphcs") as LuaFunction);
					this.m_OnOfflineClashToggleBoolean_hotfix = (luaObj.RawGet("OnOfflineClashToggle") as LuaFunction);
					this.m_OnOfflineBattleReportToggleBoolean_hotfix = (luaObj.RawGet("OnOfflineBattleReportToggle") as LuaFunction);
					this.m_OnOfflineRankingToggleBoolean_hotfix = (luaObj.RawGet("OnOfflineRankingToggle") as LuaFunction);
					this.m_OnOfflineArenaPointRewardButtonClick_hotfix = (luaObj.RawGet("OnOfflineArenaPointRewardButtonClick") as LuaFunction);
					this.m_OnOfflineArenaPointRewardCloseButtonClick_hotfix = (luaObj.RawGet("OnOfflineArenaPointRewardCloseButtonClick") as LuaFunction);
					this.m_OnOfflineVictoryPointsRewardButtonClickGainRewardButton_hotfix = (luaObj.RawGet("OnOfflineVictoryPointsRewardButtonClick") as LuaFunction);
					this.m_OnOfflineArenaOpponentAttackButtonClickArenaOpponentListItemUIController_hotfix = (luaObj.RawGet("OnOfflineArenaOpponentAttackButtonClick") as LuaFunction);
					this.m_OnOfflineBattleReportRevengeButtonClickOfflineArenaBattleReportListItemUIController_hotfix = (luaObj.RawGet("OnOfflineBattleReportRevengeButtonClick") as LuaFunction);
					this.m_OnOfflineBattleReportReplayButtonClickOfflineArenaBattleReportListItemUIController_hotfix = (luaObj.RawGet("OnOfflineBattleReportReplayButtonClick") as LuaFunction);
					this.m_OnDefendButtonClick_hotfix = (luaObj.RawGet("OnDefendButtonClick") as LuaFunction);
					this.m_OnAttackConfirmButtonClick_hotfix = (luaObj.RawGet("OnAttackConfirmButtonClick") as LuaFunction);
					this.m_OnAutoBattleButtonClick_hotfix = (luaObj.RawGet("OnAutoBattleButtonClick") as LuaFunction);
					this.m_OnAttackBackgroundButtonClick_hotfix = (luaObj.RawGet("OnAttackBackgroundButtonClick") as LuaFunction);
					this.m_OnAutoBattleTipsConfirmButtonClick_hotfix = (luaObj.RawGet("OnAutoBattleTipsConfirmButtonClick") as LuaFunction);
					this.m_OnAutoBattleTipsCancelButtonClick_hotfix = (luaObj.RawGet("OnAutoBattleTipsCancelButtonClick") as LuaFunction);
					this.m_add_EventOnShowOfflinePanelAction`1_hotfix = (luaObj.RawGet("add_EventOnShowOfflinePanel") as LuaFunction);
					this.m_remove_EventOnShowOfflinePanelAction`1_hotfix = (luaObj.RawGet("remove_EventOnShowOfflinePanel") as LuaFunction);
					this.m_add_EventOnGainOfflineVictoryPointsRewardAction`1_hotfix = (luaObj.RawGet("add_EventOnGainOfflineVictoryPointsReward") as LuaFunction);
					this.m_remove_EventOnGainOfflineVictoryPointsRewardAction`1_hotfix = (luaObj.RawGet("remove_EventOnGainOfflineVictoryPointsReward") as LuaFunction);
					this.m_add_EventOnShowOfflineArenaOpponentAction`1_hotfix = (luaObj.RawGet("add_EventOnShowOfflineArenaOpponent") as LuaFunction);
					this.m_remove_EventOnShowOfflineArenaOpponentAction`1_hotfix = (luaObj.RawGet("remove_EventOnShowOfflineArenaOpponent") as LuaFunction);
					this.m_add_EventOnAttackOfflineArenaOpponentAction`1_hotfix = (luaObj.RawGet("add_EventOnAttackOfflineArenaOpponent") as LuaFunction);
					this.m_remove_EventOnAttackOfflineArenaOpponentAction`1_hotfix = (luaObj.RawGet("remove_EventOnAttackOfflineArenaOpponent") as LuaFunction);
					this.m_add_EventOnShowRevengeOfflineArenaOpponentAction`1_hotfix = (luaObj.RawGet("add_EventOnShowRevengeOfflineArenaOpponent") as LuaFunction);
					this.m_remove_EventOnShowRevengeOfflineArenaOpponentAction`1_hotfix = (luaObj.RawGet("remove_EventOnShowRevengeOfflineArenaOpponent") as LuaFunction);
					this.m_add_EventOnRevengeOfflineArenaOpponentAction`1_hotfix = (luaObj.RawGet("add_EventOnRevengeOfflineArenaOpponent") as LuaFunction);
					this.m_remove_EventOnRevengeOfflineArenaOpponentAction`1_hotfix = (luaObj.RawGet("remove_EventOnRevengeOfflineArenaOpponent") as LuaFunction);
					this.m_add_EventOnOfflineBattleReportReplayAction`1_hotfix = (luaObj.RawGet("add_EventOnOfflineBattleReportReplay") as LuaFunction);
					this.m_remove_EventOnOfflineBattleReportReplayAction`1_hotfix = (luaObj.RawGet("remove_EventOnOfflineBattleReportReplay") as LuaFunction);
					this.m_OnlineOnBindFiledsCompleted_hotfix = (luaObj.RawGet("OnlineOnBindFiledsCompleted") as LuaFunction);
					this.m_SetOnlineScoreAndDanInt32Int32_hotfix = (luaObj.RawGet("SetOnlineScoreAndDan") as LuaFunction);
					this.m_SetLadderModeBooleanBoolean_hotfix = (luaObj.RawGet("SetLadderMode") as LuaFunction);
					this.m_SetLadderOpenTimeString_hotfix = (luaObj.RawGet("SetLadderOpenTime") as LuaFunction);
					this.m_SetLadderWeekWinInt32Int32_hotfix = (luaObj.RawGet("SetLadderWeekWin") as LuaFunction);
					this.m_SetOnlineWeekWinRewardStatusInt32Int32GainRewardStatus_hotfix = (luaObj.RawGet("SetOnlineWeekWinRewardStatus") as LuaFunction);
					this.m_SetOnlineWeekWinRewardProgressInt32Int32_hotfix = (luaObj.RawGet("SetOnlineWeekWinRewardProgress") as LuaFunction);
					this.m_ShowPromoteBattleInt32_hotfix = (luaObj.RawGet("ShowPromoteBattle") as LuaFunction);
					this.m_ShowPromoteSucceedInt32_hotfix = (luaObj.RawGet("ShowPromoteSucceed") as LuaFunction);
					this.m_SetPromoteBattleStatusInt32List`1_hotfix = (luaObj.RawGet("SetPromoteBattleStatus") as LuaFunction);
					this.m_SetOnlineDansList`1Int32_hotfix = (luaObj.RawGet("SetOnlineDans") as LuaFunction);
					this.m_SetOnlineArenaBattleReportsList`1_hotfix = (luaObj.RawGet("SetOnlineArenaBattleReports") as LuaFunction);
					this.m_SetOnlineArenaRankingsInt32List`1List`1Boolean_hotfix = (luaObj.RawGet("SetOnlineArenaRankings") as LuaFunction);
					this.m_ShowGlobalRankingToggleBoolean_hotfix = (luaObj.RawGet("ShowGlobalRankingToggle") as LuaFunction);
					this.m_ShowOnlinePanelOnlineArenaPanelType_hotfix = (luaObj.RawGet("ShowOnlinePanel") as LuaFunction);
					this.m_ShowMatchingNow_hotfix = (luaObj.RawGet("ShowMatchingNow") as LuaFunction);
					this.m_HideMatchingNow_hotfix = (luaObj.RawGet("HideMatchingNow") as LuaFunction);
					this.m_SetMatchingNowTimeTimeSpan_hotfix = (luaObj.RawGet("SetMatchingNowTime") as LuaFunction);
					this.m_SetMatchingPredictTimeTimeSpan_hotfix = (luaObj.RawGet("SetMatchingPredictTime") as LuaFunction);
					this.m_IsMatchingNowPredictTimeActive_hotfix = (luaObj.RawGet("IsMatchingNowPredictTimeActive") as LuaFunction);
					this.m_ShowMatchingFailed_hotfix = (luaObj.RawGet("ShowMatchingFailed") as LuaFunction);
					this.m_OnOnlineClashToggleBoolean_hotfix = (luaObj.RawGet("OnOnlineClashToggle") as LuaFunction);
					this.m_OnOnlineBattleReportToggleBoolean_hotfix = (luaObj.RawGet("OnOnlineBattleReportToggle") as LuaFunction);
					this.m_OnOnlineDanToggleBoolean_hotfix = (luaObj.RawGet("OnOnlineDanToggle") as LuaFunction);
					this.m_OnOnlineLocalRankingToggleBoolean_hotfix = (luaObj.RawGet("OnOnlineLocalRankingToggle") as LuaFunction);
					this.m_OnOnlineGlobalRankingToggleBoolean_hotfix = (luaObj.RawGet("OnOnlineGlobalRankingToggle") as LuaFunction);
					this.m_OnOnlineWeekWinRewardButtonClickGainRewardButton_hotfix = (luaObj.RawGet("OnOnlineWeekWinRewardButtonClick") as LuaFunction);
					this.m_OnOnlineBattleReportReplayButtonClickOnlineArenaBattleReportListItemUIController_hotfix = (luaObj.RawGet("OnOnlineBattleReportReplayButtonClick") as LuaFunction);
					this.m_OnOnlineClashLadderChallengeButtonClick_hotfix = (luaObj.RawGet("OnOnlineClashLadderChallengeButtonClick") as LuaFunction);
					this.m_OnOnlineClashCasualChallengeButtonClick_hotfix = (luaObj.RawGet("OnOnlineClashCasualChallengeButtonClick") as LuaFunction);
					this.m_OnMatchingFailedConfirmButtonClick_hotfix = (luaObj.RawGet("OnMatchingFailedConfirmButtonClick") as LuaFunction);
					this.m_OnMatchingNowCancelButtonClick_hotfix = (luaObj.RawGet("OnMatchingNowCancelButtonClick") as LuaFunction);
					this.m_OnOnlineArenaRankingRewardButtonClick_hotfix = (luaObj.RawGet("OnOnlineArenaRankingRewardButtonClick") as LuaFunction);
					this.m_OnOnlineArenaRankingRewardCloseButtonClick_hotfix = (luaObj.RawGet("OnOnlineArenaRankingRewardCloseButtonClick") as LuaFunction);
					this.m_OnPromoteBattleConfirmButtonClick_hotfix = (luaObj.RawGet("OnPromoteBattleConfirmButtonClick") as LuaFunction);
					this.m_OnPromoteSucceedConfirmButtonClick_hotfix = (luaObj.RawGet("OnPromoteSucceedConfirmButtonClick") as LuaFunction);
					this.m_add_EventOnShowOnlinePanelAction`1_hotfix = (luaObj.RawGet("add_EventOnShowOnlinePanel") as LuaFunction);
					this.m_remove_EventOnShowOnlinePanelAction`1_hotfix = (luaObj.RawGet("remove_EventOnShowOnlinePanel") as LuaFunction);
					this.m_add_EventOnGainOnlineWeekWinRewardAction`1_hotfix = (luaObj.RawGet("add_EventOnGainOnlineWeekWinReward") as LuaFunction);
					this.m_remove_EventOnGainOnlineWeekWinRewardAction`1_hotfix = (luaObj.RawGet("remove_EventOnGainOnlineWeekWinReward") as LuaFunction);
					this.m_add_EventOnOnlineBattleReportReplayAction`1_hotfix = (luaObj.RawGet("add_EventOnOnlineBattleReportReplay") as LuaFunction);
					this.m_remove_EventOnOnlineBattleReportReplayAction`1_hotfix = (luaObj.RawGet("remove_EventOnOnlineBattleReportReplay") as LuaFunction);
					this.m_add_EventOnLadderChallengeAction_hotfix = (luaObj.RawGet("add_EventOnLadderChallenge") as LuaFunction);
					this.m_remove_EventOnLadderChallengeAction_hotfix = (luaObj.RawGet("remove_EventOnLadderChallenge") as LuaFunction);
					this.m_add_EventOnCasualChallengeAction_hotfix = (luaObj.RawGet("add_EventOnCasualChallenge") as LuaFunction);
					this.m_remove_EventOnCasualChallengeAction_hotfix = (luaObj.RawGet("remove_EventOnCasualChallenge") as LuaFunction);
					this.m_add_EventOnMatchingCancelAction_hotfix = (luaObj.RawGet("add_EventOnMatchingCancel") as LuaFunction);
					this.m_remove_EventOnMatchingCancelAction_hotfix = (luaObj.RawGet("remove_EventOnMatchingCancel") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06009CCF RID: 40143 RVA: 0x002CCDEC File Offset: 0x002CAFEC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006A05 RID: 27141
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x04006A06 RID: 27142
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x04006A07 RID: 27143
		[AutoBind("./HelpButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_helpButton;

		// Token: 0x04006A08 RID: 27144
		[AutoBind("./PlayerResource/ArenaCoin/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_offlineArenaCoinText;

		// Token: 0x04006A09 RID: 27145
		[AutoBind("./PlayerResource/ArenaOnlineCoin/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_onlineArenaCoinText;

		// Token: 0x04006A0A RID: 27146
		[AutoBind("./PlayerResource/Ticket", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_arenaTicketButton;

		// Token: 0x04006A0B RID: 27147
		[AutoBind("./PlayerResource/Ticket/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_arenaTicketText;

		// Token: 0x04006A0C RID: 27148
		[AutoBind("./PlayerResource/Ticket/AddButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_addArenaTicketButton;

		// Token: 0x04006A0D RID: 27149
		[AutoBind("./Switch", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_switchUIStateController;

		// Token: 0x04006A0E RID: 27150
		[AutoBind("./Switch/SwitchButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_switchButton;

		// Token: 0x04006A0F RID: 27151
		[AutoBind("./Switch/SwitchButton", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_switchButtonUIStateController;

		// Token: 0x04006A10 RID: 27152
		[AutoBind("./OfflineAndOnlingChange", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_offlineOnlineChangeUIStateController;

		// Token: 0x04006A11 RID: 27153
		[AutoBind("./AutoBattleTips", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_autoBattleTipsUIStateController;

		// Token: 0x04006A12 RID: 27154
		[AutoBind("./AutoBattleTips/BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_autoBattleTipsBackgroundButton;

		// Token: 0x04006A13 RID: 27155
		[AutoBind("./AutoBattleTips/Panel/ShowToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_autoBattleTipsShowToggle;

		// Token: 0x04006A14 RID: 27156
		[AutoBind("./AutoBattleTips/Panel/ConfirmButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_autoBattleTipsConfirmButton;

		// Token: 0x04006A15 RID: 27157
		[AutoBind("./AutoBattleTips/Panel/CancelButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_autoBattleTipsCancelButton;

		// Token: 0x04006A16 RID: 27158
		[AutoBind("./RewardPreview", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_rewardPreviewUIStateController;

		// Token: 0x04006A17 RID: 27159
		[AutoBind("./RewardPreview/BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_rewardPreviewBackgroundButton;

		// Token: 0x04006A18 RID: 27160
		[AutoBind("./RewardPreview/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_rewardPreviewScrollRect;

		// Token: 0x04006A19 RID: 27161
		[AutoBind("./ArenaTicketDesc", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_arenaTicketDescGameObject;

		// Token: 0x04006A1A RID: 27162
		[AutoBind("./ArenaTicketDesc", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_arenaTicketDescUIStateCtrl;

		// Token: 0x04006A1B RID: 27163
		[AutoBind("./ArenaTicketDesc/BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_arenaTicketDescBackgroundButton;

		// Token: 0x04006A1C RID: 27164
		[AutoBind("./BuyArenaTicket", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_buyArenaTicketUIStateController;

		// Token: 0x04006A1D RID: 27165
		[AutoBind("./BuyArenaTicket/BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_buyArenaTicketBackgroundButton;

		// Token: 0x04006A1E RID: 27166
		[AutoBind("./BuyArenaTicket/Panel/CountText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_buyArenaTicketCountText;

		// Token: 0x04006A1F RID: 27167
		[AutoBind("./BuyArenaTicket/Panel/BuyButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_buyArenaTicketBuyButton;

		// Token: 0x04006A20 RID: 27168
		[AutoBind("./BuyArenaTicket/Panel/BuyButton/PriceText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_buyArenaTicketPriceText;

		// Token: 0x04006A21 RID: 27169
		[AutoBind("./ArenaPointReward", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_offineArenaPointRewardUIStateCtrl;

		// Token: 0x04006A22 RID: 27170
		[AutoBind("./ArenaPointReward/BGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_offlineArenaPointRewardBGButton;

		// Token: 0x04006A23 RID: 27171
		[AutoBind("./ArenaPointReward/Detail/CloseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_offlineArenaPointRewardCloseButton;

		// Token: 0x04006A24 RID: 27172
		[AutoBind("./ArenaPointReward/Detail/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_offlineArenaPointRewardScrollRect;

		// Token: 0x04006A25 RID: 27173
		[AutoBind("./ArenaRankingReward", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_onlineArenaRankingRewardUIStateCtrl;

		// Token: 0x04006A26 RID: 27174
		[AutoBind("./ArenaRankingReward/BGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_onlineArenaRankingRewardBGButton;

		// Token: 0x04006A27 RID: 27175
		[AutoBind("./ArenaRankingReward/Detail/CloseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_onlineArenaRankingRewardCloseButton;

		// Token: 0x04006A28 RID: 27176
		[AutoBind("./ArenaRankingReward/Detail/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_onlineArenaRankingRewardscrollRect;

		// Token: 0x04006A29 RID: 27177
		[AutoBind("./Attack", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_attackUIStateController;

		// Token: 0x04006A2A RID: 27178
		[AutoBind("./Attack/BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_attackBackgroundButton;

		// Token: 0x04006A2B RID: 27179
		[AutoBind("./Attack/Panel/Detail/Title/PowerValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_attackBattlePowerText;

		// Token: 0x04006A2C RID: 27180
		[AutoBind("./Attack/Panel/Detail/AttackButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_attackConfirmButton;

		// Token: 0x04006A2D RID: 27181
		[AutoBind("./Attack/Panel/Detail/AutoBattleButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_attackAutoConfirmButton;

		// Token: 0x04006A2E RID: 27182
		[AutoBind("./Attack/Panel/Detail/Graphics", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_attackGraphicsGameObject;

		// Token: 0x04006A2F RID: 27183
		[AutoBind("./Attack/Panel/Detail/Title/PlayerImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_attackPlayerIconImage;

		// Token: 0x04006A30 RID: 27184
		[AutoBind("./Attack/Panel/Detail/Title/PlayerNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_attackPlayerNameText;

		// Token: 0x04006A31 RID: 27185
		[AutoBind("./Attack/Panel/Detail/Title/LvValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_attackPlayerLVText;

		// Token: 0x04006A32 RID: 27186
		[AutoBind("./Attack/Panel/Detail/Title/IntegralValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_attackPlayerArenaPointText;

		// Token: 0x04006A33 RID: 27187
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_prefabsGameObject;

		// Token: 0x04006A34 RID: 27188
		[AutoBind("./Prefabs/ArenaLevelListItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_arenaLevelListItemPrefab;

		// Token: 0x04006A35 RID: 27189
		[AutoBind("./Prefabs/ArenaRankingListItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_arenaRankingListItemPrefab;

		// Token: 0x04006A36 RID: 27190
		[AutoBind("./Prefabs/ArenaBattleReportListItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_offlineArenaBattleReportListItemPrefab;

		// Token: 0x04006A37 RID: 27191
		[AutoBind("./Prefabs/ArenaOpponentListItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_arenaOpponentListItemPrefab;

		// Token: 0x04006A38 RID: 27192
		[AutoBind("./Prefabs/ArenaPointRewardListItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_arenaPointRewardListItemPrefab;

		// Token: 0x04006A39 RID: 27193
		[AutoBind("./Prefabs/ArenaOnlineBattleReportListItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_onlineArenaBattleReportListItemPrefab;

		// Token: 0x04006A3A RID: 27194
		private bool m_isIgnoreToggleEvent;

		// Token: 0x04006A3B RID: 27195
		private bool m_isRevengeOpponent;

		// Token: 0x04006A3C RID: 27196
		private static bool s_isShowAutoBattleTips = true;

		// Token: 0x04006A3D RID: 27197
		private GainRewardButton[] m_offlineVictoryPointsRewardButtons;

		// Token: 0x04006A3E RID: 27198
		private GainRewardButton[] m_onlineWeekWinRewardButtons;

		// Token: 0x04006A3F RID: 27199
		private GameObjectPool<ArenaLevelListItemUIController> m_onlineArenaLevelPool;

		// Token: 0x04006A40 RID: 27200
		private List<UISpineGraphic> m_opponentGraphics = new List<UISpineGraphic>();

		// Token: 0x04006A48 RID: 27208
		[AutoBind("./Offline", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_offlineGameObject;

		// Token: 0x04006A49 RID: 27209
		[AutoBind("./Offline/Margin", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_offlineMarginTransform;

		// Token: 0x04006A4A RID: 27210
		[AutoBind("./Offline/Margin/Tabs/ClashToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_offlineClashToggle;

		// Token: 0x04006A4B RID: 27211
		[AutoBind("./Offline/Margin/Tabs/BattleReportToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_offlineBattleReportToggle;

		// Token: 0x04006A4C RID: 27212
		[AutoBind("./Offline/Margin/Tabs/RankingToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_offlineRankingToggle;

		// Token: 0x04006A4D RID: 27213
		[AutoBind("./Offline/Panels/Clash", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_offlineClashPanelGameObject;

		// Token: 0x04006A4E RID: 27214
		[AutoBind("./Offline/Panels/Clash/Opponents", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_offlineArenaOpponentsGameObject;

		// Token: 0x04006A4F RID: 27215
		[AutoBind("./Offline/Panels/Clash/InSettle", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_offlineInSettleGameObject;

		// Token: 0x04006A50 RID: 27216
		[AutoBind("./Offline/Panels/Clash/RefreshTime/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_offlineArenaOpponentsRefreshTimeText;

		// Token: 0x04006A51 RID: 27217
		[AutoBind("./Offline/Panels/BattleReport", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_offlineBattleReportPanelGameObject;

		// Token: 0x04006A52 RID: 27218
		[AutoBind("./Offline/Panels/BattleReport/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_offlineBattleReportScrollRect;

		// Token: 0x04006A53 RID: 27219
		[AutoBind("./Offline/Panels/BattleReport/EmptyPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_offlineNoBattleReportGameObject;

		// Token: 0x04006A54 RID: 27220
		[AutoBind("./Offline/Panels/Ranking", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_offlineRankingPanelGameObject;

		// Token: 0x04006A55 RID: 27221
		[AutoBind("./Offline/Panels/Ranking/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_offlineRankingScrollRect;

		// Token: 0x04006A56 RID: 27222
		[AutoBind("./Offline/Panels/Ranking/Player/PlayerNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_offlineRankingPlayerNameText;

		// Token: 0x04006A57 RID: 27223
		[AutoBind("./Offline/Panels/Ranking/Player/Ranking", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_offlineRankingPlayerRankingUIStateController;

		// Token: 0x04006A58 RID: 27224
		[AutoBind("./Offline/Panels/Ranking/Player/Ranking/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_offlineRankingPlayerRankingText;

		// Token: 0x04006A59 RID: 27225
		[AutoBind("./Offline/Panels/Ranking/Player/Ranking/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_offlineRankingPlayerRankingImage;

		// Token: 0x04006A5A RID: 27226
		[AutoBind("./Offline/Panels/Ranking/Player/ArenaPoints/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_offlineRankingArenaPointsText;

		// Token: 0x04006A5B RID: 27227
		[AutoBind("./Offline/Panels/Ranking/Player/HeadIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_offlineRankingPlayerIconImage;

		// Token: 0x04006A5C RID: 27228
		[AutoBind("./Offline/Panels/Ranking/Player/HeadIcon/HeadFrameDummy", AutoBindAttribute.InitState.NotInit, false)]
		private Transform m_offlineRankingPlayerHeadFrameTransform;

		// Token: 0x04006A5D RID: 27229
		[AutoBind("./Offline/Panels/Ranking/Player/HeadIcon/LevelText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_offlineRankingPlayerLevelText;

		// Token: 0x04006A5E RID: 27230
		[AutoBind("./Offline/Margin/Player/Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_offlinePlayerIconImage;

		// Token: 0x04006A5F RID: 27231
		[AutoBind("./Offline/Margin/Player/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_offlinePlayerNameText;

		// Token: 0x04006A60 RID: 27232
		[AutoBind("./Offline/Margin/Player/LvGroup/LvNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_offlinePlayerLevelText;

		// Token: 0x04006A61 RID: 27233
		[AutoBind("./Offline/Margin/Player/BattlePower/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_offlinePlayerBattlePowerText;

		// Token: 0x04006A62 RID: 27234
		[AutoBind("./Offline/Margin/Player/ArenaPoints/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_offlineArenaPointsText;

		// Token: 0x04006A63 RID: 27235
		[AutoBind("./Offline/Margin/Player/ArenaPointsUp/Text1", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_offlineArenaPointsUpText1;

		// Token: 0x04006A64 RID: 27236
		[AutoBind("./Offline/Margin/Player/ArenaPointsUp/Text2", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_offlineArenaPointsUpText2;

		// Token: 0x04006A65 RID: 27237
		[AutoBind("./Offline/Margin/Player/ArenaPointsUp/ProgressBarImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_offlineArenaPointsUpBarImage;

		// Token: 0x04006A66 RID: 27238
		[AutoBind("./Offline/Margin/Player/DefendButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_offlineDefendButton;

		// Token: 0x04006A67 RID: 27239
		[AutoBind("./Offline/Margin/Player/RewardButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_offlineArenaPointRewardButton;

		// Token: 0x04006A68 RID: 27240
		[AutoBind("./Offline/DownGroup/VictoryPoints/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_offlineVictoryPointsText;

		// Token: 0x04006A69 RID: 27241
		[AutoBind("./Offline/DownGroup/VictoryPointsReward/Button1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_offlineVictoryPointsRewardButton1GameObject;

		// Token: 0x04006A6A RID: 27242
		[AutoBind("./Offline/DownGroup/VictoryPointsReward/Button2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_offlineVictoryPointsRewardButton2GameObject;

		// Token: 0x04006A6B RID: 27243
		[AutoBind("./Offline/DownGroup/VictoryPointsReward/Button3", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_offlineVictoryPointsRewardButton3GameObject;

		// Token: 0x04006A6C RID: 27244
		[AutoBind("./Offline/DownGroup/VictoryPointsReward/BarFrame/Bar", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_offlineVictoryPointsRewardImage;

		// Token: 0x04006A6D RID: 27245
		[AutoBind("./Offline/DownGroup/WeekWin/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_offlineWeekWinText;

		// Token: 0x04006A6E RID: 27246
		private GameObjectPool<ArenaOpponentListItemUIController> m_arenaOpponentPool;

		// Token: 0x04006A6F RID: 27247
		private GameObjectPool<ArenaRankingListItemUIController> m_arenaRankingPool;

		// Token: 0x04006A70 RID: 27248
		private GameObjectPool<OfflineArenaBattleReportListItemUIController> m_offlineArenaBattleReportPool;

		// Token: 0x04006A71 RID: 27249
		private GameObjectPool<ArenaPointRewardListItemUIController> m_offlineArenaPointRewardPool;

		// Token: 0x04006A78 RID: 27256
		[AutoBind("./Online", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_onlineGameObject;

		// Token: 0x04006A79 RID: 27257
		[AutoBind("./Online/Margin", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_onlineMarginTransform;

		// Token: 0x04006A7A RID: 27258
		[AutoBind("./Online/Margin/Tabs/ClashToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_onlineClashToggle;

		// Token: 0x04006A7B RID: 27259
		[AutoBind("./Online/Margin/Tabs/BattleReportToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_onlineBattleReportToggle;

		// Token: 0x04006A7C RID: 27260
		[AutoBind("./Online/Margin/Tabs/ArenaLevelToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_onlineDanToggle;

		// Token: 0x04006A7D RID: 27261
		[AutoBind("./Online/Margin/Tabs/LocalRankingToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_onlineLocalRankingToggle;

		// Token: 0x04006A7E RID: 27262
		[AutoBind("./Online/Margin/Tabs/GlobalRankingToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_onlineGlobalRankingToggle;

		// Token: 0x04006A7F RID: 27263
		[AutoBind("./Online/Panels/Clash", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_onlineClashPanelGameObject;

		// Token: 0x04006A80 RID: 27264
		[AutoBind("./Online/Panels/Clash/LadderMode", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_onlineClashLadderModeUIStateController;

		// Token: 0x04006A81 RID: 27265
		[AutoBind("./Online/Panels/Clash/LadderMode/WinRate/WinRateValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_onlineClashWinRateText;

		// Token: 0x04006A82 RID: 27266
		[AutoBind("./Online/Panels/Clash/LadderMode/WinRate/WinTimes/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_onlineClashWinCountText;

		// Token: 0x04006A83 RID: 27267
		[AutoBind("./Online/Panels/Clash/LadderMode/WinRate/FailedTimes/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_onlineClashLoseCountText;

		// Token: 0x04006A84 RID: 27268
		[AutoBind("./Online/Panels/Clash/LadderMode/WinRate/Times/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_onlineClashTotalCountText;

		// Token: 0x04006A85 RID: 27269
		[AutoBind("./Online/Panels/Clash/LadderMode/WinRate/ArenaLevelIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_onlineClashDanIconImage;

		// Token: 0x04006A86 RID: 27270
		[AutoBind("./Online/Panels/Clash/LadderMode/PromoteCompetitionInfo/NowArenaLevelIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_onlineClashPromoteDanIconImage;

		// Token: 0x04006A87 RID: 27271
		[AutoBind("./Online/Panels/Clash/LadderMode/PromoteCompetitionInfo/AfterArenaLevelIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_onlineClashPromoteNextDanIconImage;

		// Token: 0x04006A88 RID: 27272
		[AutoBind("./Online/Panels/Clash/LadderMode/PromoteCompetitionInfo/CountText", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_onlineClashPromoteCountImage;

		// Token: 0x04006A89 RID: 27273
		[AutoBind("./Online/Panels/Clash/LadderMode/PromoteCompetitionInfo/CompetitionRoundGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_onlineClashPromoteRoundGroupGameObject;

		// Token: 0x04006A8A RID: 27274
		[AutoBind("./Online/Panels/Clash/LadderMode/OpenTime", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_onlineClashLadderOpenTimeGameObject;

		// Token: 0x04006A8B RID: 27275
		[AutoBind("./Online/Panels/Clash/LadderMode/OpenTime/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_onlineClashLadderOpenTimeText;

		// Token: 0x04006A8C RID: 27276
		[AutoBind("./Online/Panels/Clash/LadderMode/ChallengeButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_onlineClashLadderChallengeButton;

		// Token: 0x04006A8D RID: 27277
		[AutoBind("./Online/Panels/Clash/LadderMode/ChallengeButton", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_onlineClashLadderChallengeButtonUIStateController;

		// Token: 0x04006A8E RID: 27278
		[AutoBind("./Online/Panels/Clash/CasualMode/ChallengeButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_onlineClashCasualChallengeButton;

		// Token: 0x04006A8F RID: 27279
		[AutoBind("./Online/Panels/BattleReport", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_onlineBattleReportPanelGameObject;

		// Token: 0x04006A90 RID: 27280
		[AutoBind("./Online/Panels/BattleReport/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_onlineBattleReportScrollRect;

		// Token: 0x04006A91 RID: 27281
		[AutoBind("./Online/Panels/BattleReport/EmptyPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_onlineNoBattleReportGameObject;

		// Token: 0x04006A92 RID: 27282
		[AutoBind("./Online/Panels/ArenaLevel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_onlineDanPanelGameObject;

		// Token: 0x04006A93 RID: 27283
		[AutoBind("./Online/Panels/ArenaLevel/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_onlineArenaLevelScrollRect;

		// Token: 0x04006A94 RID: 27284
		[AutoBind("./Online/Panels/Ranking", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_onlineRankingPanelGameObject;

		// Token: 0x04006A95 RID: 27285
		[AutoBind("./Online/Panels/Ranking/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_onlineRankingScrollRect;

		// Token: 0x04006A96 RID: 27286
		[AutoBind("./Online/Panels/Ranking/Player/PlayerNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_onlineRankingPlayerNameText;

		// Token: 0x04006A97 RID: 27287
		[AutoBind("./Online/Panels/Ranking/Player/Ranking", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_onlineRankingPlayerRankingUIStateController;

		// Token: 0x04006A98 RID: 27288
		[AutoBind("./Online/Panels/Ranking/Player/Ranking/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_onlineRankingPlayerRankingText;

		// Token: 0x04006A99 RID: 27289
		[AutoBind("./Online/Panels/Ranking/Player/Ranking/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_onlineRankingPlayerRankingImage;

		// Token: 0x04006A9A RID: 27290
		[AutoBind("./Online/Panels/Ranking/Player/ArenaPoints/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_onlineRankingArenaPointsText;

		// Token: 0x04006A9B RID: 27291
		[AutoBind("./Online/Panels/Ranking/Player/HeadIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_onlineRankingPlayerIconImage;

		// Token: 0x04006A9C RID: 27292
		[AutoBind("./Online/Panels/Ranking/Player/HeadIcon/HeadFrameDummy", AutoBindAttribute.InitState.NotInit, false)]
		private Transform m_onlineRankingPlayerHeadFrameTransform;

		// Token: 0x04006A9D RID: 27293
		[AutoBind("./Online/Panels/Ranking/Player/HeadIcon/LevelText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_onlineRankingPlayerLevelText;

		// Token: 0x04006A9E RID: 27294
		[AutoBind("./Online/Margin/Player/Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_onlinePlayerIconImage;

		// Token: 0x04006A9F RID: 27295
		[AutoBind("./Online/Margin/Player/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_onlinePlayerNameText;

		// Token: 0x04006AA0 RID: 27296
		[AutoBind("./Online/Margin/Player/ArenaLevel/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_onlineDanText;

		// Token: 0x04006AA1 RID: 27297
		[AutoBind("./Online/Margin/Player/ArenaLevel/Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_onlineDanIconImage;

		// Token: 0x04006AA2 RID: 27298
		[AutoBind("./Online/Margin/Player/LvGroup/LvNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_onlinePlayerLevelText;

		// Token: 0x04006AA3 RID: 27299
		[AutoBind("./Online/Margin/Player/ArenaPoints/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_onlineArenaPointsText;

		// Token: 0x04006AA4 RID: 27300
		[AutoBind("./Online/Margin/Player/ArenaPointsUp/Text1", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_onlineArenaPointsUpText1;

		// Token: 0x04006AA5 RID: 27301
		[AutoBind("./Online/Margin/Player/ArenaPointsUp/Text2", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_onlineArenaPointsUpText2;

		// Token: 0x04006AA6 RID: 27302
		[AutoBind("./Online/Margin/Player/ArenaPointsUp/ProgressBarImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_onlineArenaPointsUpBarImage;

		// Token: 0x04006AA7 RID: 27303
		[AutoBind("./Online/Margin/Player/RewardButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_onlineArenaRankingRewardButton;

		// Token: 0x04006AA8 RID: 27304
		[AutoBind("./Online/DownGroup/WeekWin/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_onlineWeekWinText;

		// Token: 0x04006AA9 RID: 27305
		[AutoBind("./Online/DownGroup/WeekWinReward/Button1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_onlineWeekWinRewardButton1GameObject;

		// Token: 0x04006AAA RID: 27306
		[AutoBind("./Online/DownGroup/WeekWinReward/Button2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_onlineWeekWinRewardButton2GameObject;

		// Token: 0x04006AAB RID: 27307
		[AutoBind("./Online/DownGroup/WeekWinReward/Button3", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_onlineWeekWinRewardButton3GameObject;

		// Token: 0x04006AAC RID: 27308
		[AutoBind("./Online/DownGroup/WeekWinReward/BarFrame/Bar", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_onlineWeekWinRewardImage;

		// Token: 0x04006AAD RID: 27309
		[AutoBind("./PromoteBattleTips", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_promoteBattleUIStateController;

		// Token: 0x04006AAE RID: 27310
		[AutoBind("./PromoteBattleTips/BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_promoteBattleBGButton;

		// Token: 0x04006AAF RID: 27311
		[AutoBind("./PromoteBattleTips/Panel/TipsText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_promoteBattleText;

		// Token: 0x04006AB0 RID: 27312
		[AutoBind("./PromoteBattleTips/Panel/ConfirmButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_promoteBattleConfirmButton;

		// Token: 0x04006AB1 RID: 27313
		[AutoBind("./PromoteSucceedTips", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_promoteSucceedUIStateController;

		// Token: 0x04006AB2 RID: 27314
		[AutoBind("./PromoteSucceedTips/BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_promoteSucceedBGButton;

		// Token: 0x04006AB3 RID: 27315
		[AutoBind("./PromoteSucceedTips/Panel/ArenaLevelImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_promoteSucceedDanImage;

		// Token: 0x04006AB4 RID: 27316
		[AutoBind("./PromoteSucceedTips/Panel/Info/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_promoteSucceedDanText;

		// Token: 0x04006AB5 RID: 27317
		[AutoBind("./PromoteSucceedTips/Panel/ConfirmButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_promoteSucceedConfirmButton;

		// Token: 0x04006AB6 RID: 27318
		[AutoBind("./MatchingFailedTips", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_matchingFailedUIStateController;

		// Token: 0x04006AB7 RID: 27319
		[AutoBind("./MatchingFailedTips/BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_matchingFailedBGButton;

		// Token: 0x04006AB8 RID: 27320
		[AutoBind("./MatchingFailedTips/Panel/ConfirmButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_matchingFailedConfirmButton;

		// Token: 0x04006AB9 RID: 27321
		[AutoBind("./MatchingNow", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_matchingNowUIStateController;

		// Token: 0x04006ABA RID: 27322
		[AutoBind("./MatchingNow/Panel/Detail/TimeText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_matchingNowTimeText;

		// Token: 0x04006ABB RID: 27323
		[AutoBind("./MatchingNow/Panel/Detail/PredictTime", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_matchingNowPredictTimeGameObject;

		// Token: 0x04006ABC RID: 27324
		[AutoBind("./MatchingNow/Panel/Detail/PredictTime/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_matchingNowPredictTimeText;

		// Token: 0x04006ABD RID: 27325
		[AutoBind("./MatchingNow/Panel/Detail/CancelButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_matchingNowCancelButton;

		// Token: 0x04006ABE RID: 27326
		private GameObjectPool<ArenaRankingListItemUIController> m_onlineArenaRankingPool;

		// Token: 0x04006ABF RID: 27327
		private GameObjectPool<OnlineArenaBattleReportListItemUIController> m_onlineArenaBattleReportPool;

		// Token: 0x04006AC0 RID: 27328
		private GameObjectPool<ArenaRankingRewardListItemUIController> m_onlineArenaRankingRewardPool;

		// Token: 0x04006AC1 RID: 27329
		private bool m_isMatchingNow;

		// Token: 0x04006AC2 RID: 27330
		[DoNotToLua]
		private ArenaUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04006AC3 RID: 27331
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006AC4 RID: 27332
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006AC5 RID: 27333
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04006AC6 RID: 27334
		private LuaFunction m_OpenArenaUITypeBoolean_hotfix;

		// Token: 0x04006AC7 RID: 27335
		private LuaFunction m_SwitchOfflineOnlineArenaUIType_hotfix;

		// Token: 0x04006AC8 RID: 27336
		private LuaFunction m_SetPlayerHeadIconInt32_hotfix;

		// Token: 0x04006AC9 RID: 27337
		private LuaFunction m_SetPlayerNameString_hotfix;

		// Token: 0x04006ACA RID: 27338
		private LuaFunction m_SetPlayerLevelInt32_hotfix;

		// Token: 0x04006ACB RID: 27339
		private LuaFunction m_SetArenaHonorInt32_hotfix;

		// Token: 0x04006ACC RID: 27340
		private LuaFunction m_SetArenaTicketInt32Int32_hotfix;

		// Token: 0x04006ACD RID: 27341
		private LuaFunction m_SetBattlePowerInt32_hotfix;

		// Token: 0x04006ACE RID: 27342
		private LuaFunction m_ShowArenaTicketDesc_hotfix;

		// Token: 0x04006ACF RID: 27343
		private LuaFunction m_CloseArenaTicketDesc_hotfix;

		// Token: 0x04006AD0 RID: 27344
		private LuaFunction m_CreateSpineGraphicConfigDataJobConnectionInfoConfigDataModelSkinResourceInfo_hotfix;

		// Token: 0x04006AD1 RID: 27345
		private LuaFunction m_AddRewardPreviewGoodsList;

		// Token: 0x04006AD2 RID: 27346
		private LuaFunction m_ShowBuyArenaTicketInt32Int32_hotfix;

		// Token: 0x04006AD3 RID: 27347
		private LuaFunction m_HideBuyArenaTicket_hotfix;

		// Token: 0x04006AD4 RID: 27348
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x04006AD5 RID: 27349
		private LuaFunction m_OnHelpButtonClick_hotfix;

		// Token: 0x04006AD6 RID: 27350
		private LuaFunction m_OnRewardPreviewBackgroundButtonClick_hotfix;

		// Token: 0x04006AD7 RID: 27351
		private LuaFunction m_OnAddArenaTicketButtonClick_hotfix;

		// Token: 0x04006AD8 RID: 27352
		private LuaFunction m_OnBuyArenaTicketBackgroundButtonClick_hotfix;

		// Token: 0x04006AD9 RID: 27353
		private LuaFunction m_OnBuyArenaTicketBuyButtonClick_hotfix;

		// Token: 0x04006ADA RID: 27354
		private LuaFunction m_OnSwitchButtonClick_hotfix;

		// Token: 0x04006ADB RID: 27355
		private LuaFunction m_add_EventOnDefendAction_hotfix;

		// Token: 0x04006ADC RID: 27356
		private LuaFunction m_remove_EventOnDefendAction_hotfix;

		// Token: 0x04006ADD RID: 27357
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x04006ADE RID: 27358
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x04006ADF RID: 27359
		private LuaFunction m_add_EventOnShowHelpAction_hotfix;

		// Token: 0x04006AE0 RID: 27360
		private LuaFunction m_remove_EventOnShowHelpAction_hotfix;

		// Token: 0x04006AE1 RID: 27361
		private LuaFunction m_add_EventOnShowBuyArenaTicketAction_hotfix;

		// Token: 0x04006AE2 RID: 27362
		private LuaFunction m_remove_EventOnShowBuyArenaTicketAction_hotfix;

		// Token: 0x04006AE3 RID: 27363
		private LuaFunction m_add_EventOnBuyArenaTicketAction_hotfix;

		// Token: 0x04006AE4 RID: 27364
		private LuaFunction m_remove_EventOnBuyArenaTicketAction_hotfix;

		// Token: 0x04006AE5 RID: 27365
		private LuaFunction m_add_EventOnSwitchOnlineOfflineAction_hotfix;

		// Token: 0x04006AE6 RID: 27366
		private LuaFunction m_remove_EventOnSwitchOnlineOfflineAction_hotfix;

		// Token: 0x04006AE7 RID: 27367
		private LuaFunction m_OfflineOnBindFiledsCompleted_hotfix;

		// Token: 0x04006AE8 RID: 27368
		private LuaFunction m_SetOfflineArenaPointsAndLevelInt32Int32_hotfix;

		// Token: 0x04006AE9 RID: 27369
		private LuaFunction m_SetOfflineWeekWinInt32Int32_hotfix;

		// Token: 0x04006AEA RID: 27370
		private LuaFunction m_SetOfflineInSettleTimeBoolean_hotfix;

		// Token: 0x04006AEB RID: 27371
		private LuaFunction m_SetOfflineVictoryPointsRewardStatusInt32Int32GainRewardStatus_hotfix;

		// Token: 0x04006AEC RID: 27372
		private LuaFunction m_SetOfflineVictoryPointsRewardProgressInt32Int32_hotfix;

		// Token: 0x04006AED RID: 27373
		private LuaFunction m_SetOfflineArenaOpponentsList;

		// Token: 0x04006AEE RID: 27374
		private LuaFunction m_SetOfflineArenaOpponentsRefreshTimeTimeSpan_hotfix;

		// Token: 0x04006AEF RID: 27375
		private LuaFunction m_SetOfflineArenaBattleReportsList;

		// Token: 0x04006AF0 RID: 27376
		private LuaFunction m_SetOfflineArenaRankingsInt32List;

		// Token: 0x04006AF1 RID: 27377
		private LuaFunction m_ShowOfflinePanelOfflineArenaPanelType_hotfix;

		// Token: 0x04006AF2 RID: 27378
		private LuaFunction m_ShowAutoBattleTips_hotfix;

		// Token: 0x04006AF3 RID: 27379
		private LuaFunction m_HideAutoBattleTips_hotfix;

		// Token: 0x04006AF4 RID: 27380
		private LuaFunction m_ShowArenaOpponentArenaOpponentList;

		// Token: 0x04006AF5 RID: 27381
		private LuaFunction m_HideArenaOpponent_hotfix;

		// Token: 0x04006AF6 RID: 27382
		private LuaFunction m_ClearOpponentGraphcs_hotfix;

		// Token: 0x04006AF7 RID: 27383
		private LuaFunction m_OnOfflineClashToggleBoolean_hotfix;

		// Token: 0x04006AF8 RID: 27384
		private LuaFunction m_OnOfflineBattleReportToggleBoolean_hotfix;

		// Token: 0x04006AF9 RID: 27385
		private LuaFunction m_OnOfflineRankingToggleBoolean_hotfix;

		// Token: 0x04006AFA RID: 27386
		private LuaFunction m_OnOfflineArenaPointRewardButtonClick_hotfix;

		// Token: 0x04006AFB RID: 27387
		private LuaFunction m_OnOfflineArenaPointRewardCloseButtonClick_hotfix;

		// Token: 0x04006AFC RID: 27388
		private LuaFunction m_OnOfflineVictoryPointsRewardButtonClickGainRewardButton_hotfix;

		// Token: 0x04006AFD RID: 27389
		private LuaFunction m_OnOfflineArenaOpponentAttackButtonClickArenaOpponentListItemUIController_hotfix;

		// Token: 0x04006AFE RID: 27390
		private LuaFunction m_OnOfflineBattleReportRevengeButtonClickOfflineArenaBattleReportListItemUIController_hotfix;

		// Token: 0x04006AFF RID: 27391
		private LuaFunction m_OnOfflineBattleReportReplayButtonClickOfflineArenaBattleReportListItemUIController_hotfix;

		// Token: 0x04006B00 RID: 27392
		private LuaFunction m_OnDefendButtonClick_hotfix;

		// Token: 0x04006B01 RID: 27393
		private LuaFunction m_OnAttackConfirmButtonClick_hotfix;

		// Token: 0x04006B02 RID: 27394
		private LuaFunction m_OnAutoBattleButtonClick_hotfix;

		// Token: 0x04006B03 RID: 27395
		private LuaFunction m_OnAttackBackgroundButtonClick_hotfix;

		// Token: 0x04006B04 RID: 27396
		private LuaFunction m_OnAutoBattleTipsConfirmButtonClick_hotfix;

		// Token: 0x04006B05 RID: 27397
		private LuaFunction m_OnAutoBattleTipsCancelButtonClick_hotfix;

		// Token: 0x04006B06 RID: 27398
		private LuaFunction m_add_EventOnShowOfflinePanelAction;

		// Token: 0x04006B07 RID: 27399
		private LuaFunction m_remove_EventOnShowOfflinePanelAction;

		// Token: 0x04006B08 RID: 27400
		private LuaFunction m_add_EventOnGainOfflineVictoryPointsRewardAction;

		// Token: 0x04006B09 RID: 27401
		private LuaFunction m_remove_EventOnGainOfflineVictoryPointsRewardAction;

		// Token: 0x04006B0A RID: 27402
		private LuaFunction m_add_EventOnShowOfflineArenaOpponentAction;

		// Token: 0x04006B0B RID: 27403
		private LuaFunction m_remove_EventOnShowOfflineArenaOpponentAction;

		// Token: 0x04006B0C RID: 27404
		private LuaFunction m_add_EventOnAttackOfflineArenaOpponentAction;

		// Token: 0x04006B0D RID: 27405
		private LuaFunction m_remove_EventOnAttackOfflineArenaOpponentAction;

		// Token: 0x04006B0E RID: 27406
		private LuaFunction m_add_EventOnShowRevengeOfflineArenaOpponentAction;

		// Token: 0x04006B0F RID: 27407
		private LuaFunction m_remove_EventOnShowRevengeOfflineArenaOpponentAction;

		// Token: 0x04006B10 RID: 27408
		private LuaFunction m_add_EventOnRevengeOfflineArenaOpponentAction;

		// Token: 0x04006B11 RID: 27409
		private LuaFunction m_remove_EventOnRevengeOfflineArenaOpponentAction;

		// Token: 0x04006B12 RID: 27410
		private LuaFunction m_add_EventOnOfflineBattleReportReplayAction;

		// Token: 0x04006B13 RID: 27411
		private LuaFunction m_remove_EventOnOfflineBattleReportReplayAction;

		// Token: 0x04006B14 RID: 27412
		private LuaFunction m_OnlineOnBindFiledsCompleted_hotfix;

		// Token: 0x04006B15 RID: 27413
		private LuaFunction m_SetOnlineScoreAndDanInt32Int32_hotfix;

		// Token: 0x04006B16 RID: 27414
		private LuaFunction m_SetLadderModeBooleanBoolean_hotfix;

		// Token: 0x04006B17 RID: 27415
		private LuaFunction m_SetLadderOpenTimeString_hotfix;

		// Token: 0x04006B18 RID: 27416
		private LuaFunction m_SetLadderWeekWinInt32Int32_hotfix;

		// Token: 0x04006B19 RID: 27417
		private LuaFunction m_SetOnlineWeekWinRewardStatusInt32Int32GainRewardStatus_hotfix;

		// Token: 0x04006B1A RID: 27418
		private LuaFunction m_SetOnlineWeekWinRewardProgressInt32Int32_hotfix;

		// Token: 0x04006B1B RID: 27419
		private LuaFunction m_ShowPromoteBattleInt32_hotfix;

		// Token: 0x04006B1C RID: 27420
		private LuaFunction m_ShowPromoteSucceedInt32_hotfix;

		// Token: 0x04006B1D RID: 27421
		private LuaFunction m_SetPromoteBattleStatusInt32List;

		// Token: 0x04006B1E RID: 27422
		private LuaFunction m_SetOnlineDansList;

		// Token: 0x04006B1F RID: 27423
		private LuaFunction m_SetOnlineArenaBattleReportsList;

		// Token: 0x04006B20 RID: 27424
		private LuaFunction m_SetOnlineArenaRankingsInt32List`1List;

		// Token: 0x04006B21 RID: 27425
		private LuaFunction m_ShowGlobalRankingToggleBoolean_hotfix;

		// Token: 0x04006B22 RID: 27426
		private LuaFunction m_ShowOnlinePanelOnlineArenaPanelType_hotfix;

		// Token: 0x04006B23 RID: 27427
		private LuaFunction m_ShowMatchingNow_hotfix;

		// Token: 0x04006B24 RID: 27428
		private LuaFunction m_HideMatchingNow_hotfix;

		// Token: 0x04006B25 RID: 27429
		private LuaFunction m_SetMatchingNowTimeTimeSpan_hotfix;

		// Token: 0x04006B26 RID: 27430
		private LuaFunction m_SetMatchingPredictTimeTimeSpan_hotfix;

		// Token: 0x04006B27 RID: 27431
		private LuaFunction m_IsMatchingNowPredictTimeActive_hotfix;

		// Token: 0x04006B28 RID: 27432
		private LuaFunction m_ShowMatchingFailed_hotfix;

		// Token: 0x04006B29 RID: 27433
		private LuaFunction m_OnOnlineClashToggleBoolean_hotfix;

		// Token: 0x04006B2A RID: 27434
		private LuaFunction m_OnOnlineBattleReportToggleBoolean_hotfix;

		// Token: 0x04006B2B RID: 27435
		private LuaFunction m_OnOnlineDanToggleBoolean_hotfix;

		// Token: 0x04006B2C RID: 27436
		private LuaFunction m_OnOnlineLocalRankingToggleBoolean_hotfix;

		// Token: 0x04006B2D RID: 27437
		private LuaFunction m_OnOnlineGlobalRankingToggleBoolean_hotfix;

		// Token: 0x04006B2E RID: 27438
		private LuaFunction m_OnOnlineWeekWinRewardButtonClickGainRewardButton_hotfix;

		// Token: 0x04006B2F RID: 27439
		private LuaFunction m_OnOnlineBattleReportReplayButtonClickOnlineArenaBattleReportListItemUIController_hotfix;

		// Token: 0x04006B30 RID: 27440
		private LuaFunction m_OnOnlineClashLadderChallengeButtonClick_hotfix;

		// Token: 0x04006B31 RID: 27441
		private LuaFunction m_OnOnlineClashCasualChallengeButtonClick_hotfix;

		// Token: 0x04006B32 RID: 27442
		private LuaFunction m_OnMatchingFailedConfirmButtonClick_hotfix;

		// Token: 0x04006B33 RID: 27443
		private LuaFunction m_OnMatchingNowCancelButtonClick_hotfix;

		// Token: 0x04006B34 RID: 27444
		private LuaFunction m_OnOnlineArenaRankingRewardButtonClick_hotfix;

		// Token: 0x04006B35 RID: 27445
		private LuaFunction m_OnOnlineArenaRankingRewardCloseButtonClick_hotfix;

		// Token: 0x04006B36 RID: 27446
		private LuaFunction m_OnPromoteBattleConfirmButtonClick_hotfix;

		// Token: 0x04006B37 RID: 27447
		private LuaFunction m_OnPromoteSucceedConfirmButtonClick_hotfix;

		// Token: 0x04006B38 RID: 27448
		private LuaFunction m_add_EventOnShowOnlinePanelAction;

		// Token: 0x04006B39 RID: 27449
		private LuaFunction m_remove_EventOnShowOnlinePanelAction;

		// Token: 0x04006B3A RID: 27450
		private LuaFunction m_add_EventOnGainOnlineWeekWinRewardAction;

		// Token: 0x04006B3B RID: 27451
		private LuaFunction m_remove_EventOnGainOnlineWeekWinRewardAction;

		// Token: 0x04006B3C RID: 27452
		private LuaFunction m_add_EventOnOnlineBattleReportReplayAction;

		// Token: 0x04006B3D RID: 27453
		private LuaFunction m_remove_EventOnOnlineBattleReportReplayAction;

		// Token: 0x04006B3E RID: 27454
		private LuaFunction m_add_EventOnLadderChallengeAction_hotfix;

		// Token: 0x04006B3F RID: 27455
		private LuaFunction m_remove_EventOnLadderChallengeAction_hotfix;

		// Token: 0x04006B40 RID: 27456
		private LuaFunction m_add_EventOnCasualChallengeAction_hotfix;

		// Token: 0x04006B41 RID: 27457
		private LuaFunction m_remove_EventOnCasualChallengeAction_hotfix;

		// Token: 0x04006B42 RID: 27458
		private LuaFunction m_add_EventOnMatchingCancelAction_hotfix;

		// Token: 0x04006B43 RID: 27459
		private LuaFunction m_remove_EventOnMatchingCancelAction_hotfix;

		// Token: 0x02000A25 RID: 2597
		public new class LuaExportHelper
		{
			// Token: 0x06009CD0 RID: 40144 RVA: 0x002CCE54 File Offset: 0x002CB054
			public LuaExportHelper(ArenaUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06009CD1 RID: 40145 RVA: 0x002CCE64 File Offset: 0x002CB064
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06009CD2 RID: 40146 RVA: 0x002CCE74 File Offset: 0x002CB074
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06009CD3 RID: 40147 RVA: 0x002CCE84 File Offset: 0x002CB084
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06009CD4 RID: 40148 RVA: 0x002CCE94 File Offset: 0x002CB094
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06009CD5 RID: 40149 RVA: 0x002CCEAC File Offset: 0x002CB0AC
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06009CD6 RID: 40150 RVA: 0x002CCEBC File Offset: 0x002CB0BC
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06009CD7 RID: 40151 RVA: 0x002CCECC File Offset: 0x002CB0CC
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06009CD8 RID: 40152 RVA: 0x002CCEDC File Offset: 0x002CB0DC
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06009CD9 RID: 40153 RVA: 0x002CCEEC File Offset: 0x002CB0EC
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06009CDA RID: 40154 RVA: 0x002CCEFC File Offset: 0x002CB0FC
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06009CDB RID: 40155 RVA: 0x002CCF0C File Offset: 0x002CB10C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06009CDC RID: 40156 RVA: 0x002CCF1C File Offset: 0x002CB11C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06009CDD RID: 40157 RVA: 0x002CCF2C File Offset: 0x002CB12C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06009CDE RID: 40158 RVA: 0x002CCF3C File Offset: 0x002CB13C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06009CDF RID: 40159 RVA: 0x002CCF4C File Offset: 0x002CB14C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06009CE0 RID: 40160 RVA: 0x002CCF5C File Offset: 0x002CB15C
			public void __callDele_EventOnDefend()
			{
				this.m_owner.__callDele_EventOnDefend();
			}

			// Token: 0x06009CE1 RID: 40161 RVA: 0x002CCF6C File Offset: 0x002CB16C
			public void __clearDele_EventOnDefend()
			{
				this.m_owner.__clearDele_EventOnDefend();
			}

			// Token: 0x06009CE2 RID: 40162 RVA: 0x002CCF7C File Offset: 0x002CB17C
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x06009CE3 RID: 40163 RVA: 0x002CCF8C File Offset: 0x002CB18C
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x06009CE4 RID: 40164 RVA: 0x002CCF9C File Offset: 0x002CB19C
			public void __callDele_EventOnShowHelp()
			{
				this.m_owner.__callDele_EventOnShowHelp();
			}

			// Token: 0x06009CE5 RID: 40165 RVA: 0x002CCFAC File Offset: 0x002CB1AC
			public void __clearDele_EventOnShowHelp()
			{
				this.m_owner.__clearDele_EventOnShowHelp();
			}

			// Token: 0x06009CE6 RID: 40166 RVA: 0x002CCFBC File Offset: 0x002CB1BC
			public void __callDele_EventOnShowBuyArenaTicket()
			{
				this.m_owner.__callDele_EventOnShowBuyArenaTicket();
			}

			// Token: 0x06009CE7 RID: 40167 RVA: 0x002CCFCC File Offset: 0x002CB1CC
			public void __clearDele_EventOnShowBuyArenaTicket()
			{
				this.m_owner.__clearDele_EventOnShowBuyArenaTicket();
			}

			// Token: 0x06009CE8 RID: 40168 RVA: 0x002CCFDC File Offset: 0x002CB1DC
			public void __callDele_EventOnBuyArenaTicket()
			{
				this.m_owner.__callDele_EventOnBuyArenaTicket();
			}

			// Token: 0x06009CE9 RID: 40169 RVA: 0x002CCFEC File Offset: 0x002CB1EC
			public void __clearDele_EventOnBuyArenaTicket()
			{
				this.m_owner.__clearDele_EventOnBuyArenaTicket();
			}

			// Token: 0x06009CEA RID: 40170 RVA: 0x002CCFFC File Offset: 0x002CB1FC
			public void __callDele_EventOnSwitchOnlineOffline()
			{
				this.m_owner.__callDele_EventOnSwitchOnlineOffline();
			}

			// Token: 0x06009CEB RID: 40171 RVA: 0x002CD00C File Offset: 0x002CB20C
			public void __clearDele_EventOnSwitchOnlineOffline()
			{
				this.m_owner.__clearDele_EventOnSwitchOnlineOffline();
			}

			// Token: 0x06009CEC RID: 40172 RVA: 0x002CD01C File Offset: 0x002CB21C
			public void __callDele_EventOnShowOfflinePanel(OfflineArenaPanelType obj)
			{
				this.m_owner.__callDele_EventOnShowOfflinePanel(obj);
			}

			// Token: 0x06009CED RID: 40173 RVA: 0x002CD02C File Offset: 0x002CB22C
			public void __clearDele_EventOnShowOfflinePanel(OfflineArenaPanelType obj)
			{
				this.m_owner.__clearDele_EventOnShowOfflinePanel(obj);
			}

			// Token: 0x06009CEE RID: 40174 RVA: 0x002CD03C File Offset: 0x002CB23C
			public void __callDele_EventOnGainOfflineVictoryPointsReward(int obj)
			{
				this.m_owner.__callDele_EventOnGainOfflineVictoryPointsReward(obj);
			}

			// Token: 0x06009CEF RID: 40175 RVA: 0x002CD04C File Offset: 0x002CB24C
			public void __clearDele_EventOnGainOfflineVictoryPointsReward(int obj)
			{
				this.m_owner.__clearDele_EventOnGainOfflineVictoryPointsReward(obj);
			}

			// Token: 0x06009CF0 RID: 40176 RVA: 0x002CD05C File Offset: 0x002CB25C
			public void __callDele_EventOnShowOfflineArenaOpponent(int obj)
			{
				this.m_owner.__callDele_EventOnShowOfflineArenaOpponent(obj);
			}

			// Token: 0x06009CF1 RID: 40177 RVA: 0x002CD06C File Offset: 0x002CB26C
			public void __clearDele_EventOnShowOfflineArenaOpponent(int obj)
			{
				this.m_owner.__clearDele_EventOnShowOfflineArenaOpponent(obj);
			}

			// Token: 0x06009CF2 RID: 40178 RVA: 0x002CD07C File Offset: 0x002CB27C
			public void __callDele_EventOnAttackOfflineArenaOpponent(bool obj)
			{
				this.m_owner.__callDele_EventOnAttackOfflineArenaOpponent(obj);
			}

			// Token: 0x06009CF3 RID: 40179 RVA: 0x002CD08C File Offset: 0x002CB28C
			public void __clearDele_EventOnAttackOfflineArenaOpponent(bool obj)
			{
				this.m_owner.__clearDele_EventOnAttackOfflineArenaOpponent(obj);
			}

			// Token: 0x06009CF4 RID: 40180 RVA: 0x002CD09C File Offset: 0x002CB29C
			public void __callDele_EventOnShowRevengeOfflineArenaOpponent(ArenaBattleReport obj)
			{
				this.m_owner.__callDele_EventOnShowRevengeOfflineArenaOpponent(obj);
			}

			// Token: 0x06009CF5 RID: 40181 RVA: 0x002CD0AC File Offset: 0x002CB2AC
			public void __clearDele_EventOnShowRevengeOfflineArenaOpponent(ArenaBattleReport obj)
			{
				this.m_owner.__clearDele_EventOnShowRevengeOfflineArenaOpponent(obj);
			}

			// Token: 0x06009CF6 RID: 40182 RVA: 0x002CD0BC File Offset: 0x002CB2BC
			public void __callDele_EventOnRevengeOfflineArenaOpponent(bool obj)
			{
				this.m_owner.__callDele_EventOnRevengeOfflineArenaOpponent(obj);
			}

			// Token: 0x06009CF7 RID: 40183 RVA: 0x002CD0CC File Offset: 0x002CB2CC
			public void __clearDele_EventOnRevengeOfflineArenaOpponent(bool obj)
			{
				this.m_owner.__clearDele_EventOnRevengeOfflineArenaOpponent(obj);
			}

			// Token: 0x06009CF8 RID: 40184 RVA: 0x002CD0DC File Offset: 0x002CB2DC
			public void __callDele_EventOnOfflineBattleReportReplay(ArenaBattleReport obj)
			{
				this.m_owner.__callDele_EventOnOfflineBattleReportReplay(obj);
			}

			// Token: 0x06009CF9 RID: 40185 RVA: 0x002CD0EC File Offset: 0x002CB2EC
			public void __clearDele_EventOnOfflineBattleReportReplay(ArenaBattleReport obj)
			{
				this.m_owner.__clearDele_EventOnOfflineBattleReportReplay(obj);
			}

			// Token: 0x06009CFA RID: 40186 RVA: 0x002CD0FC File Offset: 0x002CB2FC
			public void __callDele_EventOnShowOnlinePanel(OnlineArenaPanelType obj)
			{
				this.m_owner.__callDele_EventOnShowOnlinePanel(obj);
			}

			// Token: 0x06009CFB RID: 40187 RVA: 0x002CD10C File Offset: 0x002CB30C
			public void __clearDele_EventOnShowOnlinePanel(OnlineArenaPanelType obj)
			{
				this.m_owner.__clearDele_EventOnShowOnlinePanel(obj);
			}

			// Token: 0x06009CFC RID: 40188 RVA: 0x002CD11C File Offset: 0x002CB31C
			public void __callDele_EventOnGainOnlineWeekWinReward(int obj)
			{
				this.m_owner.__callDele_EventOnGainOnlineWeekWinReward(obj);
			}

			// Token: 0x06009CFD RID: 40189 RVA: 0x002CD12C File Offset: 0x002CB32C
			public void __clearDele_EventOnGainOnlineWeekWinReward(int obj)
			{
				this.m_owner.__clearDele_EventOnGainOnlineWeekWinReward(obj);
			}

			// Token: 0x06009CFE RID: 40190 RVA: 0x002CD13C File Offset: 0x002CB33C
			public void __callDele_EventOnOnlineBattleReportReplay(RealTimePVPBattleReport obj)
			{
				this.m_owner.__callDele_EventOnOnlineBattleReportReplay(obj);
			}

			// Token: 0x06009CFF RID: 40191 RVA: 0x002CD14C File Offset: 0x002CB34C
			public void __clearDele_EventOnOnlineBattleReportReplay(RealTimePVPBattleReport obj)
			{
				this.m_owner.__clearDele_EventOnOnlineBattleReportReplay(obj);
			}

			// Token: 0x06009D00 RID: 40192 RVA: 0x002CD15C File Offset: 0x002CB35C
			public void __callDele_EventOnLadderChallenge()
			{
				this.m_owner.__callDele_EventOnLadderChallenge();
			}

			// Token: 0x06009D01 RID: 40193 RVA: 0x002CD16C File Offset: 0x002CB36C
			public void __clearDele_EventOnLadderChallenge()
			{
				this.m_owner.__clearDele_EventOnLadderChallenge();
			}

			// Token: 0x06009D02 RID: 40194 RVA: 0x002CD17C File Offset: 0x002CB37C
			public void __callDele_EventOnCasualChallenge()
			{
				this.m_owner.__callDele_EventOnCasualChallenge();
			}

			// Token: 0x06009D03 RID: 40195 RVA: 0x002CD18C File Offset: 0x002CB38C
			public void __clearDele_EventOnCasualChallenge()
			{
				this.m_owner.__clearDele_EventOnCasualChallenge();
			}

			// Token: 0x06009D04 RID: 40196 RVA: 0x002CD19C File Offset: 0x002CB39C
			public void __callDele_EventOnMatchingCancel()
			{
				this.m_owner.__callDele_EventOnMatchingCancel();
			}

			// Token: 0x06009D05 RID: 40197 RVA: 0x002CD1AC File Offset: 0x002CB3AC
			public void __clearDele_EventOnMatchingCancel()
			{
				this.m_owner.__clearDele_EventOnMatchingCancel();
			}

			// Token: 0x17001FBB RID: 8123
			// (get) Token: 0x06009D06 RID: 40198 RVA: 0x002CD1BC File Offset: 0x002CB3BC
			// (set) Token: 0x06009D07 RID: 40199 RVA: 0x002CD1CC File Offset: 0x002CB3CC
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

			// Token: 0x17001FBC RID: 8124
			// (get) Token: 0x06009D08 RID: 40200 RVA: 0x002CD1DC File Offset: 0x002CB3DC
			// (set) Token: 0x06009D09 RID: 40201 RVA: 0x002CD1EC File Offset: 0x002CB3EC
			public Button m_returnButton
			{
				get
				{
					return this.m_owner.m_returnButton;
				}
				set
				{
					this.m_owner.m_returnButton = value;
				}
			}

			// Token: 0x17001FBD RID: 8125
			// (get) Token: 0x06009D0A RID: 40202 RVA: 0x002CD1FC File Offset: 0x002CB3FC
			// (set) Token: 0x06009D0B RID: 40203 RVA: 0x002CD20C File Offset: 0x002CB40C
			public Button m_helpButton
			{
				get
				{
					return this.m_owner.m_helpButton;
				}
				set
				{
					this.m_owner.m_helpButton = value;
				}
			}

			// Token: 0x17001FBE RID: 8126
			// (get) Token: 0x06009D0C RID: 40204 RVA: 0x002CD21C File Offset: 0x002CB41C
			// (set) Token: 0x06009D0D RID: 40205 RVA: 0x002CD22C File Offset: 0x002CB42C
			public Text m_offlineArenaCoinText
			{
				get
				{
					return this.m_owner.m_offlineArenaCoinText;
				}
				set
				{
					this.m_owner.m_offlineArenaCoinText = value;
				}
			}

			// Token: 0x17001FBF RID: 8127
			// (get) Token: 0x06009D0E RID: 40206 RVA: 0x002CD23C File Offset: 0x002CB43C
			// (set) Token: 0x06009D0F RID: 40207 RVA: 0x002CD24C File Offset: 0x002CB44C
			public Text m_onlineArenaCoinText
			{
				get
				{
					return this.m_owner.m_onlineArenaCoinText;
				}
				set
				{
					this.m_owner.m_onlineArenaCoinText = value;
				}
			}

			// Token: 0x17001FC0 RID: 8128
			// (get) Token: 0x06009D10 RID: 40208 RVA: 0x002CD25C File Offset: 0x002CB45C
			// (set) Token: 0x06009D11 RID: 40209 RVA: 0x002CD26C File Offset: 0x002CB46C
			public Button m_arenaTicketButton
			{
				get
				{
					return this.m_owner.m_arenaTicketButton;
				}
				set
				{
					this.m_owner.m_arenaTicketButton = value;
				}
			}

			// Token: 0x17001FC1 RID: 8129
			// (get) Token: 0x06009D12 RID: 40210 RVA: 0x002CD27C File Offset: 0x002CB47C
			// (set) Token: 0x06009D13 RID: 40211 RVA: 0x002CD28C File Offset: 0x002CB48C
			public Text m_arenaTicketText
			{
				get
				{
					return this.m_owner.m_arenaTicketText;
				}
				set
				{
					this.m_owner.m_arenaTicketText = value;
				}
			}

			// Token: 0x17001FC2 RID: 8130
			// (get) Token: 0x06009D14 RID: 40212 RVA: 0x002CD29C File Offset: 0x002CB49C
			// (set) Token: 0x06009D15 RID: 40213 RVA: 0x002CD2AC File Offset: 0x002CB4AC
			public Button m_addArenaTicketButton
			{
				get
				{
					return this.m_owner.m_addArenaTicketButton;
				}
				set
				{
					this.m_owner.m_addArenaTicketButton = value;
				}
			}

			// Token: 0x17001FC3 RID: 8131
			// (get) Token: 0x06009D16 RID: 40214 RVA: 0x002CD2BC File Offset: 0x002CB4BC
			// (set) Token: 0x06009D17 RID: 40215 RVA: 0x002CD2CC File Offset: 0x002CB4CC
			public CommonUIStateController m_switchUIStateController
			{
				get
				{
					return this.m_owner.m_switchUIStateController;
				}
				set
				{
					this.m_owner.m_switchUIStateController = value;
				}
			}

			// Token: 0x17001FC4 RID: 8132
			// (get) Token: 0x06009D18 RID: 40216 RVA: 0x002CD2DC File Offset: 0x002CB4DC
			// (set) Token: 0x06009D19 RID: 40217 RVA: 0x002CD2EC File Offset: 0x002CB4EC
			public Button m_switchButton
			{
				get
				{
					return this.m_owner.m_switchButton;
				}
				set
				{
					this.m_owner.m_switchButton = value;
				}
			}

			// Token: 0x17001FC5 RID: 8133
			// (get) Token: 0x06009D1A RID: 40218 RVA: 0x002CD2FC File Offset: 0x002CB4FC
			// (set) Token: 0x06009D1B RID: 40219 RVA: 0x002CD30C File Offset: 0x002CB50C
			public CommonUIStateController m_switchButtonUIStateController
			{
				get
				{
					return this.m_owner.m_switchButtonUIStateController;
				}
				set
				{
					this.m_owner.m_switchButtonUIStateController = value;
				}
			}

			// Token: 0x17001FC6 RID: 8134
			// (get) Token: 0x06009D1C RID: 40220 RVA: 0x002CD31C File Offset: 0x002CB51C
			// (set) Token: 0x06009D1D RID: 40221 RVA: 0x002CD32C File Offset: 0x002CB52C
			public CommonUIStateController m_offlineOnlineChangeUIStateController
			{
				get
				{
					return this.m_owner.m_offlineOnlineChangeUIStateController;
				}
				set
				{
					this.m_owner.m_offlineOnlineChangeUIStateController = value;
				}
			}

			// Token: 0x17001FC7 RID: 8135
			// (get) Token: 0x06009D1E RID: 40222 RVA: 0x002CD33C File Offset: 0x002CB53C
			// (set) Token: 0x06009D1F RID: 40223 RVA: 0x002CD34C File Offset: 0x002CB54C
			public CommonUIStateController m_autoBattleTipsUIStateController
			{
				get
				{
					return this.m_owner.m_autoBattleTipsUIStateController;
				}
				set
				{
					this.m_owner.m_autoBattleTipsUIStateController = value;
				}
			}

			// Token: 0x17001FC8 RID: 8136
			// (get) Token: 0x06009D20 RID: 40224 RVA: 0x002CD35C File Offset: 0x002CB55C
			// (set) Token: 0x06009D21 RID: 40225 RVA: 0x002CD36C File Offset: 0x002CB56C
			public Button m_autoBattleTipsBackgroundButton
			{
				get
				{
					return this.m_owner.m_autoBattleTipsBackgroundButton;
				}
				set
				{
					this.m_owner.m_autoBattleTipsBackgroundButton = value;
				}
			}

			// Token: 0x17001FC9 RID: 8137
			// (get) Token: 0x06009D22 RID: 40226 RVA: 0x002CD37C File Offset: 0x002CB57C
			// (set) Token: 0x06009D23 RID: 40227 RVA: 0x002CD38C File Offset: 0x002CB58C
			public Toggle m_autoBattleTipsShowToggle
			{
				get
				{
					return this.m_owner.m_autoBattleTipsShowToggle;
				}
				set
				{
					this.m_owner.m_autoBattleTipsShowToggle = value;
				}
			}

			// Token: 0x17001FCA RID: 8138
			// (get) Token: 0x06009D24 RID: 40228 RVA: 0x002CD39C File Offset: 0x002CB59C
			// (set) Token: 0x06009D25 RID: 40229 RVA: 0x002CD3AC File Offset: 0x002CB5AC
			public Button m_autoBattleTipsConfirmButton
			{
				get
				{
					return this.m_owner.m_autoBattleTipsConfirmButton;
				}
				set
				{
					this.m_owner.m_autoBattleTipsConfirmButton = value;
				}
			}

			// Token: 0x17001FCB RID: 8139
			// (get) Token: 0x06009D26 RID: 40230 RVA: 0x002CD3BC File Offset: 0x002CB5BC
			// (set) Token: 0x06009D27 RID: 40231 RVA: 0x002CD3CC File Offset: 0x002CB5CC
			public Button m_autoBattleTipsCancelButton
			{
				get
				{
					return this.m_owner.m_autoBattleTipsCancelButton;
				}
				set
				{
					this.m_owner.m_autoBattleTipsCancelButton = value;
				}
			}

			// Token: 0x17001FCC RID: 8140
			// (get) Token: 0x06009D28 RID: 40232 RVA: 0x002CD3DC File Offset: 0x002CB5DC
			// (set) Token: 0x06009D29 RID: 40233 RVA: 0x002CD3EC File Offset: 0x002CB5EC
			public CommonUIStateController m_rewardPreviewUIStateController
			{
				get
				{
					return this.m_owner.m_rewardPreviewUIStateController;
				}
				set
				{
					this.m_owner.m_rewardPreviewUIStateController = value;
				}
			}

			// Token: 0x17001FCD RID: 8141
			// (get) Token: 0x06009D2A RID: 40234 RVA: 0x002CD3FC File Offset: 0x002CB5FC
			// (set) Token: 0x06009D2B RID: 40235 RVA: 0x002CD40C File Offset: 0x002CB60C
			public Button m_rewardPreviewBackgroundButton
			{
				get
				{
					return this.m_owner.m_rewardPreviewBackgroundButton;
				}
				set
				{
					this.m_owner.m_rewardPreviewBackgroundButton = value;
				}
			}

			// Token: 0x17001FCE RID: 8142
			// (get) Token: 0x06009D2C RID: 40236 RVA: 0x002CD41C File Offset: 0x002CB61C
			// (set) Token: 0x06009D2D RID: 40237 RVA: 0x002CD42C File Offset: 0x002CB62C
			public ScrollRect m_rewardPreviewScrollRect
			{
				get
				{
					return this.m_owner.m_rewardPreviewScrollRect;
				}
				set
				{
					this.m_owner.m_rewardPreviewScrollRect = value;
				}
			}

			// Token: 0x17001FCF RID: 8143
			// (get) Token: 0x06009D2E RID: 40238 RVA: 0x002CD43C File Offset: 0x002CB63C
			// (set) Token: 0x06009D2F RID: 40239 RVA: 0x002CD44C File Offset: 0x002CB64C
			public GameObject m_arenaTicketDescGameObject
			{
				get
				{
					return this.m_owner.m_arenaTicketDescGameObject;
				}
				set
				{
					this.m_owner.m_arenaTicketDescGameObject = value;
				}
			}

			// Token: 0x17001FD0 RID: 8144
			// (get) Token: 0x06009D30 RID: 40240 RVA: 0x002CD45C File Offset: 0x002CB65C
			// (set) Token: 0x06009D31 RID: 40241 RVA: 0x002CD46C File Offset: 0x002CB66C
			public CommonUIStateController m_arenaTicketDescUIStateCtrl
			{
				get
				{
					return this.m_owner.m_arenaTicketDescUIStateCtrl;
				}
				set
				{
					this.m_owner.m_arenaTicketDescUIStateCtrl = value;
				}
			}

			// Token: 0x17001FD1 RID: 8145
			// (get) Token: 0x06009D32 RID: 40242 RVA: 0x002CD47C File Offset: 0x002CB67C
			// (set) Token: 0x06009D33 RID: 40243 RVA: 0x002CD48C File Offset: 0x002CB68C
			public Button m_arenaTicketDescBackgroundButton
			{
				get
				{
					return this.m_owner.m_arenaTicketDescBackgroundButton;
				}
				set
				{
					this.m_owner.m_arenaTicketDescBackgroundButton = value;
				}
			}

			// Token: 0x17001FD2 RID: 8146
			// (get) Token: 0x06009D34 RID: 40244 RVA: 0x002CD49C File Offset: 0x002CB69C
			// (set) Token: 0x06009D35 RID: 40245 RVA: 0x002CD4AC File Offset: 0x002CB6AC
			public CommonUIStateController m_buyArenaTicketUIStateController
			{
				get
				{
					return this.m_owner.m_buyArenaTicketUIStateController;
				}
				set
				{
					this.m_owner.m_buyArenaTicketUIStateController = value;
				}
			}

			// Token: 0x17001FD3 RID: 8147
			// (get) Token: 0x06009D36 RID: 40246 RVA: 0x002CD4BC File Offset: 0x002CB6BC
			// (set) Token: 0x06009D37 RID: 40247 RVA: 0x002CD4CC File Offset: 0x002CB6CC
			public Button m_buyArenaTicketBackgroundButton
			{
				get
				{
					return this.m_owner.m_buyArenaTicketBackgroundButton;
				}
				set
				{
					this.m_owner.m_buyArenaTicketBackgroundButton = value;
				}
			}

			// Token: 0x17001FD4 RID: 8148
			// (get) Token: 0x06009D38 RID: 40248 RVA: 0x002CD4DC File Offset: 0x002CB6DC
			// (set) Token: 0x06009D39 RID: 40249 RVA: 0x002CD4EC File Offset: 0x002CB6EC
			public Text m_buyArenaTicketCountText
			{
				get
				{
					return this.m_owner.m_buyArenaTicketCountText;
				}
				set
				{
					this.m_owner.m_buyArenaTicketCountText = value;
				}
			}

			// Token: 0x17001FD5 RID: 8149
			// (get) Token: 0x06009D3A RID: 40250 RVA: 0x002CD4FC File Offset: 0x002CB6FC
			// (set) Token: 0x06009D3B RID: 40251 RVA: 0x002CD50C File Offset: 0x002CB70C
			public Button m_buyArenaTicketBuyButton
			{
				get
				{
					return this.m_owner.m_buyArenaTicketBuyButton;
				}
				set
				{
					this.m_owner.m_buyArenaTicketBuyButton = value;
				}
			}

			// Token: 0x17001FD6 RID: 8150
			// (get) Token: 0x06009D3C RID: 40252 RVA: 0x002CD51C File Offset: 0x002CB71C
			// (set) Token: 0x06009D3D RID: 40253 RVA: 0x002CD52C File Offset: 0x002CB72C
			public Text m_buyArenaTicketPriceText
			{
				get
				{
					return this.m_owner.m_buyArenaTicketPriceText;
				}
				set
				{
					this.m_owner.m_buyArenaTicketPriceText = value;
				}
			}

			// Token: 0x17001FD7 RID: 8151
			// (get) Token: 0x06009D3E RID: 40254 RVA: 0x002CD53C File Offset: 0x002CB73C
			// (set) Token: 0x06009D3F RID: 40255 RVA: 0x002CD54C File Offset: 0x002CB74C
			public CommonUIStateController m_offineArenaPointRewardUIStateCtrl
			{
				get
				{
					return this.m_owner.m_offineArenaPointRewardUIStateCtrl;
				}
				set
				{
					this.m_owner.m_offineArenaPointRewardUIStateCtrl = value;
				}
			}

			// Token: 0x17001FD8 RID: 8152
			// (get) Token: 0x06009D40 RID: 40256 RVA: 0x002CD55C File Offset: 0x002CB75C
			// (set) Token: 0x06009D41 RID: 40257 RVA: 0x002CD56C File Offset: 0x002CB76C
			public Button m_offlineArenaPointRewardBGButton
			{
				get
				{
					return this.m_owner.m_offlineArenaPointRewardBGButton;
				}
				set
				{
					this.m_owner.m_offlineArenaPointRewardBGButton = value;
				}
			}

			// Token: 0x17001FD9 RID: 8153
			// (get) Token: 0x06009D42 RID: 40258 RVA: 0x002CD57C File Offset: 0x002CB77C
			// (set) Token: 0x06009D43 RID: 40259 RVA: 0x002CD58C File Offset: 0x002CB78C
			public Button m_offlineArenaPointRewardCloseButton
			{
				get
				{
					return this.m_owner.m_offlineArenaPointRewardCloseButton;
				}
				set
				{
					this.m_owner.m_offlineArenaPointRewardCloseButton = value;
				}
			}

			// Token: 0x17001FDA RID: 8154
			// (get) Token: 0x06009D44 RID: 40260 RVA: 0x002CD59C File Offset: 0x002CB79C
			// (set) Token: 0x06009D45 RID: 40261 RVA: 0x002CD5AC File Offset: 0x002CB7AC
			public ScrollRect m_offlineArenaPointRewardScrollRect
			{
				get
				{
					return this.m_owner.m_offlineArenaPointRewardScrollRect;
				}
				set
				{
					this.m_owner.m_offlineArenaPointRewardScrollRect = value;
				}
			}

			// Token: 0x17001FDB RID: 8155
			// (get) Token: 0x06009D46 RID: 40262 RVA: 0x002CD5BC File Offset: 0x002CB7BC
			// (set) Token: 0x06009D47 RID: 40263 RVA: 0x002CD5CC File Offset: 0x002CB7CC
			public CommonUIStateController m_onlineArenaRankingRewardUIStateCtrl
			{
				get
				{
					return this.m_owner.m_onlineArenaRankingRewardUIStateCtrl;
				}
				set
				{
					this.m_owner.m_onlineArenaRankingRewardUIStateCtrl = value;
				}
			}

			// Token: 0x17001FDC RID: 8156
			// (get) Token: 0x06009D48 RID: 40264 RVA: 0x002CD5DC File Offset: 0x002CB7DC
			// (set) Token: 0x06009D49 RID: 40265 RVA: 0x002CD5EC File Offset: 0x002CB7EC
			public Button m_onlineArenaRankingRewardBGButton
			{
				get
				{
					return this.m_owner.m_onlineArenaRankingRewardBGButton;
				}
				set
				{
					this.m_owner.m_onlineArenaRankingRewardBGButton = value;
				}
			}

			// Token: 0x17001FDD RID: 8157
			// (get) Token: 0x06009D4A RID: 40266 RVA: 0x002CD5FC File Offset: 0x002CB7FC
			// (set) Token: 0x06009D4B RID: 40267 RVA: 0x002CD60C File Offset: 0x002CB80C
			public Button m_onlineArenaRankingRewardCloseButton
			{
				get
				{
					return this.m_owner.m_onlineArenaRankingRewardCloseButton;
				}
				set
				{
					this.m_owner.m_onlineArenaRankingRewardCloseButton = value;
				}
			}

			// Token: 0x17001FDE RID: 8158
			// (get) Token: 0x06009D4C RID: 40268 RVA: 0x002CD61C File Offset: 0x002CB81C
			// (set) Token: 0x06009D4D RID: 40269 RVA: 0x002CD62C File Offset: 0x002CB82C
			public ScrollRect m_onlineArenaRankingRewardscrollRect
			{
				get
				{
					return this.m_owner.m_onlineArenaRankingRewardscrollRect;
				}
				set
				{
					this.m_owner.m_onlineArenaRankingRewardscrollRect = value;
				}
			}

			// Token: 0x17001FDF RID: 8159
			// (get) Token: 0x06009D4E RID: 40270 RVA: 0x002CD63C File Offset: 0x002CB83C
			// (set) Token: 0x06009D4F RID: 40271 RVA: 0x002CD64C File Offset: 0x002CB84C
			public CommonUIStateController m_attackUIStateController
			{
				get
				{
					return this.m_owner.m_attackUIStateController;
				}
				set
				{
					this.m_owner.m_attackUIStateController = value;
				}
			}

			// Token: 0x17001FE0 RID: 8160
			// (get) Token: 0x06009D50 RID: 40272 RVA: 0x002CD65C File Offset: 0x002CB85C
			// (set) Token: 0x06009D51 RID: 40273 RVA: 0x002CD66C File Offset: 0x002CB86C
			public Button m_attackBackgroundButton
			{
				get
				{
					return this.m_owner.m_attackBackgroundButton;
				}
				set
				{
					this.m_owner.m_attackBackgroundButton = value;
				}
			}

			// Token: 0x17001FE1 RID: 8161
			// (get) Token: 0x06009D52 RID: 40274 RVA: 0x002CD67C File Offset: 0x002CB87C
			// (set) Token: 0x06009D53 RID: 40275 RVA: 0x002CD68C File Offset: 0x002CB88C
			public Text m_attackBattlePowerText
			{
				get
				{
					return this.m_owner.m_attackBattlePowerText;
				}
				set
				{
					this.m_owner.m_attackBattlePowerText = value;
				}
			}

			// Token: 0x17001FE2 RID: 8162
			// (get) Token: 0x06009D54 RID: 40276 RVA: 0x002CD69C File Offset: 0x002CB89C
			// (set) Token: 0x06009D55 RID: 40277 RVA: 0x002CD6AC File Offset: 0x002CB8AC
			public Button m_attackConfirmButton
			{
				get
				{
					return this.m_owner.m_attackConfirmButton;
				}
				set
				{
					this.m_owner.m_attackConfirmButton = value;
				}
			}

			// Token: 0x17001FE3 RID: 8163
			// (get) Token: 0x06009D56 RID: 40278 RVA: 0x002CD6BC File Offset: 0x002CB8BC
			// (set) Token: 0x06009D57 RID: 40279 RVA: 0x002CD6CC File Offset: 0x002CB8CC
			public Button m_attackAutoConfirmButton
			{
				get
				{
					return this.m_owner.m_attackAutoConfirmButton;
				}
				set
				{
					this.m_owner.m_attackAutoConfirmButton = value;
				}
			}

			// Token: 0x17001FE4 RID: 8164
			// (get) Token: 0x06009D58 RID: 40280 RVA: 0x002CD6DC File Offset: 0x002CB8DC
			// (set) Token: 0x06009D59 RID: 40281 RVA: 0x002CD6EC File Offset: 0x002CB8EC
			public GameObject m_attackGraphicsGameObject
			{
				get
				{
					return this.m_owner.m_attackGraphicsGameObject;
				}
				set
				{
					this.m_owner.m_attackGraphicsGameObject = value;
				}
			}

			// Token: 0x17001FE5 RID: 8165
			// (get) Token: 0x06009D5A RID: 40282 RVA: 0x002CD6FC File Offset: 0x002CB8FC
			// (set) Token: 0x06009D5B RID: 40283 RVA: 0x002CD70C File Offset: 0x002CB90C
			public Image m_attackPlayerIconImage
			{
				get
				{
					return this.m_owner.m_attackPlayerIconImage;
				}
				set
				{
					this.m_owner.m_attackPlayerIconImage = value;
				}
			}

			// Token: 0x17001FE6 RID: 8166
			// (get) Token: 0x06009D5C RID: 40284 RVA: 0x002CD71C File Offset: 0x002CB91C
			// (set) Token: 0x06009D5D RID: 40285 RVA: 0x002CD72C File Offset: 0x002CB92C
			public Text m_attackPlayerNameText
			{
				get
				{
					return this.m_owner.m_attackPlayerNameText;
				}
				set
				{
					this.m_owner.m_attackPlayerNameText = value;
				}
			}

			// Token: 0x17001FE7 RID: 8167
			// (get) Token: 0x06009D5E RID: 40286 RVA: 0x002CD73C File Offset: 0x002CB93C
			// (set) Token: 0x06009D5F RID: 40287 RVA: 0x002CD74C File Offset: 0x002CB94C
			public Text m_attackPlayerLVText
			{
				get
				{
					return this.m_owner.m_attackPlayerLVText;
				}
				set
				{
					this.m_owner.m_attackPlayerLVText = value;
				}
			}

			// Token: 0x17001FE8 RID: 8168
			// (get) Token: 0x06009D60 RID: 40288 RVA: 0x002CD75C File Offset: 0x002CB95C
			// (set) Token: 0x06009D61 RID: 40289 RVA: 0x002CD76C File Offset: 0x002CB96C
			public Text m_attackPlayerArenaPointText
			{
				get
				{
					return this.m_owner.m_attackPlayerArenaPointText;
				}
				set
				{
					this.m_owner.m_attackPlayerArenaPointText = value;
				}
			}

			// Token: 0x17001FE9 RID: 8169
			// (get) Token: 0x06009D62 RID: 40290 RVA: 0x002CD77C File Offset: 0x002CB97C
			// (set) Token: 0x06009D63 RID: 40291 RVA: 0x002CD78C File Offset: 0x002CB98C
			public GameObject m_prefabsGameObject
			{
				get
				{
					return this.m_owner.m_prefabsGameObject;
				}
				set
				{
					this.m_owner.m_prefabsGameObject = value;
				}
			}

			// Token: 0x17001FEA RID: 8170
			// (get) Token: 0x06009D64 RID: 40292 RVA: 0x002CD79C File Offset: 0x002CB99C
			// (set) Token: 0x06009D65 RID: 40293 RVA: 0x002CD7AC File Offset: 0x002CB9AC
			public GameObject m_arenaLevelListItemPrefab
			{
				get
				{
					return this.m_owner.m_arenaLevelListItemPrefab;
				}
				set
				{
					this.m_owner.m_arenaLevelListItemPrefab = value;
				}
			}

			// Token: 0x17001FEB RID: 8171
			// (get) Token: 0x06009D66 RID: 40294 RVA: 0x002CD7BC File Offset: 0x002CB9BC
			// (set) Token: 0x06009D67 RID: 40295 RVA: 0x002CD7CC File Offset: 0x002CB9CC
			public GameObject m_arenaRankingListItemPrefab
			{
				get
				{
					return this.m_owner.m_arenaRankingListItemPrefab;
				}
				set
				{
					this.m_owner.m_arenaRankingListItemPrefab = value;
				}
			}

			// Token: 0x17001FEC RID: 8172
			// (get) Token: 0x06009D68 RID: 40296 RVA: 0x002CD7DC File Offset: 0x002CB9DC
			// (set) Token: 0x06009D69 RID: 40297 RVA: 0x002CD7EC File Offset: 0x002CB9EC
			public GameObject m_offlineArenaBattleReportListItemPrefab
			{
				get
				{
					return this.m_owner.m_offlineArenaBattleReportListItemPrefab;
				}
				set
				{
					this.m_owner.m_offlineArenaBattleReportListItemPrefab = value;
				}
			}

			// Token: 0x17001FED RID: 8173
			// (get) Token: 0x06009D6A RID: 40298 RVA: 0x002CD7FC File Offset: 0x002CB9FC
			// (set) Token: 0x06009D6B RID: 40299 RVA: 0x002CD80C File Offset: 0x002CBA0C
			public GameObject m_arenaOpponentListItemPrefab
			{
				get
				{
					return this.m_owner.m_arenaOpponentListItemPrefab;
				}
				set
				{
					this.m_owner.m_arenaOpponentListItemPrefab = value;
				}
			}

			// Token: 0x17001FEE RID: 8174
			// (get) Token: 0x06009D6C RID: 40300 RVA: 0x002CD81C File Offset: 0x002CBA1C
			// (set) Token: 0x06009D6D RID: 40301 RVA: 0x002CD82C File Offset: 0x002CBA2C
			public GameObject m_arenaPointRewardListItemPrefab
			{
				get
				{
					return this.m_owner.m_arenaPointRewardListItemPrefab;
				}
				set
				{
					this.m_owner.m_arenaPointRewardListItemPrefab = value;
				}
			}

			// Token: 0x17001FEF RID: 8175
			// (get) Token: 0x06009D6E RID: 40302 RVA: 0x002CD83C File Offset: 0x002CBA3C
			// (set) Token: 0x06009D6F RID: 40303 RVA: 0x002CD84C File Offset: 0x002CBA4C
			public GameObject m_onlineArenaBattleReportListItemPrefab
			{
				get
				{
					return this.m_owner.m_onlineArenaBattleReportListItemPrefab;
				}
				set
				{
					this.m_owner.m_onlineArenaBattleReportListItemPrefab = value;
				}
			}

			// Token: 0x17001FF0 RID: 8176
			// (get) Token: 0x06009D70 RID: 40304 RVA: 0x002CD85C File Offset: 0x002CBA5C
			// (set) Token: 0x06009D71 RID: 40305 RVA: 0x002CD86C File Offset: 0x002CBA6C
			public bool m_isIgnoreToggleEvent
			{
				get
				{
					return this.m_owner.m_isIgnoreToggleEvent;
				}
				set
				{
					this.m_owner.m_isIgnoreToggleEvent = value;
				}
			}

			// Token: 0x17001FF1 RID: 8177
			// (get) Token: 0x06009D72 RID: 40306 RVA: 0x002CD87C File Offset: 0x002CBA7C
			// (set) Token: 0x06009D73 RID: 40307 RVA: 0x002CD88C File Offset: 0x002CBA8C
			public bool m_isRevengeOpponent
			{
				get
				{
					return this.m_owner.m_isRevengeOpponent;
				}
				set
				{
					this.m_owner.m_isRevengeOpponent = value;
				}
			}

			// Token: 0x17001FF2 RID: 8178
			// (get) Token: 0x06009D74 RID: 40308 RVA: 0x002CD89C File Offset: 0x002CBA9C
			// (set) Token: 0x06009D75 RID: 40309 RVA: 0x002CD8A4 File Offset: 0x002CBAA4
			public static bool s_isShowAutoBattleTips
			{
				get
				{
					return ArenaUIController.s_isShowAutoBattleTips;
				}
				set
				{
					ArenaUIController.s_isShowAutoBattleTips = value;
				}
			}

			// Token: 0x17001FF3 RID: 8179
			// (get) Token: 0x06009D76 RID: 40310 RVA: 0x002CD8AC File Offset: 0x002CBAAC
			// (set) Token: 0x06009D77 RID: 40311 RVA: 0x002CD8BC File Offset: 0x002CBABC
			public GainRewardButton[] m_offlineVictoryPointsRewardButtons
			{
				get
				{
					return this.m_owner.m_offlineVictoryPointsRewardButtons;
				}
				set
				{
					this.m_owner.m_offlineVictoryPointsRewardButtons = value;
				}
			}

			// Token: 0x17001FF4 RID: 8180
			// (get) Token: 0x06009D78 RID: 40312 RVA: 0x002CD8CC File Offset: 0x002CBACC
			// (set) Token: 0x06009D79 RID: 40313 RVA: 0x002CD8DC File Offset: 0x002CBADC
			public GainRewardButton[] m_onlineWeekWinRewardButtons
			{
				get
				{
					return this.m_owner.m_onlineWeekWinRewardButtons;
				}
				set
				{
					this.m_owner.m_onlineWeekWinRewardButtons = value;
				}
			}

			// Token: 0x17001FF5 RID: 8181
			// (get) Token: 0x06009D7A RID: 40314 RVA: 0x002CD8EC File Offset: 0x002CBAEC
			// (set) Token: 0x06009D7B RID: 40315 RVA: 0x002CD8FC File Offset: 0x002CBAFC
			public GameObjectPool<ArenaLevelListItemUIController> m_onlineArenaLevelPool
			{
				get
				{
					return this.m_owner.m_onlineArenaLevelPool;
				}
				set
				{
					this.m_owner.m_onlineArenaLevelPool = value;
				}
			}

			// Token: 0x17001FF6 RID: 8182
			// (get) Token: 0x06009D7C RID: 40316 RVA: 0x002CD90C File Offset: 0x002CBB0C
			// (set) Token: 0x06009D7D RID: 40317 RVA: 0x002CD91C File Offset: 0x002CBB1C
			public List<UISpineGraphic> m_opponentGraphics
			{
				get
				{
					return this.m_owner.m_opponentGraphics;
				}
				set
				{
					this.m_owner.m_opponentGraphics = value;
				}
			}

			// Token: 0x17001FF7 RID: 8183
			// (get) Token: 0x06009D7E RID: 40318 RVA: 0x002CD92C File Offset: 0x002CBB2C
			// (set) Token: 0x06009D7F RID: 40319 RVA: 0x002CD93C File Offset: 0x002CBB3C
			public GameObject m_offlineGameObject
			{
				get
				{
					return this.m_owner.m_offlineGameObject;
				}
				set
				{
					this.m_owner.m_offlineGameObject = value;
				}
			}

			// Token: 0x17001FF8 RID: 8184
			// (get) Token: 0x06009D80 RID: 40320 RVA: 0x002CD94C File Offset: 0x002CBB4C
			// (set) Token: 0x06009D81 RID: 40321 RVA: 0x002CD95C File Offset: 0x002CBB5C
			public RectTransform m_offlineMarginTransform
			{
				get
				{
					return this.m_owner.m_offlineMarginTransform;
				}
				set
				{
					this.m_owner.m_offlineMarginTransform = value;
				}
			}

			// Token: 0x17001FF9 RID: 8185
			// (get) Token: 0x06009D82 RID: 40322 RVA: 0x002CD96C File Offset: 0x002CBB6C
			// (set) Token: 0x06009D83 RID: 40323 RVA: 0x002CD97C File Offset: 0x002CBB7C
			public Toggle m_offlineClashToggle
			{
				get
				{
					return this.m_owner.m_offlineClashToggle;
				}
				set
				{
					this.m_owner.m_offlineClashToggle = value;
				}
			}

			// Token: 0x17001FFA RID: 8186
			// (get) Token: 0x06009D84 RID: 40324 RVA: 0x002CD98C File Offset: 0x002CBB8C
			// (set) Token: 0x06009D85 RID: 40325 RVA: 0x002CD99C File Offset: 0x002CBB9C
			public Toggle m_offlineBattleReportToggle
			{
				get
				{
					return this.m_owner.m_offlineBattleReportToggle;
				}
				set
				{
					this.m_owner.m_offlineBattleReportToggle = value;
				}
			}

			// Token: 0x17001FFB RID: 8187
			// (get) Token: 0x06009D86 RID: 40326 RVA: 0x002CD9AC File Offset: 0x002CBBAC
			// (set) Token: 0x06009D87 RID: 40327 RVA: 0x002CD9BC File Offset: 0x002CBBBC
			public Toggle m_offlineRankingToggle
			{
				get
				{
					return this.m_owner.m_offlineRankingToggle;
				}
				set
				{
					this.m_owner.m_offlineRankingToggle = value;
				}
			}

			// Token: 0x17001FFC RID: 8188
			// (get) Token: 0x06009D88 RID: 40328 RVA: 0x002CD9CC File Offset: 0x002CBBCC
			// (set) Token: 0x06009D89 RID: 40329 RVA: 0x002CD9DC File Offset: 0x002CBBDC
			public GameObject m_offlineClashPanelGameObject
			{
				get
				{
					return this.m_owner.m_offlineClashPanelGameObject;
				}
				set
				{
					this.m_owner.m_offlineClashPanelGameObject = value;
				}
			}

			// Token: 0x17001FFD RID: 8189
			// (get) Token: 0x06009D8A RID: 40330 RVA: 0x002CD9EC File Offset: 0x002CBBEC
			// (set) Token: 0x06009D8B RID: 40331 RVA: 0x002CD9FC File Offset: 0x002CBBFC
			public GameObject m_offlineArenaOpponentsGameObject
			{
				get
				{
					return this.m_owner.m_offlineArenaOpponentsGameObject;
				}
				set
				{
					this.m_owner.m_offlineArenaOpponentsGameObject = value;
				}
			}

			// Token: 0x17001FFE RID: 8190
			// (get) Token: 0x06009D8C RID: 40332 RVA: 0x002CDA0C File Offset: 0x002CBC0C
			// (set) Token: 0x06009D8D RID: 40333 RVA: 0x002CDA1C File Offset: 0x002CBC1C
			public GameObject m_offlineInSettleGameObject
			{
				get
				{
					return this.m_owner.m_offlineInSettleGameObject;
				}
				set
				{
					this.m_owner.m_offlineInSettleGameObject = value;
				}
			}

			// Token: 0x17001FFF RID: 8191
			// (get) Token: 0x06009D8E RID: 40334 RVA: 0x002CDA2C File Offset: 0x002CBC2C
			// (set) Token: 0x06009D8F RID: 40335 RVA: 0x002CDA3C File Offset: 0x002CBC3C
			public Text m_offlineArenaOpponentsRefreshTimeText
			{
				get
				{
					return this.m_owner.m_offlineArenaOpponentsRefreshTimeText;
				}
				set
				{
					this.m_owner.m_offlineArenaOpponentsRefreshTimeText = value;
				}
			}

			// Token: 0x17002000 RID: 8192
			// (get) Token: 0x06009D90 RID: 40336 RVA: 0x002CDA4C File Offset: 0x002CBC4C
			// (set) Token: 0x06009D91 RID: 40337 RVA: 0x002CDA5C File Offset: 0x002CBC5C
			public GameObject m_offlineBattleReportPanelGameObject
			{
				get
				{
					return this.m_owner.m_offlineBattleReportPanelGameObject;
				}
				set
				{
					this.m_owner.m_offlineBattleReportPanelGameObject = value;
				}
			}

			// Token: 0x17002001 RID: 8193
			// (get) Token: 0x06009D92 RID: 40338 RVA: 0x002CDA6C File Offset: 0x002CBC6C
			// (set) Token: 0x06009D93 RID: 40339 RVA: 0x002CDA7C File Offset: 0x002CBC7C
			public ScrollRect m_offlineBattleReportScrollRect
			{
				get
				{
					return this.m_owner.m_offlineBattleReportScrollRect;
				}
				set
				{
					this.m_owner.m_offlineBattleReportScrollRect = value;
				}
			}

			// Token: 0x17002002 RID: 8194
			// (get) Token: 0x06009D94 RID: 40340 RVA: 0x002CDA8C File Offset: 0x002CBC8C
			// (set) Token: 0x06009D95 RID: 40341 RVA: 0x002CDA9C File Offset: 0x002CBC9C
			public GameObject m_offlineNoBattleReportGameObject
			{
				get
				{
					return this.m_owner.m_offlineNoBattleReportGameObject;
				}
				set
				{
					this.m_owner.m_offlineNoBattleReportGameObject = value;
				}
			}

			// Token: 0x17002003 RID: 8195
			// (get) Token: 0x06009D96 RID: 40342 RVA: 0x002CDAAC File Offset: 0x002CBCAC
			// (set) Token: 0x06009D97 RID: 40343 RVA: 0x002CDABC File Offset: 0x002CBCBC
			public GameObject m_offlineRankingPanelGameObject
			{
				get
				{
					return this.m_owner.m_offlineRankingPanelGameObject;
				}
				set
				{
					this.m_owner.m_offlineRankingPanelGameObject = value;
				}
			}

			// Token: 0x17002004 RID: 8196
			// (get) Token: 0x06009D98 RID: 40344 RVA: 0x002CDACC File Offset: 0x002CBCCC
			// (set) Token: 0x06009D99 RID: 40345 RVA: 0x002CDADC File Offset: 0x002CBCDC
			public ScrollRect m_offlineRankingScrollRect
			{
				get
				{
					return this.m_owner.m_offlineRankingScrollRect;
				}
				set
				{
					this.m_owner.m_offlineRankingScrollRect = value;
				}
			}

			// Token: 0x17002005 RID: 8197
			// (get) Token: 0x06009D9A RID: 40346 RVA: 0x002CDAEC File Offset: 0x002CBCEC
			// (set) Token: 0x06009D9B RID: 40347 RVA: 0x002CDAFC File Offset: 0x002CBCFC
			public Text m_offlineRankingPlayerNameText
			{
				get
				{
					return this.m_owner.m_offlineRankingPlayerNameText;
				}
				set
				{
					this.m_owner.m_offlineRankingPlayerNameText = value;
				}
			}

			// Token: 0x17002006 RID: 8198
			// (get) Token: 0x06009D9C RID: 40348 RVA: 0x002CDB0C File Offset: 0x002CBD0C
			// (set) Token: 0x06009D9D RID: 40349 RVA: 0x002CDB1C File Offset: 0x002CBD1C
			public CommonUIStateController m_offlineRankingPlayerRankingUIStateController
			{
				get
				{
					return this.m_owner.m_offlineRankingPlayerRankingUIStateController;
				}
				set
				{
					this.m_owner.m_offlineRankingPlayerRankingUIStateController = value;
				}
			}

			// Token: 0x17002007 RID: 8199
			// (get) Token: 0x06009D9E RID: 40350 RVA: 0x002CDB2C File Offset: 0x002CBD2C
			// (set) Token: 0x06009D9F RID: 40351 RVA: 0x002CDB3C File Offset: 0x002CBD3C
			public Text m_offlineRankingPlayerRankingText
			{
				get
				{
					return this.m_owner.m_offlineRankingPlayerRankingText;
				}
				set
				{
					this.m_owner.m_offlineRankingPlayerRankingText = value;
				}
			}

			// Token: 0x17002008 RID: 8200
			// (get) Token: 0x06009DA0 RID: 40352 RVA: 0x002CDB4C File Offset: 0x002CBD4C
			// (set) Token: 0x06009DA1 RID: 40353 RVA: 0x002CDB5C File Offset: 0x002CBD5C
			public Image m_offlineRankingPlayerRankingImage
			{
				get
				{
					return this.m_owner.m_offlineRankingPlayerRankingImage;
				}
				set
				{
					this.m_owner.m_offlineRankingPlayerRankingImage = value;
				}
			}

			// Token: 0x17002009 RID: 8201
			// (get) Token: 0x06009DA2 RID: 40354 RVA: 0x002CDB6C File Offset: 0x002CBD6C
			// (set) Token: 0x06009DA3 RID: 40355 RVA: 0x002CDB7C File Offset: 0x002CBD7C
			public Text m_offlineRankingArenaPointsText
			{
				get
				{
					return this.m_owner.m_offlineRankingArenaPointsText;
				}
				set
				{
					this.m_owner.m_offlineRankingArenaPointsText = value;
				}
			}

			// Token: 0x1700200A RID: 8202
			// (get) Token: 0x06009DA4 RID: 40356 RVA: 0x002CDB8C File Offset: 0x002CBD8C
			// (set) Token: 0x06009DA5 RID: 40357 RVA: 0x002CDB9C File Offset: 0x002CBD9C
			public Image m_offlineRankingPlayerIconImage
			{
				get
				{
					return this.m_owner.m_offlineRankingPlayerIconImage;
				}
				set
				{
					this.m_owner.m_offlineRankingPlayerIconImage = value;
				}
			}

			// Token: 0x1700200B RID: 8203
			// (get) Token: 0x06009DA6 RID: 40358 RVA: 0x002CDBAC File Offset: 0x002CBDAC
			// (set) Token: 0x06009DA7 RID: 40359 RVA: 0x002CDBBC File Offset: 0x002CBDBC
			public Transform m_offlineRankingPlayerHeadFrameTransform
			{
				get
				{
					return this.m_owner.m_offlineRankingPlayerHeadFrameTransform;
				}
				set
				{
					this.m_owner.m_offlineRankingPlayerHeadFrameTransform = value;
				}
			}

			// Token: 0x1700200C RID: 8204
			// (get) Token: 0x06009DA8 RID: 40360 RVA: 0x002CDBCC File Offset: 0x002CBDCC
			// (set) Token: 0x06009DA9 RID: 40361 RVA: 0x002CDBDC File Offset: 0x002CBDDC
			public Text m_offlineRankingPlayerLevelText
			{
				get
				{
					return this.m_owner.m_offlineRankingPlayerLevelText;
				}
				set
				{
					this.m_owner.m_offlineRankingPlayerLevelText = value;
				}
			}

			// Token: 0x1700200D RID: 8205
			// (get) Token: 0x06009DAA RID: 40362 RVA: 0x002CDBEC File Offset: 0x002CBDEC
			// (set) Token: 0x06009DAB RID: 40363 RVA: 0x002CDBFC File Offset: 0x002CBDFC
			public Image m_offlinePlayerIconImage
			{
				get
				{
					return this.m_owner.m_offlinePlayerIconImage;
				}
				set
				{
					this.m_owner.m_offlinePlayerIconImage = value;
				}
			}

			// Token: 0x1700200E RID: 8206
			// (get) Token: 0x06009DAC RID: 40364 RVA: 0x002CDC0C File Offset: 0x002CBE0C
			// (set) Token: 0x06009DAD RID: 40365 RVA: 0x002CDC1C File Offset: 0x002CBE1C
			public Text m_offlinePlayerNameText
			{
				get
				{
					return this.m_owner.m_offlinePlayerNameText;
				}
				set
				{
					this.m_owner.m_offlinePlayerNameText = value;
				}
			}

			// Token: 0x1700200F RID: 8207
			// (get) Token: 0x06009DAE RID: 40366 RVA: 0x002CDC2C File Offset: 0x002CBE2C
			// (set) Token: 0x06009DAF RID: 40367 RVA: 0x002CDC3C File Offset: 0x002CBE3C
			public Text m_offlinePlayerLevelText
			{
				get
				{
					return this.m_owner.m_offlinePlayerLevelText;
				}
				set
				{
					this.m_owner.m_offlinePlayerLevelText = value;
				}
			}

			// Token: 0x17002010 RID: 8208
			// (get) Token: 0x06009DB0 RID: 40368 RVA: 0x002CDC4C File Offset: 0x002CBE4C
			// (set) Token: 0x06009DB1 RID: 40369 RVA: 0x002CDC5C File Offset: 0x002CBE5C
			public Text m_offlinePlayerBattlePowerText
			{
				get
				{
					return this.m_owner.m_offlinePlayerBattlePowerText;
				}
				set
				{
					this.m_owner.m_offlinePlayerBattlePowerText = value;
				}
			}

			// Token: 0x17002011 RID: 8209
			// (get) Token: 0x06009DB2 RID: 40370 RVA: 0x002CDC6C File Offset: 0x002CBE6C
			// (set) Token: 0x06009DB3 RID: 40371 RVA: 0x002CDC7C File Offset: 0x002CBE7C
			public Text m_offlineArenaPointsText
			{
				get
				{
					return this.m_owner.m_offlineArenaPointsText;
				}
				set
				{
					this.m_owner.m_offlineArenaPointsText = value;
				}
			}

			// Token: 0x17002012 RID: 8210
			// (get) Token: 0x06009DB4 RID: 40372 RVA: 0x002CDC8C File Offset: 0x002CBE8C
			// (set) Token: 0x06009DB5 RID: 40373 RVA: 0x002CDC9C File Offset: 0x002CBE9C
			public Text m_offlineArenaPointsUpText1
			{
				get
				{
					return this.m_owner.m_offlineArenaPointsUpText1;
				}
				set
				{
					this.m_owner.m_offlineArenaPointsUpText1 = value;
				}
			}

			// Token: 0x17002013 RID: 8211
			// (get) Token: 0x06009DB6 RID: 40374 RVA: 0x002CDCAC File Offset: 0x002CBEAC
			// (set) Token: 0x06009DB7 RID: 40375 RVA: 0x002CDCBC File Offset: 0x002CBEBC
			public Text m_offlineArenaPointsUpText2
			{
				get
				{
					return this.m_owner.m_offlineArenaPointsUpText2;
				}
				set
				{
					this.m_owner.m_offlineArenaPointsUpText2 = value;
				}
			}

			// Token: 0x17002014 RID: 8212
			// (get) Token: 0x06009DB8 RID: 40376 RVA: 0x002CDCCC File Offset: 0x002CBECC
			// (set) Token: 0x06009DB9 RID: 40377 RVA: 0x002CDCDC File Offset: 0x002CBEDC
			public Image m_offlineArenaPointsUpBarImage
			{
				get
				{
					return this.m_owner.m_offlineArenaPointsUpBarImage;
				}
				set
				{
					this.m_owner.m_offlineArenaPointsUpBarImage = value;
				}
			}

			// Token: 0x17002015 RID: 8213
			// (get) Token: 0x06009DBA RID: 40378 RVA: 0x002CDCEC File Offset: 0x002CBEEC
			// (set) Token: 0x06009DBB RID: 40379 RVA: 0x002CDCFC File Offset: 0x002CBEFC
			public Button m_offlineDefendButton
			{
				get
				{
					return this.m_owner.m_offlineDefendButton;
				}
				set
				{
					this.m_owner.m_offlineDefendButton = value;
				}
			}

			// Token: 0x17002016 RID: 8214
			// (get) Token: 0x06009DBC RID: 40380 RVA: 0x002CDD0C File Offset: 0x002CBF0C
			// (set) Token: 0x06009DBD RID: 40381 RVA: 0x002CDD1C File Offset: 0x002CBF1C
			public Button m_offlineArenaPointRewardButton
			{
				get
				{
					return this.m_owner.m_offlineArenaPointRewardButton;
				}
				set
				{
					this.m_owner.m_offlineArenaPointRewardButton = value;
				}
			}

			// Token: 0x17002017 RID: 8215
			// (get) Token: 0x06009DBE RID: 40382 RVA: 0x002CDD2C File Offset: 0x002CBF2C
			// (set) Token: 0x06009DBF RID: 40383 RVA: 0x002CDD3C File Offset: 0x002CBF3C
			public Text m_offlineVictoryPointsText
			{
				get
				{
					return this.m_owner.m_offlineVictoryPointsText;
				}
				set
				{
					this.m_owner.m_offlineVictoryPointsText = value;
				}
			}

			// Token: 0x17002018 RID: 8216
			// (get) Token: 0x06009DC0 RID: 40384 RVA: 0x002CDD4C File Offset: 0x002CBF4C
			// (set) Token: 0x06009DC1 RID: 40385 RVA: 0x002CDD5C File Offset: 0x002CBF5C
			public GameObject m_offlineVictoryPointsRewardButton1GameObject
			{
				get
				{
					return this.m_owner.m_offlineVictoryPointsRewardButton1GameObject;
				}
				set
				{
					this.m_owner.m_offlineVictoryPointsRewardButton1GameObject = value;
				}
			}

			// Token: 0x17002019 RID: 8217
			// (get) Token: 0x06009DC2 RID: 40386 RVA: 0x002CDD6C File Offset: 0x002CBF6C
			// (set) Token: 0x06009DC3 RID: 40387 RVA: 0x002CDD7C File Offset: 0x002CBF7C
			public GameObject m_offlineVictoryPointsRewardButton2GameObject
			{
				get
				{
					return this.m_owner.m_offlineVictoryPointsRewardButton2GameObject;
				}
				set
				{
					this.m_owner.m_offlineVictoryPointsRewardButton2GameObject = value;
				}
			}

			// Token: 0x1700201A RID: 8218
			// (get) Token: 0x06009DC4 RID: 40388 RVA: 0x002CDD8C File Offset: 0x002CBF8C
			// (set) Token: 0x06009DC5 RID: 40389 RVA: 0x002CDD9C File Offset: 0x002CBF9C
			public GameObject m_offlineVictoryPointsRewardButton3GameObject
			{
				get
				{
					return this.m_owner.m_offlineVictoryPointsRewardButton3GameObject;
				}
				set
				{
					this.m_owner.m_offlineVictoryPointsRewardButton3GameObject = value;
				}
			}

			// Token: 0x1700201B RID: 8219
			// (get) Token: 0x06009DC6 RID: 40390 RVA: 0x002CDDAC File Offset: 0x002CBFAC
			// (set) Token: 0x06009DC7 RID: 40391 RVA: 0x002CDDBC File Offset: 0x002CBFBC
			public Image m_offlineVictoryPointsRewardImage
			{
				get
				{
					return this.m_owner.m_offlineVictoryPointsRewardImage;
				}
				set
				{
					this.m_owner.m_offlineVictoryPointsRewardImage = value;
				}
			}

			// Token: 0x1700201C RID: 8220
			// (get) Token: 0x06009DC8 RID: 40392 RVA: 0x002CDDCC File Offset: 0x002CBFCC
			// (set) Token: 0x06009DC9 RID: 40393 RVA: 0x002CDDDC File Offset: 0x002CBFDC
			public Text m_offlineWeekWinText
			{
				get
				{
					return this.m_owner.m_offlineWeekWinText;
				}
				set
				{
					this.m_owner.m_offlineWeekWinText = value;
				}
			}

			// Token: 0x1700201D RID: 8221
			// (get) Token: 0x06009DCA RID: 40394 RVA: 0x002CDDEC File Offset: 0x002CBFEC
			// (set) Token: 0x06009DCB RID: 40395 RVA: 0x002CDDFC File Offset: 0x002CBFFC
			public GameObjectPool<ArenaOpponentListItemUIController> m_arenaOpponentPool
			{
				get
				{
					return this.m_owner.m_arenaOpponentPool;
				}
				set
				{
					this.m_owner.m_arenaOpponentPool = value;
				}
			}

			// Token: 0x1700201E RID: 8222
			// (get) Token: 0x06009DCC RID: 40396 RVA: 0x002CDE0C File Offset: 0x002CC00C
			// (set) Token: 0x06009DCD RID: 40397 RVA: 0x002CDE1C File Offset: 0x002CC01C
			public GameObjectPool<ArenaRankingListItemUIController> m_arenaRankingPool
			{
				get
				{
					return this.m_owner.m_arenaRankingPool;
				}
				set
				{
					this.m_owner.m_arenaRankingPool = value;
				}
			}

			// Token: 0x1700201F RID: 8223
			// (get) Token: 0x06009DCE RID: 40398 RVA: 0x002CDE2C File Offset: 0x002CC02C
			// (set) Token: 0x06009DCF RID: 40399 RVA: 0x002CDE3C File Offset: 0x002CC03C
			public GameObjectPool<OfflineArenaBattleReportListItemUIController> m_offlineArenaBattleReportPool
			{
				get
				{
					return this.m_owner.m_offlineArenaBattleReportPool;
				}
				set
				{
					this.m_owner.m_offlineArenaBattleReportPool = value;
				}
			}

			// Token: 0x17002020 RID: 8224
			// (get) Token: 0x06009DD0 RID: 40400 RVA: 0x002CDE4C File Offset: 0x002CC04C
			// (set) Token: 0x06009DD1 RID: 40401 RVA: 0x002CDE5C File Offset: 0x002CC05C
			public GameObjectPool<ArenaPointRewardListItemUIController> m_offlineArenaPointRewardPool
			{
				get
				{
					return this.m_owner.m_offlineArenaPointRewardPool;
				}
				set
				{
					this.m_owner.m_offlineArenaPointRewardPool = value;
				}
			}

			// Token: 0x17002021 RID: 8225
			// (get) Token: 0x06009DD2 RID: 40402 RVA: 0x002CDE6C File Offset: 0x002CC06C
			// (set) Token: 0x06009DD3 RID: 40403 RVA: 0x002CDE7C File Offset: 0x002CC07C
			public GameObject m_onlineGameObject
			{
				get
				{
					return this.m_owner.m_onlineGameObject;
				}
				set
				{
					this.m_owner.m_onlineGameObject = value;
				}
			}

			// Token: 0x17002022 RID: 8226
			// (get) Token: 0x06009DD4 RID: 40404 RVA: 0x002CDE8C File Offset: 0x002CC08C
			// (set) Token: 0x06009DD5 RID: 40405 RVA: 0x002CDE9C File Offset: 0x002CC09C
			public RectTransform m_onlineMarginTransform
			{
				get
				{
					return this.m_owner.m_onlineMarginTransform;
				}
				set
				{
					this.m_owner.m_onlineMarginTransform = value;
				}
			}

			// Token: 0x17002023 RID: 8227
			// (get) Token: 0x06009DD6 RID: 40406 RVA: 0x002CDEAC File Offset: 0x002CC0AC
			// (set) Token: 0x06009DD7 RID: 40407 RVA: 0x002CDEBC File Offset: 0x002CC0BC
			public Toggle m_onlineClashToggle
			{
				get
				{
					return this.m_owner.m_onlineClashToggle;
				}
				set
				{
					this.m_owner.m_onlineClashToggle = value;
				}
			}

			// Token: 0x17002024 RID: 8228
			// (get) Token: 0x06009DD8 RID: 40408 RVA: 0x002CDECC File Offset: 0x002CC0CC
			// (set) Token: 0x06009DD9 RID: 40409 RVA: 0x002CDEDC File Offset: 0x002CC0DC
			public Toggle m_onlineBattleReportToggle
			{
				get
				{
					return this.m_owner.m_onlineBattleReportToggle;
				}
				set
				{
					this.m_owner.m_onlineBattleReportToggle = value;
				}
			}

			// Token: 0x17002025 RID: 8229
			// (get) Token: 0x06009DDA RID: 40410 RVA: 0x002CDEEC File Offset: 0x002CC0EC
			// (set) Token: 0x06009DDB RID: 40411 RVA: 0x002CDEFC File Offset: 0x002CC0FC
			public Toggle m_onlineDanToggle
			{
				get
				{
					return this.m_owner.m_onlineDanToggle;
				}
				set
				{
					this.m_owner.m_onlineDanToggle = value;
				}
			}

			// Token: 0x17002026 RID: 8230
			// (get) Token: 0x06009DDC RID: 40412 RVA: 0x002CDF0C File Offset: 0x002CC10C
			// (set) Token: 0x06009DDD RID: 40413 RVA: 0x002CDF1C File Offset: 0x002CC11C
			public Toggle m_onlineLocalRankingToggle
			{
				get
				{
					return this.m_owner.m_onlineLocalRankingToggle;
				}
				set
				{
					this.m_owner.m_onlineLocalRankingToggle = value;
				}
			}

			// Token: 0x17002027 RID: 8231
			// (get) Token: 0x06009DDE RID: 40414 RVA: 0x002CDF2C File Offset: 0x002CC12C
			// (set) Token: 0x06009DDF RID: 40415 RVA: 0x002CDF3C File Offset: 0x002CC13C
			public Toggle m_onlineGlobalRankingToggle
			{
				get
				{
					return this.m_owner.m_onlineGlobalRankingToggle;
				}
				set
				{
					this.m_owner.m_onlineGlobalRankingToggle = value;
				}
			}

			// Token: 0x17002028 RID: 8232
			// (get) Token: 0x06009DE0 RID: 40416 RVA: 0x002CDF4C File Offset: 0x002CC14C
			// (set) Token: 0x06009DE1 RID: 40417 RVA: 0x002CDF5C File Offset: 0x002CC15C
			public GameObject m_onlineClashPanelGameObject
			{
				get
				{
					return this.m_owner.m_onlineClashPanelGameObject;
				}
				set
				{
					this.m_owner.m_onlineClashPanelGameObject = value;
				}
			}

			// Token: 0x17002029 RID: 8233
			// (get) Token: 0x06009DE2 RID: 40418 RVA: 0x002CDF6C File Offset: 0x002CC16C
			// (set) Token: 0x06009DE3 RID: 40419 RVA: 0x002CDF7C File Offset: 0x002CC17C
			public CommonUIStateController m_onlineClashLadderModeUIStateController
			{
				get
				{
					return this.m_owner.m_onlineClashLadderModeUIStateController;
				}
				set
				{
					this.m_owner.m_onlineClashLadderModeUIStateController = value;
				}
			}

			// Token: 0x1700202A RID: 8234
			// (get) Token: 0x06009DE4 RID: 40420 RVA: 0x002CDF8C File Offset: 0x002CC18C
			// (set) Token: 0x06009DE5 RID: 40421 RVA: 0x002CDF9C File Offset: 0x002CC19C
			public Text m_onlineClashWinRateText
			{
				get
				{
					return this.m_owner.m_onlineClashWinRateText;
				}
				set
				{
					this.m_owner.m_onlineClashWinRateText = value;
				}
			}

			// Token: 0x1700202B RID: 8235
			// (get) Token: 0x06009DE6 RID: 40422 RVA: 0x002CDFAC File Offset: 0x002CC1AC
			// (set) Token: 0x06009DE7 RID: 40423 RVA: 0x002CDFBC File Offset: 0x002CC1BC
			public Text m_onlineClashWinCountText
			{
				get
				{
					return this.m_owner.m_onlineClashWinCountText;
				}
				set
				{
					this.m_owner.m_onlineClashWinCountText = value;
				}
			}

			// Token: 0x1700202C RID: 8236
			// (get) Token: 0x06009DE8 RID: 40424 RVA: 0x002CDFCC File Offset: 0x002CC1CC
			// (set) Token: 0x06009DE9 RID: 40425 RVA: 0x002CDFDC File Offset: 0x002CC1DC
			public Text m_onlineClashLoseCountText
			{
				get
				{
					return this.m_owner.m_onlineClashLoseCountText;
				}
				set
				{
					this.m_owner.m_onlineClashLoseCountText = value;
				}
			}

			// Token: 0x1700202D RID: 8237
			// (get) Token: 0x06009DEA RID: 40426 RVA: 0x002CDFEC File Offset: 0x002CC1EC
			// (set) Token: 0x06009DEB RID: 40427 RVA: 0x002CDFFC File Offset: 0x002CC1FC
			public Text m_onlineClashTotalCountText
			{
				get
				{
					return this.m_owner.m_onlineClashTotalCountText;
				}
				set
				{
					this.m_owner.m_onlineClashTotalCountText = value;
				}
			}

			// Token: 0x1700202E RID: 8238
			// (get) Token: 0x06009DEC RID: 40428 RVA: 0x002CE00C File Offset: 0x002CC20C
			// (set) Token: 0x06009DED RID: 40429 RVA: 0x002CE01C File Offset: 0x002CC21C
			public Image m_onlineClashDanIconImage
			{
				get
				{
					return this.m_owner.m_onlineClashDanIconImage;
				}
				set
				{
					this.m_owner.m_onlineClashDanIconImage = value;
				}
			}

			// Token: 0x1700202F RID: 8239
			// (get) Token: 0x06009DEE RID: 40430 RVA: 0x002CE02C File Offset: 0x002CC22C
			// (set) Token: 0x06009DEF RID: 40431 RVA: 0x002CE03C File Offset: 0x002CC23C
			public Image m_onlineClashPromoteDanIconImage
			{
				get
				{
					return this.m_owner.m_onlineClashPromoteDanIconImage;
				}
				set
				{
					this.m_owner.m_onlineClashPromoteDanIconImage = value;
				}
			}

			// Token: 0x17002030 RID: 8240
			// (get) Token: 0x06009DF0 RID: 40432 RVA: 0x002CE04C File Offset: 0x002CC24C
			// (set) Token: 0x06009DF1 RID: 40433 RVA: 0x002CE05C File Offset: 0x002CC25C
			public Image m_onlineClashPromoteNextDanIconImage
			{
				get
				{
					return this.m_owner.m_onlineClashPromoteNextDanIconImage;
				}
				set
				{
					this.m_owner.m_onlineClashPromoteNextDanIconImage = value;
				}
			}

			// Token: 0x17002031 RID: 8241
			// (get) Token: 0x06009DF2 RID: 40434 RVA: 0x002CE06C File Offset: 0x002CC26C
			// (set) Token: 0x06009DF3 RID: 40435 RVA: 0x002CE07C File Offset: 0x002CC27C
			public Image m_onlineClashPromoteCountImage
			{
				get
				{
					return this.m_owner.m_onlineClashPromoteCountImage;
				}
				set
				{
					this.m_owner.m_onlineClashPromoteCountImage = value;
				}
			}

			// Token: 0x17002032 RID: 8242
			// (get) Token: 0x06009DF4 RID: 40436 RVA: 0x002CE08C File Offset: 0x002CC28C
			// (set) Token: 0x06009DF5 RID: 40437 RVA: 0x002CE09C File Offset: 0x002CC29C
			public GameObject m_onlineClashPromoteRoundGroupGameObject
			{
				get
				{
					return this.m_owner.m_onlineClashPromoteRoundGroupGameObject;
				}
				set
				{
					this.m_owner.m_onlineClashPromoteRoundGroupGameObject = value;
				}
			}

			// Token: 0x17002033 RID: 8243
			// (get) Token: 0x06009DF6 RID: 40438 RVA: 0x002CE0AC File Offset: 0x002CC2AC
			// (set) Token: 0x06009DF7 RID: 40439 RVA: 0x002CE0BC File Offset: 0x002CC2BC
			public GameObject m_onlineClashLadderOpenTimeGameObject
			{
				get
				{
					return this.m_owner.m_onlineClashLadderOpenTimeGameObject;
				}
				set
				{
					this.m_owner.m_onlineClashLadderOpenTimeGameObject = value;
				}
			}

			// Token: 0x17002034 RID: 8244
			// (get) Token: 0x06009DF8 RID: 40440 RVA: 0x002CE0CC File Offset: 0x002CC2CC
			// (set) Token: 0x06009DF9 RID: 40441 RVA: 0x002CE0DC File Offset: 0x002CC2DC
			public Text m_onlineClashLadderOpenTimeText
			{
				get
				{
					return this.m_owner.m_onlineClashLadderOpenTimeText;
				}
				set
				{
					this.m_owner.m_onlineClashLadderOpenTimeText = value;
				}
			}

			// Token: 0x17002035 RID: 8245
			// (get) Token: 0x06009DFA RID: 40442 RVA: 0x002CE0EC File Offset: 0x002CC2EC
			// (set) Token: 0x06009DFB RID: 40443 RVA: 0x002CE0FC File Offset: 0x002CC2FC
			public Button m_onlineClashLadderChallengeButton
			{
				get
				{
					return this.m_owner.m_onlineClashLadderChallengeButton;
				}
				set
				{
					this.m_owner.m_onlineClashLadderChallengeButton = value;
				}
			}

			// Token: 0x17002036 RID: 8246
			// (get) Token: 0x06009DFC RID: 40444 RVA: 0x002CE10C File Offset: 0x002CC30C
			// (set) Token: 0x06009DFD RID: 40445 RVA: 0x002CE11C File Offset: 0x002CC31C
			public CommonUIStateController m_onlineClashLadderChallengeButtonUIStateController
			{
				get
				{
					return this.m_owner.m_onlineClashLadderChallengeButtonUIStateController;
				}
				set
				{
					this.m_owner.m_onlineClashLadderChallengeButtonUIStateController = value;
				}
			}

			// Token: 0x17002037 RID: 8247
			// (get) Token: 0x06009DFE RID: 40446 RVA: 0x002CE12C File Offset: 0x002CC32C
			// (set) Token: 0x06009DFF RID: 40447 RVA: 0x002CE13C File Offset: 0x002CC33C
			public Button m_onlineClashCasualChallengeButton
			{
				get
				{
					return this.m_owner.m_onlineClashCasualChallengeButton;
				}
				set
				{
					this.m_owner.m_onlineClashCasualChallengeButton = value;
				}
			}

			// Token: 0x17002038 RID: 8248
			// (get) Token: 0x06009E00 RID: 40448 RVA: 0x002CE14C File Offset: 0x002CC34C
			// (set) Token: 0x06009E01 RID: 40449 RVA: 0x002CE15C File Offset: 0x002CC35C
			public GameObject m_onlineBattleReportPanelGameObject
			{
				get
				{
					return this.m_owner.m_onlineBattleReportPanelGameObject;
				}
				set
				{
					this.m_owner.m_onlineBattleReportPanelGameObject = value;
				}
			}

			// Token: 0x17002039 RID: 8249
			// (get) Token: 0x06009E02 RID: 40450 RVA: 0x002CE16C File Offset: 0x002CC36C
			// (set) Token: 0x06009E03 RID: 40451 RVA: 0x002CE17C File Offset: 0x002CC37C
			public ScrollRect m_onlineBattleReportScrollRect
			{
				get
				{
					return this.m_owner.m_onlineBattleReportScrollRect;
				}
				set
				{
					this.m_owner.m_onlineBattleReportScrollRect = value;
				}
			}

			// Token: 0x1700203A RID: 8250
			// (get) Token: 0x06009E04 RID: 40452 RVA: 0x002CE18C File Offset: 0x002CC38C
			// (set) Token: 0x06009E05 RID: 40453 RVA: 0x002CE19C File Offset: 0x002CC39C
			public GameObject m_onlineNoBattleReportGameObject
			{
				get
				{
					return this.m_owner.m_onlineNoBattleReportGameObject;
				}
				set
				{
					this.m_owner.m_onlineNoBattleReportGameObject = value;
				}
			}

			// Token: 0x1700203B RID: 8251
			// (get) Token: 0x06009E06 RID: 40454 RVA: 0x002CE1AC File Offset: 0x002CC3AC
			// (set) Token: 0x06009E07 RID: 40455 RVA: 0x002CE1BC File Offset: 0x002CC3BC
			public GameObject m_onlineDanPanelGameObject
			{
				get
				{
					return this.m_owner.m_onlineDanPanelGameObject;
				}
				set
				{
					this.m_owner.m_onlineDanPanelGameObject = value;
				}
			}

			// Token: 0x1700203C RID: 8252
			// (get) Token: 0x06009E08 RID: 40456 RVA: 0x002CE1CC File Offset: 0x002CC3CC
			// (set) Token: 0x06009E09 RID: 40457 RVA: 0x002CE1DC File Offset: 0x002CC3DC
			public ScrollRect m_onlineArenaLevelScrollRect
			{
				get
				{
					return this.m_owner.m_onlineArenaLevelScrollRect;
				}
				set
				{
					this.m_owner.m_onlineArenaLevelScrollRect = value;
				}
			}

			// Token: 0x1700203D RID: 8253
			// (get) Token: 0x06009E0A RID: 40458 RVA: 0x002CE1EC File Offset: 0x002CC3EC
			// (set) Token: 0x06009E0B RID: 40459 RVA: 0x002CE1FC File Offset: 0x002CC3FC
			public GameObject m_onlineRankingPanelGameObject
			{
				get
				{
					return this.m_owner.m_onlineRankingPanelGameObject;
				}
				set
				{
					this.m_owner.m_onlineRankingPanelGameObject = value;
				}
			}

			// Token: 0x1700203E RID: 8254
			// (get) Token: 0x06009E0C RID: 40460 RVA: 0x002CE20C File Offset: 0x002CC40C
			// (set) Token: 0x06009E0D RID: 40461 RVA: 0x002CE21C File Offset: 0x002CC41C
			public ScrollRect m_onlineRankingScrollRect
			{
				get
				{
					return this.m_owner.m_onlineRankingScrollRect;
				}
				set
				{
					this.m_owner.m_onlineRankingScrollRect = value;
				}
			}

			// Token: 0x1700203F RID: 8255
			// (get) Token: 0x06009E0E RID: 40462 RVA: 0x002CE22C File Offset: 0x002CC42C
			// (set) Token: 0x06009E0F RID: 40463 RVA: 0x002CE23C File Offset: 0x002CC43C
			public Text m_onlineRankingPlayerNameText
			{
				get
				{
					return this.m_owner.m_onlineRankingPlayerNameText;
				}
				set
				{
					this.m_owner.m_onlineRankingPlayerNameText = value;
				}
			}

			// Token: 0x17002040 RID: 8256
			// (get) Token: 0x06009E10 RID: 40464 RVA: 0x002CE24C File Offset: 0x002CC44C
			// (set) Token: 0x06009E11 RID: 40465 RVA: 0x002CE25C File Offset: 0x002CC45C
			public CommonUIStateController m_onlineRankingPlayerRankingUIStateController
			{
				get
				{
					return this.m_owner.m_onlineRankingPlayerRankingUIStateController;
				}
				set
				{
					this.m_owner.m_onlineRankingPlayerRankingUIStateController = value;
				}
			}

			// Token: 0x17002041 RID: 8257
			// (get) Token: 0x06009E12 RID: 40466 RVA: 0x002CE26C File Offset: 0x002CC46C
			// (set) Token: 0x06009E13 RID: 40467 RVA: 0x002CE27C File Offset: 0x002CC47C
			public Text m_onlineRankingPlayerRankingText
			{
				get
				{
					return this.m_owner.m_onlineRankingPlayerRankingText;
				}
				set
				{
					this.m_owner.m_onlineRankingPlayerRankingText = value;
				}
			}

			// Token: 0x17002042 RID: 8258
			// (get) Token: 0x06009E14 RID: 40468 RVA: 0x002CE28C File Offset: 0x002CC48C
			// (set) Token: 0x06009E15 RID: 40469 RVA: 0x002CE29C File Offset: 0x002CC49C
			public Image m_onlineRankingPlayerRankingImage
			{
				get
				{
					return this.m_owner.m_onlineRankingPlayerRankingImage;
				}
				set
				{
					this.m_owner.m_onlineRankingPlayerRankingImage = value;
				}
			}

			// Token: 0x17002043 RID: 8259
			// (get) Token: 0x06009E16 RID: 40470 RVA: 0x002CE2AC File Offset: 0x002CC4AC
			// (set) Token: 0x06009E17 RID: 40471 RVA: 0x002CE2BC File Offset: 0x002CC4BC
			public Text m_onlineRankingArenaPointsText
			{
				get
				{
					return this.m_owner.m_onlineRankingArenaPointsText;
				}
				set
				{
					this.m_owner.m_onlineRankingArenaPointsText = value;
				}
			}

			// Token: 0x17002044 RID: 8260
			// (get) Token: 0x06009E18 RID: 40472 RVA: 0x002CE2CC File Offset: 0x002CC4CC
			// (set) Token: 0x06009E19 RID: 40473 RVA: 0x002CE2DC File Offset: 0x002CC4DC
			public Image m_onlineRankingPlayerIconImage
			{
				get
				{
					return this.m_owner.m_onlineRankingPlayerIconImage;
				}
				set
				{
					this.m_owner.m_onlineRankingPlayerIconImage = value;
				}
			}

			// Token: 0x17002045 RID: 8261
			// (get) Token: 0x06009E1A RID: 40474 RVA: 0x002CE2EC File Offset: 0x002CC4EC
			// (set) Token: 0x06009E1B RID: 40475 RVA: 0x002CE2FC File Offset: 0x002CC4FC
			public Transform m_onlineRankingPlayerHeadFrameTransform
			{
				get
				{
					return this.m_owner.m_onlineRankingPlayerHeadFrameTransform;
				}
				set
				{
					this.m_owner.m_onlineRankingPlayerHeadFrameTransform = value;
				}
			}

			// Token: 0x17002046 RID: 8262
			// (get) Token: 0x06009E1C RID: 40476 RVA: 0x002CE30C File Offset: 0x002CC50C
			// (set) Token: 0x06009E1D RID: 40477 RVA: 0x002CE31C File Offset: 0x002CC51C
			public Text m_onlineRankingPlayerLevelText
			{
				get
				{
					return this.m_owner.m_onlineRankingPlayerLevelText;
				}
				set
				{
					this.m_owner.m_onlineRankingPlayerLevelText = value;
				}
			}

			// Token: 0x17002047 RID: 8263
			// (get) Token: 0x06009E1E RID: 40478 RVA: 0x002CE32C File Offset: 0x002CC52C
			// (set) Token: 0x06009E1F RID: 40479 RVA: 0x002CE33C File Offset: 0x002CC53C
			public Image m_onlinePlayerIconImage
			{
				get
				{
					return this.m_owner.m_onlinePlayerIconImage;
				}
				set
				{
					this.m_owner.m_onlinePlayerIconImage = value;
				}
			}

			// Token: 0x17002048 RID: 8264
			// (get) Token: 0x06009E20 RID: 40480 RVA: 0x002CE34C File Offset: 0x002CC54C
			// (set) Token: 0x06009E21 RID: 40481 RVA: 0x002CE35C File Offset: 0x002CC55C
			public Text m_onlinePlayerNameText
			{
				get
				{
					return this.m_owner.m_onlinePlayerNameText;
				}
				set
				{
					this.m_owner.m_onlinePlayerNameText = value;
				}
			}

			// Token: 0x17002049 RID: 8265
			// (get) Token: 0x06009E22 RID: 40482 RVA: 0x002CE36C File Offset: 0x002CC56C
			// (set) Token: 0x06009E23 RID: 40483 RVA: 0x002CE37C File Offset: 0x002CC57C
			public Text m_onlineDanText
			{
				get
				{
					return this.m_owner.m_onlineDanText;
				}
				set
				{
					this.m_owner.m_onlineDanText = value;
				}
			}

			// Token: 0x1700204A RID: 8266
			// (get) Token: 0x06009E24 RID: 40484 RVA: 0x002CE38C File Offset: 0x002CC58C
			// (set) Token: 0x06009E25 RID: 40485 RVA: 0x002CE39C File Offset: 0x002CC59C
			public Image m_onlineDanIconImage
			{
				get
				{
					return this.m_owner.m_onlineDanIconImage;
				}
				set
				{
					this.m_owner.m_onlineDanIconImage = value;
				}
			}

			// Token: 0x1700204B RID: 8267
			// (get) Token: 0x06009E26 RID: 40486 RVA: 0x002CE3AC File Offset: 0x002CC5AC
			// (set) Token: 0x06009E27 RID: 40487 RVA: 0x002CE3BC File Offset: 0x002CC5BC
			public Text m_onlinePlayerLevelText
			{
				get
				{
					return this.m_owner.m_onlinePlayerLevelText;
				}
				set
				{
					this.m_owner.m_onlinePlayerLevelText = value;
				}
			}

			// Token: 0x1700204C RID: 8268
			// (get) Token: 0x06009E28 RID: 40488 RVA: 0x002CE3CC File Offset: 0x002CC5CC
			// (set) Token: 0x06009E29 RID: 40489 RVA: 0x002CE3DC File Offset: 0x002CC5DC
			public Text m_onlineArenaPointsText
			{
				get
				{
					return this.m_owner.m_onlineArenaPointsText;
				}
				set
				{
					this.m_owner.m_onlineArenaPointsText = value;
				}
			}

			// Token: 0x1700204D RID: 8269
			// (get) Token: 0x06009E2A RID: 40490 RVA: 0x002CE3EC File Offset: 0x002CC5EC
			// (set) Token: 0x06009E2B RID: 40491 RVA: 0x002CE3FC File Offset: 0x002CC5FC
			public Text m_onlineArenaPointsUpText1
			{
				get
				{
					return this.m_owner.m_onlineArenaPointsUpText1;
				}
				set
				{
					this.m_owner.m_onlineArenaPointsUpText1 = value;
				}
			}

			// Token: 0x1700204E RID: 8270
			// (get) Token: 0x06009E2C RID: 40492 RVA: 0x002CE40C File Offset: 0x002CC60C
			// (set) Token: 0x06009E2D RID: 40493 RVA: 0x002CE41C File Offset: 0x002CC61C
			public Text m_onlineArenaPointsUpText2
			{
				get
				{
					return this.m_owner.m_onlineArenaPointsUpText2;
				}
				set
				{
					this.m_owner.m_onlineArenaPointsUpText2 = value;
				}
			}

			// Token: 0x1700204F RID: 8271
			// (get) Token: 0x06009E2E RID: 40494 RVA: 0x002CE42C File Offset: 0x002CC62C
			// (set) Token: 0x06009E2F RID: 40495 RVA: 0x002CE43C File Offset: 0x002CC63C
			public Image m_onlineArenaPointsUpBarImage
			{
				get
				{
					return this.m_owner.m_onlineArenaPointsUpBarImage;
				}
				set
				{
					this.m_owner.m_onlineArenaPointsUpBarImage = value;
				}
			}

			// Token: 0x17002050 RID: 8272
			// (get) Token: 0x06009E30 RID: 40496 RVA: 0x002CE44C File Offset: 0x002CC64C
			// (set) Token: 0x06009E31 RID: 40497 RVA: 0x002CE45C File Offset: 0x002CC65C
			public Button m_onlineArenaRankingRewardButton
			{
				get
				{
					return this.m_owner.m_onlineArenaRankingRewardButton;
				}
				set
				{
					this.m_owner.m_onlineArenaRankingRewardButton = value;
				}
			}

			// Token: 0x17002051 RID: 8273
			// (get) Token: 0x06009E32 RID: 40498 RVA: 0x002CE46C File Offset: 0x002CC66C
			// (set) Token: 0x06009E33 RID: 40499 RVA: 0x002CE47C File Offset: 0x002CC67C
			public Text m_onlineWeekWinText
			{
				get
				{
					return this.m_owner.m_onlineWeekWinText;
				}
				set
				{
					this.m_owner.m_onlineWeekWinText = value;
				}
			}

			// Token: 0x17002052 RID: 8274
			// (get) Token: 0x06009E34 RID: 40500 RVA: 0x002CE48C File Offset: 0x002CC68C
			// (set) Token: 0x06009E35 RID: 40501 RVA: 0x002CE49C File Offset: 0x002CC69C
			public GameObject m_onlineWeekWinRewardButton1GameObject
			{
				get
				{
					return this.m_owner.m_onlineWeekWinRewardButton1GameObject;
				}
				set
				{
					this.m_owner.m_onlineWeekWinRewardButton1GameObject = value;
				}
			}

			// Token: 0x17002053 RID: 8275
			// (get) Token: 0x06009E36 RID: 40502 RVA: 0x002CE4AC File Offset: 0x002CC6AC
			// (set) Token: 0x06009E37 RID: 40503 RVA: 0x002CE4BC File Offset: 0x002CC6BC
			public GameObject m_onlineWeekWinRewardButton2GameObject
			{
				get
				{
					return this.m_owner.m_onlineWeekWinRewardButton2GameObject;
				}
				set
				{
					this.m_owner.m_onlineWeekWinRewardButton2GameObject = value;
				}
			}

			// Token: 0x17002054 RID: 8276
			// (get) Token: 0x06009E38 RID: 40504 RVA: 0x002CE4CC File Offset: 0x002CC6CC
			// (set) Token: 0x06009E39 RID: 40505 RVA: 0x002CE4DC File Offset: 0x002CC6DC
			public GameObject m_onlineWeekWinRewardButton3GameObject
			{
				get
				{
					return this.m_owner.m_onlineWeekWinRewardButton3GameObject;
				}
				set
				{
					this.m_owner.m_onlineWeekWinRewardButton3GameObject = value;
				}
			}

			// Token: 0x17002055 RID: 8277
			// (get) Token: 0x06009E3A RID: 40506 RVA: 0x002CE4EC File Offset: 0x002CC6EC
			// (set) Token: 0x06009E3B RID: 40507 RVA: 0x002CE4FC File Offset: 0x002CC6FC
			public Image m_onlineWeekWinRewardImage
			{
				get
				{
					return this.m_owner.m_onlineWeekWinRewardImage;
				}
				set
				{
					this.m_owner.m_onlineWeekWinRewardImage = value;
				}
			}

			// Token: 0x17002056 RID: 8278
			// (get) Token: 0x06009E3C RID: 40508 RVA: 0x002CE50C File Offset: 0x002CC70C
			// (set) Token: 0x06009E3D RID: 40509 RVA: 0x002CE51C File Offset: 0x002CC71C
			public CommonUIStateController m_promoteBattleUIStateController
			{
				get
				{
					return this.m_owner.m_promoteBattleUIStateController;
				}
				set
				{
					this.m_owner.m_promoteBattleUIStateController = value;
				}
			}

			// Token: 0x17002057 RID: 8279
			// (get) Token: 0x06009E3E RID: 40510 RVA: 0x002CE52C File Offset: 0x002CC72C
			// (set) Token: 0x06009E3F RID: 40511 RVA: 0x002CE53C File Offset: 0x002CC73C
			public Button m_promoteBattleBGButton
			{
				get
				{
					return this.m_owner.m_promoteBattleBGButton;
				}
				set
				{
					this.m_owner.m_promoteBattleBGButton = value;
				}
			}

			// Token: 0x17002058 RID: 8280
			// (get) Token: 0x06009E40 RID: 40512 RVA: 0x002CE54C File Offset: 0x002CC74C
			// (set) Token: 0x06009E41 RID: 40513 RVA: 0x002CE55C File Offset: 0x002CC75C
			public Text m_promoteBattleText
			{
				get
				{
					return this.m_owner.m_promoteBattleText;
				}
				set
				{
					this.m_owner.m_promoteBattleText = value;
				}
			}

			// Token: 0x17002059 RID: 8281
			// (get) Token: 0x06009E42 RID: 40514 RVA: 0x002CE56C File Offset: 0x002CC76C
			// (set) Token: 0x06009E43 RID: 40515 RVA: 0x002CE57C File Offset: 0x002CC77C
			public Button m_promoteBattleConfirmButton
			{
				get
				{
					return this.m_owner.m_promoteBattleConfirmButton;
				}
				set
				{
					this.m_owner.m_promoteBattleConfirmButton = value;
				}
			}

			// Token: 0x1700205A RID: 8282
			// (get) Token: 0x06009E44 RID: 40516 RVA: 0x002CE58C File Offset: 0x002CC78C
			// (set) Token: 0x06009E45 RID: 40517 RVA: 0x002CE59C File Offset: 0x002CC79C
			public CommonUIStateController m_promoteSucceedUIStateController
			{
				get
				{
					return this.m_owner.m_promoteSucceedUIStateController;
				}
				set
				{
					this.m_owner.m_promoteSucceedUIStateController = value;
				}
			}

			// Token: 0x1700205B RID: 8283
			// (get) Token: 0x06009E46 RID: 40518 RVA: 0x002CE5AC File Offset: 0x002CC7AC
			// (set) Token: 0x06009E47 RID: 40519 RVA: 0x002CE5BC File Offset: 0x002CC7BC
			public Button m_promoteSucceedBGButton
			{
				get
				{
					return this.m_owner.m_promoteSucceedBGButton;
				}
				set
				{
					this.m_owner.m_promoteSucceedBGButton = value;
				}
			}

			// Token: 0x1700205C RID: 8284
			// (get) Token: 0x06009E48 RID: 40520 RVA: 0x002CE5CC File Offset: 0x002CC7CC
			// (set) Token: 0x06009E49 RID: 40521 RVA: 0x002CE5DC File Offset: 0x002CC7DC
			public Image m_promoteSucceedDanImage
			{
				get
				{
					return this.m_owner.m_promoteSucceedDanImage;
				}
				set
				{
					this.m_owner.m_promoteSucceedDanImage = value;
				}
			}

			// Token: 0x1700205D RID: 8285
			// (get) Token: 0x06009E4A RID: 40522 RVA: 0x002CE5EC File Offset: 0x002CC7EC
			// (set) Token: 0x06009E4B RID: 40523 RVA: 0x002CE5FC File Offset: 0x002CC7FC
			public Text m_promoteSucceedDanText
			{
				get
				{
					return this.m_owner.m_promoteSucceedDanText;
				}
				set
				{
					this.m_owner.m_promoteSucceedDanText = value;
				}
			}

			// Token: 0x1700205E RID: 8286
			// (get) Token: 0x06009E4C RID: 40524 RVA: 0x002CE60C File Offset: 0x002CC80C
			// (set) Token: 0x06009E4D RID: 40525 RVA: 0x002CE61C File Offset: 0x002CC81C
			public Button m_promoteSucceedConfirmButton
			{
				get
				{
					return this.m_owner.m_promoteSucceedConfirmButton;
				}
				set
				{
					this.m_owner.m_promoteSucceedConfirmButton = value;
				}
			}

			// Token: 0x1700205F RID: 8287
			// (get) Token: 0x06009E4E RID: 40526 RVA: 0x002CE62C File Offset: 0x002CC82C
			// (set) Token: 0x06009E4F RID: 40527 RVA: 0x002CE63C File Offset: 0x002CC83C
			public CommonUIStateController m_matchingFailedUIStateController
			{
				get
				{
					return this.m_owner.m_matchingFailedUIStateController;
				}
				set
				{
					this.m_owner.m_matchingFailedUIStateController = value;
				}
			}

			// Token: 0x17002060 RID: 8288
			// (get) Token: 0x06009E50 RID: 40528 RVA: 0x002CE64C File Offset: 0x002CC84C
			// (set) Token: 0x06009E51 RID: 40529 RVA: 0x002CE65C File Offset: 0x002CC85C
			public Button m_matchingFailedBGButton
			{
				get
				{
					return this.m_owner.m_matchingFailedBGButton;
				}
				set
				{
					this.m_owner.m_matchingFailedBGButton = value;
				}
			}

			// Token: 0x17002061 RID: 8289
			// (get) Token: 0x06009E52 RID: 40530 RVA: 0x002CE66C File Offset: 0x002CC86C
			// (set) Token: 0x06009E53 RID: 40531 RVA: 0x002CE67C File Offset: 0x002CC87C
			public Button m_matchingFailedConfirmButton
			{
				get
				{
					return this.m_owner.m_matchingFailedConfirmButton;
				}
				set
				{
					this.m_owner.m_matchingFailedConfirmButton = value;
				}
			}

			// Token: 0x17002062 RID: 8290
			// (get) Token: 0x06009E54 RID: 40532 RVA: 0x002CE68C File Offset: 0x002CC88C
			// (set) Token: 0x06009E55 RID: 40533 RVA: 0x002CE69C File Offset: 0x002CC89C
			public CommonUIStateController m_matchingNowUIStateController
			{
				get
				{
					return this.m_owner.m_matchingNowUIStateController;
				}
				set
				{
					this.m_owner.m_matchingNowUIStateController = value;
				}
			}

			// Token: 0x17002063 RID: 8291
			// (get) Token: 0x06009E56 RID: 40534 RVA: 0x002CE6AC File Offset: 0x002CC8AC
			// (set) Token: 0x06009E57 RID: 40535 RVA: 0x002CE6BC File Offset: 0x002CC8BC
			public Text m_matchingNowTimeText
			{
				get
				{
					return this.m_owner.m_matchingNowTimeText;
				}
				set
				{
					this.m_owner.m_matchingNowTimeText = value;
				}
			}

			// Token: 0x17002064 RID: 8292
			// (get) Token: 0x06009E58 RID: 40536 RVA: 0x002CE6CC File Offset: 0x002CC8CC
			// (set) Token: 0x06009E59 RID: 40537 RVA: 0x002CE6DC File Offset: 0x002CC8DC
			public GameObject m_matchingNowPredictTimeGameObject
			{
				get
				{
					return this.m_owner.m_matchingNowPredictTimeGameObject;
				}
				set
				{
					this.m_owner.m_matchingNowPredictTimeGameObject = value;
				}
			}

			// Token: 0x17002065 RID: 8293
			// (get) Token: 0x06009E5A RID: 40538 RVA: 0x002CE6EC File Offset: 0x002CC8EC
			// (set) Token: 0x06009E5B RID: 40539 RVA: 0x002CE6FC File Offset: 0x002CC8FC
			public Text m_matchingNowPredictTimeText
			{
				get
				{
					return this.m_owner.m_matchingNowPredictTimeText;
				}
				set
				{
					this.m_owner.m_matchingNowPredictTimeText = value;
				}
			}

			// Token: 0x17002066 RID: 8294
			// (get) Token: 0x06009E5C RID: 40540 RVA: 0x002CE70C File Offset: 0x002CC90C
			// (set) Token: 0x06009E5D RID: 40541 RVA: 0x002CE71C File Offset: 0x002CC91C
			public Button m_matchingNowCancelButton
			{
				get
				{
					return this.m_owner.m_matchingNowCancelButton;
				}
				set
				{
					this.m_owner.m_matchingNowCancelButton = value;
				}
			}

			// Token: 0x17002067 RID: 8295
			// (get) Token: 0x06009E5E RID: 40542 RVA: 0x002CE72C File Offset: 0x002CC92C
			// (set) Token: 0x06009E5F RID: 40543 RVA: 0x002CE73C File Offset: 0x002CC93C
			public GameObjectPool<ArenaRankingListItemUIController> m_onlineArenaRankingPool
			{
				get
				{
					return this.m_owner.m_onlineArenaRankingPool;
				}
				set
				{
					this.m_owner.m_onlineArenaRankingPool = value;
				}
			}

			// Token: 0x17002068 RID: 8296
			// (get) Token: 0x06009E60 RID: 40544 RVA: 0x002CE74C File Offset: 0x002CC94C
			// (set) Token: 0x06009E61 RID: 40545 RVA: 0x002CE75C File Offset: 0x002CC95C
			public GameObjectPool<OnlineArenaBattleReportListItemUIController> m_onlineArenaBattleReportPool
			{
				get
				{
					return this.m_owner.m_onlineArenaBattleReportPool;
				}
				set
				{
					this.m_owner.m_onlineArenaBattleReportPool = value;
				}
			}

			// Token: 0x17002069 RID: 8297
			// (get) Token: 0x06009E62 RID: 40546 RVA: 0x002CE76C File Offset: 0x002CC96C
			// (set) Token: 0x06009E63 RID: 40547 RVA: 0x002CE77C File Offset: 0x002CC97C
			public GameObjectPool<ArenaRankingRewardListItemUIController> m_onlineArenaRankingRewardPool
			{
				get
				{
					return this.m_owner.m_onlineArenaRankingRewardPool;
				}
				set
				{
					this.m_owner.m_onlineArenaRankingRewardPool = value;
				}
			}

			// Token: 0x1700206A RID: 8298
			// (get) Token: 0x06009E64 RID: 40548 RVA: 0x002CE78C File Offset: 0x002CC98C
			// (set) Token: 0x06009E65 RID: 40549 RVA: 0x002CE79C File Offset: 0x002CC99C
			public bool m_isMatchingNow
			{
				get
				{
					return this.m_owner.m_isMatchingNow;
				}
				set
				{
					this.m_owner.m_isMatchingNow = value;
				}
			}

			// Token: 0x06009E66 RID: 40550 RVA: 0x002CE7AC File Offset: 0x002CC9AC
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06009E67 RID: 40551 RVA: 0x002CE7BC File Offset: 0x002CC9BC
			public void ShowArenaTicketDesc()
			{
				this.m_owner.ShowArenaTicketDesc();
			}

			// Token: 0x06009E68 RID: 40552 RVA: 0x002CE7CC File Offset: 0x002CC9CC
			public void CloseArenaTicketDesc()
			{
				this.m_owner.CloseArenaTicketDesc();
			}

			// Token: 0x06009E69 RID: 40553 RVA: 0x002CE7DC File Offset: 0x002CC9DC
			public UISpineGraphic CreateSpineGraphic(ConfigDataJobConnectionInfo jobConnectionInfo, ConfigDataModelSkinResourceInfo skinResInfo)
			{
				return this.m_owner.CreateSpineGraphic(jobConnectionInfo, skinResInfo);
			}

			// Token: 0x06009E6A RID: 40554 RVA: 0x002CE7EC File Offset: 0x002CC9EC
			public void AddRewardPreviewGoods(List<Goods> goods)
			{
				this.m_owner.AddRewardPreviewGoods(goods);
			}

			// Token: 0x06009E6B RID: 40555 RVA: 0x002CE7FC File Offset: 0x002CC9FC
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x06009E6C RID: 40556 RVA: 0x002CE80C File Offset: 0x002CCA0C
			public void OnHelpButtonClick()
			{
				this.m_owner.OnHelpButtonClick();
			}

			// Token: 0x06009E6D RID: 40557 RVA: 0x002CE81C File Offset: 0x002CCA1C
			public void OnRewardPreviewBackgroundButtonClick()
			{
				this.m_owner.OnRewardPreviewBackgroundButtonClick();
			}

			// Token: 0x06009E6E RID: 40558 RVA: 0x002CE82C File Offset: 0x002CCA2C
			public void OnAddArenaTicketButtonClick()
			{
				this.m_owner.OnAddArenaTicketButtonClick();
			}

			// Token: 0x06009E6F RID: 40559 RVA: 0x002CE83C File Offset: 0x002CCA3C
			public void OnBuyArenaTicketBackgroundButtonClick()
			{
				this.m_owner.OnBuyArenaTicketBackgroundButtonClick();
			}

			// Token: 0x06009E70 RID: 40560 RVA: 0x002CE84C File Offset: 0x002CCA4C
			public void OnBuyArenaTicketBuyButtonClick()
			{
				this.m_owner.OnBuyArenaTicketBuyButtonClick();
			}

			// Token: 0x06009E71 RID: 40561 RVA: 0x002CE85C File Offset: 0x002CCA5C
			public void OnSwitchButtonClick()
			{
				this.m_owner.OnSwitchButtonClick();
			}

			// Token: 0x06009E72 RID: 40562 RVA: 0x002CE86C File Offset: 0x002CCA6C
			public void OfflineOnBindFiledsCompleted()
			{
				this.m_owner.OfflineOnBindFiledsCompleted();
			}

			// Token: 0x06009E73 RID: 40563 RVA: 0x002CE87C File Offset: 0x002CCA7C
			public void ShowAutoBattleTips()
			{
				this.m_owner.ShowAutoBattleTips();
			}

			// Token: 0x06009E74 RID: 40564 RVA: 0x002CE88C File Offset: 0x002CCA8C
			public void HideAutoBattleTips()
			{
				this.m_owner.HideAutoBattleTips();
			}

			// Token: 0x06009E75 RID: 40565 RVA: 0x002CE89C File Offset: 0x002CCA9C
			public void HideArenaOpponent()
			{
				this.m_owner.HideArenaOpponent();
			}

			// Token: 0x06009E76 RID: 40566 RVA: 0x002CE8AC File Offset: 0x002CCAAC
			public void ClearOpponentGraphcs()
			{
				this.m_owner.ClearOpponentGraphcs();
			}

			// Token: 0x06009E77 RID: 40567 RVA: 0x002CE8BC File Offset: 0x002CCABC
			public void OnOfflineClashToggle(bool on)
			{
				this.m_owner.OnOfflineClashToggle(on);
			}

			// Token: 0x06009E78 RID: 40568 RVA: 0x002CE8CC File Offset: 0x002CCACC
			public void OnOfflineBattleReportToggle(bool on)
			{
				this.m_owner.OnOfflineBattleReportToggle(on);
			}

			// Token: 0x06009E79 RID: 40569 RVA: 0x002CE8DC File Offset: 0x002CCADC
			public void OnOfflineRankingToggle(bool on)
			{
				this.m_owner.OnOfflineRankingToggle(on);
			}

			// Token: 0x06009E7A RID: 40570 RVA: 0x002CE8EC File Offset: 0x002CCAEC
			public void OnOfflineArenaPointRewardButtonClick()
			{
				this.m_owner.OnOfflineArenaPointRewardButtonClick();
			}

			// Token: 0x06009E7B RID: 40571 RVA: 0x002CE8FC File Offset: 0x002CCAFC
			public void OnOfflineArenaPointRewardCloseButtonClick()
			{
				this.m_owner.OnOfflineArenaPointRewardCloseButtonClick();
			}

			// Token: 0x06009E7C RID: 40572 RVA: 0x002CE90C File Offset: 0x002CCB0C
			public void OnOfflineVictoryPointsRewardButtonClick(GainRewardButton b)
			{
				this.m_owner.OnOfflineVictoryPointsRewardButtonClick(b);
			}

			// Token: 0x06009E7D RID: 40573 RVA: 0x002CE91C File Offset: 0x002CCB1C
			public void OnOfflineArenaOpponentAttackButtonClick(ArenaOpponentListItemUIController ctrl)
			{
				this.m_owner.OnOfflineArenaOpponentAttackButtonClick(ctrl);
			}

			// Token: 0x06009E7E RID: 40574 RVA: 0x002CE92C File Offset: 0x002CCB2C
			public void OnOfflineBattleReportRevengeButtonClick(OfflineArenaBattleReportListItemUIController ctrl)
			{
				this.m_owner.OnOfflineBattleReportRevengeButtonClick(ctrl);
			}

			// Token: 0x06009E7F RID: 40575 RVA: 0x002CE93C File Offset: 0x002CCB3C
			public void OnOfflineBattleReportReplayButtonClick(OfflineArenaBattleReportListItemUIController ctrl)
			{
				this.m_owner.OnOfflineBattleReportReplayButtonClick(ctrl);
			}

			// Token: 0x06009E80 RID: 40576 RVA: 0x002CE94C File Offset: 0x002CCB4C
			public void OnDefendButtonClick()
			{
				this.m_owner.OnDefendButtonClick();
			}

			// Token: 0x06009E81 RID: 40577 RVA: 0x002CE95C File Offset: 0x002CCB5C
			public void OnAttackConfirmButtonClick()
			{
				this.m_owner.OnAttackConfirmButtonClick();
			}

			// Token: 0x06009E82 RID: 40578 RVA: 0x002CE96C File Offset: 0x002CCB6C
			public void OnAutoBattleButtonClick()
			{
				this.m_owner.OnAutoBattleButtonClick();
			}

			// Token: 0x06009E83 RID: 40579 RVA: 0x002CE97C File Offset: 0x002CCB7C
			public void OnAttackBackgroundButtonClick()
			{
				this.m_owner.OnAttackBackgroundButtonClick();
			}

			// Token: 0x06009E84 RID: 40580 RVA: 0x002CE98C File Offset: 0x002CCB8C
			public void OnAutoBattleTipsConfirmButtonClick()
			{
				this.m_owner.OnAutoBattleTipsConfirmButtonClick();
			}

			// Token: 0x06009E85 RID: 40581 RVA: 0x002CE99C File Offset: 0x002CCB9C
			public void OnAutoBattleTipsCancelButtonClick()
			{
				this.m_owner.OnAutoBattleTipsCancelButtonClick();
			}

			// Token: 0x06009E86 RID: 40582 RVA: 0x002CE9AC File Offset: 0x002CCBAC
			public void OnlineOnBindFiledsCompleted()
			{
				this.m_owner.OnlineOnBindFiledsCompleted();
			}

			// Token: 0x06009E87 RID: 40583 RVA: 0x002CE9BC File Offset: 0x002CCBBC
			public void OnOnlineClashToggle(bool on)
			{
				this.m_owner.OnOnlineClashToggle(on);
			}

			// Token: 0x06009E88 RID: 40584 RVA: 0x002CE9CC File Offset: 0x002CCBCC
			public void OnOnlineBattleReportToggle(bool on)
			{
				this.m_owner.OnOnlineBattleReportToggle(on);
			}

			// Token: 0x06009E89 RID: 40585 RVA: 0x002CE9DC File Offset: 0x002CCBDC
			public void OnOnlineDanToggle(bool on)
			{
				this.m_owner.OnOnlineDanToggle(on);
			}

			// Token: 0x06009E8A RID: 40586 RVA: 0x002CE9EC File Offset: 0x002CCBEC
			public void OnOnlineLocalRankingToggle(bool on)
			{
				this.m_owner.OnOnlineLocalRankingToggle(on);
			}

			// Token: 0x06009E8B RID: 40587 RVA: 0x002CE9FC File Offset: 0x002CCBFC
			public void OnOnlineGlobalRankingToggle(bool on)
			{
				this.m_owner.OnOnlineGlobalRankingToggle(on);
			}

			// Token: 0x06009E8C RID: 40588 RVA: 0x002CEA0C File Offset: 0x002CCC0C
			public void OnOnlineWeekWinRewardButtonClick(GainRewardButton b)
			{
				this.m_owner.OnOnlineWeekWinRewardButtonClick(b);
			}

			// Token: 0x06009E8D RID: 40589 RVA: 0x002CEA1C File Offset: 0x002CCC1C
			public void OnOnlineBattleReportReplayButtonClick(OnlineArenaBattleReportListItemUIController ctrl)
			{
				this.m_owner.OnOnlineBattleReportReplayButtonClick(ctrl);
			}

			// Token: 0x06009E8E RID: 40590 RVA: 0x002CEA2C File Offset: 0x002CCC2C
			public void OnOnlineClashLadderChallengeButtonClick()
			{
				this.m_owner.OnOnlineClashLadderChallengeButtonClick();
			}

			// Token: 0x06009E8F RID: 40591 RVA: 0x002CEA3C File Offset: 0x002CCC3C
			public void OnOnlineClashCasualChallengeButtonClick()
			{
				this.m_owner.OnOnlineClashCasualChallengeButtonClick();
			}

			// Token: 0x06009E90 RID: 40592 RVA: 0x002CEA4C File Offset: 0x002CCC4C
			public void OnMatchingFailedConfirmButtonClick()
			{
				this.m_owner.OnMatchingFailedConfirmButtonClick();
			}

			// Token: 0x06009E91 RID: 40593 RVA: 0x002CEA5C File Offset: 0x002CCC5C
			public void OnMatchingNowCancelButtonClick()
			{
				this.m_owner.OnMatchingNowCancelButtonClick();
			}

			// Token: 0x06009E92 RID: 40594 RVA: 0x002CEA6C File Offset: 0x002CCC6C
			public void OnOnlineArenaRankingRewardButtonClick()
			{
				this.m_owner.OnOnlineArenaRankingRewardButtonClick();
			}

			// Token: 0x06009E93 RID: 40595 RVA: 0x002CEA7C File Offset: 0x002CCC7C
			public void OnOnlineArenaRankingRewardCloseButtonClick()
			{
				this.m_owner.OnOnlineArenaRankingRewardCloseButtonClick();
			}

			// Token: 0x06009E94 RID: 40596 RVA: 0x002CEA8C File Offset: 0x002CCC8C
			public void OnPromoteBattleConfirmButtonClick()
			{
				this.m_owner.OnPromoteBattleConfirmButtonClick();
			}

			// Token: 0x06009E95 RID: 40597 RVA: 0x002CEA9C File Offset: 0x002CCC9C
			public void OnPromoteSucceedConfirmButtonClick()
			{
				this.m_owner.OnPromoteSucceedConfirmButtonClick();
			}

			// Token: 0x04006B44 RID: 27460
			private ArenaUIController m_owner;
		}
	}
}
