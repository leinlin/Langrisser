using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001111 RID: 4369
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_OnHideSound : LuaObject
{
	// Token: 0x06015B93 RID: 88979 RVA: 0x005971CC File Offset: 0x005953CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soundName(IntPtr l)
	{
		int result;
		try
		{
			OnHideSound onHideSound = (OnHideSound)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, onHideSound.m_soundName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B94 RID: 88980 RVA: 0x00597220 File Offset: 0x00595420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soundName(IntPtr l)
	{
		int result;
		try
		{
			OnHideSound onHideSound = (OnHideSound)LuaObject.checkSelf(l);
			string soundName;
			LuaObject.checkType(l, 2, out soundName);
			onHideSound.m_soundName = soundName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B95 RID: 88981 RVA: 0x00597278 File Offset: 0x00595478
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.OnHideSound");
		string name = "m_soundName";
		if (Lua_BlackJack_BJFramework_Runtime_OnHideSound.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_OnHideSound.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_OnHideSound.get_m_soundName);
		}
		LuaCSFunction get = Lua_BlackJack_BJFramework_Runtime_OnHideSound.<>f__mg$cache0;
		if (Lua_BlackJack_BJFramework_Runtime_OnHideSound.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_OnHideSound.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_OnHideSound.set_m_soundName);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_BJFramework_Runtime_OnHideSound.<>f__mg$cache1, true);
		LuaObject.createTypeMetatable(l, null, typeof(OnHideSound), typeof(MonoBehaviour));
	}

	// Token: 0x0400C353 RID: 50003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C354 RID: 50004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
