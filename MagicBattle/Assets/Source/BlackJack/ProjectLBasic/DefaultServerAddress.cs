using System;
using BlackJack.BJFramework.Runtime;
using PD.SDK;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectLBasic
{
	// Token: 0x020010B0 RID: 4272
	[CustomLuaClass]
	public class DefaultServerAddress
	{
		// Token: 0x0601588C RID: 88204 RVA: 0x0057C0D0 File Offset: 0x0057A2D0
		public static bool Load()
		{
			string text = string.Empty;
			WWW www = new WWW(Util.GetFileStreamingAssetsPath4WWW("Config/DefaultServerAddress.txt"));
			while (!www.isDone)
			{
			}
			if (!string.IsNullOrEmpty(www.error))
			{
				global::Debug.LogError("DefaultServerAddress.Load Config/DefaultServerAddress.txt Error: " + www.error + " TryLoad DefaultServerAddress2");
			}
			else
			{
				text = www.text;
			}
			if (string.IsNullOrEmpty(text))
			{
				WWW www2 = new WWW(Util.GetFileStreamingAssetsPath4WWW("Config/DefaultServerAddress2.txt"));
				while (!www2.isDone)
				{
				}
				if (!string.IsNullOrEmpty(www2.error))
				{
					global::Debug.LogError("DefaultServerAddress.Load Config/DefaultServerAddress2.txt Error: " + www2.error);
					return false;
				}
				text = www2.text;
			}
			string[] array = Array.ConvertAll<string, string>(text.Split(new char[]
			{
				'\n'
			}), (string s) => s.Trim());
			string[] array2 = null;
			foreach (string text2 in array)
			{
				if (!text2.StartsWith("//"))
				{
					array2 = Array.ConvertAll<string, string>(text2.Split(new char[]
					{
						','
					}), (string inputString) => inputString.Trim());
					if (array2 != null && array2.Length >= 6)
					{
						break;
					}
					global::Debug.LogError(string.Format("DefaultServerAddress.Load: {0} 's segments count is less than 6.", text2));
				}
			}
			for (int j = 0; j < array2.Length; j++)
			{
				if (string.IsNullOrEmpty(array2[j]))
				{
					global::Debug.LogError(string.Format("DefaultServerAddress.Load address[{0}] is empty.", j));
					return false;
				}
			}
			DefaultServerAddress.m_address = array2;
			return true;
		}

		// Token: 0x17003ED3 RID: 16083
		// (get) Token: 0x0601588D RID: 88205 RVA: 0x0057C2AC File Offset: 0x0057A4AC
		public static string ServerListURL
		{
			get
			{
				if (DefaultServerAddress.m_address == null)
				{
					global::Debug.LogError("DefaultServerAddress.ServerListURL: m_address is null.");
				}
				if (PDSDK.IsIosLoginWindowsPlayer)
				{
					return DefaultServerAddress.m_address[5];
				}
				return DefaultServerAddress.m_address[0];
			}
		}

		// Token: 0x17003ED4 RID: 16084
		// (get) Token: 0x0601588E RID: 88206 RVA: 0x0057C2DC File Offset: 0x0057A4DC
		public static string AnnouncementsURL
		{
			get
			{
				if (DefaultServerAddress.m_address == null)
				{
					global::Debug.LogError("DefaultServerAddress.AnnouncementsURL: m_address is null.");
				}
				return DefaultServerAddress.m_address[1];
			}
		}

		// Token: 0x17003ED5 RID: 16085
		// (get) Token: 0x0601588F RID: 88207 RVA: 0x0057C2FC File Offset: 0x0057A4FC
		public static string URLToSaveUpdateClientServerURL
		{
			get
			{
				if (DefaultServerAddress.m_address == null)
				{
					global::Debug.LogError("DefaultServerAddress.URLToSaveUpdateClientServerURL: m_address is null.");
				}
				return DefaultServerAddress.m_address[2];
			}
		}

		// Token: 0x17003ED6 RID: 16086
		// (get) Token: 0x06015890 RID: 88208 RVA: 0x0057C31C File Offset: 0x0057A51C
		public static string GMUserConfigURL
		{
			get
			{
				if (DefaultServerAddress.m_address == null)
				{
					global::Debug.LogError("DefaultServerAddress.GMUserConfigURL: m_address is null.");
				}
				return DefaultServerAddress.m_address[3];
			}
		}

		// Token: 0x17003ED7 RID: 16087
		// (get) Token: 0x06015891 RID: 88209 RVA: 0x0057C33C File Offset: 0x0057A53C
		public static string ReportBugURL
		{
			get
			{
				if (DefaultServerAddress.m_address == null)
				{
					global::Debug.LogError("DefaultServerAddress.ReportBugURL: m_address is null.");
				}
				return DefaultServerAddress.m_address[4];
			}
		}

		// Token: 0x0400BC42 RID: 48194
		private static string[] m_address;
	}
}
