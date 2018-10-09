using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x02001110 RID: 4368
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_OnClickSound : LuaObject
{
	// Token: 0x06015B8E RID: 88974 RVA: 0x00597024 File Offset: 0x00595224
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			OnClickSound onClickSound = (OnClickSound)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			onClickSound.OnPointerClick(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B8F RID: 88975 RVA: 0x0059707C File Offset: 0x0059527C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_clickSoundName(IntPtr l)
	{
		int result;
		try
		{
			OnClickSound onClickSound = (OnClickSound)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, onClickSound.m_clickSoundName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B90 RID: 88976 RVA: 0x005970D0 File Offset: 0x005952D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_clickSoundName(IntPtr l)
	{
		int result;
		try
		{
			OnClickSound onClickSound = (OnClickSound)LuaObject.checkSelf(l);
			string clickSoundName;
			LuaObject.checkType(l, 2, out clickSoundName);
			onClickSound.m_clickSoundName = clickSoundName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B91 RID: 88977 RVA: 0x00597128 File Offset: 0x00595328
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.OnClickSound");
		if (Lua_BlackJack_BJFramework_Runtime_OnClickSound.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_OnClickSound.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_OnClickSound.OnPointerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_OnClickSound.<>f__mg$cache0);
		string name = "m_clickSoundName";
		if (Lua_BlackJack_BJFramework_Runtime_OnClickSound.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_OnClickSound.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_OnClickSound.get_m_clickSoundName);
		}
		LuaCSFunction get = Lua_BlackJack_BJFramework_Runtime_OnClickSound.<>f__mg$cache1;
		if (Lua_BlackJack_BJFramework_Runtime_OnClickSound.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_OnClickSound.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_OnClickSound.set_m_clickSoundName);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_BJFramework_Runtime_OnClickSound.<>f__mg$cache2, true);
		LuaObject.createTypeMetatable(l, null, typeof(OnClickSound), typeof(MonoBehaviour));
	}

	// Token: 0x0400C350 RID: 50000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C351 RID: 50001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C352 RID: 50002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
