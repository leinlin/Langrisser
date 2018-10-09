using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200172F RID: 5935
[Preserve]
public class Lua_UnityEngine_MissingReferenceException : LuaObject
{
	// Token: 0x060236A4 RID: 145060 RVA: 0x00C53580 File Offset: 0x00C51780
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
				MissingReferenceException o = new MissingReferenceException();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 2)
			{
				string message;
				LuaObject.checkType(l, 2, out message);
				MissingReferenceException o = new MissingReferenceException(message);
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
				MissingReferenceException o = new MissingReferenceException(message2, innerException);
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

	// Token: 0x060236A5 RID: 145061 RVA: 0x00C53650 File Offset: 0x00C51850
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.MissingReferenceException");
		if (Lua_UnityEngine_MissingReferenceException.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_MissingReferenceException.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_MissingReferenceException.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_MissingReferenceException.<>f__mg$cache0, typeof(MissingReferenceException), typeof(SystemException));
	}

	// Token: 0x040194A4 RID: 103588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
