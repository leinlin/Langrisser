using System;
using System.Collections;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Resource;
using BlackJack.BJFramework.Runtime.Scene;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using BlackJack.ProjectLBasic;
using PD.SDK;
using UnityEngine;

namespace BlackJack.ProjectL.Static
{
	// Token: 0x020010F4 RID: 4340
	public class ProjectLGameEntryUITask : GameEntryUITaskBase
	{
		// Token: 0x060159E1 RID: 88545 RVA: 0x005809F4 File Offset: 0x0057EBF4
		public ProjectLGameEntryUITask(string taskName) : base(taskName)
		{
		}

		// Token: 0x060159E2 RID: 88546 RVA: 0x00580A90 File Offset: 0x0057EC90
		protected override void OnTick()
		{
			base.OnTick();
			if (this.m_mainCtrl == null)
			{
				return;
			}
			this.UpdatePreloadProgress();
			this.UpdateLoadConfigProgress();
		}

		// Token: 0x060159E3 RID: 88547 RVA: 0x00580AB8 File Offset: 0x0057ECB8
		protected override IEnumerator OnBasicVersionUnmatch()
		{
			global::Debug.LogError("Pre-Update Client failed: OnBasicVersionUnmatch");
			yield return new WaitForSecondsRealtime(3f);
			yield return DialogBox.Show(this.m_mainCtrl.gameObject, "Assets/GameProject/Resources/UI/DialogBox.prefab", StringTable.Get("MsgUpdateClinetByAppStore"), StringTable.Get("ButtonIKnow"), string.Empty, delegate(DialogBoxResult ret)
			{
				if (PDSDK.Instance != null)
				{
					Application.OpenURL(PDSDK.Instance.DownloadClientURL);
				}
				Application.Quit();
			});
			yield break;
		}

		// Token: 0x060159E4 RID: 88548 RVA: 0x00580AD4 File Offset: 0x0057ECD4
		protected override void InitAllUIControllers()
		{
			base.InitAllUIControllers();
			if (this.m_mainCtrl == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_mainCtrl = (this.m_uiCtrlArray[0] as ProjectLGameEntryUIController);
				}
				if (this.m_mainCtrl == null)
				{
					global::Debug.LogError("ProjectLGameEntryUIController is null");
					return;
				}
			}
		}

		// Token: 0x060159E5 RID: 88549 RVA: 0x00580B38 File Offset: 0x0057ED38
		protected override void UpdateView()
		{
		}

		// Token: 0x060159E6 RID: 88550 RVA: 0x00580B3C File Offset: 0x0057ED3C
		private IEnumerator CheckNetwork()
		{
			if (SceneManager.Instance == null)
			{
				yield return null;
			}
			for (;;)
			{
				if (Application.internetReachability == NetworkReachability.NotReachable)
				{
					yield return DialogBox.Show(this.m_mainCtrl.gameObject, "Assets/GameProject/Resources/UI/DialogBox.prefab", StringTable.Get("MsgCheckYourNetworkPlease"), StringTable.Get("ButtonOK"), string.Empty, null);
				}
				else
				{
					Hostname2Ip[] h2is = new Hostname2Ip[]
					{
						new Hostname2Ip("www.baidu.com"),
						new Hostname2Ip("www.qq.com"),
						new Hostname2Ip("www.taobao.com"),
						new Hostname2Ip("www.google.com"),
						new Hostname2Ip("www.facebook.com")
					};
					float t = Time.unscaledTime + 5f;
					yield return new WaitUntil(delegate()
					{
						foreach (Hostname2Ip hostname2Ip2 in h2is)
						{
							if (hostname2Ip2.isDone && !string.IsNullOrEmpty(hostname2Ip2.ip))
							{
								return true;
							}
						}
						return Time.unscaledTime > t;
					});
					foreach (Hostname2Ip hostname2Ip in h2is)
					{
						hostname2Ip.Destroy();
					}
					if (Time.unscaledTime < t)
					{
						break;
					}
					yield return DialogBox.Show(this.m_mainCtrl.gameObject, "Assets/GameProject/Resources/UI/DialogBox.prefab", StringTable.Get("MsgCheckYourNetworkPlease"), StringTable.Get("ButtonOK"), string.Empty, null);
				}
			}
			yield break;
		}

		// Token: 0x060159E7 RID: 88551 RVA: 0x00580B58 File Offset: 0x0057ED58
		protected override IEnumerator EntryPipeLine()
		{
			Utility.LogMemorySize("ProjectLGameEntryUITask.EntryPipeLine");
			bool isEnd = false;
			this.m_mainCtrl.ShowCompanyUI(delegate
			{
				isEnd = true;
			});
			float delay = Time.unscaledTime + 3.5f;
			yield return new WaitUntil(delegate()
			{
				if (Time.unscaledTime > delay)
				{
					this.m_mainCtrl.ShowUpdateClientUI(true);
				}
				return isEnd;
			});
			this.m_mainCtrl.SetMesssage(StringTable.Get("MsgConnectingServer"));
			this.m_mainCtrl.SetProgress(0f);
			this.m_mainCtrl.ShowUpdateClientUI(true);
			yield return this.CheckNetwork();
			this.m_mainCtrl.AddProgress(0.05f, 1f);
			yield return Utility.GetUpdateClientURL(this.m_mainCtrl.gameObject);
			this.m_mainCtrl.AddProgress(0.05f, 1f);
			yield return base.EntryPipeLine();
			yield break;
		}

		// Token: 0x060159E8 RID: 88552 RVA: 0x00580B74 File Offset: 0x0057ED74
		protected override IEnumerator DownloadAudioFiles()
		{
			if (PDSDK.IsIosReview)
			{
				yield break;
			}
			float updateTime = Time.unscaledTime + 1f;
			long lastDownloadedLength = 0L;
			bool isSuccess = true;
			long downloadAssetbundleLength = ResourceManager.Instance.GetTotalPreUpdateingDownloadBytes();
			yield return AudioManager4CRI.DownloadAudioFiles(delegate(bool ret)
			{
				isSuccess = ret;
			}, delegate(long downloadedLength, long totalLength)
			{
				if (Time.unscaledTime > updateTime)
				{
					if (this.m_downloadAudioLength <= 0L)
					{
						this.m_downloadAudioLength = totalLength;
					}
					this.m_mainCtrl.SetProgress(0.5f + (float)downloadedLength / (float)totalLength * 0.2f);
					this.m_mainCtrl.SetMesssage(string.Format(StringTable.Get("MsgCurrentDownloadInfo"), (double)(downloadAssetbundleLength + downloadedLength) * 9.5367431640625E-07, (double)(downloadAssetbundleLength + this.m_downloadAudioLength) * 9.5367431640625E-07, (double)(downloadedLength - lastDownloadedLength) / 1024.0 / (double)(Time.unscaledTime - updateTime + 1f)));
					lastDownloadedLength = downloadedLength;
					updateTime = Time.unscaledTime + 1f;
				}
			}, null, this.m_mainCtrl);
			if (!isSuccess)
			{
				PDSDK.Instance.printGameEventLog("18.1", string.Empty);
				yield return DialogBox.Show(this.m_mainCtrl.gameObject, "Assets/GameProject/Resources/UI/DialogBox.prefab", StringTable.Get("MsgUpdateAudioFailed"), StringTable.Get("ButtonOK"), string.Empty, null);
			}
			yield break;
		}

		// Token: 0x060159E9 RID: 88553 RVA: 0x00580B90 File Offset: 0x0057ED90
		protected override void OnStreamingAssetsFilesProcessingStart()
		{
			this.m_mainCtrl.SetMesssage(StringTable.Get("MsgCheckingLocalResources"));
		}

		// Token: 0x060159EA RID: 88554 RVA: 0x00580BA8 File Offset: 0x0057EDA8
		protected override void OnStreamingAssetsFilesProcessingEnd(bool ret)
		{
		}

		// Token: 0x060159EB RID: 88555 RVA: 0x00580BAC File Offset: 0x0057EDAC
		protected override void OnBundleDataLoadingStart()
		{
			this.m_mainCtrl.SetMesssage(StringTable.Get("MsgConnectingServer"));
		}

		// Token: 0x060159EC RID: 88556 RVA: 0x00580BC4 File Offset: 0x0057EDC4
		protected override void OnBundleDataLoadingEnd(bool ret)
		{
			if (!ret)
			{
				this.m_mainCtrl.StartCoroutine(DialogBox.Show(this.m_mainCtrl.gameObject, "Assets/GameProject/Resources/UI/DialogBox.prefab", StringTable.Get("MsgUpdateClinetFailed"), StringTable.Get("ButtonOK"), string.Empty, delegate(DialogBoxResult result)
				{
					Application.Quit();
				}));
				return;
			}
			this.m_mainCtrl.AddProgress(0.1f, 1f);
		}

		// Token: 0x060159ED RID: 88557 RVA: 0x00580C44 File Offset: 0x0057EE44
		protected override void NotifyUserDownloadAndWait(long totalDownloadByte)
		{
			this.m_mainCtrl.StartCoroutine(this.GetAudioDownloadLengthAndNotifyUser(totalDownloadByte));
		}

		// Token: 0x060159EE RID: 88558 RVA: 0x00580C5C File Offset: 0x0057EE5C
		private IEnumerator GetAudioDownloadLengthAndNotifyUser(long downloadAssetbundleBytes)
		{
			yield return AudioManager4CRI.DownloadAudioFiles(delegate(bool ret)
			{
				if (!ret)
				{
					global::Debug.LogError("ProjectLGameEntryUITask.GetAudioDownloadLengthAndNotifyUser Get audio download length failed!");
				}
			}, null, delegate(long downloadLengh)
			{
				this.m_downloadAudioLength = downloadLengh;
				downloadAssetbundleBytes += downloadLengh;
			}, null);
			double sizeMB = (double)downloadAssetbundleBytes * 9.5367431640625E-07;
			if (sizeMB < 5.0 && Application.internetReachability == NetworkReachability.ReachableViaLocalAreaNetwork)
			{
				global::Debug.Log(string.Format("Directly download patch({0:F2}MB) less than 5MB in WIFI.", sizeMB));
				base.StartPreDownload();
				PDSDK.Instance.printGameEventLog("15", string.Empty);
				yield break;
			}
			this.m_mainCtrl.StartCoroutine(DialogBox.Show(this.m_mainCtrl.gameObject, "Assets/GameProject/Resources/UI/DialogBox.prefab", string.Format(StringTable.Get("MsgUpdateClientOrNot"), sizeMB), StringTable.Get("ButtonUpdate"), StringTable.Get("ButtonNo"), delegate(DialogBoxResult ret)
			{
				if (ret == DialogBoxResult.Ok)
				{
					this.StartPreDownload();
					PDSDK.Instance.printGameEventLog("15", string.Empty);
				}
				else
				{
					Application.Quit();
				}
			}));
			yield break;
		}

		// Token: 0x060159EF RID: 88559 RVA: 0x00580C80 File Offset: 0x0057EE80
		protected override void OnAssetBundlePreUpdateingRefuse()
		{
		}

		// Token: 0x060159F0 RID: 88560 RVA: 0x00580C84 File Offset: 0x0057EE84
		protected override void OnAssetBundlePreUpdateingStart()
		{
			this.m_mainCtrl.SetMesssage(StringTable.Get("MsgDownloading"));
		}

		// Token: 0x060159F1 RID: 88561 RVA: 0x00580C9C File Offset: 0x0057EE9C
		protected override void OnAssetBundlePreUpdateingEnd(bool ret)
		{
			if (!ret)
			{
				this.m_mainCtrl.StartCoroutine(DialogBox.Show(this.m_mainCtrl.gameObject, "Assets/GameProject/Resources/UI/DialogBox.prefab", StringTable.Get("MsgUpdateClinetFailed"), StringTable.Get("ButtonOK"), string.Empty, delegate(DialogBoxResult result)
				{
					Application.Quit();
				}));
				PDSDK.Instance.printGameEventLog("18", string.Empty);
				return;
			}
			this.m_mainCtrl.SetProgress(0.5f);
			PDSDK.Instance.printGameEventLog("16", string.Empty);
		}

		// Token: 0x060159F2 RID: 88562 RVA: 0x00580D40 File Offset: 0x0057EF40
		protected override void OnAssetBundleManifestLoadingStart()
		{
			this.m_mainCtrl.SetMesssage(StringTable.Get("MsgCheckingDownloadedResources"));
		}

		// Token: 0x060159F3 RID: 88563 RVA: 0x00580D58 File Offset: 0x0057EF58
		protected override void OnAssetBundleManifestLoadingEnd(bool ret)
		{
			if (!ret)
			{
				this.m_mainCtrl.StartCoroutine(DialogBox.Show(this.m_mainCtrl.gameObject, "Assets/GameProject/Resources/UI/DialogBox.prefab", StringTable.Get("MsgUpdateClinetFailed"), StringTable.Get("ButtonOK"), string.Empty, delegate(DialogBoxResult result)
				{
					Application.Quit();
				}));
				return;
			}
			this.m_mainCtrl.AddProgress(0.02f, 1f);
		}

		// Token: 0x060159F4 RID: 88564 RVA: 0x00580DD8 File Offset: 0x0057EFD8
		protected override void OnLoadDynamicAssemblysStart()
		{
			this.m_mainCtrl.SetMesssage(StringTable.Get("MsgLoadingProgram"));
		}

		// Token: 0x060159F5 RID: 88565 RVA: 0x00580DF0 File Offset: 0x0057EFF0
		protected override void OnLoadDynamicAssemblysEnd(bool ret)
		{
			if (!ret)
			{
				this.m_mainCtrl.StartCoroutine(DialogBox.Show(this.m_mainCtrl.gameObject, "Assets/GameProject/Resources/UI/DialogBox.prefab", StringTable.Get("MsgLoadProgramFailed"), StringTable.Get("ButtonOK"), string.Empty, delegate(DialogBoxResult result)
				{
					Application.Quit();
				}));
				return;
			}
			ProjectLGameManager projectLGameManager = GameManager.Instance as ProjectLGameManager;
			if (projectLGameManager == null)
			{
				return;
			}
			if (!projectLGameManager.InitLogicInterface())
			{
				global::Debug.LogError("ProjectLGameEntryUITask.OnLoadDynamicAssemblysEnd ProjectLGameManager.InitLogicInterface failed.");
				return;
			}
		}

		// Token: 0x060159F6 RID: 88566 RVA: 0x00580E84 File Offset: 0x0057F084
		protected override void OnStartLuaManagerStart()
		{
			this.m_mainCtrl.SetMesssage(StringTable.Get("MsgLoadingScripts"));
		}

		// Token: 0x060159F7 RID: 88567 RVA: 0x00580E9C File Offset: 0x0057F09C
		protected override void OnStartLuaManagerEnd(bool ret)
		{
			if (!ret)
			{
				this.m_mainCtrl.StartCoroutine(DialogBox.Show(this.m_mainCtrl.gameObject, "Assets/GameProject/Resources/UI/DialogBox.prefab", StringTable.Get("MsgLoadScriptsFailed"), StringTable.Get("ButtonOK"), string.Empty, delegate(DialogBoxResult result)
				{
					Application.Quit();
				}));
				return;
			}
			this.m_mainCtrl.AddProgress(0.02f, 1f);
		}

		// Token: 0x060159F8 RID: 88568 RVA: 0x00580F1C File Offset: 0x0057F11C
		protected override void OnLoadConfigDataStart()
		{
			Utility.LogMemorySize("ProjectLGameEntryUITask.OnLoadConfigDataStart");
			this.m_mainCtrl.SetMesssage(StringTable.Get("MsgLoadingConfigs"));
			this.m_mainCtrl.AddProgress(1f, 0.7f);
			this.m_isUpdateLoadConfigProgress = true;
		}

		// Token: 0x060159F9 RID: 88569 RVA: 0x00580F5C File Offset: 0x0057F15C
		protected override void OnLoadConfigDataEnd(bool ret)
		{
			Utility.LogMemorySize("ProjectLGameEntryUITask.OnLoadConfigDataEnd");
			this.m_isUpdateLoadConfigProgress = false;
			if (!ret)
			{
				this.m_mainCtrl.StartCoroutine(DialogBox.Show(this.m_mainCtrl.gameObject, "Assets/GameProject/Resources/UI/DialogBox.prefab", StringTable.Get("MsgLoadConfigFailed"), StringTable.Get("ButtonOK"), string.Empty, delegate(DialogBoxResult result)
				{
					Application.Quit();
				}));
				return;
			}
			PDSDK.Instance.printGameEventLog("19", string.Empty);
		}

		// Token: 0x060159FA RID: 88570 RVA: 0x00580FEC File Offset: 0x0057F1EC
		protected override void OnStartAudioManagerStart()
		{
			this.m_mainCtrl.SetMesssage(StringTable.Get("MsgLoaingAudio"));
		}

		// Token: 0x060159FB RID: 88571 RVA: 0x00581004 File Offset: 0x0057F204
		protected override void OnStartAudioManagerEnd(bool ret)
		{
			if (!ret)
			{
				this.m_mainCtrl.StartCoroutine(DialogBox.Show(this.m_mainCtrl.gameObject, "Assets/GameProject/Resources/UI/DialogBox.prefab", StringTable.Get("MsgLoadAudioFailed"), StringTable.Get("ButtonOK"), string.Empty, delegate(DialogBoxResult result)
				{
					Application.Quit();
				}));
				return;
			}
			this.m_mainCtrl.AddProgress(0.04f, 1f);
		}

		// Token: 0x060159FC RID: 88572 RVA: 0x00581084 File Offset: 0x0057F284
		private void CollectPreloadMessage()
		{
			if (this.m_preloadMessage.Count > 0)
			{
				return;
			}
			for (int i = 1; i < 1000; i++)
			{
				string key = string.Format("PreloadMessage_{0}", i);
				if (!StringTable.IsKeyExist(key))
				{
					break;
				}
				this.m_preloadMessage.Add(StringTable.Get(key));
			}
		}

		// Token: 0x060159FD RID: 88573 RVA: 0x005810EC File Offset: 0x0057F2EC
		private void RandomUpdatePreloadMessage()
		{
			this.m_mainCtrl.SetMesssage(this.m_preloadMessage[UnityEngine.Random.Range(0, this.m_preloadMessage.Count)]);
		}

		// Token: 0x060159FE RID: 88574 RVA: 0x00581118 File Offset: 0x0057F318
		protected override void LaunchLogin()
		{
			Utility.LogMemorySize("StartUITask PreloadUITask");
			UIUtility.LoadTranslateTable();
			this.CollectPreloadMessage();
			this.m_mainCtrl.SetProgress(0f);
			this.RandomUpdatePreloadMessage();
			if (UIManager.Instance.StartUITask(new UIIntent("PreloadUITask", null), true, false, null) == null)
			{
				global::Debug.LogError("ProjectLGameEntryUITask.LaunchLogin Start PreloadUITask failed.");
				return;
			}
			ResourceManager.Instance.m_loadingProgress = 0f;
			this.m_isUpdatePreloadProgress = true;
		}

		// Token: 0x060159FF RID: 88575 RVA: 0x00581190 File Offset: 0x0057F390
		private void UpdateLoadConfigProgress()
		{
			if (!this.m_isUpdateLoadConfigProgress || this.m_mainCtrl == null)
			{
				return;
			}
			ClientConfigDataLoader clientConfigDataLoader = GameManager.Instance.ConfigDataLoader as ClientConfigDataLoader;
			if (clientConfigDataLoader == null || clientConfigDataLoader.LoadingProgress > 0.99999f)
			{
				return;
			}
			this.m_mainCtrl.SetProgress(0.7f + 0.29f * clientConfigDataLoader.LoadingProgress);
		}

		// Token: 0x06015A00 RID: 88576 RVA: 0x00581200 File Offset: 0x0057F400
		private void UpdatePreloadProgress()
		{
			if (!this.m_isUpdatePreloadProgress)
			{
				return;
			}
			if (Time.unscaledTime > this.m_lastUpdateMessageTime + 4f)
			{
				this.RandomUpdatePreloadMessage();
				this.m_lastUpdateMessageTime = Time.unscaledTime;
			}
			if (Time.unscaledTime > this.m_lastUpdateProgressTime + 0.2f)
			{
				this.m_mainCtrl.SetProgress(ResourceManager.Instance.m_loadingProgress);
				this.m_lastUpdateProgressTime = Time.unscaledTime;
			}
			if (ResourceManager.Instance.m_loadingProgress > 0.95f)
			{
				this.m_isUpdatePreloadProgress = false;
				Shader.WarmupAllShaders();
			}
		}

		// Token: 0x06015A01 RID: 88577 RVA: 0x00581298 File Offset: 0x0057F498
		protected override void UpdateView4StreamingAssetsFilesProcessing()
		{
		}

		// Token: 0x06015A02 RID: 88578 RVA: 0x0058129C File Offset: 0x0057F49C
		protected override void UpdateView4BundleDataLoading()
		{
		}

		// Token: 0x06015A03 RID: 88579 RVA: 0x005812A0 File Offset: 0x0057F4A0
		protected override void UpdateView4AssetBundlePreUpdateing()
		{
			if (Time.unscaledTime > this.m_lastUpdateProgressTime + 0.5f)
			{
				this.m_mainCtrl.AddProgress((ResourceManager.Instance.GetAssetBundleUpdateingPercent() - this.m_lastUpdateProgress) * 0.3f, 0.5f);
				this.m_lastUpdateProgress = ResourceManager.Instance.GetAssetBundleUpdateingPercent();
				this.m_mainCtrl.SetMesssage(string.Format(StringTable.Get("MsgCurrentDownloadInfo"), (double)ResourceManager.Instance.GetPreUpdateingDownloadedBytes() * 9.5367431640625E-07, (double)(ResourceManager.Instance.GetTotalPreUpdateingDownloadBytes() + this.m_downloadAudioLength) * 9.5367431640625E-07, (double)(ResourceManager.Instance.GetPreUpdateingDownloadedBytes() - this.m_lastDownloadedBytes) / 1024.0 / (double)(Time.unscaledTime - this.m_lastUpdateProgressTime)));
				this.m_lastDownloadedBytes = ResourceManager.Instance.GetPreUpdateingDownloadedBytes();
				this.m_lastUpdateProgressTime = Time.unscaledTime;
			}
		}

		// Token: 0x06015A04 RID: 88580 RVA: 0x0058139C File Offset: 0x0057F59C
		protected override void UpdateView4AssetBundleManifestLoading()
		{
		}

		// Token: 0x17003EFC RID: 16124
		// (get) Token: 0x06015A05 RID: 88581 RVA: 0x005813A0 File Offset: 0x0057F5A0
		protected override UITaskBase.LayerDesc[] LayerDescArray
		{
			get
			{
				return this.m_layerDescArray;
			}
		}

		// Token: 0x17003EFD RID: 16125
		// (get) Token: 0x06015A06 RID: 88582 RVA: 0x005813A8 File Offset: 0x0057F5A8
		protected override UITaskBase.UIControllerDesc[] UICtrlDescArray
		{
			get
			{
				return this.m_uiCtrlDescArray;
			}
		}

		// Token: 0x0400BCE8 RID: 48360
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "EntryUILayer",
				m_layerResPath = "Assets/GameProject/Resources/UI/EntryUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400BCE9 RID: 48361
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "EntryUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.Static.ProjectLGameEntryUIController"),
				m_ctrlName = "ProjectLGameEntryUIController"
			}
		};

		// Token: 0x0400BCEA RID: 48362
		private ProjectLGameEntryUIController m_mainCtrl;

		// Token: 0x0400BCEB RID: 48363
		private float m_lastUpdateProgress;

		// Token: 0x0400BCEC RID: 48364
		private long m_lastDownloadedBytes;

		// Token: 0x0400BCED RID: 48365
		private float m_lastUpdateProgressTime;

		// Token: 0x0400BCEE RID: 48366
		private bool m_isUpdatePreloadProgress;

		// Token: 0x0400BCEF RID: 48367
		private bool m_isUpdateLoadConfigProgress;

		// Token: 0x0400BCF0 RID: 48368
		private List<string> m_preloadMessage = new List<string>(10);

		// Token: 0x0400BCF1 RID: 48369
		private float m_lastUpdateMessageTime;

		// Token: 0x0400BCF2 RID: 48370
		private long m_downloadAudioLength;

		// Token: 0x0400BCF3 RID: 48371
		private const double m_byte2MB = 9.5367431640625E-07;
	}
}
