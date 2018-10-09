using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200034F RID: 847
	[CustomLuaClass]
	public class SpineAnimationSoundTable
	{
		// Token: 0x06003135 RID: 12597 RVA: 0x000C08E4 File Offset: 0x000BEAE4
		public static void Initialize(ClientConfigDataLoader loader)
		{
			SpineAnimationSoundTable.m_soundTable.Clear();
			foreach (KeyValuePair<int, ConfigDataSpineAnimationSoundTable> keyValuePair in loader.GetAllConfigDataSpineAnimationSoundTable())
			{
				Dictionary<string, Dictionary<string, string>> dictionary;
				if (!SpineAnimationSoundTable.m_soundTable.TryGetValue(keyValuePair.Value.SpineDataName, out dictionary))
				{
					dictionary = new Dictionary<string, Dictionary<string, string>>();
					SpineAnimationSoundTable.m_soundTable.Add(keyValuePair.Value.SpineDataName, dictionary);
				}
				Dictionary<string, string> dictionary2;
				if (!dictionary.TryGetValue(keyValuePair.Value.AnimationName, out dictionary2))
				{
					dictionary2 = new Dictionary<string, string>();
					dictionary.Add(keyValuePair.Value.AnimationName, dictionary2);
				}
				string text;
				if (!dictionary2.TryGetValue(keyValuePair.Value.EventName, out text))
				{
					dictionary2.Add(keyValuePair.Value.EventName, keyValuePair.Value.SoundName);
				}
			}
		}

		// Token: 0x06003136 RID: 12598 RVA: 0x000C09E4 File Offset: 0x000BEBE4
		public static string GetSoundName(string spineDataName, string animationName, string eventName)
		{
			Dictionary<string, Dictionary<string, string>> dictionary;
			if (!SpineAnimationSoundTable.m_soundTable.TryGetValue(spineDataName, out dictionary))
			{
				return string.Empty;
			}
			Dictionary<string, string> dictionary2;
			if (!dictionary.TryGetValue(animationName, out dictionary2))
			{
				return string.Empty;
			}
			string result;
			if (!dictionary2.TryGetValue(eventName, out result))
			{
				return string.Empty;
			}
			return result;
		}

		// Token: 0x04002582 RID: 9602
		private static Dictionary<string, Dictionary<string, Dictionary<string, string>>> m_soundTable = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>();
	}
}
