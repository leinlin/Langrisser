using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200129E RID: 4766
[Preserve]
public class Lua_BlackJack_ProjectL_Misc_AudioUtility : LuaObject
{
	// Token: 0x0601901D RID: 102429 RVA: 0x0071D7A0 File Offset: 0x0071B9A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			AudioUtility o = new AudioUtility();
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

	// Token: 0x0601901E RID: 102430 RVA: 0x0071D7E8 File Offset: 0x0071B9E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPlaySound(IntPtr l)
	{
		int result;
		try
		{
			AudioUtility audioUtility = (AudioUtility)LuaObject.checkSelf(l);
			OnClickSound e;
			LuaObject.checkType<OnClickSound>(l, 2, out e);
			string name;
			LuaObject.checkType(l, 3, out name);
			audioUtility.OnPlaySound(e, name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x0601901F RID: 102431 RVA: 0x0071D84C File Offset: 0x0071BA4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int NormalizeVolume_s(IntPtr l)
	{
		int result;
		try
		{
			float[] voiceData;
			LuaObject.checkArray<float>(l, 1, out voiceData);
			float[] a = AudioUtility.NormalizeVolume(voiceData);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, a);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019020 RID: 102432 RVA: 0x0071D8A0 File Offset: 0x0071BAA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClipAudioByLength_s(IntPtr l)
	{
		int result;
		try
		{
			AudioClip ac;
			LuaObject.checkType<AudioClip>(l, 1, out ac);
			float realRecordLength;
			LuaObject.checkType(l, 2, out realRecordLength);
			AudioClip o = AudioUtility.ClipAudioByLength(ac, realRecordLength);
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

	// Token: 0x06019021 RID: 102433 RVA: 0x0071D900 File Offset: 0x0071BB00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Pause_s(IntPtr l)
	{
		int result;
		try
		{
			bool pause;
			LuaObject.checkType(l, 1, out pause);
			AudioUtility.Pause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019022 RID: 102434 RVA: 0x0071D94C File Offset: 0x0071BB4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PlaySound_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(string)))
			{
				string name;
				LuaObject.checkType(l, 1, out name);
				IAudioPlayback o = AudioUtility.PlaySound(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(SoundTableId)))
			{
				SoundTableId id;
				LuaObject.checkEnum<SoundTableId>(l, 1, out id);
				AudioUtility.PlaySound(id);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(AudioClip)))
			{
				AudioClip a;
				LuaObject.checkType<AudioClip>(l, 1, out a);
				AudioUtility.PlaySound(a);
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

	// Token: 0x06019023 RID: 102435 RVA: 0x0071DA44 File Offset: 0x0071BC44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StopSound_s(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 1, out name);
			AudioUtility.StopSound(name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019024 RID: 102436 RVA: 0x0071DA90 File Offset: 0x0071BC90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SearchAndPlaySpineAnimEventSound_s(IntPtr l)
	{
		int result;
		try
		{
			string spineDataName;
			LuaObject.checkType(l, 1, out spineDataName);
			string animationName;
			LuaObject.checkType(l, 2, out animationName);
			string eventName;
			LuaObject.checkType(l, 3, out eventName);
			AudioUtility.SearchAndPlaySpineAnimEventSound(spineDataName, animationName, eventName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019025 RID: 102437 RVA: 0x0071DAF4 File Offset: 0x0071BCF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetVolume_s(IntPtr l)
	{
		int result;
		try
		{
			string category;
			LuaObject.checkType(l, 1, out category);
			float volume;
			LuaObject.checkType(l, 2, out volume);
			bool isSmooth;
			LuaObject.checkType(l, 3, out isSmooth);
			AudioUtility.SetVolume(category, volume, isSmooth);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019026 RID: 102438 RVA: 0x0071DB58 File Offset: 0x0071BD58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetVolume_s(IntPtr l)
	{
		int result;
		try
		{
			string category;
			LuaObject.checkType(l, 1, out category);
			float volume = AudioUtility.GetVolume(category);
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

	// Token: 0x06019027 RID: 102439 RVA: 0x0071DBAC File Offset: 0x0071BDAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MusicCategory(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Music_VolumeControl");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019028 RID: 102440 RVA: 0x0071DBF4 File Offset: 0x0071BDF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SoundCategory(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "SFX_VolumeControl");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019029 RID: 102441 RVA: 0x0071DC3C File Offset: 0x0071BE3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_VoiceCategory(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Voice_VolumeControl");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601902A RID: 102442 RVA: 0x0071DC84 File Offset: 0x0071BE84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StopAllMusic(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Action_StopMusic");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601902B RID: 102443 RVA: 0x0071DCCC File Offset: 0x0071BECC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StopAllVoice(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Action_StopVoice");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601902C RID: 102444 RVA: 0x0071DD14 File Offset: 0x0071BF14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AllSoundsCategory(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "All_Game_Sounds");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601902D RID: 102445 RVA: 0x0071DD5C File Offset: 0x0071BF5C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Misc.AudioUtility");
		if (Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_AudioUtility.OnPlaySound);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_AudioUtility.NormalizeVolume_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_AudioUtility.ClipAudioByLength_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_AudioUtility.Pause_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_AudioUtility.PlaySound_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_AudioUtility.StopSound_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_AudioUtility.SearchAndPlaySpineAnimEventSound_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_AudioUtility.SetVolume_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_AudioUtility.GetVolume_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cache8);
		string name = "MusicCategory";
		if (Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_AudioUtility.get_MusicCategory);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cache9, null, false);
		string name2 = "SoundCategory";
		if (Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_AudioUtility.get_SoundCategory);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cacheA, null, false);
		string name3 = "VoiceCategory";
		if (Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_AudioUtility.get_VoiceCategory);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cacheB, null, false);
		string name4 = "StopAllMusic";
		if (Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_AudioUtility.get_StopAllMusic);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cacheC, null, false);
		string name5 = "StopAllVoice";
		if (Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_AudioUtility.get_StopAllVoice);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cacheD, null, false);
		string name6 = "AllSoundsCategory";
		if (Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_AudioUtility.get_AllSoundsCategory);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cacheE, null, false);
		if (Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_AudioUtility.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Misc_AudioUtility.<>f__mg$cacheF, typeof(AudioUtility));
	}

	// Token: 0x0400F4C3 RID: 62659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F4C4 RID: 62660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F4C5 RID: 62661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F4C6 RID: 62662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F4C7 RID: 62663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F4C8 RID: 62664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F4C9 RID: 62665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F4CA RID: 62666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F4CB RID: 62667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F4CC RID: 62668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F4CD RID: 62669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F4CE RID: 62670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F4CF RID: 62671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F4D0 RID: 62672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F4D1 RID: 62673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F4D2 RID: 62674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;
}
