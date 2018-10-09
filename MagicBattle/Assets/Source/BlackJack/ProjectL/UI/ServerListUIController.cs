using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectLBasic;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E5A RID: 3674
	[HotFix]
	public class ServerListUIController : UIControllerBase
	{
		// Token: 0x06011CD4 RID: 72916 RVA: 0x0049AA0C File Offset: 0x00498C0C
		private ServerListUIController()
		{
		}

		// Token: 0x06011CD5 RID: 72917 RVA: 0x0049AA48 File Offset: 0x00498C48
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
			this.m_backgroundButton.onClick.AddListener(new UnityAction(this.OnCloseButtonClicked));
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
		}

		// Token: 0x06011CD6 RID: 72918 RVA: 0x0049AAE0 File Offset: 0x00498CE0
		public void SetServerList(List<LoginUITask.ServerInfo> serverList, List<LoginUITask.ServerInfo> recentLoginServerList, List<LoginUITask.ExistCharInfo> existCharsInfo, int selectServerID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetServerListList`1List`1List`1Int32_hotfix != null)
			{
				this.m_SetServerListList`1List`1List`1Int32_hotfix.call(new object[]
				{
					this,
					serverList,
					recentLoginServerList,
					existCharsInfo,
					selectServerID
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (existCharsInfo != null)
			{
				this.m_existCharsInfo = existCharsInfo;
			}
			this.m_existCharsInfo = existCharsInfo;
			this.m_existCharsInfo.Sort(delegate(LoginUITask.ExistCharInfo left, LoginUITask.ExistCharInfo right)
			{
				if (left.m_lastLoginHours != right.m_lastLoginHours)
				{
					return left.m_lastLoginHours - right.m_lastLoginHours;
				}
				if (right.m_playerLevel != left.m_playerLevel)
				{
					return right.m_playerLevel - left.m_playerLevel;
				}
				return left.m_charName.CompareTo(right.m_charName);
			});
			this.m_serverGroup.Clear();
			foreach (LoginUITask.ServerInfo serverInfo in serverList)
			{
				if (!this.m_serverGroup.ContainsKey(serverInfo.m_areaName))
				{
					this.m_serverGroup.Add(serverInfo.m_areaName, new List<LoginUITask.ServerInfo>());
				}
				this.m_serverGroup[serverInfo.m_areaName].Add(serverInfo);
			}
			this.m_selectServerID = selectServerID;
			this.m_servers = serverList;
			this.m_selectArea = null;
			this.RefreshServerArea();
			this.RefreshPlayerHead();
			if (this.m_areaGroup.transform.childCount > 0)
			{
				LoginUITask.ServerInfo serverInfo2 = this.m_servers.Find((LoginUITask.ServerInfo i) => i.m_id == this.m_selectServerID);
				this.ClearServerListItem(this.m_liServerListGroup);
				this.AddServerListItem(this.m_liServerListGroup, this.m_serverGroup[serverInfo2.m_areaName]);
			}
		}

		// Token: 0x06011CD7 RID: 72919 RVA: 0x0049ACC8 File Offset: 0x00498EC8
		private void ClearServerListItem(GameObject listGroup)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearServerListItemGameObject_hotfix != null)
			{
				this.m_ClearServerListItemGameObject_hotfix.call(new object[]
				{
					this,
					listGroup
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (listGroup == null)
			{
				return;
			}
			GameObjectUtility.DestroyChildren(listGroup);
		}

		// Token: 0x06011CD8 RID: 72920 RVA: 0x0049AD4C File Offset: 0x00498F4C
		private void RefreshServerArea()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RefreshServerArea_hotfix != null)
			{
				this.m_RefreshServerArea_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyChildrenImmediate(this.m_areaGroup);
			foreach (KeyValuePair<string, List<LoginUITask.ServerInfo>> keyValuePair in this.m_serverGroup)
			{
				GameObject areaItem = UnityEngine.Object.Instantiate<GameObject>(this.m_areaItemTemplate);
				areaItem.name = keyValuePair.Key;
				areaItem.transform.SetParent(this.m_areaGroup.transform, false);
				Text text = GameObjectUtility.FindComponentByName<Text>(areaItem.transform, "AreaText");
				text.text = keyValuePair.Key;
				GameObject gameObject = GameObjectUtility.FindGameObjectByName(areaItem.transform, "Select");
				gameObject.SetActive(false);
				Button component = areaItem.GetComponent<ButtonEx>();
				component.onClick.AddListener(delegate()
				{
					this.OnAreaClick(areaItem);
				});
			}
			if (this.m_areaGroup.transform.childCount > 0)
			{
				LoginUITask.ServerInfo serverInfo = this.m_servers.Find((LoginUITask.ServerInfo i) => i.m_id == this.m_selectServerID);
				Transform transform = GameObjectUtility.FindGameObjectByName(this.m_areaGroup.transform, serverInfo.m_areaName).transform;
				GameObject gameObject2 = GameObjectUtility.FindGameObjectByName(transform, "Select");
				gameObject2.SetActive(true);
				this.m_selectArea = transform.gameObject;
			}
		}

		// Token: 0x06011CD9 RID: 72921 RVA: 0x0049AF24 File Offset: 0x00499124
		private void RefreshPlayerHead()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RefreshPlayerHead_hotfix != null)
			{
				this.m_RefreshPlayerHead_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyChildrenImmediate(this.m_headGroup);
			global::Debug.Log(new object[]
			{
				this.m_existCharsInfo.Count
			});
			if (this.m_existCharsInfo.Count > 0)
			{
				this.m_noChar.SetActive(false);
			}
			else
			{
				this.m_noChar.SetActive(true);
			}
			using (List<LoginUITask.ExistCharInfo>.Enumerator enumerator = this.m_existCharsInfo.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ServerListUIController.<RefreshPlayerHead>c__AnonStorey1 <RefreshPlayerHead>c__AnonStorey = new ServerListUIController.<RefreshPlayerHead>c__AnonStorey1();
					<RefreshPlayerHead>c__AnonStorey.charInfo = enumerator.Current;
					<RefreshPlayerHead>c__AnonStorey.$this = this;
					global::Debug.Log(new object[]
					{
						<RefreshPlayerHead>c__AnonStorey.charInfo.m_channelId
					});
					global::Debug.Log(<RefreshPlayerHead>c__AnonStorey.charInfo.m_charName);
					global::Debug.Log(new object[]
					{
						<RefreshPlayerHead>c__AnonStorey.charInfo.m_headIcon
					});
					global::Debug.Log(new object[]
					{
						<RefreshPlayerHead>c__AnonStorey.charInfo.m_lastLoginHours
					});
					global::Debug.Log(new object[]
					{
						<RefreshPlayerHead>c__AnonStorey.charInfo.m_playerLevel
					});
					LoginUITask.ServerInfo server = this.m_servers.Find((LoginUITask.ServerInfo i) => i.m_bornChannelId == <RefreshPlayerHead>c__AnonStorey.charInfo.m_channelId && i.m_roleListURL == <RefreshPlayerHead>c__AnonStorey.charInfo.m_roleListURL);
					if (server == null)
					{
						global::Debug.LogError(string.Format("ServerListUIController.RefreshPlayerHead Server {0} dose not exist.", <RefreshPlayerHead>c__AnonStorey.charInfo.m_channelId));
					}
					else
					{
						GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_headItemTemplate);
						gameObject.transform.SetParent(this.m_headGroup.transform, false);
						Image image = GameObjectUtility.FindComponentByName<Image>(gameObject.transform, "HeadIcon");
						image.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerSmallHeadIconImageName(HeadIconTools.GetHeadPortrait(<RefreshPlayerHead>c__AnonStorey.charInfo.m_headIcon)));
						Text text = GameObjectUtility.FindComponentByName<Text>(gameObject.transform, "NameText");
						text.text = <RefreshPlayerHead>c__AnonStorey.charInfo.m_charName.ToString();
						Text text2 = GameObjectUtility.FindComponentByName<Text>(gameObject.transform, "LvText");
						text2.text = <RefreshPlayerHead>c__AnonStorey.charInfo.m_playerLevel.ToString();
						Text text3 = GameObjectUtility.FindComponentByName<Text>(gameObject.transform, "ServerText");
						text3.text = server.m_name;
						Text text4 = GameObjectUtility.FindComponentByName<Text>(gameObject.transform, "TimeText");
						text4.text = this.LastLoginTimeDescription(<RefreshPlayerHead>c__AnonStorey.charInfo.m_lastLoginHours);
						Button component = gameObject.GetComponent<Button>();
						component.onClick.AddListener(delegate()
						{
							LoginUITask findAInstance = LoginUITask.FindAInstance;
							if (findAInstance != null)
							{
								findAInstance.UpdateGMUserFlag(server);
							}
							bool isGMUser = LoginUITask.IsGMUser;
							if (findAInstance != null)
							{
								findAInstance.UpdateGMUserFlag(null);
							}
							if (!isGMUser && !string.IsNullOrEmpty(server.m_loginAgentUrl) && server.m_state == LoginUITask.ServerInfo.State.Maintain)
							{
								<RefreshPlayerHead>c__AnonStorey.$this.StartCoroutine(findAInstance.GetSDKPlatformUserID(server));
								IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
								<RefreshPlayerHead>c__AnonStorey.$this.StartCoroutine(DialogBox.Show(<RefreshPlayerHead>c__AnonStorey.$this.gameObject, "Assets/GameProject/RuntimeAssets/UI/Common_ABS/Prefab/DialogBox.prefab", (!string.IsNullOrEmpty(server.m_serverOpenDateTime)) ? string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_ServerWillOpenAtTime), server.m_name, server.m_serverOpenDateTime) : string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Login_CanNotSelectMaintainServer), server.m_name), configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_DialogBox_Ok), string.Empty, null));
								return;
							}
							<RefreshPlayerHead>c__AnonStorey.$this.m_selectServerID = server.m_id;
							<RefreshPlayerHead>c__AnonStorey.$this.Close();
						});
					}
				}
			}
		}

		// Token: 0x06011CDA RID: 72922 RVA: 0x0049B244 File Offset: 0x00499444
		private void AddServerListItem(GameObject listGroup, List<LoginUITask.ServerInfo> serverList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddServerListItemGameObjectList`1_hotfix != null)
			{
				this.m_AddServerListItemGameObjectList`1_hotfix.call(new object[]
				{
					this,
					listGroup,
					serverList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (listGroup == null || serverList == null || serverList.Count == 0)
			{
				return;
			}
			foreach (LoginUITask.ServerInfo server in serverList)
			{
				this.AddServerListItem(listGroup, server);
			}
		}

		// Token: 0x06011CDB RID: 72923 RVA: 0x0049B330 File Offset: 0x00499530
		private void AddServerListItem(GameObject listGroup, LoginUITask.ServerInfo server)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddServerListItemGameObjectServerInfo_hotfix != null)
			{
				this.m_AddServerListItemGameObjectServerInfo_hotfix.call(new object[]
				{
					this,
					listGroup,
					server2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LoginUITask.ServerInfo server = server2;
			ServerListUIController $this = this;
			if (listGroup == null || server == null)
			{
				return;
			}
			this.m_liServerNameText.text = server.m_name;
			this.m_liNewServerIcon.SetActive(server.m_isNew);
			this.m_liServerStateIcon.sprite = AssetUtility.Instance.GetSprite(UIAsset.ServerStateSpritePath[server.m_state - LoginUITask.ServerInfo.State.Hot]);
			LoginUITask.ExistCharInfo existCharInfo = null;
			if (!string.IsNullOrEmpty(server.m_roleListURL))
			{
				existCharInfo = this.m_existCharsInfo.Find((LoginUITask.ExistCharInfo i) => i.m_channelId == server.m_bornChannelId && i.m_roleListURL == server.m_roleListURL);
			}
			this.m_liServerCharIcon.SetActive(server.m_state != LoginUITask.ServerInfo.State.Maintain && existCharInfo != null);
			if (server.m_state != LoginUITask.ServerInfo.State.Maintain && existCharInfo != null)
			{
				this.m_liServerCharImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerSmallHeadIconImageName(HeadIconTools.GetHeadPortrait(existCharInfo.m_headIcon)));
				this.m_liServerCharLevel.text = existCharInfo.m_playerLevel.ToString();
			}
			this.m_liMaitainServerIcon.SetActive(server.m_state == LoginUITask.ServerInfo.State.Maintain);
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_serverListItemTemplate);
			Button component = gameObject.GetComponent<Button>();
			if (component != null)
			{
				component.onClick.RemoveAllListeners();
				component.onClick.AddListener(delegate()
				{
					LoginUITask findAInstance = LoginUITask.FindAInstance;
					if (findAInstance != null)
					{
						findAInstance.UpdateGMUserFlag(server);
					}
					bool isGMUser = LoginUITask.IsGMUser;
					if (findAInstance != null)
					{
						findAInstance.UpdateGMUserFlag(null);
					}
					if (!isGMUser && !string.IsNullOrEmpty(server.m_loginAgentUrl) && server.m_state == LoginUITask.ServerInfo.State.Maintain)
					{
						$this.StartCoroutine(findAInstance.GetSDKPlatformUserID(server));
						IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
						$this.StartCoroutine(DialogBox.Show($this.gameObject, "Assets/GameProject/RuntimeAssets/UI/Common_ABS/Prefab/DialogBox.prefab", (!string.IsNullOrEmpty(server.m_serverOpenDateTime)) ? string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_ServerWillOpenAtTime), server.m_name, server.m_serverOpenDateTime) : string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Login_CanNotSelectMaintainServer), server.m_name), configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_DialogBox_Ok), string.Empty, null));
						return;
					}
					$this.m_selectServerID = server.m_id;
					$this.Close();
				});
			}
			gameObject.transform.SetParent(listGroup.transform, false);
			gameObject.SetActive(true);
		}

		// Token: 0x06011CDC RID: 72924 RVA: 0x0049B550 File Offset: 0x00499750
		public void Open()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Open_hotfix != null)
			{
				this.m_Open_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_uiStateController, "Show", null, false, true);
		}

		// Token: 0x06011CDD RID: 72925 RVA: 0x0049B5C4 File Offset: 0x004997C4
		public void Close()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Close_hotfix != null)
			{
				this.m_Close_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_uiStateController, "Close", new Action(this.OnUIClosed), false, true);
		}

		// Token: 0x06011CDE RID: 72926 RVA: 0x0049B644 File Offset: 0x00499844
		private string LastLoginTimeDescription(int hour)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LastLoginTimeDescriptionInt32_hotfix != null)
			{
				return (string)this.m_LastLoginTimeDescriptionInt32_hotfix.call(new object[]
				{
					this,
					hour
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (hour < 24)
			{
				return this.m_configDataLoader.GetConfigDataStringTable(707).Value;
			}
			if (hour < 720)
			{
				string value = this.m_configDataLoader.GetConfigDataStringTable(708).Value;
				return string.Format(value, hour / 24);
			}
			return this.m_configDataLoader.GetConfigDataStringTable(709).Value;
		}

		// Token: 0x06011CDF RID: 72927 RVA: 0x0049B724 File Offset: 0x00499924
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
			if (!Input.GetMouseButton(0) || !Input.GetMouseButton(1) || !Input.GetKey(KeyCode.LeftShift))
			{
				this.m_fDebugReportTime = Time.realtimeSinceStartup;
			}
			if (Time.realtimeSinceStartup - this.m_fDebugReportTime > 10f)
			{
				base.StartCoroutine(TestUITask.ReportBug("UploadLogByTouches", 24.0));
				this.m_fDebugReportTime = Time.realtimeSinceStartup;
			}
		}

		// Token: 0x06011CE0 RID: 72928 RVA: 0x0049B7F4 File Offset: 0x004999F4
		private void OnCloseButtonClicked()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCloseButtonClicked_hotfix != null)
			{
				this.m_OnCloseButtonClicked_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.Close();
		}

		// Token: 0x06011CE1 RID: 72929 RVA: 0x0049B85C File Offset: 0x00499A5C
		private void OnAreaClick(GameObject areaItem)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAreaClickGameObject_hotfix != null)
			{
				this.m_OnAreaClickGameObject_hotfix.call(new object[]
				{
					this,
					areaItem
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject gameObject;
			if (this.m_selectArea != null)
			{
				gameObject = GameObjectUtility.FindGameObjectByName(this.m_selectArea.transform, "Select");
				gameObject.SetActive(false);
			}
			gameObject = GameObjectUtility.FindGameObjectByName(areaItem.transform, "Select");
			gameObject.SetActive(true);
			this.m_selectArea = areaItem;
			this.ClearServerListItem(this.m_liServerListGroup);
			this.AddServerListItem(this.m_liServerListGroup, this.m_serverGroup[areaItem.name]);
		}

		// Token: 0x06011CE2 RID: 72930 RVA: 0x0049B944 File Offset: 0x00499B44
		private void OnUIClosed()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnUIClosed_hotfix != null)
			{
				this.m_OnUIClosed_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnClosed != null)
			{
				this.EventOnClosed(this.m_selectServerID);
			}
		}

		// Token: 0x140003D1 RID: 977
		// (add) Token: 0x06011CE3 RID: 72931 RVA: 0x0049B9C0 File Offset: 0x00499BC0
		// (remove) Token: 0x06011CE4 RID: 72932 RVA: 0x0049BA5C File Offset: 0x00499C5C
		public event Action<int> EventOnClosed
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnClosedAction`1_hotfix != null)
				{
					this.m_add_EventOnClosedAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnClosed;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnClosed, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnClosedAction`1_hotfix != null)
				{
					this.m_remove_EventOnClosedAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnClosed;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnClosed, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003694 RID: 13972
		// (get) Token: 0x06011CE5 RID: 72933 RVA: 0x0049BAF8 File Offset: 0x00499CF8
		// (set) Token: 0x06011CE6 RID: 72934 RVA: 0x0049BB18 File Offset: 0x00499D18
		[DoNotToLua]
		public new ServerListUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ServerListUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06011CE7 RID: 72935 RVA: 0x0049BB24 File Offset: 0x00499D24
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06011CE8 RID: 72936 RVA: 0x0049BB30 File Offset: 0x00499D30
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06011CE9 RID: 72937 RVA: 0x0049BB38 File Offset: 0x00499D38
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06011CEA RID: 72938 RVA: 0x0049BB40 File Offset: 0x00499D40
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06011CEB RID: 72939 RVA: 0x0049BB54 File Offset: 0x00499D54
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06011CEC RID: 72940 RVA: 0x0049BB5C File Offset: 0x00499D5C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06011CED RID: 72941 RVA: 0x0049BB68 File Offset: 0x00499D68
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06011CEE RID: 72942 RVA: 0x0049BB74 File Offset: 0x00499D74
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06011CEF RID: 72943 RVA: 0x0049BB80 File Offset: 0x00499D80
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06011CF0 RID: 72944 RVA: 0x0049BB8C File Offset: 0x00499D8C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06011CF1 RID: 72945 RVA: 0x0049BB98 File Offset: 0x00499D98
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06011CF2 RID: 72946 RVA: 0x0049BBA4 File Offset: 0x00499DA4
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06011CF3 RID: 72947 RVA: 0x0049BBB0 File Offset: 0x00499DB0
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06011CF4 RID: 72948 RVA: 0x0049BBBC File Offset: 0x00499DBC
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06011CF5 RID: 72949 RVA: 0x0049BBC8 File Offset: 0x00499DC8
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06011CF6 RID: 72950 RVA: 0x0049BBD0 File Offset: 0x00499DD0
		private void __callDele_EventOnClosed(int obj)
		{
			Action<int> eventOnClosed = this.EventOnClosed;
			if (eventOnClosed != null)
			{
				eventOnClosed(obj);
			}
		}

		// Token: 0x06011CF7 RID: 72951 RVA: 0x0049BBF4 File Offset: 0x00499DF4
		private void __clearDele_EventOnClosed(int obj)
		{
			this.EventOnClosed = null;
		}

		// Token: 0x06011CFB RID: 72955 RVA: 0x0049BC7C File Offset: 0x00499E7C
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
					this.m_SetServerListList`1List`1List`1Int32_hotfix = (luaObj.RawGet("SetServerList") as LuaFunction);
					this.m_ClearServerListItemGameObject_hotfix = (luaObj.RawGet("ClearServerListItem") as LuaFunction);
					this.m_RefreshServerArea_hotfix = (luaObj.RawGet("RefreshServerArea") as LuaFunction);
					this.m_RefreshPlayerHead_hotfix = (luaObj.RawGet("RefreshPlayerHead") as LuaFunction);
					this.m_AddServerListItemGameObjectList`1_hotfix = (luaObj.RawGet("AddServerListItem") as LuaFunction);
					this.m_AddServerListItemGameObjectServerInfo_hotfix = (luaObj.RawGet("AddServerListItem") as LuaFunction);
					this.m_Open_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_Close_hotfix = (luaObj.RawGet("Close") as LuaFunction);
					this.m_LastLoginTimeDescriptionInt32_hotfix = (luaObj.RawGet("LastLoginTimeDescription") as LuaFunction);
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_OnCloseButtonClicked_hotfix = (luaObj.RawGet("OnCloseButtonClicked") as LuaFunction);
					this.m_OnAreaClickGameObject_hotfix = (luaObj.RawGet("OnAreaClick") as LuaFunction);
					this.m_OnUIClosed_hotfix = (luaObj.RawGet("OnUIClosed") as LuaFunction);
					this.m_add_EventOnClosedAction`1_hotfix = (luaObj.RawGet("add_EventOnClosed") as LuaFunction);
					this.m_remove_EventOnClosedAction`1_hotfix = (luaObj.RawGet("remove_EventOnClosed") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06011CFC RID: 72956 RVA: 0x0049BEC0 File Offset: 0x0049A0C0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ServerListUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A1EC RID: 41452
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400A1ED RID: 41453
		[AutoBind("./BlackBGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_backgroundButton;

		// Token: 0x0400A1EE RID: 41454
		[AutoBind("./Detail/ServerListPanel/ServerScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_liServerListGroup;

		// Token: 0x0400A1EF RID: 41455
		[AutoBind("./Detail/AreaListPanel/ServerScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_areaGroup;

		// Token: 0x0400A1F0 RID: 41456
		[AutoBind("./Detail/CharListPanel/ServerScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_headGroup;

		// Token: 0x0400A1F1 RID: 41457
		[AutoBind("./Detail/CharListPanel/NoChar", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_noChar;

		// Token: 0x0400A1F2 RID: 41458
		[AutoBind("./Prefabs/ServerItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_serverListItemTemplate;

		// Token: 0x0400A1F3 RID: 41459
		[AutoBind("./Prefabs/CharItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_headItemTemplate;

		// Token: 0x0400A1F4 RID: 41460
		[AutoBind("./Prefabs/AreaItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_areaItemTemplate;

		// Token: 0x0400A1F5 RID: 41461
		[AutoBind("./Prefabs/ServerItem/ServerNameGroup/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_liServerNameText;

		// Token: 0x0400A1F6 RID: 41462
		[AutoBind("./Prefabs/ServerItem/NewBGImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_liNewServerIcon;

		// Token: 0x0400A1F7 RID: 41463
		[AutoBind("./Prefabs/ServerItem/StateImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_liServerStateIcon;

		// Token: 0x0400A1F8 RID: 41464
		[AutoBind("./Prefabs/ServerItem/CharGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_liServerCharIcon;

		// Token: 0x0400A1F9 RID: 41465
		[AutoBind("./Prefabs/ServerItem/CharGroup/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_liServerCharImage;

		// Token: 0x0400A1FA RID: 41466
		[AutoBind("./Prefabs/ServerItem/CharGroup/LevelNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_liServerCharLevel;

		// Token: 0x0400A1FB RID: 41467
		[AutoBind("./Prefabs/ServerItem/Maintenance", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_liMaitainServerIcon;

		// Token: 0x0400A1FC RID: 41468
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x0400A1FD RID: 41469
		private Dictionary<string, List<LoginUITask.ServerInfo>> m_serverGroup = new Dictionary<string, List<LoginUITask.ServerInfo>>();

		// Token: 0x0400A1FE RID: 41470
		private List<LoginUITask.ServerInfo> m_servers;

		// Token: 0x0400A1FF RID: 41471
		private GameObject m_selectArea;

		// Token: 0x0400A201 RID: 41473
		private int m_selectServerID = -1;

		// Token: 0x0400A202 RID: 41474
		private List<LoginUITask.ExistCharInfo> m_existCharsInfo = new List<LoginUITask.ExistCharInfo>();

		// Token: 0x0400A203 RID: 41475
		private string m_roleListURL = string.Empty;

		// Token: 0x0400A204 RID: 41476
		private float m_fDebugReportTime = float.MaxValue;

		// Token: 0x0400A205 RID: 41477
		[DoNotToLua]
		private ServerListUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A207 RID: 41479
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A208 RID: 41480
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A209 RID: 41481
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A20A RID: 41482
		private LuaFunction m_SetServerListList`1List`1List;

		// Token: 0x0400A20B RID: 41483
		private LuaFunction m_ClearServerListItemGameObject_hotfix;

		// Token: 0x0400A20C RID: 41484
		private LuaFunction m_RefreshServerArea_hotfix;

		// Token: 0x0400A20D RID: 41485
		private LuaFunction m_RefreshPlayerHead_hotfix;

		// Token: 0x0400A20E RID: 41486
		private LuaFunction m_AddServerListItemGameObjectList;

		// Token: 0x0400A20F RID: 41487
		private LuaFunction m_AddServerListItemGameObjectServerInfo_hotfix;

		// Token: 0x0400A210 RID: 41488
		private LuaFunction m_Open_hotfix;

		// Token: 0x0400A211 RID: 41489
		private LuaFunction m_Close_hotfix;

		// Token: 0x0400A212 RID: 41490
		private LuaFunction m_LastLoginTimeDescriptionInt32_hotfix;

		// Token: 0x0400A213 RID: 41491
		private LuaFunction m_Update_hotfix;

		// Token: 0x0400A214 RID: 41492
		private LuaFunction m_OnCloseButtonClicked_hotfix;

		// Token: 0x0400A215 RID: 41493
		private LuaFunction m_OnAreaClickGameObject_hotfix;

		// Token: 0x0400A216 RID: 41494
		private LuaFunction m_OnUIClosed_hotfix;

		// Token: 0x0400A217 RID: 41495
		private LuaFunction m_add_EventOnClosedAction;

		// Token: 0x0400A218 RID: 41496
		private LuaFunction m_remove_EventOnClosedAction;

		// Token: 0x02000E5B RID: 3675
		public new class LuaExportHelper
		{
			// Token: 0x06011CFD RID: 72957 RVA: 0x0049BF28 File Offset: 0x0049A128
			public LuaExportHelper(ServerListUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06011CFE RID: 72958 RVA: 0x0049BF38 File Offset: 0x0049A138
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06011CFF RID: 72959 RVA: 0x0049BF48 File Offset: 0x0049A148
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06011D00 RID: 72960 RVA: 0x0049BF58 File Offset: 0x0049A158
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06011D01 RID: 72961 RVA: 0x0049BF68 File Offset: 0x0049A168
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06011D02 RID: 72962 RVA: 0x0049BF80 File Offset: 0x0049A180
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06011D03 RID: 72963 RVA: 0x0049BF90 File Offset: 0x0049A190
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06011D04 RID: 72964 RVA: 0x0049BFA0 File Offset: 0x0049A1A0
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06011D05 RID: 72965 RVA: 0x0049BFB0 File Offset: 0x0049A1B0
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06011D06 RID: 72966 RVA: 0x0049BFC0 File Offset: 0x0049A1C0
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06011D07 RID: 72967 RVA: 0x0049BFD0 File Offset: 0x0049A1D0
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06011D08 RID: 72968 RVA: 0x0049BFE0 File Offset: 0x0049A1E0
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06011D09 RID: 72969 RVA: 0x0049BFF0 File Offset: 0x0049A1F0
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06011D0A RID: 72970 RVA: 0x0049C000 File Offset: 0x0049A200
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06011D0B RID: 72971 RVA: 0x0049C010 File Offset: 0x0049A210
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06011D0C RID: 72972 RVA: 0x0049C020 File Offset: 0x0049A220
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06011D0D RID: 72973 RVA: 0x0049C030 File Offset: 0x0049A230
			public void __callDele_EventOnClosed(int obj)
			{
				this.m_owner.__callDele_EventOnClosed(obj);
			}

			// Token: 0x06011D0E RID: 72974 RVA: 0x0049C040 File Offset: 0x0049A240
			public void __clearDele_EventOnClosed(int obj)
			{
				this.m_owner.__clearDele_EventOnClosed(obj);
			}

			// Token: 0x17003695 RID: 13973
			// (get) Token: 0x06011D0F RID: 72975 RVA: 0x0049C050 File Offset: 0x0049A250
			// (set) Token: 0x06011D10 RID: 72976 RVA: 0x0049C060 File Offset: 0x0049A260
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

			// Token: 0x17003696 RID: 13974
			// (get) Token: 0x06011D11 RID: 72977 RVA: 0x0049C070 File Offset: 0x0049A270
			// (set) Token: 0x06011D12 RID: 72978 RVA: 0x0049C080 File Offset: 0x0049A280
			public Button m_backgroundButton
			{
				get
				{
					return this.m_owner.m_backgroundButton;
				}
				set
				{
					this.m_owner.m_backgroundButton = value;
				}
			}

			// Token: 0x17003697 RID: 13975
			// (get) Token: 0x06011D13 RID: 72979 RVA: 0x0049C090 File Offset: 0x0049A290
			// (set) Token: 0x06011D14 RID: 72980 RVA: 0x0049C0A0 File Offset: 0x0049A2A0
			public GameObject m_liServerListGroup
			{
				get
				{
					return this.m_owner.m_liServerListGroup;
				}
				set
				{
					this.m_owner.m_liServerListGroup = value;
				}
			}

			// Token: 0x17003698 RID: 13976
			// (get) Token: 0x06011D15 RID: 72981 RVA: 0x0049C0B0 File Offset: 0x0049A2B0
			// (set) Token: 0x06011D16 RID: 72982 RVA: 0x0049C0C0 File Offset: 0x0049A2C0
			public GameObject m_areaGroup
			{
				get
				{
					return this.m_owner.m_areaGroup;
				}
				set
				{
					this.m_owner.m_areaGroup = value;
				}
			}

			// Token: 0x17003699 RID: 13977
			// (get) Token: 0x06011D17 RID: 72983 RVA: 0x0049C0D0 File Offset: 0x0049A2D0
			// (set) Token: 0x06011D18 RID: 72984 RVA: 0x0049C0E0 File Offset: 0x0049A2E0
			public GameObject m_headGroup
			{
				get
				{
					return this.m_owner.m_headGroup;
				}
				set
				{
					this.m_owner.m_headGroup = value;
				}
			}

			// Token: 0x1700369A RID: 13978
			// (get) Token: 0x06011D19 RID: 72985 RVA: 0x0049C0F0 File Offset: 0x0049A2F0
			// (set) Token: 0x06011D1A RID: 72986 RVA: 0x0049C100 File Offset: 0x0049A300
			public GameObject m_noChar
			{
				get
				{
					return this.m_owner.m_noChar;
				}
				set
				{
					this.m_owner.m_noChar = value;
				}
			}

			// Token: 0x1700369B RID: 13979
			// (get) Token: 0x06011D1B RID: 72987 RVA: 0x0049C110 File Offset: 0x0049A310
			// (set) Token: 0x06011D1C RID: 72988 RVA: 0x0049C120 File Offset: 0x0049A320
			public GameObject m_serverListItemTemplate
			{
				get
				{
					return this.m_owner.m_serverListItemTemplate;
				}
				set
				{
					this.m_owner.m_serverListItemTemplate = value;
				}
			}

			// Token: 0x1700369C RID: 13980
			// (get) Token: 0x06011D1D RID: 72989 RVA: 0x0049C130 File Offset: 0x0049A330
			// (set) Token: 0x06011D1E RID: 72990 RVA: 0x0049C140 File Offset: 0x0049A340
			public GameObject m_headItemTemplate
			{
				get
				{
					return this.m_owner.m_headItemTemplate;
				}
				set
				{
					this.m_owner.m_headItemTemplate = value;
				}
			}

			// Token: 0x1700369D RID: 13981
			// (get) Token: 0x06011D1F RID: 72991 RVA: 0x0049C150 File Offset: 0x0049A350
			// (set) Token: 0x06011D20 RID: 72992 RVA: 0x0049C160 File Offset: 0x0049A360
			public GameObject m_areaItemTemplate
			{
				get
				{
					return this.m_owner.m_areaItemTemplate;
				}
				set
				{
					this.m_owner.m_areaItemTemplate = value;
				}
			}

			// Token: 0x1700369E RID: 13982
			// (get) Token: 0x06011D21 RID: 72993 RVA: 0x0049C170 File Offset: 0x0049A370
			// (set) Token: 0x06011D22 RID: 72994 RVA: 0x0049C180 File Offset: 0x0049A380
			public Text m_liServerNameText
			{
				get
				{
					return this.m_owner.m_liServerNameText;
				}
				set
				{
					this.m_owner.m_liServerNameText = value;
				}
			}

			// Token: 0x1700369F RID: 13983
			// (get) Token: 0x06011D23 RID: 72995 RVA: 0x0049C190 File Offset: 0x0049A390
			// (set) Token: 0x06011D24 RID: 72996 RVA: 0x0049C1A0 File Offset: 0x0049A3A0
			public GameObject m_liNewServerIcon
			{
				get
				{
					return this.m_owner.m_liNewServerIcon;
				}
				set
				{
					this.m_owner.m_liNewServerIcon = value;
				}
			}

			// Token: 0x170036A0 RID: 13984
			// (get) Token: 0x06011D25 RID: 72997 RVA: 0x0049C1B0 File Offset: 0x0049A3B0
			// (set) Token: 0x06011D26 RID: 72998 RVA: 0x0049C1C0 File Offset: 0x0049A3C0
			public Image m_liServerStateIcon
			{
				get
				{
					return this.m_owner.m_liServerStateIcon;
				}
				set
				{
					this.m_owner.m_liServerStateIcon = value;
				}
			}

			// Token: 0x170036A1 RID: 13985
			// (get) Token: 0x06011D27 RID: 72999 RVA: 0x0049C1D0 File Offset: 0x0049A3D0
			// (set) Token: 0x06011D28 RID: 73000 RVA: 0x0049C1E0 File Offset: 0x0049A3E0
			public GameObject m_liServerCharIcon
			{
				get
				{
					return this.m_owner.m_liServerCharIcon;
				}
				set
				{
					this.m_owner.m_liServerCharIcon = value;
				}
			}

			// Token: 0x170036A2 RID: 13986
			// (get) Token: 0x06011D29 RID: 73001 RVA: 0x0049C1F0 File Offset: 0x0049A3F0
			// (set) Token: 0x06011D2A RID: 73002 RVA: 0x0049C200 File Offset: 0x0049A400
			public Image m_liServerCharImage
			{
				get
				{
					return this.m_owner.m_liServerCharImage;
				}
				set
				{
					this.m_owner.m_liServerCharImage = value;
				}
			}

			// Token: 0x170036A3 RID: 13987
			// (get) Token: 0x06011D2B RID: 73003 RVA: 0x0049C210 File Offset: 0x0049A410
			// (set) Token: 0x06011D2C RID: 73004 RVA: 0x0049C220 File Offset: 0x0049A420
			public Text m_liServerCharLevel
			{
				get
				{
					return this.m_owner.m_liServerCharLevel;
				}
				set
				{
					this.m_owner.m_liServerCharLevel = value;
				}
			}

			// Token: 0x170036A4 RID: 13988
			// (get) Token: 0x06011D2D RID: 73005 RVA: 0x0049C230 File Offset: 0x0049A430
			// (set) Token: 0x06011D2E RID: 73006 RVA: 0x0049C240 File Offset: 0x0049A440
			public GameObject m_liMaitainServerIcon
			{
				get
				{
					return this.m_owner.m_liMaitainServerIcon;
				}
				set
				{
					this.m_owner.m_liMaitainServerIcon = value;
				}
			}

			// Token: 0x170036A5 RID: 13989
			// (get) Token: 0x06011D2F RID: 73007 RVA: 0x0049C250 File Offset: 0x0049A450
			// (set) Token: 0x06011D30 RID: 73008 RVA: 0x0049C260 File Offset: 0x0049A460
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

			// Token: 0x170036A6 RID: 13990
			// (get) Token: 0x06011D31 RID: 73009 RVA: 0x0049C270 File Offset: 0x0049A470
			// (set) Token: 0x06011D32 RID: 73010 RVA: 0x0049C280 File Offset: 0x0049A480
			public Dictionary<string, List<LoginUITask.ServerInfo>> m_serverGroup
			{
				get
				{
					return this.m_owner.m_serverGroup;
				}
				set
				{
					this.m_owner.m_serverGroup = value;
				}
			}

			// Token: 0x170036A7 RID: 13991
			// (get) Token: 0x06011D33 RID: 73011 RVA: 0x0049C290 File Offset: 0x0049A490
			// (set) Token: 0x06011D34 RID: 73012 RVA: 0x0049C2A0 File Offset: 0x0049A4A0
			public List<LoginUITask.ServerInfo> m_servers
			{
				get
				{
					return this.m_owner.m_servers;
				}
				set
				{
					this.m_owner.m_servers = value;
				}
			}

			// Token: 0x170036A8 RID: 13992
			// (get) Token: 0x06011D35 RID: 73013 RVA: 0x0049C2B0 File Offset: 0x0049A4B0
			// (set) Token: 0x06011D36 RID: 73014 RVA: 0x0049C2C0 File Offset: 0x0049A4C0
			public GameObject m_selectArea
			{
				get
				{
					return this.m_owner.m_selectArea;
				}
				set
				{
					this.m_owner.m_selectArea = value;
				}
			}

			// Token: 0x170036A9 RID: 13993
			// (get) Token: 0x06011D37 RID: 73015 RVA: 0x0049C2D0 File Offset: 0x0049A4D0
			// (set) Token: 0x06011D38 RID: 73016 RVA: 0x0049C2E0 File Offset: 0x0049A4E0
			public int m_selectServerID
			{
				get
				{
					return this.m_owner.m_selectServerID;
				}
				set
				{
					this.m_owner.m_selectServerID = value;
				}
			}

			// Token: 0x170036AA RID: 13994
			// (get) Token: 0x06011D39 RID: 73017 RVA: 0x0049C2F0 File Offset: 0x0049A4F0
			// (set) Token: 0x06011D3A RID: 73018 RVA: 0x0049C300 File Offset: 0x0049A500
			public List<LoginUITask.ExistCharInfo> m_existCharsInfo
			{
				get
				{
					return this.m_owner.m_existCharsInfo;
				}
				set
				{
					this.m_owner.m_existCharsInfo = value;
				}
			}

			// Token: 0x170036AB RID: 13995
			// (get) Token: 0x06011D3B RID: 73019 RVA: 0x0049C310 File Offset: 0x0049A510
			// (set) Token: 0x06011D3C RID: 73020 RVA: 0x0049C320 File Offset: 0x0049A520
			public string m_roleListURL
			{
				get
				{
					return this.m_owner.m_roleListURL;
				}
				set
				{
					this.m_owner.m_roleListURL = value;
				}
			}

			// Token: 0x170036AC RID: 13996
			// (get) Token: 0x06011D3D RID: 73021 RVA: 0x0049C330 File Offset: 0x0049A530
			// (set) Token: 0x06011D3E RID: 73022 RVA: 0x0049C340 File Offset: 0x0049A540
			public float m_fDebugReportTime
			{
				get
				{
					return this.m_owner.m_fDebugReportTime;
				}
				set
				{
					this.m_owner.m_fDebugReportTime = value;
				}
			}

			// Token: 0x06011D3F RID: 73023 RVA: 0x0049C350 File Offset: 0x0049A550
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06011D40 RID: 73024 RVA: 0x0049C360 File Offset: 0x0049A560
			public void ClearServerListItem(GameObject listGroup)
			{
				this.m_owner.ClearServerListItem(listGroup);
			}

			// Token: 0x06011D41 RID: 73025 RVA: 0x0049C370 File Offset: 0x0049A570
			public void RefreshServerArea()
			{
				this.m_owner.RefreshServerArea();
			}

			// Token: 0x06011D42 RID: 73026 RVA: 0x0049C380 File Offset: 0x0049A580
			public void RefreshPlayerHead()
			{
				this.m_owner.RefreshPlayerHead();
			}

			// Token: 0x06011D43 RID: 73027 RVA: 0x0049C390 File Offset: 0x0049A590
			public void AddServerListItem(GameObject listGroup, List<LoginUITask.ServerInfo> serverList)
			{
				this.m_owner.AddServerListItem(listGroup, serverList);
			}

			// Token: 0x06011D44 RID: 73028 RVA: 0x0049C3A0 File Offset: 0x0049A5A0
			public void AddServerListItem(GameObject listGroup, LoginUITask.ServerInfo server)
			{
				this.m_owner.AddServerListItem(listGroup, server);
			}

			// Token: 0x06011D45 RID: 73029 RVA: 0x0049C3B0 File Offset: 0x0049A5B0
			public string LastLoginTimeDescription(int hour)
			{
				return this.m_owner.LastLoginTimeDescription(hour);
			}

			// Token: 0x06011D46 RID: 73030 RVA: 0x0049C3C0 File Offset: 0x0049A5C0
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x06011D47 RID: 73031 RVA: 0x0049C3D0 File Offset: 0x0049A5D0
			public void OnCloseButtonClicked()
			{
				this.m_owner.OnCloseButtonClicked();
			}

			// Token: 0x06011D48 RID: 73032 RVA: 0x0049C3E0 File Offset: 0x0049A5E0
			public void OnAreaClick(GameObject areaItem)
			{
				this.m_owner.OnAreaClick(areaItem);
			}

			// Token: 0x06011D49 RID: 73033 RVA: 0x0049C3F0 File Offset: 0x0049A5F0
			public void OnUIClosed()
			{
				this.m_owner.OnUIClosed();
			}

			// Token: 0x0400A219 RID: 41497
			private ServerListUIController m_owner;
		}
	}
}
