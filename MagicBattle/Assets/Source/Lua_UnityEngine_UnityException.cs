using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001871 RID: 6257
[Preserve]
public class Lua_UnityEngine_UnityException : LuaObject
{
	// Token: 0x06024352 RID: 148306 RVA: 0x00CB868C File Offset: 0x00CB688C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				UnityException o = new UnityException();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 2)
			{
				string message;
				LuaObject.checkType(l, 2, out message);
				UnityException o = new UnityException(message);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 3)
			{
				string message2;
				LuaObject.checkType(l, 2, out message2);
				Exception innerException;
				LuaObject.checkType<Exception>(l, 3, out innerException);
				UnityException o = new UnityException(message2, innerException);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else
			{
				result = LuaObject.error(l, "New object failed.");
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024353 RID: 148307 RVA: 0x00CB875C File Offset: 0x00CB695C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UnityException");
		if (Lua_UnityEngine_UnityException.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UnityException.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UnityException.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_UnityException.<>f__mg$cache0, typeof(UnityException), typeof(SystemException));
	}

	// Token: 0x04019ECE RID: 106190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
