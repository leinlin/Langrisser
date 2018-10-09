using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ConfigData;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.Misc
{
	// Token: 0x0200086E RID: 2158
	[CustomLuaClass]
	public class AudioUtility
	{
		// Token: 0x06006B34 RID: 27444 RVA: 0x001E13E0 File Offset: 0x001DF5E0
		public void OnPlaySound(OnClickSound e, string name)
		{
			AudioUtility.PlaySound(name);
		}

		// Token: 0x06006B35 RID: 27445 RVA: 0x001E13EC File Offset: 0x001DF5EC
		public static float[] NormalizeVolume(float[] voiceData)
		{
			float num = float.MinValue;
			for (long num2 = 0L; num2 < (long)voiceData.Length; num2 += 1L)
			{
				num = Math.Max(num, voiceData[(int)(checked((IntPtr)num2))]);
			}
			float factor = 2f / num;
			if (num < 0.02f || factor < 0.999f)
			{
				return voiceData;
			}
			return Array.ConvertAll<float, float>(voiceData, (float i) => i * factor);
		}

		// Token: 0x06006B36 RID: 27446 RVA: 0x001E1464 File Offset: 0x001DF664
		public static AudioClip ClipAudioByLength(AudioClip ac, float realRecordLength)
		{
			if (ac == null)
			{
				global::Debug.LogError("SetAudioClipLength: ac is null.");
				return null;
			}
			AudioClip audioClip = AudioClip.Create(ac.name, (int)((float)ac.samples * Math.Min(realRecordLength, ac.length) / ac.length), ac.channels, ac.frequency, false);
			float[] data = new float[ac.samples];
			ac.GetData(data, 0);
			audioClip.SetData(data, 0);
			return audioClip;
		}

		// Token: 0x06006B37 RID: 27447 RVA: 0x001E14E0 File Offset: 0x001DF6E0
		public static void Pause(bool pause)
		{
			if (GameManager.Instance == null || GameManager.Instance.AudioManager == null)
			{
				return;
			}
			GameManager.Instance.AudioManager.Pause(pause);
		}

		// Token: 0x06006B38 RID: 27448 RVA: 0x001E150C File Offset: 0x001DF70C
		public static IAudioPlayback PlaySound(string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				return null;
			}
			if (GameManager.Instance == null || GameManager.Instance.AudioManager == null)
			{
				return null;
			}
			return GameManager.Instance.AudioManager.PlaySound(name, 1f);
		}

		// Token: 0x06006B39 RID: 27449 RVA: 0x001E154C File Offset: 0x001DF74C
		public static void StopSound(string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				return;
			}
			if (GameManager.Instance == null || GameManager.Instance.AudioManager == null)
			{
				return;
			}
			GameManager.Instance.AudioManager.StopSound(name);
		}

		// Token: 0x06006B3A RID: 27450 RVA: 0x001E1584 File Offset: 0x001DF784
		public static void SearchAndPlaySpineAnimEventSound(string spineDataName, string animationName, string eventName)
		{
			string soundName = SpineAnimationSoundTable.GetSoundName(spineDataName, animationName, eventName);
			if (string.IsNullOrEmpty(soundName))
			{
				return;
			}
			if (GameManager.Instance == null || GameManager.Instance.AudioManager == null)
			{
				return;
			}
			GameManager.Instance.AudioManager.PlaySound(soundName, 1f);
		}

		// Token: 0x06006B3B RID: 27451 RVA: 0x001E15D8 File Offset: 0x001DF7D8
		private static string SoundIDToName(SoundTableId id)
		{
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			return configDataLoader.UtilityGetSound(id);
		}

		// Token: 0x06006B3C RID: 27452 RVA: 0x001E15FC File Offset: 0x001DF7FC
		public static void PlaySound(SoundTableId id)
		{
			if (GameManager.Instance == null || GameManager.Instance.AudioManager == null)
			{
				return;
			}
			GameManager.Instance.AudioManager.PlaySound(AudioUtility.SoundIDToName(id), 1f);
		}

		// Token: 0x06006B3D RID: 27453 RVA: 0x001E1634 File Offset: 0x001DF834
		public static void PlaySound(AudioClip a)
		{
			if (GameManager.Instance == null || GameManager.Instance.AudioManager == null)
			{
				return;
			}
			GameManager.Instance.AudioManager.PlaySound(a, 1f);
		}

		// Token: 0x06006B3E RID: 27454 RVA: 0x001E1668 File Offset: 0x001DF868
		public static void SetVolume(string category, float volume, bool isSmooth = true)
		{
			if (GameManager.Instance == null || GameManager.Instance.AudioManager == null)
			{
				return;
			}
			GameManager.Instance.AudioManager.SetVolume(category, volume, isSmooth);
		}

		// Token: 0x06006B3F RID: 27455 RVA: 0x001E1698 File Offset: 0x001DF898
		public static float GetVolume(string category)
		{
			if (GameManager.Instance == null || GameManager.Instance.AudioManager == null)
			{
				return 0f;
			}
			return GameManager.Instance.AudioManager.GetVolume(category);
		}

		// Token: 0x0400527F RID: 21119
		public const string MusicCategory = "Music_VolumeControl";

		// Token: 0x04005280 RID: 21120
		public const string SoundCategory = "SFX_VolumeControl";

		// Token: 0x04005281 RID: 21121
		public const string VoiceCategory = "Voice_VolumeControl";

		// Token: 0x04005282 RID: 21122
		public const string StopAllMusic = "Action_StopMusic";

		// Token: 0x04005283 RID: 21123
		public const string StopAllVoice = "Action_StopVoice";

		// Token: 0x04005284 RID: 21124
		public const string AllSoundsCategory = "All_Game_Sounds";
	}
}
