using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using SLua;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x0200011B RID: 283
	[CustomLuaClass]
	public class Util
	{
		// Token: 0x06000BCC RID: 3020 RVA: 0x000323C4 File Offset: 0x000305C4
		public static IEnumerator DownloadHttpFile(string url, Action<bool, WWW> onReceive, Action<WWW> onUpdate = null)
		{
			int retryCount = 5;
			for (;;)
			{
				int num;
				retryCount = (num = retryCount) - 1;
				if (num <= 0)
				{
					goto Block_4;
				}
				WWW www = new WWW(url);
				yield return new WaitUntil(delegate()
				{
					if (onUpdate != null)
					{
						onUpdate(www);
					}
					return www.isDone;
				});
				if (string.IsNullOrEmpty(www.error))
				{
					break;
				}
				global::Debug.LogError(string.Format("DownHttpTextFile {0} Error: {1}", url, www.error));
				if (retryCount > 0)
				{
					global::Debug.Log("Wait for 2 seconds and retry to download...");
					yield return new WaitForSeconds(2f);
				}
			}
			if (onReceive != null)
			{
				onReceive(true, <DownloadHttpFile>c__AnonStorey2.www);
			}
			yield break;
			Block_4:
			if (onReceive != null)
			{
				onReceive(false, null);
			}
			yield break;
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x000323F0 File Offset: 0x000305F0
		public static string GetCurrentTargetPlatform()
		{
			if (string.IsNullOrEmpty(Util.m_platform))
			{
				if (!Application.isEditor)
				{
					RuntimePlatform platform = Application.platform;
					if (platform != RuntimePlatform.OSXPlayer)
					{
						if (platform != RuntimePlatform.WindowsPlayer)
						{
							switch (platform)
							{
							case RuntimePlatform.IPhonePlayer:
								Util.m_platform = "iOS";
								break;
							case RuntimePlatform.Android:
								Util.m_platform = "Android";
								break;
							}
						}
						else if (IntPtr.Size == 8)
						{
							Util.m_platform = "StandaloneWindows64";
						}
						else
						{
							Util.m_platform = "StandaloneWindows";
						}
					}
					else
					{
						Util.m_platform = "StandaloneOSXIntel";
					}
				}
				else if (Util.GetCurrentTargetPlatformInEditor != null)
				{
					Util.m_platform = Util.GetCurrentTargetPlatformInEditor();
				}
				else
				{
					Util.m_platform = "Android";
				}
			}
			return Util.m_platform;
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000BCE RID: 3022 RVA: 0x000324D4 File Offset: 0x000306D4
		// (set) Token: 0x06000BCF RID: 3023 RVA: 0x000324DC File Offset: 0x000306DC
		public static Func<string> GetCurrentTargetPlatformInEditor { get; set; }

		// Token: 0x06000BD0 RID: 3024 RVA: 0x000324E4 File Offset: 0x000306E4
		public static string GetFilePersistentPath(string assetPath)
		{
			if (Util.m_persistentPath == null)
			{
				Util.m_persistentPath = Application.persistentDataPath + "/";
			}
			return Util.m_persistentPath + assetPath;
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x00032510 File Offset: 0x00030710
		public static string GetFileStreamingAssetsPath(string assetPath)
		{
			if (Util.m_streamingAssetsPath == null)
			{
				Util.m_streamingAssetsPath = Application.streamingAssetsPath + "/";
			}
			return Util.m_streamingAssetsPath + assetPath;
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x0003253C File Offset: 0x0003073C
		public static string GetFileStreamingAssetsPath4WWW(string assetPath)
		{
			if (Util.m_streamingAssetsPath == null)
			{
				Util.m_streamingAssetsPath = Application.streamingAssetsPath + "/";
			}
			if (!Util.m_streamingAssetsPath.Contains("://"))
			{
				return string.Format("file://{0}{1}", Util.m_streamingAssetsPath, assetPath);
			}
			return string.Format("{0}{1}", Util.m_streamingAssetsPath, assetPath);
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x0003259C File Offset: 0x0003079C
		public static string ReformPathString(string path)
		{
			path = path.Replace("\\", "/");
			path = path.Replace("//", "/");
			while (path.EndsWith("/"))
			{
				path = path.Substring(0, path.Length - 1);
			}
			return path;
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x000325F4 File Offset: 0x000307F4
		public static string GetAssetDNNameFromPath(string path)
		{
			if (Util.m_dnNameDict.ContainsKey(path))
			{
				return Util.m_dnNameDict[path];
			}
			string text = path.Replace('/', '_');
			if (text.Contains("\\\\"))
			{
				text = text.Replace("\\\\", "_");
			}
			if (text.Contains("\\"))
			{
				text = text.Replace("\\", "_");
			}
			if (text.Contains("."))
			{
				text = text.Replace(".", "_");
			}
			text += ".b";
			Util.m_dnNameDict[path] = text;
			return text;
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x000326A4 File Offset: 0x000308A4
		public static string GetBundleNameByAssetPath(string path)
		{
			return Util.GetAssetDNNameFromPath(path).ToLower();
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x000326B4 File Offset: 0x000308B4
		public static long GetFileSize(string path)
		{
			if (!File.Exists(path))
			{
				return 0L;
			}
			FileInfo fileInfo = new FileInfo(path);
			return fileInfo.Length;
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x000326DC File Offset: 0x000308DC
		public static void RemoveCloneFromGameObjectName(GameObject go)
		{
			if (go.name.EndsWith("(Clone)"))
			{
				go.name = go.name.Replace("(Clone)", string.Empty);
			}
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x00032710 File Offset: 0x00030910
		public static void SetTransformParent(Transform child, Transform parent)
		{
			Vector3 localPosition = child.localPosition;
			Quaternion localRotation = child.localRotation;
			Vector3 localScale = child.localScale;
			child.parent = parent;
			child.localPosition = localPosition;
			child.localRotation = localRotation;
			child.localScale = localScale;
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x00032750 File Offset: 0x00030950
		public static List<long> GetAllFilesSize(List<string> fileList)
		{
			List<long> list = new List<long>(fileList.Count);
			foreach (string fileName in fileList)
			{
				FileInfo fileInfo = new FileInfo(fileName);
				if (fileInfo == null || !fileInfo.Exists)
				{
					list.Add(0L);
				}
				else
				{
					list.Add(fileInfo.Length);
				}
			}
			return list;
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x000327E0 File Offset: 0x000309E0
		public static List<string> CreateMd5FromFileList(List<string> fileList)
		{
			List<string> list = new List<string>(fileList.Count);
			MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
			foreach (string path in fileList)
			{
				if (!File.Exists(path))
				{
					list.Add(string.Empty);
				}
				else
				{
					FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
					byte[] value = md5CryptoServiceProvider.ComputeHash(fileStream);
					fileStream.Close();
					string item = BitConverter.ToString(value).Replace("-", string.Empty);
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x0003289C File Offset: 0x00030A9C
		public static string CreateMd5FromFile(string filePath)
		{
			MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
			if (!File.Exists(filePath))
			{
				return string.Empty;
			}
			FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
			byte[] value = md5CryptoServiceProvider.ComputeHash(fileStream);
			fileStream.Close();
			return BitConverter.ToString(value).Replace("-", string.Empty);
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x000328F0 File Offset: 0x00030AF0
		public static string CreateMd5FromBytes(byte[] bytes)
		{
			if (bytes == null || bytes.Length == 0)
			{
				return string.Empty;
			}
			MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] value = md5CryptoServiceProvider.ComputeHash(bytes);
			return BitConverter.ToString(value).Replace("-", string.Empty);
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x00032938 File Offset: 0x00030B38
		public static string TimeSpanToString(TimeSpan timeSpan)
		{
			return string.Format("{0:00}:{1:00}:{2:00}", timeSpan.Days * 24 + timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x00032974 File Offset: 0x00030B74
		public static string GetTypeDefaultValueString(Type type)
		{
			if (type.IsValueType)
			{
				return Activator.CreateInstance(type).ToString().ToLower();
			}
			return "null";
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x00032998 File Offset: 0x00030B98
		public static Type FindType(string typeName)
		{
			Type type = Type.GetType(typeName);
			if (type != null)
			{
				return type;
			}
			foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
			{
				type = assembly.GetType(typeName);
				if (type != null)
				{
					return type;
				}
			}
			return null;
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x000329E8 File Offset: 0x00030BE8
		public static string GetTypeDefinitionString(Type type)
		{
			if (type.IsArray)
			{
				string str = type.Name.Substring(type.Name.IndexOf("["), type.Name.Length - type.Name.IndexOf("["));
				string typeDefinitionString = Util.GetTypeDefinitionString(type.GetElementType());
				return typeDefinitionString + str;
			}
			string text;
			if (!type.IsGenericType)
			{
				if (type == typeof(void))
				{
					text = "void";
				}
				else if (type.IsByRef)
				{
					text = Util.GetTypeDefinitionString(type.GetElementType());
				}
				else
				{
					text = type.FullName;
				}
			}
			else
			{
				string text2 = type.Namespace + "." + type.Name.Remove(type.Name.LastIndexOf('`'));
				string text3 = "<";
				foreach (Type type2 in type.GetGenericArguments())
				{
					text3 = text3 + Util.GetTypeDefinitionString(type2) + ",";
				}
				text3 = text3.Remove(text3.Length - 1, 1);
				text3 += ">";
				text2 += text3;
				text = text2;
			}
			if (string.IsNullOrEmpty(text))
			{
				global::Debug.LogError(string.Format("{0} 's result is null", type.ReflectedType));
			}
			return text.Replace('+', '.');
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x00032B64 File Offset: 0x00030D64
		public static string GetGenericTypeFriendlyName(Type type)
		{
			string text;
			if (!type.IsGenericType)
			{
				text = type.Name;
			}
			else
			{
				string text2 = type.Namespace + "." + type.Name.Remove(type.Name.LastIndexOf('`'));
				string text3 = "_";
				foreach (Type type2 in type.GetGenericArguments())
				{
					text3 = text3 + Util.GetGenericTypeFriendlyName(type2) + "_";
				}
				text3 = text3.Remove(text3.Length - 1, 1);
				text2 += text3;
				text = text2;
			}
			if (string.IsNullOrEmpty(text))
			{
				global::Debug.LogError(string.Format("{0} 's result is null", type.ReflectedType));
			}
			return text.Replace('+', '.');
		}

		// Token: 0x040006EF RID: 1775
		private static string m_platform;

		// Token: 0x040006F1 RID: 1777
		private static string m_persistentPath;

		// Token: 0x040006F2 RID: 1778
		private static string m_streamingAssetsPath;

		// Token: 0x040006F3 RID: 1779
		private static Dictionary<string, string> m_dnNameDict = new Dictionary<string, string>();
	}
}
