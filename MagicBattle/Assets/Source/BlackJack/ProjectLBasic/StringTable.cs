using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectLBasic
{
	// Token: 0x020010B7 RID: 4279
	[CustomLuaClass]
	public class StringTable
	{
		// Token: 0x060158B9 RID: 88249 RVA: 0x0057C9FC File Offset: 0x0057ABFC
		public static bool Load()
		{
			StringTable.m_filepath = "Config/StringTable.txt";
			WWW www = new WWW(Util.GetFileStreamingAssetsPath4WWW(StringTable.m_filepath));
			while (!www.isDone)
			{
			}
			if (!string.IsNullOrEmpty(www.error))
			{
				global::Debug.LogError(string.Format("StringTable.Load DefaultServerAddress.Load {0} Error: {1}", StringTable.m_filepath, www.error));
				return false;
			}
			string[] array = Array.ConvertAll<string, string>(www.text.Split(new char[]
			{
				'\n'
			}), (string s) => s.Trim());
			StringTable.m_stringDictionary = new Dictionary<string, string>();
			string empty = string.Empty;
			foreach (string text in array)
			{
				string[] array3 = text.Split(new string[]
				{
					",="
				}, StringSplitOptions.RemoveEmptyEntries);
				if (array3.Length == 2 && !string.IsNullOrEmpty(array3[0]) && !string.IsNullOrEmpty(array3[1]))
				{
					if (StringTable.m_stringDictionary.TryGetValue(array3[0], out empty))
					{
						global::Debug.LogError(string.Format("StringTable.Load() key {0} repeated.", array3[0]));
						return false;
					}
					StringTable.m_stringDictionary.Add(array3[0], array3[1].Replace("\\n", "\n"));
				}
			}
			return true;
		}

		// Token: 0x060158BA RID: 88250 RVA: 0x0057CB58 File Offset: 0x0057AD58
		public static bool IsKeyExist(string key)
		{
			if (string.IsNullOrEmpty(key))
			{
				return false;
			}
			if (StringTable.m_stringDictionary == null)
			{
				return false;
			}
			string empty = string.Empty;
			return StringTable.m_stringDictionary.TryGetValue(key, out empty);
		}

		// Token: 0x060158BB RID: 88251 RVA: 0x0057CB9C File Offset: 0x0057AD9C
		public static string Get(string key)
		{
			if (string.IsNullOrEmpty(key))
			{
				global::Debug.LogError("StringTable.Get() key is null.");
				return string.Empty;
			}
			if (StringTable.m_stringDictionary == null)
			{
				global::Debug.LogError("StringTable.Get() m_stringDictionary == null.");
				return string.Empty;
			}
			string empty = string.Empty;
			if (!StringTable.m_stringDictionary.TryGetValue(key, out empty))
			{
				global::Debug.LogError(string.Format("StringTable.Get No key={0} string in {1}", key, StringTable.m_filepath));
				return string.Empty;
			}
			return empty;
		}

		// Token: 0x0400BC66 RID: 48230
		private static Dictionary<string, string> m_stringDictionary = null;

		// Token: 0x0400BC67 RID: 48231
		private static string m_filepath = string.Empty;
	}
}
