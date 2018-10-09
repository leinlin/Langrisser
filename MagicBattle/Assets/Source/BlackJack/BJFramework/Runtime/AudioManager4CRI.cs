using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using BlackJack.Utils;
using SLua;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x02000009 RID: 9
	[CustomLuaClass]
	public class AudioManager4CRI : IAudioManager, ITickable
	{
		// Token: 0x060001D2 RID: 466 RVA: 0x00009AC0 File Offset: 0x00007CC0
		public static IEnumerator DownloadAudioFiles(Action<bool> onEnd, Action<long, long> onUpdate = null, Action<long> onEndAfterGotDownloadLength = null, MonoBehaviour coroutineOwner = null)
		{
			if (GameManager.Instance == null || GameManager.Instance.GameClientSetting == null)
			{
				yield break;
			}
			if (!GameManager.Instance.GameClientSetting.AudioSetting.EnableDownload)
			{
				yield break;
			}
			if (!AudioManager4CRI.LoadAllFilesPaths())
			{
				global::Debug.LogError("AudioManager4CRI.DownloadAudioFiles Failed to LoadAllFilesPaths().");
				yield break;
			}
			bool isSuccess = false;
			string serverFileListMd5 = string.Empty;
			yield return Util.DownloadHttpFile(string.Format("{0}/{1}", AudioManager4CRI.DownloadUrlRoot, "AllFilesPath.txt.md5"), delegate(bool ret, WWW www)
			{
				isSuccess = ret;
				if (ret)
				{
					serverFileListMd5 = www.text;
				}
			}, null);
			if (!isSuccess)
			{
				global::Debug.LogError("AudioManager4CRI.DownloadAudioFiles download filelist's md5 Failed .");
				if (onEnd != null)
				{
					onEnd(false);
				}
				yield break;
			}
			string localFileListMd5 = AudioManager4CRI.LoadTextFile(string.Format("{0}/{1}", AudioManager4CRI.CacheFolderPath, "ServerAllFilesPath.txt.md5"));
			if (string.IsNullOrEmpty(localFileListMd5) || localFileListMd5 != serverFileListMd5)
			{
				yield return Util.DownloadHttpFile(string.Format("{0}/{1}", AudioManager4CRI.DownloadUrlRoot, "AllFilesPath.txt"), delegate(bool ret, WWW www)
				{
					isSuccess = ret;
					if (ret)
					{
						try
						{
							if (!Directory.Exists(AudioManager4CRI.CacheFolderPath))
							{
								Directory.CreateDirectory(AudioManager4CRI.CacheFolderPath);
							}
							File.WriteAllText(string.Format("{0}/{1}", AudioManager4CRI.CacheFolderPath, "ServerAllFilesPath.txt"), www.text);
							File.WriteAllText(string.Format("{0}/{1}", AudioManager4CRI.CacheFolderPath, "ServerAllFilesPath.txt.md5"), serverFileListMd5);
						}
						catch (Exception ex)
						{
							global::Debug.LogError(string.Format("AudioManager4CRI.DownloadAudioFiles exception: {0}", ex.Message));
							isSuccess = false;
						}
					}
				}, null);
				if (!isSuccess)
				{
					global::Debug.LogError("AudioManager4CRI.DownloadAudioFiles download filelist Failed .");
					if (onEnd != null)
					{
						onEnd(false);
					}
					yield break;
				}
			}
			AudioManager4CRI.m_serverCriAssetFileInfos = AudioManager4CRI.LoadFileInfos(string.Format("{0}/{1}", AudioManager4CRI.CacheFolderPath, "ServerAllFilesPath.txt"));
			AudioManager4CRI.m_cacheCriAssetFileInfos = AudioManager4CRI.LoadFileInfos(string.Format("{0}/{1}", AudioManager4CRI.CacheFolderPath, "AllFilesPath.txt"));
			List<AudioManager4CRI.FileInfo> differentFileInfos = AudioManager4CRI.DifferentiateFileInfos(AudioManager4CRI.m_serverCriAssetFileInfos, AudioManager4CRI.m_clientCriAssetFileInfos, AudioManager4CRI.m_cacheCriAssetFileInfos);
			long totalDownloadLength = AudioManager4CRI.GetTotalFileLengh(differentFileInfos);
			if (onEndAfterGotDownloadLength != null)
			{
				onEndAfterGotDownloadLength(totalDownloadLength);
				yield break;
			}
			long downloadedLength = 0L;
			if (coroutineOwner == null || coroutineOwner.gameObject == null || !coroutineOwner.gameObject.activeInHierarchy)
			{
				using (List<AudioManager4CRI.FileInfo>.Enumerator enumerator = differentFileInfos.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						AudioManager4CRI.FileInfo i = enumerator.Current;
						yield return AudioManager4CRI.DownloadAudioFileToCache(i, delegate(bool ret)
						{
							if (!ret)
							{
								global::Debug.LogError(string.Format("AudioManager4CRI.DownloadAudioFiles download audio file {0} Failed .", i.m_path));
								isSuccess = false;
							}
							else
							{
								downloadedLength += i.m_length;
							}
							if (!AudioManager4CRI.SaveFileInfos(Path.Combine(AudioManager4CRI.CacheFolderPath, "AllFilesPath.txt"), AudioManager4CRI.m_cacheCriAssetFileInfos))
							{
								global::Debug.LogError("AudioManager4CRI.DownloadAudioFiles save cache filelist Failed .");
								isSuccess = false;
							}
						}, delegate(WWW www)
						{
							if (onUpdate != null)
							{
								onUpdate(downloadedLength + (long)www.bytesDownloaded, totalDownloadLength);
							}
						});
					}
				}
			}
			else
			{
				int downloadCoroutinCount = 0;
				HashSet<WWW> runningWWW = new HashSet<WWW>();
				using (List<AudioManager4CRI.FileInfo>.Enumerator enumerator2 = differentFileInfos.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						AudioManager4CRI.FileInfo i = enumerator2.Current;
						yield return new WaitUntil(() => downloadCoroutinCount < 4);
						downloadCoroutinCount++;
						coroutineOwner.StartCoroutine(AudioManager4CRI.DownloadAudioFileToCache(i, delegate(bool ret)
						{
							if (!ret)
							{
								global::Debug.LogError(string.Format("AudioManager4CRI.DownloadAudioFiles download audio file {0} Failed .", i.m_path));
								isSuccess = false;
							}
							else
							{
								downloadedLength += i.m_length;
							}
							if (!AudioManager4CRI.SaveFileInfos(Path.Combine(AudioManager4CRI.CacheFolderPath, "AllFilesPath.txt"), AudioManager4CRI.m_cacheCriAssetFileInfos))
							{
								global::Debug.LogError("AudioManager4CRI.DownloadAudioFiles save cache filelist Failed .");
								isSuccess = false;
							}
							downloadCoroutinCount--;
						}, delegate(WWW www)
						{
							if (!runningWWW.Contains(www) && !www.isDone)
							{
								runningWWW.Add(www);
							}
							long num = 0L;
							foreach (WWW www2 in runningWWW)
							{
								num += (long)www2.bytesDownloaded;
							}
							if (onUpdate != null)
							{
								onUpdate(downloadedLength + num, totalDownloadLength);
							}
							if (runningWWW.Contains(www) && www.isDone)
							{
								runningWWW.Remove(www);
							}
						}));
					}
				}
				yield return new WaitUntil(() => downloadCoroutinCount == 0);
			}
			if (!isSuccess)
			{
				if (onEnd != null)
				{
					onEnd(false);
				}
				yield break;
			}
			if (onEnd != null)
			{
				onEnd(true);
			}
			yield break;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00009AF0 File Offset: 0x00007CF0
		private static long GetTotalFileLengh(List<AudioManager4CRI.FileInfo> fileList)
		{
			long num = 0L;
			foreach (AudioManager4CRI.FileInfo fileInfo in fileList)
			{
				num += fileInfo.m_length;
			}
			return num;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00009B50 File Offset: 0x00007D50
		private static bool SaveFileInfos(string filepath, List<AudioManager4CRI.FileInfo> fileInfos)
		{
			bool result;
			try
			{
				StringBuilder stringBuilder = new StringBuilder();
				foreach (AudioManager4CRI.FileInfo fileInfo in fileInfos)
				{
					stringBuilder.AppendLine(string.Format("{0},{1},{2}", fileInfo.m_path, fileInfo.m_md5, fileInfo.m_length));
				}
				File.WriteAllText(filepath, stringBuilder.ToString());
				result = true;
			}
			catch (Exception ex)
			{
				global::Debug.LogError("AudioManager4CRI.SaveFileInfos exception: " + ex.Message);
				result = false;
			}
			return result;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00009C10 File Offset: 0x00007E10
		private static IEnumerator DownloadAudioFileToCache(AudioManager4CRI.FileInfo fi, Action<bool> onEnd, Action<WWW> onUpdate = null)
		{
			byte[] fileData = null;
			yield return Util.DownloadHttpFile(string.Format("{0}/{1}", AudioManager4CRI.DownloadUrlRoot, fi.m_path), delegate(bool ret, WWW www)
			{
				if (!ret)
				{
					if (onEnd != null)
					{
						onEnd(ret);
					}
					return;
				}
				fileData = www.bytes;
			}, onUpdate);
			if (fileData == null)
			{
				onEnd(false);
				yield break;
			}
			try
			{
				string path = string.Format("{0}/{1}", AudioManager4CRI.CacheFolderPath, fi.m_path);
				string directoryName = Path.GetDirectoryName(path);
				if (!Directory.Exists(directoryName))
				{
					Directory.CreateDirectory(directoryName);
				}
				File.WriteAllBytes(path, fileData);
				int num = AudioManager4CRI.m_cacheCriAssetFileInfos.FindIndex((AudioManager4CRI.FileInfo info) => fi.m_path == info.m_path);
				if (num >= 0)
				{
					AudioManager4CRI.m_cacheCriAssetFileInfos.RemoveAt(num);
				}
				AudioManager4CRI.m_cacheCriAssetFileInfos.Add(fi);
			}
			catch (Exception ex)
			{
				global::Debug.LogError("AudioManager4CRI.DownloadAudioFileToCache exception: " + ex.Message);
				onEnd(false);
				yield break;
			}
			if (onEnd != null)
			{
				onEnd(true);
			}
			yield break;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00009C3C File Offset: 0x00007E3C
		private static List<AudioManager4CRI.FileInfo> DifferentiateFileInfos(List<AudioManager4CRI.FileInfo> serverInfos, List<AudioManager4CRI.FileInfo> clientInfos, List<AudioManager4CRI.FileInfo> cacheInfos)
		{
			List<AudioManager4CRI.FileInfo> list = new List<AudioManager4CRI.FileInfo>();
			if (serverInfos == null || clientInfos == null)
			{
				return list;
			}
			for (int j = 0; j < serverInfos.Count; j++)
			{
				AudioManager4CRI.FileInfo i = serverInfos[j];
				if (!i.m_path.Contains("AllFilesPath.txt"))
				{
					if (!clientInfos.Exists((AudioManager4CRI.FileInfo info) => info.m_path == i.m_path && info.m_md5 == i.m_md5))
					{
						i.m_isAtClient = false;
						serverInfos[j] = i;
						if (cacheInfos == null || !cacheInfos.Exists((AudioManager4CRI.FileInfo info) => info.m_path == i.m_path && info.m_md5 == i.m_md5))
						{
							list.Add(i);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x00009D0C File Offset: 0x00007F0C
		public static string CacheFolderPath
		{
			get
			{
				return string.Format("{0}/{1}", Application.persistentDataPath, GameManager.Instance.GameClientSetting.AudioSetting.CRIAudioManagerAsset);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00009D34 File Offset: 0x00007F34
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x00009D3C File Offset: 0x00007F3C
		public static string DownloadUrlRoot { get; set; }

		// Token: 0x060001DA RID: 474 RVA: 0x00009D44 File Offset: 0x00007F44
		private List<string> GetResourceFiles(string endStr)
		{
			if (AudioManager4CRI.m_clientCriAssetFileInfos == null)
			{
				global::Debug.LogError("AudioManager4CRI.GetResourceFiles m_criAssetFileInfos is null.");
				return null;
			}
			List<AudioManager4CRI.FileInfo> list = (AudioManager4CRI.m_serverCriAssetFileInfos != null && AudioManager4CRI.m_serverCriAssetFileInfos.Count != 0 && AudioManager4CRI.m_cacheCriAssetFileInfos != null && AudioManager4CRI.m_cacheCriAssetFileInfos.Count != 0) ? AudioManager4CRI.m_serverCriAssetFileInfos : AudioManager4CRI.m_clientCriAssetFileInfos;
			return list.FindAll(delegate(AudioManager4CRI.FileInfo fi)
			{
				if (endStr[0] == '.' || endStr[0] == '/')
				{
					return fi.m_path.ToLower().EndsWith(endStr.ToLower());
				}
				return fi.m_path.ToLower().EndsWith("/" + endStr.ToLower()) || fi.m_path.ToLower() == endStr.ToLower();
			}).ConvertAll<string>(delegate(AudioManager4CRI.FileInfo fi)
			{
				if (fi.m_isAtClient)
				{
					return Path.Combine(this.GetCRIResourcePath(), fi.m_path);
				}
				return Path.Combine(AudioManager4CRI.CacheFolderPath, fi.m_path);
			});
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00009DE0 File Offset: 0x00007FE0
		private void UpdateSheet()
		{
			if ((int)(Time.time * 0.3f) <= (int)((Time.time - Time.deltaTime) * 0.3f))
			{
				return;
			}
			List<IAudioPlayback> list = new List<IAudioPlayback>();
			List<string> list2 = new List<string>();
			foreach (KeyValuePair<string, AudioManager4CRI.PlaybacksOfSheet> keyValuePair in this.m_playbacksOfSheets)
			{
				list.Clear();
				foreach (IAudioPlayback audioPlayback in keyValuePair.Value.m_playbacks)
				{
					if (audioPlayback.IsStoped())
					{
						list.Add(audioPlayback);
					}
				}
				foreach (IAudioPlayback item in list)
				{
					keyValuePair.Value.m_playbacks.Remove(item);
					if (keyValuePair.Value.m_playbacks.Count == 0)
					{
						keyValuePair.Value.m_removeTime = Time.time + 15f;
					}
				}
				if (Time.time > keyValuePair.Value.m_removeTime)
				{
					list2.Add(keyValuePair.Key);
				}
			}
			foreach (string text in list2)
			{
				this.m_CRIProvider.CRIRemoveCueSheet(text);
				this.m_playbacksOfSheets.Remove(text);
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00009FFC File Offset: 0x000081FC
		public void SetVolume(string category, float volume, bool isSmooth)
		{
			if (isSmooth)
			{
				this.m_corutineHelper.StartCorutine(this.SetVolumeSmoothly(category, volume));
			}
			else
			{
				this.m_CRIProvider.SetCategoryVolume(category, volume);
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000A02C File Offset: 0x0000822C
		private IEnumerator SetVolumeSmoothly(string category, float volume)
		{
			float lastTime = Time.time;
			float initVolume = this.m_CRIProvider.GetCategoryVolume(category);
			float curVolume = initVolume;
			for (;;)
			{
				float deltaVolume = (volume - initVolume) * (Time.time - lastTime) * 1.42857146f;
				curVolume += deltaVolume;
				if ((volume - curVolume) * (volume - curVolume + deltaVolume) < 0f)
				{
					curVolume = volume;
				}
				this.m_CRIProvider.SetCategoryVolume(category, curVolume);
				if (curVolume == volume)
				{
					break;
				}
				lastTime = Time.time;
				yield return null;
			}
			yield break;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000A058 File Offset: 0x00008258
		public float GetVolume(string category)
		{
			return this.m_CRIProvider.GetCategoryVolume(category);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000A068 File Offset: 0x00008268
		public static AudioManager4CRI CreateAudioManager()
		{
			if (AudioManager4CRI.m_instance == null)
			{
				AudioManager4CRI.m_instance = new AudioManager4CRI();
			}
			return AudioManager4CRI.m_instance;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000A084 File Offset: 0x00008284
		public bool Initlize()
		{
			global::Debug.Log(string.Format("AudioManager4CRI.Initlize start", new object[0]));
			this.m_muteSound = false;
			if (AudioManager4CRI.m_criProviderType == null)
			{
				global::Debug.LogError("AudioManager4CRI.Initialize() m_CriProviderType is null.");
				return false;
			}
			this.m_CRIProvider = (Activator.CreateInstance(AudioManager4CRI.m_criProviderType) as ICRIProvider);
			if (this.m_CRIProvider == null)
			{
				global::Debug.LogError("Failed to create ICRIProvider by m_criProviderType.");
				return false;
			}
			if (!AudioManager4CRI.LoadAllFilesPaths())
			{
				global::Debug.LogError("AudioManager4CRI.Initialize Failed to LoadAllFilesPaths().");
				return false;
			}
			bool result;
			try
			{
				if (this.m_CRIProvider.GetCRIManagerObject() == null)
				{
					global::Debug.LogError("Failed to initialize AduioManager4Cri, Cri Ware created failed");
					result = false;
				}
				else
				{
					this.CreateCRI();
					this.CreatePlayerVoiceSource();
					List<string> resourceFiles = this.GetResourceFiles(".acf");
					if (resourceFiles.Count == 0)
					{
						global::Debug.LogError("Failed to initialize AduioManager4Cri, acf file not found!");
						result = false;
					}
					else if (resourceFiles.Count != 1)
					{
						global::Debug.LogError("Failed to initialize AduioManager4Cri, found more than one .acf files!");
						result = false;
					}
					else
					{
						this.m_criDesc.m_acfFullPath = resourceFiles[0];
						this.m_CRIProvider.CriRegisterAcf(this.m_criDesc.m_acfFullPath);
						result = true;
					}
				}
			}
			catch (Exception ex)
			{
				global::Debug.LogError("AudioManager4CRI.Start() failed, error: " + ex.Message);
				result = true;
			}
			return result;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000A1DC File Offset: 0x000083DC
		public void Pause(bool pause)
		{
			this.m_CRIProvider.Pause(pause);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000A1EC File Offset: 0x000083EC
		public static List<AudioManager4CRI.FileInfo> ParseFileInfosText(string text)
		{
			List<AudioManager4CRI.FileInfo> list = new List<AudioManager4CRI.FileInfo>();
			if (string.IsNullOrEmpty(text))
			{
				return list;
			}
			foreach (string text2 in text.Split(new char[]
			{
				'\n'
			}))
			{
				if (!string.IsNullOrEmpty(text2))
				{
					string[] array2 = text2.Trim().Split(new char[]
					{
						','
					});
					if (array2.Length >= 3)
					{
						list.Add(new AudioManager4CRI.FileInfo(array2[0], array2[1], long.Parse(array2[2]), true));
					}
				}
			}
			return list;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000A28C File Offset: 0x0000848C
		private static bool LoadAllFilesPaths()
		{
			string assetPath = Path.Combine(GameManager.Instance.GameClientSetting.AudioSetting.CRIAudioManagerAsset, "AllFilesPath.txt");
			AudioManager4CRI.m_clientCriAssetFileInfos = AudioManager4CRI.LoadFileInfos(Util.GetFileStreamingAssetsPath4WWW(assetPath));
			if (AudioManager4CRI.m_clientCriAssetFileInfos == null)
			{
				global::Debug.LogError("AudioManager4CRI.LoadFileInfos Error: m_criAssetFileInfos == null ");
				return false;
			}
			return true;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000A2E0 File Offset: 0x000084E0
		public static string LoadTextFile(string filepath)
		{
			string result;
			try
			{
				if (filepath.Contains(AudioManager4CRI.CacheFolderPath))
				{
					if (!File.Exists(filepath))
					{
						result = null;
					}
					else
					{
						result = File.ReadAllText(filepath);
					}
				}
				else
				{
					if (!filepath.Contains("://"))
					{
						filepath = string.Format("file://{0}", filepath);
					}
					WWW www = new WWW(filepath);
					while (!www.isDone)
					{
					}
					if (!string.IsNullOrEmpty(www.error))
					{
						global::Debug.LogError(string.Format("AudioManager4CRI.LoadTextFile {0} Error: {1}", filepath, www.error));
						result = null;
					}
					else
					{
						result = www.text;
					}
				}
			}
			catch (Exception ex)
			{
				global::Debug.LogError(string.Format("AudioManager4CRI.LoadTextFile exception: {0}", ex.Message));
				result = null;
			}
			return result;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000A3B8 File Offset: 0x000085B8
		public static List<AudioManager4CRI.FileInfo> LoadFileInfos(string filepath)
		{
			return AudioManager4CRI.ParseFileInfosText(AudioManager4CRI.LoadTextFile(filepath));
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000A3C8 File Offset: 0x000085C8
		public void Uninitlize()
		{
			global::Debug.Log(string.Format("AudioManager4CRI.Uninitlize", new object[0]));
			this.StopAll();
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x0000A3F4 File Offset: 0x000085F4
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x0000A3E8 File Offset: 0x000085E8
		public ICRIProvider CRIProvider
		{
			get
			{
				return this.m_CRIProvider;
			}
			set
			{
				this.m_CRIProvider = value;
			}
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000A3FC File Offset: 0x000085FC
		private string GetCRIResourcePath()
		{
			return "CRIRes";
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000A404 File Offset: 0x00008604
		public IEnumerator Start(Action<bool> onEnd, string criAudioManagerAssetPath)
		{
			onEnd(true);
			yield break;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000A420 File Offset: 0x00008620
		private bool CreateCRI()
		{
			GameObject gameObject = Resources.Load<GameObject>(AudioManager4CRI.m_CriWareLibraryInitializerAssetPath);
			if (gameObject == null)
			{
				global::Debug.LogError("AudioManager4CRI.CreateCRI fail CriWareLibraryInitializerPrefab = null");
				return false;
			}
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(gameObject);
			if (gameObject2 == null)
			{
				global::Debug.LogError("AudioManager4CRI.CreateCRI fail CriWareLibraryInitializerObject = null");
				return false;
			}
			Util.RemoveCloneFromGameObjectName(gameObject2);
			GameObject gameObject3 = Resources.Load<GameObject>(AudioManager4CRI.m_CriWareErrorHandlerAssetPath);
			if (gameObject3 == null)
			{
				global::Debug.LogError("AudioManager4CRI.CreateCRI fail CriWareErrorHandlerPrefab = null");
				return false;
			}
			GameObject gameObject4 = UnityEngine.Object.Instantiate<GameObject>(gameObject3);
			if (gameObject4 == null)
			{
				global::Debug.LogError("AudioManager4CRI.CreateCRI fail CriWareErrorHandlerObject = null");
				return false;
			}
			Util.RemoveCloneFromGameObjectName(gameObject4);
			GameObject gameObject5 = Resources.Load<GameObject>(AudioManager4CRI.m_CRIWAREAssetPath);
			if (gameObject5 == null)
			{
				global::Debug.LogError("AudioManager4CRI.CreateCRI fail CRIWAREPrefab = null");
				return false;
			}
			GameObject gameObject6 = UnityEngine.Object.Instantiate<GameObject>(gameObject5);
			if (gameObject6 == null)
			{
				global::Debug.LogError("AudioManager4CRI.CreateCRI fail CRIWAREObject = null");
				return false;
			}
			Util.RemoveCloneFromGameObjectName(gameObject6);
			this.m_CRIProvider.AddCRIComponentSources();
			return true;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000A518 File Offset: 0x00008718
		private void CreatePlayerVoiceSource()
		{
			if (this.m_mainAudioListener == null)
			{
				this.m_mainAudioListener = this.m_CRIProvider.GetCRIManagerObject().AddComponent<AudioListener>();
			}
			this.m_playerVoiceAudioSource = this.m_CRIProvider.GetCRIManagerObject().AddComponent<AudioSource>();
			this.m_playerVoiceAudioSource.loop = false;
			this.m_playerVoiceAudioSource.playOnAwake = false;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000A57C File Offset: 0x0000877C
		public void Tick()
		{
			this.m_corutineHelper.Tick();
			this.UpdateSheet();
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000A590 File Offset: 0x00008790
		private string GetSheetName(string cueName)
		{
			string[] array = cueName.Split(new char[]
			{
				'_'
			});
			if (array.Length < 2)
			{
				global::Debug.LogError(string.Format("Invalid Cue Name {0}", cueName));
				return string.Empty;
			}
			return array[0];
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000A5D4 File Offset: 0x000087D4
		private CRIDesc.SheetDesc GetSheetDesc(string sheetName)
		{
			CRIDesc.SheetDesc result;
			try
			{
				CRIDesc.SheetDesc sheetDesc = this.GetSheetDescImpl(sheetName);
				if (sheetDesc != null)
				{
					result = sheetDesc;
				}
				else
				{
					sheetDesc = new CRIDesc.SheetDesc();
					string text = string.Format("{0}.acb", sheetName);
					string text2 = string.Format("{0}.awb", sheetName);
					List<string> resourceFiles = this.GetResourceFiles(text);
					if (resourceFiles.Count > 0)
					{
						sheetDesc.m_acbFullPath = resourceFiles[0];
						if (resourceFiles.Count > 1)
						{
							global::Debug.LogError(string.Format("More the one {0} ACB file", text));
						}
					}
					List<string> resourceFiles2 = this.GetResourceFiles(text2);
					if (resourceFiles2.Count > 0)
					{
						sheetDesc.m_awbFullPath = resourceFiles2[0];
						if (resourceFiles.Count > 1)
						{
							global::Debug.LogError(string.Format("More the one {0} AWB file", text2));
						}
					}
					if (string.IsNullOrEmpty(sheetDesc.m_acbFullPath) && string.IsNullOrEmpty(sheetDesc.m_awbFullPath))
					{
						global::Debug.LogError(string.Format("Invaild sheetName {0}", sheetName));
						result = null;
					}
					else
					{
						sheetDesc.m_sheetName = sheetName;
						this.m_criDesc.m_sheetList.Add(sheetDesc);
						result = sheetDesc;
					}
				}
			}
			catch (Exception ex)
			{
				global::Debug.LogError(string.Format("AudioManager4CRI.GetSheetDesc( {0} ) {1}", sheetName, ex.Message));
				result = null;
			}
			return result;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000A72C File Offset: 0x0000892C
		private CRIDesc.SheetDesc GetSheetDescImpl(string sheetName)
		{
			foreach (CRIDesc.SheetDesc sheetDesc in this.m_criDesc.m_sheetList)
			{
				if (sheetDesc.m_sheetName == sheetName)
				{
					return sheetDesc;
				}
			}
			return null;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000A7A4 File Offset: 0x000089A4
		public bool AllocSheetByCueName(string cueName)
		{
			string sheetName = this.GetSheetName(cueName);
			if (sheetName == string.Empty)
			{
				return false;
			}
			CRIDesc.SheetDesc sheetDesc = this.GetSheetDesc(sheetName);
			if (sheetDesc == null)
			{
				global::Debug.LogError(string.Format("Failed to GetSheetDesc: cueName={0}", cueName));
				return false;
			}
			if (this.m_playbacksOfSheets.ContainsKey(sheetName))
			{
				return true;
			}
			this.m_CRIProvider.CRIAddCueSheet(sheetName, sheetDesc.m_acbFullPath, sheetDesc.m_awbFullPath);
			return true;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0000A818 File Offset: 0x00008A18
		public float GetCueLength(string cueName)
		{
			string sheetName = this.GetSheetName(cueName);
			if (sheetName == string.Empty)
			{
				return 0f;
			}
			return this.m_CRIProvider.GetCueLength(sheetName, cueName);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000A850 File Offset: 0x00008A50
		public void StopAll()
		{
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000A854 File Offset: 0x00008A54
		public void SetMute(bool muteBackGroundMusic, bool muteSound, bool muteMovieBackGroundMusic, bool mutePlayerVoice, bool muteSpeech)
		{
			global::Debug.LogError("Don't call function: AudioManager4CRI.SetMute!");
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000A860 File Offset: 0x00008A60
		public void SetBackGroundMusicMute(bool muteBackGroundMusic)
		{
			global::Debug.LogError("Don't call function: AudioManager4CRI.SetBackGroundMusicMute!");
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000A86C File Offset: 0x00008A6C
		public void SetVolume(float backGroundMusicVolume, float soundVolume, float playerVoiceVolume, float speechVolume)
		{
			global::Debug.LogError("Don't call function: AudioManager4CRI.SetVolume!");
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000A878 File Offset: 0x00008A78
		public void PlayBackGroundMusic(string music)
		{
			global::Debug.LogError("Don't call function: AudioManager4CRI.PlayBackGroundMusic!");
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000A884 File Offset: 0x00008A84
		public void StopBackGroundMusic()
		{
			global::Debug.LogError("Don't call function: AudioManager4CRI.StopBackGroundMusic!");
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000A890 File Offset: 0x00008A90
		public void PlaySound(AudioClip ac, float volume = 1f)
		{
			global::Debug.LogError("Don't call function: AudioManager4CRI.PlaySound!");
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000A89C File Offset: 0x00008A9C
		public void PlaySound(string sound, AudioClip audioClip, float volume = 1f, bool allowRepeatedPlaying = false)
		{
			global::Debug.LogError("Don't call function: AudioManager4CRI.PlaySound!");
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000A8A8 File Offset: 0x00008AA8
		public IAudioPlayback PlaySound(string sound, float volume = 1f)
		{
			if (this.m_muteSound)
			{
				return null;
			}
			sound = sound.Trim();
			if (sound.ToLower().StartsWith("stop,"))
			{
				this.StopSound(sound.Substring(5));
				return null;
			}
			if (!this.AllocSheetByCueName(sound))
			{
				return null;
			}
			IAudioPlayback audioPlayback = this.m_CRIProvider.PlaySound(sound);
			this.AddPlaybackToSheet(this.GetSheetName(sound), audioPlayback);
			return audioPlayback;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000A91C File Offset: 0x00008B1C
		public void StopSound(string sound)
		{
			string sheetName = this.GetSheetName(sound);
			if (sheetName == string.Empty)
			{
				return;
			}
			AudioManager4CRI.PlaybacksOfSheet playbacksOfSheet;
			if (!this.m_playbacksOfSheets.TryGetValue(sheetName, out playbacksOfSheet))
			{
				return;
			}
			foreach (IAudioPlayback audioPlayback in playbacksOfSheet.m_playbacks)
			{
				if (audioPlayback != null && !(audioPlayback.CueName != sound) && !audioPlayback.IsStoped())
				{
					audioPlayback.Stop();
				}
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000A9CC File Offset: 0x00008BCC
		private void AddPlaybackToSheet(string sheetName, IAudioPlayback playback)
		{
			AudioManager4CRI.PlaybacksOfSheet playbacksOfSheet;
			if (!this.m_playbacksOfSheets.TryGetValue(sheetName, out playbacksOfSheet))
			{
				playbacksOfSheet = new AudioManager4CRI.PlaybacksOfSheet();
				this.m_playbacksOfSheets.Add(sheetName, playbacksOfSheet);
			}
			if (playback != null)
			{
				if (playbacksOfSheet.m_playbacks.Count == 0)
				{
					playbacksOfSheet.m_removeTime = float.MaxValue;
				}
				playbacksOfSheet.m_playbacks.Add(playback);
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000AA2C File Offset: 0x00008C2C
		public void StopSound()
		{
			global::Debug.LogError("Don't call function: AudioManager4CRI.StopSound!");
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000AA38 File Offset: 0x00008C38
		public void PlaySpeech(string sound, float volume = 1f)
		{
			global::Debug.LogError("Don't call function: AudioManager4CRI.PlaySpeech!");
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000AA44 File Offset: 0x00008C44
		public void StopSpeech()
		{
			global::Debug.LogError("Don't call function: AudioManager4CRI.StopSpeech!");
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000AA50 File Offset: 0x00008C50
		public bool IsSpeechPlaying()
		{
			global::Debug.LogError("Don't call function: AudioManager4CRI.IsSpeechPlaying!");
			return false;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000AA60 File Offset: 0x00008C60
		public void PlayPlayerVoice(AudioClip sound, float volume = 1f)
		{
			if (this.m_muteSound)
			{
				return;
			}
			if (sound == null)
			{
				return;
			}
			this.m_playerVoiceAudioSource.PlayOneShot(sound, volume);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000AA88 File Offset: 0x00008C88
		public bool IsSoundPlaying()
		{
			global::Debug.LogError("Don't call function: AudioManager4CRI.IsSoundPlaying!");
			return false;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000AA98 File Offset: 0x00008C98
		public void StopPlayerVoice()
		{
			this.StopPlayerVoiceByAudioSource();
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000AAA0 File Offset: 0x00008CA0
		public bool IsPlayerVoicePlaying()
		{
			return this.m_playerVoiceAudioSource.isPlaying;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000AAB0 File Offset: 0x00008CB0
		private void StopPlayerVoiceByAudioSource()
		{
			this.m_playerVoiceAudioSource.Stop();
			this.m_playerVoiceAudioSource.clip = null;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000207 RID: 519 RVA: 0x0000AACC File Offset: 0x00008CCC
		public static AudioManager4CRI Instance
		{
			get
			{
				return AudioManager4CRI.m_instance;
			}
		}

		// Token: 0x04000016 RID: 22
		private static AudioManager4CRI m_instance;

		// Token: 0x04000017 RID: 23
		private AudioListener m_mainAudioListener;

		// Token: 0x04000018 RID: 24
		private CRIDesc m_criDesc = new CRIDesc();

		// Token: 0x04000019 RID: 25
		private bool m_muteSound;

		// Token: 0x0400001A RID: 26
		private AudioSource m_playerVoiceAudioSource;

		// Token: 0x0400001B RID: 27
		private ICRIProvider m_CRIProvider;

		// Token: 0x0400001C RID: 28
		private static string m_CRIWAREAssetPath = "CRI/CRIWARE";

		// Token: 0x0400001D RID: 29
		private static string m_CriWareErrorHandlerAssetPath = "CRI/CriWareErrorHandler";

		// Token: 0x0400001E RID: 30
		private static string m_CriWareLibraryInitializerAssetPath = "CRI/CriWareLibraryInitializer";

		// Token: 0x0400001F RID: 31
		public static Type m_criProviderType;

		// Token: 0x04000020 RID: 32
		private const float m_delayRemoveEmptySheetSeconds = 15f;

		// Token: 0x04000021 RID: 33
		private Dictionary<string, AudioManager4CRI.PlaybacksOfSheet> m_playbacksOfSheets = new Dictionary<string, AudioManager4CRI.PlaybacksOfSheet>();

		// Token: 0x04000022 RID: 34
		public static List<AudioManager4CRI.FileInfo> m_clientCriAssetFileInfos = new List<AudioManager4CRI.FileInfo>();

		// Token: 0x04000023 RID: 35
		public static List<AudioManager4CRI.FileInfo> m_serverCriAssetFileInfos = new List<AudioManager4CRI.FileInfo>();

		// Token: 0x04000024 RID: 36
		public static List<AudioManager4CRI.FileInfo> m_cacheCriAssetFileInfos = new List<AudioManager4CRI.FileInfo>();

		// Token: 0x04000025 RID: 37
		public const string FilenameOfAllFilesPath = "AllFilesPath.txt";

		// Token: 0x04000026 RID: 38
		private TinyCorutineHelper m_corutineHelper = new TinyCorutineHelper();

		// Token: 0x04000027 RID: 39
		private const float m_invertSmoothDuration = 1.42857146f;

		// Token: 0x0200000A RID: 10
		[CustomLuaClass]
		public class PlaybacksOfSheet
		{
			// Token: 0x04000028 RID: 40
			public List<IAudioPlayback> m_playbacks = new List<IAudioPlayback>();

			// Token: 0x04000029 RID: 41
			public float m_removeTime = float.MaxValue;
		}

		// Token: 0x0200000B RID: 11
		public struct FileInfo
		{
			// Token: 0x0600020A RID: 522 RVA: 0x0000AB34 File Offset: 0x00008D34
			public FileInfo(string path, string md5, long length, bool isAtClient = true)
			{
				this.m_path = path;
				this.m_md5 = md5;
				this.m_length = length;
				this.m_isAtClient = isAtClient;
			}

			// Token: 0x0400002A RID: 42
			public string m_path;

			// Token: 0x0400002B RID: 43
			public string m_md5;

			// Token: 0x0400002C RID: 44
			public long m_length;

			// Token: 0x0400002D RID: 45
			public bool m_isAtClient;
		}
	}
}
