using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017EB RID: 6123
[Preserve]
public class Lua_UnityEngine_StackTraceUtility : LuaObject
{
	// Token: 0x06023DD1 RID: 146897 RVA: 0x00C921A8 File Offset: 0x00C903A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExtractStackTrace_s(IntPtr l)
	{
		int result;
		try
		{
			string s = StackTraceUtility.ExtractStackTrace();
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

	// Token: 0x06023DD2 RID: 146898 RVA: 0x00C921F0 File Offset: 0x00C903F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExtractStringFromException_s(IntPtr l)
	{
		int result;
		try
		{
			object exception;
			LuaObject.checkType<object>(l, 1, out exception);
			string s = StackTraceUtility.ExtractStringFromException(exception);
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

	// Token: 0x06023DD3 RID: 146899 RVA: 0x00C92244 File Offset: 0x00C90444
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.StackTraceUtility");
		if (Lua_UnityEngine_StackTraceUtility.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_StackTraceUtility.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_StackTraceUtility.ExtractStackTrace_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_StackTraceUtility.<>f__mg$cache0);
		if (Lua_UnityEngine_StackTraceUtility.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_StackTraceUtility.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_StackTraceUtility.ExtractStringFromException_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_StackTraceUtility.<>f__mg$cache1);
		LuaObject.createTypeMetatable(l, null, typeof(StackTraceUtility));
	}

	// Token: 0x04019A59 RID: 105049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019A5A RID: 105050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
