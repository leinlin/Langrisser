using System;
using System.Collections;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Lua;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200110A RID: 4362
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_Lua_LuaCoroutineChecker : LuaObject
{
	// Token: 0x06015B2C RID: 88876 RVA: 0x00594280 File Offset: 0x00592480
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Awake(IntPtr l)
	{
		int result;
		try
		{
			LuaCoroutineChecker luaCoroutineChecker = (LuaCoroutineChecker)LuaObject.checkSelf(l);
			luaCoroutineChecker.m_luaExportHelper.Awake();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B2D RID: 88877 RVA: 0x005942D4 File Offset: 0x005924D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Start(IntPtr l)
	{
		int result;
		try
		{
			LuaCoroutineChecker luaCoroutineChecker = (LuaCoroutineChecker)LuaObject.checkSelf(l);
			luaCoroutineChecker.m_luaExportHelper.Start();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B2E RID: 88878 RVA: 0x00594328 File Offset: 0x00592528
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int TestCoroutine(IntPtr l)
	{
		int result;
		try
		{
			LuaCoroutineChecker luaCoroutineChecker = (LuaCoroutineChecker)LuaObject.checkSelf(l);
			IEnumerator o = luaCoroutineChecker.m_luaExportHelper.TestCoroutine();
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

	// Token: 0x06015B2F RID: 88879 RVA: 0x00594384 File Offset: 0x00592584
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.Lua.LuaCoroutineChecker");
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaCoroutineChecker.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaCoroutineChecker.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaCoroutineChecker.Awake);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaCoroutineChecker.<>f__mg$cache0);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaCoroutineChecker.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaCoroutineChecker.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaCoroutineChecker.Start);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaCoroutineChecker.<>f__mg$cache1);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaCoroutineChecker.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaCoroutineChecker.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaCoroutineChecker.TestCoroutine);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaCoroutineChecker.<>f__mg$cache2);
		LuaObject.createTypeMetatable(l, null, typeof(LuaCoroutineChecker), typeof(MonoBehaviour));
	}

	// Token: 0x0400C2FA RID: 49914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C2FB RID: 49915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C2FC RID: 49916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
