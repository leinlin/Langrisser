using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001106 RID: 4358
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI_PlaybacksOfSheet : LuaObject
{
	// Token: 0x06015AE5 RID: 88805 RVA: 0x00591EC8 File Offset: 0x005900C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4CRI.PlaybacksOfSheet o = new AudioManager4CRI.PlaybacksOfSheet();
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

	// Token: 0x06015AE6 RID: 88806 RVA: 0x00591F10 File Offset: 0x00590110
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playbacks(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4CRI.PlaybacksOfSheet playbacksOfSheet = (AudioManager4CRI.PlaybacksOfSheet)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playbacksOfSheet.m_playbacks);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AE7 RID: 88807 RVA: 0x00591F64 File Offset: 0x00590164
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playbacks(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4CRI.PlaybacksOfSheet playbacksOfSheet = (AudioManager4CRI.PlaybacksOfSheet)LuaObject.checkSelf(l);
			List<IAudioPlayback> playbacks;
			LuaObject.checkType<List<IAudioPlayback>>(l, 2, out playbacks);
			playbacksOfSheet.m_playbacks = playbacks;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AE8 RID: 88808 RVA: 0x00591FBC File Offset: 0x005901BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_removeTime(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4CRI.PlaybacksOfSheet playbacksOfSheet = (AudioManager4CRI.PlaybacksOfSheet)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playbacksOfSheet.m_removeTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AE9 RID: 88809 RVA: 0x00592010 File Offset: 0x00590210
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_removeTime(IntPtr l)
	{
		int result;
		try
		{
			AudioManager4CRI.PlaybacksOfSheet playbacksOfSheet = (AudioManager4CRI.PlaybacksOfSheet)LuaObject.checkSelf(l);
			float removeTime;
			LuaObject.checkType(l, 2, out removeTime);
			playbacksOfSheet.m_removeTime = removeTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AEA RID: 88810 RVA: 0x00592068 File Offset: 0x00590268
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.AudioManager4CRI.PlaybacksOfSheet");
		string name = "m_playbacks";
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI_PlaybacksOfSheet.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI_PlaybacksOfSheet.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI_PlaybacksOfSheet.get_m_playbacks);
		}
		LuaCSFunction get = Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI_PlaybacksOfSheet.<>f__mg$cache0;
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI_PlaybacksOfSheet.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI_PlaybacksOfSheet.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI_PlaybacksOfSheet.set_m_playbacks);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI_PlaybacksOfSheet.<>f__mg$cache1, true);
		string name2 = "m_removeTime";
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI_PlaybacksOfSheet.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI_PlaybacksOfSheet.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI_PlaybacksOfSheet.get_m_removeTime);
		}
		LuaCSFunction get2 = Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI_PlaybacksOfSheet.<>f__mg$cache2;
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI_PlaybacksOfSheet.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI_PlaybacksOfSheet.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI_PlaybacksOfSheet.set_m_removeTime);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI_PlaybacksOfSheet.<>f__mg$cache3, true);
		if (Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI_PlaybacksOfSheet.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI_PlaybacksOfSheet.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI_PlaybacksOfSheet.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI_PlaybacksOfSheet.<>f__mg$cache4, typeof(AudioManager4CRI.PlaybacksOfSheet));
	}

	// Token: 0x0400C2BB RID: 49851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C2BC RID: 49852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C2BD RID: 49853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C2BE RID: 49854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400C2BF RID: 49855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
