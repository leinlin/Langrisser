using System;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using PD.SDK;
using SLua;
using SystemClipboard;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E94 RID: 3732
	[HotFix]
	public class PlayerInfoUIController : UIControllerBase
	{
		// Token: 0x060122CA RID: 74442 RVA: 0x004AD1D0 File Offset: 0x004AB3D0
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
			this.m_closeButton.onClick.AddListener(new UnityAction(this.OnCloseButtonClick));
			this.m_bgButton.onClick.AddListener(new UnityAction(this.OnCloseButtonClick));
			this.m_changeIconButton.onClick.AddListener(new UnityAction(this.OnChangeIconButtonClick));
			this.m_changeNameButton.onClick.AddListener(new UnityAction(this.OnChangeNameButtonClick));
			this.m_changeNameInputField.onEndEdit.AddListener(new UnityAction<string>(this.ChangeNameInputField_OnEndEdit));
			this.m_watchMyBusinessCardButton.onClick.AddListener(new UnityAction(this.OnWatchMyBusinessCardButtonClick));
			this.m_userCenterButton.onClick.AddListener(new UnityAction(this.OnUserCenterButtonClick));
			this.m_playerCenterButton.onClick.AddListener(new UnityAction(this.OnPlayerCenterButtonClick));
			this.m_signButton.onClick.AddListener(new UnityAction(this.OnSignButtonClick));
			this.m_settingButton.onClick.AddListener(new UnityAction(this.OnSettingButtonClick));
			this.m_recToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnRECToggleValueChanged));
			this.m_recToggle.gameObject.SetActive(Application.platform == RuntimePlatform.IPhonePlayer || Application.platform == RuntimePlatform.WindowsEditor);
			this.m_copyButton.onClick.AddListener(new UnityAction(this.OnCopyButtonClick));
			this.m_changeNamePanelBGButton.onClick.AddListener(new UnityAction(this.OnChangeNamePanelCloseButtonClick));
			this.m_confirmChangeNameButton.onClick.AddListener(new UnityAction(this.OnConfirmChangeNameButtonClick));
			this.m_voicePackageButton.onClick.AddListener(new UnityAction(this.OnVoicePackageButtonClick));
			this.m_forumButton.onClick.AddListener(new UnityAction(this.OnForumButtonClick));
			this.m_changeAccountButton.onClick.AddListener(new UnityAction(this.OnChangeAccountButtonClick));
			this.SetPlayerNameLimit(this.m_configDataLoader.ConfigableConstId_PlayerNameMaxLength);
			if (Application.platform == RuntimePlatform.IPhonePlayer || PDSDK.IsIosLoginWindowsPlayer)
			{
				this.m_redeemCodeButton.gameObject.SetActive(false);
			}
			else
			{
				this.m_redeemCodeButton.onClick.AddListener(new UnityAction(this.OnRedeemCodeButtonClick));
				this.m_redemptionCodeReturnButton.onClick.AddListener(new UnityAction(this.OnRedemptionCodeCancelButtonClick));
				this.m_redemptionCodeCancelButton.onClick.AddListener(new UnityAction(this.OnRedemptionCodeCancelButtonClick));
				this.m_redemptionCodeConfirmButton.onClick.AddListener(new UnityAction(this.OnRedemptionCodeConfirmButtonClick));
			}
			this.m_playerCenterButton.gameObject.SetActive(UIUtility.IsZiLongChannel());
			base.gameObject.SetActive(true);
		}

		// Token: 0x060122CB RID: 74443 RVA: 0x004AD508 File Offset: 0x004AB708
		public void UpdateViewInPlayerInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateViewInPlayerInfo_hotfix != null)
			{
				this.m_UpdateViewInPlayerInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerIconImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerSmallHeadIconImageName(this.m_playerContext.GetPlayerHeadPortrait()));
			UIUtility.SetPlayerHeadFrame(this.m_headFrameTransform, this.m_playerContext.GetPlayerHeadFrame(), true, "Normal");
			this.m_playerNameText.text = this.m_playerContext.GetPlayerName();
			this.m_playerLevelText.text = this.m_playerContext.GetPlayerLevel().ToString();
			this.m_playerExpProgressText.text = (this.m_playerContext.GetPlayerNextLevelExp() - this.m_playerContext.GetPlayerExp()).ToString();
			this.m_playerExpProgressImage.fillAmount = (float)this.m_playerContext.GetPlayerExp() / (float)this.m_playerContext.GetPlayerNextLevelExp();
			this.m_userIDText.text = this.m_playerContext.GetUserId();
			this.m_recToggle.isOn = LocalConfig.Instance.Data.ScreenRecordOn;
			this.m_versionText.text = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_PlayerInfo_Version) + this.m_configDataLoader.Version;
		}

		// Token: 0x060122CC RID: 74444 RVA: 0x004AD694 File Offset: 0x004AB894
		private void SetChangeNamePanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetChangeNamePanel_hotfix != null)
			{
				this.m_SetChangeNamePanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_changeNamePriceImage.sprite = AssetUtility.Instance.GetSprite("UI/Icon/Item_ABS/Item_MagicCrystal.png");
			this.m_changeNamePriceText.text = this.m_configDataLoader.ConfigableConstId_ChangeNameCostNums.ToString();
		}

		// Token: 0x060122CD RID: 74445 RVA: 0x004AD734 File Offset: 0x004AB934
		public void SetPlayerNameLimit(int count)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPlayerNameLimitInt32_hotfix != null)
			{
				this.m_SetPlayerNameLimitInt32_hotfix.call(new object[]
				{
					this,
					count
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_changeNameInputField.characterLimit = UIUtility.GetInputFieldCharacterLimit(count);
			this.m_playerNameLimit = count;
		}

		// Token: 0x060122CE RID: 74446 RVA: 0x004AD7BC File Offset: 0x004AB9BC
		public void PlayerInfoOpenTween()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerInfoOpenTween_hotfix != null)
			{
				this.m_PlayerInfoOpenTween_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_playerInfoContentStateCtrl, "Show", null, false, true);
		}

		// Token: 0x060122CF RID: 74447 RVA: 0x004AD830 File Offset: 0x004ABA30
		private void OnCloseButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCloseButtonClick_hotfix != null)
			{
				this.m_OnCloseButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_playerInfoContentStateCtrl, "Close", delegate
			{
				if (this.EventOnClose != null)
				{
					this.EventOnClose();
				}
			}, false, true);
		}

		// Token: 0x060122D0 RID: 74448 RVA: 0x004AD8B0 File Offset: 0x004ABAB0
		private void OnRECToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRECToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnRECToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnChangeRECState != null)
			{
				this.EventOnChangeRECState(isOn);
			}
		}

		// Token: 0x060122D1 RID: 74449 RVA: 0x004AD938 File Offset: 0x004ABB38
		private void OnUserCenterButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnUserCenterButtonClick_hotfix != null)
			{
				this.m_OnUserCenterButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			PDSDK.Instance.callCustomerServiceWeb();
		}

		// Token: 0x060122D2 RID: 74450 RVA: 0x004AD9A4 File Offset: 0x004ABBA4
		private void OnPlayerCenterButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPlayerCenterButtonClick_hotfix != null)
			{
				this.m_OnPlayerCenterButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			PDSDK.Instance.userCenter();
		}

		// Token: 0x060122D3 RID: 74451 RVA: 0x004ADA10 File Offset: 0x004ABC10
		private void OnSignButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSignButtonClick_hotfix != null)
			{
				this.m_OnSignButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowSign != null)
			{
				this.EventOnShowSign();
			}
		}

		// Token: 0x060122D4 RID: 74452 RVA: 0x004ADA88 File Offset: 0x004ABC88
		private void OnSettingButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSettingButtonClick_hotfix != null)
			{
				this.m_OnSettingButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowPlayerSetting != null)
			{
				this.EventOnShowPlayerSetting();
			}
		}

		// Token: 0x060122D5 RID: 74453 RVA: 0x004ADB00 File Offset: 0x004ABD00
		private void OnChangeNameButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnChangeNameButtonClick_hotfix != null)
			{
				this.m_OnChangeNameButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetChangeNamePanel();
			UIUtility.SetUIStateOpen(this.m_changeNameStateCtrl, "Show", null, false, true);
		}

		// Token: 0x060122D6 RID: 74454 RVA: 0x004ADB7C File Offset: 0x004ABD7C
		private void ChangeNameInputField_OnEndEdit(string str)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ChangeNameInputField_OnEndEditString_hotfix != null)
			{
				this.m_ChangeNameInputField_OnEndEditString_hotfix.call(new object[]
				{
					this,
					str
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_playerNameLimit > 0 && str.Length > this.m_playerNameLimit)
			{
				this.m_changeNameInputField.text = str.Substring(0, this.m_playerNameLimit);
			}
		}

		// Token: 0x060122D7 RID: 74455 RVA: 0x004ADC24 File Offset: 0x004ABE24
		private void OnWatchMyBusinessCardButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnWatchMyBusinessCardButtonClick_hotfix != null)
			{
				this.m_OnWatchMyBusinessCardButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowMyBusinessCard != null)
			{
				this.EventOnShowMyBusinessCard();
			}
		}

		// Token: 0x060122D8 RID: 74456 RVA: 0x004ADC9C File Offset: 0x004ABE9C
		private void OnConfirmChangeNameButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnConfirmChangeNameButtonClick_hotfix != null)
			{
				this.m_OnConfirmChangeNameButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_playerContext.CanChangePlayerName(this.m_changeNameInputField.text);
			if (num == 0)
			{
				if (this.EventOnChangeName != null)
				{
					this.EventOnChangeName(this.m_changeNameInputField.text);
				}
			}
			else if (num == -401)
			{
				if (this.EventOnCrystalNotEnough != null)
				{
					this.EventOnCrystalNotEnough();
				}
			}
			else
			{
				string txt = this.m_configDataLoader.UtilityGetErrorCodeString(num);
				CommonUIController.Instance.ShowMessage(txt, 2f, null, true);
			}
		}

		// Token: 0x060122D9 RID: 74457 RVA: 0x004ADD84 File Offset: 0x004ABF84
		public void OnChangeNamePanelCloseButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnChangeNamePanelCloseButtonClick_hotfix != null)
			{
				this.m_OnChangeNamePanelCloseButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_changeNameStateCtrl, "Close", delegate
			{
				this.m_changeNameInputField.text = string.Empty;
			}, false, true);
		}

		// Token: 0x060122DA RID: 74458 RVA: 0x004ADE04 File Offset: 0x004AC004
		private void OnCopyButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCopyButtonClick_hotfix != null)
			{
				this.m_OnCopyButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Clipboard.Text = this.m_userIDText.text;
		}

		// Token: 0x060122DB RID: 74459 RVA: 0x004ADE74 File Offset: 0x004AC074
		private void OnVoicePackageButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnVoicePackageButtonClick_hotfix != null)
			{
				this.m_OnVoicePackageButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_PlayerInfo_VoicePackage, 2f, null, true);
		}

		// Token: 0x060122DC RID: 74460 RVA: 0x004ADEEC File Offset: 0x004AC0EC
		private void OnChangeIconButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnChangeIconButtonClick_hotfix != null)
			{
				this.m_OnChangeIconButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowChangeIconPanel != null)
			{
				this.EventOnShowChangeIconPanel();
			}
		}

		// Token: 0x060122DD RID: 74461 RVA: 0x004ADF64 File Offset: 0x004AC164
		private void OnRedeemCodeButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRedeemCodeButtonClick_hotfix != null)
			{
				this.m_OnRedeemCodeButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_redemptionCodePanelUIStateCtrl.gameObject.SetActive(true);
			this.m_redemptionCodePanelUIStateCtrl.SetToUIState("Show", false, true);
			this.m_redemptionCodeInputField.text = string.Empty;
		}

		// Token: 0x060122DE RID: 74462 RVA: 0x004ADFF8 File Offset: 0x004AC1F8
		private void OnRedemptionCodeConfirmButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRedemptionCodeConfirmButtonClick_hotfix != null)
			{
				this.m_OnRedemptionCodeConfirmButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string text = this.m_redemptionCodeInputField.text;
			if (this.EventOnRedemptionCodeUse != null)
			{
				this.EventOnRedemptionCodeUse(text, delegate(int resultDetail)
				{
					string text2 = this.m_configDataLoader.UtilityGetStringByStringTable((StringTableId)resultDetail);
					if (text2 == null || text2 == string.Empty)
					{
						global::Debug.LogError("Unknown ResultDetail : " + resultDetail);
						text2 = "Unknown ResultDetail : " + resultDetail;
					}
					CommonUIController.Instance.ShowMessage(text2, 2f, null, true);
					this.OnRedemptionCodeCancelButtonClick();
				});
			}
		}

		// Token: 0x060122DF RID: 74463 RVA: 0x004AE088 File Offset: 0x004AC288
		private void OnRedemptionCodeCancelButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRedemptionCodeCancelButtonClick_hotfix != null)
			{
				this.m_OnRedemptionCodeCancelButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_redemptionCodePanelUIStateCtrl.SetActionForUIStateFinshed("Close", delegate
			{
				this.m_redemptionCodePanelUIStateCtrl.gameObject.SetActive(false);
			});
			this.m_redemptionCodePanelUIStateCtrl.SetToUIState("Close", false, true);
		}

		// Token: 0x060122E0 RID: 74464 RVA: 0x004AE118 File Offset: 0x004AC318
		private void OnForumButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnForumButtonClick_hotfix != null)
			{
				this.m_OnForumButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_PlayerInfo_Forum, 2f, null, true);
		}

		// Token: 0x060122E1 RID: 74465 RVA: 0x004AE190 File Offset: 0x004AC390
		private void OnChangeAccountButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnChangeAccountButtonClick_hotfix != null)
			{
				this.m_OnChangeAccountButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LoginUITask.ReturnToLoginAndSwitchUser();
		}

		// Token: 0x060122E2 RID: 74466 RVA: 0x004AE1F8 File Offset: 0x004AC3F8
		public void ShowChangeHeadIconPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowChangeHeadIconPanel_hotfix != null)
			{
				this.m_ShowChangeHeadIconPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_headIconUIController == null)
			{
				this.m_headIconUIController = GameObjectUtility.AddControllerToGameObject<PlayerInfoHeadIconUIController>(this.m_changeHeadIconPanelGameObj);
				this.m_headIconUIController.EventOnChangeHeadPortraitAndHeadFrame += this.EventOnChangeHeadPortraitAndHeadFrame;
			}
			this.m_headIconUIController.ShowChangeHeadIconPanel(this.m_playerHeadPortraitPrefab, this.m_playerHeadFramePrefab);
		}

		// Token: 0x060122E3 RID: 74467 RVA: 0x004AE2A4 File Offset: 0x004AC4A4
		public void OnChangeIconPanelCloseButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnChangeIconPanelCloseButtonClick_hotfix != null)
			{
				this.m_OnChangeIconPanelCloseButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_headIconUIController.OnChangeIconPanelCloseButtonClick();
		}

		// Token: 0x140003E7 RID: 999
		// (add) Token: 0x060122E4 RID: 74468 RVA: 0x004AE310 File Offset: 0x004AC510
		// (remove) Token: 0x060122E5 RID: 74469 RVA: 0x004AE3AC File Offset: 0x004AC5AC
		public event Action EventOnShowChangeIconPanel
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowChangeIconPanelAction_hotfix != null)
				{
					this.m_add_EventOnShowChangeIconPanelAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowChangeIconPanel;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowChangeIconPanel, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowChangeIconPanelAction_hotfix != null)
				{
					this.m_remove_EventOnShowChangeIconPanelAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowChangeIconPanel;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowChangeIconPanel, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003E8 RID: 1000
		// (add) Token: 0x060122E6 RID: 74470 RVA: 0x004AE448 File Offset: 0x004AC648
		// (remove) Token: 0x060122E7 RID: 74471 RVA: 0x004AE4E4 File Offset: 0x004AC6E4
		public event Action<int, int> EventOnChangeHeadPortraitAndHeadFrame
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnChangeHeadPortraitAndHeadFrameAction`2_hotfix != null)
				{
					this.m_add_EventOnChangeHeadPortraitAndHeadFrameAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int> action = this.EventOnChangeHeadPortraitAndHeadFrame;
				Action<int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int>>(ref this.EventOnChangeHeadPortraitAndHeadFrame, (Action<int, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnChangeHeadPortraitAndHeadFrameAction`2_hotfix != null)
				{
					this.m_remove_EventOnChangeHeadPortraitAndHeadFrameAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int> action = this.EventOnChangeHeadPortraitAndHeadFrame;
				Action<int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int>>(ref this.EventOnChangeHeadPortraitAndHeadFrame, (Action<int, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003E9 RID: 1001
		// (add) Token: 0x060122E8 RID: 74472 RVA: 0x004AE580 File Offset: 0x004AC780
		// (remove) Token: 0x060122E9 RID: 74473 RVA: 0x004AE61C File Offset: 0x004AC81C
		public event Action<string> EventOnChangeName
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnChangeNameAction`1_hotfix != null)
				{
					this.m_add_EventOnChangeNameAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnChangeName;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnChangeName, (Action<string>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnChangeNameAction`1_hotfix != null)
				{
					this.m_remove_EventOnChangeNameAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnChangeName;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnChangeName, (Action<string>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003EA RID: 1002
		// (add) Token: 0x060122EA RID: 74474 RVA: 0x004AE6B8 File Offset: 0x004AC8B8
		// (remove) Token: 0x060122EB RID: 74475 RVA: 0x004AE754 File Offset: 0x004AC954
		public event Action EventOnShowSign
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowSignAction_hotfix != null)
				{
					this.m_add_EventOnShowSignAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowSign;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowSign, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowSignAction_hotfix != null)
				{
					this.m_remove_EventOnShowSignAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowSign;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowSign, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003EB RID: 1003
		// (add) Token: 0x060122EC RID: 74476 RVA: 0x004AE7F0 File Offset: 0x004AC9F0
		// (remove) Token: 0x060122ED RID: 74477 RVA: 0x004AE88C File Offset: 0x004ACA8C
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

		// Token: 0x140003EC RID: 1004
		// (add) Token: 0x060122EE RID: 74478 RVA: 0x004AE928 File Offset: 0x004ACB28
		// (remove) Token: 0x060122EF RID: 74479 RVA: 0x004AE9C4 File Offset: 0x004ACBC4
		public event Action EventOnShowPlayerSetting
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowPlayerSettingAction_hotfix != null)
				{
					this.m_add_EventOnShowPlayerSettingAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowPlayerSetting;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowPlayerSetting, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowPlayerSettingAction_hotfix != null)
				{
					this.m_remove_EventOnShowPlayerSettingAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowPlayerSetting;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowPlayerSetting, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003ED RID: 1005
		// (add) Token: 0x060122F0 RID: 74480 RVA: 0x004AEA60 File Offset: 0x004ACC60
		// (remove) Token: 0x060122F1 RID: 74481 RVA: 0x004AEAFC File Offset: 0x004ACCFC
		public event Action EventOnShowMyBusinessCard
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowMyBusinessCardAction_hotfix != null)
				{
					this.m_add_EventOnShowMyBusinessCardAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowMyBusinessCard;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowMyBusinessCard, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowMyBusinessCardAction_hotfix != null)
				{
					this.m_remove_EventOnShowMyBusinessCardAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowMyBusinessCard;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowMyBusinessCard, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003EE RID: 1006
		// (add) Token: 0x060122F2 RID: 74482 RVA: 0x004AEB98 File Offset: 0x004ACD98
		// (remove) Token: 0x060122F3 RID: 74483 RVA: 0x004AEC34 File Offset: 0x004ACE34
		public event Action<bool> EventOnChangeRECState
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnChangeRECStateAction`1_hotfix != null)
				{
					this.m_add_EventOnChangeRECStateAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnChangeRECState;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnChangeRECState, (Action<bool>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnChangeRECStateAction`1_hotfix != null)
				{
					this.m_remove_EventOnChangeRECStateAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnChangeRECState;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnChangeRECState, (Action<bool>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003EF RID: 1007
		// (add) Token: 0x060122F4 RID: 74484 RVA: 0x004AECD0 File Offset: 0x004ACED0
		// (remove) Token: 0x060122F5 RID: 74485 RVA: 0x004AED6C File Offset: 0x004ACF6C
		public event Action<string, Action<int>> EventOnRedemptionCodeUse
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnRedemptionCodeUseAction`2_hotfix != null)
				{
					this.m_add_EventOnRedemptionCodeUseAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string, Action<int>> action = this.EventOnRedemptionCodeUse;
				Action<string, Action<int>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string, Action<int>>>(ref this.EventOnRedemptionCodeUse, (Action<string, Action<int>>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnRedemptionCodeUseAction`2_hotfix != null)
				{
					this.m_remove_EventOnRedemptionCodeUseAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string, Action<int>> action = this.EventOnRedemptionCodeUse;
				Action<string, Action<int>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string, Action<int>>>(ref this.EventOnRedemptionCodeUse, (Action<string, Action<int>>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003F0 RID: 1008
		// (add) Token: 0x060122F6 RID: 74486 RVA: 0x004AEE08 File Offset: 0x004AD008
		// (remove) Token: 0x060122F7 RID: 74487 RVA: 0x004AEEA4 File Offset: 0x004AD0A4
		public event Action EventOnCrystalNotEnough
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCrystalNotEnoughAction_hotfix != null)
				{
					this.m_add_EventOnCrystalNotEnoughAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCrystalNotEnough;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCrystalNotEnough, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCrystalNotEnoughAction_hotfix != null)
				{
					this.m_remove_EventOnCrystalNotEnoughAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCrystalNotEnough;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCrystalNotEnough, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003763 RID: 14179
		// (get) Token: 0x060122F8 RID: 74488 RVA: 0x004AEF40 File Offset: 0x004AD140
		// (set) Token: 0x060122F9 RID: 74489 RVA: 0x004AEF60 File Offset: 0x004AD160
		[DoNotToLua]
		public new PlayerInfoUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new PlayerInfoUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060122FA RID: 74490 RVA: 0x004AEF6C File Offset: 0x004AD16C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060122FB RID: 74491 RVA: 0x004AEF78 File Offset: 0x004AD178
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060122FC RID: 74492 RVA: 0x004AEF80 File Offset: 0x004AD180
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060122FD RID: 74493 RVA: 0x004AEF88 File Offset: 0x004AD188
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060122FE RID: 74494 RVA: 0x004AEF9C File Offset: 0x004AD19C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060122FF RID: 74495 RVA: 0x004AEFA4 File Offset: 0x004AD1A4
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06012300 RID: 74496 RVA: 0x004AEFB0 File Offset: 0x004AD1B0
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06012301 RID: 74497 RVA: 0x004AEFBC File Offset: 0x004AD1BC
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06012302 RID: 74498 RVA: 0x004AEFC8 File Offset: 0x004AD1C8
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06012303 RID: 74499 RVA: 0x004AEFD4 File Offset: 0x004AD1D4
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06012304 RID: 74500 RVA: 0x004AEFE0 File Offset: 0x004AD1E0
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06012305 RID: 74501 RVA: 0x004AEFEC File Offset: 0x004AD1EC
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06012306 RID: 74502 RVA: 0x004AEFF8 File Offset: 0x004AD1F8
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06012307 RID: 74503 RVA: 0x004AF004 File Offset: 0x004AD204
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06012308 RID: 74504 RVA: 0x004AF010 File Offset: 0x004AD210
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06012309 RID: 74505 RVA: 0x004AF018 File Offset: 0x004AD218
		private void __callDele_EventOnShowChangeIconPanel()
		{
			Action eventOnShowChangeIconPanel = this.EventOnShowChangeIconPanel;
			if (eventOnShowChangeIconPanel != null)
			{
				eventOnShowChangeIconPanel();
			}
		}

		// Token: 0x0601230A RID: 74506 RVA: 0x004AF038 File Offset: 0x004AD238
		private void __clearDele_EventOnShowChangeIconPanel()
		{
			this.EventOnShowChangeIconPanel = null;
		}

		// Token: 0x0601230B RID: 74507 RVA: 0x004AF044 File Offset: 0x004AD244
		private void __callDele_EventOnChangeHeadPortraitAndHeadFrame(int arg1, int arg2)
		{
			Action<int, int> eventOnChangeHeadPortraitAndHeadFrame = this.EventOnChangeHeadPortraitAndHeadFrame;
			if (eventOnChangeHeadPortraitAndHeadFrame != null)
			{
				eventOnChangeHeadPortraitAndHeadFrame(arg1, arg2);
			}
		}

		// Token: 0x0601230C RID: 74508 RVA: 0x004AF068 File Offset: 0x004AD268
		private void __clearDele_EventOnChangeHeadPortraitAndHeadFrame(int arg1, int arg2)
		{
			this.EventOnChangeHeadPortraitAndHeadFrame = null;
		}

		// Token: 0x0601230D RID: 74509 RVA: 0x004AF074 File Offset: 0x004AD274
		private void __callDele_EventOnChangeName(string obj)
		{
			Action<string> eventOnChangeName = this.EventOnChangeName;
			if (eventOnChangeName != null)
			{
				eventOnChangeName(obj);
			}
		}

		// Token: 0x0601230E RID: 74510 RVA: 0x004AF098 File Offset: 0x004AD298
		private void __clearDele_EventOnChangeName(string obj)
		{
			this.EventOnChangeName = null;
		}

		// Token: 0x0601230F RID: 74511 RVA: 0x004AF0A4 File Offset: 0x004AD2A4
		private void __callDele_EventOnShowSign()
		{
			Action eventOnShowSign = this.EventOnShowSign;
			if (eventOnShowSign != null)
			{
				eventOnShowSign();
			}
		}

		// Token: 0x06012310 RID: 74512 RVA: 0x004AF0C4 File Offset: 0x004AD2C4
		private void __clearDele_EventOnShowSign()
		{
			this.EventOnShowSign = null;
		}

		// Token: 0x06012311 RID: 74513 RVA: 0x004AF0D0 File Offset: 0x004AD2D0
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x06012312 RID: 74514 RVA: 0x004AF0F0 File Offset: 0x004AD2F0
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x06012313 RID: 74515 RVA: 0x004AF0FC File Offset: 0x004AD2FC
		private void __callDele_EventOnShowPlayerSetting()
		{
			Action eventOnShowPlayerSetting = this.EventOnShowPlayerSetting;
			if (eventOnShowPlayerSetting != null)
			{
				eventOnShowPlayerSetting();
			}
		}

		// Token: 0x06012314 RID: 74516 RVA: 0x004AF11C File Offset: 0x004AD31C
		private void __clearDele_EventOnShowPlayerSetting()
		{
			this.EventOnShowPlayerSetting = null;
		}

		// Token: 0x06012315 RID: 74517 RVA: 0x004AF128 File Offset: 0x004AD328
		private void __callDele_EventOnShowMyBusinessCard()
		{
			Action eventOnShowMyBusinessCard = this.EventOnShowMyBusinessCard;
			if (eventOnShowMyBusinessCard != null)
			{
				eventOnShowMyBusinessCard();
			}
		}

		// Token: 0x06012316 RID: 74518 RVA: 0x004AF148 File Offset: 0x004AD348
		private void __clearDele_EventOnShowMyBusinessCard()
		{
			this.EventOnShowMyBusinessCard = null;
		}

		// Token: 0x06012317 RID: 74519 RVA: 0x004AF154 File Offset: 0x004AD354
		private void __callDele_EventOnChangeRECState(bool obj)
		{
			Action<bool> eventOnChangeRECState = this.EventOnChangeRECState;
			if (eventOnChangeRECState != null)
			{
				eventOnChangeRECState(obj);
			}
		}

		// Token: 0x06012318 RID: 74520 RVA: 0x004AF178 File Offset: 0x004AD378
		private void __clearDele_EventOnChangeRECState(bool obj)
		{
			this.EventOnChangeRECState = null;
		}

		// Token: 0x06012319 RID: 74521 RVA: 0x004AF184 File Offset: 0x004AD384
		private void __callDele_EventOnRedemptionCodeUse(string arg1, Action<int> arg2)
		{
			Action<string, Action<int>> eventOnRedemptionCodeUse = this.EventOnRedemptionCodeUse;
			if (eventOnRedemptionCodeUse != null)
			{
				eventOnRedemptionCodeUse(arg1, arg2);
			}
		}

		// Token: 0x0601231A RID: 74522 RVA: 0x004AF1A8 File Offset: 0x004AD3A8
		private void __clearDele_EventOnRedemptionCodeUse(string arg1, Action<int> arg2)
		{
			this.EventOnRedemptionCodeUse = null;
		}

		// Token: 0x0601231B RID: 74523 RVA: 0x004AF1B4 File Offset: 0x004AD3B4
		private void __callDele_EventOnCrystalNotEnough()
		{
			Action eventOnCrystalNotEnough = this.EventOnCrystalNotEnough;
			if (eventOnCrystalNotEnough != null)
			{
				eventOnCrystalNotEnough();
			}
		}

		// Token: 0x0601231C RID: 74524 RVA: 0x004AF1D4 File Offset: 0x004AD3D4
		private void __clearDele_EventOnCrystalNotEnough()
		{
			this.EventOnCrystalNotEnough = null;
		}

		// Token: 0x06012321 RID: 74529 RVA: 0x004AF290 File Offset: 0x004AD490
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
					this.m_UpdateViewInPlayerInfo_hotfix = (luaObj.RawGet("UpdateViewInPlayerInfo") as LuaFunction);
					this.m_SetChangeNamePanel_hotfix = (luaObj.RawGet("SetChangeNamePanel") as LuaFunction);
					this.m_SetPlayerNameLimitInt32_hotfix = (luaObj.RawGet("SetPlayerNameLimit") as LuaFunction);
					this.m_PlayerInfoOpenTween_hotfix = (luaObj.RawGet("PlayerInfoOpenTween") as LuaFunction);
					this.m_OnCloseButtonClick_hotfix = (luaObj.RawGet("OnCloseButtonClick") as LuaFunction);
					this.m_OnRECToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnRECToggleValueChanged") as LuaFunction);
					this.m_OnUserCenterButtonClick_hotfix = (luaObj.RawGet("OnUserCenterButtonClick") as LuaFunction);
					this.m_OnPlayerCenterButtonClick_hotfix = (luaObj.RawGet("OnPlayerCenterButtonClick") as LuaFunction);
					this.m_OnSignButtonClick_hotfix = (luaObj.RawGet("OnSignButtonClick") as LuaFunction);
					this.m_OnSettingButtonClick_hotfix = (luaObj.RawGet("OnSettingButtonClick") as LuaFunction);
					this.m_OnChangeNameButtonClick_hotfix = (luaObj.RawGet("OnChangeNameButtonClick") as LuaFunction);
					this.m_ChangeNameInputField_OnEndEditString_hotfix = (luaObj.RawGet("ChangeNameInputField_OnEndEdit") as LuaFunction);
					this.m_OnWatchMyBusinessCardButtonClick_hotfix = (luaObj.RawGet("OnWatchMyBusinessCardButtonClick") as LuaFunction);
					this.m_OnConfirmChangeNameButtonClick_hotfix = (luaObj.RawGet("OnConfirmChangeNameButtonClick") as LuaFunction);
					this.m_OnChangeNamePanelCloseButtonClick_hotfix = (luaObj.RawGet("OnChangeNamePanelCloseButtonClick") as LuaFunction);
					this.m_OnCopyButtonClick_hotfix = (luaObj.RawGet("OnCopyButtonClick") as LuaFunction);
					this.m_OnVoicePackageButtonClick_hotfix = (luaObj.RawGet("OnVoicePackageButtonClick") as LuaFunction);
					this.m_OnChangeIconButtonClick_hotfix = (luaObj.RawGet("OnChangeIconButtonClick") as LuaFunction);
					this.m_OnRedeemCodeButtonClick_hotfix = (luaObj.RawGet("OnRedeemCodeButtonClick") as LuaFunction);
					this.m_OnRedemptionCodeConfirmButtonClick_hotfix = (luaObj.RawGet("OnRedemptionCodeConfirmButtonClick") as LuaFunction);
					this.m_OnRedemptionCodeCancelButtonClick_hotfix = (luaObj.RawGet("OnRedemptionCodeCancelButtonClick") as LuaFunction);
					this.m_OnForumButtonClick_hotfix = (luaObj.RawGet("OnForumButtonClick") as LuaFunction);
					this.m_OnChangeAccountButtonClick_hotfix = (luaObj.RawGet("OnChangeAccountButtonClick") as LuaFunction);
					this.m_ShowChangeHeadIconPanel_hotfix = (luaObj.RawGet("ShowChangeHeadIconPanel") as LuaFunction);
					this.m_OnChangeIconPanelCloseButtonClick_hotfix = (luaObj.RawGet("OnChangeIconPanelCloseButtonClick") as LuaFunction);
					this.m_add_EventOnShowChangeIconPanelAction_hotfix = (luaObj.RawGet("add_EventOnShowChangeIconPanel") as LuaFunction);
					this.m_remove_EventOnShowChangeIconPanelAction_hotfix = (luaObj.RawGet("remove_EventOnShowChangeIconPanel") as LuaFunction);
					this.m_add_EventOnChangeHeadPortraitAndHeadFrameAction`2_hotfix = (luaObj.RawGet("add_EventOnChangeHeadPortraitAndHeadFrame") as LuaFunction);
					this.m_remove_EventOnChangeHeadPortraitAndHeadFrameAction`2_hotfix = (luaObj.RawGet("remove_EventOnChangeHeadPortraitAndHeadFrame") as LuaFunction);
					this.m_add_EventOnChangeNameAction`1_hotfix = (luaObj.RawGet("add_EventOnChangeName") as LuaFunction);
					this.m_remove_EventOnChangeNameAction`1_hotfix = (luaObj.RawGet("remove_EventOnChangeName") as LuaFunction);
					this.m_add_EventOnShowSignAction_hotfix = (luaObj.RawGet("add_EventOnShowSign") as LuaFunction);
					this.m_remove_EventOnShowSignAction_hotfix = (luaObj.RawGet("remove_EventOnShowSign") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_add_EventOnShowPlayerSettingAction_hotfix = (luaObj.RawGet("add_EventOnShowPlayerSetting") as LuaFunction);
					this.m_remove_EventOnShowPlayerSettingAction_hotfix = (luaObj.RawGet("remove_EventOnShowPlayerSetting") as LuaFunction);
					this.m_add_EventOnShowMyBusinessCardAction_hotfix = (luaObj.RawGet("add_EventOnShowMyBusinessCard") as LuaFunction);
					this.m_remove_EventOnShowMyBusinessCardAction_hotfix = (luaObj.RawGet("remove_EventOnShowMyBusinessCard") as LuaFunction);
					this.m_add_EventOnChangeRECStateAction`1_hotfix = (luaObj.RawGet("add_EventOnChangeRECState") as LuaFunction);
					this.m_remove_EventOnChangeRECStateAction`1_hotfix = (luaObj.RawGet("remove_EventOnChangeRECState") as LuaFunction);
					this.m_add_EventOnRedemptionCodeUseAction`2_hotfix = (luaObj.RawGet("add_EventOnRedemptionCodeUse") as LuaFunction);
					this.m_remove_EventOnRedemptionCodeUseAction`2_hotfix = (luaObj.RawGet("remove_EventOnRedemptionCodeUse") as LuaFunction);
					this.m_add_EventOnCrystalNotEnoughAction_hotfix = (luaObj.RawGet("add_EventOnCrystalNotEnough") as LuaFunction);
					this.m_remove_EventOnCrystalNotEnoughAction_hotfix = (luaObj.RawGet("remove_EventOnCrystalNotEnough") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06012322 RID: 74530 RVA: 0x004AF7C0 File Offset: 0x004AD9C0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PlayerInfoUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A417 RID: 42007
		[AutoBind("./PlayerInfoContent", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_playerInfoContentStateCtrl;

		// Token: 0x0400A418 RID: 42008
		[AutoBind("./PlayerInfoContent/CloseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_closeButton;

		// Token: 0x0400A419 RID: 42009
		[AutoBind("./BGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_bgButton;

		// Token: 0x0400A41A RID: 42010
		[AutoBind("./PlayerInfoContent/TopPanel/PlayerIcon/Change", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_changeIconButton;

		// Token: 0x0400A41B RID: 42011
		[AutoBind("./PlayerInfoContent/TopPanel/PlayerName/Change", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_changeNameButton;

		// Token: 0x0400A41C RID: 42012
		[AutoBind("./PlayerInfoContent/TopPanel/NameCardButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_watchMyBusinessCardButton;

		// Token: 0x0400A41D RID: 42013
		[AutoBind("./PlayerInfoContent/TopPanel/CopyButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_copyButton;

		// Token: 0x0400A41E RID: 42014
		[AutoBind("./PlayerInfoContent/MiddlePanel/SignButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_signButton;

		// Token: 0x0400A41F RID: 42015
		[AutoBind("./PlayerInfoContent/MiddlePanel/SettingButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_settingButton;

		// Token: 0x0400A420 RID: 42016
		[AutoBind("./PlayerInfoContent/MiddlePanel/RECToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_recToggle;

		// Token: 0x0400A421 RID: 42017
		[AutoBind("./PlayerInfoContent/TopPanel/PlayerIcon/PlayerIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_playerIconImage;

		// Token: 0x0400A422 RID: 42018
		[AutoBind("./PlayerInfoContent/TopPanel/PlayerIcon/HeadFrameDummy", AutoBindAttribute.InitState.NotInit, false)]
		private Transform m_headFrameTransform;

		// Token: 0x0400A423 RID: 42019
		[AutoBind("./PlayerInfoContent/TopPanel/PlayerName/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerNameText;

		// Token: 0x0400A424 RID: 42020
		[AutoBind("./PlayerInfoContent/TopPanel/PlayerLevel/Level/LevelText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerLevelText;

		// Token: 0x0400A425 RID: 42021
		[AutoBind("./PlayerInfoContent/TopPanel/PlayerLevel/ProgressText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerExpProgressText;

		// Token: 0x0400A426 RID: 42022
		[AutoBind("./PlayerInfoContent/TopPanel/PlayerLevel/LevelProgress/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_playerExpProgressImage;

		// Token: 0x0400A427 RID: 42023
		[AutoBind("./PlayerInfoContent/TopPanel/AccountID/IDText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_userIDText;

		// Token: 0x0400A428 RID: 42024
		[AutoBind("./PlayerInfoContent/Version/VersionText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_versionText;

		// Token: 0x0400A429 RID: 42025
		[AutoBind("./ChangeNamePanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_changeNameStateCtrl;

		// Token: 0x0400A42A RID: 42026
		[AutoBind("./ChangeNamePanel/InputField", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_changeNameInputField;

		// Token: 0x0400A42B RID: 42027
		[AutoBind("./ChangeNamePanel/ConfirmButton/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_changeNamePriceImage;

		// Token: 0x0400A42C RID: 42028
		[AutoBind("./ChangeNamePanel/ConfirmButton/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_changeNamePriceText;

		// Token: 0x0400A42D RID: 42029
		[AutoBind("./ChangeNamePanel/BGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_changeNamePanelBGButton;

		// Token: 0x0400A42E RID: 42030
		[AutoBind("./ChangeNamePanel/ConfirmButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_confirmChangeNameButton;

		// Token: 0x0400A42F RID: 42031
		[AutoBind("./PlayerInfoContent/DownPanel/VoicePackage", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_voicePackageButton;

		// Token: 0x0400A430 RID: 42032
		[AutoBind("./PlayerInfoContent/DownPanel/RedeemCode", AutoBindAttribute.InitState.Active, false)]
		private Button m_redeemCodeButton;

		// Token: 0x0400A431 RID: 42033
		[AutoBind("./PlayerInfoContent/DownPanel/Forum", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_forumButton;

		// Token: 0x0400A432 RID: 42034
		[AutoBind("./PlayerInfoContent/DownPanel/ChangeAccount", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_changeAccountButton;

		// Token: 0x0400A433 RID: 42035
		[AutoBind("./PlayerInfoContent/DownPanel/UserCenter", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_userCenterButton;

		// Token: 0x0400A434 RID: 42036
		[AutoBind("./PlayerInfoContent/DownPanel/PlayerCenter", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_playerCenterButton;

		// Token: 0x0400A435 RID: 42037
		[AutoBind("./RedemptionCodePanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_redemptionCodePanelUIStateCtrl;

		// Token: 0x0400A436 RID: 42038
		[AutoBind("./RedemptionCodePanel/ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_redemptionCodeReturnButton;

		// Token: 0x0400A437 RID: 42039
		[AutoBind("./RedemptionCodePanel/Content/InputField", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_redemptionCodeInputField;

		// Token: 0x0400A438 RID: 42040
		[AutoBind("./RedemptionCodePanel/Content/CancelButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_redemptionCodeCancelButton;

		// Token: 0x0400A439 RID: 42041
		[AutoBind("./RedemptionCodePanel/Content/ConfirmButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_redemptionCodeConfirmButton;

		// Token: 0x0400A43A RID: 42042
		[AutoBind("./ChangeIconPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_changeHeadIconPanelGameObj;

		// Token: 0x0400A43B RID: 42043
		[AutoBind("./Prefab/PlayerIconPrefab", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_playerHeadPortraitPrefab;

		// Token: 0x0400A43C RID: 42044
		[AutoBind("./Prefab/HeadFramePrefab", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_playerHeadFramePrefab;

		// Token: 0x0400A43D RID: 42045
		private PlayerInfoHeadIconUIController m_headIconUIController;

		// Token: 0x0400A43E RID: 42046
		private ClientConfigDataLoader m_configDataLoader = GameManager.Instance.ConfigDataLoader as ClientConfigDataLoader;

		// Token: 0x0400A43F RID: 42047
		private ProjectLPlayerContext m_playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x0400A440 RID: 42048
		private int m_playerNameLimit;

		// Token: 0x0400A441 RID: 42049
		[DoNotToLua]
		private PlayerInfoUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A442 RID: 42050
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A443 RID: 42051
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A444 RID: 42052
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A445 RID: 42053
		private LuaFunction m_UpdateViewInPlayerInfo_hotfix;

		// Token: 0x0400A446 RID: 42054
		private LuaFunction m_SetChangeNamePanel_hotfix;

		// Token: 0x0400A447 RID: 42055
		private LuaFunction m_SetPlayerNameLimitInt32_hotfix;

		// Token: 0x0400A448 RID: 42056
		private LuaFunction m_PlayerInfoOpenTween_hotfix;

		// Token: 0x0400A449 RID: 42057
		private LuaFunction m_OnCloseButtonClick_hotfix;

		// Token: 0x0400A44A RID: 42058
		private LuaFunction m_OnRECToggleValueChangedBoolean_hotfix;

		// Token: 0x0400A44B RID: 42059
		private LuaFunction m_OnUserCenterButtonClick_hotfix;

		// Token: 0x0400A44C RID: 42060
		private LuaFunction m_OnPlayerCenterButtonClick_hotfix;

		// Token: 0x0400A44D RID: 42061
		private LuaFunction m_OnSignButtonClick_hotfix;

		// Token: 0x0400A44E RID: 42062
		private LuaFunction m_OnSettingButtonClick_hotfix;

		// Token: 0x0400A44F RID: 42063
		private LuaFunction m_OnChangeNameButtonClick_hotfix;

		// Token: 0x0400A450 RID: 42064
		private LuaFunction m_ChangeNameInputField_OnEndEditString_hotfix;

		// Token: 0x0400A451 RID: 42065
		private LuaFunction m_OnWatchMyBusinessCardButtonClick_hotfix;

		// Token: 0x0400A452 RID: 42066
		private LuaFunction m_OnConfirmChangeNameButtonClick_hotfix;

		// Token: 0x0400A453 RID: 42067
		private LuaFunction m_OnChangeNamePanelCloseButtonClick_hotfix;

		// Token: 0x0400A454 RID: 42068
		private LuaFunction m_OnCopyButtonClick_hotfix;

		// Token: 0x0400A455 RID: 42069
		private LuaFunction m_OnVoicePackageButtonClick_hotfix;

		// Token: 0x0400A456 RID: 42070
		private LuaFunction m_OnChangeIconButtonClick_hotfix;

		// Token: 0x0400A457 RID: 42071
		private LuaFunction m_OnRedeemCodeButtonClick_hotfix;

		// Token: 0x0400A458 RID: 42072
		private LuaFunction m_OnRedemptionCodeConfirmButtonClick_hotfix;

		// Token: 0x0400A459 RID: 42073
		private LuaFunction m_OnRedemptionCodeCancelButtonClick_hotfix;

		// Token: 0x0400A45A RID: 42074
		private LuaFunction m_OnForumButtonClick_hotfix;

		// Token: 0x0400A45B RID: 42075
		private LuaFunction m_OnChangeAccountButtonClick_hotfix;

		// Token: 0x0400A45C RID: 42076
		private LuaFunction m_ShowChangeHeadIconPanel_hotfix;

		// Token: 0x0400A45D RID: 42077
		private LuaFunction m_OnChangeIconPanelCloseButtonClick_hotfix;

		// Token: 0x0400A45E RID: 42078
		private LuaFunction m_add_EventOnShowChangeIconPanelAction_hotfix;

		// Token: 0x0400A45F RID: 42079
		private LuaFunction m_remove_EventOnShowChangeIconPanelAction_hotfix;

		// Token: 0x0400A460 RID: 42080
		private LuaFunction m_add_EventOnChangeHeadPortraitAndHeadFrameAction;

		// Token: 0x0400A461 RID: 42081
		private LuaFunction m_remove_EventOnChangeHeadPortraitAndHeadFrameAction;

		// Token: 0x0400A462 RID: 42082
		private LuaFunction m_add_EventOnChangeNameAction;

		// Token: 0x0400A463 RID: 42083
		private LuaFunction m_remove_EventOnChangeNameAction;

		// Token: 0x0400A464 RID: 42084
		private LuaFunction m_add_EventOnShowSignAction_hotfix;

		// Token: 0x0400A465 RID: 42085
		private LuaFunction m_remove_EventOnShowSignAction_hotfix;

		// Token: 0x0400A466 RID: 42086
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x0400A467 RID: 42087
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x0400A468 RID: 42088
		private LuaFunction m_add_EventOnShowPlayerSettingAction_hotfix;

		// Token: 0x0400A469 RID: 42089
		private LuaFunction m_remove_EventOnShowPlayerSettingAction_hotfix;

		// Token: 0x0400A46A RID: 42090
		private LuaFunction m_add_EventOnShowMyBusinessCardAction_hotfix;

		// Token: 0x0400A46B RID: 42091
		private LuaFunction m_remove_EventOnShowMyBusinessCardAction_hotfix;

		// Token: 0x0400A46C RID: 42092
		private LuaFunction m_add_EventOnChangeRECStateAction;

		// Token: 0x0400A46D RID: 42093
		private LuaFunction m_remove_EventOnChangeRECStateAction;

		// Token: 0x0400A46E RID: 42094
		private LuaFunction m_add_EventOnRedemptionCodeUseAction;

		// Token: 0x0400A46F RID: 42095
		private LuaFunction m_remove_EventOnRedemptionCodeUseAction;

		// Token: 0x0400A470 RID: 42096
		private LuaFunction m_add_EventOnCrystalNotEnoughAction_hotfix;

		// Token: 0x0400A471 RID: 42097
		private LuaFunction m_remove_EventOnCrystalNotEnoughAction_hotfix;

		// Token: 0x02000E95 RID: 3733
		public new class LuaExportHelper
		{
			// Token: 0x06012323 RID: 74531 RVA: 0x004AF828 File Offset: 0x004ADA28
			public LuaExportHelper(PlayerInfoUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06012324 RID: 74532 RVA: 0x004AF838 File Offset: 0x004ADA38
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06012325 RID: 74533 RVA: 0x004AF848 File Offset: 0x004ADA48
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06012326 RID: 74534 RVA: 0x004AF858 File Offset: 0x004ADA58
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06012327 RID: 74535 RVA: 0x004AF868 File Offset: 0x004ADA68
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06012328 RID: 74536 RVA: 0x004AF880 File Offset: 0x004ADA80
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06012329 RID: 74537 RVA: 0x004AF890 File Offset: 0x004ADA90
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0601232A RID: 74538 RVA: 0x004AF8A0 File Offset: 0x004ADAA0
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0601232B RID: 74539 RVA: 0x004AF8B0 File Offset: 0x004ADAB0
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0601232C RID: 74540 RVA: 0x004AF8C0 File Offset: 0x004ADAC0
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0601232D RID: 74541 RVA: 0x004AF8D0 File Offset: 0x004ADAD0
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0601232E RID: 74542 RVA: 0x004AF8E0 File Offset: 0x004ADAE0
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0601232F RID: 74543 RVA: 0x004AF8F0 File Offset: 0x004ADAF0
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06012330 RID: 74544 RVA: 0x004AF900 File Offset: 0x004ADB00
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06012331 RID: 74545 RVA: 0x004AF910 File Offset: 0x004ADB10
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06012332 RID: 74546 RVA: 0x004AF920 File Offset: 0x004ADB20
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06012333 RID: 74547 RVA: 0x004AF930 File Offset: 0x004ADB30
			public void __callDele_EventOnShowChangeIconPanel()
			{
				this.m_owner.__callDele_EventOnShowChangeIconPanel();
			}

			// Token: 0x06012334 RID: 74548 RVA: 0x004AF940 File Offset: 0x004ADB40
			public void __clearDele_EventOnShowChangeIconPanel()
			{
				this.m_owner.__clearDele_EventOnShowChangeIconPanel();
			}

			// Token: 0x06012335 RID: 74549 RVA: 0x004AF950 File Offset: 0x004ADB50
			public void __callDele_EventOnChangeHeadPortraitAndHeadFrame(int arg1, int arg2)
			{
				this.m_owner.__callDele_EventOnChangeHeadPortraitAndHeadFrame(arg1, arg2);
			}

			// Token: 0x06012336 RID: 74550 RVA: 0x004AF960 File Offset: 0x004ADB60
			public void __clearDele_EventOnChangeHeadPortraitAndHeadFrame(int arg1, int arg2)
			{
				this.m_owner.__clearDele_EventOnChangeHeadPortraitAndHeadFrame(arg1, arg2);
			}

			// Token: 0x06012337 RID: 74551 RVA: 0x004AF970 File Offset: 0x004ADB70
			public void __callDele_EventOnChangeName(string obj)
			{
				this.m_owner.__callDele_EventOnChangeName(obj);
			}

			// Token: 0x06012338 RID: 74552 RVA: 0x004AF980 File Offset: 0x004ADB80
			public void __clearDele_EventOnChangeName(string obj)
			{
				this.m_owner.__clearDele_EventOnChangeName(obj);
			}

			// Token: 0x06012339 RID: 74553 RVA: 0x004AF990 File Offset: 0x004ADB90
			public void __callDele_EventOnShowSign()
			{
				this.m_owner.__callDele_EventOnShowSign();
			}

			// Token: 0x0601233A RID: 74554 RVA: 0x004AF9A0 File Offset: 0x004ADBA0
			public void __clearDele_EventOnShowSign()
			{
				this.m_owner.__clearDele_EventOnShowSign();
			}

			// Token: 0x0601233B RID: 74555 RVA: 0x004AF9B0 File Offset: 0x004ADBB0
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0601233C RID: 74556 RVA: 0x004AF9C0 File Offset: 0x004ADBC0
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x0601233D RID: 74557 RVA: 0x004AF9D0 File Offset: 0x004ADBD0
			public void __callDele_EventOnShowPlayerSetting()
			{
				this.m_owner.__callDele_EventOnShowPlayerSetting();
			}

			// Token: 0x0601233E RID: 74558 RVA: 0x004AF9E0 File Offset: 0x004ADBE0
			public void __clearDele_EventOnShowPlayerSetting()
			{
				this.m_owner.__clearDele_EventOnShowPlayerSetting();
			}

			// Token: 0x0601233F RID: 74559 RVA: 0x004AF9F0 File Offset: 0x004ADBF0
			public void __callDele_EventOnShowMyBusinessCard()
			{
				this.m_owner.__callDele_EventOnShowMyBusinessCard();
			}

			// Token: 0x06012340 RID: 74560 RVA: 0x004AFA00 File Offset: 0x004ADC00
			public void __clearDele_EventOnShowMyBusinessCard()
			{
				this.m_owner.__clearDele_EventOnShowMyBusinessCard();
			}

			// Token: 0x06012341 RID: 74561 RVA: 0x004AFA10 File Offset: 0x004ADC10
			public void __callDele_EventOnChangeRECState(bool obj)
			{
				this.m_owner.__callDele_EventOnChangeRECState(obj);
			}

			// Token: 0x06012342 RID: 74562 RVA: 0x004AFA20 File Offset: 0x004ADC20
			public void __clearDele_EventOnChangeRECState(bool obj)
			{
				this.m_owner.__clearDele_EventOnChangeRECState(obj);
			}

			// Token: 0x06012343 RID: 74563 RVA: 0x004AFA30 File Offset: 0x004ADC30
			public void __callDele_EventOnRedemptionCodeUse(string arg1, Action<int> arg2)
			{
				this.m_owner.__callDele_EventOnRedemptionCodeUse(arg1, arg2);
			}

			// Token: 0x06012344 RID: 74564 RVA: 0x004AFA40 File Offset: 0x004ADC40
			public void __clearDele_EventOnRedemptionCodeUse(string arg1, Action<int> arg2)
			{
				this.m_owner.__clearDele_EventOnRedemptionCodeUse(arg1, arg2);
			}

			// Token: 0x06012345 RID: 74565 RVA: 0x004AFA50 File Offset: 0x004ADC50
			public void __callDele_EventOnCrystalNotEnough()
			{
				this.m_owner.__callDele_EventOnCrystalNotEnough();
			}

			// Token: 0x06012346 RID: 74566 RVA: 0x004AFA60 File Offset: 0x004ADC60
			public void __clearDele_EventOnCrystalNotEnough()
			{
				this.m_owner.__clearDele_EventOnCrystalNotEnough();
			}

			// Token: 0x17003764 RID: 14180
			// (get) Token: 0x06012347 RID: 74567 RVA: 0x004AFA70 File Offset: 0x004ADC70
			// (set) Token: 0x06012348 RID: 74568 RVA: 0x004AFA80 File Offset: 0x004ADC80
			public CommonUIStateController m_playerInfoContentStateCtrl
			{
				get
				{
					return this.m_owner.m_playerInfoContentStateCtrl;
				}
				set
				{
					this.m_owner.m_playerInfoContentStateCtrl = value;
				}
			}

			// Token: 0x17003765 RID: 14181
			// (get) Token: 0x06012349 RID: 74569 RVA: 0x004AFA90 File Offset: 0x004ADC90
			// (set) Token: 0x0601234A RID: 74570 RVA: 0x004AFAA0 File Offset: 0x004ADCA0
			public Button m_closeButton
			{
				get
				{
					return this.m_owner.m_closeButton;
				}
				set
				{
					this.m_owner.m_closeButton = value;
				}
			}

			// Token: 0x17003766 RID: 14182
			// (get) Token: 0x0601234B RID: 74571 RVA: 0x004AFAB0 File Offset: 0x004ADCB0
			// (set) Token: 0x0601234C RID: 74572 RVA: 0x004AFAC0 File Offset: 0x004ADCC0
			public Button m_bgButton
			{
				get
				{
					return this.m_owner.m_bgButton;
				}
				set
				{
					this.m_owner.m_bgButton = value;
				}
			}

			// Token: 0x17003767 RID: 14183
			// (get) Token: 0x0601234D RID: 74573 RVA: 0x004AFAD0 File Offset: 0x004ADCD0
			// (set) Token: 0x0601234E RID: 74574 RVA: 0x004AFAE0 File Offset: 0x004ADCE0
			public Button m_changeIconButton
			{
				get
				{
					return this.m_owner.m_changeIconButton;
				}
				set
				{
					this.m_owner.m_changeIconButton = value;
				}
			}

			// Token: 0x17003768 RID: 14184
			// (get) Token: 0x0601234F RID: 74575 RVA: 0x004AFAF0 File Offset: 0x004ADCF0
			// (set) Token: 0x06012350 RID: 74576 RVA: 0x004AFB00 File Offset: 0x004ADD00
			public Button m_changeNameButton
			{
				get
				{
					return this.m_owner.m_changeNameButton;
				}
				set
				{
					this.m_owner.m_changeNameButton = value;
				}
			}

			// Token: 0x17003769 RID: 14185
			// (get) Token: 0x06012351 RID: 74577 RVA: 0x004AFB10 File Offset: 0x004ADD10
			// (set) Token: 0x06012352 RID: 74578 RVA: 0x004AFB20 File Offset: 0x004ADD20
			public Button m_watchMyBusinessCardButton
			{
				get
				{
					return this.m_owner.m_watchMyBusinessCardButton;
				}
				set
				{
					this.m_owner.m_watchMyBusinessCardButton = value;
				}
			}

			// Token: 0x1700376A RID: 14186
			// (get) Token: 0x06012353 RID: 74579 RVA: 0x004AFB30 File Offset: 0x004ADD30
			// (set) Token: 0x06012354 RID: 74580 RVA: 0x004AFB40 File Offset: 0x004ADD40
			public Button m_copyButton
			{
				get
				{
					return this.m_owner.m_copyButton;
				}
				set
				{
					this.m_owner.m_copyButton = value;
				}
			}

			// Token: 0x1700376B RID: 14187
			// (get) Token: 0x06012355 RID: 74581 RVA: 0x004AFB50 File Offset: 0x004ADD50
			// (set) Token: 0x06012356 RID: 74582 RVA: 0x004AFB60 File Offset: 0x004ADD60
			public Button m_signButton
			{
				get
				{
					return this.m_owner.m_signButton;
				}
				set
				{
					this.m_owner.m_signButton = value;
				}
			}

			// Token: 0x1700376C RID: 14188
			// (get) Token: 0x06012357 RID: 74583 RVA: 0x004AFB70 File Offset: 0x004ADD70
			// (set) Token: 0x06012358 RID: 74584 RVA: 0x004AFB80 File Offset: 0x004ADD80
			public Button m_settingButton
			{
				get
				{
					return this.m_owner.m_settingButton;
				}
				set
				{
					this.m_owner.m_settingButton = value;
				}
			}

			// Token: 0x1700376D RID: 14189
			// (get) Token: 0x06012359 RID: 74585 RVA: 0x004AFB90 File Offset: 0x004ADD90
			// (set) Token: 0x0601235A RID: 74586 RVA: 0x004AFBA0 File Offset: 0x004ADDA0
			public Toggle m_recToggle
			{
				get
				{
					return this.m_owner.m_recToggle;
				}
				set
				{
					this.m_owner.m_recToggle = value;
				}
			}

			// Token: 0x1700376E RID: 14190
			// (get) Token: 0x0601235B RID: 74587 RVA: 0x004AFBB0 File Offset: 0x004ADDB0
			// (set) Token: 0x0601235C RID: 74588 RVA: 0x004AFBC0 File Offset: 0x004ADDC0
			public Image m_playerIconImage
			{
				get
				{
					return this.m_owner.m_playerIconImage;
				}
				set
				{
					this.m_owner.m_playerIconImage = value;
				}
			}

			// Token: 0x1700376F RID: 14191
			// (get) Token: 0x0601235D RID: 74589 RVA: 0x004AFBD0 File Offset: 0x004ADDD0
			// (set) Token: 0x0601235E RID: 74590 RVA: 0x004AFBE0 File Offset: 0x004ADDE0
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

			// Token: 0x17003770 RID: 14192
			// (get) Token: 0x0601235F RID: 74591 RVA: 0x004AFBF0 File Offset: 0x004ADDF0
			// (set) Token: 0x06012360 RID: 74592 RVA: 0x004AFC00 File Offset: 0x004ADE00
			public Text m_playerNameText
			{
				get
				{
					return this.m_owner.m_playerNameText;
				}
				set
				{
					this.m_owner.m_playerNameText = value;
				}
			}

			// Token: 0x17003771 RID: 14193
			// (get) Token: 0x06012361 RID: 74593 RVA: 0x004AFC10 File Offset: 0x004ADE10
			// (set) Token: 0x06012362 RID: 74594 RVA: 0x004AFC20 File Offset: 0x004ADE20
			public Text m_playerLevelText
			{
				get
				{
					return this.m_owner.m_playerLevelText;
				}
				set
				{
					this.m_owner.m_playerLevelText = value;
				}
			}

			// Token: 0x17003772 RID: 14194
			// (get) Token: 0x06012363 RID: 74595 RVA: 0x004AFC30 File Offset: 0x004ADE30
			// (set) Token: 0x06012364 RID: 74596 RVA: 0x004AFC40 File Offset: 0x004ADE40
			public Text m_playerExpProgressText
			{
				get
				{
					return this.m_owner.m_playerExpProgressText;
				}
				set
				{
					this.m_owner.m_playerExpProgressText = value;
				}
			}

			// Token: 0x17003773 RID: 14195
			// (get) Token: 0x06012365 RID: 74597 RVA: 0x004AFC50 File Offset: 0x004ADE50
			// (set) Token: 0x06012366 RID: 74598 RVA: 0x004AFC60 File Offset: 0x004ADE60
			public Image m_playerExpProgressImage
			{
				get
				{
					return this.m_owner.m_playerExpProgressImage;
				}
				set
				{
					this.m_owner.m_playerExpProgressImage = value;
				}
			}

			// Token: 0x17003774 RID: 14196
			// (get) Token: 0x06012367 RID: 74599 RVA: 0x004AFC70 File Offset: 0x004ADE70
			// (set) Token: 0x06012368 RID: 74600 RVA: 0x004AFC80 File Offset: 0x004ADE80
			public Text m_userIDText
			{
				get
				{
					return this.m_owner.m_userIDText;
				}
				set
				{
					this.m_owner.m_userIDText = value;
				}
			}

			// Token: 0x17003775 RID: 14197
			// (get) Token: 0x06012369 RID: 74601 RVA: 0x004AFC90 File Offset: 0x004ADE90
			// (set) Token: 0x0601236A RID: 74602 RVA: 0x004AFCA0 File Offset: 0x004ADEA0
			public Text m_versionText
			{
				get
				{
					return this.m_owner.m_versionText;
				}
				set
				{
					this.m_owner.m_versionText = value;
				}
			}

			// Token: 0x17003776 RID: 14198
			// (get) Token: 0x0601236B RID: 74603 RVA: 0x004AFCB0 File Offset: 0x004ADEB0
			// (set) Token: 0x0601236C RID: 74604 RVA: 0x004AFCC0 File Offset: 0x004ADEC0
			public CommonUIStateController m_changeNameStateCtrl
			{
				get
				{
					return this.m_owner.m_changeNameStateCtrl;
				}
				set
				{
					this.m_owner.m_changeNameStateCtrl = value;
				}
			}

			// Token: 0x17003777 RID: 14199
			// (get) Token: 0x0601236D RID: 74605 RVA: 0x004AFCD0 File Offset: 0x004ADED0
			// (set) Token: 0x0601236E RID: 74606 RVA: 0x004AFCE0 File Offset: 0x004ADEE0
			public InputField m_changeNameInputField
			{
				get
				{
					return this.m_owner.m_changeNameInputField;
				}
				set
				{
					this.m_owner.m_changeNameInputField = value;
				}
			}

			// Token: 0x17003778 RID: 14200
			// (get) Token: 0x0601236F RID: 74607 RVA: 0x004AFCF0 File Offset: 0x004ADEF0
			// (set) Token: 0x06012370 RID: 74608 RVA: 0x004AFD00 File Offset: 0x004ADF00
			public Image m_changeNamePriceImage
			{
				get
				{
					return this.m_owner.m_changeNamePriceImage;
				}
				set
				{
					this.m_owner.m_changeNamePriceImage = value;
				}
			}

			// Token: 0x17003779 RID: 14201
			// (get) Token: 0x06012371 RID: 74609 RVA: 0x004AFD10 File Offset: 0x004ADF10
			// (set) Token: 0x06012372 RID: 74610 RVA: 0x004AFD20 File Offset: 0x004ADF20
			public Text m_changeNamePriceText
			{
				get
				{
					return this.m_owner.m_changeNamePriceText;
				}
				set
				{
					this.m_owner.m_changeNamePriceText = value;
				}
			}

			// Token: 0x1700377A RID: 14202
			// (get) Token: 0x06012373 RID: 74611 RVA: 0x004AFD30 File Offset: 0x004ADF30
			// (set) Token: 0x06012374 RID: 74612 RVA: 0x004AFD40 File Offset: 0x004ADF40
			public Button m_changeNamePanelBGButton
			{
				get
				{
					return this.m_owner.m_changeNamePanelBGButton;
				}
				set
				{
					this.m_owner.m_changeNamePanelBGButton = value;
				}
			}

			// Token: 0x1700377B RID: 14203
			// (get) Token: 0x06012375 RID: 74613 RVA: 0x004AFD50 File Offset: 0x004ADF50
			// (set) Token: 0x06012376 RID: 74614 RVA: 0x004AFD60 File Offset: 0x004ADF60
			public Button m_confirmChangeNameButton
			{
				get
				{
					return this.m_owner.m_confirmChangeNameButton;
				}
				set
				{
					this.m_owner.m_confirmChangeNameButton = value;
				}
			}

			// Token: 0x1700377C RID: 14204
			// (get) Token: 0x06012377 RID: 74615 RVA: 0x004AFD70 File Offset: 0x004ADF70
			// (set) Token: 0x06012378 RID: 74616 RVA: 0x004AFD80 File Offset: 0x004ADF80
			public Button m_voicePackageButton
			{
				get
				{
					return this.m_owner.m_voicePackageButton;
				}
				set
				{
					this.m_owner.m_voicePackageButton = value;
				}
			}

			// Token: 0x1700377D RID: 14205
			// (get) Token: 0x06012379 RID: 74617 RVA: 0x004AFD90 File Offset: 0x004ADF90
			// (set) Token: 0x0601237A RID: 74618 RVA: 0x004AFDA0 File Offset: 0x004ADFA0
			public Button m_redeemCodeButton
			{
				get
				{
					return this.m_owner.m_redeemCodeButton;
				}
				set
				{
					this.m_owner.m_redeemCodeButton = value;
				}
			}

			// Token: 0x1700377E RID: 14206
			// (get) Token: 0x0601237B RID: 74619 RVA: 0x004AFDB0 File Offset: 0x004ADFB0
			// (set) Token: 0x0601237C RID: 74620 RVA: 0x004AFDC0 File Offset: 0x004ADFC0
			public Button m_forumButton
			{
				get
				{
					return this.m_owner.m_forumButton;
				}
				set
				{
					this.m_owner.m_forumButton = value;
				}
			}

			// Token: 0x1700377F RID: 14207
			// (get) Token: 0x0601237D RID: 74621 RVA: 0x004AFDD0 File Offset: 0x004ADFD0
			// (set) Token: 0x0601237E RID: 74622 RVA: 0x004AFDE0 File Offset: 0x004ADFE0
			public Button m_changeAccountButton
			{
				get
				{
					return this.m_owner.m_changeAccountButton;
				}
				set
				{
					this.m_owner.m_changeAccountButton = value;
				}
			}

			// Token: 0x17003780 RID: 14208
			// (get) Token: 0x0601237F RID: 74623 RVA: 0x004AFDF0 File Offset: 0x004ADFF0
			// (set) Token: 0x06012380 RID: 74624 RVA: 0x004AFE00 File Offset: 0x004AE000
			public Button m_userCenterButton
			{
				get
				{
					return this.m_owner.m_userCenterButton;
				}
				set
				{
					this.m_owner.m_userCenterButton = value;
				}
			}

			// Token: 0x17003781 RID: 14209
			// (get) Token: 0x06012381 RID: 74625 RVA: 0x004AFE10 File Offset: 0x004AE010
			// (set) Token: 0x06012382 RID: 74626 RVA: 0x004AFE20 File Offset: 0x004AE020
			public Button m_playerCenterButton
			{
				get
				{
					return this.m_owner.m_playerCenterButton;
				}
				set
				{
					this.m_owner.m_playerCenterButton = value;
				}
			}

			// Token: 0x17003782 RID: 14210
			// (get) Token: 0x06012383 RID: 74627 RVA: 0x004AFE30 File Offset: 0x004AE030
			// (set) Token: 0x06012384 RID: 74628 RVA: 0x004AFE40 File Offset: 0x004AE040
			public CommonUIStateController m_redemptionCodePanelUIStateCtrl
			{
				get
				{
					return this.m_owner.m_redemptionCodePanelUIStateCtrl;
				}
				set
				{
					this.m_owner.m_redemptionCodePanelUIStateCtrl = value;
				}
			}

			// Token: 0x17003783 RID: 14211
			// (get) Token: 0x06012385 RID: 74629 RVA: 0x004AFE50 File Offset: 0x004AE050
			// (set) Token: 0x06012386 RID: 74630 RVA: 0x004AFE60 File Offset: 0x004AE060
			public Button m_redemptionCodeReturnButton
			{
				get
				{
					return this.m_owner.m_redemptionCodeReturnButton;
				}
				set
				{
					this.m_owner.m_redemptionCodeReturnButton = value;
				}
			}

			// Token: 0x17003784 RID: 14212
			// (get) Token: 0x06012387 RID: 74631 RVA: 0x004AFE70 File Offset: 0x004AE070
			// (set) Token: 0x06012388 RID: 74632 RVA: 0x004AFE80 File Offset: 0x004AE080
			public InputField m_redemptionCodeInputField
			{
				get
				{
					return this.m_owner.m_redemptionCodeInputField;
				}
				set
				{
					this.m_owner.m_redemptionCodeInputField = value;
				}
			}

			// Token: 0x17003785 RID: 14213
			// (get) Token: 0x06012389 RID: 74633 RVA: 0x004AFE90 File Offset: 0x004AE090
			// (set) Token: 0x0601238A RID: 74634 RVA: 0x004AFEA0 File Offset: 0x004AE0A0
			public Button m_redemptionCodeCancelButton
			{
				get
				{
					return this.m_owner.m_redemptionCodeCancelButton;
				}
				set
				{
					this.m_owner.m_redemptionCodeCancelButton = value;
				}
			}

			// Token: 0x17003786 RID: 14214
			// (get) Token: 0x0601238B RID: 74635 RVA: 0x004AFEB0 File Offset: 0x004AE0B0
			// (set) Token: 0x0601238C RID: 74636 RVA: 0x004AFEC0 File Offset: 0x004AE0C0
			public Button m_redemptionCodeConfirmButton
			{
				get
				{
					return this.m_owner.m_redemptionCodeConfirmButton;
				}
				set
				{
					this.m_owner.m_redemptionCodeConfirmButton = value;
				}
			}

			// Token: 0x17003787 RID: 14215
			// (get) Token: 0x0601238D RID: 74637 RVA: 0x004AFED0 File Offset: 0x004AE0D0
			// (set) Token: 0x0601238E RID: 74638 RVA: 0x004AFEE0 File Offset: 0x004AE0E0
			public GameObject m_changeHeadIconPanelGameObj
			{
				get
				{
					return this.m_owner.m_changeHeadIconPanelGameObj;
				}
				set
				{
					this.m_owner.m_changeHeadIconPanelGameObj = value;
				}
			}

			// Token: 0x17003788 RID: 14216
			// (get) Token: 0x0601238F RID: 74639 RVA: 0x004AFEF0 File Offset: 0x004AE0F0
			// (set) Token: 0x06012390 RID: 74640 RVA: 0x004AFF00 File Offset: 0x004AE100
			public GameObject m_playerHeadPortraitPrefab
			{
				get
				{
					return this.m_owner.m_playerHeadPortraitPrefab;
				}
				set
				{
					this.m_owner.m_playerHeadPortraitPrefab = value;
				}
			}

			// Token: 0x17003789 RID: 14217
			// (get) Token: 0x06012391 RID: 74641 RVA: 0x004AFF10 File Offset: 0x004AE110
			// (set) Token: 0x06012392 RID: 74642 RVA: 0x004AFF20 File Offset: 0x004AE120
			public GameObject m_playerHeadFramePrefab
			{
				get
				{
					return this.m_owner.m_playerHeadFramePrefab;
				}
				set
				{
					this.m_owner.m_playerHeadFramePrefab = value;
				}
			}

			// Token: 0x1700378A RID: 14218
			// (get) Token: 0x06012393 RID: 74643 RVA: 0x004AFF30 File Offset: 0x004AE130
			// (set) Token: 0x06012394 RID: 74644 RVA: 0x004AFF40 File Offset: 0x004AE140
			public PlayerInfoHeadIconUIController m_headIconUIController
			{
				get
				{
					return this.m_owner.m_headIconUIController;
				}
				set
				{
					this.m_owner.m_headIconUIController = value;
				}
			}

			// Token: 0x1700378B RID: 14219
			// (get) Token: 0x06012395 RID: 74645 RVA: 0x004AFF50 File Offset: 0x004AE150
			// (set) Token: 0x06012396 RID: 74646 RVA: 0x004AFF60 File Offset: 0x004AE160
			public ClientConfigDataLoader m_configDataLoader
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

			// Token: 0x1700378C RID: 14220
			// (get) Token: 0x06012397 RID: 74647 RVA: 0x004AFF70 File Offset: 0x004AE170
			// (set) Token: 0x06012398 RID: 74648 RVA: 0x004AFF80 File Offset: 0x004AE180
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

			// Token: 0x1700378D RID: 14221
			// (get) Token: 0x06012399 RID: 74649 RVA: 0x004AFF90 File Offset: 0x004AE190
			// (set) Token: 0x0601239A RID: 74650 RVA: 0x004AFFA0 File Offset: 0x004AE1A0
			public int m_playerNameLimit
			{
				get
				{
					return this.m_owner.m_playerNameLimit;
				}
				set
				{
					this.m_owner.m_playerNameLimit = value;
				}
			}

			// Token: 0x0601239B RID: 74651 RVA: 0x004AFFB0 File Offset: 0x004AE1B0
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0601239C RID: 74652 RVA: 0x004AFFC0 File Offset: 0x004AE1C0
			public void SetChangeNamePanel()
			{
				this.m_owner.SetChangeNamePanel();
			}

			// Token: 0x0601239D RID: 74653 RVA: 0x004AFFD0 File Offset: 0x004AE1D0
			public void OnCloseButtonClick()
			{
				this.m_owner.OnCloseButtonClick();
			}

			// Token: 0x0601239E RID: 74654 RVA: 0x004AFFE0 File Offset: 0x004AE1E0
			public void OnRECToggleValueChanged(bool isOn)
			{
				this.m_owner.OnRECToggleValueChanged(isOn);
			}

			// Token: 0x0601239F RID: 74655 RVA: 0x004AFFF0 File Offset: 0x004AE1F0
			public void OnUserCenterButtonClick()
			{
				this.m_owner.OnUserCenterButtonClick();
			}

			// Token: 0x060123A0 RID: 74656 RVA: 0x004B0000 File Offset: 0x004AE200
			public void OnPlayerCenterButtonClick()
			{
				this.m_owner.OnPlayerCenterButtonClick();
			}

			// Token: 0x060123A1 RID: 74657 RVA: 0x004B0010 File Offset: 0x004AE210
			public void OnSignButtonClick()
			{
				this.m_owner.OnSignButtonClick();
			}

			// Token: 0x060123A2 RID: 74658 RVA: 0x004B0020 File Offset: 0x004AE220
			public void OnSettingButtonClick()
			{
				this.m_owner.OnSettingButtonClick();
			}

			// Token: 0x060123A3 RID: 74659 RVA: 0x004B0030 File Offset: 0x004AE230
			public void OnChangeNameButtonClick()
			{
				this.m_owner.OnChangeNameButtonClick();
			}

			// Token: 0x060123A4 RID: 74660 RVA: 0x004B0040 File Offset: 0x004AE240
			public void ChangeNameInputField_OnEndEdit(string str)
			{
				this.m_owner.ChangeNameInputField_OnEndEdit(str);
			}

			// Token: 0x060123A5 RID: 74661 RVA: 0x004B0050 File Offset: 0x004AE250
			public void OnWatchMyBusinessCardButtonClick()
			{
				this.m_owner.OnWatchMyBusinessCardButtonClick();
			}

			// Token: 0x060123A6 RID: 74662 RVA: 0x004B0060 File Offset: 0x004AE260
			public void OnConfirmChangeNameButtonClick()
			{
				this.m_owner.OnConfirmChangeNameButtonClick();
			}

			// Token: 0x060123A7 RID: 74663 RVA: 0x004B0070 File Offset: 0x004AE270
			public void OnCopyButtonClick()
			{
				this.m_owner.OnCopyButtonClick();
			}

			// Token: 0x060123A8 RID: 74664 RVA: 0x004B0080 File Offset: 0x004AE280
			public void OnVoicePackageButtonClick()
			{
				this.m_owner.OnVoicePackageButtonClick();
			}

			// Token: 0x060123A9 RID: 74665 RVA: 0x004B0090 File Offset: 0x004AE290
			public void OnChangeIconButtonClick()
			{
				this.m_owner.OnChangeIconButtonClick();
			}

			// Token: 0x060123AA RID: 74666 RVA: 0x004B00A0 File Offset: 0x004AE2A0
			public void OnRedeemCodeButtonClick()
			{
				this.m_owner.OnRedeemCodeButtonClick();
			}

			// Token: 0x060123AB RID: 74667 RVA: 0x004B00B0 File Offset: 0x004AE2B0
			public void OnRedemptionCodeConfirmButtonClick()
			{
				this.m_owner.OnRedemptionCodeConfirmButtonClick();
			}

			// Token: 0x060123AC RID: 74668 RVA: 0x004B00C0 File Offset: 0x004AE2C0
			public void OnRedemptionCodeCancelButtonClick()
			{
				this.m_owner.OnRedemptionCodeCancelButtonClick();
			}

			// Token: 0x060123AD RID: 74669 RVA: 0x004B00D0 File Offset: 0x004AE2D0
			public void OnForumButtonClick()
			{
				this.m_owner.OnForumButtonClick();
			}

			// Token: 0x060123AE RID: 74670 RVA: 0x004B00E0 File Offset: 0x004AE2E0
			public void OnChangeAccountButtonClick()
			{
				this.m_owner.OnChangeAccountButtonClick();
			}

			// Token: 0x0400A472 RID: 42098
			private PlayerInfoUIController m_owner;
		}
	}
}
