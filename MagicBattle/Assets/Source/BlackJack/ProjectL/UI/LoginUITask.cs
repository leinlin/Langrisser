using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.PlayerContext;
using BlackJack.BJFramework.Runtime.Resource;
using BlackJack.BJFramework.Runtime.Scene;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.LibClient;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectLBasic;
using PD.SDK;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E3D RID: 3645
	[HotFix]
	public class LoginUITask : LoginUITaskBase
	{
		// Token: 0x06011A64 RID: 72292 RVA: 0x0049069C File Offset: 0x0048E89C
		public LoginUITask(string name) : base(name)
		{
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as ClientConfigDataLoader);
			LoginUITask.InitializeGlobals();
			SystemUtility.SetTimeScale(1f);
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

		// Token: 0x06011A65 RID: 72293 RVA: 0x00490940 File Offset: 0x0048EB40
		public void ShowDialogBox(StringTableId strID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowDialogBoxStringTableId_hotfix != null)
			{
				this.m_ShowDialogBoxStringTableId_hotfix.call(new object[]
				{
					this,
					strID
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_loginUIController == null)
			{
				return;
			}
			ClientConfigDataLoader clientConfigDataLoader = GameManager.Instance.ConfigDataLoader as ClientConfigDataLoader;
			if (clientConfigDataLoader == null)
			{
				return;
			}
			this.m_loginUIController.StartCoroutine(DialogBox.Show(this.m_loginUIController.gameObject, "Assets/GameProject/RuntimeAssets/UI/Common_ABS/Prefab/DialogBox.prefab", clientConfigDataLoader.UtilityGetStringByStringTable(strID), clientConfigDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_DialogBox_Ok), string.Empty, null));
		}

		// Token: 0x06011A66 RID: 72294 RVA: 0x00490A14 File Offset: 0x0048EC14
		public static void Relogin()
		{
			LoginUITask.m_isAutoRelogin = true;
			GameManager.Instance.Return2Login(true);
		}

		// Token: 0x06011A67 RID: 72295 RVA: 0x00490A28 File Offset: 0x0048EC28
		public static void ReturnToLoginAndSwitchUser()
		{
			LoginUITask.m_isReturnToLoginAndSwitchUser = true;
			GameManager.Instance.Return2Login(true);
		}

		// Token: 0x06011A68 RID: 72296 RVA: 0x00490A3C File Offset: 0x0048EC3C
		private static void InitializeGlobals()
		{
			if (LoginUITask.s_isGlobalInitialized)
			{
				return;
			}
			LoginUITask.LogSystemInfo();
			Screen.sleepTimeout = -1;
			SystemUtility.SetTimeScale(1f);
			Time.maximumDeltaTime = 0.1f;
			UIUtility.SetDefaultPixelDragThreshold((int)Math.Round((double)(Screen.dpi * 0.05f)));
			EventSystem.current.pixelDragThreshold = UIUtility.GetDefaultPixelDragThreshold();
			ClientConfigDataLoader clientConfigDataLoader = GameManager.Instance.ConfigDataLoader as ClientConfigDataLoader;
			int num = clientConfigDataLoader.UtilityInitialize();
			if (num < 0)
			{
				string str = string.Format("Failed to initialize config, error: {0}, {1}", num, clientConfigDataLoader.UtilityGetErrorCodeString(num));
				global::Debug.LogError("配置加载错误：" + str);
				LoginUITask.m_loadConfigFailedMessage = "配置加载错误：" + str;
			}
			LoginUITask.InitLocalConfig();
			if (LoginUITask.<>f__mg$cache0 == null)
			{
				LoginUITask.<>f__mg$cache0 = new Action<Action>(LoginUITask.NetWorkTransactionTask_OnReLoginBySession);
			}
			NetWorkTransactionTask.EventReLoginBySession += LoginUITask.<>f__mg$cache0;
			if (LoginUITask.<>f__mg$cache1 == null)
			{
				LoginUITask.<>f__mg$cache1 = new Action<bool>(LoginUITask.NetWorkTransactionTask_ReturnToLoginUI);
			}
			NetWorkTransactionTask.EventReturnToLoginUI += LoginUITask.<>f__mg$cache1;
			if (LoginUITask.<>f__mg$cache2 == null)
			{
				LoginUITask.<>f__mg$cache2 = new Action<bool>(LoginUITask.NetWorkTransactionTask_OnEventShowUIWaiting);
			}
			NetWorkTransactionTask.EventShowUIWaiting += LoginUITask.<>f__mg$cache2;
			UIManager instance = UIManager.Instance;
			if (LoginUITask.<>f__mg$cache3 == null)
			{
				LoginUITask.<>f__mg$cache3 = new Action<bool>(LoginUITask.NetWorkTransactionTask_ReturnToLoginUI);
			}
			instance.EventReturnToLoginUI += LoginUITask.<>f__mg$cache3;
			LoginUITask.m_serverlist.Clear();
			LoginUITask.m_curSelectServerID = -1;
			LoginUITask.s_isGlobalInitialized = true;
			UserGuideUITask.Initialize();
		}

		// Token: 0x06011A69 RID: 72297 RVA: 0x00490B9C File Offset: 0x0048ED9C
		private static void InitLocalConfig()
		{
			if (Application.platform != RuntimePlatform.WindowsEditor)
			{
				LoginUITask.s_localConfigPath = Application.persistentDataPath + "/Config/";
			}
			else
			{
				LoginUITask.s_localConfigPath = Application.persistentDataPath + "/Config_Editor/";
			}
			try
			{
				Directory.CreateDirectory(LoginUITask.s_localConfigPath);
			}
			catch (Exception arg)
			{
				global::Debug.LogError("InitLocalConfig CreateDirectory Error: " + arg);
			}
			LocalConfig.Instance = new LocalConfig();
			LocalConfig.Instance.SetFileName(LoginUITask.s_localConfigPath + "Config.txt");
			LocalConfig.Instance.Load();
			LocalConfig.Instance.Apply(true);
			LocalAccountConfig.Instance = new LocalAccountConfig();
			LocalProcessingBattle.Instance = new LocalProcessingBattle();
			LocalProcessingBattle.Instance.SetFileName(LoginUITask.s_localConfigPath + "Battle.txt");
			LocalProcessingBattle.ArenaInstance = new LocalProcessingBattle();
			LocalProcessingBattle.ArenaInstance.SetFileName(LoginUITask.s_localConfigPath + "ArenaBattle.txt");
		}

		// Token: 0x06011A6A RID: 72298 RVA: 0x00490CA0 File Offset: 0x0048EEA0
		private static void LogSystemInfo()
		{
			string str = TestUIController.BuildSystemInfoText(false);
			global::Debug.Log(str);
		}

		// Token: 0x17003631 RID: 13873
		// (get) Token: 0x06011A6B RID: 72299 RVA: 0x00490CBC File Offset: 0x0048EEBC
		public static List<LoginUITask.ServerInfo> ServerList
		{
			get
			{
				return LoginUITask.m_serverlist;
			}
		}

		// Token: 0x06011A6C RID: 72300 RVA: 0x00490CC4 File Offset: 0x0048EEC4
		public static LoginUITask.ServerInfo GetServerInfoByBornChannelID(int bornChannelID)
		{
			if (LoginUITask.m_serverlist == null || LoginUITask.m_serverlist.Count == 0 || LoginUITask.m_curSelectServerID < 0)
			{
				return null;
			}
			LoginUITask.ServerInfo currentServer = LoginUITask.GetCurrentSelectServerInfo();
			if (currentServer == null)
			{
				return null;
			}
			return LoginUITask.m_serverlist.Find((LoginUITask.ServerInfo i) => i.m_realmID == currentServer.m_realmID && i.m_bornChannelId == bornChannelID);
		}

		// Token: 0x06011A6D RID: 72301 RVA: 0x00490D34 File Offset: 0x0048EF34
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
			this.m_assets.Clear();
			if (this.m_curLoadingLayers.Count == 0)
			{
				AssetUtility.AddAssetToList("FX/UI_ABS/UI_Fx/U_click_down.prefab", this.m_assets);
				AssetUtility.AddAssetToList("FX/UI_ABS/UI_Fx/U_click.prefab", this.m_assets);
				AssetUtility.AddSpriteAssetToList("UI/Login_ABS/Label_Notice.png", this.m_assets);
				AssetUtility.AddSpriteAssetToList("UI/Login_ABS/Label_Activity.png", this.m_assets);
			}
			else if (this.m_curLoadingLayers.Find((UITaskBase.LayerDesc layer) => layer.m_layerName == "ServerListUIController") != null)
			{
				foreach (string name in UIAsset.ServerStateSpritePath)
				{
					AssetUtility.AddSpriteAssetToList(name, this.m_assets);
				}
				ClientConfigDataLoader clientConfigDataLoader = GameManager.Instance.ConfigDataLoader as ClientConfigDataLoader;
				foreach (KeyValuePair<int, ConfigDataCharImageInfo> keyValuePair in clientConfigDataLoader.GetAllConfigDataCharImageInfo())
				{
					AssetUtility.AddSpriteAssetToList(keyValuePair.Value.SmallHeadImage, this.m_assets);
				}
			}
			return this.m_assets.Count > 0;
		}

		// Token: 0x06011A6E RID: 72302 RVA: 0x00490ED8 File Offset: 0x0048F0D8
		protected override List<string> CollectAllDynamicResForLoad()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectAllDynamicResForLoad_hotfix != null)
			{
				return (List<string>)this.m_CollectAllDynamicResForLoad_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_assets;
		}

		// Token: 0x06011A6F RID: 72303 RVA: 0x00490F4C File Offset: 0x0048F14C
		protected override void PostOnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostOnLoadAllResCompleted_hotfix != null)
			{
				this.m_PostOnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_assets.Clear();
			base.PostOnLoadAllResCompleted();
		}

		// Token: 0x06011A70 RID: 72304 RVA: 0x00490FC0 File Offset: 0x0048F1C0
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
				if (sceneLayerBase != null && sceneLayerBase.State != SceneLayerBase.LayerState.InStack)
				{
					SceneManager.Instance.PushLayer(sceneLayerBase);
				}
			}
		}

		// Token: 0x17003632 RID: 13874
		// (get) Token: 0x06011A71 RID: 72305 RVA: 0x0049106C File Offset: 0x0048F26C
		private static bool ShouldUsePDSDK
		{
			get
			{
				LoginUITask.ServerInfo currentSelectServerInfo = LoginUITask.GetCurrentSelectServerInfo();
				return currentSelectServerInfo == null || !string.IsNullOrEmpty(currentSelectServerInfo.m_loginAgentUrl);
			}
		}

		// Token: 0x06011A72 RID: 72306 RVA: 0x00491098 File Offset: 0x0048F298
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
			if (this.m_serverListUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 1)
				{
					this.m_serverListUIController = (this.m_uiCtrlArray[1] as ServerListUIController);
				}
				if (this.m_serverListUIController != null)
				{
					this.m_serverListUIController.EventOnClosed += this.ServerListUIController_OnServerListClosed;
					LoginUITask.ServerInfo currentSelectServerInfo = LoginUITask.GetCurrentSelectServerInfo();
					this.m_serverListUIController.SetServerList(LoginUITask.m_serverlist, LoginUITask.GetRecentLoginServerList(), this.m_exsitCharsInfo, LoginUITask.m_curSelectServerID);
				}
			}
			if (this.m_createCharaterUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 2)
				{
					this.m_createCharaterUIController = (this.m_uiCtrlArray[2] as CreateCharacterUIController);
				}
				if (!(this.m_createCharaterUIController != null))
				{
					global::Debug.LogError("CreateCharacterUIController is null");
					return;
				}
				this.m_createCharaterUIController.EventOnCreate += this.CreateCharacterUIController_OnCreate;
				this.m_createCharaterUIController.EventOnAutoName += this.CreateCharacterUIController_OnAutoName;
			}
			if (this.m_loginCommonUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 3)
				{
					this.m_loginCommonUIController = (this.m_uiCtrlArray[3] as LoginCommonUIController);
				}
				if (!(this.m_loginCommonUIController != null))
				{
					global::Debug.LogError("LoginCommonUIController is null");
					return;
				}
				this.m_loginCommonUIController.FadeIn(0.5f, Color.black, null);
				this.m_loginCommonUIController.InitTouchFx();
			}
			if (this.m_loginUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_loginUIController = (this.m_uiCtrlArray[0] as LoginUIController);
				}
				if (!(this.m_loginUIController != null))
				{
					global::Debug.LogError("InitAllUIControllers LoginUIController is null");
					return;
				}
				this.m_loginUIController.EventSelectServer += this.LoginUIController_OnSelectServerClick;
				this.m_loginUIController.EventOnLogin += this.LoginUIController_OnLogin;
				this.m_loginUIController.EventOnSaveServerConfig += this.LoginUIController_OnSaveServerConfig;
				this.m_loginUIController.EventAccountTextChanged += this.LoginUIController_OnAccountTextChanged;
				this.m_loginUIController.EventOpenUserCenter += this.LoginUIController_OnOpenUserCenter;
				this.m_loginUIController.EventLoginPCClient += this.LoginUIController_OnLoginPCClient;
				this.m_loginUIController.EventOnCloseAnnouncePanel += this.LoginUIController_OnCloseAnnouncePanel;
				this.m_loginUIController.EventOnOpenAnnouncePanel += this.LoginUIController_OnOpenAnnouncePanel;
				PDSDK.m_eventLoginFailed = new Action(this.PDSK_OnLoginFailed);
				PDSDK.m_eventLoginSuccess = new Action<LoginSuccessMsg>(this.PDSDK_OnLoginSuccess);
				if (LoginUITask.<>f__mg$cache4 == null)
				{
					LoginUITask.<>f__mg$cache4 = new Action(LoginUITask.PDSDK_OnLogoutSuccess);
				}
				PDSDK.m_eventLogoutSuccess = LoginUITask.<>f__mg$cache4;
				PDSDK.m_eventInitSuccess = new Action(this.PDSDK_OnInitSucess);
				PDSDK.m_eventInitFailed = new Action(this.PDSDK_OnInitFailed);
				PDSDK.m_eventQRLoginSuccess = new Action<string>(this.PDSDK_OnQRLoginSuccess);
				PDSDK.m_eventQRLoginFailed = new Action<string>(this.PDSDK_OnQRLoginFailed);
				PDSDK.m_eventQRLoginCancel = new Action<string>(this.PDSDK_OnQRLoginCancel);
				if (LoginUITask.<>f__mg$cache5 == null)
				{
					LoginUITask.<>f__mg$cache5 = new Action<LoginSuccessMsg>(LoginUITask.PDSDK_OnSwitchUserSuccess);
				}
				PDSDK.m_eventOnSwitchUserSuccess = LoginUITask.<>f__mg$cache5;
				AudioUtility.PlaySound(this.m_configDataLoader.UtilityGetSound(SoundTableId.SoundTableId_LoginMusic));
				UIUtility.SetLongFrame();
				if (LoginUITask.GetCurrentSelectServerInfo() != null && LoginUITask.ShouldUsePDSDK && !LoginUITask.m_isAutoRelogin && !LoginUITask.m_isReturnToLoginAndSwitchUser && !LoginUITask.m_isReturnToLoginAndOnLoginSuccess)
				{
					this.PDLogin();
				}
				this.StartCoroutineKeepUpdatingServerList();
				Utility.LogMemorySize("LoginUITask.InitAllUIControllers");
			}
			UIUtility.ActivateLayer(this.m_createCharaterUIController, false);
			if (!string.IsNullOrEmpty(LoginUITask.m_loadConfigFailedMessage))
			{
				this.m_loginUIController.ShowMessage(LoginUITask.m_loadConfigFailedMessage, 60, true);
			}
			GameObject gameObject = GameObject.Find("UILayerGroupRoot2");
			if (gameObject != null)
			{
				gameObject.SetActive(false);
			}
		}

		// Token: 0x06011A73 RID: 72307 RVA: 0x004914E4 File Offset: 0x0048F6E4
		private void StartCoroutineKeepUpdatingServerList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartCoroutineKeepUpdatingServerList_hotfix != null)
			{
				this.m_StartCoroutineKeepUpdatingServerList_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_loginUIController.StartCoroutine(this.KeepUpdatingServerList());
		}

		// Token: 0x06011A74 RID: 72308 RVA: 0x00491558 File Offset: 0x0048F758
		public static void SetLocalPushNotifications()
		{
			ClientConfigDataLoader clientConfigDataLoader = GameManager.Instance.ConfigDataLoader as ClientConfigDataLoader;
			if (clientConfigDataLoader == null || PDSDK.Instance == null)
			{
				return;
			}
			PDSDK.Instance.clearLocalNotifications();
			Dictionary<int, ConfigDataDailyPushNotification> dictionary = new Dictionary<int, ConfigDataDailyPushNotification>();
			foreach (KeyValuePair<int, ConfigDataDailyPushNotification> keyValuePair in clientConfigDataLoader.GetAllConfigDataDailyPushNotification())
			{
				DateTime pushNotificationTime = LoginUITask.GetPushNotificationTime(keyValuePair.Value);
				if (pushNotificationTime != DateTime.MinValue)
				{
					PDSDK.Instance.doAddLocalPush(keyValuePair.Value.Title, keyValuePair.Value.Content, string.Format("{0:yyyyMMdd}", pushNotificationTime), pushNotificationTime.Hour.ToString("00"), pushNotificationTime.Minute.ToString("00"));
					global::Debug.Log(new object[]
					{
						string.Concat(new object[]
						{
							"SetLocalPushNotifications ",
							keyValuePair.Value.Content,
							" ",
							pushNotificationTime,
							" ",
							string.Format("{0:yyyyMMdd}", pushNotificationTime)
						}),
						pushNotificationTime.Hour.ToString("00"),
						pushNotificationTime.Minute.ToString("00")
					});
				}
				else if (keyValuePair.Value.Hour != -1)
				{
					if (keyValuePair.Value.PushCondition == UserGuideCondition.UserGuideCondition_ || UserGuideUITask.CheckCondition(keyValuePair.Value.PushCondition, keyValuePair.Value.PCParam))
					{
						dictionary.Add(keyValuePair.Key, keyValuePair.Value);
					}
				}
			}
			DateTime dateTime = DateTime.Today;
			for (int i = 0; i < 14; i++)
			{
				foreach (KeyValuePair<int, ConfigDataDailyPushNotification> keyValuePair2 in dictionary)
				{
					PDSDK.Instance.doAddLocalPush(keyValuePair2.Value.Title, keyValuePair2.Value.Content, string.Format("{0:yyyyMMdd}", dateTime), keyValuePair2.Value.Hour.ToString("00"), keyValuePair2.Value.Minute.ToString("00"));
				}
				dateTime = dateTime.AddDays(1.0);
			}
		}

		// Token: 0x06011A75 RID: 72309 RVA: 0x00491840 File Offset: 0x0048FA40
		private static DateTime GetPushNotificationTime(ConfigDataDailyPushNotification cfg)
		{
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int id = cfg.ID;
			if (id != 4)
			{
				if (id != 5)
				{
					if (id == 6)
					{
						if (LocalConfig.Instance.Data.NotifyStoreRefresh)
						{
							return projectLPlayerContext.GetBlackMarketNextFlushTime();
						}
					}
				}
				else if (LocalConfig.Instance.Data.NotifyArenaTicket)
				{
					return projectLPlayerContext.GetArenaTicketNextGivenTime();
				}
			}
			else if (LocalConfig.Instance.Data.NotifyEnergyRecover)
			{
				return projectLPlayerContext.GetEnergyReachMaxTime();
			}
			return DateTime.MinValue;
		}

		// Token: 0x06011A76 RID: 72310 RVA: 0x004918E4 File Offset: 0x0048FAE4
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
			if (this.m_loginUIController != null)
			{
				this.m_loginUIController.EventSelectServer -= this.LoginUIController_OnSelectServerClick;
				this.m_loginUIController.EventOnLogin -= this.LoginUIController_OnLogin;
				this.m_loginUIController.EventOnSaveServerConfig -= this.LoginUIController_OnSaveServerConfig;
				this.m_loginUIController.EventAccountTextChanged -= this.LoginUIController_OnAccountTextChanged;
				this.m_loginUIController.EventOpenUserCenter -= this.LoginUIController_OnOpenUserCenter;
				this.m_loginUIController.EventLoginPCClient -= this.LoginUIController_OnLoginPCClient;
				this.m_loginUIController.EventOnCloseAnnouncePanel -= this.LoginUIController_OnCloseAnnouncePanel;
				this.m_loginUIController.EventOnOpenAnnouncePanel -= this.LoginUIController_OnOpenAnnouncePanel;
				this.m_loginUIController = null;
				PDSDK.m_eventLoginFailed = null;
				PDSDK.m_eventLoginSuccess = null;
				PDSDK.m_eventInitSuccess = null;
				PDSDK.m_eventInitFailed = null;
				PDSDK.m_eventQRLoginSuccess = null;
				PDSDK.m_eventQRLoginFailed = null;
				PDSDK.m_eventQRLoginCancel = null;
			}
			if (this.m_serverListUIController != null)
			{
				this.m_serverListUIController.EventOnClosed -= this.ServerListUIController_OnServerListClosed;
				this.m_serverListUIController = null;
			}
			if (this.m_createCharaterUIController != null)
			{
				this.m_createCharaterUIController.EventOnCreate -= this.CreateCharacterUIController_OnCreate;
				this.m_createCharaterUIController.EventOnAutoName -= this.CreateCharacterUIController_OnAutoName;
				this.m_createCharaterUIController = null;
			}
			if (this.m_loginCommonUIController != null)
			{
				this.m_loginCommonUIController = null;
			}
		}

		// Token: 0x06011A77 RID: 72311 RVA: 0x00491AD4 File Offset: 0x0048FCD4
		private static List<LoginUITask.ServerInfo> GetRecentLoginServerList()
		{
			List<LoginUITask.ServerInfo> list = new List<LoginUITask.ServerInfo>();
			if (LocalConfig.Instance.Data.RecentLoginServerIDs == null)
			{
				return list;
			}
			LoginUITask.m_isRecentLoginServerIDInServerlist = true;
			int[] recentLoginServerIDs = LocalConfig.Instance.Data.RecentLoginServerIDs;
			for (int j = 0; j < recentLoginServerIDs.Length; j++)
			{
				int id = recentLoginServerIDs[j];
				LoginUITask.ServerInfo serverInfo = LoginUITask.m_serverlist.Find((LoginUITask.ServerInfo i) => i.m_id == id);
				if (serverInfo == null)
				{
					LoginUITask.m_isRecentLoginServerIDInServerlist = false;
				}
				else
				{
					list.Add(serverInfo);
				}
			}
			return list;
		}

		// Token: 0x06011A78 RID: 72312 RVA: 0x00491B6C File Offset: 0x0048FD6C
		private void ServerListUIController_OnServerListClosed(int selectedServerID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ServerListUIController_OnServerListClosedInt32_hotfix != null)
			{
				this.m_ServerListUIController_OnServerListClosedInt32_hotfix.call(new object[]
				{
					this,
					selectedServerID
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (selectedServerID < 0)
			{
				return;
			}
			if (LoginUITask.m_curSelectServerID == selectedServerID)
			{
				return;
			}
			global::Debug.Log(string.Format("OnServerListClosed: Server No. {0} was selected.", selectedServerID));
			LoginUITask.m_curSelectServerID = selectedServerID;
			PDSDK.Instance.printGameEventLog("24", string.Empty);
			LoginUITask.ServerInfo currentSelectServerInfo = LoginUITask.GetCurrentSelectServerInfo();
			if (this.m_loginUIController != null)
			{
				this.m_loginUIController.SetServerInfo(currentSelectServerInfo);
				this.m_loginUIController.EnablePDSDKLoginMode(LoginUITask.ShouldUsePDSDK);
			}
			if (currentSelectServerInfo != null && this.m_curLoginAgnetUrl.ToLower() != currentSelectServerInfo.m_loginAgentUrl.ToLower() && LoginUITask.ShouldUsePDSDK)
			{
				this.PDLogin();
			}
			this.UpdateGMUserFlag(null);
		}

		// Token: 0x06011A79 RID: 72313 RVA: 0x00491C90 File Offset: 0x0048FE90
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
			this.m_isOpeningUI = true;
			if (AssetUtility.Instance != null)
			{
				AssetUtility.Instance.RegisterDynamicAssetCache(this.m_dynamicResCacheDict);
			}
			return base.OnStart(intent);
		}

		// Token: 0x06011A7A RID: 72314 RVA: 0x00491D34 File Offset: 0x0048FF34
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
			if (AssetUtility.Instance != null)
			{
				AssetUtility.Instance.UnregisterDynamicAssetCache(this.m_dynamicResCacheDict);
			}
			this.m_loginCommonUIController.DisposeTouchFx();
			base.OnStop();
		}

		// Token: 0x06011A7B RID: 72315 RVA: 0x00491DC0 File Offset: 0x0048FFC0
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
			this.m_isOpeningUI = true;
			this.InitLayerStateOnLoadAllResCompleted();
			return base.OnResume(intent);
		}

		// Token: 0x06011A7C RID: 72316 RVA: 0x00491E50 File Offset: 0x00490050
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
			UIUtility.CheckLongFrame();
		}

		// Token: 0x06011A7D RID: 72317 RVA: 0x00491EBC File Offset: 0x004900BC
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
			if (this.m_isOpeningUI)
			{
				LoginSettings loginSetting = GameManager.Instance.GameClientSetting.LoginSetting;
				if (this.IsEditorTestLogin())
				{
					this.m_loginUIController.SetAccountName(loginSetting.LoginAccount);
					this.m_loginUIController.SetPassword(string.Empty);
				}
				else
				{
					LocalConfigData data = LocalConfig.Instance.Data;
					if (string.IsNullOrEmpty(data.AccountName))
					{
						data.AccountName = loginSetting.LoginAccount;
					}
					this.m_loginUIController.SetAccountName(data.AccountName);
					this.m_loginUIController.SetPassword(data.Password);
					this.m_loginUIController.EnablePDSDKLoginMode(LoginUITask.ShouldUsePDSDK);
					this.m_loginUIController.SetClientVersion(this.m_configDataLoader.Version);
					this.m_loginUIController.SetServerInfo(LoginUITask.GetCurrentSelectServerInfo());
				}
				this.m_loginUIController.StartCoroutine(LoginUITask.CheckClientVersion());
				this.DownloadAnnounceFile(true);
				if (!LoginUITask.m_isAutoRelogin)
				{
					this.DownloadServerListFile();
				}
				this.ReqExistChars();
				this.DownloadGMUserIDs();
				LoginUITask.DeleteExpiredLogFiles(Application.persistentDataPath + "/Log/", this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_ClientLogFileExpireDays));
				this.UpdateLoginPCClientButton();
			}
		}

		// Token: 0x06011A7E RID: 72318 RVA: 0x00492048 File Offset: 0x00490248
		public static void DeleteExpiredLogFiles(string logFolder, int days)
		{
			try
			{
				if (!string.IsNullOrEmpty(logFolder) && days > 0)
				{
					DateTime t = DateTime.Now.AddDays((double)(-(double)days));
					foreach (string fileName in Directory.GetFiles(logFolder, "Log*.txt"))
					{
						FileInfo fileInfo = new FileInfo(fileName);
						if (fileInfo.LastWriteTime < t)
						{
							File.Delete(fileInfo.FullName);
						}
					}
				}
			}
			catch (Exception ex)
			{
				global::Debug.LogError(string.Format("LoginUITask.DeleteExpiredLogFiles Exception: {0}", ex.Message));
			}
		}

		// Token: 0x06011A7F RID: 72319 RVA: 0x00492100 File Offset: 0x00490300
		public static IEnumerator CheckClientVersion()
		{
			if (PDSDK.IsIosReview)
			{
				yield break;
			}
			if (Application.internetReachability == NetworkReachability.NotReachable)
			{
				global::Debug.Log("LoginUITask.CheckClientVersion Network Not Reachable");
				yield break;
			}
			yield return Utility.GetUpdateClientURL(null);
			global::Debug.Log("LoginUITask.CheckClientVersion");
			if (ResourceManager.Instance == null)
			{
				global::Debug.LogError("LoginUITask.CheckClientVersion ResourceManager.Instance == null");
				yield break;
			}
			bool isCheckSucceed = false;
			int newestClientVersion = -1;
			uint newestClientCrc = 0u;
			bool isLocalNewest = true;
			yield return ResourceManager.Instance.CheckBundleDataVersionFromUrl(delegate(bool succeed, int newestVer, uint newestCrc, bool localNewest)
			{
				isCheckSucceed = succeed;
				newestClientVersion = newestVer;
				newestClientCrc = newestCrc;
				isLocalNewest = localNewest;
			});
			if (!isCheckSucceed)
			{
				global::Debug.LogError("LoginUITask.CheckClientVersion ResourceManager.CheckBundleDataVersionFromUrl failed.");
				yield break;
			}
			global::Debug.Log(string.Format("LoginUI.CheckClientVersion newestClientVersion={0}, isLocalNewest={1}", newestClientVersion, isLocalNewest));
			if (newestClientVersion >= 0 && !isLocalNewest)
			{
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				yield return DialogBox.Show(SceneManager.Instance.RootCanvasGo, "Assets/GameProject/RuntimeAssets/UI/Common_ABS/Prefab/DialogBox.prefab", configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_PleaseUpdateClient), configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_DialogBox_Ok), string.Empty, delegate(DialogBoxResult result)
				{
					Application.Quit();
				});
			}
			yield break;
		}

		// Token: 0x06011A80 RID: 72320 RVA: 0x00492114 File Offset: 0x00490314
		protected override void PostUpdateView()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostUpdateView_hotfix != null)
			{
				this.m_PostUpdateView_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isOpeningUI = false;
			UIUtility.SetLongFrame();
			this.StopEntryUITask();
		}

		// Token: 0x06011A81 RID: 72321 RVA: 0x00492188 File Offset: 0x00490388
		private void StopEntryUITask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StopEntryUITask_hotfix != null)
			{
				this.m_StopEntryUITask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UITaskBase uitaskBase = UIManager.Instance.FindUITaskWithName("ProjectLGameEntryUITask");
			if (uitaskBase == null)
			{
				return;
			}
			uitaskBase.Stop();
		}

		// Token: 0x17003633 RID: 13875
		// (get) Token: 0x06011A82 RID: 72322 RVA: 0x00492208 File Offset: 0x00490408
		public static int RecommendServerIndex
		{
			get
			{
				if (LoginUITask.m_serverlist.Count == 0)
				{
					LoginUITask.m_recommendServerIndex = -1;
					global::Debug.LogError("LoginUITask.RecommendServerID m_serverList.Count==0");
					return -1;
				}
				if (LoginUITask.m_recommendServerIndex >= 0 && LoginUITask.m_recommendServerIndex < LoginUITask.m_serverlist.Count)
				{
					return LoginUITask.m_recommendServerIndex;
				}
				float num = UnityEngine.Random.Range(0f, LoginUITask.m_totalRecommandWeight);
				for (int i = 0; i < LoginUITask.m_serverlist.Count; i++)
				{
					LoginUITask.ServerInfo serverInfo = LoginUITask.m_serverlist[i];
					if (serverInfo.m_recommendWeight >= 0.0001f)
					{
						num -= serverInfo.m_recommendWeight;
						if (num < 0.0001f)
						{
							LoginUITask.m_recommendServerIndex = i;
							return i;
						}
					}
				}
				LoginUITask.m_recommendServerIndex = 0;
				return 0;
			}
		}

		// Token: 0x06011A83 RID: 72323 RVA: 0x004922CC File Offset: 0x004904CC
		public static LoginUITask.ServerInfo GetCurrentSelectServerInfo()
		{
			if (LoginUITask.m_curSelectServerID >= 0)
			{
				LoginUITask.ServerInfo serverInfo = LoginUITask.m_serverlist.Find((LoginUITask.ServerInfo i) => i.m_id == LoginUITask.m_curSelectServerID);
				if (serverInfo != null)
				{
					return serverInfo;
				}
			}
			List<LoginUITask.ServerInfo> recentLoginServerList = LoginUITask.GetRecentLoginServerList();
			if (recentLoginServerList.Count > 0)
			{
				LoginUITask.m_curSelectServerID = recentLoginServerList[0].m_id;
				return recentLoginServerList[0];
			}
			if (LoginUITask.m_serverlist.Count > 0 && LoginUITask.RecommendServerIndex >= 0)
			{
				LoginUITask.ServerInfo serverInfo2 = LoginUITask.m_serverlist[LoginUITask.RecommendServerIndex];
				LoginUITask.m_curSelectServerID = serverInfo2.m_id;
				return serverInfo2;
			}
			return null;
		}

		// Token: 0x06011A84 RID: 72324 RVA: 0x00492378 File Offset: 0x00490578
		private void DownloadServerListFile()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DownloadServerListFile_hotfix != null)
			{
				this.m_DownloadServerListFile_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_loginUIController != null)
			{
				if (this.m_downloadServerListCoroutine != null)
				{
					this.m_loginUIController.StopCoroutine(this.m_downloadServerListCoroutine);
				}
				this.m_downloadServerListCoroutine = this.m_loginUIController.StartCoroutine(Util.DownloadHttpFile(DefaultServerAddress.ServerListURL, delegate(bool isSucceed, WWW www)
				{
					if (isSucceed)
					{
						if (PDSDK.IsIosLoginWindowsPlayer && !LoginUITask.m_isRecentLoginServerIDInServerlist && !string.IsNullOrEmpty(LoginUITask.m_serverListText) && !string.IsNullOrEmpty(www.text) && LoginUITask.m_serverListText != www.text)
						{
							LoginUITask.m_curSelectServerID = -1;
						}
						LoginUITask.m_serverListText = www.text;
						LoginUITask.ParseServerListText(LoginUITask.m_serverListText);
					}
					else
					{
						this.m_loginUIController.ShowMessage(StringTableId.StringTableId_DownloadServerListFailed, 3, true);
					}
					this.m_downloadServerListCoroutine = null;
				}, null));
			}
		}

		// Token: 0x06011A85 RID: 72325 RVA: 0x00492430 File Offset: 0x00490630
		private void DownloadAnnounceFile(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DownloadAnnounceFileBoolean_hotfix != null)
			{
				this.m_DownloadAnnounceFileBoolean_hotfix.call(new object[]
				{
					this,
					isShow2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool isShow = isShow2;
			LoginUITask $this = this;
			if (this.m_loginUIController != null)
			{
				this.m_loginUIController.StartCoroutine(Util.DownloadHttpFile(DefaultServerAddress.AnnouncementsURL, delegate(bool isSucceed, WWW www)
				{
					if (isSucceed)
					{
						$this.m_loginUIController.SetAnnounce(www.text);
						if (isShow)
						{
							if (LoginUITask.m_isAutoRelogin)
							{
								LoginUITask.m_isAutoRelogin = false;
								$this.LoginUIController_OnLogin();
							}
							else if (LoginUITask.m_isReturnToLoginAndSwitchUser)
							{
								LoginUITask.m_isReturnToLoginAndSwitchUser = false;
								if (LoginUITask.ShouldUsePDSDK)
								{
									$this.LoginUIController_OnOpenUserCenter();
								}
								else
								{
									$this.m_loginUIController.ShowStartAnimation();
								}
							}
							else if (LoginUITask.m_isReturnToLoginAndOnLoginSuccess)
							{
								LoginUITask.m_isReturnToLoginAndOnLoginSuccess = false;
								if (LoginUITask.ShouldUsePDSDK)
								{
									$this.PDSDK_OnLoginSuccess(LoginUITask.m_onSwitchUserSuccessMsg);
								}
								$this.m_loginUIController.ShowStartAnimation();
							}
							else
							{
								$this.m_loginUIController.ShowAnnouncePanel(true, null);
							}
							PDSDK.Instance.printGameEventLog("21", string.Empty);
						}
					}
					else
					{
						$this.m_loginUIController.ShowStartAnimation();
						$this.m_loginUIController.ShowMessage(StringTableId.StringTableId_DownloadAnnounceFailed, 3, true);
					}
				}, null));
			}
		}

		// Token: 0x06011A86 RID: 72326 RVA: 0x004924E8 File Offset: 0x004906E8
		private void DownloadGMUserIDs()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DownloadGMUserIDs_hotfix != null)
			{
				this.m_DownloadGMUserIDs_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_loginUIController != null)
			{
				this.m_loginUIController.StartCoroutine(Util.DownloadHttpFile(DefaultServerAddress.GMUserConfigURL, delegate(bool isSucceed, WWW www)
				{
					if (isSucceed)
					{
						this.ParseGMUserIDsText(www.text);
					}
				}, null));
			}
		}

		// Token: 0x06011A87 RID: 72327 RVA: 0x0049257C File Offset: 0x0049077C
		private void ParseGMUserIDsText(string text)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ParseGMUserIDsTextString_hotfix != null)
			{
				this.m_ParseGMUserIDsTextString_hotfix.call(new object[]
				{
					this,
					text
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_gmUserIDs == null)
			{
				this.m_gmUserIDs = new Dictionary<string, HashSet<string>>();
			}
			this.m_gmUserIDs.Clear();
			string[] array = Array.ConvertAll<string, string>(text.Split(new char[]
			{
				'\n'
			}), (string s) => s.Trim());
			foreach (string text2 in array)
			{
				if (!text2.StartsWith("//"))
				{
					string[] array3 = Array.ConvertAll<string, string>(text2.Split(new char[]
					{
						','
					}), (string inputString) => inputString.Trim());
					if (array3.Length < 2)
					{
						global::Debug.LogError(string.Format("LoginUITask.ParseGMUserIDsText {0} 's segments count is less than 2.", text2));
					}
					else if (!string.IsNullOrEmpty(array3[0]) && !this.m_gmUserIDs.ContainsKey(array3[0]))
					{
						HashSet<string> hashSet = new HashSet<string>();
						for (int j = 1; j < array3.Length; j++)
						{
							hashSet.Add(array3[j]);
						}
						this.m_gmUserIDs.Add(array3[0], hashSet);
					}
				}
			}
			this.UpdateGMUserFlag(null);
		}

		// Token: 0x17003634 RID: 13876
		// (get) Token: 0x06011A88 RID: 72328 RVA: 0x00492730 File Offset: 0x00490930
		public static bool IsGMUser
		{
			get
			{
				return LoginUITask.m_isGMUser;
			}
		}

		// Token: 0x06011A89 RID: 72329 RVA: 0x00492738 File Offset: 0x00490938
		public void UpdateLoginPCClientButton()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateLoginPCClientButton_hotfix != null)
			{
				this.m_UpdateLoginPCClientButton_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06011A8A RID: 72330 RVA: 0x00492798 File Offset: 0x00490998
		private bool IsSdkIDCanLoginPCClient(string sdkChannelID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsSdkIDCanLoginPCClientString_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsSdkIDCanLoginPCClientString_hotfix.call(new object[]
				{
					this,
					sdkChannelID
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return PDSDK.Instance != null && (sdkChannelID == PDSDK.Instance.PDAndroidChannelID || sdkChannelID == PDSDK.Instance.IOSChannelID);
		}

		// Token: 0x06011A8B RID: 72331 RVA: 0x00492850 File Offset: 0x00490A50
		public void UpdateGMUserFlag(LoginUITask.ServerInfo si = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateGMUserFlagServerInfo_hotfix != null)
			{
				this.m_UpdateGMUserFlagServerInfo_hotfix.call(new object[]
				{
					this,
					si
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (Application.platform != RuntimePlatform.WindowsEditor)
			{
				LoginUITask.m_isGMUser = false;
				if (DebugConsoleView.instance != null)
				{
					DebugConsoleView.instance.IsForceHide = true;
				}
				if (this.m_gmUserIDs == null || this.m_gmUserIDs.Count == 0)
				{
					return;
				}
				if (si == null)
				{
					si = LoginUITask.GetCurrentSelectServerInfo();
					if (si == null)
					{
						return;
					}
				}
				HashSet<string> hashSet;
				if (!this.m_gmUserIDs.TryGetValue(si.ToString(), out hashSet))
				{
					return;
				}
				string text;
				if (string.IsNullOrEmpty(si.m_loginAgentUrl))
				{
					text = this.m_loginUIController.GetAccountName();
				}
				else
				{
					text = si.m_sdkPlatformUserID;
				}
				if (!hashSet.Contains("*") && (string.IsNullOrEmpty(text) || !hashSet.Contains(text)))
				{
					return;
				}
			}
			LoginUITask.m_isGMUser = true;
			if (DebugConsoleView.instance != null)
			{
				DebugConsoleView.instance.IsForceHide = false;
			}
		}

		// Token: 0x06011A8C RID: 72332 RVA: 0x0049299C File Offset: 0x00490B9C
		private void UpdateLocalConfigGMUser()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateLocalConfigGMUser_hotfix != null)
			{
				this.m_UpdateLocalConfigGMUser_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (LocalConfig.Instance != null)
			{
				LocalConfig.Instance.UpdateGMUser(LoginUITask.IsGMUser);
				LocalConfig.Instance.Save();
			}
		}

		// Token: 0x06011A8D RID: 72333 RVA: 0x00492A20 File Offset: 0x00490C20
		[DebuggerHidden]
		public IEnumerator GetSDKPlatformUserID(LoginUITask.ServerInfo si)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSDKPlatformUserIDServerInfo_hotfix != null)
			{
				return (IEnumerator)this.m_GetSDKPlatformUserIDServerInfo_hotfix.call(new object[]
				{
					this,
					si
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LoginUITask.<GetSDKPlatformUserID>c__Iterator1 <GetSDKPlatformUserID>c__Iterator = new LoginUITask.<GetSDKPlatformUserID>c__Iterator1();
			<GetSDKPlatformUserID>c__Iterator.si = si;
			<GetSDKPlatformUserID>c__Iterator.$this = this;
			return <GetSDKPlatformUserID>c__Iterator;
		}

		// Token: 0x06011A8E RID: 72334 RVA: 0x00492AB4 File Offset: 0x00490CB4
		private void ReqExistChars()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ReqExistChars_hotfix != null)
			{
				this.m_ReqExistChars_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_loginUIController == null)
			{
				return;
			}
			LoginUITask.ServerInfo currentSelectServerInfo = LoginUITask.GetCurrentSelectServerInfo();
			if (currentSelectServerInfo == null || string.IsNullOrEmpty(currentSelectServerInfo.m_sdkPlatformName) || string.IsNullOrEmpty(currentSelectServerInfo.m_sdkPlatformUserID) || string.IsNullOrEmpty(currentSelectServerInfo.m_roleListURL))
			{
				return;
			}
			HashSet<string> hashSet = new HashSet<string>();
			foreach (LoginUITask.ServerInfo serverInfo in LoginUITask.m_serverlist)
			{
				if (serverInfo != null && !string.IsNullOrEmpty(serverInfo.m_roleListURL))
				{
					hashSet.Add(serverInfo.m_roleListURL);
				}
			}
			List<WWW> wwws = new List<WWW>();
			foreach (string text in hashSet)
			{
				wwws.Add(new WWW(string.Format("{0}?{1}={2}&{3}={4}", new object[]
				{
					text,
					"platformUserId",
					WWW.EscapeURL(currentSelectServerInfo.m_sdkPlatformUserID),
					"platformName",
					WWW.EscapeURL(currentSelectServerInfo.m_sdkPlatformName)
				})));
			}
			this.m_exsitCharsInfo.Clear();
			HashSet<WWW> doneWWW = new HashSet<WWW>();
			this.m_loginUIController.StartCoroutine(new WaitUntil(delegate()
			{
				foreach (WWW www in wwws)
				{
					if (!doneWWW.Contains(www) && www.isDone)
					{
						doneWWW.Add(www);
						if (!string.IsNullOrEmpty(www.error))
						{
							global::Debug.LogError(string.Format("ReqExistChars from {0} 's Error: {1}", www.url, www.error));
						}
						else
						{
							global::Debug.Log(string.Format("role list server {0} Return: {1}", www.url, www.text));
							try
							{
								JsonData jsonData = JsonMapper.ToObject(www.text);
								if (jsonData["status"].ToString().ToLower() != "ok")
								{
									global::Debug.LogError(string.Format("Exist char ack error: {0}", jsonData["error"].ToString()));
								}
								else
								{
									IEnumerator enumerator4 = ((IEnumerable)jsonData["roleList"]).GetEnumerator();
									try
									{
										while (enumerator4.MoveNext())
										{
											object obj = enumerator4.Current;
											JsonData jsonData2 = (JsonData)obj;
											this.m_exsitCharsInfo.Add(new LoginUITask.ExistCharInfo(www.url.Substring(0, Math.Max(www.url.IndexOf("?"), 0)), ((IJsonWrapper)jsonData2["ServerId"]).GetInt(), ((IJsonWrapper)jsonData2["PlayerLevel"]).GetInt(), ((IJsonWrapper)jsonData2["HeadIcon"]).GetInt(), ((IJsonWrapper)jsonData2["LastLoginHours"]).GetInt(), jsonData2["Name"].ToString()));
										}
									}
									finally
									{
										IDisposable disposable;
										if ((disposable = (enumerator4 as IDisposable)) != null)
										{
											disposable.Dispose();
										}
									}
								}
							}
							catch (Exception ex)
							{
								global::Debug.LogError(string.Format("ReqExistChars: Json parse error: {0}", ex.Message));
							}
						}
					}
				}
				if (wwws.Count == doneWWW.Count)
				{
					if (this.m_exsitCharsInfo.Count > 0 && this.m_serverListUIController != null)
					{
						this.m_serverListUIController.SetServerList(LoginUITask.m_serverlist, LoginUITask.GetRecentLoginServerList(), this.m_exsitCharsInfo, LoginUITask.m_curSelectServerID);
					}
					return true;
				}
				return false;
			}));
		}

		// Token: 0x06011A8F RID: 72335 RVA: 0x00492CB8 File Offset: 0x00490EB8
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
			if (this.m_loginUIController == null)
			{
				return;
			}
			this.m_loginUIController.ShowWaitingNet(show);
		}

		// Token: 0x06011A90 RID: 72336 RVA: 0x00492D48 File Offset: 0x00490F48
		protected override void LaunchEnterGameUIWithGameSettingTokenAndServer()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LaunchEnterGameUIWithGameSettingTokenAndServer_hotfix != null)
			{
				this.m_LaunchEnterGameUIWithGameSettingTokenAndServer_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.LaunchEnterGameUI();
		}

		// Token: 0x06011A91 RID: 72337 RVA: 0x00492DB0 File Offset: 0x00490FB0
		protected override void LaunchEnterGameUIWithUIInputAccountAndServer()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LaunchEnterGameUIWithUIInputAccountAndServer_hotfix != null)
			{
				this.m_LaunchEnterGameUIWithUIInputAccountAndServer_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.LaunchEnterGameUI();
		}

		// Token: 0x06011A92 RID: 72338 RVA: 0x00492E18 File Offset: 0x00491018
		[DebuggerHidden]
		protected override IEnumerator DownloadGameServerLoginAnnouncement(Action<bool> onEnd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DownloadGameServerLoginAnnouncementAction`1_hotfix != null)
			{
				return (IEnumerator)this.m_DownloadGameServerLoginAnnouncementAction`1_hotfix.call(new object[]
				{
					this,
					onEnd
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return new LoginUITask.<DownloadGameServerLoginAnnouncement>c__Iterator2();
		}

		// Token: 0x06011A93 RID: 72339 RVA: 0x00492E9C File Offset: 0x0049109C
		protected override void ShowGameServerLoginAnnouncementUI()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowGameServerLoginAnnouncementUI_hotfix != null)
			{
				this.m_ShowGameServerLoginAnnouncementUI_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06011A94 RID: 72340 RVA: 0x00492EFC File Offset: 0x004910FC
		protected override void ShowEnterGameUI()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowEnterGameUI_hotfix != null)
			{
				this.m_ShowEnterGameUI_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ShowEnterGameUI();
			this.EnableInput(true);
			UIUtility.ActivateLayer(this.m_loginUIController, true);
			UIUtility.ActivateLayer(this.m_createCharaterUIController, false);
		}

		// Token: 0x06011A95 RID: 72341 RVA: 0x00492F84 File Offset: 0x00491184
		[DebuggerHidden]
		protected override IEnumerator StartLoginAgentLogin(Action<int, string, string> onEnd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartLoginAgentLoginAction`3_hotfix != null)
			{
				return (IEnumerator)this.m_StartLoginAgentLoginAction`3_hotfix.call(new object[]
				{
					this,
					onEnd
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LoginUITask.<StartLoginAgentLogin>c__Iterator3 <StartLoginAgentLogin>c__Iterator = new LoginUITask.<StartLoginAgentLogin>c__Iterator3();
			<StartLoginAgentLogin>c__Iterator.onEnd = onEnd;
			<StartLoginAgentLogin>c__Iterator.$this = this;
			return <StartLoginAgentLogin>c__Iterator;
		}

		// Token: 0x06011A96 RID: 72342 RVA: 0x00493018 File Offset: 0x00491218
		protected override bool OnLoginByAuthTokenAck(int ret, string sessionToken, bool needRedirect)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLoginByAuthTokenAckInt32StringBoolean_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnLoginByAuthTokenAckInt32StringBoolean_hotfix.call(new object[]
				{
					this,
					ret,
					sessionToken,
					needRedirect
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool flag = base.OnLoginByAuthTokenAck(ret, sessionToken, needRedirect);
			if (flag)
			{
				this.m_ignoreNetworkErrorOnce = true;
			}
			else if (ret == -7)
			{
				global::Debug.LogError("LoginUITask OnLoginByAuthTokenAck error: the same account has logined. ");
				if (this.m_retryLoginByAuthTokenCount == 0)
				{
					this.m_retryLoginByAuthTokenCount++;
					this.LoginUIController_OnLogin();
				}
				else
				{
					this.m_loginUIController.ShowMessage(StringTableId.StringTableId_ConnectServerFailed, 3, true);
					this.m_loginUIController.StartCoroutine(this.DelayEnableInput(true, 3f));
				}
			}
			else
			{
				global::Debug.LogError("OnLoginByAuthTokenAck error: " + ret);
				if (ret == -11)
				{
					this.m_authtoken = string.Empty;
				}
				if (ret == -10)
				{
					this.m_loginUIController.ShowMessage(StringTableId.StringTableId_ServerIsFull, 3, true);
				}
				else if (ret == -8)
				{
					this.m_loginUIController.ShowMessage(StringTableId.StringTableId_AccountNameOrPasswordWrong, 3, true);
				}
				else if (ret == -9)
				{
					this.m_loginUIController.ShowMessage(StringTableId.StringTableId_AccountBan, 3, true);
				}
				else if (ret == -4)
				{
					this.m_loginUIController.ShowMessage(StringTableId.StringTableId_InvalidClientVersion, 3, true);
				}
				else
				{
					string text = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_ConnectServerFailed) + "   " + ret.ToString();
					this.m_loginUIController.ShowMessage(text, 3, true);
				}
				this.m_loginUIController.StartCoroutine(this.DelayEnableInput(true, 3f));
			}
			return flag;
		}

		// Token: 0x06011A97 RID: 72343 RVA: 0x00493228 File Offset: 0x00491428
		[DebuggerHidden]
		private IEnumerator DelayEnableInput(bool isEnable, float delaySeconds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DelayEnableInputBooleanSingle_hotfix != null)
			{
				return (IEnumerator)this.m_DelayEnableInputBooleanSingle_hotfix.call(new object[]
				{
					this,
					isEnable,
					delaySeconds
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LoginUITask.<DelayEnableInput>c__Iterator4 <DelayEnableInput>c__Iterator = new LoginUITask.<DelayEnableInput>c__Iterator4();
			<DelayEnableInput>c__Iterator.delaySeconds = delaySeconds;
			<DelayEnableInput>c__Iterator.isEnable = isEnable;
			<DelayEnableInput>c__Iterator.$this = this;
			return <DelayEnableInput>c__Iterator;
		}

		// Token: 0x06011A98 RID: 72344 RVA: 0x004932D0 File Offset: 0x004914D0
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
			if (this.m_loginUIController == null)
			{
				return;
			}
			this.m_loginUIController.ShowMessage(id, time, isOverride);
		}

		// Token: 0x06011A99 RID: 72345 RVA: 0x00493380 File Offset: 0x00491580
		protected override bool OnLoginBySessionTokenAck(int ret)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLoginBySessionTokenAckInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnLoginBySessionTokenAckInt32_hotfix.call(new object[]
				{
					this,
					ret
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool flag = base.OnLoginBySessionTokenAck(ret);
			if (flag)
			{
				ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				if (projectLPlayerContext != null)
				{
					this.SaveSessionTokenCache(projectLPlayerContext.GetSessionToken());
				}
				LocalConfig.Instance.AddRecentLoginServerID(LoginUITask.m_curSelectServerID);
				this.SaveLoginInfo();
			}
			else
			{
				global::Debug.LogError("LoginUITask.OnLoginBySessionTokenAck error: " + ret);
				this.ClearSessionTokenCache();
				if (ret == -10)
				{
					this.m_loginUIController.ShowMessage(StringTableId.StringTableId_ServerIsFull, 3, true);
					this.m_loginUIController.StartCoroutine(this.DelayEnableInput(true, 3f));
				}
				else if (this.m_retryLoginBySessionTokenCount == 0)
				{
					this.m_retryLoginBySessionTokenCount++;
					if (this.m_loginUIController != null)
					{
						this.m_loginUIController.StartCoroutine(this.LoginBySessionTokenAgain());
					}
					else
					{
						global::Debug.LogError("LoginUITask.OnLoginBySessionTokenAck m_loginUIController is null, can not login again.");
						this.m_loginUIController.StartCoroutine(this.DelayEnableInput(true, 3f));
					}
				}
				else
				{
					this.m_loginUIController.ShowMessage(StringTableId.StringTableId_ConnectServerFailed, 3, true);
					this.m_loginUIController.StartCoroutine(this.DelayEnableInput(true, 3f));
				}
			}
			return flag;
		}

		// Token: 0x06011A9A RID: 72346 RVA: 0x0049352C File Offset: 0x0049172C
		[DebuggerHidden]
		private IEnumerator LoginBySessionTokenAgain()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LoginBySessionTokenAgain_hotfix != null)
			{
				return (IEnumerator)this.m_LoginBySessionTokenAgain_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LoginUITask.<LoginBySessionTokenAgain>c__Iterator5 <LoginBySessionTokenAgain>c__Iterator = new LoginUITask.<LoginBySessionTokenAgain>c__Iterator5();
			<LoginBySessionTokenAgain>c__Iterator.$this = this;
			return <LoginBySessionTokenAgain>c__Iterator;
		}

		// Token: 0x06011A9B RID: 72347 RVA: 0x004935A8 File Offset: 0x004917A8
		protected override void StartPlayerInfoInitReq()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartPlayerInfoInitReq_hotfix != null)
			{
				this.m_StartPlayerInfoInitReq_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_loginTaskState = LoginUITaskBase.LoginState.StartPlayerInfoInit;
			this.EnableInput(false);
			PlayerInfoInitNetTask playerInfoInitNetTask = new PlayerInfoInitNetTask();
			playerInfoInitNetTask.EventOnStop += delegate(Task task)
			{
				PlayerInfoInitNetTask playerInfoInitNetTask2 = task as PlayerInfoInitNetTask;
				PlayerInfoInitNetTask.ResultState reqResultState = playerInfoInitNetTask2.ReqResultState;
				if (reqResultState != PlayerInfoInitNetTask.ResultState.CreateCharacter)
				{
					if (reqResultState == PlayerInfoInitNetTask.ResultState.InitEnd)
					{
						this.OnPlayerInfoInitEnd();
					}
				}
				else
				{
					LoginUITask.ServerInfo currentSelectServerInfo = LoginUITask.GetCurrentSelectServerInfo();
					if (!LoginUITask.IsGMUser && currentSelectServerInfo != null && currentSelectServerInfo.m_isRefuseNewPlayer && GameManager.Instance != null)
					{
						global::Debug.LogError(string.Format("server {0} refuse new player.", currentSelectServerInfo.m_name));
						this.m_loginUIController.ShowMessage(StringTableId.StringTableId_ServerRefuseNewPlayer, 3, false);
						GameManager.Instance.Return2Login(true);
					}
					else
					{
						this.m_loginTaskState = LoginUITaskBase.LoginState.ReadyForCharacterUI;
						this.ShowCreateCharacterUI();
					}
				}
				this.EnableInput(true);
			};
			playerInfoInitNetTask.Start(null);
		}

		// Token: 0x06011A9C RID: 72348 RVA: 0x00493638 File Offset: 0x00491838
		protected override void OnPlayerInfoInitEnd()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPlayerInfoInitEnd_hotfix != null)
			{
				this.m_OnPlayerInfoInitEnd_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_loginTaskState = LoginUITaskBase.LoginState.ReadyForCharacterUI;
			if (LoginUITask.ShouldUsePDSDK)
			{
				if (this.m_isNewRole)
				{
					PDSDK.Instance.doSetExtData(LoginUITask.PDSDKGameRoleJsonString, "CreateRole");
				}
				PDSDK.Instance.StartGame(LoginUITask.PDSDKStartGameJsonString);
				StoreUITask.PDSDKRequestGoods();
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			LocalAccountConfig.Instance.SetFileName(LoginUITask.s_localConfigPath + "Config_" + projectLPlayerContext.GetUserId() + ".txt");
			LocalAccountConfig.Instance.Load();
			this.UpdateLocalConfigGMUser();
			LoginUITask.SetLocalPushNotifications();
			this.LauncheMainUI();
		}

		// Token: 0x06011A9D RID: 72349 RVA: 0x00493730 File Offset: 0x00491930
		private static string GetStartGameOrCreateRoleJsonString(string rolenameProperty)
		{
			JsonData jsonData = new JsonData();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext == null)
			{
				global::Debug.LogError("StartGameJsonString: Failed to get ProjectLPlayerContext");
				return string.Empty;
			}
			LoginUITask.ServerInfo currentSelectServerInfo = LoginUITask.GetCurrentSelectServerInfo();
			if (currentSelectServerInfo == null)
			{
				global::Debug.LogError("StartGameJsonString: Failed to GetCurrentSelectServerInfo");
				return string.Empty;
			}
			if (string.IsNullOrEmpty(currentSelectServerInfo.m_sdkPlatformUserID))
			{
				global::Debug.LogError("StartGameJsonString: si.m_sdkPlatformUserID is null.");
				return string.Empty;
			}
			if (string.IsNullOrEmpty(projectLPlayerContext.GetUserId()))
			{
				global::Debug.LogError("StartGameJsonString: pc.GetUserId() is null.");
				return string.Empty;
			}
			jsonData["RoleId"] = projectLPlayerContext.GetUserId();
			jsonData["GameUid"] = currentSelectServerInfo.m_sdkPlatformUserID;
			jsonData["RoleLevel"] = projectLPlayerContext.GetPlayerLevel().ToString();
			jsonData["ServerId"] = currentSelectServerInfo.m_channelId.ToString();
			jsonData["ServerName"] = currentSelectServerInfo.m_name;
			jsonData[rolenameProperty] = projectLPlayerContext.GetPlayerName();
			jsonData["Balance"] = projectLPlayerContext.GetCrystal();
			jsonData["PartyName"] = string.Empty;
			jsonData["VipLevel"] = projectLPlayerContext.GetPlayerVip();
			jsonData["PushInfo"] = string.Empty;
			jsonData["RoleCreateTime"] = UnixTimeStamp.From(projectLPlayerContext.GetCreateTimeUtc());
			return jsonData.ToJson();
		}

		// Token: 0x17003635 RID: 13877
		// (get) Token: 0x06011A9E RID: 72350 RVA: 0x004938D8 File Offset: 0x00491AD8
		public static string PDSDKStartGameJsonString
		{
			get
			{
				return LoginUITask.GetStartGameOrCreateRoleJsonString("GameName");
			}
		}

		// Token: 0x17003636 RID: 13878
		// (get) Token: 0x06011A9F RID: 72351 RVA: 0x004938E4 File Offset: 0x00491AE4
		public static string PDSDKGameRoleJsonString
		{
			get
			{
				return LoginUITask.GetStartGameOrCreateRoleJsonString("RoleName");
			}
		}

		// Token: 0x06011AA0 RID: 72352 RVA: 0x004938F0 File Offset: 0x00491AF0
		private void PlayerContext_OnGameServerNetworkError()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnGameServerNetworkError_hotfix != null)
			{
				this.m_PlayerContext_OnGameServerNetworkError_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LoginUITask.NetWorkTransactionTask_OnReLoginBySession(null);
		}

		// Token: 0x06011AA1 RID: 72353 RVA: 0x00493958 File Offset: 0x00491B58
		protected override void LauncheMainUI()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LauncheMainUI_hotfix != null)
			{
				this.m_LauncheMainUI_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_loginCommonUIController.FadeOut(0.5f, Color.black, delegate
			{
				base.Stop();
				GameObject gameObject = GameObject.Find("Launcher");
				if (gameObject != null)
				{
					MonoBehaviour componentInParent = gameObject.GetComponentInParent<MonoBehaviour>();
					if (componentInParent != null)
					{
						componentInParent.StartCoroutine(LoginUITask.Co_UnloadAssetsAndStartPreloadUITask());
					}
				}
			});
		}

		// Token: 0x06011AA2 RID: 72354 RVA: 0x004939DC File Offset: 0x00491BDC
		private static IEnumerator Co_UnloadAssetsAndStartPreloadUITask()
		{
			Utility.LogMemorySize("StartUITask CommonUITask");
			UIIntent intent = new UIIntent(typeof(CommonUITask).Name, null);
			UIManager.Instance.StartUITask(intent, false, false, null);
			ResourceManager.Instance.UnloadUnusedAssets();
			yield return Resources.UnloadUnusedAssets();
			yield break;
		}

		// Token: 0x06011AA3 RID: 72355 RVA: 0x004939F0 File Offset: 0x00491BF0
		protected override void OnWaitingMsgAckOutTime()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnWaitingMsgAckOutTime_hotfix != null)
			{
				this.m_OnWaitingMsgAckOutTime_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.LogError("LoginUITask OnWaitingMsgAckOutTime loginState=" + this.m_loginTaskState);
			this.EnableInput(true);
			this.m_loginUIController.ShowMessage(StringTableId.StringTableId_ConnectServerFailed, 3, true);
		}

		// Token: 0x06011AA4 RID: 72356 RVA: 0x00493A84 File Offset: 0x00491C84
		protected override void OnGameServerConnected()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGameServerConnected_hotfix != null)
			{
				this.m_OnGameServerConnected_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06011AA5 RID: 72357 RVA: 0x00493AE4 File Offset: 0x00491CE4
		protected override void OnGameServerNetworkError()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGameServerNetworkError_hotfix != null)
			{
				this.m_OnGameServerNetworkError_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_retryLoginByAuthTokenCount > 0)
			{
				return;
			}
			if (this.m_retryLoginBySessionTokenCount > 0)
			{
				return;
			}
			if (this.m_ignoreNetworkErrorOnce)
			{
				this.m_ignoreNetworkErrorOnce = false;
				return;
			}
			this.EnableInput(true);
			global::Debug.LogError("LoginUITask OnGameServerNetworkError");
			this.m_loginUIController.ShowMessage(StringTableId.StringTableId_ConnectServerFailed, 5, false);
		}

		// Token: 0x06011AA6 RID: 72358 RVA: 0x00493B94 File Offset: 0x00491D94
		private void ShowCreateCharacterUI()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowCreateCharacterUI_hotfix != null)
			{
				this.m_ShowCreateCharacterUI_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_loginCommonUIController.FadeOut(0.3f, Color.black, delegate
			{
				UIUtility.ActivateLayer(this.m_loginUIController, false);
				UIUtility.ActivateLayer(this.m_createCharaterUIController, true);
				this.m_createCharaterUIController.SetCharacterNameLimit(this.m_configDataLoader.ConfigableConstId_PlayerNameMaxLength);
				this.m_createCharaterUIController.SetCharacterName(string.Empty);
				this.m_createCharaterUIController.Open();
				this.m_loginCommonUIController.FadeIn(0.3f, Color.black, null);
			});
		}

		// Token: 0x06011AA7 RID: 72359 RVA: 0x00493C18 File Offset: 0x00491E18
		private void StartCreateCharacterReq()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartCreateCharacterReq_hotfix != null)
			{
				this.m_StartCreateCharacterReq_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.EnableInput(false);
			CreateCharacterNetTask createCharacterNetTask = new CreateCharacterNetTask(this.m_createCharaterUIController.GetCharacterName());
			createCharacterNetTask.EventOnStop += delegate(Task task)
			{
				CreateCharacterNetTask createCharacterNetTask2 = task as CreateCharacterNetTask;
				if (createCharacterNetTask2.Result == 0)
				{
					this.m_isNewRole = true;
					this.m_createCharaterUIController.Close(new Action(this.StartPlayerInfoInitReq));
				}
				else if (createCharacterNetTask2.Result != -99)
				{
					this.m_createCharaterUIController.ShowMessage(this.m_configDataLoader.UtilityGetErrorCodeString(createCharacterNetTask2.Result), 2);
				}
				this.EnableInput(true);
			};
			createCharacterNetTask.Start(null);
		}

		// Token: 0x06011AA8 RID: 72360 RVA: 0x00493CAC File Offset: 0x00491EAC
		public void SaveSessionTokenCache(string sessionToken)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SaveSessionTokenCacheString_hotfix != null)
			{
				this.m_SaveSessionTokenCacheString_hotfix.call(new object[]
				{
					this,
					sessionToken
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!string.IsNullOrEmpty(this.SessionTokenCacheFileName))
			{
				FileUtility.WriteText(this.SessionTokenCacheFileName, sessionToken);
			}
			else
			{
				global::Debug.LogError("SaveSessionTokenCache: Failed to save SessionToken, SessionTokenCacheFileName is null.");
			}
		}

		// Token: 0x06011AA9 RID: 72361 RVA: 0x00493D48 File Offset: 0x00491F48
		public string GetSessionTokenCache()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSessionTokenCache_hotfix != null)
			{
				return (string)this.m_GetSessionTokenCache_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!string.IsNullOrEmpty(this.SessionTokenCacheFileName) && FileUtility.IsFileExist(this.SessionTokenCacheFileName))
			{
				return FileUtility.ReadText(this.SessionTokenCacheFileName);
			}
			return string.Empty;
		}

		// Token: 0x17003637 RID: 13879
		// (get) Token: 0x06011AAA RID: 72362 RVA: 0x00493DE8 File Offset: 0x00491FE8
		private string SessionTokenCacheFileName
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_SessionTokenCacheFileName_hotfix != null)
				{
					return (string)this.m_get_SessionTokenCacheFileName_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				if (string.IsNullOrEmpty(LoginUITask.SessionAccountInfo))
				{
					global::Debug.Log("LoginUITask.SessionTokenCacheFileName.get SessionAccountInfo is null.");
					return string.Empty;
				}
				return string.Format("{0}/SessionToken.{1}.txt", Application.persistentDataPath, LoginUITask.SessionAccountInfo);
			}
		}

		// Token: 0x06011AAB RID: 72363 RVA: 0x00493E88 File Offset: 0x00492088
		public void ClearSessionTokenCache()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearSessionTokenCache_hotfix != null)
			{
				this.m_ClearSessionTokenCache_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_lastSessionToken = string.Empty;
			this.m_isClearSessionFailed = false;
			if (FileUtility.IsFileExist(this.SessionTokenCacheFileName))
			{
				this.m_isClearSessionFailed = !FileUtility.DeleteFile(this.SessionTokenCacheFileName);
			}
		}

		// Token: 0x06011AAC RID: 72364 RVA: 0x00493F20 File Offset: 0x00492120
		protected bool IsSessionTokenValid(string sessionToken)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsSessionTokenValidString_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsSessionTokenValidString_hotfix.call(new object[]
				{
					this,
					sessionToken
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (string.IsNullOrEmpty(sessionToken))
			{
				global::Debug.Log("IsSessionTokenValid: sessionToken is null.");
				return false;
			}
			if (SessionToken.GetSessionObject(sessionToken) == null)
			{
				global::Debug.Log("IsSessionTokenValid: sessionTokenObject is null.");
				return false;
			}
			return true;
		}

		// Token: 0x06011AAD RID: 72365 RVA: 0x00493FD0 File Offset: 0x004921D0
		private void SaveLoginInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SaveLoginInfo_hotfix != null)
			{
				this.m_SaveLoginInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LocalConfigData data = LocalConfig.Instance.Data;
			data.AccountName = this.m_loginUIController.GetAccountName();
			data.Password = this.m_loginUIController.GetPassword();
			LocalConfig.Instance.Save();
		}

		// Token: 0x06011AAE RID: 72366 RVA: 0x00494068 File Offset: 0x00492268
		private string CreateRandomName()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateRandomName_hotfix != null)
			{
				return (string)this.m_CreateRandomName_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_randomNameHead == null)
			{
				this.m_randomNameHead = new List<string>();
				foreach (KeyValuePair<int, ConfigDataRandomNameHead> keyValuePair in this.m_configDataLoader.GetAllConfigDataRandomNameHead())
				{
					this.m_randomNameHead.Add(keyValuePair.Value.Name);
				}
				this.m_randomNameMiddle = new List<string>();
				foreach (KeyValuePair<int, ConfigDataRandomNameMiddle> keyValuePair2 in this.m_configDataLoader.GetAllConfigDataRandomNameMiddle())
				{
					this.m_randomNameMiddle.Add(keyValuePair2.Value.Name);
				}
				this.m_randomNameTail = new List<string>();
				foreach (KeyValuePair<int, ConfigDataRandomNameTail> keyValuePair3 in this.m_configDataLoader.GetAllConfigDataRandomNameTail())
				{
					this.m_randomNameTail.Add(keyValuePair3.Value.Name);
				}
				this.m_randomNameRandom = new System.Random();
			}
			string text = string.Empty;
			if (this.m_randomNameHead.Count > 0)
			{
				text += this.m_randomNameHead[this.m_randomNameRandom.Next(this.m_randomNameHead.Count)];
			}
			if (this.m_randomNameMiddle.Count > 0)
			{
				text += this.m_randomNameMiddle[this.m_randomNameRandom.Next(this.m_randomNameMiddle.Count)];
			}
			if (this.m_randomNameTail.Count > 0)
			{
				text += this.m_randomNameTail[this.m_randomNameRandom.Next(this.m_randomNameTail.Count)];
			}
			return text;
		}

		// Token: 0x06011AAF RID: 72367 RVA: 0x004942E8 File Offset: 0x004924E8
		private void EnableInput(bool isEnable)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EnableInputBoolean_hotfix != null)
			{
				this.m_EnableInputBoolean_hotfix.call(new object[]
				{
					this,
					isEnable
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_loginCommonUIController.EnableInput(isEnable);
		}

		// Token: 0x06011AB0 RID: 72368 RVA: 0x00494364 File Offset: 0x00492564
		private void PDLogin()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PDLogin_hotfix != null)
			{
				this.m_PDLogin_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!LoginUITask.ShouldUsePDSDK)
			{
				this.EnableInput(true);
				return;
			}
			this.UpdateLoginPCClientButton();
			if (!PDSDK.IsInit)
			{
				PDSDK.Instance.Init();
				return;
			}
			if (this.m_loginCommonUIController == null)
			{
				this.EnableInput(true);
				return;
			}
			this.EnableInput(false);
			global::Debug.Log("LoginUITask.PDLogin()");
			this.m_authtoken = string.Empty;
			PDSDK.Instance.Login("menghuanmonizhan");
		}

		// Token: 0x06011AB1 RID: 72369 RVA: 0x00494438 File Offset: 0x00492638
		private void LoginUIController_OnLoginPCClient()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LoginUIController_OnLoginPCClient_hotfix != null)
			{
				this.m_LoginUIController_OnLoginPCClient_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!LoginUITask.ShouldUsePDSDK)
			{
				return;
			}
			PDSDK.Instance.doStartQRLogin("menghuanmonizhan");
		}

		// Token: 0x06011AB2 RID: 72370 RVA: 0x004944B4 File Offset: 0x004926B4
		public void PDSDK_OnQRLoginSuccess(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PDSDK_OnQRLoginSuccessString_hotfix != null)
			{
				this.m_PDSDK_OnQRLoginSuccessString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_loginUIController.ShowMessage(StringTableId.StringTableId_QRLogin_Success, 3, true);
		}

		// Token: 0x06011AB3 RID: 72371 RVA: 0x00494538 File Offset: 0x00492738
		public void PDSDK_OnQRLoginFailed(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PDSDK_OnQRLoginFailedString_hotfix != null)
			{
				this.m_PDSDK_OnQRLoginFailedString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_loginUIController.ShowMessage(StringTableId.StringTableId_QRLogin_Failed, 3, true);
		}

		// Token: 0x06011AB4 RID: 72372 RVA: 0x004945BC File Offset: 0x004927BC
		public void PDSDK_OnQRLoginCancel(string msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PDSDK_OnQRLoginCancelString_hotfix != null)
			{
				this.m_PDSDK_OnQRLoginCancelString_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_loginUIController.ShowMessage(StringTableId.StringTableId_QRLogin_Cancel, 3, true);
		}

		// Token: 0x06011AB5 RID: 72373 RVA: 0x00494640 File Offset: 0x00492840
		public void PDSK_OnLoginFailed()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PDSK_OnLoginFailed_hotfix != null)
			{
				this.m_PDSK_OnLoginFailed_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("LoginUITask.PDSDK_OnLoginFailed");
			this.m_loginUIController.ShowStartAnimation();
			this.EnableInput(true);
			this.UpdateLoginPCClientButton();
		}

		// Token: 0x06011AB6 RID: 72374 RVA: 0x004946C4 File Offset: 0x004928C4
		private void PDSDK_OnInitFailed()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PDSDK_OnInitFailed_hotfix != null)
			{
				this.m_PDSDK_OnInitFailed_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("LoginUITask.PDSDK_OnInitFailed");
			this.m_loginUIController.ShowStartAnimation();
			this.m_loginUIController.ShowMessage(StringTableId.StringTableId_Login_Login_Fail, 3, true);
			this.EnableInput(true);
		}

		// Token: 0x06011AB7 RID: 72375 RVA: 0x00494754 File Offset: 0x00492954
		private void PDSDK_OnInitSucess()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PDSDK_OnInitSucess_hotfix != null)
			{
				this.m_PDSDK_OnInitSucess_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("LoginUITask.PDSDK_OnInitSucess");
			this.PDLogin();
		}

		// Token: 0x06011AB8 RID: 72376 RVA: 0x004947C4 File Offset: 0x004929C4
		private void ClearSDKUserIDOfAllServer()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearSDKUserIDOfAllServer_hotfix != null)
			{
				this.m_ClearSDKUserIDOfAllServer_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (LoginUITask.ServerInfo serverInfo in LoginUITask.m_serverlist)
			{
				serverInfo.m_sdkPlatformUserID = string.Empty;
				serverInfo.m_sdkPlatformName = string.Empty;
			}
		}

		// Token: 0x06011AB9 RID: 72377 RVA: 0x00494884 File Offset: 0x00492A84
		public static void PDSDK_OnLogoutSuccess()
		{
			global::Debug.Log("LoginUITask.PDSDK_OnLogoutSuccess");
			LoginUITask findAInstance = LoginUITask.FindAInstance;
			if (findAInstance != null && findAInstance.State == Task.TaskState.Running)
			{
				findAInstance.UpdateLoginPCClientButton();
				if (!PDSDK.IsLogouting)
				{
					PDSDK.Instance.Login(string.Empty);
				}
				return;
			}
			LoginUITask.ReturnToLoginAndSwitchUser();
		}

		// Token: 0x06011ABA RID: 72378 RVA: 0x004948D8 File Offset: 0x00492AD8
		public static void PDSDK_OnSwitchUserSuccess(LoginSuccessMsg msg)
		{
			global::Debug.Log("LoginUITask.PDSDK_OnSwitchUserSuccess");
			LoginUITask findAInstance = LoginUITask.FindAInstance;
			if (findAInstance != null && findAInstance.State == Task.TaskState.Running)
			{
				findAInstance.PDSDK_OnLoginSuccess(msg);
				return;
			}
			LoginUITask.m_isReturnToLoginAndOnLoginSuccess = true;
			LoginUITask.m_onSwitchUserSuccessMsg = msg;
			GameManager.Instance.Return2Login(true);
		}

		// Token: 0x06011ABB RID: 72379 RVA: 0x00494928 File Offset: 0x00492B28
		public void PDSDK_OnLoginSuccess(LoginSuccessMsg msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PDSDK_OnLoginSuccessLoginSuccessMsg_hotfix != null)
			{
				this.m_PDSDK_OnLoginSuccessLoginSuccessMsg_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("LoginUITask.PDSDK_OnLoginSuccess");
			this.UpdateLoginPCClientButton();
			this.m_pdsdkLoginReturnData = msg.data;
			this.m_pdsdkLoginReturnOpcode = msg.opcode;
			this.m_pdsdkLoginReturnChannelID = msg.channel_id;
			this.m_pdsdkLoginReturnCustomParams = msg.customparams;
			this.ClearSDKUserIDOfAllServer();
			if (Application.platform == RuntimePlatform.WindowsPlayer)
			{
				this.DownloadServerListFile();
			}
			LoginUITask.ServerInfo currentSelectServerInfo = LoginUITask.GetCurrentSelectServerInfo();
			if (currentSelectServerInfo == null)
			{
				global::Debug.LogError("PDSDK_OnLoginSucess: server info is not ready yet.");
				this.EnableInput(true);
				return;
			}
			if (this.m_loginAgentCoroutine != null)
			{
				this.m_loginUIController.StopCoroutine(this.m_loginAgentCoroutine);
			}
			this.m_loginAgentCoroutine = this.m_loginUIController.StartCoroutine(this.LoginAgent(currentSelectServerInfo.m_loginAgentUrl, msg.data, msg.opcode, msg.channel_id, msg.customparams));
			this.m_loginUIController.ShowStartAnimation();
		}

		// Token: 0x06011ABC RID: 72380 RVA: 0x00494A74 File Offset: 0x00492C74
		private bool ParseLoginAgentAck(string ackText, ref string status, ref string platformName, ref string userId, ref string token, ref string error)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ParseLoginAgentAckStringString_String_String_String_String__hotfix != null)
			{
				return LuaDelegation.Lua_BlackJack_ProjectL_UI_LoginUITask_ParseLoginAgentAck_String_String_String_String_String_String(this, this.m_ParseLoginAgentAckStringString_String_String_String_String__hotfix, ackText, ref status, ref platformName, ref userId, ref token, ref error);
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool result;
			try
			{
				JsonData jsonData = JsonMapper.ToObject(ackText);
				status = jsonData["status"].ToString();
				if (status == "ok")
				{
					platformName = jsonData["platformName"].ToString();
					userId = jsonData["userId"].ToString();
					token = jsonData["token"].ToString();
				}
				else
				{
					error = jsonData["error"].ToString();
				}
				result = true;
			}
			catch (Exception ex)
			{
				global::Debug.LogError(string.Format("ParseLoginAgentAck: Json parse error: {0}", ex.Message));
				result = false;
			}
			return result;
		}

		// Token: 0x06011ABD RID: 72381 RVA: 0x00494B88 File Offset: 0x00492D88
		[DebuggerHidden]
		private IEnumerator LoginAgent(string svrUrl, string data, string opcode, string channel_id, string customparams)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LoginAgentStringStringStringStringString_hotfix != null)
			{
				return (IEnumerator)this.m_LoginAgentStringStringStringStringString_hotfix.call(new object[]
				{
					this,
					svrUrl,
					data,
					opcode,
					channel_id,
					customparams
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LoginUITask.<LoginAgent>c__Iterator7 <LoginAgent>c__Iterator = new LoginUITask.<LoginAgent>c__Iterator7();
			<LoginAgent>c__Iterator.svrUrl = svrUrl;
			<LoginAgent>c__Iterator.opcode = opcode;
			<LoginAgent>c__Iterator.channel_id = channel_id;
			<LoginAgent>c__Iterator.data = data;
			<LoginAgent>c__Iterator.$this = this;
			return <LoginAgent>c__Iterator;
		}

		// Token: 0x06011ABE RID: 72382 RVA: 0x00494C70 File Offset: 0x00492E70
		private void SetPlatformInfoToServerList(string loginAgentUrl, string platformName, string platformUserID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPlatformInfoToServerListStringStringString_hotfix != null)
			{
				this.m_SetPlatformInfoToServerListStringStringString_hotfix.call(new object[]
				{
					this,
					loginAgentUrl,
					platformName,
					platformUserID
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (LoginUITask.ServerInfo serverInfo in LoginUITask.m_serverlist)
			{
				if (serverInfo.m_loginAgentUrl == loginAgentUrl)
				{
					serverInfo.m_sdkPlatformName = platformName;
					serverInfo.m_sdkPlatformUserID = platformUserID;
				}
			}
		}

		// Token: 0x06011ABF RID: 72383 RVA: 0x00494D68 File Offset: 0x00492F68
		private void LoginUIController_OnOpenUserCenter()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LoginUIController_OnOpenUserCenter_hotfix != null)
			{
				this.m_LoginUIController_OnOpenUserCenter_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!LoginUITask.ShouldUsePDSDK)
			{
				return;
			}
			this.m_loginUIController.StartCoroutine(this.SwitchUserAccount());
		}

		// Token: 0x06011AC0 RID: 72384 RVA: 0x00494DE8 File Offset: 0x00492FE8
		[DebuggerHidden]
		private IEnumerator SwitchUserAccount()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SwitchUserAccount_hotfix != null)
			{
				return (IEnumerator)this.m_SwitchUserAccount_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LoginUITask.<SwitchUserAccount>c__Iterator8 <SwitchUserAccount>c__Iterator = new LoginUITask.<SwitchUserAccount>c__Iterator8();
			<SwitchUserAccount>c__Iterator.$this = this;
			return <SwitchUserAccount>c__Iterator;
		}

		// Token: 0x06011AC1 RID: 72385 RVA: 0x00494E64 File Offset: 0x00493064
		private void LoginUIController_OnAccountTextChanged(string text)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LoginUIController_OnAccountTextChangedString_hotfix != null)
			{
				this.m_LoginUIController_OnAccountTextChangedString_hotfix.call(new object[]
				{
					this,
					text
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.UpdateGMUserFlag(null);
		}

		// Token: 0x06011AC2 RID: 72386 RVA: 0x00494EDC File Offset: 0x004930DC
		private void LoginUIController_OnSaveServerConfig()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LoginUIController_OnSaveServerConfig_hotfix != null)
			{
				this.m_LoginUIController_OnSaveServerConfig_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SaveLoginInfo();
		}

		// Token: 0x06011AC3 RID: 72387 RVA: 0x00494F44 File Offset: 0x00493144
		private void LoginUIController_OnCloseAnnouncePanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LoginUIController_OnCloseAnnouncePanel_hotfix != null)
			{
				this.m_LoginUIController_OnCloseAnnouncePanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_loginUIController == null)
			{
				return;
			}
			this.m_loginUIController.ShowAnnouncePanel(false, delegate
			{
				LoginUITask.ServerInfo currentSelectServerInfo = LoginUITask.GetCurrentSelectServerInfo();
				if (currentSelectServerInfo != null && LoginUITask.ShouldUsePDSDK && !PDSDK.IsLogin)
				{
					this.PDLogin();
				}
				else
				{
					this.m_loginUIController.ShowStartAnimation();
				}
			});
		}

		// Token: 0x06011AC4 RID: 72388 RVA: 0x00494FD0 File Offset: 0x004931D0
		private void LoginUIController_OnOpenAnnouncePanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LoginUIController_OnOpenAnnouncePanel_hotfix != null)
			{
				this.m_LoginUIController_OnOpenAnnouncePanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_loginUIController == null)
			{
				return;
			}
			this.DownloadAnnounceFile(true);
			PDSDK.Instance.printGameEventLog("22", string.Empty);
		}

		// Token: 0x06011AC5 RID: 72389 RVA: 0x00495060 File Offset: 0x00493260
		private void LoginUIController_OnSelectServerClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LoginUIController_OnSelectServerClick_hotfix != null)
			{
				this.m_LoginUIController_OnSelectServerClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ShowServerListUI(true);
		}

		// Token: 0x06011AC6 RID: 72390 RVA: 0x004950C8 File Offset: 0x004932C8
		protected override bool IsNeedLoadStaticRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedLoadStaticRes_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedLoadStaticRes_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_curLoadingLayers.Count != 0 || base.IsNeedLoadStaticRes();
		}

		// Token: 0x06011AC7 RID: 72391 RVA: 0x0049514C File Offset: 0x0049334C
		protected override List<UITaskBase.LayerDesc> CollectAllStaticResDescForLoad()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectAllStaticResDescForLoad_hotfix != null)
			{
				return (List<UITaskBase.LayerDesc>)this.m_CollectAllStaticResDescForLoad_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curLoadingLayers.Count == 0)
			{
				return base.CollectAllStaticResDescForLoad();
			}
			List<UITaskBase.LayerDesc> result = new List<UITaskBase.LayerDesc>(this.m_curLoadingLayers);
			this.m_curLoadingLayers.Clear();
			return result;
		}

		// Token: 0x06011AC8 RID: 72392 RVA: 0x004951E8 File Offset: 0x004933E8
		private void ShowServerListUI(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowServerListUIBoolean_hotfix != null)
			{
				this.m_ShowServerListUIBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isShow)
			{
				PDSDK.Instance.printGameEventLog("23", string.Empty);
				this.DownloadServerListFile();
				if (this.m_serverListUIController == null)
				{
					this.m_curLoadingLayers.Add(this.m_layerDescArray[1]);
					base.StartUpdatePipeLine(null, false, false, true);
					return;
				}
				this.m_serverListUIController.Open();
			}
			else
			{
				this.m_serverListUIController.Close();
			}
		}

		// Token: 0x17003638 RID: 13880
		// (get) Token: 0x06011AC9 RID: 72393 RVA: 0x004952C4 File Offset: 0x004934C4
		public static string SessionAccountInfo
		{
			get
			{
				LoginUITask.ServerInfo currentSelectServerInfo = LoginUITask.GetCurrentSelectServerInfo();
				if (currentSelectServerInfo == null)
				{
					global::Debug.Log("LoginUITask.SessionAccountInfo.get GetCurrentSelectServerInfo is null.");
					return null;
				}
				if (!LoginUITask.ShouldUsePDSDK)
				{
					return string.Format("{0}_{1}", (LoginUITask.FindAInstance == null || !(LoginUITask.FindAInstance.m_loginUIController != null)) ? LoginUIController.m_accountName : LoginUITask.FindAInstance.m_loginUIController.GetAccountName(), currentSelectServerInfo.m_id);
				}
				if (string.IsNullOrEmpty(currentSelectServerInfo.m_sdkPlatformName))
				{
					global::Debug.Log("LoginUITask.SessionAccountInfo.get m_sdkPlatformName is null.");
					return null;
				}
				if (string.IsNullOrEmpty(currentSelectServerInfo.m_sdkPlatformUserID))
				{
					global::Debug.Log("LoginUITask.SessionAccountInfo.get m_sdkPlatformUserID is null.");
					return null;
				}
				return string.Format("{0}_{1}_{2}", currentSelectServerInfo.m_sdkPlatformName, currentSelectServerInfo.m_sdkPlatformUserID, currentSelectServerInfo.m_id);
			}
		}

		// Token: 0x06011ACA RID: 72394 RVA: 0x0049539C File Offset: 0x0049359C
		[DebuggerHidden]
		private IEnumerator KeepUpdatingServerList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_KeepUpdatingServerList_hotfix != null)
			{
				return (IEnumerator)this.m_KeepUpdatingServerList_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LoginUITask.<KeepUpdatingServerList>c__Iterator9 <KeepUpdatingServerList>c__Iterator = new LoginUITask.<KeepUpdatingServerList>c__Iterator9();
			<KeepUpdatingServerList>c__Iterator.$this = this;
			return <KeepUpdatingServerList>c__Iterator;
		}

		// Token: 0x06011ACB RID: 72395 RVA: 0x00495418 File Offset: 0x00493618
		private void LoginUIController_OnLogin()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LoginUIController_OnLogin_hotfix != null)
			{
				this.m_LoginUIController_OnLogin_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (LoginUITask.m_serverlist.Count == 0)
			{
				global::Debug.LogError("LoginUITask.LoginUIController_OnLogin serverlist is empty.");
				this.DownloadServerListFile();
				return;
			}
			LoginUITask.ServerInfo currentSelectServerInfo = LoginUITask.GetCurrentSelectServerInfo();
			if (currentSelectServerInfo == null)
			{
				return;
			}
			if (!LoginUITask.IsGMUser && currentSelectServerInfo.m_state == LoginUITask.ServerInfo.State.Maintain)
			{
				if (this.m_loginUIController != null)
				{
					this.GetSDKPlatformUserID(currentSelectServerInfo);
					IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
					this.m_loginUIController.StartCoroutine(DialogBox.Show(this.m_loginUIController.gameObject, "Assets/GameProject/RuntimeAssets/UI/Common_ABS/Prefab/DialogBox.prefab", (!string.IsNullOrEmpty(currentSelectServerInfo.m_serverOpenDateTime)) ? string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_ServerWillOpenAtTime), currentSelectServerInfo.m_name, currentSelectServerInfo.m_serverOpenDateTime) : string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Login_CanNotSelectMaintainServer), currentSelectServerInfo.m_name), configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_DialogBox_Ok), string.Empty, null));
				}
				return;
			}
			this.m_isNewRole = false;
			this.EnableInput(false);
			this.m_loginUIController.ShowMessage(StringTableId.StringTableId_Login_Logining, 0, true);
			if (LoginUITask.ShouldUsePDSDK)
			{
				PDSDK.Instance.printGameEventLog("25", string.Empty);
			}
			this.m_loginChannelId = currentSelectServerInfo.m_channelId;
			this.m_bornChannelId = currentSelectServerInfo.m_bornChannelId;
			string sessionTokenCache = this.GetSessionTokenCache();
			if (this.IsSessionTokenValid(sessionTokenCache) && !this.m_isClearSessionFailed)
			{
				global::Debug.Log(string.Format("LoginUITask.LoginUIController_OnLogin call StartSessionLogin() {0}", sessionTokenCache));
				this.m_lastSessionToken = sessionTokenCache;
				this.StartSessionLogin();
			}
			else
			{
				if (!string.IsNullOrEmpty(sessionTokenCache))
				{
					this.ClearSessionTokenCache();
				}
				if (LoginUITask.ShouldUsePDSDK)
				{
					if (string.IsNullOrEmpty(this.m_authtoken) || currentSelectServerInfo.m_loginAgentUrl != this.m_curLoginAgnetUrl || string.IsNullOrEmpty(LoginUITask.SessionAccountInfo))
					{
						global::Debug.Log(string.Format("LoginUITask.LoginUIController_OnLogin {0}{1}{2}", (!string.IsNullOrEmpty(this.m_authtoken)) ? string.Empty : "m_authtoken is null, ", (!(currentSelectServerInfo.m_loginAgentUrl != this.m_curLoginAgnetUrl)) ? string.Empty : "LoginAgnetUr changed, ", (!string.IsNullOrEmpty(LoginUITask.SessionAccountInfo)) ? string.Empty : "SessionAccountInfo is null"));
						this.PDLogin();
						return;
					}
				}
				else
				{
					this.m_authtoken = PlayerContextBase.CreateFakeAuthToken(this.m_loginUIController.GetAccountName(), this.m_loginUIController.GetPassword());
				}
				this.m_authLoginServerAddress = currentSelectServerInfo.m_ip;
				this.m_authLoginServerPort = currentSelectServerInfo.m_port;
				this.OnEnterGameConfirmed();
			}
		}

		// Token: 0x06011ACC RID: 72396 RVA: 0x00495700 File Offset: 0x00493900
		private void CreateCharacterUIController_OnCreate()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateCharacterUIController_OnCreate_hotfix != null)
			{
				this.m_CreateCharacterUIController_OnCreate_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string characterName = this.m_createCharaterUIController.GetCharacterName();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CheckPlayerName(characterName);
			if (num == 0)
			{
				this.StartCreateCharacterReq();
				PDSDK.Instance.printGameEventLog("27", string.Empty);
			}
			else
			{
				this.m_createCharaterUIController.ShowMessage(this.m_configDataLoader.UtilityGetErrorCodeString(num), 2);
				PDSDK.Instance.printGameEventLog("27", "{\"error\":\"Invalid name\"}");
			}
		}

		// Token: 0x06011ACD RID: 72397 RVA: 0x004957D8 File Offset: 0x004939D8
		private void CreateCharacterUIController_OnAutoName()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateCharacterUIController_OnAutoName_hotfix != null)
			{
				this.m_CreateCharacterUIController_OnAutoName_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_createCharaterUIController.SetCharacterName(this.CreateRandomName());
		}

		// Token: 0x06011ACE RID: 72398 RVA: 0x0049584C File Offset: 0x00493A4C
		public static void CheckServerMaitainState()
		{
			if (LoginUITask.FindAInstance != null && LoginUITask.FindAInstance.State == Task.TaskState.Running)
			{
				return;
			}
			if (CommonUIController.Instance == null || !CommonUIController.Instance.isActiveAndEnabled)
			{
				return;
			}
			CommonUIController.Instance.StartCoroutine(Util.DownloadHttpFile(DefaultServerAddress.ServerListURL, delegate(bool isSucceed, WWW www)
			{
				if (isSucceed)
				{
					LoginUITask.m_serverListText = www.text;
					LoginUITask.ParseServerListText(LoginUITask.m_serverListText);
					LoginUITask.ServerInfo currentSelectServerInfo = LoginUITask.GetCurrentSelectServerInfo();
					if (currentSelectServerInfo != null && currentSelectServerInfo.m_state == LoginUITask.ServerInfo.State.Maintain)
					{
						ClientConfigDataLoader clientConfigDataLoader = GameManager.Instance.ConfigDataLoader as ClientConfigDataLoader;
						ReloginUITask.Enable = false;
						CommonUIController.Instance.ShowDialogBox(clientConfigDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_ClientPauseReloginTimeout), delegate(DialogBoxResult ret)
						{
							GameManager.Instance.Return2Login(true);
							ReloginUITask.Enable = true;
						}, clientConfigDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_DialogBox_Ok), string.Empty);
					}
				}
			}, null));
		}

		// Token: 0x06011ACF RID: 72399 RVA: 0x004958C8 File Offset: 0x00493AC8
		private static void NetWorkTransactionTask_OnReLoginBySession(Action action)
		{
			global::Debug.Log("NetWorkTransactionTask_OnReLoginBySession");
			ReloginBySessionUIIntent intent = new ReloginBySessionUIIntent(typeof(ReloginUITask).Name, action, "WaitForReloginConfirm");
			UIManager.Instance.StartUITask(intent, true, false, null);
		}

		// Token: 0x17003639 RID: 13881
		// (get) Token: 0x06011AD0 RID: 72400 RVA: 0x0049590C File Offset: 0x00493B0C
		public static LoginUITask FindAInstance
		{
			get
			{
				return UIUtility.FindUITaskWithType(typeof(LoginUITask)) as LoginUITask;
			}
		}

		// Token: 0x06011AD1 RID: 72401 RVA: 0x00495924 File Offset: 0x00493B24
		private static void NetWorkTransactionTask_ReturnToLoginUI(bool isDataDirty)
		{
			global::Debug.Log("NetWorkTransactionTask_ReturnToLoginUI, isDataDirty " + isDataDirty);
			LoginUITask findAInstance = LoginUITask.FindAInstance;
			if (findAInstance != null)
			{
				findAInstance.ShowEnterGameUI();
				return;
			}
			UIIntent intent = new UIIntent(typeof(LoginUITask).Name, null);
			UIManager.Instance.StartUITask(intent, true, true, null);
		}

		// Token: 0x06011AD2 RID: 72402 RVA: 0x00495980 File Offset: 0x00493B80
		private static void ParseServerListText(string serverListText)
		{
			if (string.IsNullOrEmpty(serverListText))
			{
				global::Debug.LogError("SetServerList serverListText is null.");
				return;
			}
			string[] array = Array.ConvertAll<string, string>(serverListText.Split(new char[]
			{
				'\n'
			}), (string s) => s.Trim());
			bool flag = false;
			bool flag2 = false;
			foreach (string text in array)
			{
				if (!string.IsNullOrEmpty(text) && !text.StartsWith("//"))
				{
					string[] array3 = Array.ConvertAll<string, string>(text.Split(new char[]
					{
						','
					}), (string inputString) => inputString.Trim());
					if (array3.Length >= 2 && !(array3[0].ToLower() != "submittingversions"))
					{
						if (flag)
						{
							global::Debug.LogError("LoginUITask.ParseServerListText Error: Found more than 1 line for Submitting Versions.");
							break;
						}
						foreach (string a in array3)
						{
							if (a == Application.version)
							{
								flag2 = true;
							}
						}
						flag = true;
					}
				}
			}
			List<LoginUITask.ServerInfo> list = new List<LoginUITask.ServerInfo>(LoginUITask.m_serverlist);
			LoginUITask.m_serverlist.Clear();
			LoginUITask.m_totalRecommandWeight = 0f;
			LoginUITask.m_recommendServerIndex = -1;
			string[] array5 = array;
			for (int k = 0; k < array5.Length; k++)
			{
				string text2 = array5[k];
				if (!string.IsNullOrEmpty(text2) && !text2.StartsWith("//"))
				{
					string[] array6 = Array.ConvertAll<string, string>(text2.Split(new char[]
					{
						','
					}), (string inputString) => inputString.Trim());
					if (array6.Length <= 0 || !(array6[0].ToLower() == "submittingversions"))
					{
						if (array6.Length < 17)
						{
							global::Debug.LogError(string.Format("{0} 's segments count is less than 17.", text2));
						}
						else if (!(array6[12].ToLower() == "t" ^ flag2))
						{
							int id;
							if (!int.TryParse(array6[0], out id))
							{
								global::Debug.LogError(string.Format("{0} is not int.", array6[0]));
							}
							else if (LoginUITask.m_serverlist.Find((LoginUITask.ServerInfo i) => i.m_id == id) != null)
							{
								global::Debug.LogError(string.Format("{0} 's id has existed.", text2));
							}
							else
							{
								object obj = Enum.Parse(typeof(LoginUITask.ServerInfo.State), array6[2]);
								if (obj == null)
								{
									global::Debug.LogError(string.Format("{0} is not valid state.", array6[2]));
								}
								else
								{
									LoginUITask.ServerInfo.State state = (LoginUITask.ServerInfo.State)obj;
									bool isNew = array6[3].ToLower() == "new";
									int port;
									int channelId;
									int bornChannelId;
									float num;
									int realmID;
									if (!int.TryParse(array6[5], out port))
									{
										global::Debug.LogError(string.Format("{0} is not int.", array6[5]));
									}
									else if (!int.TryParse(array6[7], out channelId))
									{
										global::Debug.LogError(string.Format("{0} is not int.", array6[7]));
									}
									else if (!int.TryParse(array6[8], out bornChannelId))
									{
										global::Debug.LogError(string.Format("{0} is not int.", array6[8]));
									}
									else if (!float.TryParse(array6[9], out num))
									{
										global::Debug.LogError(string.Format("{0} is not float.", array6[9]));
									}
									else if (!int.TryParse(array6[11], out realmID))
									{
										global::Debug.LogError(string.Format("{0} is not int.", array6[11]));
									}
									else
									{
										LoginUITask.ServerInfo serverInfo = new LoginUITask.ServerInfo(LoginUITask.m_serverlist.Count, id, array6[1], state, isNew, array6[4], port, array6[6], channelId, bornChannelId, num, array6[10], realmID, array6[12].ToLower() == "t", LoginUITask.ParseServerOpenDateTime(array6[13]), array6[14].ToLower() == "t", array6[15]);
										foreach (LoginUITask.ServerInfo serverInfo2 in list)
										{
											if (serverInfo2.m_id == serverInfo.m_id && serverInfo2.m_ip == serverInfo.m_ip && serverInfo2.m_port == serverInfo.m_port && serverInfo2.m_loginAgentUrl == serverInfo.m_loginAgentUrl && serverInfo2.m_channelId == serverInfo.m_channelId)
											{
												serverInfo.m_sdkPlatformName = serverInfo2.m_sdkPlatformName;
												serverInfo.m_sdkPlatformUserID = serverInfo2.m_sdkPlatformUserID;
												break;
											}
										}
										LoginUITask.m_serverlist.Add(serverInfo);
										LoginUITask.m_totalRecommandWeight += num;
									}
								}
							}
						}
					}
				}
			}
			if (LoginUITask.FindAInstance != null)
			{
				LoginUITask.FindAInstance.UpdateServerList();
			}
		}

		// Token: 0x06011AD3 RID: 72403 RVA: 0x00495EC0 File Offset: 0x004940C0
		private void UpdateServerList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateServerList_hotfix != null)
			{
				this.m_UpdateServerList_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_serverListUIController != null)
			{
				LoginUITask.ServerInfo currentSelectServerInfo = LoginUITask.GetCurrentSelectServerInfo();
				this.m_serverListUIController.SetServerList(LoginUITask.m_serverlist, LoginUITask.GetRecentLoginServerList(), this.m_exsitCharsInfo, LoginUITask.m_curSelectServerID);
			}
			if (this.m_loginUIController != null)
			{
				this.m_loginUIController.SetServerInfo(LoginUITask.GetCurrentSelectServerInfo());
				this.m_loginUIController.EnablePDSDKLoginMode(LoginUITask.ShouldUsePDSDK);
			}
		}

		// Token: 0x06011AD4 RID: 72404 RVA: 0x00495F88 File Offset: 0x00494188
		private static string ParseServerOpenDateTime(string dt)
		{
			if (string.IsNullOrEmpty(dt))
			{
				return string.Empty;
			}
			string[] array = dt.Split(new char[]
			{
				'-'
			});
			if (array.Length != 5)
			{
				global::Debug.LogError(string.Format("LoginUITask.ParseServerOpenDateTime open time is not valid: {0}", dt));
				return string.Empty;
			}
			ClientConfigDataLoader clientConfigDataLoader = GameManager.Instance.ConfigDataLoader as ClientConfigDataLoader;
			return string.Format(clientConfigDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_ServerOpenTimeFormatString), new object[]
			{
				array[0],
				array[1],
				array[2],
				array[3],
				array[4]
			});
		}

		// Token: 0x06011AD5 RID: 72405 RVA: 0x0049601C File Offset: 0x0049421C
		private static void NetWorkTransactionTask_OnEventShowUIWaiting(bool show)
		{
			CommonUIController instance = CommonUIController.Instance;
			if (instance != null)
			{
				instance.ShowWaitingNet(show);
				return;
			}
			LoginUITask findAInstance = LoginUITask.FindAInstance;
			if (findAInstance != null)
			{
				findAInstance.ShowWaitingNet(show);
				return;
			}
		}

		// Token: 0x1700363A RID: 13882
		// (get) Token: 0x06011AD6 RID: 72406 RVA: 0x00496058 File Offset: 0x00494258
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

		// Token: 0x1700363B RID: 13883
		// (get) Token: 0x06011AD7 RID: 72407 RVA: 0x004960CC File Offset: 0x004942CC
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

		// Token: 0x1700363C RID: 13884
		// (get) Token: 0x06011AD8 RID: 72408 RVA: 0x00496140 File Offset: 0x00494340
		// (set) Token: 0x06011AD9 RID: 72409 RVA: 0x00496160 File Offset: 0x00494360
		[DoNotToLua]
		public new LoginUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new LoginUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06011ADA RID: 72410 RVA: 0x0049616C File Offset: 0x0049436C
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x06011ADB RID: 72411 RVA: 0x00496174 File Offset: 0x00494374
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x06011ADC RID: 72412 RVA: 0x0049617C File Offset: 0x0049437C
		private bool __callBase_IsSDKLogin()
		{
			return base.IsSDKLogin();
		}

		// Token: 0x06011ADD RID: 72413 RVA: 0x00496184 File Offset: 0x00494384
		private bool __callBase_IsEditorTestLogin()
		{
			return base.IsEditorTestLogin();
		}

		// Token: 0x06011ADE RID: 72414 RVA: 0x0049618C File Offset: 0x0049438C
		private void __callBase_StartInitSDK()
		{
			base.StartInitSDK();
		}

		// Token: 0x06011ADF RID: 72415 RVA: 0x00496194 File Offset: 0x00494394
		private void __callBase_OnSDKInitEnd(bool isSuccess)
		{
			base.OnSDKInitEnd(isSuccess);
		}

		// Token: 0x06011AE0 RID: 72416 RVA: 0x004961A0 File Offset: 0x004943A0
		private void __callBase_StartSDKLogin()
		{
			base.StartSDKLogin();
		}

		// Token: 0x06011AE1 RID: 72417 RVA: 0x004961A8 File Offset: 0x004943A8
		private void __callBase_OnSDKLoginEnd(bool isSuccess)
		{
			base.OnSDKLoginEnd(isSuccess);
		}

		// Token: 0x06011AE2 RID: 72418 RVA: 0x004961B4 File Offset: 0x004943B4
		private void __callBase_PostSDKLogin()
		{
			base.PostSDKLogin();
		}

		// Token: 0x06011AE3 RID: 72419 RVA: 0x004961BC File Offset: 0x004943BC
		private bool __callBase_IsNeedSelectServer()
		{
			return base.IsNeedSelectServer();
		}

		// Token: 0x06011AE4 RID: 72420 RVA: 0x004961C4 File Offset: 0x004943C4
		private void __callBase_LaunchServerListUI()
		{
			base.LaunchServerListUI();
		}

		// Token: 0x06011AE5 RID: 72421 RVA: 0x004961CC File Offset: 0x004943CC
		private IEnumerator __callBase_DownloadServerList(Action<bool> onEnd)
		{
			return base.DownloadServerList(onEnd);
		}

		// Token: 0x06011AE6 RID: 72422 RVA: 0x004961D8 File Offset: 0x004943D8
		private void __callBase_OnDownloadServerListEnd(bool isSuccess)
		{
			base.OnDownloadServerListEnd(isSuccess);
		}

		// Token: 0x06011AE7 RID: 72423 RVA: 0x004961E4 File Offset: 0x004943E4
		private void __callBase_ShowServerListUI()
		{
			base.ShowServerListUI();
		}

		// Token: 0x06011AE8 RID: 72424 RVA: 0x004961EC File Offset: 0x004943EC
		private void __callBase_OnGameServerConfirmed(string serverId)
		{
			base.OnGameServerConfirmed(serverId);
		}

		// Token: 0x06011AE9 RID: 72425 RVA: 0x004961F8 File Offset: 0x004943F8
		private void __callBase_InitServerCtxByServerID(string serverId)
		{
			base.InitServerCtxByServerID(serverId);
		}

		// Token: 0x06011AEA RID: 72426 RVA: 0x00496204 File Offset: 0x00494404
		private string __callBase_GetLastLoginedServerID()
		{
			return base.GetLastLoginedServerID();
		}

		// Token: 0x06011AEB RID: 72427 RVA: 0x0049620C File Offset: 0x0049440C
		private void __callBase_LaunchEnterGameUI()
		{
			base.LaunchEnterGameUI();
		}

		// Token: 0x06011AEC RID: 72428 RVA: 0x00496214 File Offset: 0x00494414
		private void __callBase_LaunchEnterGameUIWithGameSettingTokenAndServer()
		{
			base.LaunchEnterGameUIWithGameSettingTokenAndServer();
		}

		// Token: 0x06011AED RID: 72429 RVA: 0x0049621C File Offset: 0x0049441C
		private void __callBase_LaunchEnterGameUIWithUIInputAccountAndServer()
		{
			base.LaunchEnterGameUIWithUIInputAccountAndServer();
		}

		// Token: 0x06011AEE RID: 72430 RVA: 0x00496224 File Offset: 0x00494424
		private bool __callBase_LoadLastLoginWithUIInputInfo(out string loginUserId, out string authLoginServerAddress, out int authLoginServerPort)
		{
			return base.LoadLastLoginWithUIInputInfo(out loginUserId, out authLoginServerAddress, out authLoginServerPort);
		}

		// Token: 0x06011AEF RID: 72431 RVA: 0x00496230 File Offset: 0x00494430
		private IEnumerator __callBase_DownloadGameServerLoginAnnouncement(Action<bool> onEnd)
		{
			return base.DownloadGameServerLoginAnnouncement(onEnd);
		}

		// Token: 0x06011AF0 RID: 72432 RVA: 0x0049623C File Offset: 0x0049443C
		private void __callBase_OnDownloadGameServerLoginAnnouncementEnd(bool isSuccess)
		{
			base.OnDownloadGameServerLoginAnnouncementEnd(isSuccess);
		}

		// Token: 0x06011AF1 RID: 72433 RVA: 0x00496248 File Offset: 0x00494448
		private void __callBase_ShowGameServerLoginAnnouncementUI()
		{
			base.ShowGameServerLoginAnnouncementUI();
		}

		// Token: 0x06011AF2 RID: 72434 RVA: 0x00496250 File Offset: 0x00494450
		private void __callBase_ShowEnterGameUI()
		{
			base.ShowEnterGameUI();
		}

		// Token: 0x06011AF3 RID: 72435 RVA: 0x00496258 File Offset: 0x00494458
		private void __callBase_OnEnterGameConfirmed()
		{
			base.OnEnterGameConfirmed();
		}

		// Token: 0x06011AF4 RID: 72436 RVA: 0x00496260 File Offset: 0x00494460
		private IEnumerator __callBase_StartLoginAgentLogin(Action<int, string, string> onEnd)
		{
			return base.StartLoginAgentLogin(onEnd);
		}

		// Token: 0x06011AF5 RID: 72437 RVA: 0x0049626C File Offset: 0x0049446C
		private void __callBase_LoginAgentLoginEnd(int errCode, string loginUserId, string authToken)
		{
			base.LoginAgentLoginEnd(errCode, loginUserId, authToken);
		}

		// Token: 0x06011AF6 RID: 72438 RVA: 0x00496278 File Offset: 0x00494478
		private void __callBase_StartAuthLogin()
		{
			base.StartAuthLogin();
		}

		// Token: 0x06011AF7 RID: 72439 RVA: 0x00496280 File Offset: 0x00494480
		private void __callBase_StartSessionLogin()
		{
			base.StartSessionLogin();
		}

		// Token: 0x06011AF8 RID: 72440 RVA: 0x00496288 File Offset: 0x00494488
		private void __callBase_StartPlayerInfoInitReq()
		{
			base.StartPlayerInfoInitReq();
		}

		// Token: 0x06011AF9 RID: 72441 RVA: 0x00496290 File Offset: 0x00494490
		private void __callBase_LauncheMainUI()
		{
			base.LauncheMainUI();
		}

		// Token: 0x06011AFA RID: 72442 RVA: 0x00496298 File Offset: 0x00494498
		private void __callBase_OnWaitingMsgAckOutTime()
		{
			base.OnWaitingMsgAckOutTime();
		}

		// Token: 0x06011AFB RID: 72443 RVA: 0x004962A0 File Offset: 0x004944A0
		private void __callBase_StartWaitingMsgAck(float waitTime)
		{
			base.StartWaitingMsgAck(waitTime);
		}

		// Token: 0x06011AFC RID: 72444 RVA: 0x004962AC File Offset: 0x004944AC
		private void __callBase_StopWaitingMsgAck()
		{
			base.StopWaitingMsgAck();
		}

		// Token: 0x06011AFD RID: 72445 RVA: 0x004962B4 File Offset: 0x004944B4
		private void __callBase_ClearGameServerLoginState()
		{
			base.ClearGameServerLoginState();
		}

		// Token: 0x06011AFE RID: 72446 RVA: 0x004962BC File Offset: 0x004944BC
		private void __callBase_OnTick()
		{
			base.OnTick();
		}

		// Token: 0x06011AFF RID: 72447 RVA: 0x004962C4 File Offset: 0x004944C4
		private void __callBase_OnGameServerConnected()
		{
			base.OnGameServerConnected();
		}

		// Token: 0x06011B00 RID: 72448 RVA: 0x004962CC File Offset: 0x004944CC
		private void __callBase_OnGameServerDisconnected()
		{
			base.OnGameServerDisconnected();
		}

		// Token: 0x06011B01 RID: 72449 RVA: 0x004962D4 File Offset: 0x004944D4
		private void __callBase_OnGameServerNetworkError()
		{
			base.OnGameServerNetworkError();
		}

		// Token: 0x06011B02 RID: 72450 RVA: 0x004962DC File Offset: 0x004944DC
		private bool __callBase_OnLoginByAuthTokenAck(int ret, string sessionToken, bool needRedirect)
		{
			return base.OnLoginByAuthTokenAck(ret, sessionToken, needRedirect);
		}

		// Token: 0x06011B03 RID: 72451 RVA: 0x004962E8 File Offset: 0x004944E8
		private bool __callBase_OnLoginBySessionTokenAck(int ret)
		{
			return base.OnLoginBySessionTokenAck(ret);
		}

		// Token: 0x06011B04 RID: 72452 RVA: 0x004962F4 File Offset: 0x004944F4
		private void __callBase_OnConfigDataMD5InfoNtf(string fileNameWithErrorMD5, string localMD5, string serverMD5)
		{
			base.OnConfigDataMD5InfoNtf(fileNameWithErrorMD5, localMD5, serverMD5);
		}

		// Token: 0x06011B05 RID: 72453 RVA: 0x00496300 File Offset: 0x00494500
		private void __callBase_OnPlayerInfoInitEnd()
		{
			base.OnPlayerInfoInitEnd();
		}

		// Token: 0x06011B17 RID: 72471 RVA: 0x00496724 File Offset: 0x00494924
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
					this.m_ShowDialogBoxStringTableId_hotfix = (luaObj.RawGet("ShowDialogBox") as LuaFunction);
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_CollectAllDynamicResForLoad_hotfix = (luaObj.RawGet("CollectAllDynamicResForLoad") as LuaFunction);
					this.m_PostOnLoadAllResCompleted_hotfix = (luaObj.RawGet("PostOnLoadAllResCompleted") as LuaFunction);
					this.m_InitLayerStateOnLoadAllResCompleted_hotfix = (luaObj.RawGet("InitLayerStateOnLoadAllResCompleted") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_StartCoroutineKeepUpdatingServerList_hotfix = (luaObj.RawGet("StartCoroutineKeepUpdatingServerList") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_ServerListUIController_OnServerListClosedInt32_hotfix = (luaObj.RawGet("ServerListUIController_OnServerListClosed") as LuaFunction);
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_OnStop_hotfix = (luaObj.RawGet("OnStop") as LuaFunction);
					this.m_OnResumeUIIntent_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_OnTick_hotfix = (luaObj.RawGet("OnTick") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_PostUpdateView_hotfix = (luaObj.RawGet("PostUpdateView") as LuaFunction);
					this.m_StopEntryUITask_hotfix = (luaObj.RawGet("StopEntryUITask") as LuaFunction);
					this.m_DownloadServerListFile_hotfix = (luaObj.RawGet("DownloadServerListFile") as LuaFunction);
					this.m_DownloadAnnounceFileBoolean_hotfix = (luaObj.RawGet("DownloadAnnounceFile") as LuaFunction);
					this.m_DownloadGMUserIDs_hotfix = (luaObj.RawGet("DownloadGMUserIDs") as LuaFunction);
					this.m_ParseGMUserIDsTextString_hotfix = (luaObj.RawGet("ParseGMUserIDsText") as LuaFunction);
					this.m_UpdateLoginPCClientButton_hotfix = (luaObj.RawGet("UpdateLoginPCClientButton") as LuaFunction);
					this.m_IsSdkIDCanLoginPCClientString_hotfix = (luaObj.RawGet("IsSdkIDCanLoginPCClient") as LuaFunction);
					this.m_UpdateGMUserFlagServerInfo_hotfix = (luaObj.RawGet("UpdateGMUserFlag") as LuaFunction);
					this.m_UpdateLocalConfigGMUser_hotfix = (luaObj.RawGet("UpdateLocalConfigGMUser") as LuaFunction);
					this.m_GetSDKPlatformUserIDServerInfo_hotfix = (luaObj.RawGet("GetSDKPlatformUserID") as LuaFunction);
					this.m_ReqExistChars_hotfix = (luaObj.RawGet("ReqExistChars") as LuaFunction);
					this.m_ShowWaitingNetBoolean_hotfix = (luaObj.RawGet("ShowWaitingNet") as LuaFunction);
					this.m_LaunchEnterGameUIWithGameSettingTokenAndServer_hotfix = (luaObj.RawGet("LaunchEnterGameUIWithGameSettingTokenAndServer") as LuaFunction);
					this.m_LaunchEnterGameUIWithUIInputAccountAndServer_hotfix = (luaObj.RawGet("LaunchEnterGameUIWithUIInputAccountAndServer") as LuaFunction);
					this.m_DownloadGameServerLoginAnnouncementAction`1_hotfix = (luaObj.RawGet("DownloadGameServerLoginAnnouncement") as LuaFunction);
					this.m_ShowGameServerLoginAnnouncementUI_hotfix = (luaObj.RawGet("ShowGameServerLoginAnnouncementUI") as LuaFunction);
					this.m_ShowEnterGameUI_hotfix = (luaObj.RawGet("ShowEnterGameUI") as LuaFunction);
					this.m_StartLoginAgentLoginAction`3_hotfix = (luaObj.RawGet("StartLoginAgentLogin") as LuaFunction);
					this.m_OnLoginByAuthTokenAckInt32StringBoolean_hotfix = (luaObj.RawGet("OnLoginByAuthTokenAck") as LuaFunction);
					this.m_DelayEnableInputBooleanSingle_hotfix = (luaObj.RawGet("DelayEnableInput") as LuaFunction);
					this.m_ShowMessageStringTableIdInt32Boolean_hotfix = (luaObj.RawGet("ShowMessage") as LuaFunction);
					this.m_OnLoginBySessionTokenAckInt32_hotfix = (luaObj.RawGet("OnLoginBySessionTokenAck") as LuaFunction);
					this.m_LoginBySessionTokenAgain_hotfix = (luaObj.RawGet("LoginBySessionTokenAgain") as LuaFunction);
					this.m_StartPlayerInfoInitReq_hotfix = (luaObj.RawGet("StartPlayerInfoInitReq") as LuaFunction);
					this.m_OnPlayerInfoInitEnd_hotfix = (luaObj.RawGet("OnPlayerInfoInitEnd") as LuaFunction);
					this.m_PlayerContext_OnGameServerNetworkError_hotfix = (luaObj.RawGet("PlayerContext_OnGameServerNetworkError") as LuaFunction);
					this.m_LauncheMainUI_hotfix = (luaObj.RawGet("LauncheMainUI") as LuaFunction);
					this.m_OnWaitingMsgAckOutTime_hotfix = (luaObj.RawGet("OnWaitingMsgAckOutTime") as LuaFunction);
					this.m_OnGameServerConnected_hotfix = (luaObj.RawGet("OnGameServerConnected") as LuaFunction);
					this.m_OnGameServerNetworkError_hotfix = (luaObj.RawGet("OnGameServerNetworkError") as LuaFunction);
					this.m_ShowCreateCharacterUI_hotfix = (luaObj.RawGet("ShowCreateCharacterUI") as LuaFunction);
					this.m_StartCreateCharacterReq_hotfix = (luaObj.RawGet("StartCreateCharacterReq") as LuaFunction);
					this.m_SaveSessionTokenCacheString_hotfix = (luaObj.RawGet("SaveSessionTokenCache") as LuaFunction);
					this.m_GetSessionTokenCache_hotfix = (luaObj.RawGet("GetSessionTokenCache") as LuaFunction);
					this.m_get_SessionTokenCacheFileName_hotfix = (luaObj.RawGet("get_SessionTokenCacheFileName") as LuaFunction);
					this.m_ClearSessionTokenCache_hotfix = (luaObj.RawGet("ClearSessionTokenCache") as LuaFunction);
					this.m_IsSessionTokenValidString_hotfix = (luaObj.RawGet("IsSessionTokenValid") as LuaFunction);
					this.m_SaveLoginInfo_hotfix = (luaObj.RawGet("SaveLoginInfo") as LuaFunction);
					this.m_CreateRandomName_hotfix = (luaObj.RawGet("CreateRandomName") as LuaFunction);
					this.m_EnableInputBoolean_hotfix = (luaObj.RawGet("EnableInput") as LuaFunction);
					this.m_PDLogin_hotfix = (luaObj.RawGet("PDLogin") as LuaFunction);
					this.m_LoginUIController_OnLoginPCClient_hotfix = (luaObj.RawGet("LoginUIController_OnLoginPCClient") as LuaFunction);
					this.m_PDSDK_OnQRLoginSuccessString_hotfix = (luaObj.RawGet("PDSDK_OnQRLoginSuccess") as LuaFunction);
					this.m_PDSDK_OnQRLoginFailedString_hotfix = (luaObj.RawGet("PDSDK_OnQRLoginFailed") as LuaFunction);
					this.m_PDSDK_OnQRLoginCancelString_hotfix = (luaObj.RawGet("PDSDK_OnQRLoginCancel") as LuaFunction);
					this.m_PDSK_OnLoginFailed_hotfix = (luaObj.RawGet("PDSK_OnLoginFailed") as LuaFunction);
					this.m_PDSDK_OnInitFailed_hotfix = (luaObj.RawGet("PDSDK_OnInitFailed") as LuaFunction);
					this.m_PDSDK_OnInitSucess_hotfix = (luaObj.RawGet("PDSDK_OnInitSucess") as LuaFunction);
					this.m_ClearSDKUserIDOfAllServer_hotfix = (luaObj.RawGet("ClearSDKUserIDOfAllServer") as LuaFunction);
					this.m_PDSDK_OnLoginSuccessLoginSuccessMsg_hotfix = (luaObj.RawGet("PDSDK_OnLoginSuccess") as LuaFunction);
					this.m_ParseLoginAgentAckStringString_String_String_String_String__hotfix = (luaObj.RawGet("ParseLoginAgentAck") as LuaFunction);
					this.m_LoginAgentStringStringStringStringString_hotfix = (luaObj.RawGet("LoginAgent") as LuaFunction);
					this.m_SetPlatformInfoToServerListStringStringString_hotfix = (luaObj.RawGet("SetPlatformInfoToServerList") as LuaFunction);
					this.m_LoginUIController_OnOpenUserCenter_hotfix = (luaObj.RawGet("LoginUIController_OnOpenUserCenter") as LuaFunction);
					this.m_SwitchUserAccount_hotfix = (luaObj.RawGet("SwitchUserAccount") as LuaFunction);
					this.m_LoginUIController_OnAccountTextChangedString_hotfix = (luaObj.RawGet("LoginUIController_OnAccountTextChanged") as LuaFunction);
					this.m_LoginUIController_OnSaveServerConfig_hotfix = (luaObj.RawGet("LoginUIController_OnSaveServerConfig") as LuaFunction);
					this.m_LoginUIController_OnCloseAnnouncePanel_hotfix = (luaObj.RawGet("LoginUIController_OnCloseAnnouncePanel") as LuaFunction);
					this.m_LoginUIController_OnOpenAnnouncePanel_hotfix = (luaObj.RawGet("LoginUIController_OnOpenAnnouncePanel") as LuaFunction);
					this.m_LoginUIController_OnSelectServerClick_hotfix = (luaObj.RawGet("LoginUIController_OnSelectServerClick") as LuaFunction);
					this.m_IsNeedLoadStaticRes_hotfix = (luaObj.RawGet("IsNeedLoadStaticRes") as LuaFunction);
					this.m_CollectAllStaticResDescForLoad_hotfix = (luaObj.RawGet("CollectAllStaticResDescForLoad") as LuaFunction);
					this.m_ShowServerListUIBoolean_hotfix = (luaObj.RawGet("ShowServerListUI") as LuaFunction);
					this.m_KeepUpdatingServerList_hotfix = (luaObj.RawGet("KeepUpdatingServerList") as LuaFunction);
					this.m_LoginUIController_OnLogin_hotfix = (luaObj.RawGet("LoginUIController_OnLogin") as LuaFunction);
					this.m_CreateCharacterUIController_OnCreate_hotfix = (luaObj.RawGet("CreateCharacterUIController_OnCreate") as LuaFunction);
					this.m_CreateCharacterUIController_OnAutoName_hotfix = (luaObj.RawGet("CreateCharacterUIController_OnAutoName") as LuaFunction);
					this.m_UpdateServerList_hotfix = (luaObj.RawGet("UpdateServerList") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06011B18 RID: 72472 RVA: 0x0049703C File Offset: 0x0049523C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(LoginUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A0BC RID: 41148
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "LoginUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Login_ABS/Prefab/LoginUIPrefab.prefab",
				m_isUILayer = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "ServerListUIController",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Login_ABS/Prefab/ServerListUIPrefab.prefab",
				m_isUILayer = true,
				m_isLazyLoad = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "CreateCharacterUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Login_ABS/Prefab/CreateCharacterUIPrefab.prefab",
				m_isUILayer = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "LoginCommonUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Login_ABS/Prefab/LoginCommonUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400A0BD RID: 41149
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "LoginUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.LoginUIController"),
				m_ctrlName = "LoginUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "ServerListUIController",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.ServerListUIController"),
				m_ctrlName = "ServerListUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "CreateCharacterUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.CreateCharacterUIController"),
				m_ctrlName = "CreateCharacterUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "LoginCommonUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.LoginCommonUIController"),
				m_ctrlName = "LoginCommonUIController"
			}
		};

		// Token: 0x0400A0BE RID: 41150
		private Coroutine m_loginAgentCoroutine;

		// Token: 0x0400A0BF RID: 41151
		private LoginUIController m_loginUIController;

		// Token: 0x0400A0C0 RID: 41152
		private ServerListUIController m_serverListUIController;

		// Token: 0x0400A0C1 RID: 41153
		private CreateCharacterUIController m_createCharaterUIController;

		// Token: 0x0400A0C2 RID: 41154
		private LoginCommonUIController m_loginCommonUIController;

		// Token: 0x0400A0C3 RID: 41155
		private int m_retryLoginByAuthTokenCount;

		// Token: 0x0400A0C4 RID: 41156
		private int m_retryLoginBySessionTokenCount;

		// Token: 0x0400A0C5 RID: 41157
		private List<string> m_assets = new List<string>();

		// Token: 0x0400A0C6 RID: 41158
		private List<string> m_randomNameHead;

		// Token: 0x0400A0C7 RID: 41159
		private List<string> m_randomNameMiddle;

		// Token: 0x0400A0C8 RID: 41160
		private List<string> m_randomNameTail;

		// Token: 0x0400A0C9 RID: 41161
		private System.Random m_randomNameRandom;

		// Token: 0x0400A0CA RID: 41162
		private ClientConfigDataLoader m_configDataLoader;

		// Token: 0x0400A0CB RID: 41163
		private static bool s_isGlobalInitialized = false;

		// Token: 0x0400A0CC RID: 41164
		private static string s_localConfigPath;

		// Token: 0x0400A0CD RID: 41165
		private static string m_loadConfigFailedMessage;

		// Token: 0x0400A0CE RID: 41166
		private List<UITaskBase.LayerDesc> m_curLoadingLayers = new List<UITaskBase.LayerDesc>();

		// Token: 0x0400A0CF RID: 41167
		private static string m_serverListText;

		// Token: 0x0400A0D0 RID: 41168
		private static List<LoginUITask.ServerInfo> m_serverlist = new List<LoginUITask.ServerInfo>(50);

		// Token: 0x0400A0D1 RID: 41169
		private static bool m_isRecentLoginServerIDInServerlist = true;

		// Token: 0x0400A0D2 RID: 41170
		private static int m_curSelectServerID = -1;

		// Token: 0x0400A0D3 RID: 41171
		private static int m_recommendServerIndex = -1;

		// Token: 0x0400A0D4 RID: 41172
		private static float m_totalRecommandWeight = 0f;

		// Token: 0x0400A0D5 RID: 41173
		private List<LoginUITask.ExistCharInfo> m_exsitCharsInfo = new List<LoginUITask.ExistCharInfo>();

		// Token: 0x0400A0D6 RID: 41174
		private bool m_isOpeningUI = true;

		// Token: 0x0400A0D7 RID: 41175
		private string m_curLoginAgnetUrl = string.Empty;

		// Token: 0x0400A0D8 RID: 41176
		public const string CustomParams = "menghuanmonizhan";

		// Token: 0x0400A0D9 RID: 41177
		public const int m_messageDuration = 3;

		// Token: 0x0400A0DA RID: 41178
		private bool m_ignoreNetworkErrorOnce;

		// Token: 0x0400A0DB RID: 41179
		private Dictionary<string, HashSet<string>> m_gmUserIDs;

		// Token: 0x0400A0DC RID: 41180
		private static bool m_isGMUser = false;

		// Token: 0x0400A0DD RID: 41181
		private bool m_isGettingSDKPlatformUserID;

		// Token: 0x0400A0DE RID: 41182
		private string m_pdsdkLoginReturnData = string.Empty;

		// Token: 0x0400A0DF RID: 41183
		private string m_pdsdkLoginReturnOpcode = string.Empty;

		// Token: 0x0400A0E0 RID: 41184
		private string m_pdsdkLoginReturnChannelID = string.Empty;

		// Token: 0x0400A0E1 RID: 41185
		private string m_pdsdkLoginReturnCustomParams = string.Empty;

		// Token: 0x0400A0E2 RID: 41186
		private static bool m_isAutoRelogin = false;

		// Token: 0x0400A0E3 RID: 41187
		private static bool m_isReturnToLoginAndSwitchUser = false;

		// Token: 0x0400A0E4 RID: 41188
		private static bool m_isReturnToLoginAndOnLoginSuccess = false;

		// Token: 0x0400A0E5 RID: 41189
		private static LoginSuccessMsg m_onSwitchUserSuccessMsg;

		// Token: 0x0400A0E6 RID: 41190
		private bool m_isNewRole;

		// Token: 0x0400A0E7 RID: 41191
		private Coroutine m_downloadServerListCoroutine;

		// Token: 0x0400A0E8 RID: 41192
		private bool m_isClearSessionFailed;

		// Token: 0x0400A0E9 RID: 41193
		[DoNotToLua]
		private LoginUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400A0EA RID: 41194
		[CompilerGenerated]
		private static Action<Action> <>f__mg$cache0;

		// Token: 0x0400A0EB RID: 41195
		[CompilerGenerated]
		private static Action<bool> <>f__mg$cache1;

		// Token: 0x0400A0EC RID: 41196
		[CompilerGenerated]
		private static Action<bool> <>f__mg$cache2;

		// Token: 0x0400A0ED RID: 41197
		[CompilerGenerated]
		private static Action<bool> <>f__mg$cache3;

		// Token: 0x0400A0EF RID: 41199
		[CompilerGenerated]
		private static Action <>f__mg$cache4;

		// Token: 0x0400A0F0 RID: 41200
		[CompilerGenerated]
		private static Action<LoginSuccessMsg> <>f__mg$cache5;

		// Token: 0x0400A0F9 RID: 41209
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A0FA RID: 41210
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A0FB RID: 41211
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400A0FC RID: 41212
		private LuaFunction m_ShowDialogBoxStringTableId_hotfix;

		// Token: 0x0400A0FD RID: 41213
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x0400A0FE RID: 41214
		private LuaFunction m_CollectAllDynamicResForLoad_hotfix;

		// Token: 0x0400A0FF RID: 41215
		private LuaFunction m_PostOnLoadAllResCompleted_hotfix;

		// Token: 0x0400A100 RID: 41216
		private LuaFunction m_InitLayerStateOnLoadAllResCompleted_hotfix;

		// Token: 0x0400A101 RID: 41217
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400A102 RID: 41218
		private LuaFunction m_StartCoroutineKeepUpdatingServerList_hotfix;

		// Token: 0x0400A103 RID: 41219
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400A104 RID: 41220
		private LuaFunction m_ServerListUIController_OnServerListClosedInt32_hotfix;

		// Token: 0x0400A105 RID: 41221
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x0400A106 RID: 41222
		private LuaFunction m_OnStop_hotfix;

		// Token: 0x0400A107 RID: 41223
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x0400A108 RID: 41224
		private LuaFunction m_OnTick_hotfix;

		// Token: 0x0400A109 RID: 41225
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400A10A RID: 41226
		private LuaFunction m_PostUpdateView_hotfix;

		// Token: 0x0400A10B RID: 41227
		private LuaFunction m_StopEntryUITask_hotfix;

		// Token: 0x0400A10C RID: 41228
		private LuaFunction m_DownloadServerListFile_hotfix;

		// Token: 0x0400A10D RID: 41229
		private LuaFunction m_DownloadAnnounceFileBoolean_hotfix;

		// Token: 0x0400A10E RID: 41230
		private LuaFunction m_DownloadGMUserIDs_hotfix;

		// Token: 0x0400A10F RID: 41231
		private LuaFunction m_ParseGMUserIDsTextString_hotfix;

		// Token: 0x0400A110 RID: 41232
		private LuaFunction m_UpdateLoginPCClientButton_hotfix;

		// Token: 0x0400A111 RID: 41233
		private LuaFunction m_IsSdkIDCanLoginPCClientString_hotfix;

		// Token: 0x0400A112 RID: 41234
		private LuaFunction m_UpdateGMUserFlagServerInfo_hotfix;

		// Token: 0x0400A113 RID: 41235
		private LuaFunction m_UpdateLocalConfigGMUser_hotfix;

		// Token: 0x0400A114 RID: 41236
		private LuaFunction m_GetSDKPlatformUserIDServerInfo_hotfix;

		// Token: 0x0400A115 RID: 41237
		private LuaFunction m_ReqExistChars_hotfix;

		// Token: 0x0400A116 RID: 41238
		private LuaFunction m_ShowWaitingNetBoolean_hotfix;

		// Token: 0x0400A117 RID: 41239
		private LuaFunction m_LaunchEnterGameUIWithGameSettingTokenAndServer_hotfix;

		// Token: 0x0400A118 RID: 41240
		private LuaFunction m_LaunchEnterGameUIWithUIInputAccountAndServer_hotfix;

		// Token: 0x0400A119 RID: 41241
		private LuaFunction m_DownloadGameServerLoginAnnouncementAction;

		// Token: 0x0400A11A RID: 41242
		private LuaFunction m_ShowGameServerLoginAnnouncementUI_hotfix;

		// Token: 0x0400A11B RID: 41243
		private LuaFunction m_ShowEnterGameUI_hotfix;

		// Token: 0x0400A11C RID: 41244
		private LuaFunction m_StartLoginAgentLoginAction;

		// Token: 0x0400A11D RID: 41245
		private LuaFunction m_OnLoginByAuthTokenAckInt32StringBoolean_hotfix;

		// Token: 0x0400A11E RID: 41246
		private LuaFunction m_DelayEnableInputBooleanSingle_hotfix;

		// Token: 0x0400A11F RID: 41247
		private LuaFunction m_ShowMessageStringTableIdInt32Boolean_hotfix;

		// Token: 0x0400A120 RID: 41248
		private LuaFunction m_OnLoginBySessionTokenAckInt32_hotfix;

		// Token: 0x0400A121 RID: 41249
		private LuaFunction m_LoginBySessionTokenAgain_hotfix;

		// Token: 0x0400A122 RID: 41250
		private LuaFunction m_StartPlayerInfoInitReq_hotfix;

		// Token: 0x0400A123 RID: 41251
		private LuaFunction m_OnPlayerInfoInitEnd_hotfix;

		// Token: 0x0400A124 RID: 41252
		private LuaFunction m_PlayerContext_OnGameServerNetworkError_hotfix;

		// Token: 0x0400A125 RID: 41253
		private LuaFunction m_LauncheMainUI_hotfix;

		// Token: 0x0400A126 RID: 41254
		private LuaFunction m_OnWaitingMsgAckOutTime_hotfix;

		// Token: 0x0400A127 RID: 41255
		private LuaFunction m_OnGameServerConnected_hotfix;

		// Token: 0x0400A128 RID: 41256
		private LuaFunction m_OnGameServerNetworkError_hotfix;

		// Token: 0x0400A129 RID: 41257
		private LuaFunction m_ShowCreateCharacterUI_hotfix;

		// Token: 0x0400A12A RID: 41258
		private LuaFunction m_StartCreateCharacterReq_hotfix;

		// Token: 0x0400A12B RID: 41259
		private LuaFunction m_SaveSessionTokenCacheString_hotfix;

		// Token: 0x0400A12C RID: 41260
		private LuaFunction m_GetSessionTokenCache_hotfix;

		// Token: 0x0400A12D RID: 41261
		private LuaFunction m_get_SessionTokenCacheFileName_hotfix;

		// Token: 0x0400A12E RID: 41262
		private LuaFunction m_ClearSessionTokenCache_hotfix;

		// Token: 0x0400A12F RID: 41263
		private LuaFunction m_IsSessionTokenValidString_hotfix;

		// Token: 0x0400A130 RID: 41264
		private LuaFunction m_SaveLoginInfo_hotfix;

		// Token: 0x0400A131 RID: 41265
		private LuaFunction m_CreateRandomName_hotfix;

		// Token: 0x0400A132 RID: 41266
		private LuaFunction m_EnableInputBoolean_hotfix;

		// Token: 0x0400A133 RID: 41267
		private LuaFunction m_PDLogin_hotfix;

		// Token: 0x0400A134 RID: 41268
		private LuaFunction m_LoginUIController_OnLoginPCClient_hotfix;

		// Token: 0x0400A135 RID: 41269
		private LuaFunction m_PDSDK_OnQRLoginSuccessString_hotfix;

		// Token: 0x0400A136 RID: 41270
		private LuaFunction m_PDSDK_OnQRLoginFailedString_hotfix;

		// Token: 0x0400A137 RID: 41271
		private LuaFunction m_PDSDK_OnQRLoginCancelString_hotfix;

		// Token: 0x0400A138 RID: 41272
		private LuaFunction m_PDSK_OnLoginFailed_hotfix;

		// Token: 0x0400A139 RID: 41273
		private LuaFunction m_PDSDK_OnInitFailed_hotfix;

		// Token: 0x0400A13A RID: 41274
		private LuaFunction m_PDSDK_OnInitSucess_hotfix;

		// Token: 0x0400A13B RID: 41275
		private LuaFunction m_ClearSDKUserIDOfAllServer_hotfix;

		// Token: 0x0400A13C RID: 41276
		private LuaFunction m_PDSDK_OnLoginSuccessLoginSuccessMsg_hotfix;

		// Token: 0x0400A13D RID: 41277
		private LuaFunction m_ParseLoginAgentAckStringString_String_String_String_String__hotfix;

		// Token: 0x0400A13E RID: 41278
		private LuaFunction m_LoginAgentStringStringStringStringString_hotfix;

		// Token: 0x0400A13F RID: 41279
		private LuaFunction m_SetPlatformInfoToServerListStringStringString_hotfix;

		// Token: 0x0400A140 RID: 41280
		private LuaFunction m_LoginUIController_OnOpenUserCenter_hotfix;

		// Token: 0x0400A141 RID: 41281
		private LuaFunction m_SwitchUserAccount_hotfix;

		// Token: 0x0400A142 RID: 41282
		private LuaFunction m_LoginUIController_OnAccountTextChangedString_hotfix;

		// Token: 0x0400A143 RID: 41283
		private LuaFunction m_LoginUIController_OnSaveServerConfig_hotfix;

		// Token: 0x0400A144 RID: 41284
		private LuaFunction m_LoginUIController_OnCloseAnnouncePanel_hotfix;

		// Token: 0x0400A145 RID: 41285
		private LuaFunction m_LoginUIController_OnOpenAnnouncePanel_hotfix;

		// Token: 0x0400A146 RID: 41286
		private LuaFunction m_LoginUIController_OnSelectServerClick_hotfix;

		// Token: 0x0400A147 RID: 41287
		private LuaFunction m_IsNeedLoadStaticRes_hotfix;

		// Token: 0x0400A148 RID: 41288
		private LuaFunction m_CollectAllStaticResDescForLoad_hotfix;

		// Token: 0x0400A149 RID: 41289
		private LuaFunction m_ShowServerListUIBoolean_hotfix;

		// Token: 0x0400A14A RID: 41290
		private LuaFunction m_KeepUpdatingServerList_hotfix;

		// Token: 0x0400A14B RID: 41291
		private LuaFunction m_LoginUIController_OnLogin_hotfix;

		// Token: 0x0400A14C RID: 41292
		private LuaFunction m_CreateCharacterUIController_OnCreate_hotfix;

		// Token: 0x0400A14D RID: 41293
		private LuaFunction m_CreateCharacterUIController_OnAutoName_hotfix;

		// Token: 0x0400A14E RID: 41294
		private LuaFunction m_UpdateServerList_hotfix;

		// Token: 0x0400A14F RID: 41295
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400A150 RID: 41296
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000E3E RID: 3646
		[HotFix]
		public class ExistCharInfo
		{
			// Token: 0x06011B19 RID: 72473 RVA: 0x004970A4 File Offset: 0x004952A4
			public ExistCharInfo(string roleListURL, int channelId, int playerId, int headIcon, int lastLoginHours, string charName)
			{
				this.m_roleListURL = roleListURL;
				this.m_channelId = channelId;
				this.m_playerLevel = playerId;
				this.m_headIcon = headIcon;
				this.m_lastLoginHours = lastLoginHours;
				this.m_charName = charName;
			}

			// Token: 0x0400A151 RID: 41297
			public string m_roleListURL;

			// Token: 0x0400A152 RID: 41298
			public int m_channelId;

			// Token: 0x0400A153 RID: 41299
			public int m_playerLevel;

			// Token: 0x0400A154 RID: 41300
			public int m_headIcon;

			// Token: 0x0400A155 RID: 41301
			public int m_lastLoginHours;

			// Token: 0x0400A156 RID: 41302
			public string m_charName;
		}

		// Token: 0x02000E3F RID: 3647
		[HotFix]
		public class ServerInfo
		{
			// Token: 0x06011B1A RID: 72474 RVA: 0x004970DC File Offset: 0x004952DC
			public ServerInfo(int initialIndex, int id, string name, LoginUITask.ServerInfo.State state, bool isNew, string ip, int port, string loginAgentUrl, int channelId, int bornChannelId, float recommendWeight, string roleListURL, int realmID, bool isAppleReview, string serverOpenDateTime, bool isRefuseNewPlayer, string areaName)
			{
				this.m_initialIndex = initialIndex;
				this.m_id = id;
				this.m_name = name;
				this.m_state = state;
				this.m_isNew = isNew;
				this.m_ip = ip;
				this.m_port = port;
				this.m_loginAgentUrl = loginAgentUrl;
				this.m_channelId = channelId;
				this.m_bornChannelId = bornChannelId;
				this.m_recommendWeight = recommendWeight;
				this.m_roleListURL = roleListURL;
				this.m_realmID = realmID;
				this.m_isAppleReview = isAppleReview;
				this.m_serverOpenDateTime = serverOpenDateTime;
				this.m_isRefuseNewPlayer = isRefuseNewPlayer;
				this.m_areaName = areaName;
			}

			// Token: 0x06011B1B RID: 72475 RVA: 0x0049717C File Offset: 0x0049537C
			public override string ToString()
			{
				return string.Concat(new object[]
				{
					this.m_ip,
					this.m_port,
					this.m_loginAgentUrl,
					this.m_channelId,
					this.m_bornChannelId
				});
			}

			// Token: 0x0400A157 RID: 41303
			public int m_id;

			// Token: 0x0400A158 RID: 41304
			public string m_name;

			// Token: 0x0400A159 RID: 41305
			public LoginUITask.ServerInfo.State m_state = LoginUITask.ServerInfo.State.Normal;

			// Token: 0x0400A15A RID: 41306
			public bool m_isNew;

			// Token: 0x0400A15B RID: 41307
			public string m_ip;

			// Token: 0x0400A15C RID: 41308
			public int m_port;

			// Token: 0x0400A15D RID: 41309
			public string m_loginAgentUrl;

			// Token: 0x0400A15E RID: 41310
			public int m_channelId;

			// Token: 0x0400A15F RID: 41311
			public int m_bornChannelId;

			// Token: 0x0400A160 RID: 41312
			public float m_recommendWeight;

			// Token: 0x0400A161 RID: 41313
			public int m_initialIndex;

			// Token: 0x0400A162 RID: 41314
			public string m_sdkPlatformName;

			// Token: 0x0400A163 RID: 41315
			public string m_sdkPlatformUserID;

			// Token: 0x0400A164 RID: 41316
			public string m_roleListURL;

			// Token: 0x0400A165 RID: 41317
			public int m_realmID;

			// Token: 0x0400A166 RID: 41318
			public bool m_isAppleReview;

			// Token: 0x0400A167 RID: 41319
			public string m_serverOpenDateTime;

			// Token: 0x0400A168 RID: 41320
			public bool m_isRefuseNewPlayer;

			// Token: 0x0400A169 RID: 41321
			public string m_areaName;

			// Token: 0x02000E40 RID: 3648
			public enum State
			{
				// Token: 0x0400A16B RID: 41323
				Hot = 1,
				// Token: 0x0400A16C RID: 41324
				Crowded,
				// Token: 0x0400A16D RID: 41325
				Maintain,
				// Token: 0x0400A16E RID: 41326
				Normal
			}
		}

		// Token: 0x02000E41 RID: 3649
		public new class LuaExportHelper
		{
			// Token: 0x06011B1C RID: 72476 RVA: 0x004971D0 File Offset: 0x004953D0
			public LuaExportHelper(LoginUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06011B1D RID: 72477 RVA: 0x004971E0 File Offset: 0x004953E0
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x06011B1E RID: 72478 RVA: 0x004971F0 File Offset: 0x004953F0
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x06011B1F RID: 72479 RVA: 0x00497200 File Offset: 0x00495400
			public bool __callBase_IsSDKLogin()
			{
				return this.m_owner.__callBase_IsSDKLogin();
			}

			// Token: 0x06011B20 RID: 72480 RVA: 0x00497210 File Offset: 0x00495410
			public bool __callBase_IsEditorTestLogin()
			{
				return this.m_owner.__callBase_IsEditorTestLogin();
			}

			// Token: 0x06011B21 RID: 72481 RVA: 0x00497220 File Offset: 0x00495420
			public void __callBase_StartInitSDK()
			{
				this.m_owner.__callBase_StartInitSDK();
			}

			// Token: 0x06011B22 RID: 72482 RVA: 0x00497230 File Offset: 0x00495430
			public void __callBase_OnSDKInitEnd(bool isSuccess)
			{
				this.m_owner.__callBase_OnSDKInitEnd(isSuccess);
			}

			// Token: 0x06011B23 RID: 72483 RVA: 0x00497240 File Offset: 0x00495440
			public void __callBase_StartSDKLogin()
			{
				this.m_owner.__callBase_StartSDKLogin();
			}

			// Token: 0x06011B24 RID: 72484 RVA: 0x00497250 File Offset: 0x00495450
			public void __callBase_OnSDKLoginEnd(bool isSuccess)
			{
				this.m_owner.__callBase_OnSDKLoginEnd(isSuccess);
			}

			// Token: 0x06011B25 RID: 72485 RVA: 0x00497260 File Offset: 0x00495460
			public void __callBase_PostSDKLogin()
			{
				this.m_owner.__callBase_PostSDKLogin();
			}

			// Token: 0x06011B26 RID: 72486 RVA: 0x00497270 File Offset: 0x00495470
			public bool __callBase_IsNeedSelectServer()
			{
				return this.m_owner.__callBase_IsNeedSelectServer();
			}

			// Token: 0x06011B27 RID: 72487 RVA: 0x00497280 File Offset: 0x00495480
			public void __callBase_LaunchServerListUI()
			{
				this.m_owner.__callBase_LaunchServerListUI();
			}

			// Token: 0x06011B28 RID: 72488 RVA: 0x00497290 File Offset: 0x00495490
			public IEnumerator __callBase_DownloadServerList(Action<bool> onEnd)
			{
				return this.m_owner.__callBase_DownloadServerList(onEnd);
			}

			// Token: 0x06011B29 RID: 72489 RVA: 0x004972A0 File Offset: 0x004954A0
			public void __callBase_OnDownloadServerListEnd(bool isSuccess)
			{
				this.m_owner.__callBase_OnDownloadServerListEnd(isSuccess);
			}

			// Token: 0x06011B2A RID: 72490 RVA: 0x004972B0 File Offset: 0x004954B0
			public void __callBase_ShowServerListUI()
			{
				this.m_owner.__callBase_ShowServerListUI();
			}

			// Token: 0x06011B2B RID: 72491 RVA: 0x004972C0 File Offset: 0x004954C0
			public void __callBase_OnGameServerConfirmed(string serverId)
			{
				this.m_owner.__callBase_OnGameServerConfirmed(serverId);
			}

			// Token: 0x06011B2C RID: 72492 RVA: 0x004972D0 File Offset: 0x004954D0
			public void __callBase_InitServerCtxByServerID(string serverId)
			{
				this.m_owner.__callBase_InitServerCtxByServerID(serverId);
			}

			// Token: 0x06011B2D RID: 72493 RVA: 0x004972E0 File Offset: 0x004954E0
			public string __callBase_GetLastLoginedServerID()
			{
				return this.m_owner.__callBase_GetLastLoginedServerID();
			}

			// Token: 0x06011B2E RID: 72494 RVA: 0x004972F0 File Offset: 0x004954F0
			public void __callBase_LaunchEnterGameUI()
			{
				this.m_owner.__callBase_LaunchEnterGameUI();
			}

			// Token: 0x06011B2F RID: 72495 RVA: 0x00497300 File Offset: 0x00495500
			public void __callBase_LaunchEnterGameUIWithGameSettingTokenAndServer()
			{
				this.m_owner.__callBase_LaunchEnterGameUIWithGameSettingTokenAndServer();
			}

			// Token: 0x06011B30 RID: 72496 RVA: 0x00497310 File Offset: 0x00495510
			public void __callBase_LaunchEnterGameUIWithUIInputAccountAndServer()
			{
				this.m_owner.__callBase_LaunchEnterGameUIWithUIInputAccountAndServer();
			}

			// Token: 0x06011B31 RID: 72497 RVA: 0x00497320 File Offset: 0x00495520
			public bool __callBase_LoadLastLoginWithUIInputInfo(out string loginUserId, out string authLoginServerAddress, out int authLoginServerPort)
			{
				return this.m_owner.__callBase_LoadLastLoginWithUIInputInfo(out loginUserId, out authLoginServerAddress, out authLoginServerPort);
			}

			// Token: 0x06011B32 RID: 72498 RVA: 0x00497330 File Offset: 0x00495530
			public IEnumerator __callBase_DownloadGameServerLoginAnnouncement(Action<bool> onEnd)
			{
				return this.m_owner.__callBase_DownloadGameServerLoginAnnouncement(onEnd);
			}

			// Token: 0x06011B33 RID: 72499 RVA: 0x00497340 File Offset: 0x00495540
			public void __callBase_OnDownloadGameServerLoginAnnouncementEnd(bool isSuccess)
			{
				this.m_owner.__callBase_OnDownloadGameServerLoginAnnouncementEnd(isSuccess);
			}

			// Token: 0x06011B34 RID: 72500 RVA: 0x00497350 File Offset: 0x00495550
			public void __callBase_ShowGameServerLoginAnnouncementUI()
			{
				this.m_owner.__callBase_ShowGameServerLoginAnnouncementUI();
			}

			// Token: 0x06011B35 RID: 72501 RVA: 0x00497360 File Offset: 0x00495560
			public void __callBase_ShowEnterGameUI()
			{
				this.m_owner.__callBase_ShowEnterGameUI();
			}

			// Token: 0x06011B36 RID: 72502 RVA: 0x00497370 File Offset: 0x00495570
			public void __callBase_OnEnterGameConfirmed()
			{
				this.m_owner.__callBase_OnEnterGameConfirmed();
			}

			// Token: 0x06011B37 RID: 72503 RVA: 0x00497380 File Offset: 0x00495580
			public IEnumerator __callBase_StartLoginAgentLogin(Action<int, string, string> onEnd)
			{
				return this.m_owner.__callBase_StartLoginAgentLogin(onEnd);
			}

			// Token: 0x06011B38 RID: 72504 RVA: 0x00497390 File Offset: 0x00495590
			public void __callBase_LoginAgentLoginEnd(int errCode, string loginUserId, string authToken)
			{
				this.m_owner.__callBase_LoginAgentLoginEnd(errCode, loginUserId, authToken);
			}

			// Token: 0x06011B39 RID: 72505 RVA: 0x004973A0 File Offset: 0x004955A0
			public void __callBase_StartAuthLogin()
			{
				this.m_owner.__callBase_StartAuthLogin();
			}

			// Token: 0x06011B3A RID: 72506 RVA: 0x004973B0 File Offset: 0x004955B0
			public void __callBase_StartSessionLogin()
			{
				this.m_owner.__callBase_StartSessionLogin();
			}

			// Token: 0x06011B3B RID: 72507 RVA: 0x004973C0 File Offset: 0x004955C0
			public void __callBase_StartPlayerInfoInitReq()
			{
				this.m_owner.__callBase_StartPlayerInfoInitReq();
			}

			// Token: 0x06011B3C RID: 72508 RVA: 0x004973D0 File Offset: 0x004955D0
			public void __callBase_LauncheMainUI()
			{
				this.m_owner.__callBase_LauncheMainUI();
			}

			// Token: 0x06011B3D RID: 72509 RVA: 0x004973E0 File Offset: 0x004955E0
			public void __callBase_OnWaitingMsgAckOutTime()
			{
				this.m_owner.__callBase_OnWaitingMsgAckOutTime();
			}

			// Token: 0x06011B3E RID: 72510 RVA: 0x004973F0 File Offset: 0x004955F0
			public void __callBase_StartWaitingMsgAck(float waitTime)
			{
				this.m_owner.__callBase_StartWaitingMsgAck(waitTime);
			}

			// Token: 0x06011B3F RID: 72511 RVA: 0x00497400 File Offset: 0x00495600
			public void __callBase_StopWaitingMsgAck()
			{
				this.m_owner.__callBase_StopWaitingMsgAck();
			}

			// Token: 0x06011B40 RID: 72512 RVA: 0x00497410 File Offset: 0x00495610
			public void __callBase_ClearGameServerLoginState()
			{
				this.m_owner.__callBase_ClearGameServerLoginState();
			}

			// Token: 0x06011B41 RID: 72513 RVA: 0x00497420 File Offset: 0x00495620
			public void __callBase_OnTick()
			{
				this.m_owner.__callBase_OnTick();
			}

			// Token: 0x06011B42 RID: 72514 RVA: 0x00497430 File Offset: 0x00495630
			public void __callBase_OnGameServerConnected()
			{
				this.m_owner.__callBase_OnGameServerConnected();
			}

			// Token: 0x06011B43 RID: 72515 RVA: 0x00497440 File Offset: 0x00495640
			public void __callBase_OnGameServerDisconnected()
			{
				this.m_owner.__callBase_OnGameServerDisconnected();
			}

			// Token: 0x06011B44 RID: 72516 RVA: 0x00497450 File Offset: 0x00495650
			public void __callBase_OnGameServerNetworkError()
			{
				this.m_owner.__callBase_OnGameServerNetworkError();
			}

			// Token: 0x06011B45 RID: 72517 RVA: 0x00497460 File Offset: 0x00495660
			public bool __callBase_OnLoginByAuthTokenAck(int ret, string sessionToken, bool needRedirect)
			{
				return this.m_owner.__callBase_OnLoginByAuthTokenAck(ret, sessionToken, needRedirect);
			}

			// Token: 0x06011B46 RID: 72518 RVA: 0x00497470 File Offset: 0x00495670
			public bool __callBase_OnLoginBySessionTokenAck(int ret)
			{
				return this.m_owner.__callBase_OnLoginBySessionTokenAck(ret);
			}

			// Token: 0x06011B47 RID: 72519 RVA: 0x00497480 File Offset: 0x00495680
			public void __callBase_OnConfigDataMD5InfoNtf(string fileNameWithErrorMD5, string localMD5, string serverMD5)
			{
				this.m_owner.__callBase_OnConfigDataMD5InfoNtf(fileNameWithErrorMD5, localMD5, serverMD5);
			}

			// Token: 0x06011B48 RID: 72520 RVA: 0x00497490 File Offset: 0x00495690
			public void __callBase_OnPlayerInfoInitEnd()
			{
				this.m_owner.__callBase_OnPlayerInfoInitEnd();
			}

			// Token: 0x1700363D RID: 13885
			// (get) Token: 0x06011B49 RID: 72521 RVA: 0x004974A0 File Offset: 0x004956A0
			// (set) Token: 0x06011B4A RID: 72522 RVA: 0x004974B0 File Offset: 0x004956B0
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

			// Token: 0x1700363E RID: 13886
			// (get) Token: 0x06011B4B RID: 72523 RVA: 0x004974C0 File Offset: 0x004956C0
			// (set) Token: 0x06011B4C RID: 72524 RVA: 0x004974D0 File Offset: 0x004956D0
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

			// Token: 0x1700363F RID: 13887
			// (get) Token: 0x06011B4D RID: 72525 RVA: 0x004974E0 File Offset: 0x004956E0
			// (set) Token: 0x06011B4E RID: 72526 RVA: 0x004974F0 File Offset: 0x004956F0
			public Coroutine m_loginAgentCoroutine
			{
				get
				{
					return this.m_owner.m_loginAgentCoroutine;
				}
				set
				{
					this.m_owner.m_loginAgentCoroutine = value;
				}
			}

			// Token: 0x17003640 RID: 13888
			// (get) Token: 0x06011B4F RID: 72527 RVA: 0x00497500 File Offset: 0x00495700
			// (set) Token: 0x06011B50 RID: 72528 RVA: 0x00497510 File Offset: 0x00495710
			public LoginUIController m_loginUIController
			{
				get
				{
					return this.m_owner.m_loginUIController;
				}
				set
				{
					this.m_owner.m_loginUIController = value;
				}
			}

			// Token: 0x17003641 RID: 13889
			// (get) Token: 0x06011B51 RID: 72529 RVA: 0x00497520 File Offset: 0x00495720
			// (set) Token: 0x06011B52 RID: 72530 RVA: 0x00497530 File Offset: 0x00495730
			public ServerListUIController m_serverListUIController
			{
				get
				{
					return this.m_owner.m_serverListUIController;
				}
				set
				{
					this.m_owner.m_serverListUIController = value;
				}
			}

			// Token: 0x17003642 RID: 13890
			// (get) Token: 0x06011B53 RID: 72531 RVA: 0x00497540 File Offset: 0x00495740
			// (set) Token: 0x06011B54 RID: 72532 RVA: 0x00497550 File Offset: 0x00495750
			public CreateCharacterUIController m_createCharaterUIController
			{
				get
				{
					return this.m_owner.m_createCharaterUIController;
				}
				set
				{
					this.m_owner.m_createCharaterUIController = value;
				}
			}

			// Token: 0x17003643 RID: 13891
			// (get) Token: 0x06011B55 RID: 72533 RVA: 0x00497560 File Offset: 0x00495760
			// (set) Token: 0x06011B56 RID: 72534 RVA: 0x00497570 File Offset: 0x00495770
			public LoginCommonUIController m_loginCommonUIController
			{
				get
				{
					return this.m_owner.m_loginCommonUIController;
				}
				set
				{
					this.m_owner.m_loginCommonUIController = value;
				}
			}

			// Token: 0x17003644 RID: 13892
			// (get) Token: 0x06011B57 RID: 72535 RVA: 0x00497580 File Offset: 0x00495780
			// (set) Token: 0x06011B58 RID: 72536 RVA: 0x00497590 File Offset: 0x00495790
			public int m_retryLoginByAuthTokenCount
			{
				get
				{
					return this.m_owner.m_retryLoginByAuthTokenCount;
				}
				set
				{
					this.m_owner.m_retryLoginByAuthTokenCount = value;
				}
			}

			// Token: 0x17003645 RID: 13893
			// (get) Token: 0x06011B59 RID: 72537 RVA: 0x004975A0 File Offset: 0x004957A0
			// (set) Token: 0x06011B5A RID: 72538 RVA: 0x004975B0 File Offset: 0x004957B0
			public int m_retryLoginBySessionTokenCount
			{
				get
				{
					return this.m_owner.m_retryLoginBySessionTokenCount;
				}
				set
				{
					this.m_owner.m_retryLoginBySessionTokenCount = value;
				}
			}

			// Token: 0x17003646 RID: 13894
			// (get) Token: 0x06011B5B RID: 72539 RVA: 0x004975C0 File Offset: 0x004957C0
			// (set) Token: 0x06011B5C RID: 72540 RVA: 0x004975D0 File Offset: 0x004957D0
			public List<string> m_assets
			{
				get
				{
					return this.m_owner.m_assets;
				}
				set
				{
					this.m_owner.m_assets = value;
				}
			}

			// Token: 0x17003647 RID: 13895
			// (get) Token: 0x06011B5D RID: 72541 RVA: 0x004975E0 File Offset: 0x004957E0
			// (set) Token: 0x06011B5E RID: 72542 RVA: 0x004975F0 File Offset: 0x004957F0
			public List<string> m_randomNameHead
			{
				get
				{
					return this.m_owner.m_randomNameHead;
				}
				set
				{
					this.m_owner.m_randomNameHead = value;
				}
			}

			// Token: 0x17003648 RID: 13896
			// (get) Token: 0x06011B5F RID: 72543 RVA: 0x00497600 File Offset: 0x00495800
			// (set) Token: 0x06011B60 RID: 72544 RVA: 0x00497610 File Offset: 0x00495810
			public List<string> m_randomNameMiddle
			{
				get
				{
					return this.m_owner.m_randomNameMiddle;
				}
				set
				{
					this.m_owner.m_randomNameMiddle = value;
				}
			}

			// Token: 0x17003649 RID: 13897
			// (get) Token: 0x06011B61 RID: 72545 RVA: 0x00497620 File Offset: 0x00495820
			// (set) Token: 0x06011B62 RID: 72546 RVA: 0x00497630 File Offset: 0x00495830
			public List<string> m_randomNameTail
			{
				get
				{
					return this.m_owner.m_randomNameTail;
				}
				set
				{
					this.m_owner.m_randomNameTail = value;
				}
			}

			// Token: 0x1700364A RID: 13898
			// (get) Token: 0x06011B63 RID: 72547 RVA: 0x00497640 File Offset: 0x00495840
			// (set) Token: 0x06011B64 RID: 72548 RVA: 0x00497650 File Offset: 0x00495850
			public System.Random m_randomNameRandom
			{
				get
				{
					return this.m_owner.m_randomNameRandom;
				}
				set
				{
					this.m_owner.m_randomNameRandom = value;
				}
			}

			// Token: 0x1700364B RID: 13899
			// (get) Token: 0x06011B65 RID: 72549 RVA: 0x00497660 File Offset: 0x00495860
			// (set) Token: 0x06011B66 RID: 72550 RVA: 0x00497670 File Offset: 0x00495870
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

			// Token: 0x1700364C RID: 13900
			// (get) Token: 0x06011B67 RID: 72551 RVA: 0x00497680 File Offset: 0x00495880
			// (set) Token: 0x06011B68 RID: 72552 RVA: 0x00497688 File Offset: 0x00495888
			public static bool s_isGlobalInitialized
			{
				get
				{
					return LoginUITask.s_isGlobalInitialized;
				}
				set
				{
					LoginUITask.s_isGlobalInitialized = value;
				}
			}

			// Token: 0x1700364D RID: 13901
			// (get) Token: 0x06011B69 RID: 72553 RVA: 0x00497690 File Offset: 0x00495890
			// (set) Token: 0x06011B6A RID: 72554 RVA: 0x00497698 File Offset: 0x00495898
			public static string s_localConfigPath
			{
				get
				{
					return LoginUITask.s_localConfigPath;
				}
				set
				{
					LoginUITask.s_localConfigPath = value;
				}
			}

			// Token: 0x1700364E RID: 13902
			// (get) Token: 0x06011B6B RID: 72555 RVA: 0x004976A0 File Offset: 0x004958A0
			// (set) Token: 0x06011B6C RID: 72556 RVA: 0x004976A8 File Offset: 0x004958A8
			public static string m_loadConfigFailedMessage
			{
				get
				{
					return LoginUITask.m_loadConfigFailedMessage;
				}
				set
				{
					LoginUITask.m_loadConfigFailedMessage = value;
				}
			}

			// Token: 0x1700364F RID: 13903
			// (get) Token: 0x06011B6D RID: 72557 RVA: 0x004976B0 File Offset: 0x004958B0
			// (set) Token: 0x06011B6E RID: 72558 RVA: 0x004976C0 File Offset: 0x004958C0
			public List<UITaskBase.LayerDesc> m_curLoadingLayers
			{
				get
				{
					return this.m_owner.m_curLoadingLayers;
				}
				set
				{
					this.m_owner.m_curLoadingLayers = value;
				}
			}

			// Token: 0x17003650 RID: 13904
			// (get) Token: 0x06011B6F RID: 72559 RVA: 0x004976D0 File Offset: 0x004958D0
			// (set) Token: 0x06011B70 RID: 72560 RVA: 0x004976D8 File Offset: 0x004958D8
			public static string m_serverListText
			{
				get
				{
					return LoginUITask.m_serverListText;
				}
				set
				{
					LoginUITask.m_serverListText = value;
				}
			}

			// Token: 0x17003651 RID: 13905
			// (get) Token: 0x06011B71 RID: 72561 RVA: 0x004976E0 File Offset: 0x004958E0
			// (set) Token: 0x06011B72 RID: 72562 RVA: 0x004976E8 File Offset: 0x004958E8
			public static List<LoginUITask.ServerInfo> m_serverlist
			{
				get
				{
					return LoginUITask.m_serverlist;
				}
				set
				{
					LoginUITask.m_serverlist = value;
				}
			}

			// Token: 0x17003652 RID: 13906
			// (get) Token: 0x06011B73 RID: 72563 RVA: 0x004976F0 File Offset: 0x004958F0
			// (set) Token: 0x06011B74 RID: 72564 RVA: 0x004976F8 File Offset: 0x004958F8
			public static bool m_isRecentLoginServerIDInServerlist
			{
				get
				{
					return LoginUITask.m_isRecentLoginServerIDInServerlist;
				}
				set
				{
					LoginUITask.m_isRecentLoginServerIDInServerlist = value;
				}
			}

			// Token: 0x17003653 RID: 13907
			// (get) Token: 0x06011B75 RID: 72565 RVA: 0x00497700 File Offset: 0x00495900
			// (set) Token: 0x06011B76 RID: 72566 RVA: 0x00497708 File Offset: 0x00495908
			public static int m_curSelectServerID
			{
				get
				{
					return LoginUITask.m_curSelectServerID;
				}
				set
				{
					LoginUITask.m_curSelectServerID = value;
				}
			}

			// Token: 0x17003654 RID: 13908
			// (get) Token: 0x06011B77 RID: 72567 RVA: 0x00497710 File Offset: 0x00495910
			// (set) Token: 0x06011B78 RID: 72568 RVA: 0x00497718 File Offset: 0x00495918
			public static int m_recommendServerIndex
			{
				get
				{
					return LoginUITask.m_recommendServerIndex;
				}
				set
				{
					LoginUITask.m_recommendServerIndex = value;
				}
			}

			// Token: 0x17003655 RID: 13909
			// (get) Token: 0x06011B79 RID: 72569 RVA: 0x00497720 File Offset: 0x00495920
			// (set) Token: 0x06011B7A RID: 72570 RVA: 0x00497728 File Offset: 0x00495928
			public static float m_totalRecommandWeight
			{
				get
				{
					return LoginUITask.m_totalRecommandWeight;
				}
				set
				{
					LoginUITask.m_totalRecommandWeight = value;
				}
			}

			// Token: 0x17003656 RID: 13910
			// (get) Token: 0x06011B7B RID: 72571 RVA: 0x00497730 File Offset: 0x00495930
			// (set) Token: 0x06011B7C RID: 72572 RVA: 0x00497740 File Offset: 0x00495940
			public List<LoginUITask.ExistCharInfo> m_exsitCharsInfo
			{
				get
				{
					return this.m_owner.m_exsitCharsInfo;
				}
				set
				{
					this.m_owner.m_exsitCharsInfo = value;
				}
			}

			// Token: 0x17003657 RID: 13911
			// (get) Token: 0x06011B7D RID: 72573 RVA: 0x00497750 File Offset: 0x00495950
			// (set) Token: 0x06011B7E RID: 72574 RVA: 0x00497760 File Offset: 0x00495960
			public bool m_isOpeningUI
			{
				get
				{
					return this.m_owner.m_isOpeningUI;
				}
				set
				{
					this.m_owner.m_isOpeningUI = value;
				}
			}

			// Token: 0x17003658 RID: 13912
			// (get) Token: 0x06011B7F RID: 72575 RVA: 0x00497770 File Offset: 0x00495970
			// (set) Token: 0x06011B80 RID: 72576 RVA: 0x00497780 File Offset: 0x00495980
			public string m_curLoginAgnetUrl
			{
				get
				{
					return this.m_owner.m_curLoginAgnetUrl;
				}
				set
				{
					this.m_owner.m_curLoginAgnetUrl = value;
				}
			}

			// Token: 0x17003659 RID: 13913
			// (get) Token: 0x06011B81 RID: 72577 RVA: 0x00497790 File Offset: 0x00495990
			// (set) Token: 0x06011B82 RID: 72578 RVA: 0x004977A0 File Offset: 0x004959A0
			public bool m_ignoreNetworkErrorOnce
			{
				get
				{
					return this.m_owner.m_ignoreNetworkErrorOnce;
				}
				set
				{
					this.m_owner.m_ignoreNetworkErrorOnce = value;
				}
			}

			// Token: 0x1700365A RID: 13914
			// (get) Token: 0x06011B83 RID: 72579 RVA: 0x004977B0 File Offset: 0x004959B0
			// (set) Token: 0x06011B84 RID: 72580 RVA: 0x004977C0 File Offset: 0x004959C0
			public Dictionary<string, HashSet<string>> m_gmUserIDs
			{
				get
				{
					return this.m_owner.m_gmUserIDs;
				}
				set
				{
					this.m_owner.m_gmUserIDs = value;
				}
			}

			// Token: 0x1700365B RID: 13915
			// (get) Token: 0x06011B85 RID: 72581 RVA: 0x004977D0 File Offset: 0x004959D0
			// (set) Token: 0x06011B86 RID: 72582 RVA: 0x004977D8 File Offset: 0x004959D8
			public static bool m_isGMUser
			{
				get
				{
					return LoginUITask.m_isGMUser;
				}
				set
				{
					LoginUITask.m_isGMUser = value;
				}
			}

			// Token: 0x1700365C RID: 13916
			// (get) Token: 0x06011B87 RID: 72583 RVA: 0x004977E0 File Offset: 0x004959E0
			// (set) Token: 0x06011B88 RID: 72584 RVA: 0x004977F0 File Offset: 0x004959F0
			public bool m_isGettingSDKPlatformUserID
			{
				get
				{
					return this.m_owner.m_isGettingSDKPlatformUserID;
				}
				set
				{
					this.m_owner.m_isGettingSDKPlatformUserID = value;
				}
			}

			// Token: 0x1700365D RID: 13917
			// (get) Token: 0x06011B89 RID: 72585 RVA: 0x00497800 File Offset: 0x00495A00
			// (set) Token: 0x06011B8A RID: 72586 RVA: 0x00497810 File Offset: 0x00495A10
			public string m_pdsdkLoginReturnData
			{
				get
				{
					return this.m_owner.m_pdsdkLoginReturnData;
				}
				set
				{
					this.m_owner.m_pdsdkLoginReturnData = value;
				}
			}

			// Token: 0x1700365E RID: 13918
			// (get) Token: 0x06011B8B RID: 72587 RVA: 0x00497820 File Offset: 0x00495A20
			// (set) Token: 0x06011B8C RID: 72588 RVA: 0x00497830 File Offset: 0x00495A30
			public string m_pdsdkLoginReturnOpcode
			{
				get
				{
					return this.m_owner.m_pdsdkLoginReturnOpcode;
				}
				set
				{
					this.m_owner.m_pdsdkLoginReturnOpcode = value;
				}
			}

			// Token: 0x1700365F RID: 13919
			// (get) Token: 0x06011B8D RID: 72589 RVA: 0x00497840 File Offset: 0x00495A40
			// (set) Token: 0x06011B8E RID: 72590 RVA: 0x00497850 File Offset: 0x00495A50
			public string m_pdsdkLoginReturnChannelID
			{
				get
				{
					return this.m_owner.m_pdsdkLoginReturnChannelID;
				}
				set
				{
					this.m_owner.m_pdsdkLoginReturnChannelID = value;
				}
			}

			// Token: 0x17003660 RID: 13920
			// (get) Token: 0x06011B8F RID: 72591 RVA: 0x00497860 File Offset: 0x00495A60
			// (set) Token: 0x06011B90 RID: 72592 RVA: 0x00497870 File Offset: 0x00495A70
			public string m_pdsdkLoginReturnCustomParams
			{
				get
				{
					return this.m_owner.m_pdsdkLoginReturnCustomParams;
				}
				set
				{
					this.m_owner.m_pdsdkLoginReturnCustomParams = value;
				}
			}

			// Token: 0x17003661 RID: 13921
			// (get) Token: 0x06011B91 RID: 72593 RVA: 0x00497880 File Offset: 0x00495A80
			// (set) Token: 0x06011B92 RID: 72594 RVA: 0x00497888 File Offset: 0x00495A88
			public static bool m_isAutoRelogin
			{
				get
				{
					return LoginUITask.m_isAutoRelogin;
				}
				set
				{
					LoginUITask.m_isAutoRelogin = value;
				}
			}

			// Token: 0x17003662 RID: 13922
			// (get) Token: 0x06011B93 RID: 72595 RVA: 0x00497890 File Offset: 0x00495A90
			// (set) Token: 0x06011B94 RID: 72596 RVA: 0x00497898 File Offset: 0x00495A98
			public static bool m_isReturnToLoginAndSwitchUser
			{
				get
				{
					return LoginUITask.m_isReturnToLoginAndSwitchUser;
				}
				set
				{
					LoginUITask.m_isReturnToLoginAndSwitchUser = value;
				}
			}

			// Token: 0x17003663 RID: 13923
			// (get) Token: 0x06011B95 RID: 72597 RVA: 0x004978A0 File Offset: 0x00495AA0
			// (set) Token: 0x06011B96 RID: 72598 RVA: 0x004978A8 File Offset: 0x00495AA8
			public static bool m_isReturnToLoginAndOnLoginSuccess
			{
				get
				{
					return LoginUITask.m_isReturnToLoginAndOnLoginSuccess;
				}
				set
				{
					LoginUITask.m_isReturnToLoginAndOnLoginSuccess = value;
				}
			}

			// Token: 0x17003664 RID: 13924
			// (get) Token: 0x06011B97 RID: 72599 RVA: 0x004978B0 File Offset: 0x00495AB0
			// (set) Token: 0x06011B98 RID: 72600 RVA: 0x004978B8 File Offset: 0x00495AB8
			public static LoginSuccessMsg m_onSwitchUserSuccessMsg
			{
				get
				{
					return LoginUITask.m_onSwitchUserSuccessMsg;
				}
				set
				{
					LoginUITask.m_onSwitchUserSuccessMsg = value;
				}
			}

			// Token: 0x17003665 RID: 13925
			// (get) Token: 0x06011B99 RID: 72601 RVA: 0x004978C0 File Offset: 0x00495AC0
			// (set) Token: 0x06011B9A RID: 72602 RVA: 0x004978D0 File Offset: 0x00495AD0
			public bool m_isNewRole
			{
				get
				{
					return this.m_owner.m_isNewRole;
				}
				set
				{
					this.m_owner.m_isNewRole = value;
				}
			}

			// Token: 0x17003666 RID: 13926
			// (get) Token: 0x06011B9B RID: 72603 RVA: 0x004978E0 File Offset: 0x00495AE0
			// (set) Token: 0x06011B9C RID: 72604 RVA: 0x004978F0 File Offset: 0x00495AF0
			public Coroutine m_downloadServerListCoroutine
			{
				get
				{
					return this.m_owner.m_downloadServerListCoroutine;
				}
				set
				{
					this.m_owner.m_downloadServerListCoroutine = value;
				}
			}

			// Token: 0x17003667 RID: 13927
			// (get) Token: 0x06011B9D RID: 72605 RVA: 0x00497900 File Offset: 0x00495B00
			// (set) Token: 0x06011B9E RID: 72606 RVA: 0x00497910 File Offset: 0x00495B10
			public bool m_isClearSessionFailed
			{
				get
				{
					return this.m_owner.m_isClearSessionFailed;
				}
				set
				{
					this.m_owner.m_isClearSessionFailed = value;
				}
			}

			// Token: 0x17003668 RID: 13928
			// (get) Token: 0x06011B9F RID: 72607 RVA: 0x00497920 File Offset: 0x00495B20
			public static bool ShouldUsePDSDK
			{
				get
				{
					return LoginUITask.ShouldUsePDSDK;
				}
			}

			// Token: 0x17003669 RID: 13929
			// (get) Token: 0x06011BA0 RID: 72608 RVA: 0x00497928 File Offset: 0x00495B28
			public string SessionTokenCacheFileName
			{
				get
				{
					return this.m_owner.SessionTokenCacheFileName;
				}
			}

			// Token: 0x1700366A RID: 13930
			// (get) Token: 0x06011BA1 RID: 72609 RVA: 0x00497938 File Offset: 0x00495B38
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x1700366B RID: 13931
			// (get) Token: 0x06011BA2 RID: 72610 RVA: 0x00497948 File Offset: 0x00495B48
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x06011BA3 RID: 72611 RVA: 0x00497958 File Offset: 0x00495B58
			public static void InitializeGlobals()
			{
				LoginUITask.InitializeGlobals();
			}

			// Token: 0x06011BA4 RID: 72612 RVA: 0x00497960 File Offset: 0x00495B60
			public static void InitLocalConfig()
			{
				LoginUITask.InitLocalConfig();
			}

			// Token: 0x06011BA5 RID: 72613 RVA: 0x00497968 File Offset: 0x00495B68
			public static void LogSystemInfo()
			{
				LoginUITask.LogSystemInfo();
			}

			// Token: 0x06011BA6 RID: 72614 RVA: 0x00497970 File Offset: 0x00495B70
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x06011BA7 RID: 72615 RVA: 0x00497980 File Offset: 0x00495B80
			public List<string> CollectAllDynamicResForLoad()
			{
				return this.m_owner.CollectAllDynamicResForLoad();
			}

			// Token: 0x06011BA8 RID: 72616 RVA: 0x00497990 File Offset: 0x00495B90
			public void PostOnLoadAllResCompleted()
			{
				this.m_owner.PostOnLoadAllResCompleted();
			}

			// Token: 0x06011BA9 RID: 72617 RVA: 0x004979A0 File Offset: 0x00495BA0
			public void InitLayerStateOnLoadAllResCompleted()
			{
				this.m_owner.InitLayerStateOnLoadAllResCompleted();
			}

			// Token: 0x06011BAA RID: 72618 RVA: 0x004979B0 File Offset: 0x00495BB0
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x06011BAB RID: 72619 RVA: 0x004979C0 File Offset: 0x00495BC0
			public void StartCoroutineKeepUpdatingServerList()
			{
				this.m_owner.StartCoroutineKeepUpdatingServerList();
			}

			// Token: 0x06011BAC RID: 72620 RVA: 0x004979D0 File Offset: 0x00495BD0
			public static DateTime GetPushNotificationTime(ConfigDataDailyPushNotification cfg)
			{
				return LoginUITask.GetPushNotificationTime(cfg);
			}

			// Token: 0x06011BAD RID: 72621 RVA: 0x004979D8 File Offset: 0x00495BD8
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x06011BAE RID: 72622 RVA: 0x004979E8 File Offset: 0x00495BE8
			public static List<LoginUITask.ServerInfo> GetRecentLoginServerList()
			{
				return LoginUITask.GetRecentLoginServerList();
			}

			// Token: 0x06011BAF RID: 72623 RVA: 0x004979F0 File Offset: 0x00495BF0
			public void ServerListUIController_OnServerListClosed(int selectedServerID)
			{
				this.m_owner.ServerListUIController_OnServerListClosed(selectedServerID);
			}

			// Token: 0x06011BB0 RID: 72624 RVA: 0x00497A00 File Offset: 0x00495C00
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x06011BB1 RID: 72625 RVA: 0x00497A10 File Offset: 0x00495C10
			public void OnStop()
			{
				this.m_owner.OnStop();
			}

			// Token: 0x06011BB2 RID: 72626 RVA: 0x00497A20 File Offset: 0x00495C20
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x06011BB3 RID: 72627 RVA: 0x00497A30 File Offset: 0x00495C30
			public void OnTick()
			{
				this.m_owner.OnTick();
			}

			// Token: 0x06011BB4 RID: 72628 RVA: 0x00497A40 File Offset: 0x00495C40
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x06011BB5 RID: 72629 RVA: 0x00497A50 File Offset: 0x00495C50
			public void PostUpdateView()
			{
				this.m_owner.PostUpdateView();
			}

			// Token: 0x06011BB6 RID: 72630 RVA: 0x00497A60 File Offset: 0x00495C60
			public void StopEntryUITask()
			{
				this.m_owner.StopEntryUITask();
			}

			// Token: 0x06011BB7 RID: 72631 RVA: 0x00497A70 File Offset: 0x00495C70
			public void DownloadServerListFile()
			{
				this.m_owner.DownloadServerListFile();
			}

			// Token: 0x06011BB8 RID: 72632 RVA: 0x00497A80 File Offset: 0x00495C80
			public void DownloadAnnounceFile(bool isShow)
			{
				this.m_owner.DownloadAnnounceFile(isShow);
			}

			// Token: 0x06011BB9 RID: 72633 RVA: 0x00497A90 File Offset: 0x00495C90
			public void DownloadGMUserIDs()
			{
				this.m_owner.DownloadGMUserIDs();
			}

			// Token: 0x06011BBA RID: 72634 RVA: 0x00497AA0 File Offset: 0x00495CA0
			public void ParseGMUserIDsText(string text)
			{
				this.m_owner.ParseGMUserIDsText(text);
			}

			// Token: 0x06011BBB RID: 72635 RVA: 0x00497AB0 File Offset: 0x00495CB0
			public bool IsSdkIDCanLoginPCClient(string sdkChannelID)
			{
				return this.m_owner.IsSdkIDCanLoginPCClient(sdkChannelID);
			}

			// Token: 0x06011BBC RID: 72636 RVA: 0x00497AC0 File Offset: 0x00495CC0
			public void UpdateLocalConfigGMUser()
			{
				this.m_owner.UpdateLocalConfigGMUser();
			}

			// Token: 0x06011BBD RID: 72637 RVA: 0x00497AD0 File Offset: 0x00495CD0
			public void ReqExistChars()
			{
				this.m_owner.ReqExistChars();
			}

			// Token: 0x06011BBE RID: 72638 RVA: 0x00497AE0 File Offset: 0x00495CE0
			public void LaunchEnterGameUIWithGameSettingTokenAndServer()
			{
				this.m_owner.LaunchEnterGameUIWithGameSettingTokenAndServer();
			}

			// Token: 0x06011BBF RID: 72639 RVA: 0x00497AF0 File Offset: 0x00495CF0
			public void LaunchEnterGameUIWithUIInputAccountAndServer()
			{
				this.m_owner.LaunchEnterGameUIWithUIInputAccountAndServer();
			}

			// Token: 0x06011BC0 RID: 72640 RVA: 0x00497B00 File Offset: 0x00495D00
			public IEnumerator DownloadGameServerLoginAnnouncement(Action<bool> onEnd)
			{
				return this.m_owner.DownloadGameServerLoginAnnouncement(onEnd);
			}

			// Token: 0x06011BC1 RID: 72641 RVA: 0x00497B10 File Offset: 0x00495D10
			public void ShowGameServerLoginAnnouncementUI()
			{
				this.m_owner.ShowGameServerLoginAnnouncementUI();
			}

			// Token: 0x06011BC2 RID: 72642 RVA: 0x00497B20 File Offset: 0x00495D20
			public void ShowEnterGameUI()
			{
				this.m_owner.ShowEnterGameUI();
			}

			// Token: 0x06011BC3 RID: 72643 RVA: 0x00497B30 File Offset: 0x00495D30
			public IEnumerator StartLoginAgentLogin(Action<int, string, string> onEnd)
			{
				return this.m_owner.StartLoginAgentLogin(onEnd);
			}

			// Token: 0x06011BC4 RID: 72644 RVA: 0x00497B40 File Offset: 0x00495D40
			public bool OnLoginByAuthTokenAck(int ret, string sessionToken, bool needRedirect)
			{
				return this.m_owner.OnLoginByAuthTokenAck(ret, sessionToken, needRedirect);
			}

			// Token: 0x06011BC5 RID: 72645 RVA: 0x00497B50 File Offset: 0x00495D50
			public IEnumerator DelayEnableInput(bool isEnable, float delaySeconds)
			{
				return this.m_owner.DelayEnableInput(isEnable, delaySeconds);
			}

			// Token: 0x06011BC6 RID: 72646 RVA: 0x00497B60 File Offset: 0x00495D60
			public bool OnLoginBySessionTokenAck(int ret)
			{
				return this.m_owner.OnLoginBySessionTokenAck(ret);
			}

			// Token: 0x06011BC7 RID: 72647 RVA: 0x00497B70 File Offset: 0x00495D70
			public IEnumerator LoginBySessionTokenAgain()
			{
				return this.m_owner.LoginBySessionTokenAgain();
			}

			// Token: 0x06011BC8 RID: 72648 RVA: 0x00497B80 File Offset: 0x00495D80
			public void StartPlayerInfoInitReq()
			{
				this.m_owner.StartPlayerInfoInitReq();
			}

			// Token: 0x06011BC9 RID: 72649 RVA: 0x00497B90 File Offset: 0x00495D90
			public void OnPlayerInfoInitEnd()
			{
				this.m_owner.OnPlayerInfoInitEnd();
			}

			// Token: 0x06011BCA RID: 72650 RVA: 0x00497BA0 File Offset: 0x00495DA0
			public static string GetStartGameOrCreateRoleJsonString(string rolenameProperty)
			{
				return LoginUITask.GetStartGameOrCreateRoleJsonString(rolenameProperty);
			}

			// Token: 0x06011BCB RID: 72651 RVA: 0x00497BA8 File Offset: 0x00495DA8
			public void PlayerContext_OnGameServerNetworkError()
			{
				this.m_owner.PlayerContext_OnGameServerNetworkError();
			}

			// Token: 0x06011BCC RID: 72652 RVA: 0x00497BB8 File Offset: 0x00495DB8
			public void LauncheMainUI()
			{
				this.m_owner.LauncheMainUI();
			}

			// Token: 0x06011BCD RID: 72653 RVA: 0x00497BC8 File Offset: 0x00495DC8
			public static IEnumerator Co_UnloadAssetsAndStartPreloadUITask()
			{
				return LoginUITask.Co_UnloadAssetsAndStartPreloadUITask();
			}

			// Token: 0x06011BCE RID: 72654 RVA: 0x00497BD0 File Offset: 0x00495DD0
			public void OnWaitingMsgAckOutTime()
			{
				this.m_owner.OnWaitingMsgAckOutTime();
			}

			// Token: 0x06011BCF RID: 72655 RVA: 0x00497BE0 File Offset: 0x00495DE0
			public void OnGameServerConnected()
			{
				this.m_owner.OnGameServerConnected();
			}

			// Token: 0x06011BD0 RID: 72656 RVA: 0x00497BF0 File Offset: 0x00495DF0
			public void OnGameServerNetworkError()
			{
				this.m_owner.OnGameServerNetworkError();
			}

			// Token: 0x06011BD1 RID: 72657 RVA: 0x00497C00 File Offset: 0x00495E00
			public void ShowCreateCharacterUI()
			{
				this.m_owner.ShowCreateCharacterUI();
			}

			// Token: 0x06011BD2 RID: 72658 RVA: 0x00497C10 File Offset: 0x00495E10
			public void StartCreateCharacterReq()
			{
				this.m_owner.StartCreateCharacterReq();
			}

			// Token: 0x06011BD3 RID: 72659 RVA: 0x00497C20 File Offset: 0x00495E20
			public bool IsSessionTokenValid(string sessionToken)
			{
				return this.m_owner.IsSessionTokenValid(sessionToken);
			}

			// Token: 0x06011BD4 RID: 72660 RVA: 0x00497C30 File Offset: 0x00495E30
			public void SaveLoginInfo()
			{
				this.m_owner.SaveLoginInfo();
			}

			// Token: 0x06011BD5 RID: 72661 RVA: 0x00497C40 File Offset: 0x00495E40
			public string CreateRandomName()
			{
				return this.m_owner.CreateRandomName();
			}

			// Token: 0x06011BD6 RID: 72662 RVA: 0x00497C50 File Offset: 0x00495E50
			public void EnableInput(bool isEnable)
			{
				this.m_owner.EnableInput(isEnable);
			}

			// Token: 0x06011BD7 RID: 72663 RVA: 0x00497C60 File Offset: 0x00495E60
			public void PDLogin()
			{
				this.m_owner.PDLogin();
			}

			// Token: 0x06011BD8 RID: 72664 RVA: 0x00497C70 File Offset: 0x00495E70
			public void LoginUIController_OnLoginPCClient()
			{
				this.m_owner.LoginUIController_OnLoginPCClient();
			}

			// Token: 0x06011BD9 RID: 72665 RVA: 0x00497C80 File Offset: 0x00495E80
			public void PDSDK_OnInitFailed()
			{
				this.m_owner.PDSDK_OnInitFailed();
			}

			// Token: 0x06011BDA RID: 72666 RVA: 0x00497C90 File Offset: 0x00495E90
			public void PDSDK_OnInitSucess()
			{
				this.m_owner.PDSDK_OnInitSucess();
			}

			// Token: 0x06011BDB RID: 72667 RVA: 0x00497CA0 File Offset: 0x00495EA0
			public void ClearSDKUserIDOfAllServer()
			{
				this.m_owner.ClearSDKUserIDOfAllServer();
			}

			// Token: 0x06011BDC RID: 72668 RVA: 0x00497CB0 File Offset: 0x00495EB0
			public bool ParseLoginAgentAck(string ackText, ref string status, ref string platformName, ref string userId, ref string token, ref string error)
			{
				return this.m_owner.ParseLoginAgentAck(ackText, ref status, ref platformName, ref userId, ref token, ref error);
			}

			// Token: 0x06011BDD RID: 72669 RVA: 0x00497CC8 File Offset: 0x00495EC8
			public IEnumerator LoginAgent(string svrUrl, string data, string opcode, string channel_id, string customparams)
			{
				return this.m_owner.LoginAgent(svrUrl, data, opcode, channel_id, customparams);
			}

			// Token: 0x06011BDE RID: 72670 RVA: 0x00497CDC File Offset: 0x00495EDC
			public void SetPlatformInfoToServerList(string loginAgentUrl, string platformName, string platformUserID)
			{
				this.m_owner.SetPlatformInfoToServerList(loginAgentUrl, platformName, platformUserID);
			}

			// Token: 0x06011BDF RID: 72671 RVA: 0x00497CEC File Offset: 0x00495EEC
			public void LoginUIController_OnOpenUserCenter()
			{
				this.m_owner.LoginUIController_OnOpenUserCenter();
			}

			// Token: 0x06011BE0 RID: 72672 RVA: 0x00497CFC File Offset: 0x00495EFC
			public IEnumerator SwitchUserAccount()
			{
				return this.m_owner.SwitchUserAccount();
			}

			// Token: 0x06011BE1 RID: 72673 RVA: 0x00497D0C File Offset: 0x00495F0C
			public void LoginUIController_OnAccountTextChanged(string text)
			{
				this.m_owner.LoginUIController_OnAccountTextChanged(text);
			}

			// Token: 0x06011BE2 RID: 72674 RVA: 0x00497D1C File Offset: 0x00495F1C
			public void LoginUIController_OnSaveServerConfig()
			{
				this.m_owner.LoginUIController_OnSaveServerConfig();
			}

			// Token: 0x06011BE3 RID: 72675 RVA: 0x00497D2C File Offset: 0x00495F2C
			public void LoginUIController_OnCloseAnnouncePanel()
			{
				this.m_owner.LoginUIController_OnCloseAnnouncePanel();
			}

			// Token: 0x06011BE4 RID: 72676 RVA: 0x00497D3C File Offset: 0x00495F3C
			public void LoginUIController_OnOpenAnnouncePanel()
			{
				this.m_owner.LoginUIController_OnOpenAnnouncePanel();
			}

			// Token: 0x06011BE5 RID: 72677 RVA: 0x00497D4C File Offset: 0x00495F4C
			public void LoginUIController_OnSelectServerClick()
			{
				this.m_owner.LoginUIController_OnSelectServerClick();
			}

			// Token: 0x06011BE6 RID: 72678 RVA: 0x00497D5C File Offset: 0x00495F5C
			public bool IsNeedLoadStaticRes()
			{
				return this.m_owner.IsNeedLoadStaticRes();
			}

			// Token: 0x06011BE7 RID: 72679 RVA: 0x00497D6C File Offset: 0x00495F6C
			public List<UITaskBase.LayerDesc> CollectAllStaticResDescForLoad()
			{
				return this.m_owner.CollectAllStaticResDescForLoad();
			}

			// Token: 0x06011BE8 RID: 72680 RVA: 0x00497D7C File Offset: 0x00495F7C
			public void ShowServerListUI(bool isShow)
			{
				this.m_owner.ShowServerListUI(isShow);
			}

			// Token: 0x06011BE9 RID: 72681 RVA: 0x00497D8C File Offset: 0x00495F8C
			public IEnumerator KeepUpdatingServerList()
			{
				return this.m_owner.KeepUpdatingServerList();
			}

			// Token: 0x06011BEA RID: 72682 RVA: 0x00497D9C File Offset: 0x00495F9C
			public void LoginUIController_OnLogin()
			{
				this.m_owner.LoginUIController_OnLogin();
			}

			// Token: 0x06011BEB RID: 72683 RVA: 0x00497DAC File Offset: 0x00495FAC
			public void CreateCharacterUIController_OnCreate()
			{
				this.m_owner.CreateCharacterUIController_OnCreate();
			}

			// Token: 0x06011BEC RID: 72684 RVA: 0x00497DBC File Offset: 0x00495FBC
			public void CreateCharacterUIController_OnAutoName()
			{
				this.m_owner.CreateCharacterUIController_OnAutoName();
			}

			// Token: 0x06011BED RID: 72685 RVA: 0x00497DCC File Offset: 0x00495FCC
			public static void NetWorkTransactionTask_OnReLoginBySession(Action action)
			{
				LoginUITask.NetWorkTransactionTask_OnReLoginBySession(action);
			}

			// Token: 0x06011BEE RID: 72686 RVA: 0x00497DD4 File Offset: 0x00495FD4
			public static void NetWorkTransactionTask_ReturnToLoginUI(bool isDataDirty)
			{
				LoginUITask.NetWorkTransactionTask_ReturnToLoginUI(isDataDirty);
			}

			// Token: 0x06011BEF RID: 72687 RVA: 0x00497DDC File Offset: 0x00495FDC
			public static void ParseServerListText(string serverListText)
			{
				LoginUITask.ParseServerListText(serverListText);
			}

			// Token: 0x06011BF0 RID: 72688 RVA: 0x00497DE4 File Offset: 0x00495FE4
			public void UpdateServerList()
			{
				this.m_owner.UpdateServerList();
			}

			// Token: 0x06011BF1 RID: 72689 RVA: 0x00497DF4 File Offset: 0x00495FF4
			public static string ParseServerOpenDateTime(string dt)
			{
				return LoginUITask.ParseServerOpenDateTime(dt);
			}

			// Token: 0x06011BF2 RID: 72690 RVA: 0x00497DFC File Offset: 0x00495FFC
			public static void NetWorkTransactionTask_OnEventShowUIWaiting(bool show)
			{
				LoginUITask.NetWorkTransactionTask_OnEventShowUIWaiting(show);
			}

			// Token: 0x0400A16F RID: 41327
			private LoginUITask m_owner;
		}
	}
}
