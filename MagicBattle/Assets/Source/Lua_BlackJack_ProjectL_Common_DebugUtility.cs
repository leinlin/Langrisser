using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001218 RID: 4632
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DebugUtility : LuaObject
{
	// Token: 0x0601809F RID: 98463 RVA: 0x006AB3E0 File Offset: 0x006A95E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DebugUtility o = new DebugUtility();
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

	// Token: 0x060180A0 RID: 98464 RVA: 0x006AB428 File Offset: 0x006A9628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Log_s(IntPtr l)
	{
		int result;
		try
		{
			object obj;
			LuaObject.checkType<object>(l, 1, out obj);
			DebugUtility.Log(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180A1 RID: 98465 RVA: 0x006AB474 File Offset: 0x006A9674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogWarning_s(IntPtr l)
	{
		int result;
		try
		{
			object obj;
			LuaObject.checkType<object>(l, 1, out obj);
			DebugUtility.LogWarning(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180A2 RID: 98466 RVA: 0x006AB4C0 File Offset: 0x006A96C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int LogError_s(IntPtr l)
	{
		int result;
		try
		{
			object obj;
			LuaObject.checkType<object>(l, 1, out obj);
			DebugUtility.LogError(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180A3 RID: 98467 RVA: 0x006AB50C File Offset: 0x006A970C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DebugUtility");
		if (Lua_BlackJack_ProjectL_Common_DebugUtility.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DebugUtility.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DebugUtility.Log_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DebugUtility.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DebugUtility.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DebugUtility.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DebugUtility.LogWarning_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DebugUtility.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DebugUtility.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DebugUtility.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DebugUtility.LogError_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DebugUtility.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DebugUtility.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DebugUtility.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DebugUtility.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DebugUtility.<>f__mg$cache3, typeof(DebugUtility));
	}

	// Token: 0x0400E651 RID: 58961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E652 RID: 58962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E653 RID: 58963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E654 RID: 58964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
