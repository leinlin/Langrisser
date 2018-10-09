using System;
using System.Collections;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Log;
using BlackJack.BJFramework.Runtime.Resource;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using BlackJack.ProjectLBasic;
using PD.SDK;
using UnityEngine;

namespace BlackJack.ProjectL.Static
{
	// Token: 0x020010FF RID: 4351
	public class ProjectLGameLauncher : MonoBehaviour
	{
		// Token: 0x06015A41 RID: 88641 RVA: 0x00582010 File Offset: 0x00580210
		private void Awake()
		{
			ProjectLGameLauncher.InitAutoRotateSetting();
			global::Debug.m_mainThread = Thread.CurrentThread;
			LogManager.CreateLogManager();
			LogManager.Instance.Initlize(Application.platform == RuntimePlatform.WindowsEditor, true, Application.persistentDataPath + "/Log/", "Log");
			Application.targetFrameRate = 60;
			Utility.LogMemorySize("ProjectLGameLauncher.Awake");
		}

		// Token: 0x06015A42 RID: 88642 RVA: 0x0058206C File Offset: 0x0058026C
		private IEnumerator Start()
		{
			if (DebugConsoleView.instance != null)
			{
				DebugConsoleView.instance.IsForceHide = true;
			}
			if (DebugConsoleMode.instance != null)
			{
				LogManager.Instance.FileLogger.EventOnLog += DebugConsoleMode.instance._LogReceived;
				Application.logMessageReceived -= DebugConsoleMode.instance._LogCallback;
			}
			global::Debug.Log("ProjectLGameLauncher.Start()");
			if (!StringTable.Load())
			{
				global::Debug.LogError("Failed to load string table.");
			}
			yield return new WaitUntil(() => PDSDK.Instance != null);
			PDSDK.Instance.Init();
			yield return new WaitUntil(() => PDSDK.IsInit);
			PDSDK.Instance.printGameEventLog("1", string.Empty);
			if (!DefaultServerAddress.Load())
			{
				global::Debug.LogError("call DefaultServerAddress.Load failed.");
				yield break;
			}
			this.m_gameManager = GameManager.CreateAndInitGameManager<ProjectLGameManager>();
			if (this.m_gameManager == null)
			{
				global::Debug.LogError("CreateAndInitGameManager start fail");
				yield break;
			}
			if (PDSDK.IsIosReview)
			{
				this.m_gameManager.GameClientSetting.ResourcesSetting.SkipStreamingAssetsFileProcessing = true;
				this.m_gameManager.GameClientSetting.ResourcesSetting.DisableAssetBundleDownload = true;
				this.m_gameManager.GameClientSetting.ResourcesSetting.SkipAssetBundlePreUpdateing = true;
				this.m_gameManager.GameClientSetting.ResourcesSetting.AssetBundleDownloadUrlRoot = string.Empty;
				if (ResourceManager.Instance != null && !ResourceManager.Instance.Initlize(this.m_gameManager.GameClientSetting.ResourcesSetting))
				{
					global::Debug.LogError("ProjectLGameLauncher.Start failed to initialize resourcemanager.");
				}
			}
			yield return null;
			UIManager.Instance.RegisterUITaskWithGroup(typeof(ProjectLGameEntryUITask).Name, new TypeDNName(typeof(ProjectLGameEntryUITask).FullName), 0, null);
			if (!(UIManager.Instance.StartUITask(new UIIntent(typeof(ProjectLGameEntryUITask).Name, null), false, false, null) is ProjectLGameEntryUITask))
			{
				global::Debug.LogError("ProjectLGameEntryUITask start fail");
			}
			Utility.LogMemorySize("ProjectLGameLauncher.Start");
			yield break;
		}

		// Token: 0x06015A43 RID: 88643 RVA: 0x00582088 File Offset: 0x00580288
		public static void InitAutoRotateSetting()
		{
			Screen.autorotateToLandscapeLeft = true;
			Screen.autorotateToLandscapeRight = true;
			Screen.autorotateToPortrait = false;
			Screen.autorotateToPortraitUpsideDown = false;
			Screen.orientation = ScreenOrientation.AutoRotation;
		}

		// Token: 0x06015A44 RID: 88644 RVA: 0x005820A8 File Offset: 0x005802A8
		private void Update()
		{
			if (this.m_gameManager != null)
			{
				this.m_gameManager.Tick();
			}
		}

		// Token: 0x06015A45 RID: 88645 RVA: 0x005820C0 File Offset: 0x005802C0
		private void LateUpdate()
		{
			CommonUIController.StaticLateUpdate();
		}

		// Token: 0x06015A46 RID: 88646 RVA: 0x005820C8 File Offset: 0x005802C8
		private void OnApplicationQuit()
		{
			this.m_gameManager.OnApplicationQuit();
		}

		// Token: 0x06015A47 RID: 88647 RVA: 0x005820D8 File Offset: 0x005802D8
		private void OnApplicationPause(bool isPause)
		{
			global::Debug.Log(string.Format("ProjectLGameLauncher.OnApplicationPause {0}", isPause));
			if (GameManager.Instance == null)
			{
				return;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			bool flag = PDSDK.Instance != null && PDSDK.Instance.m_isCallWebView;
			if (isPause)
			{
				this.m_pauseTime = DateTime.Now;
				if (!flag && projectLPlayerContext != null)
				{
					projectLPlayerContext.SendClientAppPauseNtf();
				}
			}
			else if (this.m_pauseTime != DateTime.MinValue)
			{
				if (!flag && projectLPlayerContext != null)
				{
					projectLPlayerContext.SendClientAppResumeNtf();
				}
				this.m_pauseTime = DateTime.MinValue;
			}
		}

		// Token: 0x0400BD2A RID: 48426
		private ProjectLGameManager m_gameManager;

		// Token: 0x0400BD2B RID: 48427
		private DateTime m_pauseTime;
	}
}
