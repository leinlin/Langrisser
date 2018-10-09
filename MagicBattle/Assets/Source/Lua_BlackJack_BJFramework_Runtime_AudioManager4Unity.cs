using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001107 RID: 4359
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity : LuaObject
{
	// Token: 0x06015AEC RID: 88812 RVA: 0x00592144 File Offset: 0x00590344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Pause(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4Unity audioManager4Unity = (AudioManager4Unity)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			audioManager4Unity.Pause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AED RID: 88813 RVA: 0x0059219C File Offset: 0x0059039C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnableDefaultAudioListener(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4Unity audioManager4Unity = (AudioManager4Unity)LuaObject.checkSelf(l);
			bool enable;
			LuaObject.checkType(l, 2, out enable);
			audioManager4Unity.EnableDefaultAudioListener(enable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AEE RID: 88814 RVA: 0x005921F4 File Offset: 0x005903F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StopAll(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4Unity audioManager4Unity = (AudioManager4Unity)LuaObject.checkSelf(l);
			audioManager4Unity.StopAll();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AEF RID: 88815 RVA: 0x00592240 File Offset: 0x00590440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetMute(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4Unity audioManager4Unity = (AudioManager4Unity)LuaObject.checkSelf(l);
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
			audioManager4Unity.SetMute(muteBackGroundMusic, muteSound, muteMovieBackGroundMusic, mutePlayerVoice, muteSpeech);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AF0 RID: 88816 RVA: 0x005922CC File Offset: 0x005904CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBackGroundMusicMute(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4Unity audioManager4Unity = (AudioManager4Unity)LuaObject.checkSelf(l);
			bool backGroundMusicMute;
			LuaObject.checkType(l, 2, out backGroundMusicMute);
			audioManager4Unity.SetBackGroundMusicMute(backGroundMusicMute);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AF1 RID: 88817 RVA: 0x00592324 File Offset: 0x00590524
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
				AudioManager4Unity audioManager4Unity = (AudioManager4Unity)LuaObject.checkSelf(l);
				string category;
				LuaObject.checkType(l, 2, out category);
				float volume;
				LuaObject.checkType(l, 3, out volume);
				bool isSmooth;
				LuaObject.checkType(l, 4, out isSmooth);
				audioManager4Unity.SetVolume(category, volume, isSmooth);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 5)
			{
				AudioManager4Unity audioManager4Unity2 = (AudioManager4Unity)LuaObject.checkSelf(l);
				float backGroundMusicVolume;
				LuaObject.checkType(l, 2, out backGroundMusicVolume);
				float soundVolume;
				LuaObject.checkType(l, 3, out soundVolume);
				float playerVoiceVolume;
				LuaObject.checkType(l, 4, out playerVoiceVolume);
				float speechVolume;
				LuaObject.checkType(l, 5, out speechVolume);
				audioManager4Unity2.SetVolume(backGroundMusicVolume, soundVolume, playerVoiceVolume, speechVolume);
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

	// Token: 0x06015AF2 RID: 88818 RVA: 0x0059241C File Offset: 0x0059061C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetVolume(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4Unity audioManager4Unity = (AudioManager4Unity)LuaObject.checkSelf(l);
			string category;
			LuaObject.checkType(l, 2, out category);
			float volume = audioManager4Unity.GetVolume(category);
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

	// Token: 0x06015AF3 RID: 88819 RVA: 0x00592480 File Offset: 0x00590680
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PlayBackGroundMusic(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4Unity audioManager4Unity = (AudioManager4Unity)LuaObject.checkSelf(l);
			string music;
			LuaObject.checkType(l, 2, out music);
			audioManager4Unity.PlayBackGroundMusic(music);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AF4 RID: 88820 RVA: 0x005924D8 File Offset: 0x005906D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopBackGroundMusic(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4Unity audioManager4Unity = (AudioManager4Unity)LuaObject.checkSelf(l);
			audioManager4Unity.StopBackGroundMusic();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AF5 RID: 88821 RVA: 0x00592524 File Offset: 0x00590724
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PlaySound(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, num, 2, typeof(AudioClip), typeof(float)))
			{
				AudioManager4Unity audioManager4Unity = (AudioManager4Unity)LuaObject.checkSelf(l);
				AudioClip sound;
				LuaObject.checkType<AudioClip>(l, 2, out sound);
				float volume;
				LuaObject.checkType(l, 3, out volume);
				audioManager4Unity.PlaySound(sound, volume);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string), typeof(float)))
			{
				AudioManager4Unity audioManager4Unity2 = (AudioManager4Unity)LuaObject.checkSelf(l);
				string sound2;
				LuaObject.checkType(l, 2, out sound2);
				float volume2;
				LuaObject.checkType(l, 3, out volume2);
				IAudioPlayback o = audioManager4Unity2.PlaySound(sound2, volume2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 5)
			{
				AudioManager4Unity audioManager4Unity3 = (AudioManager4Unity)LuaObject.checkSelf(l);
				string sound3;
				LuaObject.checkType(l, 2, out sound3);
				AudioClip audioClip;
				LuaObject.checkType<AudioClip>(l, 3, out audioClip);
				float volume3;
				LuaObject.checkType(l, 4, out volume3);
				bool allowRepeatedPlaying;
				LuaObject.checkType(l, 5, out allowRepeatedPlaying);
				audioManager4Unity3.PlaySound(sound3, audioClip, volume3, allowRepeatedPlaying);
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

	// Token: 0x06015AF6 RID: 88822 RVA: 0x0059269C File Offset: 0x0059089C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayPlayerVoice(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4Unity audioManager4Unity = (AudioManager4Unity)LuaObject.checkSelf(l);
			AudioClip sound;
			LuaObject.checkType<AudioClip>(l, 2, out sound);
			float volume;
			LuaObject.checkType(l, 3, out volume);
			audioManager4Unity.PlayPlayerVoice(sound, volume);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AF7 RID: 88823 RVA: 0x00592700 File Offset: 0x00590900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopSound(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				AudioManager4Unity audioManager4Unity = (AudioManager4Unity)LuaObject.checkSelf(l);
				string sound;
				LuaObject.checkType(l, 2, out sound);
				audioManager4Unity.StopSound(sound);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 1)
			{
				AudioManager4Unity audioManager4Unity2 = (AudioManager4Unity)LuaObject.checkSelf(l);
				audioManager4Unity2.StopSound();
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

	// Token: 0x06015AF8 RID: 88824 RVA: 0x005927AC File Offset: 0x005909AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopPlayerVoice(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4Unity audioManager4Unity = (AudioManager4Unity)LuaObject.checkSelf(l);
			audioManager4Unity.StopPlayerVoice();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AF9 RID: 88825 RVA: 0x005927F8 File Offset: 0x005909F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PlaySpeech(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string), typeof(float)))
			{
				AudioManager4Unity audioManager4Unity = (AudioManager4Unity)LuaObject.checkSelf(l);
				string sound;
				LuaObject.checkType(l, 2, out sound);
				float volume;
				LuaObject.checkType(l, 3, out volume);
				audioManager4Unity.PlaySpeech(sound, volume);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(AudioClip), typeof(float)))
			{
				AudioManager4Unity audioManager4Unity2 = (AudioManager4Unity)LuaObject.checkSelf(l);
				AudioClip sound2;
				LuaObject.checkType<AudioClip>(l, 2, out sound2);
				float volume2;
				LuaObject.checkType(l, 3, out volume2);
				audioManager4Unity2.PlaySpeech(sound2, volume2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function PlaySpeech to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AFA RID: 88826 RVA: 0x00592900 File Offset: 0x00590B00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StopSpeech(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4Unity audioManager4Unity = (AudioManager4Unity)LuaObject.checkSelf(l);
			audioManager4Unity.StopSpeech();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AFB RID: 88827 RVA: 0x0059294C File Offset: 0x00590B4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsSpeechPlaying(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4Unity audioManager4Unity = (AudioManager4Unity)LuaObject.checkSelf(l);
			bool b = audioManager4Unity.IsSpeechPlaying();
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

	// Token: 0x06015AFC RID: 88828 RVA: 0x005929A0 File Offset: 0x00590BA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsSoundPlaying(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4Unity audioManager4Unity = (AudioManager4Unity)LuaObject.checkSelf(l);
			bool b = audioManager4Unity.IsSoundPlaying();
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

	// Token: 0x06015AFD RID: 88829 RVA: 0x005929F4 File Offset: 0x00590BF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsPlayerVoicePlaying(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4Unity audioManager4Unity = (AudioManager4Unity)LuaObject.checkSelf(l);
			bool b = audioManager4Unity.IsPlayerVoicePlaying();
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

	// Token: 0x06015AFE RID: 88830 RVA: 0x00592A48 File Offset: 0x00590C48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Instance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, AudioManager4Unity.Instance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AFF RID: 88831 RVA: 0x00592A90 File Offset: 0x00590C90
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.AudioManager4Unity");
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.Pause);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache0);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.EnableDefaultAudioListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache1);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.StopAll);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache2);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.SetMute);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache3);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.SetBackGroundMusicMute);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache4);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.SetVolume);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache5);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.GetVolume);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache6);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.PlayBackGroundMusic);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache7);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.StopBackGroundMusic);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache8);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.PlaySound);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache9);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.PlayPlayerVoice);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cacheA);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.StopSound);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cacheB);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.StopPlayerVoice);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cacheC);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.PlaySpeech);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cacheD);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.StopSpeech);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cacheE);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.IsSpeechPlaying);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cacheF);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.IsSoundPlaying);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache10);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.IsPlayerVoicePlaying);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache11);
		string name = "Instance";
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.get_Instance);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.<>f__mg$cache12, null, false);
		LuaObject.createTypeMetatable(l, null, typeof(AudioManager4Unity));
	}

	// Token: 0x0400C2C0 RID: 49856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C2C1 RID: 49857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C2C2 RID: 49858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C2C3 RID: 49859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400C2C4 RID: 49860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400C2C5 RID: 49861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400C2C6 RID: 49862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400C2C7 RID: 49863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400C2C8 RID: 49864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400C2C9 RID: 49865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400C2CA RID: 49866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400C2CB RID: 49867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400C2CC RID: 49868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400C2CD RID: 49869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400C2CE RID: 49870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400C2CF RID: 49871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400C2D0 RID: 49872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400C2D1 RID: 49873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400C2D2 RID: 49874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;
}
