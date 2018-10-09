using System;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x02000042 RID: 66
	[Serializable]
	public class AudioSettings
	{
		// Token: 0x04000157 RID: 343
		public string AudioMixerAssetPath;

		// Token: 0x04000158 RID: 344
		public string AudioMixerBGMGroupSubPath;

		// Token: 0x04000159 RID: 345
		public string AudioMixerSoundEffectGroupSubPath;

		// Token: 0x0400015A RID: 346
		public string AudioMixerPlayerVoiceGroupSubPath;

		// Token: 0x0400015B RID: 347
		public string AudioMixerSpeechGroupSubPath;

		// Token: 0x0400015C RID: 348
		public string AudioMixerBGMVolumeParamName;

		// Token: 0x0400015D RID: 349
		public string AudioMixerMovieBGMVolumeParamName;

		// Token: 0x0400015E RID: 350
		public string AudioMixerSoundEffectParamName;

		// Token: 0x0400015F RID: 351
		public string AudioMixerPlayerVoiceVolumeParamName;

		// Token: 0x04000160 RID: 352
		public string AudioMixerSpeechVolumeParamName;

		// Token: 0x04000161 RID: 353
		public bool EnableCRI;

		// Token: 0x04000162 RID: 354
		public string CRIAudioManagerAsset;

		// Token: 0x04000163 RID: 355
		public string CRIVideoAssetPathRoot;

		// Token: 0x04000164 RID: 356
		public string CRIVideoAssetPathRootForEditor;

		// Token: 0x04000165 RID: 357
		public bool EnableDownload;
	}
}
