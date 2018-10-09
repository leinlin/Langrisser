using System;
using System.Collections;
using BlackJack.BJFramework.Runtime.Resource;
using BlackJack.Utils;
using SLua;
using UnityEngine;
using UnityEngine.Audio;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x02000017 RID: 23
	[CustomLuaClass]
	public class AudioManager4Unity : IAudioManager, ITickable
	{
		// Token: 0x06000238 RID: 568 RVA: 0x0000BAC4 File Offset: 0x00009CC4
		private AudioManager4Unity()
		{
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000BAD8 File Offset: 0x00009CD8
		[DoNotToLua]
		public static AudioManager4Unity CreateAudioManager()
		{
			if (AudioManager4Unity.m_instance == null)
			{
				AudioManager4Unity.m_instance = new AudioManager4Unity();
			}
			return AudioManager4Unity.m_instance;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000BAF4 File Offset: 0x00009CF4
		[DoNotToLua]
		public bool Initlize()
		{
			global::Debug.Log(string.Format("AudioManager.Initlize start", new object[0]));
			return true;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000BB0C File Offset: 0x00009D0C
		public void Pause(bool pause)
		{
			global::Debug.LogError("Do not call: AudioManager4Unity.Pause()");
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000BB18 File Offset: 0x00009D18
		[DoNotToLua]
		public void Uninitlize()
		{
			global::Debug.Log(string.Format("AudioManager.Uninitlize", new object[0]));
			this.StopAll();
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000BB38 File Offset: 0x00009D38
		[DoNotToLua]
		public IEnumerator Start(Action<bool> onEnd, string mixerAssetPath)
		{
			global::Debug.Log(string.Format("AudioManager.Start", new object[0]));
			this.m_audioRoot = new GameObject("AudioRoot", new Type[]
			{
				typeof(AudioSource),
				typeof(AudioListener)
			});
			this.m_backGroundAudioSource1 = this.m_audioRoot.GetComponent<AudioSource>();
			this.m_backGroundAudioSource1.playOnAwake = false;
			this.m_backGroundAudioSource1.loop = true;
			this.m_backGroundAudioSource2 = this.m_audioRoot.AddComponent<AudioSource>();
			this.m_backGroundAudioSource2.playOnAwake = false;
			this.m_backGroundAudioSource2.loop = true;
			this.m_soundAudioSource = this.m_audioRoot.AddComponent<AudioSource>();
			this.m_soundAudioSource.loop = false;
			this.m_soundAudioSource.playOnAwake = false;
			this.m_playerVoiceAudioSource = this.m_audioRoot.AddComponent<AudioSource>();
			this.m_playerVoiceAudioSource.loop = false;
			this.m_playerVoiceAudioSource.playOnAwake = false;
			this.m_speechAudioSource = this.m_audioRoot.AddComponent<AudioSource>();
			this.m_speechAudioSource.loop = false;
			this.m_speechAudioSource.playOnAwake = false;
			if (!string.IsNullOrEmpty(mixerAssetPath))
			{
				yield return this.CreateMainAudioMixer(onEnd, mixerAssetPath);
			}
			else
			{
				onEnd(true);
			}
			yield break;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000BB64 File Offset: 0x00009D64
		public void EnableDefaultAudioListener(bool enable)
		{
			if (this.MainAudioListener != null)
			{
				this.MainAudioListener.enabled = enable;
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000BB84 File Offset: 0x00009D84
		public void StopAll()
		{
			if (this.m_mainAudioMixer != null)
			{
				this.StopAllByAudioMixer();
			}
			else
			{
				this.StopAllByAudioSource();
			}
			this.m_corutineHelper.CancelAll();
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000BBB4 File Offset: 0x00009DB4
		public void SetMute(bool muteBackGroundMusic, bool muteSound, bool muteMovieBackGroundMusic, bool mutePlayerVoice, bool muteSpeech)
		{
			this.m_muteBackGroundMusic = muteBackGroundMusic;
			this.m_muteMovieBackGroundMusic = muteMovieBackGroundMusic;
			this.m_muteSound = muteSound;
			this.m_mutePlayerVoice = mutePlayerVoice;
			this.m_muteSpeech = muteSpeech;
			if (this.m_mainAudioMixer != null)
			{
				this.SetMuteByAudioMixer();
			}
			else
			{
				this.SetMuteByAudioSource();
			}
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000BC08 File Offset: 0x00009E08
		public void SetBackGroundMusicMute(bool muteBackGroundMusic)
		{
			this.SetMute(muteBackGroundMusic, this.m_muteSound, this.m_muteMovieBackGroundMusic, this.m_mutePlayerVoice, this.m_muteSpeech);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000BC2C File Offset: 0x00009E2C
		public void SetVolume(float backGroundMusicVolume, float soundVolume, float playerVoiceVolume, float speechVolume)
		{
			this.m_backGroundMusicVolume = backGroundMusicVolume;
			this.m_soundVolume = soundVolume;
			this.m_playerVoiceVolume = playerVoiceVolume;
			this.m_speechVolume = speechVolume;
			if (this.m_mainAudioMixer != null)
			{
				this.SetVolumeByAudioMixer();
			}
			else
			{
				this.SetVolumeByAudioSource();
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000BC78 File Offset: 0x00009E78
		public void SetVolume(string category, float volume, bool isSmooth)
		{
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000BC7C File Offset: 0x00009E7C
		public float GetVolume(string category)
		{
			return 1f;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000BC84 File Offset: 0x00009E84
		public void PlayBackGroundMusic(string music)
		{
			if (string.IsNullOrEmpty(music))
			{
				this.StopBackGroundMusic();
				return;
			}
			if (this.m_currBackGroundAudioSource == null)
			{
				this.m_currBackGroundAudioSource = this.m_backGroundAudioSource1;
				this.m_oldBackGroundAudioSource = this.m_backGroundAudioSource2;
			}
			IEnumerator corutine = ResourceManager.Instance.LoadAsset<AudioClip>(music, delegate(string path, AudioClip asset)
			{
				if (asset != null)
				{
					if (this.m_currBackGroundAudioSource == null)
					{
						this.m_currBackGroundAudioSource = this.m_backGroundAudioSource1;
					}
					if (this.m_currBackGroundAudioSource.clip != asset)
					{
						this.m_oldBackGroundAudioSource = this.m_currBackGroundAudioSource;
						this.m_currBackGroundAudioSource = ((!(this.m_currBackGroundAudioSource == this.m_backGroundAudioSource1)) ? this.m_backGroundAudioSource1 : this.m_backGroundAudioSource2);
						this.m_bgmSwapTime = new DateTime?(DateTime.Now);
						this.m_currBackGroundAudioSource.clip = asset;
						if (!this.m_muteBackGroundMusic)
						{
							this.SetVolume(this.m_backGroundMusicVolume, this.m_soundVolume, this.m_playerVoiceVolume, this.m_speechVolume);
						}
						this.m_currBackGroundAudioSource.volume = 0f;
						this.m_currBackGroundAudioSource.Play();
					}
				}
			}, false, false);
			this.m_corutineHelper.StartCorutine(corutine);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000BCF4 File Offset: 0x00009EF4
		public void StopBackGroundMusic()
		{
			if (this.m_mainAudioMixer != null)
			{
				this.StopBackGroundMusicByAudioMixer();
			}
			else
			{
				this.StopBackGroundMusicByAudioSource();
			}
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000BD18 File Offset: 0x00009F18
		public IAudioPlayback PlaySound(string sound, float volume = 1f)
		{
			if (this.m_muteSound)
			{
				return null;
			}
			if (string.IsNullOrEmpty(sound))
			{
				return null;
			}
			IEnumerator corutine = ResourceManager.Instance.LoadAsset<AudioClip>(sound, delegate(string path, AudioClip asset)
			{
				this.m_soundAudioSource.PlayOneShot(asset, this.GetRealSoundAudioSourceVolume(volume));
			}, false, false);
			this.m_corutineHelper.StartCorutine(corutine);
			return null;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000BD7C File Offset: 0x00009F7C
		public void PlaySound(string sound, AudioClip audioClip, float volume = 1f, bool allowRepeatedPlaying = false)
		{
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000BD80 File Offset: 0x00009F80
		public void PlaySound(AudioClip sound, float volume = 1f)
		{
			if (this.m_muteSound)
			{
				return;
			}
			if (sound == null)
			{
				return;
			}
			this.m_soundAudioSource.PlayOneShot(sound, this.GetRealSoundAudioSourceVolume(volume));
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000BDB0 File Offset: 0x00009FB0
		public void PlayPlayerVoice(AudioClip sound, float volume = 1f)
		{
			if (this.m_mutePlayerVoice)
			{
				return;
			}
			if (sound == null)
			{
				return;
			}
			this.m_playerVoiceAudioSource.PlayOneShot(sound, this.GetPlayerVoiceAudioSourceVolume(volume));
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000BDE0 File Offset: 0x00009FE0
		public void StopSound(string sound)
		{
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0000BDE4 File Offset: 0x00009FE4
		public void StopSound()
		{
			if (this.m_mainAudioMixer != null)
			{
				this.StopSoundByAudioMixer();
			}
			else
			{
				this.StopSoundByAudioSource();
			}
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0000BE08 File Offset: 0x0000A008
		public void StopPlayerVoice()
		{
			if (this.m_mainAudioMixer != null)
			{
				this.StopPlayerVoiceByAudioMixer();
			}
			else
			{
				this.StopPlayerVoiceByAudioSource();
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000BE2C File Offset: 0x0000A02C
		public void PlaySpeech(AudioClip sound, float volume = 1f)
		{
			if (this.m_muteSpeech)
			{
				return;
			}
			if (sound == null)
			{
				return;
			}
			this.SetVolume(this.m_backGroundMusicVolume, this.m_soundVolume, this.m_playerVoiceVolume, volume);
			this.m_speechAudioSource.clip = sound;
			this.m_speechAudioSource.Play();
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0000BE84 File Offset: 0x0000A084
		public void PlaySpeech(string sound, float volume = 1f)
		{
			if (this.m_muteSpeech)
			{
				return;
			}
			if (string.IsNullOrEmpty(sound))
			{
				return;
			}
			this.SetVolume(this.m_backGroundMusicVolume, this.m_soundVolume, this.m_playerVoiceVolume, volume);
			IEnumerator corutine = ResourceManager.Instance.LoadAsset<AudioClip>(sound, delegate(string path, AudioClip asset)
			{
				if (asset != null)
				{
					this.m_speechAudioSource.clip = asset;
					this.m_speechAudioSource.Play();
				}
			}, false, false);
			this.m_corutineHelper.StartCorutine(corutine);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0000BEE8 File Offset: 0x0000A0E8
		public void StopSpeech()
		{
			if (this.m_mainAudioMixer != null)
			{
				this.StopSpeechByAudioMixer();
			}
			else
			{
				this.StopSpeechByAudioSource();
			}
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0000BF0C File Offset: 0x0000A10C
		public bool IsSpeechPlaying()
		{
			return this.m_speechAudioSource.isPlaying;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0000BF1C File Offset: 0x0000A11C
		public bool IsSoundPlaying()
		{
			return this.m_soundAudioSource.isPlaying;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0000BF2C File Offset: 0x0000A12C
		public bool IsPlayerVoicePlaying()
		{
			return this.m_playerVoiceAudioSource.isPlaying;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0000BF3C File Offset: 0x0000A13C
		[DoNotToLua]
		public void Tick()
		{
			this.m_corutineHelper.Tick();
			if (!this.m_muteBackGroundMusic && this.m_currBackGroundAudioSource != null && this.m_oldBackGroundAudioSource)
			{
				DateTime? bgmSwapTime = this.m_bgmSwapTime;
				if (bgmSwapTime != null)
				{
					float num = (!(this.m_mainAudioMixer == null)) ? 1f : this.m_backGroundMusicVolume;
					double num2 = (DateTime.Now - this.m_bgmSwapTime.Value).TotalSeconds / 1.0;
					num2 = ((num2 >= 0.0) ? num2 : 0.0);
					num2 = ((num2 <= 1.0) ? num2 : 1.0);
					if (this.m_currBackGroundAudioSource.volume < num)
					{
						this.m_currBackGroundAudioSource.volume = num * (float)num2;
					}
					if (this.m_oldBackGroundAudioSource.volume > 0f)
					{
						this.m_oldBackGroundAudioSource.volume = num * (1f - (float)num2);
						if (this.m_oldBackGroundAudioSource.volume <= 0f)
						{
							this.m_oldBackGroundAudioSource.Stop();
							this.m_oldBackGroundAudioSource.clip = null;
						}
					}
				}
			}
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000C094 File Offset: 0x0000A294
		private float GetRealSoundAudioSourceVolume(float soundVolume)
		{
			if (this.m_mainAudioMixer != null)
			{
				return soundVolume;
			}
			return this.m_soundVolume * soundVolume;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000C0B4 File Offset: 0x0000A2B4
		private float GetPlayerVoiceAudioSourceVolume(float soundVolume)
		{
			if (this.m_mainAudioMixer != null)
			{
				return soundVolume;
			}
			return this.m_playerVoiceVolume * soundVolume;
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000257 RID: 599 RVA: 0x0000C0D4 File Offset: 0x0000A2D4
		public static AudioManager4Unity Instance
		{
			get
			{
				return AudioManager4Unity.m_instance;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000258 RID: 600 RVA: 0x0000C0DC File Offset: 0x0000A2DC
		private AudioListener MainAudioListener
		{
			get
			{
				if (this.m_mainAudioListener == null)
				{
					this.m_mainAudioListener = this.m_audioRoot.GetComponent<AudioListener>();
				}
				return this.m_mainAudioListener;
			}
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000C108 File Offset: 0x0000A308
		private IEnumerator CreateMainAudioMixer(Action<bool> onEnd, string mixerAssetPath)
		{
			yield return ResourceManager.Instance.LoadAsset<AudioMixer>(mixerAssetPath, delegate(string path, AudioMixer asset)
			{
				if (asset == null)
				{
					global::Debug.LogError(string.Format("AudioManager.Start load AudioMixer fail path={0}", mixerAssetPath));
					onEnd(false);
				}
				this.m_mainAudioMixer = asset;
			}, false, false);
			if (this.m_mainAudioMixer != null)
			{
				GameClientSetting gameClientSetting = GameManager.Instance.GameClientSetting;
				AudioMixerGroup audioMixerGroupBySubPathName = this.GetAudioMixerGroupBySubPathName(this.m_mainAudioMixer, gameClientSetting.AudioSetting.AudioMixerBGMGroupSubPath);
				if (audioMixerGroupBySubPathName == null)
				{
					global::Debug.LogError(string.Format("AudioManager.Start find AudioMixerBGMGroup fail subpath = {0}", gameClientSetting.AudioSetting.AudioMixerBGMGroupSubPath));
				}
				this.m_backGroundAudioSource1.outputAudioMixerGroup = audioMixerGroupBySubPathName;
				this.m_backGroundAudioSource2.outputAudioMixerGroup = audioMixerGroupBySubPathName;
				AudioMixerGroup audioMixerGroupBySubPathName2 = this.GetAudioMixerGroupBySubPathName(this.m_mainAudioMixer, gameClientSetting.AudioSetting.AudioMixerSoundEffectGroupSubPath);
				if (audioMixerGroupBySubPathName2 == null)
				{
					global::Debug.LogError(string.Format("AudioManager.Start find AudioMixerSoundEffectGroup fail subpath = {0}", gameClientSetting.AudioSetting.AudioMixerBGMGroupSubPath));
				}
				this.m_soundAudioSource.outputAudioMixerGroup = audioMixerGroupBySubPathName2;
				AudioMixerGroup audioMixerGroupBySubPathName3 = this.GetAudioMixerGroupBySubPathName(this.m_mainAudioMixer, gameClientSetting.AudioSetting.AudioMixerPlayerVoiceGroupSubPath);
				if (audioMixerGroupBySubPathName3 == null)
				{
					global::Debug.LogError(string.Format("AudioManager.Start find AudioMixerPlayerVoiceGroup fail subpath = {0}", gameClientSetting.AudioSetting.AudioMixerPlayerVoiceGroupSubPath));
				}
				this.m_playerVoiceAudioSource.outputAudioMixerGroup = audioMixerGroupBySubPathName3;
				AudioMixerGroup audioMixerGroupBySubPathName4 = this.GetAudioMixerGroupBySubPathName(this.m_mainAudioMixer, gameClientSetting.AudioSetting.AudioMixerSpeechGroupSubPath);
				if (audioMixerGroupBySubPathName4 == null)
				{
					global::Debug.LogError(string.Format("AudioManager.Start find AudioMixerSpeechGroup fail subpath = {0}", gameClientSetting.AudioSetting.AudioMixerSpeechGroupSubPath));
				}
				this.m_speechAudioSource.outputAudioMixerGroup = audioMixerGroupBySubPathName4;
				onEnd(true);
			}
			yield break;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000C134 File Offset: 0x0000A334
		private void StopAllByAudioMixer()
		{
			GameClientSetting gameClientSetting = GameManager.Instance.GameClientSetting;
			this.m_mainAudioMixer.SetFloat(gameClientSetting.AudioSetting.AudioMixerBGMVolumeParamName, this.TransformNormalizeVolumeToRealAudioMixerGroupVolume(0f));
			this.m_mainAudioMixer.SetFloat(gameClientSetting.AudioSetting.AudioMixerSoundEffectParamName, this.TransformNormalizeVolumeToRealAudioMixerGroupVolume(0f));
			this.m_mainAudioMixer.SetFloat(gameClientSetting.AudioSetting.AudioMixerPlayerVoiceVolumeParamName, this.TransformNormalizeVolumeToRealAudioMixerGroupVolume(0f));
			this.m_mainAudioMixer.SetFloat(gameClientSetting.AudioSetting.AudioMixerSpeechVolumeParamName, this.TransformNormalizeVolumeToRealAudioMixerGroupVolume(0f));
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000C1D4 File Offset: 0x0000A3D4
		private void SetMuteByAudioMixer()
		{
			GameClientSetting gameClientSetting = GameManager.Instance.GameClientSetting;
			if (this.m_muteBackGroundMusic)
			{
				this.m_mainAudioMixer.SetFloat(gameClientSetting.AudioSetting.AudioMixerBGMVolumeParamName, this.TransformNormalizeVolumeToRealAudioMixerGroupVolume(0f));
			}
			else
			{
				this.m_mainAudioMixer.SetFloat(gameClientSetting.AudioSetting.AudioMixerBGMVolumeParamName, this.TransformNormalizeVolumeToRealAudioMixerGroupVolume(this.m_backGroundMusicVolume));
			}
			if (this.m_muteMovieBackGroundMusic)
			{
				this.m_mainAudioMixer.SetFloat(gameClientSetting.AudioSetting.AudioMixerMovieBGMVolumeParamName, this.TransformNormalizeVolumeToRealAudioMixerGroupVolume(0f));
			}
			else
			{
				this.m_mainAudioMixer.SetFloat(gameClientSetting.AudioSetting.AudioMixerMovieBGMVolumeParamName, this.TransformNormalizeVolumeToRealAudioMixerGroupVolume(this.m_backGroundMusicVolume));
			}
			if (this.m_muteSound)
			{
				this.m_mainAudioMixer.SetFloat(gameClientSetting.AudioSetting.AudioMixerSoundEffectParamName, this.TransformNormalizeVolumeToRealAudioMixerGroupVolume(0f));
			}
			else
			{
				this.m_mainAudioMixer.SetFloat(gameClientSetting.AudioSetting.AudioMixerSoundEffectParamName, this.TransformNormalizeVolumeToRealAudioMixerGroupVolume(this.m_soundVolume));
			}
			if (this.m_mutePlayerVoice)
			{
				this.m_mainAudioMixer.SetFloat(gameClientSetting.AudioSetting.AudioMixerPlayerVoiceVolumeParamName, this.TransformNormalizeVolumeToRealAudioMixerGroupVolume(0f));
			}
			else
			{
				this.m_mainAudioMixer.SetFloat(gameClientSetting.AudioSetting.AudioMixerPlayerVoiceVolumeParamName, this.TransformNormalizeVolumeToRealAudioMixerGroupVolume(this.m_soundVolume));
			}
			if (this.m_muteSpeech)
			{
				this.m_mainAudioMixer.SetFloat(gameClientSetting.AudioSetting.AudioMixerSpeechVolumeParamName, this.TransformNormalizeVolumeToRealAudioMixerGroupVolume(0f));
			}
			else
			{
				this.m_mainAudioMixer.SetFloat(gameClientSetting.AudioSetting.AudioMixerSpeechVolumeParamName, this.TransformNormalizeVolumeToRealAudioMixerGroupVolume(this.m_speechVolume));
			}
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000C398 File Offset: 0x0000A598
		private void SetVolumeByAudioMixer()
		{
			GameClientSetting gameClientSetting = GameManager.Instance.GameClientSetting;
			this.m_mainAudioMixer.SetFloat(gameClientSetting.AudioSetting.AudioMixerBGMVolumeParamName, this.TransformNormalizeVolumeToRealAudioMixerGroupVolume(this.m_backGroundMusicVolume));
			this.m_mainAudioMixer.SetFloat(gameClientSetting.AudioSetting.AudioMixerMovieBGMVolumeParamName, this.TransformNormalizeVolumeToRealAudioMixerGroupVolume(this.m_backGroundMusicVolume));
			this.m_mainAudioMixer.SetFloat(gameClientSetting.AudioSetting.AudioMixerSoundEffectParamName, this.TransformNormalizeVolumeToRealAudioMixerGroupVolume(this.m_soundVolume));
			this.m_mainAudioMixer.SetFloat(gameClientSetting.AudioSetting.AudioMixerPlayerVoiceVolumeParamName, this.TransformNormalizeVolumeToRealAudioMixerGroupVolume(this.m_soundVolume));
			this.m_mainAudioMixer.SetFloat(gameClientSetting.AudioSetting.AudioMixerSpeechVolumeParamName, this.TransformNormalizeVolumeToRealAudioMixerGroupVolume(this.m_speechVolume));
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000C460 File Offset: 0x0000A660
		private void StopBackGroundMusicByAudioMixer()
		{
			GameClientSetting gameClientSetting = GameManager.Instance.GameClientSetting;
			this.m_mainAudioMixer.SetFloat(gameClientSetting.AudioSetting.AudioMixerBGMVolumeParamName, this.TransformNormalizeVolumeToRealAudioMixerGroupVolume(0f));
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000C49C File Offset: 0x0000A69C
		private void StopSoundByAudioMixer()
		{
			GameClientSetting gameClientSetting = GameManager.Instance.GameClientSetting;
			this.m_mainAudioMixer.SetFloat(gameClientSetting.AudioSetting.AudioMixerSoundEffectParamName, this.TransformNormalizeVolumeToRealAudioMixerGroupVolume(0f));
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0000C4D8 File Offset: 0x0000A6D8
		private void StopSpeechByAudioMixer()
		{
			GameClientSetting gameClientSetting = GameManager.Instance.GameClientSetting;
			this.m_mainAudioMixer.SetFloat(gameClientSetting.AudioSetting.AudioMixerSpeechVolumeParamName, this.TransformNormalizeVolumeToRealAudioMixerGroupVolume(0f));
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000C514 File Offset: 0x0000A714
		private void StopPlayerVoiceByAudioMixer()
		{
			GameClientSetting gameClientSetting = GameManager.Instance.GameClientSetting;
			this.m_mainAudioMixer.SetFloat(gameClientSetting.AudioSetting.AudioMixerPlayerVoiceVolumeParamName, this.TransformNormalizeVolumeToRealAudioMixerGroupVolume(0f));
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000C550 File Offset: 0x0000A750
		private float TransformNormalizeVolumeToRealAudioMixerGroupVolume(float normalizeVolume)
		{
			float num = 100f * normalizeVolume - 80f;
			if (num < -80f)
			{
				num = -80f;
			}
			if (num > 20f)
			{
				num = 20f;
			}
			return num;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000C590 File Offset: 0x0000A790
		private AudioMixerGroup GetAudioMixerGroupBySubPathName(AudioMixer audioMixer, string subPathName)
		{
			AudioMixerGroup[] array = audioMixer.FindMatchingGroups(subPathName);
			if (array != null && array.Length > 0)
			{
				return array[0];
			}
			return null;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0000C5BC File Offset: 0x0000A7BC
		private void StopAllByAudioSource()
		{
			if (this.m_currBackGroundAudioSource != null)
			{
				this.m_currBackGroundAudioSource.Stop();
				this.m_currBackGroundAudioSource.clip = null;
			}
			if (this.m_soundAudioSource != null)
			{
				this.m_soundAudioSource.Stop();
				this.m_soundAudioSource.clip = null;
			}
			if (this.m_playerVoiceAudioSource != null)
			{
				this.m_playerVoiceAudioSource.Stop();
				this.m_playerVoiceAudioSource.clip = null;
			}
			if (this.m_speechAudioSource != null)
			{
				this.m_speechAudioSource.Stop();
				this.m_speechAudioSource.clip = null;
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000C66C File Offset: 0x0000A86C
		private void SetMuteByAudioSource()
		{
			if (this.m_muteBackGroundMusic)
			{
				if (this.m_currBackGroundAudioSource != null)
				{
					this.m_currBackGroundAudioSource.volume = 0f;
				}
			}
			else if (this.m_currBackGroundAudioSource != null)
			{
				this.m_currBackGroundAudioSource.volume = this.m_backGroundMusicVolume;
			}
			if (this.m_muteSound)
			{
				this.m_soundAudioSource.volume = 0f;
			}
			else
			{
				this.m_soundAudioSource.volume = this.m_soundVolume;
			}
			if (this.m_mutePlayerVoice)
			{
				this.m_playerVoiceAudioSource.volume = 0f;
			}
			else
			{
				this.m_playerVoiceAudioSource.volume = this.m_playerVoiceVolume;
			}
			if (this.m_muteSpeech)
			{
				this.m_speechAudioSource.volume = 0f;
			}
			else
			{
				this.m_speechAudioSource.volume = this.m_playerVoiceVolume;
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0000C760 File Offset: 0x0000A960
		private void SetVolumeByAudioSource()
		{
			if (this.m_currBackGroundAudioSource != null)
			{
				this.m_currBackGroundAudioSource.volume = this.m_backGroundMusicVolume;
			}
			if (this.m_soundAudioSource != null)
			{
				this.m_soundAudioSource.volume = this.m_soundVolume;
			}
			if (this.m_playerVoiceAudioSource != null)
			{
				this.m_playerVoiceAudioSource.volume = this.m_playerVoiceVolume;
			}
			if (this.m_speechAudioSource != null)
			{
				this.m_speechAudioSource.volume = this.m_speechVolume;
			}
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0000C7F8 File Offset: 0x0000A9F8
		private void StopBackGroundMusicByAudioSource()
		{
			this.m_currBackGroundAudioSource.Stop();
			this.m_currBackGroundAudioSource.clip = null;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000C814 File Offset: 0x0000AA14
		private void StopSoundByAudioSource()
		{
			this.m_soundAudioSource.Stop();
			this.m_soundAudioSource.clip = null;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000C830 File Offset: 0x0000AA30
		private void StopSpeechByAudioSource()
		{
			this.m_speechAudioSource.Stop();
			this.m_speechAudioSource.clip = null;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000C84C File Offset: 0x0000AA4C
		private void StopPlayerVoiceByAudioSource()
		{
			this.m_playerVoiceAudioSource.Stop();
			this.m_playerVoiceAudioSource.clip = null;
		}

		// Token: 0x04000067 RID: 103
		private static AudioManager4Unity m_instance;

		// Token: 0x04000068 RID: 104
		private TinyCorutineHelper m_corutineHelper = new TinyCorutineHelper();

		// Token: 0x04000069 RID: 105
		private GameObject m_audioRoot;

		// Token: 0x0400006A RID: 106
		private AudioSource m_backGroundAudioSource1;

		// Token: 0x0400006B RID: 107
		private AudioSource m_backGroundAudioSource2;

		// Token: 0x0400006C RID: 108
		private AudioSource m_currBackGroundAudioSource;

		// Token: 0x0400006D RID: 109
		private AudioSource m_oldBackGroundAudioSource;

		// Token: 0x0400006E RID: 110
		private DateTime? m_bgmSwapTime;

		// Token: 0x0400006F RID: 111
		private AudioSource m_soundAudioSource;

		// Token: 0x04000070 RID: 112
		private AudioSource m_playerVoiceAudioSource;

		// Token: 0x04000071 RID: 113
		private AudioSource m_speechAudioSource;

		// Token: 0x04000072 RID: 114
		private AudioMixer m_mainAudioMixer;

		// Token: 0x04000073 RID: 115
		private AudioListener m_mainAudioListener;

		// Token: 0x04000074 RID: 116
		private bool m_muteBackGroundMusic;

		// Token: 0x04000075 RID: 117
		private bool m_muteMovieBackGroundMusic;

		// Token: 0x04000076 RID: 118
		private bool m_muteSound;

		// Token: 0x04000077 RID: 119
		private bool m_mutePlayerVoice;

		// Token: 0x04000078 RID: 120
		private bool m_muteSpeech;

		// Token: 0x04000079 RID: 121
		private float m_backGroundMusicVolume;

		// Token: 0x0400007A RID: 122
		private float m_soundVolume;

		// Token: 0x0400007B RID: 123
		private float m_playerVoiceVolume;

		// Token: 0x0400007C RID: 124
		private float m_speechVolume;

		// Token: 0x0400007D RID: 125
		private const float BGMSwapTime = 1f;
	}
}
