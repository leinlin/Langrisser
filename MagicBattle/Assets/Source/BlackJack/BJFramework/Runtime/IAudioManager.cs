using System;
using System.Collections;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x02000021 RID: 33
	public interface IAudioManager : ITickable
	{
		// Token: 0x0600028A RID: 650
		bool Initlize();

		// Token: 0x0600028B RID: 651
		void Uninitlize();

		// Token: 0x0600028C RID: 652
		void Pause(bool pause);

		// Token: 0x0600028D RID: 653
		IEnumerator Start(Action<bool> onEnd, string initAssetPath);

		// Token: 0x0600028E RID: 654
		void StopAll();

		// Token: 0x0600028F RID: 655
		void SetMute(bool muteBackGroundMusic, bool muteSound, bool muteMovieBackGroundMusic, bool mutePlayerVoice, bool muteSpeech);

		// Token: 0x06000290 RID: 656
		void SetBackGroundMusicMute(bool muteBackGroundMusic);

		// Token: 0x06000291 RID: 657
		void SetVolume(float backGroundMusicVolume, float soundVolume, float playerVoiceVolume, float speechVolume);

		// Token: 0x06000292 RID: 658
		void SetVolume(string category, float volume, bool isSmooth);

		// Token: 0x06000293 RID: 659
		float GetVolume(string category);

		// Token: 0x06000294 RID: 660
		void PlayBackGroundMusic(string music);

		// Token: 0x06000295 RID: 661
		void StopBackGroundMusic();

		// Token: 0x06000296 RID: 662
		void PlaySpeech(string music, float volume = 1f);

		// Token: 0x06000297 RID: 663
		void StopSpeech();

		// Token: 0x06000298 RID: 664
		IAudioPlayback PlaySound(string sound, float volume = 1f);

		// Token: 0x06000299 RID: 665
		void PlaySound(AudioClip ac, float volume = 1f);

		// Token: 0x0600029A RID: 666
		void PlaySound(string sound, AudioClip audioClip, float volume = 1f, bool allowRepeatedPlaying = false);

		// Token: 0x0600029B RID: 667
		void StopSound();

		// Token: 0x0600029C RID: 668
		void StopSound(string sound);

		// Token: 0x0600029D RID: 669
		void PlayPlayerVoice(AudioClip sound, float volume = 1f);

		// Token: 0x0600029E RID: 670
		void StopPlayerVoice();

		// Token: 0x0600029F RID: 671
		bool IsSoundPlaying();

		// Token: 0x060002A0 RID: 672
		bool IsPlayerVoicePlaying();

		// Token: 0x060002A1 RID: 673
		bool IsSpeechPlaying();
	}
}
