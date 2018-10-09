using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using BlackJack.BJFramework.Runtime.ConfigData;
using BlackJack.BJFramework.Runtime.Log;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.PlayerContext;
using BlackJack.BJFramework.Runtime.Resource;
using BlackJack.BJFramework.Runtime.Scene;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.Utils;
using SLua;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x02000045 RID: 69
	[CustomLuaClass]
	public abstract class GameManager : ITickable
	{
		// Token: 0x0600036B RID: 875 RVA: 0x00010A04 File Offset: 0x0000EC04
		[DoNotToLua]
		protected GameManager()
		{
			this.m_state = GameManager.GMState.None;
			this.m_playerContext = null;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00010A30 File Offset: 0x0000EC30
		[DoNotToLua]
		public static T CreateAndInitGameManager<T>() where T : GameManager, new()
		{
			if (GameManager.m_instance != null)
			{
				return GameManager.m_instance as T;
			}
			GameManager.m_instance = Activator.CreateInstance<T>();
			if (!GameManager.m_instance.Initlize())
			{
				global::Debug.LogError("CreateAndInitGameManager fail");
				return (T)((object)null);
			}
			return (T)((object)GameManager.m_instance);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00010A90 File Offset: 0x0000EC90
		[DoNotToLua]
		private Assembly OnAssemblyResolve(object sender, ResolveEventArgs args)
		{
			global::Debug.LogWarning(string.Format("{0} {1}", sender, args.Name));
			return null;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00010AAC File Offset: 0x0000ECAC
		[DoNotToLua]
		private void OnAssemblyLoad(object sender, AssemblyLoadEventArgs args)
		{
			global::Debug.LogWarning(string.Format("{0} {1}", sender, args.LoadedAssembly));
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00010AC4 File Offset: 0x0000ECC4
		[DoNotToLua]
		private void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
			global::Debug.LogError(string.Format("OnUnhandledException  {0} {1}", sender, e));
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00010AD8 File Offset: 0x0000ECD8
		[DoNotToLua]
		public virtual bool Initlize()
		{
			UnityEngine.Debug.Log("GameManager.Initlize start");
			AppDomain.CurrentDomain.AssemblyResolve += this.OnAssemblyResolve;
			AppDomain.CurrentDomain.AssemblyLoad += this.OnAssemblyLoad;
			AppDomain.CurrentDomain.UnhandledException += this.OnUnhandledException;
			if (!this.InitlizeGameSetting())
			{
				UnityEngine.Debug.LogError("GameManager.Initlize fail");
				return false;
			}
			Application.targetFrameRate = this.m_gameClientSetting.ResolutionSetting.RefreshRate;
			Screen.sleepTimeout = -1;
			global::Debug.m_mainThread = Thread.CurrentThread;
			string str = (!this.m_gameClientSetting.Log2Persistent) ? Application.temporaryCachePath : Application.persistentDataPath;
			this.m_logManager = LogManager.CreateLogManager();
			if (!this.m_logManager.Initlize(!this.m_gameClientSetting.DisableUnityEngineLog, true, str + "/Log/", "Log"))
			{
				UnityEngine.Debug.LogError("GameManager.Initlize fail for m_logManager.Initlize");
				return false;
			}
			this.m_taskManager = TaskManager.CreateTaskManager();
			if (!this.m_taskManager.Initlize())
			{
				UnityEngine.Debug.LogError("GameManager.Initlize fail for m_taskManager.Initlize()");
				return false;
			}
			if (GameManager.CreateResourceManagerHandler != null)
			{
				this.m_resourceManager = GameManager.CreateResourceManagerHandler();
			}
			else
			{
				this.m_resourceManager = ResourceManager.CreateResourceManager();
			}
			if (!this.m_resourceManager.Initlize(this.m_gameClientSetting.ResourcesSetting))
			{
				global::Debug.LogError("GameManager.Initlize fail for m_resourceManager.Initlize()");
				return false;
			}
			this.m_sceneManager = SceneManager.CreateSceneManager();
			if (!this.m_sceneManager.Initlize(this.m_gameClientSetting.SceneSetting.DesignScreenWidth, this.m_gameClientSetting.SceneSetting.DesignScreenHeight, this.m_gameClientSetting.SceneSetting.TrigerWidth2ShrinkScale, this.m_gameClientSetting.SceneSetting.TrigerHeight2ShrinkScale, this.m_gameClientSetting.SceneSetting.SceneLayerOffset, false, this.m_gameClientSetting.SceneSetting.UseOrthographicForUILayer))
			{
				global::Debug.LogError("GameManager.Initlize fail for m_sceneManager.Initlize()");
				return false;
			}
			this.m_uiManager = UIManager.CreateUIManager();
			if (!this.m_uiManager.Initlize())
			{
				global::Debug.LogError("GameManager.Initlize fail for m_uiManager.Initlize()");
				return false;
			}
			this.m_classLoader = ClassLoader.CreateClassLoader();
			Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
			foreach (Assembly assembly in assemblies)
			{
				this.m_classLoader.AddAssembly(assembly);
			}
			foreach (string assemblyString in this.m_gameClientSetting.DynamicAssemblySetting.DynamicAssemblyList)
			{
				this.m_classLoader.AddAssembly(Assembly.Load(assemblyString));
			}
			if (this.m_gameClientSetting.LuaSetting.EnableLua)
			{
				if (this.m_gameClientSetting.DynamicAssemblySetting.EnableDynamicAssembly)
				{
					global::Debug.LogError("Can not enable DynamicAssembly and Lua in same time");
					return false;
				}
				this.m_luaManager = LuaManager.CreateLuaManager();
				if (!this.m_luaManager.Initlize(this.m_gameClientSetting.LuaSetting.LuaRootPath, this.m_gameClientSetting.LuaSetting.LuaInitModule))
				{
					global::Debug.LogError("GameManager.Initlize fail for m_luaManager.Initlize()");
					return false;
				}
			}
			this.m_state = GameManager.GMState.Inited;
			return true;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00010E28 File Offset: 0x0000F028
		public bool InitlizeAudioManager()
		{
			this.m_audioManager = this.CreateAudioManager();
			if (!this.m_audioManager.Initlize())
			{
				global::Debug.LogError("GameManager.InitlizeAudioManager Failed to m_audioManager.Initlize()");
				return false;
			}
			return true;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00010E54 File Offset: 0x0000F054
		[DoNotToLua]
		public virtual void Uninitlize()
		{
			this.m_corutineHelper.CancelAll();
			if (this.m_luaManager != null)
			{
				this.m_luaManager.Uninitlize();
			}
			this.m_uiManager.Uninitlize();
			this.m_sceneManager.Uninitlize();
			if (this.m_audioManager != null)
			{
				this.m_audioManager.Uninitlize();
			}
			this.m_resourceManager.Uninitlize();
			this.m_taskManager.Uninitlize();
			this.m_logManager.Uninitlize();
			global::Debug.m_mainThread = null;
			this.m_state = GameManager.GMState.None;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00010EDC File Offset: 0x0000F0DC
		[DoNotToLua]
		public virtual void OnApplicationQuit()
		{
			this.Uninitlize();
			GameManager.m_instance = null;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00010EEC File Offset: 0x0000F0EC
		[DoNotToLua]
		protected virtual bool InitlizeGameSetting()
		{
			this.m_gameClientSetting = (Resources.Load("GameClientSetting", typeof(GameClientSetting)) as GameClientSetting);
			if (this.m_gameClientSetting == null)
			{
				UnityEngine.Debug.LogError("InitlizeGameSetting fail");
				return false;
			}
			return true;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00010F2C File Offset: 0x0000F12C
		[DoNotToLua]
		protected IAudioManager CreateAudioManager()
		{
			if (this.m_gameClientSetting.AudioSetting.EnableCRI)
			{
				return AudioManager4CRI.CreateAudioManager();
			}
			return AudioManager4Unity.CreateAudioManager();
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00010F50 File Offset: 0x0000F150
		[DoNotToLua]
		public virtual bool StartLoadDynamicAssemblys(Action<bool> onEnd)
		{
			global::Debug.Log("GameManager.StartLoadDynamicAssemblys");
			if (this.m_state != GameManager.GMState.Inited || this.m_resourceManager.State != ResourceManager.RMState.AssetBundleManifestLoadEnd)
			{
				global::Debug.LogError("StartLoadDynamicAssemblys in wrong state");
				return false;
			}
			this.m_state = GameManager.GMState.DynamicAssemblyLoading;
			if (!this.m_gameClientSetting.DynamicAssemblySetting.EnableDynamicAssembly)
			{
				global::Debug.Log("StartLoadDynamicAssemblys skip");
				this.m_state = GameManager.GMState.DynamicAssemblyLoadEnd;
				this.OnLoadDynamicAssemblysCompleted(true, onEnd);
				return true;
			}
			this.m_corutineHelper.StartCorutine(this.LoadDynamicAssemblysWorker(delegate(bool lret)
			{
				this.OnLoadDynamicAssemblysCompleted(lret, onEnd);
			}));
			return true;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00011000 File Offset: 0x0000F200
		[DoNotToLua]
		protected virtual void OnLoadDynamicAssemblysCompleted(bool ret, Action<bool> onEnd)
		{
			onEnd(ret);
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0001100C File Offset: 0x0000F20C
		[DoNotToLua]
		private IEnumerator LoadDynamicAssemblysWorker(Action<bool> onEnd)
		{
			foreach (string assemblyName in this.m_gameClientSetting.DynamicAssemblySetting.DynamicAssemblyList)
			{
				string dllAssetName = string.Format("{0}/{1}_ABS/{2}_dll.asset", PathHelper.DynamicAssemblyAssetRoot, assemblyName, assemblyName);
				BytesScripableObject dllAsset = null;
				IEnumerator iter = this.m_resourceManager.LoadAsset<BytesScripableObject>(dllAssetName, delegate(string lpath, BytesScripableObject lasset)
				{
					dllAsset = lasset;
				}, false, false);
				yield return iter;
				if (dllAsset == null)
				{
					global::Debug.LogError(string.Format("LoadDynamicAssemblysWorker fail dllAssetName={0}", dllAssetName));
					onEnd(false);
					yield break;
				}
				global::Debug.LogWarning(string.Format("LoadDynamicAssemblysWorker Assembly.Load dllAsset.bytes={0}", dllAsset.m_size));
				Assembly assembly = AppDomain.CurrentDomain.Load(dllAsset.GetBytes());
				this.m_classLoader.AddAssembly(assembly);
			}
			this.m_state = GameManager.GMState.DynamicAssemblyLoadEnd;
			onEnd(true);
			yield break;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00011030 File Offset: 0x0000F230
		[DoNotToLua]
		public virtual bool StartLuaManager(Action<bool> onEnd)
		{
			if ((this.m_state != GameManager.GMState.Inited && this.m_state != GameManager.GMState.DynamicAssemblyLoadEnd) || this.m_resourceManager.State != ResourceManager.RMState.AssetBundleManifestLoadEnd)
			{
				global::Debug.LogError("StartLuaManager in wrong state");
				return false;
			}
			this.m_state = GameManager.GMState.LuaLoading;
			if (!this.m_gameClientSetting.LuaSetting.EnableLua)
			{
				global::Debug.Log("StartLuaManager skip");
				this.m_state = GameManager.GMState.LuaLoadEnd;
				onEnd(true);
				return true;
			}
			this.m_corutineHelper.StartCorutine(this.m_luaManager.StartLuaSvr(delegate(bool lret)
			{
				if (!lret)
				{
					global::Debug.LogError("StartLuaManager m_luaManager.StartLuaSvr fail");
					onEnd(false);
					return;
				}
				this.m_state = GameManager.GMState.LuaLoadEnd;
				onEnd(true);
			}));
			return true;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x000110E8 File Offset: 0x0000F2E8
		[DoNotToLua]
		public virtual bool StartLoadConfigData(Action<bool> onEnd, out int initLoadDataCount)
		{
			initLoadDataCount = 0;
			if ((this.m_state != GameManager.GMState.DynamicAssemblyLoadEnd && this.m_state != GameManager.GMState.LuaLoadEnd) || this.m_resourceManager.State != ResourceManager.RMState.AssetBundleManifestLoadEnd)
			{
				global::Debug.LogError("StartLoadConfigData in wrong state");
				return false;
			}
			this.m_state = GameManager.GMState.ConfigDataLoading;
			this.m_configDataLoader = (this.m_classLoader.CreateInstance(new TypeDNName(this.m_gameClientSetting.ConfigDataSetting.ConfigDataLoaderTypeDNName), new object[0]) as ClientConfigDataLoaderBase);
			if (this.m_configDataLoader == null)
			{
				global::Debug.LogError("StartLoadConfigData fail can not CreateInstance for m_configDataLoader");
				return false;
			}
			this.m_configDataLoader.ConfigDataAssetAllowNull = this.m_gameClientSetting.ConfigDataSetting.ConfigDataAssetAllowNullSetting;
			return this.m_configDataLoader.StartInitializeFromAsset(delegate(bool resultForConfigDataLoaderInit)
			{
				if (resultForConfigDataLoaderInit)
				{
					this.InitStringTableManager(delegate(bool resultForStringTableManagerInit)
					{
						if (resultForStringTableManagerInit)
						{
							bool hasExtensionProcess = false;
							hasExtensionProcess = this.OnLoadConfigDataEnd(delegate(bool lret)
							{
								if (!hasExtensionProcess)
								{
									throw new ApplicationException("OnLoadConfigDataEnd !hasExtensionProcess but call OnEnd");
								}
								<StartLoadConfigData>c__AnonStorey.m_state = ((!lret) ? <StartLoadConfigData>c__AnonStorey.m_state : GameManager.GMState.ConfigDataLoadEnd);
								onEnd(lret);
							});
							if (!hasExtensionProcess)
							{
								this.m_state = GameManager.GMState.ConfigDataLoadEnd;
								onEnd(true);
							}
						}
						else
						{
							onEnd(false);
						}
					});
				}
				else
				{
					onEnd(false);
				}
			}, out initLoadDataCount);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x000111C4 File Offset: 0x0000F3C4
		protected virtual bool OnLoadConfigDataEnd(Action<bool> onEnd)
		{
			return false;
		}

		// Token: 0x0600037C RID: 892 RVA: 0x000111C8 File Offset: 0x0000F3C8
		[DoNotToLua]
		protected virtual bool InitStringTableManager(Action<bool> onEnd)
		{
			this.m_stringTableManager = (this.m_classLoader.CreateInstance(new TypeDNName(this.m_gameClientSetting.ConfigDataSetting.StringTableManagerTypeDNName), new object[]
			{
				this.m_configDataLoader
			}) as StringTableManagerBase);
			if (this.m_stringTableManager == null)
			{
				global::Debug.LogError("InitStringTableManager fail can not CreateInstance for m_stringTableManager");
				return false;
			}
			if (this.m_configDataLoader.InitLoadDataCount == 0)
			{
				onEnd(true);
				return true;
			}
			this.m_corutineHelper.StartCorutine(this.m_stringTableManager.InitLocalization(this.m_gameClientSetting.StringTableSetting.LocalizationDefault, delegate(bool lret)
			{
				if (!lret)
				{
					global::Debug.LogError("InitStringTableManager fail in InitLocalization");
				}
				onEnd(lret);
			}));
			return true;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00011284 File Offset: 0x0000F484
		[DoNotToLua]
		public T GetConfigData<T>() where T : ClientConfigDataLoaderBase
		{
			return this.m_configDataLoader as T;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00011298 File Offset: 0x0000F498
		[DoNotToLua]
		public virtual bool StartAudioManager(Action<bool> onEnd)
		{
			if (this.m_state != GameManager.GMState.ConfigDataLoadEnd || this.m_resourceManager.State != ResourceManager.RMState.AssetBundleManifestLoadEnd)
			{
				global::Debug.LogError("StartAudioManager in wrong state");
				return false;
			}
			if (this.m_audioManager == null)
			{
				global::Debug.LogError("GameManger.StartAudioManager m_audioManager is null.");
				return false;
			}
			this.m_state = GameManager.GMState.AudioManagerLoading;
			string initAssetPath;
			if (this.m_gameClientSetting.AudioSetting.EnableCRI)
			{
				initAssetPath = this.m_gameClientSetting.AudioSetting.CRIAudioManagerAsset;
			}
			else
			{
				initAssetPath = this.m_gameClientSetting.AudioSetting.AudioMixerAssetPath;
			}
			this.m_corutineHelper.StartCorutine(this.m_audioManager.Start(delegate(bool lret)
			{
				if (!lret)
				{
					global::Debug.LogError("StartAudioManager m_audioManager.Start fail");
					onEnd(false);
					return;
				}
				this.m_state = GameManager.GMState.AudioManagerLoadEnd;
				onEnd(true);
			}, initAssetPath));
			return true;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00011364 File Offset: 0x0000F564
		public virtual bool InitlizeBeforeGameAuthLogin(string loginUserId)
		{
			if (this.m_state != GameManager.GMState.AudioManagerLoadEnd)
			{
				global::Debug.LogError("InitlizeBeforeGameServerLogin in wrong state");
				return false;
			}
			this.LoginUserId = loginUserId;
			if (!this.InitPlayerContext())
			{
				global::Debug.LogError("InitPlayerContext fail");
				return false;
			}
			if (!this.InitGameNetworkClient())
			{
				global::Debug.LogError("InitGameNetworkClient fail");
				return false;
			}
			this.m_playerContext.InitWithNetworkClient(this.m_networkClient);
			return true;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x000113D8 File Offset: 0x0000F5D8
		[DoNotToLua]
		public virtual bool InitGameNetworkClient()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000381 RID: 897 RVA: 0x000113E0 File Offset: 0x0000F5E0
		public virtual bool InitPlayerContext()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000382 RID: 898 RVA: 0x000113E8 File Offset: 0x0000F5E8
		[DoNotToLua]
		public T GetPlayerContext<T>() where T : PlayerContextBase
		{
			return this.m_playerContext as T;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x000113FC File Offset: 0x0000F5FC
		[DoNotToLua]
		public T GetGameManagerParam<T>(string key) where T : class
		{
			object obj;
			if (this.m_gameManagerParamDict.TryGetValue(key, out obj))
			{
				return obj as T;
			}
			return (T)((object)null);
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00011430 File Offset: 0x0000F630
		public void SetGameManagerParam(string key, object value)
		{
			this.m_gameManagerParamDict[key] = value;
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00011440 File Offset: 0x0000F640
		public virtual void Return2Login(bool raiseCriticalDataCacheDirty)
		{
			this.Clear4Return2Login(raiseCriticalDataCacheDirty);
			this.m_uiManager.ReturnToLoginUI();
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00011454 File Offset: 0x0000F654
		public virtual void Clear4Return2Login(bool isCacheDataDirty)
		{
			this.m_playerContext = null;
			if (this.m_networkClient != null)
			{
				this.m_networkClient.Close();
				this.m_networkClient = null;
			}
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0001147C File Offset: 0x0000F67C
		public virtual void Clear4Relogin()
		{
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00011480 File Offset: 0x0000F680
		public void StartCorutine(Func<IEnumerator> corutine)
		{
			this.m_corutineHelper.StartCorutine(corutine);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00011490 File Offset: 0x0000F690
		public void StartCorutine(IEnumerator corutine)
		{
			this.m_corutineHelper.StartCorutine(corutine);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x000114A0 File Offset: 0x0000F6A0
		public virtual void Tick()
		{
			try
			{
				this.m_corutineHelper.Tick();
				Timer.Tick();
				if (this.m_playerContext != null)
				{
					this.m_playerContext.Tick();
				}
				this.m_taskManager.Tick();
				this.m_resourceManager.Tick();
				if (this.m_audioManager != null)
				{
					this.m_audioManager.Tick();
				}
				this.m_sceneManager.Tick();
				this.m_uiManager.Tick();
			}
			catch (Exception ex)
			{
				global::Debug.LogError(ex.Message + "\n" + ex.StackTrace);
				throw;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600038B RID: 907 RVA: 0x00011548 File Offset: 0x0000F748
		public static GameManager Instance
		{
			get
			{
				return GameManager.m_instance;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600038C RID: 908 RVA: 0x00011550 File Offset: 0x0000F750
		public GameClientSetting GameClientSetting
		{
			get
			{
				return this.m_gameClientSetting;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600038D RID: 909 RVA: 0x00011558 File Offset: 0x0000F758
		// (set) Token: 0x0600038E RID: 910 RVA: 0x00011560 File Offset: 0x0000F760
		public static Func<ResourceManager> CreateResourceManagerHandler { get; set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600038F RID: 911 RVA: 0x00011568 File Offset: 0x0000F768
		public IAudioManager AudioManager
		{
			get
			{
				return this.m_audioManager;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000390 RID: 912 RVA: 0x00011570 File Offset: 0x0000F770
		public ClientConfigDataLoaderBase ConfigDataLoader
		{
			get
			{
				return this.m_configDataLoader;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000391 RID: 913 RVA: 0x00011578 File Offset: 0x0000F778
		public StringTableManagerBase StringTableManager
		{
			get
			{
				return this.m_stringTableManager;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000392 RID: 914 RVA: 0x00011580 File Offset: 0x0000F780
		public IPlayerContextNetworkClient NetworkClient
		{
			get
			{
				return this.m_networkClient;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000393 RID: 915 RVA: 0x00011588 File Offset: 0x0000F788
		public PlayerContextBase PlayerContext
		{
			get
			{
				return this.m_playerContext;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000394 RID: 916 RVA: 0x00011590 File Offset: 0x0000F790
		// (set) Token: 0x06000395 RID: 917 RVA: 0x00011598 File Offset: 0x0000F798
		public string LoginUserId { get; protected set; }

		// Token: 0x04000170 RID: 368
		private static GameManager m_instance;

		// Token: 0x04000171 RID: 369
		protected GameManager.GMState m_state;

		// Token: 0x04000172 RID: 370
		private TinyCorutineHelper m_corutineHelper = new TinyCorutineHelper();

		// Token: 0x04000173 RID: 371
		protected GameClientSetting m_gameClientSetting;

		// Token: 0x04000174 RID: 372
		protected LogManager m_logManager;

		// Token: 0x04000175 RID: 373
		protected TaskManager m_taskManager;

		// Token: 0x04000176 RID: 374
		protected ResourceManager m_resourceManager;

		// Token: 0x04000178 RID: 376
		protected IAudioManager m_audioManager;

		// Token: 0x04000179 RID: 377
		protected SceneManager m_sceneManager;

		// Token: 0x0400017A RID: 378
		protected UIManager m_uiManager;

		// Token: 0x0400017B RID: 379
		protected ClassLoader m_classLoader;

		// Token: 0x0400017C RID: 380
		protected LuaManager m_luaManager;

		// Token: 0x0400017D RID: 381
		protected ClientConfigDataLoaderBase m_configDataLoader;

		// Token: 0x0400017E RID: 382
		protected StringTableManagerBase m_stringTableManager;

		// Token: 0x0400017F RID: 383
		protected IPlayerContextNetworkClient m_networkClient;

		// Token: 0x04000180 RID: 384
		protected PlayerContextBase m_playerContext;

		// Token: 0x04000182 RID: 386
		protected Dictionary<string, object> m_gameManagerParamDict = new Dictionary<string, object>();

		// Token: 0x02000046 RID: 70
		public enum GMState
		{
			// Token: 0x04000184 RID: 388
			None,
			// Token: 0x04000185 RID: 389
			Inited,
			// Token: 0x04000186 RID: 390
			DynamicAssemblyLoading,
			// Token: 0x04000187 RID: 391
			DynamicAssemblyLoadEnd,
			// Token: 0x04000188 RID: 392
			LuaLoading,
			// Token: 0x04000189 RID: 393
			LuaLoadEnd,
			// Token: 0x0400018A RID: 394
			ConfigDataLoading,
			// Token: 0x0400018B RID: 395
			ConfigDataLoadEnd,
			// Token: 0x0400018C RID: 396
			AudioManagerLoading,
			// Token: 0x0400018D RID: 397
			AudioManagerLoadEnd,
			// Token: 0x0400018E RID: 398
			Ready = 9
		}
	}
}
