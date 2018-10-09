using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200111F RID: 4383
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_SoundPlayer : LuaObject
{
	// Token: 0x06015C68 RID: 89192 RVA: 0x0059D420 File Offset: 0x0059B620
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PlaySound(IntPtr l)
	{
		int result;
		try
		{
			SoundPlayer soundPlayer = (SoundPlayer)LuaObject.checkSelf(l);
			string soundName;
			LuaObject.checkType(l, 2, out soundName);
			soundPlayer.PlaySound(soundName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C69 RID: 89193 RVA: 0x0059D478 File Offset: 0x0059B678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_clickedTester(IntPtr l)
	{
		int result;
		try
		{
			SoundPlayer soundPlayer = (SoundPlayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soundPlayer.m_clickedTester);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C6A RID: 89194 RVA: 0x0059D4CC File Offset: 0x0059B6CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_clickedTester(IntPtr l)
	{
		int result;
		try
		{
			SoundPlayer soundPlayer = (SoundPlayer)LuaObject.checkSelf(l);
			ClickedTester clickedTester;
			LuaObject.checkType<ClickedTester>(l, 2, out clickedTester);
			soundPlayer.m_clickedTester = clickedTester;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C6B RID: 89195 RVA: 0x0059D524 File Offset: 0x0059B724
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.SoundPlayer");
		if (Lua_BlackJack_BJFramework_Runtime_SoundPlayer.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_SoundPlayer.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_SoundPlayer.PlaySound);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_SoundPlayer.<>f__mg$cache0);
		string name = "m_clickedTester";
		if (Lua_BlackJack_BJFramework_Runtime_SoundPlayer.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_SoundPlayer.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_SoundPlayer.get_m_clickedTester);
		}
		LuaCSFunction get = Lua_BlackJack_BJFramework_Runtime_SoundPlayer.<>f__mg$cache1;
		if (Lua_BlackJack_BJFramework_Runtime_SoundPlayer.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_SoundPlayer.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_SoundPlayer.set_m_clickedTester);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_BJFramework_Runtime_SoundPlayer.<>f__mg$cache2, true);
		LuaObject.createTypeMetatable(l, null, typeof(SoundPlayer), typeof(MonoBehaviour));
	}

	// Token: 0x0400C40C RID: 50188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C40D RID: 50189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C40E RID: 50190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
