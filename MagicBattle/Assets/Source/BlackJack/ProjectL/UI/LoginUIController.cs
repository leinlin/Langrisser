using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using PD.SDK;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E37 RID: 3639
	[HotFix]
	public class LoginUIController : UIControllerBase
	{
		// Token: 0x06011981 RID: 72065 RVA: 0x0048CFB0 File Offset: 0x0048B1B0
		private LoginUIController()
		{
		}

		// Token: 0x06011982 RID: 72066 RVA: 0x0048CFC0 File Offset: 0x0048B1C0
		private void Start()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Start_hotfix != null)
			{
				this.m_Start_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			PDSDK.Instance.printGameEventLog("3", string.Empty);
			this.IsLoginButtonClicked = false;
		}

		// Token: 0x06011983 RID: 72067 RVA: 0x0048D03C File Offset: 0x0048B23C
		private void OnEnable()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEnable_hotfix != null)
			{
				this.m_OnEnable_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.IsLoginButtonClicked = false;
		}

		// Token: 0x06011984 RID: 72068 RVA: 0x0048D0A4 File Offset: 0x0048B2A4
		public void SetServerInfo(LoginUITask.ServerInfo serverInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetServerInfoServerInfo_hotfix != null)
			{
				this.m_SetServerInfoServerInfo_hotfix.call(new object[]
				{
					this,
					serverInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (serverInfo == null)
			{
				return;
			}
			this.m_selectServerName.text = serverInfo.m_name;
		}

		// Token: 0x06011985 RID: 72069 RVA: 0x0048D12C File Offset: 0x0048B32C
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
			this.m_loginButton.onClick.AddListener(new UnityAction(this.OnLoginButtonClick));
			this.m_sdkLoginButton.onClick.AddListener(new UnityAction(this.OnLoginButtonClick));
			this.m_selectServerButton.onClick.AddListener(new UnityAction(this.OnSelectServerButtonClick));
			this.m_showServerButton.onClick.AddListener(new UnityAction(this.OnShowServerButtonClick));
			this.m_selectServerName.text = string.Empty;
			this.m_openAnnounceButton.onClick.AddListener(new UnityAction(this.OnOpenAnnouncePanel));
			this.m_closeAnnounceButton.onClick.AddListener(new UnityAction(this.OnCloseAnnouncePanel));
			this.m_announceBGButton.onClick.AddListener(new UnityAction(this.OnCloseAnnouncePanel));
			this.m_fastEnterGameToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnToggleFastEnterGame));
			this.m_testFirstBattleToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnToggleTestFirstBattle));
			this.m_saveServerConfigButton.onClick.AddListener(new UnityAction(this.OnSaveServerConfigClick));
			this.m_switchUserButton.onClick.AddListener(new UnityAction(this.OnOpenUserCenterButtonClick));
			this.m_accountInputField.onValueChanged.AddListener(new UnityAction<string>(this.OnAccountTextChanged));
			this.m_loginPCClientButton.onClick.AddListener(new UnityAction(this.OnLoginPCClientButtonClick));
			this.m_announceListScrollRect.onValueChanged.AddListener(delegate(Vector2 vector2)
			{
				RectTransform component = this.m_announceListPointBGContent.GetComponent<RectTransform>();
				RectTransform component2 = this.m_announceListContent.GetComponent<RectTransform>();
				component.anchoredPosition = component2.anchoredPosition;
			});
			this.m_fastEnterGameToggle.isOn = LocalConfig.Instance.Data.IsFastEnterGame;
			Toggle testFirstBattleToggle = this.m_testFirstBattleToggle;
			bool flag = false;
			LoginUIController.IsTestFirstBattle = flag;
			testFirstBattleToggle.isOn = flag;
			GameObject gameObject = UnityEngine.Object.Instantiate(base.GetAssetInContainer("NetworkWaitingUI")) as GameObject;
			gameObject.transform.SetParent(base.gameObject.transform, false);
			gameObject.SetActive(false);
			this.m_networkWatingStateController = gameObject.GetComponent<CommonUIStateController>();
			UIUtility.MarginAdjustHorizontal(this.m_marginTransform);
		}

		// Token: 0x06011986 RID: 72070 RVA: 0x0048D3A4 File Offset: 0x0048B5A4
		private void OnAccountTextChanged(string text)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAccountTextChangedString_hotfix != null)
			{
				this.m_OnAccountTextChangedString_hotfix.call(new object[]
				{
					this,
					text
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventAccountTextChanged != null)
			{
				this.EventAccountTextChanged(text);
			}
		}

		// Token: 0x06011987 RID: 72071 RVA: 0x0048D42C File Offset: 0x0048B62C
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
			float unscaledDeltaTime = Time.unscaledDeltaTime;
			if (this.m_hideMessageTime > 0f)
			{
				this.m_hideMessageTime -= unscaledDeltaTime;
				if (this.m_hideMessageTime <= 0f)
				{
					this.HideMessage();
				}
			}
		}

		// Token: 0x06011988 RID: 72072 RVA: 0x0048D4C8 File Offset: 0x0048B6C8
		public void ShowWaitingNet(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowWaitingNetBoolean_hotfix != null)
			{
				this.m_ShowWaitingNetBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (show)
			{
				this.m_networkWatingStateController.gameObject.SetActive(true);
				this.m_networkWatingStateController.SetToUIState("Open", false, true);
			}
			else
			{
				this.m_networkWatingStateController.SetToUIState("Close", false, true);
				this.m_networkWatingStateController.gameObject.SetActive(false);
			}
		}

		// Token: 0x06011989 RID: 72073 RVA: 0x0048D58C File Offset: 0x0048B78C
		private void OnLoginPCClientButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLoginPCClientButtonClick_hotfix != null)
			{
				this.m_OnLoginPCClientButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventLoginPCClient != null)
			{
				this.EventLoginPCClient();
			}
		}

		// Token: 0x0601198A RID: 72074 RVA: 0x0048D604 File Offset: 0x0048B804
		private void OnOpenUserCenterButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnOpenUserCenterButtonClick_hotfix != null)
			{
				this.m_OnOpenUserCenterButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOpenUserCenter != null)
			{
				this.EventOpenUserCenter();
			}
		}

		// Token: 0x0601198B RID: 72075 RVA: 0x0048D67C File Offset: 0x0048B87C
		private void OnSelectServerButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSelectServerButtonClick_hotfix != null)
			{
				this.m_OnSelectServerButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventSelectServer != null)
			{
				this.EventSelectServer();
			}
		}

		// Token: 0x17003602 RID: 13826
		// (get) Token: 0x0601198C RID: 72076 RVA: 0x0048D6F4 File Offset: 0x0048B8F4
		// (set) Token: 0x0601198D RID: 72077 RVA: 0x0048D768 File Offset: 0x0048B968
		public bool IsLoginButtonClicked
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_IsLoginButtonClicked_hotfix != null)
				{
					return Convert.ToBoolean(this.m_get_IsLoginButtonClicked_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<IsLoginButtonClicked>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_IsLoginButtonClickedBoolean_hotfix != null)
				{
					this.m_set_IsLoginButtonClickedBoolean_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<IsLoginButtonClicked>k__BackingField = value;
			}
		}

		// Token: 0x0601198E RID: 72078 RVA: 0x0048D7E0 File Offset: 0x0048B9E0
		private void OnLoginButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLoginButtonClick_hotfix != null)
			{
				this.m_OnLoginButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.IsLoginButtonClicked = true;
			if (this.EventOnLogin != null)
			{
				this.EventOnLogin();
			}
			global::Debug.Log("LoginUIController.OnLoginButtonClick");
		}

		// Token: 0x0601198F RID: 72079 RVA: 0x0048D868 File Offset: 0x0048BA68
		private void OnSaveServerConfigClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSaveServerConfigClick_hotfix != null)
			{
				this.m_OnSaveServerConfigClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnSaveServerConfig != null)
			{
				this.EventOnSaveServerConfig();
			}
		}

		// Token: 0x06011990 RID: 72080 RVA: 0x0048D8E0 File Offset: 0x0048BAE0
		private void OnToggleFastEnterGame(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnToggleFastEnterGameBoolean_hotfix != null)
			{
				this.m_OnToggleFastEnterGameBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LocalConfig.Instance.Data.IsFastEnterGame = isOn;
		}

		// Token: 0x06011991 RID: 72081 RVA: 0x0048D960 File Offset: 0x0048BB60
		private void OnToggleTestFirstBattle(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnToggleTestFirstBattleBoolean_hotfix != null)
			{
				this.m_OnToggleTestFirstBattleBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LoginUIController.IsTestFirstBattle = isOn;
		}

		// Token: 0x06011992 RID: 72082 RVA: 0x0048D9D8 File Offset: 0x0048BBD8
		public void ShowStartAnimation()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowStartAnimation_hotfix != null)
			{
				this.m_ShowStartAnimation_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isStartAnimShowed)
			{
				return;
			}
			this.m_isStartAnimShowed = true;
			if (this.m_logoAnimController != null)
			{
				this.m_logoAnimController.SetToUIState("Show", false, true);
			}
			if (this.m_swordAnimController != null)
			{
				this.m_swordAnimController.SetToUIState("Show", false, true);
			}
		}

		// Token: 0x06011993 RID: 72083 RVA: 0x0048DA94 File Offset: 0x0048BC94
		public void SetAccountName(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetAccountNameString_hotfix != null)
			{
				this.m_SetAccountNameString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (string.IsNullOrEmpty(name))
			{
				this.m_accountInputField.text = string.Empty;
			}
			else
			{
				this.m_accountInputField.text = name;
			}
		}

		// Token: 0x06011994 RID: 72084 RVA: 0x0048DB30 File Offset: 0x0048BD30
		public void EnablePDSDKLoginMode(bool isEnable)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EnablePDSDKLoginModeBoolean_hotfix != null)
			{
				this.m_EnablePDSDKLoginModeBoolean_hotfix.call(new object[]
				{
					this,
					isEnable
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_accountGameObject.SetActive(!isEnable);
			this.m_passwordGameObject.SetActive(!isEnable);
			this.m_loginButton.gameObject.SetActive(!isEnable);
			this.m_sdkLoginButton.gameObject.SetActive(isEnable);
			this.m_switchUserButton.gameObject.SetActive(isEnable);
		}

		// Token: 0x06011995 RID: 72085 RVA: 0x0048DBF4 File Offset: 0x0048BDF4
		public string GetAccountName()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAccountName_hotfix != null)
			{
				return (string)this.m_GetAccountName_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LoginUIController.m_accountName = this.m_accountInputField.text;
			return this.m_accountInputField.text;
		}

		// Token: 0x06011996 RID: 72086 RVA: 0x0048DC7C File Offset: 0x0048BE7C
		public void SetPassword(string password)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPasswordString_hotfix != null)
			{
				this.m_SetPasswordString_hotfix.call(new object[]
				{
					this,
					password
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (string.IsNullOrEmpty(base.name))
			{
				this.m_passwordInputField.text = string.Empty;
			}
			else
			{
				this.m_passwordInputField.text = password;
			}
		}

		// Token: 0x06011997 RID: 72087 RVA: 0x0048DD20 File Offset: 0x0048BF20
		public string GetPassword()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPassword_hotfix != null)
			{
				return (string)this.m_GetPassword_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_passwordInputField.text;
		}

		// Token: 0x06011998 RID: 72088 RVA: 0x0048DD98 File Offset: 0x0048BF98
		public void ShowMessage(StringTableId id, int time = 0, bool isOverride = true)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowMessageStringTableIdInt32Boolean_hotfix != null)
			{
				this.m_ShowMessageStringTableIdInt32Boolean_hotfix.call(new object[]
				{
					this,
					id,
					time,
					isOverride
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.ShowMessage(configDataLoader.UtilityGetStringByStringTable(id), time, isOverride);
		}

		// Token: 0x06011999 RID: 72089 RVA: 0x0048DE48 File Offset: 0x0048C048
		public void ShowMessage(string text, int time = 0, bool isOverride = true)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowMessageStringInt32Boolean_hotfix != null)
			{
				this.m_ShowMessageStringInt32Boolean_hotfix.call(new object[]
				{
					this,
					text,
					time,
					isOverride
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!isOverride && this.m_hideMessageTime > 0f)
			{
				return;
			}
			this.m_messageGameObject.SetActive(true);
			this.m_messageText.text = text;
			this.m_hideMessageTime = (float)time;
			UIUtility.ReplayTween(this.m_messageGameObject, null);
		}

		// Token: 0x0601199A RID: 72090 RVA: 0x0048DF1C File Offset: 0x0048C11C
		public void SetClientVersion(string ver)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetClientVersionString_hotfix != null)
			{
				this.m_SetClientVersionString_hotfix.call(new object[]
				{
					this,
					ver
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.m_clientVersionText.text = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_ClientVersionFormatString), ver);
		}

		// Token: 0x0601199B RID: 72091 RVA: 0x0048DFB8 File Offset: 0x0048C1B8
		public void HideMessage()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideMessage_hotfix != null)
			{
				this.m_HideMessage_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_messageGameObject.SetActive(false);
			this.m_hideMessageTime = 0f;
		}

		// Token: 0x0601199C RID: 72092 RVA: 0x0048E030 File Offset: 0x0048C230
		public void ShowAnnouncePanel(bool isShow, Action onEnd = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowAnnouncePanelBooleanAction_hotfix != null)
			{
				this.m_ShowAnnouncePanelBooleanAction_hotfix.call(new object[]
				{
					this,
					isShow,
					onEnd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isShow)
			{
				UIUtility.SetUIStateOpen(this.m_announcePanelUIStateController, "Open", null, false, true);
			}
			else
			{
				UIUtility.SetUIStateClose(this.m_announcePanelUIStateController, "Close", onEnd, false, true);
			}
		}

		// Token: 0x0601199D RID: 72093 RVA: 0x0048E0E4 File Offset: 0x0048C2E4
		public void SetAnnounce(string announceText)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetAnnounceString_hotfix != null)
			{
				this.m_SetAnnounceString_hotfix.call(new object[]
				{
					this,
					announceText
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (string.IsNullOrEmpty(announceText))
			{
				global::Debug.LogError("announceText is null.");
				return;
			}
			string[] array = announceText.Split(new string[]
			{
				"/,\\"
			}, StringSplitOptions.RemoveEmptyEntries);
			if (array.Length % 3 != 0)
			{
				global::Debug.LogError("announce text segments number is not 3 integer multiple.");
				return;
			}
			List<LoginAnnouncement> list = new List<LoginAnnouncement>(array.Length / 3);
			for (int i = 0; i < array.Length; i += 3)
			{
				object obj = Enum.Parse(typeof(LoginAnnouncement.AnnounceType), array[i].Trim(), true);
				if (obj == null)
				{
					global::Debug.LogError(string.Format("Failed to parse {0} to AnnounceType.", array[i]));
				}
				else
				{
					LoginAnnouncement.AnnounceType type = (LoginAnnouncement.AnnounceType)obj;
					list.Add(new LoginAnnouncement(type, array[i + 1].Trim(), array[i + 2]));
				}
			}
			this.SetAnnounce(list);
		}

		// Token: 0x0601199E RID: 72094 RVA: 0x0048E218 File Offset: 0x0048C418
		private void SetAnnounce(List<LoginAnnouncement> announceList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetAnnounceList`1_hotfix != null)
			{
				this.m_SetAnnounceList`1_hotfix.call(new object[]
				{
					this,
					announceList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyChildren(this.m_announceListContent);
			List<GameObject> list = new List<GameObject>();
			if (announceList != null && announceList.Count > 0)
			{
				using (List<LoginAnnouncement>.Enumerator enumerator = announceList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						LoginAnnouncement item = enumerator.Current;
						LoginUIController $this = this;
						this.m_activityNameText.text = item.Title;
						LoginAnnouncement.AnnounceType currentType = item.CurrentType;
						if (currentType != LoginAnnouncement.AnnounceType.Notice)
						{
							if (currentType != LoginAnnouncement.AnnounceType.Activity)
							{
								if (currentType == LoginAnnouncement.AnnounceType.None)
								{
									this.m_tabLogo.gameObject.SetActive(false);
								}
							}
							else
							{
								this.m_tabLogo.sprite = AssetUtility.Instance.GetSprite("UI/Login_ABS/Label_Activity.png");
								this.m_tabLogo.gameObject.SetActive(true);
							}
						}
						else
						{
							this.m_tabLogo.sprite = AssetUtility.Instance.GetSprite("UI/Login_ABS/Label_Notice.png");
							this.m_tabLogo.gameObject.SetActive(true);
						}
						GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_toggleItemPrefab);
						gameObject.GetComponent<Toggle>().onValueChanged.AddListener(delegate(bool isOn)
						{
							if (isOn)
							{
								$this.m_detailScrollView.GetComponent<ScrollRect>().normalizedPosition = Vector2.one;
								$this.m_announceContentText.text = item.Content;
							}
						});
						gameObject.transform.SetParent(this.m_announceListContent.transform, false);
						gameObject.SetActive(true);
						list.Add(gameObject);
					}
				}
			}
			if (list != null && list.Count > 0)
			{
				list[0].GetComponent<Toggle>().isOn = true;
			}
			int num = 6;
			if (this.m_announceListPointBGContent.transform.childCount >= list.Count + num)
			{
				UIUtility.SetGameObjectChildrenActiveCount(this.m_announceListPointBGContent, list.Count + num);
			}
			else
			{
				int num2 = list.Count - this.m_announceListPointBGContent.transform.childCount + num;
				for (int i = 0; i < num2; i++)
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.m_announceListPointItem);
					gameObject2.transform.SetParent(this.m_announceListPointBGContent.transform, false);
					gameObject2.SetActive(true);
				}
			}
		}

		// Token: 0x17003603 RID: 13827
		// (set) Token: 0x0601199F RID: 72095 RVA: 0x0048E4D0 File Offset: 0x0048C6D0
		public bool EnableLoginPCClientButton
		{
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_EnableLoginPCClientButtonBoolean_hotfix != null)
				{
					this.m_set_EnableLoginPCClientButtonBoolean_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.m_loginPCClientButton.gameObject.SetActive(value);
			}
		}

		// Token: 0x060119A0 RID: 72096 RVA: 0x0048E554 File Offset: 0x0048C754
		private void OnOpenAnnouncePanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnOpenAnnouncePanel_hotfix != null)
			{
				this.m_OnOpenAnnouncePanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnOpenAnnouncePanel != null)
			{
				this.EventOnOpenAnnouncePanel();
			}
		}

		// Token: 0x060119A1 RID: 72097 RVA: 0x0048E5CC File Offset: 0x0048C7CC
		private void OnCloseAnnouncePanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCloseAnnouncePanel_hotfix != null)
			{
				this.m_OnCloseAnnouncePanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnCloseAnnouncePanel != null)
			{
				this.EventOnCloseAnnouncePanel();
			}
		}

		// Token: 0x060119A2 RID: 72098 RVA: 0x0048E644 File Offset: 0x0048C844
		private void OnShowServerButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnShowServerButtonClick_hotfix != null)
			{
				this.m_OnShowServerButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!LoginUITask.IsGMUser)
			{
				return;
			}
			this.m_showServerButtonClickCount--;
			if (this.m_showServerButtonClickCount > 0)
			{
				return;
			}
			this.m_showServerButton.gameObject.SetActive(false);
			this.m_serverGameObject.SetActive(true);
		}

		// Token: 0x140003C9 RID: 969
		// (add) Token: 0x060119A3 RID: 72099 RVA: 0x0048E6E8 File Offset: 0x0048C8E8
		// (remove) Token: 0x060119A4 RID: 72100 RVA: 0x0048E784 File Offset: 0x0048C984
		public event Action EventOnCloseAnnouncePanel
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCloseAnnouncePanelAction_hotfix != null)
				{
					this.m_add_EventOnCloseAnnouncePanelAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCloseAnnouncePanel;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCloseAnnouncePanel, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCloseAnnouncePanelAction_hotfix != null)
				{
					this.m_remove_EventOnCloseAnnouncePanelAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCloseAnnouncePanel;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCloseAnnouncePanel, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003CA RID: 970
		// (add) Token: 0x060119A5 RID: 72101 RVA: 0x0048E820 File Offset: 0x0048CA20
		// (remove) Token: 0x060119A6 RID: 72102 RVA: 0x0048E8BC File Offset: 0x0048CABC
		public event Action EventOnOpenAnnouncePanel
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnOpenAnnouncePanelAction_hotfix != null)
				{
					this.m_add_EventOnOpenAnnouncePanelAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnOpenAnnouncePanel;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnOpenAnnouncePanel, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnOpenAnnouncePanelAction_hotfix != null)
				{
					this.m_remove_EventOnOpenAnnouncePanelAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnOpenAnnouncePanel;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnOpenAnnouncePanel, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003CB RID: 971
		// (add) Token: 0x060119A7 RID: 72103 RVA: 0x0048E958 File Offset: 0x0048CB58
		// (remove) Token: 0x060119A8 RID: 72104 RVA: 0x0048E9F4 File Offset: 0x0048CBF4
		public event Action EventOnLogin
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnLoginAction_hotfix != null)
				{
					this.m_add_EventOnLoginAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnLogin;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnLogin, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnLoginAction_hotfix != null)
				{
					this.m_remove_EventOnLoginAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnLogin;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnLogin, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003CC RID: 972
		// (add) Token: 0x060119A9 RID: 72105 RVA: 0x0048EA90 File Offset: 0x0048CC90
		// (remove) Token: 0x060119AA RID: 72106 RVA: 0x0048EB2C File Offset: 0x0048CD2C
		public event Action EventOnSaveServerConfig
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSaveServerConfigAction_hotfix != null)
				{
					this.m_add_EventOnSaveServerConfigAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSaveServerConfig;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSaveServerConfig, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSaveServerConfigAction_hotfix != null)
				{
					this.m_remove_EventOnSaveServerConfigAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSaveServerConfig;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSaveServerConfig, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003CD RID: 973
		// (add) Token: 0x060119AB RID: 72107 RVA: 0x0048EBC8 File Offset: 0x0048CDC8
		// (remove) Token: 0x060119AC RID: 72108 RVA: 0x0048EC64 File Offset: 0x0048CE64
		public event Action EventSelectServer
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventSelectServerAction_hotfix != null)
				{
					this.m_add_EventSelectServerAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventSelectServer;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventSelectServer, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventSelectServerAction_hotfix != null)
				{
					this.m_remove_EventSelectServerAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventSelectServer;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventSelectServer, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003CE RID: 974
		// (add) Token: 0x060119AD RID: 72109 RVA: 0x0048ED00 File Offset: 0x0048CF00
		// (remove) Token: 0x060119AE RID: 72110 RVA: 0x0048ED9C File Offset: 0x0048CF9C
		public event Action EventOpenUserCenter
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOpenUserCenterAction_hotfix != null)
				{
					this.m_add_EventOpenUserCenterAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOpenUserCenter;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOpenUserCenter, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOpenUserCenterAction_hotfix != null)
				{
					this.m_remove_EventOpenUserCenterAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOpenUserCenter;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOpenUserCenter, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003CF RID: 975
		// (add) Token: 0x060119AF RID: 72111 RVA: 0x0048EE38 File Offset: 0x0048D038
		// (remove) Token: 0x060119B0 RID: 72112 RVA: 0x0048EED4 File Offset: 0x0048D0D4
		public event Action EventLoginPCClient
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventLoginPCClientAction_hotfix != null)
				{
					this.m_add_EventLoginPCClientAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventLoginPCClient;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventLoginPCClient, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventLoginPCClientAction_hotfix != null)
				{
					this.m_remove_EventLoginPCClientAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventLoginPCClient;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventLoginPCClient, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003D0 RID: 976
		// (add) Token: 0x060119B1 RID: 72113 RVA: 0x0048EF70 File Offset: 0x0048D170
		// (remove) Token: 0x060119B2 RID: 72114 RVA: 0x0048F00C File Offset: 0x0048D20C
		public event Action<string> EventAccountTextChanged
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventAccountTextChangedAction`1_hotfix != null)
				{
					this.m_add_EventAccountTextChangedAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventAccountTextChanged;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventAccountTextChanged, (Action<string>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventAccountTextChangedAction`1_hotfix != null)
				{
					this.m_remove_EventAccountTextChangedAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventAccountTextChanged;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventAccountTextChanged, (Action<string>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003604 RID: 13828
		// (get) Token: 0x060119B4 RID: 72116 RVA: 0x0048F0B0 File Offset: 0x0048D2B0
		// (set) Token: 0x060119B3 RID: 72115 RVA: 0x0048F0A8 File Offset: 0x0048D2A8
		public static bool IsTestFirstBattle { get; private set; }

		// Token: 0x17003605 RID: 13829
		// (get) Token: 0x060119B5 RID: 72117 RVA: 0x0048F0B8 File Offset: 0x0048D2B8
		// (set) Token: 0x060119B6 RID: 72118 RVA: 0x0048F0D8 File Offset: 0x0048D2D8
		[DoNotToLua]
		public new LoginUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new LoginUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060119B7 RID: 72119 RVA: 0x0048F0E4 File Offset: 0x0048D2E4
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060119B8 RID: 72120 RVA: 0x0048F0F0 File Offset: 0x0048D2F0
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060119B9 RID: 72121 RVA: 0x0048F0F8 File Offset: 0x0048D2F8
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060119BA RID: 72122 RVA: 0x0048F100 File Offset: 0x0048D300
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060119BB RID: 72123 RVA: 0x0048F114 File Offset: 0x0048D314
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060119BC RID: 72124 RVA: 0x0048F11C File Offset: 0x0048D31C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060119BD RID: 72125 RVA: 0x0048F128 File Offset: 0x0048D328
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060119BE RID: 72126 RVA: 0x0048F134 File Offset: 0x0048D334
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060119BF RID: 72127 RVA: 0x0048F140 File Offset: 0x0048D340
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060119C0 RID: 72128 RVA: 0x0048F14C File Offset: 0x0048D34C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x060119C1 RID: 72129 RVA: 0x0048F158 File Offset: 0x0048D358
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x060119C2 RID: 72130 RVA: 0x0048F164 File Offset: 0x0048D364
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x060119C3 RID: 72131 RVA: 0x0048F170 File Offset: 0x0048D370
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x060119C4 RID: 72132 RVA: 0x0048F17C File Offset: 0x0048D37C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x060119C5 RID: 72133 RVA: 0x0048F188 File Offset: 0x0048D388
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x060119C6 RID: 72134 RVA: 0x0048F190 File Offset: 0x0048D390
		private void __callDele_EventOnCloseAnnouncePanel()
		{
			Action eventOnCloseAnnouncePanel = this.EventOnCloseAnnouncePanel;
			if (eventOnCloseAnnouncePanel != null)
			{
				eventOnCloseAnnouncePanel();
			}
		}

		// Token: 0x060119C7 RID: 72135 RVA: 0x0048F1B0 File Offset: 0x0048D3B0
		private void __clearDele_EventOnCloseAnnouncePanel()
		{
			this.EventOnCloseAnnouncePanel = null;
		}

		// Token: 0x060119C8 RID: 72136 RVA: 0x0048F1BC File Offset: 0x0048D3BC
		private void __callDele_EventOnOpenAnnouncePanel()
		{
			Action eventOnOpenAnnouncePanel = this.EventOnOpenAnnouncePanel;
			if (eventOnOpenAnnouncePanel != null)
			{
				eventOnOpenAnnouncePanel();
			}
		}

		// Token: 0x060119C9 RID: 72137 RVA: 0x0048F1DC File Offset: 0x0048D3DC
		private void __clearDele_EventOnOpenAnnouncePanel()
		{
			this.EventOnOpenAnnouncePanel = null;
		}

		// Token: 0x060119CA RID: 72138 RVA: 0x0048F1E8 File Offset: 0x0048D3E8
		private void __callDele_EventOnLogin()
		{
			Action eventOnLogin = this.EventOnLogin;
			if (eventOnLogin != null)
			{
				eventOnLogin();
			}
		}

		// Token: 0x060119CB RID: 72139 RVA: 0x0048F208 File Offset: 0x0048D408
		private void __clearDele_EventOnLogin()
		{
			this.EventOnLogin = null;
		}

		// Token: 0x060119CC RID: 72140 RVA: 0x0048F214 File Offset: 0x0048D414
		private void __callDele_EventOnSaveServerConfig()
		{
			Action eventOnSaveServerConfig = this.EventOnSaveServerConfig;
			if (eventOnSaveServerConfig != null)
			{
				eventOnSaveServerConfig();
			}
		}

		// Token: 0x060119CD RID: 72141 RVA: 0x0048F234 File Offset: 0x0048D434
		private void __clearDele_EventOnSaveServerConfig()
		{
			this.EventOnSaveServerConfig = null;
		}

		// Token: 0x060119CE RID: 72142 RVA: 0x0048F240 File Offset: 0x0048D440
		private void __callDele_EventSelectServer()
		{
			Action eventSelectServer = this.EventSelectServer;
			if (eventSelectServer != null)
			{
				eventSelectServer();
			}
		}

		// Token: 0x060119CF RID: 72143 RVA: 0x0048F260 File Offset: 0x0048D460
		private void __clearDele_EventSelectServer()
		{
			this.EventSelectServer = null;
		}

		// Token: 0x060119D0 RID: 72144 RVA: 0x0048F26C File Offset: 0x0048D46C
		private void __callDele_EventOpenUserCenter()
		{
			Action eventOpenUserCenter = this.EventOpenUserCenter;
			if (eventOpenUserCenter != null)
			{
				eventOpenUserCenter();
			}
		}

		// Token: 0x060119D1 RID: 72145 RVA: 0x0048F28C File Offset: 0x0048D48C
		private void __clearDele_EventOpenUserCenter()
		{
			this.EventOpenUserCenter = null;
		}

		// Token: 0x060119D2 RID: 72146 RVA: 0x0048F298 File Offset: 0x0048D498
		private void __callDele_EventLoginPCClient()
		{
			Action eventLoginPCClient = this.EventLoginPCClient;
			if (eventLoginPCClient != null)
			{
				eventLoginPCClient();
			}
		}

		// Token: 0x060119D3 RID: 72147 RVA: 0x0048F2B8 File Offset: 0x0048D4B8
		private void __clearDele_EventLoginPCClient()
		{
			this.EventLoginPCClient = null;
		}

		// Token: 0x060119D4 RID: 72148 RVA: 0x0048F2C4 File Offset: 0x0048D4C4
		private void __callDele_EventAccountTextChanged(string obj)
		{
			Action<string> eventAccountTextChanged = this.EventAccountTextChanged;
			if (eventAccountTextChanged != null)
			{
				eventAccountTextChanged(obj);
			}
		}

		// Token: 0x060119D5 RID: 72149 RVA: 0x0048F2E8 File Offset: 0x0048D4E8
		private void __clearDele_EventAccountTextChanged(string obj)
		{
			this.EventAccountTextChanged = null;
		}

		// Token: 0x060119D7 RID: 72151 RVA: 0x0048F328 File Offset: 0x0048D528
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
					this.m_Start_hotfix = (luaObj.RawGet("Start") as LuaFunction);
					this.m_OnEnable_hotfix = (luaObj.RawGet("OnEnable") as LuaFunction);
					this.m_SetServerInfoServerInfo_hotfix = (luaObj.RawGet("SetServerInfo") as LuaFunction);
					this.m_OnBindFiledsCompleted_hotfix = (luaObj.RawGet("OnBindFiledsCompleted") as LuaFunction);
					this.m_OnAccountTextChangedString_hotfix = (luaObj.RawGet("OnAccountTextChanged") as LuaFunction);
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_ShowWaitingNetBoolean_hotfix = (luaObj.RawGet("ShowWaitingNet") as LuaFunction);
					this.m_OnLoginPCClientButtonClick_hotfix = (luaObj.RawGet("OnLoginPCClientButtonClick") as LuaFunction);
					this.m_OnOpenUserCenterButtonClick_hotfix = (luaObj.RawGet("OnOpenUserCenterButtonClick") as LuaFunction);
					this.m_OnSelectServerButtonClick_hotfix = (luaObj.RawGet("OnSelectServerButtonClick") as LuaFunction);
					this.m_get_IsLoginButtonClicked_hotfix = (luaObj.RawGet("get_IsLoginButtonClicked") as LuaFunction);
					this.m_set_IsLoginButtonClickedBoolean_hotfix = (luaObj.RawGet("set_IsLoginButtonClicked") as LuaFunction);
					this.m_OnLoginButtonClick_hotfix = (luaObj.RawGet("OnLoginButtonClick") as LuaFunction);
					this.m_OnSaveServerConfigClick_hotfix = (luaObj.RawGet("OnSaveServerConfigClick") as LuaFunction);
					this.m_OnToggleFastEnterGameBoolean_hotfix = (luaObj.RawGet("OnToggleFastEnterGame") as LuaFunction);
					this.m_OnToggleTestFirstBattleBoolean_hotfix = (luaObj.RawGet("OnToggleTestFirstBattle") as LuaFunction);
					this.m_ShowStartAnimation_hotfix = (luaObj.RawGet("ShowStartAnimation") as LuaFunction);
					this.m_SetAccountNameString_hotfix = (luaObj.RawGet("SetAccountName") as LuaFunction);
					this.m_EnablePDSDKLoginModeBoolean_hotfix = (luaObj.RawGet("EnablePDSDKLoginMode") as LuaFunction);
					this.m_GetAccountName_hotfix = (luaObj.RawGet("GetAccountName") as LuaFunction);
					this.m_SetPasswordString_hotfix = (luaObj.RawGet("SetPassword") as LuaFunction);
					this.m_GetPassword_hotfix = (luaObj.RawGet("GetPassword") as LuaFunction);
					this.m_ShowMessageStringTableIdInt32Boolean_hotfix = (luaObj.RawGet("ShowMessage") as LuaFunction);
					this.m_ShowMessageStringInt32Boolean_hotfix = (luaObj.RawGet("ShowMessage") as LuaFunction);
					this.m_SetClientVersionString_hotfix = (luaObj.RawGet("SetClientVersion") as LuaFunction);
					this.m_HideMessage_hotfix = (luaObj.RawGet("HideMessage") as LuaFunction);
					this.m_ShowAnnouncePanelBooleanAction_hotfix = (luaObj.RawGet("ShowAnnouncePanel") as LuaFunction);
					this.m_SetAnnounceString_hotfix = (luaObj.RawGet("SetAnnounce") as LuaFunction);
					this.m_SetAnnounceList`1_hotfix = (luaObj.RawGet("SetAnnounce") as LuaFunction);
					this.m_set_EnableLoginPCClientButtonBoolean_hotfix = (luaObj.RawGet("set_EnableLoginPCClientButton") as LuaFunction);
					this.m_OnOpenAnnouncePanel_hotfix = (luaObj.RawGet("OnOpenAnnouncePanel") as LuaFunction);
					this.m_OnCloseAnnouncePanel_hotfix = (luaObj.RawGet("OnCloseAnnouncePanel") as LuaFunction);
					this.m_OnShowServerButtonClick_hotfix = (luaObj.RawGet("OnShowServerButtonClick") as LuaFunction);
					this.m_add_EventOnCloseAnnouncePanelAction_hotfix = (luaObj.RawGet("add_EventOnCloseAnnouncePanel") as LuaFunction);
					this.m_remove_EventOnCloseAnnouncePanelAction_hotfix = (luaObj.RawGet("remove_EventOnCloseAnnouncePanel") as LuaFunction);
					this.m_add_EventOnOpenAnnouncePanelAction_hotfix = (luaObj.RawGet("add_EventOnOpenAnnouncePanel") as LuaFunction);
					this.m_remove_EventOnOpenAnnouncePanelAction_hotfix = (luaObj.RawGet("remove_EventOnOpenAnnouncePanel") as LuaFunction);
					this.m_add_EventOnLoginAction_hotfix = (luaObj.RawGet("add_EventOnLogin") as LuaFunction);
					this.m_remove_EventOnLoginAction_hotfix = (luaObj.RawGet("remove_EventOnLogin") as LuaFunction);
					this.m_add_EventOnSaveServerConfigAction_hotfix = (luaObj.RawGet("add_EventOnSaveServerConfig") as LuaFunction);
					this.m_remove_EventOnSaveServerConfigAction_hotfix = (luaObj.RawGet("remove_EventOnSaveServerConfig") as LuaFunction);
					this.m_add_EventSelectServerAction_hotfix = (luaObj.RawGet("add_EventSelectServer") as LuaFunction);
					this.m_remove_EventSelectServerAction_hotfix = (luaObj.RawGet("remove_EventSelectServer") as LuaFunction);
					this.m_add_EventOpenUserCenterAction_hotfix = (luaObj.RawGet("add_EventOpenUserCenter") as LuaFunction);
					this.m_remove_EventOpenUserCenterAction_hotfix = (luaObj.RawGet("remove_EventOpenUserCenter") as LuaFunction);
					this.m_add_EventLoginPCClientAction_hotfix = (luaObj.RawGet("add_EventLoginPCClient") as LuaFunction);
					this.m_remove_EventLoginPCClientAction_hotfix = (luaObj.RawGet("remove_EventLoginPCClient") as LuaFunction);
					this.m_add_EventAccountTextChangedAction`1_hotfix = (luaObj.RawGet("add_EventAccountTextChanged") as LuaFunction);
					this.m_remove_EventAccountTextChangedAction`1_hotfix = (luaObj.RawGet("remove_EventAccountTextChanged") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060119D8 RID: 72152 RVA: 0x0048F8A4 File Offset: 0x0048DAA4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(LoginUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A04C RID: 41036
		[AutoBind("./Margin", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_marginTransform;

		// Token: 0x0400A04D RID: 41037
		[AutoBind("./AnnouncePanel", AutoBindAttribute.InitState.Inactive, false)]
		private CommonUIStateController m_announcePanelUIStateController;

		// Token: 0x0400A04E RID: 41038
		[AutoBind("./AnnouncePanel/Detail/CloseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_closeAnnounceButton;

		// Token: 0x0400A04F RID: 41039
		[AutoBind("./AnnouncePanel/BlackBGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_announceBGButton;

		// Token: 0x0400A050 RID: 41040
		[AutoBind("./AnnouncePanel/Detail/LeftToggleScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_announceListScrollRect;

		// Token: 0x0400A051 RID: 41041
		[AutoBind("./AnnouncePanel/Detail/LeftToggleScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_announceListContent;

		// Token: 0x0400A052 RID: 41042
		[AutoBind("./AnnouncePanel/Detail/LeftToggleScrollView/Viewport/Point", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_announceListPointItem;

		// Token: 0x0400A053 RID: 41043
		[AutoBind("./AnnouncePanel/Detail/LeftToggleScrollView/Viewport/BGContent", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_announceListPointBGContent;

		// Token: 0x0400A054 RID: 41044
		[AutoBind("./AnnouncePanel/Prefab/ToggleItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_toggleItemPrefab;

		// Token: 0x0400A055 RID: 41045
		[AutoBind("./AnnouncePanel/Prefab/ToggleItem/ItemContent/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_activityNameText;

		// Token: 0x0400A056 RID: 41046
		[AutoBind("./AnnouncePanel/Prefab/ToggleItem/ItemContent/Logo", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_tabLogo;

		// Token: 0x0400A057 RID: 41047
		[AutoBind("./AnnouncePanel/Detail/InfoPanel/DetailScrollView/Viewport/Content/Text/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_announceContentText;

		// Token: 0x0400A058 RID: 41048
		[AutoBind("./AnnouncePanel/Detail/InfoPanel/DetailScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_detailScrollView;

		// Token: 0x0400A059 RID: 41049
		[AutoBind("./Margin/OpenAnnounceButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_openAnnounceButton;

		// Token: 0x0400A05A RID: 41050
		[AutoBind("./Server", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_serverGameObject;

		// Token: 0x0400A05B RID: 41051
		[AutoBind("./Server/ButtonPanel/FastEnterGame", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_fastEnterGameToggle;

		// Token: 0x0400A05C RID: 41052
		[AutoBind("./Server/ButtonPanel/TestFirstBattle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_testFirstBattleToggle;

		// Token: 0x0400A05D RID: 41053
		[AutoBind("./Server/ButtonPanel/SaveButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_saveServerConfigButton;

		// Token: 0x0400A05E RID: 41054
		[AutoBind("./ShowServerButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_showServerButton;

		// Token: 0x0400A05F RID: 41055
		[AutoBind("./Account/InputField", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_accountInputField;

		// Token: 0x0400A060 RID: 41056
		[AutoBind("./Password/InputField", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_passwordInputField;

		// Token: 0x0400A061 RID: 41057
		[AutoBind("./LoginButton", AutoBindAttribute.InitState.Inactive, false)]
		private Button m_loginButton;

		// Token: 0x0400A062 RID: 41058
		[AutoBind("./SDKLoginButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_sdkLoginButton;

		// Token: 0x0400A063 RID: 41059
		[AutoBind("./Message", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_messageGameObject;

		// Token: 0x0400A064 RID: 41060
		[AutoBind("./Account", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_accountGameObject;

		// Token: 0x0400A065 RID: 41061
		[AutoBind("./Password", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_passwordGameObject;

		// Token: 0x0400A066 RID: 41062
		[AutoBind("./SelectServers", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_selectServerButton;

		// Token: 0x0400A067 RID: 41063
		[AutoBind("./SelectServers/ServersNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_selectServerName;

		// Token: 0x0400A068 RID: 41064
		[AutoBind("./Message/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_messageText;

		// Token: 0x0400A069 RID: 41065
		[AutoBind("./Margin/ClientVersionText", AutoBindAttribute.InitState.Active, false)]
		private Text m_clientVersionText;

		// Token: 0x0400A06A RID: 41066
		[AutoBind("./Margin/SwitchUserButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_switchUserButton;

		// Token: 0x0400A06B RID: 41067
		[AutoBind("./Margin/LoginPCClient/Button", AutoBindAttribute.InitState.Inactive, false)]
		private Button m_loginPCClientButton;

		// Token: 0x0400A06C RID: 41068
		[AutoBind("./Login/LogoImage", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_logoAnimController;

		// Token: 0x0400A06D RID: 41069
		[AutoBind("./Login", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_swordAnimController;

		// Token: 0x0400A06E RID: 41070
		private float m_hideMessageTime;

		// Token: 0x0400A06F RID: 41071
		private int m_showServerButtonClickCount = 10;

		// Token: 0x0400A070 RID: 41072
		private CommonUIStateController m_networkWatingStateController;

		// Token: 0x0400A071 RID: 41073
		private bool m_isStartAnimShowed;

		// Token: 0x0400A072 RID: 41074
		public static string m_accountName;

		// Token: 0x0400A073 RID: 41075
		[DoNotToLua]
		private LoginUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A074 RID: 41076
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A075 RID: 41077
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A076 RID: 41078
		private LuaFunction m_Start_hotfix;

		// Token: 0x0400A077 RID: 41079
		private LuaFunction m_OnEnable_hotfix;

		// Token: 0x0400A078 RID: 41080
		private LuaFunction m_SetServerInfoServerInfo_hotfix;

		// Token: 0x0400A079 RID: 41081
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A07A RID: 41082
		private LuaFunction m_OnAccountTextChangedString_hotfix;

		// Token: 0x0400A07B RID: 41083
		private LuaFunction m_Update_hotfix;

		// Token: 0x0400A07C RID: 41084
		private LuaFunction m_ShowWaitingNetBoolean_hotfix;

		// Token: 0x0400A07D RID: 41085
		private LuaFunction m_OnLoginPCClientButtonClick_hotfix;

		// Token: 0x0400A07E RID: 41086
		private LuaFunction m_OnOpenUserCenterButtonClick_hotfix;

		// Token: 0x0400A07F RID: 41087
		private LuaFunction m_OnSelectServerButtonClick_hotfix;

		// Token: 0x0400A080 RID: 41088
		private LuaFunction m_get_IsLoginButtonClicked_hotfix;

		// Token: 0x0400A081 RID: 41089
		private LuaFunction m_set_IsLoginButtonClickedBoolean_hotfix;

		// Token: 0x0400A082 RID: 41090
		private LuaFunction m_OnLoginButtonClick_hotfix;

		// Token: 0x0400A083 RID: 41091
		private LuaFunction m_OnSaveServerConfigClick_hotfix;

		// Token: 0x0400A084 RID: 41092
		private LuaFunction m_OnToggleFastEnterGameBoolean_hotfix;

		// Token: 0x0400A085 RID: 41093
		private LuaFunction m_OnToggleTestFirstBattleBoolean_hotfix;

		// Token: 0x0400A086 RID: 41094
		private LuaFunction m_ShowStartAnimation_hotfix;

		// Token: 0x0400A087 RID: 41095
		private LuaFunction m_SetAccountNameString_hotfix;

		// Token: 0x0400A088 RID: 41096
		private LuaFunction m_EnablePDSDKLoginModeBoolean_hotfix;

		// Token: 0x0400A089 RID: 41097
		private LuaFunction m_GetAccountName_hotfix;

		// Token: 0x0400A08A RID: 41098
		private LuaFunction m_SetPasswordString_hotfix;

		// Token: 0x0400A08B RID: 41099
		private LuaFunction m_GetPassword_hotfix;

		// Token: 0x0400A08C RID: 41100
		private LuaFunction m_ShowMessageStringTableIdInt32Boolean_hotfix;

		// Token: 0x0400A08D RID: 41101
		private LuaFunction m_ShowMessageStringInt32Boolean_hotfix;

		// Token: 0x0400A08E RID: 41102
		private LuaFunction m_SetClientVersionString_hotfix;

		// Token: 0x0400A08F RID: 41103
		private LuaFunction m_HideMessage_hotfix;

		// Token: 0x0400A090 RID: 41104
		private LuaFunction m_ShowAnnouncePanelBooleanAction_hotfix;

		// Token: 0x0400A091 RID: 41105
		private LuaFunction m_SetAnnounceString_hotfix;

		// Token: 0x0400A092 RID: 41106
		private LuaFunction m_SetAnnounceList;

		// Token: 0x0400A093 RID: 41107
		private LuaFunction m_set_EnableLoginPCClientButtonBoolean_hotfix;

		// Token: 0x0400A094 RID: 41108
		private LuaFunction m_OnOpenAnnouncePanel_hotfix;

		// Token: 0x0400A095 RID: 41109
		private LuaFunction m_OnCloseAnnouncePanel_hotfix;

		// Token: 0x0400A096 RID: 41110
		private LuaFunction m_OnShowServerButtonClick_hotfix;

		// Token: 0x0400A097 RID: 41111
		private LuaFunction m_add_EventOnCloseAnnouncePanelAction_hotfix;

		// Token: 0x0400A098 RID: 41112
		private LuaFunction m_remove_EventOnCloseAnnouncePanelAction_hotfix;

		// Token: 0x0400A099 RID: 41113
		private LuaFunction m_add_EventOnOpenAnnouncePanelAction_hotfix;

		// Token: 0x0400A09A RID: 41114
		private LuaFunction m_remove_EventOnOpenAnnouncePanelAction_hotfix;

		// Token: 0x0400A09B RID: 41115
		private LuaFunction m_add_EventOnLoginAction_hotfix;

		// Token: 0x0400A09C RID: 41116
		private LuaFunction m_remove_EventOnLoginAction_hotfix;

		// Token: 0x0400A09D RID: 41117
		private LuaFunction m_add_EventOnSaveServerConfigAction_hotfix;

		// Token: 0x0400A09E RID: 41118
		private LuaFunction m_remove_EventOnSaveServerConfigAction_hotfix;

		// Token: 0x0400A09F RID: 41119
		private LuaFunction m_add_EventSelectServerAction_hotfix;

		// Token: 0x0400A0A0 RID: 41120
		private LuaFunction m_remove_EventSelectServerAction_hotfix;

		// Token: 0x0400A0A1 RID: 41121
		private LuaFunction m_add_EventOpenUserCenterAction_hotfix;

		// Token: 0x0400A0A2 RID: 41122
		private LuaFunction m_remove_EventOpenUserCenterAction_hotfix;

		// Token: 0x0400A0A3 RID: 41123
		private LuaFunction m_add_EventLoginPCClientAction_hotfix;

		// Token: 0x0400A0A4 RID: 41124
		private LuaFunction m_remove_EventLoginPCClientAction_hotfix;

		// Token: 0x0400A0A5 RID: 41125
		private LuaFunction m_add_EventAccountTextChangedAction;

		// Token: 0x0400A0A6 RID: 41126
		private LuaFunction m_remove_EventAccountTextChangedAction;

		// Token: 0x02000E38 RID: 3640
		public new class LuaExportHelper
		{
			// Token: 0x060119D9 RID: 72153 RVA: 0x0048F90C File Offset: 0x0048DB0C
			public LuaExportHelper(LoginUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060119DA RID: 72154 RVA: 0x0048F91C File Offset: 0x0048DB1C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x060119DB RID: 72155 RVA: 0x0048F92C File Offset: 0x0048DB2C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x060119DC RID: 72156 RVA: 0x0048F93C File Offset: 0x0048DB3C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x060119DD RID: 72157 RVA: 0x0048F94C File Offset: 0x0048DB4C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x060119DE RID: 72158 RVA: 0x0048F964 File Offset: 0x0048DB64
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x060119DF RID: 72159 RVA: 0x0048F974 File Offset: 0x0048DB74
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x060119E0 RID: 72160 RVA: 0x0048F984 File Offset: 0x0048DB84
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x060119E1 RID: 72161 RVA: 0x0048F994 File Offset: 0x0048DB94
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x060119E2 RID: 72162 RVA: 0x0048F9A4 File Offset: 0x0048DBA4
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x060119E3 RID: 72163 RVA: 0x0048F9B4 File Offset: 0x0048DBB4
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x060119E4 RID: 72164 RVA: 0x0048F9C4 File Offset: 0x0048DBC4
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x060119E5 RID: 72165 RVA: 0x0048F9D4 File Offset: 0x0048DBD4
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x060119E6 RID: 72166 RVA: 0x0048F9E4 File Offset: 0x0048DBE4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x060119E7 RID: 72167 RVA: 0x0048F9F4 File Offset: 0x0048DBF4
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x060119E8 RID: 72168 RVA: 0x0048FA04 File Offset: 0x0048DC04
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x060119E9 RID: 72169 RVA: 0x0048FA14 File Offset: 0x0048DC14
			public void __callDele_EventOnCloseAnnouncePanel()
			{
				this.m_owner.__callDele_EventOnCloseAnnouncePanel();
			}

			// Token: 0x060119EA RID: 72170 RVA: 0x0048FA24 File Offset: 0x0048DC24
			public void __clearDele_EventOnCloseAnnouncePanel()
			{
				this.m_owner.__clearDele_EventOnCloseAnnouncePanel();
			}

			// Token: 0x060119EB RID: 72171 RVA: 0x0048FA34 File Offset: 0x0048DC34
			public void __callDele_EventOnOpenAnnouncePanel()
			{
				this.m_owner.__callDele_EventOnOpenAnnouncePanel();
			}

			// Token: 0x060119EC RID: 72172 RVA: 0x0048FA44 File Offset: 0x0048DC44
			public void __clearDele_EventOnOpenAnnouncePanel()
			{
				this.m_owner.__clearDele_EventOnOpenAnnouncePanel();
			}

			// Token: 0x060119ED RID: 72173 RVA: 0x0048FA54 File Offset: 0x0048DC54
			public void __callDele_EventOnLogin()
			{
				this.m_owner.__callDele_EventOnLogin();
			}

			// Token: 0x060119EE RID: 72174 RVA: 0x0048FA64 File Offset: 0x0048DC64
			public void __clearDele_EventOnLogin()
			{
				this.m_owner.__clearDele_EventOnLogin();
			}

			// Token: 0x060119EF RID: 72175 RVA: 0x0048FA74 File Offset: 0x0048DC74
			public void __callDele_EventOnSaveServerConfig()
			{
				this.m_owner.__callDele_EventOnSaveServerConfig();
			}

			// Token: 0x060119F0 RID: 72176 RVA: 0x0048FA84 File Offset: 0x0048DC84
			public void __clearDele_EventOnSaveServerConfig()
			{
				this.m_owner.__clearDele_EventOnSaveServerConfig();
			}

			// Token: 0x060119F1 RID: 72177 RVA: 0x0048FA94 File Offset: 0x0048DC94
			public void __callDele_EventSelectServer()
			{
				this.m_owner.__callDele_EventSelectServer();
			}

			// Token: 0x060119F2 RID: 72178 RVA: 0x0048FAA4 File Offset: 0x0048DCA4
			public void __clearDele_EventSelectServer()
			{
				this.m_owner.__clearDele_EventSelectServer();
			}

			// Token: 0x060119F3 RID: 72179 RVA: 0x0048FAB4 File Offset: 0x0048DCB4
			public void __callDele_EventOpenUserCenter()
			{
				this.m_owner.__callDele_EventOpenUserCenter();
			}

			// Token: 0x060119F4 RID: 72180 RVA: 0x0048FAC4 File Offset: 0x0048DCC4
			public void __clearDele_EventOpenUserCenter()
			{
				this.m_owner.__clearDele_EventOpenUserCenter();
			}

			// Token: 0x060119F5 RID: 72181 RVA: 0x0048FAD4 File Offset: 0x0048DCD4
			public void __callDele_EventLoginPCClient()
			{
				this.m_owner.__callDele_EventLoginPCClient();
			}

			// Token: 0x060119F6 RID: 72182 RVA: 0x0048FAE4 File Offset: 0x0048DCE4
			public void __clearDele_EventLoginPCClient()
			{
				this.m_owner.__clearDele_EventLoginPCClient();
			}

			// Token: 0x060119F7 RID: 72183 RVA: 0x0048FAF4 File Offset: 0x0048DCF4
			public void __callDele_EventAccountTextChanged(string obj)
			{
				this.m_owner.__callDele_EventAccountTextChanged(obj);
			}

			// Token: 0x060119F8 RID: 72184 RVA: 0x0048FB04 File Offset: 0x0048DD04
			public void __clearDele_EventAccountTextChanged(string obj)
			{
				this.m_owner.__clearDele_EventAccountTextChanged(obj);
			}

			// Token: 0x17003606 RID: 13830
			// (get) Token: 0x060119F9 RID: 72185 RVA: 0x0048FB14 File Offset: 0x0048DD14
			// (set) Token: 0x060119FA RID: 72186 RVA: 0x0048FB24 File Offset: 0x0048DD24
			public RectTransform m_marginTransform
			{
				get
				{
					return this.m_owner.m_marginTransform;
				}
				set
				{
					this.m_owner.m_marginTransform = value;
				}
			}

			// Token: 0x17003607 RID: 13831
			// (get) Token: 0x060119FB RID: 72187 RVA: 0x0048FB34 File Offset: 0x0048DD34
			// (set) Token: 0x060119FC RID: 72188 RVA: 0x0048FB44 File Offset: 0x0048DD44
			public CommonUIStateController m_announcePanelUIStateController
			{
				get
				{
					return this.m_owner.m_announcePanelUIStateController;
				}
				set
				{
					this.m_owner.m_announcePanelUIStateController = value;
				}
			}

			// Token: 0x17003608 RID: 13832
			// (get) Token: 0x060119FD RID: 72189 RVA: 0x0048FB54 File Offset: 0x0048DD54
			// (set) Token: 0x060119FE RID: 72190 RVA: 0x0048FB64 File Offset: 0x0048DD64
			public Button m_closeAnnounceButton
			{
				get
				{
					return this.m_owner.m_closeAnnounceButton;
				}
				set
				{
					this.m_owner.m_closeAnnounceButton = value;
				}
			}

			// Token: 0x17003609 RID: 13833
			// (get) Token: 0x060119FF RID: 72191 RVA: 0x0048FB74 File Offset: 0x0048DD74
			// (set) Token: 0x06011A00 RID: 72192 RVA: 0x0048FB84 File Offset: 0x0048DD84
			public Button m_announceBGButton
			{
				get
				{
					return this.m_owner.m_announceBGButton;
				}
				set
				{
					this.m_owner.m_announceBGButton = value;
				}
			}

			// Token: 0x1700360A RID: 13834
			// (get) Token: 0x06011A01 RID: 72193 RVA: 0x0048FB94 File Offset: 0x0048DD94
			// (set) Token: 0x06011A02 RID: 72194 RVA: 0x0048FBA4 File Offset: 0x0048DDA4
			public ScrollRect m_announceListScrollRect
			{
				get
				{
					return this.m_owner.m_announceListScrollRect;
				}
				set
				{
					this.m_owner.m_announceListScrollRect = value;
				}
			}

			// Token: 0x1700360B RID: 13835
			// (get) Token: 0x06011A03 RID: 72195 RVA: 0x0048FBB4 File Offset: 0x0048DDB4
			// (set) Token: 0x06011A04 RID: 72196 RVA: 0x0048FBC4 File Offset: 0x0048DDC4
			public GameObject m_announceListContent
			{
				get
				{
					return this.m_owner.m_announceListContent;
				}
				set
				{
					this.m_owner.m_announceListContent = value;
				}
			}

			// Token: 0x1700360C RID: 13836
			// (get) Token: 0x06011A05 RID: 72197 RVA: 0x0048FBD4 File Offset: 0x0048DDD4
			// (set) Token: 0x06011A06 RID: 72198 RVA: 0x0048FBE4 File Offset: 0x0048DDE4
			public GameObject m_announceListPointItem
			{
				get
				{
					return this.m_owner.m_announceListPointItem;
				}
				set
				{
					this.m_owner.m_announceListPointItem = value;
				}
			}

			// Token: 0x1700360D RID: 13837
			// (get) Token: 0x06011A07 RID: 72199 RVA: 0x0048FBF4 File Offset: 0x0048DDF4
			// (set) Token: 0x06011A08 RID: 72200 RVA: 0x0048FC04 File Offset: 0x0048DE04
			public GameObject m_announceListPointBGContent
			{
				get
				{
					return this.m_owner.m_announceListPointBGContent;
				}
				set
				{
					this.m_owner.m_announceListPointBGContent = value;
				}
			}

			// Token: 0x1700360E RID: 13838
			// (get) Token: 0x06011A09 RID: 72201 RVA: 0x0048FC14 File Offset: 0x0048DE14
			// (set) Token: 0x06011A0A RID: 72202 RVA: 0x0048FC24 File Offset: 0x0048DE24
			public GameObject m_toggleItemPrefab
			{
				get
				{
					return this.m_owner.m_toggleItemPrefab;
				}
				set
				{
					this.m_owner.m_toggleItemPrefab = value;
				}
			}

			// Token: 0x1700360F RID: 13839
			// (get) Token: 0x06011A0B RID: 72203 RVA: 0x0048FC34 File Offset: 0x0048DE34
			// (set) Token: 0x06011A0C RID: 72204 RVA: 0x0048FC44 File Offset: 0x0048DE44
			public Text m_activityNameText
			{
				get
				{
					return this.m_owner.m_activityNameText;
				}
				set
				{
					this.m_owner.m_activityNameText = value;
				}
			}

			// Token: 0x17003610 RID: 13840
			// (get) Token: 0x06011A0D RID: 72205 RVA: 0x0048FC54 File Offset: 0x0048DE54
			// (set) Token: 0x06011A0E RID: 72206 RVA: 0x0048FC64 File Offset: 0x0048DE64
			public Image m_tabLogo
			{
				get
				{
					return this.m_owner.m_tabLogo;
				}
				set
				{
					this.m_owner.m_tabLogo = value;
				}
			}

			// Token: 0x17003611 RID: 13841
			// (get) Token: 0x06011A0F RID: 72207 RVA: 0x0048FC74 File Offset: 0x0048DE74
			// (set) Token: 0x06011A10 RID: 72208 RVA: 0x0048FC84 File Offset: 0x0048DE84
			public Text m_announceContentText
			{
				get
				{
					return this.m_owner.m_announceContentText;
				}
				set
				{
					this.m_owner.m_announceContentText = value;
				}
			}

			// Token: 0x17003612 RID: 13842
			// (get) Token: 0x06011A11 RID: 72209 RVA: 0x0048FC94 File Offset: 0x0048DE94
			// (set) Token: 0x06011A12 RID: 72210 RVA: 0x0048FCA4 File Offset: 0x0048DEA4
			public GameObject m_detailScrollView
			{
				get
				{
					return this.m_owner.m_detailScrollView;
				}
				set
				{
					this.m_owner.m_detailScrollView = value;
				}
			}

			// Token: 0x17003613 RID: 13843
			// (get) Token: 0x06011A13 RID: 72211 RVA: 0x0048FCB4 File Offset: 0x0048DEB4
			// (set) Token: 0x06011A14 RID: 72212 RVA: 0x0048FCC4 File Offset: 0x0048DEC4
			public Button m_openAnnounceButton
			{
				get
				{
					return this.m_owner.m_openAnnounceButton;
				}
				set
				{
					this.m_owner.m_openAnnounceButton = value;
				}
			}

			// Token: 0x17003614 RID: 13844
			// (get) Token: 0x06011A15 RID: 72213 RVA: 0x0048FCD4 File Offset: 0x0048DED4
			// (set) Token: 0x06011A16 RID: 72214 RVA: 0x0048FCE4 File Offset: 0x0048DEE4
			public GameObject m_serverGameObject
			{
				get
				{
					return this.m_owner.m_serverGameObject;
				}
				set
				{
					this.m_owner.m_serverGameObject = value;
				}
			}

			// Token: 0x17003615 RID: 13845
			// (get) Token: 0x06011A17 RID: 72215 RVA: 0x0048FCF4 File Offset: 0x0048DEF4
			// (set) Token: 0x06011A18 RID: 72216 RVA: 0x0048FD04 File Offset: 0x0048DF04
			public Toggle m_fastEnterGameToggle
			{
				get
				{
					return this.m_owner.m_fastEnterGameToggle;
				}
				set
				{
					this.m_owner.m_fastEnterGameToggle = value;
				}
			}

			// Token: 0x17003616 RID: 13846
			// (get) Token: 0x06011A19 RID: 72217 RVA: 0x0048FD14 File Offset: 0x0048DF14
			// (set) Token: 0x06011A1A RID: 72218 RVA: 0x0048FD24 File Offset: 0x0048DF24
			public Toggle m_testFirstBattleToggle
			{
				get
				{
					return this.m_owner.m_testFirstBattleToggle;
				}
				set
				{
					this.m_owner.m_testFirstBattleToggle = value;
				}
			}

			// Token: 0x17003617 RID: 13847
			// (get) Token: 0x06011A1B RID: 72219 RVA: 0x0048FD34 File Offset: 0x0048DF34
			// (set) Token: 0x06011A1C RID: 72220 RVA: 0x0048FD44 File Offset: 0x0048DF44
			public Button m_saveServerConfigButton
			{
				get
				{
					return this.m_owner.m_saveServerConfigButton;
				}
				set
				{
					this.m_owner.m_saveServerConfigButton = value;
				}
			}

			// Token: 0x17003618 RID: 13848
			// (get) Token: 0x06011A1D RID: 72221 RVA: 0x0048FD54 File Offset: 0x0048DF54
			// (set) Token: 0x06011A1E RID: 72222 RVA: 0x0048FD64 File Offset: 0x0048DF64
			public Button m_showServerButton
			{
				get
				{
					return this.m_owner.m_showServerButton;
				}
				set
				{
					this.m_owner.m_showServerButton = value;
				}
			}

			// Token: 0x17003619 RID: 13849
			// (get) Token: 0x06011A1F RID: 72223 RVA: 0x0048FD74 File Offset: 0x0048DF74
			// (set) Token: 0x06011A20 RID: 72224 RVA: 0x0048FD84 File Offset: 0x0048DF84
			public InputField m_accountInputField
			{
				get
				{
					return this.m_owner.m_accountInputField;
				}
				set
				{
					this.m_owner.m_accountInputField = value;
				}
			}

			// Token: 0x1700361A RID: 13850
			// (get) Token: 0x06011A21 RID: 72225 RVA: 0x0048FD94 File Offset: 0x0048DF94
			// (set) Token: 0x06011A22 RID: 72226 RVA: 0x0048FDA4 File Offset: 0x0048DFA4
			public InputField m_passwordInputField
			{
				get
				{
					return this.m_owner.m_passwordInputField;
				}
				set
				{
					this.m_owner.m_passwordInputField = value;
				}
			}

			// Token: 0x1700361B RID: 13851
			// (get) Token: 0x06011A23 RID: 72227 RVA: 0x0048FDB4 File Offset: 0x0048DFB4
			// (set) Token: 0x06011A24 RID: 72228 RVA: 0x0048FDC4 File Offset: 0x0048DFC4
			public Button m_loginButton
			{
				get
				{
					return this.m_owner.m_loginButton;
				}
				set
				{
					this.m_owner.m_loginButton = value;
				}
			}

			// Token: 0x1700361C RID: 13852
			// (get) Token: 0x06011A25 RID: 72229 RVA: 0x0048FDD4 File Offset: 0x0048DFD4
			// (set) Token: 0x06011A26 RID: 72230 RVA: 0x0048FDE4 File Offset: 0x0048DFE4
			public Button m_sdkLoginButton
			{
				get
				{
					return this.m_owner.m_sdkLoginButton;
				}
				set
				{
					this.m_owner.m_sdkLoginButton = value;
				}
			}

			// Token: 0x1700361D RID: 13853
			// (get) Token: 0x06011A27 RID: 72231 RVA: 0x0048FDF4 File Offset: 0x0048DFF4
			// (set) Token: 0x06011A28 RID: 72232 RVA: 0x0048FE04 File Offset: 0x0048E004
			public GameObject m_messageGameObject
			{
				get
				{
					return this.m_owner.m_messageGameObject;
				}
				set
				{
					this.m_owner.m_messageGameObject = value;
				}
			}

			// Token: 0x1700361E RID: 13854
			// (get) Token: 0x06011A29 RID: 72233 RVA: 0x0048FE14 File Offset: 0x0048E014
			// (set) Token: 0x06011A2A RID: 72234 RVA: 0x0048FE24 File Offset: 0x0048E024
			public GameObject m_accountGameObject
			{
				get
				{
					return this.m_owner.m_accountGameObject;
				}
				set
				{
					this.m_owner.m_accountGameObject = value;
				}
			}

			// Token: 0x1700361F RID: 13855
			// (get) Token: 0x06011A2B RID: 72235 RVA: 0x0048FE34 File Offset: 0x0048E034
			// (set) Token: 0x06011A2C RID: 72236 RVA: 0x0048FE44 File Offset: 0x0048E044
			public GameObject m_passwordGameObject
			{
				get
				{
					return this.m_owner.m_passwordGameObject;
				}
				set
				{
					this.m_owner.m_passwordGameObject = value;
				}
			}

			// Token: 0x17003620 RID: 13856
			// (get) Token: 0x06011A2D RID: 72237 RVA: 0x0048FE54 File Offset: 0x0048E054
			// (set) Token: 0x06011A2E RID: 72238 RVA: 0x0048FE64 File Offset: 0x0048E064
			public Button m_selectServerButton
			{
				get
				{
					return this.m_owner.m_selectServerButton;
				}
				set
				{
					this.m_owner.m_selectServerButton = value;
				}
			}

			// Token: 0x17003621 RID: 13857
			// (get) Token: 0x06011A2F RID: 72239 RVA: 0x0048FE74 File Offset: 0x0048E074
			// (set) Token: 0x06011A30 RID: 72240 RVA: 0x0048FE84 File Offset: 0x0048E084
			public Text m_selectServerName
			{
				get
				{
					return this.m_owner.m_selectServerName;
				}
				set
				{
					this.m_owner.m_selectServerName = value;
				}
			}

			// Token: 0x17003622 RID: 13858
			// (get) Token: 0x06011A31 RID: 72241 RVA: 0x0048FE94 File Offset: 0x0048E094
			// (set) Token: 0x06011A32 RID: 72242 RVA: 0x0048FEA4 File Offset: 0x0048E0A4
			public Text m_messageText
			{
				get
				{
					return this.m_owner.m_messageText;
				}
				set
				{
					this.m_owner.m_messageText = value;
				}
			}

			// Token: 0x17003623 RID: 13859
			// (get) Token: 0x06011A33 RID: 72243 RVA: 0x0048FEB4 File Offset: 0x0048E0B4
			// (set) Token: 0x06011A34 RID: 72244 RVA: 0x0048FEC4 File Offset: 0x0048E0C4
			public Text m_clientVersionText
			{
				get
				{
					return this.m_owner.m_clientVersionText;
				}
				set
				{
					this.m_owner.m_clientVersionText = value;
				}
			}

			// Token: 0x17003624 RID: 13860
			// (get) Token: 0x06011A35 RID: 72245 RVA: 0x0048FED4 File Offset: 0x0048E0D4
			// (set) Token: 0x06011A36 RID: 72246 RVA: 0x0048FEE4 File Offset: 0x0048E0E4
			public Button m_switchUserButton
			{
				get
				{
					return this.m_owner.m_switchUserButton;
				}
				set
				{
					this.m_owner.m_switchUserButton = value;
				}
			}

			// Token: 0x17003625 RID: 13861
			// (get) Token: 0x06011A37 RID: 72247 RVA: 0x0048FEF4 File Offset: 0x0048E0F4
			// (set) Token: 0x06011A38 RID: 72248 RVA: 0x0048FF04 File Offset: 0x0048E104
			public Button m_loginPCClientButton
			{
				get
				{
					return this.m_owner.m_loginPCClientButton;
				}
				set
				{
					this.m_owner.m_loginPCClientButton = value;
				}
			}

			// Token: 0x17003626 RID: 13862
			// (get) Token: 0x06011A39 RID: 72249 RVA: 0x0048FF14 File Offset: 0x0048E114
			// (set) Token: 0x06011A3A RID: 72250 RVA: 0x0048FF24 File Offset: 0x0048E124
			public CommonUIStateController m_logoAnimController
			{
				get
				{
					return this.m_owner.m_logoAnimController;
				}
				set
				{
					this.m_owner.m_logoAnimController = value;
				}
			}

			// Token: 0x17003627 RID: 13863
			// (get) Token: 0x06011A3B RID: 72251 RVA: 0x0048FF34 File Offset: 0x0048E134
			// (set) Token: 0x06011A3C RID: 72252 RVA: 0x0048FF44 File Offset: 0x0048E144
			public CommonUIStateController m_swordAnimController
			{
				get
				{
					return this.m_owner.m_swordAnimController;
				}
				set
				{
					this.m_owner.m_swordAnimController = value;
				}
			}

			// Token: 0x17003628 RID: 13864
			// (get) Token: 0x06011A3D RID: 72253 RVA: 0x0048FF54 File Offset: 0x0048E154
			// (set) Token: 0x06011A3E RID: 72254 RVA: 0x0048FF64 File Offset: 0x0048E164
			public float m_hideMessageTime
			{
				get
				{
					return this.m_owner.m_hideMessageTime;
				}
				set
				{
					this.m_owner.m_hideMessageTime = value;
				}
			}

			// Token: 0x17003629 RID: 13865
			// (get) Token: 0x06011A3F RID: 72255 RVA: 0x0048FF74 File Offset: 0x0048E174
			// (set) Token: 0x06011A40 RID: 72256 RVA: 0x0048FF84 File Offset: 0x0048E184
			public int m_showServerButtonClickCount
			{
				get
				{
					return this.m_owner.m_showServerButtonClickCount;
				}
				set
				{
					this.m_owner.m_showServerButtonClickCount = value;
				}
			}

			// Token: 0x1700362A RID: 13866
			// (get) Token: 0x06011A41 RID: 72257 RVA: 0x0048FF94 File Offset: 0x0048E194
			// (set) Token: 0x06011A42 RID: 72258 RVA: 0x0048FFA4 File Offset: 0x0048E1A4
			public CommonUIStateController m_networkWatingStateController
			{
				get
				{
					return this.m_owner.m_networkWatingStateController;
				}
				set
				{
					this.m_owner.m_networkWatingStateController = value;
				}
			}

			// Token: 0x1700362B RID: 13867
			// (get) Token: 0x06011A43 RID: 72259 RVA: 0x0048FFB4 File Offset: 0x0048E1B4
			// (set) Token: 0x06011A44 RID: 72260 RVA: 0x0048FFC4 File Offset: 0x0048E1C4
			public bool m_isStartAnimShowed
			{
				get
				{
					return this.m_owner.m_isStartAnimShowed;
				}
				set
				{
					this.m_owner.m_isStartAnimShowed = value;
				}
			}

			// Token: 0x1700362C RID: 13868
			// (set) Token: 0x06011A45 RID: 72261 RVA: 0x0048FFD4 File Offset: 0x0048E1D4
			public static bool IsTestFirstBattle
			{
				set
				{
					LoginUIController.IsTestFirstBattle = value;
				}
			}

			// Token: 0x06011A46 RID: 72262 RVA: 0x0048FFDC File Offset: 0x0048E1DC
			public void Start()
			{
				this.m_owner.Start();
			}

			// Token: 0x06011A47 RID: 72263 RVA: 0x0048FFEC File Offset: 0x0048E1EC
			public void OnEnable()
			{
				this.m_owner.OnEnable();
			}

			// Token: 0x06011A48 RID: 72264 RVA: 0x0048FFFC File Offset: 0x0048E1FC
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06011A49 RID: 72265 RVA: 0x0049000C File Offset: 0x0048E20C
			public void OnAccountTextChanged(string text)
			{
				this.m_owner.OnAccountTextChanged(text);
			}

			// Token: 0x06011A4A RID: 72266 RVA: 0x0049001C File Offset: 0x0048E21C
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x06011A4B RID: 72267 RVA: 0x0049002C File Offset: 0x0048E22C
			public void OnLoginPCClientButtonClick()
			{
				this.m_owner.OnLoginPCClientButtonClick();
			}

			// Token: 0x06011A4C RID: 72268 RVA: 0x0049003C File Offset: 0x0048E23C
			public void OnOpenUserCenterButtonClick()
			{
				this.m_owner.OnOpenUserCenterButtonClick();
			}

			// Token: 0x06011A4D RID: 72269 RVA: 0x0049004C File Offset: 0x0048E24C
			public void OnSelectServerButtonClick()
			{
				this.m_owner.OnSelectServerButtonClick();
			}

			// Token: 0x06011A4E RID: 72270 RVA: 0x0049005C File Offset: 0x0048E25C
			public void OnLoginButtonClick()
			{
				this.m_owner.OnLoginButtonClick();
			}

			// Token: 0x06011A4F RID: 72271 RVA: 0x0049006C File Offset: 0x0048E26C
			public void OnSaveServerConfigClick()
			{
				this.m_owner.OnSaveServerConfigClick();
			}

			// Token: 0x06011A50 RID: 72272 RVA: 0x0049007C File Offset: 0x0048E27C
			public void OnToggleFastEnterGame(bool isOn)
			{
				this.m_owner.OnToggleFastEnterGame(isOn);
			}

			// Token: 0x06011A51 RID: 72273 RVA: 0x0049008C File Offset: 0x0048E28C
			public void OnToggleTestFirstBattle(bool isOn)
			{
				this.m_owner.OnToggleTestFirstBattle(isOn);
			}

			// Token: 0x06011A52 RID: 72274 RVA: 0x0049009C File Offset: 0x0048E29C
			public void SetAnnounce(List<LoginAnnouncement> announceList)
			{
				this.m_owner.SetAnnounce(announceList);
			}

			// Token: 0x06011A53 RID: 72275 RVA: 0x004900AC File Offset: 0x0048E2AC
			public void OnOpenAnnouncePanel()
			{
				this.m_owner.OnOpenAnnouncePanel();
			}

			// Token: 0x06011A54 RID: 72276 RVA: 0x004900BC File Offset: 0x0048E2BC
			public void OnCloseAnnouncePanel()
			{
				this.m_owner.OnCloseAnnouncePanel();
			}

			// Token: 0x06011A55 RID: 72277 RVA: 0x004900CC File Offset: 0x0048E2CC
			public void OnShowServerButtonClick()
			{
				this.m_owner.OnShowServerButtonClick();
			}

			// Token: 0x0400A0A7 RID: 41127
			private LoginUIController m_owner;
		}
	}
}
