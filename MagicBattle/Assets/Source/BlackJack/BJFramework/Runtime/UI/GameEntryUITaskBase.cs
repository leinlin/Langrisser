using System;
using System.Collections;
using BlackJack.BJFramework.Runtime.Resource;

namespace BlackJack.BJFramework.Runtime.UI
{
	// Token: 0x020000F2 RID: 242
	public abstract class GameEntryUITaskBase : UITaskBase
	{
		// Token: 0x060008E0 RID: 2272 RVA: 0x0002771C File Offset: 0x0002591C
		public GameEntryUITaskBase(string name) : base(name)
		{
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00027728 File Offset: 0x00025928
		protected override void PostUpdateView()
		{
			if (ResourceManager.Instance.State == ResourceManager.RMState.Inited)
			{
				this.m_corutineHelper.StartCorutine(new Func<IEnumerator>(this.EntryPipeLine));
				return;
			}
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00027754 File Offset: 0x00025954
		protected virtual IEnumerator DownloadAudioFiles()
		{
			yield break;
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00027768 File Offset: 0x00025968
		protected virtual IEnumerator EntryPipeLine()
		{
			bool? ret = null;
			ResourceManager.Instance.CheckBundleCache();
			this.OnStreamingAssetsFilesProcessingStart();
			bool tret;
			ResourceManager.Instance.StartStreamingAssetsFilesProcessing(delegate(bool lret)
			{
				tret = lret;
				ret = new bool?(lret);
				this.OnStreamingAssetsFilesProcessingEnd(lret);
			});
			while (ret == null)
			{
				yield return null;
			}
			if (!ret.Value)
			{
				Debug.LogError("EntryPipeLine fail after StartStreamingAssetsFilesProcessing");
				yield break;
			}
			ret = null;
			this.OnBundleDataLoadingStart();
			ResourceManager.Instance.StartBundleDataLoading(delegate(bool lret)
			{
				tret = lret;
				ret = new bool?(lret);
				this.OnBundleDataLoadingEnd(lret);
			});
			while (ret == null)
			{
				yield return null;
			}
			if (!ret.Value)
			{
				Debug.LogError("EntryPipeLine fail after StartBundleDataLoading");
				yield break;
			}
			ret = null;
			if (!GameManager.Instance.GameClientSetting.ResourcesSetting.DisableAssetBundleDownload && GameManager.Instance.GameClientSetting.LoginSetting.BasicVersion != ResourceManager.Instance.GetBundleDataBasicVersion())
			{
				Debug.LogError(string.Format("EntryPipeLine fail, BasicVersion Unmatch: ClientBasicVersion = {0}, NewBasicVersion = {1}", GameManager.Instance.GameClientSetting.LoginSetting.BasicVersion, ResourceManager.Instance.GetBundleDataBasicVersion()));
				yield return this.OnBasicVersionUnmatch();
				yield break;
			}
			long totalDownloadByte = ResourceManager.Instance.GetTotalPreUpdateingDownloadBytes();
			if (totalDownloadByte != 0L)
			{
				Debug.Log(string.Format("NotifyUserDownloadAndWait bytes={0}", totalDownloadByte));
				this.NotifyUserDownloadAndWait(totalDownloadByte);
				for (;;)
				{
					bool? startBundlePreDownloadByPlayer = this.m_startBundlePreDownloadByPlayer;
					if (startBundlePreDownloadByPlayer != null)
					{
						break;
					}
					yield return null;
				}
				if (!this.m_startBundlePreDownloadByPlayer.Value)
				{
					Debug.Log("BundlePreUpdateing cancel by player");
					this.OnAssetBundlePreUpdateingRefuse();
					yield break;
				}
				this.OnAssetBundlePreUpdateingStart();
				ResourceManager.Instance.StartAssetBundlePreUpdateing(delegate(bool lret)
				{
					tret = lret;
					ret = new bool?(lret);
					this.OnAssetBundlePreUpdateingEnd(lret);
				});
				while (ret == null)
				{
					yield return null;
				}
				if (!ret.Value)
				{
					Debug.LogError("EntryPipeLine fail after StartAssetBundlePreUpdateing");
					yield break;
				}
				ret = null;
			}
			this.OnAssetBundleManifestLoadingStart();
			ResourceManager.Instance.StartAssetBundleManifestLoading(delegate(bool lret)
			{
				tret = lret;
				ret = new bool?(lret);
				this.OnAssetBundleManifestLoadingEnd(lret);
			});
			while (ret == null)
			{
				yield return null;
			}
			if (!ret.Value)
			{
				Debug.LogError("EntryPipeLine fail after StartAssetBundleManifestLoading");
				yield break;
			}
			ret = null;
			yield return this.DownloadAudioFiles();
			if (!GameManager.Instance.InitlizeAudioManager())
			{
				Debug.LogError("GameEntryUITaskBase.EntryPipeLine Failed to InitlizeAudioManager.");
				yield break;
			}
			this.OnLoadDynamicAssemblysStart();
			GameManager.Instance.StartLoadDynamicAssemblys(delegate(bool lret)
			{
				tret = lret;
				ret = new bool?(lret);
				this.OnLoadDynamicAssemblysEnd(lret);
			});
			while (ret == null)
			{
				yield return null;
			}
			if (!ret.Value)
			{
				Debug.LogError("EntryPipeLine fail after StartLoadDynamicAssemblys");
				yield break;
			}
			ret = null;
			this.OnStartLuaManagerStart();
			GameManager.Instance.StartLuaManager(delegate(bool lret)
			{
				tret = lret;
				ret = new bool?(lret);
				this.OnStartLuaManagerEnd(lret);
			});
			while (ret == null)
			{
				yield return null;
			}
			if (!ret.Value)
			{
				Debug.LogError("EntryPipeLine fail after StartLuaManager");
				yield break;
			}
			ret = null;
			this.OnLoadConfigDataStart();
			GameManager.Instance.StartLoadConfigData(delegate(bool lret)
			{
				tret = lret;
				ret = new bool?(lret);
				this.OnLoadConfigDataEnd(lret);
			}, out this.m_configDataInitLoadCount);
			while (ret == null)
			{
				yield return null;
			}
			if (!ret.Value)
			{
				Debug.LogError("EntryPipeLine fail after StartLoadConfigData");
				yield break;
			}
			ret = null;
			this.OnStartAudioManagerStart();
			GameManager.Instance.StartAudioManager(delegate(bool lret)
			{
				tret = lret;
				ret = new bool?(lret);
				this.OnStartAudioManagerEnd(lret);
			});
			while (ret == null)
			{
				yield return null;
			}
			if (!ret.Value)
			{
				Debug.LogError("EntryPipeLine fail after StartAudioManager");
				yield break;
			}
			ret = null;
			ret = new bool?(this.InitUITaskRegister());
			if (!ret.Value)
			{
				Debug.LogError("EntryPipeLine fail in InitUITaskRegister");
				yield break;
			}
			ret = null;
			this.LaunchLogin();
			yield break;
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00027784 File Offset: 0x00025984
		protected virtual void OnStreamingAssetsFilesProcessingStart()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x0002778C File Offset: 0x0002598C
		protected virtual void OnStreamingAssetsFilesProcessingEnd(bool ret)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x00027794 File Offset: 0x00025994
		protected virtual void OnBundleDataLoadingStart()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x0002779C File Offset: 0x0002599C
		protected virtual void OnBundleDataLoadingEnd(bool ret)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x000277A4 File Offset: 0x000259A4
		protected virtual IEnumerator OnBasicVersionUnmatch()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x000277AC File Offset: 0x000259AC
		protected virtual void NotifyUserDownloadAndWait(long totalDownloadByte)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x000277B4 File Offset: 0x000259B4
		public void StartPreDownload()
		{
			this.m_startBundlePreDownloadByPlayer = new bool?(true);
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x000277C4 File Offset: 0x000259C4
		public void RefusePreDownload()
		{
			this.m_startBundlePreDownloadByPlayer = new bool?(false);
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x000277D4 File Offset: 0x000259D4
		protected virtual void OnAssetBundlePreUpdateingRefuse()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x000277DC File Offset: 0x000259DC
		protected virtual void OnAssetBundlePreUpdateingStart()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x000277E4 File Offset: 0x000259E4
		protected virtual void OnAssetBundlePreUpdateingEnd(bool ret)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x000277EC File Offset: 0x000259EC
		protected virtual void OnAssetBundleManifestLoadingStart()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x000277F4 File Offset: 0x000259F4
		protected virtual void OnAssetBundleManifestLoadingEnd(bool ret)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x000277FC File Offset: 0x000259FC
		protected virtual void OnLoadDynamicAssemblysStart()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00027804 File Offset: 0x00025A04
		protected virtual void OnLoadDynamicAssemblysEnd(bool ret)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x0002780C File Offset: 0x00025A0C
		protected virtual void OnStartLuaManagerStart()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00027814 File Offset: 0x00025A14
		protected virtual void OnStartLuaManagerEnd(bool ret)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x0002781C File Offset: 0x00025A1C
		protected virtual void OnLoadConfigDataStart()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00027824 File Offset: 0x00025A24
		protected virtual void OnLoadConfigDataEnd(bool ret)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x0002782C File Offset: 0x00025A2C
		protected virtual void OnStartAudioManagerStart()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00027834 File Offset: 0x00025A34
		protected virtual void OnStartAudioManagerEnd(bool ret)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x0002783C File Offset: 0x00025A3C
		protected virtual bool InitUITaskRegister()
		{
			if (ClassLoader.Instance.CreateInstance(new TypeDNName(GameManager.Instance.GameClientSetting.UITaskRegisterTypeDNName), new object[0]) == null)
			{
				Debug.LogError("UITaskRegister fail");
				return false;
			}
			return true;
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00027884 File Offset: 0x00025A84
		protected virtual void LaunchLogin()
		{
			Debug.Log("GameEntryUITaskBase.LaunchLogin");
			base.Stop();
			if (UIManager.Instance.StartUITask(new UIIntent("LoginUITask", null), true, false, null) == null)
			{
				Debug.LogError("StartUITask for LoginUITask fail");
				return;
			}
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x000278CC File Offset: 0x00025ACC
		protected override void OnTick()
		{
			this.m_corutineHelper.Tick();
			switch (ResourceManager.Instance.State)
			{
			case ResourceManager.RMState.StreamingAssetsFilesProcessing:
				this.UpdateView4StreamingAssetsFilesProcessing();
				break;
			case ResourceManager.RMState.BundleDataLoading:
				this.UpdateView4BundleDataLoading();
				break;
			case ResourceManager.RMState.AssetBundlePreUpdateing:
				this.UpdateView4AssetBundlePreUpdateing();
				break;
			case ResourceManager.RMState.AssetBundleManifestLoading:
				this.UpdateView4AssetBundleManifestLoading();
				break;
			}
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x0002794C File Offset: 0x00025B4C
		protected virtual void UpdateView4StreamingAssetsFilesProcessing()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x00027954 File Offset: 0x00025B54
		protected virtual void UpdateView4BundleDataLoading()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x0002795C File Offset: 0x00025B5C
		protected virtual void UpdateView4AssetBundlePreUpdateing()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x00027964 File Offset: 0x00025B64
		protected virtual void UpdateView4AssetBundleManifestLoading()
		{
			throw new NotImplementedException();
		}

		// Token: 0x040005AA RID: 1450
		protected bool? m_startBundlePreDownloadByPlayer;

		// Token: 0x040005AB RID: 1451
		protected int m_configDataInitLoadCount;
	}
}
