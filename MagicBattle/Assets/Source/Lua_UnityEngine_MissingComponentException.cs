using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200172E RID: 5934
[Preserve]
public class Lua_UnityEngine_MissingComponentException : LuaObject
{
	// Token: 0x060236A1 RID: 145057 RVA: 0x00C53458 File Offset: 0x00C51658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				MissingComponentException o = new MissingComponentException();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 2)
			{
				string message;
				LuaObject.checkType(l, 2, out message);
				MissingComponentException o = new MissingComponentException(message);
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
				MissingComponentException o = new MissingComponentException(message2, innerException);
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

	// Token: 0x060236A2 RID: 145058 RVA: 0x00C53528 File Offset: 0x00C51728
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.MissingComponentException");
		if (Lua_UnityEngine_MissingComponentException.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_MissingComponentException.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_MissingComponentException.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_MissingComponentException.<>f__mg$cache0, typeof(MissingComponentException), typeof(SystemException));
	}

	// Token: 0x040194A3 RID: 103587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
