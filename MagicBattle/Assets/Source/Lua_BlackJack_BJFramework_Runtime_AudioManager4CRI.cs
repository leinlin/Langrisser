using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001105 RID: 4357
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI : LuaObject
{
	// Token: 0x06015AB7 RID: 88759 RVA: 0x005907E8 File Offset: 0x0058E9E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4CRI o = new AudioManager4CRI();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AB8 RID: 88760 RVA: 0x00590830 File Offset: 0x0058EA30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetVolume(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				AudioManager4CRI audioManager4CRI = (AudioManager4CRI)LuaObject.checkSelf(l);
				string category;
				LuaObject.checkType(l, 2, out category);
				float volume;
				LuaObject.checkType(l, 3, out volume);
				bool isSmooth;
				LuaObject.checkType(l, 4, out isSmooth);
				audioManager4CRI.SetVolume(category, volume, isSmooth);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 5)
			{
				AudioManager4CRI audioManager4CRI2 = (AudioManager4CRI)LuaObject.checkSelf(l);
				float backGroundMusicVolume;
				LuaObject.checkType(l, 2, out backGroundMusicVolume);
				float soundVolume;
				LuaObject.checkType(l, 3, out soundVolume);
				float playerVoiceVolume;
				LuaObject.checkType(l, 4, out playerVoiceVolume);
				float speechVolume;
				LuaObject.checkType(l, 5, out speechVolume);
				audioManager4CRI2.SetVolume(backGroundMusicVolume, soundVolume, playerVoiceVolume, speechVolume);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetVolume to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AB9 RID: 88761 RVA: 0x00590928 File Offset: 0x0058EB28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetVolume(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4CRI audioManager4CRI = (AudioManager4CRI)LuaObject.checkSelf(l);
			string category;
			LuaObject.checkType(l, 2, out category);
			float volume = audioManager4CRI.GetVolume(category);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, volume);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015ABA RID: 88762 RVA: 0x0059098C File Offset: 0x0058EB8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Initlize(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4CRI audioManager4CRI = (AudioManager4CRI)LuaObject.checkSelf(l);
			bool b = audioManager4CRI.Initlize();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015ABB RID: 88763 RVA: 0x005909E0 File Offset: 0x0058EBE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Pause(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4CRI audioManager4CRI = (AudioManager4CRI)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			audioManager4CRI.Pause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015ABC RID: 88764 RVA: 0x00590A38 File Offset: 0x0058EC38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Uninitlize(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4CRI audioManager4CRI = (AudioManager4CRI)LuaObject.checkSelf(l);
			audioManager4CRI.Uninitlize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015ABD RID: 88765 RVA: 0x00590A84 File Offset: 0x0058EC84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Start(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4CRI audioManager4CRI = (AudioManager4CRI)LuaObject.checkSelf(l);
			Action<bool> onEnd;
			LuaObject.checkDelegate<Action<bool>>(l, 2, out onEnd);
			string criAudioManagerAssetPath;
			LuaObject.checkType(l, 3, out criAudioManagerAssetPath);
			IEnumerator o = audioManager4CRI.Start(onEnd, criAudioManagerAssetPath);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015ABE RID: 88766 RVA: 0x00590AF4 File Offset: 0x0058ECF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4CRI audioManager4CRI = (AudioManager4CRI)LuaObject.checkSelf(l);
			audioManager4CRI.Tick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015ABF RID: 88767 RVA: 0x00590B40 File Offset: 0x0058ED40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AllocSheetByCueName(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4CRI audioManager4CRI = (AudioManager4CRI)LuaObject.checkSelf(l);
			string cueName;
			LuaObject.checkType(l, 2, out cueName);
			bool b = audioManager4CRI.AllocSheetByCueName(cueName);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AC0 RID: 88768 RVA: 0x00590BA4 File Offset: 0x0058EDA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCueLength(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4CRI audioManager4CRI = (AudioManager4CRI)LuaObject.checkSelf(l);
			string cueName;
			LuaObject.checkType(l, 2, out cueName);
			float cueLength = audioManager4CRI.GetCueLength(cueName);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cueLength);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AC1 RID: 88769 RVA: 0x00590C08 File Offset: 0x0058EE08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StopAll(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4CRI audioManager4CRI = (AudioManager4CRI)LuaObject.checkSelf(l);
			audioManager4CRI.StopAll();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AC2 RID: 88770 RVA: 0x00590C54 File Offset: 0x0058EE54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetMute(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4CRI audioManager4CRI = (AudioManager4CRI)LuaObject.checkSelf(l);
			bool muteBackGroundMusic;
			LuaObject.checkType(l, 2, out muteBackGroundMusic);
			bool muteSound;
			LuaObject.checkType(l, 3, out muteSound);
			bool muteMovieBackGroundMusic;
			LuaObject.checkType(l, 4, out muteMovieBackGroundMusic);
			bool mutePlayerVoice;
			LuaObject.checkType(l, 5, out mutePlayerVoice);
			bool muteSpeech;
			LuaObject.checkType(l, 6, out muteSpeech);
			audioManager4CRI.SetMute(muteBackGroundMusic, muteSound, muteMovieBackGroundMusic, mutePlayerVoice, muteSpeech);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AC3 RID: 88771 RVA: 0x00590CE0 File Offset: 0x0058EEE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetBackGroundMusicMute(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4CRI audioManager4CRI = (AudioManager4CRI)LuaObject.checkSelf(l);
			bool backGroundMusicMute;
			LuaObject.checkType(l, 2, out backGroundMusicMute);
			audioManager4CRI.SetBackGroundMusicMute(backGroundMusicMute);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AC4 RID: 88772 RVA: 0x00590D38 File Offset: 0x0058EF38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayBackGroundMusic(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4CRI audioManager4CRI = (AudioManager4CRI)LuaObject.checkSelf(l);
			string music;
			LuaObject.checkType(l, 2, out music);
			audioManager4CRI.PlayBackGroundMusic(music);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AC5 RID: 88773 RVA: 0x00590D90 File Offset: 0x0058EF90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopBackGroundMusic(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4CRI audioManager4CRI = (AudioManager4CRI)LuaObject.checkSelf(l);
			audioManager4CRI.StopBackGroundMusic();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AC6 RID: 88774 RVA: 0x00590DDC File Offset: 0x0058EFDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PlaySound(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, num, 2, typeof(string), typeof(float)))
			{
				AudioManager4CRI audioManager4CRI = (AudioManager4CRI)LuaObject.checkSelf(l);
				string sound;
				LuaObject.checkType(l, 2, out sound);
				float volume;
				LuaObject.checkType(l, 3, out volume);
				IAudioPlayback o = audioManager4CRI.PlaySound(sound, volume);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(AudioClip), typeof(float)))
			{
				AudioManager4CRI audioManager4CRI2 = (AudioManager4CRI)LuaObject.checkSelf(l);
				AudioClip ac;
				LuaObject.checkType<AudioClip>(l, 2, out ac);
				float volume2;
				LuaObject.checkType(l, 3, out volume2);
				audioManager4CRI2.PlaySound(ac, volume2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 5)
			{
				AudioManager4CRI audioManager4CRI3 = (AudioManager4CRI)LuaObject.checkSelf(l);
				string sound2;
				LuaObject.checkType(l, 2, out sound2);
				AudioClip audioClip;
				LuaObject.checkType<AudioClip>(l, 3, out audioClip);
				float volume3;
				LuaObject.checkType(l, 4, out volume3);
				bool allowRepeatedPlaying;
				LuaObject.checkType(l, 5, out allowRepeatedPlaying);
				audioManager4CRI3.PlaySound(sound2, audioClip, volume3, allowRepeatedPlaying);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function PlaySound to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AC7 RID: 88775 RVA: 0x00590F54 File Offset: 0x0058F154
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StopSound(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				AudioManager4CRI audioManager4CRI = (AudioManager4CRI)LuaObject.checkSelf(l);
				string sound;
				LuaObject.checkType(l, 2, out sound);
				audioManager4CRI.StopSound(sound);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 1)
			{
				AudioManager4CRI audioManager4CRI2 = (AudioManager4CRI)LuaObject.checkSelf(l);
				audioManager4CRI2.StopSound();
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function StopSound to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AC8 RID: 88776 RVA: 0x00591000 File Offset: 0x0058F200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlaySpeech(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4CRI audioManager4CRI = (AudioManager4CRI)LuaObject.checkSelf(l);
			string sound;
			LuaObject.checkType(l, 2, out sound);
			float volume;
			LuaObject.checkType(l, 3, out volume);
			audioManager4CRI.PlaySpeech(sound, volume);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AC9 RID: 88777 RVA: 0x00591064 File Offset: 0x0058F264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopSpeech(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4CRI audioManager4CRI = (AudioManager4CRI)LuaObject.checkSelf(l);
			audioManager4CRI.StopSpeech();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015ACA RID: 88778 RVA: 0x005910B0 File Offset: 0x0058F2B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsSpeechPlaying(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4CRI audioManager4CRI = (AudioManager4CRI)LuaObject.checkSelf(l);
			bool b = audioManager4CRI.IsSpeechPlaying();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015ACB RID: 88779 RVA: 0x00591104 File Offset: 0x0058F304
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PlayPlayerVoice(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4CRI audioManager4CRI = (AudioManager4CRI)LuaObject.checkSelf(l);
			AudioClip sound;
			LuaObject.checkType<AudioClip>(l, 2, out sound);
			float volume;
			LuaObject.checkType(l, 3, out volume);
			audioManager4CRI.PlayPlayerVoice(sound, volume);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015ACC RID: 88780 RVA: 0x00591168 File Offset: 0x0058F368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsSoundPlaying(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4CRI audioManager4CRI = (AudioManager4CRI)LuaObject.checkSelf(l);
			bool b = audioManager4CRI.IsSoundPlaying();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015ACD RID: 88781 RVA: 0x005911BC File Offset: 0x0058F3BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StopPlayerVoice(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4CRI audioManager4CRI = (AudioManager4CRI)LuaObject.checkSelf(l);
			audioManager4CRI.StopPlayerVoice();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015ACE RID: 88782 RVA: 0x00591208 File Offset: 0x0058F408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsPlayerVoicePlaying(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4CRI audioManager4CRI = (AudioManager4CRI)LuaObject.checkSelf(l);
			bool b = audioManager4CRI.IsPlayerVoicePlaying();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015ACF RID: 88783 RVA: 0x0059125C File Offset: 0x0058F45C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DownloadAudioFiles_s(IntPtr l)
	{
		int result;
		try
		{
			Action<bool> onEnd;
			LuaObject.checkDelegate<Action<bool>>(l, 1, out onEnd);
			Action<long, long> onUpdate;
			LuaObject.checkDelegate<Action<long, long>>(l, 2, out onUpdate);
			Action<long> onEndAfterGotDownloadLength;
			LuaObject.checkDelegate<Action<long>>(l, 3, out onEndAfterGotDownloadLength);
			MonoBehaviour coroutineOwner;
			LuaObject.checkType<MonoBehaviour>(l, 4, out coroutineOwner);
			IEnumerator o = AudioManager4CRI.DownloadAudioFiles(onEnd, onUpdate, onEndAfterGotDownloadLength, coroutineOwner);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AD0 RID: 88784 RVA: 0x005912D8 File Offset: 0x0058F4D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CreateAudioManager_s(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4CRI o = AudioManager4CRI.CreateAudioManager();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AD1 RID: 88785 RVA: 0x00591320 File Offset: 0x0058F520
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ParseFileInfosText_s(IntPtr l)
	{
		int result;
		try
		{
			string text;
			LuaObject.checkType(l, 1, out text);
			List<AudioManager4CRI.FileInfo> o = AudioManager4CRI.ParseFileInfosText(text);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AD2 RID: 88786 RVA: 0x00591374 File Offset: 0x0058F574
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int LoadTextFile_s(IntPtr l)
	{
		int result;
		try
		{
			string filepath;
			LuaObject.checkType(l, 1, out filepath);
			string s = AudioManager4CRI.LoadTextFile(filepath);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AD3 RID: 88787 RVA: 0x005913C8 File Offset: 0x0058F5C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int LoadFileInfos_s(IntPtr l)
	{
		int result;
		try
		{
			string filepath;
			LuaObject.checkType(l, 1, out filepath);
			List<AudioManager4CRI.FileInfo> o = AudioManager4CRI.LoadFileInfos(filepath);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AD4 RID: 88788 RVA: 0x0059141C File Offset: 0x0058F61C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_criProviderType(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, AudioManager4CRI.m_criProviderType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AD5 RID: 88789 RVA: 0x00591464 File Offset: 0x0058F664
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_criProviderType(IntPtr l)
	{
		int result;
		try
		{
			Type criProviderType;
			LuaObject.checkType(l, 2, out criProviderType);
			AudioManager4CRI.m_criProviderType = criProviderType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AD6 RID: 88790 RVA: 0x005914B0 File Offset: 0x0058F6B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_clientCriAssetFileInfos(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, AudioManager4CRI.m_clientCriAssetFileInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AD7 RID: 88791 RVA: 0x005914F8 File Offset: 0x0058F6F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_clientCriAssetFileInfos(IntPtr l)
	{
		int result;
		try
		{
			List<AudioManager4CRI.FileInfo> clientCriAssetFileInfos;
			LuaObject.checkType<List<AudioManager4CRI.FileInfo>>(l, 2, out clientCriAssetFileInfos);
			AudioManager4CRI.m_clientCriAssetFileInfos = clientCriAssetFileInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AD8 RID: 88792 RVA: 0x00591544 File Offset: 0x0058F744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_serverCriAssetFileInfos(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, AudioManager4CRI.m_serverCriAssetFileInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AD9 RID: 88793 RVA: 0x0059158C File Offset: 0x0058F78C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_serverCriAssetFileInfos(IntPtr l)
	{
		int result;
		try
		{
			List<AudioManager4CRI.FileInfo> serverCriAssetFileInfos;
			LuaObject.checkType<List<AudioManager4CRI.FileInfo>>(l, 2, out serverCriAssetFileInfos);
			AudioManager4CRI.m_serverCriAssetFileInfos = serverCriAssetFileInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015ADA RID: 88794 RVA: 0x005915D8 File Offset: 0x0058F7D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cacheCriAssetFileInfos(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, AudioManager4CRI.m_cacheCriAssetFileInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015ADB RID: 88795 RVA: 0x00591620 File Offset: 0x0058F820
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_cacheCriAssetFileInfos(IntPtr l)
	{
		int result;
		try
		{
			List<AudioManager4CRI.FileInfo> cacheCriAssetFileInfos;
			LuaObject.checkType<List<AudioManager4CRI.FileInfo>>(l, 2, out cacheCriAssetFileInfos);
			AudioManager4CRI.m_cacheCriAssetFileInfos = cacheCriAssetFileInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015ADC RID: 88796 RVA: 0x0059166C File Offset: 0x0058F86C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_FilenameOfAllFilesPath(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "AllFilesPath.txt");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015ADD RID: 88797 RVA: 0x005916B4 File Offset: 0x0058F8B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CacheFolderPath(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, AudioManager4CRI.CacheFolderPath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015ADE RID: 88798 RVA: 0x005916FC File Offset: 0x0058F8FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DownloadUrlRoot(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, AudioManager4CRI.DownloadUrlRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015ADF RID: 88799 RVA: 0x00591744 File Offset: 0x0058F944
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DownloadUrlRoot(IntPtr l)
	{
		int result;
		try
		{
			string downloadUrlRoot;
			LuaObject.checkType(l, 2, out downloadUrlRoot);
			AudioManager4CRI.DownloadUrlRoot = downloadUrlRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AE0 RID: 88800 RVA: 0x00591790 File Offset: 0x0058F990
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CRIProvider(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4CRI audioManager4CRI = (AudioManager4CRI)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, audioManager4CRI.CRIProvider);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AE1 RID: 88801 RVA: 0x005917E4 File Offset: 0x0058F9E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CRIProvider(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4CRI audioManager4CRI = (AudioManager4CRI)LuaObject.checkSelf(l);
			ICRIProvider criprovider;
			LuaObject.checkType<ICRIProvider>(l, 2, out criprovider);
			audioManager4CRI.CRIProvider = criprovider;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AE2 RID: 88802 RVA: 0x0059183C File Offset: 0x0058FA3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Instance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, AudioManager4CRI.Instance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AE3 RID: 88803 RVA: 0x00591884 File Offset: 0x0058FA84
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.AudioManager4CRI");
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.SetVolume);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache0);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.GetVolume);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache1);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache2);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.Pause);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache3);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.Uninitlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache4);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.Start);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache5);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache6);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.AllocSheetByCueName);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache7);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.GetCueLength);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache8);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.StopAll);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache9);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.SetMute);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cacheA);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.SetBackGroundMusicMute);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cacheB);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.PlayBackGroundMusic);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cacheC);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.StopBackGroundMusic);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cacheD);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.PlaySound);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cacheE);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.StopSound);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cacheF);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.PlaySpeech);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache10);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.StopSpeech);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache11);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.IsSpeechPlaying);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache12);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.PlayPlayerVoice);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache13);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.IsSoundPlaying);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache14);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.StopPlayerVoice);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache15);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.IsPlayerVoicePlaying);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache16);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.DownloadAudioFiles_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache17);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.CreateAudioManager_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache18);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.ParseFileInfosText_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache19);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.LoadTextFile_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache1A);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.LoadFileInfos_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache1B);
		string name = "m_criProviderType";
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.get_m_criProviderType);
		}
		LuaCSFunction get = Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache1C;
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.set_m_criProviderType);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache1D, false);
		string name2 = "m_clientCriAssetFileInfos";
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.get_m_clientCriAssetFileInfos);
		}
		LuaCSFunction get2 = Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache1E;
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.set_m_clientCriAssetFileInfos);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache1F, false);
		string name3 = "m_serverCriAssetFileInfos";
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.get_m_serverCriAssetFileInfos);
		}
		LuaCSFunction get3 = Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache20;
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.set_m_serverCriAssetFileInfos);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache21, false);
		string name4 = "m_cacheCriAssetFileInfos";
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.get_m_cacheCriAssetFileInfos);
		}
		LuaCSFunction get4 = Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache22;
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.set_m_cacheCriAssetFileInfos);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache23, false);
		string name5 = "FilenameOfAllFilesPath";
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.get_FilenameOfAllFilesPath);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache24, null, false);
		string name6 = "CacheFolderPath";
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.get_CacheFolderPath);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache25, null, false);
		string name7 = "DownloadUrlRoot";
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.get_DownloadUrlRoot);
		}
		LuaCSFunction get5 = Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache26;
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.set_DownloadUrlRoot);
		}
		LuaObject.addMember(l, name7, get5, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache27, false);
		string name8 = "CRIProvider";
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.get_CRIProvider);
		}
		LuaCSFunction get6 = Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache28;
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.set_CRIProvider);
		}
		LuaObject.addMember(l, name8, get6, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache29, true);
		string name9 = "Instance";
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.get_Instance);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache2A, null, false);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.<>f__mg$cache2B, typeof(AudioManager4CRI));
	}

	// Token: 0x0400C28F RID: 49807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C290 RID: 49808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C291 RID: 49809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C292 RID: 49810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400C293 RID: 49811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400C294 RID: 49812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400C295 RID: 49813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400C296 RID: 49814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400C297 RID: 49815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400C298 RID: 49816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400C299 RID: 49817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400C29A RID: 49818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400C29B RID: 49819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400C29C RID: 49820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400C29D RID: 49821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400C29E RID: 49822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400C29F RID: 49823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400C2A0 RID: 49824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400C2A1 RID: 49825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400C2A2 RID: 49826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400C2A3 RID: 49827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400C2A4 RID: 49828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400C2A5 RID: 49829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400C2A6 RID: 49830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400C2A7 RID: 49831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400C2A8 RID: 49832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400C2A9 RID: 49833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400C2AA RID: 49834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400C2AB RID: 49835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400C2AC RID: 49836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400C2AD RID: 49837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400C2AE RID: 49838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400C2AF RID: 49839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400C2B0 RID: 49840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400C2B1 RID: 49841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400C2B2 RID: 49842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400C2B3 RID: 49843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400C2B4 RID: 49844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400C2B5 RID: 49845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400C2B6 RID: 49846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400C2B7 RID: 49847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400C2B8 RID: 49848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400C2B9 RID: 49849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400C2BA RID: 49850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;
}
