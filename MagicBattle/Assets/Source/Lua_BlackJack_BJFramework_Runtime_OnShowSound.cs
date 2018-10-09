using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001113 RID: 4371
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_OnShowSound : LuaObject
{
	// Token: 0x06015B9D RID: 88989 RVA: 0x0059751C File Offset: 0x0059571C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_clickedTester(IntPtr l)
	{
		int result;
		try
		{
			OnShowSound onShowSound = (OnShowSound)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, onShowSound.m_clickedTester);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B9E RID: 88990 RVA: 0x00597570 File Offset: 0x00595770
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_clickedTester(IntPtr l)
	{
		int result;
		try
		{
			OnShowSound onShowSound = (OnShowSound)LuaObject.checkSelf(l);
			ClickedTester clickedTester;
			LuaObject.checkType<ClickedTester>(l, 2, out clickedTester);
			onShowSound.m_clickedTester = clickedTester;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B9F RID: 88991 RVA: 0x005975C8 File Offset: 0x005957C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_soundName(IntPtr l)
	{
		int result;
		try
		{
			OnShowSound onShowSound = (OnShowSound)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, onShowSound.m_soundName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BA0 RID: 88992 RVA: 0x0059761C File Offset: 0x0059581C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_soundName(IntPtr l)
	{
		int result;
		try
		{
			OnShowSound onShowSound = (OnShowSound)LuaObject.checkSelf(l);
			string soundName;
			LuaObject.checkType(l, 2, out soundName);
			onShowSound.m_soundName = soundName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BA1 RID: 88993 RVA: 0x00597674 File Offset: 0x00595874
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.OnShowSound");
		string name = "m_clickedTester";
		if (Lua_BlackJack_BJFramework_Runtime_OnShowSound.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_OnShowSound.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_OnShowSound.get_m_clickedTester);
		}
		LuaCSFunction get = Lua_BlackJack_BJFramework_Runtime_OnShowSound.<>f__mg$cache0;
		if (Lua_BlackJack_BJFramework_Runtime_OnShowSound.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_OnShowSound.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_OnShowSound.set_m_clickedTester);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_BJFramework_Runtime_OnShowSound.<>f__mg$cache1, true);
		string name2 = "m_soundName";
		if (Lua_BlackJack_BJFramework_Runtime_OnShowSound.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_OnShowSound.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_OnShowSound.get_m_soundName);
		}
		LuaCSFunction get2 = Lua_BlackJack_BJFramework_Runtime_OnShowSound.<>f__mg$cache2;
		if (Lua_BlackJack_BJFramework_Runtime_OnShowSound.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_OnShowSound.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_OnShowSound.set_m_soundName);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_BJFramework_Runtime_OnShowSound.<>f__mg$cache3, true);
		LuaObject.createTypeMetatable(l, null, typeof(OnShowSound), typeof(MonoBehaviour));
	}

	// Token: 0x0400C359 RID: 50009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C35A RID: 50010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C35B RID: 50011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C35C RID: 50012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
