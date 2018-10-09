using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Assertions;
using UnityEngine.Scripting;

// Token: 0x0200162E RID: 5678
[Preserve]
public class Lua_UnityEngine_Assertions_AssertionException : LuaObject
{
	// Token: 0x06022BDD RID: 142301 RVA: 0x00BFDDEC File Offset: 0x00BFBFEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string message;
			LuaObject.checkType(l, 2, out message);
			string userMessage;
			LuaObject.checkType(l, 3, out userMessage);
			AssertionException o = new AssertionException(message, userMessage);
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

	// Token: 0x06022BDE RID: 142302 RVA: 0x00BFDE4C File Offset: 0x00BFC04C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Message(IntPtr l)
	{
		int result;
		try
		{
			AssertionException ex = (AssertionException)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ex.Message);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BDF RID: 142303 RVA: 0x00BFDEA0 File Offset: 0x00BFC0A0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Assertions.AssertionException");
		string name = "Message";
		if (Lua_UnityEngine_Assertions_AssertionException.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Assertions_AssertionException.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Assertions_AssertionException.get_Message);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Assertions_AssertionException.<>f__mg$cache0, null, true);
		if (Lua_UnityEngine_Assertions_AssertionException.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Assertions_AssertionException.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Assertions_AssertionException.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Assertions_AssertionException.<>f__mg$cache1, typeof(AssertionException), typeof(Exception));
	}

	// Token: 0x04018BDF RID: 101343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018BE0 RID: 101344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
